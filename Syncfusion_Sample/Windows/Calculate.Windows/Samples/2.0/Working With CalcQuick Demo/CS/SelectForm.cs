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

namespace FirstSample
{
	/// <summary>
	/// Summary description for SelectForm.
	/// </summary>
	public class SelectForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button manualButton;
		private System.Windows.Forms.Button autoButton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button angleFormButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SelectForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();

			try
			{
				System.Drawing.Icon ico = new System.Drawing.Icon(FindFile("Icon", "sfgrid.ico"));
				this.Icon = ico ;
			}
			catch
			{}


			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

        #region FindFile Utility
        /// <summary>
        /// Finds a file of the given name in the current directory or sibling "Data" directory.
        /// If file is not found, the parent folder is checked until the file is found. This method
        /// is used by our samples when they load data from a separate "Data" folder.
        /// </summary>
        /// <param name="dataDirName">The name of the "Data" folder.</param>
        /// <param name="fileName">The filename to be searched.</param>
        /// <returns>The full path of the file that was found; an empty string is returned if file is not found.</returns>

        public static string FindFile(string dataDirName, string fileName)
        {
            dataDirName = dataDirName.TrimEnd('\\', '/');
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = dataDirName + "\\" + fileName;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return fileName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return dataFileName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return "";
        }
        #endregion

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
            this.manualButton = new System.Windows.Forms.Button();
            this.autoButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.angleFormButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manualButton
            // 
            this.manualButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.manualButton.Location = new System.Drawing.Point(48, 24);
            this.manualButton.Name = "manualButton";
            this.manualButton.Size = new System.Drawing.Size(184, 23);
            this.manualButton.TabIndex = 0;
            this.manualButton.Text = "Manual Calculations";
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // autoButton
            // 
            this.autoButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.autoButton.Location = new System.Drawing.Point(48, 64);
            this.autoButton.Name = "autoButton";
            this.autoButton.Size = new System.Drawing.Size(184, 23);
            this.autoButton.TabIndex = 1;
            this.autoButton.Text = "Auto Calculations";
            this.autoButton.Click += new System.EventHandler(this.autoButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(48, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Controls as Keys";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // angleFormButton
            // 
            this.angleFormButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.angleFormButton.Location = new System.Drawing.Point(48, 144);
            this.angleFormButton.Name = "angleFormButton";
            this.angleFormButton.Size = new System.Drawing.Size(184, 23);
            this.angleFormButton.TabIndex = 3;
            this.angleFormButton.Text = "Angle Calculations";
            this.angleFormButton.Click += new System.EventHandler(this.angleFormButton_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(48, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Auto Angle Calculations";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(48, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Algebraic Expressions";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(272, 270);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.angleFormButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.autoButton);
            this.Controls.Add(this.manualButton);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Form Demo";
            this.Load += new System.EventHandler(this.SelectForm_Load);
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
			Application.Run(new SelectForm());
		}

		//used in automated testing
		Form[] forms = new Form[6];
		private void manualButton_Click(object sender, System.EventArgs e)
		{
			ManualCalcForm f = new ManualCalcForm();
			forms[0] = f;
			f.Show();
		}

		private void autoButton_Click(object sender, System.EventArgs e)
		{
			AutoCalcForm f = new AutoCalcForm();
			forms[1] = f;
			f.Show();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			MoreComplexForm f = new MoreComplexForm();
			forms[2] = f;
			f.Show();
		}

		private void angleFormButton_Click(object sender, System.EventArgs e)
		{
			AngleForm f = new AngleForm();
			forms[3] = f;
			f.Show();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			AutoAngleForm f = new AutoAngleForm();
			forms[4] = f;
			f.Show();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			AlgebraicExpressions f = new AlgebraicExpressions();
			forms[5] = f;
			f.Show();
		}

		private void SelectForm_Load(object sender, System.EventArgs e)
		{
			if(Environment.CommandLine.EndsWith("automatedtest"))
			{
				this.manualButton.PerformClick();
				this.autoButton.PerformClick();
				this.button1.PerformClick();
				this.angleFormButton.PerformClick();
				this.button2.PerformClick();
				this.button3.PerformClick();
				Size sz = SystemInformation.PrimaryMonitorSize;;
				this.forms[0].Location = new Point(0,0);
				this.forms[0].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[1].Location = new Point(sz.Width/3+1,0);
				this.forms[1].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[2].Location = new Point(2*sz.Width/3+1,0);
				this.forms[2].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[3].Location = new Point(0,sz.Height/2+1);
				this.forms[3].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[4].Location = new Point(sz.Width/3+1,sz.Height/2+1);
				this.forms[4].Size = new Size(sz.Width/3, sz.Height/2);
				this.forms[5].Location = new Point(2*sz.Width/3+1,sz.Height/2+1);
				this.forms[5].Size = new Size(sz.Width/3, sz.Height/2);
				this.WindowState = FormWindowState.Minimized;
			}
		}

	}
}
