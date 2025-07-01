#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;

namespace ChildGroupOptions
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
        private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private ChildGroupOptions.DataSet1 dataSet11;
		private System.Windows.Forms.Label label2;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv afterDetails;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv beforeDetails;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv captionText;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showCaption;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv ShowCaptionPlus;
		private System.Windows.Forms.Label lblPropertyDisplay;
		private System.Windows.Forms.Label lblProperty;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private IContainer components;
        private Panel panel5;
        private ToolTip tipDesc;
        private const string connection = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
        #endregion

        public Form1()
        {
            #region GridSettings
            //
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            this.Icon = ico ;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;           
			// 
			// oleDbConnection1
			// 
            string mdbFileName = FindDatabase(@"Common\Data\ACC.mdb");
            this.oleDbConnection1.ConnectionString = String.Format(Form1.connection, mdbFileName);
			this.oleDbDataAdapter1.Fill(this.dataSet11);

			// These columns are programatically grouped to demonstrate the ChildGroupOptions.. 
			this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("Sport");
			this.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("wins",ListSortDirection.Descending);
			// Expand some nodes..
			this.gridGroupingControl1.Table.TopLevelGroup.Groups[1].IsExpanded = true;
			this.gridGroupingControl1.Table.TopLevelGroup.Groups[1].Groups[1].IsExpanded = true;
			this.gridGroupingControl1.Table.TopLevelGroup.Groups[1].Groups[3].IsExpanded = true;

			oldStyle = this.gridGroupingControl1.ChildGroupOptions.CaptionText;

            this.SetStyle(ControlStyles.UserPaint, true);
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
			this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            #endregion
        }
        #region Icon and Data files
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

		
        string FindDatabase(string mdbFileName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(mdbFileName))
                {
                    return mdbFileName;
                }
                mdbFileName = @"..\" + mdbFileName;
            }
            return "";
        }
        #endregion

        #region Form Handlers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.afterDetails = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.beforeDetails = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.captionText = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.showCaption = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.ShowCaptionPlus = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.lblPropertyDisplay = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataSet11 = new ChildGroupOptions.DataSet1();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tipDesc = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCaptionPlus)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.afterDetails);
            this.panel1.Controls.Add(this.beforeDetails);
            this.panel1.Controls.Add(this.captionText);
            this.panel1.Controls.Add(this.showCaption);
            this.panel1.Controls.Add(this.ShowCaptionPlus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(608, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 386);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Add New Record Field";
            // 
            // afterDetails
            // 
            this.afterDetails.DrawFocusRectangle = false;
            this.afterDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterDetails.Location = new System.Drawing.Point(16, 232);
            this.afterDetails.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.afterDetails.Name = "afterDetails";
            this.afterDetails.Size = new System.Drawing.Size(136, 24);
            this.afterDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.afterDetails.TabIndex = 20;
            this.afterDetails.Text = "After Details";
            this.afterDetails.ThemesEnabled = false;
            this.afterDetails.CheckStateChanged += new System.EventHandler(this.afterDetails_CheckStateChanged);
            // 
            // beforeDetails
            // 
            this.beforeDetails.Checked = true;
            this.beforeDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.beforeDetails.DrawFocusRectangle = false;
            this.beforeDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beforeDetails.Location = new System.Drawing.Point(16, 200);
            this.beforeDetails.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.beforeDetails.Name = "beforeDetails";
            this.beforeDetails.Size = new System.Drawing.Size(136, 24);
            this.beforeDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.beforeDetails.TabIndex = 19;
            this.beforeDetails.Text = "Before Details";
            this.beforeDetails.ThemesEnabled = false;
            this.beforeDetails.CheckStateChanged += new System.EventHandler(this.beforeDetails_CheckStateChanged);
            // 
            // captionText
            // 
            this.captionText.DrawFocusRectangle = false;
            this.captionText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionText.Location = new System.Drawing.Point(16, 119);
            this.captionText.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.captionText.Name = "captionText";
            this.captionText.Size = new System.Drawing.Size(146, 24);
            this.captionText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.captionText.TabIndex = 18;
            this.captionText.Text = "Modify Caption Text";
            this.captionText.ThemesEnabled = false;
            this.captionText.CheckStateChanged += new System.EventHandler(this.captionText_CheckStateChanged);
            // 
            // showCaption
            // 
            this.showCaption.Checked = true;
            this.showCaption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCaption.DrawFocusRectangle = false;
            this.showCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCaption.Location = new System.Drawing.Point(16, 87);
            this.showCaption.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.showCaption.Name = "showCaption";
            this.showCaption.Size = new System.Drawing.Size(146, 24);
            this.showCaption.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.showCaption.TabIndex = 17;
            this.showCaption.Text = "Show Caption";
            this.showCaption.ThemesEnabled = false;
            this.showCaption.CheckStateChanged += new System.EventHandler(this.showCaption_CheckStateChanged);
            // 
            // ShowCaptionPlus
            // 
            this.ShowCaptionPlus.Checked = true;
            this.ShowCaptionPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowCaptionPlus.DrawFocusRectangle = false;
            this.ShowCaptionPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCaptionPlus.Location = new System.Drawing.Point(16, 57);
            this.ShowCaptionPlus.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ShowCaptionPlus.Name = "ShowCaptionPlus";
            this.ShowCaptionPlus.Size = new System.Drawing.Size(136, 24);
            this.ShowCaptionPlus.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.ShowCaptionPlus.TabIndex = 16;
            this.ShowCaptionPlus.Text = "Show Caption +/-";
            this.ShowCaptionPlus.ThemesEnabled = false;
            this.ShowCaptionPlus.CheckStateChanged += new System.EventHandler(this.ShowCaptionPlus_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Child Group Options";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblProperty);
            this.panel3.Controls.Add(this.lblPropertyDisplay);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(9, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 118);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Changed Property :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Changed ChildGroup Options Property :";
            // 
            // lblProperty
            // 
            this.lblProperty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperty.Location = new System.Drawing.Point(218, 72);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(566, 40);
            this.lblProperty.TabIndex = 1;
            // 
            // lblPropertyDisplay
            // 
            this.lblPropertyDisplay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropertyDisplay.Location = new System.Drawing.Point(218, 16);
            this.lblPropertyDisplay.Name = "lblPropertyDisplay";
            this.lblPropertyDisplay.Size = new System.Drawing.Size(569, 40);
            this.lblPropertyDisplay.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gridGroupingControl1);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(3, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(791, 517);
            this.panel4.TabIndex = 6;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataSet11.Statistics;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.ForeColor = System.Drawing.Color.DimGray;
            this.gridGroupingControl1.Location = new System.Drawing.Point(6, 4);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.Size = new System.Drawing.Size(593, 386);
            this.gridGroupingControl1.TabIndex = 0;
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("losses"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("School"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Sport"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ties"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("wins"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("year")});
            this.gridGroupingControl1.TableDescriptor.PrimaryKeyColumns.AddRange(new Syncfusion.Grouping.SortColumnDescriptor[] {
            new Syncfusion.Grouping.SortColumnDescriptor("ID", System.ComponentModel.ListSortDirection.Ascending)});
            this.gridGroupingControl1.TableDescriptor.VisibleColumns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor[] {
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ID"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("losses"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("School"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("Sport"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("ties"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("wins"),
            new Syncfusion.Windows.Forms.Grid.Grouping.GridVisibleColumnDescriptor("year")});
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.201.0.37";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Statistics", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("losses", "losses"),
                        new System.Data.Common.DataColumnMapping("School", "School"),
                        new System.Data.Common.DataColumnMapping("Sport", "Sport"),
                        new System.Data.Common.DataColumnMapping("ties", "ties"),
                        new System.Data.Common.DataColumnMapping("wins", "wins"),
                        new System.Data.Common.DataColumnMapping("year", "year")})});
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // oleDbDeleteCommand1
            // 
            this.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText");
            this.oleDbDeleteCommand1.Connection = this.oleDbConnection1;
            this.oleDbDeleteCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "School", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "School", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "losses", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "losses", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ties", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ties", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wins", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wins", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "year", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "year", System.Data.DataRowVersion.Original, null)});
            // 
            // oleDbConnection1
            // 
            this.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString");
            // 
            // oleDbInsertCommand1
            // 
            this.oleDbInsertCommand1.CommandText = "INSERT INTO Statistics(losses, School, Sport, ties, wins, year) VALUES (?, ?, ?, " +
    "?, ?, ?)";
            this.oleDbInsertCommand1.Connection = this.oleDbConnection1;
            this.oleDbInsertCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.Integer, 0, "losses"),
            new System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"),
            new System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"),
            new System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.Integer, 0, "ties"),
            new System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.Integer, 0, "wins"),
            new System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.Integer, 0, "year")});
            // 
            // oleDbSelectCommand1
            // 
            this.oleDbSelectCommand1.CommandText = "SELECT ID, losses, School, Sport, ties, wins, year FROM Statistics";
            this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
            // 
            // oleDbUpdateCommand1
            // 
            this.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText");
            this.oleDbUpdateCommand1.Connection = this.oleDbConnection1;
            this.oleDbUpdateCommand1.Parameters.AddRange(new System.Data.OleDb.OleDbParameter[] {
            new System.Data.OleDb.OleDbParameter("losses", System.Data.OleDb.OleDbType.Integer, 0, "losses"),
            new System.Data.OleDb.OleDbParameter("School", System.Data.OleDb.OleDbType.VarWChar, 255, "School"),
            new System.Data.OleDb.OleDbParameter("Sport", System.Data.OleDb.OleDbType.VarWChar, 255, "Sport"),
            new System.Data.OleDb.OleDbParameter("ties", System.Data.OleDb.OleDbType.Integer, 0, "ties"),
            new System.Data.OleDb.OleDbParameter("wins", System.Data.OleDb.OleDbType.Integer, 0, "wins"),
            new System.Data.OleDb.OleDbParameter("year", System.Data.OleDb.OleDbType.Integer, 0, "year"),
            new System.Data.OleDb.OleDbParameter("Original_ID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_School", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "School", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_School1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "School", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sport", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_Sport1", System.Data.OleDb.OleDbType.VarWChar, 255, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Sport", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_losses", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "losses", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_losses1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "losses", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ties", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ties", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_ties1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ties", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_wins", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wins", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_wins1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "wins", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_year", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "year", System.Data.DataRowVersion.Original, null),
            new System.Data.OleDb.OleDbParameter("Original_year1", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "year", System.Data.DataRowVersion.Original, null)});
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Location = new System.Drawing.Point(-1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(841, 524);
            this.panel5.TabIndex = 7;
            // 
            // tipDesc
            // 
            this.tipDesc.BackColor = System.Drawing.Color.White;
            this.tipDesc.ForeColor = System.Drawing.Color.Black;
            this.tipDesc.IsBalloon = true;
            this.tipDesc.ShowAlways = true;
            this.tipDesc.UseFading = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.panel5);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 606);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Child-Group Options Demo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.afterDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCaptionPlus)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel5.ResumeLayout(false);
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
        #endregion

        #region Event Handlers
        private void ShowCaptionPlus_CheckStateChanged(object sender, EventArgs e)
        {
            this.gridGroupingControl1.ChildGroupOptions.ShowCaptionPlusMinus = !this.gridGroupingControl1.ChildGroupOptions.ShowCaptionPlusMinus;
            this.lblPropertyDisplay.Text = "";
            this.lblPropertyDisplay.Text = "gridGroupingControl1.ChildGroupOptions.ShowCaptionPlusMinus = " + this.gridGroupingControl1.ChildGroupOptions.ShowCaptionPlusMinus;
            this.gridGroupingControl1.Refresh();
        }

        private void showCaption_CheckStateChanged(object sender, EventArgs e)
        {
            this.gridGroupingControl1.ChildGroupOptions.ShowCaption = !this.gridGroupingControl1.ChildGroupOptions.ShowCaption;
            this.lblPropertyDisplay.Text = "";
            this.lblPropertyDisplay.Text = "gridGroupingControl1.ChildGroupOptions.ShowCaption = " + this.gridGroupingControl1.ChildGroupOptions.ShowCaption;
            this.gridGroupingControl1.Refresh();
        }
        string oldStyle = "";
        private void captionText_CheckStateChanged(object sender, EventArgs e)
        {
            this.lblPropertyDisplay.Text = "";
            if (this.captionText.Checked)
            {
                this.gridGroupingControl1.ChildGroupOptions.CaptionText = "There are {RecordCount} items under {CategoryName} : {Category}";
                this.lblPropertyDisplay.Text = "gridGroupingControl1.ChildGroupOptions.CaptionText = \"There are {RecordCount} items under {CategoryName} : {Category}\"";
            }
            else if (!this.captionText.Checked)
            {
                this.gridGroupingControl1.ChildGroupOptions.CaptionText = oldStyle;
                this.lblPropertyDisplay.Text = "gridGroupingControl1.ChildGroupOptions.CaptionText = \"" + oldStyle + "\"";
            }
        }

        private void beforeDetails_CheckStateChanged(object sender, EventArgs e)
        {
            this.lblProperty.Text = "";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = !this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = !this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails;
            this.lblProperty.Text = "gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = " + this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails;
        }

        private void afterDetails_CheckStateChanged(object sender, EventArgs e)
        {
            this.lblProperty.Text = "";
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = !this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails;
            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = !this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails;
            this.lblProperty.Text = "gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = " + this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails;
        }
        #endregion

    }
}
