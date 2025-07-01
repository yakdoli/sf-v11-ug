Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace Syncfusion.Windows.Forms.Chart.Samples
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette

            Dim color As Color() = New Color() {System.Drawing.Color.FromArgb(253, 225, 21), System.Drawing.Color.FromArgb(243, 177, 13), System.Drawing.Color.FromArgb(253, 225, 21)}
            Dim color2 As Color() = New Color() {System.Drawing.Color.FromArgb(237, 148, 8), System.Drawing.Color.FromArgb(231, 119, 3), System.Drawing.Color.FromArgb(237, 148, 8)}
            Dim color3 As Color() = New Color() {System.Drawing.Color.FromArgb(252, 0, 0), System.Drawing.Color.FromArgb(130, 0, 0), System.Drawing.Color.FromArgb(252, 0, 0)}
			chart.Series(0).Style.Interior = New BrushInfo(GradientStyle.Horizontal, color)
            chart.Series(0).Style.Border.Color = System.Drawing.Color.FromArgb(247, 194, 16)
			chart.Series(1).Style.Interior = New BrushInfo(GradientStyle.Horizontal, color3)
            chart.Series(1).Style.Border.Color = System.Drawing.Color.FromArgb(200, 70, 44)
			chart.Series(2).Style.Interior = New BrushInfo(GradientStyle.Horizontal, color2)
            chart.Series(2).Style.Border.Color = System.Drawing.Color.Orange

            ' Chart Appearance Customization

            chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() {System.Drawing.Color.FromArgb(214, 231, 247), System.Drawing.Color.White})
            chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
            chart.BorderAppearance.BaseColor = System.Drawing.Color.SkyBlue
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 5

            ' Axes Customization

            chart.PrimaryXAxis.TickColor = System.Drawing.Color.Transparent
            chart.PrimaryYAxis.TickColor = System.Drawing.Color.Transparent
            chart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(213, 219, 204)
            chart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(213, 219, 204)
			chart.PrimaryXAxis.DrawGrid = False
            chart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(213, 219, 204)
            chart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(213, 219, 204)
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Regular)
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)
			chart.LegendPosition = ChartDock.Top
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center
            chart.Legend.BackColor = System.Drawing.Color.Transparent
            chart.Legend.Border.ForeColor = System.Drawing.Color.Transparent
			chart.Depth = 100
			chart.Tilt = 15
			chart.Series3D = True
			chart.Rotation = 15
			chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			chart.PrimaryXAxis.Range = New MinMaxInfo(0, 13, 1)
			chart.PrimaryYAxis.Range = New MinMaxInfo(0, 100, 20)
			chart.Spacing = 0
'			#End Region
		End Sub
	End Class
End Namespace
