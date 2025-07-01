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

using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Collections;

namespace ManualRelations
{
	/// <summary>
	/// This sample demonstrates how to manually specify master-details relations 
	/// between three separate tables that primary keys and foreign key columns
	/// in common. 
	/// </summary>
	public class Form1 : Syncfusion.Windows.Forms.MetroForm
	{
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridGroupingControl1.Location = new System.Drawing.Point(16, 16);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(673, 410);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(708, 444);
            this.Controls.Add(this.gridGroupingControl1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frozen Column Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			DataTable parentTable = GetParentTable();
			DataTable childTable = GetChildTable();
			DataTable grandChildTable = GetGrandChildTable();

			// Manually specify relations in grouping engine. The DataSet does not need to have any DataRelations.
			// This is the same approach that should be used if you want to set up relation ships
			// between independent IList.
			GridRelationDescriptor parentToChildRelationDescriptor = new GridRelationDescriptor();
			parentToChildRelationDescriptor.ChildTableName = "MyChildTable";    // same as SourceListSetEntry.Name for childTable (see below)
			parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails;
			parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID");

			// Add relation to ParentTable 
			gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor);

			GridRelationDescriptor childToGrandChildRelationDescriptor = new GridRelationDescriptor();
			childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable";  // same as SourceListSetEntry.Name for grandChhildTable (see below)
			childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails;
			childToGrandChildRelationDescriptor.RelationKeys.Add("childID", "ChildID");

			// Add relation to ChildTable 
			parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor);

			// Register any DataTable/IList with SourceListSet, so that RelationDescriptor can resolve the name
			this.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable);
			this.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable);
			this.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable);

			this.gridGroupingControl1.DataSource = parentTable;

            // When freezing columns you have to make sure that the frozen columns 
            // in the nested tables are properly aligned with the parent table. The grid
            // does not support diffent scroll divider x-coordinates for nested tables.
            //
            // The only exception to this rule is if you turn off freezing columns
            // for all nested tables by setting/leaving ChildTableDescriptor.FrozenColumn = ""; (empty string)
            // all together.
            //
            // The TrackWidthOfParentColumn propetry of a column descriptor ensures that 
            // columns are aligned and stay in sync. 

            gridGroupingControl1.TableDescriptor.Columns[0].Width = 200;
            gridGroupingControl1.TableDescriptor.Columns[1].Width = 100;

            int freezeCol = 1;  // freeze column 0 and 1.

            // specify last column to be frozen.
            gridGroupingControl1.TableDescriptor.FrozenColumn = gridGroupingControl1.TableDescriptor.Columns[freezeCol].Name;

            //// synchronize width of columns in child record with width of column in parent record.
            for (int n = 0; n <= freezeCol; n++)
                parentToChildRelationDescriptor.ChildTableDescriptor.Columns[n].TrackWidthOfParentColumn = gridGroupingControl1.TableDescriptor.Columns[n].Name;

            // specify last column to be frozen in child table.
            parentToChildRelationDescriptor.ChildTableDescriptor.FrozenColumn = parentToChildRelationDescriptor.ChildTableDescriptor.Columns[freezeCol].Name;

            // same for grandchild table.
            for (int n = 0; n <= freezeCol; n++)
                childToGrandChildRelationDescriptor.ChildTableDescriptor.Columns[n].TrackWidthOfParentColumn = parentToChildRelationDescriptor.ChildTableDescriptor.Columns[n].Name;
            childToGrandChildRelationDescriptor.ChildTableDescriptor.FrozenColumn = childToGrandChildRelationDescriptor.ChildTableDescriptor.Columns[freezeCol].Name;
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;			
            this.gridGroupingControl1.Table.ExpandAllRecords();
            // Modeless PropertyGrid Form
            //new GridGroupingControlSchemaBrowser(this.gridGroupingControl1).Show();
        }


#if notused
        /// <summary>
        /// Save old width value when column width is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridGroupingControl1_PropertyChanging(object sender, DescriptorPropertyChangedEventArgs e)
        {
            GridGroupingControl gcc = (GridGroupingControl)sender;
            if (e.PropertyName == "TableDescriptor")
            {
                TableDescriptor tableDescriptor = gcc.TableDescriptor;
                e = (DescriptorPropertyChangedEventArgs)e.Inner;

                if (e.PropertyName == "Relations")
                    e = e.GetNestedChildTableDescriptorEvent(ref tableDescriptor);

                switch (e.PropertyName)
                {
                    case "Columns":
                        {
                            if (e.Inner is ListPropertyChangedEventArgs)
                            {
                                ListPropertyChangedEventArgs le = (ListPropertyChangedEventArgs)e.Inner;
                                if (le.Property == "Width")
                                {
                                    GridColumnDescriptor cd = (GridColumnDescriptor)le.Item;
                                    oldWidth = cd.Width;
                                }
                            }
                            break;
                        }
                }
            }
        }

        int oldWidth = -1;

        /// <summary>
        /// Apply delta of width value to all nested tables to make sure the frozen column
        /// remains aligned.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void gridGroupingControl1_PropertyChanged(object sender, DescriptorPropertyChangedEventArgs e)
        {
            GridGroupingControl gcc = (GridGroupingControl)sender;
            if (e.PropertyName == "TableDescriptor")
            {
                TableDescriptor tableDescriptor = gcc.TableDescriptor;
                e = (DescriptorPropertyChangedEventArgs)e.Inner;

                if (e.PropertyName == "Relations")
                    e = e.GetNestedChildTableDescriptorEvent(ref tableDescriptor);

                switch (e.PropertyName)
                {
                    case "Columns":
                        {
                            if (e.Inner is ListPropertyChangedEventArgs)
                            {
                                ListPropertyChangedEventArgs le = (ListPropertyChangedEventArgs)e.Inner;
                                if (le.Property == "Width")
                                {
                                    GridColumnDescriptor cd = (GridColumnDescriptor)le.Item;
                                    AlignColumnWidth(cd, oldWidth);
                                }
                            }
                            break;
                        }
                }
            }
        }

        bool inAlignColumnWidth = false;

        private void AlignColumnWidth(GridColumnDescriptor cd, int oldWidth)
        {
            if (inAlignColumnWidth)
                return;

            inAlignColumnWidth = true;

            try
            {

                int delta = cd.Width - oldWidth;

                GridTableDescriptor td = cd.TableDescriptor;
                GridEngine engine = td.Engine;
                GridGroupingControl gcc = engine.ParentControl;

                RecurseAlignColumnWidth(gcc.TableDescriptor, cd, delta);
            }
            finally
            {
                inAlignColumnWidth = false;
            }
        }

        void RecurseAlignColumnWidth(GridTableDescriptor td, GridColumnDescriptor cd, int delta)
        {
            if (td.FrozenColumn == "")
                return;

            if (cd != td.Columns[td.FrozenColumn])
                td.Columns[td.FrozenColumn].Width += delta;

            if (td.Relations.NestedCount > 0)
            {
                foreach (GridRelationDescriptor rd in td.Relations)
                {
                    if (rd.RelationKind == RelationKind.RelatedMasterDetails || rd.RelationKind == RelationKind.UniformChildList)
                    {
                        GridTableDescriptor childTableDescriptor = rd.ChildTableDescriptor;
                        RecurseAlignColumnWidth(childTableDescriptor, cd, delta);
                    }
                }
            }
        }
#endif

        Random rnd = new Random();
		private int numberParentRows = 5;
		private int numberChildRows = 20;
		private int numberGrandChildRows = 50;
		private DataTable GetParentTable()
		{
			DataTable dt = new DataTable("ParentTable");

			
			dt.Columns.Add(new DataColumn("parentID")); //lower case p
			dt.Columns.Add(new DataColumn("ParentName"));
			dt.Columns.Add(new DataColumn("ParentDec"));
            for (int n = 1; n < 10; n++)
                dt.Columns.Add(new DataColumn("Col " + n.ToString()));

			for(int i = 0; i < numberParentRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i;
				dr[1] = string.Format("parentName{0}", i);
                for (int n = 1; n < 10; n++)
                    dr[n + 2] = rnd.Next(100);
				dt.Rows.Add(dr);
			}

			return dt;
		}

		private DataTable GetChildTable()
		{
			DataTable dt = new DataTable("ChildTable");

			dt.Columns.Add(new DataColumn("childID")); //lower case c
			dt.Columns.Add(new DataColumn("Name"));
			dt.Columns.Add(new DataColumn("ParentID")); //upper case P
            for (int n = 1; n < 10; n++)
                dt.Columns.Add(new DataColumn("Col " + n.ToString()));
			
			for(int i = 0; i < numberChildRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("ChildName{0}",i);
				dr[2] = (i % numberParentRows).ToString();
                for (int n = 1; n < 10; n++)
                    dr[n + 2] = rnd.Next(100);
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
            for (int n = 1; n < 10; n++)
                dt.Columns.Add(new DataColumn("Col " + n.ToString()));
			
			for(int i = 0; i < numberGrandChildRows; i++)
			{
				DataRow dr = dt.NewRow();
				dr[0] = i.ToString();
				dr[1] = string.Format("GrandChildName{0}",i);
				dr[2] = (i % numberChildRows).ToString();
                for (int n = 1; n < 10; n++)
                    dr[n + 2] = rnd.Next(100);
                dt.Rows.Add(dr);
			}
			
			return dt;
		}
	}
}
