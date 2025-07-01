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
using System.Diagnostics;

using Syncfusion.Runtime.Serialization;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace LinkedManagers
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
	{
		# region Members declaration
		private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
		private System.Windows.Forms.ImageList imageList1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private System.ComponentModel.IContainer components;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem6;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biSuiteLogo;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biSuiteInfo;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biToolsLogo;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biToolsInfo;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biGridLogo;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biGridInfo;
		private LinkedManagers.TabPageClientControl ucSuitePage;
		private LinkedManagers.TabPageClientControl ucToolsPage;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
		private LinkedManagers.TabPageClientControl ucGridPage;
		private DemoCommon.AboutForm aboutForm;

		private Hashtable htCreatedControls = new Hashtable();
		private bool bDisposeControlsOnClose = false;	// Set to True to dispose dockable controls upon closing.
# endregion
		# region Initialization
		public Form1()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();		
		}		

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenuToolBar");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biSuiteLogo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biSuiteInfo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biToolsLogo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biToolsInfo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biGridLogo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biGridInfo = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "ShortcutToolBar");
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucSuitePage = new LinkedManagers.TabPageClientControl();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucToolsPage = new LinkedManagers.TabPageClientControl();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.ucGridPage = new LinkedManagers.TabPageClientControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Categories.Add("MainMenu");
            this.mainFrameBarManager1.Categories.Add("FileMenu");
            this.mainFrameBarManager1.Categories.Add("ViewMenu");
            this.mainFrameBarManager1.Categories.Add("HelpMenu");
            this.mainFrameBarManager1.Categories.Add("OpenShortcut");
            this.mainFrameBarManager1.Categories.Add("SaveShortcut");
            this.mainFrameBarManager1.Categories.Add("ExitShortcut");
            this.mainFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.parentBarItem3,
            this.barItem5,
            this.barItem1,
            this.barItem2,
            this.biSuiteLogo,
            this.biSuiteInfo,
            this.biToolsLogo,
            this.biToolsInfo,
            this.biGridLogo,
            this.biGridInfo,
            this.parentBarItem4,
            this.parentBarItem5,
            this.parentBarItem6});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            this.mainFrameBarManager1.ThemesEnabled = true;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenuToolBar";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)));
            this.bar1.Caption = "MainMenuToolBar";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.parentBarItem3});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2});
            this.parentBarItem1.Text = "&File";
            // 
            // barItem1
            // 
            this.barItem1.CategoryIndex = 1;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "Load Dock State";
            this.barItem1.ImageIndex = 1;
            this.barItem1.ImageList = this.imageList1;
            this.barItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem1.Text = "Load Dock State";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "new.gif");
            this.imageList1.Images.SetKeyName(1, "openfolderHS.png");
            this.imageList1.Images.SetKeyName(2, "saveHS.png");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            this.imageList1.Images.SetKeyName(14, "");
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = 1;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Save Dock State";
            this.barItem2.ImageIndex = 2;
            this.barItem2.ImageList = this.imageList1;
            this.barItem2.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem2.Text = "Save Dock State";
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "View";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem4,
            this.parentBarItem5,
            this.parentBarItem6});
            this.parentBarItem2.LargeImageList = this.imageList1;
            this.parentBarItem2.Text = "&View";
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.CategoryIndex = 2;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "Essential Suite_1";
            this.parentBarItem4.ImageIndex = 12;
            this.parentBarItem4.ImageList = this.imageList1;
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biSuiteLogo,
            this.biSuiteInfo});
            this.parentBarItem4.LargeImageList = this.imageList1;
            this.parentBarItem4.Text = "Essential Suite";
            // 
            // biSuiteLogo
            // 
            this.biSuiteLogo.CategoryIndex = 2;
            this.biSuiteLogo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biSuiteLogo.ID = "suiteLogo";
            this.biSuiteLogo.ImageIndex = 12;
            this.biSuiteLogo.ImageList = this.imageList1;
            this.biSuiteLogo.Text = "Suite Logo";
            this.biSuiteLogo.Click += new System.EventHandler(this.biSuiteLogo_Click);
            // 
            // biSuiteInfo
            // 
            this.biSuiteInfo.CategoryIndex = 2;
            this.biSuiteInfo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biSuiteInfo.ID = "suiteInformation";
            this.biSuiteInfo.ImageIndex = 14;
            this.biSuiteInfo.ImageList = this.imageList1;
            this.biSuiteInfo.Text = "Suite Information";
            this.biSuiteInfo.Click += new System.EventHandler(this.biSuiteInfo_Click);
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.CategoryIndex = 2;
            this.parentBarItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem5.ID = "Essential Tools_1";
            this.parentBarItem5.ImageIndex = 10;
            this.parentBarItem5.ImageList = this.imageList1;
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biToolsLogo,
            this.biToolsInfo});
            this.parentBarItem5.Text = "Essential Tools";
            // 
            // biToolsLogo
            // 
            this.biToolsLogo.CategoryIndex = 2;
            this.biToolsLogo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biToolsLogo.ID = "toolsLogo";
            this.biToolsLogo.ImageIndex = 10;
            this.biToolsLogo.ImageList = this.imageList1;
            this.biToolsLogo.Text = "Tools Logo";
            this.biToolsLogo.Click += new System.EventHandler(this.biToolsLogo_Click);
            // 
            // biToolsInfo
            // 
            this.biToolsInfo.CategoryIndex = 2;
            this.biToolsInfo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biToolsInfo.ID = "toolsInformation";
            this.biToolsInfo.ImageIndex = 14;
            this.biToolsInfo.ImageList = this.imageList1;
            this.biToolsInfo.Text = "Tools Information";
            this.biToolsInfo.Click += new System.EventHandler(this.biToolsInfo_Click);
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.CategoryIndex = 2;
            this.parentBarItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem6.ID = "Essential Grid_1";
            this.parentBarItem6.ImageIndex = 11;
            this.parentBarItem6.ImageList = this.imageList1;
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biGridLogo,
            this.biGridInfo});
            this.parentBarItem6.Text = "Essential Grid";
            // 
            // biGridLogo
            // 
            this.biGridLogo.CategoryIndex = 2;
            this.biGridLogo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biGridLogo.ID = "gridLogo";
            this.biGridLogo.ImageIndex = 11;
            this.biGridLogo.ImageList = this.imageList1;
            this.biGridLogo.Text = "Grid Logo";
            this.biGridLogo.Click += new System.EventHandler(this.biGridLogo_Click);
            // 
            // biGridInfo
            // 
            this.biGridInfo.CategoryIndex = 2;
            this.biGridInfo.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biGridInfo.ID = "gridInformation";
            this.biGridInfo.ImageIndex = 14;
            this.biGridInfo.ImageList = this.imageList1;
            this.biGridInfo.Text = "Grid Information";
            this.biGridInfo.Click += new System.EventHandler(this.biGridInfo_Click);
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.CategoryIndex = 0;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Help";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem5});
            this.parentBarItem3.Text = "&Help";
            // 
            // barItem5
            // 
            this.barItem5.CategoryIndex = 3;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "About Syncfusion";
            this.barItem5.ImageIndex = 9;
            this.barItem5.ImageList = this.imageList1;
            this.barItem5.Text = "About Syncfusion";
            this.barItem5.Click += new System.EventHandler(this.barItem5_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "ShortcutToolBar";
            this.bar2.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)));
            this.bar2.Caption = "ShortcutToolBar";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2});
            this.bar2.Manager = this.mainFrameBarManager1;
            this.bar2.SeparatorIndices.AddRange(new int[] {
            1});
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 51);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Padding = new System.Drawing.Point(6, 1);
            this.tabControlAdv1.Size = new System.Drawing.Size(576, 395);
            this.tabControlAdv1.TabGap = 10;
            this.tabControlAdv1.TabIndex = 4;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.ucSuitePage);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(574, 369);
            this.tabPageAdv1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageAdv1.TabIndex = 3;
            this.tabPageAdv1.Text = "Essential Suite";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // ucSuitePage
            // 
            this.ucSuitePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.ucSuitePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuitePage.Location = new System.Drawing.Point(0, 0);
            this.ucSuitePage.Name = "ucSuitePage";
            this.ucSuitePage.Size = new System.Drawing.Size(574, 369);
            this.ucSuitePage.TabIndex = 0;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(243)))));
            this.tabPageAdv2.Controls.Add(this.ucToolsPage);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(574, 369);
            this.tabPageAdv2.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(35)))));
            this.tabPageAdv2.TabIndex = 4;
            this.tabPageAdv2.Text = "Essential Tools";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // ucToolsPage
            // 
            this.ucToolsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.ucToolsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolsPage.Location = new System.Drawing.Point(0, 0);
            this.ucToolsPage.Name = "ucToolsPage";
            this.ucToolsPage.Size = new System.Drawing.Size(574, 369);
            this.ucToolsPage.TabIndex = 0;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.tabPageAdv3.Controls.Add(this.ucGridPage);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 25);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.Size = new System.Drawing.Size(574, 369);
            this.tabPageAdv3.TabIndex = 5;
            this.tabPageAdv3.Text = "Essential Grid";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // ucGridPage
            // 
            this.ucGridPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.ucGridPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGridPage.Location = new System.Drawing.Point(0, 0);
            this.ucGridPage.Name = "ucGridPage";
            this.ucGridPage.Size = new System.Drawing.Size(574, 369);
            this.ucGridPage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(576, 446);
            this.Controls.Add(this.tabControlAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linked Managers";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Syncfusion.Runtime.Serialization.AppStateSerializer.InitializeSingleton(SerializeMode.XMLFile, String.Concat(Environment.CurrentDirectory, "DockState"));
			Application.Run(new Form1());
		}

# endregion
		# region Event Handlers
		private void barItem5_Click(object sender, System.EventArgs e)
		{
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
		}
	
		private void barItem3_Click(object sender, System.EventArgs e)
		{
			this.Close();
			this.Dispose();
		}		

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Save the persisted dock state information for the different DockingManagers.
			this.ucSuitePage.DockingManager.SaveDockState();
			this.ucToolsPage.DockingManager.SaveDockState();
			this.ucGridPage.DockingManager.SaveDockState();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			DockingManager[] dockingmgrs = new DockingManager[] { this.ucSuitePage.DockingManager, 
																	this.ucToolsPage.DockingManager, 
																	this.ucGridPage.DockingManager };			
			
			// Specify the DockingManagers in the array to be used as target providers by all DockingManagers.
			foreach(DockingManager manager in dockingmgrs)
			{
				// Invoking the DockingManager.AddToTargetManagersList method on a docking manager will add the 
				// specified DockingManager argument instance to the invoking method's target managers list. 
				// Doing so allows dockable controls from the host docking manager to be docked onto the docking layout 
				// implemented by the target docking manager.
				if(manager != this.ucSuitePage.DockingManager)
					this.ucSuitePage.DockingManager.AddToTargetManagersList(manager);
				if(manager != this.ucToolsPage.DockingManager)
					this.ucToolsPage.DockingManager.AddToTargetManagersList(manager);
				if(manager != this.ucGridPage.DockingManager)
					this.ucGridPage.DockingManager.AddToTargetManagersList(manager);

				// Subscribe to the DockingManager.DockVisiblityChanged event.
				manager.DockVisibilityChanged += new DockVisibilityChangedEventHandler(this.DockingManager_DockVisibilityChanged);
				// Subscribe to the DockingManager.ManagerTransferred event.
				manager.TransferredToManager += new TransferManagerEventHandler(this.DockingManager_TransferredToManager);
				// Subscribe to the DockingManager.InitializeControlOnLoad event.
				manager.InitializeControlOnLoad += new InitializeControlOnLoadEventHandler(this.DockingManager_InitializeControlOnLoad);
				
				//Enabling Themes
				manager.ThemesEnabled=true;
			}
			
			// Load the persisted dock state information for the different DockingManagers.
			this.ucSuitePage.DockingManager.LoadDockState();
			this.ucToolsPage.DockingManager.LoadDockState();
			this.ucGridPage.DockingManager.LoadDockState();
		}

		
		private void biSuiteLogo_Click(object sender, System.EventArgs e)
		{
			this.ActivateSuiteLogoControl(this.ucSuitePage.DockingManager, true);			
		}

		private void biSuiteInfo_Click(object sender, System.EventArgs e)
		{
			this.ActivateSuiteInfoControl(this.ucSuitePage.DockingManager, true);
		}

		private void biToolsLogo_Click(object sender, System.EventArgs e)
		{
			this.ActivateToolsLogoControl(this.ucToolsPage.DockingManager, true);			
		}

		private void biToolsInfo_Click(object sender, System.EventArgs e)
		{
			this.ActivateToolsInfoControl(this.ucToolsPage.DockingManager, true);			
		}

		private void biGridLogo_Click(object sender, System.EventArgs e)
		{
			this.ActivateGridLogoControl(this.ucGridPage.DockingManager, true);			
		}
	
		private void biGridInfo_Click(object sender, System.EventArgs e)
		{
			this.ActivateGridInfoControl(this.ucGridPage.DockingManager, true);			
		}
		private void barItem1_Click(object sender, System.EventArgs e)
		{
			this.ucSuitePage.DockingManager.LoadDockState();
			this.ucToolsPage.DockingManager.LoadDockState();
			this.ucGridPage.DockingManager.LoadDockState();
		}

		private void barItem2_Click(object sender, System.EventArgs e)
		{
			this.ucSuitePage.DockingManager.SaveDockState();
			this.ucToolsPage.DockingManager.SaveDockState();
			this.ucGridPage.DockingManager.SaveDockState();
		}
# endregion
		# region Event handlers-DockingManager
		// A docking window is being closed. Remove it from the docking layout and dispose the control.
		protected void DockingManager_DockVisibilityChanged(object sender, DockVisibilityChangedEventArgs args)
		{		
			// When the bDisposeControlsOnClose flag is set, clicking the 'X' close button will remove the 
			// control from its docking layout and dispose it.
			if(this.bDisposeControlsOnClose == true)
			{
				DockingManager dockingmgr = sender as DockingManager;
				DockableControlBase dockablecontrol = args.Control as DockableControlBase;
				if(dockingmgr.GetDockVisibility(dockablecontrol) == false)
				{
					Syncfusion.Runtime.Serialization.AppStateSerializer serializer = Syncfusion.Runtime.Serialization.AppStateSerializer.GetSingleton();
					dockingmgr.SaveDockState(serializer, dockablecontrol);

					dockingmgr.SetEnableDocking(dockablecontrol, false);
					this.htCreatedControls.Remove(dockablecontrol.Name);
					dockablecontrol.Dispose();
				}
			}
		}

		// A docking window is being transferred from one docking layout to another. 
		// Update the control's DockingManager reference.
		protected void DockingManager_TransferredToManager(object sender, TransferManagerEventArgs args)
		{
			DockableControlBase dockablecontrol = args.Control as DockableControlBase;
			dockablecontrol.CurrentDockingManager = sender as DockingManager;
		}

		// The DockingManager.InitializeControlOnLoad event is fired when the DockingManager attempts to load a persisted 
		// dock state and is not able to locate the control for the persisted information. The event is used here as a 
		// place holder for creating the docking window.
		protected void DockingManager_InitializeControlOnLoad(object sender, InitializeControlOnLoadEventArgs args)
		{
			DockingManager dockingmgr = sender as DockingManager;
			switch (args.ControlName) 
			{
				case "Suite Logo":
					this.ActivateSuiteLogoControl(dockingmgr, false);
					break;
				case "Suite Info":
					this.ActivateSuiteInfoControl(dockingmgr, false);
					break;
				case "Tools Info":
					this.ActivateToolsInfoControl(dockingmgr, false);
					break;
				case "Tools Logo":
					this.ActivateToolsLogoControl(dockingmgr, false);
					break;
				case "Grid Logo":
					this.ActivateGridLogoControl(dockingmgr, false);
					break;
				case "Grid Info":
					this.ActivateGridInfoControl(dockingmgr, false);
					break;					
			}			
		}

		# endregion

		#region DockableClientsInitialization

		protected void ActivateSuiteLogoControl(DockingManager dockingmgr, bool setdockposition)
		{
			if((this.htCreatedControls.ContainsKey("Suite Logo") == true))
			{
				DockableControlBase dockablecontrol = this.htCreatedControls["Suite Logo"] as DockableControlBase;
				TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
				if(this.tabControlAdv1.SelectedTab != hosttabpage)
					this.tabControlAdv1.SelectedTab = hosttabpage;
				if(dockingmgr.GetDockVisibility(dockablecontrol) == false)
					dockingmgr.SetDockVisibility(dockablecontrol, true);
			}
			else
			{
				// Set the Suite TabPage as the selected tab.
				if(this.tabControlAdv1.SelectedTab != this.tabPageAdv1)
					this.tabControlAdv1.SelectedTab = this.tabPageAdv1;

				// Create an instance of the SuiteLogoControl and dock it to the left border of the ucSuitePage
				// UserControl that is embedded within the Suite TabPage.
				SuiteLogoControl suitelogo = new SuiteLogoControl("Suite Logo");
				suitelogo.CurrentDockingManager = dockingmgr;				
				if(setdockposition == true)
					dockingmgr.DockControl(suitelogo, dockingmgr.HostControl, DockingStyle.Left, 150);
					//dockingmgr.DockControlInAutoHideMode(suitelogo, DockingStyle.Left, 250);
				else
					dockingmgr.SetEnableDocking(suitelogo, true);
				dockingmgr.SetDockLabel(suitelogo, suitelogo.DockLabel);
				dockingmgr.SetDockIcon(suitelogo, suitelogo.DockIcon);

				this.htCreatedControls.Add("Suite Logo", suitelogo);
			}
		}

		protected void ActivateSuiteInfoControl(DockingManager dockingmgr, bool setdockposition)
		{
			if((this.htCreatedControls.ContainsKey("Suite Info") == true))
			{
				DockableControlBase dockablecontrol = this.htCreatedControls["Suite Info"] as DockableControlBase;
				TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
				if(this.tabControlAdv1.SelectedTab != hosttabpage)
					this.tabControlAdv1.SelectedTab = hosttabpage;
				if(dockingmgr.GetDockVisibility(dockablecontrol) == false)
					dockingmgr.SetDockVisibility(dockablecontrol, true);
			}
			else
			{
				// Set the Suite TabPage as the selected tab.
				if(this.tabControlAdv1.SelectedTab != this.tabPageAdv1)
					this.tabControlAdv1.SelectedTab = this.tabPageAdv1;

				// Create an instance of the SuiteInfoControl and dock it to the bottom border of the ucSuitePage
				// UserControl that is embedded within the Suite TabPage.
				DockableControlBase dockablecontrol = new SuiteInfoControl("Suite Info");
				dockablecontrol.CurrentDockingManager = dockingmgr;				
				if(setdockposition == true)
					dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Bottom, 150);
				else
					dockingmgr.SetEnableDocking(dockablecontrol, true);
				dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel);
				dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon);

				this.htCreatedControls.Add("Suite Info", dockablecontrol);
			}
		}

		protected void ActivateToolsLogoControl(DockingManager dockingmgr, bool setdockposition)
		{
			if((this.htCreatedControls.ContainsKey("Tools Logo") == true))
			{
				DockableControlBase dockablecontrol = this.htCreatedControls["Tools Logo"] as DockableControlBase;
				TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
				if(this.tabControlAdv1.SelectedTab != hosttabpage)
					this.tabControlAdv1.SelectedTab = hosttabpage;
				if(dockablecontrol.CurrentDockingManager.GetDockVisibility(dockablecontrol) == false)
					dockablecontrol.CurrentDockingManager.SetDockVisibility(dockablecontrol, true);
			}
			else
			{
				// Set the Tools TabPage as the selected tab.
				if(this.tabControlAdv1.SelectedTab != this.tabPageAdv2)
					this.tabControlAdv1.SelectedTab = this.tabPageAdv2;

				// Create an instance of the ToolsLogoControl and dock it to the left border of the ucToolsPage
				// UserControl that is embedded inside the Tools TabPage.
				DockableControlBase dockablecontrol = new ToolsLogoControl("Tools Logo");
				dockablecontrol.CurrentDockingManager = dockingmgr;				
				if(setdockposition == true)
					dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Left, 150);
				else
					dockingmgr.SetEnableDocking(dockablecontrol, true);
				dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel);
				dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon);

				this.htCreatedControls.Add("Tools Logo", dockablecontrol);
			}
		}

		protected void ActivateToolsInfoControl(DockingManager dockingmgr, bool setdockposition)
		{
			if((this.htCreatedControls.ContainsKey("Tools Info") == true))
			{
				DockableControlBase dockablecontrol = this.htCreatedControls["Tools Info"] as DockableControlBase;
				TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
				if(this.tabControlAdv1.SelectedTab != hosttabpage)
					this.tabControlAdv1.SelectedTab = hosttabpage;
				if(dockablecontrol.CurrentDockingManager.GetDockVisibility(dockablecontrol) == false)
					dockablecontrol.CurrentDockingManager.SetDockVisibility(dockablecontrol, true);
			}
			else
			{
				// Set the Tools TabPage as the selected tab.
				if(this.tabControlAdv1.SelectedTab != this.tabPageAdv2)
					this.tabControlAdv1.SelectedTab = this.tabPageAdv2;

				// Create an instance of the ToolsInfoControl and dock it to the bottom border of the ucToolsPage
				// UserControl that is embedded inside the Tools TabPage.
				DockableControlBase dockablecontrol = new ToolsInfoControl("Tools Info");
				dockablecontrol.CurrentDockingManager = dockingmgr;				
				if(setdockposition == true)
					dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Bottom, 150);
				else
					dockingmgr.SetEnableDocking(dockablecontrol, true);
				dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel);
				dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon);

				this.htCreatedControls.Add("Tools Info", dockablecontrol);

			}
		}

		protected void ActivateGridLogoControl(DockingManager dockingmgr, bool setdockposition)
		{
			if((this.htCreatedControls.ContainsKey("Grid Logo") == true))
			{
				DockableControlBase dockablecontrol = this.htCreatedControls["Grid Logo"] as DockableControlBase;
				TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
				if(this.tabControlAdv1.SelectedTab != hosttabpage)
					this.tabControlAdv1.SelectedTab = hosttabpage;
				if(dockablecontrol.CurrentDockingManager.GetDockVisibility(dockablecontrol) == false)
					dockablecontrol.CurrentDockingManager.SetDockVisibility(dockablecontrol, true);
			}
			else
			{
				// Set the Grid TabPage as the selected tab.
				if(this.tabControlAdv1.SelectedTab != this.tabPageAdv3)
					this.tabControlAdv1.SelectedTab = this.tabPageAdv3;

				// Create an instance of the GridLogoControl and dock it to the left border of the ucGridPage
				// UserControl that is embedded inside the Grid TabPage.
				DockableControlBase dockablecontrol = new GridLogoControl("Grid Logo");
				dockablecontrol.CurrentDockingManager = dockingmgr;				
				if(setdockposition == true)
					dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Left, 150);
				else
					dockingmgr.SetEnableDocking(dockablecontrol, true);
				dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel);
				dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon);
				
				this.htCreatedControls.Add("Grid Logo", dockablecontrol);
			}
		}

		protected void ActivateGridInfoControl(DockingManager dockingmgr, bool setdockposition)
		{
			if((this.htCreatedControls.ContainsKey("Grid Info") == true))
			{
				DockableControlBase dockablecontrol = this.htCreatedControls["Grid Info"] as DockableControlBase;
				TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
				if(this.tabControlAdv1.SelectedTab != hosttabpage)
					this.tabControlAdv1.SelectedTab = hosttabpage;
				if(dockablecontrol.CurrentDockingManager.GetDockVisibility(dockablecontrol) == false)
					dockablecontrol.CurrentDockingManager.SetDockVisibility(dockablecontrol, true);
			}
			else
			{
				// Set the Grid TabPage as the selected tab.
				if(this.tabControlAdv1.SelectedTab != this.tabPageAdv3)
					this.tabControlAdv1.SelectedTab = this.tabPageAdv3;

				// Create an instance of the GridInfoControl and dock it to the left border of the ucGridPage
				// UserControl that is embedded inside the Grid TabPage.
				DockableControlBase dockablecontrol = new GridInfoControl("Grid Info");
				dockablecontrol.CurrentDockingManager = dockingmgr;				
				if(setdockposition == true)
					dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Bottom, 150);
				else
					dockingmgr.SetEnableDocking(dockablecontrol, true);
				dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel);
				dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon);

				this.htCreatedControls.Add("Grid Info", dockablecontrol);
			}
		}

		#endregion // DockableClientsInitialization

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					// Array of the DockingManagers present in the different tabpage client controls.
					DockingManager[] dockingmgrs = new DockingManager[] { this.ucSuitePage.DockingManager, 
																			this.ucToolsPage.DockingManager, 
																			this.ucGridPage.DockingManager };			
			
					foreach(DockingManager manager in dockingmgrs)
					{
						manager.DockVisibilityChanged -= new DockVisibilityChangedEventHandler(this.DockingManager_DockVisibilityChanged);
						manager.TransferredToManager -= new TransferManagerEventHandler(this.DockingManager_TransferredToManager);
						manager.InitializeControlOnLoad -= new InitializeControlOnLoadEventHandler(this.DockingManager_InitializeControlOnLoad);
					}			

					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
				
	}
}
