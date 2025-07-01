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

Imports System
Imports System.Collections
Imports System.Drawing
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Grid


'/ <summary>
'/ Summary description for GridMarkHeadersHelper.
'/ </summary>
Public Class GridMarkHeadersHelper
    Implements IDisposable
    Private grid As GridControlBase
    Private mColor As Color = Color.Orange
    Private menu As ContextMenu
    Private hookGrids As New ArrayList()

    '/ <summary>
    '/ base color used to mark header cells and current row
    '/ </summary>
    Public Property MarkColor() As Color
        Get
            Return mColor
        End Get
        Set(ByVal Value As Color)
            mColor = Value
        End Set
    End Property

    Public Property ContextMenu() As ContextMenu
        Get
            Return menu
        End Get
        Set(ByVal Value As ContextMenu)
            menu = Value
        End Set
    End Property

    '/ <summary>
    '/ Constructor
    '/ </summary>
    '/ <param name="grid">The GridControl or GridDataBoundGrid object being used.</param>
    Public Sub New(ByVal grid As GridControlBase)
        Me.grid = grid

        Me.menu = New ContextMenu()

        Me.menu.MenuItems.Add("Named Range Editor", New EventHandler(AddressOf namedRangeEditor_Click))


        AddHandler Me.grid.CurrentCellMoved, AddressOf grid_CurrentCellMoved
        AddHandler Me.grid.MouseDown, AddressOf grid_MouseDown

        Me.grid.Model.Options.SelectCellsMouseButtonsMask = MouseButtons.Left
    End Sub 'New


    Public Sub RegisterGridForContextMenu(ByVal grid As GridControlBase)
        AddHandler grid.MouseDown, AddressOf grid_MouseDown
        hookGrids.Add(grid)
    End Sub 'RegisterGridForContextMenu


    Private Sub grid_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Dim grid As GridControlBase = sender
            Me.menu.Show(grid, New Point(e.X, e.Y)) '
        End If
    End Sub 'grid_MouseDown



    Private Sub namedRangeEditor_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim engine As GridFormulaEngine = CType(grid.Model.CellModels("FormulaCell"), GridFormulaCellModel).Engine
        GridFormulaNamedRangesEditHelper.ShowNamedRangesDialog(engine)
    End Sub 'namedRangeEditor_Click


    Private Sub grid_CurrentCellMoved(ByVal sender As Object, ByVal e As GridCurrentCellMovedEventArgs)
        Dim cc As GridCurrentCell = Me.grid.CurrentCell
        Me.grid.RefreshRange(GridRangeInfo.Cell(0, cc.MoveFromColIndex))
        Me.grid.RefreshRange(GridRangeInfo.Cell(0, cc.MoveToColIndex))
        Me.grid.RefreshRange(GridRangeInfo.Row(cc.MoveToRowIndex))
        Me.grid.RefreshRange(GridRangeInfo.Row(cc.MoveFromRowIndex))
    End Sub 'grid_CurrentCellMoved
    '/ <summary>
    '/ call to unsubscribe to grid events used in this helper class
    '/ </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        If Not grid.IsDisposed Then
            RemoveHandler Me.grid.CurrentCellMoved, AddressOf grid_CurrentCellMoved
            RemoveHandler Me.grid.MouseDown, AddressOf grid_MouseDown
            Dim g As GridControlBase
            For Each g In hookGrids
                RemoveHandler g.MouseDown, AddressOf grid_MouseDown
            Next g
        End If
    End Sub 'Dispose 
End Class 'GridMarkHeadersHelper 