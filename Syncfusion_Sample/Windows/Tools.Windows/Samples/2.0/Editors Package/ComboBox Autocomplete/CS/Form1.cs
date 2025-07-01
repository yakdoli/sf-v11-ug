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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace ComboBoxAutoCompleteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private ArrayList itemsList = new ArrayList();
		private ArrayList alphaList = new ArrayList();
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.GroupBox groupBox1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete comboBoxAutoComplete1;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this.comboBoxAutoComplete1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAutoComplete();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.comboBoxAutoComplete1.AutoCompleteControl)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBoxAutoComplete1
			// 
			// 
			// comboBoxAutoComplete1.AutoCompleteControl
			// 
			this.comboBoxAutoComplete1.AutoCompleteControl.AccessibleDescription = null;
			this.comboBoxAutoComplete1.AutoCompleteControl.AccessibleName = null;
			this.comboBoxAutoComplete1.AutoCompleteControl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.comboBoxAutoComplete1.AutoCompleteControl.AdjustHeightToItemCount = true;
			this.comboBoxAutoComplete1.AutoCompleteControl.AutoAddItem = false;
			this.comboBoxAutoComplete1.AutoCompleteControl.AutoSerialize = true;
			this.comboBoxAutoComplete1.AutoCompleteControl.CategoryName = "";
			this.comboBoxAutoComplete1.AutoCompleteControl.ChangeDataManagerPosition = true;
			this.comboBoxAutoComplete1.AutoCompleteControl.OverrideCombo = true;
			this.comboBoxAutoComplete1.AutoCompleteControl.ParentForm = this.groupBox1;
			this.comboBoxAutoComplete1.AutoCompleteControl.PreferredHeight = 200;
			this.comboBoxAutoComplete1.AutoCompleteControl.SelectedIndex = -1;
			this.comboBoxAutoComplete1.AutoCompleteControl.SelectedValue = "";
			this.comboBoxAutoComplete1.AutoCompleteControl.ShowCloseButton = true;
			this.comboBoxAutoComplete1.AutoCompleteControl.ShowGripper = true;
            this.comboBoxAutoComplete1.DropDownWidth = this.comboBoxAutoComplete1.Width;
			this.comboBoxAutoComplete1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.comboBoxAutoComplete1.ItemHeight = 13;
			this.comboBoxAutoComplete1.Location = new System.Drawing.Point(64, 136);
			this.comboBoxAutoComplete1.Name = "comboBoxAutoComplete1";
			this.comboBoxAutoComplete1.ParentForm = this.groupBox1;
			this.comboBoxAutoComplete1.Size = new System.Drawing.Size(240, 21);
			this.comboBoxAutoComplete1.TabIndex = 4;
			this.comboBoxAutoComplete1.UpdateComboSelectionProperties = true;
			
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label1,
																					this.comboBoxAutoComplete1});
			this.groupBox1.Location = new System.Drawing.Point(88, 48);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(376, 216);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Image = ((System.Drawing.Bitmap)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
			this.label1.ImageIndex = 0;
			this.label1.ImageList = this.imageList1;
			this.label1.Location = new System.Drawing.Point(64, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 80);
			this.label1.TabIndex = 5;
			this.label1.Text = "The ComboBoxAutoComplete control combines a combo box control with an AutoComplet" +
				"e control to provide autocompletion for that instance of the combo box.";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(32, 32);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(200)), ((System.Byte)(219)));
			this.ClientSize = new System.Drawing.Size(552, 374);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComboBox AutoComplete";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.comboBoxAutoComplete1.AutoCompleteControl)).EndInit();
			this.groupBox1.ResumeLayout(false);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			#region DataSource 
			this.alphaList.AddRange(new String[]{"A",
												"B",
												"C",
												"D",
												"E",
												"F",
												"G",
												"H",
												"I",
												"J",
												"K",
												"L",
												"M",
												"N",
												"O",
												"P",
												"Q",
												"R",
												"S",
												"T",
												"U",
												"V",
												"W",
												"X",
												"Y",
												"Z"
			});

			foreach(string s in this.alphaList)
			{
				for(int i = 0; i < 15; i++)
				{
					this.itemsList.Add(s + i.ToString());
				}
			}

			this.comboBoxAutoComplete1.AutoCompleteControl.DataSource = this.itemsList;
            this.comboBoxAutoComplete1.DropDownWidth = this.comboBoxAutoComplete1.Width;
			#endregion
		}

		

	}
}
