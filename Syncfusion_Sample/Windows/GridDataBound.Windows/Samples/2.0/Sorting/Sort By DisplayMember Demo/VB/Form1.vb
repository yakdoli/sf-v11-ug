#Region "Copyright Syncfusion Inc. 2001 - 2009"
'
'  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
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
Imports System.IO

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Office2007Form
    Private WithEvents gridDataBoundGrid1 As DataBoundGrid
    Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Private dataSet11 As DataBoundSortByDisplayMember.DataSet1
    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    ' manually added 
    Private sqlInsertProductCommand As System.Data.SqlClient.SqlCommand
    Private sqlUpdateProductCommand As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Private productIdColumn As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Private productNameColumn As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Private categoryColumn As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Private supplierColumn As Syncfusion.Windows.Forms.Grid.GridBoundColumn
    Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteProductCommand As System.Data.SqlClient.SqlCommand
    
    
    
    Public Sub New()
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
        
        Me.gridDataBoundGrid1.SortBehavior = GridSortBehavior.SingleClick
        Me.gridDataBoundGrid1.AllowSelection = GridSelectionFlags.Row Or GridSelectionFlags.Multiple Or GridSelectionFlags.Shift Or GridSelectionFlags.AlphaBlend
        Me.gridDataBoundGrid1.ControllerOptions = Me.gridDataBoundGrid1.ControllerOptions And Not(GridControllerOptions.OleDataSource Or GridControllerOptions.OleDropTarget)
        Me.gridDataBoundGrid1.ThemesEnabled = True
        Me.gridDataBoundGrid1.Office2007ScrollBars = True
        Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.StartPosition = FormStartPosition.CenterScreen
        AddHandler Me.gridDataBoundGrid1.Model.QueryCellInfo, AddressOf Model_QueryCellInfo
        
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        ' Need to manually configure these commands because of designer limitation
        ' not understanding Category table join is not needed for updating underlying
        ' datatable.
        Me.sqlInsertProductCommand = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateProductCommand = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteProductCommand = New System.Data.SqlClient.SqlCommand()
        ' 
        ' sqlInsertProductCommand
        ' 
        Me.sqlInsertProductCommand.CommandText = "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued); SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE (ProductID = @@IDENTITY)"
        Me.sqlInsertProductCommand.Connection = Me.sqlConnection1
        Me.sqlInsertProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"))
        Me.sqlInsertProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"))
        Me.sqlInsertProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"))
        Me.sqlInsertProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"))
        Me.sqlInsertProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"))
        Me.sqlInsertProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"))
        Me.sqlInsertProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"))
        Me.sqlInsertProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"))
        Me.sqlInsertProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"))
        ' 
        ' sqlUpdateProductCommand
        ' 
        Me.sqlUpdateProductCommand.CommandText = "UPDATE Products SET ProductName = @ProductName, SupplierID = @SupplierID, CategoryID = @CategoryID, QuantityPerUnit = @QuantityPerUnit, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock, UnitsOnOrder = @UnitsOnOrder, ReorderLevel = @ReorderLevel, Discontinued = @Discontinued WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (Discontinued = @Original_Discontinued) AND (ProductName = @Original_ProductName) AND (QuantityPerUnit = @Original_QuantityPerUnit OR @Original_QuantityPerUnit IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = @Original_ReorderLevel OR @Original_ReorderLevel IS NULL AND ReorderLevel IS NULL) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL) AND (UnitPrice = @Original_UnitPrice OR @Original_UnitPrice IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = @Original_UnitsInStock OR @Original_UnitsInStock IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = @Original_UnitsOnOrder OR @Original_UnitsOnOrder IS NULL AND UnitsOnOrder IS NULL); SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE (ProductID = @ProductID)"
        Me.sqlUpdateProductCommand.Connection = Me.sqlConnection1
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "Discontinued", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "ProductName", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "SupplierID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"))
        ' 
        ' sqlDeleteProductCommand
        ' 
        Me.sqlDeleteProductCommand.CommandText = "DELETE FROM Products WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (Discontinued = @Original_Discontinued) AND (ProductName = @Original_ProductName) AND (QuantityPerUnit = @Original_QuantityPerUnit OR @Original_QuantityPerUnit IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = @Original_ReorderLevel OR @Original_ReorderLevel IS NULL AND ReorderLevel IS NULL) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL) AND (UnitPrice = @Original_UnitPrice OR @Original_UnitPrice IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = @Original_UnitsInStock OR @Original_UnitsInStock IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = @Original_UnitsOnOrder OR @Original_UnitsOnOrder IS NULL AND UnitsOnOrder IS NULL)"
        Me.sqlDeleteProductCommand.Connection = Me.sqlConnection1
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "Discontinued", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "ProductName", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "SupplierID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing))
        
        ' Comment this lines out to load from SQL database
        'sqlDataAdapter1.Fill(dataSet11)
        'sqlDataAdapter2.Fill(dataSet11)
        'sqlDataAdapter3.Fill(dataSet11)
        'gridDataBoundGrid1.DataSource = dataSet11.Products
        ' and comment this lines (they will load and initialize grid from xml file)
        Dim ds As New DataSet()
        ds.ReadXmlSchema(FindXmlFile("SortDataSchema.xml"))
        ds.ReadXml(FindXmlFile("SortData.xml"))
        Me.gridDataBoundGrid1.DataSource = ds.Tables("Products")
        Me.supplierColumn.StyleInfo.DataSource = ds.Tables("Suppliers")
        Me.categoryColumn.StyleInfo.DataSource = ds.Tables("Categories")
        ' end loading xml
        Me.gridDataBoundGrid1.AllowResizeToFit = False
        Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        style = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub 'New
    
    
    Function FindXmlFile(xmlFileName As String) As String
        Dim n As Integer
        For n = 0 To 8
            If File.Exists(xmlFileName) Then
                Return xmlFileName
            End If
            xmlFileName = "..\" + xmlFileName
        Next n
        Return ""
    End Function 'FindXmlFile
    
    
    
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
        Me.gridDataBoundGrid1 = New DataBoundSortByDisplayMember.DataBoundGrid()
        Me.dataSet11 = New DataBoundSortByDisplayMember.DataSet1()
        Me.productIdColumn = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.productNameColumn = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.categoryColumn = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.supplierColumn = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.sqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridDataBoundGrid1
        '
        Me.gridDataBoundGrid1.AllowDragSelectedCols = True
        Me.gridDataBoundGrid1.DataSource = Me.dataSet11.Products
        Me.gridDataBoundGrid1.GridBoundColumns.AddRange(New Syncfusion.Windows.Forms.Grid.GridBoundColumn() {Me.productIdColumn, Me.productNameColumn, Me.categoryColumn, Me.supplierColumn})
        Me.gridDataBoundGrid1.Location = New System.Drawing.Point(24, 16)
        Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.gridDataBoundGrid1.Size = New System.Drawing.Size(248, 224)
        Me.gridDataBoundGrid1.SmartSizeBox = False
        Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid1.TabIndex = 0
        Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        '
        'productIdColumn
        '
        Me.productIdColumn.MappingName = "ProductID"
        Me.productIdColumn.StyleInfo.CellValueType = GetType(System.Int32)
        Me.productIdColumn.StyleInfo.Format = "G"
        Me.productIdColumn.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right
        '
        'productNameColumn
        '
        Me.productNameColumn.MappingName = "ProductName"
        Me.productNameColumn.StyleInfo.CellValueType = GetType(System.String)
        '
        'categoryColumn
        '
        Me.categoryColumn.HeaderText = "Category"
        Me.categoryColumn.MappingName = "CategoryID"
        Me.categoryColumn.StyleInfo.CellType = "ComboBox"
        Me.categoryColumn.StyleInfo.CellValueType = GetType(System.Int32)
        Me.categoryColumn.StyleInfo.DataSource = Me.dataSet11.Categories
        Me.categoryColumn.StyleInfo.DisplayMember = "CategoryName"
        Me.categoryColumn.StyleInfo.ValueMember = "CategoryID"
        '
        'supplierColumn
        '
        Me.supplierColumn.HeaderText = "Supplier"
        Me.supplierColumn.MappingName = "SupplierID"
        Me.supplierColumn.StyleInfo.CellType = "ComboBox"
        Me.supplierColumn.StyleInfo.CellValueType = GetType(System.Int32)
        Me.supplierColumn.StyleInfo.DataSource = Me.dataSet11.Suppliers
        Me.supplierColumn.StyleInfo.DisplayMember = "CompanyName"
        Me.supplierColumn.StyleInfo.ValueMember = "SupplierID"
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName")})})
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "SELECT Categories.CategoryName, Products.ProductID, Products.ProductName, Product" & _
        "s.SupplierID, Products.CategoryID, Products.QuantityPerUnit, Products.UnitPrice," & _
        " Products.UnitsInStock, Products.UnitsOnOrder, Products.ReorderLevel, Products.D" & _
        "iscontinued, Suppliers.CompanyName FROM Products INNER JOIN Categories ON Produc" & _
        "ts.CategoryID = Categories.CategoryID INNER JOIN Suppliers ON Products.SupplierI" & _
        "D = Suppliers.SupplierID"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_samples;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        '
        'sqlDataAdapter2
        '
        Me.sqlDataAdapter2.SelectCommand = Me.sqlSelectCommand2
        Me.sqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName")})})
        '
        'sqlSelectCommand2
        '
        Me.sqlSelectCommand2.CommandText = "SELECT CategoryID, CategoryName FROM Categories"
        Me.sqlSelectCommand2.Connection = Me.sqlConnection1
        '
        'sqlDataAdapter3
        '
        Me.sqlDataAdapter3.SelectCommand = Me.sqlSelectCommand3
        Me.sqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Suppliers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax"), New System.Data.Common.DataColumnMapping("HomePage", "HomePage")})})
        '
        'sqlSelectCommand3
        '
        Me.sqlSelectCommand3.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region," & _
        " PostalCode, Country, Phone, Fax, HomePage FROM Suppliers"
        Me.sqlSelectCommand3.Connection = Me.sqlConnection1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 264)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.gridDataBoundGrid1})
        Me.Name = "Form1"
        Me.Text = "Sort By DisplayMember Demo"
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' following workaround ensures that combobox has valid binding context before we we try resizetofit
        Me.gridDataBoundGrid1.Model.CellModels("ComboBox").BindingContext = Me.BindingContext
        Me.gridDataBoundGrid1.Model.CellModels("GridListControl").BindingContext = Me.BindingContext

        ' Now resize all columns to fit contents.
        Me.gridDataBoundGrid1.AllowResizeToFit = False
        Me.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(Me.gridDataBoundGrid1.ViewLayout.VisibleCellsRange, Syncfusion.Windows.Forms.Grid.GridResizeToFitOptions.IncludeHeaders)

        ' Let's also size parent form large enough to hold this grid with horizontal scrollbars
        Me.SuspendLayout()

        Me.AdjustGridBounds()

        Dim grid As GridDataBoundGrid = Me.gridDataBoundGrid1
        Dim parentForm As Form = Me

        Dim optimalClientSize As Size = grid.Size ' Grid size has been calculated in HawksImpGrid_Load
        ' Add frame border, caption and 2 pixels for the borders of the parent container border.
        Dim optimalParentSize As New Size(optimalClientSize.Width + System.Windows.Forms.SystemInformation.VerticalScrollBarWidth + System.Windows.Forms.SystemInformation.FrameBorderSize.Width * 2, optimalClientSize.Height + System.Windows.Forms.SystemInformation.CaptionHeight + 2)

        Me.Size = optimalParentSize
        Me.gridDataBoundGrid1.Dock = DockStyle.Fill

        Me.ResumeLayout()
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


    Sub AdjustGridBounds()
        Dim grid As GridDataBoundGrid = Me.gridDataBoundGrid1
        Dim gridWidth As Integer = grid.Model.ColWidths.GetTotal(0, grid.Model.ColCount)
        Dim gridHeight As Integer = Me.ClientSize.Height ' this.grid.Model.RowHeights.GetTotal(0, this.grid.Model.RowCount);
        grid.HScrollBehavior = GridScrollbarMode.Automatic
        grid.VScrollBehavior = GridScrollbarMode.Automatic

        ' Make sure no scrollbars are shown. A little trick here is to fist make the grid 
        ' a bit larger so that we are sure no scrollbars are needed 
        grid.Bounds = New Rectangle(0, 0, gridWidth + System.Windows.Forms.SystemInformation.VerticalScrollBarWidth, gridHeight + System.Windows.Forms.SystemInformation.HorizontalScrollBarHeight)

        ' and then set the bounds of the grid - again no scrollbars are necessary
        grid.Bounds = New Rectangle(0, 0, gridWidth, gridHeight)
    End Sub 'AdjustGridBounds

    ' - Or - 
    ' we could force turning off scrollbars temporary ...
    '			this.grid.HScrollBehavior = GridScrollbarMode.Disabled;
    '			this.grid.VScrollBehavior = GridScrollbarMode.Disabled;
    '			grid.VScroll = false;
    '			grid.HScroll = false;
    '			grid.Bounds = new Rectangle(0, 0, gridWidth, gridHeight);
    '			this.grid.HScrollBehavior = GridScrollbarMode.Automatic;
    '			this.grid.VScrollBehavior = GridScrollbarMode.Automatic;


    Private Sub gridDataBoundGrid1_CellClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs) Handles gridDataBoundGrid1.CellClick
        Dim VersionGreater1618 As Boolean = False
        If VersionGreater1618 Then
            Dim grid As GridDataBoundGrid = sender
            If Not (grid Is Nothing) AndAlso e.RowIndex = 0 AndAlso e.ColIndex > 0 Then
                Dim binder As GridModelDataBinder = grid.Binder
                Dim field As Integer = binder.ColIndexToField(e.ColIndex)
                If field >= 0 Then
                    Dim column As GridBoundColumn = binder.InternalColumns(field)
                    Dim sortName As String = column.MappingName
                    If column.MappingName = "SupplierID" Then
                        sortName = "CompanyName"
                    ElseIf column.MappingName = "CategoryID" Then
                        sortName = "CategoryName"
                    End If
                    Dim cm As CurrencyManager = BindingContext(grid.DataSource, grid.DataMember)
                    Dim dv As DataView = cm.List '
                    Dim sortDir As ListSortDirection = ListSortDirection.Ascending
                    If dv.Sort = sortName Then
                        dv.Sort = sortName + " DESC"
                        sortDir = ListSortDirection.Descending
                    Else
                        dv.Sort = sortName
                    End If
                    grid.Model(0, e.ColIndex).Tag = sortDir

                    e.Cancel = True ' do not continue with default behavior 
                End If ' e.Cancel will only work with 1.6.1.8 or higher 
            End If ' (othwerwise you need to derive GridDataBoundGrid and override OnCellClick)
        End If
    End Sub 'gridDataBoundGrid1_CellClick


    Private Sub Model_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        ' Set style.Tag for the sorted column
        If e.RowIndex = 0 AndAlso e.ColIndex > 0 Then
            Dim grid As GridDataBoundGridModel = CType(sender, GridDataBoundGridModel)
            Dim binder As GridModelDataBinder = grid.Binder
            Dim field As Integer = binder.ColIndexToField(e.ColIndex)
            If field >= 0 Then
                Dim column As GridBoundColumn = binder.InternalColumns(field)
                Dim sortName As String = column.MappingName
                If column.MappingName = "SupplierID" Then
                    sortName = "CompanyName"
                ElseIf column.MappingName = "CategoryID" Then
                    sortName = "CategoryName"
                End If
                Dim cm As CurrencyManager = BindingContext(binder.DataSource, binder.DataMember) '
                Dim dv As DataView = cm.List '

                If dv.Sort = sortName Then
                    e.Style.Tag = ListSortDirection.Ascending
                ElseIf dv.Sort = sortName + " DESC" Then
                    e.Style.Tag = ListSortDirection.Descending
                End If
            End If
        ElseIf ((e.RowIndex > 0) AndAlso (e.ColIndex > 0)) Then
            If (e.ColIndex = 4) Then
                e.Style.BackColor = Color.FromArgb(&HFF, &HBF, &H34)
            End If
        End If
    End Sub 'Model_QueryCellInfo
End Class 'Form1 

' Deriving DataBoundGrid is only needed ie e.Cancel for CellClick does not work (1.6.1.7 or earlier)

Public Class DataBoundGrid
    Inherits GridDataBoundGrid
    
    Protected Overrides Sub OnCellClick(e As GridCellClickEventArgs)
        Dim grid As GridDataBoundGrid = Me
        If Not (grid Is Nothing) AndAlso e.RowIndex = 0 AndAlso e.ColIndex > 0 Then
            Dim binder As GridModelDataBinder = grid.Binder
            Dim field As Integer = binder.ColIndexToField(e.ColIndex)
            If field >= 0 Then
                Dim column As GridBoundColumn = binder.InternalColumns(field)
                Dim sortName As String = column.MappingName
                If column.MappingName = "SupplierID" Then
                    sortName = "CompanyName"
                ElseIf column.MappingName = "CategoryID" Then
                    sortName = "CategoryName"
                End If 
                Dim cm As CurrencyManager = BindingContext(grid.DataSource, grid.DataMember) '
                Dim dv As DataView = cm.List '
                Dim sortDir As ListSortDirection = ListSortDirection.Ascending
                If dv.Sort = sortName Then
                    dv.Sort = sortName + " DESC"
                    sortDir = ListSortDirection.Descending
                Else
                    dv.Sort = sortName
                End If
                grid.Model(0, e.ColIndex).Tag = sortDir

                e.Cancel = True ' do not continue with default behavior 
            End If
        End If
        
        If e.Cancel Then
            Return
        End If 
        MyBase.OnCellClick(e)
    End Sub 'OnCellClick
End Class 'DataBoundGrid 