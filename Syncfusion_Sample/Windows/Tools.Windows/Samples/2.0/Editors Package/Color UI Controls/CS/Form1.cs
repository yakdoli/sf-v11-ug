using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Tools;

namespace ColorUIDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.TextBox textBox1;
		private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
		private Syncfusion.Windows.Forms.ColorUIControl colorUIControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCustomTabName;
		private System.Windows.Forms.CheckBox chkSelectedAsBackColor;
		private System.Windows.Forms.CheckBox chkSelectedAsText;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup;
		private System.Windows.Forms.TextBox txtStandardTabName;
		private System.Windows.Forms.TextBox txtSystemTabName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtUsersTabName1;
		private System.Windows.Forms.TextBox txtSystemTabName1;
		private System.Windows.Forms.TextBox txtStandardTabName1;
		private System.Windows.Forms.TextBox txtCustomTabName1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbSelectedColorGroup1;
		private System.Windows.Forms.CheckBox chkUserColorsStretchOnResize;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv cmbOffice2007Theme;
		private System.Windows.Forms.CheckBox chkUseOffice2007Theme;
		private Syncfusion.Windows.Forms.ButtonAdv btnShowColorGroups;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt1;
		private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt2;
		private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt3;
		private Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv colorPickerUIAdv1;
        private Label label20;
        private Panel panel3;
		private System.ComponentModel.IContainer components;

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
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.chkSelectedAsText = new System.Windows.Forms.CheckBox();
            this.txtSystemTabName = new System.Windows.Forms.TextBox();
            this.chkSelectedAsBackColor = new System.Windows.Forms.CheckBox();
            this.txtStandardTabName = new System.Windows.Forms.TextBox();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.txtCustomTabName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbSelectedColorGroup = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.chkUserColorsStretchOnResize = new System.Windows.Forms.CheckBox();
            this.txtUsersTabName1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSystemTabName1 = new System.Windows.Forms.TextBox();
            this.txtStandardTabName1 = new System.Windows.Forms.TextBox();
            this.txtCustomTabName1 = new System.Windows.Forms.TextBox();
            this.cmbSelectedColorGroup1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorUIControl1 = new Syncfusion.Windows.Forms.ColorUIControl();
            this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownExt3 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownExt2 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label19 = new System.Windows.Forms.Label();
            this.btnShowColorGroups = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cmbOffice2007Theme = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.chkUseOffice2007Theme = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).BeginInit();
            this.tabPageAdv3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(74, 49);
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 149);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty;
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(172, 195);
            this.colorPickerUIAdv1.TabIndex = 4;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2);
            this.label1.Size = new System.Drawing.Size(452, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 409);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(664, 116);
            this.textBox1.TabIndex = 2;
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabControlAdv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv3);
            this.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 109);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(664, 301);
            this.tabControlAdv1.TabGap = 10;
            this.tabControlAdv1.TabIndex = 3;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.tabPageAdv1.Controls.Add(this.chkSelectedAsText);
            this.tabPageAdv1.Controls.Add(this.txtSystemTabName);
            this.tabPageAdv1.Controls.Add(this.chkSelectedAsBackColor);
            this.tabPageAdv1.Controls.Add(this.txtStandardTabName);
            this.tabPageAdv1.Controls.Add(this.colorPickerButton1);
            this.tabPageAdv1.Controls.Add(this.txtCustomTabName);
            this.tabPageAdv1.Controls.Add(this.label20);
            this.tabPageAdv1.Controls.Add(this.label17);
            this.tabPageAdv1.Controls.Add(this.cmbSelectedColorGroup);
            this.tabPageAdv1.Controls.Add(this.label4);
            this.tabPageAdv1.Controls.Add(this.label9);
            this.tabPageAdv1.Controls.Add(this.label6);
            this.tabPageAdv1.Controls.Add(this.label7);
            this.tabPageAdv1.Controls.Add(this.label8);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(662, 278);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "Color Picker Button";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // chkSelectedAsText
            // 
            this.chkSelectedAsText.AutoSize = true;
            this.chkSelectedAsText.Location = new System.Drawing.Point(353, 182);
            this.chkSelectedAsText.Name = "chkSelectedAsText";
            this.chkSelectedAsText.Size = new System.Drawing.Size(133, 30);
            this.chkSelectedAsText.TabIndex = 7;
            this.chkSelectedAsText.Text = "Set the selected color \r\nname in the button";
            this.chkSelectedAsText.CheckedChanged += new System.EventHandler(this.chkSelectedAsText_CheckedChanged);
            // 
            // txtSystemTabName
            // 
            this.txtSystemTabName.Location = new System.Drawing.Point(164, 219);
            this.txtSystemTabName.Name = "txtSystemTabName";
            this.txtSystemTabName.Size = new System.Drawing.Size(120, 21);
            this.txtSystemTabName.TabIndex = 12;
            this.txtSystemTabName.Text = "System";
            this.txtSystemTabName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSystemTabName_KeyDown);
            // 
            // chkSelectedAsBackColor
            // 
            this.chkSelectedAsBackColor.AutoSize = true;
            this.chkSelectedAsBackColor.Checked = true;
            this.chkSelectedAsBackColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSelectedAsBackColor.Location = new System.Drawing.Point(353, 150);
            this.chkSelectedAsBackColor.Name = "chkSelectedAsBackColor";
            this.chkSelectedAsBackColor.Size = new System.Drawing.Size(173, 17);
            this.chkSelectedAsBackColor.TabIndex = 6;
            this.chkSelectedAsBackColor.Text = "Set selected color as backcolor";
            this.chkSelectedAsBackColor.CheckedChanged += new System.EventHandler(this.chkSelectedAsBackColor_CheckedChanged);
            // 
            // txtStandardTabName
            // 
            this.txtStandardTabName.Location = new System.Drawing.Point(164, 187);
            this.txtStandardTabName.Name = "txtStandardTabName";
            this.txtStandardTabName.Size = new System.Drawing.Size(120, 21);
            this.txtStandardTabName.TabIndex = 11;
            this.txtStandardTabName.Text = "Web";
            this.txtStandardTabName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStandardTabName_KeyDown);
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.ColorGroups = ((Syncfusion.Windows.Forms.ColorUIGroups)((((Syncfusion.Windows.Forms.ColorUIGroups.CustomColors | Syncfusion.Windows.Forms.ColorUIGroups.StandardColors)
                        | Syncfusion.Windows.Forms.ColorUIGroups.SystemColors)
                        | Syncfusion.Windows.Forms.ColorUIGroups.UserColors)));
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colorPickerButton1.Location = new System.Drawing.Point(259, 30);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            this.colorPickerButton1.Size = new System.Drawing.Size(128, 23);
            this.colorPickerButton1.TabIndex = 0;
            this.colorPickerButton1.Text = "Color Picker Button";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // txtCustomTabName
            // 
            this.txtCustomTabName.Location = new System.Drawing.Point(165, 155);
            this.txtCustomTabName.Name = "txtCustomTabName";
            this.txtCustomTabName.Size = new System.Drawing.Size(120, 21);
            this.txtCustomTabName.TabIndex = 10;
            this.txtCustomTabName.Text = "Palette";
            this.txtCustomTabName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomTabName_KeyDown);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(36, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(199, 13);
            this.label20.TabIndex = 3;
            this.label20.Text = "Click the button to show the color picker";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Maroon;
            this.label17.Location = new System.Drawing.Point(36, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "(Press Enter to change tab names)";
            // 
            // cmbSelectedColorGroup
            // 
            this.cmbSelectedColorGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbSelectedColorGroup.IgnoreThemeBackground = true;
            this.cmbSelectedColorGroup.Items.AddRange(new object[] {
            "None",
            "CustomColors",
            "StandardColors",
            "SystemColors",
            "UserColors"});
            this.cmbSelectedColorGroup.Location = new System.Drawing.Point(164, 251);
            this.cmbSelectedColorGroup.Name = "cmbSelectedColorGroup";
            this.cmbSelectedColorGroup.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbSelectedColorGroup.TabIndex = 9;
            this.cmbSelectedColorGroup.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedColorGroup_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(36, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Essential Properties";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Selected Color Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Custom Tab Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Standard Tab Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "System Tab Name";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.tabPageAdv2.Controls.Add(this.panel2);
            this.tabPageAdv2.Controls.Add(this.colorUIControl1);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(662, 278);
            this.tabPageAdv2.TabIndex = 1;
            this.tabPageAdv2.Text = "Color UI Control";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.chkUserColorsStretchOnResize);
            this.panel2.Controls.Add(this.txtUsersTabName1);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtSystemTabName1);
            this.panel2.Controls.Add(this.txtStandardTabName1);
            this.panel2.Controls.Add(this.txtCustomTabName1);
            this.panel2.Controls.Add(this.cmbSelectedColorGroup1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(320, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 240);
            this.panel2.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(133, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "(Press Enter to change tab names)";
            // 
            // chkUserColorsStretchOnResize
            // 
            this.chkUserColorsStretchOnResize.Location = new System.Drawing.Point(80, 208);
            this.chkUserColorsStretchOnResize.Name = "chkUserColorsStretchOnResize";
            this.chkUserColorsStretchOnResize.Size = new System.Drawing.Size(227, 24);
            this.chkUserColorsStretchOnResize.TabIndex = 23;
            this.chkUserColorsStretchOnResize.Text = "Users Color Stretch On Resize";
            this.chkUserColorsStretchOnResize.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtUsersTabName1
            // 
            this.txtUsersTabName1.Location = new System.Drawing.Point(168, 144);
            this.txtUsersTabName1.Name = "txtUsersTabName1";
            this.txtUsersTabName1.Size = new System.Drawing.Size(120, 21);
            this.txtUsersTabName1.TabIndex = 22;
            this.txtUsersTabName1.Text = "User Colors";
            this.txtUsersTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsersTabName1_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(64, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Users Tab Name";
            // 
            // txtSystemTabName1
            // 
            this.txtSystemTabName1.Location = new System.Drawing.Point(168, 112);
            this.txtSystemTabName1.Name = "txtSystemTabName1";
            this.txtSystemTabName1.Size = new System.Drawing.Size(120, 21);
            this.txtSystemTabName1.TabIndex = 20;
            this.txtSystemTabName1.Text = "System";
            this.txtSystemTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSystemTabName1_KeyDown);
            // 
            // txtStandardTabName1
            // 
            this.txtStandardTabName1.Location = new System.Drawing.Point(168, 80);
            this.txtStandardTabName1.Name = "txtStandardTabName1";
            this.txtStandardTabName1.Size = new System.Drawing.Size(120, 21);
            this.txtStandardTabName1.TabIndex = 19;
            this.txtStandardTabName1.Text = "Web";
            this.txtStandardTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStandardTabName1_KeyDown);
            // 
            // txtCustomTabName1
            // 
            this.txtCustomTabName1.Location = new System.Drawing.Point(168, 48);
            this.txtCustomTabName1.Name = "txtCustomTabName1";
            this.txtCustomTabName1.Size = new System.Drawing.Size(120, 21);
            this.txtCustomTabName1.TabIndex = 18;
            this.txtCustomTabName1.Text = "Palette";
            this.txtCustomTabName1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustomTabName1_KeyDown);
            // 
            // cmbSelectedColorGroup1
            // 
            this.cmbSelectedColorGroup1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbSelectedColorGroup1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectedColorGroup1.IgnoreThemeBackground = true;
            this.cmbSelectedColorGroup1.Items.AddRange(new object[] {
            "None",
            "CustomColors",
            "StandardColors",
            "SystemColors",
            "UserColors"});
            this.cmbSelectedColorGroup1.Location = new System.Drawing.Point(168, 176);
            this.cmbSelectedColorGroup1.Name = "cmbSelectedColorGroup1";
            this.cmbSelectedColorGroup1.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectedColorGroup1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbSelectedColorGroup1.TabIndex = 17;
            this.cmbSelectedColorGroup1.Text = "None";
            this.cmbSelectedColorGroup1.SelectedIndexChanged += new System.EventHandler(this.cmbSelectedColorGroup1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Selected Color Group";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "System Tab Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Standard Tab Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Custom Tab Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(8, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Essential Properties";
            // 
            // colorUIControl1
            // 
            this.colorUIControl1.ColorGroups = ((Syncfusion.Windows.Forms.ColorUIGroups)((((Syncfusion.Windows.Forms.ColorUIGroups.CustomColors | Syncfusion.Windows.Forms.ColorUIGroups.StandardColors)
                        | Syncfusion.Windows.Forms.ColorUIGroups.SystemColors)
                        | Syncfusion.Windows.Forms.ColorUIGroups.UserColors)));
            this.colorUIControl1.Location = new System.Drawing.Point(56, 40);
            this.colorUIControl1.Name = "colorUIControl1";
            this.colorUIControl1.SelectedColor = System.Drawing.SystemColors.ControlDarkDark;
            this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
            this.colorUIControl1.Size = new System.Drawing.Size(200, 200);
            this.colorUIControl1.TabIndex = 0;
            this.colorUIControl1.Text = "colorUIControl1";
            this.colorUIControl1.UserTabName = "User Colors";
            this.colorUIControl1.ColorSelected += new System.EventHandler(this.colorUIControl1_ColorSelected);
            // 
            // tabPageAdv3
            // 
            this.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            this.tabPageAdv3.Controls.Add(this.colorPickerUIAdv1);
            this.tabPageAdv3.Controls.Add(this.panel1);
            this.tabPageAdv3.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv3.Name = "tabPageAdv3";
            this.tabPageAdv3.Size = new System.Drawing.Size(662, 278);
            this.tabPageAdv3.TabFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.tabPageAdv3.TabIndex = 2;
            this.tabPageAdv3.Text = "Color Picker UI Adv";
            this.tabPageAdv3.ThemesEnabled = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numericUpDownExt3);
            this.panel1.Controls.Add(this.numericUpDownExt2);
            this.panel1.Controls.Add(this.numericUpDownExt1);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.btnShowColorGroups);
            this.panel1.Controls.Add(this.cmbOffice2007Theme);
            this.panel1.Controls.Add(this.chkUseOffice2007Theme);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(332, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 247);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDownExt3
            // 
            this.numericUpDownExt3.Location = new System.Drawing.Point(164, 182);
            this.numericUpDownExt3.Name = "numericUpDownExt3";
            this.numericUpDownExt3.Size = new System.Drawing.Size(96, 21);
            this.numericUpDownExt3.TabIndex = 12;
            this.numericUpDownExt3.ThemesEnabled = true;
            this.numericUpDownExt3.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownExt3.ValueChanged += new System.EventHandler(this.numericUpDownExt3_ValueChanged);
            // 
            // numericUpDownExt2
            // 
            this.numericUpDownExt2.Location = new System.Drawing.Point(165, 118);
            this.numericUpDownExt2.Name = "numericUpDownExt2";
            this.numericUpDownExt2.Size = new System.Drawing.Size(96, 21);
            this.numericUpDownExt2.TabIndex = 11;
            this.numericUpDownExt2.ThemesEnabled = true;
            this.numericUpDownExt2.ValueChanged += new System.EventHandler(this.numericUpDownExt2_ValueChanged);
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.Location = new System.Drawing.Point(166, 82);
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(96, 21);
            this.numericUpDownExt1.TabIndex = 10;
            this.numericUpDownExt1.ThemesEnabled = true;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownExt1.ValueChanged += new System.EventHandler(this.numericUpDownExt1_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(78, 182);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 9;
            this.label19.Text = "Button Height";
            // 
            // btnShowColorGroups
            // 
            this.btnShowColorGroups.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnShowColorGroups.KeepFocusRectangle = false;
            this.btnShowColorGroups.Location = new System.Drawing.Point(97, 46);
            this.btnShowColorGroups.Name = "btnShowColorGroups";
            this.btnShowColorGroups.Size = new System.Drawing.Size(120, 23);
            this.btnShowColorGroups.TabIndex = 8;
            this.btnShowColorGroups.Text = "Show Color Groups";
            this.btnShowColorGroups.UseVisualStyle = true;
            this.btnShowColorGroups.Click += new System.EventHandler(this.btnShowColorGroups_Click);
            // 
            // cmbOffice2007Theme
            // 
            this.cmbOffice2007Theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.cmbOffice2007Theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOffice2007Theme.IgnoreThemeBackground = true;
            this.cmbOffice2007Theme.Items.AddRange(new object[] {
            "Blue",
            "Black",
            "Silver"});
            this.cmbOffice2007Theme.Location = new System.Drawing.Point(164, 150);
            this.cmbOffice2007Theme.Name = "cmbOffice2007Theme";
            this.cmbOffice2007Theme.Size = new System.Drawing.Size(98, 21);
            this.cmbOffice2007Theme.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.cmbOffice2007Theme.TabIndex = 7;
            this.cmbOffice2007Theme.Text = "Blue";
            this.cmbOffice2007Theme.SelectedIndexChanged += new System.EventHandler(this.cmbOffice2007Theme_SelectedIndexChanged);
            // 
            // chkUseOffice2007Theme
            // 
            this.chkUseOffice2007Theme.AutoSize = true;
            this.chkUseOffice2007Theme.Checked = true;
            this.chkUseOffice2007Theme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseOffice2007Theme.Location = new System.Drawing.Point(94, 214);
            this.chkUseOffice2007Theme.Name = "chkUseOffice2007Theme";
            this.chkUseOffice2007Theme.Size = new System.Drawing.Size(138, 17);
            this.chkUseOffice2007Theme.TabIndex = 4;
            this.chkUseOffice2007Theme.Text = "Use Office 2007 Theme";
            this.chkUseOffice2007Theme.CheckedChanged += new System.EventHandler(this.chkUseOffice2007Theme_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(59, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Office 2007 Theme";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Vertical Spacing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Horizontal Spacing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Essential Properties";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(664, 103);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(664, 525);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControlAdv1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color UI Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSelectedColorGroup1)).EndInit();
            this.tabPageAdv3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice2007Theme)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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

		#region FormLoad

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.cmbSelectedColorGroup.SelectedIndex=0;
			this.cmbOffice2007Theme.SelectedIndex=0;
			this.cmbSelectedColorGroup1.SelectedIndex=0;
		}

		#endregion

		#region EventLog

		private void Addlog(string logText)
		{
			this.textBox1.Text += logText +"\r\n";
		}
		#endregion

		#region ColorPickerButton Properties

		private void txtCustomTabName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorPickerButton1.CustomTabName = this.txtCustomTabName.Text;
				Addlog("ColorPickerButton Custom Tab Name Changed to "+this.txtCustomTabName.Text);
			}
		}

		private void txtStandardTabName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorPickerButton1.StandardTabName = this.txtStandardTabName.Text;
				Addlog("ColorPickerButton Standard Tab Name Changed to "+this.txtStandardTabName.Text);
			}
		}

		private void txtSystemTabName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorPickerButton1.SystemTabName= this.txtSystemTabName.Text;
				Addlog("ColorPickerButton System Tab Name Changed to "+this.txtSystemTabName.Text);
			}
		}

		private void cmbSelectedColorGroup_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.colorPickerButton1.SelectedColor = Color.Empty;
			switch(this.cmbSelectedColorGroup.Text)
			{
				case "None":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
					break;
				case "CustomColors":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
					break;
				case "StandardColors":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
					break;
				case "SystemColors":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.SystemColors;
					break;
				case "UserColors":
					this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.UserColors;
					break;
			}
            this.colorPickerButton1.SelectedColor = Color.Empty;
			Addlog("ColorPickerButton's SelectedColorGroup changed to "+this.cmbSelectedColorGroup.Text);
		}

		private void chkSelectedAsBackColor_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorPickerButton1.SelectedAsBackcolor = this.chkSelectedAsBackColor.Checked;
			Addlog("ColorPickerButton's \"SelectedAsBackcolor\" set to "+this.chkSelectedAsBackColor.Checked.ToString());
		}

		private void chkSelectedAsText_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorPickerButton1.SelectedAsText = this.chkSelectedAsText.Checked;
			Addlog("ColorPickerButton's \"SelectedAsText\" set to "+this.chkSelectedAsText.Checked.ToString());
		}

		private void colorPickerButton1_ColorSelected(object sender, System.EventArgs e)
		{
			this.tabPageAdv1.BackColor = this.colorPickerButton1.SelectedColor;
			Addlog("ColorPickerButton sets TabPage BackColor to "+this.colorPickerButton1.SelectedColor.ToString());
		}

		#endregion

		#region ColorUIControl Properties

		private void colorUIControl1_ColorSelected(object sender, System.EventArgs e)
		{
			this.tabPageAdv2.BackColor = this.colorUIControl1.SelectedColor;
			Addlog("ColorUIControl sets TabPage BackColor to "+this.colorUIControl1.SelectedColor.ToString());
		}

		private void cmbSelectedColorGroup1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(this.cmbSelectedColorGroup1.Text)
			{
				case "None":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
					break;
				case "CustomColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors;
					break;
				case "StandardColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
					break;
				case "SystemColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.SystemColors;
					break;
				case "UserColors":
					this.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.UserColors;
					break;
			}
			Addlog("ColorUIControl's Selected Color Group changed to "+this.cmbSelectedColorGroup1.Text);
		}

		private void txtCustomTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.CustomTabName = this.txtCustomTabName1.Text;
				Addlog("ColorUIControl's Custom Tab Name changed to "+this.txtCustomTabName1.Text);
			}
		}

		private void txtStandardTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.StandardTabName = this.txtStandardTabName1.Text;
				Addlog("ColorUIControl's Standard Tab Name changed to "+this.txtStandardTabName.Text);
			}
		}

		private void txtSystemTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.SystemTabName = this.txtSystemTabName1.Text;
				Addlog("ColorUIControl's System Tab Name changed to "+this.txtSystemTabName1.Text);
			}
		}

		private void txtUsersTabName1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				this.colorUIControl1.UserTabName = this.txtUsersTabName1.Text;
				Addlog("ColorUIControl's User Tab Name changed to "+this.txtUsersTabName1.Text);
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
            this.colorUIControl1.CustomColorsStretchOnResize = this.chkUserColorsStretchOnResize.Checked;
			this.colorUIControl1.UserColorsStretchOnResize = this.chkUserColorsStretchOnResize.Checked;
		}

		#endregion

		#region ColorPickerUIAdv properties


		private void cmbOffice2007Theme_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(this.cmbOffice2007Theme.Text)
			{
				case "Blue":
					this.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
					break;
				case "Black":
					this.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Black;
					break;
				case "Silver":
					this.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
					break;
			}
			Addlog("ColorPickerUIAdv's Office2007Theme set to "+this.colorPickerUIAdv1.Office2007Theme.ToString());
		}

		private void chkUseOffice2007Theme_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.UseOffice2007Style = this.chkUseOffice2007Theme.Checked;
			Addlog("ColorPickerUIAdv's UseOffice2007Style is set to "+this.chkUseOffice2007Theme.Checked.ToString());
		}

		private void btnShowColorGroups_Click(object sender, System.EventArgs e)
		{
			new ColorGroup(this.colorPickerUIAdv1).ShowDialog();
            this.Refresh();
		}


		private void numericUpDownExt1_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.HorizontalItemsSpacing = (int)this.numericUpDownExt1.Value;
			Addlog("ColorPickerUIAdv's HorizontalItemsSpacing set to "+this.numericUpDownExt1.Value.ToString());
		}

		private void numericUpDownExt2_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.VerticalItemsSpacing = (int)this.numericUpDownExt2.Value;
			Addlog("ColorPickerUIAdv's VerticalItemsSpacing set to "+this.numericUpDownExt2.Value.ToString());
		}

		private void numericUpDownExt3_ValueChanged(object sender, System.EventArgs e)
		{
			this.colorPickerUIAdv1.ButtonsHeight = (int)this.numericUpDownExt3.Value;
			Addlog("ColorPickerUIAdv's ButtonsHeight set to "+this.numericUpDownExt3.Value.ToString());
		}

		private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
		{
			this.tabPageAdv3.BackColor = this.colorPickerUIAdv1.SelectedItem.Color;
			Addlog("ColorPickerUIAdv is Setting TabPage BackColor to "+this.colorPickerUIAdv1.SelectedItem.Color.ToString());
		}

        #endregion

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
