Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms

Namespace CustomDataBinding
	Public Class Form1 : Inherits Office2007Form
		#Region "Members"
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tabPage2 As System.Windows.Forms.TabPage
		Private chartControl2 As ChartControl
		Private panel1 As System.Windows.Forms.Panel
		Private label1 As Label
		Private WithEvents btnAddEntry As ButtonAdv
		Private txtPopulation As TextBox
		Private txtCountry As TextBox
		Private label3 As Label
		Private label2 As Label
		Private components As System.ComponentModel.IContainer = Nothing
		#End Region

		#Region "PopulationData"
		''' <summary>
		''' User - defined class to store population details of different cities/countries. This will act as a datasource for chart.
		''' </summary>
		Private Class PopulationData
			Private cname As String
			Private population_Renamed As Double

			''' <summary>
			''' Create a population object given the name of a city/country and its population value.
			''' </summary>
			''' <param name="cname">City or Country Name</param>
			''' <param name="population">Population in millions</param>
'INSTANT VB NOTE: The parameter population was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
			Public Sub New(ByVal cname As String, ByVal population_Renamed As Double)
				Me.cname = cname
				Me.population_Renamed = population_Renamed
			End Sub

			''' <summary>
			''' Gets or sets the name of a city or country.
			''' </summary>
			Public Property Name() As String
				Get
					Return cname
				End Get
				Set
					cname = Value
				End Set
			End Property

			''' <summary>
			''' Gets or sets the population of a city or country.
			''' </summary>
			Public Property Population() As Double
				Get
					Return population_Renamed
				End Get
				Set
					population_Renamed = Value
				End Set
			End Property
		End Class
		#End Region

		#Region "FormConstructor"
		Public Sub New()
			InitializeComponent()
			BindChartToBindingList()
            BindChartToArrayList()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
            ChartAppearance.ApplyChartStyles1(Me.chartControl2)
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.tabControl1 = New System.Windows.Forms.TabControl
            Me.tabPage1 = New System.Windows.Forms.TabPage
            Me.panel1 = New System.Windows.Forms.Panel
            Me.btnAddEntry = New Syncfusion.Windows.Forms.ButtonAdv
            Me.txtPopulation = New System.Windows.Forms.TextBox
            Me.txtCountry = New System.Windows.Forms.TextBox
            Me.label3 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.chartControl2 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.tabPage2 = New System.Windows.Forms.TabPage
            Me.tabControl1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.tabPage2.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent)
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(1, 5, 5, 5)
            Me.chartControl1.ElementsSpacing = 8
            Me.chartControl1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            '
            '
            Me.chartControl1.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(64, 56)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top
            Me.chartControl1.Legend.Spacing = 3
            Me.chartControl1.Legend.Visible = False
            Me.chartControl1.Location = New System.Drawing.Point(17, 16)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PrimaryXAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl1.PrimaryXAxis.HidePartialLabels = True
            Me.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl1.PrimaryXAxis.Title = "City"
            Me.chartControl1.PrimaryYAxis.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl1.PrimaryYAxis.ForceZero = True
            Me.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl1.PrimaryYAxis.Title = "Population (Million)"
            Me.chartControl1.Size = New System.Drawing.Size(487, 421)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "City Population"
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
            'tabControl1
            '
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabControl1.HotTrack = True
            Me.tabControl1.Location = New System.Drawing.Point(0, 0)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(529, 475)
            Me.tabControl1.TabIndex = 1
            '
            'tabPage1
            '
            Me.tabPage1.BackColor = System.Drawing.Color.White
            Me.tabPage1.Controls.Add(Me.panel1)
            Me.tabPage1.Controls.Add(Me.chartControl2)
            Me.tabPage1.Location = New System.Drawing.Point(4, 22)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Size = New System.Drawing.Size(521, 449)
            Me.tabPage1.TabIndex = 1
            Me.tabPage1.Text = "BindingList Datasource"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.btnAddEntry)
            Me.panel1.Controls.Add(Me.txtPopulation)
            Me.panel1.Controls.Add(Me.txtCountry)
            Me.panel1.Controls.Add(Me.label3)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(521, 113)
            Me.panel1.TabIndex = 2
            '
            'btnAddEntry
            '
            Me.btnAddEntry.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.btnAddEntry.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnAddEntry.ForeColor = System.Drawing.Color.MidnightBlue
            Me.btnAddEntry.KeepFocusRectangle = False
            Me.btnAddEntry.Location = New System.Drawing.Point(269, 60)
            Me.btnAddEntry.Name = "btnAddEntry"
            Me.btnAddEntry.Size = New System.Drawing.Size(137, 36)
            Me.btnAddEntry.TabIndex = 6
            Me.btnAddEntry.Text = "Add To Datasource"
            Me.btnAddEntry.UseVisualStyle = True
            '
            'txtPopulation
            '
            Me.txtPopulation.Location = New System.Drawing.Point(130, 83)
            Me.txtPopulation.Name = "txtPopulation"
            Me.txtPopulation.Size = New System.Drawing.Size(116, 21)
            Me.txtPopulation.TabIndex = 5
            '
            'txtCountry
            '
            Me.txtCountry.Location = New System.Drawing.Point(130, 57)
            Me.txtCountry.Name = "txtCountry"
            Me.txtCountry.Size = New System.Drawing.Size(116, 21)
            Me.txtCountry.TabIndex = 4
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Location = New System.Drawing.Point(34, 83)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(71, 13)
            Me.label3.TabIndex = 3
            Me.label3.Text = "Population:"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Location = New System.Drawing.Point(34, 60)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(95, 13)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Country Name:"
            '
            'label1
            '
            Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Location = New System.Drawing.Point(26, 10)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(469, 44)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Essential Chart can listen to changes in BindingList data sources and can update " & _
                "itself automatically. To check this feature, try adding a new entry to the Bindi" & _
                "ngList."
            '
            'chartControl2
            '
            Me.chartControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.chartControl2.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl2.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 5, 5)
            Me.chartControl2.ElementsSpacing = 5
            '
            '
            '
            Me.chartControl2.Legend.ItemsSize = New System.Drawing.Size(15, 15)
            Me.chartControl2.Legend.Location = New System.Drawing.Point(60, 47)
            Me.chartControl2.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Left
            Me.chartControl2.Legend.Spacing = 3
            Me.chartControl2.Legend.Visible = False
            Me.chartControl2.Location = New System.Drawing.Point(11, 132)
            Me.chartControl2.Name = "chartControl2"
            Me.chartControl2.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.DefaultOld
            Me.chartControl2.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl2.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl2.PrimaryXAxis.Title = "Country"
            Me.chartControl2.PrimaryYAxis.ForceZero = True
            Me.chartControl2.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl2.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue
            Me.chartControl2.PrimaryYAxis.Title = "Population (Million)"
            Me.chartControl2.Size = New System.Drawing.Size(497, 303)
            Me.chartControl2.TabIndex = 0
            Me.chartControl2.Text = "Country Population"
            '
            '
            '
            Me.chartControl2.Title.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chartControl2.Title.Name = "Default"
            Me.chartControl2.Titles.Add(Me.chartControl2.Title)
            '
            'tabPage2
            '
            Me.tabPage2.BackColor = System.Drawing.Color.White
            Me.tabPage2.Controls.Add(Me.chartControl1)
            Me.tabPage2.Location = New System.Drawing.Point(4, 22)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Size = New System.Drawing.Size(521, 449)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "ArrayList Datasource"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(529, 475)
            Me.Controls.Add(Me.tabControl1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Custom Collections"
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.tabPage2.ResumeLayout(False)
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

		#Region "InitializeChartData"

		Private bindList As BindingList(Of PopulationData)
		Private Sub BindChartToBindingList()
			'Datasource implements IBindingList interface. 
			bindList = New BindingList(Of PopulationData)()
			bindList.Add(New PopulationData("Indonesia", 341))
			bindList.Add(New PopulationData("India", 660))
			bindList.Add(New PopulationData("USA", 595))
			bindList.Add(New PopulationData("Nigeria", 248))
			bindList.Add(New PopulationData("China", 806))
			bindList.Add(New PopulationData("Bangladesh", 544))

			Dim series As ChartSeries = New ChartSeries("Populations")

			'Bind the above list to the chart control.
			Dim dataSeriesModel As ChartDataBindModel = New ChartDataBindModel(bindList)

			' If ChartDataBindModel.XName is empty or null, X value is index of point.
			dataSeriesModel.YNames = New String() { "Population" }
			series.SeriesModel = dataSeriesModel

            UpdateChartLabels()
            chartControl2.Series.Add(series)
		End Sub

		Private Sub UpdateChartLabels()
			'Setup a datasource for chart axis and populate axis labels.
			Dim dataLabelsModel As ChartDataBindAxisLabelModel = New ChartDataBindAxisLabelModel(bindList)
			dataLabelsModel.LabelName = "Name"
			chartControl2.PrimaryXAxis.LabelsImpl = dataLabelsModel
		End Sub

		Private Sub BindChartToArrayList()
			' Data source implements IList or IListSource interface.
			'Create an array of PopulationData objects.
			Dim populations As ArrayList = New ArrayList()
			populations.Add(New PopulationData("New York", 13))
			populations.Add(New PopulationData("Houston", 11))
			populations.Add(New PopulationData("Tokyo", 17))
			populations.Add(New PopulationData("London", 12))
			populations.Add(New PopulationData("Chicago", 10))
			populations.Add(New PopulationData("Phoneix", 14))

			Dim series As ChartSeries = New ChartSeries("Populations")

			'Bind the above array to the chart control.
			Dim dataSeriesModel As ChartDataBindModel = New ChartDataBindModel(populations)

			' If ChartDataBindModel.XName is empty or null, X value is index of point.
			dataSeriesModel.YNames = New String() { "Population" }
			series.SeriesModel = dataSeriesModel

			'Setup a datasource for chart axis and populate axis labels.
			Dim dataLabelsModel As ChartDataBindAxisLabelModel = New ChartDataBindAxisLabelModel(populations)
			dataLabelsModel.LabelName = "Name"

			chartControl1.Series.Add(series)
			chartControl1.PrimaryXAxis.LabelsImpl = dataLabelsModel

			chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode
			chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows
			Me.chartControl1.PrimaryYAxis.Range = New MinMaxInfo(8, 18, 2)
		End Sub

#End Region

		#Region "ChangeListData"
		Private Sub btnAddEntry_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddEntry.Click
			If txtCountry.Text <> "" AndAlso txtPopulation.Text <> "" Then
				bindList.Add(New PopulationData(txtCountry.Text, Double.Parse(txtPopulation.Text.ToString())))
			End If
			UpdateChartLabels()
		End Sub
		#End Region
	End Class
End Namespace