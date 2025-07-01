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

using Syncfusion.Windows.Forms.HTMLUI;

namespace Syncfusion.Windows.Forms.HTMLUI.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		Assembly _assembly;
		Stream _htmlStream;

		private Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl htmluiControl1;

		IHTMLElement[] descriptions = null;
		private System.Windows.Forms.Panel panel1;

		private Point beginPoint, endPoint = Point.Empty;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;

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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// htmluiControl1
			// 
			this.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.htmluiControl1.AutoScroll = true;
			this.htmluiControl1.AutoScrollMinSize = new System.Drawing.Size(357, 358);
			this.htmluiControl1.BackColor = System.Drawing.Color.White;
			this.htmluiControl1.EnableMultithreading = false;
			this.htmluiControl1.IsOriginalTextCached = true;
			this.htmluiControl1.Name = "htmluiControl1";
			this.htmluiControl1.ShowTitle = false;
			this.htmluiControl1.Size = new System.Drawing.Size(384, 373);
			this.htmluiControl1.StartupDocument = "";
			this.htmluiControl1.StartupFolder = "";
			this.htmluiControl1.TabIndex = 0;
			this.htmluiControl1.Text = "<html xvisible=\"True\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\"><head xvi" +
				"sible=\"False\" xsize=\"{Width=0, Height=0}\" xlocation=\"{X=0,Y=0}\" /><body xvisible" +
				"=\"True\" xsize=\"{Width=71, Height=15}\" xlocation=\"{X=10,Y=0}\">htmluiControl1</bod" +
				"y></html>";
			this.htmluiControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.htmluiControl1_Paint);
			this.htmluiControl1.LoadFinished += new System.EventHandler(this.htmluiControl1_LoadFinished);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel2});
			this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Location = new System.Drawing.Point(384, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(168, 373);
			this.panel1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(215)), ((System.Byte)(221)), ((System.Byte)(237)));
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel3});
			this.panel2.Location = new System.Drawing.Point(8, 16);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(152, 256);
			this.panel2.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(198)), ((System.Byte)(220)));
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.label3,
																				 this.label2,
																				 this.label1});
			this.panel3.Location = new System.Drawing.Point(2, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(148, 252);
			this.panel3.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Maroon;
			this.label3.Location = new System.Drawing.Point(2, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(144, 88);
			this.label3.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Maroon;
			this.label2.Location = new System.Drawing.Point(2, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 84);
			this.label2.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(103)), ((System.Byte)(110)), ((System.Byte)(152)));
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 56);
			this.label1.TabIndex = 7;
			this.label1.Text = "Click on the product descriptions to get their coordinates";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel1,
																		  this.htmluiControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            //this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Element Coordinates";
			//this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.htmluiControl1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			LoadHTMLResource();			
		}

		private bool LoadHTMLResource()
		{
			bool success = false;

			try
			{
				_assembly = Assembly.GetExecutingAssembly();
				_htmlStream = (Stream)_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.products.htm");
				if(_htmlStream != null)
				{
					this.htmluiControl1.LoadHTML(_htmlStream);
					success = true;
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			return success;
		}

		private void description_Click( object sender, EventArgs e )
		{
			BaseElement element = sender as BaseElement;
			beginPoint = element.Location;
            if (htmluiControl1.AutoScrollPosition.Y != 0)
                beginPoint.Y += htmluiControl1.AutoScrollPosition.Y;
			endPoint = new Point(beginPoint.X+element.Size.Width,beginPoint.Y+element.Size.Height);
			this.label2.Text = "Element begins at " + beginPoint.ToString() + " and ends at " +  endPoint.ToString();
			this.label3.Text = "Element's Height\n" + element.Height.ToString() + "\n\nElement's Width\n" + element.Width.ToString();
			this.htmluiControl1.Refresh();
			
		}

		private void htmluiControl1_LoadFinished(object sender, System.EventArgs e)
		{
			descriptions = this.htmluiControl1.Document.GetElementsByName("description");

			foreach (IHTMLElement description in descriptions)
			{
				description.Click += new EventHandler( description_Click );
			}
		}

		private void htmluiControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			if(beginPoint != Point.Empty  && endPoint != Point.Empty)
			{
				Size sz = new Size(endPoint.X - beginPoint.X,endPoint.Y-beginPoint.Y);
				Rectangle rect = new Rectangle(beginPoint,sz);
				e.Graphics.DrawRectangle(new Pen(Color.Red),rect);
			}
		}
	}
}
