Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Namespace Crossing_Demo_2008
	Partial Public Class Form1
        Inherits Office2007Form


		Public Sub New()
			InitializeComponent()

		End Sub



		Private Sub InitChart()
			Me.chartControl1.PrimaryXAxis.DrawGrid = False
			Me.chartControl1.PrimaryYAxis.DrawGrid = False

		End Sub
		Private Sub Appearanceset()
			chartControl1.Palette = ChartColorPalette.Custom
			chartControl1.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 41,122,139), Color.FromArgb(200, 140,198,62), Color.FromArgb(200,247,148,29), Color.FromArgb(200, 163,48,45) }

'			#Region "Chart Appearance Customization"

			chartControl1.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chartControl1.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chartControl1.ChartInterior = New BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(215, 228, 189), Color.White)
			chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chartControl1.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chartControl1.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = True
			chartControl1.ElementsSpacing = 5

'			#End Region

'			#Region "Axes Customization"

			chartControl1.PrimaryXAxis.HidePartialLabels = True
			chartControl1.PrimaryYAxis.HidePartialLabels = True
			chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chartControl1.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chartControl1.PrimaryXAxis.LineType.Width = 2
			chartControl1.PrimaryYAxis.LineType.Width = 2
			chartControl1.PrimaryXAxis.TickColor = Color.Transparent
			chartControl1.PrimaryYAxis.TickColor = Color.Transparent
			chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.LightGray
			chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.LightGray
			chartControl1.Legend.Visible = False
			chartControl1.Series(0).Style.Symbol.Border.Color = Color.FromArgb(200, 129, 115, 27)
			chartControl1.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)

'			#End Region
		End Sub

		Private Sub Form1_Load_1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitChart()
			Appearanceset()
			Me.chartControl1.Text = "Crossing"
			Dim ser As ChartSeries = New ChartSeries("Area")
			Dim ser1 As ChartSeries = New ChartSeries("Spline")

			ser.Points.Add(2, 45)
			ser.Points.Add(5, 100)
			ser.Points.Add(7, 210)
			ser.Points.Add(9, 110)
			ser.Points.Add(10, 150)
			ser.Points.Add(11, 180)
			ser1.Points.Add(2, 45)
			ser1.Points.Add(5, 100)
			ser1.Points.Add(7, 210)
			ser1.Points.Add(9, 110)
			ser1.Points.Add(10, 150)
			ser1.Points.Add(11, 180)
			ser.Type = ChartSeriesType.Spline
			ser1.Type = ChartSeriesType.Area
			Me.chartControl1.Series.Add(ser)
			Me.chartControl1.Series.Add(ser1)
			Me.comboBox1.SelectedIndex = 0
			Me.comboBox2.SelectedIndex = 0

		End Sub







		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			If CStr(Me.comboBox1.SelectedItem) = "Min" Then
				Me.chartControl1.PrimaryXAxis.Crossing = Double.MinValue
			ElseIf CStr(Me.comboBox1.SelectedItem) = "Max" Then
				Me.chartControl1.PrimaryXAxis.Crossing = Double.MaxValue
			Else
				Me.chartControl1.PrimaryXAxis.Crossing = Convert.ToDouble(Me.comboBox1.SelectedItem)
			End If
			Me.chartControl1.Redraw(True)
		End Sub

		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
			If CStr(Me.comboBox2.SelectedItem) = "Min" Then
				Me.chartControl1.PrimaryYAxis.Crossing = Double.MinValue
			ElseIf CStr(Me.comboBox2.SelectedItem) = "Max" Then
				Me.chartControl1.PrimaryYAxis.Crossing = Double.MaxValue
			Else
				Me.chartControl1.PrimaryYAxis.Crossing = Convert.ToDouble(Me.comboBox2.SelectedItem)
			End If
			Me.chartControl1.Redraw(True)
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			If checkBox1.Checked Then
				Me.chartControl1.Series3D = checkBox1.Checked
			Else
				Me.chartControl1.Series3D = False
			End If
		End Sub

		Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
			If checkBox2.Checked Then
				Me.chartControl1.EnableXZooming = True
				Me.chartControl1.EnableYZooming = True
			Else
				Me.chartControl1.EnableXZooming = False
				Me.chartControl1.EnableYZooming = False
			End If

		End Sub


	End Class
End Namespace
