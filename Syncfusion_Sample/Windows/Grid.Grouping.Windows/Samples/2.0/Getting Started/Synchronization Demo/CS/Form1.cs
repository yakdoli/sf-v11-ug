#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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
using System.IO;

using System.Data.OleDb;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

namespace FirstGridGroupCtl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private System.Windows.Forms.Panel panel1;
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		private System.Windows.Forms.Splitter splitter1;
		private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.gridGroupingControl1.TableControl.CurrentCellActivated += new EventHandler(TableControl_CurrentCellActivated);
			this.gridDataBoundGrid1.CurrentCellActivated += new EventHandler(gridDataBoundGrid1_CurrentCellActivated);
			this.gridGroupingControl1.ShowGroupDropArea = true;

            
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.ThemesEnabled = true;
            this.gridDataBoundGrid1.ThemesEnabled = true;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridDataBoundGrid1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
		}

		private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridGroupingControl1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.gridDataBoundGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 414);
            this.panel1.TabIndex = 0;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.Location = new System.Drawing.Point(326, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(376, 412);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.ThemesEnabled = false;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.splitter1.Location = new System.Drawing.Point(321, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 412);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(0, 0);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(321, 412);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 2;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.VerticalThumbTrack = true;
            this.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Metro;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(704, 414);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Synchronization Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//set the datasorce for the grids
			DataSet ds = GetACCDataSet();
			DataView dv = ds.Tables["ACCStats"].DefaultView;
			this.gridGroupingControl1.TableDescriptor.AllowNew = false;
			this.gridGroupingControl1.DataSource = dv;//ds.Tables["ACCStats"];
			
			this.gridDataBoundGrid1.DataSource = dv;
			this.gridDataBoundGrid1.UseListChangedEvent = true;

			


		}

		#region get the data from a CSV file

		private ArrayList GetUniqueValues(DataTable table, string colName)
		{
			ArrayList al = new ArrayList();
			al.Add("all");
			foreach(DataRow dr in table.Rows)
			{
				string s = dr[colName].ToString();
				int loc = al.BinarySearch(s);
				if(loc < 0)
				{
					al.Insert(-loc-1, s);
				}
			}
			return al;
		}
		private DataSet GetACCDataSet()
		{
			OleDbConnection conn = null;
			DataSet ds = null;
			try
			{
				string fileName = @"Common\Data\ACC.csv";

				for (int n = 0; n < 10; n++)
				{
					if (File.Exists(fileName))
					{
						break;
					}
					fileName = @"..\" + fileName;
				}

				string dir = Path.GetDirectoryName(fileName);

				string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dir + ";Extended Properties=Text;";
				conn = new OleDbConnection(connString);
				conn.Open();
				string select = "SELECT * FROM ACC.csv";
				OleDbDataAdapter adapt = new OleDbDataAdapter(select, conn);
				ds = new DataSet();
				adapt.Fill(ds, "ACCStats");
				conn.Close();
			}
			catch(Exception ex)
			{
				if(conn != null && conn.State == ConnectionState.Open)
				{
					conn.Close();
					MessageBox.Show(ex.ToString());
				}
				return null;
			}

			return ds;
		}
		#endregion

		private void TableControl_CurrentCellActivated(object sender, EventArgs e)
		{
			GridControlBase grid = sender as GridControlBase;
			if (grid != null)
				grid.CurrentCell.ScrollInView();
		}

		private void gridDataBoundGrid1_CurrentCellActivated(object sender, EventArgs e)
		{
			GridControlBase grid = sender as GridControlBase;
			if (grid != null)
				grid.CurrentCell.ScrollInView();
		}
	}
}
