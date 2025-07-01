Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace RangeAreaChart_Sample
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 191,192,98) }
            ' "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() { Color.FromArgb(214, 231, 247), Color.White })
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.SkyBlue
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.Font = New Font("Verdana", 8.0f, FontStyle.Regular)
			chart.Series(1).Style.Border.Color = Color.Transparent
			chart.Series(0).Style.Border.Color = Color.FromArgb(200, 255, 136, 23)
			chart.PrimaryXAxis.DrawGrid = False
			chart.PrimaryYAxis.DrawGrid = False
			chart.ElementsSpacing = 0
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.Transparent
			chart.PrimaryYAxis.LineType.Width = 2
			chart.PrimaryXAxis.LineType.Width = 2

		   chart.ShowToolTips = True

            ' "Legend Customization"

			chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
			chart.LegendPosition = ChartDock.Bottom
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center
			chart.Legend.Font = New Font("Verdana", 8.0f, FontStyle.Regular)
			chart.ShowLegend = False
            chart.EnableMouseRotation = True

            ' Added Custom points

			Dim ccp As ChartCustomPoint = New ChartCustomPoint()
			ccp.XValue = chart.Series(1).Points(40).X
			ccp.YValue = chart.Series(1).Points(40).YValues(1)
			ccp.CustomType = ChartCustomPointType.ChartCoordinates
			ccp.Text = "Upper Band"
			ccp.Symbol.Shape = ChartSymbolShape.Circle
			ccp.Symbol.Color = Color.White
			ccp.Symbol.Size = New Size(12, 12)
			ccp.Alignment = ChartTextOrientation.RegionUp

			ccp.Color = Color.Black
			ccp.Font.Facename = "Tahoma"
			ccp.Font.Size = 10f
			chart.CustomPoints.Add(ccp)

			Dim ccp1 As ChartCustomPoint = New ChartCustomPoint()
			ccp1.XValue = chart.Series(1).Points(40).X
			ccp1.YValue = chart.Series(1).Points(40).YValues(0)
			ccp1.CustomType = ChartCustomPointType.ChartCoordinates
			ccp1.Text = "Lower Band"
			ccp1.Symbol.Shape = ChartSymbolShape.Circle
			ccp1.Symbol.Color = Color.White
			ccp1.Images = New ChartImageCollection()
			ccp1.Symbol.Size = New Size(12, 12)
			ccp1.Alignment = ChartTextOrientation.RegionDown
			ccp1.Color = Color.Black
			ccp1.Font.Facename = "Tahoma"
			ccp1.Font.Size = 10f
			chart.CustomPoints.Add(ccp1)
'			#End Region
		End Sub
	End Class
End Namespace
