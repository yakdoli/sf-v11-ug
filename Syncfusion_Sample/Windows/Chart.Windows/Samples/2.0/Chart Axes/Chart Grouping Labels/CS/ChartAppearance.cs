using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace GridLabelsChartSample_2002
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
            chart.PrimaryXAxis.MinorGridLineType.ForeColor = Color.DarkGray;
            chart.PrimaryYAxis.MinorGridLineType.ForeColor = Color.DarkGray;
            chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray;
            chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray;
            chart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
           
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.Legend.Position = ChartDock.Top;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Series[0].Style.Symbol.Color = Color.FromArgb(200, 9, 116, 210);
            chart.Series[1].Style.Symbol.Color = Color.FromArgb(200, 253, 171, 0);
            chart.Series[2].Style.Symbol.Color = Color.FromArgb(200, 199, 23, 33);
            chart.Series[0].Style.Symbol.Shape = ChartSymbolShape.Star;
            chart.Series[1].Style.Symbol.Shape = ChartSymbolShape.InvertedTriangle;
            chart.Series[2].Style.Symbol.Shape = ChartSymbolShape.Diamond;

            chart.Legend.RepresentationType = ChartLegendRepresentationType.InvertedTriangle;
            chart.Text = "Speed-Torque Variation";
            chart.PrimaryXAxis.Title = "Speed (rpm)";
            chart.PrimaryYAxis.Title = "Torque(Nm)";
            chart.Series[0].Style.Symbol.Border.Color = Color.FromArgb(200, 9, 116, 210);
            chart.Series[1].Style.Symbol.Border.Color = Color.FromArgb(200, 253, 171, 0);
            chart.Series[2].Style.Symbol.Border.Color = Color.FromArgb(200, 199, 23, 33);
            chart.Series[0].Style.Symbol.Size = new Size(10, 10);
            chart.Series[1].Style.Symbol.Size = new Size(10, 10);
            chart.Series[2].Style.Symbol.Size = new Size(10, 10);

            #endregion
        }
    }
}
