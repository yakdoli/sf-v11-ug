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

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Implementation;


namespace ContextMenuDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuItem menuItem9;

		private string basePath = @"..\..\Test Files\PascalSource.pas";

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.LoadFile(basePath);

			this.editControl1.ShowIndicatorMargin = true;
			this.editControl1.ShowHorizontalSplitters = false;
			this.editControl1.ShowVerticalSplitters = false;

			// Enable or disable context menu
			// this.editControl1.ContextMenuManager.Enabled = false;

			// Switch to XPMenus PopupMenu
			// If the Syncfusion.Tools.Windows assembly was loaded before context menu is instantiated for the first time,
			// then a XPMenus PopupMenu is shown. Otherwise, a standard .NET context menu is shown.

			// Instantiating a type from Syncfusion.Tools.Windows assembly loads the assembly 
			// (you also need to have reference to the Syncfusion.Tools.Windows assembly in your project references)
			// new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();

			// You can also explicitly set the look and feel of the context menu 
			
			// Show Office2003 style context menu
			// this.editControl1.ContextMenuManager.ContextMenuProvider = new Syncfusion.Windows.Forms.Tools.XPMenus.XPMenusProvider();

			// Show standard style context menu
			// this.editControl1.ContextMenuManager.ContextMenuProvider = new Syncfusion.Windows.Forms.StandardMenusProvider();

			// Add a event handler that is called each time the menu is dropped down where you can add custom menu items.
			this.editControl1.MenuFill += new EventHandler(cm_FillMenu);
		}


		private void cm_FillMenu(object sender, EventArgs e)
		{
			ContextMenuManager cm = (ContextMenuManager) sender;
			
			// To clear default context menu items 
			// cm.ClearMenu();

			// Add a separator
			cm.AddSeparator();

			// Add custom custom context menu items and their Click eventhandlers
			cm.AddMenuItem("&Find", new EventHandler(ShowFindDialog));
			cm.AddMenuItem("&Replace", new EventHandler(ShowReplaceDialog));
			cm.AddMenuItem("&Goto", new EventHandler(ShowGoToDialog));

			
			// If you need to get access to the underlying menu provider you can access it via:
			Syncfusion.Windows.Forms.IContextMenuProvider contextMenuProvider = this.editControl1.ContextMenuManager.ContextMenuProvider;
			//	contextMenuProvider.SetContextMenuItemChecked(...);
			//	contextMenuProvider.SetContextMenuItemEnabled(...);
			//	contextMenuProvider.SetContextMenuItemImage(...);
			//	contextMenuProvider.SetContextMenuItemShortcut(...);
		}


		void ShowFindDialog(object sender, EventArgs e)
		{
			this.editControl1.ShowFindDialog();
		}

		void ShowReplaceDialog(object sender, EventArgs e)
		{
			this.editControl1.ShowReplaceDialog();
		}

		void ShowGoToDialog(object sender, EventArgs e)
		{
			this.editControl1.ShowGoToDialog();
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
			this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// editControl1
			// 
			this.editControl1.BackColor = System.Drawing.SystemColors.Window;
			this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.editControl1.Name = "editControl1";
			this.editControl1.ShowIndicatorMargin = false;
			this.editControl1.Size = new System.Drawing.Size(542, 445);
			this.editControl1.StatusBarSettings.CoordsPanel.Width = 148;
			this.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0;
			this.editControl1.StatusBarSettings.EncodingPanel.Width = 165;
			this.editControl1.StatusBarSettings.InsertPanel.Width = 33;
			this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
			this.editControl1.StatusBarSettings.StatusPanel.Width = 70;
			this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.editControl1.StatusBarSettings.TextPanel.Width = 96;
			this.editControl1.TabIndex = 0;
			this.editControl1.Text = "";
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
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem9,
																					  this.menuItem8});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "New";
			this.menuItem2.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Open";
			this.menuItem3.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "-";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "Save";
			this.menuItem5.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "SaveAs";
			this.menuItem6.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 7;
			this.menuItem8.Text = "Exit";
			this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 6;
			this.menuItem9.Text = "Close";
			this.menuItem9.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(542, 445);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Context Menu";
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void MainMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "New" :
					this.editControl1.NewFile();
					break;
				case "Open" :
					this.editControl1.LoadFile();
					break;
				case "Save" :
					this.editControl1.Save();
					break;
				case "SaveAs" :
					this.editControl1.SaveAs();
					break;
				case "Close" :
					this.editControl1.Close();
					break;
				case "Exit" :
					this.Close();
					break;
			}
		}
	}
}
