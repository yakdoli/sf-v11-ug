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
Public Class ShippersDataSet
    Inherits DataSet
    
    Private tableShippers As ShippersDataTable
    
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
            If (Not (ds.Tables("Shippers")) Is Nothing) Then
                Me.Tables.Add(New ShippersDataTable(ds.Tables("Shippers")))
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
    Public ReadOnly Property Shippers As ShippersDataTable
        Get
            Return Me.tableShippers
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As ShippersDataSet = CType(MyBase.Clone,ShippersDataSet)
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
        If (Not (ds.Tables("Shippers")) Is Nothing) Then
            Me.Tables.Add(New ShippersDataTable(ds.Tables("Shippers")))
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
        Me.tableShippers = CType(Me.Tables("Shippers"),ShippersDataTable)
        If (Not (Me.tableShippers) Is Nothing) Then
            Me.tableShippers.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "ShippersDataSet"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/ShippersDataSet.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableShippers = New ShippersDataTable
        Me.Tables.Add(Me.tableShippers)
    End Sub
    
    Private Function ShouldSerializeShippers() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub ShippersRowChangeEventHandler(ByVal sender As Object, ByVal e As ShippersRowChangeEvent)
    
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
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnShipperID}, true))
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
End Class
