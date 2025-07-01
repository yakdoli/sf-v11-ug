Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace ChartSmartLabel_2005
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette

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
            chart.ElementsSpacing = 5

            ' Axes Customization

            chart.PrimaryYAxis.Range = New MinMaxInfo(0, 40, 10)
            chart.PrimaryXAxis.Range = New MinMaxInfo(20, 60, 10)
            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.SkyBlue
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.SkyBlue
            chart.PrimaryYAxis.LineType.ForeColor = Color.SkyBlue
            chart.PrimaryXAxis.LineType.ForeColor = Color.SkyBlue
            chart.PrimaryXAxis.GridLineType.DashStyle = DashStyle.DashDotDot
            chart.PrimaryYAxis.GridLineType.DashStyle = DashStyle.DashDotDot
            chart.PrimaryXAxis.Title = "Pressure"
            chart.PrimaryYAxis.Title = "Temperature(Celcius)"
            chart.Text = "Reaction Path"
            chart.Legend.RepresentationType = ChartLegendRepresentationType.None
            chart.Legend.BackColor = Color.Transparent
            chart.Legend.Border.ForeColor = Color.Transparent
            chart.LegendPosition = ChartDock.Top
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.LegendAlignment = ChartAlignment.Center
            chart.Titles(0).Font = New Font("Vernada", 11, FontStyle.Bold)
        End Sub
    End Class
End Namespace
