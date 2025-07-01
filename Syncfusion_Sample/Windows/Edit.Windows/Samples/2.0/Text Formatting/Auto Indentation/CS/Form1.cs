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

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Dialogs;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Enums;


namespace AutoIndentationDemo
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
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
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

			this.Size = new Size(550,500);

			this.editControl1.ShowIndentationGuidelines = false;
			this.editControl1.UseTabs = true;
			this.editControl1.TabSize = 8;
			this.editControl1.TransferFocusOnTab = false;
			this.editControl1.SaveOnClose = false;
			this.editControl1.ApplyConfiguration(KnownLanguages.CSharp);

			this.editControl1.AutoIndentMode = AutoIndentMode.Smart;

			this.editControl1.Text = @"/* Press the Enter key to see the auto-indentation functionality. Chose any desired indentation style from the IndentMenu */";
			this.editControl1.Text += "\n\n" + @"for (int i=0; i<10; i++)
{";
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
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// editControl1
			// 
			this.editControl1.BackColor = System.Drawing.SystemColors.Window;
			this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.editControl1.CurrentColumn = 1;
			this.editControl1.CurrentLine = 1;
			this.editControl1.CurrentPosition = new System.Drawing.Point(1, 1);
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.FileOpened = null;
			this.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
			this.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
			this.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
			this.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.LightBlue;
			this.editControl1.IndentLineColor = System.Drawing.Color.Gray;
			this.editControl1.Name = "editControl1";
			this.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty;
			this.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red;
			this.editControl1.ShowCollapse = true;
			this.editControl1.ShowHorizontalSplitters = false;
			this.editControl1.ShowIndentationGuidelines = false;
			this.editControl1.ShowIndicatorMargin = false;
			this.editControl1.ShowLineNumbers = true;
			this.editControl1.ShowMarkers = false;
			this.editControl1.ShowOutliningCollapsers = true;
			this.editControl1.ShowSelectionMargin = false;
			this.editControl1.ShowVerticalSplitters = false;
			this.editControl1.ShowWhitespaces = false;
			this.editControl1.Size = new System.Drawing.Size(540, 464);
			this.editControl1.TabIndex = 0;
			this.editControl1.TabSize = 2;
			this.editControl1.TabStopsArray = new int[] {
															8,
															16,
															24,
															32,
															40};
			this.editControl1.Text = "editControl1";
			this.editControl1.TextAreaWidth = 600;
			this.editControl1.TransferFocusOnTab = true;
			this.editControl1.UserMarginBackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood);
			this.editControl1.UserMarginWidth = 100;
			this.editControl1.UserMarginTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.editControl1.WordWrap = true;
			this.editControl1.WordWrapMarginBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond);
			this.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black;
			this.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem10});
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
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem11,
																					   this.menuItem12,
																					   this.menuItem13});
			this.menuItem10.Text = "&IndentMode";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Text = "None";
			this.menuItem11.Click += new System.EventHandler(this.IndentMenuClick);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.Text = "Block";
			this.menuItem12.Click += new System.EventHandler(this.IndentMenuClick);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.Text = "Smart";
			this.menuItem13.Click += new System.EventHandler(this.IndentMenuClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(540, 464);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Auto Indentation";
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

		private void IndentMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "None" :
					this.editControl1.AutoIndentMode = AutoIndentMode.None;					
					break;
				case "Block" :
					this.editControl1.AutoIndentMode = AutoIndentMode.Block;					
					break;
				case "Smart" :
					this.editControl1.AutoIndentMode = AutoIndentMode.Smart;					
					break;
			}
		}
	}
}
