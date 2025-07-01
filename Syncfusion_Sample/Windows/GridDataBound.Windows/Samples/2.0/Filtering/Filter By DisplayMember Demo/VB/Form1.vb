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
Imports System.IO

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.GridHelperClasses

Namespace DataBoundFilterByDisplayMember
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits Syncfusion.Windows.Forms.Office2007Form
		Private gridDataBoundGrid1 As GridDataBoundGrid
		Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Private dataSet11 As DataSet1
		Private sqlConnection1 As System.Data.SqlClient.SqlConnection
		Private filterBar As GridDataBoundGridFilterBarExt

		''' <summary>
		''' Required designer variable.
		''' </summary>
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
            Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
			Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
			style.TextColor = Color.MidnightBlue
			style.Font.Facename = "Verdana"
			Me.BackColor = Color.FromArgb(223, 227, 239)
			Me.StartPosition = FormStartPosition.CenterScreen

			AddHandler gridDataBoundGrid1.Model.QueryCellInfo, AddressOf Model_QueryCellInfo
            Me.gridDataBoundGrid1.ThemesEnabled = True
            Me.gridDataBoundGrid1.Binder.EnableAddNew = False


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
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlUpdateProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"))
			' 
			' sqlDeleteProductCommand
			' 
			Me.sqlDeleteProductCommand.CommandText = "DELETE FROM Products WHERE (ProductID = @Original_ProductID) AND (CategoryID = @Original_CategoryID OR @Original_CategoryID IS NULL AND CategoryID IS NULL) AND (Discontinued = @Original_Discontinued) AND (ProductName = @Original_ProductName) AND (QuantityPerUnit = @Original_QuantityPerUnit OR @Original_QuantityPerUnit IS NULL AND QuantityPerUnit IS NULL) AND (ReorderLevel = @Original_ReorderLevel OR @Original_ReorderLevel IS NULL AND ReorderLevel IS NULL) AND (SupplierID = @Original_SupplierID OR @Original_SupplierID IS NULL AND SupplierID IS NULL) AND (UnitPrice = @Original_UnitPrice OR @Original_UnitPrice IS NULL AND UnitPrice IS NULL) AND (UnitsInStock = @Original_UnitsInStock OR @Original_UnitsInStock IS NULL AND UnitsInStock IS NULL) AND (UnitsOnOrder = @Original_UnitsOnOrder OR @Original_UnitsOnOrder IS NULL AND UnitsOnOrder IS NULL)"
			Me.sqlDeleteProductCommand.Connection = Me.sqlConnection1
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing))
			Me.sqlDeleteProductCommand.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing))

			' Comment this lines out to load from SQL database
'			this.sqlDataAdapter1.Fill(this.dataSet11);
'			this.sqlDataAdapter2.Fill(this.dataSet11);
'			this.sqlDataAdapter3.Fill(this.dataSet11);
'			this.gridDataBoundGrid1.DataSource = this.dataSet11.Products;

			' and comment this lines (they will load and initialize grid from xml file)


			Dim ds As DataSet = New DataSet()
			ds.ReadXmlSchema(FindXmlFile("FilterDataSchema.xml"))
			ds.ReadXml(FindXmlFile("FilterData.xml"))

			Me.gridDataBoundGrid1.DataSource = ds.Tables("Products")
			Me.supplierColumn.StyleInfo.DataSource = ds.Tables("Suppliers")
			Me.supplierColumn.StyleInfo.DisplayMember = "ContactName"
			Me.supplierColumn.StyleInfo.ValueMember = "SupplierID"
			Me.categoryColumn.StyleInfo.DataSource = ds.Tables("Categories")
			Me.categoryColumn.StyleInfo.DisplayMember = "CategoryName"
			Me.categoryColumn.StyleInfo.ValueMember = "CategoryID"

			filterBar = New GridDataBoundGridFilterBarExt()
            AddHandler filterBar.CreatingColumnHeader, AddressOf filterBar_CreatingColumnHeader
            AddHandler gridDataBoundGrid1.CurrentCellEditingComplete, AddressOf gridDataBoundGrid1_CurrentCellEditingComplete
			filterBar.WireGrid(Me.gridDataBoundGrid1)
		End Sub



		Private Function FindXmlFile(ByVal xmlFileName As String) As String
			For n As Integer = 0 To 6
				If File.Exists(xmlFileName) Then
					Return xmlFileName
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
			Return ""
		End Function


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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim gridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
			Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
			Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
			Me.sqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
			Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
			Me.sqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter()
			Me.sqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
			Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
            Me.dataSet11 = New DataSet1()
			Me.productIdColumn = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
			Me.productNameColumn = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
			Me.categoryColumn = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
			Me.supplierColumn = New Syncfusion.Windows.Forms.Grid.GridBoundColumn()
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' sqlDataAdapter1
			' 
			Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
			Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName")})})
			' 
			' sqlSelectCommand1
			' 
			Me.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText")
			Me.sqlSelectCommand1.Connection = Me.sqlConnection1
			' 
			' sqlConnection1
			' 
			Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
			Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
			' 
			' sqlDataAdapter2
			' 
			Me.sqlDataAdapter2.SelectCommand = Me.sqlSelectCommand2
			Me.sqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName")})})
			' 
			' sqlSelectCommand2
			' 
			Me.sqlSelectCommand2.CommandText = "SELECT CategoryID, CategoryName FROM Categories"
			Me.sqlSelectCommand2.Connection = Me.sqlConnection1
			' 
			' sqlDataAdapter3
			' 
			Me.sqlDataAdapter3.SelectCommand = Me.sqlSelectCommand3
			Me.sqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() { New System.Data.Common.DataTableMapping("Table", "Suppliers", New System.Data.Common.DataColumnMapping() { New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax"), New System.Data.Common.DataColumnMapping("HomePage", "HomePage")})})
			' 
			' sqlSelectCommand3
			' 
			Me.sqlSelectCommand3.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region," & " PostalCode, Country, Phone, Fax, HomePage FROM Suppliers"
			Me.sqlSelectCommand3.Connection = Me.sqlConnection1
			' 
			' gridDataBoundGrid1
			' 
			Me.gridDataBoundGrid1.AllowDragSelectedCols = True
			gridBaseStyle1.Name = "Row Header"
			gridBaseStyle1.StyleInfo.BaseStyle = "Header"
			gridBaseStyle1.StyleInfo.CellType = "RowHeaderCell"
			gridBaseStyle1.StyleInfo.Enabled = True
			gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle2.Name = "Column Header"
			gridBaseStyle2.StyleInfo.BaseStyle = "Header"
			gridBaseStyle2.StyleInfo.CellType = "ColumnHeaderCell"
			gridBaseStyle2.StyleInfo.Enabled = False
			gridBaseStyle2.StyleInfo.Font.Bold = False
			gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle3.Name = "Standard"
			gridBaseStyle3.StyleInfo.CheckBoxOptions.CheckedValue = "True"
			gridBaseStyle3.StyleInfo.CheckBoxOptions.UncheckedValue = "False"
			gridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			gridBaseStyle4.Name = "Header"
			gridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.CellType = "Header"
			gridBaseStyle4.StyleInfo.Font.Bold = True
			gridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
			gridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			Me.gridDataBoundGrid1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() { gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4})
			Me.gridDataBoundGrid1.DataSource = Me.dataSet11.Products
			Me.gridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridDataBoundGrid1.GridBoundColumns.AddRange(New Syncfusion.Windows.Forms.Grid.GridBoundColumn() { Me.productIdColumn, Me.productNameColumn, Me.categoryColumn, Me.supplierColumn})
			Me.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
			Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
			Me.gridDataBoundGrid1.Office2007ScrollBars = True
			Me.gridDataBoundGrid1.Properties.BackgroundColor = System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(239)))), (CInt((CByte(255)))))
			Me.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(215)))), (CInt((CByte(229)))))
			Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
			Me.gridDataBoundGrid1.Size = New System.Drawing.Size(590, 262)
			Me.gridDataBoundGrid1.SmartSizeBox = False
			Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
			Me.gridDataBoundGrid1.TabIndex = 0
			Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
			' 
			' productIdColumn
			' 
			Me.productIdColumn.MappingName = "ProductID"
			Me.productIdColumn.StyleInfo.CellValueType = GetType(Integer)
			Me.productIdColumn.StyleInfo.Format = "G"
			Me.productIdColumn.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right
			' 
			' productNameColumn
			' 
			Me.productNameColumn.MappingName = "ProductName"
			Me.productNameColumn.StyleInfo.CellValueType = GetType(String)
			' 
			' categoryColumn
			' 
			Me.categoryColumn.HeaderText = "Category"
			Me.categoryColumn.MappingName = "CategoryID"
			Me.categoryColumn.StyleInfo.CellType = "ComboBox"
			Me.categoryColumn.StyleInfo.DataSource = Me.dataSet11.Categories
			Me.categoryColumn.StyleInfo.DisplayMember = "CategoryName"
			Me.categoryColumn.StyleInfo.ValueMember = "CategoryID"
			' 
			' supplierColumn
			' 
			Me.supplierColumn.HeaderText = "Supplier"
			Me.supplierColumn.MappingName = "SupplierID"
			Me.supplierColumn.StyleInfo.CellType = "ComboBox"
			Me.supplierColumn.StyleInfo.DataSource = Me.dataSet11.Suppliers
			Me.supplierColumn.StyleInfo.DisplayMember = "CompanyName"
			Me.supplierColumn.StyleInfo.ValueMember = "SupplierID"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(590, 262)
			Me.Controls.Add(Me.gridDataBoundGrid1)
			Me.Name = "Form1"
			Me.Text = "Sort By DisplayMember Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()

#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
#End If


			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'Resize all columns to fit contents.
            Me.gridDataBoundGrid1.AllowResizeToFit = True
			Me.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(Me.gridDataBoundGrid1.ViewLayout.VisibleCellsRange, Syncfusion.Windows.Forms.Grid.GridResizeToFitOptions.IncludeHeaders)
            Me.Text = "Filter By DisplayMember Demo"
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

		
		Private Sub filterBar_CreatingColumnHeader(ByVal sender As Object, ByVal e As GridFilterBarCreatingColumnHeaderEventArgs)
			If e.ColName.StartsWith("Product") Then
				e.Cancel = True
			End If
		End Sub

		Private Sub Model_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
			If e.RowIndex > 0 AndAlso e.ColIndex > 0 Then
				If e.ColIndex = 3 Then
					e.Style.BackColor = Color.FromArgb(204, 212, 230)
				Else If e.ColIndex = 4 Then
					e.Style.BackColor = Color.FromArgb(&Hff, &Hbf, &H34)
				End If
			End If
        End Sub

        Private Sub gridDataBoundGrid1_CurrentCellEditingComplete(ByVal sender As Object, ByVal e As EventArgs)
            gridDataBoundGrid1.UpdateWithDrawClippedGrid(gridDataBoundGrid1.Bounds)
        End Sub
	End Class
End Namespace
