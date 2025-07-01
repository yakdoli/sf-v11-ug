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

namespace LayoutManagers
{
	/// <summary>
	/// Summary description for FlowLayoutCC.
	/// </summary>
	public class FlowLayoutCC : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox4;
		public Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox8;
		private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout3;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
		private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
		private System.Windows.Forms.TextBox textBox1;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
		private System.Windows.Forms.Panel panel3;
		private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel4;
		private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout6;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout7;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox14;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel11;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
		private System.Windows.Forms.TextBox textBox15;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel13;
		private System.Windows.Forms.ComboBox comboBox1;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel14;
		private System.Windows.Forms.TextBox textBox3;
		private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
		private System.ComponentModel.IContainer components;

		public FlowLayoutCC()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FlowLayoutCC));
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.autoLabel14 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.autoLabel13 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.flowLayout3 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
			this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.autoLabel11 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.flowLayout4 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
			this.flowLayout5 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.flowLayout6 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
			this.flowLayout7 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).BeginInit();
			this.panel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout5)).BeginInit();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout7)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.textBox1,
																				 this.autoLabel3,
																				 this.textBox3,
																				 this.autoLabel14,
																				 this.autoLabel13,
																				 this.autoLabel12,
																				 this.autoLabel7,
																				 this.textBox2,
																				 this.autoLabel4,
																				 this.textBox4,
																				 this.comboBox1,
																				 this.textBox15});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 79);
			this.panel1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.flowLayout1.SetConstraints(this.textBox1, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, false, false, false));
			this.textBox1.Location = new System.Drawing.Point(71, 4);
			this.flowLayout1.SetMinimumSize(this.textBox1, new System.Drawing.Size(100, 20));
			this.textBox1.Name = "textBox1";
			this.flowLayout1.SetPreferredSize(this.textBox1, new System.Drawing.Size(100, 20));
			this.textBox1.Size = new System.Drawing.Size(264, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "HAlign Justify; ";
			// 
			// autoLabel3
			// 
			this.autoLabel3.DX = -24;
			this.autoLabel3.DY = 2;
			this.autoLabel3.LabeledControl = this.textBox3;
			this.autoLabel3.Location = new System.Drawing.Point(340, 6);
			this.autoLabel3.Name = "autoLabel3";
			this.autoLabel3.Size = new System.Drawing.Size(20, 16);
			this.autoLabel3.TabIndex = 1;
			this.autoLabel3.Text = "&MI:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(364, 4);
			this.flowLayout1.SetMinimumSize(this.textBox3, new System.Drawing.Size(32, 20));
			this.textBox3.Name = "textBox3";
			this.flowLayout1.SetPreferredSize(this.textBox3, new System.Drawing.Size(32, 20));
			this.textBox3.Size = new System.Drawing.Size(32, 20);
			this.textBox3.TabIndex = 1;
			this.textBox3.Text = "HAlign Left";
			// 
			// autoLabel14
			// 
			this.autoLabel14.DX = -35;
			this.autoLabel14.DY = 3;
			this.autoLabel14.LabeledControl = this.comboBox1;
			this.autoLabel14.Location = new System.Drawing.Point(204, 57);
			this.autoLabel14.Name = "autoLabel14";
			this.autoLabel14.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
			this.autoLabel14.Size = new System.Drawing.Size(31, 16);
			this.autoLabel14.TabIndex = 4;
			this.autoLabel14.Text = "State";
			// 
			// comboBox1
			// 
			this.comboBox1.Location = new System.Drawing.Point(239, 54);
			this.flowLayout1.SetMinimumSize(this.comboBox1, new System.Drawing.Size(64, 21));
			this.comboBox1.Name = "comboBox1";
			this.flowLayout1.SetPreferredSize(this.comboBox1, new System.Drawing.Size(64, 21));
			this.comboBox1.Size = new System.Drawing.Size(64, 21);
			this.comboBox1.TabIndex = 4;
			this.comboBox1.Text = "HAlign Left";
			// 
			// autoLabel13
			// 
			this.autoLabel13.DX = -24;
			this.autoLabel13.DY = 3;
			this.autoLabel13.LabeledControl = this.textBox15;
			this.autoLabel13.Location = new System.Drawing.Point(308, 57);
			this.autoLabel13.Name = "autoLabel13";
			this.autoLabel13.Position = Syncfusion.Windows.Forms.Tools.AutoLabelPosition.Custom;
			this.autoLabel13.Size = new System.Drawing.Size(20, 16);
			this.autoLabel13.TabIndex = 5;
			this.autoLabel13.Text = "Zip";
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(332, 54);
			this.flowLayout1.SetMinimumSize(this.textBox15, new System.Drawing.Size(64, 20));
			this.textBox15.Name = "textBox15";
			this.flowLayout1.SetPreferredSize(this.textBox15, new System.Drawing.Size(64, 20));
			this.textBox15.Size = new System.Drawing.Size(64, 20);
			this.textBox15.TabIndex = 5;
			this.textBox15.Text = "HAlign Left ";
			// 
			// autoLabel12
			// 
			this.autoLabel12.DX = -66;
			this.autoLabel12.DY = 2;
			this.autoLabel12.LabeledControl = this.textBox2;
			this.autoLabel12.Location = new System.Drawing.Point(4, 31);
			this.autoLabel12.Name = "autoLabel12";
			this.autoLabel12.Size = new System.Drawing.Size(62, 16);
			this.autoLabel12.TabIndex = 2;
			this.autoLabel12.Text = "Last Name:";
			// 
			// textBox2
			// 
			this.flowLayout1.SetConstraints(this.textBox2, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, false, false, false));
			this.textBox2.Location = new System.Drawing.Point(70, 29);
			this.flowLayout1.SetMinimumSize(this.textBox2, new System.Drawing.Size(100, 20));
			this.textBox2.Name = "textBox2";
			this.flowLayout1.SetPreferredSize(this.textBox2, new System.Drawing.Size(100, 20));
			this.textBox2.Size = new System.Drawing.Size(326, 20);
			this.textBox2.TabIndex = 2;
			this.textBox2.Text = "HAlign Justify; ";
			// 
			// autoLabel7
			// 
			this.autoLabel7.DX = -67;
			this.autoLabel7.DY = 2;
			this.autoLabel7.LabeledControl = this.textBox1;
			this.autoLabel7.Location = new System.Drawing.Point(4, 6);
			this.autoLabel7.Name = "autoLabel7";
			this.autoLabel7.Size = new System.Drawing.Size(63, 16);
			this.autoLabel7.TabIndex = 0;
			this.autoLabel7.Text = "First Name:";
			// 
			// autoLabel4
			// 
			this.autoLabel4.DX = -65;
			this.autoLabel4.DY = 2;
			this.autoLabel4.LabeledControl = this.textBox4;
			this.autoLabel4.Location = new System.Drawing.Point(4, 56);
			this.autoLabel4.Name = "autoLabel4";
			this.autoLabel4.Size = new System.Drawing.Size(61, 16);
			this.autoLabel4.TabIndex = 3;
			this.autoLabel4.Text = "Address    :";
			// 
			// textBox4
			// 
			this.flowLayout1.SetConstraints(this.textBox4, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, true, false, false));
			this.textBox4.Location = new System.Drawing.Point(69, 54);
			this.flowLayout1.SetMinimumSize(this.textBox4, new System.Drawing.Size(100, 20));
			this.textBox4.Name = "textBox4";
			this.flowLayout1.SetPreferredSize(this.textBox4, new System.Drawing.Size(100, 20));
			this.textBox4.Size = new System.Drawing.Size(130, 20);
			this.textBox4.TabIndex = 3;
			this.textBox4.Text = "HAlign Justify; NewLine True; ";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.autoLabel6,
																				 this.autoLabel5,
																				 this.autoLabel2,
																				 this.autoLabel1,
																				 this.textBox8,
																				 this.textBox6,
																				 this.textBox5,
																				 this.textBox7});
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 79);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(400, 53);
			this.panel2.TabIndex = 1;
			// 
			// autoLabel6
			// 
			this.autoLabel6.DX = -36;
			this.autoLabel6.DY = 2;
			this.autoLabel6.LabeledControl = this.textBox7;
			this.autoLabel6.Location = new System.Drawing.Point(4, 31);
			this.autoLabel6.Name = "autoLabel6";
			this.autoLabel6.Size = new System.Drawing.Size(32, 16);
			this.autoLabel6.TabIndex = 11;
			this.autoLabel6.Text = "Label";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(40, 29);
			this.flowLayout3.SetMinimumSize(this.textBox7, new System.Drawing.Size(100, 20));
			this.textBox7.Multiline = true;
			this.textBox7.Name = "textBox7";
			this.flowLayout3.SetPreferredSize(this.textBox7, new System.Drawing.Size(100, 20));
			this.textBox7.TabIndex = 4;
			this.textBox7.Text = "Left";
			// 
			// autoLabel5
			// 
			this.autoLabel5.DX = -36;
			this.autoLabel5.DY = 2;
			this.autoLabel5.LabeledControl = this.textBox8;
			this.autoLabel5.Location = new System.Drawing.Point(4, 6);
			this.autoLabel5.Name = "autoLabel5";
			this.autoLabel5.Size = new System.Drawing.Size(32, 16);
			this.autoLabel5.TabIndex = 10;
			this.autoLabel5.Text = "Label";
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(40, 4);
			this.flowLayout3.SetMinimumSize(this.textBox8, new System.Drawing.Size(100, 20));
			this.textBox8.Multiline = true;
			this.textBox8.Name = "textBox8";
			this.flowLayout3.SetPreferredSize(this.textBox8, new System.Drawing.Size(100, 20));
			this.textBox8.TabIndex = 1;
			this.textBox8.Text = "Left";
			// 
			// autoLabel2
			// 
			this.autoLabel2.DX = -36;
			this.autoLabel2.DY = 2;
			this.autoLabel2.LabeledControl = this.textBox6;
			this.autoLabel2.Location = new System.Drawing.Point(145, 6);
			this.autoLabel2.Name = "autoLabel2";
			this.autoLabel2.Size = new System.Drawing.Size(32, 16);
			this.autoLabel2.TabIndex = 9;
			this.autoLabel2.Text = "Label";
			// 
			// textBox6
			// 
			this.flowLayout3.SetConstraints(this.textBox6, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, false, false, false));
			this.textBox6.Location = new System.Drawing.Point(181, 4);
			this.flowLayout3.SetMinimumSize(this.textBox6, new System.Drawing.Size(82, 20));
			this.textBox6.Name = "textBox6";
			this.flowLayout3.SetPreferredSize(this.textBox6, new System.Drawing.Size(82, 20));
			this.textBox6.Size = new System.Drawing.Size(215, 20);
			this.textBox6.TabIndex = 2;
			this.textBox6.Text = "Justify";
			// 
			// autoLabel1
			// 
			this.autoLabel1.DX = -36;
			this.autoLabel1.DY = 2;
			this.autoLabel1.LabeledControl = this.textBox5;
			this.autoLabel1.Location = new System.Drawing.Point(260, 31);
			this.autoLabel1.Name = "autoLabel1";
			this.autoLabel1.Size = new System.Drawing.Size(32, 16);
			this.autoLabel1.TabIndex = 8;
			this.autoLabel1.Text = "Label";
			// 
			// textBox5
			// 
			this.flowLayout3.SetConstraints(this.textBox5, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, false, false, false));
			this.textBox5.Location = new System.Drawing.Point(296, 29);
			this.flowLayout3.SetMinimumSize(this.textBox5, new System.Drawing.Size(100, 20));
			this.textBox5.Name = "textBox5";
			this.flowLayout3.SetPreferredSize(this.textBox5, new System.Drawing.Size(100, 20));
			this.textBox5.TabIndex = 3;
			this.textBox5.Text = "Right";
			// 
			// flowLayout3
			// 
			this.flowLayout3.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints;
			this.flowLayout3.AutoHeight = true;
			this.flowLayout3.BottomMargin = 4;
			this.flowLayout3.ContainerControl = this.panel2;
			this.flowLayout3.HorzFarMargin = 4;
			this.flowLayout3.HorzNearMargin = 4;
			this.flowLayout3.TopMargin = 4;
			// 
			// flowLayout1
			// 
			this.flowLayout1.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints;
			this.flowLayout1.AutoHeight = true;
			this.flowLayout1.BottomMargin = 4;
			this.flowLayout1.ContainerControl = this.panel1;
			this.flowLayout1.HorzFarMargin = 4;
			this.flowLayout1.HorzNearMargin = 4;
			this.flowLayout1.TopMargin = 4;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(205)), ((System.Byte)(212)), ((System.Byte)(231)));
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.groupBox1,
																				 this.groupBox2});
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 132);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(400, 185);
			this.panel3.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(205)), ((System.Byte)(212)), ((System.Byte)(231)));
			this.flowLayout4.SetConstraints(this.groupBox1, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Justify, false, false, true));
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.radioButton4,
																					this.radioButton3,
																					this.radioButton2,
																					this.radioButton1});
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(4, 4);
			this.flowLayout4.SetMinimumSize(this.groupBox1, new System.Drawing.Size(150, 100));
			this.groupBox1.Name = "groupBox1";
			this.flowLayout4.SetPreferredSize(this.groupBox1, new System.Drawing.Size(150, 100));
			this.groupBox1.Size = new System.Drawing.Size(392, 62);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Vertical Flow";
			// 
			// radioButton4
			// 
			this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(205)), ((System.Byte)(212)), ((System.Byte)(231)));
			this.flowLayout5.SetConstraints(this.radioButton4, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton4.Location = new System.Drawing.Point(4, 14);
			this.flowLayout5.SetMinimumSize(this.radioButton4, new System.Drawing.Size(104, 30));
			this.radioButton4.Name = "radioButton4";
			this.flowLayout5.SetPreferredSize(this.radioButton4, new System.Drawing.Size(104, 30));
			this.radioButton4.Size = new System.Drawing.Size(92, 30);
			this.radioButton4.TabIndex = 0;
			this.radioButton4.Text = "Option 1";
			// 
			// radioButton3
			// 
			this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(205)), ((System.Byte)(212)), ((System.Byte)(231)));
			this.flowLayout5.SetConstraints(this.radioButton3, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton3.Location = new System.Drawing.Point(101, 14);
			this.flowLayout5.SetMinimumSize(this.radioButton3, new System.Drawing.Size(104, 30));
			this.radioButton3.Name = "radioButton3";
			this.flowLayout5.SetPreferredSize(this.radioButton3, new System.Drawing.Size(104, 30));
			this.radioButton3.Size = new System.Drawing.Size(92, 30);
			this.radioButton3.TabIndex = 1;
			this.radioButton3.Text = "Option 2";
			// 
			// radioButton2
			// 
			this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(205)), ((System.Byte)(212)), ((System.Byte)(231)));
			this.flowLayout5.SetConstraints(this.radioButton2, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton2.Location = new System.Drawing.Point(198, 14);
			this.flowLayout5.SetMinimumSize(this.radioButton2, new System.Drawing.Size(104, 30));
			this.radioButton2.Name = "radioButton2";
			this.flowLayout5.SetPreferredSize(this.radioButton2, new System.Drawing.Size(104, 30));
			this.radioButton2.Size = new System.Drawing.Size(92, 30);
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "Option 3";
			// 
			// radioButton1
			// 
			this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(205)), ((System.Byte)(212)), ((System.Byte)(231)));
			this.flowLayout5.SetConstraints(this.radioButton1, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton1.Location = new System.Drawing.Point(295, 14);
			this.flowLayout5.SetMinimumSize(this.radioButton1, new System.Drawing.Size(104, 30));
			this.radioButton1.Name = "radioButton1";
			this.flowLayout5.SetPreferredSize(this.radioButton1, new System.Drawing.Size(104, 30));
			this.radioButton1.Size = new System.Drawing.Size(92, 30);
			this.radioButton1.TabIndex = 3;
			this.radioButton1.Text = "Option 4";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(205)), ((System.Byte)(212)), ((System.Byte)(231)));
			this.flowLayout4.SetConstraints(this.groupBox2, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Justify, false, false, true));
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.autoLabel11,
																					this.autoLabel10,
																					this.autoLabel9,
																					this.autoLabel8,
																					this.checkBox3,
																					this.checkBox2,
																					this.checkBox1,
																					this.textBox9,
																					this.textBox10,
																					this.textBox11,
																					this.textBox12,
																					this.textBox13,
																					this.textBox14});
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(4, 71);
			this.flowLayout4.SetMinimumSize(this.groupBox2, new System.Drawing.Size(256, 180));
			this.groupBox2.Name = "groupBox2";
			this.flowLayout4.SetPreferredSize(this.groupBox2, new System.Drawing.Size(256, 180));
			this.groupBox2.Size = new System.Drawing.Size(392, 111);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Vertical Flow";
			// 
			// autoLabel11
			// 
			this.autoLabel11.DX = -59;
			this.autoLabel11.DY = 2;
			this.autoLabel11.LabeledControl = this.textBox13;
			this.autoLabel11.Location = new System.Drawing.Point(253, 41);
			this.autoLabel11.Name = "autoLabel11";
			this.autoLabel11.Size = new System.Drawing.Size(55, 16);
			this.autoLabel11.TabIndex = 12;
			this.autoLabel11.Text = "AutoLabel";
			// 
			// textBox13
			// 
			this.flowLayout7.SetConstraints(this.textBox13, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.textBox13.Location = new System.Drawing.Point(312, 39);
			this.flowLayout7.SetMinimumSize(this.textBox13, new System.Drawing.Size(66, 20));
			this.textBox13.Name = "textBox13";
			this.flowLayout7.SetPreferredSize(this.textBox13, new System.Drawing.Size(66, 20));
			this.textBox13.Size = new System.Drawing.Size(67, 20);
			this.textBox13.TabIndex = 7;
			this.textBox13.Text = "Text";
			// 
			// autoLabel10
			// 
			this.autoLabel10.DX = -59;
			this.autoLabel10.DY = 2;
			this.autoLabel10.LabeledControl = this.textBox12;
			this.autoLabel10.Location = new System.Drawing.Point(253, 16);
			this.autoLabel10.Name = "autoLabel10";
			this.autoLabel10.Size = new System.Drawing.Size(55, 16);
			this.autoLabel10.TabIndex = 11;
			this.autoLabel10.Text = "AutoLabel";
			// 
			// textBox12
			// 
			this.flowLayout7.SetConstraints(this.textBox12, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.textBox12.Location = new System.Drawing.Point(312, 14);
			this.flowLayout7.SetMinimumSize(this.textBox12, new System.Drawing.Size(66, 20));
			this.textBox12.Name = "textBox12";
			this.flowLayout7.SetPreferredSize(this.textBox12, new System.Drawing.Size(66, 20));
			this.textBox12.Size = new System.Drawing.Size(67, 20);
			this.textBox12.TabIndex = 6;
			this.textBox12.Text = "Text";
			// 
			// autoLabel9
			// 
			this.autoLabel9.DX = -59;
			this.autoLabel9.DY = 2;
			this.autoLabel9.LabeledControl = this.textBox11;
			this.autoLabel9.Location = new System.Drawing.Point(114, 66);
			this.autoLabel9.Name = "autoLabel9";
			this.autoLabel9.Size = new System.Drawing.Size(55, 16);
			this.autoLabel9.TabIndex = 10;
			this.autoLabel9.Text = "AutoLabel";
			// 
			// textBox11
			// 
			this.flowLayout7.SetConstraints(this.textBox11, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.textBox11.Location = new System.Drawing.Point(173, 64);
			this.flowLayout7.SetMinimumSize(this.textBox11, new System.Drawing.Size(66, 20));
			this.textBox11.Name = "textBox11";
			this.flowLayout7.SetPreferredSize(this.textBox11, new System.Drawing.Size(66, 20));
			this.textBox11.Size = new System.Drawing.Size(75, 20);
			this.textBox11.TabIndex = 5;
			this.textBox11.Text = "Text";
			// 
			// autoLabel8
			// 
			this.autoLabel8.DX = -59;
			this.autoLabel8.DY = 2;
			this.autoLabel8.LabeledControl = this.textBox14;
			this.autoLabel8.Location = new System.Drawing.Point(253, 66);
			this.autoLabel8.Name = "autoLabel8";
			this.autoLabel8.Size = new System.Drawing.Size(55, 16);
			this.autoLabel8.TabIndex = 9;
			this.autoLabel8.Text = "AutoLabel";
			// 
			// textBox14
			// 
			this.flowLayout7.SetConstraints(this.textBox14, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.textBox14.Location = new System.Drawing.Point(312, 64);
			this.flowLayout7.SetMinimumSize(this.textBox14, new System.Drawing.Size(66, 20));
			this.textBox14.Name = "textBox14";
			this.flowLayout7.SetPreferredSize(this.textBox14, new System.Drawing.Size(66, 20));
			this.textBox14.Size = new System.Drawing.Size(67, 20);
			this.textBox14.TabIndex = 8;
			this.textBox14.Text = "Text";
			// 
			// checkBox3
			// 
			this.flowLayout7.SetConstraints(this.checkBox3, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox3.Location = new System.Drawing.Point(4, 14);
			this.flowLayout7.SetMinimumSize(this.checkBox3, new System.Drawing.Size(104, 24));
			this.checkBox3.Name = "checkBox3";
			this.flowLayout7.SetPreferredSize(this.checkBox3, new System.Drawing.Size(104, 24));
			this.checkBox3.Size = new System.Drawing.Size(105, 24);
			this.checkBox3.TabIndex = 0;
			this.checkBox3.Text = "Check 1";
			// 
			// checkBox2
			// 
			this.flowLayout7.SetConstraints(this.checkBox2, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox2.Location = new System.Drawing.Point(4, 43);
			this.flowLayout7.SetMinimumSize(this.checkBox2, new System.Drawing.Size(104, 24));
			this.checkBox2.Name = "checkBox2";
			this.flowLayout7.SetPreferredSize(this.checkBox2, new System.Drawing.Size(104, 24));
			this.checkBox2.Size = new System.Drawing.Size(105, 24);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Check 2";
			// 
			// checkBox1
			// 
			this.flowLayout7.SetConstraints(this.checkBox1, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox1.Location = new System.Drawing.Point(4, 72);
			this.flowLayout7.SetMinimumSize(this.checkBox1, new System.Drawing.Size(104, 24));
			this.checkBox1.Name = "checkBox1";
			this.flowLayout7.SetPreferredSize(this.checkBox1, new System.Drawing.Size(104, 24));
			this.checkBox1.Size = new System.Drawing.Size(105, 24);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Check 3";
			// 
			// textBox9
			// 
			this.flowLayout7.SetConstraints(this.textBox9, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.textBox9.Location = new System.Drawing.Point(114, 14);
			this.flowLayout7.SetMinimumSize(this.textBox9, new System.Drawing.Size(100, 20));
			this.textBox9.Name = "textBox9";
			this.flowLayout7.SetPreferredSize(this.textBox9, new System.Drawing.Size(100, 20));
			this.textBox9.Size = new System.Drawing.Size(134, 20);
			this.textBox9.TabIndex = 3;
			this.textBox9.Text = "Text";
			// 
			// textBox10
			// 
			this.flowLayout7.SetConstraints(this.textBox10, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Top, false, true, false));
			this.textBox10.Location = new System.Drawing.Point(114, 39);
			this.flowLayout7.SetMinimumSize(this.textBox10, new System.Drawing.Size(133, 20));
			this.textBox10.Name = "textBox10";
			this.flowLayout7.SetPreferredSize(this.textBox10, new System.Drawing.Size(133, 20));
			this.textBox10.Size = new System.Drawing.Size(134, 20);
			this.textBox10.TabIndex = 4;
			this.textBox10.Text = "Text";
			// 
			// flowLayout4
			// 
			this.flowLayout4.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints;
			this.flowLayout4.BottomMargin = 4;
			this.flowLayout4.ContainerControl = this.panel3;
			this.flowLayout4.HorzFarMargin = 4;
			this.flowLayout4.HorzNearMargin = 4;
			this.flowLayout4.TopMargin = 4;
			// 
			// flowLayout5
			// 
			this.flowLayout5.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints;
			this.flowLayout5.BottomMargin = 4;
			this.flowLayout5.ContainerControl = this.groupBox1;
			this.flowLayout5.HorzFarMargin = 8;
			this.flowLayout5.HorzNearMargin = 4;
			this.flowLayout5.LayoutMode = Syncfusion.Windows.Forms.Tools.FlowLayoutMode.Vertical;
			this.flowLayout5.TopMargin = 14;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(112)), ((System.Byte)(156)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(4, 4);
			this.flowLayout6.SetMinimumSize(this.button1, new System.Drawing.Size(75, 23));
			this.button1.Name = "button1";
			this.flowLayout6.SetPreferredSize(this.button1, new System.Drawing.Size(75, 23));
			this.button1.TabIndex = 0;
			this.button1.Text = "Left";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(112)), ((System.Byte)(156)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(84, 4);
			this.flowLayout6.SetMinimumSize(this.button2, new System.Drawing.Size(75, 23));
			this.button2.Name = "button2";
			this.flowLayout6.SetPreferredSize(this.button2, new System.Drawing.Size(75, 23));
			this.button2.TabIndex = 1;
			this.button2.Text = "Left";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(112)), ((System.Byte)(156)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(164, 4);
			this.flowLayout6.SetMinimumSize(this.button3, new System.Drawing.Size(75, 23));
			this.button3.Name = "button3";
			this.flowLayout6.SetPreferredSize(this.button3, new System.Drawing.Size(75, 23));
			this.button3.TabIndex = 2;
			this.button3.Text = "Left";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(112)), ((System.Byte)(156)));
			this.flowLayout6.SetConstraints(this.button4, new Syncfusion.Windows.Forms.Tools.FlowLayoutConstraints(true, Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Right, Syncfusion.Windows.Forms.Tools.VertFlowAlign.Center, false, false, false));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(321, 4);
			this.flowLayout6.SetMinimumSize(this.button4, new System.Drawing.Size(75, 23));
			this.button4.Name = "button4";
			this.flowLayout6.SetPreferredSize(this.button4, new System.Drawing.Size(75, 23));
			this.button4.TabIndex = 3;
			this.button4.Text = "Right";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(227)), ((System.Byte)(239)));
			this.panel4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.button1,
																				 this.button2,
																				 this.button3,
																				 this.button4});
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(0, 317);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(400, 32);
			this.panel4.TabIndex = 4;
			// 
			// flowLayout6
			// 
			this.flowLayout6.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints;
			this.flowLayout6.BottomMargin = 4;
			this.flowLayout6.ContainerControl = this.panel4;
			this.flowLayout6.HorzFarMargin = 4;
			this.flowLayout6.HorzNearMargin = 4;
			this.flowLayout6.TopMargin = 4;
			// 
			// flowLayout7
			// 
			this.flowLayout7.Alignment = Syncfusion.Windows.Forms.Tools.FlowAlignment.ChildConstraints;
			this.flowLayout7.BottomMargin = 10;
			this.flowLayout7.ContainerControl = this.groupBox2;
			this.flowLayout7.HorzFarMargin = 12;
			this.flowLayout7.HorzNearMargin = 4;
			this.flowLayout7.LayoutMode = Syncfusion.Windows.Forms.Tools.FlowLayoutMode.Vertical;
			this.flowLayout7.TopMargin = 14;
			// 
			// FlowLayoutCC
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(400, 349);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel3,
																		  this.panel2,
																		  this.panel1,
																		  this.panel4});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FlowLayoutCC";
			this.Text = "FlowLayout (with ChildConstraints)";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flowLayout3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flowLayout4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout5)).EndInit();
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flowLayout6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.flowLayout7)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	}
}
