Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Diagnostics
Imports ComboboxCells

Namespace GridSample
	''' <summary>
	''' Summary description for CurrentCellEventTracer.
	''' </summary>
	Public Class CurrentCellEventTracer
		Private _splitter As SplitterControl
		Private _displayMouseMessage As Boolean = False
		Private traceDebug As Boolean = False
		Public count As Integer = 1
		Private etracer As EventTracer
		Public Sub New(ByVal splitter As SplitterControl, ByVal output As EventTracer)
			Me._splitter = splitter
			Me.etracer = output
			AddHandler splitter.PaneCreated, AddressOf splitter_PaneCreated
			AddHandler splitter.PaneClosing, AddressOf splitter_PaneClosing
			WireGrid(TryCast(splitter.ActivePane, GridControl))
		End Sub

		Public Sub WireGrid(ByVal grid As GridControl)
			AddHandler grid.AccelerateScrollingChanged, AddressOf grid_AccelerateScrollingChanged
			'grid.ActivateToolTip += new GridActivateToolTipEventHandler(grid_ActivateToolTip);
			AddHandler grid.AutoScrollingChanged, AddressOf grid_AutoScrollingChanged
			AddHandler grid.BackColorChanged, AddressOf grid_BackColorChanged
			AddHandler grid.BackgroundImageChanged, AddressOf grid_BackgroundImageChanged
			AddHandler grid.BackgroundImageLayoutChanged, AddressOf grid_BackgroundImageLayoutChanged
			AddHandler grid.BanneredRangesChanged, AddressOf grid_BanneredRangesChanged
			AddHandler grid.BanneredRangesChanging, AddressOf grid_BanneredRangesChanging
			AddHandler grid.BaseStylesMapChanged, AddressOf grid_BaseStylesMapChanged
			AddHandler grid.BeginUpdateRequest, AddressOf grid_BeginUpdateRequest
			AddHandler grid.BindingContextChanged, AddressOf grid_BindingContextChanged
			AddHandler grid.CancelMode, AddressOf grid_CancelMode
			AddHandler grid.CausesValidationChanged, AddressOf grid_CausesValidationChanged
			AddHandler grid.CellCancelMode, AddressOf grid_CellCancelMode
			'grid.CellCursor += new GridCellCursorEventHandler(grid_CellCursor);
			'grid.CellDrawn += new GridDrawCellEventHandler(grid_CellDrawn);
			'grid.CellHitTest += new GridCellHitTestEventHandler(grid_CellHitTest);
			AddHandler grid.CellModelsChanged, AddressOf grid_CellModelsChanged
			AddHandler grid.CellMouseHover, AddressOf grid_CellMouseHover
			AddHandler grid.CellMouseMove, AddressOf grid_CellMouseMove
			AddHandler grid.CellsChanged, AddressOf grid_CellsChanged
			AddHandler grid.CellsChanging, AddressOf grid_CellsChanging
			AddHandler grid.ChangeUICues, AddressOf grid_ChangeUICues
			AddHandler grid.ClearingCells, AddressOf grid_ClearingCells
			AddHandler grid.ClientSizeChanged, AddressOf grid_ClientSizeChanged
			AddHandler grid.ClipboardCanCopy, AddressOf grid_ClipboardCanCopy
			AddHandler grid.ClipboardCanCut, AddressOf grid_ClipboardCanCut
			AddHandler grid.ClipboardCanPaste, AddressOf grid_ClipboardCanPaste
			AddHandler grid.ClipboardCopy, AddressOf grid_ClipboardCopy
			AddHandler grid.ClipboardCut, AddressOf grid_ClipboardCut
			AddHandler grid.ClipboardPaste, AddressOf grid_ClipboardPaste
			AddHandler grid.ColsHidden, AddressOf grid_ColsHidden
			AddHandler grid.ColsHiding, AddressOf grid_ColsHiding
			AddHandler grid.ColsInserted, AddressOf grid_ColsInserted
			AddHandler grid.ColsMoved, AddressOf grid_ColsMoved
			AddHandler grid.ColsMoving, AddressOf grid_ColsMoving
			AddHandler grid.ColsRemoved, AddressOf grid_ColsRemoved
			AddHandler grid.ColsRemoving, AddressOf grid_ColsRemoving
			AddHandler grid.ColWidthsChanged, AddressOf grid_ColWidthsChanged
			AddHandler grid.ColWidthsChanging, AddressOf grid_ColWidthsChanging
			AddHandler grid.ConfirmingPendingChanges, AddressOf grid_ConfirmingPendingChanges
			AddHandler grid.ContextMenuChanged, AddressOf grid_ContextMenuChanged
			AddHandler grid.ContextMenuStripChanged, AddressOf grid_ContextMenuStripChanged
			AddHandler grid.ControlAdded, AddressOf grid_ControlAdded
			AddHandler grid.ControllerOptionsChanged, AddressOf grid_ControllerOptionsChanged
			AddHandler grid.ControlRemoved, AddressOf grid_ControlRemoved
			AddHandler grid.CoveredRangesChanged, AddressOf grid_CoveredRangesChanged
			AddHandler grid.CoveredRangesChanging, AddressOf grid_CoveredRangesChanging
			AddHandler grid.CurrentCellControlKeyMessage, AddressOf grid_CurrentCellControlKeyMessage
			AddHandler grid.CurrentCellErrorMessage, AddressOf grid_CurrentCellErrorMessage
			AddHandler grid.CursorChanged, AddressOf grid_CursorChanged
			AddHandler grid.CurrentCellAcceptedChanges, AddressOf grid_CurrentCellAcceptedChanges
			AddHandler grid.CurrentCellMoved, AddressOf grid_CurrentCellMoved
			AddHandler grid.CurrentCellActivateFailed, AddressOf grid_CurrentCellActivateFailed
			AddHandler grid.CurrentCellActivated, AddressOf grid_CurrentCellActivated
			AddHandler grid.CurrentCellActivating, AddressOf grid_CurrentCellActivating
			AddHandler grid.CurrentCellChanged, AddressOf grid_CurrentCellChanged
			AddHandler grid.CurrentCellChanging, AddressOf grid_CurrentCellChanging
			AddHandler grid.CurrentCellCloseDropDown, AddressOf grid_CurrentCellCloseDropDown
			AddHandler grid.CurrentCellConfirmChangesFailed, AddressOf grid_CurrentCellConfirmChangesFailed
			AddHandler grid.CurrentCellControlGotFocus, AddressOf grid_CurrentCellControlGotFocus
			AddHandler grid.CurrentCellControlLostFocus, AddressOf grid_CurrentCellControlLostFocus
			AddHandler grid.CurrentCellDeactivated, AddressOf grid_CurrentCellDeactivated
			AddHandler grid.CurrentCellDeactivateFailed, AddressOf grid_CurrentCellDeactivateFailed
			AddHandler grid.CurrentCellDeactivating, AddressOf grid_CurrentCellDeactivating
			AddHandler grid.CurrentCellDeleting, AddressOf grid_CurrentCellDeleting
			AddHandler grid.CurrentCellEditingComplete, AddressOf grid_CurrentCellEditingComplete
			AddHandler grid.CurrentCellInitializeControlText, AddressOf grid_CurrentCellInitializeControlText
			AddHandler grid.CurrentCellKeyDown, AddressOf grid_CurrentCellKeyDown
			AddHandler grid.CurrentCellKeyPress, AddressOf grid_CurrentCellKeyPress
			AddHandler grid.CurrentCellKeyUp, AddressOf grid_CurrentCellKeyUp
			AddHandler grid.CurrentCellMoved, AddressOf grid_CurrentCellMoved
			AddHandler grid.CurrentCellMoveFailed, AddressOf grid_CurrentCellMoveFailed
			AddHandler grid.CurrentCellMoving, AddressOf grid_CurrentCellMoving
			AddHandler grid.CurrentCellRejectedChanges, AddressOf grid_CurrentCellRejectedChanges
			AddHandler grid.CurrentCellShowedDropDown, AddressOf grid_CurrentCellShowedDropDown
			AddHandler grid.CurrentCellShowingDropDown, AddressOf grid_CurrentCellShowingDropDown
			AddHandler grid.CurrentCellStartEditing, AddressOf grid_CurrentCellStartEditing
			AddHandler grid.CurrentCellValidated, AddressOf grid_CurrentCellValidated
			AddHandler grid.CurrentCellValidateString, AddressOf grid_CurrentCellValidateString
			AddHandler grid.CurrentCellValidating, AddressOf grid_CurrentCellValidating
			AddHandler grid.CurrentCellControlDoubleClick, AddressOf grid_CurrentCellControlDoubleClick

			' Mouse events
			AddHandler grid.CellButtonClicked, AddressOf grid_CellButtonClicked
			AddHandler grid.CellClick, AddressOf grid_CellClick
			AddHandler grid.CellDoubleClick, AddressOf grid_CellDoubleClick
			AddHandler grid.CellMouseDown, AddressOf grid_CellMouseDown
			AddHandler grid.CellMouseHoverEnter, AddressOf grid_CellMouseHoverEnter
			AddHandler grid.CellMouseHoverLeave, AddressOf grid_CellMouseHoverLeave
			AddHandler grid.CellMouseUp, AddressOf grid_CellMouseUp
			AddHandler grid.CheckBoxClick, AddressOf grid_CheckBoxClick
			AddHandler grid.PushButtonClick, AddressOf grid_PushButtonClick

			' Other events
			AddHandler grid.Click, AddressOf grid_Click
			AddHandler grid.DataChanged, AddressOf grid_DataChanged
			AddHandler grid.DataObjectConsumerOptionsChanged, AddressOf grid_DataObjectConsumerOptionsChanged
			AddHandler grid.DefaultColWidthChanged, AddressOf grid_DefaultColWidthChanged
			'grid.DrawCell += new GridDrawCellEventHandler(grid_DrawCell);
			AddHandler grid.DefaultColWidthChanging, AddressOf grid_DefaultColWidthChanging
			AddHandler grid.DefaultRowHeightChanged, AddressOf grid_DefaultRowHeightChanged
			AddHandler grid.DefaultRowHeightChanging, AddressOf grid_DefaultRowHeightChanging
			AddHandler grid.Disposed, AddressOf grid_Disposed
			AddHandler grid.DockChanged, AddressOf grid_DockChanged
			AddHandler grid.DrawCellBackground, AddressOf grid_DrawCellBackground
			AddHandler grid.DrawCellButton, AddressOf grid_DrawCellButton
			AddHandler grid.DrawCellButtonBackground, AddressOf grid_DrawCellButtonBackground
			AddHandler grid.DrawCellDisplayText, AddressOf grid_DrawCellDisplayText
			AddHandler grid.DrawCellFrameAppearance, AddressOf grid_DrawCellFrameAppearance
			AddHandler grid.DrawCurrentCellBorder, AddressOf grid_DrawCurrentCellBorder
			AddHandler grid.Deactivated, AddressOf grid_Deactivated
			AddHandler grid.DoubleClick, AddressOf grid_DoubleClick
			AddHandler grid.DragDrop, AddressOf grid_DragDrop
			AddHandler grid.DragEnter, AddressOf grid_DragEnter
			AddHandler grid.DragLeave, AddressOf grid_DragLeave
			AddHandler grid.DragOver, AddressOf grid_DragOver
			AddHandler grid.EnabledChanged, AddressOf grid_EnabledChanged
			AddHandler grid.EndUpdateRequest, AddressOf grid_EndUpdateRequest
			AddHandler grid.Enter, AddressOf grid_Enter
			AddHandler grid.FileNameChanged, AddressOf grid_FileNameChanged
			AddHandler grid.FillRectangleHook, AddressOf grid_FillRectangleHook
			AddHandler grid.FillSplitterPaneChanged, AddressOf grid_FillSplitterPaneChanged
			AddHandler grid.FloatingCellsChanged, AddressOf grid_FloatingCellsChanged
			AddHandler grid.FontChanged, AddressOf grid_FontChanged
			AddHandler grid.ForeColorChanged, AddressOf grid_ForeColorChanged
			AddHandler grid.FrozenColCountChanged, AddressOf grid_FrozenColCountChanged
			AddHandler grid.FrozenColCountChanging, AddressOf grid_FrozenColCountChanging
			AddHandler grid.FrozenRowCountChanged, AddressOf grid_FrozenRowCountChanged
			AddHandler grid.FrozenRowCountChanging, AddressOf grid_FrozenRowCountChanging
			AddHandler grid.GiveFeedback, AddressOf grid_GiveFeedback
			AddHandler grid.GridBoundsChanged, AddressOf grid_GridBoundsChanged
			AddHandler grid.GridControlMouseDown, AddressOf grid_GridControlMouseDown
			AddHandler grid.GridControlMouseMove, AddressOf grid_GridControlMouseMove
			AddHandler grid.GridControlMouseUp, AddressOf grid_GridControlMouseUp
			AddHandler grid.GotFocus, AddressOf grid_GotFocus
			AddHandler grid.HandleCreated, AddressOf grid_HandleCreated
			AddHandler grid.HandleDestroyed, AddressOf grid_HandleDestroyed
			AddHandler grid.HeaderColCountChanged, AddressOf grid_HeaderColCountChanged
			AddHandler grid.HeaderColCountChanging, AddressOf grid_HeaderColCountChanging
			AddHandler grid.HeaderRowCountChanged, AddressOf grid_HeaderRowCountChanged
			AddHandler grid.HeaderRowCountChanging, AddressOf grid_HeaderRowCountChanging
			AddHandler grid.HelpRequested, AddressOf grid_HelpRequested
			AddHandler grid.HorizontalScroll, AddressOf grid_HorizontalScroll
			AddHandler grid.HScrollPixelPosChanged, AddressOf grid_HScrollPixelPosChanged
			AddHandler grid.HScrollPixelPosChanging, AddressOf grid_HScrollPixelPosChanging
			AddHandler grid.ImeModeChanged, AddressOf grid_ImeModeChanged
			AddHandler grid.IntelliMouseDragScrolling, AddressOf grid_IntelliMouseDragScrolling
			AddHandler grid.Invalidated, AddressOf grid_Invalidated
			AddHandler grid.KeyDown, AddressOf grid_KeyDown
			AddHandler grid.KeyPress, AddressOf grid_KeyPress
			AddHandler grid.KeyUp, AddressOf grid_KeyUp
			AddHandler grid.LeftColChanged, AddressOf grid_LeftColChanged
			AddHandler grid.LeftColChanging, AddressOf grid_LeftColChanging
			AddHandler grid.LocationChanged, AddressOf grid_LocationChanged
			AddHandler grid.Layout, AddressOf grid_Layout
			AddHandler grid.Leave, AddressOf grid_Leave
			AddHandler grid.LostFocus, AddressOf grid_LostFocus
			AddHandler grid.MouseDown, AddressOf grid_MouseDown
			AddHandler grid.MouseUp, AddressOf grid_MouseUp
			AddHandler grid.MouseEnter, AddressOf grid_MouseEnter
			AddHandler grid.MouseLeave, AddressOf grid_MouseLeave
			AddHandler grid.MarginChanged, AddressOf grid_MarginChanged
			AddHandler grid.MergeCellsChanged, AddressOf grid_MergeCellsChanged
			AddHandler grid.ModelChanged, AddressOf grid_ModelChanged
			AddHandler grid.ModifiedChanged, AddressOf grid_ModifiedChanged
			AddHandler grid.MouseActivating, AddressOf grid_MouseActivating
			AddHandler grid.MouseCaptureChanged, AddressOf grid_MouseCaptureChanged
			AddHandler grid.MouseClick, AddressOf grid_MouseClick
			AddHandler grid.MouseHover, AddressOf grid_MouseHover
			AddHandler grid.MouseMove, AddressOf grid_MouseMove
			AddHandler grid.MouseWheel, AddressOf grid_MouseWheel
			AddHandler grid.MouseWheelZoom, AddressOf grid_MouseWheelZoom
			AddHandler grid.Move, AddressOf grid_Move
			AddHandler grid.MoveCurrentCellDirection, AddressOf grid_MoveCurrentCellDirection
			AddHandler grid.Office2007ScrollBarsChanged, AddressOf grid_Office2007ScrollBarsChanged
			AddHandler grid.Office2007ScrollBarsColorSchemeChanged, AddressOf grid_Office2007ScrollBarsColorSchemeChanged
			AddHandler grid.OperationFeedback, AddressOf grid_OperationFeedback
			AddHandler grid.OperationFeedback, AddressOf grid_OperationFeedback
			AddHandler grid.PaddingChanged, AddressOf grid_PaddingChanged
			AddHandler grid.ParentChanged, AddressOf grid_ParentChanged
			AddHandler grid.ParseCommonFormats, AddressOf grid_ParseCommonFormats
			AddHandler grid.PasteCellText, AddressOf grid_PasteCellText
			AddHandler grid.PrepareChangeSelection, AddressOf grid_PrepareChangeSelection
			AddHandler grid.PrepareClearSelection, AddressOf grid_PrepareClearSelection
			AddHandler grid.PrepareGraphics, AddressOf grid_PrepareGraphics
			'grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(grid_PrepareViewStyleInfo);
			AddHandler grid.PreviewKeyDown, AddressOf grid_PreviewKeyDown
			AddHandler grid.PrintingModeChanged, AddressOf grid_PrintingModeChanged

			'grid.QueryBanneredRange += new GridQueryBanneredRangeEventHandler(grid_QueryBanneredRange);
			'grid.QueryCellInfo += new GridQueryCellInfoEventHandler(grid_QueryCellInfo);
			'grid.QueryColWidth += new GridRowColSizeEventHandler(grid_QueryColWidth);
			'grid.QueryCoveredRange += new GridQueryCoveredRangeEventHandler(grid_QueryCoveredRange);
			'grid.QueryRowHeight += new GridRowColSizeEventHandler(grid_QueryRowHeight);
			AddHandler grid.ReadOnlyChanged, AddressOf grid_ReadOnlyChanged
			AddHandler grid.RefreshRequest, AddressOf grid_RefreshRequest
			AddHandler grid.RegionChanged, AddressOf grid_RegionChanged
			AddHandler grid.Resize, AddressOf grid_Resize
			AddHandler grid.RightToLeftChanged, AddressOf grid_RightToLeftChanged
			AddHandler grid.RowHeightsChanged, AddressOf grid_RowHeightsChanged
			AddHandler grid.RowHeightsChanging, AddressOf grid_RowHeightsChanging
			AddHandler grid.RowsHidden, AddressOf grid_RowsHidden
			AddHandler grid.RowsHiding, AddressOf grid_RowsHiding
			AddHandler grid.RowsInserted, AddressOf grid_RowsInserted
			AddHandler grid.RowsInserting, AddressOf grid_RowsInserting
			AddHandler grid.RowsMoved, AddressOf grid_RowsMoved
			AddHandler grid.RowsMoving, AddressOf grid_RowsMoving
			AddHandler grid.RowsRemoved, AddressOf grid_RowsRemoved
			AddHandler grid.RowsRemoving, AddressOf grid_RowsRemoving
			AddHandler grid.ResizingColumns, AddressOf grid_ResizingColumns
			AddHandler grid.ResizingRows, AddressOf grid_ResizingRows
			AddHandler grid.SaveCellFormattedText, AddressOf grid_SaveCellFormattedText
			AddHandler grid.SaveCellInfo, AddressOf grid_SaveCellInfo
			AddHandler grid.SaveCellText, AddressOf grid_SaveCellText
			AddHandler grid.SaveColCount, AddressOf grid_SaveColCount
			AddHandler grid.SaveColWidth, AddressOf grid_SaveColWidth
			AddHandler grid.SaveRowCount, AddressOf grid_SaveRowCount
			AddHandler grid.SaveRowHeight, AddressOf grid_SaveRowHeight
			AddHandler grid.ScrollbarsVisibleChanged, AddressOf grid_ScrollbarsVisibleChanged
			AddHandler grid.ScrollControlHandledMouseDown, AddressOf grid_ScrollControlHandledMouseDown
			AddHandler grid.ScrollControlHandledMouseMove, AddressOf grid_ScrollControlHandledMouseMove
			AddHandler grid.ScrollControlHandledMouseUp, AddressOf grid_ScrollControlHandledMouseUp
			AddHandler grid.ScrollControlMouseDown, AddressOf grid_ScrollControlMouseDown
			AddHandler grid.ScrollControlMouseMove, AddressOf grid_ScrollControlMouseMove
			AddHandler grid.ScrollControlMouseUp, AddressOf grid_ScrollControlMouseUp
			AddHandler grid.ScrollTipFeedback, AddressOf grid_ScrollTipFeedback
			AddHandler grid.SelectionChanged, AddressOf grid_SelectionChanged
			AddHandler grid.SelectionChanging, AddressOf grid_SelectionChanging
			AddHandler grid.SelectionFrameChanged, AddressOf grid_SelectionFrameChanged
			AddHandler grid.SelectionFrameChanging, AddressOf grid_SelectionFrameChanging
			AddHandler grid.ShowContextMenu, AddressOf grid_ShowContextMenu
			AddHandler grid.SizeChanged, AddressOf grid_SizeChanged
			AddHandler grid.SplitterPaneClosed, AddressOf grid_SplitterPaneClosed
			AddHandler grid.SplitterPaneClosing, AddressOf grid_SplitterPaneClosing
			AddHandler grid.StyleChanged, AddressOf grid_StyleChanged
			AddHandler grid.SupportsTransparentBackColorChanged, AddressOf grid_SupportsTransparentBackColorChanged
			AddHandler grid.SystemColorsChanged, AddressOf grid_SystemColorsChanged
			AddHandler grid.ScrollInfoChanged, AddressOf grid_ScrollInfoChanged
			AddHandler grid.SelectionDragging, AddressOf grid_SelectionDragging
			AddHandler grid.SelectionDragged, AddressOf grid_SelectionDragged
			AddHandler grid.StartAutoScrolling, AddressOf grid_StartAutoScrolling

			AddHandler grid.TabIndexChanged, AddressOf grid_TabIndexChanged
			AddHandler grid.TabStopChanged, AddressOf grid_TabStopChanged
			AddHandler grid.TextChanged, AddressOf grid_TextChanged
			AddHandler grid.ThemeChanged, AddressOf grid_ThemeChanged
			AddHandler grid.TopRowChanged, AddressOf grid_TopRowChanged
			AddHandler grid.TopRowChanging, AddressOf grid_TopRowChanging
			AddHandler grid.UpdatingChanged, AddressOf grid_UpdatingChanged
			AddHandler grid.VerticalScroll, AddressOf grid_VerticalScroll
			AddHandler grid.VisibleChanged, AddressOf grid_VisibleChanged
			AddHandler grid.VScrollPixelPosChanged, AddressOf grid_VScrollPixelPosChanged
			AddHandler grid.VScrollPixelPosChanging, AddressOf grid_VScrollPixelPosChanging
			AddHandler grid.Validated, AddressOf grid_Validated
			AddHandler grid.Validating, AddressOf grid_Validating
			AddHandler grid.WindowScrolled, AddressOf grid_WindowScrolled
			AddHandler grid.WindowScrolling, AddressOf grid_WindowScrolling
			AddHandler grid.WrapCellNextControlInForm, AddressOf grid_WrapCellNextControlInForm
		End Sub

		Public Sub UnwireGrid(ByVal grid As GridControl)
			RemoveHandler grid.AccelerateScrollingChanged, AddressOf grid_AccelerateScrollingChanged
			RemoveHandler grid.ActivateToolTip, AddressOf grid_ActivateToolTip
			RemoveHandler grid.AutoScrollingChanged, AddressOf grid_AutoScrollingChanged
			RemoveHandler grid.BackColorChanged, AddressOf grid_BackColorChanged
			RemoveHandler grid.BackgroundImageChanged, AddressOf grid_BackgroundImageChanged
			RemoveHandler grid.BackgroundImageLayoutChanged, AddressOf grid_BackgroundImageLayoutChanged
			RemoveHandler grid.BanneredRangesChanged, AddressOf grid_BanneredRangesChanged
			RemoveHandler grid.BanneredRangesChanging, AddressOf grid_BanneredRangesChanging
			RemoveHandler grid.BaseStylesMapChanged, AddressOf grid_BaseStylesMapChanged
			RemoveHandler grid.BeginUpdateRequest, AddressOf grid_BeginUpdateRequest
			RemoveHandler grid.BindingContextChanged, AddressOf grid_BindingContextChanged
			AddHandler grid.CancelMode, AddressOf grid_CancelMode
			RemoveHandler grid.CausesValidationChanged, AddressOf grid_CausesValidationChanged
			RemoveHandler grid.CellCancelMode, AddressOf grid_CellCancelMode
			RemoveHandler grid.CellCursor, AddressOf grid_CellCursor
			RemoveHandler grid.CellDrawn, AddressOf grid_CellDrawn
			RemoveHandler grid.CellHitTest, AddressOf grid_CellHitTest
			RemoveHandler grid.CellModelsChanged, AddressOf grid_CellModelsChanged
			RemoveHandler grid.CellMouseHover, AddressOf grid_CellMouseHover
			RemoveHandler grid.CellMouseMove, AddressOf grid_CellMouseMove
			RemoveHandler grid.CellsChanged, AddressOf grid_CellsChanged
			RemoveHandler grid.CellsChanging, AddressOf grid_CellsChanging
			RemoveHandler grid.ChangeUICues, AddressOf grid_ChangeUICues
			RemoveHandler grid.ClearingCells, AddressOf grid_ClearingCells
			RemoveHandler grid.ClientSizeChanged, AddressOf grid_ClientSizeChanged
			RemoveHandler grid.ClipboardCanCopy, AddressOf grid_ClipboardCanCopy

			RemoveHandler grid.ColsHidden, AddressOf grid_ColsHidden
			RemoveHandler grid.ColsHiding, AddressOf grid_ColsHiding
			RemoveHandler grid.ColsInserted, AddressOf grid_ColsInserted
			RemoveHandler grid.ColsMoved, AddressOf grid_ColsMoved
			RemoveHandler grid.ColsMoving, AddressOf grid_ColsMoving
			RemoveHandler grid.ColsRemoved, AddressOf grid_ColsRemoved
			RemoveHandler grid.ColsRemoving, AddressOf grid_ColsRemoving
			RemoveHandler grid.ColWidthsChanged, AddressOf grid_ColWidthsChanged
			RemoveHandler grid.ColWidthsChanging, AddressOf grid_ColWidthsChanging
			RemoveHandler grid.ConfirmingPendingChanges, AddressOf grid_ConfirmingPendingChanges
			RemoveHandler grid.ContextMenuChanged, AddressOf grid_ContextMenuChanged
			RemoveHandler grid.ContextMenuStripChanged, AddressOf grid_ContextMenuStripChanged

			RemoveHandler grid.ControlAdded, AddressOf grid_ControlAdded
			RemoveHandler grid.ControllerOptionsChanged, AddressOf grid_ControllerOptionsChanged
			RemoveHandler grid.ControlRemoved, AddressOf grid_ControlRemoved
			RemoveHandler grid.CoveredRangesChanged, AddressOf grid_CoveredRangesChanged
			RemoveHandler grid.CoveredRangesChanging, AddressOf grid_CoveredRangesChanging
			RemoveHandler grid.CurrentCellControlKeyMessage, AddressOf grid_CurrentCellControlKeyMessage
			RemoveHandler grid.CurrentCellErrorMessage, AddressOf grid_CurrentCellErrorMessage
			RemoveHandler grid.CursorChanged, AddressOf grid_CursorChanged


			RemoveHandler grid.CurrentCellAcceptedChanges, AddressOf grid_CurrentCellAcceptedChanges
			RemoveHandler grid.CurrentCellMoved, AddressOf grid_CurrentCellMoved
			RemoveHandler grid.CurrentCellActivateFailed, AddressOf grid_CurrentCellActivateFailed
			RemoveHandler grid.CurrentCellActivated, AddressOf grid_CurrentCellActivated
			RemoveHandler grid.CurrentCellActivating, AddressOf grid_CurrentCellActivating
			RemoveHandler grid.CurrentCellChanged, AddressOf grid_CurrentCellChanged
			RemoveHandler grid.CurrentCellChanging, AddressOf grid_CurrentCellChanging
			RemoveHandler grid.CurrentCellCloseDropDown, AddressOf grid_CurrentCellCloseDropDown
			RemoveHandler grid.CurrentCellConfirmChangesFailed, AddressOf grid_CurrentCellConfirmChangesFailed
			RemoveHandler grid.CurrentCellControlGotFocus, AddressOf grid_CurrentCellControlGotFocus
			RemoveHandler grid.CurrentCellControlLostFocus, AddressOf grid_CurrentCellControlLostFocus
			RemoveHandler grid.CurrentCellDeactivated, AddressOf grid_CurrentCellDeactivated
			RemoveHandler grid.CurrentCellDeactivateFailed, AddressOf grid_CurrentCellDeactivateFailed
			RemoveHandler grid.CurrentCellDeactivating, AddressOf grid_CurrentCellDeactivating
			RemoveHandler grid.CurrentCellDeleting, AddressOf grid_CurrentCellDeleting
			RemoveHandler grid.CurrentCellEditingComplete, AddressOf grid_CurrentCellEditingComplete
			RemoveHandler grid.CurrentCellInitializeControlText, AddressOf grid_CurrentCellInitializeControlText
			RemoveHandler grid.CurrentCellKeyDown, AddressOf grid_CurrentCellKeyDown
			RemoveHandler grid.CurrentCellKeyPress, AddressOf grid_CurrentCellKeyPress
			RemoveHandler grid.CurrentCellKeyUp, AddressOf grid_CurrentCellKeyUp
			RemoveHandler grid.CurrentCellMoved, AddressOf grid_CurrentCellMoved
			RemoveHandler grid.CurrentCellMoveFailed, AddressOf grid_CurrentCellMoveFailed
			RemoveHandler grid.CurrentCellMoving, AddressOf grid_CurrentCellMoving
			RemoveHandler grid.CurrentCellRejectedChanges, AddressOf grid_CurrentCellRejectedChanges
			RemoveHandler grid.CurrentCellShowedDropDown, AddressOf grid_CurrentCellShowedDropDown
			RemoveHandler grid.CurrentCellShowingDropDown, AddressOf grid_CurrentCellShowingDropDown
			RemoveHandler grid.CurrentCellStartEditing, AddressOf grid_CurrentCellStartEditing
			RemoveHandler grid.CurrentCellValidated, AddressOf grid_CurrentCellValidated
			RemoveHandler grid.CurrentCellValidateString, AddressOf grid_CurrentCellValidateString
			RemoveHandler grid.CurrentCellControlDoubleClick, AddressOf grid_CurrentCellControlDoubleClick

			RemoveHandler grid.CellButtonClicked, AddressOf grid_CellButtonClicked
			RemoveHandler grid.CellClick, AddressOf grid_CellClick
			RemoveHandler grid.CellDoubleClick, AddressOf grid_CellDoubleClick
			RemoveHandler grid.CellMouseDown, AddressOf grid_CellMouseDown
			RemoveHandler grid.CellMouseHoverEnter, AddressOf grid_CellMouseHoverEnter
			RemoveHandler grid.CellMouseHoverLeave, AddressOf grid_CellMouseHoverLeave
			RemoveHandler grid.CellMouseUp, AddressOf grid_CellMouseUp
			RemoveHandler grid.CheckBoxClick, AddressOf grid_CheckBoxClick
			RemoveHandler grid.PushButtonClick, AddressOf grid_PushButtonClick

			' Other events
			RemoveHandler grid.Click, AddressOf grid_Click
			RemoveHandler grid.DataChanged, AddressOf grid_DataChanged
			RemoveHandler grid.DataObjectConsumerOptionsChanged, AddressOf grid_DataObjectConsumerOptionsChanged
			RemoveHandler grid.DefaultColWidthChanging, AddressOf grid_DefaultColWidthChanging
			RemoveHandler grid.DefaultRowHeightChanged, AddressOf grid_DefaultRowHeightChanged
			RemoveHandler grid.DefaultRowHeightChanging, AddressOf grid_DefaultRowHeightChanging
			RemoveHandler grid.Disposed, AddressOf grid_Disposed
			RemoveHandler grid.DockChanged, AddressOf grid_DockChanged
			RemoveHandler grid.DrawCellBackground, AddressOf grid_DrawCellBackground
			RemoveHandler grid.DrawCellButton, AddressOf grid_DrawCellButton
			RemoveHandler grid.DrawCellButtonBackground, AddressOf grid_DrawCellButtonBackground
			RemoveHandler grid.DrawCellDisplayText, AddressOf grid_DrawCellDisplayText
			RemoveHandler grid.DrawCellFrameAppearance, AddressOf grid_DrawCellFrameAppearance
			RemoveHandler grid.DrawCurrentCellBorder, AddressOf grid_DrawCurrentCellBorder
			RemoveHandler grid.DefaultColWidthChanged, AddressOf grid_DefaultColWidthChanged
			RemoveHandler grid.Deactivated, AddressOf grid_Deactivated
			RemoveHandler grid.DoubleClick, AddressOf grid_DoubleClick
			RemoveHandler grid.DragDrop, AddressOf grid_DragDrop
			RemoveHandler grid.DragEnter, AddressOf grid_DragEnter
			RemoveHandler grid.DragLeave, AddressOf grid_DragLeave
			RemoveHandler grid.DragOver, AddressOf grid_DragOver
			RemoveHandler grid.Enter, AddressOf grid_Enter
			RemoveHandler grid.EnabledChanged, AddressOf grid_EnabledChanged
			RemoveHandler grid.EndUpdateRequest, AddressOf grid_EndUpdateRequest
			RemoveHandler grid.FileNameChanged, AddressOf grid_FileNameChanged
			RemoveHandler grid.FillRectangleHook, AddressOf grid_FillRectangleHook
			RemoveHandler grid.FillSplitterPaneChanged, AddressOf grid_FillSplitterPaneChanged
			RemoveHandler grid.FloatingCellsChanged, AddressOf grid_FloatingCellsChanged
			RemoveHandler grid.FontChanged, AddressOf grid_FontChanged
			RemoveHandler grid.ForeColorChanged, AddressOf grid_ForeColorChanged
			RemoveHandler grid.FrozenColCountChanged, AddressOf grid_FrozenColCountChanged
			RemoveHandler grid.FrozenColCountChanging, AddressOf grid_FrozenColCountChanging
			RemoveHandler grid.FrozenRowCountChanged, AddressOf grid_FrozenRowCountChanged
			RemoveHandler grid.FrozenRowCountChanging, AddressOf grid_FrozenRowCountChanging
			RemoveHandler grid.GiveFeedback, AddressOf grid_GiveFeedback
			RemoveHandler grid.GridBoundsChanged, AddressOf grid_GridBoundsChanged
			RemoveHandler grid.GridControlMouseDown, AddressOf grid_GridControlMouseDown
			RemoveHandler grid.GridControlMouseMove, AddressOf grid_GridControlMouseMove
			RemoveHandler grid.GridControlMouseUp, AddressOf grid_GridControlMouseUp
			RemoveHandler grid.GotFocus, AddressOf grid_GotFocus
			RemoveHandler grid.HandleCreated, AddressOf grid_HandleCreated
			RemoveHandler grid.HandleDestroyed, AddressOf grid_HandleDestroyed
			RemoveHandler grid.HeaderColCountChanged, AddressOf grid_HeaderColCountChanged
			RemoveHandler grid.HeaderColCountChanging, AddressOf grid_HeaderColCountChanging
			RemoveHandler grid.HeaderRowCountChanged, AddressOf grid_HeaderRowCountChanged
			RemoveHandler grid.HeaderRowCountChanging, AddressOf grid_HeaderRowCountChanging
			RemoveHandler grid.HelpRequested, AddressOf grid_HelpRequested
			RemoveHandler grid.HorizontalScroll, AddressOf grid_HorizontalScroll
			RemoveHandler grid.HScrollPixelPosChanged, AddressOf grid_HScrollPixelPosChanged
			RemoveHandler grid.HScrollPixelPosChanging, AddressOf grid_HScrollPixelPosChanging
			RemoveHandler grid.ImeModeChanged, AddressOf grid_ImeModeChanged
			RemoveHandler grid.IntelliMouseDragScrolling, AddressOf grid_IntelliMouseDragScrolling
			RemoveHandler grid.Invalidated, AddressOf grid_Invalidated
			RemoveHandler grid.KeyDown, AddressOf grid_KeyDown
			RemoveHandler grid.KeyPress, AddressOf grid_KeyPress
			RemoveHandler grid.KeyUp, AddressOf grid_KeyUp
			RemoveHandler grid.LeftColChanged, AddressOf grid_LeftColChanged
			RemoveHandler grid.LeftColChanging, AddressOf grid_LeftColChanging
			RemoveHandler grid.LocationChanged, AddressOf grid_LocationChanged
			RemoveHandler grid.MarginChanged, AddressOf grid_MarginChanged
			RemoveHandler grid.MergeCellsChanged, AddressOf grid_MergeCellsChanged
			RemoveHandler grid.ModelChanged, AddressOf grid_ModelChanged
			RemoveHandler grid.ModifiedChanged, AddressOf grid_ModifiedChanged
			RemoveHandler grid.MouseActivating, AddressOf grid_MouseActivating
			RemoveHandler grid.MouseCaptureChanged, AddressOf grid_MouseCaptureChanged
			RemoveHandler grid.MouseClick, AddressOf grid_MouseClick
			RemoveHandler grid.MouseHover, AddressOf grid_MouseHover
			RemoveHandler grid.MouseMove, AddressOf grid_MouseMove
			RemoveHandler grid.MouseWheel, AddressOf grid_MouseWheel
			RemoveHandler grid.MouseWheelZoom, AddressOf grid_MouseWheelZoom
			RemoveHandler grid.Move, AddressOf grid_Move
			RemoveHandler grid.MoveCurrentCellDirection, AddressOf grid_MoveCurrentCellDirection
			RemoveHandler grid.Office2007ScrollBarsChanged, AddressOf grid_Office2007ScrollBarsChanged
			RemoveHandler grid.Office2007ScrollBarsColorSchemeChanged, AddressOf grid_Office2007ScrollBarsColorSchemeChanged
			RemoveHandler grid.OperationFeedback, AddressOf grid_OperationFeedback
			RemoveHandler grid.PaddingChanged, AddressOf grid_PaddingChanged
			RemoveHandler grid.ParentChanged, AddressOf grid_ParentChanged
			RemoveHandler grid.ParseCommonFormats, AddressOf grid_ParseCommonFormats
			RemoveHandler grid.PasteCellText, AddressOf grid_PasteCellText
			RemoveHandler grid.PrepareChangeSelection, AddressOf grid_PrepareChangeSelection
			RemoveHandler grid.PrepareClearSelection, AddressOf grid_PrepareClearSelection
			RemoveHandler grid.PrepareGraphics, AddressOf grid_PrepareGraphics
			RemoveHandler grid.PrepareViewStyleInfo, AddressOf grid_PrepareViewStyleInfo
			RemoveHandler grid.PreviewKeyDown, AddressOf grid_PreviewKeyDown
			RemoveHandler grid.PrintingModeChanged, AddressOf grid_PrintingModeChanged
			RemoveHandler grid.Layout, AddressOf grid_Layout
			RemoveHandler grid.Leave, AddressOf grid_Leave
			RemoveHandler grid.LostFocus, AddressOf grid_LostFocus
			RemoveHandler grid.MouseDown, AddressOf grid_MouseDown
			RemoveHandler grid.MouseUp, AddressOf grid_MouseUp
			RemoveHandler grid.MouseEnter, AddressOf grid_MouseEnter
			RemoveHandler grid.MouseLeave, AddressOf grid_MouseLeave
			RemoveHandler grid.ReadOnlyChanged, AddressOf grid_ReadOnlyChanged
			RemoveHandler grid.RefreshRequest, AddressOf grid_RefreshRequest
			RemoveHandler grid.RegionChanged, AddressOf grid_RegionChanged
			RemoveHandler grid.Resize, AddressOf grid_Resize
			RemoveHandler grid.RightToLeftChanged, AddressOf grid_RightToLeftChanged
			RemoveHandler grid.RowHeightsChanged, AddressOf grid_RowHeightsChanged
			RemoveHandler grid.RowHeightsChanging, AddressOf grid_RowHeightsChanging
			RemoveHandler grid.RowsHidden, AddressOf grid_RowsHidden
			RemoveHandler grid.RowsHiding, AddressOf grid_RowsHiding
			RemoveHandler grid.RowsInserted, AddressOf grid_RowsInserted
			RemoveHandler grid.RowsInserting, AddressOf grid_RowsInserting
			RemoveHandler grid.RowsMoved, AddressOf grid_RowsMoved
			RemoveHandler grid.RowsMoving, AddressOf grid_RowsMoving
			RemoveHandler grid.RowsRemoved, AddressOf grid_RowsRemoved
			RemoveHandler grid.RowsRemoving, AddressOf grid_RowsRemoving
			RemoveHandler grid.ResizingColumns, AddressOf grid_ResizingColumns
			RemoveHandler grid.ResizingRows, AddressOf grid_ResizingRows
			RemoveHandler grid.SaveCellFormattedText, AddressOf grid_SaveCellFormattedText
			RemoveHandler grid.SaveCellInfo, AddressOf grid_SaveCellInfo
			RemoveHandler grid.SaveCellText, AddressOf grid_SaveCellText
			RemoveHandler grid.SaveColCount, AddressOf grid_SaveColCount
			RemoveHandler grid.SaveColWidth, AddressOf grid_SaveColWidth
			RemoveHandler grid.SaveRowCount, AddressOf grid_SaveRowCount
			RemoveHandler grid.SaveRowHeight, AddressOf grid_SaveRowHeight
			RemoveHandler grid.ScrollbarsVisibleChanged, AddressOf grid_ScrollbarsVisibleChanged
			RemoveHandler grid.ScrollControlHandledMouseDown, AddressOf grid_ScrollControlHandledMouseDown
			RemoveHandler grid.ScrollControlHandledMouseMove, AddressOf grid_ScrollControlHandledMouseMove
			RemoveHandler grid.ScrollControlHandledMouseUp, AddressOf grid_ScrollControlHandledMouseUp
			RemoveHandler grid.ScrollControlMouseDown, AddressOf grid_ScrollControlMouseDown
			RemoveHandler grid.ScrollControlMouseMove, AddressOf grid_ScrollControlMouseMove
			RemoveHandler grid.ScrollControlMouseUp, AddressOf grid_ScrollControlMouseUp
			RemoveHandler grid.ScrollTipFeedback, AddressOf grid_ScrollTipFeedback
			RemoveHandler grid.SelectionChanged, AddressOf grid_SelectionChanged
			RemoveHandler grid.SelectionChanging, AddressOf grid_SelectionChanging
			RemoveHandler grid.SelectionFrameChanged, AddressOf grid_SelectionFrameChanged
			RemoveHandler grid.SelectionFrameChanging, AddressOf grid_SelectionFrameChanging
			RemoveHandler grid.ShowContextMenu, AddressOf grid_ShowContextMenu
			RemoveHandler grid.SizeChanged, AddressOf grid_SizeChanged
			RemoveHandler grid.SplitterPaneClosed, AddressOf grid_SplitterPaneClosed
			RemoveHandler grid.SplitterPaneClosing, AddressOf grid_SplitterPaneClosing
			RemoveHandler grid.StyleChanged, AddressOf grid_StyleChanged
			RemoveHandler grid.SupportsTransparentBackColorChanged, AddressOf grid_SupportsTransparentBackColorChanged
			RemoveHandler grid.SystemColorsChanged, AddressOf grid_SystemColorsChanged
			RemoveHandler grid.SaveCellFormattedText, AddressOf grid_SaveCellFormattedText
			RemoveHandler grid.SaveCellInfo, AddressOf grid_SaveCellInfo
			RemoveHandler grid.SaveCellText, AddressOf grid_SaveCellText
			RemoveHandler grid.SaveColCount, AddressOf grid_SaveColCount
			RemoveHandler grid.SaveColWidth, AddressOf grid_SaveColWidth
			RemoveHandler grid.SaveRowCount, AddressOf grid_SaveRowCount
			RemoveHandler grid.SaveRowHeight, AddressOf grid_SaveRowHeight
			RemoveHandler grid.ScrollbarsVisibleChanged, AddressOf grid_ScrollbarsVisibleChanged
			RemoveHandler grid.ScrollControlHandledMouseDown, AddressOf grid_ScrollControlHandledMouseDown
			RemoveHandler grid.ScrollControlHandledMouseMove, AddressOf grid_ScrollControlHandledMouseMove
			RemoveHandler grid.ScrollControlHandledMouseUp, AddressOf grid_ScrollControlHandledMouseUp
			RemoveHandler grid.ScrollControlMouseDown, AddressOf grid_ScrollControlMouseDown
			RemoveHandler grid.ScrollControlMouseMove, AddressOf grid_ScrollControlMouseMove
			RemoveHandler grid.ScrollControlMouseUp, AddressOf grid_ScrollControlMouseUp
			RemoveHandler grid.ScrollTipFeedback, AddressOf grid_ScrollTipFeedback
			RemoveHandler grid.SelectionChanged, AddressOf grid_SelectionChanged
			RemoveHandler grid.SelectionChanging, AddressOf grid_SelectionChanging
			RemoveHandler grid.SelectionFrameChanged, AddressOf grid_SelectionFrameChanged
			RemoveHandler grid.SelectionFrameChanging, AddressOf grid_SelectionFrameChanging
			RemoveHandler grid.ShowContextMenu, AddressOf grid_ShowContextMenu
			RemoveHandler grid.SizeChanged, AddressOf grid_SizeChanged
			RemoveHandler grid.SplitterPaneClosed, AddressOf grid_SplitterPaneClosed
			RemoveHandler grid.SplitterPaneClosing, AddressOf grid_SplitterPaneClosing
			RemoveHandler grid.StyleChanged, AddressOf grid_StyleChanged
			RemoveHandler grid.SupportsTransparentBackColorChanged, AddressOf grid_SupportsTransparentBackColorChanged
			RemoveHandler grid.SystemColorsChanged, AddressOf grid_SystemColorsChanged
			RemoveHandler grid.ScrollInfoChanged, AddressOf grid_ScrollInfoChanged
			RemoveHandler grid.SelectionDragging, AddressOf grid_SelectionDragging
			RemoveHandler grid.SelectionDragged, AddressOf grid_SelectionDragged
			RemoveHandler grid.StartAutoScrolling, AddressOf grid_StartAutoScrolling
			RemoveHandler grid.TabIndexChanged, AddressOf grid_TabIndexChanged
			RemoveHandler grid.TabStopChanged, AddressOf grid_TabStopChanged
			RemoveHandler grid.TextChanged, AddressOf grid_TextChanged
			RemoveHandler grid.ThemeChanged, AddressOf grid_ThemeChanged
			RemoveHandler grid.TopRowChanged, AddressOf grid_TopRowChanged
			RemoveHandler grid.TopRowChanging, AddressOf grid_TopRowChanging
			RemoveHandler grid.UpdatingChanged, AddressOf grid_UpdatingChanged
			RemoveHandler grid.VerticalScroll, AddressOf grid_VerticalScroll
			RemoveHandler grid.VisibleChanged, AddressOf grid_VisibleChanged
			RemoveHandler grid.VScrollPixelPosChanged, AddressOf grid_VScrollPixelPosChanged
			RemoveHandler grid.VScrollPixelPosChanging, AddressOf grid_VScrollPixelPosChanging
			RemoveHandler grid.Validated, AddressOf grid_Validated
			RemoveHandler grid.Validating, AddressOf grid_Validating
			AddHandler grid.WindowScrolled, AddressOf grid_WindowScrolled
			AddHandler grid.WindowScrolling, AddressOf grid_WindowScrolling
			RemoveHandler grid.WrapCellNextControlInForm, AddressOf grid_WrapCellNextControlInForm
		End Sub

		Private Sub splitter_PaneCreated(ByVal sender As Object, ByVal e As SplitterPaneEventArgs)
			Dim grid As GridControl = TryCast(e.Control, GridControl)
			WireGrid(grid)
		End Sub

		Private Sub splitter_PaneClosing(ByVal sender As Object, ByVal e As SplitterPaneEventArgs)
			Dim grid As GridControl = TryCast(e.Control, GridControl)
			UnwireGrid(grid)
		End Sub

		Private Function GetInfo(ByVal name As String) As String
			Dim grid As GridControl = TryCast(Me._splitter.ActivePane, GridControl)
			Dim s As String = ""
			If grid IsNot Nothing Then
				If grid.CurrentCell.HasCurrentCell Then
					Dim cc As GridCurrentCell = grid.CurrentCell
					Dim renderer As GridCellRendererBase = cc.Renderer
					Dim style As GridStyleInfo = grid(cc.RowIndex, cc.ColIndex)

					Dim ct As String = ""
					If renderer.HasControlText Then
						ct = " ControlText: " & renderer.ControlText
					End If
					Dim cv As String = ""
					If renderer.HasControlValue Then
						If renderer.ControlValue IsNot Nothing Then
							ct = " ControlValue: " & renderer.ControlValue.ToString()
						Else
							ct = " ControlValue: null"
						End If
					End If
					Dim st As String = style.Text
					Dim sv As String = ""
					If style.CellValue IsNot Nothing Then
						sv = style.CellValue.ToString()
					End If
                    If cc.IsModified Then
                        s = String.Format("{0}{1} {2}""{3}"", ""{4}"", StyleText: ""{5}"", StyleValue: ""{6}"" ", "*", name, grid.CurrentCell.RangeInfo, ct, cv, st, sv)
                    Else
                        s = String.Format("{0}{1} {2}""{3}"", ""{4}"", StyleText: ""{5}"", StyleValue: ""{6}"" ", "", name, grid.CurrentCell.RangeInfo, ct, cv, st, sv)
                    End If

                Else
                    s = name
                End If
                End If
			Return s
		End Function

		Private _enabled As Boolean = False

		Public Property Enabled() As Boolean
			Get
				Return _enabled
			End Get
			Set(ByVal value As Boolean)
				_enabled = value
			End Set
		End Property

		Public Property DisplayMouseMessages() As Boolean
			Get
				Return _displayMouseMessage
			End Get
			Set(ByVal value As Boolean)
				_displayMouseMessage = value
			End Set
		End Property

		Public Overrides Function ToString() As String
			Return GetInfo("")
		End Function

		Private Sub grid_AccelerateScrollingChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("AccelerateScrollingChanged", e)
		End Sub

		Private Sub grid_ActivateToolTip(ByVal sender As Object, ByVal e As GridActivateToolTipEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ActivateToolTip", e)
		End Sub

		Private Sub grid_AutoScrollingChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("AutoScrollingChanged", e)
		End Sub

		Private Sub grid_BackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("BackColorChanged", e)
		End Sub

		Private Sub grid_BackgroundImageChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("BackgroundImageChanged", e)
		End Sub

		Private Sub grid_BackgroundImageLayoutChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("BackgroundImageLayoutChanged", e)
		End Sub

		Private Sub grid_BanneredRangesChanged(ByVal sender As Object, ByVal e As GridBanneredRangesChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("BanneredRangesChanged", e)
		End Sub
		Private Sub grid_BanneredRangesChanging(ByVal sender As Object, ByVal e As GridBanneredRangesChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("BanneredRangesChanged", e)
		End Sub

		Private Sub grid_BaseStylesMapChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("BaseStylesMapChanged", e)
		End Sub

		Private Sub grid_BeginUpdateRequest(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("BeginUpdateRequest", e)
		End Sub
		Private Sub grid_BindingContextChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("BindingContextChanged", e)
		End Sub

		Private Sub grid_CancelMode(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("CancelMode", e)
		End Sub

		Private Sub grid_ClipboardCut(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ClipboardCut", e)
		End Sub
		Private Sub grid_CausesValidationChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("CausesValidationChanged", e)
		End Sub
		Private Sub grid_CellCancelMode(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellCancelMode", e)
		End Sub

		Private Sub grid_CellCursor(ByVal sender As Object, ByVal e As GridCellCursorEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellCursor", e)
		End Sub

		Private Sub grid_CellDrawn(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellDrawn", e)
		End Sub

		Private Sub grid_CellHitTest(ByVal sender As Object, ByVal e As GridCellHitTestEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellHitTest", e)
		End Sub
		Private Sub grid_ClipboardPaste(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ClipboardPaste", e)
		End Sub
		Private Sub grid_CellModelsChanged(ByVal sender As Object, ByVal e As CollectionChangeEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellModelsChanged", e)
		End Sub
		Private Sub grid_CellMouseHover(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("CellMouseHover", e)
		End Sub
		Private Sub grid_CellMouseMove(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("CellMouseMove", e)
		End Sub
		Private Sub grid_CellsChanged(ByVal sender As Object, ByVal e As GridCellsChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellsChanged", e)
		End Sub

		Private Sub grid_ChangeUICues(ByVal sender As Object, ByVal e As UICuesEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ChangeUICues", e)
		End Sub
		Private Sub grid_ClearingCells(ByVal sender As Object, ByVal e As GridClearingCellsEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("ClearingCells", e)
		End Sub
		Private Sub grid_ClientSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ClientSizeChanged", e)
		End Sub
		Private Sub grid_CellsChanging(ByVal sender As Object, ByVal e As GridCellsChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellsChanging", e)
		End Sub
		Private Sub grid_ClipboardCanCopy(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ClipboardCanCopy", e)
		End Sub

		Private Sub grid_ClipboardCanCut(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ClipboardCanCut", e)
		End Sub
		Private Sub grid_ClipboardCanPaste(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ClipboardCanPaste", e)
		End Sub
		Private Sub grid_ClipboardCopy(ByVal sender As Object, ByVal e As GridCutPasteEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ClipboardCopy", e)
		End Sub

		Private Sub grid_ColsHidden(ByVal sender As Object, ByVal e As GridRowColHiddenEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ColsHidden", e)
		End Sub

		Private Sub grid_ColsHiding(ByVal sender As Object, ByVal e As GridRowColHidingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ColsHiding", e)
		End Sub
		Private Sub grid_ColsInserted(ByVal sender As Object, ByVal e As GridRangeInsertedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ColsInserted", e)
		End Sub
		Private Sub grid_ColsMoved(ByVal sender As Object, ByVal e As GridRangeMovedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ColsMoved", e)
		End Sub

		Private Sub grid_ColsMoving(ByVal sender As Object, ByVal e As GridRangeMovingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ColsMoving", e)
		End Sub

		Private Sub grid_ColsRemoved(ByVal sender As Object, ByVal e As GridRangeRemovedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ColsRemoved", e)
		End Sub

		Private Sub grid_CoveredRangesChanged(ByVal sender As Object, ByVal e As GridCoveredRangesChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("CoveredRangesChanged", e)
		End Sub
		Private Sub grid_CurrentCellControlKeyMessage(ByVal sender As Object, ByVal e As GridCurrentCellControlKeyMessageEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellControlKeyMessage", e)
		End Sub

		Private Sub grid_ColsRemoving(ByVal sender As Object, ByVal e As GridRangeRemovingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ColsRemoving", e)
		End Sub
		Private Sub grid_ColWidthsChanged(ByVal sender As Object, ByVal e As GridRowColSizeChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ColWidthsChanged", e)
		End Sub
		Private Sub grid_ColWidthsChanging(ByVal sender As Object, ByVal e As GridRowColSizeChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ColWidthsChanging", e)
		End Sub

		Private Sub grid_ConfirmingPendingChanges(ByVal sender As Object, ByVal e As CancelEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ConfirmingPendingChanges", e)
		End Sub
		Private Sub grid_ContextMenuChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ContextMenuChanged", e)
		End Sub

		Private Sub grid_ContextMenuStripChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ContextMenuStripChanged", e)
		End Sub

		Private Sub grid_ControlAdded(ByVal sender As Object, ByVal e As ControlEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ControlAdded", e)
		End Sub
		Private Sub grid_ControllerOptionsChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ControllerOptionsChanged", e)
		End Sub
		Private Sub grid_ControlRemoved(ByVal sender As Object, ByVal e As ControlEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ControlRemoved", e)
		End Sub

		Private Sub grid_CoveredRangesChanging(ByVal sender As Object, ByVal e As GridCoveredRangesChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("CoveredRangesChanging", e)
		End Sub
		Private Sub grid_CurrentCellErrorMessage(ByVal sender As Object, ByVal e As GridCurrentCellErrorMessageEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellErrorMessage", e)
		End Sub

		Private Sub grid_CursorChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CursorChanged", e)
		End Sub

		Private Sub grid_CurrentCellMoved(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellMoved", e)
		End Sub

		Private Sub grid_CurrentCellAcceptedChanges(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellAcceptedChanges", e)
		End Sub

		Private Sub grid_CurrentCellActivated(ByVal sender As Object, ByVal e As System.EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellActivated", e)
		End Sub

		Private Sub grid_CurrentCellActivateFailed(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCurrentCellActivateFailedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellActivateFailed", e)
		End Sub

		Private Sub grid_CurrentCellActivating(ByVal sender As Object, ByVal e As GridCurrentCellActivatingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellActivating", e)
		End Sub

		Private Sub grid_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellChanged", e)

		End Sub

		Private Sub grid_CurrentCellChanging(ByVal sender As Object, ByVal e As CancelEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellChanging", e)

		End Sub

		Private Sub grid_CurrentCellCloseDropDown(ByVal sender As Object, ByVal e As PopupClosedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellCloseDropDown", e)

		End Sub

		Private Sub grid_CurrentCellControlLostFocus(ByVal sender As Object, ByVal e As ControlEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellControlLostFocus", e)
		End Sub

		Private Sub grid_CurrentCellMoveFailed(ByVal sender As Object, ByVal e As GridCurrentCellMoveFailedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellMoveFailed", e)

		End Sub

		Private Sub grid_CurrentCellRejectedChanges(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellRejectedChanges", e)

		End Sub

		Private Sub grid_CurrentCellShowedDropDown(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellShowedDropDown", e)

		End Sub

		Private Sub grid_CurrentCellShowingDropDown(ByVal sender As Object, ByVal e As GridCurrentCellShowingDropDownEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellShowingDropDown", e)

		End Sub

		Private Sub grid_CurrentCellStartEditing(ByVal sender As Object, ByVal e As CancelEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellStartEditing", e)

		End Sub

		Private Sub grid_CurrentCellValidated(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellValidated", e)

		End Sub

		Private Sub grid_CurrentCellValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
			' Force the Renderer.ControValue to be in sync with the
			' displayed text. You have to decide on a case by case basis
			' (depeding on what cell renderer you have) if you want to do this ...
			'GridControlBase grid = (GridControlBase) sender;
			'grid.CurrentCell.Renderer.UpdateControlValue();

			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellValidating", e)
		End Sub

		Private Sub grid_CurrentCellControlDoubleClick(ByVal sender As Object, ByVal e As ControlEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellControlDoubleClick", e)
		End Sub

		Private Sub grid_CurrentCellConfirmChangesFailed(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellConfirmChangesFailed", e)
		End Sub

		Private Sub grid_CurrentCellControlGotFocus(ByVal sender As Object, ByVal e As ControlEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellControlGotFocus", e)
		End Sub

		Private Sub grid_CurrentCellDeactivateFailed(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellDeactivateFailed", e)

		End Sub

		Private Sub grid_CurrentCellDeactivating(ByVal sender As Object, ByVal e As CancelEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellDeactivating", e)

		End Sub

		Private Sub grid_CurrentCellEditingComplete(ByVal sender As Object, ByVal e As EventArgs)

			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellEditingComplete", e)
		End Sub

		Private Sub grid_CurrentCellKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellKeyDown", e)

		End Sub

		Private Sub grid_CurrentCellKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellKeyPress", e)

		End Sub

		Private Sub grid_CurrentCellKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellKeyUp", e)

		End Sub

		Private Sub grid_CurrentCellDeleting(ByVal sender As Object, ByVal e As CancelEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellDeleting", e)
		End Sub

		Private Sub grid_CurrentCellMoving(ByVal sender As Object, ByVal e As GridCurrentCellMovingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellMoving", e)

		End Sub

		Private Sub grid_CurrentCellDeactivated(ByVal sender As Object, ByVal e As GridCurrentCellDeactivatedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellDeactivated", e)

		End Sub

		Private Sub grid_CurrentCellInitializeControlText(ByVal sender As Object, ByVal e As GridCurrentCellInitializeControlTextEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellInitializeControlText", e)

		End Sub

		Private Sub grid_CurrentCellValidateString(ByVal sender As Object, ByVal e As GridCurrentCellValidateStringEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CurrentCellValidateString", e)

		End Sub

		Private Sub grid_CellButtonClicked(ByVal sender As Object, ByVal e As GridCellButtonClickedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellButtonClicked", e)

		End Sub

		Private Sub grid_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellClick", e)

		End Sub

		Private Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellDoubleClick", e)

		End Sub

		Private Sub grid_CellMouseDown(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellMouseDown", e)

		End Sub

		Private Sub grid_CellMouseHoverEnter(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("CellMouseHoverEnter", e)

		End Sub

		Private Sub grid_CellMouseHoverLeave(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("CellMouseHoverLeave", e)

		End Sub

		Private Sub grid_CellMouseUp(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("CellMouseUp", e)

		End Sub

		Private Sub grid_CheckBoxClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("CheckBoxClick", e)
		End Sub

		Private Sub grid_PushButtonClick(ByVal sender As Object, ByVal e As GridCellPushButtonClickEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("PushButtonClick", e)
		End Sub

		Private Sub grid_Click(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("Click", e)
		End Sub

		Private Sub grid_DataChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DataChanged", e)
		End Sub

		Private Sub grid_DataObjectConsumerOptionsChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DataObjectConsumerOptionsChanged", e)
		End Sub

		Private Sub grid_DefaultColWidthChanging(ByVal sender As Object, ByVal e As GridDefaultSizeChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DefaultColWidthChanging", e)
		End Sub
		Private Sub grid_DefaultRowHeightChanged(ByVal sender As Object, ByVal e As GridDefaultSizeChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DefaultRowHeightChanged", e)
		End Sub
		Private Sub grid_DefaultRowHeightChanging(ByVal sender As Object, ByVal e As GridDefaultSizeChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DefaultRowHeightChanging", e)
		End Sub
		Private Sub grid_Disposed(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Disposed", e)
		End Sub
		Private Sub grid_DockChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DockChanged", e)
		End Sub
		Private Sub grid_DrawCell(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("DrawCell", e)
		End Sub
		Private Sub grid_DrawCellBackground(ByVal sender As Object, ByVal e As GridDrawCellBackgroundEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("DrawCellBackground", e)
		End Sub
		Private Sub grid_DrawCellButton(ByVal sender As Object, ByVal e As GridDrawCellButtonEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("DrawCellButton", e)
		End Sub
		Private Sub grid_DrawCellButtonBackground(ByVal sender As Object, ByVal e As GridDrawCellButtonBackgroundEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("DrawCellButtonBackground", e)
		End Sub
		Private Sub grid_DrawCellDisplayText(ByVal sender As Object, ByVal e As GridDrawCellDisplayTextEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("DrawCellDisplayText", e)
		End Sub
		Private Sub grid_DrawCellFrameAppearance(ByVal sender As Object, ByVal e As GridDrawCellBackgroundEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("DrawCellFrameAppearance", e)
		End Sub

		Private Sub grid_DrawCurrentCellBorder(ByVal sender As Object, ByVal e As GridDrawCurrentCellBorderEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("DrawCurrentCellBorder", e)
		End Sub

		Private Sub grid_DefaultColWidthChanged(ByVal sender As Object, ByVal e As GridDefaultSizeChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DefaultColWidthChanged", e)
		End Sub

		Private Sub grid_Deactivated(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Deactivated", e)
		End Sub

		Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DoubleClick", e)
		End Sub

		Private Sub grid_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DragDrop", e)
		End Sub

		Private Sub grid_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DragEnter", e)
		End Sub

		Private Sub grid_DragLeave(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DragLeave", e)
		End Sub

		Private Sub grid_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("DragOver", e)
		End Sub

		Private Sub grid_EnabledChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("EnabledChanged", e)
		End Sub
		Private Sub grid_EndUpdateRequest(ByVal sender As Object, ByVal e As GridEndUpdateRequestEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("EndUpdateRequest", e)
		End Sub

		Private Sub grid_Enter(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Enter", e)
		End Sub

		Private Sub grid_FrozenRowCountChanging(ByVal sender As Object, ByVal e As GridCountChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("FrozenRowCountChanging", e)
		End Sub

		Private Sub grid_FrozenRowCountChanged(ByVal sender As Object, ByVal e As GridCountChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("FrozenRowCountChanged", e)
		End Sub

		Private Sub grid_FrozenColCountChanging(ByVal sender As Object, ByVal e As GridCountChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("FrozenColCountChanging", e)
		End Sub

		Private Sub grid_FrozenColCountChanged(ByVal sender As Object, ByVal e As GridCountChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("FrozenColCountChanged", e)
		End Sub

		Private Sub grid_ForeColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ForeColorChanged", e)
		End Sub

		Private Sub grid_FontChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("FontChanged", e)
		End Sub

		Private Sub grid_FloatingCellsChanged(ByVal sender As Object, ByVal e As GridFloatingCellsChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("FloatingCellsChanged", e)
		End Sub

		Private Sub grid_FillSplitterPaneChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("FillSplitterPaneChanged", e)
		End Sub

		Private Sub grid_FillRectangleHook(ByVal sender As Object, ByVal e As GridFillRectangleHookEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("FillRectangleHook", e)
		End Sub

		Private Sub grid_FileNameChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("FileNameChanged", e)
		End Sub
		Private Sub grid_GiveFeedback(ByVal sender As Object, ByVal e As GiveFeedbackEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("GiveFeedback", e)
		End Sub
		Private Sub grid_GridBoundsChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("GridBoundsChanged", e)
		End Sub
		Private Sub grid_GridControlMouseDown(ByVal sender As Object, ByVal e As CancelMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("GridControlMouseDown", e)
		End Sub
		Private Sub grid_GridControlMouseMove(ByVal sender As Object, ByVal e As CancelMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("GridControlMouseMove", e)
		End Sub
		Private Sub grid_GridControlMouseUp(ByVal sender As Object, ByVal e As CancelMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("GridControlMouseUp", e)
		End Sub

		Private Sub grid_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("GotFocus", e)
		End Sub

		Private Sub grid_HandleCreated(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("HandleCreated", e)
		End Sub
		Private Sub grid_HandleDestroyed(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("HandleDestroyed", e)
		End Sub
		Private Sub grid_HeaderColCountChanged(ByVal sender As Object, ByVal e As GridCountChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("HeaderColCountChanged", e)
		End Sub
		Private Sub grid_HeaderColCountChanging(ByVal sender As Object, ByVal e As GridCountChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("HeaderColCountChanging", e)
		End Sub

		Private Sub grid_HeaderRowCountChanged(ByVal sender As Object, ByVal e As GridCountChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("HeaderRowCountChanged", e)
		End Sub
		Private Sub grid_HeaderRowCountChanging(ByVal sender As Object, ByVal e As GridCountChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.AppendOutput("HeaderRowCountChanging", e)
			etracer.eventtype = "Grid"
		End Sub

		Private Sub grid_HelpRequested(ByVal sender As Object, ByVal hlpevent As HelpEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, hlpevent)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("HelpRequested", hlpevent)
		End Sub

		Private Sub grid_HorizontalScroll(ByVal sender As Object, ByVal e As ScrollEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("HorizontalScroll", e)
		End Sub
		Private Sub grid_HScrollPixelPosChanged(ByVal sender As Object, ByVal e As GridScrollPositionChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("HScrollPixelPosChanged", e)
		End Sub
		Private Sub grid_HScrollPixelPosChanging(ByVal sender As Object, ByVal e As GridScrollPositionChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("HScrollPixelPosChanging", e)
		End Sub

		Private Sub grid_ImeModeChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ImeModeChanged", e)
		End Sub

		Private Sub grid_IntelliMouseDragScrolling(ByVal sender As Object, ByVal e As IntelliMouseDragScrollEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("IntelliMouseDragScrolling", e)
		End Sub

		Private Sub grid_Invalidated(ByVal sender As Object, ByVal e As InvalidateEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Invalidated", e)
		End Sub

		Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("KeyDown", e)
		End Sub

		Private Sub grid_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("KeyPress", e)
		End Sub

		Private Sub grid_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("KeyUp", e)
		End Sub

		Private Sub grid_LeftColChanged(ByVal sender As Object, ByVal e As GridRowColIndexChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("LeftColChanged", e)
		End Sub
		Private Sub grid_LeftColChanging(ByVal sender As Object, ByVal e As GridRowColIndexChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("LeftColChanging", e)
		End Sub
		Private Sub grid_LocationChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("LocationChanged", e)
		End Sub
		Private Sub grid_MarginChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("MarginChanged", e)
		End Sub
		Private Sub grid_MergeCellsChanged(ByVal sender As Object, ByVal e As GridMergeCellsChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("MergeCellsChanged", e)
		End Sub

		Private Sub grid_Layout(ByVal sender As Object, ByVal e As LayoutEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Layout", e)
		End Sub

		Private Sub grid_Leave(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Leave", e)
			'sta = 0;
		End Sub

		Private Sub grid_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("LostFocus", e)
		End Sub

		Private Sub grid_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseDown", e)
		End Sub

		Private Sub grid_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseUp", e)
		End Sub

		Private Sub grid_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseEnter", e)
		End Sub

		Private Sub grid_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseLeave", e)
		End Sub

		Private Sub grid_ModelChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ModelChanged", e)
		End Sub
		Private Sub grid_ModifiedChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ModifiedChanged", e)
		End Sub
		Private Sub grid_MouseActivating(ByVal sender As Object, ByVal e As CancelEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseActivating", e)
		End Sub
		Private Sub grid_MouseCaptureChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseCaptureChanged", e)
		End Sub

		Private Sub grid_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseClick", e)
		End Sub

		Private Sub grid_MouseHover(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseHover", e)
		End Sub
		Private Sub grid_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseMove", e)
		End Sub
		Private Sub grid_MouseWheel(ByVal sender As Object, ByVal e As MouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseWheel", e)
		End Sub
		Private Sub grid_MouseWheelZoom(ByVal sender As Object, ByVal e As MouseWheelZoomEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("MouseWheelZoom", e)
		End Sub
		Private Sub grid_Move(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("Move", e)
		End Sub
		Private Sub grid_MoveCurrentCellDirection(ByVal sender As Object, ByVal e As GridMoveCurrentCellDirectionEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Cell"
			etracer.AppendOutput("MoveCurrentCellDirection", e)
		End Sub
		Private Sub grid_Office2007ScrollBarsChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Office2007ScrollBarsChanged", e)
		End Sub
		Private Sub grid_Office2007ScrollBarsColorSchemeChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Office2007ScrollBarsColorSchemeChanged", e)
		End Sub
		Private Sub grid_OperationFeedback(ByVal sender As Object, ByVal e As Syncfusion.ComponentModel.OperationFeedbackEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("OperationFeedback", e)
		End Sub

		Private Sub grid_PaddingChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("PaddingChanged", e)
		End Sub

		Private Sub grid_ParentChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ParentChanged", e)
		End Sub
		Private Sub grid_ParseCommonFormats(ByVal sender As Object, ByVal e As GridCellTextEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ParseCommonFormats", e)
		End Sub
		Private Sub grid_PasteCellText(ByVal sender As Object, ByVal e As GridPasteCellTextEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("PasteCellText", e)
		End Sub
		Private Sub grid_PrepareChangeSelection(ByVal sender As Object, ByVal e As GridPrepareChangeSelectionEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("PrepareChangeSelection", e)
		End Sub
		Private Sub grid_PrepareClearSelection(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("PrepareClearSelection", e)
		End Sub
		Private Sub grid_PrepareGraphics(ByVal sender As Object, ByVal e As Syncfusion.Drawing.GraphicsEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("PrepareGraphics", e)
		End Sub
		Private Sub grid_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridPrepareViewStyleInfoEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("PrepareViewStyleInfo", e)
		End Sub
		Private Sub grid_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("PreviewKeyDown", e)
		End Sub
		Private Sub grid_PrintingModeChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("PrintingModeChanged", e)
		End Sub

		Private Sub grid_ReadOnlyChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ReadOnlyChanged", e)
		End Sub
		Private Sub grid_RefreshRequest(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RefreshRequest", e)
		End Sub
		Private Sub grid_RegionChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RegionChanged", e)
		End Sub
		Private Sub grid_Resize(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Resize", e)
		End Sub
		Private Sub grid_RightToLeftChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RightToLeftChanged", e)
		End Sub
		Private Sub grid_RowHeightsChanged(ByVal sender As Object, ByVal e As GridRowColSizeChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowHeightsChanged", e)
		End Sub
		Private Sub grid_RowHeightsChanging(ByVal sender As Object, ByVal e As GridRowColSizeChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowHeightsChanging", e)
		End Sub
		Private Sub grid_RowsHidden(ByVal sender As Object, ByVal e As GridRowColHiddenEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowsHidden", e)
		End Sub
		Private Sub grid_RowsHiding(ByVal sender As Object, ByVal e As GridRowColHidingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowsHiding", e)
		End Sub
		Private Sub grid_RowsInserted(ByVal sender As Object, ByVal e As GridRangeInsertedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowsInserted", e)
		End Sub
		Private Sub grid_RowsInserting(ByVal sender As Object, ByVal e As GridRangeInsertingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowsInserting", e)
		End Sub
		Private Sub grid_RowsMoved(ByVal sender As Object, ByVal e As GridRangeMovedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowsMoved", e)
		End Sub
		Private Sub grid_RowsMoving(ByVal sender As Object, ByVal e As GridRangeMovingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowsMoving", e)
		End Sub
		Private Sub grid_RowsRemoved(ByVal sender As Object, ByVal e As GridRangeRemovedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowsRemoved", e)
		End Sub
		Private Sub grid_RowsRemoving(ByVal sender As Object, ByVal e As GridRangeRemovingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("RowsRemoving", e)
		End Sub

		Private Sub grid_ResizingColumns(ByVal sender As Object, ByVal e As GridResizingColumnsEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ResizingColumns", e)
		End Sub

		Private Sub grid_ResizingRows(ByVal sender As Object, ByVal e As GridResizingRowsEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ResizingRows", e)
		End Sub

		Private Sub grid_SaveCellFormattedText(ByVal sender As Object, ByVal e As GridCellTextEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SaveCellFormattedText", e)
		End Sub
		Private Sub grid_SaveCellInfo(ByVal sender As Object, ByVal e As GridSaveCellInfoEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SaveCellInfo", e)
		End Sub
		Private Sub grid_SaveCellText(ByVal sender As Object, ByVal e As GridCellTextEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SaveCellText", e)
		End Sub
		Private Sub grid_SaveColCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SaveColCount", e)
		End Sub
		Private Sub grid_SaveColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SaveColWidth", e)
		End Sub
		Private Sub grid_SaveRowCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SaveRowCount", e)
		End Sub
		Private Sub grid_SaveRowHeight(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SaveRowHeight", e)
		End Sub
		Private Sub grid_ScrollbarsVisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ScrollbarsVisibleChanged", e)
		End Sub
		Private Sub grid_ScrollControlHandledMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("ScrollControlHandledMouseDown", e)
		End Sub
		Private Sub grid_ScrollControlHandledMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("ScrollControlHandledMouseMove", e)
		End Sub
		Private Sub grid_ScrollControlHandledMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("ScrollControlHandledMouseUp", e)
		End Sub
		Private Sub grid_ScrollControlMouseDown(ByVal sender As Object, ByVal e As CancelMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("ScrollControlMouseDown", e)
		End Sub
		Private Sub grid_ScrollControlMouseMove(ByVal sender As Object, ByVal e As CancelMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("ScrollControlMouseMove", e)
		End Sub
		Private Sub grid_ScrollControlMouseUp(ByVal sender As Object, ByVal e As CancelMouseEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Mouse"
			etracer.AppendOutput("ScrollControlMouseUp", e)
		End Sub
		Private Sub grid_ScrollTipFeedback(ByVal sender As Object, ByVal e As ScrollTipFeedbackEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ScrollTipFeedback", e)
		End Sub
		Private Sub grid_SelectionChanged(ByVal sender As Object, ByVal e As GridSelectionChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SelectionChanged", e)
		End Sub
		Private Sub grid_SelectionChanging(ByVal sender As Object, ByVal e As GridSelectionChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SelectionChanged", e)
		End Sub
		Private Sub grid_SelectionFrameChanged(ByVal sender As Object, ByVal e As Syncfusion.Drawing.GraphicsEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SelectionFrameChanged", e)
		End Sub
		Private Sub grid_SelectionFrameChanging(ByVal sender As Object, ByVal e As Syncfusion.Drawing.GraphicsEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SelectionFrameChanging", e)
		End Sub
		Private Sub grid_ShowContextMenu(ByVal sender As Object, ByVal e As ShowContextMenuEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ShowContextMenu", e)
		End Sub
		Private Sub grid_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SizeChanged", e)
		End Sub
		Private Sub grid_SplitterPaneClosed(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SplitterPaneClosed", e)
		End Sub
		Private Sub grid_SplitterPaneClosing(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SplitterPaneClosing", e)
		End Sub
		Private Sub grid_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("StyleChanged", e)
		End Sub
		Private Sub grid_SupportsTransparentBackColorChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SupportsTransparentBackColorChanged", e)
		End Sub
		Private Sub grid_SystemColorsChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SystemColorsChanged", e)
		End Sub

		Private Sub grid_ScrollInfoChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("ScrollInfoChanged", e)
		End Sub

		Private Sub grid_SelectionDragging(ByVal sender As Object, ByVal e As GridSelectionDragEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SelectionDragging", e)
		End Sub

		Private Sub grid_SelectionDragged(ByVal sender As Object, ByVal e As GridSelectionDragEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("SelectionDragged", e)
		End Sub

		Private Sub grid_StartAutoScrolling(ByVal sender As Object, ByVal e As StartAutoScrollingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("StartAutoScrolling", e)
		End Sub

		Private Sub grid_TabIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("TabIndexChanged", e)
		End Sub
		Private Sub grid_TabStopChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("TabStopChanged", e)
		End Sub
		Private Sub grid_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("TextChanged", e)
		End Sub
		Private Sub grid_ThemeChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.AppendOutput("ThemeChanged", e)
		End Sub
		Private Sub grid_TopRowChanged(ByVal sender As Object, ByVal e As GridRowColIndexChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("TopRowChanged", e)
		End Sub
		Private Sub grid_TopRowChanging(ByVal sender As Object, ByVal e As GridRowColIndexChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("TopRowChanging", e)
		End Sub
		Private Sub grid_UpdatingChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("UpdatingChanged", e)
		End Sub
		Private Sub grid_VerticalScroll(ByVal sender As Object, ByVal e As ScrollEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("VerticalScroll", e)
		End Sub
		Private Sub grid_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("VisibleChanged", e)
		End Sub
		Private Sub grid_VScrollPixelPosChanged(ByVal sender As Object, ByVal e As GridScrollPositionChangedEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("VScrollPixelPosChanged", e)
		End Sub
		Private Sub grid_VScrollPixelPosChanging(ByVal sender As Object, ByVal e As GridScrollPositionChangingEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("VScrollPixelPosChanging", e)
		End Sub

		Private Sub grid_Validated(ByVal sender As Object, ByVal e As EventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Validated", e)
		End Sub

		Private Sub grid_Validating(ByVal sender As Object, ByVal e As CancelEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("Validating", e)
		End Sub

		Private Sub grid_WindowScrolled(ByVal sender As Object, ByVal e As ScrollWindowEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("WindowScrolled", e)
		End Sub
		Private Sub grid_WindowScrolling(ByVal sender As Object, ByVal e As ScrollWindowEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("WindowScrolling", e)
		End Sub
		Private Sub grid_WrapCellNextControlInForm(ByVal sender As Object, ByVal e As GridWrapCellNextControlInFormEventArgs)
			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
			etracer.eventtype = "Grid"
			etracer.AppendOutput("WrapCellNextControlInForm", e)
		End Sub
	End Class
End Namespace