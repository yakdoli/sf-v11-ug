Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.Serialization

Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid

Namespace InteractiveCellDemo
	Public Class CellDragButton
		Inherits GridCellButton
		Private interiorBrush As BrushInfo
		Private _mouseOverRange As GridRangeInfo = GridRangeInfo.Empty
		Private savedInterior As BrushInfo = BrushInfo.Empty
		Private _mouseDown As Boolean = False

		Public Sub New(ByVal control As GridCellRendererBase)
			MyBase.New(control)
			interiorBrush = New BrushInfo(GradientStyle.PathRectangle, Color.FromArgb(&H3a, &H86, &H7e),Color.FromArgb(204, 212, 230))
		End Sub

		Public Property Interior() As BrushInfo
			Get
				Return Me.interiorBrush
			End Get
			Set(ByVal value As BrushInfo)
				interiorBrush = value
			End Set
		End Property

		Private Property MouseOverRange() As GridRangeInfo
			Get
				Return _mouseOverRange
			End Get
			Set(ByVal value As GridRangeInfo)
				If Not _mouseOverRange.Equals(value) Then
					' TODO: Provide option to enable/disable undo generation
					Grid.Model.BeginInit()
					If Not _mouseOverRange.IsEmpty Then
						If savedInterior.IsEmpty Then
							Grid.Model(_mouseOverRange.Top, _mouseOverRange.Left).ResetInterior()
						Else
							Grid.Model(_mouseOverRange.Top, _mouseOverRange.Left).Interior = savedInterior
						End If
					End If
					savedInterior = BrushInfo.Empty
					_mouseOverRange = value
					If Not _mouseOverRange.IsEmpty Then
						If Grid.Model(_mouseOverRange.Top, _mouseOverRange.Left).HasInterior Then
							savedInterior = Grid.Model(_mouseOverRange.Top, _mouseOverRange.Left).Interior
						End If
						Grid.Model(_mouseOverRange.Top, _mouseOverRange.Left).Interior = interiorBrush
					End If
					Grid.Model.EndInit()
				End If
			End Set
		End Property

		Public Overrides Sub MouseDown(ByVal e As MouseEventArgs, ByVal ht As GridCellHitTestInfo)
			MyBase.MouseDown(e, ht)
			Grid.AutoScrolling = ScrollBars.Both
			Dim bounds As Rectangle = Grid.RangeInfoToRectangle(Grid.ScrollableGridRangeInfo)
			bounds.Intersect(Grid.GridBounds)
			Grid.AutoScrollBounds = bounds
			_mouseDown = True
		End Sub

		Public Overrides Sub MouseMove(ByVal e As MouseEventArgs, ByVal ht As GridCellHitTestInfo)
			If ht.CellButtonBounds.Contains(New Point(e.X, e.Y)) Then
				' Set_mouseDown(ht, true);
			Else
				' Set_mouseDown(ht, false);
				Dim range As GridRangeInfo = Grid.PointToRangeInfo(New Point(e.X, e.Y), -1)
				MouseOverRange = range
			End If
		End Sub

		Public Overrides Sub MouseUp(ByVal e As MouseEventArgs, ByVal ht As GridCellHitTestInfo)
			If Not MouseOverRange.IsEmpty Then
				MessageBox.Show("You dragged onto cell " & MouseOverRange.ToString())
			Else
				MessageBox.Show("Press this button and then drag over another cell " & MouseOverRange.ToString())
			End If

			MyBase.MouseUp(e, ht)
			MouseOverRange = GridRangeInfo.Empty
			Grid.AutoScrolling = ScrollBars.None
			Grid.ScrollCellInView(ht.RowIndex, ht.ColIndex)
			_mouseDown = False
		End Sub

		Public Overrides Sub CancelMode(ByVal ht As GridCellHitTestInfo)
			MyBase.CancelMode(ht)
			MouseOverRange = GridRangeInfo.Empty
			Grid.AutoScrolling = ScrollBars.None
			_mouseDown = False
		End Sub

        Public Overrides Function GetCursor(ByVal ht As GridCellHitTestInfo) As Cursor
            If (_mouseDown AndAlso MouseOverRange.Equals(GridRangeInfo.Cell(ht.RowIndex, ht.ColIndex))) Then
                Return Cursors.No
            Else
                Return Cursors.Hand
            End If

        End Function

	End Class

	<Serializable> _
	Public Class DragButtonCellModel
		Inherits GridStaticCellModel
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)
			AllowFloating = False
			ButtonBarSize = New Size(12*3, 12)
		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New DragButtonCellRenderer(control, Me)
		End Function

	End Class

	Public Class DragButtonCellRenderer
		Inherits GridStaticCellRenderer
		Private mybuttons() As CellDragButton

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			mybuttons = New CellDragButton(2){}
			For n As Integer = 0 To 2
				mybuttons(n) = New CellDragButton(Me)
				AddButton(mybuttons(n))
			Next n
			mybuttons(1).Interior = New BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(&Hde, &H64, &H13), Color.White)
			mybuttons(2).Interior = New BrushInfo(PatternStyle.SmallCheckerBoard, Color.FromArgb(255, 187, 111), Color.White) '.FromArgb( 0xff, 0xbf, 0x34 ));
		End Sub
	End Class

End Namespace
