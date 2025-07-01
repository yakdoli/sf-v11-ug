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
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Drawing;

namespace TreeViewAdvDemo
{

	#region Class Form1 Description
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		#region Variable Declaration
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;
		#endregion

		#region Form Constructor Initialization and Disposing
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.treeViewAdv1.StateImageList = this.imageList1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeViewAdv1
			// 
			this.treeViewAdv1.ActiveNode = null;
			this.treeViewAdv1.AddSeparatorAtEnd = true;
			this.treeViewAdv1.AllowDrop = true;
			this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(240)), ((System.Byte)(246))), System.Drawing.SystemColors.HotTrack);
			treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
			treeNodeAdvStyleInfo1.ThemesEnabled = true;
			this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
			this.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump;
			this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewAdv1.Font = new System.Drawing.Font("Tahoma", 8F);
			this.treeViewAdv1.ForeColor = System.Drawing.SystemColors.ControlText;
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
			this.treeViewAdv1.HotTracking = true;
			this.treeViewAdv1.IgnoreThemeBackground = true;
			this.treeViewAdv1.LineColor = System.Drawing.Color.Transparent;
			this.treeViewAdv1.LoadOnDemand = true;
			this.treeViewAdv1.Name = "treeViewAdv1";
			treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv1.EnsureDefaultOptionedChild = true;
			treeNodeAdv1.Height = 16;
			treeNodeAdv1.InteractiveCheckBox = true;
			treeNodeAdv1.ShowPlusOnExpand = false;
			treeNodeAdv1.Text = "c:";
			this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																								  treeNodeAdv1});
			this.treeViewAdv1.OwnerDrawNodes = true;
			this.treeViewAdv1.OwnerDrawNodesBackground = true;
			this.treeViewAdv1.PathSeparator = "/";
			this.treeViewAdv1.Size = new System.Drawing.Size(306, 526);
			this.treeViewAdv1.TabIndex = 1;
			this.treeViewAdv1.ThemesEnabled = true;
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
			this.treeViewAdv1.TransparentControls = true;
			this.treeViewAdv1.BeforeExpand += new Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventHandler(this.treeViewAdv2_BeforeExpand);
			this.treeViewAdv1.NodeBackgroundPaint += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintBackgroundEventHandler(this.treeViewAdv1_NodeBackgroundPaint);
			this.treeViewAdv1.BeforeNodePaint += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventHandler(this.treeViewAdv1_BeforeNodePaint);
			this.treeViewAdv1.AfterNodePaint += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventHandler(this.treeViewAdv1_AfterNodePaint);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(306, 526);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.treeViewAdv1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Owner Draw";
			this.Load += new System.EventHandler(this.Form1_Load);
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

		#region TreeviewAdv Event Handler

		#region NODE_FILL
		//This Event will be fired  before a node is expanded
		private void treeViewAdv2_BeforeExpand(object sender, Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventArgs e)
		{
            try
            {
                //Checking Whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                //Get the Path of the node and AddSeparatorAtEnd Property set to true
                string path = e.Node.GetPath("\\");

                //Get an Array of Directories from the current directory
                ArrayList dirs = new ArrayList(Directory.GetDirectories(path));

                //Add the Directories as a node in TreeViewAdv
                for (int i = 0; i < dirs.Count; i++)
                {
                    string dir = (string)dirs[i];
                    int lastIndex = dir.LastIndexOf("\\") + 1;
                    //				if(lastIndex <=0) lastIndex = dir.LastIndexOf(":")+1;
                    //				if(lastIndex>0)
                    TreeNodeAdv node = new TreeNodeAdv(dir.Substring(lastIndex));
                    e.Node.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
            }
		}
		#endregion NODE_FILL


		#region OWNER_DRAWING
		// Draw the background of the whole node here:
		private void treeViewAdv1_NodeBackgroundPaint(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintBackgroundEventArgs e)
		{
			if(e.Selected)
			{
				// Draw the beige background.
				e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(218,229,254)), e.Bounds);
			}
		}
		
		private void treeViewAdv1_BeforeNodePaint(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventArgs e)
		{
			if(e.Selected)
			{
				// Paint a custom background around the text area:
				e.Graphics.FillRectangle(new SolidBrush(Color.White), e.Node.TextBounds);
				e.ForeColor = SystemColors.WindowText;
			}
			else if(e.HotTracked)
			{
				if(this.treeViewAdv1.RightToLeft == RightToLeft.No)
				{
					// Draw the text myself and prevent default text drawing:
					TreeNodeAdv node = e.Node;
					Brush foreBrush = new SolidBrush(e.ForeColor);

					e.Graphics.DrawString(e.Node.Text,this.GetHotFont(node),foreBrush,node.TextBounds.X,node.Bounds.Y + (node.Height-node.TextBounds.Height)/2);

					e.HandledText = true;
				}
			}
		}

		Font GetHotFont(TreeNodeAdv node)
		{
			Font dFont = node.Font;
			return Syncfusion.Drawing.FontUtil.CreateFont(dFont,dFont.Style | FontStyle.Bold | FontStyle.Underline);
		}
        
		
		//This Event will be Fired after a node is being painted when the OwnerDrawNodes property is set to true. 
		private void treeViewAdv1_AfterNodePaint(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventArgs e)
		{
			//Checking whether Node is selected or not
			if(e.Selected)
			{
				//Draw the owner Draw text at the RightHand Side of the Selected node
				if(this.treeViewAdv1.RightToLeft == RightToLeft.No)
				{
					
					TreeNodeAdv node = e.Node;
					Brush foreBrush = new SolidBrush(e.ForeColor);
					e.Graphics.DrawString("\"Owner Drawn Text\"", node.Font, foreBrush, node.TextBounds.Right + 2,node.Bounds.Y + (node.Height-node.TextBounds.Height)/2);
				}
			}
		}
		#endregion OWNER_DRAWING

		#endregion

		#region  Form Event Handler
		private void Form1_Load(object sender, System.EventArgs e)
		{
			if(this.treeViewAdv1.RightToLeft == RightToLeft.Yes)
				MessageBox.Show("Owner drawing is done only when the control's RightToLeft is set to No.");
		}
		#endregion
	}
	#endregion
}
