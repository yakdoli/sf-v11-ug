#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace ObservableCollection_Demo
	Public Class EngineEventTracer
		Private groupingEngine As GridEngine
		Private output As ListView
		Public Sub New(ByVal groupingEngine As GridEngine, ByVal output As ListView)
			Me.output = output
			Me.groupingEngine = groupingEngine
		End Sub

		Public Sub AppendOutput(ByVal name As String, ByVal e As String)
			Dim item As ListViewItem
			Try
				item = New ListViewItem(New String(){name,e})
			Catch ex As Exception
				item = New ListViewItem(New String(){"Record deleted:",ex.InnerException.Message})
			End Try
			Me.output.Items.Add(item)
		End Sub

		#Region "Hook and Unhook Events"

		Public Sub HookEvents()
			AddHandler groupingEngine.Table.GroupAdded, AddressOf groupingEngine_GroupAdded
			AddHandler groupingEngine.Table.GroupCollapsed, AddressOf groupingEngine_GroupCollapsed
			AddHandler groupingEngine.Table.GroupCollapsing, AddressOf groupingEngine_GroupCollapsing
			AddHandler groupingEngine.Table.GroupExpanded, AddressOf groupingEngine_GroupExpanded
			AddHandler groupingEngine.Table.GroupExpanding, AddressOf groupingEngine_GroupExpanding
			AddHandler groupingEngine.Table.GroupRemoving, AddressOf groupingEngine_GroupRemoving
			AddHandler groupingEngine.Table.SortedItemsInGroup, AddressOf groupingEngine_SortedItemsInGroup
			AddHandler groupingEngine.Table.SortingItemsInGroup, AddressOf groupingEngine_SortingItemsInGroup
			AddHandler groupingEngine.Table.SourceListRecordChanged, AddressOf groupingEngine_SourceListRecordChanged
			AddHandler groupingEngine.QueryCustomSummary, AddressOf groupingEngine_QueryCustomSummary
			AddHandler groupingEngine.CurrentRecordContextChange, AddressOf groupingEngine_CurrentRecordContextChange
			AddHandler groupingEngine.DisplayElementChanged, AddressOf groupingEngine_DisplayElementChanged
			AddHandler groupingEngine.PropertyChanged, AddressOf groupingEngine_PropertyChanged
			AddHandler groupingEngine.QueryShowNestedPropertiesFields, AddressOf groupingEngine_QueryShowNestedPropertiesFields
			AddHandler groupingEngine.QueryShowRelationDisplayFields, AddressOf groupingEngine_QueryShowRelationDisplayFields
			AddHandler groupingEngine.QueryValue, AddressOf groupingEngine_QueryValue
			AddHandler groupingEngine.TableDescriptorCreated, AddressOf groupingEngine_TableDescriptorCreated
			AddHandler groupingEngine.TableDescriptor.GroupedColumns.Changed, AddressOf GroupedColumns_Changed
			AddHandler groupingEngine.TableDescriptor.SortedColumns.Changing, AddressOf SortedColumns_Changing
		End Sub


		Public Sub UnhookEvents()
			RemoveHandler groupingEngine.Table.GroupAdded, AddressOf groupingEngine_GroupAdded
			RemoveHandler groupingEngine.Table.GroupCollapsed, AddressOf groupingEngine_GroupCollapsed
			RemoveHandler groupingEngine.Table.GroupCollapsing, AddressOf groupingEngine_GroupCollapsing
			RemoveHandler groupingEngine.Table.GroupExpanded, AddressOf groupingEngine_GroupExpanded
			RemoveHandler groupingEngine.Table.GroupExpanding, AddressOf groupingEngine_GroupExpanding
			RemoveHandler groupingEngine.Table.GroupRemoving, AddressOf groupingEngine_GroupRemoving
			RemoveHandler groupingEngine.Table.SortedItemsInGroup, AddressOf groupingEngine_SortedItemsInGroup
			RemoveHandler groupingEngine.Table.SortingItemsInGroup, AddressOf groupingEngine_SortingItemsInGroup
			RemoveHandler groupingEngine.Table.SourceListRecordChanged, AddressOf groupingEngine_SourceListRecordChanged
			RemoveHandler groupingEngine.QueryCustomSummary, AddressOf groupingEngine_QueryCustomSummary
			RemoveHandler groupingEngine.CurrentRecordContextChange, AddressOf groupingEngine_CurrentRecordContextChange
			RemoveHandler groupingEngine.DisplayElementChanged, AddressOf groupingEngine_DisplayElementChanged
			RemoveHandler groupingEngine.PropertyChanged, AddressOf groupingEngine_PropertyChanged
			RemoveHandler groupingEngine.QueryShowNestedPropertiesFields, AddressOf groupingEngine_QueryShowNestedPropertiesFields
			RemoveHandler groupingEngine.QueryShowRelationDisplayFields, AddressOf groupingEngine_QueryShowRelationDisplayFields
			RemoveHandler groupingEngine.QueryValue, AddressOf groupingEngine_QueryValue
			RemoveHandler groupingEngine.TableDescriptorCreated, AddressOf groupingEngine_TableDescriptorCreated
			RemoveHandler groupingEngine.TableDescriptor.GroupedColumns.Changed, AddressOf GroupedColumns_Changed
			RemoveHandler groupingEngine.TableDescriptor.SortedColumns.Changing, AddressOf SortedColumns_Changing
		End Sub

		#End Region

		Private Sub groupingEngine_GroupAdded(ByVal sender As Object, ByVal e As GroupEventArgs)
			AppendOutput("GroupAdded: ","Grouped Column:" & e.Group.Name & " By Category: " & e.Group.Category.ToString() & " No. of items in this category:" & e.Group.GetRecordCount().ToString())
		End Sub

		Private Sub groupingEngine_GroupCollapsed(ByVal sender As Object, ByVal e As GroupEventArgs)
			AppendOutput("GroupCollapsed: ","Grouped Column:" & e.Group.Name & " By Category: " & e.Group.Category.ToString() & " No. of items in this category:" & e.Group.GetRecordCount().ToString())
		End Sub

		Private Sub groupingEngine_GroupExpanded(ByVal sender As Object, ByVal e As GroupEventArgs)
			AppendOutput("GroupExpanded: ","Grouped Column:" & e.Group.Name & " By Category: " & e.Group.Category.ToString() & " No. of items in this category:" & e.Group.GetRecordCount().ToString())
		End Sub

		Private Sub groupingEngine_GroupExpanding(ByVal sender As Object, ByVal e As GroupEventArgs)
			AppendOutput("GroupExpanding: ","Grouped Column:" & e.Group.Name & " By Category: " & e.Group.Category.ToString() & " No. of items in this category:" & e.Group.GetRecordCount().ToString())
		End Sub

		Private Sub groupingEngine_GroupCollapsing(ByVal sender As Object, ByVal e As GroupEventArgs)
			AppendOutput("GroupCollapsing:","Grouped Column:" & e.Group.Name & " By Category: " & e.Group.Category.ToString() & " No. of items in this category:" & e.Group.GetRecordCount().ToString())
		End Sub

		Private Sub groupingEngine_GroupRemoving(ByVal sender As Object, ByVal e As GroupEventArgs)
			AppendOutput("GroupRemoving: ","Grouped Column:" & e.Group.Name & " By Category: " & e.Group.Category.ToString() & " No. of items in this category:" & e.Group.GetRecordCount().ToString())
		End Sub

		Private Sub groupingEngine_SortedItemsInGroup(ByVal sender As Object, ByVal e As GroupEventArgs)
			If e.Group.Category IsNot Nothing Then
			AppendOutput("SortedItemsInGroup: ","Sorted Column:" & e.Group.Name & " By: " & e.Group.Category.ToString() & " No. of items:" & e.Group.GetRecordCount().ToString())
			End If
		End Sub

		Private Sub groupingEngine_SortingItemsInGroup(ByVal sender As Object, ByVal e As GroupEventArgs)
			If e.Group.Category IsNot Nothing Then
				AppendOutput("SortingItemsInGroup: ", "Sorted Column:" & e.Group.Name & " By: " & e.Group.Category.ToString() & " No. of items:" & e.Group.GetRecordCount().ToString())
			End If
		End Sub

		Private Sub groupingEngine_SourceListRecordChanged(ByVal sender As Object, ByVal e As RecordChangedEventArgs)
			AppendOutput("SourceListRecordChanged: ","Affected Record:" & e.Record.ToString())
		End Sub

		Private Sub groupingEngine_QueryCustomSummary(ByVal sender As Object, ByVal e As GridQueryCustomSummaryEventArgs)
			AppendOutput("QueryCustomSummary: ",e.SummaryColumn.Name & " " & e.SummaryDescriptor.SummaryType.ToString())
		End Sub

		Private Sub groupingEngine_CurrentRecordContextChange(ByVal sender As Object, ByVal e As CurrentRecordContextChangeEventArgs)
			AppendOutput("CurrentRecordContextChanged: ",e.Record.ToString())
		End Sub

		Private Sub groupingEngine_DisplayElementChanged(ByVal sender As Object, ByVal e As DisplayElementChangedEventArgs)
			AppendOutput("DisplayElementChanged: ",e.Element.ToString())
		End Sub

		Private Sub groupingEngine_PropertyChanged(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
			AppendOutput("PropertyChanged: ",e.PropertyName)
		End Sub

		Private Sub groupingEngine_QueryShowNestedPropertiesFields(ByVal sender As Object, ByVal e As QueryShowNestedPropertiesFieldsEventArgs)
			AppendOutput("QueryShowNestedPropertiesFields: ",e.ToString())
		End Sub

		Private Sub groupingEngine_QueryShowRelationDisplayFields(ByVal sender As Object, ByVal e As QueryShowRelationFieldsEventArgs)
			AppendOutput("QueryShowRelationDisplayFields: ","ParentTable:" & e.Relation.ParentTableDescriptor.Name & " ChildTable:" & e.Relation.ChildTableName)
		End Sub

		Private Sub groupingEngine_QueryValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
			AppendOutput("QueryValue: ","Field:" & e.Field.Name & " Value:" & e.Value.ToString())
		End Sub

		Private Sub groupingEngine_TableDescriptorCreated(ByVal sender As Object, ByVal e As EventArgs)
			AppendOutput("TableDescriptorCreated: ",e.ToString())
		End Sub

		Private Sub SortedColumns_Changing(ByVal sender As Object, ByVal e As Syncfusion.Collections.ListPropertyChangedEventArgs)
			If e.Item IsNot Nothing Then
				AppendOutput("Column Sorted: ", e.Item.ToString())
			End If
		End Sub

		Private Sub GroupedColumns_Changed(ByVal sender As Object, ByVal e As Syncfusion.Collections.ListPropertyChangedEventArgs)
			If e.Item IsNot Nothing Then
				AppendOutput("Column Grouped: ", e.Item.ToString())
			End If
		End Sub
	End Class
End Namespace
