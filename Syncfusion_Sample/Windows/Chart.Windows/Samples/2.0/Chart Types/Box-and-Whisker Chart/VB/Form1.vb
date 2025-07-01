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

Namespace BoxAndWhisker_2005
    Partial Public Class Form1
        Inherits Office2007Form
#Region "Form Load"

        Private chartDockControl1 As ChartDockControl

        Public Sub New()
            InitializeComponent()
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub

#End Region

#Region "Helper Methods"

#Region "Initialize Chart Data"
        ''' <summary>
        'Initialize Chart Data
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim BoxPlot As ChartSeries = New ChartSeries("Analysis 1", ChartSeriesType.BoxAndWhisker)

            BoxPlot.Points.Add(0, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150)
            BoxPlot.Points.Add(1, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140)
            BoxPlot.Points.Add(2, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130)
            BoxPlot.Points.Add(3, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120)
            BoxPlot.Points.Add(4, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110)
            BoxPlot.Points.Add(5, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100)

            Me.chartControl1.Series.Add(BoxPlot)

            Dim ccp As ChartCustomPoint = New ChartCustomPoint()
            ccp.XValue = Me.chartControl1.Series(0).Points(5).X + 0.66
            ccp.YValue = Me.chartControl1.Series(0).Points(5).YValues(5)
            ccp.CustomType = ChartCustomPointType.ChartCoordinates
            ccp.Text = "Median"
            ccp.Font.Size = 7.0F
            ccp.Font.Facename = "Tahoma"
            ccp.Color = Color.FromArgb(82, 104, 33)
            Me.chartControl1.CustomPoints.Add(ccp)

            Dim ccp1 As ChartCustomPoint = New ChartCustomPoint()
            ccp1.XValue = Me.chartControl1.Series(0).Points(5).X + 0.6
            ccp1.YValue = Me.chartControl1.Series(0).Points(5).YValues(0)
            ccp1.CustomType = ChartCustomPointType.ChartCoordinates
            ccp1.Text = "Min"
            ccp1.Font.Size = 7.0F
            ccp1.Font.Facename = "Tahoma"
            ccp1.Color = Color.FromArgb(82, 104, 33)

            Me.chartControl1.CustomPoints.Add(ccp1)

            Dim ccp2 As ChartCustomPoint = New ChartCustomPoint()
            ccp2.XValue = Me.chartControl1.Series(0).Points(5).X + 0.6
            ccp2.YValue = Me.chartControl1.Series(0).Points(5).YValues(9)
            ccp2.CustomType = ChartCustomPointType.ChartCoordinates
            ccp2.Text = "Max"
            ccp2.Font.Size = 7.0F
            ccp2.Font.Facename = "Tahoma"
            ccp2.Color = Color.FromArgb(82, 104, 33)

            Me.chartControl1.CustomPoints.Add(ccp2)
        End Sub

#End Region

#End Region

#Region "Events"

        Private labels As String() = New String() {"A", "B", "C", "D", "E", "F"}

        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
            If e.AxisOrientation = ChartOrientation.Horizontal Then
                Dim index As Integer = CInt(Fix(e.Value))
                If index >= 0 AndAlso index < labels.Length Then
                    'Applying custom label text for X Axis
                    e.Label = labels(index)
                Else
                    e.Label = ""
                End If
            End If
            e.Handled = True
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series3D = Me.checkBox1.Checked
        End Sub
#End Region
        Private Sub checkBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
            Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.PercentileMode = Me.checkBox2.Checked
            If checkBox2.Checked Then
                Me.comboBox1.Enabled = True
                Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.Percentile = 0.15
                Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.OutLierWidth = 15
            Else
                Me.comboBox1.Enabled = False
            End If
        End Sub

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.PercentileMode = Me.checkBox2.Checked
            If checkBox2.Checked AndAlso comboBox1.SelectedIndex = 0 Then
                Me.comboBox1.Enabled = True
                Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.Percentile = 0
                Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.OutLierWidth = 15
            ElseIf checkBox2.Checked AndAlso comboBox1.SelectedIndex = 1 Then
                Me.comboBox1.Enabled = True
                Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.Percentile = 0.1
                Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.OutLierWidth = 15
            ElseIf checkBox2.Checked AndAlso comboBox1.SelectedIndex = 2 Then
                Me.comboBox1.Enabled = True
                Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.Percentile = 0.15
                Me.chartControl1.Series(0).ConfigItems.BoxAndWhiskerItem.OutLierWidth = 15
            Else
                Me.comboBox1.Enabled = False
            End If
        End Sub
    End Class
End Namespace