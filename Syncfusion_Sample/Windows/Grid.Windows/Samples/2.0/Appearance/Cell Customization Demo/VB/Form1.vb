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

Namespace CellCustomization_2005
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()

			Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			initializeGrid()
		End Sub

		Private Sub initializeGrid()
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

'			#Region "Float Cells"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex,1,rowIndex+1,gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "FloatingCells"

			rowIndex += 3
			gridControl1(rowIndex, colIndex) = valuestyle
			gridControl1(rowIndex, colIndex).Text = "Control Overview"
			rowIndex += 1
			gridControl1.Model.TextDataExchange.PasteTextFromBuffer(String.Concat("Public Properties" & Constants.vbCrLf, "BackColor" & Constants.vbTab & "Gets or sets the background color for the control. " & Constants.vbCrLf, "Controls" & Constants.vbTab & "Gets the collection of controls contained within the control. " & Constants.vbCrLf, "Cursor" & Constants.vbTab & "Gets or sets the cursor that is displayed when the mouse pointer is over the control. " & Constants.vbCrLf, "DefaultBackColor" & Constants.vbTab & "Gets the default background color of the control. " & Constants.vbCrLf, "DefaultForeColor" & Constants.vbTab & "Gets the default foreground color of the control. " & Constants.vbCrLf, "Dock" & Constants.vbTab & "Gets or sets which edge of the parent container a control is docked to. " & Constants.vbCrLf, "Enabled" & Constants.vbTab & "Gets or sets a value indicating whether the control can respond to user interaction. " & Constants.vbCrLf, "Font" & Constants.vbTab & "Gets or sets the font of the text displayed by the control. " & Constants.vbCrLf, "ForeColor" & Constants.vbTab & "Gets or sets the foreground color of the control. " & Constants.vbCrLf, ""), GridRangeInfo.Cell(rowIndex, colIndex), Integer.MaxValue)
			gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount))
'			#End Region

'			#Region "CoveredCell"
			rowIndex = 16
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Covered Cells"

			rowIndex += 3

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + 2, colIndex+1))
			gridControl1(rowIndex, colIndex).BackColor = Color.Orange
			gridControl1(rowIndex, colIndex).Text = "Covered in rows & cols"
			gridControl1(rowIndex, colIndex).TextColor = Color.Black
			gridControl1(rowIndex, colIndex).Font.Bold = True
			gridControl1(rowIndex, colIndex).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex+3, rowIndex, colIndex + 5))
			gridControl1(rowIndex, colIndex + 3).BackColor = Color.Orange
            gridControl1(rowIndex, colIndex + 3).Text = "Covered in colums"
			gridControl1(rowIndex, colIndex + 3).TextColor = Color.Black
			gridControl1(rowIndex, colIndex + 3).Font.Bold = True
			gridControl1(rowIndex, colIndex + 3).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(rowIndex, colIndex + 3).HorizontalAlignment = GridHorizontalAlignment.Center

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex + 7, rowIndex + 5, colIndex + 7))
			gridControl1(rowIndex, colIndex + 7).BackColor = Color.Orange
            gridControl1(rowIndex, colIndex + 7).Text = "Covered in rows"
			gridControl1(rowIndex, colIndex + 7).TextColor = Color.Black
			gridControl1(rowIndex, colIndex + 7).Font.Bold = True
			gridControl1(rowIndex, colIndex + 7).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1(rowIndex, colIndex + 7).HorizontalAlignment = GridHorizontalAlignment.Center

'			#End Region

'			#Region "Banner Cells"
			rowIndex = 26
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Banner Cells"

			rowIndex += 3

			Dim style As GridStyleInfo
			style = gridControl1(rowIndex, colIndex)
			gridControl1.BanneredRanges.Add(GridRangeInfo.FromTlhw(rowIndex, colIndex, 8, colIndex + 1))
			style.BackgroundImage = GetImage("cloud2.png")
			style.Text = "cloud2.png"
			style.TextColor = Color.Red
			style.BackgroundImageMode = GridBackgroundImageMode.StretchImage


			style = gridControl1(rowIndex, colIndex + 5)
			gridControl1.BanneredRanges.Add(GridRangeInfo.FromTlhw(rowIndex, colIndex + 5, 8, colIndex + 1))
			style.Interior = New BrushInfo(GradientStyle.PathEllipse, SystemColors.Highlight, Color.White)
			style.Text = "GradientStyle.PathEllipse"
			style.TextColor = Color.Blue
'			#End Region

'			#Region "Custom Borders "
			rowIndex = 39
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Custom Borders Cells"

			AddHandler gridControl1.DrawCellFrameAppearance, AddressOf gridControl1_DrawCellFrameAppearance
			gridControl1.BeginUpdate()
			rowIndex += 3
			rindex = rowIndex
			cindex = colIndex
			For i As Integer = rowIndex To rindex + 5
				For j As Integer = colIndex To cindex + 7
					Dim newstyle As GridStyleInfo = gridControl1(i, j)
					newstyle.BorderMargins = New GridMarginsInfo(5, 5, 5, 5)
					newstyle.Borders.All = GridBorder.Empty
					newstyle.CellAppearance = GridCellAppearance.Flat
				Next j
			Next i
			gridControl1.EndUpdate(True)

'			#End Region

'			#Region "CustomDraw"
			gridControl1.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell
			rowIndex = 49
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Custom Drawing in  GridCells"

			Dim dt As New DataTable()
			dt.Columns.Add("BookID")
			dt.Columns.Add("BookName")
			dt.Columns.Add("Author")
			dt.Columns.Add("Price")
			dt.Rows.Add(New Object() { "BookID", "BookName", "Author", "Price" })
			dt.Rows.Add(New Object() { "1001", "Computer Networks", "Tanenbaum", "75.00" })
			dt.Rows.Add(New Object() { "1002", "DBMS", "Navbathe", "85.00" })
			dt.Rows.Add(New Object() { "1003", "Let us C", "Leland Beck", "50.00" })
			dt.Rows.Add(New Object() { "1004", "System Software", "Hamacher", "78.00" })
			dt.Rows.Add(New Object() { "1005", "Computer Organization", "Carl", "50.00" })
			dt.Rows.Add(New Object() { "1006", "Test your c skills", "Ivan", "75.00" })
			dt.Rows.Add(New Object() { "1007", "C#.Net", "Alexis", "50.00" })
			dt.Rows.Add(New Object() { "1008", "Multimedia", "Leon", "75.00" })
			dt.AcceptChanges()

			rowIndex += 3
			gridControl1(rowIndex, 6).Text = "Cart"
			gridControl1(rowIndex, 7).Text = "BookStatus"
			For i As Integer = rowIndex + 1 To 60
				Me.gridControl1(i, 6).CellValue = 0
			Next i

			gridControl1.PopulateValues(GridRangeInfo.Cells(52, 2, 60, 5), dt)

			For k As Integer = 53 To 60
				For l As Integer = 2 To 7
					gridControl1(k, l).Interior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(255, 187, 111), Color.White)
				Next l
			Next k


			For l As Integer = 2 To 7
				gridControl1(52, l).CellType = GridCellTypeName.Header

			Next l
			AddHandler gridControl1.CellClick, AddressOf HandleAClick
			'Handle the following events to do custom painting
			AddHandler gridControl1.CellDrawn, AddressOf gridControl1_CellDrawn
			AddHandler gridControl1.DrawCell, AddressOf gridControl1_DrawCell
'			#End Region
		End Sub

		#Region "Event Handlers"
		Private Sub HandleAClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			If e.RowIndex > 52 AndAlso e.ColIndex = 6 AndAlso e.RowIndex <= 60 Then
				Dim style As GridStyleInfo = Me.gridControl1(e.RowIndex, e.ColIndex)
				If style.CellValue.ToString() = "0" Then
					style.CellValue = 1

					For l As Integer = 2 To 7
						gridControl1(e.RowIndex, l).BackColor = Color.FromArgb(206, 213, 231)
					Next l
					Me.gridControl1.RowStyles(e.RowIndex).TextColor = Color.RoyalBlue
				Else
					style.CellValue = 0
					Me.gridControl1.RowStyles(e.RowIndex).TextColor = Color.Black
				End If
			End If
			Me.gridControl1.RefreshRange(GridRangeInfo.Row(e.RowIndex))
		End Sub

		Private Sub gridControl1_CellDrawn(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
			If e.ColIndex = 6 AndAlso e.RowIndex > 52 AndAlso e.RowIndex<=60 Then
				Dim rec As Rectangle = e.Bounds, rect As Rectangle = e.Bounds
				rec.X = (e.Bounds.Left + e.Bounds.Right) / 2
				If e.Style.CellValue.ToString() = "1" Then
					e.Graphics.FillEllipse(Brushes.Gray, rect)
					GridImageCellRenderer.DrawImage(e.Graphics, Me.imageList1, 1, rec, False)
				Else
					e.Graphics.FillEllipse(Brushes.LightGray, rect)
					GridImageCellRenderer.DrawImage(e.Graphics, Me.imageList1, 0, rec, False)
				End If
			End If
			If e.ColIndex = 7 AndAlso e.RowIndex > 52 AndAlso e.RowIndex <= 60 Then

				Dim rec As Rectangle = e.Bounds
				rec.X = (e.Bounds.Left + e.Bounds.Right) / 2
				If Me.gridControl1(e.RowIndex, 6).CellValue.ToString() = "1" Then
					Dim rect As Rectangle = e.Bounds
					GridImageCellRenderer.DrawImage(e.Graphics, Me.imageList1, 3, rec, False)
					e.Graphics.DrawLine(Pens.Red, rect.X, rect.Y, rect.X + rect.Width, rect.Y + rect.Height)
					e.Graphics.DrawLine(Pens.Red, rect.X, rect.Y + rect.Height, rect.X + rect.Width, rect.Y)

				Else
					GridImageCellRenderer.DrawImage(e.Graphics, Me.imageList1, 2, rec, False)
				End If
			End If
		End Sub

		Private Sub gridControl1_DrawCell(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
			If e.RowIndex >52 AndAlso e.RowIndex Mod 2 = 0 AndAlso e.ColIndex>=2 AndAlso e.ColIndex<=7 Then
				e.Style.Interior = New BrushInfo(GradientStyle.BackwardDiagonal, Color.FromArgb(51, 51, 101), Color.White)
			End If
		End Sub

		Private rindex, cindex As Integer
		Private backBmp As Image = Nothing
		Private tb As TextureBrush = Nothing

		Private Sub gridControl1_DrawCellFrameAppearance(ByVal sender As Object, ByVal e As GridDrawCellBackgroundEventArgs)
			Dim rowIndex As Integer = e.Style.CellIdentity.RowIndex
			Dim colIndex As Integer = e.Style.CellIdentity.ColIndex

			If rowIndex >= rindex AndAlso colIndex>=cindex AndAlso rowIndex <=rindex+5 AndAlso colIndex<=cindex+7 Then
				Dim brush As Brush
				Dim g As Graphics = e.Graphics


				' Use TextureBrush for upper left cells
				If colIndex < 6 AndAlso rowIndex < 12 Then
					brush = tb
				Else
					' Otherwise use a gradient brush
					brush = New System.Drawing.Drawing2D.LinearGradientBrush(e.TargetBounds, Color.FromArgb(204, 212, 230), Color.FromArgb(252, 172, 38), 45f)
				End If

				' Draw custom border for the cell. Space has been reserved for this
				' area with the TableStyle.BorderMargins property.
				Dim rect As Rectangle = e.TargetBounds
				rect.Inflate(-2, -2)
				Dim rects() As Rectangle = { New Rectangle(rect.X, rect.Y, rect.Width, 4), New Rectangle(rect.X, rect.Y, 4, rect.Height), New Rectangle(rect.Right-4, rect.Y, 4, rect.Height), New Rectangle(rect.X, rect.Bottom-4, rect.Width, 4) }
				g.FillRectangles(brush, rects)

				' Disallow grids default drawing of cell frame for this cell
				e.Cancel = True
			End If
		End Sub

		Private Function GetImage(ByVal bitmapName As String) As Image
			Dim bitmap As Image = Nothing

			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					bitmap = New Bitmap(bitmapName)
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmap
		End Function

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

	End Class
End Namespace