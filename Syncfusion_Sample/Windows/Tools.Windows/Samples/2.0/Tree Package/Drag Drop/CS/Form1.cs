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
using System.Diagnostics;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace TreeViewAdvDragDrop
{
	#region Class Form1 Description
	
	public class Form1 : Office2007Form
	{
	
		#region Variable Declaration
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
		// Use the tracker only when you want to support dropping adjacent (above or below) to a node.
		// Otherwise simply listen to the DragOver and DragDrop events and provide/use the DropEffect.
		// When used this tracker will draw indicators above or below a node while dragging an item
		// over the node. The tracker need to be updated as shown below in the DragXXX events.
		private TreeViewAdvDragHighlightTracker treeViewDragHighlightTracker = null;
        private Panel panel1;
        private Label label20;
        private Label label19;
        private ButtonEdit HighLighterColor;
        private ButtonEditChildButton buttonEditChildButton1;
        private Label label1;
        private ColorDialog colorDialog1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private IContainer components;
        private Label label4;
        private Label label3;
        private ScrollersFrame scrollersFrame1;
        private CheckBoxAdv checkBoxAdv1;
        private System.Windows.Forms.ListViewItem listViewItem1; 
		#endregion

		#region Form Constructor Initialization and Disposing
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.treeViewAdv1.AutoScrolling = ScrollBars.Both;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			
		
			#region Delegate Declaration
			this.treeViewDragHighlightTracker = new TreeViewAdvDragHighlightTracker(this.treeViewAdv1);
			// This event will let you disable certain drop-positions for certain nodes while dragging.
			this.treeViewDragHighlightTracker.QueryAllowedPositionsForNode += 
				new QueryAllowedPositionsEventHandler(this.TreeDragDrop_QueryAllowedPositionsForNode);
			this.treeViewDragHighlightTracker.QueryDragInsertInfo+=
				new QueryDragInsertInfoEventHandler(treeViewDragHighlightTracker_QueryDragInsertInfo);
			
			#endregion
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(treeViewDragHighlightTracker != null)
				{
					this.treeViewDragHighlightTracker.QueryAllowedPositionsForNode -= 
						new QueryAllowedPositionsEventHandler(this.TreeDragDrop_QueryAllowedPositionsForNode);
					this.treeViewDragHighlightTracker = null;
				}
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
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv19 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv20 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv21 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv22 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv23 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv24 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv25 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv26 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv27 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv28 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv29 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.HighLighterColor = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.scrollersFrame1 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighLighterColor)).BeginInit();
            this.HighLighterColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AllowDrop = true;
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Silver, System.Drawing.Color.Navy);
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewAdv1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(184)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(50, 17);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.Indent = 20;
            this.treeViewAdv1.LineColor = System.Drawing.Color.White;
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.Name = "treeViewAdv1";
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv1.Tag = "Continent";
            treeNodeAdv1.Text = "North America";
            treeNodeAdv1.TextColor = System.Drawing.Color.White;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv2.Tag = "Continent";
            treeNodeAdv2.Text = "South America";
            treeNodeAdv2.TextColor = System.Drawing.Color.White;
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv3.Tag = "Continent";
            treeNodeAdv3.Text = "Antarctica";
            treeNodeAdv3.TextColor = System.Drawing.Color.White;
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv4.Tag = "Continent";
            treeNodeAdv4.Text = "Europe";
            treeNodeAdv4.TextColor = System.Drawing.Color.White;
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv5.Tag = "Continent";
            treeNodeAdv5.Text = "Asia";
            treeNodeAdv5.TextColor = System.Drawing.Color.White;
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv6.Tag = "Continent";
            treeNodeAdv6.Text = "Africa";
            treeNodeAdv6.TextColor = System.Drawing.Color.White;
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv7.Tag = "Continent";
            treeNodeAdv7.Text = "Australia";
            treeNodeAdv7.TextColor = System.Drawing.Color.White;
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNodeAdv8.Text = "Australia";
            treeNodeAdv8.TextColor = System.Drawing.Color.LightSkyBlue;
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.Text = "Austria";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.Text = "Belgium";
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.Text = "Brazil";
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.Text = "Canada";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.Text = "Denmark";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.Text = "Finland";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.Text = "France";
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.Text = "Germany";
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.Text = "Ireland";
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.Text = "Italy";
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.Text = "Japan";
            treeNodeAdv20.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.EnsureDefaultOptionedChild = true;
            treeNodeAdv20.Text = "Mexico";
            treeNodeAdv21.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.EnsureDefaultOptionedChild = true;
            treeNodeAdv21.Text = "Netherlands";
            treeNodeAdv22.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.EnsureDefaultOptionedChild = true;
            treeNodeAdv22.Text = "Norway";
            treeNodeAdv23.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.EnsureDefaultOptionedChild = true;
            treeNodeAdv23.Text = "New Zealand";
            treeNodeAdv24.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.EnsureDefaultOptionedChild = true;
            treeNodeAdv24.Text = "Portugal";
            treeNodeAdv25.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.EnsureDefaultOptionedChild = true;
            treeNodeAdv25.Text = "Russia";
            treeNodeAdv26.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.EnsureDefaultOptionedChild = true;
            treeNodeAdv26.Text = "Spain";
            treeNodeAdv27.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.EnsureDefaultOptionedChild = true;
            treeNodeAdv27.Text = "Sweden";
            treeNodeAdv28.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.EnsureDefaultOptionedChild = true;
            treeNodeAdv28.Text = "United Kingdom";
            treeNodeAdv29.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.EnsureDefaultOptionedChild = true;
            treeNodeAdv29.Text = "United States";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4,
            treeNodeAdv5,
            treeNodeAdv6,
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9,
            treeNodeAdv10,
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14,
            treeNodeAdv15,
            treeNodeAdv16,
            treeNodeAdv17,
            treeNodeAdv18,
            treeNodeAdv19,
            treeNodeAdv20,
            treeNodeAdv21,
            treeNodeAdv22,
            treeNodeAdv23,
            treeNodeAdv24,
            treeNodeAdv25,
            treeNodeAdv26,
            treeNodeAdv27,
            treeNodeAdv28,
            treeNodeAdv29});
            this.treeViewAdv1.PathSeparator = "/";
            this.treeViewAdv1.Size = new System.Drawing.Size(224, 434);
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
            this.treeViewAdv1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewAdv_ItemDrag);
            this.treeViewAdv1.DragLeave += new System.EventHandler(this.treeViewAdv_DragLeave);
            this.treeViewAdv1.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.treeViewAdv_QueryContinueDrag);
            this.treeViewAdv1.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewAdv_DragOver);
            this.treeViewAdv1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewAdv_DragDrop);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBoxAdv1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.HighLighterColor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(224, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 434);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label4.Location = new System.Drawing.Point(10, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 1);
            this.label4.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(5, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 23);
            this.label3.TabIndex = 43;
            this.label3.Text = "       Drag And Drop Events";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 193);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(226, 239);
            this.listView1.TabIndex = 42;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Events";
            this.columnHeader1.Width = 201;
            // 
            // HighLighterColor
            // 
            this.HighLighterColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HighLighterColor.Buttons.Add(this.buttonEditChildButton1);
            this.HighLighterColor.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.HighLighterColor.Controls.Add(this.buttonEditChildButton1);
            this.HighLighterColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HighLighterColor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighLighterColor.Location = new System.Drawing.Point(114, 65);
            this.HighLighterColor.Name = "HighLighterColor";
            this.HighLighterColor.Size = new System.Drawing.Size(102, 26);
            this.HighLighterColor.TabIndex = 39;
            this.HighLighterColor.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.HighLighterColor_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            this.buttonEditChildButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(5, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 38;
            this.label1.Text = "DragHighlighterColor";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label20.Location = new System.Drawing.Point(10, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(185, 1);
            this.label20.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(10, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(203, 23);
            this.label19.TabIndex = 24;
            this.label19.Text = "       Drag And Drop Features  ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scrollersFrame1
            // 
            this.scrollersFrame1.EnableDelayedScrollBarUpdate = true;
            this.scrollersFrame1.HorizontalSmallChange = 7;
            this.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame1.VerticallSmallChange = 13;
            this.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv1.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv1.Location = new System.Drawing.Point(8, 97);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv1.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv1.Size = new System.Drawing.Size(177, 27);
            this.checkBoxAdv1.TabIndex = 45;
            this.checkBoxAdv1.Text = "ShowDragNodeCue";
            this.checkBoxAdv1.ThemesEnabled = true;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(452, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeViewAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(50, 300);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drag Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighLighterColor)).EndInit();
            this.HighLighterColor.ResumeLayout(false);
            this.HighLighterColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
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

		#region DRAG_DROP_UTILS
		private bool IsContinentNode(TreeNodeAdv node)
		{
			if(node.Tag == null
				|| ("Continent").CompareTo(node.Tag.ToString()) != 0)
			{
				return false;
			}
			else
				return true;
		}
		#endregion DRAG_DROP_UTILS
        		
		#region SOURCE_DRAGDROP_LOGIC
		
		private void treeViewAdv_ItemDrag(object sender, System.Windows.Forms.ItemDragEventArgs e)
		{
			TreeViewAdv treeViewAdv = sender as TreeViewAdv;

			// The TreeViewAdv always provides an array of selected nodes.
			TreeNodeAdv[] nodes = e.Item as TreeNodeAdv[];

			// Let us get only the first selected node.
			TreeNodeAdv node = nodes[0];

			// Drag only "country" nodes (non-continent nodes)
			if(!IsContinentNode(node))
			{
				// Only allow move
				DragDropEffects result = treeViewAdv.DoDragDrop(node, DragDropEffects.Move);
			}
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "ItemDrag", e.Item.ToString() });
            this.listView1.Items.Add(listViewItem1);
	
		}

		private void treeViewAdv_QueryContinueDrag(object sender, System.Windows.Forms.QueryContinueDragEventArgs e)
		{
			// Cancel draggin when Escape was pressed.
			if(e.EscapePressed)
			{
				e.Action = DragAction.Cancel;
			}
           	
		}
		#endregion SOURCE_DRAGDROP_LOGIC

		#region DEST_DRAGDROP_LOGIC

		// Helps keep track of the node that is being dragged.
		private TreeNodeAdv currentSourceNode;

		private void treeViewAdv_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// Determine drag effects
			bool droppable = true;
			TreeNodeAdv destinationNode = null;
			TreeViewAdv treeView = sender as TreeViewAdv;
			Point ptInTree = treeView.PointToClient(new Point(e.X, e.Y));
			this.currentSourceNode = null;

			// Looking for a single tree node.
			if( e.Data.GetDataPresent(typeof(TreeNodeAdv)))
			{
				// Get the destination and source node.
				destinationNode = treeView.GetNodeAtPoint(ptInTree);
				TreeNodeAdv sourceNode = (TreeNodeAdv) e.Data.GetData(typeof(TreeNodeAdv));
				// Cache this for use later in the TreeDragDrop_QueryAllowedPositionsForNode event handler.
				this.currentSourceNode = sourceNode;
				droppable = this.CanDrop(sourceNode, destinationNode);
			}
			else
				droppable = false;

			if(droppable)
				// If Moving is allowed:
				e.Effect = DragDropEffects.Move;
			else
				e.Effect = DragDropEffects.None;

			// Let the highlight tracker keep track of the current highlight node.
			this.treeViewDragHighlightTracker.SetHighlightNode(destinationNode, ptInTree);
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "DragOver", e.Data.ToString() });
            this.listView1.Items.Add(listViewItem1);
	
           	
		}
		private bool CanDrop(TreeNodeAdv sourceNode, TreeNodeAdv destinationNode)
		{
			if(// Support drag and drop only within the same tree
				sourceNode.TreeView != this.treeViewAdv1 ||
				// Cannot drop into empty area
				destinationNode == null ||
				// Cannot drop over the source's parent
				destinationNode == sourceNode.Parent ||
				// Or over itself
				destinationNode == sourceNode
				)
				return false;
			else
				return true;
		}
		private void treeViewAdv_DragLeave(object sender, System.EventArgs e)
		{
			// Let the highlight tracker keep track of the current highlight node.
			this.treeViewDragHighlightTracker.ClearHighlightNode();
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "DragLeave", e.ToString() });
            this.listView1.Items.Add(listViewItem1);
	
		}

		private void treeViewAdv_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			TreeViewAdv treeView = sender as TreeViewAdv;

			// Get the destination and source node.

			TreeNodeAdv sourceNode = (TreeNodeAdv) e.Data.GetData(typeof(TreeNodeAdv));
			
			TreeNodeAdv destinationNode = this.treeViewDragHighlightTracker.HighlightNode;
			TreeViewDropPositions dropPosition = this.treeViewDragHighlightTracker.DropPosition;
			// Clear the highlight info in the tracker.
			this.treeViewDragHighlightTracker.ClearHighlightNode();

			this.currentSourceNode = null;

			// Move the source node based on the tracked info.
			if(destinationNode != null)
			{
				switch (dropPosition)
				{
					case TreeViewDropPositions.AboveNode:
						sourceNode.Move(destinationNode, NodePositions.Previous);
						break;
					case TreeViewDropPositions.BelowNode:
						sourceNode.Move(destinationNode, NodePositions.Next);
						break;
					case TreeViewDropPositions.OnNode:
						sourceNode.Move(destinationNode.Nodes);
						destinationNode.Expand();
						break;
				}
			}
			
			treeView.SelectedNode = sourceNode;
            listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] { "DragDrop", e.Data.ToString() });
            this.listView1.Items.Add(listViewItem1);
	
            
		}
		
		#endregion DEST_DRAGDROP_LOGIC
			
		#region Delegate Defintion
		
		private void treeViewDragHighlightTracker_QueryDragInsertInfo(object sender, QueryDragInsertInfoEventArgs args)
		{
            args.DragInsertColor = highlighter;
    	}

		// Specifiy the allowed drop positions for the specified highlight node.
		private void TreeDragDrop_QueryAllowedPositionsForNode(object sender, QueryAllowedPositionsEventArgs e)
		{
			if(!this.IsContinentNode(e.HighlightNode))
			{
				// If this a country node, only allow drop above or below it.

				if(e.HighlightNode != this.currentSourceNode)
					e.AllowedPositions = TreeViewDropPositions.AboveNode | TreeViewDropPositions.BelowNode;
				else
					// Cannot drop beside itself
					e.AllowedPositions = TreeViewDropPositions.None;

				this.treeViewDragHighlightTracker.EdgeSensitivityOnTop = e.HighlightNode.Bounds.Height / 2;

				e.ShowSelectionHighlight = false;
			}
			else
			{
				// If this is a continent node allow all drop positions (default behavior).
				this.treeViewDragHighlightTracker.EdgeSensitivityOnTop = e.HighlightNode.Bounds.Height / 4;

				e.ShowSelectionHighlight = 
					// Only if the source node is droppable
					this.CanDrop(this.currentSourceNode, e.HighlightNode)
					// and droppable ON the node (not beside it)
					&& e.NewDropPosition == TreeViewDropPositions.OnNode;
			}

		}
		#endregion

        #region HighLighterColor
        Color highlighter = Color.Red;
        private void HighLighterColor_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            colorDialog1.ShowDialog();
            highlighter = colorDialog1.Color;
            this.HighLighterColor.BackColor=colorDialog1.Color;
        }
        #endregion

        #region ShowDragNodeCue
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.treeViewAdv1.ShowDragNodeCue = this.checkBoxAdv1.Checked;
        }
        
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeViewAdv1.Office2007ScrollBars = true;
            this.scrollersFrame1.AttachedTo = this.listView1;
            this.HighLighterColor.TextBox.BackColor = Color.Red;
        }

        

    }
#endregion
}
