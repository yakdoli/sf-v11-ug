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
using Microsoft.Win32;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace SimpleCode
{
	#region Class Form1 Description
	
	public class Form1 : Syncfusion.Windows.Forms.Office2007Form

	{
		#region Variable Declaration

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private Syncfusion.Windows.Forms.Tools.DockingManager dockingManager;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ImageList ilDocking;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.PropertyGrid pgDocking;
		

		#endregion

		#region Form Constructor, Initialization and Disposing

		public Form1()
		{
			//
			// Required for Windows Form Designer support.
			//
			
			
			InitializeComponent();


			// The InitalizeDockingWindows method programmatically initializes the DockingManager 
			// and the various dockable controls.
			InitializeDockingWindows();
		//	this.dockingManager.ProvideGraphicsItems += new Syncfusion.Windows.Forms.Tools.ProvideGraphicsItemsEventHandler(this.dockingManager1_ProvideGraphicsItems);
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Grid");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tools");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Chart");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Diagram");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Calculate");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Grouping");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("DocIO");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("PDF");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("XlsIO");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Barcode");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Asp.Net", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Grid");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Tools");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Chart");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Diagram");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Calculate");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Grouping");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("DocIO");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("PDF");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("XlsIO");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("HTMLUI");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Barcode");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Windows Forms", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Products", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Knowledge Base");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Evaluation Center");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Direct-Trac");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Forums");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Feature Requests");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Open Issues");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Windows Forms FAQs");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("ASP.NET FAQs");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Support", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33});
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Syncfusion", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode34});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pgDocking = new System.Windows.Forms.PropertyGrid();
            this.ilDocking = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(227)))));
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Grid",
            "Tools",
            "Chart",
            "Diagram",
            "Calculate",
            "Grouping",
            "DocIO",
            "PDF",
            "XlsIO",
            "Barcode"});
            this.listBox1.Location = new System.Drawing.Point(24, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(96, 143);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.listBox2.IntegralHeight = false;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Items.AddRange(new object[] {
            "Grid",
            "Tools",
            "Chart",
            "Diagram",
            "Edit",
            "Calculate",
            "Grouping",
            "DocIO",
            "PDF",
            "XlsIO",
            "HTMLUI",
            "Barcode"});
            this.listBox2.Location = new System.Drawing.Point(24, 165);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(136, 157);
            this.listBox2.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Knowledge Base",
            "Evaluation Center",
            "Direct-Trac",
            "Forums",
            "Feature Requests",
            "Open Issues",
            "Windows Forms FAQs",
            "ASP.NET FAQs"});
            this.checkedListBox1.Location = new System.Drawing.Point(192, 7);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(112, 232);
            this.checkedListBox1.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.treeView1.Location = new System.Drawing.Point(320, 14);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "";
            treeNode1.Text = "Grid";
            treeNode2.Name = "";
            treeNode2.Text = "Tools";
            treeNode3.Name = "";
            treeNode3.Text = "Chart";
            treeNode4.Name = "";
            treeNode4.Text = "Diagram";
            treeNode5.Name = "";
            treeNode5.Text = "Calculate";
            treeNode6.Name = "";
            treeNode6.Text = "Grouping";
            treeNode7.Name = "";
            treeNode7.Text = "DocIO";
            treeNode8.Name = "";
            treeNode8.Text = "PDF";
            treeNode9.Name = "";
            treeNode9.Text = "XlsIO";
            treeNode10.Name = "";
            treeNode10.Text = "Barcode";
            treeNode11.Name = "";
            treeNode11.Text = "Asp.Net";
            treeNode12.Name = "";
            treeNode12.Text = "Grid";
            treeNode13.Name = "";
            treeNode13.Text = "Tools";
            treeNode14.Name = "";
            treeNode14.Text = "Chart";
            treeNode15.Name = "";
            treeNode15.Text = "Diagram";
            treeNode16.Name = "";
            treeNode16.Text = "Edit";
            treeNode17.Name = "";
            treeNode17.Text = "Calculate";
            treeNode18.Name = "";
            treeNode18.Text = "Grouping";
            treeNode19.Name = "";
            treeNode19.Text = "DocIO";
            treeNode20.Name = "";
            treeNode20.Text = "PDF";
            treeNode21.Name = "";
            treeNode21.Text = "XlsIO";
            treeNode22.Name = "";
            treeNode22.Text = "HTMLUI";
            treeNode23.Name = "";
            treeNode23.Text = "Barcode";
            treeNode24.Name = "";
            treeNode24.Text = "Windows Forms";
            treeNode25.Name = "";
            treeNode25.Text = "Products";
            treeNode26.Name = "";
            treeNode26.Text = "Knowledge Base";
            treeNode27.Name = "";
            treeNode27.Text = "Evaluation Center";
            treeNode28.Name = "";
            treeNode28.Text = "Direct-Trac";
            treeNode29.Name = "";
            treeNode29.Text = "Forums";
            treeNode30.Name = "";
            treeNode30.Text = "Feature Requests";
            treeNode31.Name = "";
            treeNode31.Text = "Open Issues";
            treeNode32.Name = "";
            treeNode32.Text = "Windows Forms FAQ";
            treeNode33.Name = "";
            treeNode33.Text = "ASP.NET FAQ";
            treeNode34.Name = "";
            treeNode34.Text = "Support";
            treeNode35.Name = "";
            treeNode35.Text = "Syncfusion";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode35});
            this.treeView1.Size = new System.Drawing.Size(160, 215);
            this.treeView1.TabIndex = 3;
            // 
            // pgDocking
            // 
            this.pgDocking.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.pgDocking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgDocking.HelpBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(224)))), ((int)(((byte)(227)))));
            this.pgDocking.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.pgDocking.Location = new System.Drawing.Point(498, 165);
            this.pgDocking.Name = "pgDocking";
            this.pgDocking.Size = new System.Drawing.Size(130, 116);
            this.pgDocking.TabIndex = 4;
            this.pgDocking.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            // 
            // ilDocking
            // 
            this.ilDocking.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilDocking.ImageStream")));
            this.ilDocking.TransparentColor = System.Drawing.Color.Transparent;
            this.ilDocking.Images.SetKeyName(0, "");
            this.ilDocking.Images.SetKeyName(1, "");
            this.ilDocking.Images.SetKeyName(2, "");
            this.ilDocking.Images.SetKeyName(3, "");
            this.ilDocking.Images.SetKeyName(4, "");
            this.ilDocking.Images.SetKeyName(5, "");
            this.ilDocking.Images.SetKeyName(6, "");
            this.ilDocking.Images.SetKeyName(7, "");
            this.ilDocking.Images.SetKeyName(8, "");
            this.ilDocking.Images.SetKeyName(9, "");
            this.ilDocking.Images.SetKeyName(10, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(640, 494);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.pgDocking);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Code";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		#endregion

		#region Initializing Docking windows

		// <samplecodeblock name="DockingWindows">
		// The method demonstrates how to programmatically initialize and set the docking windows layout.
		private void InitializeDockingWindows()
		{
			// Create the DockingManager instance and set this form as the host form.
			this.dockingManager = new Syncfusion.Windows.Forms.Tools.DockingManager(this.components);
			this.dockingManager.BeginInit();
			this.dockingManager.HostForm = this;
			this.dockingManager.ThemesEnabled=true;
			DockingManager.AnimationStep=5;
			// Disable state persistence.
			this.dockingManager.VisualStyle=Syncfusion.Windows.Forms.VisualStyle.Office2007;
			this.dockingManager.PersistState = false;
			// Enable display of the default context menus.
			this.dockingManager.EnableContextMenu = true;
			// Set the imagelist that will provide the icons for the docking windows.
			this.dockingManager.ImageList = this.ilDocking;

				
			// Dock list box1 to the left border of the form and with an initial 
			// width of 175 units.
			// NOTE - Calling DockControl() on a control for the first time 
			// will initialize it as a docking window. This is the equivalent of 
			// the DockingManager.SetEnableDocking() call.
			this.dockingManager.DockControl(this.listBox1, this, 
				Syncfusion.Windows.Forms.Tools.DockingStyle.Left, 175);
			// Set the text to be displayed in the docking window caption.
			this.dockingManager.SetDockLabel(this.listBox1, "Syncfusion ASP.NET products");
			// The image index used for this control.
			this.dockingManager.SetDockIcon(this.listBox1, 5);

			// Now dock list box2 as a tab onto list box1.
			this.dockingManager.DockControl(this.listBox2, this.listBox1, 
				Syncfusion.Windows.Forms.Tools.DockingStyle.Tabbed, 175);
			this.dockingManager.SetDockLabel(this.listBox2, "Syncfusion Windows Forms Products");
			this.dockingManager.SetDockIcon(this.listBox2, 4);

			//Now dock propertygrid at top of listbox1
			this.pgDocking.SelectedObject=this.dockingManager;
			this.dockingManager.DockControl(this.pgDocking,this,DockingStyle.Right,175);
			this.dockingManager.SetDockLabel(this.pgDocking,"Docking Manager");
			this.dockingManager.SetDockIcon(this.pgDocking,10);
			
			// Dock the treeView to the right border of the form with a width of 150.
			this.dockingManager.DockControl(this.treeView1, this, DockingStyle.Right, 150);
			// Set treeView1 to start off in the AutoHide position.
			this.dockingManager.SetAutoHideMode(this.treeView1, true);
			this.dockingManager.SetDockLabel(this.treeView1, "Syncfusion at a glance");

			this.dockingManager.ActiveCaptionFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dockingManager.InActiveCaptionFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			
			
			this.dockingManager.SetDockIcon(this.treeView1, 9);

			// Set checkedListBox1 to be initially in a floating position.
			Rectangle rcfrm = this.Bounds;
			this.dockingManager.FloatControl(this.checkedListBox1, 
				new Rectangle(rcfrm.Right+25,rcfrm.Bottom-250,175,300));
			this.dockingManager.SetDockLabel(this.checkedListBox1, "Syncfusion support");
			this.dockingManager.SetDockIcon(this.checkedListBox1, 8);
			this.dockingManager.EndInit();
		}

//		private void dockingManager1_ProvideGraphicsItems(object sender, Syncfusion.Windows.Forms.Tools.ProvideGraphicsItemsEventArgs arg)
//		{
//			this.dockingManager.ActiveCaptionFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
//			this.dockingManager.InActiveCaptionFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));			
//		}

		// </samplecodeblock>

		#endregion

		#region Main Function Definition

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			Application.Run(new Form1());
		}

		#endregion

		#region Event Handlers 

		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}

		#endregion

	}

	#endregion
}
