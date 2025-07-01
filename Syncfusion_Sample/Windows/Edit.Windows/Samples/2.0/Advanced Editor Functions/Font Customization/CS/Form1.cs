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

using Syncfusion.Windows.Forms.Edit.Enums;

namespace FontCustomizationDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.Windows.Forms.Button button1;
		private Syncfusion.Windows.Forms.Edit.Dialogs.ControlLanguageSelector controlLanguageSelector1;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.Edit.Dialogs.ControlFormatsList controlFormatsList1;
		private Syncfusion.Windows.Forms.Edit.Dialogs.ControlFormatsSettings controlFormatsSettings1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
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
        private IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.editControl1.ApplyConfiguration(KnownLanguages.CSharp);
			editControl1.Text = @"// Code used to customize the Formats :
			editControl1.SaveOnClose = false;

#region Windows Form Designer generated code

this.controlLanguageSelector1.EditControl = this.editControl1;

this.controlFormatsList1.EditControl = this.editControl1;
this.controlFormatsList1.LanguageSelector = this.controlLanguageSelector1;

this.controlFormatsSettings1.FormatsSelector = this.controlFormatsList1;

#endregion
";
			
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
            this.label1 = new System.Windows.Forms.Label();
            this.controlLanguageSelector1 = new Syncfusion.Windows.Forms.Edit.Dialogs.ControlLanguageSelector();
            this.button1 = new System.Windows.Forms.Button();
            this.controlFormatsList1 = new Syncfusion.Windows.Forms.Edit.Dialogs.ControlFormatsList();
            this.controlFormatsSettings1 = new Syncfusion.Windows.Forms.Edit.Dialogs.ControlFormatsSettings();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
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
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.OnlyHighlightMatchingBraces = true;
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowSelectionMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(432, 445);
            this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
            this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control used for selecting language:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlLanguageSelector1
            // 
            this.controlLanguageSelector1.Configuration = config1;
            this.controlLanguageSelector1.EditControl = this.editControl1;
            this.controlLanguageSelector1.Location = new System.Drawing.Point(16, 304);
            this.controlLanguageSelector1.Name = "controlLanguageSelector1";
            this.controlLanguageSelector1.Size = new System.Drawing.Size(176, 21);
            this.controlLanguageSelector1.TabIndex = 1;
            this.controlLanguageSelector1.SelectedLanguageChanged += new System.EventHandler(this.controlLanguageSelector1_SelectedLanguageChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(48, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Dialog";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlFormatsList1
            // 
            this.controlFormatsList1.Configuration = config1;
            this.controlFormatsList1.EditControl = this.editControl1;
            this.controlFormatsList1.LanguageSelector = this.controlLanguageSelector1;
            this.controlFormatsList1.Location = new System.Drawing.Point(8, 32);
            this.controlFormatsList1.Name = "controlFormatsList1";
            this.controlFormatsList1.SelectedFormats = null;
            this.controlFormatsList1.Size = new System.Drawing.Size(200, 224);
            this.controlFormatsList1.TabIndex = 3;
            // 
            // controlFormatsSettings1
            // 
            this.controlFormatsSettings1.Formats = null;
            this.controlFormatsSettings1.FormatsSelector = this.controlFormatsList1;
            this.controlFormatsSettings1.Location = new System.Drawing.Point(224, 40);
            this.controlFormatsSettings1.Name = "controlFormatsSettings1";
            this.controlFormatsSettings1.Size = new System.Drawing.Size(336, 384);
            this.controlFormatsSettings1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Control for selecting language\'s format(s):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(248, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Control for editing selected formats:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.controlFormatsSettings1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.controlFormatsList1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.controlLanguageSelector1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(432, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 445);
            this.panel2.TabIndex = 3;
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
            this.menuItem8,
            this.menuItem9});
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
            this.menuItem8.Index = 6;
            this.menuItem8.Text = "Close";
            this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 7;
            this.menuItem9.Text = "Exit";
            this.menuItem9.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1000, 445);
            this.Controls.Add(this.editControl1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font Customization";
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            this.panel2.ResumeLayout(false);
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

		private void controlLanguageSelector1_SelectedLanguageChanged(object sender, System.EventArgs e)
		{
			// Changes configuration language currently used control.
			editControl1.Language = controlLanguageSelector1.SelectedLanguage;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			// Shows the font customization dialog
			editControl1.ShowFormatsCustomizationDialog();
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
