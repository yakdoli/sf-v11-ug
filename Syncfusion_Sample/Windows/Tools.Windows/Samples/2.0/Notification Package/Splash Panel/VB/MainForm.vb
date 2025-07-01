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


Imports Microsoft.VisualBasic
	Imports System
	Imports System.Drawing
	Imports System.Collections
	Imports System.ComponentModel
	Imports System.Windows.Forms
	Imports System.Data
	Imports Syncfusion.Windows.Forms.Tools
	Imports Syncfusion.Drawing
	Imports System.Reflection
Namespace SplashPanelDemo

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class MainForm : Inherits System.Windows.Forms.Form
        Private toolTip1 As System.Windows.Forms.ToolTip
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private menuItem3 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
		Private alignBottomLeft As System.Windows.Forms.RadioButton
		Private alignTopRight As System.Windows.Forms.RadioButton
		Private alignTopLeft As System.Windows.Forms.RadioButton
		Private alignCenter As System.Windows.Forms.RadioButton
		Private alignSystemTray As System.Windows.Forms.RadioButton
		Private alignBottomRight As System.Windows.Forms.RadioButton
		Private groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents textBox1 As System.Windows.Forms.TextBox
		Private alignCustom As System.Windows.Forms.RadioButton
		Private trackBar1 As System.Windows.Forms.TrackBar
		Private timerInterval As System.Windows.Forms.TextBox
		Private currentPt1 As Point
		Private currentPt2 As Point
		Private currentPt3 As Point
		Private currentPt4 As Point
        Private splashPanel1Selected As System.Windows.Forms.RadioButton
		Private splashPanel2Selected As System.Windows.Forms.RadioButton
		Private WithEvents splashPanel1 As Syncfusion.Windows.Forms.Tools.SplashPanel
		Private WithEvents splashPanel2 As Syncfusion.Windows.Forms.Tools.SplashPanel
		Private linkLabel1 As System.Windows.Forms.LinkLabel
        Private WithEvents splashPanel3 As Syncfusion.Windows.Forms.Tools.SplashPanel
        Private label3 As System.Windows.Forms.Label
		Private splashPanel4Selected As System.Windows.Forms.RadioButton
		Private splashPanel3Selected As System.Windows.Forms.RadioButton
		Private WithEvents splashPanel4 As Syncfusion.Windows.Forms.Tools.SplashPanel
		Private checkedListBox1 As System.Windows.Forms.CheckedListBox
        Private label4 As System.Windows.Forms.Label
		Private WithEvents button5 As System.Windows.Forms.Button


		Private Delegate Sub SetStringDelegate(ByVal val As String) 'Any string value

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
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
        Friend WithEvents ButtonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents ButtonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents ButtonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents ButtonAdv4 As Syncfusion.Windows.Forms.ButtonAdv
        Friend WithEvents gradientPanel4 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Friend WithEvents GradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Friend WithEvents gradientLabel2 As Syncfusion.Windows.Forms.Tools.GradientLabel
        Friend WithEvents GradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Friend WithEvents gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.mainMenu1 = New System.Windows.Forms.MainMenu
            Me.menuItem1 = New System.Windows.Forms.MenuItem
            Me.menuItem2 = New System.Windows.Forms.MenuItem
            Me.menuItem3 = New System.Windows.Forms.MenuItem
            Me.menuItem4 = New System.Windows.Forms.MenuItem
            Me.alignCustom = New System.Windows.Forms.RadioButton
            Me.alignBottomLeft = New System.Windows.Forms.RadioButton
            Me.alignTopRight = New System.Windows.Forms.RadioButton
            Me.alignTopLeft = New System.Windows.Forms.RadioButton
            Me.alignCenter = New System.Windows.Forms.RadioButton
            Me.alignSystemTray = New System.Windows.Forms.RadioButton
            Me.alignBottomRight = New System.Windows.Forms.RadioButton
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.trackBar1 = New System.Windows.Forms.TrackBar
            Me.timerInterval = New System.Windows.Forms.TextBox
            Me.splashPanel1Selected = New System.Windows.Forms.RadioButton
            Me.splashPanel2Selected = New System.Windows.Forms.RadioButton
            Me.splashPanel4Selected = New System.Windows.Forms.RadioButton
            Me.splashPanel3Selected = New System.Windows.Forms.RadioButton
            Me.splashPanel1 = New Syncfusion.Windows.Forms.Tools.SplashPanel
            Me.linkLabel1 = New System.Windows.Forms.LinkLabel
            Me.splashPanel2 = New Syncfusion.Windows.Forms.Tools.SplashPanel
            Me.ButtonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox
            Me.splashPanel3 = New Syncfusion.Windows.Forms.Tools.SplashPanel
            Me.label3 = New System.Windows.Forms.Label
            Me.ButtonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.splashPanel4 = New Syncfusion.Windows.Forms.Tools.SplashPanel
            Me.button5 = New System.Windows.Forms.Button
            Me.label4 = New System.Windows.Forms.Label
            Me.ButtonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ButtonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.GradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.gradientLabel2 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.GradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.groupBox1.SuspendLayout()
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splashPanel1.SuspendLayout()
            Me.splashPanel2.SuspendLayout()
            Me.splashPanel3.SuspendLayout()
            Me.splashPanel4.SuspendLayout()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel4.SuspendLayout()
            CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GradientPanel1.SuspendLayout()
            CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GradientPanel2.SuspendLayout()
            CType(Me.GradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GradientPanel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'imageList1
            '
            Me.imageList1.ImageSize = New System.Drawing.Size(16, 16)
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem3})
            '
            'menuItem1
            '
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2})
            Me.menuItem1.Text = "File"
            '
            'menuItem2
            '
            Me.menuItem2.Index = 0
            Me.menuItem2.Text = "&Exit"
            '
            'menuItem3
            '
            Me.menuItem3.Index = 1
            Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem4})
            Me.menuItem3.Text = "Help"
            '
            'menuItem4
            '
            Me.menuItem4.Index = 0
            Me.menuItem4.Text = "About..."
            '
            'alignCustom
            '
            Me.alignCustom.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.alignCustom.ForeColor = System.Drawing.Color.MidnightBlue
            Me.alignCustom.Location = New System.Drawing.Point(320, 40)
            Me.alignCustom.Name = "alignCustom"
            Me.alignCustom.Size = New System.Drawing.Size(88, 24)
            Me.alignCustom.TabIndex = 30
            Me.alignCustom.Text = "Custom"
            '
            'alignBottomLeft
            '
            Me.alignBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.alignBottomLeft.ForeColor = System.Drawing.Color.MidnightBlue
            Me.alignBottomLeft.Location = New System.Drawing.Point(16, 80)
            Me.alignBottomLeft.Name = "alignBottomLeft"
            Me.alignBottomLeft.Size = New System.Drawing.Size(88, 24)
            Me.alignBottomLeft.TabIndex = 27
            Me.alignBottomLeft.Text = "BottomLeft"
            '
            'alignTopRight
            '
            Me.alignTopRight.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.alignTopRight.ForeColor = System.Drawing.Color.MidnightBlue
            Me.alignTopRight.Location = New System.Drawing.Point(224, 40)
            Me.alignTopRight.Name = "alignTopRight"
            Me.alignTopRight.Size = New System.Drawing.Size(80, 24)
            Me.alignTopRight.TabIndex = 26
            Me.alignTopRight.Text = "TopRight"
            '
            'alignTopLeft
            '
            Me.alignTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.alignTopLeft.ForeColor = System.Drawing.Color.MidnightBlue
            Me.alignTopLeft.Location = New System.Drawing.Point(16, 40)
            Me.alignTopLeft.Name = "alignTopLeft"
            Me.alignTopLeft.Size = New System.Drawing.Size(88, 24)
            Me.alignTopLeft.TabIndex = 28
            Me.alignTopLeft.Text = "TopLeft"
            '
            'alignCenter
            '
            Me.alignCenter.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.alignCenter.ForeColor = System.Drawing.Color.MidnightBlue
            Me.alignCenter.Location = New System.Drawing.Point(112, 40)
            Me.alignCenter.Name = "alignCenter"
            Me.alignCenter.Size = New System.Drawing.Size(80, 24)
            Me.alignCenter.TabIndex = 24
            Me.alignCenter.Text = "Center"
            '
            'alignSystemTray
            '
            Me.alignSystemTray.Checked = True
            Me.alignSystemTray.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.alignSystemTray.ForeColor = System.Drawing.Color.MidnightBlue
            Me.alignSystemTray.Location = New System.Drawing.Point(112, 80)
            Me.alignSystemTray.Name = "alignSystemTray"
            Me.alignSystemTray.Size = New System.Drawing.Size(88, 24)
            Me.alignSystemTray.TabIndex = 25
            Me.alignSystemTray.TabStop = True
            Me.alignSystemTray.Text = "System Tray"
            '
            'alignBottomRight
            '
            Me.alignBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.alignBottomRight.ForeColor = System.Drawing.Color.MidnightBlue
            Me.alignBottomRight.Location = New System.Drawing.Point(224, 80)
            Me.alignBottomRight.Name = "alignBottomRight"
            Me.alignBottomRight.Size = New System.Drawing.Size(88, 24)
            Me.alignBottomRight.TabIndex = 29
            Me.alignBottomRight.Text = "BottomRight"
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(234, Byte), CType(255, Byte))
            Me.groupBox1.Controls.Add(Me.textBox1)
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.groupBox1.Location = New System.Drawing.Point(0, 393)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(792, 160)
            Me.groupBox1.TabIndex = 8
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Events Log"
            '
            'textBox1
            '
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(3, 16)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textBox1.Size = New System.Drawing.Size(786, 141)
            Me.textBox1.TabIndex = 0
            Me.textBox1.Text = ""
            '
            'trackBar1
            '
            Me.trackBar1.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.trackBar1.Location = New System.Drawing.Point(64, 6)
            Me.trackBar1.Maximum = 50
            Me.trackBar1.Minimum = 2
            Me.trackBar1.Name = "trackBar1"
            Me.trackBar1.Size = New System.Drawing.Size(280, 45)
            Me.trackBar1.TabIndex = 14
            Me.trackBar1.TickFrequency = 5
            Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None
            Me.trackBar1.Value = 10
            '
            'timerInterval
            '
            Me.timerInterval.Location = New System.Drawing.Point(440, 8)
            Me.timerInterval.Name = "timerInterval"
            Me.timerInterval.Size = New System.Drawing.Size(80, 20)
            Me.timerInterval.TabIndex = 15
            Me.timerInterval.Text = "5000"
            '
            'splashPanel1Selected
            '
            Me.splashPanel1Selected.Checked = True
            Me.splashPanel1Selected.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.splashPanel1Selected.ForeColor = System.Drawing.Color.MidnightBlue
            Me.splashPanel1Selected.Location = New System.Drawing.Point(16, 40)
            Me.splashPanel1Selected.Name = "splashPanel1Selected"
            Me.splashPanel1Selected.TabIndex = 18
            Me.splashPanel1Selected.TabStop = True
            Me.splashPanel1Selected.Text = "Splash Panel 1"
            '
            'splashPanel2Selected
            '
            Me.splashPanel2Selected.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.splashPanel2Selected.ForeColor = System.Drawing.Color.MidnightBlue
            Me.splashPanel2Selected.Location = New System.Drawing.Point(160, 40)
            Me.splashPanel2Selected.Name = "splashPanel2Selected"
            Me.splashPanel2Selected.TabIndex = 19
            Me.splashPanel2Selected.Text = "Splash Panel 2"
            '
            'splashPanel4Selected
            '
            Me.splashPanel4Selected.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.splashPanel4Selected.ForeColor = System.Drawing.Color.MidnightBlue
            Me.splashPanel4Selected.Location = New System.Drawing.Point(160, 80)
            Me.splashPanel4Selected.Name = "splashPanel4Selected"
            Me.splashPanel4Selected.TabIndex = 21
            Me.splashPanel4Selected.Text = "Splash Panel 4"
            '
            'splashPanel3Selected
            '
            Me.splashPanel3Selected.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.splashPanel3Selected.ForeColor = System.Drawing.Color.MidnightBlue
            Me.splashPanel3Selected.Location = New System.Drawing.Point(16, 80)
            Me.splashPanel3Selected.Name = "splashPanel3Selected"
            Me.splashPanel3Selected.TabIndex = 20
            Me.splashPanel3Selected.Text = "Splash Panel 3"
            '
            'splashPanel1
            '
            Me.splashPanel1.AnimationSpeed = 10
            Me.splashPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.HighlightText)
            Me.splashPanel1.BackgroundImage = CType(resources.GetObject("splashPanel1.BackgroundImage"), System.Drawing.Image)
            Me.splashPanel1.Controls.Add(Me.linkLabel1)
            Me.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center
            Me.splashPanel1.DiscreetLocation = New System.Drawing.Point(0, 0)
            Me.splashPanel1.Location = New System.Drawing.Point(8, 32)
            Me.splashPanel1.Name = "splashPanel1"
            Me.splashPanel1.ShowAnimation = True
            Me.splashPanel1.Size = New System.Drawing.Size(176, 152)
            Me.splashPanel1.SlideStyle = Syncfusion.Windows.Forms.Tools.SlideStyle.TopToBottom
            Me.splashPanel1.SuspendAutoCloseWhenMouseOver = False
            Me.splashPanel1.TabIndex = 27
            Me.splashPanel1.TimerInterval = 5000
            '
            'linkLabel1
            '
            Me.linkLabel1.BackColor = System.Drawing.Color.Transparent
            Me.linkLabel1.ForeColor = System.Drawing.Color.White
            Me.linkLabel1.LinkColor = System.Drawing.Color.FloralWhite
            Me.linkLabel1.Location = New System.Drawing.Point(24, 64)
            Me.linkLabel1.Name = "linkLabel1"
            Me.linkLabel1.Size = New System.Drawing.Size(112, 24)
            Me.linkLabel1.TabIndex = 0
            Me.linkLabel1.TabStop = True
            Me.linkLabel1.Text = "www.syncfusion.com"
            '
            'splashPanel2
            '
            Me.splashPanel2.AnimationSpeed = 10
            Me.splashPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CInt(CByte((255))), CInt(CByte((228))), CInt(CByte((152)))), System.Drawing.Color.FromArgb(CInt(CByte((255))), CInt(CByte((223))), CInt(CByte((134)))), System.Drawing.Color.FromArgb(CInt(CByte((255))), CInt(CByte((218))), CInt(CByte((115)))), System.Drawing.Color.FromArgb(CInt(CByte((255))), CInt(CByte((236))), CInt(CByte((178)))), System.Drawing.Color.FromArgb(CInt(CByte((255))), CInt(CByte((240))), CInt(CByte((189)))), System.Drawing.Color.FromArgb(CInt(CByte((255))), CInt(CByte((250))), CInt(CByte((217))))})
            Me.splashPanel2.Controls.Add(Me.ButtonAdv2)
            Me.splashPanel2.Controls.Add(Me.checkedListBox1)
            Me.splashPanel2.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center
            Me.splashPanel2.DiscreetLocation = New System.Drawing.Point(0, 0)
            Me.splashPanel2.Location = New System.Drawing.Point(200, 32)
            Me.splashPanel2.Name = "splashPanel2"
            Me.splashPanel2.ShowAnimation = True
            Me.splashPanel2.SlideStyle = Syncfusion.Windows.Forms.Tools.SlideStyle.FadeIn
            Me.splashPanel2.Size = New System.Drawing.Size(200, 155)
            Me.splashPanel2.SuspendAutoCloseWhenMouseOver = True
            Me.splashPanel2.TabIndex = 28
            Me.splashPanel2.TimerInterval = 5000
            '
            'ButtonAdv2
            '
            Me.ButtonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.ButtonAdv2.KeepFocusRectangle = False
            Me.ButtonAdv2.Location = New System.Drawing.Point(120, 120)
            Me.ButtonAdv2.Name = "ButtonAdv2"
            Me.ButtonAdv2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
            Me.ButtonAdv2.Size = New System.Drawing.Size(64, 23)
            Me.ButtonAdv2.TabIndex = 1
            Me.ButtonAdv2.Text = "Close"
            Me.ButtonAdv2.UseVisualStyle = True
            '
            'checkedListBox1
            '
            Me.checkedListBox1.Items.AddRange(New Object() {"Write code.", "Test using NUnit.", "Test using Usage tests.", "Test on All platforms.", "Send download instructions."})
            Me.checkedListBox1.Location = New System.Drawing.Point(16, 16)
            Me.checkedListBox1.Name = "checkedListBox1"
            Me.checkedListBox1.Size = New System.Drawing.Size(168, 94)
            Me.checkedListBox1.TabIndex = 0
            '
            'splashPanel3
            '
            Me.splashPanel3.AnimationSpeed = 10
            Me.splashPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(73, Byte), CType(75, Byte), CType(78, Byte)), System.Drawing.Color.FromArgb(CType(87, Byte), CType(90, Byte), CType(94, Byte)), System.Drawing.Color.FromArgb(CType(104, Byte), CType(108, Byte), CType(113, Byte))})
            Me.splashPanel3.Controls.Add(Me.label3)
            Me.splashPanel3.Controls.Add(Me.ButtonAdv1)
            Me.splashPanel3.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center
            Me.splashPanel3.DiscreetLocation = New System.Drawing.Point(0, 0)
            Me.splashPanel3.Location = New System.Drawing.Point(432, 32)
            Me.splashPanel3.Name = "splashPanel3"
            Me.splashPanel3.ShowAnimation = True
            Me.splashPanel3.SlideStyle = Syncfusion.Windows.Forms.Tools.SlideStyle.LeftToRight
            Me.splashPanel3.Size = New System.Drawing.Size(168, 152)
            Me.splashPanel3.SuspendAutoCloseWhenMouseOver = False
            Me.splashPanel3.TabIndex = 30
            Me.splashPanel3.TimerInterval = 5000
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.ForeColor = System.Drawing.Color.White
            Me.label3.Location = New System.Drawing.Point(24, 40)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(120, 40)
            Me.label3.TabIndex = 1
            Me.label3.Text = "The Anti Virus scan is complete."
            Me.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'ButtonAdv1
            '
            Me.ButtonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.ButtonAdv1.KeepFocusRectangle = False
            Me.ButtonAdv1.Location = New System.Drawing.Point(48, 120)
            Me.ButtonAdv1.Name = "ButtonAdv1"
            Me.ButtonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black
            Me.ButtonAdv1.TabIndex = 32
            Me.ButtonAdv1.Text = "OK"
            Me.ButtonAdv1.UseVisualStyle = True
            '
            'splashPanel4
            '
            Me.splashPanel4.AnimationSpeed = 10
            Me.splashPanel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.FromArgb(CType(250, Byte), CType(253, Byte), CType(249, Byte)), System.Drawing.Color.FromArgb(CType(223, Byte), CType(244, Byte), CType(212, Byte)))
            Me.splashPanel4.Controls.Add(Me.button5)
            Me.splashPanel4.Controls.Add(Me.label4)
            Me.splashPanel4.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center
            Me.splashPanel4.DiscreetLocation = New System.Drawing.Point(0, 0)
            Me.splashPanel4.Location = New System.Drawing.Point(624, 32)
            Me.splashPanel4.Name = "splashPanel4"
            Me.splashPanel4.ShowAnimation = True
            Me.splashPanel4.SlideStyle = Syncfusion.Windows.Forms.Tools.SlideStyle.Slide
            Me.splashPanel4.Size = New System.Drawing.Size(160, 152)
            Me.splashPanel4.SuspendAutoCloseWhenMouseOver = False
            Me.splashPanel4.TabIndex = 31
            Me.splashPanel4.TimerInterval = 5000
            '
            'button5
            '
            Me.button5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button5.Image = CType(resources.GetObject("button5.Image"), System.Drawing.Image)
            Me.button5.Location = New System.Drawing.Point(136, 0)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(21, 21)
            Me.button5.TabIndex = 3
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.label4.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(16, 64)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(120, 40)
            Me.label4.TabIndex = 2
            Me.label4.Text = "You have received a new message"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'ButtonAdv3
            '
            Me.ButtonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.ButtonAdv3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.ButtonAdv3.KeepFocusRectangle = False
            Me.ButtonAdv3.Location = New System.Drawing.Point(8, 8)
            Me.ButtonAdv3.Name = "ButtonAdv3"
            Me.ButtonAdv3.Size = New System.Drawing.Size(128, 23)
            Me.ButtonAdv3.TabIndex = 32
            Me.ButtonAdv3.Text = "Show Splash (Modal)"
            Me.ButtonAdv3.UseVisualStyle = True
            '
            'ButtonAdv4
            '
            Me.ButtonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.ButtonAdv4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.ButtonAdv4.KeepFocusRectangle = False
            Me.ButtonAdv4.Location = New System.Drawing.Point(144, 8)
            Me.ButtonAdv4.Name = "ButtonAdv4"
            Me.ButtonAdv4.Size = New System.Drawing.Size(88, 23)
            Me.ButtonAdv4.TabIndex = 32
            Me.ButtonAdv4.Text = "Show Splash"
            Me.ButtonAdv4.UseVisualStyle = True
            '
            'gradientPanel4
            '
            Me.gradientPanel4.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(171, Byte), CType(206, Byte))
            Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel4.Controls.Add(Me.Label5)
            Me.gradientPanel4.Controls.Add(Me.Label6)
            Me.gradientPanel4.Controls.Add(Me.trackBar1)
            Me.gradientPanel4.Controls.Add(Me.timerInterval)
            Me.gradientPanel4.Location = New System.Drawing.Point(8, 200)
            Me.gradientPanel4.Name = "gradientPanel4"
            Me.gradientPanel4.Size = New System.Drawing.Size(528, 40)
            Me.gradientPanel4.TabIndex = 36
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.Label5.Location = New System.Drawing.Point(16, 8)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(40, 16)
            Me.Label5.TabIndex = 21
            Me.Label5.Text = "Speed"
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.Label6.Location = New System.Drawing.Point(344, 8)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(88, 32)
            Me.Label6.TabIndex = 29
            Me.Label6.Text = "Display Interval (Milliseconds)"
            '
            'GradientPanel1
            '
            Me.GradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(171, Byte), CType(206, Byte))
            Me.GradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.GradientPanel1.Controls.Add(Me.ButtonAdv3)
            Me.GradientPanel1.Controls.Add(Me.ButtonAdv4)
            Me.GradientPanel1.Location = New System.Drawing.Point(544, 200)
            Me.GradientPanel1.Name = "GradientPanel1"
            Me.GradientPanel1.Size = New System.Drawing.Size(240, 40)
            Me.GradientPanel1.TabIndex = 37
            '
            'GradientPanel2
            '
            Me.GradientPanel2.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.GradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(171, Byte), CType(206, Byte))
            Me.GradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.GradientPanel2.Controls.Add(Me.gradientLabel2)
            Me.GradientPanel2.Controls.Add(Me.alignTopRight)
            Me.GradientPanel2.Controls.Add(Me.alignCenter)
            Me.GradientPanel2.Controls.Add(Me.alignSystemTray)
            Me.GradientPanel2.Controls.Add(Me.alignTopLeft)
            Me.GradientPanel2.Controls.Add(Me.alignBottomRight)
            Me.GradientPanel2.Controls.Add(Me.alignBottomLeft)
            Me.GradientPanel2.Controls.Add(Me.alignCustom)
            Me.GradientPanel2.Location = New System.Drawing.Point(344, 256)
            Me.GradientPanel2.Name = "GradientPanel2"
            Me.GradientPanel2.Size = New System.Drawing.Size(440, 128)
            Me.GradientPanel2.TabIndex = 37
            '
            'gradientLabel2
            '
            Me.gradientLabel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte)), System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte)))
            Me.gradientLabel2.BorderSides = System.Windows.Forms.Border3DSide.Top
            Me.gradientLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.gradientLabel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.gradientLabel2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientLabel2.ForeColor = System.Drawing.Color.Maroon
            Me.gradientLabel2.Location = New System.Drawing.Point(0, 0)
            Me.gradientLabel2.Name = "gradientLabel2"
            Me.gradientLabel2.Size = New System.Drawing.Size(438, 24)
            Me.gradientLabel2.TabIndex = 32
            Me.gradientLabel2.Text = "Desktop Alignment"
            Me.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'GradientPanel3
            '
            Me.GradientPanel3.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.GradientPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(171, Byte), CType(206, Byte))
            Me.GradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.GradientPanel3.Controls.Add(Me.gradientLabel1)
            Me.GradientPanel3.Controls.Add(Me.splashPanel1Selected)
            Me.GradientPanel3.Controls.Add(Me.splashPanel2Selected)
            Me.GradientPanel3.Controls.Add(Me.splashPanel3Selected)
            Me.GradientPanel3.Controls.Add(Me.splashPanel4Selected)
            Me.GradientPanel3.Location = New System.Drawing.Point(8, 256)
            Me.GradientPanel3.Name = "GradientPanel3"
            Me.GradientPanel3.Size = New System.Drawing.Size(312, 128)
            Me.GradientPanel3.TabIndex = 37
            '
            'gradientLabel1
            '
            Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte)), System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte)))
            Me.gradientLabel1.BorderSides = System.Windows.Forms.Border3DSide.Top
            Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.gradientLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientLabel1.ForeColor = System.Drawing.Color.Maroon
            Me.gradientLabel1.Location = New System.Drawing.Point(0, 0)
            Me.gradientLabel1.Name = "gradientLabel1"
            Me.gradientLabel1.Size = New System.Drawing.Size(310, 24)
            Me.gradientLabel1.TabIndex = 23
            Me.gradientLabel1.Text = "Select the panel to splash"
            Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'MainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(234, Byte), CType(255, Byte))
            Me.ClientSize = New System.Drawing.Size(792, 553)
            Me.Controls.Add(Me.GradientPanel2)
            Me.Controls.Add(Me.gradientPanel4)
            Me.Controls.Add(Me.splashPanel3)
            Me.Controls.Add(Me.splashPanel2)
            Me.Controls.Add(Me.splashPanel1)
            Me.Controls.Add(Me.splashPanel4)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.GradientPanel1)
            Me.Controls.Add(Me.GradientPanel3)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Menu = Me.mainMenu1
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Splash Panel "
            Me.groupBox1.ResumeLayout(False)
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splashPanel1.ResumeLayout(False)
            Me.splashPanel2.ResumeLayout(False)
            Me.splashPanel3.ResumeLayout(False)
            Me.splashPanel4.ResumeLayout(False)
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel4.ResumeLayout(False)
            CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GradientPanel1.ResumeLayout(False)
            CType(Me.GradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GradientPanel2.ResumeLayout(False)
            CType(Me.GradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GradientPanel3.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

		#Region "SplashAlignment"

		Private Function GetDesktopAlignment() As SplashAlignment
			If Me.alignCenter.Checked = True Then
				Return SplashAlignment.Center
			Else If Me.alignSystemTray.Checked = True Then
				Return SplashAlignment.SystemTray
			Else If Me.alignTopRight.Checked = True Then
				Return SplashAlignment.RightTop
			Else If Me.alignBottomLeft.Checked = True Then
				Return SplashAlignment.LeftBottom
			Else If Me.alignTopLeft.Checked = True Then
				Return SplashAlignment.LeftTop
			Else If Me.alignBottomRight.Checked = True Then
				Return SplashAlignment.RightBottom
			Else If Me.alignCustom.Checked = True Then
				Return SplashAlignment.Custom
			Else
				Return SplashAlignment.SystemTray
			End If
		End Function
		#End Region
		Private Function IsNumber(ByVal text As String) As Boolean
			If text Is Nothing OrElse text = String.Empty Then
				Return False
			End If

			Dim c As Char
			For Each c In text
				If Char.IsNumber(c) = False Then
					Return False
				End If
			Next c
			Return True
		End Function
		#Region "ShowSplash"
		Private Sub ShowSplash(ByVal isModal As Boolean)
			Dim pt As Point = Point.Empty
			Dim currentPanel As SplashPanel = Me.splashPanel1
			Dim interval As Integer = 5000

			If Me.splashPanel1Selected.Checked = True Then
				currentPanel = Me.splashPanel1
			Else If Me.splashPanel2Selected.Checked = True Then
				currentPanel = Me.splashPanel2
			Else If Me.splashPanel3Selected.Checked = True Then
				currentPanel = Me.splashPanel3
			Else If Me.splashPanel4Selected.Checked = True Then
				currentPanel = Me.splashPanel4
			End If

			If IsNumber(Me.timerInterval.Text) = True Then
				interval = Int32.Parse(Me.timerInterval.Text)
			End If


			currentPanel.DesktopAlignment = GetDesktopAlignment()
			currentPanel.TimerInterval = interval
			currentPanel.AnimationSpeed = Me.trackBar1.Value

			If currentPanel.DesktopAlignment = SplashAlignment.Custom Then
				pt = Control.MousePosition
			End If

			currentPanel.ShowSplash(pt, Me, isModal)
		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Dim frmMain As MainForm = New MainForm()
			Application.Run(frmMain)
		End Sub
		#Region "DemoCommon.AboutForm"
		Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click
            Dim ab As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies)
            ab.ShowDialog()

		End Sub
		#End Region

		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
			Application.Exit()
		End Sub
		#Region "BeforeSplash"
		Private Sub splashPanel1_BeforeSplash(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles splashPanel1.BeforeSplash, splashPanel3.BeforeSplash, splashPanel4.BeforeSplash
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "BeforeSplash", (CType(sender, Control)).Name)
			textBox1.Text = textBox1.Text & eventlogmessage
		End Sub
		#End Region
		#Region "SplashDisplayed"

		Private Sub splashPanel1_SplashDisplayed(ByVal sender As Object, ByVal e As System.EventArgs) Handles splashPanel1.SplashDisplayed, splashPanel3.SplashDisplayed, splashPanel4.SplashDisplayed
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashDisplayed", (CType(sender, Control)).Name)
			If Me.InvokeRequired Then
				Me.Invoke(New SetStringDelegate(AddressOf OutputText), New Object() { eventlogmessage })
			Else
				textBox1.Text = textBox1.Text & eventlogmessage
			End If
		End Sub

		#End Region
		#Region "Method"

		Private Sub OutputText(ByVal text As String)
			textBox1.Text = textBox1.Text & text
		End Sub

		#End Region
		#Region "splashPanel1_SplashClosing"
		Private Sub splashPanel1_SplashClosing(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs) Handles splashPanel1.SplashClosed
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashClosing", (CType(sender, Control)).Name)
			If Me.InvokeRequired Then
				Me.Invoke(New SetStringDelegate(AddressOf OutputText), New Object() { eventlogmessage })
			Else
				OutputText(eventlogmessage)
			End If

			If Me.Controls.Contains(Me.splashPanel1) = False Then
				Me.Controls.Add(Me.splashPanel1)
			End If
			Me.splashPanel1.Location = Me.currentPt1
			Me.splashPanel1.Visible = True
		End Sub
		#End Region
		#Region "splashPanel3_SplashClosing"
		Private Sub splashPanel3_SplashClosing(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs) Handles splashPanel3.SplashClosed
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashClosing", (CType(sender, Control)).Name)
			If Me.InvokeRequired Then
				Me.Invoke(New SetStringDelegate(AddressOf OutputText), New Object() { eventlogmessage })
			Else
				OutputText(eventlogmessage)
			End If

			If Me.Controls.Contains(Me.splashPanel3) = False Then
				Me.Controls.Add(Me.splashPanel3)
			End If
			Me.splashPanel3.Location = Me.currentPt3
			Me.splashPanel3.Visible = True
		End Sub
		#End Region
		#Region "splashPanel4_SplashClosing"
		Private Sub splashPanel4_SplashClosing(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs) Handles splashPanel4.SplashClosed
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashClosing", (CType(sender, Control)).Name)
			If Me.InvokeRequired Then
				Me.Invoke(New SetStringDelegate(AddressOf OutputText), New Object() { eventlogmessage })
			Else
				OutputText(eventlogmessage)
			End If

			If Me.Controls.Contains(Me.splashPanel4) = False Then
				Me.Controls.Add(Me.splashPanel4)
			End If
			Me.splashPanel4.Location = Me.currentPt4
			Me.splashPanel4.Visible = True
		End Sub
		#End Region
		#Region "MainForm_Load"

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.currentPt1 = Me.splashPanel1.Location
			Me.splashPanel1.Visible = True
			Me.currentPt2 = Me.splashPanel2.Location
			Me.splashPanel2.Visible = True
			Me.currentPt3 = Me.splashPanel3.Location
			Me.splashPanel3.Visible = True
			Me.currentPt4 = Me.splashPanel4.Location
			Me.splashPanel4.Visible = True
		End Sub
		#End Region
		#Region "splashPanel2_SplashClosing"

		Private Sub splashPanel2_SplashClosing(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs) Handles splashPanel2.SplashClosed
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashClosing", (CType(sender, Control)).Name)
			If Me.InvokeRequired Then
				Me.Invoke(New SetStringDelegate(AddressOf OutputText), New Object() { eventlogmessage })
			Else
				OutputText(eventlogmessage)
			End If

			Me.splashPanel2.Location = Me.currentPt2
			Me.splashPanel2.Visible = True
			If Me.Controls.Contains(Me.splashPanel2) = False Then
				Me.Controls.Add(Me.splashPanel2)
			End If
		End Sub
		#End Region
		#Region "codegen"

		Protected Sub CodeGen_InitializeComponent()
			' InitializeComponent
			' <samplecodeblock name="SplashPanel InitializeComponent">

			' Create the splash panel
			Me.splashPanel1 = New SplashPanel()

			' The animation speed
			Me.splashPanel1.AnimationSpeed = 10

			' The background 
			Me.splashPanel1.BackgroundColor = New BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.HighlightText, System.Drawing.SystemColors.Highlight)

			' The border style
			Me.splashPanel1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump

			' The child controls - added through the designer
			Me.splashPanel1.Controls.AddRange(New System.Windows.Forms.Control() { Me.linkLabel1})
			' The startup location for the splash panel
			Me.splashPanel1.DesktopAlignment = SplashAlignment.SystemTray

			' Specifies whether the window should appear animated
			Me.splashPanel1.ShowAnimation = True

			' The interval for which the panel is to be displayed
			Me.splashPanel1.TimerInterval = 5000

'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			'</samplecodeblock>
		End Sub

		''' <summary>
		''' 
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub CodeGen_button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.splashPanel1.ShowSplash(Point.Empty, Me, False)
		End Sub

		Private Sub CodeGen_splashPanel1_SplashClosing(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs)
			' <samplecodeblock name="SplashPanel SplashClosing event">
			AddHandler splashPanel1.SplashClosed, AddressOf splashPanel1_SplashClosing

			' splashPanel1_SplashClosing event handler
			MessageBox.Show("SplashPanel closing event handler")
			'</samplecodeblock>
		End Sub
		#End Region
		#Region "splashPanel2_BeforeSplash"
		Private Sub splashPanel2_BeforeSplash(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles splashPanel2.BeforeSplash
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "BeforeSplash", (CType(sender, Control)).Name)
			If Me.InvokeRequired Then
				Me.Invoke(New SetStringDelegate(AddressOf OutputText), New Object() { eventlogmessage })
			Else
				OutputText(eventlogmessage)
			End If

		End Sub
#End Region
#Region "splashPanel2_SplashDisplayed"

        Private Sub splashPanel2_SplashDisplayed(ByVal sender As Object, ByVal e As System.EventArgs) Handles splashPanel2.SplashDisplayed
            Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashDisplayed", (CType(sender, Control)).Name)
            If Me.InvokeRequired Then
                Me.Invoke(New SetStringDelegate(AddressOf OutputText), New Object() {eventlogmessage})
            Else
                OutputText(eventlogmessage)
            End If

        End Sub
#End Region
#Region "HideSplash"

        Private Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button5.Click
            Me.splashPanel4.HideSplash()
        End Sub
#End Region
#Region "SplashMouseEnter"
        Private Sub splashPanel2_SplashMouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles splashPanel2.SplashMouseEnter
            Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashMouseEnter", (CType(sender, Control)).Name)
            If Me.InvokeRequired Then
                Me.Invoke(New SetStringDelegate(AddressOf OutputText), New Object() {eventlogmessage})
            Else
                OutputText(eventlogmessage)
            End If

        End Sub
#End Region
#Region "splashPanel2_SplashMouseLeave"
        Private Sub splashPanel2_SplashMouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles splashPanel2.SplashMouseLeave
            Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashMouseLeave", (CType(sender, Control)).Name)
            If Me.InvokeRequired Then
                Me.Invoke(New SetStringDelegate(AddressOf OutputText), New Object() {eventlogmessage})
            Else
                OutputText(eventlogmessage)
            End If

        End Sub
#End Region

        Private Sub ButtonAdv1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv1.Click
            Me.splashPanel3.HideSplash()
        End Sub

        Private Sub ButtonAdv2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv2.Click
            Me.splashPanel2.HideSplash()
        End Sub

        Private Sub ButtonAdv3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv3.Click
            Me.ShowSplash(True)
        End Sub

        Private Sub ButtonAdv4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdv4.Click
            Me.ShowSplash(False)
        End Sub

        Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
            Me.textBox1.SelectionStart = Me.textBox1.Text.Length - 1
            Me.textBox1.ScrollToCaret()
        End Sub
    End Class
End Namespace
