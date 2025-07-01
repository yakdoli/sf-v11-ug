Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports System.Drawing.Drawing2D
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms

Namespace EssentialChartSample
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private axis1 As ChartAxis = New ChartAxis()
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private panel1 As System.Windows.Forms.Panel
		Private color1 As Color() = New Color(){Color.FromArgb(204, 96, 134), Color.FromArgb(249, 174, 200),Color.FromArgb(204, 96, 134)}
		Private WithEvents comboBox1 As ComboBox
		Private label1 As Label
		Private label2 As Label
		Private WithEvents numericUpDown1 As NumericUpDown
		Private listBox1 As ListBox
		Private label3 As Label
		Private WithEvents button2 As Button
		Private toolTip1 As ToolTip
		Private WithEvents button1 As Button
		Private label5 As Label
		Private label4 As Label
		Private label6 As Label
		Private label7 As Label
		Private textBox1 As TextBox
		Private label10 As Label
		Private WithEvents numericUpDownSpacing As NumericUpDown
		Private label9 As Label
		Private WithEvents comboBoxType As ComboBox
		Private label8 As Label
		Private textBox2 As TextBox
		Private label13 As Label
		Private WithEvents comboBoxStyle As ComboBox
		Private label12 As Label
		Private WithEvents numericUpDownWidth As NumericUpDown
		Private label11 As Label
		Private WithEvents colorPickerButton2 As ColorPickerButton
		Private WithEvents colorPickerButton1 As ColorPickerButton
		Private panel3 As Panel
        Private panel2 As Panel
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label14 As System.Windows.Forms.Label
		Private components As IContainer
		#End Region

		#Region "Main and Constructor"
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
            Dim ChartToolBarSaveItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem
            Dim ChartToolBarCopyItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem
            Dim ChartToolBarPrintItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem
            Dim ChartToolBarPrintPreviewItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem
            Dim ChartToolBarSplitter1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter = New Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter
            Dim ChartToolBarPaletteItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem
            Dim ChartToolBarStyleItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem
            Dim ChartToolBarTypeItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem
            Dim ChartToolBarSeries3DItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem
            Dim ChartToolBarShowLegendItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.Label15 = New System.Windows.Forms.Label
            Me.Label14 = New System.Windows.Forms.Label
            Me.panel3 = New System.Windows.Forms.Panel
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.panel2 = New System.Windows.Forms.Panel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label13 = New System.Windows.Forms.Label
            Me.comboBoxStyle = New System.Windows.Forms.ComboBox
            Me.label12 = New System.Windows.Forms.Label
            Me.numericUpDownWidth = New System.Windows.Forms.NumericUpDown
            Me.label11 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.numericUpDownSpacing = New System.Windows.Forms.NumericUpDown
            Me.label9 = New System.Windows.Forms.Label
            Me.comboBoxType = New System.Windows.Forms.ComboBox
            Me.label8 = New System.Windows.Forms.Label
            Me.button2 = New System.Windows.Forms.Button
            Me.label7 = New System.Windows.Forms.Label
            Me.button1 = New System.Windows.Forms.Button
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label3 = New System.Windows.Forms.Label
            Me.listBox1 = New System.Windows.Forms.ListBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.panel1.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.numericUpDownWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.RosyBrown
            Me.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.RosyBrown
            Me.chartControl1.BorderAppearance.Interior.Width = 1.0!
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent)
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(340, 87)
            Me.chartControl1.Location = New System.Drawing.Point(10, 15)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.Size = New System.Drawing.Size(478, 365)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSaveItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCopyItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintPreviewItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSplitter1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPaletteItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarStyleItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarTypeItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSeries3DItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarShowLegendItem1)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(10, 386)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(135, 18)
            Me.checkBox1.TabIndex = 1
            Me.checkBox1.Text = "Enable Break in Chart"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.Label15)
            Me.panel1.Controls.Add(Me.Label14)
            Me.panel1.Controls.Add(Me.panel3)
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Controls.Add(Me.label13)
            Me.panel1.Controls.Add(Me.comboBoxStyle)
            Me.panel1.Controls.Add(Me.label12)
            Me.panel1.Controls.Add(Me.numericUpDownWidth)
            Me.panel1.Controls.Add(Me.label11)
            Me.panel1.Controls.Add(Me.label10)
            Me.panel1.Controls.Add(Me.numericUpDownSpacing)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Controls.Add(Me.comboBoxType)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Controls.Add(Me.button2)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me.numericUpDown1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.listBox1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 410)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(499, 229)
            Me.panel1.TabIndex = 2
            '
            'Label15
            '
            Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
            Me.Label15.Location = New System.Drawing.Point(468, 187)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(20, 20)
            Me.Label15.TabIndex = 27
            Me.Label15.Text = " "
            Me.toolTip1.SetToolTip(Me.Label15, "Select Range to Remove")
            '
            'Label14
            '
            Me.Label14.Image = CType(resources.GetObject("Label14.Image"), System.Drawing.Image)
            Me.Label14.Location = New System.Drawing.Point(349, 188)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(20, 20)
            Me.Label14.TabIndex = 26
            Me.Label14.Text = " "
            Me.toolTip1.SetToolTip(Me.Label14, "Select Range to Insert")
            '
            'panel3
            '
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.textBox2)
            Me.panel3.Controls.Add(Me.colorPickerButton1)
            Me.panel3.Location = New System.Drawing.Point(122, 201)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(41, 21)
            Me.panel3.TabIndex = 25
            '
            'textBox2
            '
            Me.textBox2.BackColor = System.Drawing.Color.White
            Me.textBox2.Location = New System.Drawing.Point(0, 0)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(22, 20)
            Me.textBox2.TabIndex = 21
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.Black
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.Black
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton1.TabIndex = 23
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = True
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Controls.Add(Me.colorPickerButton2)
            Me.panel2.Location = New System.Drawing.Point(122, 169)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(41, 21)
            Me.panel2.TabIndex = 24
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.Black
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(22, 20)
            Me.textBox1.TabIndex = 14
            '
            'colorPickerButton2
            '
            Me.colorPickerButton2.BackColor = System.Drawing.Color.Black
            Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton2.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton2.Name = "colorPickerButton2"
            Me.colorPickerButton2.SelectedAsBackcolor = True
            Me.colorPickerButton2.SelectedColor = System.Drawing.Color.Black
            Me.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton2.Size = New System.Drawing.Size(17, 19)
            Me.colorPickerButton2.TabIndex = 22
            Me.colorPickerButton2.Text = "..."
            Me.colorPickerButton2.UseVisualStyleBackColor = True
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Location = New System.Drawing.Point(38, 204)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(73, 13)
            Me.label13.TabIndex = 20
            Me.label13.Text = "Spacing Color"
            '
            'comboBoxStyle
            '
            Me.comboBoxStyle.FormattingEnabled = True
            Me.comboBoxStyle.Location = New System.Drawing.Point(122, 133)
            Me.comboBoxStyle.Name = "comboBoxStyle"
            Me.comboBoxStyle.Size = New System.Drawing.Size(75, 21)
            Me.comboBoxStyle.TabIndex = 19
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Location = New System.Drawing.Point(38, 137)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(53, 13)
            Me.label12.TabIndex = 18
            Me.label12.Text = "Line Style"
            '
            'numericUpDownWidth
            '
            Me.numericUpDownWidth.Location = New System.Drawing.Point(122, 99)
            Me.numericUpDownWidth.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
            Me.numericUpDownWidth.Name = "numericUpDownWidth"
            Me.numericUpDownWidth.Size = New System.Drawing.Size(75, 20)
            Me.numericUpDownWidth.TabIndex = 17
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(38, 103)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(58, 13)
            Me.label11.TabIndex = 16
            Me.label11.Text = "Line Width"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Location = New System.Drawing.Point(38, 170)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(54, 13)
            Me.label10.TabIndex = 13
            Me.label10.Text = "Line Color"
            '
            'numericUpDownSpacing
            '
            Me.numericUpDownSpacing.Location = New System.Drawing.Point(122, 66)
            Me.numericUpDownSpacing.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.numericUpDownSpacing.Name = "numericUpDownSpacing"
            Me.numericUpDownSpacing.Size = New System.Drawing.Size(74, 20)
            Me.numericUpDownSpacing.TabIndex = 12
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(38, 69)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(69, 13)
            Me.label9.TabIndex = 11
            Me.label9.Text = "Line Spacing"
            '
            'comboBoxType
            '
            Me.comboBoxType.FormattingEnabled = True
            Me.comboBoxType.Location = New System.Drawing.Point(122, 32)
            Me.comboBoxType.Name = "comboBoxType"
            Me.comboBoxType.Size = New System.Drawing.Size(75, 21)
            Me.comboBoxType.TabIndex = 10
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(38, 34)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(54, 13)
            Me.label8.TabIndex = 9
            Me.label8.Text = "Line Type"
            '
            'button2
            '
            Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button2.Location = New System.Drawing.Point(381, 185)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(88, 24)
            Me.button2.TabIndex = 3
            Me.button2.Text = "Remove Break"
            Me.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button2.UseVisualStyleBackColor = True
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Location = New System.Drawing.Point(263, 127)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(49, 15)
            Me.label7.TabIndex = 8
            Me.label7.Text = "Manual"
            '
            'button1
            '
            Me.button1.Enabled = False
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button1.Location = New System.Drawing.Point(274, 185)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(74, 24)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Insert Break"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = True
            '
            'numericUpDown1
            '
            Me.numericUpDown1.DecimalPlaces = 1
            Me.numericUpDown1.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.numericUpDown1.Location = New System.Drawing.Point(384, 92)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(99, 20)
            Me.numericUpDown1.TabIndex = 0
            Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 65536})
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(274, 152)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(70, 13)
            Me.label3.TabIndex = 0
            Me.label3.Text = "Break Range"
            '
            'listBox1
            '
            Me.listBox1.FormattingEnabled = True
            Me.listBox1.Items.AddRange(New Object() {"500-600", "950-3000"})
            Me.listBox1.Location = New System.Drawing.Point(384, 144)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(99, 30)
            Me.listBox1.TabIndex = 1
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(274, 94)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(74, 13)
            Me.label2.TabIndex = 1
            Me.label2.Text = "Break Amount"
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Location = New System.Drawing.Point(263, 70)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(31, 15)
            Me.label6.TabIndex = 7
            Me.label6.Text = "Auto"
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(10, 3)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(96, 20)
            Me.label5.TabIndex = 6
            Me.label5.Text = "Appearance"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label4.Location = New System.Drawing.Point(246, 3)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(76, 20)
            Me.label4.TabIndex = 5
            Me.label4.Text = "Behavior"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"None", "Manual", "Auto"})
            Me.comboBox1.Location = New System.Drawing.Point(384, 38)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(99, 21)
            Me.comboBox1.TabIndex = 3
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(274, 41)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(65, 13)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Break Mode"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(499, 639)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.checkBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Breaks"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            CType(Me.numericUpDownWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownSpacing, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		#End Region

		#Region "Form Load"
		''' <summary>
		''' Form Load

        ''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            InitializeControls()
            AddHandler checkBox1.CheckedChanged, AddressOf checkBox1_CheckedChanged
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
		#End Region

		#Region "Helpher Methods"
		''' <summary>
		''' Initializes chart series data
		''' </summary>
		Protected Sub InitializeChartData()
            Dim series As ChartSeries = New ChartSeries("Populated Countries", ChartSeriesType.Column)
            series.Text = series.Name
            series.Points.Add(1, 1330)
            series.Points.Add(2, 1148)
            series.Points.Add(3, 303.8)
            series.Points.Add(4, 237.5)
            series.Points.Add(5, 191.9)
            series.Points.Add(6, 167.8)
            series.Points.Add(7, 153.5)
            series.Points.Add(8, 140.7)
            series.Points.Add(9, 138.3)
            series.Points.Add(10, 127.3)
            Me.chartControl1.Series.Add(series)
            AddHandler chartControl1.Series(0).PrepareStyle, AddressOf Form1_PrepareStyle
            MakeBreakChart()
		End Sub

		''' <summary>
		''' Initializes controls
		''' </summary>
		Protected Sub InitializeControls()
			Me.comboBox1.SelectedIndex = 1
			Me.listBox1.SelectedIndex = 0
			For Each line As String In System.Enum.GetNames(GetType(ChartBreakLineType))
				Me.comboBoxType.Items.Add(line)
			Next line
			For Each line As String In System.Enum.GetNames(GetType(DashStyle))
				Me.comboBoxStyle.Items.Add(line)
			Next line

			Me.comboBoxType.SelectedIndex = 1
			Me.comboBoxStyle.SelectedIndex = 2
			Me.numericUpDownSpacing.Value = 5
			Me.numericUpDownWidth.Value = 1
        End Sub
        Public Sub SetRange()
            Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 1400, 100)
        End Sub

		''' <summary>
		''' Prepares for manual mode break chart
		''' </summary>
		Protected Sub MakeBreakChart()
            Me.chartControl1.PrimaryYAxis.BreakRanges.BreaksMode = ChartBreaksMode.Manual
            Me.chartControl1.PrimaryYAxis.BreakRanges.Union(New DoubleRange(300, 500))
            Me.chartControl1.PrimaryYAxis.BreakRanges.Union(New DoubleRange(800, 1100))
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = ChartBreakLineType.Wave
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 5
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineColor = Color.Black
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineWidth = 1
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineStyle = DashStyle.Dot
            Me.chartControl1.PrimaryYAxis.BreakInfo.SpacingColor = Color.White
		End Sub
		#End Region

#Region "Events"
        Private Sub Form1_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = Me.chartControl1.Series(0)
            If Not series Is Nothing Then

                If args.Index = 0 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 41, 158, 214))
                ElseIf args.Index = 1 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 206, 215, 41))
                ElseIf args.Index = 2 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 255, 186, 0))
                ElseIf args.Index = 3 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 247, 125, 16))
                ElseIf args.Index = 4 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 129, 115, 27))
                ElseIf args.Index = 5 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 255, 136, 23))
                ElseIf args.Index = 6 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 246, 100, 15))
                ElseIf args.Index = 7 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 188, 200, 6))
                ElseIf args.Index = 8 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 234, 90, 81))
                ElseIf args.Index = 9 Then
                    args.Style.Interior = New BrushInfo(Color.FromArgb(200, 191, 192, 98))
                End If
            End If
        End Sub

        ''' <summary>
        ''' Toggles between Break and regular chart
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            If Me.checkBox1.Checked Then
                Me.panel1.Enabled = True
                Me.chartControl1.PrimaryYAxis.MakeBreaks = True
                If Not Me.comboBox1.SelectedItem Is Nothing Then
                    Me.chartControl1.PrimaryYAxis.BreakRanges.BreaksMode = CType(System.Enum.Parse(GetType(ChartBreaksMode), Me.comboBox1.SelectedItem.ToString()), ChartBreaksMode)
                End If
            Else
                Me.chartControl1.PrimaryYAxis.MakeBreaks = False
                Me.panel1.Enabled = False
            End If
            SetRange()
        End Sub

        ''' <summary>
        ''' Handles the different break modes
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            If Me.comboBox1.SelectedIndex = 0 Then
                Me.chartControl1.PrimaryYAxis.BreakRanges.Clear()
            ElseIf Me.comboBox1.SelectedIndex = 1 Then
                MakeBreakChart()
                Me.button1.Enabled = False
            ElseIf Me.comboBox1.SelectedIndex = 2 Then
                Me.chartControl1.PrimaryYAxis.BreakRanges.BreaksMode = ChartBreaksMode.Auto
                Me.chartControl1.PrimaryYAxis.BreakRanges.BreakAmount = Convert.ToDouble(Me.numericUpDown1.Value)
            End If
            SetRange()
        End Sub

        ''' <summary>
        ''' Removes the specified range from manual break chart
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            Dim temp As String = Me.listBox1.SelectedItem.ToString()
            Dim start As Double = Convert.ToDouble(temp.Substring(0, temp.LastIndexOf("-"c)))
            Dim [end] As Double = Convert.ToDouble(temp.Substring(temp.LastIndexOf("-"c) + 1))
            Me.chartControl1.PrimaryYAxis.BreakRanges.Exclude(New DoubleRange(start, [end]))
            Me.button1.Enabled = True
            SetRange()
        End Sub

        ''' <summary>
        ''' Inserts the specified range from manual break chart
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim temp As String = Me.listBox1.SelectedItem.ToString()
            Dim start As Double = Convert.ToDouble(temp.Substring(0, temp.LastIndexOf("-"c)))
            Dim [end] As Double = Convert.ToDouble(temp.Substring(temp.LastIndexOf("-"c) + 1))
            Me.chartControl1.PrimaryYAxis.BreakRanges.Union(New DoubleRange(start, [end]))
            SetRange()
        End Sub

        ''' <summary>
        ''' Updates the break amount during auto break mode
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
            Me.chartControl1.PrimaryYAxis.BreakRanges.BreakAmount = Convert.ToDouble(Me.numericUpDown1.Value)
            SetRange()
        End Sub

        ''' <summary>
        ''' Updates the type of the break line
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub comboBoxType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxType.SelectedIndexChanged
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = CType(System.Enum.Parse(GetType(ChartBreakLineType), Me.comboBoxType.SelectedItem.ToString()), ChartBreakLineType)
            SetRange()
        End Sub

        ''' <summary>
        ''' Updates the style of the break line
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub comboBoxStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxStyle.SelectedIndexChanged
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBoxStyle.SelectedItem.ToString()), DashStyle)
            SetRange()
        End Sub

        ''' <summary>
        ''' Controls the spacing of the break line
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub numericUpDownSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownSpacing.ValueChanged
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = Convert.ToDouble(Me.numericUpDownSpacing.Value)
            SetRange()
        End Sub

        ''' <summary>
        ''' Controls the width of the break line border
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub numericUpDownWidth_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownWidth.ValueChanged
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineWidth = CSng(Me.numericUpDownWidth.Value)
            SetRange()
        End Sub

        ''' <summary>
        ''' Handles the color of the break line border
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton2.ColorSelected
            Me.textBox1.BackColor = Me.colorPickerButton2.SelectedColor
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineColor = Me.colorPickerButton2.SelectedColor
            SetRange()
        End Sub

        ''' <summary>
        ''' Handles the color of the spacing of breakline
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
            Me.textBox2.BackColor = Me.colorPickerButton1.SelectedColor
            Me.chartControl1.PrimaryYAxis.BreakInfo.SpacingColor = Me.colorPickerButton1.SelectedColor
            SetRange()
        End Sub
#End Region

        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
            If e.AxisOrientation = ChartOrientation.Horizontal Then
                If e.Value = 1 Then
                    e.Label = "China"
                ElseIf e.Value = 2 Then
                    e.Label = "India"
                ElseIf e.Value = 3 Then
                    e.Label = "United States"
                ElseIf e.Value = 4 Then
                    e.Label = "Indonesia"
                ElseIf e.Value = 5 Then
                    e.Label = "Brazil"
                ElseIf e.Value = 6 Then
                    e.Label = "Pakistan"
                ElseIf e.Value = 7 Then
                    e.Label = "Bangladesh"
                ElseIf e.Value = 8 Then
                    e.Label = "Russia"
                ElseIf e.Value = 9 Then
                    e.Label = "Nigeria"
                ElseIf e.Value = 10 Then
                    e.Label = "Japan"
                Else
                    e.Label = ""
                End If

                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
