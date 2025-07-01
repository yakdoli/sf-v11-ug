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

using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

namespace CustomSummary
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
		private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private CustomSummary.DataSet1 dataSet11;
        internal PropertyGrid propertyGrid;
        private Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			ReadXml(this.dataSet11,"OrderDetails.xml");
			


			// Setup a integrated summary
			GridSummaryColumnDescriptor sd0 = new GridSummaryColumnDescriptor();
			//sd0.Name = "QuantityAvg";
			sd0.DataMember = "Quantity";
			sd0.DisplayColumn = "Quantity";
			sd0.Format = "{Average:#.00}";
			sd0.SummaryType = SummaryType.DoubleAggregate;
			this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new GridSummaryRowDescriptor("Row 0", "Average", sd0));

			// Setup custom summaries
			this.gridGroupingControl1.QueryCustomSummary += new GridQueryCustomSummaryEventHandler(gridGroupingControl1_QueryCustomSummary);

			GridSummaryColumnDescriptor sd1 = new GridSummaryColumnDescriptor();
			sd1.Name = "QuantityTotal";
			sd1.DataMember = "Quantity";
			sd1.DisplayColumn = "Quantity";
			sd1.Format = "{Total}";
			sd1.SummaryType = SummaryType.Custom;
			this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new GridSummaryRowDescriptor("Row 1", "Total", sd1));
			
			GridSummaryColumnDescriptor sd2 = new GridSummaryColumnDescriptor();
			sd2.Name = "QuantityDistinctCount";
			sd2.DataMember = "Quantity";
			sd2.DisplayColumn = "Quantity";
			sd2.Format = "{Count}";
			sd2.SummaryType = SummaryType.Custom;
			this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new GridSummaryRowDescriptor("Row 2", "DistinctCount", sd2));

						
			GridSummaryColumnDescriptor sd3 = new GridSummaryColumnDescriptor();
			sd3.Name = "QuantityMedian";
			sd3.DataMember = "Quantity";
			sd3.DisplayColumn = "Quantity";
			sd3.Format = "{Median}";
			sd3.SummaryType = SummaryType.Custom;
			this.gridGroupingControl1.TableDescriptor.SummaryRows.Add(new GridSummaryRowDescriptor("Row 3", "Statistic Median", sd3));


			// Setup running totals by displaying the value of a custom counter in an unbound field
			FieldDescriptor unboundField = new FieldDescriptor("QuantityCount", "", false, "");
			unboundField.ReadOnly = false;
			this.gridGroupingControl1.TableDescriptor.UnboundFields.Add(unboundField);
			
			this.gridGroupingControl1.TableDescriptor.QueryValue += new FieldValueEventHandler(unboundField_QueryValue); // Routine that queries for the value
			this.gridGroupingControl1.TableDescriptor.SaveValue += new FieldValueEventHandler(unboundField_SaveValue);

			FieldDescriptor unboundField2 = new FieldDescriptor("QuantityCount2", "", false, "");
			this.gridGroupingControl1.TableDescriptor.UnboundFields.Add(unboundField2);
			
			

			this.gridGroupingControl1.TableDescriptor.Columns.IsModified = true;

			Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
			Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
			gridColumnDescriptor1.MappingName = "OrderID";
			this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
																																			 gridColumnDescriptor1,
																																			 new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ProductID"),
																																			 new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("UnitPrice"),
																																			 new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Quantity"),
			});


			GridColumnDescriptor columnDescriptor = new GridColumnDescriptor (unboundField);
			columnDescriptor.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(245)), ((System.Byte)(227))));
			this.gridGroupingControl1.TableDescriptor.Columns.Add(columnDescriptor);

			GridColumnDescriptor columnDescriptor2 = new GridColumnDescriptor (unboundField2);
			columnDescriptor2.Appearance.AnyRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(245)), ((System.Byte)(227))));
			this.gridGroupingControl1.TableDescriptor.Columns.Add(columnDescriptor2);

			// Setup custom counter
			this.gridGroupingControl1.Table.QueryCustomCount += new CustomCountEventHandler(Table_QueryCustomCount);
			this.gridGroupingControl1.CurrentRecordContextChange += new CurrentRecordContextChangeEventHandler(gridGroupingControl1_CurrentRecordContextChange);
			this.gridGroupingControl1.Table.QueryVisibleCustomCount += new CustomCountEventHandler(Table_QueryVisibleCustomCount);

			// Assign data source
			this.gridGroupingControl1.DataMember = null;
			this.gridGroupingControl1.DataSource = this.dataSet11.Order_Details;

			quantityFieldDescriptor = this.gridGroupingControl1.TableDescriptor.Fields["Quantity"];

			// Add a filter so that we can check out difference between VisibleCustomCount (only records that meet criteria are counted) 
			// and CustomCount (all records are counted)
			this.gridGroupingControl1.TableDescriptor.RecordFilters.Add("[UnitPrice] > 20");

			this.gridGroupingControl1.FilterRuntimeProperties = true;

			this.gridGroupingControl1.TableControlCellClick += new GridTableControlCellClickEventHandler(gridGroupingControl1_TableControlCellClick);
			this.gridGroupingControl1.TableDescriptor.Columns["QuantityCount"].AllowGroupByColumn = false;
			this.gridGroupingControl1.TableDescriptor.Columns["QuantityCount2"].AllowGroupByColumn = false;

            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.TableModel.QueryColWidth += new GridRowColSizeEventHandler(TableModel_QueryColWidth);

		}

        void TableModel_QueryColWidth(object sender, GridRowColSizeEventArgs e)
        {
            if (e.Index > 0)
            {
                if (e.Index > this.gridGroupingControl1.TableModel.ColCount - 4)
                {
                    e.Size = 90;
                    return;
                }
                e.Size = 65;
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
		
		void gridGroupingControl1_TableControlCellClick(object sender, GridTableControlCellClickEventArgs e)
		{
			GridTableCellStyleInfo style = e.TableControl.Model[e.Inner.RowIndex, e.Inner.ColIndex] as GridTableCellStyleInfo;
			if (style != null 
				&& style.TableCellIdentity.DisplayElement is GridColumnHeaderRow
				&& style.TableCellIdentity.Column != null
				&& style.TableCellIdentity.Column.Name.IndexOf("Count") != -1)
			{
				MessageBox.Show("Can't sort by this column. Its contents are dependant on the order of records and will change if you sort by another column.");
				e.Inner.Cancel = true;
			}
		}

		FieldDescriptor quantityFieldDescriptor; 


		/// <summary>
		/// Custom Sumaries - associate with CreateSummaryMethod
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridGroupingControl1_QueryCustomSummary(object sender, GridQueryCustomSummaryEventArgs e)
		{
			switch (e.SummaryColumn.Name)
			{
				case "QuantityTotal":
				{
					e.SummaryDescriptor.CreateSummaryMethod = new CreateSummaryDelegate(TotalSummary.CreateSummaryMethod);
					break;
				}

				case "QuantityDistinctCount":
				{
					e.SummaryDescriptor.CreateSummaryMethod = new CreateSummaryDelegate(DistinctInt32CountSummary.CreateSummaryMethod);
					break;
				}

				case "QuantityMedian":
				{
					e.SummaryDescriptor.CreateSummaryMethod = new CreateSummaryDelegate(StatisticsSummary.CreateSummaryMethod);
					break;
				}

			}
		}


		/// <summary>
		/// Query value for unbound field
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void unboundField_QueryValue(object sender, FieldValueEventArgs e)
		{
			if (e.Record is AddNewRecord)
				return;

			if (e.Field.Name == "QuantityCount")
				e.Value = e.Record.GetCustomPosition();
			else
				e.Value = e.Record.GetVisibleCustomPosition();
		}

		/// <summary>
		/// Could write back value here if needed when unbound field is changed by user.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void unboundField_SaveValue(object sender, FieldValueEventArgs e)
		{
			Console.WriteLine(e.Value);
		}



		/// <summary>
		/// Fill in custom counter. This event is called for every record in the table. The CustomCounter
		/// will increase no matter if a record meet filter criteria or not.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Table_QueryCustomCount(object sender, CustomCountEventArgs e)
		{
			if (e.Record is AddNewRecord)
				return;

			object obj = e.Record.GetValue(quantityFieldDescriptor);
			double quantity = Convert.ToDouble(obj);
			e.CustomCount = quantity;
		}

		/// <summary>
		/// Fill in visible custom counter. This event is called for every visible record in the table. The CustomCounter
		/// will increase only for records that meet filter criteria.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Table_QueryVisibleCustomCount(object sender, CustomCountEventArgs e)
		{
            //if (e.Record is AddNewRecord)
            //    return;

            //object obj = e.Record.GetValue(quantityFieldDescriptor);
            //double quantity = Convert.ToDouble(obj);
            //e.CustomCount = quantity;
		}

		/// <summary>
		/// We need to make counters dirty when the record has changed since the custom counters need
		/// to be recalculated for subsequent records. Also, the grid needs to be redrawn.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void gridGroupingControl1_CurrentRecordContextChange(object sender, CurrentRecordContextChangeEventArgs e)
		{
			if (e.Action == CurrentRecordAction.EndEditComplete)
			{
                e.Record.InvalidateCounterBottomUp();
                this.gridGroupingControl1.Refresh();
			}
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
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.dataSet11 = new CustomSummary.DataSet1();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(12, 32);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(478, 426);
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
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.BaseStyle = "";
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" +
                "es;persist security info=True;user id=sa;packet size=4096;Pooling=true";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"),
            new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"),
            new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"),
            new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"),
            new System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"),
            new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"),
            new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"),
            new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"),
            new System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"),
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Discount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OrderID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Discount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Order Details", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("OrderID", "OrderID"),
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("Discount", "Discount")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertyGrid
            // 
            this.propertyGrid.BackColor = System.Drawing.Color.White;
            this.propertyGrid.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid.LineColor = System.Drawing.Color.White;
            this.propertyGrid.Location = new System.Drawing.Point(503, 32);
            this.propertyGrid.Margin = new System.Windows.Forms.Padding(10);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.SelectedObject = this.gridGroupingControl1;
            this.propertyGrid.Size = new System.Drawing.Size(263, 426);
            this.propertyGrid.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(496, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 410);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(779, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.gridGroupingControl1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Summary Demo";
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
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
