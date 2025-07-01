#Region "Copyright Syncfusion Inc. 2001 - 2009"
'
'  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart

Namespace StockAndVolumeChart
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"

		Private secaxis As ChartAxis = New ChartAxis()
		Private yaxis As ChartAxis = New ChartAxis()
		Private d As DateTime
		Private rand As Random = New Random()
		Private label1 As Label
        Private components As IContainer
        Private chartControl1 As ChartControl
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox

#End Region

#Region "Constructor, Main And Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.label1 = New System.Windows.Forms.Label
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Black
            Me.label1.Image = Global.My.Resources.Resources.Label
            Me.label1.Location = New System.Drawing.Point(127, 51)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(527, 20)
            Me.label1.TabIndex = 1
            Me.label1.Text = "  "
            '
            'chartControl1
            '
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(539, 75)
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(12, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.Size = New System.Drawing.Size(675, 462)
            Me.chartControl1.TabIndex = 2
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(588, 482)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(76, 17)
            Me.checkBox1.TabIndex = 4
            Me.checkBox1.Text = "Enable 3D"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(705, 504)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Stock-and-Volume Chart"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

#Region "Form Load"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            CalculateVolume()
            SetAxesRanges()
            CreateStripLine()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            Me.label1.BringToFront()
            AddHandler chartControl1.ChartRegionMouseHover, AddressOf chartControl1_ChartRegionMouseHover
        End Sub

#End Region

#Region "Helper Methods"
#Region "GetPointIndex"
        'Binary Search to get the corresponding point index.
        Private Function GetPointIndex(ByVal x As DateTime, ByVal seriesIndex As Integer) As Integer
            Dim low As Integer = 0, high As Integer = chartControl1.Series(seriesIndex).Points.Count
            Dim mid As Integer = 0
            Try
                Do While low <= high
                    mid = Convert.ToInt32((low + high) / 2)
                    If chartControl1.Series(seriesIndex).Points(mid).DateX.Date > x.Date Then
                        high = mid - 1
                    ElseIf chartControl1.Series(seriesIndex).Points(mid).DateX.Date < x.Date Then
                        low = mid + 1
                    Else
                        Return mid 'found
                    End If
                Loop
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
            Return -1 'not found
        End Function
#End Region

#Region "CreateStripLine"
        ''' <summary>
        ''' Draws a strip line that acts as a separator between two chart areas.
        ''' </summary>
        Private Sub CreateStripLine()
            Dim sLine As ChartStripLine = New ChartStripLine()
            sLine.Enabled = True
            sLine.StartAtAxisPosition = False
            sLine.Vertical = False
            sLine.Start = 112
            sLine.Width = 4
            sLine.End = sLine.Start + sLine.Width + 1
            sLine.Font = New Font("Tahoma", 8.0F)
            sLine.Text = " "
            sLine.TextAlignment = ContentAlignment.MiddleCenter
            sLine.TextColor = Color.Maroon
            sLine.Interior = New BrushInfo(GradientStyle.Horizontal, Color.Olive, Color.Olive)
            chartControl1.PrimaryYAxis.StripLines.Add(sLine)
        End Sub

#End Region

#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the chart data for Stock Series
        ''' </summary>
        Private series1 As ChartSeries
        Private Sub InitializeChartData()
            d = DateTime.Now

            series1 = New ChartSeries()
            series1.Name = "Stock1"
            series1.Type = ChartSeriesType.Candle

            series1.Text = series1.Name

            Me.chartControl1.Series.Add(series1)
            'Date, High, Low, Close, Open values.
            For i As Integer = 0 To 59
                If i <= 10 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(32, 38), rand.Next(20, 24), rand.Next(28, 32), rand.Next(24, 32))

                    ' small one
                ElseIf i > 10 AndAlso i <= 12 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(42, 45), rand.Next(30, 34), rand.Next(36, 42), rand.Next(38, 42))

                ElseIf i > 12 AndAlso i <= 19 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(48, 50), rand.Next(40, 42), rand.Next(42, 48), rand.Next(44, 48))

                    ' small
                ElseIf i > 19 AndAlso i <= 23 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(54, 60), rand.Next(45, 49), rand.Next(49, 54), rand.Next(50, 52))

                ElseIf i > 23 AndAlso i <= 29 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(54, 60), rand.Next(45, 49), rand.Next(49, 54), rand.Next(50, 54))

                    'small
                ElseIf i > 29 AndAlso i <= 32 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(62, 65), rand.Next(55, 57), rand.Next(57, 62), rand.Next(60, 62))

                ElseIf i > 32 AndAlso i <= 49 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(68, 72), rand.Next(60, 64), rand.Next(62, 68), rand.Next(64, 68))

                ElseIf i > 49 AndAlso i <= 51 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(58, 60), rand.Next(55, 58), rand.Next(58, 64), rand.Next(63, 64))

                ElseIf i > 51 Then
                    series1.Points.Add(d.AddDays(i), rand.Next(60, 65), rand.Next(52, 54), rand.Next(54, 58), rand.Next(56, 58))
                End If

            Next i

            Me.chartControl1.Series(0).YAxis = Me.yaxis
            AddHandler series1.PrepareStyle, AddressOf series_PrepareStyle
            Me.chartControl1.PrimaryYAxis.Title = "Trade volume (M)"
            Me.chartControl1.Text = "Price History"
        End Sub

#End Region

#Region "CalculateVolume"

        ''' <summary>
        ''' Initializes the chart data for Volume series.
        ''' </summary>
        Protected Sub CalculateVolume()
            d = DateTime.Now

            Dim series As ChartSeries = New ChartSeries()
            series.Name = "Volume"
            series.Type = ChartSeriesType.Column
            series.Text = series.Name

            For i As Integer = 0 To 59
                series.Points.Add(d.AddDays(i), (rand.Next(10, 100)))
            Next i

            Me.chartControl1.Series.Add(series)
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate
        End Sub

#End Region

#Region "SetAxesRanges"
        Protected Sub SetAxesRanges()
            d = DateTime.Now

            yaxis.LineType.ForeColor = Color.Olive
            yaxis.GridLineType.ForeColor = Color.Olive
            yaxis.Font = New Font("Verdana", 8.0F)

            Me.yaxis.Orientation = ChartOrientation.Vertical
            Me.yaxis.RangeType = ChartAxisRangeType.Set
            Me.yaxis.Range = New MinMaxInfo(20, 80, 10)
            Me.yaxis.Title = "Stock Price ($)"
            Me.yaxis.Format = "   0"
            Me.yaxis.TickColor = Color.Transparent
            Me.yaxis.Font = New Font("Verdana", 8.25F, FontStyle.Bold)
            Me.yaxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl1.Axes.Add(yaxis)

            Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 120, 20)
            Me.chartControl1.PrimaryYAxis.Format = " 0"
            Me.chartControl1.PrimaryYAxis.HidePartialLabels = True
            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM-dd-yy"
            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(d.AddDays(-1), d.AddDays(Me.chartControl1.Series(1).Points.Count), 10, ChartDateTimeIntervalType.Days)
            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate
            Me.chartControl1.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.SideBySide
            Me.chartControl1.Redraw(True)
        End Sub

#End Region

#End Region

#Region "Events"
        ''' <summary>
        ''' Paints the stock series with up and down colors.
        ''' </summary>
        Private Sub series_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
            Dim series As ChartSeries = TryCast(sender, ChartSeries)
            If Not series Is Nothing Then
                'Up Series - Open value < Close value - Painted with Green.
                'Down Series - Open value > Close value - Painted with Red.
                If args.Index >= 0 Then
                    If series.Points(args.Index).YValues(3) > series.Points(args.Index).YValues(2) Then

                        args.Style.Interior = New BrushInfo(GradientStyle.Horizontal, Color.Red, Color.Red)
                        args.Style.Border.Color = Color.Red
                    Else
                        args.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, Color.Green, Color.Green)
                        args.Style.Border.Color = Color.Green
                    End If
                End If
            End If
        End Sub
        Private stockPointIndex As Integer
        Private Sub chartControl1_ChartRegionMouseHover(ByVal sender As Object, ByVal e As ChartRegionMouseEventArgs)
            Dim cpt As ChartPoint = chartControl1.ChartArea.GetValueByPoint(e.Point)

            For i As Integer = 0 To chartControl1.Series(0).Points.Count - 1
                chartControl1.Series(0).Styles(i).ResetSymbol()
            Next i
            If Not cpt Is Nothing AndAlso chartControl1.ChartArea.RenderBounds.Contains(e.Point) Then
                chartControl1.CustomPoints.Clear()
                Dim cpStock As ChartPoint = Nothing, cpVolume As ChartPoint = Nothing
                Dim clientPoint As Point = Point.Empty

                'Chart points for stock and volume series.
                stockPointIndex = GetPointIndex(cpt.DateX, 0)
                If stockPointIndex <> -1 Then
                    cpStock = Me.chartControl1.Series(0).Points(stockPointIndex)
                End If
                Dim volumePointIndex As Integer = GetPointIndex(cpt.DateX, 1)
                If volumePointIndex <> -1 Then
                    cpVolume = Me.chartControl1.Series(1).Points(volumePointIndex)
                End If

                If Not cpStock Is Nothing AndAlso Not cpVolume Is Nothing Then
                    'Display Date, High, Low, Open, Close and Volume values.
                    Me.label1.Text = "Date = " & cpt.DateX.ToShortDateString() & " Open = " & cpStock.YValues(3) & ", High = " & cpStock.YValues(0) & ", Low = " & cpStock.YValues(1) & ", Close = " & cpStock.YValues(2) & ", Volume = " & cpVolume.YValues(0)

                    'Custom Symbol at the active stock series point
                    Me.chartControl1.Series(0).Styles(stockPointIndex).Symbol.Shape = ChartSymbolShape.Circle
                    Me.chartControl1.Series(0).Styles(stockPointIndex).Symbol.Color = Color.Blue
                    Me.chartControl1.Series(0).Styles(stockPointIndex).Symbol.Size = New Size(7, 7)

                    'Custom Point at the active volume series point
                    Dim ptVolume As ChartCustomPoint = New ChartCustomPoint()
                    ptVolume.Symbol.Color = Color.Blue
                    ptVolume.Symbol.Shape = ChartSymbolShape.Circle
                    ptVolume.Symbol.Size = New Size(7, 7)
                    ptVolume.SeriesIndex = 1
                    ptVolume.PointIndex = volumePointIndex
                    ptVolume.CustomType = ChartCustomPointType.PointFollow
                    chartControl1.CustomPoints.Add(ptVolume)
                End If
            End If
        End Sub
        Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series3D = checkBox1.Checked
        End Sub
#End Region
    End Class
End Namespace
