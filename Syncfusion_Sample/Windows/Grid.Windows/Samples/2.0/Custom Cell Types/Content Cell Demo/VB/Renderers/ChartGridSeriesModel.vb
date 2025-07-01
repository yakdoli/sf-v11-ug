Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms.Grid

Namespace ContentCellDemo
	''' <summary>
	''' Summary description for ChartGridSeriesModel.
	''' </summary>
	''' 

	Public Class ChartGridSeriesModel
		Implements IChartSeriesModel
		Private rangeInfo As GridRangeInfo
		Private grid As GridModel
		Private colIndex As Integer
		Private Event changedHandler As ListChangedEventHandler

		Public Sub New(ByVal grid As GridModel, ByVal rangeInfo As GridRangeInfo, ByVal colIndex As Integer)
			Me.grid = grid
			Me.rangeInfo = rangeInfo
			Me.colIndex = colIndex
		End Sub

		Public ReadOnly Property Count() As Integer Implements IChartSeriesModel.Count
			Get
				Return Me.rangeInfo.Height
			End Get
		End Property

		Public Function GetX(ByVal xIndex As Integer) As Double Implements IChartSeriesModel.GetX
			'System.Diagnostics.Trace.WriteLine("GetX");
			Return xIndex + 1
		End Function

		Public Function GetY(ByVal xIndex As Integer) As Double() Implements IChartSeriesModel.GetY
			Return New Double(){Convert.ToDouble(Me.grid(Me.rangeInfo.Top + xIndex, Me.rangeInfo.Left + Me.colIndex).Text)}
		End Function

		Public Custom Event Changed As ListChangedEventHandler Implements IChartSeriesModel.Changed
			AddHandler(ByVal value As ListChangedEventHandler)
				AddHandler Me.changedHandler, value
			End AddHandler
			RemoveHandler(ByVal value As ListChangedEventHandler)
				RemoveHandler Me.changedHandler, value
			End RemoveHandler
			RaiseEvent(ByVal sender As System.Object, ByVal e As System.ComponentModel.ListChangedEventArgs)
			End RaiseEvent
		End Event

		Public Function GetEmpty(ByVal xIndex As Integer) As Boolean Implements IChartSeriesModel.GetEmpty
			' TODO:  Add ChartGridSelectionSeriesModel.GetEmpty implementation
			Return False
		End Function
	End Class
End Namespace