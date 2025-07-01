Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ErrorBarsChart_2005
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() { Color.FromArgb(214, 231, 247), Color.White })
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.SkyBlue
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)

			chart.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
			chart.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 0
			chart.Text = "Life time for Home Appliances with Error Values"
			chart.PrimaryXAxis.Title = "Product Name"
			chart.PrimaryYAxis.Title = "Life Time(Year)"
			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.Range = New MinMaxInfo(0, 20, 5)
			chart.PrimaryYAxis.DrawGrid = False

'			#End Region

'			#Region "Axes Customization"

			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.TitleSpacing = 6

			chart.Series(0).Style.Interior = New BrushInfo(GradientStyle.Horizontal, New Color() { Color.FromArgb(0, 128, 192), Color.FromArgb(98, 203, 255), Color.FromArgb(0, 128, 192) })
			chart.Series(0).Style.Border.Width = 2.0f
			chart.Series(0).Style.Border.Color = Color.FromArgb(0, 128, 192)
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)
			chart.PrimaryXAxis.Range.Min = 0
			chart.PrimaryYAxis.Range.Min = 0

'			#End Region

'			#Region "Legend Customization"

			chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
			chart.LegendPosition = ChartDock.Top
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center
			chart.Legend.RepresentationType = ChartLegendRepresentationType.StraightLine
			chart.Legend.Items(0).RepresentationSize = New Size(25, 25)
'			#End Region
		End Sub


	End Class
End Namespace
