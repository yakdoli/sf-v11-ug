Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartToolTips
    Public Class Form1
        Inherits Syncfusion.Windows.Forms.Office2007Form
#Region "Private Members"
        Private label1 As System.Windows.Forms.Label
        Private WithEvents ChartAreaTooltip As System.Windows.Forms.CheckBox
        Private WithEvents CBox_TooltipFormat As System.Windows.Forms.ComboBox
        Private WithEvents ShowTooltip As System.Windows.Forms.CheckBox
        Private autoLabel3 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private autoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private autoLabel7 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private autoLabel6 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private autoLabel4 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private components As System.ComponentModel.Container = Nothing
        Private series1, series2 As ChartSeries
        Private WithEvents comboBox2 As ComboBox
        Private WithEvents comboBox1 As ComboBox
        Private WithEvents Ser2CheckBox As CheckBox
        Private WithEvents Ser1CheckBox As CheckBox
        Private WithEvents checkBoxChartToolTip As CheckBox
        Private WithEvents SeriesPointToolTip As CheckBox
        Private label22 As Label
        Private panel9 As Panel
        Private textBox3 As TextBox
        Private WithEvents BorderColorPicker As Syncfusion.Windows.Forms.ColorPickerButton
        Private panel2 As Panel
        Private textBox1 As TextBox
        Private WithEvents FontColorPicker As Syncfusion.Windows.Forms.ColorPickerButton
        Private chartControl1 As ChartControl
        Private label23 As Label
        Private label2 As Label
        Private label4 As Label
        Private color1 As Color() = New Color() {Color.FromArgb(150, 172, 90), Color.FromArgb(197, 229, 92), Color.FromArgb(150, 172, 90)}
        Private panel1 As Panel
        Private textBox2 As TextBox
        Private WithEvents colorPicker_FancyToolTipBackColor As Syncfusion.Windows.Forms.ColorPickerButton
        Private autoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents numericUpDown1 As NumericUpDown
        Private color2 As Color() = New Color() {Color.FromArgb(223, 111, 39), Color.FromArgb(251, 169, 113), Color.FromArgb(223, 111, 39)}
#End Region

#Region "Form's Constructor, Main And Dispose"
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
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.CBox_TooltipFormat = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.autoLabel7 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.Ser1CheckBox = New System.Windows.Forms.CheckBox
            Me.Ser2CheckBox = New System.Windows.Forms.CheckBox
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.autoLabel6 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel3 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.autoLabel4 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.ChartAreaTooltip = New System.Windows.Forms.CheckBox
            Me.ShowTooltip = New System.Windows.Forms.CheckBox
            Me.checkBoxChartToolTip = New System.Windows.Forms.CheckBox
            Me.SeriesPointToolTip = New System.Windows.Forms.CheckBox
            Me.label22 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.panel9 = New System.Windows.Forms.Panel
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.BorderColorPicker = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.panel2 = New System.Windows.Forms.Panel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.FontColorPicker = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.label23 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.colorPicker_FancyToolTipBackColor = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.panel9.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.panel1.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'CBox_TooltipFormat
            '
            Me.CBox_TooltipFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CBox_TooltipFormat.ForeColor = System.Drawing.Color.MidnightBlue
            Me.CBox_TooltipFormat.Items.AddRange(New Object() {" Series Name", " SeriesStyle.ToolTip", " SeriesStyle[i].ToolTip", " Series.Points[ index ].X", " Series.Points[ index ].YValues[i]"})
            Me.CBox_TooltipFormat.Location = New System.Drawing.Point(51, 547)
            Me.CBox_TooltipFormat.Name = "CBox_TooltipFormat"
            Me.CBox_TooltipFormat.Size = New System.Drawing.Size(172, 21)
            Me.CBox_TooltipFormat.TabIndex = 3
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(48, 518)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(78, 13)
            Me.label1.TabIndex = 4
            Me.label1.Text = "ToolTip Format"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.FormattingEnabled = True
            Me.comboBox2.Location = New System.Drawing.Point(395, 577)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(105, 21)
            Me.comboBox2.Sorted = True
            Me.comboBox2.TabIndex = 17
            '
            'autoLabel7
            '
            Me.autoLabel7.DX = 0
            Me.autoLabel7.DY = 0
            Me.autoLabel7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.autoLabel7.Location = New System.Drawing.Point(328, 577)
            Me.autoLabel7.Name = "autoLabel7"
            Me.autoLabel7.Size = New System.Drawing.Size(41, 13)
            Me.autoLabel7.TabIndex = 9
            Me.autoLabel7.Text = "Symbol"
            '
            'Ser1CheckBox
            '
            Me.Ser1CheckBox.AutoSize = True
            Me.Ser1CheckBox.Location = New System.Drawing.Point(328, 399)
            Me.Ser1CheckBox.Name = "Ser1CheckBox"
            Me.Ser1CheckBox.Size = New System.Drawing.Size(61, 17)
            Me.Ser1CheckBox.TabIndex = 19
            Me.Ser1CheckBox.Text = "Series1"
            Me.Ser1CheckBox.UseVisualStyleBackColor = True
            '
            'Ser2CheckBox
            '
            Me.Ser2CheckBox.AutoSize = True
            Me.Ser2CheckBox.Location = New System.Drawing.Point(395, 399)
            Me.Ser2CheckBox.Name = "Ser2CheckBox"
            Me.Ser2CheckBox.Size = New System.Drawing.Size(61, 17)
            Me.Ser2CheckBox.TabIndex = 20
            Me.Ser2CheckBox.Text = "Series2"
            Me.Ser2CheckBox.UseVisualStyleBackColor = True
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.DropDownWidth = 105
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Ellipse", "Rectangle", "SmoothRectangle"})
            Me.comboBox1.Location = New System.Drawing.Point(395, 547)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(105, 21)
            Me.comboBox1.Sorted = True
            Me.comboBox1.TabIndex = 16
            '
            'autoLabel6
            '
            Me.autoLabel6.DX = 0
            Me.autoLabel6.DY = 0
            Me.autoLabel6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.autoLabel6.Location = New System.Drawing.Point(328, 547)
            Me.autoLabel6.Name = "autoLabel6"
            Me.autoLabel6.Size = New System.Drawing.Size(30, 13)
            Me.autoLabel6.TabIndex = 8
            Me.autoLabel6.Text = "Style"
            '
            'autoLabel2
            '
            Me.autoLabel2.DX = 0
            Me.autoLabel2.DY = 0
            Me.autoLabel2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.autoLabel2.Location = New System.Drawing.Point(328, 488)
            Me.autoLabel2.Name = "autoLabel2"
            Me.autoLabel2.Size = New System.Drawing.Size(62, 13)
            Me.autoLabel2.TabIndex = 1
            Me.autoLabel2.Text = "BorderColor"
            '
            'autoLabel3
            '
            Me.autoLabel3.DX = 0
            Me.autoLabel3.DY = 0
            Me.autoLabel3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.autoLabel3.Location = New System.Drawing.Point(328, 518)
            Me.autoLabel3.Name = "autoLabel3"
            Me.autoLabel3.Size = New System.Drawing.Size(66, 13)
            Me.autoLabel3.TabIndex = 2
            Me.autoLabel3.Text = "BorderWidth"
            '
            'autoLabel4
            '
            Me.autoLabel4.DX = 0
            Me.autoLabel4.DY = 0
            Me.autoLabel4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.autoLabel4.Location = New System.Drawing.Point(328, 458)
            Me.autoLabel4.Name = "autoLabel4"
            Me.autoLabel4.Size = New System.Drawing.Size(52, 13)
            Me.autoLabel4.TabIndex = 5
            Me.autoLabel4.Text = "ForeColor"
            '
            'ChartAreaTooltip
            '
            Me.ChartAreaTooltip.AutoSize = True
            Me.ChartAreaTooltip.ForeColor = System.Drawing.Color.MidnightBlue
            Me.ChartAreaTooltip.Location = New System.Drawing.Point(48, 458)
            Me.ChartAreaTooltip.Name = "ChartAreaTooltip"
            Me.ChartAreaTooltip.Size = New System.Drawing.Size(112, 17)
            Me.ChartAreaTooltip.TabIndex = 2
            Me.ChartAreaTooltip.Text = "ChartArea ToolTip"
            '
            'ShowTooltip
            '
            Me.ShowTooltip.AutoSize = True
            Me.ShowTooltip.BackColor = System.Drawing.Color.Transparent
            Me.ShowTooltip.Checked = True
            Me.ShowTooltip.CheckState = System.Windows.Forms.CheckState.Checked
            Me.ShowTooltip.ForeColor = System.Drawing.Color.MidnightBlue
            Me.ShowTooltip.Location = New System.Drawing.Point(48, 399)
            Me.ShowTooltip.Name = "ShowTooltip"
            Me.ShowTooltip.Size = New System.Drawing.Size(89, 17)
            Me.ShowTooltip.TabIndex = 1
            Me.ShowTooltip.Text = "ShowToolTip"
            Me.ShowTooltip.UseVisualStyleBackColor = False
            '
            'checkBoxChartToolTip
            '
            Me.checkBoxChartToolTip.AutoSize = True
            Me.checkBoxChartToolTip.ForeColor = System.Drawing.Color.MidnightBlue
            Me.checkBoxChartToolTip.Location = New System.Drawing.Point(48, 428)
            Me.checkBoxChartToolTip.Name = "checkBoxChartToolTip"
            Me.checkBoxChartToolTip.Size = New System.Drawing.Size(90, 17)
            Me.checkBoxChartToolTip.TabIndex = 3
            Me.checkBoxChartToolTip.Text = "Chart ToolTip"
            '
            'SeriesPointToolTip
            '
            Me.SeriesPointToolTip.AutoSize = True
            Me.SeriesPointToolTip.ForeColor = System.Drawing.Color.MidnightBlue
            Me.SeriesPointToolTip.Location = New System.Drawing.Point(48, 488)
            Me.SeriesPointToolTip.Name = "SeriesPointToolTip"
            Me.SeriesPointToolTip.Size = New System.Drawing.Size(121, 17)
            Me.SeriesPointToolTip.TabIndex = 4
            Me.SeriesPointToolTip.Text = "Series Point ToolTip"
            '
            'label22
            '
            Me.label22.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label22.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label22.Image = CType(resources.GetObject("label22.Image"), System.Drawing.Image)
            Me.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label22.Location = New System.Drawing.Point(45, 364)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(73, 19)
            Me.label22.TabIndex = 108
            Me.label22.Text = "ToolTips"
            Me.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label4.Location = New System.Drawing.Point(325, 364)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(113, 19)
            Me.label4.TabIndex = 109
            Me.label4.Text = "Fancy ToolTips"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'panel9
            '
            Me.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel9.Controls.Add(Me.textBox3)
            Me.panel9.Controls.Add(Me.BorderColorPicker)
            Me.panel9.Location = New System.Drawing.Point(395, 488)
            Me.panel9.Name = "panel9"
            Me.panel9.Size = New System.Drawing.Size(41, 21)
            Me.panel9.TabIndex = 110
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
            'BorderColorPicker
            '
            Me.BorderColorPicker.BackColor = System.Drawing.Color.Black
            Me.BorderColorPicker.ColorUISize = New System.Drawing.Size(208, 230)
            Me.BorderColorPicker.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BorderColorPicker.Dock = System.Windows.Forms.DockStyle.Right
            Me.BorderColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.BorderColorPicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BorderColorPicker.ForeColor = System.Drawing.Color.MidnightBlue
            Me.BorderColorPicker.Image = CType(resources.GetObject("BorderColorPicker.Image"), System.Drawing.Image)
            Me.BorderColorPicker.Location = New System.Drawing.Point(22, 0)
            Me.BorderColorPicker.Name = "BorderColorPicker"
            Me.BorderColorPicker.SelectedAsBackcolor = True
            Me.BorderColorPicker.SelectedColor = System.Drawing.Color.Black
            Me.BorderColorPicker.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.BorderColorPicker.Size = New System.Drawing.Size(17, 19)
            Me.BorderColorPicker.TabIndex = 14
            Me.BorderColorPicker.Text = "..."
            Me.BorderColorPicker.UseVisualStyleBackColor = False
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Controls.Add(Me.FontColorPicker)
            Me.panel2.Location = New System.Drawing.Point(395, 458)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(41, 21)
            Me.panel2.TabIndex = 111
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.Black
            Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox1.Location = New System.Drawing.Point(0, 0)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(22, 20)
            Me.textBox1.TabIndex = 11
            '
            'FontColorPicker
            '
            Me.FontColorPicker.BackColor = System.Drawing.Color.Black
            Me.FontColorPicker.ColorUISize = New System.Drawing.Size(208, 230)
            Me.FontColorPicker.Cursor = System.Windows.Forms.Cursors.Hand
            Me.FontColorPicker.Dock = System.Windows.Forms.DockStyle.Right
            Me.FontColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.FontColorPicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FontColorPicker.ForeColor = System.Drawing.Color.MidnightBlue
            Me.FontColorPicker.Image = CType(resources.GetObject("FontColorPicker.Image"), System.Drawing.Image)
            Me.FontColorPicker.Location = New System.Drawing.Point(22, 0)
            Me.FontColorPicker.Name = "FontColorPicker"
            Me.FontColorPicker.SelectedAsBackcolor = True
            Me.FontColorPicker.SelectedColor = System.Drawing.Color.Black
            Me.FontColorPicker.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.FontColorPicker.Size = New System.Drawing.Size(17, 19)
            Me.FontColorPicker.TabIndex = 14
            Me.FontColorPicker.Text = "..."
            Me.FontColorPicker.UseVisualStyleBackColor = False
            '
            'chartControl1
            '
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.White, System.Drawing.Color.Gray)
            Me.chartControl1.ChartArea.BorderColor = System.Drawing.Color.White
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(374, 87)
            Me.chartControl1.Legend.ShowSymbol = True
            Me.chartControl1.Location = New System.Drawing.Point(25, 17)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 100, 20)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.Black
            Me.chartControl1.ShadowColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Silver)
            Me.chartControl1.Size = New System.Drawing.Size(510, 318)
            Me.chartControl1.TabIndex = 112
            Me.chartControl1.Text = "EssentialChart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "EssentialChart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'label23
            '
            Me.label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label23.Location = New System.Drawing.Point(45, 386)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(200, 1)
            Me.label23.TabIndex = 114
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label2.Location = New System.Drawing.Point(325, 386)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(200, 1)
            Me.label2.TabIndex = 115
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.textBox2)
            Me.panel1.Controls.Add(Me.colorPicker_FancyToolTipBackColor)
            Me.panel1.Location = New System.Drawing.Point(395, 428)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(41, 21)
            Me.panel1.TabIndex = 117
            '
            'textBox2
            '
            Me.textBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.textBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.textBox2.Location = New System.Drawing.Point(0, 0)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(22, 20)
            Me.textBox2.TabIndex = 11
            '
            'colorPicker_FancyToolTipBackColor
            '
            Me.colorPicker_FancyToolTipBackColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.colorPicker_FancyToolTipBackColor.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPicker_FancyToolTipBackColor.Cursor = System.Windows.Forms.Cursors.Hand
            Me.colorPicker_FancyToolTipBackColor.Dock = System.Windows.Forms.DockStyle.Right
            Me.colorPicker_FancyToolTipBackColor.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.colorPicker_FancyToolTipBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorPicker_FancyToolTipBackColor.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPicker_FancyToolTipBackColor.Image = CType(resources.GetObject("colorPicker_FancyToolTipBackColor.Image"), System.Drawing.Image)
            Me.colorPicker_FancyToolTipBackColor.Location = New System.Drawing.Point(22, 0)
            Me.colorPicker_FancyToolTipBackColor.Name = "colorPicker_FancyToolTipBackColor"
            Me.colorPicker_FancyToolTipBackColor.SelectedAsBackcolor = True
            Me.colorPicker_FancyToolTipBackColor.SelectedColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.colorPicker_FancyToolTipBackColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPicker_FancyToolTipBackColor.Size = New System.Drawing.Size(17, 19)
            Me.colorPicker_FancyToolTipBackColor.TabIndex = 14
            Me.colorPicker_FancyToolTipBackColor.Text = "..."
            Me.colorPicker_FancyToolTipBackColor.UseVisualStyleBackColor = False
            '
            'autoLabel1
            '
            Me.autoLabel1.DX = 0
            Me.autoLabel1.DY = 0
            Me.autoLabel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.autoLabel1.Location = New System.Drawing.Point(328, 428)
            Me.autoLabel1.Name = "autoLabel1"
            Me.autoLabel1.Size = New System.Drawing.Size(56, 13)
            Me.autoLabel1.TabIndex = 116
            Me.autoLabel1.Text = "BackColor"
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(395, 518)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(40, 20)
            Me.numericUpDown1.TabIndex = 118
            Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(566, 611)
            Me.Controls.Add(Me.numericUpDown1)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.autoLabel1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label23)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.comboBox2)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.autoLabel7)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.panel9)
            Me.Controls.Add(Me.autoLabel6)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label22)
            Me.Controls.Add(Me.CBox_TooltipFormat)
            Me.Controls.Add(Me.autoLabel4)
            Me.Controls.Add(Me.Ser2CheckBox)
            Me.Controls.Add(Me.autoLabel3)
            Me.Controls.Add(Me.Ser1CheckBox)
            Me.Controls.Add(Me.autoLabel2)
            Me.Controls.Add(Me.SeriesPointToolTip)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.checkBoxChartToolTip)
            Me.Controls.Add(Me.ChartAreaTooltip)
            Me.Controls.Add(Me.ShowTooltip)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart ToolTips "
            Me.panel9.ResumeLayout(False)
            Me.panel9.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region
#Region "Helper Methods"
#Region "InitializeChartData"
        ''' <summary>
        ''' Create a series and add points to the series.
        ''' </summary>
        Protected Sub InitializeChartData()
            series1 = New ChartSeries()
            series1.Name = "Server 1"
            series1.Type = ChartSeriesType.Column
            series1.Text = series1.Name

            series1.Points.Add(0, 20)
            series1.Points.Add(1, 40)
            series1.Points.Add(2, 80)
            series1.Points.Add(3, 70)
            series1.Points.Add(4, 50)
            AddHandler series1.PrepareStyle, AddressOf ChartControlSeries_PrepareStyle
            Me.chartControl1.Series.Add(series1)

            series2 = New ChartSeries()
            series2.Name = "Server 2"
            series2.Type = ChartSeriesType.Column
            series2.Text = series2.Name

            series2.Points.Add(0, 50)
            series2.Points.Add(1, 60)
            series2.Points.Add(2, 60)
            series2.Points.Add(3, 40)
            series2.Points.Add(4, 90)
            AddHandler series2.PrepareStyle, AddressOf ChartControlSeries_PrepareStyle
            Me.chartControl1.Series.Add(series2)

            series1.FancyToolTip.Style = MarkerStyle.Ellipse
            series2.FancyToolTip.Style = MarkerStyle.Ellipse
            series1.FancyToolTip.Symbol = ChartSymbolShape.Circle
            series2.FancyToolTip.Symbol = ChartSymbolShape.Circle
            series1.FancyToolTip.BackColor = Color.Gold
            series2.FancyToolTip.BackColor = Color.Gold

            Me.CBox_TooltipFormat.SelectedIndex = 2
            Me.chartControl1.ElementsSpacing = 15
            Me.chartControl1.ShowToolTips = Me.ShowTooltip.Checked
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
            Me.chartControl1.PrimaryXAxis.Format = "Day 0"

            For Each symbol As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape))
                If symbol.Equals("Image") Then
                    Exit For
                End If
                Me.comboBox2.Items.Add(symbol)
            Next symbol

            Me.chartControl1.Spacing = 30.0F
            Me.checkBoxChartToolTip.Checked = True
            Me.ChartAreaTooltip.Checked = True
            Me.SeriesPointToolTip.Checked = True

            Me.comboBox1.SelectedIndex = 0
            Me.comboBox2.SelectedIndex = 0
        End Sub
#End Region

#Region "SetFancyToolTip"
        Protected Sub SetFancyToolTip(ByVal series As ChartSeries)
            Dim width As Integer = Convert.ToInt32(Me.numericUpDown1.Value)

            Dim newSeries As ChartSeries = series
            series.FancyToolTip.BackColor = Me.colorPicker_FancyToolTipBackColor.SelectedColor
            series.FancyToolTip.ForeColor = Me.FontColorPicker.SelectedColor
            series.FancyToolTip.Border.ForeColor = Me.BorderColorPicker.SelectedColor
            series.FancyToolTip.Style = CType(System.Enum.Parse(GetType(Syncfusion.Windows.Forms.Chart.MarkerStyle), Me.comboBox1.SelectedItem.ToString(), True), Syncfusion.Windows.Forms.Chart.MarkerStyle)
            series.FancyToolTip.Symbol = CType(System.Enum.Parse(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape), Me.comboBox2.SelectedItem.ToString(), True), Syncfusion.Windows.Forms.Chart.ChartSymbolShape)
            series.FancyToolTip.Border.Width = width

            Me.chartControl1.Redraw(True)
        End Sub
#End Region
#End Region

#Region "Events"
#Region "Preparestyle Event"
        ''' <summary>
        ''' Set tooltip format using preparestyle event in chart control.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="args"></param>
        Protected Sub ChartControlSeries_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            ' Style formatting using a callback. You can apply the same settings directly on the series style on the
            ' point styles.
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            If series IsNot Nothing Then
                args.Style.Text = String.Format("Value is {0}", series.Points(args.Index).YValues(0))
                args.Style.ToolTip = "You are hovering over Day " & series.Points(args.Index).X.ToString()
                args.Handled = True
            End If
        End Sub
#End Region


        ''' <summary>
        ''' Tooltip customization.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>

        Private Sub ShowTooltip_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowTooltip.CheckedChanged
            If Me.ShowTooltip.Checked Then
                Me.chartControl1.ShowToolTips = True
                Me.checkBoxChartToolTip.Enabled = True
                Me.ChartAreaTooltip.Enabled = True
                Me.SeriesPointToolTip.Enabled = True

            Else
                Me.chartControl1.ShowToolTips = False
                Me.checkBoxChartToolTip.Enabled = False
                Me.ChartAreaTooltip.Enabled = False
                Me.SeriesPointToolTip.Enabled = False
            End If
            Me.chartControl1.Redraw(True)
        End Sub

#Region "Chart ToolTip"
        Private Sub checkBoxChartToolTip_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxChartToolTip.CheckedChanged
            If Me.checkBoxChartToolTip.Checked Then
                Me.chartControl1.ChartToolTip = "Chart ToolTip"
            Else
                Me.chartControl1.ChartToolTip = ""
            End If
            Me.chartControl1.Redraw(True)
        End Sub
#End Region

#Region "ChartArea ToolTip"
        Private Sub ChartAreaTooltip_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChartAreaTooltip.CheckedChanged
            If Me.ChartAreaTooltip.Checked Then
                Me.chartControl1.ChartAreaToolTip = "Chart Area ToolTip"
            Else
                Me.chartControl1.ChartAreaToolTip = ""
            End If
            Me.chartControl1.Redraw(True)
        End Sub
#End Region

#Region "Series Point ToolTip"
        Private Sub SeriesPointToolTip_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles SeriesPointToolTip.CheckedChanged
            If Me.SeriesPointToolTip.Checked Then
                Me.CBox_TooltipFormat.Visible = True
                Me.label1.Visible = True
            Else
                Me.CBox_TooltipFormat.Visible = False
                Me.label1.Visible = False
            End If
        End Sub

        Private Sub TooltipFormat_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBox_TooltipFormat.SelectedIndexChanged
            For Each s As ChartSeries In Me.chartControl1.Series
                Dim len As Integer = s.Points.Count
                s.Style.ToolTip = "Server Load"
                For i As Integer = 0 To len - 1
                    Dim x As Integer = Me.CBox_TooltipFormat.SelectedIndex
                    s.PointsToolTipFormat = "{" & x.ToString() & "}"

                    '
                    'ToolTips Format Style
                    '
                    '			"{0}" - series Name
                    '
                    '	        "{1}" - SeriesStyle.ToolTip;
                    '
                    '	        "{2}" - SeriesStyle[i].ToolTip; - this is what we want.
                    '
                    '	        "{3}" - series.Points[ index ].X;
                    '
                    '		    "{4+i}" - series.Points[ index ].YValues[i];

                Next i
            Next s
        End Sub
#End Region


        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles BorderColorPicker.ColorSelected
            If Ser1CheckBox.Checked Then
                SetFancyToolTip(series1)
            End If
            If Ser2CheckBox.Checked Then
                SetFancyToolTip(series2)
            End If
            If (Me.BorderColorPicker.SelectedColor = Color.Transparent) Then
                Me.textBox3.BackColor = Color.Empty
            Else
                Me.textBox3.BackColor = Me.BorderColorPicker.SelectedColor
            End If
            Me.Refresh()
        End Sub

        Private Sub FontColorPicker_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles FontColorPicker.ColorSelected
            If Ser1CheckBox.Checked Then
                SetFancyToolTip(series1)
            End If
            If Ser2CheckBox.Checked Then
                SetFancyToolTip(series2)
            End If
            If (Me.FontColorPicker.SelectedColor = Color.Transparent) Then
                Me.textBox1.BackColor = Color.Empty
            Else
                Me.textBox1.BackColor = Me.FontColorPicker.SelectedColor
            End If
            Me.Refresh()
        End Sub



        Private Sub colorPicker_FancyToolTipBackColor_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPicker_FancyToolTipBackColor.ColorSelected
            If Ser1CheckBox.Checked Then
                SetFancyToolTip(series1)
            End If
            If Ser2CheckBox.Checked Then
                SetFancyToolTip(series2)
            End If
            If (Me.colorPicker_FancyToolTipBackColor.SelectedColor = Color.Transparent) Then
                Me.textBox2.BackColor = Color.Empty
            Else
                Me.textBox2.BackColor = Me.colorPicker_FancyToolTipBackColor.SelectedColor
            End If
            Me.Refresh()
        End Sub


        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            If Ser1CheckBox.Checked Then
                SetFancyToolTip(series1)
            End If
            If Ser2CheckBox.Checked Then
                SetFancyToolTip(series2)
            End If
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
            If Ser1CheckBox.Checked Then
                SetFancyToolTip(series1)
            End If
            If Ser2CheckBox.Checked Then
                SetFancyToolTip(series2)
            End If
        End Sub

        Private Sub chartControl1_ChartRegionMouseHover(ByVal sender As Object, ByVal e As ChartRegionMouseEventArgs)
            If e.Region.SeriesIndex = 1 AndAlso Me.Ser2CheckBox.Checked = False Then
                series1.FancyToolTip.Visible = False
            End If
            If e.Region.SeriesIndex = 0 AndAlso Me.Ser1CheckBox.Checked = False Then
                series2.FancyToolTip.Visible = False
            End If
            If e.Region.SeriesIndex = 0 AndAlso Me.Ser1CheckBox.Checked Then
                series1.FancyToolTip.Visible = True
                series2.FancyToolTip.Visible = False
            End If
            If e.Region.SeriesIndex = 1 AndAlso Me.Ser2CheckBox.Checked Then
                series1.FancyToolTip.Visible = False
                series2.FancyToolTip.Visible = True
            End If
            If e.Region.SeriesIndex = -1 Then
                series1.FancyToolTip.Visible = False
                series2.FancyToolTip.Visible = False
            End If
            Me.chartControl1.Redraw(True)
        End Sub


        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
            If Ser1CheckBox.Checked Then
                SetFancyToolTip(series1)
            End If
            If Ser2CheckBox.Checked Then
                SetFancyToolTip(series2)
            End If
        End Sub

        Private Sub Ser1CheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Ser1CheckBox.CheckedChanged
            Me.chartControl1.ShowToolTips = False
            Me.ShowTooltip.Checked = False
            If Ser1CheckBox.Checked = True Then
                series1.FancyToolTip.Visible = True
                SetFancyToolTip(series1)
            Else
                series1.FancyToolTip.Visible = False

            End If
        End Sub

        Private Sub Ser2CheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Ser2CheckBox.CheckedChanged

            Me.chartControl1.ShowToolTips = False
            Me.ShowTooltip.Checked = False
            If Ser2CheckBox.Checked = True Then
                series2.FancyToolTip.Visible = True
                SetFancyToolTip(series2)

            Else
                series2.FancyToolTip.Visible = False

            End If
        End Sub



#End Region

    End Class
End Namespace