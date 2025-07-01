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

Namespace ChartPoints_2005
    Partial Public Class Form1
        Inherits Office2007Form
#Region "Form Load"
        Public Sub New()
            InitializeComponent()
            InitializeChartData()
            InitializeControlSettings()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region " InitializeChartData"
        Protected Sub InitializeChartData()
            Dim Wheat As ChartSeries = New ChartSeries("Wheat", ChartSeriesType.Line)
            Wheat.Points.Add(1997, 250)
            Wheat.Points.Add(1998, 235)
            Wheat.Points.Add(1999, 290)
            Wheat.Points.Add(2000, 400)
            Wheat.Points.Add(2001, 480)
            Wheat.Points.Add(2002, 490)
            Wheat.Points.Add(2003, 480)
            Wheat.Points.Add(2004, 500)
            Wheat.Points.Add(2005, 590)
            Wheat.Points.Add(2006, 660)
            Wheat.Points.Add(2007, 600)
            Me.chartControl1.Series.Add(Wheat)
            Wheat.Style.Border.Width = 3
            Wheat.Style.Symbol.Shape = ChartSymbolShape.Circle
            Wheat.Style.Symbol.Color = Color.White
            Wheat.Style.Symbol.Border.Color = Color.FromArgb(200, 253, 171, 0)
            Wheat.Style.Symbol.Border.Width = 3
            Wheat.Style.Symbol.Size = New Size(8, 8)
            Wheat.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            Wheat.Style.ImageIndex = 0
            Wheat.Style.Symbol.Shape = ChartSymbolShape.Image
            Wheat.Style.Symbol.ImageIndex = 1

            Dim Corn As ChartSeries = New ChartSeries("Corn", ChartSeriesType.Line)
            Corn.Points.Add(1997, 170)
            Corn.Points.Add(1998, 190)
            Corn.Points.Add(1999, 200)
            Corn.Points.Add(2000, 260)
            Corn.Points.Add(2001, 300)
            Corn.Points.Add(2002, 370)
            Corn.Points.Add(2003, 400)
            Corn.Points.Add(2004, 434)
            Corn.Points.Add(2005, 566)
            Corn.Points.Add(2006, 587)
            Corn.Points.Add(2007, 690)
            Me.chartControl1.Series.Add(Corn)
            Corn.Style.Border.Width = 3
            Corn.Style.Symbol.Shape = ChartSymbolShape.Square
            Corn.Style.Symbol.Color = Color.White
            Corn.Style.Symbol.Border.Color = Color.FromArgb(200, 188, 200, 6)
            Corn.Style.Symbol.Border.Width = 2
            Corn.Style.Symbol.Size = New Size(8, 8)

            Dim Rice As ChartSeries = New ChartSeries("Rice", ChartSeriesType.Line)
            Rice.Points.Add(1997, 120)
            Rice.Points.Add(1998, 180)
            Rice.Points.Add(1999, 160)
            Rice.Points.Add(2000, 210)
            Rice.Points.Add(2001, 200)
            Rice.Points.Add(2002, 280)
            Rice.Points.Add(2003, 300)
            Rice.Points.Add(2004, 335)
            Rice.Points.Add(2005, 367)
            Rice.Points.Add(2006, 380)
            Rice.Points.Add(2007, 400)
            Me.chartControl1.Series.Add(Rice)
            Rice.Style.Border.Width = 3
            Rice.Style.Symbol.Shape = ChartSymbolShape.Diamond
            Rice.Style.Symbol.Color = Color.White
            Rice.Style.Symbol.Border.Color = Color.MediumVioletRed
            Rice.Style.Symbol.Border.Width = 2
            Rice.Style.Symbol.Size = New Size(10, 10)
        End Sub
#End Region

#Region "InitializeControlSettings"
        Protected Sub InitializeControlSettings()
            For Each symbol As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartSymbolShape))
                Me.cmbSymbolStyle.Items.Add(symbol)
            Next symbol

            Me.cmbSymbolStyle.SelectedIndex = 3
        End Sub
#End Region

#Region "Events"
        Private Sub cmbSymbolStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSymbolStyle.SelectedIndexChanged
            SetSymbol()
        End Sub

        Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles colorPickerButton1.ColorSelected
            SetSymbol()
        End Sub

        Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDown1.ValueChanged
            SetSymbol()
        End Sub

#Region "Set Symbols "

        Protected Sub SetSymbol()
            'Symbol to points
            If radioButton1.Checked Then
                AddHandler chartControl1.Series(0).PrepareStyle, AddressOf ChartControlSeries_PrepareStyle
            Else
                RemoveHandler chartControl1.Series(0).PrepareStyle, AddressOf ChartControlSeries_PrepareStyle

            End If
            'Symbol to series
            If Me.radioButton2.Checked Then
                Me.chartControl1.Series(0).Style.Symbol.Color = colorPickerButton1.SelectedColor
                Me.textBox1.BackColor = colorPickerButton1.SelectedColor

                Me.chartControl1.Series(0).Style.Symbol.Size = New Size(CInt(Fix(Me.numericUpDown1.Value)), CInt(Fix(Me.numericUpDown1.Value)))
                Me.chartControl1.Series(0).Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.cmbSymbolStyle.SelectedItem.ToString(), True), ChartSymbolShape)
                If Me.chartControl1.Series(0).Style.Symbol.Shape = ChartSymbolShape.Image Then
                    Me.chartControl1.Series(0).Text = "Series - " & Me.chartControl1.Series(0).Style.Symbol.Shape.ToString()
                    Me.chartControl1.Series(0).Style.Symbol.Size = New Size(25, 25)
                    Me.numericUpDown1.Value = 25
                End If
            End If
            Me.chartControl1.Legend.Items(0).TextColor = Color.White
            Me.chartControl1.Refresh()
        End Sub
#End Region

#Region "Symbols to Points"
        Protected Sub ChartControlSeries_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            Dim rand As Random = New Random()

            If args.Index = 4 Then
                args.Style.Symbol.Shape = CType(System.Enum.Parse(GetType(ChartSymbolShape), Me.cmbSymbolStyle.SelectedItem.ToString(), True), ChartSymbolShape)
                args.Style.Symbol.Size = New Size(CInt(Fix(Me.numericUpDown1.Value)), CInt(Fix(Me.numericUpDown1.Value)))
                args.Style.Symbol.Color = colorPickerButton1.SelectedColor
            End If
        End Sub
#End Region
#End Region
    End Class
End Namespace