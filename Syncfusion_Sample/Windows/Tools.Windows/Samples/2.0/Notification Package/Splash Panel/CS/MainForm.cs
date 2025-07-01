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

namespace SplashPanelDemo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Tools;
	using Syncfusion.Drawing;
	using System.Reflection;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.RadioButton alignBottomLeft;
		private System.Windows.Forms.RadioButton alignTopRight;
		private System.Windows.Forms.RadioButton alignTopLeft;
		private System.Windows.Forms.RadioButton alignCenter;
		private System.Windows.Forms.RadioButton alignSystemTray;
		private System.Windows.Forms.RadioButton alignBottomRight;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton alignCustom;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TextBox timerInterval;
		private Point currentPt1;
		private Point currentPt2;
		private Point currentPt3;
		private Point currentPt4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton splashPanel1Selected;
		private System.Windows.Forms.RadioButton splashPanel2Selected;
		private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel1;
		private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label2;
		private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton splashPanel4Selected;
		private System.Windows.Forms.RadioButton splashPanel3Selected;
		private Syncfusion.Windows.Forms.Tools.SplashPanel splashPanel4;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button5;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
		private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
		private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
		private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel5;

        private delegate void SetStringDelegate(string val);//Any string value

		public MainForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.alignCustom = new System.Windows.Forms.RadioButton();
			this.alignBottomLeft = new System.Windows.Forms.RadioButton();
			this.alignTopRight = new System.Windows.Forms.RadioButton();
			this.alignTopLeft = new System.Windows.Forms.RadioButton();
			this.alignCenter = new System.Windows.Forms.RadioButton();
			this.alignSystemTray = new System.Windows.Forms.RadioButton();
			this.alignBottomRight = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.timerInterval = new System.Windows.Forms.TextBox();
			this.splashPanel1Selected = new System.Windows.Forms.RadioButton();
			this.splashPanel2Selected = new System.Windows.Forms.RadioButton();
			this.splashPanel4Selected = new System.Windows.Forms.RadioButton();
			this.splashPanel3Selected = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.splashPanel1 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.splashPanel2 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.splashPanel3 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.splashPanel4 = new Syncfusion.Windows.Forms.Tools.SplashPanel();
			this.button5 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
			this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
			this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
			this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
			this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
			this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.splashPanel1.SuspendLayout();
			this.splashPanel2.SuspendLayout();
			this.splashPanel3.SuspendLayout();
			this.splashPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
			this.gradientPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
			this.gradientPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
			this.gradientPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
			this.gradientPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem3});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&Exit";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem4});
			this.menuItem3.Text = "Help";
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 0;
			this.menuItem4.Text = "About...";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// alignCustom
			// 
			this.alignCustom.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.alignCustom.Location = new System.Drawing.Point(336, 40);
			this.alignCustom.Name = "alignCustom";
			this.alignCustom.Size = new System.Drawing.Size(88, 24);
			this.alignCustom.TabIndex = 30;
			this.alignCustom.Text = "Custom";
			// 
			// alignBottomLeft
			// 
			this.alignBottomLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.alignBottomLeft.Location = new System.Drawing.Point(136, 72);
			this.alignBottomLeft.Name = "alignBottomLeft";
			this.alignBottomLeft.Size = new System.Drawing.Size(88, 24);
			this.alignBottomLeft.TabIndex = 27;
			this.alignBottomLeft.Text = "BottomLeft";
			// 
			// alignTopRight
			// 
			this.alignTopRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.alignTopRight.Location = new System.Drawing.Point(240, 40);
			this.alignTopRight.Name = "alignTopRight";
			this.alignTopRight.Size = new System.Drawing.Size(80, 24);
			this.alignTopRight.TabIndex = 26;
			this.alignTopRight.Text = "TopRight";
			// 
			// alignTopLeft
			// 
			this.alignTopLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.alignTopLeft.Location = new System.Drawing.Point(136, 40);
			this.alignTopLeft.Name = "alignTopLeft";
			this.alignTopLeft.Size = new System.Drawing.Size(88, 24);
			this.alignTopLeft.TabIndex = 28;
			this.alignTopLeft.Text = "TopLeft";
			// 
			// alignCenter
			// 
			this.alignCenter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.alignCenter.Location = new System.Drawing.Point(16, 72);
			this.alignCenter.Name = "alignCenter";
			this.alignCenter.Size = new System.Drawing.Size(80, 24);
			this.alignCenter.TabIndex = 24;
			this.alignCenter.Text = "Center";
			// 
			// alignSystemTray
			// 
			this.alignSystemTray.Checked = true;
			this.alignSystemTray.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.alignSystemTray.Location = new System.Drawing.Point(16, 40);
			this.alignSystemTray.Name = "alignSystemTray";
			this.alignSystemTray.Size = new System.Drawing.Size(88, 24);
			this.alignSystemTray.TabIndex = 25;
			this.alignSystemTray.TabStop = true;
			this.alignSystemTray.Text = "System Tray";
			// 
			// alignBottomRight
			// 
			this.alignBottomRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.alignBottomRight.Location = new System.Drawing.Point(240, 72);
			this.alignBottomRight.Name = "alignBottomRight";
			this.alignBottomRight.Size = new System.Drawing.Size(88, 24);
			this.alignBottomRight.TabIndex = 29;
			this.alignBottomRight.Text = "BottomRight";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(234)), ((System.Byte)(255)));
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.groupBox1.Location = new System.Drawing.Point(0, 369);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(792, 184);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Events Log";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(234)), ((System.Byte)(255)));
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.textBox1.Location = new System.Drawing.Point(3, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(786, 165);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// trackBar1
			// 
			this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.trackBar1.Location = new System.Drawing.Point(48, 8);
			this.trackBar1.Maximum = 50;
			this.trackBar1.Minimum = 2;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(288, 45);
			this.trackBar1.TabIndex = 14;
			this.trackBar1.TickFrequency = 5;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Value = 10;
			// 
			// timerInterval
			// 
			this.timerInterval.ForeColor = System.Drawing.Color.MidnightBlue;
			this.timerInterval.Location = new System.Drawing.Point(440, 8);
			this.timerInterval.Name = "timerInterval";
			this.timerInterval.Size = new System.Drawing.Size(72, 20);
			this.timerInterval.TabIndex = 15;
			this.timerInterval.Text = "5000";
			// 
			// splashPanel1Selected
			// 
			this.splashPanel1Selected.Checked = true;
			this.splashPanel1Selected.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.splashPanel1Selected.Location = new System.Drawing.Point(24, 40);
			this.splashPanel1Selected.Name = "splashPanel1Selected";
			this.splashPanel1Selected.TabIndex = 18;
			this.splashPanel1Selected.TabStop = true;
			this.splashPanel1Selected.Text = "Splash Panel 1";
			// 
			// splashPanel2Selected
			// 
			this.splashPanel2Selected.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.splashPanel2Selected.Location = new System.Drawing.Point(24, 72);
			this.splashPanel2Selected.Name = "splashPanel2Selected";
			this.splashPanel2Selected.TabIndex = 19;
			this.splashPanel2Selected.Text = "Splash Panel 2";
			// 
			// splashPanel4Selected
			// 
			this.splashPanel4Selected.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.splashPanel4Selected.Location = new System.Drawing.Point(144, 72);
			this.splashPanel4Selected.Name = "splashPanel4Selected";
			this.splashPanel4Selected.TabIndex = 21;
			this.splashPanel4Selected.Text = "Splash Panel 4";
			// 
			// splashPanel3Selected
			// 
			this.splashPanel3Selected.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.splashPanel3Selected.Location = new System.Drawing.Point(144, 40);
			this.splashPanel3Selected.Name = "splashPanel3Selected";
			this.splashPanel3Selected.TabIndex = 20;
			this.splashPanel3Selected.Text = "Splash Panel 3";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 21;
			this.label1.Text = "Speed";
			// 
			// splashPanel1
			// 
			this.splashPanel1.AnimationSpeed = 10;
			this.splashPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.HighlightText);
			this.splashPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splashPanel1.BackgroundImage")));
			this.splashPanel1.Controls.Add(this.linkLabel1);
			this.splashPanel1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center;
			this.splashPanel1.DiscreetLocation = new System.Drawing.Point(0, 0);
			this.splashPanel1.Location = new System.Drawing.Point(8, 16);
			this.splashPanel1.Name = "splashPanel1";
			this.splashPanel1.ShowAnimation = true;
			this.splashPanel1.Size = new System.Drawing.Size(176, 136);
            this.splashPanel1.SlideStyle = SlideStyle.TopToBottom;
			this.splashPanel1.SuspendAutoCloseWhenMouseOver = false;
			this.splashPanel1.TabIndex = 27;
			this.splashPanel1.TimerInterval = 5000;
			this.splashPanel1.BeforeSplash += new System.ComponentModel.CancelEventHandler(this.splashPanel1_BeforeSplash);
			this.splashPanel1.SplashClosed += new Syncfusion.Windows.Forms.Tools.SplashClosedEventHandler(this.splashPanel1_SplashClosing);
			this.splashPanel1.SplashDisplayed += new System.EventHandler(this.splashPanel1_SplashDisplayed);
			// 
			// linkLabel1
			// 
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.ForeColor = System.Drawing.Color.White;
			this.linkLabel1.LinkColor = System.Drawing.Color.FloralWhite;
			this.linkLabel1.Location = new System.Drawing.Point(24, 64);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(112, 24);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "www.syncfusion.com";
			// 
			// splashPanel2
			// 
			this.splashPanel2.AnimationSpeed = 10;
			this.splashPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
																																						   System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(228)), ((System.Byte)(152))),
																																						   System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(223)), ((System.Byte)(134))),
																																						   System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(218)), ((System.Byte)(115))),
																																						   System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(236)), ((System.Byte)(178))),
																																						   System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(240)), ((System.Byte)(189))),
																																						   System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(250)), ((System.Byte)(217)))});
            this.splashPanel2.SlideStyle = SlideStyle.FadeIn;
			this.splashPanel2.BorderType = Syncfusion.Windows.Forms.Tools.SplashBorderType.None;
			this.splashPanel2.Controls.Add(this.checkedListBox1);
			this.splashPanel2.Controls.Add(this.buttonAdv2);
			this.splashPanel2.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center;
			this.splashPanel2.DiscreetLocation = new System.Drawing.Point(0, 0);
			this.splashPanel2.Location = new System.Drawing.Point(200, 16);
			this.splashPanel2.Name = "splashPanel2";
			this.splashPanel2.ShowAnimation = true;
			this.splashPanel2.Size = new System.Drawing.Size(200, 136);
			this.splashPanel2.SuspendAutoCloseWhenMouseOver = true;
			this.splashPanel2.TabIndex = 28;
			this.splashPanel2.TimerInterval = 5000;
			this.splashPanel2.SplashMouseLeave += new System.EventHandler(this.splashPanel2_SplashMouseLeave);
			this.splashPanel2.BeforeSplash += new System.ComponentModel.CancelEventHandler(this.splashPanel2_BeforeSplash);
			this.splashPanel2.SplashMouseEnter += new System.EventHandler(this.splashPanel2_SplashMouseEnter);
			this.splashPanel2.SplashClosed += new Syncfusion.Windows.Forms.Tools.SplashClosedEventHandler(this.splashPanel2_SplashClosing);
			this.splashPanel2.SplashDisplayed += new System.EventHandler(this.splashPanel2_SplashDisplayed);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Items.AddRange(new object[] {
																 "Write code.",
																 "Test using NUnit.",
																 "Test using Usage tests.",
																 "Test on All platforms.",
																 "Send download instructions."});
			this.checkedListBox1.Location = new System.Drawing.Point(16, 16);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(168, 79);
			this.checkedListBox1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(336, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 32);
			this.label2.TabIndex = 29;
			this.label2.Text = "Display Interval (Milliseconds)";
			// 
			// splashPanel3
			// 
			this.splashPanel3.AnimationSpeed = 10;
			this.splashPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
																																						   System.Drawing.Color.Black,
																																						   System.Drawing.Color.Black,
																																						   System.Drawing.Color.Black,
																																						   System.Drawing.Color.FromArgb(((System.Byte)(73)), ((System.Byte)(75)), ((System.Byte)(78))),
																																						   System.Drawing.Color.FromArgb(((System.Byte)(87)), ((System.Byte)(90)), ((System.Byte)(94))),
																																						   System.Drawing.Color.FromArgb(((System.Byte)(104)), ((System.Byte)(108)), ((System.Byte)(113)))});
            this.splashPanel3.SlideStyle = SlideStyle.LeftToRight;
			this.splashPanel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.splashPanel3.Controls.Add(this.label3);
			this.splashPanel3.Controls.Add(this.buttonAdv1);
			this.splashPanel3.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center;
			this.splashPanel3.DiscreetLocation = new System.Drawing.Point(0, 0);
			this.splashPanel3.Location = new System.Drawing.Point(416, 16);
			this.splashPanel3.Name = "splashPanel3";
			this.splashPanel3.ShowAnimation = true;
			this.splashPanel3.Size = new System.Drawing.Size(160, 144);
			this.splashPanel3.SuspendAutoCloseWhenMouseOver = false;
			this.splashPanel3.TabIndex = 30;
			this.splashPanel3.TimerInterval = 5000;
			this.splashPanel3.BeforeSplash += new System.ComponentModel.CancelEventHandler(this.splashPanel1_BeforeSplash);
			this.splashPanel3.SplashClosed += new Syncfusion.Windows.Forms.Tools.SplashClosedEventHandler(this.splashPanel3_SplashClosing);
			this.splashPanel3.SplashDisplayed += new System.EventHandler(this.splashPanel1_SplashDisplayed);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(24, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 32);
			this.label3.TabIndex = 1;
			this.label3.Text = "The Anti Virus scan is complete.";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// splashPanel4
			// 
			this.splashPanel4.AnimationSpeed = 10;
			this.splashPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(250)), ((System.Byte)(253)), ((System.Byte)(249))), System.Drawing.Color.FromArgb(((System.Byte)(223)), ((System.Byte)(244)), ((System.Byte)(212))));
			this.splashPanel4.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
			this.splashPanel4.Controls.Add(this.label4);
			this.splashPanel4.Controls.Add(this.button5);
			this.splashPanel4.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center;
			this.splashPanel4.DiscreetLocation = new System.Drawing.Point(0, 0);
			this.splashPanel4.Location = new System.Drawing.Point(600, 16);
			this.splashPanel4.Name = "splashPanel4";
			this.splashPanel4.ShowAnimation = true;
			this.splashPanel4.Size = new System.Drawing.Size(168, 144);
			this.splashPanel4.SuspendAutoCloseWhenMouseOver = false;
			this.splashPanel4.TabIndex = 31;
			this.splashPanel4.TimerInterval = 5000;
            this.splashPanel4.SlideStyle = SlideStyle.Slide;
			this.splashPanel4.BeforeSplash += new System.ComponentModel.CancelEventHandler(this.splashPanel1_BeforeSplash);
			this.splashPanel4.SplashClosed += new Syncfusion.Windows.Forms.Tools.SplashClosedEventHandler(this.splashPanel4_SplashClosing);
			this.splashPanel4.SplashDisplayed += new System.EventHandler(this.splashPanel1_SplashDisplayed);
			// 
			// button5
			// 
			this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(144, 0);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(21, 21);
			this.button5.TabIndex = 3;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 40);
			this.label4.TabIndex = 2;
			this.label4.Text = "You have received a new message";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// gradientPanel2
			// 
			this.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(158)), ((System.Byte)(171)), ((System.Byte)(206)));
			this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradientPanel2.Controls.Add(this.gradientLabel1);
			this.gradientPanel2.Controls.Add(this.splashPanel4Selected);
			this.gradientPanel2.Controls.Add(this.splashPanel3Selected);
			this.gradientPanel2.Controls.Add(this.splashPanel1Selected);
			this.gradientPanel2.Controls.Add(this.splashPanel2Selected);
			this.gradientPanel2.Location = new System.Drawing.Point(8, 248);
			this.gradientPanel2.Name = "gradientPanel2";
			this.gradientPanel2.Size = new System.Drawing.Size(280, 104);
			this.gradientPanel2.TabIndex = 33;
			// 
			// gradientPanel3
			// 
			this.gradientPanel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(158)), ((System.Byte)(171)), ((System.Byte)(206)));
			this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradientPanel3.Controls.Add(this.gradientLabel2);
			this.gradientPanel3.Controls.Add(this.alignSystemTray);
			this.gradientPanel3.Controls.Add(this.alignBottomRight);
			this.gradientPanel3.Controls.Add(this.alignCustom);
			this.gradientPanel3.Controls.Add(this.alignBottomLeft);
			this.gradientPanel3.Controls.Add(this.alignTopRight);
			this.gradientPanel3.Controls.Add(this.alignTopLeft);
			this.gradientPanel3.Controls.Add(this.alignCenter);
			this.gradientPanel3.Location = new System.Drawing.Point(344, 248);
			this.gradientPanel3.Name = "gradientPanel3";
			this.gradientPanel3.Size = new System.Drawing.Size(440, 104);
			this.gradientPanel3.TabIndex = 34;
			// 
			// gradientLabel1
			// 
			this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220))), System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220))));
			this.gradientLabel1.BorderSides = System.Windows.Forms.Border3DSide.Top;
			this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
			this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.gradientLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gradientLabel1.ForeColor = System.Drawing.Color.Maroon;
			this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
			this.gradientLabel1.Name = "gradientLabel1";
			this.gradientLabel1.Size = new System.Drawing.Size(278, 24);
			this.gradientLabel1.TabIndex = 22;
			this.gradientLabel1.Text = "Select the panel to splash";
			this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gradientLabel2
			// 
			this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220))), System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220))));
			this.gradientLabel2.BorderSides = System.Windows.Forms.Border3DSide.Top;
			this.gradientLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
			this.gradientLabel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.gradientLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gradientLabel2.ForeColor = System.Drawing.Color.Maroon;
			this.gradientLabel2.Location = new System.Drawing.Point(0, 0);
			this.gradientLabel2.Name = "gradientLabel2";
			this.gradientLabel2.Size = new System.Drawing.Size(438, 24);
			this.gradientLabel2.TabIndex = 31;
			this.gradientLabel2.Text = "Desktop Alignment";
			this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// gradientPanel4
			// 
			this.gradientPanel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(158)), ((System.Byte)(171)), ((System.Byte)(206)));
			this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradientPanel4.Controls.Add(this.label1);
			this.gradientPanel4.Controls.Add(this.trackBar1);
			this.gradientPanel4.Controls.Add(this.label2);
			this.gradientPanel4.Controls.Add(this.timerInterval);
			this.gradientPanel4.Location = new System.Drawing.Point(8, 184);
			this.gradientPanel4.Name = "gradientPanel4";
			this.gradientPanel4.Size = new System.Drawing.Size(528, 40);
			this.gradientPanel4.TabIndex = 35;
			// 
			// gradientPanel5
			// 
			this.gradientPanel5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(158)), ((System.Byte)(171)), ((System.Byte)(206)));
			this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gradientPanel5.Controls.Add(this.buttonAdv3);
			this.gradientPanel5.Controls.Add(this.buttonAdv4);
			this.gradientPanel5.Location = new System.Drawing.Point(544, 184);
			this.gradientPanel5.Name = "gradientPanel5";
			this.gradientPanel5.Size = new System.Drawing.Size(240, 40);
			this.gradientPanel5.TabIndex = 36;
			// 
			// buttonAdv1
			// 
			this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
			this.buttonAdv1.KeepFocusRectangle = false;
			this.buttonAdv1.Location = new System.Drawing.Point(48, 104);
			this.buttonAdv1.Name = "buttonAdv1";
			this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
			this.buttonAdv1.TabIndex = 37;
			this.buttonAdv1.Text = "OK";
			this.buttonAdv1.UseVisualStyle = true;
			this.buttonAdv1.Click += new System.EventHandler(this.button3_Click);
			// 
			// buttonAdv2
			// 
			this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
			this.buttonAdv2.KeepFocusRectangle = false;
			this.buttonAdv2.Location = new System.Drawing.Point(120, 104);
			this.buttonAdv2.Name = "buttonAdv2";
			this.buttonAdv2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
			this.buttonAdv2.Size = new System.Drawing.Size(64, 24);
			this.buttonAdv2.TabIndex = 37;
			this.buttonAdv2.Text = "Close";
			this.buttonAdv2.UseVisualStyle = true;
			this.buttonAdv2.Click += new System.EventHandler(this.button4_Click);
			// 
			// buttonAdv3
			// 
			this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
			this.buttonAdv3.ForeColor = System.Drawing.Color.MidnightBlue;
			this.buttonAdv3.KeepFocusRectangle = false;
			this.buttonAdv3.Location = new System.Drawing.Point(144, 8);
			this.buttonAdv3.Name = "buttonAdv3";
			this.buttonAdv3.Size = new System.Drawing.Size(88, 23);
			this.buttonAdv3.TabIndex = 37;
			this.buttonAdv3.Text = "Show Splash";
			this.buttonAdv3.UseVisualStyle = true;
			this.buttonAdv3.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonAdv4
			// 
			this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
			this.buttonAdv4.ForeColor = System.Drawing.Color.MidnightBlue;
			this.buttonAdv4.KeepFocusRectangle = false;
			this.buttonAdv4.Location = new System.Drawing.Point(8, 8);
			this.buttonAdv4.Name = "buttonAdv4";
			this.buttonAdv4.Size = new System.Drawing.Size(128, 23);
			this.buttonAdv4.TabIndex = 37;
			this.buttonAdv4.Text = "Show Splash (Modal)";
			this.buttonAdv4.UseVisualStyle = true;
			this.buttonAdv4.Click += new System.EventHandler(this.button2_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(234)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(792, 553);
			this.Controls.Add(this.gradientPanel5);
			this.Controls.Add(this.gradientPanel4);
			this.Controls.Add(this.gradientPanel3);
			this.Controls.Add(this.gradientPanel2);
			this.Controls.Add(this.splashPanel3);
			this.Controls.Add(this.splashPanel2);
			this.Controls.Add(this.splashPanel1);
			this.Controls.Add(this.splashPanel4);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Splash Panel ";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.splashPanel1.ResumeLayout(false);
			this.splashPanel2.ResumeLayout(false);
			this.splashPanel3.ResumeLayout(false);
			this.splashPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
			this.gradientPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
			this.gradientPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
			this.gradientPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
			this.gradientPanel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region SplashAlignment

		private SplashAlignment GetDesktopAlignment()
		{
			if(this.alignCenter.Checked == true)
				return SplashAlignment.Center;
			else if(this.alignSystemTray.Checked == true)
				return SplashAlignment.SystemTray;
			else if(this.alignTopRight.Checked == true)
				return SplashAlignment.RightTop;
			else if(this.alignBottomLeft.Checked == true)
				return SplashAlignment.LeftBottom;
			else if(this.alignTopLeft.Checked == true)
				return SplashAlignment.LeftTop;
			else if(this.alignBottomRight.Checked == true)
				return SplashAlignment.RightBottom;
			else if(this.alignCustom.Checked  == true)
				return SplashAlignment.Custom;
			else
				return SplashAlignment.SystemTray;
		}
		#endregion
		bool IsNumber(string text) 
		{
			if (text==null || text == String.Empty )
				return false;

			foreach(char c in text) 
			{
				if (Char.IsNumber(c) == false) 
					return false;
			}
			return true;
		}
		#region ShowSplash
		private void ShowSplash(bool isModal)
		{
			Point pt = Point.Empty;
			SplashPanel currentPanel = this.splashPanel1;
			int interval = 5000;

			if(this.splashPanel1Selected.Checked == true)
				currentPanel = this.splashPanel1;
			else if(this.splashPanel2Selected.Checked == true)
				currentPanel = this.splashPanel2;
			else if(this.splashPanel3Selected.Checked == true)
				currentPanel = this.splashPanel3;
			else if(this.splashPanel4Selected.Checked == true)
				currentPanel = this.splashPanel4;

			if(IsNumber(this.timerInterval.Text) == true)
				interval = Int32.Parse(this.timerInterval.Text);


			currentPanel.DesktopAlignment = GetDesktopAlignment();
			currentPanel.TimerInterval = interval;
			currentPanel.AnimationSpeed = this.trackBar1.Value;
	
			if(currentPanel.DesktopAlignment == SplashAlignment.Custom)
				pt = Control.MousePosition;

			currentPanel.ShowSplash(pt, this, isModal);
		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			MainForm frmMain = new MainForm();
			Application.Run(frmMain);
		}
		#region ShowSplash
		private void button1_Click(object sender, System.EventArgs e)
		{
			this.ShowSplash(false);
		}
		#endregion
		#region DemoCommon.AboutForm
		private void menuItem4_Click(object sender, System.EventArgs e)
		{	
			DemoCommon.AboutForm ab=new DemoCommon.AboutForm( AppDomain.CurrentDomain.GetAssemblies());
			ab.ShowDialog();
		}
		#endregion

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#region BeforeSplash
		private void splashPanel1_BeforeSplash(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "BeforeSplash", ((Control)sender).Name);
			textBox1.Text = textBox1.Text + eventlogmessage;
		}
		#endregion
		#region SplashDisplayed

		private void splashPanel1_SplashDisplayed(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashDisplayed", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                textBox1.Text = textBox1.Text + eventlogmessage;
            }
		}

		#endregion
		#region Method

        private void OutputText(string text)
        {
            textBox1.Text = textBox1.Text + text;
        }

		#endregion
		#region splashPanel1_SplashClosing
		private void splashPanel1_SplashClosing(object sender, Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs args)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashClosing", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

			if(this.Controls.Contains(this.splashPanel1) == false)
				this.Controls.Add(this.splashPanel1);
			this.splashPanel1.Location = this.currentPt1;
			this.splashPanel1.Visible = true;
		}
		#endregion
		#region splashPanel3_SplashClosing
		private void splashPanel3_SplashClosing(object sender, Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs args)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashClosing", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

			if(this.Controls.Contains(this.splashPanel3) == false)
				this.Controls.Add(this.splashPanel3);
			this.splashPanel3.Location = this.currentPt3;
			this.splashPanel3.Visible = true;
		}
		#endregion
		#region splashPanel4_SplashClosing
		private void splashPanel4_SplashClosing(object sender, Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs args)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashClosing", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

			if(this.Controls.Contains(this.splashPanel4) == false)
				this.Controls.Add(this.splashPanel4);
			this.splashPanel4.Location = this.currentPt4;
			this.splashPanel4.Visible = true;
		}
		#endregion
		#region MainForm_Load

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			this.currentPt1 = this.splashPanel1.Location;
			this.splashPanel1.Visible = true;
			this.currentPt2 = this.splashPanel2.Location;
			this.splashPanel2.Visible = true;
			this.currentPt3 = this.splashPanel3.Location;
			this.splashPanel3.Visible = true;
			this.currentPt4 = this.splashPanel4.Location;
			this.splashPanel4.Visible = true;
		}
		#endregion
		#region splashPanel2_SplashClosing

		private void splashPanel2_SplashClosing(object sender, Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs args)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashClosing", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

			this.splashPanel2.Location = this.currentPt2;
			this.splashPanel2.Visible = true;
			if(this.Controls.Contains(this.splashPanel2) == false)
				this.Controls.Add(this.splashPanel2);
		}
		#endregion
		#region codegen

		protected void CodeGen_InitializeComponent()
		{
			// InitializeComponent
			// <samplecodeblock name="SplashPanel InitializeComponent">

			// Create the splash panel
			this.splashPanel1 = new SplashPanel();

			// The animation speed
			this.splashPanel1.AnimationSpeed = 10;

			// The background 
			this.splashPanel1.BackgroundColor = new BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.HighlightText, System.Drawing.SystemColors.Highlight);
			
			// The border style
			this.splashPanel1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;

			// The child controls - added through the designer
			this.splashPanel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					   this.linkLabel1});
			// The startup location for the splash panel
			this.splashPanel1.DesktopAlignment = SplashAlignment.SystemTray;

			// Specifies whether the window should appear animated
			this.splashPanel1.ShowAnimation = true;

			// The interval for which the panel is to be displayed
			this.splashPanel1.TimerInterval = 5000;

			//</samplecodeblock>
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CodeGen_button1_Click(object sender, System.EventArgs e)
		{
			this.splashPanel1.ShowSplash(Point.Empty, this, false);
		}

		private void CodeGen_splashPanel1_SplashClosing(object sender, Syncfusion.Windows.Forms.Tools.SplashClosedEventArgs args)
		{
			// <samplecodeblock name="SplashPanel SplashClosing event">
			this.splashPanel1.SplashClosed += new Syncfusion.Windows.Forms.Tools.SplashClosedEventHandler(this.splashPanel1_SplashClosing);

			// splashPanel1_SplashClosing event handler
			MessageBox.Show("SplashPanel closing event handler");
			//</samplecodeblock>
		}
		#endregion
		#region ShowSplash

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.ShowSplash(true);
		}
		#endregion
		#region splashPanel2_BeforeSplash
		private void splashPanel2_BeforeSplash(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "BeforeSplash", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

		}
		#endregion
		#region splashPanel2_SplashDisplayed

		private void splashPanel2_SplashDisplayed(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashDisplayed", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

		}
		#endregion
		#region HideSplash

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.splashPanel3.HideSplash();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
		this.splashPanel4.HideSplash();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.splashPanel2.HideSplash();
		}
		#endregion
		#region SplashMouseEnter
		private void splashPanel2_SplashMouseEnter(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashMouseEnter", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

		}
		#endregion
		#region splashPanel2_SplashMouseLeave
		private void splashPanel2_SplashMouseLeave(object sender, System.EventArgs e)
		{
			string eventlogmessage = String.Format("Event: {0} Object: {1}\r\n", "SplashMouseLeave", ((Control)sender).Name);
            if (this.InvokeRequired)
            {
                this.Invoke(new SetStringDelegate(OutputText), new object[] { eventlogmessage });
            }
            else
            {
                OutputText(eventlogmessage);
            }

		}
		#endregion

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			this.textBox1.SelectionStart = this.textBox1.Text.Length - 1;
			this.textBox1.ScrollToCaret();

		}
	}
}
