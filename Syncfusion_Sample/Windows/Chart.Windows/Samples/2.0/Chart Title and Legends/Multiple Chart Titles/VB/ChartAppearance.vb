Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartTitle
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200,246,100,15), Color.FromArgb(200, 188,200,6), Color.FromArgb(200, 234,90,81) }

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() { Color.FromArgb(214, 231, 247), Color.White })
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.SkyBlue
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ElementsSpacing = 5
'			#End Region

'			#Region "Axes and Legend Customization"

			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryXAxis.DrawGrid = False
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.Series(0).Style.Border.Width = 3
			chart.Series(1).Style.Border.Width = 3
			chart.Series(0).Style.Symbol.Border.Color = Color.FromArgb(200, 129, 115, 27)
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)

			chart.LegendPosition = ChartDock.Bottom
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center
			chart.Legend.BackInterior = New BrushInfo(Color.Transparent)
			chart.Legend.ShowBorder = False
			chart.Legend.Border.ForeColor = Color.FromArgb(8, 78, 148)
			chart.Legend.Border.Width = 2
			chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesImage

			For Each cli As ChartLegendItem In chart.Legends(0).Items
				cli.RepresentationSize = New Size(16, 16)
				cli.TextColor = Color.MidnightBlue
				cli.Font = New Font("Verdana", 7.0f, FontStyle.Bold)
			Next cli

'			#End Region
		End Sub
	End Class
End Namespace
