using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ErrorBarsChart_2005
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.PathRectangle, new Color[] { Color.FromArgb(214, 231, 247), Color.White });
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.SkyBlue;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);

            chart.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            chart.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;
            chart.Text = "Life time for Home Appliances with Error Values";
            chart.PrimaryXAxis.Title = "Product Name";
            chart.PrimaryYAxis.Title = "Life Time(Year)";
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 20, 5);
            chart.PrimaryYAxis.DrawGrid = false;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.TitleSpacing = 6;

            chart.Series[0].Style.Interior = new BrushInfo(GradientStyle.Horizontal, new Color[] { Color.FromArgb(0, 128, 192), Color.FromArgb(98, 203, 255), Color.FromArgb(0, 128, 192) });
            chart.Series[0].Style.Border.Width = 2.0f;
            chart.Series[0].Style.Border.Color = Color.FromArgb(0, 128, 192);
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Font = new Font("Verdana", 7.0f, FontStyle.Regular);
            chart.PrimaryXAxis.Range.Min = 0;
            chart.PrimaryYAxis.Range.Min = 0;

            #endregion

            #region Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;
            chart.LegendPosition = ChartDock.Top;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Legend.RepresentationType = ChartLegendRepresentationType.StraightLine;
            chart.Legend.Items[0].RepresentationSize = new Size(25, 25);
            #endregion
        }


    }
}
