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
using System.Reflection;

using Syncfusion.Windows.Forms.HTMLUI;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		Assembly _assembly;
		Stream _htmlStream;

		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolTip toolTip1;
		private Syncfusion.Windows.Forms.Tools.CalculatorControl calculatorControl1;
		private Syncfusion.Windows.Forms.Tools.FontListBox fontListBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private int fileloaded = 0;
		static string filePath;

		private DataSet prodDs1;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			this.fontListBox1 = new Syncfusion.Windows.Forms.Tools.FontListBox();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.calculatorControl1 = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.htmluiControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(526, 287);
			this.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(228)), ((System.Byte)(241)));
			this.htmluiControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.fontListBox1,
																						 this.dataGrid1,
																						 this.monthCalendar1});
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.ForeColor = System.Drawing.Color.Maroon;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Location = new System.Drawing.Point(-1, 48);
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.ShowTitle = false;
			this.htmluiControl1.Size = new System.Drawing.Size(553, 302);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=66, Height=15}\" xlocation=\"{X=10,Y=0}\">htmluiControl1</bod" +
				"y></html>";
			this.htmluiControl1.PreRenderDocument += new Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentEventHandler(this.htmluiControl1_PreRenderDocument);
			this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
			// 
			// fontListBox1
			// 
			this.fontListBox1.Location = new System.Drawing.Point(248, 80);
			this.fontListBox1.Name = "fontListBox1";
			this.fontListBox1.Size = new System.Drawing.Size(120, 95);
			this.fontListBox1.TabIndex = 4;
			// 
			// dataGrid1
			// 
			this.dataGrid1.AccessibleName = "DataGrid";
			this.dataGrid1.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(8, 176);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(204, 144);
			this.dataGrid1.TabIndex = 2;
			this.toolTip1.SetToolTip(this.dataGrid1, "This is a DataGrid control inside HTMLUI");
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(56, 8);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 1;
			// 
			// calculatorControl1
			// 
			this.calculatorControl1.AccessibleDescription = "Calculator control";
			this.calculatorControl1.AccessibleName = "Calculator Control";
			this.calculatorControl1.AutoSize = false;
			this.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
			this.calculatorControl1.Culture = new System.Globalization.CultureInfo("en-US");
			this.calculatorControl1.DoubleValue = 0;
			this.calculatorControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.calculatorControl1.Location = new System.Drawing.Point(208, 0);
			this.calculatorControl1.Name = "calculatorControl1";
			this.calculatorControl1.RepeatAssignAction = true;
			this.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.calculatorControl1.Size = new System.Drawing.Size(250, 300);
			this.calculatorControl1.TabIndex = 3;
			this.calculatorControl1.Text = "calculatorControl1";
			this.calculatorControl1.ThemesEnabled = true;
			this.calculatorControl1.UseUserOverride = true;
			this.calculatorControl1.UseVisualStyle = false;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3});
			this.menuItem1.Text = "File";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "Exit";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5});
			this.menuItem4.Text = "View";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.Text = "HTML";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(205)), ((System.Byte)(212)), ((System.Byte)(231)));
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button2,
																				 this.button1});
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(569, 48);
			this.panel1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Maroon;
			this.button2.Location = new System.Drawing.Point(344, 7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(138, 30);
			this.button2.TabIndex = 1;
			this.button2.Text = "Load Custom Page2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Maroon;
			this.button1.Location = new System.Drawing.Point(80, 7);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(152, 31);
			this.button1.TabIndex = 0;
			this.button1.Text = "Load Custom Page1";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(550, 351);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.htmluiControl1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Custom Controls";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
			this.htmluiControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.fileloaded = 1;
			LoadHTMLResource();			
		}

		#region LOADUI
		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.customcontrols.htm");
				if(_htmlStream != null)
				{
					this.htmluiControl1.LoadHTML(_htmlStream);
					success = true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return success;
		}
		#endregion

		#region MENU_HANDLING

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.htmluiControl1.Text);
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		private void htmluiControl1_PreRenderDocument(object sender, Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentArgs e)
		{
			Hashtable htmlelements = new Hashtable();
			htmlelements = e.Document.ElementsByUserID;

			if(this.fileloaded == 1)
			{
				BaseElement monthCalendarElement1 = htmlelements["monthCalendar1"] as BaseElement;
				new CustomControlBase( monthCalendarElement1, this.monthCalendar1  ); 


				BaseElement dataGridElement1 = htmlelements["dataGrid1"] as BaseElement;
				new CustomControlBase( dataGridElement1, this.dataGrid1  ); 
			}

			else
			{
				BaseElement calculatorElement1 = htmlelements["calc"] as BaseElement;
				new CustomControlBase( calculatorElement1, this.calculatorControl1);

				BaseElement fontListElement1 = htmlelements["font"] as BaseElement;
				new CustomControlBase( fontListElement1, this.fontListBox1);
			}
		}

		private void CreateDataSet()
		{
			string tableName = "Products";
			prodDs1 = new DataSet();
			prodDs1.Tables.Add(tableName);

			DataColumn ExpiresIn = prodDs1.Tables[tableName].Columns.Add("ExpiresIn", typeof( System.TimeSpan));		
			DataColumn Quantity = prodDs1.Tables[tableName].Columns.Add("Quantity", typeof(double));	
			DataColumn Value = prodDs1.Tables[tableName].Columns.Add("Value", typeof(double));	
		
			DataRow drEmpty = prodDs1.Tables[tableName].NewRow();

			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[0]["ExpiresIn"] = new TimeSpan(0,8,0,0,0);
			prodDs1.Tables[tableName].Rows[0]["Quantity"] = 45;
			prodDs1.Tables[tableName].Rows[0]["Value"] = 2000;

			drEmpty = prodDs1.Tables[tableName].NewRow();

			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[1]["ExpiresIn"] = new TimeSpan(0,9,0,0,0);
			prodDs1.Tables[tableName].Rows[1]["Quantity"] = 27;
			prodDs1.Tables[tableName].Rows[1]["Value"] = 3000;

			drEmpty = prodDs1.Tables[tableName].NewRow();

			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[2]["ExpiresIn"] = new TimeSpan(0,10,0,0,0);
			prodDs1.Tables[tableName].Rows[2]["Quantity"] = 35;
			prodDs1.Tables[tableName].Rows[2]["Value"] = 4000;

			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[3]["ExpiresIn"] = new TimeSpan(0,11,0,0,0);
			prodDs1.Tables[tableName].Rows[3]["Quantity"] = 49;
			prodDs1.Tables[tableName].Rows[3]["Value"] = 5000;

			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[4]["ExpiresIn"] = new TimeSpan(0,12,0,0,0);
			prodDs1.Tables[tableName].Rows[4]["Quantity"] = 55;
			prodDs1.Tables[tableName].Rows[4]["Value"] = 6000;

			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[5]["ExpiresIn"] = new TimeSpan(0,13,0,0,0);
			prodDs1.Tables[tableName].Rows[5]["Quantity"] = 16;
			prodDs1.Tables[tableName].Rows[5]["Value"] = 7000;

			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[6]["ExpiresIn"] = new TimeSpan(0,14,0,0,0);
			prodDs1.Tables[tableName].Rows[6]["Quantity"] = 26;
			prodDs1.Tables[tableName].Rows[6]["Value"] = 300;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[7]["ExpiresIn"] = new TimeSpan(0,15,0,0,0);
			prodDs1.Tables[tableName].Rows[7]["Quantity"] = 46;
			prodDs1.Tables[tableName].Rows[7]["Value"] = 6700;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[8]["ExpiresIn"] = new TimeSpan(0,16,0,0,0);
			prodDs1.Tables[tableName].Rows[8]["Quantity"] = 36;
			prodDs1.Tables[tableName].Rows[8]["Value"] = 5600;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[9]["ExpiresIn"] = new TimeSpan(0,17,0,0,0);
			prodDs1.Tables[tableName].Rows[9]["Quantity"] = 22;
			prodDs1.Tables[tableName].Rows[9]["Value"] = 3800;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[10]["ExpiresIn"] = new TimeSpan(0,18,0,0,0);
			prodDs1.Tables[tableName].Rows[10]["Quantity"] = 42;
			prodDs1.Tables[tableName].Rows[10]["Value"] = 4500;


			drEmpty = prodDs1.Tables[tableName].NewRow();
			prodDs1.Tables[tableName].Rows.Add(drEmpty);
			prodDs1.Tables[tableName].Rows[11]["ExpiresIn"] = new TimeSpan(0,19,0,0,0);
			prodDs1.Tables[tableName].Rows[11]["Quantity"] = 52;
			prodDs1.Tables[tableName].Rows[11]["Value"] = 4350;

			this.dataGrid1.DataSource = this.prodDs1.Tables[0];
			
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			CreateDataSet();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.fileloaded = 1;
			LoadHTMLResource();	
		}

		private void LoadFromFile(string fileName)
		{
			string filePath = GetFilesLocation() + fileName;
			this.htmluiControl1.LoadHTML(filePath);
		}

		static string GetFilesLocation()
		{
			if(filePath != null)
				return filePath;

			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			if(slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			filePath = path + "\\files\\";
			return filePath;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.fileloaded = 2;
			LoadFromFile("customcontrols2.htm");
		}
	}
}
