Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ToolBarSample
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 188,200,6), Color.FromArgb(200, 163,48,45) }

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ElementsSpacing = 5
			chart.Series(0).Style.Border.Color = Color.Transparent
			chart.Series(1).Style.Border.Color = Color.Transparent

'			#End Region

'			#Region "Axes Customization           "
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chart.PrimaryXAxis.LineType.Width = 2
			chart.PrimaryYAxis.LineType.Width = 2
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.Legend.Visible = False
			chart.Text = "Sales Volume Comparison"
			chart.PrimaryXAxis.Title = "Year"
			chart.ShowToolTips = True
			chart.Series(0).Style.Symbol.Border.Color = Color.FromArgb(200, 129, 115, 27)
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.ToolBar.Spacing = 1
			chart.ToolBar.ButtonSize = New Size(25, 25)
			chart.ShowLegend = False
			chart.ToolBar.BackColor = Color.LightGray
'			#End Region
		End Sub
	End Class
End Namespace
