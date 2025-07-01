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
Imports Syncfusion.Windows.Forms.Tools

Namespace StatusBarAdvDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private statusBarPanel1 As System.Windows.Forms.StatusBarPanel
		Private statusBarAdv3 As Syncfusion.Windows.Forms.Tools.StatusBarAdv
		Private statusBarAdvPanel11 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private textBox1 As System.Windows.Forms.TextBox
		Private button1 As System.Windows.Forms.Button
		Private timePanel As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton3 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton4 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton5 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton6 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton7 As System.Windows.Forms.RadioButton
		Private textBox2 As System.Windows.Forms.TextBox
		Private WithEvents button2 As System.Windows.Forms.Button
		Private customPanel As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private keyPanel As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tabPage2 As System.Windows.Forms.TabPage
		Private tabPage3 As System.Windows.Forms.TabPage
		Private tabPage4 As System.Windows.Forms.TabPage
		Private datePanel As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel

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
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.statusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
			Me.statusBarAdv3 = New Syncfusion.Windows.Forms.Tools.StatusBarAdv()
			Me.button1 = New System.Windows.Forms.Button()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.customPanel = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.statusBarAdvPanel11 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.datePanel = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.timePanel = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.keyPanel = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel()
			Me.radioButton3 = New System.Windows.Forms.RadioButton()
			Me.radioButton2 = New System.Windows.Forms.RadioButton()
			Me.radioButton1 = New System.Windows.Forms.RadioButton()
			Me.radioButton5 = New System.Windows.Forms.RadioButton()
			Me.radioButton4 = New System.Windows.Forms.RadioButton()
			Me.radioButton6 = New System.Windows.Forms.RadioButton()
			Me.radioButton7 = New System.Windows.Forms.RadioButton()
			Me.button2 = New System.Windows.Forms.Button()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.tabControl1 = New System.Windows.Forms.TabControl()
			Me.tabPage1 = New System.Windows.Forms.TabPage()
			Me.tabPage2 = New System.Windows.Forms.TabPage()
			Me.tabPage3 = New System.Windows.Forms.TabPage()
			Me.tabPage4 = New System.Windows.Forms.TabPage()
			CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusBarAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.statusBarAdv3.SuspendLayout()
			CType(Me.customPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.statusBarAdvPanel11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.datePanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.timePanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.keyPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControl1.SuspendLayout()
			Me.tabPage1.SuspendLayout()
			Me.tabPage2.SuspendLayout()
			Me.tabPage3.SuspendLayout()
			Me.tabPage4.SuspendLayout()
			Me.SuspendLayout()
			' 
			' statusBarPanel1
			' 
			Me.statusBarPanel1.Text = "statusBarPanel1"
			' 
			' statusBarAdv3
			' 
			Me.statusBarAdv3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219))))
			Me.statusBarAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump
			Me.statusBarAdv3.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdv3.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.statusBarAdv3.Controls.AddRange(New System.Windows.Forms.Control() { Me.button1, Me.textBox1, Me.customPanel, Me.statusBarAdvPanel11, Me.timePanel, Me.keyPanel, Me.datePanel})
			Me.statusBarAdv3.CustomLayoutBounds = New System.Drawing.Rectangle(0, 0, 0, 0)
			Me.statusBarAdv3.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.statusBarAdv3.DockPadding.All = 3
			Me.statusBarAdv3.Location = New System.Drawing.Point(0, 392)
			Me.statusBarAdv3.Name = "statusBarAdv3"
			Me.statusBarAdv3.Size = New System.Drawing.Size(616, 22)
			Me.statusBarAdv3.Spacing = New System.Drawing.Size(2, 2)
			Me.statusBarAdv3.TabIndex = 2
			Me.statusBarAdv3.ThemesEnabled = True
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.PowderBlue
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(0, 2)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(56, 18)
			Me.button1.TabIndex = 6
			Me.button1.Text = "button1"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(58, 2)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(62, 20)
			Me.textBox1.TabIndex = 5
			Me.textBox1.Text = "textBox"
			' 
			' customPanel
			' 
			Me.customPanel.AnimationDirection = Syncfusion.Windows.Forms.Tools.MarqueeDirection.Right
			Me.customPanel.AnimationStyle = Syncfusion.Windows.Forms.Tools.MarqueeStyle.Slide
			Me.customPanel.BackColor = System.Drawing.Color.Transparent
			Me.customPanel.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.customPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.customPanel.BorderColor = System.Drawing.Color.Black
			Me.customPanel.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.customPanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.customPanel.IsMarquee = True
			Me.customPanel.Location = New System.Drawing.Point(122, 2)
			Me.customPanel.Name = "customPanel"
			Me.customPanel.Size = New System.Drawing.Size(100, 18)
			Me.customPanel.TabIndex = 4
			Me.customPanel.Text = "Custom Panel"
			Me.customPanel.ThemesEnabled = True
			' 
			' statusBarAdvPanel11
			' 
			Me.statusBarAdvPanel11.Alignment = System.Windows.Forms.HorizontalAlignment.Left
			Me.statusBarAdvPanel11.BackColor = System.Drawing.Color.Transparent
			Me.statusBarAdvPanel11.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.statusBarAdvPanel11.BorderColor = System.Drawing.Color.Black
			Me.statusBarAdvPanel11.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.statusBarAdvPanel11.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.statusBarAdvPanel11.Location = New System.Drawing.Point(224, 2)
			Me.statusBarAdvPanel11.Name = "statusBarAdvPanel11"
			Me.statusBarAdvPanel11.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CurrentCulture
			Me.statusBarAdvPanel11.Size = New System.Drawing.Size(123, 18)
			Me.statusBarAdvPanel11.SizeToContent = True
			Me.statusBarAdvPanel11.TabIndex = 0
			Me.statusBarAdvPanel11.Text = "statusBarAdvPanel11"
			Me.statusBarAdvPanel11.ThemesEnabled = True
			' 
			' datePanel
			' 
			Me.datePanel.Alignment = System.Windows.Forms.HorizontalAlignment.Left
			Me.datePanel.BackColor = System.Drawing.Color.DarkGray
			Me.datePanel.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.datePanel.BorderColor = System.Drawing.Color.Black
			Me.datePanel.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed
			Me.datePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.datePanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify
			Me.datePanel.Location = New System.Drawing.Point(516, 2)
			Me.datePanel.Name = "datePanel"
			Me.datePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortDate
			Me.datePanel.PreferredSize = New System.Drawing.Size(65, 18)
			Me.datePanel.Size = New System.Drawing.Size(83, 18)
			Me.datePanel.TabIndex = 1
			Me.datePanel.Text = "statusBarAdvPanel12"
			' 
			' timePanel
			' 
			Me.timePanel.BackColor = System.Drawing.Color.LightSteelBlue
			Me.timePanel.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.timePanel.BorderColor = System.Drawing.Color.Black
			Me.timePanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.timePanel.Location = New System.Drawing.Point(349, 2)
			Me.timePanel.Name = "timePanel"
			Me.timePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortTime
			Me.timePanel.Size = New System.Drawing.Size(63, 18)
			Me.timePanel.TabIndex = 3
			Me.timePanel.Text = "statusBarAdvPanel1"
			' 
			' keyPanel
			' 
			Me.keyPanel.BackColor = System.Drawing.Color.Transparent
			Me.keyPanel.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
			Me.keyPanel.BorderColor = System.Drawing.Color.Black
			Me.keyPanel.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.keyPanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left
			Me.keyPanel.Location = New System.Drawing.Point(414, 2)
			Me.keyPanel.Name = "keyPanel"
			Me.keyPanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CapsLockState
			Me.keyPanel.Size = New System.Drawing.Size(100, 18)
			Me.keyPanel.TabIndex = 2
			Me.keyPanel.Text = "statusBarAdvPanel13"
			Me.keyPanel.ThemesEnabled = True
			' 
			' radioButton3
			' 
			Me.radioButton3.Location = New System.Drawing.Point(40, 112)
			Me.radioButton3.Name = "radioButton3"
			Me.radioButton3.TabIndex = 2
			Me.radioButton3.Text = "Scroll Lock"
'			Me.radioButton3.CheckedChanged += New System.EventHandler(Me.radioButton3_CheckedChanged);
			' 
			' radioButton2
			' 
			Me.radioButton2.Location = New System.Drawing.Point(40, 88)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.TabIndex = 1
			Me.radioButton2.Text = "Num Lock"
'			Me.radioButton2.CheckedChanged += New System.EventHandler(Me.radioButton2_CheckedChanged);
			' 
			' radioButton1
			' 
			Me.radioButton1.Checked = True
			Me.radioButton1.Location = New System.Drawing.Point(40, 64)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.TabIndex = 0
			Me.radioButton1.TabStop = True
			Me.radioButton1.Text = "Caps Lock"
'			Me.radioButton1.CheckedChanged += New System.EventHandler(Me.radioButton1_CheckedChanged);
			' 
			' radioButton5
			' 
			Me.radioButton5.BackColor = System.Drawing.Color.Transparent
            ' Me.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Standard
			Me.radioButton5.Location = New System.Drawing.Point(40, 104)
			Me.radioButton5.Name = "radioButton5"
			Me.radioButton5.TabIndex = 1
			Me.radioButton5.Text = "Long Date"
'			Me.radioButton5.CheckedChanged += New System.EventHandler(Me.radioButton5_CheckedChanged);
			' 
			' radioButton4
			' 
			Me.radioButton4.BackColor = System.Drawing.Color.Transparent
			Me.radioButton4.Checked = True
			Me.radioButton4.Location = New System.Drawing.Point(40, 72)
			Me.radioButton4.Name = "radioButton4"
			Me.radioButton4.TabIndex = 0
			Me.radioButton4.TabStop = True
			Me.radioButton4.Text = "Short Date"
'			Me.radioButton4.CheckedChanged += New System.EventHandler(Me.radioButton4_CheckedChanged);
			' 
			' radioButton6
			' 
			Me.radioButton6.Checked = True
			Me.radioButton6.Location = New System.Drawing.Point(40, 72)
			Me.radioButton6.Name = "radioButton6"
			Me.radioButton6.TabIndex = 2
			Me.radioButton6.TabStop = True
			Me.radioButton6.Text = "Short Time"
'			Me.radioButton6.CheckedChanged += New System.EventHandler(Me.radioButton6_CheckedChanged);
			' 
			' radioButton7
			' 
			Me.radioButton7.Location = New System.Drawing.Point(40, 96)
			Me.radioButton7.Name = "radioButton7"
			Me.radioButton7.TabIndex = 3
			Me.radioButton7.Text = "Long Time"
'			Me.radioButton7.CheckedChanged += New System.EventHandler(Me.radioButton7_CheckedChanged);
			' 
			' button2
			' 
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button2.Location = New System.Drawing.Point(48, 104)
			Me.button2.Name = "button2"
			Me.button2.TabIndex = 1
			Me.button2.Text = "Set Text"
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(48, 64)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.TabIndex = 0
			Me.textBox2.Text = "Custom Panel"
			' 
			' tabControl1
			' 
			Me.tabControl1.Controls.AddRange(New System.Windows.Forms.Control() { Me.tabPage1, Me.tabPage2, Me.tabPage3, Me.tabPage4})
			Me.tabControl1.Location = New System.Drawing.Point(152, 48)
			Me.tabControl1.Name = "tabControl1"
			Me.tabControl1.SelectedIndex = 0
			Me.tabControl1.Size = New System.Drawing.Size(320, 264)
			Me.tabControl1.TabIndex = 9
			' 
			' tabPage1
			' 
			Me.tabPage1.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.tabPage1.Controls.AddRange(New System.Windows.Forms.Control() { Me.radioButton3, Me.radioButton2, Me.radioButton1})
			Me.tabPage1.Location = New System.Drawing.Point(4, 22)
			Me.tabPage1.Name = "tabPage1"
			Me.tabPage1.Size = New System.Drawing.Size(312, 238)
			Me.tabPage1.TabIndex = 0
			Me.tabPage1.Text = "KeyStatePanels"
			' 
			' tabPage2
			' 
			Me.tabPage2.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.tabPage2.Controls.AddRange(New System.Windows.Forms.Control() { Me.radioButton5, Me.radioButton4})
			Me.tabPage2.Location = New System.Drawing.Point(4, 22)
			Me.tabPage2.Name = "tabPage2"
			Me.tabPage2.Size = New System.Drawing.Size(312, 238)
			Me.tabPage2.TabIndex = 1
			Me.tabPage2.Text = "DatePanels"
			' 
			' tabPage3
			' 
			Me.tabPage3.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.tabPage3.Controls.AddRange(New System.Windows.Forms.Control() { Me.radioButton7, Me.radioButton6})
			Me.tabPage3.Location = New System.Drawing.Point(4, 22)
			Me.tabPage3.Name = "tabPage3"
			Me.tabPage3.Size = New System.Drawing.Size(312, 238)
			Me.tabPage3.TabIndex = 2
			Me.tabPage3.Text = "TimePanels"
			' 
			' tabPage4
			' 
			Me.tabPage4.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.tabPage4.Controls.AddRange(New System.Windows.Forms.Control() { Me.textBox2, Me.button2})
			Me.tabPage4.Location = New System.Drawing.Point(4, 22)
			Me.tabPage4.Name = "tabPage4"
			Me.tabPage4.Size = New System.Drawing.Size(312, 238)
			Me.tabPage4.TabIndex = 3
			Me.tabPage4.Text = "CustomPanels"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.ClientSize = New System.Drawing.Size(616, 414)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.tabControl1, Me.statusBarAdv3})
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "StatusBarAdv"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusBarAdv3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.statusBarAdv3.ResumeLayout(False)
			CType(Me.customPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.statusBarAdvPanel11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.datePanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.timePanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.keyPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControl1.ResumeLayout(False)
			Me.tabPage1.ResumeLayout(False)
			Me.tabPage2.ResumeLayout(False)
			Me.tabPage3.ResumeLayout(False)
			Me.tabPage4.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

		End Sub

		#Region "keyPanel"
		Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
			If radioButton1.Checked Then
			Me.keyPanel.PanelType = StatusBarAdvPanelType.CapsLockState
			End If
		End Sub

		Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged
			If radioButton2.Checked Then
			Me.keyPanel.PanelType = StatusBarAdvPanelType.NumLockState
			End If
		End Sub

		Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton3.CheckedChanged
			If radioButton3.Checked Then
			Me.keyPanel.PanelType = StatusBarAdvPanelType.ScrollLockState
			End If
		End Sub
		#End Region
		#Region "TimePanel"
		Private Sub radioButton6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton6.CheckedChanged
			If radioButton6.Checked Then
			Me.timePanel.PanelType = StatusBarAdvPanelType.ShortTime
			End If
		End Sub

		Private Sub radioButton7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton7.CheckedChanged
			If radioButton7.Checked Then
			Me.timePanel.PanelType = StatusBarAdvPanelType.LongTime
			End If
		End Sub
		#End Region
		#Region "DatePanel"
		Private Sub radioButton4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton4.CheckedChanged
			If radioButton4.Checked Then
			Me.datePanel.PanelType = StatusBarAdvPanelType.ShortDate
			End If
		End Sub

		Private Sub radioButton5_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton5.CheckedChanged
			If radioButton5.Checked Then
			Me.datePanel.PanelType = StatusBarAdvPanelType.LongDate
			End If
		End Sub
		#End Region
		#Region "customPanel"

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Me.customPanel.Text = Me.textBox2.Text
		End Sub
		#End Region
	End Class
End Namespace
