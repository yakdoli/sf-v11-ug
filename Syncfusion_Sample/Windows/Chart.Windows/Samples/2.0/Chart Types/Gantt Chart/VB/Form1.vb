Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart

Namespace OtherCharts
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"

		Private panel1 As System.Windows.Forms.Panel

		Private line As ChartStripLine = New ChartStripLine()

		Private secaxis As ChartAxis = New ChartAxis()
		Private isDragging As Boolean = False
		Private currentRegion As ChartRegion = Nothing
		Private chartAreaPoint As Point

		Private checkBox_Drag As System.Windows.Forms.CheckBox
		Private WithEvents chartControl1 As ChartControl

		Private toolTip1 As ToolTip
		Private WithEvents checkBox1 As CheckBox
		Private components As IContainer

		#End Region

		#Region "Constructor, Main And Dispose"
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.checkBox_Drag = New System.Windows.Forms.CheckBox()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' checkBox_Drag
			' 
			Me.checkBox_Drag.Dock = System.Windows.Forms.DockStyle.Right
			Me.checkBox_Drag.Location = New System.Drawing.Point(578, 0)
			Me.checkBox_Drag.Name = "checkBox_Drag"
			Me.checkBox_Drag.Size = New System.Drawing.Size(112, 27)
			Me.checkBox_Drag.TabIndex = 3
			Me.checkBox_Drag.Text = "Drag And Drop"
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(250))))), (CInt(Fix((CByte(250))))), (CInt(Fix((CByte(250))))))
			Me.panel1.Controls.Add(Me.checkBox1)
			Me.panel1.Controls.Add(Me.checkBox_Drag)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panel1.Location = New System.Drawing.Point(0, 362)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(690, 27)
			Me.panel1.TabIndex = 2
			' 
			' checkBox1
			' 
			Me.checkBox1.Dock = System.Windows.Forms.DockStyle.Right
			Me.checkBox1.Location = New System.Drawing.Point(497, 0)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(81, 27)
			Me.checkBox1.TabIndex = 4
			Me.checkBox1.Text = "Enable 3D"
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' chartControl1
			' 
			Me.chartControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(250))))), (CInt(Fix((CByte(250))))), (CInt(Fix((CByte(250)))))), System.Drawing.Color.White)
			Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(211))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(241)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(211))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(241)))))))
			Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
			Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
			Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 5, 2)
			Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb((CInt(Fix((CByte(250))))), (CInt(Fix((CByte(250))))), (CInt(Fix((CByte(250)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(250))))), (CInt(Fix((CByte(250))))), (CInt(Fix((CByte(250)))))))
			Me.chartControl1.ColumnFixedWidth = 35
			Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			' 
			' 
			' 
			Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
			Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
			Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent
			Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
			Me.chartControl1.Legend.Location = New System.Drawing.Point(283, 45)
			Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
			Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
			Me.chartControl1.Legend.Spacing = 3
			Me.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside
			Me.chartControl1.Location = New System.Drawing.Point(24, 24)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent
			Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
			Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
			Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent
			Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
			Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
			Me.chartControl1.Size = New System.Drawing.Size(638, 322)
			Me.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
			Me.chartControl1.TabIndex = 3
			Me.chartControl1.Text = "Essential Chart"
			' 
			' 
			' 
			Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl1.Title.Name = "Def_title"
			Me.chartControl1.Title.Text = "Essential Chart"
			Me.chartControl1.Titles.Add(Me.chartControl1.Title)
			Me.chartControl1.ZoomOutIncrement = 1.5
'			Me.chartControl1.ChartRegionMouseMove += New Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(Me.chartControl1_ChartRegionMouseMove);
'			Me.chartControl1.ChartFormatAxisLabel += New Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(Me.chartControl1_ChartFormatAxisLabel);
'			Me.chartControl1.ChartRegionMouseUp += New Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(Me.chartControl1_ChartRegionMouseUp);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(690, 389)
			Me.Controls.Add(Me.chartControl1)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Gantt Chart"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.panel1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.chartControl1.Series.Clear()

			InitializeChartData()
			Me.chartControl1.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
			Me.chartControl1.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate
			Me.chartControl1.LegendPosition = ChartDock.Top
			Me.chartControl1.Legend.ColumnsCount = 2
			ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub

		#End Region

		#Region "Helper Methods"
		#Region "InitializeChartData"
		Protected Sub InitializeChartData()
			Dim Completion As ChartSeries = New ChartSeries("Completion", ChartSeriesType.Gantt)

			Dim dt As DateTime = New DateTime(2009, 1, 1)
			Completion.Points.Add(0, dt, dt.AddDays(2))
			Completion.Points.Add(1, dt.AddDays(1), dt.AddDays(2))
			Completion.Points.Add(2, dt.AddDays(3), dt.AddDays(5))
			Completion.Points.Add(3, dt.AddDays(6), dt.AddDays(9))
			Completion.Points.Add(4, dt.AddDays(10), dt.AddDays(13))
			Completion.Points.Add(5, dt.AddDays(15), dt.AddDays(18))

			Completion.Style.PointWidth = 0.5f

			Me.chartControl1.Series.Add(Completion)
			Completion.PointsToolTipFormat = "{1}{2}"

			Dim Task As ChartSeries = New ChartSeries("Task", ChartSeriesType.Gantt)

			Task.Points.Add(0, dt, dt.AddDays(2))
			Task.Points.Add(1, dt.AddDays(1), dt.AddDays(3))
			Task.Points.Add(2, dt.AddDays(3), dt.AddDays(6))
			Task.Points.Add(3, dt.AddDays(6), dt.AddDays(10))
			Task.Points.Add(4, dt.AddDays(10), dt.AddDays(15))
			Task.Points.Add(5, dt.AddDays(15), dt.AddDays(20))

			' Make a note of the last day:
			Dim lastDay As DateTime = DateTime.FromOADate(Task.Points(Task.Points.Count - 1).YValues(1))

			Task.Style.PointWidth = 0.75f
			Me.chartControl1.Series.Add(Task)
			Task.PointsToolTipFormat = "{1}{2}"

			Me.chartControl1.ShowToolTips = True
			Me.chartControl1.CalcRegions = True


			Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(dt, lastDay.AddDays(2), 1, ChartDateTimeIntervalType.Days)

			' Displays custom into on Points
			For i As Integer = 0 To Me.chartControl1.Series(0).Points.Count - 1
				If Me.chartControl1.Series(1).Points(i).YValues(0) <> Me.chartControl1.Series(1).Points(i).YValues(1) Then
					Dim ccp As ChartCustomPoint = New ChartCustomPoint()

					Dim pt As ChartPoint = Me.chartControl1.Series(1).Points(i)
					ccp.XValue = pt.X
					ccp.YValue = pt.YValues(0) + 1
					ccp.CustomType = ChartCustomPointType.ChartCoordinates
					ccp.Text = String.Format("{0} days", pt.YValues(1) - pt.YValues(0))
					ccp.Color = Color.White
					ccp.Font.Facename = "Tahoma"
					Me.chartControl1.CustomPoints.Add(ccp)
				End If
			Next i

			' To indicate weekends
			Dim stripLineColor As Color() = New Color() { Color.LightBlue, Color.Azure, Color.SkyBlue }

			'Chart Strip Lines
			Dim stripLine1 As ChartStripLine = New ChartStripLine()
			stripLine1.Enabled = True
			stripLine1.Vertical = False
			stripLine1.StartDate = dt.AddDays(2) '// We know that Jan 3rd is a Saturday.
			stripLine1.EndDate = lastDay
			stripLine1.Width = 2

			' Repetition frequency: every 7 days
			stripLine1.PeriodDate = New TimeSpan(7, 0, 0, 0)
			stripLine1.Text = String.Empty
			stripLine1.Interior = New BrushInfo(GradientStyle.Horizontal, stripLineColor)
			Me.chartControl1.PrimaryXAxis.StripLines.Add(stripLine1)

			AddHandler chartControl1.Series(0).PrepareStyle, AddressOf Form1_PrepareStyle
            AddHandler chartControl1.Series(1).PrepareStyle, AddressOf Form1_PrepareStyle

		End Sub

		Private Sub Form1_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
			Dim series As ChartSeries = TryCast(sender, ChartSeries)
			If series Is Nothing Then
				Return
			End If

			Dim taskPoint As ChartPoint = Me.chartControl1.Series(1).Points(args.Index)
			Dim completionPoint As ChartPoint = Me.chartControl1.Series(0).Points(args.Index)

			Dim completionStartDate As DateTime = DateTime.FromOADate(completionPoint.YValues(0))
			Dim completionEndDate As DateTime = DateTime.FromOADate(completionPoint.YValues(1))

			Dim taskStartDate As DateTime = DateTime.FromOADate(taskPoint.YValues(0))
			Dim taskEndDate As DateTime = DateTime.FromOADate(taskPoint.YValues(1))
			Dim percentCompleted As Double = (CDbl(completionEndDate.Day - completionStartDate.Day) / CDbl(taskEndDate.Day - taskStartDate.Day)) * 100
			Dim percentRemaining As Double = 100 - percentCompleted
			args.Style.ToolTip = "Start date:" & taskStartDate.ToShortDateString() + Constants.vbLf & "End date:" & taskEndDate.ToShortDateString() + Constants.vbLf & "Percent Completed:" & Math.Round(percentCompleted, 2) & "%" & Constants.vbLf & "Percent Remaining: " & Math.Round(percentRemaining, 2) & "%"

			args.Handled = True
		End Sub

		#End Region

		#Region "ConvertScreenPointToChartAreaPoint"
		Private Function ConvertScreenPointToChartAreaPoint(ByVal screenPoint As Point) As Point
			' We cant directly convert a Screen Point to Chart Area Coordinates
			' This converts the point in screen coordinates to chartcontrol coordinates
			Dim ccp As Point = Me.chartControl1.PointToClient(screenPoint)

			Return ccp
		End Function

		#End Region

		Private Sub NewXValue(ByVal newX As Double)
			Me.chartControl1.Series(0).Points(Me.currentRegion.PointIndex).X=(newX)
		End Sub

		Private Sub NewYValue(ByVal newY As Double)
			Me.chartControl1.Series(0).Points(Me.currentRegion.PointIndex).YValues(0) =newY
		End Sub

		#End Region

		#Region "Events"

		#Region "ChartRegionMouseMove"
		Private Sub chartControl1_ChartRegionMouseMove(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseMove
			If Me.checkBox_Drag.Checked Then
				If e.Region.IsChartPoint Then
					Cursor = Cursors.SizeAll
					Me.isDragging = True
					Me.currentRegion = e.Region
				Else
					Cursor = Cursors.Default
				End If
			End If
		End Sub

		#End Region

		#Region "ChartRegionMouseUp"
		Private Sub chartControl1_ChartRegionMouseUp(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseUp
			If Me.checkBox_Drag.Checked Then
				If Me.isDragging Then
					chartAreaPoint = ConvertScreenPointToChartAreaPoint(Control.MousePosition)

					Dim newY As Double = Math.Floor(Me.chartControl1.ChartArea.GetValueByPoint(chartAreaPoint).YValues(0))
					Dim newX As Double = Math.Floor(Me.chartControl1.ChartArea.GetValueByPoint(chartAreaPoint).X)

					If newY < 0 OrElse newY >= 39835 OrElse newX < 0 OrElse newX > 7 Then
						MessageBox.Show("Cannot drag outside chart bounds")
					Else
						Me.NewYValue(newY)
					End If
					Me.isDragging = False
					Me.currentRegion = Nothing
				End If
				Me.isDragging = False
				Me.currentRegion = Nothing
				Me.chartControl1.Redraw(True)
			End If
		End Sub

		#End Region

		Private Sub numericUpDown_CriticalValue_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
			Me.chartControl1.Redraw(True)
		End Sub

		#Region "ChartFormatAxisLabel"

		Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs) Handles chartControl1.ChartFormatAxisLabel
			If e.AxisOrientation = ChartOrientation.Vertical Then
				' To make the label text as "Activity N"
				If e.Value >= 0 AndAlso e.Value < Me.chartControl1.Series(0).Points.Count Then
					e.Label = String.Format("Activity {0}", e.Value + 1)
				Else
					e.Label = String.Empty
				End If
			Else
				e.Label = e.ValueAsDate.ToString("MM/dd/yy")
			End If

			e.Handled = True


		End Sub
		#End Region

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			Me.chartControl1.Series3D = checkBox1.Checked
		End Sub

		#End Region
	End Class
End Namespace