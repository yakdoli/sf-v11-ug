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
using Syncfusion.Windows.Forms.Tools;

namespace StatusBarAdvDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdv statusBarAdv3;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel statusBarAdvPanel11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel timePanel;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button2;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel customPanel;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel keyPanel;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel datePanel;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
			this.statusBarAdv3 = new Syncfusion.Windows.Forms.Tools.StatusBarAdv();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.customPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.statusBarAdvPanel11 = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.datePanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.timePanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.keyPanel = new Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdv3)).BeginInit();
			this.statusBarAdv3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.customPanel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datePanel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timePanel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.keyPanel)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusBarPanel1
			// 
			this.statusBarPanel1.Text = "statusBarPanel1";
			// 
			// statusBarAdv3
			// 
			this.statusBarAdv3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219))));
			this.statusBarAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump;
			this.statusBarAdv3.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdv3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.statusBarAdv3.Controls.AddRange(new System.Windows.Forms.Control[] {
																						this.button1,
																						this.textBox1,
																						this.customPanel,
																						this.statusBarAdvPanel11,
																						this.timePanel,
																						this.keyPanel,
																						this.datePanel});
			this.statusBarAdv3.CustomLayoutBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
			this.statusBarAdv3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.statusBarAdv3.DockPadding.All = 3;
			this.statusBarAdv3.Location = new System.Drawing.Point(0, 392);
			this.statusBarAdv3.Name = "statusBarAdv3";
			this.statusBarAdv3.Size = new System.Drawing.Size(616, 22);
			this.statusBarAdv3.Spacing = new System.Drawing.Size(2, 2);
			this.statusBarAdv3.TabIndex = 2;
			this.statusBarAdv3.ThemesEnabled = true;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.PowderBlue;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(0, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 18);
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(58, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(62, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "textBox";
			// 
			// customPanel
			// 
			this.customPanel.AnimationDirection = Syncfusion.Windows.Forms.Tools.MarqueeDirection.Right;
			this.customPanel.AnimationStyle = Syncfusion.Windows.Forms.Tools.MarqueeStyle.Slide;
			this.customPanel.BackColor = System.Drawing.Color.Transparent;
			this.customPanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.customPanel.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.customPanel.BorderColor = System.Drawing.Color.Black;
			this.customPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.customPanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.customPanel.IsMarquee = true;
			this.customPanel.Location = new System.Drawing.Point(122, 2);
			this.customPanel.Name = "customPanel";
			this.customPanel.Size = new System.Drawing.Size(100, 18);
			this.customPanel.TabIndex = 4;
			this.customPanel.Text = "Custom Panel";
			this.customPanel.ThemesEnabled = true;
			// 
			// statusBarAdvPanel11
			// 
			this.statusBarAdvPanel11.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.statusBarAdvPanel11.BackColor = System.Drawing.Color.Transparent;
			this.statusBarAdvPanel11.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.statusBarAdvPanel11.BorderColor = System.Drawing.Color.Black;
			this.statusBarAdvPanel11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.statusBarAdvPanel11.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.statusBarAdvPanel11.Location = new System.Drawing.Point(224, 2);
			this.statusBarAdvPanel11.Name = "statusBarAdvPanel11";
			this.statusBarAdvPanel11.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CurrentCulture;
			this.statusBarAdvPanel11.Size = new System.Drawing.Size(123, 18);
			this.statusBarAdvPanel11.SizeToContent = true;
			this.statusBarAdvPanel11.TabIndex = 0;
			this.statusBarAdvPanel11.Text = "statusBarAdvPanel11";
			this.statusBarAdvPanel11.ThemesEnabled = true;
			// 
			// datePanel
			// 
			this.datePanel.Alignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.datePanel.BackColor = System.Drawing.Color.DarkGray;
			this.datePanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.datePanel.BorderColor = System.Drawing.Color.Black;
			this.datePanel.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dashed;
			this.datePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.datePanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Justify;
			this.datePanel.Location = new System.Drawing.Point(516, 2);
			this.datePanel.Name = "datePanel";
			this.datePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortDate;
			this.datePanel.PreferredSize = new System.Drawing.Size(65, 18);
			this.datePanel.Size = new System.Drawing.Size(83, 18);
			this.datePanel.TabIndex = 1;
			this.datePanel.Text = "statusBarAdvPanel12";
			// 
			// timePanel
			// 
			this.timePanel.BackColor = System.Drawing.Color.LightSteelBlue;
			this.timePanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.timePanel.BorderColor = System.Drawing.Color.Black;
			this.timePanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.timePanel.Location = new System.Drawing.Point(349, 2);
			this.timePanel.Name = "timePanel";
			this.timePanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.ShortTime;
			this.timePanel.Size = new System.Drawing.Size(63, 18);
			this.timePanel.TabIndex = 3;
			this.timePanel.Text = "statusBarAdvPanel1";
			// 
			// keyPanel
			// 
			this.keyPanel.BackColor = System.Drawing.Color.Transparent;
			this.keyPanel.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.keyPanel.BorderColor = System.Drawing.Color.Black;
			this.keyPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.keyPanel.HAlign = Syncfusion.Windows.Forms.Tools.HorzFlowAlign.Left;
			this.keyPanel.Location = new System.Drawing.Point(414, 2);
			this.keyPanel.Name = "keyPanel";
			this.keyPanel.PanelType = Syncfusion.Windows.Forms.Tools.StatusBarAdvPanelType.CapsLockState;
			this.keyPanel.Size = new System.Drawing.Size(100, 18);
			this.keyPanel.TabIndex = 2;
			this.keyPanel.Text = "statusBarAdvPanel13";
			this.keyPanel.ThemesEnabled = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(40, 112);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.TabIndex = 2;
			this.radioButton3.Text = "Scroll Lock";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(40, 88);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 1;
			this.radioButton2.Text = "Num Lock";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(40, 64);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Caps Lock";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton5
			// 
			this.radioButton5.BackColor = System.Drawing.Color.Transparent;
			this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
			this.radioButton5.Location = new System.Drawing.Point(40, 104);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.TabIndex = 1;
			this.radioButton5.Text = "Long Date";
			this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.BackColor = System.Drawing.Color.Transparent;
			this.radioButton4.Checked = true;
			this.radioButton4.Location = new System.Drawing.Point(40, 72);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.TabIndex = 0;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Short Date";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// radioButton6
			// 
			this.radioButton6.Checked = true;
			this.radioButton6.Location = new System.Drawing.Point(40, 72);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.TabIndex = 2;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "Short Time";
			this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
			// 
			// radioButton7
			// 
			this.radioButton7.Location = new System.Drawing.Point(40, 96);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.TabIndex = 3;
			this.radioButton7.Text = "Long Time";
			this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(48, 104);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "Set Text";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(48, 64);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 0;
			this.textBox2.Text = "Custom Panel";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.tabPage1,
																					  this.tabPage2,
																					  this.tabPage3,
																					  this.tabPage4});
			this.tabControl1.Location = new System.Drawing.Point(152, 48);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(320, 264);
			this.tabControl1.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.tabPage1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.radioButton3,
																				   this.radioButton2,
																				   this.radioButton1});
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(312, 238);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "KeyStatePanels";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.tabPage2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.radioButton5,
																				   this.radioButton4});
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(312, 238);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "DatePanels";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.tabPage3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.radioButton7,
																				   this.radioButton6});
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(312, 238);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "TimePanels";
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.tabPage4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				   this.textBox2,
																				   this.button2});
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(312, 238);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "CustomPanels";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.ClientSize = new System.Drawing.Size(616, 414);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.tabControl1,
																		  this.statusBarAdv3});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StatusBarAdv";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdv3)).EndInit();
			this.statusBarAdv3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.customPanel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.statusBarAdvPanel11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datePanel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timePanel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.keyPanel)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
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

		

		private void Form1_Load(object sender, System.EventArgs e)
		{

		}

		#region keyPanel
		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked) this.keyPanel.PanelType = StatusBarAdvPanelType.CapsLockState;
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton2.Checked) this.keyPanel.PanelType = StatusBarAdvPanelType.NumLockState;
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton3.Checked) this.keyPanel.PanelType = StatusBarAdvPanelType.ScrollLockState;
		}
		#endregion
		#region TimePanel
		private void radioButton6_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton6.Checked) this.timePanel.PanelType = StatusBarAdvPanelType.ShortTime;
		}

		private void radioButton7_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton7.Checked) this.timePanel.PanelType = StatusBarAdvPanelType.LongTime;
		}
		#endregion
		#region DatePanel
		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton4.Checked) this.datePanel.PanelType = StatusBarAdvPanelType.ShortDate;
		}

		private void radioButton5_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton5.Checked) this.datePanel.PanelType = StatusBarAdvPanelType.LongDate;
		}
		#endregion
		#region customPanel

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.customPanel.Text = this.textBox2.Text;
		}
		#endregion
	}
}
