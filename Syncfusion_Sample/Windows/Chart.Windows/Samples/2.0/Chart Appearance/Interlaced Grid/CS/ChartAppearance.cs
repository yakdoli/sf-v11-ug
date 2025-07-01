using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace WindowsApplication1
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
                Color.FromArgb(200,255,186,0),
                Color.FromArgb(200, 247,125,16) 
            };
            #endregion

            #region Chart Appearance Customization                      
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.SkyBlue;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes and Legend Customization

            // Customizing primary axes line and grid line.
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            chart.PrimaryYAxis.Range.Min = 0;
           
            // Enable Interlaced grid for X-Axis
            chart.PrimaryXAxis.InterlacedGrid = true;
            chart.PrimaryXAxis.InterlacedGridInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(238, 237, 238));
            chart.PrimaryYAxis.InterlacedGrid = false;            
            chart.PrimaryYAxis.ForceZero = true;

            // The below code illustrate how to set the axes range.
            chart.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 100, 5);
            chart.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            chart.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 10, 10);
            chart.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(new DateTime(2007, 1, 1), new DateTime(2007, 6, 1), 1, ChartDateTimeIntervalType.Months);
            chart.PrimaryXAxis.DateTimeFormat = "MMM\nyy";
            chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;
            chart.PrimaryYAxis.InterlacedGridInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(238, 237, 238));
            chart.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 40, 5);
            chart.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;                               
            chart.Font = new Font("Verdana", 17.0f, FontStyle.Bold);        

            // Customizing the legend appearance.
            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesImage;
            chart.Legend.ItemsSize = new Size(32, 32);
            chart.LegendPosition = ChartDock.Top;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesImage;
            chart.Legends[0].Items[0].TextColor = Color.FromArgb(246, 100, 15);
            chart.Legends[0].Items[1].TextColor = Color.FromArgb(36, 119, 51);
            chart.Legends[0].Items[2].TextColor = Color.FromArgb(9, 116, 210);
            foreach (ChartLegendItem cli in chart.Legends[0].Items)
            {
                cli.RepresentationSize = new Size(48, 48);
                cli.Font = new Font("Verdana", 8, FontStyle.Bold);
            }

            #endregion
        }
    }
}
