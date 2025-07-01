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

namespace SDIDemo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
	using Microsoft.Win32;
	using System.Drawing.Drawing2D;
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Syncfusion.Windows.Forms.Office2007Form

    {

# region Members declaration
		private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
		private Syncfusion.Windows.Forms.Tools.DockingClientPanel dockingClientPanel1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboDockLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cboDrag;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cboBrowsingKey;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.CheckedListBox checkedListBox2;
		private System.Windows.Forms.CheckBox cbPaint;
		private System.Windows.Forms.CheckBox cbClose;
		private System.Windows.Forms.CheckBox cbAuto;
		private System.Windows.Forms.CheckBox cbContextMenu;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ToolTip toolTip1;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox cbTreeView;
		private System.Windows.Forms.CheckBox cbListBox;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton rbLBMF;
		private System.Windows.Forms.RadioButton rbTVTB;
		private System.Windows.Forms.RadioButton rbLBTB;
		private System.Windows.Forms.RadioButton rbLBTV;
		private System.Windows.Forms.ListBox listBox2;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cboVisualStyle;
		private System.Windows.Forms.Label label11;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
		private System.Windows.Forms.ImageList ilDocking;
		private System.Windows.Forms.CheckBox cbTextBox;
		private System.Windows.Forms.CheckBox cbAutoHide;
		private System.Windows.Forms.CheckBox cbcheckedlist;
		private System.Windows.Forms.CheckBox checkBox1;
        private ComboBoxBase comboBoxBase1;
        private CheckedListBox checkedListBox3;
        private Label label2;
		private int selectedIndex=0;
		#endregion

# region Initialization
		public Form1()
		{
			//
			// Required for Windows Form Designer support.
			//
			
            InitializeComponent();

            InitEvents(this.dockingManager1);
            this.toolTip1.SetToolTip(this.listBox2, "Press Ctrl+Delete to clear the event logs");
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            AddDockControlsToList();
			
			//
			// TODO: Add any  constructor code after InitializeComponent call.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccblistBox1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbtextBox1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbtreeView1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbcheckedListBox1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbcheckedListBox2 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Enable docking");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Setting dock edge");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Making tabbed windows ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Setting as floaing");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("DesignTimeSupport", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("DockAllow event");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Dragallow event");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("DockVisibilityChanging event");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Events architecture", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("DockToFill mode");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Dissallow Floating");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Docking diamond");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("DockTab settings");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Customization options", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Extensible ");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("DockingManager", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode14,
            treeNode15});
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.ilDocking = new System.Windows.Forms.ImageList(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dockingClientPanel1 = new Syncfusion.Windows.Forms.Tools.DockingClientPanel();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbAutoHide = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPaint = new System.Windows.Forms.CheckBox();
            this.cbClose = new System.Windows.Forms.CheckBox();
            this.cbContextMenu = new System.Windows.Forms.CheckBox();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbLBMF = new System.Windows.Forms.RadioButton();
            this.rbTVTB = new System.Windows.Forms.RadioButton();
            this.rbLBTB = new System.Windows.Forms.RadioButton();
            this.rbLBTV = new System.Windows.Forms.RadioButton();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbcheckedlist = new System.Windows.Forms.CheckBox();
            this.cbTextBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTreeView = new System.Windows.Forms.CheckBox();
            this.cbListBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxBase1 = new Syncfusion.Windows.Forms.Tools.ComboBoxBase();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVisualStyle = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboBrowsingKey = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDrag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboDockLabel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            this.dockingClientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageAdv3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).BeginInit();
            this.tabPageAdv4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.AutoHideTabFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockingManager1.BrowsingKey = System.Windows.Forms.Keys.Delete;
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.DockTabFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockingManager1.ForwardMenuShortcuts = false;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.ImageList = this.ilDocking;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dockingManager1.DockVisibilityChanged += new Syncfusion.Windows.Forms.Tools.DockVisibilityChangedEventHandler(this.dockingManager1_DockVisibilityChanged);
            this.dockingManager1.DockAllow += new Syncfusion.Windows.Forms.Tools.DockAllowEventHandler(this.dockingManager1_DockAllow);
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.SetDockLabel(this.listBox1, "Docking features");
            this.dockingManager1.SetDockIcon(this.listBox1, 1);
            ccblistBox1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.listBox1, ccblistBox1);
            this.dockingManager1.SetDockLabel(this.textBox1, "Description");
            this.dockingManager1.SetDockIcon(this.textBox1, 2);
            ccbtextBox1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.textBox1, ccbtextBox1);
            this.dockingManager1.SetDockLabel(this.treeView1, "Docking Manager ");
            this.dockingManager1.SetDockIcon(this.treeView1, 4);
            ccbtreeView1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.treeView1, ccbtreeView1);
            this.dockingManager1.SetDockLabel(this.checkedListBox1, "DockController Classes");
            this.dockingManager1.SetDockIcon(this.checkedListBox1, 3);
            ccbcheckedListBox1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.checkedListBox1, ccbcheckedListBox1);
            this.dockingManager1.SetDockLabel(this.checkedListBox2, "Docking classes");
            this.dockingManager1.SetDockIcon(this.checkedListBox2, 5);
            ccbcheckedListBox2.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.checkedListBox2, ccbcheckedListBox2);
            // 
            // ilDocking
            // 
            this.ilDocking.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDocking.ImageStream")));
            this.ilDocking.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDocking.Images.SetKeyName(0, "");
            this.ilDocking.Images.SetKeyName(1, "");
            this.ilDocking.Images.SetKeyName(2, "");
            this.ilDocking.Images.SetKeyName(3, "");
            this.ilDocking.Images.SetKeyName(4, "");
            this.ilDocking.Images.SetKeyName(5, "");
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingManager1.SetEnableDocking(this.listBox1, true);
            this.listBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "VS.Net Type Docking windows",
            "Tabbed Docking",
            "Nested docking",
            "Floating windows",
            "Floating  with tabbed controls.",
            "Nested Docking in a Floating window.",
            "AutoHideMode",
            "Docking Diamonds",
            "State persistence",
            "Customization",
            "And much more..."});
            this.listBox1.Location = new System.Drawing.Point(3, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 366);
            this.listBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingManager1.SetEnableDocking(this.textBox1, true);
            this.textBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(3, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(357, 86);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Docking manager";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dockingManager1.SetEnableDocking(this.checkedListBox1, true);
            this.checkedListBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Items.AddRange(new object[] {
            "DockHostController",
            "DockTabController",
            "FloatingFormController",
            "MainFormController",
            "DockControllerBase"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 23);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(329, 63);
            this.checkedListBox1.TabIndex = 13;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dockingManager1.SetEnableDocking(this.checkedListBox2, true);
            this.checkedListBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.checkedListBox2.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox2.IntegralHeight = false;
            this.checkedListBox2.Items.AddRange(new object[] {
            "DockingManager",
            "DockHost",
            "DockTabControl",
            "DockTabPage",
            "FloatingForm",
            "AHTabControl",
            "AHTabPage",
            "FloatingForm",
            "DockingWrapperForm"});
            this.checkedListBox2.Location = new System.Drawing.Point(3, 23);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(329, 63);
            this.checkedListBox2.TabIndex = 15;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Azure;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingManager1.SetEnableDocking(this.treeView1, true);
            this.treeView1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.Black;
            this.treeView1.Location = new System.Drawing.Point(3, 23);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "";
            treeNode1.Text = "Enable docking";
            treeNode2.Name = "";
            treeNode2.Text = "Setting dock edge";
            treeNode3.Name = "";
            treeNode3.Text = "Making tabbed windows ";
            treeNode4.Name = "";
            treeNode4.Text = "Setting as floaing";
            treeNode5.Name = "";
            treeNode5.Text = "DesignTimeSupport";
            treeNode6.Name = "";
            treeNode6.Text = "DockAllow event";
            treeNode7.Name = "";
            treeNode7.Text = "Dragallow event";
            treeNode8.Name = "";
            treeNode8.Text = "DockVisibilityChanging event";
            treeNode9.Name = "";
            treeNode9.Text = "Events architecture";
            treeNode10.Name = "";
            treeNode10.Text = "DockToFill mode";
            treeNode11.Name = "";
            treeNode11.Text = "Dissallow Floating";
            treeNode12.Name = "";
            treeNode12.Text = "Docking diamond";
            treeNode13.Name = "";
            treeNode13.Text = "DockTab settings";
            treeNode14.Name = "";
            treeNode14.Text = "Customization options";
            treeNode15.Name = "";
            treeNode15.Text = "Extensible ";
            treeNode16.Name = "";
            treeNode16.Text = "DockingManager";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode16});
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(111, 366);
            this.treeView1.TabIndex = 11;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dockingClientPanel1
            // 
            this.dockingClientPanel1.Controls.Add(this.tabControlAdv1);
            this.dockingClientPanel1.Controls.Add(this.gradientPanel2);
            this.dockingClientPanel1.Location = new System.Drawing.Point(121, 0);
            this.dockingClientPanel1.Name = "dockingClientPanel1";
            this.dockingClientPanel1.Size = new System.Drawing.Size(448, 392);
            this.dockingClientPanel1.SizeToFit = true;
            this.dockingClientPanel1.TabIndex = 4;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(229)))), ((int)(((byte)(238)))));
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(210)))), ((int)(((byte)(229)))));
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.SeaShell;
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(25, 22);
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 68);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Padding = new System.Drawing.Point(6, 1);
            this.tabControlAdv1.Size = new System.Drawing.Size(448, 324);
            this.tabControlAdv1.TabIndex = 2;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.Renderers.DockTabRendererOffice2007);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.tabPageAdv1.Controls.Add(this.textBox2);
            this.tabPageAdv1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 24);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(445, 298);
            this.tabPageAdv1.TabFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Introduction";
            this.tabPageAdv1.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabPageAdv1, "Gives a brief introduction about the usage of DockingClientPanel");
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.textBox2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(69)))), ((int)(((byte)(113)))));
            this.textBox2.Location = new System.Drawing.Point(9, 8);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(428, 285);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.tabPageAdv2.Controls.Add(this.gradientPanel1);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 24);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(699, 298);
            this.tabPageAdv2.TabIndex = 1;
            this.tabPageAdv2.Text = "Behavior";
            this.tabPageAdv2.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabPageAdv2, "Contain options to change the behaviour of docking");
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.gradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.gradientPanel1.Controls.Add(this.panel2);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(699, 298);
            this.gradientPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.cbAutoHide);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbPaint);
            this.panel2.Controls.Add(this.cbClose);
            this.panel2.Controls.Add(this.cbContextMenu);
            this.panel2.Controls.Add(this.cbAuto);
            this.panel2.Location = new System.Drawing.Point(477, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 240);
            this.panel2.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(24, 214);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 21);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Freeze resizing";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbAutoHide
            // 
            this.cbAutoHide.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAutoHide.Location = new System.Drawing.Point(24, 43);
            this.cbAutoHide.Name = "cbAutoHide";
            this.cbAutoHide.Size = new System.Drawing.Size(144, 21);
            this.cbAutoHide.TabIndex = 12;
            this.cbAutoHide.Text = "Disable AutoHide";
            this.cbAutoHide.CheckedChanged += new System.EventHandler(this.cbAutoHide_CheckedChanged_1);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "State Attributes";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPaint
            // 
            this.cbPaint.Checked = true;
            this.cbPaint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPaint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbPaint.Location = new System.Drawing.Point(24, 107);
            this.cbPaint.Name = "cbPaint";
            this.cbPaint.Size = new System.Drawing.Size(120, 22);
            this.cbPaint.TabIndex = 8;
            this.cbPaint.Text = "Paint Border";
            this.cbPaint.CheckedChanged += new System.EventHandler(this.cbPaint_CheckedChanged);
            // 
            // cbClose
            // 
            this.cbClose.Checked = true;
            this.cbClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbClose.Location = new System.Drawing.Point(24, 143);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(120, 22);
            this.cbClose.TabIndex = 9;
            this.cbClose.Text = "Close Enabled";
            this.cbClose.CheckedChanged += new System.EventHandler(this.cbClose_CheckedChanged);
            // 
            // cbContextMenu
            // 
            this.cbContextMenu.Checked = true;
            this.cbContextMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbContextMenu.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbContextMenu.Location = new System.Drawing.Point(24, 179);
            this.cbContextMenu.Name = "cbContextMenu";
            this.cbContextMenu.Size = new System.Drawing.Size(120, 21);
            this.cbContextMenu.TabIndex = 11;
            this.cbContextMenu.Text = "Context Menu";
            this.cbContextMenu.CheckedChanged += new System.EventHandler(this.cbContextMenu_CheckedChanged);
            // 
            // cbAuto
            // 
            this.cbAuto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbAuto.Location = new System.Drawing.Point(24, 72);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(136, 21);
            this.cbAuto.TabIndex = 10;
            this.cbAuto.Text = "Themes Enabled";
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.rbLBMF);
            this.panel1.Controls.Add(this.rbTVTB);
            this.panel1.Controls.Add(this.rbLBTB);
            this.panel1.Controls.Add(this.rbLBTV);
            this.panel1.Location = new System.Drawing.Point(18, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 240);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Docking Customization";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(8, 215);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(168, 21);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Allow All";
            // 
            // rbLBMF
            // 
            this.rbLBMF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbLBMF.Location = new System.Drawing.Point(8, 179);
            this.rbLBMF.Name = "rbLBMF";
            this.rbLBMF.Size = new System.Drawing.Size(190, 21);
            this.rbLBMF.TabIndex = 3;
            this.rbLBMF.Text = "Disallow ListBox-MainForm";
            // 
            // rbTVTB
            // 
            this.rbTVTB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbTVTB.Location = new System.Drawing.Point(8, 136);
            this.rbTVTB.Name = "rbTVTB";
            this.rbTVTB.Size = new System.Drawing.Size(190, 21);
            this.rbTVTB.TabIndex = 2;
            this.rbTVTB.Text = "Disallow TreeView-TextBox";
            // 
            // rbLBTB
            // 
            this.rbLBTB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbLBTB.Location = new System.Drawing.Point(8, 86);
            this.rbLBTB.Name = "rbLBTB";
            this.rbLBTB.Size = new System.Drawing.Size(168, 33);
            this.rbLBTB.TabIndex = 1;
            this.rbLBTB.Text = "Disallow ListBox-TextBox";
            // 
            // rbLBTV
            // 
            this.rbLBTV.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbLBTV.Location = new System.Drawing.Point(9, 38);
            this.rbLBTV.Name = "rbLBTV";
            this.rbLBTV.Size = new System.Drawing.Size(168, 34);
            this.rbLBTV.TabIndex = 0;
            this.rbLBTV.Text = "Disallow ListBox-TreeView";
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.tabPageAdv3.Controls.Add(this.panel4);
            this.tabPageAdv3.Controls.Add(this.panel3);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 24);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.Size = new System.Drawing.Size(699, 298);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.Text = "Miscellaneous";
            this.tabPageAdv3.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabPageAdv3, "Contain customization options");
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbcheckedlist);
            this.panel4.Controls.Add(this.cbTextBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.cbTreeView);
            this.panel4.Controls.Add(this.cbListBox);
            this.panel4.Location = new System.Drawing.Point(8, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(682, 73);
            this.panel4.TabIndex = 17;
            // 
            // cbcheckedlist
            // 
            this.cbcheckedlist.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbcheckedlist.Location = new System.Drawing.Point(39, 47);
            this.cbcheckedlist.Name = "cbcheckedlist";
            this.cbcheckedlist.Size = new System.Drawing.Size(168, 22);
            this.cbcheckedlist.TabIndex = 11;
            this.cbcheckedlist.Text = "Hide CheckedListBoxes";
            this.cbcheckedlist.CheckStateChanged += new System.EventHandler(this.cbcheckedlist_CheckStateChanged);
            // 
            // cbTextBox
            // 
            this.cbTextBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTextBox.Location = new System.Drawing.Point(223, 20);
            this.cbTextBox.Name = "cbTextBox";
            this.cbTextBox.Size = new System.Drawing.Size(144, 21);
            this.cbTextBox.TabIndex = 10;
            this.cbTextBox.Text = "Hide TextBox";
            this.cbTextBox.CheckedChanged += new System.EventHandler(this.cbTextBox_CheckedChanged_1);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(680, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Visibility";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbTreeView
            // 
            this.cbTreeView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTreeView.Location = new System.Drawing.Point(223, 47);
            this.cbTreeView.Name = "cbTreeView";
            this.cbTreeView.Size = new System.Drawing.Size(144, 22);
            this.cbTreeView.TabIndex = 1;
            this.cbTreeView.Text = "Hide TreeView";
            this.cbTreeView.CheckedChanged += new System.EventHandler(this.cbTreeView_CheckedChanged);
            // 
            // cbListBox
            // 
            this.cbListBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbListBox.Location = new System.Drawing.Point(39, 20);
            this.cbListBox.Name = "cbListBox";
            this.cbListBox.Size = new System.Drawing.Size(144, 22);
            this.cbListBox.TabIndex = 0;
            this.cbListBox.Text = "Hide ListBox";
            this.cbListBox.CheckedChanged += new System.EventHandler(this.cbListBox_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.comboBoxBase1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cboVisualStyle);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cboBrowsingKey);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cboDrag);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.cboDockLabel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.checkedListBox3);
            this.panel3.Location = new System.Drawing.Point(8, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 208);
            this.panel3.TabIndex = 16;
            // 
            // comboBoxBase1
            // 
            this.comboBoxBase1.BackColor = System.Drawing.Color.White;
            this.comboBoxBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase1.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System;
            this.comboBoxBase1.IgnoreThemeBackground = true;
            this.comboBoxBase1.ListControl = this.checkedListBox3;
            this.comboBoxBase1.Location = new System.Drawing.Point(193, 174);
            this.comboBoxBase1.Name = "comboBoxBase1";
            this.comboBoxBase1.Size = new System.Drawing.Size(160, 21);
            this.comboBoxBase1.SuppressDropDownEvent = false;
            this.comboBoxBase1.TabIndex = 14;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.BackColor = System.Drawing.Color.White;
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(277, -68);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(160, 72);
            this.checkedListBox3.TabIndex = 12;
            this.checkedListBox3.SelectedIndexChanged += new System.EventHandler(this.checkedListBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Set Freeze/UnFreeze \r\nto DockedControls";
            // 
            // cboVisualStyle
            // 
            this.cboVisualStyle.BackColor = System.Drawing.Color.White;
            this.cboVisualStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisualStyle.Items.AddRange(new object[] {
            "Default",
            "Office2003",
            "OfficeXP",
            "Office2007",
            "VS2005",
            "Office2007Outlook"});
            this.cboVisualStyle.Location = new System.Drawing.Point(193, 139);
            this.cboVisualStyle.Name = "cboVisualStyle";
            this.cboVisualStyle.Size = new System.Drawing.Size(160, 24);
            this.cboVisualStyle.TabIndex = 10;
            this.cboVisualStyle.SelectedIndexChanged += new System.EventHandler(this.cboVisualStyle_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(37, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 21);
            this.label10.TabIndex = 9;
            this.label10.Text = "Visual Style";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(680, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "General Properties";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboBrowsingKey
            // 
            this.cboBrowsingKey.BackColor = System.Drawing.Color.White;
            this.cboBrowsingKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrowsingKey.Items.AddRange(new object[] {
            "Back",
            "Del",
            "End",
            "Enter",
            "F1",
            "F10",
            "F11",
            "F12",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "Home",
            "Insert",
            "PgDn",
            "PgUp"});
            this.cboBrowsingKey.Location = new System.Drawing.Point(193, 110);
            this.cboBrowsingKey.Name = "cboBrowsingKey";
            this.cboBrowsingKey.Size = new System.Drawing.Size(160, 24);
            this.cboBrowsingKey.TabIndex = 7;
            this.cboBrowsingKey.SelectedIndexChanged += new System.EventHandler(this.cboBrowsingKey_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "BrowsingKey";
            // 
            // cboDrag
            // 
            this.cboDrag.BackColor = System.Drawing.Color.White;
            this.cboDrag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrag.Items.AddRange(new object[] {
            "Standard",
            "VS2005",
            "Whidbey"});
            this.cboDrag.Location = new System.Drawing.Point(193, 81);
            this.cboDrag.Name = "cboDrag";
            this.cboDrag.Size = new System.Drawing.Size(160, 24);
            this.cboDrag.TabIndex = 5;
            this.cboDrag.SelectedIndexChanged += new System.EventHandler(this.cboDrag_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Drag Provider Style";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Left",
            "Right"});
            this.comboBox1.Location = new System.Drawing.Point(193, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cboDockLabel
            // 
            this.cboDockLabel.BackColor = System.Drawing.Color.White;
            this.cboDockLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDockLabel.Items.AddRange(new object[] {
            "Center",
            "Default",
            "Left",
            "Right"});
            this.cboDockLabel.Location = new System.Drawing.Point(193, 24);
            this.cboDockLabel.Name = "cboDockLabel";
            this.cboDockLabel.Size = new System.Drawing.Size(160, 24);
            this.cboDockLabel.TabIndex = 1;
            this.cboDockLabel.SelectedIndexChanged += new System.EventHandler(this.cboDockLabel_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(37, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "DockTab Alignment";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(37, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "DockLabel Alignment";
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            this.tabPageAdv4.Controls.Add(this.listBox2);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 24);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.Size = new System.Drawing.Size(699, 298);
            this.tabPageAdv4.TabIndex = 3;
            this.tabPageAdv4.Text = "Events Log";
            this.tabPageAdv4.ThemesEnabled = false;
            this.toolTip1.SetToolTip(this.tabPageAdv4, "Displays the information about the events fired");
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.IntegralHeight = false;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(9, 7);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(682, 285);
            this.listBox2.TabIndex = 1;
            this.listBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox2_KeyDown);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.White;
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245))))));
            this.gradientPanel2.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.label11);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(448, 392);
            this.gradientPanel2.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(233)))), ((int)(((byte)(244)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(448, 392);
            this.label11.TabIndex = 2;
            this.label11.Text = "Syncfusion Docking Windows";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 0;
            this.toolTip1.ShowAlways = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(702, 508);
            this.Controls.Add(this.dockingClientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDI Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            this.dockingClientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPageAdv3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBase1)).EndInit();
            this.tabPageAdv4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			Application.Run(new Form1());
		}
# endregion

# region Event handlers-DockingManager
		private void dockingManager1_DockAllow(object sender, Syncfusion.Windows.Forms.Tools.DockAllowEventArgs arg)
		{
			if(this.rbLBTB.Checked == true)
			{
				// Disallow docking the list box to the text box. 
				// If the list box or the text box are either of the dock event's 
				// DragControl or the TargetControl, then cancel the dock operation.
				if( ((arg.DragControl == this.listBox1) || (arg.TargetControl == this.listBox1))
					&& ((arg.DragControl == this.textBox1) || (arg.TargetControl == this.textBox1)) )
					arg.Cancel = true;
				
			}

			if(this.rbLBTV.Checked == true)
			{
				if( ((arg.DragControl == this.listBox1) || (arg.TargetControl == this.listBox1))
					&& ((arg.DragControl == this.treeView1) || (arg.TargetControl == this.treeView1)) )
					arg.Cancel = true;
			}

			if(this.rbTVTB.Checked == true)
			{
				if( ((arg.DragControl == this.treeView1) || (arg.TargetControl == this.treeView1))
					&& ((arg.DragControl == this.textBox1) || (arg.TargetControl == this.textBox1)) )
					arg.Cancel = true;
			}

			if(this.rbLBMF.Checked == true)
			{
				// Disallow docking the list box to the application's main form. 
				// In this case, the list box will be the DragControl and the main form 
				// will be TargetControl. If this is True, then cancel the operation.
				if( (arg.DragControl == this.listBox1) && (arg.TargetControl == this) )
					arg.Cancel = true;
			}
		}
		private void dockingManager1_DockVisibilityChanged(object sender, Syncfusion.Windows.Forms.Tools.DockVisibilityChangedEventArgs arg)
		{
			// Based on the control dockvisibility state and sets the state for the check boxes.
			if(arg.Control == this.listBox1)
				this.cbListBox.Checked = !this.dockingManager1.GetDockVisibility(this.listBox1);
			if(arg.Control == this.treeView1)
				this.cbTreeView.Checked = !this.dockingManager1.GetDockVisibility(this.treeView1);
			if(arg.Control == this.textBox1)
				this.cbTextBox.Checked = !this.dockingManager1.GetDockVisibility(this.textBox1);
		}		

		#endregion	

		#region Setting Dock Label property
		private void cboDockLabel_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			//Sets the DockLabelAlignment Property
			switch((string)this.cboDockLabel.SelectedItem)
			{
				case "Left":
					this.dockingManager1.DockLabelAlignment=Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Left;
					break;
				case "Right":
					this.dockingManager1.DockLabelAlignment=Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Right;
					break;
				case "Center":
					this.dockingManager1.DockLabelAlignment=Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Center;
					break;
				case "Default":
					this.dockingManager1.DockLabelAlignment=Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Default;
					break;
			}

		}
		#endregion

		#region Setting Dock Tab Alignment property
		
		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Sets Dock Tab Alignment Property
			switch((string)this.comboBox1.SelectedItem)
				
			{
				case "Left":
					this.dockingManager1.DockTabAlignment=Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Left;
					break;
				case "Right":
					this.dockingManager1.DockTabAlignment=Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Right;
					break;
				case "Top":
					this.dockingManager1.DockTabAlignment=Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Top;
					break;
				case "Bottom":
					this.dockingManager1.DockTabAlignment=Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Bottom;
					break;
			}

		}
		#endregion

		#region Setting DragProvider Style for Docking Manager
		private void cboDrag_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Sets Dragprovider Style Property
			switch((string)this.cboDrag.SelectedItem)
				
			{
				case "Standard":
					this.dockingManager1.DragProviderStyle=Syncfusion.Windows.Forms.Tools.DragProviderStyle.Standard;
					break;
				case "VS2005":
					this.dockingManager1.DragProviderStyle=Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2005;
					break;
				case "Whidbey":
					this.dockingManager1.DragProviderStyle=Syncfusion.Windows.Forms.Tools.DragProviderStyle.Whidbey;
					break;

				
			}
		}
		#endregion

		#region Setting Browsing key for Docking windows
		private void cboBrowsingKey_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Sets Docking windows Browsing Key property
			switch((string)this.cboBrowsingKey.SelectedItem)
				
			{		
				case "PgDn":
					this.dockingManager1.BrowsingKey = ((System.Windows.Forms.Keys)(Enum.Parse(typeof(Keys),"Next")));
					break;
				case "PgUp":
					this.dockingManager1.BrowsingKey = ((System.Windows.Forms.Keys)(Enum.Parse(typeof(Keys),"Prior")));
					break;
				case "Del":
					this.dockingManager1.BrowsingKey = ((System.Windows.Forms.Keys)(Enum.Parse(typeof(Keys),"Delete")));
					break;

				default:
					this.dockingManager1.BrowsingKey = ((System.Windows.Forms.Keys)(Enum.Parse(typeof(Keys),(string)this.cboBrowsingKey.SelectedItem )));
					break;
			}
			
				
			
		}
		#endregion

		#region State Attributes changed events
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.dockingManager1.FreezeResizing=checkBox1.Checked;
		}
		private void cbPaint_CheckedChanged(object sender, System.EventArgs e)
		{
			// Show/Hides the Border of the docking window
			this.dockingManager1.PaintBorders=this.cbPaint.Checked;
			
		}

		private void cbClose_CheckedChanged(object sender, System.EventArgs e)
		{
			this.dockingManager1.CloseEnabled=this.cbClose.Checked;

		}

		private void cbAuto_CheckedChanged(object sender, System.EventArgs e)
		{
			this.dockingManager1.ThemesEnabled=this.cbAuto.Checked;
		}

		private void cbContextMenu_CheckedChanged(object sender, System.EventArgs e)
		{
			this.dockingManager1.EnableContextMenu=this.cbContextMenu.Checked;
		}
		#endregion 

		#region Initialize Docking Manager Events
		public void InitEvents(DockingManager dm)
		{
			dm.AutoHideAnimationStart+=new AutoHideAnimationEventHandler(dm_AutoHideAnimationStart);
			dm.AutoHideAnimationStop+=new AutoHideAnimationEventHandler(dm_AutoHideAnimationStop);
			dm.DockAllow+=new DockAllowEventHandler(dm_DockAllow);
			dm.DockContextMenu+=new DockContextMenuEventHandler(dm_DockContextMenu);
			dm.DockControlActivated+=new DockActivationChangedEventHandler(dm_DockControlActivated);
			dm.DockControlDeactivated+=new DockActivationChangedEventHandler(dm_DockControlDeactivated);
			dm.DockMenuClick+=new DockMenuClickEventHandler(dm_DockMenuClick);
			dm.DockStateChanged+=new DockStateChangeEventHandler(dm_DockStateChanged);
			dm.DockStateChanging+=new DockStateChangeEventHandler(dm_DockStateChanging);
			dm.DockStateUnavailable+=new DockStateUnavailableEventHandler(dm_DockStateUnavailable);
			dm.DockVisibilityChanged+=new DockVisibilityChangedEventHandler(dm_DockVisibilityChanged);
			dm.DockVisibilityChanging+=new DockVisibilityChangingEventHandler(dm_DockVisibilityChanging);
			dm.DragAllow+=new DragAllowEventHandler(dm_DragAllow);
			dm.DragFeedbackStart+=new EventHandler(dm_DragFeedbackStart);
			dm.DragFeedbackStop+=new EventHandler(dm_DragFeedbackStop);
			dm.ImageListChanged+=new EventHandler(dm_ImageListChanged);
			dm.InitializeControlOnLoad+=new InitializeControlOnLoadEventHandler(dm_InitializeControlOnLoad);
			dm.NewDockStateBeginLoad+=new EventHandler(dm_NewDockStateBeginLoad);
			dm.NewDockStateEndLoad+=new EventHandler(dm_NewDockStateEndLoad);
			dm.ProvideGraphicsItems+=new ProvideGraphicsItemsEventHandler(dm_ProvideGraphicsItems);
			dm.ProvidePersistenceID+=new Syncfusion.Windows.Forms.ProvidePersistenceIDEventHandler(dm_ProvidePersistenceID);
			dm.TransferredToManager+=new TransferManagerEventHandler(dm_TransferredToManager);
			dm.TransferringFromManager+=new TransferManagerEventHandler(dm_TransferringFromManager);
		}
		#endregion //Initialize Events

		#region Standard Docking Manager Events
		
		//The AutoHideAnimationStart event occurs just before the start of an autohide animation.
		private void dm_AutoHideAnimationStart(object sender, AutoHideAnimationEventArgs arg)
		{
			selectedIndex=this.listBox2.Items.Add("AutoHide Animation Start - "+arg.Control.Name);
			SetIndex(selectedIndex);
			
		}

		//The AutoHideAnimationStop event occurs immediately after the end of an autohide animation.
		private void dm_AutoHideAnimationStop(object sender, AutoHideAnimationEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("AutoHide Animation Stop - "+arg.Control.Name);	
			SetIndex(selectedIndex);
		}

		//The DockAllow event occurs when a docking window is dragged over a potential dock target.
		private void dm_DockAllow(object sender, DockAllowEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Allow Event - "+"Drag Control - ["+arg.DragControl.Name+"], Target Control - ["+arg.TargetControl.Name+"], Docking Style  - ["+arg.DockStyle.ToString()+"]");	
			SetIndex(selectedIndex);
		}

		//The DockContextMenu event occurs when the right mouse button is clicked over a docking window's caption.
		private void dm_DockContextMenu(object sender, DockContextMenuEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Context Menu - Owner control ["+arg.Owner.Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DockControlActivated event occurs when a dockable control gets activated.
		private void dm_DockControlActivated(object sender, DockActivationChangedEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Control Activated - [" +arg.Control.Name+"]");	
			SetIndex(selectedIndex);
			
		}

		//The DockControlDeactivated event occurs when a dockable control gets deactivated.
		private void dm_DockControlDeactivated(object sender, DockActivationChangedEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Control Deactivated - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}

		//
		private void dm_DockMenuClick(object sender, DockMenuClickEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Menu Click Event - ["+arg.Control.Name+"]" +" Docking Style ["+arg.DockingStyle.ToString()+"]");	
			SetIndex(selectedIndex);
		}

		//The DockStateChanged event occurs immediately after a dock operation.
		private void dm_DockStateChanged(object sender, DockStateChangeEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock State Changed - ["+arg.Controls[0].Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DockStateChanging event occurs just before a dock operation takes place.
		private void dm_DockStateChanging(object sender, DockStateChangeEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock State Changing - ["+ arg.Controls[0].Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DockStateUnavailable event occurs if serialized information is not available for a dockable control when loading a persisted dock state.
		private void dm_DockStateUnavailable(object sender, DockStateUnavailableEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock State Unavailable - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DockVisibilityChanged event occurs after a control's DockVisibility state has changed.
		private void dm_DockVisibilityChanged(object sender, DockVisibilityChangedEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Visibility Changed - ["+arg.Control.Name+"],Action -"+arg.Action.ToString() );	
			SetIndex(selectedIndex);
		}

		//The DockVisibilityChanging event occurs during a control's DockVisibility state is changing.
		private void dm_DockVisibilityChanging(object sender, DockVisibilityChangingEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Dock Visibility Changing - ["+arg.Control.Name+"],Action -"+arg.Action.ToString());	
			SetIndex(selectedIndex);
		}

		//The DragAllow event occurs when a docking window is about to be dragged.
		private void dm_DragAllow(object sender, DragAllowEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Drag Allow Event - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}

		//The DragFeedbackStart event occurs just before the start of feedback of a drag operation.
		private void dm_DragFeedbackStart(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("Drag Feedback Start");	
			SetIndex(selectedIndex);
		}

		//The DragFeedbackStop event occurs immediately after the end of feedback of a drag operation.
		private void dm_DragFeedbackStop(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("Drag Feedback Stop");	
			SetIndex(selectedIndex);
		}

		// Occurs when the ImageList property changes.
		private void dm_ImageListChanged(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("Image List Changed");	
			SetIndex(selectedIndex);
		}

		//The InitializeControlOnLoad event occurs when the DockingManager is not able to locate a control during a LoadDockState call.
		private void dm_InitializeControlOnLoad(object sender, InitializeControlOnLoadEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Initialize Control On Load - ["+arg.ControlName+"]");	
			SetIndex(selectedIndex);
		}

		//The NewDockStateBeginLoad event occurs just before a new dock state is loaded.
		private void dm_NewDockStateBeginLoad(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("New Dock State Begin Load");	
			SetIndex(selectedIndex);
		}

		//The NewDockStateEndLoad event occurs immediately after a new dock state has been loaded.
		private void dm_NewDockStateEndLoad(object sender, EventArgs e)
		{
			selectedIndex=listBox2.Items.Add("New Dock State End Load");	
			SetIndex(selectedIndex);
		}

		//The ProvideGraphicsItems event occurs whenever a dockable control's caption needs to be painted.
		private void dm_ProvideGraphicsItems(object sender, ProvideGraphicsItemsEventArgs arg)
		{
            if (arg.Control != null)
            {
                selectedIndex = listBox2.Items.Add("Provide Graphics Items - [" + arg.Control.Name + "]");
                SetIndex(selectedIndex);
            }
		}

		//Lets you specify a unique ID used to distinguish the persistence information of different instances of the Form type.
		private void dm_ProvidePersistenceID(object sender, Syncfusion.Windows.Forms.ProvidePersistenceIDEventArgs e)
		{
			selectedIndex=listBox2.Items.Add("Provide Persistence ID");	
			SetIndex(selectedIndex);
		}

		//The TransferredToManager event occurs after a dockable control that previously belonged to some other DockingManager has been transferred to the docking layout hosted by this DockingManager.
		private void dm_TransferredToManager(object sender, TransferManagerEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Transferred To Manager - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}

		//The TransferringFromManager event occurs when a dockable control hosted by this DockingManager is about to be transferred to the docking layout hosted by some other DockingManager.
		private void dm_TransferringFromManager(object sender, TransferManagerEventArgs arg)
		{
			selectedIndex=listBox2.Items.Add("Transferring From Manager - ["+arg.Control.Name+"]");	
			SetIndex(selectedIndex);
		}
		#endregion //Standard Events
		
		#region Selects the currently added item
		private void SetIndex(int i)
		{
			this.listBox2.SelectedIndex=i;
		}
		#endregion

		#region Setting Tooltip and Delete all listbox item in KeyDown Event
		private void listBox2_MouseHover(object sender, System.EventArgs e)
		{
			this.toolTip1.SetToolTip(this.listBox2,"Press Ctrl+Delete to clear the event logs");
		}

		private void listBox2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==System.Windows.Forms.Keys.Delete|e.KeyCode==System.Windows.Forms.Keys.Control)
				this.listBox2.Items.Clear();
		}
		#endregion
       
        # region Event handlers
		    private void cbListBox_CheckedChanged(object sender, System.EventArgs e)
		    {
    			
			    this.dockingManager1.SetDockVisibility(this.listBox1, !cbListBox.Checked );
    			
		    } 

		    private void cbTreeView_CheckedChanged(object sender, System.EventArgs e)
		    {
			    // Shows / hides the treeview.
			    if(this.cbTreeView.Checked == true)
				    this.dockingManager1.SetDockVisibility(this.treeView1, false);
			    else
				    this.dockingManager1.SetDockVisibility(this.treeView1, true);			
		    }

		    private void cbTextBox_CheckedChanged(object sender, System.EventArgs e)
		    {
			    // Shows / hides the text box.
			    if(this.cbTextBox.Checked == true)
				    this.dockingManager1.SetDockVisibility(this.textBox1, false);
			    else
				    this.dockingManager1.SetDockVisibility(this.textBox1, true);			

		    }

		    private void cbAutoHide_CheckedChanged(object sender, System.EventArgs e)
		    {
			    // Enables / disables the autohide mode for the DockingManager.
			    if(this.cbAutoHide.Checked == true)
				    this.dockingManager1.AutoHideEnabled = false;
			    else
				    this.dockingManager1.AutoHideEnabled = true;		
		    }

    		
		    private void cboVisualStyle_SelectedIndexChanged(object sender, System.EventArgs e)
		    {
				    //Sets Visual Style Property
				    switch((string)this.cboVisualStyle.SelectedItem)
    				
				    {
					    case "Default":
						    this.dockingManager1.VisualStyle=Syncfusion.Windows.Forms.VisualStyle.Default;
						    break;
					    case "Office2003":
						    this.dockingManager1.VisualStyle=Syncfusion.Windows.Forms.VisualStyle.Office2003;
						    break;
					    case "OfficeXP":
						    this.dockingManager1.VisualStyle=Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
						    break;
					    case "Office2007":
						    this.dockingManager1.VisualStyle=Syncfusion.Windows.Forms.VisualStyle.Office2007;
						    break;
					    case "VS2005":
						    this.dockingManager1.VisualStyle=Syncfusion.Windows.Forms.VisualStyle.VS2005 ;
						    break;
                        case "Office2007Outlook":
                            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
                            break;
				    }
		    }
		    private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		    {
			    switch(e.Node.Text)
			    {
				    case "DockingManager": textBox1.Text="At the most basic level a docking window may be defined as a control that attaches itself to a host form's border. Windows Forms provides basic support for docking capapbilities through the Dock property of the control class.";break;
				    case "DesignTimeSupport":textBox1.Text="Docking architecture offers a true design time support";break;
				    case "Events architecture":textBox1.Text="Dockingmanager has numerous events which help to interact the docking operations";break;
				    case "Customization options":textBox1.Text="Docking manager has so much properties to make the docking customization";break;
				    case "Extensible ": textBox1.Text="Docking architecture is extensible too by using inheritance.For example if you want to change the autohide tab font and color you can inherit the DockingManager class";break;
				    case "Enable docking":textBox1.Text="The docking for an control can be easily enabled by just setting a property 'EnableDocking On DockingManager'";break;
				    case "Setting dock edge":textBox1.Text="Drag a docked window to the edge of the form that will then stick to that edge";break;
				    case "Making tabbed windows ":textBox1.Text="Drag a docked window to the title bar of another docked window, they will then became tabbed";break;
				    case "Setting as floaing":textBox1.Text="Just drag out the window ,it then will be free from form ie floating";break;
				    case "DockAllow event":textBox1.Text="A powerful event which will fire each time before a docking operation.It also allows to cancel the operation";break;
				    case "Dragallow event":textBox1.Text="The event which will fire before any drag opeation takes place";break;
				    case "DockVisibilityChanging event":textBox1.Text="Fires before we close any of the docked window.It offers the facility to cancel the closing.";break;
				    case "DockToFill mode":textBox1.Text="Specifies whether the docked windows should resize to the empty space in the host form";break;
				    case "Dissallow Floating":textBox1.Text="If it is set to true,DockingManager wont allow any window to be floated";break;
				    case "Docking diamond":textBox1.Text="Allows to set the style of dock prediction bands";break;
				    case "DockTab settings":textBox1.Text="There are 3 properties DockTabAllignment,DockTabHeight,DockTabFont which help to customize the docktab";break;
			    }
		    }
		    private void Form1_Load(object sender, System.EventArgs e)
		    {
			    cboDockLabel.SelectedIndex=2;
			    comboBox1.SelectedIndex=1;
			    cboDrag.SelectedIndex=1;
			    cboBrowsingKey.SelectedIndex=1;
			    cboVisualStyle.SelectedIndex=3;
                comboBoxBase1.Text = this.dockingManager1.GetDockLabel(this.treeView1);
                this.dockingManager1.SetFreezeResize(this.treeView1,true);
                this.checkedListBox3.SetItemChecked(4, true);
		    }
		    private void cbcheckedlist_CheckStateChanged(object sender, System.EventArgs e)
		    {
			    dockingManager1.SetDockVisibility(checkedListBox1,!cbcheckedlist.Checked );
			    dockingManager1.SetDockVisibility(checkedListBox2,!cbcheckedlist.Checked );
		    }
		    private void cbTextBox_CheckedChanged_1(object sender, System.EventArgs e)
		    {
			    dockingManager1.SetDockVisibility(textBox1,!cbTextBox.Checked);
		    }
		    private void cbAutoHide_CheckedChanged_1(object sender, System.EventArgs e)
		    {
			    dockingManager1.AutoHideEnabled=! cbAutoHide.Checked ;
		    }
    # endregion

        #region Freeze/Unfreeze

            private void AddDockControlsToList()
            {
                this.checkedListBox3.Items.Clear();
                foreach (Control c in this.dockingManager1.ControlsArray)
                {
                    //this.checkedListBox3.Items.Add(c.Name, this.dockingManager1.GetFreezeResize(c));
                    this.checkedListBox3.Items.Add(this.dockingManager1.GetDockLabel(c).ToString(), this.dockingManager1.GetFreezeResize(c));
                }
            }

            private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
            {
              Control ctrl = GetDockedControl(this.checkedListBox3.SelectedItem.ToString());
                if (ctrl != null)
                {
                    if (this.checkedListBox3.GetItemChecked(this.checkedListBox3.SelectedIndex))
                        this.dockingManager1.SetFreezeResize(ctrl, true);
                    else
                        this.dockingManager1.SetFreezeResize(ctrl, false);

                }
            }

            private Control GetDockedControl(string name)
            {
                foreach (Control c in this.dockingManager1.ControlsArray)
                {
                    if (this.dockingManager1.GetDockLabel(c).ToString() == name)
                        return c;
                }
                return null;
            }

            #endregion		

		

		
	}
}
