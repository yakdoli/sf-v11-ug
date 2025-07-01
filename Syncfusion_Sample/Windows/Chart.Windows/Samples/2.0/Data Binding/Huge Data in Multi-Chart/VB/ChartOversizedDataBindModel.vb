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
	Friend Class ChartOversizedDataBindModel
		Inherits ChartBaseDataBindList
		Implements IChartSeriesModel
        Private Shadows dataSource As DataTable
		' Grouping engine that groups a set of points togather finds their average and retunrs that average 
		' as the data point.
		Private engine As Engine = New Engine()
		Private chart As ChartControl
		Private xName, yName As String
        Private dilutionFactor1 As Integer = 1

        Public Sub New(ByVal chart As ChartControl, ByVal dataSource As DataTable, ByVal xName As String, ByVal yName As String, ByVal recaliberateOnZoom As Boolean)
            MyBase.New(dataSource.DefaultView, String.Empty, Nothing)
            Me.dataSource = dataSource
            engine.SetSourceList(CType(dataSource.DefaultView, IEnumerable))

            Me.yName = yName
            Me.xName = xName

            ' Create a summary in the engine so that the averages are calculated for the groups.
            Dim sd As SummaryDescriptor = New SummaryDescriptor()
            sd.Name = "YAverage"
            sd.MappingName = yName
            sd.SummaryType = SummaryType.DoubleAggregate
            engine.TableDescriptor.Summaries.Add(sd)

            Me.chart = chart
            AddHandler chart.Resize, AddressOf chart_RequiresRecalculation
            If recaliberateOnZoom Then
                AddHandler chart.VisibleRangeChanged, AddressOf chart_RequiresRecalculation
            End If

            Me.UpdateCategorizer()
        End Sub
        Public Sub New(ByVal chart As ChartControl, ByVal dataSource As DataTable, ByVal xName As String, ByVal yName As String)
            Me.New(chart, dataSource, xName, yName, True)
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
                Me.dilutionFactor1 = CInt(Me.chart.PrimaryXAxis.Range.Delta / width)

                dilutionFactor1 = CInt(Fix(Math.Floor((CDbl(dilutionFactor1)) * Me.chart.ZoomFactorX)))
                If dilutionFactor1 < 1 Then
                    dilutionFactor1 = 1
                End If

                ' Clear any existing groups
                Me.engine.TableDescriptor.GroupedColumns.Clear()

                If dilutionFactor1 > 1 Then
                    ' Add a new group to group by x values...
                    Me.engine.TableDescriptor.GroupedColumns.Add(Me.xName)
                    ' ... with a custom categorizer that helps group the first N number of points into 1 groups, the 2nd N into
                    ' another group, and so on.

                    Dim categorizer As CustomCategorizer = New CustomCategorizer()
                    categorizer.Factor = dilutionFactor1
                    Me.engine.TableDescriptor.GroupedColumns(Me.xName).Categorizer = categorizer
                End If
                Me.OnDilutionFactorChanged()
            End If
        End Sub

        Public Overrides ReadOnly Property Count() As Integer Implements IChartSeriesModel.Count
            Get
                If Me.dilutionFactor1 > 1 Then
                    ' Return the number of groups rather than the actual number of points.
                    Return Me.engine.Table.TopLevelGroup.Groups.Count
                Else
                    Return Me.engine.Table.Records.Count
                End If
            End Get
        End Property

        Public ReadOnly Property DilutionFactor() As Integer
            Get
                Return Me.dilutionFactor1
            End Get
        End Property

        Public Event DilutionFactorChanged As EventHandler

        Private Sub OnDilutionFactorChanged()
            If Not Me.DilutionFactorChangedEvent Is Nothing Then
                RaiseEvent DilutionFactorChanged(Me, EventArgs.Empty)
            End If
        End Sub
#Region "IChartSeriesModel Members"

        Public Function GetX(ByVal xIndex As Integer) As Double Implements IChartSeriesModel.GetX
            If Me.dilutionFactor1 > 1 Then
                ' We simply use the 1st X point in the group to render the average (see GetY)
                Dim value As Object = Me.engine.Table.TopLevelGroup.Groups(xIndex).Records(0).GetValue(Me.xName)
                Return Double.Parse(value.ToString())
            Else
                Return Double.Parse(Me.engine.Table.Records(xIndex).GetValue(Me.xName).ToString())
            End If
        End Function

        Public Function GetY(ByVal yIndex As Integer) As Double() Implements IChartSeriesModel.GetY
            If Me.dilutionFactor1 > 1 Then
                ' Return the average of the point values that were grouped into 1.
                Dim summary As DoubleAggregateSummary = TryCast(Me.engine.Table.TopLevelGroup.Groups(yIndex).GetSummary(0), DoubleAggregateSummary)
                Return New Double() {summary.Average}
            Else
                Return New Double() {Double.Parse(Me.engine.Table.Records(yIndex).GetValue(Me.yName).ToString())}
            End If
        End Function


        Public Function GetEmpty(ByVal xIndex As Integer) As Boolean Implements IChartSeriesModel.GetEmpty
            Return False
        End Function
#End Region

        Public Event ChartChanged As ComponentModel.ListChangedEventHandler Implements IChartSeriesModel.Changed
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
            Return CInt(val / factor_Renamed)
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
