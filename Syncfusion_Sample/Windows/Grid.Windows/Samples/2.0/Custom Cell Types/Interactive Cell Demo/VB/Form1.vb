Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms
Imports Syncfusion.GridHelperClasses
Imports System.IO

Namespace InteractiveCellDemo
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

#If HELPERCLASS Then
		Private bsp As Syncfusion.GridHelperClasses.ButtonEditStyleProperties
#Else
		Private bsp As ButtonEditStyleProperties
#End If

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

			gridControl1.BeginUpdate()

'			#Region "CellButton"
			Dim rowIndex As Integer = 1, colIndex As Integer = 5
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Cell Buttons"
			gridControl1.CellModels.Add("DragButton", New DragButtonCellModel(gridControl1.Model))
			rowIndex = 4
			gridControl1(rowIndex, 2).Text = "Press and Drag Button"
			gridControl1(rowIndex, 2).Font.Bold = True
			gridControl1(rowIndex, 4).CellType = "DragButton"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex,2, rowIndex,3))

			gridControl1.CellModels.Add("EllipsisText", New EllipsisCellModel(gridControl1.Model))

			gridControl1(rowIndex, 6).Text = "Browse Me"
			gridControl1(rowIndex, 6).Font.Bold = True
			gridControl1(rowIndex, 6).CellType = "EllipsisText"
			gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(3, 6, 10, 6))
'			#End Region

'			#Region "OleCntainerCell"

			colIndex = 2
			RegisterCellModel.GridCellType(Me.gridControl1, CustomCellTypes.OleContainerCell)
			rowIndex += 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1.CellModels.Add("LinkLabelCell", New LinkLabelCellModel(gridControl1.Model))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "OLEContainer Cell"

			rowIndex += 2
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Text = "Click the image to open the file with its default file handler"

			rowIndex += 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex))
			gridControl1(rowIndex, colIndex).CellType = CustomCellTypes.OleContainerCell.ToString()
            gridControl1(rowIndex, colIndex).Description = GetIconFile("common\Data\DocIO\SalesInvoiceDemo.doc")

			colIndex = 4
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex))
			gridControl1(rowIndex, colIndex).CellType = CustomCellTypes.OleContainerCell.ToString()
            gridControl1(rowIndex, colIndex).Description = GetIconFile("common\Data\XlsIO\BudgetPlanner.xls")

			colIndex = 6
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex))
			gridControl1(rowIndex, colIndex).CellType = CustomCellTypes.OleContainerCell.ToString()
            gridControl1(rowIndex, colIndex).Description = GetIconFile("common\Data\PDF\CaseStudy.pdf")

			colIndex = 2
			rowIndex += 4
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex))
			gridControl1(rowIndex, colIndex).CellType = CustomCellTypes.OleContainerCell.ToString()
            gridControl1(rowIndex, colIndex).Description = GetIconFile("common\Data\DocIO\Arabic.txt")

			colIndex = 4
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex))
			gridControl1(rowIndex, colIndex).CellType = CustomCellTypes.OleContainerCell.ToString()
            gridControl1(rowIndex, colIndex).Description = GetIconFile("common\Images\Grid\CustomBorder\back3.jpg")

			colIndex = 6
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex))
			gridControl1(rowIndex, colIndex).CellType = CustomCellTypes.OleContainerCell.ToString()
            gridControl1(rowIndex, colIndex).Description = "http://www.syncfusion.com/"


			gridControl1(13, 8) = subheaderstyle
			gridControl1(13, 8).Text = "Preview"
			gridControl1(13, 8).BackColor = Color.LightGray

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(14, 8, 16, 8))

			gridControl1(17, 8).CellType = GridCellTypeName.PushButton
			gridControl1(17, 8).Description = "Select a file for preview"
			Me.gridControl1.Model.ColWidths(8) = 127
			rowIndex += 1

			colIndex = 5


'			#End Region

'			#Region "SliderCells"
			rowIndex += 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Slider Cells"

			gridControl1.CellModels.Add("Slider", New SliderCellModel(gridControl1.Model))
			rowIndex += 3

			Dim tsp As New SliderStyleProperties(New GridStyleInfo(gridControl1.TableStyle))
			tsp.Orientation = Orientation.Horizontal

			Dim style As GridStyleInfo
			Dim sp As SliderStyleProperties

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex+1, 4))
			style = gridControl1(rowIndex, 3)
			sp = New SliderStyleProperties(style)
			style.CellType = "Slider"
			sp.Maximum = 60
			sp.Minimum = 0
			sp.TickFrequency = 8
			sp.LargeChange = 16
			sp.SmallChange = 4
			sp.Orientation = Orientation.Horizontal

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 5, rowIndex + 1, 5))
			style = gridControl1(rowIndex, 5)
			sp = New SliderStyleProperties(style)
			style.CellType = "Slider"
			sp.Maximum = 40
			sp.Minimum = 0
			sp.TickFrequency = 8
			sp.LargeChange = 16
			sp.SmallChange = 4
			sp.Orientation = Orientation.Horizontal

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 6, rowIndex + 7, 6))
			style = gridControl1(rowIndex, 6)
			sp = New SliderStyleProperties(style)
			style.CellType = "Slider"
			sp.Maximum = 40
			sp.Minimum = 0
			sp.TickFrequency = 8
			sp.LargeChange = 16
			sp.SmallChange = 4
			sp.Orientation = Orientation.Vertical
			gridControl1.EndUpdate(True)
'			#End Region

'			#Region "ButtonEdit Cells"
			rowIndex = 31

#If HELPERCLASS Then
			' Added from the source of Syncfusion.GridHelperClasses
			RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.ButtonEdit)
#Else
			Me.gridControl1.CellModels.Add("ButtonEdit", New ButtonEditCellModel(Me.gridControl1.Model))
#End If
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Button Edit Cells"
			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Text = "ButtonEdit displaying common images and getting from file"
			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, 2).FloatCell = True
			gridControl1(rowIndex, 2).Text = "Common Images"
			gridControl1(rowIndex, 2).TextColor = Color.Black
			gridControl1(rowIndex, 4).CellType = "ButtonEdit"

#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(Me.gridControl1(rowIndex, 4))
			bsp.ButtonEditInfo.ButtonEditType = Syncfusion.GridHelperClasses.ButtonType.Check
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 4))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Check
#End If

			gridControl1(rowIndex, 5).CellType = "ButtonEdit"

#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Down
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Down
#End If
			gridControl1(rowIndex, 6).CellType = "ButtonEdit"

#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Undo
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Undo
#End If
			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, 2).FloatCell = True
			gridControl1(rowIndex, 2).Text = "From File"
			gridControl1(rowIndex, 2).TextColor = Color.Black
			gridControl1(rowIndex, 4).CellType = "ButtonEdit"

#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 4))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 4))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image
#End If
			Dim bmp As Image = Image.FromFile("..//..//delete.png")
			bsp.ButtonEditInfo.Image = bmp

			gridControl1(rowIndex, 5).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image
#End If
			bmp = Image.FromFile("..//..//about.png")
			bsp.ButtonEditInfo.Image = bmp

			gridControl1(rowIndex, 6).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Image
#End If
			bmp = Image.FromFile("..//..//disk_blue.png")
			bsp.ButtonEditInfo.Image = bmp


			rowIndex += 1
			rowIndex += 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Text = "ButtonEdit cell with formatting options like textcolor, alignment, borders.."
			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, 2).FloatCell = True
			gridControl1(rowIndex, 2).Text = "With Colors"
			gridControl1(rowIndex, 2).TextColor = Color.Black

			gridControl1(rowIndex, 4).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 4))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 4))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#End If
			bsp.ButtonEditInfo.ForceBackColor = True
			bsp.ButtonEditInfo.BackColor = Color.LightGreen

			gridControl1(rowIndex, 5).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#End If
			bsp.ButtonEditInfo.ForceBackColor = True
			bsp.ButtonEditInfo.BackColor = Color.LightPink

			gridControl1(rowIndex, 6).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#End If
			bsp.ButtonEditInfo.ForceBackColor = True
			bsp.ButtonEditInfo.BackColor = Color.LightSkyBlue

			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, 2).FloatCell = True
			gridControl1(rowIndex, 2).Text = "Text Alignment"
			gridControl1(rowIndex, 2).TextColor = Color.Black

			gridControl1(rowIndex, 4).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 4))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 4))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#End If
			bsp.ButtonEditInfo.Width = 50
			bsp.ButtonEditInfo.Text = "Sync"
			bsp.ButtonEditInfo.HorizontalAlignment = GridHorizontalAlignment.Right
			bsp.ButtonEditInfo.VerticalAlignment = GridVerticalAlignment.Top

			gridControl1(rowIndex, 5).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#End If
			bsp.ButtonEditInfo.Width = 50
			bsp.ButtonEditInfo.Text = "Sync"
			bsp.ButtonEditInfo.HorizontalAlignment = GridHorizontalAlignment.Left
			bsp.ButtonEditInfo.VerticalAlignment = GridVerticalAlignment.Bottom

			gridControl1(rowIndex, 6).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.None
#End If
			bsp.ButtonEditInfo.Width = 50
			bsp.ButtonEditInfo.Text = "Sync"
			bsp.ButtonEditInfo.HorizontalAlignment = GridHorizontalAlignment.Center
			bsp.ButtonEditInfo.VerticalAlignment = GridVerticalAlignment.Middle

			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, 2).FloatCell = True
			gridControl1(rowIndex, 2).Text = "Button Alignment with Left & Right"
			gridControl1(rowIndex, 2).TextColor = Color.Black

			gridControl1.Model.RowHeights(rowIndex) = 20

			gridControl1(rowIndex, 5).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Leftend
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 5))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Leftend
#End If
			bsp.ButtonEditInfo.IsLeft = True

			gridControl1(rowIndex, 6).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Rightend
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 6))
			bsp.ButtonEditInfo.ButtonEditType = ButtonType.Rightend
#End If
			bsp.ButtonEditInfo.IsLeft = False

			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, 2).FloatCell = True
			gridControl1(rowIndex, 2).Text = "Border around button"
			gridControl1(rowIndex, 2).TextColor = Color.Black

			gridControl1(rowIndex, 5).CellType = "ButtonEdit"
#If HELPERCLASS Then
			bsp = New Syncfusion.GridHelperClasses.ButtonEditStyleProperties(gridControl1(rowIndex, 5))
#Else
			bsp = New ButtonEditStyleProperties(gridControl1(rowIndex, 5))
#End If
			bsp.ButtonEditInfo.Width = 30

#If HELPERCLASS Then
			AddHandler (CType(gridControl1.CellModels("ButtonEdit"), Syncfusion.GridHelperClasses.ButtonEditCellModel)).GridDrawButtonFace, AddressOf Form1_GridDrawButtonFace
#Else
			AddHandler (CType(gridControl1.CellModels("ButtonEdit"), ButtonEditCellModel)).GridDrawButtonFace, AddressOf Form1_GridDrawButtonFace
#End If
'			#End Region


'			#Region "LinkLabel"
			rowIndex += 3
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			'gridControl1.CellModels.Add("LinkLabelCell", new LinkLabelCellModel(gridControl1.Model));
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Link Label Cells"

			rowIndex += 3
			gridControl1(rowIndex, colIndex).CellType = "LinkLabelCell"
			gridControl1(rowIndex, colIndex).Text = "Syncfusion, Inc."
			gridControl1(rowIndex, colIndex).Font.Bold = True
			gridControl1(rowIndex, colIndex).Tag = "http://www.syncfusion.com"
			gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center

			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, colIndex).CellType = "LinkLabelCell"
			gridControl1(rowIndex, colIndex).Text = "Windows Forms FAQ"
			gridControl1(rowIndex, colIndex).Font.Bold = True
			gridControl1(rowIndex, colIndex).Tag = "http://www.syncfusion.com/support/forums/grid-windows"
			gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center

			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, colIndex).CellType = "LinkLabelCell"
			gridControl1(rowIndex, colIndex).Text = "Microsoft Windows Forms"
			gridControl1(rowIndex, colIndex).Font.Bold = True
			gridControl1(rowIndex, colIndex).Tag = "http://windowsforms.net/"
			gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center

			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, colIndex).CellType = "LinkLabelCell"
			gridControl1(rowIndex, colIndex).Text = "MSDN"
			gridControl1(rowIndex, colIndex).Font.Bold = True
			gridControl1(rowIndex, colIndex).Tag = "http://msdn.microsoft.com"
			gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center

			gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(9, 5, 17, 5))
'			#End Region

			gridControl1.EndUpdate(True)
			gridControl1.Refresh()
		End Sub
		Private Sub Form1_GridDrawButtonFace(ByVal sender As Object, ByVal e As GridDrawButtonFaceEventArgs)
			If e.RowIndex = 47 AndAlso e.ColIndex = 5 Then
				Dim br As Brush = New SolidBrush(Color.SaddleBrown)
				Dim pn As New Pen(Color.SaddleBrown, 2)

				' Draw border around the button
				e.Graphics.DrawLine(pn, New Point(e.Button.Bounds.X + 2, e.Button.Bounds.Y + 2), New Point(e.Button.Bounds.X + e.Button.Bounds.Width - 2, e.Button.Bounds.Y + 2))
				e.Graphics.DrawLine(pn, New Point(e.Button.Bounds.X + 2, e.Button.Bounds.Y + 2), New Point(e.Button.Bounds.X + 2, e.Button.Bounds.Y + e.Button.Bounds.Height - 2))
				e.Graphics.DrawLine(pn, New Point(e.Button.Bounds.X + 2, e.Button.Bounds.Y + e.Button.Bounds.Height - 2), New Point(e.Button.Bounds.X + e.Button.Bounds.Width - 2, e.Button.Bounds.Y + e.Button.Bounds.Height - 2))
				e.Graphics.DrawLine(pn, New Point(e.Button.Bounds.X + e.Button.Bounds.Width - 2, e.Button.Bounds.Y + 2), New Point(e.Button.Bounds.X + e.Button.Bounds.Width - 2, e.Button.Bounds.Y + e.Button.Bounds.Height - 2))

				e.Handled = True
			End If
		End Sub


		#Region "Event Handlers"
		Private Sub gridControl1_CellButtonClicked(ByVal sender As Object, ByVal e As GridCellButtonClickedEventArgs) Handles gridControl1.CellButtonClicked
			Dim rg As GridRangeInfo = GridRangeInfo.Cell(e.RowIndex, e.ColIndex)
			If e.ColIndex = 7 Then
				MessageBox.Show("Clicked button at " & rg.ToString())
			End If
			If e.ColIndex = 8 Then
				Dim result As DialogResult = openFileDialog1.ShowDialog()
				If result = System.Windows.Forms.DialogResult.OK Then
					Dim file As String = openFileDialog1.FileName
					Try
						setFile(file)
					Catch e1 As IOException
					End Try
				End If
			End If
		End Sub

		Private Sub setFile(ByVal address As String)
			Dim rowIndex As Integer = 14, colIndex As Integer = 8
			Me.gridControl1(rowIndex, colIndex).CellType = CustomCellTypes.OleContainerCell.ToString()
			Me.gridControl1(rowIndex, colIndex).Description = address

		End Sub
		#End Region

	End Class
End Namespace