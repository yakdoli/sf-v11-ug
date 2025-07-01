Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Drawing
Imports Syncfusion.GridHelperClasses
Imports System.Reflection
Imports System.IO
Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms

Namespace ContentCellDemo
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()
			Try
				'System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
				Dim ico As New System.Drawing.Icon(GetIconFile("D:\icons\LOGO.ico"))
				Me.Icon = ico
			Catch
			End Try
			InitializeGrid()
		End Sub

		#Region "Icon and Image Handlers"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		Private Function GetImage(ByVal bitmapName As String) As Image
			Dim bitmap As Image = Nothing

			Try
				Dim ass As System.Reflection.Assembly = GetType(Form1).Assembly
				Dim name As String = ass.GetName().Name
				Dim stream As Stream = ass.GetManifestResourceStream(name & "." & bitmapName)
				bitmap = Image.FromStream(stream)
			Catch ex As Exception
				TraceUtil.TraceExceptionCatched(ex)
			End Try

			Return bitmap
		End Function
		#End Region

		Private Sub InitializeGrid()
'			#Region "Style declaration"
			Me.gridControl1.DefaultRowHeight = 18
			Dim headerstyle As New GridStyleInfo()
			headerstyle.Font.Size = 12
			headerstyle.Font.Bold = True
			headerstyle.TextColor = Color.Black
			headerstyle.VerticalAlignment = GridVerticalAlignment.Middle
			headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center
			headerstyle.CellType = GridCellTypeName.Static

			Dim subheaderstyle As New GridStyleInfo()
			subheaderstyle.Font.Bold = True
			subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle
			subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center
			subheaderstyle.CellType = GridCellTypeName.Static

			Dim valuestyle As New GridStyleInfo()
			valuestyle.BackColor = SystemColors.Menu
			valuestyle.TextColor = Color.Black
			valuestyle.VerticalAlignment = GridVerticalAlignment.Middle
			valuestyle.HorizontalAlignment = GridHorizontalAlignment.Center

			gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation

			Dim rowIndex As Integer = 1, colIndex As Integer = 2
'			#End Region

'			#Region "Chart in Cell"

			Me.InitializeData()
			Me.gridControl1.CellModels.Add("ChartCell", New GridChartCellModel(Me.gridControl1.Model))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "ChartControl in GridCells"

'			#Region "ChartData"
			Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(4, 4, 4, 8))
			style = Me.gridControl1(4, 4)
			style.Text = "Chart Data"
			style.Font.Bold = True
			style.Font.Facename = "Times New Roman"
			style.Font.Size = 12.75F
			style.HorizontalAlignment = GridHorizontalAlignment.Center
			Me.gridControl1.RowHeights(4) = 21

			Dim rstyle As New GridRangeStyle()
			rstyle.Range = GridRangeInfo.Cell(5, 4)
			rstyle.StyleInfo.BaseStyle = "Header"
			rstyle.StyleInfo.CellType = "Header"
			rstyle.StyleInfo.Font.Bold = True
			rstyle.StyleInfo.Font.Facename = "Verdana"
			rstyle.StyleInfo.Themed = True
			Me.gridControl1.RangeStyles.Add(rstyle)

			Dim rstyle2 As New GridRangeStyle()
			rstyle2.Range = GridRangeInfo.Cells(5, 5, 5, 8)
			rstyle2.StyleInfo.BaseStyle = "Column Header"
			rstyle2.StyleInfo.CellType = "Header"
			rstyle2.StyleInfo.Font.Bold = True
			rstyle2.StyleInfo.Font.Facename = "Verdana"
			rstyle2.StyleInfo.Themed = True
			Me.gridControl1.RangeStyles.Add(rstyle2)
			Me.gridControl1(5, 5).Text = "Team1"
			Me.gridControl1(5, 6).Text = "Team2"
			Me.gridControl1(5, 7).Text = "Team3"
			Me.gridControl1(5, 8).Text = "Team4"

			Dim rstyle3 As New GridRangeStyle()
			rstyle3.Range = GridRangeInfo.Cells(6, 4, 8, 4)
			rstyle3.StyleInfo.BaseStyle = "Row Header"
			rstyle3.StyleInfo.CellType = "Header"
			rstyle3.StyleInfo.Font.Bold = True
			rstyle3.StyleInfo.Font.Facename = "Verdana"
			rstyle3.StyleInfo.Themed = True
			Me.gridControl1.RangeStyles.Add(rstyle3)
			Me.gridControl1(6, 4).Text = "Data1"
			Me.gridControl1(7, 4).Text = "Data2"
			Me.gridControl1(8, 4).Text = "Data3"



'			#End Region

'			#Region "ChartControl"
			'Define the Range where the chart should be displayed (8,2,26,8) 27, 2, 28, 8));
			Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(10, 4, 28, 10))
			Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(29, 4, 30, 10))
			style = Me.gridControl1(29, 4)
			style.Text = "Interactive Chart Cell - Try Changing the ChartData"
			style.Font.Size = 12
			style.Font.Bold = True
			style.Font.Facename = "Arial"
			style.HorizontalAlignment = GridHorizontalAlignment.Center

			style = Me.gridControl1(10,4)
			style.CellType = "ChartCell"
			csp = New ChartStyleProperties(style)
			csp.ChartType = ChartSeriesType.Column
			csp.TitleText = "Chart Cell"
			csp.Series3D = False
			csp.TitleAlignment = StringAlignment.Center

			cm = CType(Me.gridControl1.CellModels("ChartCell"), GridChartCellModel)
			'//Pass the CellValueRange and ChartAreaRange to cell model.
			cm.CellValueRangeInfo = GridRangeInfo.Cells(6, 6, 8, 8)
			cm.ChartAreaRangeInfo = GridRangeInfo.Cells(8, 2, 26, 9)

'			#End Region

'			#End Region

'			#Region "Grid in Cell"
			rowIndex = 32
			colIndex = 4
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "GridInCells"
			rowIndex += 3

#If HELPERCLASS Then
			RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.GridinCell)
#Else
			gridControl1.CellModels.Add("GridinCell", New GridInCellModel(gridControl1.Model))
#End If

			Dim grid As GridControl

			Me.gridControl1(rowIndex, colIndex).CellType = "GridinCell"
			Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 4, 10))
			grid = New ContentCellDemo.CellEmbeddedGrid(Me.gridControl1)
			grid.RowCount = 20
			grid.ColCount = 20
			grid(1, 1).Text = "this is a 20x20 grid"
			grid.ThemesEnabled = True
			grid.Office2007ScrollBars = True
			Me.gridControl1(rowIndex, colIndex).Control = grid
			Me.gridControl1.Controls.Add(grid)

			Me.gridControl1.DefaultRowHeight = 18
			Me.gridControl1.DefaultColWidth = 75
			grid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
'			#End Region

'			#Region "XHTML Cell"
			rowIndex = 42
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "XHTML Cells"
			rowIndex += 3
			RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.XhtmlCell)
			Dim xhtml1 As String = "<body style=""font-family:Arial; line-height:1em""> "
			xhtml1 &= "<h1 style=""text-align:center; color:#EE7A03 "">XhtmlCells</h1>" '#008888
			xhtml1 &= "<p/>"
			xhtml1 &= "<p>XhtmlCells use the RichTextBoxSupportsXHTML control from GotDotNet user samples to display XHTML formatted text inside a cell.</p>"
			xhtml1 &= "</body>"

			gridControl1(rowIndex, colIndex).CellType = "XhtmlCell"
			gridControl1(rowIndex, colIndex).Text = xhtml1
			gridControl1.RowHeights(rowIndex) = 50
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 10, colIndex+6))
			rowIndex += 10
			rowIndex += 1
			rowIndex += 1

'			#End Region

'			#Region "Calendar Cells"
			RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.Calendar)
			rowIndex = 57
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Calendar Cells"
			rowIndex += 3

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 4, rowIndex + 8, 6))
			style = gridControl1(rowIndex, 4)
			style.CellType = "Calendar"
			style.Control = New MonthCalendar()

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 8, rowIndex +8, 10))
			style = gridControl1(rowIndex, 8)
			style.CellType = "Calendar"
			style.Control = New MonthCalendar()

'			#End Region

'			#Region "PictureBoxCells"
			rowIndex = 71
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "PictureBox Cells"
			rowIndex += 3

			RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.PictureBox)

			Dim tsp As New Syncfusion.GridHelperClasses.PictureBoxStyleProperties(New GridStyleInfo(gridControl1.TableStyle))
			tsp.SizeMode = PictureBoxSizeMode.StretchImage
			Dim sp As Syncfusion.GridHelperClasses.PictureBoxStyleProperties
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 4, rowIndex + 6, 6))
			style = gridControl1(rowIndex, 4)
			style.CellType = "PictureBox"
			sp = New Syncfusion.GridHelperClasses.PictureBoxStyleProperties(style)
			sp.Image = GetImage("car1.jpg")
			sp.SizeMode = PictureBoxSizeMode.StretchImage
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 8, rowIndex + 6, 10))
			style = gridControl1(rowIndex, 8)
			style.CellType = "PictureBox"
			sp = New Syncfusion.GridHelperClasses.PictureBoxStyleProperties(style)
			sp.Image = GetImage("car2.jpg")
			sp.SizeMode = PictureBoxSizeMode.StretchImage
'			#End Region


		End Sub

		#Region "Variables"
		Private cm As GridChartCellModel
		Private style As GridStyleInfo
		Private csp As ChartStyleProperties
		#End Region

		#Region "ChartData"
		Private Sub InitializeData()
			Dim random As New Random()
			For i As Integer = 6 To 8
				For j As Integer = 5 To 8
					Dim value As Double = random.Next(10, 60)
					style = Me.gridControl1(i, j)
					style.CellValue = value
					style.Font.Facename = "Tahoma"
					style.Font.Size = 9f
				Next j
			Next i
		End Sub
		#End Region


	End Class
End Namespace