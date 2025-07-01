#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports System.Collections.Generic

Namespace Syncfusion.Windows.Forms.Chart.Samples
	''' <summary>
	''' The ChartControl sample form.
	''' </summary>
	Public Class FormMain
		Inherits Office2007Form
		Private WithEvents chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private designerPanel1 As DesignerPanel
		Private WithEvents buttonAdv3 As ButtonAdv
		Private WithEvents buttonAdv2 As ButtonAdv
		Private WithEvents buttonAdv1 As ButtonAdv
		Private WithEvents buttonAdv4 As ButtonAdv
		Private WithEvents checkBox1 As CheckBox
		Private components As IContainer
        Private color1, color2, color3, color4, color5, color6, color7, color8 As Color()
        Private WithEvents CheckBox2 As System.Windows.Forms.CheckBox

		#Region "Form's  Constructor, Main And Dispose"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
		End Sub
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.Run(New FormMain())
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Dim ChartToolBarSaveItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem
            Dim ChartToolBarCopyItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem
            Dim ChartToolBarPrintItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem
            Dim ChartToolBarPrintPreviewItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem
            Dim ChartToolBarSplitter1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter = New Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter
            Dim ChartToolBarPaletteItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem
            Dim ChartToolBarStyleItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem
            Dim ChartToolBarTypeItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem
            Dim ChartToolBarSeries3DItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem
            Dim ChartToolBarShowLegendItem1 As Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem = New Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.designerPanel1 = New DesignerPanel
            Me.CheckBox2 = New System.Windows.Forms.CheckBox
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.buttonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.designerPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.Blue
            Me.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent)
            Me.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(40, 10, 40, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(88, 402)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(157, 21)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m"
            Me.chartControl1.Size = New System.Drawing.Size(545, 479)
            Me.chartControl1.TabIndex = 2
            Me.chartControl1.Text = "Students Admission Statistics - Pie Chart"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.Margin = 2
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "Students Admission Statistics - Pie Chart"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSaveItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarCopyItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPrintPreviewItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSplitter1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarPaletteItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarStyleItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarTypeItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarSeries3DItem1)
            Me.chartControl1.ToolBar.Items.Add(ChartToolBarShowLegendItem1)
            Me.chartControl1.ZoomOutIncrement = 1.5
            '
            'designerPanel1
            '
            Me.designerPanel1.BackColor = System.Drawing.Color.White
            Me.designerPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(237, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(242, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(243, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(245, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))})
            Me.designerPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.designerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.designerPanel1.Controls.Add(Me.CheckBox2)
            Me.designerPanel1.Controls.Add(Me.buttonAdv1)
            Me.designerPanel1.Controls.Add(Me.checkBox1)
            Me.designerPanel1.Controls.Add(Me.buttonAdv4)
            Me.designerPanel1.Controls.Add(Me.buttonAdv3)
            Me.designerPanel1.Controls.Add(Me.buttonAdv2)
            Me.designerPanel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.designerPanel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.designerPanel1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.designerPanel1.HeaderImage = Nothing
            Me.designerPanel1.HeaderText = "       Chart Type"
            Me.designerPanel1.Location = New System.Drawing.Point(0, 0)
            Me.designerPanel1.Name = "designerPanel1"
            Me.designerPanel1.Size = New System.Drawing.Size(139, 516)
            Me.designerPanel1.TabIndex = 3
            '
            'CheckBox2
            '
            Me.CheckBox2.AutoSize = True
            Me.CheckBox2.Location = New System.Drawing.Point(7, 464)
            Me.CheckBox2.Name = "CheckBox2"
            Me.CheckBox2.Size = New System.Drawing.Size(135, 18)
            Me.CheckBox2.TabIndex = 5
            Me.CheckBox2.Text = "PieWithSameRadius"
            Me.CheckBox2.UseVisualStyleBackColor = True
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv1.Image = CType(resources.GetObject("buttonAdv1.Image"), System.Drawing.Image)
            Me.buttonAdv1.Location = New System.Drawing.Point(28, 50)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(80, 80)
            Me.buttonAdv1.TabIndex = 1
            Me.buttonAdv1.Text = "Pie"
            Me.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.buttonAdv1.UseVisualStyle = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Location = New System.Drawing.Point(7, 440)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(78, 18)
            Me.checkBox1.TabIndex = 4
            Me.checkBox1.Text = "Enable 3D"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'buttonAdv4
            '
            Me.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv4.Image = CType(resources.GetObject("buttonAdv4.Image"), System.Drawing.Image)
            Me.buttonAdv4.Location = New System.Drawing.Point(26, 147)
            Me.buttonAdv4.Name = "buttonAdv4"
            Me.buttonAdv4.Size = New System.Drawing.Size(80, 80)
            Me.buttonAdv4.TabIndex = 4
            Me.buttonAdv4.Text = "Doughnut"
            Me.buttonAdv4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.buttonAdv4.UseVisualStyle = True
            '
            'buttonAdv3
            '
            Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv3.Image = CType(resources.GetObject("buttonAdv3.Image"), System.Drawing.Image)
            Me.buttonAdv3.Location = New System.Drawing.Point(26, 344)
            Me.buttonAdv3.Name = "buttonAdv3"
            Me.buttonAdv3.Size = New System.Drawing.Size(80, 80)
            Me.buttonAdv3.TabIndex = 3
            Me.buttonAdv3.Text = "Pyramid"
            Me.buttonAdv3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.buttonAdv3.UseVisualStyle = True
            '
            'buttonAdv2
            '
            Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv2.Image = CType(resources.GetObject("buttonAdv2.Image"), System.Drawing.Image)
            Me.buttonAdv2.Location = New System.Drawing.Point(26, 246)
            Me.buttonAdv2.Name = "buttonAdv2"
            Me.buttonAdv2.Size = New System.Drawing.Size(80, 80)
            Me.buttonAdv2.TabIndex = 2
            Me.buttonAdv2.Text = "Funnel"
            Me.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.buttonAdv2.UseVisualStyle = True
            '
            'FormMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(716, 516)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.designerPanel1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "FormMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Divide Area"
            CType(Me.designerPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.designerPanel1.ResumeLayout(False)
            Me.designerPanel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Form Load"
		Private Sub FormMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)

		End Sub
#End Region

		#Region "InitializeChartData"
		''' <summary>
		''' Initializes the ChartControl's data and sets the Chart type
		''' </summary>
		Protected Sub InitializeChartData()
			Dim random As Random = New Random()
			Dim series1 As ChartSeries = New ChartSeries()
            series1.Name = "Year 2004" + Constants.vbLf + "Details"
			series1.Text = series1.Name
            series1.Points.Add(0, 10)
			series1.Points.Add(2, 8)
			series1.Points.Add(3, 11)
			series1.Points.Add(4, 23)
			series1.Points.Add(5, 24)
			series1.Points.Add(6, 10)
			series1.Points.Add(7, 24)
			SeriesSettings(series1)
            Me.chartControl1.Series.Add(series1)
            series1.ConfigItems.PieItem.ShowSeriesTitle = True

			Dim series2 As ChartSeries = New ChartSeries()
			series2.Name = "Year 2005"
			series2.Text = series2.Name
            series2.Points.Add(0, 12)
			series2.Points.Add(2, 11)
			series2.Points.Add(3, 8)
			series2.Points.Add(4, 25)
			series2.Points.Add(5, 22)
			series2.Points.Add(6, 13)
			series2.Points.Add(7, 22)
			SeriesSettings(series2)
            Me.chartControl1.Series.Add(series2)
            series2.ConfigItems.PieItem.ShowSeriesTitle = True

			Dim series3 As ChartSeries = New ChartSeries()
			series3.Name = "Year 2006"
			series3.Text = series3.Name
            series3.Points.Add(0, 8)
			series3.Points.Add(2, 12)
			series3.Points.Add(3, 8)
			series3.Points.Add(4, 21)
			series3.Points.Add(5, 26)
			series3.Points.Add(6, 12)
			series3.Points.Add(7, 26)
			SeriesSettings(series3)
            Me.chartControl1.Series.Add(series3)
            series3.ConfigItems.PieItem.ShowSeriesTitle = True

			Dim series4 As ChartSeries = New ChartSeries()
			series4.Name = "Year 2007"
			series4.Text = series4.Name
            series4.Points.Add(0, 10)
			series4.Points.Add(2, 9)
			series4.Points.Add(3, 9)
			series4.Points.Add(4, 20)
			series4.Points.Add(5, 23)
			series4.Points.Add(6, 9)
			series4.Points.Add(7, 19)
			SeriesSettings(series4)
            Me.chartControl1.Series.Add(series4)
            series4.ConfigItems.PieItem.ShowSeriesTitle = True

			Me.chartControl1.ChartArea.DivideArea = True

			Dim chartLegend As ChartLegend = New ChartLegend()
			chartLegend.Name = "Legend 1"
			Dim label As String() = New String() { "Engineering", "Medical Sciences", "BioTechnology", "Information Services", "Art and Humanities", "Geography", "Economics" }
			Dim items As List(Of ChartLegendItem) = New List(Of ChartLegendItem)()
			For i As Integer = 0 To 6
				Dim legendItem As ChartLegendItem = New ChartLegendItem(label(i))
				legendItem.Font = New Font("Verdana", 7, FontStyle.Regular)
				legendItem.RepresentationSize = New Size(16, 16)
				legendItem.TextColor = Color.MidnightBlue
				items.Add(legendItem)
			Next i
			chartControl1.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType

			chartControl1.Legend.CustomItems = items.ToArray()
			chartControl1.Legend.RowsCount = 2
			Me.chartControl1.LegendAlignment = ChartAlignment.Center
			Me.chartControl1.LegendPosition = ChartDock.Bottom
			Me.chartControl1.LegendsPlacement = ChartPlacement.Outside
			Me.chartControl1.ShowLegend = True
			Me.chartControl1.SmoothingMode = SmoothingMode.AntiAlias
		End Sub

		Protected Sub SeriesSettings(ByVal series As ChartSeries)
			Dim newSeries As ChartSeries = series
			newSeries.Style.DisplayText = True

			newSeries.Type = ChartSeriesType.Pie

			newSeries.Style.TextColor = Color.MidnightBlue
			newSeries.Style.Font.Bold = True
			newSeries.Style.Font.Size = 7

			newSeries.LegendName = "Legend 1"
			AddHandler newSeries.PrepareStyle, AddressOf series1_PrepareStyle

			For i As Integer = 0 To 6
				series.Styles(i).Font.Size = 7f
				series.Styles(i).TextFormat = String.Format("{0}%", series.Points(i).YValues(0))
			Next i
		End Sub
		#End Region

		#Region "Events"
		#Region "Series_PrepareStyle"
		''' <summary>
		''' Handler for the PrepareStyle event of ChartSeries. 
		''' </summary>
		''' <param name="sender">The ChartSeries object that raises this event.</param>
		''' <param name="args">The event data. Can be modified to change series appearance.</param>
		Private Sub series1_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
			Dim series As ChartSeries = TryCast(sender, ChartSeries)
            series.ConfigItems.PieItem.PieType = ChartPieType.OutSide
            series.Style.Border.Color = Color.SlateGray

            If Not series Is Nothing Then
                color1 = New Color() {Color.FromArgb(175, 130, 181, 182)}
                color2 = New Color() {Color.FromArgb(175, 206, 215, 41)}
                color3 = New Color() {Color.FromArgb(175, 250, 206, 35)}
                color4 = New Color() {Color.FromArgb(175, 155, 166, 184)}
                color5 = New Color() {Color.FromArgb(175, 9, 116, 210)}
                color6 = New Color() {Color.FromArgb(175, 191, 192, 98)}
                color7 = New Color() {Color.FromArgb(175, 234, 90, 81)}
                color8 = New Color() {Color.FromArgb(175, 191, 192, 98)}

                If args.Index = 0 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.None, color1)
                    Me.chartControl1.Legend.Items(0).Interior = New BrushInfo(GradientStyle.None, color1)
                ElseIf args.Index = 1 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.None, color2)
                    Me.chartControl1.Legend.Items(1).Interior = New BrushInfo(GradientStyle.None, color2)
                ElseIf args.Index = 2 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.None, color6)
                    Me.chartControl1.Legend.Items(2).Interior = New BrushInfo(GradientStyle.None, color6)
                ElseIf args.Index = 3 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.None, color4)
                    Me.chartControl1.Legend.Items(3).Interior = New BrushInfo(GradientStyle.None, color4)
                ElseIf args.Index = 4 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.None, color5)
                    Me.chartControl1.Legend.Items(4).Interior = New BrushInfo(GradientStyle.None, color5)
                ElseIf args.Index = 5 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.None, color3)
                    Me.chartControl1.Legend.Items(5).Interior = New BrushInfo(GradientStyle.None, color3)
                ElseIf args.Index = 6 Then
                    args.Style.Interior = New BrushInfo(GradientStyle.None, color7)
                    Me.chartControl1.Legend.Items(6).Interior = New BrushInfo(GradientStyle.None, color7)
                Else
                    args.Style.Interior = New BrushInfo(GradientStyle.None, color1)
                End If
            End If
		End Sub
		#End Region

		Private rectY As Rectangle
		Private Sub chartControl1_ChartAreaPaint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles chartControl1.ChartAreaPaint
			For Each series As ChartSeries In Me.chartControl1.Series
				Dim rectX As RectangleF = Me.chartControl1.ChartArea.GetSeriesBounds(series)
				rectY = New Rectangle(Convert.ToInt16(rectX.X), Convert.ToInt16(rectX.Y), Convert.ToInt16(rectX.Width), Convert.ToInt16(rectX.Height))

				e.Graphics.DrawRectangle(New Pen(Color.MidnightBlue, 1), rectY)
			Next series
		End Sub

		#End Region

		Private Sub buttonAdv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click, buttonAdv4.Click, buttonAdv3.Click, buttonAdv2.Click
			Dim buttonAdv As ButtonAdv = TryCast(sender, ButtonAdv)
			If buttonAdv.Text = "Pie" Then
				For Each series As ChartSeries In Me.chartControl1.Series
					series.Type = ChartSeriesType.Pie
					series.ConfigItems.PieItem.ShowSeriesTitle = True

					series.ConfigItems.PieItem.DoughnutCoeficient = 0
					series.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.Outside
					Me.chartControl1.Text = "Students Admission Statistics - Pie Chart"
				Next series
			ElseIf buttonAdv.Text = "Doughnut" Then
				For Each series As ChartSeries In Me.chartControl1.Series
					series.Type = ChartSeriesType.Pie
					series.ConfigItems.PieItem.DoughnutCoeficient = 0.5f
					series.ConfigItems.PieItem.ShowSeriesTitle = True
					series.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.Outside

					Me.chartControl1.Text = "Students Admission Statistics - Doughnut Chart"
				Next series
			ElseIf buttonAdv.Text = "Funnel" Then
				For Each series As ChartSeries In Me.chartControl1.Series
					series.Type = ChartSeriesType.Funnel
					series.ConfigItems.FunnelItem.ShowSeriesTitle = True
					series.ConfigItems.FunnelItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInColumn
					series.ConfigItems.FunnelItem.FigureBase = ChartFigureBase.Square
					Me.chartControl1.Text = "Students Admission Statistics - Funnel Chart"
				Next series
			ElseIf buttonAdv.Text = "Pyramid" Then
				For Each series As ChartSeries In Me.chartControl1.Series
					series.Type = ChartSeriesType.Pyramid
					series.ConfigItems.PyramidItem.ShowSeriesTitle = True
					series.ConfigItems.PyramidItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInColumn
					series.ConfigItems.PyramidItem.FigureBase = ChartFigureBase.Square
					Me.chartControl1.Text = "Students Admission Statistics - Pyramid Chart"
				Next series
			End If

		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			Me.chartControl1.Series3D = checkBox1.Checked
		End Sub

        Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
            For Each series As ChartSeries In Me.chartControl1.Series
                series.ConfigItems.PieItem.PieWithSameRadius = CheckBox2.Checked
            Next series
        End Sub
    End Class
End Namespace