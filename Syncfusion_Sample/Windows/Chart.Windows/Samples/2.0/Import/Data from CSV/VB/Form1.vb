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
#Region "private Members"
        Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
        Private tableName As String = "Products"
        Private model As ChartDataBindModel
        Private panel2 As Panel
        Private dataGrid1 As DataGrid
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Form's Constructor, Main And Dispose"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
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
            Me.panel2 = New System.Windows.Forms.Panel
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.panel2.SuspendLayout()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(173, Byte), Integer))
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Pinned
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(93, 248)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(12, 12)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(201, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.Transparent
            Me.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(201, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(171, Byte), Integer))
            Me.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.Transparent
            Me.chartControl1.Size = New System.Drawing.Size(424, 360)
            Me.chartControl1.TabIndex = 1
            Me.chartControl1.Text = "Chart Data From CSV"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Chart Data From CSV"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.Transparent
            Me.panel2.BackgroundImage = CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image)
            Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.panel2.Controls.Add(Me.dataGrid1)
            Me.panel2.Location = New System.Drawing.Point(372, 303)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(226, 183)
            Me.panel2.TabIndex = 8
            '
            'dataGrid1
            '
            Me.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderForeColor = System.Drawing.Color.Black
            Me.dataGrid1.LinkColor = System.Drawing.Color.Black
            Me.dataGrid1.Location = New System.Drawing.Point(20, 19)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.Size = New System.Drawing.Size(190, 146)
            Me.dataGrid1.TabIndex = 2
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(610, 497)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Data from CSV"
            Me.panel2.ResumeLayout(False)
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Form Load"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            InitializeChartFromCSV()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
        End Sub
#End Region

#Region "Helper Methods"

#Region "InitializeChartData"
        ''' <summary>
        ''' Imports chart data from a CSV file.
        ''' </summary>
        Protected Sub InitializeChartFromCSV()
            Dim fileName As String = WinFormsUtils.FindFile("..\..\..\..\..\..\..\Common\Data\", "ChartData.csv")

            Dim csvConn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & ";Extended Properties=""Text;HDR=Yes;FMT=Delimited""")
            csvConn.Open()

            'Query for retriving the data from the csv file.
            Dim query As String = "Select * From " & fileName

            Dim csvCommand As OleDbCommand = New OleDbCommand(query, csvConn)

            Dim csvReader As OleDbDataReader = csvCommand.ExecuteReader(CommandBehavior.CloseConnection)

            'Load the contents to a dataset.
            Dim csvDataSet As DataSet = ConvertToDataSet(csvReader, "CSVTable")

            'Bind the dataset with the datagrid to display the chart data.
            Me.dataGrid1.SetDataBinding(csvDataSet, "CSVTable")

            Me.chartControl1.Indexed = True

            'Initializes new chart series.
            Dim series As ChartSeries = New ChartSeries()
            series.Name = tableName

            model = New ChartDataBindModel(csvDataSet, "CSVTable")
            model.XName = "X Value"
            model.YNames = New String() {"Y Value"}

            series.SeriesModel = model

            'Adds the series to the ChartSeriesCollection.
            Me.chartControl1.Series.Add(series)

            '//Specifies the column width mode for the Column Type chart.
            Me.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode

            'Close the connection.
            csvReader.Close()
            csvConn.Close()
        End Sub

#End Region
#End Region

#Region "ConvertToDataSet"
        ''' <summary>
        ''' Converts DataReader to DataSet.
        ''' </summary>
        ''' <param name="myReader"></param>
        ''' <param name="tableName"></param>
        ''' <returns></returns>
        Protected Function ConvertToDataSet(ByVal dataReader As OleDbDataReader, ByVal tableName As String) As DataSet
            Dim dataSet As DataSet = New DataSet()
            Do
                ' Create new data table

                Dim schemaTable As DataTable = dataReader.GetSchemaTable()
                Dim dataTable As DataTable = New DataTable(tableName)

                If Not schemaTable Is Nothing Then
                    ' A query returning records was executed

                    For i As Integer = 0 To schemaTable.Rows.Count - 1
                        Dim dataRow As DataRow = schemaTable.Rows(i)
                        ' Create a column name that is unique in the data table
                        Dim columnName As String = CStr(dataRow("ColumnName")) '+ "<C" + i + "/>";
                        ' Add the column definition to the data table
                        Dim column As DataColumn = New DataColumn(columnName, CType(dataRow("DataType"), Type))

                        dataTable.Columns.Add(column)
                    Next i

                    'Add the data table to the dataset.
                    dataSet.Tables.Add(dataTable)

                    ' Fill the data table.
                    Do While dataReader.Read()
                        Dim dataRow As DataRow = dataTable.NewRow()

                        For i As Integer = 0 To dataReader.FieldCount - 1
                            dataRow(i) = dataReader.GetValue(i)
                        Next i

                        dataTable.Rows.Add(dataRow)
                    Loop
                Else
                    ' No records were returned.

                    Dim column As DataColumn = New DataColumn("RowsAffected")
                    dataTable.Columns.Add(column)
                    dataSet.Tables.Add(dataTable)
                    Dim dataRow As DataRow = dataTable.NewRow()
                    dataRow(0) = dataReader.RecordsAffected
                    dataTable.Rows.Add(dataRow)
                End If
            Loop While dataReader.NextResult()
            Return dataSet
        End Function
#End Region

    End Class
End Namespace
