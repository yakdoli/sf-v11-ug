using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools.XPMenus;
using Microsoft.Win32;

namespace nesteddockinglayout
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 :Syncfusion.Windows.Forms.Office2007Form

	{
		#region Variable declaration

		private bool bNestedTab;
		private nesteddockinglayout.UserControl1 userControl11;
		private nesteddockinglayout.UserControl1 userControl12;
		private DockingManager dm;
		private MainFrameBarManager mfb;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem pbiFile;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biExit;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem pbiVisualStyle;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem pbiVSOuterLayout;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSILDefault;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSILWindowsXP;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSILOffice2003;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem pbiVSInnerLayout;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSOLDefault;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSOLWindowsXP;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSOLOffice2003;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem pbiDragProviderStyle;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biNestedTabOnOff;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem pbiDPSInnerLayout;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem pbiDPSOuterLayout;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biDPSILStandard;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biDPSILVS2005;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biDPSILWhidbey;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biDPSOLStandard;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biDPSOLVS2005;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biDPSOLWhidbey;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSILVS2005;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSILOffice2007;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSOLVS2005;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem biVSOLOffice2007;
		private System.ComponentModel.IContainer components;

		#endregion

		#region VS Form code ( Constructor , Initialization and Disposing )

		public Form1()
		{
			
			InitializeComponent();

        }

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
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbuserControl11 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection ccbuserControl12 = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
            this.dm = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
            this.userControl11 = new nesteddockinglayout.UserControl1();
            this.userControl12 = new nesteddockinglayout.UserControl1();
            this.mfb = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mfb, "Main");
            this.pbiFile = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biExit = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pbiVisualStyle = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.pbiVSOuterLayout = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biVSILDefault = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biVSILWindowsXP = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biVSILOffice2003 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biVSILOffice2007 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biVSILVS2005 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pbiVSInnerLayout = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biVSOLDefault = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biVSOLWindowsXP = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biVSOLOffice2003 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biVSOLOffice2007 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biVSOLVS2005 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pbiDragProviderStyle = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.pbiDPSInnerLayout = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biDPSILStandard = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biDPSILVS2005 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biDPSILWhidbey = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pbiDPSOuterLayout = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.biDPSOLStandard = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biDPSOLVS2005 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biDPSOLWhidbey = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.biNestedTabOnOff = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfb)).BeginInit();
            this.SuspendLayout();
            // 
            // dm
            // 
            this.dm.AutoHideTabFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dm.DockLayoutStream = ((System.IO.MemoryStream)(resources.GetObject("dm.DockLayoutStream")));
            this.dm.DockTabFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.dm.HostControl = this;
            this.dm.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dm.DockAllow += new Syncfusion.Windows.Forms.Tools.DockAllowEventHandler(this.dm_DockAllow);
            this.dm.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"));
            this.dm.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"));
            this.dm.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"));
            this.dm.CaptionButtons.Add(new Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"));
            this.dm.SetDockLabel(this.userControl11, "Color Panel 1");
            ccbuserControl11.MergeWith(this.dm.CaptionButtons, false);
            this.dm.SetCustomCaptionButtons(this.userControl11, ccbuserControl11);
            this.dm.SetDockLabel(this.userControl12, "Color Panel 2");
            ccbuserControl12.MergeWith(this.dm.CaptionButtons, false);
            this.dm.SetCustomCaptionButtons(this.userControl12, ccbuserControl12);
            // 
            // userControl11
            // 
            this.dm.SetEnableDocking(this.userControl11, true);
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.userControl11.Location = new System.Drawing.Point(3, 23);
            this.userControl11.Name = "userControl11";
            this.userControl11.NestedTabbing = false;
            this.userControl11.Size = new System.Drawing.Size(354, 395);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.dm.SetEnableDocking(this.userControl12, true);
            this.userControl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.userControl12.Location = new System.Drawing.Point(3, 23);
            this.userControl12.Name = "userControl12";
            this.userControl12.NestedTabbing = false;
            this.userControl12.Size = new System.Drawing.Size(241, 395);
            this.userControl12.TabIndex = 1;
            // 
            // mfb
            // 
            this.mfb.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mfb.BarPositionInfo")));
            this.mfb.Bars.Add(this.bar1);
            this.mfb.Categories.Add("main");
            this.mfb.Categories.Add("file");
            this.mfb.Categories.Add("visualstyle");
            this.mfb.Categories.Add("innerlayout");
            this.mfb.Categories.Add("outerlayout");
            this.mfb.Categories.Add("DragProviderstyle");
            this.mfb.Categories.Add("DInner Layout");
            this.mfb.Categories.Add("DOuter Layout");
            this.mfb.CurrentBaseFormType = "";
            this.mfb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfb.Form = this;
            this.mfb.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biDPSOLVS2005,
            this.pbiVSInnerLayout,
            this.biDPSOLStandard,
            this.biDPSOLWhidbey,
            this.pbiVSOuterLayout,
            this.biVSOLDefault,
            this.pbiFile,
            this.biVSOLWindowsXP,
            this.pbiVisualStyle,
            this.biVSOLOffice2003,
            this.pbiDragProviderStyle,
            this.biVSOLVS2005,
            this.biExit,
            this.biVSOLOffice2007,
            this.biVSILDefault,
            this.biVSILWindowsXP,
            this.biVSILOffice2003,
            this.biNestedTabOnOff,
            this.pbiDPSInnerLayout,
            this.pbiDPSOuterLayout,
            this.biDPSILStandard,
            this.biDPSILVS2005,
            this.biDPSILWhidbey,
            this.biVSILVS2005,
            this.biVSILOffice2007});
            this.mfb.ResetCustomization = false;
            this.mfb.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "Main";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.pbiFile,
            this.pbiVisualStyle,
            this.pbiDragProviderStyle,
            this.biNestedTabOnOff});
            this.bar1.Manager = this.mfb;
            // 
            // pbiFile
            // 
            this.pbiFile.CategoryIndex = 0;
            this.pbiFile.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbiFile.ID = "pbiFile";
            this.pbiFile.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biExit});
            this.pbiFile.Text = "File";
            // 
            // biExit
            // 
            this.biExit.CategoryIndex = 1;
            this.biExit.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biExit.ID = "biExit";
            this.biExit.Text = "Exit";
            this.biExit.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // pbiVisualStyle
            // 
            this.pbiVisualStyle.CategoryIndex = 0;
            this.pbiVisualStyle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbiVisualStyle.ID = "pbiVisualStyle";
            this.pbiVisualStyle.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.pbiVSOuterLayout,
            this.pbiVSInnerLayout});
            this.pbiVisualStyle.Text = "Visual Style";
            // 
            // pbiVSOuterLayout
            // 
            this.pbiVSOuterLayout.CategoryIndex = 2;
            this.pbiVSOuterLayout.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbiVSOuterLayout.ID = "InnerLayout";
            this.pbiVSOuterLayout.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biVSILDefault,
            this.biVSILWindowsXP,
            this.biVSILOffice2003,
            this.biVSILOffice2007,
            this.biVSILVS2005});
            this.pbiVSOuterLayout.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.pbiVSOuterLayout.Text = "Inner Layout";
            // 
            // biVSILDefault
            // 
            this.biVSILDefault.CategoryIndex = 3;
            this.biVSILDefault.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSILDefault.ID = "Default";
            this.biVSILDefault.Text = "Default";
            this.biVSILDefault.Click += new System.EventHandler(this.VS_IL_DefaultMenu_Clcik);
            // 
            // biVSILWindowsXP
            // 
            this.biVSILWindowsXP.CategoryIndex = 3;
            this.biVSILWindowsXP.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSILWindowsXP.ID = "Windows XP themes";
            this.biVSILWindowsXP.Text = "Windows XP Themes";
            this.biVSILWindowsXP.Click += new System.EventHandler(this.VS_IL_OfficeXPMenu_Clcik);
            // 
            // biVSILOffice2003
            // 
            this.biVSILOffice2003.CategoryIndex = 3;
            this.biVSILOffice2003.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSILOffice2003.ID = "Office 2003 Style";
            this.biVSILOffice2003.Text = "Office 2003 Style";
            this.biVSILOffice2003.Click += new System.EventHandler(this.VS_IL_Office2003Menu_Click);
            // 
            // biVSILOffice2007
            // 
            this.biVSILOffice2007.CategoryIndex = 3;
            this.biVSILOffice2007.Checked = true;
            this.biVSILOffice2007.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSILOffice2007.ID = "Office2007";
            this.biVSILOffice2007.Text = "Office 2007 Style";
            this.biVSILOffice2007.Click += new System.EventHandler(this.VS_IL_Office2007Menu_Click);
            // 
            // biVSILVS2005
            // 
            this.biVSILVS2005.CategoryIndex = 3;
            this.biVSILVS2005.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSILVS2005.ID = "VS2005_2";
            this.biVSILVS2005.Text = "VS 2005";
            this.biVSILVS2005.Click += new System.EventHandler(this.VS_IL_VS2005Menu_Click);
            // 
            // pbiVSInnerLayout
            // 
            this.pbiVSInnerLayout.CategoryIndex = 2;
            this.pbiVSInnerLayout.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbiVSInnerLayout.ID = "Outer Layout";
            this.pbiVSInnerLayout.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biVSOLDefault,
            this.biVSOLWindowsXP,
            this.biVSOLOffice2003,
            this.biVSOLOffice2007,
            this.biVSOLVS2005});
            this.pbiVSInnerLayout.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.pbiVSInnerLayout.Text = "Outer Layout";
            // 
            // biVSOLDefault
            // 
            this.biVSOLDefault.CategoryIndex = 4;
            this.biVSOLDefault.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSOLDefault.ID = "Default_1";
            this.biVSOLDefault.Text = "Default";
            this.biVSOLDefault.Click += new System.EventHandler(this.VS_OL_DefaultMenu_Click);
            // 
            // biVSOLWindowsXP
            // 
            this.biVSOLWindowsXP.CategoryIndex = 4;
            this.biVSOLWindowsXP.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSOLWindowsXP.ID = "Windows XP themes_1";
            this.biVSOLWindowsXP.Text = "Windows XP Themes";
            this.biVSOLWindowsXP.Click += new System.EventHandler(this.VS_OL_OfficeXPMenu_Click);
            // 
            // biVSOLOffice2003
            // 
            this.biVSOLOffice2003.CategoryIndex = 4;
            this.biVSOLOffice2003.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSOLOffice2003.ID = "Office 2003 Style_1";
            this.biVSOLOffice2003.Text = "Office 2003 Style";
            this.biVSOLOffice2003.Click += new System.EventHandler(this.VS_OL_Office2003Menu_Click);
            // 
            // biVSOLOffice2007
            // 
            this.biVSOLOffice2007.CategoryIndex = 4;
            this.biVSOLOffice2007.Checked = true;
            this.biVSOLOffice2007.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSOLOffice2007.ID = "Office2007_1";
            this.biVSOLOffice2007.Text = "Office2007 Style";
            this.biVSOLOffice2007.Click += new System.EventHandler(this.VS_OL_Office2007Menu_Click);
            // 
            // biVSOLVS2005
            // 
            this.biVSOLVS2005.CategoryIndex = 4;
            this.biVSOLVS2005.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biVSOLVS2005.ID = "VS2005_3";
            this.biVSOLVS2005.Text = "VS2005";
            this.biVSOLVS2005.Click += new System.EventHandler(this.VS_OL_VS2005Menu_Click);
            // 
            // pbiDragProviderStyle
            // 
            this.pbiDragProviderStyle.CategoryIndex = 0;
            this.pbiDragProviderStyle.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbiDragProviderStyle.ID = "pbiDragProviderStyle";
            this.pbiDragProviderStyle.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.pbiDPSInnerLayout,
            this.pbiDPSOuterLayout});
            this.pbiDragProviderStyle.Text = "Drag Provider Style";
            // 
            // pbiDPSInnerLayout
            // 
            this.pbiDPSInnerLayout.CategoryIndex = 5;
            this.pbiDPSInnerLayout.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbiDPSInnerLayout.ID = "Inner Layout";
            this.pbiDPSInnerLayout.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biDPSILStandard,
            this.biDPSILVS2005,
            this.biDPSILWhidbey});
            this.pbiDPSInnerLayout.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.pbiDPSInnerLayout.Text = "Inner Layout";
            // 
            // biDPSILStandard
            // 
            this.biDPSILStandard.CategoryIndex = 6;
            this.biDPSILStandard.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biDPSILStandard.ID = "Standard";
            this.biDPSILStandard.Text = "Standard";
            this.biDPSILStandard.Click += new System.EventHandler(this.DPS_IL_StandardMenu_Click);
            // 
            // biDPSILVS2005
            // 
            this.biDPSILVS2005.CategoryIndex = 6;
            this.biDPSILVS2005.Checked = true;
            this.biDPSILVS2005.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biDPSILVS2005.ID = "VS2005";
            this.biDPSILVS2005.Text = "VS2005";
            this.biDPSILVS2005.Click += new System.EventHandler(this.DPS_IL_VS2005Menu_Click);
            // 
            // biDPSILWhidbey
            // 
            this.biDPSILWhidbey.CategoryIndex = 6;
            this.biDPSILWhidbey.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biDPSILWhidbey.ID = "Whidbey";
            this.biDPSILWhidbey.Text = "Whidbey";
            this.biDPSILWhidbey.Click += new System.EventHandler(this.DPS_IL_WhidbeyMenu_Click);
            // 
            // pbiDPSOuterLayout
            // 
            this.pbiDPSOuterLayout.CategoryIndex = 5;
            this.pbiDPSOuterLayout.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbiDPSOuterLayout.ID = "Outer Layout_1";
            this.pbiDPSOuterLayout.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.biDPSOLStandard,
            this.biDPSOLVS2005,
            this.biDPSOLWhidbey});
            this.pbiDPSOuterLayout.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            this.pbiDPSOuterLayout.Text = "Outer Layout";
            // 
            // biDPSOLStandard
            // 
            this.biDPSOLStandard.CategoryIndex = 7;
            this.biDPSOLStandard.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biDPSOLStandard.ID = "Standard_1";
            this.biDPSOLStandard.Text = "Standard";
            this.biDPSOLStandard.Click += new System.EventHandler(this.DPS_OL_StandardMenu_Click);
            // 
            // biDPSOLVS2005
            // 
            this.biDPSOLVS2005.CategoryIndex = 7;
            this.biDPSOLVS2005.Checked = true;
            this.biDPSOLVS2005.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biDPSOLVS2005.ID = "VS2005_1";
            this.biDPSOLVS2005.Text = "VS2005";
            this.biDPSOLVS2005.Click += new System.EventHandler(this.DPS_OL_VS2005Menu_Click);
            // 
            // biDPSOLWhidbey
            // 
            this.biDPSOLWhidbey.CategoryIndex = 7;
            this.biDPSOLWhidbey.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biDPSOLWhidbey.ID = "Whidbey_1";
            this.biDPSOLWhidbey.Text = "Whidbey";
            this.biDPSOLWhidbey.Click += new System.EventHandler(this.DPS_OL_WhidbeyMenu_Click);
            // 
            // biNestedTabOnOff
            // 
            this.biNestedTabOnOff.CategoryIndex = 0;
            this.biNestedTabOnOff.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biNestedTabOnOff.ID = "NestedTabbing";
            this.biNestedTabOnOff.Text = "Nested Tabbing OFF";
            this.biNestedTabOnOff.Click += new System.EventHandler(this.NestedOnOffMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(620, 446);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nested Docking Layouts";
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mfb)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}


		#endregion

		#region Properties

		//To assign Nexted tabbing

		public bool NestedTabbing
		{
			get
			{
				return bNestedTab;
			}
			set
			{
				bNestedTab=value;
				if(bNestedTab)
				{
                    if (dm.GetDockVisibility(this.userControl11) && dm.GetDockVisibility(this.userControl12))
                    {

                        dm.LockHostFormUpdate();
                        userControl11.NestedTabbing = true;
                        userControl12.NestedTabbing = true;
                        dm.DockTabAlignment = DockTabAlignmentStyle.Top;
                        dm.DockControl(userControl12, this, DockingStyle.Left, 650);
                        dm.DockControl(userControl11, userControl12, DockingStyle.Tabbed, 650, false);
                        dm.UnlockHostFormUpdate();
                    }
				}
				else
				{
					userControl11.NestedTabbing=false;
					userControl12.NestedTabbing=false;
					
				}
			}
		}
		#endregion

		#region Event Handlers
		// Assigning VisualStyle Default to Outer Layout.
		private void VS_OL_DefaultMenu_Click(object sender, System.EventArgs e)
		{
			dm.VisualStyle=VisualStyle.Default;
			dm.ThemesEnabled=false;
			this.biVSOLDefault.Checked=true;
			this.biVSOLOffice2003.Checked=false;
			this.biVSOLWindowsXP.Checked=false;
			this.biVSOLOffice2007.Checked = false;
			this.biVSOLVS2005.Checked = false;
		}

		// Assigning VisualStyle OfficeXP to Outer Layout.
		private void VS_OL_OfficeXPMenu_Click(object sender, System.EventArgs e)
		{
			dm.VisualStyle=VisualStyle.Default;
			dm.ThemesEnabled=true;
			this.biVSOLDefault.Checked=false;
			this.biVSOLOffice2003.Checked=false;
			this.biVSOLWindowsXP.Checked=true;
			this.biVSOLOffice2007.Checked = false;
			this.biVSOLVS2005.Checked = false;
		}

		// Assigning VisualStyle Office2003 to Outer Layout.
		private void VS_OL_Office2003Menu_Click(object sender, System.EventArgs e)
		{
			dm.VisualStyle=VisualStyle.Office2003 ;
			this.biVSOLDefault.Checked=false;
			this.biVSOLOffice2003.Checked=true;
			this.biVSOLWindowsXP.Checked=false;
			this.biVSOLOffice2007.Checked = false;
			this.biVSOLVS2005.Checked = false;
		}

		private void VS_OL_VS2005Menu_Click(object sender, System.EventArgs e)
		{
			dm.VisualStyle=VisualStyle.VS2005;
			this.biVSOLDefault.Checked=false;
			this.biVSOLOffice2003.Checked=false;
			this.biVSOLWindowsXP.Checked=false;
			this.biVSOLOffice2007.Checked = false;
			this.biVSOLVS2005.Checked = true;
		}

		private void VS_OL_Office2007Menu_Click(object sender, System.EventArgs e)
		{
			dm.VisualStyle=VisualStyle.Office2007;
			this.biVSOLDefault.Checked=false;
			this.biVSOLOffice2003.Checked=false;
			this.biVSOLWindowsXP.Checked=false;
			this.biVSOLOffice2007.Checked = true;
			this.biVSOLVS2005.Checked = false;
		}

		// Assigning VisualStyle Default to Inner Layout.
		private void VS_IL_DefaultMenu_Clcik(object sender, System.EventArgs e)
		{
			userControl11.VisualStyle=VisualStyle.Default;
			userControl11.ThemesEnabled=false;
			userControl12.VisualStyle=VisualStyle.Default;
			userControl12.ThemesEnabled=false;
			biVSILDefault.Checked=true;
			biVSILOffice2003.Checked=false;
			biVSILWindowsXP.Checked=false;
			biVSILOffice2007.Checked = false;
		}

		// Assigning VisualStyle OfficeXP to Inner Layout.
		private void VS_IL_OfficeXPMenu_Clcik(object sender, System.EventArgs e)
		{
			userControl11.VisualStyle=VisualStyle.Default;
			userControl11.ThemesEnabled=true;
			userControl12.VisualStyle=VisualStyle.Default;
			userControl12.ThemesEnabled=true;
			this.biVSILDefault.Checked=false;
			this.biVSILOffice2003.Checked=false;
			this.biVSILWindowsXP.Checked=true;
			this.biVSILOffice2007.Checked = false;
			this.biVSILVS2005.Checked = false;
		}

		// Assigning VisualStyle Office2003 to Inner Layout.
		private void VS_IL_Office2003Menu_Click(object sender, System.EventArgs e)
		{
			userControl11.VisualStyle=VisualStyle.Office2003;
			userControl12.VisualStyle=VisualStyle.Office2003;
			this.biVSILDefault.Checked=false;
			this.biVSILOffice2003.Checked=true;
			this.biVSILWindowsXP.Checked=false;
			this.biVSILOffice2007.Checked = false;
			this.biVSILVS2005.Checked = false;
		}

		private void VS_IL_VS2005Menu_Click(object sender, System.EventArgs e)
		{
			userControl11.VisualStyle=VisualStyle.VS2005;
			userControl12.VisualStyle=VisualStyle.VS2005;
			this.biVSILDefault.Checked=false;
			this.biVSILOffice2003.Checked=false;
			this.biVSILWindowsXP.Checked=false;
			this.biVSILOffice2007.Checked = false;
			this.biVSILVS2005.Checked = true;
		}

		private void VS_IL_Office2007Menu_Click(object sender, System.EventArgs e)
		{
			userControl11.VisualStyle=VisualStyle.Office2007;
			userControl12.VisualStyle=VisualStyle.Office2007;
			this.biVSILDefault.Checked=false;
			this.biVSILOffice2003.Checked=false;
			this.biVSILWindowsXP.Checked=false;
			this.biVSILOffice2007.Checked = true;
			this.biVSILVS2005.Checked = false;
		}

		// Assigning NestedTabb On or Off.
		private void NestedOnOffMenu_Click(object sender, System.EventArgs e)
		{
			if(this.biNestedTabOnOff.Text =="Nested Tabbing OFF")
			{ 
				this.biNestedTabOnOff.Text ="Nested Tabbing ON" ;
				NestedTabbing = true;
			}
			else
			{
				this.biNestedTabOnOff.Text ="Nested Tabbing OFF";
				NestedTabbing = false;
			}
		}

		// Assigning DragProviderStyle Standard to Inner Layout.
		private void DPS_IL_StandardMenu_Click(object sender, System.EventArgs e)
		{
			this.userControl11.DragProviderStyle = DragProviderStyle.Standard;
			this.userControl12.DragProviderStyle = DragProviderStyle.Standard;
			biDPSILStandard.Checked=true;
			biDPSILVS2005.Checked=false;
			biDPSILWhidbey.Checked=false;
		}

		// Assigning DragProviderStyle VS2005 to Inner Layout.
		private void DPS_IL_VS2005Menu_Click(object sender, System.EventArgs e)
		{
			this.userControl11.DragProviderStyle = DragProviderStyle.VS2005;
			this.userControl12.DragProviderStyle = DragProviderStyle.VS2005;
			biDPSILStandard.Checked=false;
			biDPSILVS2005.Checked=true;
			biDPSILWhidbey.Checked=false;
		}

		// Assigning DragProviderStyle Whidbey to Inner Layout.
		private void DPS_IL_WhidbeyMenu_Click(object sender, System.EventArgs e)
		{
			this.userControl11.DragProviderStyle = DragProviderStyle.Whidbey;
			this.userControl12.DragProviderStyle = DragProviderStyle.Whidbey;
			biDPSILStandard.Checked=false;
			biDPSILVS2005.Checked=false;
			biDPSILWhidbey.Checked=true;
		}

		// Assigning DragProviderStyle Standard to Outer Layout.
		private void DPS_OL_StandardMenu_Click(object sender, System.EventArgs e)
		{
			this.dm.DragProviderStyle = DragProviderStyle.Standard;
            this.biDPSOLStandard.Checked = true;
            this.biDPSOLVS2005.Checked = false;
            this.biDPSOLWhidbey.Checked = false;
        }

		// Assigning DragProviderStyle VS2005 to Outer Layout.
		private void DPS_OL_VS2005Menu_Click(object sender, System.EventArgs e)
		{
			this.dm.DragProviderStyle = DragProviderStyle.VS2005;
            this.biDPSOLVS2005.Checked = true;
            this.biDPSOLStandard.Checked = false;
            this.biDPSOLWhidbey.Checked = false;
        }

		// Assigning DragProviderStyle Whidbey to Outer Layout.
		private void DPS_OL_WhidbeyMenu_Click(object sender, System.EventArgs e)
		{
			this.dm.DragProviderStyle = DragProviderStyle.Whidbey;
            this.biDPSOLWhidbey.Checked = true;
            this.biDPSOLStandard.Checked = false;
            this.biDPSOLVS2005.Checked = false;
        }

		// Closing the application.
		private void ExitMenu_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
		private void dm_DockAllow(object sender, Syncfusion.Windows.Forms.Tools.DockAllowEventArgs arg)
		{
			if(this.NestedTabbing && arg.DockStyle !=DockingStyle.Tabbed)
			{
				arg.Cancel =true;
			}
		}
		#endregion

	}
}
