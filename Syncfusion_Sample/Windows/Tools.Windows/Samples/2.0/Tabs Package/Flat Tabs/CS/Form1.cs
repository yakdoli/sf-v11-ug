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
using System.Drawing.Drawing2D;

using Syncfusion.Windows.Forms.Tools;
namespace FlatTabs
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private FlatTabs.FlatTab flatTab1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
		private System.Windows.Forms.ImageList imageList1;
		private FlatTabs.CustomXPTaskBar xpTaskBar1;
		private XPTaskBarBox xpTaskBarBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private Syncfusion.Reflection.TypeLoader designTimeTabTypeLoader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ImageList imageList2;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			this.BackColor = System.Drawing.Color.Empty;
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
			this.flatTab1 = new FlatTabs.FlatTab();
			this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.label3 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.xpTaskBar1 = new FlatTabs.CustomXPTaskBar();
			this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.designTimeTabTypeLoader = new Syncfusion.Reflection.TypeLoader(this.components);
			((System.ComponentModel.ISupportInitialize)(this.flatTab1)).BeginInit();
			this.flatTab1.SuspendLayout();
			this.tabPageAdv2.SuspendLayout();
			this.tabPageAdv1.SuspendLayout();
			this.tabPageAdv3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
			this.xpTaskBar1.SuspendLayout();
			this.xpTaskBarBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flatTab1
			// 
			this.flatTab1.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.flatTab1.BackColor = System.Drawing.Color.White;
			this.flatTab1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.tabPageAdv2,
																				   this.tabPageAdv1,
																				   this.tabPageAdv3});
			this.flatTab1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flatTab1.FocusOnTabClick = false;
			this.flatTab1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.flatTab1.ImageAlignmentR = Syncfusion.Windows.Forms.Tools.RelativeImageAlignment.AboveText;
			this.flatTab1.ImageList = this.imageList1;
			this.flatTab1.ItemSize = new System.Drawing.Size(120, 120);
			this.flatTab1.Name = "flatTab1";
			this.flatTab1.RotateTextWhenVertical = true;
			this.flatTab1.Size = new System.Drawing.Size(464, 334);
			this.flatTab1.TabGap = 3;
			this.flatTab1.TabIndex = 0;
			this.flatTab1.TabStop = false;
			this.flatTab1.TabStyle = typeof(FlatTabs.FlatTabRenderer);
			this.flatTab1.SelectedIndexChanged += new System.EventHandler(this.flatTab1_SelectedIndexChanged);
			// 
			// tabPageAdv2
			// 
			this.tabPageAdv2.BackColor = System.Drawing.Color.White;
			this.tabPageAdv2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.label1});
			this.tabPageAdv2.ImageIndex = 0;
			this.tabPageAdv2.Location = new System.Drawing.Point(120, 1);
			this.tabPageAdv2.Name = "tabPageAdv2";
			this.tabPageAdv2.Size = new System.Drawing.Size(342, 331);
			this.tabPageAdv2.TabIndex = 1;
			this.tabPageAdv2.Text = "Accounts";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(72, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "TabPage1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPageAdv1
			// 
			this.tabPageAdv1.BackColor = System.Drawing.Color.White;
			this.tabPageAdv1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.label2});
			this.tabPageAdv1.ImageIndex = 2;
			this.tabPageAdv1.Location = new System.Drawing.Point(120, 1);
			this.tabPageAdv1.Name = "tabPageAdv1";
			this.tabPageAdv1.Size = new System.Drawing.Size(342, 331);
			this.tabPageAdv1.TabIndex = 0;
			this.tabPageAdv1.Text = "Cases";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(72, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 40);
			this.label2.TabIndex = 1;
			this.label2.Text = "TabPage2";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPageAdv3
			// 
			this.tabPageAdv3.BackColor = System.Drawing.Color.White;
			this.tabPageAdv3.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.label3});
			this.tabPageAdv3.ImageIndex = 1;
			this.tabPageAdv3.Location = new System.Drawing.Point(120, 1);
			this.tabPageAdv3.Name = "tabPageAdv3";
			this.tabPageAdv3.Size = new System.Drawing.Size(342, 331);
			this.tabPageAdv3.TabIndex = 2;
			this.tabPageAdv3.Text = "Contacts";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(72, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 40);
			this.label3.TabIndex = 1;
			this.label3.Text = "TabPage3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// xpTaskBar1
			// 
			this.xpTaskBar1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.xpTaskBar1.AutoPersistStates = true;
			this.xpTaskBar1.AutoScroll = true;
			this.xpTaskBar1.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBar1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.xpTaskBarBox1});
			this.xpTaskBar1.DockPadding.All = 5;
			this.xpTaskBar1.Location = new System.Drawing.Point(0, 201);
			this.xpTaskBar1.Name = "xpTaskBar1";
			this.xpTaskBar1.Size = new System.Drawing.Size(120, 128);
			this.xpTaskBar1.TabIndex = 1;
			this.xpTaskBar1.ThemesEnabled = true;
			// 
			// xpTaskBarBox1
			// 
			this.xpTaskBarBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.panel1});
			this.xpTaskBarBox1.HeaderBackColor = System.Drawing.SystemColors.Desktop;
			this.xpTaskBarBox1.HeaderImageIndex = 0;
			this.xpTaskBarBox1.HeaderImageList = this.imageList2;
			this.xpTaskBarBox1.ItemBackColor = System.Drawing.SystemColors.ControlLightLight;
			this.xpTaskBarBox1.Location = new System.Drawing.Point(5, 5);
			this.xpTaskBarBox1.Name = "xpTaskBarBox1";
			this.xpTaskBarBox1.PreferredChildPanelHeight = 60;
			this.xpTaskBarBox1.Size = new System.Drawing.Size(110, 106);
			this.xpTaskBarBox1.TabIndex = 7;
			this.xpTaskBarBox1.Text = "Search";
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button1,
																				 this.comboBox1});
			this.panel1.Location = new System.Drawing.Point(2, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(106, 60);
			this.panel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(24, 32);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "Go";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "Search1",
														   "Search2",
														   "Search3"});
			this.comboBox1.Location = new System.Drawing.Point(8, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(88, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// imageList2
			// 
			this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList2.ImageSize = new System.Drawing.Size(32, 32);
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// designTimeTabTypeLoader
			// 
			this.designTimeTabTypeLoader.TypesToLoadList.Add(new Syncfusion.Reflection.TypeName("FlatTabs.FlatTabRenderer"));
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(464, 334);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.xpTaskBar1,
																		  this.flatTab1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Flat Tabs ";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			((System.ComponentModel.ISupportInitialize)(this.flatTab1)).EndInit();
			this.flatTab1.ResumeLayout(false);
			this.tabPageAdv2.ResumeLayout(false);
			this.tabPageAdv1.ResumeLayout(false);
			this.tabPageAdv3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
			this.xpTaskBar1.ResumeLayout(false);
			this.xpTaskBarBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
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

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(this.ClientRectangle.Width > 0 && this.ClientRectangle.Height > 0)
			{
				LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, SystemColors.Control, SystemColors.ControlDark, LinearGradientMode.Horizontal);
				e.Graphics.FillRectangle(lgb, this.ClientRectangle);
			}
		}

		private void flatTab1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
