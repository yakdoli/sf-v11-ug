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

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.OpenFileDialog openFileDlg;
		private System.Windows.Forms.MenuItem Open;
		private System.Windows.Forms.MenuItem MenuExit;
		private System.Windows.Forms.MenuItem MenuEdit;
		private System.Windows.Forms.MenuItem HTMLSource;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.ContextMenu cxtMenu;
		private System.Windows.Forms.MenuItem cxtEdit;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			this.cxtMenu = new System.Windows.Forms.ContextMenu();
			this.cxtEdit = new System.Windows.Forms.MenuItem();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.Open = new System.Windows.Forms.MenuItem();
			this.MenuExit = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.MenuEdit = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.HTMLSource = new System.Windows.Forms.MenuItem();
			this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.htmluiControl1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(520, 366);
			this.panel1.TabIndex = 0;
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(493, 351);
			this.htmluiControl1.BackColor = System.Drawing.Color.White;
			this.htmluiControl1.ContextMenu = this.cxtMenu;
			this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.Size = new System.Drawing.Size(520, 366);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "htmluiControl1";
			this.htmluiControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.htmluiControl1_KeyDown);
			// 
			// cxtMenu
			// 
			this.cxtMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.cxtEdit});
			// 
			// cxtEdit
			// 
			this.cxtEdit.Index = 0;
			this.cxtEdit.Text = "Edit HTML";
			this.cxtEdit.Click += new System.EventHandler(this.cxtEdit_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem6,
																					  this.menuItem4});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.Open,
																					  this.MenuExit});
			this.menuItem1.Text = "File";
			// 
			// Open
			// 
			this.Open.Index = 0;
			this.Open.Text = "Open";
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// MenuExit
			// 
			this.MenuExit.Index = 1;
			this.MenuExit.Text = "Exit";
			this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.MenuEdit});
			this.menuItem6.Text = "Edit";
			// 
			// MenuEdit
			// 
			this.MenuEdit.Index = 0;
			this.MenuEdit.Text = "Edit HTML";
			this.MenuEdit.Click += new System.EventHandler(this.MenuEdit_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.HTMLSource});
			this.menuItem4.Text = "View";
			// 
			// HTMLSource
			// 
			this.HTMLSource.Index = 0;
			this.HTMLSource.Text = "HTML Source";
			this.HTMLSource.Click += new System.EventHandler(this.HTMLSource_Click);
			// 
			// openFileDlg
			// 
			this.openFileDlg.Filter = "html files|*.html|htm files|*.htm";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(520, 366);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HTMLUI Editor";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
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

		#region ClassEvents
		private void Open_Click(object sender, System.EventArgs e)
		{
			this.openFileDlg.InitialDirectory = GetFilesLocation();;
			if(openFileDlg.ShowDialog() == DialogResult.OK)
			{
				string fileName = this.openFileDlg.FileName.ToString();
				this.htmluiControl1.LoadHTML(fileName);
			}
		}

		private void MenuExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void MenuEdit_Click(object sender, System.EventArgs e)
		{
			OpenEditForm();
		}

		private void HTMLSource_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.htmluiControl1.Text.ToString());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.LoadFromFile("products.htm");
		}

		private void cxtEdit_Click(object sender, System.EventArgs e)
		{
			OpenEditForm();
		}

		private void htmluiControl1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.Alt == true && e.KeyCode == Keys.E)
			{
				OpenEditForm();
			}
		}
		#endregion

		#region ClassMethods
		/// <summary>
		/// Loads the main HTMLUI control with the specified file
		/// </summary>
		/// <param name="fileName">Name of the file to be loaded.</param>
		private void LoadFromFile(string fileName)
		{
			string filePath = GetFilesLocation() + fileName;
			this.htmluiControl1.LoadHTML(filePath);
		}

		/// <summary>
		/// Gets the project location
		/// </summary>
		/// <returns>string</returns>
		static string GetFilesLocation()
		{
			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			if(slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			path = path + "\\files\\";
			return path;
		}

		/// <summary>
		/// Opens the editor dialog to edit the html.
		/// </summary>
		private void OpenEditForm()
		{
			editForm edit = new editForm(this.htmluiControl1.Text);
			if(edit.ShowDialog() == DialogResult.OK)
			{
				this.htmluiControl1.LoadFromString(edit.newHtml.ToString());
			}
		}
		#endregion
	}
}
