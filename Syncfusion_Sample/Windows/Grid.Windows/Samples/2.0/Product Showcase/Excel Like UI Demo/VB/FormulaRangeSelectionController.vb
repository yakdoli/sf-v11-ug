#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace ExcelLikeUI_2005

	''' <summary>
	''' Summary description for FormulaRangeSelectionController.
	''' </summary>
	Public Class FormulaRangeSelectionController
		Implements IMouseController
		'
		Private grid As GridControlBase
		Private activeRange As GridRangeInfo
		Private lastHitTestCode As Integer = GridHitTestContext.None
		Private Const selectingCellsHitTestCode As Integer = 101

		'used for public properties
		Private mouseRequiresControlKey_Renamed As Boolean = False
		Private keyRequiresControlKey As Boolean = False
		Private selectColor As Color = Color.LightBlue
		Private resetSelectAfterPlacement As Boolean = True

		'used to highlight the formula range selection as it changes
		Private dragWindow As DragWindow

		Public Sub New(ByVal grid As GridControlBase)
			Me.grid = grid

			'events used to react to keyboard actions
			AddHandler grid.CurrentCellKeyDown, AddressOf grid_CurrentCellKeyDown
			AddHandler grid.CurrentCellDeactivated, AddressOf grid_CurrentCellDeactivated
			AddHandler grid.CurrentCellValidateString, AddressOf grid_CurrentCellValidateString
		End Sub

		#Region "Properties specific to FormulaRangeSelectionController"

		''' <summary>
		''' Indicates whether the user needs to press control while
		''' selecting the range with the mouse.
		''' </summary>
		Public Property MouseRequiresControlKey() As Boolean
			Get
				Return mouseRequiresControlKey_Renamed
			End Get
			Set(ByVal value As Boolean)
				mouseRequiresControlKey_Renamed = value
			End Set
		End Property

		''' <summary>
		''' Indicates whether the user needs to press control while
		''' selecting the range with the arrow keys.
		''' </summary>
		Public Property KeyBoardRequiresControlKey() As Boolean
			Get
				Return keyRequiresControlKey
			End Get
			Set(ByVal value As Boolean)
				keyRequiresControlKey = value
			End Set
		End Property

		''' <summary>
		''' Color used to mark the cells being selected.
		''' </summary>
		Public Property SelectionColor() As Color
			Get
				Return selectColor
			End Get
			Set(ByVal value As Color)
				selectColor = value
			End Set
		End Property

		''' <summary>
		''' Indicates whether the placed text should remain selected when control is returned
		''' to the user after selecting cells.
		''' </summary>
		Public Property ResetSelectionAfterPlacement() As Boolean
			Get
				Return resetSelectAfterPlacement
			End Get
			Set(ByVal value As Boolean)
				resetSelectAfterPlacement = value
			End Set
		End Property
		#End Region

		#Region "base implementation properties"
		Public ReadOnly Property Name() As String Implements IMouseController.Name
			Get
				Return "FormulaRangeSelector"
			End Get
		End Property

		Public ReadOnly Property Cursor() As Cursor Implements IMouseController.Cursor
			Get
				Return Cursors.Default
			End Get
		End Property

		#End Region

		#Region "keyboard handling for selecting cells with arrow keys"

		'indicates whether cells are being selected with the keyboard
		Private inKeyMove As Boolean = False

		'holds the location of the most recently key selected cell
		Private keyRow As Integer = -1
		Private keyCol As Integer = -1

		'handle keys not handled by the active textbox
		'arrow keys, escape, enter, ...
		Private Sub grid_CurrentCellKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			Dim cc As GridCurrentCell = Me.grid.CurrentCell

			If e.KeyCode = Keys.Escape Then
				If inKeyMove Then
					e.Handled = True
					Dim gtb As TextBoxBase = CType(cc.Renderer.Control, TextBoxBase)
					gtb.SelectedText = "" 'clear the text
				End If
				CancelMode()
			Else
				If cc.HasControlFocus AndAlso TypeOf cc.Renderer Is GridFormulaCellRenderer AndAlso CanDoKeySelection(cc) Then
					Dim handled As Boolean = False
					Select Case e.KeyCode
						Case Keys.Up
							If inKeyMove Then
								If (keyRow > Me.grid.Model.Rows.HeaderCount) Then
									keyRow -= 1
								Else
									keyRow -= 0
								End If
							Else
								If (cc.RowIndex > Me.grid.Model.Rows.HeaderCount) Then
									keyRow = cc.RowIndex - (1)
								Else
									keyRow = cc.RowIndex - (0)
								End If
								keyCol = cc.ColIndex
							End If
							handled = True
						Case Keys.Down
							If inKeyMove Then
								If (keyRow < Me.grid.Model.RowCount) Then
									keyRow += 1
								Else
									keyRow += 0
								End If
							Else
								If (cc.RowIndex < Me.grid.Model.RowCount) Then
									keyRow = cc.RowIndex + (1)
								Else
									keyRow = cc.RowIndex + (0)
								End If
								keyCol = cc.ColIndex
							End If
							handled = True
						Case Keys.Left
							If inKeyMove Then
								If (keyCol > Me.grid.Model.Rows.HeaderCount) Then
									keyCol -= 1
								Else
									keyCol -= 0
								End If
							Else
								If (cc.ColIndex > Me.grid.Model.Rows.HeaderCount) Then
									keyCol = cc.ColIndex - (1)
								Else
									keyCol = cc.ColIndex - (0)
								End If
								keyRow = cc.RowIndex
							End If
							handled = True
						Case Keys.Right
							If inKeyMove Then
								If (keyCol < Me.grid.Model.ColCount) Then
									keyCol += 1
								Else
									keyCol += 0
								End If
							Else
								If (cc.ColIndex < Me.grid.Model.ColCount) Then
									keyCol = cc.ColIndex + (1)
								Else
									keyCol = cc.ColIndex + (0)
								End If
								keyRow = cc.RowIndex
							End If
							handled = True
						Case Keys.Enter
							If inKeyMove Then
								inKeyMove = False
								e.Handled = True
								PlaceTextInCell(ResetSelectionAfterPlacement)
								CancelMode()
								Return
							End If

						Case Else
					End Select
					If handled Then
						If inKeyMove AndAlso 0 <> (Control.ModifierKeys And Keys.Shift) Then
							Me.MoveDragToRowCol(keyRow, keyCol)
						Else
							CancelMode()
							Me.StartDragAtRowCol(keyRow, keyCol)
							inKeyMove = True
							'puts text in cell
							Me.MoveDragToRowCol(keyRow, keyCol)
						End If
					Else
						inKeyMove = False
					End If
					e.Handled = handled
				End If
			End If

		End Sub

		'turn off everything when the current cell deactivates
		Private Sub grid_CurrentCellDeactivated(ByVal sender As Object, ByVal e As GridCurrentCellDeactivatedEventArgs)
			CancelMode()
		End Sub

		'catches the keypress of a key normally handled by the textbox
		'here we start the range slection and append the keystroke
		Private Sub grid_CurrentCellValidateString(ByVal sender As Object, ByVal e As GridCurrentCellValidateStringEventArgs)
			Dim s As String = e.Text
			Dim len As Integer = s.Length
			If inKeyMove AndAlso len > 0 Then
				Dim cc As GridCurrentCell = Me.grid.CurrentCell
				Dim gtb As TextBoxBase = CType(cc.Renderer.Control, TextBoxBase)
				gtb.Text = gtb.Text & s.Chars(len - 1)
				gtb.SelectionStart = gtb.Text.Length + 1
				gtb.SelectionLength = 0
				CancelMode()
				e.Cancel = True
			End If
		End Sub
		#End Region

		#Region "Text Management during a selection"

		Private initDragRow As Integer = -1
		Private intDragCol As Integer = -1
		Private Sub StartDragAtRowCol(ByVal row As Integer, ByVal col As Integer)
			activeRange = GridRangeInfo.Cell(row, col)

			initDragRow = row
			intDragCol = col

			dragWindow = New DragWindow()
			dragWindow.Opacity =.4f
			dragWindow.BackColor = SelectionColor
			dragWindow.Bounds = GetBounds(activeRange)
			dragWindow.ShowWindowTopMost()
		End Sub

		Private Sub PlaceTextInCell(ByVal resetSelection As Boolean)
			Dim range As String = GridRangeInfo.GetAlphaLabel(activeRange.Left) + GridRangeInfo.GetNumericLabel(activeRange.Top)
			If activeRange.Top <> activeRange.Bottom OrElse activeRange.Left <> activeRange.Right Then
				range &= ":"c + GridRangeInfo.GetAlphaLabel(activeRange.Right) + GridRangeInfo.GetNumericLabel(activeRange.Bottom)
			End If

			Dim gtb As TextBoxBase = GetTextBox()

			Dim start As Integer = gtb.SelectionStart

			gtb.SelectedText = range
			If resetSelection Then
                gtb.SelectionStart = Convert.ToInt32(start & range.ToString().Length)
				gtb.SelectionLength = 0
			Else
				gtb.SelectionStart = start
				gtb.SelectionLength = range.ToString().Length
			End If
		End Sub

		Private Sub MoveDragToRowCol(ByVal row As Integer, ByVal col As Integer)
			If row > grid.Model.Rows.FrozenCount Then
				row = Math.Max(grid.TopRowIndex, row)
			End If
			If col > grid.Model.Cols.FrozenCount Then
				col = Math.Max(grid.LeftColIndex, col)
			End If


			Dim top As Integer = Math.Min(initDragRow, row)
			Dim left As Integer = Math.Min(intDragCol, col)
			Dim bottom As Integer = Math.Max(initDragRow, row)
			Dim right As Integer = Math.Max(intDragCol, col)
			activeRange = GridRangeInfo.Cells(top, left, bottom, right)
			PlaceTextInCell(False)
			dragWindow.Bounds = GetBounds(activeRange)
			dragWindow.ShowWindowTopMost()
		End Sub

		#End Region

		#Region "Code to allow the start of selections"

		Private validPrecedingChars_Renamed As String = "+-/*<>=(,:"
		Public Property ValidPrecedingChars() As String
			Get
				Return validPrecedingChars_Renamed
			End Get
			Set(ByVal value As String)
				validPrecedingChars_Renamed = value
			End Set
		End Property

		Protected Overridable Function CanDoSelection(ByVal cc As GridCurrentCell) As Boolean
			Dim gtb As TextBoxBase = GetTextBox()
			Dim s As String = gtb.Text
			Dim b As Boolean = s.Length > 0 AndAlso gtb.SelectionStart > 0 AndAlso validPrecedingChars_Renamed.IndexOf(s.Chars(gtb.SelectionStart-1)) > -1
			Return b
		End Function

		Protected Overridable Function CanDoKeySelection(ByVal cc As GridCurrentCell) As Boolean
			Dim ctrl As Boolean = (Control.ModifierKeys And Keys.Control) <> 0

			Dim b As Boolean = CanDoSelection(cc) OrElse Me.inKeyMove

			If b Then
				Dim gtb As TextBoxBase = CType(cc.Renderer.Control, TextBoxBase)
				Dim s As String = gtb.Text
				b = Me.inKeyMove OrElse (KeyBoardRequiresControlKey AndAlso ctrl) OrElse ((Not KeyBoardRequiresControlKey) AndAlso gtb.SelectionStart = gtb.Text.Length)
			End If

			Return b
		End Function
		#End Region

		#Region "base implementation overrides"
		Public Sub MouseHoverEnter() Implements IMouseController.MouseHoverEnter
		End Sub

		''' <summary>
		''' User is moving the mouse over the hot-test area
		''' </summary>
		''' <param name="e"></param>
		Public Sub MouseHover(ByVal e As MouseEventArgs) Implements IMouseController.MouseHover
		End Sub

		''' <summary>
		''' Called when the hovering ends, either when user has moved mouse away from hittest area
		''' or when the user has pressed a mouse button.
		''' </summary>
		Public Sub MouseHoverLeave(ByVal e As EventArgs) Implements IMouseController.MouseHoverLeave
		End Sub

		Private savedFocus As Control = Nothing

		Public Sub MouseDown(ByVal e As MouseEventArgs) Implements IMouseController.MouseDown

			If e.Button = MouseButtons.Left Then
				If e.Clicks = 1 Then
					' Start automatic scrolling when user drags mouse out of window
					grid.AutoScrolling = ScrollBars.Both

					' 
					Dim rowIndex, colIndex As Integer
					Dim point As Point = New Point(e.X, e.Y)
					grid.PointToRowCol(point, rowIndex, colIndex)
					StartDragAtRowCol(rowIndex, colIndex)

					savedFocus = grid.FindForm().ActiveControl
				End If
			End If

			' DoubleClick
		End Sub





		Private Function GetBounds(ByVal range As GridRangeInfo) As Rectangle
			Dim bounds As Rectangle = grid.RangeInfoToRectangle(range, GridRangeOptions.None)
			bounds.Intersect(grid.ClientRectangle)
			bounds = grid.RectangleToScreen(bounds)
			Return bounds
		End Function

		''' <summary>
		''' User has dragged mouse. If mouse is down, set current position.
		''' </summary>
		''' <param name="e"></param>
		Public Sub MouseMove(ByVal e As MouseEventArgs) Implements IMouseController.MouseMove
			' Set current position
			Dim rowIndex, colIndex As Integer

			Dim point As Point = New Point(e.X, e.Y)
			Try
				grid.PointToRowCol(point, rowIndex, colIndex, 0)
				MoveDragToRowCol(rowIndex, colIndex)
			Catch
			End Try
		End Sub

		''' <summary>
		''' User has release mouse button. Stop automatic scrolling.
		''' </summary>
		''' <param name="e"></param>
		Public Sub MouseUp(ByVal e As MouseEventArgs) Implements IMouseController.MouseUp
			' Stop automatic scrolling 
			grid.AutoScrolling = ScrollBars.None

			Dim rowIndex, colIndex As Integer
			Dim point As Point = New Point(e.X, e.Y)
			grid.PointToRowCol(point, rowIndex, colIndex)

			dragWindow.Visible = False
			dragWindow = Nothing

			PlaceTextInCell(ResetSelectionAfterPlacement)
			grid.FocusOnMouseDown = True
			savedFocus = Nothing
		End Sub



		Public Sub CancelMode() Implements IMouseController.CancelMode
			grid.AutoScrolling = ScrollBars.None
			If Not dragWindow Is Nothing Then
				dragWindow.Visible = False
			End If
			dragWindow = Nothing
			inKeyMove = False
			grid.FocusOnMouseDown = True

			savedFocus = Nothing
		End Sub

		Private Function GetCurrentCell() As GridCurrentCell
			Dim cc As GridCurrentCell = Nothing
			If TypeOf grid.Parent Is SplitterControl Then
				Dim c As Control = (CType(grid.Parent, SplitterControl)).ActivePane
				If TypeOf c Is GridControlBase Then
					cc = (CType(c, GridControlBase)).CurrentCell
				End If
			End If
			If cc Is Nothing Then
				If Not grid.Model.ActiveGridView Is Nothing Then
					cc = grid.Model.ActiveGridView.CurrentCell
				End If
				If cc Is Nothing Then
					cc = grid.CurrentCell
				End If
			End If
			Return cc
		End Function

		Private Function GetTextBox() As TextBoxBase
			If TypeOf savedFocus Is TextBoxBase Then
				Return CType(savedFocus, TextBoxBase)
			ElseIf TypeOf GetCurrentCell().Renderer.Control Is TextBoxBase Then
				Return CType(GetCurrentCell().Renderer.Control, TextBoxBase)
			End If
			Return Nothing
		End Function


		Public Function HitTest(ByVal e As MouseEventArgs, ByVal controller As IMouseController) As Integer Implements IMouseController.HitTest
			grid.FocusOnMouseDown = True ' avoid Focus() being called
			lastHitTestCode = GridHitTestContext.None
			Dim cc As GridCurrentCell = GetCurrentCell()
			If dragWindow Is Nothing Then
				If cc.IsEditing AndAlso TypeOf cc.Renderer Is GridFormulaCellRenderer Then
					Dim ctrl As Boolean = (Control.ModifierKeys And Keys.Control) <> 0

					If e.Button = MouseButtons.Left AndAlso ((Not MouseRequiresControlKey) OrElse ctrl) Then
						Dim point As Point = New Point(e.X, e.Y)
						Dim rowIndex, colIndex As Integer
						grid.PointToRowCol(point, rowIndex, colIndex)

						If rowIndex <> cc.RowIndex OrElse colIndex <> cc.ColIndex Then
							If CanDoSelection(cc) Then
								lastHitTestCode = selectingCellsHitTestCode
								grid.FocusOnMouseDown = False
							End If
						End If

					End If
				End If
			End If
			Return lastHitTestCode
		End Function
		#End Region


	End Class
End Namespace