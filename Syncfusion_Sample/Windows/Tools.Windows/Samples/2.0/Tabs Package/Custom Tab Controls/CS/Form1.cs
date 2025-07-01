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
using System.Reflection ;
using Syncfusion.Windows.Forms.Tools;
using System.Drawing.Drawing2D;

namespace CustomTabControls
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Panel panel1;
		private System.ComponentModel.IContainer components;

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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControlAdv1.BackColor = System.Drawing.Color.White;
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.ImageList = this.imageList1;
            this.tabControlAdv1.ItemSize = new System.Drawing.Size(80, 30);
            this.tabControlAdv1.Location = new System.Drawing.Point(16, 16);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(296, 187);
            this.tabControlAdv1.TabIndex = 0;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(212)))), ((int)(((byte)(241)))));
            this.tabControlAdv1.DrawItem += new Syncfusion.Windows.Forms.Tools.DrawTabEventHandler(this.tabControlAdv1_DrawItem);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.button2);
            this.tabPageAdv1.Controls.Add(this.button1);
            this.tabPageAdv1.ImageIndex = 0;
            this.tabPageAdv1.Location = new System.Drawing.Point(0, 32);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(296, 155);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(212)))), ((int)(((byte)(241)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(48, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Custom Tab: Flat Look";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(212)))), ((int)(((byte)(241)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(48, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Custom Tab: Notched";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.ImageIndex = 1;
            this.tabPageAdv2.Location = new System.Drawing.Point(0, 32);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(296, 155);
            this.tabPageAdv2.TabIndex = 1;
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.ImageIndex = 2;
            this.tabPageAdv3.Location = new System.Drawing.Point(0, 32);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.Size = new System.Drawing.Size(296, 155);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(211)))), ((int)(((byte)(241)))));
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Custom Tab Appearances via DrawItem handler:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Yahoo Messenger Like",
            "MSN Like"});
            this.comboBox1.Location = new System.Drawing.Point(16, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.propertyGrid1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.propertyGrid1.Location = new System.Drawing.Point(336, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(208, 302);
            this.propertyGrid1.TabIndex = 3;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(211)))), ((int)(((byte)(241))))), System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(241))))));
            this.gradientPanel1.BorderColor = System.Drawing.Color.Black;
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Controls.Add(this.comboBox1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(544, 302);
            this.gradientPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tabControlAdv1);
            this.panel1.Location = new System.Drawing.Point(-2, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 222);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(544, 302);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Custom Tab Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			Application.Run(new Form1());
		}

		// In Yahoo Messenger(R) like look and feel, the active tab is the only tab
		// that gets a border around it, the rest of the tabs are border less.
		// This can be easily achieved by setting the TabStyle to
		// "3D" (typeof(TabRenderer3D), handling the DrawItem event, delegating the
		// background and interior drawing to the default drawing logic and delegating
		// the border drawing logic to the default drawing logic only if the corresponding
		// tab is active.
		private void Tab_DrawItemYahooMessengerLike(object sender, DrawTabEventArgs drawItemInfo)
		{
			// This will work only when the TabStyle is set to 3D (typeof(TabRenderer3D))
			
			// Draw the default background and interior in all cases.
			drawItemInfo.DrawBackground();
			drawItemInfo.DrawInterior();

			// The border should be drawn only when the item is selected or highlighted.
			if(((int)drawItemInfo.State & 
				((int)DrawItemState.Selected | (int)DrawItemState.HotLight)) > 0)
			{
				// Draw the borders
				drawItemInfo.DrawBorders();
			}
		}

		// <samplecodeblock name="Custom Tab Drawing">
		// The TabControlAdv.DrawItem event handler.
		private void Tab_DrawItemMSNMessengerLike(object sender, DrawTabEventArgs drawItemInfo)
		{
			Rectangle rectTab = drawItemInfo.Bounds;
			Graphics g = drawItemInfo.Graphics;
			g.SmoothingMode = SmoothingMode.AntiAlias;
			// Create a path for the border
			GraphicsPath gp = new GraphicsPath();
			
			gp.AddBezier(rectTab.Right - 1, rectTab.Bottom + 6, rectTab.Right-1, rectTab.Bottom + 2,
				rectTab.Left, rectTab.Bottom-3, rectTab.Left, rectTab.Bottom-7);
			gp.AddLine(rectTab.Left, rectTab.Bottom-4, rectTab.Left, rectTab.Top + 5);
			Point[] curvePoints1 = {new Point(rectTab.Left, rectTab.Top + 5),
									new Point(rectTab.Left+2, rectTab.Top+2),
									new Point(rectTab.Left+3, rectTab.Top+1),
									new Point(rectTab.Left+5, rectTab.Top)};
			gp.AddCurve(curvePoints1);
			gp.AddBezier(curvePoints1[0], curvePoints1[1], curvePoints1[2], curvePoints1[3]);
			gp.AddLine(curvePoints1[3], new Point(rectTab.Right-6, rectTab.Top));
			Point[] curvePoints2 = {new Point(rectTab.Right-6, rectTab.Top),
									new Point(rectTab.Right-2, rectTab.Top-1),
									new Point(rectTab.Right-2, rectTab.Top-3),
									new Point(rectTab.Right-1, rectTab.Top - 5)};
			gp.AddCurve(curvePoints2);

			if(((int)drawItemInfo.State & (int)DrawItemState.Selected) > 0)
			{
				g.FillPath(new SolidBrush(drawItemInfo.BackColor), gp);

				drawItemInfo.DrawInterior();
			}
			else
			{
				// Draw the Text and Image first
				drawItemInfo.DrawInterior();
				// Then alpha blend active tab color over it
				g.FillPath(new SolidBrush(Color.FromArgb(128, this.tabControlAdv1.ActiveTabColor)), gp);
			}
		}
		// </samplecodeblock>

		private void tabControlAdv1_DrawItem(object sender, Syncfusion.Windows.Forms.Tools.DrawTabEventArgs drawItemInfo)
		{
			drawItemInfo.DrawBackground();
			drawItemInfo.DrawInterior();

			switch(this.comboBox1.SelectedIndex)
			{
				case 0:this.Tab_DrawItemYahooMessengerLike(sender, drawItemInfo);
					break;
				case 1: this.Tab_DrawItemMSNMessengerLike(sender, drawItemInfo);
					break;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(this.comboBox1.SelectedIndex)
			{
					// Yahoo-Messenger like
				case 0: this.tabControlAdv1.TabStyle = typeof(TabRenderer3D);
					this.tabControlAdv1.Alignment = TabAlignment.Bottom;
					
					//Resetting MSN like settings
					this.tabControlAdv1.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.Normal;
					this.tabControlAdv1.BackColor = Color.White;
					this.tabControlAdv1.ActiveTabColor = this.tabControlAdv1.BackColor;
					this.tabControlAdv1.TabPanelBackColor = Color.FromArgb(183, 212, 241);//this.BackColor;
					this.tabControlAdv1.TabGap = 0;
					this.tabControlAdv1.FocusOnTabClick = false;
					break;
					// MSN Messenger like
				case 1: this.tabControlAdv1.TabStyle = typeof(TabRenderer3D);
					this.tabControlAdv1.Alignment = TabAlignment.Left;
					this.tabControlAdv1.ItemSize = new Size(50, 50);
					this.tabControlAdv1.SizeMode = Syncfusion.Windows.Forms.Tools.TabSizeMode.Fixed;
					this.tabControlAdv1.ActiveTabColor = Color.White;
					this.tabControlAdv1.TabPanelBackColor = Color.FromArgb(183, 212, 241);
					this.tabControlAdv1.TabGap = 10;
					break;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.comboBox1.SelectedIndex = 1;
			this.comboBox1.SelectedIndex = 0;
			this.propertyGrid1.SelectedObject = this.tabControlAdv1;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Form2 form2 = new Form2();
			form2.Visible = true;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Form3 form3 = new Form3();
			form3.Visible = true;
		}
	}
}
