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

namespace LayoutManagers
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Tools;
	using System.Runtime.InteropServices;


	/// <summary>
	/// Summary description for FlowLayoutForm.
	/// </summary>
	public class FlowLayoutForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
		private System.ComponentModel.IContainer components;

		public FlowLayoutForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FlowLayoutForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
			this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label1,
																				 this.label10,
																				 this.label9,
																				 this.label8,
																				 this.label7,
																				 this.label6,
																				 this.label5,
																				 this.label4,
																				 this.label3,
																				 this.label2,
																				 this.label13,
																				 this.label14});
			this.panel1.Location = new System.Drawing.Point(8, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 330);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Image = ((System.Drawing.Bitmap)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(24, 4);
			this.flowLayout1.SetMinimumSize(this.label1, new System.Drawing.Size(64, 56));
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 40);
			this.label1.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.Image = ((System.Drawing.Bitmap)(resources.GetObject("label10.Image")));
			this.label10.Location = new System.Drawing.Point(69, 4);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(40, 40);
			this.label10.TabIndex = 13;
			// 
			// label9
			// 
			this.label9.Image = ((System.Drawing.Bitmap)(resources.GetObject("label9.Image")));
			this.label9.Location = new System.Drawing.Point(114, 4);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 40);
			this.label9.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.Image = ((System.Drawing.Bitmap)(resources.GetObject("label8.Image")));
			this.label8.Location = new System.Drawing.Point(159, 4);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 40);
			this.label8.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.Image = ((System.Drawing.Bitmap)(resources.GetObject("label7.Image")));
			this.label7.Location = new System.Drawing.Point(204, 4);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 40);
			this.label7.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.Image = ((System.Drawing.Bitmap)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(249, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 40);
			this.label6.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Image = ((System.Drawing.Bitmap)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(294, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 40);
			this.label5.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Image = ((System.Drawing.Bitmap)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(19, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 60);
			this.label4.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Image = ((System.Drawing.Bitmap)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(84, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 60);
			this.label3.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Image = ((System.Drawing.Bitmap)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(149, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 60);
			this.label2.TabIndex = 5;
			// 
			// label13
			// 
			this.label13.Image = ((System.Drawing.Bitmap)(resources.GetObject("label13.Image")));
			this.label13.Location = new System.Drawing.Point(214, 49);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 60);
			this.label13.TabIndex = 14;
			// 
			// label14
			// 
			this.label14.Image = ((System.Drawing.Bitmap)(resources.GetObject("label14.Image")));
			this.label14.Location = new System.Drawing.Point(279, 49);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 60);
			this.label14.TabIndex = 15;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.BackColor = System.Drawing.SystemColors.Control;
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
			this.propertyGrid1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(376, 0);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(208, 389);
			this.propertyGrid1.TabIndex = 1;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// flowLayout1
			// 
			this.flowLayout1.BottomMargin = 4;
			this.flowLayout1.ContainerControl = this.panel1;
			this.flowLayout1.TopMargin = 4;
			// 
			// gradientLabel1
			// 
			this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(240)), ((System.Byte)(247))), System.Drawing.Color.FromArgb(((System.Byte)(182)), ((System.Byte)(211)), ((System.Byte)(249))));
			this.gradientLabel1.BorderSides = (((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
				| System.Windows.Forms.Border3DSide.Right) 
				| System.Windows.Forms.Border3DSide.Bottom);
			this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
			this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gradientLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gradientLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.gradientLabel1.Name = "gradientLabel1";
			this.gradientLabel1.Size = new System.Drawing.Size(376, 40);
			this.gradientLabel1.TabIndex = 2;
			this.gradientLabel1.Text = "Images arranged using FlowLayout";
			this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FlowLayoutForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(112)), ((System.Byte)(156)));
			this.ClientSize = new System.Drawing.Size(584, 389);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gradientLabel1,
																		  this.propertyGrid1,
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FlowLayoutForm";
			this.Text = "FlowLayout";
			this.Load += new System.EventHandler(this.FlowLayoutForm_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void FlowLayoutForm_Load(object sender, System.EventArgs e)
		{
			this.propertyGrid1.SelectedObject = this.flowLayout1;

			// Sample Code Block to illustrate initialization without designer.
			// Repeats whatever the deisgner already did in InitializeComponent.
		
			// <samplecodeblock name="Initializing FlowLayout">
			// Binding a Control to the FlowLayout manager programaitcally
//			this.flowLayout1 = new FlowLayout();
//	
//			// Set the container control; all the child controls of this container control are
//			// automatically registered as children with the manager.
//			this.flowLayout1.ContainerControl = this.panel1;
//
//			// Set some properties on the flowLayout manager:
//			this.flowLayout1.HGap = 20;
//			this.flowLayout1.Alignment = FlowAlignment.Near;
//
//			// You can ignore one or more child Control from being laid out, like this:
//			// This will have the same effect as calling RemoveLayoutComponent.
//			this.flowLayout1.GetConstraintsRef(this.label10).Active = false;

			// You can prevent automatic layout during the layout event:
			// If you decide to do so, make sure to call flowLayout.LayoutContainer manually.
			// this.flowLayout1.AutoLayout = false;
			// </samplecodeblock>
		
		}
	}
}
