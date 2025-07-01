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

Namespace ErrorBarsChart_2005
    Partial Public Class Form1
        Inherits Office2007Form
#Region "Constructor and Form Load"

        ''' <summary>
        ''' Form Constructor
        ''' </summary>
        Public Sub New()
            InitializeComponent()
            Me.MaximizeBox = False
        End Sub

        ''' <summary>
        ''' Form Load
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitializeErrorChart()
            For Each errorBarShape As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape))
                Me.comboBox1.Items.Add(errorBarShape)
            Next errorBarShape
            Me.comboBox1.SelectedIndex = 3
            For Each symbolShape As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape))
                Me.comboBox2.Items.Add(symbolShape)
            Next symbolShape
            Me.comboBox2.SelectedIndex = 8
            Me.checkBox1.Checked = True
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub

#End Region

#Region "Helpher Methods"

        ''' <summary>
        ''' Initializes Chart and error values
        ''' </summary>
        Public Sub InitializeErrorChart()
            ' Initialize chart series.

            Dim series1 As ChartSeries = New ChartSeries("Series 1", ChartSeriesType.Line)
            series1.Points.Add(1, New Double() {8, 3})
            series1.Points.Add(2, New Double() {10, 2})
            series1.Points.Add(3, New Double() {16, 2})
            series1.Points.Add(4, New Double() {7, 3})
            series1.Points.Add(5, New Double() {12, 3})
            series1.Style.Images = New ChartImageCollection(Me.imageList1.Images)
            series1.Style.Symbol.Color = Color.White
            Me.chartControl1.Series.Add(series1)

            ' Enable the property to draw errorBars to the series.

            series1.ConfigItems.ErrorBars.Enabled = False

        End Sub

#End Region

#Region "Events"
        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
            ' ErrorBarSymbol shape can be set here.

            Me.chartControl1.Series(0).ConfigItems.ErrorBars.SymbolShape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.comboBox1.SelectedItem.ToString()), ChartSymbolShape)

            If Me.comboBox1.SelectedItem.ToString().Equals("Image") Then
                Me.chartControl1.Series(0).Style.ImageIndex = 1
            End If
        End Sub

        Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
            ' Series Symbol shapes can be set here.

            Me.chartControl1.Series(0).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.comboBox2.SelectedItem.ToString()), ChartSymbolShape)
            Me.chartControl1.Redraw(True)
            If Me.comboBox2.SelectedItem.ToString().Equals("Image") Then
                Me.chartControl1.Series(0).Style.Symbol.ImageIndex = 1
            End If
        End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series(0).ConfigItems.ErrorBars.Enabled = Me.checkBox1.Checked
            Me.comboBox1.Enabled = Me.checkBox1.Checked
            Me.comboBox2.Enabled = Me.checkBox1.Checked
        End Sub
#End Region

        Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
            Me.chartControl1.Series3D = CheckBox2.Checked
            Me.chartControl1.Depth = 30
        End Sub

        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
            If e.AxisOrientation = ChartOrientation.Horizontal Then
                If e.Value = 1 Then
                    e.Label = "Microwave" & Constants.vbLf & "Oven"
                ElseIf e.Value = 2 Then
                    e.Label = "Water" & Constants.vbLf & "Purifier"
                ElseIf e.Value = 3 Then
                    e.Label = "Refrigerator"
                ElseIf e.Value = 4 Then
                    e.Label = "Voccume" & Constants.vbLf & "Cleaner"
                ElseIf e.Value = 5 Then
                    e.Label = "Coffee" & Constants.vbLf & "Maker"
                Else
                    e.Label = ""
                End If

                e.Handled = True
            End If
        End Sub
    End Class
End Namespace