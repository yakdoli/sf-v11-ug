using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace FinancialChart
{
	public class Form1 : Office2007Form
	{
        #region Private Members

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox3;
        private Label label9;
        private Label label3;
        private Label label4;
        private Panel panel2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion 
        		
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Etched;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(301, 74);
            this.chartControl1.LegendAlignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Near;
            this.chartControl1.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Right;
            this.chartControl1.Location = new System.Drawing.Point(15, 14);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Navy;
            this.chartControl1.PrimaryXAxis.OriginDate = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryYAxis.OriginDate = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            this.chartControl1.Size = new System.Drawing.Size(430, 306);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 104);
            this.panel1.TabIndex = 1;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Location = new System.Drawing.Point(314, 39);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(77, 18);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "NASDAQ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(104, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select series";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(262, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "NYSE";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(108, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 1);
            this.label3.TabIndex = 8;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Location = new System.Drawing.Point(262, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(104, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Open-Close Draw Mode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(104, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "HiLo Open Close";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Candle Chart",
            "HiLo Chart",
            "HiLo Open Close Chart",
            "Kagi Chart",
            "Point And Figure Chart",
            "Renko Chart",
            "Three Line Break Chart"});
            this.comboBox1.Location = new System.Drawing.Point(81, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Financial Chart";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(395, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(66, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "3D Style";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 346);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 24);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(466, 474);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Charts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.chartControl1.Series.Clear();
            this.comboBox1.SelectedIndex = 0;
            FillControlPanel();
            this.comboBox2.SelectedIndex = 0;
            InitializeControlSettings();
           
        }
        #endregion 

        #region Helper Methods

        #region InitializeControlSettings
        private void InitializeControlSettings()
        {
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.chartControl1.Legend.Visible = false;

            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(85, 142, 213));
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Color.Transparent, Color.Transparent);// System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(213))))), System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(142)))), ((int)(((byte)(213))))));
            
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(155, 178, 242);
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(155, 178, 242);
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(155, 178, 242);
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(155, 178, 242);

            this.chartControl1.BorderAppearance.SkinStyle = ChartBorderSkinStyle.Etched;
            this.chartControl1.BorderAppearance.Interior.ForeColor = Color.FromArgb(86, 143, 213);
        }

        #endregion

        #region SetColor
        private void SetColor()
        {
            Color[] color1 = new Color[] { Color.FromArgb(33, 76, 129), Color.FromArgb(191, 219, 255), Color.FromArgb(33, 76, 129) };//, Color.FromArgb(166, 198, 255) };//, Color.White };
          
            this.chartControl1.Series[0].Style.Interior = new BrushInfo(GradientStyle.Horizontal, color1);
            this.chartControl1.Series[0].Style.Border.Color = Color.White;
            this.chartControl1.Series[0].Style.Border.Width = 1;


        }
        private void SetColor1()
        {
            Color[] color1 = new Color[] { Color.White};
            this.chartControl1.Series[0].Style.Interior = new BrushInfo(GradientStyle.None, color1);
            Color[] color2 = new Color[] { Color.FromArgb(33, 76, 129)};
            this.chartControl1.Series[1].Style.Interior = new BrushInfo(GradientStyle.None, color2);
        }
        #endregion 

        #region InitializeChartData
        protected void InitializeChartData()
        {
            Random r = new Random();

            string select1 = this.comboBox1.SelectedItem.ToString();
            this.Size = new Size(478, 410);
            this.panel1.Visible = false;
            switch (select1)
            {
                case "Candle Chart":                 

                    ChartSeries series1 = new ChartSeries(" Series 1", ChartSeriesType.Candle);
                    series1.Text = series1.Name;

                    DateTime date1 = new DateTime(2006, 2, 12);
                    series1.Points.Add(date1.AddDays(1), 470, 200, 270, 400);
                    series1.Points.Add(date1.AddDays(2), 520, 234, 321, 458);
                    series1.Points.Add(date1.AddDays(3), 482, 193, 352, 302);
                    series1.Points.Add(date1.AddDays(4), 457, 230, 300, 410);
                    series1.Points.Add(date1.AddDays(5), 421, 150, 357, 200);
                    series1.Points.Add(date1.AddDays(6), 475, 200, 300, 385);
                  
                    this.chartControl1.Series.Add(series1);
                    this.chartControl1.Text = "Stock Price Summary";
                    this.chartControl1.PrimaryYAxis.Title = "Price $";
                    this.chartControl1.PrimaryXAxis.Title = "Week Day";
                    this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(date1, date1.AddDays(7), 2, ChartDateTimeIntervalType.Days);
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.Text = "Candle Chart";
                    SetColor();
                break;
                case "HiLo Chart":
                   
                    ChartSeries series2 = new ChartSeries("NYSE", ChartSeriesType.HiLo);
                    series2.Text = series2.Name;
                    DateTime start = new DateTime(2006, 2, 20);

                    series2.Points.Add(start.AddDays(0), 456, 214, 364, 386);
                    series2.Points.Add(start.AddDays(1), 491, 234, 321, 378);
                    series2.Points.Add(start.AddDays(2), 482, 193, 302, 352);
                    series2.Points.Add(start.AddDays(3), 437, 243, 354, 391);
                    series2.Points.Add(start.AddDays(4), 421, 223, 317, 367);
                    series2.Points.Add(start.AddDays(5), 434, 263, 339, 385);
                    series2.Points.Add(start.AddDays(6), 425, 245, 365, 396);
                    series2.Points.Add(start.AddDays(7), 457, 234, 385, 398);
                    series2.Points.Add(start.AddDays(8), 482, 267, 316, 389);
                    series2.Points.Add(start.AddDays(9), 496, 285, 374, 399);

                    ChartSeries series3 = new ChartSeries(" NASDAQ", ChartSeriesType.HiLo);
                    series3.Text = series3.Name;
                   
                    series3.Points.Add(start.AddDays(0), 437, 263, 373, 412);
                    series3.Points.Add(start.AddDays(1), 491, 243, 383, 391);
                    series3.Points.Add(start.AddDays(2), 480, 290, 313, 421);
                    series3.Points.Add(start.AddDays(3), 466, 215, 323, 452);
                    series3.Points.Add(start.AddDays(4), 486, 243, 328, 415);
                    series3.Points.Add(start.AddDays(5), 461, 263, 356, 371);
                    series3.Points.Add(start.AddDays(6), 489, 273, 316, 399);
                    series3.Points.Add(start.AddDays(7), 484, 285, 384, 415);
                    series3.Points.Add(start.AddDays(8), 461, 266, 396, 423);
                    series3.Points.Add(start.AddDays(9), 498, 278, 328, 433);

                    this.chartControl1.Series.Add(series2);
                    this.chartControl1.Series.Add(series3);
                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start.AddDays(-1), start.AddDays(10), 2, ChartDateTimeIntervalType.Days);
                    
                    this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
                    this.chartControl1.PrimaryYAxis.Title = "Price ($)";
                    this.chartControl1.Text = "HiLo Chart";
                    SetColor1();
                 break;
                case "HiLo Open Close Chart":

                    this.Size = new Size(478, 515);
                    this.panel1.Visible = true;
                    ChartSeries series4 = new ChartSeries("NYSE", ChartSeriesType.HiLoOpenClose);
                    series4.Text = series4.Name;
                    DateTime date = new DateTime(2006, 2, 13);

                    series4.Points.Add(date, 456, 214, 364, 386);
                    series4.Points.Add(date.AddDays(1), 491, 234, 321, 378);
                    series4.Points.Add(date.AddDays(2), 482, 193, 302, 352);
                    series4.Points.Add(date.AddDays(3), 437, 243, 354, 391);
                    series4.Points.Add(date.AddDays(4), 421, 223, 317, 367);
                    series4.Points.Add(date.AddDays(5), 434, 263, 339, 385);

                    ChartSeries series5 = new ChartSeries("NASDAQ", ChartSeriesType.HiLoOpenClose);
                    series5.Text = series5.Name;

                    series5.Points.Add(date, 437, 263, 373, 412);
                    series5.Points.Add(date.AddDays(1), 491, 243, 383, 391);
                    series5.Points.Add(date.AddDays(2), 480, 290, 313, 421);
                    series5.Points.Add(date.AddDays(3), 466, 215, 323, 452);
                    series5.Points.Add(date.AddDays(4), 486, 243, 328, 415);
                    series5.Points.Add(date.AddDays(5), 461, 263, 356, 371);

                    this.chartControl1.Series.Add(series4);
                    this.chartControl1.Series.Add(series5);

                    this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                    this.chartControl1.PrimaryXAxis.DateTimeFormat =  "MMM/dd";
                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(date.AddDays(-1), date.AddDays(6), 2, ChartDateTimeIntervalType.Days);
                    this.chartControl1.PrimaryXAxis.Title = "Week Days";
                    this.chartControl1.PrimaryYAxis.Title = "Price $";
                    this.chartControl1.Text = "HiLo Open Close Chart";
                    SetColor1();
                break;
                case "Kagi Chart":
                   
                    double[] points2 = { 25.25, 27.75, 29.0, 28.275, 27.75, 27.75, 27.275, 26.25, 25.75, 25.25, 26.25, 25.25, 24.5, 25.625, 25.5, 26.625, 26.275, 26.25, 26.875, 27.25, 26.875, 26.5, 27.125, 26.275, 25.875, 26.625, 27.125, 26.25, 27.0, 27.25, 27.5, 28.5, 29.5, 28.875, 28.5, 29.0, 28.5, 28.5, 29.0, 29.0, 40.0, 29.875, 29.875, 28.875, 28.5, 28.25, 28.875, 29.275, 29.275, 29.75, 29.5, 29.275, 28.5, 27.75, 27.625, 27.5, 26.5, 25.0, 26.625, 26.0, 25.875, 25.0, 25.25, 25.125, 25.05 };
                    DateTime current = new DateTime(2004, 01, 1);
                    int numPoints = points2.Length;

                    ChartSeries series = new ChartSeries("Series 1");
                    for (int j = 0; j < numPoints; j++)
                    {
                        series.Points.Add(current.AddDays(j * 5), points2[j]);
                    }

                    series.Type = ChartSeriesType.Kagi;
                    series.Text = series.Name;
                    series.ReversalAmount = 1.0;
                    series.ConfigItems.FinancialItem.PriceUpColor = Color.White;
                    series.ConfigItems.FinancialItem.PriceDownColor = Color.FromArgb(33, 76, 129);

                    series.Style.Border.Width = 1;
                    this.chartControl1.Series.Add(series);

                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(current, current.AddMonths(13), 3, ChartDateTimeIntervalType.Months);
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.Text = "Kagi Chart";
                  break;
                case "Point And Figure Chart":
                     double[] points = {   35.250,37.750,39.000,38.275,37.750,37.750,37.275,36.250,35.750,35.250,36.250,35.250,34.500,
										  35.625,35.500,36.625,36.275,36.250,36.875,37.250,36.875,36.500,37.125,36.275,35.875,36.625,
										  27.125,26.250,27.000,27.250,37.500,38.500,39.500,38.875,38.500,39.000,38.500,28.500,29.000,
										  29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275,
										  28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050};

                    double[] points1 = {   25,27.500,28.750,28.025,27.500,27.500,27.025,26.250,35.750,35.250,36.250,35.250,34.500,
										   25.625,25.500,26.625,26.275,26.250,26.875,27.250,26.875,26.500,27.125,26.275,25.875,26.625,
										   27.125,26.250,27.000,27.250,27.500,38.500,39.500,38.875,38.500,39.000,28.500,28.500,29.000,
										   29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275,
										   28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050};


                    DateTime current1 = new DateTime(2004, 01, 1);
                    int numPoints1 = points.Length;

                    ChartSeries series7 = new ChartSeries("Series 1");
                    for (int j = 0; j < numPoints1; j++)
                    {
                        series7.Points.Add(current1.AddDays(j), new double[] { points[j], points1[j] });
                    }

                    series7.Type = ChartSeriesType.PointAndFigure;
                    series7.Text = series7.Name;
                    series7.ReversalAmount = 0.0;
                  
                    
                    this.chartControl1.Series.Add(series7);

                    this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(current1, current1.AddDays(30), 10, ChartDateTimeIntervalType.Days);
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.Text = "Point And Figure Chart";
                    series7.ConfigItems.FinancialItem.PriceUpColor = Color.White;
                    series7.ConfigItems.FinancialItem.PriceDownColor = Color.FromArgb(33, 76, 129);
                    series7.Style.Border.Width = 1;
                    SetColor();
                 break;
               case "Renko Chart":         
                    double[] points5 = {   25.250,27.750,29.000,28.275,27.750,27.750,27.275,26.250,25.750,25.250,26.250,25.250,24.500,
										  25.625,25.500,26.625,26.275,26.250,26.875,27.250,26.875,26.500,27.125,26.275,25.875,26.625,
										  27.125,26.250,27.000,27.250,27.500,28.500,29.500,28.875,28.500,29.000,28.500,28.500,29.000,
										  29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275,
										  28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050};

                    DateTime date5 = new DateTime(2004, 1, 1);

                    ChartSeries series11 = new ChartSeries("Series " + 0);

                    for (int day = 0; day < points5.Length; day++)
                    {
                        series11.Points.Add(date5.AddDays(day), points5[day]);
                    }

                    series11.Type = ChartSeriesType.Renko;
                    series11.ReversalAmount = 1;
                    series11.ConfigItems.FinancialItem.PriceUpColor = Color.White;
                    series11.ConfigItems.FinancialItem.PriceDownColor = Color.FromArgb(33, 76, 129);
                    this.chartControl1.Series.Add(series11);

                    this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(date5, date5.AddDays(60), 10, ChartDateTimeIntervalType.Days);
                    this.chartControl1.Text = "Renko Chart";
                    this.chartControl1.PrimaryYAxis.Format = "$ #";
                    break;
                case "Three Line Break Chart":
                  
                    double[] points6 = {   25.250,27.750,29.000,28.275,27.750,27.750,27.275,26.250,25.750,25.250,26.250,25.250,24.500,
										  25.625,25.500,26.625,26.275,26.250,26.875,27.250,26.875,26.500,27.125,26.275,25.875,26.625,
										  27.125,26.250,27.000,27.250,27.500,28.500,29.500,28.875,28.500,29.000,28.500,28.500,29.000,
										  29.000,40.000,29.875,29.875,28.875,28.500,28.250,28.875,29.275,29.275,29.750,29.500,29.275,
										  28.500,27.750,27.625,27.500,26.500,25.000,26.625,26.000,25.875,25.000,25.250,25.125,25.050};

                    DateTime dates = DateTime.Today.AddDays(-points6.Length);

                    ChartSeries series8 = new ChartSeries("Series " + 0);

                    for (int day = 0; day < points6.Length; day++)
                    {
                        series8.Points.Add(dates.AddDays(day), points6[day]);
                    }

                    series8.Type = ChartSeriesType.ThreeLineBreak;
                    series8.ReversalAmount = 3.0;
                    series8.ConfigItems.FinancialItem.PriceUpColor = Color.White;
                    series8.ConfigItems.FinancialItem.PriceDownColor = Color.FromArgb(33, 76, 129);
                  
                    this.chartControl1.Text = "Three Line Break Chart";
                    this.chartControl1.PrimaryYAxis.Format = "$ #";
                    this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(dates, dates.AddDays(60), 10, ChartDateTimeIntervalType.Days);
                    this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM/dd";
                    this.chartControl1.Series.Add(series8);
                    break;
                default:
                    MessageBox.Show("Select any ONE Chart from the ListBox", "Error", MessageBoxButtons.OK);
                    break;
            }           
        }

        #endregion

        #region FillControlPanel
        protected void FillControlPanel()
        {
            foreach (string mode in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartOpenCloseDrawMode)))
                this.comboBox2.Items.Add(mode);

        }

        #endregion

       
        #endregion 
        
        #region Events
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series.Clear();
            InitializeChartData();
        }

        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox1.Checked && this.checkBox2.Checked)
            {
                this.chartControl1.Series[0].ConfigItems.HiLoOpenCloseItem.DrawMode = (ChartOpenCloseDrawMode)Enum.Parse(typeof(ChartOpenCloseDrawMode), this.comboBox2.SelectedItem.ToString(), true);
                this.chartControl1.Series[1].ConfigItems.HiLoOpenCloseItem.DrawMode = (ChartOpenCloseDrawMode)Enum.Parse(typeof(ChartOpenCloseDrawMode), this.comboBox2.SelectedItem.ToString(), true);
            }
            else if (this.checkBox1.Checked)
                this.chartControl1.Series[0].ConfigItems.HiLoOpenCloseItem.DrawMode = (ChartOpenCloseDrawMode)Enum.Parse(typeof(ChartOpenCloseDrawMode), this.comboBox2.SelectedItem.ToString(), true);
            else if (this.checkBox2.Checked)
                this.chartControl1.Series[1].ConfigItems.HiLoOpenCloseItem.DrawMode = (ChartOpenCloseDrawMode)Enum.Parse(typeof(ChartOpenCloseDrawMode), this.comboBox2.SelectedItem.ToString(), true);

            this.chartControl1.Refresh();
        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.chartControl1.Series3D = true;
            }
            else
            {
                this.chartControl1.Series3D = false;
            }
        }

        #endregion 
	}
}
