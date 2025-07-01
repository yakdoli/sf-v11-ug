Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports System.Collections

Namespace HeatMapChart_2005
	Public Partial Class Form1
		Inherits Office2007Form
		Private str As String() = { "Canada", "Brazil", "Argentina", "Arizona", "India", "Pakistan" }
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitializeChartData()
		End Sub

		Private Sub InitializeChartData()
			Dim Stocks As ChartSeries = New ChartSeries("Stocks", ChartSeriesType.HeatMap)
			Stocks.Points.Add(7,4, 10000)
			Stocks.Points.Add(6,3, 5541)
			Stocks.Points.Add(5,2, 6007)
			Stocks.Points.Add(4,2, 5022)
			Stocks.Points.Add(3,2.5, 6882)
			Stocks.Points.Add(2,1.5, 6584)
			Stocks.Points.Add(1,1, 2799)

			Stocks.Styles(0).Text = "US"
			Stocks.Styles(1).Text = "South Carolina"
			Stocks.Styles(2).Text = "Florida"
			Stocks.Styles(3).Text = "Mexico"
			Stocks.Styles(4).Text = "Arizona"
			Stocks.Styles(5).Text = "North Carolina"
			Stocks.Styles(6).Text = "Utah"

			Stocks.Style.DisplayText = True
			Stocks.Style.Font.Size = 9f
			Me.chartControl1.Series.Add(Stocks)

			Me.chartControl1.ShowLegend = False
            Stocks.ConfigItems.HeatMapItem.DisplayTitle = True
            Stocks.ConfigItems.HeatMapItem.LowestValueColor = Color.FromArgb(255, 23, 0)
            Stocks.ConfigItems.HeatMapItem.HighestValueColor = Color.FromArgb(81, 168, 0)
            Stocks.ConfigItems.HeatMapItem.MiddleValueColor = Color.Gold
            Stocks.ConfigItems.HeatMapItem.StartText = "US"
            Stocks.ConfigItems.HeatMapItem.EndText = "Utah"

			Me.chartControl1.ElementsSpacing = 0
			Me.chartControl1.Text = "Stocks- Sales and Expense details"

			Me.chartControl1.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() { Color.FromArgb(214, 231, 247), Color.White })
			Me.chartControl1.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			Me.chartControl1.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			Me.chartControl1.BorderAppearance.BaseColor = Color.SkyBlue
            Me.chartControl1.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
            Me.comboBox1.SelectedIndex = 2

		End Sub

		Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
			Dim series As ChartSeries = Me.chartControl1.Series(0)
            series.ConfigItems.HeatMapItem.LowestValueColor = Me.colorPickerButton1.SelectedColor
			Me.textBox1.BackColor = Me.colorPickerButton1.SelectedColor
			Me.Refresh()
		End Sub

		Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton2.ColorSelected
			Dim series As ChartSeries = Me.chartControl1.Series(0)
            series.ConfigItems.HeatMapItem.HighestValueColor = Me.colorPickerButton2.SelectedColor
			Me.textBox2.BackColor = Me.colorPickerButton2.SelectedColor
			Me.Refresh()
		End Sub

		Private Sub colorPickerButton3_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton3.ColorSelected
			Dim series As ChartSeries = Me.chartControl1.Series(0)
            series.ConfigItems.HeatMapItem.MiddleValueColor = Me.colorPickerButton3.SelectedColor
			Me.textBox3.BackColor = Me.colorPickerButton3.SelectedColor
			Me.Refresh()
		End Sub

		Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar1.Scroll
			Me.chartControl1.Series(0).Points(0).YValues(0) = Me.trackBar1.Value
			Me.chartControl1.Refresh()
		End Sub

		Private Sub trackBar2_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles trackBar2.Scroll
			Me.chartControl1.Series(0).Points(6).YValues(0) = Me.trackBar2.Value
			Me.chartControl1.Refresh()
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series(0).ConfigItems.HeatMapItem.DisplayTitle = Me.checkBox1.Checked
		End Sub

		Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
			Me.chartControl1.Series(0).Style.DisplayText = Me.checkBox2.Checked
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim series As ChartSeries = Me.chartControl1.Series(0)
			Dim point As Random = New Random()
			Dim point1 As Random = New Random()
			Dim points As Double()={point.Next(1,10),point1.Next(2000,10000)}

			Dim chp As ChartPoint = New ChartPoint(Me.chartControl1.Series(0).Points.Count+1,points)
			series.Points.Add(Me.chartControl1.Series(0).Points.Count + 1, points)
			Select Case Me.chartControl1.Series(0).Points.Count Mod 6
				Case 0
					series.Styles(Me.chartControl1.Series(0).Points.Count - 1).Text = str(0)
				Case 1
					series.Styles(Me.chartControl1.Series(0).Points.Count - 1).Text = str(1)
				Case 2
					series.Styles(Me.chartControl1.Series(0).Points.Count - 1).Text = str(2)
				Case 3
					series.Styles(Me.chartControl1.Series(0).Points.Count - 1).Text = str(3)
				Case 4
					series.Styles(Me.chartControl1.Series(0).Points.Count - 1).Text = str(4)
				Case 5
					series.Styles(Me.chartControl1.Series(0).Points.Count - 1).Text = str(5)
            End Select
		End Sub

        Private Sub checkBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
            Me.chartControl1.Series(0).ConfigItems.HeatMapItem.DisplayColorSwatch = Me.checkBox3.Checked
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.Series(0).ConfigItems.HeatMapItem.HeatMapStyle = CType(System.Enum.Parse(GetType(ChartHeatMapLayoutStyle), Me.comboBox1.SelectedItem.ToString(), True), ChartHeatMapLayoutStyle)
        End Sub
    End Class
End Namespace