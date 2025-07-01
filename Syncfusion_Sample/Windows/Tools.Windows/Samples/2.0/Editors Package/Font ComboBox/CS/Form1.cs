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

namespace FontComboBoxDemo
{
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel groupBox3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox chkAutocomp;
		private Syncfusion.Windows.Forms.Tools.FontComboBox fontComboBox2;
		private System.Windows.Forms.ImageList imageList2;
		private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
		private System.Windows.Forms.Panel groupBox1;
		private Syncfusion.Windows.Forms.Tools.FontComboBox fontComboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel groupBox2;
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.BannerTextProvider bannerTextProvider1;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit bannerClrEdit;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Button btnSetBanner;
        private ComboBox cmbMode;
        private TextBox txtBanner;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private ColorDialog colorDialog1;
        private Label label10;
        private ToolTip toolTip1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			InitializeComponent();
            cmbMode.SelectedIndex = 1;
            Application.Idle += new EventHandler(Application_Idle);
		}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.bannerClrEdit = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.btnSetBanner = new System.Windows.Forms.Button();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.txtBanner = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chkAutocomp = new System.Windows.Forms.CheckBox();
            this.fontComboBox2 = new Syncfusion.Windows.Forms.Tools.FontComboBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.groupBox1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontComboBox1 = new Syncfusion.Windows.Forms.Tools.FontComboBox();
            this.groupBox2 = new System.Windows.Forms.Panel();
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).BeginInit();
            this.bannerClrEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(208)))), ((int)(((byte)(227)))));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.bannerClrEdit);
            this.groupBox3.Controls.Add(this.btnSetBanner);
            this.groupBox3.Controls.Add(this.cmbMode);
            this.groupBox3.Controls.Add(this.txtBanner);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.chkAutocomp);
            this.groupBox3.Controls.Add(this.fontComboBox2);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(265, 285);
            this.groupBox3.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(129, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 26);
            this.label10.TabIndex = 2;
            this.toolTip1.SetToolTip(this.label10, "Banner Text is used to provide\r\ncue banner help text for\r\nFontComboBox control.");
            // 
            // bannerClrEdit
            // 
            this.bannerClrEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bannerClrEdit.Buttons.Add(this.buttonEditChildButton1);
            this.bannerClrEdit.Controls.Add(this.buttonEditChildButton1);
            this.bannerClrEdit.Controls.Add(this.textBoxExt2);
            this.bannerClrEdit.Location = new System.Drawing.Point(44, 250);
            this.bannerClrEdit.Name = "bannerClrEdit";
            this.bannerClrEdit.Size = new System.Drawing.Size(86, 22);
            this.bannerClrEdit.TabIndex = 14;
            this.bannerClrEdit.TextBox = this.textBoxExt2;
            this.bannerClrEdit.UseVisualStyle = true;
            this.bannerClrEdit.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.bannerClrEdit_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(62, 14);
            this.textBoxExt2.TabIndex = 0;
            // 
            // btnSetBanner
            // 
            this.btnSetBanner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSetBanner.Location = new System.Drawing.Point(144, 250);
            this.btnSetBanner.Name = "btnSetBanner";
            this.btnSetBanner.Size = new System.Drawing.Size(103, 23);
            this.btnSetBanner.TabIndex = 13;
            this.btnSetBanner.Text = "Set Banner Text";
            this.btnSetBanner.UseVisualStyleBackColor = true;
            this.btnSetBanner.Click += new System.EventHandler(this.btnSetBanner_Click);
            // 
            // cmbMode
            // 
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "EditMode",
            "FocusMode"});
            this.cmbMode.Location = new System.Drawing.Point(171, 215);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(91, 21);
            this.cmbMode.TabIndex = 12;
            // 
            // txtBanner
            // 
            this.txtBanner.Location = new System.Drawing.Point(44, 215);
            this.txtBanner.Name = "txtBanner";
            this.txtBanner.Size = new System.Drawing.Size(86, 21);
            this.txtBanner.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Mode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(7, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "BannerText Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(7, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Another FontComboBox ";
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(128, 109);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "DropDownList";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 109);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "DropDown";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "No. of Items to Show:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 75);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(56, 21);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // chkAutocomp
            // 
            this.chkAutocomp.Checked = true;
            this.chkAutocomp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutocomp.Location = new System.Drawing.Point(51, 140);
            this.chkAutocomp.Name = "chkAutocomp";
            this.chkAutocomp.Size = new System.Drawing.Size(128, 24);
            this.chkAutocomp.TabIndex = 1;
            this.chkAutocomp.Text = "Use Auto Complete";
            this.chkAutocomp.CheckedChanged += new System.EventHandler(this.chkAutocomp_CheckedChanged);
            // 
            // fontComboBox2
            // 
            this.bannerTextProvider1.SetBannerText(this.fontComboBox2, new Syncfusion.Windows.Forms.BannerTextInfo("[Select]", true, null, System.Drawing.SystemColors.ControlDark, Syncfusion.Windows.Forms.BannerTextMode.FocusMode));
            this.fontComboBox2.Location = new System.Drawing.Point(4, 32);
            this.fontComboBox2.MaxDropDownItems = 25;
            this.fontComboBox2.Name = "fontComboBox2";
            this.fontComboBox2.Size = new System.Drawing.Size(248, 22);
            this.fontComboBox2.Sorted = true;
            this.fontComboBox2.TabIndex = 0;
            this.fontComboBox2.UseAutoComplete = true;
            this.fontComboBox2.SelectedIndexChanged += new System.EventHandler(this.fontComboBox2_SelectedIndexChanged);
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxExt1.Location = new System.Drawing.Point(24, 152);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(204, 21);
            this.textBoxExt1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(208)))), ((int)(((byte)(227)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fontComboBox1);
            this.groupBox1.Controls.Add(this.textBoxExt1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(300, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 285);
            this.groupBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Name of The Selected Font";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(14, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "FontComboBox with all installed System Fonts";
            // 
            // fontComboBox1
            // 
            this.fontComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox1.Location = new System.Drawing.Point(16, 80);
            this.fontComboBox1.Name = "fontComboBox1";
            this.fontComboBox1.Size = new System.Drawing.Size(248, 22);
            this.fontComboBox1.TabIndex = 0;
            this.fontComboBox1.SelectedIndexChanged += new System.EventHandler(this.fontComboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.groupBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 80);
            this.groupBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(584, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font ComboBox ";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bannerClrEdit)).EndInit();
            this.bannerClrEdit.ResumeLayout(false);
            this.bannerClrEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	
		#region SelectedIndexChanged
		private void fontComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.textBoxExt1.Text = this.fontComboBox1.SelectedItem.ToString ();
			this.label2.Font = new Font(this.fontComboBox1.SelectedItem.ToString (),11,FontStyle.Regular  );
			this.fontComboBox2.SelectedItem = this.fontComboBox1.SelectedItem;
		}

		private void fontComboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.textBoxExt1.Text = this.fontComboBox2.SelectedItem.ToString ();
			this.label2.Font = new Font(this.fontComboBox2.SelectedItem.ToString (),11,FontStyle.Regular  );
			this.fontComboBox1.SelectedItem = this.fontComboBox2.SelectedItem;
		}
		#endregion

		private void chkAutocomp_CheckedChanged(object sender, System.EventArgs e)
		{
			this.fontComboBox2.UseAutoComplete = chkAutocomp.Checked;
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			this.fontComboBox2.MaxDropDownItems = (int)numericUpDown1.Value;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			this.fontComboBox2.DropDownStyle = ComboBoxStyle.DropDown ;
            this.bannerTextProvider1.GetBannerText(this.fontComboBox2).Visible = true;
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
			this.fontComboBox2.DropDownStyle = ComboBoxStyle.DropDownList ;
            this.bannerTextProvider1.GetBannerText(this.fontComboBox2).Visible = false;
		}

        void Application_Idle(object sender, EventArgs e)
        {
            if (txtBanner.Text == "")
                btnSetBanner.Enabled = false;
            else
                btnSetBanner.Enabled = true;
        }

        private void bannerClrEdit_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                bannerClrEdit.TextBox.BackColor = colorDialog1.Color;
        }

        private void btnSetBanner_Click(object sender, EventArgs e)
        {
            BannerTextMode mode = (BannerTextMode)Enum.Parse(typeof(BannerTextMode), cmbMode.SelectedItem.ToString());
            BannerTextInfo binfo = this.bannerTextProvider1.GetBannerText(this.fontComboBox2);
            binfo.Text = txtBanner.Text;
            binfo.Mode = mode;
            binfo.Color = bannerClrEdit.TextBox.BackColor;
            this.fontComboBox2.Refresh();
        }
	}
}
