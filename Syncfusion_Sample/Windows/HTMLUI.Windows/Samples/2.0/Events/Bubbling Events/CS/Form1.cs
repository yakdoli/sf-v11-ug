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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox checkBox1;
		IHTMLElement[] htmlelement;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;


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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(349, 337);
			this.htmluiControl1.BackColor = System.Drawing.SystemColors.Control;
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Location = new System.Drawing.Point(176, 0);
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.ShowTitle = false;
			this.htmluiControl1.Size = new System.Drawing.Size(376, 352);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=71, Height=15}\" xlocation=\"{X=10,Y=0}\">htmluiControl1</bod" +
				"y></html>";
			this.htmluiControl1.LoadError += new Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventHandler(this.htmluiControl1_LoadError);
			this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
			// 
			// statusBar1
			// 
			this.statusBar1.Location = new System.Drawing.Point(0, 352);
			this.statusBar1.Name = "statusBar1";
			this.statusBar1.Size = new System.Drawing.Size(552, 22);
			this.statusBar1.TabIndex = 1;
			this.statusBar1.Text = "statusBar1";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel2,
																				 this.checkBox1});
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(176, 352);
			this.panel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel3});
			this.panel2.Location = new System.Drawing.Point(8, 112);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(160, 88);
			this.panel2.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label2,
																				 this.label1});
			this.panel3.Location = new System.Drawing.Point(2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(156, 84);
			this.panel3.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Action";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(141)), ((System.Byte)(46)), ((System.Byte)(28)));
			this.label1.Location = new System.Drawing.Point(2, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 54);
			this.label1.TabIndex = 2;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(51)), ((System.Byte)(51)), ((System.Byte)(103)));
			this.checkBox1.Location = new System.Drawing.Point(8, 24);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(160, 72);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Check To Include Mouse Leave Event";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.statusBar1,
																		  this.htmluiControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bubbling Events";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
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

				if(path == GetFilesLocation() + "main.htm")
				{
					htmlelement = this.htmluiControl1.Document.GetElementsByName("body");
				}				
				this.htmlelement[0].Click += new EventHandler(body_OnClick);
				this.htmlelement[0].MouseLeave += new EventHandler(body_MouseLeave);
			}
			catch(Exception ex)
			{
				MessageBox.Show("Error:" + ex.ToString());
			}
		}

		private void body_OnClick(object sender, EventArgs e)
		{
			BubblingEventArgs bargs = HTMLUIControl.GetBublingEventArgs(e);
			BaseElement elem = bargs.RootSender as BaseElement;

			if( elem != null && elem is INPUTElementImpl)
			{
				if(elem.ID == "Button1")
				{
					this.label1.Text = "Button 1 clicked";
				}
				else if(elem.ID == "Button2")
				{
					this.label1.Text = "Button 2 clicked";
				}
				else if(elem.ID == "Button3")
				{
					this.label1.Text = "Button 3 clicked";
				}
				else if(elem.ID == "Button4")
				{
					this.label1.Text = "Button 4 clicked";
				}
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

		private void body_MouseLeave(object sender, EventArgs e)
		{
			BubblingEventArgs bargs = HTMLUIControl.GetBublingEventArgs(e);
			BaseElement elem = bargs.RootSender as BaseElement;

			if( elem != null && elem is INPUTElementImpl && checkBox1.Checked == true)
			{
				if(elem.ID == "Button1")
				{
					this.label1.Text = "Mouse just left Button 1";
				}
				else if(elem.ID == "Button2")
				{
					this.label1.Text = "Mouse just left Button 2";
				}
				else if(elem.ID == "Button3")
				{
					this.label1.Text = "Mouse just left Button 3";
				}
				else if(elem.ID == "Button4")
				{
					this.label1.Text = "Mouse just left Button 4";
				}
			}	
		}



	}
}
