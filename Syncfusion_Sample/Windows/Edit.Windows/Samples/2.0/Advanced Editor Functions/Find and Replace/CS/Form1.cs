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
using System.Diagnostics;
using System.Runtime.InteropServices;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.IO;

using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Edit.Enums;


namespace FindReplaceDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private int i;
		
		private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\CSharpSource.cs";

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.ShowLineNumbers = true;
			this.editControl1.ShowIndicatorMargin = true;
			this.editControl1.ShowOutliningCollapsers = true;			

			this.editControl1.LoadFile(filePath);
			
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem5,
																					  this.menuItem1,
																					  this.menuItem14,
																					  this.menuItem18,
																					  this.menuItem23});
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 0;
			this.menuItem5.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem8,
																					  this.menuItem9,
																					  this.menuItem10,
																					  this.menuItem11,
																					  this.menuItem12,
																					  this.menuItem13});
			this.menuItem5.Text = "File";
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 0;
			this.menuItem6.Text = "New";
			this.menuItem6.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 1;
			this.menuItem7.Text = "Open";
			this.menuItem7.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 2;
			this.menuItem8.Text = "-";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 3;
			this.menuItem9.Text = "Save";
			this.menuItem9.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 4;
			this.menuItem10.Text = "SaveAs";
			this.menuItem10.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 5;
			this.menuItem11.Text = "-";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 6;
			this.menuItem12.Text = "Close";
			this.menuItem12.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 7;
			this.menuItem13.Text = "Exit";
			this.menuItem13.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4});
			this.menuItem1.Text = "Launch Menu";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Find Dialog";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Replace Dialog";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "GoTo Dialog";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 2;
			this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem17,
																					   this.menuItem25,
																					   this.menuItem15,
																					   this.menuItem16});
			this.menuItem14.Text = "Find History";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 0;
			this.menuItem17.Text = "Add To History";
			this.menuItem17.Click += new System.EventHandler(this.FindHistoryMenu_Click);
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 1;
			this.menuItem25.Text = "Remove From History";
			this.menuItem25.Click += new System.EventHandler(this.FindHistoryMenu_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 2;
			this.menuItem15.Text = "Sort History";
			this.menuItem15.Click += new System.EventHandler(this.FindHistoryMenu_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 3;
			this.menuItem16.Text = "Clear History";
			this.menuItem16.Click += new System.EventHandler(this.FindHistoryMenu_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 3;
			this.menuItem18.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem19,
																					   this.menuItem20,
																					   this.menuItem21,
																					   this.menuItem22});
			this.menuItem18.Text = "Replace History";
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 0;
			this.menuItem19.Text = "Add To History";
			this.menuItem19.Click += new System.EventHandler(this.ReplaceHistory_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 1;
			this.menuItem20.Text = "Remove From History";
			this.menuItem20.Click += new System.EventHandler(this.ReplaceHistory_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 2;
			this.menuItem21.Text = "Sort History";
			this.menuItem21.Click += new System.EventHandler(this.ReplaceHistory_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 3;
			this.menuItem22.Text = "Clear History";
			this.menuItem22.Click += new System.EventHandler(this.ReplaceHistory_Click);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 4;
			this.menuItem23.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem24,
																					   this.menuItem26,
																					   this.menuItem27,
																					   this.menuItem28});
			this.menuItem23.Text = "Replace Search History";
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 0;
			this.menuItem24.Text = "Add To History";
			this.menuItem24.Click += new System.EventHandler(this.ReplaceSearchHistory_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 1;
			this.menuItem26.Text = "Remove From History";
			this.menuItem26.Click += new System.EventHandler(this.ReplaceSearchHistory_Click);
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 2;
			this.menuItem27.Text = "Sort History";
			this.menuItem27.Click += new System.EventHandler(this.ReplaceSearchHistory_Click);
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 3;
			this.menuItem28.Text = "Clear History";
			this.menuItem28.Click += new System.EventHandler(this.ReplaceSearchHistory_Click);
			// 
			// editControl1
			// 
			this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
			this.editControl1.BackColor = System.Drawing.SystemColors.Window;
			this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.DropAllFiles = false;
			this.editControl1.FileExtensions = new string[] {
																".cs",
																".htm",
																".html",
																".java",
																".js",
																".pas",
																".sql",
																".vb",
																".vbs",
																".xml"};
			this.editControl1.Name = "editControl1";
			this.editControl1.ShowIndicatorMargin = false;
			this.editControl1.ShowLineNumbers = false;
			this.editControl1.ShowOutliningCollapsers = false;
			this.editControl1.Size = new System.Drawing.Size(542, 445);
			this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
			this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.editControl1.TabIndex = 0;
			this.editControl1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(542, 445);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1});
			this.Menu = this.mainMenu1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Name = "Form1";
			this.Text = "Find and Replace";
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

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.FindDialogOpen();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.ReplaceDialogOpen();
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.GoToDialogOpen();
		}

		private void codeEdit1_RegisteringKeyCommands(object sender, System.EventArgs e)
		{
			this.editControl1.Commands.Add("FindDialog.Open").ProcessCommand += new ProcessCommandEventHandler(FindDialogOpen);
			this.editControl1.Commands.Add("ReplaceDialog.Open").ProcessCommand += new ProcessCommandEventHandler(ReplaceDialogOpen);
			this.editControl1.Commands.Add("GoToDialog.Open").ProcessCommand += new ProcessCommandEventHandler(GoToDialogOpen);			
		}	
	
		private void FindDialogOpen()
		{
			this.editControl1.ShowFindDialog();			
		}

		private void ReplaceDialogOpen()
		{
			this.editControl1.ShowReplaceDialog();			
		}

		private void GoToDialogOpen()
		{
			this.editControl1.ShowGoToDialog();			
		}

		private void codeEdit1_RegisteringDefaultKeyBindings(object sender, System.EventArgs e)
		{
			this.editControl1.KeyBinder.BindToCommand (Keys.Control | Keys.F, "FindDialog.Open");
			this.editControl1.KeyBinder.BindToCommand (Keys.Control | Keys.R, "ReplaceDialog.Open");
			this.editControl1.KeyBinder.BindToCommand (Keys.Control | Keys.G, "GoToDialog.Open");
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


		private void FindHistoryMenu_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "Add To History":
					AddToHistoryDlg ATH=new AddToHistoryDlg();
					if(DialogResult.OK==ATH.ShowDialog())
					{
						this.editControl1.FindHistory.Insert(0,(object)ATH.addedItem);
					}
					break;
				case "Remove From History":
					i=1;
					RemoveHistoryItem r=new RemoveHistoryItem(this.SearchItemList);
					if(DialogResult.OK==r.ShowDialog())
					{
						if(r.RemoveListItems!=null)
						{
							foreach(Object o in r.RemoveListItems)
							{
								this.editControl1.FindHistory.Remove(o);
							}
						}
					}
					break;
				case "Sort History":
					this.editControl1.FindHistory.Sort();
					break;
				case "Clear History":
					this.editControl1.FindHistory.Clear();
					break;
				}

		
		} 

		private void ReplaceHistory_Click  (object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "Add To History":
					AddToHistoryDlg ATH=new AddToHistoryDlg();
					if(DialogResult.OK==ATH.ShowDialog())
					{
						this.editControl1.ReplaceHistory.Insert(0,(object)ATH.addedItem);
					}
					break;
				case "Remove From History":
					i=2;
					RemoveHistoryItem r=new RemoveHistoryItem(this.SearchItemList);
					if(DialogResult.OK==r.ShowDialog())
					{
						if(r.RemoveListItems!=null)
						{
							foreach(Object o in r.RemoveListItems)
							{
								this.editControl1.ReplaceHistory.Remove(o);
							}
						}
					}
					break;
				case "Sort History":
					this.editControl1.ReplaceHistory.Sort();
					break;
				case "Clear History":
					this.editControl1.ReplaceHistory.Clear();
					break;
			}
		
		}

		private void ReplaceSearchHistory_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "Add To History":
					AddToHistoryDlg ATH = new AddToHistoryDlg();
					if(DialogResult.OK == ATH.ShowDialog())
					{
						this.editControl1.ReplaceSearchHistory.Insert(0,(object)ATH.addedItem);
					}
					break;
				case "Remove From History":
					i=3;
					RemoveHistoryItem r = new RemoveHistoryItem(this.SearchItemList);
					if(DialogResult.OK == r.ShowDialog())
					{
						if(r.RemoveListItems!=null)
						{
							foreach(Object o in r.RemoveListItems)
							{
								this.editControl1.ReplaceSearchHistory.Remove(o);
							}
						}
					}
					break;
				case "Sort History":
					this.editControl1.ReplaceSearchHistory.Sort();
					break;
				case "Clear History":
					this.editControl1.ReplaceSearchHistory.Clear();
					
					break;
					
			}
		
		}

		//Properties
		public System.Collections.ArrayList SearchItemList
		{
			
			get
			{
				if(i==1)
				return this.editControl1.FindHistory;
				else if(i==2)
				return this.editControl1.ReplaceHistory;
				else if(i==3)
                return this.editControl1.ReplaceSearchHistory;
				else
					return null;
			}
		}
	}


}
