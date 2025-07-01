Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace MultipleAxesLayout
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 9,116,210), Color.FromArgb(200,36,119,51), Color.FromArgb(200, 199,23,33) }
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
			chart.ElementsSpacing = 5

'			#End Region

'			#Region "Axes Customization"
			chart.Series(0).Style.Border.Color = Color.Transparent
			chart.Series(1).Style.Border.Color = Color.Transparent
			chart.Series(2).Style.Border.Color = Color.Transparent
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.DarkGray
			chart.PrimaryXAxis.LineType.ForeColor = Color.LightGray
			chart.PrimaryXAxis.LineType.Width = 2F
			chart.PrimaryYAxis.GridLineType.Width = 1F
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(2, 59, 95)
			chart.PrimaryYAxis.LineType.Width = 2F
			chart.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			chart.PrimaryXAxis.DrawGrid = False
'			#End Region
		End Sub
	End Class
End Namespace
