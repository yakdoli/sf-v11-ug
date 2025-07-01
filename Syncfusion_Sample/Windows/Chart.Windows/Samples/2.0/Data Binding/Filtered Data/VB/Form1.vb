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

Namespace Syncfusion.Windows.Forms.Chart.Samples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private components As System.ComponentModel.IContainer
		Private datamodel1 As DataModel
		Private datamodel2 As DataModel
		Private datamodel3 As DataModel
		Private datamodel4 As DataModel
		Private datamodel5 As DataModel
		Private datamodel6 As DataModel
		Private datamodel7 As DataModel
		Private datamodel8 As DataModel
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private label1 As System.Windows.Forms.Label
		Private dprovider As DataProvider = New DataProvider()
		Private start As DateTime

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
		

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
            Me.label1 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.panel1.SuspendLayout()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(454, 75)
            Me.chartControl1.Location = New System.Drawing.Point(20, 17)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Title = "Time"
            Me.chartControl1.PrimaryYAxis.Title = "Network Load"
            Me.chartControl1.Size = New System.Drawing.Size(585, 356)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Peak Avearage Network Load"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Peak Avearage Network Load"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.numericUpDown1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 375)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(624, 33)
            Me.panel1.TabIndex = 1
            '
            'numericUpDown1
            '
            Me.numericUpDown1.BackColor = System.Drawing.Color.White
            Me.numericUpDown1.Increment = New Decimal(New Integer() {200, 0, 0, 0})
            Me.numericUpDown1.Location = New System.Drawing.Point(525, 6)
            Me.numericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.numericUpDown1.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.ReadOnly = True
            Me.numericUpDown1.Size = New System.Drawing.Size(96, 20)
            Me.numericUpDown1.TabIndex = 2
            Me.numericUpDown1.Value = New Decimal(New Integer() {800, 0, 0, 0})
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(412, 10)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(112, 17)
            Me.label1.TabIndex = 3
            Me.label1.Text = "Select Timer Interval"
            '
            'checkBox1
            '
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(298, 6)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(96, 24)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "Enable Styles"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(624, 408)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Filtered Data "
            Me.panel1.ResumeLayout(False)
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitializeChartData()
			InitializeChartAppearance()
			Me.dprovider.timer1.Enabled = True
			AddHandler dprovider.timer1.Tick, AddressOf timer1_Tick
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub

		''' <summary>
		''' Initializes Chart Data.
		''' </summary>
		Protected Sub InitializeChartData()
			'Setting Indexed to false speeds up the Chart. This is not a choice for making the Chart faster. 
			'If you don't need a Indexed/Positional Chart, you must set this property to false.
			Me.chartControl1.Indexed = False

			Dim series As ChartSeries = New ChartSeries("Line 1",ChartSeriesType.Line)

			datamodel1 = New DataModel()
            series.SeriesModel = datamodel1

			'Point Symbols and Point Text will not be visible if Enable Styles is set to false.
			series.EnableStyles = False

			'Turning shadow off means, your lines will not have shadows (and hence the chart will be rendered faster).
            series.Style.DisplayShadow = False
			Me.chartControl1.Series.Add(series)

            series = New ChartSeries("Line 2", ChartSeriesType.Line)
			datamodel2 = New DataModel()
            series.SeriesModel = datamodel2
            Me.chartControl1.Series.Add(series)

            series = New ChartSeries("Line 3", ChartSeriesType.Line)
			datamodel3 = New DataModel()
            series.SeriesModel = datamodel3
            Me.chartControl1.Series.Add(series)
           
			For Each seriesn As ChartSeries In Me.chartControl1.Series
				seriesn.EnableStyles = False
				seriesn.Style.DisplayShadow = False
				AddHandler seriesn.PrepareStyle, AddressOf series_PrepareStyle
			Next seriesn
		End Sub

		''' <summary>
		''' Initializes chart appearance.
		''' </summary>
		Protected Sub InitializeChartAppearance()
			Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
			Me.chartControl1.PrimaryXAxis.DateTimeFormat = "hh:mm:ss"

			'This property controls Tooltips and AutoHighlighting. 
			'If this value is set to false, these features will not work.
			Me.chartControl1.CalcRegions = False

			Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate
            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(DateTime.Now.AddMinutes(-1),DateTime.Now.AddMinutes(3),1,ChartDateTimeIntervalType.Minutes)
			start = Me.chartControl1.PrimaryXAxis.DateTimeRange.End
		End Sub

		''' <summary>
		''' Timer tick event.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)
			Me.dprovider.timer1.Enabled = False
			Me.chartControl1.BeginUpdate()
			Me.datamodel1.Refresh()
			Me.datamodel2.Refresh()
            Me.datamodel3.Refresh()
			Me.chartControl1.EndUpdate()
			Me.dprovider.timer1.Enabled = True
            If Me.chartControl1.Series(2).Points(Me.chartControl1.Series(2).Points.Count - 1).DateX > start Then
                Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(DateTime.Now.AddMinutes(-1), DateTime.Now.AddMinutes(2), 1, ChartDateTimeIntervalType.Minutes)
                start = Me.chartControl1.PrimaryXAxis.DateTimeRange.End
            End If
		End Sub

		Private Sub series_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
			Dim series As ChartSeries = TryCast(sender, ChartSeries)
			If Not series Is Nothing Then
				args.Style.Symbol.Shape = ChartSymbolShape.Square
				args.Style.Symbol.Size = New Size(2,2)
				args.Style.Symbol.Color = Color.DarkGreen
			End If
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			For Each ser As ChartSeries In Me.chartControl1.Series
				ser.EnableStyles = Me.checkBox1.Checked
			Next ser
		End Sub

		Private Sub numericUpDown1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericUpDown1.ValueChanged
			Me.dprovider.timer1.Interval = CInt(Fix(Me.numericUpDown1.Value))
        End Sub
    End Class
End Namespace