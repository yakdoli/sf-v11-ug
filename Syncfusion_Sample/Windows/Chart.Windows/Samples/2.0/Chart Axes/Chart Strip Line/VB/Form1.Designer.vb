Imports Microsoft.VisualBasic
Imports System
Namespace Chart_StripLine
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.domainUpDown1 = New System.Windows.Forms.DomainUpDown
            Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.panel2 = New System.Windows.Forms.Panel
            Me.label9 = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.panel4 = New System.Windows.Forms.Panel
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.label10 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.numericUpDown4 = New System.Windows.Forms.NumericUpDown
            Me.label4 = New System.Windows.Forms.Label
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.label1 = New System.Windows.Forms.Label
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.button2 = New System.Windows.Forms.Button
            Me.label6 = New System.Windows.Forms.Label
            Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label3 = New System.Windows.Forms.Label
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label5 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.numericUpDown5 = New System.Windows.Forms.NumericUpDown
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.panel4.SuspendLayout()
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 5, 2)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ElementsSpacing = 0
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.ForeColor = System.Drawing.SystemColors.ControlText
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(47, 35)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.Spacing = 3
            Me.chartControl1.Location = New System.Drawing.Point(8, 6)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryXAxis.Title = "Days"
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryYAxis.Title = "Temperature"
            Me.chartControl1.Size = New System.Drawing.Size(422, 305)
            Me.chartControl1.TabIndex = 4
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.chartControl1.ToolBar.ButtonBackColor = System.Drawing.SystemColors.ControlLight
            Me.chartControl1.ToolBar.ButtonForeColor = System.Drawing.SystemColors.ActiveBorder
            Me.chartControl1.ToolBar.ButtonSize = New System.Drawing.Size(26, 26)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.domainUpDown1)
            Me.panel1.Controls.Add(Me.buttonAdv3)
            Me.panel1.Controls.Add(Me.buttonAdv2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 319)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(438, 21)
            Me.panel1.TabIndex = 5
            '
            'domainUpDown1
            '
            Me.domainUpDown1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.domainUpDown1.Items.Add("Monday")
            Me.domainUpDown1.Items.Add("Tuesday")
            Me.domainUpDown1.Items.Add("Wednesday")
            Me.domainUpDown1.Items.Add("Thursday")
            Me.domainUpDown1.Items.Add("Friday")
            Me.domainUpDown1.Items.Add("Saturday")
            Me.domainUpDown1.Items.Add("Sunday")
            Me.domainUpDown1.Location = New System.Drawing.Point(180, 1)
            Me.domainUpDown1.Name = "domainUpDown1"
            Me.domainUpDown1.ReadOnly = True
            Me.domainUpDown1.Size = New System.Drawing.Size(75, 20)
            Me.domainUpDown1.TabIndex = 54
            Me.domainUpDown1.Text = "Thursday"
            '
            'buttonAdv3
            '
            Me.buttonAdv3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP
            Me.buttonAdv3.BackColor = System.Drawing.Color.Transparent
            Me.buttonAdv3.KeepFocusRectangle = False
            Me.buttonAdv3.Location = New System.Drawing.Point(0, 0)
            Me.buttonAdv3.Name = "buttonAdv3"
            Me.buttonAdv3.Size = New System.Drawing.Size(138, 21)
            Me.buttonAdv3.TabIndex = 57
            Me.buttonAdv3.Text = "Mark High Temperature"
            Me.buttonAdv3.UseVisualStyle = False
            '
            'buttonAdv2
            '
            Me.buttonAdv2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP
            Me.buttonAdv2.BackColor = System.Drawing.Color.Transparent
            Me.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.buttonAdv2.KeepFocusRectangle = False
            Me.buttonAdv2.Location = New System.Drawing.Point(300, 0)
            Me.buttonAdv2.Name = "buttonAdv2"
            Me.buttonAdv2.Size = New System.Drawing.Size(138, 21)
            Me.buttonAdv2.TabIndex = 56
            Me.buttonAdv2.Text = "Create StripLine"
            Me.buttonAdv2.UseVisualStyle = False
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.White
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.label11)
            Me.panel2.Controls.Add(Me.numericUpDown5)
            Me.panel2.Controls.Add(Me.checkBox1)
            Me.panel2.Controls.Add(Me.label9)
            Me.panel2.Controls.Add(Me.label14)
            Me.panel2.Controls.Add(Me.label8)
            Me.panel2.Controls.Add(Me.panel4)
            Me.panel2.Controls.Add(Me.comboBox2)
            Me.panel2.Controls.Add(Me.label10)
            Me.panel2.Controls.Add(Me.label7)
            Me.panel2.Controls.Add(Me.numericUpDown4)
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Controls.Add(Me.numericUpDown2)
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Controls.Add(Me.radioButton2)
            Me.panel2.Controls.Add(Me.radioButton1)
            Me.panel2.Controls.Add(Me.button2)
            Me.panel2.Controls.Add(Me.label6)
            Me.panel2.Controls.Add(Me.numericUpDown3)
            Me.panel2.Controls.Add(Me.numericUpDown1)
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Controls.Add(Me.label2)
            Me.panel2.Controls.Add(Me.comboBox1)
            Me.panel2.Controls.Add(Me.label5)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel2.Location = New System.Drawing.Point(0, 340)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(438, 180)
            Me.panel2.TabIndex = 1
            '
            'label9
            '
            Me.label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label9.Location = New System.Drawing.Point(308, 19)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(1, 120)
            Me.label9.TabIndex = 66
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label14.Location = New System.Drawing.Point(121, 19)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(1, 120)
            Me.label14.TabIndex = 65
            '
            'label8
            '
            Me.label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label8.AutoSize = True
            Me.label8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label8.Location = New System.Drawing.Point(7, 21)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(70, 13)
            Me.label8.TabIndex = 64
            Me.label8.Text = "StripLine Axis"
            '
            'panel4
            '
            Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel4.Controls.Add(Me.textBox3)
            Me.panel4.Controls.Add(Me.colorPickerButton1)
            Me.panel4.Location = New System.Drawing.Point(207, 102)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(90, 21)
            Me.panel4.TabIndex = 63
            '
            'textBox3
            '
            Me.textBox3.BackColor = System.Drawing.Color.Black
            Me.textBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox3.Location = New System.Drawing.Point(0, 0)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ReadOnly = True
            Me.textBox3.Size = New System.Drawing.Size(71, 20)
            Me.textBox3.TabIndex = 11
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.Black
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton1.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Image = CType(resources.GetObject("colorPickerButton1.Image"), System.Drawing.Image)
            Me.colorPickerButton1.Location = New System.Drawing.Point(71, 0)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.Black
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton1.TabIndex = 14
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'comboBox2
            '
            Me.comboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox2.Items.AddRange(New Object() {"Default", "DateTime"})
            Me.comboBox2.Location = New System.Drawing.Point(208, 22)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(90, 21)
            Me.comboBox2.TabIndex = 61
            '
            'label10
            '
            Me.label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label10.AutoSize = True
            Me.label10.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label10.Location = New System.Drawing.Point(129, 24)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(75, 13)
            Me.label10.TabIndex = 60
            Me.label10.Text = "StripLine Type"
            '
            'label7
            '
            Me.label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label7.AutoSize = True
            Me.label7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label7.Location = New System.Drawing.Point(129, 102)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(55, 13)
            Me.label7.TabIndex = 57
            Me.label7.Text = "Text Color"
            '
            'numericUpDown4
            '
            Me.numericUpDown4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown4.BackColor = System.Drawing.Color.White
            Me.numericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown4.Location = New System.Drawing.Point(391, 93)
            Me.numericUpDown4.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
            Me.numericUpDown4.Name = "numericUpDown4"
            Me.numericUpDown4.ReadOnly = True
            Me.numericUpDown4.Size = New System.Drawing.Size(37, 20)
            Me.numericUpDown4.TabIndex = 55
            Me.numericUpDown4.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label4
            '
            Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label4.BackColor = System.Drawing.Color.White
            Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label4.Location = New System.Drawing.Point(318, 93)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(58, 31)
            Me.label4.TabIndex = 56
            Me.label4.Text = "Repitition " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Frequency"
            '
            'numericUpDown2
            '
            Me.numericUpDown2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown2.BackColor = System.Drawing.Color.White
            Me.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown2.Location = New System.Drawing.Point(391, 70)
            Me.numericUpDown2.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.ReadOnly = True
            Me.numericUpDown2.Size = New System.Drawing.Size(37, 20)
            Me.numericUpDown2.TabIndex = 53
            Me.numericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label1
            '
            Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.AutoSize = True
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(318, 70)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(58, 13)
            Me.label1.TabIndex = 54
            Me.label1.Text = "DateOffset"
            '
            'radioButton2
            '
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Checked = True
            Me.radioButton2.Location = New System.Drawing.Point(43, 86)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(32, 17)
            Me.radioButton2.TabIndex = 52
            Me.radioButton2.TabStop = True
            Me.radioButton2.Text = "Y"
            Me.radioButton2.UseVisualStyleBackColor = True
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Location = New System.Drawing.Point(41, 51)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(32, 17)
            Me.radioButton1.TabIndex = 51
            Me.radioButton1.Text = "X"
            Me.radioButton1.UseVisualStyleBackColor = True
            '
            'button2
            '
            Me.button2.Location = New System.Drawing.Point(135, 152)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(161, 23)
            Me.button2.TabIndex = 47
            Me.button2.Text = "Click here to Add StripLine"
            Me.button2.UseVisualStyleBackColor = True
            '
            'label6
            '
            Me.label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label6.AutoSize = True
            Me.label6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label6.Location = New System.Drawing.Point(318, 47)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(35, 13)
            Me.label6.TabIndex = 39
            Me.label6.Text = "Width"
            '
            'numericUpDown3
            '
            Me.numericUpDown3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown3.BackColor = System.Drawing.Color.White
            Me.numericUpDown3.Location = New System.Drawing.Point(391, 47)
            Me.numericUpDown3.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
            Me.numericUpDown3.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown3.Name = "numericUpDown3"
            Me.numericUpDown3.ReadOnly = True
            Me.numericUpDown3.Size = New System.Drawing.Size(37, 20)
            Me.numericUpDown3.TabIndex = 33
            Me.numericUpDown3.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown1.BackColor = System.Drawing.Color.White
            Me.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown1.Location = New System.Drawing.Point(391, 24)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.ReadOnly = True
            Me.numericUpDown1.Size = New System.Drawing.Size(37, 20)
            Me.numericUpDown1.TabIndex = 32
            Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label3
            '
            Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label3.AutoSize = True
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(129, 78)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(67, 13)
            Me.label3.TabIndex = 29
            Me.label3.Text = "Text position"
            '
            'textBox1
            '
            Me.textBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox1.Location = New System.Drawing.Point(207, 48)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(90, 20)
            Me.textBox1.TabIndex = 28
            Me.textBox1.Text = "New StripLine"
            '
            'label2
            '
            Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(129, 50)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(72, 13)
            Me.label2.TabIndex = 27
            Me.label2.Text = "StripLine Text"
            '
            'comboBox1
            '
            Me.comboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.Location = New System.Drawing.Point(207, 73)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(90, 21)
            Me.comboBox1.TabIndex = 26
            '
            'label5
            '
            Me.label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.White
            Me.label5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label5.Location = New System.Drawing.Point(318, 24)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(69, 13)
            Me.label5.TabIndex = 38
            Me.label5.Text = "Start Position"
            '
            'label11
            '
            Me.label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label11.AutoSize = True
            Me.label11.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label11.Location = New System.Drawing.Point(10, 147)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(63, 13)
            Me.label11.TabIndex = 72
            Me.label11.Text = "Fixed Width"
            '
            'numericUpDown5
            '
            Me.numericUpDown5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.numericUpDown5.BackColor = System.Drawing.Color.White
            Me.numericUpDown5.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.numericUpDown5.Location = New System.Drawing.Point(76, 145)
            Me.numericUpDown5.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown5.Name = "numericUpDown5"
            Me.numericUpDown5.ReadOnly = True
            Me.numericUpDown5.Size = New System.Drawing.Size(43, 20)
            Me.numericUpDown5.TabIndex = 71
            Me.numericUpDown5.Value = New Decimal(New Integer() {10, 0, 0, 0})
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(11, 122)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(82, 17)
            Me.checkBox1.TabIndex = 70
            Me.checkBox1.Text = "Fixed Width"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(438, 520)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.panel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Strip Line"
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            CType(Me.numericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private label6 As System.Windows.Forms.Label
		Private numericUpDown3 As System.Windows.Forms.NumericUpDown
		Private numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private label3 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private label5 As System.Windows.Forms.Label
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private numericUpDown2 As System.Windows.Forms.NumericUpDown
		Private label1 As System.Windows.Forms.Label
		Private numericUpDown4 As System.Windows.Forms.NumericUpDown
		Private label4 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents domainUpDown1 As System.Windows.Forms.DomainUpDown
		Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
		Private label10 As System.Windows.Forms.Label
		Private panel4 As System.Windows.Forms.Panel
		Private textBox3 As System.Windows.Forms.TextBox
		Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label9 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
        Private label8 As System.Windows.Forms.Label
        Private WithEvents label11 As System.Windows.Forms.Label
        Private WithEvents numericUpDown5 As System.Windows.Forms.NumericUpDown
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
	End Class
End Namespace

