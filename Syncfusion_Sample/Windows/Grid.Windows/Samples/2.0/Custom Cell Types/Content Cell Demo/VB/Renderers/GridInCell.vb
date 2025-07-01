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
Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace ContentCellDemo


	''' <summary>
	''' Summary description for GridInCell.
	''' </summary>
	Public Class GridInCellModel
		Inherits GridGenericControlCellModel
		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)
			AllowFloating = False
		End Sub

		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New GridInCellRenderer(control, Me)
		End Function

	End Class


	Public Class GridInCellRenderer
		Inherits GridGenericControlCellRenderer
		Private activeGrid As CellEmbeddedGrid

		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			Me.SupportsFocusControl = True
		End Sub

		Protected Overrides Sub OnDraw(ByVal g As System.Drawing.Graphics, ByVal clientRectangle As System.Drawing.Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As Syncfusion.Windows.Forms.Grid.GridStyleInfo)
			If Me.ShouldDrawFocused(rowIndex, colIndex) Then
				If TypeOf style.Control Is CellEmbeddedGrid Then
					activeGrid = CType(style.Control, CellEmbeddedGrid)
				End If

				MyBase.OnDraw(g, clientRectangle, rowIndex, colIndex, style)
			Else
				' Draw a static grid
				If TypeOf style.Control Is CellEmbeddedGrid Then
					Dim grid As CellEmbeddedGrid = CType(style.Control, CellEmbeddedGrid)
					grid.DrawGrid(g, clientRectangle, True)
				End If
			End If
		End Sub

		Protected Overrides Function ProcessKeyEventArgs(ByRef m As Message) As Boolean
			TraceUtil.TraceCurrentMethodInfo(m.ToString())

			' forward keyboard events to child grid that would otherwise 
			' be handled by parent grid (right arrow, page down etc.)
			If activeGrid IsNot Nothing AndAlso activeGrid.Focused Then
				Return activeGrid.InitiateProcessKeyEventArgs(m)
			End If

			Return MyBase.ProcessKeyEventArgs(m)
		End Function
	End Class

	Public Class CellEmbeddedGrid
		Inherits GridControl
		Public Sub New(ByVal parent As GridControl)
			Me.RowHeights(0) = Me.RowHeights(1)
			Me.DefaultColWidth = 50

			Me.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation
			Me.VScrollBehavior = GridScrollbarMode.Automatic
			Me.HScrollBehavior = GridScrollbarMode.Automatic
			Me.BorderStyle = BorderStyle.None
			Me.Location = New Point(-10000, -10000)
			Me.ActivateCurrentCellBehavior = GridCellActivateAction.PositionCaret
			Me.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.GrayWhenLostFocus
			Me.VerticalThumbTrack = True
			Me.HorizontalThumbTrack = True
			Me.FillSplitterPane = False
			Me.Properties.GridLineColor = System.Drawing.Color.Silver
			Me.DefaultGridBorderStyle = GridBorderStyle.Solid
		End Sub

		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			TraceUtil.TraceCurrentMethodInfo(e.KeyCode)
			MyBase.OnKeyDown(e)
		End Sub

		Friend Function InitiateProcessKeyEventArgs(ByRef m As Message) As Boolean
			Return MyBase.ProcessKeyEventArgs(m)
		End Function
	End Class
End Namespace
