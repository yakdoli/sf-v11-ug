Imports Microsoft.VisualBasic
Imports System
Namespace TickMarksDemo_2005
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
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.label40 = New System.Windows.Forms.Label
            Me.designerPanel2 = New DesignerPanel
            Me.label17 = New System.Windows.Forms.Label
            Me.nUDYAxisTickWidth = New System.Windows.Forms.NumericUpDown
            Me.label16 = New System.Windows.Forms.Label
            Me.label18 = New System.Windows.Forms.Label
            Me.nUDYAxisTickHeight = New System.Windows.Forms.NumericUpDown
            Me.nUDYAxisTickGridPadding = New System.Windows.Forms.NumericUpDown
            Me.cbYAxisDrawLabelGrid = New System.Windows.Forms.CheckBox
            Me.label7 = New System.Windows.Forms.Label
            Me.nUDYAxisSmallTickWidth = New System.Windows.Forms.NumericUpDown
            Me.label12 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label14 = New System.Windows.Forms.Label
            Me.nUDYAxisSmallTickHeight = New System.Windows.Forms.NumericUpDown
            Me.cpYAxisTickColor = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.nUDYAxisTicksPerInterval = New System.Windows.Forms.NumericUpDown
            Me.label8 = New System.Windows.Forms.Label
            Me.label10 = New System.Windows.Forms.Label
            Me.designerPanel1 = New DesignerPanel
            Me.label15 = New System.Windows.Forms.Label
            Me.nUDXAxisTickWidth = New System.Windows.Forms.NumericUpDown
            Me.label3 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.nUDXAxisTickHeight = New System.Windows.Forms.NumericUpDown
            Me.label6 = New System.Windows.Forms.Label
            Me.nUDXAxisSmallTickWidth = New System.Windows.Forms.NumericUpDown
            Me.label13 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.nUDXAxisSmallTickHeight = New System.Windows.Forms.NumericUpDown
            Me.cbXAxisDrawLabelGrid = New System.Windows.Forms.CheckBox
            Me.nUDXAxisTickGridPadding = New System.Windows.Forms.NumericUpDown
            Me.label2 = New System.Windows.Forms.Label
            Me.cpXAxisTickColor = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label1 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.nUDXAxisTicksPerInterval = New System.Windows.Forms.NumericUpDown
            Me.chartControl1.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.designerPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel2.SuspendLayout()
            CType(Me.nUDYAxisTickWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDYAxisTickHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDYAxisTickGridPadding, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDYAxisSmallTickWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDYAxisSmallTickHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDYAxisTicksPerInterval, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel1.SuspendLayout()
            CType(Me.nUDXAxisTickWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDXAxisTickHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDXAxisSmallTickWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDXAxisSmallTickHeight, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDXAxisTickGridPadding, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.nUDXAxisTicksPerInterval, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer)))
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(6, Byte), Integer), CType(CType(22, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(102, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(489, 72)
            Me.chartControl1.Location = New System.Drawing.Point(16, 64)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.DrawTickLabelGrid = True
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryXAxis.SmallTickSize = New System.Drawing.Size(1, 5)
            Me.chartControl1.PrimaryXAxis.SmallTicksPerInterval = 5
            Me.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.TickSize = New System.Drawing.Size(2, 8)
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.SmallTickSize = New System.Drawing.Size(5, 1)
            Me.chartControl1.PrimaryYAxis.SmallTicksPerInterval = 5
            Me.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.TickDrawingOperationMode = Syncfusion.Windows.Forms.Chart.ChartAxisTickDrawingOperationMode.IntervalFixed
            Me.chartControl1.PrimaryYAxis.TickSize = New System.Drawing.Size(8, 2)
            Me.chartControl1.Size = New System.Drawing.Size(615, 363)
            Me.chartControl1.Spacing = 40.0!
            Me.chartControl1.TabIndex = 0
            '
            '
            '
            Me.chartControl1.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.Margin = 1
            Me.chartControl1.Title.Name = "Default"
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
            Me.chartTitle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartTitle1.Margin = 1
            Me.chartTitle1.Name = "chartTitle1"
            Me.chartTitle1.Text = "Transmission Life Expectancy"
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image)})
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.White
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.richTextBox1)
            Me.gradientPanel1.Controls.Add(Me.label40)
            Me.gradientPanel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel1.Location = New System.Drawing.Point(11, 12)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(629, 49)
            Me.gradientPanel1.TabIndex = 3
            '
            'richTextBox1
            '
            Me.richTextBox1.BackColor = System.Drawing.Color.White
            Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(577, 47)
            Me.richTextBox1.TabIndex = 4
            Me.richTextBox1.Text = ""
            '
            'label40
            '
            Me.label40.BackColor = System.Drawing.Color.White
            Me.label40.Dock = System.Windows.Forms.DockStyle.Right
            Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label40.Image = CType(resources.GetObject("label40.Image"), System.Drawing.Image)
            Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label40.Location = New System.Drawing.Point(577, 0)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(50, 47)
            Me.label40.TabIndex = 1
            '
            'designerPanel2
            '
            Me.designerPanel2.BackColor = System.Drawing.Color.White
            Me.designerPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel2.Controls.Add(Me.label17)
            Me.designerPanel2.Controls.Add(Me.nUDYAxisTickWidth)
            Me.designerPanel2.Controls.Add(Me.label16)
            Me.designerPanel2.Controls.Add(Me.label18)
            Me.designerPanel2.Controls.Add(Me.nUDYAxisTickHeight)
            Me.designerPanel2.Controls.Add(Me.nUDYAxisTickGridPadding)
            Me.designerPanel2.Controls.Add(Me.cbYAxisDrawLabelGrid)
            Me.designerPanel2.Controls.Add(Me.label7)
            Me.designerPanel2.Controls.Add(Me.nUDYAxisSmallTickWidth)
            Me.designerPanel2.Controls.Add(Me.label12)
            Me.designerPanel2.Controls.Add(Me.label5)
            Me.designerPanel2.Controls.Add(Me.label14)
            Me.designerPanel2.Controls.Add(Me.nUDYAxisSmallTickHeight)
            Me.designerPanel2.Controls.Add(Me.cpYAxisTickColor)
            Me.designerPanel2.Controls.Add(Me.nUDYAxisTicksPerInterval)
            Me.designerPanel2.Controls.Add(Me.label8)
            Me.designerPanel2.Controls.Add(Me.label10)
            Me.designerPanel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.designerPanel2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel2.HeaderImage = CType(resources.GetObject("designerPanel2.HeaderImage"), System.Drawing.Image)
            Me.designerPanel2.HeaderText = "     Y Axis Ticks"
            Me.designerPanel2.Location = New System.Drawing.Point(337, 431)
            Me.designerPanel2.Name = "designerPanel2"
            Me.designerPanel2.Size = New System.Drawing.Size(295, 201)
            Me.designerPanel2.TabIndex = 2
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label17.ForeColor = System.Drawing.Color.Black
            Me.label17.Location = New System.Drawing.Point(130, 149)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(38, 13)
            Me.label17.TabIndex = 23
            Me.label17.Text = "Height"
            '
            'nUDYAxisTickWidth
            '
            Me.nUDYAxisTickWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDYAxisTickWidth.ForeColor = System.Drawing.Color.Black
            Me.nUDYAxisTickWidth.Location = New System.Drawing.Point(240, 149)
            Me.nUDYAxisTickWidth.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDYAxisTickWidth.Name = "nUDYAxisTickWidth"
            Me.nUDYAxisTickWidth.Size = New System.Drawing.Size(31, 20)
            Me.nUDYAxisTickWidth.TabIndex = 25
            Me.nUDYAxisTickWidth.Value = New Decimal(New Integer() {8, 0, 0, 0})
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label16.ForeColor = System.Drawing.Color.Black
            Me.label16.Location = New System.Drawing.Point(204, 149)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(35, 13)
            Me.label16.TabIndex = 24
            Me.label16.Text = "Width"
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label18.ForeColor = System.Drawing.Color.Black
            Me.label18.Location = New System.Drawing.Point(5, 149)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(56, 13)
            Me.label18.TabIndex = 21
            Me.label18.Text = "Ticks Size"
            '
            'nUDYAxisTickHeight
            '
            Me.nUDYAxisTickHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDYAxisTickHeight.ForeColor = System.Drawing.Color.Black
            Me.nUDYAxisTickHeight.Location = New System.Drawing.Point(168, 149)
            Me.nUDYAxisTickHeight.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDYAxisTickHeight.Name = "nUDYAxisTickHeight"
            Me.nUDYAxisTickHeight.Size = New System.Drawing.Size(32, 20)
            Me.nUDYAxisTickHeight.TabIndex = 22
            Me.nUDYAxisTickHeight.Value = New Decimal(New Integer() {2, 0, 0, 0})
            '
            'nUDYAxisTickGridPadding
            '
            Me.nUDYAxisTickGridPadding.Enabled = False
            Me.nUDYAxisTickGridPadding.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDYAxisTickGridPadding.ForeColor = System.Drawing.Color.Black
            Me.nUDYAxisTickGridPadding.Location = New System.Drawing.Point(133, 121)
            Me.nUDYAxisTickGridPadding.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDYAxisTickGridPadding.Name = "nUDYAxisTickGridPadding"
            Me.nUDYAxisTickGridPadding.Size = New System.Drawing.Size(36, 20)
            Me.nUDYAxisTickGridPadding.TabIndex = 8
            Me.nUDYAxisTickGridPadding.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'cbYAxisDrawLabelGrid
            '
            Me.cbYAxisDrawLabelGrid.AutoSize = True
            Me.cbYAxisDrawLabelGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.cbYAxisDrawLabelGrid.ForeColor = System.Drawing.Color.Black
            Me.cbYAxisDrawLabelGrid.Location = New System.Drawing.Point(5, 33)
            Me.cbYAxisDrawLabelGrid.Name = "cbYAxisDrawLabelGrid"
            Me.cbYAxisDrawLabelGrid.Size = New System.Drawing.Size(126, 17)
            Me.cbYAxisDrawLabelGrid.TabIndex = 4
            Me.cbYAxisDrawLabelGrid.Text = "Draw Tick Label Grid"
            Me.cbYAxisDrawLabelGrid.UseVisualStyleBackColor = True
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label7.ForeColor = System.Drawing.Color.Black
            Me.label7.Location = New System.Drawing.Point(5, 121)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(121, 13)
            Me.label7.TabIndex = 7
            Me.label7.Text = "Tick Label Grid Padding"
            '
            'nUDYAxisSmallTickWidth
            '
            Me.nUDYAxisSmallTickWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDYAxisSmallTickWidth.ForeColor = System.Drawing.Color.Black
            Me.nUDYAxisSmallTickWidth.Location = New System.Drawing.Point(240, 177)
            Me.nUDYAxisSmallTickWidth.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDYAxisSmallTickWidth.Name = "nUDYAxisSmallTickWidth"
            Me.nUDYAxisSmallTickWidth.Size = New System.Drawing.Size(31, 20)
            Me.nUDYAxisSmallTickWidth.TabIndex = 20
            Me.nUDYAxisSmallTickWidth.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label12.ForeColor = System.Drawing.Color.Black
            Me.label12.Location = New System.Drawing.Point(204, 177)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(35, 13)
            Me.label12.TabIndex = 19
            Me.label12.Text = "Width"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label5.ForeColor = System.Drawing.Color.Black
            Me.label5.Location = New System.Drawing.Point(5, 177)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(84, 13)
            Me.label5.TabIndex = 12
            Me.label5.Text = "Small Ticks Size"
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label14.ForeColor = System.Drawing.Color.Black
            Me.label14.Location = New System.Drawing.Point(130, 177)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(38, 13)
            Me.label14.TabIndex = 18
            Me.label14.Text = "Height"
            '
            'nUDYAxisSmallTickHeight
            '
            Me.nUDYAxisSmallTickHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDYAxisSmallTickHeight.ForeColor = System.Drawing.Color.Black
            Me.nUDYAxisSmallTickHeight.Location = New System.Drawing.Point(168, 177)
            Me.nUDYAxisSmallTickHeight.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDYAxisSmallTickHeight.Name = "nUDYAxisSmallTickHeight"
            Me.nUDYAxisSmallTickHeight.Size = New System.Drawing.Size(32, 20)
            Me.nUDYAxisSmallTickHeight.TabIndex = 17
            Me.nUDYAxisSmallTickHeight.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'cpYAxisTickColor
            '
            Me.cpYAxisTickColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cpYAxisTickColor.ColorUISize = New System.Drawing.Size(208, 230)
            Me.cpYAxisTickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cpYAxisTickColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.cpYAxisTickColor.ForeColor = System.Drawing.Color.Black
            Me.cpYAxisTickColor.Location = New System.Drawing.Point(133, 65)
            Me.cpYAxisTickColor.Name = "cpYAxisTickColor"
            Me.cpYAxisTickColor.SelectedAsBackcolor = True
            Me.cpYAxisTickColor.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cpYAxisTickColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.cpYAxisTickColor.Size = New System.Drawing.Size(20, 20)
            Me.cpYAxisTickColor.TabIndex = 6
            Me.cpYAxisTickColor.UseVisualStyleBackColor = False
            '
            'nUDYAxisTicksPerInterval
            '
            Me.nUDYAxisTicksPerInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDYAxisTicksPerInterval.ForeColor = System.Drawing.Color.Black
            Me.nUDYAxisTicksPerInterval.Location = New System.Drawing.Point(133, 93)
            Me.nUDYAxisTicksPerInterval.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDYAxisTicksPerInterval.Name = "nUDYAxisTicksPerInterval"
            Me.nUDYAxisTicksPerInterval.Size = New System.Drawing.Size(36, 20)
            Me.nUDYAxisTicksPerInterval.TabIndex = 2
            Me.nUDYAxisTicksPerInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label8.ForeColor = System.Drawing.Color.Black
            Me.label8.Location = New System.Drawing.Point(5, 65)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(55, 13)
            Me.label8.TabIndex = 3
            Me.label8.Text = "Tick Color"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label10.ForeColor = System.Drawing.Color.Black
            Me.label10.Location = New System.Drawing.Point(5, 93)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(118, 13)
            Me.label10.TabIndex = 1
            Me.label10.Text = "Small Ticks Per Interval"
            '
            'designerPanel1
            '
            Me.designerPanel1.BackColor = System.Drawing.Color.White
            Me.designerPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel1.Controls.Add(Me.label15)
            Me.designerPanel1.Controls.Add(Me.nUDXAxisTickWidth)
            Me.designerPanel1.Controls.Add(Me.label3)
            Me.designerPanel1.Controls.Add(Me.label9)
            Me.designerPanel1.Controls.Add(Me.nUDXAxisTickHeight)
            Me.designerPanel1.Controls.Add(Me.label6)
            Me.designerPanel1.Controls.Add(Me.nUDXAxisSmallTickWidth)
            Me.designerPanel1.Controls.Add(Me.label13)
            Me.designerPanel1.Controls.Add(Me.label11)
            Me.designerPanel1.Controls.Add(Me.nUDXAxisSmallTickHeight)
            Me.designerPanel1.Controls.Add(Me.cbXAxisDrawLabelGrid)
            Me.designerPanel1.Controls.Add(Me.nUDXAxisTickGridPadding)
            Me.designerPanel1.Controls.Add(Me.label2)
            Me.designerPanel1.Controls.Add(Me.cpXAxisTickColor)
            Me.designerPanel1.Controls.Add(Me.label1)
            Me.designerPanel1.Controls.Add(Me.label4)
            Me.designerPanel1.Controls.Add(Me.nUDXAxisTicksPerInterval)
            Me.designerPanel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.designerPanel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel1.HeaderImage = CType(resources.GetObject("designerPanel1.HeaderImage"), System.Drawing.Image)
            Me.designerPanel1.HeaderText = "     X Axis Ticks"
            Me.designerPanel1.Location = New System.Drawing.Point(19, 431)
            Me.designerPanel1.Name = "designerPanel1"
            Me.designerPanel1.Size = New System.Drawing.Size(295, 201)
            Me.designerPanel1.TabIndex = 1
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label15.ForeColor = System.Drawing.Color.Black
            Me.label15.Location = New System.Drawing.Point(3, 149)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(56, 13)
            Me.label15.TabIndex = 17
            Me.label15.Text = "Ticks Size"
            '
            'nUDXAxisTickWidth
            '
            Me.nUDXAxisTickWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDXAxisTickWidth.ForeColor = System.Drawing.Color.Black
            Me.nUDXAxisTickWidth.Location = New System.Drawing.Point(240, 149)
            Me.nUDXAxisTickWidth.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDXAxisTickWidth.Name = "nUDXAxisTickWidth"
            Me.nUDXAxisTickWidth.Size = New System.Drawing.Size(31, 20)
            Me.nUDXAxisTickWidth.TabIndex = 21
            Me.nUDXAxisTickWidth.Value = New Decimal(New Integer() {2, 0, 0, 0})
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label3.ForeColor = System.Drawing.Color.Black
            Me.label3.Location = New System.Drawing.Point(204, 149)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(35, 13)
            Me.label3.TabIndex = 20
            Me.label3.Text = "Width"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.ForeColor = System.Drawing.Color.Black
            Me.label9.Location = New System.Drawing.Point(130, 149)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(38, 13)
            Me.label9.TabIndex = 19
            Me.label9.Text = "Height"
            '
            'nUDXAxisTickHeight
            '
            Me.nUDXAxisTickHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDXAxisTickHeight.ForeColor = System.Drawing.Color.Black
            Me.nUDXAxisTickHeight.Location = New System.Drawing.Point(168, 149)
            Me.nUDXAxisTickHeight.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDXAxisTickHeight.Name = "nUDXAxisTickHeight"
            Me.nUDXAxisTickHeight.Size = New System.Drawing.Size(32, 20)
            Me.nUDXAxisTickHeight.TabIndex = 18
            Me.nUDXAxisTickHeight.Value = New Decimal(New Integer() {8, 0, 0, 0})
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label6.ForeColor = System.Drawing.Color.Black
            Me.label6.Location = New System.Drawing.Point(3, 177)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(84, 13)
            Me.label6.TabIndex = 12
            Me.label6.Text = "Small Ticks Size"
            '
            'nUDXAxisSmallTickWidth
            '
            Me.nUDXAxisSmallTickWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDXAxisSmallTickWidth.ForeColor = System.Drawing.Color.Black
            Me.nUDXAxisSmallTickWidth.Location = New System.Drawing.Point(240, 177)
            Me.nUDXAxisSmallTickWidth.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDXAxisSmallTickWidth.Name = "nUDXAxisSmallTickWidth"
            Me.nUDXAxisSmallTickWidth.Size = New System.Drawing.Size(31, 20)
            Me.nUDXAxisSmallTickWidth.TabIndex = 16
            Me.nUDXAxisSmallTickWidth.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label13.ForeColor = System.Drawing.Color.Black
            Me.label13.Location = New System.Drawing.Point(204, 177)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(35, 13)
            Me.label13.TabIndex = 15
            Me.label13.Text = "Width"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label11.ForeColor = System.Drawing.Color.Black
            Me.label11.Location = New System.Drawing.Point(130, 177)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(38, 13)
            Me.label11.TabIndex = 14
            Me.label11.Text = "Height"
            '
            'nUDXAxisSmallTickHeight
            '
            Me.nUDXAxisSmallTickHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDXAxisSmallTickHeight.ForeColor = System.Drawing.Color.Black
            Me.nUDXAxisSmallTickHeight.Location = New System.Drawing.Point(168, 177)
            Me.nUDXAxisSmallTickHeight.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDXAxisSmallTickHeight.Name = "nUDXAxisSmallTickHeight"
            Me.nUDXAxisSmallTickHeight.Size = New System.Drawing.Size(32, 20)
            Me.nUDXAxisSmallTickHeight.TabIndex = 13
            Me.nUDXAxisSmallTickHeight.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'cbXAxisDrawLabelGrid
            '
            Me.cbXAxisDrawLabelGrid.AutoSize = True
            Me.cbXAxisDrawLabelGrid.Checked = True
            Me.cbXAxisDrawLabelGrid.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbXAxisDrawLabelGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.cbXAxisDrawLabelGrid.ForeColor = System.Drawing.Color.Black
            Me.cbXAxisDrawLabelGrid.Location = New System.Drawing.Point(4, 39)
            Me.cbXAxisDrawLabelGrid.Name = "cbXAxisDrawLabelGrid"
            Me.cbXAxisDrawLabelGrid.Size = New System.Drawing.Size(126, 17)
            Me.cbXAxisDrawLabelGrid.TabIndex = 4
            Me.cbXAxisDrawLabelGrid.Text = "Draw Tick Label Grid"
            Me.cbXAxisDrawLabelGrid.UseVisualStyleBackColor = True
            '
            'nUDXAxisTickGridPadding
            '
            Me.nUDXAxisTickGridPadding.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDXAxisTickGridPadding.ForeColor = System.Drawing.Color.Black
            Me.nUDXAxisTickGridPadding.Location = New System.Drawing.Point(130, 121)
            Me.nUDXAxisTickGridPadding.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDXAxisTickGridPadding.Name = "nUDXAxisTickGridPadding"
            Me.nUDXAxisTickGridPadding.Size = New System.Drawing.Size(36, 20)
            Me.nUDXAxisTickGridPadding.TabIndex = 8
            Me.nUDXAxisTickGridPadding.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.Color.Black
            Me.label2.Location = New System.Drawing.Point(4, 65)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(55, 13)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Tick Color"
            '
            'cpXAxisTickColor
            '
            Me.cpXAxisTickColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cpXAxisTickColor.ColorUISize = New System.Drawing.Size(208, 230)
            Me.cpXAxisTickColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cpXAxisTickColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.cpXAxisTickColor.ForeColor = System.Drawing.Color.Black
            Me.cpXAxisTickColor.Location = New System.Drawing.Point(130, 65)
            Me.cpXAxisTickColor.Name = "cpXAxisTickColor"
            Me.cpXAxisTickColor.SelectedAsBackcolor = True
            Me.cpXAxisTickColor.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.cpXAxisTickColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.cpXAxisTickColor.Size = New System.Drawing.Size(20, 20)
            Me.cpXAxisTickColor.TabIndex = 6
            Me.cpXAxisTickColor.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(4, 93)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(118, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Small Ticks Per Interval"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label4.ForeColor = System.Drawing.Color.Black
            Me.label4.Location = New System.Drawing.Point(4, 121)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(121, 13)
            Me.label4.TabIndex = 7
            Me.label4.Text = "Tick Label Grid Padding"
            '
            'nUDXAxisTicksPerInterval
            '
            Me.nUDXAxisTicksPerInterval.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.nUDXAxisTicksPerInterval.ForeColor = System.Drawing.Color.Black
            Me.nUDXAxisTicksPerInterval.Location = New System.Drawing.Point(130, 93)
            Me.nUDXAxisTicksPerInterval.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.nUDXAxisTicksPerInterval.Name = "nUDXAxisTicksPerInterval"
            Me.nUDXAxisTicksPerInterval.Size = New System.Drawing.Size(36, 20)
            Me.nUDXAxisTicksPerInterval.TabIndex = 2
            Me.nUDXAxisTicksPerInterval.Value = New Decimal(New Integer() {5, 0, 0, 0})
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(654, 639)
            Me.Controls.Add(Me.gradientPanel1)
            Me.Controls.Add(Me.designerPanel2)
            Me.Controls.Add(Me.designerPanel1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Tick Marks"
            Me.chartControl1.ResumeLayout(False)
            Me.chartControl1.PerformLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            CType(Me.designerPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel2.ResumeLayout(False)
            Me.designerPanel2.PerformLayout()
            CType(Me.nUDYAxisTickWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDYAxisTickHeight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDYAxisTickGridPadding, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDYAxisSmallTickWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDYAxisSmallTickHeight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDYAxisTicksPerInterval, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel1.ResumeLayout(False)
            Me.designerPanel1.PerformLayout()
            CType(Me.nUDXAxisTickWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDXAxisTickHeight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDXAxisSmallTickWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDXAxisSmallTickHeight, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDXAxisTickGridPadding, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.nUDXAxisTicksPerInterval, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private designerPanel1 As DesignerPanel
        Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
        Private WithEvents cbXAxisDrawLabelGrid As System.Windows.Forms.CheckBox
        Private label2 As System.Windows.Forms.Label
        Private WithEvents nUDXAxisTicksPerInterval As System.Windows.Forms.NumericUpDown
        Private label1 As System.Windows.Forms.Label
        Private WithEvents nUDXAxisTickGridPadding As System.Windows.Forms.NumericUpDown
        Private label4 As System.Windows.Forms.Label
        Public WithEvents cpXAxisTickColor As Syncfusion.Windows.Forms.ColorPickerButton
        Private WithEvents nUDXAxisSmallTickHeight As System.Windows.Forms.NumericUpDown
        Private label6 As System.Windows.Forms.Label
        Private designerPanel2 As DesignerPanel
        Private WithEvents nUDYAxisTickGridPadding As System.Windows.Forms.NumericUpDown
        Private label5 As System.Windows.Forms.Label
        Private WithEvents cbYAxisDrawLabelGrid As System.Windows.Forms.CheckBox
        Private label7 As System.Windows.Forms.Label
        Public WithEvents cpYAxisTickColor As Syncfusion.Windows.Forms.ColorPickerButton
        Private label8 As System.Windows.Forms.Label
        Private WithEvents nUDYAxisTicksPerInterval As System.Windows.Forms.NumericUpDown
        Private label10 As System.Windows.Forms.Label
        Private chartTitle1 As Syncfusion.Windows.Forms.Chart.ChartTitle
        Private WithEvents nUDXAxisSmallTickWidth As System.Windows.Forms.NumericUpDown
        Private label13 As System.Windows.Forms.Label
        Private label11 As System.Windows.Forms.Label
        Private WithEvents nUDYAxisSmallTickWidth As System.Windows.Forms.NumericUpDown
        Private label12 As System.Windows.Forms.Label
        Private label14 As System.Windows.Forms.Label
        Private WithEvents nUDYAxisSmallTickHeight As System.Windows.Forms.NumericUpDown
        Private WithEvents nUDXAxisTickWidth As System.Windows.Forms.NumericUpDown
        Private label3 As System.Windows.Forms.Label
        Private label9 As System.Windows.Forms.Label
        Private WithEvents nUDXAxisTickHeight As System.Windows.Forms.NumericUpDown
        Private label15 As System.Windows.Forms.Label
        Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private label40 As System.Windows.Forms.Label
        Private WithEvents nUDYAxisTickWidth As System.Windows.Forms.NumericUpDown
        Private label16 As System.Windows.Forms.Label
        Private label17 As System.Windows.Forms.Label
        Private WithEvents nUDYAxisTickHeight As System.Windows.Forms.NumericUpDown
        Private label18 As System.Windows.Forms.Label
        Private richTextBox1 As System.Windows.Forms.RichTextBox


    End Class
End Namespace

