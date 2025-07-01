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

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace _TreeViewAdvImageOverLayingDemo
{
	#region Class Form1 Description
	
	public class Form1 : System.Windows.Forms.Form
	{
		#region Variable Declaration
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ImageList imageList2;
		private System.ComponentModel.IContainer components;
		#endregion
		
		#region Form Constructor Initialization Disposing
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeViewAdv1
			// 
			this.treeViewAdv1.ActiveNode = null;
			this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(58)), ((System.Byte)(134)), ((System.Byte)(126))));
			treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
			this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
			this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewAdv1.ForeColor = System.Drawing.SystemColors.ControlLight;
			// 
			// treeViewAdv1.HelpTextControl
			// 
			this.treeViewAdv1.HelpTextControl.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(732, 0);
			this.treeViewAdv1.HelpTextControl.Name = "helpText";
			this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(50, 17);
			this.treeViewAdv1.HelpTextControl.TabIndex = 0;
			this.treeViewAdv1.HelpTextControl.Text = "help text";
			this.treeViewAdv1.LeftImageList = this.imageList1;
			this.treeViewAdv1.Name = "treeViewAdv1";
			treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv1.EnsureDefaultOptionedChild = true;
			treeNodeAdv1.Expanded = true;
			treeNodeAdv1.LeftImageIndices = new int[] {
														  1};
			treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv2.EnsureDefaultOptionedChild = true;
			treeNodeAdv2.Expanded = true;
			treeNodeAdv2.LeftImageIndices = new int[] {
														  1};
			treeNodeAdv2.Optioned = true;
			treeNodeAdv2.ShowPlusOnExpand = false;
			treeNodeAdv2.Text = "India";
			treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv3.EnsureDefaultOptionedChild = true;
			treeNodeAdv3.LeftImageIndices = new int[] {
														  2};
			treeNodeAdv3.ShowPlusOnExpand = false;
			treeNodeAdv3.Text = "China";
			treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							 treeNodeAdv2,
																							 treeNodeAdv3});
			treeNodeAdv1.ShowPlusOnExpand = false;
			treeNodeAdv1.Text = "Asia";
			treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv4.EnsureDefaultOptionedChild = true;
			treeNodeAdv4.Expanded = true;
			treeNodeAdv4.LeftImageIndices = new int[] {
														  7};
			treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv5.EnsureDefaultOptionedChild = true;
			treeNodeAdv5.Expanded = true;
			treeNodeAdv5.LeftImageIndices = new int[] {
														  3};
			treeNodeAdv5.Optioned = true;
			treeNodeAdv5.ShowPlusOnExpand = false;
			treeNodeAdv5.Text = "Britain";
			treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv6.EnsureDefaultOptionedChild = true;
			treeNodeAdv6.LeftImageIndices = new int[] {
														  4};
			treeNodeAdv6.ShowPlusOnExpand = false;
			treeNodeAdv6.Text = "France";
			treeNodeAdv4.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							 treeNodeAdv5,
																							 treeNodeAdv6});
			treeNodeAdv4.ShowPlusOnExpand = false;
			treeNodeAdv4.Text = "Europe";
			treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv7.EnsureDefaultOptionedChild = true;
			treeNodeAdv7.Expanded = true;
			treeNodeAdv7.LeftImageIndices = new int[] {
														  6};
			treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv8.EnsureDefaultOptionedChild = true;
			treeNodeAdv8.Expanded = true;
			treeNodeAdv8.LeftImageIndices = new int[] {
														  5};
			treeNodeAdv8.Optioned = true;
			treeNodeAdv8.ShowPlusOnExpand = false;
			treeNodeAdv8.Text = "United States";
			treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv9.EnsureDefaultOptionedChild = true;
			treeNodeAdv9.LeftImageIndices = new int[] {
														  6};
			treeNodeAdv9.ShowPlusOnExpand = false;
			treeNodeAdv9.Text = "Canada";
			treeNodeAdv7.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							 treeNodeAdv8,
																							 treeNodeAdv9});
			treeNodeAdv7.ShowPlusOnExpand = false;
			treeNodeAdv7.Text = "North America";
			treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv10.EnsureDefaultOptionedChild = true;
			treeNodeAdv10.Expanded = true;
			treeNodeAdv10.LeftImageIndices = new int[] {
														   9};
			treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv11.EnsureDefaultOptionedChild = true;
			treeNodeAdv11.LeftImageIndices = new int[] {
														   10};
			treeNodeAdv11.Optioned = true;
			treeNodeAdv11.RightImageIndices = new int[] {
															0};
			treeNodeAdv11.ShowPlusOnExpand = false;
			treeNodeAdv11.Text = "Australia";
			treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv12.EnsureDefaultOptionedChild = true;
			treeNodeAdv12.LeftImageIndices = new int[] {
														   11};
			treeNodeAdv12.RightImageIndices = new int[] {
															1};
			treeNodeAdv12.ShowPlusOnExpand = false;
			treeNodeAdv12.Text = "New Zealand";
			treeNodeAdv10.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							  treeNodeAdv11,
																							  treeNodeAdv12});
			treeNodeAdv10.RightImageIndices = new int[] {
															0};
			treeNodeAdv10.ShowPlusOnExpand = false;
			treeNodeAdv10.Text = "Australia";
			treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv13.EnsureDefaultOptionedChild = true;
			treeNodeAdv13.Expanded = true;
			treeNodeAdv13.LeftImageIndices = new int[] {
														   12};
			treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv14.EnsureDefaultOptionedChild = true;
			treeNodeAdv14.LeftImageIndices = new int[] {
														   13};
			treeNodeAdv14.Optioned = true;
			treeNodeAdv14.RightImageIndices = new int[] {
															2};
			treeNodeAdv14.ShowPlusOnExpand = false;
			treeNodeAdv14.Text = "Brazil";
			treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv15.EnsureDefaultOptionedChild = true;
			treeNodeAdv15.LeftImageIndices = new int[] {
														   14};
			treeNodeAdv15.RightImageIndices = new int[] {
															3};
			treeNodeAdv15.ShowPlusOnExpand = false;
			treeNodeAdv15.Text = "Argentina";
			treeNodeAdv13.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							  treeNodeAdv14,
																							  treeNodeAdv15});
			treeNodeAdv13.RightImageIndices = new int[] {
															6};
			treeNodeAdv13.ShowPlusOnExpand = false;
			treeNodeAdv13.Text = "South America";
			treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv16.EnsureDefaultOptionedChild = true;
			treeNodeAdv16.Expanded = true;
			treeNodeAdv16.LeftImageIndices = new int[] {
														   15};
			treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv17.EnsureDefaultOptionedChild = true;
			treeNodeAdv17.LeftImageIndices = new int[] {
														   16};
			treeNodeAdv17.Optioned = true;
			treeNodeAdv17.RightImageIndices = new int[] {
															4};
			treeNodeAdv17.ShowPlusOnExpand = false;
			treeNodeAdv17.Text = "South Africa";
			treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv18.EnsureDefaultOptionedChild = true;
			treeNodeAdv18.LeftImageIndices = new int[] {
														   17};
			treeNodeAdv18.RightImageIndices = new int[] {
															5};
			treeNodeAdv18.ShowPlusOnExpand = false;
			treeNodeAdv18.Text = "Zimbabwe";
			treeNodeAdv16.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							  treeNodeAdv17,
																							  treeNodeAdv18});
			treeNodeAdv16.RightImageIndices = new int[] {
															7};
			treeNodeAdv16.ShowPlusOnExpand = false;
			treeNodeAdv16.Text = "Africa";
			this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																								  treeNodeAdv1,
																								  treeNodeAdv4,
																								  treeNodeAdv7,
																								  treeNodeAdv10,
																								  treeNodeAdv13,
																								  treeNodeAdv16});
			this.treeViewAdv1.OwnerDrawNodes = true;
			this.treeViewAdv1.RightImageList = this.imageList2;
			this.treeViewAdv1.ShowLines = false;
			this.treeViewAdv1.Size = new System.Drawing.Size(216, 333);
			this.treeViewAdv1.TabIndex = 0;
			this.treeViewAdv1.Text = "treeViewAdv1";
			// 
			// treeViewAdv1.ToolTipControl
			// 
			this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
			this.treeViewAdv1.ToolTipControl.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(642, 0);
			this.treeViewAdv1.ToolTipControl.Name = "toolTip";
			this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 17);
			this.treeViewAdv1.ToolTipControl.TabIndex = 1;
			this.treeViewAdv1.ToolTipControl.Text = "toolTip";
			this.treeViewAdv1.BeforeCollapse += new Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventHandler(this.treeViewAdv1_BeforeCollapse);
			this.treeViewAdv1.AfterNodePaint += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventHandler(this.treeViewAdv1_AfterNodePaint);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// imageList2
			// 
			this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(216, 333);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.treeViewAdv1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Image Overlay";
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

		#region TreeView Event Handler

		//This Event will be Fired after a node is being painted when the OwnerDrawNodes property is set to true.
		private void treeViewAdv1_AfterNodePaint(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventArgs e)
		{
			//Getting the  Mouse Current Position
			Point pt=this.treeViewAdv1.PointToClient(new Point(MousePosition.X,MousePosition.Y));
			
			//Get the Node at the specified Location
			TreeNodeAdv node=this.treeViewAdv1.GetNodeAtPoint(pt);
			
			//Get the selected node of the TreeViewAdv1 Control
			node = this.treeViewAdv1.SelectedNode;
			
			//Checking whether the Selected Node is not equal to Null
			if(node!=null) 
			{ 
				// Update the icon for the selected node
 
				if(node.Text=="Asia" || node.Text=="India"||node.Text=="China"||node.Text=="Europe" 
					|| node.Text=="Britain"||node.Text=="France"||node.Text=="North America"||
					node.Text=="United States"||node.Text=="Canada")
				{ 
					//Get the Location to paint the new image
					pt = new Point(node.LeftImagesX, node.TextAndImageBounds.Y);
					
					//Paint the new image at the specified location
					e.Graphics.DrawImage(imageList1.Images[0], pt );
				} 

				else
				{
					//Get the Location to paint the image
					pt = new Point(node.RightImagesX, node.TextAndImageBounds.Y);
					//Paint the new image at the specified location
					e.Graphics.DrawImage(imageList2.Images[8], pt );
				}

			} 
		}
		//This event wiil be fired  before a node has collapsed.
		private void treeViewAdv1_BeforeCollapse(object sender, Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventArgs e)
		{
		   //Checking Whether the Selected node doesn't have a children
			if(!this.treeViewAdv1.SelectedNode.HasChildren)
                //Set the Selected Node of the  TreeviewAdv1
				this.treeViewAdv1.SelectedNode=this.treeViewAdv1.SelectedNode.Parent;

		}
		#endregion
	}
#endregion
}
