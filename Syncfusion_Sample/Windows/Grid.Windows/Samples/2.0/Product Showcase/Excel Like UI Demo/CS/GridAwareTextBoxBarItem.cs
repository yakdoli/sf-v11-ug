using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Design;
using Syncfusion.Collections;
using Syncfusion.ComponentModel;
using System.Drawing.Design;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Reflection;
using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms.Grid;


namespace ExcelLikeUI_2005
{
	/// <summary>
	/// Summary description for GridAwareTextBoxBarItem.
	/// </summary>
	public class GridAwareTextBoxBarItem : TextBoxBarItem
	{
		private GridAwareTextBox gridAwareTextBox = null;
		private GridControlBase _grid = null;
		private bool rangeofgrid=false;
		private bool ignoreSync = false;

		public GridAwareTextBoxBarItem():base()
		{		
			
		}

		public void WireGridAwareTextBox(GridAwareTextBox gridAwareTextBox, GridControlBase grid, bool range)
		{
			this._grid = grid;
			this.gridAwareTextBox = gridAwareTextBox;
			this.rangeofgrid=range;

			//Assign the current selection range to NameBox
			if(rangeofgrid)
                this.TextBoxValue = string.Format("R{0}C{0}",grid.CurrentCell.RowIndex,grid.CurrentCell.ColIndex);

			this._grid.Model.SelectionChanged +=new GridSelectionChangedEventHandler(Model_SelectionChanged);
            this._grid.CurrentCellMoved += new GridCurrentCellMovedEventHandler(_grid_CurrentCellMoved);
			this.gridAwareTextBox.TextChanged += new EventHandler(gridAwareTextBox_TextChanged);
		}

        void _grid_CurrentCellMoved(object sender, GridCurrentCellMovedEventArgs e)
        {
            if (rangeofgrid)
                this.TextBoxValue = string.Format("R{0}C{0}", _grid.CurrentCell.RowIndex, _grid.CurrentCell.ColIndex);
        }

		public void UnwireGrid(GridControlBase grid)
		{
			this.gridAwareTextBox.UnwireGrid(grid);
		}

		
		public override string TextBoxValue
		{
			get
			{
				return base.TextBoxValue;
			}
			set
			{
				
				if(rangeofgrid || ignoreSync)
					base.TextBoxValue = value;
				else
				{
					if(this._grid != null)
					{
						//Set textbox value to current cell value
						GridCurrentCell cc= GetCurrentCell();
						cc.MoveTo(cc.RowIndex,cc.ColIndex,GridSetCurrentCellOptions.ScrollInView);
						this.gridAwareTextBox.Text = value;
						base.TextBoxValue = value;
					}
				}
			}
		}

		private void gridAwareTextBox_TextChanged(object sender, EventArgs e)
		{
			if(!rangeofgrid)
			{
				ignoreSync = true;
				this.TextBoxValue = this.gridAwareTextBox.Text;
				ignoreSync = false;
			}
		}

		private void Model_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
		{
			//Change the NameBox value to reflect the current selection range
			if(rangeofgrid)
				this.TextBoxValue= e.Range.ToString();
		}

		GridCurrentCell GetCurrentCell()
		{
			GridCurrentCell cc = null;
			if (this._grid.Parent is SplitterControl)
			{
				Control c = ((SplitterControl) this._grid.Parent).ActivePane;
				if (c is GridControlBase)
					cc = ((GridControlBase) c).CurrentCell;
			}
			if (cc == null)
			{
				if (this._grid.Model.ActiveGridView != null)
					cc = this._grid.Model.ActiveGridView.CurrentCell;
				if (cc == null)
					cc = this._grid.CurrentCell;
			}
			return cc;
		}

	}
}
