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
using System.Xml;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using Syncfusion.Drawing;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Syncfusion.Windows.Forms.Schedule;

using System.Diagnostics;

namespace OutlookDemo
{
    #region Form
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Office2007Form
    {
        #region Members
        private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView listView1;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem4;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem5;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem6;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem7;
        private System.Windows.Forms.Panel mailPanel;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.Panel contactsPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Panel tasksPanel;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.Panel notesPanel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
        private System.Windows.Forms.Panel journalPanel;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.ComponentModel.IContainer components;
        //private AxSHDocVw.AxWebBrowser Display;

        // Outlook Groups Add/Remove Implementation		
        private System.Collections.Hashtable htLabelToImageIndex = new Hashtable();
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Label clientPanelImage;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label clientPanelLabel2;
        private System.Windows.Forms.Label clientPanelLabel1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem12;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem13;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem17;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem18;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem11;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem19;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem12;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem20;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem13;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem21;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem14;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem22;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem31;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem32;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem15;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem33;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem34;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem35;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem36;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem37;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem38;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem39;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem40;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem42;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem43;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem44;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem46;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem45;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem29;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem41;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem47;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem48;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem49;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem50;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem51;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem52;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem53;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem54;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem55;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem56;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem57;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem58;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem59;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem60;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem mailBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem calendarBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem contactsBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem tasksBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem notesBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem folderlistBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem journalBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem23;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem24;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem25;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem26;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem27;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem28;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem30;
        private System.Windows.Forms.Panel gridContainerPanel;
        private System.Collections.ArrayList restoreList = new ArrayList();
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel16;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem toolbarListBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem61;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem listBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem textBoxBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem staticBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem62;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem_AutoPreview;
        private System.Windows.Forms.RichTextBox Display;
        private System.Windows.Forms.Panel scheduleContainerPanel;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem63;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem64;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem65;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem66;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem67;
        private System.Windows.Forms.Panel contactsGridPanel;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem68;
        private ContactsPaneForm contactForm = null;
        private CalendarForm calForm = null;
        private XPTaskBar mailTaskBar;
        private XPTaskBarBox favouritesTaskBarBox;
        private XPTaskBarBox mailTaskBarBox;
        private GradientPanel gradientPanel2;
        private GradientPanel gradientPanel3;
        private XPTaskBar xpTaskBar1;
        private XPTaskBarBox myCalendarsTaskBarBox1;
        private GradientPanel gradientPanel4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel11;
        private LinkLabel linkLabel12;
        private LinkLabel linkLabel10;
        private LinkLabel linkLabel13;
        private LinkLabel linkLabel14;
        private LinkLabel linkLabel15;
        private LinkLabel linkLabel16;
        private LinkLabel linkLabel17;
        private GradientPanel gradientPanel5;
        private XPTaskBar xpTaskBar2;
        private XPTaskBarBox myContactsTaskBarBox;
        private XPTaskBarBox currentViewTaskBarBox;
        private Panel panel2;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton25;
        private RadioButton radioButton24;
        private RadioButton radioButton23;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel18;
        private LinkLabel linkLabel19;
        private LinkLabel linkLabel3;
        private GradientPanel gradientPanel6;
        private XPTaskBar xpTaskBar3;
        private XPTaskBarBox mytasksTaskBarBox;
        private XPTaskBarBox currentViewTaskBarBox1;
        private RadioButton radioButton31;
        private RadioButton radioButton30;
        private RadioButton radioButton28;
        private RadioButton radioButton27;
        private LinkLabel linkLabel20;
        private LinkLabel linkLabel21;
        private Panel panel4;
        private GradientPanel gradientPanel7;
        private XPTaskBar xpTaskBar4;
        private XPTaskBarBox notesTaskBarBox;
        private XPTaskBarBox currentViewTaskBarBox2;
        private LinkLabel linkLabel22;
        private Panel panel5;
        private LinkLabel linkLabel23;
        private XPTaskBar xpTaskBar5;
        private XPTaskBarBox allFoldersTaskBarBox;
        private GradientPanel gradientPanel9;
        private Panel panel1;
        private Panel panel6;
        private GradientPanel gradientPanel10;
        private XPTaskBar xpTaskBar6;
        private XPTaskBarBox myJournalTaskBarBox;
        private XPTaskBarBox currentViewTaskBarBox3;
        private RadioButton radioButton29;
        private RadioButton radioButton26;
        private LinkLabel linkLabel25;
        private LinkLabel linkLabel24;
        private SplitContainer splitContainer1;
        private Panel folderlistPanel;
        private GradientPanel gradientPanel8;
        private Panel panel8;
        private BarItem blueStyleBarItem;
        private BarItem blackStyleBarItem;
        private BarItem silverStyleBarItem;
        private ParentBarItem parentBarItem17;
        private StatusStripEx statusStripEx1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private SplashPanel splashPanel1;
        private SplashControl splashControl1;
        private ScrollersFrame scrollersFrame1;
        private ScrollersFrame scrollersFrame2;
        private SplitContainerAdv splitContainerAdv1;
        int distance = 300;
        private OutlookDemo.GroupingPanel gridGroupingPanel;

        #endregion

        #region Properties
        public GroupBar GroupBarControl
        {
            get { return this.groupBar1; }
        }

        public IEnumerator ItemStateStore
        {
            get { return this.restoreList.GetEnumerator(); }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
            this.splashControl1.ShowDialogSplash(this);

            #region Settings

            Color[] clrDefault = new Color[]{
										Color.FromArgb(192,219,255), Color.FromArgb(188,217,255), Color.FromArgb(184,215,255),
										Color.FromArgb(181,213,255), Color.FromArgb(177,211,255), Color.FromArgb(173,209,255),
										Color.FromArgb(198,222,255), Color.FromArgb(204,225,255), Color.FromArgb(210,229,255),
										Color.FromArgb(215,232,255), Color.FromArgb(221,236,255), Color.FromArgb(227,239,255)
									};
            this.Display.Hide();
            scheduleContainerPanel.Hide();
            contactsGridPanel.Hide();
            this.barItem64.Enabled = false;
            this.barItem65.Enabled = false;
            this.barItem66.Enabled = false;
            this.barItem67.Enabled = false;

            // Set the 1 and 3 monthAdv instances in the Calendar panel to the previous and next month

            this.treeView1.ExpandAll();
            this.treeView3.ExpandAll();

            // Initialize the htLabelToImageIndex map - the index refers to the icon position in the smallImageList
            this.htLabelToImageIndex.Add("Mail", 2);
            this.htLabelToImageIndex.Add("Calendar", 12);
            this.htLabelToImageIndex.Add("Contacts", 9);
            this.htLabelToImageIndex.Add("Tasks", 10);
            this.htLabelToImageIndex.Add("Notes", 11);
            this.htLabelToImageIndex.Add("Folder List", 3);
            this.htLabelToImageIndex.Add("Journal", 13);

            // The restoreList is used by the OptionsForm Restore functionality to restore the GroupBarItems to the state set in the designer.
            foreach (GroupBarItem item in this.groupBar1.GroupBarItems)
                this.restoreList.Add(new GroupBarItemState(item.Text, item.InNavigationPane, item.Visible));

            this.InitializeGroupBarClientColors();

            // Set the text for the ClientPanel labels
            GroupBarItem selitem = this.groupBar1.GroupBarItems[this.groupBar1.SelectedItem];
            this.clientPanelLabel1.Text = "Inbox";
            this.clientPanelLabel2.Text = String.Empty;
            this.clientPanelImage.ImageIndex = (int)this.htLabelToImageIndex[selitem.Text];

            // Create the GroupingPanel instance that contains the grouped Essential Grid and add it to the form's placeholder Panel
            this.gridGroupingPanel = new GroupingPanel();
            this.gridContainerPanel.Controls.Add(this.gridGroupingPanel);
            this.gridGroupingPanel.Dock = DockStyle.Fill;

            this.contactForm = new ContactsPaneForm();
            this.contactsGridPanel.Controls.Add(contactForm);
            this.contactForm.Dock = DockStyle.Fill;
            this.contactForm.BringToFront();

            this.calForm = new CalendarForm();
            this.scheduleContainerPanel.Controls.Add(calForm);
            this.calForm.Dock = DockStyle.Fill;

            this.Closing += new CancelEventHandler(Form1_Closing);
            this.gridGroupingPanel.Grid.TableControl.Model.SelectionChanging += new GridSelectionChangingEventHandler(Model_SelectionChanging);
            this.barItem47.PerformClick();
            this.groupBar1.GroupBarItemSelectionChanging += new GroupBarItemSelectionChangingEventHandler(groupBar1_GroupBarItemSelectionChanging);
            this.toolStripStatusLabel1.Text = this.gridGroupingPanel.Grid.Table.Records.Count.ToString() + " Messages";

            this.gridGroupingPanel.Grid.Table.RecordDeleted += new RecordEventHandler(Table_RecordDeleted);
            this.mailTaskBar.SizeChanged += new EventHandler(mailTaskBar_SizeChanged);
            SetGradientColors();
            this.groupBar1.HeaderForeColor = Color.MidnightBlue;

            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.BringToFront();
            #endregion

            this.gridContainerPanel.Height = 325;
            this.gridContainerPanel.Dock = DockStyle.Top;
            this.splitter2.Dock = DockStyle.Top;
            this.panel16.Dock = DockStyle.Fill;
            this.panel16.Show();
            SetBackGroundTheme();

        }

        #region Helper Methods

        private void SetGradientColors()
        {
			Office2003Colors.GroupBarHeaderColorDark = Color.FromArgb(175, 210, 255);
			Office2003Colors.GroupBarHeaderColorLight = Color.FromArgb(227, 239, 255);
			Office2003Colors.GroupBarItemTextColor = Color.MidnightBlue;
			Office2003Colors.GroupBarHighlightColorDark = Color.FromArgb(255, 215, 103);
			Office2003Colors.GroupBarHighlightColorLight = Color.FromArgb(255, 254, 228);
			Office2003Colors.GroupBarSelectedColorDark = Color.FromArgb(251, 140, 60);
			Office2003Colors.GroupBarSelectedColorLight = Color.FromArgb(255, 211, 101);
			Office2003Colors.SeparatorColor = Color.FromArgb(101, 147, 207);
        }

        // Sets the Office2003 colors for the GroupBar's client controls
        private void InitializeGroupBarClientColors()
        {
            Office2003Colors.UpdateMenuColors();
            //this.gradientPanel1.BackgroundColor = new BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.GroupBarHeaderColorDark, Office2003Colors.GroupBarHeaderColorLight); 
        }

        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Junk Email", 0, 0);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Inbox", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Personal Folders", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Archive Folders", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Drafts", 5, 5);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Inbox", 2, 2);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Outbox", 3, 3);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Public");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Junk Mail", 3, 3);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1, new System.Windows.Forms.TreeNode[] {
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Junk Email", 0, 0);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("InBox", 2, 2);
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Calendar");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Contacts", 9, 9);
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Drafts", 5, 5);
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Journal", 13, 13);
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Personal Folders", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Archive Folders", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Drafts", 5, 5);
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("InBox", 2, 2);
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("OutBox", 3, 3);
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Public");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("For Follow Up", 4, 4);
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Large Mail", 4, 4);
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4, new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem0"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem2"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "ListViewItem4"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.mailPanel = new System.Windows.Forms.Panel();
            this.mailTaskBar = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.favouritesTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.mailTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.journalPanel = new System.Windows.Forms.Panel();
            this.gradientPanel10 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.linkLabel25 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar6 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.myJournalTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.currentViewTaskBarBox3 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.linkLabel24 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.folderlistPanel = new System.Windows.Forms.Panel();
            this.gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar5 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.allFoldersTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel9 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.notesPanel = new System.Windows.Forms.Panel();
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.linkLabel22 = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.linkLabel23 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar4 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.notesTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.currentViewTaskBarBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.tasksPanel = new System.Windows.Forms.Panel();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.linkLabel20 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar3 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.mytasksTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.currentViewTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radioButton31 = new System.Windows.Forms.RadioButton();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton28 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.linkLabel21 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.contactsPanel = new System.Windows.Forms.Panel();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar2 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.myContactsTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.currentViewTaskBarBox = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.linkLabel18 = new System.Windows.Forms.LinkLabel();
            this.linkLabel19 = new System.Windows.Forms.LinkLabel();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.linkLabel12 = new System.Windows.Forms.LinkLabel();
            this.linkLabel13 = new System.Windows.Forms.LinkLabel();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.myCalendarsTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel14 = new System.Windows.Forms.LinkLabel();
            this.linkLabel17 = new System.Windows.Forms.LinkLabel();
            this.linkLabel15 = new System.Windows.Forms.LinkLabel();
            this.linkLabel16 = new System.Windows.Forms.LinkLabel();
            this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem7 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem4 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem5 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem6 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem29 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem37 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem38 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem39 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem40 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem42 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem43 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem44 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem46 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem45 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem52 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem53 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem18 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem41 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem19 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem12 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem47 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem48 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem63 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem20 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem13 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem49 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem50 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem68 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem21 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem14 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem51 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem22 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.mailBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.calendarBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.contactsBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tasksBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.notesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.folderlistBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.journalBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem31 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem32 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem54 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem55 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem56 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem15 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem57 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem58 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem59 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem16 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem60 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem33 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem34 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem35 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem23 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem36 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem17 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.blueStyleBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.blackStyleBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.silverStyleBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Standard");
            this.barItem24 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem25 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem30 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar3 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Advanced");
            this.barItem62 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem_AutoPreview = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem26 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem27 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem28 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem64 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem65 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem66 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem67 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.clientPanel = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Display = new System.Windows.Forms.RichTextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.gridContainerPanel = new System.Windows.Forms.Panel();
            this.scheduleContainerPanel = new System.Windows.Forms.Panel();
            this.contactsGridPanel = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.clientPanelImage = new System.Windows.Forms.Label();
            this.clientPanelLabel1 = new System.Windows.Forms.Label();
            this.clientPanelLabel2 = new System.Windows.Forms.Label();
            this.toolbarListBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem();
            this.barItem61 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.listBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem();
            this.textBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.TextBoxBarItem();
            this.staticBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splashControl1 = new Syncfusion.Windows.Forms.Tools.SplashControl();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.scrollersFrame2 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.groupBar1.SuspendLayout();
            this.mailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBar)).BeginInit();
            this.mailTaskBar.SuspendLayout();
            this.mailTaskBarBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.journalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel10)).BeginInit();
            this.gradientPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar6)).BeginInit();
            this.xpTaskBar6.SuspendLayout();
            this.currentViewTaskBarBox3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.folderlistPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).BeginInit();
            this.gradientPanel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar5)).BeginInit();
            this.xpTaskBar5.SuspendLayout();
            this.allFoldersTaskBarBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel9)).BeginInit();
            this.gradientPanel9.SuspendLayout();
            this.notesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar4)).BeginInit();
            this.xpTaskBar4.SuspendLayout();
            this.currentViewTaskBarBox2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar3)).BeginInit();
            this.xpTaskBar3.SuspendLayout();
            this.currentViewTaskBarBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.contactsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar2)).BeginInit();
            this.xpTaskBar2.SuspendLayout();
            this.currentViewTaskBarBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            this.myCalendarsTaskBarBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.clientPanel.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStripEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBar1
            // 
            this.groupBar1.AllowCollapse = true;
            this.groupBar1.AllowDrop = true;
            this.groupBar1.AnimatedSelection = false;
            this.groupBar1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBar1.Controls.Add(this.mailPanel);
            this.groupBar1.Controls.Add(this.journalPanel);
            this.groupBar1.Controls.Add(this.folderlistPanel);
            this.groupBar1.Controls.Add(this.notesPanel);
            this.groupBar1.Controls.Add(this.tasksPanel);
            this.groupBar1.Controls.Add(this.contactsPanel);
            this.groupBar1.Controls.Add(this.calendarPanel);
            this.groupBar1.Controls.Add(this.splashPanel1);
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold);
            this.groupBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.groupBar1.GroupBarItemCursor = System.Windows.Forms.Cursors.Hand;
            this.groupBar1.GroupBarItemHeight = 32;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem7,
            this.groupBarItem3,
            this.groupBarItem4,
            this.groupBarItem5,
            this.groupBarItem6,
            this.groupBarItem2});
            this.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.groupBar1.Location = new System.Drawing.Point(0, 0);
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.PopupClientSize = new System.Drawing.Size(0, 0);
            this.groupBar1.SelectedItem = 0;
            this.groupBar1.Size = new System.Drawing.Size(187, 697);
            this.groupBar1.StackedMode = true;
            this.groupBar1.TabIndex = 0;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.groupBar1.GroupBarItemSelected += new System.EventHandler(this.groupBar1_GroupBarItemSelected);
            this.groupBar1.NavigationPaneDropDownClick += new Syncfusion.Windows.Forms.Tools.NavigationPaneDropDownClickEventHandler(this.groupBar1_NavigationPaneDropDownClick);
            this.groupBar1.StateChanged += new System.EventHandler(this.groupBar1_StateChanged);
            // 
            // mailPanel
            // 
            this.mailPanel.Controls.Add(this.mailTaskBar);
            this.mailPanel.Location = new System.Drawing.Point(1, 27);
            this.mailPanel.Name = "mailPanel";
            this.mailPanel.Size = new System.Drawing.Size(185, 407);
            this.mailPanel.TabIndex = 1;
            // 
            // mailTaskBar
            // 
            this.mailTaskBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailTaskBar.Controls.Add(this.favouritesTaskBarBox);
            this.mailTaskBar.Controls.Add(this.mailTaskBarBox);
            this.mailTaskBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailTaskBar.Location = new System.Drawing.Point(0, 0);
            this.mailTaskBar.MinimumSize = new System.Drawing.Size(0, 0);
            this.mailTaskBar.Name = "mailTaskBar";
            this.mailTaskBar.Size = new System.Drawing.Size(185, 407);
            this.mailTaskBar.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007;
            this.mailTaskBar.TabIndex = 4;
            this.mailTaskBar.VerticalPadding = 10;
            // 
            // favouritesTaskBarBox
            // 
            this.favouritesTaskBarBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.favouritesTaskBarBox.DrawFocusRect = false;
            this.favouritesTaskBarBox.FocusOnClick = false;
            this.favouritesTaskBarBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.favouritesTaskBarBox.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favouritesTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.favouritesTaskBarBox.HeaderImageIndex = -1;
            this.favouritesTaskBarBox.HitTaskBoxArea = false;
            this.favouritesTaskBarBox.ImageList = this.smallImageList;
            this.favouritesTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Inbox", System.Drawing.Color.Empty, 2, null, "", true, true, "XPTaskBarItem0", new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Unread Mail", System.Drawing.Color.Empty, 4, null, "", true, true, "XPTaskBarItem1", new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sent Items", System.Drawing.Color.Empty, 6, null, "", true, true, "XPTaskBarItem2", new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.favouritesTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.favouritesTaskBarBox.Name = "favouritesTaskBarBox";
            this.favouritesTaskBarBox.Size = new System.Drawing.Size(183, 80);
            this.favouritesTaskBarBox.TabIndex = 0;
            this.favouritesTaskBarBox.Text = "Favourite Folders";
            this.favouritesTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "");
            this.smallImageList.Images.SetKeyName(1, "");
            this.smallImageList.Images.SetKeyName(2, "");
            this.smallImageList.Images.SetKeyName(3, "");
            this.smallImageList.Images.SetKeyName(4, "");
            this.smallImageList.Images.SetKeyName(5, "");
            this.smallImageList.Images.SetKeyName(6, "");
            this.smallImageList.Images.SetKeyName(7, "");
            this.smallImageList.Images.SetKeyName(8, "");
            this.smallImageList.Images.SetKeyName(9, "");
            this.smallImageList.Images.SetKeyName(10, "");
            this.smallImageList.Images.SetKeyName(11, "");
            this.smallImageList.Images.SetKeyName(12, "");
            this.smallImageList.Images.SetKeyName(13, "");
            this.smallImageList.Images.SetKeyName(14, "");
            this.smallImageList.Images.SetKeyName(15, "");
            this.smallImageList.Images.SetKeyName(16, "");
            this.smallImageList.Images.SetKeyName(17, "");
            this.smallImageList.Images.SetKeyName(18, "");
            this.smallImageList.Images.SetKeyName(19, "");
            this.smallImageList.Images.SetKeyName(20, "");
            this.smallImageList.Images.SetKeyName(21, "");
            this.smallImageList.Images.SetKeyName(22, "");
            this.smallImageList.Images.SetKeyName(23, "");
            this.smallImageList.Images.SetKeyName(24, "");
            this.smallImageList.Images.SetKeyName(25, "");
            this.smallImageList.Images.SetKeyName(26, "");
            this.smallImageList.Images.SetKeyName(27, "");
            this.smallImageList.Images.SetKeyName(28, "");
            this.smallImageList.Images.SetKeyName(29, "");
            this.smallImageList.Images.SetKeyName(30, "");
            this.smallImageList.Images.SetKeyName(31, "");
            this.smallImageList.Images.SetKeyName(32, "");
            this.smallImageList.Images.SetKeyName(33, "");
            this.smallImageList.Images.SetKeyName(34, "");
            this.smallImageList.Images.SetKeyName(35, "");
            this.smallImageList.Images.SetKeyName(36, "");
            this.smallImageList.Images.SetKeyName(37, "");
            this.smallImageList.Images.SetKeyName(38, "");
            this.smallImageList.Images.SetKeyName(39, "");
            this.smallImageList.Images.SetKeyName(40, "");
            this.smallImageList.Images.SetKeyName(41, "");
            this.smallImageList.Images.SetKeyName(42, "");
            this.smallImageList.Images.SetKeyName(43, "");
            this.smallImageList.Images.SetKeyName(44, "");
            this.smallImageList.Images.SetKeyName(45, "");
            this.smallImageList.Images.SetKeyName(46, "");
            this.smallImageList.Images.SetKeyName(47, "");
            this.smallImageList.Images.SetKeyName(48, "");
            this.smallImageList.Images.SetKeyName(49, "today.png");
            // 
            // mailTaskBarBox
            // 
            this.mailTaskBarBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.mailTaskBarBox.Controls.Add(this.gradientPanel2);
            this.mailTaskBarBox.DrawFocusRect = false;
            this.mailTaskBarBox.FocusOnClick = false;
            this.mailTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.mailTaskBarBox.HeaderImageIndex = -1;
            this.mailTaskBarBox.HitTaskBoxArea = false;
            this.mailTaskBarBox.Location = new System.Drawing.Point(0, 90);
            this.mailTaskBarBox.Name = "mailTaskBarBox";
            this.mailTaskBarBox.PreferredChildPanelHeight = 272;
            this.mailTaskBarBox.Size = new System.Drawing.Size(183, 297);
            this.mailTaskBarBox.TabIndex = 1;
            this.mailTaskBarBox.Text = "Mail Folders";
            this.mailTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel2.Controls.Add(this.treeView3);
            this.gradientPanel2.Location = new System.Drawing.Point(2, 23);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(179, 272);
            this.gradientPanel2.TabIndex = 4;
            // 
            // treeView3
            // 
            this.treeView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView3.ImageIndex = 0;
            this.treeView3.ImageList = this.smallImageList;
            this.treeView3.Indent = 25;
            this.treeView3.Location = new System.Drawing.Point(0, 0);
            this.treeView3.Name = "treeView3";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Deleted Items";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Text = "Junk Email";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Inbox";
            treeNode4.ImageIndex = 6;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 6;
            treeNode4.Text = "Sent Items";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "Search Folders";
            treeNode6.ImageIndex = 7;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 7;
            treeNode6.Text = "Personal Folders";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "";
            treeNode7.SelectedImageIndex = 4;
            treeNode7.Text = "Search Folders";
            treeNode8.ImageIndex = 6;
            treeNode8.Name = "";
            treeNode8.SelectedImageIndex = 6;
            treeNode8.Text = "Sent Items";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "Deleted Items";
            treeNode10.ImageIndex = 8;
            treeNode10.Name = "";
            treeNode10.SelectedImageIndex = 8;
            treeNode10.Text = "Archive Folders";
            treeNode11.ImageIndex = 5;
            treeNode11.Name = "";
            treeNode11.SelectedImageIndex = 5;
            treeNode11.Text = "Drafts";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "";
            treeNode12.SelectedImageIndex = 2;
            treeNode12.Text = "Inbox";
            treeNode13.ImageIndex = 3;
            treeNode13.Name = "";
            treeNode13.SelectedImageIndex = 3;
            treeNode13.Text = "Outbox";
            treeNode14.ImageIndex = 6;
            treeNode14.Name = "";
            treeNode14.SelectedImageIndex = 6;
            treeNode14.Text = "Sent Items";
            treeNode15.Name = "";
            treeNode15.Text = "Public";
            treeNode16.ImageIndex = 8;
            treeNode16.Name = "";
            treeNode16.SelectedImageIndex = 8;
            treeNode16.Text = "Syncfusion Email";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10,
            treeNode16});
            this.treeView3.SelectedImageIndex = 0;
            this.treeView3.ShowLines = false;
            this.treeView3.Size = new System.Drawing.Size(179, 272);
            this.treeView3.TabIndex = 3;
            // 
            // journalPanel
            // 
            this.journalPanel.BackColor = System.Drawing.SystemColors.Window;
            this.journalPanel.Controls.Add(this.gradientPanel10);
            this.journalPanel.Location = new System.Drawing.Point(1, 225);
            this.journalPanel.Name = "journalPanel";
            this.journalPanel.Size = new System.Drawing.Size(218, 74);
            this.journalPanel.TabIndex = 4;
            // 
            // gradientPanel10
            // 
            this.gradientPanel10.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel10.Controls.Add(this.panel8);
            this.gradientPanel10.Controls.Add(this.linkLabel25);
            this.gradientPanel10.Controls.Add(this.xpTaskBar6);
            this.gradientPanel10.Controls.Add(this.linkLabel24);
            this.gradientPanel10.Controls.Add(this.linkLabel11);
            this.gradientPanel10.Controls.Add(this.linkLabel9);
            this.gradientPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel10.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel10.Name = "gradientPanel10";
            this.gradientPanel10.Size = new System.Drawing.Size(218, 74);
            this.gradientPanel10.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 263);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(218, 5);
            this.panel8.TabIndex = 4;
            // 
            // linkLabel25
            // 
            this.linkLabel25.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel25.AutoSize = true;
            this.linkLabel25.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel25.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel25.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel25.Location = new System.Drawing.Point(6, 309);
            this.linkLabel25.Name = "linkLabel25";
            this.linkLabel25.Size = new System.Drawing.Size(84, 14);
            this.linkLabel25.TabIndex = 3;
            this.linkLabel25.TabStop = true;
            this.linkLabel25.Text = "Add New Group";
            this.linkLabel25.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar6
            // 
            this.xpTaskBar6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar6.Controls.Add(this.myJournalTaskBarBox);
            this.xpTaskBar6.Controls.Add(this.currentViewTaskBarBox3);
            this.xpTaskBar6.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar6.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar6.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar6.Name = "xpTaskBar6";
            this.xpTaskBar6.Size = new System.Drawing.Size(218, 263);
            this.xpTaskBar6.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007;
            this.xpTaskBar6.TabIndex = 0;
            this.xpTaskBar6.VerticalPadding = 10;
            // 
            // myJournalTaskBarBox
            // 
            this.myJournalTaskBarBox.DrawFocusRect = false;
            this.myJournalTaskBarBox.FocusOnClick = false;
            this.myJournalTaskBarBox.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myJournalTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.myJournalTaskBarBox.HeaderImageIndex = -1;
            this.myJournalTaskBarBox.HitTaskBoxArea = false;
            this.myJournalTaskBarBox.ImageList = this.smallImageList;
            this.myJournalTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Journal", System.Drawing.Color.Empty, 13, null, "", true, true, "XPTaskBarItem9", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Journal in Archive Folders", System.Drawing.Color.Empty, 13, null, "", true, true, "XPTaskBarItem10", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.myJournalTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.myJournalTaskBarBox.Name = "myJournalTaskBarBox";
            this.myJournalTaskBarBox.Size = new System.Drawing.Size(216, 61);
            this.myJournalTaskBarBox.TabIndex = 0;
            this.myJournalTaskBarBox.Text = "My Journal";
            this.myJournalTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // currentViewTaskBarBox3
            // 
            this.currentViewTaskBarBox3.Controls.Add(this.panel14);
            this.currentViewTaskBarBox3.DrawFocusRect = false;
            this.currentViewTaskBarBox3.FocusOnClick = false;
            this.currentViewTaskBarBox3.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.currentViewTaskBarBox3.HeaderImageIndex = -1;
            this.currentViewTaskBarBox3.HitTaskBoxArea = false;
            this.currentViewTaskBarBox3.Location = new System.Drawing.Point(0, 71);
            this.currentViewTaskBarBox3.Name = "currentViewTaskBarBox3";
            this.currentViewTaskBarBox3.PreferredChildPanelHeight = 150;
            this.currentViewTaskBarBox3.Size = new System.Drawing.Size(216, 175);
            this.currentViewTaskBarBox3.TabIndex = 1;
            this.currentViewTaskBarBox3.Text = "Current View";
            this.currentViewTaskBarBox3.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.White;
            this.panel14.Controls.Add(this.radioButton29);
            this.panel14.Controls.Add(this.radioButton18);
            this.panel14.Controls.Add(this.radioButton26);
            this.panel14.Controls.Add(this.radioButton19);
            this.panel14.Controls.Add(this.radioButton20);
            this.panel14.Controls.Add(this.radioButton21);
            this.panel14.Controls.Add(this.radioButton22);
            this.panel14.Location = new System.Drawing.Point(2, 23);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(212, 150);
            this.panel14.TabIndex = 6;
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton29.Location = new System.Drawing.Point(6, 128);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(133, 20);
            this.radioButton29.TabIndex = 3;
            this.radioButton29.TabStop = true;
            this.radioButton29.Text = "Outlook Data Files";
            this.radioButton29.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton18.Location = new System.Drawing.Point(6, 108);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(96, 20);
            this.radioButton18.TabIndex = 4;
            this.radioButton18.Text = "Phone Calls";
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton26.Location = new System.Drawing.Point(6, 90);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(117, 20);
            this.radioButton26.TabIndex = 2;
            this.radioButton26.TabStop = true;
            this.radioButton26.Text = "Last Seven Days";
            this.radioButton26.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton19.Location = new System.Drawing.Point(6, 68);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(81, 20);
            this.radioButton19.TabIndex = 3;
            this.radioButton19.Text = "Entry List";
            this.radioButton19.UseVisualStyleBackColor = false;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton20.Location = new System.Drawing.Point(6, 46);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(95, 20);
            this.radioButton20.TabIndex = 2;
            this.radioButton20.Text = "By Category";
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton21.Location = new System.Drawing.Point(6, 24);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(89, 20);
            this.radioButton21.TabIndex = 1;
            this.radioButton21.Text = "By Contact";
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton22.Location = new System.Drawing.Point(6, 2);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(71, 20);
            this.radioButton22.TabIndex = 0;
            this.radioButton22.Text = "By Type";
            // 
            // linkLabel24
            // 
            this.linkLabel24.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel24.AutoSize = true;
            this.linkLabel24.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel24.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel24.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel24.Location = new System.Drawing.Point(6, 293);
            this.linkLabel24.Name = "linkLabel24";
            this.linkLabel24.Size = new System.Drawing.Size(125, 14);
            this.linkLabel24.TabIndex = 2;
            this.linkLabel24.TabStop = true;
            this.linkLabel24.Text = "Share My Journal Folder";
            this.linkLabel24.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel11
            // 
            this.linkLabel11.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel11.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel11.Location = new System.Drawing.Point(6, 276);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(126, 14);
            this.linkLabel11.TabIndex = 0;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "Open a Shared Journal...";
            this.linkLabel11.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel9
            // 
            this.linkLabel9.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel9.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel9.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel9.Location = new System.Drawing.Point(6, 327);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(133, 14);
            this.linkLabel9.TabIndex = 1;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Customize Current View...";
            this.linkLabel9.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // folderlistPanel
            // 
            this.folderlistPanel.Controls.Add(this.gradientPanel8);
            this.folderlistPanel.Location = new System.Drawing.Point(1, 27);
            this.folderlistPanel.Name = "folderlistPanel";
            this.folderlistPanel.Size = new System.Drawing.Size(201, 407);
            this.folderlistPanel.TabIndex = 1;
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel8.Controls.Add(this.panel6);
            this.gradientPanel8.Controls.Add(this.xpTaskBar5);
            this.gradientPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel8.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(201, 407);
            this.gradientPanel8.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.linkLabel7);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.linkLabel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 345);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(201, 62);
            this.panel6.TabIndex = 2;
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel7.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel7.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel7.Location = new System.Drawing.Point(11, 31);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(176, 16);
            this.linkLabel7.TabIndex = 1;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Data File Management...";
            this.linkLabel7.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 6);
            this.panel1.TabIndex = 1;
            // 
            // linkLabel8
            // 
            this.linkLabel8.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel8.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel8.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel8.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel8.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel8.Location = new System.Drawing.Point(11, 10);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(176, 16);
            this.linkLabel8.TabIndex = 0;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Folder Sizes";
            this.linkLabel8.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar5
            // 
            this.xpTaskBar5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar5.Controls.Add(this.allFoldersTaskBarBox);
            this.xpTaskBar5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpTaskBar5.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar5.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar5.Name = "xpTaskBar5";
            this.xpTaskBar5.Size = new System.Drawing.Size(201, 407);
            this.xpTaskBar5.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007;
            this.xpTaskBar5.TabIndex = 0;
            this.xpTaskBar5.VerticalPadding = 10;
            // 
            // allFoldersTaskBarBox
            // 
            this.allFoldersTaskBarBox.Controls.Add(this.gradientPanel9);
            this.allFoldersTaskBarBox.DrawFocusRect = false;
            this.allFoldersTaskBarBox.FocusOnClick = false;
            this.allFoldersTaskBarBox.HeaderFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allFoldersTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.allFoldersTaskBarBox.HeaderImageIndex = -1;
            this.allFoldersTaskBarBox.HitTaskBoxArea = false;
            this.allFoldersTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.allFoldersTaskBarBox.Name = "allFoldersTaskBarBox";
            this.allFoldersTaskBarBox.PreferredChildPanelHeight = 360;
            this.allFoldersTaskBarBox.Size = new System.Drawing.Size(199, 386);
            this.allFoldersTaskBarBox.TabIndex = 0;
            this.allFoldersTaskBarBox.Text = "All Folders";
            this.allFoldersTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // gradientPanel9
            // 
            this.gradientPanel9.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel9.Controls.Add(this.treeView1);
            this.gradientPanel9.Location = new System.Drawing.Point(2, 24);
            this.gradientPanel9.Name = "gradientPanel9";
            this.gradientPanel9.Size = new System.Drawing.Size(195, 360);
            this.gradientPanel9.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.smallImageList;
            this.treeView1.Indent = 25;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode17.ImageIndex = 3;
            treeNode17.Name = "";
            treeNode17.SelectedImageIndex = 3;
            treeNode17.Text = "Junk Mail";
            treeNode18.ImageIndex = 1;
            treeNode18.Name = "";
            treeNode18.SelectedImageIndex = 1;
            treeNode18.Text = "Deleted Items";
            treeNode19.ImageIndex = 0;
            treeNode19.Name = "";
            treeNode19.SelectedImageIndex = 0;
            treeNode19.Text = "Junk Email";
            treeNode20.ImageIndex = 2;
            treeNode20.Name = "";
            treeNode20.SelectedImageIndex = 2;
            treeNode20.Text = "InBox";
            treeNode21.ImageIndex = 6;
            treeNode21.Name = "";
            treeNode21.SelectedImageIndex = 6;
            treeNode21.Text = "Sent Items";
            treeNode22.ImageIndex = 4;
            treeNode22.Name = "";
            treeNode22.SelectedImageIndex = 4;
            treeNode22.Text = "Search Folders";
            treeNode23.Name = "";
            treeNode23.Text = "Calendar";
            treeNode24.ImageIndex = 9;
            treeNode24.Name = "";
            treeNode24.SelectedImageIndex = 9;
            treeNode24.Text = "Contacts";
            treeNode25.ImageIndex = 5;
            treeNode25.Name = "";
            treeNode25.SelectedImageIndex = 5;
            treeNode25.Text = "Drafts";
            treeNode26.ImageIndex = 13;
            treeNode26.Name = "";
            treeNode26.SelectedImageIndex = 13;
            treeNode26.Text = "Journal";
            treeNode27.ImageIndex = 7;
            treeNode27.Name = "";
            treeNode27.SelectedImageIndex = 7;
            treeNode27.Text = "Personal Folders";
            treeNode28.ImageIndex = 4;
            treeNode28.Name = "";
            treeNode28.SelectedImageIndex = 4;
            treeNode28.Text = "Search Folders";
            treeNode29.ImageIndex = 6;
            treeNode29.Name = "";
            treeNode29.SelectedImageIndex = 6;
            treeNode29.Text = "Sent Items";
            treeNode30.ImageIndex = 1;
            treeNode30.Name = "";
            treeNode30.SelectedImageIndex = 1;
            treeNode30.Text = "Deleted Items";
            treeNode31.ImageIndex = 8;
            treeNode31.Name = "";
            treeNode31.SelectedImageIndex = 8;
            treeNode31.Text = "Archive Folders";
            treeNode32.ImageIndex = 5;
            treeNode32.Name = "";
            treeNode32.SelectedImageIndex = 5;
            treeNode32.Text = "Drafts";
            treeNode33.ImageIndex = 2;
            treeNode33.Name = "";
            treeNode33.SelectedImageIndex = 2;
            treeNode33.Text = "InBox";
            treeNode34.ImageIndex = 3;
            treeNode34.Name = "";
            treeNode34.SelectedImageIndex = 3;
            treeNode34.Text = "OutBox";
            treeNode35.ImageIndex = 6;
            treeNode35.Name = "";
            treeNode35.SelectedImageIndex = 6;
            treeNode35.Text = "Sent Items";
            treeNode36.Name = "";
            treeNode36.Text = "Public";
            treeNode37.ImageIndex = 8;
            treeNode37.Name = "";
            treeNode37.SelectedImageIndex = 8;
            treeNode37.Text = "Syncfusion Email";
            treeNode38.ImageIndex = 4;
            treeNode38.Name = "";
            treeNode38.SelectedImageIndex = 4;
            treeNode38.Text = "For Follow Up";
            treeNode39.ImageIndex = 4;
            treeNode39.Name = "";
            treeNode39.SelectedImageIndex = 4;
            treeNode39.Text = "Large Mail";
            treeNode40.ImageIndex = 4;
            treeNode40.Name = "";
            treeNode40.SelectedImageIndex = 4;
            treeNode40.Text = "Search Folders";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode31,
            treeNode37,
            treeNode40});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(195, 360);
            this.treeView1.TabIndex = 4;
            // 
            // notesPanel
            // 
            this.notesPanel.Controls.Add(this.gradientPanel7);
            this.notesPanel.Location = new System.Drawing.Point(1, 27);
            this.notesPanel.Name = "notesPanel";
            this.notesPanel.Size = new System.Drawing.Size(201, 407);
            this.notesPanel.TabIndex = 1;
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.BackColor = System.Drawing.Color.White;
            this.gradientPanel7.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel7.Controls.Add(this.linkLabel22);
            this.gradientPanel7.Controls.Add(this.panel5);
            this.gradientPanel7.Controls.Add(this.linkLabel23);
            this.gradientPanel7.Controls.Add(this.xpTaskBar4);
            this.gradientPanel7.Controls.Add(this.linkLabel5);
            this.gradientPanel7.Controls.Add(this.linkLabel6);
            this.gradientPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel7.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(201, 407);
            this.gradientPanel7.TabIndex = 0;
            // 
            // linkLabel22
            // 
            this.linkLabel22.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel22.AutoSize = true;
            this.linkLabel22.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel22.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel22.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel22.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel22.Location = new System.Drawing.Point(4, 249);
            this.linkLabel22.Name = "linkLabel22";
            this.linkLabel22.Size = new System.Drawing.Size(127, 14);
            this.linkLabel22.TabIndex = 0;
            this.linkLabel22.TabStop = true;
            this.linkLabel22.Text = "Share My Notes Folder...";
            this.linkLabel22.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 215);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(201, 5);
            this.panel5.TabIndex = 1;
            // 
            // linkLabel23
            // 
            this.linkLabel23.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel23.AutoSize = true;
            this.linkLabel23.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel23.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel23.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel23.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel23.Location = new System.Drawing.Point(4, 267);
            this.linkLabel23.Name = "linkLabel23";
            this.linkLabel23.Size = new System.Drawing.Size(84, 14);
            this.linkLabel23.TabIndex = 1;
            this.linkLabel23.TabStop = true;
            this.linkLabel23.Text = "Add New Group";
            this.linkLabel23.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar4
            // 
            this.xpTaskBar4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar4.Controls.Add(this.notesTaskBarBox);
            this.xpTaskBar4.Controls.Add(this.currentViewTaskBarBox2);
            this.xpTaskBar4.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar4.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar4.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar4.Name = "xpTaskBar4";
            this.xpTaskBar4.Size = new System.Drawing.Size(201, 215);
            this.xpTaskBar4.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007;
            this.xpTaskBar4.TabIndex = 0;
            this.xpTaskBar4.VerticalPadding = 10;
            // 
            // notesTaskBarBox
            // 
            this.notesTaskBarBox.DrawFocusRect = false;
            this.notesTaskBarBox.FocusOnClick = false;
            this.notesTaskBarBox.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.notesTaskBarBox.HeaderImageIndex = -1;
            this.notesTaskBarBox.HitTaskBoxArea = false;
            this.notesTaskBarBox.ImageList = this.smallImageList;
            this.notesTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Notes", System.Drawing.Color.Empty, 11, null, "", true, true, "XPTaskBarItem8", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.notesTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.notesTaskBarBox.Name = "notesTaskBarBox";
            this.notesTaskBarBox.Size = new System.Drawing.Size(199, 42);
            this.notesTaskBarBox.TabIndex = 0;
            this.notesTaskBarBox.Text = "My Notes";
            this.notesTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // currentViewTaskBarBox2
            // 
            this.currentViewTaskBarBox2.Controls.Add(this.panel9);
            this.currentViewTaskBarBox2.DrawFocusRect = false;
            this.currentViewTaskBarBox2.FocusOnClick = false;
            this.currentViewTaskBarBox2.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentViewTaskBarBox2.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.currentViewTaskBarBox2.HeaderImageIndex = -1;
            this.currentViewTaskBarBox2.HitTaskBoxArea = false;
            this.currentViewTaskBarBox2.Location = new System.Drawing.Point(0, 52);
            this.currentViewTaskBarBox2.Name = "currentViewTaskBarBox2";
            this.currentViewTaskBarBox2.PreferredChildPanelHeight = 125;
            this.currentViewTaskBarBox2.Size = new System.Drawing.Size(199, 150);
            this.currentViewTaskBarBox2.TabIndex = 1;
            this.currentViewTaskBarBox2.Text = "Current View";
            this.currentViewTaskBarBox2.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.radioButton13);
            this.panel9.Controls.Add(this.radioButton14);
            this.panel9.Controls.Add(this.radioButton15);
            this.panel9.Controls.Add(this.radioButton16);
            this.panel9.Controls.Add(this.radioButton17);
            this.panel9.Location = new System.Drawing.Point(2, 23);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(195, 125);
            this.panel9.TabIndex = 6;
            // 
            // radioButton13
            // 
            this.radioButton13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton13.Location = new System.Drawing.Point(8, 98);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(176, 24);
            this.radioButton13.TabIndex = 4;
            this.radioButton13.Text = "Outlook Data Files";
            // 
            // radioButton14
            // 
            this.radioButton14.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton14.Location = new System.Drawing.Point(8, 75);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(176, 24);
            this.radioButton14.TabIndex = 3;
            this.radioButton14.Text = "By Category";
            this.radioButton14.UseVisualStyleBackColor = false;
            // 
            // radioButton15
            // 
            this.radioButton15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton15.Location = new System.Drawing.Point(8, 52);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(176, 24);
            this.radioButton15.TabIndex = 2;
            this.radioButton15.Text = "Last Seven Days";
            // 
            // radioButton16
            // 
            this.radioButton16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton16.Location = new System.Drawing.Point(8, 29);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(176, 24);
            this.radioButton16.TabIndex = 1;
            this.radioButton16.Text = "Notes List";
            // 
            // radioButton17
            // 
            this.radioButton17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton17.Location = new System.Drawing.Point(8, 6);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(176, 24);
            this.radioButton17.TabIndex = 0;
            this.radioButton17.Text = "Icons";
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel5.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel5.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel5.Location = new System.Drawing.Point(4, 288);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(176, 16);
            this.linkLabel5.TabIndex = 1;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Customize Current View...";
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel6.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel6.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel6.Location = new System.Drawing.Point(4, 232);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(176, 16);
            this.linkLabel6.TabIndex = 0;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Open Shared Notes...";
            this.linkLabel6.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // tasksPanel
            // 
            this.tasksPanel.BackColor = System.Drawing.SystemColors.Window;
            this.tasksPanel.Controls.Add(this.gradientPanel6);
            this.tasksPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksPanel.Location = new System.Drawing.Point(1, 27);
            this.tasksPanel.Name = "tasksPanel";
            this.tasksPanel.Size = new System.Drawing.Size(201, 407);
            this.tasksPanel.TabIndex = 1;
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel6.Controls.Add(this.panel4);
            this.gradientPanel6.Controls.Add(this.linkLabel20);
            this.gradientPanel6.Controls.Add(this.xpTaskBar3);
            this.gradientPanel6.Controls.Add(this.linkLabel21);
            this.gradientPanel6.Controls.Add(this.linkLabel4);
            this.gradientPanel6.Controls.Add(this.linkLabel3);
            this.gradientPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel6.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(201, 407);
            this.gradientPanel6.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 359);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(201, 5);
            this.panel4.TabIndex = 1005;
            // 
            // linkLabel20
            // 
            this.linkLabel20.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel20.AutoSize = true;
            this.linkLabel20.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel20.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel20.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel20.Location = new System.Drawing.Point(7, 392);
            this.linkLabel20.Name = "linkLabel20";
            this.linkLabel20.Size = new System.Drawing.Size(125, 14);
            this.linkLabel20.TabIndex = 1003;
            this.linkLabel20.TabStop = true;
            this.linkLabel20.Text = "Share My Tasks Folder...";
            this.linkLabel20.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar3
            // 
            this.xpTaskBar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar3.Controls.Add(this.mytasksTaskBarBox);
            this.xpTaskBar3.Controls.Add(this.currentViewTaskBarBox1);
            this.xpTaskBar3.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar3.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar3.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar3.Name = "xpTaskBar3";
            this.xpTaskBar3.Size = new System.Drawing.Size(201, 359);
            this.xpTaskBar3.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007;
            this.xpTaskBar3.TabIndex = 0;
            this.xpTaskBar3.VerticalPadding = 10;
            // 
            // mytasksTaskBarBox
            // 
            this.mytasksTaskBarBox.DrawFocusRect = false;
            this.mytasksTaskBarBox.FocusOnClick = false;
            this.mytasksTaskBarBox.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mytasksTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.mytasksTaskBarBox.HeaderImageIndex = -1;
            this.mytasksTaskBarBox.HitTaskBoxArea = false;
            this.mytasksTaskBarBox.ImageList = this.smallImageList;
            this.mytasksTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("To-Do List", System.Drawing.Color.Empty, 49, null, "", true, true, "XPTaskBarItem5", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Tasks", System.Drawing.Color.Empty, 10, null, "", true, true, "XPTaskBarItem6", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Tasks in Archive Folders", System.Drawing.Color.Empty, 10, null, "", true, true, "XPTaskBarItem7", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.mytasksTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.mytasksTaskBarBox.Name = "mytasksTaskBarBox";
            this.mytasksTaskBarBox.Size = new System.Drawing.Size(199, 77);
            this.mytasksTaskBarBox.TabIndex = 0;
            this.mytasksTaskBarBox.Text = "My Tasks";
            this.mytasksTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // currentViewTaskBarBox1
            // 
            this.currentViewTaskBarBox1.Controls.Add(this.panel7);
            this.currentViewTaskBarBox1.DrawFocusRect = false;
            this.currentViewTaskBarBox1.FocusOnClick = false;
            this.currentViewTaskBarBox1.HeaderFont = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentViewTaskBarBox1.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.currentViewTaskBarBox1.HeaderImageIndex = -1;
            this.currentViewTaskBarBox1.HitTaskBoxArea = false;
            this.currentViewTaskBarBox1.Location = new System.Drawing.Point(0, 87);
            this.currentViewTaskBarBox1.Name = "currentViewTaskBarBox1";
            this.currentViewTaskBarBox1.PreferredChildPanelHeight = 232;
            this.currentViewTaskBarBox1.Size = new System.Drawing.Size(199, 257);
            this.currentViewTaskBarBox1.TabIndex = 1;
            this.currentViewTaskBarBox1.Text = "Current View";
            this.currentViewTaskBarBox1.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.radioButton31);
            this.panel7.Controls.Add(this.radioButton30);
            this.panel7.Controls.Add(this.radioButton28);
            this.panel7.Controls.Add(this.radioButton27);
            this.panel7.Controls.Add(this.radioButton12);
            this.panel7.Controls.Add(this.radioButton11);
            this.panel7.Controls.Add(this.radioButton6);
            this.panel7.Controls.Add(this.radioButton7);
            this.panel7.Controls.Add(this.radioButton8);
            this.panel7.Controls.Add(this.radioButton9);
            this.panel7.Controls.Add(this.radioButton10);
            this.panel7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.Location = new System.Drawing.Point(2, 23);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(195, 232);
            this.panel7.TabIndex = 6;
            // 
            // radioButton31
            // 
            this.radioButton31.AutoSize = true;
            this.radioButton31.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton31.Location = new System.Drawing.Point(7, 209);
            this.radioButton31.Name = "radioButton31";
            this.radioButton31.Size = new System.Drawing.Size(84, 20);
            this.radioButton31.TabIndex = 12;
            this.radioButton31.TabStop = true;
            this.radioButton31.Text = "To-Do List";
            this.radioButton31.UseVisualStyleBackColor = true;
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton30.Location = new System.Drawing.Point(7, 190);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(133, 20);
            this.radioButton30.TabIndex = 11;
            this.radioButton30.TabStop = true;
            this.radioButton30.Text = "Outlook Data Files";
            this.radioButton30.UseVisualStyleBackColor = true;
            // 
            // radioButton28
            // 
            this.radioButton28.AutoSize = true;
            this.radioButton28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton28.Location = new System.Drawing.Point(7, 170);
            this.radioButton28.Name = "radioButton28";
            this.radioButton28.Size = new System.Drawing.Size(111, 20);
            this.radioButton28.TabIndex = 9;
            this.radioButton28.TabStop = true;
            this.radioButton28.Text = "Tasks Timeline";
            this.radioButton28.UseVisualStyleBackColor = true;
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton27.Location = new System.Drawing.Point(7, 147);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(122, 20);
            this.radioButton27.TabIndex = 8;
            this.radioButton27.TabStop = true;
            this.radioButton27.Text = "Completed Tasks";
            this.radioButton27.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton12.Location = new System.Drawing.Point(7, 125);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(94, 20);
            this.radioButton12.TabIndex = 6;
            this.radioButton12.Text = "Assignment";
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton11.Location = new System.Drawing.Point(7, 104);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(95, 20);
            this.radioButton11.TabIndex = 5;
            this.radioButton11.Text = "By Category";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(7, 83);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(110, 20);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Text = "Overdue Tasks";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton7.Location = new System.Drawing.Point(7, 63);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(119, 20);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.Text = "Next Seven Days";
            this.radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton8.Location = new System.Drawing.Point(7, 43);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(96, 20);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "Active Tasks";
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton9.Location = new System.Drawing.Point(7, 23);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(99, 20);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.Text = "Detailed List";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton10.Location = new System.Drawing.Point(7, 4);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(90, 20);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.Text = "Simple List";
            // 
            // linkLabel21
            // 
            this.linkLabel21.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel21.AutoSize = true;
            this.linkLabel21.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel21.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel21.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel21.Location = new System.Drawing.Point(7, 409);
            this.linkLabel21.Name = "linkLabel21";
            this.linkLabel21.Size = new System.Drawing.Size(84, 14);
            this.linkLabel21.TabIndex = 1004;
            this.linkLabel21.TabStop = true;
            this.linkLabel21.Text = "Add New Group";
            this.linkLabel21.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel4.Location = new System.Drawing.Point(7, 374);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(109, 14);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Open Shared Tasks...";
            this.linkLabel4.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel3.Location = new System.Drawing.Point(7, 428);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(133, 14);
            this.linkLabel3.TabIndex = 1;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Customize Current View...";
            this.linkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // contactsPanel
            // 
            this.contactsPanel.Controls.Add(this.gradientPanel5);
            this.contactsPanel.Location = new System.Drawing.Point(1, 27);
            this.contactsPanel.Name = "contactsPanel";
            this.contactsPanel.Size = new System.Drawing.Size(201, 407);
            this.contactsPanel.TabIndex = 1;
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BackColor = System.Drawing.Color.White;
            this.gradientPanel5.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel5.Controls.Add(this.linkLabel1);
            this.gradientPanel5.Controls.Add(this.panel3);
            this.gradientPanel5.Controls.Add(this.linkLabel2);
            this.gradientPanel5.Controls.Add(this.xpTaskBar2);
            this.gradientPanel5.Controls.Add(this.linkLabel18);
            this.gradientPanel5.Controls.Add(this.linkLabel19);
            this.gradientPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel5.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(201, 407);
            this.gradientPanel5.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel1.Location = new System.Drawing.Point(9, 264);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 14);
            this.linkLabel1.TabIndex = 1003;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open Shared Contacts...";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 5);
            this.panel3.TabIndex = 1;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel2.Location = new System.Drawing.Point(9, 282);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(141, 14);
            this.linkLabel2.TabIndex = 1004;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Share My Contacts Folder...";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar2
            // 
            this.xpTaskBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar2.Controls.Add(this.myContactsTaskBarBox);
            this.xpTaskBar2.Controls.Add(this.currentViewTaskBarBox);
            this.xpTaskBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar2.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar2.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar2.Name = "xpTaskBar2";
            this.xpTaskBar2.Size = new System.Drawing.Size(201, 253);
            this.xpTaskBar2.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007;
            this.xpTaskBar2.TabIndex = 0;
            this.xpTaskBar2.VerticalPadding = 10;
            // 
            // myContactsTaskBarBox
            // 
            this.myContactsTaskBarBox.BackColor = System.Drawing.SystemColors.Control;
            this.myContactsTaskBarBox.DrawFocusRect = false;
            this.myContactsTaskBarBox.FocusOnClick = false;
            this.myContactsTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.myContactsTaskBarBox.HeaderImageIndex = -1;
            this.myContactsTaskBarBox.HitTaskBoxArea = false;
            this.myContactsTaskBarBox.ImageList = this.smallImageList;
            this.myContactsTaskBarBox.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Contacts", System.Drawing.Color.Empty, 38, null, "", true, true, "XPTaskBarItem4", new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.myContactsTaskBarBox.Location = new System.Drawing.Point(0, 0);
            this.myContactsTaskBarBox.Name = "myContactsTaskBarBox";
            this.myContactsTaskBarBox.Size = new System.Drawing.Size(199, 42);
            this.myContactsTaskBarBox.TabIndex = 0;
            this.myContactsTaskBarBox.Text = "My Contacts";
            this.myContactsTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // currentViewTaskBarBox
            // 
            this.currentViewTaskBarBox.Controls.Add(this.panel2);
            this.currentViewTaskBarBox.DrawFocusRect = false;
            this.currentViewTaskBarBox.FocusOnClick = false;
            this.currentViewTaskBarBox.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.currentViewTaskBarBox.HeaderImageIndex = -1;
            this.currentViewTaskBarBox.HitTaskBoxArea = false;
            this.currentViewTaskBarBox.Location = new System.Drawing.Point(0, 52);
            this.currentViewTaskBarBox.Name = "currentViewTaskBarBox";
            this.currentViewTaskBarBox.PreferredChildPanelHeight = 165;
            this.currentViewTaskBarBox.Size = new System.Drawing.Size(199, 190);
            this.currentViewTaskBarBox.TabIndex = 1;
            this.currentViewTaskBarBox.Text = "Current View";
            this.currentViewTaskBarBox.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.radioButton25);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton24);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton23);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(2, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 165);
            this.panel2.TabIndex = 2;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton25.Location = new System.Drawing.Point(10, 143);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(133, 20);
            this.radioButton25.TabIndex = 2;
            this.radioButton25.TabStop = true;
            this.radioButton25.Text = "Outlook Data Files";
            this.radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(10, 102);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(98, 20);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "By Company";
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton24.Location = new System.Drawing.Point(10, 123);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(93, 20);
            this.radioButton24.TabIndex = 1;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "By Location";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.SystemColors.Window;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(10, 82);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 20);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "By Category";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton23.Location = new System.Drawing.Point(10, 4);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(115, 20);
            this.radioButton23.TabIndex = 0;
            this.radioButton23.TabStop = true;
            this.radioButton23.Text = "Business Cards";
            this.radioButton23.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(10, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Phone List";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(10, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Detailed Address Cards";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(10, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Address Cards";
            // 
            // linkLabel18
            // 
            this.linkLabel18.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel18.AutoSize = true;
            this.linkLabel18.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel18.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel18.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel18.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel18.Location = new System.Drawing.Point(9, 299);
            this.linkLabel18.Name = "linkLabel18";
            this.linkLabel18.Size = new System.Drawing.Size(84, 14);
            this.linkLabel18.TabIndex = 1005;
            this.linkLabel18.TabStop = true;
            this.linkLabel18.Text = "Add New Group";
            this.linkLabel18.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel19
            // 
            this.linkLabel19.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel19.AutoSize = true;
            this.linkLabel19.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel19.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel19.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel19.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel19.Location = new System.Drawing.Point(9, 317);
            this.linkLabel19.Name = "linkLabel19";
            this.linkLabel19.Size = new System.Drawing.Size(133, 14);
            this.linkLabel19.TabIndex = 1006;
            this.linkLabel19.TabStop = true;
            this.linkLabel19.Text = "Customize Current View...";
            this.linkLabel19.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // calendarPanel
            // 
            this.calendarPanel.BackColor = System.Drawing.Color.White;
            this.calendarPanel.Controls.Add(this.gradientPanel3);
            this.calendarPanel.Location = new System.Drawing.Point(1, 27);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(201, 407);
            this.calendarPanel.TabIndex = 1;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gradientPanel3.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel3.Controls.Add(this.linkLabel10);
            this.gradientPanel3.Controls.Add(this.panel11);
            this.gradientPanel3.Controls.Add(this.linkLabel12);
            this.gradientPanel3.Controls.Add(this.linkLabel13);
            this.gradientPanel3.Controls.Add(this.xpTaskBar1);
            this.gradientPanel3.Controls.Add(this.linkLabel14);
            this.gradientPanel3.Controls.Add(this.linkLabel17);
            this.gradientPanel3.Controls.Add(this.linkLabel15);
            this.gradientPanel3.Controls.Add(this.linkLabel16);
            this.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel3.Location = new System.Drawing.Point(0, 169);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(201, 238);
            this.gradientPanel3.TabIndex = 0;
            // 
            // linkLabel10
            // 
            this.linkLabel10.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel10.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel10.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel10.Location = new System.Drawing.Point(9, 96);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(124, 14);
            this.linkLabel10.TabIndex = 2;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "How to Share Calendars";
            this.linkLabel10.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(209)))), ((int)(((byte)(255)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 79);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(197, 5);
            this.panel11.TabIndex = 1;
            // 
            // linkLabel12
            // 
            this.linkLabel12.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel12.AutoSize = true;
            this.linkLabel12.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel12.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel12.Location = new System.Drawing.Point(9, 117);
            this.linkLabel12.Name = "linkLabel12";
            this.linkLabel12.Size = new System.Drawing.Size(134, 14);
            this.linkLabel12.TabIndex = 3;
            this.linkLabel12.TabStop = true;
            this.linkLabel12.Text = "Open a Shared Calendar...";
            this.linkLabel12.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel13
            // 
            this.linkLabel13.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel13.AutoSize = true;
            this.linkLabel13.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel13.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel13.Location = new System.Drawing.Point(10, 134);
            this.linkLabel13.Name = "linkLabel13";
            this.linkLabel13.Size = new System.Drawing.Size(127, 14);
            this.linkLabel13.TabIndex = 4;
            this.linkLabel13.TabStop = true;
            this.linkLabel13.Text = "Search Calendars Online";
            this.linkLabel13.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar1.Controls.Add(this.myCalendarsTaskBarBox1);
            this.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskBar1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Size = new System.Drawing.Size(197, 79);
            this.xpTaskBar1.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007;
            this.xpTaskBar1.TabIndex = 0;
            this.xpTaskBar1.VerticalPadding = 10;
            // 
            // myCalendarsTaskBarBox1
            // 
            this.myCalendarsTaskBarBox1.Controls.Add(this.gradientPanel4);
            this.myCalendarsTaskBarBox1.DrawFocusRect = false;
            this.myCalendarsTaskBarBox1.FocusOnClick = false;
            this.myCalendarsTaskBarBox1.HeaderForeColor = System.Drawing.Color.DarkBlue;
            this.myCalendarsTaskBarBox1.HeaderImageIndex = -1;
            this.myCalendarsTaskBarBox1.HitTaskBoxArea = false;
            this.myCalendarsTaskBarBox1.Location = new System.Drawing.Point(0, 0);
            this.myCalendarsTaskBarBox1.Name = "myCalendarsTaskBarBox1";
            this.myCalendarsTaskBarBox1.PreferredChildPanelHeight = 45;
            this.myCalendarsTaskBarBox1.Size = new System.Drawing.Size(195, 70);
            this.myCalendarsTaskBarBox1.TabIndex = 0;
            this.myCalendarsTaskBarBox1.Text = "My Calendars";
            this.myCalendarsTaskBarBox1.ProvideHeaderBackgroundBrush += new Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(this.TaskBarBox_ProvideHeaderBackgroundBrush);
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradientPanel4.Controls.Add(this.checkBox2);
            this.gradientPanel4.Controls.Add(this.checkBox1);
            this.gradientPanel4.Location = new System.Drawing.Point(2, 23);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(191, 45);
            this.gradientPanel4.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.White;
            this.checkBox2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ImageIndex = 12;
            this.checkBox2.ImageList = this.smallImageList;
            this.checkBox2.Location = new System.Drawing.Point(3, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(169, 18);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Calendar in Archive Folder";
            this.checkBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ImageIndex = 12;
            this.checkBox1.ImageList = this.smallImageList;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Calendar";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // linkLabel14
            // 
            this.linkLabel14.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel14.AutoSize = true;
            this.linkLabel14.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel14.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel14.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel14.Location = new System.Drawing.Point(9, 158);
            this.linkLabel14.Name = "linkLabel14";
            this.linkLabel14.Size = new System.Drawing.Size(109, 14);
            this.linkLabel14.TabIndex = 5;
            this.linkLabel14.TabStop = true;
            this.linkLabel14.Text = "Share My Calendar...";
            this.linkLabel14.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel17
            // 
            this.linkLabel17.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel17.AutoSize = true;
            this.linkLabel17.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel17.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel17.Location = new System.Drawing.Point(9, 217);
            this.linkLabel17.Name = "linkLabel17";
            this.linkLabel17.Size = new System.Drawing.Size(84, 14);
            this.linkLabel17.TabIndex = 8;
            this.linkLabel17.TabStop = true;
            this.linkLabel17.Text = "Add New Group";
            this.linkLabel17.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel15
            // 
            this.linkLabel15.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel15.AutoSize = true;
            this.linkLabel15.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel15.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel15.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel15.Location = new System.Drawing.Point(9, 175);
            this.linkLabel15.Name = "linkLabel15";
            this.linkLabel15.Size = new System.Drawing.Size(147, 14);
            this.linkLabel15.TabIndex = 6;
            this.linkLabel15.TabStop = true;
            this.linkLabel15.Text = "Send a Calendar via E-mail...";
            this.linkLabel15.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // linkLabel16
            // 
            this.linkLabel16.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel16.AutoSize = true;
            this.linkLabel16.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.linkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel16.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            this.linkLabel16.Location = new System.Drawing.Point(9, 194);
            this.linkLabel16.Name = "linkLabel16";
            this.linkLabel16.Size = new System.Drawing.Size(116, 14);
            this.linkLabel16.TabIndex = 7;
            this.linkLabel16.TabStop = true;
            this.linkLabel16.Text = "Publish My Calendar...";
            this.linkLabel16.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(178)))));
            // 
            // splashPanel1
            // 
            this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.HighlightText);
            this.splashPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splashPanel1.BackgroundImage")));
            this.splashPanel1.BorderType = Syncfusion.Windows.Forms.Tools.SplashBorderType.None;
            this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
            this.splashPanel1.Location = new System.Drawing.Point(128, 621);
            this.splashPanel1.Name = "splashPanel1";
            this.splashPanel1.Size = new System.Drawing.Size(430, 230);
            this.splashPanel1.TabIndex = 5;
            this.splashPanel1.Text = "splashPanel1";
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.Client = this.mailPanel;
            this.groupBarItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem1.Icon")));
            this.groupBarItem1.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem1.NavigationPaneIcon")));
            this.groupBarItem1.Padding = 4;
            this.groupBarItem1.Text = "Mail";
            // 
            // groupBarItem7
            // 
            this.groupBarItem7.Client = this.calendarPanel;
            this.groupBarItem7.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem7.Icon")));
            this.groupBarItem7.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem7.NavigationPaneIcon")));
            this.groupBarItem7.Padding = 4;
            this.groupBarItem7.Text = "Calendar";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.Client = this.contactsPanel;
            this.groupBarItem3.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem3.Icon")));
            this.groupBarItem3.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem3.NavigationPaneIcon")));
            this.groupBarItem3.Padding = 4;
            this.groupBarItem3.Text = "Contacts";
            // 
            // groupBarItem4
            // 
            this.groupBarItem4.Client = this.tasksPanel;
            this.groupBarItem4.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem4.Icon")));
            this.groupBarItem4.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem4.NavigationPaneIcon")));
            this.groupBarItem4.Padding = 4;
            this.groupBarItem4.Text = "Tasks";
            // 
            // groupBarItem5
            // 
            this.groupBarItem5.Client = this.notesPanel;
            this.groupBarItem5.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem5.Icon")));
            this.groupBarItem5.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem5.NavigationPaneIcon")));
            this.groupBarItem5.Padding = 4;
            this.groupBarItem5.Text = "Notes";
            // 
            // groupBarItem6
            // 
            this.groupBarItem6.Client = this.folderlistPanel;
            this.groupBarItem6.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem6.Icon")));
            this.groupBarItem6.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem6.NavigationPaneIcon")));
            this.groupBarItem6.Padding = 4;
            this.groupBarItem6.Text = "Folder List";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.Client = this.journalPanel;
            this.groupBarItem2.Icon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem2.Icon")));
            this.groupBarItem2.NavigationPaneIcon = ((System.Drawing.Icon)(resources.GetObject("groupBarItem2.NavigationPaneIcon")));
            this.groupBarItem2.Padding = 4;
            this.groupBarItem2.Text = "Journal";
            this.groupBarItem2.Visible = false;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(1, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(302, 246);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
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
            this.imageList1.Images.SetKeyName(15, "");
            this.imageList1.Images.SetKeyName(16, "");
            this.imageList1.Images.SetKeyName(17, "");
            this.imageList1.Images.SetKeyName(18, "");
            this.imageList1.Images.SetKeyName(19, "");
            this.imageList1.Images.SetKeyName(20, "");
            this.imageList1.Images.SetKeyName(21, "");
            this.imageList1.Images.SetKeyName(22, "");
            this.imageList1.Images.SetKeyName(23, "");
            this.imageList1.Images.SetKeyName(24, "");
            this.imageList1.Images.SetKeyName(25, "");
            this.imageList1.Images.SetKeyName(26, "");
            this.imageList1.Images.SetKeyName(27, "");
            this.imageList1.Images.SetKeyName(28, "");
            this.imageList1.Images.SetKeyName(29, "");
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Bars.Add(this.bar3);
            this.mainFrameBarManager1.Categories.Add("&File");
            this.mainFrameBarManager1.Categories.Add("&View");
            this.mainFrameBarManager1.Categories.Add("&Edit");
            this.mainFrameBarManager1.Categories.Add("&Go");
            this.mainFrameBarManager1.Categories.Add("&Tools");
            this.mainFrameBarManager1.Categories.Add("&Actions");
            this.mainFrameBarManager1.Categories.Add("&Help");
            this.mainFrameBarManager1.Categories.Add("Popups");
            this.mainFrameBarManager1.Categories.Add("grid");
            this.mainFrameBarManager1.Categories.Add("ScheduleView");
            this.mainFrameBarManager1.Categories.Add("VisualStyles");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.ImageList = this.smallImageList;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2,
            this.barItem1,
            this.barItem2,
            this.parentBarItem3,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.parentBarItem10,
            this.barItem37,
            this.barItem38,
            this.barItem39,
            this.barItem40,
            this.parentBarItem4,
            this.barItem42,
            this.barItem43,
            this.barItem44,
            this.barItem45,
            this.parentBarItem5,
            this.barItem46,
            this.barItem29,
            this.barItem52,
            this.parentBarItem6,
            this.barItem53,
            this.parentBarItem8,
            this.parentBarItem9,
            this.barItem6,
            this.barItem7,
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18,
            this.parentBarItem11,
            this.barItem19,
            this.parentBarItem12,
            this.barItem20,
            this.parentBarItem13,
            this.barItem21,
            this.parentBarItem14,
            this.barItem22,
            this.mailBarItem,
            this.calendarBarItem,
            this.contactsBarItem,
            this.tasksBarItem,
            this.notesBarItem,
            this.folderlistBarItem,
            this.journalBarItem,
            this.barItem31,
            this.barItem32,
            this.parentBarItem7,
            this.parentBarItem15,
            this.parentBarItem16,
            this.barItem33,
            this.barItem34,
            this.barItem35,
            this.barItem36,
            this.barItem41,
            this.barItem47,
            this.barItem48,
            this.barItem49,
            this.barItem50,
            this.barItem51,
            this.barItem54,
            this.barItem55,
            this.barItem56,
            this.barItem57,
            this.barItem58,
            this.barItem59,
            this.barItem60,
            this.barItem23,
            this.barItem24,
            this.barItem25,
            this.barItem26,
            this.barItem27,
            this.barItem28,
            this.barItem30,
            this.barItem62,
            this.barItem_AutoPreview,
            this.barItem63,
            this.barItem64,
            this.barItem65,
            this.barItem66,
            this.barItem67,
            this.barItem68,
            this.blueStyleBarItem,
            this.blackStyleBarItem,
            this.silverStyleBarItem,
            this.parentBarItem17});
            this.mainFrameBarManager1.LargeImageList = this.imageList1;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
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
            this.parentBarItem4,
            this.parentBarItem5,
            this.parentBarItem6,
            this.parentBarItem8,
            this.parentBarItem9,
            this.parentBarItem17});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem10,
            this.parentBarItem2,
            this.barItem1,
            this.barItem2,
            this.parentBarItem3,
            this.barItem3,
            this.barItem4,
            this.barItem5});
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            3,
            4,
            7});
            this.parentBarItem1.Text = "&File";
            // 
            // parentBarItem10
            // 
            this.parentBarItem10.CategoryIndex = 0;
            this.parentBarItem10.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem10.ID = "Ne&w";
            this.parentBarItem10.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem29,
            this.barItem37,
            this.barItem38,
            this.barItem39,
            this.barItem40,
            this.barItem42,
            this.barItem43,
            this.barItem44});
            this.parentBarItem10.ParentStyle = Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItemStyle.DropDown;
            this.parentBarItem10.SeparatorIndices.AddRange(new int[] {
            1,
            3});
            this.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            this.parentBarItem10.Text = "Ne&w";
            this.parentBarItem10.Click += new System.EventHandler(this.OnNewMailMessageClick);
            // 
            // barItem29
            // 
            this.barItem29.CategoryIndex = 0;
            this.barItem29.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem29.ID = "&Mail Message";
            this.barItem29.ImageIndex = 25;
            this.barItem29.Text = "&Mail Message";
            this.barItem29.Click += new System.EventHandler(this.OnNewMailMessageClick);
            // 
            // barItem37
            // 
            this.barItem37.CategoryIndex = 0;
            this.barItem37.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem37.ID = "Folder";
            this.barItem37.ImageIndex = 3;
            this.barItem37.Text = "Folder";
            // 
            // barItem38
            // 
            this.barItem38.CategoryIndex = 0;
            this.barItem38.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem38.ID = "Search Folder";
            this.barItem38.ImageIndex = 4;
            this.barItem38.Text = "Search Folder";
            // 
            // barItem39
            // 
            this.barItem39.CategoryIndex = 0;
            this.barItem39.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem39.ID = "Appointment";
            this.barItem39.ImageIndex = 12;
            this.barItem39.Text = "Appointment";
            // 
            // barItem40
            // 
            this.barItem40.CategoryIndex = 0;
            this.barItem40.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem40.ID = "Contact";
            this.barItem40.ImageIndex = 9;
            this.barItem40.Text = "Contact";
            // 
            // barItem42
            // 
            this.barItem42.CategoryIndex = 0;
            this.barItem42.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem42.ID = "Task";
            this.barItem42.ImageIndex = 10;
            this.barItem42.Text = "Task";
            // 
            // barItem43
            // 
            this.barItem43.CategoryIndex = 0;
            this.barItem43.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem43.ID = "Journal Entry";
            this.barItem43.ImageIndex = 13;
            this.barItem43.Text = "Journal Entry";
            // 
            // barItem44
            // 
            this.barItem44.CategoryIndex = 0;
            this.barItem44.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem44.ID = "Note";
            this.barItem44.ImageIndex = 11;
            this.barItem44.Text = "Note";
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.CategoryIndex = 0;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "&Open";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem46,
            this.barItem45});
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem2.Text = "&Open";
            // 
            // barItem46
            // 
            this.barItem46.CategoryIndex = 0;
            this.barItem46.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem46.ID = "Outlook Data File";
            this.barItem46.Text = "Outlook Data File";
            // 
            // barItem45
            // 
            this.barItem45.CategoryIndex = 0;
            this.barItem45.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem45.ID = "Selected Items";
            this.barItem45.Text = "Selected Items";
            // 
            // barItem1
            // 
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "Clos&e All Items";
            this.barItem1.Text = "Clos&e All Items";
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Save &As...";
            this.barItem2.Text = "Save &As...";
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.CategoryIndex = 0;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "Page Set&up";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem52,
            this.barItem53});
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem3.Text = "Page Set&up";
            // 
            // barItem52
            // 
            this.barItem52.CategoryIndex = 0;
            this.barItem52.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem52.ID = "Page Style";
            this.barItem52.Text = "Page Style";
            // 
            // barItem53
            // 
            this.barItem53.CategoryIndex = 0;
            this.barItem53.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem53.ID = "Memo Style";
            this.barItem53.Text = "Memo Style";
            // 
            // barItem3
            // 
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "Print Pre&view";
            this.barItem3.ImageIndex = 30;
            this.barItem3.Text = "Print Pre&view";
            // 
            // barItem4
            // 
            this.barItem4.CategoryIndex = 0;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "&Print";
            this.barItem4.ImageIndex = 29;
            this.barItem4.Text = "&Print";
            // 
            // barItem5
            // 
            this.barItem5.CategoryIndex = 0;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "E&xit";
            this.barItem5.Text = "E&xit";
            this.barItem5.Click += new System.EventHandler(this.barItem5_Click);
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.CategoryIndex = 2;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "&Edit";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem6,
            this.barItem7,
            this.barItem8,
            this.barItem9,
            this.barItem10,
            this.barItem11,
            this.barItem12,
            this.barItem13,
            this.barItem14,
            this.barItem15,
            this.barItem16,
            this.barItem17,
            this.barItem18});
            this.parentBarItem4.SeparatorIndices.AddRange(new int[] {
            1,
            5,
            6,
            10,
            12});
            this.parentBarItem4.Text = "&Edit";
            // 
            // barItem6
            // 
            this.barItem6.CategoryIndex = 2;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "&Undo";
            this.barItem6.ImageIndex = 35;
            this.barItem6.Text = "&Undo";
            // 
            // barItem7
            // 
            this.barItem7.CategoryIndex = 2;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "Cu&t";
            this.barItem7.ImageIndex = 19;
            this.barItem7.Text = "Cu&t";
            // 
            // barItem8
            // 
            this.barItem8.CategoryIndex = 2;
            this.barItem8.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem8.ID = "&Copy";
            this.barItem8.ImageIndex = 17;
            this.barItem8.Text = "&Copy";
            // 
            // barItem9
            // 
            this.barItem9.CategoryIndex = 2;
            this.barItem9.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem9.ID = "Office Clip&board";
            this.barItem9.ImageIndex = 16;
            this.barItem9.Text = "Office Clip&board";
            // 
            // barItem10
            // 
            this.barItem10.CategoryIndex = 2;
            this.barItem10.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem10.ID = "&Paste";
            this.barItem10.ImageIndex = 26;
            this.barItem10.Text = "&Paste";
            // 
            // barItem11
            // 
            this.barItem11.CategoryIndex = 2;
            this.barItem11.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem11.ID = "Select A&ll";
            this.barItem11.Text = "Select A&ll";
            // 
            // barItem12
            // 
            this.barItem12.CategoryIndex = 2;
            this.barItem12.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem12.ID = "&Delete";
            this.barItem12.ImageIndex = 20;
            this.barItem12.Text = "&Delete";
            // 
            // barItem13
            // 
            this.barItem13.CategoryIndex = 2;
            this.barItem13.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem13.ID = "&Undelete";
            this.barItem13.Text = "&Undelete";
            // 
            // barItem14
            // 
            this.barItem14.CategoryIndex = 2;
            this.barItem14.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem14.ID = "&Move To Folder";
            this.barItem14.ImageIndex = 24;
            this.barItem14.Text = "&Move To Folder";
            // 
            // barItem15
            // 
            this.barItem15.CategoryIndex = 2;
            this.barItem15.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem15.ID = "Cop&y To Folder";
            this.barItem15.Text = "Cop&y To Folder";
            // 
            // barItem16
            // 
            this.barItem16.CategoryIndex = 2;
            this.barItem16.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem16.ID = "Mark as Read";
            this.barItem16.ImageIndex = 14;
            this.barItem16.Text = "Mark as Read";
            // 
            // barItem17
            // 
            this.barItem17.CategoryIndex = 2;
            this.barItem17.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem17.ID = "Mark as Unread";
            this.barItem17.ImageIndex = 36;
            this.barItem17.Text = "Mark as Unread";
            // 
            // barItem18
            // 
            this.barItem18.CategoryIndex = 2;
            this.barItem18.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem18.ID = "Categor&ies...";
            this.barItem18.Text = "Categor&ies...";
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.CategoryIndex = 1;
            this.parentBarItem5.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem5.ID = "&View";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem11,
            this.barItem19,
            this.parentBarItem12,
            this.barItem20,
            this.parentBarItem13,
            this.barItem21,
            this.parentBarItem14,
            this.barItem22});
            this.parentBarItem5.SeparatorIndices.AddRange(new int[] {
            1,
            5,
            6});
            this.parentBarItem5.Text = "&View";
            // 
            // parentBarItem11
            // 
            this.parentBarItem11.CategoryIndex = 1;
            this.parentBarItem11.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem11.ID = "&Arrange By";
            this.parentBarItem11.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem41});
            this.parentBarItem11.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem11.Text = "&Arrange By";
            // 
            // barItem41
            // 
            this.barItem41.CategoryIndex = 1;
            this.barItem41.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem41.ID = "Date";
            this.barItem41.Text = "Date";
            // 
            // barItem19
            // 
            this.barItem19.CategoryIndex = 1;
            this.barItem19.Checked = true;
            this.barItem19.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem19.ID = "Na&vigation Pane";
            this.barItem19.Text = "Na&vigation Pane";
            this.barItem19.Click += new System.EventHandler(this.barItem19_Click);
            // 
            // parentBarItem12
            // 
            this.parentBarItem12.CategoryIndex = 1;
            this.parentBarItem12.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem12.ID = "Reading Pa&ne";
            this.parentBarItem12.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem47,
            this.barItem48,
            this.barItem63});
            this.parentBarItem12.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem12.Text = "Reading Pa&ne";
            // 
            // barItem47
            // 
            this.barItem47.CategoryIndex = 1;
            this.barItem47.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem47.ID = "Right";
            this.barItem47.ImageIndex = 46;
            this.barItem47.Text = "Right";
            this.barItem47.Click += new System.EventHandler(this.barItem47_Click);
            // 
            // barItem48
            // 
            this.barItem48.CategoryIndex = 1;
            this.barItem48.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem48.ID = "Bottom";
            this.barItem48.ImageIndex = 44;
            this.barItem48.Text = "Bottom";
            this.barItem48.Click += new System.EventHandler(this.barItem48_Click);
            // 
            // barItem63
            // 
            this.barItem63.CategoryIndex = 1;
            this.barItem63.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem63.ID = "&Off";
            this.barItem63.ImageIndex = 45;
            this.barItem63.Text = "&Off";
            this.barItem63.Click += new System.EventHandler(this.barItem63_Click);
            // 
            // barItem20
            // 
            this.barItem20.CategoryIndex = 1;
            this.barItem20.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem20.ID = "Auto&Preview";
            this.barItem20.ImageIndex = 27;
            this.barItem20.Text = "Auto&Preview";
            this.barItem20.Click += new System.EventHandler(this.barItem20_Click);
            // 
            // parentBarItem13
            // 
            this.parentBarItem13.CategoryIndex = 1;
            this.parentBarItem13.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem13.ID = "Expand/Collapse Groups";
            this.parentBarItem13.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem49,
            this.barItem50,
            this.barItem68});
            this.parentBarItem13.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem13.Text = "Expand/Collapse Groups";
            // 
            // barItem49
            // 
            this.barItem49.CategoryIndex = 1;
            this.barItem49.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem49.ID = "Expand All Groups";
            this.barItem49.Text = "Expand All Groups";
            this.barItem49.Click += new System.EventHandler(this.barItem49_Click);
            // 
            // barItem50
            // 
            this.barItem50.CategoryIndex = 1;
            this.barItem50.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem50.ID = "Collapse All Groups";
            this.barItem50.Text = "Collapse All Groups";
            this.barItem50.Click += new System.EventHandler(this.barItem50_Click);
            // 
            // barItem68
            // 
            this.barItem68.CategoryIndex = 1;
            this.barItem68.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem68.ID = "Expand This Group";
            this.barItem68.Text = "Expand This Group";
            this.barItem68.Click += new System.EventHandler(this.barItem68_Click);
            // 
            // barItem21
            // 
            this.barItem21.CategoryIndex = 1;
            this.barItem21.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem21.ID = "&Refresh";
            this.barItem21.Text = "&Refresh";
            // 
            // parentBarItem14
            // 
            this.parentBarItem14.CategoryIndex = 1;
            this.parentBarItem14.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem14.ID = "&Toolbars";
            this.parentBarItem14.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem51});
            this.parentBarItem14.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.parentBarItem14.Text = "&Toolbars";
            // 
            // barItem51
            // 
            this.barItem51.CategoryIndex = 1;
            this.barItem51.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem51.ID = "Standard";
            this.barItem51.Text = "Standard";
            // 
            // barItem22
            // 
            this.barItem22.CategoryIndex = 1;
            this.barItem22.Checked = true;
            this.barItem22.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem22.ID = "&Status Bar";
            this.barItem22.Text = "&Status Bar";
            this.barItem22.Click += new System.EventHandler(this.barItem22_Click);
            // 
            // parentBarItem6
            // 
            this.parentBarItem6.CategoryIndex = 3;
            this.parentBarItem6.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem6.ID = "&Go";
            this.parentBarItem6.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.mailBarItem,
            this.calendarBarItem,
            this.contactsBarItem,
            this.tasksBarItem,
            this.notesBarItem,
            this.folderlistBarItem,
            this.journalBarItem,
            this.barItem31});
            this.parentBarItem6.SeparatorIndices.AddRange(new int[] {
            5,
            7});
            this.parentBarItem6.Text = "&Go";
            // 
            // mailBarItem
            // 
            this.mailBarItem.CategoryIndex = 3;
            this.mailBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailBarItem.ID = "&Mail";
            this.mailBarItem.ImageIndex = 14;
            this.mailBarItem.Text = "&Mail";
            this.mailBarItem.Click += new System.EventHandler(this.mailBarItem_Click);
            // 
            // calendarBarItem
            // 
            this.calendarBarItem.CategoryIndex = 3;
            this.calendarBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarBarItem.ID = "&Calendar";
            this.calendarBarItem.ImageIndex = 12;
            this.calendarBarItem.Text = "&Calendar";
            this.calendarBarItem.Click += new System.EventHandler(this.calendarBarItem_Click);
            // 
            // contactsBarItem
            // 
            this.contactsBarItem.CategoryIndex = 3;
            this.contactsBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsBarItem.ID = "Cont&acts";
            this.contactsBarItem.ImageIndex = 9;
            this.contactsBarItem.Text = "Cont&acts";
            this.contactsBarItem.Click += new System.EventHandler(this.contactsBarItem_Click);
            // 
            // tasksBarItem
            // 
            this.tasksBarItem.CategoryIndex = 3;
            this.tasksBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksBarItem.ID = "&Tasks";
            this.tasksBarItem.ImageIndex = 10;
            this.tasksBarItem.Text = "&Tasks";
            this.tasksBarItem.Click += new System.EventHandler(this.tasksBarItem_Click);
            // 
            // notesBarItem
            // 
            this.notesBarItem.CategoryIndex = 3;
            this.notesBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBarItem.ID = "&Notes";
            this.notesBarItem.ImageIndex = 11;
            this.notesBarItem.Text = "&Notes";
            this.notesBarItem.Click += new System.EventHandler(this.notesBarItem_Click);
            // 
            // folderlistBarItem
            // 
            this.folderlistBarItem.CategoryIndex = 3;
            this.folderlistBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderlistBarItem.ID = "Folder &List";
            this.folderlistBarItem.ImageIndex = 3;
            this.folderlistBarItem.Text = "Folder &List";
            this.folderlistBarItem.Click += new System.EventHandler(this.folderlistBarItem_Click);
            // 
            // journalBarItem
            // 
            this.journalBarItem.CategoryIndex = 3;
            this.journalBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journalBarItem.ID = "&Journal";
            this.journalBarItem.ImageIndex = 13;
            this.journalBarItem.Text = "&Journal";
            this.journalBarItem.Click += new System.EventHandler(this.journalBarItem_Click);
            // 
            // barItem31
            // 
            this.barItem31.CategoryIndex = 3;
            this.barItem31.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem31.ID = "&Folder...";
            this.barItem31.Text = "&Folder...";
            // 
            // parentBarItem8
            // 
            this.parentBarItem8.CategoryIndex = 5;
            this.parentBarItem8.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem8.ID = "&Actions";
            this.parentBarItem8.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem32,
            this.parentBarItem7,
            this.parentBarItem15,
            this.parentBarItem16,
            this.barItem33,
            this.barItem34,
            this.barItem35});
            this.parentBarItem8.SeparatorIndices.AddRange(new int[] {
            2,
            3,
            4});
            this.parentBarItem8.Text = "&Actions";
            // 
            // barItem32
            // 
            this.barItem32.CategoryIndex = 5;
            this.barItem32.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem32.ID = "&New Mail Message";
            this.barItem32.ImageIndex = 25;
            this.barItem32.Text = "&New Mail Message";
            // 
            // parentBarItem7
            // 
            this.parentBarItem7.CategoryIndex = 5;
            this.parentBarItem7.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem7.ID = "New Mail &Message Using";
            this.parentBarItem7.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem54,
            this.barItem55,
            this.barItem56});
            this.parentBarItem7.Text = "New Mail &Message Using";
            // 
            // barItem54
            // 
            this.barItem54.CategoryIndex = 5;
            this.barItem54.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem54.ID = "Plain Text";
            this.barItem54.Text = "Plain Text";
            // 
            // barItem55
            // 
            this.barItem55.CategoryIndex = 5;
            this.barItem55.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem55.ID = "Rich Text";
            this.barItem55.Text = "Rich Text";
            // 
            // barItem56
            // 
            this.barItem56.CategoryIndex = 5;
            this.barItem56.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem56.ID = "HTML (No Stationery)";
            this.barItem56.Text = "HTML (No Stationery)";
            // 
            // parentBarItem15
            // 
            this.parentBarItem15.CategoryIndex = 5;
            this.parentBarItem15.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem15.ID = "Follow &Up";
            this.parentBarItem15.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem57,
            this.barItem58,
            this.barItem59});
            this.parentBarItem15.Text = "Follow &Up";
            // 
            // barItem57
            // 
            this.barItem57.CategoryIndex = 5;
            this.barItem57.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem57.ID = "Red Flag";
            this.barItem57.Text = "Red Flag";
            // 
            // barItem58
            // 
            this.barItem58.CategoryIndex = 5;
            this.barItem58.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem58.ID = "Blue Flag";
            this.barItem58.Text = "Blue Flag";
            // 
            // barItem59
            // 
            this.barItem59.CategoryIndex = 5;
            this.barItem59.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem59.ID = "Yellow Flag";
            this.barItem59.Text = "Yellow Flag";
            // 
            // parentBarItem16
            // 
            this.parentBarItem16.CategoryIndex = 5;
            this.parentBarItem16.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem16.ID = "&Junk E-mail";
            this.parentBarItem16.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem60});
            this.parentBarItem16.Text = "&Junk E-mail";
            // 
            // barItem60
            // 
            this.barItem60.CategoryIndex = 5;
            this.barItem60.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem60.ID = "Junk E-mail Options";
            this.barItem60.Text = "Junk E-mail Options";
            // 
            // barItem33
            // 
            this.barItem33.CategoryIndex = 5;
            this.barItem33.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem33.ID = "&Reply";
            this.barItem33.ImageIndex = 31;
            this.barItem33.Text = "&Reply";
            // 
            // barItem34
            // 
            this.barItem34.CategoryIndex = 5;
            this.barItem34.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem34.ID = "Reply to A&ll";
            this.barItem34.ImageIndex = 32;
            this.barItem34.Text = "Reply to A&ll";
            // 
            // barItem35
            // 
            this.barItem35.CategoryIndex = 5;
            this.barItem35.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem35.ID = "For&ward";
            this.barItem35.ImageIndex = 22;
            this.barItem35.Text = "For&ward";
            // 
            // parentBarItem9
            // 
            this.parentBarItem9.CategoryIndex = 6;
            this.parentBarItem9.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem9.ID = "&Help";
            this.parentBarItem9.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem23,
            this.barItem36});
            this.parentBarItem9.Text = "&Help";
            // 
            // barItem23
            // 
            this.barItem23.CategoryIndex = 6;
            this.barItem23.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem23.ID = "OutlookDemo Help";
            this.barItem23.ImageIndex = 23;
            this.barItem23.Text = "OutlookDemo Help";
            // 
            // barItem36
            // 
            this.barItem36.CategoryIndex = 6;
            this.barItem36.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem36.ID = "&About OutlookDemo...";
            this.barItem36.ImageIndex = 37;
            this.barItem36.Text = "&About Syncfusion...";
            this.barItem36.Click += new System.EventHandler(this.barItem36_Click);
            // 
            // parentBarItem17
            // 
            this.parentBarItem17.CategoryIndex = 10;
            this.parentBarItem17.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem17.ID = "Office Theme Styles";
            this.parentBarItem17.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.blueStyleBarItem,
            this.blackStyleBarItem,
            this.silverStyleBarItem});
            this.parentBarItem17.Text = "&Office Theme Styles";
            // 
            // blueStyleBarItem
            // 
            this.blueStyleBarItem.CategoryIndex = 10;
            this.blueStyleBarItem.Checked = true;
            this.blueStyleBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueStyleBarItem.ID = "Blue";
            this.blueStyleBarItem.Text = "Blue";
            this.blueStyleBarItem.Click += new System.EventHandler(this.OnThemeChange);
            // 
            // blackStyleBarItem
            // 
            this.blackStyleBarItem.CategoryIndex = 10;
            this.blackStyleBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackStyleBarItem.ID = "Black";
            this.blackStyleBarItem.Text = "Black";
            this.blackStyleBarItem.Click += new System.EventHandler(this.OnThemeChange);
            // 
            // silverStyleBarItem
            // 
            this.silverStyleBarItem.CategoryIndex = 10;
            this.silverStyleBarItem.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silverStyleBarItem.ID = "Silver";
            this.silverStyleBarItem.Text = "Silver";
            this.silverStyleBarItem.Click += new System.EventHandler(this.OnThemeChange);
            // 
            // bar2
            // 
            this.bar2.BarName = "Standard";
            this.bar2.Caption = "Standard";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem10,
            this.barItem4,
            this.barItem14,
            this.barItem33,
            this.barItem34,
            this.barItem35,
            this.barItem12,
            this.barItem24,
            this.barItem25,
            this.barItem30,
            this.barItem23});
            this.bar2.Manager = this.mainFrameBarManager1;
            this.bar2.SeparatorIndices.AddRange(new int[] {
            1,
            3,
            6,
            7,
            9});
            // 
            // barItem24
            // 
            this.barItem24.CategoryIndex = 4;
            this.barItem24.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem24.ID = "Find";
            this.barItem24.ImageIndex = 47;
            this.barItem24.Text = "Find";
            // 
            // barItem25
            // 
            this.barItem25.CategoryIndex = 4;
            this.barItem25.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem25.ID = "Rules and Alerts";
            this.barItem25.ImageIndex = 33;
            this.barItem25.Text = "Rules and Alerts";
            // 
            // barItem30
            // 
            this.barItem30.CategoryIndex = 4;
            this.barItem30.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem30.ID = "Address Book";
            this.barItem30.ImageIndex = 15;
            this.barItem30.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem30.Text = "Address Book";
            // 
            // bar3
            // 
            this.bar3.BarName = "Advanced";
            this.bar3.Caption = "Advanced";
            this.bar3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem62,
            this.barItem_AutoPreview});
            this.bar3.Manager = this.mainFrameBarManager1;
            // 
            // barItem62
            // 
            this.barItem62.CategoryIndex = 8;
            this.barItem62.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem62.ID = "GroupByBox";
            this.barItem62.ImageIndex = 39;
            this.barItem62.Text = "GroupByBox";
            this.barItem62.Tooltip = "GroupByBox";
            this.barItem62.Click += new System.EventHandler(this.barItem62_Click);
            // 
            // barItem_AutoPreview
            // 
            this.barItem_AutoPreview.CategoryIndex = 8;
            this.barItem_AutoPreview.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem_AutoPreview.ID = "AutoPreview";
            this.barItem_AutoPreview.ImageIndex = 27;
            this.barItem_AutoPreview.Text = "AutoPreview";
            this.barItem_AutoPreview.Click += new System.EventHandler(this.barItem_AutoPreview_Click);
            // 
            // barItem26
            // 
            this.barItem26.CategoryIndex = 4;
            this.barItem26.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem26.ID = "E-mail Accounts";
            this.barItem26.Text = "E-mail Accounts";
            // 
            // barItem27
            // 
            this.barItem27.CategoryIndex = 4;
            this.barItem27.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem27.ID = "Customize";
            this.barItem27.Text = "Customize";
            // 
            // barItem28
            // 
            this.barItem28.CategoryIndex = 4;
            this.barItem28.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem28.ID = "Options";
            this.barItem28.Text = "Options";
            // 
            // barItem64
            // 
            this.barItem64.CategoryIndex = 9;
            this.barItem64.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem64.ID = "Day";
            this.barItem64.ImageIndex = 40;
            this.barItem64.Text = "Day";
            this.barItem64.Click += new System.EventHandler(this.barItem64_Click);
            // 
            // barItem65
            // 
            this.barItem65.CategoryIndex = 9;
            this.barItem65.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem65.ID = "WorkWeek";
            this.barItem65.ImageIndex = 41;
            this.barItem65.Text = "WorkWeek";
            this.barItem65.Click += new System.EventHandler(this.barItem65_Click);
            // 
            // barItem66
            // 
            this.barItem66.CategoryIndex = 9;
            this.barItem66.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem66.ID = "Week";
            this.barItem66.ImageIndex = 42;
            this.barItem66.Text = "Week";
            this.barItem66.Click += new System.EventHandler(this.barItem66_Click);
            // 
            // barItem67
            // 
            this.barItem67.CategoryIndex = 9;
            this.barItem67.CustomTextFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem67.ID = "Month";
            this.barItem67.ImageIndex = 43;
            this.barItem67.Text = "Month";
            this.barItem67.Click += new System.EventHandler(this.barItem67_Click);
            // 
            // clientPanel
            // 
            this.clientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.clientPanel.Controls.Add(this.panel16);
            this.clientPanel.Controls.Add(this.splitter2);
            this.clientPanel.Controls.Add(this.gridContainerPanel);
            this.clientPanel.Controls.Add(this.scheduleContainerPanel);
            this.clientPanel.Controls.Add(this.contactsGridPanel);
            this.clientPanel.Controls.Add(this.gradientPanel1);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 0);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(830, 697);
            this.clientPanel.TabIndex = 4;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel16.Controls.Add(this.Display);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(0, 357);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(830, 340);
            this.panel16.TabIndex = 4;
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.SystemColors.Window;
            this.Display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Display.Location = new System.Drawing.Point(0, 0);
            this.Display.Name = "Display";
            this.Display.ReadOnly = true;
            this.Display.Size = new System.Drawing.Size(828, 338);
            this.Display.TabIndex = 0;
            this.Display.Text = "";
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 353);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(830, 4);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // gridContainerPanel
            // 
            this.gridContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.gridContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridContainerPanel.Location = new System.Drawing.Point(0, 28);
            this.gridContainerPanel.Name = "gridContainerPanel";
            this.gridContainerPanel.Size = new System.Drawing.Size(830, 325);
            this.gridContainerPanel.TabIndex = 2;
            // 
            // scheduleContainerPanel
            // 
            this.scheduleContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.scheduleContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleContainerPanel.Location = new System.Drawing.Point(0, 28);
            this.scheduleContainerPanel.Name = "scheduleContainerPanel";
            this.scheduleContainerPanel.Size = new System.Drawing.Size(830, 669);
            this.scheduleContainerPanel.TabIndex = 2;
            // 
            // contactsGridPanel
            // 
            this.contactsGridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsGridPanel.Location = new System.Drawing.Point(0, 28);
            this.contactsGridPanel.Name = "contactsGridPanel";
            this.contactsGridPanel.Size = new System.Drawing.Size(826, 678);
            this.contactsGridPanel.TabIndex = 5;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255))))));
            this.gradientPanel1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.clientPanelImage);
            this.gradientPanel1.Controls.Add(this.clientPanelLabel1);
            this.gradientPanel1.Controls.Add(this.clientPanelLabel2);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(830, 28);
            this.gradientPanel1.TabIndex = 1;
            // 
            // clientPanelImage
            // 
            this.clientPanelImage.BackColor = System.Drawing.Color.Transparent;
            this.clientPanelImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.clientPanelImage.ImageIndex = 2;
            this.clientPanelImage.ImageList = this.smallImageList;
            this.clientPanelImage.Location = new System.Drawing.Point(0, 0);
            this.clientPanelImage.Name = "clientPanelImage";
            this.clientPanelImage.Size = new System.Drawing.Size(32, 26);
            this.clientPanelImage.TabIndex = 3;
            // 
            // clientPanelLabel1
            // 
            this.clientPanelLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPanelLabel1.BackColor = System.Drawing.Color.Transparent;
            this.clientPanelLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientPanelLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clientPanelLabel1.Location = new System.Drawing.Point(38, -1);
            this.clientPanelLabel1.Name = "clientPanelLabel1";
            this.clientPanelLabel1.Size = new System.Drawing.Size(695, 28);
            this.clientPanelLabel1.TabIndex = 5;
            this.clientPanelLabel1.Text = "Inbox";
            this.clientPanelLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientPanelLabel2
            // 
            this.clientPanelLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clientPanelLabel2.BackColor = System.Drawing.Color.Transparent;
            this.clientPanelLabel2.ForeColor = System.Drawing.Color.White;
            this.clientPanelLabel2.Location = new System.Drawing.Point(739, 0);
            this.clientPanelLabel2.Name = "clientPanelLabel2";
            this.clientPanelLabel2.Size = new System.Drawing.Size(88, 28);
            this.clientPanelLabel2.TabIndex = 4;
            this.clientPanelLabel2.Text = "label12";
            this.clientPanelLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolbarListBarItem1
            // 
            this.toolbarListBarItem1.CategoryIndex = 8;
            this.toolbarListBarItem1.CustomTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolbarListBarItem1.ID = "GroupByBox";
            this.toolbarListBarItem1.Text = "GroupByBox";
            // 
            // barItem61
            // 
            this.barItem61.CategoryIndex = 8;
            this.barItem61.CustomTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem61.ID = "sad";
            this.barItem61.Text = "sad";
            // 
            // listBarItem1
            // 
            this.listBarItem1.CategoryIndex = 8;
            this.listBarItem1.CustomTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBarItem1.ID = "Grou";
            this.listBarItem1.Text = "Grou";
            // 
            // textBoxBarItem1
            // 
            this.textBoxBarItem1.CategoryIndex = 8;
            this.textBoxBarItem1.CustomTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBarItem1.ID = "efrwe";
            this.textBoxBarItem1.Text = "efrwe";
            this.textBoxBarItem1.Value = "";
            // 
            // staticBarItem1
            // 
            this.staticBarItem1.CategoryIndex = 8;
            this.staticBarItem1.CustomTextFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticBarItem1.ID = "ewr";
            this.staticBarItem1.Text = "ewr";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.clientPanel);
            this.splitContainer1.Size = new System.Drawing.Size(830, 697);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 1002;
            // 
            // statusStripEx1
            // 
            this.statusStripEx1.AllowItemReorder = true;
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripEx1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStripEx1.Location = new System.Drawing.Point(1, 827);
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.Size = new System.Drawing.Size(200, 22);
            this.statusStripEx1.TabIndex = 1003;
            this.statusStripEx1.Text = "statusStripEx1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 14);
            this.toolStripStatusLabel1.Text = "Messages";
            // 
            // splashControl1
            // 
            this.splashControl1.AutoMode = false;
            this.splashControl1.CustomSplashPanel = this.splashPanel1;
            this.splashControl1.HideHostForm = true;
            this.splashControl1.HostForm = this;
            this.splashControl1.UseCustomSplashPanel = true;
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.AttachedTo = this.treeView1;
            this.scrollersFrame1.OfficeColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Managed;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007Generic;
            // 
            // scrollersFrame2
            // 
            this.scrollersFrame2.AttachedTo = this.treeView3;
            this.scrollersFrame2.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame2.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007Generic;
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 50);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252))))), System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255))))));
            this.splitContainerAdv1.Panel1.Controls.Add(this.groupBar1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252))))), System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255))))));
            this.splitContainerAdv1.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerAdv1.Size = new System.Drawing.Size(1024, 697);
            this.splitContainerAdv1.SplitterDistance = 187;
            this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue;
            this.splitContainerAdv1.TabIndex = 10001;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.DoubleClick += new System.EventHandler(this.splitContainerAdv1_DoubleClick);
            this.splitContainerAdv1.SplitterMoved += new Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventHandler(this.splitContainerAdv1_SplitterMoved);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 747);
            this.Controls.Add(this.splitContainerAdv1);
            this.Controls.Add(this.statusStripEx1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outlook Demo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.groupBar1.ResumeLayout(false);
            this.mailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBar)).EndInit();
            this.mailTaskBar.ResumeLayout(false);
            this.mailTaskBarBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.journalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel10)).EndInit();
            this.gradientPanel10.ResumeLayout(false);
            this.gradientPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar6)).EndInit();
            this.xpTaskBar6.ResumeLayout(false);
            this.currentViewTaskBarBox3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.folderlistPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).EndInit();
            this.gradientPanel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar5)).EndInit();
            this.xpTaskBar5.ResumeLayout(false);
            this.allFoldersTaskBarBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel9)).EndInit();
            this.gradientPanel9.ResumeLayout(false);
            this.notesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            this.gradientPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar4)).EndInit();
            this.xpTaskBar4.ResumeLayout(false);
            this.currentViewTaskBarBox2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.tasksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            this.gradientPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar3)).EndInit();
            this.xpTaskBar3.ResumeLayout(false);
            this.currentViewTaskBarBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.contactsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.gradientPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar2)).EndInit();
            this.xpTaskBar2.ResumeLayout(false);
            this.currentViewTaskBarBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.calendarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            this.gradientPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            this.myCalendarsTaskBarBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.statusStripEx1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Theme Changes

        private string themeStyle = "Blue";
        public static int r = 189, g = 215, b = 252, r1 = 220, g1 = 235, b1 = 254;
        private void OnThemeChange(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            SetTheme(item.ID);
        }

        public void SetTheme(String theme)
        {
            switch (theme)
            {
                case "Blue":
                    themeStyle = "Blue";
                    r = 189; g = 215; b = 252; r1 = 220; g1 = 235; b1 = 254;
                     SetBackGroundTheme();
                    this.groupBar1.Office2007Theme = Office2007Theme.Blue;
                    this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Blue;
                    this.xpTaskBar1.Office2007ColorScheme = Office2007Theme.Blue;
                    this.xpTaskBar2.Office2007ColorScheme = Office2007Theme.Blue;
                    this.xpTaskBar3.Office2007ColorScheme = Office2007Theme.Blue;
                    this.xpTaskBar4.Office2007ColorScheme = Office2007Theme.Blue;
                    this.xpTaskBar5.Office2007ColorScheme = Office2007Theme.Blue;
                    this.xpTaskBar6.Office2007ColorScheme = Office2007Theme.Blue;
                    this.blueStyleBarItem.Checked = true;
                    this.blackStyleBarItem.Checked = false;
                    this.silverStyleBarItem.Checked = false;
                    this.scrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Blue;
                    this.ColorScheme = Office2007Theme.Blue;
                    SetForeGroundTheme(Color.FromArgb(21, 66, 139));
                    this.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Blue;
                    this.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Blue;
                    this.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Blue;
                    this.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Blue;
					this.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Blue;
                    this.mailTaskBar.Office2007ColorScheme = Office2007Theme.Blue;
                    break;
                case "Black":
                    themeStyle = "Black";
                    SetBackGroundTheme();
                    r = 109; g = 109; b = 109; r1 = 61; g1 = 61; b1 = 61;
                    SetBackGroundTheme();
                    this.groupBar1.Office2007Theme = Office2007Theme.Black;
                    this.xpTaskBar1.Office2007ColorScheme = Office2007Theme.Black;
                    this.xpTaskBar2.Office2007ColorScheme = Office2007Theme.Black;
                    this.xpTaskBar3.Office2007ColorScheme = Office2007Theme.Black;
                    this.xpTaskBar4.Office2007ColorScheme = Office2007Theme.Black;
                    this.xpTaskBar5.Office2007ColorScheme = Office2007Theme.Black;
                    this.xpTaskBar6.Office2007ColorScheme = Office2007Theme.Black;
                    this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black;
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Black;
                    this.blueStyleBarItem.Checked = false;
                    this.blackStyleBarItem.Checked = true;
                    this.silverStyleBarItem.Checked = false;
                    this.scrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Black;
                    this.ColorScheme = Office2007Theme.Black;
                    SetForeGroundTheme(Color.White);
                    this.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Black;
                    this.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Black;
                    this.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Black;
                    this.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Black;
					this.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Black;
                    this.mailTaskBar.Office2007ColorScheme = Office2007Theme.Black;
                    break;
                case "Silver":
                    themeStyle = "Silver";
                    r = 212; g = 214; b = 219; r1 = 178; g1 = 183; b1 = 190;
                    SetBackGroundTheme();
                    this.groupBar1.Office2007Theme = Office2007Theme.Silver;
                    this.xpTaskBar1.Office2007ColorScheme = Office2007Theme.Silver;
                    this.xpTaskBar2.Office2007ColorScheme = Office2007Theme.Silver;
                    this.xpTaskBar3.Office2007ColorScheme = Office2007Theme.Silver;
                    this.xpTaskBar4.Office2007ColorScheme = Office2007Theme.Silver;
                    this.xpTaskBar5.Office2007ColorScheme = Office2007Theme.Silver;
                    this.xpTaskBar6.Office2007ColorScheme = Office2007Theme.Silver;
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Silver;
                    this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
                    this.blueStyleBarItem.Checked = false;
                    this.blackStyleBarItem.Checked = false;
                    this.silverStyleBarItem.Checked = true;
                    this.scrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Silver;
                    this.ColorScheme = Office2007Theme.Silver;
                    SetForeGroundTheme(Color.Black);
                    this.calForm.btnDay.Office2007ColorScheme = Office2007Theme.Silver;
                    this.calForm.btnMonth.Office2007ColorScheme = Office2007Theme.Silver;
                    this.calForm.btnWeek.Office2007ColorScheme = Office2007Theme.Silver;
                    this.calForm.scheduleControl1.Appearance.VisualStyle = GridVisualStyles.Office2007Silver;
					this.gridGroupingPanel.Grid.TableOptions.GridVisualStyles = GridVisualStyles.Office2007Silver;
                    this.mailTaskBar.Office2007ColorScheme = Office2007Theme.Silver;
                    break;
            }
            this.Refresh();
        }

        private void SetBackGroundTheme()
        {
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(r1)), ((System.Byte)(g1)), ((System.Byte)(b1))), System.Drawing.Color.FromArgb(((System.Byte)(r)), ((System.Byte)(g)), ((System.Byte)(b))));
            this.gridContainerPanel.BackColor = Color.FromArgb(r, g, b);
            this.splitContainer1.BackColor = Color.FromArgb(r, g, b);
            this.gridGroupingPanel.BackColor = Color.FromArgb(r, g, b);
            this.splitter2.BackColor = Color.FromArgb(r, g, b);
            this.panel16.BackColor = Color.FromArgb(r1, g1, b1);
            this.panel3.BackColor = Color.FromArgb(r, g, b);
            this.panel4.BackColor = Color.FromArgb(r, g, b);
            this.panel5.BackColor = Color.FromArgb(r, g, b);
			this.panel1.BackColor = Color.FromArgb(r, g, b);
			this.panel8.BackColor = Color.FromArgb(r, g, b);
			this.panel11.BackColor = Color.FromArgb(r, g, b);
            this.calForm.BackColor = Color.FromArgb(r, g, b);
            this.calForm.scheduleControl1.BackColor = Color.FromArgb(r, g, b);
            this.calForm.scheduleControl1.Appearance.SplitterBackColor = Color.FromArgb(r, g, b);
            this.calForm.scheduleControl1.Appearance.MarkColumnColor = Color.FromArgb(r, g, b);
            this.calForm.scheduleControl1.Appearance.NavigationCalendarHeaderColor = Color.FromArgb(r, g, b);
            this.calForm.scheduleControl1.NavigationPanel.BackColor = Color.FromArgb(r1, g1, b1);
            this.calForm.scheduleControl1.Appearance.MonthWeekHeaderBackColor = Color.FromArgb(r1, g1, b1);
            this.calForm.scheduleControl1.Appearance.CaptionBackColor = Color.FromArgb(r1, g1, b1);
            this.calForm.scheduleControl1.Appearance.AllDayBackColor = Color.FromArgb(r1, g1, b1);
            this.calForm.scheduleControl1.Calendar.BackColor = Color.FromArgb(r1, g1, b1);
            this.calForm.scheduleControl1.Appearance.TimeBackColor = Color.FromArgb(r1, g1, b1);
            this.calForm.scheduleControl1.Appearance.PrimeTimeCellColor = Color.FromArgb(r1, g1, b1);
            this.calForm.scheduleControl1.Appearance.NonPrimeTimeCellColor = Color.FromArgb(r1, g1, b1);
        }

        private void SetForeGroundTheme(Color color)
        {
            this.clientPanelLabel1.ForeColor = color;
            this.clientPanelLabel2.ForeColor = color;
            this.mailTaskBarBox.HeaderForeColor = color;
            this.favouritesTaskBarBox.HeaderForeColor = color;
            this.myCalendarsTaskBarBox1.HeaderForeColor = color;
            this.myContactsTaskBarBox.HeaderForeColor = color;
            this.myJournalTaskBarBox.HeaderForeColor = color;
            this.mytasksTaskBarBox.HeaderForeColor = color;
            this.currentViewTaskBarBox.HeaderForeColor = color;
            this.currentViewTaskBarBox1.HeaderForeColor = color;
            this.currentViewTaskBarBox2.HeaderForeColor = color;
            this.currentViewTaskBarBox3.HeaderForeColor = color;
            this.calForm.scheduleControl1.Appearance.TimeTextColor = color;
            this.calForm.scheduleControl1.Appearance.TextColor = color;
            this.calForm.radFullWeek.ForeColor = color;
            this.calForm.radWorkWeek.ForeColor = color;
        }

        #endregion

        #region Event Handlers
        private void OnNewMailMessageClick(object sender, EventArgs e)
        {
            new NewMailForm(this, this.themeStyle).Show();
        }

        private void TaskBarBox_ProvideHeaderBackgroundBrush(object sender, ProvideBrushEventArgs args)
        {
            System.Drawing.Drawing2D.Blend blend = new System.Drawing.Drawing2D.Blend();
            blend.Factors = new float[] { 0.0f, 0.25F, 0.5f, 1.0F };
            blend.Positions = new float[] { 0.0F, 0.25F, 0.5F, 1.0F, 1.5F };
            // Estimate the GroupBarItem bounds

            Rectangle rcgroupbaritem = args.Bounds;
            // Create and initialize the LinearGradientBrush
            System.Drawing.Drawing2D.LinearGradientBrush lgbrush = new System.Drawing.Drawing2D.LinearGradientBrush(rcgroupbaritem, Color.White, Color.FromArgb(r, g, b), 90, true);
            lgbrush.Blend = blend;
            args.Brush = lgbrush;
        }

        void mailTaskBar_SizeChanged(object sender, EventArgs e)
        {
            this.mailTaskBarBox.PreferredChildPanelHeight = this.mailTaskBar.Height - this.favouritesTaskBarBox.Height;
        }

        private void groupBar1_NavigationPaneDropDownClick(object sender, Syncfusion.Windows.Forms.Tools.NavigationPaneDropDownClickEventArgs args)
        {
            // Add the 'Navigation Pane Options' and 'Add and Remove Buttons' menu commands to the GroupBar's dropdown menu
            args.ContextMenuProvider.AddContextMenuItem(String.Empty, "Navigation Pane Options...", new EventHandler(this.NavPaneOptions_Click));
            String addremove = "Add or Remove Buttons";
            // Create and add a BarItem for each GroupBarItem in the GroupBar control
            foreach (GroupBarItem item in this.groupBar1.GroupBarItems)
            {
                args.ContextMenuProvider.AddContextMenuItem(addremove, item.Text, new EventHandler(this.AddRemoveButtons_Click));
                args.ContextMenuProvider.SetContextMenuItemChecked(item.Text, item.Visible);
                args.ContextMenuProvider.SetContextMenuItemImage(item.Text, this.smallImageList, (int)this.htLabelToImageIndex[item.Text]);
            }
        }

        private void NavPaneOptions_Click(object sender, System.EventArgs e)
        {
            OutlookDemo.OptionsForm optform = new OutlookDemo.OptionsForm(this);
            optform.ShowDialog(this);
        }

        private void AddRemoveButtons_Click(object sender, System.EventArgs e)
        {
            // Hide or show the GroupBarItem that was clicked on the PopupMenu
            Syncfusion.Windows.Forms.ContextMenuItem cntxtitem = sender as ContextMenuItem;
            String itemtext = cntxtitem.ContextMenuItemText;
            foreach (GroupBarItem item in this.groupBar1.GroupBarItems)
            {
                if (item.Text == itemtext)
                {
                    item.Visible = !item.Visible;
                    break;
                }
            }
        }

        protected override void OnSystemColorsChanged(EventArgs e)
        {
            base.OnSystemColorsChanged(e);
            this.InitializeGroupBarClientColors();
        }



        private void groupBar1_GroupBarItemSelected(object sender, System.EventArgs e)
        {
            // Set the text for the ClientPanel labels
            GroupBarItem selitem = this.groupBar1.GroupBarItems[this.groupBar1.SelectedItem];
            if (selitem.Text == "Mail")
                this.clientPanelLabel1.Text = "Inbox";
            else
                this.clientPanelLabel1.Text = selitem.Text;
            this.clientPanelLabel2.Text = String.Empty;
			if (htLabelToImageIndex.Count > 0 )
            this.clientPanelImage.ImageIndex = (int)this.htLabelToImageIndex[selitem.Text];
        }

        private void barItem5_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void barItem36_Click(object sender, System.EventArgs e)
        {
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
        }

        private void mailBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Mail");
        }

        private void calendarBarItem_Click(object sender, System.EventArgs e)
        {
            this.groupBar1.SelectedItem = 1;
        }

        private void contactsBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Contacts");
        }

        private void tasksBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Tasks");
        }

        private void notesBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Notes");
        }

        private void folderlistBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Folder List");
        }

        private void journalBarItem_Click(object sender, System.EventArgs e)
        {
            this.SetGroupBarSelectedItem("Journal");
        }

        private void SetGroupBarSelectedItem(String itemtext)
        {
            int selecteditem = -1;
            foreach (GroupBarItem item in this.groupBar1.GroupBarItems)
            {
                if (item.Text == itemtext)
                {
                    if (item.Visible == true)
                        selecteditem = this.groupBar1.GroupBarItems.IndexOf(item);
                    break;
                }
            }
            if (selecteditem != -1)
                this.groupBar1.SelectedItem = selecteditem;
        }

        private void barItem48_Click(object sender, System.EventArgs e)
        {
            // Toggle the reading pane to dock bottom
            this.gridContainerPanel.Height = 325;
            this.gridContainerPanel.Dock = DockStyle.Top;
            this.splitter2.Dock = DockStyle.Top;
            this.panel16.Dock = DockStyle.Fill;
            this.panel16.Show();
        }

        private void barItem47_Click(object sender, System.EventArgs e)
        {
            // Toggle the reading pane to dock right
            //this.gridContainerPanel.Width = 490;
            this.gridContainerPanel.Width = 700;
            this.gridContainerPanel.Dock = DockStyle.Left;
            this.splitter2.Dock = DockStyle.Left;
            //this.panel16.Width=280;
            this.panel16.Width = 310;
            this.panel16.Dock = DockStyle.Right;
            this.panel16.Show();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.gridGroupingPanel.Grid.Table.ExpandAllGroups();
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            this.gridGroupingPanel.Close();
        }

        private void barItem62_Click(object sender, System.EventArgs e)
        {
            if (this.groupBar1.SelectedItem == 0)
                this.gridGroupingPanel.Grid.ShowGroupDropArea = !this.gridGroupingPanel.Grid.ShowGroupDropArea;
            else if (this.groupBar1.SelectedItem == 2)
                this.contactForm.Grid.ShowGroupDropArea = !this.contactForm.Grid.ShowGroupDropArea;
        }

        private GridBorder gridBottomBorderhide = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
        private GridBorder gridBottomBorderShow = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, Color.FromArgb(227, 239, 255), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
        private void barItem_AutoPreview_Click(object sender, System.EventArgs e)
        {
            BarItem barItem = (BarItem)sender;
            this.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow = !this.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow;
            barItem.Checked = !barItem.Checked;
            if (barItem.Checked)
            {
                //Turning Preview On
                this.gridGroupingPanel.Grid.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderhide;
                this.gridGroupingPanel.Grid.Appearance.AnyIndentCell.Borders.Bottom = gridBottomBorderhide;
                foreach (Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gcd in this.gridGroupingPanel.Grid.TableDescriptor.Columns)
                {
                    gcd.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderhide;
                    gcd.GroupByAppearance.GroupIndentCell.Borders.Bottom = gridBottomBorderhide;
                }
                this.gridGroupingPanel.PreviewSelected = true;
            }
            else
            {
                //Turning Preview Off
                this.gridGroupingPanel.Grid.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderShow;
                this.gridGroupingPanel.Grid.Appearance.AnyIndentCell.Borders.Bottom = gridBottomBorderShow;
                foreach (Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gcd in this.gridGroupingPanel.Grid.TableDescriptor.Columns)
                {
                    gcd.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderShow;
                    gcd.GroupByAppearance.GroupIndentCell.Borders.Bottom = gridBottomBorderShow;
                }
                this.gridGroupingPanel.PreviewSelected = false;
            }
        }


        private void Model_SelectionChanging(object sender, GridSelectionChangingEventArgs e)
        {
            // use the Nested display elements to know the selection is of record or caption
            int row = 0;
            if (Control.MouseButtons == MouseButtons.Right)
                e.Cancel = true;

            if (e.Reason != GridSelectionReason.MouseMove)
                row = e.Range.Top;

            if (this.gridGroupingPanel.Grid.Table.NestedDisplayElements.Count > row)
            {
                // If the selection is of caption hide the reading pane
                if (this.gridGroupingPanel.Grid.Table.NestedDisplayElements[row].IsCaption())
                    this.Display.Hide();
                if (this.gridGroupingPanel.Grid.Table.NestedDisplayElements[row].IsRecord())
                {
                    this.Display.Show();

                    Record rec = this.gridGroupingPanel.Grid.Table.CurrentRecord;
                    DataRowView drv = this.gridGroupingPanel.Grid.Table.NestedDisplayElements[row].GetData() as DataRowView;

                    string rtf2 =
                        @"{\rtf1\ansi" +
                        // font table
                        @"{\fonttbl" +
                        @"\f0\fswiss Calibri;} " +
                        @"\highlight0\ql\f3\f0\fs28   " + drv["Subject"] + "\\plain\\par" +
                        @"\highlight\ql\f0\f0\fs26    " + drv["From"] + "\\plain\\par" +
                        @"\highlight1\ql\cf0\f0\fs20 {\b     To :}" + drv["To"] + "\\plain\\par" + Environment.NewLine +
                        @"\highlight1\ql\f0\f2\fs20 " + "\\plain\\par" +
                        // third line
                        @"\highlight1\ql\cf0\f0\fs20     " + drv["Content"] + "\\plain\\par" +
                        // closing bracket
                        @"}";

                    // Use display to show the content..
                    if (e.Reason == GridSelectionReason.MouseDown || e.Reason == GridSelectionReason.ArrowKey)
                    {
                        Display.Rtf = rtf2;
                    }
                }
            }
        }

        private void barItem20_Click(object sender, EventArgs e)
        {
            if (this.groupBar1.SelectedItem == 0)
            {
                BarItem barItem = (BarItem)sender;
                this.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow = !this.gridGroupingPanel.Grid.TableOptions.ShowRecordPreviewRow;
                barItem.Checked = !barItem.Checked;
                if (barItem.Checked)
                {
                    //Turning Preview On
                    this.gridGroupingPanel.Grid.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderhide;
                    this.gridGroupingPanel.Grid.Appearance.AnyIndentCell.Borders.Bottom = gridBottomBorderhide;
                    foreach (Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gcd in this.gridGroupingPanel.Grid.TableDescriptor.Columns)
                    {
                        gcd.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderhide;
                        gcd.GroupByAppearance.GroupIndentCell.Borders.Bottom = gridBottomBorderhide;
                    }
                    this.gridGroupingPanel.PreviewSelected = true;
                }
                else
                {
                    //Turning Preview Off
                    this.gridGroupingPanel.Grid.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderShow;
                    this.gridGroupingPanel.Grid.Appearance.AnyIndentCell.Borders.Bottom = gridBottomBorderShow;
                    foreach (Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor gcd in this.gridGroupingPanel.Grid.TableDescriptor.Columns)
                    {
                        gcd.Appearance.AnyRecordFieldCell.Borders.Bottom = gridBottomBorderShow;
                        gcd.GroupByAppearance.GroupIndentCell.Borders.Bottom = gridBottomBorderShow;
                    }
                    this.gridGroupingPanel.PreviewSelected = false;
                }
            }
            else if (this.groupBar1.SelectedItem == 2)
            {
                this.contactForm.Grid.TableModel.Properties.DisplayVertLines = !this.contactForm.Grid.TableModel.Properties.DisplayVertLines;
            }
        }

        private void barItem19_Click(object sender, EventArgs e)
        {
            this.barItem19.Checked = !this.barItem19.Checked;
            if (this.barItem19.Checked)
                this.groupBar1.Show();
            else
                this.groupBar1.Hide();
        }

        private void barItem63_Click(object sender, EventArgs e)
        {
            this.panel16.Hide();
            this.gridContainerPanel.Dock = DockStyle.Fill;
        }

        private void groupBar1_GroupBarItemSelectionChanging(object sender, GroupBarItemSelectionChangingEventArgs args)
        {
            if (this.groupBar1.GroupBarItems[args.NewSelected].Text == "Calendar")
            {
                this.gradientPanel1.Hide();
                this.gridContainerPanel.Hide();
                this.panel16.Hide();
                scheduleContainerPanel.Show();
                this.calendarPanel.Controls.Add(this.calForm.Scheduler.Calendar);
                this.toolStripStatusLabel1.Text = this.calForm.Scheduler.Calendar.DateValue.ToLongDateString();
                this.barItem64.Enabled = true;
                this.barItem65.Enabled = true;
                this.barItem66.Enabled = true;
                this.barItem67.Enabled = true;
                this.clientPanel.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (this.groupBar1.GroupBarItems[args.NewSelected].Text == "Contacts")
            {
                this.clientPanel.BorderStyle = BorderStyle.None;
                this.gridContainerPanel.Hide();
                this.panel16.Hide();
                this.scheduleContainerPanel.Hide();
                this.gradientPanel1.Show();
                this.contactsGridPanel.Show();
                int count = this.contactForm.Grid.TableModel.RowCount - 1;
                this.toolStripStatusLabel1.Text = count.ToString() + " Items";
                this.barItem64.Enabled = false;
                this.barItem65.Enabled = false;
                this.barItem66.Enabled = false;
                this.barItem67.Enabled = false;
            }
            else
            {
                this.clientPanel.BorderStyle = BorderStyle.None;
                this.scheduleContainerPanel.Hide();
                this.gridContainerPanel.Show();
                this.panel16.Show();
                this.contactsGridPanel.Hide();
                this.gradientPanel1.Show();
                this.toolStripStatusLabel1.Text = this.gridGroupingPanel.Grid.Table.Records.Count.ToString() + " Messages";
                this.barItem64.Enabled = false;
                this.barItem65.Enabled = false;
                this.barItem66.Enabled = false;
                this.barItem67.Enabled = false;
            }
        }

        private void barItem22_Click(object sender, EventArgs e)
        {
            this.barItem22.Checked = !this.barItem22.Checked;
            if (!this.barItem22.Checked)
            {
                this.statusStripEx1.Hide();
            }
            else
            {
                this.statusStripEx1.Show();
            }
        }

        private void Table_RecordDeleted(object sender, RecordEventArgs e)
        {
            this.toolStripStatusLabel1.Text = this.gridGroupingPanel.Grid.Table.Records.Count.ToString() + " Messages";
        }

        private void barItem64_Click(object sender, EventArgs e)
        {
            if (this.calForm.Scheduler.ScheduleType != ScheduleViewType.Day)
                this.calForm.Scheduler.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Day);
        }
        private void barItem65_Click(object sender, EventArgs e)
        {
            if (this.calForm.Scheduler.ScheduleType != ScheduleViewType.WorkWeek)
                this.calForm.Scheduler.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.WorkWeek);
        }
        private void barItem66_Click(object sender, EventArgs e)
        {
            if (this.calForm.Scheduler.ScheduleType != ScheduleViewType.Week)
                this.calForm.Scheduler.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Week);
        }
        private void barItem67_Click(object sender, EventArgs e)
        {
            if (this.calForm.Scheduler.ScheduleType != ScheduleViewType.Month)
                this.calForm.Scheduler.PerformSwitchToScheduleViewTypeClick(ScheduleViewType.Month);
        }

        private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton5.Checked)
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Add("CompanyName");
            else
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Remove("CompanyName");
        }

        private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton4.Checked)
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Add("ContactTitle");
            else
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Remove("ContactTitle");
        }

        private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton3.Checked)
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Add("Phone");
            else
                this.contactForm.Grid.TableDescriptor.GroupedColumns.Remove("Phone");
        }

        private void barItem49_Click(object sender, EventArgs e)
        {
            this.gridGroupingPanel.ExpandAllGroupsBarItem.PerformClick();
        }

        private void barItem50_Click(object sender, EventArgs e)
        {
            this.gridGroupingPanel.collapseAllGroupsBarItem.PerformClick();
        }

        private void barItem68_Click(object sender, EventArgs e)
        {
            this.gridGroupingPanel.ExpandthisGroup();
        }

        #endregion
        bool flag = true;

        private void splitContainerAdv1_DoubleClick(object sender, EventArgs e)
        {
            if (flag)
            {
                this.groupBar1.Collapsed = true;
                this.splitContainerAdv1.SplitterDistance = 50;
                flag = false;
            }
            else
            {
                this.groupBar1.Collapsed = false;
                this.splitContainerAdv1.SplitterDistance = distance;
                flag = true;
            }

        }

        private void splitContainerAdv1_SplitterMoved(object sender, Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventArgs e)
        {
            if (this.splitContainerAdv1.SplitterDistance != 50)
                distance = this.splitContainerAdv1.SplitterDistance;
            if (this.splitContainerAdv1.SplitterDistance < 55)
            {
                this.groupBar1.Collapsed = true;
                this.splitContainerAdv1.SplitterDistance = 50;
            }
            else
            {
                this.groupBar1.Collapsed = false;
            }

        }
       
        private void groupBar1_StateChanged(object sender, EventArgs e)
        {
            if (this.groupBar1.Collapsed)
            {
                this.splitContainerAdv1.SplitterDistance = 50;
                flag = false;
            }
            else
            {
                this.splitContainerAdv1.SplitterDistance = distance;
                flag = true;
            }
        }

    }
    #endregion

    #region GroupBarItem class
    // Serves as a temporary store for the GroupBarItem state - Used by the Options Form 'Restore' functionality
    public class GroupBarItemState
    {
        private String strItemText;
        private bool bInNavPane = false;
        private bool bVisible = true;

        public String ItemText { get { return this.strItemText; } }
        public bool InNavPane { get { return this.bInNavPane; } }
        public bool Visible { get { return this.bVisible; } }

        public GroupBarItemState(String text, bool navpane, bool visible)
        {
            this.strItemText = text;
            this.bInNavPane = navpane;
            this.bVisible = visible;
        }
    }
    #endregion

}
