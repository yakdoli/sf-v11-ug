Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Runtime.Serialization
Imports System.Collections
Imports System.Diagnostics
Imports Syncfusion.Windows.Forms.Diagram

	''' <summary>
	''' Each employee in the organization will be represented in the diagram as a Symbol node
	''' </summary>
<Serializable> _
Public Class EmployeeSymbol_CS
	Inherits RoundRect
	'private RoundRect rect = new RoundRect(
	Private nameLbl As New Label()
	Private strEmpID As String = String.Empty
	Private strManagerID As String = String.Empty
	Private nRecSubEmployeeCount As Integer = 0
	Private m_HREF As String = String.Empty
	Private m_ALT As String = String.Empty

	Public Sub New(ByVal x As Single, ByVal y As Single, ByVal width As Single, ByVal height As Single, ByVal fCurveRadius As Single)
		MyBase.New(x, y, width, height, fCurveRadius, MeasureUnits.Pixel)
		Me.FillStyle.Color = System.Drawing.Color.FromArgb(255, 170, 170)
		Me.LineStyle.LineColor = System.Drawing.Color.Tomato
		nameLbl.FontStyle.Size = 8
		nameLbl.HorizontalAlignment = System.Drawing.StringAlignment.Center
		nameLbl.FontStyle.Family = "Arial"
		nameLbl.FontStyle.Bold = True
		Me.Labels.Add(nameLbl)
	End Sub

	Public Sub New(ByVal src As EmployeeSymbol_CS)
		MyBase.New(src)
	End Sub

	' Serialization constructor
	Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
		MyBase.New(info, context)
		Me.strManagerID = info.GetString("ManagerID")
		Me.nRecSubEmployeeCount = info.GetInt32("RecSubEmployeeCount")
	End Sub

	Protected Overrides Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext)
		MyBase.GetObjectData(info, context)

		info.AddValue("ManagerID", Me.strManagerID)
		info.AddValue("RecSubEmployeeCount", Me.nRecSubEmployeeCount)
	End Sub

	Public Property HREF() As String
		Get
			Return Me.m_HREF
		End Get
		Set(ByVal value As String)
			If m_HREF <> value Then
				m_HREF = value
				Me.Tag = m_HREF & ";" & m_ALT

			End If
		End Set
	End Property

	Public Property ALT() As String
		Get
			Return Me.m_ALT
		End Get
		Set(ByVal value As String)
			If m_ALT <> value Then
				m_ALT = value
				Me.Tag = m_HREF & ";" & m_ALT
			End If
		End Set
	End Property

	Public Property EmployeeName() As String
		Get
			Return Me.nameLbl.Text
		End Get
		Set(ByVal value As String)
			Me.nameLbl.Text = value
		End Set
	End Property

	Public Property EmployeeID() As String
		Get
			Return strEmpID
		End Get
		Set(ByVal value As String)
			strEmpID = value
		End Set
	End Property

	Public Property ManagerID() As String
		Get
			Return Me.strManagerID
		End Get
		Set(ByVal value As String)
			If Me.strManagerID <> value Then
				Me.strManagerID = value
			End If
		End Set
	End Property

	Public ReadOnly Property Rank() As Integer
		Get
'INSTANT VB NOTE: The local variable rank was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
			Dim rank_Renamed As Integer = 1

			Dim thisNode As IGraphNode = TryCast(Me, IGraphNode)
			Dim curNode As IGraphNode = thisNode
			Dim cyclicalPathFound As Boolean = False

			Do While curNode IsNot Nothing AndAlso Not cyclicalPathFound
				Dim edgesEntering As ICollection = curNode.EdgesEntering
				If edgesEntering.Count > 0 Then
					Dim enumEdgesEntering As IEnumerator = edgesEntering.GetEnumerator()
					If enumEdgesEntering IsNot Nothing Then
						enumEdgesEntering.MoveNext()
						Dim incomingEdge As IGraphEdge = TryCast(enumEdgesEntering.Current, IGraphEdge)
						If incomingEdge IsNot Nothing Then
							curNode = incomingEdge.FromNode

							If curNode Is thisNode Then
								cyclicalPathFound = True
							Else
								rank_Renamed += 1
							End If
						End If
					End If
				Else
					curNode = Nothing
				End If
			Loop

			Return rank_Renamed
		End Get
	End Property

	Public ReadOnly Property Manager() As EmployeeSymbol_CS
		Get
'INSTANT VB NOTE: The local variable manager was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
			Dim manager_Renamed As EmployeeSymbol_CS = Nothing
			Dim thisNode As IGraphNode = TryCast(Me, IGraphNode)
			Dim fromNode As IGraphNode

			If thisNode IsNot Nothing Then
				Dim edgesEntering As ICollection = thisNode.EdgesEntering
				If edgesEntering.Count > 0 Then
					Dim enumEdgesEntering As IEnumerator = edgesEntering.GetEnumerator()
					If enumEdgesEntering IsNot Nothing Then
						enumEdgesEntering.MoveNext()
						Dim incomingEdge As IGraphEdge = TryCast(enumEdgesEntering.Current, IGraphEdge)
						If incomingEdge IsNot Nothing Then
							fromNode = incomingEdge.FromNode
							If fromNode IsNot Nothing Then
								manager_Renamed = TryCast(fromNode, EmployeeSymbol_CS)
							End If
						End If
					End If
				End If
			End If

			Return manager_Renamed
		End Get
	End Property

	Public ReadOnly Property Employees() As ICollection
		Get
'INSTANT VB NOTE: The local variable employees was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
			Dim employees_Renamed As New ArrayList()
			Dim thisNode As IGraphNode = TryCast(Me, IGraphNode)
			If thisNode IsNot Nothing Then
				Dim edgesLeaving As ICollection = thisNode.EdgesLeaving
				If edgesLeaving IsNot Nothing Then
					For Each curEdge As IGraphEdge In edgesLeaving
						Dim curEmployee As EmployeeSymbol_CS = TryCast(curEdge.ToNode, EmployeeSymbol_CS)
						If curEmployee IsNot Nothing Then
							employees_Renamed.Add(curEmployee)
						End If
					Next curEdge
				End If
			End If

			Return employees_Renamed
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
End Class
