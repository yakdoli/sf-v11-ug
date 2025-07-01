using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ChartPoints_2005
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            { 
                Color.FromArgb(200, 253,171,0),            
                Color.FromArgb(200, 188, 200, 6),                            
                Color.MediumVioletRed 
            };

            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(Color.Black);
            chart.ChartInterior = new BrushInfo(Color.Black);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 2;

            #endregion

            #region Axes and Legend Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(224,223,227);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(224, 223, 227);
            chart.PrimaryXAxis.GridLineType.DashStyle = DashStyle.Dot;
            chart.PrimaryYAxis.GridLineType.DashStyle = DashStyle.Dot;
            chart.PrimaryXAxis.LineType.ForeColor = Color.White;
            chart.PrimaryYAxis.LineType.ForeColor = Color.White;
            chart.PrimaryXAxis.TitleColor = Color.White;
            chart.PrimaryYAxis.TitleColor = Color.White;
            chart.PrimaryXAxis.ForeColor = Color.White;
            chart.PrimaryYAxis.ForeColor = Color.White;
            chart.PrimaryXAxis.TickColor = Color.White;
            chart.PrimaryYAxis.TickColor = Color.White;                    
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.Legend.Position = ChartDock.Bottom;
            chart.LegendAlignment = ChartAlignment.Near;          
            
            for (int i = 0; i < chart.Legend.Items.Length; i++)
            {
                chart.Legend.Items[i].TextColor = Color.White;
                chart.Legend.Items[i].TextAligment = VerticalAlignment.Center;
                chart.Legend.ItemsSize = new Size(30, 30);
            }
            chart.Legend.RepresentationType = ChartLegendRepresentationType.StraightLine;
            chart.Legend.ShowSymbol = true;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 700, 100);
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryXAxis.Range = new MinMaxInfo(1996, 2008, 1);
            chart.PrimaryXAxis.LabelRotate = true;
            chart.PrimaryXAxis.LabelRotateAngle = 270;        
            chart.Text = "World Production of Wheat, Corn and Rice";
            chart.Titles[0].ForeColor = Color.White;
            chart.Titles[0].Font = new Font("Vernada", 11, FontStyle.Bold);
            chart.PrimaryXAxis.Font = new Font("Arial", 8.25f, FontStyle.Regular);
            chart.PrimaryYAxis.Font = new Font("Arial", 8.25f, FontStyle.Regular);
            chart.Legend.Font = new Font("Arial", 8.25f, FontStyle.Regular);
            chart.PrimaryXAxis.Title = "Year";
            chart.PrimaryYAxis.Title = "Production (Million tonnes)";          

            #endregion
        }
    }
}
