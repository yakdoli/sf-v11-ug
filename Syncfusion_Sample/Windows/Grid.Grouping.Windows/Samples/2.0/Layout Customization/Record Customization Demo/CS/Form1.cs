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
using System.Text;
using System.Xml;
using System.Runtime.Serialization;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;

namespace EmployeeView
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Syncfusion.Windows.Forms.MetroForm
	{
		private EmployeeView.DataSet1 dataSet11;
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        private PropertyGrid propertyGrid1;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            String commandstring = "select * from Employees";

            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connString);
            try
            {
                da.Fill(dataSet11, "Employees");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            this.Icon = ico;				

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
            this.gridGroupingControl1.Appearance.AnyCell.ImageSizeMode = GridImageSizeMode.CenterImage;
			this.gridGroupingControl1.IntelliMousePanning = true;

            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana";
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
			this.gridGroupingControl1.TableControl.ResizingRows+=new GridResizingRowsEventHandler(TableControl_ResizingRows);
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
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
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor5 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor6 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor7 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor8 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor3 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor4 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor5 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor6 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor gridColumnSetDescriptor7 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataSet11 = new EmployeeView.DataSet1();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridGroupingControl1.Appearance.AlternateRecordFieldCell.BaseStyle = "";
            this.gridGroupingControl1.Appearance.AlternateRecordFieldCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(219))))));
            this.gridGroupingControl1.Appearance.RecordPreviewCell.BaseStyle = "";
            this.gridGroupingControl1.Appearance.RecordPreviewCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246))))));
            this.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.BaseStyle = "";
            this.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.CellType = "Static";
            this.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.Enabled = false;
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = true;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.DataSource = this.dataSet11.Employees;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(13, 15);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(578, 359);
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
            gridColumnDescriptor1.HeaderText = "ID";
            gridColumnDescriptor1.MappingName = "EmployeeID";
            gridColumnDescriptor1.Width = 60;
            gridColumnDescriptor2.MappingName = "FirstName";
            gridColumnDescriptor2.Width = 115;
            gridColumnDescriptor3.MappingName = "Address";
            gridColumnDescriptor3.Width = 118;
            gridColumnDescriptor4.MappingName = "City";
            gridColumnDescriptor4.Width = 83;
            gridColumnDescriptor5.MappingName = "Region";
            gridColumnDescriptor5.Width = 80;
            gridColumnDescriptor6.MappingName = "Country";
            gridColumnDescriptor6.Width = 80;
            gridColumnDescriptor7.MappingName = "Title";
            gridColumnDescriptor7.Width = 144;
            gridColumnDescriptor8.MappingName = "TitleOfCourtesy";
            gridColumnDescriptor8.Width = 133;
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor1,
            gridColumnDescriptor2,
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("LastName"),
            gridColumnDescriptor3,
            gridColumnDescriptor4,
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("PostalCode"),
            gridColumnDescriptor5,
            gridColumnDescriptor6,
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("BirthDate"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Photo"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ReportsTo"),
            gridColumnDescriptor7,
            gridColumnDescriptor8});
            gridColumnSetDescriptor1.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("EmployeeID", "R0C0:R1C0")});
            gridColumnSetDescriptor1.Name = "ColumnSetId";
            gridColumnSetDescriptor2.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Photo", "R0C0:R1C0")});
            gridColumnSetDescriptor2.Name = "ColumnSetPhoto";
            gridColumnSetDescriptor3.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("FirstName", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("LastName", "R1C0")});
            gridColumnSetDescriptor3.Name = "ColumnSetName";
            gridColumnSetDescriptor4.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Address", "R0C0:R0C1"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("City", "R1C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("PostalCode", "R1C1")});
            gridColumnSetDescriptor4.Name = "ColumnSetAddress";
            gridColumnSetDescriptor5.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Region", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Country", "R1C0")});
            gridColumnSetDescriptor5.Name = "ColumnSetRegionCountry";
            gridColumnSetDescriptor6.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Title", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("TitleOfCourtesy", "R1C0")});
            gridColumnSetDescriptor6.Name = "ColumnSetTitle";
            gridColumnSetDescriptor7.ColumnSpans.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("BirthDate", "R0C0"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("ReportsTo", "R1C0")});
            gridColumnSetDescriptor7.Name = "ColumnSetBirth";
            this.gridGroupingControl1.TableDescriptor.ColumnSets.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor[] {
            gridColumnSetDescriptor1,
            gridColumnSetDescriptor2,
            gridColumnSetDescriptor3,
            gridColumnSetDescriptor4,
            gridColumnSetDescriptor5,
            gridColumnSetDescriptor6,
            gridColumnSetDescriptor7});
            this.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.gridGroupingControl1.TableOptions.RecordPreviewRowHeight = 60;
            this.gridGroupingControl1.TableOptions.RecordRowHeight = 30;
            this.gridGroupingControl1.TableOptions.ShowRecordPreviewRow = true;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = true;
            this.gridGroupingControl1.QueryCellStyleInfo += new Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventHandler(this.gridGroupingControl1_QueryCellStyleInfo);
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
            this.propertyGrid1.Location = new System.Drawing.Point(617, 15);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(272, 359);
            this.propertyGrid1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(905, 395);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.gridGroupingControl1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Record Customization Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.ResumeLayout(false);

		}

        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

		private void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
		{
			switch (e.TableCellIdentity.TableCellType)
			{
				case GridTableCellType.RecordPreviewCell:
				{
					GridGroupingControl groupingControl = (GridGroupingControl) sender;
					GridTable table = groupingControl.Table;
					GridRecord record = e.TableCellIdentity.DisplayElement.ParentRecord as GridRecord;
					if (record != null)
						e.Style.CellValue = record.GetValue("Notes").ToString();
					else
						e.Style.CellValue = "No Notes.";
					break;
				}
			}

			StringBuilder sb = new StringBuilder();

			sb.Append(e.TableCellIdentity.Info);

			if (e.Style != null)
			{
				sb.AppendFormat("\r\nCellType = {0}", e.Style.CellType);
				sb.AppendFormat(", CellValueType = {0}", e.Style.CellValueType);
				sb.AppendFormat(", nFormat = \"{0}\"", e.Style.Format);
				sb.AppendFormat(", CellValue = \"{0}\"", e.Style.CellValue);
				sb.AppendFormat(", ImageSizeMode = \"{0}\"", e.Style.ImageSizeMode);
				
			}

			e.Style.CellTipText = sb.ToString();
		}

		private void TableControl_ResizingRows(object sender, GridResizingRowsEventArgs e)
		{
			e.Cancel=true;
		}
	}
}
