using System;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ClickPointDemo2
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            { 
                Color.FromArgb(200, 129,115,27)          
            };

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White);
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.DarkOliveGreen;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.HidePartialLabels = true;
            chart.PrimaryYAxis.HidePartialLabels = true;
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27);
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27);
            chart.PrimaryXAxis.LineType.Width = 2;
            chart.PrimaryYAxis.LineType.Width = 2;
            chart.PrimaryXAxis.Title = "Time";
            chart.PrimaryYAxis.Title = "Stock Price";
            chart.PrimaryYAxis.Format = "#$";
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.Legend.Visible = false;         
            chart.ShowToolTips = true;
            chart.Series[0].Style.Symbol.Border.Color = Color.FromArgb(200, 129, 115, 27);
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Text = "Stock Price with Custom Trend Line";

            #endregion
        }
    }
}
