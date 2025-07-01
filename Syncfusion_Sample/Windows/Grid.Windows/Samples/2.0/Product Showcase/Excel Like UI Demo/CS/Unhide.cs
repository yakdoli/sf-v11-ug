using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace ExcelLikeUI_2005
{
	/// <summary>
	/// Summary description for Unhide.
	/// </summary>
	public class Unhide : Office2007Form
	{
		private ButtonAdv okButton;
		private ButtonAdv cancelButton;
		internal System.Windows.Forms.ListBox sheetListBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Unhide()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            this.AcceptButton.DialogResult = DialogResult.OK;

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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.sheetListBox = new System.Windows.Forms.ListBox();
            this.okButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cancelButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SuspendLayout();
            // 
            // sheetListBox
            // 
            this.sheetListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sheetListBox.Location = new System.Drawing.Point(8, 16);
            this.sheetListBox.Name = "sheetListBox";
            this.sheetListBox.Size = new System.Drawing.Size(216, 108);
            this.sheetListBox.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(45, 147);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyle = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(149, 147);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyle = true;
            // 
            // Unhide
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(236, 182);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sheetListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(248, 248);
            this.MinimizeBox = false;
            this.Name = "Unhide";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unhide";
            this.ResumeLayout(false);

		}
		#endregion
	}
}
