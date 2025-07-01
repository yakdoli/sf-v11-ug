Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports System.Drawing.Drawing2D
Imports Syncfusion.Drawing

Namespace MultipleAxesLayout
	Public Partial Class Form1
		Inherits Office2007Form
        Public Sub New()
            InitializeComponent()
        End Sub

		#Region "Chart control Data."
		Private Sub ChartControlData()
			Me.chartControl1.Series.Clear()

			Dim axis As ChartAxis = Me.chartControl1.PrimaryYAxis
			Dim axis0 As ChartAxis = New ChartAxis(ChartOrientation.Vertical)
			Dim axis1 As ChartAxis = New ChartAxis(ChartOrientation.Vertical)


			Dim axis2 As ChartAxis = New ChartAxis(ChartOrientation.Vertical)
			Dim axis3 As ChartAxis = New ChartAxis(ChartOrientation.Vertical)
			Dim axis4 As ChartAxis = New ChartAxis(ChartOrientation.Vertical)

			Dim layout1 As ChartAxisLayout = New ChartAxisLayout()
			Dim layout2 As ChartAxisLayout = New ChartAxisLayout()

			chartControl1.Axes.Add(axis0)
			chartControl1.Axes.Add(axis1)

			chartControl1.Axes.Add(axis2)
			chartControl1.Axes.Add(axis3)
			chartControl1.Axes.Add(axis4)

			layout1.Spacing = 12
			layout2.Spacing = 12

			layout2.Axes.Add(axis)
			layout2.Axes.Add(axis0)
			layout2.Axes.Add(axis1)

			layout1.Axes.Add(axis2)
			layout1.Axes.Add(axis3)
			layout1.Axes.Add(axis4)

			chartControl1.ChartArea.YLayouts.Add(layout1)
			chartControl1.ChartArea.YLayouts.Add(layout2)

			Dim population As ChartSeries = New ChartSeries("Population", ChartSeriesType.Column)
			population.Points.Add(0, 1.3)
			population.Points.Add(1, 1)
			population.Points.Add(2, 0.5)
			population.Points.Add(3, 0.3)

			Dim Growth As ChartSeries = New ChartSeries("Growth[%]", ChartSeriesType.Column)
			Growth.Points.Add(0, 0.7)
			Growth.Points.Add(1, 1.6)
			Growth.Points.Add(2, 0.7)
			Growth.Points.Add(3, 0.4)

			Dim Birthrate As ChartSeries = New ChartSeries("BirthRate", ChartSeriesType.Column)
			Birthrate.Points.Add(0, 15)
			Birthrate.Points.Add(1, 27)
			Birthrate.Points.Add(2, 17)
			Birthrate.Points.Add(3, 24)

			population.YAxis = axis
			Growth.YAxis = axis0
			Birthrate.YAxis = axis1

			axis.Title = "Population (Million)"
			axis0.Title = "Growth[%]"
            axis1.Title = "Birthrate"

			Dim GDP As ChartSeries = New ChartSeries("GDP pc in 1000 ", ChartSeriesType.Line)
			GDP.Points.Add(0, 10)
			GDP.Points.Add(1, 5)
			GDP.Points.Add(2, 85)
			GDP.Points.Add(3, 5)
            GDP.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.FromArgb(200, 234, 90, 81))
			GDP.Style.Border.Width = 2

			Dim Lifeexpect As ChartSeries = New ChartSeries("Life Expect ", ChartSeriesType.Spline)
			Lifeexpect.Points.Add(0, 70)
			Lifeexpect.Points.Add(1, 65)
			Lifeexpect.Points.Add(2, 85)
			Lifeexpect.Points.Add(3, 65)
            Lifeexpect.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.FromArgb(200, 36, 119, 51))
			Lifeexpect.Style.Border.Width = 2

			Dim Literacy As ChartSeries = New ChartSeries("Literacy[%]", ChartSeriesType.SplineArea)
			Literacy.Points.Add(0, 85)
			Literacy.Points.Add(1, 55)
			Literacy.Points.Add(2, 35)
            Literacy.Points.Add(3, 95)
            Literacy.Style.Border.Color = Color.Transparent
            Literacy.Style.Interior = New Syncfusion.Drawing.BrushInfo(Color.FromArgb(200, 253, 171, 0))

			Me.chartControl1.LegendsPlacement = ChartPlacement.Outside
			Me.chartControl1.LegendPosition = ChartDock.Top
			Me.chartControl1.LegendAlignment = ChartAlignment.Center
			Me.chartControl1.Title.Visible = False

			Dim Xaxis As ChartAxis = New ChartAxis()
			Xaxis.Orientation = ChartOrientation.Horizontal
			Xaxis.OpposedPosition = True
			Xaxis.Range = New MinMaxInfo(-1, 4, 1)
            Xaxis.DrawGrid = False
            Xaxis.LineType.Width = 1.75F
			Me.chartControl1.Axes.Add(Xaxis)

			GDP.YAxis = axis2
			GDP.XAxis = Xaxis
			Lifeexpect.YAxis = axis3
			Lifeexpect.XAxis = Xaxis

			Literacy.YAxis = axis4
			Literacy.XAxis = Xaxis

			axis2.Title = "GDP pc in 1000"
			axis3.Title = "Lifeexpect"
			axis4.Title = "Literacy"

			Me.chartControl1.Series.Add(population)
			Me.chartControl1.Series.Add(Growth)
			Me.chartControl1.Series.Add(Birthrate)
			Me.chartControl1.Series.Add(GDP)
			Me.chartControl1.Series.Add(Lifeexpect)
			Me.chartControl1.Series.Add(Literacy)

			axis1.OpposedPosition = True
			axis1.DrawGrid = False
			axis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift
			axis0.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift
			axis1.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift
			axis2.OpposedPosition = True
			axis0.DrawGrid = True
			axis.DrawGrid = False
			axis2.DrawGrid = False
			axis2.DrawGrid = True
			axis3.DrawGrid = False
			axis4.DrawGrid = False

			axis2.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift
			axis3.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift
            axis4.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift

            axis.LineType.ForeColor = Color.Blue
            axis.ForeColor = Color.Blue
            axis.TitleColor = Color.Blue
            axis.LineType.Width = 1.75F

            axis0.LineType.ForeColor = Color.DarkGreen
            axis0.ForeColor = Color.DarkGreen
            axis0.TitleColor = Color.DarkGreen
            axis0.LineType.Width = 1.75F

            axis1.LineType.ForeColor = Color.Red
            axis1.LineType.Width = 1.75F
            axis1.ForeColor = Color.Red
            axis1.TitleColor = Color.Red

            axis2.LineType.ForeColor = Color.Salmon
            axis2.ForeColor = Color.Salmon
            axis2.TitleColor = Color.Salmon
            axis2.LineType.Width = 1.75F

            axis3.LineType.ForeColor = Color.Green
            axis3.ForeColor = Color.Green
            axis3.TitleColor = Color.Green
            axis3.LineType.Width = 1.75F

            axis4.LineType.ForeColor = Color.Orange
            axis4.ForeColor = Color.Orange
            axis4.TitleColor = Color.Orange
            axis4.LineType.Width = 1.75F

		End Sub
		#End Region

		#Region "Forn_Load"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ChartControlData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub
		#End Region

	End Class
End Namespace