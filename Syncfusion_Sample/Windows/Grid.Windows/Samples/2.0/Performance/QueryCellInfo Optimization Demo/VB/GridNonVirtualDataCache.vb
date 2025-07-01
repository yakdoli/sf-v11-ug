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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Threading

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Styles
Imports Syncfusion.Collections
Imports Syncfusion.Diagnostics


'/ <summary>
'/ Provides a volatile data container that is optimized for non-virtual grids with
    '/ a smaller number of rows where QueryCellInfo event is only
    '/ wanted to be called once for a cell and not multiple times .
    '/ <para/> PrepareViewStyleInfo is still supported and
    '/ can be enabled/disabled with <see cref="GridControlBase.SupportsPrepareViewStyleInfo"/>
    '/ </summary>
    
    Public Class GridOneTimeOnlyQueryCellInfoCache
    Implements IGridVolatileData
        '/ <summary>
        '/ Specifies whether base styles (see <see cref="GridStyleInfo.BaseStyle"/> in <see cref="GridStyleInfo"/> class)
        '/ should be supported.
        '/ </summary>
        Public Shared SupportBaseStyles As Boolean = True
        
        Private _gridModel As OneTimeOnlyQueryCellInfoGridModel
        Private _dataCache As GridStyleInfoCache
        
        
        Public Sub New(gridModel As GridModel)
            _gridModel = CType(gridModel, OneTimeOnlyQueryCellInfoGridModel)
            _dataCache = New GridStyleInfoCache()
        End Sub 'New
        
        #Region "IGridData Members"
        
        
    Default Public Property Item(ByVal rowIndex As Integer, ByVal colIndex As Integer) As GridStyleInfo Implements IGridData.Item
        Get
            Dim style As GridStyleInfo = _dataCache(rowIndex, colIndex)
            If style Is Nothing Then
                If rowIndex > _gridModel.Data.RowCount Then
                    _gridModel.Data.RowCount = Me.RowCount
                End If
                If colIndex > _gridModel.Data.ColCount Then
                    _gridModel.Data.ColCount = Me.ColCount
                End If
                Dim store As GridStyleInfoStore = _gridModel.Data(rowIndex, colIndex)
                If store Is Nothing Then
                    store = New GridStyleInfoStore()
                    _gridModel.Data(rowIndex, colIndex) = store
                End If
                style = New GridStyleInfo(New GridStyleInfoIdentity(Me, rowIndex, colIndex), store)
                style.BeginInit()
                GC.SuppressFinalize(style.Identity)
                Dim e As New GridQueryCellInfoEventArgs(rowIndex, colIndex, style)
                Me._gridModel.RaiseQueryCellInfo(e)
                _dataCache.RowCount = _gridModel.Data.RowCount
                _dataCache.ColCount = _gridModel.Data.ColCount
                _dataCache(rowIndex, colIndex) = e.Style
                style.EndInit()
            End If
            Return style
        End Get
        Set(ByVal Value As GridStyleInfo)
            Dim style As GridStyleInfo = _dataCache(rowIndex, colIndex)
            If Not [Object].ReferenceEquals(style, Value) Then
                Me(rowIndex, colIndex).ModifyStyle(Value, StyleModifyType.Changes)
            End If
            _gridModel.Data(rowIndex, colIndex) = Value.Store
        End Set
    End Property


    Public Function LookupCellModel(ByVal id As String) As GridCellModelBase Implements IGridData.LookupCellModel
        Return _gridModel.CellModels(id)
    End Function 'LookupCellModel


    Public ReadOnly Property BaseStylesMap() As GridBaseStylesMap Implements IGridData.BaseStylesMap
        Get
            Return _gridModel.BaseStylesMap
        End Get
    End Property


    Public Function GetBaseStyles(ByVal styleInfo As GridStyleInfo, ByVal rowIndex As Integer, ByVal colIndex As Integer) As GridStyleInfo() Implements IGridData.GetBaseStyles
        If SupportBaseStyles Then
            Return _GetBaseStyles(styleInfo, rowIndex, colIndex)
        Else
            Return _GetSimpleBaseStyles(styleInfo, rowIndex, colIndex)
        End If
    End Function 'GetBaseStyles 
    Private cachedBaseStyles As GridStyleInfo() = Nothing
    Private headerBaseStyles As GridStyleInfo() = Nothing


    Function _GetBaseStyles(ByVal styleInfo As GridStyleInfo, ByVal rowIndex As Integer, ByVal colIndex As Integer) As GridStyleInfo()
        Dim cellStyles() As GridStyleInfo
        Dim cellStyleCount As Integer = 0

        ' Row, Column and Table style
        Dim headerRowCount As Integer = _gridModel.Rows.HeaderCount
        Dim headerColCount As Integer = _gridModel.Cols.HeaderCount
        If colIndex > headerColCount AndAlso rowIndex > headerRowCount Then
            If rowIndex = 0 Then
                cellStyles = New GridStyleInfo() {RowStyles(rowIndex), TableStyle}
            ElseIf colIndex = 0 Then
                cellStyles = New GridStyleInfo() {ColStyles(colIndex), TableStyle}
            Else
                cellStyles = New GridStyleInfo() {RowStyles(rowIndex), ColStyles(colIndex), TableStyle}
            End If
            cellStyleCount = cellStyles.Length
        ElseIf colIndex >= 0 AndAlso rowIndex < 0 OrElse (rowIndex >= 0 AndAlso colIndex < 0) Then
            cellStyles = New GridStyleInfo() {TableStyle}
            cellStyleCount = cellStyles.Length
        Else
            cellStyles = Nothing
        End If
        ' base style
        Dim item As GridStyleInfo = styleInfo
        If styleInfo Is Nothing Then
            item = Me(rowIndex, colIndex)
        End If
        Dim baseStyleName As String = ""
        If item.HasBaseStyle Then
            baseStyleName = item.BaseStyle
        End If
        If baseStyleName.Length = 0 AndAlso Not (cellStyles Is Nothing) Then
            Dim si As GridStyleInfo
            For Each si In cellStyles
                If si.HasBaseStyle Then
                    baseStyleName = si.BaseStyle
                    If baseStyleName.Length > 0 Then
                        Exit For
                    End If
                End If
            Next si
        End If
        ' row or column header
        If baseStyleName.Length = 0 Then
            If rowIndex >= 0 AndAlso colIndex >= 0 Then
                If rowIndex <= headerRowCount AndAlso colIndex <= headerColCount Then
                    baseStyleName = "Header"
                ElseIf rowIndex <= headerRowCount Then
                    baseStyleName = "Column Header"
                ElseIf colIndex <= headerColCount Then
                    baseStyleName = "Row Header"
                End If
            End If
        End If
        ' load all parent base styles (including standard style)
        Dim level As Integer
        Dim infoMapStyles As GridStyleInfo() = Me.BaseStylesMap.GetBaseStylesMapStyles(baseStyleName, level)

        ' combine the two arrays.
        Dim baseStyles(cellStyleCount + level - 1) As GridStyleInfo
        If Not (cellStyles Is Nothing) Then
            Array.Copy(cellStyles, 0, baseStyles, 0, cellStyleCount)
        End If
        If Not (infoMapStyles Is Nothing) Then
            Array.Copy(infoMapStyles, 0, baseStyles, cellStyleCount, level)
        End If
        ' each GridStyleInfoIdentity will cache the baseStyles.
        Return baseStyles
    End Function '_GetBaseStyles


    Function _GetSimpleBaseStyles(ByVal styleInfo As GridStyleInfo, ByVal rowIndex As Integer, ByVal colIndex As Integer) As GridStyleInfo()
        If rowIndex < 0 OrElse colIndex < 0 Then
            Return Nothing

        ElseIf rowIndex = 0 OrElse colIndex = 0 Then
            If headerBaseStyles Is Nothing Then
                Dim cellStyleCount As Integer = 0

                ' Row, Column and Table style
                cellStyleCount = 0

                ' base style
                Dim baseStyleName As String = "Header"

                ' load all parent base styles (including standard style)
                Dim level As Integer
                Dim infoMapStyles As GridStyleInfo() = Me.BaseStylesMap.GetBaseStylesMapStyles(baseStyleName, level)

                ' combine the two arrays.
                Dim baseStyles(cellStyleCount + level) As GridStyleInfo
                If Not (infoMapStyles Is Nothing) Then
                    Array.Copy(infoMapStyles, 0, baseStyles, cellStyleCount, level)
                End If
                ' each GridStyleInfoIdentity will cache the baseStyles.
                headerBaseStyles = baseStyles
            End If
            Return headerBaseStyles
        Else
            'return new GridStyleInfo[] { TableStyle };
            If cachedBaseStyles Is Nothing Then
                Dim cellStyles() As GridStyleInfo = {TableStyle}
                Dim cellStyleCount As Integer = 1

                Dim item As GridStyleInfo = styleInfo
                If styleInfo Is Nothing Then
                    item = Me(rowIndex, colIndex)
                End If
                Dim baseStyleName As String = ""
                If item.HasBaseStyle Then
                    baseStyleName = item.BaseStyle
                End If
                ' load standard style
                Dim level As Integer
                Dim infoMapStyles As GridStyleInfo() = Me.BaseStylesMap.GetBaseStylesMapStyles("Standard", level)

                ' combine the two arrays.
                Dim baseStyles(cellStyleCount + level) As GridStyleInfo
                If Not (cellStyles Is Nothing) Then
                    Array.Copy(cellStyles, 0, baseStyles, 0, cellStyleCount)
                End If
                If Not (infoMapStyles Is Nothing) Then
                    Array.Copy(infoMapStyles, 0, baseStyles, cellStyleCount, level)
                End If
                ' each GridStyleInfoIdentity will cache the baseStyles.
                cachedBaseStyles = baseStyles
            End If
            Return cachedBaseStyles
        End If
    End Function '_GetSimpleBaseStyles

#End Region
        
        
        #Region "IGridVolatileData Members"
        
        
    Public Sub ResetRowCount() Implements IGridVolatileData.ResetRowCount
    End Sub 'ResetRowCount


    Public Property ColCount() As Integer Implements IGridVolatileData.ColCount
        Get
            Dim e As New GridRowColCountEventArgs(_gridModel.Data.ColCount)
            _gridModel.RaiseQueryColCount(e)
            Return e.Count
        End Get
        Set(ByVal Value As Integer)
            _gridModel.Data.ColCount = Value
        End Set
    End Property


    Public Property RowCount() As Integer Implements IGridVolatileData.RowCount
        Get
            Dim e As New GridRowColCountEventArgs(_gridModel.Data.RowCount)
            _gridModel.RaiseQueryRowCount(e)
            Return e.Count
        End Get
        Set(ByVal Value As Integer)
            _gridModel.Data.RowCount = Value
        End Set
    End Property


    Public ReadOnly Property HasRowCount() As Boolean Implements IGridVolatileData.HasRowCount
        Get
            Return True
        End Get
    End Property


    Public Sub Clear() Implements IGridVolatileData.Clear
        ' Called from ResetVolatileData, e.g. when Insert, Remove or Sorted data
        Me._dataCache.Clear()
    End Sub 'Clear


    Public ReadOnly Property HasColCount() As Boolean Implements IGridVolatileData.HasColCount
        Get
            Return True
        End Get
    End Property


    Public Sub ResetColCount() Implements IGridVolatileData.ResetColCount
    End Sub 'ResetColCount


    Public Sub ResetItem(ByVal cell As GridCellPos) Implements IGridVolatileData.ResetItem
        If cell.RowNumber <= _dataCache.RowCount AndAlso cell.ColumnNumber <= _dataCache.ColCount Then
            _dataCache(cell.RowNumber, cell.ColumnNumber) = Nothing
        End If
    End Sub 'ResetItem 
#End Region
        
        
        Public Class RowStylesIndexer
            Private _dataCacheParent As GridOneTimeOnlyQueryCellInfoCache
            
            Friend Sub New(_dataCache As GridOneTimeOnlyQueryCellInfoCache)
                _dataCacheParent = _dataCache
            End Sub 'New
            
            Default Public Property Item(rowIndex As Integer) As GridStyleInfo
                Get
                    Return _dataCacheParent(rowIndex, - 1)
                End Get
                Set
                    _dataCacheParent(rowIndex, - 1) = value
                End Set
            End Property
        End Class 'RowStylesIndexer
        
        Private _rowStyles As RowStylesIndexer = Nothing
        
        
        Public ReadOnly Property RowStyles() As RowStylesIndexer
            Get
                If _rowStyles Is Nothing Then
                    _rowStyles = New RowStylesIndexer(Me)
                End If
                Return _rowStyles
            End Get
        End Property
        
        
        Public Class ColStylesIndexer
            Private _dataCacheParent As GridOneTimeOnlyQueryCellInfoCache
            
            Friend Sub New(_dataCache As GridOneTimeOnlyQueryCellInfoCache)
                _dataCacheParent = _dataCache
            End Sub 'New
            
            Default Public Property Item(colIndex As Integer) As GridStyleInfo
                Get
                    Return _dataCacheParent(- 1, colIndex)
                End Get
                Set
                    _dataCacheParent(- 1, colIndex) = value
                End Set
            End Property
        End Class 'ColStylesIndexer
        
        Private _colStyles As ColStylesIndexer = Nothing
        
        
        Public ReadOnly Property ColStyles() As ColStylesIndexer
            Get
                If _colStyles Is Nothing Then
                    _colStyles = New ColStylesIndexer(Me)
                End If
                Return _colStyles
            End Get
        End Property
        
        
        Public Property TableStyle() As GridStyleInfo
            Get
                Return Me(- 1, - 1)
            End Get
            Set
                Me(- 1, - 1) = value
            End Set
        End Property
        
        
        
        Public Class GridStyleInfoCache
            Private sfTable As SFTable
            Private Const delta As Integer = 1
            
            
            '/ <summary>
            '/ Initializes a new instance of the GridStyleInfoCache class.
            '/ </summary>
            Public Sub New()
                sfTable = New GridRowCollection()
                sfTable.RowCount = delta + 1
                sfTable.ColCount = delta + 1
            End Sub 'New
            
            
            '/ <summary>
            '/ Resets the row and column count to zero and clears all cells.
            '/ </summary>
            Public Overridable Sub Clear()
                sfTable.Clear()
                sfTable.RowCount = delta + 1
                sfTable.ColCount = delta + 1
            End Sub 'Clear
            
            '/ <summary>
            '/ Gets or sets the row count in the <see cref="GridStyleInfoCache"/> table.
            '/ </summary>
            '/ <remarks>
            '/ The row count does not include headers and column styles. If you set the row count to be 2 there will
            '/ be one column header, one column style and two grid rows with cells.
            '/ </remarks>
            
            Public Overridable Property RowCount() As Integer
                Get
                    ' There is a delta of two (or delta) rows because GridStyleInfoCache has 
                    ' one first header row (row 0) that is not counted with RowCount
                    ' and one column styles row (row -1) that is not counted.
                    Return Math.Max(0, sfTable.RowCount - delta - 1)
                End Get
                Set
                    sfTable.RowCount = value + delta + 1
                End Set
            End Property
            
            '/ <summary>
            '/ Gets or sets the column count in the <see cref="GridStyleInfoCache"/> table.
            '/ </summary>
            '/ <remarks>
            '/ The column count does not include headers and row styles. If you set the column count to be 2 there will
            '/ be one row header, one row style and two grid columns with cells.
            '/ </remarks>
            
            Public Overridable Property ColCount() As Integer
                Get
                    ' There is a delta of two (or delta) columns because GridStyleInfoCache has 
                    ' one first header column (column 0) that is not counted with ColCount
                    ' and one row styles column (column -1) that is not counted.
                    Return Math.Max(0, sfTable.ColCount - delta - 1)
                End Get
                Set
                    sfTable.ColCount = value + delta + 1
                End Set
            End Property
            
            
            '/ <summary>
            '/ Tests if the cell at the specified row and column index has been initialized.
            '/ </summary>
            '/ <param name="rowIndex">The row index. Can be 0 for column headers and -1 for column styles.</param>
            '/ <param name="colIndex">The column index. Can be 0 for row headers and -1 for row styles.</param>
            '/ <returns></returns>
            Public Function Contains(rowIndex As Integer, colIndex As Integer) As Boolean
                Return sfTable.Contains(rowIndex + 1, colIndex + 1)
            End Function 'Contains
            
            '/ <summary>
            '/ The cell contents at the specified row and column index.
            '/ </summary>
            '/ <param name="rowIndex">The row index. Can be 0 for column headers and -1 for column styles.</param>
            '/ <param name="colIndex">The column index. Can be 0 for row headers and -1 for row styles.</param>
            '/ <returns>A <see cref="GridStyleInfo"/> with the specified cells _dataCache. Can be null if cell has not been intialized
            '/ for the specified position.</returns>
            
            Default Public Property Item(rowIndex As Integer, colIndex As Integer) As GridStyleInfo
                Get
                    Return sfTable(rowIndex + 1, colIndex + 1) '
            End Get
            Set(ByVal Value As GridStyleInfo)
                sfTable(rowIndex + 1, colIndex + 1) = Value
            End Set
        End Property
    End Class 'GridStyleInfoCache
    End Class 'GridOneTimeOnlyQueryCellInfoCache
