Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace Chart_StripLine
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 163,48,45) }

            ' Chart Appearance Customization

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.ChartInterior = New BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 0

            ' Axes Customization

			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.MinorGridLineType.ForeColor = Color.DarkGray
			chart.PrimaryYAxis.MinorGridLineType.ForeColor = Color.DarkGray
			chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray
			chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray
			chart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit

			chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.DrawGrid = False
			chart.PrimaryXAxis.Range = New MinMaxInfo(0, 8, 1)
			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.Range = New MinMaxInfo(50, 100, 5)
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.Legend.Position = ChartDock.Top
			chart.LegendAlignment = ChartAlignment.Center
			chart.Series(0).Style.Border.Color = Color.FromArgb(200, 9, 116, 210)
			chart.Series(0).Style.Border.Width = 2
			chart.Text = "Weather Chart"
			chart.PrimaryXAxis.Title = "Days"
            chart.PrimaryYAxis.Title = "Temperature"
		End Sub
	End Class
End Namespace
