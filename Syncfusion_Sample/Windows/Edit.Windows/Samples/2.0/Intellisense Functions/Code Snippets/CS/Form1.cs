using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.IO;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets;
using Syncfusion.XmlSerializersCreator;


namespace CodeSnippetsDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private string csharpsnippetsPath=Path.GetDirectoryName(Application.ExecutablePath)+@"\..\..\Snippets\C#";
		private string vbsnippetsPath=Path.GetDirectoryName(Application.ExecutablePath)+@"\..\..\Snippets\VB";
		private string configPath=Path.GetDirectoryName(Application.ExecutablePath)+@"..\..\..\config.xml";

		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem9;
		private CodeSnippetsContainer container=new Syncfusion.Windows.Forms.Edit.Utils.CodeSnippets.CodeSnippetsContainer();
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			this.editControl1.Configurator.Open(configPath);
			this.editControl1.ApplyConfiguration("C#");
			this.editControl1.Language.SnippetsContainer.RemoveContainer("Container 1");
			this.editControl1.Language.SnippetsContainer.RemoveContainer("Container 2");
			this.editControl1.Language.SnippetsContainer.RemoveSnippet("if");
			this.editControl1.Language.SnippetsContainer.RemoveSnippet("try");
			this.editControl1.Text="/* Choose any desired Code Snippet from the Code Snippets Menu. Press Ctrl + ` to see the Code Snippets. Press Enter to insert the selected Code Snippet into the EditControl*/\n";

			if(Directory.Exists(csharpsnippetsPath))
			{
				CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(csharpsnippetsPath,this.editControl1);
			}
			
		
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
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// editControl1
			// 
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
			this.editControl1.SaveOnClose = false;
			this.editControl1.Size = new System.Drawing.Size(542, 466);
			this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
			this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.editControl1.TabIndex = 0;
			this.editControl1.Text = "";
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
																					  this.menuItem8});
			this.menuItem1.Text = "&File";
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
			this.menuItem4.Text = "&Save";
			this.menuItem4.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "Save &As";
			this.menuItem5.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "-";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "&Close";
			this.menuItem7.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 6;
			this.menuItem8.Text = "E&xit";
			this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 1;
			this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem12,
																					  this.menuItem13});
			this.menuItem9.Text = "Language";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 0;
			this.menuItem12.Text = "C# Snippets";
			this.menuItem12.Click += new System.EventHandler(this.CSharpCodeSnippets_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 1;
			this.menuItem13.Text = "Vb Snippets";
			this.menuItem13.Click += new System.EventHandler(this.VBCodeSnippets_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(542, 466);
			this.Controls.Add(this.editControl1);
			this.Menu = this.mainMenu1;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Name = "Form1";
			this.Text = "Code Snippets";
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
				case "Save &As" :
					this.editControl1.SaveAs();
					break;
				case "&Close" :
					this.editControl1.Close();
					break;
				case "E&xit" :
					this.Close();
					break;
			}
		}

		private void CSharpCodeSnippets_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			
			this.editControl1.ApplyConfiguration("C#");
			RemoveSnippets();
			if(Directory.Exists(csharpsnippetsPath))
			{
				CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(csharpsnippetsPath,this.editControl1);
			}
			
		}
		private void RemoveSnippets()
		{
			ArrayList snippets=this.editControl1.Language.SnippetsContainer.SnippetsNames;
			foreach(string str in snippets)
			{
				this.editControl1.Language.SnippetsContainer.RemoveSnippet(str);
			}
		if ((this.editControl1.Language.SnippetsContainer.ContainersNumber)==1)
				  this.editControl1.Language.SnippetsContainer.RemoveContainer("Loops");
		

		}
		private void VBCodeSnippets_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
            this.editControl1.ApplyConfiguration("VB.NET");
			RemoveSnippets();
			if(Directory.Exists(vbsnippetsPath))
			{				
					CodeSnippetsExtractor.CodeSnippetsExtractor.Extract(vbsnippetsPath,this.editControl1);
			}

		}

		

	}
}
