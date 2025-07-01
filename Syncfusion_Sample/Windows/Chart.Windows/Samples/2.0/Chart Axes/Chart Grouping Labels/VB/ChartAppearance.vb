Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace GridLabelsChartSample_2002
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' "ApplyCustomPalette" 

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 9,116,210), Color.FromArgb(200, 253,171,0), Color.FromArgb(200, 199,23,33) }

            ' "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.ChartInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 0

            ' "Axes Customization"

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

			chart.LegendsPlacement = ChartPlacement.Outside
			chart.Legend.Position = ChartDock.Top
			chart.LegendAlignment = ChartAlignment.Center
			chart.Series(0).Style.Symbol.Color = Color.FromArgb(200, 9, 116, 210)
			chart.Series(1).Style.Symbol.Color = Color.FromArgb(200, 253, 171, 0)
			chart.Series(2).Style.Symbol.Color = Color.FromArgb(200, 199, 23, 33)
			chart.Series(0).Style.Symbol.Shape = ChartSymbolShape.Star
			chart.Series(1).Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle
			chart.Series(2).Style.Symbol.Shape = ChartSymbolShape.Diamond

			chart.Legend.RepresentationType = ChartLegendRepresentationType.InvertedTriangle
			chart.Text = "Speed-Torque Variation"
			chart.PrimaryXAxis.Title = "Speed (rpm)"
			chart.PrimaryYAxis.Title = "Torque(Nm)"
			chart.Series(0).Style.Symbol.Border.Color = Color.FromArgb(200, 9, 116, 210)
			chart.Series(1).Style.Symbol.Border.Color = Color.FromArgb(200, 253, 171, 0)
			chart.Series(2).Style.Symbol.Border.Color = Color.FromArgb(200, 199, 23, 33)
			chart.Series(0).Style.Symbol.Size = New Size(10, 10)
			chart.Series(1).Style.Symbol.Size = New Size(10, 10)
            chart.Series(2).Style.Symbol.Size = New Size(10, 10)
		End Sub
	End Class
End Namespace
