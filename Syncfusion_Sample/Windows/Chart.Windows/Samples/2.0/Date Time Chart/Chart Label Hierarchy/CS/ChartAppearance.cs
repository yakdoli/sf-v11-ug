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

namespace ChartLabelHierarchy
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            chart.ShowLegend = false;
            chart.BackInterior = new BrushInfo(GradientStyle.ForwardDiagonal,
                Color.FromArgb(215, 228, 189), Color.White);
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, 
                Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical,
                Color.Transparent, Color.Transparent);

            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.DarkOliveGreen;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);

            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent;
            chart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Silver;

            chart.PrimaryXAxis.TickSize = new System.Drawing.Size(1, 5);
            chart.PrimaryYAxis.TickSize = new System.Drawing.Size(5, 1);
            chart.LegendsPlacement = ChartPlacement.Outside;
            //Adds Custom legend to chart control
            ChartLegend legend1 = new ChartLegend(chart);
            legend1.Name = "legend1";
            legend1.RepresentationType = ChartLegendRepresentationType.None;
            legend1.Position = ChartDock.Bottom;
            legend1.Alignment = ChartAlignment.Far;
            ChartLegendItem[] customItems = new ChartLegendItem[0];
            ChartLegendItemsCollection clic = new ChartLegendItemsCollection();
            ChartLegendItem cli1 = new ChartLegendItem("Press Esc to Cancel Zooming");
            clic.Add(cli1);
            legend1.CustomItems = clic.ToArray();
            chart.Legends.Add(legend1);
        }
    }
}
