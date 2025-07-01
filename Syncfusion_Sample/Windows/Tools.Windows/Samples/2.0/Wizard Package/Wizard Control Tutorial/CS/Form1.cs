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

namespace WizardControlTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Tools.WizardControl wizardControl1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
		private Syncfusion.Windows.Forms.Tools.WizardContainer wizardContainer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Timer timer1;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage frontPage;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage provideInfoPage;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage uploadPage;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage uploadLaterPage;
		private Syncfusion.Windows.Forms.Tools.WizardControlPage finishPage;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label13;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.wizardControl1.GridBagLayout.GetConstraintsRef(this.wizardControl1.NextButton).Insets = new Insets(5, 0, 0, 0);

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.wizardControl1 = new Syncfusion.Windows.Forms.Tools.WizardControl();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.wizardContainer1 = new Syncfusion.Windows.Forms.Tools.WizardContainer();
			this.frontPage = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.provideInfoPage = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.uploadLaterPage = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
			this.label9 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.finishPage = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
			this.label10 = new System.Windows.Forms.Label();
			this.uploadPage = new Syncfusion.Windows.Forms.Tools.WizardControlPage(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label13 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wizardControl1.GridBagLayout)).BeginInit();
			this.wizardControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
			this.gradientPanel1.SuspendLayout();
			this.wizardContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.frontPage)).BeginInit();
			this.frontPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.provideInfoPage)).BeginInit();
			this.provideInfoPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uploadLaterPage)).BeginInit();
			this.uploadLaterPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.finishPage)).BeginInit();
			this.finishPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uploadPage)).BeginInit();
			this.uploadPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// wizardControl1
			// 
			// 
			// wizardControl1.BackButton
			// 
			this.wizardControl1.BackButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.wizardControl1.BackButton.Location = new System.Drawing.Point(192, 386);
			this.wizardControl1.BackButton.Name = "backButton";
			this.wizardControl1.BackButton.Text = "<< Back";
			this.wizardControl1.BackButton.Visible = false;
			this.wizardControl1.Banner = this.pictureBox1;
			this.wizardControl1.BannerPanel = this.gradientPanel1;
			// 
			// wizardControl1.CancelButton
			// 
			this.wizardControl1.CancelButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.wizardControl1.CancelButton.Location = new System.Drawing.Point(432, 386);
			this.wizardControl1.CancelButton.Name = "cancelButton";
			this.wizardControl1.CancelButton.Text = "Cancel";
			this.wizardControl1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.wizardContainer1,
																						 this.wizardControl1.HelpButton,
																						 this.wizardControl1.CancelButton,
																						 this.wizardControl1.FinishButton,
																						 this.wizardControl1.BackButton,
																						 this.wizardControl1.NextButton,
																						 this.gradientPanel1});
			this.wizardControl1.Description = this.label2;
			this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// wizardControl1.FinishButton
			// 
			this.wizardControl1.FinishButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.wizardControl1.FinishButton.Location = new System.Drawing.Point(432, 386);
			this.wizardControl1.FinishButton.Name = "finishButton";
			this.wizardControl1.FinishButton.Text = "Finish";
			this.wizardControl1.FinishButton.Visible = false;
			// 
			// wizardControl1.GridBagLayout
			// 
			this.wizardControl1.GridBagLayout.ContainerControl = this.wizardControl1;
			// 
			// wizardControl1.HelpButton
			// 
			this.wizardControl1.HelpButton.Enabled = false;
			this.wizardControl1.HelpButton.Location = new System.Drawing.Point(432, 386);
			this.wizardControl1.HelpButton.Name = "helpButton";
			this.wizardControl1.HelpButton.Text = "Help";
			this.wizardControl1.HelpButton.Visible = false;
			this.wizardControl1.Name = "wizardControl1";
			// 
			// wizardControl1.NextButton
			// 
			this.wizardControl1.NextButton.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.wizardControl1.NextButton.Location = new System.Drawing.Point(352, 386);
			this.wizardControl1.NextButton.Name = "nextButton";
			this.wizardControl1.NextButton.Text = "Next >>";
			this.wizardControl1.SelectedWizardPage = this.uploadLaterPage;
			this.wizardControl1.Size = new System.Drawing.Size(512, 414);
			this.wizardControl1.TabIndex = 0;
			this.wizardControl1.Title = this.label1;
			this.wizardControl1.WizardPageContainer = this.wizardContainer1;
			this.wizardControl1.WizardPages = new Syncfusion.Windows.Forms.Tools.WizardControlPage[] {
																										 this.frontPage,
																										 this.provideInfoPage,
																										 this.uploadPage,
																										 this.uploadLaterPage,
																										 this.finishPage};
			this.wizardControl1.Next += new System.EventHandler(this.wizardControl1_Next);
			this.wizardControl1.Help += new System.EventHandler(this.wizardControl1_Help);
			this.wizardControl1.Finish += new System.EventHandler(this.wizardControl1_Finish);
			this.wizardControl1.Cancel += new System.EventHandler(this.wizardControl1_Cancel);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.pictureBox1.Image = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(438, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 61);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// gradientPanel1
			// 
			this.gradientPanel1.BackColor = System.Drawing.Color.White;
			this.gradientPanel1.BorderColor = System.Drawing.Color.Black;
			this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gradientPanel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.pictureBox1,
																						 this.label1,
																						 this.label2});
			this.gradientPanel1.Name = "gradientPanel1";
			this.gradientPanel1.Size = new System.Drawing.Size(512, 70);
			this.gradientPanel1.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Page 2 of 3";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.Location = new System.Drawing.Point(20, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Delayed Registration Procedure:";
			// 
			// wizardContainer1
			// 
			this.wizardContainer1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.wizardContainer1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						   this.frontPage,
																						   this.provideInfoPage,
																						   this.uploadPage,
																						   this.uploadLaterPage,
																						   this.finishPage});
			this.wizardContainer1.Location = new System.Drawing.Point(0, 70);
			this.wizardContainer1.Name = "wizardContainer1";
			this.wizardContainer1.Size = new System.Drawing.Size(512, 303);
			this.wizardContainer1.TabIndex = 1;
			// 
			// frontPage
			// 
			this.frontPage.BackColor = System.Drawing.Color.White;
			this.frontPage.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
			this.frontPage.BackVisible = false;
			this.frontPage.BorderColor = System.Drawing.Color.Black;
			this.frontPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.frontPage.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label13,
																					this.label12,
																					this.pictureBox2,
																					this.label11,
																					this.label7});
			this.frontPage.Description = "This is the description of the Wizard Page";
			this.frontPage.FullPage = true;
			this.frontPage.LayoutName = "Card1";
			this.frontPage.Name = "frontPage";
			this.frontPage.NextPage = this.provideInfoPage;
			this.frontPage.PreviousPage = null;
			this.frontPage.Size = new System.Drawing.Size(512, 303);
			this.frontPage.TabIndex = 0;
			this.frontPage.Title = "Page Title";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Navy;
			this.label12.Image = ((System.Drawing.Bitmap)(resources.GetObject("label12.Image")));
			this.label12.Location = new System.Drawing.Point(64, 72);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 40);
			this.label12.TabIndex = 2;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(160, 376);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(242)), ((System.Byte)(151)), ((System.Byte)(50)));
			this.label11.Location = new System.Drawing.Point(184, 24);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(280, 72);
			this.label11.TabIndex = 1;
			this.label11.Text = "Welcome to the registration wizard";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Navy;
			this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label7.Location = new System.Drawing.Point(184, 224);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(296, 32);
			this.label7.TabIndex = 0;
			this.label7.Text = "This wizard will run you through the registration procedure.";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// provideInfoPage
			// 
			this.provideInfoPage.BackEnabled = false;
			this.provideInfoPage.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Window);
			this.provideInfoPage.BackVisible = false;
			this.provideInfoPage.BorderColor = System.Drawing.Color.Black;
			this.provideInfoPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.provideInfoPage.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.radioButton2,
																						  this.radioButton1,
																						  this.textBox3,
																						  this.label5,
																						  this.textBox2,
																						  this.label4,
																						  this.textBox1,
																						  this.label3});
			this.provideInfoPage.Description = "Provide personal information:";
			this.provideInfoPage.FullPage = false;
			this.provideInfoPage.LayoutName = "Card2";
			this.provideInfoPage.Name = "provideInfoPage";
			this.provideInfoPage.NextPage = this.uploadPage;
			this.provideInfoPage.PreviousPage = this.frontPage;
			this.provideInfoPage.Size = new System.Drawing.Size(512, 303);
			this.provideInfoPage.TabIndex = 1;
			this.provideInfoPage.Title = "Page 1 of 3";
			this.provideInfoPage.NextClick += new System.EventHandler(this.provideInfoPage_NextClick);
			this.provideInfoPage.ValidatePage += new System.ComponentModel.CancelEventHandler(this.provideInfoPage_ValidatePage);
			// 
			// radioButton2
			// 
			this.radioButton2.BackColor = System.Drawing.Color.Transparent;
			this.radioButton2.Location = new System.Drawing.Point(184, 224);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 5;
			this.radioButton2.Text = "Upload Later";
			// 
			// radioButton1
			// 
			this.radioButton1.BackColor = System.Drawing.Color.Transparent;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(184, 192);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(160, 24);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Upload registration Info.";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(184, 80);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(168, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.Text = "";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Location = new System.Drawing.Point(56, 80);
			this.label5.Name = "label5";
			this.label5.TabIndex = 4;
			this.label5.Text = "Address";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(184, 120);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(168, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(56, 120);
			this.label4.Name = "label4";
			this.label4.TabIndex = 2;
			this.label4.Text = "Telephone";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(184, 40);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(168, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(56, 40);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			this.label3.Text = "Name";
			// 
			// uploadLaterPage
			// 
			this.uploadLaterPage.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Window);
			this.uploadLaterPage.BackVisible = false;
			this.uploadLaterPage.BorderColor = System.Drawing.Color.Black;
			this.uploadLaterPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.uploadLaterPage.Controls.AddRange(new System.Windows.Forms.Control[] {
																						  this.label9,
																						  this.numericUpDown1,
																						  this.label8});
			this.uploadLaterPage.Description = "Delayed Registration Procedure:";
			this.uploadLaterPage.FullPage = false;
			this.uploadLaterPage.HelpEnabled = false;
			this.uploadLaterPage.HelpVisible = false;
			this.uploadLaterPage.LayoutName = "Card4";
			this.uploadLaterPage.Name = "uploadLaterPage";
			this.uploadLaterPage.NextPage = this.finishPage;
			this.uploadLaterPage.PreviousPage = this.provideInfoPage;
			this.uploadLaterPage.Size = new System.Drawing.Size(512, 303);
			this.uploadLaterPage.TabIndex = 3;
			this.uploadLaterPage.Title = "Page 2 of 3";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Location = new System.Drawing.Point(200, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 23);
			this.label9.TabIndex = 2;
			this.label9.Text = "days.";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(144, 56);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(48, 20);
			this.numericUpDown1.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Location = new System.Drawing.Point(64, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 0;
			this.label8.Text = "Register after ";
			// 
			// finishPage
			// 
			this.finishPage.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Window);
			this.finishPage.BackVisible = false;
			this.finishPage.BorderColor = System.Drawing.Color.Black;
			this.finishPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.finishPage.CancelOverFinish = false;
			this.finishPage.CancelVisible = false;
			this.finishPage.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.label10});
			this.finishPage.Description = "Registration Completed";
			this.finishPage.FullPage = false;
			this.finishPage.HelpEnabled = false;
			this.finishPage.HelpVisible = false;
			this.finishPage.LayoutName = "Card5";
			this.finishPage.Name = "finishPage";
			this.finishPage.NextEnabled = false;
			this.finishPage.NextPage = null;
			this.finishPage.PreviousPage = this.uploadPage;
			this.finishPage.Size = new System.Drawing.Size(512, 303);
			this.finishPage.TabIndex = 4;
			this.finishPage.Title = "Page 3 of 3";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Location = new System.Drawing.Point(40, 256);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(320, 23);
			this.label10.TabIndex = 0;
			this.label10.Text = "Congrats! You have now successfully completed registration.";
			// 
			// uploadPage
			// 
			this.uploadPage.BackEnabled = false;
			this.uploadPage.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Window);
			this.uploadPage.BackVisible = false;
			this.uploadPage.BorderColor = System.Drawing.Color.Black;
			this.uploadPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.uploadPage.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.label6,
																					 this.progressBar1});
			this.uploadPage.Description = "Progress of operation:";
			this.uploadPage.FullPage = false;
			this.uploadPage.HelpVisible = false;
			this.uploadPage.LayoutName = "Card3";
			this.uploadPage.Name = "uploadPage";
			this.uploadPage.NextPage = this.finishPage;
			this.uploadPage.PreviousPage = this.provideInfoPage;
			this.uploadPage.Size = new System.Drawing.Size(512, 303);
			this.uploadPage.TabIndex = 2;
			this.uploadPage.Title = "Page 2 of 3";
			this.uploadPage.BackClick += new System.EventHandler(this.uploadPage_BackClick);
			this.uploadPage.PageLoad += new System.EventHandler(this.uploadPage_PageLoad);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Location = new System.Drawing.Point(88, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(192, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "Registration Upload Progress Info:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(88, 120);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(312, 23);
			this.progressBar1.TabIndex = 0;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.Color.Navy;
			this.label13.Location = new System.Drawing.Point(192, 336);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(216, 24);
			this.label13.TabIndex = 4;
			this.label13.Text = "Click Next to proceed";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 414);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.wizardControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wizard Control Tutorial";
			((System.ComponentModel.ISupportInitialize)(this.wizardControl1.GridBagLayout)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
			this.wizardControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
			this.gradientPanel1.ResumeLayout(false);
			this.wizardContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.frontPage)).EndInit();
			this.frontPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.provideInfoPage)).EndInit();
			this.provideInfoPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uploadLaterPage)).EndInit();
			this.uploadLaterPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.finishPage)).EndInit();
			this.finishPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uploadPage)).EndInit();
			this.uploadPage.ResumeLayout(false);
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

		#region WIZARD_CONTROL_EVENTS

		private void wizardControl1_Finish(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void wizardControl1_Cancel(object sender, System.EventArgs e)
		{
			this.progressBar1.Value = this.progressBar1.Value ;
			this.timer1.Stop();
			if(MessageBox.Show("Are you sure you want to cancel the wizard?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
				Close();
			else
			{
				this.timer1.Start();
				if(this.progressBar1.Value == 100)
                    this.timer1.Stop();
			}
			
		}

		private void wizardControl1_Help(object sender, System.EventArgs e)
		{
			MessageBox.Show("Help not implemented");
		}

		#endregion WIZARD_CONTROL_EVENTS

		#region PROVIDE_INFO_PAGE_EVENTS
		private void provideInfoPage_ValidatePage(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(this.radioButton1.Checked)
			{
				if(this.textBox1.Text.Trim() == String.Empty)
				{
					MessageBox.Show("Name cannot be empty.","Validation",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					e.Cancel = true;
					this.textBox1.Focus();
				}
			}	
		}

		private void provideInfoPage_NextClick(object sender, System.EventArgs e)
		{
			// Set up the execution path based on user preference:
			if(this.radioButton1.Checked)
			{
				this.provideInfoPage.NextPage = this.uploadPage;
				this.finishPage.PreviousPage = this.uploadPage;
			}
			else
			{
				this.provideInfoPage.NextPage = this.uploadLaterPage;
				this.finishPage.PreviousPage = this.uploadLaterPage;
			}
		}
		#endregion

		#region UPLOAD_PAGE_EVENTS
		private void uploadPage_PageLoad(object sender, System.EventArgs e)
		{
			// Start a timer to simulate registration info upload:
			this.progressBar1.Value = 0;
			this.timer1.Enabled = true;

			// To prevent the user from clicking the next button until the upload is done, disable the next button:
			this.uploadPage.NextEnabled = false;
		}
 
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			this.progressBar1.Value += 5;
			if(this.progressBar1.Value == 100)
			{
				this.timer1.Enabled = false;
				this.uploadPage.NextEnabled = true;
			}
		}
		#endregion

		private void uploadPage_BackClick(object sender, System.EventArgs e)
		{
			this.textBox1.Text ="";

		}

		private void wizardControl1_Next(object sender, System.EventArgs e)
		{
			if(this.wizardControl1.SelectedPage == this.provideInfoPage)
				this.textBox1.Focus();
		}

	}
}
