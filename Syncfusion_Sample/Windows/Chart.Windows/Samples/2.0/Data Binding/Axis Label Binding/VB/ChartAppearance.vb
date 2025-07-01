Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace AxisLabelBinding
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(175, 199,23,33), Color.FromArgb(175, 9,116,210), Color.FromArgb(175, 253,171,0), Color.FromArgb(175, 188,200,6), Color.FromArgb(175,36,119,51) }

'			#End Region

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.ChartInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 0
'			#End Region

'			#Region "Axes Customization"

			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryXAxis.LineType.Width = 2
			chart.PrimaryYAxis.LineType.Width = 2
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.ShowLegend = False
			chart.Text = "Highest populated cities in the world"
			chart.Titles(0).Font = New Font("Vernada", 12, FontStyle.Regular)
			chart.ForeColor = Color.MidnightBlue

'			#End Region
		End Sub
	End Class
End Namespace
