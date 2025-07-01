Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace ClickPointDemo2
	Friend Class TrendLineRenderer
		Private chart As ChartControl
		Private mDown As Point = Point.Empty
		Private draggingTrendLineSeries As ChartSeries = Nothing

		Public Sub New(ByVal chart As ChartControl)
			Me.chart = chart
			AddHandler chart.MouseDown, AddressOf chart_MouseDown
			AddHandler chart.MouseUp, AddressOf chart_MouseUp
			AddHandler chart.MouseMove, AddressOf chart_MouseMove
		End Sub

		Private lineUpColor_Renamed As Color = Color.DarkGreen
		''' <summary>
		''' Specifies the color to draw the trendline in when indicating a upward trend
		''' </summary>
		Public Property LineUpColor() As Color
			Get
				Return lineUpColor_Renamed
			End Get
			Set(ByVal value As Color)
				lineUpColor_Renamed = value
			End Set
		End Property

		Private lineDownColor_Renamed As Color = Color.Blue
		''' <summary>
		''' Specifies the color to draw the trendline in when indicating a downward trend
		''' </summary>
		Public Property LineDownColor() As Color
			Get
				Return lineDownColor_Renamed
			End Get
			Set(ByVal value As Color)
				lineDownColor_Renamed = value
			End Set
		End Property


		Private lineWidth_Renamed As Integer = 2
		''' <summary>
		''' Specifies the minimum width a trend line can be drawn with
		''' </summary>
		Public Property LineWidth() As Integer
			Get
				Return lineWidth_Renamed
			End Get
			Set(ByVal value As Integer)
				lineWidth_Renamed = value
			End Set
		End Property

		Private lineStyle_Renamed As DashStyle
		Public Property LineStyle() As DashStyle
			Get
				Return lineStyle_Renamed
			End Get
			Set(ByVal value As DashStyle)
				lineStyle_Renamed = value
			End Set
		End Property

		Private lineSymbol_Renamed As ChartSymbolShape
		Public Property LineSymbol() As ChartSymbolShape
			Get
				Return lineSymbol_Renamed
			End Get
			Set(ByVal value As ChartSymbolShape)
				lineSymbol_Renamed = value
			End Set
		End Property

		Private lineSymbolColor_Renamed As Color = Color.Yellow
		Public Property LinesymbolColor() As Color
			Get
				Return lineSymbolColor_Renamed
			End Get
			Set(ByVal value As Color)
				lineSymbolColor_Renamed = value
			End Set
		End Property

		Private lineSymbolSize_Renamed As Size = New Size(9, 9)
		Public Property LineSymbolSize() As Size
			Get
				Return lineSymbolSize_Renamed
			End Get
			Set(ByVal value As Size)
				lineSymbolSize_Renamed = value
			End Set
		End Property

		Private Sub chart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.MouseMove(e.Location)
		End Sub

		Private Sub chart_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.MouseUp(e.Location)
		End Sub

		Private Sub chart_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Me.MouseDown(e.Location)
		End Sub

		Public Sub MouseDown(ByVal pt As Point)
			If Me.chart.ChartArea.RenderBounds.Contains(pt) Then
				Me.mDown = pt
			End If
		End Sub

		Public Sub MouseMove(ByVal pt As Point)
			If Me.mDown <> Point.Empty Then
				If Me.IsDragging = False Then
					Me.StartDragging(pt)
				Else
					Me.UpdateDragPoint(pt)
				End If
			End If
		End Sub

		Public Sub MouseUp(ByVal pt As Point)
			If Me.IsDragging Then
				Me.EndDragging(pt)
			Else
				Me.mDown = Point.Empty
			End If
		End Sub

		#Region "DraggingCode"
		Private isDragging_Renamed As Boolean = False
		Private Property IsDragging() As Boolean
			Get
				Return Me.isDragging_Renamed
			End Get
			Set(ByVal value As Boolean)
				If isDragging_Renamed <> value Then
					Me.isDragging_Renamed = value
					If Me.isDragging_Renamed = False Then
						Me.mDown = Point.Empty
						If Not Me.draggingTrendLineSeries Is Nothing Then
							Me.chart.Series.Remove(Me.draggingTrendLineSeries)
							Me.draggingTrendLineSeries = Nothing
						End If
					Else
						If Me.mDown = Point.Empty Then
							Throw New Exception("Always set IsDragging to true after setting a valid value on the mDown.")
						End If
					End If
				End If
			End Set
		End Property

		Private Sub StartDragging(ByVal mousePoint As Point)
			Me.IsDragging = True

			Me.draggingTrendLineSeries = Me.CreateNewSeries(Me.mDown, mousePoint)

			Me.UpdateTrendLineColor(Me.draggingTrendLineSeries)
		End Sub

		Private Sub UpdateDragPoint(ByVal pt As Point)
			Dim ptEnd As ChartPoint = Me.chart.ChartArea.GetValueByPoint(pt)

			Me.draggingTrendLineSeries.Points(1).X = ptEnd.X
			Me.draggingTrendLineSeries.Points(1).YValues(0) = ptEnd.YValues(0)

			Me.UpdateTrendLineColor(Me.draggingTrendLineSeries)
		End Sub

		Private Sub EndDragging(ByVal pt As Point)
			If Me.IsDragging Then
				If Me.chart.ChartArea.RenderBounds.Contains(pt) Then
					If Math.Abs(Me.mDown.X - pt.X) > 10 OrElse Math.Abs(Me.mDown.Y - pt.Y) > 10 Then
						Me.AddTrendLine(Me.mDown, pt)

					End If
				End If
				Me.IsDragging = False
			End If
			Console.WriteLine(Me.mDown.ToString() & " ,  " & pt.ToString())
		End Sub

		Public Function CreateNewSeries(ByVal start As Point, ByVal [end] As Point) As ChartSeries
			Dim ptStart As ChartPoint = Me.chart.ChartArea.GetValueByPoint(start)
			Dim ptEnd As ChartPoint = Me.chart.ChartArea.GetValueByPoint([end])

            Dim tseries As ChartSeries = New ChartSeries("Dragging TrendLine", ChartSeriesType.Line)

			tseries.Points.Add(ptStart)
			tseries.Points.Add(ptEnd)

			Me.chart.Series.Add(tseries)

			'tseries.LegendItem.Visible = false;

			Return tseries
		End Function

		Public Sub AddTrendLine(ByVal start As Point, ByVal [end] As Point)
			Dim newSeries As ChartSeries = Me.CreateNewSeries(start, [end])

			Me.UpdateTrendLineColor(newSeries)

		End Sub

		Public Sub UpdateTrendLineColor(ByVal newSeries As ChartSeries)
			Dim ptStart As ChartPoint = newSeries.Points(0)
			Dim ptEnd As ChartPoint = newSeries.Points(1)
			' Specify the color for the lines
			If ptStart.YValues(0) < ptEnd.YValues(0) Then
				newSeries.Style.Interior = New Syncfusion.Drawing.BrushInfo(Me.LineUpColor)
			Else
				newSeries.Style.Interior = New Syncfusion.Drawing.BrushInfo(Me.LineDownColor)
			End If
			newSeries.Style.Border.Width = Me.LineWidth
			newSeries.Style.Border.DashStyle = Me.lineStyle_Renamed
			newSeries.Style.Symbol.Color = Me.LinesymbolColor
			newSeries.Style.Symbol.Shape = Me.LineSymbol
			newSeries.Style.Symbol.Size = Me.LineSymbolSize
			newSeries.Style.ToolTip = "Date  : " & newSeries.Points(0).DateX.ToString() & Constants.vbLf & "Value :" & newSeries.Points(0).YValues(0).ToString()
		End Sub
		#End Region
	End Class
End Namespace
