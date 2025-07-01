Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace ChartDragDrop
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' ApplyCustomPalette

            chart.Palette = ChartColorPalette.Custom
            chart.CustomPalette = New System.Drawing.Color() {Color.FromArgb(175, 199, 23, 33)}

            ' Chart Appearance Customization

            chart.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.ChartInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 224, 192), System.Drawing.Color.White)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 0

            ' Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)

            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryYAxis.Range = New MinMaxInfo(0, 100, 25)
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryXAxis.Range = New MinMaxInfo(0, 7, 1)

            chart.Series(0).Style.Symbol.Shape = ChartSymbolShape.Circle
            chart.Series(0).Style.Symbol.Color = Color.White
            chart.Series(0).Style.Symbol.Size = New Size(8, 8)
            chart.Series(0).Style.DisplayText = True
            chart.Series(0).Style.TextColor = Color.Black
            chart.Series(0).Style.TextFormat = "{0}"
            chart.Series(0).Style.TextOrientation = ChartTextOrientation.Up
            chart.Series(0).Style.Symbol.Color = Color.FromArgb(175, 199, 23, 33)
            chart.Series(0).Style.Symbol.Border.Color = Color.Transparent
            chart.Series(0).Style.Border.Color = Color.Transparent
            chart.Series(0).Style.Border.Width = 2
            chart.Text = "Daily Performance "
            chart.PrimaryYAxis.Title = "Task finished(%)"
            chart.PrimaryXAxis.Title = "Daily Review"
            ' Legend Customization

            chart.ShowLegend = False
        End Sub
    End Class
End Namespace
