Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web

Namespace TestTreeApp
	<Serializable> _
	Public Class Vision
		Private m_desc As String
		Private m_goal As List(Of Goal)
		Private m_yr As Integer
		Public Property Description() As String
			Get
				Return m_desc
			End Get
			Set(ByVal value As String)
				m_desc = value
			End Set
		End Property
		Public Property FiscalYear() As Integer
			Get
				Return m_yr
			End Get
			Set(ByVal value As Integer)
				m_yr = value
			End Set
		End Property
		Public Property Goals() As List(Of Goal)
			Get
				Return m_goal
			End Get
			Set(ByVal value As List(Of Goal))
				m_goal = value
			End Set
		End Property
	End Class
End Namespace