Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartGetValueSample
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(175, 36, 119, 51), Color.FromArgb(175, 253, 171, 0), Color.FromArgb(175, 199, 23, 33)}

            ' Chart Appearance Customization

            chart.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 0

            ' Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.Text = "Daily Performance "
            chart.PrimaryYAxis.Title = "Task finished(%)"
            chart.PrimaryXAxis.Title = "Daily Review"
            chart.Titles(0).Font = New Font("Vernada", 12, FontStyle.Bold)
            chart.Legend.Font = New Font("Vernada", 8, FontStyle.Regular)
            chart.Series(0).Style.Border.Color = Color.Transparent
            chart.Series(1).Style.Border.Color = Color.Transparent
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryXAxis.Range = New MinMaxInfo(0, 11, 1)
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryYAxis.Range = New MinMaxInfo(0, 100, 25)

            ' Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
            chart.LegendPosition = ChartDock.Top
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.LegendAlignment = ChartAlignment.Center
        End Sub
    End Class
End Namespace
