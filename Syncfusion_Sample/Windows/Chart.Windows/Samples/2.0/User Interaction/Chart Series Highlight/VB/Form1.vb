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
Imports System.Drawing.Drawing2D

Namespace HighlightingSeries
	Partial Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"
		Private series1 As ChartSeries
		Private series2 As ChartSeries
		Private series3 As ChartSeries
		Private color1() As Color = { Color.FromArgb(117, 142, 172), Color.FromArgb(205, 217, 231), Color.FromArgb(117, 142, 172) }
		Private color2() As Color = { Color.FromArgb(150, 172, 90), Color.FromArgb(197, 229, 92), Color.FromArgb(150, 172, 90) }
		Private color3() As Color = { Color.FromArgb(223, 111, 39), Color.FromArgb(251, 169, 113), Color.FromArgb(223, 111, 39) }
		#End Region

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitializeChartData()
		End Sub

		#Region "InitializeChartData"
		''' <summary>
		''' Initializes the ChartControl's data and sets the Chart type
		''' </summary>
		Protected Sub InitializeChartData()
			series1 = New ChartSeries()
			series1.Name = "Product A"
			series1.Text = series1.Name
			series1.Points.Add(500, 16)
			series1.Points.Add(1000, 10)
			series1.Points.Add(1500, 13)
			series1.Points.Add(2000, 17)
			series1.Points.Add(2500, 11)
			series1.Points.Add(3000, 18)
			series1.Type = ChartSeriesType.SplineArea
			Me.chartControl1.Series.Add(series1)

			series2 = New ChartSeries()
			series2.Name = "Product B"
			series2.Text = series2.Name
			series2.Points.Add(500, 6)
			series2.Points.Add(1000, 2)
			series2.Points.Add(1500, 3)
			series2.Points.Add(2000, 7)
			series2.Points.Add(2500, 1)
			series2.Points.Add(3000, 8)
			series2.Type = ChartSeriesType.SplineArea
			Me.chartControl1.Series.Add(series2)

			series3 = New ChartSeries()
			series3.Name = "Product C"
			series3.Text = series3.Name
			series3.Points.Add(500, 26)
			series3.Points.Add(1000, 20)
			series3.Points.Add(1500, 23)
			series3.Points.Add(2000, 27)
			series3.Points.Add(2500, 21)
			series3.Points.Add(3000, 28)
			series3.Type = ChartSeriesType.SplineArea
			Me.chartControl1.Series.Add(series3)

			Me.chartControl1.Series3D = Me.checkBox1.Checked
			Me.cmbChartType.SelectedIndex = 0
			Me.ColumnDrawMode.SelectedIndex = 0
			Me.chartControl1.SeriesHighlight = False
			AddHandler colorPickerButton2.ColorSelected, AddressOf colorPickerButton2_ColorSelected
			AddHandler colorPickerButton1.ColorSelected, AddressOf colorPickerButton1_ColorSelected
			AddHandler numericUpDown1.ValueChanged, AddressOf numericUpDown1_ValueChanged
			ChartAppearance.ApplyChartStyles(Me.chartControl1)
			Me.chartControl1.Cursor = Cursors.Hand
			Me.chartControl1.Depth = 100
		End Sub

		Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			If Hidden_Specific.Checked Then
				Dim bi As New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Series(0).Style.DimmedInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi)
                Dim bi1 As New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Series(1).Style.DimmedInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi1)
                Dim bi2 As New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Series(2).Style.DimmedInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi2)

            End If
        End Sub
        Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
            Dim interior As BrushInfo = Me.chartControl1.Series(0).Style.HighlightInterior
            If interior Is Nothing Then
                interior = New BrushInfo()
            End If
            If Me.radioButton2.Checked Then
                Dim foreColor As Color = interior.ForeColor
                Dim bi As New BrushInfo(GradientStyle.None, foreColor, Me.colorPickerButton2.SelectedColor)
                Dim bi1 As New BrushInfo(GradientStyle.None, foreColor, Me.colorPickerButton2.SelectedColor)
                Dim bi2 As New BrushInfo(GradientStyle.None, foreColor, Me.colorPickerButton2.SelectedColor)

                Me.chartControl1.Series(0).Style.HighlightInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi)
                Me.chartControl1.Series(1).Style.HighlightInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi1)
                Me.chartControl1.Series(2).Style.HighlightInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi2)
                Me.chartControl1.Refresh()
            End If
        End Sub
#End Region

#Region "Event"

        Private Sub cmbChartType_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles cmbChartType.SelectedIndexChanged
            If Me.cmbChartType.Text = "SplineArea" Then
                For i As Integer = 0 To Me.chartControl1.Series.Count - 1
                    Me.chartControl1.Series(i).Type = ChartSeriesType.SplineArea
                Next i
                Me.ColumnDrawMode.Enabled = False
            ElseIf Me.cmbChartType.Text = "Column" Then
                For i As Integer = 0 To Me.chartControl1.Series.Count - 1
                    Me.chartControl1.Series(i).Type = ChartSeriesType.Column
                Next i
                Me.ColumnDrawMode.Enabled = True
            End If
        End Sub
        Private Sub ColumnDrawMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ColumnDrawMode.SelectedIndexChanged
            Me.chartControl1.ColumnDrawMode = CType(System.Enum.Parse(GetType(ChartColumnDrawMode), Me.ColumnDrawMode.SelectedItem.ToString()), ChartColumnDrawMode)
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series3D = Me.checkBox1.Checked
        End Sub

        Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.CheckedChanged
            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.HighlightInterior = Nothing
                Me.chartControl1.Series(1).Style.HighlightInterior = Nothing
                Me.chartControl1.Series(2).Style.HighlightInterior = Nothing
            End If
        End Sub
        Private Sub radioButton2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If radioButton2.Checked Then
                Dim interior As BrushInfo = Me.chartControl1.Series(0).Style.HighlightInterior
                If interior Is Nothing Then
                    interior = New BrushInfo()
                End If
                Dim foreColor As Color = interior.ForeColor
                Dim bi As New BrushInfo(GradientStyle.None, foreColor, Me.colorPickerButton2.SelectedColor)
                Me.chartControl1.Series(0).Style.HighlightInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi)
            End If
        End Sub

        Private Sub radioButton4_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Hidden_Auto.CheckedChanged
            Me.chartControl1.Series(0).Style.DimmedInterior = Nothing
            Me.chartControl1.Series(1).Style.DimmedInterior = Nothing
            Me.chartControl1.Series(2).Style.DimmedInterior = Nothing
        End Sub

        Private Sub radioButton3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Hidden_Specific.CheckedChanged
            If Hidden_Specific.Checked Then
                Dim bi As New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Series(0).Style.DimmedInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi)
                Dim bi1 As New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Series(1).Style.DimmedInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi1)
                Dim bi2 As New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Series(2).Style.DimmedInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi2)
            End If
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            Me.chartControl1.SeriesHighlight = Me.checkBox2.Checked
        End Sub
#End Region

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            If Me.radioButton1.Checked Then
                Me.chartControl1.Series(0).Style.HighlightInterior = Nothing
                Me.chartControl1.Series(1).Style.HighlightInterior = Nothing
                Me.chartControl1.Series(2).Style.HighlightInterior = Nothing
            End If
            If radioButton2.Checked Then
                Dim interior As BrushInfo = Me.chartControl1.Series(0).Style.HighlightInterior
                If interior Is Nothing Then
                    interior = New BrushInfo()
                End If
                Dim foreColor As Color = interior.ForeColor
                Dim bi As New BrushInfo(GradientStyle.None, foreColor, Me.colorPickerButton2.SelectedColor)
                Me.chartControl1.Series(0).Style.HighlightInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi)
            End If
            If Hidden_Specific.Checked Then
                Dim bi As New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Series(0).Style.DimmedInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi)
                Dim bi1 As New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Series(1).Style.DimmedInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi1)
                Dim bi2 As New BrushInfo(GradientStyle.Vertical, Me.colorPickerButton1.SelectedColor, Me.colorPickerButton1.SelectedColor)
                Me.chartControl1.Series(2).Style.DimmedInterior = New BrushInfo(Convert.ToInt16(Me.numericUpDown1.Value), bi2)
            End If

            If Hidden_Auto.Checked Then
                Me.chartControl1.Series(0).Style.DimmedInterior = Nothing
                Me.chartControl1.Series(1).Style.DimmedInterior = Nothing
                Me.chartControl1.Series(2).Style.DimmedInterior = Nothing
            End If

        End Sub
	End Class
End Namespace
