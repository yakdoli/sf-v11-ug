Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartWaterMarker
	Public Partial Class Form1
		Inherits Office2007Form
		Private legendColor As Color() = New Color() { Color.White, Color.White, Color.White, Color.White, Color.FromArgb(189, 221, 253), Color.FromArgb(236, 241, 245) }
		Private legendHighlightColor As Color() = New Color() { Color.FromArgb(249, 196, 74), Color.FromArgb(249, 196, 74), Color.FromArgb(249, 196, 74), Color.FromArgb(189, 221, 253), Color.FromArgb(236, 241, 245) }

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitializeData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            chartControl1.ShowLegend = False

		End Sub
		#Region "InitializeData"
		Protected Sub InitializeData()
            Me.comboBox1.SelectedIndex = 1
            Me.comboBox2.SelectedIndex = 1
            Me.comboBox3.SelectedIndex = 1
			Me.chartControl1.ChartArea.Watermark.Font = New Font("Times New Roman", 14, FontStyle.Bold)
            Me.chartControl1.ChartArea.Watermark.TextColor = Color.MidnightBlue
            Me.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile("..\..\..\..\..\..\..\..\..\Common\images\Chart\Logo.png")
            Me.chartControl1.Depth = 75

            ' "Add Series"

			Me.chartControl1.Series.Clear()

			Dim series1 As ChartSeries = New ChartSeries()
			series1.Name = "Model1_Blue"
			series1.Text = "Blue"
			series1.Points.Add(1996, 40)
			series1.Points.Add(1998, 60)
			series1.Points.Add(2000, 75)
			series1.Points.Add(2002, 60)
			series1.Points.Add(2004, 55)
			series1.Points.Add(2006, 85)
			series1.Type = ChartSeriesType.Spline
			series1.Style.Border.Width = 3
			series1.Style.ImageIndex = 0
            series1.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
			series1.Style.Border.Color = Color.FromArgb(49, 73, 102)
			chartControl1.Series.Add(series1)

			Dim series2 As ChartSeries = New ChartSeries()
			series2.Name = "Model1_Green"
			series2.Text = "Green"
			series2.Points.Add(1996, 35)
			series2.Points.Add(1998, 70)
			series2.Points.Add(2000, 45)
			series2.Points.Add(2002, 20)
			series2.Points.Add(2004, 35)
			series2.Points.Add(2006, 65)
			series2.Type = ChartSeriesType.Spline
			series2.Style.Border.Width = 3
			series2.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series2.Style.ImageIndex = 1
			series2.Style.Border.Color = Color.FromArgb(151, 188, 75)
            chartControl1.Series.Add(series2)
            Me.chartControl1.ShowLegend = False

			Dim series3 As ChartSeries = New ChartSeries()
			series3.Name = "Model2_Blue"
			series3.Text = "Red"
			series3.Points.Add(1996, 60)
			series3.Points.Add(1998, 35)
			series3.Points.Add(2000, 55)
			series3.Points.Add(2002, 30)
			series3.Points.Add(2004, 65)
			series3.Points.Add(2006, 45)
			series3.Type = ChartSeriesType.Spline
			series3.Style.Border.Width = 3
			series3.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series3.Style.ImageIndex = 2
			series3.Style.Border.Color = Color.FromArgb(110, 68, 67)
			chartControl1.Series.Add(series3)

			Dim series4 As ChartSeries = New ChartSeries()
			series4.Name = "Model2_Green"
			series4.Text = "Pink"
			series4.Points.Add(1996, 45)
			series4.Points.Add(1998, 50)
			series4.Points.Add(2000, 35)
			series4.Points.Add(2002, 60)
			series4.Points.Add(2004, 35)
			series4.Points.Add(2006, 55)
			series4.Type = ChartSeriesType.Spline
			series4.Style.Border.Width = 3
			series4.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series4.Style.ImageIndex = 3
			series4.Style.Border.Color = Color.FromArgb(169, 119, 118)
			chartControl1.Series.Add(series4)
		End Sub
			#End Region

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.ChartArea.Watermark.HorizontalAlignment = CType(System.Enum.Parse(GetType(ChartAlignment), Me.comboBox1.SelectedItem.ToString(), True), ChartAlignment)

        End Sub

		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
			Me.chartControl1.ChartArea.Watermark.VerticalAlignment = CType(System.Enum.Parse(GetType(ChartAlignment), Me.comboBox2.SelectedItem.ToString(), True), ChartAlignment)
		End Sub

		Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton2.CheckedChanged
			If radioButton2.Checked Then
				Me.chartControl1.ChartArea.Watermark.Image = Nothing
				Me.chartControl1.ChartArea.Watermark.Text = "Syncfusion Chart"

				Me.label3.Enabled = True
				Me.numericUpDown1.Enabled = True
			ElseIf radioButton2.Checked=False Then
				Me.label3.Enabled = False
                Me.numericUpDown1.Enabled = False
                Me.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile("..\..\..\..\..\..\..\..\..\Common\images\Chart\Logo.png")
			End If
		End Sub

		Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.CheckedChanged
			If radioButton1.Checked Then
				Me.chartControl1.ChartArea.Watermark.Text = Nothing
                Me.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile("..\..\..\..\..\..\..\..\..\Common\images\Chart\Logo.png")
			End If
		End Sub

		Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
			Me.chartControl1.ChartArea.Watermark.Opacity =Convert.ToSingle(Me.numericUpDown1.Value)
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			Me.chartControl1.Series3D = checkBox1.Checked
			If checkBox1.Checked Then
				Me.label4.Enabled=True

			ElseIf checkBox1.Checked=False Then
				Me.label4.Enabled=False

			End If
		End Sub

		Private Sub comboBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox3.SelectedIndexChanged
			Me.chartControl1.ChartArea.Watermark.ZOrder = CType(System.Enum.Parse(GetType(ChartWaterMarkOrder), Me.comboBox3.SelectedItem.ToString(), True), ChartWaterMarkOrder)
		End Sub



	End Class
End Namespace