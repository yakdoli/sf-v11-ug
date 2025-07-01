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

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;

namespace ListItemReference
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
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
				Icon ico = new Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
				this.Icon = ico ;	
			}
			catch
			{}

			USStatesCollection usStates = USStatesCollection.CreateDefaultCollection();
			CountriesCollection countries = CountriesCollection.CreateDefaultCollection();

			this.gridGroupingControl1.Engine.SourceListSet.Add("Countries", countries);
			this.gridGroupingControl1.Engine.SourceListSet.Add("USStates", usStates);

			DataTable table = new DataTable();
			table.Columns.Add("Id", typeof(string));
			table.Columns.Add("Country", typeof(Country));
			table.Columns.Add("State", typeof(USState));

			// and then add a few rows:
			for ( int i=0; i < 50; i++ )
			{
				table.Rows.Add(table.NewRow());
				table.Rows[i][0] = i;
				table.Rows[i][1] = countries[i%8];
				if (i%8 == 0)
					table.Rows[i][2] = usStates[i/8];
			}

			GridTableDescriptor mainTd = this.gridGroupingControl1.TableDescriptor;
		

			GridRelationDescriptor usStatesRd = new GridRelationDescriptor();
			usStatesRd.Name = "State";
			usStatesRd.MappingName = "State";  // FieldName in table
			usStatesRd.ChildTableName = "USStates";  // SourceListSet name for lookup
			usStatesRd.RelationKind = RelationKind.ListItemReference;
            usStatesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227);
			usStatesRd.ChildTableDescriptor.VisibleColumns.Add("Name");
			usStatesRd.ChildTableDescriptor.SortedColumns.Add("Name");
			mainTd.Relations.Add(usStatesRd);

			GridRelationDescriptor countriesRd = new GridRelationDescriptor();
			countriesRd.Name = "Country";
			countriesRd.MappingName = "Country";  // FieldName in table
			countriesRd.ChildTableName = "Countries";  // SourceListSet name for lookup
			countriesRd.RelationKind = RelationKind.ListItemReference;
            countriesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227);
			countriesRd.ChildTableDescriptor.AllowEdit = true;
			countriesRd.ChildTableDescriptor.AllowNew = true;  // Make pencil icon appear, allow user to add countries (these setting will be overriden by CountriesCollection.IsReadOnly / CountriesCollection.IsFixedSize properties if they are true).
			mainTd.Relations.Add(countriesRd);

	

			this.gridGroupingControl1.DataSource = table;
            
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            //this.BackColor = Color.FromArgb(223, 227, 239);

			// After data source was set you could call LoadDefault and remove columns
			//			mainTd.Columns.LoadDefault();
			//			mainTd.Columns.Remove("Country.CountryCode");

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
            this.gridGroupingControl1.IntelliMousePanning = true;
            this.gridGroupingControl1.Location = new System.Drawing.Point(16, 16);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(712, 392);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(747, 422);
            this.Controls.Add(this.gridGroupingControl1);
            this.DropShadow = true;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Item Reference Demo";
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

            # if SyncfusionFramework1_1 || SyncfusionFramework2_0
                Application.EnableVisualStyles();
            # endif

			Application.Run(new Form1());
		}
	}
}
