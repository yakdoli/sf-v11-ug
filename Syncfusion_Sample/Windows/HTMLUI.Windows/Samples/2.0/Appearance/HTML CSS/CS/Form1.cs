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

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label3;

		static string filePath;

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
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel4});
			this.panel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(136, 374);
			this.panel1.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.panel4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel5});
			this.panel4.Location = new System.Drawing.Point(8, 24);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(120, 136);
			this.panel4.TabIndex = 5;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.panel5.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label3,
																				 this.radioButton2,
																				 this.radioButton1});
			this.panel5.Location = new System.Drawing.Point(2, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(116, 132);
			this.panel5.TabIndex = 5;
			// 
			// radioButton2
			// 
			this.radioButton2.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton2.Location = new System.Drawing.Point(4, 82);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(108, 40);
			this.radioButton2.TabIndex = 5;
			this.radioButton2.Text = "Style sheet2";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Anchor = (System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.ForeColor = System.Drawing.Color.Maroon;
			this.radioButton1.Location = new System.Drawing.Point(4, 42);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(108, 32);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Style sheet1";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(389, 361);
			this.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Location = new System.Drawing.Point(136, 0);
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.Size = new System.Drawing.Size(416, 376);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 2;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=77, Height=14}\" xlocation=\"{X=10,Y=20}\">htmluiControl1</bo" +
				"dy></html>";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(-2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "Style Sheets";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.htmluiControl1,
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HTML CSS";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
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

		private void LoadHTMLFile(string fileName)
		{

			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			if(slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			this.htmluiControl1.StartupDocument = System.IO.Path.Combine(path, fileName);	

		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTMLFile(@"styles.htm");
			if(this.radioButton1.Checked == true)
			{
				LoadCSSFromFile("style.css");
			}
		}
		private void LoadCSSFromFile(string fileName)
		{
			string filePath = GetFilesLocation() + fileName;
			this.htmluiControl1.LoadCSS(filePath);
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

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			Console.WriteLine("Load Finished");
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.radioButton2.Checked == true)
			{
				LoadCSSFromFile("style2.css");
			}
			
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(this.radioButton1.Checked == true)
			{
				LoadCSSFromFile("style.css");
			}
					
		}


	}
}
