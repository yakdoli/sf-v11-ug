Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing.Drawing2D

Namespace ChartLegendSample
    Public Class Form1
        Inherits Office2007Form

#Region "Private Members"


        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents cmbLegendType As System.Windows.Forms.ComboBox
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label8 As Label
        Private WithEvents label10 As Label
        Private WithEvents comboBox4 As ComboBox
        Private WithEvents comboBox1 As ComboBox
        Private WithEvents comboBox5 As ComboBox
        Private WithEvents label7 As Label
        Private WithEvents label12 As Label
        Private WithEvents label13 As Label
        Private WithEvents comboBox_FontStyle As ComboBox
        Private WithEvents panel9 As Panel
        Private WithEvents textBox_TextColor As TextBox
        Private WithEvents colorPicker_TextColor As ColorPickerButton
        Private WithEvents numericUpDown_FontSize As NumericUpDown
        Private WithEvents comboBox_Fontfamily As ComboBox
        Private WithEvents panel2 As Panel
        Private WithEvents textBox1 As TextBox
        Private WithEvents colorPickerButton1 As ColorPickerButton
        Private WithEvents comboBox2 As ComboBox
        Private WithEvents label19 As Label
        Private WithEvents panel3 As Panel
        Private WithEvents textBox2 As TextBox
        Private WithEvents colorPickerButton2 As ColorPickerButton
        Private WithEvents label18 As Label
        Private WithEvents label17 As Label
        Private WithEvents checkBox1 As CheckBox
        Private WithEvents label5 As Label
        Private WithEvents panel4 As Panel
        Private WithEvents textBox3 As TextBox
        Private WithEvents colorPickerButton3 As ColorPickerButton
        Private WithEvents label21 As Label
        Private WithEvents textBox4 As TextBox
        Private WithEvents label22 As Label
        Private WithEvents panel5 As Panel
        Private WithEvents textBox5 As TextBox
        Private WithEvents colorPickerButton4 As ColorPickerButton
        Private WithEvents label23 As Label
        Private WithEvents comboBox3 As ComboBox
        Private WithEvents label26 As Label
        Private WithEvents numericUpDown2 As NumericUpDown
        Private WithEvents label27 As Label
        Private WithEvents numericUpDown3 As NumericUpDown
        Private WithEvents label28 As Label
        Private WithEvents comboBox6 As ComboBox
        Private WithEvents comboBox7 As ComboBox
        Private WithEvents label29 As Label
        Private WithEvents checkBox2 As CheckBox
        Private WithEvents checkBox4 As CheckBox
        Private WithEvents label30 As Label
        Private WithEvents toolTip1 As ToolTip
        Private WithEvents checkBox5 As CheckBox
        Private WithEvents label31 As Label
        Private WithEvents comboBox8 As ComboBox
        Private WithEvents label9 As Label
        Private WithEvents label11 As Label
        Private WithEvents numericUpDown5 As NumericUpDown
        Private WithEvents checkBox7 As CheckBox
        Private WithEvents label34 As Label
        Private WithEvents panel7 As Panel
        Private WithEvents textBox6 As TextBox
        Private WithEvents colorPickerButton5 As ColorPickerButton
        Private WithEvents imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
        Private WithEvents comboBox9 As ComboBox
        Private WithEvents label42 As Label
        Private WithEvents chartControl1 As ChartControl
        Private WithEvents designerPanel1 As DesignerPanel
        Private WithEvents designerPanel2 As DesignerPanel
        Private WithEvents designerPanel3 As DesignerPanel
        Private WithEvents designerPanel4 As DesignerPanel
        Private WithEvents designerPanel5 As DesignerPanel
        Private WithEvents designerPanel6 As DesignerPanel
        Private WithEvents designerPanel7 As DesignerPanel
        Private WithEvents label1 As Label
        Private WithEvents label2 As Label
        Private WithEvents ComboBox10 As System.Windows.Forms.ComboBox
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents components As System.ComponentModel.IContainer
#End Region

#Region "Form Constructor, Main And Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.designerPanel7 = New DesignerPanel
            Me.panel4 = New System.Windows.Forms.Panel
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.colorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label2 = New System.Windows.Forms.Label
            Me.comboBox3 = New System.Windows.Forms.ComboBox
            Me.label21 = New System.Windows.Forms.Label
            Me.label23 = New System.Windows.Forms.Label
            Me.panel5 = New System.Windows.Forms.Panel
            Me.textBox5 = New System.Windows.Forms.TextBox
            Me.colorPickerButton4 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label22 = New System.Windows.Forms.Label
            Me.textBox4 = New System.Windows.Forms.TextBox
            Me.label5 = New System.Windows.Forms.Label
            Me.designerPanel6 = New DesignerPanel
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox5 = New System.Windows.Forms.CheckBox
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.label30 = New System.Windows.Forms.Label
            Me.cmbLegendType = New System.Windows.Forms.ComboBox
            Me.label42 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label31 = New System.Windows.Forms.Label
            Me.comboBox9 = New System.Windows.Forms.ComboBox
            Me.designerPanel5 = New DesignerPanel
            Me.ComboBox10 = New System.Windows.Forms.ComboBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.comboBox5 = New System.Windows.Forms.ComboBox
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.label10 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.designerPanel4 = New DesignerPanel
            Me.label26 = New System.Windows.Forms.Label
            Me.comboBox7 = New System.Windows.Forms.ComboBox
            Me.label29 = New System.Windows.Forms.Label
            Me.label27 = New System.Windows.Forms.Label
            Me.comboBox6 = New System.Windows.Forms.ComboBox
            Me.label28 = New System.Windows.Forms.Label
            Me.numericUpDown2 = New System.Windows.Forms.NumericUpDown
            Me.numericUpDown3 = New System.Windows.Forms.NumericUpDown
            Me.designerPanel3 = New DesignerPanel
            Me.label12 = New System.Windows.Forms.Label
            Me.label7 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.label13 = New System.Windows.Forms.Label
            Me.numericUpDown_FontSize = New System.Windows.Forms.NumericUpDown
            Me.panel9 = New System.Windows.Forms.Panel
            Me.textBox_TextColor = New System.Windows.Forms.TextBox
            Me.colorPicker_TextColor = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.comboBox_Fontfamily = New System.Windows.Forms.ComboBox
            Me.comboBox_FontStyle = New System.Windows.Forms.ComboBox
            Me.designerPanel2 = New DesignerPanel
            Me.checkBox7 = New System.Windows.Forms.CheckBox
            Me.label9 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.comboBox8 = New System.Windows.Forms.ComboBox
            Me.label34 = New System.Windows.Forms.Label
            Me.numericUpDown5 = New System.Windows.Forms.NumericUpDown
            Me.panel7 = New System.Windows.Forms.Panel
            Me.textBox6 = New System.Windows.Forms.TextBox
            Me.colorPickerButton5 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.designerPanel1 = New DesignerPanel
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.label19 = New System.Windows.Forms.Label
            Me.panel3 = New System.Windows.Forms.Panel
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label17 = New System.Windows.Forms.Label
            Me.label18 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            CType(Me.designerPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel7.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.panel5.SuspendLayout()
            CType(Me.designerPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel6.SuspendLayout()
            CType(Me.designerPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel5.SuspendLayout()
            CType(Me.designerPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel4.SuspendLayout()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.designerPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel3.SuspendLayout()
            CType(Me.numericUpDown_FontSize, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel9.SuspendLayout()
            CType(Me.designerPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel2.SuspendLayout()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel7.SuspendLayout()
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel1.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images2"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images3"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images4"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images5"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images6"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images7"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images8"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images9"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images10"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images11"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images12"), System.Drawing.Image)})
            '
            'chartControl1
            '
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.chartControl1.BorderAppearance.FrameThickness = New Syncfusion.Windows.Forms.Chart.ChartThickness(1.0!, 1.0!, 2.0!, 2.0!)
            Me.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.Red
            Me.chartControl1.BorderAppearance.Interior.Width = 1.0!
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(212, 305)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Legend.RowsCount = 2
            Me.chartControl1.Legend.Spacing = 9
            Me.chartControl1.Location = New System.Drawing.Point(13, 14)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.DrawGrid = False
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 6, 1)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(-100, 500, 100)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.Size = New System.Drawing.Size(503, 401)
            Me.chartControl1.TabIndex = 4
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
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
            Me.chartControl1.ZoomOutIncrement = 0.20000000298023224
            '
            'designerPanel7
            '
            Me.designerPanel7.BackColor = System.Drawing.Color.White
            Me.designerPanel7.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel7.Controls.Add(Me.panel4)
            Me.designerPanel7.Controls.Add(Me.checkBox1)
            Me.designerPanel7.Controls.Add(Me.label2)
            Me.designerPanel7.Controls.Add(Me.comboBox3)
            Me.designerPanel7.Controls.Add(Me.label21)
            Me.designerPanel7.Controls.Add(Me.label23)
            Me.designerPanel7.Controls.Add(Me.panel5)
            Me.designerPanel7.Controls.Add(Me.label22)
            Me.designerPanel7.Controls.Add(Me.textBox4)
            Me.designerPanel7.Controls.Add(Me.label5)
            Me.designerPanel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel7.HeaderImage = CType(resources.GetObject("designerPanel7.HeaderImage"), System.Drawing.Image)
            Me.designerPanel7.HeaderText = "       Title And Shadow"
            Me.designerPanel7.Location = New System.Drawing.Point(600, 421)
            Me.designerPanel7.Name = "designerPanel7"
            Me.designerPanel7.Size = New System.Drawing.Size(190, 150)
            Me.designerPanel7.TabIndex = 144
            '
            'panel4
            '
            Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel4.Controls.Add(Me.textBox3)
            Me.panel4.Controls.Add(Me.colorPickerButton3)
            Me.panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.panel4.ForeColor = System.Drawing.Color.Black
            Me.panel4.Location = New System.Drawing.Point(88, 127)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(43, 19)
            Me.panel4.TabIndex = 96
            '
            'textBox3
            '
            Me.textBox3.BackColor = System.Drawing.Color.Black
            Me.textBox3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox3.Location = New System.Drawing.Point(0, 0)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.ReadOnly = True
            Me.textBox3.Size = New System.Drawing.Size(24, 20)
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
            Me.colorPickerButton3.Image = CType(resources.GetObject("colorPickerButton3.Image"), System.Drawing.Image)
            Me.colorPickerButton3.Location = New System.Drawing.Point(24, 0)
            Me.colorPickerButton3.Name = "colorPickerButton3"
            Me.colorPickerButton3.SelectedAsBackcolor = True
            Me.colorPickerButton3.SelectedColor = System.Drawing.Color.Black
            Me.colorPickerButton3.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton3.Size = New System.Drawing.Size(17, 17)
            Me.colorPickerButton3.TabIndex = 14
            Me.colorPickerButton3.Text = "..."
            Me.colorPickerButton3.UseVisualStyleBackColor = False
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.checkBox1.ForeColor = System.Drawing.Color.Black
            Me.checkBox1.Location = New System.Drawing.Point(88, 105)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(35, 18)
            Me.checkBox1.TabIndex = 95
            Me.checkBox1.Text = " "
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.Color.Black
            Me.label2.Location = New System.Drawing.Point(9, 105)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(79, 13)
            Me.label2.TabIndex = 102
            Me.label2.Text = "Shadow Visible"
            '
            'comboBox3
            '
            Me.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox3.ForeColor = System.Drawing.Color.Black
            Me.comboBox3.FormattingEnabled = True
            Me.comboBox3.Items.AddRange(New Object() {"Near", "Center", "Far"})
            Me.comboBox3.Location = New System.Drawing.Point(88, 80)
            Me.comboBox3.Name = "comboBox3"
            Me.comboBox3.Size = New System.Drawing.Size(90, 21)
            Me.comboBox3.TabIndex = 101
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label21.ForeColor = System.Drawing.Color.Black
            Me.label21.Location = New System.Drawing.Point(9, 31)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(51, 13)
            Me.label21.TabIndex = 95
            Me.label21.Text = "Title Text"
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label23.ForeColor = System.Drawing.Color.Black
            Me.label23.Location = New System.Drawing.Point(9, 80)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(76, 13)
            Me.label23.TabIndex = 100
            Me.label23.Text = "Title Alignment"
            '
            'panel5
            '
            Me.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel5.Controls.Add(Me.textBox5)
            Me.panel5.Controls.Add(Me.colorPickerButton4)
            Me.panel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.panel5.ForeColor = System.Drawing.Color.Black
            Me.panel5.Location = New System.Drawing.Point(88, 55)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(41, 19)
            Me.panel5.TabIndex = 99
            '
            'textBox5
            '
            Me.textBox5.BackColor = System.Drawing.Color.Black
            Me.textBox5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox5.Location = New System.Drawing.Point(0, 0)
            Me.textBox5.Name = "textBox5"
            Me.textBox5.ReadOnly = True
            Me.textBox5.Size = New System.Drawing.Size(22, 20)
            Me.textBox5.TabIndex = 11
            '
            'colorPickerButton4
            '
            Me.colorPickerButton4.BackColor = System.Drawing.Color.Black
            Me.colorPickerButton4.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton4.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton4.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton4.Image = CType(resources.GetObject("colorPickerButton4.Image"), System.Drawing.Image)
            Me.colorPickerButton4.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton4.Name = "colorPickerButton4"
            Me.colorPickerButton4.SelectedAsBackcolor = True
            Me.colorPickerButton4.SelectedColor = System.Drawing.Color.Black
            Me.colorPickerButton4.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton4.Size = New System.Drawing.Size(17, 17)
            Me.colorPickerButton4.TabIndex = 14
            Me.colorPickerButton4.Text = "..."
            Me.colorPickerButton4.UseVisualStyleBackColor = False
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label22.ForeColor = System.Drawing.Color.Black
            Me.label22.Location = New System.Drawing.Point(9, 55)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(54, 13)
            Me.label22.TabIndex = 98
            Me.label22.Text = "Title Color"
            '
            'textBox4
            '
            Me.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.textBox4.ForeColor = System.Drawing.Color.Black
            Me.textBox4.Location = New System.Drawing.Point(88, 31)
            Me.textBox4.Name = "textBox4"
            Me.textBox4.Size = New System.Drawing.Size(90, 20)
            Me.textBox4.TabIndex = 96
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label5.ForeColor = System.Drawing.Color.Black
            Me.label5.Location = New System.Drawing.Point(9, 127)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(73, 13)
            Me.label5.TabIndex = 97
            Me.label5.Text = "Shadow Color"
            '
            'designerPanel6
            '
            Me.designerPanel6.BackColor = System.Drawing.Color.White
            Me.designerPanel6.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel6.Controls.Add(Me.checkBox2)
            Me.designerPanel6.Controls.Add(Me.checkBox5)
            Me.designerPanel6.Controls.Add(Me.checkBox4)
            Me.designerPanel6.Controls.Add(Me.label30)
            Me.designerPanel6.Controls.Add(Me.cmbLegendType)
            Me.designerPanel6.Controls.Add(Me.label42)
            Me.designerPanel6.Controls.Add(Me.label4)
            Me.designerPanel6.Controls.Add(Me.label31)
            Me.designerPanel6.Controls.Add(Me.comboBox9)
            Me.designerPanel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel6.HeaderImage = CType(resources.GetObject("designerPanel6.HeaderImage"), System.Drawing.Image)
            Me.designerPanel6.HeaderText = "       Item Representation"
            Me.designerPanel6.Location = New System.Drawing.Point(403, 421)
            Me.designerPanel6.Name = "designerPanel6"
            Me.designerPanel6.Size = New System.Drawing.Size(190, 150)
            Me.designerPanel6.TabIndex = 144
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.checkBox2.ForeColor = System.Drawing.Color.Black
            Me.checkBox2.Location = New System.Drawing.Point(12, 30)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(111, 18)
            Me.checkBox2.TabIndex = 111
            Me.checkBox2.Text = "Show CheckBox"
            '
            'checkBox5
            '
            Me.checkBox5.AutoSize = True
            Me.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.checkBox5.ForeColor = System.Drawing.Color.Black
            Me.checkBox5.Location = New System.Drawing.Point(12, 79)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(99, 18)
            Me.checkBox5.TabIndex = 117
            Me.checkBox5.Text = "Custom Image"
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.checkBox4.ForeColor = System.Drawing.Color.Black
            Me.checkBox4.Location = New System.Drawing.Point(12, 54)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(96, 18)
            Me.checkBox4.TabIndex = 115
            Me.checkBox4.Text = "Show Symbol"
            '
            'label30
            '
            Me.label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label30.ForeColor = System.Drawing.Color.Black
            Me.label30.Image = CType(resources.GetObject("label30.Image"), System.Drawing.Image)
            Me.label30.Location = New System.Drawing.Point(114, 54)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(20, 20)
            Me.label30.TabIndex = 116
            Me.toolTip1.SetToolTip(Me.label30, "Coded to add a symbol in series 2. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hence legend item 2 alone will show " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "symbol" & _
                    "")
            '
            'cmbLegendType
            '
            Me.cmbLegendType.Cursor = System.Windows.Forms.Cursors.Hand
            Me.cmbLegendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cmbLegendType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.cmbLegendType.ForeColor = System.Drawing.Color.Black
            Me.cmbLegendType.Location = New System.Drawing.Point(79, 126)
            Me.cmbLegendType.Name = "cmbLegendType"
            Me.cmbLegendType.Size = New System.Drawing.Size(90, 21)
            Me.cmbLegendType.TabIndex = 4
            '
            'label42
            '
            Me.label42.AutoSize = True
            Me.label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label42.ForeColor = System.Drawing.Color.Black
            Me.label42.Location = New System.Drawing.Point(12, 102)
            Me.label42.Name = "label42"
            Me.label42.Size = New System.Drawing.Size(52, 13)
            Me.label42.TabIndex = 138
            Me.label42.Text = "Hide Item"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label4.ForeColor = System.Drawing.Color.Black
            Me.label4.Location = New System.Drawing.Point(12, 126)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(31, 13)
            Me.label4.TabIndex = 6
            Me.label4.Text = "Type"
            '
            'label31
            '
            Me.label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label31.ForeColor = System.Drawing.Color.Black
            Me.label31.Image = CType(resources.GetObject("label31.Image"), System.Drawing.Image)
            Me.label31.Location = New System.Drawing.Point(115, 79)
            Me.label31.Name = "label31"
            Me.label31.Size = New System.Drawing.Size(20, 20)
            Me.label31.TabIndex = 118
            Me.toolTip1.SetToolTip(Me.label31, "Programmed to show a custom image in legend item 1")
            '
            'comboBox9
            '
            Me.comboBox9.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox9.ForeColor = System.Drawing.Color.Black
            Me.comboBox9.Items.AddRange(New Object() {"Anguilla", "Argentina", "Bahamas", "Belize", "Bolivia", "Canada", "Chile", "Colombia", "None"})
            Me.comboBox9.Location = New System.Drawing.Point(79, 102)
            Me.comboBox9.Name = "comboBox9"
            Me.comboBox9.Size = New System.Drawing.Size(90, 21)
            Me.comboBox9.TabIndex = 137
            '
            'designerPanel5
            '
            Me.designerPanel5.BackColor = System.Drawing.Color.White
            Me.designerPanel5.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel5.Controls.Add(Me.ComboBox10)
            Me.designerPanel5.Controls.Add(Me.Label6)
            Me.designerPanel5.Controls.Add(Me.label3)
            Me.designerPanel5.Controls.Add(Me.comboBox5)
            Me.designerPanel5.Controls.Add(Me.comboBox1)
            Me.designerPanel5.Controls.Add(Me.comboBox4)
            Me.designerPanel5.Controls.Add(Me.label10)
            Me.designerPanel5.Controls.Add(Me.label8)
            Me.designerPanel5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel5.HeaderImage = CType(resources.GetObject("designerPanel5.HeaderImage"), System.Drawing.Image)
            Me.designerPanel5.HeaderText = "       Item Alignment"
            Me.designerPanel5.Location = New System.Drawing.Point(10, 421)
            Me.designerPanel5.Name = "designerPanel5"
            Me.designerPanel5.Size = New System.Drawing.Size(190, 150)
            Me.designerPanel5.TabIndex = 143
            '
            'ComboBox10
            '
            Me.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.ComboBox10.ForeColor = System.Drawing.Color.Black
            Me.ComboBox10.FormattingEnabled = True
            Me.ComboBox10.Items.AddRange(New Object() {"All", "Dockable", "Movable", "None"})
            Me.ComboBox10.Location = New System.Drawing.Point(88, 105)
            Me.ComboBox10.Name = "ComboBox10"
            Me.ComboBox10.Size = New System.Drawing.Size(90, 21)
            Me.ComboBox10.TabIndex = 81
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Location = New System.Drawing.Point(15, 107)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(49, 13)
            Me.Label6.TabIndex = 80
            Me.Label6.Text = "Behavior"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label3.ForeColor = System.Drawing.Color.Black
            Me.label3.Location = New System.Drawing.Point(15, 31)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(57, 13)
            Me.label3.TabIndex = 6
            Me.label3.Text = "Placement"
            '
            'comboBox5
            '
            Me.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox5.ForeColor = System.Drawing.Color.Black
            Me.comboBox5.FormattingEnabled = True
            Me.comboBox5.Items.AddRange(New Object() {"Near", "Center", "Far"})
            Me.comboBox5.Location = New System.Drawing.Point(88, 80)
            Me.comboBox5.Name = "comboBox5"
            Me.comboBox5.Size = New System.Drawing.Size(90, 21)
            Me.comboBox5.TabIndex = 79
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox1.ForeColor = System.Drawing.Color.Black
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Left", "Right", "Top", "Bottom", "Floating"})
            Me.comboBox1.Location = New System.Drawing.Point(88, 55)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(90, 21)
            Me.comboBox1.TabIndex = 78
            '
            'comboBox4
            '
            Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox4.ForeColor = System.Drawing.Color.Black
            Me.comboBox4.FormattingEnabled = True
            Me.comboBox4.Items.AddRange(New Object() {"Inside", "Outside"})
            Me.comboBox4.Location = New System.Drawing.Point(88, 31)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(90, 21)
            Me.comboBox4.TabIndex = 77
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label10.ForeColor = System.Drawing.Color.Black
            Me.label10.Location = New System.Drawing.Point(15, 80)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(53, 13)
            Me.label10.TabIndex = 74
            Me.label10.Text = "Alignment"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label8.ForeColor = System.Drawing.Color.Black
            Me.label8.Location = New System.Drawing.Point(15, 55)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(44, 13)
            Me.label8.TabIndex = 73
            Me.label8.Text = "Position"
            '
            'designerPanel4
            '
            Me.designerPanel4.BackColor = System.Drawing.Color.White
            Me.designerPanel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel4.Controls.Add(Me.label26)
            Me.designerPanel4.Controls.Add(Me.comboBox7)
            Me.designerPanel4.Controls.Add(Me.label29)
            Me.designerPanel4.Controls.Add(Me.label27)
            Me.designerPanel4.Controls.Add(Me.comboBox6)
            Me.designerPanel4.Controls.Add(Me.label28)
            Me.designerPanel4.Controls.Add(Me.numericUpDown2)
            Me.designerPanel4.Controls.Add(Me.numericUpDown3)
            Me.designerPanel4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel4.HeaderImage = CType(resources.GetObject("designerPanel4.HeaderImage"), System.Drawing.Image)
            Me.designerPanel4.HeaderText = "       Items Position"
            Me.designerPanel4.Location = New System.Drawing.Point(206, 421)
            Me.designerPanel4.Name = "designerPanel4"
            Me.designerPanel4.Size = New System.Drawing.Size(190, 150)
            Me.designerPanel4.TabIndex = 142
            '
            'label26
            '
            Me.label26.AutoSize = True
            Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label26.ForeColor = System.Drawing.Color.Black
            Me.label26.Location = New System.Drawing.Point(7, 31)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(60, 13)
            Me.label26.TabIndex = 104
            Me.label26.Text = "Row Count"
            '
            'comboBox7
            '
            Me.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox7.FormattingEnabled = True
            Me.comboBox7.Items.AddRange(New Object() {"Bottom", "Center", "Top"})
            Me.comboBox7.Location = New System.Drawing.Point(87, 118)
            Me.comboBox7.Name = "comboBox7"
            Me.comboBox7.Size = New System.Drawing.Size(90, 21)
            Me.comboBox7.TabIndex = 110
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label29.ForeColor = System.Drawing.Color.Black
            Me.label29.Location = New System.Drawing.Point(7, 118)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(77, 13)
            Me.label29.TabIndex = 109
            Me.label29.Text = "Text Alignment"
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label27.ForeColor = System.Drawing.Color.Black
            Me.label27.Location = New System.Drawing.Point(7, 60)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(46, 13)
            Me.label27.TabIndex = 106
            Me.label27.Text = "Spacing"
            '
            'comboBox6
            '
            Me.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox6.FormattingEnabled = True
            Me.comboBox6.Items.AddRange(New Object() {"Near", "Center", "Far"})
            Me.comboBox6.Location = New System.Drawing.Point(87, 93)
            Me.comboBox6.Name = "comboBox6"
            Me.comboBox6.Size = New System.Drawing.Size(90, 21)
            Me.comboBox6.TabIndex = 108
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label28.ForeColor = System.Drawing.Color.Black
            Me.label28.Location = New System.Drawing.Point(7, 93)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(76, 13)
            Me.label28.TabIndex = 107
            Me.label28.Text = "Item Alignment"
            '
            'numericUpDown2
            '
            Me.numericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.numericUpDown2.Location = New System.Drawing.Point(87, 31)
            Me.numericUpDown2.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
            Me.numericUpDown2.Name = "numericUpDown2"
            Me.numericUpDown2.Size = New System.Drawing.Size(38, 20)
            Me.numericUpDown2.TabIndex = 103
            Me.numericUpDown2.Value = New Decimal(New Integer() {2, 0, 0, 0})
            '
            'numericUpDown3
            '
            Me.numericUpDown3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.numericUpDown3.Location = New System.Drawing.Point(87, 60)
            Me.numericUpDown3.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
            Me.numericUpDown3.Name = "numericUpDown3"
            Me.numericUpDown3.Size = New System.Drawing.Size(38, 20)
            Me.numericUpDown3.TabIndex = 105
            Me.numericUpDown3.Value = New Decimal(New Integer() {9, 0, 0, 0})
            '
            'designerPanel3
            '
            Me.designerPanel3.BackColor = System.Drawing.Color.White
            Me.designerPanel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel3.Controls.Add(Me.label12)
            Me.designerPanel3.Controls.Add(Me.label7)
            Me.designerPanel3.Controls.Add(Me.label1)
            Me.designerPanel3.Controls.Add(Me.label13)
            Me.designerPanel3.Controls.Add(Me.numericUpDown_FontSize)
            Me.designerPanel3.Controls.Add(Me.panel9)
            Me.designerPanel3.Controls.Add(Me.comboBox_Fontfamily)
            Me.designerPanel3.Controls.Add(Me.comboBox_FontStyle)
            Me.designerPanel3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel3.HeaderImage = CType(resources.GetObject("designerPanel3.HeaderImage"), System.Drawing.Image)
            Me.designerPanel3.HeaderText = "       Font Settings"
            Me.designerPanel3.Location = New System.Drawing.Point(538, 280)
            Me.designerPanel3.Name = "designerPanel3"
            Me.designerPanel3.Size = New System.Drawing.Size(256, 127)
            Me.designerPanel3.TabIndex = 141
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label12.ForeColor = System.Drawing.Color.Black
            Me.label12.Location = New System.Drawing.Point(9, 42)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(60, 13)
            Me.label12.TabIndex = 88
            Me.label12.Text = "Font Family"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label7.ForeColor = System.Drawing.Color.Black
            Me.label7.Location = New System.Drawing.Point(9, 96)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(51, 13)
            Me.label7.TabIndex = 92
            Me.label7.Text = "Font Size"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Location = New System.Drawing.Point(125, 98)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(55, 13)
            Me.label1.TabIndex = 93
            Me.label1.Text = "Font Color"
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label13.ForeColor = System.Drawing.Color.Black
            Me.label13.Location = New System.Drawing.Point(9, 69)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(54, 13)
            Me.label13.TabIndex = 91
            Me.label13.Text = "Font Style"
            '
            'numericUpDown_FontSize
            '
            Me.numericUpDown_FontSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.numericUpDown_FontSize.ForeColor = System.Drawing.Color.Black
            Me.numericUpDown_FontSize.Location = New System.Drawing.Point(76, 96)
            Me.numericUpDown_FontSize.Maximum = New Decimal(New Integer() {14, 0, 0, 0})
            Me.numericUpDown_FontSize.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
            Me.numericUpDown_FontSize.Name = "numericUpDown_FontSize"
            Me.numericUpDown_FontSize.Size = New System.Drawing.Size(41, 20)
            Me.numericUpDown_FontSize.TabIndex = 90
            Me.numericUpDown_FontSize.Value = New Decimal(New Integer() {8, 0, 0, 0})
            '
            'panel9
            '
            Me.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel9.Controls.Add(Me.textBox_TextColor)
            Me.panel9.Controls.Add(Me.colorPicker_TextColor)
            Me.panel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.panel9.ForeColor = System.Drawing.Color.Black
            Me.panel9.Location = New System.Drawing.Point(192, 97)
            Me.panel9.Name = "panel9"
            Me.panel9.Size = New System.Drawing.Size(41, 19)
            Me.panel9.TabIndex = 85
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
            Me.colorPicker_TextColor.Size = New System.Drawing.Size(17, 17)
            Me.colorPicker_TextColor.TabIndex = 14
            Me.colorPicker_TextColor.Text = "..."
            Me.colorPicker_TextColor.UseVisualStyleBackColor = False
            '
            'comboBox_Fontfamily
            '
            Me.comboBox_Fontfamily.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBox_Fontfamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_Fontfamily.DropDownWidth = 150
            Me.comboBox_Fontfamily.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox_Fontfamily.ForeColor = System.Drawing.Color.Black
            Me.comboBox_Fontfamily.Items.AddRange(New Object() {"Agency FB", "Arial", "Book Antiqua", "Bookman Old Style", "Bradley Hand ITC", "Courier New", "Calibri", "Curlz MT", "Estrangelo Edessa", "Felix Titling", "Gautami", "Gill Sans MT Ext Condensed Bold", "Impact", "Microsoft Sans Serif", "MS Outlook", "Pristina", "Raavi", "Symbol", "Tahoma", "Times New Roman", "Verdana"})
            Me.comboBox_Fontfamily.Location = New System.Drawing.Point(75, 42)
            Me.comboBox_Fontfamily.Name = "comboBox_Fontfamily"
            Me.comboBox_Fontfamily.Size = New System.Drawing.Size(158, 21)
            Me.comboBox_Fontfamily.TabIndex = 87
            '
            'comboBox_FontStyle
            '
            Me.comboBox_FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox_FontStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox_FontStyle.ForeColor = System.Drawing.Color.Black
            Me.comboBox_FontStyle.FormattingEnabled = True
            Me.comboBox_FontStyle.Location = New System.Drawing.Point(75, 69)
            Me.comboBox_FontStyle.Name = "comboBox_FontStyle"
            Me.comboBox_FontStyle.Size = New System.Drawing.Size(157, 21)
            Me.comboBox_FontStyle.TabIndex = 89
            '
            'designerPanel2
            '
            Me.designerPanel2.BackColor = System.Drawing.Color.White
            Me.designerPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel2.Controls.Add(Me.checkBox7)
            Me.designerPanel2.Controls.Add(Me.label9)
            Me.designerPanel2.Controls.Add(Me.label11)
            Me.designerPanel2.Controls.Add(Me.comboBox8)
            Me.designerPanel2.Controls.Add(Me.label34)
            Me.designerPanel2.Controls.Add(Me.numericUpDown5)
            Me.designerPanel2.Controls.Add(Me.panel7)
            Me.designerPanel2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel2.HeaderImage = CType(resources.GetObject("designerPanel2.HeaderImage"), System.Drawing.Image)
            Me.designerPanel2.HeaderText = "       Border Settings"
            Me.designerPanel2.Location = New System.Drawing.Point(538, 135)
            Me.designerPanel2.Name = "designerPanel2"
            Me.designerPanel2.Size = New System.Drawing.Size(256, 130)
            Me.designerPanel2.TabIndex = 140
            '
            'checkBox7
            '
            Me.checkBox7.AutoSize = True
            Me.checkBox7.Checked = True
            Me.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.checkBox7.ForeColor = System.Drawing.Color.Black
            Me.checkBox7.Location = New System.Drawing.Point(18, 36)
            Me.checkBox7.Name = "checkBox7"
            Me.checkBox7.Size = New System.Drawing.Size(87, 17)
            Me.checkBox7.TabIndex = 102
            Me.checkBox7.Text = "Show Border"
            Me.checkBox7.UseVisualStyleBackColor = False
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.ForeColor = System.Drawing.Color.Black
            Me.label9.Location = New System.Drawing.Point(15, 65)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(58, 13)
            Me.label9.TabIndex = 100
            Me.label9.Text = "Dash Style"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label11.ForeColor = System.Drawing.Color.Black
            Me.label11.Location = New System.Drawing.Point(15, 97)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(35, 13)
            Me.label11.TabIndex = 104
            Me.label11.Text = "Width"
            '
            'comboBox8
            '
            Me.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox8.FormattingEnabled = True
            Me.comboBox8.Items.AddRange(New Object() {"Solid", "Dash", "Dot", "DashDot", "DashDotDot", "Custom"})
            Me.comboBox8.Location = New System.Drawing.Point(79, 65)
            Me.comboBox8.Name = "comboBox8"
            Me.comboBox8.Size = New System.Drawing.Size(157, 21)
            Me.comboBox8.TabIndex = 101
            '
            'label34
            '
            Me.label34.AutoSize = True
            Me.label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label34.ForeColor = System.Drawing.Color.Black
            Me.label34.Location = New System.Drawing.Point(130, 99)
            Me.label34.Name = "label34"
            Me.label34.Size = New System.Drawing.Size(59, 13)
            Me.label34.TabIndex = 106
            Me.label34.Text = "Back Color"
            '
            'numericUpDown5
            '
            Me.numericUpDown5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDown5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.numericUpDown5.Location = New System.Drawing.Point(80, 97)
            Me.numericUpDown5.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.numericUpDown5.Name = "numericUpDown5"
            Me.numericUpDown5.Size = New System.Drawing.Size(38, 20)
            Me.numericUpDown5.TabIndex = 103
            Me.numericUpDown5.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'panel7
            '
            Me.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel7.Controls.Add(Me.textBox6)
            Me.panel7.Controls.Add(Me.colorPickerButton5)
            Me.panel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.panel7.Location = New System.Drawing.Point(195, 99)
            Me.panel7.Name = "panel7"
            Me.panel7.Size = New System.Drawing.Size(41, 19)
            Me.panel7.TabIndex = 105
            '
            'textBox6
            '
            Me.textBox6.BackColor = System.Drawing.Color.Silver
            Me.textBox6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox6.Location = New System.Drawing.Point(0, 0)
            Me.textBox6.Name = "textBox6"
            Me.textBox6.ReadOnly = True
            Me.textBox6.Size = New System.Drawing.Size(22, 20)
            Me.textBox6.TabIndex = 11
            '
            'colorPickerButton5
            '
            Me.colorPickerButton5.BackColor = System.Drawing.Color.Black
            Me.colorPickerButton5.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton5.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPickerButton5.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPickerButton5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPickerButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPickerButton5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton5.Image = CType(resources.GetObject("colorPickerButton5.Image"), System.Drawing.Image)
            Me.colorPickerButton5.Location = New System.Drawing.Point(22, 0)
            Me.colorPickerButton5.Name = "colorPickerButton5"
            Me.colorPickerButton5.SelectedAsBackcolor = True
            Me.colorPickerButton5.SelectedColor = System.Drawing.Color.Black
            Me.colorPickerButton5.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton5.Size = New System.Drawing.Size(17, 17)
            Me.colorPickerButton5.TabIndex = 14
            Me.colorPickerButton5.Text = "..."
            Me.colorPickerButton5.UseVisualStyleBackColor = False
            '
            'designerPanel1
            '
            Me.designerPanel1.BackColor = System.Drawing.Color.White
            Me.designerPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel1.Controls.Add(Me.comboBox2)
            Me.designerPanel1.Controls.Add(Me.label19)
            Me.designerPanel1.Controls.Add(Me.panel3)
            Me.designerPanel1.Controls.Add(Me.label17)
            Me.designerPanel1.Controls.Add(Me.label18)
            Me.designerPanel1.Controls.Add(Me.panel2)
            Me.designerPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel1.HeaderImage = CType(resources.GetObject("designerPanel1.HeaderImage"), System.Drawing.Image)
            Me.designerPanel1.HeaderText = "       Back Interior"
            Me.designerPanel1.Location = New System.Drawing.Point(538, 14)
            Me.designerPanel1.Name = "designerPanel1"
            Me.designerPanel1.Size = New System.Drawing.Size(252, 108)
            Me.designerPanel1.TabIndex = 139
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.DropDownWidth = 150
            Me.comboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Location = New System.Drawing.Point(78, 42)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(157, 21)
            Me.comboBox2.TabIndex = 93
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label19.ForeColor = System.Drawing.Color.Black
            Me.label19.Location = New System.Drawing.Point(3, 42)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(73, 13)
            Me.label19.TabIndex = 92
            Me.label19.Text = "Gradient Style"
            '
            'panel3
            '
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.textBox2)
            Me.panel3.Controls.Add(Me.colorPickerButton2)
            Me.panel3.Location = New System.Drawing.Point(194, 75)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(41, 19)
            Me.panel3.TabIndex = 91
            '
            'textBox2
            '
            Me.textBox2.BackColor = System.Drawing.Color.White
            Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox2.Location = New System.Drawing.Point(0, 0)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(22, 21)
            Me.textBox2.TabIndex = 11
            '
            'colorPickerButton2
            '
            Me.colorPickerButton2.BackColor = System.Drawing.Color.White
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
            Me.colorPickerButton2.SelectedColor = System.Drawing.Color.White
            Me.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton2.Size = New System.Drawing.Size(17, 17)
            Me.colorPickerButton2.TabIndex = 14
            Me.colorPickerButton2.Text = "..."
            Me.colorPickerButton2.UseVisualStyleBackColor = False
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label17.ForeColor = System.Drawing.Color.Black
            Me.label17.Location = New System.Drawing.Point(125, 75)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(55, 13)
            Me.label17.TabIndex = 89
            Me.label17.Text = "Fore Color"
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label18.ForeColor = System.Drawing.Color.Black
            Me.label18.Location = New System.Drawing.Point(3, 75)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(59, 13)
            Me.label18.TabIndex = 90
            Me.label18.Text = "Back Color"
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Controls.Add(Me.colorPickerButton1)
            Me.panel2.Location = New System.Drawing.Point(78, 75)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(41, 19)
            Me.panel2.TabIndex = 88
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(22, 21)
            Me.textBox1.TabIndex = 11
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
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
            Me.colorPickerButton1.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(247, Byte), Integer))
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(17, 17)
            Me.colorPickerButton1.TabIndex = 14
            Me.colorPickerButton1.Text = "..."
            Me.colorPickerButton1.UseVisualStyleBackColor = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(802, 579)
            Me.Controls.Add(Me.designerPanel7)
            Me.Controls.Add(Me.designerPanel6)
            Me.Controls.Add(Me.designerPanel5)
            Me.Controls.Add(Me.designerPanel4)
            Me.Controls.Add(Me.designerPanel3)
            Me.Controls.Add(Me.designerPanel2)
            Me.Controls.Add(Me.designerPanel1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Legend"
            CType(Me.designerPanel7, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel7.ResumeLayout(False)
            Me.designerPanel7.PerformLayout()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            Me.panel5.ResumeLayout(False)
            Me.panel5.PerformLayout()
            CType(Me.designerPanel6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel6.ResumeLayout(False)
            Me.designerPanel6.PerformLayout()
            CType(Me.designerPanel5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel5.ResumeLayout(False)
            Me.designerPanel5.PerformLayout()
            CType(Me.designerPanel4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel4.ResumeLayout(False)
            Me.designerPanel4.PerformLayout()
            CType(Me.numericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.designerPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel3.ResumeLayout(False)
            Me.designerPanel3.PerformLayout()
            CType(Me.numericUpDown_FontSize, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel9.ResumeLayout(False)
            Me.panel9.PerformLayout()
            CType(Me.designerPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel2.ResumeLayout(False)
            Me.designerPanel2.PerformLayout()
            CType(Me.numericUpDown5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel7.ResumeLayout(False)
            Me.panel7.PerformLayout()
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel1.ResumeLayout(False)
            Me.designerPanel1.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            For Each fontstyle As String In System.Enum.GetNames(GetType(System.Drawing.FontStyle))
                Me.comboBox_FontStyle.Items.Add(fontstyle)
            Next fontstyle

            For Each gradientstyle As String In System.Enum.GetNames(GetType(GradientStyle))
                Me.comboBox2.Items.Add(gradientstyle)
            Next gradientstyle

            Me.comboBox_FontStyle.SelectedIndex = 0
            Me.comboBox_Fontfamily.SelectedIndex = 13
            Me.comboBox2.SelectedIndex = 4
            Me.chartControl1.Legend.ShowItemsShadow = False
            Me.panel4.Enabled = False

            Me.comboBox8.SelectedIndex = 0
            Me.comboBox3.SelectedIndex = 1
            Me.comboBox1.SelectedIndex = 3
            Me.comboBox4.SelectedIndex = 1
            Me.comboBox5.SelectedIndex = 1
            Me.comboBox6.SelectedIndex = 0
            Me.comboBox7.SelectedIndex = 1
            Me.comboBox9.SelectedIndex = 8
            Me.ComboBox10.SelectedIndex = 0
            Me.chartControl1.Legend.ShowBorder = True
            Me.chartControl1.Legend.VisibleCheckBox = True

            For Each representationtype As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartLegendRepresentationType))
                Me.cmbLegendType.Items.Add(representationtype)
            Next representationtype
            Me.cmbLegendType.SelectedIndex = 2
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        Private Sub InitializeChartData()
            Me.chartControl1.Text = "Population Statistics"

            Dim series1 As New ChartSeries()
            series1.Name = "Anguilla"
            series1.Text = series1.Name
            series1.SeriesIndexedModelImpl = New ArrayModel(New Double() {1000.5, 1100.797, 1500.0})
            series1.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series1)
            series1.Style.Interior = New BrushInfo(GradientStyle.Horizontal, System.Drawing.Color.FromArgb(91, 66, 98), Color.FromArgb(192, 167, 199))
            series1.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series1.Style.ImageIndex = 0

            Dim series2 As New ChartSeries()
            series2.Name = "Argentina"
            series2.Text = series2.Name
            series2.SeriesIndexedModelImpl = New ArrayModel(New Double() {25955.82, 36955.182, 38955.182})
            series2.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series2)
            series2.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series2.Style.ImageIndex = 1
            series2.Style.Interior = New BrushInfo(GradientStyle.Horizontal, System.Drawing.Color.FromArgb(81, 81, 204), System.Drawing.Color.FromArgb(171, 171, 255))

            Dim series3 As New ChartSeries()
            series3.Name = "Bahamas"
            series3.Text = series3.Name
            series3.SeriesIndexedModelImpl = New ArrayModel(New Double() {2040.082, 2940.982, 2960.982})
            series3.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series3)
            series3.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series3.Style.ImageIndex = 3
            series3.Style.Interior = New BrushInfo(GradientStyle.Horizontal, System.Drawing.Color.FromArgb(21, 131, 132), System.Drawing.Color.FromArgb(118, 206, 210))

            Dim series4 As New ChartSeries()
            series4.Name = "Belize"
            series4.Text = series4.Name
            series4.SeriesIndexedModelImpl = New ArrayModel(New Double() {2350.183, 2490.183, 2550.183})
            series4.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series4)
            series4.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series4.Style.ImageIndex = 5
            series4.Style.Interior = New BrushInfo(GradientStyle.Horizontal, System.Drawing.Color.FromArgb(119, 131, 31), System.Drawing.Color.FromArgb(210, 223, 135))
            series4.Style.Interior = New BrushInfo(GradientStyle.Horizontal, System.Drawing.Color.FromArgb(214, 43, 43), System.Drawing.Color.FromArgb(255, 132, 132))

            Dim series5 As New ChartSeries()
            series5.Name = "Bolivia"
            series5.Text = series5.Name
            series5.SeriesIndexedModelImpl = New ArrayModel(New Double() {7812.52, 8152.62, 8002.62})
            series5.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series5)
            series5.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series5.Style.ImageIndex = 6
            series5.Style.Interior = New BrushInfo(GradientStyle.Horizontal, System.Drawing.Color.FromArgb(170, 137, 8), System.Drawing.Color.FromArgb(254, 227, 136))

            Dim series6 As New ChartSeries()
            series6.Name = "Canada"
            series6.Text = series6.Name
            series6.SeriesIndexedModelImpl = New ArrayModel(New Double() {30281.092, 31281.092, 31581.092})
            series6.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series6)
            series6.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series6.Style.ImageIndex = 8
            series6.Style.Interior = New BrushInfo(GradientStyle.Horizontal, System.Drawing.Color.FromArgb(158, 57, 113), System.Drawing.Color.FromArgb(252, 169, 215))

            Dim series7 As New ChartSeries()
            series7.Name = "Chile"
            series7.Text = series7.Name
            series7.SeriesIndexedModelImpl = New ArrayModel(New Double() {10153.797, 15153.797, 16153.797})
            series7.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series7)
            series7.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series7.Style.ImageIndex = 9
            series7.Style.Interior = New BrushInfo(GradientStyle.Horizontal, System.Drawing.Color.FromArgb(171, 106, 38), System.Drawing.Color.FromArgb(255, 189, 133))

            Dim series8 As New ChartSeries()
            series8.Name = "Colombia"
            series8.Text = series8.Name
            series8.SeriesIndexedModelImpl = New ArrayModel(New Double() {32685.655, 35685.655, 37685.655})
            series8.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series8)
            series8.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series8.Style.ImageIndex = 10
            series8.Style.Interior = New BrushInfo(GradientStyle.Horizontal, System.Drawing.Color.FromArgb(164, 42, 5), System.Drawing.Color.FromArgb(244, 147, 114))
            Me.chartControl1.Legend.OnlyColumnsForFloating = False
            Me.chartControl1.Indexed = True


        End Sub
#End Region

#Region "ChangeFont"
        Private Sub ChangeFont()
            If Me.comboBox_Fontfamily.SelectedItem IsNot Nothing Then
                Dim fs As FontStyle = CType(System.Enum.Parse(GetType(FontStyle), Me.comboBox_FontStyle.SelectedItem.ToString(), True), FontStyle)
                Me.chartControl1.Legend.Font = New Font(Me.comboBox_Fontfamily.SelectedItem.ToString(), CSng(Me.numericUpDown_FontSize.Value), fs)
            End If
        End Sub

#End Region


#End Region

#Region "Events"

        Private Sub cmbFontFace_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            ChangeFont()
        End Sub


#Region "ChartFormatAxisLabel"
        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs)

            If e.AxisOrientation = ChartOrientation.Horizontal Then
                Select Case CInt(Fix(e.Value))
                    Case 0
                        e.Label = "1995"
                    Case 1
                        e.Label = "2000"
                    Case 2
                        e.Label = "2005"
                    Case Else
                        e.Label = ""

                End Select

            End If

            e.Handled = True
        End Sub
#End Region

#Region "Legend Alignment"
        Private Sub comboBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox4.SelectedIndexChanged
            Me.chartControl1.LegendsPlacement = CType(System.Enum.Parse(GetType(ChartPlacement), Me.comboBox4.SelectedItem.ToString(), True), ChartPlacement)

        End Sub

        Private Sub comboBox1_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.LegendPosition = CType(System.Enum.Parse(GetType(ChartDock), Me.comboBox1.SelectedItem.ToString(), True), ChartDock)


        End Sub

        Private Sub comboBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox5.SelectedIndexChanged
            Me.chartControl1.LegendAlignment = CType(System.Enum.Parse(GetType(ChartAlignment), Me.comboBox5.SelectedItem.ToString(), True), ChartAlignment)
        End Sub
#End Region

#Region "Font Settings"
        Private Sub comboBox_Fontfamily_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_Fontfamily.SelectedIndexChanged
            ChangeFont()
        End Sub

        Private Sub comboBox_FontStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_FontStyle.SelectedIndexChanged
            ChangeFont()
        End Sub

        Private Sub numericUpDown_FontSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown_FontSize.ValueChanged
            ChangeFont()
        End Sub

        Private Sub colorPicker_TextColor_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPicker_TextColor.ColorSelected
            For Each item As ChartLegendItem In Me.chartControl1.Legend.Items
                item.TextColor = Me.colorPicker_TextColor.SelectedColor
            Next item
            Me.textBox_TextColor.BackColor = Me.colorPicker_TextColor.SelectedColor
            Me.Refresh()

        End Sub
#End Region

#Region " BackInterior"
        Protected Sub SetBackInterior()
            Me.chartControl1.Legend.BackInterior = New BrushInfo(CType(System.Enum.Parse(GetType(GradientStyle), Me.comboBox2.SelectedItem.ToString(), True), GradientStyle), Me.colorPickerButton1.SelectedColor, Me.colorPickerButton2.SelectedColor)
        End Sub
        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
            SetBackInterior()
            Me.textBox1.BackColor = Me.colorPickerButton1.SelectedColor
            Me.Refresh()
        End Sub

        Private Sub comboBox2_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
            SetBackInterior()
        End Sub

        Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton2.ColorSelected
            SetBackInterior()
            Me.textBox2.BackColor = Me.colorPickerButton2.SelectedColor
            Me.Refresh()
        End Sub
#End Region

#Region "Shadow"
        Private Sub checkBox1_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            If Me.checkBox1.Checked Then
                Me.chartControl1.Legend.ShowItemsShadow = True
                Me.panel4.Enabled = True

            Else
                Me.chartControl1.Legend.ShowItemsShadow = False
                Me.panel4.Enabled = False

            End If
        End Sub

        Private Sub colorPickerButton3_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton3.ColorSelected
            Me.chartControl1.Legend.ItemsShadowColor = Me.colorPickerButton3.SelectedColor
            Me.textBox3.BackColor = Me.colorPickerButton3.SelectedColor
            Me.Refresh()
        End Sub


#End Region

#Region "Title"
        Private Sub textBox4_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox4.TextChanged
            Me.chartControl1.Legend.Text = Me.textBox4.Text
        End Sub

        Private Sub colorPickerButton4_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton4.ColorSelected
            Me.chartControl1.Legend.ForeColor = Me.colorPickerButton4.SelectedColor
            Me.textBox5.BackColor = Me.colorPickerButton4.SelectedColor
            Me.Refresh()
        End Sub

        Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
            Me.chartControl1.Legend.TextAlignment = CType(System.Enum.Parse(GetType(StringAlignment), Me.comboBox3.SelectedItem.ToString(), True), StringAlignment)
        End Sub
#End Region

        Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown2.ValueChanged
            Me.chartControl1.Legend.RowsCount = CInt(Fix(Me.numericUpDown2.Value))
        End Sub

        Private Sub numericUpDown3_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown3.ValueChanged
            Me.chartControl1.Legend.Spacing = CInt(Fix(Me.numericUpDown3.Value))

        End Sub

        Private Sub comboBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox6.SelectedIndexChanged
            Me.chartControl1.Legend.ItemsAlignment = CType(System.Enum.Parse(GetType(StringAlignment), Me.comboBox6.SelectedItem.ToString(), True), StringAlignment)
        End Sub

        Private Sub comboBox7_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox7.SelectedIndexChanged
            Me.chartControl1.Legend.ItemsTextAligment = CType(System.Enum.Parse(GetType(VerticalAlignment), Me.comboBox7.SelectedItem.ToString(), True), VerticalAlignment)

        End Sub

        Private Sub checkBox2_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            Me.chartControl1.Legend.VisibleCheckBox = Me.checkBox2.Checked
        End Sub

#Region "HideItem"
        Private Sub comboBox9_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox9.SelectedIndexChanged
            For Each item As ChartLegendItem In Me.chartControl1.Legend.Items
                item.Visible = True
            Next item
            Me.chartControl1.Refresh()
            If Me.comboBox9.SelectedIndex < 8 Then
                Me.chartControl1.Legend.Items(CInt(Fix(Me.comboBox9.SelectedIndex))).Visible = False
                Me.chartControl1.Refresh()
            End If
        End Sub
#End Region
        Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            If Me.checkBox4.Checked Then
                'Set symbol for first series
                Me.chartControl1.Series(1).Style.Symbol.Shape = ChartSymbolShape.Circle
                Me.chartControl1.Series(1).Style.Symbol.Color = Color.Red
                Me.chartControl1.Series(1).Style.Symbol.Size = New Size(7, 7)
                Me.chartControl1.Legend.ShowSymbol = True
            Else
                Me.chartControl1.Series(1).Style.Symbol.Shape = ChartSymbolShape.None
                Me.chartControl1.Legend.ShowSymbol = False
            End If
            Me.chartControl1.Refresh()
        End Sub
        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLegendType.SelectedIndexChanged
            Me.chartControl1.Legend.RepresentationType = CType(System.Enum.Parse(GetType(ChartLegendRepresentationType), Me.cmbLegendType.SelectedItem.ToString(), True), ChartLegendRepresentationType)
        End Sub
#Region "Custom Image"
        Private Sub checkBox5_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox5.CheckedChanged
            If Me.checkBox5.Checked Then
                'An Item is added with custom image. 
                Dim cli As New ChartLegendItem("Custom Image")
                Dim clic As New ChartLegendItemsCollection()
                cli.Type = ChartLegendItemType.Image
                cli.ImageList = New ChartImageCollection()
                cli.ImageList.Add(Me.imageListAdv1.Images(12))
                cli.ImageIndex = 0
                clic.Add(cli)
                Me.chartControl1.Legend.CustomItems = clic.ToArray()

                '  //Custom image could be set for existing items with the below code
                '  this.chartControl1.Legend.Items[0].ImageList = new ChartImageCollection();
                '  this.chartControl1.Legend.Items[0].ImageList.Add(this.imageListAdv1.Images[12]);
                '  this.chartControl1.Legend.Items[0].ImageIndex = 0;
                '    this.chartControl1.Legend.Items[0].Type = ChartLegendItemType.Image;

            Else
                Me.chartControl1.Legend.CustomItems = Nothing
            End If
        End Sub
#End Region
        Private Sub comboBox8_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox8.SelectedIndexChanged

            Me.chartControl1.Legend.Border.DashStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox8.SelectedItem.ToString(), True), DashStyle)
        End Sub

        Private Sub numericUpDown5_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown5.ValueChanged
            Me.chartControl1.Legend.Border.Width = CInt(Fix(Me.numericUpDown5.Value))
        End Sub

        Private Sub checkBox7_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox7.CheckedChanged
            If Me.checkBox7.Checked Then
                Me.comboBox8.Enabled = True
                Me.panel7.Enabled = True
                Me.numericUpDown5.Enabled = True
                Me.chartControl1.Legend.ShowBorder = True

            Else
                Me.comboBox8.Enabled = False
                Me.panel7.Enabled = False
                Me.numericUpDown5.Enabled = False
                Me.chartControl1.Legend.ShowBorder = False
            End If
        End Sub

        Private Sub colorPickerButton5_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton5.ColorSelected
            Me.chartControl1.Legend.Border.ForeColor = Me.colorPickerButton5.SelectedColor
            Me.textBox6.BackColor = Me.colorPickerButton5.SelectedColor
            Me.Refresh()
        End Sub
        Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
            Me.chartControl1.Legend.Behavior = CType(System.Enum.Parse(GetType(ChartDockingFlags), Me.ComboBox10.SelectedItem.ToString(), True), ChartDockingFlags)
        End Sub
#End Region
    End Class
End Namespace
