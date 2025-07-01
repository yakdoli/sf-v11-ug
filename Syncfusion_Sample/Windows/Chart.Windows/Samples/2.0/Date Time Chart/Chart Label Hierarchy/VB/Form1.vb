#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
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

Namespace ChartLabelHierarchy
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		Private chartControl As Syncfusion.Windows.Forms.Chart.ChartControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Private timer1 As System.Windows.Forms.Timer
		Private label6 As Label
		Private label40 As Label
		Private secYAxis As ChartAxis = New ChartAxis()

		Public Sub New()
			InitializeComponent()
			ChartAppearance.ApplyChartStyles(chartControl)
			Me.BackColor = Color.White
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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.chartControl = New Syncfusion.Windows.Forms.Chart.ChartControl()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.label6 = New System.Windows.Forms.Label()
			Me.label40 = New System.Windows.Forms.Label()
			Me.SuspendLayout()
			' 
			' chartControl
			' 
			Me.chartControl.Dock = System.Windows.Forms.DockStyle.Top
			Me.chartControl.IsWindowLess = False
			' 
			' 
			' 
			Me.chartControl.Legend.Location = New System.Drawing.Point(589, 31)
			Me.chartControl.Location = New System.Drawing.Point(0, 0)
			Me.chartControl.Name = "chartControl"
			Me.chartControl.PrimaryXAxis.Crossing = Double.NaN
			Me.chartControl.PrimaryXAxis.Margin = True
			Me.chartControl.PrimaryYAxis.Crossing = Double.NaN
			Me.chartControl.PrimaryYAxis.Margin = True
			Me.chartControl.Size = New System.Drawing.Size(698, 365)
			Me.chartControl.TabIndex = 0
			' 
			' 
			' 
			Me.chartControl.Title.Font = New System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl.Title.Name = "Def_title"
			Me.chartControl.Title.Text = ""
			Me.chartControl.Titles.Add(Me.chartControl.Title)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			' 
			' label6
			' 
			Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label6.Image = (CType(resources.GetObject("label6.Image"), System.Drawing.Image))
			Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label6.Location = New System.Drawing.Point(-2, 368)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(688, 45)
			Me.label6.TabIndex = 7
			Me.label6.Text = "               Sample Description"
			Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' label40
			' 
			Me.label40.BackColor = System.Drawing.Color.Transparent
			Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label40.Location = New System.Drawing.Point(-2, 413)
			Me.label40.Name = "label40"
			Me.label40.Size = New System.Drawing.Size(654, 66)
			Me.label40.TabIndex = 8
			Me.label40.Text = resources.GetString("label40.Text")
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(698, 488)
			Me.Controls.Add(Me.label40)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.chartControl)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Chart Label Hierarchy"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub
		Private series As ChartSeries
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
		 InitializeChartData()
		End Sub

		#Region "InitializeChartData"
		Private Sub InitializeChartData()
			Me.chartControl.Text = "Yearly view for Stock"
			Me.chartControl.PrimaryXAxis.Title = "Date"
			Me.chartControl.PrimaryYAxis.Title = "Stock"
			Me.chartControl.ShowLegend = False
			AddHandler chartControl.PrimaryXAxis.Zooming, AddressOf PrimaryXAxis_Zooming

			Dim dt As DateTime = New DateTime(1998, 05, 05, 4, 47, 33)
			Me.chartControl.PrimaryXAxis.ValueType = ChartValueType.DateTime
			Me.chartControl.PrimaryXAxis.DateTimeFormat = "yyyy"
			Me.chartControl.PrimaryXAxis.LabelRotate = True
			Me.chartControl.PrimaryXAxis.LabelRotateAngle = 90
			series = New ChartSeries("Market")
			series.Type = ChartSeriesType.Spline
			Dim ran As Random = New Random()
			Me.chartControl.BeginUpdate()
			For i As Integer = 1 To 4379
				series.Points.Add(dt.AddDays(i), i + ran.Next(2, 100))
			Next i
			Me.chartControl.EndUpdate()
			Me.chartControl.Series.Add(series)

			Me.chartControl.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			Me.chartControl.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(series.Points(0).DateX, series.Points(series.Points.Count - 1).DateX, 1, ChartDateTimeIntervalType.Years)
			Me.chartControl.EnableXZooming = True

			series.Style.Interior = New BrushInfo(Color.FromArgb(200, 140, 198, 62))
			Me.chartControl.Zooming.Interior = New Syncfusion.Drawing.BrushInfo(Color.FromArgb(200, 140, 198, 62))
			Me.chartControl.GetHScrollBar(Me.chartControl.PrimaryXAxis).ZoomButton.Size = New Size(0, 0)
		End Sub
		#End Region

		#Region "SetHierarchy Label"
		Private Sub PrimaryXAxis_Zooming(ByVal sender As Object, ByVal args As ChartAxisZoomingArgs)
			If args.ZoomFactor <= 0.5 AndAlso Cursors.Equals(Me.chartControl.Cursor, Cursors.Cross) Then
				Dim type As ChartDateTimeIntervalType = Me.chartControl.PrimaryXAxis.DateTimeRange.DefaultInterval.Type
				Select Case type
					Case ChartDateTimeIntervalType.Years
						Me.chartControl.PrimaryXAxis.DateTimeFormat = "MMM-yy"
						Me.chartControl.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(series.Points(0).DateX, series.Points(series.Points.Count - 1).DateX, 2, ChartDateTimeIntervalType.Months)
						Me.chartControl.Text = "Monthly View for Stock"
					Case ChartDateTimeIntervalType.Months
						Me.chartControl.PrimaryXAxis.DateTimeFormat = "ddd,d,MMM-yy"
						Me.chartControl.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(series.Points(0).DateX, series.Points(series.Points.Count - 1).DateX, 5, ChartDateTimeIntervalType.Weeks)
						Me.chartControl.Text = "Weekly View for Stock"

					Case ChartDateTimeIntervalType.Weeks
						Me.chartControl.PrimaryXAxis.DateTimeFormat = "dd-MM-yy"
						Me.chartControl.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(series.Points(0).DateX, series.Points(series.Points.Count - 1).DateX, 20, ChartDateTimeIntervalType.Days)
						Me.chartControl.Text = "Day View for Stock"

					Case ChartDateTimeIntervalType.Days
						Me.chartControl.PrimaryXAxis.DateTimeFormat = "HH:mm"
						Me.chartControl.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(series.Points(0).DateX, series.Points(series.Points.Count - 1).DateX, 125, ChartDateTimeIntervalType.Hours)
						Me.chartControl.Text = "Hour View for Stock"
				End Select
			Else
				If args.ZoomFactor = 1 Then
					Me.chartControl.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(series.Points(0).DateX, series.Points(series.Points.Count - 1).DateX, 1, ChartDateTimeIntervalType.Years)
					Me.chartControl.PrimaryXAxis.DateTimeFormat = "yyyy"
					Me.chartControl.Text = "Yearly view for Stock"

				End If
			End If
		End Sub
		#End Region

	End Class
End Namespace