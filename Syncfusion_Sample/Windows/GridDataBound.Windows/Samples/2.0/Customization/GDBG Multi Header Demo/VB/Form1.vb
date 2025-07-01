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

Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid
Imports GDBGMultiHeader

'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    Private dataSet11 As DataSet1
    Private WithEvents gridRecordNavigationControl1 As Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
    Private WithEvents gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlConnection2 As System.Data.SqlClient.SqlConnection
    Private sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Private panel1 As System.Windows.Forms.Panel
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch ex As Exception
        End Try
        'Listen to the IBindingList.ListChanged events instead of the 
        'CurrencyManager events.
        Me.gridDataBoundGrid1.UseListChangedEvent = True
        Me.gridDataBoundGrid1.AllowSelection = GridSelectionFlags.Cell
        Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.StartPosition = FormStartPosition.CenterScreen
 
    End Sub 'New

    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose


#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.dataSet11 = New GDBGMultiHeader.DataSet1
        Me.gridRecordNavigationControl1 = New Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
        Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.sqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.panel1 = New System.Windows.Forms.Panel
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gridRecordNavigationControl1.SuspendLayout()
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.DeleteCommand = Me.sqlDeleteCommand1
        Me.sqlDataAdapter1.InsertCommand = Me.sqlInsertCommand1
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax")})})
        Me.sqlDataAdapter1.UpdateCommand = Me.sqlUpdateCommand1
        '
        'sqlDeleteCommand1
        '
        Me.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText")
        Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & _
            "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'sqlInsertCommand1
        '
        Me.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText")
        Me.sqlInsertCommand1.Connection = Me.sqlConnection1
        Me.sqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax")})
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," & _
            " PostalCode, Country, Phone, Fax FROM Customers"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        '
        'sqlUpdateCommand1
        '
        Me.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText")
        Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing)})
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gridRecordNavigationControl1
        '
        Me.gridRecordNavigationControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridRecordNavigationControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridRecordNavigationControl1.Controls.Add(Me.gridDataBoundGrid1)
        Me.gridRecordNavigationControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gridRecordNavigationControl1.Location = New System.Drawing.Point(48, 32)
        Me.gridRecordNavigationControl1.MaxRecord = 0
        Me.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1"
        Me.gridRecordNavigationControl1.ShowToolTips = True
        Me.gridRecordNavigationControl1.Size = New System.Drawing.Size(520, 328)
        Me.gridRecordNavigationControl1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.gridRecordNavigationControl1.TabIndex = 0
        Me.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1"
        Me.gridRecordNavigationControl1.ThemesEnabled = True
        '
        'gridDataBoundGrid1
        '
        Me.gridDataBoundGrid1.AllowDragSelectedCols = True
        Me.gridDataBoundGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDataBoundGrid1.DataSource = Me.dataSet11.Customers
        Me.gridDataBoundGrid1.DefaultColWidth = 70
        Me.gridDataBoundGrid1.DefaultRowHeight = 18
        Me.gridDataBoundGrid1.FillSplitterPane = True
        Me.gridDataBoundGrid1.HorizontalThumbTrack = True
        Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
        Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.gridDataBoundGrid1.Size = New System.Drawing.Size(501, 309)
        Me.gridDataBoundGrid1.SmartSizeBox = False
        Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ThemesEnabled = True
        Me.gridDataBoundGrid1.VerticalScrollTips = True
        Me.gridDataBoundGrid1.VerticalThumbTrack = True
        '
        'sqlSelectCommand2
        '
        Me.sqlSelectCommand2.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" & _
            ", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products"
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
        Me.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText")
        Me.sqlInsertCommand2.Connection = Me.sqlConnection2
        Me.sqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued")})
        '
        'sqlUpdateCommand2
        '
        Me.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText")
        Me.sqlUpdateCommand2.Connection = Me.sqlConnection2
        Me.sqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"), New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID")})
        '
        'sqlDeleteCommand2
        '
        Me.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText")
        Me.sqlDeleteCommand2.Connection = Me.sqlConnection2
        Me.sqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlDataAdapter2
        '
        Me.sqlDataAdapter2.DeleteCommand = Me.sqlDeleteCommand2
        Me.sqlDataAdapter2.InsertCommand = Me.sqlInsertCommand2
        Me.sqlDataAdapter2.SelectCommand = Me.sqlSelectCommand2
        Me.sqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})})
        Me.sqlDataAdapter2.UpdateCommand = Me.sqlUpdateCommand2
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(584, 374)
        Me.panel1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 374)
        Me.Controls.Add(Me.gridRecordNavigationControl1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDBG Multi Header Demo"
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gridRecordNavigationControl1.ResumeLayout(False)
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    Private checkBoxValues As New Hashtable()
    Private unboundValues As New Hashtable()
    Private gridModel As gridModel = Nothing
    Private gridBinder As GridModelDataBinder = Nothing
    Private initialized As Boolean = False


    Sub ReadXml(ByVal xmlFileName As String)
        Dim n As Integer
        For n = 0 To 10
            If File.Exists(xmlFileName) Then
                Me.dataSet11.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "../" + xmlFileName
        Next n
    End Sub 'ReadXml


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'we'll read the data from a local XML file
        'comment this line if you want to access your SQLserver
        ReadXml("Common\Data\GDBDMultiHeader.XML")

        'uncomment these DataAdapter1.Fill lines if you want to access your SQLserver
        'load the dataset with the tables we use
        'this.sqlDataAdapter1.Fill(this.dataSet11);
        'this.sqlDataAdapter2.Fill(this.dataSet11);
        Dim extraRowHeaders As Integer = 2
        Dim extraColHeaders As Integer = 1

        ' cache grid model and binder
        Me.gridModel = Me.gridDataBoundGrid1.Model
        Me.gridBinder = Me.gridDataBoundGrid1.Binder

        ' Reduce flicker
        Me.gridDataBoundGrid1.BeginUpdate()

        ' Copy over bound columns and add one unbound extra column at the end
        Dim columns As GridBoundColumnsCollection = CType(Me.gridBinder.InternalColumns.Clone(), GridBoundColumnsCollection)
        Dim unboundColumn As New GridBoundColumn()
        unboundColumn.HeaderText = "Unbound"
        unboundColumn.MappingName = "Unbound"
        columns.Add(unboundColumn)
        Me.gridBinder.GridBoundColumns = columns

        ' Initialize extra row and column header
        Me.gridDataBoundGrid1.Model.Rows.HeaderCount = extraRowHeaders
        Me.gridDataBoundGrid1.Model.Rows.FrozenCount = extraRowHeaders
        Me.gridDataBoundGrid1.Model.Cols.HeaderCount = extraColHeaders
        Me.gridDataBoundGrid1.Model.Cols.FrozenCount = extraColHeaders

        ' Some covered cells in the second header
        Me.gridDataBoundGrid1.Model.CoveredRanges.Add(GridRangeInfo.Cells(1, 2, 1, 3))
        Me.gridDataBoundGrid1.Model.CoveredRanges.Add(GridRangeInfo.Cells(1, 4, 1, 6))
        Me.gridDataBoundGrid1.Model.CoveredRanges.Add(GridRangeInfo.Cells(1, 8, 1, 10))
        Me.gridDataBoundGrid1(1, 2).Text = "Covered Cell - Group One"
        Me.gridDataBoundGrid1(1, 4).Text = "Covered Cell - Group Two"
        Me.gridDataBoundGrid1(1, 7).Text = "Single Cell"
        Me.gridDataBoundGrid1(1, 8).Text = "Covered Cell - Group Four"


        ' Before saving cell values we need to initialize internal data store to accept cell information
        ' Otherwise, we would get an "Out of Range" exception when saving cells.
        Me.gridDataBoundGrid1.Model.Data.RowCount = Me.gridDataBoundGrid1.Model.Rows.HeaderCount + 1
        Me.gridDataBoundGrid1.Model.Data.ColCount = Me.gridDataBoundGrid1.Model.ColCount - 1

        ' Now save the cells that should be displayed in the header cells.
        Dim maxcol As Integer = Me.dataSet11.Customers.Columns.Count
        Dim ar(maxcol) As GridStyleInfo
        Dim n As Integer
        For n = 0 To maxcol - 1
            Dim style As New GridStyleInfo()
            style.BaseStyle = "Standard" ' change base style - we don't want the standard "Header" basestyle.
            style.Borders.Bottom = New GridBorder(GridBorderStyle.Dashed, Color.Gray, GridBorderWeight.Medium)

            Select Case n Mod 7
                Case 0
                    ' Make it a combobox, (but could also be a GridDropDownList or CheckBox or ...)
                    style.CellType = "ComboBox"

                    ' This shows the Products table in the combobox.
                    style.DataSource = Me.dataSet11.Products
                    style.DisplayMember = "ProductName"
                    style.ValueMember = "ProductID"
                    style.Interior = New BrushInfo(Color.FromArgb(&HFF, &HBF, &H34))

                Case 1
                    ' CheckBox
                    style.CellType = "CheckBox"
                    style.Description = "CheckBox"
                    style.Interior = New BrushInfo(Color.FromArgb(192, 201, 219))
                    style.HorizontalAlignment = GridHorizontalAlignment.Center
                    style.VerticalAlignment = GridVerticalAlignment.Middle

                Case 2
                    ' Pushbutton
                    style.CellType = "PushButton"
                    style.Description = "Button"

                Case 3
                    ' Dropdown list
                    style.CellType = "GridListControl"

                    ' This shows the Products table in the combobox.
                    style.DataSource = Me.dataSet11.Products
                    style.DisplayMember = "ProductName"
                    style.ValueMember = "ProductID"
                    style.Interior = New BrushInfo(Color.FromArgb(204, 212, 230))

                Case 4
                    ' NumericUpDown
                    style.CellType = "NumericUpDown"
                    style.NumericUpDown.Minimum = 1
                    style.NumericUpDown.Maximum = 100
                    style.NumericUpDown.WrapValue = True
                    style.NumericUpDown.StartValue = 25
                    style.CellValueType = GetType(Double)
                    style.CellValue = 25
                    style.Interior = New BrushInfo(Color.FromArgb(&H85, &HBF, &H75))

                Case 5
                    ' ColorUI
                    style.CellType = "ColorEdit"
                    style.CellValueType = GetType(Color)
                    style.CellValue = Color.FromArgb(204, 212, 230)

                Case 6
                    ' DateTime
                    style.CellType = "MonthCalendar"
                    style.CellValueType = GetType(DateTime)
                    style.Interior = New BrushInfo(Color.FromArgb(218, 229, 245))
                    style.CellValue = DateTime.Today
                    style.Format = "d"
            End Select

            ar(n) = style
        Next n

        ' Save styles in one batch.
        Me.gridDataBoundGrid1.Model.ChangeCells(GridRangeInfo.Cells(extraRowHeaders, extraColHeaders + 1, extraRowHeaders, extraColHeaders + maxcol), ar)

        If extraColHeaders > 0 Then
            AddHandler Me.gridDataBoundGrid1.Model.QueryCellInfo, AddressOf ModelQueryCellInfo
            AddHandler Me.gridDataBoundGrid1.Model.SaveCellInfo, AddressOf ModelSaveCellInfo
            AddHandler gridDataBoundGrid1.ResizingRows, AddressOf gridResizingRows
            Me.gridDataBoundGrid1.Model.ColStyles(1).CellType = "CheckBox"
            Me.gridDataBoundGrid1.Model.ColStyles(1).BaseStyle = "Standard"
        End If

        ' Resize rows to fit height
        Me.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Cells(0, 0, extraRowHeaders, gridDataBoundGrid1.Model.ColCount), GridResizeToFitOptions.None)
        Me.gridDataBoundGrid1.Model.RowHeights.ResizeToFit(GridRangeInfo.Cells(0, 0, extraRowHeaders, gridDataBoundGrid1.Model.ColCount), GridResizeToFitOptions.None)
        Me.gridDataBoundGrid1.AllowResizeToFit = False

        ' Enable SelectAll mode for current cell (looks better)
        Me.gridDataBoundGrid1.Model.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.WhenGridActive
        Me.gridDataBoundGrid1.Model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.SelectAll

        ' Move current cell to top-left corner.
        Me.gridDataBoundGrid1.CurrentCell.MoveTo(gridDataBoundGrid1.Model.Rows.HeaderCount + 1, gridDataBoundGrid1.Model.Cols.HeaderCount + 1)

        ' Increase with of navigation record so that " of ###" can be shown
        Me.gridRecordNavigationControl1.NavigationBarWidth += 20
        Me.gridRecordNavigationControl1.Font = Me.gridDataBoundGrid1.Font
        Me.gridRecordNavigationControl1.BackColor = Color.FromArgb(192, 201, 219)
        Me.gridRecordNavigationControl1.NavigationBarBackColor = Color.FromArgb(237, 240, 246)

        ' Resize rows option
        Me.gridDataBoundGrid1.Model.Options.ResizeRowsBehavior = GridResizeCellsBehavior.ResizeAll Or GridResizeCellsBehavior.OutlineBounds Or GridResizeCellsBehavior.OutlineHeaders
        Me.gridDataBoundGrid1.Model.Options.ResizeColsBehavior = GridResizeCellsBehavior.ResizeSingle Or GridResizeCellsBehavior.AllowDragOutside Or GridResizeCellsBehavior.OutlineBounds Or GridResizeCellsBehavior.OutlineHeaders

        ' Set fond bold for standard column headers
        Dim gsiHeader As GridStyleInfo = Me.gridDataBoundGrid1.Model.BaseStylesMap("Header").StyleInfo
        gsiHeader.Font.Bold = True
        gsiHeader.Interior = New BrushInfo(Color.FromArgb(192, 201, 219))
        gsiHeader.TextColor = Color.FromArgb(51, 51, 102)

        Dim gsiStandard As GridStyleInfo = Me.gridDataBoundGrid1.Model.BaseStylesMap("Standard").StyleInfo
        '	gsiStandard.Interior = new BrushInfo(Color.FromArgb( 237, 240, 246 ));
        gsiStandard.TextColor = Color.FromArgb(0, 21, 84)

        ' Move Unbound column
        Dim unboundColIndex As Integer = gridModel.NameToColIndex("Unbound")
        If unboundColIndex <> -1 Then
            gridModel.Cols.MoveRange(unboundColIndex, 4)
        End If

        Me.gridDataBoundGrid1.DefaultRowHeight = 18
        Me.gridDataBoundGrid1.DefaultColWidth = 70
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid

        ' Grid will repaint ittself later.
        Me.gridDataBoundGrid1.EndUpdate()

        ' Wire events
        AddHandler Me.gridDataBoundGrid1.ScrollInfoChanged, AddressOf Me.gridDataBoundGrid1_ScrollInfoChanged
        AddHandler Me.gridDataBoundGrid1.ScrollTipFeedback, AddressOf Me.gridDataBoundGrid1_ScrollTipFeedback

        initialized = True
    End Sub 'Form1_Load

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    End Sub 'Form1_Closing

    ' You should call Update if you want changes made in the DataGrid be committed
    ' to the datasource. 
    ' Just uncomment the line below.
    ' this.sqlDataAdapter1.Update(this.dataSet11);

    Private Sub gridDataBoundGrid1_ScrollTipFeedback(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.ScrollTipFeedbackEventArgs)
        Dim grid As GridDataBoundGrid = sender '
        Dim recordNum As Integer = e.Value - grid.Model.Rows.HeaderCount
        Dim customer As Integer = grid.NameToColIndex("CustomerID")

        e.Text = [String].Format("Record {0}: {1}   ", recordNum, grid(e.Value, customer).Text)
        e.Font = grid.Font
        e.Size = grid.ScrollTip.GetPreferredSize(e.Text)
    End Sub 'gridDataBoundGrid1_ScrollTipFeedback


    Private Sub gridDataBoundGrid1_ScrollInfoChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim grid As GridDataBoundGrid = sender '
        Dim recordCount As Integer = grid.Binder.RowIndexToPosition(grid.Model.RowCount) + 1
        If grid.Binder.SupportsAddNew Then
            recordCount -= 1
        End If
        If recordCount > 0 Then
            Me.gridRecordNavigationControl1.MaxLabel = " of " + recordCount.ToString()
        Else
            Me.gridRecordNavigationControl1.MaxLabel = ""
        End If
        Syncfusion.Diagnostics.TraceUtil.TraceCurrentMethodInfo(Me.gridRecordNavigationControl1.MaxLabel)
    End Sub 'gridDataBoundGrid1_ScrollInfoChanged


    Private Sub gridRecordNavigationControl1_PaneCreated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs) Handles gridRecordNavigationControl1.PaneCreated
        Dim grid As GridDataBoundGrid = e.Control '
        AddHandler grid.ScrollTipFeedback, AddressOf Me.gridDataBoundGrid1_ScrollTipFeedback
        AddHandler grid.ScrollInfoChanged, AddressOf Me.gridDataBoundGrid1_ScrollInfoChanged
        AddHandler grid.PrepareViewStyleInfo, AddressOf Me.gridDataBoundGrid1_PrepareViewStyleInfo
        AddHandler grid.CurrentCellChanged, AddressOf Me.gridDataBoundGrid1_CurrentCellChanged
    End Sub 'gridRecordNavigationControl1_PaneCreated


    Private Sub gridRecordNavigationControl1_PaneClosing(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs) Handles gridRecordNavigationControl1.PaneClosing
        Dim grid As GridDataBoundGrid = e.Control '
        RemoveHandler grid.ScrollTipFeedback, AddressOf Me.gridDataBoundGrid1_ScrollTipFeedback
        RemoveHandler grid.ScrollInfoChanged, AddressOf Me.gridDataBoundGrid1_ScrollInfoChanged
        RemoveHandler grid.PrepareViewStyleInfo, AddressOf Me.gridDataBoundGrid1_PrepareViewStyleInfo
        RemoveHandler grid.CurrentCellChanged, AddressOf Me.gridDataBoundGrid1_CurrentCellChanged
    End Sub 'gridRecordNavigationControl1_PaneClosing

    Private Sub gridResizingRows(ByVal sender As Object, ByVal e As GridResizingRowsEventArgs)
        Me.gridDataBoundGrid1.ResizeRowsBehavior = GridResizeCellsBehavior.ResizeSingle
    End Sub

    Function GetPrimaryKey(ByVal rowIndex As Integer) As String
        Dim key As String = Nothing
        ' We can get the primary key either from the grid
        'int keyColIndex = model.NameToColIndex("CustomerID");
        'string key = model[rowIndex, keyColIndex].Text;
        ' or bypass grid and get it directly from the table
        Dim record As Integer = gridBinder.RowIndexToPosition(rowIndex)
        If record < Me.dataSet11.Customers.Count Then
            key = Me.dataSet11.Customers(record)(Me.dataSet11.Customers.CustomerIDColumn).ToString()
        End If
        Return key
    End Function 'GetPrimaryKey


    Sub ModelQueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        Dim model As GridModel = CType(sender, IGridModelSource).Model
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex > model.Rows.HeaderCount Then
            Dim colIndex As Integer = e.ColIndex
            ' Unbound checkbox header column
            If colIndex = 1 Then
                ' Initialize appearance of checkbox
                e.Style.CellType = "CheckBox"
                e.Style.Interior = New BrushInfo(GradientStyle.Horizontal, Color.FromArgb(192, 201, 219), Color.FromArgb(237, 240, 246))
                e.Style.Borders.Right = New GridBorder(GridBorderStyle.Dashed, Color.Gray, GridBorderWeight.Medium)
                e.Style.HorizontalAlignment = GridHorizontalAlignment.Center
                e.Style.VerticalAlignment = GridVerticalAlignment.Middle
                e.Style.CellValueType = GetType(Boolean)
                e.Style.CheckBoxOptions.CheckedValue = "True"
                e.Style.CheckBoxOptions.UncheckedValue = "False"

                ' look up checkbox state in hashtable
                Dim key As String = GetPrimaryKey(rowIndex)
                If Not (key Is Nothing) Then
                    Dim value As Object = checkBoxValues(key)
                    If Not (value Is Nothing) Then
                        e.Style.CellValue = value
                    End If
                End If
                e.Handled = True
                'Syncfusion.Diagnostics.TraceUtil.TraceCurrentMethodInfo(keyColIndex, key, value, e);
                Return
            End If

            ' Unbound column in columns collection
            Dim fieldNum As Integer = Me.gridBinder.ColIndexToField(colIndex)
            If fieldNum >= 0 And fieldNum < gridBinder.GridBoundColumns.Count Then
                Dim col As GridBoundColumn = Me.gridBinder.GridBoundColumns(fieldNum)
                If Not (col Is Nothing) AndAlso col.MappingName = "Unbound" Then
                    Select Case rowIndex Mod 4
                        Case 0
                            e.Style.Interior = New BrushInfo(Color.FromArgb(218, 229, 245))
                            e.Style.HorizontalAlignment = GridHorizontalAlignment.Center
                            e.Style.VerticalAlignment = GridVerticalAlignment.Middle
                            e.Style.CellType = "MonthCalendar"
                        Case 1
                            e.Style.HorizontalAlignment = GridHorizontalAlignment.Center
                            e.Style.VerticalAlignment = GridVerticalAlignment.Middle
                            e.Style.CellType = "PushButton"
                            e.Style.Description = "Click Me!"
                        Case 2
                            e.Style.Interior = New BrushInfo(Color.FromArgb(219, 226, 242))
                            e.Style.HorizontalAlignment = GridHorizontalAlignment.Center
                            e.Style.VerticalAlignment = GridVerticalAlignment.Middle
                            e.Style.CellType = "TextBox"
                        Case 3
                            e.Style.Interior = New BrushInfo(Color.FromArgb(192, 201, 219))
                            e.Style.HorizontalAlignment = GridHorizontalAlignment.Center
                            e.Style.VerticalAlignment = GridVerticalAlignment.Middle
                            e.Style.CellType = "CheckBox"
                    End Select

                    ' look up Value in hashtable
                    Dim key As String = GetPrimaryKey(rowIndex)
                    If Not (key Is Nothing) Then
                        Dim value As Object = unboundValues(key)
                        If Not (value Is Nothing) Then
                            e.Style.CellValue = value
                        End If
                    End If
                    e.Handled = True
                    'Syncfusion.Diagnostics.TraceUtil.TraceCurrentMethodInfo(keyColIndex, key, value, e);
                    Return
                End If
            End If
        End If
    End Sub 'ModelQueryCellInfo



    Sub ModelSaveCellInfo(ByVal sender As Object, ByVal e As GridSaveCellInfoEventArgs)
        Dim model As GridModel = CType(sender, IGridModelSource).Model
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex > model.Rows.HeaderCount Then
            Dim colIndex As Integer = e.ColIndex

            ' Unbound checkbox header column
            If colIndex = 1 Then
                ' Save checkbox value in hashtable
                Dim key As String = GetPrimaryKey(rowIndex)
                If Not (key Is Nothing) Then
                    checkBoxValues(key) = e.Style.CellValue
                    Syncfusion.Diagnostics.TraceUtil.TraceCurrentMethodInfo(key, e.Style.CellValue, e, Me.checkBoxValues.Count)
                End If
                e.Handled = True
            End If

            ' Unbound column in columns collection
            Dim fieldNum As Integer = Me.gridBinder.ColIndexToField(colIndex)
            If fieldNum >= 0 Then
                Dim col As GridBoundColumn = Me.gridBinder.GridBoundColumns(fieldNum)
                If Not (col Is Nothing) AndAlso col.MappingName = "Unbound" Then
                    ' Save value in hashtable
                    Dim key As String = GetPrimaryKey(rowIndex)
                    If Not (key Is Nothing) Then
                        unboundValues(key) = e.Style.CellValue
                        Syncfusion.Diagnostics.TraceUtil.TraceCurrentMethodInfo(key, e.Style.CellValue, e, Me.checkBoxValues.Count)
                    End If
                    e.Handled = True
                End If
            End If
        End If
    End Sub 'ModelSaveCellInfo


    Private Sub gridDataBoundGrid1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs) Handles gridDataBoundGrid1.PrepareViewStyleInfo
        If Not Me.initialized Then
            Return
        End If
        ' Draw all cells with strikeout font when user clicked the checkbox in the row header
        Dim grid As GridDataBoundGrid = CType(sender, GridDataBoundGrid)
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex > gridModel.Rows.HeaderCount Then
            Dim colIndex As Integer = e.ColIndex

            If colIndex > gridModel.Cols.HeaderCount Then
                ' If unbound checkbox column is checked then show all text striked out.
                'object value = null; //gridModel[rowIndex, 1].CellValue;
                Dim style As GridStyleInfo = gridModel(rowIndex, 1)
                If TypeOf style.CellValue Is Boolean Then
                    e.Style.Font.Strikeout = CBool(style.CellValue)
                End If
            End If
        End If
    End Sub 'gridDataBoundGrid1_PrepareViewStyleInfo

    Private Sub gridDataBoundGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gridDataBoundGrid1.CurrentCellChanged
        ' Set current position and/or repaint row when user clicked the checkbox in the row header
        Dim grid As GridDataBoundGrid = CType(sender, GridDataBoundGrid)
        Dim colIndex As Integer = grid.CurrentCell.ColIndex
        Dim rowIndex As Integer = grid.CurrentCell.RowIndex
        If colIndex = 1 Then
            Dim record As Integer = gridBinder.RowIndexToPosition(rowIndex)
            If gridBinder.CurrentPosition <> record Then
                gridBinder.CurrentPosition = record
            Else
                gridModel.InvalidateRange(GridRangeInfo.Row(rowIndex), GridRangeOptions.None)
            End If
        End If
    End Sub 'gridDataBoundGrid1_CurrentCellChanged
End Class 'Form1