Imports Microsoft.VisualBasic
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
Imports System.Data
Imports System.Xml
Imports System.Runtime.Serialization

Namespace GridSample


    <Serializable(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Diagnostics.DebuggerStepThrough(), System.ComponentModel.ToolboxItem(True)> _
 Public Class DataSet1
        Inherits DataSet

        Private tableCustomers As CustomersDataTable

        Private tableEmployees As EmployeesDataTable

        Private tableOrders As OrdersDataTable

        Public Sub New()
            Me.InitClass()
            Dim schemaChangedHandler As New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
        End Sub

        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            Dim strSchema As String = (CStr(info.GetValue("XmlSchema", GetType(String))))
            If (strSchema IsNot Nothing) Then
                Dim ds As New DataSet()
                ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
                If (ds.Tables("Customers") IsNot Nothing) Then
                    Me.Tables.Add(New CustomersDataTable(ds.Tables("Customers")))
                End If
                If (ds.Tables("Employees") IsNot Nothing) Then
                    Me.Tables.Add(New EmployeesDataTable(ds.Tables("Employees")))
                End If
                If (ds.Tables("Orders") IsNot Nothing) Then
                    Me.Tables.Add(New OrdersDataTable(ds.Tables("Orders")))
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
            Dim schemaChangedHandler As New System.ComponentModel.CollectionChangeEventHandler(AddressOf Me.SchemaChanged)
            AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
            AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
        End Sub

        <System.ComponentModel.Browsable(False), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Customers() As CustomersDataTable
            Get
                Return Me.tableCustomers
            End Get
        End Property

        <System.ComponentModel.Browsable(False), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Employees() As EmployeesDataTable
            Get
                Return Me.tableEmployees
            End Get
        End Property

        <System.ComponentModel.Browsable(False), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
        Public ReadOnly Property Orders() As OrdersDataTable
            Get
                Return Me.tableOrders
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
            Dim ds As New DataSet()
            ds.ReadXml(reader)
            If (ds.Tables("Customers") IsNot Nothing) Then
                Me.Tables.Add(New CustomersDataTable(ds.Tables("Customers")))
            End If
            If (ds.Tables("Employees") IsNot Nothing) Then
                Me.Tables.Add(New EmployeesDataTable(ds.Tables("Employees")))
            End If
            If (ds.Tables("Orders") IsNot Nothing) Then
                Me.Tables.Add(New OrdersDataTable(ds.Tables("Orders")))
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
            Dim stream As New System.IO.MemoryStream()
            Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
            stream.Position = 0
            Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
        End Function

        Friend Sub InitVars()
            Me.tableCustomers = (CType(Me.Tables("Customers"), CustomersDataTable))
            If (Me.tableCustomers IsNot Nothing) Then
                Me.tableCustomers.InitVars()
            End If
            Me.tableEmployees = (CType(Me.Tables("Employees"), EmployeesDataTable))
            If (Me.tableEmployees IsNot Nothing) Then
                Me.tableEmployees.InitVars()
            End If
            Me.tableOrders = (CType(Me.Tables("Orders"), OrdersDataTable))
            If (Me.tableOrders IsNot Nothing) Then
                Me.tableOrders.InitVars()
            End If
        End Sub

        Private Sub InitClass()
            Me.DataSetName = "DataSet1"
            Me.Prefix = ""
            Me.Namespace = "http://www.tempuri.org/DataSet1.xsd"
            Me.Locale = New System.Globalization.CultureInfo("en-US")
            Me.CaseSensitive = False
            Me.EnforceConstraints = True
            Me.tableCustomers = New CustomersDataTable()
            Me.Tables.Add(Me.tableCustomers)
            Me.tableEmployees = New EmployeesDataTable()
            Me.Tables.Add(Me.tableEmployees)
            Me.tableOrders = New OrdersDataTable()
            Me.Tables.Add(Me.tableOrders)
        End Sub

        Private Function ShouldSerializeCustomers() As Boolean
            Return False
        End Function

        Private Function ShouldSerializeEmployees() As Boolean
            Return False
        End Function

        Private Function ShouldSerializeOrders() As Boolean
            Return False
        End Function

        Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
            If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
                Me.InitVars()
            End If
        End Sub

        Public Delegate Sub CustomersRowChangeEventHandler(ByVal sender As Object, ByVal e As CustomersRowChangeEvent)

        Public Delegate Sub EmployeesRowChangeEventHandler(ByVal sender As Object, ByVal e As EmployeesRowChangeEvent)

        Public Delegate Sub OrdersRowChangeEventHandler(ByVal sender As Object, ByVal e As OrdersRowChangeEvent)

        <System.Diagnostics.DebuggerStepThrough()> _
        Public Class CustomersDataTable
            Inherits DataTable
            Implements System.Collections.IEnumerable

            Private columnCustomerID As DataColumn

            Private columnCompanyName As DataColumn

            Friend Sub New()
                MyBase.New("Customers")
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

            Friend ReadOnly Property CustomerIDColumn() As DataColumn
                Get
                    Return Me.columnCustomerID
                End Get
            End Property

            Friend ReadOnly Property CompanyNameColumn() As DataColumn
                Get
                    Return Me.columnCompanyName
                End Get
            End Property

            Default Public ReadOnly Property Item(ByVal index As Integer) As CustomersRow
                Get
                    Return (CType(Me.Rows(index), CustomersRow))
                End Get
            End Property

            Public Event CustomersRowChanged As CustomersRowChangeEventHandler

            Public Event CustomersRowChanging As CustomersRowChangeEventHandler

            Public Event CustomersRowDeleted As CustomersRowChangeEventHandler

            Public Event CustomersRowDeleting As CustomersRowChangeEventHandler

            Public Sub AddCustomersRow(ByVal row As CustomersRow)
                Me.Rows.Add(row)
            End Sub

            Public Function AddCustomersRow(ByVal CustomerID As String, ByVal CompanyName As String) As CustomersRow
                Dim rowCustomersRow As CustomersRow = (CType(Me.NewRow(), CustomersRow))
                rowCustomersRow.ItemArray = New Object() {CustomerID, CompanyName}
                Me.Rows.Add(rowCustomersRow)
                Return rowCustomersRow
            End Function

            Public Function FindByCustomerID(ByVal CustomerID As String) As CustomersRow
                Return (CType(Me.Rows.Find(New Object() {CustomerID}), CustomersRow))
            End Function

            Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            Public Overrides Function Clone() As DataTable
                Dim cln As CustomersDataTable = (CType(MyBase.Clone(), CustomersDataTable))
                cln.InitVars()
                Return cln
            End Function

            Protected Overrides Function CreateInstance() As DataTable
                Return New CustomersDataTable()
            End Function

            Friend Sub InitVars()
                Me.columnCustomerID = Me.Columns("CustomerID")
                Me.columnCompanyName = Me.Columns("CompanyName")
            End Sub

            Private Sub InitClass()
                Me.columnCustomerID = New DataColumn("CustomerID", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnCustomerID)
                Me.columnCompanyName = New DataColumn("CompanyName", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnCompanyName)
                Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnCustomerID}, True))
                Me.columnCustomerID.AllowDBNull = False
                Me.columnCustomerID.Unique = True
                Me.columnCompanyName.AllowDBNull = False
            End Sub

            Public Function NewCustomersRow() As CustomersRow
                Return (CType(Me.NewRow(), CustomersRow))
            End Function

            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New CustomersRow(builder)
            End Function

            Protected Overrides Function GetRowType() As System.Type
                Return GetType(CustomersRow)
            End Function

            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Me.CustomersRowChangedEvent IsNot Nothing) Then
                    RaiseEvent CustomersRowChanged(Me, New CustomersRowChangeEvent((CType(e.Row, CustomersRow)), e.Action))
                End If
            End Sub

            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Me.CustomersRowChangingEvent IsNot Nothing) Then
                    RaiseEvent CustomersRowChanging(Me, New CustomersRowChangeEvent((CType(e.Row, CustomersRow)), e.Action))
                End If
            End Sub

            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Me.CustomersRowDeletedEvent IsNot Nothing) Then
                    RaiseEvent CustomersRowDeleted(Me, New CustomersRowChangeEvent((CType(e.Row, CustomersRow)), e.Action))
                End If
            End Sub

            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Me.CustomersRowDeletingEvent IsNot Nothing) Then
                    RaiseEvent CustomersRowDeleting(Me, New CustomersRowChangeEvent((CType(e.Row, CustomersRow)), e.Action))
                End If
            End Sub

            Public Sub RemoveCustomersRow(ByVal row As CustomersRow)
                Me.Rows.Remove(row)
            End Sub
        End Class

        <System.Diagnostics.DebuggerStepThrough()> _
        Public Class CustomersRow
            Inherits DataRow

            Private tableCustomers As CustomersDataTable

            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableCustomers = (CType(Me.Table, CustomersDataTable))
            End Sub

            Public Property CustomerID() As String
                Get
                    Return (CStr(Me(Me.tableCustomers.CustomerIDColumn)))
                End Get
                Set(ByVal value As String)
                    Me(Me.tableCustomers.CustomerIDColumn) = value
                End Set
            End Property

            Public Property CompanyName() As String
                Get
                    Return (CStr(Me(Me.tableCustomers.CompanyNameColumn)))
                End Get
                Set(ByVal value As String)
                    Me(Me.tableCustomers.CompanyNameColumn) = value
                End Set
            End Property
        End Class

        <System.Diagnostics.DebuggerStepThrough()> _
        Public Class CustomersRowChangeEvent
            Inherits EventArgs

            Private eventRow As CustomersRow

            Private eventAction As DataRowAction

            Public Sub New(ByVal row As CustomersRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            Public ReadOnly Property Row() As CustomersRow
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
        Public Class EmployeesDataTable
            Inherits DataTable
            Implements System.Collections.IEnumerable

            Private columnEmployeeID As DataColumn

            Private columnLastName As DataColumn

            Friend Sub New()
                MyBase.New("Employees")
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

            Friend ReadOnly Property EmployeeIDColumn() As DataColumn
                Get
                    Return Me.columnEmployeeID
                End Get
            End Property

            Friend ReadOnly Property LastNameColumn() As DataColumn
                Get
                    Return Me.columnLastName
                End Get
            End Property

            Default Public ReadOnly Property Item(ByVal index As Integer) As EmployeesRow
                Get
                    Return (CType(Me.Rows(index), EmployeesRow))
                End Get
            End Property

            Public Event EmployeesRowChanged As EmployeesRowChangeEventHandler

            Public Event EmployeesRowChanging As EmployeesRowChangeEventHandler

            Public Event EmployeesRowDeleted As EmployeesRowChangeEventHandler

            Public Event EmployeesRowDeleting As EmployeesRowChangeEventHandler

            Public Sub AddEmployeesRow(ByVal row As EmployeesRow)
                Me.Rows.Add(row)
            End Sub

            Public Function AddEmployeesRow(ByVal LastName As String) As EmployeesRow
                Dim rowEmployeesRow As EmployeesRow = (CType(Me.NewRow(), EmployeesRow))
                rowEmployeesRow.ItemArray = New Object() {Nothing, LastName}
                Me.Rows.Add(rowEmployeesRow)
                Return rowEmployeesRow
            End Function

            Public Function FindByEmployeeID(ByVal EmployeeID As Integer) As EmployeesRow
                Return (CType(Me.Rows.Find(New Object() {EmployeeID}), EmployeesRow))
            End Function

            Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            Public Overrides Function Clone() As DataTable
                Dim cln As EmployeesDataTable = (CType(MyBase.Clone(), EmployeesDataTable))
                cln.InitVars()
                Return cln
            End Function

            Protected Overrides Function CreateInstance() As DataTable
                Return New EmployeesDataTable()
            End Function

            Friend Sub InitVars()
                Me.columnEmployeeID = Me.Columns("EmployeeID")
                Me.columnLastName = Me.Columns("LastName")
            End Sub

            Private Sub InitClass()
                Me.columnEmployeeID = New DataColumn("EmployeeID", GetType(Integer), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnEmployeeID)
                Me.columnLastName = New DataColumn("LastName", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnLastName)
                Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnEmployeeID}, True))
                Me.columnEmployeeID.AutoIncrement = True
                Me.columnEmployeeID.AllowDBNull = False
                Me.columnEmployeeID.ReadOnly = True
                Me.columnEmployeeID.Unique = True
                Me.columnLastName.AllowDBNull = False
            End Sub

            Public Function NewEmployeesRow() As EmployeesRow
                Return (CType(Me.NewRow(), EmployeesRow))
            End Function

            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New EmployeesRow(builder)
            End Function

            Protected Overrides Function GetRowType() As System.Type
                Return GetType(EmployeesRow)
            End Function

            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Me.EmployeesRowChangedEvent IsNot Nothing) Then
                    RaiseEvent EmployeesRowChanged(Me, New EmployeesRowChangeEvent((CType(e.Row, EmployeesRow)), e.Action))
                End If
            End Sub

            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Me.EmployeesRowChangingEvent IsNot Nothing) Then
                    RaiseEvent EmployeesRowChanging(Me, New EmployeesRowChangeEvent((CType(e.Row, EmployeesRow)), e.Action))
                End If
            End Sub

            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Me.EmployeesRowDeletedEvent IsNot Nothing) Then
                    RaiseEvent EmployeesRowDeleted(Me, New EmployeesRowChangeEvent((CType(e.Row, EmployeesRow)), e.Action))
                End If
            End Sub

            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Me.EmployeesRowDeletingEvent IsNot Nothing) Then
                    RaiseEvent EmployeesRowDeleting(Me, New EmployeesRowChangeEvent((CType(e.Row, EmployeesRow)), e.Action))
                End If
            End Sub

            Public Sub RemoveEmployeesRow(ByVal row As EmployeesRow)
                Me.Rows.Remove(row)
            End Sub
        End Class

        <System.Diagnostics.DebuggerStepThrough()> _
        Public Class EmployeesRow
            Inherits DataRow

            Private tableEmployees As EmployeesDataTable

            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableEmployees = (CType(Me.Table, EmployeesDataTable))
            End Sub

            Public Property EmployeeID() As Integer
                Get
                    Return (CInt(Fix(Me(Me.tableEmployees.EmployeeIDColumn))))
                End Get
                Set(ByVal value As Integer)
                    Me(Me.tableEmployees.EmployeeIDColumn) = value
                End Set
            End Property

            Public Property LastName() As String
                Get
                    Return (CStr(Me(Me.tableEmployees.LastNameColumn)))
                End Get
                Set(ByVal value As String)
                    Me(Me.tableEmployees.LastNameColumn) = value
                End Set
            End Property
        End Class

        <System.Diagnostics.DebuggerStepThrough()> _
        Public Class EmployeesRowChangeEvent
            Inherits EventArgs

            Private eventRow As EmployeesRow

            Private eventAction As DataRowAction

            Public Sub New(ByVal row As EmployeesRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            Public ReadOnly Property Row() As EmployeesRow
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

            Friend ReadOnly Property OrderIDColumn() As DataColumn
                Get
                    Return Me.columnOrderID
                End Get
            End Property

            Friend ReadOnly Property CustomerIDColumn() As DataColumn
                Get
                    Return Me.columnCustomerID
                End Get
            End Property

            Friend ReadOnly Property EmployeeIDColumn() As DataColumn
                Get
                    Return Me.columnEmployeeID
                End Get
            End Property

            Friend ReadOnly Property OrderDateColumn() As DataColumn
                Get
                    Return Me.columnOrderDate
                End Get
            End Property

            Friend ReadOnly Property RequiredDateColumn() As DataColumn
                Get
                    Return Me.columnRequiredDate
                End Get
            End Property

            Friend ReadOnly Property ShippedDateColumn() As DataColumn
                Get
                    Return Me.columnShippedDate
                End Get
            End Property

            Friend ReadOnly Property ShipViaColumn() As DataColumn
                Get
                    Return Me.columnShipVia
                End Get
            End Property

            Friend ReadOnly Property FreightColumn() As DataColumn
                Get
                    Return Me.columnFreight
                End Get
            End Property

            Friend ReadOnly Property ShipNameColumn() As DataColumn
                Get
                    Return Me.columnShipName
                End Get
            End Property

            Friend ReadOnly Property ShipAddressColumn() As DataColumn
                Get
                    Return Me.columnShipAddress
                End Get
            End Property

            Friend ReadOnly Property ShipCityColumn() As DataColumn
                Get
                    Return Me.columnShipCity
                End Get
            End Property

            Friend ReadOnly Property ShipRegionColumn() As DataColumn
                Get
                    Return Me.columnShipRegion
                End Get
            End Property

            Friend ReadOnly Property ShipPostalCodeColumn() As DataColumn
                Get
                    Return Me.columnShipPostalCode
                End Get
            End Property

            Friend ReadOnly Property ShipCountryColumn() As DataColumn
                Get
                    Return Me.columnShipCountry
                End Get
            End Property

            Default Public ReadOnly Property Item(ByVal index As Integer) As OrdersRow
                Get
                    Return (CType(Me.Rows(index), OrdersRow))
                End Get
            End Property

            Public Event OrdersRowChanged As OrdersRowChangeEventHandler

            Public Event OrdersRowChanging As OrdersRowChangeEventHandler

            Public Event OrdersRowDeleted As OrdersRowChangeEventHandler

            Public Event OrdersRowDeleting As OrdersRowChangeEventHandler

            Public Sub AddOrdersRow(ByVal row As OrdersRow)
                Me.Rows.Add(row)
            End Sub

            Public Function AddOrdersRow(ByVal CustomerID As String, ByVal EmployeeID As Integer, ByVal OrderDate As System.DateTime, ByVal RequiredDate As System.DateTime, ByVal ShippedDate As System.DateTime, ByVal ShipVia As Integer, ByVal Freight As System.Decimal, ByVal ShipName As String, ByVal ShipAddress As String, ByVal ShipCity As String, ByVal ShipRegion As String, ByVal ShipPostalCode As String, ByVal ShipCountry As String) As OrdersRow
                Dim rowOrdersRow As OrdersRow = (CType(Me.NewRow(), OrdersRow))
                rowOrdersRow.ItemArray = New Object() {Nothing, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry}
                Me.Rows.Add(rowOrdersRow)
                Return rowOrdersRow
            End Function

            Public Function FindByOrderID(ByVal OrderID As Integer) As OrdersRow
                Return (CType(Me.Rows.Find(New Object() {OrderID}), OrdersRow))
            End Function

            Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
                Return Me.Rows.GetEnumerator()
            End Function

            Public Overrides Function Clone() As DataTable
                Dim cln As OrdersDataTable = (CType(MyBase.Clone(), OrdersDataTable))
                cln.InitVars()
                Return cln
            End Function

            Protected Overrides Function CreateInstance() As DataTable
                Return New OrdersDataTable()
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
                Me.columnOrderID = New DataColumn("OrderID", GetType(Integer), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnOrderID)
                Me.columnCustomerID = New DataColumn("CustomerID", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnCustomerID)
                Me.columnEmployeeID = New DataColumn("EmployeeID", GetType(Integer), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnEmployeeID)
                Me.columnOrderDate = New DataColumn("OrderDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnOrderDate)
                Me.columnRequiredDate = New DataColumn("RequiredDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnRequiredDate)
                Me.columnShippedDate = New DataColumn("ShippedDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnShippedDate)
                Me.columnShipVia = New DataColumn("ShipVia", GetType(Integer), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnShipVia)
                Me.columnFreight = New DataColumn("Freight", GetType(System.Decimal), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnFreight)
                Me.columnShipName = New DataColumn("ShipName", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnShipName)
                Me.columnShipAddress = New DataColumn("ShipAddress", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnShipAddress)
                Me.columnShipCity = New DataColumn("ShipCity", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnShipCity)
                Me.columnShipRegion = New DataColumn("ShipRegion", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnShipRegion)
                Me.columnShipPostalCode = New DataColumn("ShipPostalCode", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnShipPostalCode)
                Me.columnShipCountry = New DataColumn("ShipCountry", GetType(String), Nothing, System.Data.MappingType.Element)
                Me.Columns.Add(Me.columnShipCountry)
                Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnOrderID}, True))
                Me.columnOrderID.AutoIncrement = True
                Me.columnOrderID.AllowDBNull = False
                Me.columnOrderID.ReadOnly = True
                Me.columnOrderID.Unique = True
            End Sub

            Public Function NewOrdersRow() As OrdersRow
                Return (CType(Me.NewRow(), OrdersRow))
            End Function

            Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
                Return New OrdersRow(builder)
            End Function

            Protected Overrides Function GetRowType() As System.Type
                Return GetType(OrdersRow)
            End Function

            Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanged(e)
                If (Me.OrdersRowChangedEvent IsNot Nothing) Then
                    RaiseEvent OrdersRowChanged(Me, New OrdersRowChangeEvent((CType(e.Row, OrdersRow)), e.Action))
                End If
            End Sub

            Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowChanging(e)
                If (Me.OrdersRowChangingEvent IsNot Nothing) Then
                    RaiseEvent OrdersRowChanging(Me, New OrdersRowChangeEvent((CType(e.Row, OrdersRow)), e.Action))
                End If
            End Sub

            Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleted(e)
                If (Me.OrdersRowDeletedEvent IsNot Nothing) Then
                    RaiseEvent OrdersRowDeleted(Me, New OrdersRowChangeEvent((CType(e.Row, OrdersRow)), e.Action))
                End If
            End Sub

            Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
                MyBase.OnRowDeleting(e)
                If (Me.OrdersRowDeletingEvent IsNot Nothing) Then
                    RaiseEvent OrdersRowDeleting(Me, New OrdersRowChangeEvent((CType(e.Row, OrdersRow)), e.Action))
                End If
            End Sub

            Public Sub RemoveOrdersRow(ByVal row As OrdersRow)
                Me.Rows.Remove(row)
            End Sub
        End Class

        <System.Diagnostics.DebuggerStepThrough()> _
        Public Class OrdersRow
            Inherits DataRow

            Private tableOrders As OrdersDataTable

            Friend Sub New(ByVal rb As DataRowBuilder)
                MyBase.New(rb)
                Me.tableOrders = (CType(Me.Table, OrdersDataTable))
            End Sub

            Public Property OrderID() As Integer
                Get
                    Return (CInt(Fix(Me(Me.tableOrders.OrderIDColumn))))
                End Get
                Set(ByVal value As Integer)
                    Me(Me.tableOrders.OrderIDColumn) = value
                End Set
            End Property

            Public Property CustomerID() As String
                Get
                    Try
                        Return (CStr(Me(Me.tableOrders.CustomerIDColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As String)
                    Me(Me.tableOrders.CustomerIDColumn) = value
                End Set
            End Property

            Public Property EmployeeID() As Integer
                Get
                    Try
                        Return (CInt(Fix(Me(Me.tableOrders.EmployeeIDColumn))))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As Integer)
                    Me(Me.tableOrders.EmployeeIDColumn) = value
                End Set
            End Property

            Public Property OrderDate() As System.DateTime
                Get
                    Try
                        Return (CDate(Me(Me.tableOrders.OrderDateColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As System.DateTime)
                    Me(Me.tableOrders.OrderDateColumn) = value
                End Set
            End Property

            Public Property RequiredDate() As System.DateTime
                Get
                    Try
                        Return (CDate(Me(Me.tableOrders.RequiredDateColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As System.DateTime)
                    Me(Me.tableOrders.RequiredDateColumn) = value
                End Set
            End Property

            Public Property ShippedDate() As System.DateTime
                Get
                    Try
                        Return (CDate(Me(Me.tableOrders.ShippedDateColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As System.DateTime)
                    Me(Me.tableOrders.ShippedDateColumn) = value
                End Set
            End Property

            Public Property ShipVia() As Integer
                Get
                    Try
                        Return (CInt(Fix(Me(Me.tableOrders.ShipViaColumn))))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As Integer)
                    Me(Me.tableOrders.ShipViaColumn) = value
                End Set
            End Property

            Public Property Freight() As System.Decimal
                Get
                    Try
                        Return (CDec(Me(Me.tableOrders.FreightColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As System.Decimal)
                    Me(Me.tableOrders.FreightColumn) = value
                End Set
            End Property

            Public Property ShipName() As String
                Get
                    Try
                        Return (CStr(Me(Me.tableOrders.ShipNameColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As String)
                    Me(Me.tableOrders.ShipNameColumn) = value
                End Set
            End Property

            Public Property ShipAddress() As String
                Get
                    Try
                        Return (CStr(Me(Me.tableOrders.ShipAddressColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As String)
                    Me(Me.tableOrders.ShipAddressColumn) = value
                End Set
            End Property

            Public Property ShipCity() As String
                Get
                    Try
                        Return (CStr(Me(Me.tableOrders.ShipCityColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As String)
                    Me(Me.tableOrders.ShipCityColumn) = value
                End Set
            End Property

            Public Property ShipRegion() As String
                Get
                    Try
                        Return (CStr(Me(Me.tableOrders.ShipRegionColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As String)
                    Me(Me.tableOrders.ShipRegionColumn) = value
                End Set
            End Property

            Public Property ShipPostalCode() As String
                Get
                    Try
                        Return (CStr(Me(Me.tableOrders.ShipPostalCodeColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As String)
                    Me(Me.tableOrders.ShipPostalCodeColumn) = value
                End Set
            End Property

            Public Property ShipCountry() As String
                Get
                    Try
                        Return (CStr(Me(Me.tableOrders.ShipCountryColumn)))
                    Catch e As InvalidCastException
                        Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                    End Try
                End Get
                Set(ByVal value As String)
                    Me(Me.tableOrders.ShipCountryColumn) = value
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
        End Class

        <System.Diagnostics.DebuggerStepThrough()> _
        Public Class OrdersRowChangeEvent
            Inherits EventArgs

            Private eventRow As OrdersRow

            Private eventAction As DataRowAction

            Public Sub New(ByVal row As OrdersRow, ByVal action As DataRowAction)
                Me.eventRow = row
                Me.eventAction = action
            End Sub

            Public ReadOnly Property Row() As OrdersRow
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