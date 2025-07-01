using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace TornadoChart_2005
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {              
                Color.FromArgb(200, 41,158,214),
                Color.FromArgb(200,206,215,41),              
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

            chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 2, 2);
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.Transparent;
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.DrawGrid = false;
            chart.PrimaryXAxis.TickColor = Color.Transparent;

            chart.PrimaryYAxis.ValueType = ChartValueType.Double;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 22, 1);

            #endregion

            #region Axes Customization           
         
            chart.Text = "Product Comparison Chart";
            chart.PrimaryXAxis.Title = "Range(Miles)";
            chart.PrimaryYAxis.Title = "Capacity(Tones)";
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Regular);
            chart.Font = new Font("Verdana", 7.0f, FontStyle.Regular);
            chart.Series[0].Style.Border.Color = Color.Gray;
            chart.Series[1].Style.Border.Color = Color.Gray;          
            #endregion

            #region Legend Customization

            chart.Legend.Alignment = ChartAlignment.Center;
            chart.Legend.Position = ChartDock.Top;
            chart.LegendsPlacement = ChartPlacement.Outside;
            #endregion
        }

    }
}
