Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing

Namespace ChartDataBinding
	Public partial Class Form1 : Inherits Office2007Form
		#Region "Members"
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private label2 As System.Windows.Forms.Label
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private WithEvents btnTop3 As Syncfusion.Windows.Forms.ButtonAdv
		Private components As System.ComponentModel.IContainer = Nothing
		#End Region

		Public Sub New()
			InitializeComponent()
			'Setup a database.
			PopulationDataService.PopulateDataBase()
		End Sub

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.label2 = New System.Windows.Forms.Label
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.btnTop3 = New Syncfusion.Windows.Forms.ButtonAdv
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.White, System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(1, 4, 5, 1)
            Me.chartControl1.ElementsSpacing = 0
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(194, 52)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.Spacing = 3
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(15, 6)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.SystemColors.ControlText
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray
            Me.chartControl1.Size = New System.Drawing.Size(417, 326)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "Binding To Linq Datasource"
            '
            '
            '
            Me.chartControl1.Title.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.Title.Name = "Default"
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
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(0, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(158, 156)
            Me.label2.TabIndex = 4
            Me.label2.Text = resources.GetString("label2.Text")
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.White
            Me.gradientPanel1.BorderColor = System.Drawing.Color.White
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.gradientPanel2)
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.gradientPanel1.Location = New System.Drawing.Point(438, 0)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(184, 338)
            Me.gradientPanel1.TabIndex = 7
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(206, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.btnTop3)
            Me.gradientPanel2.Controls.Add(Me.label2)
            Me.gradientPanel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientPanel2.Location = New System.Drawing.Point(11, 62)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(160, 215)
            Me.gradientPanel2.TabIndex = 6
            '
            'btnTop3
            '
            Me.btnTop3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.btnTop3.KeepFocusRectangle = False
            Me.btnTop3.Location = New System.Drawing.Point(18, 171)
            Me.btnTop3.Name = "btnTop3"
            Me.btnTop3.Size = New System.Drawing.Size(116, 23)
            Me.btnTop3.TabIndex = 7
            Me.btnTop3.Text = "Filter Top 3 Cities"
            Me.btnTop3.UseVisualStyle = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(622, 338)
            Me.Controls.Add(Me.gradientPanel1)
            Me.Controls.Add(Me.chartControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "LINQ DataSource"
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

		#End Region

		#Region "Main Function"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "Dispose"
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
		#End Region

		#Region "InitializeChart"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            'Bind the chart to a datasource that contains the entire records from the database.
            Me.BindChart(PopulationDataService.GetCompleteList())
        End Sub
		#End Region

		#Region "Update ChartDataRange"
		Private Sub btnTop3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnTop3.Click
			'Filter the records based on a constraint and bound them to the chart control.
			Dim datasource As Object = PopulationDataService.GetFilteredData()
			'Refresh the chart with the above datasource.
			Me.BindChart(datasource)
		End Sub
		#End Region

		#Region "ChartDataBinding"
		'This method binds the chart to a given datasource.
		Private Sub BindChart(ByVal populations As Object)
			Me.chartControl1.Series.Clear()

			Dim series As ChartSeries = New ChartSeries("Populations")
			Dim dataSeriesModel As ChartDataBindModel = New ChartDataBindModel(populations)

			' If ChartDataBindModel.XName is empty or null, X value is index of point.
			dataSeriesModel.YNames = New String() { "Population" }

            series.SeriesModel = dataSeriesModel
            series.Style.Border.Color = Color.Transparent
            Dim dataLabelsModel As ChartDataBindAxisLabelModel = New ChartDataBindAxisLabelModel(populations)
            dataLabelsModel.LabelName = "City"
			chartControl1.Series.Add(series)
            chartControl1.PrimaryXAxis.LabelsImpl = dataLabelsModel
		End Sub
#End Region
		
	End Class
End Namespace
