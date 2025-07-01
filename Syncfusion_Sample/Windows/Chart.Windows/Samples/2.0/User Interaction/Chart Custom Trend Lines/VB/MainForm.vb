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
Imports System.Collections
Imports System.Drawing.Drawing2D
Imports Syncfusion.Drawing

Namespace ClickPointDemo2
    Partial Public Class MainForm
        Inherits Office2007Form
#Region "Form Constructor"
        Private rand As Random = New Random()
        Public Sub New()

            InitializeComponent()
            Me.tlineRenderer = New TrendLineRenderer(Me.chartControl1)

        End Sub
#End Region

#Region "Form Load"
        Private tlineRenderer As TrendLineRenderer
        Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            Me.InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartData"
        Private Sub InitializeChartData()
            Dim d As DateTime = DateTime.Now
            Dim series1 As ChartSeries = New ChartSeries("Stock", ChartSeriesType.Line)
            series1.Text = series1.Name
            Me.chartControl1.Series.Add(series1)
            For i As Integer = 0 To 99
                If i <= 10 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(25, 38))
                ElseIf i > 10 AndAlso i <= 12 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(38, 45))
                ElseIf i > 12 AndAlso i <= 19 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(42, 50))
                ElseIf i > 19 AndAlso i <= 23 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(50, 60))
                ElseIf i > 23 AndAlso i <= 29 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(58, 72))
                ElseIf i > 29 AndAlso i <= 32 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(62, 78))
                ElseIf i > 32 AndAlso i <= 49 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(68, 85))
                ElseIf i > 49 AndAlso i <= 51 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(58, 90))
                ElseIf i > 51 AndAlso i <= 61 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(86, 108))
                ElseIf i > 61 AndAlso i <= 71 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(100, 118))
                ElseIf i > 71 AndAlso i <= 81 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(110, 122))
                ElseIf i > 81 AndAlso i <= 91 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(116, 129))
                ElseIf i > 91 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(125, 138))
                End If
            Next i

            Me.chartControl1.Series(0).Style.Border.Width = 2
            Me.chartControl1.Series(0).Style.Interior = New BrushInfo(Color.FromArgb(192, 80, 77))
            Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 160, 20)
            Me.chartControl1.PrimaryYAxis.Format = " 0"

            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = "M/d/yy"
            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
            Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(d.AddDays(-1), d.AddDays(Me.chartControl1.Series(0).Points.Count), 8, ChartDateTimeIntervalType.Days)
            For Each symbol As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape))
                Me.cmbSymbolStyle.Items.Add(symbol)
            Next symbol
            Me.cmbSymbolStyle.SelectedIndex = 1
            Me.comboBox_LineStyle.SelectedIndex = 0
            Me.colorPickerButton3.SelectedColor = Color.Yellow
            Me.checkBox1.Checked = True
            Me.chartControl1.ShowLegend = False
        End Sub
#End Region
#End Region

#Region "Events"
        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
            If IsDBNull(Me.tlineRenderer) Then
                Me.tlineRenderer.LineWidth = CInt(Fix(Me.numericUpDown1.Value))
            End If
        End Sub
        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
            Me.tlineRenderer.LineUpColor = Me.colorPickerButton1.SelectedColor
        End Sub
        Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton2.ColorSelected
            Me.tlineRenderer.LineDownColor = Me.colorPickerButton2.SelectedColor
        End Sub
        Private Sub comboBox_LineStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_LineStyle.SelectedIndexChanged
            Me.tlineRenderer.LineStyle = CType(System.Enum.Parse(GetType(DashStyle), Me.comboBox_LineStyle.SelectedItem.ToString(), True), DashStyle)
        End Sub
        Private Sub cmbSymbolStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSymbolStyle.SelectedIndexChanged
            Me.tlineRenderer.LineSymbol = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.cmbSymbolStyle.SelectedItem.ToString(), True), ChartSymbolShape)
        End Sub
        Private Sub numericUpDown2_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown2.ValueChanged
            If IsDBNull(Me.tlineRenderer) Then
                Dim x As Integer = CInt(Fix(Me.numericUpDown2.Value))
                Me.tlineRenderer.LineSymbolSize = New Size(x, x)
            End If
        End Sub
        Private Sub colorPickerButton3_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton3.ColorSelected
            Me.tlineRenderer.LinesymbolColor = colorPickerButton3.SelectedColor
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.ShowToolTips = Me.checkBox1.Checked
        End Sub
#End Region
    End Class
End Namespace