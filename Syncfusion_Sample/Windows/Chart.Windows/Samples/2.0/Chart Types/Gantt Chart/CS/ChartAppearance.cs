using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;

namespace OtherCharts
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {     
                Color.FromArgb(163,48,45),              
                Color.FromArgb(140,198,62)                        
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

            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[1].Style.Border.Color = Color.Transparent;

            chart.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 0, 4);
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(211, 224, 241);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(211, 224, 241);
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(211, 224, 241);
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(211, 224, 241);
            chart.PrimaryXAxis.OpposedPosition = true;
            chart.ChartArea.XAxesLayoutMode = ChartAxesLayoutMode.Stacking;
            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendAlignment = ChartAlignment.Near;
            chart.PrimaryYAxis.Inversed = true;
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(211, 224, 241);
            chart.PrimaryXAxis.OpposedPosition = true;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(211, 224, 241);
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 90;
            chart.Text = "Project Schedule";
            chart.Legend.Items[0].ItemStyle.Spacing = 7;
            chart.Legend.Items[1].ItemStyle.Spacing = 7;

            #endregion
        }
    }
}
