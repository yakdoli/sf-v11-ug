#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Diagnostics
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.HTMLUI


''' <summary>
	''' Summary description for Form1.
	''' </summary>
Public Class Form1 : Inherits System.Windows.Forms.Form

#Region "Variables"
    Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
    Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private panel1 As System.Windows.Forms.Panel
    Private WithEvents button1 As System.Windows.Forms.Button
    Private label1 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer
    Private menuItem8 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Private menuItem10 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
    Private imageList1 As System.Windows.Forms.ImageList
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private WithEvents button12 As System.Windows.Forms.Button
    Private panel3 As System.Windows.Forms.Panel
    Private WithEvents toolBar1 As System.Windows.Forms.ToolBar
    Private toolBarButton1 As System.Windows.Forms.ToolBarButton
    Private toolBarButton2 As System.Windows.Forms.ToolBarButton
    Private toolBarButton3 As System.Windows.Forms.ToolBarButton
    Private toolBarButton4 As System.Windows.Forms.ToolBarButton
    Private toolBarButton6 As System.Windows.Forms.ToolBarButton
    Private toolBarButton7 As System.Windows.Forms.ToolBarButton
    Private toolBarButton8 As System.Windows.Forms.ToolBarButton
    Private toolBarButton9 As System.Windows.Forms.ToolBarButton
    Private toolBarButton10 As System.Windows.Forms.ToolBarButton
    Private toolBarButton11 As System.Windows.Forms.ToolBarButton
    Private toolBarButton12 As System.Windows.Forms.ToolBarButton
    Private toolBarButton13 As System.Windows.Forms.ToolBarButton
    Private menuItem13 As System.Windows.Forms.MenuItem
    Private menuItem14 As System.Windows.Forms.MenuItem
    Private menuItem15 As System.Windows.Forms.MenuItem
    Private menuItem16 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem17 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem18 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem19 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem20 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem21 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem22 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem23 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem24 As System.Windows.Forms.MenuItem
    Private home As Uri
    Private selectedText As String = ""
    Private homeLocation As String = ""
    Private fileName As String = ""
    Private pd As HTMLUIPrintDocument
    Private DftfontSize As Single = 0
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private menuItem25 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem26 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem27 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem28 As System.Windows.Forms.MenuItem
    Private fontSize As Single = 0
#End Region

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
    Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
    Me.mainMenu1 = New System.Windows.Forms.MainMenu
    Me.menuItem1 = New System.Windows.Forms.MenuItem
    Me.menuItem2 = New System.Windows.Forms.MenuItem
    Me.menuItem5 = New System.Windows.Forms.MenuItem
    Me.menuItem6 = New System.Windows.Forms.MenuItem
    Me.menuItem3 = New System.Windows.Forms.MenuItem
    Me.menuItem4 = New System.Windows.Forms.MenuItem
    Me.menuItem7 = New System.Windows.Forms.MenuItem
    Me.menuItem13 = New System.Windows.Forms.MenuItem
    Me.menuItem14 = New System.Windows.Forms.MenuItem
    Me.menuItem15 = New System.Windows.Forms.MenuItem
    Me.menuItem17 = New System.Windows.Forms.MenuItem
    Me.menuItem18 = New System.Windows.Forms.MenuItem
    Me.menuItem19 = New System.Windows.Forms.MenuItem
    Me.menuItem24 = New System.Windows.Forms.MenuItem
    Me.menuItem16 = New System.Windows.Forms.MenuItem
    Me.menuItem20 = New System.Windows.Forms.MenuItem
    Me.menuItem21 = New System.Windows.Forms.MenuItem
    Me.menuItem22 = New System.Windows.Forms.MenuItem
    Me.menuItem23 = New System.Windows.Forms.MenuItem
    Me.menuItem8 = New System.Windows.Forms.MenuItem
    Me.menuItem9 = New System.Windows.Forms.MenuItem
    Me.menuItem10 = New System.Windows.Forms.MenuItem
    Me.menuItem11 = New System.Windows.Forms.MenuItem
    Me.menuItem12 = New System.Windows.Forms.MenuItem
    Me.menuItem25 = New System.Windows.Forms.MenuItem
    Me.menuItem26 = New System.Windows.Forms.MenuItem
    Me.menuItem28 = New System.Windows.Forms.MenuItem
    Me.menuItem27 = New System.Windows.Forms.MenuItem
    Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.panel1 = New System.Windows.Forms.Panel
    Me.comboBox1 = New System.Windows.Forms.ComboBox
    Me.panel3 = New System.Windows.Forms.Panel
    Me.toolBar1 = New System.Windows.Forms.ToolBar
    Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton11 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton4 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton12 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton6 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton7 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton13 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton8 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton9 = New System.Windows.Forms.ToolBarButton
    Me.toolBarButton10 = New System.Windows.Forms.ToolBarButton
    Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.label1 = New System.Windows.Forms.Label
    Me.button1 = New System.Windows.Forms.Button
    Me.button12 = New System.Windows.Forms.Button
    CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.panel1.SuspendLayout()
    Me.panel3.SuspendLayout()
    Me.SuspendLayout()
    '
    'htmluiControl1
    '
    Me.htmluiControl1.AllowDrop = True
    Me.htmluiControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.htmluiControl1.AutoRunScripts = True
    Me.htmluiControl1.AutoScroll = True
    Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(525, 257)
    Me.htmluiControl1.BackColor = System.Drawing.SystemColors.ControlLightLight
    Me.htmluiControl1.EnableMultithreading = False
    Me.htmluiControl1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.htmluiControl1.IsOriginalTextCached = True
    Me.htmluiControl1.Location = New System.Drawing.Point(0, 80)
    Me.htmluiControl1.Name = "htmluiControl1"
    Me.htmluiControl1.Size = New System.Drawing.Size(552, 272)
    Me.htmluiControl1.StartupDocument = ""
    Me.htmluiControl1.StartupFolder = ""
    Me.htmluiControl1.TabIndex = 0
    Me.htmluiControl1.Text = "htmluiControl1"
    '
    'mainMenu1
    '
    Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem4, Me.menuItem13, Me.menuItem8, Me.menuItem10, Me.menuItem25})
    '
    'menuItem1
    '
    Me.menuItem1.Index = 0
    Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem5, Me.menuItem6, Me.menuItem3})
    Me.menuItem1.Text = "File"
    '
    'menuItem2
    '
    Me.menuItem2.Index = 0
    Me.menuItem2.Text = "Load From File"
    '
    'menuItem5
    '
    Me.menuItem5.Index = 1
    Me.menuItem5.Text = "Print Preview"
    '
    'menuItem6
    '
    Me.menuItem6.Index = 2
    Me.menuItem6.Text = "Print"
    '
    'menuItem3
    '
    Me.menuItem3.Index = 3
    Me.menuItem3.Text = "Exit"
    '
    'menuItem4
    '
    Me.menuItem4.Index = 1
    Me.menuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem7})
    Me.menuItem4.Text = "Edit"
    '
    'menuItem7
    '
    Me.menuItem7.Index = 0
    Me.menuItem7.Text = "Copy Selected Text"
    '
    'menuItem13
    '
    Me.menuItem13.Index = 2
    Me.menuItem13.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem14})
    Me.menuItem13.Text = "Format"
    '
    'menuItem14
    '
    Me.menuItem14.Index = 0
    Me.menuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem15, Me.menuItem16})
    Me.menuItem14.Text = "Font"
    '
    'menuItem15
    '
    Me.menuItem15.Index = 0
    Me.menuItem15.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem17, Me.menuItem18, Me.menuItem19, Me.menuItem24})
    Me.menuItem15.Text = "Face"
    '
    'menuItem17
    '
    Me.menuItem17.Index = 0
    Me.menuItem17.Text = "Arial"
    '
    'menuItem18
    '
    Me.menuItem18.Index = 1
    Me.menuItem18.Text = "Courier New"
    '
    'menuItem19
    '
    Me.menuItem19.Index = 2
    Me.menuItem19.Text = "Century Gothic"
    '
    'menuItem24
    '
    Me.menuItem24.Index = 3
    Me.menuItem24.Text = "Tahoma"
    '
    'menuItem16
    '
    Me.menuItem16.Index = 1
    Me.menuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem20, Me.menuItem21, Me.menuItem22, Me.menuItem23})
    Me.menuItem16.Text = "Size"
    '
    'menuItem20
    '
    Me.menuItem20.Index = 0
    Me.menuItem20.Text = "Default"
    '
    'menuItem21
    '
    Me.menuItem21.Index = 1
    Me.menuItem21.Text = "Large"
    '
    'menuItem22
    '
    Me.menuItem22.Index = 2
    Me.menuItem22.Text = "Medium"
    '
    'menuItem23
    '
    Me.menuItem23.Index = 3
    Me.menuItem23.Text = "Small"
    '
    'menuItem8
    '
    Me.menuItem8.Index = 3
    Me.menuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem9})
    Me.menuItem8.Text = "Options"
    '
    'menuItem9
    '
    Me.menuItem9.Index = 0
    Me.menuItem9.Text = "Set Current Page As My Home Page"
    '
    'menuItem10
    '
    Me.menuItem10.Index = 4
    Me.menuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem11, Me.menuItem12})
    Me.menuItem10.Text = "View"
    '
    'menuItem11
    '
    Me.menuItem11.Index = 0
    Me.menuItem11.Text = "View HTML"
    '
    'menuItem12
    '
    Me.menuItem12.Index = 1
    Me.menuItem12.Text = "View XML"
    '
    'menuItem25
    '
    Me.menuItem25.Index = 5
    Me.menuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem26, Me.menuItem28, Me.menuItem27})
    Me.menuItem25.Text = "Help"
    '
    'menuItem26
    '
    Me.menuItem26.Index = 0
    Me.menuItem26.Text = "Knowledge Base"
    '
    'menuItem28
    '
    Me.menuItem28.Index = 1
    Me.menuItem28.Text = "About HTMLUI"
    '
    'menuItem27
    '
    Me.menuItem27.Index = 2
    Me.menuItem27.Text = "About Syncfusion"
    '
    'panel1
    '
    Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
    Me.panel1.Controls.Add(Me.comboBox1)
    Me.panel1.Controls.Add(Me.panel3)
    Me.panel1.Controls.Add(Me.label1)
    Me.panel1.Controls.Add(Me.button1)
    Me.panel1.Controls.Add(Me.button12)
    Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.panel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.panel1.Location = New System.Drawing.Point(0, 0)
    Me.panel1.Name = "panel1"
    Me.panel1.Size = New System.Drawing.Size(552, 80)
    Me.panel1.TabIndex = 1
    '
    'comboBox1
    '
    Me.comboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.comboBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.comboBox1.Location = New System.Drawing.Point(72, 48)
    Me.comboBox1.Name = "comboBox1"
    Me.comboBox1.Size = New System.Drawing.Size(392, 21)
    Me.comboBox1.TabIndex = 4
    Me.comboBox1.Text = "http://www.google.com/"
    '
    'panel3
    '
    Me.panel3.Controls.Add(Me.toolBar1)
    Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.panel3.Location = New System.Drawing.Point(0, 0)
    Me.panel3.Name = "panel3"
    Me.panel3.Size = New System.Drawing.Size(552, 40)
    Me.panel3.TabIndex = 3
    '
    'toolBar1
    '
    Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
    Me.toolBar1.AutoSize = False
    Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton2, Me.toolBarButton11, Me.toolBarButton3, Me.toolBarButton4, Me.toolBarButton12, Me.toolBarButton6, Me.toolBarButton7, Me.toolBarButton13, Me.toolBarButton8, Me.toolBarButton9, Me.toolBarButton10})
    Me.toolBar1.ButtonSize = New System.Drawing.Size(25, 25)
    Me.toolBar1.DropDownArrows = True
    Me.toolBar1.ImageList = Me.imageList1
    Me.toolBar1.Location = New System.Drawing.Point(0, 0)
    Me.toolBar1.Name = "toolBar1"
    Me.toolBar1.ShowToolTips = True
    Me.toolBar1.Size = New System.Drawing.Size(552, 40)
    Me.toolBar1.TabIndex = 0
    '
    'toolBarButton1
    '
    Me.toolBarButton1.ImageIndex = 5
    Me.toolBarButton1.Tag = "1"
    Me.toolBarButton1.ToolTipText = "Navigate Previous"
    '
    'toolBarButton2
    '
    Me.toolBarButton2.ImageIndex = 3
    Me.toolBarButton2.Tag = "2"
    Me.toolBarButton2.ToolTipText = "Navigate Next"
    '
    'toolBarButton11
    '
    Me.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton3
    '
    Me.toolBarButton3.ImageIndex = 10
    Me.toolBarButton3.Tag = "3"
    Me.toolBarButton3.ToolTipText = "Exit"
    '
    'toolBarButton4
    '
    Me.toolBarButton4.ImageIndex = 4
    Me.toolBarButton4.Tag = "4"
    Me.toolBarButton4.ToolTipText = "Copy to ClipBoard"
    '
    'toolBarButton12
    '
    Me.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton6
    '
    Me.toolBarButton6.ImageIndex = 7
    Me.toolBarButton6.Tag = "6"
    Me.toolBarButton6.ToolTipText = "Refresh"
    '
    'toolBarButton7
    '
    Me.toolBarButton7.ImageIndex = 2
    Me.toolBarButton7.Tag = "7"
    Me.toolBarButton7.ToolTipText = "Home"
    '
    'toolBarButton13
    '
    Me.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
    '
    'toolBarButton8
    '
    Me.toolBarButton8.ImageIndex = 8
    Me.toolBarButton8.Tag = "8"
    Me.toolBarButton8.ToolTipText = "Search for the text"
    '
    'toolBarButton9
    '
    Me.toolBarButton9.ImageIndex = 1
    Me.toolBarButton9.Tag = "9"
    Me.toolBarButton9.ToolTipText = "Open In Default Browser"
    '
    'toolBarButton10
    '
    Me.toolBarButton10.ImageIndex = 6
    Me.toolBarButton10.Tag = "10"
    Me.toolBarButton10.ToolTipText = "Print"
    '
    'imageList1
    '
    Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
    Me.imageList1.ImageSize = New System.Drawing.Size(32, 32)
    Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
    Me.imageList1.TransparentColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
    '
    'label1
    '
    Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.label1.ForeColor = System.Drawing.Color.Black
    Me.label1.Location = New System.Drawing.Point(8, 54)
    Me.label1.Name = "label1"
    Me.label1.Size = New System.Drawing.Size(56, 16)
    Me.label1.TabIndex = 2
    Me.label1.Text = "Address"
    Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'button1
    '
    Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.button1.BackColor = System.Drawing.SystemColors.Window
    Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
    Me.button1.Location = New System.Drawing.Point(472, 48)
    Me.button1.Name = "button1"
    Me.button1.Size = New System.Drawing.Size(24, 21)
    Me.button1.TabIndex = 1
    Me.button1.Text = "..."
    '
    'button12
    '
    Me.button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.button12.BackColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
    Me.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
    Me.button12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.button12.ForeColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
    Me.button12.Image = CType(resources.GetObject("button12.Image"), System.Drawing.Image)
    Me.button12.Location = New System.Drawing.Point(504, 48)
    Me.button12.Name = "button12"
    Me.button12.Size = New System.Drawing.Size(32, 24)
    Me.button12.TabIndex = 2
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
    Me.BackColor = System.Drawing.Color.White
    Me.ClientSize = New System.Drawing.Size(552, 353)
    Me.Controls.Add(Me.htmluiControl1)
    Me.Controls.Add(Me.panel1)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ForeColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Menu = Me.mainMenu1
    Me.Name = "Form1"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "HTMLUI Explorer"
    CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.panel1.ResumeLayout(False)
    Me.panel3.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub

#Region "ClassHelperEvents"
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.htmluiControl1.LoadFromString("<body bgcolor=#ffffff></body>")
        Me.DftfontSize = Me.htmluiControl1.DefaultFormat.Font.Size
        Me.fontSize = Me.DftfontSize
    End Sub

    Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
        pd = New HTMLUIPrintDocument(Me.htmluiControl1.Document)
        Me.htmluiControl1.Cursor = Cursors.Default
        If Me.htmluiControl1.Document.IsFileName = True Then
            Me.comboBox1.Text = Me.htmluiControl1.Document.FileName.ToString()
            Console.WriteLine("File Loaded from drive: " & Me.htmluiControl1.Document.FileName.ToString())
        End If
        If Me.htmluiControl1.Document.IsUri = True Then
            Me.comboBox1.Text = Me.htmluiControl1.Document.Uri.ToString()
            Console.WriteLine("File Loaded from URI: " & Me.htmluiControl1.Document.Uri.ToString())
        End If
        Me.htmluiControl1.DefaultFormat.Cursor = Cursors.IBeam
    End Sub
#End Region

#Region "UI Events"

    Private Sub htmluiControl1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles htmluiControl1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub htmluiControl1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles htmluiControl1.DragDrop
        Dim files As String() = CType(e.Data.GetData("FileDrop", False), String())

        For Each fileName In files
            Me.htmluiControl1.LoadHTML(fileName)
        Next fileName
    End Sub

    Private Sub htmluiControl1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles htmluiControl1.KeyDown
        If e.Alt = True AndAlso e.KeyCode = Keys.F4 Then
            ExitApplication()
        End If
    End Sub

    Private Sub comboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles comboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadDocument()
        End If
    End Sub

    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        Dim uri As uri = New uri(Me.comboBox1.SelectedItem.ToString())
        Me.htmluiControl1.LoadHTML(uri)
        Me.htmluiControl1.Refresh()
    End Sub

    Private Sub toolBar1_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles toolBar1.ButtonClick
        If Convert.ToInt32(e.Button.Tag) = 1 Then
            Me.htmluiControl1.Back(-1)
            Me.htmluiControl1.Refresh()
        End If

        If Convert.ToInt32(e.Button.Tag) = 2 Then
            Me.htmluiControl1.Forward(1)
            Me.htmluiControl1.Refresh()
        End If

        If Convert.ToInt32(e.Button.Tag) = 3 Then
            Application.Exit()
        End If

        If Convert.ToInt32(e.Button.Tag) = 4 Then
            CopyText()
        End If

        If Convert.ToInt32(e.Button.Tag) = 6 Then
            Me.htmluiControl1.Refresh()
        End If

        If Convert.ToInt32(e.Button.Tag) = 7 Then
            Try
                If Me.homeLocation = "" Then
                    Me.htmluiControl1.LoadHTML(Me.home)
                    Me.comboBox1.Text = Me.htmluiControl1.Document.Uri.ToString()
                Else
                    Me.htmluiControl1.LoadHTML(Me.homeLocation)
                    Me.comboBox1.Text = Me.htmluiControl1.Document.FileName.ToString()
                End If
            Catch e1 As Exception
                MessageBox.Show("Please set your Home page from the options menu before using this option.")
            End Try
        End If

        If Convert.ToInt32(e.Button.Tag) = 8 Then
            Me.htmluiControl1.DisplayFindForm()
        End If

        If Convert.ToInt32(e.Button.Tag) = 9 Then
            If Me.comboBox1.Text <> "" Then
                Dim process As process = process.Start(Me.comboBox1.Text.ToString())
            Else
                Console.WriteLine("Please enter your file name in the text box.")
            End If
        End If

        If Convert.ToInt32(e.Button.Tag) = 10 Then
            PrintDocument()
        End If
    End Sub

    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
        Me.openFileDialog1.Filter = "htm files(*.htm)|*.htm|html files(*.html)|*.html|mht files(*.mht)|*.mht"
        If LoadTheHTML() AndAlso Me.comboBox1.Text <> "" Then
            Me.htmluiControl1.LoadHTML(Me.comboBox1.Text)
            Me.htmluiControl1.Cursor = Cursors.Arrow
        End If
    End Sub

    Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
        ExitApplication()
    End Sub

    Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
        PrintPreview()
    End Sub

    Private Sub menuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem6.Click
        PrintDocument()
    End Sub

    Private Sub menuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem7.Click
        CopyText()
    End Sub

    Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
        If Me.comboBox1.Text <> "" Then
            If Me.htmluiControl1.Document.IsFileName = True Then
                Me.homeLocation = Me.htmluiControl1.Document.FileName.ToString()
            End If
            If Me.htmluiControl1.Document.IsUri = True Then
                Me.home = Me.htmluiControl1.Document.Uri
            End If
        Else
            MessageBox.Show("Load the page to use it as your home page.")
        End If
    End Sub


    Private Sub menuItem11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem11.Click
        MessageBox.Show(Me.htmluiControl1.Text)
    End Sub

    Private Sub menuItem12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem12.Click
        MessageBox.Show(Me.htmluiControl1.Document.Document.OuterXml.ToString())
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.openFileDialog1.Filter = "htm files(*.htm)|*.htm|html files(*.html)|*.html"
        LoadTheHTML()
        LoadDocument()
    End Sub

    Private Sub button12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button12.Click
        LoadDocument()
    End Sub

    Private Sub menuItem17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem17.Click
        Me.htmluiControl1.DefaultFormat.Font = New Font("Arial", Me.fontSize)
    End Sub

    Private Sub menuItem18_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem18.Click
        Me.htmluiControl1.DefaultFormat.Font = New Font("Courier New", Me.fontSize)
    End Sub

    Private Sub menuItem19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem19.Click
        Me.htmluiControl1.DefaultFormat.Font = New Font("Century Gothic", Me.fontSize)
    End Sub

    Private Sub menuItem20_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem20.Click
        Me.fontSize = Me.DftfontSize
        ChangeFontSize()
    End Sub

    Private Sub menuItem21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem21.Click
        Me.fontSize = (Me.DftfontSize + 7)
        ChangeFontSize()
    End Sub

    Private Sub menuItem22_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem22.Click
        Me.fontSize = (Me.DftfontSize + 3)
        ChangeFontSize()
    End Sub

    Private Sub menuItem23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem23.Click
        If (Me.DftfontSize - 3) > 0 Then
            Me.fontSize = (Me.DftfontSize - 3)
            ChangeFontSize()
        Else
            MessageBox.Show("Font size cannot be less than or equal to zero")
        End If
    End Sub

    Private Sub menuItem24_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem24.Click
        Me.htmluiControl1.DefaultFormat.Font = New Font("Tahoma", Me.fontSize)
    End Sub



    Private Sub menuItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem26.Click
        Dim process As process = process.Start("http://www.syncfusion.com/support/kb/htmlui/Default.aspx")
    End Sub

    Private Sub menuItem28_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem28.Click
        Dim process As process = process.Start("http://www.syncfusion.com/Products/product.aspx?p=25&tab_id=0")
    End Sub

    Private Sub menuItem27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem27.Click
        Dim process As process = process.Start("http://www.syncfusion.com/default.aspx")
    End Sub

#End Region

#Region "UI methods"
    Private Function LoadTheHTML() As Boolean
        Dim result As Boolean = False
        If Me.openFileDialog1.ShowDialog() = DialogResult.OK Then
            If Me.openFileDialog1.FileName <> "" Then
                Me.comboBox1.Text = Me.openFileDialog1.FileName
                Me.htmluiControl1.Cursor = Cursors.Arrow

                result = True
            End If
        Else
            Me.htmluiControl1.Cursor = Cursors.Arrow
            Me.htmluiControl1.Refresh()

            result = False
        End If
        Return result
    End Function

    Private Sub LoadDocument()
        Me.htmluiControl1.Cursor = Cursors.WaitCursor
        If comboBox1.Text <> "" Then
            Console.WriteLine("Loading the Specified URI...")
            Try
                Dim uri As uri = New uri(Me.comboBox1.Text)
                Me.htmluiControl1.LoadHTML(uri)
                Me.htmluiControl1.Cursor = Cursors.Arrow
            Catch exc As Exception
                MessageBox.Show(exc.ToString())
            End Try
        Else
            Console.WriteLine("Uri is Empty")
            Me.htmluiControl1.Cursor = Cursors.Arrow
        End If
        Me.comboBox1.Items.Add(Me.comboBox1.Text.ToString())
    End Sub

    Private Sub CopyText()
        Me.selectedText = Me.htmluiControl1.SelectedText.ToString()
        If Me.selectedText <> "" Then
            Clipboard.SetDataObject(Me.selectedText, True)
        Else
            Console.WriteLine("Please select some text")
        End If
    End Sub

    Private Sub ChangeFontSize()
        Try
            Me.htmluiControl1.DefaultFormat.Font = New Font(Me.htmluiControl1.DefaultFormat.Font.FontFamily, Me.fontSize)
        Catch exc As Exception
            MessageBox.Show(exc.ToString())
        End Try
    End Sub

    Private Sub PrintDocument()
        If Me.htmluiControl1.Document.Document.OuterXml <> "" Then
            Dim dg As PrintDialog = New PrintDialog()
            dg.AllowSomePages = True
            dg.Document = pd
            If dg.ShowDialog() = DialogResult.OK Then
                pd.Print()
            End If

        Else
            Console.WriteLine("The current document is not valid for printing")
        End If
    End Sub

    Private Sub PrintPreview()
        Dim dlg As PrintPreviewDialog = New PrintPreviewDialog()
        dlg.Document = pd
        dlg.ShowDialog()
    End Sub

    Private Sub ExitApplication()
        Application.Exit()
    End Sub
#End Region

End Class