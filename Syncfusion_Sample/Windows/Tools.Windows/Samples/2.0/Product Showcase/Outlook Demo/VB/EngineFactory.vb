Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Namespace OutlookDemo
	#Region "GroupingEngineFactory"

	''' <summary>
	''' GroupingEngineFactory provides a trimmed down GridGroup
	''' which eliminates overhead of not needed preview rows, header and footer cells.
	''' </summary>
	Public Class GroupingEngineFactory : Inherits GridEngineFactoryBase
		Public Overrides Function CreateEngine() As GridEngine
			Return New GroupingEngine()
		End Function
	End Class

	Public Class GroupingEngine : Inherits GridEngine
		Public Overrides Function CreateChildTable(ByVal parent As Element) As ChildTable
			Return New GroupingChildTable(parent)
		End Function
	End Class

	Public Class ExtraSection : Inherits EmptySection
		Public Sub New(ByVal parent As Group)
			MyBase.New(parent)
		End Sub

		Public Overrides ReadOnly Property Kind() As DisplayElementKind
			Get
				Return DisplayElementKind.None
			End Get
		End Property

		Public Overrides Function GetElementCount() As Integer
			Return 1
		End Function

		Public Overrides Function GetVisibleCount() As Integer
			Return 1
		End Function

		Public Overrides Function GetYAmountCount() As Double
			Return 20
		End Function
	End Class

	Public Class GroupingChildTable : Inherits GridChildTable
		Public Sub New(ByVal parent As Element)
			MyBase.New(parent)
		End Sub

		Private Shared sectionRequired_Renamed As Boolean = True
		Public Shared Property SectionRequired() As Boolean
			Get
				Return sectionRequired_Renamed
			End Get
			Set
				sectionRequired_Renamed = Value
			End Set
		End Property

		Protected Overrides Sub OnInitializeSections(ByVal hasRecords As Boolean, ByVal fields As SortColumnDescriptorCollection)
			If Me.IsTopLevelGroup AndAlso GroupingChildTable.sectionRequired Then
				Me.Sections.Add(New ExtraSection(Me))
			End If
			MyBase.OnInitializeSections(hasRecords, fields)
		End Sub

		Public Overrides Function IsChildVisible(ByVal el As Element) As Boolean
			If Me.IsTopLevelGroup AndAlso GroupingChildTable.sectionRequired AndAlso TypeOf el Is ExtraSection Then
				Return True
			Else
				Return MyBase.IsChildVisible(el)
			End If
		End Function
	End Class
	#End Region
End Namespace
