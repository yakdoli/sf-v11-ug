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

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Office2007Form
#Region "Form's Constructor"
        Public Sub New()
            InitializeComponent()
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartData"
        Public Sub InitializeChartData()
            Dim series As ChartSeries = New ChartSeries()
            series.Type = ChartSeriesType.Spline
            series.Name = "Series 0"
            series.Text = "News and Media"
            series.Points.Add(New DateTime(2007, 1, 1), 13)
            series.Points.Add(New DateTime(2007, 2, 1), 8)
            series.Points.Add(New DateTime(2007, 3, 1), 21)
            series.Points.Add(New DateTime(2007, 4, 1), 13)
            series.Points.Add(New DateTime(2007, 5, 1), 15)
            series.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            'series.Style.DisplayShadow = true;
            series.Style.ImageIndex = 0
            Me.chartControl1.Series.Add(series)

            Dim series1 As ChartSeries = New ChartSeries()
            series1.Type = ChartSeriesType.Spline
            series1.Name = "Series 1"
            series1.Text = "Finance Sector"
            series1.Points.Add(New DateTime(2007, 1, 1), 18)
            series1.Points.Add(New DateTime(2007, 2, 1), 5)
            series1.Points.Add(New DateTime(2007, 3, 1), 26)
            series1.Points.Add(New DateTime(2007, 4, 1), 32)
            series1.Points.Add(New DateTime(2007, 5, 1), 20)
            series1.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series1.Style.ImageIndex = 1
            Me.chartControl1.Series.Add(series1)

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Type = ChartSeriesType.Spline
            series2.Name = "Series 2"
            series2.Text = "Imports And Exports"
            series2.Points.Add(New DateTime(2007, 1, 1), 0)
            series2.Points.Add(New DateTime(2007, 2, 1), 12)
            series2.Points.Add(New DateTime(2007, 3, 1), 20)
            series2.Points.Add(New DateTime(2007, 4, 1), 16)
            series2.Points.Add(New DateTime(2007, 5, 1), 35)
            series2.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            'series2.Style.DisplayShadow = true;
            series2.Style.ImageIndex = 2
            Me.chartControl1.Series.Add(series2)

            Me.chartControl1.Series(0).Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.FromArgb(246, 100, 15))
            Me.chartControl1.Series(0).Style.Border.Color = Color.Black
            Me.chartControl1.Series(0).Style.Border.Width = 3
            Me.chartControl1.Series(1).Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.FromArgb(36, 119, 51))
            Me.chartControl1.Series(1).Style.Border.Color = Color.Black
            Me.chartControl1.Series(1).Style.Border.Width = 3
            Me.chartControl1.Series(2).Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.FromArgb(9, 116, 210))
            Me.chartControl1.Series(2).Style.Border.Color = Color.Black
            Me.chartControl1.Series(2).Style.Border.Width = 3

            Me.chartControl1.Legend.RepresentationType = ChartLegendRepresentationType.SeriesImage
            Me.chartControl1.Legends(0).Items(0).TextColor = Color.FromArgb(246, 100, 15)
            Me.chartControl1.Legends(0).Items(1).TextColor = Color.FromArgb(36, 119, 51)
            Me.chartControl1.Legends(0).Items(2).TextColor = Color.FromArgb(9, 116, 210)

            AddHandler chartControl1.Series(0).PrepareStyle, AddressOf ChartControlSeries_PrepareStyle
            AddHandler chartControl1.Series(1).PrepareStyle, AddressOf ChartControlSeries_PrepareStyle
            AddHandler chartControl1.Series(2).PrepareStyle, AddressOf ChartControlSeries_PrepareStyle
        End Sub
#End Region

#End Region

#Region "Events"

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbInterlacedGridXAxis.CheckedChanged
            'Sets InterlacedGrid for Primary X Axis
            Me.chartControl1.PrimaryXAxis.InterlacedGrid = Me.cbInterlacedGridXAxis.Checked

        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbInterlacedGridYAxis.CheckedChanged
            'Sets InterlacedGrid for Primary Y Axis
            Me.chartControl1.PrimaryYAxis.InterlacedGrid = Me.cbInterlacedGridYAxis.Checked
        End Sub

        Protected Sub ChartControlSeries_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            If args.Index = 17 AndAlso series.Name = "Series 0" Then
                args.Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle
                args.Style.Symbol.Size = New Size(20, 20)
                args.Style.Symbol.Offset = New Size(0, -4)
                args.Style.Symbol.Color = Color.FromArgb(141, 188, 74)
            End If

            If args.Index = 17 AndAlso series.Name = "Series 2" Then
                args.Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle
                args.Style.Symbol.Size = New Size(20, 20)
                args.Style.Symbol.Color = Color.FromArgb(236, 100, 24)
            End If

            If args.Index = 17 AndAlso series.Name = "Series 1" Then
                args.Style.Symbol.Shape = ChartSymbolShape.Triangle
                args.Style.Symbol.Size = New Size(20, 20)
                args.Style.Symbol.Offset = New Size(0, -6)
                args.Style.Symbol.Color = Color.FromArgb(255, 246, 0)
            End If
        End Sub

        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel

            If e.AxisOrientation = ChartOrientation.Vertical Then
                'Applying Formatted Axis label values.
                e.Label = String.Format("{0}%", e.Value)
            End If

            e.Handled = True
        End Sub


#End Region
    End Class
End Namespace
