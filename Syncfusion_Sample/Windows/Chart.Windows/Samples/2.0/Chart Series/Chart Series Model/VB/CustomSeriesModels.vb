Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports Syncfusion.Windows.Forms.Chart
Imports System.Collections.Generic


Namespace ChartSeriesModel
#Region "CustomIndexedSeriesModel"
	Public Class CustomIndexedSeriesModel
		Implements IChartSeriesIndexedModel

		Private dd As Data = New Data()

		Public Sub New()
		   ' dd.FillData();

		End Sub
		Public ReadOnly Property Count() As Integer Implements IChartSeriesIndexedModel.Count
			Get
				Return dd.customData.Count
			End Get
		End Property

		Public Function GetY(ByVal xIndex As Integer) As Double() Implements IChartSeriesIndexedModel.GetY
			Return New Double() { dd.customData(xIndex).docsGenerated }
		End Function

		Public Function GetEmpty(ByVal index As Integer) As Boolean Implements IChartSeriesIndexedModel.GetEmpty
			Return False
		End Function

		Public Event Changed As ListChangedEventHandler Implements IChartSeriesIndexedModel.Changed

	End Class
		#End Region

#Region "CustomSeriesModel"
	Public Class CustomSeriesModel
		Implements IChartSeriesModel
		Private dd As Data = New Data()
		Public ReadOnly Property Count() As Integer Implements IChartSeriesModel.Count
			Get
				Return dd.customData.Count
			End Get
		End Property
		Public Function GetX(ByVal xIndex As Integer) As Double Implements IChartSeriesModel.GetX
			Return dd.customData(xIndex).testTime.Month
		End Function

		Public Function GetY(ByVal xIndex As Integer) As Double() Implements IChartSeriesModel.GetY
			Return New Double() { dd.customData(xIndex).docsGenerated }
		End Function

		Public Function GetEmpty(ByVal index As Integer) As Boolean Implements IChartSeriesModel.GetEmpty
			Return False
		End Function

		Public Event Changed As ListChangedEventHandler Implements IChartSeriesModel.Changed
	End Class

		#End Region

#Region "Data"
	Public Class Data
		Public testTime As DateTime ' X
		Public docsGenerated As Integer ' Y
		Public testLabel As String ' custom strings for X axis labels.
		Public Sub New()
			FillData()
		End Sub
		Public Sub New(ByVal TestTime As DateTime, ByVal DocsGenerated As Integer, ByVal TestLabel As String)
			Me.testTime = TestTime
			Me.docsGenerated = DocsGenerated
			Me.testLabel = TestLabel
		End Sub
		Public customData As BindingList(Of Data)
		Public Sub FillData()
			customData = New BindingList(Of Data)()
			customData.Add(New Data(New DateTime(2008, 4, 10), 50, "v5.0"))
			customData.Add(New Data(New DateTime(2008, 4, 15), 75, "SP 1"))
			customData.Add(New Data(New DateTime(2008, 5, 20), 85, "SP 2"))
			customData.Add(New Data(New DateTime(2008, 7, 30), 95, "SP 3"))
		End Sub
	End Class
			#End Region

#Region "LabelModel"
	Public Class IndexedSeriesLabelModel
		Implements IChartAxisLabelModel
		Private dd As Data = New Data()
		Public Function GetLabelAt(ByVal index As Integer) As ChartAxisLabel Implements IChartAxisLabelModel.GetLabelAt
			If index = 0 Then
				Return New ChartAxisLabel("")
			Else
				Return New ChartAxisLabel("     " & dd.customData(index - 1).testLabel & Constants.vbLf & " (" & dd.customData(index - 1).testTime.Month & "/" & dd.customData(index - 1).testTime.Day & "/" & dd.customData(index-1).testTime.Year & ")")
			End If
		End Function

		Public ReadOnly Property Count() As Integer Implements IChartAxisLabelModel.Count
			Get
				Return dd.customData.Count + 1
			End Get
		End Property
	End Class

	Public Class SeriesLabelModel
		Implements IChartAxisLabelModel
		Private labels As String()

		Public Sub New(ByVal labels As String())
			Me.labels = labels
		End Sub

		Public Function GetLabelAt(ByVal index As Integer) As ChartAxisLabel Implements IChartAxisLabelModel.GetLabelAt
			Return New ChartAxisLabel(Me.labels(index))
		End Function

		Public ReadOnly Property Count() As Integer Implements IChartAxisLabelModel.Count
			Get
				Return Me.labels.GetLength(0)
			End Get
		End Property
	End Class
	#End Region

End Namespace












