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

Namespace ChartLabels_2005
    Partial Public Class Form1
        Inherits Office2007Form
#Region "Form constructor"
        Public Sub New()
            InitializeComponent()
            InitializeChartData()
            InitialControlSettings()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitialControlSettings"
        Protected Sub InitialControlSettings()
            For Each fontstyle As String In System.Enum.GetNames(GetType(System.Drawing.FontStyle))
                Me.comboBox_FontStyle.Items.Add(fontstyle)
            Next fontstyle

            For Each valueType As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartLabelIntersectAction))
                Me.comboBox_LabelIntersectAction.Items.Add(valueType)
            Next valueType

            Me.comboBox_LabelIntersectAction.SelectedIndex = 2
            Me.comboBox_EdgeDrawingMode.SelectedIndex = 0

            Me.comboBox_FontStyle.SelectedIndex = 0
            Me.comboBox_Fontfamily.SelectedIndex = 20
            Me.comboBox_DoubleFormat.SelectedIndex = 0
            Me.comboBox_DateFormat.SelectedIndex = 16
            Me.comboBox_StringAlign.SelectedIndex = 0
            Me.numericUpDown1.Enabled = False
        End Sub
#End Region

#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type
        ''' </summary>

        Protected Sub InitializeChartData()
            Me.chartControl1.Series.Clear()
            Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "Electronics"
            series1.Text = series1.Name

            series1.Points.Add(0, 6200)
            series1.Points.Add(1, 7500)
            series1.Points.Add(2, 4000)
            series1.Points.Add(3, 4900)
            series1.Points.Add(4, 3500)
            series1.Points.Add(5, 1100)
            series1.Points.Add(6, 950)

            series1.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series1)

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Name = "Home Improvement"
            series2.Text = series2.Name

            series2.Points.Add(0, 6550)
            series2.Points.Add(1, 7300)
            series2.Points.Add(2, 4750)
            series2.Points.Add(3, 5100)
            series2.Points.Add(4, 3750)
            series2.Points.Add(5, 1500)
            series2.Points.Add(6, 1050)

            series2.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series2)

        End Sub
#End Region

#Region " SetFont"
        Protected Sub SetFont()
            If Me.comboBox_Fontfamily.SelectedIndex > 0 Then
                Dim fs As FontStyle = CType(System.Enum.Parse(GetType(FontStyle), Me.comboBox_FontStyle.SelectedItem.ToString(), True), FontStyle)
                Me.chartControl1.PrimaryXAxis.Font = New Font(Me.comboBox_Fontfamily.SelectedItem.ToString(), CSng(Me.numericUpDown_FontSize.Value), fs)
            End If
        End Sub
#End Region
#End Region

#Region "Events"
        Private Sub comboBox_DateFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_DateFormat.SelectedIndexChanged
            Me.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = Me.comboBox_datesHidden.Items(Me.comboBox_DateFormat.SelectedIndex).ToString()
            'Sets the customization of default interval
            radioButton_ChartFormatAxisLabel.Checked = False
        End Sub

        Private Sub font_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_FontStyle.SelectedIndexChanged, comboBox_Fontfamily.SelectedIndexChanged
            SetFont()
        End Sub

        Private Sub numericUpDown_FontSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown_FontSize.ValueChanged
            SetFont()
        End Sub

        Private Sub colorPicker_TextColor_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPicker_TextColor.ColorSelected
            Me.chartControl1.PrimaryXAxis.ForeColor = Me.colorPicker_TextColor.SelectedColor
            Me.textBox_TextColor.BackColor = Me.colorPicker_TextColor.SelectedColor
        End Sub

        Private CustomText_ChartFormat As Boolean = False
        Private Sub radioButton_ChartFormatAxisLabel_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton_ChartFormatAxisLabel.CheckedChanged
            Me.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode
            CustomText_ChartFormat = Me.radioButton_ChartFormatAxisLabel.Checked
            Me.chartControl1.Refresh()
        End Sub

        Private Sub radioButton1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButton1.CheckedChanged
            If radioButton1.Checked Then
                Me.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode
                Me.chartControl1.PrimaryXAxis.Labels.Clear()
                Me.chartControl1.PrimaryXAxis.Labels.Add(New ChartAxisLabel("Mon", Color.MidnightBlue, New Font("Verdana", 11), 2, "", ChartValueType.Custom))
                Me.chartControl1.PrimaryXAxis.Labels.Add(New ChartAxisLabel("Wed", Color.MidnightBlue, New Font("Verdana", 11), 4, "", ChartValueType.Custom))
                Me.chartControl1.PrimaryXAxis.Labels.Add(New ChartAxisLabel("Fri", Color.MidnightBlue, New Font("Verdana", 11), 6, "", ChartValueType.Custom))

            Else
                Me.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.AutomaticMode
            End If
        End Sub

        Private Sub comboBox_LabelIntersectAction_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_LabelIntersectAction.SelectedIndexChanged
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = CType(System.Enum.Parse(GetType(ChartLabelIntersectAction), Me.comboBox_LabelIntersectAction.SelectedItem.ToString(), True), ChartLabelIntersectAction)
        End Sub

        Private Sub comboBox_EdgeDrawingMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_EdgeDrawingMode.SelectedIndexChanged
            Me.chartControl1.PrimaryXAxis.EdgeLabelsDrawingMode = CType(System.Enum.Parse(GetType(ChartAxisEdgeLabelsDrawingMode), Me.comboBox_EdgeDrawingMode.SelectedItem.ToString(), True), ChartAxisEdgeLabelsDrawingMode)
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
            Me.chartControl1.PrimaryXAxis.HidePartialLabels = Me.checkBox2.Checked
        End Sub

        Private Sub comboBox_StringAlign_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_StringAlign.SelectedIndexChanged
            Me.chartControl1.PrimaryXAxis.LabelAlignment = CType(System.Enum.Parse(GetType(StringAlignment), Me.comboBox_StringAlign.SelectedItem.ToString(), True), StringAlignment)

        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.PrimaryXAxis.LabelRotate = Me.checkBox1.Checked
            Me.numericUpDown1.Enabled = Me.checkBox1.Checked
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
            Me.chartControl1.PrimaryXAxis.LabelRotateAngle = CInt(Fix(Me.numericUpDown1.Value))
        End Sub

        Private Sub comboBox_DoubleFormat_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox_DoubleFormat.SelectedIndexChanged
            Select Case Me.comboBox_DoubleFormat.SelectedIndex
                Case 0
                    Me.chartControl1.PrimaryYAxis.Format = "0"
                Case 1
                    Me.chartControl1.PrimaryYAxis.Format = "0.00"
                Case 2
                    Me.chartControl1.PrimaryYAxis.Format = "$#,##0.00"
                Case 3
                    Me.chartControl1.PrimaryYAxis.Format = "0.000"
                Case 4
                    Me.chartControl1.PrimaryYAxis.Format = "$#,##0.000"
            End Select

        End Sub

#Region "ChartFormatAxisLabel"
        Private arr As String() = New String(7) {}
        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
            Dim index As Integer = CInt(Fix(e.Value)) + 1
            If e.AxisOrientation = ChartOrientation.Horizontal Then
                If CustomText_ChartFormat Then
                    Dim CustomText As String = Me.textBox1.Text
                    arr = CustomText.Split(New Char() {ControlChars.Lf})
                    If index < arr.Length Then
                        e.Label = arr(index).ToString()
                    End If
                End If
            End If
            e.Handled = True
        End Sub
#End Region

#End Region
    End Class
End Namespace