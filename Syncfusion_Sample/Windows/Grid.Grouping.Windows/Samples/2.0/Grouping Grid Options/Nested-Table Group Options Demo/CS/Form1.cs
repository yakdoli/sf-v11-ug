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
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;

namespace NestedTableGroupOptions
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        #region Private Members
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl gridGroupingControl1;
		private NestedTableGroupOptions.DataSet1 dataSet11;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv ShowCaptionPlus;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showCaption;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv beforeDetails;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv captionText;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv afterDetails;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblProperty;
        private System.Windows.Forms.Label lblProp;
        private IContainer components;
        private ToolTip tipDesc;
        public readonly static string connString = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
#endregion

		public Form1()
        {
            #region Grid Settings
            //
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            this.Icon = ico;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI";
            String commandstring1 = "select * from Customers";
            String commandstring2 = "select * from Orders";

            SqlCeDataAdapter da1 = new SqlCeDataAdapter(commandstring1, connString);
            SqlCeDataAdapter da2 = new SqlCeDataAdapter(commandstring2, connString);
            try
            {
                da1.Fill(dataSet11, "Customers");
                da2.Fill(dataSet11, "Orders");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }
			
			oldStyle = this.gridGroupingControl1.NestedTableGroupOptions.CaptionText;
			this.gridGroupingControl1.Table.Records[2].IsExpanded = true;
			this.gridGroupingControl1.Table.Records[1].IsExpanded = true;
            this.SetStyle(ControlStyles.UserPaint, true);
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            #endregion
        }
        #region Icon and Data Files
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

        #endregion

        #region Form Settings
        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

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
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridGroupingControl1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.dataSet11 = new NestedTableGroupOptions.DataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblProp = new System.Windows.Forms.Label();
            this.lblProperty = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tipDesc = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afterDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCaption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCaptionPlus)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(507, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 285);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Add New Record Field";
            // 
            // afterDetails
            // 
            this.afterDetails.DrawFocusRectangle = false;
            this.afterDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afterDetails.Location = new System.Drawing.Point(32, 216);
            this.afterDetails.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.afterDetails.Name = "afterDetails";
            this.afterDetails.Size = new System.Drawing.Size(104, 24);
            this.afterDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.afterDetails.TabIndex = 14;
            this.afterDetails.Text = "After Details";
            this.afterDetails.ThemesEnabled = false;
            this.afterDetails.CheckStateChanged += new System.EventHandler(this.afterDetails_CheckedChanged);
            // 
            // beforeDetails
            // 
            this.beforeDetails.Checked = true;
            this.beforeDetails.CheckState = System.Windows.Forms.CheckState.Checked;
            this.beforeDetails.DrawFocusRectangle = false;
            this.beforeDetails.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beforeDetails.Location = new System.Drawing.Point(32, 184);
            this.beforeDetails.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.beforeDetails.Name = "beforeDetails";
            this.beforeDetails.Size = new System.Drawing.Size(104, 24);
            this.beforeDetails.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.beforeDetails.TabIndex = 13;
            this.beforeDetails.Text = "Before Details";
            this.beforeDetails.ThemesEnabled = false;
            this.beforeDetails.CheckStateChanged += new System.EventHandler(this.beforeDetails_CheckedChanged);
            // 
            // captionText
            // 
            this.captionText.DrawFocusRectangle = false;
            this.captionText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.captionText.Location = new System.Drawing.Point(40, 104);
            this.captionText.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.captionText.Name = "captionText";
            this.captionText.Size = new System.Drawing.Size(136, 32);
            this.captionText.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.captionText.TabIndex = 12;
            this.captionText.Text = "Modify Caption Text";
            this.captionText.ThemesEnabled = false;
            this.captionText.CheckStateChanged += new System.EventHandler(this.captionText_CheckedChanged);
            // 
            // showCaption
            // 
            this.showCaption.Checked = true;
            this.showCaption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showCaption.DrawFocusRectangle = false;
            this.showCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCaption.Location = new System.Drawing.Point(40, 72);
            this.showCaption.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.showCaption.Name = "showCaption";
            this.showCaption.Size = new System.Drawing.Size(136, 24);
            this.showCaption.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.showCaption.TabIndex = 11;
            this.showCaption.Text = "Show Caption";
            this.showCaption.ThemesEnabled = false;
            this.showCaption.CheckStateChanged += new System.EventHandler(this.showCaption_CheckedChanged);
            // 
            // ShowCaptionPlus
            // 
            this.ShowCaptionPlus.Checked = true;
            this.ShowCaptionPlus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowCaptionPlus.DrawFocusRectangle = false;
            this.ShowCaptionPlus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowCaptionPlus.Location = new System.Drawing.Point(40, 40);
            this.ShowCaptionPlus.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ShowCaptionPlus.Name = "ShowCaptionPlus";
            this.ShowCaptionPlus.Size = new System.Drawing.Size(136, 24);
            this.ShowCaptionPlus.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.ShowCaptionPlus.TabIndex = 10;
            this.ShowCaptionPlus.Text = "Show Caption +/-";
            this.ShowCaptionPlus.ThemesEnabled = false;
            this.ShowCaptionPlus.CheckStateChanged += new System.EventHandler(this.ShowCaptionPlus_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nested Table Group Options";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridGroupingControl1);
            this.panel2.Location = new System.Drawing.Point(10, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 284);
            this.panel2.TabIndex = 2;
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataSet11.Customers;
            this.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.Location = new System.Drawing.Point(0, 0);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(490, 284);
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
            this.gridGroupingControl1.Text = "gridGroupingControl1";
            this.gridGroupingControl1.VersionInfo = "4.201.0.37";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblProp);
            this.panel3.Controls.Add(this.lblProperty);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.ForeColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(10, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 128);
            this.panel3.TabIndex = 4;
            // 
            // lblProp
            // 
            this.lblProp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProp.Location = new System.Drawing.Point(236, 73);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(436, 40);
            this.lblProp.TabIndex = 3;
            // 
            // lblProperty
            // 
            this.lblProperty.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProperty.Location = new System.Drawing.Point(236, 16);
            this.lblProperty.Name = "lblProperty";
            this.lblProperty.Size = new System.Drawing.Size(436, 32);
            this.lblProperty.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Changed Property :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Changed NestedTableGroupOptions Property :";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(0, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(716, 435);
            this.panel4.TabIndex = 6;
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
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(718, 442);
            this.Controls.Add(this.panel4);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 505);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nested-Table Group Options Demo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.afterDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beforeDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.captionText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showCaption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowCaptionPlus)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGroupingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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

        #region EVent Handlers
        private void ShowCaptionPlus_CheckedChanged(object sender, System.EventArgs e)
		{
			this.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = !this.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus;
			this.lblProperty.Text="";
			this.lblProperty.Text="gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = "+this.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus;
			this.gridGroupingControl1.Refresh();
		}

		private void showCaption_CheckedChanged(object sender, System.EventArgs e)
		{
			this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = !this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption;
			this.lblProperty.Text="";
			this.lblProperty.Text="gridGroupingControl1.NestedTableGroupOptions.ShowCaption = "+this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption;
			this.gridGroupingControl1.Refresh();
		}

		string oldStyle = "";
		private void captionText_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblProperty.Text="";
			if(this.captionText.Checked)
			{
				this.gridGroupingControl1.NestedTableGroupOptions.CaptionText = "There are {RecordCount} items under {CategoryName} : {Category}";
				this.lblProperty.Text="gridGroupingControl1.NestedTableGroupOptions.CaptionText = \"There are {RecordCount} items under {CategoryName} : {Category}\"";
			}
			else if(!this.captionText.Checked)
			{
				this.gridGroupingControl1.NestedTableGroupOptions.CaptionText = oldStyle;
				this.lblProperty.Text="gridGroupingControl1.NestedTableGroupOptions.CaptionText = \""+oldStyle +"\"";
			}
		}

		private void beforeDetails_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblProp.Text="";
			this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = !this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails;
			this.lblProp.Text="gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = " +this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails;
		}

		private void afterDetails_CheckedChanged(object sender, System.EventArgs e)
		{
			this.lblProp.Text="";
			this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = !this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails;
			this.lblProp.Text="gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = "+ this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails;
        }

        #endregion

    }
}
