using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {        
                Color.FromArgb(200, 253,171,0),
                Color.FromArgb(200, 199,23,33)          
               
            };

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;           
            chart.ElementsSpacing = 0;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.DarkGray;
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.DarkGray;
            chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray;
            chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray;
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            
            
            
            #endregion

            #region Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;
            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Near;
            chart.Legend.Visible = false;

            #endregion
        }
    }
}
