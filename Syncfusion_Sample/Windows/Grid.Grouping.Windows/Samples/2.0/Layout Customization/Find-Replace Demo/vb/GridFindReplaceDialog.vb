#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms

Namespace FindReplace
	Partial Public Class GridFindReplaceDialog
		Inherits MetroForm
		Private frDialog As GridFindReplaceDialogSink
		Private frEvents As GridFindReplaceEventArgs
		Private locInfo As Object
		Private options As GridFindTextOptions
		Private grid As GridGroupingControl
		Public Sub New(ByVal groupinggrid As GridGroupingControl, ByVal themeStyle As String)
			InitializeComponent()
			grid = groupinggrid
			frDialog = New GridFindReplaceDialogSink(grid.TableControl)
			options = GridFindTextOptions.None
			cmbOptions.SelectedIndex = 1
			AddHandler grid.QueryCellStyleInfo, AddressOf grid_QueryCellStyleInfo
		End Sub

		Private Sub grid_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
			If findAll Then
				Dim dr As DataRowView = TryCast(e.TableCellIdentity.DisplayElement.GetData(), DataRowView)
				Dim rowIndex, colIndex As Integer
				grid.TableControl.CurrentCell.GetCurrentCell(rowIndex, colIndex)
				Dim range As GridRangeInfo = grid.TableControl.Selections.Ranges.ActiveRange
				If cmbOptions.Text.Equals("WholeTable") AndAlso dr IsNot Nothing Then
					If e.Style.Text.Equals(txtSearch.Text) AndAlso e.TableCellIdentity.DisplayElement.Kind = DisplayElementKind.Record Then
						e.Style.BackColor = Color.Orange
					End If
				ElseIf cmbOptions.Text.Equals("ColumnOnly") AndAlso dr IsNot Nothing Then
					If e.TableCellIdentity.ColIndex = colIndex Then
						If e.Style.Text.Equals(txtSearch.Text) Then
							e.Style.BackColor = Color.Orange
						End If
					End If
				End If

			ElseIf resetAll Then
				e.Style.BackColor = SystemColors.Window
			End If
		End Sub

		Private Sub findnextBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles findnextBtn.Click
			If txtSearch.Text <> "" Then
				SetOptions()
				locInfo = GridRangeInfo.Table()
				frEvents = New GridFindReplaceEventArgs(txtSearch.Text, "", options, locInfo)
				frDialog.Find(frEvents)
			End If
		End Sub
		Private Sub SetOptions()
			options = GridFindTextOptions.None
			If matchChkbox.Checked Then
				options = GridFindTextOptions.MatchCase
			End If
			If matchAllChkbox.Checked Then
				options = options Or GridFindTextOptions.MatchWholeCell
			End If
			If searchupChkbox.Checked Then
				options = options Or GridFindTextOptions.SearchUp
			End If

			Select Case cmbOptions.SelectedIndex
				Case 0
					options = options Or GridFindTextOptions.ColumnOnly
				Case 1
					options = options Or GridFindTextOptions.WholeTable
			End Select
		End Sub
		Private findAll As Boolean = False
		Private resetAll As Boolean = False
		Private Sub findallBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles findallBtn.Click
			findAll = True
			resetAll = False
			grid.Refresh()
		End Sub

		Private Sub cancelbtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cancelbtn.Click
			resetAll = True
			findAll = False
			grid.TableControl.Selections.Clear()
			grid.Refresh()
			RemoveHandler grid.QueryCellStyleInfo, AddressOf grid_QueryCellStyleInfo
			Me.Close()
		End Sub

        Private Sub ReplaceBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReplaceBtn.Click

            If (Not String.IsNullOrEmpty(txtSearch.Text)) AndAlso (Not String.IsNullOrEmpty(txtReplace.Text)) Then
                SetOptions()
                frEvents = New GridFindReplaceEventArgs(txtSearch.Text, txtReplace.Text, options, locInfo)
                frDialog.Replace(frEvents)
            End If
        End Sub

		Private Sub ReplaceAllBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ReplaceAllBtn.Click
			If txtSearch.Text <> "" AndAlso txtReplace.Text <> "" Then
				SetOptions()
				frEvents = New GridFindReplaceEventArgs(txtSearch.Text, txtReplace.Text, options, locInfo)
				frDialog.ReplaceAll(frEvents)
			End If
			resetAll = True
			findAll = False
			grid.Refresh()
		End Sub

		Protected Overrides Sub WndProc(ByRef m As Message)
			Select Case m.Msg
				Case &H84
					m.Result = New IntPtr(&H2)
					Return
			End Select
			MyBase.WndProc(m)
		End Sub
		Private Sub GridFindReplaceDialog_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		End Sub
	End Class
End Namespace
