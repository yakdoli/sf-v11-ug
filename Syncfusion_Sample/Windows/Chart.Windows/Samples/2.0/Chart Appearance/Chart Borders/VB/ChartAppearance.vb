Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace EssentialChartSamples
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 140,198,62), Color.FromArgb(200, 163,48,45) }

'			#End Region

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 6
'			#End Region

'			#Region "Axes Customization"

			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray
			chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.Series(0).Style.Border.Color = Color.Transparent
			chart.Series(1).Style.Border.Color = Color.Transparent
			chart.Series(1).Style.Border.Width = 2
			chart.Series(0).Style.Border.Width = 2
			chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryXAxis.Range = New MinMaxInfo(1994,2001, 1)
			chart.PrimaryXAxis.LabelRotate = True
			chart.PrimaryXAxis.LabelRotateAngle = 270
			chart.PrimaryXAxis.Title = "Year"
			chart.PrimaryYAxis.Title="Millions"
			chart.PrimaryYAxis.Format = "$##"
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Regular)
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)

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
