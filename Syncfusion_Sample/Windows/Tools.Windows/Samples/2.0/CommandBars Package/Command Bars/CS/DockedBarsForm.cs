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

using Syncfusion.Windows.Forms.Tools;

namespace CommandBars
{
    using System;
    using System.Drawing;
    using System.Collections;
    using System.ComponentModel;
    using System.Windows.Forms;
    using System.Data;
    using System.Drawing.Drawing2D;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class DockedBarsForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.RichTextBox richTextBox1;
        public Syncfusion.Windows.Forms.Tools.CommandBarController commandBarController1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.ComboBox fontComboBox;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private System.Windows.Forms.ToolBarButton boldButton;
        private System.Windows.Forms.ToolBarButton italicButton;
        private System.Windows.Forms.ToolBarButton underLineButton;
        private System.Windows.Forms.ToolBarButton laButton;
        private System.Windows.Forms.ToolBarButton centerButton;
        private System.Windows.Forms.ToolBarButton raButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolBarButton separator;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.MenuItem menuItem8;
        private System.Windows.Forms.MenuItem menuItem13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolBarButton toolBarButton1;
        private System.Windows.Forms.ToolBarButton toolBarButton2;
        private System.Windows.Forms.ToolBarButton toolBarButton3;
        private System.Windows.Forms.ToolBarButton toolBarButton5;
        private System.Windows.Forms.ToolBarButton toolBarButton6;
        private System.Windows.Forms.ToolBarButton toolBarButton7;
        private System.Windows.Forms.Panel panel3;
        public Syncfusion.Windows.Forms.Tools.CommandBar commandBarFonts;
        private System.Windows.Forms.ToolBar tbFont;
        public Syncfusion.Windows.Forms.Tools.CommandBar commandBarAlign;
        private System.Windows.Forms.ToolBar tbAlign;
        public Syncfusion.Windows.Forms.Tools.CommandBar commandBarStandard;
        public Syncfusion.Windows.Forms.Tools.CommandBar commandBarAddress;
        private System.Windows.Forms.ToolBar tbStandard;
        private System.Windows.Forms.ToolBarButton toolBarButton8;
        private System.Windows.Forms.Panel pnlFonts;
        private System.Windows.Forms.Panel pnlFontsTB;
        private bool initDone = false;

        private System.Windows.Forms.MenuItem menuItemNew;
        private System.Windows.Forms.MenuItem menuItemOpen;
        private System.Windows.Forms.MenuItem menuItemCopy;
        private System.Windows.Forms.MenuItem menuItemCut;
        private System.Windows.Forms.MenuItem menuItemPaste;
        private System.Windows.Forms.MenuItem menuItemSave;
        private System.Windows.Forms.MenuItem menuItemExit;
        private System.Windows.Forms.MenuItem menuItemStandard;
        private System.Windows.Forms.MenuItem menuItemFonts;
        private System.Windows.Forms.MenuItem menuItemAlign;
        private System.Windows.Forms.MenuItem menuItemAddress;
        private System.Windows.Forms.MenuItem menuItemView;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemEdit;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenuAddress;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biAddressHome;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biAddressFAQ;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biAddressSales;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biAddressProducts;

        private Size szFontToolBarPanel;
        private System.Windows.Forms.StatusBar statusBar1;
        private Syncfusion.Windows.Forms.Tools.XPTaskPane xpTaskPane1;
        private Syncfusion.Windows.Forms.Tools.WizardContainer wizardContainer1;
        private Syncfusion.Windows.Forms.Tools.XPTaskPage xpTaskPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.XPTaskPage xpTaskPage2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel panel1;
        private RadioButton AllowFloating;
        private RadioButton AllowDocking;
        private Size szFontCommandBarPanelSize;


        public DockedBarsForm()
        {
            // Cache the fully extended sizes of the toolbar and panel controls in the fonts CommandBar.
            // These sizes are used for calculating the toolbar dimensions in the CommandBar.CommandBarStateChanging 
            // and CommandBar.CommandBarStateChanged event handlers
            this.szFontToolBarPanel = new Size(72, 23);
            this.szFontCommandBarPanelSize = new Size(288, 24);

            //
            // Required for Windows Form Designer support.
            //
            InitializeComponent();
            this.commandBarAddress.AllowedDockBorders = Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Top | Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Bottom;

            #region Office2003Colors
            Office2003Colors.UpdateMenuColors();
           #endregion
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockedBarsForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.commandBarController1 = new Syncfusion.Windows.Forms.Tools.CommandBarController(this.components);
            this.commandBarFonts = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.pnlFonts = new System.Windows.Forms.Panel();
            this.fontComboBox = new System.Windows.Forms.ComboBox();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.pnlFontsTB = new System.Windows.Forms.Panel();
            this.tbFont = new System.Windows.Forms.ToolBar();
            this.boldButton = new System.Windows.Forms.ToolBarButton();
            this.italicButton = new System.Windows.Forms.ToolBarButton();
            this.underLineButton = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.commandBarAlign = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbAlign = new System.Windows.Forms.ToolBar();
            this.laButton = new System.Windows.Forms.ToolBarButton();
            this.centerButton = new System.Windows.Forms.ToolBarButton();
            this.raButton = new System.Windows.Forms.ToolBarButton();
            this.commandBarStandard = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbStandard = new System.Windows.Forms.ToolBar();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton5 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
            this.commandBarAddress = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.popupMenuAddress = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biAddressHome = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biAddressFAQ = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biAddressSales = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biAddressProducts = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.separator = new System.Windows.Forms.ToolBarButton();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemNew = new System.Windows.Forms.MenuItem();
            this.menuItemOpen = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItemExit = new System.Windows.Forms.MenuItem();
            this.menuItemEdit = new System.Windows.Forms.MenuItem();
            this.menuItemCut = new System.Windows.Forms.MenuItem();
            this.menuItemCopy = new System.Windows.Forms.MenuItem();
            this.menuItemPaste = new System.Windows.Forms.MenuItem();
            this.menuItemView = new System.Windows.Forms.MenuItem();
            this.menuItemStandard = new System.Windows.Forms.MenuItem();
            this.menuItemFonts = new System.Windows.Forms.MenuItem();
            this.menuItemAlign = new System.Windows.Forms.MenuItem();
            this.menuItemAddress = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.wizardContainer1 = new Syncfusion.Windows.Forms.Tools.WizardContainer();
            this.AllowFloating = new System.Windows.Forms.RadioButton();
            this.AllowDocking = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).BeginInit();
            this.commandBarFonts.SuspendLayout();
            this.pnlFonts.SuspendLayout();
            this.pnlFontsTB.SuspendLayout();
            this.commandBarAlign.SuspendLayout();
            this.panel3.SuspendLayout();
            this.commandBarStandard.SuspendLayout();
            this.panel2.SuspendLayout();
            this.commandBarAddress.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.SandyBrown;
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(544, 285);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = @"
NOTE: 

The CommandBars framework should be used only with the standard .NET menus / toolbars and not the Essential Tools XPMenus. 

To implement the XP style menus / toolbars, please use the MainFrameBarManager / ChildFrameBarManager classes as demonstrated in the XPMenus sample.";
            // 
            // commandBarController1
            // 
            this.commandBarController1.CommandBars.Add(this.commandBarFonts);
            this.commandBarController1.CommandBars.Add(this.commandBarAlign);
            this.commandBarController1.CommandBars.Add(this.commandBarStandard);
            this.commandBarController1.CommandBars.Add(this.commandBarAddress);
            this.commandBarController1.HostForm = this;
            this.commandBarController1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // commandBarFonts
            // 
            this.commandBarFonts.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.commandBarFonts.Controls.Add(this.pnlFonts);
            this.commandBarFonts.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.commandBarFonts.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.commandBarFonts.HideDropDownButton = true;
            this.commandBarFonts.MaxLength = 300;
            this.commandBarFonts.MinHeight = 26;
            this.commandBarFonts.MinLength = 50;
            this.commandBarFonts.Name = "commandBarFonts";
            this.commandBarFonts.RowIndex = 0;
            this.commandBarFonts.RowOffset = 169;
            this.commandBarFonts.ShowDockModeText = false;
            this.commandBarFonts.TabIndex = 0;
            this.commandBarFonts.TabStop = false;
            this.commandBarFonts.Text = "Fonts";
            this.commandBarFonts.CommandBarStateChanging += new Syncfusion.Windows.Forms.Tools.CommandBarStateChangingEventHandler(this.cbFonts_CommandBarStateChanging);
            this.commandBarFonts.CommandBarStateChanged += new System.EventHandler(this.cbFonts_CommandBarStateChanging);
            // 
            // pnlFonts
            // 
            this.pnlFonts.Controls.Add(this.fontComboBox);
            this.pnlFonts.Controls.Add(this.fontSizeComboBox);
            this.pnlFonts.Controls.Add(this.pnlFontsTB);
            this.pnlFonts.Location = new System.Drawing.Point(10, 1);
            this.pnlFonts.Name = "pnlFonts";
            this.pnlFonts.Size = new System.Drawing.Size(288, 24);
            this.pnlFonts.TabIndex = 6;
            // 
            // fontComboBox
            // 
            this.fontComboBox.DisplayMember = "Name";
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.Location = new System.Drawing.Point(0, 1);
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(144, 21);
            this.fontComboBox.TabIndex = 5;
            this.fontComboBox.ValueMember = "Name";
            this.fontComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "15"});
            this.fontSizeComboBox.Location = new System.Drawing.Point(148, 1);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(56, 21);
            this.fontSizeComboBox.TabIndex = 4;
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontComboBox_SelectedIndexChanged);
            // 
            // pnlFontsTB
            // 
            this.pnlFontsTB.Controls.Add(this.tbFont);
            this.pnlFontsTB.Location = new System.Drawing.Point(210, 0);
            this.pnlFontsTB.Name = "pnlFontsTB";
            this.pnlFontsTB.Size = new System.Drawing.Size(72, 23);
            this.pnlFontsTB.TabIndex = 5;
            // 
            // tbFont
            // 
            this.tbFont.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbFont.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.boldButton,
            this.italicButton,
            this.underLineButton});
            this.tbFont.Divider = false;
            this.tbFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFont.DropDownArrows = true;
            this.tbFont.ImageList = this.imageList1;
            this.tbFont.Location = new System.Drawing.Point(0, 0);
            this.tbFont.Name = "tbFont";
            this.tbFont.ShowToolTips = true;
            this.tbFont.Size = new System.Drawing.Size(72, 26);
            this.tbFont.TabIndex = 4;
            this.tbFont.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // boldButton
            // 
            this.boldButton.ImageIndex = 3;
            this.boldButton.Name = "boldButton";
            this.boldButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.boldButton.ToolTipText = "Bold";
            // 
            // italicButton
            // 
            this.italicButton.ImageIndex = 4;
            this.italicButton.Name = "italicButton";
            this.italicButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.italicButton.ToolTipText = "Italic";
            // 
            // underLineButton
            // 
            this.underLineButton.ImageIndex = 5;
            this.underLineButton.Name = "underLineButton";
            this.underLineButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.underLineButton.ToolTipText = "Underline";
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
            // 
            // commandBarAlign
            // 
            this.commandBarAlign.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.commandBarAlign.Controls.Add(this.panel3);
            this.commandBarAlign.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.commandBarAlign.FloatModeWrapping = true;
            this.commandBarAlign.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.commandBarAlign.HideDropDownButton = true;
            this.commandBarAlign.MaxLength = 84;
            this.commandBarAlign.MinHeight = 26;
            this.commandBarAlign.MinLength = 50;
            this.commandBarAlign.Name = "commandBarAlign";
            this.commandBarAlign.RowIndex = 1;
            this.commandBarAlign.RowOffset = 402;
            this.commandBarAlign.ShowDockModeText = false;
            this.commandBarAlign.TabIndex = 2;
            this.commandBarAlign.TabStop = false;
            this.commandBarAlign.Text = "Align";
            this.commandBarAlign.CommandBarWrapping += new Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventHandler(this.commandBarAlign_CommandBarWrapping);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbAlign);
            this.panel3.Location = new System.Drawing.Point(10, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 24);
            this.panel3.TabIndex = 5;
            // 
            // tbAlign
            // 
            this.tbAlign.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbAlign.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.laButton,
            this.centerButton,
            this.raButton});
            this.tbAlign.ButtonSize = new System.Drawing.Size(23, 22);
            this.tbAlign.Divider = false;
            this.tbAlign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbAlign.DropDownArrows = true;
            this.tbAlign.ImageList = this.imageList1;
            this.tbAlign.Location = new System.Drawing.Point(0, 0);
            this.tbAlign.Name = "tbAlign";
            this.tbAlign.ShowToolTips = true;
            this.tbAlign.Size = new System.Drawing.Size(72, 26);
            this.tbAlign.TabIndex = 4;
            this.tbAlign.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // laButton
            // 
            this.laButton.ImageIndex = 1;
            this.laButton.Name = "laButton";
            this.laButton.Pushed = true;
            this.laButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.laButton.ToolTipText = "Left Aligned";
            // 
            // centerButton
            // 
            this.centerButton.ImageIndex = 0;
            this.centerButton.Name = "centerButton";
            this.centerButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.centerButton.ToolTipText = "Center Aligned";
            // 
            // raButton
            // 
            this.raButton.ImageIndex = 2;
            this.raButton.Name = "raButton";
            this.raButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this.raButton.ToolTipText = "Right Aligned";
            // 
            // commandBarStandard
            // 
            this.commandBarStandard.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.commandBarStandard.Controls.Add(this.panel2);
            this.commandBarStandard.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.commandBarStandard.FloatModeWrapping = true;
            this.commandBarStandard.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.commandBarStandard.HideDropDownButton = true;
            this.commandBarStandard.MaxLength = 167;
            this.commandBarStandard.MinHeight = 26;
            this.commandBarStandard.MinLength = 50;
            this.commandBarStandard.Name = "commandBarStandard";
            this.commandBarStandard.RowIndex = 0;
            this.commandBarStandard.RowOffset = 0;
            this.commandBarStandard.ShowDockModeText = false;
            this.commandBarStandard.TabIndex = 1;
            this.commandBarStandard.TabStop = false;
            this.commandBarStandard.Text = "Standard";
            this.commandBarStandard.CommandBarWrapping += new Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventHandler(this.commandBarStandard_Wrapping);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbStandard);
            this.panel2.Location = new System.Drawing.Point(10, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 24);
            this.panel2.TabIndex = 5;
            // 
            // tbStandard
            // 
            this.tbStandard.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.tbStandard.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.toolBarButton1,
            this.toolBarButton2,
            this.toolBarButton3,
            this.toolBarButton5,
            this.toolBarButton6,
            this.toolBarButton7,
            this.toolBarButton8});
            this.tbStandard.Divider = false;
            this.tbStandard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStandard.DropDownArrows = true;
            this.tbStandard.ImageList = this.imageList1;
            this.tbStandard.Location = new System.Drawing.Point(0, 0);
            this.tbStandard.Name = "tbStandard";
            this.tbStandard.ShowToolTips = true;
            this.tbStandard.Size = new System.Drawing.Size(155, 26);
            this.tbStandard.TabIndex = 4;
            this.tbStandard.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.tbStandard_ButtonClick);
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.ImageIndex = 6;
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.ToolTipText = "New";
            // 
            // toolBarButton2
            // 
            this.toolBarButton2.ImageIndex = 7;
            this.toolBarButton2.Name = "toolBarButton2";
            this.toolBarButton2.ToolTipText = "Open";
            // 
            // toolBarButton3
            // 
            this.toolBarButton3.ImageIndex = 8;
            this.toolBarButton3.Name = "toolBarButton3";
            this.toolBarButton3.ToolTipText = "Save";
            // 
            // toolBarButton5
            // 
            this.toolBarButton5.Name = "toolBarButton5";
            this.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // toolBarButton6
            // 
            this.toolBarButton6.ImageIndex = 10;
            this.toolBarButton6.Name = "toolBarButton6";
            this.toolBarButton6.ToolTipText = "Cut";
            // 
            // toolBarButton7
            // 
            this.toolBarButton7.ImageIndex = 11;
            this.toolBarButton7.Name = "toolBarButton7";
            this.toolBarButton7.ToolTipText = "Copy";
            // 
            // toolBarButton8
            // 
            this.toolBarButton8.ImageIndex = 12;
            this.toolBarButton8.Name = "toolBarButton8";
            this.toolBarButton8.ToolTipText = "Paste";
            // 
            // commandBarAddress
            // 
            this.commandBarAddress.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.commandBarAddress.Controls.Add(this.panel1);
            this.commandBarAddress.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.commandBarAddress.FloatModeWrapping = true;
            this.commandBarAddress.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.commandBarAddress.HideDropDownButton = true;
            this.commandBarAddress.MaxLength = 400;
            this.commandBarAddress.MinHeight = 26;
            this.commandBarAddress.MinLength = 50;
            this.commandBarAddress.Name = "commandBarAddress";
            this.commandBarAddress.PopupMenu = this.popupMenuAddress;
            this.commandBarAddress.RowIndex = 1;
            this.commandBarAddress.RowOffset = 0;
            this.commandBarAddress.TabIndex = 3;
            this.commandBarAddress.TabStop = false;
            this.commandBarAddress.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(55, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 24);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.Items.AddRange(new object[] {
            "www.syncfusion.com",
            "www.syncfusion.com/faq/winforms",
            "msdn.microsoft.com"});
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(343, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "www.syncfusion.com";
            // 
            // popupMenuAddress
            // 
            this.popupMenuAddress.ParentBarItem = this.parentBarItem1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biAddressHome,
            this.biAddressFAQ,
            this.biAddressSales,
            this.biAddressProducts});
            this.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue;
            this.parentBarItem1.ShowToolTipInPopUp = false;
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // biAddressHome
            // 
            this.biAddressHome.ID = "Syncfusion Home";
            this.biAddressHome.ImageIndex = 13;
            this.biAddressHome.ImageList = this.imageList1;
            this.biAddressHome.ShowToolTipInPopUp = false;
            this.biAddressHome.Text = "Syncfusion Home";
            this.biAddressHome.Click += new System.EventHandler(this.biAddress_Click);
            // 
            // biAddressFAQ
            // 
            this.biAddressFAQ.ID = "Windows Forms FAQ";
            this.biAddressFAQ.ImageIndex = 13;
            this.biAddressFAQ.ImageList = this.imageList1;
            this.biAddressFAQ.ShowToolTipInPopUp = false;
            this.biAddressFAQ.Text = "Windows Forms FAQ";
            this.biAddressFAQ.Click += new System.EventHandler(this.biAddress_Click);
            // 
            // biAddressSales
            // 
            this.biAddressSales.ID = "Syncfusion Sales";
            this.biAddressSales.ImageIndex = 13;
            this.biAddressSales.ImageList = this.imageList1;
            this.biAddressSales.ShowToolTipInPopUp = false;
            this.biAddressSales.Text = "Syncfusion Sales";
            this.biAddressSales.Click += new System.EventHandler(this.biAddress_Click);
            // 
            // biAddressProducts
            // 
            this.biAddressProducts.ID = "Syncfusion Products Page";
            this.biAddressProducts.ImageIndex = 13;
            this.biAddressProducts.ImageList = this.imageList1;
            this.biAddressProducts.ShowToolTipInPopUp = false;
            this.biAddressProducts.Text = "Syncfusion Products Page";
            this.biAddressProducts.Click += new System.EventHandler(this.biAddress_Click);
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemEdit,
            this.menuItemView,
            this.menuItemHelp});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemSave,
            this.menuItem8,
            this.menuItemExit});
            this.menuItemFile.Text = "&File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.Index = 0;
            this.menuItemNew.Text = "&New";
            this.menuItemNew.Click += new System.EventHandler(this.menuItemFile_Click);
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Index = 1;
            this.menuItemOpen.Text = "&Open";
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemFile_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Index = 2;
            this.menuItemSave.Text = "Save";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemFile_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 3;
            this.menuItem8.Text = "-";
            // 
            // menuItemExit
            // 
            this.menuItemExit.Index = 4;
            this.menuItemExit.Text = "&Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemFile_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.Index = 1;
            this.menuItemEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemCut,
            this.menuItemCopy,
            this.menuItemPaste});
            this.menuItemEdit.Text = "&Edit";
            // 
            // menuItemCut
            // 
            this.menuItemCut.Index = 0;
            this.menuItemCut.Text = "Cu&t";
            this.menuItemCut.Click += new System.EventHandler(this.menuItemEdit_Click);
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.Index = 1;
            this.menuItemCopy.Text = "&Copy";
            this.menuItemCopy.Click += new System.EventHandler(this.menuItemEdit_Click);
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.Index = 2;
            this.menuItemPaste.Text = "&Paste";
            this.menuItemPaste.Click += new System.EventHandler(this.menuItemEdit_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.Index = 2;
            this.menuItemView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemStandard,
            this.menuItemFonts,
            this.menuItemAlign,
            this.menuItemAddress});
            this.menuItemView.Text = "&View";
            this.menuItemView.Popup += new System.EventHandler(this.menuItemView_Popup);
            // 
            // menuItemStandard
            // 
            this.menuItemStandard.Index = 0;
            this.menuItemStandard.Text = "Standard";
            this.menuItemStandard.Click += new System.EventHandler(this.menuItemView_Click);
            // 
            // menuItemFonts
            // 
            this.menuItemFonts.Index = 1;
            this.menuItemFonts.Text = "Fonts";
            this.menuItemFonts.Click += new System.EventHandler(this.menuItemView_Click);
            // 
            // menuItemAlign
            // 
            this.menuItemAlign.Index = 2;
            this.menuItemAlign.Text = "Align";
            this.menuItemAlign.Click += new System.EventHandler(this.menuItemView_Click);
            // 
            // menuItemAddress
            // 
            this.menuItemAddress.Index = 3;
            this.menuItemAddress.Text = "Address";
            this.menuItemAddress.Click += new System.EventHandler(this.menuItemView_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 3;
            this.menuItemHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem13});
            this.menuItemHelp.Text = "&Help";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemEdit_Click);
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 0;
            this.menuItem13.Text = "About &Syncfusion";
            this.menuItem13.Click += new System.EventHandler(this.menuItem13_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 337);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(544, 24);
            this.statusBar1.TabIndex = 4;
            this.statusBar1.Text = "Ready";
            // 
            // wizardContainer1
            // 
            this.wizardContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardContainer1.Location = new System.Drawing.Point(0, 22);
            this.wizardContainer1.Name = "wizardContainer1";
            this.wizardContainer1.Size = new System.Drawing.Size(192, 263);
            this.wizardContainer1.TabIndex = 3;
            // 
            // AllowFloating
            // 
            this.AllowFloating.AutoSize = true;
            this.AllowFloating.BackColor = System.Drawing.Color.Transparent;
            this.AllowFloating.Location = new System.Drawing.Point(16, 183);
            this.AllowFloating.Name = "AllowFloating";
            this.AllowFloating.Size = new System.Drawing.Size(90, 17);
            this.AllowFloating.TabIndex = 13;
            this.AllowFloating.Text = "Allow Floating";
            this.AllowFloating.UseVisualStyleBackColor = false;
            this.AllowFloating.CheckedChanged += new System.EventHandler(this.AllowFloating_CheckedChanged);
            // 
            // AllowDocking
            // 
            this.AllowDocking.AutoSize = true;
            this.AllowDocking.BackColor = System.Drawing.Color.Transparent;
            this.AllowDocking.Checked = true;
            this.AllowDocking.Location = new System.Drawing.Point(16, 160);
            this.AllowDocking.Name = "AllowDocking";
            this.AllowDocking.Size = new System.Drawing.Size(93, 17);
            this.AllowDocking.TabIndex = 12;
            this.AllowDocking.TabStop = true;
            this.AllowDocking.Text = "Allow Docking";
            this.AllowDocking.UseVisualStyleBackColor = false;
            this.AllowDocking.CheckedChanged += new System.EventHandler(this.AllowDocking_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(16, 137);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(144, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Show Drop Down Button";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Style";
            // 
            // styleComboBox
            // 
            this.styleComboBox.DisplayMember = "Name";
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.Items.AddRange(new object[] {
            "Default",
            "OfficeXP",
            "Office2003"});
            this.styleComboBox.Location = new System.Drawing.Point(16, 86);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(160, 21);
            this.styleComboBox.TabIndex = 7;
            this.styleComboBox.ValueMember = "Name";
            this.styleComboBox.SelectedIndexChanged += new System.EventHandler(this.styleComboBox_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(16, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Chevron";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 96);
            this.label2.TabIndex = 2;
            this.label2.Text = "The Essential Tools Menus Package uses the CommandBars framework for creating the" +
                " XP menus and toolbars. ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "CommandBars implement the framework support that is required for creating Visual " +
                "Studio.NET type dockable/floatable menus and toolbars.";
            // 
            // DockedBarsForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "DockedBarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Command Bars ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).EndInit();
            this.commandBarFonts.ResumeLayout(false);
            this.pnlFonts.ResumeLayout(false);
            this.pnlFontsTB.ResumeLayout(false);
            this.pnlFontsTB.PerformLayout();
            this.commandBarAlign.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.commandBarStandard.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.commandBarAddress.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.Run(new DockedBarsForm());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.fontComboBox.DisplayMember = "Name";
            this.fontComboBox.ValueMember = "Name";
            this.fontComboBox.Items.AddRange(FontFamily.Families);
            this.fontComboBox.SelectedIndex = 2;

            this.fontSizeComboBox.SelectedIndex = 2;
            this.styleComboBox.Items.Clear();
            this.styleComboBox.DataSource = Enum.GetNames(typeof(VisualStyle));
            //this.styleComboBox.SelectedIndex = 2;

            this.initDone = true;
            this.UpdateFont();

            this.xpTaskPane1 = new Syncfusion.Windows.Forms.Tools.XPTaskPane();
            this.xpTaskPage2 = new Syncfusion.Windows.Forms.Tools.XPTaskPage();
            this.xpTaskPage1 = new Syncfusion.Windows.Forms.Tools.XPTaskPage();
            // 
            // xpTaskPane1
            // 
            this.xpTaskPane1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.xpTaskPane1.Controls.Add(this.wizardContainer1);
            this.xpTaskPane1.Dock = System.Windows.Forms.DockStyle.Right;
            // 
            // xpTaskPage2
            // 
            this.xpTaskPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.xpTaskPage2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(230))))), System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(206))))));
            this.xpTaskPage2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.xpTaskPage2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage2.Controls.Add(this.AllowFloating);
            this.xpTaskPage2.Controls.Add(this.AllowDocking);
            this.xpTaskPage2.Controls.Add(this.checkBox2);
            this.xpTaskPage2.Controls.Add(this.label3);
            this.xpTaskPage2.Controls.Add(this.styleComboBox);
            this.xpTaskPage2.Controls.Add(this.checkBox1);
            this.xpTaskPage2.LayoutName = "Card1";
            this.xpTaskPage2.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPage2.Name = "xpTaskPage2";
            this.xpTaskPage2.NextPage = null;
            this.xpTaskPage2.PreviousPage = null;
            this.xpTaskPage2.Size = new System.Drawing.Size(192, 263);
            this.xpTaskPage2.TabIndex = 1;
            this.xpTaskPage2.Title = "Properties";

            // 
            // xpTaskPage1
            // 
            this.xpTaskPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.xpTaskPage1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(236))))), System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(206))))));
            this.xpTaskPage1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.xpTaskPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage1.Controls.Add(this.pictureBox2);
            this.xpTaskPage1.Controls.Add(this.label2);
            this.xpTaskPage1.Controls.Add(this.pictureBox1);
            this.xpTaskPage1.Controls.Add(this.label1);
            this.xpTaskPage1.LayoutName = "Card2";
            this.xpTaskPage1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPage1.Name = "xpTaskPage1";
            this.xpTaskPage1.NextPage = null;
            this.xpTaskPage1.PreviousPage = null;
            this.xpTaskPage1.Size = new System.Drawing.Size(192, 263);
            this.xpTaskPage1.TabIndex = 0;
            this.xpTaskPage1.Title = "Info";

            this.xpTaskPane1.HeaderMenuItem.ImageIndex = 2;
            this.xpTaskPane1.HeaderMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.xpTaskPane1.Location = new System.Drawing.Point(352, 52);
            this.xpTaskPane1.Name = "xpTaskPane1";
            this.xpTaskPane1.SelectedPage = this.xpTaskPage2;
            this.xpTaskPane1.Size = new System.Drawing.Size(192, 285);
            this.xpTaskPane1.TabIndex = 5;
            this.xpTaskPane1.TaskPages = new Syncfusion.Windows.Forms.Tools.XPTaskPage[] {
        this.xpTaskPage2,
        this.xpTaskPage1};
            this.xpTaskPane1.TaskPanePageContainer = this.wizardContainer1;
            this.wizardContainer1.Controls.Add(this.xpTaskPage2);
            this.wizardContainer1.Controls.Add(this.xpTaskPage1);
            this.Controls.Add(this.xpTaskPane1);

            this.xpTaskPane1.Header.BackColor = Office2003Colors.MenuMarginColorDark;
            this.xpTaskPage1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.MenuMarginColorLight, Office2003Colors.MenuMarginColorDark);
            this.xpTaskPage2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.MenuMarginColorLight, Office2003Colors.MenuMarginColorDark);
            
        }

        private FontStyle curStyle = FontStyle.Regular;
        private HorizontalAlignment curAlignment = HorizontalAlignment.Left;
        private void fontComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!this.initDone)
                return;

            this.richTextBox1.Focus();
            this.UpdateFont();
        }

        private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            if (!this.initDone)
                return;

            //this.curStyle = FontStyle.Regular;
            if (e.Button == this.boldButton)
            {
                if (this.boldButton.Pushed)
                    this.curStyle = this.curStyle | FontStyle.Bold;
                else
                    this.curStyle -= FontStyle.Bold;
            }
            else if (e.Button == this.italicButton)
            {
                if (this.italicButton.Pushed)
                    this.curStyle = this.curStyle | FontStyle.Italic;
                else
                    this.curStyle -= FontStyle.Italic;
            }
            else if (e.Button == this.underLineButton)
            {
                if (this.underLineButton.Pushed)
                    this.curStyle = this.curStyle | FontStyle.Underline;
                else
                    this.curStyle -= FontStyle.Underline;
            }
            else if (e.Button == this.laButton)
            {
                if (this.laButton.Pushed)
                {
                    this.curAlignment = HorizontalAlignment.Left;
                    this.centerButton.Pushed = false;
                    this.raButton.Pushed = false;
                }
            }
            else if (e.Button == this.centerButton)
            {
                if (this.centerButton.Pushed)
                {
                    this.curAlignment = HorizontalAlignment.Center;
                    this.laButton.Pushed = false;
                    this.raButton.Pushed = false;
                }
            }
            else if (e.Button == this.raButton)
            {
                if (this.raButton.Pushed)
                {
                    this.curAlignment = HorizontalAlignment.Right;
                    this.laButton.Pushed = false;
                    this.centerButton.Pushed = false;
                }
            }
            this.richTextBox1.Focus();
            this.UpdateFont();
        }

        private void UpdateFont()
        {
            try
            {
                string family = this.fontComboBox.SelectedItem.ToString();
                family = family.Substring(family.IndexOf("=") + 1, family.IndexOf("]") - family.IndexOf("=") - 1);
                this.richTextBox1.SelectionFont = new Font(family, Int32.Parse(this.fontSizeComboBox.Text), this.curStyle);
                this.richTextBox1.SelectionAlignment = this.curAlignment;
            }
            catch { }
        }

        private void menuItemEdit_Click(object sender, System.EventArgs e)
        {
            MenuItem mnuitem = sender as MenuItem;
            if (mnuitem != null)
                this.HandleStandardCommands(mnuitem.Text);
        }

        private void menuItemFile_Click(object sender, System.EventArgs e)
        {
            MenuItem mnuitem = sender as MenuItem;
            if (mnuitem != null)
                this.HandleStandardCommands(mnuitem.Text);
        }

        private void tbStandard_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            this.HandleStandardCommands(e.Button.ToolTipText);
        }

        private void menuItemView_Click(object sender, System.EventArgs e)
        {
            MenuItem mnuitem = sender as MenuItem;
            switch (mnuitem.Text)
            {
                case "Address":
                    this.commandBarAddress.Visible = !this.menuItemAddress.Checked;
                    break;
                case "Align":
                    this.commandBarAlign.Visible = !this.menuItemAlign.Checked;
                    break;
                case "Fonts":
                    this.commandBarFonts.Visible = !this.menuItemFonts.Checked;
                    break;
                case "Standard":
                    this.commandBarStandard.Visible = !this.menuItemStandard.Checked;
                    break;
            }
        }

        private void HandleStandardCommands(String command)
        {
            int nindex = command.IndexOf('&');
            if (nindex >= 0)
                command = command.Remove(nindex, 1);
            switch (command)
            {
                case "New":
                    this.richTextBox1.Clear();
                    break;
                case "Open":
                    this.OpenDocument();
                    break;
                case "Save":
                    this.SaveDocument();
                    break;
                case "Exit":
                    this.Close();
                    break;
                case "Cut":
                    this.richTextBox1.Cut();
                    break;
                case "Copy":
                    this.richTextBox1.Copy();
                    break;
                case "Paste":
                    this.richTextBox1.Paste();
                    break;
            }
        }

        private void OpenDocument()
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                openFile1.FileName.Length > 0)
            {
                this.richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void SaveDocument()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                this.richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void menuItemView_Popup(object sender, System.EventArgs e)
        {
            this.menuItemAddress.Checked = this.commandBarAddress.Visible;
            this.menuItemAlign.Checked = this.commandBarAlign.Visible;
            this.menuItemFonts.Checked = this.commandBarFonts.Visible;
            this.menuItemStandard.Checked = this.commandBarStandard.Visible;
        }

        // Handler for the CommandBar.CommandBarStateChanging event.
        private void cbFonts_CommandBarStateChanging(object obj, Syncfusion.Windows.Forms.Tools.CommandBarStateChangingEventArgs arg)
        {
            // If the fonts CommandBar is being docked to a vertical dock position, ie., left or right, 
            // then hide the two combo boxes and set the commandbar maxlength to be equal to 
            // the length of the fonts toolbar.
            // NOTE - The CommandBar's dockstate will be set to CommandBarDockState.None when the CommandBar 
            // is in an indeterminate state. This happens only during loading and deserialization.
            Syncfusion.Windows.Forms.Tools.CommandBarDockState currentborder = this.commandBarFonts.DockState;
            Syncfusion.Windows.Forms.Tools.CommandBarDockState newborder = arg.NewDockState;
            if (((currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top) ||
                (currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Bottom) ||
                (currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float) ||
                (currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.None)) &&
                ((newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right)))
            {
                this.fontComboBox.Visible = false;
                this.fontSizeComboBox.Visible = false;
                this.commandBarFonts.MaxLength = this.commandBarFonts.CalcCommandBarMaxLength(this.szFontToolBarPanel.Width);
                // Move the panel containing the fonts toolbar to the (0,0) position of the commandbar panel.
                this.pnlFontsTB.Location = new Point(0, 0);
            }
            // If the Fonts CommandBar is being redocked / floated from the left or right borders, then 
            // increase the max length and restore combo box visibility.
            if (((currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (currentborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right)) &&
                ((newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top) ||
                (newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Bottom) ||
                (newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float) ||
                (newborder == Syncfusion.Windows.Forms.Tools.CommandBarDockState.None)))
            {
                this.commandBarFonts.MaxLength = this.commandBarFonts.CalcCommandBarMaxLength(this.szFontCommandBarPanelSize.Width);
                // Move the fonts toolbar panel to its original position ie., after the two combo boxes.
                this.pnlFontsTB.Location = new Point(this.fontSizeComboBox.Right + 6, 0);
                this.fontComboBox.Visible = true;
                this.fontSizeComboBox.Visible = true;
            }
        }

        // Handler for the CommandBar.CommandBarStateChanged event.
        private void cbFonts_CommandBarStateChanging(object sender, System.EventArgs e)
        {
            // The Fonts CommandBar client dimensions may have been changed by the redocking. 
            // Size the panel containing the Fonts toolbar to fit the new CommandBar panel dimensions.
            if (((this.commandBarFonts.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (this.commandBarFonts.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right))
                && (this.pnlFontsTB.Width > this.commandBarFonts.Width))
            {
                this.pnlFontsTB.Size = this.pnlFonts.Size;
            }
            else
            {
                // The CommandBar has been moved out of a left / right dock position.
                if (this.pnlFontsTB.Height > this.commandBarFonts.Height)
                {
                    this.pnlFontsTB.Size = this.szFontToolBarPanel;
                }
            }
        }

        private void biAddress_Click(object sender, System.EventArgs e)
        {
            Syncfusion.Windows.Forms.Tools.XPMenus.BarItem item = sender as Syncfusion.Windows.Forms.Tools.XPMenus.BarItem;
            this.comboBox1.Text = item.Tag as String;
        }

        private void commandBarStandard_Wrapping(object obj, Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventArgs arg)
        {
            // Apply the wrapping algorithm only when the CommandBar is floating.
            if (this.commandBarStandard.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float)
            {
                // szmaxwrap represents the tbStandard toolbar's dimensions in the maximum wrapped state. 
                // szwinwrap represents the tbStandard toolbar's dimensions in the minimum wrapped state.
                // These dimensions are determined at design time.
                Size szmaxwrap = new Size(40, 155);
                Size szminwrap = new Size(150, 23);
                this.DoToolBarWrapping(this.tbStandard, szmaxwrap, szminwrap, arg);
            }
            else if ((this.commandBarStandard.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (this.commandBarStandard.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right))
            {
                Size szmaxwrap = new Size(24, 155);
                arg.ClientSize = szmaxwrap;
            }
        }

        private void commandBarAlign_CommandBarWrapping(object obj, Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventArgs arg)
        {
            // Apply the wrapping algorithm only when the CommandBar is floating.
            if (this.commandBarAlign.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float)
            {
                Size szmaxwrap = new Size(40, 67);
                Size szminwrap = new Size(72, 23);
                this.DoToolBarWrapping(this.tbAlign, szmaxwrap, szminwrap, arg);
            }
            else if ((this.commandBarAlign.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) ||
                (this.commandBarAlign.DockState == Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right))
            {
                Size szmaxwrap = new Size(24, 67);
                arg.ClientSize = szmaxwrap;
            }
        }

        private void DoToolBarWrapping(ToolBar toolbar, Size szmaxwrap, Size szminwrap, Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventArgs arg)
        {
            Size szcurrent = arg.ClientSize;
            Size sztemp = toolbar.Size;

            int nbtncount = toolbar.Buttons.Count;
            Size szbtn = toolbar.ButtonSize;

            if ((arg.CommandBarResizeType == Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Right) || (arg.CommandBarResizeType == Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Left))
            {
                int nfactor = (int)Math.Ceiling((float)szminwrap.Width / (float)szcurrent.Width);
                float ffactor = (float)szminwrap.Width / (float)szcurrent.Width;

                if (szcurrent.Width < szmaxwrap.Width)
                {
                    arg.ClientSize = szmaxwrap;
                }
                else if ((nfactor > 1) && (nfactor == ffactor))
                {
                    int nnewwidth = (int)Math.Ceiling((float)nbtncount / (float)nfactor) * szbtn.Width;

                    Size sznew = Size.Empty;
                    if (nnewwidth > szmaxwrap.Width)
                    {
                        // Set this width to be the toolbar's parent panel width and allow the toolbar to 
                        // layout itself for this width. We then get the toolbar's height and assign this as 
                        // the CommandBar client size.
                        sznew.Width = nnewwidth;
                        toolbar.Parent.Width = sznew.Width;
                        sznew.Height = toolbar.Height;
                        toolbar.Parent.Width = sztemp.Width;
                    }
                    else
                        sznew = szmaxwrap;

                    // Set the CommandBar's client size to be equal to this new size.
                    arg.ClientSize = sznew;
                }
                else if (ffactor <= 1)
                {
                    // The CommandBar is extended to the maximum width.
                    arg.ClientSize = szminwrap;
                }
                else
                {
                    arg.ClientSize = toolbar.Size;
                }
            }
            else if ((arg.CommandBarResizeType == Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Bottom) || (arg.CommandBarResizeType == Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Top))
            {
                int nfactor = (int)Math.Floor((float)szcurrent.Height / (float)szbtn.Height);
                float ffactor = (float)szcurrent.Height / (float)szbtn.Height;

                if (szcurrent.Height > szmaxwrap.Height)
                {
                    arg.ClientSize = szmaxwrap;
                }
                else if ((nfactor > 1) && (nfactor == ffactor))
                {
                    // The toolbar width is estimated to be equal to the buttonwidth + the number of button columns reqd.
                    int nnewwidth = (int)Math.Ceiling((float)nbtncount / (float)nfactor) * szbtn.Width;

                    Size sznew = Size.Empty;
                    if (nnewwidth > szmaxwrap.Width)
                    {
                        // Assign the new width to the toolbar parent panel and get the corresponding 
                        // toolbar height.
                        sznew.Width = nnewwidth;
                        toolbar.Parent.Width = sznew.Width;
                        sznew.Height = toolbar.Height;
                        toolbar.Parent.Width = sztemp.Width;
                    }
                    else
                        sznew = szmaxwrap;

                    // Set the CommandBar's client size to be equal to this new size.
                    arg.ClientSize = sznew;
                }
                else if (ffactor <= 1)
                {
                    arg.ClientSize = szminwrap;
                }
                else
                {
                    arg.ClientSize = toolbar.Size;
                }
            }
        }

        #region AboutForm_Logic

        DemoCommon.AboutForm aboutForm = null;
        private void menuItem13_Click(object sender, System.EventArgs e)
        {
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
        }

        #endregion AboutForm_Logic

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
                bar.HideChevron = !this.checkBox1.Checked;
        }

        private void styleComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Syncfusion.Windows.Forms.VisualStyle vstyle = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            try
            {
                vstyle = (Syncfusion.Windows.Forms.VisualStyle)Enum.Parse(typeof(Syncfusion.Windows.Forms.VisualStyle), this.styleComboBox.Text);
            }
            catch
            {

            }
            this.commandBarController1.Style = vstyle;
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
                bar.Refresh();

        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
            {
                if (bar.Name != "commandBarStandard")
                {
                    bar.HideDropDownButton = !this.checkBox2.Checked;
                    this.commandBarController1.RecalcLayout(bar);
                }
            }

        }

        private void AllowFloating_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
            {
                if (bar.Visible)
                bar.DisableDocking = !this.AllowDocking.Checked;
            }
        }

        private void AllowDocking_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CommandBar bar in this.commandBarController1.CommandBars)
            {
                bar.DisableFloating = !this.AllowFloating.Checked;
            }

        }

        /*
        // This method is not used anywhere and is provided only to show how to 
        // programmatically initialize the CommandBars.
        // <samplecodeblock name="CommandBars">
        private void InitializeCommandBars()
        {	
            // Create the CommandBarController.
            this.commandBarController1 = new Syncfusion.Windows.Forms.Tools.CommandBarController();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).BeginInit();

            // Set the CommandBarController's host form.
            this.commandBarController1.HostForm = this;
            this.commandBarController1.PersistState = true;

            // Create the CommandBar control.
            this.commandBarAddress = new Syncfusion.Windows.Forms.Tools.CommandBar();

            // Set the CommandBar Layout/Behavior/Appearance attributes.
            this.commandBarAddress.DockBorder = Syncfusion.Windows.Forms.Tools.DockBorder.Top;
            this.commandBarAddress.HideDropDownButton = true;
            this.commandBarAddress.MaxLength = 400;
            this.commandBarAddress.MinHeight = 26;
            this.commandBarAddress.MinLength = 50;
            this.commandBarAddress.Name = "commandBarAddress";
            this.commandBarAddress.RowIndex = 1;
            this.commandBarAddress.RowOffset = 1;
            this.commandBarAddress.Text = "Address";

            // Create the Combo Box control and add it to the CommandBar's Controls collection.
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.commandBarAddress.Controls.AddRange(new System.Windows.Forms.Control[] {this.comboBox1});

            // Add the CommandBar to the CommandBarController.CommandBars collection.
            this.commandBarController1.CommandBars.Add(this.commandBarAddress);

            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).EndInit();
        }
        //</samplecodeblock>
        */

    }
}
