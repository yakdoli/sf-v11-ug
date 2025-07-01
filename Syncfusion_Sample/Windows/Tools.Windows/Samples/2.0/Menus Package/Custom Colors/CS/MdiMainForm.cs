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
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace Tutorial
{
	/// <summary>
	/// Summary description for MdiMainForm.
	/// </summary>
	public class MdiMainForm : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.ImageList largeImageList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem newItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cascadeItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem tileHorz;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem tileVert;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem mdiListBarItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem closeItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar mainMenuBar;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar standardBar;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem StylebarItem;
		private System.ComponentModel.IContainer components;

		public MdiMainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			SetGradientColors();
			DrawBackground();

			// To draw the background underneath bars.
			this.mainFrameBarManager1.DrawDockBarBackground += new DockBarPaintEventHandler(mainFrameBarManager1_DrawDockBarBackground);
            this.mainFrameBarManager1.RegisterMdiChildTypes(new Type[] { typeof(MdiChildForm) });
			//
			// TODO: Add any constructor code after InitializeComponent call
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiMainForm));
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.mainMenuBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "MainMenu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.newItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.closeItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.cascadeItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tileHorz = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.tileVert = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.mdiListBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem();
            this.standardBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Standard");
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.StylebarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.mainMenuBar);
            this.mainFrameBarManager1.Bars.Add(this.standardBar);
            this.mainFrameBarManager1.Categories.Add("File");
            this.mainFrameBarManager1.Categories.Add("Window");
            this.mainFrameBarManager1.Categories.Add("Popups");
            this.mainFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.ImageList = this.imageList;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.newItem,
            this.cascadeItem,
            this.tileHorz,
            this.tileVert,
            this.parentBarItem1,
            this.parentBarItem2,
            this.mdiListBarItem1,
            this.closeItem,
            this.StylebarItem});
            this.mainFrameBarManager1.LargeImageList = this.largeImageList;
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.BarName = "MainMenu";
            this.mainMenuBar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)));
            this.mainMenuBar.Caption = "MainMenu";
            this.mainMenuBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.parentBarItem2});
            this.mainMenuBar.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.CategoryIndex = 2;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.newItem,
            this.closeItem});
            this.parentBarItem1.SeparatorIndices.AddRange(new int[] {
            1});
            this.parentBarItem1.Text = "&File";
            // 
            // newItem
            // 
            this.newItem.CategoryIndex = 0;
            this.newItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newItem.ID = "New";
            this.newItem.ImageIndex = 1;
            this.newItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.newItem.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
            this.newItem.Text = "New";
            this.newItem.Click += new System.EventHandler(this.newItem_Click);
            // 
            // closeItem
            // 
            this.closeItem.CategoryIndex = 0;
            this.closeItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeItem.ID = "Close";
            this.closeItem.MergeOrder = 4;
            this.closeItem.Text = "Close";
            this.closeItem.Click += new System.EventHandler(this.closeItem_Click);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.CategoryIndex = 2;
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.ID = "&Window";
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.cascadeItem,
            this.tileHorz,
            this.tileVert,
            this.mdiListBarItem1});
            this.parentBarItem2.MergeOrder = 20;
            this.parentBarItem2.SeparatorIndices.AddRange(new int[] {
            3});
            this.parentBarItem2.Text = "&Window";
            // 
            // cascadeItem
            // 
            this.cascadeItem.CategoryIndex = 1;
            this.cascadeItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cascadeItem.ID = "Cascade";
            this.cascadeItem.ImageIndex = 3;
            this.cascadeItem.Text = "Cascade";
            this.cascadeItem.Click += new System.EventHandler(this.cascadeItem_Click);
            // 
            // tileHorz
            // 
            this.tileHorz.CategoryIndex = 1;
            this.tileHorz.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileHorz.ID = "Tile";
            this.tileHorz.ImageIndex = 4;
            this.tileHorz.Text = "Tile Horizontal";
            this.tileHorz.Click += new System.EventHandler(this.tileHorz_Click);
            // 
            // tileVert
            // 
            this.tileVert.CategoryIndex = 1;
            this.tileVert.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileVert.ID = "Tile Vertical";
            this.tileVert.ImageIndex = 5;
            this.tileVert.Text = "Tile Vertical";
            this.tileVert.Click += new System.EventHandler(this.tileVert_Click);
            // 
            // mdiListBarItem1
            // 
            this.mdiListBarItem1.CategoryIndex = 1;
            this.mdiListBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdiListBarItem1.ID = "Window List";
            // 
            // standardBar
            // 
            this.standardBar.BarName = "Standard";
            this.standardBar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)));
            this.standardBar.Caption = "Standard";
            this.standardBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.newItem});
            this.standardBar.Manager = this.mainFrameBarManager1;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "");
            this.imageList.Images.SetKeyName(1, "");
            this.imageList.Images.SetKeyName(2, "");
            this.imageList.Images.SetKeyName(3, "");
            this.imageList.Images.SetKeyName(4, "");
            this.imageList.Images.SetKeyName(5, "");
            // 
            // StylebarItem
            // 
            this.StylebarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StylebarItem.ID = "_1";
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "");
            this.largeImageList.Images.SetKeyName(1, "");
            this.largeImageList.Images.SetKeyName(2, "");
            // 
            // MdiMainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(624, 446);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MdiMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Colors";
            this.Load += new System.EventHandler(this.MdiMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MdiMainForm());
		}

		#region Click events
		int count = 1;
		private void newItem_Click(object sender, System.EventArgs e)
		{
			MdiChildForm childForm1 = new MdiChildForm();
			childForm1.Text = "Child " + count.ToString();
			childForm1.MdiParent = this;
			childForm1.Closed+= new EventHandler(child_closing);
			childForm1.Show();
			count++;

			DrawBackground();
		}

		private void child_closing(object sender, System.EventArgs e)
		{
			DrawBackground();
		}

		private void tileHorz_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void tileVert_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void cascadeItem_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		#endregion

		#region Colors
		private void SetGradientColors()
		{
			MenuColors.SelColor            = Color.FromArgb(179, 71, 59);
			MenuColors.SelTextColor        = Color.White;
			MenuColors.SelBorderColor      = Color.FromArgb(183, 214, 242);
			MenuColors.MenuBGColor         = Color.White;
			MenuColors.MenuLeftStripColor  = Color.White;
			MenuColors.DropDownBorderColor = Color.FromArgb(166, 205, 226);
			MenuColors.PressedSelColor     = Color.FromArgb(166, 201, 232);
			MenuColors.CheckedSelColor     = Color.FromArgb(215, 236, 255);
			MenuColors.FloatingCommandBarCaptionColor = Color.FromArgb(183, 214, 242);
		}

		private void DrawBackground()
		{
			foreach (Bar bar in mainFrameBarManager1.Bars)
			{
				bar.DrawBackground += new PaintEventHandler(bar_DrawBackground);
			}
		}
		
		#endregion
		
		#region DrawEvents
		private void bar_DrawBackground(object sender, PaintEventArgs e)
		{
			Bar bar = (Bar)sender;
			Rectangle rect = e.ClipRectangle;

            Bar _bar = mainFrameBarManager1.GetMergedEquivalent(bar, bar);
            CommandBarExt commandBarExt = (CommandBarExt)mainFrameBarManager1.GetBarControl(_bar);
			if(bar.BarName == "Standard")
				commandBarExt.BackColor = Color.FromArgb(169,192,236);
			else
				commandBarExt.BackColor = SystemColors.ControlLight;
		
			e.Graphics.FillRectangle(new SolidBrush(SystemColors.ControlLight), rect);
		}

		private void mainFrameBarManager1_DrawDockBarBackground(object sender, DockBarPaintEventArgs args)
		{
			//args.PaintEventArgs.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(169, 192,236)), args.PaintEventArgs.ClipRectangle);
		}
		#endregion

		# region MdiClient color
		private void MdiMainForm_Load(object sender, System.EventArgs e)
		{
            MdiChildForm form = new MdiChildForm();
            form.MdiParent = this;
            form.Show();

            DrawBackground();
		}
		#endregion

        private void closeItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
	
	}
}
