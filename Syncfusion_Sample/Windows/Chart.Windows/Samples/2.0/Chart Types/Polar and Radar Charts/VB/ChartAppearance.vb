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
            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 253, 171, 0), Color.FromArgb(200, 199, 23, 33)}

            ' Chart Appearance Customization

            chart.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ElementsSpacing = 0

            ' Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.DarkGray
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.DarkGray
            chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray
            chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray
            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent

            ' Legend Customization
            chart.Legend.Visible = False
        End Sub
    End Class
End Namespace
