using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;

namespace ChartSmartLabel_2005
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Private Member
        private int _Id = 1;
        #endregion

        #region FormLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            this.InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region Helper Methods
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries("Compound AA", ChartSeriesType.Scatter);
            series1.Style.Symbol.Color = Color.DarkOrchid;
            series1.Style.Symbol.Shape = ChartSymbolShape.Square;
            series1.Style.TextOffset = 15;
            series1.SmartLabelsBorderColor = Color.DarkOrchid;
            series1.SmartLabelsBorderWidth = 1;
            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);

            ChartSeries series4 = new ChartSeries("Compound BB", ChartSeriesType.Scatter);
            series4.Style.Symbol.Color = Color.Red;
            series4.Style.TextOffset = -30;
            series4.Style.Symbol.Shape = ChartSymbolShape.Star;
            series4.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);

            series4.SmartLabelsBorderColor = Color.Red;
            series4.SmartLabelsBorderWidth = 1;

            ChartSeries series5 = new ChartSeries("Compound CC", ChartSeriesType.Scatter);
            series5.Style.Symbol.Color = Color.Magenta;
            series5.Style.Symbol.Shape = ChartSymbolShape.Triangle;
            series5.Style.TextOffset = 15;
            series5.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            series5.SmartLabelsBorderColor = Color.Magenta;
            series5.SmartLabelsBorderWidth = 1;

            ChartSeries series6 = new ChartSeries("Compound DD", ChartSeriesType.Scatter);
            series6.Style.Symbol.Color = Color.Yellow;
            series6.Style.Symbol.Shape = ChartSymbolShape.Hexagon;
            series6.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            series6.SmartLabelsBorderColor = Color.Transparent;
            series6.SmartLabelsBorderWidth = 1;

            series1.Points.Add(34.5745413, 20.3282866);
            series1.Points.Add(31.1144818, 14.2510141);
            series1.Points.Add(36.7960707, 20.6485916);
            series1.Points.Add(39.3946526, 29.6503113);
            series1.Points.Add(36.9149847, 12.036468);

            series4.Points.Add(33.6240289, 10.4293169);
            series4.Points.Add(25.959018, 15.0305531);
            series4.Points.Add(26.1158617, 22.2780683);
            series4.Points.Add(24.5590223, 11.1255066);
            series4.Points.Add(39.9605541, 17.2306935);
            series4.Points.Add(38.220167, 10.7499491);

            series5.Points.Add(49.9140424, 12.8742868);
            series5.Points.Add(53.8453009, 18.630743);
            series5.Points.Add(53.2494757, 04.3310421);
            series5.Points.Add(50.8416839, 01.9014331);

            series6.Points.Add(58.1815097, 18.1211902);
            series6.Points.Add(47.6000954, 20.3468524);
            series6.Points.Add(50.8396695, 18.8712833);
            series6.Points.Add(47.3161036, 01.6289029);
            series6.Points.Add(41.3283884, 10.5059598);

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series4);
            this.chartControl1.Series.Add(series5);
            this.chartControl1.Series.Add(series6);

            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                this.chartControl1.Series[i].SmartLabels = true;
                this.chartControl1.Legend.ShowSymbol = true;
            }
        }

        void series_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            args.Style.DisplayText = true;
            args.Style.TextOrientation = ChartTextOrientation.Smart;
            args.Style.Text = "T" + this._Id.ToString();
            this._Id++;
            series.Style.Font.Facename = "Arial";
            series.Style.Font.Size = 7;
        }
        #endregion
    }
}