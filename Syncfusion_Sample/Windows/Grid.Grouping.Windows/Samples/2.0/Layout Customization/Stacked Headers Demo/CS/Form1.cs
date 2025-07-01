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

using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;

using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary;

namespace CustomSectionInGroup
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Syncfusion.Windows.Forms.MetroForm
	{
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private StackedHeaders.DataSet1 northwindDataSet1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapterOrders;
		private System.Data.SqlClient.SqlConnection sqlConnection2;
        private PropertyGrid propertyGrid1;

		private System.ComponentModel.Container components = null;

		public Form1()
		{
			// GroupingEngineFactory provides a modified GridChildTable that adds an extra section
			//GridEngineFactory.Factory = new GroupingEngineFactory();
			
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            //
			// TODO: Add any constructor code after InitializeComponent call
			//

			InitializeDataSet();
			
			System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
			this.Icon = ico ;	
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

		
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
        }

        void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            if (e.Style.CellValueType == typeof(DateTime))
            {
                e.Style.Format = "MM/dd/yyyy";
            }
        }

		string xmlName = "Common\\Data\\Orders.xml";
		bool msdeAvailable = false;

		void InitializeDataSet()
		{
			if (msdeAvailable)
			{
				// Initialize the data set

				this.northwindDataSet1.BeginInit();

				// Order is important here - first fill tables that are referenced with 
				// foreign keys, then tables that have references to others.

				this.sqlDataAdapterOrders.Fill(this.northwindDataSet1);

				this.northwindDataSet1.EndInit();

				this.northwindDataSet1.WriteXml(xmlName);
			}
			else
			{
				// Read from a xml file instead. 
				if (!ReadXml(this.northwindDataSet1, xmlName))
				{
					// If no xml found, try again with MSDE
					msdeAvailable = true;
					InitializeDataSet();
				}
			}

		}

		bool ReadXml(DataSet ds, string xmlFileName)
		{
			// Check both in parent folder and Parent\Data folders.
			string xmlDataFileName = @"Common\Data\" + xmlFileName;
			for (int n = 0; n < 10; n++)
			{
				if (System.IO.File.Exists(xmlFileName))
				{
					ds.ReadXml(xmlFileName);
					return true;
				}
				if (System.IO.File.Exists(xmlDataFileName))
				{
					ds.ReadXml(xmlDataFileName);
					return true;
				}
				xmlFileName = @"..\" + xmlFileName;
				xmlDataFileName = @"..\" + xmlDataFileName;
			}

			return false;
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor gridStackedHeaderRowDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderRowDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor gridStackedHeaderDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection2 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapterOrders = new System.Data.SqlClient.SqlDataAdapter();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.northwindDataSet1 = new StackedHeaders.DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" +
                "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" +
                "Country FROM Orders";
            this.sqlSelectCommand2.Connection = this.sqlConnection2;
            // 
            // sqlConnection2
            // 
            this.sqlConnection2.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" +
                "es;persist security info=True;user id=sa;packet size=4096;Pooling=true";
            this.sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapterOrders
            // 
            this.sqlDataAdapterOrders.SelectCommand = this.sqlSelectCommand2;
            this.sqlDataAdapterOrders.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Orders", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"),
                        new System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"),
                        new System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"),
                        new System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"),
                        new System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"),
                        new System.Data.Common.DataColumnMapping("Freight", "Freight"),
                        new System.Data.Common.DataColumnMapping("ShipName", "ShipName"),
                        new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
                        new System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"),
                        new System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"),
                        new System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"),
                        new System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})});
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(679, 2);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid1.Size = new System.Drawing.Size(272, 444);
            this.propertyGrid1.TabIndex = 11;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.gridGroupingControl1.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
            this.gridGroupingControl1.Appearance.StackedHeaderCell.Themed = false;
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowColumnHeaders = true;
            this.gridGroupingControl1.ChildGroupOptions.ShowStackedHeaders = true;
            this.gridGroupingControl1.DataSource = this.northwindDataSet1.Orders;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(9, 2);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(655, 444);
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
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("OrderID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("CustomerID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("EmployeeID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("OrderDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("RequiredDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShippedDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipVia"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Freight"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipName"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipAddress"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipCity"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipRegion"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipPostalCode"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ShipCountry")});
            this.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("OrderID", System.ComponentModel.ListSortDirection.Ascending)});
            gridStackedHeaderRowDescriptor1.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))));
            gridStackedHeaderDescriptor1.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))));
            gridStackedHeaderDescriptor1.Appearance.StackedHeaderCell.TextColor = System.Drawing.Color.Black;
            gridStackedHeaderDescriptor1.HeaderText = "Header One";
            gridStackedHeaderDescriptor1.Name = "StackedHeader 1";
            gridStackedHeaderDescriptor1.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("CustomerID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("EmployeeID")});
            gridStackedHeaderDescriptor2.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))));
            gridStackedHeaderDescriptor2.HeaderText = "Header Two";
            gridStackedHeaderDescriptor2.Name = "StackedHeader 2";
            gridStackedHeaderDescriptor2.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("OrderDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("Freight"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("RequiredDate")});
            gridStackedHeaderDescriptor3.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))));
            gridStackedHeaderDescriptor3.HeaderText = "Header Three";
            gridStackedHeaderDescriptor3.Name = "StackedHeader 3";
            gridStackedHeaderDescriptor3.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShippedDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipVia"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipName")});
            gridStackedHeaderDescriptor4.Appearance.StackedHeaderCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))));
            gridStackedHeaderDescriptor4.HeaderText = "Header Four";
            gridStackedHeaderDescriptor4.Name = "StackedHeader 4";
            gridStackedHeaderDescriptor4.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipAddress"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipCity"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipRegion"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipPostalCode"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderVisibleColumnDescriptor("ShipCountry")});
            gridStackedHeaderRowDescriptor1.Headers.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridStackedHeaderDescriptor[] {
            gridStackedHeaderDescriptor1,
            gridStackedHeaderDescriptor2,
            gridStackedHeaderDescriptor3,
            gridStackedHeaderDescriptor4});
            gridStackedHeaderRowDescriptor1.Name = "Row 1";
            this.gridGroupingControl1.TableDescriptor.StackedHeaderRows.Add(gridStackedHeaderRowDescriptor1);
            this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryRowDescriptor("SummaryRow 1", new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor[] {
                new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor("FreightAverage", Syncfusion.Grouping.SummaryType.DoubleAggregate, "Freight", "{Average:###.00}")}));
            this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryRowDescriptor("SummaryRow 2", "Total", new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor[] {
                new Syncfusion.Windows.Forms.Grid.Grouping.GridSummaryColumnDescriptor("FreightTotal", Syncfusion.Grouping.SummaryType.DoubleAggregate, "Freight", "{Sum:###.00}")}));
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("OrderID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("CustomerID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("EmployeeID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("OrderDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Freight"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("RequiredDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShippedDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipVia"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipName"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipAddress"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipCity"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipRegion"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipPostalCode"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ShipCountry")});
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229))))));
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            // 
            // northwindDataSet1
            // 
            this.northwindDataSet1.DataSetName = "DataSet1";
            this.northwindDataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(962, 454);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stacked Headers Demo";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet1)).EndInit();
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			for(int j=0;j<this.gridGroupingControl1.TableDescriptor.StackedHeaderRows["Row1"].Headers.Count;j++)
			{
				Console.WriteLine(this.gridGroupingControl1.TableDescriptor.StackedHeaderRows["Row1"].Headers[j].Name);

			}
		}

	}



}