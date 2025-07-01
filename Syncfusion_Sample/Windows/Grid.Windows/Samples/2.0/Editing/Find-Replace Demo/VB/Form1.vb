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

Namespace GridFindReplace
	Partial Public Class Form1
		Inherits MetroForm
		Private frDialog As GridFindReplaceDialogSink
		Private frEvents As GridFindReplaceEventArgs
		Private options As GridFindTextOptions
		Private locInfo As Object

		Public Sub New()
			InitializeComponent()

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

'			#Region "Grid and its dialog "

			EnableControls(False)

			'Populate the grid control
			Dim r As New Random()
			For i As Integer = 1 To gridControl1.RowCount
				For j As Integer = 1 To gridControl1.ColCount
					gridControl1(i,j).Text = r.Next(100, 150).ToString()
				Next j
			Next i

			'Setup FindReplace dialog
			frDialog = New GridFindReplaceDialogSink(gridControl1)

			'Initial Settings
			options = GridFindTextOptions.None
			cmbOptions.SelectedIndex = 2
			Me.gridControl1.ForceCurrentCellMoveTo = True
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.CurrentCell.MoveTo(1, 1)
			gridControl1.TableStyle.TextColor = Color.MidnightBlue
'			#End Region
		End Sub

		#Region "Event Handlers"

		'FindNext
		Private Sub btnFindNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindNext.Click
			gridControl1.Selections.Clear()

			If cmbSearch.Text <> "" Then
				AddToSearchedList(cmbSearch.Text)

				SetOptions()
				locInfo = GridRangeInfo.Table()
				clearHighlight()
				frEvents = New GridFindReplaceEventArgs(cmbSearch.Text, "", options, locInfo)
				frDialog.Find(frEvents)

			End If
		End Sub

		'FindAll - Loops through the cells in the grid and highlights all the values 
		'that match with the given search string.
		Private Sub btnFindAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindAll.Click
			If cmbSearch.Text IsNot Nothing Then
				AddToSearchedList(cmbSearch.Text)

				SetOptions()
				locInfo = GridRangeInfo.Table()
				Dim selRange As GridRangeInfo = GridRangeInfo.Empty
				Dim rowIndex, colIndex As Integer
				If (options And GridFindTextOptions.SelectionOnly) <> GridFindTextOptions.None Then
					selRange = gridControl1.Selections.Ranges.ActiveRange

				ElseIf (options And GridFindTextOptions.ColumnOnly) <> GridFindTextOptions.None Then
					selRange = GridRangeInfo.Col(gridControl1.CurrentCell.ColIndex)

				ElseIf (options And GridFindTextOptions.WholeTable) <> GridFindTextOptions.None Then
					selRange = GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount)
				End If

				clearHighlight()

				Dim startTop As Integer = selRange.Top
				Dim startLeft As Integer = selRange.Left

				Do While GridFindReplaceDialogSink.GetNextCell(selRange, startTop, startLeft, False, chkSearchUp.Checked)
					Dim style As GridStyleInfo = gridControl1(startTop, startLeft)
					Dim renderer As GridCellRendererBase = gridControl1.CellRenderers(style.CellType)
					If renderer.FindText(cmbSearch.Text, startTop, startLeft, options, True) Then
						gridControl1.CurrentCell.GetCurrentCell(rowIndex, colIndex)
						gridControl1(rowIndex, colIndex).BackColor = Color.Orange
					End If
				Loop
			End If
		End Sub

		'Replace
		Private Sub btnReplace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReplace.Click
			If cmbSearch.Text <> "" AndAlso cmbReplace.Text <> "" Then
				AddToSearchedList(cmbSearch.Text)
				SetOptions()
				locInfo = GridRangeInfo.Table()
				frEvents = New GridFindReplaceEventArgs(cmbSearch.Text, cmbReplace.Text, options, locInfo)
				frDialog.Replace(frEvents)
			End If
		End Sub

		'ReplaceAll
		Private Sub btnReplaceAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReplaceAll.Click
			If cmbSearch.Text <> "" AndAlso cmbReplace.Text <> "" Then
				AddToSearchedList(cmbSearch.Text)
				SetOptions()
				locInfo = GridRangeInfo.Table()
				frEvents = New GridFindReplaceEventArgs(cmbSearch.Text, cmbReplace.Text, options, locInfo)
				frDialog.ReplaceAll(frEvents)
				clearHighlight()
			Else
				MessageBox.Show("Search/Replace value is missing")
			End If
		End Sub

		Private Sub cmbSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbSearch.TextChanged
			If cmbSearch.Text <> "" Then
				EnableControls(True)
			Else
				EnableControls(False)
			End If
		End Sub
		#End Region

		#Region "Helper methods"

		'Setup the search options.
		Private Sub SetOptions()
			options = GridFindTextOptions.None
			If chkMatchCase.Checked Then
				options = GridFindTextOptions.MatchCase
			End If
			If chkMatchWholeCell.Checked Then
				options = options Or GridFindTextOptions.MatchWholeCell
			End If
			If chkSearchUp.Checked Then
				options = options Or GridFindTextOptions.SearchUp
			End If

			Select Case cmbOptions.SelectedIndex
				Case 0
					options = options Or GridFindTextOptions.ColumnOnly
				Case 1
					options = options Or GridFindTextOptions.SelectionOnly
				Case 2
					options = options Or GridFindTextOptions.WholeTable
			End Select
		End Sub

		Private Sub EnableControls(ByVal enable As Boolean)
			Me.cmbReplace.Enabled = enable
			btnFindNext.Enabled = enable
			btnFindAll.Enabled = enable
			btnReplace.Enabled = enable
			btnReplaceAll.Enabled = enable
			chkMatchCase.Enabled = enable
			chkMatchWholeCell.Enabled = enable
			chkSearchUp.Enabled = enable
			cmbOptions.Enabled = enable
			lblReplaceWith.Enabled = enable
		End Sub

		'Set the backcolor of the cells being highlighted to their original color.
		Private Sub clearHighlight()
			For i As Integer = 1 To gridControl1.RowCount
				For j As Integer = 1 To gridControl1.ColCount
					gridControl1(i, j).BackColor = SystemColors.Window
				Next j
			Next i
		End Sub

		'Keep track of the search strings being entered.
		Private Sub AddToSearchedList(ByVal txt As String)
			If Not cmbSearch.Items.Contains(txt) Then
				cmbSearch.Items.Insert(0, txt)
			End If
		End Sub

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