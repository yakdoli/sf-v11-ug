Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace EssentialChartSample
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
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
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chart.PrimaryXAxis.LineType.Width = 2
			chart.PrimaryYAxis.LineType.Width = 2
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.Indexed = True
			chart.Legend.Visible = False
			chart.ShowToolTips = True
			chart.Series(0).Style.Border.Color = Color.Transparent

			' Set the Chart and axes titles.
			chart.Titles(0).Text = "Most Populated Countries in the World " & Constants.vbLf & " Mid-Year 2008"
			chart.PrimaryXAxis.Title = "Countries"
			chart.PrimaryYAxis.Title = "Population in Millions"
			chart.Titles(0).Font = New Font("Verdana", 11.0f, FontStyle.Bold)

			' Set primary X-Axis range.
			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.Range = New MinMaxInfo(0, 1400, 100)

			' Rotate the primary axis labels.
			chart.PrimaryXAxis.LabelRotate = True
			chart.PrimaryXAxis.LabelRotateAngle = 270

			' Set breaks for the chart
			chart.PrimaryYAxis.MakeBreaks = True

'			#End Region
		End Sub
	End Class
End Namespace
