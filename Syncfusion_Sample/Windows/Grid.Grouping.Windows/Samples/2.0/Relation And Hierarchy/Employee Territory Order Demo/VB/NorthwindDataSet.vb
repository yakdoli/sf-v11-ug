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
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class NorthwindDataSet
    Inherits DataSet
    
    Private tableEmployees As EmployeesDataTable
    
    Private tableEmployeeTerritories As EmployeeTerritoriesDataTable
    
    Private table_Region As _RegionDataTable
    
    Private tableTerritories As TerritoriesDataTable
    
    Private tableOrders As OrdersDataTable
    
    Private tableOrder_Details As Order_DetailsDataTable
    
    Private tableProducts As ProductsDataTable
    
    Private tableSuppliers As SuppliersDataTable
    
    Private tableCategories As CategoriesDataTable
    
    Private tableShippers As ShippersDataTable
    
    Private tableCustomers As CustomersDataTable
    
    Private relationEmployeesEmployeeTerritories As DataRelation
    
    Private relationEmployeesOrders As DataRelation
    
    Private relationOrdersOrder_x0020_Details As DataRelation
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Employees")) Is Nothing) Then
                Me.Tables.Add(New EmployeesDataTable(ds.Tables("Employees")))
            End If
            If (Not (ds.Tables("EmployeeTerritories")) Is Nothing) Then
                Me.Tables.Add(New EmployeeTerritoriesDataTable(ds.Tables("EmployeeTerritories")))
            End If
            If (Not (ds.Tables("Region")) Is Nothing) Then
                Me.Tables.Add(New _RegionDataTable(ds.Tables("Region")))
            End If
            If (Not (ds.Tables("Territories")) Is Nothing) Then
                Me.Tables.Add(New TerritoriesDataTable(ds.Tables("Territories")))
            End If
            If (Not (ds.Tables("Orders")) Is Nothing) Then
                Me.Tables.Add(New OrdersDataTable(ds.Tables("Orders")))
            End If
            If (Not (ds.Tables("Order Details")) Is Nothing) Then
                Me.Tables.Add(New Order_DetailsDataTable(ds.Tables("Order Details")))
            End If
            If (Not (ds.Tables("Products")) Is Nothing) Then
                Me.Tables.Add(New ProductsDataTable(ds.Tables("Products")))
            End If
            If (Not (ds.Tables("Suppliers")) Is Nothing) Then
                Me.Tables.Add(New SuppliersDataTable(ds.Tables("Suppliers")))
            End If
            If (Not (ds.Tables("Categories")) Is Nothing) Then
                Me.Tables.Add(New CategoriesDataTable(ds.Tables("Categories")))
            End If
            If (Not (ds.Tables("Shippers")) Is Nothing) Then
                Me.Tables.Add(New ShippersDataTable(ds.Tables("Shippers")))
            End If
            If (Not (ds.Tables("Customers")) Is Nothing) Then
                Me.Tables.Add(New CustomersDataTable(ds.Tables("Customers")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Employees As EmployeesDataTable
        Get
            Return Me.tableEmployees
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property EmployeeTerritories As EmployeeTerritoriesDataTable
        Get
            Return Me.tableEmployeeTerritories
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property _Region As _RegionDataTable
        Get
            Return Me.table_Region
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Territories As TerritoriesDataTable
        Get
            Return Me.tableTerritories
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Orders As OrdersDataTable
        Get
            Return Me.tableOrders
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Order_Details As Order_DetailsDataTable
        Get
            Return Me.tableOrder_Details
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Products As ProductsDataTable
        Get
            Return Me.tableProducts
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Suppliers As SuppliersDataTable
        Get
            Return Me.tableSuppliers
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Categories As CategoriesDataTable
        Get
            Return Me.tableCategories
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Shippers As ShippersDataTable
        Get
            Return Me.tableShippers
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Customers As CustomersDataTable
        Get
            Return Me.tableCustomers
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As NorthwindDataSet = CType(MyBase.Clone,NorthwindDataSet)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Employees")) Is Nothing) Then
            Me.Tables.Add(New EmployeesDataTable(ds.Tables("Employees")))
        End If
        If (Not (ds.Tables("EmployeeTerritories")) Is Nothing) Then
            Me.Tables.Add(New EmployeeTerritoriesDataTable(ds.Tables("EmployeeTerritories")))
        End If
        If (Not (ds.Tables("Region")) Is Nothing) Then
            Me.Tables.Add(New _RegionDataTable(ds.Tables("Region")))
        End If
        If (Not (ds.Tables("Territories")) Is Nothing) Then
            Me.Tables.Add(New TerritoriesDataTable(ds.Tables("Territories")))
        End If
        If (Not (ds.Tables("Orders")) Is Nothing) Then
            Me.Tables.Add(New OrdersDataTable(ds.Tables("Orders")))
        End If
        If (Not (ds.Tables("Order Details")) Is Nothing) Then
            Me.Tables.Add(New Order_DetailsDataTable(ds.Tables("Order Details")))
        End If
        If (Not (ds.Tables("Products")) Is Nothing) Then
            Me.Tables.Add(New ProductsDataTable(ds.Tables("Products")))
        End If
        If (Not (ds.Tables("Suppliers")) Is Nothing) Then
            Me.Tables.Add(New SuppliersDataTable(ds.Tables("Suppliers")))
        End If
        If (Not (ds.Tables("Categories")) Is Nothing) Then
            Me.Tables.Add(New CategoriesDataTable(ds.Tables("Categories")))
        End If
        If (Not (ds.Tables("Shippers")) Is Nothing) Then
            Me.Tables.Add(New ShippersDataTable(ds.Tables("Shippers")))
        End If
        If (Not (ds.Tables("Customers")) Is Nothing) Then
            Me.Tables.Add(New CustomersDataTable(ds.Tables("Customers")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableEmployees = CType(Me.Tables("Employees"),EmployeesDataTable)
        If (Not (Me.tableEmployees) Is Nothing) Then
            Me.tableEmployees.InitVars
        End If
        Me.tableEmployeeTerritories = CType(Me.Tables("EmployeeTerritories"),EmployeeTerritoriesDataTable)
        If (Not (Me.tableEmployeeTerritories) Is Nothing) Then
            Me.tableEmployeeTerritories.InitVars
        End If
        Me.table_Region = CType(Me.Tables("Region"),_RegionDataTable)
        If (Not (Me.table_Region) Is Nothing) Then
            Me.table_Region.InitVars
        End If
        Me.tableTerritories = CType(Me.Tables("Territories"),TerritoriesDataTable)
        If (Not (Me.tableTerritories) Is Nothing) Then
            Me.tableTerritories.InitVars
        End If
        Me.tableOrders = CType(Me.Tables("Orders"),OrdersDataTable)
        If (Not (Me.tableOrders) Is Nothing) Then
            Me.tableOrders.InitVars
        End If
        Me.tableOrder_Details = CType(Me.Tables("Order Details"),Order_DetailsDataTable)
        If (Not (Me.tableOrder_Details) Is Nothing) Then
            Me.tableOrder_Details.InitVars
        End If
        Me.tableProducts = CType(Me.Tables("Products"),ProductsDataTable)
        If (Not (Me.tableProducts) Is Nothing) Then
            Me.tableProducts.InitVars
        End If
        Me.tableSuppliers = CType(Me.Tables("Suppliers"),SuppliersDataTable)
        If (Not (Me.tableSuppliers) Is Nothing) Then
            Me.tableSuppliers.InitVars
        End If
        Me.tableCategories = CType(Me.Tables("Categories"),CategoriesDataTable)
        If (Not (Me.tableCategories) Is Nothing) Then
            Me.tableCategories.InitVars
        End If
        Me.tableShippers = CType(Me.Tables("Shippers"),ShippersDataTable)
        If (Not (Me.tableShippers) Is Nothing) Then
            Me.tableShippers.InitVars
        End If
        Me.tableCustomers = CType(Me.Tables("Customers"),CustomersDataTable)
        If (Not (Me.tableCustomers) Is Nothing) Then
            Me.tableCustomers.InitVars
        End If
        Me.relationEmployeesEmployeeTerritories = Me.Relations("EmployeesEmployeeTerritories")
        Me.relationEmployeesOrders = Me.Relations("EmployeesOrders")
        Me.relationOrdersOrder_x0020_Details = Me.Relations("OrdersOrder_x0020_Details")
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "NorthwindDataSet"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/NorthwindDataSet.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableEmployees = New EmployeesDataTable
        Me.Tables.Add(Me.tableEmployees)
        Me.tableEmployeeTerritories = New EmployeeTerritoriesDataTable
        Me.Tables.Add(Me.tableEmployeeTerritories)
        Me.table_Region = New _RegionDataTable
        Me.Tables.Add(Me.table_Region)
        Me.tableTerritories = New TerritoriesDataTable
        Me.Tables.Add(Me.tableTerritories)
        Me.tableOrders = New OrdersDataTable
        Me.Tables.Add(Me.tableOrders)
        Me.tableOrder_Details = New Order_DetailsDataTable
        Me.Tables.Add(Me.tableOrder_Details)
        Me.tableProducts = New ProductsDataTable
        Me.Tables.Add(Me.tableProducts)
        Me.tableSuppliers = New SuppliersDataTable
        Me.Tables.Add(Me.tableSuppliers)
        Me.tableCategories = New CategoriesDataTable
        Me.Tables.Add(Me.tableCategories)
        Me.tableShippers = New ShippersDataTable
        Me.Tables.Add(Me.tableShippers)
        Me.tableCustomers = New CustomersDataTable
        Me.Tables.Add(Me.tableCustomers)
        Dim fkc As ForeignKeyConstraint
        fkc = New ForeignKeyConstraint("EmployeesEmployeeTerritories", New DataColumn() {Me.tableEmployees.EmployeeIDColumn}, New DataColumn() {Me.tableEmployeeTerritories.EmployeeIDColumn})
        Me.tableEmployeeTerritories.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        fkc = New ForeignKeyConstraint("TerritoriesEmployeeTerritories", New DataColumn() {Me.tableTerritories.TerritoryIDColumn}, New DataColumn() {Me.tableEmployeeTerritories.TerritoryIDColumn})
        Me.tableEmployeeTerritories.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        fkc = New ForeignKeyConstraint("RegionTerritories", New DataColumn() {Me.table_Region.RegionIDColumn}, New DataColumn() {Me.tableTerritories.RegionIDColumn})
        Me.tableTerritories.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        fkc = New ForeignKeyConstraint("EmployeesOrders", New DataColumn() {Me.tableEmployees.EmployeeIDColumn}, New DataColumn() {Me.tableOrders.EmployeeIDColumn})
        Me.tableOrders.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        fkc = New ForeignKeyConstraint("ShippersOrders", New DataColumn() {Me.tableShippers.ShipperIDColumn}, New DataColumn() {Me.tableOrders.ShipViaColumn})
        Me.tableOrders.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        fkc = New ForeignKeyConstraint("CustomersOrders", New DataColumn() {Me.tableCustomers.CustomerIDColumn}, New DataColumn() {Me.tableOrders.CustomerIDColumn})
        Me.tableOrders.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        fkc = New ForeignKeyConstraint("OrdersOrder_x0020_Details", New DataColumn() {Me.tableOrders.OrderIDColumn}, New DataColumn() {Me.tableOrder_Details.OrderIDColumn})
        Me.tableOrder_Details.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        fkc = New ForeignKeyConstraint("ProductsOrder_x0020_Details", New DataColumn() {Me.tableProducts.ProductIDColumn}, New DataColumn() {Me.tableOrder_Details.ProductIDColumn})
        Me.tableOrder_Details.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        fkc = New ForeignKeyConstraint("SuppliersProducts", New DataColumn() {Me.tableSuppliers.SupplierIDColumn}, New DataColumn() {Me.tableProducts.SupplierIDColumn})
        Me.tableProducts.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        fkc = New ForeignKeyConstraint("CategoriesProducts", New DataColumn() {Me.tableCategories.CategoryIDColumn}, New DataColumn() {Me.tableProducts.CategoryIDColumn})
        Me.tableProducts.Constraints.Add(fkc)
        fkc.AcceptRejectRule = AcceptRejectRule.None
        fkc.DeleteRule = Rule.Cascade
        fkc.UpdateRule = Rule.Cascade
        Me.relationEmployeesEmployeeTerritories = New DataRelation("EmployeesEmployeeTerritories", New DataColumn() {Me.tableEmployees.EmployeeIDColumn}, New DataColumn() {Me.tableEmployeeTerritories.EmployeeIDColumn}, false)
        Me.Relations.Add(Me.relationEmployeesEmployeeTerritories)
        Me.relationEmployeesOrders = New DataRelation("EmployeesOrders", New DataColumn() {Me.tableEmployees.EmployeeIDColumn}, New DataColumn() {Me.tableOrders.EmployeeIDColumn}, false)
        Me.Relations.Add(Me.relationEmployeesOrders)
        Me.relationOrdersOrder_x0020_Details = New DataRelation("OrdersOrder_x0020_Details", New DataColumn() {Me.tableOrders.OrderIDColumn}, New DataColumn() {Me.tableOrder_Details.OrderIDColumn}, false)
        Me.Relations.Add(Me.relationOrdersOrder_x0020_Details)
    End Sub
    
    Private Function ShouldSerializeEmployees() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeEmployeeTerritories() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerialize_Region() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeTerritories() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeOrders() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeOrder_Details() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeProducts() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeSuppliers() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeCategories() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeShippers() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeCustomers() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub EmployeesRowChangeEventHandler(ByVal sender As Object, ByVal e As EmployeesRowChangeEvent)
    
    Public Delegate Sub EmployeeTerritoriesRowChangeEventHandler(ByVal sender As Object, ByVal e As EmployeeTerritoriesRowChangeEvent)
    
    Public Delegate Sub _RegionRowChangeEventHandler(ByVal sender As Object, ByVal e As _RegionRowChangeEvent)
    
    Public Delegate Sub TerritoriesRowChangeEventHandler(ByVal sender As Object, ByVal e As TerritoriesRowChangeEvent)
    
    Public Delegate Sub OrdersRowChangeEventHandler(ByVal sender As Object, ByVal e As OrdersRowChangeEvent)
    
    Public Delegate Sub Order_DetailsRowChangeEventHandler(ByVal sender As Object, ByVal e As Order_DetailsRowChangeEvent)
    
    Public Delegate Sub ProductsRowChangeEventHandler(ByVal sender As Object, ByVal e As ProductsRowChangeEvent)
    
    Public Delegate Sub SuppliersRowChangeEventHandler(ByVal sender As Object, ByVal e As SuppliersRowChangeEvent)
    
    Public Delegate Sub CategoriesRowChangeEventHandler(ByVal sender As Object, ByVal e As CategoriesRowChangeEvent)
    
    Public Delegate Sub ShippersRowChangeEventHandler(ByVal sender As Object, ByVal e As ShippersRowChangeEvent)
    
    Public Delegate Sub CustomersRowChangeEventHandler(ByVal sender As Object, ByVal e As CustomersRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmployeesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnEmployeeID As DataColumn
        
        Private columnLastName As DataColumn
        
        Private columnFirstName As DataColumn
        
        Private columnTitle As DataColumn
        
        Private columnTitleOfCourtesy As DataColumn
        
        Private columnBirthDate As DataColumn
        
        Private columnHireDate As DataColumn
        
        Private columnAddress As DataColumn
        
        Private columnCity As DataColumn
        
        Private column_Region As DataColumn
        
        Private columnPostalCode As DataColumn
        
        Private columnCountry As DataColumn
        
        Private columnHomePhone As DataColumn
        
        Private columnExtension As DataColumn
        
        Private columnPhoto As DataColumn
        
        Private columnNotes As DataColumn
        
        Private columnReportsTo As DataColumn
        
        Private columnPhotoPath As DataColumn
        
        Friend Sub New()
            MyBase.New("Employees")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property EmployeeIDColumn As DataColumn
            Get
                Return Me.columnEmployeeID
            End Get
        End Property
        
        Friend ReadOnly Property LastNameColumn As DataColumn
            Get
                Return Me.columnLastName
            End Get
        End Property
        
        Friend ReadOnly Property FirstNameColumn As DataColumn
            Get
                Return Me.columnFirstName
            End Get
        End Property
        
        Friend ReadOnly Property TitleColumn As DataColumn
            Get
                Return Me.columnTitle
            End Get
        End Property
        
        Friend ReadOnly Property TitleOfCourtesyColumn As DataColumn
            Get
                Return Me.columnTitleOfCourtesy
            End Get
        End Property
        
        Friend ReadOnly Property BirthDateColumn As DataColumn
            Get
                Return Me.columnBirthDate
            End Get
        End Property
        
        Friend ReadOnly Property HireDateColumn As DataColumn
            Get
                Return Me.columnHireDate
            End Get
        End Property
        
        Friend ReadOnly Property AddressColumn As DataColumn
            Get
                Return Me.columnAddress
            End Get
        End Property
        
        Friend ReadOnly Property CityColumn As DataColumn
            Get
                Return Me.columnCity
            End Get
        End Property
        
        Friend ReadOnly Property _RegionColumn As DataColumn
            Get
                Return Me.column_Region
            End Get
        End Property
        
        Friend ReadOnly Property PostalCodeColumn As DataColumn
            Get
                Return Me.columnPostalCode
            End Get
        End Property
        
        Friend ReadOnly Property CountryColumn As DataColumn
            Get
                Return Me.columnCountry
            End Get
        End Property
        
        Friend ReadOnly Property HomePhoneColumn As DataColumn
            Get
                Return Me.columnHomePhone
            End Get
        End Property
        
        Friend ReadOnly Property ExtensionColumn As DataColumn
            Get
                Return Me.columnExtension
            End Get
        End Property
        
        Friend ReadOnly Property PhotoColumn As DataColumn
            Get
                Return Me.columnPhoto
            End Get
        End Property
        
        Friend ReadOnly Property NotesColumn As DataColumn
            Get
                Return Me.columnNotes
            End Get
        End Property
        
        Friend ReadOnly Property ReportsToColumn As DataColumn
            Get
                Return Me.columnReportsTo
            End Get
        End Property
        
        Friend ReadOnly Property PhotoPathColumn As DataColumn
            Get
                Return Me.columnPhotoPath
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As EmployeesRow
            Get
                Return CType(Me.Rows(index),EmployeesRow)
            End Get
        End Property
        
        Public Event EmployeesRowChanged As EmployeesRowChangeEventHandler
        
        Public Event EmployeesRowChanging As EmployeesRowChangeEventHandler
        
        Public Event EmployeesRowDeleted As EmployeesRowChangeEventHandler
        
        Public Event EmployeesRowDeleting As EmployeesRowChangeEventHandler
        
        Public Overloads Sub AddEmployeesRow(ByVal row As EmployeesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddEmployeesRow( _
                    ByVal LastName As String,  _
                    ByVal FirstName As String,  _
                    ByVal Title As String,  _
                    ByVal TitleOfCourtesy As String,  _
                    ByVal BirthDate As Date,  _
                    ByVal HireDate As Date,  _
                    ByVal Address As String,  _
                    ByVal City As String,  _
                    ByVal _Region As String,  _
                    ByVal PostalCode As String,  _
                    ByVal Country As String,  _
                    ByVal HomePhone As String,  _
                    ByVal Extension As String,  _
                    ByVal Photo() As Byte,  _
                    ByVal Notes As String,  _
                    ByVal ReportsTo As Integer,  _
                    ByVal PhotoPath As String) As EmployeesRow
            Dim rowEmployeesRow As EmployeesRow = CType(Me.NewRow,EmployeesRow)
            rowEmployeesRow.ItemArray = New Object() {Nothing, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, _Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath}
            Me.Rows.Add(rowEmployeesRow)
            Return rowEmployeesRow
        End Function
        
        Public Function FindByEmployeeID(ByVal EmployeeID As Integer) As EmployeesRow
            Return CType(Me.Rows.Find(New Object() {EmployeeID}),EmployeesRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As EmployeesDataTable = CType(MyBase.Clone,EmployeesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New EmployeesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnEmployeeID = Me.Columns("EmployeeID")
            Me.columnLastName = Me.Columns("LastName")
            Me.columnFirstName = Me.Columns("FirstName")
            Me.columnTitle = Me.Columns("Title")
            Me.columnTitleOfCourtesy = Me.Columns("TitleOfCourtesy")
            Me.columnBirthDate = Me.Columns("BirthDate")
            Me.columnHireDate = Me.Columns("HireDate")
            Me.columnAddress = Me.Columns("Address")
            Me.columnCity = Me.Columns("City")
            Me.column_Region = Me.Columns("Region")
            Me.columnPostalCode = Me.Columns("PostalCode")
            Me.columnCountry = Me.Columns("Country")
            Me.columnHomePhone = Me.Columns("HomePhone")
            Me.columnExtension = Me.Columns("Extension")
            Me.columnPhoto = Me.Columns("Photo")
            Me.columnNotes = Me.Columns("Notes")
            Me.columnReportsTo = Me.Columns("ReportsTo")
            Me.columnPhotoPath = Me.Columns("PhotoPath")
        End Sub
        
        Private Sub InitClass()
            Me.columnEmployeeID = New DataColumn("EmployeeID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEmployeeID)
            Me.columnLastName = New DataColumn("LastName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnLastName)
            Me.columnFirstName = New DataColumn("FirstName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFirstName)
            Me.columnTitle = New DataColumn("Title", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTitle)
            Me.columnTitleOfCourtesy = New DataColumn("TitleOfCourtesy", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTitleOfCourtesy)
            Me.columnBirthDate = New DataColumn("BirthDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnBirthDate)
            Me.columnHireDate = New DataColumn("HireDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnHireDate)
            Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress)
            Me.columnCity = New DataColumn("City", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCity)
            Me.column_Region = New DataColumn("Region", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_Region)
            Me.columnPostalCode = New DataColumn("PostalCode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPostalCode)
            Me.columnCountry = New DataColumn("Country", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCountry)
            Me.columnHomePhone = New DataColumn("HomePhone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnHomePhone)
            Me.columnExtension = New DataColumn("Extension", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnExtension)
            Me.columnPhoto = New DataColumn("Photo", GetType(System.Byte()), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhoto)
            Me.columnNotes = New DataColumn("Notes", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNotes)
            Me.columnReportsTo = New DataColumn("ReportsTo", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnReportsTo)
            Me.columnPhotoPath = New DataColumn("PhotoPath", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhotoPath)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnEmployeeID}, true))
            Me.columnEmployeeID.AutoIncrement = true
            Me.columnEmployeeID.AllowDBNull = false
            Me.columnEmployeeID.ReadOnly = true
            Me.columnEmployeeID.Unique = true
            Me.columnLastName.AllowDBNull = false
            Me.columnFirstName.AllowDBNull = false
        End Sub
        
        Public Function NewEmployeesRow() As EmployeesRow
            Return CType(Me.NewRow,EmployeesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New EmployeesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(EmployeesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.EmployeesRowChangedEvent) Is Nothing) Then
                RaiseEvent EmployeesRowChanged(Me, New EmployeesRowChangeEvent(CType(e.Row,EmployeesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.EmployeesRowChangingEvent) Is Nothing) Then
                RaiseEvent EmployeesRowChanging(Me, New EmployeesRowChangeEvent(CType(e.Row,EmployeesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.EmployeesRowDeletedEvent) Is Nothing) Then
                RaiseEvent EmployeesRowDeleted(Me, New EmployeesRowChangeEvent(CType(e.Row,EmployeesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.EmployeesRowDeletingEvent) Is Nothing) Then
                RaiseEvent EmployeesRowDeleting(Me, New EmployeesRowChangeEvent(CType(e.Row,EmployeesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveEmployeesRow(ByVal row As EmployeesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmployeesRow
        Inherits DataRow
        
        Private tableEmployees As EmployeesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableEmployees = CType(Me.Table,EmployeesDataTable)
        End Sub
        
        Public Property EmployeeID As Integer
            Get
                Return CType(Me(Me.tableEmployees.EmployeeIDColumn),Integer)
            End Get
            Set
                Me(Me.tableEmployees.EmployeeIDColumn) = value
            End Set
        End Property
        
        Public Property LastName As String
            Get
                Return CType(Me(Me.tableEmployees.LastNameColumn),String)
            End Get
            Set
                Me(Me.tableEmployees.LastNameColumn) = value
            End Set
        End Property
        
        Public Property FirstName As String
            Get
                Return CType(Me(Me.tableEmployees.FirstNameColumn),String)
            End Get
            Set
                Me(Me.tableEmployees.FirstNameColumn) = value
            End Set
        End Property
        
        Public Property Title As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.TitleColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.TitleColumn) = value
            End Set
        End Property
        
        Public Property TitleOfCourtesy As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.TitleOfCourtesyColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.TitleOfCourtesyColumn) = value
            End Set
        End Property
        
        Public Property BirthDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.BirthDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.BirthDateColumn) = value
            End Set
        End Property
        
        Public Property HireDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.HireDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.HireDateColumn) = value
            End Set
        End Property
        
        Public Property Address As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.AddressColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.AddressColumn) = value
            End Set
        End Property
        
        Public Property City As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.CityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.CityColumn) = value
            End Set
        End Property
        
        Public Property _Region As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees._RegionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees._RegionColumn) = value
            End Set
        End Property
        
        Public Property PostalCode As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.PostalCodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.PostalCodeColumn) = value
            End Set
        End Property
        
        Public Property Country As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.CountryColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.CountryColumn) = value
            End Set
        End Property
        
        Public Property HomePhone As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.HomePhoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.HomePhoneColumn) = value
            End Set
        End Property
        
        Public Property Extension As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.ExtensionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.ExtensionColumn) = value
            End Set
        End Property
        
        Public Property Photo As Byte()
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.PhotoColumn),Byte())
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.PhotoColumn) = value
            End Set
        End Property
        
        Public Property Notes As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.NotesColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.NotesColumn) = value
            End Set
        End Property
        
        Public Property ReportsTo As Integer
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.ReportsToColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.ReportsToColumn) = value
            End Set
        End Property
        
        Public Property PhotoPath As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.PhotoPathColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.PhotoPathColumn) = value
            End Set
        End Property
        
        Public Function IsTitleNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.TitleColumn)
        End Function
        
        Public Sub SetTitleNull()
            Me(Me.tableEmployees.TitleColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTitleOfCourtesyNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.TitleOfCourtesyColumn)
        End Function
        
        Public Sub SetTitleOfCourtesyNull()
            Me(Me.tableEmployees.TitleOfCourtesyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsBirthDateNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.BirthDateColumn)
        End Function
        
        Public Sub SetBirthDateNull()
            Me(Me.tableEmployees.BirthDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsHireDateNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.HireDateColumn)
        End Function
        
        Public Sub SetHireDateNull()
            Me(Me.tableEmployees.HireDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAddressNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.AddressColumn)
        End Function
        
        Public Sub SetAddressNull()
            Me(Me.tableEmployees.AddressColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCityNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.CityColumn)
        End Function
        
        Public Sub SetCityNull()
            Me(Me.tableEmployees.CityColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Is_RegionNull() As Boolean
            Return Me.IsNull(Me.tableEmployees._RegionColumn)
        End Function
        
        Public Sub Set_RegionNull()
            Me(Me.tableEmployees._RegionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPostalCodeNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.PostalCodeColumn)
        End Function
        
        Public Sub SetPostalCodeNull()
            Me(Me.tableEmployees.PostalCodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCountryNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.CountryColumn)
        End Function
        
        Public Sub SetCountryNull()
            Me(Me.tableEmployees.CountryColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsHomePhoneNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.HomePhoneColumn)
        End Function
        
        Public Sub SetHomePhoneNull()
            Me(Me.tableEmployees.HomePhoneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsExtensionNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.ExtensionColumn)
        End Function
        
        Public Sub SetExtensionNull()
            Me(Me.tableEmployees.ExtensionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhotoNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.PhotoColumn)
        End Function
        
        Public Sub SetPhotoNull()
            Me(Me.tableEmployees.PhotoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsNotesNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.NotesColumn)
        End Function
        
        Public Sub SetNotesNull()
            Me(Me.tableEmployees.NotesColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsReportsToNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.ReportsToColumn)
        End Function
        
        Public Sub SetReportsToNull()
            Me(Me.tableEmployees.ReportsToColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhotoPathNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.PhotoPathColumn)
        End Function
        
        Public Sub SetPhotoPathNull()
            Me(Me.tableEmployees.PhotoPathColumn) = System.Convert.DBNull
        End Sub
        
        Public Function GetEmployeeTerritoriesRows() As EmployeeTerritoriesRow()
            Return CType(Me.GetChildRows(Me.Table.ChildRelations("EmployeesEmployeeTerritories")),EmployeeTerritoriesRow())
        End Function
        
        Public Function GetOrdersRows() As OrdersRow()
            Return CType(Me.GetChildRows(Me.Table.ChildRelations("EmployeesOrders")),OrdersRow())
        End Function
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmployeesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As EmployeesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As EmployeesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As EmployeesRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmployeeTerritoriesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnEmployeeID As DataColumn
        
        Private columnTerritoryID As DataColumn
        
        Friend Sub New()
            MyBase.New("EmployeeTerritories")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property EmployeeIDColumn As DataColumn
            Get
                Return Me.columnEmployeeID
            End Get
        End Property
        
        Friend ReadOnly Property TerritoryIDColumn As DataColumn
            Get
                Return Me.columnTerritoryID
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As EmployeeTerritoriesRow
            Get
                Return CType(Me.Rows(index),EmployeeTerritoriesRow)
            End Get
        End Property
        
        Public Event EmployeeTerritoriesRowChanged As EmployeeTerritoriesRowChangeEventHandler
        
        Public Event EmployeeTerritoriesRowChanging As EmployeeTerritoriesRowChangeEventHandler
        
        Public Event EmployeeTerritoriesRowDeleted As EmployeeTerritoriesRowChangeEventHandler
        
        Public Event EmployeeTerritoriesRowDeleting As EmployeeTerritoriesRowChangeEventHandler
        
        Public Overloads Sub AddEmployeeTerritoriesRow(ByVal row As EmployeeTerritoriesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddEmployeeTerritoriesRow(ByVal parentEmployeesRowByEmployeesEmployeeTerritories As EmployeesRow, ByVal TerritoryID As String) As EmployeeTerritoriesRow
            Dim rowEmployeeTerritoriesRow As EmployeeTerritoriesRow = CType(Me.NewRow,EmployeeTerritoriesRow)
            rowEmployeeTerritoriesRow.ItemArray = New Object() {parentEmployeesRowByEmployeesEmployeeTerritories(0), TerritoryID}
            Me.Rows.Add(rowEmployeeTerritoriesRow)
            Return rowEmployeeTerritoriesRow
        End Function
        
        Public Function FindByEmployeeIDTerritoryID(ByVal EmployeeID As Integer, ByVal TerritoryID As String) As EmployeeTerritoriesRow
            Return CType(Me.Rows.Find(New Object() {EmployeeID, TerritoryID}),EmployeeTerritoriesRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As EmployeeTerritoriesDataTable = CType(MyBase.Clone,EmployeeTerritoriesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New EmployeeTerritoriesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnEmployeeID = Me.Columns("EmployeeID")
            Me.columnTerritoryID = Me.Columns("TerritoryID")
        End Sub
        
        Private Sub InitClass()
            Me.columnEmployeeID = New DataColumn("EmployeeID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEmployeeID)
            Me.columnTerritoryID = New DataColumn("TerritoryID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTerritoryID)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnEmployeeID, Me.columnTerritoryID}, true))
            Me.columnEmployeeID.AllowDBNull = false
            Me.columnTerritoryID.AllowDBNull = false
        End Sub
        
        Public Function NewEmployeeTerritoriesRow() As EmployeeTerritoriesRow
            Return CType(Me.NewRow,EmployeeTerritoriesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New EmployeeTerritoriesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(EmployeeTerritoriesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.EmployeeTerritoriesRowChangedEvent) Is Nothing) Then
                RaiseEvent EmployeeTerritoriesRowChanged(Me, New EmployeeTerritoriesRowChangeEvent(CType(e.Row,EmployeeTerritoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.EmployeeTerritoriesRowChangingEvent) Is Nothing) Then
                RaiseEvent EmployeeTerritoriesRowChanging(Me, New EmployeeTerritoriesRowChangeEvent(CType(e.Row,EmployeeTerritoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.EmployeeTerritoriesRowDeletedEvent) Is Nothing) Then
                RaiseEvent EmployeeTerritoriesRowDeleted(Me, New EmployeeTerritoriesRowChangeEvent(CType(e.Row,EmployeeTerritoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.EmployeeTerritoriesRowDeletingEvent) Is Nothing) Then
                RaiseEvent EmployeeTerritoriesRowDeleting(Me, New EmployeeTerritoriesRowChangeEvent(CType(e.Row,EmployeeTerritoriesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveEmployeeTerritoriesRow(ByVal row As EmployeeTerritoriesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmployeeTerritoriesRow
        Inherits DataRow
        
        Private tableEmployeeTerritories As EmployeeTerritoriesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableEmployeeTerritories = CType(Me.Table,EmployeeTerritoriesDataTable)
        End Sub
        
        Public Property EmployeeID As Integer
            Get
                Return CType(Me(Me.tableEmployeeTerritories.EmployeeIDColumn),Integer)
            End Get
            Set
                Me(Me.tableEmployeeTerritories.EmployeeIDColumn) = value
            End Set
        End Property
        
        Public Property TerritoryID As String
            Get
                Return CType(Me(Me.tableEmployeeTerritories.TerritoryIDColumn),String)
            End Get
            Set
                Me(Me.tableEmployeeTerritories.TerritoryIDColumn) = value
            End Set
        End Property
        
        Public Property EmployeesRow As EmployeesRow
            Get
                Return CType(Me.GetParentRow(Me.Table.ParentRelations("EmployeesEmployeeTerritories")),EmployeesRow)
            End Get
            Set
                Me.SetParentRow(value, Me.Table.ParentRelations("EmployeesEmployeeTerritories"))
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmployeeTerritoriesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As EmployeeTerritoriesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As EmployeeTerritoriesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As EmployeeTerritoriesRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class _RegionDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnRegionID As DataColumn
        
        Private columnRegionDescription As DataColumn
        
        Friend Sub New()
            MyBase.New("Region")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property RegionIDColumn As DataColumn
            Get
                Return Me.columnRegionID
            End Get
        End Property
        
        Friend ReadOnly Property RegionDescriptionColumn As DataColumn
            Get
                Return Me.columnRegionDescription
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As _RegionRow
            Get
                Return CType(Me.Rows(index),_RegionRow)
            End Get
        End Property
        
        Public Event _RegionRowChanged As _RegionRowChangeEventHandler
        
        Public Event _RegionRowChanging As _RegionRowChangeEventHandler
        
        Public Event _RegionRowDeleted As _RegionRowChangeEventHandler
        
        Public Event _RegionRowDeleting As _RegionRowChangeEventHandler
        
        Public Overloads Sub Add_RegionRow(ByVal row As _RegionRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function Add_RegionRow(ByVal RegionID As Integer, ByVal RegionDescription As String) As _RegionRow
            Dim row_RegionRow As _RegionRow = CType(Me.NewRow,_RegionRow)
            row_RegionRow.ItemArray = New Object() {RegionID, RegionDescription}
            Me.Rows.Add(row_RegionRow)
            Return row_RegionRow
        End Function
        
        Public Function FindByRegionID(ByVal RegionID As Integer) As _RegionRow
            Return CType(Me.Rows.Find(New Object() {RegionID}),_RegionRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As _RegionDataTable = CType(MyBase.Clone,_RegionDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New _RegionDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnRegionID = Me.Columns("RegionID")
            Me.columnRegionDescription = Me.Columns("RegionDescription")
        End Sub
        
        Private Sub InitClass()
            Me.columnRegionID = New DataColumn("RegionID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRegionID)
            Me.columnRegionDescription = New DataColumn("RegionDescription", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRegionDescription)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnRegionID}, true))
            Me.columnRegionID.AllowDBNull = false
            Me.columnRegionID.Unique = true
            Me.columnRegionDescription.AllowDBNull = false
        End Sub
        
        Public Function New_RegionRow() As _RegionRow
            Return CType(Me.NewRow,_RegionRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New _RegionRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(_RegionRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me._RegionRowChangedEvent) Is Nothing) Then
                RaiseEvent _RegionRowChanged(Me, New _RegionRowChangeEvent(CType(e.Row,_RegionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me._RegionRowChangingEvent) Is Nothing) Then
                RaiseEvent _RegionRowChanging(Me, New _RegionRowChangeEvent(CType(e.Row,_RegionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me._RegionRowDeletedEvent) Is Nothing) Then
                RaiseEvent _RegionRowDeleted(Me, New _RegionRowChangeEvent(CType(e.Row,_RegionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me._RegionRowDeletingEvent) Is Nothing) Then
                RaiseEvent _RegionRowDeleting(Me, New _RegionRowChangeEvent(CType(e.Row,_RegionRow), e.Action))
            End If
        End Sub
        
        Public Sub Remove_RegionRow(ByVal row As _RegionRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class _RegionRow
        Inherits DataRow
        
        Private table_Region As _RegionDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.table_Region = CType(Me.Table,_RegionDataTable)
        End Sub
        
        Public Property RegionID As Integer
            Get
                Return CType(Me(Me.table_Region.RegionIDColumn),Integer)
            End Get
            Set
                Me(Me.table_Region.RegionIDColumn) = value
            End Set
        End Property
        
        Public Property RegionDescription As String
            Get
                Return CType(Me(Me.table_Region.RegionDescriptionColumn),String)
            End Get
            Set
                Me(Me.table_Region.RegionDescriptionColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class _RegionRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As _RegionRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As _RegionRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As _RegionRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TerritoriesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnTerritoryID As DataColumn
        
        Private columnTerritoryDescription As DataColumn
        
        Private columnRegionID As DataColumn
        
        Friend Sub New()
            MyBase.New("Territories")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property TerritoryIDColumn As DataColumn
            Get
                Return Me.columnTerritoryID
            End Get
        End Property
        
        Friend ReadOnly Property TerritoryDescriptionColumn As DataColumn
            Get
                Return Me.columnTerritoryDescription
            End Get
        End Property
        
        Friend ReadOnly Property RegionIDColumn As DataColumn
            Get
                Return Me.columnRegionID
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As TerritoriesRow
            Get
                Return CType(Me.Rows(index),TerritoriesRow)
            End Get
        End Property
        
        Public Event TerritoriesRowChanged As TerritoriesRowChangeEventHandler
        
        Public Event TerritoriesRowChanging As TerritoriesRowChangeEventHandler
        
        Public Event TerritoriesRowDeleted As TerritoriesRowChangeEventHandler
        
        Public Event TerritoriesRowDeleting As TerritoriesRowChangeEventHandler
        
        Public Overloads Sub AddTerritoriesRow(ByVal row As TerritoriesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddTerritoriesRow(ByVal TerritoryID As String, ByVal TerritoryDescription As String, ByVal RegionID As Integer) As TerritoriesRow
            Dim rowTerritoriesRow As TerritoriesRow = CType(Me.NewRow,TerritoriesRow)
            rowTerritoriesRow.ItemArray = New Object() {TerritoryID, TerritoryDescription, RegionID}
            Me.Rows.Add(rowTerritoriesRow)
            Return rowTerritoriesRow
        End Function
        
        Public Function FindByTerritoryID(ByVal TerritoryID As String) As TerritoriesRow
            Return CType(Me.Rows.Find(New Object() {TerritoryID}),TerritoriesRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As TerritoriesDataTable = CType(MyBase.Clone,TerritoriesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New TerritoriesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnTerritoryID = Me.Columns("TerritoryID")
            Me.columnTerritoryDescription = Me.Columns("TerritoryDescription")
            Me.columnRegionID = Me.Columns("RegionID")
        End Sub
        
        Private Sub InitClass()
            Me.columnTerritoryID = New DataColumn("TerritoryID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTerritoryID)
            Me.columnTerritoryDescription = New DataColumn("TerritoryDescription", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTerritoryDescription)
            Me.columnRegionID = New DataColumn("RegionID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRegionID)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnTerritoryID}, true))
            Me.columnTerritoryID.AllowDBNull = false
            Me.columnTerritoryID.Unique = true
            Me.columnTerritoryDescription.AllowDBNull = false
            Me.columnRegionID.AllowDBNull = false
        End Sub
        
        Public Function NewTerritoriesRow() As TerritoriesRow
            Return CType(Me.NewRow,TerritoriesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New TerritoriesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(TerritoriesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.TerritoriesRowChangedEvent) Is Nothing) Then
                RaiseEvent TerritoriesRowChanged(Me, New TerritoriesRowChangeEvent(CType(e.Row,TerritoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.TerritoriesRowChangingEvent) Is Nothing) Then
                RaiseEvent TerritoriesRowChanging(Me, New TerritoriesRowChangeEvent(CType(e.Row,TerritoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.TerritoriesRowDeletedEvent) Is Nothing) Then
                RaiseEvent TerritoriesRowDeleted(Me, New TerritoriesRowChangeEvent(CType(e.Row,TerritoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.TerritoriesRowDeletingEvent) Is Nothing) Then
                RaiseEvent TerritoriesRowDeleting(Me, New TerritoriesRowChangeEvent(CType(e.Row,TerritoriesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveTerritoriesRow(ByVal row As TerritoriesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TerritoriesRow
        Inherits DataRow
        
        Private tableTerritories As TerritoriesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableTerritories = CType(Me.Table,TerritoriesDataTable)
        End Sub
        
        Public Property TerritoryID As String
            Get
                Return CType(Me(Me.tableTerritories.TerritoryIDColumn),String)
            End Get
            Set
                Me(Me.tableTerritories.TerritoryIDColumn) = value
            End Set
        End Property
        
        Public Property TerritoryDescription As String
            Get
                Return CType(Me(Me.tableTerritories.TerritoryDescriptionColumn),String)
            End Get
            Set
                Me(Me.tableTerritories.TerritoryDescriptionColumn) = value
            End Set
        End Property
        
        Public Property RegionID As Integer
            Get
                Return CType(Me(Me.tableTerritories.RegionIDColumn),Integer)
            End Get
            Set
                Me(Me.tableTerritories.RegionIDColumn) = value
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class TerritoriesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As TerritoriesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As TerritoriesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As TerritoriesRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class OrdersDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnOrderID As DataColumn
        
        Private columnCustomerID As DataColumn
        
        Private columnEmployeeID As DataColumn
        
        Private columnOrderDate As DataColumn
        
        Private columnRequiredDate As DataColumn
        
        Private columnShippedDate As DataColumn
        
        Private columnShipVia As DataColumn
        
        Private columnFreight As DataColumn
        
        Private columnShipName As DataColumn
        
        Private columnShipAddress As DataColumn
        
        Private columnShipCity As DataColumn
        
        Private columnShipRegion As DataColumn
        
        Private columnShipPostalCode As DataColumn
        
        Private columnShipCountry As DataColumn
        
        Friend Sub New()
            MyBase.New("Orders")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property OrderIDColumn As DataColumn
            Get
                Return Me.columnOrderID
            End Get
        End Property
        
        Friend ReadOnly Property CustomerIDColumn As DataColumn
            Get
                Return Me.columnCustomerID
            End Get
        End Property
        
        Friend ReadOnly Property EmployeeIDColumn As DataColumn
            Get
                Return Me.columnEmployeeID
            End Get
        End Property
        
        Friend ReadOnly Property OrderDateColumn As DataColumn
            Get
                Return Me.columnOrderDate
            End Get
        End Property
        
        Friend ReadOnly Property RequiredDateColumn As DataColumn
            Get
                Return Me.columnRequiredDate
            End Get
        End Property
        
        Friend ReadOnly Property ShippedDateColumn As DataColumn
            Get
                Return Me.columnShippedDate
            End Get
        End Property
        
        Friend ReadOnly Property ShipViaColumn As DataColumn
            Get
                Return Me.columnShipVia
            End Get
        End Property
        
        Friend ReadOnly Property FreightColumn As DataColumn
            Get
                Return Me.columnFreight
            End Get
        End Property
        
        Friend ReadOnly Property ShipNameColumn As DataColumn
            Get
                Return Me.columnShipName
            End Get
        End Property
        
        Friend ReadOnly Property ShipAddressColumn As DataColumn
            Get
                Return Me.columnShipAddress
            End Get
        End Property
        
        Friend ReadOnly Property ShipCityColumn As DataColumn
            Get
                Return Me.columnShipCity
            End Get
        End Property
        
        Friend ReadOnly Property ShipRegionColumn As DataColumn
            Get
                Return Me.columnShipRegion
            End Get
        End Property
        
        Friend ReadOnly Property ShipPostalCodeColumn As DataColumn
            Get
                Return Me.columnShipPostalCode
            End Get
        End Property
        
        Friend ReadOnly Property ShipCountryColumn As DataColumn
            Get
                Return Me.columnShipCountry
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As OrdersRow
            Get
                Return CType(Me.Rows(index),OrdersRow)
            End Get
        End Property
        
        Public Event OrdersRowChanged As OrdersRowChangeEventHandler
        
        Public Event OrdersRowChanging As OrdersRowChangeEventHandler
        
        Public Event OrdersRowDeleted As OrdersRowChangeEventHandler
        
        Public Event OrdersRowDeleting As OrdersRowChangeEventHandler
        
        Public Overloads Sub AddOrdersRow(ByVal row As OrdersRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddOrdersRow(ByVal CustomerID As String, ByVal parentEmployeesRowByEmployeesOrders As EmployeesRow, ByVal OrderDate As Date, ByVal RequiredDate As Date, ByVal ShippedDate As Date, ByVal ShipVia As Integer, ByVal Freight As Decimal, ByVal ShipName As String, ByVal ShipAddress As String, ByVal ShipCity As String, ByVal ShipRegion As String, ByVal ShipPostalCode As String, ByVal ShipCountry As String) As OrdersRow
            Dim rowOrdersRow As OrdersRow = CType(Me.NewRow,OrdersRow)
            rowOrdersRow.ItemArray = New Object() {Nothing, CustomerID, parentEmployeesRowByEmployeesOrders(0), OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry}
            Me.Rows.Add(rowOrdersRow)
            Return rowOrdersRow
        End Function
        
        Public Function FindByOrderID(ByVal OrderID As Integer) As OrdersRow
            Return CType(Me.Rows.Find(New Object() {OrderID}),OrdersRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As OrdersDataTable = CType(MyBase.Clone,OrdersDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New OrdersDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnOrderID = Me.Columns("OrderID")
            Me.columnCustomerID = Me.Columns("CustomerID")
            Me.columnEmployeeID = Me.Columns("EmployeeID")
            Me.columnOrderDate = Me.Columns("OrderDate")
            Me.columnRequiredDate = Me.Columns("RequiredDate")
            Me.columnShippedDate = Me.Columns("ShippedDate")
            Me.columnShipVia = Me.Columns("ShipVia")
            Me.columnFreight = Me.Columns("Freight")
            Me.columnShipName = Me.Columns("ShipName")
            Me.columnShipAddress = Me.Columns("ShipAddress")
            Me.columnShipCity = Me.Columns("ShipCity")
            Me.columnShipRegion = Me.Columns("ShipRegion")
            Me.columnShipPostalCode = Me.Columns("ShipPostalCode")
            Me.columnShipCountry = Me.Columns("ShipCountry")
        End Sub
        
        Private Sub InitClass()
            Me.columnOrderID = New DataColumn("OrderID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrderID)
            Me.columnCustomerID = New DataColumn("CustomerID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCustomerID)
            Me.columnEmployeeID = New DataColumn("EmployeeID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEmployeeID)
            Me.columnOrderDate = New DataColumn("OrderDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrderDate)
            Me.columnRequiredDate = New DataColumn("RequiredDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRequiredDate)
            Me.columnShippedDate = New DataColumn("ShippedDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShippedDate)
            Me.columnShipVia = New DataColumn("ShipVia", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipVia)
            Me.columnFreight = New DataColumn("Freight", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFreight)
            Me.columnShipName = New DataColumn("ShipName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipName)
            Me.columnShipAddress = New DataColumn("ShipAddress", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipAddress)
            Me.columnShipCity = New DataColumn("ShipCity", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipCity)
            Me.columnShipRegion = New DataColumn("ShipRegion", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipRegion)
            Me.columnShipPostalCode = New DataColumn("ShipPostalCode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipPostalCode)
            Me.columnShipCountry = New DataColumn("ShipCountry", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipCountry)
            Me.Constraints.Add(New UniqueConstraint("NorthwindDataSetKey1", New DataColumn() {Me.columnOrderID}, true))
            Me.columnOrderID.AutoIncrement = true
            Me.columnOrderID.AllowDBNull = false
            Me.columnOrderID.ReadOnly = true
            Me.columnOrderID.Unique = true
        End Sub
        
        Public Function NewOrdersRow() As OrdersRow
            Return CType(Me.NewRow,OrdersRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New OrdersRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(OrdersRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.OrdersRowChangedEvent) Is Nothing) Then
                RaiseEvent OrdersRowChanged(Me, New OrdersRowChangeEvent(CType(e.Row,OrdersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.OrdersRowChangingEvent) Is Nothing) Then
                RaiseEvent OrdersRowChanging(Me, New OrdersRowChangeEvent(CType(e.Row,OrdersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.OrdersRowDeletedEvent) Is Nothing) Then
                RaiseEvent OrdersRowDeleted(Me, New OrdersRowChangeEvent(CType(e.Row,OrdersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.OrdersRowDeletingEvent) Is Nothing) Then
                RaiseEvent OrdersRowDeleting(Me, New OrdersRowChangeEvent(CType(e.Row,OrdersRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveOrdersRow(ByVal row As OrdersRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class OrdersRow
        Inherits DataRow
        
        Private tableOrders As OrdersDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableOrders = CType(Me.Table,OrdersDataTable)
        End Sub
        
        Public Property OrderID As Integer
            Get
                Return CType(Me(Me.tableOrders.OrderIDColumn),Integer)
            End Get
            Set
                Me(Me.tableOrders.OrderIDColumn) = value
            End Set
        End Property
        
        Public Property CustomerID As String
            Get
                Try 
                    Return CType(Me(Me.tableOrders.CustomerIDColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.CustomerIDColumn) = value
            End Set
        End Property
        
        Public Property EmployeeID As Integer
            Get
                Try 
                    Return CType(Me(Me.tableOrders.EmployeeIDColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.EmployeeIDColumn) = value
            End Set
        End Property
        
        Public Property OrderDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableOrders.OrderDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.OrderDateColumn) = value
            End Set
        End Property
        
        Public Property RequiredDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableOrders.RequiredDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.RequiredDateColumn) = value
            End Set
        End Property
        
        Public Property ShippedDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableOrders.ShippedDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.ShippedDateColumn) = value
            End Set
        End Property
        
        Public Property ShipVia As Integer
            Get
                Try 
                    Return CType(Me(Me.tableOrders.ShipViaColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.ShipViaColumn) = value
            End Set
        End Property
        
        Public Property Freight As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableOrders.FreightColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.FreightColumn) = value
            End Set
        End Property
        
        Public Property ShipName As String
            Get
                Try 
                    Return CType(Me(Me.tableOrders.ShipNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.ShipNameColumn) = value
            End Set
        End Property
        
        Public Property ShipAddress As String
            Get
                Try 
                    Return CType(Me(Me.tableOrders.ShipAddressColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.ShipAddressColumn) = value
            End Set
        End Property
        
        Public Property ShipCity As String
            Get
                Try 
                    Return CType(Me(Me.tableOrders.ShipCityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.ShipCityColumn) = value
            End Set
        End Property
        
        Public Property ShipRegion As String
            Get
                Try 
                    Return CType(Me(Me.tableOrders.ShipRegionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.ShipRegionColumn) = value
            End Set
        End Property
        
        Public Property ShipPostalCode As String
            Get
                Try 
                    Return CType(Me(Me.tableOrders.ShipPostalCodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.ShipPostalCodeColumn) = value
            End Set
        End Property
        
        Public Property ShipCountry As String
            Get
                Try 
                    Return CType(Me(Me.tableOrders.ShipCountryColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableOrders.ShipCountryColumn) = value
            End Set
        End Property
        
        Public Property EmployeesRow As EmployeesRow
            Get
                Return CType(Me.GetParentRow(Me.Table.ParentRelations("EmployeesOrders")),EmployeesRow)
            End Get
            Set
                Me.SetParentRow(value, Me.Table.ParentRelations("EmployeesOrders"))
            End Set
        End Property
        
        Public Function IsCustomerIDNull() As Boolean
            Return Me.IsNull(Me.tableOrders.CustomerIDColumn)
        End Function
        
        Public Sub SetCustomerIDNull()
            Me(Me.tableOrders.CustomerIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsEmployeeIDNull() As Boolean
            Return Me.IsNull(Me.tableOrders.EmployeeIDColumn)
        End Function
        
        Public Sub SetEmployeeIDNull()
            Me(Me.tableOrders.EmployeeIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsOrderDateNull() As Boolean
            Return Me.IsNull(Me.tableOrders.OrderDateColumn)
        End Function
        
        Public Sub SetOrderDateNull()
            Me(Me.tableOrders.OrderDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsRequiredDateNull() As Boolean
            Return Me.IsNull(Me.tableOrders.RequiredDateColumn)
        End Function
        
        Public Sub SetRequiredDateNull()
            Me(Me.tableOrders.RequiredDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShippedDateNull() As Boolean
            Return Me.IsNull(Me.tableOrders.ShippedDateColumn)
        End Function
        
        Public Sub SetShippedDateNull()
            Me(Me.tableOrders.ShippedDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipViaNull() As Boolean
            Return Me.IsNull(Me.tableOrders.ShipViaColumn)
        End Function
        
        Public Sub SetShipViaNull()
            Me(Me.tableOrders.ShipViaColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFreightNull() As Boolean
            Return Me.IsNull(Me.tableOrders.FreightColumn)
        End Function
        
        Public Sub SetFreightNull()
            Me(Me.tableOrders.FreightColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipNameNull() As Boolean
            Return Me.IsNull(Me.tableOrders.ShipNameColumn)
        End Function
        
        Public Sub SetShipNameNull()
            Me(Me.tableOrders.ShipNameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipAddressNull() As Boolean
            Return Me.IsNull(Me.tableOrders.ShipAddressColumn)
        End Function
        
        Public Sub SetShipAddressNull()
            Me(Me.tableOrders.ShipAddressColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipCityNull() As Boolean
            Return Me.IsNull(Me.tableOrders.ShipCityColumn)
        End Function
        
        Public Sub SetShipCityNull()
            Me(Me.tableOrders.ShipCityColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipRegionNull() As Boolean
            Return Me.IsNull(Me.tableOrders.ShipRegionColumn)
        End Function
        
        Public Sub SetShipRegionNull()
            Me(Me.tableOrders.ShipRegionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipPostalCodeNull() As Boolean
            Return Me.IsNull(Me.tableOrders.ShipPostalCodeColumn)
        End Function
        
        Public Sub SetShipPostalCodeNull()
            Me(Me.tableOrders.ShipPostalCodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsShipCountryNull() As Boolean
            Return Me.IsNull(Me.tableOrders.ShipCountryColumn)
        End Function
        
        Public Sub SetShipCountryNull()
            Me(Me.tableOrders.ShipCountryColumn) = System.Convert.DBNull
        End Sub
        
        Public Function GetOrder_DetailsRows() As Order_DetailsRow()
            Return CType(Me.GetChildRows(Me.Table.ChildRelations("OrdersOrder_x0020_Details")),Order_DetailsRow())
        End Function
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class OrdersRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As OrdersRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As OrdersRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As OrdersRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Order_DetailsDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnOrderID As DataColumn
        
        Private columnProductID As DataColumn
        
        Private columnUnitPrice As DataColumn
        
        Private columnQuantity As DataColumn
        
        Private columnDiscount As DataColumn
        
        Friend Sub New()
            MyBase.New("Order Details")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property OrderIDColumn As DataColumn
            Get
                Return Me.columnOrderID
            End Get
        End Property
        
        Friend ReadOnly Property ProductIDColumn As DataColumn
            Get
                Return Me.columnProductID
            End Get
        End Property
        
        Friend ReadOnly Property UnitPriceColumn As DataColumn
            Get
                Return Me.columnUnitPrice
            End Get
        End Property
        
        Friend ReadOnly Property QuantityColumn As DataColumn
            Get
                Return Me.columnQuantity
            End Get
        End Property
        
        Friend ReadOnly Property DiscountColumn As DataColumn
            Get
                Return Me.columnDiscount
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As Order_DetailsRow
            Get
                Return CType(Me.Rows(index),Order_DetailsRow)
            End Get
        End Property
        
        Public Event Order_DetailsRowChanged As Order_DetailsRowChangeEventHandler
        
        Public Event Order_DetailsRowChanging As Order_DetailsRowChangeEventHandler
        
        Public Event Order_DetailsRowDeleted As Order_DetailsRowChangeEventHandler
        
        Public Event Order_DetailsRowDeleting As Order_DetailsRowChangeEventHandler
        
        Public Overloads Sub AddOrder_DetailsRow(ByVal row As Order_DetailsRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddOrder_DetailsRow(ByVal parentOrdersRowByOrdersOrder_x0020_Details As OrdersRow, ByVal ProductID As Integer, ByVal UnitPrice As Decimal, ByVal Quantity As Short, ByVal Discount As Single) As Order_DetailsRow
            Dim rowOrder_DetailsRow As Order_DetailsRow = CType(Me.NewRow,Order_DetailsRow)
            rowOrder_DetailsRow.ItemArray = New Object() {parentOrdersRowByOrdersOrder_x0020_Details(0), ProductID, UnitPrice, Quantity, Discount}
            Me.Rows.Add(rowOrder_DetailsRow)
            Return rowOrder_DetailsRow
        End Function
        
        Public Function FindByOrderIDProductID(ByVal OrderID As Integer, ByVal ProductID As Integer) As Order_DetailsRow
            Return CType(Me.Rows.Find(New Object() {OrderID, ProductID}),Order_DetailsRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As Order_DetailsDataTable = CType(MyBase.Clone,Order_DetailsDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New Order_DetailsDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnOrderID = Me.Columns("OrderID")
            Me.columnProductID = Me.Columns("ProductID")
            Me.columnUnitPrice = Me.Columns("UnitPrice")
            Me.columnQuantity = Me.Columns("Quantity")
            Me.columnDiscount = Me.Columns("Discount")
        End Sub
        
        Private Sub InitClass()
            Me.columnOrderID = New DataColumn("OrderID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnOrderID)
            Me.columnProductID = New DataColumn("ProductID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnProductID)
            Me.columnUnitPrice = New DataColumn("UnitPrice", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUnitPrice)
            Me.columnQuantity = New DataColumn("Quantity", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnQuantity)
            Me.columnDiscount = New DataColumn("Discount", GetType(System.Single), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDiscount)
            Me.Constraints.Add(New UniqueConstraint("NorthwindDataSetKey2", New DataColumn() {Me.columnOrderID, Me.columnProductID}, true))
            Me.columnOrderID.AllowDBNull = false
            Me.columnProductID.AllowDBNull = false
            Me.columnUnitPrice.AllowDBNull = false
            Me.columnQuantity.AllowDBNull = false
            Me.columnDiscount.AllowDBNull = false
        End Sub
        
        Public Function NewOrder_DetailsRow() As Order_DetailsRow
            Return CType(Me.NewRow,Order_DetailsRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Order_DetailsRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Order_DetailsRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Order_DetailsRowChangedEvent) Is Nothing) Then
                RaiseEvent Order_DetailsRowChanged(Me, New Order_DetailsRowChangeEvent(CType(e.Row,Order_DetailsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Order_DetailsRowChangingEvent) Is Nothing) Then
                RaiseEvent Order_DetailsRowChanging(Me, New Order_DetailsRowChangeEvent(CType(e.Row,Order_DetailsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Order_DetailsRowDeletedEvent) Is Nothing) Then
                RaiseEvent Order_DetailsRowDeleted(Me, New Order_DetailsRowChangeEvent(CType(e.Row,Order_DetailsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Order_DetailsRowDeletingEvent) Is Nothing) Then
                RaiseEvent Order_DetailsRowDeleting(Me, New Order_DetailsRowChangeEvent(CType(e.Row,Order_DetailsRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveOrder_DetailsRow(ByVal row As Order_DetailsRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Order_DetailsRow
        Inherits DataRow
        
        Private tableOrder_Details As Order_DetailsDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableOrder_Details = CType(Me.Table,Order_DetailsDataTable)
        End Sub
        
        Public Property OrderID As Integer
            Get
                Return CType(Me(Me.tableOrder_Details.OrderIDColumn),Integer)
            End Get
            Set
                Me(Me.tableOrder_Details.OrderIDColumn) = value
            End Set
        End Property
        
        Public Property ProductID As Integer
            Get
                Return CType(Me(Me.tableOrder_Details.ProductIDColumn),Integer)
            End Get
            Set
                Me(Me.tableOrder_Details.ProductIDColumn) = value
            End Set
        End Property
        
        Public Property UnitPrice As Decimal
            Get
                Return CType(Me(Me.tableOrder_Details.UnitPriceColumn),Decimal)
            End Get
            Set
                Me(Me.tableOrder_Details.UnitPriceColumn) = value
            End Set
        End Property
        
        Public Property Quantity As Short
            Get
                Return CType(Me(Me.tableOrder_Details.QuantityColumn),Short)
            End Get
            Set
                Me(Me.tableOrder_Details.QuantityColumn) = value
            End Set
        End Property
        
        Public Property Discount As Single
            Get
                Return CType(Me(Me.tableOrder_Details.DiscountColumn),Single)
            End Get
            Set
                Me(Me.tableOrder_Details.DiscountColumn) = value
            End Set
        End Property
        
        Public Property OrdersRow As OrdersRow
            Get
                Return CType(Me.GetParentRow(Me.Table.ParentRelations("OrdersOrder_x0020_Details")),OrdersRow)
            End Get
            Set
                Me.SetParentRow(value, Me.Table.ParentRelations("OrdersOrder_x0020_Details"))
            End Set
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class Order_DetailsRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As Order_DetailsRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As Order_DetailsRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As Order_DetailsRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ProductsDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
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
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property ProductIDColumn As DataColumn
            Get
                Return Me.columnProductID
            End Get
        End Property
        
        Friend ReadOnly Property ProductNameColumn As DataColumn
            Get
                Return Me.columnProductName
            End Get
        End Property
        
        Friend ReadOnly Property SupplierIDColumn As DataColumn
            Get
                Return Me.columnSupplierID
            End Get
        End Property
        
        Friend ReadOnly Property CategoryIDColumn As DataColumn
            Get
                Return Me.columnCategoryID
            End Get
        End Property
        
        Friend ReadOnly Property QuantityPerUnitColumn As DataColumn
            Get
                Return Me.columnQuantityPerUnit
            End Get
        End Property
        
        Friend ReadOnly Property UnitPriceColumn As DataColumn
            Get
                Return Me.columnUnitPrice
            End Get
        End Property
        
        Friend ReadOnly Property UnitsInStockColumn As DataColumn
            Get
                Return Me.columnUnitsInStock
            End Get
        End Property
        
        Friend ReadOnly Property UnitsOnOrderColumn As DataColumn
            Get
                Return Me.columnUnitsOnOrder
            End Get
        End Property
        
        Friend ReadOnly Property ReorderLevelColumn As DataColumn
            Get
                Return Me.columnReorderLevel
            End Get
        End Property
        
        Friend ReadOnly Property DiscontinuedColumn As DataColumn
            Get
                Return Me.columnDiscontinued
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ProductsRow
            Get
                Return CType(Me.Rows(index),ProductsRow)
            End Get
        End Property
        
        Public Event ProductsRowChanged As ProductsRowChangeEventHandler
        
        Public Event ProductsRowChanging As ProductsRowChangeEventHandler
        
        Public Event ProductsRowDeleted As ProductsRowChangeEventHandler
        
        Public Event ProductsRowDeleting As ProductsRowChangeEventHandler
        
        Public Overloads Sub AddProductsRow(ByVal row As ProductsRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddProductsRow(ByVal ProductName As String, ByVal SupplierID As Integer, ByVal CategoryID As Integer, ByVal QuantityPerUnit As String, ByVal UnitPrice As Decimal, ByVal UnitsInStock As Short, ByVal UnitsOnOrder As Short, ByVal ReorderLevel As Short, ByVal Discontinued As Boolean) As ProductsRow
            Dim rowProductsRow As ProductsRow = CType(Me.NewRow,ProductsRow)
            rowProductsRow.ItemArray = New Object() {Nothing, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued}
            Me.Rows.Add(rowProductsRow)
            Return rowProductsRow
        End Function
        
        Public Function FindByProductID(ByVal ProductID As Integer) As ProductsRow
            Return CType(Me.Rows.Find(New Object() {ProductID}),ProductsRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ProductsDataTable = CType(MyBase.Clone,ProductsDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ProductsDataTable
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
            Me.columnProductID = New DataColumn("ProductID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnProductID)
            Me.columnProductName = New DataColumn("ProductName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnProductName)
            Me.columnSupplierID = New DataColumn("SupplierID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSupplierID)
            Me.columnCategoryID = New DataColumn("CategoryID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCategoryID)
            Me.columnQuantityPerUnit = New DataColumn("QuantityPerUnit", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnQuantityPerUnit)
            Me.columnUnitPrice = New DataColumn("UnitPrice", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUnitPrice)
            Me.columnUnitsInStock = New DataColumn("UnitsInStock", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUnitsInStock)
            Me.columnUnitsOnOrder = New DataColumn("UnitsOnOrder", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUnitsOnOrder)
            Me.columnReorderLevel = New DataColumn("ReorderLevel", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnReorderLevel)
            Me.columnDiscontinued = New DataColumn("Discontinued", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDiscontinued)
            Me.Constraints.Add(New UniqueConstraint("NorthwindDataSetKey3", New DataColumn() {Me.columnProductID}, true))
            Me.columnProductID.AutoIncrement = true
            Me.columnProductID.AllowDBNull = false
            Me.columnProductID.ReadOnly = true
            Me.columnProductID.Unique = true
            Me.columnProductName.AllowDBNull = false
            Me.columnDiscontinued.AllowDBNull = false
        End Sub
        
        Public Function NewProductsRow() As ProductsRow
            Return CType(Me.NewRow,ProductsRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ProductsRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ProductsRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ProductsRowChangedEvent) Is Nothing) Then
                RaiseEvent ProductsRowChanged(Me, New ProductsRowChangeEvent(CType(e.Row,ProductsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ProductsRowChangingEvent) Is Nothing) Then
                RaiseEvent ProductsRowChanging(Me, New ProductsRowChangeEvent(CType(e.Row,ProductsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ProductsRowDeletedEvent) Is Nothing) Then
                RaiseEvent ProductsRowDeleted(Me, New ProductsRowChangeEvent(CType(e.Row,ProductsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ProductsRowDeletingEvent) Is Nothing) Then
                RaiseEvent ProductsRowDeleting(Me, New ProductsRowChangeEvent(CType(e.Row,ProductsRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveProductsRow(ByVal row As ProductsRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ProductsRow
        Inherits DataRow
        
        Private tableProducts As ProductsDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableProducts = CType(Me.Table,ProductsDataTable)
        End Sub
        
        Public Property ProductID As Integer
            Get
                Return CType(Me(Me.tableProducts.ProductIDColumn),Integer)
            End Get
            Set
                Me(Me.tableProducts.ProductIDColumn) = value
            End Set
        End Property
        
        Public Property ProductName As String
            Get
                Return CType(Me(Me.tableProducts.ProductNameColumn),String)
            End Get
            Set
                Me(Me.tableProducts.ProductNameColumn) = value
            End Set
        End Property
        
        Public Property SupplierID As Integer
            Get
                Try 
                    Return CType(Me(Me.tableProducts.SupplierIDColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.SupplierIDColumn) = value
            End Set
        End Property
        
        Public Property CategoryID As Integer
            Get
                Try 
                    Return CType(Me(Me.tableProducts.CategoryIDColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.CategoryIDColumn) = value
            End Set
        End Property
        
        Public Property QuantityPerUnit As String
            Get
                Try 
                    Return CType(Me(Me.tableProducts.QuantityPerUnitColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.QuantityPerUnitColumn) = value
            End Set
        End Property
        
        Public Property UnitPrice As Decimal
            Get
                Try 
                    Return CType(Me(Me.tableProducts.UnitPriceColumn),Decimal)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.UnitPriceColumn) = value
            End Set
        End Property
        
        Public Property UnitsInStock As Short
            Get
                Try 
                    Return CType(Me(Me.tableProducts.UnitsInStockColumn),Short)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.UnitsInStockColumn) = value
            End Set
        End Property
        
        Public Property UnitsOnOrder As Short
            Get
                Try 
                    Return CType(Me(Me.tableProducts.UnitsOnOrderColumn),Short)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.UnitsOnOrderColumn) = value
            End Set
        End Property
        
        Public Property ReorderLevel As Short
            Get
                Try 
                    Return CType(Me(Me.tableProducts.ReorderLevelColumn),Short)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.ReorderLevelColumn) = value
            End Set
        End Property
        
        Public Property Discontinued As Boolean
            Get
                Return CType(Me(Me.tableProducts.DiscontinuedColumn),Boolean)
            End Get
            Set
                Me(Me.tableProducts.DiscontinuedColumn) = value
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
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ProductsRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ProductsRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ProductsRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ProductsRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SuppliersDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnSupplierID As DataColumn
        
        Private columnCompanyName As DataColumn
        
        Private columnContactName As DataColumn
        
        Private columnContactTitle As DataColumn
        
        Private columnAddress As DataColumn
        
        Private columnCity As DataColumn
        
        Private column_Region As DataColumn
        
        Private columnPostalCode As DataColumn
        
        Private columnCountry As DataColumn
        
        Private columnPhone As DataColumn
        
        Private columnFax As DataColumn
        
        Private columnHomePage As DataColumn
        
        Friend Sub New()
            MyBase.New("Suppliers")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property SupplierIDColumn As DataColumn
            Get
                Return Me.columnSupplierID
            End Get
        End Property
        
        Friend ReadOnly Property CompanyNameColumn As DataColumn
            Get
                Return Me.columnCompanyName
            End Get
        End Property
        
        Friend ReadOnly Property ContactNameColumn As DataColumn
            Get
                Return Me.columnContactName
            End Get
        End Property
        
        Friend ReadOnly Property ContactTitleColumn As DataColumn
            Get
                Return Me.columnContactTitle
            End Get
        End Property
        
        Friend ReadOnly Property AddressColumn As DataColumn
            Get
                Return Me.columnAddress
            End Get
        End Property
        
        Friend ReadOnly Property CityColumn As DataColumn
            Get
                Return Me.columnCity
            End Get
        End Property
        
        Friend ReadOnly Property _RegionColumn As DataColumn
            Get
                Return Me.column_Region
            End Get
        End Property
        
        Friend ReadOnly Property PostalCodeColumn As DataColumn
            Get
                Return Me.columnPostalCode
            End Get
        End Property
        
        Friend ReadOnly Property CountryColumn As DataColumn
            Get
                Return Me.columnCountry
            End Get
        End Property
        
        Friend ReadOnly Property PhoneColumn As DataColumn
            Get
                Return Me.columnPhone
            End Get
        End Property
        
        Friend ReadOnly Property FaxColumn As DataColumn
            Get
                Return Me.columnFax
            End Get
        End Property
        
        Friend ReadOnly Property HomePageColumn As DataColumn
            Get
                Return Me.columnHomePage
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As SuppliersRow
            Get
                Return CType(Me.Rows(index),SuppliersRow)
            End Get
        End Property
        
        Public Event SuppliersRowChanged As SuppliersRowChangeEventHandler
        
        Public Event SuppliersRowChanging As SuppliersRowChangeEventHandler
        
        Public Event SuppliersRowDeleted As SuppliersRowChangeEventHandler
        
        Public Event SuppliersRowDeleting As SuppliersRowChangeEventHandler
        
        Public Overloads Sub AddSuppliersRow(ByVal row As SuppliersRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddSuppliersRow(ByVal CompanyName As String, ByVal ContactName As String, ByVal ContactTitle As String, ByVal Address As String, ByVal City As String, ByVal _Region As String, ByVal PostalCode As String, ByVal Country As String, ByVal Phone As String, ByVal Fax As String, ByVal HomePage As String) As SuppliersRow
            Dim rowSuppliersRow As SuppliersRow = CType(Me.NewRow,SuppliersRow)
            rowSuppliersRow.ItemArray = New Object() {Nothing, CompanyName, ContactName, ContactTitle, Address, City, _Region, PostalCode, Country, Phone, Fax, HomePage}
            Me.Rows.Add(rowSuppliersRow)
            Return rowSuppliersRow
        End Function
        
        Public Function FindBySupplierID(ByVal SupplierID As Integer) As SuppliersRow
            Return CType(Me.Rows.Find(New Object() {SupplierID}),SuppliersRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As SuppliersDataTable = CType(MyBase.Clone,SuppliersDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New SuppliersDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnSupplierID = Me.Columns("SupplierID")
            Me.columnCompanyName = Me.Columns("CompanyName")
            Me.columnContactName = Me.Columns("ContactName")
            Me.columnContactTitle = Me.Columns("ContactTitle")
            Me.columnAddress = Me.Columns("Address")
            Me.columnCity = Me.Columns("City")
            Me.column_Region = Me.Columns("Region")
            Me.columnPostalCode = Me.Columns("PostalCode")
            Me.columnCountry = Me.Columns("Country")
            Me.columnPhone = Me.Columns("Phone")
            Me.columnFax = Me.Columns("Fax")
            Me.columnHomePage = Me.Columns("HomePage")
        End Sub
        
        Private Sub InitClass()
            Me.columnSupplierID = New DataColumn("SupplierID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSupplierID)
            Me.columnCompanyName = New DataColumn("CompanyName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCompanyName)
            Me.columnContactName = New DataColumn("ContactName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnContactName)
            Me.columnContactTitle = New DataColumn("ContactTitle", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnContactTitle)
            Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress)
            Me.columnCity = New DataColumn("City", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCity)
            Me.column_Region = New DataColumn("Region", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_Region)
            Me.columnPostalCode = New DataColumn("PostalCode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPostalCode)
            Me.columnCountry = New DataColumn("Country", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCountry)
            Me.columnPhone = New DataColumn("Phone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhone)
            Me.columnFax = New DataColumn("Fax", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFax)
            Me.columnHomePage = New DataColumn("HomePage", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnHomePage)
            Me.Constraints.Add(New UniqueConstraint("NorthwindDataSetKey4", New DataColumn() {Me.columnSupplierID}, true))
            Me.columnSupplierID.AutoIncrement = true
            Me.columnSupplierID.AllowDBNull = false
            Me.columnSupplierID.ReadOnly = true
            Me.columnSupplierID.Unique = true
            Me.columnCompanyName.AllowDBNull = false
        End Sub
        
        Public Function NewSuppliersRow() As SuppliersRow
            Return CType(Me.NewRow,SuppliersRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New SuppliersRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(SuppliersRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.SuppliersRowChangedEvent) Is Nothing) Then
                RaiseEvent SuppliersRowChanged(Me, New SuppliersRowChangeEvent(CType(e.Row,SuppliersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.SuppliersRowChangingEvent) Is Nothing) Then
                RaiseEvent SuppliersRowChanging(Me, New SuppliersRowChangeEvent(CType(e.Row,SuppliersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.SuppliersRowDeletedEvent) Is Nothing) Then
                RaiseEvent SuppliersRowDeleted(Me, New SuppliersRowChangeEvent(CType(e.Row,SuppliersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.SuppliersRowDeletingEvent) Is Nothing) Then
                RaiseEvent SuppliersRowDeleting(Me, New SuppliersRowChangeEvent(CType(e.Row,SuppliersRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveSuppliersRow(ByVal row As SuppliersRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SuppliersRow
        Inherits DataRow
        
        Private tableSuppliers As SuppliersDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSuppliers = CType(Me.Table,SuppliersDataTable)
        End Sub
        
        Public Property SupplierID As Integer
            Get
                Return CType(Me(Me.tableSuppliers.SupplierIDColumn),Integer)
            End Get
            Set
                Me(Me.tableSuppliers.SupplierIDColumn) = value
            End Set
        End Property
        
        Public Property CompanyName As String
            Get
                Return CType(Me(Me.tableSuppliers.CompanyNameColumn),String)
            End Get
            Set
                Me(Me.tableSuppliers.CompanyNameColumn) = value
            End Set
        End Property
        
        Public Property ContactName As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.ContactNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers.ContactNameColumn) = value
            End Set
        End Property
        
        Public Property ContactTitle As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.ContactTitleColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers.ContactTitleColumn) = value
            End Set
        End Property
        
        Public Property Address As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.AddressColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers.AddressColumn) = value
            End Set
        End Property
        
        Public Property City As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.CityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers.CityColumn) = value
            End Set
        End Property
        
        Public Property _Region As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers._RegionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers._RegionColumn) = value
            End Set
        End Property
        
        Public Property PostalCode As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.PostalCodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers.PostalCodeColumn) = value
            End Set
        End Property
        
        Public Property Country As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.CountryColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers.CountryColumn) = value
            End Set
        End Property
        
        Public Property Phone As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.PhoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers.PhoneColumn) = value
            End Set
        End Property
        
        Public Property Fax As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.FaxColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers.FaxColumn) = value
            End Set
        End Property
        
        Public Property HomePage As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.HomePageColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableSuppliers.HomePageColumn) = value
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
        
        Public Function Is_RegionNull() As Boolean
            Return Me.IsNull(Me.tableSuppliers._RegionColumn)
        End Function
        
        Public Sub Set_RegionNull()
            Me(Me.tableSuppliers._RegionColumn) = System.Convert.DBNull
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
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class SuppliersRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As SuppliersRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As SuppliersRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As SuppliersRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CategoriesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCategoryID As DataColumn
        
        Private columnCategoryName As DataColumn
        
        Private columnDescription As DataColumn
        
        Private columnPicture As DataColumn
        
        Friend Sub New()
            MyBase.New("Categories")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property CategoryIDColumn As DataColumn
            Get
                Return Me.columnCategoryID
            End Get
        End Property
        
        Friend ReadOnly Property CategoryNameColumn As DataColumn
            Get
                Return Me.columnCategoryName
            End Get
        End Property
        
        Friend ReadOnly Property DescriptionColumn As DataColumn
            Get
                Return Me.columnDescription
            End Get
        End Property
        
        Friend ReadOnly Property PictureColumn As DataColumn
            Get
                Return Me.columnPicture
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As CategoriesRow
            Get
                Return CType(Me.Rows(index),CategoriesRow)
            End Get
        End Property
        
        Public Event CategoriesRowChanged As CategoriesRowChangeEventHandler
        
        Public Event CategoriesRowChanging As CategoriesRowChangeEventHandler
        
        Public Event CategoriesRowDeleted As CategoriesRowChangeEventHandler
        
        Public Event CategoriesRowDeleting As CategoriesRowChangeEventHandler
        
        Public Overloads Sub AddCategoriesRow(ByVal row As CategoriesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddCategoriesRow(ByVal CategoryName As String, ByVal Description As String, ByVal Picture() As Byte) As CategoriesRow
            Dim rowCategoriesRow As CategoriesRow = CType(Me.NewRow,CategoriesRow)
            rowCategoriesRow.ItemArray = New Object() {Nothing, CategoryName, Description, Picture}
            Me.Rows.Add(rowCategoriesRow)
            Return rowCategoriesRow
        End Function
        
        Public Function FindByCategoryID(ByVal CategoryID As Integer) As CategoriesRow
            Return CType(Me.Rows.Find(New Object() {CategoryID}),CategoriesRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As CategoriesDataTable = CType(MyBase.Clone,CategoriesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New CategoriesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCategoryID = Me.Columns("CategoryID")
            Me.columnCategoryName = Me.Columns("CategoryName")
            Me.columnDescription = Me.Columns("Description")
            Me.columnPicture = Me.Columns("Picture")
        End Sub
        
        Private Sub InitClass()
            Me.columnCategoryID = New DataColumn("CategoryID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCategoryID)
            Me.columnCategoryName = New DataColumn("CategoryName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCategoryName)
            Me.columnDescription = New DataColumn("Description", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescription)
            Me.columnPicture = New DataColumn("Picture", GetType(System.Byte()), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPicture)
            Me.Constraints.Add(New UniqueConstraint("NorthwindDataSetKey5", New DataColumn() {Me.columnCategoryID}, true))
            Me.columnCategoryID.AutoIncrement = true
            Me.columnCategoryID.AllowDBNull = false
            Me.columnCategoryID.ReadOnly = true
            Me.columnCategoryID.Unique = true
            Me.columnCategoryName.AllowDBNull = false
        End Sub
        
        Public Function NewCategoriesRow() As CategoriesRow
            Return CType(Me.NewRow,CategoriesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New CategoriesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(CategoriesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.CategoriesRowChangedEvent) Is Nothing) Then
                RaiseEvent CategoriesRowChanged(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.CategoriesRowChangingEvent) Is Nothing) Then
                RaiseEvent CategoriesRowChanging(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.CategoriesRowDeletedEvent) Is Nothing) Then
                RaiseEvent CategoriesRowDeleted(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.CategoriesRowDeletingEvent) Is Nothing) Then
                RaiseEvent CategoriesRowDeleting(Me, New CategoriesRowChangeEvent(CType(e.Row,CategoriesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveCategoriesRow(ByVal row As CategoriesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CategoriesRow
        Inherits DataRow
        
        Private tableCategories As CategoriesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableCategories = CType(Me.Table,CategoriesDataTable)
        End Sub
        
        Public Property CategoryID As Integer
            Get
                Return CType(Me(Me.tableCategories.CategoryIDColumn),Integer)
            End Get
            Set
                Me(Me.tableCategories.CategoryIDColumn) = value
            End Set
        End Property
        
        Public Property CategoryName As String
            Get
                Return CType(Me(Me.tableCategories.CategoryNameColumn),String)
            End Get
            Set
                Me(Me.tableCategories.CategoryNameColumn) = value
            End Set
        End Property
        
        Public Property Description As String
            Get
                Try 
                    Return CType(Me(Me.tableCategories.DescriptionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCategories.DescriptionColumn) = value
            End Set
        End Property
        
        Public Property Picture As Byte()
            Get
                Try 
                    Return CType(Me(Me.tableCategories.PictureColumn),Byte())
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCategories.PictureColumn) = value
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
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CategoriesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As CategoriesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As CategoriesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As CategoriesRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ShippersDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnShipperID As DataColumn
        
        Private columnCompanyName As DataColumn
        
        Private columnPhone As DataColumn
        
        Friend Sub New()
            MyBase.New("Shippers")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property ShipperIDColumn As DataColumn
            Get
                Return Me.columnShipperID
            End Get
        End Property
        
        Friend ReadOnly Property CompanyNameColumn As DataColumn
            Get
                Return Me.columnCompanyName
            End Get
        End Property
        
        Friend ReadOnly Property PhoneColumn As DataColumn
            Get
                Return Me.columnPhone
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As ShippersRow
            Get
                Return CType(Me.Rows(index),ShippersRow)
            End Get
        End Property
        
        Public Event ShippersRowChanged As ShippersRowChangeEventHandler
        
        Public Event ShippersRowChanging As ShippersRowChangeEventHandler
        
        Public Event ShippersRowDeleted As ShippersRowChangeEventHandler
        
        Public Event ShippersRowDeleting As ShippersRowChangeEventHandler
        
        Public Overloads Sub AddShippersRow(ByVal row As ShippersRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddShippersRow(ByVal CompanyName As String, ByVal Phone As String) As ShippersRow
            Dim rowShippersRow As ShippersRow = CType(Me.NewRow,ShippersRow)
            rowShippersRow.ItemArray = New Object() {Nothing, CompanyName, Phone}
            Me.Rows.Add(rowShippersRow)
            Return rowShippersRow
        End Function
        
        Public Function FindByShipperID(ByVal ShipperID As Integer) As ShippersRow
            Return CType(Me.Rows.Find(New Object() {ShipperID}),ShippersRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As ShippersDataTable = CType(MyBase.Clone,ShippersDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New ShippersDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnShipperID = Me.Columns("ShipperID")
            Me.columnCompanyName = Me.Columns("CompanyName")
            Me.columnPhone = Me.Columns("Phone")
        End Sub
        
        Private Sub InitClass()
            Me.columnShipperID = New DataColumn("ShipperID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnShipperID)
            Me.columnCompanyName = New DataColumn("CompanyName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCompanyName)
            Me.columnPhone = New DataColumn("Phone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhone)
            Me.Constraints.Add(New UniqueConstraint("NorthwindDataSetKey6", New DataColumn() {Me.columnShipperID}, true))
            Me.columnShipperID.AutoIncrement = true
            Me.columnShipperID.AllowDBNull = false
            Me.columnShipperID.ReadOnly = true
            Me.columnShipperID.Unique = true
            Me.columnCompanyName.AllowDBNull = false
        End Sub
        
        Public Function NewShippersRow() As ShippersRow
            Return CType(Me.NewRow,ShippersRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New ShippersRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(ShippersRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.ShippersRowChangedEvent) Is Nothing) Then
                RaiseEvent ShippersRowChanged(Me, New ShippersRowChangeEvent(CType(e.Row,ShippersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.ShippersRowChangingEvent) Is Nothing) Then
                RaiseEvent ShippersRowChanging(Me, New ShippersRowChangeEvent(CType(e.Row,ShippersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.ShippersRowDeletedEvent) Is Nothing) Then
                RaiseEvent ShippersRowDeleted(Me, New ShippersRowChangeEvent(CType(e.Row,ShippersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.ShippersRowDeletingEvent) Is Nothing) Then
                RaiseEvent ShippersRowDeleting(Me, New ShippersRowChangeEvent(CType(e.Row,ShippersRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveShippersRow(ByVal row As ShippersRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ShippersRow
        Inherits DataRow
        
        Private tableShippers As ShippersDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableShippers = CType(Me.Table,ShippersDataTable)
        End Sub
        
        Public Property ShipperID As Integer
            Get
                Return CType(Me(Me.tableShippers.ShipperIDColumn),Integer)
            End Get
            Set
                Me(Me.tableShippers.ShipperIDColumn) = value
            End Set
        End Property
        
        Public Property CompanyName As String
            Get
                Return CType(Me(Me.tableShippers.CompanyNameColumn),String)
            End Get
            Set
                Me(Me.tableShippers.CompanyNameColumn) = value
            End Set
        End Property
        
        Public Property Phone As String
            Get
                Try 
                    Return CType(Me(Me.tableShippers.PhoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableShippers.PhoneColumn) = value
            End Set
        End Property
        
        Public Function IsPhoneNull() As Boolean
            Return Me.IsNull(Me.tableShippers.PhoneColumn)
        End Function
        
        Public Sub SetPhoneNull()
            Me(Me.tableShippers.PhoneColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ShippersRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As ShippersRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As ShippersRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As ShippersRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CustomersDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCustomerID As DataColumn
        
        Private columnCompanyName As DataColumn
        
        Private columnContactName As DataColumn
        
        Private columnContactTitle As DataColumn
        
        Private columnAddress As DataColumn
        
        Private columnCity As DataColumn
        
        Private column_Region As DataColumn
        
        Private columnPostalCode As DataColumn
        
        Private columnCountry As DataColumn
        
        Private columnPhone As DataColumn
        
        Private columnFax As DataColumn
        
        Friend Sub New()
            MyBase.New("Customers")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property CustomerIDColumn As DataColumn
            Get
                Return Me.columnCustomerID
            End Get
        End Property
        
        Friend ReadOnly Property CompanyNameColumn As DataColumn
            Get
                Return Me.columnCompanyName
            End Get
        End Property
        
        Friend ReadOnly Property ContactNameColumn As DataColumn
            Get
                Return Me.columnContactName
            End Get
        End Property
        
        Friend ReadOnly Property ContactTitleColumn As DataColumn
            Get
                Return Me.columnContactTitle
            End Get
        End Property
        
        Friend ReadOnly Property AddressColumn As DataColumn
            Get
                Return Me.columnAddress
            End Get
        End Property
        
        Friend ReadOnly Property CityColumn As DataColumn
            Get
                Return Me.columnCity
            End Get
        End Property
        
        Friend ReadOnly Property _RegionColumn As DataColumn
            Get
                Return Me.column_Region
            End Get
        End Property
        
        Friend ReadOnly Property PostalCodeColumn As DataColumn
            Get
                Return Me.columnPostalCode
            End Get
        End Property
        
        Friend ReadOnly Property CountryColumn As DataColumn
            Get
                Return Me.columnCountry
            End Get
        End Property
        
        Friend ReadOnly Property PhoneColumn As DataColumn
            Get
                Return Me.columnPhone
            End Get
        End Property
        
        Friend ReadOnly Property FaxColumn As DataColumn
            Get
                Return Me.columnFax
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As CustomersRow
            Get
                Return CType(Me.Rows(index),CustomersRow)
            End Get
        End Property
        
        Public Event CustomersRowChanged As CustomersRowChangeEventHandler
        
        Public Event CustomersRowChanging As CustomersRowChangeEventHandler
        
        Public Event CustomersRowDeleted As CustomersRowChangeEventHandler
        
        Public Event CustomersRowDeleting As CustomersRowChangeEventHandler
        
        Public Overloads Sub AddCustomersRow(ByVal row As CustomersRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddCustomersRow(ByVal CustomerID As String, ByVal CompanyName As String, ByVal ContactName As String, ByVal ContactTitle As String, ByVal Address As String, ByVal City As String, ByVal _Region As String, ByVal PostalCode As String, ByVal Country As String, ByVal Phone As String, ByVal Fax As String) As CustomersRow
            Dim rowCustomersRow As CustomersRow = CType(Me.NewRow,CustomersRow)
            rowCustomersRow.ItemArray = New Object() {CustomerID, CompanyName, ContactName, ContactTitle, Address, City, _Region, PostalCode, Country, Phone, Fax}
            Me.Rows.Add(rowCustomersRow)
            Return rowCustomersRow
        End Function
        
        Public Function FindByCustomerID(ByVal CustomerID As String) As CustomersRow
            Return CType(Me.Rows.Find(New Object() {CustomerID}),CustomersRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As CustomersDataTable = CType(MyBase.Clone,CustomersDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New CustomersDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCustomerID = Me.Columns("CustomerID")
            Me.columnCompanyName = Me.Columns("CompanyName")
            Me.columnContactName = Me.Columns("ContactName")
            Me.columnContactTitle = Me.Columns("ContactTitle")
            Me.columnAddress = Me.Columns("Address")
            Me.columnCity = Me.Columns("City")
            Me.column_Region = Me.Columns("Region")
            Me.columnPostalCode = Me.Columns("PostalCode")
            Me.columnCountry = Me.Columns("Country")
            Me.columnPhone = Me.Columns("Phone")
            Me.columnFax = Me.Columns("Fax")
        End Sub
        
        Private Sub InitClass()
            Me.columnCustomerID = New DataColumn("CustomerID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCustomerID)
            Me.columnCompanyName = New DataColumn("CompanyName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCompanyName)
            Me.columnContactName = New DataColumn("ContactName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnContactName)
            Me.columnContactTitle = New DataColumn("ContactTitle", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnContactTitle)
            Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress)
            Me.columnCity = New DataColumn("City", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCity)
            Me.column_Region = New DataColumn("Region", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_Region)
            Me.columnPostalCode = New DataColumn("PostalCode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPostalCode)
            Me.columnCountry = New DataColumn("Country", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCountry)
            Me.columnPhone = New DataColumn("Phone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhone)
            Me.columnFax = New DataColumn("Fax", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFax)
            Me.Constraints.Add(New UniqueConstraint("NorthwindDataSetKey7", New DataColumn() {Me.columnCustomerID}, true))
            Me.columnCustomerID.AllowDBNull = false
            Me.columnCustomerID.Unique = true
            Me.columnCompanyName.AllowDBNull = false
        End Sub
        
        Public Function NewCustomersRow() As CustomersRow
            Return CType(Me.NewRow,CustomersRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New CustomersRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(CustomersRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.CustomersRowChangedEvent) Is Nothing) Then
                RaiseEvent CustomersRowChanged(Me, New CustomersRowChangeEvent(CType(e.Row,CustomersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.CustomersRowChangingEvent) Is Nothing) Then
                RaiseEvent CustomersRowChanging(Me, New CustomersRowChangeEvent(CType(e.Row,CustomersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.CustomersRowDeletedEvent) Is Nothing) Then
                RaiseEvent CustomersRowDeleted(Me, New CustomersRowChangeEvent(CType(e.Row,CustomersRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.CustomersRowDeletingEvent) Is Nothing) Then
                RaiseEvent CustomersRowDeleting(Me, New CustomersRowChangeEvent(CType(e.Row,CustomersRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveCustomersRow(ByVal row As CustomersRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CustomersRow
        Inherits DataRow
        
        Private tableCustomers As CustomersDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableCustomers = CType(Me.Table,CustomersDataTable)
        End Sub
        
        Public Property CustomerID As String
            Get
                Return CType(Me(Me.tableCustomers.CustomerIDColumn),String)
            End Get
            Set
                Me(Me.tableCustomers.CustomerIDColumn) = value
            End Set
        End Property
        
        Public Property CompanyName As String
            Get
                Return CType(Me(Me.tableCustomers.CompanyNameColumn),String)
            End Get
            Set
                Me(Me.tableCustomers.CompanyNameColumn) = value
            End Set
        End Property
        
        Public Property ContactName As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers.ContactNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomers.ContactNameColumn) = value
            End Set
        End Property
        
        Public Property ContactTitle As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers.ContactTitleColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomers.ContactTitleColumn) = value
            End Set
        End Property
        
        Public Property Address As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers.AddressColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomers.AddressColumn) = value
            End Set
        End Property
        
        Public Property City As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers.CityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomers.CityColumn) = value
            End Set
        End Property
        
        Public Property _Region As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers._RegionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomers._RegionColumn) = value
            End Set
        End Property
        
        Public Property PostalCode As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers.PostalCodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomers.PostalCodeColumn) = value
            End Set
        End Property
        
        Public Property Country As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers.CountryColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomers.CountryColumn) = value
            End Set
        End Property
        
        Public Property Phone As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers.PhoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomers.PhoneColumn) = value
            End Set
        End Property
        
        Public Property Fax As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers.FaxColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableCustomers.FaxColumn) = value
            End Set
        End Property
        
        Public Function IsContactNameNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.ContactNameColumn)
        End Function
        
        Public Sub SetContactNameNull()
            Me(Me.tableCustomers.ContactNameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsContactTitleNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.ContactTitleColumn)
        End Function
        
        Public Sub SetContactTitleNull()
            Me(Me.tableCustomers.ContactTitleColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAddressNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.AddressColumn)
        End Function
        
        Public Sub SetAddressNull()
            Me(Me.tableCustomers.AddressColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCityNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.CityColumn)
        End Function
        
        Public Sub SetCityNull()
            Me(Me.tableCustomers.CityColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Is_RegionNull() As Boolean
            Return Me.IsNull(Me.tableCustomers._RegionColumn)
        End Function
        
        Public Sub Set_RegionNull()
            Me(Me.tableCustomers._RegionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPostalCodeNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.PostalCodeColumn)
        End Function
        
        Public Sub SetPostalCodeNull()
            Me(Me.tableCustomers.PostalCodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCountryNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.CountryColumn)
        End Function
        
        Public Sub SetCountryNull()
            Me(Me.tableCustomers.CountryColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhoneNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.PhoneColumn)
        End Function
        
        Public Sub SetPhoneNull()
            Me(Me.tableCustomers.PhoneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFaxNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.FaxColumn)
        End Function
        
        Public Sub SetFaxNull()
            Me(Me.tableCustomers.FaxColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CustomersRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As CustomersRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As CustomersRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As CustomersRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
