using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {
                Color.FromArgb(200,0,255,0)
            };
            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(Color.Black);
            chart.ChartInterior = new BrushInfo(Color.Black);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;         
            #endregion

            #region Axes and Legend Customization
         
            chart.PrimaryXAxis.LineType.ForeColor = Color.Transparent;
            chart.PrimaryYAxis.LineType.ForeColor = Color.Transparent;
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.TitleColor = Color.White;
            chart.PrimaryYAxis.TitleColor = Color.White;
            chart.PrimaryXAxis.ForeColor = Color.White;
            chart.PrimaryYAxis.ForeColor = Color.White;
            chart.ElementsSpacing = 0;                  
          
            chart.PrimaryXAxis.SmallTicksPerInterval = 2;
            chart.PrimaryXAxis.DrawMinorGrid = true;
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.DrawGrid = false;
            chart.PrimaryXAxis.MinorGridLineType.ForeColor = Color.LightGreen;
            chart.PrimaryYAxis.SmallTicksPerInterval = 3;
            chart.PrimaryYAxis.DrawMinorGrid = true;
            chart.PrimaryYAxis.MinorGridLineType.ForeColor = Color.LightGreen;
            chart.PrimaryXAxis.MinorGridLineType.DashStyle = DashStyle.Dot;
            chart.PrimaryYAxis.MinorGridLineType.DashStyle = DashStyle.Dot;       
            
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 270;            
            chart.Series[0].Style.Border.Color = Color.Transparent;
            chart.Series[0].Style.Border.Width = 2;
            chart.Legend.Visible = false;
            chart.PrimaryYAxis.Title = "Memory Usage (MB)";
            chart.PrimaryXAxis.Title = "Time";
            chart.Text = "Memory Usage History";
            chart.ForeColor = Color.White;
            chart.Titles[0].Font = new Font("Verdana", 10.0f, FontStyle.Bold);
            

            #endregion
        }
    }
}
