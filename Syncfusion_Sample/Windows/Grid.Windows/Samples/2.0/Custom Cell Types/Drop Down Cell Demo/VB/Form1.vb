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
Imports Syncfusion.Windows.Forms

Namespace DropDownCellDemo
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			
			InitializeGrid()
		End Sub

		#Region "Icon Handlers"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function
		#End Region

		Private Sub InitializeGrid()
'			#Region "Style declaration"
			Me.gridControl1.DefaultRowHeight = 18
			Dim headerstyle As New GridStyleInfo()
			headerstyle.Font.Size = 12
			headerstyle.Font.Bold = True
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
'			#End Region

'			#Region "Date Time Picker Cells"
			Dim rowIndex As Integer = 1, colIndex As Integer = 4
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Date Time Picker Cells"
			rowIndex += 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 5))
			Me.gridControl1(rowIndex, colIndex - 1).Text = "Date Picker : (MM/dd/yyyy hh:mm)"
			Me.gridControl1(rowIndex, colIndex - 1).TextColor = Color.Black
			colIndex += 1
			colIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1))
			Me.gridControl1.CellModels.Add("DateTimePicker", New DateTimeCellModel(Me.gridControl1.Model))
			Me.gridControl1(rowIndex, colIndex).CellType = "DateTimePicker"
			Me.gridControl1(rowIndex, colIndex).CellValueType = GetType(DateTime)
			Me.gridControl1(rowIndex, colIndex).CellValue = DateTime.Now
			Me.gridControl1(rowIndex, colIndex).Format = "MM/dd/yyyy hh:mm"

			rowIndex += 1
			rowIndex += 1
			colIndex -= 2
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 5))
			Me.gridControl1(rowIndex, colIndex - 1).Text = "Time Picker cell : (hh:mm:ss tt)"
			Me.gridControl1(rowIndex, colIndex - 1).TextColor = Color.Black
			colIndex += 1
			colIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1))
			Me.gridControl1(rowIndex, colIndex).CellType = "DateTimePicker"
			Me.gridControl1(rowIndex, colIndex).CellValueType = GetType(DateTime)
			Me.gridControl1(rowIndex, colIndex).CellValue = DateTime.Now
			Me.gridControl1(rowIndex, colIndex).Format = "hh:mm:ss tt"

'#End Region

'			#Region "DropDownGrid cells"
			Dim GridA As New GridControl()
			GridA.RowCount = 10
			GridA.ColCount = 5
			GridA.ThemesEnabled = True
			GridA.CausesValidation = False
			GridA(1, 1).Text = "Grid A"

			GridA.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			GridA.Properties.BackgroundColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
			GridA.Properties.GridLineColor = System.Drawing.Color.FromArgb((CByte(208)), (CByte(215)), (CByte(229)))
			GridA.DefaultGridBorderStyle = GridBorderStyle.Solid
			GridA.ForeColor = System.Drawing.Color.MidnightBlue
			GridA.Font = New System.Drawing.Font("Verdana", 8.5F)


			Dim GridB As New GridControl()
			GridB.RowCount = 6
			GridB.ColCount = 6
			GridB.CausesValidation = False
			GridB.ThemesEnabled = True
			GridB(1, 1).Text = "Grid B"

			GridB.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Dim aModel As New DropDownGridCellModel(Me.gridControl1.Model)
			aModel.EmbeddedGrid = GridA
			Dim bModel As New DropDownGridCellModel(Me.gridControl1.Model)
			bModel.EmbeddedGrid = GridB
			gridControl1.CellModels.Add("GridADropCell", aModel)
			gridControl1.CellModels.Add("GridBDropCell", bModel)

			rowIndex += 3
			colIndex -= 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "DropDown Grid Cells"
			rowIndex += 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1))
			Me.gridControl1(rowIndex, colIndex).Text = "Grid A"
			Me.gridControl1(rowIndex, colIndex).CellType = "GridADropCell"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex + 3, rowIndex, colIndex + 4))
			Me.gridControl1(rowIndex, colIndex + 3).Text = "Grid B"
			Me.gridControl1(rowIndex, colIndex + 3).CellType = "GridBDropCell"
'			#End Region

'			#Region "DropDown Form and User Control"
			rowIndex += 3
			colIndex -= 2
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "DropDown Form and User Control"
			rowIndex += 1
			rowIndex += 1

			Me.gridControl1.CellModels.Add("DropDownForm", New DropDownFormCellModel(Me.gridControl1.Model, New DropDownForm()))
			Me.gridControl1.CellModels.Add("DropDownUserControl", New DropDownUserCellModel(Me.gridControl1.Model, New DropDownUser()))

			'//DropDownForm...
			rowIndex += 1
			colIndex = 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 4))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 5, rowIndex, 7))
			gridControl1(rowIndex, colIndex).Text = "DropDownForm"
			gridControl1(rowIndex, colIndex).TextColor = Color.Black
			Me.gridControl1(rowIndex, colIndex + 2).CellType = "DropDownForm"
			Me.gridControl1(rowIndex, colIndex + 2).Text = "choice1,choice3"

			'//DropDownForm...
			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 4))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 5, rowIndex, 7))
			gridControl1(rowIndex, colIndex).Text = "DropDownUserControl"
			gridControl1(rowIndex, colIndex).TextColor = Color.Black
			Me.gridControl1(rowIndex, colIndex + 2).CellType = "DropDownUserControl"
			Me.gridControl1(rowIndex, colIndex + 2).Text = "choice1,choice3"

'			#End Region

'			#Region "DropDOwnCalculator Cell"

			rowIndex += 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "DropDown Calculator TextBox"
			rowIndex += 1
			rowIndex += 1

#If HELPERCLASS Then
			RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.CalculatorTextBox)
#Else
			Me.gridControl1.CellModels.Add("CalculatorTextBox", New DropDownCalculatorTextBoxCellModel(Me.gridControl1.Model))
#End If

			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 4, rowIndex, 6))
			Dim c1 As New CalculatorControl()
			c1.BorderStyle = Border3DStyle.Flat
			c1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			c1.UseVisualStyle = True

			Dim style As GridStyleInfo = gridControl1(rowIndex, 4)
			style.CellType = "CalculatorTextBox"
			style.Control = c1
			style.Text = "Calculator TextBox"


'			#End Region
		End Sub
	End Class
End Namespace