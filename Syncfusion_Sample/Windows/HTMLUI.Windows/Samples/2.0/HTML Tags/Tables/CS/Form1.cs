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

		Assembly _assembly;
		Stream _htmlStream;

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
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.BackColor = System.Drawing.SystemColors.Control;
			this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.Size = new System.Drawing.Size(552, 374);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=77, Height=14}\" xlocation=\"{X=10,Y=20}\">htmluiControl1</bo" +
				"dy></html>";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.htmluiControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tables";
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

		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.tables.htm");
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTMLResource();
		}
	}
}
