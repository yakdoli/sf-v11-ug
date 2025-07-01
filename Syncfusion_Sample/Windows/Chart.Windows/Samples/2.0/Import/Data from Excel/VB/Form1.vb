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
		Private lastTime As DateTime = DateTime.Now
		Private tableName As String = "Products"
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
		<STAThread> _
		Shared Sub Main()
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
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.panel2 = New System.Windows.Forms.Panel
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(113, Byte), Integer), CType(CType(173, Byte), Integer))
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Pinned
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(5, 10, 5, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(88, 264)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(7, 7)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.Series3D = True
            Me.chartControl1.Size = New System.Drawing.Size(514, 376)
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
            Me.dataGrid1.Location = New System.Drawing.Point(20, 20)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.Size = New System.Drawing.Size(150, 105)
            Me.dataGrid1.TabIndex = 1
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.Transparent
            Me.panel2.BackgroundImage = CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image)
            Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.panel2.Controls.Add(Me.dataGrid1)
            Me.panel2.Location = New System.Drawing.Point(367, 268)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(190, 144)
            Me.panel2.TabIndex = 9
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(564, 422)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Data from Excel"
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Form Load"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitializeChartExcelData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub
		#End Region

		#Region "Helper Methods"
		#Region "InitializeChartExcelData"
		''' <summary>
		''' Initializes chart data from Excel Sheet.
		''' </summary>
		Protected Sub InitializeChartExcelData()
            Dim fileName As String = WinFormsUtils.FindFile("..\..\..\..\..\..\..\Common\Data\", "ChartData.xls")

			'The Oledbconnection.
			Dim excelConn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileName & ";Extended Properties=""Excel 8.0;HDR=Yes;""")
			excelConn.Open()

			'Query for retriving the data from the excel sheet.
			Dim query As String = "Select * From [Sheet1$A1:B11]"

			Dim excelCommand As OleDbCommand = New OleDbCommand(query,excelConn)

			Dim excelReader As OleDbDataReader = excelCommand.ExecuteReader(CommandBehavior.CloseConnection)

			'Load the contents to a dataset.
			Dim excelDataSet As DataSet = ConvertToDataSet(excelReader,"ExcelTable")

			'Bind the dataset with the datagrid to display the chart data.
			Me.dataGrid1.SetDataBinding(excelDataSet,"ExcelTable")

			Me.chartControl1.Indexed = True

			'Initializes new chart series.
			Dim series As ChartSeries = New ChartSeries()
			series.Name = tableName

			model = New ChartDataBindModel(excelDataSet,"ExcelTable")
			model.XName = "X Value"
			model.YNames = New String(){"Y Value"}

			series.SeriesModel = model

			'Specifies the column width mode for the Column Type chart.
			Me.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode

			'Adds the series to the ChartSeriesCollection.
			Me.chartControl1.Series.Add(series)

			'Close the connection.
			excelReader.Close()
            excelConn.Close()

            Me.dataGrid1.ReadOnly = True
            Me.dataGrid1.CaptionVisible = False
            Me.dataGrid1.PreferredColumnWidth = 63
            Me.dataGrid1.PreferredRowHeight = 7
            Me.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(229, 234, 241)
            Me.dataGrid1.BackColor = System.Drawing.Color.FromArgb(239, 239, 239)
            Me.dataGrid1.BorderStyle = BorderStyle.None
            Me.dataGrid1.RowHeadersVisible = False
		End Sub
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

		#End Region

	End Class
End Namespace