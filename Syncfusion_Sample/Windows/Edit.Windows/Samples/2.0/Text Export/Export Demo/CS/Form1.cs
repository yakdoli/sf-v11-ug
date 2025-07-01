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
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Enums;

namespace ExportDemo
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
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
        private System.Windows.Forms.MenuItem menuItem19;
        private IContainer components;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		
		private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Form1.cs";		

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.LoadFile(filePath);            			
			this.editControl1.ShowOutliningCollapsers = true;
			this.editControl1.ShowSelectionMargin = false;
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
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.menuItem18 = new System.Windows.Forms.MenuItem();
            this.menuItem19 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 0);
            this.editControl1.Name = "editControl1";
            this.editControl1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.Size = new System.Drawing.Size(542, 445);
            this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
            this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "edtCode";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.VisualColumn = 1;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem12});
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
            this.menuItem14,
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
            // menuItem14
            // 
            this.menuItem14.Index = 6;
            this.menuItem14.Text = "Close";
            this.menuItem14.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 7;
            this.menuItem8.Text = "Exit";
            this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 1;
            this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem17,
            this.menuItem18,
            this.menuItem19,
            this.menuItem9,
            this.menuItem10,
            this.menuItem11,
            this.menuItem13});
            this.menuItem12.Text = "ExportMenu";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 0;
            this.menuItem17.Text = "Save as RTF";
            this.menuItem17.Click += new System.EventHandler(this.ExportMenuClick);
            // 
            // menuItem18
            // 
            this.menuItem18.Index = 1;
            this.menuItem18.Text = "Save as HTML";
            this.menuItem18.Click += new System.EventHandler(this.ExportMenuClick);
            // 
            // menuItem19
            // 
            this.menuItem19.Index = 2;
            this.menuItem19.Text = "Save as XML";
            this.menuItem19.Click += new System.EventHandler(this.ExportMenuClick);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 3;
            this.menuItem9.Text = "-";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 4;
            this.menuItem10.Text = "Get RTF Source";
            this.menuItem10.Click += new System.EventHandler(this.ExportMenuClick);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 5;
            this.menuItem11.Text = "Get HTML Source";
            this.menuItem11.Click += new System.EventHandler(this.ExportMenuClick);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 6;
            this.menuItem13.Text = "Get XML Source";
            this.menuItem13.Click += new System.EventHandler(this.ExportMenuClick);
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
            this.Text = "Export Demo";
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

		private void ExportMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			Form2 sourcecodeDialog = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();  
			switch (mi.Text)
			{
				case "Save as RTF" :                       

                    saveFileDialog.Filter = "RitchTextDocuments (*.rtf)|*.rtf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.editControl1.SaveAsRTF(saveFileDialog.FileName);                         
                    }		
					break;
				case "Save as XML" :
                    saveFileDialog.Filter = "XML Documents (*.xml)|*.xml";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.editControl1.SaveAsXML(saveFileDialog.FileName);
                    }
					break;
				case "Save as HTML" :
                    saveFileDialog.Filter = "HTML Documents (*.html)|*.html";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        this.editControl1.SaveAsHTML(saveFileDialog.FileName);
                    }
					break;
				case "Get RTF Source" :
					sourcecodeDialog = new Form2();
					sourcecodeDialog.SetText(this.editControl1.GetTextAsRTF());
					sourcecodeDialog.Text = "RTF Source Code";	
					sourcecodeDialog.MoveToBeginning();
					sourcecodeDialog.ShowDialog();
					break;
				case "Get XML Source" :
					sourcecodeDialog = new Form2();
					sourcecodeDialog.SetText(this.editControl1.GetTextAsXML());
					sourcecodeDialog.ApplyConfiguration(KnownLanguages.XML);
					sourcecodeDialog.Text = "XML Source Code";
					sourcecodeDialog.MoveToBeginning();
					sourcecodeDialog.ShowDialog();
					break;
				case "Get HTML Source" :
					sourcecodeDialog = new Form2();
					sourcecodeDialog.SetText(this.editControl1.GetTextAsHTML());
					sourcecodeDialog.ApplyConfiguration(KnownLanguages.HTML);
					sourcecodeDialog.Text = "HTML Source Code";
					sourcecodeDialog.MoveToBeginning();
					sourcecodeDialog.ShowDialog();
					break;
			}
		}
	}
}