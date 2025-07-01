using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using System.Drawing.Drawing2D;
using Syncfusion.Drawing;

namespace MultipleAxesLayout
{
    public partial class Form1 : Office2007Form
    {
        #region Color settings        
        #endregion

        public Form1()
        {
            InitializeComponent();
        }     

        #region Chart control Data.
        private void ChartControlData()
        {
            this.chartControl1.Series.Clear();
            ChartAxis axis = this.chartControl1.PrimaryYAxis;
            ChartAxis axis0 = new ChartAxis(ChartOrientation.Vertical);
            ChartAxis axis1 = new ChartAxis(ChartOrientation.Vertical);
            ChartAxis axis2 = new ChartAxis(ChartOrientation.Vertical);
            ChartAxis axis3 = new ChartAxis(ChartOrientation.Vertical);
            ChartAxis axis4 = new ChartAxis(ChartOrientation.Vertical);

            ChartAxisLayout layout1 = new ChartAxisLayout();
            ChartAxisLayout layout2 = new ChartAxisLayout();
            chartControl1.Axes.Add(axis0);
            chartControl1.Axes.Add(axis1);
            chartControl1.Axes.Add(axis2);
            chartControl1.Axes.Add(axis3);
            chartControl1.Axes.Add(axis4);

            layout1.Spacing = 12;
            layout2.Spacing = 12;
            layout2.Axes.Add(axis);
            layout2.Axes.Add(axis0);
            layout2.Axes.Add(axis1);
            layout1.Axes.Add(axis2);
            layout1.Axes.Add(axis3);
            layout1.Axes.Add(axis4);
            chartControl1.ChartArea.YLayouts.Add(layout1);
            chartControl1.ChartArea.YLayouts.Add(layout2);

            ChartSeries population = new ChartSeries("Population", ChartSeriesType.Column);
            population.Points.Add(0, 1.3);
            population.Points.Add(1, 1);
            population.Points.Add(2, 0.5);
            population.Points.Add(3, 0.3);           

            ChartSeries Growth = new ChartSeries("Growth[%]", ChartSeriesType.Column);
            Growth.Points.Add(0, 0.7);
            Growth.Points.Add(1, 1.6);
            Growth.Points.Add(2, 0.7);
            Growth.Points.Add(3, 0.4);            

            ChartSeries Birthrate = new ChartSeries("BirthRate", ChartSeriesType.Column);
            Birthrate.Points.Add(0, 15);
            Birthrate.Points.Add(1, 27);
            Birthrate.Points.Add(2, 17);
            Birthrate.Points.Add(3, 24);            

            population.YAxis = axis;
            Growth.YAxis = axis0;
            Birthrate.YAxis = axis1;
            axis.Title = "Population (Million)";
            axis0.Title = "Growth[%]";
            axis1.Title = "Birthrate";          

            ChartSeries GDP = new ChartSeries("GDP pc in 1000 ", ChartSeriesType.Line);
            GDP.Points.Add(0, 10);
            GDP.Points.Add(1, 5);
            GDP.Points.Add(2, 85);
            GDP.Points.Add(3, 5);
            GDP.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(200, 234, 90, 81));
            GDP.Style.Border.Width = 2;

            ChartSeries Lifeexpect = new ChartSeries("Life Expect ", ChartSeriesType.Spline);
            Lifeexpect.Points.Add(0, 70);
            Lifeexpect.Points.Add(1, 65);
            Lifeexpect.Points.Add(2, 85);
            Lifeexpect.Points.Add(3, 65);
            Lifeexpect.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(200,36,119,51));
            Lifeexpect.Style.Border.Width = 2;

            ChartSeries Literacy = new ChartSeries("Literacy[%]", ChartSeriesType.SplineArea);
            Literacy.Points.Add(0, 85);
            Literacy.Points.Add(1, 55);
            Literacy.Points.Add(2, 35);
            Literacy.Points.Add(3, 95);
            Literacy.Style.Border.Color = Color.Transparent;
            Literacy.Style.Interior = new Syncfusion.Drawing.BrushInfo(Color.FromArgb(200, 253, 171, 0));

            this.chartControl1.LegendsPlacement = ChartPlacement.Outside;
            this.chartControl1.LegendPosition = ChartDock.Top;
            this.chartControl1.LegendAlignment = ChartAlignment.Center;
            this.chartControl1.Title.Visible = false;

            ChartAxis Xaxis = new ChartAxis();
            Xaxis.Orientation = ChartOrientation.Horizontal;
            Xaxis.OpposedPosition = true;
            Xaxis.Range = new MinMaxInfo(-1, 4, 1);
            Xaxis.DrawGrid = false;
            Xaxis.LineType.Width = 1.75F;
            Xaxis.LineType.ForeColor = Color.LightGray;
            this.chartControl1.Axes.Add(Xaxis);

            GDP.YAxis = axis2;
            GDP.XAxis = Xaxis;
            Lifeexpect.YAxis = axis3;
            Lifeexpect.XAxis = Xaxis;
            Literacy.YAxis = axis4;
            Literacy.XAxis = Xaxis;
            axis2.Title = "GDP pc in 1000";
            axis3.Title = "Lifeexpect";
            axis4.Title = "Literacy";

            this.chartControl1.Series.Add(population);
            this.chartControl1.Series.Add(Growth);
            this.chartControl1.Series.Add(Birthrate);
            this.chartControl1.Series.Add(GDP);
            this.chartControl1.Series.Add(Lifeexpect);
            this.chartControl1.Series.Add(Literacy);

            axis1.OpposedPosition = true;
            axis1.DrawGrid = false;
            axis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis0.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis1.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis2.OpposedPosition = true;
            axis0.DrawGrid = true;
            axis.DrawGrid = false;
            axis2.DrawGrid = false;
            axis2.DrawGrid = true;
            axis3.DrawGrid = false;
            axis4.DrawGrid = false;
            axis2.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis3.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;
            axis4.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;

            //"population"
            axis.LineType.ForeColor = Color.Blue;
            axis.ForeColor = Color.Blue;
            axis.TitleColor = Color.Blue;
            axis.LineType.Width = 1.75F;

            //"Growth"
            axis0.LineType.ForeColor = Color.DarkGreen;
            axis0.ForeColor = Color.DarkGreen;
            axis0.TitleColor = Color.DarkGreen;
            axis0.LineType.Width = 1.75F;

            //"Birthrate"
            axis1.LineType.ForeColor = Color.Red;
            axis1.LineType.Width = 1.75F;
            axis1.ForeColor = Color.Red;
            axis1.TitleColor = Color.Red;

            //"GDP pc in 1000";
            axis2.LineType.ForeColor = Color.Salmon;
            axis2.ForeColor = Color.Salmon;
            axis2.TitleColor = Color.Salmon;
            axis2.LineType.Width = 1.75F;

            //"Lifeexpect";
            axis3.LineType.ForeColor = Color.Green;
            axis3.ForeColor = Color.Green;
            axis3.TitleColor = Color.Green;
            axis3.LineType.Width = 1.75F;

            //"Literacy";
            axis4.LineType.ForeColor = Color.Orange;
            axis4.ForeColor = Color.Orange;
            axis4.TitleColor = Color.Orange;
            axis4.LineType.Width = 1.75F;

        }
        #endregion

        #region Forn_Load

        private void Form1_Load(object sender, EventArgs e)
        {
            ChartControlData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

    }
}