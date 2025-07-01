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
Public Class DataSet2
   Inherits DataSet
   
   Private tableSex_Description As Sex_DescriptionDataTable
   
   
   Public Sub New()
      Me.InitClass()
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub 'New


    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        Dim strSchema As String = CStr(info.GetValue("XmlSchema", GetType(String)))
        If Not (strSchema Is Nothing) Then
            Dim ds As New DataSet()
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If Not (ds.Tables("Sex_Description") Is Nothing) Then
                Me.Tables.Add(New Sex_DescriptionDataTable(ds.Tables("Sex_Description")))
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
    Public ReadOnly Property Sex_Description() As Sex_DescriptionDataTable
        Get
            Return Me.tableSex_Description
        End Get
    End Property


    Public Overrides Function Clone() As DataSet
        Dim cln As DataSet2 = CType(MyBase.Clone(), DataSet2)
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
        If Not (ds.Tables("Sex_Description") Is Nothing) Then
            Me.Tables.Add(New Sex_DescriptionDataTable(ds.Tables("Sex_Description")))
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
        Me.tableSex_Description = CType(Me.Tables("Sex_Description"), Sex_DescriptionDataTable)
        If Not (Me.tableSex_Description Is Nothing) Then
            Me.tableSex_Description.InitVars()
        End If
    End Sub 'InitVars


    Private Sub InitClass()
        Me.DataSetName = "DataSet2"
        Me.Prefix = ""
        Me.Namespace = "http://www.tempuri.org/DataSet2.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = False
        Me.EnforceConstraints = True
        Me.tableSex_Description = New Sex_DescriptionDataTable()
        Me.Tables.Add(Me.tableSex_Description)
    End Sub 'InitClass


    Private Function ShouldSerializeSex_Description() As Boolean
        Return False
    End Function 'ShouldSerializeSex_Description


    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If e.Action = System.ComponentModel.CollectionChangeAction.Remove Then
            Me.InitVars()
        End If
    End Sub 'SchemaChanged


    Delegate Sub Sex_DescriptionRowChangeEventHandler(ByVal sender As Object, ByVal e As Sex_DescriptionRowChangeEvent)

    <System.Diagnostics.DebuggerStepThrough()> _
    Public Class Sex_DescriptionDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable

        Private columnDescription As DataColumn

        Private columnID As DataColumn


        Friend Sub New()
            MyBase.New("Sex_Description")
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


        Friend ReadOnly Property DescriptionColumn() As DataColumn
            Get
                Return Me.columnDescription
            End Get
        End Property


        Friend ReadOnly Property IDColumn() As DataColumn
            Get
                Return Me.columnID
            End Get
        End Property


        Default Public ReadOnly Property Item(ByVal index As Integer) As Sex_DescriptionRow
            Get
                Return CType(Me.Rows(index), Sex_DescriptionRow)
            End Get
        End Property

        Public Event Sex_DescriptionRowChanged As Sex_DescriptionRowChangeEventHandler

        Public Event Sex_DescriptionRowChanging As Sex_DescriptionRowChangeEventHandler

        Public Event Sex_DescriptionRowDeleted As Sex_DescriptionRowChangeEventHandler

        Public Event Sex_DescriptionRowDeleting As Sex_DescriptionRowChangeEventHandler


        Public Overloads Sub AddSex_DescriptionRow(ByVal row As Sex_DescriptionRow)
            Me.Rows.Add(row)
        End Sub 'AddSex_DescriptionRow


        Public Overloads Function AddSex_DescriptionRow(ByVal Description As String) As Sex_DescriptionRow
            Dim rowSex_DescriptionRow As Sex_DescriptionRow = CType(Me.NewRow(), Sex_DescriptionRow)
            rowSex_DescriptionRow.ItemArray = New Object() {Description, Nothing}
            Me.Rows.Add(rowSex_DescriptionRow)
            Return rowSex_DescriptionRow
        End Function 'AddSex_DescriptionRow


        Public Function FindByID(ByVal ID As Integer) As Sex_DescriptionRow
            Return CType(Me.Rows.Find(New Object() {ID}), Sex_DescriptionRow)
        End Function 'FindByID


        Public Function GetEnumerator() As System.Collections.IEnumerator Implements IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator()
        End Function 'GetEnumerator


        Public Overrides Function Clone() As DataTable
            Dim cln As Sex_DescriptionDataTable = CType(MyBase.Clone(), Sex_DescriptionDataTable)
            cln.InitVars()
            Return cln
        End Function 'Clone


        Protected Overrides Function CreateInstance() As DataTable
            Return New Sex_DescriptionDataTable()
        End Function 'CreateInstance


        Friend Sub InitVars()
            Me.columnDescription = Me.Columns("Description")
            Me.columnID = Me.Columns("ID")
        End Sub 'InitVars


        Private Sub InitClass()
            Me.columnDescription = New DataColumn("Description", GetType(String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnDescription)
            Me.columnID = New DataColumn("ID", GetType(Integer), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnID)
            Me.Constraints.Add(New UniqueConstraint("Constraint1", New DataColumn() {Me.columnID}, True))
            Me.columnID.AutoIncrement = True
            Me.columnID.AllowDBNull = False
            Me.columnID.Unique = True
        End Sub 'InitClass


        Public Function NewSex_DescriptionRow() As Sex_DescriptionRow
            Return CType(Me.NewRow(), Sex_DescriptionRow)
        End Function 'NewSex_DescriptionRow


        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New Sex_DescriptionRow(builder)
        End Function 'NewRowFromBuilder


        Protected Overrides Function GetRowType() As System.Type
            Return GetType(Sex_DescriptionRow)
        End Function 'GetRowType


        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.Sex_DescriptionRowChangedEvent) Is Nothing) Then
                RaiseEvent Sex_DescriptionRowChanged(Me, New Sex_DescriptionRowChangeEvent(CType(e.Row, Sex_DescriptionRow), e.Action))
            End If
        End Sub 'OnRowChanged


        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.Sex_DescriptionRowChangingEvent) Is Nothing) Then
                RaiseEvent Sex_DescriptionRowChanging(Me, New Sex_DescriptionRowChangeEvent(CType(e.Row, Sex_DescriptionRow), e.Action))
            End If
        End Sub 'OnRowChanging


        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.Sex_DescriptionRowDeletedEvent) Is Nothing) Then
                RaiseEvent Sex_DescriptionRowDeleted(Me, New Sex_DescriptionRowChangeEvent(CType(e.Row, Sex_DescriptionRow), e.Action))
            End If
        End Sub 'OnRowDeleted


        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.Sex_DescriptionRowDeletingEvent) Is Nothing) Then
                RaiseEvent Sex_DescriptionRowDeleting(Me, New Sex_DescriptionRowChangeEvent(CType(e.Row, Sex_DescriptionRow), e.Action))
            End If
        End Sub 'OnRowDeleting


        Public Sub RemoveSex_DescriptionRow(ByVal row As Sex_DescriptionRow)
            Me.Rows.Remove(row)
        End Sub 'RemoveSex_DescriptionRow
    End Class 'Sex_DescriptionDataTable

    <System.Diagnostics.DebuggerStepThrough()> _
    Public Class Sex_DescriptionRow
        Inherits DataRow

        Private tableSex_Description As Sex_DescriptionDataTable


        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableSex_Description = CType(Me.Table, Sex_DescriptionDataTable)
        End Sub 'New


        Public Property Description() As String
            Get
                Try
                    Return CStr(Me(Me.tableSex_Description.DescriptionColumn))
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set(ByVal Value As String)
                Me(Me.tableSex_Description.DescriptionColumn) = Value
            End Set
        End Property


        Public Property ID() As Integer
            Get
                Return Fix(Me(Me.tableSex_Description.IDColumn))
            End Get
            Set(ByVal Value As Integer)
                Me(Me.tableSex_Description.IDColumn) = Value
            End Set
        End Property


        Public Function IsDescriptionNull() As Boolean
            Return Me.IsNull(Me.tableSex_Description.DescriptionColumn)
        End Function 'IsDescriptionNull


        Public Sub SetDescriptionNull()
            Me(Me.tableSex_Description.DescriptionColumn) = System.Convert.DBNull
        End Sub 'SetDescriptionNull
    End Class 'Sex_DescriptionRow

    <System.Diagnostics.DebuggerStepThrough()> _
    Public Class Sex_DescriptionRowChangeEvent
        Inherits EventArgs

        Private eventRow As Sex_DescriptionRow

        Private eventAction As DataRowAction


        Public Sub New(ByVal row As Sex_DescriptionRow, ByVal action As DataRowAction)
            Me.eventRow = row
            Me.eventAction = action
        End Sub 'New


        Public ReadOnly Property Row() As Sex_DescriptionRow
            Get
                Return Me.eventRow
            End Get
        End Property


        Public ReadOnly Property Action() As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class 'Sex_DescriptionRowChangeEvent
End Class 'DataSet2