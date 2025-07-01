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

namespace SelectionMarginDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem nwToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem selectionMarginToolStripMenuItem;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem foregroundColorItem;
        private ToolStripMenuItem marginWidthToolStripMenuItem;
        private ToolStripMenuItem changedLineMarkingToolStripMenuItem;
        private ToolStripMenuItem enableItItem;
        private ToolStripMenuItem changedLineColorItem;
        private ToolStripMenuItem savedLinesColorItem;
        private ColorDialog colorDialog;
        private ToolStripComboBox ChangeMarginCombo;
        private IContainer components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.SelectionMarginBackgroundColor = Color.LightBlue;
			this.editControl1.SelectionMarginForegroundColor = Color.Gray;
			this.editControl1.LoadFile("..\\..\\Test Files\\Test.cs");
			this.editControl1.ApplyConfiguration("C#");
            this.editControl1.MarkChangedLines = true;
            this.ChangeMarginCombo.SelectedIndex = 0;
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
            this.nwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionMarginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foregroundColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marginWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeMarginCombo = new System.Windows.Forms.ToolStripComboBox();
            this.changedLineMarkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableItItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changedLineColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedLinesColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
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
            this.editControl1.ShowHorizontalSplitters = false;
            this.editControl1.ShowIndicatorMargin = false;
            this.editControl1.ShowVerticalSplitters = false;
            this.editControl1.Size = new System.Drawing.Size(542, 421);
            this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
            this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.editControl1.TabIndex = 0;
            this.editControl1.Text = "editControl1";
            this.editControl1.TransferFocusOnTab = true;
            this.editControl1.VisualColumn = 1;
            this.editControl1.WordWrap = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.selectionMarginToolStripMenuItem,
            this.changedLineMarkingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nwToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.closeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nwToolStripMenuItem
            // 
            this.nwToolStripMenuItem.Name = "nwToolStripMenuItem";
            this.nwToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nwToolStripMenuItem.Text = "New";
            this.nwToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
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
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MainMenuClick);
            // 
            // selectionMarginToolStripMenuItem
            // 
            this.selectionMarginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.foregroundColorItem,
            this.marginWidthToolStripMenuItem});
            this.selectionMarginToolStripMenuItem.Name = "selectionMarginToolStripMenuItem";
            this.selectionMarginToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.selectionMarginToolStripMenuItem.Text = "Selection Margin";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color...";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.SetBackgroundColor);
            // 
            // foregroundColorItem
            // 
            this.foregroundColorItem.Name = "foregroundColorItem";
            this.foregroundColorItem.Size = new System.Drawing.Size(181, 22);
            this.foregroundColorItem.Text = "Foreground Color...";
            this.foregroundColorItem.Click += new System.EventHandler(this.SetForegroundColor);
            // 
            // marginWidthToolStripMenuItem
            // 
            this.marginWidthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeMarginCombo});
            this.marginWidthToolStripMenuItem.Name = "marginWidthToolStripMenuItem";
            this.marginWidthToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.marginWidthToolStripMenuItem.Text = "Margin Width";
            // 
            // ChangeMarginCombo
            // 
            this.ChangeMarginCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeMarginCombo.Items.AddRange(new object[] {
            "Default",
            "25",
            "50",
            "75",
            "100",
            "125"});
            this.ChangeMarginCombo.Name = "ChangeMarginCombo";
            this.ChangeMarginCombo.Size = new System.Drawing.Size(121, 21);
            this.ChangeMarginCombo.SelectedIndexChanged += new System.EventHandler(this.MarginWidthChanged);
            // 
            // changedLineMarkingToolStripMenuItem
            // 
            this.changedLineMarkingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableItItem,
            this.changedLineColorItem,
            this.savedLinesColorItem});
            this.changedLineMarkingToolStripMenuItem.Name = "changedLineMarkingToolStripMenuItem";
            this.changedLineMarkingToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.changedLineMarkingToolStripMenuItem.Text = "Changed Line Marking";
            // 
            // enableItItem
            // 
            this.enableItItem.Checked = true;
            this.enableItItem.CheckOnClick = true;
            this.enableItItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableItItem.Name = "enableItItem";
            this.enableItItem.Size = new System.Drawing.Size(190, 22);
            this.enableItItem.Text = "Enable it!";
            this.enableItItem.Click += new System.EventHandler(this.ChangedLineMarkingMenu_Click);
            // 
            // changedLineColorItem
            // 
            this.changedLineColorItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.changedLineColorItem.Name = "changedLineColorItem";
            this.changedLineColorItem.Size = new System.Drawing.Size(190, 22);
            this.changedLineColorItem.Text = "Changed lines color...";
            this.changedLineColorItem.Click += new System.EventHandler(this.ChangedLinesColor);
            // 
            // savedLinesColorItem
            // 
            this.savedLinesColorItem.Name = "savedLinesColorItem";
            this.savedLinesColorItem.Size = new System.Drawing.Size(190, 22);
            this.savedLinesColorItem.Text = "Saved lines color...";
            this.savedLinesColorItem.Click += new System.EventHandler(this.SavedLinesColor);
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
            this.Text = "Selection Margin";
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
		
		private void ChangedLineMarkingMenu_Click(object sender, System.EventArgs e)
		{
            this.editControl1.MarkChangedLines = enableItItem.Checked;
        }

        private void SetBackgroundColor(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editControl1.SelectionMarginBackgroundColor = colorDialog.Color;
backgroundColorToolStripMenuItem.ForeColor = colorDialog.Color;
            }
        }

        private void SetForegroundColor(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editControl1.SelectionMarginForegroundColor = colorDialog.Color;
                foregroundColorItem.ForeColor = colorDialog.Color;
            }
        }

        private void MarginWidthChanged(object sender, EventArgs e)
        {
            switch (ChangeMarginCombo.SelectedItem as string)
            {
                case "Default":
                    this.editControl1.SelectionMarginWidth = 5;
                    break;
                case "25":
                    this.editControl1.SelectionMarginWidth = 25;
                    break;
                case "50":
                    this.editControl1.SelectionMarginWidth = 50;
                    break;
                case "75":
                    this.editControl1.SelectionMarginWidth = 75;
                    break;
                case "100":
                    this.editControl1.SelectionMarginWidth = 100;
                    break;
                case "125":
                    this.editControl1.SelectionMarginWidth = 125;
                    break;
            }
        }

        private void ChangedLinesColor(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editControl1.ChangedLinesMarkingLineColor = colorDialog.Color;
                changedLineColorItem.ForeColor = colorDialog.Color;
            }
        }

        private void SavedLinesColor(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                editControl1.SavedLinesMarkingLineColor = colorDialog.Color;
                savedLinesColorItem.ForeColor = colorDialog.Color;
            }
        }

        private void MainMenuClick(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            switch (item.Text)
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
                case "Close":
                    editControl1.Close();
                    break;
                case "Exit":
                    Close();
                    break;
            }
        }
	}
}
