using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace VSDemo
{
	/// <summary>
	/// Summary description for ObjectBrowser.
	/// </summary>
	public class ObjectBrowserView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panel1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem browseBarItem;
		public Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar objectBrowserToolBar;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem sortNameParentBarItem;
		private System.Windows.Forms.ImageList dockingImageList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem sortTypeParentBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem backBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem forwardBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem findSymbolBarItem;
		private System.Windows.Forms.LinkLabel llObjBrowserBottom;
		private System.ComponentModel.IContainer components;

		public ObjectBrowserView()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectBrowserView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.llObjBrowserBottom = new System.Windows.Forms.LinkLabel();
            this.objectBrowserToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.browseBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem();
            this.sortNameParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.sortTypeParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.backBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.forwardBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.findSymbolBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.llObjBrowserBottom);
            this.panel1.Controls.Add(this.objectBrowserToolBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 88);
            this.panel1.TabIndex = 0;
            // 
            // llObjBrowserBottom
            // 
            this.llObjBrowserBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.llObjBrowserBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llObjBrowserBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.llObjBrowserBottom.LinkArea = new System.Windows.Forms.LinkArea(25, 58);
            this.llObjBrowserBottom.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.llObjBrowserBottom.LinkColor = System.Drawing.Color.DarkGreen;
            this.llObjBrowserBottom.Location = new System.Drawing.Point(0, 25);
            this.llObjBrowserBottom.Name = "llObjBrowserBottom";
            this.llObjBrowserBottom.Size = new System.Drawing.Size(696, 63);
            this.llObjBrowserBottom.TabIndex = 1;
            this.llObjBrowserBottom.TabStop = true;
            this.llObjBrowserBottom.Text = "public class RichTextBox: System.Windows.Forms.RichTextBox";
            this.llObjBrowserBottom.UseCompatibleTextRendering = true;
            // 
            // objectBrowserToolBar
            // 
            this.objectBrowserToolBar.BackColor = System.Drawing.Color.Transparent;
            this.objectBrowserToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.objectBrowserToolBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.objectBrowserToolBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.browseBarItem,
            this.sortNameParentBarItem,
            this.sortTypeParentBarItem,
            this.backBarItem,
            this.forwardBarItem,
            this.findSymbolBarItem});
            this.objectBrowserToolBar.Location = new System.Drawing.Point(0, 0);
            this.objectBrowserToolBar.Name = "objectBrowserToolBar";
            this.objectBrowserToolBar.SeparatorIndices.AddRange(new int[] {
            1,
            3});
            this.objectBrowserToolBar.Size = new System.Drawing.Size(696, 25);
            this.objectBrowserToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.objectBrowserToolBar.TabIndex = 0;
            // 
            // browseBarItem
            // 
            this.browseBarItem.ID = "Select ";
            this.browseBarItem.MinWidth = 100;
            this.browseBarItem.Text = "Select Component";
            // 
            // sortNameParentBarItem
            // 
            this.sortNameParentBarItem.ImageIndex = 26;
            this.sortNameParentBarItem.ImageList = this.dockingImageList;
            this.sortNameParentBarItem.ParentStyle = Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItemStyle.DropDown;
            this.sortNameParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            // 
            // dockingImageList
            // 
            this.dockingImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("dockingImageList.ImageStream")));
            this.dockingImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.dockingImageList.Images.SetKeyName(0, "");
            this.dockingImageList.Images.SetKeyName(1, "");
            this.dockingImageList.Images.SetKeyName(2, "");
            this.dockingImageList.Images.SetKeyName(3, "");
            this.dockingImageList.Images.SetKeyName(4, "");
            this.dockingImageList.Images.SetKeyName(5, "");
            this.dockingImageList.Images.SetKeyName(6, "");
            this.dockingImageList.Images.SetKeyName(7, "");
            this.dockingImageList.Images.SetKeyName(8, "");
            this.dockingImageList.Images.SetKeyName(9, "");
            this.dockingImageList.Images.SetKeyName(10, "");
            this.dockingImageList.Images.SetKeyName(11, "");
            this.dockingImageList.Images.SetKeyName(12, "");
            this.dockingImageList.Images.SetKeyName(13, "");
            this.dockingImageList.Images.SetKeyName(14, "");
            this.dockingImageList.Images.SetKeyName(15, "");
            this.dockingImageList.Images.SetKeyName(16, "");
            this.dockingImageList.Images.SetKeyName(17, "");
            this.dockingImageList.Images.SetKeyName(18, "");
            this.dockingImageList.Images.SetKeyName(19, "");
            this.dockingImageList.Images.SetKeyName(20, "");
            this.dockingImageList.Images.SetKeyName(21, "");
            this.dockingImageList.Images.SetKeyName(22, "");
            this.dockingImageList.Images.SetKeyName(23, "");
            this.dockingImageList.Images.SetKeyName(24, "");
            this.dockingImageList.Images.SetKeyName(25, "");
            this.dockingImageList.Images.SetKeyName(26, "");
            this.dockingImageList.Images.SetKeyName(27, "");
            this.dockingImageList.Images.SetKeyName(28, "");
            this.dockingImageList.Images.SetKeyName(29, "");
            this.dockingImageList.Images.SetKeyName(30, "");
            this.dockingImageList.Images.SetKeyName(31, "");
            this.dockingImageList.Images.SetKeyName(32, "");
            this.dockingImageList.Images.SetKeyName(33, "");
            this.dockingImageList.Images.SetKeyName(34, "");
            this.dockingImageList.Images.SetKeyName(35, "");
            this.dockingImageList.Images.SetKeyName(36, "");
            this.dockingImageList.Images.SetKeyName(37, "");
            this.dockingImageList.Images.SetKeyName(38, "");
            this.dockingImageList.Images.SetKeyName(39, "");
            this.dockingImageList.Images.SetKeyName(40, "");
            this.dockingImageList.Images.SetKeyName(41, "");
            this.dockingImageList.Images.SetKeyName(42, "");
            this.dockingImageList.Images.SetKeyName(43, "");
            this.dockingImageList.Images.SetKeyName(44, "");
            this.dockingImageList.Images.SetKeyName(45, "");
            this.dockingImageList.Images.SetKeyName(46, "");
            this.dockingImageList.Images.SetKeyName(47, "");
            this.dockingImageList.Images.SetKeyName(48, "");
            this.dockingImageList.Images.SetKeyName(49, "");
            this.dockingImageList.Images.SetKeyName(50, "");
            this.dockingImageList.Images.SetKeyName(51, "");
            this.dockingImageList.Images.SetKeyName(52, "");
            this.dockingImageList.Images.SetKeyName(53, "");
            this.dockingImageList.Images.SetKeyName(54, "");
            this.dockingImageList.Images.SetKeyName(55, "");
            this.dockingImageList.Images.SetKeyName(56, "");
            this.dockingImageList.Images.SetKeyName(57, "");
            this.dockingImageList.Images.SetKeyName(58, "");
            this.dockingImageList.Images.SetKeyName(59, "");
            this.dockingImageList.Images.SetKeyName(60, "");
            this.dockingImageList.Images.SetKeyName(61, "");
            this.dockingImageList.Images.SetKeyName(62, "");
            this.dockingImageList.Images.SetKeyName(63, "");
            this.dockingImageList.Images.SetKeyName(64, "");
            this.dockingImageList.Images.SetKeyName(65, "");
            this.dockingImageList.Images.SetKeyName(66, "");
            this.dockingImageList.Images.SetKeyName(67, "");
            this.dockingImageList.Images.SetKeyName(68, "");
            this.dockingImageList.Images.SetKeyName(69, "");
            this.dockingImageList.Images.SetKeyName(70, "");
            this.dockingImageList.Images.SetKeyName(71, "");
            this.dockingImageList.Images.SetKeyName(72, "");
            this.dockingImageList.Images.SetKeyName(73, "");
            this.dockingImageList.Images.SetKeyName(74, "");
            this.dockingImageList.Images.SetKeyName(75, "");
            this.dockingImageList.Images.SetKeyName(76, "");
            this.dockingImageList.Images.SetKeyName(77, "");
            this.dockingImageList.Images.SetKeyName(78, "");
            // 
            // sortTypeParentBarItem
            // 
            this.sortTypeParentBarItem.ImageIndex = 36;
            this.sortTypeParentBarItem.ImageList = this.dockingImageList;
            this.sortTypeParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP;
            // 
            // backBarItem
            // 
            this.backBarItem.ImageIndex = 39;
            this.backBarItem.ImageList = this.dockingImageList;
            // 
            // forwardBarItem
            // 
            this.forwardBarItem.ImageIndex = 40;
            this.forwardBarItem.ImageList = this.dockingImageList;
            // 
            // findSymbolBarItem
            // 
            this.findSymbolBarItem.ImageIndex = 41;
            this.findSymbolBarItem.ImageList = this.dockingImageList;
            // 
            // ObjectBrowserView
            // 
            this.Controls.Add(this.panel1);
            this.Name = "ObjectBrowserView";
            this.Size = new System.Drawing.Size(696, 88);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
	}
}
