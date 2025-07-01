Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System.IO

Namespace FindReplaceDemo_2005
	Partial Public Class Form1
		Inherits Form
		Private ds As DataSet
		Private frDialog As GridFindReplaceDialogSink
		Private frEvents As GridFindReplaceEventArgs
		Private options As GridFindTextOptions
		Private locInfo As Object
		Public Sub New()
			InitializeComponent()
			Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
				Me.Icon = ico
			Catch
			End Try
			ds = New DataSet()
			ReadXml(ds, "\common\Data\GDBDdata.XML")
			Me.gridDataBoundGrid1.DataSource = ds.Tables("products")
			Me.gridDataBoundGrid1.Model.EnableLegacyStyle = False
			Me.gridDataBoundGrid1.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Blue
			Me.StartPosition = FormStartPosition.CenterScreen
			Me.grpBoxFindReplace.BackColor = Color.LightBlue
			Me.BackColor = Me.grpBoxFindReplace.BackColor

			'Setup FindReplace dialog
			frDialog = New GridFindReplaceDialogSink(Me.gridDataBoundGrid1)
			options = GridFindTextOptions.None
			cmbBoxOptions.SelectedIndex = 2
			Me.gridDataBoundGrid1.ForceCurrentCellMoveTo = True
			Me.gridDataBoundGrid1.CurrentCell.MoveTo(1, 1)
			AddHandler gridDataBoundGrid1.Model.QueryCellInfo, AddressOf Model_QueryCellInfo
		End Sub

		#Region "Sample Helper"
		Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Exit For
				End If
				xmlFileName = "..\" & xmlFileName
			Next n
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
		#End Region ' Sample Helper

		#Region "Find and Replace"
		Private findAll As Boolean = False
		Private resetAll As Boolean = False
		Private Sub Model_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
			If findAll Then
				Dim gcc As GridCurrentCell = Me.gridDataBoundGrid1.CurrentCell
				If Me.cmbBoxOptions.Text.Equals("WholeTable") Then
					SetCellBackColor(e)
				ElseIf cmbBoxOptions.Text.Equals("ColumnOnly") AndAlso gcc IsNot Nothing Then
					If e.ColIndex = gcc.ColIndex Then
						SetCellBackColor(e)
					End If
				End If
			ElseIf resetAll Then
				e.Style.BackColor = SystemColors.Window
			End If
		End Sub

		Private Sub SetCellBackColor(ByVal e As GridQueryCellInfoEventArgs)
			Dim text As String = e.Style.Text
			Dim userText As String = cmbBoxSearch.Text.Trim()
			If Not chkBoxMatchCase.Checked Then
				text = text.ToLower()
				userText = userText.ToLower()
			End If
			If Me.chkBoxMatchWholeCell.Checked Then
				If text.Equals(userText) Then
					e.Style.BackColor = Color.Orange
				End If
			Else
				If text.Contains(userText) Then
					e.Style.BackColor = Color.Orange
				End If
			End If
		End Sub


		'FindNext
		Private Sub btnFindNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindNext.Click
			If cmbBoxSearch.Text <> String.Empty Then
				AddToSearchedList(cmbBoxSearch.Text)
				SetOptions()
				locInfo = GridRangeInfo.Table()
				frEvents = New GridFindReplaceEventArgs(cmbBoxSearch.Text, "", options, locInfo)
				frDialog.Find(frEvents)
			End If
		End Sub

		'FindAll - Sets the cell back color via QueryCellInfo event in the grid and so highlights all the values 
		'that match with the given search string.
		Private Sub btnFindAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFindAll.Click
			If cmbBoxSearch.Text IsNot Nothing Then
				AddToSearchedList(cmbBoxSearch.Text)
				findAll = True
				resetAll = False
				Me.gridDataBoundGrid1.Refresh()
			End If
		End Sub

		Private Sub btnReplace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReplace.Click
			If cmbBoxSearch.Text <> String.Empty AndAlso cmbBoxReplace.Text <> String.Empty Then
				SetOptions()
				frEvents = New GridFindReplaceEventArgs(cmbBoxSearch.Text, cmbBoxReplace.Text, options, locInfo)
				frDialog.Replace(frEvents)
			End If
		End Sub

		Private Sub btnReplaceAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReplaceAll.Click
			If cmbBoxSearch.Text <> String.Empty AndAlso cmbBoxReplace.Text <> String.Empty Then
				If cmbBoxSearch.Text <> String.Empty AndAlso Me.cmbBoxReplace.Text <> String.Empty Then
					SetOptions()
					frEvents = New GridFindReplaceEventArgs(cmbBoxSearch.Text, Me.cmbBoxReplace.Text, options, locInfo)
					frDialog.ReplaceAll(frEvents)
				End If
				findAll = False
				resetAll = True
				Me.gridDataBoundGrid1.Refresh()
			Else
				MessageBox.Show("Search/Replace value is missing")
			End If
		End Sub

		#Region "Helper methods"

		'Setup the search options.
		Private Sub SetOptions()
			options = GridFindTextOptions.None
			If chkBoxMatchCase.Checked Then
				options = GridFindTextOptions.MatchCase
			End If
			If chkBoxMatchWholeCell.Checked Then
				options = options Or GridFindTextOptions.MatchWholeCell
			End If
			If chkBoxSearchUp.Checked Then
				options = options Or GridFindTextOptions.SearchUp
			End If
			Select Case cmbBoxOptions.SelectedIndex
				Case 0
					options = options Or GridFindTextOptions.ColumnOnly
				Case 1
					options = options Or GridFindTextOptions.SelectionOnly
				Case 2
					options = options Or GridFindTextOptions.WholeTable
			End Select
		End Sub

		'Keep track of the search strings being entered.
		Private Sub AddToSearchedList(ByVal txt As String)
			If Not cmbBoxSearch.Items.Contains(txt) Then
				cmbBoxSearch.Items.Insert(0, txt)
			End If
		End Sub
		#End Region

		Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
			'Set the backcolor of the cells being highlighted to their original color using QueryCellInfo event.
			resetAll = True
			findAll = False
			Me.gridDataBoundGrid1.Selections.Clear()
			Me.gridDataBoundGrid1.Refresh()
		End Sub
		#End Region ' Find and Replace
	End Class
End Namespace