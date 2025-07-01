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
using Syncfusion.Calculate;

namespace FirstSample
{
	/// <summary>
	/// Summary description for AutoAngleForm.
	/// </summary>
	public class AutoAngleForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox Angle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox cosTB;
		private System.Windows.Forms.TextBox sinTB;
		private System.Windows.Forms.Label label4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AutoAngleForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();

			try
			{
				System.Drawing.Icon ico = new System.Drawing.Icon(SelectForm.FindFile("Icon", "sfgrid.ico"));
				this.Icon = ico ;
			}
			catch{}
	

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
		/// Required method for Designer suppor; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.Angle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cosTB = new System.Windows.Forms.TextBox();
            this.sinTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(152, 88);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(56, 20);
            this.Angle.TabIndex = 0;
            this.Angle.Text = "30";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "angle in degrees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "cosine of angle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "sine of angle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cosTB
            // 
            this.cosTB.Location = new System.Drawing.Point(152, 128);
            this.cosTB.Name = "cosTB";
            this.cosTB.Size = new System.Drawing.Size(136, 20);
            this.cosTB.TabIndex = 4;
            this.cosTB.Text = "= sin([Angle] * pi() / 180) ";
            // 
            // sinTB
            // 
            this.sinTB.Location = new System.Drawing.Point(152, 168);
            this.sinTB.Name = "sinTB";
            this.sinTB.Size = new System.Drawing.Size(136, 20);
            this.sinTB.TabIndex = 5;
            this.sinTB.Text = "= cos([Angle] * pi() / 180) ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter an angle and press Tab to see its Sine and Cosine.";
            // 
            // AutoAngleForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(320, 206);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sinTB);
            this.Controls.Add(this.cosTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Angle);
            this.Name = "AutoAngleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Angle Form Demo";
            this.Load += new System.EventHandler(this.AngleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		CalcQuick calculator = null;

		private void AngleForm_Load(object sender, System.EventArgs e)
		{
			//TextBox Angle = new TextBox();
			this.Angle.Name = "Angle";
			this.Angle.Text = "30";

			//cosTB = new TextBox();
			this.cosTB.Name = "cosTB";
			this.cosTB.Text = "= cos([Angle] * pi() / 180) ";

			//sinTB = new TextBox();
			this.sinTB.Name = "sinTB";
			this.sinTB.Text = "= sin([Angle] * pi() / 180) ";

			//Instantiate a CalcQuick object:
			calculator = new CalcQuick();

			//Register the controls used in calculations.
			//The formula names used are the Control.Name strings.
            this.calculator.RegisterControlArray(new Control[]
                                                {
                                                    this.Angle,
                                                    this.cosTB,
                                                    this.sinTB
                                                });

			//Allow the CalcQuick sheet to create dependency lists among the formula objects
			//necesary for auto-calculations.
			this.calculator.RefreshAllCalculations();
		}

		
	}
}
