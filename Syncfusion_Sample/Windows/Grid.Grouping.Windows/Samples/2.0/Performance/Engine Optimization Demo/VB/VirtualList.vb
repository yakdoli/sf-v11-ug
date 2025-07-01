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
Imports System.Collections
Imports System.ComponentModel

Namespace TestEngineOptimizations
	''' <summary>
	''' Summary description for VirtualList.
	''' </summary>
	Public Class VirtualList : Implements IList, ITypedList
		Private virtualCount As Integer

'INSTANT VB NOTE: The parameter count was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal count_Renamed As Integer)
			virtualCount = count_Renamed
		End Sub

		#Region "IList Members"

		Public ReadOnly Property IsReadOnly() As Boolean Implements IList.IsReadOnly
			Get
				Return True
			End Get
		End Property

        Default Public Property Item(ByVal index As Integer) As Object Implements IList.Item
            Get
                Dim item1 As VirtualItem = New VirtualItem()
                item1.Index = index
                item1.Name = "Name" & index.ToString("000000000")
                item1.SomeValue = index * 0.873332F
                item1.OtherValue = (293023033 - index) / 8

                Return item1
            End Get
            Set(ByVal value As Object)
            End Set
        End Property

		Public Sub RemoveAt(ByVal index As Integer) Implements IList.RemoveAt
		End Sub

		Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IList.Insert
		End Sub

		Public Sub Remove(ByVal value As Object) Implements IList.Remove
		End Sub

		Public Function Contains(ByVal value As Object) As Boolean Implements IList.Contains
			Return False
		End Function

		Public Sub Clear() Implements IList.Clear
		End Sub

		Public Function IndexOf(ByVal value As Object) As Integer Implements IList.IndexOf
			Return 0
		End Function

		Public Function Add(ByVal value As Object) As Integer Implements IList.Add
			Return 0
		End Function

		Public ReadOnly Property IsFixedSize() As Boolean Implements IList.IsFixedSize
			Get
				Return True
			End Get
		End Property

		#End Region

		#Region "ICollection Members"

        Public ReadOnly Property IsSynchronized() As Boolean Implements IList.IsSynchronized
            Get
                Return False
            End Get
        End Property

        Public ReadOnly Property Count() As Integer Implements IList.Count
            Get
                Return virtualCount
            End Get
        End Property

        Public Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements IList.CopyTo
        End Sub

        Public ReadOnly Property SyncRoot() As Object Implements IList.SyncRoot
            Get
                Return Nothing
            End Get
        End Property

		#End Region

		#Region "IEnumerable Members"

        Public Function GetEnumerator() As IEnumerator Implements IList.GetEnumerator
            Return Nothing
        End Function

		#End Region

		#Region "ITypedList Members"

		Public Function GetItemProperties(ByVal listAccessors As PropertyDescriptor()) As PropertyDescriptorCollection Implements ITypedList.GetItemProperties
			Dim pds As System.ComponentModel.PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(VirtualItem))

            Dim atts As String() = New String() {"Index", "Name", "SomeValue", "OtherValue"}

			Return pds.Sort(atts)
		End Function

		Public Function GetListName(ByVal listAccessors As PropertyDescriptor()) As String Implements ITypedList.GetListName
			Return "VirtualList"
		End Function

		#End Region
	End Class

	<TypeConverter(GetType(VirtualItemConverter))> _
	Public Class VirtualItem
		Private index_Renamed As Integer
		Private name_Renamed As String
		Private someValue_Renamed As Double
		Private otherValue_Renamed As Double

		Public Property Index() As Integer
			Get
				Return index_Renamed
			End Get
			Set
				index_Renamed = Value
			End Set
		End Property
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set
				name_Renamed = Value
			End Set
		End Property
		Public Property SomeValue() As Double
			Get
				Return someValue_Renamed
			End Get
			Set
				someValue_Renamed = Value
			End Set
		End Property
		Public Property OtherValue() As Double
			Get
				Return otherValue_Renamed
			End Get
			Set
				otherValue_Renamed = Value
			End Set
		End Property

	End Class

	Public Class VirtualItemConverter : Inherits TypeConverter
		Public Overrides Overloads Function GetProperties(ByVal context As ITypeDescriptorContext, ByVal value As Object, ByVal attributes As Attribute()) As PropertyDescriptorCollection
			Dim pds As System.ComponentModel.PropertyDescriptorCollection = TypeDescriptor.GetProperties(value.GetType(), attributes)

            Dim atts As String() = New String() {"Index", "Name", "SomeValue", "OtherValue"}

			Return pds.Sort(atts)
		End Function

	End Class
End Namespace
