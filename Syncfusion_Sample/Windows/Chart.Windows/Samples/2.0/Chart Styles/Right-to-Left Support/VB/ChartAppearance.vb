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
            ' ApplyCustomPalette

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(175,36,119,51), Color.FromArgb(175, 253,171,0) }

            ' Chart Appearance Customization

			chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, System.Drawing.Color.White, Color.FromArgb(255, 224, 192))
			chart.ChartInterior = New BrushInfo(GradientStyle.PathRectangle, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.PathRectangle, System.Drawing.Color.White, Color.FromArgb(255, 224, 192))
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 0
            ' Axes and Legend Customization

			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryXAxis.LineType.ForeColor = Color.Gray
			chart.PrimaryYAxis.LineType.ForeColor = Color.Gray
			chart.PrimaryYAxis.LineType.Width = 2
			chart.PrimaryXAxis.LineType.Width = 2

			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.DrawGrid = False
			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.Range = New MinMaxInfo(6, 20, 2)
			chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryXAxis.Range = New MinMaxInfo(0, 400, 50)
			chart.Series(0).Style.Border.Color = Color.Transparent
			chart.Series(1).Style.Border.Color = Color.Transparent
            chart.ShowLegend = False
		End Sub
	End Class
End Namespace
