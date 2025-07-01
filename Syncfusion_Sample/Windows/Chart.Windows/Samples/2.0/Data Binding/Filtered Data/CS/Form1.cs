#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Office2007Form
    {
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.ComponentModel.IContainer components = null;
        private DataModel datamodel1;
        private DataModel datamodel2;
        private DataModel datamodel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private DataProvider dprovider = new DataProvider();
        private DateTime start;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(437, 75);
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Title = "Time";
            this.chartControl1.PrimaryYAxis.Title = "Network Load";
            this.chartControl1.Size = new System.Drawing.Size(568, 333);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Peak Average Network Load";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Peak Average Network Load";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 29);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.numericUpDown1.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(493, 5);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(357, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Timer Interval";
            // 
            // checkBox1
            // 
            this.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox1.Location = new System.Drawing.Point(255, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Enable Styles";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 391);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtered Data ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
            InitializeChartData();
            InitializeChartAppearance();
            this.dprovider.timer1.Enabled = true;
            this.dprovider.timer1.Tick += new EventHandler(timer1_Tick);
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        /// <summary>
        /// Initializes Chart Data.
        /// </summary>
        protected void InitializeChartData()
        {
            //Setting Indexed to false speeds up the Chart. This is not a choice for making the Chart faster. 
            //If you don't need a Indexed/Positional Chart, you must set this property to false.
            this.chartControl1.Indexed = false;

            ChartSeries series = new ChartSeries("Line 1", ChartSeriesType.Line);
            datamodel1 = new DataModel();
            series.SeriesModel = datamodel1;

            //Point Symbols and Point Text will not be visible if Enable Styles is set to false.
            series.EnableStyles = false;

            //Turning shadow off means, your lines will not have shadows (and hence the chart will be rendered faster).
            series.Style.DisplayShadow = false;
            this.chartControl1.Series.Add(series);

            series = new ChartSeries("Line 2", ChartSeriesType.Line);
            datamodel2 = new DataModel();
            series.SeriesModel = datamodel2;
            this.chartControl1.Series.Add(series);

            series = new ChartSeries("Line 3", ChartSeriesType.Line);
            datamodel3 = new DataModel();
            series.SeriesModel = datamodel3;
            this.chartControl1.Series.Add(series);

            foreach (ChartSeries seriesn in this.chartControl1.Series)
            {
                seriesn.EnableStyles = false;
                seriesn.Style.DisplayShadow = false;
                seriesn.PrepareStyle += new ChartPrepareStyleInfoHandler(this.series_PrepareStyle);
            }
        }

        /// <summary>
        /// Initializes chart appearance.
        /// </summary>
        protected void InitializeChartAppearance()
        {
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "hh:mm:ss";

            //This property controls Tooltips and AutoHighlighting. 
            //If this value is set to false, these features will not work.
            this.chartControl1.CalcRegions = false;
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(DateTime.Now.AddMinutes(-1), DateTime.Now.AddMinutes(3), 1, ChartDateTimeIntervalType.Minutes);
            start = this.chartControl1.PrimaryXAxis.DateTimeRange.End;
        }

        /// <summary>
        /// Timer tick event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dprovider.timer1.Enabled = false;
            this.chartControl1.BeginUpdate();
            this.datamodel1.Refresh();
            this.datamodel2.Refresh();
            this.datamodel3.Refresh();
            this.chartControl1.EndUpdate();
            this.dprovider.timer1.Enabled = true;

            if (this.chartControl1.Series[2].Points[this.chartControl1.Series[2].Points.Count - 1].DateX > start)
            {
                this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(DateTime.Now.AddMinutes(-1), DateTime.Now.AddMinutes(2), 1, ChartDateTimeIntervalType.Minutes);
                start = this.chartControl1.PrimaryXAxis.DateTimeRange.End;
            }
        }

        private void series_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                args.Style.Symbol.Shape = ChartSymbolShape.Square;
                args.Style.Symbol.Size = new Size(2, 2);
                args.Style.Symbol.Color = Color.DarkGreen;
            }
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach (ChartSeries ser in this.chartControl1.Series)
                ser.EnableStyles = this.checkBox1.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.dprovider.timer1.Interval = (int)this.numericUpDown1.Value;
        }
    }
}