Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid

Namespace CrossSheetReference
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		#Region "Private Members"
		Private tabBarSplitterControl1 As Syncfusion.Windows.Forms.TabBarSplitterControl
		Private tabBarPage1 As Syncfusion.Windows.Forms.TabBarPage
		Private tabBarPage2 As Syncfusion.Windows.Forms.TabBarPage
		Private gridDisplay As Syncfusion.Windows.Forms.Grid.GridControl
		Private gridCalculations As Syncfusion.Windows.Forms.Grid.GridControl
		Private gridAwareTextBox1 As GridAwareTextBox
		Private WithEvents showFormula As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label1 As System.Windows.Forms.Label
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		#End Region

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

'			#Region "Grid Style Settings"
			gridDisplay.ThemesEnabled = True
			gridCalculations.ThemesEnabled=True
			gridCalculations.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridDisplay.BorderStyle=BorderStyle.FixedSingle
			Me.gridCalculations.BorderStyle=BorderStyle.FixedSingle

			'Settings to give Excel like Flat Look to the grid
			Me.gridDisplay.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
			Me.gridCalculations.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
'			#End Region

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
		End Sub

		#Region "Form handlers"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim gridRangeStyle1 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle2 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle3 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle4 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle5 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle6 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle7 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle8 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle9 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle10 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle11 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle12 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle13 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle14 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle15 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle16 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle17 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle18 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle19 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle20 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle21 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle22 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle23 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle24 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle25 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle26 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle27 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle28 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle29 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle30 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle31 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle32 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle33 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle34 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle35 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle36 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle37 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle38 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle39 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle40 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle41 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle42 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle43 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle44 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle45 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle46 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle47 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle48 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle49 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle50 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle51 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle52 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle53 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle54 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle55 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle56 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle57 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle58 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle59 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle60 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle61 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle62 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle63 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle64 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridCellInfo1 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo2 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo3 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo4 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo5 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo6 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo7 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo8 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo9 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo10 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo11 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo12 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo13 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo14 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo15 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo16 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo17 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo18 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo19 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo20 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo21 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo22 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo23 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo24 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo25 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo26 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo27 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo28 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo29 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo30 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo31 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo32 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo33 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo34 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo35 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo36 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo37 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo38 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo39 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo40 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo41 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo42 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Dim gridCellInfo43 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Me.tabBarSplitterControl1 = New Syncfusion.Windows.Forms.TabBarSplitterControl()
			Me.tabBarPage1 = New Syncfusion.Windows.Forms.TabBarPage()
			Me.gridDisplay = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.tabBarPage2 = New Syncfusion.Windows.Forms.TabBarPage()
			Me.gridCalculations = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.gridAwareTextBox1 = New Syncfusion.Windows.Forms.Grid.GridAwareTextBox()
			Me.showFormula = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.label1 = New System.Windows.Forms.Label()
			Me.tabBarSplitterControl1.SuspendLayout()
			Me.tabBarPage1.SuspendLayout()
			CType(Me.gridDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabBarPage2.SuspendLayout()
			CType(Me.gridCalculations, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.showFormula, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tabBarSplitterControl1
			' 
			Me.tabBarSplitterControl1.BackColor = System.Drawing.Color.White
			Me.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage1)
			Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage2)
			Me.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText
			Me.tabBarSplitterControl1.Location = New System.Drawing.Point(12, 48)
			Me.tabBarSplitterControl1.Name = "tabBarSplitterControl1"
			Me.tabBarSplitterControl1.Size = New System.Drawing.Size(728, 384)
			Me.tabBarSplitterControl1.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Metro
			Me.tabBarSplitterControl1.TabFolderDelta = 11
			Me.tabBarSplitterControl1.TabIndex = 0
			Me.tabBarSplitterControl1.Text = "tabBarSplitterControl1"
			Me.tabBarSplitterControl1.ThemesEnabled = True
			' 
			' tabBarPage1
			' 
			Me.tabBarPage1.Controls.Add(Me.gridDisplay)
			Me.tabBarPage1.Location = New System.Drawing.Point(0, 0)
			Me.tabBarPage1.Name = "tabBarPage1"
			Me.tabBarPage1.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control
			Me.tabBarPage1.Text = "Display"
			Me.tabBarPage1.ThemesEnabled = True
			' 
			' gridDisplay
			' 
			Me.gridDisplay.AllowSelection = (CType(((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell) Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift) Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard) Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend), Syncfusion.Windows.Forms.Grid.GridSelectionFlags))
			Me.gridDisplay.BackColor = System.Drawing.Color.White
			Me.gridDisplay.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 199), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 82), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 135)})
			Me.gridDisplay.CoveredRanges.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeInfo() { Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(3, 1, 3, 4)})
			Me.gridDisplay.DefaultColWidth = 70
			Me.gridDisplay.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridDisplay.DefaultRowHeight = 18
			Me.gridDisplay.FillSplitterPane = True
			Me.gridDisplay.FloatCellsMode = Syncfusion.Windows.Forms.Grid.GridFloatCellsMode.OnDemandCalculation
			Me.gridDisplay.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.gridDisplay.ForeColor = System.Drawing.Color.MidnightBlue
			Me.gridDisplay.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridDisplay.Location = New System.Drawing.Point(0, 0)
			Me.gridDisplay.Name = "gridDisplay"
			Me.gridDisplay.Properties.GridLineColor = System.Drawing.Color.LightGray
			Me.gridDisplay.Properties.MarkColHeader = False
			Me.gridDisplay.Properties.MarkRowHeader = False
			gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle1.StyleInfo.Font.Bold = False
			gridRangeStyle1.StyleInfo.Font.Facename = "Arial"
			gridRangeStyle1.StyleInfo.Font.Italic = False
			gridRangeStyle1.StyleInfo.Font.Size = 9.75F
			gridRangeStyle1.StyleInfo.Font.Strikeout = False
			gridRangeStyle1.StyleInfo.Font.Underline = False
			gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle2.StyleInfo.Font.Bold = False
			gridRangeStyle2.StyleInfo.Font.Facename = "Arial"
			gridRangeStyle2.StyleInfo.Font.Italic = False
			gridRangeStyle2.StyleInfo.Font.Size = 9.75F
			gridRangeStyle2.StyleInfo.Font.Strikeout = False
			gridRangeStyle2.StyleInfo.Font.Underline = False
			gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle3.StyleInfo.Font.Bold = False
			gridRangeStyle3.StyleInfo.Font.Facename = "Arial"
			gridRangeStyle3.StyleInfo.Font.Italic = False
			gridRangeStyle3.StyleInfo.Font.Size = 9.75F
			gridRangeStyle3.StyleInfo.Font.Strikeout = False
			gridRangeStyle3.StyleInfo.Font.Underline = False
			gridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle4.StyleInfo.Font.Bold = False
			gridRangeStyle4.StyleInfo.Font.Facename = "Arial"
			gridRangeStyle4.StyleInfo.Font.Italic = False
			gridRangeStyle4.StyleInfo.Font.Size = 9.75F
			gridRangeStyle4.StyleInfo.Font.Strikeout = False
			gridRangeStyle4.StyleInfo.Font.Underline = False
			gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle5.StyleInfo.Font.Bold = False
			gridRangeStyle5.StyleInfo.Font.Facename = "Arial"
			gridRangeStyle5.StyleInfo.Font.Italic = False
			gridRangeStyle5.StyleInfo.Font.Size = 9.75F
			gridRangeStyle5.StyleInfo.Font.Strikeout = False
			gridRangeStyle5.StyleInfo.Font.Underline = False
			gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle6.StyleInfo.Font.Bold = False
			gridRangeStyle6.StyleInfo.Font.Facename = "Arial"
			gridRangeStyle6.StyleInfo.Font.Italic = False
			gridRangeStyle6.StyleInfo.Font.Size = 9.75F
			gridRangeStyle6.StyleInfo.Font.Strikeout = False
			gridRangeStyle6.StyleInfo.Font.Underline = False
			gridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle7.StyleInfo.Font.Bold = False
			gridRangeStyle7.StyleInfo.Font.Facename = "Arial"
			gridRangeStyle7.StyleInfo.Font.Italic = False
			gridRangeStyle7.StyleInfo.Font.Size = 9.75F
			gridRangeStyle7.StyleInfo.Font.Strikeout = False
			gridRangeStyle7.StyleInfo.Font.Underline = False
			gridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle8.StyleInfo.Font.Bold = False
			gridRangeStyle8.StyleInfo.Font.Facename = "Verdana"
			gridRangeStyle8.StyleInfo.Font.Italic = False
			gridRangeStyle8.StyleInfo.Font.Size = 9.75F
			gridRangeStyle8.StyleInfo.Font.Strikeout = False
			gridRangeStyle8.StyleInfo.Font.Underline = False
			gridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle9.StyleInfo.Font.Bold = False
			gridRangeStyle9.StyleInfo.Font.Facename = "Arial"
			gridRangeStyle9.StyleInfo.Font.Italic = False
			gridRangeStyle9.StyleInfo.Font.Size = 9.75F
			gridRangeStyle9.StyleInfo.Font.Strikeout = False
			gridRangeStyle9.StyleInfo.Font.Underline = False
			gridRangeStyle9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle10.StyleInfo.Font.Bold = False
			gridRangeStyle10.StyleInfo.Font.Facename = "Arial"
			gridRangeStyle10.StyleInfo.Font.Italic = False
			gridRangeStyle10.StyleInfo.Font.Size = 9.75F
			gridRangeStyle10.StyleInfo.Font.Strikeout = False
			gridRangeStyle10.StyleInfo.Font.Underline = False
			gridRangeStyle10.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(1)
			gridRangeStyle11.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right
			gridRangeStyle11.StyleInfo.Text = ""
			gridRangeStyle12.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(2)
			gridRangeStyle12.StyleInfo.Font.Bold = True
			gridRangeStyle13.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(3)
			gridRangeStyle13.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right
			gridRangeStyle14.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(4)
			gridRangeStyle14.StyleInfo.Font.Bold = True
			gridRangeStyle15.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(3, 1)
			gridRangeStyle15.StyleInfo.Font.Bold = True
			gridRangeStyle15.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridRangeStyle15.StyleInfo.Text = "Payroll"
			gridRangeStyle15.StyleInfo.TextColor = System.Drawing.Color.DodgerBlue
			gridRangeStyle16.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(3, 2)
			gridRangeStyle16.StyleInfo.Font.Bold = True
			gridRangeStyle16.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridRangeStyle16.StyleInfo.Text = ""
			gridRangeStyle16.StyleInfo.TextColor = System.Drawing.Color.DodgerBlue
			gridRangeStyle17.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(3, 3, 3, 4)
			gridRangeStyle17.StyleInfo.TextColor = System.Drawing.Color.DodgerBlue
			gridRangeStyle18.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(4, 0)
			gridRangeStyle18.StyleInfo.Text = "4"
			gridRangeStyle19.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(4, 1, 4, 4)
			gridRangeStyle19.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle20.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(5, 0)
			gridRangeStyle20.StyleInfo.Text = "5"
			gridRangeStyle21.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(5, 1, 5, 2)
			gridRangeStyle21.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle21.StyleInfo.Text = ""
			gridRangeStyle22.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(5, 3, 5, 4)
			gridRangeStyle22.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle23.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 0)
			gridRangeStyle23.StyleInfo.Text = "6"
			gridRangeStyle24.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 1)
			gridRangeStyle24.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle24.StyleInfo.Text = "Name:"
			gridRangeStyle25.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 2, 9, 2)
			gridRangeStyle25.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle25.StyleInfo.Text = ""
			gridRangeStyle26.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 3)
			gridRangeStyle26.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle26.StyleInfo.Text = "DA:"
			gridRangeStyle27.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 4, 20, 4)
			gridRangeStyle27.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle28.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(7, 0)
			gridRangeStyle28.StyleInfo.Text = "7"
			gridRangeStyle29.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(7, 1)
			gridRangeStyle29.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle29.StyleInfo.Text = "Qualification:"
			gridRangeStyle30.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(7, 3)
			gridRangeStyle30.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle30.StyleInfo.Text = "Gross Pay:"
			gridRangeStyle31.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(8, 0)
			gridRangeStyle31.StyleInfo.Text = "8"
			gridRangeStyle32.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(8, 1)
			gridRangeStyle32.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle32.StyleInfo.Text = "Experience:"
			gridRangeStyle33.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(8, 3)
			gridRangeStyle33.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle33.StyleInfo.Text = "PF:"
			gridRangeStyle34.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(9, 0)
			gridRangeStyle34.StyleInfo.Text = "9"
			gridRangeStyle35.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(9, 1)
			gridRangeStyle35.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle35.StyleInfo.Text = "Basic Pay:"
			gridRangeStyle36.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(9, 3)
			gridRangeStyle36.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle36.StyleInfo.Text = "Net Pay:"
			gridRangeStyle37.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(10, 0)
			gridRangeStyle37.StyleInfo.Text = "10"
			gridRangeStyle38.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(10, 1, 10, 2)
			gridRangeStyle38.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle39.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(10, 3)
			gridRangeStyle39.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle39.StyleInfo.Text = "Annual Income:"
			gridRangeStyle40.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(11, 0)
			gridRangeStyle40.StyleInfo.Text = "11"
			gridRangeStyle41.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(11, 1)
			gridRangeStyle41.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle41.StyleInfo.Font.Underline = True
			gridRangeStyle41.StyleInfo.Text = "LIC Policy Details"
			gridRangeStyle42.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(11, 2, 11, 4)
			gridRangeStyle42.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle43.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(12, 0)
			gridRangeStyle43.StyleInfo.Text = "12"
			gridRangeStyle44.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(12, 1)
			gridRangeStyle44.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle44.StyleInfo.Text = "Policy No:"
			gridRangeStyle45.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(12, 2, 14, 2)
			gridRangeStyle45.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle45.StyleInfo.Text = ""
			gridRangeStyle46.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(12, 3, 20, 4)
			gridRangeStyle46.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle47.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(13, 0)
			gridRangeStyle47.StyleInfo.Text = "13"
			gridRangeStyle48.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(13, 1)
			gridRangeStyle48.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle48.StyleInfo.Text = "Policy Type:"
			gridRangeStyle49.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(14, 0)
			gridRangeStyle49.StyleInfo.Text = "14"
			gridRangeStyle50.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(14, 1)
			gridRangeStyle50.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle50.StyleInfo.Text = "Premium:"
			gridRangeStyle51.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(15, 0)
			gridRangeStyle51.StyleInfo.Text = "15"
			gridRangeStyle52.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(15, 1, 15, 4)
			gridRangeStyle52.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle53.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(16, 0)
			gridRangeStyle53.StyleInfo.Text = "16"
			gridRangeStyle54.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(16, 1)
			gridRangeStyle54.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle54.StyleInfo.Font.Underline = True
			gridRangeStyle54.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right
			gridRangeStyle54.StyleInfo.Text = "Personal Loan Details"
			gridRangeStyle55.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(16, 2, 16, 4)
			gridRangeStyle55.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle56.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(17, 0)
			gridRangeStyle56.StyleInfo.Text = "17"
			gridRangeStyle57.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(17, 1)
			gridRangeStyle57.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle57.StyleInfo.Text = "Loan No:"
			gridRangeStyle58.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(17, 2, 19, 2)
			gridRangeStyle58.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle58.StyleInfo.Text = ""
			gridRangeStyle59.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(18, 0)
			gridRangeStyle59.StyleInfo.Text = "18"
			gridRangeStyle60.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(18, 1)
			gridRangeStyle60.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle60.StyleInfo.Text = "Loan Amount:"
			gridRangeStyle61.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(19, 0)
			gridRangeStyle61.StyleInfo.Text = "19"
			gridRangeStyle62.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(19, 1)
			gridRangeStyle62.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			gridRangeStyle62.StyleInfo.Text = "Monthly Due:"
			gridRangeStyle63.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(20, 0)
			gridRangeStyle63.StyleInfo.Text = "20"
			gridRangeStyle64.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(20, 1, 20, 4)
			gridRangeStyle64.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame)
			Me.gridDisplay.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() { gridRangeStyle1, gridRangeStyle2, gridRangeStyle3, gridRangeStyle4, gridRangeStyle5, gridRangeStyle6, gridRangeStyle7, gridRangeStyle8, gridRangeStyle9, gridRangeStyle10, gridRangeStyle11, gridRangeStyle12, gridRangeStyle13, gridRangeStyle14, gridRangeStyle15, gridRangeStyle16, gridRangeStyle17, gridRangeStyle18, gridRangeStyle19, gridRangeStyle20, gridRangeStyle21, gridRangeStyle22, gridRangeStyle23, gridRangeStyle24, gridRangeStyle25, gridRangeStyle26, gridRangeStyle27, gridRangeStyle28, gridRangeStyle29, gridRangeStyle30, gridRangeStyle31, gridRangeStyle32, gridRangeStyle33, gridRangeStyle34, gridRangeStyle35, gridRangeStyle36, gridRangeStyle37, gridRangeStyle38, gridRangeStyle39, gridRangeStyle40, gridRangeStyle41, gridRangeStyle42, gridRangeStyle43, gridRangeStyle44, gridRangeStyle45, gridRangeStyle46, gridRangeStyle47, gridRangeStyle48, gridRangeStyle49, gridRangeStyle50, gridRangeStyle51, gridRangeStyle52, gridRangeStyle53, gridRangeStyle54, gridRangeStyle55, gridRangeStyle56, gridRangeStyle57, gridRangeStyle58, gridRangeStyle59, gridRangeStyle60, gridRangeStyle61, gridRangeStyle62, gridRangeStyle63, gridRangeStyle64})
			Me.gridDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.gridDisplay.RowCount = 20
			Me.gridDisplay.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() { New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
			Me.gridDisplay.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridDisplay.Size = New System.Drawing.Size(711, 367)
			Me.gridDisplay.SmartSizeBox = False
			Me.gridDisplay.ThemesEnabled = True
			' 
			' tabBarPage2
			' 
			Me.tabBarPage2.Controls.Add(Me.gridCalculations)
			Me.tabBarPage2.Location = New System.Drawing.Point(0, 0)
			Me.tabBarPage2.Name = "tabBarPage2"
			Me.tabBarPage2.SplitBars = (CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars))
			Me.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control
			Me.tabBarPage2.Text = "Calculations"
			Me.tabBarPage2.ThemesEnabled = True
			' 
			' gridCalculations
			' 
			Me.gridCalculations.AllowSelection = (CType(((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell) Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift) Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard) Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend), Syncfusion.Windows.Forms.Grid.GridSelectionFlags))
			Me.gridCalculations.BackColor = System.Drawing.Color.White
			Me.gridCalculations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridCalculations.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 139), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 79), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 70)})
			Me.gridCalculations.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridCalculations.FillSplitterPane = True
			Me.gridCalculations.Font = New System.Drawing.Font("Verdana", 8.25F)
			Me.gridCalculations.ForeColor = System.Drawing.Color.MidnightBlue
			gridCellInfo1.Col = -1
			gridCellInfo1.Row = -1
			gridCellInfo1.StyleInfo.Font.Bold = False
			gridCellInfo1.StyleInfo.Font.Facename = "Verdana"
			gridCellInfo1.StyleInfo.Font.Italic = False
			gridCellInfo1.StyleInfo.Font.Size = 8.25F
			gridCellInfo1.StyleInfo.Font.Strikeout = False
			gridCellInfo1.StyleInfo.Font.Underline = False
			gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridCellInfo2.Col = -1
			gridCellInfo2.Row = -1
			gridCellInfo2.StyleInfo.Font.Bold = False
			gridCellInfo2.StyleInfo.Font.Facename = "Verdana"
			gridCellInfo2.StyleInfo.Font.Italic = False
			gridCellInfo2.StyleInfo.Font.Size = 8.25F
			gridCellInfo2.StyleInfo.Font.Strikeout = False
			gridCellInfo2.StyleInfo.Font.Underline = False
			gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridCellInfo3.Col = 1
			gridCellInfo3.Row = 3
			gridCellInfo4.Col = 2
			gridCellInfo4.Row = 3
			gridCellInfo4.StyleInfo.Font.Bold = True
			gridCellInfo4.StyleInfo.Text = "LIC Policy Details"
			gridCellInfo5.Col = 3
			gridCellInfo5.Row = 3
			gridCellInfo6.Col = 4
			gridCellInfo6.Row = 3
			gridCellInfo7.Col = 5
			gridCellInfo7.Row = 3
			gridCellInfo8.Col = 0
			gridCellInfo8.Row = 4
			gridCellInfo8.StyleInfo.Text = "4"
			gridCellInfo9.Col = 1
			gridCellInfo9.Row = 4
			gridCellInfo10.Col = 2
			gridCellInfo10.Row = 4
			gridCellInfo10.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo10.StyleInfo.Text = "Policy No"
			gridCellInfo11.Col = 3
			gridCellInfo11.Row = 4
			gridCellInfo11.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo11.StyleInfo.Text = "Policy Type"
			gridCellInfo12.Col = 4
			gridCellInfo12.Row = 4
			gridCellInfo12.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo12.StyleInfo.Text = "Premium"
			gridCellInfo13.Col = 5
			gridCellInfo13.Row = 4
			gridCellInfo13.StyleInfo.Text = "Deductions"
			gridCellInfo14.Col = 0
			gridCellInfo14.Row = 5
			gridCellInfo14.StyleInfo.Text = "5"
			gridCellInfo15.Col = 1
			gridCellInfo15.Row = 5
			gridCellInfo16.Col = 2
			gridCellInfo16.Row = 5
			gridCellInfo16.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo17.Col = 3
			gridCellInfo17.Row = 5
			gridCellInfo17.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo18.Col = 4
			gridCellInfo18.Row = 5
			gridCellInfo18.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo19.Col = 5
			gridCellInfo19.Row = 5
			gridCellInfo19.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo20.Col = 0
			gridCellInfo20.Row = 6
			gridCellInfo20.StyleInfo.Text = "6"
			gridCellInfo21.Col = 1
			gridCellInfo21.Row = 6
			gridCellInfo22.Col = 2
			gridCellInfo22.Row = 6
			gridCellInfo23.Col = 3
			gridCellInfo23.Row = 6
			gridCellInfo24.Col = 4
			gridCellInfo24.Row = 6
			gridCellInfo25.Col = 5
			gridCellInfo25.Row = 6
			gridCellInfo26.Col = 0
			gridCellInfo26.Row = 7
			gridCellInfo26.StyleInfo.Text = "7"
			gridCellInfo27.Col = 1
			gridCellInfo27.Row = 7
			gridCellInfo28.Col = 2
			gridCellInfo28.Row = 7
			gridCellInfo28.StyleInfo.Font.Bold = True
			gridCellInfo28.StyleInfo.Text = "Personal Loan Details"
			gridCellInfo29.Col = 3
			gridCellInfo29.Row = 7
			gridCellInfo30.Col = 4
			gridCellInfo30.Row = 7
			gridCellInfo31.Col = 5
			gridCellInfo31.Row = 7
			gridCellInfo32.Col = 0
			gridCellInfo32.Row = 8
			gridCellInfo32.StyleInfo.Text = "8"
			gridCellInfo33.Col = 1
			gridCellInfo33.Row = 8
			gridCellInfo34.Col = 2
			gridCellInfo34.Row = 8
			gridCellInfo34.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo34.StyleInfo.Text = "Loan No"
			gridCellInfo35.Col = 3
			gridCellInfo35.Row = 8
			gridCellInfo35.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo35.StyleInfo.Text = "Loan Amount"
			gridCellInfo36.Col = 4
			gridCellInfo36.Row = 8
			gridCellInfo36.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo36.StyleInfo.Text = "Monthly Due"
			gridCellInfo37.Col = 5
			gridCellInfo37.Row = 8
			gridCellInfo37.StyleInfo.Text = "Deductions"
			gridCellInfo38.Col = 0
			gridCellInfo38.Row = 9
			gridCellInfo38.StyleInfo.Text = "9"
			gridCellInfo39.Col = 1
			gridCellInfo39.Row = 9
			gridCellInfo40.Col = 2
			gridCellInfo40.Row = 9
			gridCellInfo40.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo40.StyleInfo.Text = ""
			gridCellInfo41.Col = 3
			gridCellInfo41.Row = 9
			gridCellInfo41.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo42.Col = 4
			gridCellInfo42.Row = 9
			gridCellInfo42.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridCellInfo43.Col = 5
			gridCellInfo43.Row = 9
			gridCellInfo43.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			Me.gridCalculations.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() { gridCellInfo1, gridCellInfo2, gridCellInfo3, gridCellInfo4, gridCellInfo5, gridCellInfo6, gridCellInfo7, gridCellInfo8, gridCellInfo9, gridCellInfo10, gridCellInfo11, gridCellInfo12, gridCellInfo13, gridCellInfo14, gridCellInfo15, gridCellInfo16, gridCellInfo17, gridCellInfo18, gridCellInfo19, gridCellInfo20, gridCellInfo21, gridCellInfo22, gridCellInfo23, gridCellInfo24, gridCellInfo25, gridCellInfo26, gridCellInfo27, gridCellInfo28, gridCellInfo29, gridCellInfo30, gridCellInfo31, gridCellInfo32, gridCellInfo33, gridCellInfo34, gridCellInfo35, gridCellInfo36, gridCellInfo37, gridCellInfo38, gridCellInfo39, gridCellInfo40, gridCellInfo41, gridCellInfo42, gridCellInfo43})
			Me.gridCalculations.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridCalculations.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridCalculations.Location = New System.Drawing.Point(0, 0)
			Me.gridCalculations.MetroScrollBars = True
			Me.gridCalculations.Name = "gridCalculations"
			Me.gridCalculations.Properties.GridLineColor = System.Drawing.Color.LightGray
			Me.gridCalculations.Properties.MarkColHeader = False
			Me.gridCalculations.Properties.MarkRowHeader = False
			Me.gridCalculations.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.gridCalculations.RowCount = 20
			Me.gridCalculations.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() { New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21), New Syncfusion.Windows.Forms.Grid.GridRowHeight(1, 18)})
			Me.gridCalculations.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
			Me.gridCalculations.Size = New System.Drawing.Size(711, 367)
			Me.gridCalculations.SmartSizeBox = False
			Me.gridCalculations.ThemesEnabled = True
			' 
			' gridAwareTextBox1
			' 
			Me.gridAwareTextBox1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window
			Me.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window
			Me.gridAwareTextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gridAwareTextBox1.Location = New System.Drawing.Point(88, 15)
			Me.gridAwareTextBox1.Name = "gridAwareTextBox1"
			Me.gridAwareTextBox1.Size = New System.Drawing.Size(536, 22)
			Me.gridAwareTextBox1.TabIndex = 1
			' 
			' showFormula
			' 
			Me.showFormula.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.showFormula.DrawFocusRectangle = False
			Me.showFormula.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.showFormula.Location = New System.Drawing.Point(632, 15)
			Me.showFormula.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.showFormula.Name = "showFormula"
			Me.showFormula.Size = New System.Drawing.Size(108, 18)
			Me.showFormula.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
			Me.showFormula.TabIndex = 2
			Me.showFormula.Text = "Show Formula"
			Me.showFormula.ThemesEnabled = False
'			Me.showFormula.CheckStateChanged += New EventHandler(showFormula_CheckedChanged)
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(9, 15)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(72, 16)
			Me.label1.TabIndex = 3
			Me.label1.Text = "Formula Bar"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(752, 440)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.showFormula)
			Me.Controls.Add(Me.gridAwareTextBox1)
			Me.Controls.Add(Me.tabBarSplitterControl1)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Cross-Reference Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.tabBarSplitterControl1.ResumeLayout(False)
			Me.tabBarPage1.ResumeLayout(False)
			CType(Me.gridDisplay, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabBarPage2.ResumeLayout(False)
			CType(Me.gridCalculations, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.showFormula, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
#End Region

		#Region "Event Handlers"
		Private engine As GridFormulaEngine
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			'Registering grid as sheet for cross-reference
			Dim sheetFamilyID As Integer = GridFormulaEngine.CreateSheetFamilyID()
			GridFormulaEngine.RegisterGridAsSheet("Display", Me.gridDisplay.Model, sheetFamilyID)
			GridFormulaEngine.RegisterGridAsSheet("Calculate", Me.gridCalculations.Model, sheetFamilyID)
			SetUpDisplaySheet()
			SetUpCalcSheet()

			'setup copying formulas
			engine = (CType(Me.gridCalculations.CellModels("FormulaCell"), GridFormulaCellModel)).Engine
			engine.FormulaCopyFlags = engine.FormulaCopyFlags Or GridFormulaCopyFlags.ClipBoardFormula

			'Subscribe to the necessary events
			AddHandler gridDisplay.CurrentCellStartEditing, AddressOf gridDisplay_CurrentCellStartEditing
			AddHandler gridDisplay.CellDoubleClick, AddressOf gridDisplay_CellDoubleClick
			AddHandler gridCalculations.CurrentCellStartEditing, AddressOf gridCalculations_CurrentCellStartEditing
			AddHandler gridCalculations.CellDoubleClick, AddressOf gridCalculations_CellDoubleClick
			AddHandler gridDisplay.DrawCellDisplayText, AddressOf gridDisplay_DrawCellDisplayText
			AddHandler gridCalculations.DrawCellDisplayText, AddressOf gridCalculations_DrawCellDisplayText
		End Sub

		Private Sub gridCalculations_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			editingLocked = False
			Me.gridCalculations.CurrentCell.BeginEdit(True)
			editingLocked = True
		End Sub

		Private Sub gridDisplay_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			editingLocked = False
			Me.gridDisplay.CurrentCell.BeginEdit(True)
			editingLocked = True
		End Sub

		Private Sub gridCalculations_CurrentCellStartEditing(ByVal sender As Object, ByVal e As CancelEventArgs)
			e.Cancel = editingLocked
		End Sub

		Private Sub gridDisplay_CurrentCellStartEditing(ByVal sender As Object, ByVal e As CancelEventArgs)
			e.Cancel = editingLocked
		End Sub

		#Region "DisplaySheet"

		Private Sub SetUpDisplaySheet()

			'General Settings
			Dim row As Integer = 6
			Dim col As Integer = 4

			Me.gridDisplay(row, col).CellType = GridCellTypeName.FormulaCell
			Me.gridDisplay(row, col).Text = "=B9*0.81"

			row += 1
			Me.gridDisplay(row, col).CellType = GridCellTypeName.FormulaCell
			Me.gridDisplay(row, col).Text="=B9+D6"

			row += 1
			Me.gridDisplay(row, col).CellType = GridCellTypeName.FormulaCell
			Me.gridDisplay(row, col).Text="=D7*0.10"

			row += 1
			Me.gridDisplay(row, col).CellType = GridCellTypeName.FormulaCell
			Me.gridDisplay(row, col).Text = "=D7-D8"

			row += 1
			Me.gridDisplay(row, col).CellType = GridCellTypeName.FormulaCell
			Me.gridDisplay(row, col).Text = "=D9*12"

			row = 6
			col = 2
			'General Details
			Me.gridDisplay(row, col).Text = "Vedha"
			row += 1
			Me.gridDisplay(row, col).Text = "B.E."
			row += 1
			Me.gridDisplay(row, col).Text = "4 years"
			row += 1
			Me.gridDisplay(row, col).Text = "8,000.00"

			'Policy Details
			row += 3
			Me.gridDisplay(row, col).Text = "1234"
			row += 1
			Me.gridDisplay(row, col).Text = "Quarterly"
			row += 1
			Me.gridDisplay(row, col).Text = "2,000.00"

			'Loan Details
			row += 3
			Me.gridDisplay(row, col).Text = "5678"
			row += 1
			Me.gridDisplay(row, col).Text = "1,00,000.00"
			row += 1
			Me.gridDisplay(row, col).Text = "1,500.00"


			Me.gridAwareTextBox1.WireGrid(Me.gridDisplay)


		End Sub


		#End Region

		#Region "CalculationSheet"

		Private Sub SetUpCalcSheet()
			Dim row As Integer = 5
			Dim col As Integer = 2

			Me.gridCalculations(row, col).CellType = GridCellTypeName.FormulaCell
			Me.gridCalculations(row, col).Text = "=Display!B12"

			Me.gridCalculations(row, col + 1).CellType = GridCellTypeName.FormulaCell
			Me.gridCalculations(row, col + 1).Text = "=Display!B13"

			Me.gridCalculations(row, col + 2).CellType = GridCellTypeName.FormulaCell
			Me.gridCalculations(row, col + 2).Text = "=Display!B14"

			Me.gridCalculations(row, col + 3).CellType = GridCellTypeName.FormulaCell
			Me.gridCalculations(row, col + 3).Text = "=D5*4"

			row+=4
			Me.gridCalculations(row, col).CellType = GridCellTypeName.FormulaCell
			Me.gridCalculations(row, col).Text = "=Display!B17"

			Me.gridCalculations(row, col + 1).CellType = GridCellTypeName.FormulaCell
			Me.gridCalculations(row, col + 1).Text = "=Display!B18"

			Me.gridCalculations(row, col + 2).CellType = GridCellTypeName.FormulaCell
			Me.gridCalculations(row, col + 2).Text = "=Display!B19"

			Me.gridCalculations(row, col + 3).CellType = GridCellTypeName.FormulaCell
			Me.gridCalculations(row, col + 3).Text = "=D9*12"

			Me.gridCalculations.TableStyle.Format = "#,##0"

			Me.gridAwareTextBox1.WireGrid(Me.gridCalculations)
		End Sub


		#End Region

		Private Sub tabBarSplitterControl1_PaneCreated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs)
			Dim grid As GridControl = TryCast(e.Control, GridControl)
			Me.gridAwareTextBox1.WireGrid(grid)
		End Sub

		Private Sub tabBarSplitterControl1_PaneClosing(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs)
			Dim grid As GridControl = TryCast(e.Control, GridControl)
			Me.gridAwareTextBox1.UnwireGrid(grid)
		End Sub

		Private editingLocked As Boolean = True
		Private flag As Boolean=False

		Private Sub showFormula_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles showFormula.CheckStateChanged
			If showFormula.Checked Then
				'Display the formulas in Formula Cells
				flag=True
				Me.gridDisplay.RefreshRange(GridRangeInfo.Cells(6,4,10,4))
				Me.gridCalculations.RefreshRange(GridRangeInfo.Row(5))
				Me.gridCalculations.RefreshRange(GridRangeInfo.Row(9))
			Else
				'Show the computed results in Formula Cells
				flag=False
				Me.gridDisplay.RefreshRange(GridRangeInfo.Cells(6,4,10,4))
				Me.gridCalculations.RefreshRange(GridRangeInfo.Row(5))
				Me.gridCalculations.RefreshRange(GridRangeInfo.Row(9))
			End If
		End Sub

		Private Sub gridDisplay_DrawCellDisplayText(ByVal sender As Object, ByVal e As GridDrawCellDisplayTextEventArgs)
			If e.Style.CellType Is "FormulaCell" AndAlso flag Then
				e.DisplayText = e.Style.Text
			End If
		End Sub
		Private Sub gridCalculations_DrawCellDisplayText(ByVal sender As Object, ByVal e As GridDrawCellDisplayTextEventArgs)
			If e.Style.CellType Is "FormulaCell" AndAlso flag Then
				e.DisplayText=e.Style.Text
			End If
		End Sub
#End Region
	End Class
End Namespace
