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

Namespace ChartSmartLabel_2005


    Partial Public Class Form1
        Inherits Office2007Form
        Public Sub New()
            InitializeComponent()
        End Sub
#Region "PrivateMember"
        Private _Id As Integer = 1
#End Region

#Region "FormLoad"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Method"
        Protected Sub InitializeChartData()
            Dim series1 As ChartSeries = New ChartSeries("Compound AA", ChartSeriesType.Scatter)
            series1.Style.Symbol.Color = System.Drawing.Color.DarkOrchid
            series1.Style.Symbol.Shape = ChartSymbolShape.Square
            series1.Style.TextOffset = 15
            series1.SmartLabelsBorderColor = System.Drawing.Color.DarkOrchid
            series1.SmartLabelsBorderWidth = 1
            AddHandler series1.PrepareStyle, AddressOf series_PrepareStyle

            Dim series4 As ChartSeries = New ChartSeries("Compound CC", ChartSeriesType.Scatter)
            series4.Style.Symbol.Color = System.Drawing.Color.Red
            series4.Style.TextOffset = -30
            series4.Style.Symbol.Shape = ChartSymbolShape.Star
            AddHandler series4.PrepareStyle, AddressOf series_PrepareStyle

            series4.SmartLabelsBorderColor = System.Drawing.Color.Red
            series4.SmartLabelsBorderWidth = 1

            Dim series5 As ChartSeries = New ChartSeries("Compound DD", ChartSeriesType.Scatter)
            series5.Style.Symbol.Color = System.Drawing.Color.Magenta
            series5.Style.Symbol.Shape = ChartSymbolShape.Triangle
            series5.Style.TextOffset = 15
            AddHandler series5.PrepareStyle, AddressOf series_PrepareStyle
            series5.SmartLabelsBorderColor = System.Drawing.Color.Magenta
            series5.SmartLabelsBorderWidth = 1

            Dim series6 As ChartSeries = New ChartSeries("Compound EE", ChartSeriesType.Scatter)
            series6.Style.Symbol.Color = System.Drawing.Color.Yellow
            series6.Style.Symbol.Shape = ChartSymbolShape.Hexagon
            AddHandler series6.PrepareStyle, AddressOf series_PrepareStyle
            series6.SmartLabelsBorderColor = System.Drawing.Color.Transparent
            series6.SmartLabelsBorderWidth = 1

            series1.Points.Add(34.5745413, 20.3282866)
            series1.Points.Add(31.1144818, 14.2510141)
            series1.Points.Add(36.7960707, 20.6485916)
            series1.Points.Add(39.3946526, 29.6503113)
            series1.Points.Add(36.9149847, 12.036468)

            series4.Points.Add(33.6240289, 10.4293169)
            series4.Points.Add(25.959018, 15.0305531)
            series4.Points.Add(26.1158617, 22.2780683)
            series4.Points.Add(24.5590223, 11.1255066)
            series4.Points.Add(39.9605541, 17.2306935)
            series4.Points.Add(38.220167000000004, 10.7499491)

            series5.Points.Add(49.9140424, 12.8742868)
            series5.Points.Add(53.8453009, 18.630743)
            series5.Points.Add(53.2494757, 4.3310421)
            series5.Points.Add(50.8416839, 1.9014331)

            series6.Points.Add(58.1815097, 18.1211902)
            series6.Points.Add(47.6000954, 20.3468524)
            series6.Points.Add(50.8396695, 16.8712833)
            series6.Points.Add(47.3161036, 0.6289029)
            series6.Points.Add(41.3283884, 10.5059598)

            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series4)
            Me.chartControl1.Series.Add(series5)
            Me.chartControl1.Series.Add(series6)

            For i As Integer = 0 To Me.chartControl1.Series.Count - 1
                Me.chartControl1.Series(i).SmartLabels = True
                Me.chartControl1.Legend.ShowSymbol = True
            Next i
        End Sub

        Private Sub series_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            args.Style.DisplayText = True
            args.Style.TextOrientation = ChartTextOrientation.Smart
            args.Style.Text = "T" & Me._Id.ToString()
            Me._Id += 1
            series.Style.Font.Facename = "Arial"
            series.Style.Font.Size = 7
        End Sub
#End Region
    End Class
End Namespace