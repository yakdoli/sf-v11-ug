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

namespace TextHandlingDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private IContainer components = null;

		private Form2 inputDialog;
        private string inputString = string.Empty;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem setTextToolStripMenuItem;
        private ToolStripMenuItem appendTextToolStripMenuItem;
        private ToolStripMenuItem insertTextToolStripMenuItem;
        private ToolStripMenuItem deleteAllToolStripMenuItem;
        private ToolStripMenuItem deleteSelectionToolStripMenuItem;
		private bool accepted = false;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			inputDialog = new Form2();
			inputDialog.AcceptButton.Click += new EventHandler (AcceptButton_Clicked);
			inputDialog.CancelButton.Click += new EventHandler (CancelButton_Clicked);
		}

		private void AcceptButton_Clicked (object sender, EventArgs args)
		{
			this.inputString = this.inputDialog.InputString;
			this.accepted = true;
			this.inputDialog.Close();
		}

		private void CancelButton_Clicked (object sender, EventArgs args)
		{
			this.accepted = false;
			this.inputDialog.Close();
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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appendTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editControl1
            // 
            this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
            this.editControl1.BackColor = System.Drawing.SystemColors.Window;
            this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.editControl1.Configurator = config1;
            this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editControl1.LineNumbersFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editControl1.Location = new System.Drawing.Point(0, 24);
            this.editControl1.Name = "editControl1";
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowLineNumbers = false;
            this.editControl1.ShowOutliningCollapsers = false;
            this.editControl1.Size = new System.Drawing.Size(542, 421);
            this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
            this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setTextToolStripMenuItem,
            this.appendTextToolStripMenuItem,
            this.insertTextToolStripMenuItem,
            this.deleteAllToolStripMenuItem,
            this.deleteSelectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Save As...";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // setTextToolStripMenuItem
            // 
            this.setTextToolStripMenuItem.Name = "setTextToolStripMenuItem";
            this.setTextToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.setTextToolStripMenuItem.Text = "SetText";
            this.setTextToolStripMenuItem.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // appendTextToolStripMenuItem
            // 
            this.appendTextToolStripMenuItem.Name = "appendTextToolStripMenuItem";
            this.appendTextToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.appendTextToolStripMenuItem.Text = "AppendText";
            this.appendTextToolStripMenuItem.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // insertTextToolStripMenuItem
            // 
            this.insertTextToolStripMenuItem.Name = "insertTextToolStripMenuItem";
            this.insertTextToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.insertTextToolStripMenuItem.Text = "InsertText";
            this.insertTextToolStripMenuItem.Click += new System.EventHandler(this.menuItem11_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.deleteAllToolStripMenuItem.Text = "DeleteAll";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.menuItem12_Click);
            // 
            // deleteSelectionToolStripMenuItem
            // 
            this.deleteSelectionToolStripMenuItem.Name = "deleteSelectionToolStripMenuItem";
            this.deleteSelectionToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.deleteSelectionToolStripMenuItem.Text = "DeleteSelection";
            this.deleteSelectionToolStripMenuItem.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(542, 445);
            this.Controls.Add(this.editControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Handling";
            ((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        private void MainMenuClick(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            switch (mi.Text)
            {
                case "New":
                    editControl1.NewFile();
                    break;
                case "Open...":
                    editControl1.LoadFile();
                    break;
                case "Save":
                    editControl1.Save();
                    break;
                case "Save As...":
                    editControl1.SaveAs();
                    break;
                case "Exit":
                    Close();
                    break;
            }
        }

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			this.inputDialog.ShowDialog();

			if (this.accepted)
			{
				this.editControl1.Text = this.inputString;
			}
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			this.inputDialog.ShowDialog();		

			if (this.accepted)
			{
				this.editControl1.AppendText(this.inputString);
			}
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			this.inputDialog.ShowDialog();	
	
			if (this.accepted)
			{
				this.editControl1.InsertText(this.editControl1.CurrentLine, this.editControl1.CurrentColumn, this.inputString);
			}
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			this.editControl1.DeleteAll();
		}

		private void menuItem13_Click(object sender, System.EventArgs e)
		{
            if (editControl1.Selection != null)
                this.editControl1.DeleteText(this.editControl1.Selection.Top, this.editControl1.Selection.Bottom);
            else
                MessageBox.Show("Please select the text to be deleted");
		}

       
	}
}
