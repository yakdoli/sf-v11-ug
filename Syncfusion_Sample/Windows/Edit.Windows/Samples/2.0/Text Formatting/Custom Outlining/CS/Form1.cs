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

namespace CustomOutliningDemo
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
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem4;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;		
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;

		private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Test.dat";
		private string configPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\config.xml";

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.LoadFile(filePath);

			this.editControl1.Configurator.Open(configPath);
			this.editControl1.ApplyConfiguration("CustomLanguage");

			this.editControl1.ShowOutliningCollapsers = true;		
			this.editControl1.ShowLineNumbers = true;
			this.editControl1.ShowSelectionMargin = false;
			this.editControl1.ShowVerticalSplitters = false;
			this.editControl1.ShowHorizontalSplitters = false;
			this.editControl1.ShowIndicatorMargin = true;

            this.editControl1.GoTo(83);
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
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
																					  this.menuItem9,
																					  this.menuItem5,
																					  this.menuItem4,
																					  this.menuItem6,
																					  this.menuItem10,
																					  this.menuItem7});
			this.menuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.menuItem2.ShowShortcut = false;
			this.menuItem2.Text = "&New";
			this.menuItem2.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.menuItem3.ShowShortcut = false;
			this.menuItem3.Text = "&Open";
			this.menuItem3.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.menuItem5.ShowShortcut = false;
			this.menuItem5.Text = "&Save";
			this.menuItem5.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 4;
			this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
			this.menuItem4.ShowShortcut = false;
			this.menuItem4.Text = "Save&As";
			this.menuItem4.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 5;
			this.menuItem6.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 7;
			this.menuItem7.Text = "E&xit";
			this.menuItem7.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// editControl1
			// 
			this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
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
			this.editControl1.ShowCollapse = false;
			this.editControl1.ShowHorizontalSplitters = true;
			this.editControl1.ShowIndentationGuidelines = true;
			this.editControl1.ShowIndicatorMargin = false;
			this.editControl1.ShowLineNumbers = false;
			this.editControl1.ShowMarkers = false;
			this.editControl1.ShowOutliningCollapsers = false;
			this.editControl1.ShowVerticalSplitters = true;
			this.editControl1.ShowWhitespaces = false;
			this.editControl1.Size = new System.Drawing.Size(542, 445);
			this.editControl1.TabIndex = 0;
			this.editControl1.TabSize = 2;
			this.editControl1.TabStopsArray = new int[] {
															8,
															16,
															24,
															32,
															40};
			this.editControl1.Text = "";
			this.editControl1.TextAreaWidth = 600;
			this.editControl1.TransferFocusOnTab = true;
			this.editControl1.UserMarginBackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood);
			this.editControl1.UserMarginWidth = 100;
			this.editControl1.UserMarginTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.editControl1.WordWrapMarginBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond);
			this.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black;
			this.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 2;
			this.menuItem9.Text = "-";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 6;
			this.menuItem10.Text = "Close";
			this.menuItem10.Click += new System.EventHandler(this.MainMenuClick);
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
			this.Text = "Custom Outlining";
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
	}
}
