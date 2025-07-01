using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartTemplate_2005
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {              
                Color.FromArgb(200, 188,200,6),
                Color.FromArgb(200, 234,90,81)
            };

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(Color.FromArgb(255, 224, 192));
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;           
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.Font = new Font("Vernada", 8f, FontStyle.Regular);
            chart.PrimaryYAxis.Font = new Font("Vernada", 8f, FontStyle.Regular);
            chart.Legend.Font = new Font("Vernada", 8f, FontStyle.Regular);
            chart.Text = "Hardware sales per month";
            chart.PrimaryXAxis.Title = "Month";
            chart.PrimaryYAxis.Title = "Sales";
            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[1].Style.Border.Color = Color.Transparent;
           
            #endregion

            #region Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;
            chart.LegendPosition = ChartDock.Top;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;

            #endregion
        }
    }
}
