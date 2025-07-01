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

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace PopupControls
{
	/// <summary>
	/// Summary description for PopupUserControl.
	/// </summary>
  public class PopupUserControl : System.Windows.Forms.UserControl
  {
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.ComponentModel.IContainer components=null;
    
		public PopupUserControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

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
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(16, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 128);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "<<<  Enter Text >>>";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(24, 184);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// PopupUserControl
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.textBox1});
			this.Name = "PopupUserControl";
			this.Size = new System.Drawing.Size(224, 216);
			this.ResumeLayout(false);

		}
		#endregion

  	private void button1_Click(object sender, System.EventArgs e)
	  {
		// Find my parent PopupControlContainer:
		if(this.FindForm() is PopupHost)
		{
			PopupControlContainer pcc = null;
			// Find the PopupControlContainer
			foreach(Control c in this.FindForm().Controls)
			{
				if(c is PopupControlContainer)
				{
					pcc = c as PopupControlContainer;
					break;
				}
			}
			// Need to do this only if the PopupControlContainer is currently showing
			if(pcc != null && pcc.IsShowing())
			{
				pcc.HidePopup(PopupCloseType.Done);
			}
		}
	}
  }
}
