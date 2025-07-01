Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartImportData
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            'ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 41, 158, 214), Color.FromArgb(200, 206, 215, 41), Color.FromArgb(200, 255, 186, 0), Color.FromArgb(200, 247, 125, 16)}
            ' Chart Appearance Customization

            chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() {Color.FromArgb(214, 231, 247), Color.White})
            chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
            chart.BorderAppearance.BaseColor = Color.SkyBlue
            chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True

            'Axes Customization
            chart.Series(0).Style.Border.Color = Color.Gray
            chart.Text = "Highest populated cities in the world"

        End Sub
    End Class
End Namespace
