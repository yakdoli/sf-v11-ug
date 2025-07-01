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
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms


Public Class GridHierDataBoundGrid
    Inherits GridDataBoundGrid
    'Fields
    'Constructors
    'Events
    'Methods
    Public Sub New(ByVal f As Form, ByVal parentTable As DataTable, ByVal childTable As DataTable, ByVal childGrid As GridDataBoundGrid, ByVal queryFilterHandler As QueryFilterStringEventHandler, ByVal queryFormatHandler As QueryFormatGridEventHandler, ByVal hasChildGrid As Boolean)
        MyBase.New()
        If hasChildGrid Then
            'add special cell control (dropdowngrid)
            Dim cellModel As DBDropDownGridCellModel
            cellModel = New DBDropDownGridCellModel(Me.Model)
            'DDGridCellModel cellModel = new DDGridCellModel(this.Model);
            cellModel.EmbeddedGrid = childGrid
            'make the orderGrid the dropgrid
            cellModel.DataSource = childTable
            AddHandler cellModel.QueryFilterString, queryFilterHandler
            AddHandler cellModel.QueryFormatGrid, queryFormatHandler
            Me.Model.CellModels.Add("DBDropDownGridCell", cellModel)
        End If
        Me.DataSource = parentTable
        'set up GridBoundColumns for the parentTable
        Dim cm As CurrencyManager
        cm = CType(f.BindingContext(parentTable), CurrencyManager)
        Dim pdc As PropertyDescriptorCollection
        pdc = cm.GetItemProperties
        Dim gbc As GridBoundColumn
        Me.GridBoundColumns.Clear()
        'add the reset
        If hasChildGrid Then
            'add special unbound column at beginning
            gbc = New GridBoundColumn()
            gbc.MappingName = ""
            gbc.HeaderText = "    "
            gbc.StyleInfo.CellType = "DBDropDownGridCell"
            gbc.StyleInfo.CellValue = ""
            Me.GridBoundColumns.Add(gbc)
        End If
        Dim dc As DataColumn
        For Each dc In parentTable.Columns
            Dim pd As PropertyDescriptor
            pd = pdc(dc.ColumnName)
            gbc = New GridBoundColumn(pd)
            gbc.MappingName = dc.ColumnName
            gbc.HeaderText = dc.ColumnName
            Me.GridBoundColumns.Add(gbc)
            'avoid 1st select problem
            '//this.CurrentCell.Deactivate(true);
            'this.customerGrid.Model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.SetCurrent;
            '//this.CurrentCell.Activate(1, 2, GridSetCurrentCellOptions.SetFocus);
        Next
        'this.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0));
        'set the width of th erow headers
        If hasChildGrid Then
            Me.Model.ColWidths(1) = 18
            Me.Model.Cols.FrozenCount = 1
            'this is here to hide an extra column at the end ????
            'remove when the problem is corrected...
            Me.Model.Cols.Hidden(Me.Model.ColCount) = True
        End If
        Me.Model.ColWidths(0) = 18
        Me.ThemesEnabled = True

    End Sub
End Class
