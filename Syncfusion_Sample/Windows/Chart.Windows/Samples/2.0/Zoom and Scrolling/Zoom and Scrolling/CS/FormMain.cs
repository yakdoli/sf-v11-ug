using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Data.OleDb;
using Syncfusion.Windows.Forms;

namespace KeyAndMouseZoomingSample
{
    public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.ComboBox ComboScrollDown;
        private System.Windows.Forms.ComboBox ComboScrollRight;
        private System.Windows.Forms.ComboBox ComboScrollUp;
        private System.Windows.Forms.ComboBox ComboScrollLeft;
        private System.Windows.Forms.ComboBox ComboZoomIn;
        private System.Windows.Forms.ComboBox ComboZoomOut;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label9;
        private Label label10;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private ComboBox comboBox2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
        private IContainer components;
        Color forecolor = Color.Red;
        private CheckBox checkBox2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private CheckBox checkBox3;
        private Label label19;
        private Label label22;
        private Label label14;
        private Label label15;
        private Label label11;
        private Label label3;
        private Label label4;
        private Label label17;
        private Label label18;
        private Label label20;
        private Panel panel9;
        private TextBox textBox3;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton;
        private Panel panel1;
        private TextBox textBox1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Panel panel2;
        private TextBox textBox2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton4;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private Label label8;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Panel panel3;
        private Label label2;
        private Label label12;
        private CheckBox checkBox4;
        private ComboBox comboBox7;
        private Label label13;
        private ComboBox comboBox8;
        private Label label16;
        Color backcolor = Color.Black;
        #endregion

        #region Form's Constructor, Main and Dispose
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ComboScrollDown = new System.Windows.Forms.ComboBox();
            this.ComboScrollRight = new System.Windows.Forms.ComboBox();
            this.ComboScrollUp = new System.Windows.Forms.ComboBox();
            this.ComboScrollLeft = new System.Windows.Forms.ComboBox();
            this.ComboZoomIn = new System.Windows.Forms.ComboBox();
            this.ComboZoomOut = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.colorPickerButton = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.colorPickerButton4 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Etched;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.EnableXZooming = true;
            this.chartControl1.EnableYZooming = true;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(62, 74);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Location = new System.Drawing.Point(30, 17);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(1850, 2007, 10);
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.Size = new System.Drawing.Size(550, 363);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Temperature Anomaly";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // autoLabel2
            // 
            this.autoLabel2.DX = 0;
            this.autoLabel2.DY = 0;
            this.autoLabel2.ForeColor = System.Drawing.Color.Black;
            this.autoLabel2.Location = new System.Drawing.Point(199, 267);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(85, 13);
            this.autoLabel2.TabIndex = 21;
            this.autoLabel2.Text = "ZoomingFactorY";
            // 
            // autoLabel1
            // 
            this.autoLabel1.DX = 0;
            this.autoLabel1.DY = 0;
            this.autoLabel1.ForeColor = System.Drawing.Color.Black;
            this.autoLabel1.Location = new System.Drawing.Point(199, 241);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(85, 13);
            this.autoLabel1.TabIndex = 20;
            this.autoLabel1.Text = "ZoomingFactorX";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(399, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Show Scroll Bars";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			this.checkBox2.Visible = false;
			this.checkBox2.Enabled = false;
            // 
            // ComboScrollDown
            // 
            this.ComboScrollDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboScrollDown.Location = new System.Drawing.Point(498, 175);
            this.ComboScrollDown.Name = "ComboScrollDown";
            this.ComboScrollDown.Size = new System.Drawing.Size(85, 21);
            this.ComboScrollDown.TabIndex = 10;
            this.ComboScrollDown.SelectedIndexChanged += new System.EventHandler(this.ComboScrollDown_SelectedIndexChanged);
            // 
            // ComboScrollRight
            // 
            this.ComboScrollRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboScrollRight.Location = new System.Drawing.Point(498, 99);
            this.ComboScrollRight.Name = "ComboScrollRight";
            this.ComboScrollRight.Size = new System.Drawing.Size(85, 21);
            this.ComboScrollRight.TabIndex = 9;
            this.ComboScrollRight.SelectedIndexChanged += new System.EventHandler(this.ComboScrollRight_SelectedIndexChanged);
            // 
            // ComboScrollUp
            // 
            this.ComboScrollUp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboScrollUp.Location = new System.Drawing.Point(498, 150);
            this.ComboScrollUp.Name = "ComboScrollUp";
            this.ComboScrollUp.Size = new System.Drawing.Size(85, 21);
            this.ComboScrollUp.TabIndex = 8;
            this.ComboScrollUp.SelectedIndexChanged += new System.EventHandler(this.ComboScrollUp_SelectedIndexChanged);
            // 
            // ComboScrollLeft
            // 
            this.ComboScrollLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboScrollLeft.Location = new System.Drawing.Point(498, 125);
            this.ComboScrollLeft.Name = "ComboScrollLeft";
            this.ComboScrollLeft.Size = new System.Drawing.Size(85, 21);
            this.ComboScrollLeft.TabIndex = 7;
            this.ComboScrollLeft.SelectedIndexChanged += new System.EventHandler(this.ComboScrollLeft_SelectedIndexChanged);
            // 
            // ComboZoomIn
            // 
            this.ComboZoomIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboZoomIn.Location = new System.Drawing.Point(93, 241);
            this.ComboZoomIn.Name = "ComboZoomIn";
            this.ComboZoomIn.Size = new System.Drawing.Size(65, 21);
            this.ComboZoomIn.TabIndex = 1;
            this.ComboZoomIn.SelectedIndexChanged += new System.EventHandler(this.ComboZoomIn_SelectedIndexChanged);
            // 
            // ComboZoomOut
            // 
            this.ComboZoomOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboZoomOut.Location = new System.Drawing.Point(93, 267);
            this.ComboZoomOut.Name = "ComboZoomOut";
            this.ComboZoomOut.Size = new System.Drawing.Size(65, 21);
            this.ComboZoomOut.TabIndex = 2;
            this.ComboZoomOut.SelectedIndexChanged += new System.EventHandler(this.ComboZoomOut_SelectedIndexChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox3.Location = new System.Drawing.Point(18, 40);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(120, 18);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "Show ZoomButton";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3 ",
            "0.4 ",
            "0.5 ",
            "0.6 ",
            "0.7 ",
            "0.8 ",
            "0.9 ",
            "1.0 "});
            this.comboBox4.Location = new System.Drawing.Point(284, 99);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(54, 21);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(284, 175);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(89, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // autoLabel9
            // 
            this.autoLabel9.DX = 0;
            this.autoLabel9.DY = 0;
            this.autoLabel9.ForeColor = System.Drawing.Color.Black;
            this.autoLabel9.Location = new System.Drawing.Point(199, 99);
            this.autoLabel9.Name = "autoLabel9";
            this.autoLabel9.Size = new System.Drawing.Size(43, 13);
            this.autoLabel9.TabIndex = 12;
            this.autoLabel9.Text = "Opacity";
            // 
            // autoLabel8
            // 
            this.autoLabel8.DX = 0;
            this.autoLabel8.DY = 0;
            this.autoLabel8.ForeColor = System.Drawing.Color.Black;
            this.autoLabel8.Location = new System.Drawing.Point(199, 150);
            this.autoLabel8.Name = "autoLabel8";
            this.autoLabel8.Size = new System.Drawing.Size(56, 13);
            this.autoLabel8.TabIndex = 11;
            this.autoLabel8.Text = "BackColor";
            // 
            // autoLabel7
            // 
            this.autoLabel7.DX = 0;
            this.autoLabel7.DY = 0;
            this.autoLabel7.ForeColor = System.Drawing.Color.Black;
            this.autoLabel7.Location = new System.Drawing.Point(199, 125);
            this.autoLabel7.Name = "autoLabel7";
            this.autoLabel7.Size = new System.Drawing.Size(52, 13);
            this.autoLabel7.TabIndex = 10;
            this.autoLabel7.Text = "ForeColor";
            // 
            // autoLabel6
            // 
            this.autoLabel6.DX = 0;
            this.autoLabel6.DY = 0;
            this.autoLabel6.ForeColor = System.Drawing.Color.Black;
            this.autoLabel6.Location = new System.Drawing.Point(199, 175);
            this.autoLabel6.Name = "autoLabel6";
            this.autoLabel6.Size = new System.Drawing.Size(73, 13);
            this.autoLabel6.TabIndex = 9;
            this.autoLabel6.Text = "Gradient Style";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // autoLabel4
            // 
            this.autoLabel4.DX = 0;
            this.autoLabel4.DY = 0;
            this.autoLabel4.ForeColor = System.Drawing.Color.Black;
            this.autoLabel4.Location = new System.Drawing.Point(18, 175);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(58, 13);
            this.autoLabel4.TabIndex = 6;
            this.autoLabel4.Text = "Dash Style";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Color";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1.0",
            "2.0",
            "3.0",
            "4.0",
            "5.0",
            "6.0",
            "7.0",
            "8.0",
            "9.0"});
            this.comboBox1.Location = new System.Drawing.Point(93, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(65, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(18, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Width";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox1.Location = new System.Drawing.Point(18, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show Border";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label19.Location = new System.Drawing.Point(18, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(275, 1);
            this.label19.TabIndex = 116;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label22.Image = ((System.Drawing.Image)(resources.GetObject("label22.Image")));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(18, 11);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 16);
            this.label22.TabIndex = 115;
            this.label22.Text = "Zooming";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label14.Location = new System.Drawing.Point(395, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 1);
            this.label14.TabIndex = 118;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(393, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 117;
            this.label15.Text = "Scrolling";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(18, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 119;
            this.label11.Text = "ZoomIn Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "ZoomOut Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(396, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 121;
            this.label4.Text = "Scrolling Right Key";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(396, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 122;
            this.label17.Text = "Scrolling Left Key";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(396, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 13);
            this.label18.TabIndex = 123;
            this.label18.Text = "Scrolling Up Key";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(396, 175);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 13);
            this.label20.TabIndex = 124;
            this.label20.Text = "Scrolling Down Key";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.textBox3);
            this.panel9.Controls.Add(this.colorPickerButton);
            this.panel9.Location = new System.Drawing.Point(90, 150);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(41, 21);
            this.panel9.TabIndex = 127;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(22, 20);
            this.textBox3.TabIndex = 11;
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorPickerButton.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorPickerButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton.Image = ((System.Drawing.Image)(resources.GetObject("colorPickerButton.Image")));
            this.colorPickerButton.Location = new System.Drawing.Point(22, 0);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.SelectedAsBackcolor = true;
            this.colorPickerButton.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.colorPickerButton.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton.TabIndex = 14;
            this.colorPickerButton.Text = "...";
            this.colorPickerButton.UseVisualStyleBackColor = false;
            this.colorPickerButton.ColorSelected += new System.EventHandler(this.colorPickerButton_ColorSelected);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Location = new System.Drawing.Point(284, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 21);
            this.panel1.TabIndex = 128;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Red;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 11;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Red;
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
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Red;
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton1.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton1.TabIndex = 14;
            this.colorPickerButton1.Text = "...";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.colorPickerButton1_ColorSelected);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.colorPickerButton4);
            this.panel2.Location = new System.Drawing.Point(284, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 21);
            this.panel2.TabIndex = 129;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Yellow;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 11;
            // 
            // colorPickerButton4
            // 
            this.colorPickerButton4.BackColor = System.Drawing.Color.Yellow;
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
            this.colorPickerButton4.SelectedColor = System.Drawing.Color.Yellow;
            this.colorPickerButton4.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton4.Size = new System.Drawing.Size(17, 19);
            this.colorPickerButton4.TabIndex = 14;
            this.colorPickerButton4.Text = "...";
            this.colorPickerButton4.UseVisualStyleBackColor = false;
            this.colorPickerButton4.ColorSelected += new System.EventHandler(this.colorPickerButton4_ColorSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 130;
            this.label1.Text = "ZoomArea Border";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(199, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 131;
            this.label5.Text = "ZoomArea Interior";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(18, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 132;
            this.label6.Text = "Zooming Keys";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(199, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 133;
            this.label7.Text = "Zooming Factor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1")))});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(400, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 135;
            this.label8.Text = "Scrolling Keys";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.comboBox5.Location = new System.Drawing.Point(284, 241);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(55, 21);
            this.comboBox5.TabIndex = 136;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "1"});
            this.comboBox6.Location = new System.Drawing.Point(284, 267);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(55, 21);
            this.comboBox6.TabIndex = 137;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox8);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.comboBox7);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.checkBox4);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.comboBox6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ComboZoomOut);
            this.panel3.Controls.Add(this.comboBox5);
            this.panel3.Controls.Add(this.ComboZoomIn);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.ComboScrollLeft);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.ComboScrollRight);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ComboScrollUp);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ComboScrollDown);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.checkBox3);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.comboBox4);
            this.panel3.Controls.Add(this.autoLabel4);
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.autoLabel9);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.autoLabel8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.autoLabel2);
            this.panel3.Controls.Add(this.autoLabel6);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.autoLabel1);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.autoLabel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 302);
            this.panel3.TabIndex = 138;
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "Panning",
            "None"});
            this.comboBox8.Location = new System.Drawing.Point(499, 278);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(85, 21);
            this.comboBox8.TabIndex = 144;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(403, 282);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 143;
            this.label16.Text = "Y-Zoom Action";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Panning",
            "None"});
            this.comboBox7.Location = new System.Drawing.Point(498, 253);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(85, 21);
            this.comboBox7.TabIndex = 142;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 141;
            this.label13.Text = "X-Zoom Action";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(400, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 139;
            this.label2.Text = "Panning";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label12.Location = new System.Drawing.Point(400, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 1);
            this.label12.TabIndex = 140;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(403, 231);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(101, 17);
            this.checkBox4.TabIndex = 138;
            this.checkBox4.Text = "Enable Panning";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 695);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zoom and Scrolling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.SetBoxItems();
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        private ChartDataBindModel model;
        private ChartDataBindModel model1;
        protected void InitializeChartData()
        {

            string fileName = WinFormsUtils.FindFile(@"..\..\..\..\..\..\..\Common\Data\", "ChartTemperatureAnomaly.xls");

            //The Oledbconnection.
            OleDbConnection excelConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties=\"Excel 8.0;HDR=Yes;\"");
            excelConn.Open();
            //Query for retriving the data from the excel sheet.
            string query = "Select * From [Sheet1$A1:C159]";
            OleDbCommand excelCommand = new OleDbCommand(query, excelConn);
            OleDbDataReader excelReader = excelCommand.ExecuteReader(CommandBehavior.CloseConnection);

            //Load the contents to a dataset.
            DataSet excelDataSet = ConvertToDataSet(excelReader, "ExcelTable");

            //Initializes new chart series. 
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Anomaly";
            series1.Text = "Anomaly";
            series1.Type = ChartSeriesType.Spline;
            model1 = new ChartDataBindModel(excelDataSet, "ExcelTable");
            model1.XName = "X Value";
            model1.YNames = new string[] { "Y Value" };
            series1.SeriesModel = model1;
            this.chartControl1.Series.Add(series1);

            //Initializes new chart series.
            ChartSeries series2 = new ChartSeries();
            series2.Name = "Smoothed";
            series2.Text = "Smoothed";
            series2.Type = ChartSeriesType.SplineArea;
            model = new ChartDataBindModel(excelDataSet, "ExcelTable");
            model.XName = "X Value";
            model.YNames = new string[] { "Z Value" };
            series2.SeriesModel = model;
            this.chartControl1.Series.Add(series2);

            //Close the connection.
            excelReader.Close();
            excelConn.Close();

            this.comboBox7.SelectedIndex = 0;
            this.comboBox8.SelectedIndex = 0;
            this.comboBox7.Enabled = false;
            this.comboBox8.Enabled = false;
        }
        #endregion

        #region ConvertToDataSet
        /// <summary>
        /// Converts DataReader to DataSet.
        /// </summary>
        /// <param name="myReader"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        protected DataSet ConvertToDataSet(OleDbDataReader dataReader, string tableName)
        {
            DataSet dataSet = new DataSet();
            do
            {
                // Create new data table

                DataTable schemaTable = dataReader.GetSchemaTable();
                DataTable dataTable = new DataTable(tableName);

                if (schemaTable != null)
                {
                    // A query returning records was executed

                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        DataRow dataRow = schemaTable.Rows[i];
                        // Create a column name that is unique in the data table
                        string columnName = (string)dataRow["ColumnName"];
                        // Add the column definition to the data table
                        DataColumn column = new DataColumn(columnName, (Type)dataRow["DataType"]);
                        dataTable.Columns.Add(column);
                    }

                    //Add the data table to the dataset.
                    dataSet.Tables.Add(dataTable);

                    // Fill the data table.
                    while (dataReader.Read())
                    {
                        DataRow dataRow = dataTable.NewRow();

                        for (int i = 0; i < dataReader.FieldCount; i++)
                            dataRow[i] = dataReader.GetValue(i);

                        dataTable.Rows.Add(dataRow);
                    }
                }
                else
                {
                    // No records were returned.

                    DataColumn column = new DataColumn("RowsAffected");
                    dataTable.Columns.Add(column);
                    dataSet.Tables.Add(dataTable);
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = dataReader.RecordsAffected;
                    dataTable.Rows.Add(dataRow);
                }
            }
            while (dataReader.NextResult());
            return dataSet;
        }
        #endregion

        #region SetBoxItems
        private void SetBoxItems()
        {
            this.ComboZoomIn.Items.Add("+");
            this.ComboZoomIn.Items.Add(Keys.A);
            this.ComboZoomIn.Items.Add(Keys.P);
            this.ComboZoomOut.Items.Add("-");
            this.ComboZoomOut.Items.Add(Keys.B);
            this.ComboZoomOut.Items.Add(Keys.O);
            this.ComboScrollRight.Items.Add(Keys.Right);
            this.ComboScrollRight.Items.Add(Keys.NumPad6);
            this.ComboScrollRight.Items.Add(Keys.R);
            this.ComboScrollLeft.Items.Add(Keys.Left);
            this.ComboScrollLeft.Items.Add(Keys.NumPad4);
            this.ComboScrollLeft.Items.Add(Keys.L);
            this.ComboScrollUp.Items.Add(Keys.Up);
            this.ComboScrollUp.Items.Add(Keys.NumPad8);
            this.ComboScrollUp.Items.Add(Keys.F10);
            this.ComboScrollDown.Items.Add(Keys.Down);
            this.ComboScrollDown.Items.Add(Keys.NumPad2);
            this.ComboScrollDown.Items.Add(Keys.F4);
            this.chartControl1.ZoomCancel = Keys.Escape;

            foreach (string dashtype in Enum.GetNames(typeof(System.Drawing.Drawing2D.DashStyle)))
                this.comboBox2.Items.Add(dashtype);
            this.comboBox2.SelectedIndex = 0;

            foreach (string gradient in Enum.GetNames(typeof(Syncfusion.Drawing.GradientStyle)))
                this.comboBox3.Items.Add(gradient);

            this.comboBox3.SelectedIndex = 1;
            this.comboBox4.SelectedIndex = 6;
            this.comboBox1.SelectedIndex = 0;
            this.ComboZoomIn.SelectedIndex = 0;
            this.ComboZoomOut.SelectedIndex = 0;
            this.ComboScrollRight.SelectedIndex = 0;
            this.ComboScrollLeft.SelectedIndex = 0;
            this.ComboScrollUp.SelectedIndex = 0;
            this.ComboScrollDown.SelectedIndex = 0;
            this.comboBox5.SelectedIndex = 9;
            this.comboBox6.SelectedIndex = 9;
        }
        #endregion
        #endregion

        #region Events

        private void ComboZoomIn_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboZoomIn.SelectedItem.ToString();
            switch (select1)
            {
                case "+":
                    this.chartControl1.ZoomIn = Keys.Oemplus;
                    break;

                case "A":
                    this.chartControl1.ZoomIn = Keys.A;
                    break;

                case "P":
                    this.chartControl1.ZoomIn = Keys.P;
                    break;

                default:
                    this.chartControl1.ZoomIn = Keys.Oemplus;
                    break;
            }
            this.chartControl1.Redraw(true);
        }

        private void ComboZoomOut_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboZoomOut.SelectedItem.ToString();

            switch (select1)
            {
                case "-":
                    this.chartControl1.ZoomOut = Keys.OemMinus;
                    break;

                case "B":
                    this.chartControl1.ZoomOut = Keys.B;
                    break;

                case "O":
                    this.chartControl1.ZoomOut = Keys.O;
                    break;

                default:
                    this.chartControl1.ZoomOut = Keys.OemMinus;
                    break;
            }

            this.chartControl1.Redraw(true);
        }

        private void ComboScrollRight_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboScrollRight.SelectedItem.ToString();

            switch (select1)
            {
                case "Right":
                    this.chartControl1.ZoomRight = Keys.Right;
                    break;

                case "NumPad6":
                    this.chartControl1.ZoomRight = Keys.NumPad6;
                    break;

                case "R":
                    this.chartControl1.ZoomRight = Keys.R;
                    break;

                default:
                    this.chartControl1.ZoomRight = Keys.Right;
                    break;
            }
            this.chartControl1.Redraw(true);
        }

        private void ComboScrollLeft_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboScrollLeft.SelectedItem.ToString();

            switch (select1)
            {
                case "Left":
                    this.chartControl1.ZoomLeft = Keys.Left;
                    break;

                case "NumPad4":
                    this.chartControl1.ZoomLeft = Keys.NumPad4;
                    break;

                case "L":
                    this.chartControl1.ZoomLeft = Keys.L;
                    break;

                default:
                    this.chartControl1.ZoomLeft = Keys.Left;
                    break;
            }
            this.chartControl1.Redraw(true);
        }

        private void ComboScrollUp_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboScrollUp.SelectedItem.ToString();

            switch (select1)
            {
                case "Up":
                    this.chartControl1.ZoomUp = Keys.Up;
                    break;

                case "NumPad8":
                    this.chartControl1.ZoomUp = Keys.NumPad8;
                    break;

                case "F10":
                    this.chartControl1.ZoomUp = Keys.F10;
                    break;

                default:
                    this.chartControl1.ZoomUp = Keys.Up;
                    break;
            }
            this.chartControl1.Redraw(true);
        }

        private void ComboScrollDown_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Focus();
            string select1 = this.ComboScrollDown.SelectedItem.ToString();

            switch (select1)
            {
                case "Down":
                    this.chartControl1.ZoomDown = Keys.Down;
                    break;

                case "NumPad2":
                    this.chartControl1.ZoomDown = Keys.NumPad2;
                    break;

                case "F4":
                    this.chartControl1.ZoomDown = Keys.F4;
                    break;

                default:
                    this.chartControl1.ZoomDown = Keys.Down;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Zooming.Border.Width = (float)Convert.ToDouble(comboBox1.SelectedItem);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Zooming.Border.DashStyle = (System.Drawing.Drawing2D.DashStyle)Enum.Parse(typeof(System.Drawing.Drawing2D.DashStyle), this.comboBox2.SelectedItem.ToString(), true);
        }




        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            forecolor = this.colorPickerButton1.SelectedColor;
            backcolor = this.colorPickerButton4.SelectedColor;
            this.chartControl1.Zooming.Interior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox3.SelectedItem.ToString(), true), forecolor, backcolor);
        }



        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Zooming.Opacity = (float)Convert.ToDouble(comboBox4.SelectedItem);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.chartControl1.Zooming.ShowBorder = true;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = true;
                this.colorPickerButton1.Enabled = true;
            }
            else if (checkBox1.Checked == false)
            {
                this.chartControl1.Zooming.ShowBorder = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.colorPickerButton1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                this.chartControl1.ShowScrollBars = false;
            }
            else
            {
                this.chartControl1.ShowScrollBars = true;
            }
        }




        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.chartControl1.ShowScrollBars = true;
            }
            else
            {
                this.chartControl1.ShowScrollBars = false;
            }

            this.chartControl1.ZoomFactorX = Convert.ToDouble(this.comboBox5.SelectedItem);

        }
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.chartControl1.ShowScrollBars = true;
            }
            else
            {
                this.chartControl1.ShowScrollBars = false;
            }

            this.chartControl1.ZoomFactorY = Convert.ToDouble(this.comboBox6.SelectedItem);
        }


        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                this.chartControl1.ShowScrollBars = false;
            }
            else
            {
                this.chartControl1.ShowScrollBars = true;
            }
        }
        #region Show/Hide Zoom Button
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.chartControl1.GetVScrollBar(this.chartControl1.PrimaryYAxis).ZoomButton.Size = new Size(14, 14);
                this.chartControl1.GetHScrollBar(this.chartControl1.PrimaryXAxis).ZoomButton.Size = new Size(14, 14);
                this.chartControl1.Redraw(true);
            }
            else
            {
                this.chartControl1.GetVScrollBar(this.chartControl1.PrimaryYAxis).ZoomButton.Size = new Size(0, 0);
                this.chartControl1.GetHScrollBar(this.chartControl1.PrimaryXAxis).ZoomButton.Size = new Size(0, 0);
                this.chartControl1.Redraw(true);
            }

        }
        #endregion

        private void colorPickerButton_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.Zooming.Border.ForeColor = this.colorPickerButton.SelectedColor;
            this.textBox3.BackColor = this.colorPickerButton.SelectedColor;
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            forecolor = this.colorPickerButton1.SelectedColor;
            this.chartControl1.Zooming.Interior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox3.SelectedItem.ToString(), true), forecolor, backcolor);
            this.textBox1.BackColor = this.colorPickerButton1.SelectedColor;
        }

        private void colorPickerButton4_ColorSelected(object sender, EventArgs e)
        {
            backcolor = this.colorPickerButton4.SelectedColor;
            this.chartControl1.Zooming.Interior = new BrushInfo((GradientStyle)Enum.Parse(typeof(GradientStyle), this.comboBox3.SelectedItem.ToString(), true), forecolor, backcolor);
            this.textBox2.BackColor = this.colorPickerButton4.SelectedColor;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                this.chartControl1.MouseAction = ChartMouseAction.Panning;
                this.comboBox7.Enabled = true;
                this.comboBox8.Enabled = true;
            }
            else
            {
                this.chartControl1.MouseAction = ChartMouseAction.Zooming;
                this.comboBox7.Enabled = false;
                this.comboBox8.Enabled = true;
            }

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.ZoomActions = (ChartZoomingAction)Enum.Parse(typeof(ChartZoomingAction), this.comboBox7.SelectedItem.ToString(), true);

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.ZoomActions = (ChartZoomingAction)Enum.Parse(typeof(ChartZoomingAction), this.comboBox8.SelectedItem.ToString(), true);
        }
        #endregion
    }
}