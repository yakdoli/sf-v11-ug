using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion;
using Syncfusion.Windows.Forms.Grid;

namespace AlertMessageLocalization
{
    public class GridControl
    {
        private const int GRP_HEADER_INDEX = 0;
        private const int HEADER_INDEX = 1;

        private const int TOTAL_COLS = 7;
        private const int GRP_COL1_INDEX = 3;
        private const int GRP_COL2_INDEX = 7;

        private Syncfusion.Windows.Forms.Grid.GridControl _grid = null;
        
        public Syncfusion.Windows.Forms.Grid.GridControl Grid
        {
            get { return _grid; }
            set { _grid = value; }
        }

        public GridControl()
        {
            _grid = new Syncfusion.Windows.Forms.Grid.GridControl();

            InitializeGrid();
        }

        private void InitializeGrid()
        {
            this._grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._grid.Size = new System.Drawing.Size(500, 500);
            this._grid.SmartSizeBox = false;

            this._grid.UseRightToLeftCompatibleTextBox = true;

            _grid.Rows.HeaderCount = 1;
            _grid.RowCount = 10;
            _grid.ColCount = TOTAL_COLS;
            
            this._grid.EnterKeyBehavior = Syncfusion.Windows.Forms.Grid.GridDirectionType.Down;
            this._grid.ExcelLikeCurrentCell = true;
            this._grid.Office2007ScrollBars = true;
            this._grid.Office2007ScrollBarsColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black;
            this._grid.CellClick += new GridCellClickEventHandler(_grid_CellClick);
            _grid.AllowDragSelectedCols = true;

            _grid.NumberedColHeaders = false;
        }

        void _grid_CellClick(object sender, GridCellClickEventArgs e)
        {
            if (_grid[e.RowIndex, e.ColIndex].CellValue == "Header")
            {
                this._grid.Selections.Add(GridRangeInfo.Cols(e.ColIndex, e.ColIndex + 3));
            }
        }

        public void InitializeCols()
        {
            for (int colIndex = 1; colIndex <= TOTAL_COLS; colIndex++)
            {
                if (colIndex == GRP_COL1_INDEX)
                {
                    _grid[GRP_HEADER_INDEX, colIndex].CellValue = "Header";

                    this._grid.CoveredRanges.Add(GridRangeInfo.Cells(GRP_HEADER_INDEX, colIndex, GRP_HEADER_INDEX, colIndex + 3));
                }

                _grid[HEADER_INDEX, colIndex].CellValue = "Column " + colIndex.ToString();
            }
            for (int iRow = 2; iRow <= Grid.RowCount; iRow++)
            {
                _grid[iRow, 1].CellValue = iRow;
                _grid[iRow, 2].CellValue = "02/03/2012 12:00 AM";
                _grid[iRow, 3].CellValue = iRow;
                _grid[iRow, 4].CellValue = iRow;
                _grid[iRow, 5].CellValue = iRow;
                _grid[iRow, 6].CellValue = iRow;
                _grid[iRow, 7].CellValue = iRow;              
            }
        }        
    }
}
