using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using Syncfusion.Windows.Forms;

namespace FolderBrowserDemo
{
	public class frmFolderBrowser : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.FolderBrowser folderBrowser1;
		private System.Windows.Forms.Panel groupBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox cbShowShares;
		private System.Windows.Forms.CheckBox cbBrowseForEverything;
		private System.Windows.Forms.CheckBox cbBrowseForPrinter;
		private System.Windows.Forms.CheckBox cbBrowseForComputer;
		private System.Windows.Forms.CheckBox cbAllowUrls;
		private System.Windows.Forms.CheckBox cbNewDialogStyle;
		private System.Windows.Forms.CheckBox cbValidate;
		private System.Windows.Forms.CheckBox cbShowTextBox;
		private System.Windows.Forms.CheckBox cbRestrictToSubfolders;
		private System.Windows.Forms.CheckBox cbRestrictToDomain;
		private System.Windows.Forms.CheckBox cbRestrictToFilesystem;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel groupBox3;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.ComponentModel.IContainer components;

		public frmFolderBrowser()
		{
			InitializeComponent();			
		}

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

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolderBrowser));
            this.folderBrowser1 = new Syncfusion.Windows.Forms.FolderBrowser(this.components);
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRestrictToFilesystem = new System.Windows.Forms.CheckBox();
            this.cbRestrictToDomain = new System.Windows.Forms.CheckBox();
            this.cbRestrictToSubfolders = new System.Windows.Forms.CheckBox();
            this.cbShowTextBox = new System.Windows.Forms.CheckBox();
            this.cbValidate = new System.Windows.Forms.CheckBox();
            this.cbNewDialogStyle = new System.Windows.Forms.CheckBox();
            this.cbAllowUrls = new System.Windows.Forms.CheckBox();
            this.cbBrowseForComputer = new System.Windows.Forms.CheckBox();
            this.cbBrowseForPrinter = new System.Windows.Forms.CheckBox();
            this.cbBrowseForEverything = new System.Windows.Forms.CheckBox();
            this.cbShowShares = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowser1
            // 
            this.folderBrowser1.StartLocation = Syncfusion.Windows.Forms.FolderBrowserFolder.Desktop;
            this.folderBrowser1.Style = Syncfusion.Windows.Forms.FolderBrowserStyles.RestrictToFilesystem;
            this.folderBrowser1.FolderBrowserCallback += new Syncfusion.Windows.Forms.FolderBrowserCallbackEventHandler(this.folderBrowser1_FolderBrowserCallback);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.groupBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(8, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Set Start Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Set Start Location:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Location:";
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(16, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 16);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Custom Start Location";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.Location = new System.Drawing.Point(117, 40);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(103, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Custom Location:";
            this.label2.Visible = false;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 359);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(642, 24);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "Folder Browser Demo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRestrictToFilesystem);
            this.groupBox2.Controls.Add(this.cbRestrictToDomain);
            this.groupBox2.Controls.Add(this.cbRestrictToSubfolders);
            this.groupBox2.Controls.Add(this.cbShowTextBox);
            this.groupBox2.Controls.Add(this.cbValidate);
            this.groupBox2.Controls.Add(this.cbNewDialogStyle);
            this.groupBox2.Controls.Add(this.cbAllowUrls);
            this.groupBox2.Controls.Add(this.cbBrowseForComputer);
            this.groupBox2.Controls.Add(this.cbBrowseForPrinter);
            this.groupBox2.Controls.Add(this.cbBrowseForEverything);
            this.groupBox2.Controls.Add(this.cbShowShares);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Brown;
            this.groupBox2.Location = new System.Drawing.Point(8, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 187);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder Browser Styles";
            // 
            // cbRestrictToFilesystem
            // 
            this.cbRestrictToFilesystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRestrictToFilesystem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRestrictToFilesystem.ForeColor = System.Drawing.Color.Black;
            this.cbRestrictToFilesystem.Location = new System.Drawing.Point(240, 64);
            this.cbRestrictToFilesystem.Name = "cbRestrictToFilesystem";
            this.cbRestrictToFilesystem.Size = new System.Drawing.Size(144, 16);
            this.cbRestrictToFilesystem.TabIndex = 10;
            this.cbRestrictToFilesystem.Text = "Restrict To File System";
            this.cbRestrictToFilesystem.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbRestrictToDomain
            // 
            this.cbRestrictToDomain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRestrictToDomain.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRestrictToDomain.ForeColor = System.Drawing.Color.Black;
            this.cbRestrictToDomain.Location = new System.Drawing.Point(16, 150);
            this.cbRestrictToDomain.Name = "cbRestrictToDomain";
            this.cbRestrictToDomain.Size = new System.Drawing.Size(120, 16);
            this.cbRestrictToDomain.TabIndex = 9;
            this.cbRestrictToDomain.Text = "Restrict To Domain";
            this.cbRestrictToDomain.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbRestrictToSubfolders
            // 
            this.cbRestrictToSubfolders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRestrictToSubfolders.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRestrictToSubfolders.ForeColor = System.Drawing.Color.Black;
            this.cbRestrictToSubfolders.Location = new System.Drawing.Point(16, 108);
            this.cbRestrictToSubfolders.Name = "cbRestrictToSubfolders";
            this.cbRestrictToSubfolders.Size = new System.Drawing.Size(128, 16);
            this.cbRestrictToSubfolders.TabIndex = 8;
            this.cbRestrictToSubfolders.Text = "Restrict To Subfolders";
            this.cbRestrictToSubfolders.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbShowTextBox
            // 
            this.cbShowTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowTextBox.ForeColor = System.Drawing.Color.Black;
            this.cbShowTextBox.Location = new System.Drawing.Point(240, 108);
            this.cbShowTextBox.Name = "cbShowTextBox";
            this.cbShowTextBox.Size = new System.Drawing.Size(96, 16);
            this.cbShowTextBox.TabIndex = 7;
            this.cbShowTextBox.Text = "Show TextBox";
            this.cbShowTextBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbValidate
            // 
            this.cbValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbValidate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValidate.ForeColor = System.Drawing.Color.Black;
            this.cbValidate.Location = new System.Drawing.Point(480, 104);
            this.cbValidate.Name = "cbValidate";
            this.cbValidate.Size = new System.Drawing.Size(80, 24);
            this.cbValidate.TabIndex = 6;
            this.cbValidate.Text = "Validate";
            this.cbValidate.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbNewDialogStyle
            // 
            this.cbNewDialogStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNewDialogStyle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNewDialogStyle.ForeColor = System.Drawing.Color.Black;
            this.cbNewDialogStyle.Location = new System.Drawing.Point(240, 146);
            this.cbNewDialogStyle.Name = "cbNewDialogStyle";
            this.cbNewDialogStyle.Size = new System.Drawing.Size(112, 24);
            this.cbNewDialogStyle.TabIndex = 5;
            this.cbNewDialogStyle.Text = "New Dialog Style";
            this.cbNewDialogStyle.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbAllowUrls
            // 
            this.cbAllowUrls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAllowUrls.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllowUrls.ForeColor = System.Drawing.Color.Black;
            this.cbAllowUrls.Location = new System.Drawing.Point(480, 64);
            this.cbAllowUrls.Name = "cbAllowUrls";
            this.cbAllowUrls.Size = new System.Drawing.Size(112, 16);
            this.cbAllowUrls.TabIndex = 4;
            this.cbAllowUrls.Text = "Allow Urls";
            this.cbAllowUrls.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbBrowseForComputer
            // 
            this.cbBrowseForComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBrowseForComputer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrowseForComputer.ForeColor = System.Drawing.Color.Black;
            this.cbBrowseForComputer.Location = new System.Drawing.Point(16, 64);
            this.cbBrowseForComputer.Name = "cbBrowseForComputer";
            this.cbBrowseForComputer.Size = new System.Drawing.Size(136, 16);
            this.cbBrowseForComputer.TabIndex = 3;
            this.cbBrowseForComputer.Text = "Browse For Computer";
            this.cbBrowseForComputer.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbBrowseForPrinter
            // 
            this.cbBrowseForPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBrowseForPrinter.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrowseForPrinter.ForeColor = System.Drawing.Color.Black;
            this.cbBrowseForPrinter.Location = new System.Drawing.Point(480, 24);
            this.cbBrowseForPrinter.Name = "cbBrowseForPrinter";
            this.cbBrowseForPrinter.Size = new System.Drawing.Size(120, 16);
            this.cbBrowseForPrinter.TabIndex = 2;
            this.cbBrowseForPrinter.Text = "Browse For Printer";
            this.cbBrowseForPrinter.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbBrowseForEverything
            // 
            this.cbBrowseForEverything.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBrowseForEverything.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrowseForEverything.ForeColor = System.Drawing.Color.Black;
            this.cbBrowseForEverything.Location = new System.Drawing.Point(240, 24);
            this.cbBrowseForEverything.Name = "cbBrowseForEverything";
            this.cbBrowseForEverything.Size = new System.Drawing.Size(144, 16);
            this.cbBrowseForEverything.TabIndex = 1;
            this.cbBrowseForEverything.Text = "Browse For Everything";
            this.cbBrowseForEverything.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // cbShowShares
            // 
            this.cbShowShares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShowShares.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowShares.ForeColor = System.Drawing.Color.Black;
            this.cbShowShares.Location = new System.Drawing.Point(16, 24);
            this.cbShowShares.Name = "cbShowShares";
            this.cbShowShares.Size = new System.Drawing.Size(128, 16);
            this.cbShowShares.TabIndex = 0;
            this.cbShowShares.Text = "Show Admin Shares";
            this.cbShowShares.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.groupBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonAdv1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Brown;
            this.groupBox3.Location = new System.Drawing.Point(400, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 136);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.Text = "Folder Browser";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "The Folder Browser is intended to provide a convinient browsing to files and fold" +
                "ers";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.Black;
            this.buttonAdv1.Location = new System.Drawing.Point(56, 96);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(128, 21);
            this.buttonAdv1.TabIndex = 0;
            this.buttonAdv1.Text = "Show FolderBrowser";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.cmdShowBrowser_Click);
            // 
            // frmFolderBrowser
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(642, 383);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolderBrowser";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Browser Demo";
            this.Load += new System.EventHandler(this.frmFolderBrowser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new frmFolderBrowser());
		}

		private void frmFolderBrowser_Load(object sender, System.EventArgs e)
		{
			// To Populate the ComboxBox1 with the Folder Path.
			this.comboBox1.Items.AddRange(new string[] {
														   "Desktop Directory", "My Computer", "My Documents", "Desktop", "Internet", "Programs", "Control Panel",
														   "Printers", "Personal","Favorites","Startup", "Recent", "Send To", "Recycle Bin", "Start Menu", "My Music",
														   "My Video", "Network Neighborhood", "NetHood", "Fonts", "Templates", "My Pictures", "Common Documents", 
														   "Common Admin Tools", "Net And DialUp Connections", "Common Music", "Common Pictures", 
														   "Common Video", "Resources", "CD Burn Area", "Computers Near Me"});
			
			this.folderBrowser1.StartLocation = Syncfusion.Windows.Forms.FolderBrowserFolder.Desktop;
			this.folderBrowser1.Description = "This is the Demo of Syncfusion FolderBrowser Control.";
			this.comboBox1.SelectedIndex = 3;
		}

		private void cmdShowBrowser_Click(object sender, System.EventArgs e)
		{
			if(textBox1.Visible == true || textBox1.Text.Trim().Length>0)
			{
				//If this check is omitted FolderBrowser will display its own Error Message.
				if(!Directory.Exists(textBox1.Text.Trim()))
				{
					MessageBox.Show("Kindly Check the Path.");
					return;
				}
				this.folderBrowser1.CustomStartLocation = textBox1.Text;
				this.folderBrowser1.StartLocation = FolderBrowserFolder.CustomStartLocation;
			}

			// To reset the StartLocation after using CustomStartLocation.
			if(checkBox1.Checked == false)
				comboBox1_SelectionChangeCommitted(sender,e);

			if( folderBrowser1.ShowDialog()== DialogResult.OK)
				this.statusBar1.Text = folderBrowser1.DirectoryPath;
		}

		private void comboBox1_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			#region Set Folder Browser StartLocation
			switch(comboBox1.Items[comboBox1.SelectedIndex].ToString())
			{
				case "Recycle Bin":
					folderBrowser1.StartLocation = FolderBrowserFolder.BitBucket;
					break;
				case "CD Burn Area":
					folderBrowser1.StartLocation = FolderBrowserFolder.CDBurnArea;
					break;
				case "Common Admin Tools":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonAdminTools;
					break;
				case "Common Documents":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonDocuments;
					break;	
				case "Common Music":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonMusic;
					break;	
				case "Common Pictures":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonPictures ;
					break;
				case "Common Video":
					folderBrowser1.StartLocation = FolderBrowserFolder.CommonVideo;
					break;
				case "Computers Near Me":
					folderBrowser1.StartLocation = FolderBrowserFolder.ComputersNearMe;
					break;
				case "Control Panel":
					folderBrowser1.StartLocation = FolderBrowserFolder.Controls;
					break;
				case "Desktop":
					folderBrowser1.StartLocation = FolderBrowserFolder.Desktop;
					break;
				case "Desktop Directory":
					folderBrowser1.StartLocation = FolderBrowserFolder.DesktopDirectory;
					break;
				case "Favorites":
					folderBrowser1.StartLocation = FolderBrowserFolder.Favorites;
					break;
				case "Fonts":
					folderBrowser1.StartLocation = FolderBrowserFolder.Fonts;
					break;
				case "Internet":
					folderBrowser1.StartLocation = FolderBrowserFolder.Internet;
					break;
				case "My Computer":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyComputer;
					break;
				case "My Documents":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyDocuments;
					break;
				case "My Music":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyMusic;
					break;
				case "My Pictures":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyPictures;
					break;
				case "My Video":
					folderBrowser1.StartLocation = FolderBrowserFolder.MyVideo;
					break;
				case "Net And DialUp Connections":
					folderBrowser1.StartLocation = FolderBrowserFolder.NetAndDialUpConnections;
					break;
				case "Net Hood":
					folderBrowser1.StartLocation = FolderBrowserFolder.NetHood;
					break;
				case "Network Neighborhood":
					folderBrowser1.StartLocation = FolderBrowserFolder.NetworkNeighborhood;
					break;
				case "Personal":
					folderBrowser1.StartLocation = FolderBrowserFolder.Personal;
					break;
				case "Printers":
					folderBrowser1.StartLocation = FolderBrowserFolder.Printers;
					break;
				case "Programs":
					folderBrowser1.StartLocation = FolderBrowserFolder.Programs;
					break;
				case "Recent":
					folderBrowser1.StartLocation = FolderBrowserFolder.Recent;
					break;
				case "Resources":
					folderBrowser1.StartLocation = FolderBrowserFolder.Resources;
					break;
				case "Send To":
					folderBrowser1.StartLocation = FolderBrowserFolder.SendTo;
					break;
				case "Start Menu":
					folderBrowser1.StartLocation = FolderBrowserFolder.StartMenu;
					break;
				case "Startup":
					folderBrowser1.StartLocation = FolderBrowserFolder.Startup;
					break;
				case "Templates":
					folderBrowser1.StartLocation = FolderBrowserFolder.Templates;
					break;
			}
			#endregion
		}

		// Event handler for the FolderBrowser.FolderBrowserCallback validation event.
		// This handler is functionally equivalent of the Win32 BrowseCallbackProc callback function.
		private void folderBrowser1_FolderBrowserCallback(object sender, Syncfusion.Windows.Forms.FolderBrowserCallbackEventArgs e)
		{
			this.statusBar1.Text = String.Format("Event: {0}, Path: {1}", e.FolderBrowserMessage, e.Path);
			if (e.FolderBrowserMessage == FolderBrowserMessage.ValidateFailed)
			{
				e.Dismiss = e.Path != "NONE";
			}
		}

		private void checkBox_CheckedChanged(object sender, System.EventArgs e)
		{
			this.SetFolderBrowserStyles(sender as CheckBox);		
		}

		private void SetFolderBrowserStyles(CheckBox cbselected)
		{
			#region Apply FolderBrowserStyles
			switch(cbselected.Text)
			{
				case "Restrict To File System":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.RestrictToFilesystem;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.RestrictToFilesystem;
					break;
				case "Restrict To Domain":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.RestrictToDomain;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.RestrictToDomain;
					break;
				case "Restrict To Subfolders":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.RestrictToSubfolders;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.RestrictToSubfolders;
					break;
				case "Show TextBox":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.ShowTextBox;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.ShowTextBox;
					break;
				case "Validate":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.Validate;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.Validate;
					break;
				case "New Dialog Style":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.NewDialogStyle;
					else
					{
						this.folderBrowser1.Style &= ~FolderBrowserStyles.AllowUrls;
						this.cbAllowUrls.Checked = false;
						this.folderBrowser1.Style &= ~FolderBrowserStyles.ShowAdministrativeShares;
						this.cbShowShares.Checked = false;
						this.folderBrowser1.Style &= ~FolderBrowserStyles.NewDialogStyle;
						
					}
					break;
				case "Allow Urls":
					if(cbselected.Checked == true)
					{
						this.folderBrowser1.Style |= FolderBrowserStyles.AllowUrls|FolderBrowserStyles.NewDialogStyle;
						this.cbNewDialogStyle.Checked = true;
					}
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.AllowUrls;
					break;
				case "Browse For Computer":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.BrowseForComputer;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.BrowseForComputer;
					break;
				case "Browse For Printer":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.BrowseForPrinter;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.BrowseForPrinter;
					break;
				case "Browse For Everything":
					if(cbselected.Checked == true)
						this.folderBrowser1.Style |= FolderBrowserStyles.BrowseForEverything;
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.BrowseForEverything;
					break;
				case "Show Shares":
					if(cbselected.Checked == true)
					{
						this.folderBrowser1.Style |= FolderBrowserStyles.ShowAdministrativeShares|FolderBrowserStyles.NewDialogStyle;
						this.cbNewDialogStyle.Checked = true;
					}
					else
						this.folderBrowser1.Style &= ~FolderBrowserStyles.ShowAdministrativeShares;
					break;
			}
		}
		#endregion

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
            textBox1.Text = string.Empty;
			textBox1.Visible = checkBox1.Checked;
			label2.Visible = checkBox1.Checked;

			comboBox1.Enabled = ! checkBox1.Checked;
			textBox1.Focus();
		}
	}
}
