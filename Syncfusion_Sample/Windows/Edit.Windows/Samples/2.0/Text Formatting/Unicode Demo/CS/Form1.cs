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

namespace UnicodeDemo
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
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;/// <summary>
		private System.Windows.Forms.MenuItem menuItem17;
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private string ChinesePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Chinese.txt";
		private string ArabicPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Arabic.txt";
		private string GreekPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Greek.txt";
		private string HindiPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Hindi.txt";
		private string RussianPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Russian.txt";
		private string JapanesePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Japanese.txt";
		private string HebrewPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Hebrew.txt";


		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.StatusBarSettings.TextPanel.Panel.Alignment = HorizontalAlignment.Left;
			this.editControl1.StatusBarSettings.TextPanel.Panel.Text = "Note that the required fonts must be installed on your machine for EditControl to display it correctly.";
			
			this.editControl1.LoadFile(RussianPath);			
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
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// editControl1
			// 
			this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
			this.editControl1.BackColor = System.Drawing.SystemColors.Window;
			this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.editControl1.ColumnGuideItems = new Syncfusion.Windows.Forms.Edit.Utils.ColumnGuideItem[0];
			this.editControl1.ColumnGuidesMeasuringFont = new System.Drawing.Font("Courier New", 10F);
			this.editControl1.ContextChoiceSize = new System.Drawing.Size(176, 88);
			this.editControl1.ContextPromptBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.LemonChiffon);
			this.editControl1.ContextPromptCustomSize = new System.Drawing.Size(400, 50);
			this.editControl1.ContextTooltipBackgroundBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.LemonChiffon);
			this.editControl1.CurrentColumn = 1;
			this.editControl1.CurrentLine = 1;
			this.editControl1.CurrentPosition = new System.Drawing.Point(1, 1);
			this.editControl1.CustomLineWrappingMarkingImage = null;
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.FileOpened = null;
			this.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
			this.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
			this.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
			this.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.LightBlue;
			this.editControl1.IndentLineColor = System.Drawing.Color.Gray;
			this.editControl1.LineNumbersColor = System.Drawing.Color.DarkBlue;
			this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
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
			this.editControl1.Size = new System.Drawing.Size(542, 466);
			this.editControl1.StatusBarSettings.CoordsPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.editControl1.StatusBarSettings.CoordsPanel.MinWidth = 10;
			this.editControl1.StatusBarSettings.CoordsPanel.Visible = false;
			this.editControl1.StatusBarSettings.CoordsPanel.Width = 148;
			this.editControl1.StatusBarSettings.EncodingPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0;
			this.editControl1.StatusBarSettings.EncodingPanel.Visible = false;
			this.editControl1.StatusBarSettings.EncodingPanel.Width = 165;
			this.editControl1.StatusBarSettings.InsertPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.editControl1.StatusBarSettings.InsertPanel.MinWidth = 10;
			this.editControl1.StatusBarSettings.InsertPanel.Visible = false;
			this.editControl1.StatusBarSettings.InsertPanel.Width = 33;
			this.editControl1.StatusBarSettings.StatusPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents;
			this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
			this.editControl1.StatusBarSettings.StatusPanel.Visible = false;
			this.editControl1.StatusBarSettings.StatusPanel.Width = 70;
			this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.editControl1.StatusBarSettings.TextPanel.MinWidth = 10;
			this.editControl1.StatusBarSettings.TextPanel.Visible = true;
			this.editControl1.StatusBarSettings.TextPanel.Width = 522;
			this.editControl1.StatusBarSettings.Visible = true;
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
			this.editControl1.UserMarginBackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood);
			this.editControl1.UserMarginTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(204)));
			this.editControl1.UserMarginWidth = 100;
			this.editControl1.WordWrap = true;
			this.editControl1.WordWrapMarginBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond);
			this.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black;
			this.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem14});
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
			// menuItem14
			// 
			this.menuItem14.Index = 1;
			this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem9,
																					   this.menuItem13,
																					   this.menuItem10,
																					   this.menuItem12,
																					   this.menuItem11,
																					   this.menuItem15,
																					   this.menuItem16});
			this.menuItem14.Text = "LanguagesMenu";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Text = "Chinese";
			this.menuItem9.Click += new System.EventHandler(this.LanguageMenuClick);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 1;
			this.menuItem13.Text = "Greek";
			this.menuItem13.Click += new System.EventHandler(this.LanguageMenuClick);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 2;
			this.menuItem10.Text = "Arabic";
			this.menuItem10.Click += new System.EventHandler(this.LanguageMenuClick);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 3;
			this.menuItem12.Text = "Russian";
			this.menuItem12.Click += new System.EventHandler(this.LanguageMenuClick);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 4;
			this.menuItem11.Text = "Hindi";
			this.menuItem11.Click += new System.EventHandler(this.LanguageMenuClick);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 5;
			this.menuItem15.Text = "Japanese";
			this.menuItem15.Click += new System.EventHandler(this.LanguageMenuClick);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 6;
			this.menuItem16.Text = "Hebrew";
			this.menuItem16.Click += new System.EventHandler(this.LanguageMenuClick);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 6;
			this.menuItem17.Text = "Close";
			this.menuItem17.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(542, 466);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Unicode Demo";
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

		private void LanguageMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "Hindi" :
					this.editControl1.LoadFile(HindiPath);
					break;
				case "Russian" :
					this.editControl1.LoadFile(RussianPath);
					break;
				case "Chinese" :
					this.editControl1.LoadFile(ChinesePath);
					break;
				case "Arabic" :
					this.editControl1.LoadFile(ArabicPath);
					break;
				case "Japanese" :
					this.editControl1.LoadFile(JapanesePath);
					break;
				case "Hebrew" :
					this.editControl1.LoadFile(HebrewPath);
					break;
				case "Greek" :
					this.editControl1.LoadFile(GreekPath);				
					break;
			}
		}
	}
}
