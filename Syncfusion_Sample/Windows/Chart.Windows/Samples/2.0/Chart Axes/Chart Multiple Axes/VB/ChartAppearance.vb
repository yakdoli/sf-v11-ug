Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace Samples
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 9, 116, 210), Color.FromArgb(200, 253, 171, 0), Color.FromArgb(200, 199, 23, 33)}
            ' Chart Appearance Customization

            chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() {Color.FromArgb(214, 231, 247), Color.White})
            chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
            chart.BorderAppearance.BaseColor = Color.SkyBlue
            chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 5

            ' Axes Customization

            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryXAxis.DrawGrid = False
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryYAxis.Title = "Temperature (Centigrade)"
            chart.Titles(0).Font = New Font("Verdana", 10.0F, FontStyle.Bold)
            chart.Series(0).Style.Symbol.Border.Color = Color.Transparent
            chart.Series(1).Style.Symbol.Border.Color = Color.Transparent
            chart.Series(2).Style.Symbol.Border.Color = Color.Transparent

        End Sub
    End Class
End Namespace
