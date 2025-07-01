using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace VSDemo
{
	/// <summary>
	/// Summary description for ClassView.
	/// </summary>
	public class ClassView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panelClassView;
		public Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar classViewToolBar;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem sortBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem newFolderBarItem;
		private System.Windows.Forms.ImageList dockingImageList;
		private System.Windows.Forms.TreeView tvClassView;
		private System.ComponentModel.IContainer components;

		public ClassView()
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("MainForm()", 72, 72);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Dispose(bool)", 70, 71);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("InitializeComponent()", 70, 70);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("components", 73, 73);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Program", 69, 69, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ConsoleApplication", 68, 68, new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ConsoleApplication1", 61, 61, new System.Windows.Forms.TreeNode[] {
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassView));
            this.panelClassView = new System.Windows.Forms.Panel();
            this.tvClassView = new System.Windows.Forms.TreeView();
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.classViewToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.sortBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.newFolderBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panelClassView.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClassView
            // 
            this.panelClassView.Controls.Add(this.tvClassView);
            this.panelClassView.Controls.Add(this.classViewToolBar);
            this.panelClassView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClassView.Location = new System.Drawing.Point(0, 0);
            this.panelClassView.Name = "panelClassView";
            this.panelClassView.Size = new System.Drawing.Size(184, 568);
            this.panelClassView.TabIndex = 0;
            // 
            // tvClassView
            // 
            this.tvClassView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvClassView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tvClassView.ImageIndex = 0;
            this.tvClassView.ImageList = this.dockingImageList;
            this.tvClassView.Location = new System.Drawing.Point(0, 25);
            this.tvClassView.Name = "tvClassView";
            treeNode1.ImageIndex = 72;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 72;
            treeNode1.Text = "MainForm()";
            treeNode2.ImageIndex = 70;
            treeNode2.Name = "";
            treeNode2.SelectedImageIndex = 71;
            treeNode2.Text = "Dispose(bool)";
            treeNode3.ImageIndex = 70;
            treeNode3.Name = "";
            treeNode3.SelectedImageIndex = 70;
            treeNode3.Text = "InitializeComponent()";
            treeNode4.ImageIndex = 73;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 73;
            treeNode4.Text = "components";
            treeNode5.ImageIndex = 69;
            treeNode5.Name = "";
            treeNode5.SelectedImageIndex = 69;
            treeNode5.Text = "Program";
            treeNode6.ImageIndex = 68;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 68;
            treeNode6.Text = "ConsoleApplication";
            treeNode7.ImageIndex = 61;
            treeNode7.Name = "";
            treeNode7.SelectedImageIndex = 61;
            treeNode7.Text = "ConsoleApplication1";
            this.tvClassView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.tvClassView.SelectedImageIndex = 0;
            this.tvClassView.Size = new System.Drawing.Size(184, 543);
            this.tvClassView.TabIndex = 30;
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
            // classViewToolBar
            // 
            this.classViewToolBar.BackColor = System.Drawing.Color.Transparent;
            this.classViewToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.classViewToolBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.sortBarItem,
            this.newFolderBarItem});
            this.classViewToolBar.Location = new System.Drawing.Point(0, 0);
            this.classViewToolBar.Name = "classViewToolBar";
            this.classViewToolBar.Size = new System.Drawing.Size(184, 25);
            this.classViewToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.classViewToolBar.TabIndex = 0;
            // 
            // sortBarItem
            // 
            this.sortBarItem.ImageIndex = 36;
            this.sortBarItem.ImageList = this.dockingImageList;
            this.sortBarItem.UpdateUIOnAppIdle = true;
            // 
            // newFolderBarItem
            // 
            this.newFolderBarItem.ImageIndex = 37;
            this.newFolderBarItem.ImageList = this.dockingImageList;
            // 
            // ClassView
            // 
            this.Controls.Add(this.panelClassView);
            this.Name = "ClassView";
            this.Size = new System.Drawing.Size(184, 568);
            this.panelClassView.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
	}
}
