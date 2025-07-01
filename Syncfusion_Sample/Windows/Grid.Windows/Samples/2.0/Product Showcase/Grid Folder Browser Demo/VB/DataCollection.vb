Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data


Namespace FolderBrowser
    ''' <summary>
    ''' Summary description for DataCollection.
    ''' </summary>
    Public Class DataCollection : Implements IBindingList
        Private list As ArrayList

        Public Sub New()
            list = New ArrayList
        End Sub

        Default Public Property Item(ByVal index As Integer) As SampleData
            Get
                Return CType(list(index), SampleData)
            End Get
            Set(ByVal Value As SampleData)
                list(index) = Value
            End Set
        End Property

#Region "IBindingList Members"

        Public Sub AddIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.AddIndex
        End Sub

        Public ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
            Get
                Return True
            End Get
        End Property

        Public Sub ApplySort(ByVal [property] As PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection) Implements IBindingList.ApplySort
        End Sub

        Public ReadOnly Property SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
            Get
                Return Nothing
            End Get
        End Property

        Public Function Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
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
                Return New System.ComponentModel.ListSortDirection
            End Get
        End Property
        Public Event ListChanged As System.ComponentModel.ListChangedEventHandler Implements IBindingList.ListChanged
        Public ReadOnly Property SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
            Get
                Return False
            End Get
        End Property

        Public Sub RemoveSort() Implements IBindingList.RemoveSort
        End Sub

        Public Function AddNew() As Object Implements IBindingList.AddNew
            Dim info As SampleData = New SampleData
            Me.list.Add(info)
            Return info
        End Function

        Public ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
            Get
                Return True
            End Get
        End Property

        Public Sub RemoveIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
        End Sub

#End Region

#Region "IList Members"

        Public ReadOnly Property IsReadOnly() As Boolean Implements IList.IsReadOnly
            Get
                Return False
            End Get
        End Property

        Property IList_Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                Return list(index)
            End Get
            Set(ByVal Value As Object)
                list(index) = Value
            End Set
        End Property


        Private Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
            list.RemoveAt(index)
        End Sub

        Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
            list.Insert(index, value)
        End Sub

        Public Sub Remove(ByVal value As Object) Implements IList.Remove
            list.Remove(value)
        End Sub

        Public Function Contains(ByVal value As Object) As Boolean Implements IList.Contains
            Return list.Contains(value)
        End Function

        Public Sub Clear() Implements IList.Clear
            list.Clear()
        End Sub

        Public Function IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
            Return list.IndexOf(value)
        End Function

        Public Function Add(ByVal value As Object) As Integer Implements IList.Add
            Return list.Add(value)
        End Function

        Public ReadOnly Property IsFixedSize() As Boolean Implements IList.IsFixedSize
            Get
                Return False
            End Get
        End Property

#End Region

#Region "ICollection Members"

        Public ReadOnly Property IsSynchronized() As Boolean Implements ICollection.IsSynchronized
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property Count() As Integer Implements ICollection.Count
            Get
                Return list.Count
            End Get
        End Property

        Public Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
            list.CopyTo(array, index)
        End Sub

        Public ReadOnly Property SyncRoot() As Object Implements ICollection.SyncRoot
            Get
                Return list.SyncRoot
            End Get
        End Property

#End Region

#Region "IEnumerable Members"

        Public Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
            Return list.GetEnumerator()
        End Function

#End Region
    End Class
End Namespace
