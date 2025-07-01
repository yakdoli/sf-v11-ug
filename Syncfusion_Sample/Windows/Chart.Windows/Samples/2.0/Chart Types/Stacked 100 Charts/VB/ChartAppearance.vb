Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace Stacked100Charts
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 253, 171, 0), Color.FromArgb(200, 36, 119, 51), Color.FromArgb(200, 199, 23, 33)}

            'Chart Appearance Customization

            chart.BackInterior = New BrushInfo(Color.FromArgb(255, 224, 192))
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 0
            chart.Text = "Area Chart"
            chart.PrimaryXAxis.Title = "Year"

            ' Axes Customization

            chart.Indexed = True

            chart.Series(0).ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.FlatRectangle
            chart.Series(1).ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.FlatRectangle
            chart.Series(2).ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.FlatRectangle
            chart.Series(3).ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.FlatRectangle

            chart.Legend.Position = ChartDock.Top
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(134, 134, 134)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(134, 134, 134)
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(134, 134, 134)
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(134, 134, 134)
            chart.Legend.Border.ForeColor = Color.Black
            chart.Spacing = 40
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryYAxis.Range = New MinMaxInfo(0, 100, 20)
            chart.Series(0).Style.Border.Color = Color.White
            chart.Series(1).Style.Border.Color = Color.White
            chart.Series(2).Style.Border.Color = Color.White
            chart.Series(3).Style.Border.Color = Color.White

            ' Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
            chart.LegendPosition = ChartDock.Top
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.LegendAlignment = ChartAlignment.Center

        End Sub
    End Class
End Namespace
