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


using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace PopupControls
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		// Syncfusion Changes: Using this custom PopupControlContainer derived class.
		private PopupControlContainer popupControlContainer1;
		private PopupControls.PopupParentControl popupParentControl1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// Syncfusion notes: Setup the parent/child relationship.
			//this.popupParentControl1.popupControlContainer1.PopupParent = this.popupControlContainer1;
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
			this.button1 = new System.Windows.Forms.Button();
			this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
			this.popupParentControl1 = new PopupControls.PopupParentControl();
			this.popupControlContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(32, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Show Popup";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// popupControlContainer1
			// 
			this.popupControlContainer1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.popupControlContainer1.Controls.AddRange(new System.Windows.Forms.Control[] {
																								 this.popupParentControl1});
			this.popupControlContainer1.Location = new System.Drawing.Point(32, 64);
			this.popupControlContainer1.Name = "popupControlContainer1";
			this.popupControlContainer1.ParentControl = this.button1;
			this.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.popupControlContainer1.Size = new System.Drawing.Size(376, 104);
			this.popupControlContainer1.TabIndex = 2;
			this.popupControlContainer1.Visible = false;
			// 
			// popupParentControl1
			// 
			this.popupParentControl1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.popupParentControl1.Location = new System.Drawing.Point(8, 16);
			this.popupParentControl1.Name = "popupParentControl1";
			this.popupParentControl1.Size = new System.Drawing.Size(432, 448);
			this.popupParentControl1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.ClientSize = new System.Drawing.Size(584, 390);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.popupControlContainer1,
																		  this.button1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PopUp In PopUp";
			this.popupControlContainer1.ResumeLayout(false);
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			// Toggle popup.
			if(this.popupControlContainer1.IsShowing())
				popupControlContainer1.HidePopup(PopupCloseType.Canceled);
			else
			{
				popupControlContainer1.ShowPopup(Point.Empty);
				popupControlContainer1.Focus();
			}
		}
	}
}
