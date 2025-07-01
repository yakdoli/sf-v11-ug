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


namespace LineChart2002
{
    public class Form1 : Office2007Form
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;

        int count = 0;
        private Label label21;
        private Label label22;
        private ComboBox comboBox2;
        private Label label4;
        private CheckBox checkBox2;

        #endregion
        private ImageList imageList1;
        private RadioButton radioButton3;
        private IContainer components;

        #region Constructor, Main And Dispose
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 15, 15, 5);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(194)))), ((int)(((byte)(229))))), System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(250))))));
            this.chartControl1.ElementsSpacing = 1;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(36, 53);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.ShowSymbol = true;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.Location = new System.Drawing.Point(20, 11);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Silver;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Silver;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.Rotation = 90F;
            this.chartControl1.Size = new System.Drawing.Size(477, 400);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "EssentialChart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "EssentialChart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(518, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 424);
            this.panel1.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Location = new System.Drawing.Point(17, 140);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(96, 16);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "France";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 357);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Enable 3D";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox2.Location = new System.Drawing.Point(16, 192);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Legend Representation Type";
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(17, 94);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Italy";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radiobutton1_SeriesType_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(17, 118);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(96, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Spain";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radiobutton2_SeriesType_CheckedChanged);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label21.Location = new System.Drawing.Point(16, 79);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(125, 1);
            this.label21.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label22.Location = new System.Drawing.Point(14, 63);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 14);
            this.label22.TabIndex = 8;
            this.label22.Text = "Chart Series";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(17, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 32);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Points in different Color";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxChartType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBoxChartType.Location = new System.Drawing.Point(17, 28);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(104, 21);
            this.comboBoxChartType.TabIndex = 6;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(16, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(14, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "DashStyle";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.Location = new System.Drawing.Point(16, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.numericUpDown1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.numericUpDown1.Location = new System.Drawing.Point(17, 322);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ChartType";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "server_from_client.png");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 424);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Line Charts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.comboBoxChartType.Items.Add(ChartSeriesType.Line);
            this.comboBoxChartType.Items.Add(ChartSeriesType.Spline);
            this.comboBoxChartType.Items.Add(ChartSeriesType.StepLine);
            this.comboBoxChartType.Items.Add(ChartSeriesType.RotatedSpline);
            this.comboBoxChartType.SelectedIndex = 0;
            FillControlPanel();
            this.comboBox1.SelectedIndex = 0;
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion

        #region Helper Methods

        #region InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries("Italy");
            series1.Text = series1.Name;
            series1.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            // 4, 3, 3, 3, 5, 4, 5, 6, 8, 9,10, 9, 12, 11, 5,

            double[] points1 =  {2, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1,2 };
            int i = 0;
            for (int j = 1985; j < 2003 && i < 16; j++, i++)
            {
                series1.Points.Add(j, points1[i]);
            }
            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries("Spain");
            series2.Text = series2.Name;
            series2.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            //6,9,10,10,12,8,10,5,6,5,4,3,4,2,3,
            i = 0;
            double[] points2 = {8,5,4,4,3,3,3,3,4,5,4,3,2,3,2,1};

            for (int k = 1985; k < 2003 && i < 16; k++, i++)
            {
                series2.Points.Add(k, points2[i]);
            }
            this.chartControl1.Series.Add(series2);


            ChartSeries series3 = new ChartSeries("France");
            series3.Text = series3.Name;
            series3.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            // 19,17,18,23,21,18,16,14,9,10,8,6,6,8,10,
            i = 0;
            double[] points3 = {11,15,14,10,11,6,4,6,2,2,2,2,3,4,4,4};

            for (int l = 1985; l < 2003 && i < 16; l++, i++)
            {
                series3.Points.Add(l, points3[i]);
            }

            this.chartControl1.Series.Add(series3);

            series2.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series2.Style.ImageIndex = 0;
            series1.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series1.Style.ImageIndex = 0;
            series3.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series3.Style.ImageIndex = 0;
        }

        #endregion

        #region FillControlPanel
        protected void FillControlPanel()
        {
            foreach (string linetype in Enum.GetNames(typeof(System.Drawing.Drawing2D.DashStyle)))
                this.comboBox1.Items.Add(linetype);
            this.comboBox1.SelectedIndex = 0;

            foreach (string representationtype in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartLegendRepresentationType)))
            {
                this.comboBox2.Items.Add(representationtype);
            }
            this.comboBox2.SelectedIndex = 5;
        }

        #endregion

        #endregion

        #region Events

        void series_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            //Specifying  different Colors for data points using Prepare style event
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                if (this.chartControl1.Series[0].Type.ToString() == "Line")
                {
                    if (args.Index == 0)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);
                    else if (args.Index == 1)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Green);
                    else if (args.Index == 2)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Blue);
                    else if (args.Index == 3)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Yellow);
                    else if (args.Index == 4)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Violet);
                    else if (args.Index == 5)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond);
                    else if (args.Index == 6)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Brown);
                    else if (args.Index == 7)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Aqua);
                    else if (args.Index == 8)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);
                    else if (args.Index == 9)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Green);
                    else if (args.Index == 10)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Blue);
                    else if (args.Index == 11)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Yellow);
                    else if (args.Index == 12)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Violet);
                    else if (args.Index == 13)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond);
                    else if (args.Index == 14)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Brown);
                    else if (args.Index == 15)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Aqua);
                    else if (args.Index == 16)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);
                    else if (args.Index == 17)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Green);
                    else if (args.Index == 18)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Blue);
                    else if (args.Index == 19)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Yellow);
                    else if (args.Index == 20)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Violet);
                    else if (args.Index == 21)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond);
                    else if (args.Index == 22)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Brown);
                    else if (args.Index == 23)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Aqua);
                    else if (args.Index == 24)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);
                    else if (args.Index == 25)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Green);
                    else if (args.Index == 26)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Blue);
                    else if (args.Index == 27)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Yellow);
                    else if (args.Index == 28)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Violet);
                    else if (args.Index == 29)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.BlanchedAlmond);
                    else if (args.Index == 30)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Brown);
                    else if (args.Index == 31)
                        args.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.Red);

                }
            }
        }
        private void comboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                this.chartControl1.Series[i].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);

                this.chartControl1.Series[i].Style.Border.Width = (float)(this.numericUpDown1.Value);
            }

            if ((this.comboBoxChartType.Text == "Line"))
            {
                this.checkBox1.Visible = true;
                this.chartControl1.Redraw(true);
            }
            if ((this.comboBoxChartType.Text == "Spline"))
            {
                this.checkBox1.Visible = false;
                this.chartControl1.Redraw(true);
            }
            if ((this.comboBoxChartType.Text == "StepLine"))
            {
                this.checkBox1.Visible = false;
                this.chartControl1.Redraw(true);
            }
            if (this.comboBoxChartType.Text == "RotatedSpline")
            {
                this.checkBox1.Visible = false;
                this.chartControl1.Series[0].Type = ChartSeriesType.RotatedSpline;
                this.chartControl1.Series[1].Type = ChartSeriesType.RotatedSpline;
                count = count + 1;
                this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(1985, 2000, 2);
                this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(0,16, 2);
                this.chartControl1.PrimaryXAxis.Title = "Rank";
                this.chartControl1.PrimaryYAxis.Title = "Year";

            }
            else
            {
                this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(1985, 2000, 1);               
                this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 16, 2);
                this.chartControl1.PrimaryXAxis.Title = "Year";
                this.chartControl1.PrimaryYAxis.Title = "Rank";
               
            }
            this.chartControl1.Redraw(true);
        }

        private void radiobutton1_SeriesType_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Style.Border.Width = (float)(this.numericUpDown1.Value);
            this.chartControl1.Series[0].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void radiobutton2_SeriesType_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[1].Style.Border.Width = (float)(this.numericUpDown1.Value);
            this.chartControl1.Series[1].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.chartControl1.Series[0].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            else if(radioButton2.Checked)
                this.chartControl1.Series[1].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            else
                this.chartControl1.Series[2].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.chartControl1.Series[0].Style.Border.Width = (float)(this.numericUpDown1.Value);
            else if (this.radioButton2.Checked)
                this.chartControl1.Series[1].Style.Border.Width = (float)(this.numericUpDown1.Value);
            else 
                this.chartControl1.Series[2].Style.Border.Width = (float)(this.numericUpDown1.Value);
            this.chartControl1.Redraw(true);
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.chartControl1.Series[0].EnableStyles = true;
                this.chartControl1.Series[1].EnableStyles = true;
                this.chartControl1.Series[2].EnableStyles = true;
                this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
                this.chartControl1.Series[1].PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
                this.chartControl1.Series[2].PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            }
            else
            {
                this.chartControl1.Series[0].EnableStyles = false;
                this.chartControl1.Series[1].EnableStyles = false;
                this.chartControl1.Series[2].EnableStyles = false;
            }

            this.chartControl1.Redraw(true);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Legend.RepresentationType = (ChartLegendRepresentationType)Enum.Parse(typeof(ChartLegendRepresentationType), this.comboBox2.SelectedItem.ToString(), true);

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox2.Checked;
            this.chartControl1.Depth = 50;
        }
        #endregion

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[2].Style.Border.Width = (float)(this.numericUpDown1.Value);
            this.chartControl1.Series[2].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

    }
}
