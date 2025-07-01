using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace FindReplaceDemo
{
	/// <summary>
	/// Summary description for History.
	/// </summary>
	public class AddToHistoryDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtaddedItem;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button BtnCancel;
	
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddToHistoryDlg()
		{		
			InitializeComponent();

            this.AcceptButton.DialogResult = DialogResult.OK;
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddedItem = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Item";
            // 
            // txtaddedItem
            // 
            this.txtaddedItem.Location = new System.Drawing.Point(96, 22);
            this.txtaddedItem.Name = "txtaddedItem";
            this.txtaddedItem.Size = new System.Drawing.Size(192, 20);
            this.txtaddedItem.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(40, 64);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Add";
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(192, 64);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // AddToHistoryDlg
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(312, 102);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtaddedItem);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "AddToHistoryDlg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


        private void BtnCancel_Click(object sender, System.EventArgs e)
		{
			return;
		}
	
		public string addedItem
		{
			get
			{
				return this.txtaddedItem.Text;
			}
		}
	}
}
