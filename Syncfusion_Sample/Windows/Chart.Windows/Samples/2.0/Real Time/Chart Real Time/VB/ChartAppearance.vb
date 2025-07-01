Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace Syncfusion.Windows.Forms.Chart.Samples
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200,0,255,0) }
            ' Chart Appearance Customization

			chart.BackInterior = New BrushInfo(Color.Black)
			chart.ChartInterior = New BrushInfo(Color.Black)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            ' Axes and Legend Customization

			chart.PrimaryXAxis.LineType.ForeColor = Color.Transparent
			chart.PrimaryYAxis.LineType.ForeColor = Color.Transparent
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.TitleColor = Color.White
			chart.PrimaryYAxis.TitleColor = Color.White
			chart.PrimaryXAxis.ForeColor = Color.White
			chart.PrimaryYAxis.ForeColor = Color.White

			chart.PrimaryXAxis.SmallTicksPerInterval = 2
			chart.PrimaryXAxis.DrawMinorGrid = True
			chart.PrimaryXAxis.DrawGrid = False
			chart.PrimaryYAxis.DrawGrid = False
			chart.PrimaryXAxis.MinorGridLineType.ForeColor = Color.LightGreen
			chart.PrimaryYAxis.SmallTicksPerInterval = 3
			chart.PrimaryYAxis.DrawMinorGrid = True
			chart.PrimaryYAxis.MinorGridLineType.ForeColor = Color.LightGreen
			chart.PrimaryXAxis.MinorGridLineType.DashStyle = DashStyle.Dot
			chart.PrimaryYAxis.MinorGridLineType.DashStyle = DashStyle.Dot

			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.Range.Min = 0
			chart.PrimaryYAxis.Range.Max = 60
			chart.PrimaryYAxis.Range.Interval = 10
			chart.Text = "Network Load"
			chart.PrimaryYAxis.Title = "Server Load (MBytes)"
			chart.PrimaryXAxis.Title = "Date"
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)
			chart.PrimaryXAxis.LabelRotate = True
			chart.PrimaryXAxis.LabelRotateAngle = 270
			chart.Titles(0).ForeColor = Color.White
			chart.Titles(0).Font = New Font("Vernada", 11, FontStyle.Bold)
            chart.Series(0).Style.Border.Width = 2
            chart.Legend.Visible = False
		End Sub
	End Class
End Namespace
