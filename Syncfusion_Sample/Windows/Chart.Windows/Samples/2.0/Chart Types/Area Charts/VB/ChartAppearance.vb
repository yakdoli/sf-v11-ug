Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace AreaChartSample
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            '#Region "ApplyCustomPalette"

            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 206, 215, 41), Color.FromArgb(200, 41, 158, 214), Color.FromArgb(200, 247, 125, 16)}

            '#End Region

            '#Region "Chart Appearance Customization"

            chart.BackInterior = New BrushInfo(Color.FromArgb(255, 224, 192))
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 0
            chart.Text = "Area Chart"
            chart.PrimaryXAxis.Title = "Year"

            '#End Region

            '#Region "Axes Customization"

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.Series(0).Style.Border.Color = Color.Transparent
            chart.Series(1).Style.Border.Color = Color.Transparent
            chart.Series(2).Style.Border.Color = Color.Transparent

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
