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

namespace ConstrainedLayoutBounds
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;

	/// <summary>
	/// Summary description for GridLayoutForm.
	/// </summary>
	public class GridLayoutForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private Syncfusion.Windows.Forms.Tools.GridLayout gridLayout1;
		private System.Windows.Forms.Panel outerPanel;
		private System.Windows.Forms.TextBox textBox1;
		private Panel innerPanel;
		private System.Windows.Forms.Button one;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components;

		public GridLayoutForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.label2.Text ="Panel: Width = " + this.innerPanel.Width.ToString() +"," + " Height = " + this.innerPanel.Height.ToString();

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
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GridLayoutForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
			this.outerPanel = new System.Windows.Forms.Panel();
			this.innerPanel = new System.Windows.Forms.Panel();
			this.one = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout(this.components);
			this.panel1.SuspendLayout();
			this.outerPanel.SuspendLayout();
			this.innerPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label2,
																				 this.gradientLabel1,
																				 this.outerPanel});
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(416, 357);
			this.panel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(416, 23);
			this.label2.TabIndex = 6;
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gradientLabel1
			// 
			this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(182)), ((System.Byte)(211)), ((System.Byte)(241))), System.Drawing.Color.FromArgb(((System.Byte)(219)), ((System.Byte)(229)), ((System.Byte)(241))));
			this.gradientLabel1.BorderSides = (((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
				| System.Windows.Forms.Border3DSide.Right) 
				| System.Windows.Forms.Border3DSide.Bottom);
			this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
			this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gradientLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gradientLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.gradientLabel1.Name = "gradientLabel1";
			this.gradientLabel1.Size = new System.Drawing.Size(416, 48);
			this.gradientLabel1.TabIndex = 5;
			this.gradientLabel1.Text = "GridLayout - The layout bounds for the Panel below is restricted to 300 X 200";
			this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// outerPanel
			// 
			this.outerPanel.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.outerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.outerPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.innerPanel,
																					 this.textBox1});
			this.outerPanel.Location = new System.Drawing.Point(40, 96);
			this.outerPanel.Name = "outerPanel";
			this.outerPanel.Size = new System.Drawing.Size(330, 218);
			this.outerPanel.TabIndex = 1;
			// 
			// innerPanel
			// 
			this.innerPanel.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.innerPanel.AutoScroll = true;
			this.innerPanel.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.one,
																					 this.button20,
																					 this.button19,
																					 this.button18,
																					 this.button17,
																					 this.button16,
																					 this.button15,
																					 this.button14,
																					 this.button13,
																					 this.button12,
																					 this.button11,
																					 this.button10,
																					 this.button9,
																					 this.button8,
																					 this.button7,
																					 this.button6,
																					 this.button1,
																					 this.button4,
																					 this.button3,
																					 this.button2});
			this.innerPanel.Location = new System.Drawing.Point(2, 24);
			this.innerPanel.Name = "innerPanel";
			this.innerPanel.Size = new System.Drawing.Size(322, 194);
			this.innerPanel.TabIndex = 1;
			this.innerPanel.Resize += new System.EventHandler(this.innerPanel_Resize);
			// 
			// one
			// 
			this.one.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.one.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.one.Location = new System.Drawing.Point(5, 4);
			this.gridLayout1.SetMinimumSize(this.one, new System.Drawing.Size(33, 33));
			this.one.Name = "one";
			this.gridLayout1.SetParticipateInLayout(this.one, true);
			this.gridLayout1.SetPreferredSize(this.one, new System.Drawing.Size(43, 33));
			this.one.Size = new System.Drawing.Size(75, 34);
			this.one.TabIndex = 0;
			this.one.Text = "1";
			// 
			// button20
			// 
			this.button20.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button20.Location = new System.Drawing.Point(84, 4);
			this.gridLayout1.SetMinimumSize(this.button20, new System.Drawing.Size(43, 33));
			this.button20.Name = "button20";
			this.gridLayout1.SetParticipateInLayout(this.button20, true);
			this.gridLayout1.SetPreferredSize(this.button20, new System.Drawing.Size(43, 33));
			this.button20.Size = new System.Drawing.Size(75, 34);
			this.button20.TabIndex = 2;
			this.button20.Text = "2";
			// 
			// button19
			// 
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button19.Location = new System.Drawing.Point(163, 4);
			this.button19.Name = "button19";
			this.gridLayout1.SetParticipateInLayout(this.button19, true);
			this.gridLayout1.SetPreferredSize(this.button19, new System.Drawing.Size(43, 33));
			this.button19.Size = new System.Drawing.Size(75, 34);
			this.button19.TabIndex = 3;
			this.button19.Text = "3";
			// 
			// button18
			// 
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.button18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button18.Location = new System.Drawing.Point(242, 4);
			this.button18.Name = "button18";
			this.gridLayout1.SetParticipateInLayout(this.button18, true);
			this.gridLayout1.SetPreferredSize(this.button18, new System.Drawing.Size(43, 33));
			this.button18.Size = new System.Drawing.Size(75, 34);
			this.button18.TabIndex = 12;
			this.button18.Text = "=";
			// 
			// button17
			// 
			this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button17.Location = new System.Drawing.Point(5, 42);
			this.button17.Name = "button17";
			this.gridLayout1.SetParticipateInLayout(this.button17, true);
			this.gridLayout1.SetPreferredSize(this.button17, new System.Drawing.Size(43, 33));
			this.button17.Size = new System.Drawing.Size(75, 34);
			this.button17.TabIndex = 4;
			this.button17.Text = "4";
			// 
			// button16
			// 
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button16.Location = new System.Drawing.Point(84, 42);
			this.button16.Name = "button16";
			this.gridLayout1.SetParticipateInLayout(this.button16, true);
			this.gridLayout1.SetPreferredSize(this.button16, new System.Drawing.Size(43, 33));
			this.button16.Size = new System.Drawing.Size(75, 34);
			this.button16.TabIndex = 5;
			this.button16.Text = "5";
			// 
			// button15
			// 
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button15.Location = new System.Drawing.Point(163, 42);
			this.gridLayout1.SetMinimumSize(this.button15, new System.Drawing.Size(43, 33));
			this.button15.Name = "button15";
			this.gridLayout1.SetParticipateInLayout(this.button15, true);
			this.gridLayout1.SetPreferredSize(this.button15, new System.Drawing.Size(43, 33));
			this.button15.Size = new System.Drawing.Size(75, 34);
			this.button15.TabIndex = 6;
			this.button15.Text = "6";
			// 
			// button14
			// 
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button14.Location = new System.Drawing.Point(242, 42);
			this.button14.Name = "button14";
			this.gridLayout1.SetParticipateInLayout(this.button14, true);
			this.button14.Size = new System.Drawing.Size(75, 34);
			this.button14.TabIndex = 13;
			this.button14.Text = "+";
			// 
			// button13
			// 
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button13.Location = new System.Drawing.Point(5, 80);
			this.button13.Name = "button13";
			this.gridLayout1.SetParticipateInLayout(this.button13, true);
			this.gridLayout1.SetPreferredSize(this.button13, new System.Drawing.Size(43, 33));
			this.button13.Size = new System.Drawing.Size(75, 34);
			this.button13.TabIndex = 7;
			this.button13.Text = "7";
			// 
			// button12
			// 
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button12.Location = new System.Drawing.Point(84, 80);
			this.button12.Name = "button12";
			this.gridLayout1.SetParticipateInLayout(this.button12, true);
			this.gridLayout1.SetPreferredSize(this.button12, new System.Drawing.Size(43, 33));
			this.button12.Size = new System.Drawing.Size(75, 34);
			this.button12.TabIndex = 8;
			this.button12.Text = "8";
			// 
			// button11
			// 
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button11.Location = new System.Drawing.Point(163, 80);
			this.button11.Name = "button11";
			this.gridLayout1.SetParticipateInLayout(this.button11, true);
			this.gridLayout1.SetPreferredSize(this.button11, new System.Drawing.Size(43, 33));
			this.button11.Size = new System.Drawing.Size(75, 34);
			this.button11.TabIndex = 9;
			this.button11.Text = "9";
			// 
			// button10
			// 
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button10.Location = new System.Drawing.Point(242, 80);
			this.button10.Name = "button10";
			this.gridLayout1.SetParticipateInLayout(this.button10, true);
			this.button10.Size = new System.Drawing.Size(75, 34);
			this.button10.TabIndex = 14;
			this.button10.Text = "-";
			// 
			// button9
			// 
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button9.Location = new System.Drawing.Point(5, 118);
			this.button9.Name = "button9";
			this.gridLayout1.SetParticipateInLayout(this.button9, true);
			this.gridLayout1.SetPreferredSize(this.button9, new System.Drawing.Size(43, 33));
			this.button9.Size = new System.Drawing.Size(75, 34);
			this.button9.TabIndex = 10;
			this.button9.Text = "0";
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button8.Location = new System.Drawing.Point(84, 118);
			this.button8.Name = "button8";
			this.gridLayout1.SetParticipateInLayout(this.button8, true);
			this.gridLayout1.SetPreferredSize(this.button8, new System.Drawing.Size(43, 33));
			this.button8.Size = new System.Drawing.Size(75, 34);
			this.button8.TabIndex = 11;
			this.button8.Text = ".";
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button7.Location = new System.Drawing.Point(163, 118);
			this.button7.Name = "button7";
			this.gridLayout1.SetParticipateInLayout(this.button7, true);
			this.button7.Size = new System.Drawing.Size(75, 34);
			this.button7.TabIndex = 16;
			this.button7.Text = "C";
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button6.Location = new System.Drawing.Point(242, 118);
			this.button6.Name = "button6";
			this.gridLayout1.SetParticipateInLayout(this.button6, true);
			this.gridLayout1.SetPreferredSize(this.button6, new System.Drawing.Size(43, 33));
			this.button6.Size = new System.Drawing.Size(75, 34);
			this.button6.TabIndex = 15;
			this.button6.Text = "*";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button1.Location = new System.Drawing.Point(5, 156);
			this.button1.Name = "button1";
			this.gridLayout1.SetParticipateInLayout(this.button1, true);
			this.gridLayout1.SetPreferredSize(this.button1, new System.Drawing.Size(43, 33));
			this.button1.Size = new System.Drawing.Size(75, 34);
			this.button1.TabIndex = 17;
			this.button1.Text = "MR";
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button4.Location = new System.Drawing.Point(84, 156);
			this.button4.Name = "button4";
			this.gridLayout1.SetParticipateInLayout(this.button4, true);
			this.gridLayout1.SetPreferredSize(this.button4, new System.Drawing.Size(43, 33));
			this.button4.Size = new System.Drawing.Size(75, 34);
			this.button4.TabIndex = 18;
			this.button4.Text = "MC";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button3.Location = new System.Drawing.Point(163, 156);
			this.button3.Name = "button3";
			this.gridLayout1.SetParticipateInLayout(this.button3, true);
			this.button3.Size = new System.Drawing.Size(75, 34);
			this.button3.TabIndex = 19;
			this.button3.Text = "M+";
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button2.Location = new System.Drawing.Point(242, 156);
			this.button2.Name = "button2";
			this.gridLayout1.SetParticipateInLayout(this.button2, true);
			this.button2.Size = new System.Drawing.Size(75, 34);
			this.button2.TabIndex = 20;
			this.button2.Text = "/";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(328, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
			this.propertyGrid1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(416, 0);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(240, 350);
			this.propertyGrid1.TabIndex = 1;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// gridLayout1
			// 
			this.gridLayout1.BottomMargin = 4;
			this.gridLayout1.Columns = 3;
			this.gridLayout1.ContainerControl = this.innerPanel;
			this.gridLayout1.HGap = 4;
			this.gridLayout1.HorzFarMargin = 4;
			this.gridLayout1.HorzNearMargin = 4;
			this.gridLayout1.Rows = 5;
			this.gridLayout1.TopMargin = 4;
			this.gridLayout1.VGap = 4;
			// 
			// GridLayoutForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 350);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.propertyGrid1,
																		  this.panel1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GridLayoutForm";
			this.Text = "Constrained Layout Bounds";
			this.Resize += new System.EventHandler(this.GridLayoutForm_Resize);
			this.Load += new System.EventHandler(this.GridLayoutForm_Load);
			this.panel1.ResumeLayout(false);
			this.outerPanel.ResumeLayout(false);
			this.innerPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new GridLayoutForm());
		}

		private void GridLayoutForm_Load(object sender, System.EventArgs e)
		{
			this.propertyGrid1.SelectedObject = this.gridLayout1;
		}

		// Here we will restrict the layout bounds of a container control to a min width/height.
		// This makes sense for ContainerControls with AutoScroll turned on.
		// Make sure to set DockPadding values to 0.
		private int minLayoutWidth = 300;
		private int minLayoutHeight = 200;
		// Listen to the container control's Resize event.
		private void innerPanel_Resize(object sender, System.EventArgs e)
		{
			// By default the layout bounds are the container's ClientRectangle,
			// but here we will restrict it to be a minimum size (via the CustomLayoutBounds property)
			Rectangle containerLayoutBounds = this.innerPanel.ClientRectangle;
			if(this.innerPanel.DisplayRectangle != containerLayoutBounds)
			{
				// This means that there is a scrollbar, so start laying out
				// at the displayrect's left/top
				containerLayoutBounds.X  = this.innerPanel.DisplayRectangle.X;
				containerLayoutBounds.Y  = this.innerPanel.DisplayRectangle.Y;
			}
			// If the client rect is not big enough then use the minwidth/minheight
			if(this.innerPanel.ClientRectangle.Width < minLayoutWidth)
			{
				containerLayoutBounds.Width = minLayoutWidth;
			}
			if(this.innerPanel.ClientRectangle.Height < minLayoutHeight)
			{
				containerLayoutBounds.Height = minLayoutHeight;
			}
			
			if(this.innerPanel.ClientRectangle != containerLayoutBounds)
			{
				// If we have a custom layout bounds use it.
				this.gridLayout1.CustomLayoutBounds = containerLayoutBounds;
			}
			else
			{
				// Or else make the layout manager use the client rect.
				this.gridLayout1.CustomLayoutBounds = Rectangle.Empty;
			}
		}

		private void GridLayoutForm_Resize(object sender, System.EventArgs e)
		{
			this.label2.Text ="Panel: Width = " + this.innerPanel.Width.ToString() +"," + " Height = " + this.innerPanel.Height.ToString();
		}
	}
}
