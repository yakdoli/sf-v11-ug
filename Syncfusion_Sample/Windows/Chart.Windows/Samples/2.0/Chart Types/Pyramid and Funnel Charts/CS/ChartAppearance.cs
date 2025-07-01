using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace PyramidAndFunnelChart
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {   
                Color.FromArgb(175, 9,116,210),
                Color.FromArgb(175, 253,171,0),
                Color.FromArgb(175,36,119,51),
                Color.FromArgb(175, 199,23,33)
            };
            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.PathRectangle, new Color[] { Color.FromArgb(214, 231, 247), Color.White });
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.SkyBlue;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);

            chart.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            chart.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.Text = "World Crop Statistics";          
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Font = new Font("Verdana", 8.0f, FontStyle.Regular);            

            #endregion

            #region Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;
            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Legend.Font=new Font("Verdana", 8.0f, FontStyle.Regular);
            chart.ShowLegend = false;  
            chart.EnableMouseRotation = true;
            #endregion
        }
    }
}
