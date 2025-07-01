using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartSeriesSample
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {   
                Color.FromArgb(175,36,119,51),
                Color.FromArgb(175, 253,171,0),
                Color.FromArgb(175, 199,23,33) 
            };

            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.ChartInterior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.Range.Min = 0;
            chart.PrimaryXAxis.Range.Min = 1998;
            chart.PrimaryXAxis.Range.Max = 2009;
            chart.PrimaryXAxis.Range.Interval = 1;
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 270;
            chart.PrimaryYAxis.Format = "$#";
            chart.Text = "Category wise Sales for the Year 1999-2008";
            chart.PrimaryXAxis.Title = "Year";
            chart.PrimaryYAxis.Title = "Sales (Millions)";
            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[1].Style.Border.Color = Color.Transparent;
            chart.Titles[0].Font = new Font("Vernada", 10, FontStyle.Bold);
            chart.Legend.Font = new Font("Vernada", 8, FontStyle.Regular);

            #endregion

            #region Legend Customization
            chart.Legend.BackColor = Color.Transparent;
            chart.Legend.Border.ForeColor = Color.DarkGray;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendPosition = ChartDock.Top;
            chart.LegendAlignment = ChartAlignment.Center;

            #endregion
        }
    }
}
