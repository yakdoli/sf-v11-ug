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
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms


Public Class DropDownGridCellRenderer
    Inherits GridDropDownGridCellRenderer
    Private WithEvents dbgrid As GridDataBoundGrid
    'Fields
    'Constructors
    'Methods
    Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
        MyBase.New(grid, cellModel)
        Me.DisableTextBox = True
        DropDownButton = New GridCellComboBoxButton(Me)
        Me.dbgrid = Nothing

    End Sub
    Protected Overloads Overrides Function CreateInnerControl(ByRef grid As GridControlBase) As Control

        grid = Me.dbgrid
        grid.Dock = DockStyle.Fill
        Return grid

    End Function
    Public Overloads Overrides Sub DropDownContainerShowingDropDown(ByVal sender As Object, ByVal e As CancelEventArgs)

        If (CType(Grid, GridDataBoundGrid)).Binder.IsAddNew Then
            e.Cancel = True
            Return
        End If

        MyBase.DropDownContainerShowingDropDown(sender, e)

        'fire the event that allows for the formatting of the dropped grid
        dbgrid.BeginInit()
        Dim e1 As QueryFormatGridEventArgs
        e1 = New QueryFormatGridEventArgs(Me.RowIndex, Me.ColIndex, dbgrid)
        CType(Me.Model, DBDropDownGridCellModel).OnQueryFormatGrid(e1)
        dbgrid.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0))
        dbgrid.EndInit()

        'set its height & width based on the parent grid
        Dim width As Integer
        width = ((Me.Grid.Size.Width - Me.Grid.Model.ColWidths(0)) _
                    - SystemInformation.VerticalScrollBarWidth)
        Dim height As Integer
        height = (Math.Max(60, Me.dbgrid.Model.RowHeights.GetTotal(0, Math.Min(6, Me.dbgrid.Model.RowCount))) + SystemInformation.HorizontalScrollBarHeight)
        Me.DropDownContainer.PopupHost.Size = New Size(width, height)

    End Sub
    Protected Overrides Sub OnInitialize(ByVal rowIndex As Integer, ByVal colIndex As Integer)
        Dim cellModel As DBDropDownGridCellModel = CType(Me.Model, DBDropDownGridCellModel)
        Me.dbgrid = cellModel.EmbeddedGrid

        'fire the event to retrieve the filter string...
        Dim filter As String = ""
        Dim e As QueryFilterStringEventArgs = New QueryFilterStringEventArgs(rowIndex, colIndex)
        cellModel.OnQueryFilterString(e)
        filter = e.FilterString
        If filter <> "" Then
            'get the view based on the filter & set it as the datasource
            Dim dt1 As DataTable = CType(cellModel.DataSource, DataTable)
            Dim dv As DataView = New DataView(dt1, filter, "", DataViewRowState.CurrentRows)
            dv.AllowNew = False

            'dv.AllowEdit = false;
            dv.AllowDelete = False

            'make sure dggrid has a binding context...
            If Me.dbgrid.BindingContext Is Nothing Then
                Me.dbgrid.BindingContext = Me.Grid.BindingContext
            End If

            Me.dbgrid.DataSource = dv
        End If
    End Sub

    Public Overrides Sub OnPrepareViewStyleInfo(ByVal e As GridPrepareViewStyleInfoEventArgs)
        If e.RowIndex = Grid.Model.RowCount AndAlso (CType(Grid, GridDataBoundGrid)).EnableAddNew Then
            e.Style.ShowButtons = GridShowButtons.Hide
            e.Style.Clickable = False
        End If

        MyBase.OnPrepareViewStyleInfo(e)
    End Sub
End Class

