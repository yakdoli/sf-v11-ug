using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace Pareto
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            chart.ShowLegend = false;
            chart.BackInterior = new BrushInfo(GradientStyle.ForwardDiagonal,
                Color.FromArgb(215, 228, 189), Color.White);
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, 
                Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical,
                Color.Transparent, Color.Transparent);

            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.DarkOliveGreen;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);

            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent;
            chart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Silver;

            chart.PrimaryXAxis.TickSize = new System.Drawing.Size(1, 5);
            chart.PrimaryYAxis.TickSize = new System.Drawing.Size(5, 1);
        }
    }
}
