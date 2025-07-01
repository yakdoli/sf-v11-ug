Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms

Namespace HistogramChart
	Public Partial Class Form1
		Inherits Office2007Form
		Public Sub New()
            InitializeComponent()
			InitializeChartData()
            Me.chartControl1.ShowToolTips = True
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

		End Sub

		#Region "InitializeControlSettings"

		Private color2 As Color() = New Color() { Color.FromArgb(150, 172, 90), Color.FromArgb(197, 229, 92), Color.FromArgb(150, 172, 90) }
		Private color3 As Color() = New Color() { Color.FromArgb(223, 111, 39), Color.FromArgb(251, 169, 113), Color.FromArgb(223, 111, 39) }

		Private Sub InitializeControlSettings()

			Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
			Me.chartControl1.ChartArea.XAxesLayoutMode = ChartAxesLayoutMode.Stacking
			Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 0)
			Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(167, 213, 244)
			Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(167, 213, 244)
			Me.chartControl1.PrimaryXAxis.DrawGrid = False
			Me.chartControl1.PrimaryYAxis.DrawGrid = False
			Me.chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = True
				 Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(229))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(46))))), (CInt(Fix((CByte(166))))), (CInt(Fix((CByte(226)))))))
				Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
				Me.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Transparent
				Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.FromArgb((CInt(Fix((CByte(197))))), (CInt(Fix((CByte(229))))), (CInt(Fix((CByte(92)))))))

				Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Double
				Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Auto
				Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate

				Me.chartControl1.PrimaryYAxis.ValueType = ChartValueType.Double
				Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Auto
				Me.chartControl1.Legend.Position = ChartDock.Top
		End Sub

#End Region

		#Region "InitializeChartData"
		Protected Sub InitializeChartData()
            Dim r As Random = New Random()
            Dim points As Double() = {5.25, 7.75, 9.0, 8.275, 9.75, 7.75, 8.275, 6.25, 5.75, 5.25}

            Dim points1 As Double() = {23.0, 26.5, 27.75, 25.025, 26.5, 26.5, 28.025, 29.25, 26.75, 27.25, 26.25, 25.25, 34.5, 25.625, 25.5, 26.625, 36.275, 36.25, 26.875, 40.0}

            Dim points2 As Double() = {43.0, 46.5, 47.75, 45.025, 56.5, 56.5, 58.025, 59.25, 56.75, 57.25, 46.25, 55.25, 44.5, 45.525, 55.5, 46.625, 46.275, 56.25, 46.875, 43.0, 46.25, 55.25, 44.5, 45.425, 55.5, 56.625, 46.275, 56.25, 46.875, 43.0, 46.25, 55.25, 44.5, 45.425, 55.5, 46.625, 56.275, 46.25, 56.875, 41.0}

            Dim points3 As Double() = {63.0, 66.5, 67.75, 65.025, 66.5, 76.5, 78.025, 79.25, 76.75, 77.25, 66.25, 75.25, 74.5, 65.625, 75.5, 76.625, 76.275, 66.25, 66.875, 80.0}

            Dim points4 As Double() = {85.25, 87.75, 89.0, 88.275, 89.75, 97.75, 98.275, 96.25, 95.75, 95.25}


            For i As Integer = 1 To 1
                Dim Histogram As ChartSeries = New ChartSeries("Students Result", ChartSeriesType.Histogram)
                For j As Integer = 0 To 9
                    Histogram.Points.Add(points(j), 10)
                Next j

                For j As Integer = 0 To 19
                    Histogram.Points.Add(points1(j), 10)
                Next j

                For j As Integer = 0 To 39
                    Histogram.Points.Add(points2(j), 10)
                Next j

                For j As Integer = 0 To 19
                    Histogram.Points.Add(points3(j), 10)
                Next j

                For j As Integer = 0 To 9
                    Histogram.Points.Add(points4(j), 10)
                Next j
                Histogram.Text = Histogram.Name
                Histogram.ConfigItems.HistogramItem.NumberOfIntervals = 5
                Histogram.ConfigItems.HistogramItem.ShowNormalDistribution = True
                Me.chartControl1.Series.Add(Histogram)
            Next i
            Me.chartControl1.DropSeriesPoints = True
            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 100, 10)

            Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(0, 50, 10)
		End Sub

		#End Region

#Region "Events"
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
            Me.chartControl1.Series3D = Me.checkBox1.Checked
        End Sub

        Private Sub chartControl1_ChartRegionMouseMove(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseMove
            If (e.Region.IsChartPoint) Then
                e.Region.ToolTip = e.Region.ToolTip.ToString()
            End If
        End Sub
#End Region
    End Class
End Namespace