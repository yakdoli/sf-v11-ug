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
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class DataSet1
    Inherits DataSet
    
    Private tableOrder_Details As Order_DetailsDataTable
    
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
            If (Not (ds.Tables("Order Details")) Is Nothing) Then
                Me.Tables.Add(New Order_DetailsDataTable(ds.Tables("Order Details")))
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
    Public ReadOnly Property Order_Details As Order_DetailsDataTable
        Get
            Return Me.tableOrder_Details
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As DataSet1 = CType(MyBase.Clone,DataSet1)
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
        If (Not (ds.Tables("Order Details")) Is Nothing) Then
            Me.Tables.Add(New Order_DetailsDataTable(ds.Tables("Order Details")))
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
        Me.tableOrder_Details = CType(Me.Tables("Order Details"),Order_DetailsDataTable)
        If (Not (Me.tableOrder_Details) Is Nothing) Then
            Me.tableOrder_Details.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "DataSet1"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableOrder_Details = New Order_DetailsDataTable
        Me.Tables.Add(Me.tableOrder_Details)
    End Sub
    
    Private Function ShouldSerializeOrder_Details() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub Order_DetailsRowChangeEventHandler(ByVal sender As Object, ByVal e As Order_DetailsRowChangeEvent)
    
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
        
        Public Overloads Function AddOrder_DetailsRow(ByVal OrderID As Integer, ByVal ProductID As Integer, ByVal UnitPrice As Decimal, ByVal Quantity As Short, ByVal Discount As Single) As Order_DetailsRow
            Dim rowOrder_DetailsRow As Order_DetailsRow = CType(Me.NewRow,Order_DetailsRow)
            rowOrder_DetailsRow.ItemArray = New Object() {OrderID, ProductID, UnitPrice, Quantity, Discount}
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
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnOrderID, Me.columnProductID}, true))
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
End Class
