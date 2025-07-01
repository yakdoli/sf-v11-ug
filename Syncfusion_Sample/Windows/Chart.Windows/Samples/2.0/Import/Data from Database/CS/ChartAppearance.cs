using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartImportData
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {              
                Color.FromArgb(200, 41,158,214),
                Color.FromArgb(200,206,215,41),
                Color.FromArgb(200,255,186,0),
                Color.FromArgb(200, 247,125,16) 
            };
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

            #endregion

            #region Axes Customization

            chart.Series[0].Style.Border.Color = Color.Gray;          
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryYAxis.Range.Min = 0;
            chart.Titles[0].Font = new Font("Vernada", 12, FontStyle.Bold);
           
            #endregion
        }
    }
}
