Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Drawing.Drawing2D

Namespace MultiplyLegendsSample
    Public Class Form1
        Inherits Office2007Form
#Region "Private Members"
        Private components As System.ComponentModel.IContainer = Nothing
        Private WithEvents chartControl1 As ChartControl
        Private chartTitle1 As ChartTitle
        Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
        Private legendColor As Color() = New Color() {Color.White, Color.White, Color.White, Color.White, Color.FromArgb(189, 221, 253), Color.FromArgb(236, 241, 245)}
        Private legendHighlightColor As Color() = New Color() {Color.FromArgb(249, 196, 74), Color.FromArgb(249, 196, 74), Color.FromArgb(249, 196, 74), Color.FromArgb(189, 221, 253), Color.FromArgb(236, 241, 245)}
#End Region

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.chartTitle1 = New Syncfusion.Windows.Forms.Chart.ChartTitle
            Me.chartControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'imageListAdv1
            '
            Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() {CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images2"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images3"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images4"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images5"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images6"), System.Drawing.Image), CType(resources.GetObject("imageListAdv1.Images7"), System.Drawing.Image)})
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(187, Byte), Integer))
            Me.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(187, Byte), Integer))
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.chartControl1.ChartArea.BorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(177, Byte), Integer))
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            '
            '
            '
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.Border.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Red
            Me.chartControl1.Legend.ColumnsCount = 3
            Me.chartControl1.Legend.FloatingAutoSize = False
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartControl1.Legend.Location = New System.Drawing.Point(269, 54)
            Me.chartControl1.Legend.OnlyColumnsForFloating = False
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.ShowBorder = True
            Me.chartControl1.Legend.Size = New System.Drawing.Size(83, 43)
            Me.chartControl1.Legend.Text = "Legend"
            Me.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside
            Me.chartControl1.Location = New System.Drawing.Point(7, 10)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryXAxis.DateTimeFormat = ""
            Me.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            Me.chartControl1.PrimaryXAxis.GridLineType.Width = 0.0!
            Me.chartControl1.PrimaryXAxis.HidePartialLabels = True
            Me.chartControl1.PrimaryXAxis.Origin = 34704
            Me.chartControl1.PrimaryXAxis.OriginDate = New Date(1995, 1, 5, 0, 0, 0, 0)
            Me.chartControl1.PrimaryXAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(1990, 2010, 5)
            Me.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryXAxis.Title = "Year"
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3
            Me.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.Range = New Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 100, 10)
            Me.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.[Set]
            Me.chartControl1.PrimaryYAxis.Title = "Sales Percentage"
            Me.chartControl1.ShadowColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.None, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(217, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(217, Byte), Integer)))
            Me.chartControl1.ShadowWidth = 2
            Me.chartControl1.Size = New System.Drawing.Size(621, 398)
            Me.chartControl1.TabIndex = 18
            '
            '
            '
            Me.chartControl1.Title.Name = "Default"
            Me.chartControl1.Titles.Add(Me.chartTitle1)
            '
            'chartTitle1
            '
            Me.chartTitle1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.chartTitle1.Name = "chartTitle1"
            Me.chartTitle1.Text = "Car Sales"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(640, 417)
            Me.Controls.Add(Me.chartControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Multiple Chart Legends"
            Me.chartControl1.ResumeLayout(False)
            Me.chartControl1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

#Region "Form's Constructor And Dispose"

        Public Sub New()
            InitializeComponent()
            Me.InitializeData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Not components Is Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
#End Region

#Region "InitializeData"
        Protected Sub InitializeData()

            ' "Add Series"

            Dim color1 As Color() = New Color() {Color.FromArgb(41, 88, 145), Color.FromArgb(118, 178, 249), Color.FromArgb(41, 88, 145)}
            Dim color2 As Color() = New Color() {Color.FromArgb(123, 156, 56), Color.FromArgb(211, 247, 131), Color.FromArgb(123, 156, 56)}
            Dim color3 As Color() = New Color() {Color.FromArgb(149, 44, 41), Color.FromArgb(251, 120, 116), Color.FromArgb(149, 44, 41)}
            Dim color4 As Color() = New Color() {Color.FromArgb(209, 115, 114), Color.FromArgb(255, 194, 191), Color.FromArgb(209, 115, 114)}
            Dim color5 As Color() = New Color() {Color.FromArgb(39, 133, 158), Color.FromArgb(133, 230, 254), Color.FromArgb(39, 133, 158)}
            Dim color6 As Color() = New Color() {Color.FromArgb(203, 108, 30), Color.FromArgb(254, 196, 101), Color.FromArgb(203, 108, 30)}
            Dim color8 As Color() = New Color() {Color.FromArgb(116, 147, 51), Color.FromArgb(194, 229, 121), Color.FromArgb(116, 147, 51)}
            Dim color9 As Color() = New Color() {Color.FromArgb(88, 62, 120), Color.FromArgb(182, 147, 223), Color.FromArgb(88, 62, 120)}
            Dim series5 As ChartSeries = New ChartSeries()
            series5.Name = "Model3_Blue"
            series5.Text = "Blue"
            series5.Points.Add(1995, 30)
            series5.Points.Add(2000, 55)
            series5.Points.Add(2005, 80)
            series5.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series5.Style.ImageIndex = 4
            series5.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color5)
            series5.Style.Border.Color = Color.FromArgb(48, 98, 112)
            series5.Type = ChartSeriesType.Spline
            series5.Style.Border.Width = 3
            series5.Style.Symbol.Shape = ChartSymbolShape.Circle
            series5.Style.Symbol.Color = Color.White
            series5.Style.Symbol.Border.Color = Color.FromArgb(39, 133, 158)
            series5.Style.Symbol.Border.Width = 3
            series5.Style.Border.Width = 3
            chartControl1.Series.Add(series5)

            Dim series6 As ChartSeries = New ChartSeries()
            series6.Name = "Model3_Green"
            series6.Text = "Orange"
            series6.Points.Add(1995, 50)
            series6.Points.Add(2000, 43)
            series6.Points.Add(2005, 65)
            series6.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series6.Style.ImageIndex = 5
            series6.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color6)
            series6.Style.Border.Color = Color.FromArgb(240, 139, 47)
            series6.Type = ChartSeriesType.Line
            series6.Style.Border.Width = 3
            series6.Style.Symbol.Shape = ChartSymbolShape.Circle
            series6.Style.Symbol.Color = Color.White
            series6.Style.Symbol.Border.Color = Color.FromArgb(203, 108, 30)
            series6.Style.Symbol.Border.Width = 3
            chartControl1.Series.Add(series6)

            Dim series7 As ChartSeries = New ChartSeries()
            series7.Name = "Model4_Blue"
            series7.Text = "Green"
            series7.Points.Add(1995, 43)
            series7.Points.Add(2000, 62)
            series7.Points.Add(2005, 60)
            series7.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series7.Style.ImageIndex = 6
            series7.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color8)
            series7.Style.Border.Color = Color.FromArgb(106, 127, 64)
            series7.Type = ChartSeriesType.Line
            series7.Style.Border.Width = 3
            series7.Style.Symbol.Shape = ChartSymbolShape.Circle
            series7.Style.Symbol.Color = Color.White
            series7.Style.Symbol.Border.Color = Color.FromArgb(116, 147, 51)
            series7.Style.Symbol.Border.Width = 3
            chartControl1.Series.Add(series7)

            Dim series8 As ChartSeries = New ChartSeries()
            series8.Name = "Model4_Blue"
            series8.Text = "Purple"
            series8.Points.Add(1995, 48)
            series8.Points.Add(2000, 71)
            series8.Points.Add(2005, 66)
            series8.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series8.Style.ImageIndex = 7
            series8.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color9)
            series8.Style.Border.Color = Color.FromArgb(75, 61, 92)
            series8.Type = ChartSeriesType.Spline
            series8.Style.Border.DashStyle = DashStyle.DashDotDot
            series8.Style.Border.Width = 3
            chartControl1.Series.Add(series8)

            Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "Model1_Blue"
            series1.Text = "Blue"
            series1.Points.Add(1995, 40)
            series1.Points.Add(2000, 60)
            series1.Points.Add(2005, 75)
            series1.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series1.Style.ImageIndex = 0
            series1.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color1)
            series1.Style.Border.Color = Color.FromArgb(49, 73, 102)
            chartControl1.Series.Add(series1)

            Dim series2 As ChartSeries = New ChartSeries()
            series2.Name = "Model1_Green"
            series2.Text = "Green"
            series2.Points.Add(1995, 35)
            series2.Points.Add(2000, 70)
            series2.Points.Add(2005, 45)
            series2.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series2.Style.ImageIndex = 1
            series2.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color2)
            series2.Style.Border.Color = Color.FromArgb(151, 188, 75)
            chartControl1.Series.Add(series2)

            Dim series3 As ChartSeries = New ChartSeries()
            series3.Name = "Model2_Blue"
            series3.Text = "Red"
            series3.Points.Add(1995, 60)
            series3.Points.Add(2000, 35)
            series3.Points.Add(2005, 55)
            series3.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series3.Style.ImageIndex = 2
            series3.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color3)
            series3.Style.Border.Color = Color.FromArgb(110, 68, 67)
            chartControl1.Series.Add(series3)

            Dim series4 As ChartSeries = New ChartSeries()
            series4.Name = "Model2_Green"
            series4.Text = "Pink"
            series4.Points.Add(1995, 45)
            series4.Points.Add(2000, 50)
            series4.Points.Add(2005, 35)
            series4.Style.Images = New ChartImageCollection(Me.imageListAdv1.Images)
            series4.Style.ImageIndex = 3
            series4.Style.Interior = New Syncfusion.Drawing.BrushInfo(GradientStyle.Horizontal, color4)
            series4.Style.Border.Color = Color.FromArgb(169, 119, 118)
            chartControl1.Series.Add(series4)
            Me.chartControl1.ShowLegend = False

            ' "Add Legend"
            Dim legend1 As ChartLegend = New ChartLegend(chartControl1)
            Dim legend2 As ChartLegend = New ChartLegend(chartControl1)
            Dim legend3 As ChartLegend = New ChartLegend(chartControl1)
            Dim legend5 As ChartLegend = New ChartLegend(chartControl1)
            Dim legend6 As ChartLegend = New ChartLegend(chartControl1)

            legend1.Name = "legend1"
            legend2.Name = "legend2"
            legend3.Name = "legend3"
            legend5.Name = "legend5"
            legend6.Name = "legend6"

            legend1.Text = "Zen"
            legend2.Text = "Ford"
            legend3.Text = "Sedan"
            legend5.Text = "MobileHome"
            legend6.Text = "Oldtimer"
            legend1.Spacing = 2
            legend2.Spacing = 2
            legend3.Spacing = 2
            legend5.Spacing = 2
            legend6.Spacing = 2

            chartControl1.Legends.Add(legend1)
            chartControl1.Legends.Add(legend2)
            chartControl1.Legends.Add(legend3)
            chartControl1.Legends.Add(legend5)
            chartControl1.Legends.Add(legend6)

            series1.LegendName = "legend1"
            series2.LegendName = "legend1"
            series3.LegendName = "legend2"
            series4.LegendName = "legend2"
            series5.LegendName = "legend3"
            series6.LegendName = "legend3"
            series7.LegendName = "legend5"
            series8.LegendName = "legend6"

            Me.chartControl1.LegendsPlacement = ChartPlacement.Outside

            '		 #End Region

            '		#Region "AutoHighlight"
            Me.chartControl1.AutoHighlight = True
            For Each series As ChartSeries In Me.chartControl1.Series
                Dim highlightcolor As Color() = New Color() {Color.FromArgb(255, 204, 68), Color.FromArgb(254, 234, 180), Color.FromArgb(250, 186, 13)}
                series.Style.HighlightInterior = New BrushInfo(GradientStyle.Horizontal, highlightcolor)
            Next series
            Me.chartControl1.Refresh()
            '		#End Region

            '		#Region "Legend Settings"
            For Each chartLegend As ChartLegend In Me.chartControl1.Legends
                If chartLegend.Name = "legend1" OrElse chartLegend.Name = "legend2" OrElse chartLegend.Name = "legend3" Then
                    chartLegend.Position = ChartDock.Bottom
                End If

                If chartLegend.Name = "legend5" Then
                    chartLegend.Position = ChartDock.Left
                End If

                If chartLegend.Name = "legend6" Then
                    chartLegend.Position = ChartDock.Right
                End If

                chartLegend.RepresentationType = ChartLegendRepresentationType.SeriesImage
                chartLegend.Font = New Font("Tahoma", 7.5F, FontStyle.Bold)
                chartLegend.ForeColor = Color.FromArgb(23, 83, 120)
                chartLegend.BackInterior = New BrushInfo(GradientStyle.Vertical, legendColor)
                chartLegend.ShowBorder = True
                chartLegend.Border.ForeColor = Color.FromArgb(143, 192, 223)
                chartLegend.Border.Width = 1


                For Each cli As ChartLegendItem In chartLegend.Items
                    cli.Font = New Font("Vedana", 8.0F, FontStyle.Regular)
                    cli.TextColor = Color.Black
                    cli.RepresentationSize = New Size(32, 32)
                Next cli

                Me.chartControl1.DockingManager.LayoutMode = ChartLayoutMode.Wrap
                Me.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
            Next chartLegend
            '		#End Region

        End Sub
#End Region

#Region "Events"
        'Highlights the series point and the corresponding LegendItem.
        Private Sub chartControl1_ChartRegionMouseHover(ByVal sender As Object, ByVal e As ChartRegionMouseEventArgs) Handles chartControl1.ChartRegionMouseHover

            For Each chartLegend As ChartLegend In Me.chartControl1.Legends
                chartLegend.BackInterior = New BrushInfo(GradientStyle.Vertical, legendColor)
                For Each cli As ChartLegendItem In chartLegend.Items
                    cli.Font = New Font("Vedana", 8.0F, FontStyle.Regular)
                    cli.TextColor = Color.Black
                Next cli
            Next chartLegend
            If e.Region.SeriesIndex > -1 Then
                chartControl1.Legends(Me.chartControl1.Series(e.Region.SeriesIndex).LegendName).BackInterior = New BrushInfo(GradientStyle.Vertical, legendHighlightColor)
                Me.chartControl1.Series(e.Region.SeriesIndex).LegendItem.Font = New Font("Vedana", 7.0F, FontStyle.Bold)
                Me.chartControl1.Series(e.Region.SeriesIndex).LegendItem.TextColor = Color.FromArgb(44, 127, 179)

            End If

        End Sub
#End Region
    End Class
End Namespace