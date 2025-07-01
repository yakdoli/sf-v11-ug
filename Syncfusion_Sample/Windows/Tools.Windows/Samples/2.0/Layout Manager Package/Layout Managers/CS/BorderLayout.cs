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

namespace LayoutManagers
{
	/// <summary>
	/// Summary description for BorderLayoutForm.
	/// </summary>
	public class BorderLayoutForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnNorth;
		private System.Windows.Forms.Button btnWest;
		private System.Windows.Forms.Button btnEast;
		private System.Windows.Forms.Button btnCenter;
		private System.Windows.Forms.Button btnSouth;
		private System.ComponentModel.IContainer components;
		private Syncfusion.Windows.Forms.Tools.BorderLayout borderLayout1;
		
		public BorderLayoutForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BorderLayoutForm));
			this.btnNorth = new System.Windows.Forms.Button();
			this.btnWest = new System.Windows.Forms.Button();
			this.btnEast = new System.Windows.Forms.Button();
			this.btnCenter = new System.Windows.Forms.Button();
			this.borderLayout1 = new Syncfusion.Windows.Forms.Tools.BorderLayout(this.components);
			this.btnSouth = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.borderLayout1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNorth
			// 
			this.btnNorth.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.btnNorth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNorth.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnNorth.ForeColor = System.Drawing.Color.Black;
			this.btnNorth.Location = new System.Drawing.Point(20, 20);
			this.btnNorth.Name = "btnNorth";
			this.borderLayout1.SetPosition(this.btnNorth, Syncfusion.Windows.Forms.Tools.BorderPosition.North);
			this.borderLayout1.SetPreferredSize(this.btnNorth, new System.Drawing.Size(152, 24));
			this.btnNorth.Size = new System.Drawing.Size(408, 24);
			this.btnNorth.TabIndex = 0;
			this.btnNorth.Text = "North";
			// 
			// btnWest
			// 
			this.btnWest.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.btnWest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWest.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnWest.ForeColor = System.Drawing.Color.Black;
			this.btnWest.Location = new System.Drawing.Point(20, 64);
			this.btnWest.Name = "btnWest";
			this.borderLayout1.SetPosition(this.btnWest, Syncfusion.Windows.Forms.Tools.BorderPosition.West);
			this.borderLayout1.SetPreferredSize(this.btnWest, new System.Drawing.Size(108, 124));
			this.btnWest.Size = new System.Drawing.Size(108, 134);
			this.btnWest.TabIndex = 2;
			this.btnWest.Text = "West";
			// 
			// btnEast
			// 
			this.btnEast.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.btnEast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEast.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnEast.ForeColor = System.Drawing.Color.Black;
			this.btnEast.Location = new System.Drawing.Point(320, 64);
			this.btnEast.Name = "btnEast";
			this.borderLayout1.SetPosition(this.btnEast, Syncfusion.Windows.Forms.Tools.BorderPosition.East);
			this.borderLayout1.SetPreferredSize(this.btnEast, new System.Drawing.Size(108, 164));
			this.btnEast.Size = new System.Drawing.Size(108, 134);
			this.btnEast.TabIndex = 3;
			this.btnEast.Text = "East";
			// 
			// btnCenter
			// 
			this.btnCenter.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.btnCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCenter.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnCenter.ForeColor = System.Drawing.Color.Black;
			this.btnCenter.Location = new System.Drawing.Point(148, 64);
			this.btnCenter.Name = "btnCenter";
			this.borderLayout1.SetPosition(this.btnCenter, Syncfusion.Windows.Forms.Tools.BorderPosition.Center);
			this.borderLayout1.SetPreferredSize(this.btnCenter, new System.Drawing.Size(128, 72));
			this.btnCenter.Size = new System.Drawing.Size(152, 134);
			this.btnCenter.TabIndex = 4;
			this.btnCenter.Text = "Center";
			// 
			// borderLayout1
			// 
			this.borderLayout1.BottomMargin = 20;
			this.borderLayout1.ContainerControl = this;
			this.borderLayout1.HGap = 20;
			this.borderLayout1.HorzFarMargin = 20;
			this.borderLayout1.HorzNearMargin = 20;
			this.borderLayout1.TopMargin = 20;
			this.borderLayout1.VGap = 20;
			// 
			// btnSouth
			// 
			this.btnSouth.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.btnSouth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSouth.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnSouth.ForeColor = System.Drawing.Color.Black;
			this.btnSouth.Location = new System.Drawing.Point(20, 218);
			this.btnSouth.Name = "btnSouth";
			this.borderLayout1.SetPosition(this.btnSouth, Syncfusion.Windows.Forms.Tools.BorderPosition.South);
			this.borderLayout1.SetPreferredSize(this.btnSouth, new System.Drawing.Size(86, 24));
			this.btnSouth.Size = new System.Drawing.Size(408, 24);
			this.btnSouth.TabIndex = 5;
			this.btnSouth.Text = "South";
			// 
			// BorderLayoutForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(448, 262);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnSouth,
																		  this.btnCenter,
																		  this.btnEast,
																		  this.btnNorth,
																		  this.btnWest});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BorderLayoutForm";
			this.Text = "Border Layout ";
			this.Load += new System.EventHandler(this.BorderLayoutForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.borderLayout1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void BorderLayoutForm_Load(object sender, System.EventArgs e)
		{
			// Sample Code Block to illustrate initialization without designer.
			// Repeats whatever the deisgner already did in InitializeComponent.
		
				// <samplecodeblock name="Initializing BorderLayout">
//				this.borderLayout1 = new BorderLayout();
//
//				this.borderLayout1.ContainerControl = this;
//
//				// Set the border-position of the button.
//				this.borderLayout1.SetPosition(this.btnNorth, BorderPosition.North);
//				this.borderLayout1.SetPosition(this.btnSouth, BorderPosition.South);
//				this.borderLayout1.SetPosition(this.btnCenter, BorderPosition.Center);
//				this.borderLayout1.SetPosition(this.btnEast, BorderPosition.East);
//				this.borderLayout1.SetPosition(this.btnWest, BorderPosition.West);
				// </samplecodeblock>
			
		}
	}
}
