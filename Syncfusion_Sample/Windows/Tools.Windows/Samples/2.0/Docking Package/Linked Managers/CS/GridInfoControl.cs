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

namespace LinkedManagers
{
	/// <summary>
	/// Summary description for GridInfoControl.
	/// </summary>
	public class GridInfoControl : DockableControlBase
	{
		private System.Windows.Forms.TextBox textBox1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridInfoControl(String label)
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Initialize the docking window label and icon properties.
			this.Name = label;
			this.controlLabel = label;
			this.controlIcon = new Icon("..\\..\\..\\Icons\\sfgrid.ico");
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
			this.textBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(220)), ((System.Byte)(226)), ((System.Byte)(240)));
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(520, 464);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = @"Most grid controls on the market today are data binding centric. As a consequence, they are column-oriented in nature. Each column is required to be of the same data type since data in a database column is of the same type. Formatting a column as a single entity is usually easy. Formatting individual cells however is often not supported or when supported, not very straightforward. Essential Grid is a cell-oriented grid control that allows for extensive customization at the cell level.";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// GridInfoControl
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBox1});
			this.Name = "GridInfoControl";
			this.Size = new System.Drawing.Size(520, 464);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
