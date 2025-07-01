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
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;

namespace MasterDetailForm
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl parentTableGrid;
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl parentToChildGrid;
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl hierarchyGrid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl childToGrandChildGrid;
		private System.Windows.Forms.Label label4;
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

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			try
			{
				Icon ico = new Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
				this.Icon = ico ;	
			}
			catch
			{}
            
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
            this.parentTableGrid = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.parentToChildGrid = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.hierarchyGrid = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.childToGrandChildGrid = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parentTableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentToChildGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hierarchyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childToGrandChildGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // parentTableGrid
            // 
            this.parentTableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.parentTableGrid.BackColor = System.Drawing.SystemColors.Window;
            this.parentTableGrid.Location = new System.Drawing.Point(16, 32);
            this.parentTableGrid.Name = "parentTableGrid";
            this.parentTableGrid.Size = new System.Drawing.Size(320, 128);
            this.parentTableGrid.TabIndex = 0;
            this.parentTableGrid.Text = "parentTableGrid";
            // 
            // parentToChildGrid
            // 
            this.parentToChildGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parentToChildGrid.BackColor = System.Drawing.SystemColors.Window;
            this.parentToChildGrid.Location = new System.Drawing.Point(16, 200);
            this.parentToChildGrid.Name = "parentToChildGrid";
            this.parentToChildGrid.Size = new System.Drawing.Size(320, 128);
            this.parentToChildGrid.TabIndex = 1;
            this.parentToChildGrid.Text = "parentToChildGrid";
            // 
            // hierarchyGrid
            // 
            this.hierarchyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hierarchyGrid.BackColor = System.Drawing.SystemColors.Window;
            this.hierarchyGrid.Location = new System.Drawing.Point(368, 32);
            this.hierarchyGrid.Name = "hierarchyGrid";
            this.hierarchyGrid.Size = new System.Drawing.Size(304, 464);
            this.hierarchyGrid.TabIndex = 2;
            this.hierarchyGrid.Text = "hierarchyGrid";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Parent";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Child";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "GrandChild";
            // 
            // childToGrandChildGrid
            // 
            this.childToGrandChildGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.childToGrandChildGrid.BackColor = System.Drawing.SystemColors.Window;
            this.childToGrandChildGrid.Location = new System.Drawing.Point(16, 368);
            this.childToGrandChildGrid.Name = "childToGrandChildGrid";
            this.childToGrandChildGrid.Size = new System.Drawing.Size(320, 128);
            this.childToGrandChildGrid.TabIndex = 6;
            this.childToGrandChildGrid.Text = "childToGrandChildGrid";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "HierarchyGrid";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(696, 518);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.childToGrandChildGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hierarchyGrid);
            this.Controls.Add(this.parentToChildGrid);
            this.Controls.Add(this.parentTableGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(704, 552);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Detail Form Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentTableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentToChildGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hierarchyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childToGrandChildGrid)).EndInit();
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
			DataSet dSet = new DataSet();

			//get the tables
			DataTable parentTable = GetParentTable();
			DataTable childTable = GetChildTable();
			DataTable grandChildTable = GetGrandChildTable();
			dSet.Tables.AddRange(new DataTable[]{parentTable, childTable, grandChildTable});

			//setup the relations
			DataColumn parentColumn = parentTable.Columns["parentID"];
			DataColumn childColumn = childTable.Columns["ParentID"];
			dSet.Relations.Add("ParentToChild", parentColumn, childColumn);

			parentColumn = childTable.Columns["childID"];
			childColumn = grandChildTable.Columns["ChildID"];
			dSet.Relations.Add("ChildToGrandChild", parentColumn, childColumn);

			//set the master-detail-detail grids
			this.parentTableGrid.DataSource = parentTable; //master
			this.parentTableGrid.TableDescriptor.Relations.Clear(); // don't autopopulate relations

			this.parentToChildGrid.DataSource = parentTable; //detail1
			this.parentToChildGrid.DataMember = "ParentToChild"; //detail1
			this.parentToChildGrid.TableDescriptor.Relations.Clear(); // don't autopopulate relations

			this.childToGrandChildGrid.DataSource = parentTable; //detail2
			this.childToGrandChildGrid.DataMember = "ParentToChild.ChildToGrandChild"; //detail2
			this.childToGrandChildGrid.TableDescriptor.Relations.Clear(); // don't autopopulate relations

			// hierarchyGrid grid with hierarchical view
			this.hierarchyGrid.DataSource = parentTable;
			this.hierarchyGrid.Engine.BindToCurrencyManager = false; // don't attach this one to CurrencyManager.

            this.parentTableGrid.GridVisualStyles = GridVisualStyles.Metro;
            this.parentTableGrid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.parentTableGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.parentTableGrid.TopLevelGroupOptions.ShowCaption = false;


            this.parentToChildGrid.GridVisualStyles = GridVisualStyles.Metro;
            this.parentToChildGrid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.parentToChildGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.parentToChildGrid.TopLevelGroupOptions.ShowCaption = false;

            this.childToGrandChildGrid.GridVisualStyles = GridVisualStyles.Metro;
            this.childToGrandChildGrid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.childToGrandChildGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.childToGrandChildGrid.TopLevelGroupOptions.ShowCaption = false;

            this.hierarchyGrid.GridVisualStyles = GridVisualStyles.Metro;
            this.hierarchyGrid.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.hierarchyGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.hierarchyGrid.TopLevelGroupOptions.ShowCaption = false;
           

            
		}
		private int parentRows = 10;
		private int ChildRows = 30;
		private int GrandChildRows = 80;

		private DataTable GetParentTable()
		{
			DataTable dt = new DataTable("ParentTable");

			dt.Columns.Add(new DataColumn("parentID")); //lower case p
			dt.Columns.Add(new DataColumn("ParentName"));

			for(int i = 0; i < parentRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("parentName{0}", i);
				dt.Rows.Add(dr);
			}

			return dt;
		}

		private Random r = new Random();

		private DataTable GetChildTable()
		{
			DataTable dt = new DataTable("ChildTable");

			dt.Columns.Add(new DataColumn("childID")); //lower case c
			dt.Columns.Add(new DataColumn("Name"));
			dt.Columns.Add(new DataColumn("ParentID")); //upper case P
			
			for(int i = 0; i < ChildRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("ChildName{0}",i);
				dr[2] = r.Next(parentRows).ToString();//(i % parentRows).ToString();
				dt.Rows.Add(dr);
			}
		
			return dt;
		}

		private DataTable GetGrandChildTable()
		{
			DataTable dt = new DataTable("GrandChildTable");

			dt.Columns.Add(new DataColumn("GrandChildID"));
			dt.Columns.Add(new DataColumn("Name"));
			dt.Columns.Add(new DataColumn("ChildID")); //upper case C
			
			for(int i = 0; i < GrandChildRows; ++i)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("GrandChildName{0}",i);
				dr[2] = r.Next(ChildRows).ToString();//(i % ChildRows).ToString();
				dt.Rows.Add(dr);
			}
			
			return dt;
		}
		
	}
}
