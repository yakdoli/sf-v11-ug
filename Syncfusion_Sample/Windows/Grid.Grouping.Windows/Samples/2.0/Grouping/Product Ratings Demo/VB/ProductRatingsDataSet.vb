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
Public Class ProductRatingsDataSet
    Inherits DataSet
    
    Private tableCustomers As CustomersDataTable
    
    Private tableProducts As ProductsDataTable
    
    Private tableRatingDescription As RatingDescriptionDataTable
    
    Private tableRatings As RatingsDataTable
    
    Private tableSuppliers As SuppliersDataTable
    
    Private relationProductsRatings As DataRelation
    
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
            If (Not (ds.Tables("Customers")) Is Nothing) Then
                Me.Tables.Add(New CustomersDataTable(ds.Tables("Customers")))
            End If
            If (Not (ds.Tables("Products")) Is Nothing) Then
                Me.Tables.Add(New ProductsDataTable(ds.Tables("Products")))
            End If
            If (Not (ds.Tables("RatingDescription")) Is Nothing) Then
                Me.Tables.Add(New RatingDescriptionDataTable(ds.Tables("RatingDescription")))
            End If
            If (Not (ds.Tables("Ratings")) Is Nothing) Then
                Me.Tables.Add(New RatingsDataTable(ds.Tables("Ratings")))
            End If
            If (Not (ds.Tables("Suppliers")) Is Nothing) Then
                Me.Tables.Add(New SuppliersDataTable(ds.Tables("Suppliers")))
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
    Public ReadOnly Property Customers As CustomersDataTable
        Get
            Return Me.tableCustomers
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
    Public ReadOnly Property RatingDescription As RatingDescriptionDataTable
        Get
            Return Me.tableRatingDescription
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Ratings As RatingsDataTable
        Get
            Return Me.tableRatings
        End Get
    End Property
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Suppliers As SuppliersDataTable
        Get
            Return Me.tableSuppliers
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ProductRatingsDataSet = CType(MyBase.Clone,ProductRatingsDataSet)
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
        If (Not (ds.Tables("Customers")) Is Nothing) Then
            Me.Tables.Add(New CustomersDataTable(ds.Tables("Customers")))
        End If
        If (Not (ds.Tables("Products")) Is Nothing) Then
            Me.Tables.Add(New ProductsDataTable(ds.Tables("Products")))
        End If
        If (Not (ds.Tables("RatingDescription")) Is Nothing) Then
            Me.Tables.Add(New RatingDescriptionDataTable(ds.Tables("RatingDescription")))
        End If
        If (Not (ds.Tables("Ratings")) Is Nothing) Then
            Me.Tables.Add(New RatingsDataTable(ds.Tables("Ratings")))
        End If
        If (Not (ds.Tables("Suppliers")) Is Nothing) Then
            Me.Tables.Add(New SuppliersDataTable(ds.Tables("Suppliers")))
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
        Me.tableCustomers = CType(Me.Tables("Customers"),CustomersDataTable)
        If (Not (Me.tableCustomers) Is Nothing) Then
            Me.tableCustomers.InitVars
        End If
        Me.tableProducts = CType(Me.Tables("Products"),ProductsDataTable)
        If (Not (Me.tableProducts) Is Nothing) Then
            Me.tableProducts.InitVars
        End If
        Me.tableRatingDescription = CType(Me.Tables("RatingDescription"),RatingDescriptionDataTable)
        If (Not (Me.tableRatingDescription) Is Nothing) Then
            Me.tableRatingDescription.InitVars
        End If
        Me.tableRatings = CType(Me.Tables("Ratings"),RatingsDataTable)
        If (Not (Me.tableRatings) Is Nothing) Then
            Me.tableRatings.InitVars
        End If
        Me.tableSuppliers = CType(Me.Tables("Suppliers"),SuppliersDataTable)
        If (Not (Me.tableSuppliers) Is Nothing) Then
            Me.tableSuppliers.InitVars
        End If
        Me.relationProductsRatings = Me.Relations("ProductsRatings")
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ProductRatingsDataSet"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/ProductRatingsDataSet.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableCustomers = New CustomersDataTable
        Me.Tables.Add(Me.tableCustomers)
        Me.tableProducts = New ProductsDataTable
        Me.Tables.Add(Me.tableProducts)
        Me.tableRatingDescription = New RatingDescriptionDataTable
        Me.Tables.Add(Me.tableRatingDescription)
        Me.tableRatings = New RatingsDataTable
        Me.Tables.Add(Me.tableRatings)
        Me.tableSuppliers = New SuppliersDataTable
        Me.Tables.Add(Me.tableSuppliers)
        Dim fkc As ForeignKeyConstraint
        fkc = New ForeignKeyConstraint("SuppliersProducts", New DataColumn() {Me.tableSuppliers.SupplierIDColumn}, New DataColumn() {Me.tableProducts.SupplierIDColumn})
        Me.tableProducts.Constraints.Add(fkc)
        fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None
        fkc.DeleteRule = System.Data.Rule.Cascade
        fkc.UpdateRule = System.Data.Rule.Cascade
        fkc = New ForeignKeyConstraint("ProductsRatings", New DataColumn() {Me.tableProducts.ProductIDColumn}, New DataColumn() {Me.tableRatings.ProductIDColumn})
        Me.tableRatings.Constraints.Add(fkc)
        fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None
        fkc.DeleteRule = System.Data.Rule.Cascade
        fkc.UpdateRule = System.Data.Rule.Cascade
        fkc = New ForeignKeyConstraint("RatingDescriptionRatings", New DataColumn() {Me.tableRatingDescription.RatingIDColumn}, New DataColumn() {Me.tableRatings.RatingIDColumn})
        Me.tableRatings.Constraints.Add(fkc)
        fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None
        fkc.DeleteRule = System.Data.Rule.Cascade
        fkc.UpdateRule = System.Data.Rule.Cascade
        fkc = New ForeignKeyConstraint("CustomersRatings", New DataColumn() {Me.tableCustomers.CustomerIDColumn}, New DataColumn() {Me.tableRatings.CustomerIDColumn})
        Me.tableRatings.Constraints.Add(fkc)
        fkc.AcceptRejectRule = System.Data.AcceptRejectRule.None
        fkc.DeleteRule = System.Data.Rule.Cascade
        fkc.UpdateRule = System.Data.Rule.Cascade
        Me.relationProductsRatings = New DataRelation("ProductsRatings", New DataColumn() {Me.tableProducts.ProductIDColumn}, New DataColumn() {Me.tableRatings.ProductIDColumn}, false)
        Me.Relations.Add(Me.relationProductsRatings)
    End Sub
    
    Private Function ShouldSerializeCustomers() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeProducts() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeRatingDescription() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeRatings() As Boolean
        Return false
    End Function
    
    Private Function ShouldSerializeSuppliers() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub CustomersRowChangeEventHandler(ByVal sender As Object, ByVal e As CustomersRowChangeEvent)
    
    Public Delegate Sub ProductsRowChangeEventHandler(ByVal sender As Object, ByVal e As ProductsRowChangeEvent)
    
    Public Delegate Sub RatingDescriptionRowChangeEventHandler(ByVal sender As Object, ByVal e As RatingDescriptionRowChangeEvent)
    
    Public Delegate Sub RatingsRowChangeEventHandler(ByVal sender As Object, ByVal e As RatingsRowChangeEvent)
    
    Public Delegate Sub SuppliersRowChangeEventHandler(ByVal sender As Object, ByVal e As SuppliersRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class CustomersDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnAddress As DataColumn
        
        Private columnCity As DataColumn
        
        Private columnCompanyName As DataColumn
        
        Private columnContactName As DataColumn
        
        Private columnContactTitle As DataColumn
        
        Private columnCountry As DataColumn
        
        Private columnCustomerID As DataColumn
        
        Private columnFax As DataColumn
        
        Private columnPhone As DataColumn
        
        Private columnPostalCode As DataColumn
        
        Private column_Region As DataColumn
        
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
        
        Friend ReadOnly Property CountryColumn As DataColumn
            Get
                Return Me.columnCountry
            End Get
        End Property
        
        Friend ReadOnly Property CustomerIDColumn As DataColumn
            Get
                Return Me.columnCustomerID
            End Get
        End Property
        
        Friend ReadOnly Property FaxColumn As DataColumn
            Get
                Return Me.columnFax
            End Get
        End Property
        
        Friend ReadOnly Property PhoneColumn As DataColumn
            Get
                Return Me.columnPhone
            End Get
        End Property
        
        Friend ReadOnly Property PostalCodeColumn As DataColumn
            Get
                Return Me.columnPostalCode
            End Get
        End Property
        
        Friend ReadOnly Property _RegionColumn As DataColumn
            Get
                Return Me.column_Region
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
        
        Public Overloads Function AddCustomersRow(ByVal Address As String, ByVal City As String, ByVal CompanyName As String, ByVal ContactName As String, ByVal ContactTitle As String, ByVal Country As String, ByVal CustomerID As String, ByVal Fax As String, ByVal Phone As String, ByVal PostalCode As String, ByVal _Region As String) As CustomersRow
            Dim rowCustomersRow As CustomersRow = CType(Me.NewRow,CustomersRow)
            rowCustomersRow.ItemArray = New Object() {Address, City, CompanyName, ContactName, ContactTitle, Country, CustomerID, Fax, Phone, PostalCode, _Region}
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
            Me.columnAddress = Me.Columns("Address")
            Me.columnCity = Me.Columns("City")
            Me.columnCompanyName = Me.Columns("CompanyName")
            Me.columnContactName = Me.Columns("ContactName")
            Me.columnContactTitle = Me.Columns("ContactTitle")
            Me.columnCountry = Me.Columns("Country")
            Me.columnCustomerID = Me.Columns("CustomerID")
            Me.columnFax = Me.Columns("Fax")
            Me.columnPhone = Me.Columns("Phone")
            Me.columnPostalCode = Me.Columns("PostalCode")
            Me.column_Region = Me.Columns("Region")
        End Sub
        
        Private Sub InitClass()
            Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress)
            Me.columnCity = New DataColumn("City", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCity)
            Me.columnCompanyName = New DataColumn("CompanyName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCompanyName)
            Me.columnContactName = New DataColumn("ContactName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnContactName)
            Me.columnContactTitle = New DataColumn("ContactTitle", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnContactTitle)
            Me.columnCountry = New DataColumn("Country", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCountry)
            Me.columnCustomerID = New DataColumn("CustomerID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCustomerID)
            Me.columnFax = New DataColumn("Fax", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFax)
            Me.columnPhone = New DataColumn("Phone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhone)
            Me.columnPostalCode = New DataColumn("PostalCode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPostalCode)
            Me.column_Region = New DataColumn("Region", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_Region)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnCustomerID}, true))
            Me.columnCustomerID.AllowDBNull = false
            Me.columnCustomerID.Unique = true
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
        
        Public Property CompanyName As String
            Get
                Try 
                    Return CType(Me(Me.tableCustomers.CompanyNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
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
        
        Public Property CustomerID As String
            Get
                Return CType(Me(Me.tableCustomers.CustomerIDColumn),String)
            End Get
            Set
                Me(Me.tableCustomers.CustomerIDColumn) = value
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
        
        Public Function IsCompanyNameNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.CompanyNameColumn)
        End Function
        
        Public Sub SetCompanyNameNull()
            Me(Me.tableCustomers.CompanyNameColumn) = System.Convert.DBNull
        End Sub
        
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
        
        Public Function IsCountryNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.CountryColumn)
        End Function
        
        Public Sub SetCountryNull()
            Me(Me.tableCustomers.CountryColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsFaxNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.FaxColumn)
        End Function
        
        Public Sub SetFaxNull()
            Me(Me.tableCustomers.FaxColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhoneNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.PhoneColumn)
        End Function
        
        Public Sub SetPhoneNull()
            Me(Me.tableCustomers.PhoneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPostalCodeNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.PostalCodeColumn)
        End Function
        
        Public Sub SetPostalCodeNull()
            Me(Me.tableCustomers.PostalCodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Is_RegionNull() As Boolean
            Return Me.IsNull(Me.tableCustomers._RegionColumn)
        End Function
        
        Public Sub Set_RegionNull()
            Me(Me.tableCustomers._RegionColumn) = System.Convert.DBNull
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
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class ProductsDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCategoryID As DataColumn
        
        Private columnDiscontinued As DataColumn
        
        Private columnProductID As DataColumn
        
        Private columnProductName As DataColumn
        
        Private columnQuantityPerUnit As DataColumn
        
        Private columnReorderLevel As DataColumn
        
        Private columnSupplierID As DataColumn
        
        Private columnUnitPrice As DataColumn
        
        Private columnUnitsInStock As DataColumn
        
        Private columnUnitsOnOrder As DataColumn
        
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
        
        Friend ReadOnly Property CategoryIDColumn As DataColumn
            Get
                Return Me.columnCategoryID
            End Get
        End Property
        
        Friend ReadOnly Property DiscontinuedColumn As DataColumn
            Get
                Return Me.columnDiscontinued
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
        
        Friend ReadOnly Property QuantityPerUnitColumn As DataColumn
            Get
                Return Me.columnQuantityPerUnit
            End Get
        End Property
        
        Friend ReadOnly Property ReorderLevelColumn As DataColumn
            Get
                Return Me.columnReorderLevel
            End Get
        End Property
        
        Friend ReadOnly Property SupplierIDColumn As DataColumn
            Get
                Return Me.columnSupplierID
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
        
        Public Overloads Function AddProductsRow(ByVal CategoryID As Integer, ByVal Discontinued As Boolean, ByVal ProductName As String, ByVal QuantityPerUnit As String, ByVal ReorderLevel As Short, ByVal SupplierID As Integer, ByVal UnitPrice As Decimal, ByVal UnitsInStock As Short, ByVal UnitsOnOrder As Short) As ProductsRow
            Dim rowProductsRow As ProductsRow = CType(Me.NewRow,ProductsRow)
            rowProductsRow.ItemArray = New Object() {CategoryID, Discontinued, Nothing, ProductName, QuantityPerUnit, ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder}
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
            Me.columnCategoryID = Me.Columns("CategoryID")
            Me.columnDiscontinued = Me.Columns("Discontinued")
            Me.columnProductID = Me.Columns("ProductID")
            Me.columnProductName = Me.Columns("ProductName")
            Me.columnQuantityPerUnit = Me.Columns("QuantityPerUnit")
            Me.columnReorderLevel = Me.Columns("ReorderLevel")
            Me.columnSupplierID = Me.Columns("SupplierID")
            Me.columnUnitPrice = Me.Columns("UnitPrice")
            Me.columnUnitsInStock = Me.Columns("UnitsInStock")
            Me.columnUnitsOnOrder = Me.Columns("UnitsOnOrder")
        End Sub
        
        Private Sub InitClass()
            Me.columnCategoryID = New DataColumn("CategoryID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCategoryID)
            Me.columnDiscontinued = New DataColumn("Discontinued", GetType(System.Boolean), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDiscontinued)
            Me.columnProductID = New DataColumn("ProductID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnProductID)
            Me.columnProductName = New DataColumn("ProductName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnProductName)
            Me.columnQuantityPerUnit = New DataColumn("QuantityPerUnit", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnQuantityPerUnit)
            Me.columnReorderLevel = New DataColumn("ReorderLevel", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnReorderLevel)
            Me.columnSupplierID = New DataColumn("SupplierID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSupplierID)
            Me.columnUnitPrice = New DataColumn("UnitPrice", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUnitPrice)
            Me.columnUnitsInStock = New DataColumn("UnitsInStock", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUnitsInStock)
            Me.columnUnitsOnOrder = New DataColumn("UnitsOnOrder", GetType(System.Int16), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnUnitsOnOrder)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnProductID}, true))
            Me.columnProductID.AutoIncrement = true
            Me.columnProductID.AllowDBNull = false
            Me.columnProductID.Unique = true
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
        
        Public Property Discontinued As Boolean
            Get
                Try 
                    Return CType(Me(Me.tableProducts.DiscontinuedColumn),Boolean)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.DiscontinuedColumn) = value
            End Set
        End Property
        
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
                Try 
                    Return CType(Me(Me.tableProducts.ProductNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableProducts.ProductNameColumn) = value
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
        
        Public Function IsCategoryIDNull() As Boolean
            Return Me.IsNull(Me.tableProducts.CategoryIDColumn)
        End Function
        
        Public Sub SetCategoryIDNull()
            Me(Me.tableProducts.CategoryIDColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsDiscontinuedNull() As Boolean
            Return Me.IsNull(Me.tableProducts.DiscontinuedColumn)
        End Function
        
        Public Sub SetDiscontinuedNull()
            Me(Me.tableProducts.DiscontinuedColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsProductNameNull() As Boolean
            Return Me.IsNull(Me.tableProducts.ProductNameColumn)
        End Function
        
        Public Sub SetProductNameNull()
            Me(Me.tableProducts.ProductNameColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsQuantityPerUnitNull() As Boolean
            Return Me.IsNull(Me.tableProducts.QuantityPerUnitColumn)
        End Function
        
        Public Sub SetQuantityPerUnitNull()
            Me(Me.tableProducts.QuantityPerUnitColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsReorderLevelNull() As Boolean
            Return Me.IsNull(Me.tableProducts.ReorderLevelColumn)
        End Function
        
        Public Sub SetReorderLevelNull()
            Me(Me.tableProducts.ReorderLevelColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsSupplierIDNull() As Boolean
            Return Me.IsNull(Me.tableProducts.SupplierIDColumn)
        End Function
        
        Public Sub SetSupplierIDNull()
            Me(Me.tableProducts.SupplierIDColumn) = System.Convert.DBNull
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
        
        Public Function GetRatingsRows() As RatingsRow()
            Return CType(Me.GetChildRows(Me.Table.ChildRelations("ProductsRatings")),RatingsRow())
        End Function
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
    Public Class RatingDescriptionDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnDescription As DataColumn
        
        Private columnRatingID As DataColumn
        
        Friend Sub New()
            MyBase.New("RatingDescription")
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
        
        Friend ReadOnly Property DescriptionColumn As DataColumn
            Get
                Return Me.columnDescription
            End Get
        End Property
        
        Friend ReadOnly Property RatingIDColumn As DataColumn
            Get
                Return Me.columnRatingID
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As RatingDescriptionRow
            Get
                Return CType(Me.Rows(index),RatingDescriptionRow)
            End Get
        End Property
        
        Public Event RatingDescriptionRowChanged As RatingDescriptionRowChangeEventHandler
        
        Public Event RatingDescriptionRowChanging As RatingDescriptionRowChangeEventHandler
        
        Public Event RatingDescriptionRowDeleted As RatingDescriptionRowChangeEventHandler
        
        Public Event RatingDescriptionRowDeleting As RatingDescriptionRowChangeEventHandler
        
        Public Overloads Sub AddRatingDescriptionRow(ByVal row As RatingDescriptionRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddRatingDescriptionRow(ByVal Description As String, ByVal RatingID As Integer) As RatingDescriptionRow
            Dim rowRatingDescriptionRow As RatingDescriptionRow = CType(Me.NewRow,RatingDescriptionRow)
            rowRatingDescriptionRow.ItemArray = New Object() {Description, RatingID}
            Me.Rows.Add(rowRatingDescriptionRow)
            Return rowRatingDescriptionRow
        End Function
        
        Public Function FindByRatingID(ByVal RatingID As Integer) As RatingDescriptionRow
            Return CType(Me.Rows.Find(New Object() {RatingID}),RatingDescriptionRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As RatingDescriptionDataTable = CType(MyBase.Clone,RatingDescriptionDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New RatingDescriptionDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnDescription = Me.Columns("Description")
            Me.columnRatingID = Me.Columns("RatingID")
        End Sub
        
        Private Sub InitClass()
            Me.columnDescription = New DataColumn("Description", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescription)
            Me.columnRatingID = New DataColumn("RatingID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRatingID)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnRatingID}, true))
            Me.columnRatingID.AllowDBNull = false
            Me.columnRatingID.Unique = true
        End Sub
        
        Public Function NewRatingDescriptionRow() As RatingDescriptionRow
            Return CType(Me.NewRow,RatingDescriptionRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New RatingDescriptionRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(RatingDescriptionRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RatingDescriptionRowChangedEvent) Is Nothing) Then
                RaiseEvent RatingDescriptionRowChanged(Me, New RatingDescriptionRowChangeEvent(CType(e.Row,RatingDescriptionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RatingDescriptionRowChangingEvent) Is Nothing) Then
                RaiseEvent RatingDescriptionRowChanging(Me, New RatingDescriptionRowChangeEvent(CType(e.Row,RatingDescriptionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RatingDescriptionRowDeletedEvent) Is Nothing) Then
                RaiseEvent RatingDescriptionRowDeleted(Me, New RatingDescriptionRowChangeEvent(CType(e.Row,RatingDescriptionRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RatingDescriptionRowDeletingEvent) Is Nothing) Then
                RaiseEvent RatingDescriptionRowDeleting(Me, New RatingDescriptionRowChangeEvent(CType(e.Row,RatingDescriptionRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveRatingDescriptionRow(ByVal row As RatingDescriptionRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RatingDescriptionRow
        Inherits DataRow
        
        Private tableRatingDescription As RatingDescriptionDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableRatingDescription = CType(Me.Table,RatingDescriptionDataTable)
        End Sub
        
        Public Property Description As String
            Get
                Try 
                    Return CType(Me(Me.tableRatingDescription.DescriptionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRatingDescription.DescriptionColumn) = value
            End Set
        End Property
        
        Public Property RatingID As Integer
            Get
                Return CType(Me(Me.tableRatingDescription.RatingIDColumn),Integer)
            End Get
            Set
                Me(Me.tableRatingDescription.RatingIDColumn) = value
            End Set
        End Property
        
        Public Function IsDescriptionNull() As Boolean
            Return Me.IsNull(Me.tableRatingDescription.DescriptionColumn)
        End Function
        
        Public Sub SetDescriptionNull()
            Me(Me.tableRatingDescription.DescriptionColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RatingDescriptionRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As RatingDescriptionRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As RatingDescriptionRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As RatingDescriptionRow
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
    Public Class RatingsDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnCustomerID As DataColumn
        
        Private columnProductID As DataColumn
        
        Private columnRatingID As DataColumn
        
        Friend Sub New()
            MyBase.New("Ratings")
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
        
        Friend ReadOnly Property ProductIDColumn As DataColumn
            Get
                Return Me.columnProductID
            End Get
        End Property
        
        Friend ReadOnly Property RatingIDColumn As DataColumn
            Get
                Return Me.columnRatingID
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As RatingsRow
            Get
                Return CType(Me.Rows(index),RatingsRow)
            End Get
        End Property
        
        Public Event RatingsRowChanged As RatingsRowChangeEventHandler
        
        Public Event RatingsRowChanging As RatingsRowChangeEventHandler
        
        Public Event RatingsRowDeleted As RatingsRowChangeEventHandler
        
        Public Event RatingsRowDeleting As RatingsRowChangeEventHandler
        
        Public Overloads Sub AddRatingsRow(ByVal row As RatingsRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddRatingsRow(ByVal CustomerID As String, ByVal parentProductsRowByProductsRatings As ProductsRow, ByVal RatingID As Integer) As RatingsRow
            Dim rowRatingsRow As RatingsRow = CType(Me.NewRow,RatingsRow)
            rowRatingsRow.ItemArray = New Object() {CustomerID, parentProductsRowByProductsRatings(2), RatingID}
            Me.Rows.Add(rowRatingsRow)
            Return rowRatingsRow
        End Function
        
        Public Function FindByCustomerIDProductID(ByVal CustomerID As String, ByVal ProductID As Integer) As RatingsRow
            Return CType(Me.Rows.Find(New Object() {CustomerID, ProductID}),RatingsRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As RatingsDataTable = CType(MyBase.Clone,RatingsDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New RatingsDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnCustomerID = Me.Columns("CustomerID")
            Me.columnProductID = Me.Columns("ProductID")
            Me.columnRatingID = Me.Columns("RatingID")
        End Sub
        
        Private Sub InitClass()
            Me.columnCustomerID = New DataColumn("CustomerID", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCustomerID)
            Me.columnProductID = New DataColumn("ProductID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnProductID)
            Me.columnRatingID = New DataColumn("RatingID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnRatingID)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnCustomerID, Me.columnProductID}, true))
            Me.columnCustomerID.AllowDBNull = false
            Me.columnProductID.AllowDBNull = false
        End Sub
        
        Public Function NewRatingsRow() As RatingsRow
            Return CType(Me.NewRow,RatingsRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New RatingsRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(RatingsRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.RatingsRowChangedEvent) Is Nothing) Then
                RaiseEvent RatingsRowChanged(Me, New RatingsRowChangeEvent(CType(e.Row,RatingsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.RatingsRowChangingEvent) Is Nothing) Then
                RaiseEvent RatingsRowChanging(Me, New RatingsRowChangeEvent(CType(e.Row,RatingsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.RatingsRowDeletedEvent) Is Nothing) Then
                RaiseEvent RatingsRowDeleted(Me, New RatingsRowChangeEvent(CType(e.Row,RatingsRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.RatingsRowDeletingEvent) Is Nothing) Then
                RaiseEvent RatingsRowDeleting(Me, New RatingsRowChangeEvent(CType(e.Row,RatingsRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveRatingsRow(ByVal row As RatingsRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RatingsRow
        Inherits DataRow
        
        Private tableRatings As RatingsDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableRatings = CType(Me.Table,RatingsDataTable)
        End Sub
        
        Public Property CustomerID As String
            Get
                Return CType(Me(Me.tableRatings.CustomerIDColumn),String)
            End Get
            Set
                Me(Me.tableRatings.CustomerIDColumn) = value
            End Set
        End Property
        
        Public Property ProductID As Integer
            Get
                Return CType(Me(Me.tableRatings.ProductIDColumn),Integer)
            End Get
            Set
                Me(Me.tableRatings.ProductIDColumn) = value
            End Set
        End Property
        
        Public Property RatingID As Integer
            Get
                Try 
                    Return CType(Me(Me.tableRatings.RatingIDColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableRatings.RatingIDColumn) = value
            End Set
        End Property
        
        Public Property ProductsRow As ProductsRow
            Get
                Return CType(Me.GetParentRow(Me.Table.ParentRelations("ProductsRatings")),ProductsRow)
            End Get
            Set
                Me.SetParentRow(value, Me.Table.ParentRelations("ProductsRatings"))
            End Set
        End Property
        
        Public Function IsRatingIDNull() As Boolean
            Return Me.IsNull(Me.tableRatings.RatingIDColumn)
        End Function
        
        Public Sub SetRatingIDNull()
            Me(Me.tableRatings.RatingIDColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class RatingsRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As RatingsRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As RatingsRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As RatingsRow
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
        
        Private columnAddress As DataColumn
        
        Private columnCity As DataColumn
        
        Private columnCompanyName As DataColumn
        
        Private columnContactName As DataColumn
        
        Private columnContactTitle As DataColumn
        
        Private columnCountry As DataColumn
        
        Private columnFax As DataColumn
        
        Private columnHomePage As DataColumn
        
        Private columnPhone As DataColumn
        
        Private columnPostalCode As DataColumn
        
        Private column_Region As DataColumn
        
        Private columnSupplierID As DataColumn
        
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
        
        Friend ReadOnly Property CountryColumn As DataColumn
            Get
                Return Me.columnCountry
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
        
        Friend ReadOnly Property PhoneColumn As DataColumn
            Get
                Return Me.columnPhone
            End Get
        End Property
        
        Friend ReadOnly Property PostalCodeColumn As DataColumn
            Get
                Return Me.columnPostalCode
            End Get
        End Property
        
        Friend ReadOnly Property _RegionColumn As DataColumn
            Get
                Return Me.column_Region
            End Get
        End Property
        
        Friend ReadOnly Property SupplierIDColumn As DataColumn
            Get
                Return Me.columnSupplierID
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
        
        Public Overloads Function AddSuppliersRow(ByVal Address As String, ByVal City As String, ByVal CompanyName As String, ByVal ContactName As String, ByVal ContactTitle As String, ByVal Country As String, ByVal Fax As String, ByVal HomePage As String, ByVal Phone As String, ByVal PostalCode As String, ByVal _Region As String) As SuppliersRow
            Dim rowSuppliersRow As SuppliersRow = CType(Me.NewRow,SuppliersRow)
            rowSuppliersRow.ItemArray = New Object() {Address, City, CompanyName, ContactName, ContactTitle, Country, Fax, HomePage, Phone, PostalCode, _Region, Nothing}
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
            Me.columnAddress = Me.Columns("Address")
            Me.columnCity = Me.Columns("City")
            Me.columnCompanyName = Me.Columns("CompanyName")
            Me.columnContactName = Me.Columns("ContactName")
            Me.columnContactTitle = Me.Columns("ContactTitle")
            Me.columnCountry = Me.Columns("Country")
            Me.columnFax = Me.Columns("Fax")
            Me.columnHomePage = Me.Columns("HomePage")
            Me.columnPhone = Me.Columns("Phone")
            Me.columnPostalCode = Me.Columns("PostalCode")
            Me.column_Region = Me.Columns("Region")
            Me.columnSupplierID = Me.Columns("SupplierID")
        End Sub
        
        Private Sub InitClass()
            Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress)
            Me.columnCity = New DataColumn("City", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCity)
            Me.columnCompanyName = New DataColumn("CompanyName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCompanyName)
            Me.columnContactName = New DataColumn("ContactName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnContactName)
            Me.columnContactTitle = New DataColumn("ContactTitle", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnContactTitle)
            Me.columnCountry = New DataColumn("Country", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCountry)
            Me.columnFax = New DataColumn("Fax", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFax)
            Me.columnHomePage = New DataColumn("HomePage", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnHomePage)
            Me.columnPhone = New DataColumn("Phone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhone)
            Me.columnPostalCode = New DataColumn("PostalCode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPostalCode)
            Me.column_Region = New DataColumn("Region", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_Region)
            Me.columnSupplierID = New DataColumn("SupplierID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSupplierID)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnSupplierID}, true))
            Me.columnSupplierID.AutoIncrement = true
            Me.columnSupplierID.AllowDBNull = false
            Me.columnSupplierID.Unique = true
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
        
        Public Property CompanyName As String
            Get
                Try 
                    Return CType(Me(Me.tableSuppliers.CompanyNameColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
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
        
        Public Property SupplierID As Integer
            Get
                Return CType(Me(Me.tableSuppliers.SupplierIDColumn),Integer)
            End Get
            Set
                Me(Me.tableSuppliers.SupplierIDColumn) = value
            End Set
        End Property
        
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
        
        Public Function IsCompanyNameNull() As Boolean
            Return Me.IsNull(Me.tableSuppliers.CompanyNameColumn)
        End Function
        
        Public Sub SetCompanyNameNull()
            Me(Me.tableSuppliers.CompanyNameColumn) = System.Convert.DBNull
        End Sub
        
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
        
        Public Function IsCountryNull() As Boolean
            Return Me.IsNull(Me.tableSuppliers.CountryColumn)
        End Function
        
        Public Sub SetCountryNull()
            Me(Me.tableSuppliers.CountryColumn) = System.Convert.DBNull
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
        
        Public Function IsPhoneNull() As Boolean
            Return Me.IsNull(Me.tableSuppliers.PhoneColumn)
        End Function
        
        Public Sub SetPhoneNull()
            Me(Me.tableSuppliers.PhoneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPostalCodeNull() As Boolean
            Return Me.IsNull(Me.tableSuppliers.PostalCodeColumn)
        End Function
        
        Public Sub SetPostalCodeNull()
            Me(Me.tableSuppliers.PostalCodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Is_RegionNull() As Boolean
            Return Me.IsNull(Me.tableSuppliers._RegionColumn)
        End Function
        
        Public Sub Set_RegionNull()
            Me(Me.tableSuppliers._RegionColumn) = System.Convert.DBNull
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
End Class
