using System;
using System.Collections.Generic;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace RangeAreaChart_Sample
{
    public static class ChartAppearance
    {
        public static void ApplyChartStyles(ChartControl chart)
        {
            #region ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom;
            chart.CustomPalette = new System.Drawing.Color[] 
            {                
               Color.FromArgb(200, 191,192,98),              
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
            chart.Titles[0].Font = new Font("Verdana", 12.0f, FontStyle.Bold);
            chart.Font = new Font("Verdana", 8.0f, FontStyle.Regular);
            chart.Series[1].Style.Border.Color = Color.Transparent;
            chart.Series[0].Style.Border.Color = Color.FromArgb(200, 255, 136, 23);
            chart.PrimaryXAxis.DrawGrid = false;
            chart.PrimaryYAxis.DrawGrid = false;
            chart.ElementsSpacing = 0;
            chart.PrimaryXAxis.TickColor = Color.Transparent;
            chart.PrimaryYAxis.TickColor = Color.Transparent;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.Transparent;
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.Transparent;
            chart.PrimaryYAxis.LineType.Width = 2;
            chart.PrimaryXAxis.LineType.Width = 2;
           
           chart.ShowToolTips = true;
           
            #endregion

            #region Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;
            chart.LegendPosition = ChartDock.Bottom;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;
            chart.Legend.Font=new Font("Verdana", 8.0f, FontStyle.Regular);
            chart.ShowLegend = false;  
            chart.EnableMouseRotation = true;

            ChartCustomPoint ccp = new ChartCustomPoint();
            ccp.XValue = chart.Series[1].Points[40].X;
            ccp.YValue = chart.Series[1].Points[40].YValues[1];
            ccp.CustomType = ChartCustomPointType.ChartCoordinates;
            ccp.Text = "Upper Band";           
            ccp.Symbol.Shape = ChartSymbolShape.Circle;
            ccp.Symbol.Color = Color.White;            
            ccp.Symbol.Size = new Size(12, 12);
            ccp.Alignment = ChartTextOrientation.RegionUp;
          
            ccp.Color = Color.Black;
            ccp.Font.Facename = "Tahoma";
            ccp.Font.Size = 10f;
            chart.CustomPoints.Add(ccp);

            ChartCustomPoint ccp1 = new ChartCustomPoint();
            ccp1.XValue = chart.Series[1].Points[40].X;
            ccp1.YValue = chart.Series[1].Points[40].YValues[0];
            ccp1.CustomType = ChartCustomPointType.ChartCoordinates;
            ccp1.Text = "Lower Band";
            ccp1.Symbol.Shape = ChartSymbolShape.Circle;
            ccp1.Symbol.Color = Color.White;
            ccp1.Images = new ChartImageCollection();
            ccp1.Symbol.Size = new Size(12, 12);
            ccp1.Alignment = ChartTextOrientation.RegionDown;
            ccp1.Color = Color.Black;
            ccp1.Font.Facename = "Tahoma";
            ccp1.Font.Size = 10f;
            chart.CustomPoints.Add(ccp1);
            #endregion
        }
    }
}
