using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using System.Threading;

namespace ChartLocalization_2005
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
             InitializeComponent();
            SeriesData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.comboBox1.SelectedIndex = 0;       
        }
        public void SeriesData()
        {
            chartControl1.Series.Clear();

            ChartSeries Gold = new ChartSeries("Gold");
            Gold.Points.Add(1992, 37);
            Gold.Points.Add(1996, 44);
            Gold.Points.Add(2000, 40);
            Gold.Points.Add(2004, 35);
            Gold.Points.Add(2008, 36);
            chartControl1.Series.Add(Gold);

            ChartSeries Silver = new ChartSeries("Silver");
            Silver.Points.Add(1992, 34);
            Silver.Points.Add(1996, 32);
            Silver.Points.Add(2000, 24);
            Silver.Points.Add(2004, 31);
            Silver.Points.Add(2008, 38);
            chartControl1.Series.Add(Silver);

            ChartSeries Bronze = new ChartSeries("Bronze");
            Bronze.Points.Add(1992, 37);
            Bronze.Points.Add(1996, 25);
            Bronze.Points.Add(2000, 33);
            Bronze.Points.Add(2004, 29);
            Bronze.Points.Add(2008, 36);
            Bronze.Type = ChartSeriesType.Spline;
            Bronze.Style.Symbol.Shape = ChartSymbolShape.Circle;
            Bronze.Style.Symbol.Color = Color.White;
            Bronze.Style.Symbol.Border.Color = Color.Green;
            Bronze.Style.Symbol.Border.Width = 2;
            Bronze.ZOrder = 0;
            chartControl1.Series.Add(Bronze);

            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(1988, 2012, 4);
         

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Localize = this.comboBox1.Text;
        }     
    }
}