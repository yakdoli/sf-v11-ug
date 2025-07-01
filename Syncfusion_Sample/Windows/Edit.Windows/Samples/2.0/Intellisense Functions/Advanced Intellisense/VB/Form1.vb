#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System.Diagnostics
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text.RegularExpressions
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Implementation


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    #Region "Class Private Members"
    '/ <summary>
    '/ Hashtable with descriptions assigned to the lexem configuration.
    '/ </summary>
    Private m_MethodComments As New Hashtable()
    '/ <summary>
    '/ Hashtable of the prompts list assigned to the lexem configuration.
    '/ </summary>
    Private m_MethodPrompts As New Hashtable()
    #End Region
    Private components As System.ComponentModel.IContainer
    
    #Region "Class Controls"
    
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private menuItem7 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Private WithEvents editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private imageList1 As System.Windows.Forms.ImageList
    #End Region
    
    #Region "Class Initialization/Finalization"
    
    '/ <summary>
    '/ Creates and initiallizes form.
    '/ </summary>
    Public Sub New()
        InitializeComponent()
        
        ' Creates new file using C# language configuration.
        editControl1.NewFile(editControl1.Configurator("C#"))
        
        ' Creates format for methods coloring.
        Dim formatMethod As ISnippetFormat = editControl1.Language.Add("Method", "Text")
        formatMethod.FontColor = Color.HotPink
        
        ' Creates format for properties coloring.
        Dim formatProperty As ISnippetFormat = editControl1.Language.Add("Property", "Text")
        formatProperty.FontColor = Color.Goldenrod
        
        ' Disables ContextChoiceList dropping after dot in global context.
        Dim lexemDot_ As ConfigLexem = GetConfigLexem(CType(editControl1.Language, IConfigLexem), ".")
        lexemDot_.DropContextChoiceList = False
        
        ' Adds "this" word processing for global context.
        Dim lexemThis As ConfigLexem = GetConfigLexem(CType(editControl1.Language, IConfigLexem), "this")
        lexemThis.Type = FormatType.String 
        ' "this" starts it`s own context. It does not have EndBlock specified, so the first unprocessed token will force parser to exit from "this"'s context.
        lexemThis.IsComplex = True
        
        ' Adds "." processing for "this" context: if "this" is followed by "." then the dot will
        ' have "lexemDot" configuration.
        Dim lexemDot As ConfigLexem = GetConfigLexem(CType(lexemThis, IConfigLexem), ".")
        lexemDot.Type = FormatType.[Operator]
        ' "." can drop context choice list
        lexemDot.DropContextChoiceList = True
        lexemDot.IsComplex = True
        
        ' Add configuration for "Property1"
        Dim this_Property1 As ConfigLexem = GetConfigLexem(CType(lexemDot, IConfigLexem), "Property1")
        this_Property1.Type = FormatType.Custom
        this_Property1.FormatName = "Property"
        this_Property1.IsComplex = True
        
        ' Add configuration for "." after "Property1"
        Dim propertyDot As ConfigLexem = GetConfigLexem(CType(this_Property1, IConfigLexem), ".")
        propertyDot.Type = FormatType.[Operator]
        propertyDot.DropContextChoiceList = True
        propertyDot.IsComplex = True
        propertyDot.Priority = 10
        
        ' Add "Method1" configuration after "this.Property1."
        Dim property_Method1 As ConfigLexem = GetConfigLexem(CType(propertyDot, IConfigLexem), "Method1")
        property_Method1.Type = FormatType.Custom
        property_Method1.FormatName = "Method"
        property_Method1.IsComplex = True
        
        ' Add "Method2" configuration after "this.Property1."
        Dim property_Method2 As ConfigLexem = GetConfigLexem(CType(propertyDot, IConfigLexem), "Method2")
        property_Method2.Type = FormatType.Custom
        property_Method2.FormatName = "Method"
        property_Method2.IsComplex = True
        
        ' Add "TestMethod" configuration after "this."
        Dim this_Method1 As ConfigLexem = GetConfigLexem(CType(lexemDot, IConfigLexem), "TestMethod")
        this_Method1.Type = FormatType.Custom
        this_Method1.FormatName = "Method"
        ' needed for processing "(" and ")" next.
        this_Method1.IsComplex = True
        
        ' Add "GenerateMap" configuration after "this."
        Dim this_Method2 As ConfigLexem = GetConfigLexem(CType(lexemDot, IConfigLexem), "GenerateMap")
        this_Method2.Type = FormatType.Custom
        this_Method2.FormatName = "Method"
        ' needed for processing "(" and ")" next.
        this_Method2.IsComplex = True
        
        ' Adds processing of the "(" after "this.Property1.Method1"
        Dim this_Method1_Braces As ConfigLexem = GetConfigLexem(CType(this_Method1, IConfigLexem), "(")
        'Processing is done until ")" is found.
        this_Method1_Braces.EndBlock = ")"
        this_Method1_Braces.Type = FormatType.[Operator]
        ' Lexem with this config starts it`s own context.
        this_Method1_Braces.IsComplex = True
        ' ContextPrompt is dropped after entering "("
        this_Method1_Braces.DropContextPrompt = True
        ' Needed to override "(" from the global context. 
        this_Method1_Braces.Priority = 10
        
        Dim this_Method2_Braces As ConfigLexem = GetConfigLexem(CType(this_Method2, IConfigLexem), "(")
        this_Method2_Braces.EndBlock = ")"
        this_Method2_Braces.Type = FormatType.[Operator]
        this_Method2_Braces.IsComplex = True
        this_Method2_Braces.DropContextPrompt = True
        this_Method2_Braces.Priority = 10
        
        ' ResetCaches needed for resetting all configuration caches. Without ResetCaches user changes will not be used.
        editControl1.Language.ResetCaches()
        
        ' Fills collection of descriptions for lexemes with different configurations.
        m_MethodComments(this_Method1.ID) = "Test description"
        m_MethodComments(this_Method2.ID) = "Generates Some Specific Map....or just tests descriptions in context choice list"
        m_MethodComments(this_Property1.ID) = "The only one property" + vbLf + "It has multiline description"
        m_MethodComments(property_Method1.ID) = "Method 1"
        m_MethodComments(property_Method2.ID) = "Method 2"
        
        ' Fills collection of prompts, assigned to different lexeme configurations.
        m_MethodPrompts(this_Method1.ID) = New DictionaryEntry() {New DictionaryEntry(this_Method1.BeginBlock + "()", m_MethodComments(this_Method1.ID)), New DictionaryEntry(this_Method1.BeginBlock + "( int testData )", CStr(m_MethodComments(this_Method1.ID)) + vbLf + "testData should be specified"), New DictionaryEntry(this_Method1.BeginBlock + "( int testData, string testParam )", CStr(m_MethodComments(this_Method1.ID)) + vbLf + "testData and testParam should be specified")}
        
        m_MethodPrompts(this_Method2.ID) = New DictionaryEntry() {New DictionaryEntry(this_Method2.BeginBlock + "()", m_MethodComments(this_Method2.ID))}
        
        ' Sets text to be displayed.
        editControl1.Text = "/* To see how the Context Choice list works, type ""this."" or ""this.Property1."" (If you have closed the popup window, you can re-open it with CTRL+Space shortcut)" + vbCr + vbLf + vbCr + vbLf + "To see how the Context ToolTip works move the mouse over some text and you will see information tooltip about text under cursor if available." + vbCr + vbLf + vbCr + vbLf + "To see how the Context Prompt feature works, type ""this.TestMethod("" and you will see list of the overloaded implementations of ""TestMethod"" method. */" + vbCr + vbLf + vbCr + vbLf + "// Examples:  " + vbCr + vbLf + "this. //<- Press CTRL+Space to display the Context Choice list." + vbCr + vbLf + vbCr + vbLf + "this.TestMethod( //<- Press CTRL+SHIFT+Space after ""("" to display the Context Prompt items." + vbCr + vbLf + vbCr + vbLf + "this.GenerateMap(); // Move the mouse over ""GenerateMap"" to see the Context Tooltip." + vbCr + vbLf
        
        ' Resets undo buffer, so the user cannot undo setting of the text.
        editControl1.ResetUndoInfo()
    End Sub 'New
    
    
    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose
    
    #End Region
    
    #Region "Windows Form Designer generated code"
    
    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Config1 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem2 = New System.Windows.Forms.MenuItem
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.menuItem4 = New System.Windows.Forms.MenuItem
        Me.menuItem5 = New System.Windows.Forms.MenuItem
        Me.menuItem6 = New System.Windows.Forms.MenuItem
        Me.menuItem7 = New System.Windows.Forms.MenuItem
        Me.menuItem8 = New System.Windows.Forms.MenuItem
        Me.menuItem9 = New System.Windows.Forms.MenuItem
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.menuItem9})
        Me.menuItem1.Text = "File"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "New"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "Open"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 2
        Me.menuItem4.Text = "-"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 3
        Me.menuItem5.Text = "Save"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 4
        Me.menuItem6.Text = "SaveAs"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 5
        Me.menuItem7.Text = "-"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 6
        Me.menuItem8.Text = "Close"
        '
        'menuItem9
        '
        Me.menuItem9.Index = 7
        Me.menuItem9.Text = "Exit"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        '
        'editControl1
        '
        Me.editControl1.Configurator = Config1
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.FilterAutoCompleteItems = False
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.editControl1.Location = New System.Drawing.Point(0, 0)
        Me.editControl1.Name = "editControl1"
        Me.editControl1.SaveOnClose = False
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowSelectionMargin = False
        Me.editControl1.Size = New System.Drawing.Size(544, 457)
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.TabIndex = 0
        Me.editControl1.Text = "editControl1"
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.VisualColumn = 1
        Me.editControl1.WordWrap = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 457)
        Me.Controls.Add(Me.editControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Advanced Intellisense"
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
    #End Region
    
    #Region "MAIN Method"
    
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()>  _
    Shared Sub Main()
Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub 'Main
    #End Region
    
    #Region "Class Helper Methods"
    
    '/ <summary>
    '/ Looks for the configuration with given name in the specified container.
    '/ </summary>
    '/ <param name="container"></param>
    '/ <param name="lexemStart"></param>
    '/ <returns></returns>
    Private Function GetConfigLexem(container As IConfigLexem, lexemStart As String) As ConfigLexem
        Dim lexem As ConfigLexem = Nothing
        
        ' Searches configuration.
        Dim lexemTemp As IConfigLexem
        For Each lexemTemp In  container.SubLexems
            If lexemTemp.IsEqualToBegin(lexemStart) Then
                lexem = lexemTemp 
                Exit For
            End If
        Next lexemTemp
        
        ' If it was not found, then create new one.
        If lexem Is Nothing Then
            lexem = New ConfigLexem(lexemStart, "", FormatType.Text, False)
            container.SubLexems.Add(lexem)
            
            ' ParentConfig will be updated in ResetCaches, but the newly created configuration cannot be used without ParentConfig being set.
            lexem.ParentConfig = container
        End If
        
        Return lexem
    End Function 'GetConfigLexem
    
    
    '/ <summary>
    '/ Looks for the first lexeme on the left with DropContextChoiceList set to true in config
    '/ </summary>
    '/ <returns></returns>
    Private Function FindDropper() As ILexem
        Dim line As ILexemLine = editControl1.CurrentLineInstance
        
        If line Is Nothing Then
            Return Nothing
        End If 
        Dim lexem As ILexem = line.FindLexemByColumn(editControl1.CurrentColumn)
        
        If lexem Is Nothing Then
            ' If we are in the virtual space in the line.
            If editControl1.CurrentColumn > 1 Then
                lexem = line.FindLexemByColumn(line.LineLength)
            End If 
            If lexem Is Nothing Then
                Return Nothing
            End If
        End If 
        ' If current lexem is dropper itself
        If lexem.Config.DropContextChoiceList Then
            Return lexem
        End If 
        Dim index As Integer = line.LineLexems.IndexOf(lexem)
        
        While index > 0 AndAlso Not lexem.Config.DropContextChoiceList
            index -= 1
            lexem = line.LineLexems(index)
        End While

        If index <= 0 Then
            lexem = Nothing
        End If
        Return lexem
    End Function 'FindDropper
    
    
    '/ <summary>
    '/ Gets list of the items to be put to the context choice list.
    '/ </summary>
    '/ <returns></returns>
    Private Function GetList() As ICollection
        ' Gets neares context choice list "dropper"
        Dim lexem As ILexem = FindDropper()
        
        Dim list As New ArrayList()
        If lexem Is Nothing Then
            Return list
        End If 
        ' Adds to the resulting list all lexeme configuratios with "Method" and "Property" formats.
        Dim confLex As IConfigLexem
        For Each confLex In  lexem.Config.SubLexems
            If confLex.Format.Name = "Method" Then
                list.Add(confLex)
            End If 
            If confLex.Format.Name = "Property" Then
                list.Add(confLex)
            End If
        Next confLex 
        Return list
    End Function 'GetList
    
    
    '/ <summary>
    '/ Parses contextprompt item's subject and adds all its parameters to the collection of bolded items.
    '/ </summary>
    '/ <param name="item"></param>
    Private Sub ParseContectPromptSubject(item As ContextPromptItem)
        ' Example: MethodName( int param, string param2 )
        ' will be matched as : 1) "int param", 2) "string param2"
        Dim regex As New Regex("\(\s*((?<param>[^,]+)\s*\,*\s*)*\s*\)")
        Dim match As Match = regex.Match(item.Subject)
        
        If match.Success Then
            Dim param As Capture
            For Each param In  match.Groups("param").Captures
                ' Add matches to the list of bolded items.
                ' Every bolded item has such properties:
                ' BoldTextStart - starting index of the bolded substring of the subject
                ' BoldTextLength - length of the bolded substring of the subject
                ' Description - description, that should be shown when you select some bolded item.
                ' Note: bolded items can not be selected automatically, 
                ' user should select them while processing ContextPromptUpdate event. 
                Dim itemBolded As ContextPromptBoldTextItem = item.BoldedItems.Add(param.Index, param.Length, param.Value)
            Next param
        End If
    End Sub 'ParseContectPromptSubject
    
    #End Region
    
    #Region "Class Event Handlers"
    
    '/ <summary>
    '/ Checks wether ContextChoice menu can be dropped.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub editControl1_ContextChoiceBeforeOpen(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles editControl1.ContextPromptBeforeOpen, editControl1.ContextChoiceBeforeOpen
        e.Cancel = FindDropper() Is Nothing
    End Sub 'editControl1_ContextChoiceBeforeOpen
    
    '/ <summary>
    '/ Fills ContextChoiceMenu according to the current context.
    '/ </summary>
    '/ <param name="form"></param>
    Private Sub editControl1_ContextChoiceOpen(controller As IContextChoiceController) Handles editControl1.ContextChoiceOpen
        ' Gets the list of Method and Property configurations for current context.
        Dim list As ICollection = GetList()
        
        Dim imageIndex As Integer = 0
        ' Adds configuration BeginBlocks and associated descriptions to the Context Choice List.
        Dim conf As IConfigLexem
        For Each conf In  list
            controller.Items.Add(conf.BeginBlock, CStr(m_MethodComments(conf.ID)), Me.editControl1.ContextChoiceController.Images(("Image" + imageIndex.ToString())))
            imageIndex += 1
        Next conf
    End Sub 'editControl1_ContextChoiceOpen
    
    
    '/ <summary>
    '/ Fills context prompt menu.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub editControl1_ContextPromptOpen(sender As Object, e As Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs) Handles editControl1.ContextPromptOpen
        ' First of all we should get lexem(if it is one), 
        ' which opens current region that supports context prompt dropping.
        Dim lex As ILexem = GetCurrentContextPromptDropper()
        
        If lex Is Nothing Then
            ' If there is no such lexem, than we should not show context prompt.
            e.CloseForm = True
            Return
        End If
        
        Dim conf As IConfigLexem = lex.Config.ParentConfig
        
        ' If there is no prompts assigned to the found complex lexem, than we should exit.
        If Not m_MethodPrompts.Contains(conf.ID) Then
            Return
        End If 
        Dim prompts As DictionaryEntry() = CType(m_MethodPrompts(conf.ID), DictionaryEntry())
        e.List.Clear()
        ' add prompts
        Dim entry As DictionaryEntry
        For Each entry In  prompts
            ' Creates new context prompt item and adds it to the list of the prompts.
            Dim itemNew As ContextPromptItem = e.List.Add(CStr(entry.Key), CStr(entry.Value))
            ' Parses subject of the item, splits it to the set of method parameters
            ' and adds every parameter as boldable item to the context prompt item.
            ParseContectPromptSubject(itemNew)
        Next entry
    End Sub 'editControl1_ContextPromptOpen
    
    '/ <summary>
    '/ 
    '/ </summary>
    '/ <param name="stack"></param>
    '/ <returns></returns>
    Private Function GetCurrentDropperLexemConfigPair(ByRef stack As ConfigStack) As IStackData
        ' Gets current stack of complex lexems.
        ' Example: 
        ' {                        <- first { in stack
        '   get
        '   { return null;
        '   }
        '   set
        '   {                      <- second { in stack
        '     CallMethod1( |<-cursor is here )
        '   }
        ' When cursor is set as in example, stack will have such data:
        ' 1) first lexem "{",its configuration and position
        ' 2) complex lexem "set", its configuration and position 
        ' 3) second lexem "{",its configuration and position
        ' 4) complex lexem "CallMethod1", its configuration and position
        ' 5) complex lexem lexem "(",its configuration and position, ( is context prompt dropper( DropContextPrompt == true ).
        ' Note: this example is not appliable to configuration in current sample.
        stack = editControl1.GetCurrentStack()
        
        If Not (stack Is Nothing) AndAlso stack.Count > 0 Then
            Dim stackItem As IStackData = stack.Pop()
            
            If stackItem.Config.DropContextPrompt Then
                Return stackItem
            End If
        End If 
        Return Nothing
    End Function 'GetCurrentDropperLexemConfigPair
    
    '/ <summary>
    '/ 
    '/ </summary>
    '/ <returns></returns>
    Private Function GetCurrentContextPromptDropper() As ILexem
        Dim stack As ConfigStack
        Dim stackItem As IStackData = GetCurrentDropperLexemConfigPair(stack)
        
        If Not (stackItem Is Nothing) Then
            Return stackItem.Lexem
        End If 
        Return Nothing
    End Function 'GetCurrentContextPromptDropper
    
    
    '/ <summary>
    '/ Fills context prompt menu.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub editControl1_ContextPromptUpdate(sender As Object, e As Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs) Handles editControl1.ContextPromptUpdate
        If e.List.SelectedItem Is Nothing Then
            Return
        End If 
        Dim stack As ConfigStack
        
        ' Gets information about region, that supports context prompt dropping, we are currently in.
        Dim dropper As IStackData = GetCurrentDropperLexemConfigPair(stack)
        
        If Not (dropper Is Nothing) Then
            ' If we have found start start of the region which is context prompt dropper, 
            ' than we should get list of lexems inside that region that are before current cursor position.
            Dim list As IList = editControl1.GetLexemsInsideCurrentStack(False)
            
            If list Is Nothing Then
                ' If something is wrong than close context prompt.
                e.CloseForm = True
                Return
            End If
            
            Dim iIndex As Integer = 0
            
            ' Count all commas that are before that cursor position.
            ' Doing that we can find index of the subject part we should make bolded.
            Dim lexem As ILexem
            For Each lexem In  list
                If lexem.Text = "," Then
                    iIndex += 1
                End If
            Next lexem 
            ' If we have found index of the bolded item in currently selected context prompt, 
            ' than select it.
            If iIndex >= e.List.SelectedItem.BoldedItems.Count OrElse iIndex < 0 Then
                e.List.SelectedItem.BoldedItems.SelectedItem = Nothing
            Else
                e.List.SelectedItem.BoldedItems.SelectedItem = e.List.SelectedItem.BoldedItems(iIndex)
            End If
        Else
            ' If we have moved out of the region that supports context prompt dropping, than close context prompt.
            e.CloseForm = True
        End If
    End Sub 'editControl1_ContextPromptUpdate
    
    '/ <summary>
    '/ Gets lexeme info.
    '/ </summary>
    '/ <param name="lexem">Lexem.</param>
    '/ <returns>Lexem info text.</returns>
    Private Function GetLexemInfo(lexem As ILexem) As String
        ' Get configuration path of the lexem under cursor.
        ' Example: Property1 will have path like "this->.->Property1".
        Dim confPath As String = lexem.Config.BeginBlock
        Dim conf As IConfigLexem = lexem.Config.ParentConfig
        
        While Not (conf Is Nothing) AndAlso Not TypeOf conf Is IConfigLanguage
            confPath = conf.BeginBlock + "->" + confPath
            conf = conf.ParentConfig
        End While
        
        Return String.Format("Text: ""{0}""; ConfigPath: ""{1}""; FormatName: {2}", lexem.Text, confPath, lexem.Config.Format.Name)
    End Function 'GetLexemInfo
    
    
    '/ <summary>
    '/ Gets context tooltip.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub editControl1_UpdateContextToolTip(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.UpdateTooltipEventArgs) Handles editControl1.UpdateContextToolTip
        ' If the text is already specified, than we should not change it. This is needed to display default tooltip for the collapsed region.
        If e.Text <> String.Empty Then
            Return
        End If
        ' Convert position of the mouse cursor to the position in text.
        Dim virt As Point = editControl1.PointToVirtualPosition(New Point(e.X, e.Y), True)

        ' If there is no text in tat position, tan exit.
        If virt.IsEmpty = True Then
            Return
        End If
        Dim line As ILexemLine = editControl1.GetLine(virt.Y)

        If Not (line Is Nothing) Then
            ' Get lexem under cursor.
            Dim lexem As ILexem = line.FindLexemByColumn(virt.X)

            If Not (lexem Is Nothing) Then
                ' Set text of the tooltip.
                e.Text = GetLexemInfo(lexem) + vbLf

                ' Get stack of the lexem.
                Dim stack As ConfigStack = line.GetStackByColumn(virt.X)

                If Not (stack Is Nothing) Then
                    e.Text += "Stack before parsing lexem:" + vbLf

                    While stack.Count > 0
                        Dim stackItem As IStackData = CType(stack.Pop(), IStackData)

                        If Not (stackItem.Lexem Is Nothing) Then
                            e.Text += "-- " + GetLexemInfo(stackItem.Lexem) + vbLf
                        End If
                    End While
                    e.Text += vbLf
                End If

                ' Add description if present.
                If m_MethodComments.Contains(lexem.Config.ID) Then
                    e.Text += "Lexem contains description:" + vbLf
                    e.Text += m_MethodComments(lexem.Config.ID)
                End If
            End If
        End If
    End Sub 'editControl1_UpdateContextToolTip

#End Region
    
    
    Private Sub MainMenuClick(sender As Object, e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem8.Click, menuItem9.Click
        Dim mi As MenuItem = sender
        
        Select Case mi.Text
            Case "New"
                Me.editControl1.NewFile()
            Case "Open"
                Me.editControl1.LoadFile()
            Case "Save"
                Me.editControl1.Save()
            Case "SaveAs"
                Me.editControl1.SaveAs()
            Case "Close"
                Me.editControl1.Close()
            Case "Exit"
                Me.Close()
        End Select
    End Sub 'MainMenuClick
    
    
    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(550, 500)

        Me.editControl1.BorderStyle = BorderStyle.Fixed3D
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowOutliningCollapsers = False
        Me.editControl1.ShowSelectionMargin = False
        
        Dim index As Integer = 0
        Dim img As Image
        For Each img In  Me.imageList1.Images
            ' Populating images using an external ImageList
            Me.editControl1.ContextChoiceController.AddImage("Image" + index.ToString(), img)
            index += 1
        Next img
    End Sub 'Form1_Load
End Class 'Form1