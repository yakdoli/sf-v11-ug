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

namespace LayoutManagers
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using Syncfusion.Windows.Forms;
	using Syncfusion.Win32;
	using Microsoft.Win32;

	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MdiClient mdiClient1;
		private System.Windows.Forms.MenuItem gridBagLMMenu;
		private System.Windows.Forms.MenuItem cardLMMenu;
		private System.Windows.Forms.MenuItem gridLMMenu;
		private System.Windows.Forms.MenuItem nonControlItems;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.cardLMMenu = new System.Windows.Forms.MenuItem();
			this.gridLMMenu = new System.Windows.Forms.MenuItem();
			this.gridBagLMMenu = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.nonControlItems = new System.Windows.Forms.MenuItem();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.mdiClient1 = new System.Windows.Forms.MdiClient();
			this.SuspendLayout();
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem3,
																					  this.menuItem5,
																					  this.cardLMMenu,
																					  this.gridLMMenu,
																					  this.gridBagLMMenu,
																					  this.menuItem6,
																					  this.nonControlItems});
			this.menuItem1.Text = "LayoutTypes";
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 0;
			this.menuItem3.Text = "New FlowLayout Form";
			this.menuItem3.Click += new System.EventHandler(this.FlowLayout_Clicked);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "New FlowLayout (with ChildConstraints) Form";
			this.menuItem5.Click += new System.EventHandler(this.FlowLayoutCC_Clicked);
			// 
			// cardLMMenu
			// 
			this.cardLMMenu.Index = 2;
			this.cardLMMenu.Text = "New CardLayout Form";
			this.cardLMMenu.Click += new System.EventHandler(this.cardLMMenu_Click);
			// 
			// gridLMMenu
			// 
			this.gridLMMenu.Index = 3;
			this.gridLMMenu.Text = "New GridLayout Form";
			this.gridLMMenu.Click += new System.EventHandler(this.gridLMMenu_Click);
			// 
			// gridBagLMMenu
			// 
			this.gridBagLMMenu.Index = 4;
			this.gridBagLMMenu.Text = "New GridBagLayout Form";
			this.gridBagLMMenu.Click += new System.EventHandler(this.gridBagLMMenu_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 5;
			this.menuItem6.Text = "New BorderLayout Form";
			this.menuItem6.Click += new System.EventHandler(this.BorderLayout_Click);
			// 
			// nonControlItems
			// 
			this.nonControlItems.Index = 6;
			this.nonControlItems.Text = "New Layout Non-Control based classes Form";
			this.nonControlItems.Click += new System.EventHandler(this.nonControlItems_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem2});
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4});
			this.menuItem2.Text = "&Help";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "&About Syncfusion";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// mdiClient1
			// 
			this.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mdiClient1.Name = "mdiClient1";
			this.mdiClient1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(648, 417);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.mdiClient1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(400, 375);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Layout Managers";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static public void Main() 
		{
			Application.Run(new MainForm());
		}
		private void FlowLayout_Clicked(object sender, System.EventArgs e)
		{
			FlowLayoutForm form = new FlowLayoutForm();
			form.MdiParent = this;
			form.Show();
		}
		
		private void FlowLayoutCC_Clicked(object sender, System.EventArgs e)
		{
			FlowLayoutCC form = new FlowLayoutCC();
			form.MdiParent = this;
			form.Show();
		}

		private void cardLMMenu_Click(object sender, System.EventArgs e)
		{
			CardLayoutForm form = new CardLayoutForm();
			form.MdiParent = this;
			form.Show();
		}

		private void gridLMMenu_Click(object sender, System.EventArgs e)
		{
			GridLayoutForm form = new GridLayoutForm();
			form.MdiParent = this;
			form.Show();
		}

		private void gridBagLMMenu_Click(object sender, System.EventArgs e)
		{
			GridBagLayoutForm form = new GridBagLayoutForm();
			form.MdiParent = this;
			form.Show();
		}

		private void nonControlItems_Click(object sender, System.EventArgs e)
		{
			NonControlBasedComponents form = new NonControlBasedComponents();
			form.MdiParent = this;
			form.Show();
		}

		
		private void BorderLayout_Click(object sender, System.EventArgs e)
		{
			BorderLayoutForm form = new BorderLayoutForm();
			form.MdiParent = this;
			form.Show();
		}

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			foreach(Control ctrl in this.Controls)
			{
				if(ctrl is MdiClient)
					ctrl.BackColor  = Color.FromArgb(223, 227, 239);
			}
			this.nonControlItems_Click(this, EventArgs.Empty);
			this.BorderLayout_Click(this, EventArgs.Empty);
			this.cardLMMenu_Click(this, EventArgs.Empty);
			this.gridLMMenu_Click(this, EventArgs.Empty);
			this.gridBagLMMenu_Click(this, EventArgs.Empty);
			this.FlowLayoutCC_Clicked(this, EventArgs.Empty);
			this.FlowLayout_Clicked(this, EventArgs.Empty);

			this.LayoutMdi(MdiLayout.TileVertical);
		}

		#region AboutForm_Logic
		DemoCommon.AboutForm aboutForm = null;
		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
			aboutForm.ShowDialog();
		}
	
		#endregion AboutForm_Logic

	}
}
