
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;


using Syncfusion.XlsIO;
using Syncfusion.Windows.Forms;
using Syncfusion.GridExcelConverter;
using Syncfusion.Windows.Forms.Grid;


namespace ExcelLikeUI_2005
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class WorkBook : Office2007Form 
	{
        public Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl;
        public Syncfusion.Windows.Forms.Grid.GridAwareTextBox gridAwareTextBox1;
        public Syncfusion.Windows.Forms.Grid.GridAwareTextBox gridAwareTextBox2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem insertRowBarItem;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx tbscCMStrip;
        private Syncfusion.Windows.Forms.Tools.ContextMenuStripEx gridCMStrip;
        private ToolStripMenuItem insertSheetToolStripMenuItem;
        private ToolStripMenuItem deleteSheetToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem hyperlinkToolStripMenuItem;
        private ToolStripMenuItem showDialogToolStripMenuItem;
        private ToolStripMenuItem unhideItem;
		private System.ComponentModel.IContainer components = null;

		public WorkBook()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkBook));
            this.tabBarSplitterControl = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.gridAwareTextBox1 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.gridAwareTextBox2 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.parentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.insertRowBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tbscCMStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.insertSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridCMStrip = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hyperlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unhideItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabBarSplitterControl.SuspendLayout();
            this.tbscCMStrip.SuspendLayout();
            this.gridCMStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBarSplitterControl
            // 
            this.tabBarSplitterControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(232)))), ((int)(((byte)(249)))));
            this.tabBarSplitterControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBarSplitterControl.Controls.Add(this.gridAwareTextBox1);
            this.tabBarSplitterControl.Controls.Add(this.gridAwareTextBox2);
            this.tabBarSplitterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBarSplitterControl.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl.Location = new System.Drawing.Point(0, 0);
            this.tabBarSplitterControl.Name = "tabBarSplitterControl";
            this.tabBarSplitterControl.Style = TabBarSplitterStyle.Office2007;
            this.tabBarSplitterControl.Office2007ColorScheme = Office2007Theme.Blue;
            this.tabBarSplitterControl.Size = new System.Drawing.Size(776, 502);
            this.tabBarSplitterControl.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarSplitterControl.TabIndex = 0;
            this.tabBarSplitterControl.Text = "tabBarSplitterControl1";
            this.tabBarSplitterControl.ThemesEnabled = false;
			this.tabBarSplitterControl.Office2007ScrollBars = true;
            this.tabBarSplitterControl.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007;
            this.tabBarSplitterControl.PaneCreated += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.tabBarSplitterControl_PaneCreated);
            this.tabBarSplitterControl.ActivePageChanging += new System.Windows.Forms.ControlEventHandler(this.tabBarSplitterControl_ActivePageChanging);
            // 
            // gridAwareTextBox1
            // 
            this.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.Location = new System.Drawing.Point(-100, -100);
            this.gridAwareTextBox1.Name = "gridAwareTextBox1";
            this.gridAwareTextBox1.Size = new System.Drawing.Size(100, 20);
            this.gridAwareTextBox1.TabIndex = 1;
            // 
            // gridAwareTextBox2
            // 
            this.gridAwareTextBox2.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox2.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox2.Location = new System.Drawing.Point(-100, -100);
            this.gridAwareTextBox2.Name = "gridAwareTextBox2";
            this.gridAwareTextBox2.Size = new System.Drawing.Size(100, 20);
            this.gridAwareTextBox2.TabIndex = 2;
            // 
            // parentBarItem
            // 
            this.parentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.insertRowBarItem});
            // 
            // insertRowBarItem
            // 
            this.insertRowBarItem.ID = "insertRowBarItem";
            this.insertRowBarItem.Text = "Insert Row";
            // 
            // tbscCMStrip
            // 
            this.tbscCMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertSheetToolStripMenuItem,
            this.deleteSheetToolStripMenuItem,
            this.showDialogToolStripMenuItem,
            this.unhideItem});
            this.tbscCMStrip.Name = "tbscCMStrip";
            this.tbscCMStrip.Size = new System.Drawing.Size(153, 114);
            // 
            // insertSheetToolStripMenuItem
            // 
            this.insertSheetToolStripMenuItem.Name = "insertSheetToolStripMenuItem";
            this.insertSheetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertSheetToolStripMenuItem.Text = "Add Sheet";
            this.insertSheetToolStripMenuItem.Click += new System.EventHandler(this.insertSheetMenuItem_Click);
            // 
            // deleteSheetToolStripMenuItem
            // 
            this.deleteSheetToolStripMenuItem.Name = "deleteSheetToolStripMenuItem";
            this.deleteSheetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteSheetToolStripMenuItem.Text = "Delete Sheet";
            this.deleteSheetToolStripMenuItem.Click += new System.EventHandler(this.deleteSheetMenuItem_Click);
            // 
            // showDialogToolStripMenuItem
            // 
            this.showDialogToolStripMenuItem.Name = "showDialogToolStripMenuItem";
            this.showDialogToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showDialogToolStripMenuItem.Text = "Hide";
            this.showDialogToolStripMenuItem.Click += new System.EventHandler(this.hideItem_Click);
            // 
            // gridCMStrip
            // 
            this.gridCMStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.hyperlinkToolStripMenuItem});
            this.gridCMStrip.Name = "gridCMStrip";
            this.gridCMStrip.Size = new System.Drawing.Size(130, 120);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // hyperlinkToolStripMenuItem
            // 
            this.hyperlinkToolStripMenuItem.Name = "hyperlinkToolStripMenuItem";
            this.hyperlinkToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.hyperlinkToolStripMenuItem.Text = "Hyperlink";
            this.hyperlinkToolStripMenuItem.Click += new System.EventHandler(this.HyperLinkMenuItem_Click);
            // 
            // unhideItem
            // 
            this.unhideItem.Name = "unhideItem";
            this.unhideItem.Size = new System.Drawing.Size(152, 22);
            this.unhideItem.Text = "Unhide...";
            this.unhideItem.Click += new System.EventHandler(this.unhideItem_Click);
            // 
            // WorkBook
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(776, 502);
            this.Controls.Add(this.tabBarSplitterControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WorkBook";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.WorkBook_Deactivate);
            this.Activated += new System.EventHandler(this.WorkBook_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBarSplitterControl.ResumeLayout(false);
            this.tabBarSplitterControl.PerformLayout();
            this.tbscCMStrip.ResumeLayout(false);
            this.gridCMStrip.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		internal ArrayList HiddenSheets = new ArrayList();
	
		private void MyInit()
		{
			# region Initial Settings
			this.tabBarSplitterControl.SuspendLayout();
			this.SuspendLayout();

			for(int i = 0; i<3;i++)
			{
				TabBarPage tabBarPage = new TabBarPage();
                tabBarPage.TabBackColor = Color.FromArgb(219, 232, 249);
				GridControl _grid;
				GridModel model= new GridModel();
				SampleGrid.SetupGridModel(model);
				_grid=new SampleGrid(model);
				// 
				// _grid
				// 
                _grid.ContextMenuStrip = gridCMStrip;
				_grid.Location = new System.Drawing.Point(0, 0);
				_grid.Name = string.Format("gridControl{0}",i+1);
				_grid.SmartSizeBox = false;
				_grid.Text = string.Format("gridControl{0}",i+1);
				// 
				// tabBarPage
				// 
				tabBarPage.Controls.Add(_grid);
				tabBarPage.Location = new System.Drawing.Point(0, 0);
				tabBarPage.Name = string.Format("tabBarPage{0}",i+1);
				tabBarPage.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.Both;
				tabBarPage.Text = string.Format("Sheet{0}",i+1);
				tabBarPage.ThemesEnabled = true;
				this.tabBarSplitterControl.TabBarPages.Add(tabBarPage);
			}
			this.tabBarSplitterControl.ResumeLayout(true);
			this.ResumeLayout(true);
			#endregion
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.MyInit();

            this.tabBarSplitterControl.Bar.ContextMenuStrip = tbscCMStrip;
			this.tabBarSplitterControl.ActivePageChanged += new ControlEventHandler(tabBarSplitterControl_ActivePageChanged);
		}
	
		internal GridControl _grid = null;
		private void tabBarSplitterControl_ActivePageChanging(object sender, System.Windows.Forms.ControlEventArgs e)
		{	
			if(e.Control != null)
			    foreach(Control control in  e.Control.Controls)
			    {
				    if(control is GridControl)
				    {
					    this._grid = control as GridControl;
					    break;
				    }
			    }
			if(this._grid != null)
			{
				this.gridAwareTextBox1.WireGrid(this._grid);
				this.gridAwareTextBox2.WireGrid(this._grid);
				(this.MdiParent as Form1).gridAwareTextBoxItem1.WireGridAwareTextBox(this.gridAwareTextBox1,this._grid,true);
				(this.MdiParent as Form1).gridAwareTextBoxItem2.WireGridAwareTextBox(this.gridAwareTextBox2,this._grid,false);
				this._grid.VisibleChanged += new EventHandler(_grid_VisibleChanged);
			}
		}

		private void tabBarSplitterControl_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			this._grid = (GridControl) e.Control;
            _grid.ContextMenuStrip = gridCMStrip;
			this.gridAwareTextBox1.WireGrid(this._grid);
			this.gridAwareTextBox2.WireGrid(this._grid);
			(this.MdiParent as Form1).gridAwareTextBoxItem1.WireGridAwareTextBox(this.gridAwareTextBox1,this._grid,true);
			(this.MdiParent as Form1).gridAwareTextBoxItem2.WireGridAwareTextBox(this.gridAwareTextBox2,this._grid, false);
			this._grid.VisibleChanged += new EventHandler(_grid_VisibleChanged);
		}

		# region Menu Handlers
		private void insertSheetMenuItem_Click(object sender, System.EventArgs e)
		{
			TabBarPage tabBarPage = new TabBarPage();
            tabBarPage.TabBackColor = Color.FromArgb(219, 232, 249);
			GridControl _grid = new GridControl();
			int indx = this.tabBarSplitterControl.TabBarPages.IndexOf(this.tabBarSplitterControl.ActivePage);
			int oIndx = this.tabBarSplitterControl.TabBarPages.Count+1;

			GridModel model= new GridModel();
			SampleGrid.SetupGridModel(model);
			_grid=new SampleGrid(model);
			// 
			// _grid
			// 
            _grid.ContextMenuStrip = gridCMStrip;
			_grid.Location = new System.Drawing.Point(0, 0);
			_grid.Name = string.Format("gridControl{0}",oIndx);
			_grid.SmartSizeBox = false;
			_grid.Text = string.Format("gridControl{0}",oIndx);
			_grid.ThemesEnabled=false;

			// 
			// tabBarPage
			// 
			tabBarPage.Controls.Add(_grid);
			tabBarPage.Location = new System.Drawing.Point(0, 0);
			tabBarPage.Name = string.Format("tabBarPage{0}",oIndx);
			tabBarPage.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.Both;
			tabBarPage.Text = string.Format("Sheet{0}",oIndx);
			tabBarPage.ThemesEnabled = true;
			_grid.ThemesEnabled=false;
			GridFormulaEngine.RegisterGridAsSheet(string.Format("Sheet{0}",oIndx), _grid.Model, 1);

			this.tabBarSplitterControl.TabBarPages.Add(tabBarPage);
		}

		
		private void deleteSheetMenuItem_Click(object sender, System.EventArgs e)
		{
			if(this.tabBarSplitterControl.TabBarPages.Count>1)
			{
				TabBarPage page = this.tabBarSplitterControl.ActivePage;
				this.tabBarSplitterControl.ActivateNextPage(true);
				this.tabBarSplitterControl.TabBarPages.Remove(page);
			}
		}
	
		private void HyperLinkMenuItem_Click(object sender, System.EventArgs e)
		{
			GridCurrentCell cc =  this._grid.CurrentCell;
			GridStyleInfo style = this._grid.Model[cc.RowIndex,cc.ColIndex];
			if(style.CellType=="LinkLabel")
				style.CellType="FormulaCell";
			else
			{
				style.CellType= "LinkLabel";
				style.Tag = style.Text;
			}
		}
		private void cutMenuItem_Click(object sender, System.EventArgs e)
		{
			this._grid.Model.CutPaste.Cut();
		}

		private void copyMenuItem_Click(object sender, System.EventArgs e)
		{
			this._grid.Model.CutPaste.Copy();
		}

		private void pasteMenuItem_Click(object sender, System.EventArgs e)
		{
			this._grid.Model.CutPaste.Paste();
		}
		private void deleteMenuItem_Click_1(object sender, System.EventArgs e)
		{
			this._grid.Model.Clear(true);
		}
		# endregion

		private void WorkBook_Activated(object sender, System.EventArgs e)
		{
			(this.MdiParent as Form1).workBook = this;
			
			(this.MdiParent as Form1).gridAwareTextBoxItem1.WireGridAwareTextBox(this.gridAwareTextBox1,this._grid,true);
			(this.MdiParent as Form1).gridAwareTextBoxItem2.WireGridAwareTextBox(this.gridAwareTextBox2,this._grid,false);
			this.RegisterGrid();

		}

		private void WorkBook_Deactivate(object sender, System.EventArgs e)
		{
			(this.MdiParent as Form1).workBook = null;
			
		}


		//Register grids
		internal void RegisterGrid()
		{
			foreach(TabBarPage page in this.tabBarSplitterControl.TabBarPages)
			{
				GridControl grid=null;
				foreach(Control control in page.Controls)
					if(control is GridControl)
					{
						grid = control as GridControl;
						break;
					}
				if (grid != null)
				{
					GridFormulaEngine.RegisterGridAsSheet(page.Text, grid.Model, 1);
					grid.Model.Refresh();
				}
			}
			foreach(TabBarPage page in this.HiddenSheets)
			{
                GridControl grid = null;
				foreach(Control control in page.Controls)
				if(control is GridControl)
				{
					grid = control as GridControl;
					break;
				}
				if (grid != null)
				{
					GridFormulaEngine.RegisterGridAsSheet(page.Text, grid.Model, 1);
					grid.Model.Refresh();
				}
			}
		}


		internal void InvalidateFormulaCell()
		{
			GridRangeInfo range = new GridRangeInfo();
			range = this._grid.RectangleToRangeInfo(this._grid.Bounds);
			for(int r = range.Top; r < range.Bottom; r++)
				for(int c = range.Left;c<range.Right;c++)
					if(this._grid[r,c].HasFormulaTag)
						this._grid[r,c].FormulaTag = null;
		}

		internal void HideSheet()
		{
			if(this.tabBarSplitterControl.TabBarPages.Count > 1)
			{
				TabBarPage page =this.tabBarSplitterControl.ActivePage;
				this.HiddenSheets.Add(page);
				this.tabBarSplitterControl.ActivateNext(true);
                this.tabBarSplitterControl.TabBarPages.Remove(page);
			}
			else
				MessageBox.Show("A WorkBook must contain atleast one visible sheet!","WorkBook",MessageBoxButtons.OK,MessageBoxIcon.Stop);
		}
		
		internal void UnhideSheet()
		{
			Unhide unhideFrm  = new Unhide();

			foreach(TabBarPage page in this.HiddenSheets)
				unhideFrm.sheetListBox.Items.Add(page.Text);

			unhideFrm.Owner = this;
			if(unhideFrm.ShowDialog() == DialogResult.OK)
			{
				foreach(TabBarPage page in this.HiddenSheets)
					if(page.Text == (string)unhideFrm.sheetListBox.SelectedItem)
					{
						this.tabBarSplitterControl.TabBarPages.Add(page);
						this.HiddenSheets.Remove(page);
						break;
					}
			}
		}

		private void _grid_VisibleChanged(object sender, EventArgs e)
		{
			this.InvalidateFormulaCell();
		}

		private void tabBarSplitterControl_ActivePageChanged(object sender, ControlEventArgs e)
		{
			//Change the Formula Bar Text to reflect the current selection in the active page
			TabBarPage page = this.tabBarSplitterControl.ActivePage;
            if (page != null)
            {
                GridControl grid = null;

                if (page.Controls[1] is GridControl)
                    grid = page.Controls[1] as GridControl;
                GridCurrentCell cc = grid.CurrentCell;
                this.gridAwareTextBox2.Text = grid[cc.RowIndex, cc.ColIndex].Text;
            }
		}

        private void hideItem_Click(object sender, EventArgs e)
        {
            HideSheet();
        }

        private void unhideItem_Click(object sender, EventArgs e)
        {
            UnhideSheet();
        }
	}
}