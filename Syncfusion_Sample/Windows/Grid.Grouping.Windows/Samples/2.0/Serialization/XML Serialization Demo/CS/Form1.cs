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
using System.Xml;
using System.Xml.Serialization;
using System.IO;

using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;

namespace XMLSerialization
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        protected DataSet1 dataSet11;
        private Syncfusion.Windows.Forms.ButtonAdv reset;
        private Syncfusion.Windows.Forms.ButtonAdv btnLoadXmlSchema;
        private Syncfusion.Windows.Forms.ButtonAdv btnSaveXmlSchema;
        protected GridGroupingControl gridGroupingControl1;
        private PropertyGrid propertyGrid1;
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			bool msdeAvailable = false;
			if (msdeAvailable)
			{
				this.sqlDataAdapter1.Fill(this.dataSet11);
				this.dataSet11.WriteXml("NWCategories.xml", XmlWriteMode.WriteSchema);
			}
			else
				// Read from a xml file instead. 
				ReadXml(this.dataSet11, "NWCategories.xml");


			// Knowing the initail state
			stream = new System.IO.MemoryStream();
			this.gridGroupingControl1.WriteXmlSchema(new XmlTextWriter(stream, null));
            this.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.gridGroupingControl1.FilterRuntimeProperties = true;
            this.gridGroupingControl1.TableDescriptor.Appearance.AddNewRecordFieldCell.BackColor = Color.Orange;
            this.gridGroupingControl1.TableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.Orange;
            //this.BackColor = Color.FromArgb(223, 227, 239);
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
		}
		System.IO.MemoryStream stream;

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

		
		void ReadXml(DataSet ds, string xmlFileName)
		{
            xmlFileName = @"Common\data\grid\" + xmlFileName;
			for (int n = 0; n < 10; n++)
			{
				if (System.IO.File.Exists(xmlFileName))
				{
					ds.ReadXml(xmlFileName);
					break;
				}
				xmlFileName = @"..\" + xmlFileName;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gridColumnDescriptor2 = new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor();
            this.dataSet11 = new DataSet1();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.reset = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnLoadXmlSchema = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnSaveXmlSchema = new Syncfusion.Windows.Forms.ButtonAdv();
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
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "data source=(local)\\NETSDK;initial catalog=Northwind;integrated security=SSPI;per" +
                "sist security info=True;workstation id=localhost;packet size=4096";
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO Categories(CategoryName, Description, Picture) VALUES (@CategoryName," +
                " @Description, @Picture); SELECT CategoryID, CategoryName, Description, Picture " +
                "FROM Categories WHERE (CategoryID = @@IDENTITY)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"));
            this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture"));
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = @"UPDATE Categories SET CategoryName = @CategoryName, Description = @Description, Picture = @Picture WHERE (CategoryID = @Original_CategoryID) AND (CategoryName = @Original_CategoryName); SELECT CategoryID, CategoryName, Description, Picture FROM Categories WHERE (CategoryID = @CategoryID)";
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture"));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null));
            this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"));
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = @Original_CategoryID) AND (CategoryNam" +
                "e = @Original_CategoryName)";
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryID", System.Data.DataRowVersion.Original, null));
            this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "CategoryName", System.Data.DataRowVersion.Original, null));
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"),
																																																					new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
																																																					new System.Data.Common.DataColumnMapping("Description", "Description"),
																																																					new System.Data.Common.DataColumnMapping("Picture", "Picture")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.reset.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.reset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(340, 426);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(130, 28);
            this.reset.TabIndex = 12;
            this.reset.Text = "Reset Schema";
            this.reset.UseVisualStyle = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // btnLoadXmlSchema
            // 
            this.btnLoadXmlSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadXmlSchema.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnLoadXmlSchema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.btnLoadXmlSchema.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnLoadXmlSchema.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadXmlSchema.ForeColor = System.Drawing.Color.White;
            this.btnLoadXmlSchema.Location = new System.Drawing.Point(199, 426);
            this.btnLoadXmlSchema.Name = "btnLoadXmlSchema";
            this.btnLoadXmlSchema.Size = new System.Drawing.Size(130, 28);
            this.btnLoadXmlSchema.TabIndex = 11;
            this.btnLoadXmlSchema.Text = "Load Xml Schema";
            this.btnLoadXmlSchema.UseVisualStyle = true;
            this.btnLoadXmlSchema.Click += new System.EventHandler(this.btnLoadXmlSchema_Click);
            // 
            // btnSaveXmlSchema
            // 
            this.btnSaveXmlSchema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveXmlSchema.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnSaveXmlSchema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.btnSaveXmlSchema.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.btnSaveXmlSchema.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveXmlSchema.ForeColor = System.Drawing.Color.White;
            this.btnSaveXmlSchema.Location = new System.Drawing.Point(60, 426);
            this.btnSaveXmlSchema.Name = "btnSaveXmlSchema";
            this.btnSaveXmlSchema.Size = new System.Drawing.Size(130, 28);
            this.btnSaveXmlSchema.TabIndex = 10;
            this.btnSaveXmlSchema.Text = "Save Xml Schema";
            this.btnSaveXmlSchema.UseVisualStyle = true;
            this.btnSaveXmlSchema.Click += new System.EventHandler(this.btnSaveXmlSchema_Click);
            // 
            // gridGroupingControl1
            // 
            this.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window;
            this.gridGroupingControl1.DataSource = this.dataSet11.Categories;
            this.gridGroupingControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridGroupingControl1.Location = new System.Drawing.Point(15, 16);
            this.gridGroupingControl1.Name = "gridGroupingControl1";
            this.gridGroupingControl1.Size = new System.Drawing.Size(504, 400);
            this.gridGroupingControl1.TabIndex = 9;
            gridColumnDescriptor1.MappingName = "CategoryID";
            gridColumnDescriptor1.Width = 80;
            gridColumnDescriptor2.MappingName = "Description";
            gridColumnDescriptor2.Width = 250;
            this.gridGroupingControl1.TableDescriptor.Columns.AddRange(new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor[] {
            gridColumnDescriptor1,
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("CategoryName"),
            gridColumnDescriptor2,
            new Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Picture")});
            this.gridGroupingControl1.TableOptions.RecordRowHeight = 57;
            this.gridGroupingControl1.Text = "gridGroupingControl1";
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
            this.propertyGrid1.Location = new System.Drawing.Point(533, 16);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(309, 400);
            this.propertyGrid1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 15);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(858, 464);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.btnLoadXmlSchema);
            this.Controls.Add(this.btnSaveXmlSchema);
            this.Controls.Add(this.gridGroupingControl1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "XML Serialization Demo";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
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

			Application.Run(new Form1());
		}

		private void btnSaveXmlSchema_Click(object sender, System.EventArgs e)
		{
                XmlTextWriter xw = new XmlTextWriter("GridSchema.xml", System.Text.Encoding.UTF8);
                XmlTextWriter xwApp = new XmlTextWriter("GridLooknFeel.xml", System.Text.Encoding.UTF8);
				xw.Formatting = System.Xml.Formatting.Indented;
				this.gridGroupingControl1.WriteXmlSchema(xw);
                this.gridGroupingControl1.WriteXmlLookAndFeel(xwApp);
				xw.Close();
                xwApp.Close();
		}

		private void btnLoadXmlSchema_Click(object sender, System.EventArgs e)
		{
            if (File.Exists("GridSchema.xml") && File.Exists("GridLooknFeel.xml"))
            {
                XmlReader xr = new XmlTextReader("GridSchema.xml");
                XmlReader xrApp = new XmlTextReader("GridLooknFeel.xml");
                this.gridGroupingControl1.ApplyXmlSchema(xr);
                this.gridGroupingControl1.ApplyXmlLookAndFeel(xrApp);
                xr.Close();
                xrApp.Close();
            }
            else
                MessageBox.Show("Click \"Save Xml Schema\" button to serialize the grid.");
		}

		private void reset_Click(object sender, System.EventArgs e)
		{
			System.IO.MemoryStream stream2 = new System.IO.MemoryStream(stream.ToArray());
			this.gridGroupingControl1.ApplyXmlSchema(new XmlTextReader(stream2));
		}
	}
}
