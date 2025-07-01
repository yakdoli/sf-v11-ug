#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

using Syncfusion.ComponentModel;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

using Syncfusion.Windows.Forms.Tools.XPMenus;
namespace ExcelLikeUI_2005
{

	/// <summary>
	/// SampleGridModel for Workbook/Worksheet support (see MenuAction.NewWorkbookFile)
	/// </summary>
	public class SampleGridModel : GridModel, ICreateControl
	{
		public override Control CreateControl()
		{
			GridControlBase grid = new SampleGrid(this);            
			grid.FillSplitterPane = true;
			return grid;
		}
	}

	/// <summary>
	///    A derived grid component class.
	/// </summary>
	public class SampleGrid : GridControl
	{
        ExcelLikeThickBorderSelection excelLikeThickBorderSelection;
        ExcelLikeOutlineHeader excelLikeOutlineHeader;

		public SampleGrid()
			: this(null)
		{
		}
		
		public SampleGrid(GridModel model)
			: base(model)
		{
			this.FillSplitterPane = true;

			// transparent
			bool alphablending = false;
			if (alphablending)
			{
				this.SupportsTransparentBackColor = true;
				this.BackColor = Color.FromArgb(99, Color.White );
			}
			else
			{
				this.BackColor = Color.White;
				this.ForeColor = SystemColors.WindowText;
			}
			this.VerticalThumbTrack = false;
			this.VerticalScrollTips = true;
			this.HorizontalThumbTrack = true;
			this.HorizontalScrollTips = true;
			
			
			//Set properties to get the XP flat look
			this.ThemesEnabled = false;
			this.Properties.Buttons3D = false;
			this.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
           // this.GridVisualStyles = GridVisualStyles.Office2007Blue;
			GridStyleInfo style = new GridStyleInfo();
			GridBorder gb = new GridBorder(GridBorderStyle.Solid,SystemColors.ControlDark);
			style.Borders.Bottom = style.Borders.Right = gb;

			this.BaseStylesMap["Header"].StyleInfo.ModifyStyle(style,Syncfusion.Styles.StyleModifyType.Override);
			this.BaseStylesMap["Header"].StyleInfo.Font.Bold=false;
			this.BaseStylesMap["Header"].StyleInfo.Font.Facename="Verdana";
			this.BaseStylesMap["Header"].StyleInfo.Font.Size=10;

			this.Properties.MarkColHeader=true;
			this.Properties.MarkRowHeader=true;
			this.TableStyle.Font.Facename="Verdana";
			this.TableStyle.Font.Size=10;

            excelLikeThickBorderSelection = new ExcelLikeThickBorderSelection(this);
            excelLikeOutlineHeader = new ExcelLikeOutlineHeader(this);
            this.QueryCellInfo += new GridQueryCellInfoEventHandler(SampleGrid_QueryCellInfo);
		}

        void SampleGrid_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            GridBorder gb = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(158, 182, 206));
            if (e.Style.CellType == GridCellTypeName.Header)
            {
                if (e.RowIndex == 0)
                    e.Style.Interior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(249, 252, 253), Color.FromArgb(211, 220, 233));
                else if (e.ColIndex == 0)
                    e.Style.BackColor = Color.FromArgb(228, 236, 247);
                e.Style.Borders.Bottom = e.Style.Borders.Right = gb;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                excelLikeThickBorderSelection.Dispose();
                excelLikeOutlineHeader.Dispose();
            }

            base.Dispose(disposing);
        }

		public override void Initialize()
		{
			base.Initialize();
			this.TopRowIndex = InternalGetHeaderRows()+1;
			this.LeftColIndex = InternalGetHeaderCols()+1;
			this.AllowDrop = true;
			ExcelMarkerMouseController excelMarker;
			excelMarker = new ExcelMarkerMouseController(this);
			this.MouseControllerDispatcher.Add(excelMarker);
			
			FormulaRangeSelectionController formulaController=new FormulaRangeSelectionController(this);
			this.MouseControllerDispatcher.Add(formulaController);

			//Make sure there is a current cell
			this.CurrentCell.Activate(1,1,GridSetCurrentCellOptions.ScrollInView);
		}
    
		public static void SetupGridModel(GridModel model)
		{
			GridFactoryProvider.Init(new GridCellModelFactory());
			model.BeginInit();
			
			//setting properties.
			GridFormulaCellRenderer.ForceEditWhenActivated = false;
			model.RowCount = 100;
			model.ColCount = 100;
			model.Rows.DefaultSize = 19;
			model.Cols.DefaultSize = 65;
			model.RowHeights[0] = 21;
			model.ColWidths[0] = 35;
			model.Options.ControllerOptions = GridControllerOptions.All | GridControllerOptions.ExcelLikeSelection ;

			model.TableStyle.CellType="FormulaCell";

			model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
			model.CommandStack.Enabled=true;
			model.CellModels.Add("LinkLabel", new LinkLabelCellModel(model));
			model.EndInit();
			
		}

	}


    /// <summary>
    /// Implements an alternate approach for outlining cells with a thick border
    /// just like ExcelLikeSelectionFrame and ExcelLikeCurrentCell
    /// </summary>
    public class ExcelLikeThickBorderSelection : Disposable
    {
        GridControlBase m_grid;

        public ExcelLikeThickBorderSelection(GridControlBase grid)
        {
            m_grid = grid;

            // disable old settings - we want to replace that behavior with custom code from this class.
            m_grid.Model.Options.ExcelLikeCurrentCell = false;
            m_grid.Model.Options.ExcelLikeSelectionFrame = false;


            // custom drawing of borders, need to invalidate cells when selection changes
            this.m_grid.Model.SelectionChanged += new GridSelectionChangedEventHandler(gridSelectionChanged);
            this.m_grid.CellDrawn += new GridDrawCellEventHandler(gridCellDrawn);

            /// Optionally Change colors for selected cells 
            // this.m_grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(gridPrepareViewStyleInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.m_grid.Model.SelectionChanged -= new GridSelectionChangedEventHandler(gridSelectionChanged);
                this.m_grid.CellDrawn -= new GridDrawCellEventHandler(gridCellDrawn);
                this.m_grid.PrepareViewStyleInfo -= new GridPrepareViewStyleInfoEventHandler(gridPrepareViewStyleInfo);
            }

            base.Dispose(disposing);
        }

        /// <summary>
        /// Draw thick borders for cells that are at edge of selection.
        /// </summary>
        void gridCellDrawn(object sender, GridDrawCellEventArgs e)
        {
            GridControlBase grid = (GridControlBase)sender;
            GridRangeInfo rg = grid.Selections.Ranges.ActiveRange;

            if (rg.Contains(GridRangeInfo.Cell(e.RowIndex, e.ColIndex)))
            {
                Rectangle r = grid.RangeInfoToRectangle(GridRangeInfo.Cell(e.RowIndex, e.ColIndex));
                r.Height--;
                r.Width--;

                if (rg.Left == e.ColIndex)
                {
                    GridBorderPaint.DrawRectangle(e.Graphics, new GridBorder(GridBorderStyle.Solid, m_selectionBackColor, GridBorderWeight.ExtraExtraThick), r, Color.Beige, GridBorderSide.Left);
                }

                if (rg.Right == e.ColIndex)
                {
                    GridBorderPaint.DrawRectangle(e.Graphics, new GridBorder(GridBorderStyle.Solid, m_selectionBackColor, GridBorderWeight.ExtraExtraThick), r, Color.Beige, GridBorderSide.Right);
                }


                if (rg.Top == e.RowIndex)
                {
                    GridBorderPaint.DrawRectangle(e.Graphics, new GridBorder(GridBorderStyle.Solid, m_selectionBackColor, GridBorderWeight.ExtraExtraThick), r, Color.Beige, GridBorderSide.Top);
                }

                if (rg.Bottom == e.RowIndex)
                {
                    GridBorderPaint.DrawRectangle(e.Graphics, new GridBorder(GridBorderStyle.Solid, m_selectionBackColor, GridBorderWeight.ExtraExtraThick), r, Color.Beige, GridBorderSide.Bottom);
                }


                Rectangle rv = r;
                Rectangle rh = r;
                rh.Inflate(-2, 0);
                rv.Inflate(0, -2);

                if (rg.Top == e.RowIndex)
                {
                    rh.Y += 2;
                    rh.Height -= 2;
                }

                if (rg.Bottom == e.RowIndex)
                {
                    rh.Height -= 2;
                }


                if (rg.Left == e.ColIndex)
                {
                    rv.X += 2;
                    rv.Width -= 2;
                }

                if (rg.Right == e.ColIndex)
                {
                    rv.Width -= 2;
                }


                if (rg.Left == e.ColIndex)
                {
                    GridBorderPaint.DrawRectangle(e.Graphics, new GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Medium), rh, Color.Beige, GridBorderSide.Left);
                }

                if (rg.Right == e.ColIndex)
                {
                    GridBorderPaint.DrawRectangle(e.Graphics, new GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Medium), rh, Color.Beige, GridBorderSide.Right);
                }


                if (rg.Top == e.RowIndex)
                {
                    GridBorderPaint.DrawRectangle(e.Graphics, new GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Medium), rv, Color.Beige, GridBorderSide.Top);
                }

                if (rg.Bottom == e.RowIndex)
                {
                    GridBorderPaint.DrawRectangle(e.Graphics, new GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Medium), rv, Color.Beige, GridBorderSide.Bottom);
                }


                if (rg.Right == e.ColIndex && rg.Bottom == e.RowIndex)
                {
                    Rectangle rbr = r;
                    int d = 5;
                    rbr.X = rbr.Right - d;
                    rbr.Width = d;
                    rbr.Y = rbr.Bottom - d;
                    rbr.Height = d;

                    GridBorderPaint.DrawRectangle(e.Graphics, new GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Thick), rbr, Color.Beige, GridBorderSide.Top|GridBorderSide.Left);
                }

            }

        }

        /// <summary>
        /// Repaint selected cells.
        /// </summary>
        void gridSelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            this.m_grid.UpdateWithDrawClippedGrid(m_grid.RangeInfoToRectangle(e.Range));
        }

        Color m_selectionBackColor = SystemColors.Highlight;
        Color m_selectionTextColor = SystemColors.HighlightText;

        /// <summary>
        /// Optionally Change colors for selected cells 
        /// </summary>
        private void gridPrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
        {
            GridControlBase grid = (GridControlBase)sender;
            if (grid.Selections.Ranges.AnyRangeContains(GridRangeInfo.Cell(e.RowIndex, e.ColIndex))
                && !grid.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex))
            {
                e.Style.BackColor = m_selectionBackColor;
                e.Style.TextColor = m_selectionTextColor;
            }
        }
    }

    /// <summary>
    /// Highlight column and row headers for selected range
    /// </summary>
    public class ExcelLikeOutlineHeader : Disposable
    {
        GridControlBase m_grid;
        GridRangeInfo activeRange;

        public ExcelLikeOutlineHeader(GridControlBase grid)
        {
            m_grid = grid;

            this.m_grid.Model.SelectionChanged += new GridSelectionChangedEventHandler(gridSelectionChanged);
            this.m_grid.PrepareViewStyleInfo += new GridPrepareViewStyleInfoEventHandler(gridPrepareViewStyleInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.m_grid.Model.SelectionChanged -= new GridSelectionChangedEventHandler(gridSelectionChanged);
                this.m_grid.PrepareViewStyleInfo -= new GridPrepareViewStyleInfoEventHandler(gridPrepareViewStyleInfo);
            }

            base.Dispose(disposing);
        }

        GridRangeInfo GetColHeaderRange(GridRangeInfo range)
        {
            return GridRangeInfo.Cells(0, range.Left, 0, range.Right);
        }

        GridRangeInfo GetRowHeaderRange(GridRangeInfo range)
        {
            return GridRangeInfo.Cells(range.Top, 0, range.Bottom, 0);
        }


        /// <summary>
        /// Repaint selected cells.
        /// </summary>
        void gridSelectionChanged(object sender, GridSelectionChangedEventArgs e)
        {
            GridRangeInfo colRange = GridRangeInfo.Empty;
            GridRangeInfo rowRange = GridRangeInfo.Empty;

            if (activeRange != null && !activeRange.IsEmpty)
            {
                colRange = GetColHeaderRange(activeRange);
                rowRange = GetRowHeaderRange(activeRange);
            }

            activeRange = e.Range;

            if (activeRange != null && !activeRange.IsEmpty)
            {
                colRange = GridRangeInfo.UnionRange(colRange, GetColHeaderRange(activeRange));
                rowRange = GridRangeInfo.UnionRange(rowRange, GetRowHeaderRange(activeRange));
            }

            m_grid.UpdateWithDrawClippedGrid(m_grid.RangeInfoToRectangle(colRange));
            m_grid.UpdateWithDrawClippedGrid(m_grid.RangeInfoToRectangle(rowRange));
        }

        private void gridPrepareViewStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs e)
        {
            GridBorder gb = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(242, 149, 54));
            if (activeRange != null)
            {
                if (((e.RowIndex == 0 && (e.ColIndex >= activeRange.Left && e.ColIndex <= activeRange.Right))
                    || (e.ColIndex == 0 && (e.RowIndex >= activeRange.Top && e.RowIndex <= activeRange.Bottom)))
                    && !(e.ColIndex == 0 && e.RowIndex == 0))
                {
                    e.Style.Borders.Bottom = e.Style.Borders.Right = gb;
                    if (e.RowIndex == 0)
                        e.Style.Interior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(249, 217, 159), Color.FromArgb(242, 193, 96));
                    else if (e.ColIndex == 0)
                        e.Style.BackColor = Color.FromArgb(255, 213, 141);
                    e.Cancel = true;
                }
            }
        }
    }
}