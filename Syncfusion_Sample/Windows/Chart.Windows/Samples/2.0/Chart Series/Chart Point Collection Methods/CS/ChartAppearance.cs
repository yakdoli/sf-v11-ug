using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace ChartPointCollectionMethods_2005
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {  
                Color.FromArgb(200, 9,116,210)                        
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
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Font = new Font("Verdana", 7.0f, FontStyle.Regular);
            chart.Series[0].Style.Border.Color = Color.Transparent;

            chart.PrimaryXAxis.TitleColor = Color.MidnightBlue;
            chart.PrimaryXAxis.ForeColor = Color.MidnightBlue;
            chart.PrimaryYAxis.TitleColor = Color.MidnightBlue;
            chart.PrimaryYAxis.ForeColor = Color.MidnightBlue;
            chart.Title.ForeColor = Color.MidnightBlue;
            chart.Text = "Book Purchases by Category for 2008";
            chart.PrimaryXAxis.Title = "Category of books";
            chart.PrimaryYAxis.Title = "Number of books";
            chart.Indexed = true;
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 270;
            chart.PrimaryXAxis.TitleSpacing = 2;
            chart.ShowLegend = false;

            #endregion
        }
    }
}
