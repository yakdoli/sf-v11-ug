Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Chart

Namespace OtherCharts
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(163,48,45), Color.FromArgb(140,198,62) }

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

			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent

			chart.Series(0).Style.Border.Color = Color.Transparent
			chart.Series(1).Style.Border.Color = Color.Transparent

			chart.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
			chart.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 0, 4)
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(211, 224, 241)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(211, 224, 241)
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(211, 224, 241)
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(211, 224, 241)
			chart.PrimaryXAxis.OpposedPosition = True
			chart.ChartArea.XAxesLayoutMode = ChartAxesLayoutMode.Stacking
			chart.LegendPosition = ChartDock.Bottom
			chart.LegendAlignment = ChartAlignment.Near
			chart.PrimaryYAxis.Inversed = True
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(211, 224, 241)
			chart.PrimaryXAxis.OpposedPosition = True
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(211, 224, 241)
			chart.PrimaryXAxis.LabelRotate = True
			chart.PrimaryXAxis.LabelRotateAngle = 90
			chart.Text = "Project Schedule"
			chart.Legend.Items(0).ItemStyle.Spacing = 7
			chart.Legend.Items(1).ItemStyle.Spacing = 7

'			#End Region
		End Sub
	End Class
End Namespace
