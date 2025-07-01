Imports Microsoft.VisualBasic
Imports System
Namespace HeatMapChart_2005
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
            Me.chartTitle1 = New Syncfusion.Windows.Forms.Chart.ChartTitle
            Me.panel1 = New System.Windows.Forms.Panel
            Me.designerPanel2 = New DesignerPanel
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label5 = New System.Windows.Forms.Label
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.label4 = New System.Windows.Forms.Label
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.trackBar2 = New System.Windows.Forms.TrackBar
            Me.label3 = New System.Windows.Forms.Label
            Me.trackBar1 = New System.Windows.Forms.TrackBar
            Me.button1 = New System.Windows.Forms.Button
            Me.designerPanel1 = New DesignerPanel
            Me.label2 = New System.Windows.Forms.Label
            Me.panel4 = New System.Windows.Forms.Panel
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.colorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label1 = New System.Windows.Forms.Label
            Me.panel3 = New System.Windows.Forms.Panel
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label18 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.chartControl1.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType(Me.designerPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel2.SuspendLayout()
            CType(Me.trackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel1.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(365, 105)
            Me.chartControl1.Location = New System.Drawing.Point(45, 16)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.Size = New System.Drawing.Size(474, 305)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.Titles.Add(Me.chartTitle1)
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
            '
            'chartTitle1
            '
            Me.chartTitle1.Font = New System.Drawing.Font("Verdana", 8.5!, System.Drawing.FontStyle.Bold)
            Me.chartTitle1.ForeColor = System.Drawing.Color.SaddleBrown
            Me.chartTitle1.Name = "chartTitle1"
            Me.chartTitle1.Text = "Cell Size as Sales, Cell Color as Expense"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.designerPanel2)
            Me.panel1.Controls.Add(Me.designerPanel1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 332)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(550, 193)
            Me.panel1.TabIndex = 1
            '
            'designerPanel2
            '
            Me.designerPanel2.BackColor = System.Drawing.Color.White
            Me.designerPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel2.Controls.Add(Me.comboBox1)
            Me.designerPanel2.Controls.Add(Me.label5)
            Me.designerPanel2.Controls.Add(Me.checkBox3)
            Me.designerPanel2.Controls.Add(Me.label4)
            Me.designerPanel2.Controls.Add(Me.checkBox2)
            Me.designerPanel2.Controls.Add(Me.checkBox1)
            Me.designerPanel2.Controls.Add(Me.trackBar2)
            Me.designerPanel2.Controls.Add(Me.label3)
            Me.designerPanel2.Controls.Add(Me.trackBar1)
            Me.designerPanel2.Controls.Add(Me.button1)
            Me.designerPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel2.HeaderImage = CType(resources.GetObject("designerPanel2.HeaderImage"), System.Drawing.Image)
            Me.designerPanel2.HeaderText = "       Point Setting"
            Me.designerPanel2.Location = New System.Drawing.Point(189, 7)
            Me.designerPanel2.Name = "designerPanel2"
            Me.designerPanel2.Size = New System.Drawing.Size(354, 178)
            Me.designerPanel2.TabIndex = 1
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Vertical", "Horizontal", "Rectangular"})
            Me.comboBox1.Location = New System.Drawing.Point(126, 118)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(123, 21)
            Me.comboBox1.TabIndex = 12
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(21, 122)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(80, 13)
            Me.label5.TabIndex = 11
            Me.label5.Text = "Heat Map Style"
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Checked = True
            Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox3.Location = New System.Drawing.Point(206, 93)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(126, 17)
            Me.checkBox3.TabIndex = 9
            Me.checkBox3.Text = "Display Color Swatch"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Location = New System.Drawing.Point(20, 79)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(30, 13)
            Me.label4.TabIndex = 4
            Me.label4.Text = "Utah"
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox2.Location = New System.Drawing.Point(206, 63)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(84, 17)
            Me.checkBox2.TabIndex = 6
            Me.checkBox2.Text = "Display Text"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(206, 37)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(83, 17)
            Me.checkBox1.TabIndex = 5
            Me.checkBox1.Text = "Display Title"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'trackBar2
            '
            Me.trackBar2.Location = New System.Drawing.Point(60, 71)
            Me.trackBar2.Name = "trackBar2"
            Me.trackBar2.Size = New System.Drawing.Size(104, 45)
            Me.trackBar2.TabIndex = 3
            Me.trackBar2.Value = 1
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(20, 39)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(25, 13)
            Me.label3.TabIndex = 2
            Me.label3.Text = "US "
            '
            'trackBar1
            '
            Me.trackBar1.Location = New System.Drawing.Point(60, 31)
            Me.trackBar1.Name = "trackBar1"
            Me.trackBar1.Size = New System.Drawing.Size(104, 45)
            Me.trackBar1.TabIndex = 1
            Me.trackBar1.Value = 4
            '
            'button1
            '
            Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.Location = New System.Drawing.Point(23, 145)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(124, 23)
            Me.button1.TabIndex = 7
            Me.button1.Text = "Add New Items"
            Me.button1.UseVisualStyleBackColor = True
            '
            'designerPanel1
            '
            Me.designerPanel1.BackColor = System.Drawing.Color.White
            Me.designerPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel1.Controls.Add(Me.label2)
            Me.designerPanel1.Controls.Add(Me.panel4)
            Me.designerPanel1.Controls.Add(Me.label1)
            Me.designerPanel1.Controls.Add(Me.panel3)
            Me.designerPanel1.Controls.Add(Me.label18)
            Me.designerPanel1.Controls.Add(Me.panel2)
            Me.designerPanel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel1.HeaderImage = CType(resources.GetObject("designerPanel1.HeaderImage"), System.Drawing.Image)
            Me.designerPanel1.HeaderText = "      Color Setting"
            Me.designerPanel1.Location = New System.Drawing.Point(12, 6)
            Me.designerPanel1.Name = "designerPanel1"
            Me.designerPanel1.Size = New System.Drawing.Size(167, 178)
            Me.designerPanel1.TabIndex = 0
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.Color.Black
            Me.label2.Location = New System.Drawing.Point(12, 122)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(95, 13)
            Me.label2.TabIndex = 96
            Me.label2.Text = "Middle Value Color"
            '
            'panel4
            '
            Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel4.Controls.Add(Me.textBox3)
            Me.panel4.Controls.Add(Me.colorPickerButton3)
            Me.panel4.Location = New System.Drawing.Point(112, 122)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(41, 19)
            Me.panel4.TabIndex = 95
            '
            'textBox3
            '
            Me.textBox3.BackColor = System.Drawing.Color.Gold
            Me.textBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox3.Location = New System.Drawing.Point(0, 0)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ReadOnly = True
            Me.textBox3.Size = New System.Drawing.Size(22, 20)
            Me.textBox3.TabIndex = 11
            '
            'colorPickerButton3
            '
            Me.colorPickerButton3.BackColor = System.Drawing.Color.Gold
            Me.colorPickerButton3.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton3.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton3.Image = CType(resources.GetObject("colorPickerButton3.Image"), System.Drawing.Image)
            Me.colorPickerButton3.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton3.Name = "colorPickerButton3"
            Me.colorPickerButton3.SelectedAsBackcolor = True
            Me.colorPickerButton3.SelectedColor = System.Drawing.Color.Gold
            Me.colorPickerButton3.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton3.Size = New System.Drawing.Size(17, 17)
            Me.colorPickerButton3.TabIndex = 14
            Me.colorPickerButton3.Text = "..."
            Me.colorPickerButton3.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(12, 90)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(100, 13)
            Me.label1.TabIndex = 94
            Me.label1.Text = "Highest Value Color"
            '
            'panel3
            '
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.textBox2)
            Me.panel3.Controls.Add(Me.colorPickerButton2)
            Me.panel3.Location = New System.Drawing.Point(112, 90)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(41, 19)
            Me.panel3.TabIndex = 93
            '
            'textBox2
            '
            Me.textBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox2.Location = New System.Drawing.Point(0, 0)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(22, 20)
            Me.textBox2.TabIndex = 11
            '
            'colorPickerButton2
            '
            Me.colorPickerButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton2.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton2.Image = CType(resources.GetObject("colorPickerButton2.Image"), System.Drawing.Image)
            Me.colorPickerButton2.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton2.Name = "colorPickerButton2"
            Me.colorPickerButton2.SelectedAsBackcolor = True
            Me.colorPickerButton2.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton2.Size = New System.Drawing.Size(17, 17)
            Me.colorPickerButton2.TabIndex = 14
            Me.colorPickerButton2.Text = "..."
            Me.colorPickerButton2.UseVisualStyleBackColor = False
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label18.ForeColor = System.Drawing.Color.Black
            Me.label18.Location = New System.Drawing.Point(12, 56)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(98, 13)
            Me.label18.TabIndex = 92
            Me.label18.Text = "Lowest Value Color"
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Controls.Add(Me.colorPickerButton1)
            Me.panel2.Location = New System.Drawing.Point(112, 56)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(41, 19)
            Me.panel2.TabIndex = 91
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(22, 20)
            Me.textBox1.TabIndex = 11
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton1.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Image = CType(resources.GetObject("colorPickerButton1.Image"), System.Drawing.Image)
            Me.colorPickerButton1.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(17, 17)
            Me.colorPickerButton1.TabIndex = 14
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(550, 525)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Heat Map Chart"
            Me.chartControl1.ResumeLayout(False)
            Me.chartControl1.PerformLayout()
            Me.panel1.ResumeLayout(False)
            CType(Me.designerPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel2.ResumeLayout(False)
            Me.designerPanel2.PerformLayout()
            CType(Me.trackBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel1.ResumeLayout(False)
            Me.designerPanel1.PerformLayout()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private panel1 As System.Windows.Forms.Panel
		Private designerPanel1 As DesignerPanel
		Private label2 As System.Windows.Forms.Label
		Private panel4 As System.Windows.Forms.Panel
		Private textBox3 As System.Windows.Forms.TextBox
		Private WithEvents colorPickerButton3 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label1 As System.Windows.Forms.Label
		Private panel3 As System.Windows.Forms.Panel
		Private textBox2 As System.Windows.Forms.TextBox
		Private WithEvents colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
		Private label18 As System.Windows.Forms.Label
		Private panel2 As System.Windows.Forms.Panel
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
		Private designerPanel2 As DesignerPanel
		Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private WithEvents trackBar2 As System.Windows.Forms.TrackBar
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private WithEvents button1 As System.Windows.Forms.Button
        Private chartTitle1 As Syncfusion.Windows.Forms.Chart.ChartTitle
        Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents label5 As System.Windows.Forms.Label
	End Class
End Namespace

