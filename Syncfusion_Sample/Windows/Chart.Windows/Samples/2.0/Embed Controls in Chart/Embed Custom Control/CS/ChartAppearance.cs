using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            Color[] color = new Color[] { Color.FromArgb(253, 225, 21), Color.FromArgb(243, 177, 13), Color.FromArgb(253, 225, 21) };
            Color[] color2 = new Color[] { Color.FromArgb(237, 148, 8), Color.FromArgb(231, 119, 3), Color.FromArgb(237, 148, 8) };
            Color[] color3 = new Color[] { Color.FromArgb(252, 0, 0), Color.FromArgb(130, 0, 0), Color.FromArgb(252, 0, 0) };
            chart.Series[0].Style.Interior = new BrushInfo(GradientStyle.Horizontal, color);
            chart.Series[0].Style.Border.Color = Color.FromArgb(247, 194, 16);
            chart.Series[1].Style.Interior = new BrushInfo(GradientStyle.Horizontal, color3);
            chart.Series[1].Style.Border.Color = Color.FromArgb(200, 70, 44);
            chart.Series[2].Style.Interior = new BrushInfo(GradientStyle.Horizontal, color2);
            chart.Series[2].Style.Border.Color = Color.Orange;

            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.PathRectangle, new Color[] { Color.FromArgb(214, 231, 247), Color.White });
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.SkyBlue;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Regular);
            chart.Font = new Font("Verdana", 7.0f, FontStyle.Regular);
            chart.LegendPosition = ChartDock.Top;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Legend.BackColor = Color.Transparent;
            chart.Legend.Border.ForeColor = Color.Transparent;
            chart.Depth = 100;
            chart.Tilt = 15;
            chart.Series3D = true;
            chart.Rotation = 15;
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(0, 13, 1);
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 100, 20);
            chart.Spacing = 0;
            #endregion
        }
    }
}
