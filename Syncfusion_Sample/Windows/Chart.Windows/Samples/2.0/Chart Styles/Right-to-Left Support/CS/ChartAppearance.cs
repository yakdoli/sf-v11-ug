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

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {   
                Color.FromArgb(175,36,119,51),
                Color.FromArgb(175, 253,171,0)               
            };

            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.PathRectangle, System.Drawing.Color.White, Color.FromArgb(255, 224, 192));
            chart.ChartInterior = new BrushInfo(GradientStyle.PathRectangle, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.PathRectangle, System.Drawing.Color.White, Color.FromArgb(255, 224, 192));
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;
            #endregion

            #region Axes and Legend Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryXAxis.LineType.ForeColor = Color.Gray;
            chart.PrimaryYAxis.LineType.ForeColor = Color.Gray;
            chart.PrimaryYAxis.LineType.Width = 2;
            chart.PrimaryXAxis.LineType.Width = 2;

            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;           
            chart.PrimaryYAxis.DrawGrid = false;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(6, 20, 2);
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(0, 400, 50);
            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[1].Style.Border.Color = Color.Transparent;         
            chart.ShowLegend = false;
            #endregion
        }
    }
}
