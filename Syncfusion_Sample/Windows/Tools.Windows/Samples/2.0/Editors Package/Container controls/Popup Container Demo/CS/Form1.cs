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

namespace PopupControlContainerDemo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms;
	using System.Reflection ;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.TextBox popupTextBox;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button dropDownBtn;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

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

		// <samplecodeblock name="PopupControlContainer Initialization">
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			// It's recommended that you keep the PopupControlContainer unparented by
			// any Control on the Form (which will be the default case as set up during design-time).
			// Otherwise, the Form wouldn't close sometimes, after dropping down this popup!
			this.popupControlContainer1.Parent.Controls.Remove(this.popupControlContainer1);
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.popupTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dropDownBtn = new System.Windows.Forms.Button();
            this.popupControlContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupControlContainer1.Controls.Add(this.cancel);
            this.popupControlContainer1.Controls.Add(this.OK);
            this.popupControlContainer1.Controls.Add(this.popupTextBox);
            this.popupControlContainer1.Location = new System.Drawing.Point(16, 104);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(120, 128);
            this.popupControlContainer1.TabIndex = 0;
            this.popupControlContainer1.Visible = false;
            this.popupControlContainer1.Popup += new System.EventHandler(this.popupControlContainer1_Popup);
            this.popupControlContainer1.BeforePopup += new System.ComponentModel.CancelEventHandler(this.popupControlContainer1_BeforePopup);
            this.popupControlContainer1.CloseUp += new Syncfusion.Windows.Forms.PopupClosedEventHandler(this.popupControlContainer1_CloseUp);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cancel.Location = new System.Drawing.Point(56, 96);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(56, 24);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.OK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OK.Location = new System.Drawing.Point(8, 96);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(48, 24);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // popupTextBox
            // 
            this.popupTextBox.Location = new System.Drawing.Point(0, 0);
            this.popupTextBox.Multiline = true;
            this.popupTextBox.Name = "popupTextBox";
            this.popupTextBox.Size = new System.Drawing.Size(118, 90);
            this.popupTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageIndex = 1;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(240, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Associate a PopupControlContainer with this TextBox. And also transfer data back " +
                "and forth between the popup and the TextBox.";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(8, 40);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(176, 20);
            this.sourceTextBox.TabIndex = 2;
            this.sourceTextBox.Text = "Alt+DownArrow for popup";
            this.sourceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPopupParent_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dropDownBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sourceTextBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 320);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PopupControlContainer demo";
            // 
            // dropDownBtn
            // 
            this.dropDownBtn.Image = ((System.Drawing.Image)(resources.GetObject("dropDownBtn.Image")));
            this.dropDownBtn.Location = new System.Drawing.Point(192, 40);
            this.dropDownBtn.Name = "dropDownBtn";
            this.dropDownBtn.Size = new System.Drawing.Size(26, 20);
            this.dropDownBtn.TabIndex = 0;
            this.dropDownBtn.Click += new System.EventHandler(this.dropDownBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(552, 332);
            this.Controls.Add(this.popupControlContainer1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popup Container Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.popupControlContainer1.ResumeLayout(false);
            this.popupControlContainer1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		public static void Main() 
		{
			Application.Run(new Form1());
		}

		#region OpenClosePopup
		private void textBoxPopupParent_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			// Using this unconventional if statement syntax to avoid "and" symbol (documentation restriction, please ignore).

			// If user pressed key down, then show the popup.
			if(e.Alt)
				if(e.KeyCode == Keys.Down)
					if(!this.popupControlContainer1.IsShowing())
					{
						// Let the popup align around the source textBox.
						this.popupControlContainer1.ParentControl = this.sourceTextBox;
						// Passing Point.Empty will align it automatically around the above ParentControl.
						this.popupControlContainer1.ShowPopup(Point.Empty);

						e.Handled = true;
					}
			// Escape should close the popup.
			if(e.KeyCode == Keys.Escape)
				if(this.popupControlContainer1.IsShowing())
					this.popupControlContainer1.HidePopup(PopupCloseType.Canceled);
		}

		private void OK_Click(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.HidePopup(PopupCloseType.Done);
		}

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.HidePopup(PopupCloseType.Canceled);
		}
		#endregion OpenClosePopup
		#region PopupEvents
		private void popupControlContainer1_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// Set the text to be edited with the text in the form text box.
			this.popupTextBox.Text = this.sourceTextBox.Text;
			this.popupControlContainer1.BackColor =Color.FromArgb (227, 241, 254);
		}

		private void popupControlContainer1_Popup(object sender, System.EventArgs e)
		{
			// Set the focus on the text box inside the popup after its open.
			this.popupTextBox.Focus();
			this.popupTextBox.SelectionStart = 0;
			this.popupTextBox.SelectionLength = 0;
		}

		private void popupControlContainer1_CloseUp(object sender, Syncfusion.Windows.Forms.PopupClosedEventArgs args)
		{
			// Transfer data from the popup.
			if(args.PopupCloseType == PopupCloseType.Done)
			{
				this.sourceTextBox.Text = this.popupTextBox.Text;
			}
			// Set focus back to textbox.
			if(args.PopupCloseType == PopupCloseType.Done
				|| args.PopupCloseType == PopupCloseType.Canceled)
				this.sourceTextBox.Focus();
		}
		#endregion PopupEvents
		// </samplecodeblock>
		#region ShowPopup
		private void dropDownBtn_Click(object sender, System.EventArgs e)
		{
			this.popupControlContainer1.ParentControl = this.sourceTextBox;
			this.popupControlContainer1.ShowPopup(Point.Empty);
		}
		#endregion
		private void Form1_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
