using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartDragDrop
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {           
                Color.FromArgb(175, 199,23,33) 
            };

            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.ChartInterior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);

            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 100, 25);
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(0, 7, 1);

            chart.Series[0].Style.Symbol.Shape = ChartSymbolShape.Circle;
            chart.Series[0].Style.Symbol.Color = Color.White;
            chart.Series[0].Style.Symbol.Size = new Size(8, 8);
            chart.Series[0].Style.DisplayText = true;
            chart.Series[0].Style.TextColor = Color.Black;
            chart.Series[0].Style.TextFormat = "{0}";
            chart.Series[0].Style.TextOrientation = ChartTextOrientation.Up;
            chart.Series[0].Style.Symbol.Color = Color.FromArgb(175, 199, 23, 33);
            chart.Series[0].Style.Symbol.Border.Color = Color.Transparent;
            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[0].Style.Border.Width = 2;
            chart.Text = "Daily Performance ";
            chart.PrimaryYAxis.Title = "Task finished(%)";
            chart.PrimaryXAxis.Title = "Daily Review";

            #endregion

            #region Legend Customization

            chart.ShowLegend = false;

            #endregion
        }
    }
}
