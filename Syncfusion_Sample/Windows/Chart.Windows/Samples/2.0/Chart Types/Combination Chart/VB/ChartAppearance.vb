Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace CombinationCharts
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 36, 119, 51), Color.FromArgb(200, 199, 23, 33), Color.FromArgb(200, 253, 171, 0)}

            ' Chart Appearance Customization

            chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
            chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
            chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
            chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
            chart.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
            chart.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate

            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 0
            chart.Text = "Beijing 2008 Olympics"
            chart.PrimaryXAxis.Title = "Country"
            chart.PrimaryYAxis.Title = "Number of Medals Won"

            chart.Titles(0).Font = New Font("Verdana", 12.0F, FontStyle.Bold)
            chart.Font = New Font("Verdana", 7.0F, FontStyle.Regular)
            chart.Series(1).Style.Border.Width = 2
            chart.Series(0).Style.Border.Width = 2
            chart.Series(2).Style.Border.Color = Color.Transparent
            chart.Series(1).Style.Symbol.Shape = ChartSymbolShape.Diamond
            chart.Series(1).Style.Symbol.Color = Color.White
            chart.Series(0).Style.Symbol.Shape = ChartSymbolShape.Diamond
            chart.Series(0).Style.Symbol.Color = Color.White
            chart.ShowToolTips = True
            chart.Series(2).ConfigItems.ColumnItem.ColumnType = ChartColumnType.Cylinder
            chart.Series(0).Style.Border.Color = Color.Transparent
            chart.Series(1).Style.Border.Color = Color.Transparent

            ' Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent

            ' Legend Customization 

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
            chart.LegendPosition = ChartDock.Bottom
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.LegendAlignment = ChartAlignment.Near
        End Sub
    End Class
End Namespace
