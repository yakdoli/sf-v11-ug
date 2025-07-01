Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace LineChart2002
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 9,116,210), Color.FromArgb(200,36,119,51), Color.FromArgb(200, 199,23,33) }

'			#End Region

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
			chart.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

			chart.ElementsSpacing = 0
			chart.Text = "National football team ranking(1985-2000)"
			chart.PrimaryXAxis.Title = "Year"
			chart.PrimaryYAxis.Title = "Rank"
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)
			chart.Series(1).Style.Border.Width = 2
			chart.Series(0).Style.Border.Width = 2
			chart.Series(2).Style.Border.Width = 2

			chart.Series(0).Style.Symbol.Border.Color = Color.Transparent
			chart.Series(1).Style.Symbol.Border.Color = Color.Transparent
			chart.Series(2).Style.Symbol.Border.Color = Color.Transparent
			chart.Series(1).Style.Symbol.Shape = ChartSymbolShape.Circle
			chart.Series(1).Style.Symbol.Color = Color.FromArgb(200, 36, 119, 51)
			chart.Series(1).Style.Symbol.Size = New Size(6, 6)
			chart.Series(0).Style.Symbol.Shape = ChartSymbolShape.Square
			chart.Series(0).Style.Symbol.Color = Color.FromArgb(200, 9, 116, 210)
			chart.Series(0).Style.Symbol.Size = New Size(6, 6)
			chart.Series(2).Style.Symbol.Shape = ChartSymbolShape.Square
			chart.Series(2).Style.Symbol.Color = Color.FromArgb(200, 199, 23, 33)
			chart.Series(2).Style.Symbol.Size = New Size(6, 6)
            chart.ShowToolTips = True
            chart.Legend.ShowSymbol = True

'			#End Region

'			#Region "Axes Customization"

			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent

			chart.PrimaryYAxis.Inversed = True
			chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryXAxis.Range = New MinMaxInfo(1985, 2000, 1)
			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.Range = New MinMaxInfo(0, 16, 2)
			chart.PrimaryXAxis.LabelRotate = True
			chart.PrimaryXAxis.LabelRotateAngle = 90
			chart.EnableMouseRotation = True
'			#End Region

'			#Region "Legend Customization"

			chart.Legend.RepresentationType = ChartLegendRepresentationType.StraightLine
			chart.LegendPosition = ChartDock.Top
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center
			chart.Legend.ItemsSize = New Size(30, 30)
			chart.Legend.VisibleCheckBox = True

'			#End Region
		End Sub


	End Class
End Namespace
