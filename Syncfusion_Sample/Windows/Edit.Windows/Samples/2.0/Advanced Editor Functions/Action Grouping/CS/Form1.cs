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
using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.IO;

namespace ActionGroupingDemo
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
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem OpenGroupMenu;
		private System.Windows.Forms.MenuItem CloseGroupMenu;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem UndoMenu;
		private System.Windows.Forms.MenuItem RedoMenu;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem CancelGroupMenu;
		private System.Windows.Forms.MenuItem SavePointMenu;
        private System.Windows.Forms.MenuItem menuItem17;
        private IContainer components;

		private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\CSharpSource.cs";


		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.ShowOutliningCollapsers = true;
			this.editControl1.ShowIndicatorMargin = true;            
			this.Size = new Size(550,500);

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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.OpenGroupMenu = new System.Windows.Forms.MenuItem();
            this.CloseGroupMenu = new System.Windows.Forms.MenuItem();
            this.CancelGroupMenu = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.UndoMenu = new System.Windows.Forms.MenuItem();
            this.RedoMenu = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.SavePointMenu = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.Configurator = config1;
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
            this.editControl1.Location = new System.Drawing.Point(0, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.PseudoFileName = "";
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(542, 445);
            this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
            this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.WordWrap = true;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem9});
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
            this.menuItem17,
            this.menuItem8});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "&New";
            this.menuItem2.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "&Open";
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
            this.menuItem5.Text = "&Save";
            this.menuItem5.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "Save&As";
            this.menuItem6.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 5;
            this.menuItem7.Text = "-";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 6;
            this.menuItem17.Text = "Close";
            this.menuItem17.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 7;
            this.menuItem8.Text = "E&xit";
            this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.OpenGroupMenu,
            this.CloseGroupMenu,
            this.CancelGroupMenu,
            this.menuItem12,
            this.UndoMenu,
            this.RedoMenu,
            this.menuItem15,
            this.SavePointMenu});
            this.menuItem9.Text = "ActionMenu";
            this.menuItem9.Select += new System.EventHandler(this.menuItem9_Select);
            // 
            // OpenGroupMenu
            // 
            this.OpenGroupMenu.Index = 0;
            this.OpenGroupMenu.Text = "Open Group";
            this.OpenGroupMenu.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // CloseGroupMenu
            // 
            this.CloseGroupMenu.Enabled = false;
            this.CloseGroupMenu.Index = 1;
            this.CloseGroupMenu.Text = "Close Group";
            this.CloseGroupMenu.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // CancelGroupMenu
            // 
            this.CancelGroupMenu.Enabled = false;
            this.CancelGroupMenu.Index = 2;
            this.CancelGroupMenu.Text = "Cancel Group";
            this.CancelGroupMenu.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            this.menuItem12.Text = "-";
            // 
            // UndoMenu
            // 
            this.UndoMenu.Index = 4;
            this.UndoMenu.Text = "Undo";
            this.UndoMenu.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // RedoMenu
            // 
            this.RedoMenu.Index = 5;
            this.RedoMenu.Text = "Redo";
            this.RedoMenu.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 6;
            this.menuItem15.Text = "-";
            // 
            // SavePointMenu
            // 
            this.SavePointMenu.Index = 7;
            this.SavePointMenu.Text = "Introduce Save Point";
            this.SavePointMenu.Click += new System.EventHandler(this.ActionMenuClick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(542, 445);
            this.Controls.Add(this.editControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Action Grouping";
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
				case "&New" :
					this.editControl1.NewFile();
					break;
				case "&Open" :
					this.editControl1.LoadFile();
					break;
				case "&Save" :
					this.editControl1.Save();
					break;
				case "Save&As" :
					this.editControl1.SaveAs();
					break;
				case "Close" :
					this.editControl1.Close();
					break;
				case "E&xit" :
					this.Close();
					break;
			}
		}

		private void ActionMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "Open Group" :
					try
					{
					this.editControl1.UndoGroupOpen();
                    this.CloseGroupMenu.Enabled = true;
                    this.CancelGroupMenu.Enabled = true;
                    this.OpenGroupMenu.Enabled = false;

					}
					catch(Exception ex)
					{
						Console.WriteLine(ex.Message);
					}

					break;
				case "Close Group" :
					try
					{
						this.editControl1.UndoGroupClose();
                        this.CloseGroupMenu.Enabled = false;
                        this.CancelGroupMenu.Enabled = false;
                        this.OpenGroupMenu.Enabled = true;
					}
					catch(Exception ex)
					{
                        MessageBox.Show(ex.Message, "Alert");
					}
					break;
				case "Cancel Group" :
					try
					{
					this.editControl1.UndoGroupCancel();
                    this.CloseGroupMenu.Enabled = false;
                    this.CancelGroupMenu.Enabled = false;
                    this.OpenGroupMenu.Enabled = true;
					}
					catch(Exception ex)
					{						
						MessageBox.Show(ex.Message,"Alert");
					}
					break;
				case "Undo" :
					this.editControl1.Undo();
					break;
				case "Redo" :
					this.editControl1.Redo();					
					break;
				case "Introduce Save Point" :
					this.editControl1.ResetUndoInfo();
					break;
			}
		}

        private void menuItem9_Select(object sender, EventArgs e)
        {
             UndoMenu.Enabled =this.editControl1.CanUndo;
             RedoMenu.Enabled = this.editControl1.CanRedo;
          
        }
	}
}
