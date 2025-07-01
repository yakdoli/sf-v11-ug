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
using System.IO;

namespace BreakPointDemo
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class CustomizeForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.Label label1;
		private string imagePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Glyphs\breakpoint";
        static int i = 0;
		RadioButton activeRB;
		Image image;
private RadioButton radioButton7;
		ListViewItem activeLVI;

		public event EventHandler Accepted;

		public CustomizeForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			PopulateImageList();

			AssociateImages();

			ColorRadioButtons ();

			this.activeRB = this.radioButton4;
			this.activeRB.Checked = true;
			
			activeLVI = this.listView1.Items[2];
			image = this.imageList1.Images[activeLVI.ImageIndex];

			this.label1.Text = "Select the desired backcolor and indicator image for the breakpoint";
		}


		
		private void PopulateImageList()
		{
int i = 0;
			for (i=1; i<=8; i++)
			{
				Bitmap bmp = new Bitmap(imagePath + i.ToString() + ".png");
				this.imageList1.Images.Add(bmp);
			}
		}

		private void AssociateImages()
		{
			this.listView1.SmallImageList = this.imageList1;
			int index=0;
			foreach(ListViewItem lvi in this.listView1.Items)
			{				
				lvi.ImageIndex = index;
				index++;
			}
		}

		private void ColorRadioButtons()
		{
			foreach (Control ctrl in this.groupBox1.Controls)
			{
				RadioButton rb = (RadioButton)ctrl;

				switch (rb.Text)
				{
					case "Light Olive":
						rb.BackColor = ColorTranslator.FromHtml("#85BF75");
						break;
					case "Dark Orange":
						rb.BackColor = ColorTranslator.FromHtml("#DE6413");
						break;
					case "Dull Aqua":
						rb.BackColor = ColorTranslator.FromHtml("#B4E7F2");
						break;
					case "Bright Orange":
						rb.BackColor = ColorTranslator.FromHtml("#FFBF34");
						break;
					case "Light Blue":
						rb.BackColor = ColorTranslator.FromHtml("#DAE5F5");
						break;
					case "Violet":
						rb.BackColor = ColorTranslator.FromHtml("#333365");
						break;
case "Maroon":
                        rb.BackColor = Color.FromArgb(148, 56, 66);
                        break;
				}
			}
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Image1"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Image2"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Image3"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Image4"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Image5"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Image6"}, -1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Image7");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Image8");
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(24, 56);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(208, 168);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(19, 19);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(24, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Light Olive";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(24, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Dark Orange";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(24, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Dull Aqua";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.Location = new System.Drawing.Point(24, 96);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 24);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Bright Orange";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Location = new System.Drawing.Point(24, 120);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(104, 24);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "Light Blue";
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(248, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // radioButton7
            // 
            this.radioButton7.Location = new System.Drawing.Point(24, 167);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(104, 24);
            this.radioButton7.TabIndex = 7;
            this.radioButton7.Text = "Maroon";
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.ForeColor = System.Drawing.Color.White;
            this.radioButton6.Location = new System.Drawing.Point(24, 144);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(104, 24);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Text = "Violet";
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButtonCheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(40, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(136, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomizeForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(410, 264);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CustomizeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BreakPoint Customization Editor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		// Close customize form on Cancel button click
		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		// Raise Accepted event on OK button click
		private void button1_Click(object sender, System.EventArgs e)
		{
			if(this.Accepted != null)
				this.Accepted(this,EventArgs.Empty);

			this.Close();
		}

		private void radioButtonCheckedChanged(object sender, System.EventArgs e)
		{
			activeRB = sender as RadioButton;
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			foreach (ListViewItem lvi in this.listView1.Items)
			{
				if (lvi.Selected == true)
				{
					activeLVI = lvi;
                    i = lvi.ImageIndex;
					break;
				}
			}
		}

		// Returns the selected color
		public new Color BackColor
		{ 
			get
			{
				return activeRB.BackColor;
			}
		}

		// Returns the selected image
		public Image Image
		{
			get
			{
				image = this.imageList1.Images[i];
				return image;
			}
		}
	}
}
