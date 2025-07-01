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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;

using Syncfusion.Windows.Forms.Tools;
using System.Data.SqlServerCe;

namespace ComboTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ComboBox comboBox2;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textLog;
		private System.Windows.Forms.TabPage tabPage1;
		private ComboTest.MultiColumnComboBoxSampleControl comboBoxAdvSampleControl1;
		private System.Windows.Forms.TabControl tabControl1;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.comboBoxAdvSampleControl1.textLog = this.textLog;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textLog = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.comboBoxAdvSampleControl1 = new ComboTest.MultiColumnComboBoxSampleControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.comboBox2,
																				 this.splitter1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(456, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(176, 517);
			this.panel1.TabIndex = 6;
			// 
			// comboBox2
			// 
			this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.comboBox2.Location = new System.Drawing.Point(3, 0);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(173, 21);
			this.comboBox2.TabIndex = 1;
			// 
			// splitter1
			// 
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 517);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.textLog});
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 262);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(512, 192);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Events:";
			// 
			// textLog
			// 
			this.textLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textLog.Location = new System.Drawing.Point(3, 16);
			this.textLog.Multiline = true;
			this.textLog.Name = "textLog";
			this.textLog.Size = new System.Drawing.Size(506, 173);
			this.textLog.TabIndex = 0;
			this.textLog.Text = "";
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.comboBoxAdvSampleControl1});
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(504, 236);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "ComboBoxAdv";
			// 
			// comboBoxAdvSampleControl1
			// 
			this.comboBoxAdvSampleControl1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.comboBoxAdvSampleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBoxAdvSampleControl1.Name = "comboBoxAdvSampleControl1";
			this.comboBoxAdvSampleControl1.Size = new System.Drawing.Size(504, 236);
			this.comboBoxAdvSampleControl1.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1});
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.ItemSize = new System.Drawing.Size(82, 18);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(512, 262);
			this.tabControl1.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(154)));
			this.ClientSize = new System.Drawing.Size(512, 454);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1,
																		  this.groupBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Multi Column ComboBox";
			this.Load += new EventHandler(Form1_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
        void Form1_Load(object sender, EventArgs e)
        {
            string connectionstring = "Data Source = ..\\..\\..\\..\\..\\..\\..\\..\\..\\Common\\Data\\NorthwindIO.sdf";
            DataTable table = new DataTable();
            SqlCeConnection conn = new SqlCeConnection(connectionstring);
            conn.Open();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT CompanyName, ContactName, City, Country, CustomerID FROM Customers ORDER BY CompanyName ", conn);
            adapter.Fill(table);
            //Bind the Data Table with the MultiColumnBoundCombobox DataSource
            this.comboBoxAdvSampleControl1.multiColumnBoundCombo.DataSource = table;
            this.comboBoxAdvSampleControl1.propertyGrid1.SelectedObject = this.comboBoxAdvSampleControl1.multiColumnBoundCombo;
            adapter.Dispose();
            conn.Close();
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
	}
	interface IChildSampleControls
	{
		Control GetPrimaryItem();
	}
}
