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
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.StatusBar statusBar1;

		static string filePath = null;

		Hashtable htmlelements = new Hashtable();
		ArrayList listUsers = new ArrayList();

		INPUTElementImpl txtFname;
		INPUTElementImpl txtLname;
		INPUTElementImpl txtUname;
		INPUTElementImpl txtPass;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;


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
			UserClass oneUser = new UserClass("John", "Doe", "johndoe", "");
			this.listUsers.Add(oneUser);
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
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(525, 338);
			this.htmluiControl1.BackColor = System.Drawing.SystemColors.Control;
			this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.ShowTitle = false;
			this.htmluiControl1.Size = new System.Drawing.Size(552, 353);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=77, Height=14}\" xlocation=\"{X=10,Y=0}\">htmluiControl1</bod" +
				"y></html>";
			this.htmluiControl1.LoadError += new Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventHandler(this.htmluiControl1_LoadError);
			this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 331);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(552, 22);
			this.statusBar1.TabIndex = 1;
			this.statusBar1.Text = "statusBar1";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "View Source";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 353);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.statusBar1,
																		  this.htmluiControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HTMLUI Dialog";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		private void htmluiControl1_LoadError(object sender, Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventArgs e)
		{
			this.statusBar1.Text = "Load failed " + e.Document.FileName + " " +e.Document.RenderException.Message;
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			try
			{

				this.statusBar1.Text = "Load succeeded.";

				string path = String.Empty;

				if(this.htmluiControl1.Document.Uri != null)
					path = this.htmluiControl1.Document.Uri.LocalPath;
				else
					path = this.htmluiControl1.Document.FileName;

				if(path == GetFilesLocation() + "viewusers.htm")
				{
					htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();
					BaseElement list = htmlelements["allusersList"] as BaseElement;
					string listString = String.Empty;;
					foreach(UserClass c in this.listUsers)
					{
						listString += c.userName + "(" + c.fName+ " " + c.lName+ ")<p/>";
					}
					list.InnerHTML = listString;
				}
				else if(path  == GetFilesLocation() + "createuser.htm")
				{
					htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();

					BaseElement cuBtn = htmlelements["createUserBtn"] as BaseElement;
					BaseElement caBtn = htmlelements["cancelUserBtn"] as BaseElement;

					txtFname = htmlelements["FirstName"] as INPUTElementImpl;
					txtLname = htmlelements["LastName"] as INPUTElementImpl;
					txtUname = htmlelements["username"] as INPUTElementImpl;
					txtPass = htmlelements["password"] as INPUTElementImpl;

					cuBtn.Click += new EventHandler( cuBtn_Click );
					caBtn.Click += new EventHandler( caBtn_Click );
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadFromFile("main.htm");
		}

		private void caBtn_Click( object sender, EventArgs e )
		{
			LoadFromFile("main.htm");
		}

		private void cuBtn_Click( object sender, EventArgs e )
		{
			htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();

			BaseElement errorElem = htmlelements["errormsg"] as BaseElement;

			string errorMsg = "The following errors were encountered <br/>";
			string fname = txtFname.UserControl.CustomControl.Text.Trim();
			string lname =  txtLname.UserControl.CustomControl.Text.Trim();
			string uname = txtUname.UserControl.CustomControl.Text.Trim();
			string pass = txtPass.UserControl.CustomControl.Text.Trim();

			bool proceed = true;

			if( fname == String.Empty)
			{
				errorMsg  += "First Name is required<br/>";
				proceed = false;
			}

			if(lname == String.Empty)
			{
				errorMsg  += "Last Name is required<br/>";
				proceed = false;
			}

			if(uname == String.Empty)
			{
				errorMsg  += "User Name is required<br/>";
				proceed = false;
			}

			if(pass == String.Empty)
			{
				errorMsg  += "Password is required<br/>";
				proceed = false;
			}

			if(proceed)
			{
				UserClass newUser = new UserClass(fname ,lname ,uname ,pass );
				this.listUsers.Add(newUser);
				LoadFromFile("viewusers.htm");
			}
			else
			{
				errorElem.InnerHTML = errorMsg;
			}
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

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.htmluiControl1.Text);
		}

		private class UserClass
		{
			public string fName;
			public string lName;
			public string userName;
			public string password;

			public UserClass(string fName, string lName,string userName, string password)
			{
				this.fName = fName;
				this.lName = lName;
				this.userName = userName;
				this.password = password;
			}
		}
	}
}
