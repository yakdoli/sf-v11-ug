Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping

'INSTANT VB NOTE: VB does not allow aliasing interfaces:
'using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary

Namespace CustomSectionInGroup
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private northwindDataSet1 As StackedHeaders.DataSet1
		Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlDataAdapterOrders As System.Data.SqlClient.SqlDataAdapter
		Private sqlConnection2 As System.Data.SqlClient.SqlConnection
		Private propertyGrid1 As PropertyGrid

		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			' GroupingEngineFactory provides a modified GridChildTable that adds an extra section
			'GridEngineFactory.Factory = new GroupingEngineFactory();

			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			'
			' TODO: Add any constructor code after InitializeComponent call
			'

			InitializeDataSet()

			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
		End Sub

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo
		End Sub

		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
			If e.Style.CellValueType Is GetType(DateTime) Then
				e.Style.Format = "MM/dd/yyyy"
			End If
		End Sub

		Private xmlName As String = "Common\Data\Orders.xml"
		Private msdeAvailable As Boolean = False

		Private Sub InitializeDataSet()
			If msdeAvailable Then
				' Initialize the data set

				Me.northwindDataSet1.BeginInit()

				' Order is important here - first fill tables that are referenced with 
				' foreign keys, then tables that have references to others.

				Me.sqlDataAdapterOrders.Fill(Me.northwindDataSet1)

				Me.northwindDataSet1.EndInit()

				Me.northwindDataSet1.WriteXml(xmlName)
			Else
				' Read from a xml file instead. 
				If Not ReadXml(Me.northwindDataSet1, xmlName) Then
					' If no xml found, try again with MSDE
					msdeAvailable = True
					InitializeDataSet()
				End If
			End If

		End Sub

		Private Function ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String) As Boolean
			' Check both in parent folder and Parent\Data folders.
			Dim xmlDataFileName As String = "Common\Data\" & xmlFileName
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Return True
				End If
				If System.IO.File.Exists(xmlDataFileName) Then
					ds.ReadXml(xmlDataFileName)
					Return True
				End If
				xmlFileName = "..\" & xmlFileName
				xmlDataFileName = "..\" & xmlDataFileName
			Next n

			Return False
		End Function


		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim GridStackedHeaderRowDescriptor1 As Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor
            Dim GridStackedHeaderDescriptor1 As Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor
            Dim GridStackedHeaderDescriptor2 As Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor
            Dim GridStackedHeaderDescriptor3 As Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor
            Dim GridStackedHeaderDescriptor4 As Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
            Me.sqlConnection2 = New System.Data.SqlClient.SqlConnection
            Me.sqlDataAdapterOrders = New System.Data.SqlClient.SqlDataAdapter
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.northwindDataSet1 = New StackedHeaders.DataSet1
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'sqlSelectCommand2
            '
            Me.sqlSelectCommand2.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" & _
                "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" & _
                "Country FROM Orders"
            Me.sqlSelectCommand2.Connection = Me.sqlConnection2
            '
            'sqlConnection2
            '
            Me.sqlConnection2.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & _
                "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
            Me.sqlConnection2.FireInfoMessageEventOnUserErrors = False
            '
            'sqlDataAdapterOrders
            '
            Me.sqlDataAdapterOrders.SelectCommand = Me.sqlSelectCommand2
            Me.sqlDataAdapterOrders.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(679, 2)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
            Me.propertyGrid1.Size = New System.Drawing.Size(272, 444)
            Me.propertyGrid1.TabIndex = 11
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
            Me.gridGroupingControl1.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)))
            Me.gridGroupingControl1.Appearance.StackedHeaderCell.Themed = False
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.ChildGroupOptions.ShowColumnHeaders = True
            Me.gridGroupingControl1.ChildGroupOptions.ShowStackedHeaders = True
            Me.gridGroupingControl1.DataSource = Me.northwindDataSet1.Orders
            Me.gridGroupingControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(9, 2)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.ShowGroupDropArea = True
            Me.gridGroupingControl1.Size = New System.Drawing.Size(655, 444)
            Me.gridGroupingControl1.TabIndex = 0
            Me.gridGroupingControl1.TableDescriptor.AllowNew = False
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
            Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
            Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
            Me.gridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("OrderID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("CustomerID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("EmployeeID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("OrderDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("RequiredDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShippedDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipVia"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Freight"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipName"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipAddress"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipCity"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipRegion"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipPostalCode"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipCountry")})
            Me.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("OrderID", System.ComponentModel.ListSortDirection.Ascending)})
            GridStackedHeaderRowDescriptor1.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)))
            GridStackedHeaderDescriptor1.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer)))
            GridStackedHeaderDescriptor1.Appearance.StackedHeaderCell.TextColor = System.Drawing.Color.Black
            GridStackedHeaderDescriptor1.HeaderText = "Header One"
            GridStackedHeaderDescriptor1.Name = "StackedHeader 1"
            GridStackedHeaderDescriptor1.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("CustomerID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("EmployeeID")})
            GridStackedHeaderDescriptor2.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer)))
            GridStackedHeaderDescriptor2.HeaderText = "Header Two"
            GridStackedHeaderDescriptor2.Name = "StackedHeader 2"
            GridStackedHeaderDescriptor2.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Freight"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("RequiredDate")})
            GridStackedHeaderDescriptor3.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)))
            GridStackedHeaderDescriptor3.HeaderText = "Header Three"
            GridStackedHeaderDescriptor3.Name = "StackedHeader 3"
            GridStackedHeaderDescriptor3.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShippedDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipVia"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipName")})
            GridStackedHeaderDescriptor4.Appearance.StackedHeaderCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)))
            GridStackedHeaderDescriptor4.HeaderText = "Header Four"
            GridStackedHeaderDescriptor4.Name = "StackedHeader 4"
            GridStackedHeaderDescriptor4.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipAddress"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipCity"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipRegion"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipPostalCode"), New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipCountry")})
            GridStackedHeaderRowDescriptor1.Headers.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor() {GridStackedHeaderDescriptor1, GridStackedHeaderDescriptor2, GridStackedHeaderDescriptor3, GridStackedHeaderDescriptor4})
            GridStackedHeaderRowDescriptor1.Name = "Row 1"
            Me.gridGroupingControl1.TableDescriptor.StackedHeaderRows.Add(GridStackedHeaderRowDescriptor1)
            Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryRowDescriptor("SummaryRow 1", New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor("FreightAverage", Syncfusion.Grouping.SummaryType.DoubleAggregate, "Freight", "{Average:###.00}")}))
            Me.gridGroupingControl1.TableDescriptor.SummaryRows.Add(New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryRowDescriptor("SummaryRow 2", "Total", New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor("FreightTotal", Syncfusion.Grouping.SummaryType.DoubleAggregate, "Freight", "{Sum:###.00}")}))
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
            Me.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("OrderID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("CustomerID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("EmployeeID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("OrderDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Freight"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("RequiredDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShippedDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipVia"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipName"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipAddress"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipCity"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipRegion"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipPostalCode"), New Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipCountry")})
            Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer)))
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
            '
            'northwindDataSet1
            '
            Me.northwindDataSet1.DataSetName = "DataSet1"
            Me.northwindDataSet1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(962, 454)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Stacked Headers Demo"
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
			For j As Integer = 0 To Me.gridGroupingControl1.TableDescriptor.StackedHeaderRows("Row1").Headers.Count - 1
				Console.WriteLine(Me.gridGroupingControl1.TableDescriptor.StackedHeaderRows("Row1").Headers(j).Name)

			Next j
		End Sub

	End Class



End Namespace