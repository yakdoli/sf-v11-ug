Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing

Namespace EssentialBlocks
	Public Class BlocksGame
		#Region "Constructor"
		Private rand As Random = New Random()

		Public Sub New()
			isGameRunning_Renamed = False
			isGameStarted_Renamed = False
			isGameOver_Renamed = False

			board = New Integer(7, 19){}
			For x As Integer = 0 To 7
				For y As Integer = 0 To 19
					board(x, y) = 0
				Next y
			Next x

			piece = New Integer(4, 4){}
			For x As Integer = 0 To 4
				For y As Integer = 0 To 4
					piece(x, y) = 0
				Next y
			Next x

			nextpiece = NewPiece()

			pieceloc = New Point(0, 0)

			score = 0
		End Sub
		#End Region

		#Region "Game State"
		Private isGameRunning_Renamed As Boolean
		Public ReadOnly Property IsGameRunning() As Boolean
			Get
				Return isGameRunning_Renamed
			End Get
		End Property

		Private isGameStarted_Renamed As Boolean
		Public ReadOnly Property IsGameStarted() As Boolean
			Get
				Return isGameStarted_Renamed
			End Get
		End Property

		Private isGameOver_Renamed As Boolean
		Public ReadOnly Property IsGameOver() As Boolean
			Get
				Return isGameOver_Renamed
			End Get
		End Property
		#End Region

		#Region "Game Control"
		Public Sub StartGame()
			If (Not isGameStarted_Renamed) Then
				isGameStarted_Renamed = True
				isGameOver_Renamed = False
				isGameRunning_Renamed = True
				needNewPiece = True
			End If
		End Sub

		Public Sub PauseGame()
			If isGameStarted_Renamed AndAlso (Not isGameOver_Renamed) AndAlso isGameRunning_Renamed Then
				isGameRunning_Renamed = False
			End If
		End Sub

		Public Sub ResumeGame()
			If isGameStarted_Renamed AndAlso (Not isGameOver_Renamed) AndAlso (Not isGameRunning_Renamed) Then
				isGameRunning_Renamed = True
			End If
		End Sub

		Public Sub QuitGame()
			If isGameStarted_Renamed AndAlso (Not isGameOver_Renamed) Then
				isGameRunning_Renamed = False
				isGameOver_Renamed = True
			End If
		End Sub
		#End Region

		#Region "Piece Design"
		Private Function NewPiece() As Integer(,)
			Dim piece As Integer(,) = New Integer(4, 4){}

			Select Case rand.Next(0, 7)
				Case 0
					piece(0, 2) = 1
					piece(1, 2) = 1
					piece(2, 2) = 1
					piece(3, 2) = 1
				Case 1
					piece(1, 1) = 2
					piece(2, 1) = 2
					piece(2, 2) = 2
					piece(2, 3) = 2
				Case 2
					piece(3, 1) = 3
					piece(2, 1) = 3
					piece(2, 2) = 3
					piece(2, 3) = 3
				Case 3
					piece(2, 1) = 4
					piece(1, 2) = 4
					piece(2, 2) = 4
					piece(3, 2) = 4
				Case 4
					piece(1, 1) = 5
					piece(2, 1) = 5
					piece(1, 2) = 5
					piece(2, 2) = 5
				Case 5
					piece(2, 1) = 6
					piece(2, 2) = 6
					piece(3, 2) = 6
					piece(3, 3) = 6
				Case 6
					piece(2, 1) = 7
					piece(2, 2) = 7
					piece(1, 2) = 7
					piece(1, 3) = 7
			End Select

			Return piece

		End Function
		#End Region

		#Region "Game Action"
		Private needNewPiece As Boolean

		' Factored out logic for creating a new piece.
		Private Function QueryNewPiece() As Boolean
			If needNewPiece Then
				piece = nextpiece
				pieceloc = New Point(3, -3)
				nextpiece = NewPiece()
				needNewPiece = False
				Return True
			Else
				Return False
			End If
		End Function

		Public Sub Tick()
			If isGameRunning_Renamed AndAlso (Not isGameOver_Renamed) Then
				If (Not QueryNewPiece()) Then
					MoveDown()
				End If
			End If
		End Sub

		Public Sub MoveDown()
			If (Not QueryNewPiece()) Then
				Dim newloc As Point = pieceloc
				newloc.Y += 1

				If (Not WillCollide(piece, newloc)) Then
					pieceloc.Y += 1
				Else
					' The piece hit something going down, so it needs to be added to the display.
					For x As Integer = 0 To 4
						For y As Integer = 0 To 4
							If piece(x, y) > 0 Then
								If (Not isGameOver_Renamed) Then
									If y + pieceloc.Y < 1 Then
										' This piece caused an overflow on the top of the board, so the game is over
										isGameOver_Renamed = True
									Else
										' Add the block to the board
										board(x + pieceloc.X - 1, y + pieceloc.Y - 1) = piece(x, y)
									End If
								End If
							End If
						Next y
					Next x
					If (Not isGameOver_Renamed) Then
						ClearPieces()
						needNewPiece = True
						For x As Integer = 0 To 4
							For y As Integer = 0 To 4
								piece(x, y) = 0
							Next y
						Next x
					Else
						isGameRunning_Renamed = False
					End If
				End If
			End If
		End Sub

		Public Sub MoveLeft()
			Dim newloc As Point = pieceloc
			newloc.X -= 1

			If (Not WillCollide(piece, newloc)) Then
				pieceloc.X -= 1
			End If
		End Sub

		Public Sub MoveRight()
			Dim newloc As Point = pieceloc
			newloc.X += 1

			If (Not WillCollide(piece, newloc)) Then
				pieceloc.X += 1
			End If
		End Sub

		Public Sub Rotate()
			Dim newpiece As Integer(,) = New Integer(4, 4){}

			For x As Integer = 0 To 4
				For y As Integer = 0 To 4
					newpiece(x, y) = piece(4 - y, x)
				Next y
			Next x

			If (Not WillCollide(newpiece, pieceloc)) Then
				piece = newpiece
			End If
		End Sub

		' Detects completed rows and removes them
		Private Sub ClearPieces()
			Dim clears As Integer = 0

			For y As Integer = 0 To 19
				Dim clear As Boolean = True

				For x As Integer = 0 To 7
					clear = clear AndAlso (board(x, y) > 0)
				Next x

				If clear Then
					clears += 1
					For j As Integer = y To 0 Step -1
						For i As Integer = 0 To 7
							If j = 0 Then
								board(i, j) = 0
							Else
								board(i, j) = board(i, j - 1)
							End If
						Next i
					Next j
				End If
			Next y

			' If we removed something, score the points
			' Clears Score
			' ------------
			'      1   100
			'      2   200
			'      3   400
			'      4   800
			If clears > 0 Then
				score = score + (Convert.ToInt32(Math.Pow(2, clears - 1)) * 100)
			End If
		End Sub

		' Performs collision detection on each individual block in the piece.
		' Accepts both location and the piece so that rotation can be tested.
		Private Function WillCollide(ByVal piece As Integer(,), ByVal newloc As Point) As Boolean

            Dim b_willCollide As Boolean = False

            For x As Integer = 0 To 4
                For y As Integer = 0 To 4
                    If piece(x, y) > 0 Then
                        If x + newloc.X <= 0 Then
                            b_willCollide = True
                        ElseIf x + newloc.X >= 9 Then
                            b_willCollide = True
                        ElseIf y + newloc.Y >= 21 Then
                            b_willCollide = True
                        ElseIf newloc.Y + y > 0 AndAlso board(x + newloc.X - 1, y + newloc.Y - 1) > 0 Then
                            b_willCollide = True
                        End If
                    End If
                Next y
            Next x

            Return b_willCollide
		End Function
		#End Region

		#Region "Game Data"
		Private piece As Integer(,)
		Private nextpiece As Integer(,)
		Private pieceloc As Point

		Public Function GetNextPiece() As Integer(,)
			Return nextpiece
		End Function

		Private board As Integer(,)
		Public Function GetBoardSquare(ByVal x As Integer, ByVal y As Integer) As Integer
			If (x >= pieceloc.X AndAlso x <= pieceloc.X + 4) AndAlso (y >= pieceloc.Y AndAlso y <= pieceloc.Y + 4) AndAlso (piece(x - pieceloc.X, y - pieceloc.Y) <> 0) Then
				Return piece(x - pieceloc.X, y - pieceloc.Y)
			Else
				Return board(x - 1, y - 1)
			End If
		End Function

		Private score As Integer
		Public Function GetScore() As Integer
			Return score
		End Function
		#End Region
	End Class
End Namespace
