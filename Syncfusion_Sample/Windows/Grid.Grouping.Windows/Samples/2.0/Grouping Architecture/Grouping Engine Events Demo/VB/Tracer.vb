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

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping


    Public Class Tracer
        Private groupingEngine As GridEngine
        Private etracer As EventTracer
        Public count As Integer = 1
        Public Sub New(ByVal groupingEngine As GridEngine, ByVal Output As EventTracer)
            Me.etracer = Output
            Me.etracer.Enabled = True
            Me.groupingEngine = groupingEngine
        End Sub


 
#Region "Hook and Unhook Events"

        Public Sub HookEngEvents()
            AddHandler groupingEngine.BindingContextChanged, AddressOf groupingEngine_BindingContextChanged
            AddHandler groupingEngine.CategorizedRecords, AddressOf groupingEngine_CategorizedRecords
            AddHandler groupingEngine.CategorizingRecords, AddressOf groupingEngine_CategorizingRecords
            AddHandler groupingEngine.DataMemberChanged, AddressOf groupingEngine_DataMemberChanged
            AddHandler groupingEngine.DataSourceChanged, AddressOf groupingEngine_DataSourceChanged
            AddHandler groupingEngine.ExceptionRaised, AddressOf groupingEngine_ExceptionRaised

            AddHandler groupingEngine.Table.GroupAdded, AddressOf groupingEngine_GroupAdded
            AddHandler groupingEngine.GroupCollapsed, AddressOf groupingEngine_GroupCollapsed
            AddHandler groupingEngine.GroupCollapsing, AddressOf groupingEngine_GroupCollapsing
            AddHandler groupingEngine.GroupExpanded, AddressOf groupingEngine_GroupExpanded
            AddHandler groupingEngine.GroupExpanding, AddressOf groupingEngine_GroupExpanding
            AddHandler groupingEngine.GroupRemoving, AddressOf groupingEngine_GroupRemoving
            AddHandler groupingEngine.GroupSummaryInvalidated, AddressOf groupingEngine_GroupSummaryInvalidated
            AddHandler groupingEngine.InvalidatingCounters, AddressOf groupingEngine_InvalidatingCounters
            AddHandler groupingEngine.InvalidatingSummaries, AddressOf groupingEngine_InvalidatingSummaries

            AddHandler groupingEngine.PropertyChanged, AddressOf groupingEngine_PropertyChanged
            AddHandler groupingEngine.PropertyChanging, AddressOf groupingEngine_PropertyChanging
            AddHandler groupingEngine.ParseCommonFormats, AddressOf groupingEngine_ParseCommonFormats

            AddHandler groupingEngine.QueryAddColumn, AddressOf groupingEngine_QueryAddColumn
            AddHandler groupingEngine.QueryAddRelation, AddressOf groupingEngine_QueryAddRelation
            AddHandler groupingEngine.QueryAddVisibleColumn, AddressOf groupingEngine_QueryAddVisibleColumn
            'AddHandler groupingEngine.QueryCellFormattedText, AddressOf groupingEngine_QueryCellFormattedText
            'AddHandler groupingEngine.QueryCellStyleInfo, AddressOf groupingEngine_QueryCellStyleInfo
            AddHandler groupingEngine.QueryCellText, AddressOf groupingEngine_QueryCellText
            'AddHandler groupingEngine.QueryCoveredRange, AddressOf groupingEngine_QueryCoveredRange
            AddHandler groupingEngine.QueryCustomSummary, AddressOf groupingEngine_QueryCustomSummary
            'AddHandler groupingEngine.QueryRecordMeetsFilterCriteria, AddressOf groupingEngine_QueryRecordMeetsFilterCriteria
            AddHandler groupingEngine.QueryShowField, AddressOf groupingEngine_QueryShowField
            AddHandler groupingEngine.QueryShowNestedPropertiesFields, AddressOf groupingEngine_QueryShowNestedPropertiesFields
            AddHandler groupingEngine.QueryShowRelationDisplayFields, AddressOf groupingEngine_QueryShowRelationDisplayFields
            AddHandler groupingEngine.QueryValue, AddressOf groupingEngine_QueryValue
            AddHandler groupingEngine.RecordCollapsed, AddressOf groupingEngine_RecordCollapsed
            AddHandler groupingEngine.RecordCollapsing, AddressOf groupingEngine_RecordCollapsing
            AddHandler groupingEngine.RecordDeleted, AddressOf groupingEngine_RecordDeleted
            AddHandler groupingEngine.RecordDeleting, AddressOf groupingEngine_RecordDeleting
            AddHandler groupingEngine.RecordExpanded, AddressOf groupingEngine_RecordExpanded
            AddHandler groupingEngine.RecordExpanding, AddressOf groupingEngine_RecordExpanding
            AddHandler groupingEngine.RecordValueChanged, AddressOf groupingEngine_RecordValueChanged
            AddHandler groupingEngine.RecordValueChanging, AddressOf groupingEngine_RecordValueChanging
            AddHandler groupingEngine.SaveCellFormattedText, AddressOf groupingEngine_SaveCellFormattedText
            AddHandler groupingEngine.SaveCellText, AddressOf groupingEngine_SaveCellText
            AddHandler groupingEngine.SaveValue, AddressOf groupingEngine_SaveValue
            AddHandler groupingEngine.SelectedRecordsChanged, AddressOf groupingEngine_SelectedRecordsChanged
            AddHandler groupingEngine.SelectedRecordsChanging, AddressOf groupingEngine_SelectedRecordsChanging
            AddHandler groupingEngine.SortedItemsInGroup, AddressOf groupingEngine_SortedItemsInGroup
            AddHandler groupingEngine.SortingItemsInGroup, AddressOf groupingEngine_SortingItemsInGroup
            AddHandler groupingEngine.SourceListChanged, AddressOf groupingEngine_SourceListChanged
            AddHandler groupingEngine.SourceListListChanged, AddressOf groupingEngine_SourceListListChanged
            AddHandler groupingEngine.SourceListListChangedCompleted, AddressOf groupingEngine_SourceListListChangedCompleted
            AddHandler groupingEngine.SourceListRecordChanged, AddressOf groupingEngine_SourceListRecordChanged
            AddHandler groupingEngine.SourceListRecordChanging, AddressOf groupingEngine_SourceListRecordChanging
            AddHandler groupingEngine.TableCreated, AddressOf groupingEngine_TableCreated
            AddHandler groupingEngine.TableDescriptorCreated, AddressOf groupingEngine_TableDescriptorCreated
            AddHandler groupingEngine.TableSourceListChanged, AddressOf groupingEngine_TableSourceListChanged
        End Sub

        Public Sub HookEngTableEvents()
            AddHandler groupingEngine.Table.AddedRelatedTable, AddressOf Table_AddedRelatedTable
            AddHandler groupingEngine.Table.BindingContextChanged, AddressOf Table_BindingContextChanged
            AddHandler groupingEngine.Table.CategorizingRecords, AddressOf Table_CategorizingRecords
            AddHandler groupingEngine.Table.CurrentRecordContextChange, AddressOf Table_CurrentRecordContextChange
            AddHandler groupingEngine.Table.CurrentRecordManagerReset, AddressOf Table_CurrentRecordManagerReset
            AddHandler groupingEngine.Table.DefaultYAmountChanged, AddressOf Table_DefaultYAmountChanged
            AddHandler groupingEngine.Table.Disposed, AddressOf Table_Disposed
            AddHandler groupingEngine.Table.ExceptionRaised, AddressOf Table_ExceptionRaised
            AddHandler groupingEngine.Table.GroupAdded, AddressOf Table_GroupAdded
            AddHandler groupingEngine.Table.GroupCollapsed, AddressOf Table_GroupCollapsed
            AddHandler groupingEngine.Table.GroupCollapsing, AddressOf Table_GroupCollapsing
            AddHandler groupingEngine.Table.GroupExpanded, AddressOf Table_GroupExpanded
            AddHandler groupingEngine.Table.GroupExpanding, AddressOf Table_GroupExpanding
            AddHandler groupingEngine.Table.GroupRemoving, AddressOf Table_GroupRemoving
            AddHandler groupingEngine.Table.GroupSummaryInvalidated, AddressOf Table_GroupSummaryInvalidated
            AddHandler groupingEngine.Table.InvalidatingCounters, AddressOf Table_InvalidatingCounters
            AddHandler groupingEngine.Table.InvalidatingSummaries, AddressOf Table_InvalidatingSummaries
            'AddHandler groupingEngine.Table.QueryCellStyleInfo, AddressOf Table_QueryCellStyleInfo
            'AddHandler groupingEngine.Table.QueryCoveredRange, AddressOf Table_QueryCoveredRange
            'AddHandler groupingEngine.Table.QueryCustomCount, AddressOf Table_QueryCustomCount
            'AddHandler groupingEngine.Table.QueryVisibleCustomCount, AddressOf Table_QueryVisibleCustomCount
            AddHandler groupingEngine.Table.RecordCollapsed, AddressOf Table_RecordCollapsed
            AddHandler groupingEngine.Table.RecordCollapsing, AddressOf Table_RecordCollapsing
            AddHandler groupingEngine.Table.RecordDeleted, AddressOf Table_RecordDeleted
            AddHandler groupingEngine.Table.RecordDeleting, AddressOf Table_RecordDeleting
            AddHandler groupingEngine.Table.RecordExpanded, AddressOf Table_RecordExpanded
            AddHandler groupingEngine.Table.RecordExpanding, AddressOf Table_RecordExpanding
            AddHandler groupingEngine.Table.RecordValueChanged, AddressOf Table_RecordValueChanged
            AddHandler groupingEngine.Table.RecordValueChanging, AddressOf Table_RecordValueChanging
            AddHandler groupingEngine.Table.RemovingRelatedTable, AddressOf Table_RemovingRelatedTable
            AddHandler groupingEngine.Table.SelectedRecordsChanged, AddressOf Table_SelectedRecordsChanged
            AddHandler groupingEngine.Table.SelectedRecordsChanging, AddressOf Table_SelectedRecordsChanging
            AddHandler groupingEngine.Table.SettingTableDirty, AddressOf Table_SettingTableDirty
            AddHandler groupingEngine.Table.SortedItemsInGroup, AddressOf Table_SortedItemsInGroup
            AddHandler groupingEngine.Table.SortingItemsInGroup, AddressOf Table_SortingItemsInGroup
            AddHandler groupingEngine.Table.SourceListChanged, AddressOf Table_SourceListChanged
            AddHandler groupingEngine.Table.SourceListListChanged, AddressOf Table_SourceListListChanged
            AddHandler groupingEngine.Table.SourceListListChangedCompleted, AddressOf Table_SourceListListChangedCompleted
            AddHandler groupingEngine.Table.SourceListRecordChanging, AddressOf Table_SourceListRecordChanging
            AddHandler groupingEngine.Table.SourceListRecordChanged, AddressOf Table_SourceListRecordChanged
        End Sub

        Public Sub UnhookEngEvents()
            RemoveHandler groupingEngine.BindingContextChanged, AddressOf groupingEngine_BindingContextChanged
            RemoveHandler groupingEngine.CategorizedRecords, AddressOf groupingEngine_CategorizedRecords
            RemoveHandler groupingEngine.CategorizingRecords, AddressOf groupingEngine_CategorizingRecords
            RemoveHandler groupingEngine.CurrentRecordContextChange, AddressOf groupingEngine_CurrentRecordContextChange
            RemoveHandler groupingEngine.CurrentRecordManagerReset, AddressOf groupingEngine_CurrentRecordManagerReset
            RemoveHandler groupingEngine.ExceptionRaised, AddressOf groupingEngine_ExceptionRaised
            RemoveHandler groupingEngine.GroupAdded, AddressOf groupingEngine_GroupAdded
            RemoveHandler groupingEngine.GroupCollapsed, AddressOf groupingEngine_GroupCollapsed
            RemoveHandler groupingEngine.GroupCollapsing, AddressOf groupingEngine_GroupCollapsing
            RemoveHandler groupingEngine.GroupExpanded, AddressOf groupingEngine_GroupExpanded
            RemoveHandler groupingEngine.GroupExpanding, AddressOf groupingEngine_GroupExpanding
            RemoveHandler groupingEngine.GroupRemoving, AddressOf groupingEngine_GroupRemoving
            RemoveHandler groupingEngine.GroupSummaryInvalidated, AddressOf groupingEngine_GroupSummaryInvalidated
            RemoveHandler groupingEngine.InvalidatingCounters, AddressOf groupingEngine_InvalidatingCounters
            RemoveHandler groupingEngine.InvalidatingSummaries, AddressOf groupingEngine_InvalidatingSummaries
            RemoveHandler groupingEngine.PropertyChanged, AddressOf groupingEngine_PropertyChanged
            RemoveHandler groupingEngine.PropertyChanging, AddressOf groupingEngine_PropertyChanging
            RemoveHandler groupingEngine.QueryAddColumn, AddressOf groupingEngine_QueryAddColumn
            RemoveHandler groupingEngine.QueryAddRelation, AddressOf groupingEngine_QueryAddRelation
            RemoveHandler groupingEngine.QueryAddVisibleColumn, AddressOf groupingEngine_QueryAddVisibleColumn
            RemoveHandler groupingEngine.QueryCellFormattedText, AddressOf groupingEngine_QueryCellFormattedText
            RemoveHandler groupingEngine.QueryCellStyleInfo, AddressOf groupingEngine_QueryCellStyleInfo
            RemoveHandler groupingEngine.QueryCellText, AddressOf groupingEngine_QueryCellText
            RemoveHandler groupingEngine.QueryCoveredRange, AddressOf groupingEngine_QueryCoveredRange
            RemoveHandler groupingEngine.QueryCustomSummary, AddressOf groupingEngine_QueryCustomSummary
            RemoveHandler groupingEngine.QueryRecordMeetsFilterCriteria, AddressOf groupingEngine_QueryRecordMeetsFilterCriteria
            RemoveHandler groupingEngine.QueryShowField, AddressOf groupingEngine_QueryShowField
            RemoveHandler groupingEngine.QueryShowNestedPropertiesFields, AddressOf groupingEngine_QueryShowNestedPropertiesFields
            RemoveHandler groupingEngine.QueryShowRelationDisplayFields, AddressOf groupingEngine_QueryShowRelationDisplayFields
            RemoveHandler groupingEngine.QueryValue, AddressOf groupingEngine_QueryValue
            RemoveHandler groupingEngine.RecordCollapsed, AddressOf groupingEngine_RecordCollapsed
            RemoveHandler groupingEngine.RecordCollapsing, AddressOf groupingEngine_RecordCollapsing
            RemoveHandler groupingEngine.RecordDeleted, AddressOf groupingEngine_RecordDeleted
            RemoveHandler groupingEngine.RecordDeleting, AddressOf groupingEngine_RecordDeleting
            RemoveHandler groupingEngine.RecordExpanded, AddressOf groupingEngine_RecordExpanded
            RemoveHandler groupingEngine.RecordExpanding, AddressOf groupingEngine_RecordExpanding
            RemoveHandler groupingEngine.RecordValueChanged, AddressOf groupingEngine_RecordValueChanged
            RemoveHandler groupingEngine.RecordValueChanging, AddressOf groupingEngine_RecordValueChanging
            RemoveHandler groupingEngine.SaveCellFormattedText, AddressOf groupingEngine_SaveCellFormattedText
            RemoveHandler groupingEngine.SaveCellText, AddressOf groupingEngine_SaveCellText
            RemoveHandler groupingEngine.SaveValue, AddressOf groupingEngine_SaveValue
            RemoveHandler groupingEngine.SelectedRecordsChanged, AddressOf groupingEngine_SelectedRecordsChanged
            RemoveHandler groupingEngine.SelectedRecordsChanging, AddressOf groupingEngine_SelectedRecordsChanging
            RemoveHandler groupingEngine.SortedItemsInGroup, AddressOf groupingEngine_SortedItemsInGroup
            RemoveHandler groupingEngine.SortingItemsInGroup, AddressOf groupingEngine_SortingItemsInGroup
            RemoveHandler groupingEngine.SourceListChanged, AddressOf groupingEngine_SourceListChanged
            RemoveHandler groupingEngine.SourceListListChanged, AddressOf groupingEngine_SourceListListChanged
            RemoveHandler groupingEngine.SourceListListChangedCompleted, AddressOf groupingEngine_SourceListListChangedCompleted
            RemoveHandler groupingEngine.SourceListRecordChanged, AddressOf groupingEngine_SourceListRecordChanged
            RemoveHandler groupingEngine.SourceListRecordChanging, AddressOf groupingEngine_SourceListRecordChanging
            RemoveHandler groupingEngine.TableCreated, AddressOf groupingEngine_TableCreated
            RemoveHandler groupingEngine.TableDescriptorCreated, AddressOf groupingEngine_TableDescriptorCreated
            RemoveHandler groupingEngine.TableSourceListChanged, AddressOf groupingEngine_TableSourceListChanged
        End Sub


        Public Sub UnhookEngTableEvents()
            RemoveHandler groupingEngine.Table.AddedRelatedTable, AddressOf Table_AddedRelatedTable
            RemoveHandler groupingEngine.Table.BindingContextChanged, AddressOf Table_BindingContextChanged
            RemoveHandler groupingEngine.Table.CategorizingRecords, AddressOf Table_CategorizingRecords
            RemoveHandler groupingEngine.Table.CurrentRecordContextChange, AddressOf Table_CurrentRecordContextChange
            RemoveHandler groupingEngine.Table.DefaultYAmountChanged, AddressOf Table_DefaultYAmountChanged
            RemoveHandler groupingEngine.Table.Disposed, AddressOf Table_Disposed
            RemoveHandler groupingEngine.Table.ExceptionRaised, AddressOf Table_ExceptionRaised
            RemoveHandler groupingEngine.Table.GroupAdded, AddressOf Table_GroupAdded
            RemoveHandler groupingEngine.Table.GroupCollapsed, AddressOf Table_GroupCollapsed
            RemoveHandler groupingEngine.Table.GroupCollapsing, AddressOf Table_GroupCollapsing
            RemoveHandler groupingEngine.Table.GroupExpanded, AddressOf Table_GroupExpanded
            RemoveHandler groupingEngine.Table.GroupExpanding, AddressOf Table_GroupExpanding
            RemoveHandler groupingEngine.Table.GroupRemoving, AddressOf Table_GroupRemoving
            RemoveHandler groupingEngine.Table.GroupSummaryInvalidated, AddressOf Table_GroupSummaryInvalidated
            RemoveHandler groupingEngine.Table.InvalidatingCounters, AddressOf Table_InvalidatingCounters
            RemoveHandler groupingEngine.Table.InvalidatingSummaries, AddressOf Table_InvalidatingSummaries
            RemoveHandler groupingEngine.Table.QueryCellStyleInfo, AddressOf Table_QueryCellStyleInfo
            RemoveHandler groupingEngine.Table.QueryCustomCount, AddressOf Table_QueryCustomCount
            RemoveHandler groupingEngine.Table.QueryCoveredRange, AddressOf Table_QueryCoveredRange
            RemoveHandler groupingEngine.Table.QueryVisibleCustomCount, AddressOf Table_QueryVisibleCustomCount
            RemoveHandler groupingEngine.Table.RecordCollapsed, AddressOf Table_RecordCollapsed
            RemoveHandler groupingEngine.Table.RecordCollapsing, AddressOf Table_RecordCollapsing
            RemoveHandler groupingEngine.Table.RecordDeleted, AddressOf Table_RecordDeleted
            RemoveHandler groupingEngine.Table.RecordDeleting, AddressOf Table_RecordDeleting
            RemoveHandler groupingEngine.Table.RecordExpanded, AddressOf Table_RecordExpanded
            RemoveHandler groupingEngine.Table.RecordExpanding, AddressOf Table_RecordExpanding
            RemoveHandler groupingEngine.Table.RecordValueChanged, AddressOf Table_RecordValueChanged
            RemoveHandler groupingEngine.Table.RecordValueChanging, AddressOf Table_RecordValueChanging
            RemoveHandler groupingEngine.Table.RemovingRelatedTable, AddressOf Table_RemovingRelatedTable
            RemoveHandler groupingEngine.Table.SelectedRecordsChanged, AddressOf Table_SelectedRecordsChanged
            RemoveHandler groupingEngine.Table.SelectedRecordsChanging, AddressOf Table_SelectedRecordsChanging
            RemoveHandler groupingEngine.Table.SettingTableDirty, AddressOf Table_SettingTableDirty
            RemoveHandler groupingEngine.Table.SortedItemsInGroup, AddressOf Table_SortedItemsInGroup
            RemoveHandler groupingEngine.Table.SortingItemsInGroup, AddressOf Table_SortingItemsInGroup
            RemoveHandler groupingEngine.Table.SourceListChanged, AddressOf Table_SourceListChanged
            RemoveHandler groupingEngine.Table.SourceListListChanged, AddressOf Table_SourceListListChanged
            RemoveHandler groupingEngine.Table.SourceListListChangedCompleted, AddressOf Table_SourceListListChangedCompleted
            RemoveHandler groupingEngine.Table.SourceListRecordChanged, AddressOf Table_SourceListRecordChanged
        End Sub
#End Region

        Private Sub groupingEngine_BindingContextChanged(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("BindingContextChanged", e)
        End Sub

        Private Sub groupingEngine_CategorizedRecords(ByVal sender As Object, ByVal e As TableEventArgs)

            etracer.AppendOutput("CategorizedRecords", e)
        End Sub

        Private Sub groupingEngine_CategorizingRecords(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("CategorizingRecords", e)
        End Sub

        Private Sub groupingEngine_CurrentRecordContextChange(ByVal sender As Object, ByVal e As CurrentRecordContextChangeEventArgs)
            etracer.AppendOutput("CurrentRecordContextChange", e)
        End Sub

        Private Sub groupingEngine_CurrentRecordManagerReset(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("CurrentRecordManagerReset", e)
        End Sub

        Private Sub groupingEngine_ExceptionRaised(ByVal sender As Object, ByVal e As ExceptionRaisedEventArgs)
            etracer.AppendOutput("ExceptionRaised", e)

        End Sub

        Private Sub groupingEngine_GroupAdded(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("GroupAdded", e)

        End Sub

        Private Sub groupingEngine_GroupCollapsed(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("GroupCollapsed", e)

        End Sub

        Private Sub groupingEngine_GroupCollapsing(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("GroupCollapsing", e)

        End Sub

        Private Sub groupingEngine_GroupExpanded(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("GroupExpanded", e)

        End Sub

        Private Sub groupingEngine_GroupExpanding(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("GroupExpanding", e)

        End Sub

        Private Sub groupingEngine_GroupRemoving(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("GroupRemoving", e)

        End Sub

        Private Sub groupingEngine_GroupSummaryInvalidated(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("GroupSummaryInvalidated", e)

        End Sub

        Private Sub groupingEngine_InvalidatingCounters(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("InvalidatingCounters", e)

        End Sub

        Private Sub groupingEngine_InvalidatingSummaries(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("InvalidatingSummaries", e)

        End Sub

        Private Sub groupingEngine_PropertyChanged(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
            etracer.AppendOutput("PropertyChanged", e)

        End Sub

        Private Sub groupingEngine_PropertyChanging(ByVal sender As Object, ByVal e As DescriptorPropertyChangedEventArgs)
            etracer.AppendOutput("PropertyChanging", e)

        End Sub

        Private Sub groupingEngine_QueryAddColumn(ByVal sender As Object, ByVal e As GridQueryAddColumnEventArgs)
            etracer.AppendOutput("QueryAddColumn", e)
        End Sub


        Private Sub groupingEngine_QueryAddRelation(ByVal sender As Object, ByVal e As QueryAddRelationEventArgs)
            etracer.AppendOutput("QueryAddRelation", e)

        End Sub
        Private Sub groupingEngine_QueryAddVisibleColumn(ByVal sender As Object, ByVal e As GridQueryAddVisibleColumnEventArgs)
            etracer.AppendOutput("QueryAddVisibleColumn", e)
        End Sub

        Private Sub groupingEngine_QueryRecordMeetsFilterCriteria(ByVal sender As Object, ByVal e As QueryRecordMeetsFilterCriteriaEventArgs)
            etracer.AppendOutput("QueryRecordMeetsFilterCriteria", e)

        End Sub
        Private Sub groupingEngine_QueryCellFormattedText(ByVal sender As Object, ByVal e As GridCellTextEventArgs)
            etracer.AppendOutput("QueryCellFormattedText", e)
        End Sub

        Private Sub groupingEngine_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
            etracer.AppendOutput("QueryCellStyleInfo", e)
        End Sub

        Private Sub groupingEngine_QueryCellText(ByVal sender As Object, ByVal e As GridCellTextEventArgs)
            etracer.AppendOutput("QueryCellText", e)
        End Sub

        Private Sub groupingEngine_QueryCoveredRange(ByVal sender As Object, ByVal e As GridTableQueryCoveredRangeEventArgs)
            etracer.AppendOutput("QueryCoveredRange", e)
        End Sub

        Private Sub groupingEngine_QueryCustomSummary(ByVal sender As Object, ByVal e As GridQueryCustomSummaryEventArgs)
            etracer.AppendOutput("QueryCustomSummary", e)
        End Sub

        Private Sub groupingEngine_QueryShowField(ByVal sender As Object, ByVal e As QueryShowFieldEventArgs)
            etracer.AppendOutput("QueryShowField", e)

        End Sub

        Private Sub groupingEngine_QueryShowNestedPropertiesFields(ByVal sender As Object, ByVal e As QueryShowNestedPropertiesFieldsEventArgs)
            etracer.AppendOutput("QueryShowNestedPropertiesFields", e)

        End Sub

        Private Sub groupingEngine_QueryShowRelationDisplayFields(ByVal sender As Object, ByVal e As QueryShowRelationFieldsEventArgs)
            etracer.AppendOutput("QueryShowRelationDisplayFields", e)

        End Sub

        Private Sub groupingEngine_QueryValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
            etracer.AppendOutput("QueryValue", e)

        End Sub

        Private Sub groupingEngine_RecordCollapsed(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("RecordCollapsed", e)

        End Sub

        Private Sub groupingEngine_RecordCollapsing(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("RecordCollapsing", e)

        End Sub

        Private Sub groupingEngine_RecordDeleted(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("RecordDeleted", e)

        End Sub

        Private Sub groupingEngine_RecordDeleting(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("RecordDeleting", e)

        End Sub

        Private Sub groupingEngine_RecordExpanded(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("RecordExpanded", e)

        End Sub

        Private Sub groupingEngine_RecordExpanding(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("RecordExpanding", e)

        End Sub

        Private Sub groupingEngine_RecordValueChanged(ByVal sender As Object, ByVal e As RecordValueChangedEventArgs)
            etracer.AppendOutput("RecordValueChanged", e)

        End Sub

        Private Sub groupingEngine_RecordValueChanging(ByVal sender As Object, ByVal e As RecordValueChangingEventArgs)
            etracer.AppendOutput("RecordValueChanging", e)

        End Sub

        Private Sub groupingEngine_SaveCellFormattedText(ByVal sender As Object, ByVal e As GridCellTextEventArgs)
            etracer.AppendOutput("SaveCellFormattedText", e)
        End Sub

        Private Sub groupingEngine_SaveCellText(ByVal sender As Object, ByVal e As GridCellTextEventArgs)
            etracer.AppendOutput("SaveCellText", e)
        End Sub

        Private Sub groupingEngine_SaveValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
            etracer.AppendOutput("SaveValue", e)

        End Sub

        Private Sub groupingEngine_SelectedRecordsChanged(ByVal sender As Object, ByVal e As SelectedRecordsChangedEventArgs)
            etracer.AppendOutput("SelectedRecordsChanged", e)

        End Sub

        Private Sub groupingEngine_SelectedRecordsChanging(ByVal sender As Object, ByVal e As SelectedRecordsChangedEventArgs)
            etracer.AppendOutput("SelectedRecordsChanging", e)

        End Sub

        Private Sub groupingEngine_SortedItemsInGroup(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("SortedItemsInGroup", e)

        End Sub

        Private Sub groupingEngine_SortingItemsInGroup(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("SortingItemsInGroup", e)

        End Sub

        Private Sub groupingEngine_SourceListChanged(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("SourceListChanged", e)

        End Sub

        Private Sub groupingEngine_SourceListListChanged(ByVal sender As Object, ByVal e As TableListChangedEventArgs)
            etracer.AppendOutput("SourceListListChanged", e)

        End Sub

        Private Sub groupingEngine_SourceListListChangedCompleted(ByVal sender As Object, ByVal e As TableListChangedEventArgs)
            etracer.AppendOutput("SourceListListChangedCompleted", e)

        End Sub

        Private Sub groupingEngine_SourceListRecordChanged(ByVal sender As Object, ByVal e As RecordChangedEventArgs)
            etracer.AppendOutput("SourceListRecordChanged", e)

        End Sub

        Private Sub groupingEngine_SourceListRecordChanging(ByVal sender As Object, ByVal e As RecordChangedEventArgs)
            etracer.AppendOutput("SourceListRecordChanging", e)

        End Sub

        Private Sub groupingEngine_TableCreated(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("TableCreated", e)

        End Sub

        Private Sub groupingEngine_TableDescriptorCreated(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("TableDescriptorCreated", e)

        End Sub

        Private Sub groupingEngine_TableSourceListChanged(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("TableSourceListChanged", e)

        End Sub

        Private Sub groupingEngine_DataMemberChanged(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("DataMemberChanged", e)
        End Sub

        Private Sub groupingEngine_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("Disposed", e)
        End Sub

        Private Sub groupingEngine_ParseCommonFormats(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellTextEventArgs)
            etracer.AppendOutput("ParseCommonFormats", e)
        End Sub

        Private Sub groupingEngine_DataSourceChanged(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("DataSourceChanged", e)
        End Sub

        Private Sub Table_AddedRelatedTable(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("Table:AddedRelatedTable", e)
        End Sub

        Private Sub Table_BindingContextChanged(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("Table:BindingContextChanged", e)
        End Sub

        Private Sub Table_CategorizingRecords(ByVal sender As Object, ByVal e As TableEventArgs)

        End Sub

        Private Sub Table_CurrentRecordContextChange(ByVal sender As Object, ByVal e As CurrentRecordContextChangeEventArgs)
            etracer.AppendOutput("Table:CurrentRecordContextChange", e)
        End Sub

        Private Sub Table_CurrentRecordManagerReset(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("Table:CurrentRecordManagerReset", e)
        End Sub

        Private Sub Table_DisplayElementChanged(ByVal sender As Object, ByVal e As DisplayElementChangedEventArgs)
            etracer.AppendOutput("Table:DisplayElementChanged", e)
        End Sub

        Private Sub Table_DefaultYAmountChanged(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("Table:DefaultYAmountChanged", e)
        End Sub

        Private Sub Table_Disposed(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("Table:Disposed", e)
        End Sub

        Private Sub Table_ExceptionRaised(ByVal sender As Object, ByVal e As ExceptionRaisedEventArgs)
            etracer.AppendOutput("Table:ExceptionRaised", e)
        End Sub

        Private Sub Table_GroupAdded(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("Table:GroupAdded", e)
        End Sub

        Private Sub Table_GroupCollapsed(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("Table:GroupCollapsed", e)
        End Sub

        Private Sub Table_GroupCollapsing(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("Table:GroupCollapsing", e)
        End Sub

        Private Sub Table_GroupExpanded(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("Table:GroupExpanded", e)
        End Sub

        Private Sub Table_GroupExpanding(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("Table:GroupExpanding", e)
        End Sub

        Private Sub Table_GroupRemoving(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("Table:GroupRemoving", e)
        End Sub

        Private Sub Table_GroupSummaryInvalidated(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("Table:GroupSummaryInvalidated", e)
        End Sub

        Private Sub Table_InvalidatingCounters(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("Table:InvalidatingCounters", e)
        End Sub

        Private Sub Table_InvalidatingSummaries(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("Table:InvalidatingSummaries", e)
        End Sub

        Private Sub Table_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
            etracer.AppendOutput("Table:QueryCellStyleInfo", e)
        End Sub

        Private Sub Table_QueryCustomCount(ByVal sender As Object, ByVal e As CustomCountEventArgs)
            etracer.AppendOutput("Table:QueryCustomCount", e)
        End Sub

        Private Sub Table_QueryCoveredRange(ByVal sender As Object, ByVal e As GridTableQueryCoveredRangeEventArgs)
            etracer.AppendOutput("Table:QueryCoveredRange", e)
        End Sub

        Private Sub Table_QueryVisibleCustomCount(ByVal sender As Object, ByVal e As CustomCountEventArgs)
            etracer.AppendOutput("Table:QueryVisibleCustomCount", e)
        End Sub

        Private Sub Table_RecordCollapsed(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("Table:RecordCollapsed", e)
        End Sub

        Private Sub Table_RecordCollapsing(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("Table:RecordCollapsing", e)
        End Sub

        Private Sub Table_RecordDeleted(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("Table:GroupDeleted", e)
        End Sub

        Private Sub Table_RecordDeleting(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("Table:GroupDeleting", e)
        End Sub

        Private Sub Table_RecordExpanded(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("Table:RecordExpanded", e)
        End Sub

        Private Sub Table_RecordExpanding(ByVal sender As Object, ByVal e As RecordEventArgs)
            etracer.AppendOutput("Table:RecordExpanding", e)
        End Sub

        Private Sub Table_RecordValueChanged(ByVal sender As Object, ByVal e As RecordValueChangedEventArgs)
            etracer.AppendOutput("Table:RecordValueChanged", e)
        End Sub

        Private Sub Table_RecordValueChanging(ByVal sender As Object, ByVal e As RecordValueChangingEventArgs)
            etracer.AppendOutput("Table:RecordValueChanging", e)
        End Sub

        Private Sub Table_RemovingRelatedTable(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("Table:RemovingRelatedTable", e)
        End Sub

        Private Sub Table_SelectedRecordsChanged(ByVal sender As Object, ByVal e As SelectedRecordsChangedEventArgs)
            etracer.AppendOutput("Table:SelectedRecordsChanged", e)
        End Sub

        Private Sub Table_SelectedRecordsChanging(ByVal sender As Object, ByVal e As SelectedRecordsChangedEventArgs)
            etracer.AppendOutput("Table:SelectedRecordsChanging", e)
        End Sub

        Private Sub Table_SettingTableDirty(ByVal sender As Object, ByVal e As EventArgs)
            etracer.AppendOutput("Table:SettingTableDirty", e)
        End Sub

        Private Sub Table_SortedItemsInGroup(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("Table:SortedItemsInGroup", e)
        End Sub

        Private Sub Table_SortingItemsInGroup(ByVal sender As Object, ByVal e As GroupEventArgs)
            etracer.AppendOutput("Table:SortingItemsInGroup", e)
        End Sub

        Private Sub Table_SourceListChanged(ByVal sender As Object, ByVal e As TableEventArgs)
            etracer.AppendOutput("Table:SourceListChanged", e)
        End Sub

        Private Sub Table_SourceListListChanged(ByVal sender As Object, ByVal e As TableListChangedEventArgs)
            etracer.AppendOutput("Table:SourceListListChanged", e)
        End Sub

        Private Sub Table_SourceListListChangedCompleted(ByVal sender As Object, ByVal e As TableListChangedEventArgs)
            etracer.AppendOutput("Table:SourceListListChangedCompleted", e)
        End Sub

        Private Sub Table_SourceListRecordChanging(ByVal sender As Object, ByVal e As RecordChangedEventArgs)
            etracer.AppendOutput("Table:SourceListRecordChanging", e)
        End Sub

        Private Sub Table_SourceListRecordChanged(ByVal sender As Object, ByVal e As RecordChangedEventArgs)
            etracer.AppendOutput("Table:SourceListRecordChanged", e)
        End Sub
    End Class

