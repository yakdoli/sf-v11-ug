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

	public class Form1 : System.Windows.Forms.Form
	{
		#region Variable Declaration
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv2;
		private System.Windows.Forms.ImageList imageList1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Splitter splitter1;
		private System.ComponentModel.IContainer components;
		#endregion

		#region Form Constructor Initialization and Disposing

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
			this.treeViewAdv2 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
			this.gradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeViewAdv2
			// 
			this.treeViewAdv2.ActiveNode = null;
			this.treeViewAdv2.AddSeparatorAtEnd = true;
			this.treeViewAdv2.AllowDrop = true;
			this.treeViewAdv2.BackColor = System.Drawing.Color.White;
			this.treeViewAdv2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(240)), ((System.Byte)(246))), System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(214)), ((System.Byte)(233))));
			treeNodeAdvStyleInfo1.CheckColor = System.Drawing.SystemColors.ControlText;
			treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
			treeNodeAdvStyleInfo1.IntermediateCheckColor = System.Drawing.SystemColors.ControlDark;
			treeNodeAdvStyleInfo1.ShowCheckBox = true;
			treeNodeAdvStyleInfo1.ShowOptionButton = true;
			treeNodeAdvStyleInfo1.ThemesEnabled = true;
			this.treeViewAdv2.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
			this.treeViewAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump;
			this.treeViewAdv2.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeViewAdv2.Font = new System.Drawing.Font("Verdana", 8F);
			// 
			// treeViewAdv2.HelpTextControl
			// 
			this.treeViewAdv2.HelpTextControl.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.treeViewAdv2.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treeViewAdv2.HelpTextControl.Location = new System.Drawing.Point(732, 0);
			this.treeViewAdv2.HelpTextControl.Name = "helpText";
			this.treeViewAdv2.HelpTextControl.Size = new System.Drawing.Size(50, 17);
			this.treeViewAdv2.HelpTextControl.TabIndex = 0;
			this.treeViewAdv2.HelpTextControl.Text = "help text";
			this.treeViewAdv2.IgnoreThemeBackground = true;
			this.treeViewAdv2.Indent = 20;
			this.treeViewAdv2.LineColor = System.Drawing.Color.Transparent;
			this.treeViewAdv2.LoadOnDemand = true;
			this.treeViewAdv2.Name = "treeViewAdv2";
			treeNodeAdv1.ChildStyle.CheckColor = System.Drawing.SystemColors.ControlText;
			treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv1.ChildStyle.IntermediateCheckColor = System.Drawing.SystemColors.ControlDark;
			treeNodeAdv1.EnsureDefaultOptionedChild = true;
			treeNodeAdv1.ShowPlusOnExpand = false;
			treeNodeAdv1.Text = "c:";
			this.treeViewAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																								  treeNodeAdv1});
			this.treeViewAdv2.OwnerDrawNodes = true;
			this.treeViewAdv2.PathSeparator = "/";
			this.treeViewAdv2.ShowCheckBoxes = true;
			this.treeViewAdv2.ShowOptionButtons = true;
			this.treeViewAdv2.Size = new System.Drawing.Size(208, 526);
			this.treeViewAdv2.StateImageList = this.imageList1;
			this.treeViewAdv2.TabIndex = 2;
			this.treeViewAdv2.ThemesEnabled = true;
			// 
			// treeViewAdv2.ToolTipControl
			// 
			this.treeViewAdv2.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
			this.treeViewAdv2.ToolTipControl.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.treeViewAdv2.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treeViewAdv2.ToolTipControl.Location = new System.Drawing.Point(642, 0);
			this.treeViewAdv2.ToolTipControl.Name = "toolTip";
			this.treeViewAdv2.ToolTipControl.Size = new System.Drawing.Size(41, 17);
			this.treeViewAdv2.ToolTipControl.TabIndex = 1;
			this.treeViewAdv2.ToolTipControl.Text = "toolTip";
			this.treeViewAdv2.BeforeExpand += new Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventHandler(this.treeViewAdv2_BeforeExpand_1);
			this.treeViewAdv2.BeforeNodePaint += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventHandler(this.treeViewAdv2_NodePaint);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.White;
			// 
			// gradientPanel1
			// 
			this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(240)), ((System.Byte)(246))), System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(214)), ((System.Byte)(233))));
			this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.gradientPanel1.BorderColor = System.Drawing.Color.Black;
			this.gradientPanel1.BorderSides = System.Windows.Forms.Border3DSide.Left;
			this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gradientPanel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.comboBox2,
																						 this.label2,
																						 this.label1,
																						 this.comboBox1,
																						 this.button1});
			this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gradientPanel1.Location = new System.Drawing.Point(214, 0);
			this.gradientPanel1.Name = "gradientPanel1";
			this.gradientPanel1.Size = new System.Drawing.Size(236, 526);
			this.gradientPanel1.TabIndex = 3;
			// 
			// comboBox2
			// 
			this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(187)), ((System.Byte)(111)));
			this.comboBox2.Items.AddRange(new object[] {
														   "Text",
														   "CheckBox",
														   "Tag"});
			this.comboBox2.Location = new System.Drawing.Point(8, 136);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(216, 21);
			this.comboBox2.TabIndex = 12;
			this.comboBox2.Text = "Text";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(8, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 11;
			this.label2.Text = "Sort Type";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Sort Order";
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(187)), ((System.Byte)(111)));
			this.comboBox1.Items.AddRange(new object[] {
														   "None",
														   "Ascending",
														   "Descending"});
			this.comboBox1.Location = new System.Drawing.Point(8, 80);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(216, 21);
			this.comboBox1.TabIndex = 9;
			this.comboBox1.Text = "None";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(48, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Sort selected node";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// splitter1
			// 
			this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitter1.Location = new System.Drawing.Point(208, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(6, 526);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(450, 526);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gradientPanel1,
																		  this.splitter1,
																		  this.treeViewAdv2});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sort Nodes";
			((System.ComponentModel.ISupportInitialize)(this.treeViewAdv2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
			this.gradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Main Fnction Definition
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		#endregion

		#region TreeViewAdv Event Handler

		#region Load the child nodes 
		
		//This Event will be fired  before a node is expanded
		private void treeViewAdv2_BeforeExpand_1(object sender, Syncfusion.Windows.Forms.Tools.TreeViewAdvCancelableNodeEventArgs e)
		{
            try
            {

                //Checking Whether the Node has been  expanded atleast once
                if (e.Node.ExpandedOnce) return;

                //Get the Path of the node and AddSeparatorAtEnd Property set to true
                string path = e.Node.GetPath("\\");

                //Get an Array of Directories from the current directory path
                ArrayList dirs = new ArrayList(Directory.GetDirectories(path));

                //Add the Directories as a node in TreeViewAdv
                for (int i = 0; i < dirs.Count; i++)
                {
                    string dir = (string)dirs[i];
                    int lastIndex = dir.LastIndexOf("\\") + 1;
                    TreeNodeAdv node = new TreeNodeAdv(dir.Substring(lastIndex));
                    // Make the node's Tag same as Text for demo purposes.
                    node.Tag = node.Text;
                    e.Node.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            { }
		}

		#endregion

		BrushInfo br = new BrushInfo(GradientStyle.PathEllipse,Color.Beige,Color.Beige);

		//This Event will be Fired before a node is being painted when the OwnerDrawNodes property is set to true. 
		private void treeViewAdv2_NodePaint(object sender, Syncfusion.Windows.Forms.Tools.TreeNodeAdvPaintEventArgs e)
		{
			//Draw the BackGround color for the Selected node
			if(e.Selected)
			{

				BrushPaint.FillRectangle(e.Graphics,e.Bounds,br);
				e.ForeColor = SystemColors.WindowText;
			}
		}
#endregion

		#region button Event Handler
		
		private void button1_Click(object sender, System.EventArgs e)
		{
			//Checking the Selected Nodes is null
			if(this.treeViewAdv2.SelectedNode == null) return;
			

			if(treeViewAdv2.SelectedNode.Expanded == false || !treeViewAdv2.SelectedNode.HasChildren)
			{
				//Display the Message Box when the Node has no children
				MessageBox.Show("The selected node isn`t expanded or hasn`t got child nodes to sort");
			}
			
			switch(this.comboBox1.SelectedIndex)
			{
				case 0: treeViewAdv2.SelectedNode.SortOrder = SortOrder.None;break;
				
				//Sorting the Nodes  in Ascending order
				case 1: treeViewAdv2.SelectedNode.SortOrder = SortOrder.Ascending;break;
			    
				//Sorting the Nodes in Descending order
				case 2: treeViewAdv2.SelectedNode.SortOrder = SortOrder.Descending;break;
			}
			switch(this.comboBox2.SelectedIndex)
			{
				//Sort the node based on the node Text
				case 0: treeViewAdv2.SelectedNode.SortType = TreeNodeAdvSortType.Text;break;
				
				//Sort the node based on the value of the CheckBox
				case 1: treeViewAdv2.SelectedNode.SortType = TreeNodeAdvSortType.CheckBox;break;
				//Sort the nodes based on the node Tag
				case 2: treeViewAdv2.SelectedNode.SortType = TreeNodeAdvSortType.Tag;break;
			}

			treeViewAdv2.SelectedNode.Sort();
		}

		#endregion
	}
#endregion
}
