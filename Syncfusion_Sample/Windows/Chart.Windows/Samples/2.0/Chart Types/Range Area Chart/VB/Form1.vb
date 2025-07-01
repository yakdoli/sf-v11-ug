Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing


Namespace RangeAreaChart_Sample
    Partial Public Class Form1
        Inherits Office2007Form
#Region "Constructor"
        Private color1 As Color() = New Color() {Color.WhiteSmoke, Color.WhiteSmoke}
        Private d As DateTime = DateTime.Now
        Public Sub New()
            InitializeComponent()
        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartData"
        Protected Sub InitializeChartData()
            Me.chartControl1.Series.Clear()

            Dim rand As Random = New Random()

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Type = ChartSeriesType.RangeArea

            Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "Stock1"
            series1.Type = ChartSeriesType.Candle

            series1.Text = series1.Name
            Me.chartControl1.Series.Add(series1)
            AddHandler series1.PrepareStyle, AddressOf series1_PrepareStyle
            Me.chartControl1.Series.Add(series2)

            'Date, High, Low, Close, Open values.
            For i As Integer = 0 To 69
                If i <= 10 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(32, 38), rand.Next(20, 24), rand.Next(28, 32), rand.Next(24, 32))
                    series2.Points.Add(d.AddDays(i), rand.Next(13, 15), rand.Next(37, 40))

                    ' small one
                ElseIf i > 10 AndAlso i <= 12 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(42, 45), rand.Next(30, 34), rand.Next(36, 42), rand.Next(38, 42))
                    series2.Points.Add(d.AddDays(i), rand.Next(20, 21), rand.Next(49, 50))

                ElseIf i > 12 AndAlso i <= 19 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(48, 50), rand.Next(40, 42), rand.Next(42, 48), rand.Next(44, 48))
                    series2.Points.Add(d.AddDays(i), rand.Next(31, 33), rand.Next(58, 60))

                    ' small
                ElseIf i > 19 AndAlso i <= 23 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(54, 60), rand.Next(45, 49), rand.Next(49, 54), rand.Next(50, 52))
                    series2.Points.Add(d.AddDays(i), rand.Next(40, 45), rand.Next(60, 65))

                ElseIf i > 23 AndAlso i <= 29 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(54, 60), rand.Next(45, 49), rand.Next(49, 54), rand.Next(50, 54))
                    series2.Points.Add(d.AddDays(i), rand.Next(40, 45), rand.Next(60, 65))
                    'small
                ElseIf i > 29 AndAlso i <= 32 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(62, 65), rand.Next(55, 57), rand.Next(57, 62), rand.Next(60, 62))
                    series2.Points.Add(d.AddDays(i), rand.Next(45, 50), rand.Next(65, 70))

                ElseIf i > 32 AndAlso i <= 49 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(68, 72), rand.Next(60, 64), rand.Next(62, 68), rand.Next(64, 68))
                    series2.Points.Add(d.AddDays(i), rand.Next(50, 55), rand.Next(75, 78))

                ElseIf i > 49 AndAlso i <= 51 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(58, 60), rand.Next(55, 58), rand.Next(58, 64), rand.Next(63, 64))
                    series2.Points.Add(d.AddDays(i), rand.Next(50, 55), rand.Next(65, 75))

                ElseIf i > 51 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(60, 65), rand.Next(52, 54), rand.Next(54, 58), rand.Next(56, 58))
                    series2.Points.Add(d.AddDays(i), rand.Next(40, 45), rand.Next(60, 70))
                End If
            Next i
            Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 100, 20)
            Me.chartControl1.PrimaryYAxis.Title = "Stock Price"
            Me.chartControl1.Text = "Bollinger Bands"

            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM-dd-yy"
            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(d.AddDays(-1), d.AddDays(60), 10, ChartDateTimeIntervalType.Days)
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate
        End Sub
#End Region
#End Region

#Region "Events"
#Region "ChartFormatAxisLabel"
        Private Sub series1_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = Me.chartControl1.Series(0)
            If Not series Is Nothing Then
                'Up Series - Open value < Close value - Painted with Green.
                ' Down Series - Open value > Close value - Painted with Red.
                If args.Index >= 0 Then
                    If series.Points(args.Index).YValues(3) > series.Points(args.Index).YValues(2) Then

                        args.Style.Interior = New BrushInfo(GradientStyle.Horizontal, Color.Red, Color.Red)
                        args.Style.Border.Color = Color.Red
                    Else
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, Color.Green, Color.Green)
                        args.Style.Border.Color = Color.Green
                    End If
                End If
            End If
        End Sub
        Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
            Me.chartControl1.Series3D = CheckBox1.Checked
        End Sub
#End Region
#End Region
    End Class
End Namespace