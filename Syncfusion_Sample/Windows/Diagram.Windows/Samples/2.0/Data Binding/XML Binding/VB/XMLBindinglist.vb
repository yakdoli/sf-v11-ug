Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Collections

''' <summary>
''' Summary description for XMLBinding
''' </summary>
Public Class XMLBindinglist
	Private strName As String = String.Empty
	Private strID As String = String.Empty
	Private strManagerID As String = String.Empty
	Private strDesignation As String = String.Empty
	Private alSubEmployees As New ArrayList()

	Public Property EmployeeName() As String
		Get
			Return Me.strName
		End Get
		Set(ByVal value As String)
			Me.strName = value
		End Set
	End Property

	Public Property EmployeeID() As String
		Get
			Return Me.strID
		End Get
		Set(ByVal value As String)
			Me.strID = value
		End Set
	End Property

	Public Property Designation() As String
		Get
			Return Me.strDesignation
		End Get
		Set(ByVal value As String)
			Me.strDesignation = value
		End Set
	End Property


	Public Property ManagerID() As String
		Get
			Return Me.strManagerID
		End Get
		Set(ByVal value As String)
			Me.strManagerID = value
		End Set
	End Property

	Public ReadOnly Property SubEmployees() As ArrayList
		Get
			Return Me.alSubEmployees
		End Get
	End Property

	Public Sub New()
	End Sub

	Public Sub New(ByVal name As String, ByVal id As String, ByVal Designation As String)
		Me.strName = name
		Me.strID = id
		Me.Designation = Designation
	End Sub

	Public Sub New(ByVal name As String, ByVal id As String, ByVal Designation As String, ByVal managerid As String)
		Me.strName = name
		Me.strID = id
		Me.Designation = Designation
		Me.strManagerID = managerid
	End Sub
End Class