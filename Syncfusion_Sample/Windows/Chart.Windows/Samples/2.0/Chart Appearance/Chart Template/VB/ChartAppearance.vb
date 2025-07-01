Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartTemplate_2005
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 188, 200, 6), Color.FromArgb(200, 234, 90, 81)}

            ' "Chart Appearance Customization"

            chart.BackInterior = New BrushInfo(Color.FromArgb(255, 224, 192))
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ElementsSpacing = 0

            ' "Axes Customization"

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.PrimaryXAxis.Font = New Font("Vernada", 8.0F, FontStyle.Regular)
            chart.PrimaryYAxis.Font = New Font("Vernada", 8.0F, FontStyle.Regular)
            chart.Legend.Font = New Font("Vernada", 8.0F, FontStyle.Regular)
            chart.Text = "Hardware sales per month"
            chart.PrimaryXAxis.Title = "Month"
            chart.PrimaryYAxis.Title = "Sales"

            ' "Legend Customization"

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
            chart.LegendPosition = ChartDock.Top
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.LegendAlignment = ChartAlignment.Center
            chart.Series3D = False
        End Sub
    End Class
End Namespace
