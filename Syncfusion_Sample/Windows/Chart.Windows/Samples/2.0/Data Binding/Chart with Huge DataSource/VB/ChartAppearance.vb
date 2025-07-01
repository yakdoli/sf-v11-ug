Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartImportData
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 188,200,6) }

'			#End Region

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)
			chart.ShowToolTips = True

'			#End Region

'			#Region "Axes Customization"
			chart.PrimaryXAxis.LineType.ForeColor = Color.Olive
			chart.PrimaryYAxis.LineType.ForeColor = Color.Olive
			chart.PrimaryYAxis.DrawGrid = False
			chart.PrimaryXAxis.LineType.Width = 2
			chart.PrimaryYAxis.LineType.Width = 2
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.Gray
			chart.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			chart.EnableXZooming = True
			chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.None
			chart.PrimaryXAxis.LabelRotate = True
			chart.PrimaryXAxis.LabelRotateAngle = 90
			chart.ShowToolTips = True
			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.Range = New MinMaxInfo(0, 600, 100)

			'Turns off the legend.
			chart.Legend.Visible = False
			chart.Text = "100000 Original Data Points"
			chart.PrimaryXAxis.Title = "X Values"
			chart.PrimaryYAxis.Title = "Server Load (MBytes)"
			chart.Titles(1).Font = New Font("Vernada", 10, FontStyle.Regular)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
'			#End Region
		End Sub
	End Class
End Namespace
