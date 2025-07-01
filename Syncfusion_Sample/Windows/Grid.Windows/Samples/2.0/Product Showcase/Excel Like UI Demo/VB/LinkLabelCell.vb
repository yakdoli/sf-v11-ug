#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.Serialization

Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms


Namespace ExcelLikeUI_2005
	Public Class LinkLabelCellModel
		Inherits GridStaticCellModel
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)
			AllowFloating = False
		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New LinkLabelCellRenderer(control, Me)
		End Function

	End Class


	Public Class LinkLabelCellRenderer
		Inherits GridStaticCellRenderer
		Private _isMouseDown As Boolean
		Private _drawHotLink As Boolean
		Private _hotColor As Color
		Private _visitedColor As Color
		Private _EXEname As String

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			_isMouseDown = False
			_drawHotLink = False

			_hotColor = Color.Red
			_visitedColor = Color.Purple

			_EXEname = "iexplore.exe"
		End Sub

		Public Property VisitedLinkColor() As Color
			Get
				Return _visitedColor
			End Get
			Set(ByVal value As Color)
				_visitedColor = value
			End Set
		End Property

		Public Property ActiveLinkColor() As Color
			Get
				Return _hotColor
			End Get
			Set(ByVal value As Color)
				_hotColor = value
			End Set
		End Property

		Public Property EXEname() As String
			Get
				Return _EXEname
			End Get
			Set(ByVal value As String)
				_EXEname = value
			End Set
		End Property

		Protected Overridable Sub LaunchBrowser(ByVal style As GridStyleInfo)
			Try
				Dim process As System.Diagnostics.Process = New System.Diagnostics.Process()
				process.StartInfo.FileName = EXEname
				process.StartInfo.Arguments = CStr(style.Tag)
				process.Start()
			Catch ex As Exception
				MessageBox.Show("Error: " & ex.ToString())
			End Try

		End Sub

		Private Sub DrawLink(ByVal useHotColor As Boolean, ByVal rowIndex As Integer, ByVal colIndex As Integer)
			If useHotColor Then
				_drawHotLink = True
			End If

			Me.Grid.RefreshRange(GridRangeInfo.Cell(rowIndex, colIndex), GridRangeOptions.None)

			_drawHotLink = False
		End Sub

		Protected Overrides Sub OnMouseDown(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As System.Windows.Forms.MouseEventArgs)
			MyBase.OnMouseDown(rowIndex, colIndex, e)
			DrawLink(True, rowIndex, colIndex)
			_isMouseDown = True
		End Sub

		Protected Overrides Sub OnMouseUp(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As System.Windows.Forms.MouseEventArgs)
			MyBase.OnMouseUp(rowIndex, colIndex, e)
			Dim row, col As Integer
			Me.Grid.PointToRowCol(New Point(e.X, e.Y), row, col)
			If row = rowIndex AndAlso col = colIndex Then
				Dim style As GridStyleInfo = Me.Grid.Model(row, col)
				LaunchBrowser(style)
				style.TextColor = VisitedLinkColor
			End If
			DrawLink(False, rowIndex, colIndex)
			_isMouseDown = False
		End Sub

		Protected Overrides Sub OnCancelMode(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			MyBase.OnCancelMode(rowIndex, colIndex)
			_isMouseDown = False
			_drawHotLink = False
		End Sub

		Protected Overrides Function OnGetCursor(ByVal rowIndex As Integer, ByVal colIndex As Integer) As System.Windows.Forms.Cursor
			'if over cell, return HandPointerCursor otherwise NoCursor...
			Dim pt As Point = Me.Grid.PointToClient(Cursor.Position)
			Dim row, col As Integer
			Me.Grid.PointToRowCol(pt, row, col)

			If (row = rowIndex AndAlso col = colIndex) Then
				Return Cursors.Hand
			Else
				If (Me._isMouseDown) Then
					Return Cursors.No
				Else
					Return MyBase.OnGetCursor(rowIndex, colIndex)
				End If
			End If
		End Function

		Protected Overrides Function OnHitTest(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As MouseEventArgs, ByVal controller As IMouseController) As Integer
			'return a nonzero so the mouse messages will be forwarded to the cell render
			'but don't include the cell borders so D&D can be handled
			If Not controller Is Nothing AndAlso controller.Name = "OleDataSource" Then
				' other controllers have higher priority than me
				Return 0
			End If

			Return 1

		End Function

		Protected Overrides Sub OnDraw(ByVal g As System.Drawing.Graphics, ByVal clientRectangle As System.Drawing.Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As Syncfusion.Windows.Forms.Grid.GridStyleInfo)
			style.Font.Underline = True

			If _drawHotLink Then
				style.TextColor = ActiveLinkColor
			End If
			MyBase.OnDraw(g, clientRectangle, rowIndex, colIndex, style)

		End Sub

		Protected Overrides Sub OnMouseHoverEnter(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			MyBase.OnMouseHoverEnter(rowIndex, colIndex)
			DrawLink(True, rowIndex, colIndex)
		End Sub

		Protected Overrides Sub OnMouseHoverLeave(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As System.EventArgs)
			MyBase.OnMouseHoverLeave(rowIndex, colIndex, e)
			DrawLink(False, rowIndex, colIndex)
		End Sub

	End Class

End Namespace
