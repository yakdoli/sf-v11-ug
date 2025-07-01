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
Imports System.ComponentModel
Imports System.Data


Namespace BindingArrayList
	''' <summary>
	''' Summary description for DataCollection.
	''' </summary>
    Public Class DataCollection : Implements ComponentModel.IBindingList, INotifyPropertyChanged
        Private list As ArrayList

        Public Sub New()
            list = New ArrayList()
        End Sub

        Default Public Property Item(ByVal index As Integer) As Object Implements IBindingList.Item
            Get
                Return CType(list(index), Object)
            End Get
            Set(ByVal value As Object)
                list(index) = value
                RaisePropertyChanged(list(index).ToString())
            End Set
        End Property

        Private Sub RaisePropertyChanged(ByVal name As String)
            If Not PropertyChangedEvent Is Nothing Then
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(name))
            End If
        End Sub

#Region "INotifyPropertyChanged Members"

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

#End Region

        'TODO: INSTANT VB TODO TASK: property is a keyword in VB.NET. Change the name or use square brackets to override it:
        'INSTANT VB NOTE: The parameter property was renamed since it is a keyword in VB:
        Public Sub AddIndex(ByVal property_Renamed As PropertyDescriptor) Implements IBindingList.AddIndex
        End Sub

        Public ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
            Get
                Return True
            End Get
        End Property

        'TODO: INSTANT VB TODO TASK: property is a keyword in VB.NET. Change the name or use square brackets to override it:
        'INSTANT VB NOTE: The parameter property was renamed since it is a keyword in VB:
        Public Sub ApplySort(ByVal property_Renamed As PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection) Implements IBindingList.ApplySort
        End Sub

        Public ReadOnly Property SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
            Get
                Return Nothing
            End Get
        End Property

        'TODO: INSTANT VB TODO TASK: property is a keyword in VB.NET. Change the name or use square brackets to override it:
        'INSTANT VB NOTE: The parameter property was renamed since it is a keyword in VB:
        Public Function Find(ByVal property_Renamed As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
            Return 0
        End Function

        Public ReadOnly Property SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property IsSorted() As Boolean Implements IBindingList.IsSorted
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property AllowRemove() As Boolean Implements IBindingList.AllowRemove
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property SortDirection() As System.ComponentModel.ListSortDirection Implements IBindingList.SortDirection
            Get
                Return New System.ComponentModel.ListSortDirection()
            End Get
        End Property
        Public Event ListChanged As System.ComponentModel.ListChangedEventHandler Implements IBindingList.ListChanged
        Public ReadOnly Property SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
            Get
                Return True
            End Get
        End Property

        Public Sub RemoveSort() Implements IBindingList.RemoveSort
        End Sub

        Public Function AddNew() As Object Implements IBindingList.AddNew
            Dim info As Data = New Data()
            Me.list.Add(info)
            Return info
        End Function

        Public ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
            Get
                Return True
            End Get
        End Property

        'TODO: INSTANT VB TODO TASK: property is a keyword in VB.NET. Change the name or use square brackets to override it:
        'INSTANT VB NOTE: The parameter property was renamed since it is a keyword in VB:
        Public Sub RemoveIndex(ByVal property_Renamed As PropertyDescriptor) Implements IBindingList.RemoveIndex
        End Sub

        Public ReadOnly Property IsReadOnly() As Boolean Implements IBindingList.IsReadOnly
            Get
                Return False
            End Get
        End Property

        'Property IList.this(Integer index) As Object
        '         Get
        '             Return list(index)
        '         End Get
        '         Set(ByVal value)
        '             list(index) = Value
        '         End Set
        '     End Property

        Public Sub RemoveAt(ByVal index As Integer) Implements IBindingList.RemoveAt
            list.RemoveAt(index)
            RaiseListChanged(ListChangedType.ItemDeleted, index)
        End Sub

        Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IBindingList.Insert
            list.Insert(index, value)
            RaiseListChanged(ListChangedType.ItemAdded, index)
        End Sub

        Public Sub Remove(ByVal value As Object) Implements IBindingList.Remove
            Dim index As Integer = list.IndexOf(value)
            list.Remove(value)
            RaiseListChanged(ListChangedType.ItemDeleted, index)
        End Sub

        Public Function Contains(ByVal value As Object) As Boolean Implements IBindingList.Contains
            Return list.Contains(value)
        End Function

        Public Sub Clear() Implements IBindingList.Clear
            list.Clear()
        End Sub

        Public Function IndexOf(ByVal value As Object) As Integer Implements IBindingList.IndexOf
            Return list.IndexOf(value)
        End Function

        Public Function Add(ByVal value As Object) As Integer Implements IBindingList.Add
            'INSTANT VB NOTE: The local variable count was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            Dim count_Renamed As Integer = list.Add(value)
            RaiseListChanged(ListChangedType.ItemAdded, list.Count - 1)
            Return count_Renamed
        End Function

        Public ReadOnly Property IsFixedSize() As Boolean Implements IBindingList.IsFixedSize
            Get
                Return False
            End Get
        End Property

        Private Sub RaiseListChanged(ByVal type As ListChangedType, ByVal index As Integer)
            If Not ListChangedEvent Is Nothing Then
                RaiseEvent ListChanged(Me, New ListChangedEventArgs(type, index))
            End If
        End Sub



        Public ReadOnly Property IsSynchronized() As Boolean Implements IBindingList.IsSynchronized
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property Count() As Integer Implements IBindingList.Count
            Get
                Return list.Count
            End Get
        End Property

        Public Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements IBindingList.CopyTo
            list.CopyTo(array, index)
        End Sub

        Public ReadOnly Property SyncRoot() As Object Implements IBindingList.SyncRoot
            Get
                Return list.SyncRoot
            End Get
        End Property


#Region "IEnumerable Members"

        Public Function GetEnumerator() As IEnumerator Implements IBindingList.GetEnumerator
            Return list.GetEnumerator()
        End Function

#End Region
    End Class
End Namespace
