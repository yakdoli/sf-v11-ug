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

Namespace AxesLabelPosition_2008
	Partial Public Class Form1
		Inherits Office2007Form


		Public Sub New()
			InitializeComponent()

		End Sub



		Private Sub InitChart()
			Me.chartControl1.PrimaryXAxis.DrawGrid = False
			Me.chartControl1.PrimaryYAxis.DrawGrid = False

		End Sub
		Private neg(9) As Boolean
		Private Sub Appearanceset()

'			#Region "Chart Appearance Customization"

			chartControl1.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() { Color.FromArgb(214, 231, 247), Color.White })
			chartControl1.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chartControl1.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chartControl1.BorderAppearance.BaseColor = Color.SkyBlue
			chartControl1.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
			 chartControl1.ElementsSpacing = 5

'			#End Region

'			#Region "Axes Customization"

			 chartControl1.PrimaryYAxis.HidePartialLabels = True
			chartControl1.PrimaryXAxis.LineType.ForeColor = Color.Gray
			chartControl1.PrimaryYAxis.LineType.ForeColor = Color.Gray
			chartControl1.PrimaryXAxis.LineType.Width = 1
			chartControl1.PrimaryYAxis.LineType.Width = 1
			chartControl1.PrimaryXAxis.TickColor = Color.Transparent
			chartControl1.PrimaryYAxis.TickColor = Color.Transparent
			chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.LightGray
			chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.LightGray
			chartControl1.Legend.Visible = False

			chartControl1.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)

'			#End Region
		End Sub
		Private ser As New ChartSeries("Area")
		Private Sub Form1_Load_1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.comboBox1.SelectedIndex = 0
			InitChart()
			Appearanceset()

			Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(-150, 150, 50)
			Me.chartControl1.Text = "Net Export of Selected Nation"
			Me.chartControl1.PrimaryXAxis.Title = "Net Export(Billions of dollars)"

			ser.Points.Add(1, -45)
			ser.Points.Add(2, -80)
			ser.Points.Add(3, 90)
			ser.Points.Add(4, 130)
			ser.Points.Add(5, -100)
			ser.Points.Add(6, 80)

			ser.Type = ChartSeriesType.Bar
			Me.chartControl1.Series.Add(ser)
			Colorset()
			Me.chartControl1.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Inside
			Me.chartControl1.PrimaryYAxis.Crossing = 0


		End Sub

		Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel

			If e.AxisOrientation = ChartOrientation.Vertical Then
				If e.Label = "1" Then
					If customizeEvent Then
						If ser.Points(CInt(Fix(e.Value)) - 1).YValues(0) > 0 Then
							e.AxisLabelPlacement = ChartPlacement.Outside
						Else
							e.AxisLabelPlacement = ChartPlacement.Inside
						End If
					End If
					e.Label = "Canada"
				ElseIf e.Label = "2" Then
					If customizeEvent Then
						If ser.Points(CInt(Fix(e.Value)) - 1).YValues(0) > 0 Then
							e.AxisLabelPlacement = ChartPlacement.Outside
						Else
							e.AxisLabelPlacement = ChartPlacement.Inside
						End If
					End If
					e.Label = "France"

				ElseIf e.Label = "3" Then
					If customizeEvent Then
						If ser.Points(CInt(Fix(e.Value)) - 1).YValues(0) > 0 Then
							e.AxisLabelPlacement = ChartPlacement.Outside
						Else
							e.AxisLabelPlacement = ChartPlacement.Inside
						End If
					End If
					e.Label = "Italy"

				ElseIf e.Label = "4" Then
					If customizeEvent Then
						If ser.Points(CInt(Fix(e.Value)) - 1).YValues(0) > 0 Then
							e.AxisLabelPlacement = ChartPlacement.Outside
						Else
							e.AxisLabelPlacement = ChartPlacement.Inside
						End If
					End If
					e.Label = "Japan"

				ElseIf e.Label = "5" Then
					If customizeEvent Then
						If ser.Points(CInt(Fix(e.Value)) - 1).YValues(0) > 0 Then
							e.AxisLabelPlacement = ChartPlacement.Outside
						Else
							e.AxisLabelPlacement = ChartPlacement.Inside
						End If
					End If
					e.Label = "Britain"

				ElseIf e.Label = "6" Then
					If customizeEvent Then
						If ser.Points(CInt(Fix(e.Value)) - 1).YValues(0) > 0 Then
							e.AxisLabelPlacement = ChartPlacement.Outside
						Else
							e.AxisLabelPlacement = ChartPlacement.Inside
						End If
					End If
					e.Label = "United States"

				Else
					e.Label = ""
				End If
				e.Handled = True
			End If
		End Sub


		Private customizeEvent As Boolean = True
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			customizeEvent = Me.checkBox1.Checked
			If customizeEvent Then
				Me.chartControl1.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Inside
				Me.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift
			Else
				   Me.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.ClippingProtection
			End If
			Me.chartControl1.Refresh()

		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			ser.Points(Me.comboBox1.SelectedIndex).YValues(0) = CDbl(Me.numericUpDown1.Value)
			If checkBox1.Checked Then
				Me.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.ClippingProtection

				Me.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift
			End If
			Colorset()
			Me.chartControl1.Refresh()
		End Sub

		Private Sub Colorset()
			For i As Integer = 0 To ser.Points.Count - 1
				If ser.Points(i).YValues(0) < 0 Then
					ser.Styles(i).Interior = New BrushInfo(Color.FromArgb(200, 163, 48, 45))
				Else
					ser.Styles(i).Interior = New BrushInfo(Color.LightGreen)
				End If
			Next i
		End Sub
	End Class
End Namespace
