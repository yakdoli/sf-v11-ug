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
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Globalization
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace Syncfusion.Windows.Forms.Chart.Samples
    Public Class FormMain
        Inherits Office2007Form
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl

        Private components As System.ComponentModel.Container = Nothing

#Region "Form Constructor, Main And Dispose"
        Public Sub New()
            InitializeComponent()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New FormMain())
        End Sub

        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(0, 5, 5, 0)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            Me.chartControl1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(441, 70)
            Me.chartControl1.Location = New System.Drawing.Point(11, 11)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.Size = New System.Drawing.Size(557, 341)
            Me.chartControl1.TabIndex = 2
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'FormMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(582, 362)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Date Time Axes in Chart"
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes the ChartControl's data and sets the Chart type
        ''' </summary>
        Protected Sub InitializeChartData()
            Me.chartControl1.Indexed = False
            Me.chartControl1.LegendPosition = ChartDock.Top

            ' fill the series with random date data
            Dim random As Random = New Random()
            Dim start As DateTime = New DateTime(2008, 12, 1)
            Dim rand As DateTime = DateTime.Now
            Dim dtInfo As DateTimeFormatInfo = New DateTimeFormatInfo()

            Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "Night Shift"
            series1.Type = ChartSeriesType.Column
            series1.Text = series1.Name

            series1.Points.Add(start.AddMonths(1), 363)
            series1.Points.Add(start.AddMonths(2), 417)
            series1.Points.Add(start.AddMonths(3), 563)
            series1.Points.Add(start.AddMonths(4), 453)
            series1.Points.Add(start.AddMonths(5), 478)

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Name = "Day Shift"
            series2.Type = ChartSeriesType.Column
            series2.Text = series2.Name

            series2.Points.Add(start.AddMonths(1), 300)
            series2.Points.Add(start.AddMonths(2), 356)
            series2.Points.Add(start.AddMonths(3), 484)
            series2.Points.Add(start.AddMonths(4), 397)
            series2.Points.Add(start.AddMonths(5), 412)
            Me.chartControl1.Series.Add(series1)
            Me.chartControl1.Series.Add(series2)

            Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
            Me.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime
            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(start, start.AddMonths(6), 1, ChartDateTimeIntervalType.Months)
        End Sub
#End Region
#End Region

    End Class
End Namespace
