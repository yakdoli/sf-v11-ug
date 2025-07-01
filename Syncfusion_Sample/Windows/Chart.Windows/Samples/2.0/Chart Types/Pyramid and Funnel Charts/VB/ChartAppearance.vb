Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace PyramidAndFunnelChart
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette"
            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(175, 9, 116, 210), Color.FromArgb(175, 253, 171, 0), Color.FromArgb(175, 36, 119, 51), Color.FromArgb(175, 199, 23, 33)}
            ' Chart Appearance Customization

            chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() {Color.FromArgb(214, 231, 247), Color.White})
            chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
            chart.BorderAppearance.BaseColor = Color.SkyBlue
            chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)

            chart.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
            chart.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.Text = "World Crop Statistics"
            chart.Titles(0).Font = New Font("Verdana", 12.0F, FontStyle.Bold)
            chart.Font = New Font("Verdana", 8.0F, FontStyle.Regular)
            ' Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
            chart.LegendPosition = ChartDock.Bottom
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.LegendAlignment = ChartAlignment.Center
            chart.Legend.Font = New Font("Verdana", 8.0F, FontStyle.Regular)
            chart.ShowLegend = False
            chart.EnableMouseRotation = True

        End Sub
    End Class
End Namespace
