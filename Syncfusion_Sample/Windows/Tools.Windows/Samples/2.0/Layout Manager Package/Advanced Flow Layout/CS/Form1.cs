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

namespace AdvancedFlowLayout
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			this.Size = new Size(648, 368);
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
			this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button6,
																				 this.button5,
																				 this.button4,
																				 this.button3,
																				 this.button2,
																				 this.button1});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(128, 278);
			this.panel1.TabIndex = 0;
			this.panel1.Layout += new System.Windows.Forms.LayoutEventHandler(this.panel1_Layout);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.Location = new System.Drawing.Point(19, 5);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(72, 64);
			this.button6.TabIndex = 0;
			this.button6.Text = "button6";
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Location = new System.Drawing.Point(19, 74);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(72, 64);
			this.button5.TabIndex = 4;
			this.button5.Text = "button5";
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(19, 143);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(72, 64);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(19, 212);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(72, 64);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(19, 281);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 64);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(19, 350);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 64);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			// 
			// splitter1
			// 
			this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitter1.Location = new System.Drawing.Point(128, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(5, 278);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// flowLayout1
			// 
			this.flowLayout1.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.Near;
			this.flowLayout1.AutoLayout = false;
			this.flowLayout1.ContainerControl = this.panel1;
			this.flowLayout1.LayoutMode = Syncfusion.Windows.Forms.Tools.FlowLayoutMode.Vertical;
			// 
			// gradientLabel1
			// 
			this.gradientLabel1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(240)), ((System.Byte)(247))), System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(242)), ((System.Byte)(255))));
			this.gradientLabel1.BorderSides = (((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
				| System.Windows.Forms.Border3DSide.Right) 
				| System.Windows.Forms.Border3DSide.Bottom);
			this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
			this.gradientLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.gradientLabel1.Location = new System.Drawing.Point(200, 8);
			this.gradientLabel1.Name = "gradientLabel1";
			this.gradientLabel1.Size = new System.Drawing.Size(144, 136);
			this.gradientLabel1.TabIndex = 3;
			this.gradientLabel1.Text = "Buttons in the Panel to the left are laid out vertically by the FlowLayout manage" +
				"r in one are more columns, the number of columns being restricted based on the a" +
				"vailable width. Use the Splitter or the TrackBar to resize the panel\'s width.";
			this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// trackBar1
			// 
			this.trackBar1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.trackBar1.Location = new System.Drawing.Point(208, 160);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(104, 45);
			this.trackBar1.TabIndex = 4;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(352, 278);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.trackBar1,
																		  this.gradientLabel1,
																		  this.splitter1,
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Advanced Flow Layout ";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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

		// Handle this event, instead of automatic layout.
		private void panel1_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
			// Provide custom layout bounds.
			Rectangle custBounds = this.panel1.DisplayRectangle;
			custBounds.Y = this.panel1.DisplayRectangle.Y;
			custBounds.Height = this.DetermineLayoutHeight();

			this.flowLayout1.CustomLayoutBounds = custBounds;
			// And trigger a layout.
			this.flowLayout1.LayoutContainer();
		}
		private int DetermineLayoutHeight() 
		{ 
			// Assuming all child controls have the same width and height. 

			// Row heights. 
			int rowHeight = this.flowLayout1.VGap + this.button1.Height; 

			// Determine the width of the columns. 
			int columnWidth = this.flowLayout1.HGap + this.button1.Width; 

			// Determine the no. of columns. 
			// Assume Vertical Scroll bar will always be visible 
			int possibleColumns = (this.panel1.Width - SystemInformation.VerticalScrollBarWidth)/ columnWidth; 

			// Layout height is the total height / no. of columns. 
			int totalHeight = rowHeight * this.panel1.Controls.Count; 

			if(possibleColumns > 0) 
			{ 
				int layoutHeight = totalHeight/possibleColumns; 
				int rows = (int)Math.Ceiling((double)layoutHeight/(double)rowHeight); 
				return rowHeight * rows; 
			} 
			else 
				return totalHeight; 
		}

		private void trackBar1_Scroll(object sender, System.EventArgs e)
		{
			this.panel1.Width = this.trackBar1.Value + 380;
            if (this.trackBar1.Value == 0)
                this.panel1.Width = 112;
		}
	}
}
