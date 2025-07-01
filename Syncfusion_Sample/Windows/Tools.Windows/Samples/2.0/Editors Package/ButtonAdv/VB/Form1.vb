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

Imports Syncfusion.Windows.Forms

Namespace ButtonAdvDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		Private buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv5 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv6 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv7 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv8 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv9 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv10 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv11 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv12 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv13 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv14 As Syncfusion.Windows.Forms.ButtonAdv
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private label5 As System.Windows.Forms.Label
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private buttonAdv18 As ButtonAdv
		Private buttonAdv17 As ButtonAdv
		Private buttonAdv16 As ButtonAdv
		Private buttonAdv15 As ButtonAdv
		Private buttonAdv4 As ButtonAdv
		Private buttonAdv1 As ButtonAdv
		Private label1 As Label
		Private buttonAdv22 As ButtonAdv
		Private buttonAdv21 As ButtonAdv
		Private buttonAdv20 As ButtonAdv
		Private buttonAdv19 As ButtonAdv
		Private buttonAdv24 As ButtonAdv
		Private buttonAdv23 As ButtonAdv
        Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private WithEvents ButtonAdv25 As Syncfusion.Windows.Forms.ButtonAdv
		Private colorDialog2 As System.Windows.Forms.ColorDialog

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
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv14 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv13 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv12 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv11 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv10 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv9 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv8 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv7 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv6 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.buttonAdv24 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv23 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.buttonAdv22 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv20 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv19 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.buttonAdv18 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv21 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv17 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv16 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv15 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label5 = New System.Windows.Forms.Label
            Me.ButtonAdv25 = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'buttonAdv2
            '
            Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv2.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Calculator
            Me.buttonAdv2.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv2.KeepFocusRectangle = False
            Me.buttonAdv2.Location = New System.Drawing.Point(8, 33)
            Me.buttonAdv2.Name = "buttonAdv2"
            Me.buttonAdv2.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv2.TabIndex = 2
            Me.buttonAdv2.Text = "buttonAdv2"
            Me.buttonAdv2.UseVisualStyle = True
            '
            'buttonAdv14
            '
            Me.buttonAdv14.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv14.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv14.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv14.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.RightEnd
            Me.buttonAdv14.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv14.KeepFocusRectangle = False
            Me.buttonAdv14.Location = New System.Drawing.Point(232, 73)
            Me.buttonAdv14.Name = "buttonAdv14"
            Me.buttonAdv14.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv14.TabIndex = 14
            Me.buttonAdv14.Text = "buttonAdv14"
            Me.buttonAdv14.UseVisualStyle = True
            '
            'buttonAdv13
            '
            Me.buttonAdv13.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv13.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv13.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv13.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.LeftEnd
            Me.buttonAdv13.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv13.KeepFocusRectangle = False
            Me.buttonAdv13.Location = New System.Drawing.Point(176, 73)
            Me.buttonAdv13.Name = "buttonAdv13"
            Me.buttonAdv13.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv13.TabIndex = 13
            Me.buttonAdv13.Text = "buttonAdv13"
            Me.buttonAdv13.UseVisualStyle = True
            '
            'buttonAdv12
            '
            Me.buttonAdv12.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv12.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv12.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv12.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse
            Me.buttonAdv12.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv12.KeepFocusRectangle = False
            Me.buttonAdv12.Location = New System.Drawing.Point(289, 73)
            Me.buttonAdv12.Name = "buttonAdv12"
            Me.buttonAdv12.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv12.TabIndex = 12
            Me.buttonAdv12.Text = "buttonAdv12"
            Me.buttonAdv12.UseVisualStyle = True
            '
            'buttonAdv11
            '
            Me.buttonAdv11.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv11.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv11.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv11.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check
            Me.buttonAdv11.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv11.KeepFocusRectangle = False
            Me.buttonAdv11.Location = New System.Drawing.Point(288, 33)
            Me.buttonAdv11.Name = "buttonAdv11"
            Me.buttonAdv11.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv11.TabIndex = 11
            Me.buttonAdv11.Text = "buttonAdv11"
            Me.buttonAdv11.UseVisualStyle = True
            '
            'buttonAdv10
            '
            Me.buttonAdv10.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv10.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv10.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv10.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Undo
            Me.buttonAdv10.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv10.KeepFocusRectangle = False
            Me.buttonAdv10.Location = New System.Drawing.Point(64, 33)
            Me.buttonAdv10.Name = "buttonAdv10"
            Me.buttonAdv10.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv10.TabIndex = 10
            Me.buttonAdv10.Text = "buttonAdv10"
            Me.buttonAdv10.UseVisualStyle = True
            '
            'buttonAdv9
            '
            Me.buttonAdv9.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv9.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv9.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv9.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo
            Me.buttonAdv9.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv9.KeepFocusRectangle = False
            Me.buttonAdv9.Location = New System.Drawing.Point(64, 73)
            Me.buttonAdv9.Name = "buttonAdv9"
            Me.buttonAdv9.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv9.TabIndex = 9
            Me.buttonAdv9.Text = "buttonAdv9"
            Me.buttonAdv9.UseVisualStyle = True
            '
            'buttonAdv8
            '
            Me.buttonAdv8.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv8.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv8.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv8.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Right
            Me.buttonAdv8.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv8.KeepFocusRectangle = False
            Me.buttonAdv8.Location = New System.Drawing.Point(232, 33)
            Me.buttonAdv8.Name = "buttonAdv8"
            Me.buttonAdv8.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv8.TabIndex = 8
            Me.buttonAdv8.Text = "buttonAdv8"
            Me.buttonAdv8.UseVisualStyle = True
            '
            'buttonAdv7
            '
            Me.buttonAdv7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv7.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv7.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv7.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Left
            Me.buttonAdv7.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv7.KeepFocusRectangle = False
            Me.buttonAdv7.Location = New System.Drawing.Point(176, 33)
            Me.buttonAdv7.Name = "buttonAdv7"
            Me.buttonAdv7.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv7.TabIndex = 7
            Me.buttonAdv7.Text = "buttonAdv7"
            Me.buttonAdv7.UseVisualStyle = True
            '
            'buttonAdv6
            '
            Me.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv6.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv6.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Up
            Me.buttonAdv6.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv6.KeepFocusRectangle = False
            Me.buttonAdv6.Location = New System.Drawing.Point(120, 33)
            Me.buttonAdv6.Name = "buttonAdv6"
            Me.buttonAdv6.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv6.TabIndex = 6
            Me.buttonAdv6.Text = "buttonAdv6"
            Me.buttonAdv6.UseVisualStyle = True
            '
            'buttonAdv5
            '
            Me.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv5.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv5.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down
            Me.buttonAdv5.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv5.KeepFocusRectangle = False
            Me.buttonAdv5.Location = New System.Drawing.Point(120, 73)
            Me.buttonAdv5.Name = "buttonAdv5"
            Me.buttonAdv5.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv5.TabIndex = 5
            Me.buttonAdv5.Text = "buttonAdv5"
            Me.buttonAdv5.UseVisualStyle = True
            '
            'buttonAdv3
            '
            Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv3.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv3.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Currency
            Me.buttonAdv3.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv3.KeepFocusRectangle = False
            Me.buttonAdv3.Location = New System.Drawing.Point(8, 73)
            Me.buttonAdv3.Name = "buttonAdv3"
            Me.buttonAdv3.Size = New System.Drawing.Size(48, 37)
            Me.buttonAdv3.TabIndex = 3
            Me.buttonAdv3.Text = "buttonAdv3"
            Me.buttonAdv3.UseVisualStyle = True
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer)))
            Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel3.Controls.Add(Me.buttonAdv24)
            Me.gradientPanel3.Controls.Add(Me.buttonAdv23)
            Me.gradientPanel3.Controls.Add(Me.gradientPanel1)
            Me.gradientPanel3.Controls.Add(Me.buttonAdv17)
            Me.gradientPanel3.Controls.Add(Me.buttonAdv16)
            Me.gradientPanel3.Controls.Add(Me.buttonAdv15)
            Me.gradientPanel3.Controls.Add(Me.buttonAdv4)
            Me.gradientPanel3.Controls.Add(Me.buttonAdv1)
            Me.gradientPanel3.Location = New System.Drawing.Point(12, 160)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(456, 223)
            Me.gradientPanel3.TabIndex = 37
            '
            'buttonAdv24
            '
            Me.buttonAdv24.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP
            Me.buttonAdv24.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonAdv24.KeepFocusRectangle = False
            Me.buttonAdv24.Location = New System.Drawing.Point(89, 159)
            Me.buttonAdv24.Name = "buttonAdv24"
            Me.buttonAdv24.Size = New System.Drawing.Size(75, 23)
            Me.buttonAdv24.TabIndex = 39
            Me.buttonAdv24.Text = "&Cancel"
            '
            'buttonAdv23
            '
            Me.buttonAdv23.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP
            Me.buttonAdv23.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonAdv23.KeepFocusRectangle = False
            Me.buttonAdv23.Location = New System.Drawing.Point(8, 159)
            Me.buttonAdv23.Name = "buttonAdv23"
            Me.buttonAdv23.Size = New System.Drawing.Size(75, 23)
            Me.buttonAdv23.TabIndex = 38
            Me.buttonAdv23.Text = "&OK"
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer)))
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(69, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.ButtonAdv25)
            Me.gradientPanel1.Controls.Add(Me.buttonAdv22)
            Me.gradientPanel1.Controls.Add(Me.buttonAdv20)
            Me.gradientPanel1.Controls.Add(Me.buttonAdv19)
            Me.gradientPanel1.Controls.Add(Me.label1)
            Me.gradientPanel1.Controls.Add(Me.buttonAdv18)
            Me.gradientPanel1.Controls.Add(Me.buttonAdv21)
            Me.gradientPanel1.Location = New System.Drawing.Point(188, 81)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(253, 128)
            Me.gradientPanel1.TabIndex = 37
            '
            'buttonAdv22
            '
            Me.buttonAdv22.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2003
            Me.buttonAdv22.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv22.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv22.KeepFocusRectangle = False
            Me.buttonAdv22.Location = New System.Drawing.Point(120, 30)
            Me.buttonAdv22.Name = "buttonAdv22"
            Me.buttonAdv22.Size = New System.Drawing.Size(110, 24)
            Me.buttonAdv22.TabIndex = 22
            Me.buttonAdv22.Text = "Office 2003"
            Me.buttonAdv22.UseVisualStyle = True
            '
            'buttonAdv20
            '
            Me.buttonAdv20.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv20.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv20.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv20.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv20.KeepFocusRectangle = False
            Me.buttonAdv20.Location = New System.Drawing.Point(12, 60)
            Me.buttonAdv20.Name = "buttonAdv20"
            Me.buttonAdv20.Size = New System.Drawing.Size(102, 24)
            Me.buttonAdv20.TabIndex = 20
            Me.buttonAdv20.Text = "Office 2007 Blue"
            Me.buttonAdv20.UseVisualStyle = True
            '
            'buttonAdv19
            '
            Me.buttonAdv19.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv19.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv19.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv19.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv19.ForeColor = System.Drawing.Color.White
            Me.buttonAdv19.KeepFocusRectangle = False
            Me.buttonAdv19.Location = New System.Drawing.Point(120, 60)
            Me.buttonAdv19.Name = "buttonAdv19"
            Me.buttonAdv19.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black
            Me.buttonAdv19.Size = New System.Drawing.Size(110, 24)
            Me.buttonAdv19.TabIndex = 19
            Me.buttonAdv19.Text = "Office 2007 Black"
            Me.buttonAdv19.UseVisualStyle = True
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(13, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(41, 14)
            Me.label1.TabIndex = 36
            Me.label1.Text = "Styles"
            '
            'buttonAdv18
            '
            Me.buttonAdv18.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv18.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv18.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv18.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv18.KeepFocusRectangle = False
            Me.buttonAdv18.Location = New System.Drawing.Point(12, 92)
            Me.buttonAdv18.Name = "buttonAdv18"
            Me.buttonAdv18.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver
            Me.buttonAdv18.Size = New System.Drawing.Size(103, 26)
            Me.buttonAdv18.TabIndex = 18
            Me.buttonAdv18.Text = "Office 2007 Silver"
            Me.buttonAdv18.UseVisualStyle = True
            '
            'buttonAdv21
            '
            Me.buttonAdv21.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2000
            Me.buttonAdv21.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv21.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv21.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv21.KeepFocusRectangle = False
            Me.buttonAdv21.Location = New System.Drawing.Point(12, 30)
            Me.buttonAdv21.Name = "buttonAdv21"
            Me.buttonAdv21.Size = New System.Drawing.Size(103, 24)
            Me.buttonAdv21.TabIndex = 21
            Me.buttonAdv21.Text = "Office XP"
            Me.buttonAdv21.UseVisualStyle = True
            '
            'buttonAdv17
            '
            Me.buttonAdv17.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv17.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv17.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv17.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv17.Image = CType(resources.GetObject("buttonAdv17.Image"), System.Drawing.Image)
            Me.buttonAdv17.KeepFocusRectangle = False
            Me.buttonAdv17.Location = New System.Drawing.Point(152, 81)
            Me.buttonAdv17.Name = "buttonAdv17"
            Me.buttonAdv17.Size = New System.Drawing.Size(30, 28)
            Me.buttonAdv17.TabIndex = 17
            Me.buttonAdv17.UseVisualStyle = True
            '
            'buttonAdv16
            '
            Me.buttonAdv16.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv16.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv16.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv16.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv16.Image = CType(resources.GetObject("buttonAdv16.Image"), System.Drawing.Image)
            Me.buttonAdv16.KeepFocusRectangle = False
            Me.buttonAdv16.Location = New System.Drawing.Point(119, 81)
            Me.buttonAdv16.Name = "buttonAdv16"
            Me.buttonAdv16.Size = New System.Drawing.Size(30, 28)
            Me.buttonAdv16.TabIndex = 16
            Me.buttonAdv16.UseVisualStyle = True
            '
            'buttonAdv15
            '
            Me.buttonAdv15.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv15.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv15.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv15.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv15.Image = CType(resources.GetObject("buttonAdv15.Image"), System.Drawing.Image)
            Me.buttonAdv15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.buttonAdv15.KeepFocusRectangle = False
            Me.buttonAdv15.Location = New System.Drawing.Point(152, 13)
            Me.buttonAdv15.Name = "buttonAdv15"
            Me.buttonAdv15.Size = New System.Drawing.Size(174, 51)
            Me.buttonAdv15.TabIndex = 15
            Me.buttonAdv15.Text = "Save a copy of item in one " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the available formats." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            Me.buttonAdv15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.buttonAdv15.UseVisualStyle = True
            '
            'buttonAdv4
            '
            Me.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv4.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv4.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv4.Image = CType(resources.GetObject("buttonAdv4.Image"), System.Drawing.Image)
            Me.buttonAdv4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.buttonAdv4.Location = New System.Drawing.Point(8, 13)
            Me.buttonAdv4.Name = "buttonAdv4"
            Me.buttonAdv4.Size = New System.Drawing.Size(122, 51)
            Me.buttonAdv4.TabIndex = 14
            Me.buttonAdv4.Text = "&New Document"
            Me.buttonAdv4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.buttonAdv4.UseVisualStyle = True
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv1.BackColor = System.Drawing.SystemColors.Control
            Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Silver
            Me.buttonAdv1.Image = CType(resources.GetObject("buttonAdv1.Image"), System.Drawing.Image)
            Me.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.buttonAdv1.KeepFocusRectangle = False
            Me.buttonAdv1.Location = New System.Drawing.Point(8, 81)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black
            Me.buttonAdv1.Size = New System.Drawing.Size(104, 57)
            Me.buttonAdv1.TabIndex = 13
            Me.buttonAdv1.Text = "Image above Text"
            Me.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.buttonAdv1.UseVisualStyle = True
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer)))
            Me.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.buttonAdv6)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv3)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv2)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv5)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv14)
            Me.gradientPanel2.Controls.Add(Me.label5)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv13)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv7)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv9)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv8)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv11)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv12)
            Me.gradientPanel2.Controls.Add(Me.buttonAdv10)
            Me.gradientPanel2.Location = New System.Drawing.Point(12, 12)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(456, 126)
            Me.gradientPanel2.TabIndex = 36
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(3, 9)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(80, 14)
            Me.label5.TabIndex = 35
            Me.label5.Text = "Button Types"
            '
            'ButtonAdv25
            '
            Me.ButtonAdv25.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.ButtonAdv25.BackColor = System.Drawing.SystemColors.Control
            Me.ButtonAdv25.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed
            Me.ButtonAdv25.ComboEditBackColor = System.Drawing.Color.Silver
            Me.ButtonAdv25.KeepFocusRectangle = False
            Me.ButtonAdv25.Location = New System.Drawing.Point(120, 92)
            Me.ButtonAdv25.Name = "ButtonAdv25"
            Me.ButtonAdv25.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
            Me.ButtonAdv25.Size = New System.Drawing.Size(110, 26)
            Me.ButtonAdv25.TabIndex = 37
            Me.ButtonAdv25.Text = "Office2007Managed"
            Me.ButtonAdv25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ButtonAdv25.UseVisualStyle = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(482, 398)
            Me.Controls.Add(Me.gradientPanel2)
            Me.Controls.Add(Me.gradientPanel3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "ButtonAdv"
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel3.ResumeLayout(False)
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.gradientPanel1.PerformLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.gradientPanel2.PerformLayout()
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

	
        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.ColorScheme = Office2007Theme.Blue
            Office2007Colors.ApplyManagedColors(Me, Color.HotPink)
        End Sub
    End Class
End Namespace
