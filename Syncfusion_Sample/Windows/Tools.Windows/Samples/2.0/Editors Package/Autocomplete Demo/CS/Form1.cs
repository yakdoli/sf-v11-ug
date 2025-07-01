using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace AutoCompleteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
    {
        private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.TextBox textBox1;
		private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete1;
		private System.Windows.Forms.Label label3;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBoxAdv1;
        private System.Windows.Forms.ImageList imageList2;
		private Syncfusion.Windows.Forms.Tools.AutoComplete autoComplete2;
		private AutoCompleteDemo.Websites websites1;
		internal System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.ImageList imageList3;
		private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo1;
		private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo2;
        private Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo autoCompleteDataColumnInfo3;
        private ComboBoxAdv comboBoxAdv2;
        private Label label6;
        private Label label2;
        private Label label10;
        internal Label label12;
        internal Label label11;
        private Label label1;
        private Label label4;
        private GradientPanel gradientPanel2;
        private Label label15;
        private GradientPanel gradientPanel1;
        private Label label40;
        private Label label14;
        private Label label13;
        private Label label7;
        private Label label24;
        private ToolTip toolTip1;
        internal Label label9;
        internal Label label8;
        private TextBox textBox6;
        private AutoLabel autoLabel1;
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxAdv1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.autoComplete1 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.comboBoxAdv2 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.autoCompleteDataColumnInfo1 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("URL", 100, true);
            this.autoCompleteDataColumnInfo2 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("Name", 100, true);
            this.autoCompleteDataColumnInfo3 = new Syncfusion.Windows.Forms.Tools.AutoCompleteDataColumnInfo("ImageIndex", 100, true);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label40 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.autoComplete2 = new Syncfusion.Windows.Forms.Tools.AutoComplete(this.components);
            this.websites1 = new AutoCompleteDemo.Websites();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.websites1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // comboBoxAdv1
            // 
            this.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv1.IgnoreThemeBackground = true;
            this.comboBoxAdv1.Items.AddRange(new object[] {
            "Disabled",
            "AutoSuggest",
            "AutoAppend",
            "Both"});
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Disabled"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "AutoSuggest"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "AutoAppend"));
            this.comboBoxAdv1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv1, "Both"));
            this.comboBoxAdv1.Location = new System.Drawing.Point(158, 102);
            this.comboBoxAdv1.Name = "comboBoxAdv1";
            this.comboBoxAdv1.Size = new System.Drawing.Size(134, 21);
            this.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboBoxAdv1.TabIndex = 10;
            this.comboBoxAdv1.Text = "Disabled";
            this.comboBoxAdv1.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set AutoComplete Mode:";
            // 
            // textBox3
            // 
            this.autoComplete1.SetAutoComplete(this.textBox3, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both);
            this.autoComplete2.SetAutoComplete(this.textBox3, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.textBox3.Location = new System.Drawing.Point(432, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(185, 21);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.autoComplete1.SetAutoComplete(this.textBox2, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both);
            this.autoComplete2.SetAutoComplete(this.textBox2, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.textBox2.Location = new System.Drawing.Point(223, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 21);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.autoComplete1.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
            this.autoComplete2.SetAutoComplete(this.textBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(14, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 21);
            this.textBox1.TabIndex = 6;
            // 
            // autoComplete1
            // 
            this.autoComplete1.AccessibleDescription = null;
            this.autoComplete1.AccessibleName = null;
            this.autoComplete1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.autoComplete1.AdjustHeightToItemCount = true;
            this.autoComplete1.AutoAddItem = true;
            this.autoComplete1.AutoSerialize = true;
            this.autoComplete1.CategoryName = "";
            this.autoComplete1.ParentForm = this;
            this.autoComplete1.PreferredHeight = 200;
            this.autoComplete1.SelectedIndex = -1;
            this.autoComplete1.SelectedValue = "";
            this.autoComplete1.ShowCloseButton = true;
            this.autoComplete1.ShowGripper = true;
            this.autoComplete1.AutoCompleteItemBrowsed += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemBrowsed);
            this.autoComplete1.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemSelected);
            // 
            // textBox5
            // 
            this.autoComplete1.SetAutoComplete(this.textBox5, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.autoComplete2.SetAutoComplete(this.textBox5, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.textBox5.Location = new System.Drawing.Point(14, 426);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(608, 110);
            this.textBox5.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.autoComplete1.SetAutoComplete(this.comboBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.autoComplete2.SetAutoComplete(this.comboBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.comboBox1.Location = new System.Drawing.Point(78, 326);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(544, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // textBox4
            // 
            this.autoComplete1.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.autoComplete2.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
            this.textBox4.Location = new System.Drawing.Point(78, 353);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(544, 21);
            this.textBox4.TabIndex = 17;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            // 
            // comboBoxAdv2
            // 
            this.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdv2.IgnoreThemeBackground = true;
            this.comboBoxAdv2.Items.AddRange(new object[] {
            "MultiSuggest",
            "MultiSuggestExtended"});
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "MultiSuggest"));
            this.comboBoxAdv2.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBoxAdv2, "MultiSuggestExtended"));
            this.comboBoxAdv2.Location = new System.Drawing.Point(158, 299);
            this.comboBoxAdv2.Name = "comboBoxAdv2";
            this.comboBoxAdv2.Size = new System.Drawing.Size(134, 21);
            this.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.comboBoxAdv2.TabIndex = 13;
            this.comboBoxAdv2.Text = "MultiSuggestExtended";
            this.comboBoxAdv2.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdv2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "TextBox1";
            // 
            // autoCompleteDataColumnInfo1
            // 
            this.autoCompleteDataColumnInfo1.ColumnHeaderText = "URL";
            this.autoCompleteDataColumnInfo1.ImageColumn = false;
            this.autoCompleteDataColumnInfo1.MatchingColumn = true;
            this.autoCompleteDataColumnInfo1.Visible = true;
            // 
            // autoCompleteDataColumnInfo2
            // 
            this.autoCompleteDataColumnInfo2.ColumnHeaderText = "Name";
            this.autoCompleteDataColumnInfo2.ImageColumn = false;
            this.autoCompleteDataColumnInfo2.MatchingColumn = false;
            this.autoCompleteDataColumnInfo2.Visible = true;
            // 
            // autoCompleteDataColumnInfo3
            // 
            this.autoCompleteDataColumnInfo3.ColumnHeaderText = "ImageIndex";
            this.autoCompleteDataColumnInfo3.ImageColumn = true;
            this.autoCompleteDataColumnInfo3.MatchingColumn = false;
            this.autoCompleteDataColumnInfo3.Visible = true;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            this.imageList3.Images.SetKeyName(2, "");
            this.imageList3.Images.SetKeyName(3, "");
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(14, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "UnBounded DataSource";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(14, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bounded DataSource";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Set AutoComplete Mode:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(223, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "TextBox2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(432, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "TextBox3";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label13.Location = new System.Drawing.Point(168, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(451, 2);
            this.label13.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label14.Location = new System.Drawing.Point(181, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(438, 1);
            this.label14.TabIndex = 25;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label40);
            this.gradientPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(14, 34);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(608, 49);
            this.gradientPanel1.TabIndex = 26;
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label40.Image = ((System.Drawing.Image)(resources.GetObject("label40.Image")));
            this.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label40.Location = new System.Drawing.Point(0, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(606, 47);
            this.label40.TabIndex = 1;
            this.label40.Text = resources.GetString("label40.Text");
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.label15);
            this.gradientPanel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel2.Location = new System.Drawing.Point(14, 232);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(608, 49);
            this.gradientPanel2.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(606, 47);
            this.label15.TabIndex = 1;
            this.label15.Text = "The DataSource for this AutoComplete control is set to an XML Datasource. Enter h" +
                " to view the autocomplete. ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(106, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 1);
            this.label1.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(14, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "Event Log";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(308, 299);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 20);
            this.label24.TabIndex = 30;
            this.toolTip1.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(308, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 20);
            this.label7.TabIndex = 31;
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // autoComplete2
            // 
            this.autoComplete2.AccessibleDescription = null;
            this.autoComplete2.AccessibleName = null;
            this.autoComplete2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.autoComplete2.AdjustHeightToItemCount = false;
            this.autoComplete2.AutoAddItem = false;
            this.autoComplete2.AutoSerialize = true;
            this.autoComplete2.CategoryName = "";
            this.autoComplete2.Columns.Add(this.autoCompleteDataColumnInfo1);
            this.autoComplete2.Columns.Add(this.autoCompleteDataColumnInfo2);
            this.autoComplete2.Columns.Add(this.autoCompleteDataColumnInfo3);
            this.autoComplete2.DataSource = this.websites1.Website;
            this.autoComplete2.ImageList = this.imageList3;
            this.autoComplete2.ParentForm = this;
            this.autoComplete2.PreferredHeight = 200;
            this.autoComplete2.SelectedIndex = -1;
            this.autoComplete2.SelectedValue = "";
            this.autoComplete2.ShowCloseButton = true;
            this.autoComplete2.ShowColumnHeader = true;
            this.autoComplete2.ShowGripper = true;
            this.autoComplete2.AutoCompleteItemBrowsed += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemBrowsed);
            this.autoComplete2.AutoCompleteItemSelected += new Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventHandler(this.autoComplete_AutoCompleteItemSelected);
            // 
            // websites1
            // 
            this.websites1.DataSetName = "Websites";
            this.websites1.EnforceConstraints = false;
            this.websites1.Locale = new System.Globalization.CultureInfo("en-US");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "ComboBox";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "TextBox";
            // 
            // autoLabel1
            // 
            this.autoLabel1.Location = new System.Drawing.Point(426, 103);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(127, 13);
            this.autoLabel1.TabIndex = 34;
            this.autoLabel1.Text = "Number Of Suggestions :";
            // 
            // textBox6
            // 
            this.autoComplete1.SetAutoComplete(this.textBox6, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.autoComplete2.SetAutoComplete(this.textBox6, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
            this.textBox6.Location = new System.Drawing.Point(553, 103);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(65, 21);
            this.textBox6.TabIndex = 35;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(641, 545);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxAdv2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxAdv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autocomplete Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.autoComplete2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.websites1)).EndInit();
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

		private void comboBoxAdv1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SetAutoCompleteMode(this.comboBoxAdv1.Text);
			AddLog("AutoCompleteMode set to "+this.comboBoxAdv1.Text);
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.comboBoxAdv1.SelectedIndex = 3;
            this.comboBoxAdv2.SelectedIndex = 1;

            string filename = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\websites.xml";
            this.websites1.ReadXml(filename);

            if (this.autoComplete2.TableData.Rows.Count <= 0)
                this.autoComplete2.SetTableData();
            else
                this.autoComplete2.DataSource = null;
            
		}

       

		private void SetAutoCompleteMode(string mode)
		{
			if(mode !="")
			{
				switch(mode)
				{
					case "Disabled":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
						this.autoComplete1.SetAutoComplete(this.textBox2,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
						this.autoComplete1.SetAutoComplete(this.textBox3,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Disabled);
						break;
					case "AutoSuggest":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
						this.autoComplete1.SetAutoComplete(this.textBox2,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
						this.autoComplete1.SetAutoComplete(this.textBox3,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoSuggest);
						break;
					case "AutoAppend":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoAppend);
						this.autoComplete1.SetAutoComplete(this.textBox2,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoAppend);
						this.autoComplete1.SetAutoComplete(this.textBox3,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.AutoAppend);
						break;
					case "Both":
						this.autoComplete1.SetAutoComplete(this.textBox1,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both);
						this.autoComplete1.SetAutoComplete(this.textBox2,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both);
						this.autoComplete1.SetAutoComplete(this.textBox3,Syncfusion.Windows.Forms.Tools.AutoCompleteModes.Both);
						break;                 

				}
			}
		}


		private void AddLog(string message)
		{
			this.textBox5.Text += message +"\r\n";
		}

		private void autoComplete_AutoCompleteItemBrowsed(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
		{
			string itemText = args.ItemArray[0].ToString();
			string eventlogmessage = String.Format("Event: {0} Item: {1}", "AutoCompleteItemBrowsed", itemText);
			AddLog(eventlogmessage);
		}

		private void autoComplete_AutoCompleteItemSelected(object sender, Syncfusion.Windows.Forms.Tools.AutoCompleteItemEventArgs args)
		{
			string itemText = args.ItemArray[0].ToString();
			string eventlogmessage = String.Format("Event: {0} Item: {1}", "AutoCompleteItemSelected", itemText);
			AddLog(eventlogmessage);
		}

        private void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv2.Text)
            {
                case "MultiSuggest":
                    this.autoComplete2.SetAutoComplete(this.comboBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggest);
                    this.autoComplete2.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggest);
                    
                    break;
                case "MultiSuggestExtended":
                    this.autoComplete2.SetAutoComplete(this.comboBox1, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
                    this.autoComplete2.SetAutoComplete(this.textBox4, Syncfusion.Windows.Forms.Tools.AutoCompleteModes.MultiSuggestExtended);
                    break;
            }
            AddLog("AutoCompleteMode set to " + this.comboBoxAdv2.Text);      
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.autoComplete1.MaxNumberofSuggestion = this.autoComplete2.MaxNumberofSuggestion = Convert.ToInt16(textBox6.Text);
            }
            catch (Exception exception) { }
        }
      



	}
}
