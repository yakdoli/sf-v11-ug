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

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms

Namespace SummaryInCaption
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
		Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
		Private northwindDataSet1 As SummaryInCaption.DataSet1
		Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlInsertCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
		Private sqlDataAdapterOrders As System.Data.SqlClient.SqlDataAdapter
		Private sqlConnection2 As System.Data.SqlClient.SqlConnection
		Private propertyGrid1 As PropertyGrid
		Private panel2 As Panel

		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			InitializeDataSet()

			Dim ordersDescriptor As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor

			' You can define a summary row and mark it hidden.
			' In that summary row you can add a column and set it's mapping name (and DisplayColumn) to be Freight
			Dim summaryColumn1 As New GridSummaryColumnDescriptor("FreightAverage", SummaryType.DoubleAggregate, "Freight", "{Average:###.00}")
			Dim summaryRow1 As New GridSummaryRowDescriptor()
			summaryRow1.Name = "Caption"
			summaryRow1.Visible = False
			summaryRow1.SummaryColumns.Add(summaryColumn1)
			ordersDescriptor.SummaryRows.Add(summaryRow1)

			' This is a second row, not marked hidden and therefore shown at the end of the group.
			Dim summaryColumn2 As New GridSummaryColumnDescriptor("FreightTotal", SummaryType.DoubleAggregate, "Freight", "{Average:###.00}")
			Dim summaryRow2 As New GridSummaryRowDescriptor()
			summaryRow2.Name = "Bottom"
			summaryRow2.Visible = True
			summaryRow2.SummaryColumns.Add(summaryColumn2)
			ordersDescriptor.SummaryRows.Add(summaryRow2)

			' Here you define the summary row that should be used for displaying summaries in caption bar.
			ordersDescriptor.ChildGroupOptions.ShowCaptionSummaryCells = True
			ordersDescriptor.ChildGroupOptions.CaptionSummaryRow = "Caption"

			' Let's you hide/show the second row in child groups.
			ordersDescriptor.ChildGroupOptions.ShowSummaries = False

			' Move Freight column ahead 
			' ordersDescriptor.VisibleColumns.LoadDefault();
			Dim count As Integer = ordersDescriptor.VisibleColumns.Count ' force populating VisibleColumns
			ordersDescriptor.VisibleColumns.Remove("Freight")
			ordersDescriptor.VisibleColumns.Insert(3, New GridVisibleColumnDescriptor("Freight"))

			' Minor customization: Have Caption bar cover some cells.
			AddHandler gridGroupingControl1.TableModel.QueryCoveredRange, AddressOf TableModel_QueryCoveredRange
			captionCoverCols = 2

			Me.gridGroupingControl1.Appearance.GroupCaptionCell.BackColor = Me.gridGroupingControl1.Appearance.RecordFieldCell.BackColor
			Me.gridGroupingControl1.Appearance.GroupCaptionCell.Borders.Top = New GridBorder(GridBorderStyle.Standard)
			Me.gridGroupingControl1.Appearance.GroupCaptionCell.CellType = "Static"

			Me.gridGroupingControl1.TableOptions.CaptionRowHeight = Me.gridGroupingControl1.TableOptions.RecordRowHeight

			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False

			' Specify group sort order behavoir when adding SortColumnDescriptor to GroupedColumns
			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Clear()
			Dim gsd As New SortColumnDescriptor("ShipCountry")

			' specify your own Comparer
			'gsd.GroupSortOrderComparer = new ShipViaComparer(summaryColumn1.GetSummaryDescriptorName(), "Average");

			' or specify a summary name and the property (values will be determined using reflection)
			gsd.SetGroupSummarySortOrder(summaryColumn1.GetSummaryDescriptorName(), "Average")

			Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add(gsd)
			' this should always be true since changing one record can cause the whole group to move 
			' to a different position.
			Me.gridGroupingControl1.InvalidateAllWhenListChanged = True

			Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.gridGroupingControl1.Appearance.AnySummaryCell.BackColor = Color.FromArgb(255, 231, 162)
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


		Private captionCoverCols As Integer

		Private xmlName As String = "Orders.xml"
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
            Me.northwindDataSet1 = New SummaryInCaption.DataSet1
            Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
            Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
            Me.sqlConnection2 = New System.Data.SqlClient.SqlConnection
            Me.sqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
            Me.sqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
            Me.sqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
            Me.sqlDataAdapterOrders = New System.Data.SqlClient.SqlDataAdapter
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.panel2 = New System.Windows.Forms.Panel
            CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'northwindDataSet1
            '
            Me.northwindDataSet1.DataSetName = "DataSet1"
            Me.northwindDataSet1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'gridGroupingControl1
            '
            Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
            Me.gridGroupingControl1.DataSource = Me.northwindDataSet1.Orders
            Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.Location = New System.Drawing.Point(12, 9)
            Me.gridGroupingControl1.Name = "gridGroupingControl1"
            Me.gridGroupingControl1.ShowGroupDropArea = True
            Me.gridGroupingControl1.Size = New System.Drawing.Size(408, 478)
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
            Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
            Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
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
            'sqlInsertCommand2
            '
            Me.sqlInsertCommand2.Connection = Me.sqlConnection2
            Me.sqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry")})
            '
            'sqlUpdateCommand2
            '
            Me.sqlUpdateCommand2.Connection = Me.sqlConnection2
            Me.sqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"), New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShippedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID")})
            '
            'sqlDeleteCommand2
            '
            Me.sqlDeleteCommand2.Connection = Me.sqlConnection2
            Me.sqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShippedDate", System.Data.DataRowVersion.Original, Nothing)})
            '
            'sqlDataAdapterOrders
            '
            Me.sqlDataAdapterOrders.DeleteCommand = Me.sqlDeleteCommand2
            Me.sqlDataAdapterOrders.InsertCommand = Me.sqlInsertCommand2
            Me.sqlDataAdapterOrders.SelectCommand = Me.sqlSelectCommand2
            Me.sqlDataAdapterOrders.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
            Me.sqlDataAdapterOrders.UpdateCommand = Me.sqlUpdateCommand2
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Anchor = System.Windows.Forms.AnchorStyles.Left
            Me.propertyGrid1.BackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
            Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
            Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
            Me.propertyGrid1.LineColor = System.Drawing.Color.White
            Me.propertyGrid1.Location = New System.Drawing.Point(432, 14)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
            Me.propertyGrid1.Size = New System.Drawing.Size(252, 473)
            Me.propertyGrid1.TabIndex = 12
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.LightGray
            Me.panel2.Location = New System.Drawing.Point(425, 22)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(1, 453)
            Me.panel2.TabIndex = 13
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(695, 500)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.propertyGrid1)
            Me.Controls.Add(Me.gridGroupingControl1)
            Me.DropShadow = True
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Sort by Summary Demo"
            CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub TableModel_QueryCoveredRange(ByVal sender As Object, ByVal e As GridQueryCoveredRangeEventArgs)
			Dim thisTable As GridTable = Me.gridGroupingControl1.Table
			If e.RowIndex < thisTable.DisplayElements.Count Then
				Dim el As Element = thisTable.DisplayElements(e.RowIndex)

				Select Case el.Kind
					Case DisplayElementKind.Caption
						' Cover some cells of the caption bar (specified with captionCover)
						Dim gs As IGridGroupOptionsSource = TryCast(el.ParentGroup, IGridGroupOptionsSource)
						If gs IsNot Nothing AndAlso gs.GroupOptions.ShowCaptionSummaryCells Then
							Dim startCol As Integer = el.GroupLevel+1
							If Not gs.GroupOptions.ShowCaptionPlusMinus Then
								startCol -= 1
							End If
							If e.ColIndex >= startCol AndAlso e.ColIndex <= startCol+Me.captionCoverCols Then
								e.Range = GridRangeInfo.Cells(e.RowIndex, startCol, e.RowIndex, startCol+Me.captionCoverCols)
								e.Handled = True
							End If
						End If
						Exit Select

				End Select
			End If

		End Sub
	End Class

	Public Class ShipViaComparer
		Implements IComparer
		Private summaryDescriptorName As String
		Private propertyName As String

		Public Sub New(ByVal summaryDescriptorName As String, ByVal propertyName As String)
			Me.summaryDescriptorName = summaryDescriptorName
			Me.propertyName = propertyName
		End Sub

			#Region "IComparer Members"

		Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
			Dim gx As Group = CType(x, Group)
			Dim gy As Group = CType(y, Group)

			Dim strongTyped As Boolean = False

			If strongTyped Then
				' strong typed   (propertyName is ignored ...)
				Dim dasx As DoubleAggregateSummary = CType(gx.GetSummary(summaryDescriptorName), DoubleAggregateSummary)
				Dim dasy As DoubleAggregateSummary = CType(gy.GetSummary(summaryDescriptorName), DoubleAggregateSummary)

				Dim v As Integer = dasx.Average.CompareTo(dasy.Average)

				Return v
			Else
				' using reflection (slower but more flexible using propertyName) 
				Dim vx As Object = gx.GetSummaryProperty(summaryDescriptorName, propertyName)
				Dim vy As Object = gy.GetSummaryProperty(summaryDescriptorName, propertyName)

				Return (CType(vx, IComparable)).CompareTo(vy)
			End If
		End Function

			#End Region
	End Class

End Namespace