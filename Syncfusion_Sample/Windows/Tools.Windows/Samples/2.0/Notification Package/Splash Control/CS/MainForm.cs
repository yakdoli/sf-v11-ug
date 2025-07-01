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

namespace SplashControlDemo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Tools;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.PictureBox pictureBox1;
		internal System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Button button6;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private System.Windows.Forms.ImageList imageList2;
		public Syncfusion.Windows.Forms.Tools.SplashControl splashControl1;


		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		private void SplashClosedHandler(object sender, EventArgs e)
		{
			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.splashControl1 = new Syncfusion.Windows.Forms.Tools.SplashControl();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
			this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
			this.tabControlAdv1.SuspendLayout();
			this.tabPageAdv1.SuspendLayout();
			this.tabPageAdv2.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// splashControl1
			// 
			this.splashControl1.CustomSplashPanel = null;
			this.splashControl1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.RightBottom;
			this.splashControl1.HostForm = this;
			this.splashControl1.HostFormWindowState = System.Windows.Forms.FormWindowState.Normal;
			this.splashControl1.SplashImage = ((System.Drawing.Bitmap)(resources.GetObject("splashControl1.SplashImage")));
			this.splashControl1.TimerInterval = 3000;
			this.splashControl1.UseCustomSplashPanel = true;
			this.splashControl1.SplashDisplayed += new System.EventHandler(this.splashControl1_SplashDisplayed);
			this.splashControl1.BeforeSplash += new System.ComponentModel.CancelEventHandler(this.splashControl1_BeforeSplash);
			this.splashControl1.SplashClosed += new System.EventHandler(this.splashControl1_SplashClosed);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3});
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
			this.menuItem2.Text = "&Exit";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4});
			this.menuItem3.Text = "Help";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "About...";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(56, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(450, 250);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// textBox5
			// 
			this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(154)));
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox5.Size = new System.Drawing.Size(549, 344);
			this.textBox5.TabIndex = 4;
			this.textBox5.Text = "";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.button6.ImageIndex = 2;
			this.button6.Location = new System.Drawing.Point(184, 264);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(192, 40);
			this.button6.TabIndex = 4;
			this.button6.Text = "Click to Show Splash Screen";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// tabControlAdv1
			// 
			this.tabControlAdv1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.tabPageAdv1,
																						 this.tabPageAdv2});
			this.tabControlAdv1.ImageList = this.imageList2;
			this.tabControlAdv1.Location = new System.Drawing.Point(0, 8);
			this.tabControlAdv1.Name = "tabControlAdv1";
		
			this.tabControlAdv1.Size = new System.Drawing.Size(552, 376);
			this.tabControlAdv1.TabIndex = 6;
			this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(154)));
			this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbey);
			// 
			// tabPageAdv1
			// 
			this.tabPageAdv1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.pictureBox1,
																					  this.button6});
			this.tabPageAdv1.ImageIndex = 0;
			this.tabPageAdv1.Location = new System.Drawing.Point(1, 30);
			this.tabPageAdv1.Name = "tabPageAdv1";
			this.tabPageAdv1.Size = new System.Drawing.Size(549, 344);
			this.tabPageAdv1.TabIndex = 0;
			this.tabPageAdv1.Text = "Show Splash";
			this.tabPageAdv1.ThemesEnabled = false;
			// 
			// tabPageAdv2
			// 
			this.tabPageAdv2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.textBox5});
			this.tabPageAdv2.ImageIndex = 1;
			this.tabPageAdv2.Location = new System.Drawing.Point(1, 30);
			this.tabPageAdv2.Name = "tabPageAdv2";
			this.tabPageAdv2.Size = new System.Drawing.Size(549, 344);
			this.tabPageAdv2.TabIndex = 1;
			this.tabPageAdv2.Text = "EventLog";
			this.tabPageAdv2.ThemesEnabled = false;
			// 
			// imageList2
			// 
			this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.ClientSize = new System.Drawing.Size(552, 347);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControlAdv1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash Control";
			((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
			this.tabControlAdv1.ResumeLayout(false);
			this.tabPageAdv1.ResumeLayout(false);
			this.tabPageAdv2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			MainForm frmMain = new MainForm();
			Application.Run(frmMain);
		}
		#region ShowSplash
		private void button6_Click(object sender, System.EventArgs e)
		{
			this.splashControl1.ShowSplash(false);
		}
		#endregion
		#region samplecodeblock
		protected void CodeGen_InitializeComponent()
		{
			// <samplecodeblock name="SplashControl InitializeComponent">
			// InitializeComponent
			
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));

			// Create the splash control
			this.splashControl1 = new SplashControl();

			// Setting AutoMode to true will automatically launch
			// splash screen - no additional code is required
			this.splashControl1.AutoMode = true;

			// The start position for the splash screen
			this.splashControl1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center;
			
			// The host form for the splash control
			this.splashControl1.HostForm = this;

			// Specifies if the splash screen should appear animated
			this.splashControl1.ShowAnimation = false;
			
			// The Splash image - specified through the designer
			this.splashControl1.SplashImage = ((System.Drawing.Bitmap)(resources.GetObject("splashControl1.SplashImage")));
			
			// The time period for which the splash should appear
			this.splashControl1.TimerInterval = 3000;
			//</samplecodeblock>
		}

		#endregion
		#region Exit
		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#endregion
		#region SplashClosed
		//<samplecodeblock name="SplashControl SplashClosed event.">
		private void splashControl1_SplashClosed(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashClosed", sender.ToString());
			textBox5.Text = textBox5.Text + eventlogmessage;

		}
		#endregion
		//</samplecodeblock>
		#region SplashControlAboutForm
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			DemoCommon.AboutForm ab=new DemoCommon.AboutForm( AppDomain.CurrentDomain.GetAssemblies());
			ab.ShowDialog();
		}
		#endregion
		#region BeforeSplash
		private void splashControl1_BeforeSplash(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "BeforeSplash", sender.ToString());
			textBox5.Text = textBox5.Text + eventlogmessage;
	
		}
		#endregion
		#region SplashDisplayed
		private void splashControl1_SplashDisplayed(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashDisplayed", sender.ToString());
			textBox5.Text = textBox5.Text + eventlogmessage;
		}
		#endregion

		
	}
}
