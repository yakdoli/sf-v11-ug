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
using System.Data.OleDb;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;


namespace GridGroupingRebind
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private IContainer components;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv combobox;
        private PropertyGrid propertyGrid1;
        private ButtonAdv button2;
        private Panel panel1;
        private Label label1;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

		public Form1()
		{
			// Debug helpers to see when objects are created and destroyed (work only for debug builds
			// of libraries).
			Syncfusion.Grouping.RelationDescriptorCollection.VerboseEnsureInitialized = true;
			Syncfusion.Grouping.Engine.VerboseEnsureObjectLifeTime = true;
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
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
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
            this.components = new System.ComponentModel.Container();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.combobox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowCaption = true;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 22);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(495, 446);
            this.gridGroupingControl1.SortIconPlacement = Syncfusion.Windows.Forms.Grid.SortIconPlacement.Right;
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.AllowNew = false;
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229))))));
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            // 
            // combobox
            // 
            this.combobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.combobox.BackColor = System.Drawing.Color.White;
            this.combobox.Items.AddRange(new object[] {
            "Products",
            "Customer Order",
            "Customer Order Details"});
            this.combobox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.combobox, "Products"));
            this.combobox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.combobox, "Customer Order"));
            this.combobox.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.combobox, "Customer Order Details"));
            this.combobox.Location = new System.Drawing.Point(80, 12);
            this.combobox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(152, 23);
            this.combobox.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.combobox.TabIndex = 2;
            this.combobox.Text = "Products";
            this.combobox.SelectedIndexChanged += new System.EventHandler(this.combobox_SelectedIndexChanged);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(532, 122);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(255, 346);
            this.propertyGrid1.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(80, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 27);
            this.button2.TabIndex = 16;
            this.button2.Text = "Reset DataSource";
            this.button2.UseVisualStyle = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.combobox);
            this.panel1.Location = new System.Drawing.Point(532, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 94);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "DataSource";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(799, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Binding Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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

		private DataSet queryOleDb(string name, string query)
		{
			DataSet ds = new DataSet();
                String commandstring = query;

                SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connString);
                da.Fill(ds, name);
			return ds;
		}

		private void BindData(DataSet ds)
		{
			this.gridGroupingControl1.SuspendLayout();

			this.gridGroupingControl1.DataSource = ds != null ? ds.Tables[0] : null;
			
			// Making columns marked readonly below, marks the schema as modified. Once 
			// a schema is marked modified, its setting stay even when the source list is changed.
			// This is by design and allows users to swap the datasource at runtime without having
			// to worry that manual changes to the schema are lost.
			//
			// In order to Reset the main table descriptor and also the nested relations
			// use the following two lines:
			this.gridGroupingControl1.ResetTableDescriptor();
			this.gridGroupingControl1.TableDescriptor.Relations.Reset();

			// Show group area
			this.gridGroupingControl1.ShowGroupDropArea = true;

			// Additionial table descriptors currently habe to be added manually. We
			// plan to provide a TableDescriptor.ShowInGroupDropArea property later
			// to make this easier.
			AddGroupDropAreas(this.gridGroupingControl1.Table);

			// Make changes to schema. See above notes how to reset changes.
			SetReadOnly(this.gridGroupingControl1.Table);

			this.gridGroupingControl1.ResumeLayout(true);
		}

		private void AddGroupDropAreas(GridTable table)
		{
			Syncfusion.Grouping.RelationDescriptor rd = table.TableDescriptor.ParentRelation;
			if (rd != null && rd.RelationKind != Syncfusion.Grouping.RelationKind.RelatedMasterDetails)
				return;

			foreach(GridTable t in table.RelatedTables)
			{
				Console.WriteLine("AddGroupDropArea " + t.Info);

				gridGroupingControl1.AddGroupDropArea(t);
				//recurse...
				AddGroupDropAreas(t);
			}
		}

		private void SetReadOnly(GridTable table)
		{
			table.TableDescriptor.AllowNew = false;
			table.TableDescriptor.AllowEdit = false;
			table.TableDescriptor.AllowRemove = false;
			
			//recurse...
			foreach(GridTable t in table.RelatedTables)
			{
				SetReadOnly(t);
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			DataSet ds = queryOleDb("Products", "SELECT * FROM PRODUCTS");
			if( ds != null && ds.Tables.Count>0 )
			{
				BindData(ds);
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			DataSet ds = queryOleDb("Customers", "SELECT * FROM CUSTOMERS");
			DataSet ds2 = queryOleDb("Orders", "SELECT * FROM ORDERS");
			if( ds != null && ds.Tables.Count>0 && ds2 != null && ds2.Tables.Count>0 )
			{
				ds.Merge(ds2.Tables[0]);
				
				DataRelation relation = new DataRelation("CustomerOrders", 
					ds.Tables["Customers"].Columns["CustomerID"], 
					ds.Tables["Orders"].Columns["CustomerID"]);
				ds.Relations.Add(relation);

				BindData(ds);
			}
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			DataSet ds = queryOleDb("Customers", "SELECT * FROM CUSTOMERS");
			DataSet ds2 = queryOleDb("Orders", "SELECT * FROM ORDERS");
			DataSet ds3 = queryOleDb("OrderDetails", "SELECT * FROM [ORDER DETAILS]");
			if( ds != null && ds.Tables.Count>0 && 
				ds2 != null && ds2.Tables.Count>0 && 
				ds3 != null && ds3.Tables.Count>0 )
			{
				ds.Merge(ds2.Tables[0]);
				ds.Merge(ds3.Tables[0]);
				
				DataRelation relation = new DataRelation("CustomerOrders", 
					ds.Tables["Customers"].Columns["CustomerID"], 
					ds.Tables["Orders"].Columns["CustomerID"]);
				ds.Relations.Add(relation);

				DataRelation relation2 = new DataRelation("OrderOrderDetails", 
					ds.Tables["Orders"].Columns["OrderID"], 
					ds.Tables["OrderDetails"].Columns["OrderID"]);
				ds.Relations.Add(relation2);

				BindData(ds);
			}
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			GroupingGridPropertyDialog dlg = new GroupingGridPropertyDialog(this.gridGroupingControl1);
			dlg.Show();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			BindData(null);
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = queryOleDb("Products", "SELECT * FROM PRODUCTS");
            if (ds != null && ds.Tables.Count > 0)
            {
                BindData(ds);
            }
        }

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxAdv cb = (ComboBoxAdv)sender;
            if (cb.Text == "Products")
            {
                menuItem2_Click(cb, e);
            }
            else if (cb.Text == "Customer Order")
            {
                menuItem3_Click(cb, e);

            }
            else if (cb.Text == "Customer Order Details")
            {
                menuItem4_Click(cb, e);
            }
        }

       
	}
}
