using System;
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
                Color.FromArgb(41,158,214),
                Color.FromArgb(206,215,41),
                Color.FromArgb(250,206,35),
                Color.FromArgb(155,166,184),
                Color.FromArgb(255,186,0),
                Color.FromArgb(191,192,98),
                Color.FromArgb(247,125,16),
                Color.FromArgb(199,23,33)
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
            chart.ElementsSpacing = 0;
            chart.Series[0].ConfigItems.PieItem.FillMode = ChartPieFillMode.AllPie;
            chart.Series[0].Style.Border.Color = Color.DarkGray;
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Font = new Font("Verdana", 8.0f, FontStyle.Regular);            
            chart.Text = "Project Cost Breakdown";

            #endregion
        }
    }
}
