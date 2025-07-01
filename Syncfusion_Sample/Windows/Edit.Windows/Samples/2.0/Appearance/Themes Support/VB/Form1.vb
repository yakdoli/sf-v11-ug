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
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Runtime.InteropServices

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Utils


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    
    
    Private Declare Function LockWindowUpdate Lib "user32" (ByVal Hwnd As Integer) As Integer

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
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Private components As System.ComponentModel.IContainer
    Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
    Private menuItem11 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
    Private imageList1 As System.Windows.Forms.ImageList
    Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
    Private menuItem16 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem17 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem18 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem19 As System.Windows.Forms.MenuItem
    Private statusBar1 As System.Windows.Forms.StatusBar
    Private statusBarPanel1 As System.Windows.Forms.StatusBarPanel
    
    Private configPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\config.xml"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.SplitFourQuadrants()
        Me.editControl1.WordWrap = False
		Me.editControl1.SaveOnClose = False

        Me.editControl1.Configurator.Open(configPath)
        Me.editControl1.ApplyConfiguration("CustomLanguage")

        Me.editControl1.Text = "protected override void Dispose( bool disposing )" + vbCr + vbLf + vbTab + vbTab + "{" + vbCr + vbLf + vbTab + vbTab + vbTab + "if( disposing )" + vbCr + vbLf + vbTab + vbTab + vbTab + "{" + vbCr + vbLf + vbTab + vbTab + vbTab + vbTab + "if (components != null) " + vbCr + vbLf + vbTab + vbTab + vbTab + vbTab + "{" + vbCr + vbLf + vbTab + vbTab + vbTab + vbTab + vbTab + "components.Dispose();" + vbCr + vbLf + vbTab + vbTab + vbTab + vbTab + "}" + vbCr + vbLf + vbTab + vbTab + vbTab + "}" + vbCr + vbLf + vbTab + vbTab + vbTab + "base.Dispose( disposing );" + vbCr + vbLf + vbTab + vbTab + "}"
        
        Dim index As Integer = 0
        Dim img As Image
        For Each img In  Me.imageList1.Images
            ' Populating images using an external ImageList
            Me.editControl1.ContextChoiceController.AddImage("Image" + index.ToString(), img)
            index += 1
        Next img
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As New System.Resources.ResourceManager(GetType(Form1))
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.menuItem10 = New System.Windows.Forms.MenuItem()
        Me.menuItem11 = New System.Windows.Forms.MenuItem()
        Me.menuItem12 = New System.Windows.Forms.MenuItem()
        Me.menuItem13 = New System.Windows.Forms.MenuItem()
        Me.menuItem14 = New System.Windows.Forms.MenuItem()
        Me.menuItem15 = New System.Windows.Forms.MenuItem()
        Me.menuItem16 = New System.Windows.Forms.MenuItem()
        Me.menuItem18 = New System.Windows.Forms.MenuItem()
        Me.menuItem19 = New System.Windows.Forms.MenuItem()
        Me.menuItem17 = New System.Windows.Forms.MenuItem()
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.statusBar1 = New System.Windows.Forms.StatusBar()
        Me.statusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' editControl1
        ' 
        Me.editControl1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        Me.editControl1.BackColor = System.Drawing.SystemColors.Window
        Me.editControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.editControl1.ColumnGuideItems = New Syncfusion.Windows.Forms.Edit.Utils.ColumnGuideItem(-1) {}
        Me.editControl1.ColumnGuidesMeasuringFont = New System.Drawing.Font("Courier New", 10.0F)
        Me.editControl1.ContextChoiceSize = New System.Drawing.Size(176, 88)
        Me.editControl1.ContextPromptBackgroundBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.LemonChiffon)
        Me.editControl1.ContextPromptCustomSize = New System.Drawing.Size(400, 50)
        Me.editControl1.ContextTooltipBackgroundBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.LemonChiffon)
        Me.editControl1.CurrentColumn = 1
        Me.editControl1.CurrentLine = 1
        Me.editControl1.CurrentPosition = New System.Drawing.Point(1, 1)
        Me.editControl1.CustomLineWrappingMarkingImage = Nothing
        Me.editControl1.FileOpened = Nothing
        Me.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default
        Me.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default
        Me.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.LightBlue
        Me.editControl1.IndentLineColor = System.Drawing.Color.Gray
        Me.editControl1.LineNumbersColor = System.Drawing.Color.DarkBlue
        Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.editControl1.Location = New System.Drawing.Point(16, 16)
        Me.editControl1.Name = "editControl1"
        Me.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty
        Me.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red
        Me.editControl1.ShowCollapse = True
        Me.editControl1.ShowHorizontalSplitters = True
        Me.editControl1.ShowIndentationGuidelines = True
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowLineNumbers = True
        Me.editControl1.ShowMarkers = False
        Me.editControl1.ShowOutliningCollapsers = True
        Me.editControl1.ShowSelectionMargin = False
        Me.editControl1.ShowVerticalSplitters = True
        Me.editControl1.ShowWhitespaces = False
        Me.editControl1.Size = New System.Drawing.Size(504, 392)
        Me.editControl1.StatusBarSettings.CoordsPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.editControl1.StatusBarSettings.CoordsPanel.MinWidth = 10
        Me.editControl1.StatusBarSettings.CoordsPanel.Visible = True
        Me.editControl1.StatusBarSettings.CoordsPanel.Width = 148
        Me.editControl1.StatusBarSettings.EncodingPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
        Me.editControl1.StatusBarSettings.EncodingPanel.Visible = True
        Me.editControl1.StatusBarSettings.EncodingPanel.Width = 165
        Me.editControl1.StatusBarSettings.InsertPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.editControl1.StatusBarSettings.InsertPanel.MinWidth = 10
        Me.editControl1.StatusBarSettings.InsertPanel.Visible = True
        Me.editControl1.StatusBarSettings.InsertPanel.Width = 33
        Me.editControl1.StatusBarSettings.StatusPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.StatusPanel.Visible = True
        Me.editControl1.StatusBarSettings.StatusPanel.Width = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.StatusBarSettings.TextPanel.MinWidth = 10
        Me.editControl1.StatusBarSettings.TextPanel.Visible = True
        Me.editControl1.StatusBarSettings.TextPanel.Width = 96
        Me.editControl1.TabIndex = 0
        Me.editControl1.TabSize = 2
        Me.editControl1.TabStopsArray = New Integer() {8, 16, 24, 32, 40}
        Me.editControl1.Text = "editControl1"
        Me.editControl1.TextAreaWidth = 600
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.UserMarginBackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood)
        Me.editControl1.UserMarginTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.editControl1.UserMarginWidth = 100
        Me.editControl1.WordWrap = True
        Me.editControl1.WordWrapMarginBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond)
        Me.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black
        Me.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem10, Me.menuItem11, Me.menuItem15, Me.menuItem16})
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem9, Me.menuItem8})
        Me.menuItem1.Text = "File"
        ' 
        ' menuItem2
        ' 
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "New"
        ' 
        ' menuItem3
        ' 
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "Open"
        ' 
        ' menuItem4
        ' 
        Me.menuItem4.Index = 2
        Me.menuItem4.Text = "-"
        ' 
        ' menuItem5
        ' 
        Me.menuItem5.Index = 3
        Me.menuItem5.Text = "Save"
        ' 
        ' menuItem6
        ' 
        Me.menuItem6.Index = 4
        Me.menuItem6.Text = "SaveAs"
        ' 
        ' menuItem7
        ' 
        Me.menuItem7.Index = 5
        Me.menuItem7.Text = "-"
        ' 
        ' menuItem9
        ' 
        Me.menuItem9.Index = 6
        Me.menuItem9.Text = "Close"
        ' 
        ' menuItem8
        ' 
        Me.menuItem8.Index = 7
        Me.menuItem8.Text = "Exit"
        ' 
        ' menuItem10
        ' 
        Me.menuItem10.Index = 1
        Me.menuItem10.Text = "ToggleXPThemes"
        ' 
        ' menuItem11
        ' 
        Me.menuItem11.Index = 2
        Me.menuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem12, Me.menuItem13, Me.menuItem14})
        Me.menuItem11.Text = "IntellisensePopups"
        ' 
        ' menuItem12
        ' 
        Me.menuItem12.Index = 0
        Me.menuItem12.Text = "Context Tooltip"
        ' 
        ' menuItem13
        ' 
        Me.menuItem13.Index = 1
        Me.menuItem13.Text = "Context Choice"
        ' 
        ' menuItem14
        ' 
        Me.menuItem14.Index = 2
        Me.menuItem14.Text = "Context Prompt"
        ' 
        ' menuItem15
        ' 
        Me.menuItem15.Index = 3
        Me.menuItem15.Text = "Borders"
        ' 
        ' menuItem16
        ' 
        Me.menuItem16.Index = 4
        Me.menuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem18, Me.menuItem19, Me.menuItem17})
        Me.menuItem16.Text = "Splitters"
        ' 
        ' menuItem18
        ' 
        Me.menuItem18.Index = 0
        Me.menuItem18.Text = "Split Vertically"
        ' 
        ' menuItem19
        ' 
        Me.menuItem19.Index = 1
        Me.menuItem19.Text = "Split Horizontally"
        ' 
        ' menuItem17
        ' 
        Me.menuItem17.Index = 2
        Me.menuItem17.Text = "Split into Quadrants"
        ' 
        ' imageList1
        ' 
        Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        ' 
        ' statusBar1
        ' 
        Me.statusBar1.Location = New System.Drawing.Point(0, 423)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.statusBarPanel1})
        Me.statusBar1.ShowPanels = True
        Me.statusBar1.Size = New System.Drawing.Size(542, 22)
        Me.statusBar1.TabIndex = 1
        Me.statusBar1.Text = "statusBar1"
        ' 
        ' statusBarPanel1
        ' 
        Me.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.statusBarPanel1.Width = 526
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 445)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.statusBar1, Me.editControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Themes Support"
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
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


    Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem9.Click, menuItem8.Click
        Me.statusBar1.Panels(0).Text = ""
        Dim mi As MenuItem = sender '
        'ToDo: Error processing original source shown below
        '   this.statusBar1.Panels[0].Text = "";
        '   MenuItem mi = sender as MenuItem;
        '-------------------------^--- Syntax error: ';' expected

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


    Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
        Me.editControl1.UseXPStyle = Not Me.editControl1.UseXPStyle
    End Sub 'menuItem10_Click


    Private Sub editControl1_UpdateContextToolTip(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.UpdateTooltipEventArgs) Handles editControl1.UpdateContextToolTip
        If e.Text = String.Empty Then
            Dim pointVirtual As System.Drawing.Point = editControl1.PointToVirtualPosition(New System.Drawing.Point(e.X, e.Y))

            If pointVirtual.Y > 0 Then
                ' Get the current line  
                Dim line As ILexemLine = editControl1.GetLine(pointVirtual.Y)

                If Not (line Is Nothing) Then
                    ' Get tokens from the current line  
                    Dim lexem As ILexem = line.FindLexemByColumn(pointVirtual.X)

                    If Not (lexem Is Nothing) Then
                        Dim configLexem As IConfigLexem = lexem.Config '
                        'ToDo: Error processing original source shown below
                        '      {  
                        '       IConfigLexem configLexem = lexem.Config as IConfigLexem; 
                        '------------------------------------------------^--- Syntax error: ';' expected
                        Dim formatName As String = configLexem.Format.Name
                        e.Text = "This is a " + formatName + " : " + lexem.Text
                    End If
                End If
            End If
        End If
    End Sub 'editControl1_UpdateContextToolTip


    Private Sub IntellisensePopupsClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem12.Click, menuItem13.Click, menuItem14.Click
        Me.statusBar1.Panels(0).Text = ""
        Dim mi As MenuItem = sender '
        'ToDo: Error processing original source shown below
        '   this.statusBar1.Panels[0].Text="";
        '   MenuItem mi = sender as MenuItem;
        '-------------------------^--- Syntax error: ';' expected

        Select Case mi.Text
            Case "Context Tooltip"
                Me.editControl1.ShowContextTooltip = True
                Me.statusBar1.Panels(0).Text = "Move the mouse over the text in the EditControl to see the Context Tooltip"
            Case "Context Choice"
                LockWindowUpdate(Me.editControl1.Handle.ToInt64())
                Me.editControl1.ShowContextTooltip = False
                Me.editControl1.SplitHorizontally()
                Me.editControl1.HorizontalSplitterPosition = 0
                Me.editControl1.Text = vbLf + vbLf + "this.editControl1."
                LockWindowUpdate(0)
                Me.editControl1.ShowContextChoice()
            Case "Context Prompt"
                LockWindowUpdate(Me.editControl1.Handle.ToInt64())
                Me.editControl1.ShowContextTooltip = False
                Me.editControl1.SplitHorizontally()
                Me.editControl1.HorizontalSplitterPosition = 0
                Me.editControl1.Text = vbLf + vbLf + "this.editControl1.Find("
                LockWindowUpdate(0)
                Me.editControl1.ShowContextPrompt()
        End Select
    End Sub 'IntellisensePopupsClick


    Private Sub editControl1_ContextChoiceOpen(ByVal controller As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController) Handles editControl1.ContextChoiceOpen
        controller.Items.Add("Copy", "This is Copy", Me.editControl1.ContextChoiceController.Images("Image1"))
        controller.Items.Add("Cut", "This is Cut", Me.editControl1.ContextChoiceController.Images("Image2"))
        controller.Items.Add("Paste", "This is Paste", Me.editControl1.ContextChoiceController.Images("Image5"))
        controller.Items.Add("Find", "This is Find", Me.editControl1.ContextChoiceController.Images("Image3"))
        controller.Items.Add("Replace", "This is Replace", Me.editControl1.ContextChoiceController.Images("Image6"))
        controller.Items.Add("Open", "This is Open", Me.editControl1.ContextChoiceController.Images("Image4"))
        controller.Items.Add("Save", "This is Save", Me.editControl1.ContextChoiceController.Images("Image7"))
        controller.Items.Add("Test", "This is Test", Me.editControl1.ContextChoiceController.Images("Image8"))
        controller.Items.Add("Bookmark", "This is Bookmark", Me.editControl1.ContextChoiceController.Images("Image0"))
    End Sub 'editControl1_ContextChoiceOpen


    Private Sub editControl1_ContextPromptOpen(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs) Handles editControl1.ContextPromptOpen
        e.AddPrompt("Find()", "Display the Find dialog")
        e.AddPrompt("Find(string searchText)", "Find occurences of the specified search text")
        e.AddPrompt("Find(string searchText, bool searchUp)", "Find occurences of the specified search text and search up if specified")
    End Sub 'editControl1_ContextPromptOpen


    Private Sub editControl1_ContextChoiceClose(ByVal controller As Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController, ByVal dialogresult As System.Windows.Forms.DialogResult) Handles editControl1.ContextChoiceClose
        controller.Items.Clear()
    End Sub 'editControl1_ContextChoiceClose


    Private Sub BordersMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem15.Click
        Me.statusBar1.Panels(0).Text = "The borders have a themed appearance while using FixedSingle style in themed mode"
    End Sub 'BordersMenuClick


    Private Sub SplittersMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem18.Click, menuItem19.Click, menuItem17.Click
        Me.statusBar1.Panels(0).Text = ""
        Dim mi As MenuItem = sender '
        'ToDo: Error processing original source shown below
        '   this.statusBar1.Panels[0].Text = "";
        '   MenuItem mi = sender as MenuItem;
        '-------------------------^--- Syntax error: ';' expected

        Select Case mi.Text
            Case "Split Vertically"
                Me.editControl1.SplitVertically()
            Case "Split Horizontally"
                Me.editControl1.SplitHorizontally()
            Case "Split into Quadrants"
                Me.editControl1.SplitFourQuadrants()
        End Select
    End Sub 'SplittersMenuClick
End Class 'Form1