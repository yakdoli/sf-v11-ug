Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace DateDataBinding
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette            "
			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(175,129,115,27) }

'			#End Region

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)
			chart.Series(0).Style.Border.Color = Color.Transparent

'			#End Region

'			#Region "Axes Customization"
			chart.PrimaryXAxis.LineType.ForeColor = Color.Olive
			chart.PrimaryYAxis.LineType.ForeColor = Color.Olive
			chart.PrimaryXAxis.LineType.Width = 2
			chart.PrimaryYAxis.LineType.Width = 2
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.Gray
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.Gray
			chart.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			chart.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			chart.Text = "Product Review"
			chart.PrimaryXAxis.Title = "ExpiresDate"
			chart.PrimaryYAxis.Title = "Quantity"
			chart.Legend.Visible = False
			chart.PrimaryXAxis.ValueType = ChartValueType.DateTime
			chart.PrimaryXAxis.DateTimeFormat = "MM/dd/yy"
			chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
			chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift
'			#End Region
		End Sub
	End Class
End Namespace
