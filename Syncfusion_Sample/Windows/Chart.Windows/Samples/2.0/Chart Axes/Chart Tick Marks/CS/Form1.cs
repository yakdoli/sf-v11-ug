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
using System.Reflection;
using System.IO;

namespace TickMarksDemo_2005
{
    public partial class Form1 : Office2007Form
    {
        #region Form's Constructor

        public Form1()
        {
            InitializeComponent();
            InitializeChartData();
            InitializeControlSettings();
            this.richTextBox1.Rtf = @"{\rtf1\ansi\ansicpg1253\deff0\deflang1032{\fonttbl{\f0\fswiss\fprq2\fcharset0 Arial;}{\f1\fswiss\fprq2\fcharset161{\*\fname Arial;}Arial Greek;}{\f2\fswiss\fcharset0 Arial;}}
{\colortbl ;\red0\green0\blue128;}
{\*\generator Msftedit 5.41.15.1507;}\viewkind4\uc1\pard\cf1\lang1033\b\f0\fs17 TickMarksDemo\b0  \lang1032\f1 sample illustrates various customization options of TickMarks in Essential Chart. Along with the illustrated properties, the number of \lang1033\f0 T\lang1032\f1 ick\lang1033\f0 M\lang1032\f1 arks that should appear on chart zooming could also be specified using the axis \b\i\fs16 TickDrawingOperationMode\b0\i0\fs17  property.\cf0\lang1033\f2\fs20\par
}";
        }
        #endregion

        #region Helper Methods
        #region InitializeChartData

        private void InitializeChartData()
        {
            ChartSeries series = new ChartSeries();
            series.Name = "Series 1";
            series.Points.Add(175, 7);
            series.Points.Add(200, 6);
            series.Points.Add(225, 5);
            series.Points.Add(250, 4);
            series.Points.Add(275, 3);
            series.Points.Add(300, 2);
            series.Points.Add(325, 1);
            series.Type = ChartSeriesType.Bar;
            series.Text = series.Name;
            this.chartControl1.Series.Add(series);
            
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.Range = new MinMaxInfo(-1, 8, 1);            
            this.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(150, 350, 50);

        }
        #endregion

        #region InitializeControlSettings

   
        private void InitializeControlSettings()
        {
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.ChartArea.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(6)))), ((int)(((byte)(22))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(102))))));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(184, 25, 0);
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(184, 25, 0);
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(184, 25, 0);
            this.chartControl1.PrimaryYAxis.DrawGrid = false;
            this.chartControl1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.chartControl1.Series[0].Style.Interior = new BrushInfo(Color.White);
            this.chartControl1.Series[0].Style.Border.Color = Color.FromArgb(196, 196, 196);           
             
            ChartStripLine thermoStripLine = new ChartStripLine();
            thermoStripLine.Enabled = true;
            thermoStripLine.Vertical = true;                 
            thermoStripLine.StartAtAxisPosition = true;
            thermoStripLine.Start = 0;          
            thermoStripLine.Text = "Transmission Oil Temperature ";
            Assembly asem = this.GetType().Assembly;
            Stream str = asem.GetManifestResourceStream("TickMarksDemo_2005.Thermometer.png");
            Image img = Image.FromStream(str);
            thermoStripLine.BackImage = img;
            thermoStripLine.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            thermoStripLine.Period = 9;
            thermoStripLine.Width =.5;          
            this.chartControl1.PrimaryXAxis.StripLines.Add(thermoStripLine);

            this.chartControl1.Series[0].Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            this.chartControl1.Series[0].Style.ImageIndex = 0;
            this.chartControl1.Series[0].Style.Symbol.Shape = ChartSymbolShape.Image;
            this.chartControl1.Series[0].Style.Symbol.ImageIndex = 0;
            this.chartControl1.Series[0].Style.Symbol.Size = new Size(34, 34);
            this.chartControl1.Series[0].Style.Symbol.Offset = new Size(3, 0);
            this.chartControl1.Series[0].Style.Symbol.Color = Color.FromArgb(112, 110, 142);
            this.chartControl1.ShowLegend = false;
           
            ChartCustomPoint cp1 = new ChartCustomPoint();
            cp1.Text = "LOW HEAT : LONG MILEAGE";
            cp1.CustomType = ChartCustomPointType.ChartCoordinates;
            cp1.Font.Facename = "Verdana";
            cp1.Font.FontStyle = FontStyle.Bold;
            cp1.Font.Size = 7;
            cp1.XValue = 158;
            cp1.YValue = 4;
            this.chartControl1.CustomPoints.Add(cp1);

            ChartCustomPoint cp2 = new ChartCustomPoint();
            cp2.Text = "HIGH HEAT : SHORT MILEAGE";
            cp2.Font.Facename = "Verdana";
            cp2.Font.FontStyle = FontStyle.Bold;
            cp2.Font.Size = 7;
            cp2.CustomType = ChartCustomPointType.ChartCoordinates;
            cp2.XValue = 335;
            cp2.YValue = 4;
            this.chartControl1.CustomPoints.Add(cp2);

            this.chartControl1.Refresh();
        }
        #endregion
        #endregion

        #region Events
        #region ChartFormatAxisLabel
        string[] labels = new string[] { "",  "800 ml", "5000 ml", "10,000 ml", "20,000 ml", "50,000 ml", "100,000 ml", "", ""};
         private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Vertical)
            {
                //Applying Formatted Y Axis label values.
                e.Label = string.Format("{0}'F", e.Value);
            }
            else
            {
                if ((int)e.Value >= 0 && (int)e.Value < 8)
                {
                    e.Label = labels[(int)e.Value];
                }
            }
            e.Handled = true;
        }
        #endregion

        #region X Axis Ticks
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.DrawTickLabelGrid = cbXAxisDrawLabelGrid.Checked;
            this.nUDXAxisTickGridPadding.Enabled = cbXAxisDrawLabelGrid.Checked;

        }

        private void cpXAxisTickColor_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.TickColor = cpXAxisTickColor.SelectedColor;
        }

        private void nUDXAxisTicksPerInterval_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.SmallTicksPerInterval = (int)nUDXAxisTicksPerInterval.Value;
        }

        private void nUDXAxisTickGridPadding_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.TickLabelGridPadding = (int)nUDXAxisTickGridPadding.Value;
        }

        private void nUDXAxisTickSize_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.TickSize = new Size((int)nUDXAxisTickWidth.Value, (int)nUDXAxisTickHeight.Value);

            
        }

       

        private void nUDXAxisSmallTickSize_ValueChanged(object sender, EventArgs e)
        {

            this.chartControl1.PrimaryXAxis.SmallTickSize = new Size((int)nUDXAxisSmallTickWidth.Value, (int)nUDXAxisSmallTickHeight.Value);
        }
#endregion

        #region Y Axis Ticks
        private void cbYAxisDrawLabelGrid_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.DrawTickLabelGrid = cbYAxisDrawLabelGrid.Checked;
            this.nUDYAxisTickGridPadding.Enabled = cbYAxisDrawLabelGrid.Checked;

        }

        private void cpYAxisTickColor_ColorSelected(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.TickColor = cpYAxisTickColor.SelectedColor;
        }

        private void nUDYAxisTickSize_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.TickSize = new Size((int)nUDYAxisTickWidth.Value, (int)nUDYAxisTickHeight.Value);
        }
        private void nUDYAxisSmallTickSize_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.SmallTickSize = new Size((int)nUDYAxisSmallTickWidth.Value, (int)nUDYAxisSmallTickHeight.Value);
        }

        private void nUDYAxisTicksPerInterval_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.SmallTicksPerInterval = (int)nUDYAxisTicksPerInterval.Value;
        }

        private void nUDYAxisTickGridPadding_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.TickLabelGridPadding = (int)nUDYAxisTickGridPadding.Value;
        }

       

        #endregion

        #endregion
        
    }
}
