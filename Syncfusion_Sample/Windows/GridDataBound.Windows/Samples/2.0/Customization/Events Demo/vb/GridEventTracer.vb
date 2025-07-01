Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Diagnostics

Namespace DataBoundGridEvents
    ''' <summary>
    ''' Summary description for Class1.
    ''' </summary>
    Public Class GridEventTracer
        Private _splitter As SplitterControl
        Private _output As ListBox
        Private _displayMouseMessage As Boolean = False
        Private traceDebug As Boolean = False

        Public Sub New(ByVal splitter As SplitterControl, ByVal output As ListBox)
            Me._splitter = splitter
            AddHandler splitter.PaneCreated, AddressOf splitter_PaneCreated
            AddHandler splitter.PaneClosing, AddressOf splitter_PaneClosing
            WireGrid(CType(IIf(TypeOf splitter.ActivePane Is GridDataBoundGrid, splitter.ActivePane, Nothing), GridDataBoundGrid))
            Me._output = output
        End Sub

        Public Sub WireGrid(ByVal grid As GridDataBoundGrid)
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
            AddHandler grid.Deactivated, AddressOf grid_Deactivated
            AddHandler grid.DoubleClick, AddressOf grid_DoubleClick
            AddHandler grid.DragDrop, AddressOf grid_DragDrop
            AddHandler grid.DragEnter, AddressOf grid_DragEnter
            AddHandler grid.DragLeave, AddressOf grid_DragLeave
            AddHandler grid.DragOver, AddressOf grid_DragOver
            AddHandler grid.Enter, AddressOf grid_Enter
            AddHandler grid.GotFocus, AddressOf grid_GotFocus
            AddHandler grid.KeyDown, AddressOf grid_KeyDown
            AddHandler grid.KeyPress, AddressOf grid_KeyPress
            AddHandler grid.KeyUp, AddressOf grid_KeyUp
            AddHandler grid.Layout, AddressOf grid_Layout
            AddHandler grid.Leave, AddressOf grid_Leave
            AddHandler grid.LostFocus, AddressOf grid_LostFocus
            AddHandler grid.MouseDown, AddressOf grid_MouseDown
            AddHandler grid.MouseUp, AddressOf grid_MouseUp
            AddHandler grid.MouseEnter, AddressOf grid_MouseEnter
            AddHandler grid.MouseLeave, AddressOf grid_MouseLeave
            AddHandler grid.RowEnter, AddressOf grid_RowEnter

            AddHandler grid.QueryCanOleDragRange, AddressOf grid_QueryCanOleDragRange
            AddHandler grid.QueryNextCurrentCellPosition, AddressOf grid_QueryNextCurrentCellPosition
            'grid.QueryOleDataSourceData += new GridQueryOleDataSourceDataEventHandler(grid_QueryOleDataSourceData);
            AddHandler grid.ResizingColumns, AddressOf grid_ResizingColumns
            AddHandler grid.ResizingRows, AddressOf grid_ResizingRows
            AddHandler grid.ScrollInfoChanged, AddressOf grid_ScrollInfoChanged
            AddHandler grid.SelectionDragging, AddressOf grid_SelectionDragging
            AddHandler grid.SelectionDragged, AddressOf grid_SelectionDragged
            AddHandler grid.StartAutoScrolling, AddressOf grid_StartAutoScrolling
            AddHandler grid.Validated, AddressOf grid_Validated
            AddHandler grid.Validating, AddressOf grid_Validating
            AddHandler grid.WrapCellNextControlInForm, AddressOf grid_WrapCellNextControlInForm
        End Sub

        Public Sub UnwireGrid(ByVal grid As GridDataBoundGrid)
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
            RemoveHandler grid.Deactivated, AddressOf grid_Deactivated
            RemoveHandler grid.DoubleClick, AddressOf grid_DoubleClick
            RemoveHandler grid.DragDrop, AddressOf grid_DragDrop
            RemoveHandler grid.DragEnter, AddressOf grid_DragEnter
            RemoveHandler grid.DragLeave, AddressOf grid_DragLeave
            RemoveHandler grid.DragOver, AddressOf grid_DragOver
            RemoveHandler grid.Enter, AddressOf grid_Enter
            RemoveHandler grid.GotFocus, AddressOf grid_GotFocus
            RemoveHandler grid.KeyDown, AddressOf grid_KeyDown
            RemoveHandler grid.KeyPress, AddressOf grid_KeyPress
            RemoveHandler grid.KeyUp, AddressOf grid_KeyUp
            RemoveHandler grid.Layout, AddressOf grid_Layout
            RemoveHandler grid.Leave, AddressOf grid_Leave
            RemoveHandler grid.LostFocus, AddressOf grid_LostFocus
            RemoveHandler grid.MouseDown, AddressOf grid_MouseDown
            RemoveHandler grid.MouseUp, AddressOf grid_MouseUp
            RemoveHandler grid.MouseEnter, AddressOf grid_MouseEnter
            RemoveHandler grid.MouseLeave, AddressOf grid_MouseLeave
            RemoveHandler grid.QueryCanOleDragRange, AddressOf grid_QueryCanOleDragRange
            RemoveHandler grid.QueryNextCurrentCellPosition, AddressOf grid_QueryNextCurrentCellPosition
            'grid.QueryOleDataSourceData -= new GridQueryOleDataSourceDataEventHandler(grid_QueryOleDataSourceData);
            RemoveHandler grid.ResizingColumns, AddressOf grid_ResizingColumns
            RemoveHandler grid.ResizingRows, AddressOf grid_ResizingRows
            RemoveHandler grid.RowEnter, AddressOf grid_RowEnter

            RemoveHandler grid.ScrollInfoChanged, AddressOf grid_ScrollInfoChanged
            RemoveHandler grid.SelectionDragging, AddressOf grid_SelectionDragging
            RemoveHandler grid.SelectionDragged, AddressOf grid_SelectionDragged
            RemoveHandler grid.StartAutoScrolling, AddressOf grid_StartAutoScrolling
            RemoveHandler grid.Validated, AddressOf grid_Validated
            RemoveHandler grid.Validating, AddressOf grid_Validating
            RemoveHandler grid.WrapCellNextControlInForm, AddressOf grid_WrapCellNextControlInForm
        End Sub

        Private Sub splitter_PaneCreated(ByVal sender As Object, ByVal e As SplitterPaneEventArgs)
            Dim grid As GridDataBoundGrid = CType(IIf(TypeOf e.Control Is GridDataBoundGrid, e.Control, Nothing), GridDataBoundGrid)
            WireGrid(grid)
        End Sub

        Private Sub splitter_PaneClosing(ByVal sender As Object, ByVal e As SplitterPaneEventArgs)
            Dim grid As GridDataBoundGrid = CType(IIf(TypeOf e.Control Is GridDataBoundGrid, e.Control, Nothing), GridDataBoundGrid)
            UnwireGrid(grid)
        End Sub

        Private lastLine As String = ""

        Private Function GetInfo(ByVal name As String) As String
            Dim grid As GridDataBoundGrid = CType(IIf(TypeOf Me._splitter.ActivePane Is GridDataBoundGrid, Me._splitter.ActivePane, Nothing), GridDataBoundGrid)
            Dim s As String = ""
            If Not grid Is Nothing Then
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
                        If Not renderer.ControlValue Is Nothing Then
                            ct = " ControlValue: " & renderer.ControlValue.ToString()
                        Else
                            ct = " ControlValue: null"
                        End If
                    End If
                    Dim st As String = style.Text
                    Dim sv As String = ""
                    If Not style.CellValue Is Nothing Then
                        sv = style.CellValue.ToString()
                    End If

                    s = String.Format("{0}{1} {2}""{3}"", ""{4}"", StyleText: ""{5}"", StyleValue: ""{6}"" ", IIf(cc.IsModified, "*", ""), name, grid.CurrentCell.RangeInfo, ct, cv, st, sv)
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
            Set(ByVal Value As Boolean)
                _enabled = Value
            End Set
        End Property

        Public Property DisplayMouseMessages() As Boolean
            Get
                Return _displayMouseMessage
            End Get
            Set(ByVal Value As Boolean)
                _displayMouseMessage = Value
            End Set
        End Property

        Private Sub AppendOutput(ByVal name As String, ByVal e As EventArgs)
            If (Not Enabled) Then
                Return
            End If

            Dim s As String = ""
            If name.StartsWith("CurrentCell") Then
                'name = name.Substring("CurrentCell".Length);

                s = GetInfo(name) & " " & e.ToString()
            ElseIf DisplayMouseMessages Then
                s = name & " " & e.ToString()
            End If

            If s.Length > 0 Then
                If s <> lastLine Then
                    lastLine = s
                    _output.SelectedIndex = -1
                    _output.Items.Add(s)
                    _output.Items.Add("")
                    _output.TopIndex = Math.Max(0, _output.Items.Count - (_output.Height / _output.ItemHeight))
                End If
            End If
        End Sub

        Public Overrides Function ToString() As String
            Return GetInfo("")
        End Function

        Private Sub grid_CurrentCellMoved(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellMoved", e)
        End Sub

        Private Sub grid_CurrentCellAcceptedChanges(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellAcceptedChanges", e)
        End Sub

        Private Sub grid_CurrentCellActivated(ByVal sender As Object, ByVal e As System.EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellActivated", e)
        End Sub

        Private Sub grid_CurrentCellActivateFailed(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCurrentCellActivateFailedEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellActivateFailed", e)
        End Sub

        Private Sub grid_CurrentCellActivating(ByVal sender As Object, ByVal e As GridCurrentCellActivatingEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellActivating", e)
        End Sub

        Private Sub grid_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellChanged", e)

        End Sub

        Private Sub grid_CurrentCellChanging(ByVal sender As Object, ByVal e As CancelEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellChanging", e)

        End Sub

        Private Sub grid_CurrentCellCloseDropDown(ByVal sender As Object, ByVal e As PopupClosedEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellCloseDropDown", e)

        End Sub

        Private Sub grid_CurrentCellControlLostFocus(ByVal sender As Object, ByVal e As ControlEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellControlLostFocus", e)

        End Sub

        Private Sub grid_CurrentCellMoveFailed(ByVal sender As Object, ByVal e As GridCurrentCellMoveFailedEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellMoveFailed", e)

        End Sub

        Private Sub grid_CurrentCellRejectedChanges(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellRejectedChanges", e)

        End Sub

        Private Sub grid_CurrentCellShowedDropDown(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellShowedDropDown", e)

        End Sub

        Private Sub grid_CurrentCellShowingDropDown(ByVal sender As Object, ByVal e As GridCurrentCellShowingDropDownEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellShowingDropDown", e)

        End Sub

        Private Sub grid_CurrentCellStartEditing(ByVal sender As Object, ByVal e As CancelEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellStartEditing", e)

        End Sub

        Private Sub grid_CurrentCellValidated(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellValidated", e)

        End Sub

        Private Sub grid_CurrentCellValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            ' Force the Renderer.ControValue to be in sync with the
            ' displayed text. You have to decide on a case by case basis
            ' (depeding on what cell renderer you have) if you want to do this ...
            'GridDataBoundGridBase grid = (GridDataBoundGridBase) sender;
            'grid.CurrentCell.Renderer.UpdateControlValue();

            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellValidating", e)
        End Sub

        Private Sub grid_CurrentCellControlDoubleClick(ByVal sender As Object, ByVal e As ControlEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellControlDoubleClick", e)
        End Sub

        Private Sub grid_CurrentCellConfirmChangesFailed(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellConfirmChangesFailed", e)
        End Sub

        Private Sub grid_CurrentCellControlGotFocus(ByVal sender As Object, ByVal e As ControlEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellControlGotFocus", e)

        End Sub

        Private Sub grid_CurrentCellDeactivateFailed(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellDeactivateFailed", e)

        End Sub

        Private Sub grid_CurrentCellDeactivating(ByVal sender As Object, ByVal e As CancelEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellDeactivating", e)

        End Sub

        Private Sub grid_CurrentCellEditingComplete(ByVal sender As Object, ByVal e As EventArgs)

            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellEditingComplete", e)
        End Sub

        Private Sub grid_CurrentCellKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellKeyDown", e)

        End Sub

        Private Sub grid_CurrentCellKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellKeyPress", e)

        End Sub

        Private Sub grid_CurrentCellKeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellKeyUp", e)

        End Sub

        Private Sub grid_CurrentCellDeleting(ByVal sender As Object, ByVal e As CancelEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellDeleting", e)

        End Sub

        Private Sub grid_CurrentCellMoving(ByVal sender As Object, ByVal e As GridCurrentCellMovingEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellMoving", e)

        End Sub

        Private Sub grid_CurrentCellDeactivated(ByVal sender As Object, ByVal e As GridCurrentCellDeactivatedEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellDeactivated", e)

        End Sub

        Private Sub grid_CurrentCellInitializeControlText(ByVal sender As Object, ByVal e As GridCurrentCellInitializeControlTextEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellInitializeControlText", e)

        End Sub

        Private Sub grid_CurrentCellValidateString(ByVal sender As Object, ByVal e As GridCurrentCellValidateStringEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CurrentCellValidateString", e)

        End Sub

        Private Sub grid_CellButtonClicked(ByVal sender As Object, ByVal e As GridCellButtonClickedEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CellButtonClicked", e)

        End Sub

        Private Sub grid_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CellClick", e)

        End Sub

        Private Sub grid_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CellDoubleClick", e)

        End Sub

        Private Sub grid_CellMouseDown(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CellMouseDown", e)

        End Sub

        Private Sub grid_CellMouseHoverEnter(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CellMouseHoverEnter", e)

        End Sub

        Private Sub grid_CellMouseHoverLeave(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CellMouseHoverLeave", e)

        End Sub

        Private Sub grid_CellMouseUp(ByVal sender As Object, ByVal e As GridCellMouseEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CellMouseUp", e)

        End Sub

        Private Sub grid_CheckBoxClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("CheckBoxClick", e)

        End Sub

        Private Sub grid_PushButtonClick(ByVal sender As Object, ByVal e As GridCellPushButtonClickEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("PushButtonClick", e)

        End Sub

        Private Sub grid_Click(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("Click", e)
        End Sub

        Private Sub grid_Deactivated(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("Deactivated", e)
        End Sub

        Private Sub grid_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("DoubleClick", e)
        End Sub

        Private Sub grid_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("DragDrop", e)
        End Sub

        Private Sub grid_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("DragEnter", e)
        End Sub

        Private Sub grid_DragLeave(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("DragLeave", e)
        End Sub

        Private Sub grid_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("DragOver", e)
        End Sub

        Private Sub grid_Enter(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("Enter", e)
        End Sub

        Private Sub grid_GotFocus(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("GotFocus", e)
        End Sub

        Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("KeyDown", e)
        End Sub

        Private Sub grid_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("KeyPress", e)
        End Sub

        Private Sub grid_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("KeyUp", e)
        End Sub

        Private Sub grid_Layout(ByVal sender As Object, ByVal e As LayoutEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("Layout", e)
        End Sub

        Private Sub grid_Leave(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("Leave", e)
        End Sub

        Private Sub grid_LostFocus(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("LostFocus", e)
        End Sub

        Private Sub grid_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("MouseDown", e)
        End Sub

        Private Sub grid_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("MouseUp", e)
        End Sub

        Private Sub grid_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("MouseEnter", e)
        End Sub

        Private Sub grid_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("MouseLeave", e)
        End Sub

        Private Sub grid_QueryCanOleDragRange(ByVal sender As Object, ByVal e As GridQueryCanOleDragRangeEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("QueryCanOleDragRange", e)
        End Sub

        Private Sub grid_QueryNextCurrentCellPosition(ByVal sender As Object, ByVal e As GridQueryNextCurrentCellPositionEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("QueryNextCurrentCellPosition", e)
        End Sub

        Private Sub grid_QueryOleDataSourceData(ByVal sender As Object, ByVal e As GridQueryOleDataSourceDataEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("QueryOleDataSourceData", e)
        End Sub

        Private Sub grid_ResizingColumns(ByVal sender As Object, ByVal e As GridResizingColumnsEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("ResizingColumns", e)
        End Sub

        Private Sub grid_ResizingRows(ByVal sender As Object, ByVal e As GridResizingRowsEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("ResizingRows", e)
        End Sub

        Private Sub grid_ScrollInfoChanged(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("ScrollInfoChanged", e)
        End Sub

        Private Sub grid_SelectionDragging(ByVal sender As Object, ByVal e As GridSelectionDragEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("SelectionDragging", e)
        End Sub

        Private Sub grid_SelectionDragged(ByVal sender As Object, ByVal e As GridSelectionDragEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("SelectionDragged", e)
        End Sub

        Private Sub grid_StartAutoScrolling(ByVal sender As Object, ByVal e As StartAutoScrollingEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("StartAutoScrolling", e)
        End Sub

        Private Sub grid_Validated(ByVal sender As Object, ByVal e As EventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("Validated", e)
        End Sub

        Private Sub grid_Validating(ByVal sender As Object, ByVal e As CancelEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("Validating", e)
        End Sub

        Private Sub grid_WrapCellNextControlInForm(ByVal sender As Object, ByVal e As GridWrapCellNextControlInFormEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("WrapCellNextControlInForm", e)
        End Sub
        Private Sub grid_RowEnter(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridRowEventArgs)
            TraceUtil.TraceCurrentMethodInfoIf(traceDebug, Me, e)
            AppendOutput("RowEnter", e)
        End Sub
        '		private void grid_RowEnter(object sender,RowEnterEventArgs e)
        '		{
        '			TraceUtil.TraceCurrentMethodInfoIf(traceDebug, this, e);
        '			AppendOutput("RowEnter", e);
        '		}

    End Class


End Namespace
