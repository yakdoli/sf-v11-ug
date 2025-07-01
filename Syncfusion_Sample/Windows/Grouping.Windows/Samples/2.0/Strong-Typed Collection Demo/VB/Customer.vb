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

Imports Syncfusion.ComponentModel
Imports Syncfusion.Drawing
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid


Public Class PopulateCustomers

    Public Shared Function CreateCustomers() As CustomerCollection
        Dim customers As New CustomerCollection()
        Dim cust1 As Customer = ReadCustomer1()
        cust1.Children.Add(ReadCustomer3())
        cust1.Children.Add(ReadCustomer4())
        customers.Add(cust1)
        Dim cust2 As Customer = ReadCustomer2()
        cust2.Children.Add(ReadCustomer5())
        'cust2.Children.Add(ReadCustomer6());
        customers.Add(cust2)
        Return customers
    End Function 'CreateCustomers


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
End Class 'PopulateCustomers

<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class Customer
    Implements IEditableObject

    Structure CustomerData
        Friend id As String
        Friend firstName As String
        Friend lastName As String
    End Structure 'CustomerData

#Region "Fields"

    Private _parentCollection As CustomerCollection
    Private _children As New CustomerCollection()
    Private custData As CustomerData
    Private backupData As CustomerData
    Private beginEditCalled As Boolean = False
    Private modified As Boolean = False
    Private _forwardEditableObject As IEditableObject

#End Region

#Region "Events"

    Public Event PropertyChanged As PropertyChangedEventHandler


    Protected Overridable Sub OnPropertyChanged(ByVal e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub 'OnPropertyChanged

    '/ <summary>
    '/ Raises PropertyChanged event
    '/ </summary>
    '/ <param name="propertyName"></param>
    Sub RaisePropertyChanged(ByVal propertyName As String)
        OnPropertyChanged(New PropertyChangedEventArgs(propertyName))

        If Not Me.beginEditCalled Then
            If Not (_parentCollection Is Nothing) Then
                _parentCollection.NotifyItemPropertyChanged(Me, propertyName)
            End If
        Else
            modified = True
        End If
    End Sub 'RaisePropertyChanged 
#End Region

#Region "ctor"


    '/ <summary>
    '/ Default ctor needed for Xml and CodeDom serialization of strong-typed collections and
    '/ for Essential Grid to be able to detect properties of items in strong-typed collections.
    '/ </summary>
    Public Sub New()
        Me.custData = New CustomerData()
        Me.custData.id = ""
        Me.custData.firstName = ""
        Me.custData.lastName = ""
    End Sub 'New


    '/ <summary>
    '/ Specialized ctor
    '/ </summary>
    '/ <param name="ID"></param>
    Public Sub New(ByVal ID As String)
        Me.custData = New CustomerData()
        Me.custData.id = ID
        Me.custData.firstName = ""
        Me.custData.lastName = ""
    End Sub 'New

#End Region

#Region "IEditableObject implementation"

    ' lets ParentCollection collection be aware of status (used when AddNew was called).

    <Browsable(False)> _
    Public Property ForwardEditableObject() As IEditableObject
        Get
            Return Me._forwardEditableObject
        End Get
        Set(ByVal Value As IEditableObject)
            Me._forwardEditableObject = Value
        End Set
    End Property


    Public Sub BeginEdit() Implements IEditableObject.BeginEdit
        If Not beginEditCalled Then
            Me.backupData = custData
            beginEditCalled = True
            Console.WriteLine("BeginEdit - " + Me.backupData.lastName)
            If Not (ForwardEditableObject Is Nothing) Then
                ForwardEditableObject.BeginEdit()
            End If
            modified = False
        End If
    End Sub 'BeginEdit


    Public Sub CancelEdit() Implements IEditableObject.CancelEdit
        If beginEditCalled Then
            Me.custData = backupData
            beginEditCalled = False
            Console.WriteLine("CancelEdit - " + Me.custData.lastName)
            If Not (ForwardEditableObject Is Nothing) Then
                ForwardEditableObject.CancelEdit()
            End If
            modified = False
        End If
    End Sub 'CancelEdit


    Public Sub EndEdit() Implements IEditableObject.EndEdit
        If beginEditCalled Then
            backupData = New CustomerData()
            beginEditCalled = False
            Console.WriteLine("Done EndEdit - " + Me.custData.id + Me.custData.lastName)
            If Not (ForwardEditableObject Is Nothing) Then
                ForwardEditableObject.EndEdit()
            End If
            If Not (ParentCollection Is Nothing) AndAlso modified Then
                Me.ParentCollection.RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, ParentCollection.IndexOf(Me), -1))
            End If
            modified = False
        End If
    End Sub 'EndEdit



    <Browsable(False)> _
    Public ReadOnly Property IsBeginEditCalled() As Boolean
        Get
            Return Me.beginEditCalled
        End Get
    End Property

#End Region

#Region "Properties"


    <Browsable(True)> _
    Public Property ID() As String
        Get
            Return Me.custData.id
        End Get
        Set(ByVal Value As String)
            If ID <> Value Then
                Me.custData.id = Value
                RaisePropertyChanged("ID")
            End If
        End Set
    End Property


    <Browsable(True)> _
    Public Property FirstName() As String
        Get
            Return Me.custData.firstName
        End Get
        Set(ByVal Value As String)
            If FirstName <> Value Then
                Me.custData.firstName = Value
                RaisePropertyChanged("FirstName")
            End If
        End Set
    End Property


    <Browsable(True)> _
    Public Property LastName() As String
        Get
            Return Me.custData.lastName
        End Get
        Set(ByVal Value As String)
            If LastName <> Value Then
                Me.custData.lastName = Value
                RaisePropertyChanged("LastName")
            End If
        End Set
    End Property


    <Browsable(True), DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)> _
    Public Property Children() As CustomerCollection
        Get
            Return _children
        End Get
        Set(ByVal Value As CustomerCollection)
            If Not [Object].ReferenceEquals(Children, Value) Then
                _children = Value
                RaisePropertyChanged("Children")
            End If
        End Set
    End Property


    Public Function ShouldSerializeChildren() As Boolean
        Return Not (_children Is Nothing) AndAlso _children.Count > 0
    End Function 'ShouldSerializeChildren


    <Browsable(False), DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)> _
    Public Property ParentCollection() As CustomerCollection ' do not show as field in grid
        Get
            Return _parentCollection
        End Get
        Set(ByVal Value As CustomerCollection)
            _parentCollection = Value
        End Set
    End Property


    Public Function ShouldSerializeParentCollection() As Boolean
        Return False
    End Function 'ShouldSerializeParentCollection

#End Region
End Class 'Customer


Public Class CustomerCollection
    Implements IBindingList
    Private inner As New ArrayList()


    Public Sub New()
    End Sub 'New


    Public Overrides Function ToString() As String
        Return [GetType]().Name.ToString() + "{ " + String.Format("Count {0}", Count) + " }"
    End Function 'ToString


    Default Public Property Item(ByVal index As Integer) As Customer
        Get
            Return CType(inner(index), Customer)
        End Get
        Set(ByVal Value As Customer)
            If Not Object.ReferenceEquals(inner(index), Value) Then
                inner(index) = Value
                Value.ParentCollection = Me
                RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, index, index))
            End If
        End Set
    End Property


    Public Function Contains(ByVal value As Customer) As Boolean
        If value Is Nothing Then
            Return False
        End If
        Return inner.Contains(value)
    End Function 'Contains


    Public Function IndexOf(ByVal value As Customer) As Integer
        Return inner.IndexOf(value)
    End Function 'IndexOf


    Public Sub CopyTo(ByVal array() As Customer, ByVal index As Integer)
        Dim count As Integer = count
        Dim n As Integer
        For n = 0 To count - 1
            array((index + n)) = Me(n)
        Next n
    End Sub 'CopyTo 

    Public ReadOnly Property SyncRoot() As CustomerCollection
        Get
            Throw New NotSupportedException()
        End Get
    End Property


    Public Function GetEnumerator() As CustomerCollectionEnumerator
        Return New CustomerCollectionEnumerator(Me)
    End Function 'GetEnumerator


    Public Sub Insert(ByVal index As Integer, ByVal value As Customer)
        inner.Insert(index, value)
        value.ParentCollection = Me
        RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index, -1))
    End Sub 'Insert


    Public Sub Remove(ByVal value As Customer)
        Dim index As Integer = IndexOf(value)
        RemoveAt(index)
    End Sub 'Remove


    Public Function Add(ByVal value As Customer) As Integer
        Dim index As Integer = inner.Add(value)
        value.ParentCollection = Me
        RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index, -1))
        Return index
    End Function 'Add


    Public Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
        inner.RemoveAt(index)
        RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemDeleted, index, -1))
    End Sub 'RemoveAt


    Public Sub Clear() Implements IList.Clear
        If inner.Count > 0 Then
            inner.Clear()
            RaiseListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1, -1))
        End If
    End Sub 'Clear


    Public ReadOnly Property IsReadOnly() As Boolean Implements IList.IsReadOnly
        Get
            Return False
        End Get
    End Property


    Public ReadOnly Property IsFixedSize() As Boolean Implements IList.IsFixedSize
        Get
            Return False
        End Get
    End Property


    Public ReadOnly Property IsSynchronized() As Boolean Implements IList.IsSynchronized
        Get
            Return False
        End Get
    End Property


    Public ReadOnly Property Count() As Integer Implements IList.Count
        Get
            Return inner.Count
        End Get
    End Property



    Public Sub NotifyItemPropertyChanged(ByVal item As Customer, ByVal propertyName As String)
        Me.RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, IndexOf(item), -1))
    End Sub 'NotifyItemPropertyChanged

#Region "IList Private Members"


    Property IList_Item(ByVal index As Integer) As Object Implements IList.Item
        Get
            Return Me(index)
        End Get
        Set(ByVal Value As Object)
            Me(index) = CType(Value, Customer)
        End Set
    End Property


    Sub IList_Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
        Insert(index, CType(value, Customer))
    End Sub 'IList.Insert


    Sub IList_Remove(ByVal value As Object) Implements IList.Remove
        Remove(CType(value, Customer))
    End Sub 'IList.Remove


    Function IList_Contains(ByVal value As Object) As Boolean Implements IList.Contains
        Return Contains(CType(value, Customer))
    End Function 'IList.Contains


    Function IList_IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
        Return IndexOf(CType(value, Customer))
    End Function 'IList.IndexOf


    Function IList_Add(ByVal value As Object) As Integer Implements IList.Add
        Return Add(CType(value, Customer))
    End Function 'IList.Add

#End Region

#Region "ICollection Private Members"


    Sub ICollection_CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
        CopyTo(CType(array, Customer()), index)
    End Sub 'ICollection.CopyTo


    ReadOnly Property ICollection_SyncRoot() As Object Implements ICollection.SyncRoot
        Get
            Return Nothing
        End Get
    End Property

#End Region

#Region "IEnumerable Private Members"


    Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function 'IEnumerable.GetEnumerator

#End Region

#Region "IBindingList Members"

    ' Implements IBindingList.

    Public ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property AllowRemove() As Boolean Implements IBindingList.AllowRemove
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
        Get
            Return True
        End Get
    End Property

    Public ReadOnly Property SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
        Get
            Return False
        End Get
    End Property

    Public ReadOnly Property SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
        Get
            Return False
        End Get
    End Property

    ' Events.
    Public Event ListChanged As ListChangedEventHandler Implements IBindingList.ListChanged


    Protected Overridable Sub OnListChanged(ByVal e As ListChangedEventArgs)
        RaiseEvent ListChanged(Me, e)
    End Sub 'OnListChanged

    Public Sub RaiseListChanged(ByVal e As ListChangedEventArgs)
        OnListChanged(e)
    End Sub 'RaiseListChanged


    ' Methods.
    Public Function AddNew() As Customer
        Dim c As New Customer(Me.Count.ToString())
        Dim index As Integer = Add(c)
        Dim obj As New AddNewObjectListener(Me, c, index)
        Return c
    End Function 'AddNew

    Function IBindingList_AddNew() As Object Implements IBindingList.AddNew
        Return AddNew()
    End Function 'IBindingList.AddNew


    Public Class AddNewObjectListener
        Implements IEditableObject
        Private customers As CustomerCollection
        Private item As Customer
        Private index As Integer


        Public Sub New(ByVal customers As CustomerCollection, ByVal item As Customer, ByVal index As Integer)
            Me.customers = customers
            Me.item = item
            Me.index = index
            item.ForwardEditableObject = Me
        End Sub 'New


        Public Sub Detach()
            item.ForwardEditableObject = Nothing
            customers = Nothing
            item = Nothing
        End Sub 'Detach

#Region "IEditableObject Members"


        Public Sub EndEdit() Implements IEditableObject.EndEdit
            'customers.RaiseListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, index, index));
            Detach()
        End Sub 'EndEdit


        Public Sub CancelEdit() Implements IEditableObject.CancelEdit
            ' When a AddNew operation is canceld by the user the object needs to be removed again from
            ' the list.
            customers.RemoveAt(index)

            Detach()
        End Sub 'CancelEdit


        Public Sub BeginEdit() Implements IEditableObject.BeginEdit
        End Sub 'BeginEdit

#End Region
    End Class 'AddNewObjectListener

    ' Unsupported properties.

    ReadOnly Property IsSorted() As Boolean Implements IBindingList.IsSorted
        Get
            Throw New NotSupportedException()
        End Get
    End Property

    ReadOnly Property SortDirection() As ListSortDirection Implements IBindingList.SortDirection
        Get
            Throw New NotSupportedException()
        End Get
    End Property


    ReadOnly Property SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
        Get
            Throw New NotSupportedException()
        End Get
    End Property

    ' Unsupported Methods.
    Sub AddIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.AddIndex
        Throw New NotSupportedException()
    End Sub 'IBindingList.AddIndex


    Sub ApplySort(ByVal [property] As PropertyDescriptor, ByVal direction As ListSortDirection) Implements IBindingList.ApplySort
        Throw New NotSupportedException()
    End Sub 'IBindingList.ApplySort


    Function Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
        Throw New NotSupportedException()
    End Function 'IBindingList.Find


    Sub RemoveIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
        Throw New NotSupportedException()
    End Sub 'IBindingList.RemoveIndex


    Sub RemoveSort() Implements IBindingList.RemoveSort
        Throw New NotSupportedException()
    End Sub 'IBindingList.RemoveSort

#End Region
End Class 'CustomerCollection 


Public Class CustomerCollectionEnumerator
    Implements IEnumerator
    Private _cursor As Integer = -1
    Private _next As Integer = -1
    Private _coll As CustomerCollection


    Public Sub New(ByVal ParentCollectionCollection As CustomerCollection)
        _coll = ParentCollectionCollection
        _next = IIf(_coll.Count > 0, 0, -1)
    End Sub 'New

#Region "IEnumerator Members"


    Public Overridable Sub Reset() Implements IEnumerator.Reset
        _cursor = -1
        _next = IIf(_coll.Count > 0, 0, -1)
    End Sub 'Reset


    ReadOnly Property IEnumerator_Current() As Object Implements IEnumerator.Current
        Get
            Return Current
        End Get
    End Property


    Public ReadOnly Property Current() As Customer
        Get
            Return _coll(_cursor)
        End Get
    End Property


    Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
        If _next = -1 Then
            Return False
        End If
        _cursor = _next

        _next += 1
        If _next >= _coll.Count Then
            _next = -1
        End If
        Return _cursor <> -1
    End Function 'MoveNext
#End Region
End Class 'CustomerCollectionEnumerator 
