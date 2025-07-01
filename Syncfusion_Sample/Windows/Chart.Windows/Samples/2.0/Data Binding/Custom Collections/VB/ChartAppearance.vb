Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace CustomDataBinding
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 9,116,210) }

'			#End Region

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() { Color.FromArgb(214, 231, 247), Color.White })
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.SkyBlue
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
'			#End Region

'			#Region "Axes Customization"

			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.Range = New MinMaxInfo(8, 18, 2)
			chart.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode
			chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
			chart.Series(0).Style.Border.Color = Color.Transparent

'			#End Region

'			#Region "Legend Customization"

			chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
			chart.LegendPosition = ChartDock.Top
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center

'			#End Region
		End Sub

		Public Shared Sub ApplyChartStyles1(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			   ' Color.FromArgb(200, 253,171,0),
				'Color.FromArgb(200,36,119,51),
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 199,23,33) }

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
			chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode
			chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
			chart.Series(0).Style.Border.Color = Color.Transparent

'			#End Region

'			#Region "Legend Customization"

			chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
			chart.LegendPosition = ChartDock.Top
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center

'			#End Region
		End Sub

	End Class
End Namespace
