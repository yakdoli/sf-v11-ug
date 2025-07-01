Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports Syncfusion.Windows.Forms.Chart


Namespace ChartLegendSample
	''' <summary>
	''' Summary description for ArrayModel.
	''' </summary>
	Public Class LabelModel
		Implements IChartAxisLabelModel
		Private labels() As String

		Public Sub New(ByVal labels() As String)
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

	''' <summary>
	''' Summary description for SimpleModel.
	''' </summary>
	Public Class ArrayModel
		Implements IChartSeriesIndexedModel
		Private data() As Double

		Public Sub New(ByVal data() As Double)
			Me.data = data
		End Sub

		Public ReadOnly Property Count() As Integer Implements IChartSeriesIndexedModel.Count
			Get
				Return Me.data.GetLength(0)
			End Get
		End Property

		Public Function GetY(ByVal xIndex As Integer) As Double() Implements IChartSeriesIndexedModel.GetY
			Return New Double(){data(xIndex)}
		End Function

		Public Function GetEmpty(ByVal index As Integer) As Boolean Implements IChartSeriesIndexedModel.GetEmpty
			Return False
		End Function

		Public Event Changed As ListChangedEventHandler Implements IChartSeriesIndexedModel.Changed
	End Class
End Namespace
