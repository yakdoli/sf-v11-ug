Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartSeriesSample
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            '"ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(175,36,119,51), Color.FromArgb(175, 253,171,0), Color.FromArgb(175, 199,23,33) }

            ' "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.ChartInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 0

            ' "Axes Customization"

			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.Range.Min = 0
			chart.PrimaryXAxis.Range.Min = 1998
			chart.PrimaryXAxis.Range.Max = 2009
			chart.PrimaryXAxis.Range.Interval = 1
			chart.PrimaryXAxis.LabelRotate = True
			chart.PrimaryXAxis.LabelRotateAngle = 270
			chart.PrimaryYAxis.Format = "$#"
			chart.Text = "Category wise Sales for the Year 1999-2008"
			chart.PrimaryXAxis.Title = "Year"
			chart.PrimaryYAxis.Title = "Sales (Millions)"
			chart.Series(0).Style.Border.Color = Color.Transparent
			chart.Series(1).Style.Border.Color = Color.Transparent
			chart.Titles(0).Font = New Font("Vernada", 10, FontStyle.Bold)
			chart.Legend.Font = New Font("Vernada", 8, FontStyle.Regular)

            ' "Legend Customization"
			chart.Legend.BackColor = Color.Transparent
			chart.Legend.Border.ForeColor = Color.DarkGray
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendPosition = ChartDock.Top
            chart.LegendAlignment = ChartAlignment.Center
		End Sub
	End Class
End Namespace
