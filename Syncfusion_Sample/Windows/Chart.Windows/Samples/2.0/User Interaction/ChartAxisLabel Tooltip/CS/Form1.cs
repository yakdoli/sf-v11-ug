using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using ColumnChart2005;
using System.Collections.Generic;
using System;

namespace ChartAxisLabelTooltip_2005
{
    public partial class Form1 : Form
    {
        List<string> arrLabel = new List<string>();
        List<string> arrTooltip = new List<string>();
        public Form1()
        {
            InitializeComponent();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.ChartFormatAxisLabel += new ChartFormatAxisLabelEventHandler(chartControl1_ChartFormatAxisLabel);
            ChartSeries series = new ChartSeries("Series");
            this.chartControl1.Indexed = true;
            series.Points.Add(0, 120);
            series.Points.Add(1, 220);
            series.Points.Add(2, 150);
            series.Points.Add(3, 240);

            this.chartControl1.Series.Add(series);

            arrLabel.Add("India");
            arrLabel.Add("Pakistan");
            arrLabel.Add("Srilanka");
            arrLabel.Add("Japan");
            arrTooltip.Add("IND");
            arrTooltip.Add("PAK");
            arrTooltip.Add("SRL");
            arrTooltip.Add("JPN");
            this.chartControl1.ShowToolTips = true;
            this.chartControl1.Series3D = true;

        }



        void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            int index = (int)e.Value;
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (index >= 0 && index < arrLabel.Count)
                {
                    e.Label = arrLabel[index].ToString();
                    e.ToolTip = arrTooltip[index].ToString();
                }
            }
            e.Handled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.ShowToolTips = this.checkBox1.Checked;

        }
    }
}