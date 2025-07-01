Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Imports Syncfusion.Diagnostics
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace ExcelLikeUI_2005

	Public Class ExcelMarkerMouseController
		Implements IMouseController
		Private grid As GridControlBase
		Private activeRange As GridRangeInfo
		Private lastHitTestCode As Integer = GridHitTestContext.None
		Private Const HitExcelMarker As Integer = 101
		Private Const delta As Integer = 3
		Private dragWindow As DragWindow
		Private cursor1 As Cursor

		Public Sub New(ByVal grid As GridControlBase)
			Me.grid = grid
			Me.grid.Model.Options.SelectCellsMouseButtonsMask = MouseButtons.Left
		End Sub

		Public ReadOnly Property Name() As String Implements IMouseController.Name
			Get
				Return "ExcelMarker"
			End Get
		End Property

		Public ReadOnly Property Cursor() As Cursor Implements IMouseController.Cursor
			Get
				If cursor1 Is Nothing Then
					Dim stream As System.IO.Stream = Me.GetType().Module.Assembly.GetManifestResourceStream("ExcelLikeUI.cross.CUR")
					If Not stream Is Nothing Then
						cursor1 = New Cursor(stream)
					Else
						cursor1 = Cursors.Cross
					End If

				End If
				Return cursor1
			End Get
		End Property

		Public Sub MouseHoverEnter() Implements IMouseController.MouseHoverEnter
		End Sub

		Public Sub MouseHover(ByVal e As MouseEventArgs) Implements IMouseController.MouseHover
		End Sub
		Public Sub MouseHoverLeave(ByVal e As EventArgs) Implements IMouseController.MouseHoverLeave
		End Sub

		Private cc As GridCurrentCell
		Public Sub MouseDown(ByVal e As MouseEventArgs) Implements IMouseController.MouseDown
			cc = Me.grid.CurrentCell
			If e.Button = MouseButtons.Left Then
				If e.Clicks = 1 Then
					' Start automatic scrolling when user drags mouse out of window
					grid.AutoScrolling = ScrollBars.Both

					' 
					Dim rowIndex, colIndex As Integer
					Dim point As Point = New Point(e.X, e.Y)
					grid.PointToRowCol(point, rowIndex, colIndex)
					activeRange = grid.Selections.Ranges.ActiveRange

					dragWindow = New DragWindow()
					dragWindow.Opacity =.2f
					dragWindow.BackColor = SystemColors.Highlight
					dragWindow.Bounds = GetBounds(activeRange)
					dragWindow.ShowWindowTopMost()
					val = Me.grid.CurrentCell.Renderer.ControlValue
				End If
			End If
			'else if (e.Clicks == 2)
			' DoubleClick

		End Sub

		Private Function GetBounds(ByVal range As GridRangeInfo) As Rectangle
			Dim bounds As Rectangle = grid.RangeInfoToRectangle(range, GridRangeOptions.None)
			bounds.Intersect(grid.ClientRectangle)
			bounds = grid.RectangleToScreen(bounds)
			Return bounds
		End Function


		Public Sub MouseMove(ByVal e As MouseEventArgs) Implements IMouseController.MouseMove
			Dim rowIndex, colIndex As Integer
			Dim point As Point = New Point(e.X-delta, e.Y-delta)
			Try
				grid.PointToRowCol(point, rowIndex, colIndex, 0)
				rowIndex = Math.Max(grid.TopRowIndex, rowIndex)
				colIndex = Math.Max(grid.LeftColIndex, colIndex)
				If colIndex<=activeRange.Right AndAlso colIndex>=activeRange.Left Then
					'range = GridRangeInfo.Cells(activeRange.Top, activeRange.Left, rowIndex, colIndex);
					range=GridRangeInfo.Cells(activeRange.Top, activeRange.Left, rowIndex,activeRange.Right)
				ElseIf rowIndex<=activeRange.Bottom AndAlso rowIndex>=activeRange.Top Then
					range = GridRangeInfo.Cells(activeRange.Top, activeRange.Left,activeRange.Bottom,colIndex)
				End If
						'GetDraggedRangesBorderFilled(range);
						dragWindow.Bounds = GetBounds(range)
						dragWindow.ShowWindowTopMost()
			Catch
			End Try
		End Sub

		Public Sub MouseUp(ByVal e As MouseEventArgs) Implements IMouseController.MouseUp
			' Stop automatic scrolling 
			grid.AutoScrolling = ScrollBars.None

			Dim rowIndex, colIndex As Integer
			Dim point As Point = New Point(e.X, e.Y)
			grid.PointToRowCol(point, rowIndex, colIndex)

			dragWindow.Visible = False
			dragWindow = Nothing

			'range = GridRangeInfo.Cells(activeRange.Top, activeRange.Left, rowIndex, colIndex);
			GetDraggedRangesFilled()
			'***
			If e.Button = MouseButtons.Right Then
				Dim top As Integer = Me.grid.Model.Selections.Ranges.ActiveRange.Top
				Dim bottom As Integer = Me.grid.Model.Selections.Ranges.ActiveRange.Bottom
				Dim left As Integer = Me.grid.Model.Selections.Ranges.ActiveRange.Left
				Dim right As Integer = Me.grid.Model.Selections.Ranges.ActiveRange.Right
				Dim row As Integer = 0
				Dim col As Integer = 0
				Dim flag As Boolean = False

				If Me.grid.Model.Selections.Ranges.Count > 0 Then
					flag = True
				End If

				cc = Me.grid.CurrentCell
				Dim p As Point = Me.grid.PointToClient(Control.MousePosition)
				Me.grid.PointToRowCol(p, row, col)
				If flag Then
					If row > bottom OrElse row < top OrElse col < left OrElse col > right Then
						ActiveXSnapshot.FakeLeftMouseClick(Me.grid, p)
					End If
					flag = False
				End If
				Me.grid.CurrentCell.MoveTo(row,col,GridSetCurrentCellOptions.ScrollInView)
			End If

			'*** end of non executed code
		End Sub
		Private range As GridRangeInfo

		Private val As Object
		Private flag As Boolean=True
		Private Function IsNumber(ByVal Val As String) As Boolean
			If Val.Length<=0 Then
				Return False
			End If
			For i As Integer = 0 To Val.Length - 1
				If (Not Char.IsDigit(Val.Chars(i))) Then
					Return False
				End If
			Next i

			Return True
		End Function
		Private Sub GetDraggedRangesFilled()
			Dim v As Integer=0
			flag= IsNumber(val.ToString())

			If flag Then
				v= Int32.Parse(val.ToString())
			End If
			If Not range Is Nothing Then
				For top As Integer = range.Top To range.Bottom
					For left As Integer = range.Left To range.Right
						If flag Then
							Me.grid.Model(top,left).CellValue =v
							v += 1
						Else
							Me.grid.Model(top,left).CellValue = val
						End If
					Next left
				Next top
			End If
			Me.grid.Selections.Add(GridRangeInfo.Cells(range.Top, range.Left, range.Bottom, range.Right))
'			this.grid.CurrentCell.MoveTo(-1, -1);
		End Sub


		Public Sub CancelMode() Implements IMouseController.CancelMode
			grid.AutoScrolling = ScrollBars.None
			dragWindow.Visible = False
			dragWindow = Nothing
		End Sub

		Public Function HitTest(ByVal e As MouseEventArgs, ByVal controller As IMouseController) As Integer Implements IMouseController.HitTest
			lastHitTestCode = GridHitTestContext.None
			If e.Button = MouseButtons.Left Then
				Dim range As GridRangeInfo = grid.Selections.Ranges.ActiveRange
				If (Not range.IsEmpty) Then
					Dim point As Point = New Point(e.X, e.Y)
					point.Offset(-delta, -delta)
					Dim rowIndex, colIndex As Integer
					grid.PointToRowCol(point, rowIndex, colIndex)

					If rowIndex = range.Bottom AndAlso colIndex = range.Right Then
						point.Offset(delta*2+1, delta*2+1)
						Dim rowIndex2, colIndex2 As Integer
						grid.PointToRowCol(point, rowIndex2, colIndex2)
						If rowIndex2 <> rowIndex AndAlso colIndex2 <> colIndex Then
							lastHitTestCode = HitExcelMarker
						End If
					End If
				End If
			End If
			Return lastHitTestCode
		End Function
	End Class
End Namespace