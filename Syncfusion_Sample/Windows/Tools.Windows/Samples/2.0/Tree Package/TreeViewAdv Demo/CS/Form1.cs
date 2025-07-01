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

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace TreeViewAdvDemo
{
	#region Class Form1 Description
	
	public class Form1 : Office2007Form
	{
		#region Variable Declaration
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
		private System.Windows.Forms.ImageList stateImageList;
		private System.Windows.Forms.ImageList leftImageList;
		private System.Windows.Forms.ImageList rightImageList;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem copyItem;
		private System.Windows.Forms.MenuItem cutItem;
		private System.Windows.Forms.MenuItem editItem;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.PropertyGrid pgGrid;
		private System.ComponentModel.IContainer components;
		#endregion

		#region Form Constructor Initialization and Disposing 
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv7 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv8 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv9 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv10 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv11 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv12 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv13 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv14 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv15 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv16 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv17 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv18 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv19 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv20 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv21 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.editItem = new System.Windows.Forms.MenuItem();
            this.copyItem = new System.Windows.Forms.MenuItem();
            this.cutItem = new System.Windows.Forms.MenuItem();
            this.leftImageList = new System.Windows.Forms.ImageList(this.components);
            this.rightImageList = new System.Windows.Forms.ImageList(this.components);
            this.stateImageList = new System.Windows.Forms.ImageList(this.components);
            this.pgGrid = new System.Windows.Forms.PropertyGrid();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AllowDrop = true;
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(211)))), ((int)(((byte)(241))))), System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(241))))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            treeNodeAdvStyleInfo1.NoChildrenImgIndex = -1;
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.ContextMenu = this.contextMenu1;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Left;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(50, 17);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.ItemHeight = 18;
            this.treeViewAdv1.LeftImageList = this.leftImageList;
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.NoChildrenImgIndex = -1;
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.ShowOptionButton = true;
            treeNodeAdv2.Text = "Single";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.ShowOptionButton = true;
            treeNodeAdv3.Text = "Married";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.ShowOptionButton = true;
            treeNodeAdv4.Text = "Married with children";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4});
            treeNodeAdv1.RightImageIndices = new int[] {
        2};
            treeNodeAdv1.Text = "Marital Status";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.Expanded = true;
            treeNodeAdv5.InteractiveCheckBox = true;
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.Optioned = true;
            treeNodeAdv6.ShowCheckBox = true;
            treeNodeAdv6.Text = "Hepatitis B";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.ShowCheckBox = true;
            treeNodeAdv7.Text = "Tetanus";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.ShowCheckBox = true;
            treeNodeAdv8.Text = "Polio ";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.ShowCheckBox = true;
            treeNodeAdv9.Text = "Measles";
            treeNodeAdv5.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv6,
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9});
            treeNodeAdv5.RightImageIndices = new int[] {
        6};
            treeNodeAdv5.ShowCheckBox = true;
            treeNodeAdv5.Text = "Baby Vaccines";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.Expanded = true;
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.LeftImageIndices = new int[] {
        0};
            treeNodeAdv11.Optioned = true;
            treeNodeAdv11.Text = "Canada";
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.LeftImageIndices = new int[] {
        1};
            treeNodeAdv12.Text = "France";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.LeftImageIndices = new int[] {
        2};
            treeNodeAdv13.Text = "Germany";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.LeftImageIndices = new int[] {
        3};
            treeNodeAdv14.Text = "UK";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.LeftImageIndices = new int[] {
        4};
            treeNodeAdv15.Text = "USA";
            treeNodeAdv10.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15});
            treeNodeAdv10.RightImageIndices = new int[] {
        7};
            treeNodeAdv10.Text = "Country Information";
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.Expanded = true;
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.Optioned = true;
            treeNodeAdv17.RightImageIndices = new int[] {
        4,
        4,
        4,
        4};
            treeNodeAdv17.Text = "Finding Nemo";
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.RightImageIndices = new int[] {
        4,
        4,
        4,
        4};
            treeNodeAdv18.Text = "Lord Of the Rings";
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.RightImageIndices = new int[] {
        4,
        4};
            treeNodeAdv19.Text = "Matrix Reloaded";
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.RightImageIndices = new int[] {
        4,
        4,
        4};
            treeNodeAdv20.Text = "T3";
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.RightImageIndices = new int[] {
        4,
        4,
        4,
        4};
            treeNodeAdv21.Text = "Sea Biscuit";
            treeNodeAdv16.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv17,
            treeNodeAdv18,
            treeNodeAdv19,
            treeNodeAdv20,
            treeNodeAdv21});
            treeNodeAdv16.RightImageIndices = new int[] {
        5};
            treeNodeAdv16.Text = "Top 2003 Movies";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv5,
            treeNodeAdv10,
            treeNodeAdv16});
            this.treeViewAdv1.PathSeparator = "/";
            this.treeViewAdv1.RightImageList = this.rightImageList;
            this.treeViewAdv1.Size = new System.Drawing.Size(234, 390);
            this.treeViewAdv1.StateImageList = this.stateImageList;
            this.treeViewAdv1.TabIndex = 0;
            this.treeViewAdv1.Text = "treeViewAdv1";
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(642, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 17);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            this.treeViewAdv1.NodeEditorValidating += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvCancelableEditEventHandler(this.treeViewAdv1_NodeEditorValidating);
            this.treeViewAdv1.BeforeEdit += new Syncfusion.Windows.Forms.Tools.TreeViewAdvBeforeEditEventHandler(this.treeViewAdv1_BeforeEdit);
            this.treeViewAdv1.NodeEditorValidated += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvEditEventHandler(this.treeViewAdv1_NodeEditorValidated);
            this.treeViewAdv1.AfterCheck += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvEventHandler(this.treeViewAdv1_AfterCheck);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.editItem,
            this.copyItem,
            this.cutItem});
            this.contextMenu1.Popup += new System.EventHandler(this.contextMenu1_Popup);
            // 
            // editItem
            // 
            this.editItem.Index = 0;
            this.editItem.Text = "&Edit";
            this.editItem.Click += new System.EventHandler(this.editItem_Click);
            // 
            // copyItem
            // 
            this.copyItem.Index = 1;
            this.copyItem.Text = "&Copy";
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            // 
            // cutItem
            // 
            this.cutItem.Index = 2;
            this.cutItem.Text = "Cu&t";
            this.cutItem.Click += new System.EventHandler(this.cutItem_Click);
            // 
            // leftImageList
            // 
            this.leftImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("leftImageList.ImageStream")));
            this.leftImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.leftImageList.Images.SetKeyName(0, "");
            this.leftImageList.Images.SetKeyName(1, "");
            this.leftImageList.Images.SetKeyName(2, "");
            this.leftImageList.Images.SetKeyName(3, "");
            this.leftImageList.Images.SetKeyName(4, "");
            // 
            // rightImageList
            // 
            this.rightImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("rightImageList.ImageStream")));
            this.rightImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.rightImageList.Images.SetKeyName(0, "");
            this.rightImageList.Images.SetKeyName(1, "");
            this.rightImageList.Images.SetKeyName(2, "smiley.ico");
            this.rightImageList.Images.SetKeyName(3, "");
            this.rightImageList.Images.SetKeyName(4, "");
            this.rightImageList.Images.SetKeyName(5, "");
            this.rightImageList.Images.SetKeyName(6, "");
            this.rightImageList.Images.SetKeyName(7, "");
            // 
            // stateImageList
            // 
            this.stateImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("stateImageList.ImageStream")));
            this.stateImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.stateImageList.Images.SetKeyName(0, "");
            this.stateImageList.Images.SetKeyName(1, "");
            this.stateImageList.Images.SetKeyName(2, "");
            // 
            // pgGrid
            // 
            this.pgGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.pgGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgGrid.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.pgGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.pgGrid.Location = new System.Drawing.Point(237, 0);
            this.pgGrid.Name = "pgGrid";
            this.pgGrid.SelectedObject = this.treeViewAdv1;
            this.pgGrid.Size = new System.Drawing.Size(211, 390);
            this.pgGrid.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(234, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 390);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(448, 390);
            this.Controls.Add(this.pgGrid);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.treeViewAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeViewAdv Demo";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Main Function Definition

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		#endregion

		#region TreeViewAdv Event Handler

		// This event will be called when either option button or checkbox are changed.
		private void treeViewAdv1_AfterCheck(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvEventArgs e)
		{
			// Update the Marital Status icon based on the current selection
			if(this.treeViewAdv1.Nodes[0].Nodes[0].Optioned)
				// If single selected
				this.treeViewAdv1.Root.Nodes[0].RightImageIndices[0] = 2;
			else
				// if married or with children
				this.treeViewAdv1.Root.Nodes[0].RightImageIndices[0] = 3;
			this.treeViewAdv1.Invalidate();
		}
		

		#region EDITING
		
		private void treeViewAdv1_BeforeEdit(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvBeforeEditEventArgs e)
		{
			// Let us prevent editing the top-level nodes.
			if(e.Node.Parent == this.treeViewAdv1.Root)
			{
				e.Cancel = true;
				MessageBox.Show("Node editing canceled for top-level nodes in the BeforeEdit event handler.");
			}
		}
		private void treeViewAdv1_NodeEditorValidated(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvEditEventArgs e)
		{
			// Typically, you might have to update the bound data source, if any, with the new Label.
			e.Node.Text = e.Node.Text.ToUpper();
		}
		private void treeViewAdv1_NodeEditorValidating(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvCancelableEditEventArgs e)
		{
			if(e.Label.Length > 0)
			{
				if (e.Label.IndexOfAny(new char[]{'@', '.', ',', '!'}) != -1)
				{
					/* Cancel the label edit action, inform the user, and 
						place the node in edit mode again. */
					e.Cancel = true;
					MessageBox.Show("Invalid tree node label.\n" + 
						"The invalid characters are: '@','.', ',', '!'", 
						"Node Label Edit");
				}
			}
			else
			{
				/* Cancel the label edit action, inform the user, and 
					place the node in edit mode again. */
				e.Cancel = true;
				MessageBox.Show("Invalid tree node label.\nThe label cannot be blank", 
					"Node Label Edit");
				// To end editing mode, do this:
				// e.ContinueEditing = false;
			}
		}
		
		#endregion EDITING

		#endregion

		#region CONTEXTMENU
		
		private TreeNodeAdv rightMouseDownNodeCached = null;
		private void editItem_Click(object sender, System.EventArgs e)
		{
			if(this.rightMouseDownNodeCached != null)
				// You can also alternatively turn on F2 label editing for all nodes via 
				// the LabelEdit property of the tree.
				this.treeViewAdv1.BeginEdit(this.rightMouseDownNodeCached);
		}

		private void contextMenu1_Popup(object sender, System.EventArgs e)
		{
			this.rightMouseDownNodeCached = this.treeViewAdv1.RMouseDownNode;
			// This will be null if the user clicked in the empty portion of the tree.
			if(this.treeViewAdv1.RMouseDownNode == null)
			{
				this.copyItem.Visible = false;
				this.cutItem.Visible = false;
				this.editItem.Visible = false;
			}
			else
			{
				this.copyItem.Visible = true;
				this.cutItem.Visible = true;
				this.editItem.Visible = true;
			}
		}

		private void cutItem_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Not Implemented. Only Edit menu is implemented.");
		}

		private void copyItem_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Not Implemented. Only Edit menu is implemented.");
		}
		#endregion CONTEXTMENU

		#region Form Event Handler

		private void Form1_Closing(object sender, CancelEventArgs e)
		{
			// End editing before the form closes
			this.treeViewAdv1.EndEdit(true);
		}
		#endregion

       
	}

	#endregion 
}
