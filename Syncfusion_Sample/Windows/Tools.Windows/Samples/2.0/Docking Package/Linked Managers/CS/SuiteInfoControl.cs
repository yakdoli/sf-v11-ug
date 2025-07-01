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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Resources;

namespace LinkedManagers
{
	/// <summary>
	/// Summary description for SuiteInfoControl.
	/// </summary>
	public class SuiteInfoControl : DockableControlBase
	{
		private System.Windows.Forms.TextBox textBox1;	
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;		

		public SuiteInfoControl(String label)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize the docking window label and icon properties.
			this.Name = label;
			this.controlLabel = label;
			this.controlIcon = new Icon("..\\..\\..\\Icons\\syncf.ico");
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(226)), ((System.Byte)(240)));
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(400, 384);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = @"Essential Suite includes multpile component libraries in one great package. Each of these component libraries has a unique and useful feature set. For example, Essential Tools is a collection of great user interface controls including XP style controls and docking windows. Essential Grid is a fully customizable industry standard grid control with an extensive Excel-like feature set. Essential Edit is an enhanced edit with great features such as syntax highlighting and multi-level Undo / Redo. Essential Chart is a full-fledged business chart component with a unique point-based styles architecture. Syncfusion components are truly unique, offering benefits that are unmatched in the .NET component industry.";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// SuiteInfoControl
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBox1});
			this.Name = "SuiteInfoControl";
			this.Size = new System.Drawing.Size(400, 384);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
