#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing


Namespace Samples
    '/ <summary>
    '/ The ChartControl sample form.
    '/ </summary>

    Public Class FormMain
        Inherits Office2007Form
        '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing

        Private chartControl1 As ChartControl
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents CBox_AxesLayoutMode As System.Windows.Forms.ComboBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents autoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents autoLabel2 As Syncfusion.Windows.Forms.Tools.AutoLabel
        Private secXAxis As New ChartAxis()



        Public Sub New()
            InitializeComponent()
        End Sub 'New


        '/ <summary>
        '/ Clean up any resources being used.
        '/ </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub 'Dispose



#Region "Windows Form Designer generated code"

        '/ <summary>
        '/ Required method for Designer support - do not modify
        '/ the contents of this method with the code editor.
        '/ </summary>
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.Panel1 = New System.Windows.Forms.Panel
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label5 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.autoLabel2 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.CBox_AxesLayoutMode = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.label1 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.CheckBox1 = New System.Windows.Forms.CheckBox
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(193, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(2, -1, 5, 2)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.ForeColor = System.Drawing.Color.Black
            '
            '
            '
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(196, 54)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.Spacing = 3
            Me.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside
            Me.chartControl1.Location = New System.Drawing.Point(14, 14)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.DrawGrid = False
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(114, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.DrawGrid = False
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.White
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryYAxis.GridLineType.PenType = System.Drawing.Drawing2D.PenType.PathGradient
            Me.chartControl1.PrimaryYAxis.GridLineType.Width = 0.0!
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(114, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.ShowToolTips = True
            Me.chartControl1.Size = New System.Drawing.Size(463, 388)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "Weather Report"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Weather Report"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.White
            Me.Panel1.Controls.Add(Me.comboBox1)
            Me.Panel1.Controls.Add(Me.label5)
            Me.Panel1.Controls.Add(Me.label6)
            Me.Panel1.Controls.Add(Me.autoLabel2)
            Me.Panel1.Controls.Add(Me.CBox_AxesLayoutMode)
            Me.Panel1.Controls.Add(Me.label2)
            Me.Panel1.Controls.Add(Me.label3)
            Me.Panel1.Controls.Add(Me.autoLabel1)
            Me.Panel1.Controls.Add(Me.label1)
            Me.Panel1.Controls.Add(Me.label4)
            Me.Panel1.Controls.Add(Me.CheckBox1)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.Panel1.Location = New System.Drawing.Point(492, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(183, 415)
            Me.Panel1.TabIndex = 2
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Items.AddRange(New Object() {"None", "Wrap", "Ellipsis"})
            Me.comboBox1.Location = New System.Drawing.Point(12, 267)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(143, 21)
            Me.comboBox1.TabIndex = 22
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Location = New System.Drawing.Point(12, 225)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(155, 1)
            Me.label5.TabIndex = 21
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.BackColor = System.Drawing.Color.Transparent
            Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Location = New System.Drawing.Point(9, 209)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(127, 14)
            Me.label6.TabIndex = 20
            Me.label6.Text = "Axes Title Draw Mode"
            '
            'autoLabel2
            '
            Me.autoLabel2.DX = 0
            Me.autoLabel2.DY = 0
            Me.autoLabel2.Location = New System.Drawing.Point(10, 240)
            Me.autoLabel2.Name = "autoLabel2"
            Me.autoLabel2.Size = New System.Drawing.Size(85, 13)
            Me.autoLabel2.TabIndex = 19
            Me.autoLabel2.Text = "Title Draw Mode"
            '
            'CBox_AxesLayoutMode
            '
            Me.CBox_AxesLayoutMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CBox_AxesLayoutMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.CBox_AxesLayoutMode.ForeColor = System.Drawing.Color.MidnightBlue
            Me.CBox_AxesLayoutMode.Items.AddRange(New Object() {"SideBySide", "Stacking"})
            Me.CBox_AxesLayoutMode.Location = New System.Drawing.Point(12, 176)
            Me.CBox_AxesLayoutMode.Name = "CBox_AxesLayoutMode"
            Me.CBox_AxesLayoutMode.Size = New System.Drawing.Size(143, 21)
            Me.CBox_AxesLayoutMode.TabIndex = 18
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(9, 134)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(155, 1)
            Me.label2.TabIndex = 17
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(6, 118)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(105, 14)
            Me.label3.TabIndex = 16
            Me.label3.Text = "Axes layout Mode"
            '
            'autoLabel1
            '
            Me.autoLabel1.DX = 0
            Me.autoLabel1.DY = 0
            Me.autoLabel1.Location = New System.Drawing.Point(11, 149)
            Me.autoLabel1.Name = "autoLabel1"
            Me.autoLabel1.Size = New System.Drawing.Size(114, 13)
            Me.autoLabel1.TabIndex = 15
            Me.autoLabel1.Text = "ChartAxesLayoutMode"
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(9, 34)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(155, 1)
            Me.label1.TabIndex = 14
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.BackColor = System.Drawing.Color.Transparent
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Location = New System.Drawing.Point(6, 18)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(112, 14)
            Me.label4.TabIndex = 13
            Me.label4.Text = "Chart Mutiple Axes"
            '
            'CheckBox1
            '
            Me.CheckBox1.Checked = True
            Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
            Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.CheckBox1.Location = New System.Drawing.Point(12, 58)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(104, 16)
            Me.CheckBox1.TabIndex = 3
            Me.CheckBox1.Text = "Opposed Position"
            '
            'FormMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(675, 415)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.Panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Multiple Axes "
            Me.Panel1.ResumeLayout(False)
            Me.Panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub 'InitializeComponent 
#End Region


        '/ <summary>
        '/ The main entry point for the application.
        '/ </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New FormMain())
        End Sub 'Main



        Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            CBox_AxesLayoutMode.SelectedIndex = 1
            comboBox1.SelectedIndex = 2
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub 'FormMain_Load

        '/ <summary>
        '/ Initializes the ChartControl's data and sets the Chart type
        '/ </summary>
        Dim secYAxis As ChartAxis = New ChartAxis()

        Protected Sub InitializeChartData()

            'Scatter Line
            Dim series1 As ChartSeries = New ChartSeries(" Min.Temperature ")
            series1.Type = ChartSeriesType.Scatter
            Dim start As DateTime = DateTime.Now

            series1.Points.Add(start.AddMonths(0), -5)
            series1.Points.Add(start.AddMonths(1), 0)
            series1.Points.Add(start.AddMonths(2), 3)
            series1.Points.Add(start.AddMonths(3), 6)
            series1.Points.Add(start.AddMonths(4), 15)
            series1.Points.Add(start.AddMonths(5), 22)
            series1.Points.Add(start.AddMonths(6), 30)
            series1.Points.Add(start.AddMonths(7), 28)
            series1.Points.Add(start.AddMonths(8), 21)
            series1.Points.Add(start.AddMonths(9), 13)
            series1.Points.Add(start.AddMonths(10), 6)
            series1.Points.Add(start.AddMonths(11), 1)

            Dim series2 As ChartSeries = New ChartSeries(" Avg.Temperature ")
            series2.Text = series2.Name
            series2.Type = ChartSeriesType.Scatter

            series2.Points.Add(start.AddMonths(0), 2)
            series2.Points.Add(start.AddMonths(1), 4)
            series2.Points.Add(start.AddMonths(2), 5)
            series2.Points.Add(start.AddMonths(3), 11)
            series2.Points.Add(start.AddMonths(4), 19)
            series2.Points.Add(start.AddMonths(5), 26)
            series2.Points.Add(start.AddMonths(6), 35)
            series2.Points.Add(start.AddMonths(7), 32)
            series2.Points.Add(start.AddMonths(8), 25)
            series2.Points.Add(start.AddMonths(9), 16)
            series2.Points.Add(start.AddMonths(10), 9)
            series2.Points.Add(start.AddMonths(11), 2)

            Dim series3 As ChartSeries = New ChartSeries(" Avg. Rainfall")
            series3.Text = series3.Name
            series3.Type = ChartSeriesType.Scatter

            series3.Points.Add(start.AddMonths(0), 62)
            series3.Points.Add(start.AddMonths(1), 73)
            series3.Points.Add(start.AddMonths(2), 95)
            series3.Points.Add(start.AddMonths(3), 107)
            series3.Points.Add(start.AddMonths(4), 85)
            series3.Points.Add(start.AddMonths(5), 60)
            series3.Points.Add(start.AddMonths(6), 73)
            series3.Points.Add(start.AddMonths(7), 105)
            series3.Points.Add(start.AddMonths(9), 83)
            series3.Points.Add(start.AddMonths(10), 84)
            series3.Points.Add(start.AddMonths(11), 96)

            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series2)
            Me.chartControl1.Series.Add(series3)
            Me.chartControl1.Series(0).ScatterConnectType = ScatterConnectType.Line
            Me.chartControl1.Series(1).ScatterConnectType = ScatterConnectType.Line
            Me.chartControl1.Series(2).ScatterConnectType = ScatterConnectType.Line
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(-10, 45, 5)
            Me.chartControl1.PrimaryYAxis.HidePartialLabels = True
            Me.chartControl1.PrimaryXAxis.HidePartialLabels = True
            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM"
            Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(start.AddMonths(-1), start.AddMonths(12), 2, ChartDateTimeIntervalType.Months)
            Me.chartControl1.PrimaryYAxis.ValueType = ChartValueType.Double
            Me.chartControl1.Indexed = False


            secYAxis.DrawGrid = False
            secYAxis.Range = New MinMaxInfo(0, 120, 12)
            secYAxis.HidePartialLabels = True
            secYAxis.OpposedPosition = True
            secYAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate
            secYAxis.LineType.ForeColor = Color.DimGray
            secYAxis.ValueType = ChartValueType.Double
            secYAxis.Orientation = ChartOrientation.Vertical
            secYAxis.GridLineType.BackColor = Color.FromArgb(250, 209, 150, 150)
            secYAxis.GridLineType.ForeColor = Color.FromArgb(250, 230, 193, 193)
            secYAxis.GridLineType.PenType = System.Drawing.Drawing2D.PenType.LinearGradient
            secYAxis.GridLineType.Width = 0
            secYAxis.LineType.ForeColor = Color.FromArgb(200, 193, 114, 114)
            secYAxis.Font = New Font("Verdana", 8.0F)
            Me.chartControl1.Axes.Add(secYAxis)
            Me.chartControl1.Series(2).YAxis = secYAxis
            secYAxis.Title = "Rainfall (Millimeter)"
            Me.comboBox1.Enabled = False
        End Sub 'InitializeChartData

        Private Sub checkbox1_changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
            If (Me.CheckBox1.Checked) Then
                Me.secYAxis.LocationType = ChartAxisLocationType.Auto
                Me.secYAxis.OpposedPosition = True
            Else
                Me.secYAxis.OpposedPosition = False

            End If
        End Sub

        Private Sub CBox_AxesLayoutMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBox_AxesLayoutMode.SelectedIndexChanged
            If CBox_AxesLayoutMode.SelectedItem.ToString() = "SideBySide" Then
                Me.chartControl1.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.SideBySide
            ElseIf CBox_AxesLayoutMode.SelectedItem.ToString() = "Stacking" Then
                Me.chartControl1.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.Stacking
            End If

            If CBox_AxesLayoutMode.SelectedIndex = 0 Then
                Me.comboBox1.Enabled = True
            Else
                Me.comboBox1.Enabled = False
            End If
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.PrimaryYAxis.TitleDrawMode = CType(System.Enum.Parse(GetType(ChartTitleDrawMode), Me.comboBox1.SelectedItem.ToString(), True), ChartTitleDrawMode)
        End Sub
    End Class 'FormMain
End Namespace 'Samples