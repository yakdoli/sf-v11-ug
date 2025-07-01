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

namespace ChartPoints_2005
{
    public partial class Form1 : Office2007Form
    {
        #region Form Load
        public Form1()
        {
            InitializeComponent();
            InitializeChartData();
            InitializeControlSettings();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region  InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries Wheat = new ChartSeries("Wheat", ChartSeriesType.Line);
            Wheat.Points.Add(1997, 250 );
            Wheat.Points.Add(1998, 235);
            Wheat.Points.Add(1999, 290);
            Wheat.Points.Add(2000, 400);
            Wheat.Points.Add(2001, 480);
            Wheat.Points.Add(2002, 490);
            Wheat.Points.Add(2003, 480);
            Wheat.Points.Add(2004, 500);
            Wheat.Points.Add(2005, 590);
            Wheat.Points.Add(2006, 660);
            Wheat.Points.Add(2007, 600);
            this.chartControl1.Series.Add(Wheat);
            Wheat.Style.Border.Width = 3;
            Wheat.Style.Symbol.Shape = ChartSymbolShape.Circle;
            Wheat.Style.Symbol.Color = Color.White;
            Wheat.Style.Symbol.Border.Color =  Color.FromArgb(200, 253,171,0);
            Wheat.Style.Symbol.Border.Width = 3;
            Wheat.Style.Symbol.Size = new Size(8, 8);
            Wheat.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            Wheat.Style.ImageIndex = 0;
            Wheat.Style.Symbol.Shape = ChartSymbolShape.Image;
            Wheat.Style.Symbol.ImageIndex = 1;

            ChartSeries Corn = new ChartSeries("Corn", ChartSeriesType.Line);
            Corn.Points.Add(1997, 170);
            Corn.Points.Add(1998, 190);
            Corn.Points.Add(1999, 200);
            Corn.Points.Add(2000, 260);
            Corn.Points.Add(2001, 300);
            Corn.Points.Add(2002, 370);
            Corn.Points.Add(2003, 400);
            Corn.Points.Add(2004, 434);
            Corn.Points.Add(2005, 566);
            Corn.Points.Add(2006, 587);
            Corn.Points.Add(2007, 690);
            this.chartControl1.Series.Add(Corn);
            Corn.Style.Border.Width = 3;
            Corn.Style.Symbol.Shape = ChartSymbolShape.Square;
            Corn.Style.Symbol.Color = Color.White;
            Corn.Style.Symbol.Border.Color = Color.FromArgb(200, 188, 200, 6);
            Corn.Style.Symbol.Border.Width = 2;
            Corn.Style.Symbol.Size = new Size(8, 8);

            ChartSeries Rice = new ChartSeries("Rice", ChartSeriesType.Line);
            Rice.Points.Add(1997, 120);
            Rice.Points.Add(1998, 180);
            Rice.Points.Add(1999, 160);
            Rice.Points.Add(2000, 210);
            Rice.Points.Add(2001, 200);
            Rice.Points.Add(2002, 280);
            Rice.Points.Add(2003, 300);
            Rice.Points.Add(2004, 335);
            Rice.Points.Add(2005, 367);
            Rice.Points.Add(2006, 380);
            Rice.Points.Add(2007, 400);
            this.chartControl1.Series.Add(Rice);
            Rice.Style.Border.Width = 3;
            Rice.Style.Symbol.Shape = ChartSymbolShape.Diamond;
            Rice.Style.Symbol.Color = Color.White;
            Rice.Style.Symbol.Border.Color = Color.MediumVioletRed;
            Rice.Style.Symbol.Border.Width = 2;
            Rice.Style.Symbol.Size = new Size(10, 10);

        }
        #endregion

        #region InitializeControlSettings
        protected void InitializeControlSettings()
        {
            foreach (string symbol in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
                this.cmbSymbolStyle.Items.Add(symbol);

            this.cmbSymbolStyle.SelectedIndex = 3;
        }
        #endregion

        #region Events
        private void cmbSymbolStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSymbol();
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            SetSymbol();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SetSymbol();
        }

        #region Set Symbols

        protected void SetSymbol()
        {
            // Symbol to points
            if (radioButton1.Checked)
                this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);
            else
                this.chartControl1.Series[0].PrepareStyle -= new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);

            // Symbol to series
            if (this.radioButton2.Checked)
            {
                this.chartControl1.Series[0].Style.Symbol.Color = colorPickerButton1.SelectedColor;
                this.textBox1.BackColor = colorPickerButton1.SelectedColor;

                this.chartControl1.Series[0].Style.Symbol.Size = new Size((int)this.numericUpDown1.Value, (int)this.numericUpDown1.Value);
                this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.cmbSymbolStyle.SelectedItem.ToString(), true);
                if (this.chartControl1.Series[0].Style.Symbol.Shape == ChartSymbolShape.Image)
                {
                    this.chartControl1.Series[0].Style.Symbol.Size = new Size(25, 25);
                    this.numericUpDown1.Value = 25;
                }
            }
            this.chartControl1.Legend.Items[0].TextColor = Color.White;
            this.chartControl1.Refresh();
        }
        #endregion

        #region Symbols to Points
        protected void ChartControlSeries_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            Random rand = new Random();

            if (args.Index == 4)
            {
                args.Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.cmbSymbolStyle.SelectedItem.ToString(), true);
                args.Style.Symbol.Size = new Size((int)this.numericUpDown1.Value, (int)this.numericUpDown1.Value);
                args.Style.Symbol.Color = colorPickerButton1.SelectedColor;
            }
        }
        #endregion
        #endregion
    }
}