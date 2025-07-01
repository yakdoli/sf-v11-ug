Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace Syncfusion.Windows.Forms.Chart.Samples
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            '#Region "ApplyCustomPalette"
            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 191, 192, 98), Color.FromArgb(200, 250, 206, 35)}
            '#End Region

            '#Region "Chart Appearance Customization"

            chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
            chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
            chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
            chart.BorderAppearance.FrameThickness = New ChartThickness(-1, -1, 1, 1)
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 5

            '#End Region

            '#Region "Axes Customization"

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
            chart.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
            chart.PrimaryXAxis.Title = "Server load(MBytes)"
            chart.Text = "Peak Average Network Load"

            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryYAxis.Range = New MinMaxInfo(0, 20, 4)

            chart.PrimaryYAxis.Title = "Peak Load Hours"
            chart.Series3D = False

            chart.Titles(0).Font = New Font("Verdana", 12.0F, FontStyle.Regular)
            chart.Font = New Font("Verdana", 7.0F, FontStyle.Regular)
            chart.Series(0).Style.TextOrientation = ChartTextOrientation.Right
            chart.Series(0).Style.TextFormat = "{0}"
            chart.Series(1).Style.TextOrientation = ChartTextOrientation.Right
            chart.Series(1).Style.TextFormat = "{0}"
            chart.Series(0).Style.Border.Color = Color.Transparent
            chart.Series(1).Style.Border.Color = Color.Transparent

            '#End Region

            '#Region "Legend Customization "

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
            chart.LegendPosition = ChartDock.Top
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.LegendAlignment = ChartAlignment.Center

            '#End Region
        End Sub
    End Class
End Namespace
