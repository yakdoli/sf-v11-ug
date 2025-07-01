using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace VSDemo
{
	/// <summary>
	/// Summary description for SolutionExplorer.
	/// </summary>
	public class SolutionExplorerView : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel panelSolutionExplorer;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem viewCodeBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem viewDesignerBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem refreshBarItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem showAllFilesBarItem;
		private System.Windows.Forms.ImageList dockingImageList;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem propertiesBarItem;
		private System.Windows.Forms.TreeView tvSolutionExp;
		public Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar solutionExplorerToolBar;
		private System.ComponentModel.IContainer components;

		public SolutionExplorerView()
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Solution \'ConsoleApplication1\' (1 Project)", 31, 31);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("System", 67, 67);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("System.Data", 67, 67);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("System.Windows.Forms", 67, 67);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("References", 62, 62, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("App.ico", 64, 64);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("AssemblyInfo.cs", 63, 63);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Class1.cs", 63, 63);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ConsoleApplication", 79, 79, new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionExplorerView));
            this.panelSolutionExplorer = new System.Windows.Forms.Panel();
            this.tvSolutionExp = new System.Windows.Forms.TreeView();
            this.dockingImageList = new System.Windows.Forms.ImageList(this.components);
            this.solutionExplorerToolBar = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.viewCodeBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.viewDesignerBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.refreshBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.showAllFilesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.propertiesBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.panelSolutionExplorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSolutionExplorer
            // 
            this.panelSolutionExplorer.Controls.Add(this.tvSolutionExp);
            this.panelSolutionExplorer.Controls.Add(this.solutionExplorerToolBar);
            this.panelSolutionExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSolutionExplorer.Location = new System.Drawing.Point(0, 0);
            this.panelSolutionExplorer.Name = "panelSolutionExplorer";
            this.panelSolutionExplorer.Size = new System.Drawing.Size(176, 328);
            this.panelSolutionExplorer.TabIndex = 0;
            // 
            // tvSolutionExp
            // 
            this.tvSolutionExp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSolutionExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvSolutionExp.HideSelection = false;
            this.tvSolutionExp.ImageIndex = 0;
            this.tvSolutionExp.ImageList = this.dockingImageList;
            this.tvSolutionExp.Location = new System.Drawing.Point(0, 25);
            this.tvSolutionExp.Name = "tvSolutionExp";
            treeNode1.ImageIndex = 31;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 31;
            treeNode1.Text = "Solution \'ConsoleApplication1\' (1 Project)";
            treeNode2.ImageIndex = 67;
            treeNode2.Name = "";
            treeNode2.SelectedImageIndex = 67;
            treeNode2.Text = "System";
            treeNode3.ImageIndex = 67;
            treeNode3.Name = "";
            treeNode3.SelectedImageIndex = 67;
            treeNode3.Text = "System.Data";
            treeNode4.ImageIndex = 67;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 67;
            treeNode4.Text = "System.Windows.Forms";
            treeNode5.ImageIndex = 62;
            treeNode5.Name = "";
            treeNode5.SelectedImageIndex = 62;
            treeNode5.Text = "References";
            treeNode6.ImageIndex = 64;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 64;
            treeNode6.Text = "App.ico";
            treeNode7.ImageIndex = 63;
            treeNode7.Name = "";
            treeNode7.SelectedImageIndex = 63;
            treeNode7.Text = "AssemblyInfo.cs";
            treeNode8.ImageIndex = 63;
            treeNode8.Name = "";
            treeNode8.SelectedImageIndex = 63;
            treeNode8.Text = "Class1.cs";
            treeNode9.ImageIndex = 79;
            treeNode9.Name = "";
            treeNode9.SelectedImageIndex = 79;
            treeNode9.Text = "ConsoleApplication";
            this.tvSolutionExp.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode9});
            this.tvSolutionExp.SelectedImageIndex = 0;
            this.tvSolutionExp.Size = new System.Drawing.Size(176, 303);
            this.tvSolutionExp.TabIndex = 2;
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
            this.dockingImageList.Images.SetKeyName(79, "");
            // 
            // solutionExplorerToolBar
            // 
            this.solutionExplorerToolBar.BackColor = System.Drawing.Color.Transparent;
            this.solutionExplorerToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.solutionExplorerToolBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.viewCodeBarItem,
            this.viewDesignerBarItem,
            this.refreshBarItem,
            this.showAllFilesBarItem,
            this.propertiesBarItem});
            this.solutionExplorerToolBar.Location = new System.Drawing.Point(0, 0);
            this.solutionExplorerToolBar.Name = "solutionExplorerToolBar";
            this.solutionExplorerToolBar.SeparatorIndices.AddRange(new int[] {
            2,
            4});
            this.solutionExplorerToolBar.Size = new System.Drawing.Size(176, 25);
            this.solutionExplorerToolBar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.solutionExplorerToolBar.TabIndex = 0;
            // 
            // viewCodeBarItem
            // 
            this.viewCodeBarItem.ImageIndex = 4;
            this.viewCodeBarItem.ImageList = this.dockingImageList;
            // 
            // viewDesignerBarItem
            // 
            this.viewDesignerBarItem.ImageIndex = 5;
            this.viewDesignerBarItem.ImageList = this.dockingImageList;
            // 
            // refreshBarItem
            // 
            this.refreshBarItem.ImageIndex = 6;
            this.refreshBarItem.ImageList = this.dockingImageList;
            // 
            // showAllFilesBarItem
            // 
            this.showAllFilesBarItem.ImageIndex = 7;
            this.showAllFilesBarItem.ImageList = this.dockingImageList;
            this.showAllFilesBarItem.UpdateUIOnAppIdle = true;
            // 
            // propertiesBarItem
            // 
            this.propertiesBarItem.ImageIndex = 8;
            this.propertiesBarItem.ImageList = this.dockingImageList;
            // 
            // SolutionExplorerView
            // 
            this.Controls.Add(this.panelSolutionExplorer);
            this.Name = "SolutionExplorerView";
            this.Size = new System.Drawing.Size(176, 328);
            this.panelSolutionExplorer.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
	}
}
