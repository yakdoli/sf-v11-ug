Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Re-distribution in any form is strictly
'  prohibited. Any infringement will be prosecuted under applicable laws. 
'
#End Region

Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Imports Syncfusion.Diagnostics
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace ExcelToolTip
	#Region "Mouse Controller For ToolTip"
	''' <summary>
	''' Summary description for CommentMouseController.
	''' </summary>
	Public Class CommentMouseController
		Implements IMouseController
		Private Const redCornerSize As Integer = 10
		Private Const blackArrowSize As Integer = 5

		Private owner As GridControlBase
		Private lastHitTestCode As Integer = GridHitTestContext.None
		Private Const HitComment As Integer = 101

		Private commentWindow As GridCellComment
		Private cornerSize As Integer = 8
		Private redrawRect As Rectangle = Rectangle.Empty

		Private cursor1 As Cursor
		Private commentRow As Integer
		Private commentCol As Integer

		Private contextMenuEnabled1 As Boolean
		Public Property ContextMenuEnabled() As Boolean
			Get
				Return contextMenuEnabled1
			End Get
			Set(ByVal value As Boolean)
				If value <> contextMenuEnabled1 Then
					contextMenuEnabled1 = value
					If contextMenuEnabled1 Then
						AddHandler owner.MouseUp, AddressOf grid_ContextMouseUp
					Else
						RemoveHandler owner.MouseUp, AddressOf grid_ContextMouseUp
					End If
				End If
			End Set
		End Property

		Private cornerBrush1 As Brush
		Public Property CornerBrush() As Brush
			Get
				Return cornerBrush1
			End Get
			Set(ByVal value As Brush)
				cornerBrush1 = value
			End Set
		End Property

		Public Property CommentCornerSize() As Integer
			Get
				Return cornerSize
			End Get
			Set(ByVal value As Integer)
				cornerSize = value
			End Set
		End Property

		Private comments As Hashtable
		Public Sub New(ByVal owner As GridControlBase, ByVal comments As Hashtable)
			Me.comments = comments
			IntializeControl(owner)
		End Sub

		Public Sub New(ByVal owner As GridControlBase)
			Me.comments = New Hashtable()
			IntializeControl(owner)
		End Sub

		Private Sub IntializeControl(ByVal owner As GridControlBase)
			Me.owner = owner
			commentWindow = New GridCellComment()
			commentWindow.CommentCorner = New Size(0, 0)
			owner.Controls.Add(commentWindow)

			AddHandler owner.CellDrawn, AddressOf grid_CellDrawn

			AddHandler owner.TopRowChanging, AddressOf grid_Scrolling
			AddHandler owner.LeftColChanging, AddressOf grid_Scrolling
			AddHandler owner.MouseDown, AddressOf grid_MouseDown

			AddHandler owner.CellMouseHover, AddressOf owner_CellMouseHover
			AddHandler owner.CellMouseHoverLeave, AddressOf owner_CellMouseHoverLeave

			cornerBrush1 = Brushes.Red 'default color

		End Sub


		Private Sub owner_CellMouseHoverLeave(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
			MouseHoverLeave(EventArgs.Empty)
		End Sub

		Private Sub owner_CellMouseHover(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
			MouseHover(e.MouseEventArgs)
		End Sub



		Public ReadOnly Property Name() As String Implements IMouseController.Name
			Get
				Return "Comment"
			End Get
		End Property

		Public ReadOnly Property Cursor() As Cursor Implements IMouseController.Cursor
			Get
				If cursor1 Is Nothing Then
					Dim stream As System.IO.Stream = commentWindow.GetType().Module.Assembly.GetManifestResourceStream("ExcelTip.cross.CUR")
					If stream IsNot Nothing Then
						cursor1 = New Cursor(stream)
					Else
						cursor1 = Nothing
					End If
				End If

				' could check latestHitTestCode here if this controller has
				' different HitTest states. Cursor will only be called if 
				' previous call to HitTest was successfull.
				Return cursor1
			End Get
		End Property

		#Region "Context Menu Code"

		Private theContextMenu As ContextMenu
		Private rightClickRow, rightClickCol As Integer
		Private leftClickOnMark As Boolean = False
		Private Sub grid_ContextMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			If e.Button = MouseButtons.Right OrElse leftClickOnMark Then
				Dim pt As New Point(e.X, e.Y)
				If Me.owner.PointToRowCol(pt, rightClickRow, rightClickCol) Then
					Dim menu As MenuItem

					If isExcelTipCell(rightClickRow, rightClickCol) Then
						menu = New MenuItem("Remove Comment", New EventHandler(AddressOf remove_Comment))
						Dim menu1 As New MenuItem("Edit Comment", New EventHandler(AddressOf edit_Comment))
						theContextMenu = New ContextMenu(New MenuItem() {menu, menu1})
					Else
						menu = New MenuItem("Add Comment", New EventHandler(AddressOf add_Comment))
						theContextMenu = New ContextMenu(New MenuItem() { menu })
					End If
					Dim key As String= GetKey(rightClickRow, rightClickCol)
					If key IsNot Nothing Then
						theContextMenu.Show(Me.owner, pt)
					End If
				End If
			End If
			leftClickOnMark = False
		End Sub

		Private Sub edit_Comment(ByVal sender As Object, ByVal e As EventArgs)
			StartEditing()
		End Sub

		Private Function GetKey(ByVal row As Integer, ByVal col As Integer) As String
			Dim sty As GridTableCellStyleInfo = TryCast(Me.owner.Model(row, col), GridTableCellStyleInfo)
			If sty.TableCellIdentity.DisplayElement.Kind = Syncfusion.Grouping.DisplayElementKind.Record Then
				If sty.TableCellIdentity.Column IsNot Nothing Then
                    Return sty.TableCellIdentity.DisplayElement.GetRecord().Id.ToString() + sty.TableCellIdentity.Column.Name
				End If
			End If
			Return Nothing
		End Function

		Private Sub StartEditing()
			Dim key As String = GetKey(rightClickRow, rightClickCol)
			Dim text As String
			If comments.Contains(key) Then
				text = comments(key).ToString()
			Else
				text = ""
				comments.Add(key,text)
			End If

			Dim rect As Rectangle = Me.owner.RangeInfoToRectangle(GridRangeInfo.Cell(rightClickRow, rightClickCol))

			Dim pt As New Point(rect.X, rect.Y)

			pt.X += Me.owner.Model.ColWidths(rightClickCol)

			If Me.owner.ClientRectangle.Width > pt.X Then
				Me.commentWindow.InitializeComment(rightClickRow, rightClickCol, pt, text)
			Else
				pt.X = pt.X - 100
				Me.commentWindow.InitializeComment(rightClickRow, rightClickCol, pt, text)
			End If

			EditComment(rightClickRow, rightClickCol)
		End Sub

		Private Sub add_Comment(ByVal sender As Object, ByVal e As EventArgs)
			StartEditing()
		End Sub

		Private Sub remove_Comment(ByVal sender As Object, ByVal e As EventArgs)
			Dim key As String = GetKey(rightClickRow, rightClickCol)
			comments.Remove(key)
			owner.Refresh()
		End Sub
		#End Region

		#Region "Mouse Overrides"
		Public Sub MouseHoverEnter() Implements IMouseController.MouseHoverEnter

		End Sub

		'private bool inDraw = false;
		''' <summary>
		''' User is moving the mouse over the hot-test area
		''' </summary>
		''' <param name="e"></param>
		Public Sub MouseHover(ByVal e As MouseEventArgs) Implements IMouseController.MouseHover
			If lastHitTestCode = GridHitTestContext.None Then
				Return
			End If


			If Not Me.commentWindow.Visible Then ' && !inDraw)
				'translate the point to top right corner...
				Dim rowIndex, colIndex As Integer
				Dim pt As New Point(e.X, e.Y)


				owner.PointToRowCol(pt, rowIndex, colIndex, -1)
					Dim hidden As Boolean
					Dim clientRow As Integer = owner.ViewLayout.RowIndexToVisibleClient(rowIndex, hidden)
					Dim clientCol As Integer = owner.ViewLayout.ColIndexToVisibleClient(colIndex, hidden)
					pt = owner.ViewLayout.ClientRowColToPoint(clientRow, clientCol, GridCellSizeKind.ActualSize)

					pt.X += owner.Model.ColWidths(colIndex)



					Dim key As String = GetKey(rowIndex, colIndex)
					Dim text As String = comments(key).ToString()
					Me.commentWindow.InitializeComment(rowIndex, colIndex, pt, text)
					Dim ploc As Point = Me.commentWindow.Location
					Me.commentWindow.Location = New Point(10000, 10000)
					Me.commentWindow.comment.Visible = True
					Me.commentWindow.editTextBox.Visible = False

					'show the windows
					Me.commentWindow.Show()
					Me.commentWindow.Update()
					Me.owner.Update()

					'draw the pointer
					Dim g As Graphics = Graphics.FromHwnd(Me.owner.Handle)
					Dim pt1 As New Point(pt.X + Me.commentWindow.CommentCorner.Width, pt.Y - Me.commentWindow.CommentCorner.Height)
					redrawRect = New Rectangle(pt.X, pt.Y - Me.commentWindow.CommentCorner.Height, Me.commentWindow.CommentCorner.Width + 1, Me.commentWindow.CommentCorner.Height + 1)
					g.DrawLine(Pens.Black, pt, pt1)
					Dim topLeft As New Point(pt.X, pt.Y - blackArrowSize + 1)
					Dim bottomLeft As New Point(pt.X, pt.Y + 1)
					Dim bottomRight As New Point(pt.X + blackArrowSize - 1, pt.Y + 1)
					g.FillPolygon(Brushes.Black, New Point() { topLeft, bottomLeft, bottomRight, topLeft })
					g.Dispose()

					If Me.owner.ClientRectangle.Width < ploc.X Then
						ploc.X = ploc.X - 100
					End If

					Me.commentWindow.Location = ploc

			End If
		End Sub

		''' <summary>
		''' Called when the hovering ends, either when user has moved mouse away from hittest area
		''' or when the user has pressed a mouse button.
		''' </summary>
		Public Sub MouseHoverLeave(ByVal e As EventArgs) Implements IMouseController.MouseHoverLeave
			If Me.commentWindow.comment.Visible Then
				Me.commentWindow.Hide()
				Me.owner.Invalidate(redrawRect)
			End If
		End Sub

		Public Sub MouseDown(ByVal e As MouseEventArgs) Implements IMouseController.MouseDown
		End Sub

		''' <summary>
		''' User has dragged mouse. If mouse is down, set current position.
		''' </summary>
		''' <param name="e"></param>
		Public Sub MouseMove(ByVal e As MouseEventArgs) Implements IMouseController.MouseMove

		End Sub

		''' <summary>
		''' User has release mouse button. Stop automatic scrolling.
		''' </summary>
		''' <param name="e"></param>
		Public Sub MouseUp(ByVal e As MouseEventArgs) Implements IMouseController.MouseUp
			If e.Button = MouseButtons.Left Then
				leftClickOnMark = True
				grid_ContextMouseUp(owner, e)
			End If
		End Sub

		#End Region

		Public Sub CancelMode() Implements IMouseController.CancelMode
			If Me.commentWindow.Visible Then
				Me.commentWindow.Hide()
				Me.owner.Invalidate(redrawRect)
			End If
		End Sub

		Public Function HitTest(ByVal e As MouseEventArgs, ByVal controller As IMouseController) As Integer Implements IMouseController.HitTest
			lastHitTestCode = GridHitTestContext.None

			Dim pt As New Point(e.X, e.Y)
			Dim rowIndex, colIndex As Integer
			owner.PointToRowCol(pt, rowIndex, colIndex)
			Dim rect As Rectangle = GetCorner(rowIndex, colIndex)
			Console.WriteLine("{0}   {1}   {2}", rect, pt, rect.Contains(pt))
			If rect.Contains(pt) AndAlso (Not Me.commentWindow.editTextBox.Visible) Then
				If isExcelTipCell(rowIndex, colIndex) Then
					lastHitTestCode = HitComment
				End If
			End If

			Return lastHitTestCode
		End Function

		Private Function GetCorner(ByVal row As Integer, ByVal col As Integer) As Rectangle
			Dim bounds As Rectangle = owner.RangeInfoToRectangle(GridRangeInfo.Cell(row, col), GridRangeOptions.None)
			bounds = New Rectangle(bounds.X + bounds.Width - Me.CommentCornerSize - 1, bounds.Y, Me.CommentCornerSize, Me.CommentCornerSize)
			bounds.Intersect(owner.ClientRectangle)
			Return bounds
		End Function

		Private Function isExcelTipCell(ByVal rowIndex As Integer, ByVal colIndex As Integer) As Boolean
			Dim key As String = GetKey(rowIndex, colIndex)
			If key Is Nothing Then
				Return False
			End If
			If Not comments.Contains(key) Then
				Return False
			End If
			Return True
		End Function

		Private Sub grid_CellDrawn(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
			If isExcelTipCell(e.RowIndex, e.ColIndex) AndAlso ((Not Me.owner.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex)) OrElse (Not Me.owner.CurrentCell.IsEditing)) Then
				Dim topLeft As New Point(e.Bounds.X + e.Bounds.Width - CommentCornerSize, e.Bounds.Y)
				Dim topRight As New Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y)
				Dim bottomRight As New Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y + CommentCornerSize)
				e.Graphics.FillPolygon(cornerBrush1, New Point(){topLeft, topRight, bottomRight, topLeft})
			End If
		End Sub

		#Region "Comment Edit Code"

		Private Sub EditComment(ByVal row As Integer, ByVal col As Integer)
			commentRow = row
			commentCol = col

			Dim pt As Point = Me.commentWindow.comment.Location
			pt.Offset(5, 5)
			Me.commentWindow.editTextBox.Location = pt

			Me.commentWindow.editTextBox.Size = Me.commentWindow.comment.Size - New Size(5, 5)
			'this.commentWindow.Show();
			Me.commentWindow.comment.Hide()

			'make sure there is space for some more lines...
			Dim diff As Integer = Math.Max(Me.commentWindow.Height, 60) - Me.commentWindow.Height
			If diff > 0 Then
				Me.commentWindow.Height += diff
				Me.commentWindow.editTextBox.Height += diff
			End If

			'make wide enough
			Me.commentWindow.editTextBox.Width = Math.Max(Me.commentWindow.Width - 10, Me.commentWindow.editTextBox.Width)

			Me.commentWindow.editTextBox.Show()
			Me.commentWindow.ActiveControl = Me.commentWindow.editTextBox

			AddHandler commentWindow.Leave, AddressOf textBox_Leave
			AddHandler commentWindow.editTextBox.TextChanged, AddressOf textbox_Changed

			Me.commentWindow.Show()
			Me.commentWindow.editTextBox.Focus()
			Me.owner.WantKeys = False
		End Sub


		Private Sub textBox_Leave(ByVal sender As Object, ByVal e As EventArgs)
			If Me.commentWindow.editTextBox.Modified Then
				Dim key As String = GetKey(commentRow, commentCol)
				comments(key) = Me.commentWindow.editTextBox.Text
				Me.commentWindow.editTextBox.Modified = False
			End If

			RemoveHandler commentWindow.Leave, AddressOf textBox_Leave
			RemoveHandler commentWindow.editTextBox.TextChanged, AddressOf textbox_Changed

			Me.commentWindow.editTextBox.Hide()
			Me.commentWindow.Hide()
			Me.owner.Invalidate(redrawRect)
			Me.owner.WantKeys = True
		End Sub
		Private Sub textbox_Changed(ByVal sender As Object, ByVal e As EventArgs)
			Me.commentWindow.editTextBox.Modified = True
		End Sub

		Private Sub grid_Scrolling(ByVal sender As Object, ByVal e As GridRowColIndexChangingEventArgs)
			Me.CancelMode()
		End Sub

		Private Sub grid_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim rowIndex, colIndex As Integer
			owner.PointToRowCol(New Point(e.X, e.Y), rowIndex, colIndex)
			If (rowIndex <> Me.commentRow OrElse colIndex <> Me.commentRow) AndAlso Me.commentWindow.editTextBox.Visible Then
				textBox_Leave(sender, e)
			End If
		End Sub
		#End Region    
	End Class
	#End Region    
End Namespace