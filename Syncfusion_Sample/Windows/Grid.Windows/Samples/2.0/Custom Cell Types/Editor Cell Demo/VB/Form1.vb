Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.GridHelperClasses

Namespace EditorCellDemo
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

			gridControl1.TableStyle.FloatCell = True
			gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation
'			#End Region

			gridControl1.BeginUpdate()

			Dim rowIndex As Integer = 1, colIndex As Integer = 4

'			#Region "IntegerTextBox"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Integer TextBox Cell"

			rowIndex += 3
			RegisterCellModel.GridCellType(Me.gridControl1, CustomCellTypes.IntegerTextBox)
			Me.gridControl1(rowIndex, colIndex - 2).Text = ".CellType = CustomCellTypes.IntegerTextBox"
			Me.gridControl1(rowIndex, colIndex - 2).HorizontalAlignment = GridHorizontalAlignment.Center


			Me.gridControl1(rowIndex, colIndex + 2) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 2).CellType = CustomCellTypes.IntegerTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 2).CellValue = 56789

			Me.gridControl1(rowIndex, colIndex + 3) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 3).CellType = CustomCellTypes.IntegerTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 3).CellValue = 34210

			rowIndex += 1
			 Me.gridControl1(rowIndex, colIndex + 2) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 2).CellType = CustomCellTypes.IntegerTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 2).CellValue = 1234

			Me.gridControl1(rowIndex, colIndex + 3) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 3).CellType = CustomCellTypes.IntegerTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 3).CellValue = 54321

'			#End Region

'			#Region "DoubleTextBox"
			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Double TextBox Cell"

			rowIndex += 3
			RegisterCellModel.GridCellType(Me.gridControl1, CustomCellTypes.DoubleTextBox)
			Me.gridControl1(rowIndex, colIndex - 2).Text = ".CellType = CustomCellTypes.DoubleTextBox"
			Me.gridControl1(rowIndex, colIndex - 2).HorizontalAlignment = GridHorizontalAlignment.Center


			Me.gridControl1(rowIndex, colIndex + 2) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 2).CellType = CustomCellTypes.DoubleTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 2).CellValue = 123456

			Me.gridControl1(rowIndex, colIndex + 3) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 3).CellType = CustomCellTypes.DoubleTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 3).CellValue = 876543

			rowIndex += 1
			Me.gridControl1(rowIndex, colIndex + 2) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 2).CellType = CustomCellTypes.DoubleTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 2).CellValue = 13579

			Me.gridControl1(rowIndex, colIndex + 3) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 3).CellType = CustomCellTypes.DoubleTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 3).CellValue = 975324

'			#End Region

'			#Region "Percentage TextBox"
			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Percentage TextBox Cell"

			rowIndex += 3
			RegisterCellModel.GridCellType(Me.gridControl1, CustomCellTypes.PercentTextBox)
			Me.gridControl1(rowIndex, colIndex - 2).Text = ".CellType = CustomCellTypes.DoubleTextBox"
			Me.gridControl1(rowIndex, colIndex - 2).HorizontalAlignment = GridHorizontalAlignment.Center


			Me.gridControl1(rowIndex, colIndex + 2) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 2).CellType = CustomCellTypes.PercentTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 2).CellValue = 54

			Me.gridControl1(rowIndex, colIndex + 3) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 3).CellType = CustomCellTypes.PercentTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 3).CellValue = 65

			rowIndex += 1
			Me.gridControl1(rowIndex, colIndex + 2) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 2).CellType = CustomCellTypes.PercentTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 2).CellValue = 84

			Me.gridControl1(rowIndex, colIndex + 3) = valuestyle
			Me.gridControl1(rowIndex, colIndex + 3).CellType = CustomCellTypes.PercentTextBox.ToString()
			Me.gridControl1(rowIndex, colIndex + 3).CellValue = 92

'			#End Region

'			#Region "EnhancedNumericUpdown"
			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Enhanced Numeric Up-Down Cell"

			RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.FNumericUpDown)
			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Text = "Allow Decimal Increment and Decrement(step by 0.2,0.01,0.001)"

'			#Region "#1"
			rowIndex += 1
			rowIndex += 1
			gridControl1.Model.RowHeights(rowIndex) = 20
			Dim style As GridStyleInfo = gridControl1(rowIndex, colIndex -1)
			style.CellType = "FNumericUpDown"
			style.Text = "0.5"
			Dim sp As New FloatNumericUpDownStyleProperties(style)
			sp.StyleInfo.BackColor = SystemColors.Window
			sp.FloatNumericUpDownProperties.Maximum = 15.0
			sp.FloatNumericUpDownProperties.Minimum = 0.0
			sp.FloatNumericUpDownProperties.StartValue = 0.5
			sp.FloatNumericUpDownProperties.Step = 0.2
			sp.FloatNumericUpDownProperties.WrapValue = True
			sp.FloatNumericUpDownProperties.DecimalPlaces = 1

			style = gridControl1(rowIndex, colIndex+1)
			style.CellType = "FNumericUpDown"
			style.Text = "10.10"
			sp = New FloatNumericUpDownStyleProperties(style)
			sp.StyleInfo.BackColor = SystemColors.Window
			sp.FloatNumericUpDownProperties.Maximum = 12.50
			sp.FloatNumericUpDownProperties.Minimum = 0.0
			sp.FloatNumericUpDownProperties.StartValue = 10.10
			sp.FloatNumericUpDownProperties.Step = 0.01
			sp.FloatNumericUpDownProperties.WrapValue = True
			sp.FloatNumericUpDownProperties.DecimalPlaces = 2


			style = gridControl1(rowIndex, colIndex + 3)
			style.CellType = "FNumericUpDown"
			style.Text = "15.000"
			sp = New FloatNumericUpDownStyleProperties(style)
			sp.StyleInfo.BackColor = SystemColors.Window
			sp.FloatNumericUpDownProperties.Maximum = 15.225
			sp.FloatNumericUpDownProperties.Minimum = 0.0
			sp.FloatNumericUpDownProperties.StartValue = 15.000
			sp.FloatNumericUpDownProperties.Step = 0.001
			sp.FloatNumericUpDownProperties.WrapValue = True
			sp.FloatNumericUpDownProperties.DecimalPlaces = 3
			sp.FloatNumericUpDownProperties.Orientation = FloatNumericUpDownProperties.OrientationType.Vertical
			sp.FloatNumericUpDownProperties.InterceptArrowkeys = False
			sp.FloatNumericUpDownProperties.ThousandsSeparator = False
'			#End Region

'			#Region "#2"
			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Text = "Option to decrease number beyond Zero(Negative numbers allowed)"

			rowIndex += 1
			rowIndex += 1
			gridControl1.Model.RowHeights(rowIndex) = 20
			style = Me.gridControl1(rowIndex, colIndex - 1)
			style.CellType="FNumericUpDown"
			style.Text="-4"
			sp = New FloatNumericUpDownStyleProperties(style)
'#End Region

'			#Region "#3"
			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Text = "Use Up/Down arrow keys from Keyboard to increment/decrement the numeric value"

			rowIndex += 1
			rowIndex += 1
			gridControl1.Model.RowHeights(rowIndex) = 20
			style = Me.gridControl1(rowIndex, colIndex - 1)
			style.CellType = "FNumericUpDown"
			style.Text = "100000"
			sp = New FloatNumericUpDownStyleProperties(style)
			sp.StyleInfo.BackColor = SystemColors.Window
			sp.FloatNumericUpDownProperties.Maximum = 10000000000
			sp.FloatNumericUpDownProperties.Minimum = 1
			sp.FloatNumericUpDownProperties.StartValue = 100000
			sp.FloatNumericUpDownProperties.Step = 100
			sp.FloatNumericUpDownProperties.WrapValue = True
			sp.FloatNumericUpDownProperties.DecimalPlaces = 0
			sp.FloatNumericUpDownProperties.Orientation = FloatNumericUpDownProperties.OrientationType.Vertical
			sp.FloatNumericUpDownProperties.InterceptArrowkeys = True
			sp.FloatNumericUpDownProperties.ThousandsSeparator = False
'			#End Region

'			#Region "#4"

			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Text = "Setting the Orientation property"

			rowIndex += 1
			rowIndex += 1
			gridControl1.Model.RowHeights(rowIndex) = 20
			style = Me.gridControl1(rowIndex, colIndex - 1)
			style.CellType = "FNumericUpDown"
			style.Text = "5.5"
			sp = New FloatNumericUpDownStyleProperties(style)
			sp.StyleInfo.BackColor = SystemColors.Window
			sp.FloatNumericUpDownProperties.Maximum = 15.5
			sp.FloatNumericUpDownProperties.Minimum = 0.5
			sp.FloatNumericUpDownProperties.StartValue =.5
			sp.FloatNumericUpDownProperties.Step =.5
			sp.FloatNumericUpDownProperties.WrapValue = True
			sp.FloatNumericUpDownProperties.DecimalPlaces = 1
			sp.FloatNumericUpDownProperties.Orientation = FloatNumericUpDownProperties.OrientationType.Horizontal
			sp.FloatNumericUpDownProperties.InterceptArrowkeys = True
			sp.FloatNumericUpDownProperties.ThousandsSeparator = False

			style = Me.gridControl1(rowIndex, colIndex + 1)
			style.CellType = "FNumericUpDown"
			style.Text = "10.0"
			sp = New FloatNumericUpDownStyleProperties(style)
			sp.StyleInfo.BackColor = SystemColors.Window
			sp.FloatNumericUpDownProperties.Maximum = 15.5
			sp.FloatNumericUpDownProperties.Minimum = 0.5
			sp.FloatNumericUpDownProperties.Step =.5
			sp.FloatNumericUpDownProperties.DecimalPlaces = 1
			sp.FloatNumericUpDownProperties.Orientation = FloatNumericUpDownProperties.OrientationType.Vertical
'			#End Region

'			#End Region

			gridControl1.EndUpdate(True)
			gridControl1.Refresh()
		End Sub
	End Class
End Namespace