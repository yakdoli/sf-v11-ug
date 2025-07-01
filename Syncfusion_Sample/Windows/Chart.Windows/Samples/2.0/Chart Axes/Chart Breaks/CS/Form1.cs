using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Chart;
using System.Drawing.Drawing2D;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;

namespace EssentialChartSample
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Office2007Form
    {
        # region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private ChartAxis axis1 = new ChartAxis();
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        Color[] color1 = new Color[]{Color.FromArgb(204, 96, 134), 
                Color.FromArgb(249, 174, 200),Color.FromArgb(204, 96, 134)};
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private ListBox listBox1;
        private Label label3;
        private Button button2;
        private ToolTip toolTip1;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private Label label10;
        private NumericUpDown numericUpDownSpacing;
        private Label label9;
        private ComboBox comboBoxType;
        private Label label8;
        private TextBox textBox2;
        private Label label13;
        private ComboBox comboBoxStyle;
        private Label label12;
        private NumericUpDown numericUpDownWidth;
        private Label label11;
        private ColorPickerButton colorPickerButton2;
        private ColorPickerButton colorPickerButton1;
        private Panel panel3;
        private Panel panel2;
        private IContainer components;
        # endregion

        # region Main and Constructor
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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownSpacing = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.RosyBrown;
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.RosyBrown;
            this.chartControl1.BorderAppearance.Interior.Width = 1F;
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(375, 87);
            this.chartControl1.Location = new System.Drawing.Point(25, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3;
            this.chartControl1.Size = new System.Drawing.Size(513, 429);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.chartControl1.ZoomOutIncrement = 1.5;
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(12, 447);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 18);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Enable Break in Chart";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.comboBoxStyle);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.numericUpDownWidth);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numericUpDownSpacing);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 471);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 229);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.colorPickerButton1);
            this.panel3.Location = new System.Drawing.Point(152, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 21);
            this.panel3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 21;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton1.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton1.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton1.TabIndex = 23;
            this.colorPickerButton1.Text = "...";
            this.colorPickerButton1.UseVisualStyleBackColor = true;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.colorPickerButton2);
            this.panel2.Location = new System.Drawing.Point(152, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 21);
            this.panel2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 14;
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton2.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton2.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton2.TabIndex = 22;
            this.colorPickerButton2.Text = "...";
            this.colorPickerButton2.UseVisualStyleBackColor = true;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(68, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Spacing Color";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(152, 133);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(75, 21);
            this.comboBoxStyle.TabIndex = 19;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Line Style";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(152, 99);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownWidth.TabIndex = 17;
            this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(68, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Line Width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Line Color";
            // 
            // numericUpDownSpacing
            // 
            this.numericUpDownSpacing.Location = new System.Drawing.Point(152, 66);
            this.numericUpDownSpacing.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpacing.Name = "numericUpDownSpacing";
            this.numericUpDownSpacing.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownSpacing.TabIndex = 12;
            this.numericUpDownSpacing.ValueChanged += new System.EventHandler(this.numericUpDownSpacing_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Line Spacing";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(152, 32);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(75, 21);
            this.comboBoxType.TabIndex = 10;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Line Type";
            // 
            // button2
            // 
            this.button2.Image = global::EssentialChartSample.Properties.Resources.tooltipImage;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(414, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove Break";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button2, "Select Range to Remove");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(293, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Manual";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = global::EssentialChartSample.Properties.Resources.tooltipImage;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(304, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert Break";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.button1, "Select Range to Insert");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(414, 92);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Break Range";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "300-500",
            "800-1100"});
            this.listBox1.Location = new System.Drawing.Point(414, 144);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(99, 30);
            this.listBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Break Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(293, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Auto";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Image = global::EssentialChartSample.Properties.Resources.labelImage;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(40, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Appearance";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Image = global::EssentialChartSample.Properties.Resources.labelImage;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(276, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Behavior";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Manual",
            "Auto"});
            this.comboBox1.Location = new System.Drawing.Point(414, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Break Mode";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 700);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Breaks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        # endregion

        # region Form Load
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();         
            InitializeControls();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        # endregion

        # region Helpher Methods
        /// <summary>
        /// Initializes chart series data
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series = new ChartSeries("Populated Countries", ChartSeriesType.Column);
            series.Text = series.Name;
            series.Points.Add(1, 1330);
            series.Points.Add(2, 1148);
            series.Points.Add(3, 303.8);
            series.Points.Add(4, 237.5);
            series.Points.Add(5, 191.9);
            series.Points.Add(6, 167.8);
            series.Points.Add(7, 153.5);
            series.Points.Add(8, 140.7);
            series.Points.Add(9, 138.3);
            series.Points.Add(10, 127.3);
            this.chartControl1.Series.Add(series);
            this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(Form1_PrepareStyle);
            MakeBreakChart();
        }
        /// <summary>
        /// Initializes controls
        /// </summary>
        protected void InitializeControls()
        {
            this.comboBox1.SelectedIndex = 1;
            this.listBox1.SelectedIndex = 0;
            foreach (string line in Enum.GetNames(typeof(ChartBreakLineType)))
                this.comboBoxType.Items.Add(line);
            foreach (string line in Enum.GetNames(typeof(DashStyle)))
                this.comboBoxStyle.Items.Add(line);

            this.comboBoxType.SelectedIndex = 1;
            this.comboBoxStyle.SelectedIndex = 2;
            this.numericUpDownSpacing.Value = 5;
            this.numericUpDownWidth.Value = 1;
        }        

        /// <summary>
        /// Prepares for manual mode break chart
        /// </summary>
        protected void MakeBreakChart()
        {
            this.chartControl1.PrimaryYAxis.BreakRanges.BreaksMode = ChartBreaksMode.Manual;
            this.chartControl1.PrimaryYAxis.BreakRanges.Union(new DoubleRange(300, 500));
            this.chartControl1.PrimaryYAxis.BreakRanges.Union(new DoubleRange(800, 1100));
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = ChartBreakLineType.Wave;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 5;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineColor = Color.Black;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineWidth = 1;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineStyle = DashStyle.Dot;
            this.chartControl1.PrimaryYAxis.BreakInfo.SpacingColor = Color.White;
        }
        #endregion

        # region Events

        void Form1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = this.chartControl1.Series[0];
            if (series != null)
            {

                if (args.Index == 0)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 41, 158, 214));
                }
                else if (args.Index == 1)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 206, 215, 41));
                }
                else if (args.Index == 2)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 255, 186, 0));
                }
                else if (args.Index == 3)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 247, 125, 16));
                }
                else if (args.Index == 4)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 129, 115, 27));
                }
                else if (args.Index == 5)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 255, 136, 23));
                }
                else if (args.Index == 6)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 246, 100, 15));
                }
                else if (args.Index == 7)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 188, 200, 6));
                }
                else if (args.Index == 8)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 234, 90, 81));
                }
                else if (args.Index == 9)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(200, 191, 192, 98));
                }
            }
        }

        /// <summary>
        /// Toggles between Break and regular chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.panel1.Enabled = true;
                this.chartControl1.PrimaryYAxis.MakeBreaks = true;
                this.chartControl1.PrimaryYAxis.BreakRanges.BreaksMode = (ChartBreaksMode)Enum.Parse(typeof(ChartBreaksMode), this.comboBox1.SelectedItem.ToString());
            }
            else
            {
                this.chartControl1.PrimaryYAxis.MakeBreaks = false;
                this.panel1.Enabled = false;
            }
            SetRange();
        }
        public void SetRange()
        {
            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 1400, 100);
        }
        /// <summary>
        /// Handles the different break modes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
                this.chartControl1.PrimaryYAxis.BreakRanges.Clear();
            else if (this.comboBox1.SelectedIndex == 1)
            {
                MakeBreakChart();
                this.button1.Enabled = false;
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                this.chartControl1.PrimaryYAxis.BreakRanges.BreaksMode = ChartBreaksMode.Auto;
                this.chartControl1.PrimaryYAxis.BreakRanges.BreakAmount = Convert.ToDouble(this.numericUpDown1.Value);
            }
            SetRange();
        }

        /// <summary>
        /// Removes the specified range from manual break chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string temp = this.listBox1.SelectedItem.ToString();
            double start = Convert.ToDouble(temp.Substring(0, temp.LastIndexOf('-')));
            double end = Convert.ToDouble(temp.Substring(temp.LastIndexOf('-') + 1));
            this.chartControl1.PrimaryYAxis.BreakRanges.Exclude(new DoubleRange(start, end));
            this.button1.Enabled = true;
            SetRange();
        }

        /// <summary>
        /// Inserts the specified range from manual break chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string temp = this.listBox1.SelectedItem.ToString();
            double start = Convert.ToDouble(temp.Substring(0, temp.LastIndexOf('-')));
            double end = Convert.ToDouble(temp.Substring(temp.LastIndexOf('-') + 1));
            this.chartControl1.PrimaryYAxis.BreakRanges.Union(new DoubleRange(start, end));
            SetRange();
        }

        /// <summary>
        /// Updates the break amount during auto break mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakRanges.BreakAmount = Convert.ToDouble(this.numericUpDown1.Value);
            SetRange();
        }

        /// <summary>
        /// Updates the type of the break line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = (ChartBreakLineType)Enum.Parse(typeof(ChartBreakLineType), this.comboBoxType.SelectedItem.ToString());
            SetRange();
        }

        /// <summary>
        /// Updates the style of the break line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakInfo.LineStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBoxStyle.SelectedItem.ToString());
            SetRange();
        }

        /// <summary>
        /// Controls the spacing of the break line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownSpacing_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = Convert.ToDouble(this.numericUpDownSpacing.Value);
            SetRange();
        }

        /// <summary>
        /// Controls the width of the break line border
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownWidth_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.BreakInfo.LineWidth = (float)(this.numericUpDownWidth.Value);
            SetRange();
        }

        /// <summary>
        /// Handles the color of the break line border
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            this.textBox1.BackColor = this.colorPickerButton2.SelectedColor;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineColor = this.colorPickerButton2.SelectedColor;
            SetRange();
        }

        /// <summary>
        /// Handles the color of the spacing of breakline
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.textBox2.BackColor = this.colorPickerButton1.SelectedColor;
            this.chartControl1.PrimaryYAxis.BreakInfo.SpacingColor = this.colorPickerButton1.SelectedColor;
            SetRange();
        }

        # endregion

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (e.Value == 1)
                    e.Label = "China";
                else if (e.Value == 2)
                    e.Label = "India";
                else if (e.Value == 3)
                    e.Label = "United States";
                else if (e.Value == 4)
                    e.Label = "Indonesia";
                else if (e.Value == 5)
                    e.Label = "Brazil";
                else if (e.Value == 6)
                    e.Label = "Pakistan";
                else if (e.Value == 7)
                    e.Label = "Bangladesh";
                else if (e.Value == 8)
                    e.Label = "Russia";
                else if (e.Value == 9)
                    e.Label = "Nigeria";
                else if (e.Value == 10)
                    e.Label = "Japan";
                else
                    e.Label = "";

                e.Handled = true;
            }
        }
    }
}
