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

using Syncfusion.Windows.Forms.HTMLUI;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private string customControlTemplateString;
		private string controlsString;
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;

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
			this.customControlTemplateString = "<custom assembly='$$assembly$$' class='$$classname$$'  width='280'/><p/>";
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
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(301, 281);
			this.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(229)), ((System.Byte)(245)));
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.Size = new System.Drawing.Size(328, 296);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 4;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=66, Height=15}\" xlocation=\"{X=10,Y=0}\">htmluiControl1</bod" +
				"y></html>";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.textBox1,
																				 this.comboBox1,
																				 this.label2,
																				 this.label1,
																				 this.button2,
																				 this.button1,
																				 this.listView1});
			this.panel1.Location = new System.Drawing.Point(328, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(224, 296);
			this.panel1.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(8, 184);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(200, 20);
			this.textBox1.TabIndex = 24;
			this.textBox1.Text = "System.Windows.Forms";
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "HScrollBar",
														   "CheckBox",
														   "DataGrid",
														   "TabControl",
														   "ListBox",
														   "RadioButton"});
			this.comboBox1.Location = new System.Drawing.Point(8, 232);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 21);
			this.comboBox1.TabIndex = 23;
			this.comboBox1.Text = "Button";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(251)), ((System.Byte)(172)), ((System.Byte)(85)));
			this.label2.Location = new System.Drawing.Point(8, 160);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 16);
			this.label2.TabIndex = 21;
			this.label2.Text = "Assembly Name";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(251)), ((System.Byte)(172)), ((System.Byte)(85)));
			this.label1.Location = new System.Drawing.Point(8, 208);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 16);
			this.label1.TabIndex = 20;
			this.label1.Text = "Class Name";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(228)), ((System.Byte)(240)));
			this.button2.Enabled = false;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Maroon;
			this.button2.Location = new System.Drawing.Point(56, 128);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 24);
			this.button2.TabIndex = 18;
			this.button2.Text = "Delete";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(228)), ((System.Byte)(240)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Maroon;
			this.button1.Location = new System.Drawing.Point(64, 264);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 24);
			this.button1.TabIndex = 17;
			this.button1.Text = "Add";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.listView1.BackColor = System.Drawing.Color.White;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.columnHeader1,
																						this.columnHeader2});
			this.listView1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listView1.FullRowSelect = true;
			this.listView1.Location = new System.Drawing.Point(7, 8);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(209, 113);
			this.listView1.TabIndex = 15;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Class Name";
			this.columnHeader1.Width = 86;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Assembly";
			this.columnHeader2.Width = 188;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.richTextBox1.BackColor = System.Drawing.Color.White;
			this.richTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(0, 296);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(552, 80);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.richTextBox1,
																		  this.htmluiControl1,
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Controls creation";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
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
			Application.Run(new Form1());
		}

		private void FillInitialHTML()
		{
			CreateControl("Syncfusion.Windows.Forms.ButtonAdv", "Syncfusion.Shared.Base");
			CreateControl("Syncfusion.Windows.Forms.Tools.CurrencyTextBox", "Syncfusion.Shared.Base");
			CreateControl("DateTimePicker", "System.Windows.Forms");
			CreateControl("DataGrid", "System.Windows.Forms");

			AddToListView("Syncfusion.Windows.Forms.ButtonAdv", "Syncfusion.Shared.Base");
			AddToListView("Syncfusion.Windows.Forms.Tools.CurrencyTextBox", "Syncfusion.Shared.Base");
			AddToListView("DateTimePicker", "System.Windows.Forms");
			AddToListView("DataGrid", "System.Windows.Forms");

			SyncHTML();
		}

		private void SyncHTML()
		{
			string htmlStr = "<html><title>Click add button to add the control to HTMLUI</title><body>" + this.controlsString + "</body></html>";
			this.htmluiControl1.LoadFromString(htmlStr);
			this.richTextBox1.Text = htmlStr.Replace("<p/>", "<p/>\r\n");
		}


		private void Form1_Load(object sender, System.EventArgs e)
		{
			FillInitialHTML();
		}

		private void CreateControl(string className, string assemblyName)
		{
			string customHTML = this.customControlTemplateString.Replace("$$classname$$", className);
			customHTML = customHTML.Replace("$$assembly$$", assemblyName);
			this.controlsString += customHTML;
		}

		private void CreateAllControls()
		{
			this.controlsString = "";

			for(int i=0;i< this.listView1.Items.Count ;i++) 
			{ 
				CreateControl(this.listView1.Items[i].SubItems[0].Text, this.listView1.Items[i].SubItems[1].Text); 
			} 

			SyncHTML();
		}

		private void AddToListView(string className, string assemblyName)
		{
			ListViewItem item = this.listView1.Items.Add(className);
			item.SubItems.Add(assemblyName);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			AddToListView(this.comboBox1.Text, this.textBox1.Text);
			CreateAllControls();
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.listView1.SelectedItems.Count > 0)
				this.button2.Enabled = true;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(this.listView1.SelectedItems.Count > 0)
			{
				this.listView1.Items.Remove(this.listView1.SelectedItems[0]);
			}
			CreateAllControls();

			if(this.listView1.Items.Count > 0)
			{
				this.listView1.Items[0].Selected = true;				
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.controlsString);
		}
	}
}
