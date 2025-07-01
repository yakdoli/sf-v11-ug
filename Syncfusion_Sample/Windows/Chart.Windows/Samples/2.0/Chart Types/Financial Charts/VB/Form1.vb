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

Namespace FinancialChart
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"

		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private panel1 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
		Public WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private checkBox2 As System.Windows.Forms.CheckBox
		Private checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents comboBox2 As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
		Private label9 As Label
		Private label3 As Label
		Private label4 As Label
		Private panel2 As Panel
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
		Private components As System.ComponentModel.Container = Nothing

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.panel1 = New System.Windows.Forms.Panel
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.label4 = New System.Windows.Forms.Label
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label3 = New System.Windows.Forms.Label
            Me.comboBox2 = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.panel2 = New System.Windows.Forms.Panel
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(310, 70)
            Me.chartControl1.LegendAlignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Near
            Me.chartControl1.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Right
            Me.chartControl1.Location = New System.Drawing.Point(19, 18)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Navy
            Me.chartControl1.PrimaryXAxis.OriginDate = New Date(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black
            Me.chartControl1.PrimaryYAxis.OriginDate = New Date(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl1.Size = New System.Drawing.Size(430, 306)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.checkBox2)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.checkBox1)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.comboBox2)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label9)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 370)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(466, 104)
            Me.panel1.TabIndex = 1
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox2.Location = New System.Drawing.Point(314, 39)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(77, 18)
            Me.checkBox2.TabIndex = 1
            Me.checkBox2.Text = "NASDAQ"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label4.Location = New System.Drawing.Point(104, 44)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(67, 13)
            Me.label4.TabIndex = 5
            Me.label4.Text = "Select series"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(262, 39)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(61, 18)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "NYSE"
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(108, 29)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(255, 1)
            Me.label3.TabIndex = 8
            '
            'comboBox2
            '
            Me.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox2.Location = New System.Drawing.Point(262, 73)
            Me.comboBox2.Name = "comboBox2"
            Me.comboBox2.Size = New System.Drawing.Size(104, 21)
            Me.comboBox2.TabIndex = 4
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(104, 76)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(153, 13)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Select Open-Close Draw Mode"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.BackColor = System.Drawing.Color.Transparent
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label9.Location = New System.Drawing.Point(104, 12)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(98, 14)
            Me.label9.TabIndex = 2
            Me.label9.Text = "HiLo Open Close"
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.Items.AddRange(New Object() {"Candle Chart", "HiLo Chart", "HiLo Open Close Chart", "Kagi Chart", "Point And Figure Chart", "Renko Chart", "Three Line Break Chart"})
            Me.comboBox1.Location = New System.Drawing.Point(81, 0)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(121, 21)
            Me.comboBox1.TabIndex = 1
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(3, 3)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(77, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Financial Chart"
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Location = New System.Drawing.Point(395, 4)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(66, 17)
            Me.checkBox3.TabIndex = 6
            Me.checkBox3.Text = "3D Style"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.comboBox1)
            Me.panel2.Controls.Add(Me.checkBox3)
            Me.panel2.Controls.Add(Me.label1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel2.Location = New System.Drawing.Point(0, 346)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(466, 24)
            Me.panel2.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(466, 474)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Financial Charts"
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.chartControl1.Series.Clear()
			Me.comboBox1.SelectedIndex = 0
			FillControlPanel()
			Me.comboBox2.SelectedIndex = 0
			InitializeControlSettings()

		End Sub
		#End Region 

		#Region "Helper Methods"

		#Region "InitializeControlSettings"
		Private Sub InitializeControlSettings()
			Me.chartControl1.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.chartControl1.Legend.Visible = False

			Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(85, 142, 213))
			Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
			Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.Transparent, Color.Transparent) ' System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(213))))), System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(213))))));

			Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(155, 178, 242)
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(155, 178, 242)
			Me.chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(155, 178, 242)
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(155, 178, 242)

            Me.chartControl1.BorderAppearance.SkinStyle = ChartBorderSkinStyle.Etched
            Me.chartControl1.BorderAppearance.Interior.ForeColor = Color.FromArgb(86, 143, 213)

		End Sub

		#End Region

		#Region "SetColor"
		Private Sub SetColor()
			Dim color1 As Color() = New Color() { Color.FromArgb(33, 76, 129), Color.FromArgb(191, 219, 255), Color.FromArgb(33, 76, 129) } ', Color.FromArgb(166, 198, 255) };//, Color.White };

			Me.chartControl1.Series(0).Style.Interior = New BrushInfo(GradientStyle.Horizontal, color1)
			Me.chartControl1.Series(0).Style.Border.Color = Color.White
			Me.chartControl1.Series(0).Style.Border.Width = 1


		End Sub
		Private Sub SetColor1()
			Dim color1 As Color() = New Color() { Color.White}
			Me.chartControl1.Series(0).Style.Interior = New BrushInfo(GradientStyle.None, color1)
			Dim color2 As Color() = New Color() { Color.FromArgb(33, 76, 129)}
			Me.chartControl1.Series(1).Style.Interior = New BrushInfo(GradientStyle.None, color2)
		End Sub
		#End Region 

		#Region "InitializeChartData"
		Protected Sub InitializeChartData()
			Dim r As Random = New Random()

			Dim select1 As String = Me.comboBox1.SelectedItem.ToString()
			Me.Size = New Size(478, 410)
			Me.panel1.Visible = False
			Select Case select1
				Case "Candle Chart"

					Dim series1 As ChartSeries = New ChartSeries(" Series 1", ChartSeriesType.Candle)
					series1.Text = series1.Name

					Dim date1 As DateTime = New DateTime(2006, 2, 12)
					series1.Points.Add(date1.AddDays(1), 470, 200, 270, 400)
					series1.Points.Add(date1.AddDays(2), 520, 234, 321, 458)
					series1.Points.Add(date1.AddDays(3), 482, 193, 352, 302)
					series1.Points.Add(date1.AddDays(4), 457, 230, 300, 410)
					series1.Points.Add(date1.AddDays(5), 421, 150, 357, 200)
					series1.Points.Add(date1.AddDays(6), 475, 200, 300, 385)

					Me.chartControl1.Series.Add(series1)
					Me.chartControl1.Text = "Stock Price Summary"
					Me.chartControl1.PrimaryYAxis.Title = "Price $"
					Me.chartControl1.PrimaryXAxis.Title = "Week Day"
					Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
					Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
					Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(date1, date1.AddDays(7), 2, ChartDateTimeIntervalType.Days)
					Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd"
					Me.chartControl1.Text = "Candle Chart"
					SetColor()
				Case "HiLo Chart"

					Dim series2 As ChartSeries = New ChartSeries("NYSE", ChartSeriesType.HiLo)
					series2.Text = series2.Name
					Dim start As DateTime = New DateTime(2006, 2, 20)

					series2.Points.Add(start.AddDays(0), 456, 214, 364, 386)
					series2.Points.Add(start.AddDays(1), 491, 234, 321, 378)
					series2.Points.Add(start.AddDays(2), 482, 193, 302, 352)
					series2.Points.Add(start.AddDays(3), 437, 243, 354, 391)
					series2.Points.Add(start.AddDays(4), 421, 223, 317, 367)
					series2.Points.Add(start.AddDays(5), 434, 263, 339, 385)
					series2.Points.Add(start.AddDays(6), 425, 245, 365, 396)
					series2.Points.Add(start.AddDays(7), 457, 234, 385, 398)
					series2.Points.Add(start.AddDays(8), 482, 267, 316, 389)
					series2.Points.Add(start.AddDays(9), 496, 285, 374, 399)

					Dim series3 As ChartSeries = New ChartSeries(" NASDAQ", ChartSeriesType.HiLo)
					series3.Text = series3.Name

					series3.Points.Add(start.AddDays(0), 437, 263, 373, 412)
					series3.Points.Add(start.AddDays(1), 491, 243, 383, 391)
					series3.Points.Add(start.AddDays(2), 480, 290, 313, 421)
					series3.Points.Add(start.AddDays(3), 466, 215, 323, 452)
					series3.Points.Add(start.AddDays(4), 486, 243, 328, 415)
					series3.Points.Add(start.AddDays(5), 461, 263, 356, 371)
					series3.Points.Add(start.AddDays(6), 489, 273, 316, 399)
					series3.Points.Add(start.AddDays(7), 484, 285, 384, 415)
					series3.Points.Add(start.AddDays(8), 461, 266, 396, 423)
					series3.Points.Add(start.AddDays(9), 498, 278, 328, 433)

					Me.chartControl1.Series.Add(series2)
					Me.chartControl1.Series.Add(series3)
					Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
					Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(start.AddDays(-1), start.AddDays(10), 2, ChartDateTimeIntervalType.Days)

					Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
					Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd"
					Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate
					Me.chartControl1.PrimaryYAxis.Title = "Price ($)"
					Me.chartControl1.Text = "HiLo Chart"
					SetColor1()
				Case "HiLo Open Close Chart"

					Me.Size = New Size(478, 515)
					Me.panel1.Visible = True
					Dim series4 As ChartSeries = New ChartSeries("NYSE", ChartSeriesType.HiLoOpenClose)
					series4.Text = series4.Name
					Dim [date] As DateTime = New DateTime(2006, 2, 13)

					series4.Points.Add([date], 456, 214, 364, 386)
					series4.Points.Add([date].AddDays(1), 491, 234, 321, 378)
					series4.Points.Add([date].AddDays(2), 482, 193, 302, 352)
					series4.Points.Add([date].AddDays(3), 437, 243, 354, 391)
					series4.Points.Add([date].AddDays(4), 421, 223, 317, 367)
					series4.Points.Add([date].AddDays(5), 434, 263, 339, 385)

					Dim series5 As ChartSeries = New ChartSeries("NASDAQ", ChartSeriesType.HiLoOpenClose)
					series5.Text = series5.Name

					series5.Points.Add([date], 437, 263, 373, 412)
					series5.Points.Add([date].AddDays(1), 491, 243, 383, 391)
					series5.Points.Add([date].AddDays(2), 480, 290, 313, 421)
					series5.Points.Add([date].AddDays(3), 466, 215, 323, 452)
					series5.Points.Add([date].AddDays(4), 486, 243, 328, 415)
					series5.Points.Add([date].AddDays(5), 461, 263, 356, 371)

					Me.chartControl1.Series.Add(series4)
					Me.chartControl1.Series.Add(series5)

					Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
					Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd"
					Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
					Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange([date].AddDays(-1), [date].AddDays(6), 2, ChartDateTimeIntervalType.Days)
					Me.chartControl1.PrimaryXAxis.Title = "Week Days"
					Me.chartControl1.PrimaryYAxis.Title = "Price $"
					Me.chartControl1.Text = "HiLo Open Close Chart"
					SetColor1()
				Case "Kagi Chart"

					Dim points2 As Double() = { 25.25, 27.75, 29.0, 28.275, 27.75, 27.75, 27.275, 26.25, 25.75, 25.25, 26.25, 25.25, 24.5, 25.625, 25.5, 26.625, 26.275, 26.25, 26.875, 27.25, 26.875, 26.5, 27.125, 26.275, 25.875, 26.625, 27.125, 26.25, 27.0, 27.25, 27.5, 28.5, 29.5, 28.875, 28.5, 29.0, 28.5, 28.5, 29.0, 29.0, 40.0, 29.875, 29.875, 28.875, 28.5, 28.25, 28.875, 29.275, 29.275, 29.75, 29.5, 29.275, 28.5, 27.75, 27.625, 27.5, 26.5, 25.0, 26.625, 26.0, 25.875, 25.0, 25.25, 25.125, 25.05 }
					Dim current As DateTime = New DateTime(2004, 01, 1)
					Dim numPoints As Integer = points2.Length

					Dim series As ChartSeries = New ChartSeries("Series 1")
					For j As Integer = 0 To numPoints - 1
						series.Points.Add(current.AddDays(j * 5), points2(j))
					Next j

					series.Type = ChartSeriesType.Kagi
					series.Text = series.Name
					series.ReversalAmount = 1.0
					series.ConfigItems.FinancialItem.PriceUpColor = Color.White
					series.ConfigItems.FinancialItem.PriceDownColor = Color.FromArgb(33, 76, 129)

					series.Style.Border.Width = 1
					Me.chartControl1.Series.Add(series)

					Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
					Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(current, current.AddMonths(13), 3, ChartDateTimeIntervalType.Months)
					Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd"
					Me.chartControl1.Text = "Kagi Chart"
				Case "Point And Figure Chart"
					 Dim points As Double() = { 35.250,37.750,39.000,38.275,37.750,37.750,37.275,36.250,35.750,35.250,36.250,35.250,34.500, 35.625,35.500,36.625,36.275,36.250,36.875,37.250,36.875,36.500,37.125,36.275,35.875,36.625, 27.125,26.250,27.000,27.250,37.500,38.500,39.500,38.875,38.500,39.000,38.500,28.500,29.000, 29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275, 28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050}

					Dim points1 As Double() = { 25,27.500,28.750,28.025,27.500,27.500,27.025,26.250,35.750,35.250,36.250,35.250,34.500, 25.625,25.500,26.625,26.275,26.250,26.875,27.250,26.875,26.500,27.125,26.275,25.875,26.625, 27.125,26.250,27.000,27.250,27.500,38.500,39.500,38.875,38.500,39.000,28.500,28.500,29.000, 29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275, 28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050}


					Dim current1 As DateTime = New DateTime(2004, 01, 1)
					Dim numPoints1 As Integer = points.Length

					Dim series7 As ChartSeries = New ChartSeries("Series 1")
					For j As Integer = 0 To numPoints1 - 1
						series7.Points.Add(current1.AddDays(j), New Double() { points(j), points1(j) })
					Next j

					series7.Type = ChartSeriesType.PointAndFigure
					series7.Text = series7.Name
					series7.ReversalAmount = 0.0


					Me.chartControl1.Series.Add(series7)

					Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
					Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(current1, current1.AddDays(30), 10, ChartDateTimeIntervalType.Days)
					Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd"
					Me.chartControl1.Text = "Point And Figure Chart"
					series7.ConfigItems.FinancialItem.PriceUpColor = Color.White
					series7.ConfigItems.FinancialItem.PriceDownColor = Color.FromArgb(33, 76, 129)
					series7.Style.Border.Width = 1
					SetColor()
			   Case "Renko Chart"
					Dim points5 As Double() = { 25.250,27.750,29.000,28.275,27.750,27.750,27.275,26.250,25.750,25.250,26.250,25.250,24.500, 25.625,25.500,26.625,26.275,26.250,26.875,27.250,26.875,26.500,27.125,26.275,25.875,26.625, 27.125,26.250,27.000,27.250,27.500,28.500,29.500,28.875,28.500,29.000,28.500,28.500,29.000, 29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275, 28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050}

					Dim date5 As DateTime = New DateTime(2004, 1, 1)

					Dim series11 As ChartSeries = New ChartSeries("Series " & 0)

					For day As Integer = 0 To points5.Length - 1
						series11.Points.Add(date5.AddDays(day), points5(day))
					Next day

					series11.Type = ChartSeriesType.Renko
					series11.ReversalAmount = 1
					series11.ConfigItems.FinancialItem.PriceUpColor = Color.White
					series11.ConfigItems.FinancialItem.PriceDownColor = Color.FromArgb(33, 76, 129)
					Me.chartControl1.Series.Add(series11)

					Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
					Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd"
					Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(date5, date5.AddDays(60), 10, ChartDateTimeIntervalType.Days)
					Me.chartControl1.Text = "Renko Chart"
					Me.chartControl1.PrimaryYAxis.Format = "$ #"
				Case "Three Line Break Chart"

					Dim points6 As Double() = { 25.250,27.750,29.000,28.275,27.750,27.750,27.275,26.250,25.750,25.250,26.250,25.250,24.500, 25.625,25.500,26.625,26.275,26.250,26.875,27.250,26.875,26.500,27.125,26.275,25.875,26.625, 27.125,26.250,27.000,27.250,27.500,28.500,29.500,28.875,28.500,29.000,28.500,28.500,29.000, 29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275, 28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050}

					Dim dates As DateTime = DateTime.Today.AddDays(-points6.Length)

					Dim series8 As ChartSeries = New ChartSeries("Series " & 0)

					For day As Integer = 0 To points6.Length - 1
						series8.Points.Add(dates.AddDays(day), points6(day))
					Next day

					series8.Type = ChartSeriesType.ThreeLineBreak
					series8.ReversalAmount = 3.0
					series8.ConfigItems.FinancialItem.PriceUpColor = Color.White
					series8.ConfigItems.FinancialItem.PriceDownColor = Color.FromArgb(33, 76, 129)

					Me.chartControl1.Text = "Three Line Break Chart"
					Me.chartControl1.PrimaryYAxis.Format = "$ #"
					Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(dates, dates.AddDays(60), 10, ChartDateTimeIntervalType.Days)
					Me.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd"
					Me.chartControl1.Series.Add(series8)
				Case Else
					MessageBox.Show("Select any ONE Chart from the ListBox", "Error", MessageBoxButtons.OK)
			End Select
		End Sub

		#End Region

		#Region "FillControlPanel"
		Protected Sub FillControlPanel()
			For Each mode As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartOpenCloseDrawMode))
				Me.comboBox2.Items.Add(mode)
			Next mode

		End Sub

		#End Region


		#End Region 

		#Region "Events"
		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
			Me.chartControl1.Series.Clear()
			InitializeChartData()
		End Sub

		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox2.SelectedIndexChanged
			If Me.checkBox1.Checked AndAlso Me.checkBox2.Checked Then
				Me.chartControl1.Series(0).ConfigItems.HiLoOpenCloseItem.DrawMode = CType(System.Enum.Parse(GetType(ChartOpenCloseDrawMode), Me.comboBox2.SelectedItem.ToString(), True), ChartOpenCloseDrawMode)
				Me.chartControl1.Series(1).ConfigItems.HiLoOpenCloseItem.DrawMode = CType(System.Enum.Parse(GetType(ChartOpenCloseDrawMode), Me.comboBox2.SelectedItem.ToString(), True), ChartOpenCloseDrawMode)
			ElseIf Me.checkBox1.Checked Then
				Me.chartControl1.Series(0).ConfigItems.HiLoOpenCloseItem.DrawMode = CType(System.Enum.Parse(GetType(ChartOpenCloseDrawMode), Me.comboBox2.SelectedItem.ToString(), True), ChartOpenCloseDrawMode)
			ElseIf Me.checkBox2.Checked Then
				Me.chartControl1.Series(1).ConfigItems.HiLoOpenCloseItem.DrawMode = CType(System.Enum.Parse(GetType(ChartOpenCloseDrawMode), Me.comboBox2.SelectedItem.ToString(), True), ChartOpenCloseDrawMode)
			End If

			Me.chartControl1.Refresh()
		End Sub

		Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
			If Me.checkBox3.Checked Then
				Me.chartControl1.Series3D = True
			Else
				Me.chartControl1.Series3D = False
			End If
		End Sub

		#End Region 
	End Class
End Namespace
