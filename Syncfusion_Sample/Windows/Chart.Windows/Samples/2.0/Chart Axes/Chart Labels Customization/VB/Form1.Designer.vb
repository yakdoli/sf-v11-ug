Imports Microsoft.VisualBasic
Imports System
Namespace ChartLabels_2005
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.tabControl1 = New System.Windows.Forms.TabControl
            Me.tabPage1 = New System.Windows.Forms.TabPage
            Me.label19 = New System.Windows.Forms.Label
            Me.label23 = New System.Windows.Forms.Label
            Me.label18 = New System.Windows.Forms.Label
            Me.label15 = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.label22 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.comboBox_StringAlign = New System.Windows.Forms.ComboBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label9 = New System.Windows.Forms.Label
            Me.comboBox_DateFormat = New System.Windows.Forms.ComboBox
            Me.label33 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.comboBox_datesHidden = New System.Windows.Forms.ComboBox
            Me.label35 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.comboBox_FontStyle = New System.Windows.Forms.ComboBox
            Me.comboBox_DoubleFormat = New System.Windows.Forms.ComboBox
            Me.panel9 = New System.Windows.Forms.Panel
            Me.textBox_TextColor = New System.Windows.Forms.TextBox
            Me.colorPicker_TextColor = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.numericUpDown_FontSize = New System.Windows.Forms.NumericUpDown
            Me.comboBox_Fontfamily = New System.Windows.Forms.ComboBox
            Me.tabPage2 = New System.Windows.Forms.TabPage
            Me.label17 = New System.Windows.Forms.Label
            Me.label16 = New System.Windows.Forms.Label
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.radioButton_ChartFormatAxisLabel = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.tabPage3 = New System.Windows.Forms.TabPage
            Me.label36 = New System.Windows.Forms.Label
            Me.label34 = New System.Windows.Forms.Label
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label31 = New System.Windows.Forms.Label
            Me.comboBox_EdgeDrawingMode = New System.Windows.Forms.ComboBox
            Me.label28 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.comboBox_LabelIntersectAction = New System.Windows.Forms.ComboBox
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.tabControl1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel9.SuspendLayout()
            CType(Me.numericUpDown_FontSize, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage2.SuspendLayout()
            Me.tabPage3.SuspendLayout()
            Me.SuspendLayout()
            '
            'tabControl1
            '
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Controls.Add(Me.tabPage3)
            Me.tabControl1.Location = New System.Drawing.Point(0, 352)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(544, 257)
            Me.tabControl1.TabIndex = 79
            '
            'tabPage1
            '
            Me.tabPage1.Controls.Add(Me.label19)
            Me.tabPage1.Controls.Add(Me.label23)
            Me.tabPage1.Controls.Add(Me.label18)
            Me.tabPage1.Controls.Add(Me.label15)
            Me.tabPage1.Controls.Add(Me.label14)
            Me.tabPage1.Controls.Add(Me.label1)
            Me.tabPage1.Controls.Add(Me.label12)
            Me.tabPage1.Controls.Add(Me.label22)
            Me.tabPage1.Controls.Add(Me.label13)
            Me.tabPage1.Controls.Add(Me.label3)
            Me.tabPage1.Controls.Add(Me.label4)
            Me.tabPage1.Controls.Add(Me.numericUpDown1)
            Me.tabPage1.Controls.Add(Me.comboBox_StringAlign)
            Me.tabPage1.Controls.Add(Me.checkBox1)
            Me.tabPage1.Controls.Add(Me.label9)
            Me.tabPage1.Controls.Add(Me.comboBox_DateFormat)
            Me.tabPage1.Controls.Add(Me.label33)
            Me.tabPage1.Controls.Add(Me.label10)
            Me.tabPage1.Controls.Add(Me.label7)
            Me.tabPage1.Controls.Add(Me.comboBox_datesHidden)
            Me.tabPage1.Controls.Add(Me.label35)
            Me.tabPage1.Controls.Add(Me.label5)
            Me.tabPage1.Controls.Add(Me.label6)
            Me.tabPage1.Controls.Add(Me.label11)
            Me.tabPage1.Controls.Add(Me.comboBox_FontStyle)
            Me.tabPage1.Controls.Add(Me.comboBox_DoubleFormat)
            Me.tabPage1.Controls.Add(Me.panel9)
            Me.tabPage1.Controls.Add(Me.numericUpDown_FontSize)
            Me.tabPage1.Controls.Add(Me.comboBox_Fontfamily)
            Me.tabPage1.Location = New System.Drawing.Point(4, 22)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage1.Size = New System.Drawing.Size(536, 231)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "Text Formatting"
            Me.tabPage1.UseVisualStyleBackColor = True
            '
            'label19
            '
            Me.label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label19.Location = New System.Drawing.Point(9, 31)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(120, 1)
            Me.label19.TabIndex = 114
            '
            'label23
            '
            Me.label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label23.Location = New System.Drawing.Point(154, 31)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(235, 1)
            Me.label23.TabIndex = 113
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label18.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label18.Location = New System.Drawing.Point(7, 43)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(48, 13)
            Me.label18.TabIndex = 112
            Me.label18.Text = "Format"
            Me.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label15.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label15.Location = New System.Drawing.Point(346, 100)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(87, 13)
            Me.label15.TabIndex = 111
            Me.label15.Text = "Label Settings"
            Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label14.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label14.Location = New System.Drawing.Point(153, 100)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(82, 13)
            Me.label14.TabIndex = 110
            Me.label14.Text = "Font Settings"
            Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(153, 45)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(48, 13)
            Me.label1.TabIndex = 109
            Me.label1.Text = "Format"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label12
            '
            Me.label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label12.Image = CType(resources.GetObject("label12.Image"), System.Drawing.Image)
            Me.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label12.Location = New System.Drawing.Point(151, 9)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(62, 18)
            Me.label12.TabIndex = 108
            Me.label12.Text = "X Axis"
            Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label22
            '
            Me.label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label22.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label22.Image = CType(resources.GetObject("label22.Image"), System.Drawing.Image)
            Me.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label22.Location = New System.Drawing.Point(7, 11)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(58, 16)
            Me.label22.TabIndex = 107
            Me.label22.Text = "Y Axis"
            Me.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label13
            '
            Me.label13.Image = CType(resources.GetObject("label13.Image"), System.Drawing.Image)
            Me.label13.Location = New System.Drawing.Point(473, 178)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(20, 20)
            Me.label13.TabIndex = 106
            Me.toolTip1.SetToolTip(Me.label13, "Takes effect when the Intersect action  is set as none")
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.ForeColor = System.Drawing.Color.Black
            Me.label3.Location = New System.Drawing.Point(346, 124)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(82, 13)
            Me.label3.TabIndex = 101
            Me.label3.Text = "Label Alignment"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.ForeColor = System.Drawing.Color.Black
            Me.label4.Location = New System.Drawing.Point(346, 178)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(69, 13)
            Me.label4.TabIndex = 105
            Me.label4.Text = "Rotate Angle"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Increment = New Decimal(New Integer() {225, 0, 0, 65536})
            Me.numericUpDown1.Location = New System.Drawing.Point(429, 178)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.ReadOnly = True
            Me.numericUpDown1.Size = New System.Drawing.Size(38, 20)
            Me.numericUpDown1.TabIndex = 104
            '
            'comboBox_StringAlign
            '
            Me.comboBox_StringAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_StringAlign.DropDownWidth = 100
            Me.comboBox_StringAlign.FormattingEnabled = True
            Me.comboBox_StringAlign.Items.AddRange(New Object() {"Center", "Near", "Far"})
            Me.comboBox_StringAlign.Location = New System.Drawing.Point(429, 124)
            Me.comboBox_StringAlign.Name = "comboBox_StringAlign"
            Me.comboBox_StringAlign.Size = New System.Drawing.Size(100, 21)
            Me.comboBox_StringAlign.TabIndex = 100
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(429, 151)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(15, 14)
            Me.checkBox1.TabIndex = 103
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.ForeColor = System.Drawing.Color.Black
            Me.label9.Location = New System.Drawing.Point(346, 151)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(68, 13)
            Me.label9.TabIndex = 102
            Me.label9.Text = "Label Rotate"
            '
            'comboBox_DateFormat
            '
            Me.comboBox_DateFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_DateFormat.DropDownWidth = 200
            Me.comboBox_DateFormat.FormattingEnabled = True
            Me.comboBox_DateFormat.Items.AddRange(New Object() {"3/14/2001", "Wednesday, March 14, 2001", "3/14", "3/14/01", "03/14/01", "14-Mar", "14-Mar-01", "Mar-01", "March -01", "March 14,2001", "M", "M-01", "3/14/2001", "14-Mar-2001", "Mar", "Tue", "Tuesday", "Mar/12,Wed"})
            Me.comboBox_DateFormat.Location = New System.Drawing.Point(218, 62)
            Me.comboBox_DateFormat.Name = "comboBox_DateFormat"
            Me.comboBox_DateFormat.Size = New System.Drawing.Size(132, 21)
            Me.comboBox_DateFormat.TabIndex = 73
            '
            'label33
            '
            Me.label33.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label33.Location = New System.Drawing.Point(143, 15)
            Me.label33.Name = "label33"
            Me.label33.Size = New System.Drawing.Size(1, 208)
            Me.label33.TabIndex = 87
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.ForeColor = System.Drawing.Color.Black
            Me.label10.Location = New System.Drawing.Point(153, 62)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(53, 13)
            Me.label10.TabIndex = 81
            Me.label10.Text = "DateTime"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.ForeColor = System.Drawing.Color.Black
            Me.label7.Location = New System.Drawing.Point(153, 178)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(51, 13)
            Me.label7.TabIndex = 84
            Me.label7.Text = "Font Size"
            '
            'comboBox_datesHidden
            '
            Me.comboBox_datesHidden.FormattingEnabled = True
            Me.comboBox_datesHidden.Items.AddRange(New Object() {"M/d/yyyy", "dddd, MMMM dd, yyyy", "M/d", "M/d/yy", "MM/dd/yy", "d-MMM", "d-MMM-yy", "MMM-yy", "MMMM-yy", "MMMM d, yyyy", "MMMMM", "MMMMM-yy", "M/d/yyyy", "d-MMM-yyyy", "MMM", "ddd", "dddd", "MMM/dd, ddd"})
            Me.comboBox_datesHidden.Location = New System.Drawing.Point(255, 62)
            Me.comboBox_datesHidden.Name = "comboBox_datesHidden"
            Me.comboBox_datesHidden.Size = New System.Drawing.Size(42, 21)
            Me.comboBox_datesHidden.TabIndex = 92
            Me.comboBox_datesHidden.Visible = False
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.ForeColor = System.Drawing.Color.Black
            Me.label35.Location = New System.Drawing.Point(153, 205)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(55, 13)
            Me.label35.TabIndex = 77
            Me.label35.Text = "Font Color"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.ForeColor = System.Drawing.Color.Black
            Me.label5.Location = New System.Drawing.Point(153, 124)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(57, 13)
            Me.label5.TabIndex = 80
            Me.label5.Text = "Font family"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.ForeColor = System.Drawing.Color.Black
            Me.label6.Location = New System.Drawing.Point(153, 151)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(54, 13)
            Me.label6.TabIndex = 83
            Me.label6.Text = "Font Style"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.ForeColor = System.Drawing.Color.Black
            Me.label11.Location = New System.Drawing.Point(6, 62)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(41, 13)
            Me.label11.TabIndex = 83
            Me.label11.Text = "Double"
            '
            'comboBox_FontStyle
            '
            Me.comboBox_FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_FontStyle.DropDownWidth = 100
            Me.comboBox_FontStyle.FormattingEnabled = True
            Me.comboBox_FontStyle.Location = New System.Drawing.Point(217, 151)
            Me.comboBox_FontStyle.Name = "comboBox_FontStyle"
            Me.comboBox_FontStyle.Size = New System.Drawing.Size(100, 21)
            Me.comboBox_FontStyle.TabIndex = 81
            '
            'comboBox_DoubleFormat
            '
            Me.comboBox_DoubleFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_DoubleFormat.FormattingEnabled = True
            Me.comboBox_DoubleFormat.Items.AddRange(New Object() {"1234", "1234.00", "$1234.00", "1234.000", "$1234.000"})
            Me.comboBox_DoubleFormat.Location = New System.Drawing.Point(49, 62)
            Me.comboBox_DoubleFormat.Name = "comboBox_DoubleFormat"
            Me.comboBox_DoubleFormat.Size = New System.Drawing.Size(81, 21)
            Me.comboBox_DoubleFormat.TabIndex = 82
            '
            'panel9
            '
            Me.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel9.Controls.Add(Me.textBox_TextColor)
            Me.panel9.Controls.Add(Me.colorPicker_TextColor)
            Me.panel9.Location = New System.Drawing.Point(215, 205)
            Me.panel9.Name = "panel9"
            Me.panel9.Size = New System.Drawing.Size(41, 21)
            Me.panel9.TabIndex = 76
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
            Me.colorPicker_TextColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPicker_TextColor.Size = New System.Drawing.Size(17, 19)
            Me.colorPicker_TextColor.TabIndex = 14
            Me.colorPicker_TextColor.Text = "..."
            Me.colorPicker_TextColor.UseVisualStyleBackColor = False
            '
            'numericUpDown_FontSize
            '
            Me.numericUpDown_FontSize.Location = New System.Drawing.Point(217, 178)
            Me.numericUpDown_FontSize.Maximum = New Decimal(New Integer() {14, 0, 0, 0})
            Me.numericUpDown_FontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
            Me.numericUpDown_FontSize.Name = "numericUpDown_FontSize"
            Me.numericUpDown_FontSize.ReadOnly = True
            Me.numericUpDown_FontSize.Size = New System.Drawing.Size(38, 20)
            Me.numericUpDown_FontSize.TabIndex = 82
            Me.numericUpDown_FontSize.Value = New Decimal(New Integer() {9, 0, 0, 0})
            '
            'comboBox_Fontfamily
            '
            Me.comboBox_Fontfamily.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox_Fontfamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_Fontfamily.DropDownWidth = 200
            Me.comboBox_Fontfamily.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox_Fontfamily.Items.AddRange(New Object() {"Agency FB", "Arial", "Book Antiqua", "Bookman Old Style", "Bradley Hand ITC", "Courier New", "Calibri", "Curlz MT", "Estrangelo Edessa", "Felix Titling", "Gautami", "Gill Sans MT Ext Condensed Bold", "Impact", "Microsoft Sans Serif", "MS Outlook", "Pristina", "Raavi", "Symbol", "Tahoma", "Times New Roman", "Verdana"})
            Me.comboBox_Fontfamily.Location = New System.Drawing.Point(218, 124)
            Me.comboBox_Fontfamily.Name = "comboBox_Fontfamily"
            Me.comboBox_Fontfamily.Size = New System.Drawing.Size(100, 21)
            Me.comboBox_Fontfamily.TabIndex = 79
            '
            'tabPage2
            '
            Me.tabPage2.Controls.Add(Me.label17)
            Me.tabPage2.Controls.Add(Me.label16)
            Me.tabPage2.Controls.Add(Me.textBox1)
            Me.tabPage2.Controls.Add(Me.radioButton_ChartFormatAxisLabel)
            Me.tabPage2.Controls.Add(Me.radioButton1)
            Me.tabPage2.Location = New System.Drawing.Point(4, 22)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage2.Size = New System.Drawing.Size(536, 231)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "Custom Label Text"
            Me.tabPage2.UseVisualStyleBackColor = True
            '
            'label17
            '
            Me.label17.ForeColor = System.Drawing.Color.Black
            Me.label17.Location = New System.Drawing.Point(39, 206)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(492, 21)
            Me.label17.TabIndex = 111
            Me.label17.Text = "Select this option to restrict the number of labels rendered in the axis and also" & _
                " customize it's formatting"
            '
            'label16
            '
            Me.label16.ForeColor = System.Drawing.Color.Black
            Me.label16.Location = New System.Drawing.Point(39, 37)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(477, 34)
            Me.label16.TabIndex = 110
            Me.label16.Text = "Select this option to customize the label-text for the automatically generated in" & _
                "tervals using the ChartFormatAxisLabel event"
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(70, 71)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(106, 99)
            Me.textBox1.TabIndex = 2
            Me.textBox1.Text = "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sale Starts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sale Ends" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'radioButton_ChartFormatAxisLabel
            '
            Me.radioButton_ChartFormatAxisLabel.AutoSize = True
            Me.radioButton_ChartFormatAxisLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.radioButton_ChartFormatAxisLabel.Location = New System.Drawing.Point(39, 17)
            Me.radioButton_ChartFormatAxisLabel.Name = "radioButton_ChartFormatAxisLabel"
            Me.radioButton_ChartFormatAxisLabel.Size = New System.Drawing.Size(142, 17)
            Me.radioButton_ChartFormatAxisLabel.TabIndex = 1
            Me.radioButton_ChartFormatAxisLabel.TabStop = True
            Me.radioButton_ChartFormatAxisLabel.Text = "For Default Intervals"
            Me.radioButton_ChartFormatAxisLabel.UseVisualStyleBackColor = True
            '
            'radioButton1
            '
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.radioButton1.Location = New System.Drawing.Point(39, 186)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(144, 17)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "For Custom Intervals"
            Me.radioButton1.UseVisualStyleBackColor = True
            '
            'tabPage3
            '
            Me.tabPage3.Controls.Add(Me.label36)
            Me.tabPage3.Controls.Add(Me.label34)
            Me.tabPage3.Controls.Add(Me.checkBox2)
            Me.tabPage3.Controls.Add(Me.label2)
            Me.tabPage3.Controls.Add(Me.label31)
            Me.tabPage3.Controls.Add(Me.comboBox_EdgeDrawingMode)
            Me.tabPage3.Controls.Add(Me.label28)
            Me.tabPage3.Controls.Add(Me.label8)
            Me.tabPage3.Controls.Add(Me.comboBox_LabelIntersectAction)
            Me.tabPage3.Location = New System.Drawing.Point(4, 22)
            Me.tabPage3.Name = "tabPage3"
            Me.tabPage3.Size = New System.Drawing.Size(536, 231)
            Me.tabPage3.TabIndex = 2
            Me.tabPage3.Text = "Intersecting Labels"
            Me.tabPage3.UseVisualStyleBackColor = True
            '
            'label36
            '
            Me.label36.Image = CType(resources.GetObject("label36.Image"), System.Drawing.Image)
            Me.label36.Location = New System.Drawing.Point(286, 118)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(20, 20)
            Me.label36.TabIndex = 107
            Me.toolTip1.SetToolTip(Me.label36, resources.GetString("label36.ToolTip"))
            '
            'label34
            '
            Me.label34.Image = CType(resources.GetObject("label34.Image"), System.Drawing.Image)
            Me.label34.Location = New System.Drawing.Point(286, 74)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(20, 20)
            Me.label34.TabIndex = 106
            Me.toolTip1.SetToolTip(Me.label34, "Affects the labels that get rendered at the edges of the axis")
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.Location = New System.Drawing.Point(163, 118)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(15, 14)
            Me.checkBox2.TabIndex = 105
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.Location = New System.Drawing.Point(286, 30)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(20, 20)
            Me.label2.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.label2, "Specifies the action to take when labels texts intersect")
            '
            'label31
            '
            Me.label31.AutoSize = True
            Me.label31.ForeColor = System.Drawing.Color.Black
            Me.label31.Location = New System.Drawing.Point(30, 118)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(95, 13)
            Me.label31.TabIndex = 104
            Me.label31.Text = "Hide Partial Labels"
            '
            'comboBox_EdgeDrawingMode
            '
            Me.comboBox_EdgeDrawingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_EdgeDrawingMode.FormattingEnabled = True
            Me.comboBox_EdgeDrawingMode.Items.AddRange(New Object() {"Center ", "Shift", "ClippingProtection "})
            Me.comboBox_EdgeDrawingMode.Location = New System.Drawing.Point(163, 73)
            Me.comboBox_EdgeDrawingMode.Name = "comboBox_EdgeDrawingMode"
            Me.comboBox_EdgeDrawingMode.Size = New System.Drawing.Size(118, 21)
            Me.comboBox_EdgeDrawingMode.TabIndex = 103
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.ForeColor = System.Drawing.Color.Black
            Me.label28.Location = New System.Drawing.Point(30, 77)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(129, 13)
            Me.label28.TabIndex = 102
            Me.label28.Text = "EdgeLabelsDrawingMode"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.ForeColor = System.Drawing.Color.Black
            Me.label8.Location = New System.Drawing.Point(30, 36)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(81, 13)
            Me.label8.TabIndex = 99
            Me.label8.Text = "Intersect Action"
            '
            'comboBox_LabelIntersectAction
            '
            Me.comboBox_LabelIntersectAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_LabelIntersectAction.FormattingEnabled = True
            Me.comboBox_LabelIntersectAction.Location = New System.Drawing.Point(163, 28)
            Me.comboBox_LabelIntersectAction.Name = "comboBox_LabelIntersectAction"
            Me.comboBox_LabelIntersectAction.Size = New System.Drawing.Size(118, 21)
            Me.comboBox_LabelIntersectAction.TabIndex = 100
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 25, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Legend.Location = New System.Drawing.Point(206, 49)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside
            Me.chartControl1.Location = New System.Drawing.Point(26, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = "dddd"
            Me.chartControl1.PrimaryXAxis.GridLineType.BackColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryXAxis.HidePartialLabels = True
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = Syncfusion.Windows.Forms.Chart.ChartLabelIntersectAction.MultipleRows
            Me.chartControl1.PrimaryXAxis.Offset = 1
            Me.chartControl1.PrimaryXAxis.Origin = 39358
            Me.chartControl1.PrimaryXAxis.OriginDate = New Date(2007, 10, 3, 0, 0, 0, 0)
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 8, 1)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryXAxis.ValueType = Syncfusion.Windows.Forms.Chart.ChartValueType.DateTime
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 10000, 1000)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.Size = New System.Drawing.Size(496, 321)
            Me.chartControl1.TabIndex = 80
            Me.chartControl1.Text = "Unique Visitors Count"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Unique Visitors Count"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(542, 607)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.tabControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Labels Customization"
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.tabPage1.PerformLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel9.ResumeLayout(False)
            Me.panel9.PerformLayout()
            CType(Me.numericUpDown_FontSize, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage2.ResumeLayout(False)
            Me.tabPage2.PerformLayout()
            Me.tabPage3.ResumeLayout(False)
            Me.tabPage3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private label33 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private comboBox_datesHidden As System.Windows.Forms.ComboBox
		Private label35 As System.Windows.Forms.Label
		Private WithEvents comboBox_DateFormat As System.Windows.Forms.ComboBox
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private WithEvents comboBox_FontStyle As System.Windows.Forms.ComboBox
		Private WithEvents comboBox_DoubleFormat As System.Windows.Forms.ComboBox
		Private panel9 As System.Windows.Forms.Panel
		Private textBox_TextColor As System.Windows.Forms.TextBox
		Private WithEvents colorPicker_TextColor As Syncfusion.Windows.Forms.ColorPickerButton
		Private WithEvents numericUpDown_FontSize As System.Windows.Forms.NumericUpDown
		Private WithEvents comboBox_Fontfamily As System.Windows.Forms.ComboBox
		Private tabPage2 As System.Windows.Forms.TabPage
		Private tabPage3 As System.Windows.Forms.TabPage
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents radioButton_ChartFormatAxisLabel As System.Windows.Forms.RadioButton
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private label36 As System.Windows.Forms.Label
		Private label34 As System.Windows.Forms.Label
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private label2 As System.Windows.Forms.Label
		Private label31 As System.Windows.Forms.Label
		Private WithEvents comboBox_EdgeDrawingMode As System.Windows.Forms.ComboBox
		Private label28 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private WithEvents comboBox_LabelIntersectAction As System.Windows.Forms.ComboBox
		Private label13 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private WithEvents comboBox_StringAlign As System.Windows.Forms.ComboBox
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private label9 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private label22 As System.Windows.Forms.Label
		Private label17 As System.Windows.Forms.Label
		Private label16 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private label23 As System.Windows.Forms.Label
		Private label18 As System.Windows.Forms.Label
		Private label19 As System.Windows.Forms.Label
    End Class
End Namespace

