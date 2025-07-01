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

namespace Pareto
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Office2007Form
    {
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer timer1;
        private ChartAxis secYAxis = new ChartAxis();

        public Form1()
        {
            InitializeComponent();          
            ChartAppearance.ApplyChartStyles(chartControl);           
            this.BackColor = Color.White;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chartControl
            // 
            this.chartControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.chartControl.Legend.Location = new System.Drawing.Point(398, 31);
            this.chartControl.Location = new System.Drawing.Point(22, 22);
            this.chartControl.Name = "chartControl";
            this.chartControl.Size = new System.Drawing.Size(507, 331);
            this.chartControl.TabIndex = 0;
            // 
            // 
            // 
            this.chartControl.Title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl.Title.Name = "Def_title";
            this.chartControl.Title.Text = "";
            this.chartControl.Titles.Add(this.chartControl.Title);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(554, 375);
            this.Controls.Add(this.chartControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pareto Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            CreateParetoChart();
        }

        protected void CreateParetoChart()
        {
            this.chartControl.Title.Text = "Pareto Chart";
            this.chartControl.Series.Clear();

            ChartSeries series1 = new ChartSeries("Defects");
            series1.Type = ChartSeriesType.Column;
            series1.Points.Add(1, 120);
            series1.Points.Add(2, 60);
            series1.Points.Add(3, 50);
            series1.Points.Add(4, 40);
            series1.Points.Add(5, 20);
            series1.Points.Add(6, 10);
            series1.Style.Interior = new BrushInfo(Color.FromArgb(200, 140, 198, 62));
            series1.Style.Border.Color = Color.Transparent;
            this.chartControl.Series.Add(series1);
            this.chartControl.PrimaryXAxis.FormatLabel += new ChartFormatAxisLabelEventHandler(PrimaryXAxis_FormatLabel);
            this.chartControl.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl.PrimaryXAxis.Title = "Defects";

            ChartSeries ser = new ChartSeries("Frequency", ChartSeriesType.Line);
            ser.Style.Border.Width = 3;
            ser.Style.Interior = new BrushInfo(Color.FromArgb(163, 48, 45));
            ser.Points.Add(0, 0);

            double val = 0;
            // To get the Total of all points.
            for (int j = 0; j < this.chartControl.Series[0].Points.Count; j++)
            {
                val += this.chartControl.Series[0].Points[j].YValues[0];
            }

            int i = 0;
            // To get the cumulative points [ Y Values ] for line series.
            for (; i < this.chartControl.Series[0].Points.Count; i++)
            {
                double val1 = 0;
                for (int k = 0; k <= i; k++)
                {
                    val1 += this.chartControl.Series[0].Points[k].YValues[0];
                }

                ser.Points.Add(i + 1, (val1 / val) * 100); // calculates percentage of cumulative values
            }

            this.chartControl.PrimaryYAxis.Range.Max = val;
            this.chartControl.PrimaryYAxis.Title = "Frequency";
            
            ser.Style.Symbol.Shape = ChartSymbolShape.Diamond;
            ser.Style.Symbol.Color = Color.Yellow;
            ser.Style.Symbol.Size = new Size(7, 7);
            this.chartControl.Series.Add(ser);
            this.chartControl.PrimaryYAxis.Range.Max = val;

            secYAxis.DrawGrid = false;
            secYAxis.HidePartialLabels = false;
            secYAxis.OpposedPosition = true;
            secYAxis.Title = "Cumulative Frequency";
            secYAxis.ValueType = ChartValueType.Double;
            secYAxis.Orientation = ChartOrientation.Vertical;
            secYAxis.TickSize = new Size(5, 1);

            this.chartControl.Series[1].YAxis = secYAxis;
            this.chartControl.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.Stacking;
            this.chartControl.Axes.Add(secYAxis);

            // Set ranges
            secYAxis.Range = new MinMaxInfo(0, 100, 20);
            this.chartControl.PrimaryXAxis.Range = new MinMaxInfo(0, 7, 1);
            this.chartControl.PrimaryYAxis.Range.Min = 0;
            secYAxis.FormatLabel += new ChartFormatAxisLabelEventHandler(secYAxis_FormatLabel);
        }

        void PrimaryXAxis_FormatLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            e.Label = "D" + e.Label;
            e.Handled = true;
        }

        void secYAxis_FormatLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            e.Label += " %";
            e.Handled = true;
        }
    }
}