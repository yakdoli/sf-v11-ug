#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.HTMLUI;

namespace Syncfusion.Windows.Forms.samples.HTMLUIExplorer
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		#region Variables
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton toolBarButton2;
		private System.Windows.Forms.ToolBarButton toolBarButton3;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton toolBarButton6;
		private System.Windows.Forms.ToolBarButton toolBarButton7;
		private System.Windows.Forms.ToolBarButton toolBarButton8;
		private System.Windows.Forms.ToolBarButton toolBarButton9;
		private System.Windows.Forms.ToolBarButton toolBarButton10;
		private System.Windows.Forms.ToolBarButton toolBarButton11;
		private System.Windows.Forms.ToolBarButton toolBarButton12;
		private System.Windows.Forms.ToolBarButton toolBarButton13;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		Uri home;
		string selectedText = "";
		string homeLocation = "";
		HTMLUIPrintDocument pd;
		float DftfontSize = 0;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		float fontSize = 0;
		#endregion

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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.toolBar1 = new System.Windows.Forms.ToolBar();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton2 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton11 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton3 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton12 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton6 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton7 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton13 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton8 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton9 = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton10 = new System.Windows.Forms.ToolBarButton();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.AllowDrop = true;
			this.htmluiControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.htmluiControl1.AutoRunScripts = true;
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(525, 257);
			this.htmluiControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Location = new System.Drawing.Point(0, 80);
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.Size = new System.Drawing.Size(552, 272);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "htmluiControl1";
			this.htmluiControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.htmluiControl1_KeyDown);
			this.htmluiControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.htmluiControl1_DragDrop);
			this.htmluiControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.htmluiControl1_DragEnter);
			this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem1,
																																							this.menuItem4,
																																							this.menuItem13,
																																							this.menuItem8,
																																							this.menuItem10,
																																							this.menuItem25});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem2,
																																							this.menuItem5,
																																							this.menuItem6,
																																							this.menuItem3});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "Load From File";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 1;
			this.menuItem5.Text = "Print Preview";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 2;
			this.menuItem6.Text = "Print";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 3;
			this.menuItem3.Text = "Exit";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem7});
			this.menuItem4.Text = "Edit";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Text = "Copy Selected Text";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 2;
			this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							 this.menuItem14});
			this.menuItem13.Text = "Format";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 0;
			this.menuItem14.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							 this.menuItem15,
																																							 this.menuItem16});
			this.menuItem14.Text = "Font";
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 0;
			this.menuItem15.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							 this.menuItem17,
																																							 this.menuItem18,
																																							 this.menuItem19,
																																							 this.menuItem24});
			this.menuItem15.Text = "Face";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 0;
			this.menuItem17.Text = "Arial";
			this.menuItem17.Click += new System.EventHandler(this.menuItem17_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 1;
			this.menuItem18.Text = "Courier New";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 2;
			this.menuItem19.Text = "Century Gothic";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 3;
			this.menuItem24.Text = "Tahoma";
			this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 1;
			this.menuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							 this.menuItem20,
																																							 this.menuItem21,
																																							 this.menuItem22,
																																							 this.menuItem23});
			this.menuItem16.Text = "Size";
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 0;
			this.menuItem20.Text = "Default";
			this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 1;
			this.menuItem21.Text = "Large";
			this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 2;
			this.menuItem22.Text = "Medium";
			this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 3;
			this.menuItem23.Text = "Small";
			this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 3;
			this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem9});
			this.menuItem8.Text = "Options";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Text = "Set Current Page As My Home Page";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 4;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							 this.menuItem11,
																																							 this.menuItem12});
			this.menuItem10.Text = "View";
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 0;
			this.menuItem11.Text = "View HTML";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.Text = "View XML";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 5;
			this.menuItem25.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							 this.menuItem26,
																																							 this.menuItem28,
																																							 this.menuItem27});
			this.menuItem25.Text = "Help";
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 0;
			this.menuItem26.Text = "Knowledge Base";
			this.menuItem26.Click += new System.EventHandler(this.menuItem26_Click);
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 1;
			this.menuItem28.Text = "About HTMLUI";
			this.menuItem28.Click += new System.EventHandler(this.menuItem28_Click);
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 2;
			this.menuItem27.Text = "About Syncfusion";
			this.menuItem27.Click += new System.EventHandler(this.menuItem27_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(229)), ((System.Byte)(245)));
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button12);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(552, 80);
			this.panel1.TabIndex = 1;
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.comboBox1.Location = new System.Drawing.Point(72, 48);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(392, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "http://www.Google.com/";
			this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.toolBar1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(552, 40);
			this.panel3.TabIndex = 3;
			// 
			// toolBar1
			// 
			this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar1.AutoSize = false;
			this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																																								this.toolBarButton1,
																																								this.toolBarButton2,
																																								this.toolBarButton11,
																																								this.toolBarButton3,
																																								this.toolBarButton4,
																																								this.toolBarButton12,
																																								this.toolBarButton6,
																																								this.toolBarButton7,
																																								this.toolBarButton13,
																																								this.toolBarButton8,
																																								this.toolBarButton9,
																																								this.toolBarButton10});
			this.toolBar1.ButtonSize = new System.Drawing.Size(25, 25);
			this.toolBar1.DropDownArrows = true;
			this.toolBar1.ImageList = this.imageList1;
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.ShowToolTips = true;
			this.toolBar1.Size = new System.Drawing.Size(552, 40);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.ImageIndex = 4;
			this.toolBarButton1.Tag = "1";
			this.toolBarButton1.ToolTipText = "Navigate Previous";
			// 
			// toolBarButton2
			// 
			this.toolBarButton2.ImageIndex = 3;
			this.toolBarButton2.Tag = "2";
			this.toolBarButton2.ToolTipText = "Navigate Next";
			// 
			// toolBarButton11
			// 
			this.toolBarButton11.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton3
			// 
			this.toolBarButton3.ImageIndex = 9;
			this.toolBarButton3.Tag = "3";
			this.toolBarButton3.ToolTipText = "Exit";
			// 
			// toolBarButton4
			// 
			this.toolBarButton4.ImageIndex = 10;
			this.toolBarButton4.Tag = "4";
			this.toolBarButton4.ToolTipText = "Copy to ClipBoard";
			// 
			// toolBarButton12
			// 
			this.toolBarButton12.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton6
			// 
			this.toolBarButton6.ImageIndex = 6;
			this.toolBarButton6.Tag = "6";
			this.toolBarButton6.ToolTipText = "Refresh";
			// 
			// toolBarButton7
			// 
			this.toolBarButton7.ImageIndex = 2;
			this.toolBarButton7.Tag = "7";
			this.toolBarButton7.ToolTipText = "Home";
			// 
			// toolBarButton13
			// 
			this.toolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolBarButton8
			// 
			this.toolBarButton8.ImageIndex = 7;
			this.toolBarButton8.Tag = "8";
			this.toolBarButton8.ToolTipText = "Search for the text";
			// 
			// toolBarButton9
			// 
			this.toolBarButton9.ImageIndex = 0;
			this.toolBarButton9.Tag = "9";
			this.toolBarButton9.ToolTipText = "Open In Default Browser";
			// 
			// toolBarButton10
			// 
			this.toolBarButton10.ImageIndex = 5;
			this.toolBarButton10.Tag = "10";
			this.toolBarButton10.ToolTipText = "Print";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(229)), ((System.Byte)(245)));
			// 
			// label1
			// 
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(8, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Address";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.SystemColors.Window;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(472, 48);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(30, 21);
			this.button1.TabIndex = 1;
			this.button1.Text = "...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button12
			// 
			this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button12.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(229)), ((System.Byte)(245)));
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button12.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(229)), ((System.Byte)(245)));
			this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
			this.button12.Location = new System.Drawing.Point(512, 48);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(32, 24);
			this.button12.TabIndex = 2;
			this.button12.Click += new System.EventHandler(this.button12_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(552, 353);
			this.Controls.Add(this.htmluiControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(229)), ((System.Byte)(245)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HTMLUI Explorer";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		#region ClassHelperEvents
		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.htmluiControl1.LoadFromString("<body bgcolor=#ffffff></body>");
			this.DftfontSize = this.htmluiControl1.DefaultFormat.Font.Size;
			this.fontSize = this.DftfontSize;
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			pd = new HTMLUIPrintDocument( this.htmluiControl1.Document );
			this.htmluiControl1.Cursor = Cursors.Default;
			if(this.htmluiControl1.Document.IsFileName == true)
			{
				this.comboBox1.Text = this.htmluiControl1.Document.FileName.ToString();
				Console.WriteLine("File Loaded from drive: "+ this.htmluiControl1.Document.FileName.ToString());
			}
			if(this.htmluiControl1.Document.IsUri == true)
			{
				this.comboBox1.Text = this.htmluiControl1.Document.Uri.ToString();
				Console.WriteLine("File Loaded from URI: "+ this.htmluiControl1.Document.Uri.ToString());
			}
			this.htmluiControl1.DefaultFormat.Cursor = Cursors.IBeam;
		}
		#endregion

		#region UI Events

		private void htmluiControl1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if(e.Data.GetDataPresent (DataFormats.FileDrop)) 
				e.Effect = DragDropEffects.All;
			else 
				e.Effect = DragDropEffects.None;		
		}

		private void htmluiControl1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] files = (string[])e.Data.GetData("FileDrop", false); 

			foreach (string fileName in files) 
			{ 
				this.htmluiControl1.LoadHTML(fileName);
			}
		}

		private void htmluiControl1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.Alt == true && e.KeyCode == Keys.F4)
			{
				ExitApplication();
			}
		}

		private void comboBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				LoadDocument();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Uri uri = new Uri(this.comboBox1.SelectedItem.ToString());
			this.htmluiControl1.LoadHTML(uri);
			this.htmluiControl1.Refresh();
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if(Convert.ToInt32(e.Button.Tag) == 1)
			{
				this.htmluiControl1.Back(-1);
				this.htmluiControl1.Refresh();
			}
			
			if(Convert.ToInt32(e.Button.Tag) == 2)
			{
				this.htmluiControl1.Forward(1);
				this.htmluiControl1.Refresh();
			}

			if(Convert.ToInt32(e.Button.Tag) == 3)
			{
				Application.Exit();
			}

			if(Convert.ToInt32(e.Button.Tag) == 4)
			{
				CopyText();
			}

			if(Convert.ToInt32(e.Button.Tag) == 6)
			{
				this.htmluiControl1.Refresh();
			}

			if(Convert.ToInt32(e.Button.Tag) == 7)
			{
				try
				{
					if(this.homeLocation == "")
					{
						this.htmluiControl1.LoadHTML(this.home);
						this.comboBox1.Text = this.htmluiControl1.Document.Uri.ToString();
					}
					else
					{
						this.htmluiControl1.LoadHTML(this.homeLocation);
						this.comboBox1.Text = this.htmluiControl1.Document.FileName.ToString();
					}
				}
				catch(Exception)
				{
					MessageBox.Show("Please set your Home page from the options menu before using this option.");
				}
			}

			if(Convert.ToInt32(e.Button.Tag) == 8)
			{
				this.htmluiControl1.DisplayFindForm();
			}

			if(Convert.ToInt32(e.Button.Tag) == 9)
			{
				if(this.comboBox1.Text != "")
				{
					Process process = Process.Start(this.comboBox1.Text.ToString());
				}
				else
				{
					Console.WriteLine("Please enter your file name in the text box.");
				}
			}

			if(Convert.ToInt32(e.Button.Tag) == 10)
			{
				PrintDocument();
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.openFileDialog1.Filter = "htm files(*.htm)|*.htm|html files(*.html)|*.html|mht files(*.mht)|*.mht";
			if (LoadTheHTML() && this.comboBox1.Text != "")
			{
				this.htmluiControl1.LoadHTML(this.comboBox1.Text);
				this.htmluiControl1.Cursor = Cursors.Arrow;
			}
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			ExitApplication();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			PrintPreview();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			PrintDocument();
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			CopyText();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			if(this.comboBox1.Text != "")
			{
				if(this.htmluiControl1.Document.IsFileName == true)
				{
					this.homeLocation = this.htmluiControl1.Document.FileName.ToString();
				}
				if(this.htmluiControl1.Document.IsUri == true)
				{
					this.home = this.htmluiControl1.Document.Uri;
				}
			}
			else
			{
				MessageBox.Show("Load the page to use it as your home page.");
			}
		}


		private void menuItem11_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.htmluiControl1.Text);
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this.htmluiControl1.Document.Document.OuterXml.ToString());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.openFileDialog1.Filter = "htm files(*.htm)|*.htm|html files(*.html)|*.html";
			LoadTheHTML();
			LoadDocument();
		}

		private void button12_Click(object sender, System.EventArgs e)
		{
			LoadDocument();
		}

		private void menuItem17_Click(object sender, System.EventArgs e)
		{
			this.htmluiControl1.DefaultFormat.Font = new Font("Arial", this.fontSize);			
		}

		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			this.htmluiControl1.DefaultFormat.Font = new Font("Courier New", this.fontSize);
		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			this.htmluiControl1.DefaultFormat.Font = new Font("Century Gothic", this.fontSize);
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			this.fontSize = this.DftfontSize;
			ChangeFontSize();
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			this.fontSize = (this.DftfontSize + 7);
			ChangeFontSize();
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			this.fontSize = (this.DftfontSize + 3);
			ChangeFontSize();
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			if((this.DftfontSize - 3) > 0)
			{
				this.fontSize = (this.DftfontSize - 3);
				ChangeFontSize();
			}
			else
			{
				MessageBox.Show("Font size cannot be less than or equal to zero");
			}
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			this.htmluiControl1.DefaultFormat.Font = new Font("Tahoma", this.fontSize);
		}

		

		private void menuItem26_Click(object sender, System.EventArgs e)
		{
			Process process = Process.Start("http://www.syncfusion.com/support/kb/htmlui/Default.aspx");
		}

		private void menuItem28_Click(object sender, System.EventArgs e)
		{
			Process process = Process.Start("http://www.syncfusion.com/Products/product.aspx?p=25&tab_id=0");
		}

		private void menuItem27_Click(object sender, System.EventArgs e)
		{
			Process process = Process.Start("http://www.syncfusion.com/default.aspx");
		}

		#endregion

		#region UI methods
		private bool LoadTheHTML()
		{
			bool result = false;
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if(this.openFileDialog1.FileName != "")
				{
					this.comboBox1.Text = this.openFileDialog1.FileName;
					this.htmluiControl1.Cursor = Cursors.Arrow;

					result = true;
				}
			}
			else
			{
				this.htmluiControl1.Cursor = Cursors.Arrow;
				this.htmluiControl1.Refresh();

				result = false;
			}
			return result;
		}

		private void LoadDocument()
		{
			this.htmluiControl1.Cursor = Cursors.WaitCursor;
			if(comboBox1.Text != "")
			{
				Console.WriteLine("Loading the Specified URI...");
				try
				{
					Uri uri = new Uri(this.comboBox1.Text);
					this.htmluiControl1.LoadHTML(uri);
					this.htmluiControl1.Cursor = Cursors.Arrow;
				}
				catch(Exception exc)
				{
					MessageBox.Show(exc.ToString());
				}
			}
			else
			{
				Console.WriteLine("Uri is Empty");
				this.htmluiControl1.Cursor = Cursors.Arrow;
			}
			this.comboBox1.Items.Add(this.comboBox1.Text.ToString());
		}

		private void CopyText()
		{
			this.selectedText = this.htmluiControl1.SelectedText.ToString();
			if(this.selectedText != "")
			{
				Clipboard.SetDataObject(this.selectedText, true);
			}
			else
			{
				Console.WriteLine("Please select some text");
			}
		}

		private void ChangeFontSize()
		{
			try
			{
				this.htmluiControl1.DefaultFormat.Font = new Font(this.htmluiControl1.DefaultFormat.Font.FontFamily, this.fontSize);
			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
			}
		}

		private void PrintDocument()
		{
			if(this.htmluiControl1.Document.Document.OuterXml != "")
			{
				PrintDialog dg = new PrintDialog();
				dg.AllowSomePages = true;
				dg.Document = pd;
				if(dg.ShowDialog() == DialogResult.OK)
					pd.Print();
			}

			else
			{
				Console.WriteLine("The current document is not valid for printing");
			}
		}

		private void PrintPreview()
		{
			PrintPreviewDialog dlg = new PrintPreviewDialog() ;
			dlg.Document = pd;
			dlg.ShowDialog();
		}

		private void ExitApplication()
		{
			Application.Exit();
		}
		#endregion

	}
}