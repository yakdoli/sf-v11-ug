#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Re-distribution in any form is strictly
'  prohibited. Any infringement will be prosecuted under applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
	Imports System
	Imports System.Data
	Imports System.Xml
	Imports System.Runtime.Serialization
Namespace AutoCompleteDemo


	<Serializable(), System.ComponentModel.DesignerCategoryAttribute("code"), System.Diagnostics.DebuggerStepThrough(), System.ComponentModel.ToolboxItem(True)> _
	Public Class Websites : Inherits DataSet

		Private tableWebsite As WebsiteDataTable

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
				If (Not ds.Tables("Website") Is Nothing) Then
					Me.Tables.Add(New WebsiteDataTable(ds.Tables("Website")))
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
		Public ReadOnly Property Website() As WebsiteDataTable
			Get
				Return Me.tableWebsite
			End Get
		End Property

		Public Overrides Function Clone() As DataSet
			Dim cln As Websites = (CType(MyBase.Clone(), Websites))
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
			If (Not ds.Tables("Website") Is Nothing) Then
				Me.Tables.Add(New WebsiteDataTable(ds.Tables("Website")))
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
			Me.tableWebsite = (CType(Me.Tables("Website"), WebsiteDataTable))
			If (Not Me.tableWebsite Is Nothing) Then
				Me.tableWebsite.InitVars()
			End If
		End Sub

		Private Sub InitClass()
			Me.DataSetName = "Websites"
			Me.Prefix = ""
			Me.Namespace = "http://tempuri.org/websites.xsd"
			Me.Locale = New System.Globalization.CultureInfo("en-US")
			Me.CaseSensitive = False
			Me.EnforceConstraints = False
			Me.tableWebsite = New WebsiteDataTable()
			Me.Tables.Add(Me.tableWebsite)
		End Sub

		Private Function ShouldSerializeWebsite() As Boolean
			Return False
		End Function

		Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
			If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
				Me.InitVars()
			End If
		End Sub

		Public Delegate Sub WebsiteRowChangeEventHandler(ByVal sender As Object, ByVal e As WebsiteRowChangeEvent)

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class WebsiteDataTable : Inherits DataTable : Implements System.Collections.IEnumerable

			Private columnURL As DataColumn

			Private columnName As DataColumn

			Private columnImageIndex As DataColumn

			Friend Sub New()
				MyBase.New("Website")
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

			Friend ReadOnly Property URLColumn() As DataColumn
				Get
					Return Me.columnURL
				End Get
			End Property

			Friend ReadOnly Property NameColumn() As DataColumn
				Get
					Return Me.columnName
				End Get
			End Property

			Friend ReadOnly Property ImageIndexColumn() As DataColumn
				Get
					Return Me.columnImageIndex
				End Get
			End Property

			Public ReadOnly Default Property Item(ByVal index As Integer) As WebsiteRow
				Get
					Return (CType(Me.Rows(index), WebsiteRow))
				End Get
			End Property

			Public Event WebsiteRowChanged As WebsiteRowChangeEventHandler

			Public Event WebsiteRowChanging As WebsiteRowChangeEventHandler

			Public Event WebsiteRowDeleted As WebsiteRowChangeEventHandler

			Public Event WebsiteRowDeleting As WebsiteRowChangeEventHandler

			Public Sub AddWebsiteRow(ByVal row As WebsiteRow)
				Me.Rows.Add(row)
			End Sub

			Public Function AddWebsiteRow(ByVal URL As String, ByVal Name As String, ByVal ImageIndex As String) As WebsiteRow
				Dim rowWebsiteRow As WebsiteRow = (CType(Me.NewRow(), WebsiteRow))
				rowWebsiteRow.ItemArray = New Object() { URL, Name, ImageIndex}
				Me.Rows.Add(rowWebsiteRow)
				Return rowWebsiteRow
			End Function

			Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
				Return Me.Rows.GetEnumerator()
			End Function

			Public Overrides Overloads Function Clone() As DataTable
				Dim cln As WebsiteDataTable = (CType(MyBase.Clone(), WebsiteDataTable))
				cln.InitVars()
				Return cln
			End Function

			Protected Overrides Function CreateInstance() As DataTable
				Return New WebsiteDataTable()
			End Function

			Friend Sub InitVars()
				Me.columnURL = Me.Columns("URL")
				Me.columnName = Me.Columns("Name")
				Me.columnImageIndex = Me.Columns("ImageIndex")
			End Sub

			Private Sub InitClass()
				Me.columnURL = New DataColumn("URL", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnURL)
				Me.columnName = New DataColumn("Name", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnName)
				Me.columnImageIndex = New DataColumn("ImageIndex", GetType(String), Nothing, System.Data.MappingType.Element)
				Me.Columns.Add(Me.columnImageIndex)
			End Sub

			Public Function NewWebsiteRow() As WebsiteRow
				Return (CType(Me.NewRow(), WebsiteRow))
			End Function

			Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
				Return New WebsiteRow(builder)
			End Function

			Protected Overrides Function GetRowType() As System.Type
				Return GetType(WebsiteRow)
			End Function

			Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowChanged(e)
				If (Not Me.WebsiteRowChangedEvent Is Nothing) Then
					RaiseEvent WebsiteRowChanged(Me, New WebsiteRowChangeEvent((CType(e.Row, WebsiteRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowChanging(e)
				If (Not Me.WebsiteRowChangingEvent Is Nothing) Then
					RaiseEvent WebsiteRowChanging(Me, New WebsiteRowChangeEvent((CType(e.Row, WebsiteRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowDeleted(e)
				If (Not Me.WebsiteRowDeletedEvent Is Nothing) Then
					RaiseEvent WebsiteRowDeleted(Me, New WebsiteRowChangeEvent((CType(e.Row, WebsiteRow)), e.Action))
				End If
			End Sub

			Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
				MyBase.OnRowDeleting(e)
				If (Not Me.WebsiteRowDeletingEvent Is Nothing) Then
					RaiseEvent WebsiteRowDeleting(Me, New WebsiteRowChangeEvent((CType(e.Row, WebsiteRow)), e.Action))
				End If
			End Sub

			Public Sub RemoveWebsiteRow(ByVal row As WebsiteRow)
				Me.Rows.Remove(row)
			End Sub
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class WebsiteRow : Inherits DataRow

			Private tableWebsite As WebsiteDataTable

			Friend Sub New(ByVal rb As DataRowBuilder)
				MyBase.New(rb)
				Me.tableWebsite = (CType(Me.Table, WebsiteDataTable))
			End Sub

			Public Property URL() As String
				Get
					Try
						Return (CStr(Me(Me.tableWebsite.URLColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableWebsite.URLColumn) = Value
				End Set
			End Property

			Public Property Name() As String
				Get
					Try
						Return (CStr(Me(Me.tableWebsite.NameColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableWebsite.NameColumn) = Value
				End Set
			End Property

			Public Property ImageIndex() As String
				Get
					Try
						Return (CStr(Me(Me.tableWebsite.ImageIndexColumn)))
					Catch e As InvalidCastException
						Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
					End Try
				End Get
				Set
					Me(Me.tableWebsite.ImageIndexColumn) = Value
				End Set
			End Property

			Public Function IsURLNull() As Boolean
				Return Me.IsNull(Me.tableWebsite.URLColumn)
			End Function

			Public Sub SetURLNull()
				Me(Me.tableWebsite.URLColumn) = System.Convert.DBNull
			End Sub

			Public Function IsNameNull() As Boolean
				Return Me.IsNull(Me.tableWebsite.NameColumn)
			End Function

			Public Sub SetNameNull()
				Me(Me.tableWebsite.NameColumn) = System.Convert.DBNull
			End Sub

			Public Function IsImageIndexNull() As Boolean
				Return Me.IsNull(Me.tableWebsite.ImageIndexColumn)
			End Function

			Public Sub SetImageIndexNull()
				Me(Me.tableWebsite.ImageIndexColumn) = System.Convert.DBNull
			End Sub
		End Class

		<System.Diagnostics.DebuggerStepThrough()> _
		Public Class WebsiteRowChangeEvent : Inherits EventArgs

			Private eventRow As WebsiteRow

			Private eventAction As DataRowAction

'INSTANT VB NOTE: The parameter row was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
'INSTANT VB NOTE: The parameter action was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
			Public Sub New(ByVal row_Renamed As WebsiteRow, ByVal action_Renamed As DataRowAction)
				Me.eventRow = row_Renamed
				Me.eventAction = action_Renamed
			End Sub

			Public ReadOnly Property Row() As WebsiteRow
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
