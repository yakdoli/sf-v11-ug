#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.Drawing
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms

Namespace ExcelMarker

    Public Class ExcelMarkerMouseController
        Implements IMouseController 'ToDo: Add Implements Clauses for implementation methods of these interface(s)
        Private owner As GridControlBase
        Private activeRange As GridRangeInfo
        Private lastHitTestCode As Integer = GridHitTestContext.None
        Private HitExcelMarker As Integer = 101
        Private delta As Integer = 3
        Private dragWindow As DragWindow
        Private cursor1 As Cursor


        Public Sub New(ByVal owner As GridControlBase)
            Me.owner = owner
        End Sub 'New


        Public Overridable Overloads ReadOnly Property Name() As String Implements IMouseController.Name
            Get
                Return "ExcelMarker"
            End Get
        End Property


        Public Overridable Overloads ReadOnly Property Cursor() As Cursor Implements IMouseController.Cursor

            Get
                If cursor1 Is Nothing Then
                    Dim stream As System.IO.Stream = [GetType]().Module.Assembly.GetManifestResourceStream("ExcelMarker.cross.CUR")
                    If Not (stream Is Nothing) Then
                        cursor1 = New Cursor(stream)
                    Else
                        cursor1 = Cursors.Cross
                    End If
                End If
                ' could check latestHitTestCode here if this controller has
                ' different HitTest states. Cursor will only be called if 
                ' previous call to HitTest was successfull.
                Return cursor1
            End Get
        End Property


        Public Overridable Overloads Sub MouseHoverEnter() Implements IMouseController.MouseHoverEnter
        End Sub 'MouseHoverEnter


        '/ <summary>
        '/ User is moving the mouse over the hot-test area
        '/ </summary>
        '/ <param name="e"></param>
        Public Overridable Overloads Sub MouseHover(ByVal e As MouseEventArgs) Implements IMouseController.MouseHover
        End Sub 'MouseHover


        '/ <summary>
        '/ Called when the hovering ends, either when user has moved mouse away from hittest area
        '/ or when the user has pressed a mouse button.
        '/ </summary>
        Public Overridable Overloads Sub MouseHoverLeave(ByVal e As EventArgs) Implements IMouseController.MouseHoverLeave
        End Sub 'MouseHoverLeave


        Public Overridable Overloads Sub MouseDown(ByVal e As MouseEventArgs) Implements IMouseController.MouseDown
            If e.Button = MouseButtons.Left Then
                If e.Clicks = 1 Then
                    ' Start automatic scrolling when user drags mouse out of window
                    owner.AutoScrolling = ScrollBars.Both

                    ' 
                    Dim rowIndex, colIndex As Integer
                    Dim point As New point(e.X, e.Y)
                    owner.PointToRowCol(point, rowIndex, colIndex)
                    activeRange = owner.Selections.Ranges.ActiveRange

                    dragWindow = New dragWindow()
                    dragWindow.Opacity = 0.4F
                    dragWindow.BackColor = SystemColors.Menu
                    dragWindow.Bounds = GetBounds(activeRange)
                    dragWindow.ShowWindowTopMost()
                End If
            End If
        End Sub 'MouseDown
        ' else if (e.Clicks == 2)
        ' DoubleClick

        Function GetBounds(ByVal range As GridRangeInfo) As Rectangle
            Dim bounds As Rectangle = owner.RangeInfoToRectangle(range, GridRangeOptions.None)
            bounds.Intersect(owner.ClientRectangle)
            bounds = owner.RectangleToScreen(bounds)
            Return bounds
        End Function 'GetBounds


        '/ <summary>
        '/ User has dragged mouse. If mouse is down, set current position.
        '/ </summary>
        '/ <param name="e"></param>
        Public Overridable Overloads Sub MouseMove(ByVal e As MouseEventArgs) Implements IMouseController.MouseMove

            ' Set current position
            Dim rowIndex, colIndex As Integer
            Dim point As New point(e.X - delta, e.Y - delta)
            Try
                owner.PointToRowCol(point, rowIndex, colIndex, 0)
                rowIndex = Math.Max(owner.TopRowIndex, rowIndex)
                colIndex = Math.Max(owner.LeftColIndex, colIndex)
                Dim range As GridRangeInfo = GridRangeInfo.Cells(activeRange.Top, activeRange.Left, rowIndex, colIndex)
                dragWindow.Bounds = GetBounds(range)
                dragWindow.ShowWindowTopMost()
            Catch
            End Try
        End Sub 'MouseMove


        '/ <summary>
        '/ User has release mouse button. Stop automatic scrolling.
        '/ </summary>
        '/ <param name="e"></param>
        Public Overridable Overloads Sub MouseUp(ByVal e As MouseEventArgs) Implements IMouseController.MouseUp
            ' Stop automatic scrolling 
            owner.AutoScrolling = ScrollBars.None

            Dim rowIndex, colIndex As Integer
            Dim point As New point(e.X, e.Y)
            owner.PointToRowCol(point, rowIndex, colIndex)

            dragWindow.Visible = False
            dragWindow = Nothing

            Dim range As GridRangeInfo = GridRangeInfo.Cells(activeRange.Top, activeRange.Left, rowIndex, colIndex)
            MessageBox.Show((owner.Selections.Ranges.ActiveRange.ToString() + " expanded to " + range.ToString()))
        End Sub 'MouseUp


        Public Overridable Overloads Sub CancelMode() Implements IMouseController.CancelMode
            owner.AutoScrolling = ScrollBars.None
            dragWindow.Visible = False
            dragWindow = Nothing
        End Sub 'CancelMode


        Public Overridable Overloads Function HitTest(ByVal e As MouseEventArgs, ByVal controller As IMouseController) As Integer Implements IMouseController.HitTest
            lastHitTestCode = GridHitTestContext.None

            ' Our vote has higher priority than other controllers
            If e.Button = MouseButtons.Left Then '&& 
                ' (controller == null || controller.Name == "ResizeCells")
                Dim range As GridRangeInfo = owner.Selections.Ranges.ActiveRange
                If Not range.IsEmpty Then
                    Dim point1 As Point = New Point(e.X, e.Y)
                    point1.Offset(-delta, -delta)
                    Dim rowIndex, colIndex As Integer
                    owner.PointToRowCol(point1, rowIndex, colIndex)

                    If rowIndex = range.Bottom And colIndex = range.Right Then
                        point1.Offset(delta * 2 + 1, delta * 2 + 1)
                        Dim rowIndex2, colIndex2 As Integer
                        owner.PointToRowCol(point1, rowIndex2, colIndex2)
                        If rowIndex2 <> rowIndex And colIndex2 <> colIndex Then
                            lastHitTestCode = HitExcelMarker
                        End If
                    End If
                End If
            End If
            Return lastHitTestCode
        End Function 'HitTest
    End Class 'ExcelMarkerMouseController
End Namespace
