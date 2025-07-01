Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing
Imports System.Drawing.Drawing2D

Namespace ChartPoints_2005
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' "ApplyCustomPalette"

            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(200, 253, 171, 0), Color.FromArgb(200, 188, 200, 6), Color.MediumVioletRed}
            ' "Chart Appearance Customization"

            chart.BackInterior = New BrushInfo(Color.Black)
            chart.ChartInterior = New BrushInfo(Color.Black)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.None
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 5

            ' "Axes and Legend Customization"

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(224, 223, 227)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(224, 223, 227)
            chart.PrimaryXAxis.GridLineType.DashStyle = DashStyle.Dot
            chart.PrimaryYAxis.GridLineType.DashStyle = DashStyle.Dot
            chart.PrimaryXAxis.LineType.ForeColor = Color.White
            chart.PrimaryYAxis.LineType.ForeColor = Color.White
            chart.PrimaryXAxis.TitleColor = Color.White
            chart.PrimaryYAxis.TitleColor = Color.White
            chart.PrimaryXAxis.ForeColor = Color.White
            chart.PrimaryYAxis.ForeColor = Color.White
            chart.PrimaryXAxis.TickColor = Color.White
            chart.PrimaryYAxis.TickColor = Color.White
            chart.LegendsPlacement = ChartPlacement.Outside
            chart.Legend.Position = ChartDock.Bottom
            chart.LegendAlignment = ChartAlignment.Far

            For i As Integer = 0 To chart.Legend.Items.Length - 1
                chart.Legend.Items(i).TextColor = Color.White
                chart.Legend.Items(i).TextAligment = VerticalAlignment.Center
                chart.Legend.ItemsSize = New Size(30, 30)
            Next i
            chart.Legend.RepresentationType = ChartLegendRepresentationType.StraightLine
            chart.Legend.ShowSymbol = True
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryYAxis.Range = New MinMaxInfo(0, 700, 100)
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryXAxis.Range = New MinMaxInfo(1996, 2008, 1)
            chart.PrimaryXAxis.LabelRotate = True
            chart.PrimaryXAxis.LabelRotateAngle = 270
            chart.Text = "World Production of Wheat, Corn and Rice"
            chart.Titles(0).ForeColor = Color.White
            chart.Titles(0).Font = New Font("Vernada", 11, FontStyle.Bold)
            chart.PrimaryXAxis.Font = New Font("Arial", 8.25F, FontStyle.Regular)
            chart.PrimaryYAxis.Font = New Font("Arial", 8.25F, FontStyle.Regular)
            chart.Legend.Font = New Font("Arial", 8.25F, FontStyle.Regular)
            chart.PrimaryXAxis.Title = "Year"
            chart.PrimaryYAxis.Title = "Production (Million tonnes)"

        End Sub
    End Class
End Namespace
