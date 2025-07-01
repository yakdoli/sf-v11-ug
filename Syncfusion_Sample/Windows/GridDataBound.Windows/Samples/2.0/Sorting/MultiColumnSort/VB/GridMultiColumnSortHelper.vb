Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Collections
Imports Syncfusion.Windows.Forms.Grid
Imports System.Windows.Forms
Imports System.Data


Namespace GridMultiColSortHelper
	''' <summary>
	''' Helper class to faciliate multicolumn sorting 
	''' in a GridDataBoundGrid bound to a DataTable.
	''' </summary>
	Public Class GridMultiColSortHelper
		''' <summary>
		''' the constructor
		''' </summary>
		Public Sub New()

		End Sub

		'tracks the columns that are currently sorted by position in sort.
		Private sortedCols As New ArrayList()

		'tracks the columns currently sorted by column name
		Private sortDirections As New SortedList()

		'indicates whether the helper class should autosize teh columns
		Private handleAutoSize As Boolean = False

		'a reference to the GridDataBoundGrid
		Private grid As GridDataBoundGrid = Nothing

'INSTANT VB NOTE: The variable defaultSortColumn was renamed since Visual Basic does not allow class members with the same name:
		Private defaultSortColumn_Renamed As String = String.Empty
		Public Property DefaultSortColumn() As String
			Get
				Return defaultSortColumn_Renamed
			End Get
			Set(ByVal value As String)
				If defaultSortColumn_Renamed <> value Then
				   Dim dv As DataView = GetDataView()
				   If dv.Table.Columns.Contains(value) Then
					   defaultSortColumn_Renamed = value
				   Else
					   MessageBox.Show("Column """ & value & """ is not in this view")
				   End If
				End If
			End Set
		End Property

		''' <summary>
		''' Sets teh helper class to manage sorting in the grid
		''' </summary>
		''' <param name="grid">the GridDataBoundGrid</param>
		''' <param name="handleAutoSize">whether or not you want the helper class to resize the columns widths</param>
		Public Sub WireGrid(ByVal grid As GridDataBoundGrid, ByVal handleAutoSize As Boolean)
			If Me.grid IsNot Nothing AndAlso (Not Me.grid.Equals(grid)) Then
				UnwireGrid()
			End If

			If Me.grid IsNot Nothing AndAlso Me.grid.Equals(grid) Then
				Return
			End If

			Me.grid = grid
			AddHandler grid.CellClick, AddressOf grid_CellClick
			AddHandler grid.CellDoubleClick, AddressOf grid_CellDoubleClick
			AddHandler grid.DrawCellDisplayText, AddressOf grid_DrawCellDisplayText
			Me.grid.BaseStylesMap("Column Header").StyleInfo.CellType = "Header"

			'test out the datasource
			Dim dv As DataView = GetDataView()

			If handleAutoSize Then
				'size columns so triangle will fit ok
				Me.grid.AllowResizeToFit = False
				Me.grid.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0))
				For i As Integer = 1 To Me.grid.Model.ColCount
					Me.grid.Model.ColWidths(i) = Me.grid.Model.ColWidths(i) + 12
				Next i
			End If
			Me.handleAutoSize = handleAutoSize
		End Sub

		''' <summary>
		''' unhooks the helper object from the GridDataBoundGrid
		''' </summary>
		Public Sub UnwireGrid()
			If Me.grid Is Nothing Then
				Return
			End If

			RemoveHandler grid.CellClick, AddressOf grid_CellClick
			RemoveHandler grid.CellDoubleClick, AddressOf grid_CellDoubleClick
			RemoveHandler grid.DrawCellDisplayText, AddressOf grid_DrawCellDisplayText
			Me.grid.BaseStylesMap("Column Header").StyleInfo.CellType = "SortColumnHeader"

			Me.grid = Nothing
		End Sub

		'gets at the DataView
		Private Function GetDataView() As DataView
			Dim cm As CurrencyManager = TryCast(Me.grid.BindingContext(Me.grid.DataSource, Me.grid.DataMember), CurrencyManager)
			If cm IsNot Nothing Then
				Dim dv As DataView = TryCast(cm.List, DataView)
				If dv IsNot Nothing Then
					Return dv
				End If
			End If

			Throw New ArgumentException("DataSource must be a DataTable or DataView")
		End Function

		'draws the cell text with sort icon if needed
		Private Sub grid_DrawCellDisplayText(ByVal sender As Object, ByVal e As GridDrawCellDisplayTextEventArgs)
			If e.Style.CellIdentity.ColIndex > 0 AndAlso e.Style.CellIdentity.RowIndex = 0 AndAlso Me.sortDirections.Count > 0 Then
				Dim field As Integer = Me.grid.Binder.ColIndexToField(e.Style.CellIdentity.ColIndex)
				Dim gbcc As GridBoundColumnsCollection
				If (Me.grid.GridBoundColumns Is Nothing OrElse Me.grid.GridBoundColumns.Count = 0) Then
					gbcc = Me.grid.Binder.InternalColumns
				Else
					gbcc = Me.grid.GridBoundColumns
				End If
				Dim colName As String = gbcc(field).MappingName
				If Me.sortDirections(colName) IsNot Nothing Then
					Dim listSortDirection As ListSortDirection = CType(Me.sortDirections(colName), ListSortDirection)
					Dim margin As Integer = 12
					Dim textRectangle As Rectangle = e.TextRectangle
					textRectangle.Width -= margin

					GridStaticCellRenderer.DrawText(e.Graphics, e.DisplayText, e.Style.GdipFont, textRectangle, e.Style, e.Style.TextColor, False)


						Dim rect As New Rectangle(textRectangle.Right, textRectangle.Y, 10, textRectangle.Height)
						rect = GridUtil.CenterInRect(rect, New Size(8, 8))

						Dim brush As Brush = New SolidBrush(SystemColors.ControlDark)

						'g.FillRectangle(brush, rect);
						Dim i2 As Integer = Math.Max(0, (rect.Height - 3) / 2)
						rect.Inflate(-i2, -i2)
						Dim pen1 As New Pen(SystemColors.WindowFrame)
						Dim pen2 As New Pen(SystemColors.Control)
						Dim triangleDirection As GridTriangleDirection
						If listSortDirection = ListSortDirection.Ascending Then
							triangleDirection = GridTriangleDirection.Up
						Else
							triangleDirection = GridTriangleDirection.Down
						End If
						GridPaintTriangle.Paint(e.Graphics, rect, triangleDirection, brush, pen1, True)
						pen1.Dispose()
						pen2.Dispose()

					e.Cancel = True
				End If
			End If
		End Sub

		'handles the click sorting
		Private Sub grid_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			If Me.grid.SortBehavior <> GridSortBehavior.SingleClick Then
				Return
			End If
			If e.RowIndex = 0 Then
				HandleSortCol(e.ColIndex)
				e.Cancel = True
			End If
		End Sub

		'handles the double click sorting
		Private Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			If Me.grid.SortBehavior <> GridSortBehavior.DoubleClick Then
				Return
			End If
			If e.RowIndex = 0 Then
				HandleSortCol(e.ColIndex)
				e.Cancel = True
			End If
		End Sub

		'sets up the sort information in sortDirections and sortedCols.
		Private Sub HandleSortCol(ByVal colIndex As Integer)
			Dim field As Integer = Me.grid.Binder.ColIndexToField(colIndex)
			If field > -1 Then
				Dim gbcc As GridBoundColumnsCollection
				If (Me.grid.GridBoundColumns Is Nothing OrElse Me.grid.GridBoundColumns.Count = 0) Then
					gbcc = Me.grid.Binder.InternalColumns
				Else
					gbcc = Me.grid.GridBoundColumns
				End If
				Dim colName As String = gbcc(field).MappingName
				Dim dir As ListSortDirection = ListSortDirection.Ascending

				If Me.sortDirections(colName) IsNot Nothing Then
					If (CType(Me.sortDirections(colName), ListSortDirection) = ListSortDirection.Ascending) Then
						dir = ListSortDirection.Descending
					Else
						dir = ListSortDirection.Ascending
					End If
				End If

				If (Control.ModifierKeys And Keys.Control) = 0 Then
					Me.sortedCols.Clear()
					Me.sortDirections.Clear()
				End If

				If Me.sortDirections(colName) IsNot Nothing Then
					Me.sortDirections(colName) = dir
				Else
					If Me.DefaultSortColumn <> "" AndAlso (Not Me.sortedCols.Contains(Me.DefaultSortColumn)) Then
						Me.sortedCols.Add(Me.DefaultSortColumn)
						Me.sortDirections.Add(Me.DefaultSortColumn, ListSortDirection.Ascending)
					End If
					Me.sortedCols.Add(colName)
					Me.sortDirections.Add(colName, dir)
				End If

				SortColumns()
			End If
		End Sub

		''' <summary>
		''' Lets you programaticcally sort multiple columns
		''' </summary>
		''' <param name="colName">name of column to be sorted</param>
		''' <param name="dir">the direction of the sort</param>
		''' <param name="clearSortedColumns">whether previous sorts should be cleared</param>
		''' <param name="initiateSort">whether the sort should be done.</param>
		Public Sub SortColumn(ByVal colName As String, ByVal dir As ListSortDirection, ByVal clearSortedColumns As Boolean, ByVal initiateSort As Boolean)
			If clearSortedColumns Then
				Me.sortedCols.Clear()
				Me.sortDirections.Clear()
			End If

			If Me.sortDirections(colName) IsNot Nothing Then
				Me.sortDirections(colName) = dir
			Else
				If Me.DefaultSortColumn <> "" AndAlso (Not Me.sortedCols.Contains(Me.DefaultSortColumn)) Then
					Me.sortedCols.Add(Me.DefaultSortColumn)
					Me.sortDirections.Add(Me.DefaultSortColumn, ListSortDirection.Ascending)
				End If
				Me.sortedCols.Add(colName)
				Me.sortDirections.Add(colName, dir)
			End If

			If initiateSort Then
				SortColumns()
			End If
		End Sub

		'sorts the columns as specified in sortedCols and sortDirections through the DataView
		Private Sub SortColumns()
			Dim sort As String = ""
			For i As Integer = 0 To Me.sortedCols.Count - 1
				Dim colName As String = Me.sortedCols(i).ToString()
				Dim dir As String
				If (Me.sortDirections(colName).Equals(ListSortDirection.Ascending)) Then
					dir = "Asc"
				Else
					dir = "Desc"
				End If
				If i > 0 Then
					sort &= ","c
				End If
				sort &= String.Format("[{0}] {1}", colName, dir)
				Dim colIndex As Integer = Me.grid.Binder.NameToColIndex(colName)

				Me.grid(0, colIndex).Tag = Me.sortDirections(colName)
			Next i
			'Console.WriteLine(sort);

			Dim dv As DataView = GetDataView()
			dv.Sort = sort

		End Sub
	End Class


End Namespace
