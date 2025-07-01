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
Imports System.Drawing.Drawing2D

Namespace Syncfusion.Windows.Forms.Chart.Samples
	Public Class ChartAppearance
		Private Sub New()
		End Sub
		Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
'			#Region "ApplyCustomPalette"

			chart.Palette = ChartColorPalette.Custom
			chart.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200,0,255,0) }
'			#End Region

'			#Region "Chart Appearance Customization"

			chart.BackInterior = New BrushInfo(Color.Black)
			chart.ChartInterior = New BrushInfo(Color.Black)
			chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None
			chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

'			#End Region

'			#Region "Axes and Legend Customization"

			chart.PrimaryXAxis.LineType.ForeColor = Color.Transparent
			chart.PrimaryYAxis.LineType.ForeColor = Color.Transparent
			chart.PrimaryXAxis.TickColor = Color.Transparent
			chart.PrimaryYAxis.TickColor = Color.Transparent
			chart.PrimaryXAxis.TitleColor = Color.White
			chart.PrimaryYAxis.TitleColor = Color.White
			chart.PrimaryXAxis.ForeColor = Color.White
			chart.PrimaryYAxis.ForeColor = Color.White

			chart.PrimaryXAxis.SmallTicksPerInterval = 2
			chart.PrimaryXAxis.DrawMinorGrid = True
			chart.PrimaryXAxis.DrawGrid = False
			chart.PrimaryYAxis.DrawGrid = False
			chart.PrimaryXAxis.MinorGridLineType.ForeColor = Color.LightGreen
			chart.PrimaryYAxis.SmallTicksPerInterval = 3
			chart.PrimaryYAxis.DrawMinorGrid = True
			chart.PrimaryYAxis.MinorGridLineType.ForeColor = Color.LightGreen
			chart.PrimaryXAxis.MinorGridLineType.DashStyle = DashStyle.Dot
			chart.PrimaryYAxis.MinorGridLineType.DashStyle = DashStyle.Dot

			chart.Text = "CPU Load"
			chart.PrimaryYAxis.Title = "CPU Usage(%)"
			chart.PrimaryXAxis.Title = "Time"
			chart.Font = New Font("Verdana", 7.0f, FontStyle.Regular)
			chart.PrimaryXAxis.LabelRotate = True
			chart.PrimaryXAxis.LabelRotateAngle = 270
			chart.Titles(0).ForeColor = Color.White
			chart.Titles(0).Font = New Font("Vernada", 11, FontStyle.Bold)
			chart.Series(0).Style.Border.Width = 2

'			#End Region
		End Sub
	End Class
End Namespace
