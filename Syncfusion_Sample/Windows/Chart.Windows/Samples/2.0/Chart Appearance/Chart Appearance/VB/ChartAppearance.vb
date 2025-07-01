Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartAppearance
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' "ApplyCustomPalette"

            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 247, 148, 29), Color.FromArgb(200, 140, 198, 62), Color.FromArgb(200, 163, 48, 45)}

            ' "Chart Appearance Customization"

            chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() {Color.FromArgb(214, 231, 247), Color.White})
            chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
            chart.BorderAppearance.BaseColor = Color.SkyBlue
            chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True

            ' "Axes and Legend Customization"

            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryXAxis.DrawGrid = False
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryYAxis.Range.Min = 0
            chart.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(196, 222, 254))
            chart.Legend.Border.ForeColor = Color.DarkGray
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.LegendAlignment = ChartAlignment.Center
            chart.Titles(0).Font = New Font("Verdana", 12.0F, FontStyle.Regular)
            chart.Font = New Font("Verdana", 7.0F, FontStyle.Regular)
            chart.Series(0).Style.Border.Color = Color.Transparent
            chart.Series(1).Style.Border.Color = Color.Transparent
            chart.Series(2).Style.Border.Color = Color.Transparent
        End Sub
    End Class
End Namespace
