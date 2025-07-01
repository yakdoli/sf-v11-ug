#Region "Copyright Syncfusion Inc. 2001 - 2011"
'
'  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
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
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Threading

Namespace Syncfusion.Windows.Forms.Chart.Samples
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private prodDs1 As DataSet
		Private components As System.ComponentModel.IContainer
		Private model As ChartDataBindModel = Nothing
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents btnStop As Button
		Private WithEvents btnStart As Button
		Private label6 As Label
		Private label40 As Label

		Private lastTime As DateTime = DateTime.Now
		#End Region

		#Region "Form Constructor, Main And Dispose"
		Public Sub New()

			InitializeComponent()

		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
			Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label40 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.btnStop = New System.Windows.Forms.Button()
			Me.btnStart = New System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' chartControl1
			' 
			Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.Teal
			Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Open
			Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
			Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
			Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
			Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent)
			Me.chartControl1.Depth = 1F
			Me.chartControl1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.IsWindowLess = False
			' 
			' 
			' 
			Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.chartControl1.Legend.ForeColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.Legend.Location = New System.Drawing.Point(85, 419)
			Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
			Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
			Me.chartControl1.Legend.Visible = False
			Me.chartControl1.Location = New System.Drawing.Point(11, 11)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PrimaryXAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Gray
			Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.PrimaryXAxis.Margin = True
			Me.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.PrimaryYAxis.Crossing = Double.NaN
			Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.PrimaryYAxis.LineType.BackColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.PrimaryYAxis.Margin = True
			Me.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.Rotation = 0.1F
			Me.chartControl1.Size = New System.Drawing.Size(514, 332)
			Me.chartControl1.TabIndex = 0
			Me.chartControl1.Text = "Syncfusion Essential Chart"
			Me.chartControl1.Tilt = 0.1F
			' 
			' 
			' 
			Me.chartControl1.Title.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue
			Me.chartControl1.Title.Name = "Def_title"
			Me.chartControl1.Title.Text = "Syncfusion Essential Chart"
			Me.chartControl1.Titles.Add(Me.chartControl1.Title)
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.White
			Me.panel1.Controls.Add(Me.label40)
			Me.panel1.Controls.Add(Me.label6)
			Me.panel1.Controls.Add(Me.btnStop)
			Me.panel1.Controls.Add(Me.btnStart)
			Me.panel1.Location = New System.Drawing.Point(0, 349)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(553, 127)
			Me.panel1.TabIndex = 1
			' 
			' label40
			' 
			Me.label40.BackColor = System.Drawing.Color.Transparent
			Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label40.Location = New System.Drawing.Point(3, 82)
			Me.label40.Name = "label40"
			Me.label40.Size = New System.Drawing.Size(534, 42)
			Me.label40.TabIndex = 7
			Me.label40.Text = "Points are added by thread for each one second. The last 20 seconds points are on" & "ly visible in chart, other invisible points are removed from chart series to imp" & "rove performance of chart." & Constants.vbCrLf
			' 
			' label6
			' 
			Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label6.Image = (CType(resources.GetObject("label6.Image"), System.Drawing.Image))
			Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label6.Location = New System.Drawing.Point(-3, 37)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(688, 45)
			Me.label6.TabIndex = 6
			Me.label6.Text = "               Sample Description"
			Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' btnStop
			' 
			Me.btnStop.Location = New System.Drawing.Point(284, 11)
			Me.btnStop.Name = "btnStop"
			Me.btnStop.Size = New System.Drawing.Size(75, 23)
			Me.btnStop.TabIndex = 1
			Me.btnStop.Text = "Stop"
			Me.btnStop.UseVisualStyleBackColor = True
'			Me.btnStop.Click += New System.EventHandler(Me.btnStop_Click);
			' 
			' btnStart
			' 
			Me.btnStart.Location = New System.Drawing.Point(187, 11)
			Me.btnStart.Name = "btnStart"
			Me.btnStart.Size = New System.Drawing.Size(75, 23)
			Me.btnStart.TabIndex = 0
			Me.btnStart.Text = "Start"
			Me.btnStart.UseVisualStyleBackColor = True
'			Me.btnStart.Click += New System.EventHandler(Me.btnStart_Click);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(537, 477)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Chart Real Time"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		Private addRealData As Thread
		Public Delegate Sub AddDataDelegate()
		Public Event addDataDel As AddDataDelegate
		Private rand As Random = New Random()
		Private minValue, maxValue As DateTime
		Private Start As ThreadStart
		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'Create a new single thread to add points to chart series
			Start = New ThreadStart(AddressOf DataThreadLoop)
			addRealData = New Thread(Start)
			AddHandler addDataDel, AddressOf AddChartData
			InitializeChart()
			ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub
		#End Region
		#Region "Helper Method"
		Private Sub InitializeChart()
			minValue = DateTime.Now
			maxValue = minValue.AddSeconds(30)
			chartControl1.Series.Clear()
			chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
			chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(minValue, maxValue, 10, ChartDateTimeIntervalType.Seconds)
			chartControl1.PrimaryXAxis.DateTimeFormat = "HH:mm:ss"
			Me.chartControl1.ShowLegend = False
			Dim series As ChartSeries = New ChartSeries("Spline")
			series.Type = ChartSeriesType.Spline
			For i As Integer = 0 To 121
				series.Points.Add(minValue.AddMilliseconds(i * 160), rand.Next(2, 17))
			Next i

			series.Style.Border.Width = 2
			'series.Style.Symbol.Shape = ChartSymbolShape.Circle;
			chartControl1.Series.Add(series)

		   Me.btnStart_Click(Nothing, EventArgs.Empty)
		End Sub

	   Private Sub DataThreadLoop()
			Try
				Do
					' Invoke method used to interact with the chart control on the form
					 chartControl1.Invoke(addDataDelEvent)

					' Thread is inactive for 200ms
					Thread.Sleep(200)
				Loop
			Catch
				' Thread is aborted
			End Try
	   End Sub
		''' <summary>
		''' AddChartData Method invoked from the thread to add series points
		''' </summary>
		Public Sub AddChartData()

			Dim timeStamp As DateTime = DateTime.Now
			timeStamp = timeStamp.AddSeconds(20)
			For Each Series As ChartSeries In Me.chartControl1.Series
				AddNewPoint(timeStamp, Series)
			Next Series
		End Sub
		Public Sub AddNewPoint(ByVal timeStamp As DateTime, ByVal Series As ChartSeries)
			' Add new data point to series.
			Series.Points.Add(timeStamp, rand.Next(3, 17))

			'// remove all points from the source series older than 20 seconds.
			Dim removePointVal As Double = timeStamp.AddSeconds(CDbl(20) * (-1)).ToOADate()


			Do While Series.Points(0).DateX.ToOADate() < removePointVal
				Series.Points.RemoveAt(0)
			Loop
			chartControl1.PrimaryXAxis.Range.Min = Series.Points(0).DateX.ToOADate()
			chartControl1.PrimaryXAxis.Range.Max = Series.Points(0).DateX.AddSeconds(30).ToOADate()
		End Sub

		Private Sub btnStart_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStart.Click
			' Disable the Stop button on the form
			btnStart.Enabled = False
			' Enable the Stop button on the form
			btnStop.Enabled = True

			' start worker threads.
			If addRealData.IsAlive = True Then
				addRealData.Resume()
			Else
				addRealData.Start()
			End If

		End Sub

		Private Sub btnStop_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStop.Click

			' Suspend thread
			If addRealData.IsAlive = True Then
				addRealData.Suspend()
			End If

			' Enable start button on the form
			btnStart.Enabled = True

			' Disable the Stop button
			btnStop.Enabled = False

		End Sub
		#End Region

	End Class
End Namespace