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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Tools;
using System.Resources;
using Syncfusion.Windows.Forms;
using System.Diagnostics;
using Syncfusion.Windows.Forms.Tools.Design;

namespace xptabs
{	
	public class TabControlAdvFrame : Office2007Form
    {
        #region Declaration
        private System.Windows.Forms.ImageList imageList;
        private Label label1;      
        private TabControlAdv FormTabControl;
        private TabPageAdv tab3;
        private TabPageAdv tab4;
        private TabPageAdv tab6;
        private Label label40;
        private TabControlAdv PrimitivesTabControl;
        private GradientPanel gradientPanel1;
        private Label label2;
        private TabControlAdv BehaviorTabControl;
        private TabPageAdv tabPageAdv3;
        private TabPageAdv tabPageAdv4;
        private TabPageAdv tabPageAdv5;
        private TabPageAdv tabPageAdv6;
        private TabPageAdv tabPageAdv7;
        private TabPageAdv tabPageAdv8;
        private Label label6;
        private Label label7;
        private Label label9;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private ToolTip toolTip1;
        private Label label11;
        private CheckBox checkBox7;
        private Label label13;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox14;
        private CheckBox checkBox13;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox17;
        private Label label5;
        private Label label14;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label18;
        private ColorDialog colorDialog1;
        private ButtonEdit activeTabColorEdit;
        private ButtonEditChildButton buttonEditChildButton1;
        private TextBoxExt textBoxExt1;
        private ButtonEdit panelColorEdit;
        private ButtonEditChildButton buttonEditChildButton4;
        private ButtonEdit borderColorEdit;
        private ButtonEditChildButton buttonEditChildButton3;
        private ButtonEdit inactiveTabColorEdit;
        private ButtonEditChildButton buttonEditChildButton2;
        private Label label19;
        private Label label20;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label24;
        private CheckBox checkBox24;
        private CheckBox checkBox23;
        private CheckBox checkBox22;
        private CheckBox checkBox21;
        private CheckBox checkBox20;
        private CheckBox checkBox19;
        private CheckBox checkBox18;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label25;
        private ComboBox comboBox1;
        private Label label30;
        private Label label29;
        private Label label28;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv2;
        private TabPageAdv tabPageAdv9;
        private TabPageAdv tabPageAdv10;
        private TabPageAdv tabPageAdv11;
        private ContextMenuStripEx contextMenuStripEx1;
        private ToolStripMenuItem addTabToolStripMenuItem;
        private CheckBox contextMenuCheck;
        private Label label4;
        private Point tabPoint;
        private CheckBox checkBox16;
        private Label label31;
        private TabPageAdv tabPageAdv12;
        private TabPageAdv tabPageAdv13;
        private Label label32;
        private Label label33;
        private Label label35;
        private Label label34;
        private Label label26;
        private Label label8;
        private Label label10;
        private ListBox listBox1;
        private Label label12;
        private Label label27;
        private Label label37;
        private CheckBox checkBox15;
        private CheckBox checkBox25;
		private System.ComponentModel.IContainer components;

        private TabPageAdv Appearance, Behavior, Tab_Primitives, tabPage1;
        private Label label36;
        private Label label38;
        private CheckBox checkBox26;
        private SuperToolTip superToolTip1;
        
#endregion-

        #region Form constructor, Main & Dispose
		public TabControlAdvFrame()
		{
			InitializeComponent();

            PopulateTabStyles();
            InitializeItems();

            

            foreach (TabPageAdv tp in BehaviorTabControl.TabPages)
            {
                tp.Closing += new TabPageAdvClosingEventHandler(tp_Closing);
                tp.Closed += new EventHandler(tp_Closed);
            }
            this.Load += new EventHandler(TabControlAdvFrame_Load);
		}

        void TabControlAdvFrame_Load(object sender, EventArgs e)
        {
            tab6.Image = Image.FromFile(@"../../../Data/appearance.gif");
            tab3.Image = Image.FromFile(@"../../../Data/behaviour.gif");
            tab4.Image = Image.FromFile(@"../../../Data/primitives.gif");
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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.Run(new TabControlAdvFrame());
        }
#endregion

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabControlAdvFrame));
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo3 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.FormTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.contextMenuStripEx1 = new Syncfusion.Windows.Forms.Tools.ContextMenuStripEx();
            this.addTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuCheck = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panelColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.borderColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.inactiveTabColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.activeTabColorEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tab3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.BehaviorTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv12 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv13 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv11 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv9 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv10 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv6 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv8 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.tab4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.PrimitivesTabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv7 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.label33 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.superToolTip1 = new Syncfusion.Windows.Forms.Tools.SuperToolTip(this);
            ((System.ComponentModel.ISupportInitialize)(this.FormTabControl)).BeginInit();
            this.FormTabControl.SuspendLayout();
            this.contextMenuStripEx1.SuspendLayout();
            this.tab6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColorEdit)).BeginInit();
            this.panelColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorEdit)).BeginInit();
            this.borderColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveTabColorEdit)).BeginInit();
            this.inactiveTabColorEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeTabColorEdit)).BeginInit();
            this.activeTabColorEdit.SuspendLayout();
            this.tab3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorTabControl)).BeginInit();
            this.BehaviorTabControl.SuspendLayout();
            this.tab4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrimitivesTabControl)).BeginInit();
            this.PrimitivesTabControl.SuspendLayout();
            this.tabPageAdv7.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "user_24.png");
            this.imageList.Images.SetKeyName(1, "clip_24.png");
            this.imageList.Images.SetKeyName(2, "sphere_24.png");
            this.imageList.Images.SetKeyName(3, "ellipse_24_hot.png");
            this.imageList.Images.SetKeyName(4, "mergedfield_icon_16.png");
            this.imageList.Images.SetKeyName(5, "group_icon_16.png");
            this.imageList.Images.SetKeyName(6, "primitives.gif");
            this.imageList.Images.SetKeyName(7, "apperance.gif");
            this.imageList.Images.SetKeyName(8, "behaviour.gif");
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(192, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "VS 2005 Style";
            // 
            // FormTabControl
            // 
            this.FormTabControl.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormTabControl.AdjustTopGap = 10;
            this.FormTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormTabControl.ContextMenuStrip = this.contextMenuStripEx1;
            this.FormTabControl.Controls.Add(this.tab6);
            this.FormTabControl.Controls.Add(this.tab3);
            this.FormTabControl.Controls.Add(this.tab4);
            this.FormTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.FormTabControl.FocusOnTabClick = false;
            this.FormTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTabControl.HotTrack = true;
            this.FormTabControl.ImageList = this.imageList;
            this.FormTabControl.ImageOffset = 10;
            this.FormTabControl.LevelTextAndImage = true;
            this.FormTabControl.Location = new System.Drawing.Point(12, 1);
            this.FormTabControl.Name = "FormTabControl";
            this.FormTabControl.ShowSuperToolTips = true;
            this.FormTabControl.ShowToolTips = true;
            this.FormTabControl.Size = new System.Drawing.Size(576, 448);
            this.FormTabControl.TabGap = 10;
            this.FormTabControl.TabIndex = 14;
            this.FormTabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.FormTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);
            this.FormTabControl.UserMoveTabs = true;
            this.FormTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormTabControl_MouseDown);
            // 
            // contextMenuStripEx1
            // 
            this.contextMenuStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTabToolStripMenuItem});
            this.contextMenuStripEx1.Name = "contextMenuStripEx1";
            this.contextMenuStripEx1.Size = new System.Drawing.Size(126, 51);
            this.contextMenuStripEx1.Text = "Options";
            this.contextMenuStripEx1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripEx1_Opening);
            // 
            // addTabToolStripMenuItem
            // 
            this.addTabToolStripMenuItem.Name = "addTabToolStripMenuItem";
            this.addTabToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.addTabToolStripMenuItem.Text = "Add Tab";
            this.addTabToolStripMenuItem.Click += new System.EventHandler(this.addTabToolStripMenuItem_Click);
            // 
            // tab6
            // 
            this.tab6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.tab6.Controls.Add(this.checkBox26);
            this.tab6.Controls.Add(this.label38);
            this.tab6.Controls.Add(this.label36);
            this.tab6.Controls.Add(this.label32);
            this.tab6.Controls.Add(this.checkBox16);
            this.tab6.Controls.Add(this.label31);
            this.tab6.Controls.Add(this.label4);
            this.tab6.Controls.Add(this.contextMenuCheck);
            this.tab6.Controls.Add(this.numericUpDown1);
            this.tab6.Controls.Add(this.label20);
            this.tab6.Controls.Add(this.label25);
            this.tab6.Controls.Add(this.comboBox1);
            this.tab6.Controls.Add(this.label30);
            this.tab6.Controls.Add(this.label29);
            this.tab6.Controls.Add(this.label28);
            this.tab6.Controls.Add(this.label14);
            this.tab6.Controls.Add(this.label7);
            this.tab6.Controls.Add(this.comboBox3);
            this.tab6.Controls.Add(this.comboBox2);
            this.tab6.Controls.Add(this.label24);
            this.tab6.Controls.Add(this.label23);
            this.tab6.Controls.Add(this.label22);
            this.tab6.Controls.Add(this.label21);
            this.tab6.Controls.Add(this.label19);
            this.tab6.Controls.Add(this.panelColorEdit);
            this.tab6.Controls.Add(this.borderColorEdit);
            this.tab6.Controls.Add(this.inactiveTabColorEdit);
            this.tab6.Controls.Add(this.activeTabColorEdit);
            this.tab6.Controls.Add(this.label17);
            this.tab6.Controls.Add(this.label16);
            this.tab6.Controls.Add(this.label18);
            this.tab6.Controls.Add(this.label15);
            this.tab6.Controls.Add(this.label5);
            this.tab6.Controls.Add(this.checkBox17);
            this.tab6.Controls.Add(this.checkBox14);
            this.tab6.Controls.Add(this.checkBox13);
            this.tab6.Controls.Add(this.checkBox12);
            this.tab6.Controls.Add(this.checkBox11);
            this.tab6.Controls.Add(this.checkBox10);
            this.tab6.Controls.Add(this.label6);
            this.tab6.Image = null;
            this.tab6.ImageIndex = 0;
            this.tab6.ImageSize = new System.Drawing.Size(16, 16);
            this.tab6.Location = new System.Drawing.Point(1, 43);
            this.tab6.Name = "tab6";
            this.tab6.Size = new System.Drawing.Size(574, 404);
            toolTipInfo1.Header.Text = "Appearance";
            this.tab6.SuperTooltip = toolTipInfo1;
            this.tab6.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tab6.TabIndex = 7;
            this.tab6.Text = "Appearance";
            this.tab6.ThemesEnabled = false;
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox26.Location = new System.Drawing.Point(374, 162);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(103, 32);
            this.checkBox26.TabIndex = 44;
            this.checkBox26.Tag = "outsidebounds";
            this.checkBox26.Text = "Show Animated\r\nTab Image";
            this.checkBox26.UseVisualStyleBackColor = true;
            this.checkBox26.CheckedChanged += new System.EventHandler(this.checkBox26_CheckedChanged);
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label38.Location = new System.Drawing.Point(87, 138);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(470, 1);
            this.label38.TabIndex = 43;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label36.Image = ((System.Drawing.Image)(resources.GetObject("label36.Image")));
            this.label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label36.Location = new System.Drawing.Point(18, 124);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(62, 24);
            this.label36.TabIndex = 42;
            this.label36.Text = "Image";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label32
            // 
            this.label32.Image = ((System.Drawing.Image)(resources.GetObject("label32.Image")));
            this.label32.Location = new System.Drawing.Point(449, 49);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(20, 20);
            this.label32.TabIndex = 41;
            this.toolTip1.SetToolTip(this.label32, "Will be shown if the no of tabs \r\nexceed control width. Add more \r\ntabs to see th" +
                    "e scrolls.");
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(212, 80);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(107, 17);
            this.checkBox16.TabIndex = 39;
            this.checkBox16.Tag = "persist";
            this.checkBox16.Text = "Persist Tab State";
            this.checkBox16.UseVisualStyleBackColor = true;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // label31
            // 
            this.label31.Image = ((System.Drawing.Image)(resources.GetObject("label31.Image")));
            this.label31.Location = new System.Drawing.Point(319, 80);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 20);
            this.label31.TabIndex = 40;
            this.toolTip1.SetToolTip(this.label31, "Persist the following:\r\n\r\nActive Tab\r\nTabOrder\r\nRenamed tab text");
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(183, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 38;
            this.toolTip1.SetToolTip(this.label4, "Right on Tabs to see \r\na context menu. It is \r\nset to show only  on \r\ntabs throug" +
                    "h code.");
            // 
            // contextMenuCheck
            // 
            this.contextMenuCheck.AutoSize = true;
            this.contextMenuCheck.Location = new System.Drawing.Point(25, 49);
            this.contextMenuCheck.Name = "contextMenuCheck";
            this.contextMenuCheck.Size = new System.Drawing.Size(160, 17);
            this.contextMenuCheck.TabIndex = 37;
            this.contextMenuCheck.Tag = "contextmenu";
            this.contextMenuCheck.Text = "Show Custom Context Menu";
            this.contextMenuCheck.UseVisualStyleBackColor = true;
            this.contextMenuCheck.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(418, 362);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 20);
            this.numericUpDown1.TabIndex = 36;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label20.Location = new System.Drawing.Point(371, 219);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(170, 1);
            this.label20.TabIndex = 22;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(304, 252);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 14);
            this.label25.TabIndex = 35;
            this.label25.Text = "Tab Style";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 200;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 14;
            this.comboBox1.Location = new System.Drawing.Point(418, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 22);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(304, 364);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(48, 14);
            this.label30.TabIndex = 33;
            this.label30.Text = "Tab Gap";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(304, 326);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(67, 14);
            this.label29.TabIndex = 32;
            this.label29.Text = "Border Style";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(304, 287);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(75, 14);
            this.label28.TabIndex = 31;
            this.label28.Text = "Tab Alignment";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label14.Location = new System.Drawing.Point(116, 220);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 1);
            this.label14.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label7.Location = new System.Drawing.Point(100, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(460, 1);
            this.label7.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(418, 323);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(131, 22);
            this.comboBox3.TabIndex = 29;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Top",
            "Left",
            "Bottom",
            "Right"});
            this.comboBox2.Location = new System.Drawing.Point(418, 283);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 22);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(317, 49);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 20);
            this.label24.TabIndex = 27;
            this.toolTip1.SetToolTip(this.label24, "Work only when 3D \r\nTabStyle is enabled.");
            // 
            // label23
            // 
            this.label23.Image = ((System.Drawing.Image)(resources.GetObject("label23.Image")));
            this.label23.Location = new System.Drawing.Point(245, 330);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 20);
            this.label23.TabIndex = 26;
            this.toolTip1.SetToolTip(this.label23, "BorderStyle should be set \r\nto Fixed Single");
            // 
            // label22
            // 
            this.label22.Image = ((System.Drawing.Image)(resources.GetObject("label22.Image")));
            this.label22.Location = new System.Drawing.Point(245, 287);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 20);
            this.label22.TabIndex = 25;
            this.toolTip1.SetToolTip(this.label22, "Work for 2D, 3D, WorkBook,\r\nOneNoteStyle, FlatTabs styles");
            // 
            // label21
            // 
            this.label21.Image = ((System.Drawing.Image)(resources.GetObject("label21.Image")));
            this.label21.Location = new System.Drawing.Point(245, 252);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 20);
            this.label21.TabIndex = 24;
            this.toolTip1.SetToolTip(this.label21, "Work for 2D, 3D, WorkBook,\r\nOneNoteStyle, FlatTabs styles");
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(304, 206);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 23);
            this.label19.TabIndex = 23;
            this.label19.Text = "Styles";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelColorEdit
            // 
            this.panelColorEdit.Buttons.Add(this.buttonEditChildButton4);
            this.panelColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.panelColorEdit.Controls.Add(this.buttonEditChildButton4);
            this.panelColorEdit.Controls.Add(this.textBoxExt1);
            this.panelColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.panelColorEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelColorEdit.Location = new System.Drawing.Point(123, 362);
            this.panelColorEdit.Name = "panelColorEdit";
            this.panelColorEdit.ShowTextBox = false;
            this.panelColorEdit.Size = new System.Drawing.Size(121, 26);
            this.panelColorEdit.TabIndex = 21;
            this.panelColorEdit.TextBox = this.textBoxExt1;
            this.panelColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.panelColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton4.Image = null;
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 20;
            this.buttonEditChildButton4.TabIndex = 1;
            this.buttonEditChildButton4.Text = "...";
            this.buttonEditChildButton4.UseVisualStyleBackColor = true;
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.Location = new System.Drawing.Point(3, 3);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(95, 20);
            this.textBoxExt1.TabIndex = 0;
            // 
            // borderColorEdit
            // 
            this.borderColorEdit.Buttons.Add(this.buttonEditChildButton3);
            this.borderColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.borderColorEdit.Controls.Add(this.buttonEditChildButton3);
            this.borderColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.borderColorEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borderColorEdit.Location = new System.Drawing.Point(123, 324);
            this.borderColorEdit.Name = "borderColorEdit";
            this.borderColorEdit.ShowTextBox = false;
            this.borderColorEdit.Size = new System.Drawing.Size(121, 26);
            this.borderColorEdit.TabIndex = 20;
            this.borderColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.borderColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton3.Image = null;
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 20;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Text = "...";
            this.buttonEditChildButton3.UseVisualStyleBackColor = true;
            // 
            // inactiveTabColorEdit
            // 
            this.inactiveTabColorEdit.Buttons.Add(this.buttonEditChildButton2);
            this.inactiveTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.inactiveTabColorEdit.Controls.Add(this.buttonEditChildButton2);
            this.inactiveTabColorEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inactiveTabColorEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inactiveTabColorEdit.Location = new System.Drawing.Point(123, 285);
            this.inactiveTabColorEdit.Name = "inactiveTabColorEdit";
            this.inactiveTabColorEdit.ShowTextBox = false;
            this.inactiveTabColorEdit.Size = new System.Drawing.Size(121, 26);
            this.inactiveTabColorEdit.TabIndex = 19;
            this.inactiveTabColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.inactiveTabColorEdit_ButtonClicked);
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton2.Image = null;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 20;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "...";
            this.buttonEditChildButton2.UseVisualStyleBackColor = true;
            // 
            // activeTabColorEdit
            // 
            this.activeTabColorEdit.Buttons.Add(this.buttonEditChildButton1);
            this.activeTabColorEdit.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.activeTabColorEdit.Controls.Add(this.buttonEditChildButton1);
            this.activeTabColorEdit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeTabColorEdit.Location = new System.Drawing.Point(123, 248);
            this.activeTabColorEdit.Name = "activeTabColorEdit";
            this.activeTabColorEdit.ShowTextBox = false;
            this.activeTabColorEdit.Size = new System.Drawing.Size(121, 26);
            this.activeTabColorEdit.TabIndex = 18;
            this.activeTabColorEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            this.buttonEditChildButton1.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 363);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 14);
            this.label17.TabIndex = 17;
            this.label17.Text = "Tab Panel Back Color";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 324);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 14);
            this.label16.TabIndex = 16;
            this.label16.Text = "Border Color";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 14);
            this.label18.TabIndex = 15;
            this.label18.Text = "Inactive Tab Color";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 14);
            this.label15.TabIndex = 15;
            this.label15.Text = "Active Tab Color";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(8, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Color Options";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Checked = true;
            this.checkBox17.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox17.Location = new System.Drawing.Point(25, 162);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(94, 32);
            this.checkBox17.TabIndex = 12;
            this.checkBox17.Tag = "outsidebounds";
            this.checkBox17.Text = "Image Outside\r\nTab Bounds";
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox14.Location = new System.Drawing.Point(212, 50);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(99, 18);
            this.checkBox14.TabIndex = 9;
            this.checkBox14.Tag = "themes";
            this.checkBox14.Text = "Enable Themes";
            this.checkBox14.UseVisualStyleBackColor = true;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.Checked = true;
            this.checkBox13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox13.Location = new System.Drawing.Point(364, 43);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(87, 32);
            this.checkBox13.TabIndex = 8;
            this.checkBox13.Tag = "scrolls";
            this.checkBox13.Text = "Show Scroll";
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox12.Location = new System.Drawing.Point(25, 84);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(152, 18);
            this.checkBox12.TabIndex = 7;
            this.checkBox12.Tag = "rotatetext";
            this.checkBox12.Text = "Rotate Text When Vertical";
            this.checkBox12.UseVisualStyleBackColor = true;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox11.Location = new System.Drawing.Point(284, 162);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(72, 32);
            this.checkBox11.TabIndex = 6;
            this.checkBox11.Tag = "imagealign";
            this.checkBox11.Text = "Image \r\nLeft Align";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox10.Location = new System.Drawing.Point(141, 162);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(101, 32);
            this.checkBox10.TabIndex = 5;
            this.checkBox10.Tag = "inactiveimage";
            this.checkBox10.Text = "Disable Inactive\r\nPage Image";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.Properties_CheckChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Properties";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab3
            // 
            this.tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.tab3.Controls.Add(this.label3);
            this.tab3.Controls.Add(this.label37);
            this.tab3.Controls.Add(this.checkBox15);
            this.tab3.Controls.Add(this.checkBox25);
            this.tab3.Controls.Add(this.checkBox21);
            this.tab3.Controls.Add(this.label12);
            this.tab3.Controls.Add(this.label27);
            this.tab3.Controls.Add(this.checkBox24);
            this.tab3.Controls.Add(this.listBox1);
            this.tab3.Controls.Add(this.checkBox23);
            this.tab3.Controls.Add(this.BehaviorTabControl);
            this.tab3.Controls.Add(this.checkBox22);
            this.tab3.Controls.Add(this.label8);
            this.tab3.Controls.Add(this.checkBox20);
            this.tab3.Controls.Add(this.label10);
            this.tab3.Controls.Add(this.checkBox19);
            this.tab3.Controls.Add(this.checkBox18);
            this.tab3.Image = null;
            this.tab3.ImageIndex = 1;
            this.tab3.ImageSize = new System.Drawing.Size(16, 16);
            this.tab3.Location = new System.Drawing.Point(1, 43);
            this.tab3.Name = "tab3";
            this.tab3.Size = new System.Drawing.Size(574, 404);
            toolTipInfo2.Header.Text = "Behavior Tab";
            this.tab3.SuperTooltip = toolTipInfo2;
            this.tab3.TabIndex = 4;
            this.tab3.Text = "Behavior";
            this.tab3.ThemesEnabled = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(348, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 28;
            this.toolTip1.SetToolTip(this.label3, "Multiline should be true.");
            // 
            // label37
            // 
            this.label37.Image = ((System.Drawing.Image)(resources.GetObject("label37.Image")));
            this.label37.Location = new System.Drawing.Point(473, 154);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(20, 20);
            this.label37.TabIndex = 47;
            this.toolTip1.SetToolTip(this.label37, "Applicable when the TabCloseButton is shown");
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox15.Location = new System.Drawing.Point(373, 148);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(105, 32);
            this.checkBox15.TabIndex = 46;
            this.checkBox15.Tag = "outsidebounds";
            this.checkBox15.Text = "TabCloseButton \r\nfor Active Tab";
            this.checkBox15.UseVisualStyleBackColor = true;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Checked = true;
            this.checkBox25.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox25.Location = new System.Drawing.Point(373, 118);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(140, 18);
            this.checkBox25.TabIndex = 48;
            this.checkBox25.Tag = "themes";
            this.checkBox25.Text = "Show Tab Close Button";
            this.checkBox25.UseVisualStyleBackColor = true;
            this.checkBox25.CheckedChanged += new System.EventHandler(this.checkBox25_CheckedChanged);
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Checked = true;
            this.checkBox21.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox21.Location = new System.Drawing.Point(242, 148);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(109, 32);
            this.checkBox21.TabIndex = 13;
            this.checkBox21.Tag = "frontrow";
            this.checkBox21.Text = "Keep Selected \r\nTab In Front Row";
            this.checkBox21.UseVisualStyleBackColor = true;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.label12.Location = new System.Drawing.Point(98, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(450, 1);
            this.label12.TabIndex = 33;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(18, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 24);
            this.label27.TabIndex = 34;
            this.label27.Text = "Behavior";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox24.Location = new System.Drawing.Point(499, 155);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(72, 18);
            this.checkBox24.TabIndex = 16;
            this.checkBox24.Tag = "labeledit";
            this.checkBox24.Text = "Label Edit";
            this.checkBox24.UseVisualStyleBackColor = true;
            this.checkBox24.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(522, 108);
            this.listBox1.TabIndex = 32;
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox23.Location = new System.Drawing.Point(149, 155);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(79, 18);
            this.checkBox23.TabIndex = 15;
            this.checkBox23.Tag = "movetabs";
            this.checkBox23.Text = "Move Tabs";
            this.checkBox23.UseVisualStyleBackColor = true;
            this.checkBox23.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // BehaviorTabControl
            // 
            this.BehaviorTabControl.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.BehaviorTabControl.BackColor = System.Drawing.SystemColors.Control;
            this.BehaviorTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BehaviorTabControl.BorderVisible = true;
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv5);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv12);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv13);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv1);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv11);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv2);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv9);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv10);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv6);
            this.BehaviorTabControl.Controls.Add(this.tabPageAdv8);
            this.BehaviorTabControl.FocusOnTabClick = false;
            this.BehaviorTabControl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BehaviorTabControl.HotTrack = true;
            this.BehaviorTabControl.InactiveTabColor = System.Drawing.Color.White;
            this.BehaviorTabControl.Location = new System.Drawing.Point(21, 40);
            this.BehaviorTabControl.Name = "BehaviorTabControl";
            this.BehaviorTabControl.ShowTabCloseButton = true;
            this.BehaviorTabControl.ShowToolTips = true;
            this.BehaviorTabControl.Size = new System.Drawing.Size(522, 69);
            this.BehaviorTabControl.TabIndex = 3;
            this.BehaviorTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererVS2008);
            this.BehaviorTabControl.VSLikeScrollButton = true;
            this.BehaviorTabControl.SelectedIndexChanged += new System.EventHandler(this.BehaviorTabControl_SelectedIndexChanged);
            this.BehaviorTabControl.LabelEditChanged += new System.EventHandler(this.BehaviorTabControl_LabelEditChanged);
            this.BehaviorTabControl.BeforeEdit += new Syncfusion.Windows.Forms.Tools.EditEventHandler(this.BehaviorTabControl_BeforeEdit);
            this.BehaviorTabControl.LabelEditTextChanged += new System.EventHandler(this.BehaviorTabControl_LabelEditTextChanged);
            this.BehaviorTabControl.AfterEdit += new Syncfusion.Windows.Forms.Tools.EditEventHandler(this.BehaviorTabControl_AfterEdit);
            this.BehaviorTabControl.SelectedIndexChanging += new Syncfusion.Windows.Forms.Tools.SelectedIndexChangingEventHandler(this.BehaviorTabControl_SelectedIndexChanging);
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv5.TabIndex = 1;
            this.tabPageAdv5.Text = "Home Page";
            this.tabPageAdv5.ThemesEnabled = false;
            this.tabPageAdv5.ToolTipText = "Home Page";
            // 
            // tabPageAdv12
            // 
            this.tabPageAdv12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv12.Image = null;
            this.tabPageAdv12.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv12.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv12.Name = "tabPageAdv12";
            this.tabPageAdv12.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv12.TabIndex = 8;
            this.tabPageAdv12.Text = "Remote";
            this.tabPageAdv12.ThemesEnabled = false;
            this.tabPageAdv12.ToolTipText = "Remote";
            // 
            // tabPageAdv13
            // 
            this.tabPageAdv13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv13.Image = null;
            this.tabPageAdv13.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv13.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv13.Name = "tabPageAdv13";
            this.tabPageAdv13.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv13.TabIndex = 9;
            this.tabPageAdv13.Text = "Updates";
            this.tabPageAdv13.ThemesEnabled = false;
            this.tabPageAdv13.ToolTipText = "Updates";
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv1.TabIndex = 3;
            this.tabPageAdv1.Text = "Options";
            this.tabPageAdv1.ThemesEnabled = false;
            this.tabPageAdv1.ToolTipText = "Options";
            // 
            // tabPageAdv11
            // 
            this.tabPageAdv11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv11.Image = null;
            this.tabPageAdv11.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv11.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv11.Name = "tabPageAdv11";
            this.tabPageAdv11.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv11.TabIndex = 7;
            this.tabPageAdv11.Text = "More Options..";
            this.tabPageAdv11.ThemesEnabled = false;
            this.tabPageAdv11.ToolTipText = "More Options..";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv2.Image = null;
            this.tabPageAdv2.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv2.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv2.TabIndex = 4;
            this.tabPageAdv2.Text = "Format Text";
            this.tabPageAdv2.ThemesEnabled = false;
            this.tabPageAdv2.ToolTipText = "Format Text";
            // 
            // tabPageAdv9
            // 
            this.tabPageAdv9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv9.Image = null;
            this.tabPageAdv9.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv9.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv9.Name = "tabPageAdv9";
            this.tabPageAdv9.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv9.TabIndex = 5;
            this.tabPageAdv9.Text = "Message";
            this.tabPageAdv9.ThemesEnabled = false;
            this.tabPageAdv9.ToolTipText = "Message";
            // 
            // tabPageAdv10
            // 
            this.tabPageAdv10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv10.Image = null;
            this.tabPageAdv10.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv10.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv10.Name = "tabPageAdv10";
            this.tabPageAdv10.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv10.TabIndex = 6;
            this.tabPageAdv10.Text = "Find and Replace";
            this.tabPageAdv10.ThemesEnabled = false;
            this.tabPageAdv10.ToolTipText = "Find and Replace";
            // 
            // tabPageAdv6
            // 
            this.tabPageAdv6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv6.Image = null;
            this.tabPageAdv6.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv6.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv6.Name = "tabPageAdv6";
            this.tabPageAdv6.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv6.TabIndex = 1;
            this.tabPageAdv6.Text = "Insert Item";
            this.tabPageAdv6.ThemesEnabled = false;
            this.tabPageAdv6.ToolTipText = "Insert Item";
            // 
            // tabPageAdv8
            // 
            this.tabPageAdv8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabPageAdv8.Image = null;
            this.tabPageAdv8.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv8.Location = new System.Drawing.Point(5, 32);
            this.tabPageAdv8.Name = "tabPageAdv8";
            this.tabPageAdv8.Size = new System.Drawing.Size(512, 32);
            this.tabPageAdv8.TabIndex = 2;
            this.tabPageAdv8.Text = "View Tabs";
            this.tabPageAdv8.ThemesEnabled = false;
            this.tabPageAdv8.ToolTipText = "View Tabs";
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Checked = true;
            this.checkBox22.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox22.Location = new System.Drawing.Point(29, 155);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(98, 18);
            this.checkBox22.TabIndex = 14;
            this.checkBox22.Tag = "tooltips";
            this.checkBox22.Text = "Show ToolTips";
            this.checkBox22.UseVisualStyleBackColor = true;
            this.checkBox22.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.label8.Location = new System.Drawing.Point(93, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(450, 1);
            this.label8.TabIndex = 30;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox20.Location = new System.Drawing.Point(242, 118);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(63, 18);
            this.checkBox20.TabIndex = 12;
            this.checkBox20.Tag = "multiline";
            this.checkBox20.Text = "Multiline";
            this.checkBox20.UseVisualStyleBackColor = true;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(19, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 24);
            this.label10.TabIndex = 31;
            this.label10.Text = "Events";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Checked = true;
            this.checkBox19.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox19.Location = new System.Drawing.Point(149, 118);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(72, 18);
            this.checkBox19.TabIndex = 11;
            this.checkBox19.Tag = "hottrack";
            this.checkBox19.Text = "Hot Track";
            this.checkBox19.UseVisualStyleBackColor = true;
            this.checkBox19.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox18.Location = new System.Drawing.Point(29, 118);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(92, 18);
            this.checkBox18.TabIndex = 10;
            this.checkBox18.Tag = "focus";
            this.checkBox18.Text = "Focus on Tab";
            this.checkBox18.UseVisualStyleBackColor = true;
            this.checkBox18.CheckedChanged += new System.EventHandler(this.Behavior_CheckChanged);
            // 
            // tab4
            // 
            this.tab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.tab4.Controls.Add(this.gradientPanel1);
            this.tab4.Controls.Add(this.PrimitivesTabControl);
            this.tab4.Image = null;
            this.tab4.ImageIndex = 2;
            this.tab4.ImageSize = new System.Drawing.Size(16, 16);
            this.tab4.Location = new System.Drawing.Point(1, 43);
            this.tab4.Name = "tab4";
            this.tab4.Size = new System.Drawing.Size(574, 404);
            toolTipInfo3.Header.Text = "Tab Primitives";
            this.tab4.SuperTooltip = toolTipInfo3;
            this.tab4.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tab4.TabIndex = 6;
            this.tab4.Text = "Tab Primitives";
            this.tab4.ThemesEnabled = false;
            tab4.ImageSize = new Size(15, 15);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label40);
            this.gradientPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(17, 17);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(540, 49);
            this.gradientPanel1.TabIndex = 2;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label40.Image = ((System.Drawing.Image)(resources.GetObject("label40.Image")));
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(0, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(538, 47);
            this.label40.TabIndex = 1;
            this.label40.Text = resources.GetString("label40.Text");
            // 
            // PrimitivesTabControl
            // 
            this.PrimitivesTabControl.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.PrimitivesTabControl.BackColor = System.Drawing.SystemColors.Control;
            this.PrimitivesTabControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv7);
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv3);
            this.PrimitivesTabControl.Controls.Add(this.tabPageAdv4);
            this.PrimitivesTabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(161)))));
            this.PrimitivesTabControl.FocusOnTabClick = false;
            this.PrimitivesTabControl.Location = new System.Drawing.Point(15, 92);
            this.PrimitivesTabControl.Name = "PrimitivesTabControl";
            this.PrimitivesTabControl.ShowScroll = false;
            this.PrimitivesTabControl.ShowToolTips = true;
            this.PrimitivesTabControl.Size = new System.Drawing.Size(542, 213);
            this.PrimitivesTabControl.TabIndex = 0;
            this.PrimitivesTabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.Custom, ((System.Drawing.Image)(resources.GetObject("PrimitivesTabControl.TabPrimitivesHost.TabPrimitives"))), System.Drawing.Color.Empty, false, 1, "AddTab", "AddTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.FirstTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive0", "FirstTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.PreviousPage, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive1", "PreviousPage"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.PreviousTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive2", "PreviousTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.NextTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive3", "NextTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.NextPage, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive4", "NextPage"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.LastTab, null, System.Drawing.Color.Empty, true, 1, "TabPrimitive5", "LastTab"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.DropDown, null, System.Drawing.Color.Empty, false, 1, "TabPrimitive6", "DropDown"));
            this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives.Add(new Syncfusion.Windows.Forms.Tools.TabPrimitive(Syncfusion.Windows.Forms.Tools.TabPrimitiveType.Close, null, System.Drawing.Color.Empty, false, 1, "TabPrimitive7", "Close"));
            this.PrimitivesTabControl.TabPrimitivesHost.Visible = true;
            this.PrimitivesTabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererIE7);
            this.PrimitivesTabControl.TabPrimitiveClick += new Syncfusion.Windows.Forms.Tools.TabPrimitiveClick(this.PrimitivesTabControl_TabPrimitiveClick);
            // 
            // tabPageAdv7
            // 
            this.tabPageAdv7.Controls.Add(this.label35);
            this.tabPageAdv7.Controls.Add(this.label34);
            this.tabPageAdv7.Controls.Add(this.label26);
            this.tabPageAdv7.Controls.Add(this.label11);
            this.tabPageAdv7.Controls.Add(this.label13);
            this.tabPageAdv7.Controls.Add(this.label9);
            this.tabPageAdv7.Controls.Add(this.checkBox9);
            this.tabPageAdv7.Controls.Add(this.checkBox8);
            this.tabPageAdv7.Controls.Add(this.checkBox7);
            this.tabPageAdv7.Controls.Add(this.checkBox6);
            this.tabPageAdv7.Controls.Add(this.checkBox5);
            this.tabPageAdv7.Controls.Add(this.checkBox4);
            this.tabPageAdv7.Controls.Add(this.checkBox3);
            this.tabPageAdv7.Controls.Add(this.checkBox2);
            this.tabPageAdv7.Controls.Add(this.checkBox1);
            this.tabPageAdv7.Image = null;
            this.tabPageAdv7.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv7.Location = new System.Drawing.Point(1, 33);
            this.tabPageAdv7.Name = "tabPageAdv7";
            this.tabPageAdv7.Size = new System.Drawing.Size(540, 179);
            this.tabPageAdv7.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageAdv7.TabIndex = 1;
            this.tabPageAdv7.Text = "Primitives Options";
            this.tabPageAdv7.ThemesEnabled = false;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label35.Image = ((System.Drawing.Image)(resources.GetObject("label35.Image")));
            this.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label35.Location = new System.Drawing.Point(291, 98);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(133, 24);
            this.label35.TabIndex = 17;
            this.label35.Text = "Custom Primitives";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label34.Image = ((System.Drawing.Image)(resources.GetObject("label34.Image")));
            this.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label34.Location = new System.Drawing.Point(13, 98);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 24);
            this.label34.TabIndex = 16;
            this.label34.Text = "More Options";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label26.Image = ((System.Drawing.Image)(resources.GetObject("label26.Image")));
            this.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label26.Location = new System.Drawing.Point(13, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 24);
            this.label26.TabIndex = 15;
            this.label26.Text = "Visibility";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label11.Location = new System.Drawing.Point(428, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 1);
            this.label11.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label13.Location = new System.Drawing.Point(115, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 1);
            this.label13.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label9.Location = new System.Drawing.Point(92, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(430, 1);
            this.label9.TabIndex = 7;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox9.Location = new System.Drawing.Point(142, 139);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(118, 18);
            this.checkBox9.TabIndex = 12;
            this.checkBox9.Text = "Show Close button";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox8.Location = new System.Drawing.Point(26, 139);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(110, 18);
            this.checkBox8.TabIndex = 12;
            this.checkBox8.Text = "Show DropDown";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(304, 139);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(136, 18);
            this.checkBox7.TabIndex = 9;
            this.checkBox7.Text = "Show Custom Primitive";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(294, 55);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(69, 18);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "Next Tab";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(26, 55);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(68, 18);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "First Tab";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(369, 55);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 18);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Next Page";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(100, 55);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 18);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Previous Page";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(449, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 18);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Last Tab";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(202, 55);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 18);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Previous Tab";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.Image = null;
            this.tabPageAdv3.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 33);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.Size = new System.Drawing.Size(540, 179);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.Text = "TabPage 1";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(1, 33);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.Size = new System.Drawing.Size(540, 179);
            this.tabPageAdv4.TabIndex = 3;
            this.tabPageAdv4.Text = "Tab Page 2";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(82)))));
            this.label33.Image = ((System.Drawing.Image)(resources.GetObject("label33.Image")));
            this.label33.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label33.Location = new System.Drawing.Point(12, 54);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(81, 24);
            this.label33.TabIndex = 29;
            this.label33.Text = "Behavior";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(126, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 1);
            this.label2.TabIndex = 0;
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.SystemColors.Window;
            // 
            // TabControlAdvFrame
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(598, 461);
            this.Controls.Add(this.FormTabControl);
            this.Controls.Add(this.label33);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "TabControlAdvFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabControlAdv ";
            this.UseOffice2007SchemeBackColor = true;
            ((System.ComponentModel.ISupportInitialize)(this.FormTabControl)).EndInit();
            this.FormTabControl.ResumeLayout(false);
            this.contextMenuStripEx1.ResumeLayout(false);
            this.tab6.ResumeLayout(false);
            this.tab6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelColorEdit)).EndInit();
            this.panelColorEdit.ResumeLayout(false);
            this.panelColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderColorEdit)).EndInit();
            this.borderColorEdit.ResumeLayout(false);
            this.borderColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inactiveTabColorEdit)).EndInit();
            this.inactiveTabColorEdit.ResumeLayout(false);
            this.inactiveTabColorEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activeTabColorEdit)).EndInit();
            this.activeTabColorEdit.ResumeLayout(false);
            this.activeTabColorEdit.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.tab3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BehaviorTabControl)).EndInit();
            this.BehaviorTabControl.ResumeLayout(false);
            this.tab4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PrimitivesTabControl)).EndInit();
            this.PrimitivesTabControl.ResumeLayout(false);
            this.tabPageAdv7.ResumeLayout(false);
            this.tabPageAdv7.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        #region TabControl Events
        void tp_Closing(object sender, TabPageAdvClosingEventArgs args)
        {
            if (MessageBox.Show("Are you sure want to close the " + args.TabPageAdv.Text + " tab?", "Closing tab...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                tabPage1 = args.TabPageAdv;
                args.Cancel = false;
                EventsList("TabPage Closing: " + tabPage1.Text);
            }
            else
                args.Cancel = true;
        }

        void tp_Closed(object sender, EventArgs e)
        {
            EventsList("TabPage Closed: " + tabPage1.Text);
        }

        #endregion

        #region Helper Methods
        private void InitializeItems()
        {
            this.comboBox1.SelectedIndex = 9;
            this.comboBox2.SelectedIndex = 0;
            
            foreach(String str in Enum.GetNames(typeof(System.Windows.Forms.BorderStyle)))
                this.comboBox3.Items.Add(str);
            this.comboBox3.SelectedIndex = 1;

            for (int tabcount = 3; tabcount < 10; tabcount++)
            {
                TabPageAdv tabPage = new TabPageAdv("Tab Page " + tabcount.ToString());
                PrimitivesTabControl.TabPages.Add(tabPage);
            }

            Appearance = FormTabControl.TabPages[0];
            Behavior = FormTabControl.TabPages[1];
            Tab_Primitives = FormTabControl.TabPages[2];
        }

        private void PopulateTabStyles()
        {
            this.comboBox1.Items.Add("TabRenderer3D");
            this.comboBox1.Items.Add("TabRenderer2D");
            this.comboBox1.Items.Add("Workbook");
            this.comboBox1.Items.Add("OneNoteStyle");
            this.comboBox1.Items.Add("OneNoteStyleFlatTabs");
            this.comboBox1.Items.Add("Office2003");
            this.comboBox1.Items.Add("Whidbey");
            this.comboBox1.Items.Add("DockingWhidbey");
            this.comboBox1.Items.Add("DockingWhidbeyBeta");
            this.comboBox1.Items.Add("Office2007Blue");
            this.comboBox1.Items.Add("Office2007Black");
            this.comboBox1.Items.Add("Office2007Silver");
            this.comboBox1.Items.Add("Office2007Managed");
            this.comboBox1.Items.Add("InternetExplorer7");
            this.comboBox1.Items.Add("TabRendererVS2008");
            this.comboBox1.Items.Add("TabRendererBlendDark");
            this.comboBox1.Items.Add("TabRendererBlendLight");
            this.comboBox1.Items.Add("TabRendererVS2010");
        } 
        #endregion
      
        #region Color Options
        private void buttonEdit1_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                activeTabColorEdit.BackColor = colorDialog1.Color;
                FormTabControl.ActiveTabColor = colorDialog1.Color;
            }
        }

        private void inactiveTabColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                inactiveTabColorEdit.BackColor = colorDialog1.Color;
                FormTabControl.InactiveTabColor = colorDialog1.Color;
            }
        }

        private void borderColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                borderColorEdit.BackColor = colorDialog1.Color;
                FormTabControl.FixedSingleBorderColor = colorDialog1.Color;
            }
        }

        private void panelColorEdit_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panelColorEdit.BackColor = colorDialog1.Color;
                FormTabControl.TabPanelBackColor = colorDialog1.Color;
            }
        }

        #endregion

        #region Primitives
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            switch (checkBox.Text)
            {
                case "First Tab":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[1].Visible = this.checkBox5.Checked;
                    break;
                case "Previous Page":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[2].Visible = this.checkBox3.Checked;
                    break;
                case "Previous Tab":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[3].Visible = this.checkBox1.Checked;
                    break;
                case "Next Tab":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[4].Visible = this.checkBox6.Checked;
                    break;
                case "Next Page":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[5].Visible = this.checkBox4.Checked;
                    break;
                case "Last Tab":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[6].Visible = this.checkBox2.Checked;
                    break;
                case "Show DropDown":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[7].Visible = this.checkBox8.Checked;
                    break;
                case "Show Close button":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[8].Visible = this.checkBox9.Checked;
                    break;
                case "Show Custom Primitive":
                    this.PrimitivesTabControl.TabPrimitivesHost.TabPrimitives[0].Visible = this.checkBox7.Checked;
                    break;
            }
        }

        private void PrimitivesTabControl_TabPrimitiveClick(object sender, TabPrimitiveClickEventArgs e)
        {
            if (e.TabPrimitive.Name == "AddTab")
            {
                TabPageAdv tabPage = new TabPageAdv("New Tab");
                PrimitivesTabControl.TabPages.Add(tabPage);
            }
        }
        #endregion

        #region Styles
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.SelectedItem as string)
            {
                case "TabRenderer3D":
                    this.FormTabControl.TabStyle = typeof(TabRenderer3D);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRenderer2D":
                    this.FormTabControl.TabStyle = typeof(TabRenderer2D);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Workbook":
                    this.FormTabControl.TabStyle = typeof(TabRendererWorkbookMode);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "OneNoteStyle":
                    this.FormTabControl.TabStyle = typeof(OneNoteStyleRenderer);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "OneNoteStyleFlatTabs":
                    this.FormTabControl.TabStyle = typeof(OneNoteStyleFlatTabsRenderer);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Office2003":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2003);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Whidbey":
                    this.FormTabControl.TabStyle = typeof(TabRendererWhidbey);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "DockingWhidbey":
                    this.FormTabControl.TabStyle = typeof(TabRendererDockingWhidbey);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "DockingWhidbeyBeta":
                    this.FormTabControl.TabStyle = typeof(TabRendererDockingWhidbeyBeta);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Office2007Blue":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2007);
                    this.FormTabControl.Office2007ColorScheme = Office2007Theme.Blue;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "Office2007Black":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2007);
                    this.FormTabControl.Office2007ColorScheme = Office2007Theme.Black;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Black);
                    break;
                case "Office2007Silver":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2007);
                    this.FormTabControl.Office2007ColorScheme = Office2007Theme.Silver;
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Silver);
                    break;
                case "Office2007Managed":
                    this.FormTabControl.TabStyle = typeof(TabRendererOffice2007);
                    this.FormTabControl.Office2007ColorScheme = Office2007Theme.Managed;
                    Office2007Colors.ApplyManagedColors(this, Color.Green);
                    break;

                case "InternetExplorer7":
                    this.FormTabControl.TabStyle = typeof(TabRendererIE7);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRendererVS2008":
                    this.FormTabControl.TabStyle = typeof(TabRendererVS2008);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRendererBlendDark":
                    this.FormTabControl.TabStyle = typeof(TabRendererBlendDark);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRendererBlendLight":
                    this.FormTabControl.TabStyle = typeof(TabRendererBlendLight);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Blue);
                    break;
                case "TabRendererVS2010":
                    this.FormTabControl.TabStyle = typeof(TabRendererVS2010);
                    Office2007Colors.ApplyManagedScheme(this, Office2007Theme.Silver);
                    break;
            }
        }

        private void Properties_CheckChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            switch (checkBox.Tag as string)
            {
                case "themes":
                    FormTabControl.ThemesEnabled = checkBox14.Checked;
                    break;
                case "imagealign":
                    if (checkBox11.Checked)
                        FormTabControl.ImageAlignmentR = RelativeImageAlignment.LeftOfText;
                    else
                        FormTabControl.ImageAlignmentR = RelativeImageAlignment.RightOfText;
                    break;
                case "scrolls":
                    FormTabControl.ShowScroll = checkBox13.Checked;
                    break;
                case "outsidebounds":
                    if (checkBox17.Checked)
                    {
                        FormTabControl.ImageOffset = 10;
                        FormTabControl.ItemSize = new Size(102, 25);
                    }
                    else
                    {
                        FormTabControl.ImageOffset = 0;
                        FormTabControl.ItemSize = new Size(102, 33);
                    }
                    if (this.FormTabControl.Alignment == TabAlignment.Left || this.FormTabControl.Alignment == TabAlignment.Right)
                        FormTabControl.LevelTextAndImage = false;
                    else
                        FormTabControl.LevelTextAndImage = checkBox17.Checked;
                    break;
                case "inactiveimage":
                    FormTabControl.DisableInactivePageImage = checkBox10.Checked;
                    break;
                case "rotatetext":
                    FormTabControl.RotateTextWhenVertical = checkBox12.Checked;
                    break;
                case "persist":
                    FormTabControl.PersistTabState = checkBox16.Checked;
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            FormTabControl.TabGap = (int)numericUpDown1.Value;
        }

        // Tab Alignment
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    FormTabControl.Alignment = TabAlignment.Top;
                    FormTabControl.LevelTextAndImage = true;
                    break;
                case 1:
                    FormTabControl.Alignment = TabAlignment.Left;
                    FormTabControl.LevelTextAndImage = false;
                    break;
                case 2:
                    FormTabControl.Alignment = TabAlignment.Bottom;
                    FormTabControl.LevelTextAndImage = true;
                    break;
                case 3:
                    FormTabControl.Alignment = TabAlignment.Right;
                    FormTabControl.LevelTextAndImage = false;
                    break;
            }
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    FormTabControl.BorderStyle = BorderStyle.None;
                    break;
                case 1:
                    FormTabControl.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case 2:
                    FormTabControl.BorderStyle = BorderStyle.Fixed3D;
                    break;
            }
        } 
        #endregion

        #region Custom ContextMenu
        private void contextMenuStripEx1_Opening(object sender, CancelEventArgs e)
        {
            if (FormTabControl.GetTabRect(FormTabControl.SelectedIndex).Contains(tabPoint)
                && contextMenuCheck.Checked)
            {
                contextMenuStripEx1.Show();
                tabPoint = Point.Empty;
            }
            else
                e.Cancel = true;
        }

        private void FormTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if(contextMenuCheck.Checked)
                tabPoint = new Point(e.X, e.Y);
        }

        private void addTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPageAdv tabPage = new TabPageAdv("New Tab");
            tabPage.ImageIndex = 3;
            FormTabControl.TabPages.Add(tabPage);
        }  
        #endregion

        #region Behavior Tab
        private void Behavior_CheckChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Tag as string)
            {
                case "focus":
                    BehaviorTabControl.FocusOnTabClick = checkBox18.Checked;
                    break;
                case "hottrack":
                    BehaviorTabControl.HotTrack = checkBox19.Checked;
                    break;
                case "multiline":
                    BehaviorTabControl.Multiline = checkBox20.Checked;
                    break;
                case "labeledit":
                    BehaviorTabControl.LabelEdit = checkBox24.Checked;
                    break;
                case "tooltips":
                    BehaviorTabControl.ShowToolTips = checkBox22.Checked;
                    break;
                case "movetabs":
                    BehaviorTabControl.UserMoveTabs = checkBox23.Checked;
                    break;
                case "frontrow":
                    BehaviorTabControl.KeepSelectedTabInFrontRow = checkBox21.Checked;
                    break;
            }
        } 
        #endregion

        #region Events
        private void BehaviorTabControl_SelectedIndexChanging(object sender, SelectedIndexChangingEventArgs args)
        {
            if (args.NewSelectedIndex >= 0)
            EventsList("Selected Index Changing: " + BehaviorTabControl.TabPages[args.NewSelectedIndex].Text);
            
        }

        private void BehaviorTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BehaviorTabControl.SelectedIndex >= 0)
            EventsList("Selected Index Changed: " + BehaviorTabControl.SelectedTab.Text);
        }

        private void BehaviorTabControl_BeforeEdit(object sender, EditEventArgs e)
        {
            EventsList("Before Edit: " + e.EditText);
        }

        private void BehaviorTabControl_AfterEdit(object sender, EditEventArgs e)
        {
            EventsList("After Edit: " + e.EditText);
        }

        private void BehaviorTabControl_LabelEditChanged(object sender, EventArgs e)
        {
            EventsList("Label Edit changed");
        }

        private void BehaviorTabControl_LabelEditTextChanged(object sender, EventArgs e)
        {
            EventsList("Label Edit Text changed");
        }

        private void EventsList(object item)
        {
            listBox1.Items.Add(item);
            listBox1.SetSelected(listBox1.Items.Count - 1, true);
            listBox1.SetSelected(listBox1.Items.Count - 1, false);
        }
        private void buttonEdit1_ButtonClicked_1(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                activeTabColorEdit.BackColor = colorDialog1.Color;

            }
        }
        #endregion

        #region Close Button
        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            BehaviorTabControl.ShowTabCloseButton = checkBox25.Checked;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
           //Shows close button for Active tab only
            BehaviorTabControl.ShowCloseButtonForActiveTabOnly = checkBox15.Checked;
        }
        #endregion

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                tab3.ImageIndex = -1;
                tab4.ImageIndex = -1;
                tab6.ImageIndex = -1;
               
                checkBox10.Enabled = false;
                checkBox17.Checked = false;
            }
            else
            {
              
            tab3.ImageIndex=1;
            tab4.ImageIndex=2;
            tab6.ImageIndex = 0;
            }
        }

     
        #region Creating TabControlAdv dynamically
        //		private void InitMyTabs()
//		{
//			this.tabControl1 = new TabControlAdv();
//			this.tabPage1 = new TabPageAdv();
//			this.tabPage2 = new TabPageAdv();
//			this.tabPage3 = new TabPageAdv();
// 
//			// Positions tabs on the left side of tabControl1.
//			// this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
//       
//			// Sets the tabs to appear in 2D mode.
//			tabControl1.TabStyle = typeof(TabRenderer2D);
//
//			// Highlights TabPage.Text when the mouse passes over tabs.
//			this.tabControl1.HotTrack = true;
//
//			// Set the relative alignment between the images and text in a tab
//			this.tabControl1.ImageAlignmentR = RelativeImageAlignment.BelowText;
//
//			// Allows more than one row of tabs.
//			// this.tabControl1.Multiline = true;
//
//			// Creates a cushion of 22 pixels around TabPage.Text strings.
//			this.tabControl1.Padding = new System.Drawing.Point(22, 22);
//
//			// Makes the tab width definable. 
//			this.tabControl1.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.Fixed;
//
//			// Sizes the tabs of tabControl1.
//			this.tabControl1.ItemSize = new Size(90, 64); // Make sure to take into account the padding values.
//
//			// To rotate text when aligned vertically.
//			this.tabControl1.RotateTextWhenVertical = true;
//
//			// Allows the user to move the tabs by simply dragging and dropping
//			this.tabControl1.UserMoveTabs = true;
//
//			// Draws the scroll buttons Visual Studio MDI Tabs like.
//			this.tabControl1.VSLikeScrollButton = true;
//
//			this.tabControl1.Controls.AddRange(new Control[] { this.tabPage1, this.tabPage2, this.tabPage3});
//			this.tabControl1.Location = new Point(16, 24);
//			this.tabControl1.SelectedIndex = 0;
//			this.tabControl1.Size = new Size(248, 232);
// 
//			this.tabPage1.Text = "Tab1";
//			this.tabPage2.Text = "Tab2";
//			this.tabPage3.Text = "Tab3";
//			this.Size = new Size(300,300);
//			this.Controls.AddRange(new Control[] { this.tabControl1});
//
//			// Selects tabPage1 using SelectedIndex.
//			this.tabControl1.SelectedIndex = 1;
//
//			// Shows ToolTipText when the mouse passes over tabs.
//			this.tabControl1.ShowToolTips = true;
//		}
#endregion
	}
}
