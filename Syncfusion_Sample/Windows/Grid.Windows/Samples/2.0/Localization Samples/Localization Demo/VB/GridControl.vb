Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion
Imports Syncfusion.Windows.Forms.Grid


Public Class GridControl
    Private Const GRP_HEADER_INDEX As Integer = 0
    Private Const HEADER_INDEX As Integer = 1

    Private Const TOTAL_COLS As Integer = 10
    Private Const GRP_COL1_INDEX As Integer = 3
    Private Const GRP_COL2_INDEX As Integer = 7

    Private _grid As Syncfusion.Windows.Forms.Grid.GridControl = Nothing

    Public Property Grid() As Syncfusion.Windows.Forms.Grid.GridControl
        Get
            Return _grid
        End Get
        Set(ByVal value As Syncfusion.Windows.Forms.Grid.GridControl)
            _grid = value
        End Set
    End Property

    Public Sub New()
        _grid = New Syncfusion.Windows.Forms.Grid.GridControl()

        InitializeGrid()
    End Sub

    Private Sub InitializeGrid()
        Me._grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me._grid.Size = New System.Drawing.Size(500, 500)
        Me._grid.SmartSizeBox = False

        Me._grid.UseRightToLeftCompatibleTextBox = True

        _grid.Rows.HeaderCount = 1
        _grid.RowCount = 10
        _grid.ColCount = TOTAL_COLS

        Me._grid.EnterKeyBehavior = Syncfusion.Windows.Forms.Grid.GridDirectionType.Down
        Me._grid.ExcelLikeCurrentCell = True
        Me._grid.Office2007ScrollBars = True
        Me._grid.Office2007ScrollBarsColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black

        _grid.AllowDragSelectedCols = True

        _grid.NumberedColHeaders = False
    End Sub

    Public Sub InitializeCols()
        For colIndex As Integer = 1 To TOTAL_COLS
            If colIndex = GRP_COL1_INDEX Then
                _grid(GRP_HEADER_INDEX, colIndex).CellValue = "Header"

                Me._grid.CoveredRanges.Add(GridRangeInfo.Cells(GRP_HEADER_INDEX, colIndex, GRP_HEADER_INDEX, colIndex + 3))
            End If

            _grid(HEADER_INDEX, colIndex).CellValue = "Column " & colIndex.ToString()
        Next colIndex
        For iRow As Integer = 2 To Grid.RowCount
            _grid(iRow, 1).CellValue = iRow
            _grid(iRow, 2).CellValue = "02/03/2012 12:00 AM"
            _grid(iRow, 3).CellValue = iRow
            _grid(iRow, 4).CellValue = iRow
            _grid(iRow, 5).CellValue = iRow
            _grid(iRow, 6).CellValue = iRow
            _grid(iRow, 7).CellValue = iRow
            _grid(iRow, 8).CellValue = iRow
            _grid(iRow, 9).CellValue = iRow
            _grid(iRow, 10).CellValue = iRow
        Next iRow
    End Sub
End Class

