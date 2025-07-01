using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Reflection;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Microsoft.Win32;

namespace WindowFill
{
	/// <summary>
	/// Summary description for frmMain.
	/// </summary>
	public class frmMain : Syncfusion.Windows.Forms.Office2007Form

	{
		# region Members declaration
		private System.Windows.Forms.ImageList ilCommon;
		private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
		private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
		private System.ComponentModel.IContainer components;
		private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xPTtaskMenuBox1;
		private Syncfusion.Windows.Forms.Tools.XPTaskBarBox taskMenuBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
		private Syncfusion.Windows.Forms.Tools.XPTaskBar Tasks;
		private System.Windows.Forms.ListView Items;
		private System.Windows.Forms.RichTextBox Description;
		private System.Windows.Forms.TreeView Category;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem comboBoxBarItem1;
		private System.Windows.Forms.ListBox lstlistBox1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;		
        private DemoCommon.AboutForm aboutForm;

# endregion	

		# region Initialisation
		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			
		
			InitializeComponent();


            this.comboBoxBarItem1.Click += new EventHandler(comboBoxBarItem1_Click);
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        void comboBoxBarItem1_Click(object sender, EventArgs e)
        {
            switch (comboBoxBarItem1.TextBoxValue)
            {
                
                case "Office2003":
                    dockingManager1.VisualStyle = VisualStyle.Office2003;
                    break;
                case "WindowsXPThemes":
                    dockingManager1.VisualStyle = VisualStyle.Default;
                    dockingManager1.ThemesEnabled = true;
                    break;
                case "Office2007":
                    dockingManager1.VisualStyle = VisualStyle.Office2007;
                    break;
                case "VS2005":
                    dockingManager1.VisualStyle = VisualStyle.VS2005;
                    break;

                case "Default":
                    dockingManager1.VisualStyle = VisualStyle.Default;
                    break;

            }
        }


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbCategory = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbTasks = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbItems = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbDescription = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "CD Drive"}, 24, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "HDD 80GB"}, 2, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Camera"}, 9, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Webcam"}, 10, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "DVD Writer"}, 1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(249))))), new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("DVD", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("CD/DVD Drives", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("80GB", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Hard disk", 3, 3, new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Laser", 7, 7);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Printers", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Webcam", 10, 10);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Camera", 11, 11, new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.ilCommon = new System.Windows.Forms.ImageList(this.components);
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Main");
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "VisualStyles");
            this.comboBoxBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.lstlistBox1 = new System.Windows.Forms.ListBox();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Items = new System.Windows.Forms.ListView();
            this.Tasks = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.taskMenuBox3 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xPTtaskMenuBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.Category = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks)).BeginInit();
            this.Tasks.SuspendLayout();
            this.taskMenuBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.AutoLoadToolBarPositions = false;
            this.mainFrameBarManager1.AutoPersistCustomization = false;
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("VisualStyle");
            this.mainFrameBarManager1.Categories.Add("Format");
            this.mainFrameBarManager1.Categories.Add("View");
            this.mainFrameBarManager1.Categories.Add("Popups");
            this.mainFrameBarManager1.Categories.Add("Help");
            this.mainFrameBarManager1.Categories.Add("Misc");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form";
            this.mainFrameBarManager1.EnableCustomizing = false;
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.barItem1,
            this.parentBarItem2,
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.parentBarItem3,
            this.comboBoxBarItem1,
            this.barItem6,
            this.barItem7});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)));
            this.bar1.Caption = "Main";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem3,
            this.parentBarItem2,
            this.parentBarItem1});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.CategoryIndex = 0;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "File";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem5});
            this.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem3.Text = "File";
            // 
            // barItem5
            // 
            this.barItem5.CategoryIndex = 0;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Close";
            this.barItem5.Text = "Close";
            this.barItem5.Click += new System.EventHandler(this.barItem5_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.CategoryIndex = 1;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "Visual Style";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem2,
            this.barItem3,
            this.barItem6,
            this.barItem4,
            this.barItem7});
            this.parentBarItem2.Text = "Visual Style";
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = 1;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Default";
            this.barItem2.Text = "Default";
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // barItem3
            // 
            this.barItem3.CategoryIndex = 1;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "Office2003";
            this.barItem3.Text = "Office2003";
            this.barItem3.Click += new System.EventHandler(this.barItem3_Click);
            // 
            // barItem6
            // 
            this.barItem6.CategoryIndex = 1;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "Office2007";
            this.barItem6.Text = "Office2007";
            this.barItem6.Click += new System.EventHandler(this.barItem6_Click);
            // 
            // barItem4
            // 
            this.barItem4.CategoryIndex = 1;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Windows XP themes";
            this.barItem4.Text = "Windows XP themes";
            this.barItem4.Click += new System.EventHandler(this.barItem4_Click);
            // 
            // barItem7
            // 
            this.barItem7.CategoryIndex = 1;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "VS2005";
            this.barItem7.Text = "VS2005";
            this.barItem7.Click += new System.EventHandler(this.barItem7_Click);
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.CategoryIndex = 5;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "Help";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1});
            this.parentBarItem1.Text = "Help";
            // 
            // barItem1
            // 
            this.barItem1.CategoryIndex = 5;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "About Syncfusion";
            this.barItem1.Text = "About Syncfusion";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // bar2
            // 
            this.bar2.BarName = "VisualStyles";
            this.bar2.BarStyle = Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible;
            this.bar2.Caption = "VisualStyles";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.comboBoxBarItem1});
            this.bar2.Manager = this.mainFrameBarManager1;
            // 
            // comboBoxBarItem1
            // 
            this.comboBoxBarItem1.CategoryIndex = 1;
            this.comboBoxBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBarItem1.Editable = false;
            this.comboBoxBarItem1.ID = "VisualStyle_1";
            this.comboBoxBarItem1.ListBox = this.lstlistBox1;
            this.comboBoxBarItem1.MinWidth = 150;
            this.comboBoxBarItem1.Text = "VisualStyle";
            this.comboBoxBarItem1.TextBoxValue = "Office2007";
            this.comboBoxBarItem1.Selected += new System.EventHandler(this.comboBoxBarItem1_Selected);
            // 
            // lstlistBox1
            // 
            this.lstlistBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstlistBox1.ItemHeight = 16;
            this.lstlistBox1.Items.AddRange(new object[] {
            "Default",
            "Office2003",
            "Office2007",
            "WindowsXPThemes",
            "VS2005"});
            this.lstlistBox1.Location = new System.Drawing.Point(128, 192);
            this.lstlistBox1.Name = "lstlistBox1";
            this.lstlistBox1.Size = new System.Drawing.Size(144, 52);
            this.lstlistBox1.TabIndex = 18;
            // 
            // dockingManager1
            // 
            this.dockingManager1.ActiveCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dockingManager1.DisallowFloating = true;
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.DockToFill = true;
            this.dockingManager1.HostControl = this;
            this.dockingManager1.ImageList = this.ilCommon;
            this.dockingManager1.InActiveCaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.SetDockLabel(this.Category, "Category");
            ccbCategory.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.Category, ccbCategory);
            this.dockingManager1.SetDockLabel(this.Tasks, "Tasks");
            ccbTasks.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.Tasks, ccbTasks);
            this.dockingManager1.SetDockLabel(this.Items, "Items");
            this.dockingManager1.SetDockIcon(this.Items, 23);
            ccbItems.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.Items, ccbItems);
            this.dockingManager1.SetDockLabel(this.Description, "Description");
            this.dockingManager1.SetDockIcon(this.Description, 5);
            ccbDescription.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.Description, ccbDescription);
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.dockingManager1.SetEnableDocking(this.Description, true);
            this.Description.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(100)))), ((int)(((byte)(19)))));
            this.Description.Location = new System.Drawing.Point(3, 23);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(397, 221);
            this.Description.TabIndex = 4;
            this.Description.Text = "Use the DockingManager.DockToFill mode to create forms comprising entirely of doc" +
                "kable windows. Controls can be made non-floatable by setting the DockingManager." +
                "DisallowFloating property.";
            // 
            // Items
            // 
            this.Items.AllowColumnReorder = true;
            this.Items.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dockingManager1.SetEnableDocking(this.Items, true);
            this.Items.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewItem3.UseItemStyleForSubItems = false;
            this.Items.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.Items.LargeImageList = this.ilCommon;
            this.Items.Location = new System.Drawing.Point(3, 23);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(397, 129);
            this.Items.TabIndex = 5;
            this.Items.UseCompatibleStateImageBehavior = false;
            // 
            // Tasks
            // 
            this.Tasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tasks.Controls.Add(this.taskMenuBox3);
            this.Tasks.Controls.Add(this.xPTtaskMenuBox1);
            this.dockingManager1.SetEnableDocking(this.Tasks, true);
            this.Tasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Tasks.Location = new System.Drawing.Point(3, 23);
            this.Tasks.MinimumSize = new System.Drawing.Size(0, 0);
            this.Tasks.Name = "Tasks";
            this.Tasks.Padding = new System.Windows.Forms.Padding(10);
            this.Tasks.Size = new System.Drawing.Size(211, 362);
            this.Tasks.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007;
            this.Tasks.TabIndex = 9;
            this.Tasks.VerticalPadding = 20;
            // 
            // taskMenuBox3
            // 
            this.taskMenuBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(213)))), ((int)(((byte)(226)))));
            this.taskMenuBox3.Controls.Add(this.panel1);
            this.taskMenuBox3.DrawFocusRect = false;
            this.taskMenuBox3.FocusOnClick = false;
            this.taskMenuBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.taskMenuBox3.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskMenuBox3.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.taskMenuBox3.HeaderImageIndex = -1;
            this.taskMenuBox3.HitTaskBoxArea = false;
            this.taskMenuBox3.Location = new System.Drawing.Point(10, 10);
            this.taskMenuBox3.Name = "taskMenuBox3";
            this.taskMenuBox3.PreferredChildPanelHeight = 120;
            this.taskMenuBox3.Size = new System.Drawing.Size(189, 144);
            this.taskMenuBox3.TabIndex = 2;
            this.taskMenuBox3.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 120);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Items.AddRange(new object[] {
            "C#",
            "VB",
            "C++"});
            this.comboBox1.Location = new System.Drawing.Point(78, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "comboBox1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(78, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keywords:";
            // 
            // xPTtaskMenuBox1
            // 
            this.xPTtaskMenuBox1.BackColor = System.Drawing.Color.White;
            this.xPTtaskMenuBox1.DrawFocusRect = false;
            this.xPTtaskMenuBox1.FocusOnClick = false;
            this.xPTtaskMenuBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPTtaskMenuBox1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPTtaskMenuBox1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.xPTtaskMenuBox1.HeaderImageIndex = -1;
            this.xPTtaskMenuBox1.HitTaskBoxArea = false;
            this.xPTtaskMenuBox1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results by Customer Name", System.Drawing.SystemColors.ActiveCaption, 22, null, "about items", true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results by Customer ID", System.Drawing.Color.Empty, 23, null, "about drawing", true, true, "", new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))), 0)});
            this.xPTtaskMenuBox1.Location = new System.Drawing.Point(10, 174);
            this.xPTtaskMenuBox1.Name = "xPTtaskMenuBox1";
            this.xPTtaskMenuBox1.Size = new System.Drawing.Size(189, 98);
            this.xPTtaskMenuBox1.TabIndex = 1;
            this.xPTtaskMenuBox1.Text = "Sort Categories";
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(238)))), ((int)(((byte)(249)))));
            this.dockingManager1.SetEnableDocking(this.Category, true);
            this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ImageIndex = 0;
            this.Category.ImageList = this.ilCommon;
            this.Category.Location = new System.Drawing.Point(3, 23);
            this.Category.Name = "Category";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "DVD";
            treeNode2.Name = "";
            treeNode2.Text = "CD/DVD Drives";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "80GB";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Hard disk";
            treeNode5.ImageIndex = 7;
            treeNode5.Name = "";
            treeNode5.SelectedImageIndex = 7;
            treeNode5.Text = "Laser";
            treeNode6.ImageIndex = 8;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 8;
            treeNode6.Text = "Printers";
            treeNode7.ImageIndex = 10;
            treeNode7.Name = "";
            treeNode7.SelectedImageIndex = 10;
            treeNode7.Text = "Webcam";
            treeNode8.ImageIndex = 11;
            treeNode8.Name = "";
            treeNode8.SelectedImageIndex = 11;
            treeNode8.Text = "Camera";
            this.Category.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode4,
            treeNode6,
            treeNode8});
            this.Category.SelectedImageIndex = 0;
            this.Category.Size = new System.Drawing.Size(211, 362);
            this.Category.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(632, 462);
            this.Controls.Add(this.lstlistBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Window Fill";
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxBarItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tasks)).EndInit();
            this.Tasks.ResumeLayout(false);
            this.taskMenuBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}
# endregion

		# region Event handlers
		private void barItem1_Click(object sender, System.EventArgs e)
		{
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
		}

		private void barItem2_Click(object sender, System.EventArgs e)
		{
			dockingManager1.ThemesEnabled = false;
			dockingManager1.VisualStyle = VisualStyle.Default ;
			this.comboBoxBarItem1.TextBoxValue = "Default";
		}

		private void barItem3_Click(object sender, System.EventArgs e)
		{
			dockingManager1.VisualStyle = VisualStyle.Office2003;
			this.comboBoxBarItem1.TextBoxValue = "Office2003";
		}

		private void barItem4_Click(object sender, System.EventArgs e)
		{
			dockingManager1.VisualStyle = VisualStyle.Default ;
			dockingManager1.ThemesEnabled = true;
			this.comboBoxBarItem1.TextBoxValue = "WindowsXPThemes";
		}
		private void barItem6_Click(object sender, System.EventArgs e)
		{
			dockingManager1.VisualStyle = VisualStyle.Office2007;	
			this.comboBoxBarItem1.TextBoxValue = "Office2007";
		}
		private void barItem7_Click(object sender, System.EventArgs e)
		{
			dockingManager1.VisualStyle = VisualStyle.VS2005;		
			this.comboBoxBarItem1.TextBoxValue = "VS2005";
		}
		private void comboBoxBarItem1_Selected(object sender, System.EventArgs e)
		{
			
		}
		# endregion		

        private void barItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	}
}
