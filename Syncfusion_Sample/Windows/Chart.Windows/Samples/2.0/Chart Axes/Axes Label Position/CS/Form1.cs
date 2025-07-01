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

namespace AxesLabelPosition_2008
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
        bool[] neg = new bool[10];
        private void Appearanceset()
        {
           
            #region Chart Appearance Customization

            chartControl1.BackInterior = new BrushInfo(GradientStyle.PathRectangle, new Color[] { Color.FromArgb(214, 231, 247), Color.White });
            chartControl1.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chartControl1.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chartControl1.BorderAppearance.BaseColor = Color.SkyBlue;
            chartControl1.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
             chartControl1.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

             chartControl1.PrimaryYAxis.HidePartialLabels = true;
            chartControl1.PrimaryXAxis.LineType.ForeColor = Color.Gray; 
            chartControl1.PrimaryYAxis.LineType.ForeColor = Color.Gray; 
            chartControl1.PrimaryXAxis.LineType.Width = 1;
            chartControl1.PrimaryYAxis.LineType.Width = 1;
            chartControl1.PrimaryXAxis.TickColor = Color.Transparent;
            chartControl1.PrimaryYAxis.TickColor = Color.Transparent;
            chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.LightGray;
            chartControl1.PrimaryYAxis.GridLineType.ForeColor = Color.LightGray;
            chartControl1.Legend.Visible = false;
          
            chartControl1.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);

            #endregion
        }
        ChartSeries ser = new ChartSeries("Area");
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            InitChart();
            Appearanceset();
           
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(-150, 150, 50);
            this.chartControl1.Text = "Net Export of Selected Nation";
            this.chartControl1.PrimaryXAxis.Title = "Net Export(Billions of dollars)";
 
            ser.Points.Add(1, -45);
            ser.Points.Add(2, -80);
            ser.Points.Add(3, 90);
            ser.Points.Add(4, 130);
            ser.Points.Add(5, -100);
            ser.Points.Add(6, 80);
 
            ser.Type = ChartSeriesType.Bar;
            this.chartControl1.Series.Add(ser);
            Colorset();
            this.chartControl1.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Inside;
            this.chartControl1.PrimaryYAxis.Crossing = 0;  


        }

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            
            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                if (e.Label == "1")
                {
                    if (customizeEvent)
                    {
                        if (ser.Points[(int)e.Value - 1].YValues[0] > 0)
                            e.AxisLabelPlacement = ChartPlacement.Outside;
                        else
                            e.AxisLabelPlacement = ChartPlacement.Inside;
                    }
                    e.Label = "Canada";
                }
                else if (e.Label == "2")
                {
                    if (customizeEvent)
                    {
                        if (ser.Points[(int)e.Value - 1].YValues[0] > 0)
                            e.AxisLabelPlacement = ChartPlacement.Outside;
                        else
                            e.AxisLabelPlacement = ChartPlacement.Inside;
                    }
                    e.Label = "France";

                }
                else if (e.Label == "3")
                {
                    if (customizeEvent)
                    {
                        if (ser.Points[(int)e.Value - 1].YValues[0] > 0)
                            e.AxisLabelPlacement = ChartPlacement.Outside;
                        else
                            e.AxisLabelPlacement = ChartPlacement.Inside;
                    }
                    e.Label = "Italy";

                }
                else if (e.Label == "4")
                {
                    if (customizeEvent)
                    {
                        if (ser.Points[(int)e.Value - 1].YValues[0] > 0)
                            e.AxisLabelPlacement = ChartPlacement.Outside;
                        else
                            e.AxisLabelPlacement = ChartPlacement.Inside;
                    }
                    e.Label = "Japan";

                }
                else if (e.Label == "5")
                {
                    if (customizeEvent)
                    {
                        if (ser.Points[(int)e.Value - 1].YValues[0] > 0)
                            e.AxisLabelPlacement = ChartPlacement.Outside;
                        else
                            e.AxisLabelPlacement = ChartPlacement.Inside;
                    }
                    e.Label = "Britain";

                }
                else if (e.Label == "6")
                {
                    if (customizeEvent)
                    {
                        if (ser.Points[(int)e.Value - 1].YValues[0] > 0)
                            e.AxisLabelPlacement = ChartPlacement.Outside;
                        else
                            e.AxisLabelPlacement = ChartPlacement.Inside;
                    }
                    e.Label = "United States";

                }
                else
                    e.Label = "";
                e.Handled = true;
            }
        }


        bool customizeEvent = true;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            customizeEvent = this.checkBox1.Checked;
            if (customizeEvent)
            {
                this.chartControl1.PrimaryYAxis.AxisLabelPlacement = ChartPlacement.Inside;
                this.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            }
            else
            {
                   this.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.ClippingProtection;
           }
            this.chartControl1.Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ser.Points[this.comboBox1.SelectedIndex].YValues[0] = (double)this.numericUpDown1.Value;
            if (checkBox1.Checked)
            {
                this.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.ClippingProtection;
                
                this.chartControl1.PrimaryYAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            }
            Colorset();
            this.chartControl1.Refresh();
        }

        private void Colorset()
        {
            for (int i = 0; i < ser.Points.Count; i++)
            {
                if (ser.Points[i].YValues[0] < 0)
                {
                    ser.Styles[i].Interior = new BrushInfo(Color.FromArgb(200, 163, 48, 45));
                }
                else
                {
                    ser.Styles[i].Interior = new BrushInfo(Color.LightGreen);
                }
            }
        }
    }
}
