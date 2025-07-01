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
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Globalization
Imports System.Resources
Imports System.Windows.Forms


Public Class Form1
    Inherits Form

    Private components As Container

    Public Sub New()
        MyBase.New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
            Me.Icon = ico
        Catch ex As Exception
        End Try
        'Listen to the IBindingList.ListChanged events instead of the 
        'CurrencyManager events.
        Me.gridDataBoundGrid1.UseListChangedEvent = True
 
        
        'Listen to the IBindingList.ListChanged events instead of the 
        'CurrencyManager events.
        Me.gridDataBoundGrid2.UseListChangedEvent = True

        
        'Listen to the IBindingList.ListChanged events instead of the 
        'CurrencyManager events.
        Me.gridDataBoundGrid3.UseListChangedEvent = True

        
        'Listen to the IBindingList.ListChanged events instead of the 
        'CurrencyManager events.
        Me.gridDataBoundGrid4.UseListChangedEvent = True

        Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"

        Me.gridDataBoundGrid2.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid2.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid2.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        style = gridDataBoundGrid2.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"

        Me.gridDataBoundGrid3.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid3.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid3.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        style = gridDataBoundGrid3.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"

        Me.gridDataBoundGrid4.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid4.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid4.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        style = gridDataBoundGrid4.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.StartPosition = FormStartPosition.CenterScreen
   End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)

    End Sub

    Friend WithEvents sqlcustomerAdapter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents gridDataBoundGrid4 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Friend WithEvents sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents gridDataBoundGrid3 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Friend WithEvents sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents gridDataBoundGrid2 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Friend WithEvents sqlemployeeAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents sqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents gridBoundColumn2 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents gridBoundColumn1 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Friend WithEvents gridBoundColumn3 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents sqlorderAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSet12 As GDBGcombos.DataSet1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridBoundColumn4 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents GridBoundColumn5 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents GridBoundColumn6 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents panel1 As System.Windows.Forms.Panel

#Region "Windows Generated Code"
    Friend WithEvents GridBoundColumn7 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Friend WithEvents GridBoundColumn8 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Private WithEvents GridBoundColumn9 As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim GridStyleInfo3 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
        Dim GridStyleInfo4 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
        Me.DataSet12 = New GDBGcombos.DataSet1
        Me.sqlorderAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlcustomerAdapter = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlemployeeAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.GridBoundColumn7 = New Syncfusion.Windows.Forms.Grid.GridBoundColumn
        Me.GridBoundColumn8 = New Syncfusion.Windows.Forms.Grid.GridBoundColumn
        Me.GridBoundColumn9 = New Syncfusion.Windows.Forms.Grid.GridBoundColumn
        Me.gridBoundColumn1 = New Syncfusion.Windows.Forms.Grid.GridBoundColumn
        Me.gridBoundColumn2 = New Syncfusion.Windows.Forms.Grid.GridBoundColumn
        Me.gridBoundColumn3 = New Syncfusion.Windows.Forms.Grid.GridBoundColumn
        Me.gridDataBoundGrid2 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.gridDataBoundGrid3 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.gridDataBoundGrid4 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDataBoundGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDataBoundGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDataBoundGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet12
        '
        Me.DataSet12.DataSetName = "DataSet1"
        Me.DataSet12.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sqlorderAdapter1
        '
        Me.sqlorderAdapter1.DeleteCommand = Me.sqlDeleteCommand1
        Me.sqlorderAdapter1.InsertCommand = Me.sqlInsertCommand1
        Me.sqlorderAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlorderAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
        Me.sqlorderAdapter1.UpdateCommand = Me.sqlUpdateCommand1
        '
        'sqlDeleteCommand1
        '
        Me.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText")
        Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShippedDate", System.Data.DataRowVersion.Original, Nothing)})
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
        Me.sqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry")})
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" & _
            "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" & _
            "Country FROM Orders"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        '
        'sqlUpdateCommand1
        '
        Me.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText")
        Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"), New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShippedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID")})
        '
        'sqlcustomerAdapter
        '
        Me.sqlcustomerAdapter.SelectCommand = Me.sqlSelectCommand2
        Me.sqlcustomerAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName")})})
        '
        'sqlSelectCommand2
        '
        Me.sqlSelectCommand2.CommandText = "SELECT CustomerID, CompanyName FROM Customers"
        Me.sqlSelectCommand2.Connection = Me.sqlConnection1
        '
        'sqlemployeeAdapter1
        '
        Me.sqlemployeeAdapter1.SelectCommand = Me.sqlSelectCommand3
        Me.sqlemployeeAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("LastName", "LastName")})})
        '
        'sqlSelectCommand3
        '
        Me.sqlSelectCommand3.CommandText = "SELECT EmployeeID, LastName FROM Employees"
        Me.sqlSelectCommand3.Connection = Me.sqlConnection1
        '
        'gridDataBoundGrid1
        '
        Me.gridDataBoundGrid1.AllowDragSelectedCols = True
        Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDataBoundGrid1.DataSource = Me.DataSet12.Orders
        Me.gridDataBoundGrid1.GridBoundColumns.AddRange(New Syncfusion.Windows.Forms.Grid.GridBoundColumn() {Me.GridBoundColumn7, Me.GridBoundColumn8, Me.GridBoundColumn9})
        Me.gridDataBoundGrid1.HorizontalThumbTrack = True
        Me.gridDataBoundGrid1.Location = New System.Drawing.Point(16, 37)
        Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible
        Me.gridDataBoundGrid1.Size = New System.Drawing.Size(336, 160)
        Me.gridDataBoundGrid1.SmartSizeBox = False
        Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid1.TabIndex = 0
        Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ThemesEnabled = True
        Me.gridDataBoundGrid1.VerticalThumbTrack = True
        '
        'GridBoundColumn7
        '
        Me.GridBoundColumn7.HeaderText = "OrderID"
        Me.GridBoundColumn7.MappingName = "OrderID"
        '
        'GridBoundColumn8
        '
        Me.GridBoundColumn8.HeaderText = "Customer"
        Me.GridBoundColumn8.MappingName = "CustomerID"
        Me.GridBoundColumn8.StyleInfo.CellType = "ComboBox"
        Me.GridBoundColumn8.StyleInfo.DataSource = Me.DataSet12.Customers
        Me.GridBoundColumn8.StyleInfo.DisplayMember = "CompanyName"
        Me.GridBoundColumn8.StyleInfo.ValueMember = "CustomerID"
        '
        'GridBoundColumn9
        '
        Me.GridBoundColumn9.HeaderText = "Employee"
        Me.GridBoundColumn9.MappingName = "EmployeeID"
        Me.GridBoundColumn9.StyleInfo.CellType = "ComboBox"
        Me.GridBoundColumn9.StyleInfo.DataSource = Me.DataSet12.Employees
        Me.GridBoundColumn9.StyleInfo.DisplayMember = "LastName"
        Me.GridBoundColumn9.StyleInfo.ValueMember = "EmployeeID"
        '
        'gridBoundColumn1
        '
        Me.gridBoundColumn1.HeaderText = "OrderID"
        Me.gridBoundColumn1.MappingName = "OrderID"
        '
        'gridBoundColumn2
        '
        Me.gridBoundColumn2.HeaderText = "Customer"
        Me.gridBoundColumn2.MappingName = "CustomerID"
        Me.gridBoundColumn2.StyleInfo.CellType = "ComboBox"
        Me.gridBoundColumn2.StyleInfo.DisplayMember = "CompanyName"
        Me.gridBoundColumn2.StyleInfo.ValueMember = "CustomerID"
        '
        'gridBoundColumn3
        '
        Me.gridBoundColumn3.HeaderText = "Employee"
        Me.gridBoundColumn3.MappingName = "EmployeeID"
        Me.gridBoundColumn3.StyleInfo.CellType = "ComboBox"
        Me.gridBoundColumn3.StyleInfo.DisplayMember = "LastName"
        Me.gridBoundColumn3.StyleInfo.ValueMember = "EmployeeID"
        '
        'gridDataBoundGrid2
        '
        Me.gridDataBoundGrid2.AllowDragSelectedCols = True
        Me.gridDataBoundGrid2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDataBoundGrid2.DataSource = Me.DataSet12.Orders
        Me.gridDataBoundGrid2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gridDataBoundGrid2.HorizontalThumbTrack = True
        Me.gridDataBoundGrid2.Location = New System.Drawing.Point(16, 234)
        Me.gridDataBoundGrid2.Name = "gridDataBoundGrid2"
        Me.gridDataBoundGrid2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible
        Me.gridDataBoundGrid2.Size = New System.Drawing.Size(896, 144)
        Me.gridDataBoundGrid2.SmartSizeBox = False
        Me.gridDataBoundGrid2.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid2.TabIndex = 1
        GridStyleInfo3.Font.Bold = False
        GridStyleInfo3.Font.Facename = "Microsoft Sans Serif"
        GridStyleInfo3.Font.Italic = False
        GridStyleInfo3.Font.Size = 8.25!
        GridStyleInfo3.Font.Strikeout = False
        GridStyleInfo3.Font.Underline = False
        Me.gridDataBoundGrid2.TableStyle = GridStyleInfo3
        Me.gridDataBoundGrid2.Text = "gridDataBoundGrid2"
        Me.gridDataBoundGrid2.ThemesEnabled = True
        Me.gridDataBoundGrid2.VerticalThumbTrack = True
        '
        'gridDataBoundGrid3
        '
        Me.gridDataBoundGrid3.AllowDragSelectedCols = True
        Me.gridDataBoundGrid3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDataBoundGrid3.DataSource = Me.DataSet12.Customers
        Me.gridDataBoundGrid3.HorizontalThumbTrack = True
        Me.gridDataBoundGrid3.Location = New System.Drawing.Point(368, 69)
        Me.gridDataBoundGrid3.Name = "gridDataBoundGrid3"
        Me.gridDataBoundGrid3.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible
        Me.gridDataBoundGrid3.Size = New System.Drawing.Size(320, 128)
        Me.gridDataBoundGrid3.SmartSizeBox = False
        Me.gridDataBoundGrid3.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid3.TabIndex = 2
        Me.gridDataBoundGrid3.Text = "gridDataBoundGrid3"
        Me.gridDataBoundGrid3.ThemesEnabled = True
        Me.gridDataBoundGrid3.VerticalThumbTrack = True
        '
        'gridDataBoundGrid4
        '
        Me.gridDataBoundGrid4.AllowDragSelectedCols = True
        Me.gridDataBoundGrid4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDataBoundGrid4.DataSource = Me.DataSet12.Employees
        Me.gridDataBoundGrid4.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.gridDataBoundGrid4.HorizontalThumbTrack = True
        Me.gridDataBoundGrid4.Location = New System.Drawing.Point(704, 69)
        Me.gridDataBoundGrid4.Name = "gridDataBoundGrid4"
        Me.gridDataBoundGrid4.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.AlwaysVisible
        Me.gridDataBoundGrid4.Size = New System.Drawing.Size(208, 128)
        Me.gridDataBoundGrid4.SmartSizeBox = False
        Me.gridDataBoundGrid4.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid4.TabIndex = 3
        GridStyleInfo4.Font.Bold = False
        GridStyleInfo4.Font.Facename = "Arial"
        GridStyleInfo4.Font.Italic = False
        GridStyleInfo4.Font.Size = 8.25!
        GridStyleInfo4.Font.Strikeout = False
        GridStyleInfo4.Font.Underline = False
        Me.gridDataBoundGrid4.TableStyle = GridStyleInfo4
        Me.gridDataBoundGrid4.Text = "gridDataBoundGrid4"
        Me.gridDataBoundGrid4.ThemesEnabled = True
        Me.gridDataBoundGrid4.VerticalThumbTrack = True
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(320, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Orders Table Showing Raw Data"
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(704, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "EmployeeTable with Key && Value"
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(368, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Customer Table with Key && Value"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Orders Grid with Foreign Key Combo Columns"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(792, 566)
        Me.panel1.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(928, 390)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gridDataBoundGrid4)
        Me.Controls.Add(Me.gridDataBoundGrid3)
        Me.Controls.Add(Me.gridDataBoundGrid2)
        Me.Controls.Add(Me.gridDataBoundGrid1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDBG Combo Box Demo"
        CType(Me.DataSet12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDataBoundGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDataBoundGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDataBoundGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    <STAThread()> _
    Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub

    'search up the folder tree for the desired XML file
    Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
        Dim n As Integer
        For n = 0 To 10
            If System.IO.File.Exists(xmlFileName) Then
                ds.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" & xmlFileName
        Next n '
    End Sub 'ReadXml

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'we'll read the data from a local XML file
            'comment this line if you want to access your SQLserver
            ReadXml(Me.DataSet12, "Common\\Data\\GDBDdata.XML")

            'uncomment these 3 lines if you want to access your SQLserver
            'Me.sqlcustomerAdapter.Fill(Me.DataSet12)
            'Me.sqlemployeeAdapter1.Fill(Me.DataSet12)
            'Me.sqlorderAdapter1.Fill(Me.DataSet12)


            AddHandler gridDataBoundGrid2.CurrentCellActivated, AddressOf gridDataBoundGrid2_CurrentCellActivated
            AddHandler gridDataBoundGrid3.CurrentCellActivated, AddressOf gridDataBoundGrid3_CurrentCellActivated
            AddHandler gridDataBoundGrid4.CurrentCellActivated, AddressOf gridDataBoundGrid4_CurrentCellActivated

            'manually size columns in first grid
            Me.gridDataBoundGrid1.AllowResizeToFit = False
            Me.gridDataBoundGrid1.Model.ColWidths(1) = 50
            Me.gridDataBoundGrid1.Model.ColWidths(2) = 142
            Me.gridDataBoundGrid1.Model.ColWidths(3) = 88

            'color columns from code...
            Me.gridDataBoundGrid1.Model.ColStyles(2).BackColor = Color.FromArgb(218, 229, 245)
            Me.gridDataBoundGrid1.Model.ColStyles(3).BackColor = Color.FromArgb(204, 212, 230)
            Me.gridDataBoundGrid2.Model.ColStyles(2).BackColor = Color.FromArgb(218, 229, 245)
            Me.gridDataBoundGrid3.Model.ColStyles(1).BackColor = Color.FromArgb(218, 229, 245)
            Me.gridDataBoundGrid2.Model.ColStyles(3).BackColor = Color.FromArgb(204, 212, 230)
            Me.gridDataBoundGrid4.Model.ColStyles(1).BackColor = Color.FromArgb(204, 212, 230)

            Me.gridDataBoundGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver
            Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridDataBoundGrid2.Model.Properties.GridLineColor = System.Drawing.Color.Silver
            Me.gridDataBoundGrid2.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridDataBoundGrid3.Model.Properties.GridLineColor = System.Drawing.Color.Silver
            Me.gridDataBoundGrid3.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridDataBoundGrid4.Model.Properties.GridLineColor = System.Drawing.Color.Silver
            Me.gridDataBoundGrid4.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid


        Catch ex As Exception
            MessageBox.Show("Problem reading XML file: " + ex.ToString())
            Me.Close()
        End Try





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

	
    Private Sub gridDataBoundGrid2_CurrentCellActivated(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'force scroll into view
        Me.gridDataBoundGrid2.CurrentCell.ScrollInView()

    End Sub
    Private Sub gridDataBoundGrid3_CurrentCellActivated(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'force scroll into view
        Me.gridDataBoundGrid3.CurrentCell.ScrollInView()

    End Sub
    Private Sub gridDataBoundGrid4_CurrentCellActivated(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'force scroll into view
        Me.gridDataBoundGrid4.CurrentCell.ScrollInView()

    End Sub


End Class

