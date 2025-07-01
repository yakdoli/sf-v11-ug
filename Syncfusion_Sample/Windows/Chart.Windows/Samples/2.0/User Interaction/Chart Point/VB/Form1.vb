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

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing

Namespace ChartGetValueSample

    Public Class Form1
        Inherits Syncfusion.Windows.Forms.Office2007Form
#Region "Helper Methods"
        Private toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents chartControl1 As ChartControl
        Private components As System.ComponentModel.IContainer
#End Region

#Region "Constructor, Main and Dispose"
        Public Sub New()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Font = New System.Drawing.Font("Arial", 12.0!)
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(65, 242)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(3, 1)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 1000, 200)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.Size = New System.Drawing.Size(552, 319)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(558, 325)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Point"
            Me.ResumeLayout(False)

        End Sub
#End Region


#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Dim series1 As ChartSeries = New ChartSeries()
            series1.Points.Add(1, 36)
            series1.Points.Add(2, 61)
            series1.Points.Add(3, 52)
            series1.Points.Add(4, 27)
            series1.Points.Add(5, 11)
            series1.Points.Add(6, 24)
            series1.Points.Add(7, 25)
            series1.Points.Add(8, 47)
            series1.Points.Add(9, 52)
            series1.Points.Add(10, 76)
            series1.Type = ChartSeriesType.SplineArea
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent
            series1.Text = "Team 1"
            Me.chartControl1.Series.Add(series1)

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Points.Add(1, 56)
            series2.Points.Add(2, 84)
            series2.Points.Add(3, 72)
            series2.Points.Add(4, 47)
            series2.Points.Add(5, 31)
            series2.Points.Add(6, 54)
            series2.Points.Add(7, 35)
            series2.Points.Add(8, 67)
            series2.Points.Add(9, 82)
            series2.Points.Add(10, 98)
            series2.Type = ChartSeriesType.SplineArea
            series2.Text = "Team 2"
            Me.chartControl1.Series.Add(series2)
        End Sub
#End Region
#End Region

#Region "Events"
        Private Sub chartControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chartControl1.MouseMove
            Dim mousePoint As Point = New Point(e.X, e.Y)
            Dim chpt As ChartPoint = chartControl1.ChartArea.GetValueByPoint(New Point(e.X, e.Y))
            Dim pt As Point = chartControl1.ChartArea.GetPointByValue(chpt)

            Dim text As String = Nothing
            If Me.chartControl1.ChartArea.RenderBounds.Contains(pt) Then
                text = "Mouse point - " & mousePoint.ToString() & Constants.vbLf & "Result of method GetValueByPoint - {" & chpt.X.ToString() & "," & chpt.YValues(0).ToString() & "}" & Constants.vbLf & "Result of method GetPointByValue - " & pt.ToString()


            Else
                text = "Outside Axis Bounds"

            End If

            toolTip1.SetToolTip(chartControl1, text)
        End Sub
#End Region

    End Class
End Namespace
