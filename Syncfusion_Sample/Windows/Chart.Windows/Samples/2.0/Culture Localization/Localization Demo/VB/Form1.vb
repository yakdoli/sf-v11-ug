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
Imports System.Threading

Namespace ChartLocalization_2005
	Partial Public Class Form1
		Inherits Office2007Form
		Public Sub New()
			 InitializeComponent()
			SeriesData()
			ChartAppearance.ApplyChartStyles(Me.chartControl1)
			Me.comboBox1.SelectedIndex = 0
		End Sub
		Public Sub SeriesData()
			chartControl1.Series.Clear()

			Dim Gold As ChartSeries = New ChartSeries("Gold")
			Gold.Points.Add(1992, 37)
			Gold.Points.Add(1996, 44)
			Gold.Points.Add(2000, 40)
			Gold.Points.Add(2004, 35)
			Gold.Points.Add(2008, 36)
			chartControl1.Series.Add(Gold)

			Dim Silver As ChartSeries = New ChartSeries("Silver")
			Silver.Points.Add(1992, 34)
			Silver.Points.Add(1996, 32)
			Silver.Points.Add(2000, 24)
			Silver.Points.Add(2004, 31)
			Silver.Points.Add(2008, 38)
			chartControl1.Series.Add(Silver)

			Dim Bronze As ChartSeries = New ChartSeries("Bronze")
			Bronze.Points.Add(1992, 37)
			Bronze.Points.Add(1996, 25)
			Bronze.Points.Add(2000, 33)
			Bronze.Points.Add(2004, 29)
			Bronze.Points.Add(2008, 36)
			Bronze.Type = ChartSeriesType.Spline
			Bronze.Style.Symbol.Shape = ChartSymbolShape.Circle
			Bronze.Style.Symbol.Color = Color.White
			Bronze.Style.Symbol.Border.Color = Color.Green
			Bronze.Style.Symbol.Border.Width = 2
			Bronze.ZOrder = 0
			chartControl1.Series.Add(Bronze)

			Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(1988, 2012, 4)


		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			Me.chartControl1.Localize = Me.comboBox1.Text
		End Sub
	End Class
End Namespace