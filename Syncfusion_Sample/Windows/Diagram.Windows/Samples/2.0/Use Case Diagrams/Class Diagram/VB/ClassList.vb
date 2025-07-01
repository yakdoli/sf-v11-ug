Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web

''' <summary>
''' Summary description for ClassList
''' </summary>

<Serializable> _
Public Class ClassList
	#Region "class members"
'INSTANT VB NOTE: The variable className was renamed since Visual Basic does not allow class members with the same name:
	Private className_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable classType was renamed since Visual Basic does not allow class members with the same name:
	Private classType_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable objectType was renamed since Visual Basic does not allow class members with the same name:
	Private objectType_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable propertyList was renamed since Visual Basic does not allow class members with the same name:
	Private propertyList_Renamed As New List(Of PropertyList)()
'INSTANT VB NOTE: The variable methodList was renamed since Visual Basic does not allow class members with the same name:
	Private methodList_Renamed As New List(Of MethodList)()
	#End Region

	#Region "ClassProperties"
	Public Property ClassName() As String
		Get
			Return className_Renamed
		End Get
		Set(ByVal value As String)
			className_Renamed = value
		End Set
	End Property
	Public Property ClassType() As String
		Get
			Return classType_Renamed
		End Get
		Set(ByVal value As String)
			classType_Renamed = value
		End Set
	End Property
	Public Property ObjectType() As String
		Get
			Return objectType_Renamed
		End Get
		Set(ByVal value As String)
			objectType_Renamed = value
		End Set
	End Property


	Public Property PropertyList() As List(Of PropertyList)
		Get
			Return propertyList_Renamed
		End Get
		Set(ByVal value As List(Of PropertyList))
			propertyList_Renamed = value
		End Set
	End Property

	Public Property MethodList() As List(Of MethodList)
		Get
			Return methodList_Renamed
		End Get
		Set(ByVal value As List(Of MethodList))
			methodList_Renamed = value
		End Set
	End Property

	#End Region
End Class

Public Class PropertyList
'INSTANT VB NOTE: The variable propertyName was renamed since Visual Basic does not allow class members with the same name:
	Private propertyName_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable propertyType was renamed since Visual Basic does not allow class members with the same name:
	Private propertyType_Renamed As PropertyType = PropertyType.Internal
	Public Property PropertyName() As String
		Get
			Return propertyName_Renamed
		End Get
		Set(ByVal value As String)
			propertyName_Renamed = value
		End Set
	End Property

	Public Property PropertyType() As PropertyType
		Get
			Return propertyType_Renamed
		End Get
		Set(ByVal value As PropertyType)
			propertyType_Renamed = value
		End Set
	End Property
End Class

Public Enum PropertyType
	Internal
	[Public]
	[Protected]
	[Private]
End Enum

Public Enum MethodType
	Internal
	[Protected]
	[Public]
	[Private]

End Enum

Public Class MethodList
'INSTANT VB NOTE: The variable methodName was renamed since Visual Basic does not allow class members with the same name:
	Private methodName_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable methodType was renamed since Visual Basic does not allow class members with the same name:
	Private methodType_Renamed As MethodType = MethodType.Internal

	Public Property MethodName() As String
		Get
			Return methodName_Renamed
		End Get
		Set(ByVal value As String)
			methodName_Renamed = value
		End Set
	End Property

	Public Property MethodType() As MethodType
		Get
			Return methodType_Renamed
		End Get
		Set(ByVal value As MethodType)
			methodType_Renamed = value
		End Set
	End Property
End Class

