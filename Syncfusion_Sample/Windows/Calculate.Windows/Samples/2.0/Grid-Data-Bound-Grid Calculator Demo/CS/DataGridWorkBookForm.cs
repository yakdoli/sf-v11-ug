#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Calculate;
using Syncfusion.Windows.Forms.Grid;

namespace GridDataBoundGridCalculator
{
	/// <summary>
	/// Summary description for GridDataBoundGridWorkBook.
	/// </summary>
	public class GridDataBoundGridWorkBookForm : System.Windows.Forms.Form
	{
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid1;
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid2;
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid3;
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid4;
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl1;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage1;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage2;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage3;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage4;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage5;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridDataBoundGridWorkBookForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();

			System.Drawing.Icon ico = new System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"));
			this.Icon = ico ;


			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{            
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBarSplitterControl1 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.tabBarPage1 = new Syncfusion.Windows.Forms.TabBarPage();
            this.tabBarPage2 = new Syncfusion.Windows.Forms.TabBarPage();
            this.tabBarPage3 = new Syncfusion.Windows.Forms.TabBarPage();
            this.tabBarPage4 = new Syncfusion.Windows.Forms.TabBarPage();
            this.tabBarPage5 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridDataBoundGrid1 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.gridDataBoundGrid2 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.gridDataBoundGrid3 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.gridDataBoundGrid4 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.gridDataBoundGrid5 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid5)).BeginInit();
            this.tabBarSplitterControl1.SuspendLayout();
            this.tabBarPage1.SuspendLayout();
            this.tabBarPage2.SuspendLayout();
            this.tabBarPage3.SuspendLayout();
            this.tabBarPage4.SuspendLayout();
            this.tabBarPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.DataMember = "";
            this.gridDataBoundGrid1.FillSplitterPane = true;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(573, 341);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // gridDataBoundGrid2
            // 
            this.gridDataBoundGrid2.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid2.AllowDragSelectedCols = true;
            this.gridDataBoundGrid2.DataMember = "";
            this.gridDataBoundGrid2.FillSplitterPane = true;
            this.gridDataBoundGrid2.Location = new System.Drawing.Point(136, 112);
            this.gridDataBoundGrid2.Name = "gridDataBoundGrid2";
            this.gridDataBoundGrid2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid2.Size = new System.Drawing.Size(130, 80);
            this.gridDataBoundGrid2.SmartSizeBox = false;
            this.gridDataBoundGrid2.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // gridDataBoundGrid3
            // 
            this.gridDataBoundGrid3.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid3.AllowDragSelectedCols = true;
            this.gridDataBoundGrid3.DataMember = "";
            this.gridDataBoundGrid3.FillSplitterPane = true;
            this.gridDataBoundGrid3.Location = new System.Drawing.Point(136, 136);
            this.gridDataBoundGrid3.Name = "gridDataBoundGrid3";
            this.gridDataBoundGrid3.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid3.Size = new System.Drawing.Size(130, 80);
            this.gridDataBoundGrid3.SmartSizeBox = false;
            this.gridDataBoundGrid3.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // gridDataBoundGrid4
            // 
            this.gridDataBoundGrid4.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid4.AllowDragSelectedCols = true;
            this.gridDataBoundGrid4.DataMember = "";
            this.gridDataBoundGrid4.FillSplitterPane = true;
            this.gridDataBoundGrid4.Location = new System.Drawing.Point(112, 112);
            this.gridDataBoundGrid4.Name = "gridDataBoundGrid4";
            this.gridDataBoundGrid4.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid4.Size = new System.Drawing.Size(130, 80);
            this.gridDataBoundGrid4.SmartSizeBox = false;
            this.gridDataBoundGrid4.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // gridDataBoundGrid5
            // 
            this.gridDataBoundGrid5.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid5.AllowDragSelectedCols = true;
            this.gridDataBoundGrid5.DataMember = "";
            this.gridDataBoundGrid5.FillSplitterPane = true;
            this.gridDataBoundGrid5.Location = new System.Drawing.Point(144, 96);
            this.gridDataBoundGrid5.Name = "gridDataBoundGrid5";
            this.gridDataBoundGrid5.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid5.Size = new System.Drawing.Size(130, 80);
            this.gridDataBoundGrid5.SmartSizeBox = false;
            this.gridDataBoundGrid5.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(34, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Formulas";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(320, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter a formula like   = Sum(GDBG2!B2:GDBG2!B5)   into a cell.";
            // 
            // tabBarSplitterControl1
            // 
            this.tabBarSplitterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage1);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage2);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage3);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage4);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage5);
            this.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl1.Location = new System.Drawing.Point(32, 64);
            this.tabBarSplitterControl1.Name = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.Office2007ScrollBars = true;
            this.tabBarSplitterControl1.Size = new System.Drawing.Size(592, 360);
            this.tabBarSplitterControl1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None;
            this.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007;
            this.tabBarSplitterControl1.TabFolderDelta = 11;
            this.tabBarSplitterControl1.TabIndex = 5;
            this.tabBarSplitterControl1.Text = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.ThemesEnabled = false;
            // 
            // tabBarPage1
            // 
            this.tabBarPage1.Controls.Add(this.gridDataBoundGrid1);
            this.tabBarPage1.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage1.Name = "tabBarPage1";
            this.tabBarPage1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None;
            this.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage1.Text = "GDBG1";
            this.tabBarPage1.ThemesEnabled = false;
            // 
            // tabBarPage2
            // 
            this.tabBarPage2.Controls.Add(this.gridDataBoundGrid2);
            this.tabBarPage2.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage2.Name = "tabBarPage2";
            this.tabBarPage2.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage2.Text = "GDBG2";
            this.tabBarPage2.ThemesEnabled = false;
            // 
            // tabBarPage3
            // 
            this.tabBarPage3.Controls.Add(this.gridDataBoundGrid3);
            this.tabBarPage3.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage3.Name = "tabBarPage3";
            this.tabBarPage3.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage3.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage3.Text = "GDBG3";
            this.tabBarPage3.ThemesEnabled = false;
            // 
            // tabBarPage4
            // 
            this.tabBarPage4.Controls.Add(this.gridDataBoundGrid4);
            this.tabBarPage4.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage4.Name = "tabBarPage4";
            this.tabBarPage4.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage4.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage4.Text = "GDBG4";
            this.tabBarPage4.ThemesEnabled = false;
            // 
            // tabBarPage5
            // 
            this.tabBarPage5.Controls.Add(this.gridDataBoundGrid5);
            this.tabBarPage5.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage5.Name = "tabBarPage5";
            this.tabBarPage5.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage5.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage5.Text = "GDBG5";
            this.tabBarPage5.ThemesEnabled = false;
            // 
            // GridDataBoundGridWorkBookForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(656, 454);
            this.Controls.Add(this.tabBarSplitterControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Name = "GridDataBoundGridWorkBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grid-Data-Bound-Grid Calculator Demo";
            this.Load += new System.EventHandler(this.gridDataBoundGridWorkBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid5)).EndInit();
            this.tabBarSplitterControl1.ResumeLayout(false);
            this.tabBarPage1.ResumeLayout(false);
            this.tabBarPage2.ResumeLayout(false);
            this.tabBarPage3.ResumeLayout(false);
            this.tabBarPage4.ResumeLayout(false);
            this.tabBarPage5.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


		Syncfusion.Calculate.CalcEngine engine;

		private void gridDataBoundGridWorkBookForm_Load(object sender, System.EventArgs e)
		{
			this.gridDataBoundGrid1.DataSource = GetARandomTable();
			this.gridDataBoundGrid2.DataSource = GetARandomTable();
			this.gridDataBoundGrid3.DataSource = GetARandomTable();
			this.gridDataBoundGrid4.DataSource = GetARandomTable();
			this.gridDataBoundGrid5.DataSource = GetARandomTable();


            this.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid1.Font = new System.Drawing.Font("Verdana", 8.5F);

            this.gridDataBoundGrid2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid2.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid2.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid2.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid2.Font = new System.Drawing.Font("Verdana", 8.5F);

            this.gridDataBoundGrid3.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid3.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid3.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid3.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid3.Font = new System.Drawing.Font("Verdana", 8.5F);

            this.gridDataBoundGrid4.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid4.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid4.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid4.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid4.Font = new System.Drawing.Font("Verdana", 8.5F);

            this.gridDataBoundGrid5.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid5.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid5.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid5.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid5.Font = new System.Drawing.Font("Verdana", 8.5F);

			if(engine == null)
			{
				//Create the engine:
				engine = new Syncfusion.Calculate.CalcEngine(this.gridDataBoundGrid1);
				//Track dependencies required for auto calculations:
				engine.UseDependencies = true;
			
				//Register multiple ICalcData objects for cross sheet references:
				int sheetfamilyID = Syncfusion.Calculate.CalcEngine.CreateSheetFamilyID();
				engine.RegisterGridAsSheet("GDBG1", this.gridDataBoundGrid1, sheetfamilyID);
				engine.RegisterGridAsSheet("GDBG2", this.gridDataBoundGrid2, sheetfamilyID);
				engine.RegisterGridAsSheet("GDBG3", this.gridDataBoundGrid3, sheetfamilyID);
				engine.RegisterGridAsSheet("GDBG4", this.gridDataBoundGrid4, sheetfamilyID);
				engine.RegisterGridAsSheet("GDBG5", this.gridDataBoundGrid5, sheetfamilyID);
			}
		}

		#region Create DataTables

		Random r = new Random();
		int tableCount = 0;
		private DataTable GetARandomTable()
		{
			DataTable dt = new DataTable(string.Format("Table{0}", tableCount));

			int nRows = r.Next(100) + 5;
			int nCols = r.Next(20) + 5;

			for(int i = 0; i < nCols; ++i)
				dt.Columns.Add(new DataColumn(RangeInfo.GetAlphaLabel(i+1)));

			tableCount++;

			for(int i = 0; i < nRows; ++i)
			{
				DataRow dr = dt.NewRow();
				for(int j = 0; j < nCols; ++j)
				{
					if(j == 0)
						dr[j] = i + 1;
					else
						dr[j] = r.Next(1000);
				}
				dt.Rows.Add(dr);
			}
			dt.DefaultView.AllowNew = false;
			return dt;
		}

		#endregion

		#region debug output to display cell dependencies


		#endregion

		#region  CheckBox handler code

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid1);
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid2);
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid3);
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid4);
			ShowFormulas(this.checkBox1.Checked, this.gridDataBoundGrid5);
			this.Cursor = Cursors.Default;
		}

		private void ShowFormulas(bool show, CalcGridDataBoundGrid grid)
		{
			DataTable dt = grid.DataSource as DataTable;

			engine.IgnoreValueChanged = true;
				
			if(show)
			{
				for(int row = 0; row < dt.Rows.Count; ++row)
				{
					for(int col = 0; col < dt.Columns.Count; ++col)
					{
						//All calls into CalcEngine are 1-based:
						string s = this.engine.GetFormulaRowCol(grid, row+1, col+1);
						if(s.Length > 0)
						{
							//No calculation as ValueChanged is not raised.
							grid[row + 1, col + 1].Text = s;
						}
					}
				}
			}
			else
			{
				for(int row = 0; row < dt.Rows.Count; ++row)
				{
					for(int col = 0; col < dt.Columns.Count; ++col)
					{
						//All calls into CalcEngine are 1-based:
						string s = this.engine.GetFormulaRowCol(grid, row+1, col+1);
						if(s.Length > 0)
						{
							//Get the value:
							Syncfusion.Calculate.GridSheetFamilyItem family = Syncfusion.Calculate.CalcEngine.GetSheetFamilyItem(grid);
							string cell = (family.ParentObjectToToken == null) ? "" : family.ParentObjectToToken[grid].ToString();
			
							cell += RangeInfo.GetAlphaLabel(col+1) + (row+1).ToString(); 
							s = this.engine.GetValueFromParentObject(cell);
							grid[row + 1, col + 1].Text = s;
							
						}
					}
					this.gridDataBoundGrid1.Binder.EndEdit();
				}
			}
			engine.IgnoreValueChanged = false;
		
		}
		#endregion
	}
}
