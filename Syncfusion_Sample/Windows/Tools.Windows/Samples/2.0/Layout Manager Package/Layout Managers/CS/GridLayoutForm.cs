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
		private System.Windows.Forms.Panel innerPanel;
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
		private System.ComponentModel.IContainer components;

		public GridLayoutForm()
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
																				 this.gradientLabel1,
																				 this.outerPanel});
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(352, 325);
			this.panel1.TabIndex = 0;
			// 
			// gradientLabel1
			// 
			this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(240)), ((System.Byte)(247))), System.Drawing.Color.FromArgb(((System.Byte)(182)), ((System.Byte)(211)), ((System.Byte)(241))));
			this.gradientLabel1.BorderSides = (((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
				| System.Windows.Forms.Border3DSide.Right) 
				| System.Windows.Forms.Border3DSide.Bottom);
			this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
			this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gradientLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gradientLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.gradientLabel1.Name = "gradientLabel1";
			this.gradientLabel1.Size = new System.Drawing.Size(352, 48);
			this.gradientLabel1.TabIndex = 2;
			this.gradientLabel1.Text = "A Quick and Dirty Calculator using GridLayout";
			this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			this.outerPanel.Location = new System.Drawing.Point(40, 72);
			this.outerPanel.Name = "outerPanel";
			this.outerPanel.Size = new System.Drawing.Size(264, 210);
			this.outerPanel.TabIndex = 1;
			// 
			// innerPanel
			// 
			this.innerPanel.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
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
			this.innerPanel.DockPadding.All = 10;
			this.innerPanel.Location = new System.Drawing.Point(2, 24);
			this.innerPanel.Name = "innerPanel";
			this.innerPanel.Size = new System.Drawing.Size(256, 186);
			this.innerPanel.TabIndex = 1;
			// 
			// one
			// 
			this.one.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.one.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.one.ForeColor = System.Drawing.Color.Black;
			this.one.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.one.Location = new System.Drawing.Point(4, 5);
			this.gridLayout1.SetMinimumSize(this.one, new System.Drawing.Size(33, 33));
			this.one.Name = "one";
			this.gridLayout1.SetParticipateInLayout(this.one, true);
			this.gridLayout1.SetPreferredSize(this.one, new System.Drawing.Size(43, 33));
			this.one.Size = new System.Drawing.Size(59, 32);
			this.one.TabIndex = 0;
			this.one.Text = "1";
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button20.ForeColor = System.Drawing.Color.Black;
			this.button20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button20.Location = new System.Drawing.Point(67, 5);
			this.gridLayout1.SetMinimumSize(this.button20, new System.Drawing.Size(43, 33));
			this.button20.Name = "button20";
			this.gridLayout1.SetParticipateInLayout(this.button20, true);
			this.gridLayout1.SetPreferredSize(this.button20, new System.Drawing.Size(43, 33));
			this.button20.Size = new System.Drawing.Size(59, 32);
			this.button20.TabIndex = 2;
			this.button20.Text = "2";
			// 
			// button19
			// 
			this.button19.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button19.ForeColor = System.Drawing.Color.Black;
			this.button19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button19.Location = new System.Drawing.Point(130, 5);
			this.button19.Name = "button19";
			this.gridLayout1.SetParticipateInLayout(this.button19, true);
			this.gridLayout1.SetPreferredSize(this.button19, new System.Drawing.Size(43, 33));
			this.button19.Size = new System.Drawing.Size(59, 32);
			this.button19.TabIndex = 3;
			this.button19.Text = "3";
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.Brown;
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button18.ForeColor = System.Drawing.Color.White;
			this.button18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button18.Location = new System.Drawing.Point(193, 5);
			this.button18.Name = "button18";
			this.gridLayout1.SetParticipateInLayout(this.button18, true);
			this.gridLayout1.SetPreferredSize(this.button18, new System.Drawing.Size(43, 33));
			this.button18.Size = new System.Drawing.Size(59, 32);
			this.button18.TabIndex = 12;
			this.button18.Text = "=";
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button17.ForeColor = System.Drawing.Color.Black;
			this.button17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button17.Location = new System.Drawing.Point(4, 41);
			this.button17.Name = "button17";
			this.gridLayout1.SetParticipateInLayout(this.button17, true);
			this.gridLayout1.SetPreferredSize(this.button17, new System.Drawing.Size(43, 33));
			this.button17.Size = new System.Drawing.Size(59, 32);
			this.button17.TabIndex = 4;
			this.button17.Text = "4";
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button16.ForeColor = System.Drawing.Color.Black;
			this.button16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button16.Location = new System.Drawing.Point(67, 41);
			this.button16.Name = "button16";
			this.gridLayout1.SetParticipateInLayout(this.button16, true);
			this.gridLayout1.SetPreferredSize(this.button16, new System.Drawing.Size(43, 33));
			this.button16.Size = new System.Drawing.Size(59, 32);
			this.button16.TabIndex = 5;
			this.button16.Text = "5";
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button15.ForeColor = System.Drawing.Color.Black;
			this.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button15.Location = new System.Drawing.Point(130, 41);
			this.gridLayout1.SetMinimumSize(this.button15, new System.Drawing.Size(43, 33));
			this.button15.Name = "button15";
			this.gridLayout1.SetParticipateInLayout(this.button15, true);
			this.gridLayout1.SetPreferredSize(this.button15, new System.Drawing.Size(43, 33));
			this.button15.Size = new System.Drawing.Size(59, 32);
			this.button15.TabIndex = 6;
			this.button15.Text = "6";
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button14.ForeColor = System.Drawing.Color.Black;
			this.button14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button14.Location = new System.Drawing.Point(193, 41);
			this.button14.Name = "button14";
			this.gridLayout1.SetParticipateInLayout(this.button14, true);
			this.button14.Size = new System.Drawing.Size(59, 32);
			this.button14.TabIndex = 13;
			this.button14.Text = "+";
			// 
			// button13
			// 
			this.button13.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button13.ForeColor = System.Drawing.Color.Black;
			this.button13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button13.Location = new System.Drawing.Point(4, 77);
			this.button13.Name = "button13";
			this.gridLayout1.SetParticipateInLayout(this.button13, true);
			this.gridLayout1.SetPreferredSize(this.button13, new System.Drawing.Size(43, 33));
			this.button13.Size = new System.Drawing.Size(59, 32);
			this.button13.TabIndex = 7;
			this.button13.Text = "7";
			// 
			// button12
			// 
			this.button12.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button12.ForeColor = System.Drawing.Color.Black;
			this.button12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button12.Location = new System.Drawing.Point(67, 77);
			this.button12.Name = "button12";
			this.gridLayout1.SetParticipateInLayout(this.button12, true);
			this.gridLayout1.SetPreferredSize(this.button12, new System.Drawing.Size(43, 33));
			this.button12.Size = new System.Drawing.Size(59, 32);
			this.button12.TabIndex = 8;
			this.button12.Text = "8";
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button11.ForeColor = System.Drawing.Color.Black;
			this.button11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button11.Location = new System.Drawing.Point(130, 77);
			this.button11.Name = "button11";
			this.gridLayout1.SetParticipateInLayout(this.button11, true);
			this.gridLayout1.SetPreferredSize(this.button11, new System.Drawing.Size(43, 33));
			this.button11.Size = new System.Drawing.Size(59, 32);
			this.button11.TabIndex = 9;
			this.button11.Text = "9";
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button10.ForeColor = System.Drawing.Color.Black;
			this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button10.Location = new System.Drawing.Point(193, 77);
			this.button10.Name = "button10";
			this.gridLayout1.SetParticipateInLayout(this.button10, true);
			this.button10.Size = new System.Drawing.Size(59, 32);
			this.button10.TabIndex = 14;
			this.button10.Text = "-";
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button9.ForeColor = System.Drawing.Color.Black;
			this.button9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button9.Location = new System.Drawing.Point(4, 113);
			this.button9.Name = "button9";
			this.gridLayout1.SetParticipateInLayout(this.button9, true);
			this.gridLayout1.SetPreferredSize(this.button9, new System.Drawing.Size(43, 33));
			this.button9.Size = new System.Drawing.Size(59, 32);
			this.button9.TabIndex = 10;
			this.button9.Text = "0";
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.Black;
			this.button8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button8.Location = new System.Drawing.Point(67, 113);
			this.button8.Name = "button8";
			this.gridLayout1.SetParticipateInLayout(this.button8, true);
			this.gridLayout1.SetPreferredSize(this.button8, new System.Drawing.Size(43, 33));
			this.button8.Size = new System.Drawing.Size(59, 32);
			this.button8.TabIndex = 11;
			this.button8.Text = ".";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.Black;
			this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button7.Location = new System.Drawing.Point(130, 113);
			this.button7.Name = "button7";
			this.gridLayout1.SetParticipateInLayout(this.button7, true);
			this.button7.Size = new System.Drawing.Size(59, 32);
			this.button7.TabIndex = 16;
			this.button7.Text = "C";
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Black;
			this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button6.Location = new System.Drawing.Point(193, 113);
			this.button6.Name = "button6";
			this.gridLayout1.SetParticipateInLayout(this.button6, true);
			this.gridLayout1.SetPreferredSize(this.button6, new System.Drawing.Size(43, 33));
			this.button6.Size = new System.Drawing.Size(59, 32);
			this.button6.TabIndex = 15;
			this.button6.Text = "*";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(128)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Maroon;
			this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button1.Location = new System.Drawing.Point(4, 149);
			this.button1.Name = "button1";
			this.gridLayout1.SetParticipateInLayout(this.button1, true);
			this.gridLayout1.SetPreferredSize(this.button1, new System.Drawing.Size(43, 33));
			this.button1.Size = new System.Drawing.Size(59, 32);
			this.button1.TabIndex = 17;
			this.button1.Text = "MR";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(128)));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Maroon;
			this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button4.Location = new System.Drawing.Point(67, 149);
			this.button4.Name = "button4";
			this.gridLayout1.SetParticipateInLayout(this.button4, true);
			this.gridLayout1.SetPreferredSize(this.button4, new System.Drawing.Size(43, 33));
			this.button4.Size = new System.Drawing.Size(59, 32);
			this.button4.TabIndex = 18;
			this.button4.Text = "MC";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(128)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Maroon;
			this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button3.Location = new System.Drawing.Point(130, 149);
			this.button3.Name = "button3";
			this.gridLayout1.SetParticipateInLayout(this.button3, true);
			this.button3.Size = new System.Drawing.Size(59, 32);
			this.button3.TabIndex = 19;
			this.button3.Text = "M+";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button2.Location = new System.Drawing.Point(193, 149);
			this.button2.Name = "button2";
			this.gridLayout1.SetParticipateInLayout(this.button2, true);
			this.button2.Size = new System.Drawing.Size(59, 32);
			this.button2.TabIndex = 20;
			this.button2.Text = "/";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(262, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
			this.propertyGrid1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(352, 0);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(200, 325);
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
			this.ClientSize = new System.Drawing.Size(552, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.propertyGrid1});
			this.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GridLayoutForm";
			this.Text = "GridLayout";
			this.Load += new System.EventHandler(this.GridLayoutForm_Load);
			this.panel1.ResumeLayout(false);
			this.outerPanel.ResumeLayout(false);
			this.innerPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridLayout1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void GridLayoutForm_Load(object sender, System.EventArgs e)
		{
			this.propertyGrid1.SelectedObject = this.gridLayout1;

			// Sample Code Block to illustrate initialization without designer.
			// Repeats whatever the deisgner already did in InitializeComponent.
			
			// <samplecodeblock name="Initializing GridLayout">
			// Binding a Control to the GridLayout manager programaitcally
			gridLayout1 = new Syncfusion.Windows.Forms.Tools.GridLayout();
	
			// Set the container control; all the child controls of this container control are
			// automatically registered as children with the manager.
			this.gridLayout1.ContainerControl = this.innerPanel;
			// Set some properties on the flowLayout manager:
			this.gridLayout1.Columns = 4;
			this.gridLayout1.Rows = 5;
			this.gridLayout1.HGap = 4;
			this.gridLayout1.VGap = 4;

			// You can ignore one or more child Control from being laid out, like this:
			// This will have the same effect as calling RemoveLayoutComponent.
			//this.gridLayout1.SetParticipateInLayout(this.button1, false);

			// You can prevent automatic layout during the layout event:
			// If you decide to do so, make sure to call gridLayout1.LayoutContainer manually.
			// this.gridLayout1.AutoLayout = false;
			// </samplecodeblock>
			
		}
	}
}
