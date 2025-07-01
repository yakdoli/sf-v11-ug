Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web

''' <summary>
''' Summary description for HoshinKanriListItem
''' </summary>
Public Class HoshinKanriListItem

'INSTANT VB NOTE: The variable content was renamed since Visual Basic does not allow class members with the same name:
	Private content_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable content1 was renamed since Visual Basic does not allow class members with the same name:
	Private content1_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable subContent was renamed since Visual Basic does not allow class members with the same name:
	Private subContent_Renamed As New List(Of String)()
'INSTANT VB NOTE: The variable plan was renamed since Visual Basic does not allow class members with the same name:
	Private plan_Renamed As New List(Of String())()
'INSTANT VB NOTE: The variable actual was renamed since Visual Basic does not allow class members with the same name:
	Private actual_Renamed As New List(Of String())()
'INSTANT VB NOTE: The variable leader was renamed since Visual Basic does not allow class members with the same name:
	Private leader_Renamed As New List(Of String)()
'INSTANT VB NOTE: The variable resources was renamed since Visual Basic does not allow class members with the same name:
	Private resources_Renamed As New List(Of String)()
'INSTANT VB NOTE: The variable comments was renamed since Visual Basic does not allow class members with the same name:
	Private comments_Renamed As New List(Of String)()
'INSTANT VB NOTE: The variable costSavings was renamed since Visual Basic does not allow class members with the same name:
	Private costSavings_Renamed As New List(Of String)()
'INSTANT VB NOTE: The variable toolTip was renamed since Visual Basic does not allow class members with the same name:
	Private toolTip_Renamed As New List(Of String)()
'INSTANT VB NOTE: The variable isOuterRectangle was renamed since Visual Basic does not allow class members with the same name:
	Public isOuterRectangle_Renamed As New List(Of Boolean)()

	Public Property Content() As String
		Get
			Return content_Renamed
		End Get
		Set(ByVal value As String)
			content_Renamed = value
		End Set
	End Property
	Public Property Content1() As String
		Get
			Return content1_Renamed
		End Get
		Set(ByVal value As String)
			content1_Renamed = value
		End Set
	End Property
	Public Property SubContent() As List(Of String)
		Get
			Return subContent_Renamed
		End Get
		Set(ByVal value As List(Of String))
			subContent_Renamed = value
		End Set
	End Property
	Public Property Plan() As List(Of String())
		Get
			Return plan_Renamed
		End Get
		Set(ByVal value As List(Of String()))
			plan_Renamed = value
		End Set
	End Property
	Public Property Actual() As List(Of String())
		Get
			Return actual_Renamed
		End Get
		Set(ByVal value As List(Of String()))
			actual_Renamed = value
		End Set
	End Property
	Public Property Leader() As List(Of String)
		Get
			Return leader_Renamed
		End Get
		Set(ByVal value As List(Of String))
			leader_Renamed = value
		End Set
	End Property
	Public Property Resources() As List(Of String)
		Get
			Return resources_Renamed
		End Get
		Set(ByVal value As List(Of String))
			resources_Renamed = value
		End Set
	End Property
	Public Property Comments() As List(Of String)
		Get
			Return comments_Renamed
		End Get
		Set(ByVal value As List(Of String))
			comments_Renamed = value
		End Set
	End Property
	Public Property CostSavings() As List(Of String)
		Get
			Return costSavings_Renamed
		End Get
		Set(ByVal value As List(Of String))
			costSavings_Renamed = value
		End Set
	End Property
	Public Property ToolTip() As List(Of String)
		Get
			Return toolTip_Renamed
		End Get
		Set(ByVal value As List(Of String))
			toolTip_Renamed = value
		End Set
	End Property
	Public Property IsOuterRectangle() As List(Of Boolean)
		Get
			Return isOuterRectangle_Renamed
		End Get
		Set(ByVal value As List(Of Boolean))
			isOuterRectangle_Renamed = value
		End Set
	End Property
End Class