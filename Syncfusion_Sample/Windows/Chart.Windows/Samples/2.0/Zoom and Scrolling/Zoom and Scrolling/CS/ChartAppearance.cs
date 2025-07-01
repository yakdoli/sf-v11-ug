using System;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace KeyAndMouseZoomingSample
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {  
                Color.FromArgb(200, 129,115,27) ,  
                Color.FromArgb(200,206,215,41) 
            };

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White);
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.DarkOliveGreen;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 5;

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.HidePartialLabels = true;
            chart.PrimaryYAxis.HidePartialLabels = true;
            chart.PrimaryXAxis.LineType.ForeColor = Color.DarkGray;
            chart.PrimaryYAxis.LineType.ForeColor = Color.DarkGray;           
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.Series[1].Style.Border.Color = Color.Transparent;
            chart.Series[0].Style.Border.Width = 2;
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Zooming.ShowBorder = true;
            chart.Zooming.Border.ForeColor = Color.FromArgb(255, 128, 0);
            chart.Zooming.Interior = new BrushInfo(GradientStyle.PathEllipse, Color.Red, Color.Yellow);
            chart.Zooming.Opacity = 0.6f;
            chart.GetVScrollBar(chart.PrimaryYAxis).ZoomButton.Size = new Size(0, 0);
            chart.GetHScrollBar(chart.PrimaryXAxis).ZoomButton.Size = new Size(0, 0);
            chart.EnableXZooming = true;
            chart.EnableYZooming = true;
            chart.ZoomFactorX = 1;
            chart.ZoomFactorX = 1;
            chart.ShowScrollBars = true;
            chart.LegendPosition = ChartDock.Top;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(1850, 2007, 10);
            chart.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            chart.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;
            chart.PrimaryXAxis.EdgeLabelsDrawingMode = ChartAxisEdgeLabelsDrawingMode.Shift;

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

            
            #endregion
        }
    }
}
