#region Copyright Syncfusion Inc. 2001 - 2008
//
//  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using System.Reflection;
using System.IO;

namespace ToolBarSample
{
    public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Private Members
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private System.Windows.Forms.CheckBox checkBox1;
        private Label label11;
        private Label label9;
        private Label label3;
        private ComboBox comboBox3;
        private CheckBox checkBox3;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private NumericUpDown numericUpDown2;
        private Label label7;
        private Label label10;
        private Label label12;
        private ChartControl chartControl1;
        private CheckBox checkBox2;
        private Panel panel9;
        private TextBox textBox_TextColor;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private TextBox textBox2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton3;
        private Button button1;
        private NumericUpDown numericUpDown3;
        Color[] color = new Color[] { Color.FromArgb(120, 75, 176), Color.FromArgb(171, 107, 251), Color.FromArgb(120, 75, 176) };
        private CheckBox checkBox4;
        private ComboBox comboBox1;
        private Label label2;
        Color[] color2 = new Color[] { Color.FromArgb(80, 157, 89), Color.FromArgb(114, 224, 127), Color.FromArgb(80, 157, 89) };

        #endregion

        #region Form's Constructor, Main And dispose
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());

        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            //Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem chartToolBarCommandItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem chartToolBarCommandItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem chartToolBarCommandItem3 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem chartToolBarCommandItem4 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem chartToolBarCommandItem5 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem chartToolBarCommandItem6 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCommandItem();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox_TextColor = new System.Windows.Forms.TextBox();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(311, 632);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Border Width";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(405, 632);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown3.TabIndex = 21;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox3.Location = new System.Drawing.Point(67, 575);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(92, 18);
            this.checkBox3.TabIndex = 18;
            this.checkBox3.Text = "Show Dialog";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(67, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Toolbar Settings";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(67, 551);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 18);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Border";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkbox1_changed);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(67, 490);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 1);
            this.label11.TabIndex = 5;
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox3.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom",
            "Floating"});
            this.comboBox3.Location = new System.Drawing.Point(122, 632);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(83, 21);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(67, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Position";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(311, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Appearance Settings";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(311, 491);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 1);
            this.label10.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(311, 529);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Spacing";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(405, 529);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown2.TabIndex = 21;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(311, 504);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Header";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(405, 504);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Etched;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.WhiteSmoke, System.Drawing.Color.Silver);
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(62, 82);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Location = new System.Drawing.Point(49, 16);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 500, 100);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            // 
            // 
            // 
            this.chartControl1.PrintDocument.ColorMode = Syncfusion.Windows.Forms.Chart.ChartPrintColorMode.GrayScale;
            this.chartControl1.ShowToolbar = true;
            this.chartControl1.ShowToolTips = true;
            this.chartControl1.Size = new System.Drawing.Size(458, 435);
            this.chartControl1.TabIndex = 0;
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.BackColor = System.Drawing.Color.DarkGray;
            this.chartControl1.ToolBar.ButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.chartControl1.ToolBar.ButtonForeColor = System.Drawing.Color.Gray;
            this.chartControl1.ToolBar.ButtonSize = new System.Drawing.Size(28, 28);
            this.chartControl1.ToolBar.Header = 7;
            this.chartControl1.ToolBar.IconPadding = 5;
            chartToolBarCommandItem1.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ZoomIn;
            chartToolBarCommandItem1.Parameter = null;
            chartToolBarCommandItem1.ToolTip = "ZoomIn";
            chartToolBarCommandItem2.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ZoomOut;
            chartToolBarCommandItem2.Parameter = null;
            chartToolBarCommandItem2.ToolTip = "ZoomOut";
            chartToolBarCommandItem3.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ResetZooming;
            chartToolBarCommandItem3.Parameter = null;
            chartToolBarCommandItem3.ToolTip = "Reset Zooming";
            chartToolBarCommandItem4.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ToggleXZooming;
            chartToolBarCommandItem4.Parameter = null;
            chartToolBarCommandItem4.ToolTip = "Enable X Zooming";
            chartToolBarCommandItem5.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.ToggleYZooming;
            chartToolBarCommandItem5.Parameter = null;
            chartToolBarCommandItem5.ToolTip = "Enable Y Zooming";
            chartToolBarCommandItem6.Command = Syncfusion.Windows.Forms.Chart.ChartCommands.TogglePanning;
            chartToolBarCommandItem6.Parameter = null;
            chartToolBarCommandItem6.ToolTip = "Panning";
            //this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCommandItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCommandItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCommandItem3);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCommandItem4);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCommandItem5);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCommandItem6);
            this.chartControl1.ToolBar.Padding = 5;
            this.chartControl1.ToolBar.ShowGrip = false;
            this.chartControl1.ToolBar.Spacing = 2;
            this.chartControl1.ToolBar.Visible = true;
            this.chartControl1.ZoomOutIncrement = 1.5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Location = new System.Drawing.Point(67, 527);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 18);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Show Grip";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.textBox_TextColor);
            this.panel9.Controls.Add(this.colorPickerButton1);
            this.panel9.Location = new System.Drawing.Point(405, 554);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(45, 21);
            this.panel9.TabIndex = 77;
            // 
            // textBox_TextColor
            // 
            this.textBox_TextColor.BackColor = System.Drawing.Color.DarkGray;
            this.textBox_TextColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TextColor.Location = new System.Drawing.Point(0, 0);
            this.textBox_TextColor.Name = "textBox_TextColor";
            this.textBox_TextColor.ReadOnly = true;
            this.textBox_TextColor.Size = new System.Drawing.Size(26, 20);
            this.textBox_TextColor.TabIndex = 11;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.DarkGray;
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton1.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton1.Image")));
            this.colorPickerButton1.Location = new System.Drawing.Point(26, 0);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.DarkGray;
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton1.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton1.TabIndex = 14;
            this.colorPickerButton1.Text = "...";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(311, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "BackColor";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.colorPickerButton2);
            this.panel1.Location = new System.Drawing.Point(405, 580);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(45, 21);
            this.panel1.TabIndex = 79;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 11;
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.Gray;
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton2.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton2.Image")));
            this.colorPickerButton2.Location = new System.Drawing.Point(26, 0);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.Gray;
            this.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton2.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton2.TabIndex = 14;
            this.colorPickerButton2.Text = "...";
            this.colorPickerButton2.UseVisualStyleBackColor = false;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(311, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Button ForeColor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(311, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Button BackColor";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.colorPickerButton3);
            this.panel2.Location = new System.Drawing.Point(405, 606);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 21);
            this.panel2.TabIndex = 81;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 11;
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton3.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton3.Image")));
            this.colorPickerButton3.Location = new System.Drawing.Point(26, 0);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.SelectedAsBackcolor = true;
            this.colorPickerButton3.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.colorPickerButton3.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton3.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton3.TabIndex = 14;
            this.colorPickerButton3.Text = "...";
            this.colorPickerButton3.UseVisualStyleBackColor = false;
            this.colorPickerButton3.ColorSelected += new System.EventHandler(this.colorPickerButton3_ColorSelected);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 83;
            this.button1.Text = "Add New Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox4.Location = new System.Drawing.Point(67, 503);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(99, 18);
            this.checkBox4.TabIndex = 84;
            this.checkBox4.Text = "Show ToolBar";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Dockable",
            "Movable",
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(122, 603);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 85;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(67, 606);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Behavior";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 687);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDown3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart ToolBar ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Form Load
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            this.comboBox3.SelectedIndex = 2;
            this.comboBox1.SelectedIndex = 0;
            ChartAppearance.ApplyChartStyles(this.chartControl1);

        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        /// <summary>
        /// Initializes the chartControl1's data and sets the Chart type
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Saab";
            series1.Type = ChartSeriesType.Column;
            series1.Text = series1.Name;

            series1.Points.Add(2001, 256);
            series1.Points.Add(2002, 491);
            series1.Points.Add(2003, 382);
            series1.Points.Add(2004, 437);
            series1.Points.Add(2005, 321);

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Volvo";
            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;

            series2.Points.Add(2001, 437);
            series2.Points.Add(2002, 451);
            series2.Points.Add(2003, 490);
            series2.Points.Add(2004, 366);
            series2.Points.Add(2005, 422);

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);

            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
            this.chartControl1.Text = "Sales Volume Comparison";
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;

        }
        #endregion
        #endregion

        #region Events
        private void checkbox1_changed(object sender, System.EventArgs e)
        {
            this.chartControl1.ToolBar.ShowBorder = this.checkBox1.Checked;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.Position = (ChartDock)Enum.Parse(typeof(ChartDock), this.comboBox3.SelectedItem.ToString(), true);
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.ButtonBackColor = this.colorPickerButton3.SelectedColor;
            this.textBox2.BackColor = this.colorPickerButton3.SelectedColor;
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.ButtonForeColor = this.colorPickerButton2.SelectedColor;
            this.textBox1.BackColor = this.colorPickerButton2.SelectedColor;
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.BackColor = this.colorPickerButton1.SelectedColor;
            this.textBox_TextColor.BackColor = this.colorPickerButton1.SelectedColor;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.ShowDialog = this.checkBox3.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.Header = (int)this.numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.Spacing = (int)this.numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.Border.Width = (float)this.numericUpDown3.Value;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.ShowGrip = this.checkBox2.Checked;
            this.chartControl1.Redraw(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChartToolBarItem rotateItem = new ChartToolBarItem();
            rotateItem.Name = "Rotation";
            rotateItem.Image = Image.FromFile(@"..\..\Rotation.png");
            this.chartControl1.ToolBar.Items.Add(rotateItem);
            this.chartControl1.ToolBar.ItemClick += new EventHandler(ToolBar_ItemClick);
            this.chartControl1.Size = new Size(475, 435);
            this.button1.Enabled = false;
        }

        private void ToolBar_ItemClick(object sender, EventArgs e)
        {
            ChartToolBarItem tt = sender as ChartToolBarItem;
            if (tt.Name == "Rotation")
            {
                this.chartControl1.Series3D = true;
                if ((float)this.chartControl1.Rotation == 90)
                    this.chartControl1.Rotation = 30;
                else
                    this.chartControl1.Rotation = this.chartControl1.Rotation + 5;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.ShowToolbar = this.checkBox4.Checked;
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ToolBar.Behavior = (ChartDockingFlags)Enum.Parse(typeof(ChartDockingFlags), this.comboBox1.SelectedItem.ToString(), true);
        }

    }
}
