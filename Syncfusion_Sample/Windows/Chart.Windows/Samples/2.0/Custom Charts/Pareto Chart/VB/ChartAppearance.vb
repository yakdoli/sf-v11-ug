Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace Pareto
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
			chart.ShowLegend = False
			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)

			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)

			chart.PrimaryXAxis.DrawGrid = False
			chart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent
			chart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Silver

			chart.PrimaryXAxis.TickSize = New System.Drawing.Size(1, 5)
			chart.PrimaryYAxis.TickSize = New System.Drawing.Size(5, 1)
		End Sub
	End Class
End Namespace
