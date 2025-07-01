Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms

Namespace GridStyle_2005
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
'			#Region "CellStyleGridControl"
			gridControl1.Model.Options.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation

			Dim boldFont As New GridFontInfo()
			boldFont.Bold = True
			boldFont.Size = 11
			boldFont.Underline = True

			Dim rowIndex As Integer = 2
			Dim colIndex As Integer = 1

			gridControl1.Rows.DefaultSize += 2
			Dim boldfontRowHeight As Integer = gridControl1.Rows.DefaultSize + 6

			gridControl1.Model.Options.ControllerOptions = GridControllerOptions.All
			gridControl1.Model.Options.DataObjectConsumerOptions = GridDataObjectConsumerOptions.All

			Dim standard As GridStyleInfo = gridControl1.BaseStylesMap("Standard").StyleInfo
			Dim header As GridStyleInfo = gridControl1.BaseStylesMap("Header").StyleInfo
			Dim rowHeader As GridStyleInfo = gridControl1.BaseStylesMap("Row Header").StyleInfo
			Dim colHeader As GridStyleInfo = gridControl1.BaseStylesMap("Column Header").StyleInfo

			header.Interior = New BrushInfo(SystemColors.Control)
			rowHeader.Interior = New BrushInfo(SystemColors.Control)

			standard.Font.Facename = "Arial" '"Helvetica";
			header.Enabled = False

			gridControl1.Model.Options.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "Interior"
			gridControl1(rowIndex, 1).Font = boldFont

			boldfontRowHeight = gridControl1.RowHeights(rowIndex)
			rowIndex += 1

			colIndex = 1
			For Each color As Color In New Color() { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.DimGray}
				gridControl1(rowIndex, colIndex).Interior = New BrushInfo(color)
				colIndex += 1
			Next color
			rowIndex += 1
			colIndex = 1
			For Each pattern As PatternStyle In New PatternStyle() { PatternStyle.LightVertical, PatternStyle.DarkDownwardDiagonal, PatternStyle.DashedHorizontal, PatternStyle.DottedDiamond, PatternStyle.SmallCheckerBoard, PatternStyle.SmallGrid}
				gridControl1(rowIndex, colIndex).Interior = New BrushInfo(pattern, Color.Black, Color.White)
				colIndex += 1
			Next pattern
			rowIndex += 1
			colIndex = 1
			For Each pattern As GradientStyle In New GradientStyle() { GradientStyle.BackwardDiagonal, GradientStyle.ForwardDiagonal, GradientStyle.PathEllipse, GradientStyle.PathRectangle, GradientStyle.Vertical, GradientStyle.Horizontal}
				gridControl1(rowIndex, colIndex).Interior = New BrushInfo(pattern, Color.FromArgb(&Hde, &H64, &H13), Color.Black) 'Color.Yellow, Color.Blue);
				gridControl1(rowIndex, colIndex).CellAppearance = GridCellAppearance.Raised
				gridControl1(rowIndex + 1, colIndex).Interior = New BrushInfo(pattern, Color.FromArgb(&H82, &H2e, &H1b), Color.White) 'Color.Red, Color.White);
				gridControl1(rowIndex + 1, colIndex).CellAppearance = GridCellAppearance.Sunken
				colIndex += 1
			Next pattern

			rowIndex += 1
			rowIndex += 1
			rowIndex += 1
			colIndex = 1

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "Font"
			gridControl1(rowIndex, 1).Font = boldFont
			gridControl1.RowHeights(rowIndex) = boldfontRowHeight
			rowIndex += 1

			For Each size As Integer In New Integer(){ 6, 7, 8, 10, 12, 14}
				gridControl1(rowIndex, colIndex).Font.Size = size
				gridControl1(rowIndex, colIndex).Text = size.ToString()
				colIndex += 1
			Next size
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex))

			rowIndex += 1
			colIndex = 1
			For Each fontStyle As FontStyle In New FontStyle() { FontStyle.Bold, FontStyle.Italic, FontStyle.Regular, FontStyle.Strikeout, FontStyle.Underline, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Regular}
				gridControl1(rowIndex, colIndex).Font.FontStyle = fontStyle
				gridControl1(rowIndex, colIndex).Text = System.Enum.Format(GetType(FontStyle), fontStyle, "G")
				colIndex += 1
			Next fontStyle

			rowIndex += 1
			rowIndex += 1
			colIndex = 1

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "TextColor"
			gridControl1(rowIndex, 1).Font = boldFont
			gridControl1.RowHeights(rowIndex) = boldfontRowHeight
			rowIndex += 1

			colIndex = 1
			For Each color As Color In New Color() { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.DimGray}
				gridControl1(rowIndex, colIndex).TextColor = color
				gridControl1(rowIndex, colIndex).Text = ColorConvert.ColorToString(color, True)
				colIndex += 1
			Next color

			rowIndex += 1
			rowIndex += 1

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "Borders"
			gridControl1(rowIndex, 1).Font = boldFont
			gridControl1.RowHeights(rowIndex) = boldfontRowHeight
			rowIndex += 1
			colIndex = 1

			For Each border As GridBorder In New GridBorder() { New GridBorder(GridBorderStyle.Solid, Color.Black), New GridBorder(GridBorderStyle.Dotted, Color.Red), New GridBorder(GridBorderStyle.DashDot, Color.Black), New GridBorder(GridBorderStyle.DashDotDot, Color.Red), New GridBorder(GridBorderStyle.Dashed, Color.Black, GridBorderWeight.Medium), New GridBorder(GridBorderStyle.Dotted, Color.Red, GridBorderWeight.Medium)}
				gridControl1(rowIndex, colIndex).Borders.Bottom = border
				gridControl1(rowIndex, colIndex).Borders.Right = border
				gridControl1(rowIndex, colIndex).Text = border.ToString()
				colIndex += 1
			Next border

			rowIndex += 1
			colIndex = 1
			For Each border As GridBorder In New GridBorder() { New GridBorder(GridBorderStyle.Dashed, Color.Black, GridBorderWeight.Thick), New GridBorder(GridBorderStyle.Dotted, Color.Red, GridBorderWeight.Thick), New GridBorder(GridBorderStyle.DashDot, Color.Black, GridBorderWeight.Medium), New GridBorder(GridBorderStyle.DashDotDot, Color.Red, GridBorderWeight.Medium), New GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Thick), New GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.Medium)}
				gridControl1(rowIndex, colIndex).Borders.Bottom = border
				gridControl1(rowIndex, colIndex).Borders.Right = border
				gridControl1(rowIndex, colIndex).Text = border.ToString()
				colIndex += 1
			Next border

			rowIndex += 1
			rowIndex += 1
			colIndex = 1

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "Orientation"
			gridControl1(rowIndex, 1).Font = boldFont
			gridControl1.RowHeights(rowIndex) = boldfontRowHeight
			rowIndex += 1

			For Each orientation As Integer In New Integer() { 0, 45, 60, 90, 180, -90}
				Dim style1 As GridStyleInfo = gridControl1(rowIndex, colIndex)
				' style1 is a direct reference to gridControl1[rowIndex, colIndex]; 
				' changes will be propagated back to GridData
				style1.HorizontalAlignment = GridHorizontalAlignment.Center
				style1.VerticalAlignment = GridVerticalAlignment.Middle
				Dim font As GridFontInfo = style1.Font
				font.Orientation = orientation
				font.Bold = True
				style1.Text = "Angle = " & font.Orientation.ToString()
				colIndex += 1
			Next orientation

			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex))

			rowIndex += 1
			rowIndex += 1
			colIndex = 1

			gridControl1.CurrentCell.MoveTo(2, 2)

			Me.gridControl1.DefaultRowHeight = 18
			Me.gridControl1.DefaultColWidth = 70

			Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid
'			#End Region

'			#Region "StyleObject Grid"
			'change the header's BackColor
			gridControl2.BaseStylesMap("Header").StyleInfo.BackColor = Color.FromArgb(238, 240, 246)
			gridControl2.BaseStylesMap("Row Header").StyleInfo.BackColor = Color.FromArgb(238, 240, 246)

			'add a new basestyle
			gridBaseStyle1 = New GridBaseStyle("BackColorTest", False)
			gridControl2.BaseStylesMap("BackColorTest").StyleInfo.BackColor = Color.SkyBlue


'			#End Region

		End Sub

		#Region "EventHandlers"
		Private Sub ApplySettings(ByVal sender As Object, ByVal e As EventArgs) Handles BaseStyleCheck.CheckedChanged, Cell32Check.CheckedChanged, Column2Check.CheckedChanged, Row3Check.CheckedChanged, TableCheck.CheckedChanged, StandardCheck.CheckedChanged
			ApplyCheck(gridControl2.BaseStylesMap("Standard").StyleInfo, StandardCheck, StandardColor)
			ApplyCheck(gridControl2.TableStyle, TableCheck, TableColor)
			ApplyCheck(gridControl2.RowStyles(3), Row3Check, Row3Color)
			ApplyCheck(gridControl2.ColStyles(2), Column2Check, Column2Color)
			ApplyCheck(gridControl2(3, 2), Cell32Check, Cell32Color)

			ApplyBaseCheck(gridControl2.BaseStylesMap("BackColorTest").StyleInfo, BaseStyleCheck, BaseStyleColor)
		End Sub

		Private Sub ApplyCheck(ByVal style As GridStyleInfo, ByVal check As CheckBox, ByVal _color As ColorPickerButton)
			_color.BackColor = _color.SelectedColor
			If check.Checked Then
				style.BackColor = _color.SelectedColor
			Else
				style.ResetInterior()
			End If
		End Sub

		Private Sub ApplyBaseCheck(ByVal style As GridStyleInfo, ByVal check As CheckBox, ByVal _color As ColorPickerButton)
			_color.BackColor = _color.SelectedColor
			Dim style1 As New GridStyleInfo()
			If check.Checked Then
				style.BackColor = _color.SelectedColor
				style1.BaseStyle = "BackColorTest"
				gridControl2.ChangeCells(GridRangeInfo.Cells(2, 1, 4, 4), style1)

			Else
				style1.ResetBaseStyle()
				gridControl2.ChangeCells(GridRangeInfo.Cells(2, 1, 4, 4), style1)

			End If
		End Sub
		#End Region

	End Class
End Namespace