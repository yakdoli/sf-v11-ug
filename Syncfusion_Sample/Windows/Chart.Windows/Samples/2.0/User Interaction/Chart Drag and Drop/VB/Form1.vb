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

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartDragDrop
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.Office2007Form
		#Region "Private Members"
		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
		Private isDragging As Boolean = False
		Private currentRegion As ChartRegion = Nothing
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		#End Region

		#Region "Form constructor, Main And Dispose"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label1 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(333, 70)
            Me.chartControl1.Location = New System.Drawing.Point(7, 8)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(452, 331)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 337)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(467, 30)
            Me.panel1.TabIndex = 1
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(306, 5)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(59, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Chart Type"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.comboBox1.Items.AddRange(New Object() {"Line", "Column", "Scatter"})
            Me.comboBox1.Location = New System.Drawing.Point(371, 2)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(96, 21)
            Me.comboBox1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(467, 367)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Drag and Drop "
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitializeChartData()
			  Me.comboBox1.SelectedIndex = 0
		End Sub
		#End Region

		#Region "Helper Methods"
		#Region "InitializeChartData"
		''' <summary>
		''' Initializes chart data
		''' </summary>
		Protected Sub InitializeChartData()
            Dim series As ChartSeries = New ChartSeries("Drag and Drop Series", ChartSeriesType.Line)
            series.Text = series.Name
            series.Points.Add(1, 25)
            series.Points.Add(2, 31)
            series.Points.Add(3, 42)
            series.Points.Add(4, 59)
            series.Points.Add(5, 78)
            series.Points.Add(6, 89)
            Me.chartControl1.Series.Add(series)
		End Sub
#End Region
		#End Region

		#Region "Events"
		Private selectedDataPoint As Point

		''' <summary>
		''' The chart mouse down event
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub chartControl1_ChartRegionMouseDown(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseDown
			selectedDataPoint = New System.Drawing.Point()
			If e.Region.Type = ChartRegionType.SeriesPoint Then
				selectedDataPoint = e.Point
				Me.Cursor = Cursors.SizeAll
				Me.isDragging = True
				Me.currentRegion = e.Region
			End If

		End Sub

		''' <summary>
		''' The chart mouse up event
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>

		Private Sub chartControl1_ChartRegionMouseUp(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseUp
			Cursor = Cursors.SizeAll
			If Me.isDragging Then
				Dim newY As Double = Math.Floor(Me.chartControl1.ChartArea.GetValueByPoint(e.Point).YValues(0))
				Dim newX As Double = Me.chartControl1.ChartArea.GetValueByPoint(e.Point).X


				If newY < 0 OrElse newY >= 50 OrElse newX < 0 OrElse newX > 7 Then
					MessageBox.Show("Cannot drag outside chart bounds")
				Else
					Me.NewYValue(newY)
					Me.NewXValue(newX)
				End If

				Me.isDragging = False
				Me.currentRegion = Nothing
				Me.selectedDataPoint.Y = 0
				Me.selectedDataPoint.X = 0
				Me.chartControl1.Redraw(True)
			End If

			Me.chartControl1.Series(0).Style.TextFormat = "{0}"
			Me.chartControl1.Refresh()
		End Sub
		Private Sub NewXValue(ByVal newX As Double)
			Me.chartControl1.Series(0).Points(Me.currentRegion.PointIndex).X = newX
		End Sub
		Private Sub NewYValue(ByVal newY As Double)
			Me.chartControl1.Series(0).Points(Me.currentRegion.PointIndex).YValues(0) = newY
		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
			Me.chartControl1.Series.Clear()
			InitializeChartData()
            Me.chartControl1.Series(0).Type = CType(System.Enum.Parse(GetType(ChartSeriesType), Me.comboBox1.SelectedItem.ToString(), True), ChartSeriesType)
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
			Me.chartControl1.Refresh()
		End Sub

		Private Sub chartControl1_ChartRegionMouseMove(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseMove
				If e.Region.Type = ChartRegionType.SeriesPoint Then
					Me.isDragging = True
					Me.currentRegion = e.Region
					Me.Cursor = Cursors.SizeAll
				Else
					If Me.selectedDataPoint.X=0 AndAlso Me.selectedDataPoint.Y=0 Then
					Me.Cursor = Cursors.Default
					End If
				End If
		End Sub

		Private Sub chartControl1_ChartRegionClick(ByVal sender As Object, ByVal e As ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionClick
			If e.Region.Type = ChartRegionType.ChartCustom Then
				Me.isDragging = False
				Me.Cursor = Cursors.Default
			End If
		End Sub
		#End Region


	End Class
End Namespace