Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web

Namespace TestTreeApp
	<Serializable> _
	Public Class Objective
		Private m_desc As String
		Private m_key As List(Of KeyTask)
		Public Property Description() As String
			Get
				Return m_desc
			End Get
			Set(ByVal value As String)
				m_desc = value
			End Set
		End Property
		Public Property KeyTasks() As List(Of KeyTask)
			Get
				Return m_key
			End Get
			Set(ByVal value As List(Of KeyTask))
				m_key = value
			End Set
		End Property
	End Class
End Namespace