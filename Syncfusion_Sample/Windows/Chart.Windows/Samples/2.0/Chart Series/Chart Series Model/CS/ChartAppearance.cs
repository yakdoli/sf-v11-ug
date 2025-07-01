using System;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartSeriesModel
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
            chart.PrimaryXAxis.InterlacedGrid = true;
            chart.PrimaryXAxis.InterlacedGridInterior = new BrushInfo(GradientStyle.Horizontal, Color.FromArgb(215, 228, 189), Color.White);
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27);
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27);
            chart.PrimaryXAxis.LineType.Width = 2;
            chart.PrimaryYAxis.LineType.Width = 2;
            chart.PrimaryXAxis.TickColor = Color.White;
            chart.PrimaryYAxis.TickColor = Color.White;
            chart.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.Legend.Visible = false;
            chart.ShowToolTips = true;
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.StyleDialogOptions.ShowBorderTab = true;
            chart.StyleDialogOptions.ShowTextTab = false;
            chart.StyleDialogOptions.ShowFancyToolTipsTab = false;
            chart.StyleDialogOptions.ShowInteriorTab = false;
            chart.StyleDialogOptions.ShowShadowTab = false;
            chart.StyleDialogOptions.ShowSymbolTab = false;
            chart.ShowLegend = false;
            #endregion
        }
    }
}
