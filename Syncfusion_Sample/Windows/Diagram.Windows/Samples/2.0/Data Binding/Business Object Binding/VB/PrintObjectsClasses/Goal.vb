Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web

Namespace TestTreeApp
	<Serializable> _
	Public Class Goal
		Private m_desc As String
		Private m_obj As List(Of Objective)
		Public Property Description() As String
			Get
				Return m_desc
			End Get
			Set(ByVal value As String)
				m_desc = value
			End Set
		End Property
		Public Property Objectives() As List(Of Objective)
			Get
				Return m_obj
			End Get
			Set(ByVal value As List(Of Objective))
				m_obj = value
			End Set
		End Property
	End Class
End Namespace