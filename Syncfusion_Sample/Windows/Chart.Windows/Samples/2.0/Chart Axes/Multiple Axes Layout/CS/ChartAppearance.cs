using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace MultipleAxesLayout
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {              
                Color.FromArgb(200, 9,116,210),             
                Color.FromArgb(200,36,119,51),
                Color.FromArgb(200, 199,23,33)                
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
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization
            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[1].Style.Border.Color = Color.Transparent;
            chart.Series[2].Style.Border.Color = Color.Transparent;     
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.DarkGray;
            chart.PrimaryXAxis.LineType.ForeColor = Color.LightGray;
            chart.PrimaryXAxis.LineType.Width = 2F;            
            chart.PrimaryYAxis.GridLineType.Width = 1F;
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(2, 59, 95);
            chart.PrimaryYAxis.LineType.Width = 2F;
            chart.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            chart.PrimaryXAxis.DrawGrid = false;
            #endregion
        }
    }
}
