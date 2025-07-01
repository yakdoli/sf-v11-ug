using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;

namespace ChartCustomDrawing
{
    public class MainForm : Office2007Form
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Label label1;
        private System.ComponentModel.IContainer components = null;
        Color[] color = new Color[] { Color.FromArgb(150, 172, 90), Color.FromArgb(197, 229, 92), Color.FromArgb(150, 172, 90) };
        #endregion

        #region Form's Constructor, Main And Dispose
        public MainForm()
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
            Application.Run(new MainForm());
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(233)))), ((int)(((byte)(249))))), System.Drawing.Color.Transparent);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(325, 206);
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.LegendAlignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Near;
            this.chartControl1.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Right;
            this.chartControl1.Location = new System.Drawing.Point(22, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.OriginDate = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            this.chartControl1.PrimaryYAxis.OriginDate = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            this.chartControl1.ShowLegend = false;
            this.chartControl1.Size = new System.Drawing.Size(429, 336);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartAreaPaint += new System.Windows.Forms.PaintEventHandler(this.chartControl1_ChartAreaPaint);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "                   Arrows in the Primary axes and a line are drawn over the Chart" +
                "Area using the \r\n                   ChartAreaPaint event\r\n ";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(473, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Custom Drawing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            IntializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);

        }
        #endregion

        #region Helper Methods

        #region IntializeChartData
        private void IntializeChartData()
        {
            string tooltipTemplate = "Capacity: {0}; Range: {1}";
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Technology AAA";
            series1.Type = ChartSeriesType.Scatter;
            series1.Text = series1.Name;
            series1.Style.TextOffset = 7;

            series1.Points.Add(500, 300);
            series1.Styles[0].Text = "Point1";
            series1.Styles[0].ToolTip = String.Format(tooltipTemplate, 300, 500);

            series1.Points.Add(1000, 491);
            series1.Styles[1].Text = "Point2";
            series1.Styles[1].ToolTip = String.Format(tooltipTemplate, 491, 1000);

            series1.Points.Add(1500, 382);
            series1.Styles[2].Text = "Point3";
            series1.Styles[2].ToolTip = String.Format(tooltipTemplate, 382, 1500);

            series1.Points.Add(2000, 437);
            series1.Styles[3].Text = "Point4";
            series1.Styles[3].ToolTip = String.Format(tooltipTemplate, 437, 2000);

            series1.Points.Add(2500, 200);
            series1.Styles[4].Text = "Point5";
            series1.Styles[4].ToolTip = String.Format(tooltipTemplate, 200, 2500);

            series1.Style.DisplayText = true;
            series1.Style.TextOrientation = ChartTextOrientation.Up;
            this.chartControl1.Series.Add(series1);
            series1.Style.Font.Size = 7.0f;


        }
        #endregion

        #endregion

        #region ChartAreaPaint Event

        // Using the ChartAreaPaint event we can perform custom drawing over the chart area.   
        private void chartControl1_ChartAreaPaint(object sender, PaintEventArgs e)
        {
            Brush arrowBrush = new SolidBrush(Color.FromArgb(129, 115, 27));
            // Get the right end of the X axis
            Point ptX = this.chartControl1.ChartArea.GetPointByValue(new ChartPoint(this.chartControl1.PrimaryXAxis.Range.Max, this.chartControl1.PrimaryYAxis.Range.Min));

            PointF ptX1 = new PointF(ptX.X - 10, ptX.Y - 6);
            PointF ptX2 = new PointF(ptX.X, ptX.Y);
            PointF ptX3 = new PointF(ptX.X - 10, ptX.Y + 6);

            // Draws an arrow at the end of the X axis
            e.Graphics.FillPolygon(arrowBrush, new PointF[] { ptX1, ptX2, ptX3 });

            // Get the top end of the Y axis
            Point ptY = this.chartControl1.ChartArea.GetPointByValue(new ChartPoint(this.chartControl1.PrimaryXAxis.Range.Min, this.chartControl1.PrimaryYAxis.Range.Max));

            PointF ptY1 = new PointF(ptY.X - 6, ptY.Y + 10);
            PointF ptY2 = new PointF(ptY.X, ptY.Y);
            PointF ptY3 = new PointF(ptY.X + 6, ptY.Y + 10);

            // Draws an arrow at the top of the Y Axis.
            e.Graphics.FillPolygon(arrowBrush, new PointF[] { ptY1, ptY2, ptY3 });

            // Draws a line through the center of the chart.
            Pen pp = new Pen(Color.FromArgb(175, 129, 115, 27));
            e.Graphics.DrawLine(pp, ptY.X, ptX.Y, ptX.X, ptY.Y);
        }
        #endregion
    }
}

