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
using System.Xml.Serialization;
using System.Runtime.Serialization;

using Syncfusion.Drawing;
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
        DataSet currentDataSet = null;
        private IContainer components;

        private TableRecordFieldStylesCollection tableRecordFieldStyles = new TableRecordFieldStylesCollection();

		[DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Content)]
		public TableRecordFieldStylesCollection TableRecordFieldStyles
		{
			get
			{
				return tableRecordFieldStyles;
			}
			set
			{
				tableRecordFieldStyles = value;
			}
		}


		static XmlSerializer tableRecordFieldStylesSerializer;
        private GridGroupingControl gridGroupingControl1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv5;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;

		static XmlSerializer TableRecordFieldStylesSerializer
		{
			get
			{
				if (tableRecordFieldStylesSerializer == null)
					tableRecordFieldStylesSerializer = new XmlSerializer(typeof(TableRecordFieldStylesCollection));
				return tableRecordFieldStylesSerializer;
			}
		}

        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            this.Icon = ico;	


			
			
			// look for 
            currentDataSet = this.dataSet11.Clone(); 
            String commandstring = "select * from Employees";

            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connString);
            try
            {
                da.Fill(currentDataSet, "Employees");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            this.gridGroupingControl1.DataSource = currentDataSet.Tables[0];
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
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

		
        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(21, 8);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(528, 381);
            this.gridGroupingControl1.TabIndex = 1;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdv5);
            this.panel1.Controls.Add(this.buttonAdv4);
            this.panel1.Controls.Add(this.buttonAdv3);
            this.panel1.Controls.Add(this.buttonAdv2);
            this.panel1.Controls.Add(this.buttonAdv1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(550, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 382);
            this.panel1.TabIndex = 2;
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.buttonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv5.ForeColor = System.Drawing.Color.White;
            this.buttonAdv5.Location = new System.Drawing.Point(26, 260);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv5.TabIndex = 4;
            this.buttonAdv5.Text = "Edit custom styles";
            this.buttonAdv5.UseVisualStyle = true;
            this.buttonAdv5.UseVisualStyleBackColor = true;
            this.buttonAdv5.Click += new System.EventHandler(this.buttonAdv5_Click);
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv4.ForeColor = System.Drawing.Color.White;
            this.buttonAdv4.Location = new System.Drawing.Point(26, 210);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv4.TabIndex = 3;
            this.buttonAdv4.Text = "Restore all from xml";
            this.buttonAdv4.UseVisualStyle = true;
            this.buttonAdv4.UseVisualStyleBackColor = true;
            this.buttonAdv4.Click += new System.EventHandler(this.buttonAdv4_Click);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv3.ForeColor = System.Drawing.Color.White;
            this.buttonAdv3.Location = new System.Drawing.Point(26, 160);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv3.TabIndex = 2;
            this.buttonAdv3.Text = "Clear all";
            this.buttonAdv3.UseVisualStyle = true;
            this.buttonAdv3.UseVisualStyleBackColor = true;
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.Location = new System.Drawing.Point(26, 110);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv2.TabIndex = 1;
            this.buttonAdv2.Text = "Save all to xml";
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.UseVisualStyleBackColor = true;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Location = new System.Drawing.Point(26, 60);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(151, 40);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Text = "Initialize with custom styles";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.UseVisualStyleBackColor = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(738, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridGroupingControl1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            this.panel1.ResumeLayout(false);
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

		private void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
		{
			switch (e.TableCellIdentity.TableCellType)
			{
				case GridTableCellType.RecordPreviewCell:
				{
					GridGroupingControl groupingControl = (GridGroupingControl) sender;
					GridTable table = groupingControl.Table;
					GridRecord record = (GridRecord) e.TableCellIdentity.DisplayElement.ParentRecord;
					e.Style.CellValue = record.GetValue("Notes").ToString();
					break;
				}

				case GridTableCellType.AlternateRecordFieldCell:
				case GridTableCellType.AddNewRecordFieldCell:
				case GridTableCellType.RecordFieldCell:
				{
					GridTable table = e.TableCellIdentity.Table;
					string tableName = table.TableDescriptor.Name;
					GridRecord record = (GridRecord) e.TableCellIdentity.DisplayElement.ParentRecord;
					object recordkey = record.PrimaryKeys[0];
					string fieldName = e.TableCellIdentity.Column.MappingName;

					GridStyleInfo style = GetCellStyle(tableName, recordkey, fieldName);
					if (style != null)
						e.Style.ModifyStyle(style, Syncfusion.Styles.StyleModifyType.Override);
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

		public GridStyleInfo GetCellStyle(string tableName, object primaryKey, string fieldName)
		{
			RecordFieldStylesCollection recordFieldStyles = TableRecordFieldStyles.GetRecordFieldStylesByTableName(tableName);
			if (recordFieldStyles != null)
			{
				FieldStyleCollection fieldStyles = recordFieldStyles.GetFieldStylesByRecordKey(primaryKey);
				if (fieldStyles != null)
				{
					return fieldStyles.GetStyleByFieldName(fieldName);
				}
			}
			return null;
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
		}

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Appearance.AnyCell.ImageSizeMode = GridImageSizeMode.CenterImage;
            this.gridGroupingControl1.IntelliMousePanning = true;

            GridTable employeeTable = this.gridGroupingControl1.Table;
            GridTableDescriptor employeeTableDescriptor = this.gridGroupingControl1.TableDescriptor;

            RecordFieldStylesCollection employee = TableRecordFieldStyles.GetObject(this.gridGroupingControl1.TableDescriptor.Name);

            employee.GetObject(2).GetObject("LastName").BackColor = ColorConvert.ColorFromString("#84A1C3");
            employee.GetObject(2).GetObject("LastName").Font.Bold = true;
            employee.GetObject(1).GetObject("City").BackColor = ColorConvert.ColorFromString("#FF9933"); ;
            employee.GetObject(1).GetObject("City").Font.Italic = true;
            employee.GetObject(1).GetObject("Address").Interior = new BrushInfo(PatternStyle.OutlinedDiamond, ColorConvert.ColorFromString("#84A1C3"), ColorConvert.ColorFromString("#2a437e"));
            employee.GetObject(1).GetObject("Address").TextColor = Color.White;
            employee.GetObject(1).GetObject("Address").Font.Bold = true;
            employee.GetObject(1).GetObject("Address").Font.Size += 2;

            // see also gridGroupingControl1_QueryCellStyleInfo handler, 
            //	case GridTableCellType.AlternateRecordFieldCell:
            //	case GridTableCellType.AddNewRecordFieldCell:
            //	case GridTableCellType.RecordFieldCell:
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter xw = new XmlTextWriter("TableRecordFieldStylesCollection.xml", System.Text.Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                TableRecordFieldStylesSerializer.Serialize(xw, TableRecordFieldStyles);
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                XmlTextWriter xw = new XmlTextWriter("DataSet.xml", System.Text.Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                DataTable dt = this.gridGroupingControl1.DataSource as DataTable;
                dt.DataSet.WriteXml(xw, XmlWriteMode.WriteSchema);
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                XmlTextWriter xw = new XmlTextWriter("LookAndFeel.xml", System.Text.Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                this.gridGroupingControl1.WriteXmlLookAndFeel(xw);
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                XmlTextWriter xw = new XmlTextWriter("EngineSchema.xml", System.Text.Encoding.UTF8);
                xw.Formatting = Formatting.Indented;
                this.gridGroupingControl1.WriteXmlSchema(xw);
                xw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Saved to " + System.IO.Directory.GetCurrentDirectory());
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            TableRecordFieldStyles.Clear();
            this.currentDataSet.Clear();
            this.gridGroupingControl1.Refresh();
        }

        private void buttonAdv4_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("TableRecordFieldStylesCollection.xml"))
            {
                MessageBox.Show("Xml file does not exist. Please save to xml before trying to restore.");
                return;
            }

            try
            {
                XmlTextReader xr = new XmlTextReader("TableRecordFieldStylesCollection.xml");
                TableRecordFieldStyles = (TableRecordFieldStylesCollection)TableRecordFieldStylesSerializer.Deserialize(xr);
                xr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            try
            {
                XmlTextReader xr = new XmlTextReader("DataSet.xml");
                currentDataSet = new DataSet();
                currentDataSet.ReadXml(xr, XmlReadMode.ReadSchema);
                this.gridGroupingControl1.DataSource = currentDataSet.Tables[0];
                xr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                XmlTextReader xr = new XmlTextReader("EngineSchema.xml");
                this.gridGroupingControl1.ApplyXmlSchema(xr);
                xr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                XmlTextReader xr = new XmlTextReader("LookAndFeel.xml");
                this.gridGroupingControl1.ApplyXmlLookAndFeel(xr);
                xr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            this.gridGroupingControl1.Refresh();

            MessageBox.Show("Loaded from " + System.IO.Directory.GetCurrentDirectory());
        }

        private void buttonAdv5_Click(object sender, EventArgs e)
        {
            System.ComponentModel.Design.CollectionEditor ce = new System.ComponentModel.Design.CollectionEditor(this.tableRecordFieldStyles.GetType());
            Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer esc = new Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(null);
            PropertyDescriptor pd = TypeDescriptor.GetProperties(this)["TableRecordFieldStyles"];
            Syncfusion.ComponentModel.TypeDescriptorContext tdc = new Syncfusion.ComponentModel.TypeDescriptorContext(this, pd);
            tdc.ServiceProvider = esc;

            ce.EditValue(tdc, esc, tableRecordFieldStyles);

            this.gridGroupingControl1.Refresh();
        }
	}
}
