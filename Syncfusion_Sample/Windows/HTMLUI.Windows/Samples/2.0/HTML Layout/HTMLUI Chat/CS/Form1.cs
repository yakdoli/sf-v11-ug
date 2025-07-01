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
using System.IO;
using System.Xml;
using System.Reflection;

using Syncfusion.Windows.Forms.HTMLUI;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		#region ClassSummaryDescription
		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;

		BaseElement table1 = null;

		private const string DEF_IMG_SMILE = "<img id='smile' src='..\\..\\smile.gif'>";
		private const string DEF_IMG_SAD = "<img id='sad' src='..\\..\\sad.gif'>";
		private const string DEF_IMG_LAUGH = "<img id='laugh' src='..\\..\\laugh.gif'>";
		private const string DEF_IMG_WAVE = "<img id='wave' src='..\\..\\wave.gif'>";
		private const string DEF_SMILE = ":-)";
		private const string DEF_SAD = ":-(";
		private const string DEF_LAUGH = ":))";
		private const string DEF_WAVE = ":-h";

		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.ComponentModel.IContainer components;
		#endregion

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
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.button7 = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel7 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(309, 297);
			this.htmluiControl1.ContextMenu = this.contextMenu1;
			this.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Location = new System.Drawing.Point(0, 0);
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.ShowTitle = false;
			this.htmluiControl1.Size = new System.Drawing.Size(336, 312);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=66, Height=15}\" xlocation=\"{X=10,Y=15}\">htmluiControl1</bo" +
				"dy></html>";
			this.toolTip1.SetToolTip(this.htmluiControl1, "HTMLUI Control");
			this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																								 this.menuItem9});
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Text = "Copy";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(229)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.panel1.Controls.Add(this.panel8);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 312);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(336, 136);
			this.panel1.TabIndex = 1;
			// 
			// panel8
			// 
			this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel8.BackColor = System.Drawing.Color.White;
			this.panel8.Controls.Add(this.button6);
			this.panel8.Controls.Add(this.button1);
			this.panel8.Controls.Add(this.textBox1);
			this.panel8.Location = new System.Drawing.Point(8, 40);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(312, 88);
			this.panel8.TabIndex = 6;
			// 
			// button6
			// 
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.button6.BackColor = System.Drawing.Color.LightCyan;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.Location = new System.Drawing.Point(256, 56);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(48, 17);
			this.button6.TabIndex = 2;
			this.button6.Text = "Search";
			this.toolTip1.SetToolTip(this.button6, "Search for text");
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.button1.BackColor = System.Drawing.Color.LightCyan;
			this.button1.Enabled = false;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(256, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 48);
			this.button1.TabIndex = 1;
			this.button1.Text = "Send";
			this.toolTip1.SetToolTip(this.button1, "Send Message");
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.textBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(177)));
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(256, 88);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button5.BackColor = System.Drawing.Color.LightCyan;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(152, 8);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(32, 24);
			this.button5.TabIndex = 5;
			this.toolTip1.SetToolTip(this.button5, "Cry");
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button4.BackColor = System.Drawing.Color.LightCyan;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(104, 8);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(32, 24);
			this.button4.TabIndex = 4;
			this.toolTip1.SetToolTip(this.button4, "bye");
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.BackColor = System.Drawing.Color.LightCyan;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(56, 8);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(32, 24);
			this.button3.TabIndex = 3;
			this.toolTip1.SetToolTip(this.button3, "broad smile");
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.BackColor = System.Drawing.Color.LightCyan;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(8, 8);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 24);
			this.button2.TabIndex = 2;
			this.toolTip1.SetToolTip(this.button2, "smile");
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(229)), ((System.Byte)(245)));
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.panel6);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.panel2.Location = new System.Drawing.Point(336, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(128, 446);
			this.panel2.TabIndex = 2;
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.Color.AliceBlue;
			this.panel6.Controls.Add(this.button7);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Location = new System.Drawing.Point(8, 312);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(112, 120);
			this.panel6.TabIndex = 1;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.AliceBlue;
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button7.ForeColor = System.Drawing.Color.AliceBlue;
			this.button7.ImageIndex = 5;
			this.button7.ImageList = this.imageList1;
			this.button7.Location = new System.Drawing.Point(72, 104);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(32, 15);
			this.button7.TabIndex = 1;
			this.button7.Text = "...";
			this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolTip1.SetToolTip(this.button7, "Change the display picture");
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(15, 15);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.White;
			this.panel7.Controls.Add(this.pictureBox2);
			this.panel7.ForeColor = System.Drawing.Color.Honeydew;
			this.panel7.Location = new System.Drawing.Point(8, 8);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(96, 96);
			this.panel7.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(96, 96);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.Color.AliceBlue;
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Location = new System.Drawing.Point(8, 16);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(112, 120);
			this.panel4.TabIndex = 0;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.White;
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.ForeColor = System.Drawing.Color.Honeydew;
			this.panel5.Location = new System.Drawing.Point(8, 8);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(96, 96);
			this.panel5.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(96, 96);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.htmluiControl1);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(336, 312);
			this.panel3.TabIndex = 3;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem1,
																																							this.menuItem6});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem2,
																																							this.menuItem3,
																																							this.menuItem4,
																																							this.menuItem5});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "New Chat Window";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Save this conversation";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "Open old conversation";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "Exit";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 1;
			this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																																							this.menuItem7,
																																							this.menuItem8});
			this.menuItem6.Text = "Options";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 0;
			this.menuItem7.Text = "Change display picture";
			this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 1;
			this.menuItem8.Text = "ChangeBackGround";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "Conversation1";
			this.saveFileDialog1.Title = "Save the conversation";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.CheckFileExists = false;
			this.openFileDialog1.CheckPathExists = false;
			this.openFileDialog1.RestoreDirectory = true;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(464, 446);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "HTMLUI Chat";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
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

		#region ApplicationEvents
		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			WireElements();
		}


		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.htmluiControl1.LoadFromString("");
			LoadHTMLFile(@"chat.htm");
			this.pictureBox1.Image = Image.FromFile(GetLocation()+@"\clouds.jpg");
			this.pictureBox2.Image = Image.FromFile(GetLocation()+@"\clouds.jpg");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			SendContents();
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(this.textBox1.Text != String.Empty)
			{
				this.button1.Enabled = true;
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
            this.textBox1.Text += ":-)";
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text += ":))";
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text += ":-h";
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text += ":-(";
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				SendContents();
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Form form = new Form1();
			form.Show();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.saveFileDialog1.Filter = "xml files|*.xml";
			this.openFileDialog1.InitialDirectory = Directory.CreateDirectory(@"..\..\").FullName.ToString();
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.htmluiControl1.Document.Document.Save(saveFileDialog1.FileName);
			}
			Console.WriteLine("Conversation saved.");
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			this.openFileDialog1.Filter = "xml files|*.xml";
			this.openFileDialog1.InitialDirectory = Directory.CreateDirectory(@"..\..\").FullName.ToString();
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				XmlDocument document = new XmlDocument();
				document.Load(openFileDialog1.FileName);
				string outerXML = document.FirstChild.OuterXml.ToString();
				this.htmluiControl1.LoadFromString(ReplaceImage(outerXML));
			}
			Console.WriteLine("Conversation opened.");
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{
			this.ChangeDisplayPicture();
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			this.ChangeDisplayPicture();
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			this.htmluiControl1.DisplayFindForm();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			ChangeBackGroundPicture();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			string str = this.htmluiControl1.SelectedText.ToString();
			if(str != "")
			{
				Clipboard.SetDataObject(str, true);
			}
		}
		#endregion

		#region ClassHelperMethods
		private void ChangeDisplayPicture()
		{
			this.openFileDialog1.Filter = "Bmp files|*.bmp|Jpg files|*.jpg|Gif files|*.gif";
			this.openFileDialog1.InitialDirectory = Directory.CreateDirectory(@"..\..\").FullName.ToString();
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.pictureBox2.Image = Image.FromFile(this.openFileDialog1.FileName.ToString());
			}
		}

		private string ReplaceImage(string OuterXML)
		{
			this.htmluiControl1.LoadFromString(OuterXML);
			IHTMLElement[] element = this.htmluiControl1.Document.GetElementsByName("body");
			IHTMLElementsCollection collection = element[0].Children;

			foreach(IHTMLElement elem in collection)
			{
				WriteElement(elem);
			}
			return this.htmluiControl1.Document.Document.OuterXml;
		}

		private void WriteElement(IHTMLElement elem)
		{
			if(elem.ID == "smile")
			{
				Console.WriteLine(elem.Attributes["src"].Value.ToString());
				elem.Attributes["src"].Value = GetLocation() + @"\smile.gif";
			}

			else if(elem.ID == "sad")
			{
				elem.Attributes["src"].Value = GetLocation() + @"\sad.gif";
			}

			else if(elem.ID == "laugh")
			{
				elem.Attributes["src"].Value = GetLocation() + @"\laugh.gif";
			}

			else if(elem.ID == "wave")
			{
				elem.Attributes["src"].Value = GetLocation() + @"\wave.gif";
			}

			if(elem.Children.Count != 0)
			{
				IHTMLElementsCollection newParent = elem.Children;
				foreach(IHTMLElement smallChild in newParent)
				{
					WriteElement(smallChild);
				}
			}
		}

		private string GetLocation()
		{
			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			if(slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			path = path+"\\files";
			return path;
		}

		private void WireElements()
		{
			Hashtable htmlelements = this.htmluiControl1.Document.GetElementsByUserIdHash();
			this.table1 = htmlelements["Table1"] as BaseElement;
		}

		private void LoadHTMLFile(string fileName)
		{
			string path;
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase );
			int slashPos = path.LastIndexOf("\\",path.Length);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			slashPos = path.LastIndexOf("\\",slashPos-1);
			if(slashPos > 0)
				path = path.Substring(0,slashPos);
			path = path.Replace("file:\\", "");
			this.htmluiControl1.StartupDocument = System.IO.Path.Combine(path+"//files", fileName);	
		}

		private void SendContents()
		{
			if(this.textBox1.Text != String.Empty)
			{
				AddToDisplay(this.textBox1.Text);
				this.textBox1.Clear();
				this.button1.Enabled = false;
			}
		}

		private void AddToDisplay(string newText)
		{
			//Replace the text with the smileys
			newText = newText.Replace(DEF_SMILE, DEF_IMG_SMILE);
			newText = newText.Replace(DEF_LAUGH, DEF_IMG_LAUGH);
			newText = newText.Replace(DEF_WAVE, DEF_IMG_WAVE);
			newText = newText.Replace(DEF_SAD, DEF_IMG_SAD);

			newText = newText.Replace("\r\n", "<br \\>" );

			// Create a new row and insert the text
			this.table1.InnerHTML += "<tr><td class=\"date\">" + DateTime.Now.ToString() +"</td></tr><tr><td class=\"message\">" + newText +"<p/></td></tr>";
			ScrollToEnd();
		}

		private void ChangeBackGroundPicture()
		{
			this.openFileDialog1.Filter = "Bmp files|*.bmp|Jpg files|*.jpg|Gif files|*.gif";
			this.openFileDialog1.InitialDirectory = Directory.CreateDirectory(@"..\..\").FullName.ToString();
			if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				this.panel1.BackgroundImage = Image.FromFile(this.openFileDialog1.FileName.ToString());
				this.panel2.BackgroundImage = Image.FromFile(this.openFileDialog1.FileName.ToString());
			}
		}

		private void ScrollToEnd()
		{
			Point lastPoint = new Point(this.table1.Location.X + this.table1.Size.Width, this.table1.Location.Y + this.table1.Size.Height);
            Rectangle rect = new Rectangle(new Point(lastPoint.X-10, lastPoint.Y-10), new Size(10,10));
			this.htmluiControl1.ScrollToRectangle(rect, this.htmluiControl1.Document);
		}
		#endregion
	}
}
