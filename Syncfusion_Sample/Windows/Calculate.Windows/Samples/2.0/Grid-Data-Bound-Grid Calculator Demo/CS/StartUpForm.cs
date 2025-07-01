#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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

namespace GridDataBoundGridCalculator
{
	/// <summary>
	/// Summary description for StartUpForm.
	/// </summary>
	public class StartUpForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public StartUpForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();
			
			System.Drawing.Icon ico = new System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"));
			this.Icon = ico ;
	

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
		/// Required method for Designer support; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(32, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Single GridDataBoundGrid with Calculation support";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(32, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Workbook of GridDataBoundGrids with Calculation support";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartUpForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(248, 166);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "StartUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Up Form";
            this.Load += new System.EventHandler(this.StartUpForm_Load);
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new StartUpForm());
		}


		//used in automated testing
		Form[] forms = new Form[2];

		private void button1_Click(object sender, System.EventArgs e)
		{
			SingleGridDataBoundGridForm f = new SingleGridDataBoundGridForm();
			forms[0] = f;
			f.Show();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			GridDataBoundGridWorkBookForm f = new GridDataBoundGridWorkBookForm();
			forms[1] = f;
			f.Show();
		}

		private void StartUpForm_Load(object sender, System.EventArgs e)
		{
			if(Environment.CommandLine.EndsWith("automatedtest"))
			{
				this.button1.PerformClick();
				this.button2.PerformClick();
				Size sz = SystemInformation.PrimaryMonitorSize;;
				this.forms[0].Location = new Point(0,0);
				this.forms[0].Size = new Size(sz.Width/2, sz.Height);
				this.forms[1].Location = new Point(sz.Width/2+1,0);
				this.forms[1].Size = new Size(sz.Width/2, sz.Height);
				this.WindowState = FormWindowState.Minimized;
			}
		}
	}
}
