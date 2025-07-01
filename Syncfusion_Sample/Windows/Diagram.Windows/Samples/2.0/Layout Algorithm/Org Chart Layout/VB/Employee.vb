Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
'
'  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Collections


''' <summary>
''' The Employee class represents an employee in the orgranization structure. This class is used only for 
''' extracting the oganization structure data and creating the diagram symbol nodes
''' </summary>
Public Class Employee_CS
	Private strName As String = String.Empty
	Private strID As String = String.Empty
	Private strManagerID As String = String.Empty
	Private strDesignation As String = String.Empty
	Private strGender As String = String.Empty
	Private alSubEmployees As New ArrayList()
	Private nRecSubEmployeeCount As Integer = 0
	Private strImageName As String = String.Empty
	Private strDOJ As String = String.Empty


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

	Public Property Gender() As String
		Get
			Return Me.strGender
		End Get
		Set(ByVal value As String)
			Me.strGender = value
		End Set
	End Property

	Public Property DOJ() As String
		Get
			Return Me.strDOJ
		End Get
		Set(ByVal value As String)
			Me.strDOJ = value
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

	Public Property ImageName() As String
		Get
			Return Me.strImageName
		End Get
		Set(ByVal value As String)
			Me.strImageName = value
		End Set
	End Property

	Public ReadOnly Property SubEmployees() As ArrayList
		Get
			Return Me.alSubEmployees
		End Get
	End Property

	Public Property RecSubEmployeeCount() As Integer
		Get
			Return Me.nRecSubEmployeeCount
		End Get
		Set(ByVal value As Integer)
			Me.nRecSubEmployeeCount = value
		End Set
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
