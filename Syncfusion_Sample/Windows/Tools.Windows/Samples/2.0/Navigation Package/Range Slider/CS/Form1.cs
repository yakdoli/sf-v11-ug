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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.Data.OleDb;
using Syncfusion.Windows.Forms.Grid;

namespace TaskBar
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
    {
        #region Private Members
     
	    private TabControlAdv tabControlAdv2;
        private TabPageAdv tabPageAdv4;
        private TabPageAdv tabPageAdv5;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private CheckBox checkBox1;
        private Label label1;
        private NumericUpDown numericUpDown4;
        private Label label3;
        private NumericUpDown numericUpDown5;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private RangeSlider rangeSlider1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        static string path = @"../../../Data/sample.mdb";
        private GroupBox groupBox2;
        private Label label6;
        private Label label8;
        private ButtonEdit HighLighterColor;
        private ButtonEditChildButton buttonEditChildButton1;
        private Label label9;
        private ButtonEdit buttonEdit3;
        private ButtonEditChildButton buttonEditChildButton4;
        private Label label12;
        private ButtonEdit buttonEdit2;
        private ButtonEditChildButton buttonEditChildButton3;
        private Label label11;
        private ButtonEdit buttonEdit1;
        private ButtonEditChildButton buttonEditChildButton2;
        private Label label10;
        private ButtonEdit buttonEdit4;
        private ButtonEditChildButton buttonEditChildButton5;
        private Label label13;
        private ColorDialog colorDialog1;
                    
		private System.ComponentModel.IContainer components;
        string conString = @"Provider=Microsoft.JET.OLEDB.4.0;" + @"data source=" + path;
        OleDbConnection conn = null;
           
#endregion

        #region Form's constructor, Main and Dispose
        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            colorDialog1 = new ColorDialog();
            // Create an open the connection
            conn = new OleDbConnection(conString);
            conn.Open();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
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
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.rangeSlider1 = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.tabControlAdv2 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv4 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageAdv5 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.buttonEdit4 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton5 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonEdit2 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label10 = new System.Windows.Forms.Label();
            this.HighLighterColor = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).BeginInit();
            this.tabControlAdv2.SuspendLayout();
            this.tabPageAdv4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPageAdv5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).BeginInit();
            this.buttonEdit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).BeginInit();
            this.buttonEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighLighterColor)).BeginInit();
            this.HighLighterColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "200";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Location = new System.Drawing.Point(1, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 216);
            this.panel1.TabIndex = 15;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowSelection = Syncfusion.Windows.Forms.Grid.GridSelectionFlags.None;
            gridBaseStyle1.Name = "Row Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle2.Name = "Column Header";
            gridBaseStyle2.StyleInfo.BaseStyle = "Header";
            gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle4.Name = "Header";
            gridBaseStyle4.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.CellType = "Header";
            gridBaseStyle4.StyleInfo.Font.Bold = true;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.DefaultColWidth = 66;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ResizeColsBehavior = ((Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior)((((Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.ResizeAll | Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.ResizeSingle)
                        | Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.OutlineHeaders)
                        | Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.OutlineBounds)));
            this.gridControl1.ResizeRowsBehavior = ((Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior)((((Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.ResizeAll | Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.ResizeSingle)
                        | Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.OutlineHeaders)
                        | Syncfusion.Windows.Forms.Grid.GridResizeCellsBehavior.OutlineBounds)));
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.ScrollFrozen = false;
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(437, 216);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 1;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.UseRightToLeftCompatibleTextBox = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // rangeSlider1
            // 
            this.rangeSlider1.ChannelHeight = 6;
            this.rangeSlider1.Location = new System.Drawing.Point(133, 24);
            this.rangeSlider1.Maximum = 200;
            this.rangeSlider1.Name = "rangeSlider1";
            this.rangeSlider1.Size = new System.Drawing.Size(308, 22);
            this.rangeSlider1.SliderMax = 200;
            this.rangeSlider1.SliderSize = new System.Drawing.Size(15, 18);
            this.rangeSlider1.TabIndex = 12;
            this.rangeSlider1.Text = "rangeSlider1";
            this.rangeSlider1.TickFrequency = 10;
            // 
            // tabControlAdv2
            // 
            this.tabControlAdv2.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.tabControlAdv2.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.tabControlAdv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv2.Controls.Add(this.tabPageAdv4);
            this.tabControlAdv2.Controls.Add(this.tabPageAdv5);
            this.tabControlAdv2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControlAdv2.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.tabControlAdv2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tabControlAdv2.Location = new System.Drawing.Point(444, 0);
            this.tabControlAdv2.Name = "tabControlAdv2";
            this.tabControlAdv2.Size = new System.Drawing.Size(244, 307);
            this.tabControlAdv2.TabGap = 10;
            this.tabControlAdv2.TabIndex = 3;
            this.tabControlAdv2.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.tabControlAdv2.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);
            this.tabControlAdv2.ThemesEnabled = true;
            // 
            // tabPageAdv4
            // 
            this.tabPageAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.tabPageAdv4.Controls.Add(this.groupBox1);
            this.tabPageAdv4.Controls.Add(this.groupBox2);
            this.tabPageAdv4.Image = null;
            this.tabPageAdv4.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv4.Location = new System.Drawing.Point(3, 24);
            this.tabPageAdv4.Name = "tabPageAdv4";
            this.tabPageAdv4.Size = new System.Drawing.Size(238, 280);
            this.tabPageAdv4.TabIndex = 1;
            this.tabPageAdv4.Text = "Settings";
            this.tabPageAdv4.ThemesEnabled = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 132);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Slider Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Slider Width";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown4.Location = new System.Drawing.Point(15, 38);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(95, 21);
            this.numericUpDown4.TabIndex = 14;
            this.numericUpDown4.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Channel Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Slider Height";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown3.Location = new System.Drawing.Point(15, 98);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(95, 21);
            this.numericUpDown3.TabIndex = 16;
            this.numericUpDown3.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown5.Location = new System.Drawing.Point(119, 38);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(95, 21);
            this.numericUpDown5.TabIndex = 16;
            this.numericUpDown5.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(24, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 82);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slider Ticks";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(127, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Show Ticks";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(6, 46);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(95, 21);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tick Frequency";
            // 
            // tabPageAdv5
            // 
            this.tabPageAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.tabPageAdv5.Controls.Add(this.buttonEdit4);
            this.tabPageAdv5.Controls.Add(this.label13);
            this.tabPageAdv5.Controls.Add(this.buttonEdit3);
            this.tabPageAdv5.Controls.Add(this.label12);
            this.tabPageAdv5.Controls.Add(this.buttonEdit2);
            this.tabPageAdv5.Controls.Add(this.label11);
            this.tabPageAdv5.Controls.Add(this.buttonEdit1);
            this.tabPageAdv5.Controls.Add(this.label10);
            this.tabPageAdv5.Controls.Add(this.HighLighterColor);
            this.tabPageAdv5.Controls.Add(this.label9);
            this.tabPageAdv5.Image = null;
            this.tabPageAdv5.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv5.Location = new System.Drawing.Point(3, 24);
            this.tabPageAdv5.Name = "tabPageAdv5";
            this.tabPageAdv5.Size = new System.Drawing.Size(238, 280);
            this.tabPageAdv5.TabIndex = 2;
            this.tabPageAdv5.Text = "Color";
            this.tabPageAdv5.ThemesEnabled = false;
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton5);
            this.buttonEdit4.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton5);
            this.buttonEdit4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEdit4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit4.Location = new System.Drawing.Point(127, 66);
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.ShowTextBox = false;
            this.buttonEdit4.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit4.TabIndex = 49;
            // 
            // buttonEditChildButton5
            // 
            this.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton5.Image = null;
            this.buttonEditChildButton5.Name = "buttonEditChildButton5";
            this.buttonEditChildButton5.PreferredWidth = 20;
            this.buttonEditChildButton5.TabIndex = 1;
            this.buttonEditChildButton5.Text = "...";
            this.buttonEditChildButton5.UseVisualStyleBackColor = true;
            this.buttonEditChildButton5.Click += new System.EventHandler(this.buttonEdit4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(17, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 14);
            this.label13.TabIndex = 48;
            this.label13.Text = "Thumb Color";
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.Buttons.Add(this.buttonEditChildButton4);
            this.buttonEdit3.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit3.Controls.Add(this.buttonEditChildButton4);
            this.buttonEdit3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEdit3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit3.Location = new System.Drawing.Point(129, 166);
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.ShowTextBox = false;
            this.buttonEdit3.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit3.TabIndex = 47;
            this.buttonEdit3.Click += new System.EventHandler(this.buttonEdit3_Click);
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton4.Image = null;
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 20;
            this.buttonEditChildButton4.TabIndex = 1;
            this.buttonEditChildButton4.Text = "...";
            this.buttonEditChildButton4.UseVisualStyleBackColor = true;
            this.buttonEditChildButton4.Click += new System.EventHandler(this.buttonEdit3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(17, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 14);
            this.label12.TabIndex = 46;
            this.label12.Text = "Channel Color";
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.Buttons.Add(this.buttonEditChildButton3);
            this.buttonEdit2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit2.Controls.Add(this.buttonEditChildButton3);
            this.buttonEdit2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEdit2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit2.Location = new System.Drawing.Point(129, 134);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.ShowTextBox = false;
            this.buttonEdit2.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit2.TabIndex = 45;
            this.buttonEdit2.Click += new System.EventHandler(this.buttonEdit2_Click);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton3.Image = null;
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 20;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Text = "...";
            this.buttonEditChildButton3.UseVisualStyleBackColor = true;
            this.buttonEditChildButton3.Click += new System.EventHandler(this.buttonEdit2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(3, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 14);
            this.label11.TabIndex = 44;
            this.label11.Text = "Highlighted Thumb Color";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton2);
            this.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton2);
            this.buttonEdit1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEdit1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit1.Location = new System.Drawing.Point(128, 99);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.ShowTextBox = false;
            this.buttonEdit1.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit1.TabIndex = 43;
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton2.Image = null;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 20;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "...";
            this.buttonEditChildButton2.UseVisualStyleBackColor = true;
            this.buttonEditChildButton2.Click += new System.EventHandler(this.buttonEdit1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(3, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 14);
            this.label10.TabIndex = 42;
            this.label10.Text = "Pushed Thumb Color";
            // 
            // HighLighterColor
            // 
            this.HighLighterColor.Buttons.Add(this.buttonEditChildButton1);
            this.HighLighterColor.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.HighLighterColor.Controls.Add(this.buttonEditChildButton1);
            this.HighLighterColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.HighLighterColor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighLighterColor.Location = new System.Drawing.Point(127, 34);
            this.HighLighterColor.Name = "HighLighterColor";
            this.HighLighterColor.ShowTextBox = false;
            this.HighLighterColor.Size = new System.Drawing.Size(102, 26);
            this.HighLighterColor.TabIndex = 41;
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditChildButton1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 20;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            this.buttonEditChildButton1.UseVisualStyleBackColor = true;
            this.buttonEditChildButton1.Click += new System.EventHandler(this.HighLighterColor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(17, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 14);
            this.label9.TabIndex = 40;
            this.label9.Text = "Range Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-2, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Select Stock Close Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(178, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Stock Report";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(214)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(688, 307);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rangeSlider1);
            this.Controls.Add(this.tabControlAdv2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Range Slider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv2)).EndInit();
            this.tabControlAdv2.ResumeLayout(false);
            this.tabPageAdv4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPageAdv5.ResumeLayout(false);
            this.tabPageAdv5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).EndInit();
            this.buttonEdit4.ResumeLayout(false);
            this.buttonEdit4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).EndInit();
            this.buttonEdit2.ResumeLayout(false);
            this.buttonEdit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HighLighterColor)).EndInit();
            this.HighLighterColor.ResumeLayout(false);
            this.HighLighterColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

       

        private void Form1_Load(object sender, EventArgs e)
        {
          
            // Create the adapter and fill the DataSet
            OleDbCommand command = new OleDbCommand(@"select * from StockData where ClosePrice between @FromPrice and @ToPrice order by symbol", conn);

            command.Parameters.Add("@FromPrice", OleDbType.Integer).Value = rangeSlider1.SliderMin;
            command.Parameters.Add("@ToPrice", OleDbType.Integer).Value = rangeSlider1.SliderMax;
         
            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.Fill(ds);

          
            DataTable table = ds.Tables[0];

            gridControl1.RowCount = table.Rows.Count;
            gridControl1.ColCount = table.Columns.Count;

            gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, table.Rows.Count, table.Columns.Count), table);
            gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, table.Rows.Count, table.Columns.Count), table);

            rangeSlider1.ValueChanged += new EventHandler(rangeSlider1_ValueChanged);
        }

        void rangeSlider1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = rangeSlider1.SliderMin.ToString();
            label5.Text = rangeSlider1.SliderMax.ToString();
           

            // Create the adapter and fill the DataSet
            OleDbCommand command = new OleDbCommand(@"select * from StockData where ClosePrice between @FromPrice and @ToPrice", conn);

            command.Parameters.Add("@FromPrice", OleDbType.Integer).Value = rangeSlider1.SliderMin;
            command.Parameters.Add("@ToPrice", OleDbType.Integer).Value = rangeSlider1.SliderMax;

            DataSet ds = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.Fill(ds);

            DataTable table = ds.Tables[0];
            gridControl1.Clear(true);
            gridControl1.RowCount = table.Rows.Count;
            gridControl1.ColCount = table.Columns.Count;

            gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, table.Rows.Count, table.Columns.Count), table);
            gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, table.Rows.Count, table.Columns.Count), table);

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            rangeSlider1.TickFrequency =(int) numericUpDown1.Value;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            rangeSlider1.ShowTicks = checkBox1.Checked;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            rangeSlider1.SliderSize = new Size( (int)numericUpDown4.Value,rangeSlider1.SliderSize.Height);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            rangeSlider1.ChannelHeight = (int)numericUpDown3.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            rangeSlider1.SliderSize = new Size( rangeSlider1.SliderSize.Width,(int)numericUpDown5.Value);
        }

        private void HighLighterColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();          
            this.HighLighterColor.BackColor = colorDialog1.Color;
            rangeSlider1.RangeColor = this.HighLighterColor.BackColor;
        }

        private void buttonEdit4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();           
            this.buttonEdit4.BackColor = colorDialog1.Color;
            rangeSlider1.ThumbColor = this.buttonEdit4.BackColor;
        }

        private void buttonEdit1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();           
            this.buttonEdit1.BackColor = colorDialog1.Color;
            rangeSlider1.PushedThumbColor = this.buttonEdit1.BackColor;
        }

        private void buttonEdit2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.buttonEdit2.BackColor = colorDialog1.Color;
            rangeSlider1.HighlightedThumbColor = this.buttonEdit2.BackColor;
        }

        private void buttonEdit3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.buttonEdit3.BackColor = colorDialog1.Color;
            rangeSlider1.ChannelColor = this.buttonEdit3.BackColor;
        }


    }
}
