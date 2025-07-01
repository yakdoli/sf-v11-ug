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

Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private WithEvents editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private menuItem7 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Private imageList1 As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer = Nothing
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    
    Private ConfigPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\config.xml"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.ShowContextTooltip = False
        Me.editControl1.ShowOutliningCollapsers = False
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowVerticalSplitters = False
        
        Me.editControl1.Configurator.Open(ConfigPath)
        Me.editControl1.ApplyConfiguration("CustomLanguage")
        
        Dim index As Integer = 0
        Dim img As Image
        For Each img In  Me.imageList1.Images
            ' Populating images using an external ImageList
            Me.editControl1.ContextChoiceController.AddImage("Image" + index.ToString(), img)
            index += 1
        Next img
        
        Me.editControl1.Text = "/* Type 'this' or 'me' and a DOT to see the context choice list. After you type 'this.', select 'Find' (or any of the items)from the context choice list and type a BRACE '(' to see the context prompt */" + vbLf + vbLf
    End Sub 'New
    
    
    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Config1 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem2 = New System.Windows.Forms.MenuItem
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.menuItem4 = New System.Windows.Forms.MenuItem
        Me.menuItem5 = New System.Windows.Forms.MenuItem
        Me.menuItem6 = New System.Windows.Forms.MenuItem
        Me.menuItem7 = New System.Windows.Forms.MenuItem
        Me.menuItem9 = New System.Windows.Forms.MenuItem
        Me.menuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'editControl1
        '
        Me.editControl1.BackColor = System.Drawing.SystemColors.Window
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.Configurator = Config1
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.editControl1.Location = New System.Drawing.Point(0, 0)
        Me.editControl1.Name = "editControl1"
        Me.editControl1.SaveOnClose = False
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.TabIndex = 0
        Me.editControl1.Text = ""
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.VisualColumn = 1
        Me.editControl1.WordWrap = True
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.MenuItem10})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem9, Me.menuItem8})
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
        'menuItem9
        '
        Me.menuItem9.Index = 6
        Me.menuItem9.Text = "Close"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 7
        Me.menuItem8.Text = "Exit"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11, Me.MenuItem12})
        Me.MenuItem10.Text = "FilterAutoCompleteItems"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "True"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 1
        Me.MenuItem12.Text = "False"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        Me.imageList1.Images.SetKeyName(3, "")
        Me.imageList1.Images.SetKeyName(4, "")
        Me.imageList1.Images.SetKeyName(5, "")
        Me.imageList1.Images.SetKeyName(6, "")
        Me.imageList1.Images.SetKeyName(7, "")
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 445)
        Me.Controls.Add(Me.editControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Context Choice and Prompt"
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub 'Main



    Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem8.Click, menuItem9.Click
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

    'Store the lexem name invoking the ContextPrompt popup
    Private contextPromptLexem As String = ""

    Private Sub editControl1_ContextPromptBeforeOpen(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles editControl1.ContextPromptBeforeOpen
        Dim lex As ILexem
        Dim lexemLine As ILexemLine = Me.editControl1.GetLine(Me.editControl1.CurrentLine)

        'Gets the index of the current word in that line
        Dim ind As Integer = GetContextPromptCharIndex(lexemLine)

        If ind <= 0 Then
            e.Cancel = True
            Return
        End If
        lex = lexemLine.LineLexems(ind - 1) 

        ' If the count is less than '2', do not show the ContextPrompt popup
        If lexemLine.LineLexems.Count < 2 Then
            e.Cancel = True
        Else
            ' Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
            If lex.Text = "Chat" OrElse lex.Text = "Database" OrElse lex.Text = "NewFile" OrElse lex.Text = "Find" OrElse lex.Text = "Home" OrElse lex.Text = "PieChart" OrElse lex.Text = "Tools" Then
                Me.contextPromptLexem = lex.Text
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub 'editControl1_ContextPromptBeforeOpen


    ' Populate the context prompt list on popup
    Private Sub editControl1_ContextPromptOpen(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs) Handles editControl1.ContextPromptOpen
        If Me.contextPromptLexem <> "" Then
            PopulateContextPromptItems(e)
        End If
    End Sub 'editControl1_ContextPromptOpen



    ' Method that populates the context prompt list based on the lexem invoking it
    Private Sub PopulateContextPromptItems(ByVal e As ContextPromptUpdateEventArgs)
        Select Case Me.contextPromptLexem
            Case "Chat"
                e.List.Clear()
                e.AddPrompt("Chat(string chatText, int senderID, int receiverID, int connectionID)", "Specify the chat text, the sender information, the receiver information and the connection ID")
                e.AddPrompt("Chat(string chatText, int senderID, bool isBroadCast)", "Specify the chat text, the sender information, and if its a broadcast")
            Case "Database"
                e.List.Clear()
                e.AddPrompt("Database()", "Create a new database")
                e.AddPrompt("Database(string dataBaseName)", "Create a new database with the specified name")
            Case "NewFile"
                e.List.Clear()
                e.AddPrompt("NewFile()", "Create a new file")
                e.AddPrompt("NewFile(string fileName)", "Create a new file with the specified name")
            Case "Find"
                e.List.Clear()
                e.AddPrompt("Find()", "Display the Find dialog")
                e.AddPrompt("Find(string searchText)", "Find occurences of the specified search text")
                e.AddPrompt("Find(string searchText, bool searchUp)", "Find occurences of the specified search text and search up if specified")
            Case "Home"
                e.List.Clear()
                e.AddPrompt("Home()", "Go to the initial application form")
            Case "PieChart"
                e.List.Clear()
                e.AddPrompt("PieChart()", "Create an empty Pie-chart")
                e.AddPrompt("PieChart(string[] sectionNames, int[] sectionAngles)", "Create a Pie-chart containing the specified sections with the specified angles information")
                e.AddPrompt("PieChart(string[] sectionNames, int[] sectionAngles, Color[] sectionColors)", "Create a Pie-chart containing the specified sections with the specified angles and color information")
            Case "Tools"
                e.List.Clear()
                e.AddPrompt("Tools()", "Display the Tools dialog")
                e.AddPrompt("Tools(int ToolID)", "Display the Tools dialog and select the specified Tool")
        End Select
    End Sub 'PopulateContextPromptItems



    ' Display the selected Context prompt item's index
    Private Sub editControl1_ContextPromptSelectionChanged(ByVal sender As Syncfusion.Windows.Forms.Edit.Forms.Popup.ContextPrompt, ByVal e As Syncfusion.Windows.Forms.Edit.ContextPromptSelectionChangedEventArgs) Handles editControl1.ContextPromptSelectionChanged
        Console.WriteLine("SelectedIndex : " + e.SelectedIndex.ToString())
        Console.WriteLine("ContextPromptSelectionChanged")
    End Sub 'editControl1_ContextPromptSelectionChanged



    ' Returns the last index of the context prompt character - '(' in the current line
    Private Function GetContextPromptCharIndex(ByVal line As ILexemLine) As Integer
        Dim lastPos As Integer = -1

        Dim i As Integer
        For i = 0 To line.LineLexems.Count - 1
            Dim lex As ILexem = line.LineLexems(i) 

            If lex.Text = "(" Then
                lastPos = i
            End If
        Next i
        Return lastPos
    End Function 'GetContextPromptCharIndex



    ' Clear the context prompt lexem name on close
    Private Sub editControl1_ContextPromptClose(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.ContextPromptCloseEventArgs) Handles editControl1.ContextPromptClose
        Me.contextPromptLexem = ""
    End Sub 'editControl1_ContextPromptClose



    ' Ensure that the context choice popup is displayed if the invoking lexems are "this" or "me" only
    Private Sub editControl1_ContextChoiceBeforeOpen(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles editControl1.ContextChoiceBeforeOpen
        Dim lex As ILexem
        Dim lexemLine As ILexemLine = Me.editControl1.GetLine(Me.editControl1.CurrentLine)

        'Gets the index of the current word in that line
        Dim ind As Integer = GetContextChoiceCharIndex(lexemLine)

        If ind <= 0 Then
            e.Cancel = True
            Return
        End If

        lex = lexemLine.LineLexems(ind - 1) 

        ' If the count is less than '2', do not show the ContextChoice popup
        If lexemLine.LineLexems.Count < 2 Then
            e.Cancel = True
        Else
            ' Display ContextChoice popup if the lexem used to invoke them is "this" or "me" only
            If lex.Text = "this" OrElse lex.Text = "me" Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub 'editControl1_ContextChoiceBeforeOpen


    ' Populate the context choice list on popup
    Private Sub editControl1_ContextChoiceOpen(ByVal controller As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController) Handles editControl1.ContextChoiceOpen
        controller.Items.Add("Chat", "This is Chat", Me.editControl1.ContextChoiceController.Images("Image0"))
        controller.Items.Add("Database", "This is Database", Me.editControl1.ContextChoiceController.Images("Image1"))
        controller.Items.Add("NewFile", "This is NewFile", Me.editControl1.ContextChoiceController.Images("Image2"))
        controller.Items.Add("Find", "This is Find", Me.editControl1.ContextChoiceController.Images("Image3"))
        controller.Items.Add("Home", "This is Home", Me.editControl1.ContextChoiceController.Images("Image4"))
        controller.Items.Add("PieChart", "This is PieChart", Me.editControl1.ContextChoiceController.Images("Image6"))
        controller.Items.Add("Tools", "This is Tools", Me.editControl1.ContextChoiceController.Images("Image7"))
    End Sub 'editControl1_ContextChoiceOpen



    Private Sub editControl1_ContextChoiceItemSelected(ByVal sender As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController, ByVal e As Syncfusion.Windows.Forms.Edit.ContextChoiceItemSelectedEventArgs) Handles editControl1.ContextChoiceItemSelected
        ' Display the Context Choice item selected		
        Console.WriteLine("SelectedItem : " + e.SelectedItem.Text)
    End Sub 'editControl1_ContextChoiceItemSelected



    ' Clear the Context Choice items list on closing the Context Choice popup
    Private Sub editControl1_ContextChoiceClose(ByVal controller As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController, ByVal dialogresult As System.Windows.Forms.DialogResult) Handles editControl1.ContextChoiceClose
        controller.Items.Clear()
    End Sub 'editControl1_ContextChoiceClose


    ' Returns the last index of the context choice character - '.' in the current line
    Private Function GetContextChoiceCharIndex(ByVal line As ILexemLine) As Integer
        Dim lastPos As Integer = -1

        Dim i As Integer
        For i = 0 To line.LineLexems.Count - 1
            Dim lex As ILexem = line.LineLexems(i) 

            If lex.Text = "." Then
                lastPos = i
            End If
        Next i
        Return lastPos
    End Function 'GetContextChoiceCharIndex
#Region "FilterAutoCompleteItems"

    Private Sub menuItem11_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem11.Click
        'Filters the item in the AutoComplete Context choice and the filtered item alone will be visible.
        Me.editControl1.FilterAutoCompleteItems = True
    End Sub

    Private Sub menuItem12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem12.Click
        'All the items will be visible and the selection will be navigated to the item. 
        Me.editControl1.FilterAutoCompleteItems = False
    End Sub
#End Region

    
End Class 'Form1