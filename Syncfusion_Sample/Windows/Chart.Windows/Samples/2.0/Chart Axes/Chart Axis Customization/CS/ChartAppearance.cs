using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartAxisCustomization_2005
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {   
                Color.FromArgb(200,36,119,51),
                Color.FromArgb(200, 253,171,0),
                Color.FromArgb(200, 199,23,33) 
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
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(0, 4, 1);
            chart.PrimaryXAxis.MinorGridLineType.ForeColor = Color.DarkGray;
            chart.PrimaryYAxis.MinorGridLineType.ForeColor = Color.DarkGray;
            chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray;
            chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray;
            chart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            chart.ShowLegend = false;
            chart.PrimaryYAxis.DrawMinorGrid = true;
            chart.PrimaryXAxis.SmallTicksPerInterval = 4;
            chart.PrimaryYAxis.SmallTicksPerInterval = 4;

            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[1].Style.Border.Color = Color.Transparent;
            chart.Series[2].Style.Border.Color = Color.Transparent;

            #endregion
        }
    }
}
