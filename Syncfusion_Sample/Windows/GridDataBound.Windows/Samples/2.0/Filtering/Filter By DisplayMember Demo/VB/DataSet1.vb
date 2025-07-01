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
	Imports System.Data
	Imports System.Xml
	Imports System.Runtime.Serialization
Namespace DataBoundFilterByDisplayMember


	<Serializable(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Diagnostics.DebuggerStepThrough(), System.ComponentModel.ToolboxItem(True)> _
	Public Class DataSet1 : Inherits DataSet

		Private tableCategories As CategoriesDataTable

		Private tableProducts As ProductsDataTable

		Private tableSuppliers As SuppliersDataTable

		Public Sub New()
			Me.InitClass()
			Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
			AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
		End Sub

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			Dim strSchema As String = (CStr(info.GetValue("XmlSchema", GetType(String))))
			If (Not strSchema Is Nothing) Then
				Dim ds As DataSet = New DataSet()
				ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
				If (Not ds.Tables("Categories") Is Nothing) Then
					Me.Tables.Add(New CategoriesDataTable(ds.Tables("Categories")))
				End If
				If (Not ds.Tables("Products") Is Nothing) Then
					Me.Tables.Add(New ProductsDataTable(ds.Tables("Products")))
				End If
				If (Not ds.Tables("Suppliers") Is Nothing) Then
					Me.Tables.Add(New SuppliersDataTable(ds.Tables("Suppliers")))
				End If
				Me.DataSetName = ds.DataSetName
				Me.Prefix = ds.Prefix
				Me.Namespace = ds.Namespace
				Me.Locale = ds.Locale
				Me.CaseSensitive = ds.CaseSensitive
				Me.EnforceConstraints = ds.EnforceConstraints
				Me.Merge(ds, False, System.Data.MissingSchemaAction.Add)
				Me.InitVars()
			Else
				Me.InitClass()
			End If
			Me.GetSerializationData(info, context)
			Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
			AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
			AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
		End Sub

		<System.ComponentModel.Browsable(False), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Categories() As CategoriesDataTable
			Get
				Return Me.tableCategories
			End Get
		End Property

		<System.ComponentModel.Browsable(False), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Products() As ProductsDataTable
			Get
				Return Me.tableProducts
			End Get
		End Property

		<System.ComponentModel.Browsable(False), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
		Public ReadOnly Property Suppliers() As SuppliersDataTable
			Get
				Return Me.tableSuppliers
			End Get
		End Property

		Public Overrides Function Clone() As DataSet
			Dim cln As DataSet1 = (CType(MyBase.Clone(), DataSet1))
			cln.InitVars()
			Return cln
		End Function

		Protected Overrides Function ShouldSerializeTables() As Boolean
			Return False
		End Function

		Protected Overrides Function ShouldSerializeRelations() As Boolean
			Return False
		End Function

		Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
			Me.Reset()
			Dim ds As DataSet = New DataSet()
			ds.ReadXml(reader)
			If (Not ds.Tables("Categories") Is Nothing) Then
				Me.Tables.Add(New CategoriesDataTable(ds.Tables("Categories")))
			End If
			If (Not ds.Tables("Products") Is Nothing) Then
				Me.Tables.Add(New ProductsDataTable(ds.Tables("Products")))
			End If
			If (Not ds.Tables("Suppliers") Is Nothing) Then
				Me.Tables.Add(New SuppliersDataTable(ds.Tables("Suppliers")))
			End If
			Me.DataSetName = ds.DataSetName
			Me.Prefix = ds.Prefix
			Me.Namespace = ds.Namespace
			Me.Locale = ds.Locale
			Me.CaseSensitive = ds.CaseSensitive
			Me.EnforceConstraints = ds.EnforceConstraints
			Me.Merge(ds, False, System.Data.MissingSchemaAction.Add)
			Me.InitVars()
		End Sub

		Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
			Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream()
			Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
			stream.Position = 0
			Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
		End Function

		Friend Sub InitVars()
			Me.tableCategories = (CType(Me.Tables("Categories"), CategoriesDataTable))
			If (Not Me.tableCategories Is Nothing) Then
				Me.tableCategories.InitVars()
			End If
			Me.tableProducts = (CType(Me.Tables("Products"), ProductsDataTable))
			If (Not Me.tableProducts Is Nothing) Then
				Me.tableProducts.InitVars()
			End If
			Me.tableSuppliers = (CType(Me.Tables("Suppliers"), SuppliersDataTable))
			If (Not Me.tableSuppliers Is Nothing) Then
				Me.tableSuppliers.InitVars()
			End If
		End Sub

		Private Sub InitClass()
			Me.DataSetName = "DataSet1"
			Me.Prefix = ""
			Me.Namespace = "http://www.tempuri.org/DataSet1.xsd"
			Me.Locale = New System.Globalization.CultureInfo("en-US")
			Me.CaseSensitive = False
			Me.EnforceConstraints = True
			Me.tableCategories = New CategoriesDataTable()
			Me.Tables.Add(Me.tableCategories)
			Me.tableProducts = New ProductsDataTable()
			Me.Tables.Add(Me.tableProducts)
			Me.tableSuppliers = New SuppliersDataTable()
			Me.Tables.Add(Me.tableSuppliers)
		End Sub

		Private Function ShouldSerializeCategories() As Boolean
			Return False
		End Function

		Private Function ShouldSerializeProducts() As Boolean
			Return False
		End Function

		Private Function ShouldSerializeSuppliers() As Boolean
			Return False
		End Function

		Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
			If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
				Me.InitVars()
			End If
		End Sub

		Public Delegate Sub CategoriesRowChangeEventHandler(ByVal sender As Object, ByVal e As CategoriesRowChangeEvent)

		Public Delegate Sub ProductsRowChangeEventHandler(ByVal sender As Object, ByVal e As ProductsRowChangeEvent)

		Public Delegate Sub SuppliersRowChangeEventHandler(ByVal sender As Object, ByVal e As SuppliersRowChangeEvent)

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class CategoriesDataTable : Inherits DataTable : Implements System.Collections.IEnumerable

			Private columnCategoryID As DataColumn

			Private columnCategoryName As DataColumn

			Private columnDescription As DataColumn

			Private columnPicture As DataColumn

			Friend Sub New()
				MyBase.New("Categories")
				Me.InitClass()
			End Sub

			Friend Sub New(ByVal table As DataTable)
				MyBase.New(table.TableName)
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
				Me.DisplayExpression = table.DisplayExpression
			End Sub

			<System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			Friend ReadOnly Property CategoryIDColumn() As DataColumn
				Get
					Return Me.columnCategoryID
				End Get
			End Property

			Friend ReadOnly Property CategoryNameColumn() As DataColumn
				Get
					Return Me.columnCategoryName
				End Get
			End Property

			Friend ReadOnly Property DescriptionColumn() As DataColumn
				Get
					Return Me.columnDescription
				End Get
			End Property

			Friend ReadOnly Property PictureColumn() As DataColumn
				Get
					Return Me.columnPicture
				End Get
			End Property

			Public ReadOnly Default Property Item(ByVal index As Integer) As CategoriesRow
				Get
					Return (CType(Me.Rows(index), CategoriesRow))
				End Get
			End Property

			Public Event CategoriesRowChanged As CategoriesRowChangeEventHandler

			Public Event CategoriesRowChanging As CategoriesRowChangeEventHandler

			Public Event CategoriesRowDeleted As CategoriesRowChangeEventHandler

			Public Event CategoriesRowDeleting As CategoriesRowChangeEventHandler

			Public Sub AddCategoriesRow(ByVal row As CategoriesRow)
				Me.Rows.Add(row)
			End Sub

			Public Function AddCategoriesRow(ByVal CategoryName As String, ByVal Description As String, ByVal Picture As System.Byte()) As CategoriesRow
				Dim rowCategoriesRow As CategoriesRow = (CType(Me.NewRow(), CategoriesRow))
				rowCategoriesRow.ItemArray = New Object() { Nothing, CategoryName, Description, Picture}
				Me.Rows.Add(rowCategoriesRow)
				Return rowCategoriesRow
			End Function

			Public Function FindByCategoryID(ByVal CategoryID As Integer) As CategoriesRow
				Return (CType(Me.Rows.Find(New Object() { CategoryID}), CategoriesRow))
			End Function

			Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
				Return Me.Rows.GetEnumerator()
			End Function

			Public Overrides Overloads Function Clone() As DataTable
				Dim cln As CategoriesDataTable = (CType(MyBase.Clone(), CategoriesDataTable))
				cln.InitVars()
				Return cln
			End Function

			Protected Overrides Function CreateInstance() As DataTable
				Return New CategoriesDataTable()
			End Function

			Friend Sub InitVars()
				Me.columnCategoryID = Me.Columns("CategoryID")
				Me.columnCategoryName = Me.Columns("CategoryName")
				Me.columnDescription = Me.Columns("Description")
				Me.columnPicture = Me.Columns("Picture")
			End Sub

			Private Sub InitClass()
				Me.columnCategoryID = New DataColumn("CategoryID", GetType(Integer), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnCategoryID)
				Me.columnCategoryName = New DataColumn("CategoryName", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnCategoryName)
				Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnDescription)
				Me.columnPicture = New DataColumn("Picture", GetType(System.Byte() ), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnPicture)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() { Me.columnCategoryID}, True))
				Me.columnCategoryID.AutoIncrement = True
				Me.columnCategoryID.AllowDBNull = False
				Me.columnCategoryID.ReadOnly = True
				Me.columnCategoryID.Unique = True
				Me.columnCategoryName.AllowDBNull = False
			End Sub

			Public Function NewCategoriesRow() As CategoriesRow
				Return (CType(Me.NewRow(), CategoriesRow))
			End Function

			Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
				Return New CategoriesRow(builder)
			End Function

			Protected Overrides Function GetRowType() As System.Type
				Return GetType(CategoriesRow)
			End Function

			Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Not Me.CategoriesRowChangedEvent Is Nothing) Then
					RaiseEvent CategoriesRowChanged(Me, New CategoriesRowChangeEvent((CType(e.Row, CategoriesRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Not Me.CategoriesRowChangingEvent Is Nothing) Then
					RaiseEvent CategoriesRowChanging(Me, New CategoriesRowChangeEvent((CType(e.Row, CategoriesRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Not Me.CategoriesRowDeletedEvent Is Nothing) Then
					RaiseEvent CategoriesRowDeleted(Me, New CategoriesRowChangeEvent((CType(e.Row, CategoriesRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Not Me.CategoriesRowDeletingEvent Is Nothing) Then
					RaiseEvent CategoriesRowDeleting(Me, New CategoriesRowChangeEvent((CType(e.Row, CategoriesRow)), e.Action))
				End If
			End Sub

			Public Sub RemoveCategoriesRow(ByVal row As CategoriesRow)
				Me.Rows.Remove(row)
			End Sub
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class CategoriesRow : Inherits DataRow

			Private tableCategories As CategoriesDataTable

			Friend Sub New(ByVal rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableCategories = (CType(Me.Table, CategoriesDataTable))
			End Sub

			Public Property CategoryID() As Integer
				Get
					Return (CInt(Me(Me.tableCategories.CategoryIDColumn)))
				End Get
				Set
					Me(Me.tableCategories.CategoryIDColumn) = Value
				End Set
			End Property

			Public Property CategoryName() As String
				Get
					Return (CStr(Me(Me.tableCategories.CategoryNameColumn)))
				End Get
				Set
					Me(Me.tableCategories.CategoryNameColumn) = Value
				End Set
			End Property

			Public Property Description() As String
				Get
					Try
						Return (CStr(Me(Me.tableCategories.DescriptionColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableCategories.DescriptionColumn) = Value
				End Set
			End Property

			Public Property Picture() As System.Byte()
				Get
					Try
						Return (CType(Me(Me.tableCategories.PictureColumn), System.Byte()))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableCategories.PictureColumn) = Value
				End Set
			End Property

			Public Function IsDescriptionNull() As Boolean
				Return Me.IsNull(Me.tableCategories.DescriptionColumn)
			End Function

			Public Sub SetDescriptionNull()
				Me(Me.tableCategories.DescriptionColumn) = System.Convert.DBNull
			End Sub

			Public Function IsPictureNull() As Boolean
				Return Me.IsNull(Me.tableCategories.PictureColumn)
			End Function

			Public Sub SetPictureNull()
				Me(Me.tableCategories.PictureColumn) = System.Convert.DBNull
			End Sub
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class CategoriesRowChangeEvent : Inherits EventArgs

			Private eventRow As CategoriesRow

			Private eventAction As DataRowAction

'INSTANT VB NOTE: The parameter row was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
'INSTANT VB NOTE: The parameter action was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
			Public Sub New(ByVal row_Renamed As CategoriesRow, ByVal action_Renamed As DataRowAction)
				Me.eventRow = row_Renamed
				Me.eventAction = action_Renamed
			End Sub

			Public ReadOnly Property Row() As CategoriesRow
				Get
					Return Me.eventRow
				End Get
			End Property

			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class ProductsDataTable : Inherits DataTable : Implements System.Collections.IEnumerable

			Private columnProductID As DataColumn

			Private columnProductName As DataColumn

			Private columnSupplierID As DataColumn

			Private columnCategoryID As DataColumn

			Private columnQuantityPerUnit As DataColumn

			Private columnUnitPrice As DataColumn

			Private columnUnitsInStock As DataColumn

			Private columnUnitsOnOrder As DataColumn

			Private columnReorderLevel As DataColumn

			Private columnDiscontinued As DataColumn

			Friend Sub New()
				MyBase.New("Products")
				Me.InitClass()
			End Sub

			Friend Sub New(ByVal table As DataTable)
				MyBase.New(table.TableName)
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
				Me.DisplayExpression = table.DisplayExpression
			End Sub

			<System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			Friend ReadOnly Property ProductIDColumn() As DataColumn
				Get
					Return Me.columnProductID
				End Get
			End Property

			Friend ReadOnly Property ProductNameColumn() As DataColumn
				Get
					Return Me.columnProductName
				End Get
			End Property

			Friend ReadOnly Property SupplierIDColumn() As DataColumn
				Get
					Return Me.columnSupplierID
				End Get
			End Property

			Friend ReadOnly Property CategoryIDColumn() As DataColumn
				Get
					Return Me.columnCategoryID
				End Get
			End Property

			Friend ReadOnly Property QuantityPerUnitColumn() As DataColumn
				Get
					Return Me.columnQuantityPerUnit
				End Get
			End Property

			Friend ReadOnly Property UnitPriceColumn() As DataColumn
				Get
					Return Me.columnUnitPrice
				End Get
			End Property

			Friend ReadOnly Property UnitsInStockColumn() As DataColumn
				Get
					Return Me.columnUnitsInStock
				End Get
			End Property

			Friend ReadOnly Property UnitsOnOrderColumn() As DataColumn
				Get
					Return Me.columnUnitsOnOrder
				End Get
			End Property

			Friend ReadOnly Property ReorderLevelColumn() As DataColumn
				Get
					Return Me.columnReorderLevel
				End Get
			End Property

			Friend ReadOnly Property DiscontinuedColumn() As DataColumn
				Get
					Return Me.columnDiscontinued
				End Get
			End Property

			Public ReadOnly Default Property Item(ByVal index As Integer) As ProductsRow
				Get
					Return (CType(Me.Rows(index), ProductsRow))
				End Get
			End Property

			Public Event ProductsRowChanged As ProductsRowChangeEventHandler

			Public Event ProductsRowChanging As ProductsRowChangeEventHandler

			Public Event ProductsRowDeleted As ProductsRowChangeEventHandler

			Public Event ProductsRowDeleting As ProductsRowChangeEventHandler

			Public Sub AddProductsRow(ByVal row As ProductsRow)
				Me.Rows.Add(row)
			End Sub

			Public Function AddProductsRow(ByVal ProductName As String, ByVal SupplierID As Integer, ByVal CategoryID As Integer, ByVal QuantityPerUnit As String, ByVal UnitPrice As System.Decimal, ByVal UnitsInStock As Short, ByVal UnitsOnOrder As Short, ByVal ReorderLevel As Short, ByVal Discontinued As Boolean) As ProductsRow
				Dim rowProductsRow As ProductsRow = (CType(Me.NewRow(), ProductsRow))
				rowProductsRow.ItemArray = New Object() { Nothing, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued}
				Me.Rows.Add(rowProductsRow)
				Return rowProductsRow
			End Function

			Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
				Return Me.Rows.GetEnumerator()
			End Function

			Public Overrides Overloads Function Clone() As DataTable
				Dim cln As ProductsDataTable = (CType(MyBase.Clone(), ProductsDataTable))
				cln.InitVars()
				Return cln
			End Function

			Protected Overrides Function CreateInstance() As DataTable
				Return New ProductsDataTable()
			End Function

			Friend Sub InitVars()
				Me.columnProductID = Me.Columns("ProductID")
				Me.columnProductName = Me.Columns("ProductName")
				Me.columnSupplierID = Me.Columns("SupplierID")
				Me.columnCategoryID = Me.Columns("CategoryID")
				Me.columnQuantityPerUnit = Me.Columns("QuantityPerUnit")
				Me.columnUnitPrice = Me.Columns("UnitPrice")
				Me.columnUnitsInStock = Me.Columns("UnitsInStock")
				Me.columnUnitsOnOrder = Me.Columns("UnitsOnOrder")
				Me.columnReorderLevel = Me.Columns("ReorderLevel")
				Me.columnDiscontinued = Me.Columns("Discontinued")
			End Sub

			Private Sub InitClass()
				Me.columnProductID = New DataColumn("ProductID", GetType(Integer), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnProductID)
				Me.columnProductName = New DataColumn("ProductName", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnProductName)
				Me.columnSupplierID = New DataColumn("SupplierID", GetType(Integer), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnSupplierID)
				Me.columnCategoryID = New DataColumn("CategoryID", GetType(Integer), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnCategoryID)
				Me.columnQuantityPerUnit = New DataColumn("QuantityPerUnit", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnQuantityPerUnit)
				Me.columnUnitPrice = New DataColumn("UnitPrice", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnUnitPrice)
				Me.columnUnitsInStock = New DataColumn("UnitsInStock", GetType(Short), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnUnitsInStock)
				Me.columnUnitsOnOrder = New DataColumn("UnitsOnOrder", GetType(Short), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnUnitsOnOrder)
				Me.columnReorderLevel = New DataColumn("ReorderLevel", GetType(Short), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnReorderLevel)
				Me.columnDiscontinued = New DataColumn("Discontinued", GetType(Boolean), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnDiscontinued)
				Me.columnProductID.AutoIncrement = True
				Me.columnProductID.AllowDBNull = False
				Me.columnProductID.ReadOnly = True
				Me.columnProductName.AllowDBNull = False
				Me.columnDiscontinued.AllowDBNull = False
			End Sub

			Public Function NewProductsRow() As ProductsRow
				Return (CType(Me.NewRow(), ProductsRow))
			End Function

			Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
				Return New ProductsRow(builder)
			End Function

			Protected Overrides Function GetRowType() As System.Type
				Return GetType(ProductsRow)
			End Function

			Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Not Me.ProductsRowChangedEvent Is Nothing) Then
					RaiseEvent ProductsRowChanged(Me, New ProductsRowChangeEvent((CType(e.Row, ProductsRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Not Me.ProductsRowChangingEvent Is Nothing) Then
					RaiseEvent ProductsRowChanging(Me, New ProductsRowChangeEvent((CType(e.Row, ProductsRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Not Me.ProductsRowDeletedEvent Is Nothing) Then
					RaiseEvent ProductsRowDeleted(Me, New ProductsRowChangeEvent((CType(e.Row, ProductsRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Not Me.ProductsRowDeletingEvent Is Nothing) Then
					RaiseEvent ProductsRowDeleting(Me, New ProductsRowChangeEvent((CType(e.Row, ProductsRow)), e.Action))
				End If
			End Sub

			Public Sub RemoveProductsRow(ByVal row As ProductsRow)
				Me.Rows.Remove(row)
			End Sub
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class ProductsRow : Inherits DataRow

			Private tableProducts As ProductsDataTable

			Friend Sub New(ByVal rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableProducts = (CType(Me.Table, ProductsDataTable))
			End Sub

			Public Property ProductID() As Integer
				Get
					Return (CInt(Me(Me.tableProducts.ProductIDColumn)))
				End Get
				Set
					Me(Me.tableProducts.ProductIDColumn) = Value
				End Set
			End Property

			Public Property ProductName() As String
				Get
					Return (CStr(Me(Me.tableProducts.ProductNameColumn)))
				End Get
				Set
					Me(Me.tableProducts.ProductNameColumn) = Value
				End Set
			End Property

			Public Property SupplierID() As Integer
				Get
					Try
						Return (CInt(Me(Me.tableProducts.SupplierIDColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableProducts.SupplierIDColumn) = Value
				End Set
			End Property

			Public Property CategoryID() As Integer
				Get
					Try
						Return (CInt(Me(Me.tableProducts.CategoryIDColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableProducts.CategoryIDColumn) = Value
				End Set
			End Property

			Public Property QuantityPerUnit() As String
				Get
					Try
						Return (CStr(Me(Me.tableProducts.QuantityPerUnitColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableProducts.QuantityPerUnitColumn) = Value
				End Set
			End Property

			Public Property UnitPrice() As System.Decimal
				Get
					Try
						Return (CDec(Me(Me.tableProducts.UnitPriceColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableProducts.UnitPriceColumn) = Value
				End Set
			End Property

			Public Property UnitsInStock() As Short
				Get
					Try
						Return (CShort(Me(Me.tableProducts.UnitsInStockColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableProducts.UnitsInStockColumn) = Value
				End Set
			End Property

			Public Property UnitsOnOrder() As Short
				Get
					Try
						Return (CShort(Me(Me.tableProducts.UnitsOnOrderColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableProducts.UnitsOnOrderColumn) = Value
				End Set
			End Property

			Public Property ReorderLevel() As Short
				Get
					Try
						Return (CShort(Me(Me.tableProducts.ReorderLevelColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableProducts.ReorderLevelColumn) = Value
				End Set
			End Property

			Public Property Discontinued() As Boolean
				Get
					Return (CBool(Me(Me.tableProducts.DiscontinuedColumn)))
				End Get
				Set
					Me(Me.tableProducts.DiscontinuedColumn) = Value
				End Set
			End Property

			Public Function IsSupplierIDNull() As Boolean
				Return Me.IsNull(Me.tableProducts.SupplierIDColumn)
			End Function

			Public Sub SetSupplierIDNull()
				Me(Me.tableProducts.SupplierIDColumn) = System.Convert.DBNull
			End Sub

			Public Function IsCategoryIDNull() As Boolean
				Return Me.IsNull(Me.tableProducts.CategoryIDColumn)
			End Function

			Public Sub SetCategoryIDNull()
				Me(Me.tableProducts.CategoryIDColumn) = System.Convert.DBNull
			End Sub

			Public Function IsQuantityPerUnitNull() As Boolean
				Return Me.IsNull(Me.tableProducts.QuantityPerUnitColumn)
			End Function

			Public Sub SetQuantityPerUnitNull()
				Me(Me.tableProducts.QuantityPerUnitColumn) = System.Convert.DBNull
			End Sub

			Public Function IsUnitPriceNull() As Boolean
				Return Me.IsNull(Me.tableProducts.UnitPriceColumn)
			End Function

			Public Sub SetUnitPriceNull()
				Me(Me.tableProducts.UnitPriceColumn) = System.Convert.DBNull
			End Sub

			Public Function IsUnitsInStockNull() As Boolean
				Return Me.IsNull(Me.tableProducts.UnitsInStockColumn)
			End Function

			Public Sub SetUnitsInStockNull()
				Me(Me.tableProducts.UnitsInStockColumn) = System.Convert.DBNull
			End Sub

			Public Function IsUnitsOnOrderNull() As Boolean
				Return Me.IsNull(Me.tableProducts.UnitsOnOrderColumn)
			End Function

			Public Sub SetUnitsOnOrderNull()
				Me(Me.tableProducts.UnitsOnOrderColumn) = System.Convert.DBNull
			End Sub

			Public Function IsReorderLevelNull() As Boolean
				Return Me.IsNull(Me.tableProducts.ReorderLevelColumn)
			End Function

			Public Sub SetReorderLevelNull()
				Me(Me.tableProducts.ReorderLevelColumn) = System.Convert.DBNull
			End Sub
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class ProductsRowChangeEvent : Inherits EventArgs

			Private eventRow As ProductsRow

			Private eventAction As DataRowAction

'INSTANT VB NOTE: The parameter row was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
'INSTANT VB NOTE: The parameter action was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
			Public Sub New(ByVal row_Renamed As ProductsRow, ByVal action_Renamed As DataRowAction)
				Me.eventRow = row_Renamed
				Me.eventAction = action_Renamed
			End Sub

			Public ReadOnly Property Row() As ProductsRow
				Get
					Return Me.eventRow
				End Get
			End Property

			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class SuppliersDataTable : Inherits DataTable : Implements System.Collections.IEnumerable

			Private columnSupplierID As DataColumn

			Private columnCompanyName As DataColumn

			Private columnContactName As DataColumn

			Private columnContactTitle As DataColumn

			Private columnAddress As DataColumn

			Private columnCity As DataColumn

			Private columnRegion As DataColumn

			Private columnPostalCode As DataColumn

			Private columnCountry As DataColumn

			Private columnPhone As DataColumn

			Private columnFax As DataColumn

			Private columnHomePage As DataColumn

			Friend Sub New()
				MyBase.New("Suppliers")
				Me.InitClass()
			End Sub

			Friend Sub New(ByVal table As DataTable)
				MyBase.New(table.TableName)
				If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
					Me.CaseSensitive = table.CaseSensitive
				End If
				If (table.Locale.ToString() <> table.DataSet.Locale.ToString()) Then
					Me.Locale = table.Locale
				End If
				If (table.Namespace <> table.DataSet.Namespace) Then
					Me.Namespace = table.Namespace
				End If
				Me.Prefix = table.Prefix
				Me.MinimumCapacity = table.MinimumCapacity
				Me.DisplayExpression = table.DisplayExpression
			End Sub

			<System.ComponentModel.Browsable(False)> _
			Public ReadOnly Property Count() As Integer
				Get
					Return Me.Rows.Count
				End Get
			End Property

			Friend ReadOnly Property SupplierIDColumn() As DataColumn
				Get
					Return Me.columnSupplierID
				End Get
			End Property

			Friend ReadOnly Property CompanyNameColumn() As DataColumn
				Get
					Return Me.columnCompanyName
				End Get
			End Property

			Friend ReadOnly Property ContactNameColumn() As DataColumn
				Get
					Return Me.columnContactName
				End Get
			End Property

			Friend ReadOnly Property ContactTitleColumn() As DataColumn
				Get
					Return Me.columnContactTitle
				End Get
			End Property

			Friend ReadOnly Property AddressColumn() As DataColumn
				Get
					Return Me.columnAddress
				End Get
			End Property

			Friend ReadOnly Property CityColumn() As DataColumn
				Get
					Return Me.columnCity
				End Get
			End Property

			Friend ReadOnly Property RegionColumn() As DataColumn
				Get
					Return Me.columnRegion
				End Get
			End Property

			Friend ReadOnly Property PostalCodeColumn() As DataColumn
				Get
					Return Me.columnPostalCode
				End Get
			End Property

			Friend ReadOnly Property CountryColumn() As DataColumn
				Get
					Return Me.columnCountry
				End Get
			End Property

			Friend ReadOnly Property PhoneColumn() As DataColumn
				Get
					Return Me.columnPhone
				End Get
			End Property

			Friend ReadOnly Property FaxColumn() As DataColumn
				Get
					Return Me.columnFax
				End Get
			End Property

			Friend ReadOnly Property HomePageColumn() As DataColumn
				Get
					Return Me.columnHomePage
				End Get
			End Property

			Public ReadOnly Default Property Item(ByVal index As Integer) As SuppliersRow
				Get
					Return (CType(Me.Rows(index), SuppliersRow))
				End Get
			End Property

			Public Event SuppliersRowChanged As SuppliersRowChangeEventHandler

			Public Event SuppliersRowChanging As SuppliersRowChangeEventHandler

			Public Event SuppliersRowDeleted As SuppliersRowChangeEventHandler

			Public Event SuppliersRowDeleting As SuppliersRowChangeEventHandler

			Public Sub AddSuppliersRow(ByVal row As SuppliersRow)
				Me.Rows.Add(row)
			End Sub

			Public Function AddSuppliersRow(ByVal CompanyName As String, ByVal ContactName As String, ByVal ContactTitle As String, ByVal Address As String, ByVal City As String, ByVal Region As String, ByVal PostalCode As String, ByVal Country As String, ByVal Phone As String, ByVal Fax As String, ByVal HomePage As String) As SuppliersRow
				Dim rowSuppliersRow As SuppliersRow = (CType(Me.NewRow(), SuppliersRow))
				rowSuppliersRow.ItemArray = New Object() { Nothing, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage}
				Me.Rows.Add(rowSuppliersRow)
				Return rowSuppliersRow
			End Function

			Public Function FindBySupplierID(ByVal SupplierID As Integer) As SuppliersRow
				Return (CType(Me.Rows.Find(New Object() { SupplierID}), SuppliersRow))
			End Function

			Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
				Return Me.Rows.GetEnumerator()
			End Function

			Public Overrides Overloads Function Clone() As DataTable
				Dim cln As SuppliersDataTable = (CType(MyBase.Clone(), SuppliersDataTable))
				cln.InitVars()
				Return cln
			End Function

			Protected Overrides Function CreateInstance() As DataTable
				Return New SuppliersDataTable()
			End Function

			Friend Sub InitVars()
				Me.columnSupplierID = Me.Columns("SupplierID")
				Me.columnCompanyName = Me.Columns("CompanyName")
				Me.columnContactName = Me.Columns("ContactName")
				Me.columnContactTitle = Me.Columns("ContactTitle")
				Me.columnAddress = Me.Columns("Address")
				Me.columnCity = Me.Columns("City")
				Me.columnRegion = Me.Columns("Region")
				Me.columnPostalCode = Me.Columns("PostalCode")
				Me.columnCountry = Me.Columns("Country")
				Me.columnPhone = Me.Columns("Phone")
				Me.columnFax = Me.Columns("Fax")
				Me.columnHomePage = Me.Columns("HomePage")
			End Sub

			Private Sub InitClass()
				Me.columnSupplierID = New DataColumn("SupplierID", GetType(Integer), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnSupplierID)
				Me.columnCompanyName = New DataColumn("CompanyName", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnCompanyName)
				Me.columnContactName = New DataColumn("ContactName", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnContactName)
				Me.columnContactTitle = New DataColumn("ContactTitle", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnContactTitle)
				Me.columnAddress = New DataColumn("Address", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnAddress)
				Me.columnCity = New DataColumn("City", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnCity)
				Me.columnRegion = New DataColumn("Region", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnRegion)
				Me.columnPostalCode = New DataColumn("PostalCode", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnPostalCode)
				Me.columnCountry = New DataColumn("Country", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnCountry)
				Me.columnPhone = New DataColumn("Phone", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnPhone)
				Me.columnFax = New DataColumn("Fax", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnFax)
				Me.columnHomePage = New DataColumn("HomePage", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnHomePage)
				Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() { Me.columnSupplierID}, True))
				Me.columnSupplierID.AutoIncrement = True
				Me.columnSupplierID.AllowDBNull = False
				Me.columnSupplierID.ReadOnly = True
				Me.columnSupplierID.Unique = True
				Me.columnCompanyName.AllowDBNull = False
			End Sub

			Public Function NewSuppliersRow() As SuppliersRow
				Return (CType(Me.NewRow(), SuppliersRow))
			End Function

			Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
				Return New SuppliersRow(builder)
			End Function

			Protected Overrides Function GetRowType() As System.Type
				Return GetType(SuppliersRow)
			End Function

			Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Not Me.SuppliersRowChangedEvent Is Nothing) Then
					RaiseEvent SuppliersRowChanged(Me, New SuppliersRowChangeEvent((CType(e.Row, SuppliersRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Not Me.SuppliersRowChangingEvent Is Nothing) Then
					RaiseEvent SuppliersRowChanging(Me, New SuppliersRowChangeEvent((CType(e.Row, SuppliersRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Not Me.SuppliersRowDeletedEvent Is Nothing) Then
					RaiseEvent SuppliersRowDeleted(Me, New SuppliersRowChangeEvent((CType(e.Row, SuppliersRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Not Me.SuppliersRowDeletingEvent Is Nothing) Then
					RaiseEvent SuppliersRowDeleting(Me, New SuppliersRowChangeEvent((CType(e.Row, SuppliersRow)), e.Action))
				End If
			End Sub

			Public Sub RemoveSuppliersRow(ByVal row As SuppliersRow)
				Me.Rows.Remove(row)
			End Sub
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class SuppliersRow : Inherits DataRow

			Private tableSuppliers As SuppliersDataTable

			Friend Sub New(ByVal rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableSuppliers = (CType(Me.Table, SuppliersDataTable))
			End Sub

			Public Property SupplierID() As Integer
				Get
					Return (CInt(Me(Me.tableSuppliers.SupplierIDColumn)))
				End Get
				Set
					Me(Me.tableSuppliers.SupplierIDColumn) = Value
				End Set
			End Property

			Public Property CompanyName() As String
				Get
					Return (CStr(Me(Me.tableSuppliers.CompanyNameColumn)))
				End Get
				Set
					Me(Me.tableSuppliers.CompanyNameColumn) = Value
				End Set
			End Property

			Public Property ContactName() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.ContactNameColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.ContactNameColumn) = Value
				End Set
			End Property

			Public Property ContactTitle() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.ContactTitleColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.ContactTitleColumn) = Value
				End Set
			End Property

			Public Property Address() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.AddressColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.AddressColumn) = Value
				End Set
			End Property

			Public Property City() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.CityColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.CityColumn) = Value
				End Set
			End Property

			Public Property Region() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.RegionColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.RegionColumn) = Value
				End Set
			End Property

			Public Property PostalCode() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.PostalCodeColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.PostalCodeColumn) = Value
				End Set
			End Property

			Public Property Country() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.CountryColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.CountryColumn) = Value
				End Set
			End Property

			Public Property Phone() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.PhoneColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.PhoneColumn) = Value
				End Set
			End Property

			Public Property Fax() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.FaxColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.FaxColumn) = Value
				End Set
			End Property

			Public Property HomePage() As String
				Get
					Try
						Return (CStr(Me(Me.tableSuppliers.HomePageColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableSuppliers.HomePageColumn) = Value
				End Set
			End Property

			Public Function IsContactNameNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.ContactNameColumn)
			End Function

			Public Sub SetContactNameNull()
				Me(Me.tableSuppliers.ContactNameColumn) = System.Convert.DBNull
			End Sub

			Public Function IsContactTitleNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.ContactTitleColumn)
			End Function

			Public Sub SetContactTitleNull()
				Me(Me.tableSuppliers.ContactTitleColumn) = System.Convert.DBNull
			End Sub

			Public Function IsAddressNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.AddressColumn)
			End Function

			Public Sub SetAddressNull()
				Me(Me.tableSuppliers.AddressColumn) = System.Convert.DBNull
			End Sub

			Public Function IsCityNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.CityColumn)
			End Function

			Public Sub SetCityNull()
				Me(Me.tableSuppliers.CityColumn) = System.Convert.DBNull
			End Sub

			Public Function IsRegionNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.RegionColumn)
			End Function

			Public Sub SetRegionNull()
				Me(Me.tableSuppliers.RegionColumn) = System.Convert.DBNull
			End Sub

			Public Function IsPostalCodeNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.PostalCodeColumn)
			End Function

			Public Sub SetPostalCodeNull()
				Me(Me.tableSuppliers.PostalCodeColumn) = System.Convert.DBNull
			End Sub

			Public Function IsCountryNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.CountryColumn)
			End Function

			Public Sub SetCountryNull()
				Me(Me.tableSuppliers.CountryColumn) = System.Convert.DBNull
			End Sub

			Public Function IsPhoneNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.PhoneColumn)
			End Function

			Public Sub SetPhoneNull()
				Me(Me.tableSuppliers.PhoneColumn) = System.Convert.DBNull
			End Sub

			Public Function IsFaxNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.FaxColumn)
			End Function

			Public Sub SetFaxNull()
				Me(Me.tableSuppliers.FaxColumn) = System.Convert.DBNull
			End Sub

			Public Function IsHomePageNull() As Boolean
				Return Me.IsNull(Me.tableSuppliers.HomePageColumn)
			End Function

			Public Sub SetHomePageNull()
				Me(Me.tableSuppliers.HomePageColumn) = System.Convert.DBNull
			End Sub
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class SuppliersRowChangeEvent : Inherits EventArgs

			Private eventRow As SuppliersRow

			Private eventAction As DataRowAction

'INSTANT VB NOTE: The parameter row was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
'INSTANT VB NOTE: The parameter action was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
			Public Sub New(ByVal row_Renamed As SuppliersRow, ByVal action_Renamed As DataRowAction)
				Me.eventRow = row_Renamed
				Me.eventAction = action_Renamed
			End Sub

			Public ReadOnly Property Row() As SuppliersRow
				Get
					Return Me.eventRow
				End Get
			End Property

			Public ReadOnly Property Action() As DataRowAction
				Get
					Return Me.eventAction
				End Get
			End Property
		End Class
	End Class
End Namespace
