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
		Private lastTime As DateTime = DateTime.Now
		Private xAxisLabelModel As ChartDataBindAxisLabelModel = Nothing
		Private dataGrid1 As System.Windows.Forms.DataGrid
		Private panel2 As Panel
		Private components As System.ComponentModel.Container = Nothing
		#End Region

		#Region "Form's Constructor, Main And Dispose"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
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
            Me.chartControl1.Legend.Location = New System.Drawing.Point(93, 239)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(7, 7)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 6, 1)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.Size = New System.Drawing.Size(441, 351)
            Me.chartControl1.Spacing = 20.0!
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
            Me.dataGrid1.Size = New System.Drawing.Size(226, 105)
            Me.dataGrid1.TabIndex = 1
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.Transparent
            Me.panel2.BackgroundImage = CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image)
            Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.panel2.Controls.Add(Me.dataGrid1)
            Me.panel2.Location = New System.Drawing.Point(268, 329)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(267, 144)
            Me.panel2.TabIndex = 9
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(542, 483)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Data From Database"
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
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
		''' Initializes chart data from access database.
		''' </summary>
		Protected Sub InitializeChartData()
			' The Access database
            Dim fileName As String = WinFormsUtils.FindFile("..\..\..\..\..\..\..\Common\Data\", "ChartData.mdb")
			Dim myConnectionString As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & fileName

			' Define the database query    
			Dim mySelectQuery As String = "SELECT City, ID, Population FROM Demographics"

			' Create a database connection object using the connection string    
			Dim myConnection As OleDbConnection = New OleDbConnection(myConnectionString)

			' Create a database command on the connection using query    
			Dim myCommand As OleDbCommand = New OleDbCommand(mySelectQuery,myConnection)

			myCommand.Connection.Open()

			' Create a database reader    
			Dim myReader As OleDbDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

			'Load the contents into a dataset.
			Dim dataSet As DataSet = ConvertToDataSet(myReader,"Demographics")

			'Bind the dataset with the datagrid to display the chart data.
			Me.dataGrid1.SetDataBinding(dataSet,"Demographics")

			'Initializes new chart series.
			Dim series As ChartSeries = New ChartSeries()
			series.Name = "Products"

			Dim model As ChartDataBindModel = New ChartDataBindModel(dataSet,"Demographics")
			model.XName = "ID"
			model.YNames = New String(){"Population"}

			series.SeriesModel = model

			Me.xAxisLabelModel = New ChartDataBindAxisLabelModel(dataSet,"Demographics")
			Me.xAxisLabelModel.LabelName = "City"


			'Adds the series to the ChartSeriesCollection.
			Me.chartControl1.Series.Add(series)

			'this.chartControl1.PrimaryXAxis.AutoValueType = false;
			Me.chartControl1.PrimaryXAxis.LabelsImpl = Me.xAxisLabelModel

            Me.xAxisLabelModel.PositionIndex = 1
            Me.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode

			'Specifies the mode of displaying the label of the x-axis on intersection.
			Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows

			'Specifies the column width mode for the Column Type chart.
			Me.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode

			' Close the reader and the connection
			myReader.Close()
            myConnection.Close()

            'Turns off the legend.
            Me.chartControl1.Legend.Visible = False

            Me.dataGrid1.ReadOnly = True
            Me.dataGrid1.CaptionVisible = False
            Me.dataGrid1.PreferredColumnWidth = 55
            Me.dataGrid1.PreferredRowHeight = 7
            Me.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(229, 234, 241)
            Me.dataGrid1.BackColor = System.Drawing.Color.FromArgb(239, 239, 239)
            Me.dataGrid1.BorderStyle = BorderStyle.None
            Me.dataGrid1.RowHeadersVisible = False
            Me.chartControl1.Text = "Highest populated cities in the world"

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

		#Region "InitializeControlSettings"
		Private Sub InitializeControlSettings()
			Me.chartControl1.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))

            Dim color As Color() = New Color() {System.Drawing.Color.FromArgb(117, 142, 172), System.Drawing.Color.FromArgb(205, 217, 231), System.Drawing.Color.FromArgb(117, 142, 172)}
			Me.chartControl1.Series(0).Style.Interior = New BrushInfo(GradientStyle.Horizontal, color)
            Me.chartControl1.Series(0).Style.Border.Color = System.Drawing.Color.FromArgb(112, 143, 171)

            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent)

			Me.chartControl1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit

			Me.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.Transparent
			Me.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(160, 178, 201)
			Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(112, 143, 171)
			Me.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.Transparent
			Me.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(160, 178, 201)
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(112, 143, 171)
        End Sub
#End Region
#End Region
    End Class
End Namespace