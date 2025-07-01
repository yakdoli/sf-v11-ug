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
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms

Imports Syncfusion.ComponentModel
Imports Syncfusion.Diagnostics
Imports Syncfusion.Drawing
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid


' TODO: In this sample when you add a new customer and then
' cancel the editing of the new customer an empty customer
' will remain in the list. Correct behavior would be to remove
' the empty customer when AddNew operation is canceled.
Namespace CustomersSample

    Public Interface IRecordObject
        '/ <summary>
        '/ Method handler for the <see cref="GridModel.QueryCellInfo"/> event.
        '/ </summary>
        '/ <param name=" e">An <see cref="GridQueryCellInfoEventArgs"/> that contains the event data.</param>
        Sub QueryCellInfo(ByVal e As QueryColumnStyleEventArgs)
    End Interface 'IRecordObject 
    '/ <summary>
    '/ Method handler for the <see cref="GridModel.SaveCellInfo"/> event.
    '/ </summary>
    '/ <param name=" e">An <see cref="GridSaveCellInfoEventArgs"/> that contains the event data.</param>
    'void SaveCellInfo(GridSaveCellInfoEventArgs e);


    Public NotInheritable Class QueryColumnStyleEventArgs
        Inherits SyncfusionHandledEventArgs
        Private _gridInfo As GridQueryCellInfoEventArgs
        Private _state As GridBoundRecordState
        Private _level As GridHierarchyLevel
        Private _columnStyle As GridBoundColumn
        Private _mappingName As String


        Friend Sub New(ByVal gridInfo As GridQueryCellInfoEventArgs, ByVal state As GridBoundRecordState, ByVal level As GridHierarchyLevel, ByVal columnStyle As GridBoundColumn, ByVal mappingName As String)
            Me._gridInfo = gridInfo
            Me._state = state
            Me._level = level
            Me._columnStyle = columnStyle
            Me._mappingName = mappingName
        End Sub 'New


        <TraceProperty(True)> _
        Public ReadOnly Property GridInfo() As GridQueryCellInfoEventArgs
            Get
                Return _gridInfo
            End Get
        End Property


        <TraceProperty(True)> _
        Public ReadOnly Property State() As GridBoundRecordState
            Get
                Return _state
            End Get
        End Property


        <TraceProperty(True)> _
        Public ReadOnly Property Level() As GridHierarchyLevel
            Get
                Return _level
            End Get
        End Property


        <TraceProperty(True)> _
        Public ReadOnly Property ColumnStyle() As GridBoundColumn
            Get
                Return _columnStyle
            End Get
        End Property


        <TraceProperty(True)> _
        Public ReadOnly Property MappingName() As String
            Get
                Return _mappingName
            End Get
        End Property
    End Class 'QueryColumnStyleEventArgs



    Public Class RecordObjectBinder

        Public Sub New(ByVal model As GridDataBoundGridModel)
            WireGridModel(model)
        End Sub 'New


        Sub WireGridModel(ByVal model As GridModel)
            AddHandler model.QueryCellInfo, AddressOf GridModelQueryCellInfo
            AddHandler model.SaveCellInfo, AddressOf GridModelSaveCellInfo
        End Sub 'WireGridModel


        Sub GridModelQueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
            Dim ms As IGridModelSource = sender '
            Dim gridModel As GridDataBoundGridModel = ms.Model '
            Dim gridBinder As GridModelDataBinder = gridModel.DataProvider '

            Dim fieldNum As Integer = gridBinder.ColIndexToField(e.ColIndex)
            Dim position As Integer = gridBinder.RowIndexToPosition(e.RowIndex)
            If position < 0 OrElse fieldNum < 0 Then
                ' row or column header
                Return
            End If

            ' Get record state information as position, listManager, childCount etc.
            Dim state As GridBoundRecordState = gridBinder.GetRecordStateAtRowIndex(e.RowIndex)

            ' Get level information with bound columns, layout, row/col to field mapping
            Dim level As GridHierarchyLevel = gridBinder.GetHierarchyLevel(state.LevelIndex)

            ' Adjust for wrapped rows when a record has several rows
            Dim fieldInCollection As Integer = level.RowFieldToField(state.RowIndexInRecord, fieldNum)

            ' Get the columns collection for the hierarchy level
            Dim columns As GridBoundColumnsCollection = level.InternalColumns

            If fieldInCollection >= 0 AndAlso fieldInCollection < columns.Count Then
                ' Get the column style for this field
                Dim columnStyle As GridBoundColumn = columns(fieldInCollection)
                If Not (columnStyle Is Nothing) Then
                    ' Check if this is an unbound column (where mapping name did not match any Property in associated class)
                    Dim pd As PropertyDescriptor = columnStyle.PropertyDescriptor
                    If pd Is Nothing Then
                        If state.Position < state.Table.Count Then
                            ' Get the record object from the table for this record
                            Dim rowObject As Object = state.Table(state.Position)

                            ' Check for the IRecordObject interface
                            Dim recordObject As IRecordObject = rowObject '

                            If Not (recordObject Is Nothing) Then
                                ' Get style info from IRecordObject
                                Dim mappingName As String = columnStyle.MappingName
                                Dim cse As New QueryColumnStyleEventArgs(e, state, level, columnStyle, mappingName)
                                recordObject.QueryCellInfo(cse)

                                ' Assign e.Handled = true if information was provided by QueryCellInfo call
                                e.Handled = cse.Handled

                                TraceUtil.TraceCurrentMethodInfo(cse)
                            End If
                        End If
                    End If
                End If
            End If
        End Sub 'GridModelQueryCellInfo


        Sub GridModelSaveCellInfo(ByVal sender As Object, ByVal e As GridSaveCellInfoEventArgs)
        End Sub 'GridModelSaveCellInfo
    End Class 'RecordObjectBinder ' similar code here for saving style info




    Public Class Customer
        Implements IRecordObject


        Structure CustomerData
            Friend id As String
            Friend firstName As String
            Friend lastName As String
        End Structure 'CustomerData

        Private _parent As CustomersList
        Private _children As New CustomersList()
        Private custData As CustomerData
        Private inTxn As Boolean = False


        Public Sub QueryCellInfo(ByVal e As QueryColumnStyleEventArgs) Implements IRecordObject.QueryCellInfo
            Dim ce As GridQueryCellInfoEventArgs = e.GridInfo
            If e.MappingName = "Unbound1" Then
                ce.Style.CellValue = String.Format("{0}: {1} {2}", Me.ID, FirstName, LastName)
                If e.Level.LevelIndex = 0 Then
                    ce.Style.BackColor = Color.FromArgb(&HFF, &HBF, &H34)
                Else
                    ce.Style.BackColor = Color.FromArgb(192, 201, 219)
                End If
            ElseIf e.MappingName = "Unbound2" Then
                ce.Style.CellValue = e.State.Position.ToString()
            End If
        End Sub 'QueryCellInfo


        Public Sub New(ByVal ID As String)
            Me.custData = New CustomerData()
            Me.custData.id = ID
            Me.custData.firstName = ""
            Me.custData.lastName = ""
        End Sub 'New


        Public Property ID() As String
            Get
                Return Me.custData.id
            End Get
            Set(ByVal Value As String)
                Me.custData.id = Value
            End Set
        End Property


        Public Property FirstName() As String
            Get
                Return Me.custData.firstName
            End Get
            Set(ByVal Value As String)
                Me.custData.firstName = Value
            End Set
        End Property


        Public Property LastName() As String
            Get
                Return Me.custData.lastName
            End Get
            Set(ByVal Value As String)
                Me.custData.lastName = Value
            End Set
        End Property


        Public Property Children() As CustomersList
            Get
                Return _children
            End Get
            Set(ByVal Value As CustomersList)
                _children = Value
            End Set
        End Property


        Friend Property Parent() As CustomersList
            Get
                Return _parent
            End Get
            Set(ByVal Value As CustomersList)
                _parent = Value
            End Set
        End Property


        Private Sub OnCustomerChanged()
            If Not inTxn AndAlso Not (Parent Is Nothing) Then
                Parent.CustomerChanged(Me)
            End If
        End Sub 'OnCustomerChanged
    End Class 'Customer


    Public Class CustomersList
        Inherits CollectionBase

        Private resetEvent As New ListChangedEventArgs(ListChangedType.Reset, -1)


        Public Sub LoadCustomers()
            Dim l As IList = CType(Me, IList)
            Dim cust1 As Customer = ReadCustomer1()
            cust1.Children.Add(ReadCustomer3())
            cust1.Children.Add(ReadCustomer4())
            l.Add(cust1)
            Dim cust2 As Customer = ReadCustomer2()
            cust2.Children.Add(ReadCustomer5())
            cust2.Children.Add(ReadCustomer6())
            l.Add(cust2)
            OnListChanged(resetEvent)
        End Sub 'LoadCustomers


        Default Public Property Item(ByVal index As Integer) As Customer
            Get
                Return CType(List(index), Customer)
            End Get
            Set(ByVal Value As Customer)
                List(index) = Value
            End Set
        End Property


        Public Function Add(ByVal value As Customer) As Integer
            Return List.Add(value)
        End Function 'Add


        Public Function AddNew() As Customer
            Return CType(CType(Me, IBindingList).AddNew(), Customer)
        End Function 'AddNew



        Public Sub Remove(ByVal value As Customer)
            List.Remove(value)
        End Sub 'Remove



        Protected Overridable Sub OnListChanged(ByVal ev As ListChangedEventArgs)
            RaiseEvent ListChanged(Me, ev)
        End Sub 'OnListChanged



        Protected Overrides Sub OnClear()
            Dim c As Customer
            For Each c In List
                c.Parent = Nothing
            Next c
        End Sub 'OnClear


        Protected Overrides Sub OnClearComplete()
            OnListChanged(resetEvent)
        End Sub 'OnClearComplete


        Protected Overrides Sub OnInsertComplete(ByVal index As Integer, ByVal value As Object)
            Dim c As Customer = CType(value, Customer)
            c.Parent = Me
            OnListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index))
        End Sub 'OnInsertComplete


        Protected Overrides Sub OnRemoveComplete(ByVal index As Integer, ByVal value As Object)
            Dim c As Customer = CType(value, Customer)
            c.Parent = Me
            OnListChanged(New ListChangedEventArgs(ListChangedType.ItemDeleted, index))
        End Sub 'OnRemoveComplete


        Protected Overrides Sub OnSetComplete(ByVal index As Integer, ByVal oldValue As Object, ByVal newValue As Object)
            If oldValue <> newValue Then

                Dim oldcust As Customer = CType(oldValue, Customer)
                Dim newcust As Customer = CType(newValue, Customer)

                oldcust.Parent = Nothing
                newcust.Parent = Me


                OnListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index))
            End If
        End Sub 'OnSetComplete


        ' Called by Customer when it changes.
        Friend Sub CustomerChanged(ByVal cust As Customer)

            Dim index As Integer = List.IndexOf(cust)

            OnListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, index))
        End Sub 'CustomerChanged


        ' Events.
        Public Event ListChanged As ListChangedEventHandler



        ' Worker functions to populate the list with data.
        Private Shared Function ReadCustomer1() As Customer
            Dim cust As New Customer("536-45-1245")
            cust.FirstName = "Jo"
            cust.LastName = "Brown"
            Return cust
        End Function 'ReadCustomer1


        Private Shared Function ReadCustomer2() As Customer
            Dim cust As New Customer("246-12-5645")
            cust.FirstName = "Robert"
            cust.LastName = "Brown"
            Return cust
        End Function 'ReadCustomer2


        Private Shared Function ReadCustomer3() As Customer
            Dim cust As New Customer("537-45-1245")
            cust.FirstName = "Keith"
            cust.LastName = "Brown"
            Return cust
        End Function 'ReadCustomer3


        Private Shared Function ReadCustomer4() As Customer
            Dim cust As New Customer("247-12-5645")
            cust.FirstName = "Sven"
            cust.LastName = "Brown"
            Return cust
        End Function 'ReadCustomer4


        Private Shared Function ReadCustomer5() As Customer
            Dim cust As New Customer("538-45-1245")
            cust.FirstName = "Katie"
            cust.LastName = "Brown"
            Return cust
        End Function 'ReadCustomer5


        Private Shared Function ReadCustomer6() As Customer
            Dim cust As New Customer("248-12-5645")
            cust.FirstName = "Steve"
            cust.LastName = "Brown"
            Return cust
        End Function 'ReadCustomer6
    End Class 'CustomersList
End Namespace 'CustomersSample 
