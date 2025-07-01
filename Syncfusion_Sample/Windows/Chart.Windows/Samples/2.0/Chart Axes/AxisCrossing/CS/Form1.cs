using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;

namespace Crossing_Demo_2008
{
    public partial class Form1 : Office2007Form
    {


        public Form1()
        {
            InitializeComponent();

        }



        private void InitChart()
        {
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryYAxis.DrawGrid = false;

        }
        private void Appearanceset()
        {
            chartControl1.Palette = ChartColorPalette.Custom;
            chartControl1.CustomPalette = new System.Drawing.Color[] 
            {              
                Color.FromArgb(200, 41,122,139),
                Color.FromArgb(200, 140,198,62),
                Color.FromArgb(200,247,148,29),
                Color.FromArgb(200, 163,48,45)                     
            };

            #region Chart Appearance Customization

            chartControl1.BackInterior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White);
            chartControl1.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chartControl1.ChartInterior = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(215, 228, 189), Color.White);
            chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chartControl1.BorderAppearance.BaseColor = Color.DarkOliveGreen;
            chartControl1.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chartControl1.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chartControl1.PrimaryXAxis.HidePartialLabels = true;
            chartControl1.PrimaryYAxis.HidePartialLabels = true;
            chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27);
            chartControl1.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27);
            chartControl1.PrimaryXAxis.LineType.Width = 2;
            chartControl1.PrimaryYAxis.LineType.Width = 2;
            chartControl1.PrimaryXAxis.TickColor = Color.Transparent;
            chartControl1.PrimaryYAxis.TickColor = Color.Transparent;
            chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.LightGray;
            chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.LightGray;
            chartControl1.Legend.Visible = false;
            chartControl1.Series[0].Style.Symbol.Border.Color = Color.FromArgb(200, 129, 115, 27);
            chartControl1.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);

            #endregion
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            InitChart();
            Appearanceset();
            this.chartControl1.Text = "Crossing";
            ChartSeries ser = new ChartSeries("Area");
            ChartSeries ser1 = new ChartSeries("Spline");

            ser.Points.Add(2, 45);
            ser.Points.Add(5, 100);
            ser.Points.Add(7, 210);
            ser.Points.Add(9, 110);
            ser.Points.Add(10, 150);
            ser.Points.Add(11, 180);
            ser1.Points.Add(2, 45);
            ser1.Points.Add(5, 100);
            ser1.Points.Add(7, 210);
            ser1.Points.Add(9, 110);
            ser1.Points.Add(10, 150);
            ser1.Points.Add(11, 180);
            ser.Type = ChartSeriesType.Spline;
            ser1.Type = ChartSeriesType.Area;
            this.chartControl1.Series.Add(ser);
            this.chartControl1.Series.Add(ser1);
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
           
        }







        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)this.comboBox1.SelectedItem == "Min")
                this.chartControl1.PrimaryXAxis.Crossing = double.MinValue;
            else if ((string)this.comboBox1.SelectedItem == "Max")
                this.chartControl1.PrimaryXAxis.Crossing = double.MaxValue;
            else
                this.chartControl1.PrimaryXAxis.Crossing = Convert.ToDouble(this.comboBox1.SelectedItem);
            this.chartControl1.Redraw(true);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)this.comboBox2.SelectedItem == "Min")
                this.chartControl1.PrimaryYAxis.Crossing = double.MinValue;
            else if ((string)this.comboBox2.SelectedItem == "Max")
                this.chartControl1.PrimaryYAxis.Crossing = double.MaxValue;
            else
                this.chartControl1.PrimaryYAxis.Crossing = Convert.ToDouble(this.comboBox2.SelectedItem);
            this.chartControl1.Redraw(true);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.chartControl1.Series3D = checkBox1.Checked;
            else
                this.chartControl1.Series3D = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.chartControl1.EnableXZooming = true;
                this.chartControl1.EnableYZooming = true;
            }
            else
            {
                this.chartControl1.EnableXZooming = false;
                this.chartControl1.EnableYZooming = false;
            }

        }


    }
}
