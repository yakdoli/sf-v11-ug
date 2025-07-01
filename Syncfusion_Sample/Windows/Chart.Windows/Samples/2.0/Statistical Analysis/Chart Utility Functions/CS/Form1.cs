using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Chart.Statistics;
using Syncfusion.Drawing;

namespace ChartUtilityFunctions1
{
	public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Panel panel1;
		private double doubleX;
		private double y;
		private double coef;
		private double beta;
		private double n;
		private double m;
		private ChartSeries series;
        private Label label6;
        private Label label7;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        #region Form's Constructor, Main And Dispose

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))), System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))));
            this.chartControl1.ForeColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(70, 222);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Location = new System.Drawing.Point(14, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(436, 337);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Essential Chart-Utility Function";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart-Utility Function";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Location = new System.Drawing.Point(134, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9",
            "0.99"});
            this.comboBox2.Location = new System.Drawing.Point(134, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox3.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "8",
            "10",
            "15",
            "20",
            "30"});
            this.comboBox3.Location = new System.Drawing.Point(153, 154);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(81, 21);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox4.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "8",
            "10",
            "15",
            "20",
            "30"});
            this.comboBox4.Location = new System.Drawing.Point(153, 184);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(81, 21);
            this.comboBox4.TabIndex = 4;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Degrees of Freedom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Values";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(137, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 215);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Inverse Distribution";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(19, 248);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "One Tail";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(453, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 361);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Distributions";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(3, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Utitlity Functions";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Essential Chart-Utility Function";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.comboBox1.Items.Add("Normal Distribution");
            this.comboBox1.Items.Add("T Cumulative Distribution");
            this.comboBox1.Items.Add("F Cumulative Distribution");

            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox4.SelectedIndex = 0;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region Helper Methods

        #region NormalDistribution

        /// <summary>
        /// Updates Normal Distribution chart based on the changed values.
        /// </summary>
        protected void FillNDistribution()
        {
            double values = 0.0;

            if (!this.checkBox1.Checked)
                values = UtilityFunctions.NormalDistribution(Convert.ToDouble(this.comboBox2.SelectedItem));
            else
                values = UtilityFunctions.InverseNormalDistribution(Convert.ToDouble(this.comboBox2.SelectedItem));

            this.textBox1.Text = values.ToString("G5");
           
        }


        protected void InitializeNormalDistributionChart()
        {
            this.chartControl1.Series.Clear();

            //Initializes the Normal distribution series.
            series = new ChartSeries();

            series.Name = "Normal Distribution";
            series.Type = ChartSeriesType.SplineArea;
            series.Text = series.Name;

            coef = 1.0 / Math.Sqrt(2 * Math.PI);

            for (int x = -50; x <= 50; x++)
            {
                doubleX = x / 10.0;
                y = coef * Math.Exp(doubleX * doubleX / -2);

                //Add the data points to the series.
                series.Points.Add(doubleX - 0.05, y);
            }
            series.Style.Border.Color = Color.Transparent;
            //Add the series to the chart series collection.
            this.chartControl1.Series.Add(series);
        }
        #endregion

        #region TDistribution

        /// <summary>
        /// Updates the T Distribution chart based on the changed values.
        /// </summary>
        protected void FillTDistribution()
        {
            double values = 0.0;

            if (!this.checkBox1.Checked)
                values = UtilityFunctions.TCumulativeDistribution(double.Parse(this.comboBox2.SelectedItem.ToString()), double.Parse(this.comboBox3.SelectedItem.ToString()), this.checkBox2.Checked);
            else
                values = UtilityFunctions.InverseTCumulativeDistribution(double.Parse(this.comboBox2.SelectedItem.ToString()), double.Parse(this.comboBox3.SelectedItem.ToString()), this.checkBox2.Checked);

            this.textBox1.Text = values.ToString("G5");
         
        }

        protected void InitializeTDistributionChart()
        {
            this.chartControl1.Series.Clear();

            //Initializes the T distribution series.
            series = new ChartSeries();
            series.Name = "T Distribution";
            series.Type = ChartSeriesType.SplineArea;
            series.Text = series.Name;

            //Set the degree of freedom.
            n = double.Parse(this.comboBox3.SelectedItem.ToString());

            //Calculates the Beta function.
            beta = UtilityFunctions.Beta(0.5, n / 2.0);

            // Calculate coefficient of T Distribution.
            coef = Math.Pow(n, -0.5) / beta;

            // Calculate Data Points
            for (int x = -120; x <= 120; x++)
            {
                doubleX = x / 10.0;
                y = coef / Math.Pow(1.0 + doubleX * doubleX / n, (n + 1.0) / 2.0);

                //Add data points to the series.
                series.Points.Add(doubleX, y);
            }
            series.Style.Border.Color = Color.Transparent;

            //Add the series to the chart series collection.
            this.chartControl1.Series.Add(series);
           
        }
        #endregion

        #region FDistribution
        /// <summary>
        /// Updates the F Distribution chart based on the changed values.
        /// </summary>
        protected void FillFDistribution()
        {
            double values = 0.0;

            if (this.comboBox2.Text != "" && this.comboBox3.Text != "" && this.comboBox4.Text != "")
            {
                if (!this.checkBox1.Checked)
                    values = UtilityFunctions.FCumulativeDistribution(double.Parse(this.comboBox2.SelectedItem.ToString()), double.Parse(this.comboBox3.SelectedItem.ToString()), double.Parse(this.comboBox4.SelectedItem.ToString()));
                else
                    values = UtilityFunctions.InverseFCumulativeDistribution(double.Parse(this.comboBox2.SelectedItem.ToString()), double.Parse(this.comboBox3.SelectedItem.ToString()), double.Parse(this.comboBox4.SelectedItem.ToString()));
            }

            this.textBox1.Text = values.ToString("G5");
           
        }


        /// <summary>
        /// Initializes F distribution chart.
        /// </summary>
        protected void InitializeFDistributionChart()
        {
            this.chartControl1.Series.Clear();

            //Initializes the F distribution series.
            series = new ChartSeries();

            series.Name = "F Distribution";
            series.Type = ChartSeriesType.SplineArea;
            series.Text = series.Name;

            // Set degrees of freedom
            n = double.Parse(comboBox3.SelectedItem.ToString());
            m = double.Parse(comboBox4.SelectedItem.ToString());

            // Calculate the Beta function
            beta = UtilityFunctions.Beta(n / 2.0, m / 2.0);

            // Find coefficient
            coef = Math.Pow(n / m, n / 2.0) / beta;

            // Go through all data points and calculate values
            for (double x = 0.01; x <= 15; x += 0.1)
            {
                doubleX = x;
                y = coef * (Math.Pow(doubleX, n / 2.0 - 1.0) / Math.Pow(1.0 + n * doubleX / m, (n + m) / 2.0));

                // Add data points to the series.
                series.Points.Add(doubleX, y);
            }
            series.Style.Border.Color = Color.Transparent;
            //Add the series to the chart series collection.
            this.chartControl1.Series.Add(series);
        }
        #endregion

        #region DisplayChart
        /// <summary>
        /// Displays the distribution chart based on the selected value.
        /// </summary>
        protected void DisplayChart()
        {
            switch (this.comboBox1.SelectedItem.ToString())
            {
                case "Normal Distribution":
                    InitializeNormalDistributionChart();
                    this.comboBox3.Enabled = false;
                    this.comboBox4.Enabled = false;
                    this.checkBox2.Enabled = true;
                    FillNDistribution();
                    break;
                case "T Cumulative Distribution":
                    InitializeTDistributionChart();
                    this.comboBox3.Enabled = true;
                    this.comboBox4.Enabled = false;
                    this.checkBox2.Enabled = true;
                    FillTDistribution();
                    break;
                case "F Cumulative Distribution":
                    InitializeFDistributionChart();
                    this.comboBox3.Enabled = true;
                    this.comboBox4.Enabled = true;
                    this.checkBox2.Enabled = false;
                    FillFDistribution();
                    break;
                default:
                    InitializeNormalDistributionChart();
                    break;
            }
           
        }
        #endregion
        #endregion

        #region Events
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DisplayChart();
		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DisplayChart();
		}

		private void comboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.comboBox1.SelectedItem.ToString() == "T Cumulative Distribution")
			{
				DisplayChart();
				FillTDistribution();
			}
			else if(this.comboBox1.SelectedItem.ToString() == "F Cumulative Distribution")
			{
				if (comboBox4.Text != "")
					InitializeFDistributionChart();
				FillFDistribution();
			}			
		}

		private void comboBox4_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(this.comboBox1.SelectedItem.ToString() == "T Cumulative Distribution")
			{
				DisplayChart();
				FillTDistribution();
			}
			else if(this.comboBox1.SelectedItem.ToString() == "F Cumulative Distribution")
			{
				if (comboBox3.Text != "")
					InitializeFDistributionChart();
				FillFDistribution();
			}		
        }
        #endregion
    }
}
