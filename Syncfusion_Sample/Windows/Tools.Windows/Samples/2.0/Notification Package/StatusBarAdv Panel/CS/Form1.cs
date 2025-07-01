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

namespace StatusBarAdvPanelDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel2;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel3;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel4;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel5;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel7;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel6;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel8;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;

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
			this.statusBarAdvPanel1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.statusBarAdvPanel2 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.statusBarAdvPanel3 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.statusBarAdvPanel4 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.statusBarAdvPanel5 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.statusBarAdv1 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
			this.statusBarAdvPanel8 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.statusBarAdvPanel6 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.statusBarAdvPanel7 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).BeginInit();
			this.statusBarAdvPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).BeginInit();
			this.statusBarAdv1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel7)).BeginInit();
			this.SuspendLayout();
			// 
			// statusBarAdvPanel1
			// 
			this.statusBarAdvPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.statusBarAdvPanel1.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdvPanel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																							 this.statusBarAdvPanel2});
			this.statusBarAdvPanel1.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.statusBarAdvPanel1.Location = new System.Drawing.Point(280, 32);
			this.statusBarAdvPanel1.Name = "statusBarAdvPanel1";
			this.statusBarAdvPanel1.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongDate;
			this.statusBarAdvPanel1.Size = new System.Drawing.Size(216, 24);
			this.statusBarAdvPanel1.TabIndex = 0;
			this.statusBarAdvPanel1.Text = "statusBarAdvPanel1";
			// 
			// statusBarAdvPanel2
			// 
			this.statusBarAdvPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.statusBarAdvPanel2.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdvPanel2.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.statusBarAdvPanel2.Location = new System.Drawing.Point(-2, -2);
			this.statusBarAdvPanel2.Name = "statusBarAdvPanel2";
			this.statusBarAdvPanel2.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongDate;
			this.statusBarAdvPanel2.Size = new System.Drawing.Size(216, 24);
			this.statusBarAdvPanel2.TabIndex = 1;
			this.statusBarAdvPanel2.Text = "statusBarAdvPanel1";
			// 
			// statusBarAdvPanel3
			// 
			this.statusBarAdvPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Transparent, System.Drawing.SystemColors.Window);
			this.statusBarAdvPanel3.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdvPanel3.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.statusBarAdvPanel3.Location = new System.Drawing.Point(280, 112);
			this.statusBarAdvPanel3.Name = "statusBarAdvPanel3";
			this.statusBarAdvPanel3.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortDate;
			this.statusBarAdvPanel3.Size = new System.Drawing.Size(216, 24);
			this.statusBarAdvPanel3.TabIndex = 1;
			this.statusBarAdvPanel3.Text = "statusBarAdvPanel1";
			this.statusBarAdvPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.statusBarAdvPanel3_Paint);
			// 
			// statusBarAdvPanel4
			// 
			this.statusBarAdvPanel4.BackColor = System.Drawing.Color.Transparent;
			this.statusBarAdvPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.statusBarAdvPanel4.BorderColor = System.Drawing.Color.Blue;
			this.statusBarAdvPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.statusBarAdvPanel4.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.statusBarAdvPanel4.Location = new System.Drawing.Point(280, 184);
			this.statusBarAdvPanel4.Name = "statusBarAdvPanel4";
			this.statusBarAdvPanel4.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CapsLockState;
			this.statusBarAdvPanel4.Size = new System.Drawing.Size(216, 24);
			this.statusBarAdvPanel4.TabIndex = 2;
			this.statusBarAdvPanel4.Text = "statusBarAdvPanel1";
			// 
			// statusBarAdvPanel5
			// 
			this.statusBarAdvPanel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.statusBarAdvPanel5.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdvPanel5.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.statusBarAdvPanel5.Location = new System.Drawing.Point(280, 272);
			this.statusBarAdvPanel5.Name = "statusBarAdvPanel5";
			this.statusBarAdvPanel5.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ScrollLockState;
			this.statusBarAdvPanel5.Size = new System.Drawing.Size(216, 24);
			this.statusBarAdvPanel5.TabIndex = 3;
			this.statusBarAdvPanel5.Text = "statusBarAdvPanel1";
			// 
			// statusBarAdv1
			// 
			this.statusBarAdv1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(241)), ((System.Byte)(254)));
			this.statusBarAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.statusBarAdv1.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdv1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.statusBarAdvPanel8,
																						this.statusBarAdvPanel6,
																						this.statusBarAdvPanel7});
			this.statusBarAdv1.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
			this.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusBarAdv1.DockPadding.All = 3;
			this.statusBarAdv1.Location = new System.Drawing.Point(0, 342);
			this.statusBarAdv1.Name = "statusBarAdv1";
			this.statusBarAdv1.Size = new System.Drawing.Size(552, 32);
			this.statusBarAdv1.SizingGrip = false;
			this.statusBarAdv1.Spacing = new System.Drawing.Size(2, 2);
			this.statusBarAdv1.TabIndex = 8;
			this.statusBarAdv1.ThemesEnabled = true;
			// 
			// statusBarAdvPanel8
			// 
			this.statusBarAdvPanel8.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.statusBarAdvPanel8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(241)), ((System.Byte)(254)));
			this.statusBarAdvPanel8.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Info, System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(64)), ((System.Byte)(64))));
			this.statusBarAdvPanel8.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdvPanel8.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
			this.statusBarAdvPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.statusBarAdvPanel8.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.statusBarAdvPanel8.Location = new System.Drawing.Point(0, 2);
			this.statusBarAdvPanel8.Name = "statusBarAdvPanel8";
			this.statusBarAdvPanel8.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.LongTime;
			this.statusBarAdvPanel8.Size = new System.Drawing.Size(67, 24);
			this.statusBarAdvPanel8.SizeToContent = true;
			this.statusBarAdvPanel8.TabIndex = 12;
			this.statusBarAdvPanel8.Text = null;
			this.statusBarAdvPanel8.ThemesEnabled = true;
			// 
			// statusBarAdvPanel6
			// 
			this.statusBarAdvPanel6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(241)), ((System.Byte)(254)));
			this.statusBarAdvPanel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.statusBarAdvPanel6.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdvPanel6.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
			this.statusBarAdvPanel6.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify;
			this.statusBarAdvPanel6.Location = new System.Drawing.Point(69, 2);
			this.statusBarAdvPanel6.Name = "statusBarAdvPanel6";
			this.statusBarAdvPanel6.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CurrentCulture;
			this.statusBarAdvPanel6.PreferredSize = new System.Drawing.Size(183, 24);
			this.statusBarAdvPanel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.statusBarAdvPanel6.Size = new System.Drawing.Size(286, 24);
			this.statusBarAdvPanel6.TabIndex = 11;
			this.statusBarAdvPanel6.Text = "statusBarAdvPanel6";
			// 
			// statusBarAdvPanel7
			// 
			this.statusBarAdvPanel7.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Info, System.Drawing.SystemColors.InactiveBorder);
			this.statusBarAdvPanel7.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdvPanel7.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
			this.statusBarAdvPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.statusBarAdvPanel7.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right;
			this.statusBarAdvPanel7.Location = new System.Drawing.Point(357, 2);
			this.statusBarAdvPanel7.Name = "statusBarAdvPanel7";
			this.statusBarAdvPanel7.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.InsertKeyState;
			this.statusBarAdvPanel7.Size = new System.Drawing.Size(184, 24);
			this.statusBarAdvPanel7.TabIndex = 10;
			this.statusBarAdvPanel7.Text = null;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(56, 272);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(200, 24);
			this.label4.TabIndex = 13;
			this.label4.Text = "Scroll Lock state";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(56, 184);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(200, 24);
			this.label3.TabIndex = 12;
			this.label3.Text = "CAPS lock state with color border";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(56, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 24);
			this.label2.TabIndex = 11;
			this.label2.Text = "Short date with gradient";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(56, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 24);
			this.label1.TabIndex = 10;
			this.label1.Text = "Long Date";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.statusBarAdv1,
																		  this.statusBarAdvPanel5,
																		  this.statusBarAdvPanel4,
																		  this.statusBarAdvPanel3,
																		  this.statusBarAdvPanel1,
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StatusBarAdv Panel";
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel1)).EndInit();
			this.statusBarAdvPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdv1)).EndInit();
			this.statusBarAdv1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel7)).EndInit();
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

		private void statusBarAdvPanel3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
		
		}
	}
}
