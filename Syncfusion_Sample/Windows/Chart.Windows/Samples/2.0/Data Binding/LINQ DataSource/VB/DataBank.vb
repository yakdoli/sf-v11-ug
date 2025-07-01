Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Collections

Namespace ChartDataBinding
	#Region "Populating DataBase"
	Public Class PopulationDataService
		Private Shared populationData As PopulationData()

		'Populate Database
		Public Shared Sub PopulateDataBase()
			'We can use the Database to have these details 
			populationData = New PopulationData(5) {}
			populationData(0) = New PopulationData("New York", 13)
			populationData(1) = New PopulationData("Houston", 6)
			populationData(2) = New PopulationData("Tokyo", 15)
			populationData(3) = New PopulationData("London", 12)
			populationData(4) = New PopulationData("Chicago", 18)
			populationData(5) = New PopulationData("Los Angeles", 11)
		End Sub

		Public Shared Function GetCompleteList() As PopulationData()
			Return populationData
		End Function

		'LINQ statement to fetch top 3 cities by their population.
        Public Shared Function GetFilteredData() As Object
            Dim data As IEnumerable(Of ChartDataBinding.PopulationData)
            data = (From e In populationData Order By e.Population Descending Select New PopulationData(e.City.ToString(), e.Population)).Take(3)

            Return data.ToList()
        End Function
	End Class
	#End Region

	#Region "Designing Database"
	Public Class PopulationData
		Private city_Renamed As String

		Public Property City() As String
			Get
				Return city_Renamed
			End Get
			Set
				city_Renamed = Value
			End Set
		End Property

		Private population_Renamed As Double

		Public Property Population() As Double
			Get
				Return population_Renamed
			End Get
			Set
				population_Renamed = Value
			End Set
		End Property

'INSTANT VB NOTE: The parameter city was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
'INSTANT VB NOTE: The parameter population was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal city_Renamed As String, ByVal population_Renamed As Double)
			Me.city_Renamed = city_Renamed
			Me.population_Renamed = population_Renamed
		End Sub
	End Class
	#End Region
End Namespace
