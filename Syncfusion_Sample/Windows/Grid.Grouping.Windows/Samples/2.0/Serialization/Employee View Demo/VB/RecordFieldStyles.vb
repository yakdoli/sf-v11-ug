Imports Microsoft.VisualBasic
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

Imports Syncfusion.Windows.Forms.Grid

Namespace EmployeeView
	<TypeConverter(GetType(System.ComponentModel.ExpandableObjectConverter))> _
	Public Class FieldStyle
'INSTANT VB NOTE: The variable fieldName was renamed since Visual Basic does not allow class members with the same name:
		Private fieldName_Renamed As String
'INSTANT VB NOTE: The variable style was renamed since Visual Basic does not allow class members with the same name:
		Private style_Renamed As New GridStyleInfo()

		Public Property FieldName() As String
			Get
				Return fieldName_Renamed
			End Get
			Set(ByVal value As String)
				fieldName_Renamed = value
			End Set
		End Property

		<DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)> _
		Public Property Style() As GridStyleInfo
			Get
				Return style_Renamed
			End Get
			Set(ByVal value As GridStyleInfo)
				style_Renamed = value
			End Set
		End Property
	End Class

	<TypeConverter(GetType(System.ComponentModel.ExpandableObjectConverter))> _
	Public Class RecordFieldStyles
'INSTANT VB NOTE: The variable recordKey was renamed since Visual Basic does not allow class members with the same name:
		Private recordKey_Renamed As String
'INSTANT VB NOTE: The variable fieldStyles was renamed since Visual Basic does not allow class members with the same name:
		Private fieldStyles_Renamed As New FieldStyleCollection()

		Public Property RecordKey() As String
			Get
				Return recordKey_Renamed
			End Get
			Set(ByVal value As String)
				recordKey_Renamed = value
			End Set
		End Property


		<DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)> _
		Public Property FieldStyles() As FieldStyleCollection
			Get
				Return fieldStyles_Renamed
			End Get
			Set(ByVal value As FieldStyleCollection)
				fieldStyles_Renamed = value
			End Set
		End Property
	End Class

	<TypeConverter(GetType(System.ComponentModel.ExpandableObjectConverter))> _
	Public Class TableRecordFieldStyles
'INSTANT VB NOTE: The variable tableName was renamed since Visual Basic does not allow class members with the same name:
		Private tableName_Renamed As String
'INSTANT VB NOTE: The variable recordFieldStyles was renamed since Visual Basic does not allow class members with the same name:
		Private recordFieldStyles_Renamed As New RecordFieldStylesCollection()

		Public Property TableName() As String
			Get
				Return tableName_Renamed
			End Get
			Set(ByVal value As String)
				tableName_Renamed = value
			End Set
		End Property

		<DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)> _
		Public Property RecordFieldStyles() As RecordFieldStylesCollection
			Get
				Return recordFieldStyles_Renamed
			End Get
			Set(ByVal value As RecordFieldStylesCollection)
				recordFieldStyles_Renamed = value
			End Set
		End Property

	End Class


	#region "'FieldStyleCollection' strongly typed collection class"

	<EditorAttribute(GetType(System.ComponentModel.Design.CollectionEditor), GetType(System.Drawing.Design.UITypeEditor))> _
	Public Class FieldStyleCollection
		Inherits System.Collections.CollectionBase

		Public Sub New()
		End Sub

		Public Sub New(ByVal fieValue As FieldStyleCollection)
			Me.AddRange(fieValue)
		End Sub

		Public Sub New(ByVal fieValue() As FieldStyle)
			Me.AddRange(fieValue)
		End Sub

		Default Public Property Item(ByVal intIndex As Integer) As FieldStyle
			Get
				Return (CType(List(intIndex), FieldStyle))
			End Get
			Set(ByVal value As FieldStyle)
				List(intIndex) = value
			End Set
		End Property

		Public Function GetStyleByFieldName(ByVal fieldName As String) As GridStyleInfo
			' Could optize using a sorted list that gets build up in this method and set dirty/cleared
			' whenever OnSet, OnInsert, OnRemove etc. is called

			For n As Integer = 0 To Count - 1
				If Me(n).FieldName = fieldName Then
					Return Me(n).Style
				End If
			Next n
			Return Nothing
		End Function

		Public Function GetObject(ByVal fieldName As String) As GridStyleInfo
			Dim value As GridStyleInfo = GetStyleByFieldName(fieldName)
			If value Is Nothing Then
				Dim obj As New FieldStyle()
				obj.FieldName = fieldName
				value = obj.Style
				Add(obj)
			End If

			Return value
		End Function

		Public Function Add(ByVal fieValue As FieldStyle) As Integer
			Return List.Add(fieValue)
		End Function

		Public Sub AddRange(ByVal fieValue() As FieldStyle)
			Dim intCounter As Integer = 0
			Do While (intCounter < fieValue.Length)
				Me.Add(fieValue(intCounter))
				intCounter = (intCounter + 1)
			Loop
		End Sub

		Public Sub AddRange(ByVal fieValue As FieldStyleCollection)
			Dim intCounter As Integer = 0
			Do While (intCounter < fieValue.Count)
				Me.Add(fieValue(intCounter))
				intCounter = (intCounter + 1)
			Loop
		End Sub

		Public Function Contains(ByVal fieValue As FieldStyle) As Boolean
			Return List.Contains(fieValue)
		End Function

		Public Sub CopyTo(ByVal fieArray() As FieldStyle, ByVal intIndex As Integer)
			List.CopyTo(fieArray, intIndex)
		End Sub

		Public Function IndexOf(ByVal fieValue As FieldStyle) As Integer
			Return List.IndexOf(fieValue)
		End Function

		Public Sub Insert(ByVal intIndex As Integer, ByVal fieValue As FieldStyle)
			List.Insert(intIndex, fieValue)
		End Sub

		Public Shadows Function GetEnumerator() As FieldStyleEnumerator
			Return New FieldStyleEnumerator(Me)
		End Function

		Public Sub Remove(ByVal fieValue As FieldStyle)
			List.Remove(fieValue)
		End Sub

		Public Class FieldStyleEnumerator
			Inherits Object
			Implements System.Collections.IEnumerator

			Private iEnBase As System.Collections.IEnumerator

			Private iEnLocal As System.Collections.IEnumerable

			Public Sub New(ByVal fieMappings As FieldStyleCollection)
				Me.iEnLocal = (CType(fieMappings, System.Collections.IEnumerable))
				Me.iEnBase = iEnLocal.GetEnumerator()
			End Sub

			Public ReadOnly Property Current() As FieldStyle
				Get
					Return (CType(iEnBase.Current, FieldStyle))
				End Get
			End Property

			Private ReadOnly Property IEnumerator_Current() As Object Implements System.Collections.IEnumerator.Current
				Get
					Return iEnBase.Current
				End Get
			End Property

			Public Function MoveNext() As Boolean
				Return iEnBase.MoveNext()
			End Function

			Private Function IEnumerator_MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
				Return iEnBase.MoveNext()
			End Function

			Public Sub Reset()
				iEnBase.Reset()
			End Sub

			Private Sub IEnumerator_Reset() Implements System.Collections.IEnumerator.Reset
				iEnBase.Reset()
			End Sub
		End Class
	End Class

	#End Region '('FieldStyleCollection' strongly typed collection class)

	#region "'RecordFieldStylesCollection' strongly typed collection class"


	<EditorAttribute(GetType(System.ComponentModel.Design.CollectionEditor), GetType(System.Drawing.Design.UITypeEditor))> _
	Public Class RecordFieldStylesCollection
		Inherits System.Collections.CollectionBase

		Public Sub New()
		End Sub

		Public Sub New(ByVal recValue As RecordFieldStylesCollection)
			Me.AddRange(recValue)
		End Sub

		Public Sub New(ByVal recValue() As RecordFieldStyles)
			Me.AddRange(recValue)
		End Sub

		Default Public Property Item(ByVal intIndex As Integer) As RecordFieldStyles
			Get
				Return (CType(List(intIndex), RecordFieldStyles))
			End Get
			Set(ByVal value As RecordFieldStyles)
				List(intIndex) = value
			End Set
		End Property

		Public Function GetFieldStylesByRecordKey(ByVal recordKey As Object) As FieldStyleCollection
			Dim s As String = recordKey.ToString()

			' Could optize using a sorted list that gets build up in this method and set dirty/cleared
			' whenever OnSet, OnInsert, OnRemove etc. is called

			For n As Integer = 0 To Count - 1
				If Me(n).RecordKey.Equals(s) Then
					Return Me(n).FieldStyles
				End If
			Next n
			Return Nothing
		End Function

		Public Function GetObject(ByVal recordKey As Object) As FieldStyleCollection
			Dim value As FieldStyleCollection = GetFieldStylesByRecordKey(recordKey)
			If value Is Nothing Then
				Dim obj As New RecordFieldStyles()
				obj.RecordKey = recordKey.ToString()
				value = obj.FieldStyles
				Add(obj)
			End If

			Return value
		End Function


		Public Function Add(ByVal recValue As RecordFieldStyles) As Integer
			Return List.Add(recValue)
		End Function

		Public Sub AddRange(ByVal recValue() As RecordFieldStyles)
			Dim intCounter As Integer = 0
			Do While (intCounter < recValue.Length)
				Me.Add(recValue(intCounter))
				intCounter = (intCounter + 1)
			Loop
		End Sub

		Public Sub AddRange(ByVal recValue As RecordFieldStylesCollection)
			Dim intCounter As Integer = 0
			Do While (intCounter < recValue.Count)
				Me.Add(recValue(intCounter))
				intCounter = (intCounter + 1)
			Loop
		End Sub

		Public Function Contains(ByVal recValue As RecordFieldStyles) As Boolean
			Return List.Contains(recValue)
		End Function

		Public Sub CopyTo(ByVal recArray() As RecordFieldStyles, ByVal intIndex As Integer)
			List.CopyTo(recArray, intIndex)
		End Sub

		Public Function IndexOf(ByVal recValue As RecordFieldStyles) As Integer
			Return List.IndexOf(recValue)
		End Function

		Public Sub Insert(ByVal intIndex As Integer, ByVal recValue As RecordFieldStyles)
			List.Insert(intIndex, recValue)
		End Sub

		Public Shadows Function GetEnumerator() As RecordFieldStylesEnumerator
			Return New RecordFieldStylesEnumerator(Me)
		End Function

		Public Sub Remove(ByVal recValue As RecordFieldStyles)
			List.Remove(recValue)
		End Sub

		Public Class RecordFieldStylesEnumerator
			Inherits Object
			Implements System.Collections.IEnumerator

			Private iEnBase As System.Collections.IEnumerator

			Private iEnLocal As System.Collections.IEnumerable

			Public Sub New(ByVal recMappings As RecordFieldStylesCollection)
				Me.iEnLocal = (CType(recMappings, System.Collections.IEnumerable))
				Me.iEnBase = iEnLocal.GetEnumerator()
			End Sub

			Public ReadOnly Property Current() As RecordFieldStyles
				Get
					Return (CType(iEnBase.Current, RecordFieldStyles))
				End Get
			End Property

			Private ReadOnly Property IEnumerator_Current() As Object Implements System.Collections.IEnumerator.Current
				Get
					Return iEnBase.Current
				End Get
			End Property

			Public Function MoveNext() As Boolean
				Return iEnBase.MoveNext()
			End Function

			Private Function IEnumerator_MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
				Return iEnBase.MoveNext()
			End Function

			Public Sub Reset()
				iEnBase.Reset()
			End Sub

			Private Sub IEnumerator_Reset() Implements System.Collections.IEnumerator.Reset
				iEnBase.Reset()
			End Sub
		End Class
	End Class

	#End Region '('RecordFieldStylesCollection' strongly typed collection class)

	#region "'TableRecordFieldStylesCollection' strongly typed collection class"

	<EditorAttribute(GetType(System.ComponentModel.Design.CollectionEditor), GetType(System.Drawing.Design.UITypeEditor))> _
	Public Class TableRecordFieldStylesCollection
		Inherits System.Collections.CollectionBase

		Public Sub New()
		End Sub

		Public Sub New(ByVal tabValue As TableRecordFieldStylesCollection)
			Me.AddRange(tabValue)
		End Sub

		Public Sub New(ByVal tabValue() As TableRecordFieldStyles)
			Me.AddRange(tabValue)
		End Sub

		Default Public Property Item(ByVal intIndex As Integer) As TableRecordFieldStyles
			Get
				Return (CType(List(intIndex), TableRecordFieldStyles))
			End Get
			Set(ByVal value As TableRecordFieldStyles)
				List(intIndex) = value
			End Set
		End Property

		Public Function GetRecordFieldStylesByTableName(ByVal tableName As String) As RecordFieldStylesCollection
			' Could optize using a sorted list that gets build up in this method and set dirty/cleared
			' whenever OnSet, OnInsert, OnRemove etc. is called

			For n As Integer = 0 To Count - 1
				If Me(n).TableName = tableName Then
					Return Me(n).RecordFieldStyles
				End If
			Next n

			Return Nothing
		End Function

		Public Function GetObject(ByVal tableName As String) As RecordFieldStylesCollection
			Dim value As RecordFieldStylesCollection = GetRecordFieldStylesByTableName(tableName)
			If value Is Nothing Then
				Dim obj As New TableRecordFieldStyles()
				obj.TableName = tableName
				value = obj.RecordFieldStyles
				Add(obj)
			End If

			Return value
		End Function

		Public Function Add(ByVal tabValue As TableRecordFieldStyles) As Integer
			Return List.Add(tabValue)
		End Function

		Public Sub AddRange(ByVal tabValue() As TableRecordFieldStyles)
			Dim intCounter As Integer = 0
			Do While (intCounter < tabValue.Length)
				Me.Add(tabValue(intCounter))
				intCounter = (intCounter + 1)
			Loop
		End Sub

		Public Sub AddRange(ByVal tabValue As TableRecordFieldStylesCollection)
			Dim intCounter As Integer = 0
			Do While (intCounter < tabValue.Count)
				Me.Add(tabValue(intCounter))
				intCounter = (intCounter + 1)
			Loop
		End Sub

		Public Function Contains(ByVal tabValue As TableRecordFieldStyles) As Boolean
			Return List.Contains(tabValue)
		End Function

		Public Sub CopyTo(ByVal tabArray() As TableRecordFieldStyles, ByVal intIndex As Integer)
			List.CopyTo(tabArray, intIndex)
		End Sub

		Public Function IndexOf(ByVal tabValue As TableRecordFieldStyles) As Integer
			Return List.IndexOf(tabValue)
		End Function

		Public Sub Insert(ByVal intIndex As Integer, ByVal tabValue As TableRecordFieldStyles)
			List.Insert(intIndex, tabValue)
		End Sub

		Public Shadows Function GetEnumerator() As TableRecordFieldStylesEnumerator
			Return New TableRecordFieldStylesEnumerator(Me)
		End Function

		Public Sub Remove(ByVal tabValue As TableRecordFieldStyles)
			List.Remove(tabValue)
		End Sub

		Public Class TableRecordFieldStylesEnumerator
			Inherits Object
			Implements System.Collections.IEnumerator

			Private iEnBase As System.Collections.IEnumerator

			Private iEnLocal As System.Collections.IEnumerable

			Public Sub New(ByVal tabMappings As TableRecordFieldStylesCollection)
				Me.iEnLocal = (CType(tabMappings, System.Collections.IEnumerable))
				Me.iEnBase = iEnLocal.GetEnumerator()
			End Sub

			Public ReadOnly Property Current() As TableRecordFieldStyles
				Get
					Return (CType(iEnBase.Current, TableRecordFieldStyles))
				End Get
			End Property

			Private ReadOnly Property IEnumerator_Current() As Object Implements System.Collections.IEnumerator.Current
				Get
					Return iEnBase.Current
				End Get
			End Property

			Public Function MoveNext() As Boolean
				Return iEnBase.MoveNext()
			End Function

			Private Function IEnumerator_MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
				Return iEnBase.MoveNext()
			End Function

			Public Sub Reset()
				iEnBase.Reset()
			End Sub

			Private Sub IEnumerator_Reset() Implements System.Collections.IEnumerator.Reset
				iEnBase.Reset()
			End Sub
		End Class
	End Class


	#End Region '('TableRecordFieldStylesCollection' strongly typed collection class)

End Namespace
