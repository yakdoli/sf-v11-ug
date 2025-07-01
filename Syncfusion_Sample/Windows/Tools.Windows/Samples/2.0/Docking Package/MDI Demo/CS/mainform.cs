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

namespace MDIDemo
{    
	using System;
	using System.ComponentModel;
	using System.Drawing;
	using System.Windows.Forms;
	using System.Reflection;
	using System.Diagnostics;
	using System.Runtime.InteropServices;
    using Microsoft.Win32;

	using Syncfusion.Runtime.Serialization;
    using Syncfusion.Windows.Forms.Tools.XPMenus;
    using Syncfusion.Windows.Forms.Tools;
    using Syncfusion.Windows.Forms;

	public class MainForm : Office2007Form
	{       
        # region Members declaration

        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private System.ComponentModel.IContainer components;

		private int windowCount = 0 ;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton5;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ImageList ilCommon;
		private System.Windows.Forms.Panel pnlSlnToolBar;
        private System.Windows.Forms.ToolBar tbSlnPanel;
		private System.Windows.Forms.TreeView tvNetwork;
		private System.Windows.Forms.ListBox dwCurrent;
		private System.Windows.Forms.TreeView dwDocumentBrowser;
		private System.Windows.Forms.TextBox dwNotes2;
		private System.Windows.Forms.TextBox dwNotes1;
		private System.Windows.Forms.Panel dwNetwork;

		// Used during CommandBar dockstate changes.
		private Size szToolBarPanel;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private CommandBar cbToolBar;
        private BarItem barItem20;
        private Bar bar4;
        private ToolStripEx toolStripEx1;
        private ToolStripCheckBox chkOffice2007Mdi;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton clrSchemeDD;
        private ToolStripMenuItem blueClrScheme;
        private ToolStripMenuItem silverClrScheme;
        private ToolStripMenuItem blackClrScheme;
        private ToolStripMenuItem CustomColorScheme;
        private ToolStripButton tsbNew;
        private ToolStripButton tsbOpen;
        private ToolStripButton tsbSave;
        private ToolStripComboBox cmbFontFace;
        private ToolStripComboBox cmbFontSize;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
		private Size szToolBarCommandBarPanel;
# endregion

        # region Initialization
		public MainForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			
			InitializeComponent();

            CustomColorsDropDownImpl();
			//Set up MDI stuff.
			this.IsMdiContainer = true;
			this.MdiChildActivate += new EventHandler(this.MDIChildActivated);
			// Get the toolbar and CommandBar panel sizes.
			this.szToolBarPanel = new Size(80,24);
			this.szToolBarCommandBarPanel = new Size(273,24);
            
         

            this.cmbFontFace.SelectedIndex = 0;
            this.cmbFontSize.SelectedIndex = 1;

            //Status Bar
            this.bar4 = new Bar();
            this.mainFrameBarManager1.Bars.Add(bar4);
            this.bar4.BarName = "Status Bar";
            this.bar4.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsStatusBar)));
            this.bar4.Caption = "Status Bar";
            this.bar4.Items.Add(barItem20);
            this.bar4.Manager = this.mainFrameBarManager1;
            this.Load += new EventHandler(MainForm_Load);
            this.dockingManager1.NewDockStateEndLoad += new EventHandler(dockingManager1_NewDockStateEndLoad);
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
		}

        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.dockingManager1.UnlockDockPanelsUpdate();
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.dockingManager1.LockDockPanelsUpdate();
        }

        void dockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {
            
            CreateNewDocument();

            
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            this.dockingManager1.SetAsMDIChild(this.dwDocumentBrowser, true);
        }

		/// <summary>
		///    Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
				
		
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main(string[] args)
		{
			// Modify this version, whenever changes are made such that the persisted state cannot be loaded anymore.
			string curVersion = "1.0";
			ValidatePersistedStateVersion(curVersion);
			StoreVersionInfo(curVersion);
			MainForm mainForm = new MainForm();
			Application.Run(mainForm);
		}
		
		/// <summary>
		///    Required method for Designer support - do not modify
		///    the contents of this method with the code editor.
		/// </summary>
		protected void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbdwCurrent = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbdwDocumentBrowser = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbdwNotes2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbdwNetwork = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbdwNotes1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Amber", 35, 35);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Services", 30, 30, new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("John", 31, 31);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Smith", 32, 32);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Field Units", 30, 30, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Steve 1", 36, 36);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Steve 2", 34, 34);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Caldito", 33, 33);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Luxor", 32, 32);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Marketing/Sales", 30, 30, new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Salem", 31, 31);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Amityville", 31, 31);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Deployment Servers", 37, 37, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode(" Brad", 31, 31);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Anton", 37, 37, new System.Windows.Forms.TreeNode[] {
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Technical Support", 30, 30, new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Bill", 32, 32);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Mark", 32, 32);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Steve", 31, 31);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("MaryAnn", 31, 31);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("LP1", 36, 36);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("LP2", 36, 36);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Print Server", 30, 30, new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Development", 37, 37, new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Solution 1", 22, 22);
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Solution 2", 22, 22);
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Trial", 22, 22);
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Clerks", 24, 24);
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("WorkIssue", 24, 24);
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("QuickSolutions", 25, 25, new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Clients");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Office1", 22, 22, new System.Windows.Forms.TreeNode[] {
            treeNode31});
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("BG Group", 25, 25, new System.Windows.Forms.TreeNode[] {
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Contacts", 8, 8);
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Referrals");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("QuickSoft Solutions", 26, 26, new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35});
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("ABCL Sales", 22, 22);
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("BetaSoft", 24, 24);
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("NC", 8, 8);
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("SC", 9, 9);
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("GA");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("ZincLite Inc", 27, 27, new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Sales 1", 22, 22);
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Sales 2", 22, 22);
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Complaints", 10, 10);
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("MicroCorp", 23, 23, new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode45});
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.ilCommon = new System.Windows.Forms.ImageList(this.components);
            this.dwNotes2 = new System.Windows.Forms.TextBox();
            this.dwNotes1 = new System.Windows.Forms.TextBox();
            this.dwNetwork = new System.Windows.Forms.Panel();
            this.tvNetwork = new System.Windows.Forms.TreeView();
            this.pnlSlnToolBar = new System.Windows.Forms.Panel();
            this.tbSlnPanel = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.dwCurrent = new System.Windows.Forms.ListBox();
            this.dwDocumentBrowser = new System.Windows.Forms.TreeView();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.cbToolBar = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbFontFace = new System.Windows.Forms.ToolStripComboBox();
            this.cmbFontSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.chkOffice2007Mdi = new Syncfusion.Windows.Forms.Tools.ToolStripCheckBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clrSchemeDD = new System.Windows.Forms.ToolStripDropDownButton();
            this.blueClrScheme = new System.Windows.Forms.ToolStripMenuItem();
            this.silverClrScheme = new System.Windows.Forms.ToolStripMenuItem();
            this.blackClrScheme = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomColorScheme = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            this.dwNetwork.SuspendLayout();
            this.pnlSlnToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.toolStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.ForwardMenuShortcuts = false;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.ImageList = this.ilCommon;
            this.dockingManager1.Office2007MdiChildForm = true;
            this.dockingManager1.Office2007MdiColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.SetDockLabel(this.dwCurrent, "Current");
            this.dockingManager1.SetDockIcon(this.dwCurrent, 45);
            ccbdwCurrent.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.dwCurrent, ccbdwCurrent);
            this.dockingManager1.SetDockLabel(this.dwDocumentBrowser, "DocumentBrowser");
            this.dockingManager1.SetDockIcon(this.dwDocumentBrowser, 47);
            ccbdwDocumentBrowser.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.dwDocumentBrowser, ccbdwDocumentBrowser);
            this.dockingManager1.SetDockLabel(this.dwNotes2, "Notes 2");
            this.dockingManager1.SetDockIcon(this.dwNotes2, 9);
            ccbdwNotes2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.dwNotes2, ccbdwNotes2);
            this.dockingManager1.SetDockLabel(this.dwNetwork, "Network");
            this.dockingManager1.SetDockIcon(this.dwNetwork, 46);
            ccbdwNetwork.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.dwNetwork, ccbdwNetwork);
            this.dockingManager1.SetDockLabel(this.dwNotes1, "Notes 1");
            this.dockingManager1.SetDockIcon(this.dwNotes1, 9);
            ccbdwNotes1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.dwNotes1, ccbdwNotes1);
            // 
            // ilCommon
            // 
            this.ilCommon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCommon.ImageStream")));
            this.ilCommon.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCommon.Images.SetKeyName(0, "");
            this.ilCommon.Images.SetKeyName(1, "");
            this.ilCommon.Images.SetKeyName(2, "");
            this.ilCommon.Images.SetKeyName(3, "");
            this.ilCommon.Images.SetKeyName(4, "");
            this.ilCommon.Images.SetKeyName(5, "");
            this.ilCommon.Images.SetKeyName(6, "");
            this.ilCommon.Images.SetKeyName(7, "");
            this.ilCommon.Images.SetKeyName(8, "");
            this.ilCommon.Images.SetKeyName(9, "");
            this.ilCommon.Images.SetKeyName(10, "");
            this.ilCommon.Images.SetKeyName(11, "");
            this.ilCommon.Images.SetKeyName(12, "");
            this.ilCommon.Images.SetKeyName(13, "");
            this.ilCommon.Images.SetKeyName(14, "");
            this.ilCommon.Images.SetKeyName(15, "");
            this.ilCommon.Images.SetKeyName(16, "");
            this.ilCommon.Images.SetKeyName(17, "");
            this.ilCommon.Images.SetKeyName(18, "");
            this.ilCommon.Images.SetKeyName(19, "");
            this.ilCommon.Images.SetKeyName(20, "");
            this.ilCommon.Images.SetKeyName(21, "");
            this.ilCommon.Images.SetKeyName(22, "");
            this.ilCommon.Images.SetKeyName(23, "");
            this.ilCommon.Images.SetKeyName(24, "");
            this.ilCommon.Images.SetKeyName(25, "");
            this.ilCommon.Images.SetKeyName(26, "");
            this.ilCommon.Images.SetKeyName(27, "");
            this.ilCommon.Images.SetKeyName(28, "");
            this.ilCommon.Images.SetKeyName(29, "");
            this.ilCommon.Images.SetKeyName(30, "");
            this.ilCommon.Images.SetKeyName(31, "");
            this.ilCommon.Images.SetKeyName(32, "");
            this.ilCommon.Images.SetKeyName(33, "");
            this.ilCommon.Images.SetKeyName(34, "");
            this.ilCommon.Images.SetKeyName(35, "");
            this.ilCommon.Images.SetKeyName(36, "");
            this.ilCommon.Images.SetKeyName(37, "");
            this.ilCommon.Images.SetKeyName(38, "");
            this.ilCommon.Images.SetKeyName(39, "");
            this.ilCommon.Images.SetKeyName(40, "");
            this.ilCommon.Images.SetKeyName(41, "");
            this.ilCommon.Images.SetKeyName(42, "");
            this.ilCommon.Images.SetKeyName(43, "");
            this.ilCommon.Images.SetKeyName(44, "");
            this.ilCommon.Images.SetKeyName(45, "");
            this.ilCommon.Images.SetKeyName(46, "");
            this.ilCommon.Images.SetKeyName(47, "");
            this.ilCommon.Images.SetKeyName(48, "colors.png");
            // 
            // dwNotes2
            // 
            this.dwNotes2.BackColor = System.Drawing.Color.White;
            this.dwNotes2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingManager1.SetEnableDocking(this.dwNotes2, true);
            this.dwNotes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwNotes2.Location = new System.Drawing.Point(3, 23);
            this.dwNotes2.Multiline = true;
            this.dwNotes2.Name = "dwNotes2";
            this.dwNotes2.Size = new System.Drawing.Size(737, 82);
            this.dwNotes2.TabIndex = 13;
            this.dwNotes2.Text = "NOTE - Replace disks for all project files.";
            // 
            // dwNotes1
            // 
            this.dwNotes1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingManager1.SetEnableDocking(this.dwNotes1, true);
            this.dwNotes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwNotes1.Location = new System.Drawing.Point(3, 23);
            this.dwNotes1.Multiline = true;
            this.dwNotes1.Name = "dwNotes1";
            this.dwNotes1.Size = new System.Drawing.Size(737, 82);
            this.dwNotes1.TabIndex = 17;
            this.dwNotes1.Text = "Send profiles to Suzanne.";
            // 
            // dwNetwork
            // 
            this.dwNetwork.Controls.Add(this.tvNetwork);
            this.dwNetwork.Controls.Add(this.pnlSlnToolBar);
            this.dockingManager1.SetEnableDocking(this.dwNetwork, true);
            this.dwNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dwNetwork.Location = new System.Drawing.Point(3, 23);
            this.dwNetwork.Name = "dwNetwork";
            this.dwNetwork.Size = new System.Drawing.Size(155, 411);
            this.dwNetwork.TabIndex = 16;
            // 
            // tvNetwork
            // 
            this.tvNetwork.BackColor = System.Drawing.Color.White;
            this.tvNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNetwork.ImageIndex = 0;
            this.tvNetwork.ImageList = this.ilCommon;
            this.tvNetwork.Location = new System.Drawing.Point(0, 23);
            this.tvNetwork.Name = "tvNetwork";
            treeNode1.ImageIndex = 35;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 35;
            treeNode1.Text = "Amber";
            treeNode2.ImageIndex = 30;
            treeNode2.Name = "";
            treeNode2.SelectedImageIndex = 30;
            treeNode2.Text = "Services";
            treeNode3.ImageIndex = 31;
            treeNode3.Name = "";
            treeNode3.SelectedImageIndex = 31;
            treeNode3.Text = "John";
            treeNode4.ImageIndex = 32;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 32;
            treeNode4.Text = "Smith";
            treeNode5.ImageIndex = 30;
            treeNode5.Name = "";
            treeNode5.SelectedImageIndex = 30;
            treeNode5.Text = "Field Units";
            treeNode6.ImageIndex = 36;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 36;
            treeNode6.Text = "Steve 1";
            treeNode7.ImageIndex = 34;
            treeNode7.Name = "";
            treeNode7.SelectedImageIndex = 34;
            treeNode7.Text = "Steve 2";
            treeNode8.ImageIndex = 33;
            treeNode8.Name = "";
            treeNode8.SelectedImageIndex = 33;
            treeNode8.Text = "Caldito";
            treeNode9.ImageIndex = 32;
            treeNode9.Name = "";
            treeNode9.SelectedImageIndex = 32;
            treeNode9.Text = "Luxor";
            treeNode10.ImageIndex = 30;
            treeNode10.Name = "";
            treeNode10.SelectedImageIndex = 30;
            treeNode10.Text = "Marketing/Sales";
            treeNode11.ImageIndex = 31;
            treeNode11.Name = "";
            treeNode11.SelectedImageIndex = 31;
            treeNode11.Text = "Salem";
            treeNode12.ImageIndex = 31;
            treeNode12.Name = "";
            treeNode12.SelectedImageIndex = 31;
            treeNode12.Text = "Amityville";
            treeNode13.ImageIndex = 37;
            treeNode13.Name = "";
            treeNode13.SelectedImageIndex = 37;
            treeNode13.Text = "Deployment Servers";
            treeNode14.ImageIndex = 31;
            treeNode14.Name = "";
            treeNode14.SelectedImageIndex = 31;
            treeNode14.Text = " Brad";
            treeNode15.ImageIndex = 37;
            treeNode15.Name = "";
            treeNode15.SelectedImageIndex = 37;
            treeNode15.Text = "Anton";
            treeNode16.ImageIndex = 30;
            treeNode16.Name = "";
            treeNode16.SelectedImageIndex = 30;
            treeNode16.Text = "Technical Support";
            treeNode17.ImageIndex = 32;
            treeNode17.Name = "";
            treeNode17.SelectedImageIndex = 32;
            treeNode17.Text = "Bill";
            treeNode18.ImageIndex = 32;
            treeNode18.Name = "";
            treeNode18.SelectedImageIndex = 32;
            treeNode18.Text = "Mark";
            treeNode19.ImageIndex = 31;
            treeNode19.Name = "";
            treeNode19.SelectedImageIndex = 31;
            treeNode19.Text = "Steve";
            treeNode20.ImageIndex = 31;
            treeNode20.Name = "";
            treeNode20.SelectedImageIndex = 31;
            treeNode20.Text = "MaryAnn";
            treeNode21.ImageIndex = 36;
            treeNode21.Name = "";
            treeNode21.SelectedImageIndex = 36;
            treeNode21.Text = "LP1";
            treeNode22.ImageIndex = 36;
            treeNode22.Name = "";
            treeNode22.SelectedImageIndex = 36;
            treeNode22.Text = "LP2";
            treeNode23.ImageIndex = 30;
            treeNode23.Name = "";
            treeNode23.SelectedImageIndex = 30;
            treeNode23.Text = "Print Server";
            treeNode24.ImageIndex = 37;
            treeNode24.Name = "";
            treeNode24.SelectedImageIndex = 37;
            treeNode24.Text = "Development";
            this.tvNetwork.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode13,
            treeNode16,
            treeNode24});
            this.tvNetwork.SelectedImageIndex = 0;
            this.tvNetwork.Size = new System.Drawing.Size(155, 388);
            this.tvNetwork.TabIndex = 1;
            // 
            // pnlSlnToolBar
            // 
            this.pnlSlnToolBar.Controls.Add(this.tbSlnPanel);
            this.pnlSlnToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSlnToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSlnToolBar.Name = "pnlSlnToolBar";
            this.pnlSlnToolBar.Size = new System.Drawing.Size(155, 23);
            this.pnlSlnToolBar.TabIndex = 23;
            // 
            // tbSlnPanel
            // 
            this.tbSlnPanel.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbSlnPanel.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton4,
            this.toolBarButton5,
            this.toolBarButton6,
            this.toolBarButton7});
            this.tbSlnPanel.ButtonSize = new System.Drawing.Size(23, 20);
            this.tbSlnPanel.Divider = false;
            this.tbSlnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSlnPanel.DropDownArrows = true;
            this.tbSlnPanel.ImageList = this.ilCommon;
            this.tbSlnPanel.Location = new System.Drawing.Point(0, 0);
            this.tbSlnPanel.Name = "tbSlnPanel";
            this.tbSlnPanel.ShowToolTips = true;
            this.tbSlnPanel.Size = new System.Drawing.Size(155, 26);
            this.tbSlnPanel.TabIndex = 0;
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 41;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.ToolTipText = "View Code";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 5;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.ToolTipText = "View Designer";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.ImageIndex = 44;
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.ToolTipText = "Refresh";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.ImageIndex = 43;
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.ToolTipText = "Show All Files";
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.ImageIndex = 42;
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.ToolTipText = "Properties";
            // 
            // dwCurrent
            // 
            this.dwCurrent.BackColor = System.Drawing.Color.White;
            this.dwCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingManager1.SetEnableDocking(this.dwCurrent, true);
            this.dwCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwCurrent.IntegralHeight = false;
            this.dwCurrent.Items.AddRange(new object[] {
            "Projects1.doc",
            "Features.doc",
            "Client Issues1.doc",
            "Client Issues2.doc",
            "Clients.xls",
            "Presentation.ppt",
            "Slides.ppt",
            "Updates.doc",
            "Personal.doc",
            "Mail.doc"});
            this.dwCurrent.Location = new System.Drawing.Point(3, 23);
            this.dwCurrent.Name = "dwCurrent";
            this.dwCurrent.Size = new System.Drawing.Size(131, 411);
            this.dwCurrent.TabIndex = 9;
            // 
            // dwDocumentBrowser
            // 
            this.dwDocumentBrowser.BackColor = System.Drawing.Color.White;
            this.dwDocumentBrowser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingManager1.SetEnableDocking(this.dwDocumentBrowser, true);
            this.dwDocumentBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwDocumentBrowser.ImageIndex = 0;
            this.dwDocumentBrowser.ImageList = this.ilCommon;
            this.dwDocumentBrowser.Location = new System.Drawing.Point(3, 23);
            this.dwDocumentBrowser.Name = "dwDocumentBrowser";
            treeNode25.ImageIndex = 22;
            treeNode25.Name = "";
            treeNode25.SelectedImageIndex = 22;
            treeNode25.Text = "Solution 1";
            treeNode26.ImageIndex = 22;
            treeNode26.Name = "";
            treeNode26.SelectedImageIndex = 22;
            treeNode26.Text = "Solution 2";
            treeNode27.ImageIndex = 22;
            treeNode27.Name = "";
            treeNode27.SelectedImageIndex = 22;
            treeNode27.Text = "Trial";
            treeNode28.ImageIndex = 24;
            treeNode28.Name = "";
            treeNode28.SelectedImageIndex = 24;
            treeNode28.Text = "Clerks";
            treeNode29.ImageIndex = 24;
            treeNode29.Name = "";
            treeNode29.SelectedImageIndex = 24;
            treeNode29.Text = "WorkIssue";
            treeNode30.ImageIndex = 25;
            treeNode30.Name = "";
            treeNode30.SelectedImageIndex = 25;
            treeNode30.Text = "QuickSolutions";
            treeNode31.Name = "";
            treeNode31.Text = "Clients";
            treeNode32.ImageIndex = 22;
            treeNode32.Name = "";
            treeNode32.SelectedImageIndex = 22;
            treeNode32.Text = "Office1";
            treeNode33.ImageIndex = 25;
            treeNode33.Name = "";
            treeNode33.SelectedImageIndex = 25;
            treeNode33.Text = "BG Group";
            treeNode34.ImageIndex = 8;
            treeNode34.Name = "";
            treeNode34.SelectedImageIndex = 8;
            treeNode34.Text = "Contacts";
            treeNode35.Name = "";
            treeNode35.Text = "Referrals";
            treeNode36.ImageIndex = 26;
            treeNode36.Name = "";
            treeNode36.SelectedImageIndex = 26;
            treeNode36.Text = "QuickSoft Solutions";
            treeNode37.ImageIndex = 22;
            treeNode37.Name = "";
            treeNode37.SelectedImageIndex = 22;
            treeNode37.Text = "ABCL Sales";
            treeNode38.ImageIndex = 24;
            treeNode38.Name = "";
            treeNode38.SelectedImageIndex = 24;
            treeNode38.Text = "BetaSoft";
            treeNode39.ImageIndex = 8;
            treeNode39.Name = "";
            treeNode39.SelectedImageIndex = 8;
            treeNode39.Text = "NC";
            treeNode40.ImageIndex = 9;
            treeNode40.Name = "";
            treeNode40.SelectedImageIndex = 9;
            treeNode40.Text = "SC";
            treeNode41.Name = "";
            treeNode41.Text = "GA";
            treeNode42.ImageIndex = 27;
            treeNode42.Name = "";
            treeNode42.SelectedImageIndex = 27;
            treeNode42.Text = "ZincLite Inc";
            treeNode43.ImageIndex = 22;
            treeNode43.Name = "";
            treeNode43.SelectedImageIndex = 22;
            treeNode43.Text = "Sales 1";
            treeNode44.ImageIndex = 22;
            treeNode44.Name = "";
            treeNode44.SelectedImageIndex = 22;
            treeNode44.Text = "Sales 2";
            treeNode45.ImageIndex = 10;
            treeNode45.Name = "";
            treeNode45.SelectedImageIndex = 10;
            treeNode45.Text = "Complaints";
            treeNode46.ImageIndex = 23;
            treeNode46.Name = "";
            treeNode46.SelectedImageIndex = 23;
            treeNode46.Text = "MicroCorp";
            this.dwDocumentBrowser.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode33,
            treeNode36,
            treeNode37,
            treeNode38,
            treeNode42,
            treeNode46});
            this.dwDocumentBrowser.SelectedImageIndex = 0;
            this.dwDocumentBrowser.Size = new System.Drawing.Size(183, 411);
            this.dwDocumentBrowser.TabIndex = 11;
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Window");
            this.mainFrameBarManager1.Categories.Add("Help");
            this.mainFrameBarManager1.Categories.Add("Status Bar");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.parentBarItem5,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.parentBarItem2,
            this.barItem15,
            this.barItem20});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // bar1
            // 
            this.bar1.BarName = "MainMenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "MainMenu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem5,
            this.parentBarItem2});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4});
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItem1.Text = "&File";
            // 
            // barItem1
            // 
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "New";
            this.barItem1.ImageIndex = 40;
            this.barItem1.ImageList = this.ilCommon;
            this.barItem1.Text = "New";
            this.barItem1.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Open";
            this.barItem2.ImageIndex = 38;
            this.barItem2.ImageList = this.ilCommon;
            this.barItem2.Text = "Open";
            this.barItem2.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem3
            // 
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "Save";
            this.barItem3.ImageIndex = 39;
            this.barItem3.ImageList = this.ilCommon;
            this.barItem3.Text = "Save";
            this.barItem3.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem4
            // 
            this.barItem4.CategoryIndex = 0;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Exit";
            this.barItem4.Text = "Exit";
            this.barItem4.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.CategoryIndex = 1;
            this.parentBarItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem5.ID = "Window";
            this.parentBarItem5.ImageIndex = 38;
            this.parentBarItem5.ImageList = this.ilCommon;
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem12,
            this.barItem13,
            this.barItem14});
            this.parentBarItem5.MergeOrder = 2;
            this.parentBarItem5.Text = "Window";
            // 
            // barItem12
            // 
            this.barItem12.CategoryIndex = 1;
            this.barItem12.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem12.ID = "Cascade";
            this.barItem12.Text = "Cascade";
            this.barItem12.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem13
            // 
            this.barItem13.CategoryIndex = 1;
            this.barItem13.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem13.ID = "Tile Horizontally";
            this.barItem13.Text = "Tile Horizontally";
            this.barItem13.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // barItem14
            // 
            this.barItem14.CategoryIndex = 1;
            this.barItem14.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem14.ID = "Tile Vertically";
            this.barItem14.Text = "Tile Vertically";
            this.barItem14.Click += new System.EventHandler(this.OnBarItemClick);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.CategoryIndex = 2;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "Help";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem15});
            this.parentBarItem2.MergeOrder = 3;
            this.parentBarItem2.Text = "Help";
            // 
            // barItem15
            // 
            this.barItem15.CategoryIndex = 2;
            this.barItem15.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem15.ID = "About Syncfusion";
            this.barItem15.Text = "About Syncfusion";
            // 
            // barItem20
            // 
            this.barItem20.CategoryIndex = 3;
            this.barItem20.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem20.ID = "Status1";
            this.barItem20.Text = "Status1";
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.CategoryIndex = 1;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "FontFace";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem5,
            this.barItem6,
            this.barItem7,
            this.barItem8});
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem3.Text = "FontFace";
            // 
            // barItem5
            // 
            this.barItem5.CategoryIndex = 1;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "1.Microsoft Sans Seriff";
            this.barItem5.Text = "1. Microsoft Sans Seriff";
            // 
            // barItem6
            // 
            this.barItem6.CategoryIndex = 1;
            this.barItem6.Checked = true;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "2. Calibri";
            this.barItem6.Text = "2. Calibri";
            // 
            // barItem7
            // 
            this.barItem7.CategoryIndex = 1;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "3. Courier New";
            this.barItem7.Text = "3. Courier New";
            // 
            // barItem8
            // 
            this.barItem8.CategoryIndex = 1;
            this.barItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem8.ID = "4. Times New Roman";
            this.barItem8.Text = "4. Times New Roman";
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.CategoryIndex = 1;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "FontSize";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem9});
            this.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem4.Text = "FontSize";
            // 
            // barItem9
            // 
            this.barItem9.CategoryIndex = 1;
            this.barItem9.Checked = true;
            this.barItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem9.ID = "Small";
            this.barItem9.Text = "Small";
            // 
            // barItem10
            // 
            this.barItem10.CategoryIndex = 1;
            this.barItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem10.ID = "Medium";
            this.barItem10.Text = "Medium";
            // 
            // barItem11
            // 
            this.barItem11.CategoryIndex = 1;
            this.barItem11.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem11.ID = "Large";
            this.barItem11.Text = "Large";
            // 
            // cbToolBar
            // 
            this.cbToolBar.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.cbToolBar.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.cbToolBar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.cbToolBar.MaxLength = 200;
            this.cbToolBar.MinHeight = 26;
            this.cbToolBar.MinLength = 50;
            this.cbToolBar.Name = "cbToolBar";
            this.cbToolBar.RowIndex = -1;
            this.cbToolBar.RowOffset = -1;
            this.cbToolBar.TabIndex = 0;
            this.cbToolBar.TabStop = false;
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.toolStripSeparator2,
            this.cmbFontFace,
            this.cmbFontSize,
            this.toolStripSeparator3,
            this.chkOffice2007Mdi,
            this.toolStripSeparator1,
            this.clrSchemeDD});
            this.toolStripEx1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007;
            this.toolStripEx1.Location = new System.Drawing.Point(0, 24);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.toolStripEx1.ShowCaption = false;
            this.toolStripEx1.Size = new System.Drawing.Size(743, 25);
            this.toolStripEx1.TabIndex = 10015;
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cmbFontFace
            // 
            this.cmbFontFace.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Courier New",
            "MS Sans Serif"});
            this.cmbFontFace.Name = "cmbFontFace";
            this.cmbFontFace.Size = new System.Drawing.Size(121, 25);
            this.cmbFontFace.Text = "Font Family";
            this.cmbFontFace.SelectedIndexChanged += new System.EventHandler(this.cmbFontFace_SelectedIndexChanged);
            // 
            // cmbFontSize
            // 
            this.cmbFontSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.cmbFontSize.Name = "cmbFontSize";
            this.cmbFontSize.Size = new System.Drawing.Size(121, 25);
            this.cmbFontSize.Text = "Size";
            this.cmbFontSize.SelectedIndexChanged += new System.EventHandler(this.cmbFontSize_SelectedIndexChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // chkOffice2007Mdi
            // 
            this.chkOffice2007Mdi.Checked = true;
            this.chkOffice2007Mdi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOffice2007Mdi.Name = "chkOffice2007Mdi";
            this.chkOffice2007Mdi.Size = new System.Drawing.Size(130, 22);
            this.chkOffice2007Mdi.Text = "Office 2007 MDI Child";
            this.chkOffice2007Mdi.CheckedChanged += new System.EventHandler(this.chkOffice2007Mdi_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // clrSchemeDD
            // 
            this.clrSchemeDD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueClrScheme,
            this.silverClrScheme,
            this.blackClrScheme,
            this.CustomColorScheme});
            this.clrSchemeDD.Image = ((System.Drawing.Image)(resources.GetObject("clrSchemeDD.Image")));
            this.clrSchemeDD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clrSchemeDD.Name = "clrSchemeDD";
            this.clrSchemeDD.Size = new System.Drawing.Size(102, 22);
            this.clrSchemeDD.Text = "Color Scheme";
            // 
            // blueClrScheme
            // 
            this.blueClrScheme.Checked = true;
            this.blueClrScheme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.blueClrScheme.Name = "blueClrScheme";
            this.blueClrScheme.Size = new System.Drawing.Size(152, 22);
            this.blueClrScheme.Tag = "Blue";
            this.blueClrScheme.Text = "Blue";
            this.blueClrScheme.Click += new System.EventHandler(this.clrSchemeDD_Click);
            // 
            // silverClrScheme
            // 
            this.silverClrScheme.Name = "silverClrScheme";
            this.silverClrScheme.Size = new System.Drawing.Size(152, 22);
            this.silverClrScheme.Tag = "Silver";
            this.silverClrScheme.Text = "Silver";
            this.silverClrScheme.Click += new System.EventHandler(this.clrSchemeDD_Click);
            // 
            // blackClrScheme
            // 
            this.blackClrScheme.Name = "blackClrScheme";
            this.blackClrScheme.Size = new System.Drawing.Size(152, 22);
            this.blackClrScheme.Tag = "Black";
            this.blackClrScheme.Text = "Black";
            this.blackClrScheme.Click += new System.EventHandler(this.clrSchemeDD_Click);
            // 
            // CustomColorScheme
            // 
            this.CustomColorScheme.Name = "CustomColorScheme";
            this.CustomColorScheme.Size = new System.Drawing.Size(152, 22);
            this.CustomColorScheme.Tag = "Custom";
            this.CustomColorScheme.Text = "Custom Color";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(743, 621);
            this.Controls.Add(this.toolStripEx1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI Demo";
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            this.dwNetwork.ResumeLayout(false);
            this.pnlSlnToolBar.ResumeLayout(false);
            this.pnlSlnToolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}		

# endregion
		
        # region Helper methods
		private void CreateNewDocument()
		{
			windowCount++ ;
			Document doc = new Document("Document " + windowCount.ToString());
            doc.FormBorderStyle = FormBorderStyle.None;
            this.dockingManager1.LockDockPanelsUpdate();
            this.dockingManager1.SetEnableDocking(doc,true);
            this.dockingManager1.SetDockLabel(doc, "Document" + windowCount);
            this.dockingManager1.SetAsMDIChild(doc, true);
            this.dockingManager1.UnlockDockPanelsUpdate();
			if(this.cmbFontFace.Enabled == false)
                this.cmbFontFace.Enabled = true;
			if(this.cmbFontSize.Enabled == false)
                this.cmbFontSize.Enabled = true;
			if(this.barItem3.Enabled == false)
                this.barItem3.Enabled = true;
		}

		private void OpenDocument()
		{
			// Create an OpenFileDialog to request a file to open.
			OpenFileDialog openFile1 = new OpenFileDialog();

			// Initialize the OpenFileDialog to look for RTF files.
			openFile1.DefaultExt = "*.rtf";
			openFile1.Filter = "RTF Files|*.rtf";

			// Determine whether the user selected a file from the OpenFileDialog.
			if(openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
				openFile1.FileName.Length > 0) 
			{
				// Create a new document and initialize it with the contents of the file.
				this.CreateNewDocument();
				Document activedoc = this.ActiveMdiChild as Document;
				activedoc.DoLoadDocument(openFile1.FileName);
			}
		}

		private void SaveDocument()
		{
			Form mdichild = this.ActiveMdiChild;
			if((mdichild != null) && (mdichild is Document))
			{
				// Create a SaveFileDialog to request a path and file name to save to.
				SaveFileDialog saveFile1 = new SaveFileDialog();

				// Initialize the SaveFileDialog to specify the RTF extension for the file.
				saveFile1.DefaultExt = "*.rtf";
				saveFile1.Filter = "RTF Files|*.rtf";

				// Determine if the user selected a file name from the saveFileDialog.
				if(saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
					saveFile1.FileName.Length > 0) 
				{
					// Save the contents of the RichTextBox into the file.
					Document activedoc = mdichild as Document;
					activedoc.DoSaveDocument(saveFile1.FileName);
				}
			}
		}

		# endregion

        #region BarItem Click Events

        private void OnBarItemClick(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            switch (item.ID)
            {
                case "New":
                    CreateNewDocument();
                    break;
                case "Open":
                    OpenDocument();
                    break;
                case "Save":
                    SaveDocument();
                    break;
                case "Exit":
                    Application.Exit();
                    break;
                case "Cascade":
                    this.LayoutMdi(MdiLayout.Cascade);
                    break;
                case "Tile Horizontally":
                    this.LayoutMdi(MdiLayout.TileHorizontal);
                    break;
                case "Tile Vertically":
                    this.LayoutMdi(MdiLayout.TileVertical);
                    break;
                case "About Syncfusion":
                    new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies()).ShowDialog();
                    break;

            }

        }

        #endregion

        #region CommandBarEvents & Form Events

        //One of the MDIChild windows has been activated.
		protected void MDIChildActivated(object sender, System.EventArgs e)
		{
            
            if (this.ActiveMdiChild == null)
                barItem20.Text = String.Empty;
            else
                barItem20.Text = this.ActiveMdiChild.Text;
		}

		public void MDIClient_ControlRemoved(object sender,	ControlEventArgs e)
		{
			if(this.MdiChildren.Length == 0)
			{
				this.cmbFontFace.Text = "Font Family";
				this.cmbFontSize.Text = "Size";
                this.cmbFontFace.Enabled = false;
                this.cmbFontSize.Enabled = false;
				this.barItem3.Enabled = false;
			}
		}
		
		protected override void OnMdiChildActivate(EventArgs e)
		{
			base.OnMdiChildActivate(e);

			Form mdichild = this.ActiveMdiChild;
			if((mdichild != null) && (mdichild is Document))
			{
				Document doc = mdichild as Document;
                this.cmbFontFace.Text = doc.CurrentFontFamily;
                this.cmbFontSize.Text = doc.CurrentFontSize;
			}
		}		
		
# endregion

		#region VERSIONING
		static string VersionTag = "AppVersion";
		static void ValidatePersistedStateVersion(string curVersion)
		{
			// Versioning
			AppStateSerializer serializer = AppStateSerializer.GetSingleton();
			object objectOut = serializer.DeserializeObject(VersionTag);
			if(objectOut != null)
			{
				string version = (string)objectOut;
				version = version.ToLower();

				curVersion = curVersion.ToLower();

				// Persisted info is not the current version, let's lose it.
				if(version != curVersion)
					serializer.FlushSerializer();
			}
		}
		// Store the current version, so that we can validate it the next time.
		static void StoreVersionInfo(string curVersion)
		{
			AppStateSerializer serializer = AppStateSerializer.GetSingleton();
			serializer.SerializeObject(VersionTag, curVersion, true);
		}
		#endregion VERSIONING

        #region ToolStripMenuEvents
        private void CustomColorsDropDownImpl()
        {
            ColorPickerUIAdv colorPicker = new ColorPickerUIAdv();
            colorPicker.Picked += new ColorPickerUIAdv.ColorPickedEventHandler(colorPicker_Picked);
            colorPicker.MoreColorsButton.Visible = false;
            colorPicker.StateButton.Visible = false;
          //  colorPicker.Size = new Size(150, 100);
            ToolStripControlHost host = new ToolStripControlHost(colorPicker);
            host.Size = new Size(150, 100);
            colorPicker.Dock = DockStyle.Fill;
            ToolStripDropDown dd = new ToolStripDropDown();
            dd.Items.Add(host);
            //dd.Renderer = new BorderlessRenderer();
            CustomColorScheme.DropDown = dd;
        }

        // Applying Custom color 
        private void colorPicker_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            dockingManager1.Office2007MdiColorScheme = Office2007Theme.Managed;
            dockingManager1.Office2007Theme = Office2007Theme.Managed;
            this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Managed;
            this.toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Managed;
            foreach (Form f in this.MdiChildren)
            {
                if (f != null && f is Document)
                {
                    Document docForm = f as Document;
                    docForm.ColorScheme = Office2007Theme.Managed;
                }

            }

            Office2007Colors.ApplyManagedColors(this, args.Color);
            clrSchemeDD.DropDown.Close();
            ColorSchemeMenuCheck();
            CustomColorScheme.Checked = true;
        }

        private void chkOffice2007Mdi_CheckedChanged(object sender, EventArgs e)
        {
            this.dockingManager1.Office2007MdiChildForm = this.chkOffice2007Mdi.Checked;
        }

        private void cmbFontFace_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbFontFace.Text = this.cmbFontFace.SelectedItem.ToString();
            Form mdichild = this.ActiveMdiChild;
            if ((mdichild != null) && (mdichild is Document))
            {
                Document doc = mdichild as Document;
                doc.CurrentFontFamily = this.cmbFontFace.Text;
            }
        }

        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbFontSize.Text = this.cmbFontSize.SelectedItem.ToString();
            Form mdichild = this.ActiveMdiChild;
            if ((mdichild != null) && (mdichild is Document))
            {
                Document doc = mdichild as Document;
                doc.CurrentFontSize = this.cmbFontSize.Text;
            }
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            CreateNewDocument();
        }

        private void tsbOpen_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void clrSchemeDD_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
          
            switch (menuItem.Tag as string)
            {
                case "Blue":
                    ColorSchemeMenuCheck();
                    blueClrScheme.Checked = true;
                    // Change the MDI Child form colorscheme here.
                    this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Blue;
                    this.dockingManager1.Office2007Theme = Office2007Theme.Blue;
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Blue;

                    this.toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
                    // Change parent form color scheme here.
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Silver":
                    ColorSchemeMenuCheck();
                    silverClrScheme.Checked = true;
                    this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Silver;
                    this.dockingManager1.Office2007Theme = Office2007Theme.Silver;
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Silver;

                    this.toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Silver);
                    break;
                case "Black":
                    ColorSchemeMenuCheck();
                    blackClrScheme.Checked = true;
                    this.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Black;
                    this.dockingManager1.Office2007Theme = Office2007Theme.Black;
                    this.toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Black;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Black);
                    break;
            }

            foreach (Form f in this.MdiChildren)
            {
                if (f != null && f is Document)
                {
                    Document docForm = f as Document;
                    docForm.ColorScheme = (Office2007Theme)Enum.Parse(typeof(Office2007Theme), menuItem.Tag.ToString());
                }

            }
        }

        private void ColorSchemeMenuCheck()
        {
            blueClrScheme.Checked = false;
            silverClrScheme.Checked = false;
            blackClrScheme.Checked = false;
            CustomColorScheme.Checked = false;
        }
        #endregion

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

    }
}
