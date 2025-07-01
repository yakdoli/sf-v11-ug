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

namespace SyntaxColoringDemo
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
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
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
        private IContainer components;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;

		private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\";
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.ShowOutliningCollapsers = true;
			this.editControl1.LoadFile(BasePath + "\\CSharpSource.cs");
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem20 = new System.Windows.Forms.MenuItem();
            this.menuItem21 = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem22 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem23 = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.menuItem25 = new System.Windows.Forms.MenuItem();
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem13,
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 0;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem14,
            this.menuItem15,
            this.menuItem16,
            this.menuItem17,
            this.menuItem18,
            this.menuItem19,
            this.menuItem20,
            this.menuItem21});
            this.menuItem13.Text = "File";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 0;
            this.menuItem14.Text = "New";
            this.menuItem14.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 1;
            this.menuItem15.Text = "Open";
            this.menuItem15.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 2;
            this.menuItem16.Text = "-";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 3;
            this.menuItem17.Text = "Save";
            this.menuItem17.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 4;
            this.menuItem18.Text = "SaveAs";
            this.menuItem18.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 5;
            this.menuItem19.Text = "-";
            // 
            // menuItem20
            // 
            this.menuItem20.Index = 6;
            this.menuItem20.Text = "Close";
            this.menuItem20.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // menuItem21
            // 
            this.menuItem21.Index = 7;
            this.menuItem21.Text = "Exit";
            this.menuItem21.Click += new System.EventHandler(this.FileMenuClick);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem11,
            this.menuItem12});
            this.menuItem1.Text = "Configuration Menu";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 0;
            this.menuItem11.Text = "Launch Configuration Editor";
            this.menuItem11.Click += new System.EventHandler(this.ConfigurationMenuClick);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.Text = "Launch Configuration Display Utility";
            this.menuItem12.Click += new System.EventHandler(this.ConfigurationMenuClick);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 2;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem6,
            this.menuItem7,
            this.menuItem22,
            this.menuItem8,
            this.menuItem9,
            this.menuItem10,
            this.menuItem23,
            this.menuItem24,
            this.menuItem25});
            this.menuItem2.Text = "Code Samples";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "CSharp";
            this.menuItem3.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "HTML";
            this.menuItem4.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "XML";
            this.menuItem5.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 3;
            this.menuItem6.Text = "Pascal";
            this.menuItem6.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            this.menuItem7.Text = "HTML with embedded JScript";
            this.menuItem7.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem22
            // 
            this.menuItem22.Index = 5;
            this.menuItem22.Text = "HTML with embedded VBScript";
            this.menuItem22.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 6;
            this.menuItem8.Text = "Delphi";
            this.menuItem8.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 7;
            this.menuItem9.Text = "VB.NET";
            this.menuItem9.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 8;
            this.menuItem10.Text = "SQL";
            this.menuItem10.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem23
            // 
            this.menuItem23.Index = 9;
            this.menuItem23.Text = "Java";
            this.menuItem23.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 10;
            this.menuItem24.Text = "VBScript";
            this.menuItem24.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // menuItem25
            // 
            this.menuItem25.Index = 11;
            this.menuItem25.Text = "JScript";
            this.menuItem25.Click += new System.EventHandler(this.CodeSamplesMenuClick);
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(542, 425);
            this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
            this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.MenuFill += new System.EventHandler(this.editControl1_MenuFill);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(542, 425);
            this.Controls.Add(this.editControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syntax Coloring";
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

		private void CodeSamplesMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "CSharp" :
					this.editControl1.LoadFile(BasePath + "\\CSharpSource.cs");
					break;
				case "HTML" :
					this.editControl1.LoadFile(BasePath + "\\HTMLSource.html");
					break;
				case "XML" :
					this.editControl1.LoadFile(BasePath + "\\XMLSource.xml");
					break;
				case "Pascal" :
                    this.editControl1.LoadFile(BasePath + "\\PascalSource.pas");
					break;
				case "HTML with embedded JScript" :
					this.editControl1.LoadFile(BasePath + "\\HTML_JScript.html");
					break;
				case "Delphi" :
					this.editControl1.LoadFile(BasePath + "\\DelphiSource.pas");
					break;
				case "VB.NET" :
					this.editControl1.LoadFile(BasePath + "\\VBSource.vb");
					break;
				case "SQL" :
					this.editControl1.LoadFile(BasePath + "\\SQLSource.sql");
					break;
				case "HTML with embedded VBScript" :
					this.editControl1.LoadFile(BasePath + "\\HTML_VBScript.html");
					break;
				case "Java" :
					this.editControl1.LoadFile(BasePath + "\\JavaSource.Java");
					break;
				case "VBScript" :
					this.editControl1.LoadFile(BasePath + "\\VBScriptSource.vbs");
					this.editControl1.ApplyConfiguration(KnownLanguages.VBScript);
					break;
				case "JScript" :
					this.editControl1.LoadFile(BasePath + "\\JScriptSource.js");
					this.editControl1.ApplyConfiguration(KnownLanguages.JScript);
					break;
			}
		}

		
		private void ConfigurationMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "Launch Configuration Editor" :
					try
					{
						IConfigLanguage activeLang = this.editControl1.Parser.Formats as IConfigLanguage;

						ConfigurationDialog editConfig = new ConfigurationDialog( this.editControl1.Configurator,
							activeLang );
        
						if( editConfig.ShowDialog( this ) == DialogResult.OK && activeLang != null )
						{
							IConfigLanguage newLang = editConfig.Configurator.KnownLanguageNames.Contains( activeLang.Language ) ?  
								editConfig.Configurator[ activeLang.Language ] : editConfig.Configurator.DefaultLanguage;

							if( newLang != null )
							{
								this.editControl1.Configurator = editConfig.Configurator;
								this.editControl1.ApplyConfiguration(newLang);
							}
						}
					}
					catch( ArgumentException ex )
					{
						Debug.WriteLine( ex.Message + Environment.NewLine + ex.StackTrace );
						throw;
					}
					break;

				case "Launch Configuration Display Utility" :
					Form2 configForm = new Form2();
					configForm.ShowDialog();
					break;
			}
		}

		private void FileMenuClick(object sender, System.EventArgs e)
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

		private void editControl1_MenuFill(object sender, System.EventArgs e)
		{
			ContextMenuManager contextMenu = (ContextMenuManager) sender;
                        
			// Add a separator
			contextMenu.AddSeparator();

			// Add custom custom context menu items and their Click eventhandlers
			contextMenu.AddMenuItem("Launch Configuration Editor", new EventHandler(ConfigurationEditorLaunch));
			contextMenu.AddMenuItem("Launch Configuration Display Utility", new EventHandler(ConfigurationDisplayLaunch));
		}

		private void ConfigurationEditorLaunch (object sender, System.EventArgs e)
		{
			try
			{
				IConfigLanguage activeLang = this.editControl1.Parser.Formats as IConfigLanguage;

                ConfigurationDialog editConfig = new ConfigurationDialog(this.editControl1.Configurator,
					activeLang );
        
				if( editConfig.ShowDialog( this ) == DialogResult.OK && activeLang != null )
				{
					IConfigLanguage newLang = editConfig.Configurator.KnownLanguageNames.Contains( activeLang.Language ) ?  
						editConfig.Configurator[activeLang.Language] : editConfig.Configurator.DefaultLanguage;

					if( newLang != null )
					{
						this.editControl1.Configurator = editConfig.Configurator;
						this.editControl1.ApplyConfiguration (newLang);
					}
				}
			}
			catch( ArgumentException ex )
			{
				Debug.WriteLine( ex.Message + Environment.NewLine + ex.StackTrace );
				throw;
			}
		}

		private void ConfigurationDisplayLaunch (object sender, System.EventArgs e)
		{
			Form2 configForm = new Form2();
			configForm.ShowDialog();
		}
	}
}
