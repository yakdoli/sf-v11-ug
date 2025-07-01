Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports ColumnChart2005
Imports System.Collections.Generic
Imports System

Namespace ChartAxisLabelTooltip_2005
	Partial Public Class Form1
		Inherits Form
		Private arrLabel As List(Of String) = New List(Of String)()
		Private arrTooltip As List(Of String) = New List(Of String)()
		Public Sub New()
			InitializeComponent()
			ChartAppearance.ApplyChartStyles(Me.chartControl1)
			AddHandler chartControl1.ChartFormatAxisLabel, AddressOf chartControl1_ChartFormatAxisLabel
			Dim series As ChartSeries = New ChartSeries("Series")
			Me.chartControl1.Indexed = True
			series.Points.Add(0, 120)
			series.Points.Add(1, 220)
			series.Points.Add(2, 150)
			series.Points.Add(3, 240)

			Me.chartControl1.Series.Add(series)

			arrLabel.Add("India")
			arrLabel.Add("Pakistan")
			arrLabel.Add("Srilanka")
			arrLabel.Add("Japan")
			arrTooltip.Add("IND")
			arrTooltip.Add("PAK")
			arrTooltip.Add("SRL")
			arrTooltip.Add("JPN")
			Me.chartControl1.ShowToolTips = True
			Me.chartControl1.Series3D = True

		End Sub



		Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs)
			Dim index As Integer = CInt(Fix(e.Value))
			If e.AxisOrientation = ChartOrientation.Horizontal Then
				If index >= 0 AndAlso index < arrLabel.Count Then
					e.Label = arrLabel(index).ToString()
					e.ToolTip = arrTooltip(index).ToString()
				End If
			End If
			e.Handled = True
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			Me.chartControl1.ShowToolTips = Me.checkBox1.Checked

		End Sub
	End Class
End Namespace