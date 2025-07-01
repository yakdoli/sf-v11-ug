Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartPointCollectionMethods_2005
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
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 5

'			#End Region

'			#Region "Axes Customization"

			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryXAxis.DrawGrid = False
			chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204)
			chart.PrimaryYAxis.Range.Min = 0
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)
			chart.Series(0).Style.Border.Color = Color.Transparent

			chart.PrimaryXAxis.TitleColor = Color.MidnightBlue
			chart.PrimaryXAxis.ForeColor = Color.MidnightBlue
			chart.PrimaryYAxis.TitleColor = Color.MidnightBlue
			chart.PrimaryYAxis.ForeColor = Color.MidnightBlue
			chart.Title.ForeColor = Color.MidnightBlue
			chart.Text = "Book Purchases by Category for 2008"
			chart.PrimaryXAxis.Title = "Category of books"
			chart.PrimaryYAxis.Title = "Number of books"
			chart.Indexed = True
			chart.PrimaryXAxis.LabelRotate = True
			chart.PrimaryXAxis.LabelRotateAngle = 270
			chart.PrimaryXAxis.TitleSpacing = 2
			chart.ShowLegend = False

'			#End Region
		End Sub
	End Class
End Namespace
