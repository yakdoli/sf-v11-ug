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

namespace ButtonEditDemo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Tools;
	using Syncfusion.Windows.Forms;

	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ErrorProvider errorProvider1;

		private Hashtable hashLabelNames;

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;

		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox4;
        private ButtonEdit buttonEdit1;
        private ButtonEditChildButton buttonEditChildButton1;
        private TextBoxExt textBoxExt1;
        private ButtonEdit buttonEdit3;
        private ButtonEditChildButton buttonEditChildButton3;
        private TextBoxExt textBoxExt3;
        private ButtonEdit buttonEdit2;
        private ButtonEditChildButton buttonEditChildButton2;
        private TextBoxExt textBoxExt2;
        private ButtonEdit buttonEdit7;
        private ButtonEditChildButton buttonEditChildButton13;
        private ButtonEditChildButton buttonEditChildButton14;
        private ButtonEditChildButton buttonEditChildButton15;
        private ButtonEditChildButton buttonEditChildButton16;
        private TextBoxExt textBoxExt7;
        private ButtonEdit buttonEdit6;
        private ButtonEditChildButton buttonEditChildButton10;
        private ButtonEditChildButton buttonEditChildButton11;
        private ButtonEditChildButton buttonEditChildButton12;
        private TextBoxExt textBoxExt6;
        private ButtonEdit buttonEdit5;
        private ButtonEditChildButton buttonEditChildButton7;
        private ButtonEditChildButton buttonEditChildButton8;
        private ButtonEditChildButton buttonEditChildButton9;
        private TextBoxExt textBoxExt5;
        private ButtonEdit buttonEdit4;
        private ButtonEditChildButton buttonEditChildButton4;
        private ButtonEditChildButton buttonEditChildButton5;
        private ButtonEditChildButton buttonEditChildButton6;
        private TextBoxExt textBoxExt4;
		private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			hashLabelNames = new Hashtable();
			this.popupControlContainer1.ParentControl = this.buttonEdit3.TextBox;
			this.popupControlContainer1.PopupParent = this.buttonEdit3;
			this.buttonEdit3.TextBox.HandleDestroyed += new EventHandler(this.DropDownParentTextBoxDestroyed);
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

		private void DropDownParentTextBoxDestroyed(object sender, EventArgs args)
		{
			if(popupControlContainer1 != null)
				this.popupControlContainer1.ParentControl = null;
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEdit2 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonEdit7 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton13 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton14 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton15 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton16 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt7 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonEdit6 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton10 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton11 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton12 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt6 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonEdit5 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton7 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton8 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton9 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt5 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.buttonEdit4 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton5 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEditChildButton6 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt4 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).BeginInit();
            this.buttonEdit2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            this.popupControlContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit7)).BeginInit();
            this.buttonEdit7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).BeginInit();
            this.buttonEdit6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).BeginInit();
            this.buttonEdit5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).BeginInit();
            this.buttonEdit4.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.groupBox1.Controls.Add(this.buttonEdit2);
            this.groupBox1.Location = new System.Drawing.Point(16, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FolderBrowser";
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit2.Buttons.Add(this.buttonEditChildButton2);
            this.buttonEdit2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit2.Controls.Add(this.buttonEditChildButton2);
            this.buttonEdit2.Controls.Add(this.textBoxExt2);
            this.buttonEdit2.Location = new System.Drawing.Point(72, 14);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Size = new System.Drawing.Size(121, 21);
            this.buttonEdit2.TabIndex = 0;
            this.buttonEdit2.TextBox = this.textBoxExt2;
            this.buttonEdit2.UseVisualStyle = true;
            this.buttonEdit2.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton2.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton2.Image")));
            this.buttonEditChildButton2.ImageIndex = 7;
            this.buttonEditChildButton2.ImageList = this.imageList1;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 18;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "buttonEditChildButton2";
            this.buttonEditChildButton2.Click += new System.EventHandler(this.buttonEditChildButton2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(99, 13);
            this.textBoxExt2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.groupBox2.Controls.Add(this.buttonEdit1);
            this.groupBox2.Location = new System.Drawing.Point(16, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 48);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FileBrowser";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton1);
            this.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton1);
            this.buttonEdit1.Controls.Add(this.textBoxExt1);
            this.buttonEdit1.Location = new System.Drawing.Point(72, 14);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(121, 21);
            this.buttonEdit1.TabIndex = 0;
            this.buttonEdit1.TextBox = this.textBoxExt1;
            this.buttonEdit1.UseVisualStyle = true;
            this.buttonEdit1.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton1.Image")));
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Click += new System.EventHandler(this.buttonEditChildButton1_Click);
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(99, 13);
            this.textBoxExt1.TabIndex = 0;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.gradientLabel1);
            this.popupControlContainer1.Location = new System.Drawing.Point(552, 16);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(240, 200);
            this.popupControlContainer1.TabIndex = 12;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.SystemColors.ActiveCaption);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top)
                        | System.Windows.Forms.Border3DSide.Right)
                        | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(0, 0);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(240, 200);
            this.gradientLabel1.TabIndex = 0;
            this.gradientLabel1.Text = "Syncfusion";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gradientLabel1.Click += new System.EventHandler(this.gradientLabel1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.groupBox5.Controls.Add(this.buttonEdit3);
            this.groupBox5.Location = new System.Drawing.Point(16, 208);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(264, 56);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DropDown";
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit3.Buttons.Add(this.buttonEditChildButton3);
            this.buttonEdit3.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit3.Controls.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Controls.Add(this.textBoxExt3);
            this.buttonEdit3.Location = new System.Drawing.Point(74, 20);
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.Size = new System.Drawing.Size(121, 21);
            this.buttonEdit3.TabIndex = 0;
            this.buttonEdit3.TextBox = this.textBoxExt3;
            this.buttonEdit3.UseVisualStyle = true;
            this.buttonEdit3.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton3.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton3.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton3.Image")));
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 18;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Click += new System.EventHandler(this.buttonEditChildButton3_Click);
            // 
            // textBoxExt3
            // 
            this.textBoxExt3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt3.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt3.Name = "textBoxExt3";
            this.textBoxExt3.OverflowIndicatorToolTipText = null;
            this.textBoxExt3.Size = new System.Drawing.Size(99, 13);
            this.textBoxExt3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(288, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 336);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "EventLog";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 16);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(240, 312);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(552, 374);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.popupControlContainer1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(544, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DropDowns";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(544, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ButtonTypes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonEdit7);
            this.groupBox4.Controls.Add(this.buttonEdit6);
            this.groupBox4.Controls.Add(this.buttonEdit5);
            this.groupBox4.Controls.Add(this.buttonEdit4);
            this.groupBox4.Location = new System.Drawing.Point(48, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 216);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ButtonTypes";
            // 
            // buttonEdit7
            // 
            this.buttonEdit7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton13);
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton14);
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton15);
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton16);
            this.buttonEdit7.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton16);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton15);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton14);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton13);
            this.buttonEdit7.Controls.Add(this.textBoxExt7);
            this.buttonEdit7.Location = new System.Drawing.Point(269, 123);
            this.buttonEdit7.Name = "buttonEdit7";
            this.buttonEdit7.ShowTextBox = false;
            this.buttonEdit7.Size = new System.Drawing.Size(121, 21);
            this.buttonEdit7.TabIndex = 3;
            this.buttonEdit7.TextBox = this.textBoxExt7;
            this.buttonEdit7.UseVisualStyle = true;
            // 
            // buttonEditChildButton13
            // 
            this.buttonEditChildButton13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton13.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.LeftEnd;
            this.buttonEditChildButton13.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton13.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton13.Image")));
            this.buttonEditChildButton13.Name = "buttonEditChildButton13";
            this.buttonEditChildButton13.PreferredWidth = 18;
            this.buttonEditChildButton13.TabIndex = 1;
            // 
            // buttonEditChildButton14
            // 
            this.buttonEditChildButton14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton14.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.RightEnd;
            this.buttonEditChildButton14.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton14.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton14.Image")));
            this.buttonEditChildButton14.Name = "buttonEditChildButton14";
            this.buttonEditChildButton14.PreferredWidth = 18;
            this.buttonEditChildButton14.TabIndex = 2;
            // 
            // buttonEditChildButton15
            // 
            this.buttonEditChildButton15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton15.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo;
            this.buttonEditChildButton15.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton15.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton15.Image")));
            this.buttonEditChildButton15.Name = "buttonEditChildButton15";
            this.buttonEditChildButton15.PreferredWidth = 18;
            this.buttonEditChildButton15.TabIndex = 3;
            // 
            // buttonEditChildButton16
            // 
            this.buttonEditChildButton16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton16.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Undo;
            this.buttonEditChildButton16.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton16.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton16.Image")));
            this.buttonEditChildButton16.Name = "buttonEditChildButton16";
            this.buttonEditChildButton16.PreferredWidth = 18;
            this.buttonEditChildButton16.TabIndex = 4;
            // 
            // textBoxExt7
            // 
            this.textBoxExt7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt7.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt7.Name = "textBoxExt7";
            this.textBoxExt7.OverflowIndicatorToolTipText = null;
            this.textBoxExt7.Size = new System.Drawing.Size(45, 13);
            this.textBoxExt7.TabIndex = 0;
            this.textBoxExt7.Text = "buttonEdit7";
            // 
            // buttonEdit6
            // 
            this.buttonEdit6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton10);
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton11);
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton12);
            this.buttonEdit6.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton12);
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton11);
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton10);
            this.buttonEdit6.Controls.Add(this.textBoxExt6);
            this.buttonEdit6.Location = new System.Drawing.Point(34, 123);
            this.buttonEdit6.Name = "buttonEdit6";
            this.buttonEdit6.ShowTextBox = false;
            this.buttonEdit6.Size = new System.Drawing.Size(121, 21);
            this.buttonEdit6.TabIndex = 2;
            this.buttonEdit6.TextBox = this.textBoxExt6;
            this.buttonEdit6.UseVisualStyle = true;
            // 
            // buttonEditChildButton10
            // 
            this.buttonEditChildButton10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton10.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Left;
            this.buttonEditChildButton10.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton10.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton10.Image")));
            this.buttonEditChildButton10.Name = "buttonEditChildButton10";
            this.buttonEditChildButton10.PreferredWidth = 18;
            this.buttonEditChildButton10.TabIndex = 1;
            // 
            // buttonEditChildButton11
            // 
            this.buttonEditChildButton11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton11.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Right;
            this.buttonEditChildButton11.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton11.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton11.Image")));
            this.buttonEditChildButton11.Name = "buttonEditChildButton11";
            this.buttonEditChildButton11.PreferredWidth = 18;
            this.buttonEditChildButton11.TabIndex = 2;
            // 
            // buttonEditChildButton12
            // 
            this.buttonEditChildButton12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton12.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.buttonEditChildButton12.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton12.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton12.Image")));
            this.buttonEditChildButton12.Name = "buttonEditChildButton12";
            this.buttonEditChildButton12.PreferredWidth = 18;
            this.buttonEditChildButton12.TabIndex = 3;
            // 
            // textBoxExt6
            // 
            this.textBoxExt6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt6.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt6.Name = "textBoxExt6";
            this.textBoxExt6.OverflowIndicatorToolTipText = null;
            this.textBoxExt6.Size = new System.Drawing.Size(63, 13);
            this.textBoxExt6.TabIndex = 0;
            this.textBoxExt6.Text = "buttonEdit6";
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton7);
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton8);
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton9);
            this.buttonEdit5.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton9);
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton8);
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton7);
            this.buttonEdit5.Controls.Add(this.textBoxExt5);
            this.buttonEdit5.Location = new System.Drawing.Point(267, 57);
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.ShowTextBox = false;
            this.buttonEdit5.Size = new System.Drawing.Size(121, 21);
            this.buttonEdit5.TabIndex = 1;
            this.buttonEdit5.TextBox = this.textBoxExt5;
            this.buttonEdit5.UseVisualStyle = true;
            // 
            // buttonEditChildButton7
            // 
            this.buttonEditChildButton7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton7.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton7.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton7.Image")));
            this.buttonEditChildButton7.ImageIndex = 1;
            this.buttonEditChildButton7.ImageList = this.imageList1;
            this.buttonEditChildButton7.Name = "buttonEditChildButton7";
            this.buttonEditChildButton7.PreferredWidth = 18;
            this.buttonEditChildButton7.TabIndex = 1;
            this.buttonEditChildButton7.Text = "buttonEditChildButton7";
            // 
            // buttonEditChildButton8
            // 
            this.buttonEditChildButton8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton8.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton8.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton8.Image")));
            this.buttonEditChildButton8.ImageIndex = 2;
            this.buttonEditChildButton8.ImageList = this.imageList1;
            this.buttonEditChildButton8.Name = "buttonEditChildButton8";
            this.buttonEditChildButton8.PreferredWidth = 18;
            this.buttonEditChildButton8.TabIndex = 2;
            this.buttonEditChildButton8.Text = "buttonEditChildButton8";
            // 
            // buttonEditChildButton9
            // 
            this.buttonEditChildButton9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton9.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton9.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton9.Image")));
            this.buttonEditChildButton9.ImageIndex = 3;
            this.buttonEditChildButton9.ImageList = this.imageList1;
            this.buttonEditChildButton9.Name = "buttonEditChildButton9";
            this.buttonEditChildButton9.PreferredWidth = 18;
            this.buttonEditChildButton9.TabIndex = 3;
            this.buttonEditChildButton9.Text = "buttonEditChildButton9";
            // 
            // textBoxExt5
            // 
            this.textBoxExt5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt5.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt5.Name = "textBoxExt5";
            this.textBoxExt5.OverflowIndicatorToolTipText = null;
            this.textBoxExt5.Size = new System.Drawing.Size(63, 13);
            this.textBoxExt5.TabIndex = 0;
            this.textBoxExt5.Text = "buttonEdit5";
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton5);
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton6);
            this.buttonEdit4.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton6);
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton5);
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Controls.Add(this.textBoxExt4);
            this.buttonEdit4.Location = new System.Drawing.Point(34, 57);
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.ShowTextBox = false;
            this.buttonEdit4.Size = new System.Drawing.Size(121, 21);
            this.buttonEdit4.TabIndex = 0;
            this.buttonEdit4.TextBox = this.textBoxExt4;
            this.buttonEdit4.UseVisualStyle = true;
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton4.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton4.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton4.Image")));
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 18;
            this.buttonEditChildButton4.TabIndex = 1;
            // 
            // buttonEditChildButton5
            // 
            this.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton5.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Up;
            this.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton5.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton5.Image")));
            this.buttonEditChildButton5.Name = "buttonEditChildButton5";
            this.buttonEditChildButton5.PreferredWidth = 18;
            this.buttonEditChildButton5.TabIndex = 2;
            // 
            // buttonEditChildButton6
            // 
            this.buttonEditChildButton6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton6.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Currency;
            this.buttonEditChildButton6.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton6.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditChildButton6.Image")));
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 3;
            // 
            // textBoxExt4
            // 
            this.textBoxExt4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt4.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt4.Name = "textBoxExt4";
            this.textBoxExt4.OverflowIndicatorToolTipText = null;
            this.textBoxExt4.Size = new System.Drawing.Size(63, 13);
            this.textBoxExt4.TabIndex = 0;
            this.textBoxExt4.Text = "buttonEdit4";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(552, 374);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Button Edit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).EndInit();
            this.buttonEdit2.ResumeLayout(false);
            this.buttonEdit2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            this.popupControlContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit7)).EndInit();
            this.buttonEdit7.ResumeLayout(false);
            this.buttonEdit7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).EndInit();
            this.buttonEdit6.ResumeLayout(false);
            this.buttonEdit6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).EndInit();
            this.buttonEdit5.ResumeLayout(false);
            this.buttonEdit5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).EndInit();
            this.buttonEdit4.ResumeLayout(false);
            this.buttonEdit4.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			Application.Run(new MainForm());
		}

		

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		#region File
		public void buttonEditChildButton1_Click(object sender, System.EventArgs e)
		{
			//<samplecodeblock name="ButtonEdit ChildButtonClick">
			//buttonEditChildButton1_Click
			OpenFileDialog dlg = new OpenFileDialog(); 
			dlg.Title = "Open file" ; 
			dlg.InitialDirectory = "c:\\" ; 
			dlg.Filter = "All files (*.*)|*.*" ; 
          
			if(dlg.ShowDialog() == DialogResult.OK)  
				this.buttonEdit1.TextBox.Text = dlg.FileName; 
			//</samplecodeblock>
		}
		#endregion

		#region Folder
		private void buttonEditChildButton2_Click(object sender, System.EventArgs e)
		{
			FolderBrowser browse = new FolderBrowser();
			browse.FolderBrowserCallback += new FolderBrowserCallbackEventHandler(buttonEditChildButton2_Browsed);
			browse.ShowDialog(this);
		}
		#endregion

		#region buttonEditChildButton2_Browsed
		private void buttonEditChildButton2_Browsed(object sender, FolderBrowserCallbackEventArgs e)
		{
			this.buttonEdit2.TextBox.Text = e.Path;
		}
		#endregion
		#region ShowpopUp

		private void buttonEditChildButton3_Click(object sender, System.EventArgs e)
		{
			if(this.popupControlContainer1.IsShowing() == true)
			{
				this.popupControlContainer1.HidePopup(PopupCloseType.Done);
			}
			else
			{
				this.popupControlContainer1.PopupParent = this.buttonEdit3;
				this.popupControlContainer1.ShowPopup(Point.Empty);
			}
		}
		#endregion

		#region samplecodeblock
		private void CodeGen_InitializeComponent()
		{
			//<samplecodeblock name="ButtonEdit InitializeComponent">
			// InitializeComponent sample
			this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();

			this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
			this.buttonEdit1.SuspendLayout();
			this.SuspendLayout();

			this.buttonEdit1.Buttons.Add(this.buttonEditChildButton1);
			this.buttonEdit1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					  this.buttonEditChildButton1});
			this.buttonEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit1.Location = new System.Drawing.Point(8, 16);
			this.buttonEdit1.Name = "buttonEdit1";
			this.buttonEdit1.SelectionLength = 0;
			this.buttonEdit1.SelectionStart = 0;
			this.buttonEdit1.ShowTextBox = true;
			this.buttonEdit1.Size = new System.Drawing.Size(368, 22);
			this.buttonEdit1.TabIndex = 0;
			this.buttonEdit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// buttonEditChildButton1
			// 
			this.buttonEditChildButton1.ButtonAlign = Syncfusion.Windows.Forms.Tools.ButtonAlignment.Right;
			this.buttonEditChildButton1.ButtonEditParent = this.buttonEdit1;
			this.buttonEditChildButton1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
			this.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditChildButton1.Name = "buttonEditChildButton1";
			this.buttonEditChildButton1.PreferredWidth = 16;
			this.buttonEditChildButton1.TabIndex = 1;
			this.buttonEditChildButton1.Click += new System.EventHandler(this.buttonEditChildButton1_Click);
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(400, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {	  this.buttonEdit1});
			this.Text = "Syncfusion ButtonEdit Demo";
			this.buttonEdit1.ResumeLayout(false);
			this.ResumeLayout(false);
			//</samplecodeblock>
		}
		#endregion

        #region buttonEdit1_ButtonClicked
		private void buttonEdit1_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
		{
			string item = args.ClickedButton.Name;
			string eventlogmessage = String.Format("Event: {0} Item: {1}\r\n", "ButtonClicked", item);
			textBox2.Text = textBox2.Text + eventlogmessage;
		}
		#endregion

		private void MainForm_Load(object sender, System.EventArgs e)
		{
		
		}

		private void gradientLabel1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void textBox2_TextChanged(object sender, System.EventArgs e)
		{

        }
	}
}
