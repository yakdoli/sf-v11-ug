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


Imports Microsoft.VisualBasic
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
        Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private lastTime As DateTime = DateTime.Now
        Private chartControl2 As ChartControl
        Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private label40 As Label
        Private label6 As Label
        Private panel1 As Panel
        Private stripLineColor As Color() = New Color() {Color.White, Color.Olive, Color.Olive}
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form's Constructor, Main And Dispose"
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl()
            Me.chartControl2 = New Syncfusion.Windows.Forms.Chart.ChartControl()
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
            Me.label40 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.panel1 = New System.Windows.Forms.Panel()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.Transparent)
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 4, 20, 1)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Top
            ' 
            ' 
            ' 
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.Location = New System.Drawing.Point(256, 55)
            Me.chartControl1.Legend.Margin = New System.Windows.Forms.Padding(1)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(76))))), (CInt(Fix((CByte(180))))), (CInt(Fix((CByte(233))))))
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(28))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(194))))))
            Me.chartControl1.PrimaryXAxis.OriginDate = New System.DateTime(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.Transparent
            Me.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(76))))), (CInt(Fix((CByte(180))))), (CInt(Fix((CByte(233))))))
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(28))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(194))))))
            Me.chartControl1.PrimaryYAxis.OriginDate = New System.DateTime(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.Transparent
            Me.chartControl1.Size = New System.Drawing.Size(589, 222)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "High Level Chart"
            ' 
            ' 
            ' 
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
            Me.chartControl1.Title.Margin = 1
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "High Level Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '			Me.chartControl1.VisibleRangeChanged += New System.EventHandler(Me.chartControl1_VisibleRangeChanged);
            ' 
            ' chartControl2
            ' 
            Me.chartControl2.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.Transparent)
            Me.chartControl2.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed
            Me.chartControl2.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl2.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 4, 10, 1)
            Me.chartControl2.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl2.Dock = System.Windows.Forms.DockStyle.Bottom
            ' 
            ' 
            ' 
            Me.chartControl2.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl2.Legend.Location = New System.Drawing.Point(256, 55)
            Me.chartControl2.Legend.Margin = New System.Windows.Forms.Padding(1)
            Me.chartControl2.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl2.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl2.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl2.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside
            Me.chartControl2.Location = New System.Drawing.Point(0, 233)
            Me.chartControl2.Name = "chartControl2"
            Me.chartControl2.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl2.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(76))))), (CInt(Fix((CByte(180))))), (CInt(Fix((CByte(233))))))
            Me.chartControl2.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(28))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(194))))))
            Me.chartControl2.PrimaryXAxis.OriginDate = New System.DateTime(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl2.PrimaryXAxis.TickColor = System.Drawing.Color.Transparent
            Me.chartControl2.PrimaryYAxis.ForceZero = True
            Me.chartControl2.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl2.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(76))))), (CInt(Fix((CByte(180))))), (CInt(Fix((CByte(233))))))
            Me.chartControl2.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(28))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(194))))))
            Me.chartControl2.PrimaryYAxis.OriginDate = New System.DateTime(1899, 12, 30, 0, 0, 0, 0)
            Me.chartControl2.PrimaryYAxis.TickColor = System.Drawing.Color.Transparent
            Me.chartControl2.Size = New System.Drawing.Size(589, 227)
            Me.chartControl2.TabIndex = 3
            Me.chartControl2.Text = "Low Level Chart"
            ' 
            ' 
            ' 
            Me.chartControl2.Title.Font = New System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
            Me.chartControl2.Title.Margin = 1
            Me.chartControl2.Title.Name = "Default"
            Me.chartControl2.Title.Text = "Low Level Chart"
            Me.chartControl2.Titles.Add(Me.chartControl2.Title)
            ' 
            ' gradientPanel2
            ' 
            Me.gradientPanel2.BackColor = System.Drawing.Color.White
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(141))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(227))))))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel2.Controls.Add(Me.label40)
            Me.gradientPanel2.Controls.Add(Me.label6)
            Me.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gradientPanel2.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.gradientPanel2.Location = New System.Drawing.Point(0, 488)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(641, 160)
            Me.gradientPanel2.TabIndex = 7
            ' 
            ' label40
            ' 
            Me.label40.BackColor = System.Drawing.Color.Transparent
            Me.label40.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label40.Location = New System.Drawing.Point(0, 45)
            Me.label40.Name = "label40"
            Me.label40.Size = New System.Drawing.Size(641, 115)
            Me.label40.TabIndex = 1
            Me.label40.Text = resources.GetString("label40.Text")
            ' 
            ' label6
            ' 
            Me.label6.Dock = System.Windows.Forms.DockStyle.Top
            Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label6.Image = (CType(resources.GetObject("label6.Image"), System.Drawing.Image))
            Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label6.Location = New System.Drawing.Point(0, 0)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(641, 45)
            Me.label6.TabIndex = 5
            Me.label6.Text = "               Sample Description"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' panel1
            ' 
            Me.panel1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.panel1.Controls.Add(Me.chartControl1)
            Me.panel1.Controls.Add(Me.chartControl2)
            Me.panel1.Location = New System.Drawing.Point(23, 14)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(589, 460)
            Me.panel1.TabIndex = 8
            ' 
            ' Form1
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(641, 648)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.gradientPanel2)
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Huge Data in Multi-Chart"
            '			Me.Load += New System.EventHandler(Me.Form1_Load);
            '			Me.SizeChanged += New System.EventHandler(Me.Form1_SizeChanged);
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            ChartAppearance.ApplyChartStyles(Me.chartControl2)
        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        ''' <summary>
        ''' Initializes chart data from access database.
        ''' </summary>
        Protected Sub InitializeChartData()
            Dim yMax As Integer = 100
            Dim totalXValues As Integer = 100000
            Dim tableSource As DataTable = Me.CreateLargeTable(totalXValues, yMax)

            ' "MASTERCHART"
            'Sets the value type and of the axes. Setting this ensures that the ranges stay consistent as you zoom into the chart.
            ' Master Chart
            Me.SetChartRange(Me.chartControl1.PrimaryXAxis, New MinMaxInfo(0, totalXValues, totalXValues \ 10))
            Me.SetChartRange(Me.chartControl1.PrimaryYAxis, New MinMaxInfo(0, yMax, yMax \ 10))

            'Initializes new chart series.
            Dim series As ChartSeries = New ChartSeries()
            series.Name = "Population"
            series.Type = ChartSeriesType.Spline

            ' Model that "dilutes" the large set of data points based on the current chart width. Instead of just skipping
            ' points, this model uses an average of a set of points.
            Dim model As ChartOversizedDataBindModel = New ChartOversizedDataBindModel(Me.chartControl1, tableSource, "X", "Y", False)
            ' Assign this data model to the new series.
            series.SeriesModel = model
            AddHandler model.DilutionFactorChanged, AddressOf model_DilutionFactorChanged
            'Adds the series to the ChartSeriesCollection.
            Me.chartControl1.Series.Add(series)

            SetStripLine(0, 10000)

            ' "DETAILCHART"
            ' Detail Chart
            Me.SetChartRange(Me.chartControl2.PrimaryXAxis, New MinMaxInfo(0, totalXValues \ 10, totalXValues \ 100))
            Me.SetChartRange(Me.chartControl2.PrimaryYAxis, New MinMaxInfo(0, yMax, yMax \ 10))

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Name = "Population"
            series2.Type = ChartSeriesType.Spline

            Dim model2 As ChartOversizedDataBindModel = New ChartOversizedDataBindModel(Me.chartControl2, tableSource, "X", "Y")
            ' Assign this data model to the new series.
            series2.SeriesModel = model2
            AddHandler model2.DilutionFactorChanged, AddressOf model_DilutionFactorChanged
            Me.chartControl2.Series.Add(series2)
            Me.UpdateChartSubTitles()
        End Sub
#End Region

#Region "SetChartRange"
        Private Sub SetChartRange(ByVal axis As ChartAxis, ByVal range As MinMaxInfo)
            axis.ValueType = ChartValueType.Double
            axis.RangeType = ChartAxisRangeType.Set
            axis.Range = range
        End Sub
#End Region

#Region "CreateLargeTable"
        Private Function CreateLargeTable(ByVal totalXValues As Integer, ByVal yMax As Integer) As DataTable
            Dim table As DataTable = New DataTable()
            ' It's important that the x values are marked as integer, otherwise, the engine will treat it as strings and
            ' sort them incorrectly.
            Dim x As DataColumn = New DataColumn("X", GetType(Int32))
            table.Columns.Add(x)
            table.Columns.Add(New DataColumn("Y"))

            Dim ran As Random = New Random(DateTime.Now.Second)

            For i As Integer = 0 To totalXValues - 1
                Dim xVal As Integer = i
                Dim yVal As Double = (CDbl(xVal) / totalXValues) * yMax + ran.Next(-20, 20)
                Dim row As DataRow = table.NewRow()

                row(0) = xVal
                row(1) = yVal

                table.Rows.Add(row)
            Next i
            Return table
        End Function
#End Region

#Region "SetStripLine"
        Protected Sub SetStripLine(ByVal start As Double, ByVal [end] As Double)
            'Chart Strip Lines
            If Me.chartControl1.PrimaryXAxis.StripLines.Count >= 0 Then
                Me.chartControl1.PrimaryXAxis.StripLines.Clear()
            End If
            Dim stripLine As ChartStripLine = New ChartStripLine()
            stripLine.Enabled = True
            stripLine.Vertical = False
            stripLine.Start = start
            stripLine.End = [end]
            stripLine.Text = " "
            stripLine.Width = 250
            stripLine.Period = 1
            stripLine.Interior = New BrushInfo(GradientStyle.Horizontal, stripLineColor)
            Me.chartControl1.PrimaryXAxis.StripLines.Add(stripLine)
        End Sub
#End Region

#Region "UpdateChartSubTitles"
        Private Sub UpdateChartSubTitles()
            Me.chartControl1.Title.Text = "High Level Chart - Compression Ratio " & (CType(Me.chartControl1.Series(0).SeriesModel, ChartOversizedDataBindModel)).DilutionFactor.ToString() & " : 1"

            Me.chartControl2.Title.Text = "Low Level Chart - Compression Ratio " & (CType(Me.chartControl2.Series(0).SeriesModel, ChartOversizedDataBindModel)).DilutionFactor.ToString() & " : 1"
        End Sub
#End Region
#End Region

#Region "Events"
        Private Sub chartControl1_VisibleRangeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chartControl1.VisibleRangeChanged
            ' Called when the user is done selecting an area in the master chart
            If Me.chartControl1.ZoomFactorX <> 1 Then
                Dim x1 As Double = Me.chartControl1.ZoomPositionX * Me.chartControl1.PrimaryXAxis.Range.Max
                Dim x2 As Double = x1 + (Me.chartControl1.ZoomFactorX * Me.chartControl1.PrimaryXAxis.Range.Max)

                Me.SetChartRange(Me.chartControl2.PrimaryXAxis, New MinMaxInfo(x1, x2, (x2 - x1) / 10))

                CType(Me.chartControl2.Series(0).SeriesModel, ChartOversizedDataBindModel).Recaliberate()

                SetStripLine(x1, x2)
            End If
            ' Resetting it to 1 to cancel zooming
            If Me.chartControl1.ZoomFactorX <> 1 Then
                Me.chartControl1.ZoomFactorX = 1
            End If

            If Me.chartControl1.ZoomFactorY <> 1 Then
                Me.chartControl1.ZoomFactorY = 1
            End If
        End Sub

        Private Sub model_DilutionFactorChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.UpdateChartSubTitles()
        End Sub
        Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.SizeChanged
            Dim height As Integer = CInt(Me.panel1.Height / 2)
            Me.chartControl1.Height = height - 10
            Me.chartControl2.Height = height - 10
        End Sub
#End Region
    End Class
End Namespace
