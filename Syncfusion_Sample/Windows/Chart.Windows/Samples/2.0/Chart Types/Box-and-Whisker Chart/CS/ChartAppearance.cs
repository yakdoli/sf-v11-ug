using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace BoxAndWhisker_2005
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Series[0].Style.Border.Color = Color.FromArgb(82, 104, 33);
            Color[] color1 = new Color[] { Color.FromArgb(177, 183, 170), Color.FromArgb(229, 236, 220), Color.FromArgb(207, 213, 199), Color.FromArgb(177, 183, 170) };
            chart.Series[0].Style.Interior = new Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color1);

            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(189))))));
            chart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            chart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            chart.BorderAppearance.SkinStyle = ChartBorderSkinStyle.Emboss;

            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);


            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;

            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Font = new Font("Verdana", 7.0f, FontStyle.Regular);
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
