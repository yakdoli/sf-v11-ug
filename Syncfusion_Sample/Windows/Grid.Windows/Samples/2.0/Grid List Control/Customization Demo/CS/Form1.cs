using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace CustomizedListControl
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		#region Members
        private GridListControl.Dataset1 dataset11;
		private Syncfusion.Windows.Forms.Grid.GridListControl gridListControl1;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv2;
        private System.Windows.Forms.Button button1;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton3;
        private TrackBarEx trackBar4;
        private TrackBarEx trackBar5;
        private TrackBarEx trackBar6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv5;
		private System.Windows.Forms.FontDialog fontDialog1;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv4;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv3;
		private System.ComponentModel.IContainer components=null;
        private GroupBox groupBox2;
        private const string connection = @"Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False";
# endregion

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
            InitializeComponent(); 
            String commandstring = "select * from Products";
            String connection = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring,connection);
            try
            {
                da.Fill(dataset11, "Products");
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }

            
		}

        #region Form Handlers
        private string FindFile(string connstring)
        {
            connstring = @"common\data\" + connstring;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(connstring))
                    return new FileInfo(connstring).FullName;
                connstring = @"..\" + connstring;
            }

            return connstring;
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

        private string FindImageFile(string bitmapName)
        {
            string bitmappath = "";
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    bitmappath = bitmapName;

                bitmapName = @"..\" + bitmapName;
            }
            return bitmappath;
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.dataset11 = new GridListControl.Dataset1();
            this.gridListControl1 = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.button1 = new System.Windows.Forms.Button();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.trackBar4 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 255);
            this.trackBar5 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 255);
            this.trackBar6 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 255);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.checkBoxAdv5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.checkBoxAdv4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataset11
            // 
            this.dataset11.DataSetName = "Dataset1";
            this.dataset11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridListControl1
            // 
            this.gridListControl1.BackColor = System.Drawing.SystemColors.Control;
            this.gridListControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridListControl1.DataSource = this.dataset11;
            this.gridListControl1.DisplayMember = "Products.ProductID";
            this.gridListControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridListControl1.ItemHeight = 17;
            this.gridListControl1.Location = new System.Drawing.Point(12, 21);
            this.gridListControl1.MultiColumn = true;
            this.gridListControl1.Name = "gridListControl1";
            this.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridListControl1.Properties.DisplayHorzLines = false;
            this.gridListControl1.Properties.DisplayVertLines = false;
            this.gridListControl1.Properties.MarkColHeader = false;
            this.gridListControl1.Properties.MarkRowHeader = false;
            this.gridListControl1.SelectedIndex = -1;
            this.gridListControl1.Size = new System.Drawing.Size(779, 524);
            this.gridListControl1.TabIndex = 0;
            this.gridListControl1.ThemesEnabled = true;
            this.gridListControl1.TopIndex = 0;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(99, 172);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(163, 23);
            this.checkBoxAdv1.StretchImage = false;
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 5;
            this.checkBoxAdv1.Text = "Transparent Background";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv2.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv2.DrawFocusRectangle = false;
            this.checkBoxAdv2.Enabled = false;
            this.checkBoxAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv2.Location = new System.Drawing.Point(180, 135);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(152, 22);
            this.checkBoxAdv2.StretchImage = false;
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 6;
            this.checkBoxAdv2.Text = "Remove BackgroundImage";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Browse BackgroundImage";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.White;
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.Location = new System.Drawing.Point(22, 232);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.Size = new System.Drawing.Size(152, 24);
            this.colorPickerButton2.TabIndex = 9;
            this.colorPickerButton2.Text = "HeaderBackColor";
            this.colorPickerButton2.UseVisualStyleBackColor = false;
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.BackColor = System.Drawing.Color.White;
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.Location = new System.Drawing.Point(180, 232);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.SelectedAsBackcolor = true;
            this.colorPickerButton3.Size = new System.Drawing.Size(152, 24);
            this.colorPickerButton3.TabIndex = 10;
            this.colorPickerButton3.Text = "HeaderTextColor";
            this.colorPickerButton3.UseVisualStyleBackColor = false;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(71, 27);
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(215, 20);
            this.trackBar4.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBar4.TabIndex = 11;
            this.trackBar4.TimerInterval = 100;
            this.trackBar4.Value = 255;
            this.trackBar4.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(71, 75);
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(215, 20);
            this.trackBar5.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBar5.TabIndex = 0;
            this.trackBar5.TimerInterval = 100;
            this.trackBar5.Value = 255;
            this.trackBar5.Scroll += new System.EventHandler(this.trackBar2_Scroll);
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(73, 117);
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(215, 20);
            this.trackBar6.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Metro;
            this.trackBar6.TabIndex = 0;
            this.trackBar6.TimerInterval = 100;
            this.trackBar6.Value = 255;
            this.trackBar6.Scroll += new System.EventHandler(this.trackBar3_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar4);
            this.groupBox1.Controls.Add(this.trackBar5);
            this.groupBox1.Controls.Add(this.trackBar6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 176);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BackColor";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Blue";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Green";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Red";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.White;
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.Location = new System.Drawing.Point(99, 267);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.Size = new System.Drawing.Size(163, 24);
            this.colorPickerButton1.TabIndex = 15;
			this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.Text = "GridLineColor";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            // 
            // checkBoxAdv5
            // 
            this.checkBoxAdv5.BackColor = System.Drawing.Color.White;
            this.checkBoxAdv5.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv5.Checked = true;
            this.checkBoxAdv5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv5.DrawFocusRectangle = false;
            this.checkBoxAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv5.Location = new System.Drawing.Point(97, 79);
            this.checkBoxAdv5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv5.Name = "checkBoxAdv5";
            this.checkBoxAdv5.Size = new System.Drawing.Size(163, 21);
            this.checkBoxAdv5.StretchImage = false;
            this.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv5.TabIndex = 18;
            this.checkBoxAdv5.Text = "Buttons3D";
            this.checkBoxAdv5.ThemesEnabled = false;
            this.checkBoxAdv5.CheckStateChanged += new System.EventHandler(this.checkBoxAdv5_CheckStateChanged);
            // 
            // checkBoxAdv4
            // 
            this.checkBoxAdv4.BackColor = System.Drawing.Color.White;
            this.checkBoxAdv4.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv4.DrawFocusRectangle = false;
            this.checkBoxAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv4.Location = new System.Drawing.Point(180, 44);
            this.checkBoxAdv4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv4.Name = "checkBoxAdv4";
            this.checkBoxAdv4.Size = new System.Drawing.Size(152, 22);
            this.checkBoxAdv4.StretchImage = false;
            this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv4.TabIndex = 17;
            this.checkBoxAdv4.Text = "Vertical Lines";
            this.checkBoxAdv4.ThemesEnabled = false;
            this.checkBoxAdv4.CheckStateChanged += new System.EventHandler(this.checkBoxAdv4_CheckStateChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv3.BorderColor = System.Drawing.Color.DimGray;
            this.checkBoxAdv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkBoxAdv3.DrawFocusRectangle = false;
            this.checkBoxAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv3.Location = new System.Drawing.Point(22, 44);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(152, 22);
            this.checkBoxAdv3.StretchImage = false;
            this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv3.TabIndex = 16;
            this.checkBoxAdv3.Text = "Horizontal Lines";
            this.checkBoxAdv3.ThemesEnabled = false;
            this.checkBoxAdv3.CheckStateChanged += new System.EventHandler(this.checkBoxAdv3_CheckStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.checkBoxAdv5);
            this.groupBox2.Controls.Add(this.checkBoxAdv4);
            this.groupBox2.Controls.Add(this.checkBoxAdv3);
            this.groupBox2.Controls.Add(this.checkBoxAdv2);
            this.groupBox2.Controls.Add(this.checkBoxAdv1);
            this.groupBox2.Controls.Add(this.colorPickerButton1);
            this.groupBox2.Controls.Add(this.colorPickerButton3);
            this.groupBox2.Controls.Add(this.colorPickerButton2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(802, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 531);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customizing Options...";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1150, 557);
            this.Controls.Add(this.gridListControl1);
            this.Controls.Add(this.groupBox2);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customization Demo";
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
			this.BorderThickness = 2;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataset11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        #region Entry Point
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
        }
        #endregion

        #region EventHandlers
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.gridListControl1.ThemesEnabled = true;
            this.gridListControl1.HeaderBackColor = Color.FromArgb(0, 21, 84);
            this.gridListControl1.HeaderTextColor = Color.MidnightBlue;
            this.gridListControl1.BackColor = Color.White;
            this.colorPickerButton1.ColorSelected += new EventHandler(colorPickerButton1_ColorSelected);
            this.colorPickerButton2.ColorSelected += new EventHandler(colorPickerButton2_ColorSelected);
            this.colorPickerButton3.ColorSelected += new EventHandler(colorPickerButton3_ColorSelected);
            
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, System.EventArgs e)
		{
            if (this.checkBoxAdv1.Checked)
            {
                this.checkBoxAdv2.Enabled = true;

                //Make the grid background transparent
                this.gridListControl1.TransparentBackground = true;
                if (!checkBoxAdv2.Checked)
                {
                    //Add background image
                    if (imageFileName == null)
                    {
                        imageFileName = FindImageFile(@"..\..\abstract.jpg");
                        this.gridListControl1.BackgroundImage = Image.FromFile(imageFileName);
                    }
                    else
                        this.gridListControl1.BackgroundImage = Image.FromFile(imageFileName);
                }
                this.groupBox1.Enabled = false;
                this.colorPickerButton2.Enabled = false;
                this.button1.Enabled = true;

            }
			else
			{
				//Remove transparent background
				this.groupBox1.Enabled=true;
				this.colorPickerButton2.Enabled = true;
				this.button1.Enabled = false;
				this.gridListControl1.TransparentBackground = false;
				this.gridListControl1.TableStyle.TextColor = Color.MidnightBlue;
				this.checkBoxAdv2.Enabled=false;
			}
		}

        

		private void checkBoxAdv2_CheckStateChanged(object sender, System.EventArgs e)
		{
			if(this.checkBoxAdv2.Checked)
			{
				//Remove Backround Image
				this.gridListControl1.BackgroundImage = null;
			}
			else
			{
                if (imageFileName == null)
                    this.gridListControl1.BackgroundImage = Image.FromFile(FindImageFile(@"common\Images\Grid\CustomizedListControl\Cloud.jpg"));
                else
                    this.gridListControl1.BackgroundImage = Image.FromFile(imageFileName);
			}
		}

		string imageFileName = null;
		private void button1_Click(object sender, System.EventArgs e)
		{
			FileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg Files (*.jpg)|*.jpg | All files (*.*)|*.*";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				this.checkBoxAdv1.Enabled = true;
				this.imageFileName = dlg.FileName;
				//Apply the selected image to grid's background
				this.gridListControl1.BackgroundImage = Image.FromFile(this.imageFileName);
			}
		}

		private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
		{
			//Change Header BackColor
			this.gridListControl1.HeaderBackColor=colorPickerButton2.SelectedColor;
		}

		private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
		{
			//Change Header TextColor
			this.gridListControl1.HeaderTextColor=colorPickerButton3.SelectedColor;
		}

		private void trackBar1_Scroll(object sender, System.EventArgs e)
		{
			//Change the red component value of grid's backcolor
			this.gridListControl1.BackColor=Color.FromArgb(this.trackBar4.Value,this.trackBar5.Value,this.trackBar6.Value);
		}

		private void trackBar2_Scroll(object sender, System.EventArgs e)
		{
			//Change the green component value of grid's backcolor
			this.gridListControl1.BackColor=Color.FromArgb(this.trackBar4.Value,this.trackBar5.Value,this.trackBar6.Value);
		}

		private void trackBar3_Scroll(object sender, System.EventArgs e)
		{
			//Change the blue component value of grid's backcolor
			this.gridListControl1.BackColor=Color.FromArgb(this.trackBar4.Value,this.trackBar5.Value,this.trackBar6.Value);
		}

		private void checkBoxAdv3_CheckStateChanged(object sender, System.EventArgs e)
		{
			//Enable or Disable the display of horizontal grid lines
			if(this.checkBoxAdv3.Checked)
				this.gridListControl1.Properties.DisplayHorzLines=true;
			else
				this.gridListControl1.Properties.DisplayHorzLines=false;
            
		}

		private void checkBoxAdv4_CheckStateChanged(object sender, System.EventArgs e)
		{
			//Enable or Disable the display of vertical grid lines
			if(this.checkBoxAdv4.Checked)
				this.gridListControl1.Properties.DisplayVertLines=true;
			else
				this.gridListControl1.Properties.DisplayVertLines=false;
                
		}

		private void checkBoxAdv5_CheckStateChanged(object sender, System.EventArgs e)
		{
			//Specify if row/column headers should appear raised or flat
			if(this.checkBoxAdv5.Checked)
				this.gridListControl1.Properties.Buttons3D=true;
			else
				this.gridListControl1.Properties.Buttons3D=false;
		}

		private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
		{
			//Change grid lines color
            this.gridListControl1.Grid.Properties.GridLineColor =  this.colorPickerButton1.SelectedColor;
            this.gridListControl1.Grid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;          
		}

		private void checkBoxAdv6_CheckStateChanged(object sender, System.EventArgs e)
		{
			//Enable or disable ListBoxSelection Mode
            //if(this.checkBoxAdv6.Checked)
                //this.gridListControl1.Grid.DrawCell+=new GridDrawCellEventHandler(Grid_DrawCell);
            //else
                //this.gridListControl1.Grid.DrawCell-=new GridDrawCellEventHandler(Grid_DrawCell);
        }
        #endregion
    }
}
