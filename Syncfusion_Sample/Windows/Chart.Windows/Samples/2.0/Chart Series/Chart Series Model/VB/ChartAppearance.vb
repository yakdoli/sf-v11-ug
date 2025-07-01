Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartSeriesModel
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 129,115,27) }

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
			chart.PrimaryXAxis.InterlacedGrid = True
			chart.PrimaryXAxis.InterlacedGridInterior = New BrushInfo(GradientStyle.Horizontal, Color.FromArgb(215, 228, 189), Color.White)
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chart.PrimaryXAxis.LineType.Width = 2
			chart.PrimaryYAxis.LineType.Width = 2
			chart.PrimaryXAxis.TickColor = Color.White
			chart.PrimaryYAxis.TickColor = Color.White
			chart.PrimaryXAxis.ValueType = ChartValueType.DateTime
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.Legend.Visible = False
			chart.ShowToolTips = True
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.StyleDialogOptions.ShowBorderTab = True
			chart.StyleDialogOptions.ShowTextTab = False
			chart.StyleDialogOptions.ShowFancyToolTipsTab = False
			chart.StyleDialogOptions.ShowInteriorTab = False
			chart.StyleDialogOptions.ShowShadowTab = False
			chart.StyleDialogOptions.ShowSymbolTab = False
			chart.ShowLegend = False
'			#End Region
		End Sub
	End Class
End Namespace
