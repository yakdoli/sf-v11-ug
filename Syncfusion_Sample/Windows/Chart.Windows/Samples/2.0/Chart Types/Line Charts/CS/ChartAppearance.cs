using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace LineChart2002
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {              
                Color.FromArgb(200, 9,116,210),                
                Color.FromArgb(200,36,119,51),
                Color.FromArgb(200, 199,23,33)                           
            };

            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White);
            chart.ChartArea.BackInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame;
            chart.BorderAppearance.BaseColor = Color.DarkOliveGreen;
            chart.BorderAppearance.FrameThickness = new ChartThickness(-2, -2, 2, 2);
            chart.PrimaryXAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            chart.PrimaryYAxis.RangePaddingType = ChartAxisRangePaddingType.Calculate;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            chart.ElementsSpacing = 0;
            chart.Text = "National football team ranking(1985-2000)";
            chart.PrimaryXAxis.Title = "Year";
            chart.PrimaryYAxis.Title = "Rank";
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Font = new Font("Verdana", 7.0f, FontStyle.Regular);
            chart.Series[1].Style.Border.Width = 2;
            chart.Series[0].Style.Border.Width = 2;
            chart.Series[2].Style.Border.Width = 2;
           
            chart.Series[0].Style.Symbol.Border.Color = Color.Transparent;
            chart.Series[1].Style.Symbol.Border.Color = Color.Transparent;
            chart.Series[2].Style.Symbol.Border.Color = Color.Transparent;
                                 
            chart.Series[1].Style.Symbol.Shape = ChartSymbolShape.Circle;
            chart.Series[1].Style.Symbol.Color = Color.FromArgb(200, 36, 119, 51);
            chart.Series[1].Style.Symbol.Size = new Size(6, 6);           
            chart.Series[0].Style.Symbol.Shape = ChartSymbolShape.Square;
            chart.Series[0].Style.Symbol.Color = Color.FromArgb(200, 9, 116, 210);
            chart.Series[0].Style.Symbol.Size = new Size(6, 6);
            chart.Series[2].Style.Symbol.Shape = ChartSymbolShape.Square;
            chart.Series[2].Style.Symbol.Color = Color.FromArgb(200, 199, 23, 33);
            chart.Series[2].Style.Symbol.Size = new Size(6, 6);
            chart.ShowToolTips = true;          

            #endregion

            #region Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231);
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal;
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;   

            chart.PrimaryYAxis.Inversed = true;
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(1985, 2000, 1);
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 16, 2);
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 90;
            chart.EnableMouseRotation = true; 
            #endregion

            #region Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.StraightLine;
            chart.LegendPosition = ChartDock.Top;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Legend.ItemsSize = new Size(30, 30);
            chart.Legend.VisibleCheckBox = true;

            #endregion
        }


    }
}
