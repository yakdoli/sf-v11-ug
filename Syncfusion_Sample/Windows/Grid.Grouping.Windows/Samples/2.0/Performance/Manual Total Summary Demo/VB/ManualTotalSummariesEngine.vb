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



Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Data
Imports System.Text

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping


Namespace Syncfusion.Grouping.ManualSummaries
	Public Class ManualTotalSummaryEngineFactory : Inherits GridEngineFactoryBase
		' Add these static ctor to your form:
		'
		'static Form1()
		'{
			'// Enable ManualTotalSummaryEngineFactory with optimized ListChanged handler. Must
			'// be set before InitializeComponent in Form ctor.
			'GridEngineFactory.Factory = new ManualTotalSummaryEngineFactory();
		'}
		'

		Public Overrides Function CreateEngine() As GridEngine
			Return New ManualTotalSummaryEngine()
		End Function
	End Class

	Public Class ManualTotalSummaryEngine : Inherits GridEngine
		Public Sub New()
		End Sub

		Public Overrides Overloads Function CreateTable(ByVal tableDescriptor As TableDescriptor, ByVal parentRelationTable As Table) As Table
			Return New ManualTotalSummaryTable(tableDescriptor, parentRelationTable)
		End Function

		Public Overrides Function CreateGroup(ByVal parent As Section) As Group
			Return New ManualTotalSummaryGroup(parent)
		End Function

		Public Overrides Function CreateChildTable(ByVal parent As Element) As ChildTable
			Return New ManualTotalSummaryChildTable(parent)
		End Function
	End Class

	''' <summary>
	''' Grouping child table with support for manual total summaries.
	''' </summary>
	Public Class ManualTotalSummaryChildTable : Inherits GridChildTable : Implements IManualTotalSummaryArraySource
		Private ManualTotalSummaryArray As ManualTotalSummary()

		Public Sub New(ByVal parent As Element)
			MyBase.New(parent)
			ManualTotalSummaryArray = New ManualTotalSummary(parent.ParentTableDescriptor.Fields.Count - 1) {}

			Dim td As ManualTotalSummaryTable
			If TypeOf parent Is Table Then
				td = TryCast((parent), ManualTotalSummaryTable)
			Else
				td = TryCast((parent.ParentTable), ManualTotalSummaryTable)
			End If

			If Not td Is Nothing Then
				For Each field As String In td.TotalSummaries
					Dim oTemp As ManualTotalSummary = New ManualTotalSummary(Me, field)
				Next field
			End If
		End Sub

		#Region "IManualTotalSummaryArraySource Members"

		Public Function GetManualTotalSummaryArray() As ManualTotalSummary() Implements IManualTotalSummaryArraySource.GetManualTotalSummaryArray
			Return ManualTotalSummaryArray
		End Function

		#End Region
	End Class

	''' <summary>
	''' Grouping group with support for manual total summaries.
	''' </summary>
	Public Class ManualTotalSummaryGroup : Inherits GridGroup : Implements IManualTotalSummaryArraySource, IGridGroupOptionsSource
		Private ManualTotalSummaryArray As ManualTotalSummary()

		Public Sub New(ByVal parent As Section)
			MyBase.New(parent)
			ManualTotalSummaryArray = New ManualTotalSummary(parent.ParentTableDescriptor.Fields.Count - 1) {}

			Dim td As ManualTotalSummaryTable = TryCast(parent.ParentTable, ManualTotalSummaryTable)

			If Not td Is Nothing Then
				For Each field As String In td.TotalSummaries
					Dim oTemp As ManualTotalSummary = New ManualTotalSummary(Me, field)
				Next field
			End If
		End Sub

        Private Function GetParentGroupOptionsSource() As IGridGroupOptionsSource
            ' this method is overriden to avoid looking up Appearance from GridColumnDescriptor
            ' which costs a few ticks performance.

            Return CType(Me.ParentTableDescriptor, IGridGroupOptionsSource)
        End Function

		#Region "IManualTotalSummaryArraySource Members"

		Public Function GetManualTotalSummaryArray() As ManualTotalSummary() Implements IManualTotalSummaryArraySource.GetManualTotalSummaryArray
			Return ManualTotalSummaryArray
		End Function

		#End Region
	End Class


	''' <summary>
	''' Table with ManualTotalSummaries.
	''' </summary>
	Public Class ManualTotalSummaryTable : Inherits GridTable
		Public Sub New(ByVal tableDescriptor As TableDescriptor, ByVal parentRelationTable As Table)
			MyBase.New(CType(tableDescriptor, GridTableDescriptor), CType(parentRelationTable, GridTable))
		End Sub

		#Region "TotalSummaries Support"
		Private totalSummaries_Renamed As ArrayList = New ArrayList()

		''' <exclude/>
		''' <summary>
		''' TODO: Move this to TableDescriptor.
		''' </summary>
		Public Property TotalSummaries() As ArrayList
			Get
				Return Me.totalSummaries_Renamed
			End Get
			Set
				Me.totalSummaries_Renamed = Value
			End Set
		End Property

		Protected Overrides Sub OnPrepareRemoving(ByVal row As Object)
			' Save values for all fields where we need to be able to access the
			' old value (e.g. Delta for TotalSummaries).
			Dim td As TableDescriptor = TableDescriptor
			Dim tsa As IManualTotalSummaryArraySource = TryCast(Me.TopLevelGroup, IManualTotalSummaryArraySource)
			If Not tsa Is Nothing Then
				For Each name As String In Me.totalSummaries_Renamed
					Dim fd As FieldDescriptor = td.Fields(name)
					If fd.IsPropertyField() Then
						Dim pd As PropertyDescriptor = fd.GetPropertyDescriptor()
						Dim value As Object = GetValue(row, pd)

						Dim ci As ChangedFieldInfo = New ChangedFieldInfo(td, pd.Name, value, Nothing)
						Me.AddChangedField(ci)
					End If
				Next name
			End If

			MyBase.OnPrepareRemoving(row)
		End Sub

		Protected Overrides Sub OnPrepareItemAdded(ByVal row As Object)
			' Get new values for which delta information is needed
			Dim tsa As IManualTotalSummaryArraySource = TryCast(Me.TopLevelGroup, IManualTotalSummaryArraySource)
			If Not tsa Is Nothing Then
				Dim td As TableDescriptor = TableDescriptor

				For Each name As String In Me.totalSummaries_Renamed
					Dim fd As FieldDescriptor = td.Fields(name)
					If fd.IsPropertyField() Then
						Dim pd As PropertyDescriptor = fd.GetPropertyDescriptor()
						Dim value As Object = GetValue(row, pd)

						Dim ci As ChangedFieldInfo = New ChangedFieldInfo(td, pd.Name, Nothing, value)
						Me.AddChangedField(ci)
					End If
				Next name
			End If

			MyBase.OnPrepareItemAdded(row)
		End Sub

		Protected Overrides Sub OnRecordChanged(ByVal r As Element, ByVal isObsoleteRecord As Boolean, ByVal isAddedRecord As Boolean)
			Dim td As TableDescriptor = TableDescriptor
			Dim g As Group = r.ParentGroup
			Do While TypeOf g Is IManualTotalSummaryArraySource
				OnGroupSummaryInvalidated(New GroupEventArgs(g))

				Dim tsa As IManualTotalSummaryArraySource = TryCast(g, IManualTotalSummaryArraySource)
				For Each ci As ChangedFieldInfo In Me.ChangedFieldsArray
					Dim mt As ManualTotalSummary = tsa.GetManualTotalSummaryArray()(ci.FieldIndex)
					If Not mt Is Nothing Then
						mt.ApplyDelta(r, isObsoleteRecord, isAddedRecord, ci)
					End If
				Next ci

				g = g.ParentGroup
			Loop
		End Sub ' Fix ManualTotalSummary of parent groups.
		#End Region
	End Class




	''' <summary>
	''' Implement this interface in GridGroup and GridChildTable so that others have access to ManualTotalSummary array
	''' </summary>
	Public Interface IManualTotalSummaryArraySource
		Function GetManualTotalSummaryArray() As ManualTotalSummary()
	End Interface

	''' <summary>
	''' This is a manual summary class which can be updated immediately using the difference between old and
	''' new value in a ListChanged event. For each entry in ManualTotalSummaryTable.TotalSummaries a ManualTotalSummary
	''' will be created. In gridGroupingControl1_QueryCellStyleInfo the ManualTotalSummary.Total value will 
	''' be retrieved and displayed in a summary or caption cell.
	''' </summary>
	Public Class ManualTotalSummary
		Private total_Renamed As Double
		Private dirty_Renamed As Boolean = True
		Private group_Renamed As Group
		Private fieldIndex_Renamed As Integer = -1

'INSTANT VB NOTE: The parameter field was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal g As Group, ByVal field_Renamed As String)
			Me.New(g, g.ParentTableDescriptor.Fields(field_Renamed))
		End Sub

'INSTANT VB NOTE: The parameter field was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal g As Group, ByVal field_Renamed As FieldDescriptor)
			Me.Field = field_Renamed
			Me.Group = g
		End Sub

		Public Property FieldIndex() As Integer
			Set
				fieldIndex_Renamed = Value
			End Set
			Get
				If fieldIndex_Renamed = -1 Then
					fieldIndex_Renamed = field_Renamed.Collection.IndexOf(Field)
				End If
				Return Me.fieldIndex_Renamed
			End Get
		End Property


		Public Property Group() As Group
			Get
				Return Me.group_Renamed
			End Get
			Set
				Me.group_Renamed = Value
				Dim tsa As IManualTotalSummaryArraySource = TryCast(group_Renamed, IManualTotalSummaryArraySource)
				tsa.GetManualTotalSummaryArray()(FieldIndex) = Me
			End Set
		End Property

		Private field_Renamed As FieldDescriptor

		Public Property Field() As FieldDescriptor
			Get
				Return Me.field_Renamed
			End Get
			Set
				Me.field_Renamed = Value
			End Set
		End Property

		Public Property Dirty() As Boolean
			Get
				Return Me.dirty_Renamed
			End Get
			Set
				Me.dirty_Renamed = Value
			End Set
		End Property

		Public Property Total() As Double
			Get
				If dirty_Renamed Then
					CalculateTotal()
					Me.dirty_Renamed = False
				End If


				Return Me.total_Renamed
			End Get
			Set
				Me.total_Renamed = Value
			End Set
		End Property

		Private Sub CalculateTotal()
			total_Renamed = 0

			If TypeOf group_Renamed.Details Is RecordsDetails Then
				For Each r As Record In group_Renamed.Records
					Dim obj As Object = r.GetValue(field_Renamed)
					If Not obj Is Nothing AndAlso Not(TypeOf obj Is DBNull) Then
						Dim d As Double = Convert.ToDouble(obj)
						total_Renamed += d
					End If
				Next r
			Else
				For Each g As Group In group_Renamed.Groups
					Dim tsa As IManualTotalSummaryArraySource = TryCast(g, IManualTotalSummaryArraySource)
					Dim mt As ManualTotalSummary = tsa.GetManualTotalSummaryArray()(Me.FieldIndex)
					If mt Is Nothing Then
						mt = New ManualTotalSummary(g, field_Renamed)
					End If
					Dim d As Double = mt.Total
					total_Renamed += d
				Next g
			End If
		End Sub

		Public Sub ApplyDelta(ByVal r As Element, ByVal isObsoleteRecord As Boolean, ByVal isAddedRecord As Boolean, ByVal ci As ChangedFieldInfo)
			If Dirty Then
				Return
			End If

			Dim mt As ManualTotalSummary = Me

			If isObsoleteRecord Then
				If Not ci.OldValue Is Nothing AndAlso Not(TypeOf ci.OldValue Is DBNull) Then
					mt.Total -= Convert.ToDouble(ci.OldValue)
				End If
			Else If isAddedRecord Then
				If Not ci.NewValue Is Nothing AndAlso Not(TypeOf ci.NewValue Is DBNull) Then
					mt.Total += Convert.ToDouble(ci.NewValue)
				End If
			Else
                'mt.Total += ci.Delta
			End If
		End Sub

	End Class
End Namespace

