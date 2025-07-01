using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace ChartWaterMarker
{
    public partial class Form1 : Office2007Form
    {
        Color[] legendColor = new Color[] { Color.White, Color.White, Color.White, Color.White, Color.FromArgb(189, 221, 253), Color.FromArgb(236, 241, 245) };
        Color[] legendHighlightColor = new Color[] { Color.FromArgb(249, 196, 74), Color.FromArgb(249, 196, 74), Color.FromArgb(249, 196, 74), Color.FromArgb(189, 221, 253), Color.FromArgb(236, 241, 245) };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #region InitializeData
        protected void InitializeData()
        {
            this.comboBox1.SelectedIndex = 1;
            this.comboBox2.SelectedIndex = 1;
            this.comboBox3.SelectedIndex = 1;

            this.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\..\..\..\Common\images\Chart\Logo.png");
            this.chartControl1.ChartArea.Watermark.Font = new Font("Times New Roman", 14, FontStyle.Bold);
            this.chartControl1.ChartArea.Watermark.TextColor = Color.MidnightBlue;

            this.chartControl1.Depth = 75;
            this.chartControl1.Series.Clear();

            ChartSeries series1 = new ChartSeries();
            series1.Name = "Model1_Blue";
            series1.Text = "Blue";
            series1.Points.Add(1996, 40);
            series1.Points.Add(1998, 60);
            series1.Points.Add(2000, 75);
            series1.Points.Add(2002, 60);
            series1.Points.Add(2004, 55);
            series1.Points.Add(2006, 85);
            series1.Type = ChartSeriesType.Spline;
            series1.Style.Border.Width = 3;
            series1.Style.ImageIndex = 0;
            series1.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series1.Style.Border.Color = Color.FromArgb(49, 73, 102);
            chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Model1_Green";
            series2.Text = "Green";
            series2.Points.Add(1996, 35);
            series2.Points.Add(1998, 70);
            series2.Points.Add(2000, 45);
            series2.Points.Add(2002, 20);
            series2.Points.Add(2004, 35);
            series2.Points.Add(2006, 65);
            series2.Type = ChartSeriesType.Spline;
            series2.Style.Border.Width = 3;
            series2.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series2.Style.ImageIndex = 1;
            series2.Style.Border.Color = Color.FromArgb(151, 188, 75);
            chartControl1.Series.Add(series2);
            this.chartControl1.ShowLegend = false;

            ChartSeries series3 = new ChartSeries();
            series3.Name = "Model2_Blue";
            series3.Text = "Red";
            series3.Points.Add(1996, 60);
            series3.Points.Add(1998, 35);
            series3.Points.Add(2000, 55);
            series3.Points.Add(2002, 30);
            series3.Points.Add(2004, 65);
            series3.Points.Add(2006, 45);
            series3.Type = ChartSeriesType.Spline;
            series3.Style.Border.Width = 3;
            series3.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series3.Style.ImageIndex = 2;
            series3.Style.Border.Color = Color.FromArgb(110, 68, 67);
            chartControl1.Series.Add(series3);

            ChartSeries series4 = new ChartSeries();
            series4.Name = "Model2_Green";
            series4.Text = "Pink";
            series4.Points.Add(1996, 45);
            series4.Points.Add(1998, 50);
            series4.Points.Add(2000, 35);
            series4.Points.Add(2002, 60);
            series4.Points.Add(2004, 35);
            series4.Points.Add(2006, 55);
            series4.Type = ChartSeriesType.Spline;
            series4.Style.Border.Width = 3;
            series4.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            series4.Style.ImageIndex = 3;
            series4.Style.Border.Color = Color.FromArgb(169, 119, 118);
            chartControl1.Series.Add(series4);
        }

        #region Event

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.Watermark.HorizontalAlignment = (ChartAlignment)Enum.Parse(typeof(ChartAlignment), this.comboBox1.SelectedItem.ToString(), true);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.Watermark.VerticalAlignment = (ChartAlignment)Enum.Parse(typeof(ChartAlignment), this.comboBox2.SelectedItem.ToString(), true);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.chartControl1.ChartArea.Watermark.Image = null;
                this.chartControl1.ChartArea.Watermark.Text = "Syncfusion Chart";

                this.label3.Enabled = true;
                this.numericUpDown1.Enabled = true;
            }
            else if (radioButton2.Checked == false)
            {
                this.label3.Enabled = false;
                this.numericUpDown1.Enabled = false;
                this.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\..\..\..\Common\images\Chart\Logo.png");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.chartControl1.ChartArea.Watermark.Text = null;
                this.chartControl1.ChartArea.Watermark.Image = System.Drawing.Image.FromFile(@"..\..\..\..\..\..\..\..\..\Common\images\Chart\Logo.png");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.Watermark.Opacity = Convert.ToSingle(this.numericUpDown1.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox1.Checked;
           
            if (checkBox1.Checked)
            {
                this.label4.Enabled = true;
                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    this.chartControl1.Series[i].Style.Border.Width = 2f;
                }

            }
            else if (checkBox1.Checked == false)
            {
                this.label4.Enabled = false;
                for (int i = 0; i < this.chartControl1.Series.Count; i++)
                {
                    this.chartControl1.Series[i].Style.Border.Width = 3f;
                }

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.Watermark.ZOrder = (ChartWaterMarkOrder)Enum.Parse(typeof(ChartWaterMarkOrder), this.comboBox3.SelectedItem.ToString(), true);
        }
        #endregion

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Vertical  )
            {
                //Applying Formatted Axis label values.
                e.Label = string.Format("{0}%", e.Value);
            }
            e.Handled = true;
        }
        #endregion
    }
}