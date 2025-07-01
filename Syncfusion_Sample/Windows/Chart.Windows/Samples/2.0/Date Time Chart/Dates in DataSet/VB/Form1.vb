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
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart

Namespace DateDataBinding
    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"
        Private prodDs1 As DataSet
        Private lastTime As DateTime = DateTime.Now
        Private chartControl1 As ChartControl
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form Constructor, Main And Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
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
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.SuspendLayout()
            '
            'chartControl1
            '
            '
            '
            '
            Me.chartControl1.Legend.Location = New System.Drawing.Point(324, 75)
            Me.chartControl1.Location = New System.Drawing.Point(12, 11)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 500, 100)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.Size = New System.Drawing.Size(433, 368)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(463, 389)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Dates in DataSet"
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            CreateDataSet()
            InitializeChart()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChart"
        Protected Sub InitializeChart()
            Dim series As ChartSeries = New ChartSeries()
            series.Name = "Products"
            series.Text = series.Name
            Dim model As ChartDataBindModel = New ChartDataBindModel(Me.prodDs1, "Products")
            model.XName = "ExpiresDate"
            model.YNames = New String() {"Quantity"}
            series.SeriesModel = model
            series.Type = ChartSeriesType.Column
            series.Style.Border.Color = Color.FromArgb(124, 83, 153)
            series.Style.DisplayShadow = False
            Me.chartControl1.Series.Add(series)
            Dim start As DateTime = Date.Now
            Dim [end] As DateTime = start.AddMonths(3)
            Me.chartControl1.PrimaryXAxis.DateTimeRange = New ChartDateTimeRange(start, [end], 1, ChartDateTimeIntervalType.Months)
        End Sub
#End Region

#Region "CreateDataSet"
        Private Sub CreateDataSet()
            Dim tableName As String = "Products"
            prodDs1 = New DataSet()
            prodDs1.Tables.Add(tableName)

            Dim ExpiresDate As DataColumn = prodDs1.Tables(tableName).Columns.Add("ExpiresDate", GetType(System.DateTime))
            Dim Quantity As DataColumn = prodDs1.Tables(tableName).Columns.Add("Quantity", GetType(Double))
            Dim rand As Random = New Random()
            If Not prodDs1 Is Nothing AndAlso prodDs1.Tables.Count > 0 Then
                For i As Integer = 0 To 9
                    Dim drEmpty As DataRow = prodDs1.Tables(tableName).NewRow()
                    prodDs1.Tables(tableName).Rows.Add(drEmpty)
                    Dim count As Integer = Math.Max(0, prodDs1.Tables(tableName).Rows.Count - 1)
                    prodDs1.Tables(tableName).Rows(count)("Quantity") = CDbl(rand.Next(10, 400))
                    prodDs1.Tables(tableName).Rows(count)("ExpiresDate") = lastTime.AddDays(10)
                    lastTime = CDate(prodDs1.Tables(tableName).Rows(count)("ExpiresDate"))
                Next i
            End If
        End Sub
#End Region
#End Region
    End Class
End Namespace
