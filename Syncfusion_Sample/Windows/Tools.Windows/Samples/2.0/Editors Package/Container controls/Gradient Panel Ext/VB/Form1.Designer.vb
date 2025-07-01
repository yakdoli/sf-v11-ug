Imports Microsoft.VisualBasic
Imports System
Namespace GradientPanelExtDemo
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
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
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.backcolorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton2 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.gradientPanelExt1 = New Syncfusion.Windows.Forms.Tools.GradientPanelExt
            Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.gradientStyleCombo = New System.Windows.Forms.ComboBox
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.foreColorEdit = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.hostPrimitive_rB = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.collapsePrimitive_rB = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.imagePrimitive_rB = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.textPrimitive_rB = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.cornerRadiusUpDown = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.borderGapUpDown = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.cornerRadiusLabel = New System.Windows.Forms.Label
            Me.borderGapLabel = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.gradientStyleLabel = New System.Windows.Forms.Label
            Me.foreColorlabel = New System.Windows.Forms.Label
            Me.backColorlabel = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.backcolorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backcolorEdit.SuspendLayout()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gradientPanelExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanelExt1.SuspendLayout()
            CType(Me.foreColorEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.foreColorEdit.SuspendLayout()
            CType(Me.hostPrimitive_rB, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.collapsePrimitive_rB, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.imagePrimitive_rB, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textPrimitive_rB, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.cornerRadiusUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.borderGapUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.AliceBlue, System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel1.Controls.Add(Me.backcolorEdit)
            Me.gradientPanel1.Controls.Add(Me.checkBoxAdv1)
            Me.gradientPanel1.Controls.Add(Me.gradientPanelExt1)
            Me.gradientPanel1.Controls.Add(Me.gradientStyleCombo)
            Me.gradientPanel1.Controls.Add(Me.comboBox1)
            Me.gradientPanel1.Controls.Add(Me.label2)
            Me.gradientPanel1.Controls.Add(Me.foreColorEdit)
            Me.gradientPanel1.Controls.Add(Me.hostPrimitive_rB)
            Me.gradientPanel1.Controls.Add(Me.collapsePrimitive_rB)
            Me.gradientPanel1.Controls.Add(Me.imagePrimitive_rB)
            Me.gradientPanel1.Controls.Add(Me.textPrimitive_rB)
            Me.gradientPanel1.Controls.Add(Me.label1)
            Me.gradientPanel1.Controls.Add(Me.cornerRadiusUpDown)
            Me.gradientPanel1.Controls.Add(Me.borderGapUpDown)
            Me.gradientPanel1.Controls.Add(Me.cornerRadiusLabel)
            Me.gradientPanel1.Controls.Add(Me.borderGapLabel)
            Me.gradientPanel1.Controls.Add(Me.label7)
            Me.gradientPanel1.Controls.Add(Me.label6)
            Me.gradientPanel1.Controls.Add(Me.label4)
            Me.gradientPanel1.Controls.Add(Me.label3)
            Me.gradientPanel1.Controls.Add(Me.gradientStyleLabel)
            Me.gradientPanel1.Controls.Add(Me.foreColorlabel)
            Me.gradientPanel1.Controls.Add(Me.backColorlabel)
            Me.gradientPanel1.Controls.Add(Me.label14)
            Me.gradientPanel1.Controls.Add(Me.label5)
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel1.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(636, 438)
            Me.gradientPanel1.TabIndex = 0
            '
            'backcolorEdit
            '
            Me.backcolorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.backcolorEdit.Buttons.Add(Me.buttonEditChildButton2)
            Me.backcolorEdit.Controls.Add(Me.buttonEditChildButton2)
            Me.backcolorEdit.Location = New System.Drawing.Point(94, 290)
            Me.backcolorEdit.Name = "backcolorEdit"
            Me.backcolorEdit.Size = New System.Drawing.Size(118, 26)
            Me.backcolorEdit.TabIndex = 55
            Me.backcolorEdit.UseVisualStyle = True
            '
            'buttonEditChildButton2
            '
            Me.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton2.Image = Nothing
            Me.buttonEditChildButton2.Name = "buttonEditChildButton2"
            Me.buttonEditChildButton2.PreferredWidth = 18
            Me.buttonEditChildButton2.TabIndex = 1
            Me.buttonEditChildButton2.Text = "..."
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv1.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv1.Location = New System.Drawing.Point(724, 85)
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv1.Size = New System.Drawing.Size(90, 20)
            Me.checkBoxAdv1.TabIndex = 49
            Me.checkBoxAdv1.Text = "Find Options"
            Me.checkBoxAdv1.ThemesEnabled = True
            '
            'gradientPanelExt1
            '
            Me.gradientPanelExt1.BackColor = System.Drawing.Color.Transparent
            Me.gradientPanelExt1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.White)
            Me.gradientPanelExt1.BorderColor = System.Drawing.Color.Black
            Me.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanelExt1.Controls.Add(Me.autoLabel1)
            Me.gradientPanelExt1.ExpandLocation = New System.Drawing.Point(0, 0)
            Me.gradientPanelExt1.ExpandSize = New System.Drawing.Size(0, 0)
            Me.gradientPanelExt1.Location = New System.Drawing.Point(185, 66)
            Me.gradientPanelExt1.Name = "gradientPanelExt1"
            Me.gradientPanelExt1.Size = New System.Drawing.Size(294, 161)
            Me.gradientPanelExt1.TabIndex = 54
            '
            'autoLabel1
            '
            Me.autoLabel1.DX = 0
            Me.autoLabel1.DY = 0
            Me.autoLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.autoLabel1.Location = New System.Drawing.Point(91, 64)
            Me.autoLabel1.Name = "autoLabel1"
            Me.autoLabel1.Size = New System.Drawing.Size(105, 13)
            Me.autoLabel1.TabIndex = 0
            Me.autoLabel1.Text = "GradientPanelExt"
            '
            'gradientStyleCombo
            '
            Me.gradientStyleCombo.FormattingEnabled = True
            Me.gradientStyleCombo.Items.AddRange(New Object() {"None", "ForwardDiagonal", "BackwardDiagonal", "Horizontal", "Vertical"})
            Me.gradientStyleCombo.Location = New System.Drawing.Point(94, 364)
            Me.gradientStyleCombo.Name = "gradientStyleCombo"
            Me.gradientStyleCombo.Size = New System.Drawing.Size(118, 21)
            Me.gradientStyleCombo.TabIndex = 47
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Top", "Bottom", "Left", "Right"})
            Me.comboBox1.Location = New System.Drawing.Point(530, 302)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(66, 21)
            Me.comboBox1.TabIndex = 46
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(428, 302)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(96, 14)
            Me.label2.TabIndex = 45
            Me.label2.Text = "Primitive Alignment"
            '
            'foreColorEdit
            '
            Me.foreColorEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.foreColorEdit.Buttons.Add(Me.buttonEditChildButton1)
            Me.foreColorEdit.Controls.Add(Me.buttonEditChildButton1)
            Me.foreColorEdit.Location = New System.Drawing.Point(94, 332)
            Me.foreColorEdit.Name = "foreColorEdit"
            Me.foreColorEdit.Size = New System.Drawing.Size(118, 26)
            Me.foreColorEdit.TabIndex = 43
            Me.foreColorEdit.UseVisualStyle = True
            '
            'buttonEditChildButton1
            '
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 18
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            '
            'hostPrimitive_rB
            '
            Me.hostPrimitive_rB.BackColor = System.Drawing.Color.Transparent
            Me.hostPrimitive_rB.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.hostPrimitive_rB.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.hostPrimitive_rB.GradientStart = System.Drawing.SystemColors.Control
            Me.hostPrimitive_rB.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.hostPrimitive_rB.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.hostPrimitive_rB.Location = New System.Drawing.Point(431, 407)
            Me.hostPrimitive_rB.Name = "hostPrimitive_rB"
            Me.hostPrimitive_rB.ShadowColor = System.Drawing.Color.Black
            Me.hostPrimitive_rB.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.hostPrimitive_rB.Size = New System.Drawing.Size(163, 21)
            Me.hostPrimitive_rB.TabIndex = 41
            Me.hostPrimitive_rB.Text = "Host Primitive"
            Me.hostPrimitive_rB.ThemesEnabled = False
            '
            'collapsePrimitive_rB
            '
            Me.collapsePrimitive_rB.BackColor = System.Drawing.Color.Transparent
            Me.collapsePrimitive_rB.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.collapsePrimitive_rB.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.collapsePrimitive_rB.GradientStart = System.Drawing.SystemColors.Control
            Me.collapsePrimitive_rB.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.collapsePrimitive_rB.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.collapsePrimitive_rB.Location = New System.Drawing.Point(431, 380)
            Me.collapsePrimitive_rB.Name = "collapsePrimitive_rB"
            Me.collapsePrimitive_rB.ShadowColor = System.Drawing.Color.Black
            Me.collapsePrimitive_rB.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.collapsePrimitive_rB.Size = New System.Drawing.Size(163, 21)
            Me.collapsePrimitive_rB.TabIndex = 40
            Me.collapsePrimitive_rB.Text = "Collapse Primitive"
            Me.collapsePrimitive_rB.ThemesEnabled = False
            '
            'imagePrimitive_rB
            '
            Me.imagePrimitive_rB.BackColor = System.Drawing.Color.Transparent
            Me.imagePrimitive_rB.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.imagePrimitive_rB.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.imagePrimitive_rB.GradientStart = System.Drawing.SystemColors.Control
            Me.imagePrimitive_rB.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.imagePrimitive_rB.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.imagePrimitive_rB.Location = New System.Drawing.Point(431, 353)
            Me.imagePrimitive_rB.Name = "imagePrimitive_rB"
            Me.imagePrimitive_rB.ShadowColor = System.Drawing.Color.Black
            Me.imagePrimitive_rB.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.imagePrimitive_rB.Size = New System.Drawing.Size(107, 21)
            Me.imagePrimitive_rB.TabIndex = 39
            Me.imagePrimitive_rB.Text = "Image Primitive"
            Me.imagePrimitive_rB.ThemesEnabled = False
            '
            'textPrimitive_rB
            '
            Me.textPrimitive_rB.BackColor = System.Drawing.Color.Transparent
            Me.textPrimitive_rB.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.textPrimitive_rB.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.textPrimitive_rB.GradientStart = System.Drawing.SystemColors.Control
            Me.textPrimitive_rB.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.textPrimitive_rB.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.textPrimitive_rB.Location = New System.Drawing.Point(431, 326)
            Me.textPrimitive_rB.Name = "textPrimitive_rB"
            Me.textPrimitive_rB.ShadowColor = System.Drawing.Color.Black
            Me.textPrimitive_rB.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.textPrimitive_rB.Size = New System.Drawing.Size(163, 21)
            Me.textPrimitive_rB.TabIndex = 38
            Me.textPrimitive_rB.Text = "Text Primitive"
            Me.textPrimitive_rB.ThemesEnabled = False
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
            Me.label1.ImageIndex = 0
            Me.label1.ImageList = Me.imageList1
            Me.label1.Location = New System.Drawing.Point(10, 15)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(619, 48)
            Me.label1.TabIndex = 37
            Me.label1.Text = resources.GetString("label1.Text")
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'cornerRadiusUpDown
            '
            Me.cornerRadiusUpDown.Location = New System.Drawing.Point(326, 334)
            Me.cornerRadiusUpDown.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
            Me.cornerRadiusUpDown.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.cornerRadiusUpDown.Name = "cornerRadiusUpDown"
            Me.cornerRadiusUpDown.Size = New System.Drawing.Size(67, 20)
            Me.cornerRadiusUpDown.TabIndex = 34
            Me.cornerRadiusUpDown.Value = New Decimal(New Integer() {28, 0, 0, 0})
            '
            'borderGapUpDown
            '
            Me.borderGapUpDown.Location = New System.Drawing.Point(326, 301)
            Me.borderGapUpDown.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
            Me.borderGapUpDown.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.borderGapUpDown.Name = "borderGapUpDown"
            Me.borderGapUpDown.Size = New System.Drawing.Size(67, 20)
            Me.borderGapUpDown.TabIndex = 33
            Me.borderGapUpDown.Value = New Decimal(New Integer() {12, 0, 0, 0})
            '
            'cornerRadiusLabel
            '
            Me.cornerRadiusLabel.AutoSize = True
            Me.cornerRadiusLabel.BackColor = System.Drawing.Color.Transparent
            Me.cornerRadiusLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cornerRadiusLabel.Location = New System.Drawing.Point(242, 332)
            Me.cornerRadiusLabel.Name = "cornerRadiusLabel"
            Me.cornerRadiusLabel.Size = New System.Drawing.Size(76, 14)
            Me.cornerRadiusLabel.TabIndex = 32
            Me.cornerRadiusLabel.Text = "Corner Radius"
            '
            'borderGapLabel
            '
            Me.borderGapLabel.AutoSize = True
            Me.borderGapLabel.BackColor = System.Drawing.Color.Transparent
            Me.borderGapLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.borderGapLabel.Location = New System.Drawing.Point(242, 301)
            Me.borderGapLabel.Name = "borderGapLabel"
            Me.borderGapLabel.Size = New System.Drawing.Size(63, 14)
            Me.borderGapLabel.TabIndex = 31
            Me.borderGapLabel.Text = "Border Gap"
            '
            'label7
            '
            Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label7.Location = New System.Drawing.Point(242, 284)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(160, 1)
            Me.label7.TabIndex = 30
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.Transparent
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(242, 260)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(90, 24)
            Me.label6.TabIndex = 29
            Me.label6.Text = "Properties"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label4.Location = New System.Drawing.Point(428, 261)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(90, 24)
            Me.label4.TabIndex = 24
            Me.label4.Text = "Primitives"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label3.Location = New System.Drawing.Point(428, 285)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(168, 1)
            Me.label3.TabIndex = 23
            '
            'gradientStyleLabel
            '
            Me.gradientStyleLabel.AutoSize = True
            Me.gradientStyleLabel.BackColor = System.Drawing.Color.Transparent
            Me.gradientStyleLabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientStyleLabel.Location = New System.Drawing.Point(19, 363)
            Me.gradientStyleLabel.Name = "gradientStyleLabel"
            Me.gradientStyleLabel.Size = New System.Drawing.Size(74, 14)
            Me.gradientStyleLabel.TabIndex = 21
            Me.gradientStyleLabel.Text = "Gradient style"
            '
            'foreColorlabel
            '
            Me.foreColorlabel.AutoSize = True
            Me.foreColorlabel.BackColor = System.Drawing.Color.Transparent
            Me.foreColorlabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.foreColorlabel.Location = New System.Drawing.Point(19, 332)
            Me.foreColorlabel.Name = "foreColorlabel"
            Me.foreColorlabel.Size = New System.Drawing.Size(54, 14)
            Me.foreColorlabel.TabIndex = 19
            Me.foreColorlabel.Text = "ForeColor"
            '
            'backColorlabel
            '
            Me.backColorlabel.AutoSize = True
            Me.backColorlabel.BackColor = System.Drawing.Color.Transparent
            Me.backColorlabel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.backColorlabel.Location = New System.Drawing.Point(19, 301)
            Me.backColorlabel.Name = "backColorlabel"
            Me.backColorlabel.Size = New System.Drawing.Size(59, 14)
            Me.backColorlabel.TabIndex = 17
            Me.backColorlabel.Text = "Back Color"
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label14.Location = New System.Drawing.Point(19, 284)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(190, 1)
            Me.label14.TabIndex = 16
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(19, 260)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(175, 24)
            Me.label5.TabIndex = 15
            Me.label5.Text = "Background Color Options"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(636, 438)
            Me.Controls.Add(Me.gradientPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Gradient Panel Ext"
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.gradientPanel1.PerformLayout()
            CType(Me.backcolorEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backcolorEdit.ResumeLayout(False)
            Me.backcolorEdit.PerformLayout()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gradientPanelExt1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanelExt1.ResumeLayout(False)
            Me.gradientPanelExt1.PerformLayout()
            CType(Me.foreColorEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.foreColorEdit.ResumeLayout(False)
            Me.foreColorEdit.PerformLayout()
            CType(Me.hostPrimitive_rB, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.collapsePrimitive_rB, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.imagePrimitive_rB, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textPrimitive_rB, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.cornerRadiusUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.borderGapUpDown, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private backColorlabel As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private foreColorlabel As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private gradientStyleLabel As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private WithEvents cornerRadiusUpDown As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private WithEvents borderGapUpDown As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private cornerRadiusLabel As System.Windows.Forms.Label
		Private borderGapLabel As System.Windows.Forms.Label
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private WithEvents hostPrimitive_rB As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents collapsePrimitive_rB As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents imagePrimitive_rB As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents textPrimitive_rB As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private label1 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents foreColorEdit As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton1 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private label2 As System.Windows.Forms.Label
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private WithEvents gradientStyleCombo As System.Windows.Forms.ComboBox
		Private gradientPanelExt1 As Syncfusion.Windows.Forms.Tools.GradientPanelExt
		Private checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private autoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
		Private WithEvents backcolorEdit As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton2 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton


	End Class
End Namespace

