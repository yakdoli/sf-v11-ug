Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing

Namespace GettingStartedSample
    Public Class ChartAppearance
        Private Sub New()
        End Sub
        Public Shared Sub ApplyChartStyles(ByVal chart As ChartControl)
            ' Chart Appearance Customization

            chart.BackInterior = New BrushInfo(GradientStyle.PathRectangle, New Color() {Color.FromArgb(214, 231, 247), Color.White})
            chart.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.ChartInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
            chart.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
            chart.BorderAppearance.BaseColor = Color.SkyBlue
            chart.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
            chart.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
            chart.ChartArea.PrimaryXAxis.HidePartialLabels = True
            chart.ElementsSpacing = 5

            ' Axes Customization

            chart.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryYAxis.GridLineType.ForeColor = Color.FromArgb(231, 231, 231)
            chart.PrimaryXAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryYAxis.LineType.ForeColor = Color.Teal
            chart.PrimaryXAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.TickColor = Color.Transparent
            chart.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryYAxis.Range = New MinMaxInfo(0, 80, 20)
            chart.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            chart.PrimaryXAxis.Range = New MinMaxInfo(1998, 2009, 1)
            chart.PrimaryXAxis.LabelRotate = True
            chart.PrimaryXAxis.LabelRotateAngle = 270
            chart.Series(0).Style.Border.Color = Color.Transparent
            chart.PrimaryYAxis.Title = "Product sold (Millions)"
            chart.PrimaryXAxis.Title = "Year"
            chart.Title.Text = "Product Sales"

            ' Legend Customization

            chart.Legend.Visible = False
        End Sub


    End Class
End Namespace
