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
using System.Runtime.InteropServices;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Utils;

namespace XPThemesDemo
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
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;

		private string configPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.SplitFourQuadrants();
			this.editControl1.WordWrap = false;
			this.editControl1.SaveOnClose = false;
            this.editControl1.Configurator.Open(configPath);
            this.editControl1.ApplyConfiguration("CustomLanguage");
			this.editControl1.Text = @"protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}";


			int index=0;
			foreach (Image img in this.imageList1.Images)
			{
				// Populating images using an external ImageList
				this.editControl1.ContextChoiceController.AddImage("Image"+index.ToString(), img);
				index++;
			}
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
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editControl1.Configurator = config1;
            this.editControl1.Location = new System.Drawing.Point(16, 16);
            this.editControl1.Name = "editControl1";
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.Size = new System.Drawing.Size(504, 392);
            this.editControl1.StatusBarSettings.CoordsPanel.MinWidth = 10;
            this.editControl1.StatusBarSettings.InsertPanel.MinWidth = 10;
            this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
            this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.editControl1.StatusBarSettings.TextPanel.MinWidth = 10;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "editControl1";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            this.editControl1.ContextChoiceOpen += new Syncfusion.Windows.Forms.Edit.ContextChoiceEventHandler(this.editControl1_ContextChoiceOpen);
            this.editControl1.ContextPromptOpen += new Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventHandler(this.editControl1_ContextPromptOpen);
            this.editControl1.ContextChoiceClose += new Syncfusion.Windows.Forms.Edit.ContextChoiceCloseEventHandler(this.editControl1_ContextChoiceClose);
            this.editControl1.UpdateContextToolTip += new Syncfusion.Windows.Forms.Edit.UpdateTooltipEventHandler(this.editControl1_UpdateContextToolTip);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem10,
            this.menuItem11,
            this.menuItem15,
            this.menuItem16});
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
            // menuItem9
            // 
            this.menuItem9.Index = 6;
            this.menuItem9.Text = "Close";
            this.menuItem9.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 7;
            this.menuItem8.Text = "Exit";
            this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "ToggleXPThemes";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem12,
            this.menuItem13,
            this.menuItem14});
            this.menuItem11.Text = "IntellisensePopups";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 0;
            this.menuItem12.Text = "Context Tooltip";
            this.menuItem12.Click += new System.EventHandler(this.IntellisensePopupsClick);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 1;
            this.menuItem13.Text = "Context Choice";
            this.menuItem13.Click += new System.EventHandler(this.IntellisensePopupsClick);
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 2;
            this.menuItem14.Text = "Context Prompt";
            this.menuItem14.Click += new System.EventHandler(this.IntellisensePopupsClick);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 3;
            this.menuItem15.Text = "Borders";
            this.menuItem15.Click += new System.EventHandler(this.BordersMenuClick);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 4;
            this.menuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem18,
            this.menuItem19,
            this.menuItem17});
            this.menuItem16.Text = "Splitters";
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 0;
            this.menuItem18.Text = "Split Vertically";
            this.menuItem18.Click += new System.EventHandler(this.SplittersMenuClick);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 1;
            this.menuItem19.Text = "Split Horizontally";
            this.menuItem19.Click += new System.EventHandler(this.SplittersMenuClick);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 2;
            this.menuItem17.Text = "Split into Quadrants";
            this.menuItem17.Click += new System.EventHandler(this.SplittersMenuClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 423);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(542, 22);
            this.statusBar1.TabIndex = 1;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 525;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(542, 445);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.editControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Themes Support";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
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
			this.statusBar1.Panels[0].Text = "";
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

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			this.editControl1.UseXPStyle = !this.editControl1.UseXPStyle;
		}

		private void editControl1_UpdateContextToolTip(object sender, Syncfusion.Windows.Forms.Edit.UpdateTooltipEventArgs e)
		{
			if( e.Text == string.Empty )  
			{  
				Point pointVirtual = editControl1.PointToVirtualPosition( new Point( e.X, e.Y ) );  
 
				if( pointVirtual.Y > 0 )  
				{  
					// Get the current line  
					ILexemLine line = editControl1.GetLine( pointVirtual.Y );  
 
					if( line != null )  
					{  
						// Get tokens from the current line  
						ILexem lexem = line.FindLexemByColumn( pointVirtual.X );  
 
						if( lexem != null )  
						{  
							IConfigLexem configLexem = lexem.Config as IConfigLexem; 
							string formatName = configLexem.Format.Name; 
							e.Text = "This is a " + formatName + " : " + lexem.Text;  
						}  
					}  
				}  
			}  
		}

		private void IntellisensePopupsClick(object sender, System.EventArgs e)
		{	
			this.statusBar1.Panels[0].Text="";
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "Context Tooltip" :
					this.editControl1.ShowContextTooltip = true;
					this.statusBar1.Panels[0].Text = "Move the mouse over the text in the EditControl to see the Context Tooltip";
					break;
				case "Context Choice" :
					
					this.editControl1.ShowContextTooltip = false;		
					this.editControl1.SplitHorizontally();
					this.editControl1.HorizontalSplitterPosition = 0;
					this.editControl1.Text = "\n\nthis.editControl1.";

					this.editControl1.ShowContextChoice();
					break;
				case "Context Prompt" :
				
					this.editControl1.ShowContextTooltip = false;		
					this.editControl1.SplitHorizontally();
					this.editControl1.HorizontalSplitterPosition = 0;
					this.editControl1.Text = "\n\nthis.editControl1.Find(";				
					this.editControl1.ShowContextPrompt();
					break;
			}
		}

		private void editControl1_ContextChoiceOpen(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller)
		{
			controller.Items.Add("Copy", "This is Copy", this.editControl1.ContextChoiceController.Images["Image1"]);
			controller.Items.Add("Cut", "This is Cut", this.editControl1.ContextChoiceController.Images["Image2"]);    
			controller.Items.Add("Paste", "This is Paste", this.editControl1.ContextChoiceController.Images["Image5"]);
			controller.Items.Add("Find", "This is Find", this.editControl1.ContextChoiceController.Images["Image3"]);
			controller.Items.Add("Replace", "This is Replace", this.editControl1.ContextChoiceController.Images["Image6"]);
			controller.Items.Add("Open", "This is Open", this.editControl1.ContextChoiceController.Images["Image4"]);     
			controller.Items.Add("Save", "This is Save", this.editControl1.ContextChoiceController.Images["Image7"]);     
			controller.Items.Add("Test", "This is Test", this.editControl1.ContextChoiceController.Images["Image8"]);     
			controller.Items.Add("Bookmark", "This is Bookmark", this.editControl1.ContextChoiceController.Images["Image0"]);     
		}

		private void editControl1_ContextPromptOpen(object sender, Syncfusion.Windows.Forms.Edit.ContextPromptUpdateEventArgs e)
		{
			e.AddPrompt( "Find()", "Display the Find dialog" );
			e.AddPrompt( "Find(string searchText)", "Find occurences of the specified search text" );
			e.AddPrompt( "Find(string searchText, bool searchUp)", "Find occurences of the specified search text and search up if specified" );				
		}

		private void editControl1_ContextChoiceClose(Syncfusion.Windows.Forms.Edit.Interfaces.IContextChoiceController controller, System.Windows.Forms.DialogResult dialogresult)
		{
			controller.Items.Clear();
		}

		private void BordersMenuClick(object sender, System.EventArgs e)
		{		
			this.statusBar1.Panels[0].Text = "The borders have a themed appearance while using FixedSingle style in themed mode";
		}

		private void SplittersMenuClick(object sender, System.EventArgs e)
		{
			this.statusBar1.Panels[0].Text = "";
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "Split Vertically" :
					this.editControl1.SplitVertically();
					break;
				case "Split Horizontally" :
					this.editControl1.SplitHorizontally();
					break;
				case "Split into Quadrants" :
					this.editControl1.SplitFourQuadrants();
					break;
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
	}
}
