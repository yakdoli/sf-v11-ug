Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System.Collections.Specialized
Imports Syncfusion.Windows.Forms

Namespace WindowsApplication1
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

		#Region "Icon handlers"
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
			Me.gridControl1.BeginUpdate()

'			#Region "PushButtons"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount))
			gridControl1(1, 1).Text = "Push Buttons"
			gridControl1(1, 1).Font.Size = 14
			gridControl1(1, 1).Font.Bold = True
			gridControl1(1, 1).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(1, 1).HorizontalAlignment = GridHorizontalAlignment.Center
			gridControl1(1, 1).CellType = "Static"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(3, 1, 3, gridControl1.ColCount))
			gridControl1(3, 1).Text = "PushButton Cells - supports Flat, Raised and Sunken styles"
			gridControl1(3, 1).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(3, 1).HorizontalAlignment = GridHorizontalAlignment.Center
			gridControl1(3, 1).CellType = "Static"

			Dim rowIndex As Integer = 5, colIndex As Integer = 3
			gridControl1(rowIndex, colIndex).Description = "Flat"
			gridControl1(rowIndex, colIndex).CellType = GridCellTypeName.PushButton
			gridControl1(rowIndex, colIndex).Font.Size = 8
			gridControl1(rowIndex, colIndex + 2).Description = "Raised"
			gridControl1(rowIndex, colIndex + 2).CellType = GridCellTypeName.PushButton
			gridControl1(rowIndex, colIndex + 2).Font.Size = 8
			gridControl1(rowIndex, colIndex + 2).CellAppearance = GridCellAppearance.Raised
			gridControl1(rowIndex, colIndex + 4).Description = "Sunken"
			gridControl1(rowIndex, colIndex + 4).CellType = GridCellTypeName.PushButton
			gridControl1(rowIndex, colIndex + 4).Font.Size = 8
			gridControl1(rowIndex, colIndex + 4).CellAppearance = GridCellAppearance.Sunken
'			#End Region

'			#Region "RadioButtons"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(8, 1, 9, gridControl1.ColCount))
			gridControl1(8, 1).Text = "Radio Buttons"
			gridControl1(8, 1).Font.Size = 14
			gridControl1(8, 1).Font.Bold = True
			gridControl1(8, 1).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(8, 1).HorizontalAlignment = GridHorizontalAlignment.Center
			gridControl1(8, 1).CellType = "Static"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(10, 1, 10, gridControl1.ColCount))
			gridControl1(10, 1).Text = "RadioButton cell type enables multiple radio buttons in a cell and their behavior is grouped"
			gridControl1(10, 1).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(10, 1).HorizontalAlignment = GridHorizontalAlignment.Center
			gridControl1(10, 1).CellType = "Static"
			Dim sc As New StringCollection()
			sc.AddRange(New String(){ "Button 0", "Disabled/disabled", "Button 2", "Button 3"})
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(12, 1, 12, gridControl1.ColCount))
			rowIndex = 12
			Me.gridControl1(rowIndex, 1).ChoiceList = sc
			Me.gridControl1(rowIndex, 1).CellType = "RadioButton"
			Me.gridControl1(rowIndex, 1).Font.Bold = True
			Me.gridControl1(rowIndex, 1).CellValue = 0 'selected button
			Me.gridControl1(rowIndex, 1).TextAlign = GridTextAlign.Left 'where descriptions are
			Me.gridControl1(rowIndex, 1).TextMargins.Left = 5
			Me.gridControl1(rowIndex, 1).TextMargins.Right = 5
'			#End Region

'			#Region "CheckBoxes"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(15, 1, 16, gridControl1.ColCount))
			gridControl1(15, 1).Text = "CheckBoxes"
			gridControl1(15, 1).Font.Size = 14
			gridControl1(15, 1).Font.Bold = True
			gridControl1(15, 1).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(15, 1).HorizontalAlignment = GridHorizontalAlignment.Center
			gridControl1(15, 1).CellType = "Static"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(17, 1, 17, gridControl1.ColCount))
			gridControl1(17, 1).Text = "Checkbox Cells - supports triState/disabled states"
			gridControl1(17, 1).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(17, 1).HorizontalAlignment = GridHorizontalAlignment.Center
			gridControl1(17, 1).CellType = "Static"

			rowIndex = 19
			gridControl1.TableStyle.CheckBoxOptions = New GridCheckBoxCellInfo("True", "False", "", False)
			gridControl1(rowIndex, colIndex).CellValue = False
			gridControl1(rowIndex, colIndex).Description = "Click Me"
			gridControl1(rowIndex, colIndex).CellType = "CheckBox"
			gridControl1(rowIndex, colIndex).TriState = False
			gridControl1(rowIndex, colIndex + 2).CellValue = True
			gridControl1(rowIndex, colIndex + 2).CellType = "CheckBox"
			gridControl1(rowIndex, colIndex + 2).TriState = True
			gridControl1(rowIndex, colIndex + 2).Description = "TriState"
			gridControl1(rowIndex, colIndex + 2).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(rowIndex, colIndex + 4).Text = "True"
			gridControl1(rowIndex, colIndex + 4).CellType = "CheckBox"
			gridControl1(rowIndex, colIndex + 4).TriState = False
			gridControl1(rowIndex, colIndex + 4).Description = "Disabled"
			gridControl1(rowIndex, colIndex + 4).Enabled = False
			gridControl1(rowIndex, colIndex + 4).VerticalAlignment = GridVerticalAlignment.Bottom
'			#End Region

			Me.gridControl1.EndUpdate()
			Me.gridControl1.Refresh()
		End Sub

		#Region "EventHandlers"
		Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckStateChanged
			If Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro Then
				Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue
				Me.gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
			Else
				Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
			End If

			Me.gridControl1.Refresh()
		End Sub
		#End Region
	End Class
End Namespace