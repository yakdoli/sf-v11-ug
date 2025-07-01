#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Re-distribution in any form is strictly
'  prohibited. Any infringement will be prosecuted under applicable laws. 
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
	Imports Syncfusion.Windows.Forms.Tools.XPMenus
	Imports Syncfusion.Windows.Forms
Namespace CalculatorControlDemo


	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class MainForm : Inherits System.Windows.Forms.Form
		Public WithEvents calculatorControl1 As Syncfusion.Windows.Forms.Tools.CalculatorControl
		Private textBox1 As System.Windows.Forms.TextBox
		Private popupCalculator1 As Syncfusion.Windows.Forms.Tools.PopupCalculator
		Private textBox2 As System.Windows.Forms.TextBox
		Private imageList1 As System.Windows.Forms.ImageList
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private visualStyleParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private office2007ParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private checkBoxAdv3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private WithEvents numericUpDownExt2 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private WithEvents numericUpDownExt1 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private WithEvents radioButtonAdv3 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv5 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radioButtonAdv4 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private WithEvents blueBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents blackBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents silverBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel4 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientLabel2 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private components As System.ComponentModel.IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
			Me.popupCalculator1 = New PopupCalculator()
			Me.popupCalculator1.ParentControl = Me.buttonAdv1
			Me.popupCalculator1.UseVisualStyle = True
			Me.popupCalculator1.ButtonStyle = ButtonAppearance.Office2007
			Me.popupCalculator1.PopupCalculatorAlignment = CalculatorPopupAlignment.Right
			AddHandler popupCalculator1.Closing, AddressOf HandlePopupCalculatorClosingEvent
			AddHandler popupCalculator1.BeforeCalculatorPopupDisplay, AddressOf HandleBeforePopupCalculatorDisplayEvent
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
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.calculatorControl1 = New Syncfusion.Windows.Forms.Tools.CalculatorControl
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.gradientLabel2 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.numericUpDownExt2 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.numericUpDownExt1 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label6 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.radioButtonAdv4 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv5 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label8 = New System.Windows.Forms.Label
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.radioButtonAdv3 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.radioButtonAdv2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label7 = New System.Windows.Forms.Label
            Me.radioButtonAdv1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "MainMenu")
            Me.visualStyleParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.office2007ParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.blueBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.blackBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.silverBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel4.SuspendLayout()
            CType(Me.numericUpDownExt2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            CType(Me.radioButtonAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'calculatorControl1
            '
            Me.calculatorControl1.AccessibleDescription = "Calculator control"
            Me.calculatorControl1.AccessibleName = "Calculator Control"
            Me.calculatorControl1.AutoScroll = True
            Me.calculatorControl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.calculatorControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.calculatorControl1.Culture = New System.Globalization.CultureInfo("en-US")
            Me.calculatorControl1.DoubleValue = 444
            Me.calculatorControl1.FlatStyle = System.Windows.Forms.FlatStyle.Standard
            Me.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.calculatorControl1.HorizontalSpacing = 7
            Me.calculatorControl1.Location = New System.Drawing.Point(8, 44)
            Me.calculatorControl1.Name = "calculatorControl1"
            Me.calculatorControl1.RepeatAssignAction = True
            Me.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.calculatorControl1.Size = New System.Drawing.Size(312, 240)
            Me.calculatorControl1.TabIndex = 0
            Me.calculatorControl1.ThemesEnabled = False
            Me.calculatorControl1.UseUserOverride = True
            Me.calculatorControl1.UseVerticalAndHorizontalSpacing = True
            Me.calculatorControl1.UseVisualStyle = True
            Me.calculatorControl1.VerticalSpacing = 7
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(96, 12)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(224, 20)
            Me.textBox1.TabIndex = 1
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'textBox2
            '
            Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.textBox2.Location = New System.Drawing.Point(0, 387)
            Me.textBox2.Multiline = True
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.textBox2.Size = New System.Drawing.Size(734, 128)
            Me.textBox2.TabIndex = 4
            '
            'toolTip1
            '
            Me.toolTip1.ShowAlways = True
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007            
            Me.buttonAdv1.Location = New System.Drawing.Point(232, 296)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(88, 23)
            Me.buttonAdv1.TabIndex = 17
            Me.buttonAdv1.Text = "Show Popup"
            Me.buttonAdv1.UseVisualStyle = True
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer)))
            Me.gradientPanel1.BorderColor = System.Drawing.Color.Transparent
            Me.gradientPanel1.Controls.Add(Me.gradientLabel2)
            Me.gradientPanel1.Controls.Add(Me.gradientPanel4)
            Me.gradientPanel1.Controls.Add(Me.gradientPanel3)
            Me.gradientPanel1.Controls.Add(Me.gradientPanel2)
            Me.gradientPanel1.Controls.Add(Me.gradientLabel1)
            Me.gradientPanel1.Controls.Add(Me.textBox2)
            Me.gradientPanel1.Controls.Add(Me.textBox1)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv2)
            Me.gradientPanel1.Controls.Add(Me.calculatorControl1)
            Me.gradientPanel1.Controls.Add(Me.buttonAdv1)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv1)
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel1.Location = New System.Drawing.Point(0, 25)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(738, 519)
            Me.gradientPanel1.TabIndex = 18
            '
            'gradientLabel2
            '
            Me.gradientLabel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer)))
            Me.gradientLabel2.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.gradientLabel2.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.gradientLabel2.ImageIndex = 0
            Me.gradientLabel2.ImageList = Me.imageList1
            Me.gradientLabel2.Location = New System.Drawing.Point(8, 326)
            Me.gradientLabel2.Name = "gradientLabel2"
            Me.gradientLabel2.Size = New System.Drawing.Size(312, 40)
            Me.gradientLabel2.TabIndex = 32
            Me.gradientLabel2.Text = "Below given TextBox displays the events  logged  for Calculator control as well a" & _
                "s the PopUpCalculatorControl"
            Me.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'gradientPanel4
            '
            Me.gradientPanel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer)))
            Me.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel4.Controls.Add(Me.numericUpDownExt2)
            Me.gradientPanel4.Controls.Add(Me.numericUpDownExt1)
            Me.gradientPanel4.Controls.Add(Me.checkBoxAdv3)
            Me.gradientPanel4.Controls.Add(Me.label6)
            Me.gradientPanel4.Controls.Add(Me.label3)
            Me.gradientPanel4.Controls.Add(Me.label2)
            Me.gradientPanel4.Location = New System.Drawing.Point(360, 196)
            Me.gradientPanel4.Name = "gradientPanel4"
            Me.gradientPanel4.Size = New System.Drawing.Size(336, 128)
            Me.gradientPanel4.TabIndex = 31
            '
            'numericUpDownExt2
            '
            Me.numericUpDownExt2.BorderColor = System.Drawing.Color.Black
            Me.numericUpDownExt2.Location = New System.Drawing.Point(136, 92)
            Me.numericUpDownExt2.Name = "numericUpDownExt2"
            Me.numericUpDownExt2.Size = New System.Drawing.Size(120, 20)
            Me.numericUpDownExt2.TabIndex = 11
            Me.numericUpDownExt2.ThemesEnabled = True
            Me.numericUpDownExt2.Value = New Decimal(New Integer() {7, 0, 0, 0})
            '
            'numericUpDownExt1
            '
            Me.numericUpDownExt1.BorderColor = System.Drawing.Color.Black
            Me.numericUpDownExt1.Location = New System.Drawing.Point(136, 68)
            Me.numericUpDownExt1.Name = "numericUpDownExt1"
            Me.numericUpDownExt1.Size = New System.Drawing.Size(120, 20)
            Me.numericUpDownExt1.TabIndex = 10
            Me.numericUpDownExt1.ThemesEnabled = True
            Me.numericUpDownExt1.Value = New Decimal(New Integer() {7, 0, 0, 0})
            '
            'checkBoxAdv3
            '
            Me.checkBoxAdv3.AutoHeight = True
            Me.checkBoxAdv3.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv3.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv3.CheckedInt = 1
            Me.checkBoxAdv3.CheckedString = "Checked"
            Me.checkBoxAdv3.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv3.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv3.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv3.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv3.Location = New System.Drawing.Point(32, 36)
            Me.checkBoxAdv3.Name = "checkBoxAdv3"
            Me.checkBoxAdv3.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv3.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv3.Size = New System.Drawing.Size(200, 17)
            Me.checkBoxAdv3.StretchImage = False
            Me.checkBoxAdv3.TabIndex = 14
            Me.checkBoxAdv3.Text = "UseHorizontalAndVerticalSpacing"
            Me.checkBoxAdv3.ThemesEnabled = True
            Me.checkBoxAdv3.UncheckedInt = 0
            Me.checkBoxAdv3.UncheckedString = "Unchecked"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.BackColor = System.Drawing.Color.Transparent
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.Location = New System.Drawing.Point(8, 8)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(51, 13)
            Me.label6.TabIndex = 22
            Me.label6.Text = "Spacing"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.Location = New System.Drawing.Point(32, 68)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(84, 13)
            Me.label3.TabIndex = 12
            Me.label3.Text = "Vertical Spacing"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Location = New System.Drawing.Point(32, 92)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(96, 13)
            Me.label2.TabIndex = 13
            Me.label2.Text = "Horizontal Spacing"
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer)))
            Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel3.Controls.Add(Me.radioButtonAdv4)
            Me.gradientPanel3.Controls.Add(Me.radioButtonAdv5)
            Me.gradientPanel3.Controls.Add(Me.label8)
            Me.gradientPanel3.Location = New System.Drawing.Point(360, 100)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(336, 48)
            Me.gradientPanel3.TabIndex = 30
            '
            'radioButtonAdv4
            '
            Me.radioButtonAdv4.AutoHeight = True
            Me.radioButtonAdv4.BackColor = System.Drawing.Color.Transparent
            Me.radioButtonAdv4.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv4.CheckedInt = 1
            Me.radioButtonAdv4.CheckedString = "Checked"
            Me.radioButtonAdv4.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv4.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv4.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv4.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv4.Location = New System.Drawing.Point(184, 20)
            Me.radioButtonAdv4.Name = "radioButtonAdv4"
            Me.radioButtonAdv4.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv4.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv4.Size = New System.Drawing.Size(120, 17)
            Me.radioButtonAdv4.StretchImage = False
            Me.radioButtonAdv4.TabIndex = 2
            Me.radioButtonAdv4.Text = "WindowsStandard"
            Me.radioButtonAdv4.ThemesEnabled = True
            Me.radioButtonAdv4.UncheckedInt = 0
            Me.radioButtonAdv4.UncheckedString = "Unchecked"
            '
            'radioButtonAdv5
            '
            Me.radioButtonAdv5.BackColor = System.Drawing.Color.Transparent
            Me.radioButtonAdv5.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv5.Checked = True
            Me.radioButtonAdv5.CheckedInt = 1
            Me.radioButtonAdv5.CheckedString = "Checked"
            Me.radioButtonAdv5.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv5.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv5.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv5.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv5.Location = New System.Drawing.Point(22, 20)
            Me.radioButtonAdv5.Name = "radioButtonAdv5"
            Me.radioButtonAdv5.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv5.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv5.Size = New System.Drawing.Size(72, 21)
            Me.radioButtonAdv5.StretchImage = False
            Me.radioButtonAdv5.TabIndex = 3
            Me.radioButtonAdv5.Text = "Financial"
            Me.radioButtonAdv5.ThemesEnabled = True
            Me.radioButtonAdv5.UncheckedInt = 0
            Me.radioButtonAdv5.UncheckedString = "Unchecked"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.BackColor = System.Drawing.Color.Transparent
            Me.label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.Location = New System.Drawing.Point(6, 4)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(77, 13)
            Me.label8.TabIndex = 24
            Me.label8.Text = "Layout Type"
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer)))
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.radioButtonAdv3)
            Me.gradientPanel2.Controls.Add(Me.radioButtonAdv2)
            Me.gradientPanel2.Controls.Add(Me.label7)
            Me.gradientPanel2.Controls.Add(Me.radioButtonAdv1)
            Me.gradientPanel2.Location = New System.Drawing.Point(360, 44)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(336, 48)
            Me.gradientPanel2.TabIndex = 29
            '
            'radioButtonAdv3
            '
            Me.radioButtonAdv3.AutoHeight = True
            Me.radioButtonAdv3.BackColor = System.Drawing.Color.Transparent
            Me.radioButtonAdv3.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv3.CheckedInt = 1
            Me.radioButtonAdv3.CheckedString = "Checked"
            Me.radioButtonAdv3.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv3.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv3.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv3.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv3.Location = New System.Drawing.Point(175, 23)
            Me.radioButtonAdv3.Name = "radioButtonAdv3"
            Me.radioButtonAdv3.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv3.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv3.Size = New System.Drawing.Size(64, 17)
            Me.radioButtonAdv3.StretchImage = False
            Me.radioButtonAdv3.TabIndex = 3
            Me.radioButtonAdv3.Text = "Center"
            Me.radioButtonAdv3.ThemesEnabled = True
            Me.radioButtonAdv3.UncheckedInt = 0
            Me.radioButtonAdv3.UncheckedString = "Unchecked"
            '
            'radioButtonAdv2
            '
            Me.radioButtonAdv2.AutoHeight = True
            Me.radioButtonAdv2.BackColor = System.Drawing.Color.Transparent
            Me.radioButtonAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv2.Checked = True
            Me.radioButtonAdv2.CheckedInt = 1
            Me.radioButtonAdv2.CheckedString = "Checked"
            Me.radioButtonAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv2.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv2.Location = New System.Drawing.Point(71, 23)
            Me.radioButtonAdv2.Name = "radioButtonAdv2"
            Me.radioButtonAdv2.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv2.Size = New System.Drawing.Size(56, 17)
            Me.radioButtonAdv2.StretchImage = False
            Me.radioButtonAdv2.TabIndex = 2
            Me.radioButtonAdv2.Text = "Right"
            Me.radioButtonAdv2.ThemesEnabled = True
            Me.radioButtonAdv2.UncheckedInt = 0
            Me.radioButtonAdv2.UncheckedString = "Unchecked"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.BackColor = System.Drawing.Color.Transparent
            Me.label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.Location = New System.Drawing.Point(10, 2)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(138, 13)
            Me.label7.TabIndex = 23
            Me.label7.Text = "Display Text Alignment"
            '
            'radioButtonAdv1
            '
            Me.radioButtonAdv1.AutoHeight = True
            Me.radioButtonAdv1.BackColor = System.Drawing.Color.Transparent
            Me.radioButtonAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv1.CheckedInt = 1
            Me.radioButtonAdv1.CheckedString = "Checked"
            Me.radioButtonAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.radioButtonAdv1.GradientStart = System.Drawing.SystemColors.Control
            Me.radioButtonAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.radioButtonAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.radioButtonAdv1.Location = New System.Drawing.Point(127, 23)
            Me.radioButtonAdv1.Name = "radioButtonAdv1"
            Me.radioButtonAdv1.ShadowColor = System.Drawing.Color.Black
            Me.radioButtonAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.radioButtonAdv1.Size = New System.Drawing.Size(48, 17)
            Me.radioButtonAdv1.StretchImage = False
            Me.radioButtonAdv1.TabIndex = 1
            Me.radioButtonAdv1.Text = "Left"
            Me.radioButtonAdv1.ThemesEnabled = True
            Me.radioButtonAdv1.UncheckedInt = 0
            Me.radioButtonAdv1.UncheckedString = "Unchecked"
            '
            'gradientLabel1
            '
            Me.gradientLabel1.BackColor = System.Drawing.Color.Transparent
            Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer)))
            Me.gradientLabel1.BorderSides = CType(((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom) _
                        Or System.Windows.Forms.Border3DSide.Middle), System.Windows.Forms.Border3DSide)
            Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.gradientLabel1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.gradientLabel1.ImageIndex = 0
            Me.gradientLabel1.ImageList = Me.imageList1
            Me.gradientLabel1.Location = New System.Drawing.Point(360, 156)
            Me.gradientLabel1.Name = "gradientLabel1"
            Me.gradientLabel1.Size = New System.Drawing.Size(336, 40)
            Me.gradientLabel1.TabIndex = 27
            Me.gradientLabel1.Text = "Controls the vertical and horizontal spacing between controls."
            Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'checkBoxAdv2
            '
            Me.checkBoxAdv2.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv2.CheckedInt = 1
            Me.checkBoxAdv2.CheckedString = "Checked"
            Me.checkBoxAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv2.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv2.Location = New System.Drawing.Point(8, 12)
            Me.checkBoxAdv2.Name = "checkBoxAdv2"
            Me.checkBoxAdv2.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv2.Size = New System.Drawing.Size(97, 21)
            Me.checkBoxAdv2.TabIndex = 19
            Me.checkBoxAdv2.Text = "Show Display"
            Me.checkBoxAdv2.ThemesEnabled = False
            Me.checkBoxAdv2.UncheckedInt = 0
            Me.checkBoxAdv2.UncheckedString = "Unchecked"
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.AutoHeight = True
            Me.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent
            Me.checkBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv1.Checked = False
            Me.checkBoxAdv1.CheckedInt = 1
            Me.checkBoxAdv1.CheckedString = "Checked"
            Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Unchecked
            Me.checkBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv1.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv1.Location = New System.Drawing.Point(8, 300)
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv1.Size = New System.Drawing.Size(218, 17)
            Me.checkBoxAdv1.TabIndex = 18
            Me.checkBoxAdv1.Text = "Close Popup when ""="" Button Clicked"
            Me.checkBoxAdv1.ThemesEnabled = True
            Me.checkBoxAdv1.UncheckedInt = 0
            Me.checkBoxAdv1.UncheckedString = "Unchecked"
            '
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.bar1)
            Me.mainFrameBarManager1.Categories.Add("VisualStyles")
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5, Me.visualStyleParentBarItem, Me.parentBarItem2, Me.barItem7, Me.office2007ParentBarItem, Me.blueBarItem, Me.blackBarItem, Me.silverBarItem})
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'bar1
            '
            Me.bar1.BarName = "MainMenu"
            Me.bar1.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "MainMenu"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.visualStyleParentBarItem, Me.parentBarItem2})
            Me.bar1.Manager = Me.mainFrameBarManager1
            '
            'visualStyleParentBarItem
            '
            Me.visualStyleParentBarItem.CategoryIndex = 0
            Me.visualStyleParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.visualStyleParentBarItem.ID = "&Visual Styles"
            Me.visualStyleParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5, Me.office2007ParentBarItem})
            Me.visualStyleParentBarItem.Text = "&Visual Styles"
            '
            'barItem1
            '
            Me.barItem1.CategoryIndex = 0
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem1.ID = "Classic"
            Me.barItem1.Text = "Classic"
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 0
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "Office2000"
            Me.barItem2.Text = "Office2000"
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 0
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "WindowsXP"
            Me.barItem3.Text = "WindowsXP"
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 0
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "OfficeXP"
            Me.barItem4.Text = "OfficeXP"
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 0
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "Office2003"
            Me.barItem5.Text = "Office2003"
            '
            'office2007ParentBarItem
            '
            Me.office2007ParentBarItem.CategoryIndex = 0
            Me.office2007ParentBarItem.Checked = True
            Me.office2007ParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.office2007ParentBarItem.ID = "Office2007"
            Me.office2007ParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.blueBarItem, Me.blackBarItem, Me.silverBarItem})
            Me.office2007ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.office2007ParentBarItem.Text = "Office2007"
            '
            'blueBarItem
            '
            Me.blueBarItem.CategoryIndex = 0
            Me.blueBarItem.Checked = True
            Me.blueBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.blueBarItem.ID = "Blue"
            Me.blueBarItem.Text = "Blue"
            '
            'blackBarItem
            '
            Me.blackBarItem.CategoryIndex = 0
            Me.blackBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.blackBarItem.ID = "Black"
            Me.blackBarItem.Text = "Black"
            '
            'silverBarItem
            '
            Me.silverBarItem.CategoryIndex = 0
            Me.silverBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.silverBarItem.ID = "Silver"
            Me.silverBarItem.Text = "Silver"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 0
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "&Help"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem7})
            Me.parentBarItem2.Text = "&Help"
            '
            'barItem7
            '
            Me.barItem7.CategoryIndex = 0
            Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem7.ID = "AboutSyncfusion"
            Me.barItem7.Text = "About Syncfusion"
            '
            'MainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(738, 544)
            Me.Controls.Add(Me.gradientPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Calculator Control"
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.gradientPanel1.PerformLayout()
            CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel4.ResumeLayout(False)
            Me.gradientPanel4.PerformLayout()
            CType(Me.numericUpDownExt2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel3.ResumeLayout(False)
            Me.gradientPanel3.PerformLayout()
            CType(Me.radioButtonAdv4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.gradientPanel2.PerformLayout()
            CType(Me.radioButtonAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Application.Run(New MainForm())
		End Sub
		#Region "ShowDisplayArea"
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxAdv2.CheckStateChanged
			Me.calculatorControl1.ShowDisplayArea = Me.checkBoxAdv2.Checked
		End Sub
		#End Region 

		#Region "HandlePopupCalculatorClosingEvent"

		Public Sub HandlePopupCalculatorClosingEvent(ByVal sender As Object, ByVal args As CalculatorClosingEventArgs)
			'Event logging
			Dim item As String = args.FinalValue.ToString()
			Dim eventlogmessage As String = String.Format("Event: {0} FinalValue: {1}" & Constants.vbCrLf, "CalculatorClosing", item)
			textBox2.Text = textBox2.Text & eventlogmessage
		End Sub
		#End Region 

		#Region "HandleBeforePopupCalculatorDisplayEvent"

		Public Sub HandleBeforePopupCalculatorDisplayEvent(ByVal sender As Object, ByVal args As CancelEventArgs)
			'Event logging
			Dim item As String = args.Cancel.ToString()
			Dim eventlogmessage As String = String.Format("Event: {0} Cancel: {1}" & Constants.vbCrLf, "CalculatorClosing", item)
			textBox2.Text = textBox2.Text & eventlogmessage

			If Me.checkBoxAdv1.CheckState = CheckState.Checked Then
				Me.popupCalculator1.CloseAction = CalcActions.CalcOperatorEquals
			Else
				Me.popupCalculator1.CloseAction = CalcActions.CalcOperatorNone
			End If
			Me.popupCalculator1.Office2007ColorTheme = Me.calculatorControl1.Office2007Theme

		End Sub
			#End Region 

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.checkBoxAdv2.Checked = Me.calculatorControl1.ShowDisplayArea
		End Sub

        Protected Sub CodeGen_InitializeComponent()
            '<samplecodeblock name="CalcuatorControl InitializeComponent">

            'InitializeComponent
            ' Create the Calculator Control
            Me.calculatorControl1 = New CalculatorControl()
            Me.textBox1 = New TextBox()

            ' Set the value of the calculator control
            Me.calculatorControl1.DoubleValue = 0

            ' Set the border style for the control
            Me.calculatorControl1.BorderStyle = Border3DStyle.Raised

            ' The flat style for the buttons
            Me.calculatorControl1.FlatStyle = FlatStyle.Standard

            ' Set the size of the calculator
            Me.calculatorControl1.Size = New System.Drawing.Size(288, 232)

            ' Add a event handler for the ValueCalculated event of the child button
            '			Me.calculatorControl1.ValueCalculated += New Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventHandler(Me.CodeGen_calculatorControl1_ValueCalculated);

            ' Add the CalculatorControl control to the form
            Me.Controls.Add(Me.calculatorControl1)
            '</samplecodeblock>
        End Sub

#Region "ValueCalculated"
        ''' <summary>
        ''' The value has changed for the CalculatorControl.
        ''' </summary>
        ''' <param name="sender">The CalculatorControl raising the event.</param>
        ''' <param name="arg">The event data.</param>

        Private Sub CodeGen_calculatorControl1_ValueCalculated(ByVal sender As Object, ByVal arg As CalculatorValueCalculatedEventArgs) Handles calculatorControl1.ValueCalculated
            '<samplecodeblock name="CalcuatorControl ValueCalculated event">
            AddHandler calculatorControl1.ValueCalculated, AddressOf CodeGen_calculatorControl1_ValueCalculated

            'calculatorControl1_ValueCalculated
            If arg.ErrorCondition = False Then
                Me.textBox1.Text = arg.Value.ToString()
            Else
                Me.textBox1.Text = arg.Message
            End If
            '</samplecodeblock>
        End Sub
#End Region

#Region "CalculatorAboutForm"
        Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim ab As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())

            ab.ShowDialog()

        End Sub
#End Region

#Region "popupCalculator"
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonAdv1.Click
            Me.popupCalculator1.Size = Me.calculatorControl1.Size
            Me.popupCalculator1.FlatStyle = FlatStyle.Flat
            Me.popupCalculator1.DisplayCalculator()
        End Sub
#End Region

#Region "Exit"
        Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs)
            Application.Exit()
        End Sub
#End Region

#Region "ValueCalculated"
        Private Sub calculatorControl1_ValueCalculated(ByVal sender As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.CalculatorValueCalculatedEventArgs) Handles calculatorControl1.ValueCalculated
            'Event logging
            Dim item As String = arg.Value.ToString()
            Dim eventlogmessage As String = String.Format("Event: {0} Value: {1}" & Constants.vbCrLf, "ValueCalculated", item)
            textBox2.Text = textBox2.Text & eventlogmessage

            'Actual Code
            If arg.ErrorCondition = False Then
                Me.textBox1.Text = arg.Value.ToString()
            Else
                Me.textBox1.Text = arg.Message
            End If

        End Sub
#End Region

#Region "Theme Effects"

        Private Sub OnBarItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem1.Click, barItem2.Click, barItem3.Click, barItem4.Click, barItem5.Click, blueBarItem.Click, blackBarItem.Click, silverBarItem.Click, parentBarItem2.Click, barItem7.Click
            Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
            Select Case item.ID
                Case "Classic"
                    Me.calculatorControl1.ButtonStyle = ButtonAppearance.Classic
                    Me.popupCalculator1.ButtonStyle = ButtonAppearance.Classic
                    SetCheckedState(item, Me.visualStyleParentBarItem)
                    SetTheme(224, 223, 227, 224, 223, 227)
                    SetForeColor(Color.Black)
                    Me.buttonAdv1.Appearance = ButtonAppearance.Classic
                    Me.mainFrameBarManager1.Style = VisualStyle.Default
                Case "Office2000"
                    Me.calculatorControl1.ButtonStyle = ButtonAppearance.Office2000
                    Me.popupCalculator1.ButtonStyle = ButtonAppearance.Office2000
                    SetCheckedState(item, Me.visualStyleParentBarItem)
                    SetTheme(224, 223, 227, 224, 223, 227)
                    SetForeColor(Color.Black)
                    Me.buttonAdv1.Appearance = ButtonAppearance.Office2000
                    Me.mainFrameBarManager1.Style = VisualStyle.Default
                Case "WindowsXP"
                    Me.calculatorControl1.ButtonStyle = ButtonAppearance.WindowsXP
                    Me.popupCalculator1.ButtonStyle = ButtonAppearance.WindowsXP
                    SetCheckedState(item, Me.visualStyleParentBarItem)
                    SetTheme(253, 253, 253, 202, 201, 221)
                    SetForeColor(Color.Black)
                    Me.buttonAdv1.Appearance = ButtonAppearance.WindowsXP
                    Me.mainFrameBarManager1.Style = VisualStyle.Default
                Case "OfficeXP"
                    Me.calculatorControl1.ButtonStyle = ButtonAppearance.OfficeXP
                    Me.popupCalculator1.ButtonStyle = ButtonAppearance.OfficeXP
                    SetCheckedState(item, Me.visualStyleParentBarItem)
                    SetTheme(224, 223, 227, 224, 223, 227)
                    Me.buttonAdv1.Appearance = ButtonAppearance.OfficeXP
                    SetForeColor(Color.Black)
                    Me.mainFrameBarManager1.Style = VisualStyle.OfficeXP
                Case "Office2003"
                    Me.calculatorControl1.ButtonStyle = ButtonAppearance.Office2003
                    Me.popupCalculator1.ButtonStyle = ButtonAppearance.Office2003
                    SetCheckedState(item, Me.visualStyleParentBarItem)
                    SetTheme(224, 223, 227, 224, 223, 227)
                    SetForeColor(Color.Black)
                    Me.buttonAdv1.Appearance = ButtonAppearance.Office2003
                    Me.mainFrameBarManager1.Style = VisualStyle.Office2003
                Case "AboutSyncfusion"
                    Dim oTemp As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
                    oTemp.ShowDialog()
                Case "Blue"
                    SetTheme(Office2007Theme.Blue, 220, 235, 254, 189, 215, 252)
                    SetForeColor(Color.FromArgb(21, 69, 139))
                    blueBarItem.Checked = True
                    blackBarItem.Checked = False
                    silverBarItem.Checked = False
                Case "Black"
                    SetTheme(Office2007Theme.Black, 136, 136, 136, 83, 83, 83)
                    SetForeColor(Color.White)
                    blueBarItem.Checked = False
                    blackBarItem.Checked = True
                    silverBarItem.Checked = False
                Case "Silver"
                    SetTheme(Office2007Theme.Silver, 178, 183, 190, 212, 214, 219)
                    SetForeColor(Color.Black)
                    blueBarItem.Checked = False
                    blackBarItem.Checked = False
                    silverBarItem.Checked = True
            End Select
        End Sub

        Private Sub SetCheckedState(ByVal item As BarItem, ByVal parentBarItem As ParentBarItem)
            Dim i As BarItem
            For Each i In parentBarItem.Items
                If i.ID = item.ID Then
                    i.Checked = True
                Else
                    i.Checked = False
                End If
            Next i
        End Sub

        Private Sub SetForeColor(ByVal color As Color)
            Dim c As Control
            For Each c In Me.Controls
                c.ForeColor = color
            Next c
        End Sub

        Private Sub SetTheme(ByVal theme As Office2007Theme, ByVal r As Integer, ByVal g As Integer, ByVal b As Integer, ByVal r1 As Integer, ByVal g1 As Integer, ByVal b1 As Integer)
            Dim i As BarItem
            For Each i In Me.visualStyleParentBarItem.Items
                i.Checked = False
            Next i
            Me.office2007ParentBarItem.Checked = True
            Me.calculatorControl1.ButtonStyle = ButtonAppearance.Office2007
            Me.popupCalculator1.ButtonStyle = ButtonAppearance.Office2007			
            Me.popupCalculator1.Office2007ColorTheme = theme
            Me.calculatorControl1.Office2007Theme = theme
            Me.mainFrameBarManager1.Style = VisualStyle.Office2007
            Me.mainFrameBarManager1.Office2007Theme = theme
            Me.buttonAdv1.Appearance = ButtonAppearance.Office2007
            Me.buttonAdv1.Office2007ColorScheme = theme
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
            Me.calculatorControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
            Dim c As Control
            For Each c In Me.gradientPanel1.Controls
                If TypeOf c Is GradientPanel Then
                    Dim panel As GradientPanel = CType(IIf(TypeOf c Is GradientPanel, c, Nothing), GradientPanel)
                    panel.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
                    panel.BorderColor = Color.FromArgb(r, g, b)
                ElseIf TypeOf c Is GradientLabel Then
                    Dim label As GradientLabel = CType(IIf(TypeOf c Is GradientLabel, c, Nothing), GradientLabel)
                    label.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
                End If
            Next c
        End Sub

        Private Sub SetTheme(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer, ByVal r1 As Integer, ByVal g1 As Integer, ByVal b1 As Integer)
            Dim c As Control
            For Each c In Me.gradientPanel1.Controls
                If TypeOf c Is GradientPanel Then
                    Dim panel As GradientPanel = CType(IIf(TypeOf c Is GradientPanel, c, Nothing), GradientPanel)
                    panel.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
                    panel.BorderColor = Color.FromArgb(r, g, b)
                ElseIf TypeOf c Is GradientLabel Then
                    Dim label As GradientLabel = CType(IIf(TypeOf c Is GradientLabel, c, Nothing), GradientLabel)
                    label.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
                End If
            Next c
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
            Me.calculatorControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CByte(r1)), (CByte(g1)), (CByte(b1))), System.Drawing.Color.FromArgb((CByte(r)), (CByte(g)), (CByte(b))))
            Dim i As BarItem
            For Each i In Me.office2007ParentBarItem.Items
                i.Checked = False
            Next i
        End Sub

#End Region

#Region "LayoutType"
        Private Sub OnRadioLayoutTypeCheckedChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButtonAdv4.CheckChanged, radioButtonAdv5.CheckChanged
            If sender Is radioButtonAdv4 Then
                Me.calculatorControl1.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.Financial
            ElseIf sender Is radioButtonAdv5 Then
                Me.calculatorControl1.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.WindowsStandard
            End If
        End Sub
#End Region

#Region "UseVerticalAndHorizontalSpacing"
        Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.calculatorControl1.UseVerticalAndHorizontalSpacing = Me.checkBoxAdv2.Checked
        End Sub
#End Region

#Region "DisplayTextAlign"
        Private Sub OnRadioDisplayCheckedChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButtonAdv3.CheckChanged, radioButtonAdv2.CheckChanged, radioButtonAdv1.CheckChanged
            If sender Is radioButtonAdv1 Then
                Me.calculatorControl1.DisplayTextAlign = HorizontalAlignment.Left
            ElseIf sender Is radioButtonAdv2 Then
                Me.calculatorControl1.DisplayTextAlign = HorizontalAlignment.Right
            ElseIf sender Is radioButtonAdv3 Then
                Me.calculatorControl1.DisplayTextAlign = HorizontalAlignment.Center
            End If
        End Sub

#End Region

#Region "SpacingEvents"
        Private Sub numericUpDownExt1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDownExt1.ValueChanged
            If Me.checkBoxAdv3.Checked Then
                Me.calculatorControl1.VerticalSpacing = Convert.ToInt32(Me.numericUpDownExt1.Value)
            End If
        End Sub

        Private Sub numericUpDownExt2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDownExt2.ValueChanged
            If Me.checkBoxAdv3.Checked Then
                Me.calculatorControl1.HorizontalSpacing = Convert.ToInt32(Me.numericUpDownExt2.Value)
            End If
        End Sub
#End Region

    End Class
End Namespace
