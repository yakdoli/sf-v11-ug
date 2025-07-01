using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Diagnostics;

namespace LocalizationDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : 
#if SyncfusionFramework2_0	
	Office2007Form
#else
	Form
#endif	
	{
		private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem windowItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem mdiListBarItem1;
		private Syncfusion.Windows.Forms.Tools.GroupBar groupBar1;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem1;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem2;
		private Syncfusion.Windows.Forms.Tools.GroupBarItem groupBarItem3;
		private System.Windows.Forms.ImageList menuList;
		private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager1;
		private System.Windows.Forms.TextBox textBox1;
		private TabbedMDIManager tabbedMDIManager;
		private static int count = 1;
		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private Syncfusion.Windows.Forms.ColorUIControl colorUIControl1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem dropDownBarItem1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");

			InitializeComponent();

			this.StartPosition = FormStartPosition.CenterScreen;

			this.tabbedMDIManager = new TabbedMDIManager();
			this.tabbedMDIManager.AttachToMdiContainer(this);
			this.tabbedMDIManager.TabStyle = typeof(TabRendererOffice2007);
			this.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
           
            string targetPath = Application.StartupPath + "\\" + "de-DE";
            string sourceFile = System.IO.Path.GetFullPath("..\\..\\de-DE\\Syncfusion.Tools.Windows.resources.dll");
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
                System.IO.File.Copy(sourceFile, targetPath + "\\Syncfusion.Tools.Windows.resources.dll");
            sourceFile = System.IO.Path.GetFullPath("..\\..\\de-DE\\Syncfusion.Shared.Base.resources.dll");
            System.IO.File.Copy(sourceFile, targetPath + "\\Syncfusion.Shared.Base.resources.dll");
            }
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
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbtextBox1 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            this.dockingManager1 = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Hauptmenu");
            this.parentBarItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.dropDownBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.windowItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.mdiListBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem();
            this.bar2 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Standard");
            this.menuList = new System.Windows.Forms.ImageList(this.components);
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.groupBar1 = new Syncfusion.Windows.Forms.Tools.GroupBar();
            this.groupBarItem1 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem2 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            this.groupBarItem3 = new Syncfusion.Windows.Forms.Tools.GroupBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockingManager1
            // 
            this.dockingManager1.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dockingManager1.DockLayoutStream")));
            this.dockingManager1.HostControl = this;
            this.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dockingManager1.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dockingManager1.SetDockLabel(this.textBox1, "Lokalisation");
            ccbtextBox1.MergeWith(this.dockingManager1.CaptionButtons, false);
            this.dockingManager1.SetCustomCaptionButtons(this.textBox1, ccbtextBox1);
            // 
            // textBox1
            // 
            this.dockingManager1.SetEnableDocking(this.textBox1, true);
            this.textBox1.Location = new System.Drawing.Point(3, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 123);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "This Sample shows the Localization of Syncfusion Menus, Docking Manager, GroupBar" +
                " and ColorUIPicker.";
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Bars.Add(this.bar2);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Edit");
            this.mainFrameBarManager1.Categories.Add("Help");
            this.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.ImageList = this.menuList;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem3,
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem10,
            this.parentBarItem4,
            this.barItem4,
            this.barItem5,
            this.barItem6,
            this.barItem7,
            this.barItem8,
            this.parentBarItem5,
            this.barItem9,
            this.windowItem,
            this.mdiListBarItem1,
            this.dropDownBarItem1});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // bar1
            // 
            this.bar1.BarName = "Hauptmenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)));
            this.bar1.Caption = "Hauptmenu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem3,
            this.parentBarItem4,
            this.parentBarItem5,
            this.windowItem});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem3
            // 
            this.parentBarItem3.CategoryIndex = 0;
            this.parentBarItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem3.ID = "&File";
            this.parentBarItem3.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem10,
            this.barItem4});
            this.parentBarItem3.SeparatorIndices.AddRange(new int[] {
            2,
            4});
            this.parentBarItem3.Text = "&Akte";
            // 
            // barItem1
            // 
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "&New";
            this.barItem1.ImageIndex = 0;
            this.barItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.barItem1.Text = "&Neu";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "&Open";
            this.barItem2.ImageIndex = 1;
            this.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.barItem2.Text = "Geoffnet";
            // 
            // barItem3
            // 
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "&Save";
            this.barItem3.ImageIndex = 2;
            this.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.barItem3.Text = "Auber";
            // 
            // barItem10
            // 
            this.barItem10.CategoryIndex = 0;
            this.barItem10.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem10.ID = "Save &As..";
            this.barItem10.Text = "Auber wie..";
            // 
            // barItem4
            // 
            this.barItem4.CategoryIndex = 0;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "E&xit";
            this.barItem4.ImageIndex = 3;
            this.barItem4.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.barItem4.Text = "Ausgang";
            this.barItem4.Click += new System.EventHandler(this.barItem4_Click);
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.CategoryIndex = 1;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "&Edit";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem5,
            this.barItem6,
            this.barItem7,
            this.dropDownBarItem1,
            this.barItem8});
            this.parentBarItem4.MergeOrder = 1;
            this.parentBarItem4.SeparatorIndices.AddRange(new int[] {
            4});
            this.parentBarItem4.Text = "&Redigieren Sie";
            // 
            // barItem5
            // 
            this.barItem5.CategoryIndex = 1;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Cu&t";
            this.barItem5.ImageIndex = 4;
            this.barItem5.Text = "Redigieren";
            // 
            // barItem6
            // 
            this.barItem6.CategoryIndex = 1;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "&Copy";
            this.barItem6.ImageIndex = 5;
            this.barItem6.Text = "&Copy";
            // 
            // barItem7
            // 
            this.barItem7.CategoryIndex = 1;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "&Paste";
            this.barItem7.ImageIndex = 6;
            this.barItem7.Text = "&Paste";
            // 
            // dropDownBarItem1
            // 
            this.dropDownBarItem1.CategoryIndex = 1;
            this.dropDownBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDownBarItem1.ID = "Choose Color:";
            this.dropDownBarItem1.PopupControlContainer = this.popupControlContainer1;
            this.dropDownBarItem1.Text = "Farbe wahlen:";
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.colorUIControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(272, 80);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(176, 176);
            this.popupControlContainer1.TabIndex = 9;
            this.popupControlContainer1.Visible = false;
            // 
            // colorUIControl1
            // 
            this.colorUIControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorUIControl1.Location = new System.Drawing.Point(0, 0);
            this.colorUIControl1.Name = "colorUIControl1";
            this.colorUIControl1.Size = new System.Drawing.Size(176, 176);
            this.colorUIControl1.TabIndex = 0;
            this.colorUIControl1.Text = "colorUIControl1";
            this.colorUIControl1.UserTabName = "User Colors";
            // 
            // barItem8
            // 
            this.barItem8.CategoryIndex = 1;
            this.barItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem8.ID = "Select &All";
            this.barItem8.Text = "Alle vorwahlen";
            // 
            // parentBarItem5
            // 
            this.parentBarItem5.CategoryIndex = 3;
            this.parentBarItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem5.ID = "&Help";
            this.parentBarItem5.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem9});
            this.parentBarItem5.MergeOrder = 3;
            this.parentBarItem5.Text = "&Hilfe";
            // 
            // barItem9
            // 
            this.barItem9.CategoryIndex = 2;
            this.barItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem9.ID = "A&bout...";
            this.barItem9.Text = "Uber...";
            // 
            // windowItem
            // 
            this.windowItem.CategoryIndex = 2;
            this.windowItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowItem.ID = "&Window";
            this.windowItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.mdiListBarItem1});
            this.windowItem.MergeOrder = 2;
            this.windowItem.Text = "Fenster";
            // 
            // mdiListBarItem1
            // 
            this.mdiListBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiListBarItem1.ID = "Window List";
            // 
            // bar2
            // 
            this.bar2.BarName = "Standard";
            this.bar2.Caption = "Standard";
            this.bar2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3});
            this.bar2.Manager = this.mainFrameBarManager1;
            this.bar2.SeparatorIndices.AddRange(new int[] {
            2});
            // 
            // menuList
            // 
            this.menuList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuList.ImageStream")));
            this.menuList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuList.Images.SetKeyName(0, "");
            this.menuList.Images.SetKeyName(1, "");
            this.menuList.Images.SetKeyName(2, "");
            this.menuList.Images.SetKeyName(3, "");
            this.menuList.Images.SetKeyName(4, "");
            this.menuList.Images.SetKeyName(5, "");
            this.menuList.Images.SetKeyName(6, "");
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.ID = "Item";
            this.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.parentBarItem1.Text = "Item";
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.ID = "ParentBarItem";
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.parentBarItem2.Text = "Window";
            // 
            // groupBar1
            // 
            this.groupBar1.AllowDrop = true;
            this.groupBar1.AnimatedSelection = false;
            this.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(77)))), ((int)(((byte)(140)))));
            this.groupBar1.GroupBarItemCursor = System.Windows.Forms.Cursors.Hand;
            this.groupBar1.GroupBarItemHeight = 30;
            this.groupBar1.GroupBarItems.AddRange(new Syncfusion.Windows.Forms.Tools.GroupBarItem[] {
            this.groupBarItem1,
            this.groupBarItem2,
            this.groupBarItem3});
            this.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(65)))), ((int)(((byte)(140)))));
            this.groupBar1.Location = new System.Drawing.Point(0, 51);
            this.groupBar1.Name = "groupBar1";
            this.groupBar1.SelectedItem = 2;
            this.groupBar1.Size = new System.Drawing.Size(192, 427);
            this.groupBar1.StackedMode = true;
            this.groupBar1.TabIndex = 4;
            this.groupBar1.Text = "groupBar1";
            this.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left;
            this.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // groupBarItem1
            // 
            this.groupBarItem1.Client = null;
            this.groupBarItem1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBarItem1.Text = "Journal";
            // 
            // groupBarItem2
            // 
            this.groupBarItem2.Client = null;
            this.groupBarItem2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBarItem2.Text = "Kalender";
            // 
            // groupBarItem3
            // 
            this.groupBarItem3.Client = null;
            this.groupBarItem3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBarItem3.Text = "Kontakte";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(688, 478);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.groupBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Lokalisation-Demo ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockingManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupBar1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
		ProcessStartInfo pstart = new ProcessStartInfo("run.bat");
            pstart.UseShellExecute = false;
            //Hide DOS window
            pstart.CreateNoWindow = true;
            Process.Start(pstart);
			Application.Run(new Form1());
		}

		private void barItem1_Click(object sender, System.EventArgs e)
		{
			Child frm = new Child();
			frm.MdiParent = this;
			frm.Text = "Dokument " + count.ToString();
			frm.Show();
			count++;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			Child frm = new Child();
			frm.MdiParent = this;
			frm.Text = "Dokument " + count.ToString();
			frm.Show();
			count++;
		}

        private void barItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

	}
}
