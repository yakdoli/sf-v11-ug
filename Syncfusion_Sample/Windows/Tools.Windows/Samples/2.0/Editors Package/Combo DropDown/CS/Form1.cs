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
using Syncfusion.Windows.Forms;

namespace ComboDropDownDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
	{
		private Syncfusion.Windows.Forms.Tools.ComboDropDown comboDropDown1;
        private System.Windows.Forms.TreeView treeView1;
		private Syncfusion.Windows.Forms.Grid.GridListControl gridListControl1;
		private Syncfusion.Windows.Forms.Tools.ComboDropDown comboDropDown2;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Label label20;
        private Label label19;
        private Label label2;
        private Label label3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv2;
        private Label label4;
        private Label label5;
        private BannerTextProvider bannerTextProvider1;
        private Label label6;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit bannerClrEdit;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Label label8;
        private Label label9;
        private Label label10;
        private RadioButton rdoEdit;
        private RadioButton rdoFocus;
        private TextBox txtBanner;
        private Button btnSetBanner;
        private ColorDialog colorDialog1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            this.treeView1.AfterSelect += new TreeViewEventHandler(treeView1_AfterSelect);

            this.gridListControl1.Grid.CellClick += new Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(Grid_CellClick);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.treeView1.ExpandAll();

			
			#region GridList
			ArrayList USStates = new ArrayList()   ;
			USStates.Add(new USState("Alaska", "AK", 1));
			USStates.Add(new USState("Arizona", "AZ", 2));
			USStates.Add(new USState("Arkansas", "AK", 3));
			USStates.Add(new USState("California", "CA", 4));
			USStates.Add(new USState("Colorado", "CO", 5));
			USStates.Add(new USState("Connecticut", "CT", 6));
			USStates.Add(new USState("Delaware", "DE", 3));
			USStates.Add(new USState("Florida", "FL", 4));
			USStates.Add(new USState("Georgia", "GA", 1));
			USStates.Add(new USState("Hawaii", "HI", 0));
			USStates.Add(new USState("Idaho", "ID", 3));
			USStates.Add(new USState("Illinois", "IL", 2));
			USStates.Add(new USState("Indiana", "IN", 6));
			USStates.Add(new USState("Iowa", "IA", 5));
			USStates.Add(new USState("Kansas", "KA", 5));
			USStates.Add(new USState("Kentucky", "KY", 4));
			USStates.Add(new USState("Louisiana", "LA", 3));
			USStates.Add(new USState("Maine", "ME", 0));
			USStates.Add(new USState("Maryland", "MD", 0));
			USStates.Add(new USState("Massachusetts", "MA", 2));
			USStates.Add(new USState("Michigan", "MI", 1));
			USStates.Add(new USState("Minnesota", "MN", 6));
			USStates.Add(new USState("Mississippi", "MS", 5));
			USStates.Add(new USState("Missouri", "MO", 2));
			USStates.Add(new USState("Montana", "MT", 1));
			USStates.Add(new USState("Nebraska", "NE", 4));
			USStates.Add(new USState("Nevada", "NV", 0));
			USStates.Add(new USState("New Hampshire", "NH", 3));
			USStates.Add(new USState("New Jersey", "NJ", 3));
			USStates.Add(new USState("New Mexico", "NM", 2));
			USStates.Add(new USState("New York", "NY", 5));
			USStates.Add(new USState("North Carolina", "NC", 4));
			USStates.Add(new USState("North Dakota", "ND", 4));
			USStates.Add(new USState("Ohio", "OH", 1));
			USStates.Add(new USState("Oklahoma", "OK", 2));
			USStates.Add(new USState("Oregon", "OR", 5));
			USStates.Add(new USState("Pennsylvania", "PA", 0));
			USStates.Add(new USState("Rhode Island", "RI", 6));
			USStates.Add(new USState("South Carolina", "SC", 5));
			USStates.Add(new USState("South Dakota", "SD", 4));
			USStates.Add(new USState("Tennessee", "TN", 3));
			USStates.Add(new USState("Texas", "TX", 2));
			USStates.Add(new USState("Utah", "UT", 0));
			USStates.Add(new USState("Vermont", "VT", 1));
			USStates.Add(new USState("Virginia", "VA", 0));
			USStates.Add(new USState("Washington", "WA", 2));
			USStates.Add(new USState("West Virginia", "WV", 0));
			USStates.Add(new USState("Wisconsin", "WI", 3));
			USStates.Add(new USState("Wyoming", "WY", 5));

			
			ImageList imageList2 = new ImageList();
			imageList2.ImageSize = new Size(15, 15);
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\add2.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\bug_green.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\star_blue.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\navigate_check.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\jar_bean_delete.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\console.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\delete2.png"));
			imageList2.Images.Add(new Bitmap(@"..\\..\ImageList\layout_horizontal.png"));

			this.gridListControl1.ImageList = imageList2;

			
			this.gridListControl1.BeginUpdate();
			this.gridListControl1.DataSource = USStates ;
			this.gridListControl1.DisplayMember  = "LongName"     ;
			this.gridListControl1.ValueMember = "ShortName" ;
			this.gridListControl1.MultiColumn = true;
			this.gridListControl1.ShowColumnHeader = true;
			this.gridListControl1.SelectionMode = SelectionMode.One;
			this.gridListControl1.ThemesEnabled = true;
			this.gridListControl1.Grid.VerticalThumbTrack = true;			
			
			
			
			this.gridListControl1.FillLastColumn = true;
			this.gridListControl1.EndUpdate();

			#endregion
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node8", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboDropDown1 = new Syncfusion.Windows.Forms.Tools.ComboDropDown();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboDropDown2 = new Syncfusion.Windows.Forms.Tools.ComboDropDown();
            this.gridListControl1 = new Syncfusion.Windows.Forms.Grid.GridListControl();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bannerClrEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rdoEdit = new System.Windows.Forms.RadioButton();
            this.rdoFocus = new System.Windows.Forms.RadioButton();
            this.txtBanner = new System.Windows.Forms.TextBox();
            this.btnSetBanner = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).BeginInit();
            this.bannerClrEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboDropDown1
            // 
            this.comboDropDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.bannerTextProvider1.SetBannerText(this.comboDropDown1, new Syncfusion.Windows.Forms.BannerTextInfo("[Select]", true, null, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode));
            this.comboDropDown1.IgnoreThemeBackground = true;
            this.comboDropDown1.Location = new System.Drawing.Point(24, 126);
            this.comboDropDown1.Name = "comboDropDown1";
            this.comboDropDown1.PopupControl = this.treeView1;
            this.comboDropDown1.Size = new System.Drawing.Size(175, 21);
            this.comboDropDown1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboDropDown1.SuppressDropDownEvent = false;
            this.comboDropDown1.TabIndex = 0;
            this.comboDropDown1.DropDown += new System.EventHandler(this.comboDropDown1_DropDown);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.treeView1.HideSelection = false;
            this.treeView1.HotTracking = true;
            this.treeView1.ImageIndex = 3;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.ItemHeight = 34;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(451, 58);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "";
            treeNode1.Text = "Node1";
            treeNode2.Name = "";
            treeNode2.Text = "Node0";
            treeNode3.Name = "";
            treeNode3.Text = "Node10";
            treeNode4.Name = "";
            treeNode4.Text = "Node3";
            treeNode5.Name = "";
            treeNode5.Text = "Node2";
            treeNode6.Name = "";
            treeNode6.Text = "Node5";
            treeNode7.Name = "";
            treeNode7.Text = "Node4";
            treeNode8.Name = "";
            treeNode8.Text = "Node7";
            treeNode9.Name = "";
            treeNode9.Text = "Node6";
            treeNode10.Name = "";
            treeNode10.Text = "Node9";
            treeNode11.Name = "";
            treeNode11.Text = "Node8";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode5,
            treeNode7,
            treeNode9,
            treeNode11});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(174, 166);
            this.treeView1.Sorted = true;
            this.treeView1.TabIndex = 1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            // 
            // comboDropDown2
            // 
            this.comboDropDown2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.bannerTextProvider1.SetBannerText(this.comboDropDown2, new Syncfusion.Windows.Forms.BannerTextInfo("[Select]", true, null, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode));
            this.comboDropDown2.IgnoreThemeBackground = true;
            this.comboDropDown2.Location = new System.Drawing.Point(233, 126);
            this.comboDropDown2.Name = "comboDropDown2";
            this.comboDropDown2.PopupControl = this.gridListControl1;
            this.comboDropDown2.Size = new System.Drawing.Size(175, 21);
            this.comboDropDown2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboDropDown2.SuppressDropDownEvent = false;
            this.comboDropDown2.TabIndex = 4;
            // 
            // gridListControl1
            // 
            this.gridListControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridListControl1.DisplayMember = "LongName";
            this.gridListControl1.FillLastColumn = true;
            this.gridListControl1.ItemHeight = 17;
            this.gridListControl1.Location = new System.Drawing.Point(451, 187);
            this.gridListControl1.MultiColumn = true;
            this.gridListControl1.Name = "gridListControl1";
            this.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridListControl1.SelectedIndex = -1;
            this.gridListControl1.Size = new System.Drawing.Size(175, 176);
            this.gridListControl1.TabIndex = 2;
            this.gridListControl1.ThemesEnabled = true;
            this.gridListControl1.TopIndex = 0;
            this.gridListControl1.ValueMember = "ShortName";
            // 
            // autoLabel1
            // 
            this.autoLabel1.DX = 0;
            this.autoLabel1.DY = 0;
            this.autoLabel1.Location = new System.Drawing.Point(24, 225);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(35, 13);
            this.autoLabel1.TabIndex = 4;
            this.autoLabel1.Text = "Styles";
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.IgnoreThemeBackground = true;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Default",
            "OfficeXP",
            "Office2003",
            "VS2005",
            "Office2007"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Default"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "OfficeXP"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2003"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "VS2005"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Office2007"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(100, 225);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(101, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.comboBoxAdv1.SuppressDropDownEvent = false;
            this.comboBoxAdv1.TabIndex = 3;
            this.comboBoxAdv1.Text = "Office2007";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 2;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 62);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label20.Location = new System.Drawing.Point(21, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(180, 1);
            this.label20.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(21, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(114, 23);
            this.label19.TabIndex = 25;
            this.label19.Text = "With TreeView";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(230, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 1);
            this.label2.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(230, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "With GridListControl";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // autoLabel2
            // 
            this.autoLabel2.DX = 0;
            this.autoLabel2.DY = 0;
            this.autoLabel2.Location = new System.Drawing.Point(24, 259);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(70, 13);
            this.autoLabel2.TabIndex = 29;
            this.autoLabel2.Text = "ColorScheme";
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.IgnoreThemeBackground = true;
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "Blue",
            "Silver",
            "Black"});
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Blue"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Silver"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "Black"));
            this.comboBoxAdv2.Location = new System.Drawing.Point(100, 259);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(101, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.comboBoxAdv2.SuppressDropDownEvent = false;
            this.comboBoxAdv2.TabIndex = 28;
            this.comboBoxAdv2.Text = "Blue";
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label4.Location = new System.Drawing.Point(21, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 1);
            this.label4.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(21, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Visual Styles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label6.Location = new System.Drawing.Point(230, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 1);
            this.label6.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(230, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 33;
            this.label7.Text = "BannerText Settings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bannerClrEdit
            // 
            this.bannerClrEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bannerClrEdit.Buttons.Add(this.buttonEditChildButton1);
            this.bannerClrEdit.Controls.Add(this.buttonEditChildButton1);
            this.bannerClrEdit.Controls.Add(this.textBoxExt1);
            this.bannerClrEdit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bannerClrEdit.Location = new System.Drawing.Point(291, 292);
            this.bannerClrEdit.Name = "bannerClrEdit";
            this.bannerClrEdit.Size = new System.Drawing.Size(121, 21);
            this.bannerClrEdit.TabIndex = 34;
            this.bannerClrEdit.TextBox = this.textBoxExt1;
            this.bannerClrEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bannerClrEdit_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Location = new System.Drawing.Point(3, 4);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(95, 13);
            this.textBoxExt1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Text";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mode";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Color";
            // 
            // rdoEdit
            // 
            this.rdoEdit.AutoSize = true;
            this.rdoEdit.Location = new System.Drawing.Point(291, 246);
            this.rdoEdit.Name = "rdoEdit";
            this.rdoEdit.Size = new System.Drawing.Size(73, 17);
            this.rdoEdit.TabIndex = 35;
            this.rdoEdit.Text = "Edit Mode";
            this.rdoEdit.UseVisualStyleBackColor = true;
            // 
            // rdoFocus
            // 
            this.rdoFocus.AutoSize = true;
            this.rdoFocus.Checked = true;
            this.rdoFocus.Location = new System.Drawing.Point(291, 269);
            this.rdoFocus.Name = "rdoFocus";
            this.rdoFocus.Size = new System.Drawing.Size(84, 17);
            this.rdoFocus.TabIndex = 36;
            this.rdoFocus.TabStop = true;
            this.rdoFocus.Text = "Focus Mode";
            this.rdoFocus.UseVisualStyleBackColor = true;
            // 
            // txtBanner
            // 
            this.txtBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBanner.Location = new System.Drawing.Point(291, 216);
            this.txtBanner.Name = "txtBanner";
            this.txtBanner.Size = new System.Drawing.Size(120, 20);
            this.txtBanner.TabIndex = 37;
            // 
            // btnSetBanner
            // 
            this.btnSetBanner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetBanner.Location = new System.Drawing.Point(258, 325);
            this.btnSetBanner.Name = "btnSetBanner";
            this.btnSetBanner.Size = new System.Drawing.Size(131, 23);
            this.btnSetBanner.TabIndex = 38;
            this.btnSetBanner.Text = "Set Banner Text";
            this.btnSetBanner.UseVisualStyleBackColor = true;
            this.btnSetBanner.Click += new System.EventHandler(this.btnSetBanner_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(477, 367);
            this.Controls.Add(this.gridListControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnSetBanner);
            this.Controls.Add(this.txtBanner);
            this.Controls.Add(this.rdoFocus);
            this.Controls.Add(this.rdoEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bannerClrEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.autoLabel2);
            this.Controls.Add(this.comboBoxAdv2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.comboDropDown2);
            this.Controls.Add(this.comboBoxAdv1);
            this.Controls.Add(this.comboDropDown1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combo DropDown";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboDropDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).EndInit();
            this.bannerClrEdit.ResumeLayout(false);
            this.bannerClrEdit.PerformLayout();
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
			Application.Run(new Form1());
		}
		
		#region AfterDropDownPopup
		private void AfterDropDownPopup(object sender, EventArgs e)
		{
			// Uncomment this line, if you want the tree to take focus on dropdown.
			// this.treeView1.Focus();
		}
		#endregion
		#region DropDown
		private void comboDropDown1_DropDown(object sender, System.EventArgs e)
		{
			// Before the dropdown is shown, select a TreeNode based on the text in the combo.
            if (this.comboDropDown1.Text != String.Empty)
            {
                TreeNode matchedNode = this.FindNode(this.treeView1.Nodes, this.comboDropDown1.Text);
                this.treeView1.SelectedNode = matchedNode;
            }
		}
		#endregion
		#region TreeNode
		// Recursively traverse through all the nodes looking for a node with the specified text.
		private TreeNode FindNode(TreeNodeCollection nodes, string text)
		{
			foreach(TreeNode child in nodes)
				if(child.Text == text)
					return child;

			foreach(TreeNode child in nodes)
			{
				TreeNode matched = this.FindNode(child.Nodes, text);
				if(matched != null)
					return matched;
			}

			return null;
		}
		#endregion

		private void Form1_Load (object sender, EventArgs e)
		{
			// Listen to the Popup event
			this.comboDropDown1.PopupContainer.Popup += new EventHandler(this.AfterDropDownPopup);
            Application.Idle += new EventHandler(Application_Idle);
        }

        #region BannerText Settings
        void Application_Idle(object sender, EventArgs e)
        {
            if (txtBanner.Text == "")
                btnSetBanner.Enabled = false;
            else
                btnSetBanner.Enabled = true;
        }

        private void bannerClrEdit_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                this.bannerClrEdit.TextBox.BackColor = colorDialog1.Color;
        }

        void Grid_CellClick(object sender, Syncfusion.Windows.Forms.Grid.GridCellClickEventArgs e)
        {
            if (this.gridListControl1.SelectedIndex != -1)
                this.comboDropDown2.TextBox.Text = this.gridListControl1.SelectedItem.ToString();
            else
                this.comboDropDown2.TextBox.Text = String.Empty;

            this.comboDropDown2.PopupContainer.HidePopup(PopupCloseType.Done);
        }

        void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeView1.SelectedNode != null)
                // Set the combo's text to be the TreeNode's Text.
                this.comboDropDown1.Text = this.treeView1.SelectedNode.Text;
            else
                this.comboDropDown1.Text = String.Empty;

            // Close the dropdown.
            this.comboDropDown1.PopupContainer.HidePopup(PopupCloseType.Done);
        }

        private void btnSetBanner_Click(object sender, EventArgs e)
        {
            BannerTextMode mode;
            if (rdoEdit.Checked)
                mode = BannerTextMode.EditMode;
            else
                mode = BannerTextMode.FocusMode;
            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.comboDropDown1);
            binfo.Text = txtBanner.Text;
            binfo.Mode = mode;
            binfo.Color = bannerClrEdit.TextBox.BackColor;
            BannerTextInfo binfo2 = this.bannerTextProvider1.GetBannerText(this.comboDropDown2);
            binfo2.Text = txtBanner.Text;
            binfo2.Mode = mode;
            binfo2.Color = bannerClrEdit.TextBox.BackColor;
            this.comboDropDown1.Refresh();
            this.comboDropDown2.Refresh();

        }
        #endregion

        #region Styles

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv1.SelectedItem.ToString())
            {
                case "Default":
                    {
                        this.comboDropDown1.Style = VisualStyle.Default;
                         this.comboDropDown2.Style = VisualStyle.Default;
                         this.comboBoxAdv2.Enabled = false;
                        break;
                    }
                case "OfficeXP":
                    {
                        this.comboDropDown1.Style = VisualStyle.OfficeXP;
                        this.comboDropDown2.Style = VisualStyle.OfficeXP;
                        this.comboBoxAdv2.Enabled = false;
                        break;
                    }
                case "Office2003":
                    {
                        this.comboDropDown1.Style = VisualStyle.Office2003;
                        this.comboDropDown2.Style = VisualStyle.Office2003;
                        this.comboBoxAdv2.Enabled = false;
                        break;
                    }
                case "VS2005":
                    {
                        this.comboDropDown1.Style = VisualStyle.VS2005;
                        this.comboDropDown2.Style = VisualStyle.VS2005;
                        this.comboBoxAdv2.Enabled = false;
                        break;
                    }
                case "Office2007":
                    {
                        this.comboDropDown1.Style = VisualStyle.Office2007;
                        this.comboDropDown2.Style = VisualStyle.Office2007;
                        this.comboBoxAdv2.Enabled = true;
                      
                        break;
                    }
             
            }
        }
#endregion

        #region Color Schemes

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv2.SelectedItem.ToString())
            {
                case "Blue":
                    {
                        this.comboDropDown1.Office2007ColorTheme = Office2007Theme.Blue;
                        this.comboDropDown2.Office2007ColorTheme = Office2007Theme.Blue;
                          break;
                    }
                case "Silver":
                    {
                        this.comboDropDown1.Office2007ColorTheme = Office2007Theme.Silver;
                        this.comboDropDown2.Office2007ColorTheme = Office2007Theme.Silver;
                        break;
                    }
                case "Black":
                    {
                        this.comboDropDown1.Office2007ColorTheme = Office2007Theme.Black;
                        this.comboDropDown2.Office2007ColorTheme = Office2007Theme.Black;
                        break;
                    }
            }

        }
        #endregion
    }

	#region ArrayList
	public class USState
	{
		private string myShortName ;
		private string myLongName ;
		private int imgIndex;
   
		public  USState(string strLongName, string strShortName, int imageIndex)
		{
			this.myShortName = strShortName;
			this.myLongName = strLongName;
			this.imgIndex = imageIndex;
		}

		public string ShortName
		{
			get
			{
				return myShortName;
			}
		}

		public string LongName
		{
      
			get
			{
				return myLongName ;
			}
		}

		public int ImageIndex
		{
			get
			{
				return imgIndex;
			}
			set
			{
				imgIndex = value;
			}
		}


		public override string ToString()
		{
			return this.ShortName + " - " + this.LongName;
		}
	}
	#endregion
}
