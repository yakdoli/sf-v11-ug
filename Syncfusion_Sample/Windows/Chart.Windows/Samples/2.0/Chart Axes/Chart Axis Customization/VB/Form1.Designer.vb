Imports Microsoft.VisualBasic
Imports System
Namespace ChartAxisCustomization_2005
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
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.label3 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.label25 = New System.Windows.Forms.Label
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.checkBox5 = New System.Windows.Forms.CheckBox
            Me.label4 = New System.Windows.Forms.Label
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.label5 = New System.Windows.Forms.Label
            Me.comboBox5 = New System.Windows.Forms.ComboBox
            Me.label11 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.comboBox6 = New System.Windows.Forms.ComboBox
            Me.panel3 = New System.Windows.Forms.Panel
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.colorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.panel2 = New System.Windows.Forms.Panel
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label9 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.label22 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.checkBoxXAxis = New System.Windows.Forms.CheckBox
            Me.checkBoxYAxis = New System.Windows.Forms.CheckBox
            Me.label13 = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.label15 = New System.Windows.Forms.Label
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.comboBox7 = New System.Windows.Forms.ComboBox
            Me.label16 = New System.Windows.Forms.Label
            Me.label17 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.checkBox6 = New System.Windows.Forms.CheckBox
            Me.label23 = New System.Windows.Forms.Label
            Me.label35 = New System.Windows.Forms.Label
            Me.label24 = New System.Windows.Forms.Label
            Me.label26 = New System.Windows.Forms.Label
            Me.comboBox_FontStyle = New System.Windows.Forms.ComboBox
            Me.panel9 = New System.Windows.Forms.Panel
            Me.textBox_TextColor = New System.Windows.Forms.TextBox
            Me.colorPicker_TextColor = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.numericUpDown_FontSize = New System.Windows.Forms.NumericUpDown
            Me.comboBox_Fontfamily = New System.Windows.Forms.ComboBox
            Me.label18 = New System.Windows.Forms.Label
            Me.label19 = New System.Windows.Forms.Label
            Me.checkBox7 = New System.Windows.Forms.CheckBox
            Me.checkBox8 = New System.Windows.Forms.CheckBox
            Me.panel3.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.panel9.SuspendLayout()
            CType(Me.numericUpDown_FontSize, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Raised
            Me.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            Me.chartControl1.Font = New System.Drawing.Font("Arial", 10.0!)
            Me.chartControl1.IsWindowLess = False
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.AliceBlue)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(410, 77)
            Me.chartControl1.Localize = Nothing
            Me.chartControl1.Location = New System.Drawing.Point(12, 7)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
            Me.chartControl1.PrimaryXAxis.Margin = True
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryXAxis.Title = "Peak Load hours"
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
            Me.chartControl1.PrimaryYAxis.Margin = True
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.Title = "Server load (MB)"
            Me.chartControl1.Size = New System.Drawing.Size(531, 389)
            Me.chartControl1.TabIndex = 3
            Me.chartControl1.Text = "Peak Average Network loads"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Peak Average Network loads"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(13, 483)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(30, 13)
            Me.label1.TabIndex = 36
            Me.label1.Text = "Style"
            '
            'comboBox1
            '
            Me.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Items.AddRange(New Object() {"Solid", "Dash", "Dot", "DashDot", "DashDotDot", "Custom"})
            Me.comboBox1.Location = New System.Drawing.Point(55, 483)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(104, 21)
            Me.comboBox1.TabIndex = 38
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(13, 512)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(35, 13)
            Me.label2.TabIndex = 39
            Me.label2.Text = "Width"
            '
            'comboBox2
            '
            Me.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
            Me.comboBox2.Location = New System.Drawing.Point(55, 512)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(104, 21)
            Me.comboBox2.TabIndex = 37
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Location = New System.Drawing.Point(13, 541)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(38, 13)
            Me.label3.TabIndex = 40
            Me.label3.Text = "Height"
            '
            'comboBox3
            '
            Me.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
            Me.comboBox3.Location = New System.Drawing.Point(55, 541)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(104, 21)
            Me.comboBox3.TabIndex = 41
            '
            'label25
            '
            Me.label25.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label25.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label25.Image = CType(resources.GetObject("label25.Image"), System.Drawing.Image)
            Me.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label25.Location = New System.Drawing.Point(9, 404)
            Me.label25.Name = "label25"
            Me.label25.Size = New System.Drawing.Size(117, 24)
            Me.label25.TabIndex = 72
            Me.label25.Text = "Customize Axes"
            Me.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox4.Location = New System.Drawing.Point(559, 259)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(107, 18)
            Me.checkBox4.TabIndex = 78
            Me.checkBox4.Text = "Opposed Y-Axis"
            '
            'checkBox5
            '
            Me.checkBox5.AutoSize = True
            Me.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox5.Location = New System.Drawing.Point(559, 232)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(107, 18)
            Me.checkBox5.TabIndex = 77
            Me.checkBox5.Text = "Opposed X-Axis"
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(558, 158)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(100, 1)
            Me.label4.TabIndex = 76
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.Location = New System.Drawing.Point(559, 174)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(91, 18)
            Me.checkBox2.TabIndex = 75
            Me.checkBox2.Text = "Invert X Axis"
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox3.Location = New System.Drawing.Point(559, 203)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(91, 18)
            Me.checkBox3.TabIndex = 73
            Me.checkBox3.Text = "Invert Y Axis"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Location = New System.Drawing.Point(558, 141)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(83, 14)
            Me.label5.TabIndex = 74
            Me.label5.Text = "Axes Position"
            '
            'comboBox5
            '
            Me.comboBox5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox5.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
            Me.comboBox5.Location = New System.Drawing.Point(217, 512)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(104, 21)
            Me.comboBox5.TabIndex = 84
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label11.Location = New System.Drawing.Point(179, 512)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(35, 13)
            Me.label11.TabIndex = 82
            Me.label11.Text = "Width"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label12.Location = New System.Drawing.Point(179, 483)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(30, 13)
            Me.label12.TabIndex = 81
            Me.label12.Text = "Style"
            '
            'comboBox6
            '
            Me.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox6.Items.AddRange(New Object() {"Solid", "Dash", "Dot", "DashDot", "DashDotDot", "Custom"})
            Me.comboBox6.Location = New System.Drawing.Point(217, 483)
            Me.comboBox6.Name = "comboBox6"
            Me.comboBox6.Size = New System.Drawing.Size(104, 21)
            Me.comboBox6.TabIndex = 91
            '
            'panel3
            '
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.textBox3)
            Me.panel3.Controls.Add(Me.colorPickerButton3)
            Me.panel3.Location = New System.Drawing.Point(55, 569)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(41, 21)
            Me.panel3.TabIndex = 94
            '
            'textBox3
            '
            Me.textBox3.BackColor = System.Drawing.Color.Black
            Me.textBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox3.Location = New System.Drawing.Point(0, 0)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ReadOnly = True
            Me.textBox3.Size = New System.Drawing.Size(22, 20)
            Me.textBox3.TabIndex = 11
            '
            'colorPickerButton3
            '
            Me.colorPickerButton3.BackColor = System.Drawing.Color.Black
            Me.colorPickerButton3.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton3.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton3.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton3.Name = "colorPickerButton3"
            Me.colorPickerButton3.SelectedAsBackcolor = True
            Me.colorPickerButton3.SelectedColor = System.Drawing.Color.Black
            Me.colorPickerButton3.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton3.TabIndex = 14
            Me.colorPickerButton3.Text = "..."
            Me.colorPickerButton3.UseVisualStyleBackColor = False
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.textBox2)
            Me.panel2.Controls.Add(Me.colorPickerButton2)
            Me.panel2.Location = New System.Drawing.Point(217, 541)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(41, 21)
            Me.panel2.TabIndex = 97
            '
            'textBox2
            '
            Me.textBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox2.Location = New System.Drawing.Point(0, 0)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(22, 20)
            Me.textBox2.TabIndex = 11
            '
            'colorPickerButton2
            '
            Me.colorPickerButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton2.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton2.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton2.Name = "colorPickerButton2"
            Me.colorPickerButton2.SelectedAsBackcolor = True
            Me.colorPickerButton2.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.colorPickerButton2.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton2.TabIndex = 14
            Me.colorPickerButton2.Text = "..."
            Me.colorPickerButton2.UseVisualStyleBackColor = False
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label9.Location = New System.Drawing.Point(13, 571)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(31, 13)
            Me.label9.TabIndex = 99
            Me.label9.Text = "Color"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.BackColor = System.Drawing.Color.Transparent
            Me.label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label8.Location = New System.Drawing.Point(12, 450)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(31, 14)
            Me.label8.TabIndex = 100
            Me.label8.Text = "Line"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.BackColor = System.Drawing.Color.Transparent
            Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label10.Location = New System.Drawing.Point(179, 450)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(91, 14)
            Me.label10.TabIndex = 101
            Me.label10.Text = "Major Grid Line"
            '
            'label22
            '
            Me.label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label22.Location = New System.Drawing.Point(18, 467)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(138, 1)
            Me.label22.TabIndex = 102
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label6.Location = New System.Drawing.Point(179, 541)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(31, 13)
            Me.label6.TabIndex = 103
            Me.label6.Text = "Color"
            '
            'label7
            '
            Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label7.Location = New System.Drawing.Point(183, 467)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(134, 1)
            Me.label7.TabIndex = 104
            '
            'checkBoxXAxis
            '
            Me.checkBoxXAxis.AutoSize = True
            Me.checkBoxXAxis.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBoxXAxis.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxXAxis.Location = New System.Drawing.Point(132, 412)
            Me.checkBoxXAxis.Name = "checkBoxXAxis"
            Me.checkBoxXAxis.Size = New System.Drawing.Size(61, 18)
            Me.checkBoxXAxis.TabIndex = 109
            Me.checkBoxXAxis.Text = "X Axis"
            '
            'checkBoxYAxis
            '
            Me.checkBoxYAxis.AutoSize = True
            Me.checkBoxYAxis.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBoxYAxis.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxYAxis.Location = New System.Drawing.Point(190, 412)
            Me.checkBoxYAxis.Name = "checkBoxYAxis"
            Me.checkBoxYAxis.Size = New System.Drawing.Size(61, 18)
            Me.checkBoxYAxis.TabIndex = 110
            Me.checkBoxYAxis.Text = "Y Axis"
            '
            'label13
            '
            Me.label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label13.Location = New System.Drawing.Point(342, 465)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(134, 1)
            Me.label13.TabIndex = 112
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.BackColor = System.Drawing.Color.Transparent
            Me.label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label14.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label14.Location = New System.Drawing.Point(338, 448)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(92, 14)
            Me.label14.TabIndex = 111
            Me.label14.Text = "Minor Grid Line"
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label15.Location = New System.Drawing.Point(342, 567)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(31, 13)
            Me.label15.TabIndex = 117
            Me.label15.Text = "Color"
            '
            'comboBox4
            '
            Me.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox4.Items.AddRange(New Object() {"Solid", "Dash", "Dot", "DashDot", "DashDotDot", "Custom"})
            Me.comboBox4.Location = New System.Drawing.Point(380, 507)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(104, 21)
            Me.comboBox4.TabIndex = 116
            '
            'comboBox7
            '
            Me.comboBox7.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox7.Items.AddRange(New Object() {"1", "2", "3"})
            Me.comboBox7.Location = New System.Drawing.Point(380, 538)
            Me.comboBox7.Name = "comboBox7"
            Me.comboBox7.Size = New System.Drawing.Size(104, 21)
            Me.comboBox7.TabIndex = 115
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label16.Location = New System.Drawing.Point(342, 538)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(35, 13)
            Me.label16.TabIndex = 114
            Me.label16.Text = "Width"
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label17.Location = New System.Drawing.Point(342, 510)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(30, 13)
            Me.label17.TabIndex = 113
            Me.label17.Text = "Style"
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.textBox1)
            Me.panel1.Controls.Add(Me.colorPickerButton1)
            Me.panel1.Location = New System.Drawing.Point(380, 565)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(41, 21)
            Me.panel1.TabIndex = 118
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.DarkGray
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(22, 20)
            Me.textBox1.TabIndex = 11
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
            Me.colorPickerButton1.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.Black
            Me.colorPickerButton1.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton1.TabIndex = 14
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(341, 483)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(55, 17)
            Me.checkBox1.TabIndex = 119
            Me.checkBox1.Text = "X Axis"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'checkBox6
            '
            Me.checkBox6.AutoSize = True
            Me.checkBox6.Checked = True
            Me.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox6.Location = New System.Drawing.Point(405, 483)
            Me.checkBox6.Name = "checkBox6"
            Me.checkBox6.Size = New System.Drawing.Size(55, 17)
            Me.checkBox6.TabIndex = 120
            Me.checkBox6.Text = "Y Axis"
            Me.checkBox6.UseVisualStyleBackColor = True
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.ForeColor = System.Drawing.Color.Black
            Me.label23.Location = New System.Drawing.Point(496, 533)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(51, 13)
            Me.label23.TabIndex = 145
            Me.label23.Text = "Font Size"
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.ForeColor = System.Drawing.Color.Black
            Me.label35.Location = New System.Drawing.Point(496, 560)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(55, 13)
            Me.label35.TabIndex = 139
            Me.label35.Text = "Font Color"
            '
            'label24
            '
            Me.label24.AutoSize = True
            Me.label24.ForeColor = System.Drawing.Color.Black
            Me.label24.Location = New System.Drawing.Point(496, 479)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(57, 13)
            Me.label24.TabIndex = 141
            Me.label24.Text = "Font family"
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.ForeColor = System.Drawing.Color.Black
            Me.label26.Location = New System.Drawing.Point(496, 506)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(54, 13)
            Me.label26.TabIndex = 144
            Me.label26.Text = "Font Style"
            '
            'comboBox_FontStyle
            '
            Me.comboBox_FontStyle.DropDownWidth = 200
            Me.comboBox_FontStyle.FormattingEnabled = True
            Me.comboBox_FontStyle.Location = New System.Drawing.Point(560, 506)
            Me.comboBox_FontStyle.Name = "comboBox_FontStyle"
            Me.comboBox_FontStyle.Size = New System.Drawing.Size(100, 21)
            Me.comboBox_FontStyle.TabIndex = 142
            '
            'panel9
            '
            Me.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel9.Controls.Add(Me.textBox_TextColor)
            Me.panel9.Controls.Add(Me.colorPicker_TextColor)
            Me.panel9.Location = New System.Drawing.Point(561, 562)
            Me.panel9.Name = "panel9"
            Me.panel9.Size = New System.Drawing.Size(41, 21)
            Me.panel9.TabIndex = 138
            '
            'textBox_TextColor
            '
            Me.textBox_TextColor.BackColor = System.Drawing.Color.Black
            Me.textBox_TextColor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox_TextColor.Location = New System.Drawing.Point(0, 0)
            Me.textBox_TextColor.Name = "textBox_TextColor"
            Me.textBox_TextColor.ReadOnly = True
            Me.textBox_TextColor.Size = New System.Drawing.Size(22, 20)
            Me.textBox_TextColor.TabIndex = 11
            '
            'colorPicker_TextColor
            '
            Me.colorPicker_TextColor.BackColor = System.Drawing.Color.Black
            Me.colorPicker_TextColor.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPicker_TextColor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPicker_TextColor.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPicker_TextColor.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPicker_TextColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPicker_TextColor.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPicker_TextColor.Image = CType(resources.GetObject("colorPicker_TextColor.Image"), System.Drawing.Image)
            Me.colorPicker_TextColor.Location = New System.Drawing.Point(22, 0)
            Me.colorPicker_TextColor.Name = "colorPicker_TextColor"
            Me.colorPicker_TextColor.SelectedAsBackcolor = True
            Me.colorPicker_TextColor.SelectedColor = System.Drawing.Color.Black
            Me.colorPicker_TextColor.Size = New System.Drawing.Size(17, 19)
            Me.colorPicker_TextColor.TabIndex = 14
            Me.colorPicker_TextColor.Text = "..."
            Me.colorPicker_TextColor.UseVisualStyleBackColor = False
            '
            'numericUpDown_FontSize
            '
            Me.numericUpDown_FontSize.Location = New System.Drawing.Point(560, 533)
            Me.numericUpDown_FontSize.Maximum = New Decimal(New Integer() {14, 0, 0, 0})
            Me.numericUpDown_FontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
            Me.numericUpDown_FontSize.Name = "numericUpDown_FontSize"
            Me.numericUpDown_FontSize.Size = New System.Drawing.Size(38, 20)
            Me.numericUpDown_FontSize.TabIndex = 143
            Me.numericUpDown_FontSize.Value = New Decimal(New Integer() {8, 0, 0, 0})
            '
            'comboBox_Fontfamily
            '
            Me.comboBox_Fontfamily.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox_Fontfamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_Fontfamily.DropDownWidth = 200
            Me.comboBox_Fontfamily.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox_Fontfamily.Items.AddRange(New Object() {"Agency FB", "Arial", "Book Antiqua", "Bookman Old Style", "Bradley Hand ITC", "Courier New", "Calibri", "Curlz MT", "Estrangelo Edessa", "Felix Titling", "Gautami", "Gill Sans MT Ext Condensed Bold", "Impact", "Microsoft Sans Serif", "MS Outlook", "Pristina", "Raavi", "Symbol", "Tahoma", "Times New Roman", "Verdana"})
            Me.comboBox_Fontfamily.Location = New System.Drawing.Point(561, 479)
            Me.comboBox_Fontfamily.Name = "comboBox_Fontfamily"
            Me.comboBox_Fontfamily.Size = New System.Drawing.Size(100, 21)
            Me.comboBox_Fontfamily.TabIndex = 140
            '
            'label18
            '
            Me.label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label18.Location = New System.Drawing.Point(496, 464)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(165, 1)
            Me.label18.TabIndex = 137
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.BackColor = System.Drawing.Color.Transparent
            Me.label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label19.Location = New System.Drawing.Point(496, 447)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(62, 14)
            Me.label19.TabIndex = 136
            Me.label19.Text = "Axes Title"
            '
            'checkBox7
            '
            Me.checkBox7.AutoSize = True
            Me.checkBox7.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox7.Location = New System.Drawing.Point(559, 319)
            Me.checkBox7.Name = "checkBox7"
            Me.checkBox7.Size = New System.Drawing.Size(121, 18)
            Me.checkBox7.TabIndex = 147
            Me.checkBox7.Text = "Inside Y-Axis Label"
            '
            'checkBox8
            '
            Me.checkBox8.AutoSize = True
            Me.checkBox8.Cursor = System.Windows.Forms.Cursors.Hand
            Me.checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox8.Location = New System.Drawing.Point(559, 292)
            Me.checkBox8.Name = "checkBox8"
            Me.checkBox8.Size = New System.Drawing.Size(121, 18)
            Me.checkBox8.TabIndex = 146
            Me.checkBox8.Text = "Inside X-Axis Label"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(671, 618)
            Me.Controls.Add(Me.checkBox7)
            Me.Controls.Add(Me.checkBox8)
            Me.Controls.Add(Me.label23)
            Me.Controls.Add(Me.label35)
            Me.Controls.Add(Me.label24)
            Me.Controls.Add(Me.label26)
            Me.Controls.Add(Me.comboBox_FontStyle)
            Me.Controls.Add(Me.panel9)
            Me.Controls.Add(Me.numericUpDown_FontSize)
            Me.Controls.Add(Me.comboBox_Fontfamily)
            Me.Controls.Add(Me.label18)
            Me.Controls.Add(Me.label19)
            Me.Controls.Add(Me.checkBox6)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.label15)
            Me.Controls.Add(Me.comboBox4)
            Me.Controls.Add(Me.comboBox7)
            Me.Controls.Add(Me.label16)
            Me.Controls.Add(Me.label17)
            Me.Controls.Add(Me.label13)
            Me.Controls.Add(Me.label14)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.checkBoxYAxis)
            Me.Controls.Add(Me.checkBoxXAxis)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.label22)
            Me.Controls.Add(Me.label10)
            Me.Controls.Add(Me.label8)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.comboBox6)
            Me.Controls.Add(Me.comboBox5)
            Me.Controls.Add(Me.label11)
            Me.Controls.Add(Me.label12)
            Me.Controls.Add(Me.checkBox4)
            Me.Controls.Add(Me.checkBox5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.checkBox2)
            Me.Controls.Add(Me.checkBox3)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label25)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.comboBox2)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.comboBox3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Axis Customization"
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel9.ResumeLayout(False)
            Me.panel9.PerformLayout()
            CType(Me.numericUpDown_FontSize, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private label1 As System.Windows.Forms.Label
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
		Private label3 As System.Windows.Forms.Label
		Private WithEvents comboBox3 As System.Windows.Forms.ComboBox
		Private label25 As System.Windows.Forms.Label
		Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
		Private label4 As System.Windows.Forms.Label
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
		Private label5 As System.Windows.Forms.Label
		Private WithEvents comboBox5 As System.Windows.Forms.ComboBox
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private WithEvents comboBox6 As System.Windows.Forms.ComboBox
		Private panel3 As System.Windows.Forms.Panel
		Private textBox3 As System.Windows.Forms.TextBox
		Private WithEvents colorPickerButton3 As Syncfusion.Windows.Forms.ColorPickerButton
		Private panel2 As System.Windows.Forms.Panel
		Private textBox2 As System.Windows.Forms.TextBox
		Private WithEvents colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label9 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label22 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private WithEvents checkBoxXAxis As System.Windows.Forms.CheckBox
		Private WithEvents checkBoxYAxis As System.Windows.Forms.CheckBox
		Private label13 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private WithEvents comboBox4 As System.Windows.Forms.ComboBox
		Private WithEvents comboBox7 As System.Windows.Forms.ComboBox
		Private label16 As System.Windows.Forms.Label
		Private label17 As System.Windows.Forms.Label
		Private panel1 As System.Windows.Forms.Panel
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox6 As System.Windows.Forms.CheckBox
        Private WithEvents label23 As System.Windows.Forms.Label
        Private WithEvents label35 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents label26 As System.Windows.Forms.Label
        Private WithEvents comboBox_FontStyle As System.Windows.Forms.ComboBox
        Private WithEvents panel9 As System.Windows.Forms.Panel
        Private WithEvents textBox_TextColor As System.Windows.Forms.TextBox
        Private WithEvents colorPicker_TextColor As Syncfusion.Windows.Forms.ColorPickerButton
        Private WithEvents numericUpDown_FontSize As System.Windows.Forms.NumericUpDown
        Private WithEvents comboBox_Fontfamily As System.Windows.Forms.ComboBox
        Private WithEvents label18 As System.Windows.Forms.Label
        Private WithEvents label19 As System.Windows.Forms.Label
        Private WithEvents checkBox7 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox8 As System.Windows.Forms.CheckBox
     
	End Class
End Namespace

