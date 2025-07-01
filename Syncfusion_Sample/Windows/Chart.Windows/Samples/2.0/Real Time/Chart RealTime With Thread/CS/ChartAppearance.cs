#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
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
           
            chart.Text = "CPU Load";
            chart.PrimaryYAxis.Title = "CPU Usage(%)";
            chart.PrimaryXAxis.Title = "Time";            
            chart.Font = new Font("Verdana", 7.0f, FontStyle.Regular);
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 270;               
            chart.Titles[0].ForeColor = Color.White;
            chart.Titles[0].Font = new Font("Vernada", 11, FontStyle.Bold);
            chart.Series[0].Style.Border.Width = 2;

            #endregion
        }
    }
}
