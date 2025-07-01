using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace DragProviderStyles
{
    public class Form1 : Office2007Form
    {
        private Syncfusion.Windows.Forms.Tools.ToolStripEx tsDragStyles;
        private ToolStripButton tsbDefault;
        private ToolStripButton tsbWhidbey;
        private ToolStripButton tsbVs2005;
        private ToolStripButton tsbVs2008;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv syncProductsTree;
        private ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
        private Panel pnlDescription;
        private Label label1;
        private CheckedListBox chkListSWDevlopmt;
        private PictureBox pictureBox1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Form1()
        {
            InitializeComponent();

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbsyncProductsTree = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpnlDescription = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbchkListSWDevlopmt = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbpictureBox1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv7 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv8 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv9 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv10 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.syncProductsTree = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkListSWDevlopmt = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsDragStyles = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.tsbDefault = new System.Windows.Forms.ToolStripButton();
            this.tsbWhidbey = new System.Windows.Forms.ToolStripButton();
            this.tsbVs2005 = new System.Windows.Forms.ToolStripButton();
            this.tsbVs2008 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncProductsTree)).BeginInit();
            this.pnlDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tsDragStyles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.DockTabFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2008;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.ImageList = this.imageList1;
            this.dockingManager1.Office2007MdiChildForm = true;
            this.dockingManager1.Office2007MdiColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook;
            this.dockingManager1.NewDockStateEndLoad += new System.EventHandler(this.dockingManager1_NewDockStateEndLoad);
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"));
            this.dockingManager1.SetDockLabel(this.syncProductsTree, "Syncfusion Products");
            this.dockingManager1.SetDockIcon(this.syncProductsTree, 10);
            ccbsyncProductsTree.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.syncProductsTree, ccbsyncProductsTree);
            this.dockingManager1.SetDockLabel(this.pnlDescription, "Description");
            this.dockingManager1.SetDockIcon(this.pnlDescription, 9);
            ccbpnlDescription.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.pnlDescription, ccbpnlDescription);
            this.dockingManager1.SetDockLabel(this.chkListSWDevlopmt, "Software Development Cycle");
            ccbchkListSWDevlopmt.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.chkListSWDevlopmt, ccbchkListSWDevlopmt);
            this.dockingManager1.SetDockLabel(this.pictureBox1, "Organization Chart");
            ccbpictureBox1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.pictureBox1, ccbpictureBox1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon_samplebrowser.png");
            this.imageList1.Images.SetKeyName(1, "icon_tools.png");
            this.imageList1.Images.SetKeyName(2, "icon_grid.png");
            this.imageList1.Images.SetKeyName(3, "icon_chart.png");
            this.imageList1.Images.SetKeyName(4, "icon_diagram.png");
            this.imageList1.Images.SetKeyName(5, "icon_calculate.png");
            this.imageList1.Images.SetKeyName(6, "icon_docio_opt2.png");
            this.imageList1.Images.SetKeyName(7, "icon_pdf_opt2.png");
            this.imageList1.Images.SetKeyName(8, "icon_xlsio_opt2.png");
            this.imageList1.Images.SetKeyName(9, "MSACCESS_EXE_10_08.ico");
            this.imageList1.Images.SetKeyName(10, "MSO_DLL_68_01.ico");
            // 
            // syncProductsTree
            // 
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.ThemesEnabled = true;
            this.syncProductsTree.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.dockingManager1.SetEnableDocking(this.syncProductsTree, true);
            this.syncProductsTree.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.syncProductsTree.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syncProductsTree.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.syncProductsTree.HelpTextControl.Name = "helpText";
            this.syncProductsTree.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.syncProductsTree.HelpTextControl.TabIndex = 0;
            this.syncProductsTree.HelpTextControl.Text = "help text";
            this.syncProductsTree.LeftImageList = this.imageList1;
            this.syncProductsTree.Location = new System.Drawing.Point(3, 23);
            this.syncProductsTree.Name = "syncProductsTree";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv1.LeftImageIndices = new int[] {
        0};
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.LeftImageIndices = new int[] {
        1};
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.Text = "Essential Tools";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.LeftImageIndices = new int[] {
        2};
            treeNodeAdv3.Text = "Essential Grid";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.LeftImageIndices = new int[] {
        3};
            treeNodeAdv4.Text = "Essential Chart";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.LeftImageIndices = new int[] {
        4};
            treeNodeAdv5.Text = "Essential Diagram";
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.Expanded = true;
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.Expanded = true;
            treeNodeAdv7.LeftImageIndices = new int[] {
        5};
            treeNodeAdv7.Optioned = true;
            treeNodeAdv7.Text = "Essential Calculate";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.Expanded = true;
            treeNodeAdv8.LeftImageIndices = new int[] {
        6};
            treeNodeAdv8.Text = "Essential DocIO";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.Expanded = true;
            treeNodeAdv9.LeftImageIndices = new int[] {
        7};
            treeNodeAdv9.Text = "Essential PDF";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.Expanded = true;
            treeNodeAdv10.LeftImageIndices = new int[] {
        8};
            treeNodeAdv10.Text = "Essential XlsIO";
            treeNodeAdv6.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9,
            treeNodeAdv10});
            treeNodeAdv6.Text = "Back Office Products";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv6});
            treeNodeAdv1.Text = "Essential Suite";
            this.syncProductsTree.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1});
            this.syncProductsTree.Office2007ScrollBars = true;
            this.syncProductsTree.Size = new System.Drawing.Size(159, 476);
            this.syncProductsTree.TabIndex = 2;
            this.syncProductsTree.Text = "treeViewAdv1";
            this.syncProductsTree.ThemesEnabled = true;
            // 
            // 
            // 
            this.syncProductsTree.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.syncProductsTree.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syncProductsTree.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.syncProductsTree.ToolTipControl.Name = "toolTip";
            this.syncProductsTree.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.syncProductsTree.ToolTipControl.TabIndex = 1;
            this.syncProductsTree.ToolTipControl.Text = "toolTip";
            // 
            // pnlDescription
            // 
            this.pnlDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.pnlDescription.Controls.Add(this.label1);
            this.dockingManager1.SetEnableDocking(this.pnlDescription, true);
            this.pnlDescription.Location = new System.Drawing.Point(3, 3);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(341, 109);
            this.pnlDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // chkListSWDevlopmt
            // 
            this.dockingManager1.SetEnableDocking(this.chkListSWDevlopmt, true);
            this.chkListSWDevlopmt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListSWDevlopmt.FormattingEnabled = true;
            this.chkListSWDevlopmt.Items.AddRange(new object[] {
            "Data Collection Phase",
            "Analysis Phase",
            "Design Phase",
            "Implementation Phase",
            "Testing Phase",
            "Distribution Phase"});
            this.chkListSWDevlopmt.Location = new System.Drawing.Point(3, 23);
            this.chkListSWDevlopmt.Name = "chkListSWDevlopmt";
            this.chkListSWDevlopmt.Size = new System.Drawing.Size(450, 180);
            this.chkListSWDevlopmt.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.dockingManager1.SetEnableDocking(this.pictureBox1, true);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tsDragStyles
            // 
            this.tsDragStyles.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsDragStyles.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tsDragStyles.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsDragStyles.Image = null;
            this.tsDragStyles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDefault,
            this.tsbWhidbey,
            this.tsbVs2005,
            this.tsbVs2008});
            this.tsDragStyles.Location = new System.Drawing.Point(0, 0);
            this.tsDragStyles.Name = "tsDragStyles";
            this.tsDragStyles.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.tsDragStyles.ShowCaption = false;
            this.tsDragStyles.ShowLauncher = true;
            this.tsDragStyles.Size = new System.Drawing.Size(625, 25);
            this.tsDragStyles.TabIndex = 1;
            this.tsDragStyles.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsDragStyles_ItemClicked);
            // 
            // tsbDefault
            // 
            this.tsbDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDefault.Image = ((System.Drawing.Image)(resources.GetObject("tsbDefault.Image")));
            this.tsbDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDefault.Name = "tsbDefault";
            this.tsbDefault.Size = new System.Drawing.Size(52, 22);
            this.tsbDefault.Text = "Default";
            // 
            // tsbWhidbey
            // 
            this.tsbWhidbey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbWhidbey.Image = ((System.Drawing.Image)(resources.GetObject("tsbWhidbey.Image")));
            this.tsbWhidbey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbWhidbey.Name = "tsbWhidbey";
            this.tsbWhidbey.Size = new System.Drawing.Size(60, 22);
            this.tsbWhidbey.Text = "Whidbey";
            // 
            // tsbVs2005
            // 
            this.tsbVs2005.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbVs2005.Image = ((System.Drawing.Image)(resources.GetObject("tsbVs2005.Image")));
            this.tsbVs2005.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVs2005.Name = "tsbVs2005";
            this.tsbVs2005.Size = new System.Drawing.Size(55, 22);
            this.tsbVs2005.Text = "VS2005";
            // 
            // tsbVs2008
            // 
            this.tsbVs2008.Checked = true;
            this.tsbVs2008.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbVs2008.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbVs2008.Image = ((System.Drawing.Image)(resources.GetObject("tsbVs2008.Image")));
            this.tsbVs2008.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVs2008.Name = "tsbVs2008";
            this.tsbVs2008.Size = new System.Drawing.Size(55, 22);
            this.tsbVs2008.Text = "VS2008";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 527);
            this.Controls.Add(this.tsDragStyles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag Provider Styles";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syncProductsTree)).EndInit();
            this.pnlDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tsDragStyles.ResumeLayout(false);
            this.tsDragStyles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Change Drag Provider Styles
        private void tsDragStyles_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Default":
                    dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Standard;
                    break;
                case "Whidbey":
                    dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Whidbey;
                    break;
                case "VS2005":
                    dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2005;
                    break;
                case "VS2008":
                    dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2008;
                    break;
            }

            ToolStripButton button = (ToolStripButton)e.ClickedItem;
            button.Checked = true;
         
            for (int i = 0; i < tsDragStyles.Items.Count; i++)
                if (tsDragStyles.Items[i] != e.ClickedItem)
                {
                    button = (ToolStripButton)tsDragStyles.Items[i];
                    button.Checked = false;
                }

        }
        #endregion

        #region Initialization Settings
        private void Form1_Load(object sender, EventArgs e)
        {
            chkListSWDevlopmt.SetItemChecked(0, true);
            chkListSWDevlopmt.SetItemChecked(2, true);
            chkListSWDevlopmt.SetItemChecked(3, true);

        }

        private void dockingManager1_NewDockStateEndLoad(object sender, EventArgs e)
        {
            this.dockingManager1.SetAsMDIChild(this.pnlDescription, true);
        }
        #endregion
    }
}