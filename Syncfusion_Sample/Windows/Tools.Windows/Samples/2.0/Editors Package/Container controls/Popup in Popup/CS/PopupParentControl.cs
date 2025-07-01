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
	/// Summary description for PopupParentControl.
	/// </summary>
	public class PopupParentControl : System.Windows.Forms.UserControl
	{
    public Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
    private PopupControls.PopupUserControl popupUserControl1;
    private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
    private System.ComponentModel.IContainer components;

		public PopupParentControl()
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupParentControl));
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.popupUserControl1 = new PopupControls.PopupUserControl();
            this.button1 = new System.Windows.Forms.Button();
            this.popupControlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupControlContainer1.Controls.Add(this.label1);
            this.popupControlContainer1.Controls.Add(this.popupUserControl1);
            this.popupControlContainer1.Location = new System.Drawing.Point(32, 8);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.ParentControl = this.button1;
            this.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popupControlContainer1.Size = new System.Drawing.Size(384, 272);
            this.popupControlContainer1.TabIndex = 1;
            this.popupControlContainer1.Visible = false;
            this.popupControlContainer1.Popup += new System.EventHandler(this.popupControlContainer1_Popup);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(208, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Demonstrates the implementation of a popup within another popup using PopUpContro" +
                "lContainer.";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // popupUserControl1
            // 
            this.popupUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.popupUserControl1.Location = new System.Drawing.Point(8, 40);
            this.popupUserControl1.Name = "popupUserControl1";
            this.popupUserControl1.Size = new System.Drawing.Size(200, 224);
            this.popupUserControl1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(40, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Popup in Popup:";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopupParentControl_MouseDown);
            // 
            // PopupParentControl
            // 
            this.Controls.Add(this.button1);
            this.Controls.Add(this.popupControlContainer1);
            this.Name = "PopupParentControl";
            this.Size = new System.Drawing.Size(448, 312);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PopupParentControl_MouseDown);
            this.popupControlContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(this.popupControlContainer1.IsShowing())
				popupControlContainer1.HidePopup(PopupCloseType.Canceled);
			else
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
						// Set up key relationship
						pcc.CurrentPopupChild = this.popupControlContainer1;
						this.popupControlContainer1.PopupParent = pcc;
					}
				}

				popupControlContainer1.ShowPopup(Point.Empty);
			}
		}
		// So that the child popup will close on MouseDown.
		private void PopupParentControl_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.popupControlContainer1.HidePopup(PopupCloseType.Canceled);
		}
		private void popupControlContainer1_Popup(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.Focus();
		}
	}
}
