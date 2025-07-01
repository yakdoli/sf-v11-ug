#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace TableControlEvents
	Public Class EngineEventTracer
		Private groupingEngine As GridEngine
		Private output As ListBox

		Public Sub New(ByVal groupingEngine As GridEngine, ByVal output As ListBox)
			Me.output = output
			Me.groupingEngine = groupingEngine
		End Sub
		Private lastLine As String = ""
		Private Sub AppendOutput(ByVal name As String, ByVal e As EventArgs)

			Dim s As String = name
			Try
				s &= "  " & e.ToString()
			Catch ex As Exception

				s &="  " & "Record deleted: " & ex.InnerException.ToString()
			End Try
			If s.Length > 0 Then
				If s <> lastLine Then
					lastLine = s
					output.SelectedIndex = -1
					output.Items.Add(s)
					output.TopIndex = Math.Max(0, output.Items.Count - (output.Height\output.ItemHeight))
				End If
			End If
		End Sub

		#Region "Hook and Unhook Events"
			Public Sub HookTableStyleEvents()
				AddHandler groupingEngine.TableControl.BackColorChanged, AddressOf TableControl_BackColorChanged
				AddHandler groupingEngine.TableControl.BackgroundImageChanged, AddressOf TableControl_BackgroundImageChanged
				AddHandler groupingEngine.TableControl.BindingContextChanged, AddressOf TableControl_BindingContextChanged
				AddHandler groupingEngine.TableControl.QueryAllowDragColumn, AddressOf TableControl_QueryAllowDragColumn
				AddHandler groupingEngine.TableControl.QueryAllowGroupByColumn, AddressOf TableControl_QueryAllowGroupByColumn
				AddHandler groupingEngine.TableControl.QueryAllowSortColumn, AddressOf TableControl_QueryAllowSortColumn
				AddHandler groupingEngine.TableControl.Resize, AddressOf TableControl_Resize
				AddHandler groupingEngine.TableControl.ResizingColumns, AddressOf TableControl_ResizingColumns
				AddHandler groupingEngine.TableControl.ResizingRows, AddressOf TableControl_ResizingRows
				AddHandler groupingEngine.TableControl.TextChanged, AddressOf TableControl_TextChanged
				AddHandler groupingEngine.TableControl.TopRowChanged, AddressOf TableControl_TopRowChanged
			End Sub

		Public Sub HookCellEvents()
			AddHandler groupingEngine.TableControl.CellButtonClicked, AddressOf TableControl_CellButtonClicked
			AddHandler groupingEngine.TableControl.CellClick, AddressOf TableControl_CellClick
			AddHandler groupingEngine.TableControl.CellDoubleClick, AddressOf TableControl_CellDoubleClick
			AddHandler groupingEngine.TableControl.CellDrawn, AddressOf TableControl_CellDrawn
		End Sub

		Public Sub HookCurrentCellEvents()
			AddHandler groupingEngine.TableControl.CurrentCellActivated, AddressOf TableControl_CurrentCellActivated
			AddHandler groupingEngine.TableControl.CurrentCellChanged, AddressOf TableControl_CurrentCellChanged
			AddHandler groupingEngine.TableControl.CurrentCellControlGotFocus, AddressOf TableControl_CurrentCellControlGotFocus
			AddHandler groupingEngine.TableControl.CurrentCellControlLostFocus, AddressOf TableControl_CurrentCellControlLostFocus
			AddHandler groupingEngine.TableControl.CurrentCellDeactivated, AddressOf TableControl_CurrentCellDeactivated
			AddHandler groupingEngine.TableControl.CurrentCellKeyPress, AddressOf TableControl_CurrentCellKeyPress
			AddHandler groupingEngine.TableControl.CurrentCellStartEditing, AddressOf TableControl_CurrentCellStartEditing
			AddHandler groupingEngine.TableControl.CurrentCellValidated, AddressOf TableControl_CurrentCellValidated
		End Sub
		Public Sub HookGridControlEvents()
			AddHandler groupingEngine.TableControl.Click, AddressOf TableControl_Click
			AddHandler groupingEngine.TableControl.DoubleClick, AddressOf TableControl_DoubleClick
			AddHandler groupingEngine.TableControl.DragDrop, AddressOf TableControl_DragDrop
			AddHandler groupingEngine.TableControl.GotFocus, AddressOf TableControl_GotFocus
			AddHandler groupingEngine.TableControl.GridControlMouseDown, AddressOf TableControl_GridControlMouseDown
			AddHandler groupingEngine.TableControl.GridControlMouseUp, AddressOf TableControl_GridControlMouseUp
			AddHandler groupingEngine.TableControl.HorizontalScroll, AddressOf TableControl_HorizontalScroll
		End Sub
		Public Sub HookKeyEvents()
			AddHandler groupingEngine.TableControl.KeyDown, AddressOf TableControl_KeyDown
			AddHandler groupingEngine.TableControl.KeyPress, AddressOf TableControl_KeyPress
			AddHandler groupingEngine.TableControl.KeyUp, AddressOf TableControl_KeyUp
		End Sub
		Public Sub HookMouseEvents()
			AddHandler groupingEngine.TableControl.MouseDown, AddressOf TableControl_MouseDown
			AddHandler groupingEngine.TableControl.MouseLeave, AddressOf TableControl_MouseLeave
			AddHandler groupingEngine.TableControl.MouseUp, AddressOf TableControl_MouseUp
		End Sub

		Public Sub UnHookEvents()
			RemoveHandler groupingEngine.TableControl.BackColorChanged, AddressOf TableControl_BackColorChanged
			RemoveHandler groupingEngine.TableControl.BackgroundImageChanged, AddressOf TableControl_BackgroundImageChanged
			RemoveHandler groupingEngine.TableControl.BindingContextChanged, AddressOf TableControl_BindingContextChanged
			RemoveHandler groupingEngine.TableControl.CellButtonClicked, AddressOf TableControl_CellButtonClicked
			RemoveHandler groupingEngine.TableControl.CellClick, AddressOf TableControl_CellClick
			RemoveHandler groupingEngine.TableControl.CellDoubleClick, AddressOf TableControl_CellDoubleClick
			RemoveHandler groupingEngine.TableControl.CellDrawn, AddressOf TableControl_CellDrawn
			RemoveHandler groupingEngine.TableControl.Click, AddressOf TableControl_Click
			RemoveHandler groupingEngine.TableControl.CurrentCellActivated, AddressOf TableControl_CurrentCellActivated
			RemoveHandler groupingEngine.TableControl.CurrentCellChanged, AddressOf TableControl_CurrentCellChanged
			RemoveHandler groupingEngine.TableControl.CurrentCellControlGotFocus, AddressOf TableControl_CurrentCellControlGotFocus
			RemoveHandler groupingEngine.TableControl.CurrentCellControlLostFocus, AddressOf TableControl_CurrentCellControlLostFocus
			RemoveHandler groupingEngine.TableControl.CurrentCellDeactivated, AddressOf TableControl_CurrentCellDeactivated
			RemoveHandler groupingEngine.TableControl.CurrentCellKeyPress, AddressOf TableControl_CurrentCellKeyPress
			RemoveHandler groupingEngine.TableControl.CurrentCellStartEditing, AddressOf TableControl_CurrentCellStartEditing
			RemoveHandler groupingEngine.TableControl.CurrentCellValidated, AddressOf TableControl_CurrentCellValidated
			RemoveHandler groupingEngine.TableControl.DoubleClick, AddressOf TableControl_DoubleClick
			RemoveHandler groupingEngine.TableControl.DragDrop, AddressOf TableControl_DragDrop
			RemoveHandler groupingEngine.TableControl.GotFocus, AddressOf TableControl_GotFocus
			RemoveHandler groupingEngine.TableControl.GridControlMouseDown, AddressOf TableControl_GridControlMouseDown
			RemoveHandler groupingEngine.TableControl.GridControlMouseUp, AddressOf TableControl_GridControlMouseUp
			RemoveHandler groupingEngine.TableControl.HorizontalScroll, AddressOf TableControl_HorizontalScroll
			RemoveHandler groupingEngine.TableControl.KeyDown, AddressOf TableControl_KeyDown
			RemoveHandler groupingEngine.TableControl.KeyPress, AddressOf TableControl_KeyPress
			RemoveHandler groupingEngine.TableControl.KeyUp, AddressOf TableControl_KeyUp
			RemoveHandler groupingEngine.TableControl.MouseDown, AddressOf TableControl_MouseDown
			RemoveHandler groupingEngine.TableControl.MouseLeave, AddressOf TableControl_MouseLeave
			RemoveHandler groupingEngine.TableControl.MouseUp, AddressOf TableControl_MouseUp
			RemoveHandler groupingEngine.TableControl.QueryAllowDragColumn, AddressOf TableControl_QueryAllowDragColumn
			RemoveHandler groupingEngine.TableControl.QueryAllowGroupByColumn, AddressOf TableControl_QueryAllowGroupByColumn
			RemoveHandler groupingEngine.TableControl.QueryAllowSortColumn, AddressOf TableControl_QueryAllowSortColumn
			RemoveHandler groupingEngine.TableControl.Resize, AddressOf TableControl_Resize
			RemoveHandler groupingEngine.TableControl.ResizingColumns, AddressOf TableControl_ResizingColumns
			RemoveHandler groupingEngine.TableControl.ResizingRows, AddressOf TableControl_ResizingRows
			RemoveHandler groupingEngine.TableControl.TextChanged, AddressOf TableControl_TextChanged
			RemoveHandler groupingEngine.TableControl.TopRowChanged, AddressOf TableControl_TopRowChanged
		End Sub
#End Region

		Private Sub TableControl_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
				AppendOutput("BackColorChanged",e)
		End Sub

		Private Sub TableControl_BackgroundImageChanged(ByVal sender As Object, ByVal e As EventArgs)
				AppendOutput("BackgroundImageChanged",e)
		End Sub

		Private Sub TableControl_BindingContextChanged(ByVal sender As Object, ByVal e As EventArgs)
				AppendOutput("BindingContextChanged",e)
		End Sub

		Private Sub TableControl_CellButtonClicked(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellButtonClickedEventArgs)
				AppendOutput("CellButtonClicked",e)
		End Sub

		Private Sub TableControl_CellClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs)
				AppendOutput("CellClick",e)
		End Sub

		Private Sub TableControl_CellDoubleClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs)
				AppendOutput("CellDoubleClick",e)
		End Sub

		Private Sub TableControl_CellDrawn(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridDrawCellEventArgs)
				AppendOutput("CellDrawn",e)
		End Sub

		Private Sub TableControl_Click(ByVal sender As Object, ByVal e As EventArgs)
				AppendOutput("Click",e)
		End Sub

		Private Sub TableControl_CurrentCellActivated(ByVal sender As Object, ByVal e As EventArgs)
				AppendOutput("CurrentCellActivated",e)
		End Sub

		Private Sub TableControl_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs)
				AppendOutput("CurrentCellChanged",e)
		End Sub

		Private Sub TableControl_CurrentCellControlGotFocus(ByVal sender As Object, ByVal e As ControlEventArgs)
				AppendOutput("CurrentCellGotFocus",e)
		End Sub

		Private Sub TableControl_CurrentCellControlLostFocus(ByVal sender As Object, ByVal e As ControlEventArgs)
				AppendOutput("CurrentCellLostFocus",e)
		End Sub

		Private Sub TableControl_CurrentCellDeactivated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCurrentCellDeactivatedEventArgs)
				AppendOutput("CurrentCellDeactivated",e)
		End Sub

		Private Sub TableControl_CurrentCellKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
				AppendOutput("CurrentCellKeyPress",e)
		End Sub

		Private Sub TableControl_CurrentCellStartEditing(ByVal sender As Object, ByVal e As CancelEventArgs)
			AppendOutput("CurrentCellStartEditing",e)

		End Sub

		Private Sub TableControl_CurrentCellValidated(ByVal sender As Object, ByVal e As EventArgs)
			AppendOutput("CurrentCellValidated",e)
		End Sub

		Private Sub TableControl_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			AppendOutput("DoubleClick",e)
		End Sub

		Private Sub TableControl_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
			AppendOutput("DragDrop",e)

		End Sub

		Private Sub TableControl_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
			AppendOutput("GotFocus",e)
		End Sub

		Private Sub TableControl_GridControlMouseDown(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.CancelMouseEventArgs)
			AppendOutput("GridControlMouseDown",e)
		End Sub

		Private Sub TableControl_GridControlMouseUp(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.CancelMouseEventArgs)
			AppendOutput("GridControlMouseUp",e)
		End Sub

		Private Sub TableControl_HorizontalScroll(ByVal sender As Object, ByVal e As ScrollEventArgs)
			AppendOutput("HorizontalScroll",e)
		End Sub

		Private Sub TableControl_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			AppendOutput("KeyDown",e)
		End Sub

		Private Sub TableControl_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
			AppendOutput("KeyPress",e)
		End Sub

		Private Sub TableControl_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
			AppendOutput("KeyUp",e)
		End Sub

		Private Sub TableControl_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			AppendOutput("MouseDown",e)
		End Sub

		Private Sub TableControl_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			AppendOutput("MouseLeave",e)
		End Sub

		Private Sub TableControl_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			AppendOutput("MouseUp",e)
		End Sub

		Private Sub TableControl_QueryAllowDragColumn(ByVal sender As Object, ByVal e As GridQueryAllowDragColumnEventArgs)
			AppendOutput("QueryAllowDragColumn",e)
		End Sub

		Private Sub TableControl_QueryAllowGroupByColumn(ByVal sender As Object, ByVal e As GridQueryAllowGroupByColumnEventArgs)
			AppendOutput("QueryAllowGroupByColumn",e)
		End Sub

		Private Sub TableControl_QueryAllowSortColumn(ByVal sender As Object, ByVal e As GridQueryAllowSortColumnEventArgs)
			AppendOutput("QueryAllowSortColumn",e)
		End Sub

		Private Sub TableControl_Resize(ByVal sender As Object, ByVal e As EventArgs)
			AppendOutput("Resize",e)
		End Sub

		Private Sub TableControl_ResizingColumns(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridResizingColumnsEventArgs)
			AppendOutput("ResizingColumns",e)
		End Sub

		Private Sub TableControl_ResizingRows(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridResizingRowsEventArgs)
			AppendOutput("ResizingRows",e)
		End Sub

		Private Sub TableControl_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			AppendOutput("TextChanged",e)
		End Sub

		Private Sub TableControl_TopRowChanged(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridRowColIndexChangedEventArgs)
			AppendOutput("TopRowChanged",e)
		End Sub
	End Class
End Namespace
