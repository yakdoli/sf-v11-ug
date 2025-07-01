Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Web


	<Serializable> _
	Public Class KeyTask
		Private m_desc As String
		Private m_leadr As String
		Private m_cst As Decimal
		Public Property Description() As String
			Get
				Return m_desc
			End Get
			Set(ByVal value As String)
				m_desc = value
			End Set
		End Property
		Public Property Leader() As String
			Get
				Return m_leadr
			End Get
			Set(ByVal value As String)
				m_leadr = value
			End Set
		End Property
		Public Property CostSavings() As Decimal
			Get
				Return m_cst
			End Get
			Set(ByVal value As Decimal)
				m_cst = value
			End Set
		End Property

	End Class
