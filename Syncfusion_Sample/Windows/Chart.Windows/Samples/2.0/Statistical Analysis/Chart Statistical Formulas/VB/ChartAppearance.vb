Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartStatisticalFormulas
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 253,171,0), Color.FromArgb(200,36,119,51), Color.FromArgb(200, 199,23,33) }

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 5

'			#End Region

'			#Region "Axes Customization"

			chart.PrimaryXAxis.HidePartialLabels = True
			chart.PrimaryYAxis.HidePartialLabels = True
			chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray
			chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)

			chart.LegendPosition = ChartDock.Top
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

			For i As Integer = 0 To chart.Series.Count - 1
				chart.Series(i).Style.Border.Color = Color.Gray
			Next i
'			#End Region
		End Sub
	End Class
End Namespace
