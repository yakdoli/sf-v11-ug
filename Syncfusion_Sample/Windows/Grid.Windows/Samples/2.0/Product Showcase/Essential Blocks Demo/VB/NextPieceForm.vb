Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace EssentialBlocks
	Public Partial Class NextPieceForm
		Inherits Form
		Private game As BlocksGame
		Private form As BlocksForm

		Public Sub New(ByVal bGame As BlocksGame, ByVal bForm As BlocksForm)
			InitializeComponent()
			game = bGame
			gridNextPiece.AllowDragSelectedCols = False
			gridNextPiece.AllowDragSelectedRows = False
			gridNextPiece.AllowSelection = GridSelectionFlags.None
			gridNextPiece.ResizeColsBehavior = GridResizeCellsBehavior.None
			gridNextPiece.ResizeRowsBehavior = GridResizeCellsBehavior.None
			form = bForm

			Me.Left = bForm.Right
			Me.Top = bForm.Top
		End Sub

		Public WriteOnly Property BGame() As BlocksGame
			Set(ByVal value As BlocksGame)
				game = value
				ForceUpdate()
			End Set
		End Property

		' Used so that the display of the next piece will always be accurate
		Public Sub ForceUpdate()
			gridNextPiece.Invalidate()
			gridNextPiece.Update()
		End Sub

		' This isn't fundamentally different from the QueryCellInfo in BlocksForm, except that
		' game.GetNextPiece() is used instead.
		Private Sub gridNextPiece_QueryCellInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs) Handles gridNextPiece.QueryCellInfo
			e.Style.Enabled = False
			If e.ColIndex > 0 AndAlso e.RowIndex > 0 Then
				If game.IsGameOver OrElse (Not game.IsGameRunning) OrElse (Not game.IsGameStarted) Then
					e.Style.BackColor = Color.White
				Else
					e.Style.Interior = BlocksForm.GetGradient(game.GetNextPiece()(e.ColIndex - 1, e.RowIndex - 1))
				End If
			End If
		End Sub

		' Forwards arrow keys to BlocksForm so they can be handled
		Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
			If (keyData = Keys.Up) OrElse (keyData = Keys.Down) OrElse (keyData = Keys.Left) OrElse (keyData = Keys.Right) Then
				form.AcceptInput(keyData)
			End If

			Return MyBase.ProcessCmdKey(msg, keyData)
		End Function

    End Class
End Namespace