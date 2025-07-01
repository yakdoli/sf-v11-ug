using System;
using System.Text;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Drawing;

namespace Stacked100Charts
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
                Color.FromArgb(200,36,119,51),
                Color.FromArgb(200, 199,23,33)
            };

            #endregion

            #region Chart Appearance Customization

            chart.BackInterior = new BrushInfo(Color.FromArgb(255, 224, 192));
            chart.ChartInterior = new BrushInfo(GradientStyle.Vertical, Color.FromArgb(255, 224, 192), System.Drawing.Color.White);
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = true;
            chart.ElementsSpacing = 0;
            chart.Text = "Area Chart";
            chart.PrimaryXAxis.Title = "Year";

            #endregion

            #region Axes Customization

            chart.Indexed = true;

            chart.Series[0].ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.FlatRectangle;
            chart.Series[1].ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.FlatRectangle;
            chart.Series[2].ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.FlatRectangle;
            chart.Series[3].ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.FlatRectangle;

            chart.Legend.Position = ChartDock.Top;
            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(134, 134, 134);
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(134, 134, 134);
            chart.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(134, 134, 134);
            chart.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(134, 134, 134);
            chart.Legend.Border.ForeColor = Color.Black;
            chart.Spacing = 40;
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
            chart.PrimaryYAxis.Range = new MinMaxInfo(0, 100, 20);
            chart.Series[0].Style.Border.Color = Color.White;
            chart.Series[1].Style.Border.Color = Color.White;
            chart.Series[2].Style.Border.Color = Color.White;
            chart.Series[3].Style.Border.Color = Color.White;

            #endregion

            #region Legend Customization

            chart.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;
            chart.LegendPosition = ChartDock.Top;
            chart.LegendsPlacement = ChartPlacement.Outside;
            chart.LegendAlignment = ChartAlignment.Center;

            #endregion
        }


    }
}
