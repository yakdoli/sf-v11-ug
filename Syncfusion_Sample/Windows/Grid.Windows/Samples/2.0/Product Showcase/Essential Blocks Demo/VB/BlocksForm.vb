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
Imports System.Drawing.Drawing2D

Namespace EssentialBlocks
	Public Partial Class BlocksForm
		Inherits Office2007Form
		#Region "Constructor"
		Private game As BlocksGame
		Private nextPieceForm As NextPieceForm

		Public Sub New()
			InitializeComponent()
			game = New BlocksGame()
			SetPauseBarItemStatus()

			' Disable Grid interaction
			gridBoard.AllowDragSelectedCols = False
			gridBoard.AllowDragSelectedRows = False
			gridBoard.AllowSelection = GridSelectionFlags.None
			gridBoard.ResizeColsBehavior = GridResizeCellsBehavior.None
			gridBoard.ResizeRowsBehavior = GridResizeCellsBehavior.None

			' Create Next Piece display
			nextPieceForm = New NextPieceForm(game, Me)
			nextPieceForm.TopLevel = False
			Me.nextPiecePanel.Controls.Add(nextPieceForm.gridNextPiece)
			nextPieceForm.gridNextPiece.Dock = DockStyle.Fill
			Me.Focus()
		End Sub
		#End Region

		#Region "Menu Click Events"
		Private Sub exitBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitBarItem.Click
			' Pause the game for the Exit Dialog
			gameTimer.Stop()

			If AbandonGame() Then
				game.QuitGame()
				Application.Exit()
			End If

			' Restart the game, if necessary
			If game.IsGameRunning Then
				gameTimer.Start()
			End If
		End Sub

		Private Sub newGameBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newGameBarItem.Click
			' Pause the game for the Exit Dialog
			gameTimer.Stop()

			If AbandonGame() Then
				If game.IsGameStarted Then
					game.QuitGame()
					game = New BlocksGame()
				End If

				nextPieceForm.BGame = game
				game.StartGame()
				gridBoard.Invalidate()
				gridBoard.Update()
				SetPauseBarItemStatus()
			End If

			' Restart (or start) the game, if necessary
			If game.IsGameRunning Then
				gameTimer.Start()
			End If
		End Sub

		Private Sub pauseBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pauseBarItem.Click
			gameTimer.Stop()

			If game.IsGameRunning Then
				game.PauseGame()
			Else
				game.ResumeGame()
				gameTimer.Start()
			End If

			gridBoard.Invalidate()
			gridBoard.Update()
			nextPieceForm.ForceUpdate()

			SetPauseBarItemStatus()
		End Sub

		Private Sub aboutBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles aboutBarItem.Click
			gameTimer.Stop()
			Dim aboutForm As Form = New AboutForm()
			aboutForm.ShowDialog(Me)
			If game.IsGameRunning Then
				gameTimer.Start()
			End If
		End Sub

		Private Sub howToPlayBarItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles howToPlayBarItem.Click
			gameTimer.Stop()
			Dim howToPlayForm As Form = New HowToPlayForm()
			howToPlayForm.ShowDialog(Me)
			If game.IsGameRunning Then
				gameTimer.Start()
			End If
		End Sub

		' Detects game settings and sets the display of the Pause item appropriately
		Private Sub SetPauseBarItemStatus()
			If (Not game.IsGameStarted) OrElse game.IsGameOver Then
				pauseBarItem.Enabled = False
				pauseBarItem.Text = "&Pause Game"
			ElseIf game.IsGameRunning Then
				pauseBarItem.Enabled = True
				pauseBarItem.Text = "&Pause Game"
				gridBoard.CoveredRanges.Clear()
			Else
				pauseBarItem.Enabled = True
				pauseBarItem.Text = "&Resume Game"
				gridBoard.CoveredRanges.Add(GridRangeInfo.Cells(6, 3, 7, 6))
			End If
		End Sub
		#End Region

		#Region "Dialogs"

		' Returns true if the game is over or hasn't started.
		' Otherwise, asks the user if he wants to abandon his game
		Private Function AbandonGame() As Boolean
			Dim canExit As Boolean

			If game.IsGameStarted AndAlso (Not game.IsGameOver) Then
				Dim result As DialogResult = MessageBox.Show("Do you want to abandon your game?", "Exit Essential Blocks", MessageBoxButtons.YesNo)

                If result = System.Windows.Forms.DialogResult.Yes Then
                    canExit = True
                Else
                    canExit = False
                End If
			Else
				canExit = True
			End If

			Return canExit
		End Function
		#End Region

		#Region "QueryCellInfo"
		' Used to draw Pause and Game Over text
		Private Shared ArialFontInfo As GridFontInfo = New GridFontInfo(New Font("Arial", 22, FontStyle.Bold))

		' Called by the Grid during an Update for each visible cell
		Private Sub gridBoard_QueryCellInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs) Handles gridBoard.QueryCellInfo
			' Disallow editing
			e.Style.Enabled = False

			If e.ColIndex > 0 AndAlso e.RowIndex > 0 Then
				If game.IsGameRunning Then
					e.Style.Interior = GetGradient(game.GetBoardSquare(e.ColIndex, e.RowIndex))
				Else
					' Being able to see the board while paused is a significant advantage
					e.Style.BackColor = Color.White
				End If
			End If

			' Add text to the CoveredCells for Game Over and Paused messages
			If e.RowIndex = 6 Then
				If game.IsGameOver AndAlso e.ColIndex = 2 Then
					e.Style.Text = "Game Over"
					e.Style.Font = ArialFontInfo
				ElseIf (Not game.IsGameRunning) AndAlso game.IsGameStarted AndAlso (Not game.IsGameOver) AndAlso e.ColIndex = 3 Then
					e.Style.Text = "Paused"
					e.Style.Font = ArialFontInfo
				End If
			End If
		End Sub
		#End Region

		#Region "Color Mappings  "
		' Each entry in this array corresponds to a different piece
		Private Shared colors As Color() = New Color() { Color.White, Color.FromArgb(226, 144, 88), Color.FromArgb(79, 116, 186), Color.FromArgb(247, 115, 30), Color.FromArgb(117, 166, 47), Color.FromArgb(128, 0, 0), Color.FromArgb(196, 76, 74), Color.FromArgb(146, 145, 174) }
		'Color.FromArgb(255, 163, 51), Color.FromArgb(192, 201, 219), Color.FromArgb(42, 67, 126), Color.FromArgb(252, 172, 38), Color.FromArgb(244, 128, 3), Color.FromArgb(126, 140, 152), Color.FromArgb(51, 51, 101) };

		' Returns the appropriate gradient for a cell value
		Public Shared Function GetGradient(ByVal index As Integer) As BrushInfo
			If index > 0 Then
				Return New BrushInfo(GradientStyle.PathRectangle, Color.White, colors(index))
			Else
				' There shouldn't be a gradient on a blank cell
				Return New BrushInfo(Color.White)
			End If
		End Function
		#End Region

		#Region "Tick Events"
		' Used internally to track the game speed
		Private level As Integer = 1

		' Handles the periodic updates of the game
		Private Sub gameTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles gameTimer.Tick
			game.Tick()
			gridBoard.Invalidate()
			gridBoard.Update()
			nextPieceForm.ForceUpdate()

			If game.IsGameOver Then
				gameTimer.Stop()
				gridBoard.CoveredRanges.Add(GridRangeInfo.Cells(6, 2, 7, 7))
				SetPauseBarItemStatus()
			Else
				' Tracks the games speed
				label1.Text = "Score: " & game.GetScore().ToString()

				' Level    Score
				' --------------
				'     1        0
				'     2      100
				'     3      400
				'     4      900
				'     5     1600
				'     6     2500
				'     7     3600
				'     8     4900
				'     9     6400
				'    10     8100
				'    11    10000
				'    12    12100
				'    13    14400
				level = Convert.ToInt32(Math.Sqrt(game.GetScore() / 100)) + 1

				' Max level is 13
				If level > 13 Then
					level = 13
				End If

				progressBarAdv1.Value = level

				' Game speed ranges from 2 updates a second to about 6 updates a second
                gameTimer.Interval = Convert.ToInt32(3000 / (5 + level))
			End If
		End Sub
		#End Region

		#Region "Keyboard Input"

		' Used to grab the arrow key input
		Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
			AcceptInput(keyData)

			Return MyBase.ProcessCmdKey(msg, keyData)
		End Function

		' Public so that the NextPieceForm can forward key presses.
		' Otherwise, there would be confusion if the NextPieceForm has focus.
		Public Sub AcceptInput(ByVal keyData As Keys)
			' Without this call the tick event will never be processed if a key is held down
			Application.DoEvents()

			If game.IsGameRunning Then
				Dim refresh As Boolean = False

				Select Case keyData
					Case Keys.Down
						game.MoveDown()
						refresh = True
					Case Keys.Left
						game.MoveLeft()
						refresh = True
					Case Keys.Right
						game.MoveRight()
						refresh = True
					Case Keys.Up
						game.Rotate()
						refresh = True
				End Select

				If refresh Then
					gridBoard.Invalidate()
					gridBoard.Update()
					nextPieceForm.ForceUpdate()
				End If
			End If
		End Sub
		#End Region

		Private Sub showNextPieceItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles showNextPieceItem.Click
			showNextPieceItem.Checked = Not showNextPieceItem.Checked
			If showNextPieceItem.Checked Then
				Me.Width = 429
			Else
				Me.Width = 289
			End If
		End Sub

	End Class
End Namespace