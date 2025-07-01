using System;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartStatisticalFormulas
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {  
                Color.FromArgb(200, 253,171,0),
                Color.FromArgb(200,36,119,51),
                Color.FromArgb(200, 199,23,33)
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
            chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray;
            chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray;           
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);                     
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);         
          
            chart.LegendPosition = ChartDock.Top;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            for (int i = 0; i <chart.Series.Count; i++)
            {
                chart.Series[i].Style.Border.Color = Color.Gray;
            }
            #endregion
        }
    }
}
