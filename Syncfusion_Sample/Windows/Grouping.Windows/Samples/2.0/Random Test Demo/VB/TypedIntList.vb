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


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Text
Imports System.Globalization
Imports System.Runtime.Serialization
Imports System.ComponentModel.Design.Serialization

Imports Syncfusion.Diagnostics
Imports Syncfusion.Collections


Namespace RandomTest
	Public Structure WrappedInt
		Implements IConvertible, IComparable
		Private val As Int32

		Public Sub New(ByVal val As Int32)
			Me.val = val
			'listName = null;
			'this.itemProperties = null;
		End Sub
		Public Property Value() As Int32
			Get
				Return Me.val
			End Get
			Set(ByVal value As Int32)
				Me.val = value
			End Set
		End Property
		Public Shared Widening Operator CType(ByVal m As WrappedInt) As Int32
			Return m.Value
		End Operator
		Public Shared Narrowing Operator CType(ByVal i As Int32) As WrappedInt
			Return New WrappedInt(i)
		End Operator

		Public Overrides Function ToString() As String
			Return Me.val.ToString()
		End Function

		#Region "IConvertible Members"

		Private Function ToUInt64(ByVal provider As IFormatProvider) As ULong Implements IConvertible.ToUInt64
			Return CULng(Me.val)
		End Function

		Private Function ToSByte(ByVal provider As IFormatProvider) As SByte Implements IConvertible.ToSByte
			Throw New InvalidCastException()
		End Function

		Private Function ToDouble(ByVal provider As IFormatProvider) As Double Implements IConvertible.ToDouble
			Return CDbl(Me.val)
		End Function

		Private Function ToDateTime(ByVal provider As IFormatProvider) As DateTime Implements IConvertible.ToDateTime
			Throw New InvalidCastException()
		End Function

		Private Function ToSingle(ByVal provider As IFormatProvider) As Single Implements IConvertible.ToSingle
			Return CSng(Me.val)
		End Function

		Private Function ToBoolean(ByVal provider As IFormatProvider) As Boolean Implements IConvertible.ToBoolean
			Throw New InvalidCastException()
		End Function

		Private Function ToInt32(ByVal provider As IFormatProvider) As Integer Implements IConvertible.ToInt32
			Return CInt(Fix(Me.val))
		End Function

		Private Function ToUInt16(ByVal provider As IFormatProvider) As UShort Implements IConvertible.ToUInt16
			Throw New InvalidCastException()
		End Function

		Private Function ToInt16(ByVal provider As IFormatProvider) As Short Implements IConvertible.ToInt16
			Throw New InvalidCastException()
		End Function

        Private Overloads Function ToString(ByVal provider As IFormatProvider) As String Implements IConvertible.ToString
            Return Me.ToString()
        End Function

		Private Function ToByte(ByVal provider As IFormatProvider) As Byte Implements IConvertible.ToByte
			Throw New InvalidCastException()
		End Function

		Private Function ToChar(ByVal provider As IFormatProvider) As Char Implements IConvertible.ToChar
			Throw New InvalidCastException()
		End Function

		Private Function ToInt64(ByVal provider As IFormatProvider) As Long Implements IConvertible.ToInt64
			Throw New InvalidCastException()
		End Function

		Private Function GetTypeCode() As TypeCode Implements IConvertible.GetTypeCode
			Return TypeCode.Object
		End Function

		Private Function ToDecimal(ByVal provider As IFormatProvider) As Decimal Implements IConvertible.ToDecimal
			Throw New InvalidCastException()
		End Function

		Private Function ToType(ByVal conversionType As Type, ByVal provider As IFormatProvider) As Object Implements IConvertible.ToType
			Try
				Return Activator.CreateInstance(conversionType, New Object() { Me })
			Catch ex As Exception
				Throw New InvalidCastException("", ex)
			End Try
		End Function

		Private Function ToUInt32(ByVal provider As IFormatProvider) As UInteger Implements IConvertible.ToUInt32
			Throw New InvalidCastException()
		End Function

		#End Region


		Public Function CompareTo(ByVal o As Object) As Integer Implements IComparable.CompareTo
			If o Is Nothing Then
				Return -1
			Else
				Dim wInt As WrappedInt = CType(o, WrappedInt)
				Return Me.val - wInt.Value

			End If
		End Function
	End Structure

	<ListBindableAttribute(False)> _
	Public Class IntegerCollection
		Implements IList, ICloneable, IBindingList, ITypedList
		Private inner As ArrayList = New ArrayList()
		Public Event Changed As ListPropertyChangedEventHandler
		Public Event Changing As ListPropertyChangedEventHandler
		Friend version_Renamed As Integer
		Friend insideCollectionEditor As Boolean = False
'		bool inInitializeFrom = false;

		Public Shared ReadOnly Empty As IntegerCollection = New IntegerCollection()

		Public Sub New()
		End Sub

		Public Sub New(ParamArray ByVal values As WrappedInt())
			Me.AddRange(values)
		End Sub

		Public Overrides Function ToString() As String
			Return String.Format("Count = {0}", Count)
		End Function

		Public Sub InitializeFrom(ByVal other As IntegerCollection)
			Dim i As Integer
'			inInitializeFrom = true;
			Dim count As Integer = Math.Min(Me.Count, other.Count)
			For i = 0 To count - 1
				Me(i) = other(i)
			Next i

			Do While i < other.Count
				Add(other(i))
				i += 1
			Loop

			Do While Me.Count > other.Count
				RemoveAt(Me.Count-1)
			Loop
'			inInitializeFrom = false;
		End Sub

		Public Sub AddRange(ByVal values As WrappedInt())
			Me.inner.AddRange(values)
		End Sub

		Private Sub New(ByVal values As WrappedInt(), ByVal version As Integer)
			Me.New(values)
			Me.version_Renamed = version
		End Sub

		Public Function Clone() As IntegerCollection
			Dim coll As IntegerCollection = New IntegerCollection()
			coll.inner = New ArrayList()
			Dim count As Integer = Me.Count
			Dim values As WrappedInt() = New WrappedInt(count - 1){}
			For n As Integer = 0 To count - 1
				coll.inner.Add(Me(n))
			Next n
			Return coll
		End Function

		Public Overrides Overloads Function Equals(ByVal obj As Object) As Boolean
			If Me Is Nothing AndAlso obj Is Nothing Then
				Return True
			ElseIf Me Is Nothing Then
				Return False
			ElseIf Not(TypeOf obj Is IntegerCollection) Then
				Return False
			End If

			Return Equals(CType(obj, IntegerCollection))
		End Function

		Public Overrides Function GetHashCode() As Integer
			Return MyBase.GetHashCode ()
		End Function

		Public ReadOnly Property Version() As Integer
			Get
				Return version_Renamed
			End Get
		End Property

		Private Overloads Function Equals(ByVal other As IntegerCollection) As Boolean
			Dim count As Integer = Me.Count
			If other.Count <> count Then
				Return False
			End If
			For n As Integer = 0 To count - 1
				If (Not Me(n).Equals(other(n))) Then
					Return False
				End If
			Next n
			Return True
		End Function

		Default Public Property Item(ByVal index As Integer) As WrappedInt
			Get
				Return CType(inner(index), WrappedInt)
			End Get
            Set(ByVal value As WrappedInt)
                If CInt(inner(index)) <> CInt(value) Then
                    OnChanging(New ListPropertyChangedEventArgs(ListPropertyChangedType.ItemChanged, index, value, Nothing))
                    inner(index) = value
                    OnChanged(New ListPropertyChangedEventArgs(ListPropertyChangedType.ItemChanged, index, value, Nothing))
                End If
            End Set
		End Property



		''' <summary>
		''' Checks if the group belongs to the details section and is visible
		''' </summary>
		''' <param name="value"></param>
		''' <returns></returns>
		Public Function Contains(ByVal value As WrappedInt) As Boolean
			Throw New NotSupportedException()
		End Function

		''' <summary>
		''' Gets the visible position within the details section.
		''' </summary>
		''' <param name="value"></param>
		''' <returns></returns>
		Public Function IndexOf(ByVal value As WrappedInt) As Integer
			Throw New NotSupportedException()
		End Function

		Public Sub CopyTo(ByVal array As WrappedInt(), ByVal index As Integer)
			Dim count As Integer = Me.Count
			For n As Integer = 0 To count - 1
				array(index+n) = Me(n)
			Next n
		End Sub

		Public ReadOnly Property SyncRoot() As IntegerCollection
			Get
				Throw New NotSupportedException()
			End Get
		End Property

		Public Function GetEnumerator() As IntegerCollectionEnumerator
			Return New IntegerCollectionEnumerator(Me)
		End Function

		Public Sub Insert(ByVal index As Integer, ByVal value As WrappedInt)
			OnChanging(New ListPropertyChangedEventArgs(ListPropertyChangedType.Insert, index, value, Nothing))
			inner.Insert(index, value)
			OnChanged(New ListPropertyChangedEventArgs(ListPropertyChangedType.Insert, index, value, Nothing))
		End Sub

		Public Sub Remove(ByVal value As WrappedInt)
			Dim index As Integer = IndexOf(value)
			OnChanging(New ListPropertyChangedEventArgs(ListPropertyChangedType.Remove, index, value, Nothing))
			inner.Remove(value)
			OnChanged(New ListPropertyChangedEventArgs(ListPropertyChangedType.Remove, index, value, Nothing))
		End Sub

		Public Function Add(ByVal value As WrappedInt) As Integer
			OnChanging(New ListPropertyChangedEventArgs(ListPropertyChangedType.Add, -1, value, Nothing))
			Dim index As Integer = inner.Add(value)
			OnChanged(New ListPropertyChangedEventArgs(ListPropertyChangedType.Add, index, value, Nothing))
			Return index
		End Function

		Public Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
			Dim value As Object = inner(index)
			OnChanging(New ListPropertyChangedEventArgs(ListPropertyChangedType.Remove, index, value, Nothing))
			inner.RemoveAt(index)
			OnChanged(New ListPropertyChangedEventArgs(ListPropertyChangedType.Remove, index, value, Nothing))
		End Sub

		Public Sub Clear() Implements IList.Clear
			OnChanging(New ListPropertyChangedEventArgs(ListPropertyChangedType.Refresh, -1, Nothing, Nothing))
			inner.Clear()
			OnChanged(New ListPropertyChangedEventArgs(ListPropertyChangedType.Refresh, -1, Nothing, Nothing))
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

		''' <summary>
		''' Raises the <see cref="Changed"/> event.
		''' </summary>
		''' <param name="e">A <see cref="ListPropertyChangedEventArgs" /> that contains the event data.</param>
		Protected Overridable Sub OnChanged(ByVal e As ListPropertyChangedEventArgs)
			version_Renamed += 1
			If (Not Me.insideCollectionEditor) Then
				If ChangedEvent IsNot Nothing Then
					RaiseEvent Changed(Me, e)
				End If
			End If

			If ListChangedEvent IsNot Nothing Then
				Select Case e.Action
					Case ListPropertyChangedType.Add
						RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.ItemAdded, e.Index, -1))
						RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.ItemAdded, e.Index, -1))

					Case ListPropertyChangedType.Insert
						RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.ItemAdded, e.Index, -1))

					Case ListPropertyChangedType.ItemChanged
						RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.ItemChanged, e.Index, -1))

					Case ListPropertyChangedType.ItemPropertyChanged
						RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.ItemChanged, e.Index, -1))

					Case ListPropertyChangedType.Refresh
						RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, -1, -1))

					Case ListPropertyChangedType.Remove
						RaiseEvent ListChanged(Me, New ListChangedEventArgs(ListChangedType.ItemDeleted, e.Index, -1))
				End Select
			End If
		End Sub

		''' <summary>
		''' Raises the <see cref="Changed"/> event.
		''' </summary>
		''' <param name="e">A <see cref="ListPropertyChangedEventArgs" /> that contains the event data.</param>
		Protected Overridable Sub OnChanging(ByVal e As ListPropertyChangedEventArgs)
			If (Not Me.insideCollectionEditor) Then
				If ChangingEvent IsNot Nothing Then
					RaiseEvent Changing(Me, e)
				End If
			End If
		End Sub

		#Region "ICloneable Private Members"
		Private Function ICloneable_Clone() As Object Implements ICloneable.Clone
			Return Clone()
		End Function
		#End Region

		#Region "IList Private Members"

		Public Property IList_Item(ByVal index As Integer) As Object Implements IList.Item
			Get
				Return Me(index)
			End Get
			Set(ByVal value As Object)
				Me(index) = CType(value, WrappedInt)
			End Set
		End Property

		Private Sub IList_Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
			Insert(index, CType(value, WrappedInt))
		End Sub

		Private Sub IList_Remove(ByVal value As Object) Implements IList.Remove
			Remove(CType(value, WrappedInt))
		End Sub

		Private Function IList_Contains(ByVal value As Object) As Boolean Implements IList.Contains
			Return Contains(CType(value, WrappedInt))
		End Function

		Private Function IList_IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
			Return IndexOf(CType(value, WrappedInt))
		End Function

		Private Function IList_Add(ByVal value As Object) As Integer Implements IList.Add
			Return Add(CType(value, WrappedInt))
		End Function

		#End Region

		#Region "ICollection Private Members"

		Private Sub ICollection_CopyTo(ByVal array As Array, ByVal index As Integer) Implements ICollection.CopyTo
			CopyTo(CType(array, WrappedInt()), index)
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

		#Region "Implementation of IBindingList"
		Private Sub AddIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements IBindingList.AddIndex

		End Sub

		Private Sub ApplySort(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection) Implements IBindingList.ApplySort

		End Sub

		Private Function Find(ByVal [property] As System.ComponentModel.PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
			Return 0
		End Function

		Private Sub RemoveSort() Implements IBindingList.RemoveSort

		End Sub

		Private Function AddNew() As Object Implements IBindingList.AddNew
			Dim n As Integer = Add(CType(0, WrappedInt))
			Return Me(n)
		End Function

		Private Sub RemoveIndex(ByVal [property] As System.ComponentModel.PropertyDescriptor) Implements IBindingList.RemoveIndex

		End Sub

		Public ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property SortProperty() As System.ComponentModel.PropertyDescriptor Implements IBindingList.SortProperty
			Get
				Return Nothing
			End Get
		End Property

		Private ReadOnly Property SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
			Get
				Return False
			End Get
		End Property

		Private ReadOnly Property IsSorted() As Boolean Implements IBindingList.IsSorted
			Get
				Return False
			End Get
		End Property

		Public ReadOnly Property AllowRemove() As Boolean Implements IBindingList.AllowRemove
			Get
				Return True
			End Get
		End Property

		Private ReadOnly Property SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
			Get
				Return False
			End Get
		End Property

		Private ReadOnly Property IBindingList_SortDirection() As System.ComponentModel.ListSortDirection Implements IBindingList.SortDirection
			Get
				Return ListSortDirection.Ascending
			End Get
		End Property

		Public Event ListChanged As System.ComponentModel.ListChangedEventHandler Implements IBindingList.ListChanged

		Public ReadOnly Property SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
			Get
				Return True
			End Get
		End Property
		#End Region

		#Region "Implementation of ITypedList"
		Public Function GetItemProperties(ByVal listAccessors As System.ComponentModel.PropertyDescriptor()) As System.ComponentModel.PropertyDescriptorCollection Implements ITypedList.GetItemProperties
			Return TypeDescriptor.GetProperties(GetType(WrappedInt))
		End Function

		Public Function GetListName(ByVal listAccessors As System.ComponentModel.PropertyDescriptor()) As String Implements ITypedList.GetListName
			Return Nothing
		End Function
		#End Region
	End Class

	Public Class IntegerCollectionEnumerator
		Implements IEnumerator
		Private _cursor As Integer = -1, _next As Integer = -1
		Private _coll As IntegerCollection

		Public Sub New(ByVal collection As IntegerCollection)
			_coll = collection
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

		Public ReadOnly Property Current() As WrappedInt
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
