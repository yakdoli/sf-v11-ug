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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports System.Diagnostics

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping


Public Class GroupingEngineFactory
    Inherits GridEngineFactoryBase

    ' Add this line in your forms ctor:
    ' GroupingEngineFactory provides a modified GridChildTable that adds an extra section
    ' GridEngineFactory.Factory = new GroupingEngineFactory();
    Public Overrides Function CreateEngine() As GridEngine
        Return New GroupingEngine()
    End Function 'CreateEngine
End Class 'GroupingEngineFactory


Public Class GroupingEngine
    Inherits GridEngine
    
    Public Sub New()
    End Sub 'New
    
    
    Public Overloads Overrides Function CreateTable(ByVal tableDescriptor As TableDescriptor, ByVal parentRelationTable As Table) As Table
        Return New GroupingTable(tableDescriptor, parentRelationTable)
    End Function 'CreateTable


    Public Overrides Function CreateRecord(ByVal parentTable As Table) As Record
        Return New GroupingRecord(parentTable)
    End Function 'CreateRecord
End Class 'GroupingEngine

'/ <summary>
'/ Table that overrides ListChanged event handler and determines which columns were changed
'/ and also if changes affect the sort order, summaries or group captions.
'/ </summary>

Public Class GroupingTable
    Inherits GridTable
    
    Public Sub New(tableDescriptor As TableDescriptor, parentRelationTable As Table)
        MyBase.New(CType(tableDescriptor, GridTableDescriptor), CType(parentRelationTable, GridTable))
    End Sub 'New
    
    Private diffs As ArrayList
    
    
    Public Property ModifiedFields() As ArrayList
        Get
            Return diffs
        End Get
        Set
            diffs = value
        End Set
    End Property
     
    Protected Overrides Sub bindingList_ListChanged(sender As Object, e As ListChangedEventArgs)
        If e.ListChangedType = ListChangedType.ItemChanged Then
            Dim r As GroupingRecord = CType(UnsortedRecords(e.NewIndex), GroupingRecord)
            ModifiedFields = r.CompareAndUpdateValues()
        End If
        MyBase.bindingList_ListChanged(sender, e)
        ModifiedFields = Nothing
    End Sub 'bindingList_ListChanged
End Class 'GroupingTable

'/ <summary>
'/ Record that shadows values in table and can gives hints which values were changed in ListChanged event.
'/ </summary>

Public Class GroupingRecord
    Inherits GridRecord
    Private fieldValues As ArrayList
    Private data As Object
    
    
    Public Sub New(parentTable As Table)
        MyBase.New(parentTable)
    End Sub 'New
    
    
    Public Overrides Function GetData() As Object
        Dim baseData As Object = MyBase.GetData()
        If data Is Nothing OrElse Not Object.ReferenceEquals(data, baseData) Then
            ResetFieldValues()
            data = baseData
        End If
        Return data
    End Function 'GetData
    
    
    Public Sub ResetFieldValues()
        data = Nothing
    End Sub 'ResetFieldValues
    
    Private inGetValue As Boolean = False
    
    Public Overloads Overrides Function GetValue(ByVal fieldDescriptor As Syncfusion.Grouping.FieldDescriptor) As Object
        If Not inGetValue AndAlso (fieldValues Is Nothing OrElse fieldValues.Count <> ParentTableDescriptor.Fields.Count) Then
            fieldValues = New ArrayList
            inGetValue = True
            Try
                Dim fd As FieldDescriptor
                For Each fd In ParentTableDescriptor.Fields
                    fieldValues.Add(MyBase.GetValue(fd))
                Next fd
            Finally
                inGetValue = False
            End Try
        End If

        Dim index As Integer = ParentTableDescriptor.Fields.IndexOf(fieldDescriptor)
        If index <> -1 Then
            Return fieldValues(index)
        End If
        Return Nothing
    End Function 'GetValue


    Public Sub UpdateValue(ByVal fieldDescriptor As FieldDescriptor, ByVal value As Object)
        If Not (fieldValues Is Nothing) Then
            Dim index As Integer = ParentTableDescriptor.Fields.IndexOf(fieldDescriptor)
            If index <> -1 Then
                fieldValues(index) = value
            End If
        End If
    End Sub 'UpdateValue

    Public Function CompareAndUpdateValues() As ArrayList
        If Not (fieldValues Is Nothing) Then
            Dim diffs As New ArrayList
            Dim newValues As New ArrayList
            Dim fields As FieldDescriptorCollection = ParentTableDescriptor.Fields
            Dim n As Integer
            For n = 0 To fieldValues.Count - 1
                Dim value As Object = MyBase.GetValue(fields(n))
                Dim isEqual As Boolean = Object.ReferenceEquals(fieldValues(n), value)
                If Not isEqual AndAlso Not (fieldValues(n) Is Nothing) AndAlso Not (value Is Nothing) Then
                    isEqual = isEqual Or fieldValues(n).Equals(value)
                End If
                If Not isEqual Then
                    diffs.Add(n)
                End If
                newValues.Add(value)
            Next n
            fieldValues = newValues
            Return diffs
        End If
        Return Nothing
    End Function 'CompareAndUpdateValues

End Class 'GroupingRecord 

