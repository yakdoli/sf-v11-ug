Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartExportData
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(41,158,214) }
'			#End Region

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() { Color.FromArgb(214, 231, 247), Color.White })
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.SkyBlue
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 0

'			#End Region

'			#Region "Axes Customization"

			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryXAxis.DrawGrid = False
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryYAxis.Range.Min = 0

			chart.Text = "Product Orders by Age Group"
			chart.PrimaryXAxis.Title = "Ages"
			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.Range = New MinMaxInfo(0, 6000, 1000)
			chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryXAxis.Range = New MinMaxInfo(0, 10, 1)
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)
			chart.Series(1).Style.Border.Color = Color.Transparent
			chart.Series(0).Style.Border.Width = 2
			chart.Series(0).Style.Symbol.Shape = ChartSymbolShape.Circle

			For i As Integer = 0 To 1
				chart.Series(0).Styles(i).Interior = New BrushInfo(Color.Green)
				chart.Series(0).Styles(i).Symbol.Color = Color.White
				chart.Series(0).Styles(i).Symbol.Border.Color = Color.Green
				chart.Series(0).Styles(i).Symbol.Border.Width = 2
			Next i
			For i As Integer = 2 To chart.Series(0).Points.Count - 1
				chart.Series(0).Styles(i).Interior = New BrushInfo(Color.FromArgb(199, 23, 33))
				chart.Series(0).Styles(i).Symbol.Color = Color.White
				chart.Series(0).Styles(i).Symbol.Border.Color = Color.FromArgb(199, 23, 33)
				chart.Series(0).Styles(i).Symbol.Border.Width = 2
			Next i

			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendPosition = ChartDock.Bottom
			chart.LegendAlignment = ChartAlignment.Near
			chart.Legend.BackInterior = New BrushInfo(Color.Transparent)
			chart.Legend.Items(0).Visible = False

'			#End Region
		End Sub
	End Class
End Namespace
