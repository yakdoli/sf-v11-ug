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
using System.Reflection;

namespace HTMLUIControlEvents
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Assembly _assembly;
		private Stream _htmlStream;

		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.CheckBox checkBoxShowTitleChanged;
		private System.Windows.Forms.CheckBox checkBoxTitleChanged;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox checkBoxLoadStarted;
		private System.Windows.Forms.CheckBox checkBoxLoadFinished;
		private System.Windows.Forms.CheckBox checkBoxLoadError;
		private System.Windows.Forms.CheckBox checkBoxPreRenderDocument;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.htmluiControl1 = new Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBoxShowTitleChanged = new System.Windows.Forms.CheckBox();
			this.checkBoxTitleChanged = new System.Windows.Forms.CheckBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.checkBoxPreRenderDocument = new System.Windows.Forms.CheckBox();
			this.checkBoxLoadError = new System.Windows.Forms.CheckBox();
			this.checkBoxLoadFinished = new System.Windows.Forms.CheckBox();
			this.checkBoxLoadStarted = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Location = new System.Drawing.Point(144, 0);
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.Size = new System.Drawing.Size(408, 280);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=71, Height=15}\" xlocation=\"{X=10,Y=20}\">htmluiControl1</bo" +
				"dy></html>";
			this.htmluiControl1.PreRenderDocument += new Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentEventHandler(this.htmluiControl1_PreRenderDocument);
			this.htmluiControl1.TitleChanged += new Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventHandler(this.htmluiControl1_TitleChanged);
			this.htmluiControl1.LoadStarted += new System.EventHandler(this.htmluiControl1_LoadStarted);
			this.htmluiControl1.LoadError += new Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventHandler(this.htmluiControl1_LoadError);
			this.htmluiControl1.ShowTitleChanged += new Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventHandler(this.htmluiControl1_ShowTitleChanged);
			this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left);
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel2,
																				 this.panel4,
																				 this.button3});
			this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(144, 376);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel3});
			this.panel2.Location = new System.Drawing.Point(12, 208);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(120, 128);
			this.panel2.TabIndex = 8;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label1,
																				 this.button2,
																				 this.checkBoxShowTitleChanged,
																				 this.checkBoxTitleChanged});
			this.panel3.Location = new System.Drawing.Point(2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(116, 124);
			this.panel3.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(-2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 24);
			this.label1.TabIndex = 17;
			this.label1.Text = "Title events";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F);
			this.button2.ForeColor = System.Drawing.Color.Maroon;
			this.button2.Location = new System.Drawing.Point(10, 92);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 22);
			this.button2.TabIndex = 16;
			this.button2.Text = "Change Title";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// checkBoxShowTitleChanged
			// 
			this.checkBoxShowTitleChanged.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.checkBoxShowTitleChanged.Checked = true;
			this.checkBoxShowTitleChanged.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxShowTitleChanged.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxShowTitleChanged.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxShowTitleChanged.ForeColor = System.Drawing.Color.Maroon;
			this.checkBoxShowTitleChanged.Location = new System.Drawing.Point(10, 54);
			this.checkBoxShowTitleChanged.Name = "checkBoxShowTitleChanged";
			this.checkBoxShowTitleChanged.Size = new System.Drawing.Size(98, 30);
			this.checkBoxShowTitleChanged.TabIndex = 15;
			this.checkBoxShowTitleChanged.Text = "Show TitleChanged";
			// 
			// checkBoxTitleChanged
			// 
			this.checkBoxTitleChanged.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.checkBoxTitleChanged.Checked = true;
			this.checkBoxTitleChanged.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxTitleChanged.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxTitleChanged.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxTitleChanged.ForeColor = System.Drawing.Color.Maroon;
			this.checkBoxTitleChanged.Location = new System.Drawing.Point(10, 28);
			this.checkBoxTitleChanged.Name = "checkBoxTitleChanged";
			this.checkBoxTitleChanged.Size = new System.Drawing.Size(96, 24);
			this.checkBoxTitleChanged.TabIndex = 14;
			this.checkBoxTitleChanged.Text = "TitleChanged";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.panel4.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel5});
			this.panel4.Location = new System.Drawing.Point(12, 5);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(120, 200);
			this.panel4.TabIndex = 7;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.panel5.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label3,
																				 this.checkBoxPreRenderDocument,
																				 this.checkBoxLoadError,
																				 this.checkBoxLoadFinished,
																				 this.checkBoxLoadStarted,
																				 this.button1});
			this.panel5.Location = new System.Drawing.Point(2, 2);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(116, 196);
			this.panel5.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label3.Location = new System.Drawing.Point(-2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 24);
			this.label3.TabIndex = 15;
			this.label3.Text = "Load Events";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// checkBoxPreRenderDocument
			// 
			this.checkBoxPreRenderDocument.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.checkBoxPreRenderDocument.Checked = true;
			this.checkBoxPreRenderDocument.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxPreRenderDocument.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxPreRenderDocument.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxPreRenderDocument.ForeColor = System.Drawing.Color.Maroon;
			this.checkBoxPreRenderDocument.Location = new System.Drawing.Point(10, 128);
			this.checkBoxPreRenderDocument.Name = "checkBoxPreRenderDocument";
			this.checkBoxPreRenderDocument.Size = new System.Drawing.Size(96, 24);
			this.checkBoxPreRenderDocument.TabIndex = 14;
			this.checkBoxPreRenderDocument.Text = "PreRenderDocument";
			// 
			// checkBoxLoadError
			// 
			this.checkBoxLoadError.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.checkBoxLoadError.Checked = true;
			this.checkBoxLoadError.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLoadError.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxLoadError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxLoadError.ForeColor = System.Drawing.Color.Maroon;
			this.checkBoxLoadError.Location = new System.Drawing.Point(10, 96);
			this.checkBoxLoadError.Name = "checkBoxLoadError";
			this.checkBoxLoadError.Size = new System.Drawing.Size(96, 18);
			this.checkBoxLoadError.TabIndex = 13;
			this.checkBoxLoadError.Text = "LoadError";
			// 
			// checkBoxLoadFinished
			// 
			this.checkBoxLoadFinished.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.checkBoxLoadFinished.Checked = true;
			this.checkBoxLoadFinished.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLoadFinished.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxLoadFinished.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxLoadFinished.ForeColor = System.Drawing.Color.Maroon;
			this.checkBoxLoadFinished.Location = new System.Drawing.Point(10, 64);
			this.checkBoxLoadFinished.Name = "checkBoxLoadFinished";
			this.checkBoxLoadFinished.Size = new System.Drawing.Size(96, 20);
			this.checkBoxLoadFinished.TabIndex = 12;
			this.checkBoxLoadFinished.Text = "LoadFinished";
			// 
			// checkBoxLoadStarted
			// 
			this.checkBoxLoadStarted.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(193)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.checkBoxLoadStarted.Checked = true;
			this.checkBoxLoadStarted.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxLoadStarted.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBoxLoadStarted.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.checkBoxLoadStarted.ForeColor = System.Drawing.Color.Maroon;
			this.checkBoxLoadStarted.Location = new System.Drawing.Point(10, 32);
			this.checkBoxLoadStarted.Name = "checkBoxLoadStarted";
			this.checkBoxLoadStarted.Size = new System.Drawing.Size(96, 26);
			this.checkBoxLoadStarted.TabIndex = 11;
			this.checkBoxLoadStarted.Text = "LoadStarted";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Maroon;
			this.button1.Location = new System.Drawing.Point(8, 160);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(98, 24);
			this.button1.TabIndex = 11;
			this.button1.Text = "Load Document";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Maroon;
			this.button3.Location = new System.Drawing.Point(16, 345);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 24);
			this.button3.TabIndex = 4;
			this.button3.Text = "Clear";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(144, 280);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(408, 96);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBox1,
																		  this.panel1,
																		  this.htmluiControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Control Events";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
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

		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.display.htm");
				if(_htmlStream != null)
				{
					this.htmluiControl1.LoadHTML(_htmlStream);
					success = true;
				}
			}
			catch(Exception ex)
			{
				OutputText(ex.ToString());
			}
			return success;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTMLResource();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
				LoadHTMLResource();
		}

		private void OutputText(string output)
		{
			this.textBox1.Text += output + "\r\n";
			this.textBox1.SelectionStart = this.textBox1.Text.Length -1;
			this.textBox1.SelectionLength =0;
			this.textBox1.ScrollToCaret();
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			if(this.checkBoxLoadFinished.Checked)
			{
				OutputText("LoadFinished event.");
			}
		}

		private void htmluiControl1_LoadStarted(object sender, System.EventArgs e)
		{
			if(this.checkBoxLoadStarted.Checked)
			{
				OutputText("LoadStarted event.");
			}	
		}

		private void htmluiControl1_LoadError(object sender, Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventArgs e)
		{
			if(this.checkBoxLoadError.Checked)
			{
				OutputText("LoadError event.");
			}	
		}

		private void htmluiControl1_PreRenderDocument(object sender, Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentArgs e)
		{
			if(this.checkBoxPreRenderDocument.Checked)
			{
				OutputText("LoadPrerenderDocument event.");
			}
		}

		private void htmluiControl1_TitleChanged(object sender, Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventArgs e)
		{
			if(this.checkBoxTitleChanged.Checked)
			{
				OutputText("TitleChanged event.");
			}
		}

		

		private void button3_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Clear();
		}

		private void htmluiControl1_ShowTitleChanged(object sender, Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventArgs e)
		{
			if(this.checkBoxShowTitleChanged.Checked)
			{
				OutputText("ShowTitleChanged event.");
			}

		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(this.htmluiControl1.ShowTitle == true)
			{
				this.htmluiControl1.Title = "";
				this.htmluiControl1.ShowTitle = false;
			}
			else
			{
				this.htmluiControl1.Title = "HTMLUIControl Title";
				this.htmluiControl1.ShowTitle = true;
			}
		}

			
	}
}
