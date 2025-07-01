Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2011"
'
'  Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
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
Imports Syncfusion.Drawing
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace IEnumerableDemo
	Public Class PopulateCustomers
		Public Shared Function CreateCustomers() As CustomerCollection
			Dim customers As New CustomerCollection()
			customers.Add(ReadCustomer1())
			customers.Add(ReadCustomer2())
			customers.Add(ReadCustomer3())
			customers.Add(ReadCustomer4())
			customers.Add(ReadCustomer5())
			customers.Add(ReadCustomer6())
			customers.Add(ReadCustomer7())
			customers.Add(ReadCustomer8())
			customers.Add(ReadCustomer9())
			customers.Add(ReadCustomer10())
			customers.Add(ReadCustomer11())
			customers.Add(ReadCustomer12())
			customers.Add(ReadCustomer13())
			customers.Add(ReadCustomer14())
			customers.Add(ReadCustomer15())
			Return customers

		End Function

		' Worker functions to populate the list with data.
		Private Shared Function ReadCustomer1() As Customer
			Dim cust As New Customer("536-45-1245")
			cust.FirstName = "Jo"
			cust.LastName = "Brown"
			Return cust
		End Function

		Private Shared Function ReadCustomer2() As Customer
			Dim cust As New Customer("246-12-5645")
			cust.FirstName = "Robert"
			cust.LastName = "hristina Berglund"
			Return cust
		End Function

		Private Shared Function ReadCustomer3() As Customer
			Dim cust As New Customer("537-45-1245")
			cust.FirstName = "Keith Parker Cruse"
			cust.LastName = "Steve"
			Return cust
		End Function

		Private Shared Function ReadCustomer4() As Customer
			Dim cust As New Customer("247-12-5645")
			cust.FirstName = "Sven hills Bro"
			cust.LastName = "Brown kute Haris"
			Return cust
		End Function

		Private Shared Function ReadCustomer5() As Customer
			Dim cust As New Customer("538-45-1245")
			cust.FirstName = "Katie"
			cust.LastName = "Steve"
			Return cust
		End Function

		Private Shared Function ReadCustomer6() As Customer
			Dim cust As New Customer("248-12-5645")
			cust.FirstName = "Steve"
			cust.LastName = "Brown"
			Return cust
		End Function

		Private Shared Function ReadCustomer7() As Customer
			Dim cust As New Customer("257-11-5895")
			cust.FirstName = "Hanna Moos"
			cust.LastName = "Steve"
			Return cust
		End Function
		Private Shared Function ReadCustomer8() As Customer
			Dim cust As New Customer("250-17-8625")
			cust.FirstName = "Christina Berglund"
			cust.LastName = "Hanna Moos"
			Return cust
		End Function
		Private Shared Function ReadCustomer9() As Customer
			Dim cust As New Customer("158-11-5635")
			cust.FirstName = "Thomas Hardy"
			cust.LastName = "Christina Berglund"
			Return cust
		End Function
		Private Shared Function ReadCustomer10() As Customer
			Dim cust As New Customer("158-11-5635")
			cust.FirstName = "Martín Sommer"
			cust.LastName = "Elizabeth Lincoln"
			Return cust
		End Function
		Private Shared Function ReadCustomer11() As Customer
			Dim cust As New Customer("758-14-5335")
			cust.FirstName = "Elizabeth Lincoln"
			cust.LastName = "Christina Berglund"
			Return cust
		End Function
		Private Shared Function ReadCustomer12() As Customer
			Dim cust As New Customer("558-31-6635")
			cust.FirstName = "Patricio Simpson"
			cust.LastName = "Martín Sommer"
			Return cust
		End Function
		Private Shared Function ReadCustomer13() As Customer
			Dim cust As New Customer("154-10-8635")
			cust.FirstName = "Aria Cruz"
			cust.LastName = "Sven Ottlieb"
			Return cust
		End Function
		Private Shared Function ReadCustomer14() As Customer
			Dim cust As New Customer("168-11-5135")
			cust.FirstName = "Peter Franken"
			cust.LastName = "Christina Berglund"
			Return cust
		End Function
		Private Shared Function ReadCustomer15() As Customer
			Dim cust As New Customer("188-01-3605")
			cust.FirstName = "Sven Ottlieb"
			cust.LastName = "Peter Franken"
			Return cust
		End Function
	End Class

	<TypeConverter(GetType(ExpandableObjectConverter))> _
	Public Class Customer
		Implements IEditableObject
		Private Structure CustomerData
			Friend id As String
			Friend firstName As String
			Friend lastName As String
		End Structure

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
		End Sub

		''' <summary>
		''' Raises PropertyChanged event
		''' </summary>
		''' <param name="propertyName"></param>
		Private Sub RaisePropertyChanged(ByVal propertyName As String)
			OnPropertyChanged(New PropertyChangedEventArgs(propertyName))

			If Not Me.beginEditCalled Then
				If _parentCollection IsNot Nothing Then
					_parentCollection.NotifyItemPropertyChanged(Me, propertyName)
				End If
			Else
				modified = True
			End If
		End Sub

		#End Region 

		#Region "ctor"

		''' <summary>
		''' Default ctor needed for Xml and CodeDom serialization of strong-typed collections and
		''' for Essential Grid to be able to detect properties of items in strong-typed collections.
		''' </summary>
		Public Sub New()
			Me.custData = New CustomerData()
			Me.custData.id = ""
			Me.custData.firstName = ""
			Me.custData.lastName = ""
		End Sub

		''' <summary>
		''' Specialized ctor
		''' </summary>
		''' <param name="ID"></param>
		Public Sub New(ByVal ID As String)
			Me.custData = New CustomerData()
			Me.custData.id = ID
			Me.custData.firstName = ""
			Me.custData.lastName = ""
		End Sub

		#End Region 

		#Region "IEditableObject implementation"

		' lets ParentCollection collection be aware of status (used when AddNew was called).
		<Browsable(False)> _
		Public Property ForwardEditableObject() As IEditableObject
			Get
				Return Me._forwardEditableObject
			End Get
			Set(ByVal value As IEditableObject)
				Me._forwardEditableObject = value
			End Set
		End Property

		Public Sub BeginEdit() Implements IEditableObject.BeginEdit
			If Not beginEditCalled Then
				Me.backupData = custData
				beginEditCalled = True
				Console.WriteLine("BeginEdit - " & Me.backupData.lastName)
				If ForwardEditableObject IsNot Nothing Then
					ForwardEditableObject.BeginEdit()
				End If
				modified = False
			End If
		End Sub

		Public Sub CancelEdit() Implements IEditableObject.CancelEdit
			If beginEditCalled Then
				Me.custData = backupData
				beginEditCalled = False
				Console.WriteLine("CancelEdit - " & Me.custData.lastName)
				If ForwardEditableObject IsNot Nothing Then
					ForwardEditableObject.CancelEdit()
				End If
				modified = False
			End If
		End Sub

		Public Sub EndEdit() Implements IEditableObject.EndEdit
			If beginEditCalled Then
				backupData = New CustomerData()
				beginEditCalled = False
				Console.WriteLine("Done EndEdit - " & Me.custData.id & Me.custData.lastName)
				If ForwardEditableObject IsNot Nothing Then
					ForwardEditableObject.EndEdit()
				End If

				If ParentCollection IsNot Nothing AndAlso modified Then
					Me.ParentCollection.RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, ParentCollection.IndexOf(Me), -1))
				End If
				modified = False
			End If
		End Sub


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
			Set(ByVal value As String)
				If ID <> value Then
					Me.custData.id = value
					RaisePropertyChanged("ID")
				End If
			End Set
		End Property

		<Browsable(True)> _
		Public Property FirstName() As String
			Get
				Return Me.custData.firstName
			End Get
			Set(ByVal value As String)
				If FirstName <> value Then
					Me.custData.firstName = value
					RaisePropertyChanged("FirstName")
				End If
			End Set
		End Property

		<Browsable(True)> _
		Public Property LastName() As String
			Get
				Return Me.custData.lastName
			End Get
			Set(ByVal value As String)
				If LastName <> value Then
					Me.custData.lastName = value
					RaisePropertyChanged("LastName")
				End If
			End Set
		End Property

		<Browsable(False), DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)> _
		Public Property ParentCollection() As CustomerCollection ' do not show as field in grid
			Get
				Return _parentCollection
			End Get
			Set(ByVal value As CustomerCollection)
				_parentCollection = value
			End Set
		End Property

		Public Function ShouldSerializeParentCollection() As Boolean
			Return False
		End Function

		#End Region
	End Class

	Public Class CustomerCollection
		Implements IList, IBindingList
		Private inner As New ArrayList()

		Public Sub New()
		End Sub

		Public Overrides Function ToString() As String
			Return Me.GetType().Name.ToString() & "{ " & String.Format("Count {0}", Count) & " }"
		End Function

		Default Public Property Item(ByVal index As Integer) As Customer
			Get
				Return CType(inner(index), Customer)
			End Get
			Set(ByVal value As Customer)
				If Not Object.ReferenceEquals(inner(index), value) Then
					inner(index) = value
					value.ParentCollection = Me
					RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, index, index))
				End If
			End Set
		End Property

		Public Function Contains(ByVal value As Customer) As Boolean
			If value Is Nothing Then
				Return False
			End If

			Return inner.Contains(value)
		End Function

		Public Function IndexOf(ByVal value As Customer) As Integer
			Return inner.IndexOf(value)
		End Function

		Public Sub CopyTo(ByVal array() As Customer, ByVal index As Integer)
			Dim count As Integer = Me.Count
			For n As Integer = 0 To count - 1
				array(index+n) = Me(n)
			Next n
		End Sub

		Public ReadOnly Property SyncRoot() As CustomerCollection
			Get
				Throw New NotSupportedException()
			End Get
		End Property

		Public Function GetEnumerator() As CustomerCollectionEnumerator
			Return New CustomerCollectionEnumerator(Me)
		End Function

		Public Sub Insert(ByVal index As Integer, ByVal value As Customer)
			inner.Insert(index, value)
			value.ParentCollection = Me
			RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index, -1))
		End Sub

		Public Sub Remove(ByVal value As Customer)
			Dim index As Integer = IndexOf(value)
			RemoveAt(index)
		End Sub

		Public Function Add(ByVal value As Customer) As Integer
			Dim index As Integer = inner.Add(value)
			value.ParentCollection = Me
			RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemAdded, index, -1))
			Return index
		End Function

		Public Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
			inner.RemoveAt(index)
			RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemDeleted, index, -1))
		End Sub

		Public Sub Clear() Implements IList.Clear
			If inner.Count > 0 Then
				inner.Clear()
				RaiseListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1, -1))
			End If
		End Sub

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

		Public ReadOnly Property IsSynchronized() As Boolean Implements System.Collections.ICollection.IsSynchronized
			Get
				Return False
			End Get
		End Property

		Public ReadOnly Property Count() As Integer Implements System.Collections.ICollection.Count
			Get
				Return inner.Count
			End Get
		End Property


		Public Sub NotifyItemPropertyChanged(ByVal item As Customer, ByVal propertyName As String)
			Me.RaiseListChanged(New ListChangedEventArgs(ListChangedType.ItemChanged, IndexOf(item), -1))
		End Sub

		#Region "IList Private Members"

		Public Property IList_Item(ByVal index As Integer) As Object Implements IList.Item
			Get
				Return Me(index)
			End Get
			Set(ByVal value As Object)
				Me(index) = CType(value, Customer)
			End Set
		End Property

		Private Sub IList_Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
			Insert(index, CType(value, Customer))
		End Sub

		Private Sub IList_Remove(ByVal value As Object) Implements IList.Remove
			Remove(CType(value, Customer))
		End Sub

		Private Function IList_Contains(ByVal value As Object) As Boolean Implements IList.Contains
			Return Contains(CType(value, Customer))
		End Function

		Private Function IList_IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
			Return IndexOf(CType(value, Customer))
		End Function

		Private Function IList_Add(ByVal value As Object) As Integer Implements IList.Add
			Return Add(CType(value, Customer))
		End Function

		#End Region

		#Region "ICollection Private Members"

		Private Sub ICollection_CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
			CopyTo(CType(array, Customer()), index)
		End Sub

		Private ReadOnly Property ICollection_SyncRoot() As Object Implements ICollection.SyncRoot
			Get
				Return Nothing
			End Get
		End Property

		#End Region

		#Region "IEnumerable Private Members"

		Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
			Return GetEnumerator()
		End Function

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
		End Sub

		Public Sub RaiseListChanged(ByVal e As ListChangedEventArgs)
			OnListChanged(e)
		End Sub

		' Methods.

		Public Function AddNew() As Customer
			Dim c As New Customer(Me.Count.ToString())
			Dim TempAddNewObjectListener As AddNewObjectListener = New AddNewObjectListener(Me, c, Add(c))
			Return c
		End Function

		Private Function IBindingList_AddNew() As Object Implements IBindingList.AddNew
			Return AddNew()
		End Function

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
			End Sub

			Public Sub Detach()
				item.ForwardEditableObject = Nothing
				customers = Nothing
				item = Nothing
			End Sub

			#Region "IEditableObject Members"

			Public Sub EndEdit() Implements IEditableObject.EndEdit


				Detach()
			End Sub

			Public Sub CancelEdit() Implements IEditableObject.CancelEdit
				' When a AddNew operation is canceld by the user the object needs to be removed again from
				' the list.
				customers.RemoveAt(index)

				Detach()
			End Sub

			Public Sub BeginEdit() Implements IEditableObject.BeginEdit
			End Sub

			#End Region
		End Class

		' Unsupported properties.
		Private ReadOnly Property IsSorted() As Boolean Implements IBindingList.IsSorted
			Get
				Throw New NotSupportedException()
			End Get
		End Property

		Private ReadOnly Property SortDirection() As ListSortDirection Implements IBindingList.SortDirection
			Get
				Throw New NotSupportedException()
			End Get
		End Property


		Private ReadOnly Property SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
			Get
				Throw New NotSupportedException()
			End Get
		End Property

		' Unsupported Methods.
		Private Sub AddIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.AddIndex
			Throw New NotSupportedException()
		End Sub

		Private Sub ApplySort(ByVal [property] As PropertyDescriptor, ByVal direction As ListSortDirection) Implements IBindingList.ApplySort
			Throw New NotSupportedException()
		End Sub

		Private Function Find(ByVal [property] As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
			Throw New NotSupportedException()
		End Function

		Private Sub RemoveIndex(ByVal [property] As PropertyDescriptor) Implements IBindingList.RemoveIndex
			Throw New NotSupportedException()
		End Sub

		Private Sub RemoveSort() Implements IBindingList.RemoveSort
			Throw New NotSupportedException()
		End Sub

		#End Region

	End Class

	Public Class CustomerCollectionEnumerator
		Implements IEnumerator
		Private _cursor As Integer = -1, _next As Integer = -1
		Private _coll As CustomerCollection

		Public Sub New(ByVal ParentCollectionCollection As CustomerCollection)
			_coll = ParentCollectionCollection
            If _coll.Count > 0 Then
                _next = 0
            Else
                _next = -1
            End If
        End Sub

		#Region "IEnumerator Members"

		Public Overridable Sub Reset() Implements IEnumerator.Reset
			_cursor = -1
            If _coll.Count > 0 Then
                _next = 0
            Else
                _next = -1
            End If

		End Sub

		Private ReadOnly Property IEnumerator_Current() As Object Implements IEnumerator.Current
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
		End Function
		#End Region

	End Class


End Namespace
