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
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
   Inherits System.Windows.Forms.Form
   Private WithEvents xpTaskPane1 As Syncfusion.Windows.Forms.Tools.XPTaskPane
   Private panel1 As System.Windows.Forms.Panel
   Private xpTaskPage1 As Syncfusion.Windows.Forms.Tools.XPTaskPage
   Private label1 As System.Windows.Forms.Label
   Private xpTaskPage2 As Syncfusion.Windows.Forms.Tools.XPTaskPage
   Private xpTaskPage3 As Syncfusion.Windows.Forms.Tools.XPTaskPage
   Private xpTaskPage4 As Syncfusion.Windows.Forms.Tools.XPTaskPage
   Private linkLabel1 As System.Windows.Forms.LinkLabel
   Private linkLabel2 As System.Windows.Forms.LinkLabel
   Private linkLabel3 As System.Windows.Forms.LinkLabel
   Private linkLabel4 As System.Windows.Forms.LinkLabel
   Private label5 As System.Windows.Forms.Label
   Private linkLabel5 As System.Windows.Forms.LinkLabel
   Private linkLabel6 As System.Windows.Forms.LinkLabel
   Private linkLabel7 As System.Windows.Forms.LinkLabel
   Private linkLabel8 As System.Windows.Forms.LinkLabel
   Private label6 As System.Windows.Forms.Label
   Private linkLabel9 As System.Windows.Forms.LinkLabel
   Private label7 As System.Windows.Forms.Label
   Private linkLabel10 As System.Windows.Forms.LinkLabel
   Private linkLabel11 As System.Windows.Forms.LinkLabel
   Private linkLabel12 As System.Windows.Forms.LinkLabel
    Private linkLabel13 As System.Windows.Forms.LinkLabel
    Private linkLabel14 As System.Windows.Forms.LinkLabel
   Private checkBox1 As System.Windows.Forms.CheckBox
   Private label2 As System.Windows.Forms.Label
   Private label8 As System.Windows.Forms.Label
   Private textBox1 As System.Windows.Forms.TextBox
   Private button1 As System.Windows.Forms.Button
   Private button2 As System.Windows.Forms.Button
   Private linkLabel15 As System.Windows.Forms.LinkLabel
   Private label9 As System.Windows.Forms.Label
   Private label10 As System.Windows.Forms.Label
   Private comboBox1 As System.Windows.Forms.ComboBox
   Private label11 As System.Windows.Forms.Label
   Private comboBox2 As System.Windows.Forms.ComboBox
   Private label12 As System.Windows.Forms.Label
   Private linkLabel16 As System.Windows.Forms.LinkLabel
   Private panel3 As System.Windows.Forms.Panel
   Private label13 As System.Windows.Forms.Label
   Private linkLabel17 As System.Windows.Forms.LinkLabel
   Private linkLabel18 As System.Windows.Forms.LinkLabel
   Private label3 As System.Windows.Forms.Label
   Private button3 As System.Windows.Forms.Button
   Private button4 As System.Windows.Forms.Button
   Private label15 As System.Windows.Forms.Label
   Private listView1 As System.Windows.Forms.ListView
   Private label16 As System.Windows.Forms.Label
    Private comboBoxBase1 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
    Private label4 As System.Windows.Forms.Label
    Private radioButton1 As System.Windows.Forms.RadioButton
    Private textBox2 As System.Windows.Forms.TextBox
    Private radioButton2 As System.Windows.Forms.RadioButton
    Private radioButton3 As System.Windows.Forms.RadioButton
    Private label17 As System.Windows.Forms.Label
    Private label18 As System.Windows.Forms.Label
    Private comboBoxBase2 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
    Private button5 As System.Windows.Forms.Button
    Private label19 As System.Windows.Forms.Label
    Private listBox1 As System.Windows.Forms.ListBox
    Private label20 As System.Windows.Forms.Label
    Private button6 As System.Windows.Forms.Button
    Private label21 As System.Windows.Forms.Label
    Private comboBoxBase3 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
    Private button7 As System.Windows.Forms.Button
    Private richTextBox1 As System.Windows.Forms.RichTextBox
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Private label14 As System.Windows.Forms.Label
    Private components As System.ComponentModel.IContainer
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Private WithEvents wizardContainer1 As Syncfusion.Windows.Forms.Tools.WizardContainer


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Me.xpTaskPane1.HeaderMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
    End Sub 'New

    '
    ' TODO: Add any constructor code after InitializeComponent call
    '

    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Friend WithEvents XpTaskBar1 As Syncfusion.Windows.Forms.Tools.XPTaskBar
    Friend WithEvents XpTaskBarBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Clear Formatting"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Heading 1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Heading 2"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Normal"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.xpTaskPane1 = New Syncfusion.Windows.Forms.Tools.XPTaskPane
        Me.wizardContainer1 = New Syncfusion.Windows.Forms.Tools.WizardContainer
        Me.xpTaskPage1 = New Syncfusion.Windows.Forms.Tools.XPTaskPage
        Me.XpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar
        Me.XpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.linkLabel14 = New System.Windows.Forms.LinkLabel
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.linkLabel13 = New System.Windows.Forms.LinkLabel
        Me.linkLabel12 = New System.Windows.Forms.LinkLabel
        Me.linkLabel11 = New System.Windows.Forms.LinkLabel
        Me.linkLabel10 = New System.Windows.Forms.LinkLabel
        Me.label7 = New System.Windows.Forms.Label
        Me.linkLabel9 = New System.Windows.Forms.LinkLabel
        Me.label6 = New System.Windows.Forms.Label
        Me.linkLabel8 = New System.Windows.Forms.LinkLabel
        Me.linkLabel7 = New System.Windows.Forms.LinkLabel
        Me.linkLabel6 = New System.Windows.Forms.LinkLabel
        Me.linkLabel5 = New System.Windows.Forms.LinkLabel
        Me.label5 = New System.Windows.Forms.Label
        Me.linkLabel4 = New System.Windows.Forms.LinkLabel
        Me.linkLabel3 = New System.Windows.Forms.LinkLabel
        Me.linkLabel2 = New System.Windows.Forms.LinkLabel
        Me.linkLabel1 = New System.Windows.Forms.LinkLabel
        Me.label1 = New System.Windows.Forms.Label
        Me.xpTaskPage2 = New Syncfusion.Windows.Forms.Tools.XPTaskPage
        Me.panel3 = New System.Windows.Forms.Panel
        Me.linkLabel18 = New System.Windows.Forms.LinkLabel
        Me.linkLabel17 = New System.Windows.Forms.LinkLabel
        Me.label13 = New System.Windows.Forms.Label
        Me.linkLabel16 = New System.Windows.Forms.LinkLabel
        Me.label12 = New System.Windows.Forms.Label
        Me.comboBox2 = New System.Windows.Forms.ComboBox
        Me.label11 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.label10 = New System.Windows.Forms.Label
        Me.label9 = New System.Windows.Forms.Label
        Me.linkLabel15 = New System.Windows.Forms.LinkLabel
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.textBox1 = New System.Windows.Forms.TextBox
        Me.label8 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.xpTaskPage3 = New Syncfusion.Windows.Forms.Tools.XPTaskPage
        Me.comboBoxBase1 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase
        Me.label16 = New System.Windows.Forms.Label
        Me.listView1 = New System.Windows.Forms.ListView
        Me.label15 = New System.Windows.Forms.Label
        Me.button4 = New System.Windows.Forms.Button
        Me.button3 = New System.Windows.Forms.Button
        Me.label14 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.xpTaskPage4 = New Syncfusion.Windows.Forms.Tools.XPTaskPage
        Me.button7 = New System.Windows.Forms.Button
        Me.comboBoxBase3 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase
        Me.label21 = New System.Windows.Forms.Label
        Me.button6 = New System.Windows.Forms.Button
        Me.label20 = New System.Windows.Forms.Label
        Me.listBox1 = New System.Windows.Forms.ListBox
        Me.label19 = New System.Windows.Forms.Label
        Me.button5 = New System.Windows.Forms.Button
        Me.comboBoxBase2 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase
        Me.label18 = New System.Windows.Forms.Label
        Me.label17 = New System.Windows.Forms.Label
        Me.radioButton3 = New System.Windows.Forms.RadioButton
        Me.radioButton2 = New System.Windows.Forms.RadioButton
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.radioButton1 = New System.Windows.Forms.RadioButton
        Me.label4 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem2 = New System.Windows.Forms.MenuItem
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        CType(Me.xpTaskPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpTaskPane1.Header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xpTaskPane1.SuspendLayout()
        Me.wizardContainer1.SuspendLayout()
        CType(Me.xpTaskPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xpTaskPage1.SuspendLayout()
        CType(Me.XpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XpTaskBar1.SuspendLayout()
        Me.XpTaskBarBox1.SuspendLayout()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.xpTaskPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xpTaskPage2.SuspendLayout()
        Me.panel3.SuspendLayout()
        CType(Me.xpTaskPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xpTaskPage3.SuspendLayout()
        CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpTaskPage4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xpTaskPage4.SuspendLayout()
        CType(Me.comboBoxBase3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboBoxBase2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xpTaskPane1
        '
        Me.xpTaskPane1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xpTaskPane1.Controls.Add(Me.wizardContainer1)
        Me.xpTaskPane1.Dock = System.Windows.Forms.DockStyle.Right
        '
        '
        '
        Me.xpTaskPane1.Header.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.xpTaskPane1.Header.BorderColor = System.Drawing.Color.Black
        Me.xpTaskPane1.Header.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xpTaskPane1.Header.Controls.Add(Me.xpTaskPane1.HeaderLabel)
        Me.xpTaskPane1.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.xpTaskPane1.Header.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xpTaskPane1.Header.Location = New System.Drawing.Point(0, 0)
        Me.xpTaskPane1.Header.Name = "header"
        Me.xpTaskPane1.Header.Size = New System.Drawing.Size(256, 22)
        Me.xpTaskPane1.Header.TabIndex = 0
        '
        '
        '
        Me.xpTaskPane1.HeaderLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xpTaskPane1.HeaderLabel.ForeColor = System.Drawing.Color.Black
        Me.xpTaskPane1.HeaderLabel.Location = New System.Drawing.Point(45, 0)
        Me.xpTaskPane1.HeaderLabel.Name = "titleLabel"
        Me.xpTaskPane1.HeaderLabel.Size = New System.Drawing.Size(166, 22)
        Me.xpTaskPane1.HeaderLabel.TabIndex = 0
        Me.xpTaskPane1.HeaderLabel.Text = "Title"
        Me.xpTaskPane1.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '
        '
        Me.xpTaskPane1.HeaderMenuItem.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.xpTaskPane1.HeaderMenuItem.ImageIndex = 2
        Me.xpTaskPane1.HeaderMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
        Me.xpTaskPane1.Location = New System.Drawing.Point(408, 0)
        Me.xpTaskPane1.Name = "xpTaskPane1"
        Me.xpTaskPane1.SelectedPage = Me.xpTaskPage1
        Me.xpTaskPane1.Size = New System.Drawing.Size(256, 553)
        Me.xpTaskPane1.TabIndex = 1
        Me.xpTaskPane1.TaskPages = New Syncfusion.Windows.Forms.Tools.XPTaskPage() {Me.xpTaskPage1, Me.xpTaskPage2, Me.xpTaskPage3, Me.xpTaskPage4}
        Me.xpTaskPane1.TaskPanePageContainer = Me.wizardContainer1
        '
        'wizardContainer1
        '
        Me.wizardContainer1.Controls.Add(Me.xpTaskPage1)
        Me.wizardContainer1.Controls.Add(Me.xpTaskPage2)
        Me.wizardContainer1.Controls.Add(Me.xpTaskPage3)
        Me.wizardContainer1.Controls.Add(Me.xpTaskPage4)
        Me.wizardContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wizardContainer1.Location = New System.Drawing.Point(0, 22)
        Me.wizardContainer1.Name = "wizardContainer1"
        Me.wizardContainer1.Size = New System.Drawing.Size(256, 531)
        Me.wizardContainer1.TabIndex = 0
        '
        'xpTaskPage1
        '
        Me.xpTaskPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xpTaskPage1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(206, Byte), Integer)))
        Me.xpTaskPage1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.xpTaskPage1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xpTaskPage1.Controls.Add(Me.XpTaskBar1)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel12)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel11)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel10)
        Me.xpTaskPage1.Controls.Add(Me.label7)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel9)
        Me.xpTaskPage1.Controls.Add(Me.label6)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel8)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel7)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel6)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel5)
        Me.xpTaskPage1.Controls.Add(Me.label5)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel4)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel3)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel2)
        Me.xpTaskPage1.Controls.Add(Me.linkLabel1)
        Me.xpTaskPage1.Controls.Add(Me.label1)
        Me.xpTaskPage1.LayoutName = "Card1"
        Me.xpTaskPage1.Location = New System.Drawing.Point(0, 0)
        Me.xpTaskPage1.Name = "xpTaskPage1"
        Me.xpTaskPage1.NextPage = Nothing
        Me.xpTaskPage1.PreviousPage = Nothing
        Me.xpTaskPage1.Size = New System.Drawing.Size(256, 531)
        Me.xpTaskPage1.TabIndex = 0
        Me.xpTaskPage1.ThemesEnabled = True
        Me.xpTaskPage1.Title = "New Document"
        '
        'XpTaskBar1
        '
        Me.XpTaskBar1.BackColor = System.Drawing.Color.Transparent
        Me.XpTaskBar1.Controls.Add(Me.XpTaskBarBox1)
        Me.XpTaskBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.XpTaskBar1.Location = New System.Drawing.Point(0, 411)
        Me.XpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
        Me.XpTaskBar1.Name = "XpTaskBar1"
        Me.XpTaskBar1.Padding = New System.Windows.Forms.Padding(10)
        Me.XpTaskBar1.Size = New System.Drawing.Size(256, 120)
        Me.XpTaskBar1.TabIndex = 17
        '
        'XpTaskBarBox1
        '
        Me.XpTaskBarBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.XpTaskBarBox1.Controls.Add(Me.GradientPanel1)
        Me.XpTaskBarBox1.HeaderFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XpTaskBarBox1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.XpTaskBarBox1.HeaderImageIndex = -1
        Me.XpTaskBarBox1.HitTaskBoxArea = False
        Me.XpTaskBarBox1.ItemBackColor = System.Drawing.SystemColors.Window
        Me.XpTaskBarBox1.Location = New System.Drawing.Point(10, 10)
        Me.XpTaskBarBox1.Name = "XpTaskBarBox1"
        Me.XpTaskBarBox1.PreferredChildPanelHeight = 80
        Me.XpTaskBarBox1.ShowCollapseButton = False
        Me.XpTaskBarBox1.Size = New System.Drawing.Size(236, 109)
        Me.XpTaskBarBox1.TabIndex = 0
        Me.XpTaskBarBox1.Text = "See Also"
        '
        'GradientPanel1
        '
        Me.GradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.GradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GradientPanel1.Controls.Add(Me.linkLabel14)
        Me.GradientPanel1.Controls.Add(Me.checkBox1)
        Me.GradientPanel1.Controls.Add(Me.linkLabel13)
        Me.GradientPanel1.Location = New System.Drawing.Point(2, 27)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(232, 80)
        Me.GradientPanel1.TabIndex = 0
        '
        'linkLabel14
        '
        Me.linkLabel14.Image = CType(resources.GetObject("linkLabel14.Image"), System.Drawing.Image)
        Me.linkLabel14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel14.Location = New System.Drawing.Point(0, 8)
        Me.linkLabel14.Name = "linkLabel14"
        Me.linkLabel14.Size = New System.Drawing.Size(128, 16)
        Me.linkLabel14.TabIndex = 9
        Me.linkLabel14.TabStop = True
        Me.linkLabel14.Text = "Add Network Place..."
        Me.linkLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'checkBox1
        '
        Me.checkBox1.Location = New System.Drawing.Point(8, 56)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(120, 16)
        Me.checkBox1.TabIndex = 10
        Me.checkBox1.Text = "Show at startup"
        '
        'linkLabel13
        '
        Me.linkLabel13.Image = CType(resources.GetObject("linkLabel13.Image"), System.Drawing.Image)
        Me.linkLabel13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel13.Location = New System.Drawing.Point(0, 32)
        Me.linkLabel13.Name = "linkLabel13"
        Me.linkLabel13.Size = New System.Drawing.Size(128, 16)
        Me.linkLabel13.TabIndex = 8
        Me.linkLabel13.TabStop = True
        Me.linkLabel13.Text = "Microsoft Word Help"
        Me.linkLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'linkLabel12
        '
        Me.linkLabel12.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel12.Image = CType(resources.GetObject("linkLabel12.Image"), System.Drawing.Image)
        Me.linkLabel12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel12.Location = New System.Drawing.Point(24, 296)
        Me.linkLabel12.Name = "linkLabel12"
        Me.linkLabel12.Size = New System.Drawing.Size(176, 16)
        Me.linkLabel12.TabIndex = 15
        Me.linkLabel12.TabStop = True
        Me.linkLabel12.Text = "Templates on my Web Sites..."
        Me.linkLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'linkLabel11
        '
        Me.linkLabel11.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel11.Image = CType(resources.GetObject("linkLabel11.Image"), System.Drawing.Image)
        Me.linkLabel11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel11.Location = New System.Drawing.Point(24, 320)
        Me.linkLabel11.Name = "linkLabel11"
        Me.linkLabel11.Size = New System.Drawing.Size(168, 16)
        Me.linkLabel11.TabIndex = 14
        Me.linkLabel11.TabStop = True
        Me.linkLabel11.Text = "Templates on Microsoft.com"
        Me.linkLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'linkLabel10
        '
        Me.linkLabel10.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel10.Image = CType(resources.GetObject("linkLabel10.Image"), System.Drawing.Image)
        Me.linkLabel10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel10.Location = New System.Drawing.Point(24, 272)
        Me.linkLabel10.Name = "linkLabel10"
        Me.linkLabel10.Size = New System.Drawing.Size(136, 16)
        Me.linkLabel10.TabIndex = 13
        Me.linkLabel10.TabStop = True
        Me.linkLabel10.Text = "General Templates..."
        Me.linkLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label7
        '
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(16, 249)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(208, 16)
        Me.label7.TabIndex = 12
        Me.label7.Text = "New from template"
        '
        'linkLabel9
        '
        Me.linkLabel9.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel9.Image = CType(resources.GetObject("linkLabel9.Image"), System.Drawing.Image)
        Me.linkLabel9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel9.Location = New System.Drawing.Point(24, 224)
        Me.linkLabel9.Name = "linkLabel9"
        Me.linkLabel9.Size = New System.Drawing.Size(120, 16)
        Me.linkLabel9.TabIndex = 11
        Me.linkLabel9.TabStop = True
        Me.linkLabel9.Text = "Choose document"
        Me.linkLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label6
        '
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(16, 208)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(208, 16)
        Me.label6.TabIndex = 10
        Me.label6.Text = "New from existing document"
        '
        'linkLabel8
        '
        Me.linkLabel8.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel8.Image = CType(resources.GetObject("linkLabel8.Image"), System.Drawing.Image)
        Me.linkLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel8.Location = New System.Drawing.Point(24, 144)
        Me.linkLabel8.Name = "linkLabel8"
        Me.linkLabel8.Size = New System.Drawing.Size(112, 16)
        Me.linkLabel8.TabIndex = 9
        Me.linkLabel8.TabStop = True
        Me.linkLabel8.Text = "Blank Document"
        Me.linkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'linkLabel7
        '
        Me.linkLabel7.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel7.Image = CType(resources.GetObject("linkLabel7.Image"), System.Drawing.Image)
        Me.linkLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel7.Location = New System.Drawing.Point(24, 165)
        Me.linkLabel7.Name = "linkLabel7"
        Me.linkLabel7.Size = New System.Drawing.Size(112, 16)
        Me.linkLabel7.TabIndex = 8
        Me.linkLabel7.TabStop = True
        Me.linkLabel7.Text = "Blank Web Page"
        Me.linkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'linkLabel6
        '
        Me.linkLabel6.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel6.Image = CType(resources.GetObject("linkLabel6.Image"), System.Drawing.Image)
        Me.linkLabel6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel6.Location = New System.Drawing.Point(24, 186)
        Me.linkLabel6.Name = "linkLabel6"
        Me.linkLabel6.Size = New System.Drawing.Size(136, 16)
        Me.linkLabel6.TabIndex = 7
        Me.linkLabel6.TabStop = True
        Me.linkLabel6.Text = "Blank E-mail Message"
        Me.linkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'linkLabel5
        '
        Me.linkLabel5.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel5.Image = CType(resources.GetObject("linkLabel5.Image"), System.Drawing.Image)
        Me.linkLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel5.Location = New System.Drawing.Point(24, 103)
        Me.linkLabel5.Name = "linkLabel5"
        Me.linkLabel5.Size = New System.Drawing.Size(117, 16)
        Me.linkLabel5.TabIndex = 6
        Me.linkLabel5.TabStop = True
        Me.linkLabel5.Text = "More documents..."
        Me.linkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label5
        '
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(16, 128)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(88, 16)
        Me.label5.TabIndex = 5
        Me.label5.Text = "New"
        '
        'linkLabel4
        '
        Me.linkLabel4.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel4.Location = New System.Drawing.Point(48, 87)
        Me.linkLabel4.Name = "linkLabel4"
        Me.linkLabel4.Size = New System.Drawing.Size(100, 16)
        Me.linkLabel4.TabIndex = 4
        Me.linkLabel4.TabStop = True
        Me.linkLabel4.Text = "Document 4"
        '
        'linkLabel3
        '
        Me.linkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel3.Location = New System.Drawing.Point(48, 70)
        Me.linkLabel3.Name = "linkLabel3"
        Me.linkLabel3.Size = New System.Drawing.Size(100, 16)
        Me.linkLabel3.TabIndex = 3
        Me.linkLabel3.TabStop = True
        Me.linkLabel3.Text = "Document 3"
        '
        'linkLabel2
        '
        Me.linkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel2.Location = New System.Drawing.Point(48, 53)
        Me.linkLabel2.Name = "linkLabel2"
        Me.linkLabel2.Size = New System.Drawing.Size(100, 16)
        Me.linkLabel2.TabIndex = 2
        Me.linkLabel2.TabStop = True
        Me.linkLabel2.Text = "Document 2"
        '
        'linkLabel1
        '
        Me.linkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel1.Location = New System.Drawing.Point(48, 36)
        Me.linkLabel1.Name = "linkLabel1"
        Me.linkLabel1.Size = New System.Drawing.Size(100, 16)
        Me.linkLabel1.TabIndex = 1
        Me.linkLabel1.TabStop = True
        Me.linkLabel1.Text = "Document 1"
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(16, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(208, 16)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Open a document                                              "
        '
        'xpTaskPage2
        '
        Me.xpTaskPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xpTaskPage2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(206, Byte), Integer)))
        Me.xpTaskPage2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.xpTaskPage2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xpTaskPage2.Controls.Add(Me.panel3)
        Me.xpTaskPage2.Controls.Add(Me.linkLabel16)
        Me.xpTaskPage2.Controls.Add(Me.label12)
        Me.xpTaskPage2.Controls.Add(Me.comboBox2)
        Me.xpTaskPage2.Controls.Add(Me.label11)
        Me.xpTaskPage2.Controls.Add(Me.comboBox1)
        Me.xpTaskPage2.Controls.Add(Me.label10)
        Me.xpTaskPage2.Controls.Add(Me.label9)
        Me.xpTaskPage2.Controls.Add(Me.linkLabel15)
        Me.xpTaskPage2.Controls.Add(Me.button2)
        Me.xpTaskPage2.Controls.Add(Me.button1)
        Me.xpTaskPage2.Controls.Add(Me.textBox1)
        Me.xpTaskPage2.Controls.Add(Me.label8)
        Me.xpTaskPage2.Controls.Add(Me.label2)
        Me.xpTaskPage2.LayoutName = "Card2"
        Me.xpTaskPage2.Location = New System.Drawing.Point(0, 0)
        Me.xpTaskPage2.Name = "xpTaskPage2"
        Me.xpTaskPage2.NextPage = Nothing
        Me.xpTaskPage2.PreviousPage = Nothing
        Me.xpTaskPage2.Size = New System.Drawing.Size(256, 531)
        Me.xpTaskPage2.TabIndex = 1
        Me.xpTaskPage2.ThemesEnabled = True
        Me.xpTaskPage2.Title = "Basic Search"
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.White
        Me.panel3.Controls.Add(Me.linkLabel18)
        Me.panel3.Controls.Add(Me.linkLabel17)
        Me.panel3.Controls.Add(Me.label13)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel3.Location = New System.Drawing.Point(0, 459)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(256, 72)
        Me.panel3.TabIndex = 14
        '
        'linkLabel18
        '
        Me.linkLabel18.Location = New System.Drawing.Point(24, 43)
        Me.linkLabel18.Name = "linkLabel18"
        Me.linkLabel18.Size = New System.Drawing.Size(144, 23)
        Me.linkLabel18.TabIndex = 4
        Me.linkLabel18.TabStop = True
        Me.linkLabel18.Text = "Find in this document"
        '
        'linkLabel17
        '
        Me.linkLabel17.Location = New System.Drawing.Point(24, 24)
        Me.linkLabel17.Name = "linkLabel17"
        Me.linkLabel17.Size = New System.Drawing.Size(100, 16)
        Me.linkLabel17.TabIndex = 3
        Me.linkLabel17.TabStop = True
        Me.linkLabel17.Text = "Advanced Search"
        '
        'label13
        '
        Me.label13.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label13.Location = New System.Drawing.Point(16, 8)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(208, 16)
        Me.label13.TabIndex = 2
        Me.label13.Text = "See also"
        '
        'linkLabel16
        '
        Me.linkLabel16.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel16.Location = New System.Drawing.Point(24, 280)
        Me.linkLabel16.Name = "linkLabel16"
        Me.linkLabel16.Size = New System.Drawing.Size(184, 16)
        Me.linkLabel16.TabIndex = 13
        Me.linkLabel16.TabStop = True
        Me.linkLabel16.Text = "Search options..."
        '
        'label12
        '
        Me.label12.BackColor = System.Drawing.Color.Transparent
        Me.label12.Location = New System.Drawing.Point(24, 264)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(192, 20)
        Me.label12.TabIndex = 12
        Me.label12.Text = "Fast searching is currently disabled"
        '
        'comboBox2
        '
        Me.comboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBox2.Location = New System.Drawing.Point(24, 232)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(200, 21)
        Me.comboBox2.TabIndex = 11
        Me.comboBox2.Text = "Selected locations"
        '
        'label11
        '
        Me.label11.BackColor = System.Drawing.Color.Transparent
        Me.label11.Location = New System.Drawing.Point(24, 210)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(100, 16)
        Me.label11.TabIndex = 10
        Me.label11.Text = "Results should be:"
        '
        'comboBox1
        '
        Me.comboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBox1.Location = New System.Drawing.Point(24, 181)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(200, 21)
        Me.comboBox1.TabIndex = 9
        Me.comboBox1.Text = "Selected locations"
        '
        'label10
        '
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Location = New System.Drawing.Point(24, 160)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(100, 16)
        Me.label10.TabIndex = 8
        Me.label10.Text = "Search in:"
        '
        'label9
        '
        Me.label9.BackColor = System.Drawing.Color.Transparent
        Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(8, 136)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(208, 16)
        Me.label9.TabIndex = 7
        Me.label9.Text = "Other Search Options:"
        '
        'linkLabel15
        '
        Me.linkLabel15.BackColor = System.Drawing.Color.Transparent
        Me.linkLabel15.Image = CType(resources.GetObject("linkLabel15.Image"), System.Drawing.Image)
        Me.linkLabel15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.linkLabel15.Location = New System.Drawing.Point(24, 112)
        Me.linkLabel15.Name = "linkLabel15"
        Me.linkLabel15.Size = New System.Drawing.Size(88, 16)
        Me.linkLabel15.TabIndex = 6
        Me.linkLabel15.TabStop = True
        Me.linkLabel15.Text = "Search Tips..."
        Me.linkLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Location = New System.Drawing.Point(88, 80)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(64, 23)
        Me.button2.TabIndex = 5
        Me.button2.Text = "Restore"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button1.Location = New System.Drawing.Point(24, 80)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(56, 23)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Search"
        '
        'textBox1
        '
        Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBox1.Location = New System.Drawing.Point(24, 56)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(184, 20)
        Me.textBox1.TabIndex = 3
        '
        'label8
        '
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Location = New System.Drawing.Point(24, 32)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(100, 16)
        Me.label8.TabIndex = 2
        Me.label8.Text = "Search text:"
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(8, 8)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(208, 16)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Search for:"
        '
        'xpTaskPage3
        '
        Me.xpTaskPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xpTaskPage3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(206, Byte), Integer)))
        Me.xpTaskPage3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.xpTaskPage3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xpTaskPage3.Controls.Add(Me.comboBoxBase1)
        Me.xpTaskPage3.Controls.Add(Me.label16)
        Me.xpTaskPage3.Controls.Add(Me.listView1)
        Me.xpTaskPage3.Controls.Add(Me.label15)
        Me.xpTaskPage3.Controls.Add(Me.button4)
        Me.xpTaskPage3.Controls.Add(Me.button3)
        Me.xpTaskPage3.Controls.Add(Me.label14)
        Me.xpTaskPage3.Controls.Add(Me.label3)
        Me.xpTaskPage3.LayoutName = "Card3"
        Me.xpTaskPage3.Location = New System.Drawing.Point(0, 0)
        Me.xpTaskPage3.Name = "xpTaskPage3"
        Me.xpTaskPage3.NextPage = Nothing
        Me.xpTaskPage3.PreviousPage = Nothing
        Me.xpTaskPage3.Size = New System.Drawing.Size(256, 531)
        Me.xpTaskPage3.TabIndex = 2
        Me.xpTaskPage3.ThemesEnabled = True
        Me.xpTaskPage3.Title = "Styles and Formatting"
        '
        'comboBoxBase1
        '
        Me.comboBoxBase1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxBase1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboBoxBase1.FlatBorderColor = System.Drawing.SystemColors.ControlDark
        Me.comboBoxBase1.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
        Me.comboBoxBase1.IgnoreThemeBackground = True
        Me.comboBoxBase1.Location = New System.Drawing.Point(56, 496)
        Me.comboBoxBase1.Name = "comboBoxBase1"
        Me.comboBoxBase1.Size = New System.Drawing.Size(176, 21)
        Me.comboBoxBase1.SuppressDropDownEvent = False
        Me.comboBoxBase1.TabIndex = 9
        Me.comboBoxBase1.Text = "Available formatting"
        '
        'label16
        '
        Me.label16.BackColor = System.Drawing.Color.Transparent
        Me.label16.Location = New System.Drawing.Point(16, 496)
        Me.label16.Name = "label16"
        Me.label16.Size = New System.Drawing.Size(56, 16)
        Me.label16.TabIndex = 8
        Me.label16.Text = "Show"
        '
        'listView1
        '
        Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.listView1.Location = New System.Drawing.Point(24, 144)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(208, 336)
        Me.listView1.TabIndex = 7
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.List
        '
        'label15
        '
        Me.label15.BackColor = System.Drawing.Color.Transparent
        Me.label15.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(8, 112)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(208, 16)
        Me.label15.TabIndex = 6
        Me.label15.Text = "Pick formatting to apply"
        '
        'button4
        '
        Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button4.Location = New System.Drawing.Point(88, 72)
        Me.button4.Name = "button4"
        Me.button4.Size = New System.Drawing.Size(75, 23)
        Me.button4.TabIndex = 5
        Me.button4.Text = "New Style"
        '
        'button3
        '
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button3.Location = New System.Drawing.Point(16, 72)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(64, 23)
        Me.button3.TabIndex = 4
        Me.button3.Text = "Select all"
        '
        'label14
        '
        Me.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label14.Location = New System.Drawing.Point(16, 32)
        Me.label14.Name = "label14"
        Me.label14.Size = New System.Drawing.Size(224, 24)
        Me.label14.TabIndex = 3
        Me.label14.Text = "Normal"
        Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(8, 8)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(208, 16)
        Me.label3.TabIndex = 2
        Me.label3.Text = "Formatting of selected text"
        '
        'xpTaskPage4
        '
        Me.xpTaskPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.xpTaskPage4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(206, Byte), Integer)))
        Me.xpTaskPage4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.xpTaskPage4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.xpTaskPage4.Controls.Add(Me.button7)
        Me.xpTaskPage4.Controls.Add(Me.comboBoxBase3)
        Me.xpTaskPage4.Controls.Add(Me.label21)
        Me.xpTaskPage4.Controls.Add(Me.button6)
        Me.xpTaskPage4.Controls.Add(Me.label20)
        Me.xpTaskPage4.Controls.Add(Me.listBox1)
        Me.xpTaskPage4.Controls.Add(Me.label19)
        Me.xpTaskPage4.Controls.Add(Me.button5)
        Me.xpTaskPage4.Controls.Add(Me.comboBoxBase2)
        Me.xpTaskPage4.Controls.Add(Me.label18)
        Me.xpTaskPage4.Controls.Add(Me.label17)
        Me.xpTaskPage4.Controls.Add(Me.radioButton3)
        Me.xpTaskPage4.Controls.Add(Me.radioButton2)
        Me.xpTaskPage4.Controls.Add(Me.textBox2)
        Me.xpTaskPage4.Controls.Add(Me.radioButton1)
        Me.xpTaskPage4.Controls.Add(Me.label4)
        Me.xpTaskPage4.LayoutName = "Card4"
        Me.xpTaskPage4.Location = New System.Drawing.Point(0, 0)
        Me.xpTaskPage4.Name = "xpTaskPage4"
        Me.xpTaskPage4.NextPage = Nothing
        Me.xpTaskPage4.PreviousPage = Nothing
        Me.xpTaskPage4.Size = New System.Drawing.Size(256, 531)
        Me.xpTaskPage4.TabIndex = 3
        Me.xpTaskPage4.ThemesEnabled = True
        Me.xpTaskPage4.Title = "Translate"
        '
        'button7
        '
        Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button7.Location = New System.Drawing.Point(208, 472)
        Me.button7.Name = "button7"
        Me.button7.Size = New System.Drawing.Size(40, 23)
        Me.button7.TabIndex = 18
        Me.button7.Text = "Go"
        '
        'comboBoxBase3
        '
        Me.comboBoxBase3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxBase3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comboBoxBase3.FlatBorderColor = System.Drawing.SystemColors.ControlDark
        Me.comboBoxBase3.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
        Me.comboBoxBase3.IgnoreThemeBackground = True
        Me.comboBoxBase3.Location = New System.Drawing.Point(24, 472)
        Me.comboBoxBase3.Name = "comboBoxBase3"
        Me.comboBoxBase3.Size = New System.Drawing.Size(176, 21)
        Me.comboBoxBase3.SuppressDropDownEvent = False
        Me.comboBoxBase3.TabIndex = 17
        '
        'label21
        '
        Me.label21.BackColor = System.Drawing.Color.Transparent
        Me.label21.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label21.Location = New System.Drawing.Point(16, 448)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(136, 16)
        Me.label21.TabIndex = 16
        Me.label21.Text = "Translate via the Web"
        '
        'button6
        '
        Me.button6.Enabled = False
        Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button6.Location = New System.Drawing.Point(168, 416)
        Me.button6.Name = "button6"
        Me.button6.Size = New System.Drawing.Size(75, 24)
        Me.button6.TabIndex = 15
        Me.button6.Text = "Replace"
        '
        'label20
        '
        Me.label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label20.BackColor = System.Drawing.Color.Transparent
        Me.label20.Location = New System.Drawing.Point(24, 376)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(200, 32)
        Me.label20.TabIndex = 14
        Me.label20.Text = "Select a word in the Results and click Replace to add it to your document"
        '
        'listBox1
        '
        Me.listBox1.HorizontalScrollbar = True
        Me.listBox1.Location = New System.Drawing.Point(16, 208)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(224, 147)
        Me.listBox1.TabIndex = 13
        '
        'label19
        '
        Me.label19.BackColor = System.Drawing.Color.Transparent
        Me.label19.Location = New System.Drawing.Point(16, 184)
        Me.label19.Name = "label19"
        Me.label19.Size = New System.Drawing.Size(100, 16)
        Me.label19.TabIndex = 12
        Me.label19.Text = "Results"
        '
        'button5
        '
        Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.button5.Location = New System.Drawing.Point(200, 152)
        Me.button5.Name = "button5"
        Me.button5.Size = New System.Drawing.Size(40, 23)
        Me.button5.TabIndex = 11
        Me.button5.Text = "Go"
        '
        'comboBoxBase2
        '
        Me.comboBoxBase2.Enabled = False
        Me.comboBoxBase2.FlatBorderColor = System.Drawing.SystemColors.ControlDark
        Me.comboBoxBase2.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
        Me.comboBoxBase2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.comboBoxBase2.IgnoreThemeBackground = True
        Me.comboBoxBase2.Location = New System.Drawing.Point(16, 152)
        Me.comboBoxBase2.Name = "comboBoxBase2"
        Me.comboBoxBase2.Size = New System.Drawing.Size(176, 21)
        Me.comboBoxBase2.SuppressDropDownEvent = False
        Me.comboBoxBase2.TabIndex = 10
        Me.comboBoxBase2.Text = "(no dictionaries available)"
        '
        'label18
        '
        Me.label18.BackColor = System.Drawing.Color.Transparent
        Me.label18.Location = New System.Drawing.Point(16, 136)
        Me.label18.Name = "label18"
        Me.label18.Size = New System.Drawing.Size(100, 16)
        Me.label18.TabIndex = 9
        Me.label18.Text = "Dictionary"
        '
        'label17
        '
        Me.label17.BackColor = System.Drawing.Color.Transparent
        Me.label17.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label17.Location = New System.Drawing.Point(8, 112)
        Me.label17.Name = "label17"
        Me.label17.Size = New System.Drawing.Size(136, 16)
        Me.label17.TabIndex = 8
        Me.label17.Text = "Look up in dicitionary"
        '
        'radioButton3
        '
        Me.radioButton3.BackColor = System.Drawing.Color.Transparent
        Me.radioButton3.Location = New System.Drawing.Point(16, 88)
        Me.radioButton3.Name = "radioButton3"
        Me.radioButton3.Size = New System.Drawing.Size(112, 16)
        Me.radioButton3.TabIndex = 7
        Me.radioButton3.Text = "Entire document"
        Me.radioButton3.UseVisualStyleBackColor = False
        '
        'radioButton2
        '
        Me.radioButton2.BackColor = System.Drawing.Color.Transparent
        Me.radioButton2.Checked = True
        Me.radioButton2.Location = New System.Drawing.Point(16, 64)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(120, 16)
        Me.radioButton2.TabIndex = 6
        Me.radioButton2.TabStop = True
        Me.radioButton2.Text = "Current selection"
        Me.radioButton2.UseVisualStyleBackColor = False
        '
        'textBox2
        '
        Me.textBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBox2.Location = New System.Drawing.Point(72, 32)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(168, 20)
        Me.textBox2.TabIndex = 5
        Me.textBox2.Text = "textBox2"
        '
        'radioButton1
        '
        Me.radioButton1.BackColor = System.Drawing.Color.Transparent
        Me.radioButton1.Location = New System.Drawing.Point(16, 32)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(48, 16)
        Me.radioButton1.TabIndex = 4
        Me.radioButton1.Text = "Text:"
        Me.radioButton1.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(8, 8)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(208, 16)
        Me.label4.TabIndex = 3
        Me.label4.Text = "Translate what?"
        '
        'panel1
        '
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel1.Location = New System.Drawing.Point(400, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(8, 553)
        Me.panel1.TabIndex = 2
        '
        'richTextBox1
        '
        Me.richTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(400, 553)
        Me.richTextBox1.TabIndex = 3
        Me.richTextBox1.Text = "The XP TaskPane is a container control that can host a number of pages (XP TaskPa" & _
            "ge) which the user can browse using a drop-down menu and the arrow buttons in ta" & _
            "sk pane's header portion"
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem2, Me.menuItem3, Me.MenuItem4})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.Text = "&File"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 1
        Me.menuItem2.Text = "&Edit"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 2
        Me.menuItem3.Text = "&View TaskPane"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem7, Me.MenuItem8})
        Me.MenuItem4.Text = "Visual Style"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "Default"
        '
        'MenuItem6
        '
        Me.MenuItem6.Checked = True
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Office2007 - Blue"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 2
        Me.MenuItem7.Text = "Office2007 - Silver"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 3
        Me.MenuItem8.Text = "Office2007 - Black"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 553)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.xpTaskPane1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Task Pane Demo"
        CType(Me.xpTaskPane1.Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpTaskPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xpTaskPane1.ResumeLayout(False)
        Me.wizardContainer1.ResumeLayout(False)
        CType(Me.xpTaskPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xpTaskPage1.ResumeLayout(False)
        CType(Me.XpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XpTaskBar1.ResumeLayout(False)
        Me.XpTaskBarBox1.ResumeLayout(False)
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        CType(Me.xpTaskPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xpTaskPage2.ResumeLayout(False)
        Me.xpTaskPage2.PerformLayout()
        Me.panel3.ResumeLayout(False)
        CType(Me.xpTaskPage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xpTaskPage3.ResumeLayout(False)
        CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpTaskPage4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xpTaskPage4.ResumeLayout(False)
        Me.xpTaskPage4.PerformLayout()
        CType(Me.comboBoxBase3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboBoxBase2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main

    Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
        Me.xpTaskPane1.Visible = Not Me.xpTaskPane1.Visible
    End Sub 'menuItem3_Click


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Office2003Colors.UpdateMenuColors()
        'Me.xpTaskPane1.Header.BackColor = Office2003Colors.MenuMarginColorDark
        'Me.xpTaskPane1.HeaderLabel.BackColor = Office2003Colors.MenuMarginColorDark

        Me.richTextBox1.BackColor = Office2003Colors.MenuMarginColorLight
        'Me.XpTaskBarBox1.HeaderBackColor = Office2003Colors.MenuMarginColorDark
        Me.xpTaskPane1.HeaderLabel.ForeColor = Color.White
        Me.xpTaskPane1.HeaderLabel.Font = New Font("Arial", 10, FontStyle.Bold)
        Me.xpTaskPage1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.MenuMarginColorLight, Office2003Colors.MenuMarginColorDark)
        Me.xpTaskPage2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.MenuMarginColorLight, Office2003Colors.MenuMarginColorDark)
        Me.xpTaskPage3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.MenuMarginColorLight, Office2003Colors.MenuMarginColorDark)
        Me.xpTaskPage4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.MenuMarginColorLight, Office2003Colors.MenuMarginColorDark)

        Me.xpTaskPane1.VisualStyle = VisualStyle.Office2007
        Me.xpTaskPane1.Office2007ColorScheme = Office2007Theme.Blue
        Me.XpTaskBar1.BackColor = Color.FromArgb(221, 237, 253)
        Me.panel3.BackColor = Color.FromArgb(221, 237, 253)

    End Sub
#Region "Visual styles"

    Private Sub ResetMenuCheckedState(ByVal item As MenuItem)
        For Each i As MenuItem In Me.MenuItem4.MenuItems
            If i.Text = item.Text Then
                i.Checked = True
            Else
                i.Checked = False
            End If
        Next
    End Sub


    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Me.xpTaskPane1.VisualStyle = VisualStyle.Default
        Me.XpTaskBar1.BackColor = Color.FromArgb(224, 223, 227)
        Me.panel3.BackColor = Color.FromArgb(224, 223, 227)
        ResetMenuCheckedState(CType(sender, MenuItem))

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Me.xpTaskPane1.VisualStyle = VisualStyle.Office2007
        Me.xpTaskPane1.Office2007ColorScheme = Office2007Theme.Blue
        Me.XpTaskBar1.BackColor = Color.FromArgb(221, 237, 253)
        Me.panel3.BackColor = Color.FromArgb(221, 237, 253)
        ResetMenuCheckedState(CType(sender, MenuItem))

    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Me.xpTaskPane1.VisualStyle = VisualStyle.Office2007
        Me.xpTaskPane1.Office2007ColorScheme = Office2007Theme.Silver
        Me.XpTaskBar1.BackColor = Color.FromArgb(232, 235, 248)
        Me.panel3.BackColor = Color.FromArgb(232, 235, 248)
        ResetMenuCheckedState(CType(sender, MenuItem))


    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Me.xpTaskPane1.VisualStyle = VisualStyle.Office2007
        Me.xpTaskPane1.Office2007ColorScheme = Office2007Theme.Black
        Me.XpTaskBar1.BackColor = Color.FromArgb(246, 243, 248)
        Me.panel3.BackColor = Color.FromArgb(246, 243, 248)
        ResetMenuCheckedState(CType(sender, MenuItem))


    End Sub
#End Region
End Class 'Form1 