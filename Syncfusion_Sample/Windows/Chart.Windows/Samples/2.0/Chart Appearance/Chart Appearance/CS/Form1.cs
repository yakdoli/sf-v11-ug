using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace ChartAppearance
{
    public class Form1 : Office2007Form
    {
        #region Private Members

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timer1;
        string filename = null;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboBox3;
        private Label label4;
        private NumericUpDown numericUpDown4;
        private Label label17;
        private Panel panel2;
        private ColorPickerButton colorPickerButton3;
        private TextBox textBox1;
        private Label label18;
        private Panel panel3;
        private TextBox textBox2;
        private ColorPickerButton colorPickerButton2;
        private NumericUpDown numericUpDown5;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label10;
        private Label label11;
        private Label label23;
        private Panel panel5;
        private TextBox textBox4;
        private ColorPickerButton colorPickerButton6;
        private Panel panel4;
        private TextBox textBox3;
        private ColorPickerButton colorPickerButton5;
        private Label label34;
        private Panel panel6;
        private TextBox textBox5;
        private ColorPickerButton colorPickerButton1;
        private Panel panel7;
        private TextBox textBox6;
        private ColorPickerButton colorPickerButton7;
        private Label label35;
        private Panel panel8;
        private TextBox textBox7;
        private ColorPickerButton colorPickerButton8;
        private Panel panel9;
        private TextBox textBox8;
        private ColorPickerButton colorPickerButton9;
        private Button button1;
        private Button Btn_Clear;
        private ComboBox comboBox8;
        private Label label19;
        private Label label30;
        private CheckBox checkBox5;
        private Label label31;
        private ComboBox comboBox9;
        private ColorPickerButton colorPickerButton4;
        private ComboBox comboBox6;
        private Label label6;
        private Label label5;
        private ComboBox comboBox5;
        private Panel panel10;
        private TextBox textBox9;
        private Label label20;
        private Label label15;
        private Label label22;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private NumericUpDown numericUpDown2;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label label21;
        private ComboBox comboBox7;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private CheckBox checkBox1;
        private Label label24;
        private Label label16;
        private Label label12;
        private Label label9;
        private Label label25;
        private Label label27;
        private Label label14;
        private Label label13;
        private Label label26;
        private Label label28;
        private RadioButton radioButton1;
        private Label label29;
        private ToolTip toolTip1;
        private ChartControl chartControl1;
        private Panel panel11;

        private string Font_Name;

        #endregion

        #region Constructor, Main And Dispose
        public Form1()
        {
            InitializeComponent();
            InitializeControlSettings();
            InitializeChartData();
            FillControlPanel();
            this.textBox8.BackColor = Color.FromArgb(191, 219, 254);
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

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.colorPickerButton9.SelectedColor = System.Drawing.Color.FromArgb(191, 219, 254);
            this.comboBox8.SelectedIndex = 5;
            for (int i = 0; i <= 2; i++)
            {
                this.chartControl1.Series[i].Style.DisplayText = this.checkBox1.Checked;
                this.chartControl1.Series[i].Style.TextOrientation = ChartTextOrientation.Up;
            }
            ChartAppearance.ApplyChartStyles(this.chartControl1);
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label30 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label35 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.colorPickerButton8 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.colorPickerButton9 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label34 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.colorPickerButton7 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.colorPickerButton6 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.colorPickerButton5 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.colorPickerButton4 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label31 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.comboBox8);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.Btn_Clear);
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.comboBox6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(484, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 461);
            this.panel1.TabIndex = 0;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label29.Image = ((System.Drawing.Image)(resources.GetObject("label29.Image")));
            this.label29.Location = new System.Drawing.Point(413, 60);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(20, 20);
            this.label29.TabIndex = 68;
            this.toolTip1.SetToolTip(this.label29, "Select Series and then select Symbol to apply in the chartcontrol");
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(385, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 18);
            this.radioButton1.TabIndex = 67;
            this.radioButton1.Text = "Series 2";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label28.Location = new System.Drawing.Point(270, 13);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 13);
            this.label28.TabIndex = 66;
            this.label28.Text = "Select series:";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(14, 340);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 24);
            this.label27.TabIndex = 63;
            this.label27.Text = "Font settings";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label14.Location = new System.Drawing.Point(18, 353);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 1);
            this.label14.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(194, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 24);
            this.label13.TabIndex = 64;
            this.label13.Text = "Shadow";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label26.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label26.Image = ((System.Drawing.Image)(resources.GetObject("label26.Image")));
            this.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label26.Location = new System.Drawing.Point(20, 11);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 24);
            this.label26.TabIndex = 62;
            this.label26.Text = "Series settings";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label16.Location = new System.Drawing.Point(67, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(110, 1);
            this.label16.TabIndex = 61;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(187, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 24);
            this.label12.TabIndex = 60;
            this.label12.Text = "3D Mode";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(4, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 59;
            this.label9.Text = "      Background \r\n      Settings";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(10, 5);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 24);
            this.label25.TabIndex = 58;
            this.label25.Text = "Border Settings";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox8.Location = new System.Drawing.Point(90, 285);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(87, 21);
            this.comboBox8.TabIndex = 35;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label24
            // 
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(14, 311);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 29);
            this.label24.TabIndex = 57;
            this.label24.Text = "Background Image";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label11.Location = new System.Drawing.Point(14, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 1);
            this.label11.TabIndex = 26;
            // 
            // comboBox7
            // 
            this.comboBox7.BackColor = System.Drawing.Color.White;
            this.comboBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.ForeColor = System.Drawing.Color.Black;
            this.comboBox7.Location = new System.Drawing.Point(345, 58);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(64, 21);
            this.comboBox7.TabIndex = 56;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.SymbolShape_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(197, 313);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 52;
            this.label22.Text = "Tilt";
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Clear.Image")));
            this.Btn_Clear.Location = new System.Drawing.Point(138, 316);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(22, 23);
            this.Btn_Clear.TabIndex = 31;
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Visible = false;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(291, 312);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.ReadOnly = true;
            this.numericUpDown3.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown3.TabIndex = 51;
            this.numericUpDown3.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label30.Location = new System.Drawing.Point(199, 355);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(160, 1);
            this.label30.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(197, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Series Spacing";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(92, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChartControlBackGroundImage_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(291, 283);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown2.TabIndex = 49;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.Spacing_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(268, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(75, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "Symbol Shape";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(197, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = " Z Axis Depth";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(291, 253);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 47;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.Depth_ValueChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.checkBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox5.ForeColor = System.Drawing.Color.Black;
            this.checkBox5.Location = new System.Drawing.Point(193, 367);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(136, 17);
            this.checkBox5.TabIndex = 34;
            this.checkBox5.Text = "Show ChartArea Shadow";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.ChartAreaShadow_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(197, 224);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 18);
            this.checkBox2.TabIndex = 46;
            this.checkBox2.Text = "Rotate Axis";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.RotateAxis_CheckedChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(14, 287);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Gradient Style";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox3.ForeColor = System.Drawing.Color.Black;
            this.checkBox3.Location = new System.Drawing.Point(197, 191);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 18);
            this.checkBox3.TabIndex = 45;
            this.checkBox3.Text = "3D Mode";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.Black;
            this.label35.Location = new System.Drawing.Point(14, 256);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(67, 13);
            this.label35.TabIndex = 34;
            this.label35.Text = "Chart Interior";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.textBox7);
            this.panel8.Controls.Add(this.colorPickerButton8);
            this.panel8.Location = new System.Drawing.Point(138, 254);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(41, 21);
            this.panel8.TabIndex = 33;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(0, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(22, 20);
            this.textBox7.TabIndex = 11;
            // 
            // colorPickerButton8
            // 
            this.colorPickerButton8.BackColor = System.Drawing.Color.White;
            this.colorPickerButton8.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton8.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton8.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton8.Image")));
            this.colorPickerButton8.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton8.Name = "colorPickerButton8";
            this.colorPickerButton8.SelectedAsBackcolor = true;
            this.colorPickerButton8.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton8.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton8.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton8.TabIndex = 15;
            this.colorPickerButton8.Text = "...";
            this.colorPickerButton8.UseVisualStyleBackColor = false;
            this.colorPickerButton8.ColorSelected += new System.EventHandler(this.ChartInterior_ColorChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(7, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 119);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chart Control";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Border Style";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox3.Location = new System.Drawing.Point(89, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(80, 21);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.ChartBorderStyle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Border Width";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(91, 49);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown4.TabIndex = 11;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // label17
            // 
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(4, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 20);
            this.label17.TabIndex = 13;
            this.label17.Text = "Border Color";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.colorPickerButton3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(92, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(47, 21);
            this.panel2.TabIndex = 14;
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton3.Location = new System.Drawing.Point(28, 0);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.SelectedAsBackcolor = true;
            this.colorPickerButton3.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton3.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton3.TabIndex = 6;
            this.colorPickerButton3.Text = "...";
            this.colorPickerButton3.UseVisualStyleBackColor = false;
            this.colorPickerButton3.ColorSelected += new System.EventHandler(this.colorPickerButton3_ColorSelected);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(45, 20);
            this.textBox1.TabIndex = 11;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.textBox8);
            this.panel9.Controls.Add(this.colorPickerButton9);
            this.panel9.Location = new System.Drawing.Point(90, 253);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(41, 21);
            this.panel9.TabIndex = 32;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Location = new System.Drawing.Point(0, 0);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(22, 20);
            this.textBox8.TabIndex = 11;
            // 
            // colorPickerButton9
            // 
            this.colorPickerButton9.BackColor = System.Drawing.Color.White;
            this.colorPickerButton9.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton9.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton9.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton9.Image")));
            this.colorPickerButton9.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton9.Name = "colorPickerButton9";
            this.colorPickerButton9.SelectedAsBackcolor = true;
            this.colorPickerButton9.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton9.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton9.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton9.TabIndex = 14;
            this.colorPickerButton9.Text = "...";
            this.colorPickerButton9.UseVisualStyleBackColor = false;
            this.colorPickerButton9.ColorSelected += new System.EventHandler(this.ChartInterior_ColorChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Location = new System.Drawing.Point(327, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 18);
            this.radioButton3.TabIndex = 54;
            this.radioButton3.Text = "Series 1";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(14, 227);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(57, 13);
            this.label34.TabIndex = 31;
            this.label34.Text = "Chart Area";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.textBox5);
            this.panel6.Controls.Add(this.colorPickerButton1);
            this.panel6.Location = new System.Drawing.Point(138, 224);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(41, 21);
            this.panel6.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(0, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(22, 20);
            this.textBox5.TabIndex = 11;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.White;
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
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton1.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton1.TabIndex = 15;
            this.colorPickerButton1.Text = "...";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.ChartArea_ColorChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.radioButton4.Checked = true;
            this.radioButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Location = new System.Drawing.Point(267, 32);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 18);
            this.radioButton4.TabIndex = 53;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Series 0";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.textBox6);
            this.panel7.Controls.Add(this.colorPickerButton7);
            this.panel7.Location = new System.Drawing.Point(90, 224);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(41, 21);
            this.panel7.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(22, 20);
            this.textBox6.TabIndex = 11;
            // 
            // colorPickerButton7
            // 
            this.colorPickerButton7.BackColor = System.Drawing.Color.White;
            this.colorPickerButton7.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton7.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton7.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton7.Image")));
            this.colorPickerButton7.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton7.Name = "colorPickerButton7";
            this.colorPickerButton7.SelectedAsBackcolor = true;
            this.colorPickerButton7.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton7.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton7.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton7.TabIndex = 14;
            this.colorPickerButton7.Text = "...";
            this.colorPickerButton7.UseVisualStyleBackColor = false;
            this.colorPickerButton7.ColorSelected += new System.EventHandler(this.ChartArea_ColorChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label10.Location = new System.Drawing.Point(128, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(225, 1);
            this.label10.TabIndex = 7;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(14, 198);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 13);
            this.label23.TabIndex = 28;
            this.label23.Text = "Chart Control";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox4);
            this.panel5.Controls.Add(this.colorPickerButton6);
            this.panel5.Location = new System.Drawing.Point(139, 196);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 21);
            this.panel5.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(22, 20);
            this.textBox4.TabIndex = 11;
            // 
            // colorPickerButton6
            // 
            this.colorPickerButton6.BackColor = System.Drawing.Color.White;
            this.colorPickerButton6.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton6.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton6.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton6.Image")));
            this.colorPickerButton6.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton6.Name = "colorPickerButton6";
            this.colorPickerButton6.SelectedAsBackcolor = true;
            this.colorPickerButton6.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton6.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton6.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton6.TabIndex = 15;
            this.colorPickerButton6.Text = "...";
            this.colorPickerButton6.UseVisualStyleBackColor = false;
            this.colorPickerButton6.ColorSelected += new System.EventHandler(this.ChartControl_ColorChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(16, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 18);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "Show Data Point Text";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.Showtext_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.colorPickerButton5);
            this.panel4.Location = new System.Drawing.Point(90, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(41, 21);
            this.panel4.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(22, 20);
            this.textBox3.TabIndex = 11;
            // 
            // colorPickerButton5
            // 
            this.colorPickerButton5.BackColor = System.Drawing.Color.White;
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
            this.colorPickerButton5.SelectedColor = System.Drawing.Color.White;
            this.colorPickerButton5.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton5.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton5.TabIndex = 14;
            this.colorPickerButton5.Text = "...";
            this.colorPickerButton5.UseVisualStyleBackColor = false;
            this.colorPickerButton5.ColorSelected += new System.EventHandler(this.ChartControl_ColorChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.numericUpDown5);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(185, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 119);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chart Series";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.Location = new System.Drawing.Point(96, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(68, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.SeriesBorder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Border DashStyle";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(2, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Border Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Border Width";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.colorPickerButton2);
            this.panel3.Location = new System.Drawing.Point(96, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 21);
            this.panel3.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(28, 20);
            this.textBox2.TabIndex = 11;
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton2.Location = new System.Drawing.Point(28, 0);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.SelectedAsBackcolor = true;
            this.colorPickerButton2.SelectedColor = System.Drawing.Color.Transparent;
            this.colorPickerButton2.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton2.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton2.TabIndex = 5;
            this.colorPickerButton2.Text = "...";
            this.colorPickerButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.colorPickerButton2.UseVisualStyleBackColor = false;
            this.colorPickerButton2.ColorSelected += new System.EventHandler(this.SeriesBorderColor_ColorSelected);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(96, 51);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(47, 20);
            this.numericUpDown5.TabIndex = 20;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown5.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.textBox9);
            this.panel10.Controls.Add(this.colorPickerButton4);
            this.panel10.Location = new System.Drawing.Point(77, 425);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(47, 21);
            this.panel10.TabIndex = 49;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Black;
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Location = new System.Drawing.Point(0, 0);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(25, 20);
            this.textBox9.TabIndex = 11;
            // 
            // colorPickerButton4
            // 
            this.colorPickerButton4.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton4.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton4.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton4.Location = new System.Drawing.Point(25, 0);
            this.colorPickerButton4.Name = "colorPickerButton4";
            this.colorPickerButton4.SelectedAsBackcolor = true;
            this.colorPickerButton4.SelectedColor = System.Drawing.Color.Transparent;
            this.colorPickerButton4.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.StandardColors;
            this.colorPickerButton4.Size = new System.Drawing.Size(20, 19);
            this.colorPickerButton4.TabIndex = 45;
            this.colorPickerButton4.Text = "...";
            this.colorPickerButton4.UseVisualStyleBackColor = false;
            this.colorPickerButton4.ColorSelected += new System.EventHandler(this.FontColor_ColorSelected);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label31.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(18, 44);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 13);
            this.label31.TabIndex = 37;
            this.label31.Text = "Color Palette";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label15.Location = new System.Drawing.Point(244, 169);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 1);
            this.label15.TabIndex = 51;
            // 
            // comboBox9
            // 
            this.comboBox9.BackColor = System.Drawing.Color.White;
            this.comboBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox9.Location = new System.Drawing.Point(87, 41);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(96, 21);
            this.comboBox9.TabIndex = 36;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.ColorPalette_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label20.Location = new System.Drawing.Point(14, 429);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "Font Color";
            // 
            // comboBox6
            // 
            this.comboBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox6.Location = new System.Drawing.Point(77, 398);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(96, 21);
            this.comboBox6.TabIndex = 43;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.FontStyle_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(14, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "FontStyle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(14, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "FontFace";
            // 
            // comboBox5
            // 
            this.comboBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox5.Items.AddRange(new object[] {
            "Agency FB",
            "Arial",
            "Book Antiqua",
            "Bookman Old Style",
            "Bradley Hand ITC",
            "Courier New",
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
            "Times New Roman"});
            this.comboBox5.Location = new System.Drawing.Point(77, 371);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(97, 21);
            this.comboBox5.TabIndex = 42;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.FontName_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254))))));
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))));
            this.chartControl1.Legend.Location = new System.Drawing.Point(341, 31);
            this.chartControl1.Location = new System.Drawing.Point(17, 13);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(450, 341);
            this.chartControl1.TabIndex = 1;
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "";
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
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(233)))), ((int)(((byte)(254)))));
            this.panel11.Controls.Add(this.label29);
            this.panel11.Controls.Add(this.label21);
            this.panel11.Controls.Add(this.radioButton1);
            this.panel11.Controls.Add(this.comboBox9);
            this.panel11.Controls.Add(this.label28);
            this.panel11.Controls.Add(this.label31);
            this.panel11.Controls.Add(this.checkBox1);
            this.panel11.Controls.Add(this.radioButton4);
            this.panel11.Controls.Add(this.radioButton3);
            this.panel11.Controls.Add(this.label26);
            this.panel11.Controls.Add(this.comboBox7);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 371);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(484, 90);
            this.panel11.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Appearance";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Helper Methods

        #region InitializeChartData

        /// <summary>
        /// In this method chart data has been Initialized.
        /// </summary>
        protected void InitializeChartData()
        {
            // Top 5 olympic medal winners
            ChartSeries series1 = new ChartSeries("Gold");
            series1.Text = "Gold";
            series1.Type = ChartSeriesType.Column;

            ChartSeries series2 = new ChartSeries("Silver");
            series2.Text = "Silver";
            series2.Type = ChartSeriesType.Column;

            ChartSeries series3 = new ChartSeries("Bronze");
            series3.Text = "Bronze";
            series3.Type = ChartSeriesType.Column;

            // USA
            series1.Points.Add(1, 35);
            series2.Points.Add(1, 39);
            series3.Points.Add(1, 29);

            // China
            series1.Points.Add(2, 32);
            series2.Points.Add(2, 17);
            series3.Points.Add(2, 14);

            // Russia
            series1.Points.Add(3, 27);
            series2.Points.Add(3, 27);
            series3.Points.Add(3, 28);

            // Australia
            series1.Points.Add(4, 17);
            series2.Points.Add(4, 16);
            series3.Points.Add(4, 16);

            // China
            series1.Points.Add(5, 16);
            series2.Points.Add(5, 9);
            series3.Points.Add(5, 12);

            series1.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series2.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series3.Style.Images = new ChartImageCollection(this.imageList1.Images);

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
            this.chartControl1.Series.Add(series3);

            for (int i = 0; i < series1.Points.Count; i++)
                series1.Styles[i].Text = string.Format("{0}", series1.Points[i].YValues[0]);

            for (int i = 0; i < series2.Points.Count; i++)
                series2.Styles[i].Text = string.Format("{0}", series2.Points[i].YValues[0]);

            for (int i = 0; i < series3.Points.Count; i++)
                series3.Styles[i].Text = string.Format("{0}", series3.Points[i].YValues[0]);
        }

        #endregion

        #region InitializeControlSettings
        /// <summary>
        /// Setting Chart control properties.
        /// </summary>
        private void InitializeControlSettings()
        {
            this.checkBox2.Enabled = false;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown3.Enabled = false;

            foreach (ChartSeries series in this.chartControl1.Series)
            {
                if (series == this.chartControl1.Series[0])
                {
                    series.Style.Images = new ChartImageCollection(this.imageList1.Images);
                    series.Style.Symbol.Shape = ChartSymbolShape.Image;
                    series.Style.Symbol.Size = new Size(16, 16);
                    series.Style.ImageIndex = 0;
                }
                series.Style.Symbol.Color = Color.Yellow;
                series.Style.DisplayShadow = false;
                series.Style.PointWidth = 2;
                series.Style.Font.Bold = true;
            }
            this.chartControl1.ColumnDrawMode = ChartColumnDrawMode.PlaneMode;
            this.chartControl1.LegendPosition = ChartDock.Top;
            this.chartControl1.PrimaryXAxis.LabelRotate = true;
            this.chartControl1.Spacing = 20;
        }
        #endregion

        #region FillControlPanel

        /// <summary>
        /// Initializes the control values.
        /// </summary>
        protected void FillControlPanel()
        {
            foreach (string linetype in Enum.GetNames(typeof(System.Drawing.Drawing2D.DashStyle)))
                this.comboBox1.Items.Add(linetype);
            foreach (string linetype1 in Enum.GetNames(typeof(BorderStyle)))
                this.comboBox3.Items.Add(linetype1);
            foreach (string fontstyle in Enum.GetNames(typeof(System.Drawing.FontStyle)))
                this.comboBox6.Items.Add(fontstyle);
            foreach (string gradient in Enum.GetNames(typeof(Syncfusion.Drawing.GradientStyle)))
                this.comboBox8.Items.Add(gradient);
            foreach (string palette in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartColorPalette)))
                this.comboBox9.Items.Add(palette);
            foreach (string symbol in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
                this.comboBox7.Items.Add(symbol);

            this.comboBox7.SelectedIndex = 11;
            this.comboBox6.SelectedIndex = 0;
            this.comboBox5.SelectedIndex = 18;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox9.SelectedIndex = 12;
            this.colorPickerButton4.SelectedColor = Color.Black;
            this.numericUpDown2.Value = 10;
            this.timer1.Enabled = this.checkBox2.Checked;
        }
        #endregion

        #endregion

        #region Appearance

        #region Border Settings

        #region Border Color
        private void colorPickerButton3_ColorSelected(object sender, System.EventArgs e)
        {
            this.chartControl1.ChartArea.BorderColor = this.colorPickerButton3.SelectedColor;
             
            if (this.colorPickerButton3.SelectedColor == Color.Transparent)
            {
                this.textBox1.BackColor = Color.Empty;
            }
            else
            {
                this.textBox1.BackColor = this.colorPickerButton3.SelectedColor;
            }

            this.chartControl1.Redraw(true);
        }

        #endregion

        #region Border Width

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.BorderWidth = Convert.ToInt32(this.numericUpDown4.Value);
            this.chartControl1.Redraw(true);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
                this.chartControl1.Series[i].Style.Border.Width = Convert.ToInt32(this.numericUpDown5.Value);
            this.chartControl1.Redraw(true);
        }

        #endregion

        #region Border Style

        private void ChartBorderStyle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.ChartArea.BorderStyle = (BorderStyle)Enum.Parse(typeof(BorderStyle), this.comboBox3.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        #endregion

        #region Series Border

        private void SeriesBorder_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
                this.chartControl1.Series[i].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void SeriesBorderColor_ColorSelected(object sender, System.EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
                this.chartControl1.Series[i].Style.Border.Color = this.colorPickerButton2.SelectedColor;
             
            if (this.colorPickerButton2.SelectedColor == Color.Transparent)
            {
                this.textBox2.BackColor = Color.Empty;
            }
            else
            {
                this.textBox2.BackColor = this.colorPickerButton2.SelectedColor;
            }

            this.chartControl1.Redraw(true);
        }

        #endregion

        #endregion

        #region Background Settings

        #region BackImage

        /// <summary>
        /// Setting Background image for the control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChartControlBackGroundImage_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"..\..\..\..\..\..\..\..\..\Common\images\Chart";
            ofd.Filter = "BackGround files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (DialogResult.OK == ofd.ShowDialog())
            {
                filename = ofd.FileName;
                this.chartControl1.ChartAreaBackImage = new Bitmap(filename);
                this.chartControl1.ChartInterior = new BrushInfo(Color.Transparent);
                Btn_Clear.Visible = true;
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.chartControl1.ChartAreaBackImage = null;
            Btn_Clear.Visible = false;
            this.ChartInterior_ColorChanged(this.colorPickerButton8, EventArgs.Empty);
        }

        #endregion

        #region Interior

        private void ChartControl_ColorChanged(object sender, EventArgs e)
        {
            try
            {
                this.chartControl1.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton5.SelectedColor, this.colorPickerButton6.SelectedColor);
                 
                 
                if (this.colorPickerButton5.SelectedColor == Color.Transparent)
                {
                    this.textBox3.BackColor = Color.Empty;
                }
                else
                {
                    this.textBox3.BackColor = this.colorPickerButton5.SelectedColor;
                }

                if (this.colorPickerButton6.SelectedColor == Color.Transparent)
                {
                    this.textBox4.BackColor = Color.Empty;
                }
                else
                {
                    this.textBox4.BackColor = this.colorPickerButton6.SelectedColor;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ChartArea_ColorChanged(object sender, EventArgs e)
        {
            try
            {
                this.chartControl1.ChartArea.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton7.SelectedColor, this.colorPickerButton1.SelectedColor);
                 
                 
                if (this.colorPickerButton7.SelectedColor == Color.Transparent)
                {
                    this.textBox6.BackColor = Color.Empty;
                }
                else
                {
                    this.textBox6.BackColor = this.colorPickerButton7.SelectedColor;
                }
                if (this.colorPickerButton1.SelectedColor == Color.Transparent)
                {
                    this.textBox5.BackColor = Color.Empty;
                }
                else
                {
                    this.textBox5.BackColor = this.colorPickerButton1.SelectedColor;
                }          

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ChartInterior_ColorChanged(object sender, EventArgs e)
        {
            try
            {
                this.chartControl1.ChartInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton8.SelectedColor, this.colorPickerButton9.SelectedColor);
                 
                 
                if (this.colorPickerButton9.SelectedColor == Color.Transparent)
                {
                    this.textBox8.BackColor = Color.Empty;
                }
                else
                {
                    this.textBox8.BackColor = this.colorPickerButton9.SelectedColor;
                }
                if (this.colorPickerButton8.SelectedColor == Color.Transparent)
                {
                    this.textBox7.BackColor = Color.Empty;
                }
                else
                {
                    this.textBox7.BackColor = this.colorPickerButton8.SelectedColor;
                }         

            }
            catch (Exception ex)
            {
                this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254))))));
                Console.WriteLine(ex.ToString());
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton5.SelectedColor, this.colorPickerButton6.SelectedColor);
            this.chartControl1.ChartArea.BackInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton7.SelectedColor, this.colorPickerButton1.SelectedColor);
            this.chartControl1.ChartInterior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox8.SelectedItem.ToString(), true), this.colorPickerButton8.SelectedColor, this.colorPickerButton9.SelectedColor);
        }

        #endregion

        #endregion

        #region Font Settings

        /// <summary>
        /// Setting font style, font name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Showtext_CheckedChanged(object sender, System.EventArgs e)
        {
            SetFont();
            FontColor_ColorSelected(this.colorPickerButton4, EventArgs.Empty);
            for (int i = 0; i <= 2; i++)
            {
                this.chartControl1.Series[i].Style.DisplayText = this.checkBox1.Checked;
                this.chartControl1.Series[i].Style.TextOrientation = ChartTextOrientation.Up;
            }
            this.chartControl1.Redraw(true);
        }

        private void FontName_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Font_Name = this.comboBox5.SelectedItem.ToString();
            SetFont();
            for (int i = 0; i <= 2; i++)
                this.chartControl1.Series[i].Style.Font.Facename = this.comboBox5.SelectedItem.ToString();
        }

        private void FontStyle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            SetFont();
        }

        private void SetFont()
        {
            // Changing Font for Chart Legend
            ChartLegend item = this.chartControl1.Legend;
            item.Font = new Font(Font_Name, 10f, (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true));

            // Changing font for chart axis
            ChartAxis axis = this.chartControl1.PrimaryXAxis;
            axis.Font = new Font(Font_Name, 10f, (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true));
            axis = this.chartControl1.PrimaryYAxis;
            axis.Font = new Font(Font_Name, 10f, (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true));
            // Changing font for chart title
            ChartTitle title = this.chartControl1.Title;
            title.Font = new Font(Font_Name, 10f, (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true));

            if (this.chartControl1.Series.Count != 0)
            {
                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    ChartSeries series = this.chartControl1.Series[i];
                    if (series != null)
                    {
                        series.Style.Font.Facename = Font_Name;
                        series.Style.Font.Size = 10f;
                        series.Style.Font.FontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox6.SelectedItem.ToString(), true);
                    }
                }
            }
            this.chartControl1.Redraw(true);
        }

        private void FontColor_ColorSelected(object sender, System.EventArgs e)
        {
            for (int i = 0; i <= 2; i++)
            {
                this.chartControl1.Series[i].Style.TextColor = this.colorPickerButton4.SelectedColor;
                // Changing Legend Color
                this.chartControl1.Series[i].LegendItem.TextColor = this.colorPickerButton4.SelectedColor;
            }
            // Changing axis label color
            this.chartControl1.PrimaryXAxis.ForeColor = this.colorPickerButton4.SelectedColor;
            this.chartControl1.PrimaryYAxis.ForeColor = this.colorPickerButton4.SelectedColor;
            //  Changing Title Color
            this.chartControl1.Title.ForeColor = this.colorPickerButton4.SelectedColor;
             
            if (this.colorPickerButton4.SelectedColor == Color.Transparent)
            {
                this.textBox9.BackColor = Color.Empty;
            }
            else
            {
                this.textBox9.BackColor = this.colorPickerButton4.SelectedColor;
            }

            this.chartControl1.Redraw(true);
        }
        #endregion

        #region Shadow
        /// <summary>
        /// Setting shadow for the chart area.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChartAreaShadow_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.ChartAreaShadow = this.checkBox5.Checked;
        }
        #endregion

        #region ColorPalette
        /// <summary>
        /// Change the color palette in the Chart Control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPalette_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBox9.SelectedItem.ToString() == "Custom")
            {
                this.chartControl1.Palette = ChartColorPalette.Custom;
                this.chartControl1.CustomPalette = new System.Drawing.Color[] 
                {              
                Color.FromArgb(200,247,148,29),                
                Color.FromArgb(200, 140,198,62),
                Color.FromArgb(200, 163,48,45)
                };
            }
            else
            {
                this.chartControl1.Palette = (ChartColorPalette)Enum.Parse(typeof(ChartColorPalette), this.comboBox9.SelectedItem.ToString(), true);
                this.chartControl1.Series[0].Style.Interior = null;
                this.chartControl1.Series[1].Style.Interior = null;
                this.chartControl1.Series[2].Style.Interior = null;
            }
        }

        #endregion

        #region ChartFormatAxisLabel Event
        /// <summary>
        /// Formatting Chart Axes Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (e.Value == 1)
                    e.Label = "USA";
                else if (e.Value == 2)
                    e.Label = "China";
                else if (e.Value == 3)
                    e.Label = "Russia";
                else if (e.Value == 4)
                    e.Label = "Australia";
                else if (e.Value == 5)
                    e.Label = "Japan";
                else
                    e.Label = "";

                e.Handled = true;
            }
        }

        #endregion

        #endregion

        #region Behavior

        #region Rotation
        /// <summary>
        /// Enable and Disable the rotation.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void RotateAxis_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox3.Checked;
            this.chartControl1.ChartArea.Rotation = 30;
            this.chartControl1.ChartArea.Tilt = (float)this.numericUpDown3.Value;
            this.timer1.Enabled = this.checkBox2.Checked;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Tilt = (float)this.numericUpDown3.Value;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox3.Checked;
            if (this.checkBox3.Checked)
            {
                this.chartControl1.Series3D = true;
                this.checkBox2.Enabled = true;
                this.numericUpDown1.Enabled = true;
                this.numericUpDown2.Enabled = true;
                this.numericUpDown3.Enabled = true;
            }
            else
            {
                this.chartControl1.Series3D = false;
                this.checkBox2.Enabled = false;
                this.numericUpDown1.Enabled = false;
                this.numericUpDown2.Enabled = false;
                this.numericUpDown3.Enabled = false;
            }
        }

        #endregion

        #region Depth
        /// <summary>
        /// Changing chart area depth in chart control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Depth_ValueChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.ChartArea.Depth = (float)this.numericUpDown1.Value;
        }

        #endregion

        #region Spacing
        /// <summary>
        /// Changing spacing between the series in the chartcontrol.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spacing_ValueChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.SpacingBetweenSeries = (float)this.numericUpDown2.Value;
        }
        #endregion

        #region Timer
        /// <summary>
        /// Enable and disable the timer to rotate the chartarea.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            try
            {
                this.chartControl1.ChartArea.Rotation += 5;

                if (this.chartControl1.ChartArea.Rotation >= 90)
                    this.chartControl1.ChartArea.Rotation = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        #region Symbol
        /// <summary>
        /// Set and change the symbol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ChangeSymbol()
        {
            if (this.radioButton4.Checked)
            {
                if (this.comboBox7.SelectedItem.ToString() == "Image")
                {
                    this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                    this.chartControl1.Series[0].Style.Symbol.ImageIndex = 0;
                }
                else
                    this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                this.chartControl1.Series[0].Style.Symbol.Color = Color.Yellow;
            }
            else if (this.radioButton3.Checked)
            {
                if (this.comboBox7.SelectedItem.ToString() == "Image")
                {
                    this.chartControl1.Series[1].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                    this.chartControl1.Series[1].Style.Symbol.ImageIndex = 0;
                }
                else
                    this.chartControl1.Series[1].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                this.chartControl1.Series[1].Style.Symbol.Color = Color.Purple;
            }
            else if (this.radioButton1.Checked)
            {
                if (this.comboBox7.SelectedItem.ToString() == "Image")
                {
                    this.chartControl1.Series[2].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                    this.chartControl1.Series[2].Style.Symbol.ImageIndex = 0;
                }
                else
                    this.chartControl1.Series[2].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.comboBox7.SelectedItem.ToString(), true);
                this.chartControl1.Series[2].Style.Symbol.Color = Color.Purple;
            }
        }

        private void SymbolShape_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            ChangeSymbol();
            this.chartControl1.Redraw(true);
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSymbol();
            this.chartControl1.Redraw(true);
        }
        #endregion
        #endregion
    }
}