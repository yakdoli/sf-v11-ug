using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace ComboBoxBase
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label label2;
		private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase1;		
		private ComboBoxBase.DataSet1 dataSet11;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.ListBox listBox1;				
		private System.Windows.Forms.Panel groupBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase2;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textLog;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase4;
		private System.Windows.Forms.ListBox listBox3;
		private Syncfusion.Windows.Forms.Tools.ComboBoxBase comboBoxBase5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            this.Label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBase1 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataSet11 = new ComboBoxBase.DataSet1();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.comboBoxBase2 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxBase4 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.comboBoxBase5 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textLog = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase5)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Label1.ImageIndex = 0;
            this.Label1.ImageList = this.imageList1;
            this.Label1.Location = new System.Drawing.Point(136, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(440, 48);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "The ComboBoxBase can be bound to any ListBox derived class during design-time, \r\n" +
                "which will then appear in its drop-down during runtime.";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Category for Display";
            // 
            // comboBoxBase1
            // 
            this.comboBoxBase1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBoxBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase1.IgnoreThemeBackground = true;
            this.comboBoxBase1.ListControl = this.listBox1;
            this.comboBoxBase1.Location = new System.Drawing.Point(152, 26);
            this.comboBoxBase1.Name = "comboBoxBase1";
            this.comboBoxBase1.Size = new System.Drawing.Size(152, 21);
            this.comboBoxBase1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboBoxBase1.TabIndex = 9;
            this.comboBoxBase1.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBase1_SelectionChangeCommitted);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.listBox1.Items.AddRange(new object[] {
            ""});
            this.listBox1.Location = new System.Drawing.Point(120, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 12;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(110)))), ((int)(((byte)(152)))));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(198)))), ((int)(((byte)(220)))));
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(8, 56);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(110)))), ((int)(((byte)(152)))));
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(110)))), ((int)(((byte)(152)))));
            this.dataGrid1.Size = new System.Drawing.Size(368, 216);
            this.dataGrid1.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBox1.Controls.Add(this.comboBoxBase2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGrid1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.comboBoxBase1);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Location = new System.Drawing.Point(8, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 320);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.Text = "Bounded";
            // 
            // comboBoxBase2
            // 
            this.comboBoxBase2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBoxBase2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase2.IgnoreThemeBackground = true;
            this.comboBoxBase2.ListControl = this.listBox2;
            this.comboBoxBase2.Location = new System.Drawing.Point(152, 280);
            this.comboBoxBase2.Name = "comboBoxBase2";
            this.comboBoxBase2.Size = new System.Drawing.Size(152, 21);
            this.comboBoxBase2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboBoxBase2.TabIndex = 15;
            this.comboBoxBase2.Text = "True";
            this.comboBoxBase2.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBase2_SelectionChangeCommitted);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.listBox2.Items.AddRange(new object[] {
            "True",
            "False"});
            this.listBox2.Location = new System.Drawing.Point(152, 112);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Set Discontinue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bounded ListControls";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxBase4);
            this.panel1.Controls.Add(this.comboBoxBase5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textLog);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Location = new System.Drawing.Point(408, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 320);
            this.panel1.TabIndex = 14;
            // 
            // comboBoxBase4
            // 
            this.comboBoxBase4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBoxBase4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase4.IgnoreThemeBackground = true;
            this.comboBoxBase4.ListControl = this.listBox3;
            this.comboBoxBase4.Location = new System.Drawing.Point(8, 48);
            this.comboBoxBase4.Name = "comboBoxBase4";
            this.comboBoxBase4.Size = new System.Drawing.Size(160, 21);
            this.comboBoxBase4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboBoxBase4.TabIndex = 19;
            this.comboBoxBase4.Text = "Item1";
            this.comboBoxBase4.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBase_SelectionChangeCommitted);
            this.comboBoxBase4.DropDown += new System.EventHandler(this.comboBoxBase_DropDown);
            this.comboBoxBase4.TextChanged += new System.EventHandler(this.comboBoxBase_TextChanged);
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.listBox3.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3",
            "Item4",
            "Item5"});
            this.listBox3.Location = new System.Drawing.Point(192, 200);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(104, 69);
            this.listBox3.TabIndex = 23;
            // 
            // comboBoxBase5
            // 
            this.comboBoxBase5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBoxBase5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase5.IgnoreThemeBackground = true;
            this.comboBoxBase5.ListControl = this.checkedListBox1;
            this.comboBoxBase5.Location = new System.Drawing.Point(8, 96);
            this.comboBoxBase5.Name = "comboBoxBase5";
            this.comboBoxBase5.Size = new System.Drawing.Size(160, 21);
            this.comboBoxBase5.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboBoxBase5.TabIndex = 20;
            this.comboBoxBase5.Text = "Item1";
            this.comboBoxBase5.SelectionChangeCommitted += new System.EventHandler(this.comboBoxBase_SelectionChangeCommitted);
            this.comboBoxBase5.DropDown += new System.EventHandler(this.comboBoxBase_DropDown);
            this.comboBoxBase5.TextChanged += new System.EventHandler(this.comboBoxBase_TextChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.checkedListBox1.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3",
            "Item4",
            "Item5",
            "Item6"});
            this.checkedListBox1.Location = new System.Drawing.Point(223, 172);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(104, 68);
            this.checkedListBox1.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Combo With CheckedListBox:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Combo With ListBox:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(8, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Events Log";
            // 
            // textLog
            // 
            this.textLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textLog.Location = new System.Drawing.Point(0, 166);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(334, 152);
            this.textLog.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(16, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "ComboBoxBase with different Controls in DropDown";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(752, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ComboBox Base";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase5)).EndInit();
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

        private void Form1_Load(object sender, System.EventArgs e)
        {


            this.listBox1.DataSource = this.dataSet11.Categories;

            this.listBox1.DisplayMember = "CategoryName";

            string DEF_DB_COMMAND2 = "SELECT DISTINCT CategoryName FROM Categories";

            string connectionstring = (@"..\..\..\..\..\..\..\..\..\Common\Data\NorthwindIO.sdf");

            string SqlMobileConnString1 = @"Data Source = " + connectionstring;

            SqlCeConnection conn = new SqlCeConnection(SqlMobileConnString1);

            conn.Open();

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(DEF_DB_COMMAND2, conn);

            adapter.Fill(this.dataSet11.Categories);

            this.dataGrid1.DataSource = this.dataSet11.Products;

            this.comboBoxBase2.DataBindings.Add("Text", this.dataSet11.Products, "Discontinued");
            this.comboBoxBase2.Enabled = false;

        }

        private void FilterProductsList(DataTable productListTable, string category)
        {

            string DEF_DB_COMMAND2 = "SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Products.Discontinued FROM (Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID) WHERE Categories.CategoryName='" + category + "'";

            string connectionstring = (@"..\..\..\..\..\..\..\..\..\Common\Data\NorthwindIO.sdf");

            string SqlMobileConnString1 = @"Data Source = " + connectionstring;

            SqlCeConnection conn = new SqlCeConnection(SqlMobileConnString1);

            conn.Open();

            SqlCeDataAdapter adapter = new SqlCeDataAdapter(DEF_DB_COMMAND2, conn);

            adapter.Fill(productListTable);

        }

        private void comboBoxBase1_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            this.dataSet11.Products.Clear();
            FilterProductsList(this.dataSet11.Products, this.comboBoxBase1.Text);
            this.comboBoxBase2.Enabled = true;
            AddLog("Displaying " + this.comboBoxBase1.Text + " Category");
        }


        private void AddLog(string text)
        {
            this.textLog.Text += text + "\r\n";
        }

        private void comboBoxBase2_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)this.BindingContext[this.dataGrid1.DataSource];
            DataRow dr = this.dataSet11.Products.Rows[cm.Position];
            if (dr != null && dr["Discontinued"].ToString() != this.comboBoxBase2.Text)
            {
                AddLog("Setting Discontinuation " + this.comboBoxBase2.Text + " to the Product -> " + dr["ProductName"].ToString());
            }
        }

        private void comboBoxBase_DropDown(object sender, System.EventArgs e)
        {
            AddLog("Event: DropDown");
        }

        private void comboBoxBase_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            AddLog("Event: SelectionChangeCommitted");
        }

        private void comboBoxBase_TextChanged(object sender, System.EventArgs e)
        {
            AddLog("Event: TextChanged");
        }


    }

}
