Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms


Namespace AreaChartSample

    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"

        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents colorPickerButton1 As Syncfusion.Windows.Forms.ColorPickerButton
        Private WithEvents colorPickerButton2 As Syncfusion.Windows.Forms.ColorPickerButton
        Private label2 As System.Windows.Forms.Label
        Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
        Private WithEvents colorPickerButton3 As Syncfusion.Windows.Forms.ColorPickerButton
        Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
        Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents comboBoxChartType As System.Windows.Forms.ComboBox
        Private label7 As Label
        Private label8 As Label
        Private label5 As Label
        Private label3 As Label
        Private label4 As Label
        Private label10 As Label
        Private label12 As Label
        Private label6 As Label
        Private series3 As ChartSeries
        Private series1 As ChartSeries
        Private series2 As ChartSeries
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
        Private WithEvents checkBox3 As CheckBox
        Private WithEvents radioButton3 As RadioButton
        Private panel2 As Panel
#End Region

#Region "Constructor, Main and Dispose"
        Public Sub New()
            InitializeComponent()

            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
        End Sub
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub


        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
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
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.radioButton3 = New System.Windows.Forms.RadioButton
            Me.label6 = New System.Windows.Forms.Label
            Me.colorPickerButton1 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.colorPickerButton2 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label7 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.comboBoxChartType = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.label12 = New System.Windows.Forms.Label
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label10 = New System.Windows.Forms.Label
            Me.colorPickerButton3 = New Syncfusion.Windows.Forms.ColorPickerButton
            Me.label4 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.panel2 = New System.Windows.Forms.Panel
            Me.panel1.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(232, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 5, 5)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(253, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(216, Byte), Integer)))
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(61, 70)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.Spacing = 3
            Me.chartControl1.Location = New System.Drawing.Point(23, 16)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(2004, 2008, 1)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(-100, 1500, 200)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.Size = New System.Drawing.Size(411, 348)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "EssentialChart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "EssentialChart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.radioButton3)
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.colorPickerButton1)
            Me.panel1.Controls.Add(Me.colorPickerButton2)
            Me.panel1.Controls.Add(Me.label7)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label8)
            Me.panel1.Controls.Add(Me.comboBoxChartType)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.label5)
            Me.panel1.Controls.Add(Me.label12)
            Me.panel1.Controls.Add(Me.numericUpDown1)
            Me.panel1.Controls.Add(Me.label10)
            Me.panel1.Controls.Add(Me.colorPickerButton3)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.radioButton1)
            Me.panel1.Controls.Add(Me.radioButton2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(446, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(176, 416)
            Me.panel1.TabIndex = 3
            '
            'radioButton3
            '
            Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton3.Location = New System.Drawing.Point(23, 165)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(72, 16)
            Me.radioButton3.TabIndex = 15
            Me.radioButton3.Text = "BMW"
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label6.Location = New System.Drawing.Point(19, 203)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(144, 1)
            Me.label6.TabIndex = 14
            '
            'colorPickerButton1
            '
            Me.colorPickerButton1.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton1.Location = New System.Drawing.Point(21, 334)
            Me.colorPickerButton1.Name = "colorPickerButton1"
            Me.colorPickerButton1.SelectedAsBackcolor = True
            Me.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton1.Size = New System.Drawing.Size(88, 24)
            Me.colorPickerButton1.TabIndex = 0
            Me.colorPickerButton1.Text = " ForeColor"
            '
            'colorPickerButton2
            '
            Me.colorPickerButton2.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton2.Location = New System.Drawing.Point(21, 364)
            Me.colorPickerButton2.Name = "colorPickerButton2"
            Me.colorPickerButton2.SelectedAsBackcolor = True
            Me.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton2.Size = New System.Drawing.Size(88, 24)
            Me.colorPickerButton2.TabIndex = 1
            Me.colorPickerButton2.Text = " BackColor"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.BackColor = System.Drawing.Color.Transparent
            Me.label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label7.Location = New System.Drawing.Point(20, 310)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(81, 14)
            Me.label7.TabIndex = 12
            Me.label7.Text = "Interior Color"
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(17, 215)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(72, 19)
            Me.label2.TabIndex = 11
            Me.label2.Text = "BorderWidth"
            '
            'label8
            '
            Me.label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label8.Location = New System.Drawing.Point(20, 327)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(144, 1)
            Me.label8.TabIndex = 13
            '
            'comboBoxChartType
            '
            Me.comboBoxChartType.Cursor = System.Windows.Forms.Cursors.Hand
            Me.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxChartType.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBoxChartType.Location = New System.Drawing.Point(21, 55)
            Me.comboBoxChartType.Name = "comboBoxChartType"
            Me.comboBoxChartType.Size = New System.Drawing.Size(96, 21)
            Me.comboBoxChartType.TabIndex = 6
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(21, 37)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(64, 16)
            Me.label1.TabIndex = 7
            Me.label1.Text = "ChartType"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.BackColor = System.Drawing.Color.Transparent
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Location = New System.Drawing.Point(16, 187)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(75, 14)
            Me.label5.TabIndex = 8
            Me.label5.Text = "Border Style"
            '
            'label12
            '
            Me.label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label12.Location = New System.Drawing.Point(18, 28)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(144, 1)
            Me.label12.TabIndex = 3
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(19, 238)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(88, 20)
            Me.numericUpDown1.TabIndex = 10
            Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.BackColor = System.Drawing.Color.Transparent
            Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label10.Location = New System.Drawing.Point(18, 12)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(67, 14)
            Me.label10.TabIndex = 2
            Me.label10.Text = "Chart Type"
            '
            'colorPickerButton3
            '
            Me.colorPickerButton3.ColorUISize = New System.Drawing.Size(208, 230)
            Me.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.colorPickerButton3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.colorPickerButton3.Location = New System.Drawing.Point(19, 266)
            Me.colorPickerButton3.Name = "colorPickerButton3"
            Me.colorPickerButton3.SelectedAsBackcolor = True
            Me.colorPickerButton3.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
            Me.colorPickerButton3.Size = New System.Drawing.Size(88, 23)
            Me.colorPickerButton3.TabIndex = 9
            Me.colorPickerButton3.Text = "BorderColor"
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(18, 109)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(144, 1)
            Me.label4.TabIndex = 5
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(18, 93)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(76, 14)
            Me.label3.TabIndex = 4
            Me.label3.Text = "Chart Series"
            '
            'radioButton1
            '
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton1.Location = New System.Drawing.Point(22, 120)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(72, 16)
            Me.radioButton1.TabIndex = 3
            Me.radioButton1.Text = "Saab"
            '
            'radioButton2
            '
            Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton2.Location = New System.Drawing.Point(22, 143)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(72, 16)
            Me.radioButton2.TabIndex = 4
            Me.radioButton2.Text = "Volvo"
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Location = New System.Drawing.Point(132, 12)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(84, 17)
            Me.checkBox3.TabIndex = 15
            Me.checkBox3.Text = "Display Text"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'checkBox2
            '
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox2.Location = New System.Drawing.Point(243, 12)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(120, 16)
            Me.checkBox2.TabIndex = 8
            Me.checkBox2.Text = "InvertStepArea"
            '
            'checkBox1
            '
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(42, 9)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(84, 24)
            Me.checkBox1.TabIndex = 5
            Me.checkBox1.Text = "3D View"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.checkBox1)
            Me.panel2.Controls.Add(Me.checkBox3)
            Me.panel2.Controls.Add(Me.checkBox2)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel2.Location = New System.Drawing.Point(0, 377)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(446, 39)
            Me.panel2.TabIndex = 16
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(622, 416)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Area Charts"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.Area)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.StepArea)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.SplineArea)
            Me.comboBoxChartType.Items.Add(ChartSeriesType.StackingArea)
            Me.comboBoxChartType.SelectedIndex = 0
            Me.checkBox2.Visible = False
        End Sub

#End Region

#Region "Helper Methods"
#Region "InitializeChartData"
        Protected Sub InitializeChartData()
            series1 = New ChartSeries()
            series1.Name = "Saab"
            series1.Type = ChartSeriesType.Area
            series1.Text = series1.Name

            series1.Points.Add(2004, 275)
            series1.Points.Add(2005, 400)
            series1.Points.Add(2006, 525)
            series1.Points.Add(2007, 325)
            series1.Points.Add(2008, 500)

            series2 = New ChartSeries()
            series2.Name = "Volvo"
            series2.Type = ChartSeriesType.Area
            series2.Text = series2.Name

            series2.Points.Add(2004, 475)
            series2.Points.Add(2005, 550)
            series2.Points.Add(2006, 625)
            series2.Points.Add(2007, 425)
            series2.Points.Add(2008, 450)

            series3 = New ChartSeries()
            series3.Name = "BMW"
            series3.Type = ChartSeriesType.Area
            series3.Text = series3.Name

            series3.Points.Add(2004, 500)
            series3.Points.Add(2005, 600)
            series3.Points.Add(2006, 700)
            series3.Points.Add(2007, 525)
            series3.Points.Add(2008, 550)

            Me.chartControl1.PrimaryYAxis.Format = "$0.00"
            Me.chartControl1.Series3D = Me.checkBox1.Checked
            Me.chartControl1.Depth = 100
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 800, 200)

            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series2)
            Me.chartControl1.Series.Add(series3)

        End Sub

#End Region

#Region "SetColor"
        Protected Sub SetColor()
            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.Interior = New BrushInfo(100, New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton2.SelectedColor))
            ElseIf Me.radioButton2.Checked Then
                Me.chartControl1.Series(1).Style.Interior = New BrushInfo(100, New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton2.SelectedColor))
            Else
                Me.chartControl1.Series(2).Style.Interior = New BrushInfo(100, New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton2.SelectedColor))
            End If
            Me.chartControl1.Redraw(True)
        End Sub

#End Region

#End Region

#Region "Events"

        Private Sub colorPickerButton_ColorSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton1.ColorSelected, colorPickerButton2.ColorSelected
            SetColor()
        End Sub
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series3D = Me.checkBox1.Checked
        End Sub

        Private Sub comboBoxChartType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxChartType.SelectedIndexChanged
            For i As Integer = 0 To Me.chartControl1.Series.Count - 1
                Me.chartControl1.Series(i).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
            Next i

            If Me.comboBoxChartType.Text = "StackingArea" Then

                Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 2000, 500)
            Else
                Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 800, 200)
            End If

            If Me.comboBoxChartType.Text = "StepArea" Then

                Me.checkBox2.Visible = True

            Else
                Me.checkBox2.Visible = False
            End If

            Me.chartControl1.Text = Me.comboBoxChartType.Text & " Chart"
            Me.chartControl1.Redraw(True)
        End Sub


        Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton1.CheckedChanged
            Me.chartControl1.Series(0).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
            Me.chartControl1.Series(0).Style.Border.Width = CSng(Me.numericUpDown1.Value)

            If Me.comboBoxChartType.Text = "StepArea" Then
                Me.checkBox2.Visible = True
                'Me.chartControl1.Series(0).ConfigItems.StepItem.Inverted = True
            Else
                Me.checkBox2.Visible = False
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton2.CheckedChanged
            Me.chartControl1.Series(1).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
            Me.chartControl1.Series(1).Style.Border.Width = CSng(Me.numericUpDown1.Value)

            If Me.comboBoxChartType.Text = "StepArea" Then
                Me.checkBox2.Visible = True
                'Me.chartControl1.Series(1).ConfigItems.StepItem.Inverted = True
            Else
                Me.checkBox2.Visible = False
            End If
            Me.chartControl1.Redraw(True)

        End Sub

        Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton3.CheckedChanged
            Me.chartControl1.Series(2).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBoxChartType.SelectedItem.ToString(), True), ChartSeriesType)
            Me.chartControl1.Series(2).Style.Border.Width = CSng(Me.numericUpDown1.Value)

            If Me.comboBoxChartType.Text = "StepArea" Then
                Me.checkBox2.Visible = True
                'Me.chartControl1.Series(2).ConfigItems.StepItem.Inverted = True
            Else
                Me.checkBox2.Visible = False
            End If
            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
            For i As Integer = 0 To Me.chartControl1.Series.Count - 1
                Me.chartControl1.Series(i).ConfigItems.StepItem.Inverted = Me.checkBox2.Checked
            Next i
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            ElseIf radioButton2.Checked Then
                Me.chartControl1.Series(1).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            ElseIf Me.radioButton3.Checked Then
                Me.chartControl1.Series(2).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            End If

            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.Border.Color = Me.colorPickerButton3.SelectedColor
            ElseIf Me.radioButton2.Checked Then
                Me.chartControl1.Series(1).Style.Border.Color = Me.colorPickerButton3.SelectedColor
            ElseIf Me.radioButton3.Checked Then
                Me.chartControl1.Series(2).Style.Border.Color = Me.colorPickerButton3.SelectedColor
            End If

            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub colorPickerButton3_ColorSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPickerButton3.ColorSelected
            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.Border.Color = Me.colorPickerButton3.SelectedColor
            ElseIf Me.radioButton2.Checked Then
                Me.chartControl1.Series(1).Style.Border.Color = Me.colorPickerButton3.SelectedColor
            Else
                Me.chartControl1.Series(2).Style.Border.Color = Me.colorPickerButton3.SelectedColor
            End If

            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            ElseIf radioButton2.Checked Then
                Me.chartControl1.Series(1).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            Else
                Me.chartControl1.Series(2).Style.Border.Width = CSng(Me.numericUpDown1.Value)
            End If

            Me.chartControl1.Redraw(True)
        End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
            For i As Integer = 0 To Me.chartControl1.Series.Count - 1
                Me.chartControl1.Series(i).Style.DisplayText = checkBox3.Checked
                Me.chartControl1.Series(i).Style.Font.FontStyle = FontStyle.Regular
                Me.chartControl1.Series(i).Style.Font.Size = 8.0F
                Me.chartControl1.Series(i).SmartLabels = True
            Next i

        End Sub

#End Region

    End Class
End Namespace
