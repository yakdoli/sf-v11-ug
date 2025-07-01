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

Namespace TornadoChart_2005
    Partial Public Class Form1
        Inherits Office2007Form
#Region "Form Load"
        Public Sub New()
            InitializeComponent()
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

        End Sub

#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        Private ccp As ChartCustomPoint
        Private ccp1 As ChartCustomPoint
        Protected Sub InitializeChartData()
            Dim Task1 As ChartSeries = New ChartSeries("Male", ChartSeriesType.Tornado)

            Task1.Points.Add(1, -50, -12)
            Task1.Points.Add(2, -50, -91)
            Task1.Points.Add(3, -50, -397)
            Task1.Points.Add(4, -50, -1072)
            Task1.Points.Add(5, -50, -2117)
            Task1.Points.Add(6, -50, -3094)
            Task1.Points.Add(7, -50, -3804)
            Task1.Points.Add(8, -50, -4712)
            Task1.Points.Add(9, -50, -6203)
            Task1.Points.Add(10, -50, -8415)
            Task1.Points.Add(11, -50, -9771)
            Task1.Points.Add(12, -50, -11076)
            Task1.Points.Add(13, -50, -11282)
            Task1.Points.Add(14, -50, -10449)
            Task1.Points.Add(15, -50, -9987)
            Task1.Points.Add(16, -50, -10016)
            Task1.Points.Add(17, -50, -10657)
            Task1.Points.Add(18, -50, -10862)
            Task1.Points.Add(19, -50, -10670)
            Task1.Points.Add(20, -50, -9954)
            Task1.Points.Add(21, -50, -10471)
            Me.chartControl1.Series.Add(Task1)

            Dim Task2 As ChartSeries = New ChartSeries("Female", ChartSeriesType.Tornado)

            Task2.Points.Add(1, 50, 58)
            Task2.Points.Add(2, 50, 321)
            Task2.Points.Add(3, 50, 1034)
            Task2.Points.Add(4, 50, 2135)
            Task2.Points.Add(5, 50, 3459)
            Task2.Points.Add(6, 50, 4282)
            Task2.Points.Add(7, 50, 4697)
            Task2.Points.Add(8, 50, 5412)
            Task2.Points.Add(9, 50, 6814)
            Task2.Points.Add(10, 50, 8944)
            Task2.Points.Add(11, 50, 10212)
            Task2.Points.Add(12, 50, 11377)
            Task2.Points.Add(13, 50, 11452)
            Task2.Points.Add(14, 50, 10420)
            Task2.Points.Add(15, 50, 9860)
            Task2.Points.Add(16, 50, 9737)
            Task2.Points.Add(17, 50, 10166)
            Task2.Points.Add(18, 50, 10310)
            Task2.Points.Add(19, 50, 10167)
            Task2.Points.Add(20, 50, 9512)
            Task2.Points.Add(21, 50, 10024)
            Me.chartControl1.Series.Add(Task2)
            Me.chartControl1.Titles(0).Text = "Resident Population Projections " & Constants.vbLf & " by Sex and Age: 2005"

            For i As Integer = 0 To Me.chartControl1.Series(0).Points.Count - 1
                ccp = New ChartCustomPoint()
                ccp.XValue = Me.chartControl1.Series(0).Points(i).X
                ccp.YValue = Me.chartControl1.Series(0).Points(i).YValues(1) - 1000
                ccp.CustomType = ChartCustomPointType.ChartCoordinates
                Dim ch As Char() = New Char() {"-"c}
                ccp.Text = Me.chartControl1.Series(0).Points(i).YValues(1).ToString().TrimStart(ch)
                ccp.Color = Color.FromArgb(128, 100, 162)
                ccp.Font.Facename = "Tahoma"
                ccp.Font.Size = 7.0F
                Me.chartControl1.CustomPoints.Add(ccp)

                ccp1 = New ChartCustomPoint()
                ccp1.XValue = Me.chartControl1.Series(1).Points(i).X
                ccp1.YValue = Me.chartControl1.Series(1).Points(i).YValues(1) + 1000
                ccp1.CustomType = ChartCustomPointType.ChartCoordinates
                ccp1.Text = Me.chartControl1.Series(1).Points(i).YValues(1).ToString()
                ccp1.Color = Color.FromArgb(236, 75, 155)
                ccp1.Font.Facename = "Tahoma"
                ccp1.Font.Size = 7.0F

                Me.chartControl1.CustomPoints.Add(ccp1)
            Next i
        End Sub
#End Region

#End Region

#Region "Events"
        Private labels As String() = New String() {"", "100 + ", "95 to 99", "90 to 94", "85 to 89", "80 to 84", "75 to 79", "70 to 74", "65 to 69", "60 to 64", "55 to 59", "50 to 54", "45 to 49", "40 to 44", "35 to 39", "30 to 34", "25 to 29", "20 to 24", "15 to 19", "10 to 14", "5 to 9", "Under 5"}
        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
            If e.AxisOrientation = ChartOrientation.Vertical Then
                Dim index As Integer = CInt(Fix(e.Value))

                If index >= 0 AndAlso index < labels.Length Then
                    'Applying custom label text for X Axis
                    e.Label = labels(index)
                Else
                    e.Label = ""
                End If
            Else
                e.Label = ""
            End If
            e.Handled = True
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series3D = checkBox1.Checked
        End Sub
#End Region
    End Class
End Namespace