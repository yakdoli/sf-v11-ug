Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart

Namespace ChartCustomDrawing
    Public Class MainForm
        Inherits Office2007Form
#Region "Private Members"
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private label1 As Label
        Private components As System.ComponentModel.IContainer
        Private color As Color() = New Color() {System.Drawing.Color.FromArgb(150, 172, 90), System.Drawing.Color.FromArgb(197, 229, 92), System.Drawing.Color.FromArgb(150, 172, 90)}
#End Region

#Region "Form's Constructor, Main And Dispose"
        Public Sub New()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New MainForm())
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
            Me.label1 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(240))))), (CInt(Fix((CByte(233))))), (CInt(Fix((CByte(249)))))), System.Drawing.Color.Transparent)
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            ' 
            ' 
            ' 
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0F)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(325, 206)
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.LegendAlignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Near
            Me.chartControl1.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Right
            Me.chartControl1.Location = New System.Drawing.Point(22, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.OriginDate = New System.DateTime(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl1.PrimaryYAxis.OriginDate = New System.DateTime(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl1.ShowLegend = False
            Me.chartControl1.Size = New System.Drawing.Size(429, 336)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            ' 
            ' 
            ' 
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '			Me.chartControl1.ChartAreaPaint += New System.Windows.Forms.PaintEventHandler(Me.chartControl1_ChartAreaPaint);
            ' 
            ' label1
            ' 
            Me.label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label1.Image = (CType(resources.GetObject("label1.Image"), System.Drawing.Image))
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(0, 378)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(473, 45)
            Me.label1.TabIndex = 1
            Me.label1.Text = "                   Arrows in the Primary axes and a line are drawn over the Chart" & "Area using the " & Constants.vbCrLf & "                   ChartAreaPaint event" & Constants.vbCrLf & " "
            ' 
            ' MainForm
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(473, 423)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.MaximizeBox = False
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Custom Drawing"
            '			Me.Load += New System.EventHandler(Me.Form1_Load);
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            IntializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"

#Region "IntializeChartData"
        Private Sub IntializeChartData()
            Dim tooltipTemplate As String = "Capacity: {0}; Range: {1}"
            Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "Technology AAA"
            series1.Type = ChartSeriesType.Scatter
            series1.Text = series1.Name
            series1.Style.TextOffset = 7

            series1.Points.Add(500, 300)
            series1.Styles(0).Text = "Point1"
            series1.Styles(0).ToolTip = String.Format(tooltipTemplate, 300, 500)

            series1.Points.Add(1000, 491)
            series1.Styles(1).Text = "Point2"
            series1.Styles(1).ToolTip = String.Format(tooltipTemplate, 491, 1000)

            series1.Points.Add(1500, 382)
            series1.Styles(2).Text = "Point3"
            series1.Styles(2).ToolTip = String.Format(tooltipTemplate, 382, 1500)

            series1.Points.Add(2000, 437)
            series1.Styles(3).Text = "Point4"
            series1.Styles(3).ToolTip = String.Format(tooltipTemplate, 437, 2000)

            series1.Points.Add(2500, 200)
            series1.Styles(4).Text = "Point5"
            series1.Styles(4).ToolTip = String.Format(tooltipTemplate, 200, 2500)

            series1.Style.DisplayText = True
            series1.Style.TextOrientation = ChartTextOrientation.Up
            Me.chartControl1.Series.Add(series1)
            series1.Style.Font.Size = 7.0F
        End Sub
#End Region
#End Region

#Region "ChartAreaPaint Event"
        ' Using the ChartAreaPaint event we can perform custom drawing over the chart area.
        Private Sub chartControl1_ChartAreaPaint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles chartControl1.ChartAreaPaint

            Dim arrowBrush As Brush = New SolidBrush(System.Drawing.Color.FromArgb(129, 115, 27))
            ' Get the right end of the X axis
            Dim ptX As Point = Me.chartControl1.ChartArea.GetPointByValue(New ChartPoint(Me.chartControl1.PrimaryXAxis.Range.Max, Me.chartControl1.PrimaryYAxis.Range.Min))

            Dim ptX1 As PointF = New PointF(ptX.X - 10, ptX.Y - 6)
            Dim ptX2 As PointF = New PointF(ptX.X, ptX.Y)
            Dim ptX3 As PointF = New PointF(ptX.X - 10, ptX.Y + 6)

            ' Draws an arrow at the end of the X axis
            e.Graphics.FillPolygon(arrowBrush, New PointF() {ptX1, ptX2, ptX3})

            ' Get the top end of the Y axis
            Dim ptY As Point = Me.chartControl1.ChartArea.GetPointByValue(New ChartPoint(Me.chartControl1.PrimaryXAxis.Range.Min, Me.chartControl1.PrimaryYAxis.Range.Max))

            Dim ptY1 As PointF = New PointF(ptY.X - 6, ptY.Y + 10)
            Dim ptY2 As PointF = New PointF(ptY.X, ptY.Y)
            Dim ptY3 As PointF = New PointF(ptY.X + 6, ptY.Y + 10)

            ' Draws an arrow at the top of the Y Axis.
            e.Graphics.FillPolygon(arrowBrush, New PointF() {ptY1, ptY2, ptY3})

            ' Draws a line through the center of the chart.
            Dim pp As Pen = New Pen(System.Drawing.Color.FromArgb(175, 129, 115, 27))
            e.Graphics.DrawLine(pp, ptY.X, ptX.Y, ptX.X, ptY.Y)
        End Sub
#End Region
    End Class
End Namespace

