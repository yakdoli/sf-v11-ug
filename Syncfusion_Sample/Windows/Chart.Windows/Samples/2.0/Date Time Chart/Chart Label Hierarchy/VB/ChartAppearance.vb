#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartLabelHierarchy
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
			chart.ShowLegend = False
			chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)

			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chart.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)

			chart.PrimaryXAxis.DrawGrid = False
			chart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent
			chart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Silver

			chart.PrimaryXAxis.TickSize = New System.Drawing.Size(1, 5)
			chart.PrimaryYAxis.TickSize = New System.Drawing.Size(5, 1)
			chart.LegendsPlacement = ChartPlacement.Outside
			'Adds Custom legend to chart control
			Dim legend1 As ChartLegend = New ChartLegend(chart)
			legend1.Name = "legend1"
			legend1.RepresentationType = ChartLegendRepresentationType.None
			legend1.Position = ChartDock.Bottom
			legend1.Alignment = ChartAlignment.Far
			Dim customItems() As ChartLegendItem = New ChartLegendItem(){}
			Dim clic As ChartLegendItemsCollection = New ChartLegendItemsCollection()
			Dim cli1 As ChartLegendItem = New ChartLegendItem("Press Esc to Cancel Zooming")
			clic.Add(cli1)
			legend1.CustomItems = clic.ToArray()
			chart.Legends.Add(legend1)
		End Sub
	End Class
End Namespace
