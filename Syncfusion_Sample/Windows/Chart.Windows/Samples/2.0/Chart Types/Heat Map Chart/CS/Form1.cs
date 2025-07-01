using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using System.Collections;

namespace HeatMapChart_2005
{
    public partial class Form1 : Office2007Form
    {
        string[] str = { "Canada", "Brazil", "Argentina", "Arizona", "India", "Pakistan" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeChartData();
        }

        private void InitializeChartData()
        {
            ChartSeries Stocks = new ChartSeries("Stocks", ChartSeriesType.HeatMap);
            Stocks.Points.Add(7,4, 10000);
            Stocks.Points.Add(6,3, 5541);
            Stocks.Points.Add(5,2, 6007);
            Stocks.Points.Add(4,2, 5022);
            Stocks.Points.Add(3,2.5, 6882);
            Stocks.Points.Add(2,1.5, 6584);
            Stocks.Points.Add(1,1, 2799);

            Stocks.Styles[0].Text = "US";
            Stocks.Styles[1].Text = "South Carolina";
            Stocks.Styles[2].Text = "Florida";
            Stocks.Styles[3].Text = "Mexico";
            Stocks.Styles[4].Text = "Arizona";
            Stocks.Styles[5].Text = "North Carolina";
            Stocks.Styles[6].Text = "Utah";

            Stocks.Style.DisplayText = true;     
            Stocks.Style.Font.Size = 9f;           
            this.chartControl1.Series.Add(Stocks);

            this.chartControl1.ShowLegend = false;
            Stocks.ConfigItems.HeatMapItem.DisplayTitle = true;
            Stocks.ConfigItems.HeatMapItem.LowestValueColor = Color.FromArgb(255,23,0);
            Stocks.ConfigItems.HeatMapItem.HighestValueColor = Color.FromArgb(81,168,0);
            Stocks.ConfigItems.HeatMapItem.MiddleValueColor = Color.Gold;
            Stocks.ConfigItems.HeatMapItem.StartText = "US";
            Stocks.ConfigItems.HeatMapItem.EndText = "Utah";
            
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.Text = "Stocks- Sales and Expense details";

            this.chartControl1.BackInterior = new BrushInfo(GradientStyle.PathRectangle, new Color[] { Color.FromArgb(214, 231, 247), Color.White });
            this.chartControl1.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            this.chartControl1.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            this.chartControl1.BorderAppearance.BaseColor = Color.SkyBlue;
            this.chartControl1.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            this.comboBox1.SelectedIndex = 2;       
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            ChartSeries series = this.chartControl1.Series[0];
            series.ConfigItems.HeatMapItem.LowestValueColor = this.colorPickerButton1.SelectedColor;
            this.textBox1.BackColor = this.colorPickerButton1.SelectedColor;
            this.Refresh();
        }

        private void colorPickerButton2_ColorSelected(object sender, EventArgs e)
        {
            ChartSeries series = this.chartControl1.Series[0];
            series.ConfigItems.HeatMapItem.HighestValueColor = this.colorPickerButton2.SelectedColor;
            this.textBox2.BackColor = this.colorPickerButton2.SelectedColor;
            this.Refresh();
        }

        private void colorPickerButton3_ColorSelected(object sender, EventArgs e)
        {
            ChartSeries series = this.chartControl1.Series[0];
            series.ConfigItems.HeatMapItem.MiddleValueColor = this.colorPickerButton3.SelectedColor;
            this.textBox3.BackColor = this.colorPickerButton3.SelectedColor;
            this.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Points[0].YValues[0] = this.trackBar1.Value;
            this.chartControl1.Refresh();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Points[6].YValues[0] = this.trackBar2.Value;
            this.chartControl1.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.HeatMapItem.DisplayTitle = this.checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Style.DisplayText = this.checkBox2.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChartSeries series = this.chartControl1.Series[0];
            Random point = new Random();
            Random point1 = new Random();            
            double[] points={point.Next(1,10),point1.Next(2000,10000)};
            
            ChartPoint chp = new ChartPoint(this.chartControl1.Series[0].Points.Count+1,points);
            series.Points.Add(this.chartControl1.Series[0].Points.Count + 1, points);
            switch(this.chartControl1.Series[0].Points.Count%6)
            {
                case 0:
                    series.Styles[this.chartControl1.Series[0].Points.Count - 1].Text = str[0];
                    break;
                case 1:
                    series.Styles[this.chartControl1.Series[0].Points.Count - 1].Text = str[1];
                    break;
                case 2:
                    series.Styles[this.chartControl1.Series[0].Points.Count - 1].Text = str[2];
                    break;
                case 3:
                    series.Styles[this.chartControl1.Series[0].Points.Count - 1].Text = str[3];
                    break;
                case 4:
                    series.Styles[this.chartControl1.Series[0].Points.Count - 1].Text = str[4];
                    break;
                case 5:
                    series.Styles[this.chartControl1.Series[0].Points.Count - 1].Text = str[5];
                    break;
            }      
        
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.HeatMapItem.DisplayColorSwatch = this.checkBox3.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.HeatMapItem.HeatMapStyle = (ChartHeatMapLayoutStyle)Enum.Parse(typeof(ChartHeatMapLayoutStyle), this.comboBox1.SelectedItem.ToString(), true); 
        }
    }
}