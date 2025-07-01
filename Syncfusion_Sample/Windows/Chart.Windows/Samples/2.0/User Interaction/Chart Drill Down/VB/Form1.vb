#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartDrillDown
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.Office2007Form
		#Region "Private Members"

		Private components As IContainer
		Private isDrilledDown As Boolean = False
		Private panel1 As Panel
		Private label1 As Label
		Private WithEvents timer1 As Timer
		Private toolTip1 As ToolTip
		Private color1 As Color() = New Color() { Color.FromArgb(57, 120, 194), Color.FromArgb(67, 134, 216) }
		Private color2 As Color() = New Color() { Color.FromArgb(213, 67, 63), Color.FromArgb(255, 114, 110) }
		Private color3 As Color() = New Color() { Color.FromArgb(156, 197, 72), Color.FromArgb(168, 212, 79) }
		Private WithEvents chartControl1 As ChartControl
		Private color4 As Color() = New Color() { Color.FromArgb(130, 95, 173), Color.FromArgb(177, 139, 225) }

		#End Region

		#Region "Form constructor, Main and dispose"
		Public Sub New()
			InitializeComponent()

		End Sub


					''' <summary>
					''' The main entry point for the application.
					''' </summary>
					<STAThread> _
					Shared Sub Main()
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
            Me.components = New System.ComponentModel.Container
            Dim ChartSeries1 As Syncfusion.Windows.Forms.Chart.ChartSeries = New Syncfusion.Windows.Forms.Chart.ChartSeries
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label1 = New System.Windows.Forms.Label
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Location = New System.Drawing.Point(10, 341)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(422, 34)
            Me.panel1.TabIndex = 1
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label1.Location = New System.Drawing.Point(3, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(288, 23)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Click on the columns to drill down further"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'timer1
            '
            Me.timer1.Enabled = True
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.chartControl1.ForeColor = System.Drawing.SystemColors.ControlText
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(318, 75)
            Me.chartControl1.Location = New System.Drawing.Point(10, 11)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            ChartSeries1.Name = "Default"
            ChartSeries1.Points.Add(0, CType(18, Double), CType(127, Double), CType(112, Double), CType(108, Double))
            ChartSeries1.Points.Add(1, CType(56, Double), CType(73, Double), CType(61, Double), CType(56, Double))
            ChartSeries1.Points.Add(2, CType(4, Double), CType(212, Double), CType(82, Double), CType(107, Double))
            ChartSeries1.Points.Add(3, CType(50, Double), CType(348, Double), CType(55, Double), CType(190, Double))
            ChartSeries1.Points.Add(4, CType(87, Double), CType(246, Double), CType(136, Double), CType(192, Double))
            ChartSeries1.Text = "Default"
            Me.chartControl1.Series.Add(ChartSeries1)
            Me.chartControl1.Size = New System.Drawing.Size(422, 330)
            Me.chartControl1.TabIndex = 2
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(443, 374)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Drill Down"
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitializeChart()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
			Me.chartControl1.Indexed = True
		End Sub
		#End Region

#Region "Helper Methods"

#Region "InitializeDrillDownChart"
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type
        ''' </summary>
        Protected Sub InitializeDrillDownChart(ByVal index As Integer)

            Dim series1 As ChartSeries = New ChartSeries("Market Breakdown")
            series1.Name = "Market"
            series1.Text = series1.Name
            Dim labelArray As String() = Nothing

            Select Case index
                Case 0
                    labelArray = New String() {"Toyota", "Ford", "GM"}
                    Me.chartControl1.Titles(0).Text = "Automobile sales in the SUV segment"
                Case 1
                    labelArray = New String() {"Toyota", "Ford", "GM"}
                    Me.chartControl1.Titles(0).Text = "Automobile sales in the Car segment"
                Case 2
                    labelArray = New String() {"Mercedes", "Ford", "GM", "Chrysler"}
                    Me.chartControl1.Titles(0).Text = "Automobile sales in the Pickup segment"

                Case 3
                    labelArray = New String() {"Nissan", "Ford", "GM"}
                    Me.chartControl1.Titles(0).Text = "Automobile sales in the Minivan segment"
                Case Else
                    labelArray = New String() {"Toyota", "Ford", "GM"}
            End Select

            Dim count As Integer = Me.chartControl1.Series(0).Points(index).YValues.Length - 1
            For i As Integer = 0 To count - 1
                series1.Points.Add(i, Me.chartControl1.Series(0).Points(index).YValues(i + 1))
                series1.Styles(i).Text = labelArray(i) & " - " & Me.chartControl1.Series(0).Points(index).YValues(i + 1).ToString() & " %"
            Next i

            series1.Style.TextOrientation = ChartTextOrientation.RegionCenter
            series1.Style.DisplayText = True

            series1.Type = ChartSeriesType.Pie


            Me.chartControl1.Series.Clear()
            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            AddHandler series1.PrepareStyle, AddressOf series1_PrepareStyle
            Me.chartControl1.Refresh()
        End Sub
#End Region

#Region "InitializeChart"

        Protected Sub InitializeChart()
            Me.chartControl1.Series.Clear()

            Dim series1 As ChartSeries = New ChartSeries("Market")
            series1.Name = "Market"
            series1.Text = series1.Name

            series1.Points.Add(0, 20, 50, 25, 25) 'Only first Y value will be used by ColumnChart
            series1.Points.Add(1, 22, 50, 25, 35)
            series1.Points.Add(2, 23, 50, 25, 20, 20)
            series1.Points.Add(3, 24, 50, 25, 45)


            Me.chartControl1.PrimaryXAxis.LabelsImpl = New LabelModel(New String() {"", "SUV", "Car", "Pickup", "Minivan"})
            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Custom

            series1.Type = ChartSeriesType.Column
            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Titles(0).Text = "Automobile Sales by Category"

            Me.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

        End Sub
#End Region
#End Region

		#Region "Events"
		#Region "series1_PrepareStyle"
		Private Sub series1_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
			Dim series As ChartSeries = TryCast(sender, ChartSeries)
			series.ConfigItems.PieItem.PieType = ChartPieType.OutSide
			If Not series Is Nothing Then

				If args.Index = 0 Then
					args.Style.Interior = New BrushInfo(GradientStyle.PathEllipse,color1)
				ElseIf args.Index = 1 Then
					args.Style.Interior = New BrushInfo(GradientStyle.PathEllipse, color2)
				ElseIf args.Index = 2 Then
					args.Style.Interior = New BrushInfo(GradientStyle.PathEllipse, color3)
				Else
					args.Style.Interior = New BrushInfo(GradientStyle.PathEllipse, color4)
				End If

				args.Style.Border.Color = Color.Transparent
			End If
		End Sub
		#End Region

		#Region "ChartRegionClick"
		Private Sub chartControl1_ChartRegionClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionClick
			If e.Region.IsChartPoint Then
				If (Not isDrilledDown) Then
					InitializeDrillDownChart(e.Region.PointIndex)

					Me.label1.Text = "Click on the pie to go back and view " & Constants.vbLf & " 'Sales by category'"
				Else
					InitializeChart()

					Me.label1.Text = "Click on the columns to drill down further"

				End If
				isDrilledDown = Not isDrilledDown
			End If
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

			Me.chartControl1.Refresh()
		End Sub
		#End Region

		#Region "Timer"
		Private x As Integer = 0
		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			x = x + Me.timer1.Interval
		   If x < 3000 Then
				Me.label1.Location = New Point(Me.label1.Location.X + 5, Me.label1.Location.Y) '.X = this.label1.Location.X + 10;
			ElseIf x > 3000 AndAlso x < 6000 Then
				Me.label1.Location = New Point(Me.label1.Location.X - 5, Me.label1.Location.Y) '.X = this.label1.Location.X + 10;
		   ElseIf x > 6000 Then
				 x = 0
		   End If
		End Sub
#End Region

		#Region "ChartRegionMouseHover"
		 Private Sub chartControl1_ChartRegionMouseHover(ByVal sender As Object, ByVal e As ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseHover
			Dim mousePoint As Point = New Point(e.Point.X, e.Point.Y)
			Dim chpt As ChartPoint = chartControl1.ChartArea.GetValueByPoint(New Point(e.Point.X, e.Point.Y))
			Dim pt As Point = chartControl1.ChartArea.GetPointByValue(chpt)
			 Dim text As String = ""
			Select Case e.Region.PointIndex
				Case 0
					text = "Automobile sales in the SUV segment"

				Case 1
					text = "Automobile sales in the Car segment"
				Case 2
					text = "Automobile sales in the Pickup segment"
				Case 3
					text = "Automobile sales in the Minivan segment"
				Case Else
					text = ""
			End Select
			If e.Region.PointIndex >= 0 AndAlso e.Region.PointIndex < 4 Then
				 Me.chartControl1.Cursor = System.Windows.Forms.Cursors.Hand
				Else
					   Me.chartControl1.Cursor = System.Windows.Forms.Cursors.Default
				End If
				   If Me.chartControl1.Series(0).Type = ChartSeriesType.Column Then
					   toolTip1.SetToolTip(chartControl1, text)
				   End If
		 End Sub
		 #End Region
#End Region

	End Class

	#Region "LabelModel"
	Public Class LabelModel
		Implements IChartAxisLabelModel
		Private labels As String()

		Public Sub New(ByVal labels As String())
			Me.labels = labels
		End Sub

		Public Function GetLabelAt(ByVal index As Integer) As ChartAxisLabel Implements IChartAxisLabelModel.GetLabelAt
			Return New ChartAxisLabel(Me.labels(index))
		End Function

		Public ReadOnly Property Count() As Integer Implements IChartAxisLabelModel.Count
			Get
				Return Me.labels.GetLength(0)
			End Get
		End Property
	End Class
	#End Region
End Namespace
