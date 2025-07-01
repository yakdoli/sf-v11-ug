using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartExportData
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
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryYAxis.Range.Min = 0;

            chart.Text = "Product Orders by Age Group";
            chart.PrimaryXAxis.Title = "Ages";
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 6000, 1000);
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(0, 10, 1);
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Font = new Font("Verdana", 7.0f, FontStyle.Regular);
            chart.Series[1].Style.Border.Color = Color.Transparent;
            chart.Series[0].Style.Border.Width = 2;
            chart.Series[0].Style.Symbol.Shape = ChartSymbolShape.Circle;

            for (int i = 0; i < 2; i++)
            {
                chart.Series[0].Styles[i].Interior = new BrushInfo(Color.Green);
                chart.Series[0].Styles[i].Symbol.Color = Color.White;
                chart.Series[0].Styles[i].Symbol.Border.Color = Color.Green;
                chart.Series[0].Styles[i].Symbol.Border.Width = 2;
            }
            for (int i = 2; i < chart.Series[0].Points.Count; i++)
            {
                chart.Series[0].Styles[i].Interior = new BrushInfo(Color.FromArgb(199, 23, 33));
                chart.Series[0].Styles[i].Symbol.Color = Color.White;
                chart.Series[0].Styles[i].Symbol.Border.Color = Color.FromArgb(199, 23, 33);
                chart.Series[0].Styles[i].Symbol.Border.Width = 2;
            }                

            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendAlignment = ChartAlignment.Near;
            chart.Legend.BackInterior = new BrushInfo(Color.Transparent);
            chart.Legend.Items[0].Visible = false;
            
            #endregion
        }
    }
}
