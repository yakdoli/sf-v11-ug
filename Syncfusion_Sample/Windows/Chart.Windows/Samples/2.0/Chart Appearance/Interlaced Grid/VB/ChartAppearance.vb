Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace WindowsApplication1
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 41,158,214), Color.FromArgb(200,206,215,41), Color.FromArgb(200,255,186,0), Color.FromArgb(200, 247,125,16) }
'			#End Region

'			#Region "Chart Appearance Customization                      "
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.SkyBlue
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 5

'			#End Region

'			#Region "Axes and Legend Customization"

			' Customizing primary axes line and grid line.
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryXAxis.DrawGrid = False
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryYAxis.Range.Min = 0

			' Enable Interlaced grid for X-Axis
			chart.PrimaryXAxis.InterlacedGrid = True
			chart.PrimaryXAxis.InterlacedGridInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(238, 237, 238))
			chart.PrimaryYAxis.InterlacedGrid = False
			chart.PrimaryYAxis.ForceZero = True

			' The below code illustrate how to set the axes range.
			chart.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 100, 5)
			chart.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set
			chart.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 10, 10)
			chart.PrimaryXAxis.ValueType = ChartValueType.DateTime
			chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(New DateTime(2007, 1, 1), New DateTime(2007, 6, 1), 1, ChartDateTimeIntervalType.Months)
			chart.PrimaryXAxis.DateTimeFormat = "MMM" & Constants.vbLf & "yy"
			chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap
			chart.PrimaryYAxis.InterlacedGridInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(238, 237, 238))
			chart.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 40, 5)
			chart.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set
			chart.Font = New Font("Verdana", 17.0f, FontStyle.Bold)

			' Customizing the legend appearance.
			chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesImage
			chart.Legend.ItemsSize = New Size(32, 32)
			chart.LegendPosition = ChartDock.Top
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center
			chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesImage
			chart.Legends(0).Items(0).TextColor = Color.FromArgb(246, 100, 15)
			chart.Legends(0).Items(1).TextColor = Color.FromArgb(36, 119, 51)
			chart.Legends(0).Items(2).TextColor = Color.FromArgb(9, 116, 210)
			For Each cli As ChartLegendItem In chart.Legends(0).Items
				cli.RepresentationSize = New Size(48, 48)
				cli.Font = New Font("Verdana", 8, FontStyle.Bold)
			Next cli

'			#End Region
		End Sub
	End Class
End Namespace
