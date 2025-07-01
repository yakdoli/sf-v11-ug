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
Imports System.Xml
Imports System.Runtime.Serialization



<Serializable(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Diagnostics.DebuggerStepThrough(), System.ComponentModel.ToolboxItem(True)>  _
Public Class DataSet1
   Inherits DataSet
   
   Private tableCustomers As CustomersDataTable
   
   
   Public Sub New()
      Me.InitClass()
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
   End Sub 'New
   
   
   Protected Sub New(info As SerializationInfo, context As StreamingContext)
      Dim strSchema As String = CStr(info.GetValue("XmlSchema", GetType(String)))
      If Not (strSchema Is Nothing) Then
         Dim ds As New DataSet()
         ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
         If Not (ds.Tables("Customers") Is Nothing) Then
            Me.Tables.Add(New CustomersDataTable(ds.Tables("Customers")))
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
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub 'New


    <System.ComponentModel.Browsable(False), System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)> _
    Public ReadOnly Property Customers() As CustomersDataTable
        Get
            Return Me.tableCustomers
        End Get
    End Property


    Public Overrides Function Clone() As DataSet
        Dim cln As DataSet1 = CType(MyBase.Clone(), DataSet1)
        cln.InitVars()
        Return cln
    End Function 'Clone


    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return False
    End Function 'ShouldSerializeTables


    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return False
    End Function 'ShouldSerializeRelations


    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset()
        Dim ds As New DataSet()
        ds.ReadXml(reader)
        If Not (ds.Tables("Customers") Is Nothing) Then
            Me.Tables.Add(New CustomersDataTable(ds.Tables("Customers")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, False, System.Data.MissingSchemaAction.Add)
        Me.InitVars()
    End Sub 'ReadXmlSerializable


    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As New System.IO.MemoryStream()
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function 'GetSchemaSerializable


    Friend Sub InitVars()
        Me.tableCustomers = CType(Me.Tables("Customers"), CustomersDataTable)
        If Not (Me.tableCustomers Is Nothing) Then
            Me.tableCustomers.InitVars()
        End If
    End Sub 'InitVars


    Private Sub InitClass()
        Me.DataSetName = "DataSet1"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = False
        Me.EnforceConstraints = True
        Me.tableCustomers = New CustomersDataTable()
        Me.Tables.Add(Me.tableCustomers)
    End Sub 'InitClass


    Private Function ShouldSerializeCustomers() As Boolean
        Return False
    End Function 'ShouldSerializeCustomers


    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If e.Action = System.ComponentModel.CollectionChangeAction.Remove Then
            Me.InitVars()
        End If
    End Sub 'SchemaChanged


    Delegate Sub CustomersRowChangeEventHandler(ByVal sender As Object, ByVal e As CustomersRowChangeEvent)

    <System.Diagnostics.DebuggerStepThrough()> _
    Public Class CustomersDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable 'ToDo: Add Implements Clauses for implementation methods of these interface(s)

        Private columnCustomerName As DataColumn

        Private columnID As DataColumn

        Private columnSex As DataColumn


        Friend Sub New()
            MyBase.New("Customers")
            Me.InitClass()
        End Sub 'New


        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If table.CaseSensitive <> table.DataSet.CaseSensitive Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If table.Locale.ToString() <> table.DataSet.Locale.ToString() Then
                Me.Locale = table.Locale
            End If
            If table.Namespace <> table.DataSet.Namespace Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub 'New


        <System.ComponentModel.Browsable(False)> _
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property


        Friend ReadOnly Property CustomerNameColumn() As DataColumn
            Get
                Return Me.columnCustomerName
            End Get
        End Property


        Friend ReadOnly Property IDColumn() As DataColumn
            Get
                Return Me.columnID
            End Get
        End Property


        Friend ReadOnly Property SexColumn() As DataColumn
            Get
                Return Me.columnSex
            End Get
        End Property


        Default Public ReadOnly Property Item(ByVal index As Integer) As CustomersRow
            Get
                Return CType(Me.Rows(index), CustomersRow)
            End Get
        End Property

        Public Event CustomersRowChanged As CustomersRowChangeEventHandler

        Public Event CustomersRowChanging As CustomersRowChangeEventHandler

        Public Event CustomersRowDeleted As CustomersRowChangeEventHandler

        Public Event CustomersRowDeleting As CustomersRowChangeEventHandler


        Public Overloads Sub AddCustomersRow(ByVal row As CustomersRow)
            Me.Rows.Add(row)
        End Sub 'AddCustomersRow


        Public Overloads Function AddCustomersRow(ByVal CustomerName As String, ByVal Sex As String) As CustomersRow
            Dim rowCustomersRow As CustomersRow = CType(Me.NewRow(), CustomersRow)
            rowCustomersRow.ItemArray = New Object() {CustomerName, Nothing, Sex}
            Me.Rows.Add(rowCustomersRow)
            Return rowCustomersRow
        End Function 'AddCustomersRow


        Public Function FindByID(ByVal ID As Integer) As CustomersRow
            Return CType(Me.Rows.Find(New Object() {ID}), CustomersRow)
        End Function 'FindByID


        Public Function GetEnumerator() As System.Collections.IEnumerator Implements IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator()
        End Function 'GetEnumerator


        Public Overrides Function Clone() As DataTable
            Dim cln As CustomersDataTable = CType(MyBase.Clone(), CustomersDataTable)
            cln.InitVars()
            Return cln
        End Function 'Clone


        Protected Overrides Function CreateInstance() As DataTable
            Return New CustomersDataTable()
        End Function 'CreateInstance


        Friend Sub InitVars()
            Me.columnCustomerName = Me.Columns("CustomerName")
            Me.columnID = Me.Columns("ID")
            Me.columnSex = Me.Columns("Sex")
        End Sub 'InitVars


        Private Sub InitClass()
            Me.columnCustomerName = New DataColumn("CustomerName", GetType(String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCustomerName)
            Me.columnID = New DataColumn("ID", GetType(Integer), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.columnSex = New DataColumn("Sex", GetType(String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnSex)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnID}, True))
            Me.columnID.AutoIncrement = True
            Me.columnID.AllowDBNull = False
            Me.columnID.Unique = True
        End Sub 'InitClass


        Public Function NewCustomersRow() As CustomersRow
            Return CType(Me.NewRow(), CustomersRow)
        End Function 'NewCustomersRow


        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New CustomersRow(builder)
        End Function 'NewRowFromBuilder


        Protected Overrides Function GetRowType() As System.Type
            Return GetType(CustomersRow)
        End Function 'GetRowType


        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.CustomersRowChangedEvent) Is Nothing) Then
                RaiseEvent CustomersRowChanged(Me, New CustomersRowChangeEvent(CType(e.Row, CustomersRow), e.Action))
            End If
        End Sub 'OnRowChanged


        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.CustomersRowChangingEvent) Is Nothing) Then
                RaiseEvent CustomersRowChanging(Me, New CustomersRowChangeEvent(CType(e.Row, CustomersRow), e.Action))
            End If
        End Sub 'OnRowChanging


        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.CustomersRowDeletedEvent) Is Nothing) Then
                RaiseEvent CustomersRowDeleted(Me, New CustomersRowChangeEvent(CType(e.Row, CustomersRow), e.Action))
            End If
        End Sub 'OnRowDeleted


        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.CustomersRowDeletingEvent) Is Nothing) Then
                RaiseEvent CustomersRowDeleting(Me, New CustomersRowChangeEvent(CType(e.Row, CustomersRow), e.Action))
            End If
        End Sub 'OnRowDeleting


        Public Sub RemoveCustomersRow(ByVal row As CustomersRow)
            Me.Rows.Remove(row)
        End Sub 'RemoveCustomersRow
    End Class 'CustomersDataTable

    <System.Diagnostics.DebuggerStepThrough()> _
    Public Class CustomersRow
        Inherits DataRow

        Private tableCustomers As CustomersDataTable


        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableCustomers = CType(Me.Table, CustomersDataTable)
        End Sub 'New


        Public Property CustomerName() As String
            Get
                Try
                    Return CStr(Me(Me.tableCustomers.CustomerNameColumn))
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set(ByVal Value As String)
                Me(Me.tableCustomers.CustomerNameColumn) = Value
            End Set
        End Property


        Public Property ID() As Integer
            Get
                Return Fix(Me(Me.tableCustomers.IDColumn))
            End Get
            Set(ByVal Value As Integer)
                Me(Me.tableCustomers.IDColumn) = Value
            End Set
        End Property


        Public Property Sex() As String
            Get
                Try
                    Return CStr(Me(Me.tableCustomers.SexColumn))
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set(ByVal Value As String)
                Me(Me.tableCustomers.SexColumn) = Value
            End Set
        End Property


        Public Function IsCustomerNameNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.CustomerNameColumn)
        End Function 'IsCustomerNameNull


        Public Sub SetCustomerNameNull()
            Me(Me.tableCustomers.CustomerNameColumn) = System.Convert.DBNull
        End Sub 'SetCustomerNameNull


        Public Function IsSexNull() As Boolean
            Return Me.IsNull(Me.tableCustomers.SexColumn)
        End Function 'IsSexNull


        Public Sub SetSexNull()
            Me(Me.tableCustomers.SexColumn) = System.Convert.DBNull
        End Sub 'SetSexNull
    End Class 'CustomersRow

    <System.Diagnostics.DebuggerStepThrough()> _
    Public Class CustomersRowChangeEvent
        Inherits EventArgs

        Private eventRow As CustomersRow

        Private eventAction As DataRowAction


        Public Sub New(ByVal row As CustomersRow, ByVal action As DataRowAction)
            Me.eventRow = row
            Me.eventAction = action
        End Sub 'New


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
    End Class 'CustomersRowChangeEvent
End Class 'DataSet1