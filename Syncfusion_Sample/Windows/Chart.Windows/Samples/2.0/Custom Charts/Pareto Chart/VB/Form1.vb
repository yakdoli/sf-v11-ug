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

Namespace Pareto
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		Private chartControl As Syncfusion.Windows.Forms.Chart.ChartControl
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Private timer1 As System.Windows.Forms.Timer
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.SuspendLayout()
            '
            'chartControl
            '
            Me.chartControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            '
            '
            '
            Me.chartControl.Legend.Location = New System.Drawing.Point(398, 31)
            Me.chartControl.Location = New System.Drawing.Point(22, 22)
            Me.chartControl.Name = "chartControl"
            Me.chartControl.Size = New System.Drawing.Size(507, 331)
            Me.chartControl.TabIndex = 0
            '
            '
            '
            Me.chartControl.Title.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl.Title.Name = "Def_title"
            Me.chartControl.Title.Text = ""
            Me.chartControl.Titles.Add(Me.chartControl.Title)
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            '
            'timer1
            '
            Me.timer1.Enabled = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(554, 375)
            Me.Controls.Add(Me.chartControl)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Pareto Chart"
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
			CreateParetoChart()
		End Sub

		Protected Sub CreateParetoChart()
			Me.chartControl.Title.Text = "Pareto Chart"
			Me.chartControl.Series.Clear()

			Dim series1 As ChartSeries = New ChartSeries("Defects")
			series1.Type = ChartSeriesType.Column
			series1.Points.Add(1, 120)
			series1.Points.Add(2, 60)
			series1.Points.Add(3, 50)
			series1.Points.Add(4, 40)
			series1.Points.Add(5, 20)
			series1.Points.Add(6, 10)
			series1.Style.Interior = New BrushInfo(Color.FromArgb(200, 140, 198, 62))
			series1.Style.Border.Color = Color.Transparent
			Me.chartControl.Series.Add(series1)
			AddHandler chartControl.PrimaryXAxis.FormatLabel, AddressOf PrimaryXAxis_FormatLabel
			Me.chartControl.PrimaryXAxis.HidePartialLabels = True
			Me.chartControl.PrimaryXAxis.Title = "Defects"

			Dim ser As ChartSeries = New ChartSeries("Frequency", ChartSeriesType.Line)
			ser.Style.Border.Width = 3
			ser.Style.Interior = New BrushInfo(Color.FromArgb(163, 48, 45))
			ser.Points.Add(0, 0)

			Dim val As Double = 0
			' To get the Total of all points.
			For j As Integer = 0 To Me.chartControl.Series(0).Points.Count - 1
				val += Me.chartControl.Series(0).Points(j).YValues(0)
			Next j

			Dim i As Integer = 0
			' To get the cumulative points [ Y Values ] for line series.
			Do While i < Me.chartControl.Series(0).Points.Count
				Dim val1 As Double = 0
				For k As Integer = 0 To i
					val1 += Me.chartControl.Series(0).Points(k).YValues(0)
				Next k

				ser.Points.Add(i + 1, (val1 / val) * 100) ' calculates percentage of cumulative values
				i += 1
			Loop

			Me.chartControl.PrimaryYAxis.Range.Max = val
			Me.chartControl.PrimaryYAxis.Title = "Frequency"

			ser.Style.Symbol.Shape = ChartSymbolShape.Diamond
			ser.Style.Symbol.Color = Color.Yellow
			ser.Style.Symbol.Size = New Size(7, 7)
			Me.chartControl.Series.Add(ser)
			Me.chartControl.PrimaryYAxis.Range.Max = val

			secYAxis.DrawGrid = False
			secYAxis.HidePartialLabels = False
			secYAxis.OpposedPosition = True
			secYAxis.Title = "Cumulative Frequency"
			secYAxis.ValueType = ChartValueType.Double
			secYAxis.Orientation = ChartOrientation.Vertical
			secYAxis.TickSize = New Size(5, 1)

			Me.chartControl.Series(1).YAxis = secYAxis
			Me.chartControl.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.Stacking
			Me.chartControl.Axes.Add(secYAxis)

			' Set ranges
			secYAxis.Range = New MinMaxInfo(0, 100, 20)
			Me.chartControl.PrimaryXAxis.Range = New MinMaxInfo(0, 7, 1)
			Me.chartControl.PrimaryYAxis.Range.Min = 0
			AddHandler secYAxis.FormatLabel, AddressOf secYAxis_FormatLabel
		End Sub

		Private Sub PrimaryXAxis_FormatLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs)
			e.Label = "D" & e.Label
			e.Handled = True
		End Sub

		Private Sub secYAxis_FormatLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs)
			e.Label &= " %"
			e.Handled = True
		End Sub
	End Class
End Namespace