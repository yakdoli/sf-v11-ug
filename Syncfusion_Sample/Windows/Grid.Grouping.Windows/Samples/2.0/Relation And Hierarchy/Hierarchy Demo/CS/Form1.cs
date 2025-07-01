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
using System.IO;

using Syncfusion.Grouping;

using Syncfusion.Collections;
using Syncfusion.Drawing;
using Syncfusion.ComponentModel;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace HierarchySample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new Form1());
        }
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl groupingGrid1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private HierarchySample.DataSet1 dataSet21;
		private Syncfusion.Windows.Forms.ButtonAdv expandAllButton;
        private Syncfusion.Windows.Forms.ButtonAdv CollapseAllbutton;
        private PropertyGrid propertyGrid1;
        private IContainer components;

		void ReadXml(DataSet ds, string xmlFileName)
		{
			for (int n = 0; n < 10; n++)
			{
				if (File.Exists(xmlFileName))
				{
					ds.ReadXml(xmlFileName);
					break;
				}
				xmlFileName = @"..\" + xmlFileName;
			}
		}

		void CheckVisibleCount(Table tb)
		{
			int v = tb.GetVisibleCount();

			
			tb.InvalidateCounterTopDown(true);
			

			if (v != tb.GetVisibleCount())
				Console.WriteLine("{0} <> {1}", v, tb.GetVisibleCount());
		}


		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            
            this.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.groupingGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.groupingGrid1.GridVisualStyles = GridVisualStyles.Metro;
            this.groupingGrid1.GridOfficeScrollBars = OfficeScrollBars.Metro;

			try
			{
				Icon ico = new Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
				this.Icon = ico ;	
			}
			catch
			{}

			this.groupingGrid1.ShowNavigationBar = true;
			this.groupingGrid1.TableControl.HorizontalScrollTips = false;
			this.groupingGrid1.BorderStyle = BorderStyle.FixedSingle;
			this.groupingGrid1.FilterRuntimeProperties = true;
            this.propertyGrid1.SelectedObject = this.groupingGrid1;
			
			DataSet ds = new DataSet();
			ReadXml(ds, @"Common\Data\Expand.xml");

			ds.Tables[1].TableName = "Products";
			ds.Tables[2].TableName = "OrderDetails";
			ds.Tables[3].TableName = "Suppliers";

			ds.Relations.Add(
				ds.Tables[0].Columns["CategoryID"], 
				ds.Tables[1].Columns["CategoryID"]);
			ds.Relations[0].RelationName = "Category_Products";

			ds.Relations.Add(
				ds.Tables[1].Columns["ProductID"], 
				ds.Tables[2].Columns["ProductID"]);
			ds.Relations[1].RelationName = "Products_OrderDetails";

			this.groupingGrid1.DataSource = ds.Tables[0];

			GridEngine engine = this.groupingGrid1.Engine;

			engine.TopLevelGroupOptions.ShowCaption = true;

			// Record summary for Categories Tables
			
			GridTableDescriptor categoriesTableDescriptor = (GridTableDescriptor) engine.TableDescriptor;

			categoriesTableDescriptor.Columns.Clear();
			categoriesTableDescriptor.Columns.Add("CategoryID");
			categoriesTableDescriptor.Columns.Add("CategoryName");
			categoriesTableDescriptor.Columns.Add("Description");

			categoriesTableDescriptor.Columns["CategoryName"].Width = 200;

			GridSummaryColumnDescriptor countCat = new GridSummaryColumnDescriptor("RecordCount");
			countCat.SummaryType = SummaryType.Count;
			countCat.Style = GridSummaryStyle.FillRow;
			countCat.DataMember = "CategoryID";
			countCat.Format = "      {Count} Records.";

			GridSummaryRowDescriptor categoriesSummaryRow = new GridSummaryRowDescriptor("RecordCountRow");
			categoriesSummaryRow.SummaryColumns.Add(countCat);
			categoriesTableDescriptor.SummaryRows.Add(categoriesSummaryRow);

			// Group Products table by "SupplierID"
			RelationDescriptor productsRelationDescriptor = categoriesTableDescriptor.Relations["Products"];
			GridTableDescriptor productsTableDescriptor = (GridTableDescriptor) productsRelationDescriptor.ChildTableDescriptor;
			productsTableDescriptor.GroupedColumns.Add("SupplierID");

			// Group OrderDetails table by "Discount"
			// Add Total = "[UnitPrice]*[Quantity]" expression field
			// Add Summaries for Total and Average for UnitPrice.

			RelationDescriptor orderDetailsRelationDescriptor = productsTableDescriptor.Relations["OrderDetails"];
			GridTableDescriptor orderDetailsTableDescriptor = (GridTableDescriptor) orderDetailsRelationDescriptor.ChildTableDescriptor;

			ExpressionFieldDescriptor ed = new ExpressionFieldDescriptor("Total", "[UnitPrice]*[Quantity]");
			ed.DefaultValue = "";
			orderDetailsTableDescriptor.ExpressionFields.Add(ed);
			orderDetailsTableDescriptor.GroupedColumns.Add("Discount");
			
			GridSummaryRowDescriptor orderDetailsSummaryRow = new GridSummaryRowDescriptor("Total");
			orderDetailsTableDescriptor.SummaryRows.Add(orderDetailsSummaryRow);

			GridSummaryColumnDescriptor totalSum = new GridSummaryColumnDescriptor("Total");
			totalSum.SummaryType = SummaryType.DoubleAggregate;
			totalSum.Style = GridSummaryStyle.Column;
			totalSum.DataMember = "Total";
			totalSum.DisplayColumn = "Total";
			totalSum.Format = "Sum={Sum}";
			orderDetailsSummaryRow.SummaryColumns.Add(totalSum);


			orderDetailsTableDescriptor.Columns["Total"].Width = 70;
			

			GridSummaryColumnDescriptor avgUnitPrice = new GridSummaryColumnDescriptor("AvgUnitPrice");
			avgUnitPrice.SummaryType = SummaryType.DoubleAggregate;
			avgUnitPrice.Style = GridSummaryStyle.Column;
			avgUnitPrice.DataMember = "UnitPrice";
			avgUnitPrice.DisplayColumn = "UnitPrice";
			avgUnitPrice.Format = "Avg={Average:#.0}";
			orderDetailsSummaryRow.SummaryColumns.Add(avgUnitPrice);

			// expand a specific record, search for groups etc.
			Table categoriesTable = engine.Table;//.RelatedTables["Categories"];
			Console.WriteLine(categoriesTable.ToString());

			Table productsTable = categoriesTable.RelatedTables["Products"];
			Console.WriteLine(productsTable.ToString());

			// Get the child table in the products table that is assocuated with category "1"
			ChildTable product1 = (ChildTable) productsTable.TopLevelGroup.Groups["1"];
			Console.WriteLine(product1.ToString());
			Console.WriteLine(product1.Groups[0].ToString());

			// Get the child table in the products table that is assocuated with category "1"
			ChildTable product21 = (ChildTable) productsTable.TopLevelGroup.Groups["8"];
			Console.WriteLine(product21.ToString());
			Console.WriteLine(product21.Groups[0].Records[0].ToString());

			// Show me the associated "NestedTable" element of the categories table (the NestedTable 
			// element established the link between parent table and a nested child table)
			Console.WriteLine(product21.Groups[0].Records[0].ParentChildTable.ParentNestedTable);

			// Expand the product for category 8
			product21.IsExpanded = true;
			product21.ParentNestedTable.IsExpanded = true;
			product21.ParentNestedTable.ParentRecord.IsExpanded = true;

			// When you assign a "DataSet" as a datasource, the DataSet is a list with one record (not allowing AddNew) with nested tables.
			// Expand the first record so that tables are shown.
			engine.Table.TopLevelGroup.Records[0].IsExpanded = true;

			// Sort  product table by ProductName 
			product21.ParentTable.TableDescriptor.SortedColumns.Add("ProductName");

			// Find group for supplier id 21
			Group supplier21Group = product21.Groups["21"];

			// Find productname Spegesild in that group
			int index = supplier21Group.Records.FindRecord("Spegesild");

			// Print out the row index and record index
			Record r = supplier21Group.Records[index];
			Console.WriteLine("Found: " + r.ToString());
			Console.WriteLine("RowIndex " + engine.Table.NestedDisplayElements.IndexOf(r).ToString());
			Console.WriteLine("Record Index " + engine.Table.Records.IndexOf(r).ToString());

			// Dump out nested display elements to console



			this.groupingGrid1.Table.Records[0].IsExpanded = true;
			this.groupingGrid1.Table.TopLevelGroup.IsExpanded = true;


			engine.ChildGroupOptions.ShowCaption = true;
			engine.NestedTableGroupOptions.ShowCaption = true;



			// Adding GroupDropAreas for nested tables.
			groupingGrid1.AddGroupDropArea((GridTable) productsTable);
			groupingGrid1.AddGroupDropArea((GridTable) productsTable.RelatedTables[0]);
			groupingGrid1.ShowGroupDropArea = true;

			// Make Spegesild current record
			if (r != null)
			{
				r.SetCurrent();

				// Expand record and nested tables
				r.IsExpanded = true;
				r.NestedTables[0].IsExpanded = true;

				Record orderDetailsRecords = r.NestedTables[0].ChildTable.GetFirstRecord();
				// Expand Group record belongs to
				orderDetailsRecords.ParentGroup.IsExpanded = true;

				// Scroll this record in view.
				groupingGrid1.TableControl.ScrollInView(orderDetailsRecords);
				groupingGrid1.TableControl.LeftColIndex = 1;
			}

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
            this.groupingGrid1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataSet21 = new HierarchySample.DataSet1();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.expandAllButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.CollapseAllbutton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
            this.SuspendLayout();
            // 
            // groupingGrid1
            // 
            this.groupingGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupingGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.groupingGrid1.Location = new System.Drawing.Point(0, 0);
            this.groupingGrid1.Name = "groupingGrid1";
            this.groupingGrid1.Size = new System.Drawing.Size(518, 335);
            this.groupingGrid1.TabIndex = 1;
            this.groupingGrid1.Text = "groupingGrid1";
            // 
            // dataSet21
            // 
            this.dataSet21.DataSetName = "DataSet1";
            this.dataSet21.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" +
                ", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" +
                "es;persist security info=True;user id=sa;packet size=4096;Pooling=true";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
                        new System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"),
                        new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
                        new System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
                        new System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"),
                        new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"),
                        new System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})});
            // 
            // expandAllButton
            // 
            this.expandAllButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.expandAllButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.expandAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.expandAllButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.expandAllButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expandAllButton.ForeColor = System.Drawing.Color.White;
            this.expandAllButton.Location = new System.Drawing.Point(466, 350);
            this.expandAllButton.Name = "expandAllButton";
            this.expandAllButton.Size = new System.Drawing.Size(128, 24);
            this.expandAllButton.TabIndex = 2;
            this.expandAllButton.Text = "Expand All";
            this.expandAllButton.UseVisualStyle = true;
            this.expandAllButton.Click += new System.EventHandler(this.expandAllButton_Click);
            // 
            // CollapseAllbutton
            // 
            this.CollapseAllbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CollapseAllbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.CollapseAllbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.CollapseAllbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.CollapseAllbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollapseAllbutton.ForeColor = System.Drawing.Color.White;
            this.CollapseAllbutton.Location = new System.Drawing.Point(612, 350);
            this.CollapseAllbutton.Name = "CollapseAllbutton";
            this.CollapseAllbutton.Size = new System.Drawing.Size(128, 24);
            this.CollapseAllbutton.TabIndex = 2;
            this.CollapseAllbutton.Text = "Collapse All";
            this.CollapseAllbutton.UseVisualStyle = true;
            this.CollapseAllbutton.Click += new System.EventHandler(this.CollapseAllbutton_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(533, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(255, 335);
            this.propertyGrid1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 391);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.expandAllButton);
            this.Controls.Add(this.groupingGrid1);
            this.Controls.Add(this.CollapseAllbutton);
            this.DropShadow = true;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hierarchy Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private void menuItemExitApp_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItemDsChoose_Click(object sender, System.EventArgs e)
		{
			_ShowGridColumnsDialog(this.groupingGrid1.Engine.TableDescriptor, "Columns", null, typeof(GridColumnDescriptorCollection));
		}
		
		internal DialogResult _ShowGridColumnsDialog(object instance, string propertyName, IServiceProvider provider, Type type)
		{
			GroupingCollectionEditor ce = new GroupingCollectionEditor(type);
			Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(provider);
			PropertyDescriptor pd = TypeDescriptor.GetProperties(instance)[propertyName];
			Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(instance, pd);
			tdc.ServiceProvider = esc;

			ce.EditValue(tdc, esc, pd.GetValue(instance));

			Control control = instance as Control;
			if (control != null)
				control.Invalidate();
			this.groupingGrid1.Refresh();

			return esc.DialogResult;
		}


		private void Form1_Load(object sender, System.EventArgs e)
		{

		}

		private void menuItemXPThemes_Click(object sender, System.EventArgs e)
		{
			GridStyleInfo standard = this.groupingGrid1.Engine.Appearance.AnyCell;
			standard.Themed = !standard.Themed;
			this.groupingGrid1.ThemesEnabled = standard.Themed;
			this.groupingGrid1.Refresh();
		}

		private void expandAllButton_Click(object sender, System.EventArgs e)
		{
			// Set focus back to grid
			this.ActiveControl = groupingGrid1;

			// Scroll to top
			groupingGrid1.TableControl.VScrollBar.Value = groupingGrid1.TableControl.VScrollBar.Minimum;

			// Determine current element. If it is a nested table, get the current element of the child table.
			Element el = this.groupingGrid1.Table.CurrentElement;
			while (el is NestedTable)
				el = ((NestedTable) el).ChildTable.ParentTable.CurrentElement;

			// Expand all records
			this.groupingGrid1.Table.ExpandAllRecords();

			// Scroll current record into view.
			if (el != null)
			{
				// Restore Current Field 
				el.ParentTable.CurrentRecordManager.NavigateTo(el); 

				// Scroll element into view
				groupingGrid1.TableControl.ScrollInView(el);
			}

			// Synchronize grid display with engine changes.
			this.groupingGrid1.Update();

			Console.WriteLine(this.groupingGrid1.Table.GetCounter());
		}

		private void CollapseAllbutton_Click(object sender, System.EventArgs e)
		{
			// Set focus back to grid
			this.ActiveControl = groupingGrid1;

			// Scroll to top
			groupingGrid1.TableControl.VScrollBar.Value = groupingGrid1.TableControl.VScrollBar.Minimum;

			// Determine current element. If it is a nested table, get the parent record.
			Element el = this.groupingGrid1.Table.CurrentElement;
			while (el is NestedTable)
				el = el.ParentRecord;

			// Collapse all records.
			this.groupingGrid1.Table.CollapseAllRecords();
            this.groupingGrid1.Table.CollapseAllGroups();

			// Scroll current record into view.
			if (el != null)
			{
				// Restore Current Field 
				el.ParentTable.CurrentRecordManager.NavigateTo(el); 

				// Scroll element into view
				groupingGrid1.TableControl.ScrollInView(el);
			}

			// Synchronize grid display with engine changes.
			this.groupingGrid1.Update();
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm( AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
		}

	}
}