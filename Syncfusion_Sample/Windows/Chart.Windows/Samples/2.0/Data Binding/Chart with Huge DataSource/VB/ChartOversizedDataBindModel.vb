Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Grouping
Imports System.Collections
Imports System.Data
Imports Syncfusion.Collections.BinaryTree

Namespace ChartImportData
	''' <summary>
	''' A custom model that can compress (group) a huge data source (with a lot of points) into something smaller that can be 
	''' displayed in a Chart. The compression is done by combining the values in a set of points into 1 (we use averaging here
	''' but can be changed to Max, etc.)
	''' This sample works only with indexed data or with evenly spaced data.
	''' </summary>
	Friend Class ChartOversizedDataBindModel
		Inherits ChartBaseDataBindList
		Implements IChartSeriesModel
		Private dataSource As DataTable
		' Grouping engine that groups a set of points togather finds their average and retunrs that average 
		' as the data point.
		Private engine As New Engine()
		Private chart As ChartControl
		Private xName, yName As String
		Private dilutionFactor_Renamed As Integer = 1
		Private lastKnownZoomFactor As Double = 1

		Public Sub New(ByVal chart As ChartControl, ByVal dataSource As DataTable, ByVal xName As String, ByVal yName As String)
			Me.New(chart, dataSource, xName, yName, True)
		End Sub

		Public Sub New(ByVal chart As ChartControl, ByVal dataSource As DataTable, ByVal xName As String, ByVal yName As String, ByVal recaliberateOnZoom As Boolean)
			MyBase.New(dataSource.DefaultView, String.Empty, Nothing)
			Me.dataSource = dataSource
			engine.SetSourceList(CType(dataSource.DefaultView, IEnumerable))

			Me.yName = yName
			Me.xName = xName

			' Create a summary in the engine so that the averages, min and max are calculated for the groups (and the table).
			Dim sd As New SummaryDescriptor()
			sd.Name = "YAverage"
			sd.MappingName = yName
			sd.SummaryType = SummaryType.DoubleAggregate
			engine.TableDescriptor.Summaries.Add(sd)

			Me.chart = chart

			AddHandler chart.Resize, AddressOf chart_RequiresRecalculation

			Me.UpdateCategorizer()
		End Sub
		Public Sub RangeChanged(ByVal totalXValues As Double)
            If Me.lastKnownZoomFactor <> Me.chart.PrimaryXAxis.ZoomFactor AndAlso totalXValues = Me.dataSource.Rows.Count Then
                Me.Recaliberate()
            End If
        End Sub
		Private Sub chart_RequiresRecalculation(ByVal sender As Object, ByVal e As EventArgs)
			Me.Recaliberate()
		End Sub

		Public Sub Recaliberate()
			Me.UpdateCategorizer()
			' This is a bit of a hack to make the chart redraw the chart with the new set of points.
			Me.chart.Series(0).SeriesModel = Nothing
			Me.chart.Series(0).SeriesModel = Me
		End Sub

		Private Sub UpdateCategorizer()
			' Approximate width in pixels available to render the x-axis. The margins around the axes are ignored for now.
			Dim width As Integer = Me.chart.Width

			If width <> 0 Then
				' For example, if dilutionFactor is 100, then 100 points will be averaged into 1.
				Me.dilutionFactor_Renamed = CInt(Fix(Me.dataSource.Rows.Count)) / width

				Me.lastKnownZoomFactor = Me.chart.PrimaryXAxis.ZoomFactor

				dilutionFactor_Renamed = CInt(Fix(Math.Floor((CDbl(dilutionFactor_Renamed)) * Me.chart.PrimaryXAxis.ZoomFactor)))
				If dilutionFactor_Renamed < 1 Then
					dilutionFactor_Renamed = 1
				End If

				' Clear any existing groups
				Me.engine.TableDescriptor.GroupedColumns.Clear()

				If dilutionFactor_Renamed > 1 Then
					' Add a new group to group by x values...
					Me.engine.TableDescriptor.GroupedColumns.Add(Me.xName)
					' ... with a custom categorizer that helps group the first N number of points into 1 groups, the 2nd N into
					' another group, and so on.

					Dim categorizer As New CustomCategorizer()
					categorizer.Factor = dilutionFactor_Renamed
					Me.engine.TableDescriptor.GroupedColumns(Me.xName).Categorizer = categorizer
				End If
				Me.OnDilutionFactorChanged()
			End If
		End Sub
		''' <summary>
		''' Returns the number of "grouped" points available. If the DilutionFacotr is 20, then 20 points are grouped into 1.
		''' </summary>
		Public Overrides ReadOnly Property Count() As Integer Implements IChartSeriesModel.Count
			Get
				If Me.DilutionFactor > 1 Then
					' Return the number of groups rather than the actual number of points.
					Return Me.engine.Table.TopLevelGroup.Groups.Count
				Else
					Return Me.engine.Table.Records.Count
				End If
			End Get
		End Property
		''' <summary>
		''' The calculated dilution factor. If this is 20, for example, then 20 points are grouped into 1.
		''' </summary>
		Public ReadOnly Property DilutionFactor() As Integer
			Get
				Return Me.dilutionFactor_Renamed
			End Get
		End Property
		''' <summary>
		''' Raised whenever DilutionFactor changes.
		''' </summary>
		Public Event DilutionFactorChanged As EventHandler

		Private Sub OnDilutionFactorChanged()
			If Me.DilutionFactorChangedEvent IsNot Nothing Then
				RaiseEvent DilutionFactorChanged(Me, EventArgs.Empty)
			End If
		End Sub
		#Region "IChartSeriesModel Members"

		''' <summary>
		''' X is simply the index of the group in this implementation. Note that the X values could be DateTime for example in the
		''' actual data source, but it's always just an index in this implementation.
		''' </summary>
		Public Function GetX(ByVal xIndex As Integer) As Double Implements IChartSeriesModel.GetX
			Return xIndex
		End Function

		''' <summary>
		''' Returns the actual data corresponding to this grouped index. The specified index points to a group of points and the first
		''' point in that group is returned.
		''' </summary>
		Public Function GetXData(ByVal xIndex As Integer) As Object
			If Me.DilutionFactor > 1 Then
				' We simply use the 1st X point in the group to render the average (see GetY)
				Return Me.engine.Table.TopLevelGroup.Groups(xIndex).Records(0).GetValue(Me.xName)
			Else
				Return Me.engine.Table.Records(xIndex).GetValue(Me.xName)
			End If
		End Function
		''' <summary>
		''' Returns the averaged Y of the group of points at the specified grouped index.
		''' </summary>
		Public Function GetY(ByVal xIndex As Integer) As Double() Implements IChartSeriesModel.GetY
			If Me.DilutionFactor > 1 Then
				' Return the average of the point values that were grouped into 1.
				Dim summary As DoubleAggregateSummary = TryCast(Me.engine.Table.TopLevelGroup.Groups(xIndex).GetSummary(0), DoubleAggregateSummary)
				Return New Double() { summary.Average }
			Else
				Return New Double() { Double.Parse(Me.engine.Table.Records(xIndex).GetValue(Me.yName).ToString()) }
			End If
		End Function

		''' <summary>
		''' Returns the Max Y value in the data source.
		''' </summary>
		Public Function GetMaxY() As Double
			Dim summary As DoubleAggregateSummary = TryCast(Me.engine.Table.TopLevelGroup.GetSummary(0), DoubleAggregateSummary)
			Return summary.Maximum
		End Function
		''' <summary>
		''' Returns whether the specified index has empty point. This is never true in this implementation.
		''' </summary>
		Public Function GetEmpty(ByVal xIndex As Integer) As Boolean Implements IChartSeriesModel.GetEmpty
			Return False
        End Function

        Public Event ChartChanged As ComponentModel.ListChangedEventHandler Implements IChartSeriesModel.Changed

		#End Region
	End Class

	' This custom categorizer helps categorize the first N points (specified by Factor) into 1 group, the 2nd N points into a new group, and so on.
	Friend Class CustomCategorizer
		Implements Syncfusion.Grouping.IGroupByColumnCategorizer
		Private factor_Renamed As Integer

		Public Property Factor() As Integer
			Get
				Return factor_Renamed
			End Get
			Set(ByVal value As Integer)
				factor_Renamed = value
			End Set
		End Property

		' Returns the key for a particular value. All values with the same key will be grouped togather.
		Private Function GetCategory(ByVal val As Integer) As Integer
			' Since both are integers, only the abs of the division will be returned.
			Return val / factor_Renamed
		End Function

		Public Function GetGroupByCategoryKey(ByVal column As SortColumnDescriptor, ByVal isForeignKey As Boolean, ByVal record As Record) As Object Implements Syncfusion.Grouping.IGroupByColumnCategorizer.GetGroupByCategoryKey
			' Here the position of the record is used to determine it's key rather than any specific value in the record.
			Return GetCategory(record.GetSourceIndex())
		End Function

		Public Function CompareCategoryKey(ByVal column As SortColumnDescriptor, ByVal isForeignKey As Boolean, ByVal category As Object, ByVal record As Record) As Integer Implements Syncfusion.Grouping.IGroupByColumnCategorizer.CompareCategoryKey
			' Here the position of the record is used to determine it's key rather than any specific value in the record.
			Return GetCategory(record.GetSourceIndex()) - CInt(Fix(category))
		End Function
	End Class
End Namespace
