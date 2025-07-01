using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing.Drawing2D;

namespace ChartLegendSample
{
    public class Form1 : Office2007Form
    {
        #region Private Members
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLegendType;
        private System.Windows.Forms.Label label3;
        private Label label8;
        private Label label10;
        private ComboBox comboBox4;
        private ComboBox comboBox1;
        private ComboBox comboBox5;
        private Label label7;
        private Label label12;
        private Label label13;
        private ComboBox comboBox_FontStyle;
        private Panel panel9;
        private TextBox textBox_TextColor;
        private ColorPickerButton colorPicker_TextColor;
        private NumericUpDown numericUpDown_FontSize;
        private ComboBox comboBox_Fontfamily;
        private Panel panel2;
        private TextBox textBox1;
        private ColorPickerButton colorPickerButton1;
        private ComboBox comboBox2;
        private Label label19;
        private Panel panel3;
        private TextBox textBox2;
        private ColorPickerButton colorPickerButton2;
        private Label label18;
        private Label label17;
        private CheckBox checkBox1;
        private Label label5;
        private Panel panel4;
        private TextBox textBox3;
        private ColorPickerButton colorPickerButton3;
        private Label label21;
        private TextBox textBox4;
        private Label label22;
        private Panel panel5;
        private TextBox textBox5;
        private ColorPickerButton colorPickerButton4;
        private Label label23;
        private ComboBox comboBox3;
        private Label label26;
        private NumericUpDown numericUpDown2;
        private Label label27;
        private NumericUpDown numericUpDown3;
        private Label label28;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private Label label29;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private Label label30;
        private ToolTip toolTip1;
        private CheckBox checkBox5;
        private Label label31;
        private ComboBox comboBox8;
        private Label label9;
        private Label label11;
        private NumericUpDown numericUpDown5;
        private CheckBox checkBox7;
        private Label label34;
        private Panel panel7;
        private TextBox textBox6;
        private ColorPickerButton colorPickerButton5;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private ComboBox comboBox9;
        private Label label42;
        private ChartControl chartControl1;
        private DesignerPanel designerPanel1;
        private DesignerPanel designerPanel2;
        private DesignerPanel designerPanel3;
        private DesignerPanel designerPanel4;
        private DesignerPanel designerPanel5;
        private DesignerPanel designerPanel6;
        private DesignerPanel designerPanel7;
        private Label label1;
        private Label label2;
        private Label label6;
        private ComboBox comboBox10;
        private System.ComponentModel.IContainer components;
        #endregion

        #region Form Constructor, Main And Dispose
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.designerPanel7 = new DesignerPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.colorPickerButton4 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.designerPanel6 = new DesignerPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cmbLegendType = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.designerPanel5 = new DesignerPanel();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.designerPanel4 = new DesignerPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.designerPanel3 = new DesignerPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDown_FontSize = new System.Windows.Forms.NumericUpDown();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox_TextColor = new System.Windows.Forms.TextBox();
            this.colorPicker_TextColor = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.comboBox_Fontfamily = new System.Windows.Forms.ComboBox();
            this.comboBox_FontStyle = new System.Windows.Forms.ComboBox();
            this.designerPanel2 = new DesignerPanel();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.colorPickerButton5 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.designerPanel1 = new DesignerPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel7)).BeginInit();
            this.designerPanel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel6)).BeginInit();
            this.designerPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel5)).BeginInit();
            this.designerPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel4)).BeginInit();
            this.designerPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel3)).BeginInit();
            this.designerPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel2)).BeginInit();
            this.designerPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel1)).BeginInit();
            this.designerPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images3"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images4"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images5"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images6"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images7"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images8"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images9"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images10"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images11"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images12")))});
            // 
            // chartControl1
            // 
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.chartControl1.BorderAppearance.FrameThickness = new Syncfusion.Windows.Forms.Chart.ChartThickness(1F, 1F, 2F, 2F);
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.Red;
            this.chartControl1.BorderAppearance.Interior.Width = 1F;
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))), System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(235, 280);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Legend.RowsCount = 2;
            this.chartControl1.Legend.Spacing = 9;
            this.chartControl1.Location = new System.Drawing.Point(10, 20);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 6, 1);
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(-100, 500, 100);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.Size = new System.Drawing.Size(550, 376);
            this.chartControl1.TabIndex = 4;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            this.chartControl1.ZoomOutIncrement = 0.20000000298023224;
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // designerPanel7
            // 
            this.designerPanel7.BackColor = System.Drawing.Color.White;
            this.designerPanel7.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(237))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))))});
            this.designerPanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.designerPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel7.Controls.Add(this.panel4);
            this.designerPanel7.Controls.Add(this.checkBox1);
            this.designerPanel7.Controls.Add(this.label2);
            this.designerPanel7.Controls.Add(this.comboBox3);
            this.designerPanel7.Controls.Add(this.label21);
            this.designerPanel7.Controls.Add(this.label23);
            this.designerPanel7.Controls.Add(this.panel5);
            this.designerPanel7.Controls.Add(this.label22);
            this.designerPanel7.Controls.Add(this.textBox4);
            this.designerPanel7.Controls.Add(this.label5);
            this.designerPanel7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.designerPanel7.HeaderImage = ((System.Drawing.Image)(resources.GetObject("designerPanel7.HeaderImage")));
            this.designerPanel7.HeaderText = "       Title And Shadow";
            this.designerPanel7.Location = new System.Drawing.Point(635, 421);
            this.designerPanel7.Name = "designerPanel7";
            this.designerPanel7.Size = new System.Drawing.Size(190, 150);
            this.designerPanel7.TabIndex = 144;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.colorPickerButton3);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(88, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(43, 19);
            this.panel4.TabIndex = 96;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(24, 20);
            this.textBox3.TabIndex = 11;
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton3.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton3.Image")));
            this.colorPickerButton3.Location = new System.Drawing.Point(24, 0);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.SelectedAsBackcolor = true;
            this.colorPickerButton3.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton3.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton3.Size = new System.Drawing.Size(17, 17);
            this.colorPickerButton3.TabIndex = 14;
            this.colorPickerButton3.Text = "...";
            this.colorPickerButton3.UseVisualStyleBackColor = false;
            this.colorPickerButton3.ColorSelected += new System.EventHandler(this.colorPickerButton3_ColorSelected);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(88, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 18);
            this.checkBox1.TabIndex = 95;
            this.checkBox1.Text = " ";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Shadow Visible";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Near",
            "Center",
            "Far"});
            this.comboBox3.Location = new System.Drawing.Point(88, 80);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(90, 21);
            this.comboBox3.TabIndex = 101;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(9, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 95;
            this.label21.Text = "Title Text";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(9, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 13);
            this.label23.TabIndex = 100;
            this.label23.Text = "Title Alignment";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox5);
            this.panel5.Controls.Add(this.colorPickerButton4);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(88, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 19);
            this.panel5.TabIndex = 99;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(22, 20);
            this.textBox5.TabIndex = 11;
            // 
            // colorPickerButton4
            // 
            this.colorPickerButton4.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton4.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton4.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton4.Image")));
            this.colorPickerButton4.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton4.Name = "colorPickerButton4";
            this.colorPickerButton4.SelectedAsBackcolor = true;
            this.colorPickerButton4.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton4.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton4.Size = new System.Drawing.Size(17, 17);
            this.colorPickerButton4.TabIndex = 14;
            this.colorPickerButton4.Text = "...";
            this.colorPickerButton4.UseVisualStyleBackColor = false;
            this.colorPickerButton4.ColorSelected += new System.EventHandler(this.colorPickerButton4_ColorSelected);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(9, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(54, 13);
            this.label22.TabIndex = 98;
            this.label22.Text = "Title Color";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(88, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 20);
            this.textBox4.TabIndex = 96;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Shadow Color";
            // 
            // designerPanel6
            // 
            this.designerPanel6.BackColor = System.Drawing.Color.White;
            this.designerPanel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(237))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))))});
            this.designerPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.designerPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel6.Controls.Add(this.checkBox2);
            this.designerPanel6.Controls.Add(this.checkBox5);
            this.designerPanel6.Controls.Add(this.checkBox4);
            this.designerPanel6.Controls.Add(this.label30);
            this.designerPanel6.Controls.Add(this.cmbLegendType);
            this.designerPanel6.Controls.Add(this.label42);
            this.designerPanel6.Controls.Add(this.label4);
            this.designerPanel6.Controls.Add(this.label31);
            this.designerPanel6.Controls.Add(this.comboBox9);
            this.designerPanel6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.designerPanel6.HeaderImage = ((System.Drawing.Image)(resources.GetObject("designerPanel6.HeaderImage")));
            this.designerPanel6.HeaderText = "       Item Representation";
            this.designerPanel6.Location = new System.Drawing.Point(438, 421);
            this.designerPanel6.Name = "designerPanel6";
            this.designerPanel6.Size = new System.Drawing.Size(190, 150);
            this.designerPanel6.TabIndex = 144;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(12, 30);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 18);
            this.checkBox2.TabIndex = 111;
            this.checkBox2.Text = "Show CheckBox";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBox5.ForeColor = System.Drawing.Color.Black;
            this.checkBox5.Location = new System.Drawing.Point(12, 79);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(99, 18);
            this.checkBox5.TabIndex = 117;
            this.checkBox5.Text = "Custom Image";
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBox4.ForeColor = System.Drawing.Color.Black;
            this.checkBox4.Location = new System.Drawing.Point(12, 54);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(96, 18);
            this.checkBox4.TabIndex = 115;
            this.checkBox4.Text = "Show Symbol";
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
            this.label30.Location = new System.Drawing.Point(114, 54);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 20);
            this.label30.TabIndex = 116;
            this.toolTip1.SetToolTip(this.label30, "Coded to add a symbol in series 2. \r\nHence legend item 2 alone will show \r\nsymbol" +
                    "");
            // 
            // cmbLegendType
            // 
            this.cmbLegendType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLegendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLegendType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbLegendType.ForeColor = System.Drawing.Color.Black;
            this.cmbLegendType.Location = new System.Drawing.Point(79, 126);
            this.cmbLegendType.Name = "cmbLegendType";
            this.cmbLegendType.Size = new System.Drawing.Size(90, 21);
            this.cmbLegendType.TabIndex = 4;
            this.cmbLegendType.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label42.ForeColor = System.Drawing.Color.Black;
            this.label42.Location = new System.Drawing.Point(12, 102);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(52, 13);
            this.label42.TabIndex = 138;
            this.label42.Text = "Hide Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type";
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Image = ((System.Drawing.Image)(resources.GetObject("label31.Image")));
            this.label31.Location = new System.Drawing.Point(115, 79);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(20, 20);
            this.label31.TabIndex = 118;
            this.toolTip1.SetToolTip(this.label31, "Programmed to show a custom image in legend item 1");
            // 
            // comboBox9
            // 
            this.comboBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox9.ForeColor = System.Drawing.Color.Black;
            this.comboBox9.Items.AddRange(new object[] {
            "Anguilla",
            "Argentina",
            "Bahamas",
            "Belize",
            "Bolivia",
            "Canada",
            "Chile",
            "Colombia",
            "None"});
            this.comboBox9.Location = new System.Drawing.Point(79, 102);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(90, 21);
            this.comboBox9.TabIndex = 137;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // designerPanel5
            // 
            this.designerPanel5.BackColor = System.Drawing.Color.White;
            this.designerPanel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(237))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))))});
            this.designerPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.designerPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel5.Controls.Add(this.comboBox10);
            this.designerPanel5.Controls.Add(this.label6);
            this.designerPanel5.Controls.Add(this.label3);
            this.designerPanel5.Controls.Add(this.comboBox5);
            this.designerPanel5.Controls.Add(this.comboBox1);
            this.designerPanel5.Controls.Add(this.comboBox4);
            this.designerPanel5.Controls.Add(this.label10);
            this.designerPanel5.Controls.Add(this.label8);
            this.designerPanel5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.designerPanel5.HeaderImage = ((System.Drawing.Image)(resources.GetObject("designerPanel5.HeaderImage")));
            this.designerPanel5.HeaderText = "       Item Alignment";
            this.designerPanel5.Location = new System.Drawing.Point(12, 421);
            this.designerPanel5.Name = "designerPanel5";
            this.designerPanel5.Size = new System.Drawing.Size(209, 150);
            this.designerPanel5.TabIndex = 143;
            // 
            // comboBox10
            // 
            this.comboBox10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox10.Items.AddRange(new object[] {
            "All",
            "Dockable",
            "Movable",
            "None"});
            this.comboBox10.Location = new System.Drawing.Point(88, 107);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(90, 21);
            this.comboBox10.TabIndex = 87;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 88;
            this.label6.Text = "Behavior";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Placement";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox5.ForeColor = System.Drawing.Color.Black;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Near",
            "Center",
            "Far"});
            this.comboBox5.Location = new System.Drawing.Point(88, 80);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(90, 21);
            this.comboBox5.TabIndex = 79;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom",
            "Floating"});
            this.comboBox1.Location = new System.Drawing.Point(88, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 78;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Inside",
            "Outside"});
            this.comboBox4.Location = new System.Drawing.Point(88, 31);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(90, 21);
            this.comboBox4.TabIndex = 77;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "Alignment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "Position";
            // 
            // designerPanel4
            // 
            this.designerPanel4.BackColor = System.Drawing.Color.White;
            this.designerPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(237))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))))});
            this.designerPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.designerPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel4.Controls.Add(this.label26);
            this.designerPanel4.Controls.Add(this.comboBox7);
            this.designerPanel4.Controls.Add(this.label29);
            this.designerPanel4.Controls.Add(this.label27);
            this.designerPanel4.Controls.Add(this.comboBox6);
            this.designerPanel4.Controls.Add(this.label28);
            this.designerPanel4.Controls.Add(this.numericUpDown2);
            this.designerPanel4.Controls.Add(this.numericUpDown3);
            this.designerPanel4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.designerPanel4.HeaderImage = ((System.Drawing.Image)(resources.GetObject("designerPanel4.HeaderImage")));
            this.designerPanel4.HeaderText = "       Items Position";
            this.designerPanel4.Location = new System.Drawing.Point(227, 421);
            this.designerPanel4.Name = "designerPanel4";
            this.designerPanel4.Size = new System.Drawing.Size(204, 150);
            this.designerPanel4.TabIndex = 142;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(7, 31);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 13);
            this.label26.TabIndex = 104;
            this.label26.Text = "Row Count";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Bottom",
            "Center",
            "Top"});
            this.comboBox7.Location = new System.Drawing.Point(87, 118);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(90, 21);
            this.comboBox7.TabIndex = 110;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(7, 118);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 13);
            this.label29.TabIndex = 109;
            this.label29.Text = "Text Alignment";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(7, 60);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 13);
            this.label27.TabIndex = 106;
            this.label27.Text = "Spacing";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Near",
            "Center",
            "Far"});
            this.comboBox6.Location = new System.Drawing.Point(87, 93);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(90, 21);
            this.comboBox6.TabIndex = 108;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(7, 93);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(76, 13);
            this.label28.TabIndex = 107;
            this.label28.Text = "Item Alignment";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numericUpDown2.Location = new System.Drawing.Point(87, 31);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown2.TabIndex = 103;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numericUpDown3.Location = new System.Drawing.Point(87, 60);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown3.TabIndex = 105;
            this.numericUpDown3.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // designerPanel3
            // 
            this.designerPanel3.BackColor = System.Drawing.Color.White;
            this.designerPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(237))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))))});
            this.designerPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.designerPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel3.Controls.Add(this.label12);
            this.designerPanel3.Controls.Add(this.label7);
            this.designerPanel3.Controls.Add(this.label1);
            this.designerPanel3.Controls.Add(this.label13);
            this.designerPanel3.Controls.Add(this.numericUpDown_FontSize);
            this.designerPanel3.Controls.Add(this.panel9);
            this.designerPanel3.Controls.Add(this.comboBox_Fontfamily);
            this.designerPanel3.Controls.Add(this.comboBox_FontStyle);
            this.designerPanel3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.designerPanel3.HeaderImage = ((System.Drawing.Image)(resources.GetObject("designerPanel3.HeaderImage")));
            this.designerPanel3.HeaderText = "       Font Settings";
            this.designerPanel3.Location = new System.Drawing.Point(572, 280);
            this.designerPanel3.Name = "designerPanel3";
            this.designerPanel3.Size = new System.Drawing.Size(256, 127);
            this.designerPanel3.TabIndex = 141;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(9, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 88;
            this.label12.Text = "Font Family";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Font Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Font Color";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(9, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 91;
            this.label13.Text = "Font Style";
            // 
            // numericUpDown_FontSize
            // 
            this.numericUpDown_FontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numericUpDown_FontSize.ForeColor = System.Drawing.Color.Black;
            this.numericUpDown_FontSize.Location = new System.Drawing.Point(76, 96);
            this.numericUpDown_FontSize.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numericUpDown_FontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown_FontSize.Name = "numericUpDown_FontSize";
            this.numericUpDown_FontSize.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown_FontSize.TabIndex = 90;
            this.numericUpDown_FontSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_FontSize.ValueChanged += new System.EventHandler(this.numericUpDown_FontSize_ValueChanged);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.textBox_TextColor);
            this.panel9.Controls.Add(this.colorPicker_TextColor);
            this.panel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panel9.ForeColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(192, 97);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(41, 19);
            this.panel9.TabIndex = 85;
            // 
            // textBox_TextColor
            // 
            this.textBox_TextColor.BackColor = System.Drawing.Color.Black;
            this.textBox_TextColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_TextColor.Location = new System.Drawing.Point(0, 0);
            this.textBox_TextColor.Name = "textBox_TextColor";
            this.textBox_TextColor.ReadOnly = true;
            this.textBox_TextColor.Size = new System.Drawing.Size(22, 20);
            this.textBox_TextColor.TabIndex = 11;
            // 
            // colorPicker_TextColor
            // 
            this.colorPicker_TextColor.BackColor = System.Drawing.Color.Black;
            this.colorPicker_TextColor.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPicker_TextColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker_TextColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPicker_TextColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPicker_TextColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPicker_TextColor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPicker_TextColor.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker_TextColor.Image")));
            this.colorPicker_TextColor.Location = new System.Drawing.Point(22, 0);
            this.colorPicker_TextColor.Name = "colorPicker_TextColor";
            this.colorPicker_TextColor.SelectedAsBackcolor = true;
            this.colorPicker_TextColor.SelectedColor = System.Drawing.Color.Black;
            this.colorPicker_TextColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPicker_TextColor.Size = new System.Drawing.Size(17, 17);
            this.colorPicker_TextColor.TabIndex = 14;
            this.colorPicker_TextColor.Text = "...";
            this.colorPicker_TextColor.UseVisualStyleBackColor = false;
            this.colorPicker_TextColor.ColorSelected += new System.EventHandler(this.colorPicker_TextColor_ColorSelected);
            // 
            // comboBox_Fontfamily
            // 
            this.comboBox_Fontfamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_Fontfamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Fontfamily.DropDownWidth = 150;
            this.comboBox_Fontfamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox_Fontfamily.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Fontfamily.Items.AddRange(new object[] {
            "Agency FB",
            "Arial",
            "Book Antiqua",
            "Bookman Old Style",
            "Bradley Hand ITC",
            "Courier New",
            "Calibri",
            "Curlz MT",
            "Estrangelo Edessa",
            "Felix Titling",
            "Gautami",
            "Gill Sans MT Ext Condensed Bold",
            "Impact",
            "Microsoft Sans Serif",
            "MS Outlook",
            "Pristina",
            "Raavi",
            "Symbol",
            "Tahoma",
            "Times New Roman",
            "Verdana"});
            this.comboBox_Fontfamily.Location = new System.Drawing.Point(75, 42);
            this.comboBox_Fontfamily.Name = "comboBox_Fontfamily";
            this.comboBox_Fontfamily.Size = new System.Drawing.Size(158, 21);
            this.comboBox_Fontfamily.TabIndex = 87;
            this.comboBox_Fontfamily.SelectedIndexChanged += new System.EventHandler(this.comboBox_Fontfamily_SelectedIndexChanged);
            // 
            // comboBox_FontStyle
            // 
            this.comboBox_FontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FontStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox_FontStyle.ForeColor = System.Drawing.Color.Black;
            this.comboBox_FontStyle.FormattingEnabled = true;
            this.comboBox_FontStyle.Location = new System.Drawing.Point(75, 69);
            this.comboBox_FontStyle.Name = "comboBox_FontStyle";
            this.comboBox_FontStyle.Size = new System.Drawing.Size(157, 21);
            this.comboBox_FontStyle.TabIndex = 89;
            this.comboBox_FontStyle.SelectedIndexChanged += new System.EventHandler(this.comboBox_FontStyle_SelectedIndexChanged);
            // 
            // designerPanel2
            // 
            this.designerPanel2.BackColor = System.Drawing.Color.White;
            this.designerPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(237))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))))});
            this.designerPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.designerPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel2.Controls.Add(this.checkBox7);
            this.designerPanel2.Controls.Add(this.label9);
            this.designerPanel2.Controls.Add(this.label11);
            this.designerPanel2.Controls.Add(this.comboBox8);
            this.designerPanel2.Controls.Add(this.label34);
            this.designerPanel2.Controls.Add(this.numericUpDown5);
            this.designerPanel2.Controls.Add(this.panel7);
            this.designerPanel2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.designerPanel2.HeaderImage = ((System.Drawing.Image)(resources.GetObject("designerPanel2.HeaderImage")));
            this.designerPanel2.HeaderText = "       Border Settings";
            this.designerPanel2.Location = new System.Drawing.Point(572, 135);
            this.designerPanel2.Name = "designerPanel2";
            this.designerPanel2.Size = new System.Drawing.Size(256, 130);
            this.designerPanel2.TabIndex = 140;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.checkBox7.ForeColor = System.Drawing.Color.Black;
            this.checkBox7.Location = new System.Drawing.Point(18, 36);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(87, 17);
            this.checkBox7.TabIndex = 102;
            this.checkBox7.Text = "Show Border";
            this.checkBox7.UseVisualStyleBackColor = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(15, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 100;
            this.label9.Text = "Dash Style";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(15, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 104;
            this.label11.Text = "Width";
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot",
            "Custom"});
            this.comboBox8.Location = new System.Drawing.Point(79, 65);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(157, 21);
            this.comboBox8.TabIndex = 101;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(130, 99);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(59, 13);
            this.label34.TabIndex = 106;
            this.label34.Text = "Back Color";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.numericUpDown5.Location = new System.Drawing.Point(80, 97);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown5.TabIndex = 103;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.textBox6);
            this.panel7.Controls.Add(this.colorPickerButton5);
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.panel7.Location = new System.Drawing.Point(195, 99);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(41, 19);
            this.panel7.TabIndex = 105;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Silver;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(22, 20);
            this.textBox6.TabIndex = 11;
            // 
            // colorPickerButton5
            // 
            this.colorPickerButton5.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton5.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton5.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton5.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton5.Image")));
            this.colorPickerButton5.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton5.Name = "colorPickerButton5";
            this.colorPickerButton5.SelectedAsBackcolor = true;
            this.colorPickerButton5.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton5.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton5.Size = new System.Drawing.Size(17, 17);
            this.colorPickerButton5.TabIndex = 14;
            this.colorPickerButton5.Text = "...";
            this.colorPickerButton5.UseVisualStyleBackColor = false;
            this.colorPickerButton5.ColorSelected += new System.EventHandler(this.colorPickerButton5_ColorSelected);
            // 
            // designerPanel1
            // 
            this.designerPanel1.BackColor = System.Drawing.Color.White;
            this.designerPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(237))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))))});
            this.designerPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.designerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel1.Controls.Add(this.comboBox2);
            this.designerPanel1.Controls.Add(this.label19);
            this.designerPanel1.Controls.Add(this.panel3);
            this.designerPanel1.Controls.Add(this.label17);
            this.designerPanel1.Controls.Add(this.label18);
            this.designerPanel1.Controls.Add(this.panel2);
            this.designerPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.designerPanel1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("designerPanel1.HeaderImage")));
            this.designerPanel1.HeaderText = "       Back Interior";
            this.designerPanel1.Location = new System.Drawing.Point(572, 14);
            this.designerPanel1.Name = "designerPanel1";
            this.designerPanel1.Size = new System.Drawing.Size(252, 108);
            this.designerPanel1.TabIndex = 139;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownWidth = 150;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(78, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 21);
            this.comboBox2.TabIndex = 93;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 92;
            this.label19.Text = "Gradient Style";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.colorPickerButton2);
            this.panel3.Location = new System.Drawing.Point(194, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(41, 19);
            this.panel3.TabIndex = 91;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(22, 21);
            this.textBox2.TabIndex = 11;
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.White;
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton2.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton2.Image")));
            this.colorPickerButton2.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton2.Size = new System.Drawing.Size(17, 17);
            this.colorPickerButton2.TabIndex = 14;
            this.colorPickerButton2.Text = "...";
            this.colorPickerButton2.UseVisualStyleBackColor = false;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.colorPickerButton2_ColorSelected);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(125, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 89;
            this.label17.Text = "Fore Color";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(3, 75);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 90;
            this.label18.Text = "Back Color";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.colorPickerButton1);
            this.panel2.Location = new System.Drawing.Point(78, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 19);
            this.panel2.TabIndex = 88;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(22, 21);
            this.textBox1.TabIndex = 11;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton1.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton1.Image")));
            this.colorPickerButton1.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton1.Size = new System.Drawing.Size(17, 17);
            this.colorPickerButton1.TabIndex = 14;
            this.colorPickerButton1.Text = "...";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 579);
            this.Controls.Add(this.designerPanel7);
            this.Controls.Add(this.designerPanel6);
            this.Controls.Add(this.designerPanel5);
            this.Controls.Add(this.designerPanel4);
            this.Controls.Add(this.designerPanel3);
            this.Controls.Add(this.designerPanel2);
            this.Controls.Add(this.designerPanel1);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Legend";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel7)).EndInit();
            this.designerPanel7.ResumeLayout(false);
            this.designerPanel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel6)).EndInit();
            this.designerPanel6.ResumeLayout(false);
            this.designerPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel5)).EndInit();
            this.designerPanel5.ResumeLayout(false);
            this.designerPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel4)).EndInit();
            this.designerPanel4.ResumeLayout(false);
            this.designerPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel3)).EndInit();
            this.designerPanel3.ResumeLayout(false);
            this.designerPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_FontSize)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel2)).EndInit();
            this.designerPanel2.ResumeLayout(false);
            this.designerPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel1)).EndInit();
            this.designerPanel1.ResumeLayout(false);
            this.designerPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
       
            foreach (string fontstyle in Enum.GetNames(typeof(System.Drawing.FontStyle)))
                this.comboBox_FontStyle.Items.Add(fontstyle);

            foreach (string gradientstyle in Enum.GetNames(typeof(GradientStyle)))
                this.comboBox2.Items.Add(gradientstyle);

            this.comboBox_FontStyle.SelectedIndex = 0;
            this.comboBox_Fontfamily.SelectedIndex = 13;
            this.comboBox2.SelectedIndex = 4;
            this.chartControl1.Legend.ShowItemsShadow = false;
            this.panel4.Enabled = false;

            this.comboBox8.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 1;
            this.comboBox1.SelectedIndex = 3;
            this.comboBox4.SelectedIndex = 1;
            this.comboBox5.SelectedIndex = 1;
            this.comboBox6.SelectedIndex = 0;
            this.comboBox7.SelectedIndex = 1;
            this.comboBox9.SelectedIndex = 8;
            this.comboBox10.SelectedIndex = 0;
            this.chartControl1.Legend.ShowBorder = true;
            this.chartControl1.Legend.VisibleCheckBox = true;

            foreach (string representationtype in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartLegendRepresentationType)))
            {
                this.cmbLegendType.Items.Add(representationtype);
            }
            this.cmbLegendType.SelectedIndex = 2;
            ChartAppearance.ApplyChartStyles(this.chartControl1);

        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        private void InitializeChartData()
        {
            this.chartControl1.Text = "Population Statistics";

            ChartSeries series1 = new ChartSeries();
            series1.Name = "Anguilla";
            series1.Text = series1.Name;
            series1.SeriesIndexedModelImpl = new ArrayModel(new double[] { 1000.500, 1100.797, 1500.000 });
            series1.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series1);
            series1.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(91, 66, 98), Color.FromArgb(192, 167, 199));
            series1.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series1.Style.ImageIndex = 0;

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Argentina";
            series2.Text = series2.Name;
            series2.SeriesIndexedModelImpl = new ArrayModel(new double[] { 25955.82, 36955.182, 38955.182 });
            series2.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series2);
            series2.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series2.Style.ImageIndex = 1;
            series2.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(81, 81, 204), Color.FromArgb(171, 171, 255));

            ChartSeries series3 = new ChartSeries();
            series3.Name = "Bahamas";
            series3.Text = series3.Name;
            series3.SeriesIndexedModelImpl = new ArrayModel(new double[] { 2040.082, 2940.982, 2960.982 });
            series3.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series3);
            series3.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series3.Style.ImageIndex = 3;
            series3.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(21, 131, 132), Color.FromArgb(118, 206, 210));

            ChartSeries series4 = new ChartSeries();
            series4.Name = "Belize";
            series4.Text = series4.Name;
            series4.SeriesIndexedModelImpl = new ArrayModel(new double[] { 2350.183, 2490.183, 2550.183 });
            series4.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series4);
            series4.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series4.Style.ImageIndex = 5;
            series4.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(119, 131, 31), Color.FromArgb(210, 223, 135));
            series4.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(214, 43, 43), Color.FromArgb(255, 132, 132));

            ChartSeries series5 = new ChartSeries();
            series5.Name = "Bolivia";
            series5.Text = series5.Name;
            series5.SeriesIndexedModelImpl = new ArrayModel(new double[] { 7812.520, 8152.620, 8002.620 });
            series5.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series5);
            series5.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series5.Style.ImageIndex = 6;
            series5.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(170, 137, 8), Color.FromArgb(254, 227, 136));

            ChartSeries series6 = new ChartSeries();
            series6.Name = "Canada";
            series6.Text = series6.Name;
            series6.SeriesIndexedModelImpl = new ArrayModel(new double[] { 30281.092, 31281.092, 31581.092 });
            series6.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series6);
            series6.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series6.Style.ImageIndex = 8;

            series6.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(158, 57, 113), Color.FromArgb(252, 169, 215));

            ChartSeries series7 = new ChartSeries();
            series7.Name = "Chile";
            series7.Text = series7.Name;
            series7.SeriesIndexedModelImpl = new ArrayModel(new double[] { 10153.797, 15153.797, 16153.797 });
            series7.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series7);
            series7.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series7.Style.ImageIndex = 9;
            series7.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(171, 106, 38), Color.FromArgb(255, 189, 133));

            ChartSeries series8 = new ChartSeries();
            series8.Name = "Colombia";
            series8.Text = series8.Name;
            series8.SeriesIndexedModelImpl = new ArrayModel(new double[] { 32685.655, 35685.655, 37685.655 });
            series8.Type = ChartSeriesType.Column;
            this.chartControl1.Series.Add(series8);
            series8.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series8.Style.ImageIndex = 10;
            series8.Style.Interior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(164, 42, 5), Color.FromArgb(244, 147, 114));

            this.chartControl1.Legend.OnlyColumnsForFloating = false;            
            this.chartControl1.Indexed = true;


            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                this.chartControl1.Series[i].Style.Border.Color = Color.Transparent;
            }

        }
        #endregion

        #region ChangeFont
        private void ChangeFont()
        {
            if (this.comboBox_Fontfamily.SelectedItem != null)
            {
                FontStyle fs = (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox_FontStyle.SelectedItem.ToString(), true);
                this.chartControl1.Legend.Font = new Font(this.comboBox_Fontfamily.SelectedItem.ToString(), (float)this.numericUpDown_FontSize.Value, fs);
            }
        }

        #endregion


        #endregion

        #region Events

        private void cmbFontFace_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        #region ChartFormatAxisLabel
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {

            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                switch ((int)e.Value)
                {
                    case 0:
                        e.Label = "1995";
                        break;
                    case 1:
                        e.Label = "2000";
                        break;
                    case 2:
                        e.Label = "2005";
                        break;
                    default:
                        e.Label = "";
                        break;

                }

            }

            e.Handled = true;
        }
        #endregion

        #region Legend Alignment
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.LegendsPlacement = (ChartPlacement)Enum.Parse(typeof(ChartPlacement), this.comboBox4.SelectedItem.ToString(), true);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.LegendPosition = (ChartDock)Enum.Parse(typeof(ChartDock), this.comboBox1.SelectedItem.ToString(), true);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.LegendAlignment = (ChartAlignment)Enum.Parse(typeof(ChartAlignment), this.comboBox5.SelectedItem.ToString(), true);
        }

        #endregion

        #region Font Settings
        private void comboBox_Fontfamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void comboBox_FontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void numericUpDown_FontSize_ValueChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void colorPicker_TextColor_ColorSelected(object sender, EventArgs e)
        {
            foreach (ChartLegendItem item in this.chartControl1.Legend.Items)
            {
                item.TextColor = this.colorPicker_TextColor.SelectedColor;
            }
            this.textBox_TextColor.BackColor = this.colorPicker_TextColor.SelectedColor;
            this.Refresh();

        }
        #endregion

        #region  BackInterior
        protected void SetBackInterior()
        {
            this.chartControl1.Legend.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox2.SelectedItem.ToString(), true), this.colorPickerButton1.SelectedColor, this.colorPickerButton2.SelectedColor);
        }
        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            SetBackInterior();
            this.textBox1.BackColor = this.colorPickerButton1.SelectedColor;
            this.Refresh();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SetBackInterior();
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            SetBackInterior();
            this.textBox2.BackColor = this.colorPickerButton2.SelectedColor;
            this.Refresh();
        }
        #endregion

        #region Shadow
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.chartControl1.Legend.ShowItemsShadow = true;
                this.panel4.Enabled = true;

            }
            else
            {
                this.chartControl1.Legend.ShowItemsShadow = false;
                this.panel4.Enabled = false;

            }
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.Legend.ItemsShadowColor = this.colorPickerButton3.SelectedColor;
            this.textBox3.BackColor = this.colorPickerButton3.SelectedColor;
            this.Refresh();
        }


        #endregion

        #region Title
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Text = this.textBox4.Text;
        }

        private void colorPickerButton4_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.Legend.ForeColor = this.colorPickerButton4.SelectedColor;
            this.textBox5.BackColor = this.colorPickerButton4.SelectedColor;
            this.Refresh();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.TextAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), this.comboBox3.SelectedItem.ToString(), true);
        }
        #endregion

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.RowsCount = (int)this.numericUpDown2.Value;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Spacing = (int)this.numericUpDown3.Value;

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.ItemsAlignment = (StringAlignment)Enum.Parse(typeof(StringAlignment), this.comboBox6.SelectedItem.ToString(), true);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.ItemsTextAligment = (VerticalAlignment)Enum.Parse(typeof(VerticalAlignment), this.comboBox7.SelectedItem.ToString(), true);

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            this.chartControl1.Legend.VisibleCheckBox = this.checkBox2.Checked;
        }

        #region HideItem


        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ChartLegendItem item in this.chartControl1.Legend.Items)
            {
                item.Visible = true;
            }
            this.chartControl1.Refresh();
            if (this.comboBox9.SelectedIndex < 8)
            {
                this.chartControl1.Legend.Items[(int)this.comboBox9.SelectedIndex].Visible = false;
                this.chartControl1.Refresh();
            }

        }



        #endregion

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox4.Checked)
            {
                //Set symbol for first series
                this.chartControl1.Series[1].Style.Symbol.Shape = ChartSymbolShape.Circle;
                this.chartControl1.Series[1].Style.Symbol.Color = Color.Red;
                this.chartControl1.Series[1].Style.Symbol.Size = new Size(7, 7);
                this.chartControl1.Legend.ShowSymbol = true;
            }
            else
            {
                this.chartControl1.Series[1].Style.Symbol.Shape = ChartSymbolShape.None;
                this.chartControl1.Legend.ShowSymbol = false;
            }
            this.chartControl1.Refresh();
        }
        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Legend.RepresentationType = (ChartLegendRepresentationType)Enum.Parse(typeof(ChartLegendRepresentationType), this.cmbLegendType.SelectedItem.ToString(), true);


        }
        #region Custom Image
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                //An Item is added with custom image. 
                ChartLegendItem cli = new ChartLegendItem("Custom Image");
                ChartLegendItemsCollection clic = new ChartLegendItemsCollection();
                cli.Type = ChartLegendItemType.Image;
                cli.ImageList = new ChartImageCollection();
                cli.ImageList.Add(this.imageListAdv1.Images[12]);
                cli.ImageIndex = 0;
                clic.Add(cli);
                this.chartControl1.Legend.CustomItems = clic.ToArray();

                //  //Custom image could be set for existing items with the below code
                //  this.chartControl1.Legend.Items[0].ImageList = new ChartImageCollection();
                //  this.chartControl1.Legend.Items[0].ImageList.Add(this.imageListAdv1.Images[12]);
                //  this.chartControl1.Legend.Items[0].ImageIndex = 0;
                //    this.chartControl1.Legend.Items[0].Type = ChartLegendItemType.Image;

            }
            else
            {
                this.chartControl1.Legend.CustomItems = null;
            }
        }
        #endregion



        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.chartControl1.Legend.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox8.SelectedItem.ToString(), true);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Border.Width = (int)this.numericUpDown5.Value;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox7.Checked)
            {
                this.comboBox8.Enabled = true;
                this.panel7.Enabled = true;
                this.numericUpDown5.Enabled = true;
                this.chartControl1.Legend.ShowBorder = true;
            }

            else
            {
                this.comboBox8.Enabled = false;
                this.panel7.Enabled = false;
                this.numericUpDown5.Enabled = false;
                this.chartControl1.Legend.ShowBorder = false;
            }
        }

        private void colorPickerButton5_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Border.ForeColor = this.colorPickerButton5.SelectedColor;
            this.textBox6.BackColor = this.colorPickerButton5.SelectedColor;
            this.Refresh();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.Behavior = (ChartDockingFlags)Enum.Parse(typeof(ChartDockingFlags), this.comboBox10.SelectedItem.ToString(), true);
        }
        #endregion


    }
}
