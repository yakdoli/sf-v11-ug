Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace BoxAndWhisker_2005
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' #Region "ApplyCustomPalette"

            chart.Series(0).Style.Border.Color = Color.FromArgb(82, 104, 33)
            Dim color1 As Color() = New Color() {Color.FromArgb(177, 183, 170), Color.FromArgb(229, 236, 220), Color.FromArgb(207, 213, 199), Color.FromArgb(177, 183, 170)}
            chart.Series(0).Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color1)

            ' #End Region

            ' #Region "Chart Appearance Customization"
            chart.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb((CInt(Fix((CByte(215))))), (CInt(Fix((CByte(228))))), (CInt(Fix((CByte(189)))))))
            chart.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            chart.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            chart.BorderAppearance.SkinStyle = ChartBorderSkinStyle.Emboss
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 5
            chart.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryXAxis.DrawGrid = False
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)

            ' #End Region

            ' #Region "Axes Customization"

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.Titles(0).Font = New Font("Verdana", 12.0F, FontStyle.Bold)
            chart.Font = New Font("Verdana", 7.0F, FontStyle.Regular)
            ' #End Region

            ' #Region "Legend Customization "

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
            chart.LegendPosition = ChartDock.Top
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.LegendAlignment = ChartAlignment.Center

            ' #End Region
        End Sub


    End Class
End Namespace
