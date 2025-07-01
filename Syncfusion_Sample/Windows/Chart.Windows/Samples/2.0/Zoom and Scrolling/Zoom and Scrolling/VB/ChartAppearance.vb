Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace KeyAndMouseZoomingSample
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 129,115,27), Color.FromArgb(200,206,215,41) }

            'Chart Appearance Customization 

			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chart.ElementsSpacing = 5

            ' Axes Customization

			chart.PrimaryXAxis.HidePartialLabels = True
			chart.PrimaryYAxis.HidePartialLabels = True
			chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray
			chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
			chart.Series(1).Style.Border.Color = Color.Transparent
			chart.Series(0).Style.Border.Width = 2
			chart.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)
			chart.Zooming.ShowBorder = True
			chart.Zooming.Border.ForeColor = Color.FromArgb(255, 128, 0)
			chart.Zooming.Interior = New BrushInfo(GradientStyle.PathEllipse, Color.Red, Color.Yellow)
			chart.Zooming.Opacity = 0.6f
			chart.GetVScrollBar(chart.PrimaryYAxis).ZoomButton.Size = New Size(0, 0)
			chart.GetHScrollBar(chart.PrimaryXAxis).ZoomButton.Size = New Size(0, 0)
			chart.EnableXZooming = True
			chart.EnableYZooming = True
			chart.ZoomFactorX = 1
			chart.ZoomFactorX = 1
			chart.ShowScrollBars = True
			chart.LegendPosition = ChartDock.Top
			chart.LegendsPlacement = ChartPlacement.Outside
			chart.LegendAlignment = ChartAlignment.Center
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chart.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(1850, 2007, 10)
			chart.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set
			chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
			chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift

            ' Adds Custom legend to chart control
			Dim legend1 As ChartLegend = New ChartLegend(chart)
			legend1.Name = "legend1"
			legend1.RepresentationType = ChartLegendRepresentationType.None
			legend1.Position = ChartDock.Bottom
			legend1.Alignment = ChartAlignment.Far
			Dim customItems As ChartLegendItem() = New ChartLegendItem(){}
			Dim clic As ChartLegendItemsCollection = New ChartLegendItemsCollection()
			Dim cli1 As ChartLegendItem = New ChartLegendItem("Press Esc to Cancel Zooming")
			clic.Add(cli1)
			legend1.CustomItems = clic.ToArray()
            chart.Legends.Add(legend1)
		End Sub
	End Class
End Namespace
