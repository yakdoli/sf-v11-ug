Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Xml
Imports System.Data.OleDb

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Chart

Namespace ChartImportData
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private lastTime As DateTime = DateTime.Now
		Private chartTitle1 As ChartTitle
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label40 As Label
		Private label6 As Label
		Private components As System.ComponentModel.Container = Nothing
		Private panel2 As Panel
		Private WithEvents comboBox1 As ComboBox
		Private label4 As Label
		Private model As ChartOversizedDataBindModel
		#End Region

		#Region "Form's Constructor, Main and Dispose"
		Public Sub New()
			InitializeComponent()
			Me.comboBox1.SelectedIndex = 0
			Application.EnableVisualStyles()
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
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.chartTitle1 = New Syncfusion.Windows.Forms.Chart.ChartTitle
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label40 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.label4 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.chartControl1.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Silver, System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ForeColor = System.Drawing.Color.Black
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(58, 305)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(29, 9)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.Size = New System.Drawing.Size(637, 382)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.Titles.Add(Me.chartTitle1)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'chartTitle1
            '
            Me.chartTitle1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartTitle1.Name = "chartTitle1"
            Me.chartTitle1.Text = "chartTitle1"
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackColor = System.Drawing.Color.White
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel2.Controls.Add(Me.label40)
            Me.gradientPanel2.Controls.Add(Me.label6)
            Me.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gradientPanel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel2.Location = New System.Drawing.Point(0, 429)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(688, 161)
            Me.gradientPanel2.TabIndex = 6
            '
            'label40
            '
            Me.label40.BackColor = System.Drawing.Color.Transparent
            Me.label40.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label40.Location = New System.Drawing.Point(0, 45)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(688, 116)
            Me.label40.TabIndex = 1
            Me.label40.Text = resources.GetString("label40.Text")
            '
            'label6
            '
            Me.label6.Dock = System.Windows.Forms.DockStyle.Top
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(0, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(688, 45)
            Me.label6.TabIndex = 5
            Me.label6.Text = "               Sample Description"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.White
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Controls.Add(Me.comboBox1)
            Me.panel2.Location = New System.Drawing.Point(29, 397)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(637, 23)
            Me.panel2.TabIndex = 4
            '
            'label4
            '
            Me.label4.Dock = System.Windows.Forms.DockStyle.Right
            Me.label4.Location = New System.Drawing.Point(426, 0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(90, 23)
            Me.label4.TabIndex = 3
            Me.label4.Text = "Data Points"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'comboBox1
            '
            Me.comboBox1.Dock = System.Windows.Forms.DockStyle.Right
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"100000", "50000", "20000", "10000"})
            Me.comboBox1.Location = New System.Drawing.Point(516, 0)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(688, 590)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.gradientPanel2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart with Huge DataSource"
            Me.chartControl1.ResumeLayout(False)
            Me.chartControl1.PerformLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'InitializeChartData(100000);
			ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub
		#End Region

		#Region "InitializeChartData"
		''' <summary>
		''' Initializes chart data from a sample data table.
		''' </summary>
		Protected Sub InitializeChartData(ByVal totalXValues As Integer)
			' Create a sample table:
			Dim tableSource As DataTable = Me.CreateLargeTable(totalXValues)

			'Initializes new chart series.
			Dim series As New ChartSeries("population", ChartSeriesType.Spline)

			' Instantiate the Model that "dilutes" the large set of data points based on the current chart width. Instead of just skipping
			' points, this model uses an average of a set of points and uses those averages instead of the points.
			Me.model = New ChartOversizedDataBindModel(Me.chartControl1, tableSource, "X", "Y")

			' Update chart settings based on the Model:
			Me.InitChartBasedOnModel(model)

			' Assign this data model to the new series.
			series.SeriesModel = model

			'Adds the series to the ChartSeriesCollection.
			Me.chartControl1.Series.Add(series)

			Me.UpdateChartTitle()

			AddHandler series.PrepareStyle, AddressOf series_PrepareStyle
			Me.chartControl1.EnableXZooming = True
			AddHandler model.DilutionFactorChanged, AddressOf model_DilutionFactorChanged
			AddHandler chartControl1.ChartFormatAxisLabel, AddressOf ChartWebControl1_ChartFormatAxisLabel
		End Sub

		#End Region

		#Region "CreateLargeTable"
		Private Function CreateLargeTable(ByVal totalXValues As Integer) As DataTable
			Dim yMax As Integer = 600
			Dim tempstart As New DateTime(2003, 11, 1)

			Dim table As New DataTable()
			' It's important that the x values are marked as integer or DateTime, otherwise, the engine will treat it as strings and
			' sort them incorrectly.
			Dim x As New DataColumn("X", GetType(DateTime))
			table.Columns.Add(x)
			table.Columns.Add(New DataColumn("Y"))

			Dim ran As New Random(DateTime.Now.Second)
			Dim rany As New Random()

			For i As Integer = 1 To totalXValues
				'int xVal = i;
				Dim dtX As DateTime = tempstart.AddHours(i)
				Dim yVal As Double = (CDbl(i) / totalXValues) * (yMax - 40) + ran.Next(0, 40)

				Dim row As DataRow = table.NewRow()

				'row[0] = xVal;
				row(0) = dtX
				row(1) = yVal

				table.Rows.Add(row)
			Next i
			Return table
		End Function
		#End Region       

		#Region "Events"
		Private Sub ChartWebControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs)
			If e.AxisOrientation = ChartOrientation.Horizontal Then
				' Here we customize the label text for a point by getting the text from the model:
				Dim model As ChartOversizedDataBindModel = TryCast(Me.chartControl1.Series(0).SeriesModel, ChartOversizedDataBindModel)

				Dim index As Integer = CInt(Fix(e.Value))
				If model IsNot Nothing AndAlso index < model.Count Then
					' The fact that the data type is DateTiem is based on our knowledge of the bound data source.
					Dim [date] As DateTime = CDate(model.GetXData(CInt(Fix(e.Value))))
					e.Label = Me.GetFormattedLabelText([date])
				Else
					e.Label = String.Empty
				End If

				e.Handled = True
			End If
		End Sub
		Private Function GetFormattedLabelText(ByVal dtX As DateTime) As String
			' This logic we use here is based on prior knowledge of the data source.
			' We know that we have 1 data point for every hour, so this logic is based on that knowledge
			If Me.model.DilutionFactor > 700 Then ' 24 X 30 = 720
				Return dtX.ToString("MMM yyyy")
			ElseIf Me.model.DilutionFactor > 24 Then
				Return dtX.ToString("dd MMM yyyy")
			ElseIf Me.model.DilutionFactor > 12 Then
				Return dtX.ToString("dd MMM yyyy tt")
			Else
				Return dtX.ToString("dd MMM yyyy HH") & "hrs"
			End If
		End Function

		Private Sub InitChartBasedOnModel(ByVal model As ChartOversizedDataBindModel)
			Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Double
			Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
			Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, model.Count, CInt(Fix(model.Count \ 10)))

			Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
			Dim maxY As Double = model.GetMaxY()
			Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, maxY, CInt(Fix(maxY / 10)))
		End Sub
		Private Sub series_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
			' Compose the tooltip for each point:
			Dim series As ChartSeries = TryCast(sender, ChartSeries)
			series.PointsToolTipFormat = "{2}"
			If args IsNot Nothing Then
				Dim dd As DateTime = CDate(model.GetXData(args.Index))
				Dim y As Double = Me.chartControl1.Series(0).Points(args.Index).YValues(0)

				args.Style.ToolTip = "X= " & Me.GetFormattedLabelText(dd) & ", Y= " & y.ToString("F01")
			End If
			args.Handled = True
		End Sub
		'Set Data Points
		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			Dim dataPoints As Integer = Convert.ToInt32(Me.comboBox1.SelectedItem)
			Me.chartControl1.Series.Clear()
			Me.InitializeChartData(dataPoints)
		End Sub

		Private Sub model_DilutionFactorChanged(ByVal sender As Object, ByVal e As EventArgs)
			' Could happen when chart resizes or zoomed in.
			Me.UpdateChartTitle()
			Dim model As ChartOversizedDataBindModel = TryCast(sender, ChartOversizedDataBindModel)
			Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, model.Count, CInt(Fix(model.Count \ 10)))
		End Sub

		Private Sub UpdateChartTitle()
			Me.chartControl1.Text = "Compression Ratio - " & (CType(Me.chartControl1.Series(0).SeriesModel, ChartOversizedDataBindModel)).DilutionFactor.ToString() & " : 1"
			Me.chartTitle1.Text = "Number of data points: " & Me.comboBox1.SelectedItem.ToString()
		End Sub
		Private Sub chartControl1_VisibleRangeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.model.RangeChanged(Convert.ToDouble(Me.comboBox1.SelectedItem))
        End Sub
		#End Region
	End Class
End Namespace