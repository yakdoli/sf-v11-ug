Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Reflection
Imports System.IO

Namespace TickMarksDemo_2005
    Partial Public Class Form1
        Inherits Office2007Form


#Region "Form's Constructor"

        Public Sub New()
            InitializeComponent()
            InitializeChartData()
            InitializeControlSettings()
            Me.richTextBox1.Rtf = "{\rtf1\ansi\ansicpg1253\deff0\deflang1032{\fonttbl{\f0\fswiss\fprq2\fcharset0 Arial;}{\f1\fswiss\fprq2\fcharset161{\*\fname Arial;}Arial Greek;}{\f2\fswiss\fcharset0 Arial;}}" & ControlChars.CrLf & "{\colortbl ;\red0\green0\blue128;}" & ControlChars.CrLf & "{\*\generator Msftedit 5.41.15.1507;}\viewkind4\uc1\pard\cf1\lang1033\b\f0\fs17 TickMarksDemo\b0  \lang1032\f1 sample illustrates various customization options of TickMarks in Essential Chart. Along with the illustrated properties, the number of \lang1033\f0 T\lang1032\f1 ick\lang1033\f0 M\lang1032\f1 arks that should appear on chart zooming could also be specified using the axis \b\i\fs16 TickDrawingOperationMode\b0\i0\fs17  property.\cf0\lang1033\f2\fs20\par" & ControlChars.CrLf & "}"
        End Sub
#End Region

#Region "Helper Methods"
#Region "InitializeChartData"

        Private Sub InitializeChartData()
            Dim series As ChartSeries = New ChartSeries()
            series.Name = "Series 1"
            series.Points.Add(175, 7)
            series.Points.Add(200, 6)
            series.Points.Add(225, 5)
            series.Points.Add(250, 4)
            series.Points.Add(275, 3)
            series.Points.Add(300, 2)
            series.Points.Add(325, 1)
            series.Type = ChartSeriesType.Bar
            series.Text = series.Name
            Me.chartControl1.Series.Add(series)

            Me.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(-1, 8, 1)
            Me.chartControl1.PrimaryYAxis.RangeType = ChartAxisRangeType.Set
            Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(150, 350, 50)

        End Sub
#End Region

#Region "InitializeControlSettings"


        Private Sub InitializeControlSettings()

            Me.chartControl1.Font = New System.Drawing.Font("Arial", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.chartControl1.ChartArea.PrimaryXAxis.HidePartialLabels = True
            Me.chartControl1.ChartArea.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap
            Me.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(213))))), (CInt(Fix((CByte(6))))), (CInt(Fix((CByte(22)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(216))))), (CInt(Fix((CByte(102)))))))
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Color.White)
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.FromArgb(184, 25, 0)
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(184, 25, 0)
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = Color.FromArgb(184, 25, 0)
            Me.chartControl1.PrimaryYAxis.DrawGrid = False
            Me.chartControl1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
            Me.chartControl1.Series(0).Style.Interior = New BrushInfo(Color.White)
            Me.chartControl1.Series(0).Style.Border.Color = Color.FromArgb(196, 196, 196)


            Dim thermoStripLine As ChartStripLine = New ChartStripLine()
            thermoStripLine.Enabled = True
            thermoStripLine.Vertical = True
            thermoStripLine.StartAtAxisPosition = True
            thermoStripLine.Start = 0
            thermoStripLine.Text = "Transmission Oil Temperature "
            Dim asem As System.Reflection.Assembly = Me.GetType().Assembly
            Dim str As Stream = asem.GetManifestResourceStream("Thermometer.png")
            Dim img As Image = Image.FromStream(str)
            thermoStripLine.BackImage = img
            thermoStripLine.Font = New System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
            thermoStripLine.Period = 9
            thermoStripLine.Width = 0.5
            Me.chartControl1.PrimaryXAxis.StripLines.Add(thermoStripLine)

            Me.chartControl1.Series(0).Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            Me.chartControl1.Series(0).Style.ImageIndex = 0
            Me.chartControl1.Series(0).Style.Symbol.Shape = ChartSymbolShape.Image
            Me.chartControl1.Series(0).Style.Symbol.ImageIndex = 0
            Me.chartControl1.Series(0).Style.Symbol.Size = New Size(34, 34)
            Me.chartControl1.Series(0).Style.Symbol.Offset = New Size(3, 0)
            Me.chartControl1.Series(0).Style.Symbol.Color = Color.FromArgb(112, 110, 142)
            Me.chartControl1.ShowLegend = False

            Dim cp1 As ChartCustomPoint = New ChartCustomPoint()
            cp1.Text = "LOW HEAT : LONG MILEAGE"
            cp1.CustomType = ChartCustomPointType.ChartCoordinates
            cp1.Font.Facename = "Verdana"
            cp1.Font.FontStyle = FontStyle.Bold
            cp1.Font.Size = 7
            cp1.XValue = 158
            cp1.YValue = 4
            Me.chartControl1.CustomPoints.Add(cp1)

            Dim cp2 As ChartCustomPoint = New ChartCustomPoint()
            cp2.Text = "HIGH HEAT : SHORT MILEAGE"
            cp2.Font.Facename = "Verdana"
            cp2.Font.FontStyle = FontStyle.Bold
            cp2.Font.Size = 7
            cp2.CustomType = ChartCustomPointType.ChartCoordinates
            cp2.XValue = 335
            cp2.YValue = 4
            Me.chartControl1.CustomPoints.Add(cp2)
        End Sub
#End Region
#End Region

#Region "Events"
#Region "ChartFormatAxisLabel"
        Private labels As String() = New String() {"", "800 ml", "5000 ml", "10,000 ml", "20,000 ml", "50,000 ml", "100,000 ml", "", ""}
        Private Sub chartControl1_ChartFormatAxisLabel(ByVal sender As Object, ByVal e As ChartFormatAxisLabelEventArgs)
            If e.AxisOrientation = ChartOrientation.Vertical Then
                'Applying Formatted Y Axis label values.
                e.Label = String.Format("{0}'F", e.Value)
            Else
                If CInt(Fix(e.Value)) >= 0 AndAlso CInt(Fix(e.Value)) < 8 Then
                    e.Label = labels(CInt(Fix(e.Value)))
                End If
            End If
            e.Handled = True
        End Sub
#End Region

#Region "X Axis Ticks"
        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbXAxisDrawLabelGrid.CheckedChanged
            Me.chartControl1.PrimaryXAxis.DrawTickLabelGrid = cbXAxisDrawLabelGrid.Checked
            Me.nUDXAxisTickGridPadding.Enabled = cbXAxisDrawLabelGrid.Checked

        End Sub

        Private Sub cpXAxisTickColor_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpXAxisTickColor.ColorSelected
            Me.chartControl1.PrimaryXAxis.TickColor = cpXAxisTickColor.SelectedColor
        End Sub

        Private Sub nUDXAxisTicksPerInterval_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDXAxisTicksPerInterval.ValueChanged
            Me.chartControl1.PrimaryXAxis.SmallTicksPerInterval = CInt(Fix(nUDXAxisTicksPerInterval.Value))
        End Sub

        Private Sub nUDXAxisTickGridPadding_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDXAxisTickGridPadding.ValueChanged
            Me.chartControl1.PrimaryXAxis.TickLabelGridPadding = CInt(Fix(nUDXAxisTickGridPadding.Value))
        End Sub

        Private Sub nUDXAxisTickSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDXAxisTickWidth.ValueChanged, nUDXAxisTickHeight.ValueChanged
            Me.chartControl1.PrimaryXAxis.TickSize = New Size(CInt(Fix(nUDXAxisTickWidth.Value)), CInt(Fix(nUDXAxisTickHeight.Value)))
        End Sub



        Private Sub nUDXAxisSmallTickSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDXAxisSmallTickWidth.ValueChanged, nUDXAxisSmallTickHeight.ValueChanged

            Me.chartControl1.PrimaryXAxis.SmallTickSize = New Size(CInt(Fix(nUDXAxisSmallTickWidth.Value)), CInt(Fix(nUDXAxisSmallTickHeight.Value)))
        End Sub
#End Region

#Region "Y Axis Ticks"
        Private Sub cbYAxisDrawLabelGrid_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbYAxisDrawLabelGrid.CheckedChanged
            Me.chartControl1.PrimaryYAxis.DrawTickLabelGrid = cbYAxisDrawLabelGrid.Checked
            Me.nUDYAxisTickGridPadding.Enabled = cbYAxisDrawLabelGrid.Checked

        End Sub

        Private Sub cpYAxisTickColor_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpYAxisTickColor.ColorSelected
            Me.chartControl1.PrimaryYAxis.TickColor = cpYAxisTickColor.SelectedColor
        End Sub

        Private Sub nUDYAxisTickSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDYAxisTickWidth.ValueChanged, nUDYAxisTickHeight.ValueChanged
            Me.chartControl1.PrimaryYAxis.TickSize = New Size(CInt(Fix(nUDYAxisTickHeight.Value)), CInt(Fix(nUDYAxisTickWidth.Value)))
        End Sub
        Private Sub nUDYAxisSmallTickSize_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDYAxisSmallTickWidth.ValueChanged, nUDYAxisSmallTickHeight.ValueChanged
            Me.chartControl1.PrimaryYAxis.SmallTickSize = New Size(CInt(Fix(nUDYAxisSmallTickHeight.Value)), CInt(Fix(nUDYAxisSmallTickWidth.Value)))
        End Sub

        Private Sub nUDYAxisTicksPerInterval_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDYAxisTicksPerInterval.ValueChanged
            Me.chartControl1.PrimaryYAxis.SmallTicksPerInterval = CInt(Fix(nUDYAxisTicksPerInterval.Value))
        End Sub

        Private Sub nUDYAxisTickGridPadding_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDYAxisTickGridPadding.ValueChanged
            Me.chartControl1.PrimaryYAxis.TickLabelGridPadding = CInt(Fix(nUDYAxisTickGridPadding.Value))
        End Sub



#End Region

#End Region

    End Class
End Namespace
