using System;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartTitle
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {                
                Color.FromArgb(200,246,100,15),
                Color.FromArgb(200, 188,200,6),
                Color.FromArgb(200, 234,90,81)     
            };

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.PathRectangle, new Color[] { Color.FromArgb(214, 231, 247), Color.White });
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.SkyBlue;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;           
            chart.ElementsSpacing = 5;
            #endregion

            #region Axes and Legend Customization

            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);        
            chart.Series[0].Style.Border.Width = 3;
            chart.Series[1].Style.Border.Width = 3;
            chart.Series[0].Style.Symbol.Border.Color = Color.FromArgb(200, 129, 115, 27);
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);

            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Legend.BackInterior = new BrushInfo(Color.Transparent);
            chart.Legend.ShowBorder = false;
            chart.Legend.Border.ForeColor = Color.FromArgb(8, 78, 148);
            chart.Legend.Border.Width = 2;
            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesImage;

            foreach (ChartLegendItem cli in chart.Legends[0].Items)
            {
                cli.RepresentationSize = new Size(16, 16);
                cli.TextColor = Color.MidnightBlue;
                cli.Font = new Font("Verdana", 7.0f, FontStyle.Bold);
            }

            #endregion
        }
    }
}
