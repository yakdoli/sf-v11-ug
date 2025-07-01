#Region "Copyright Syncfusion Inc. 2001 - 2005"
'
'  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
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
        Inherits Syncfusion.Windows.Forms.Office2007Form
#Region "Private Members"
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private tableName As String = "Products"
        Private xAxisLabelModel As ChartDataBindAxisLabelModel = Nothing
        Private model As ChartDataBindModel
        Private dataGrid1 As System.Windows.Forms.DataGrid
        Private panel2 As Panel
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
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.panel2 = New System.Windows.Forms.Panel
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(173, Byte), Integer))
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Pinned
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(93, 264)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(7, 7)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.Size = New System.Drawing.Size(481, 376)
            Me.chartControl1.Spacing = 50.0!
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "Essential Chart"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Essential Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'dataGrid1
            '
            Me.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderForeColor = System.Drawing.Color.MidnightBlue
            Me.dataGrid1.Location = New System.Drawing.Point(17, 15)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.Size = New System.Drawing.Size(112, 106)
            Me.dataGrid1.TabIndex = 1
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.Transparent
            Me.panel2.BackgroundImage = CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image)
            Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.panel2.Controls.Add(Me.dataGrid1)
            Me.panel2.Location = New System.Drawing.Point(404, 271)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(144, 134)
            Me.panel2.TabIndex = 9
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(554, 414)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Data from an Indexed Model"
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeSeriesIndexedData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            'Updates the datagrid.
            FillDataset(Me.chartControl1.Series(0))

        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeSeriesIndexedData"
        ''' <summary>
        ''' Initializes chart data using SeriesIndexed model.
        ''' </summary>
        Protected Sub InitializeSeriesIndexedData()
            Me.chartControl1.Indexed = True
            'Initializes new chart series.
            Dim series As ChartSeries = New ChartSeries()
            series.SeriesIndexedModelImpl = New StringIndexedModel(series, New Double() {68, 49, 72, 51, 63})
            'Adds the series to the ChartSeriesCollection.
            Me.chartControl1.Series.Add(series)
            'Specifies the column width mode for the Column Type chart.
            Me.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode
            Me.dataGrid1.ReadOnly = True
            Me.dataGrid1.CaptionVisible = False
            Me.dataGrid1.PreferredColumnWidth = 55
            Me.dataGrid1.PreferredRowHeight = 7
            Me.dataGrid1.HeaderBackColor = Color.FromArgb(229, 234, 241)
            Me.dataGrid1.BackColor = Color.FromArgb(239, 239, 239)
            Me.dataGrid1.BorderStyle = BorderStyle.None
            Me.dataGrid1.RowHeadersVisible = False
        End Sub
#End Region

#Region "FillDataset"
        ''' <summary>
        ''' Fills the dataset with the chart series.
        ''' </summary>
        ''' <param name="serie"></param>
        Protected Sub FillDataset(ByVal serie As ChartSeries)
            'Creates data table
            Dim dt As DataTable = New DataTable("Data Table")

            'Initializes and adds the datarow to the table.
            Dim dr As DataRow
            For i As Integer = 0 To serie.Points.Count - 1
                dr = dt.NewRow()
                dt.Rows.Add(dr)
            Next i

            'Initializes and adds the datacolumn to the table.
            Dim XValue As DataColumn = dt.Columns.Add("X Value", GetType(String))
            Dim YValue As DataColumn = dt.Columns.Add("Y Value", GetType(Integer))

            'Populate the datatable with the series points.
            For i As Integer = 0 To serie.Points.Count - 1
                dt.Rows(i)("X Value") = serie.Points(i).X
                dt.Rows(i)("Y Value") = serie.Points(i).YValues(0)
            Next i

            'Creates a new dataset.
            Dim arrayDataSet As DataSet = New DataSet("Data DataSet")

            'Add the populated datatable to the dataset.
            arrayDataSet.Tables.Add(dt)

            'Bind the dataset with the datagrid to display the chart data.
            Me.dataGrid1.SetDataBinding(arrayDataSet, "Data Table")
        End Sub
#End Region
#End Region
    End Class
End Namespace