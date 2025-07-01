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
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms

Imports Syncfusion.ComponentModel
Imports Syncfusion.Drawing
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Imports Syncfusion.Windows.Forms.Tools.XPMenus
Namespace ExcelLikeUI_2005

	''' <summary>
	''' SampleGridModel for Workbook/Worksheet support (see MenuAction.NewWorkbookFile)
	''' </summary>
	Public Class SampleGridModel
		Inherits GridModel
		Implements ICreateControl
        Public Overrides Function CreateControl() As Control 'Implements ICreateControl.CreateControl
            Dim grid As GridControlBase = New SampleGrid(Me)
            grid.FillSplitterPane = True
            Return grid
        End Function
	End Class

	''' <summary>
	'''    A derived grid component class.
	''' </summary>
	Public Class SampleGrid
		Inherits GridControl
		Private excelLikeThickBorderSelection As ExcelLikeThickBorderSelection
		Private excelLikeOutlineHeader As ExcelLikeOutlineHeader

		Public Sub New()
			Me.New(Nothing)
		End Sub

		Public Sub New(ByVal model As GridModel)
			MyBase.New(model)
			Me.FillSplitterPane = True

			' transparent
			Dim alphablending As Boolean = False
			If alphablending Then
				Me.SupportsTransparentBackColor = True
				Me.BackColor = Color.FromArgb(99, Color.White)
			Else
				Me.BackColor = Color.White
				Me.ForeColor = SystemColors.WindowText
			End If
			Me.VerticalThumbTrack = False
			Me.VerticalScrollTips = True
			Me.HorizontalThumbTrack = True
			Me.HorizontalScrollTips = True


			'Set properties to get the XP flat look
			Me.ThemesEnabled = False
			Me.Properties.Buttons3D = False
			Me.DefaultGridBorderStyle = GridBorderStyle.Solid
			Me.Properties.GridLineColor = Color.FromArgb(208, 215, 229)

			Dim style As GridStyleInfo = New GridStyleInfo()
			Dim gb As GridBorder = New GridBorder(GridBorderStyle.Solid,SystemColors.ControlDark)
			style.Borders.Right = gb
			style.Borders.Bottom = style.Borders.Right

			Me.BaseStylesMap("Header").StyleInfo.ModifyStyle(style,Syncfusion.Styles.StyleModifyType.Override)
			Me.BaseStylesMap("Header").StyleInfo.Font.Bold=False
			Me.BaseStylesMap("Header").StyleInfo.Font.Facename="Verdana"
			Me.BaseStylesMap("Header").StyleInfo.Font.Size=10

			Me.Properties.MarkColHeader=True
			Me.Properties.MarkRowHeader=True
			Me.TableStyle.Font.Facename="Verdana"
			Me.TableStyle.Font.Size=10

			excelLikeThickBorderSelection = New ExcelLikeThickBorderSelection(Me)
			excelLikeOutlineHeader = New ExcelLikeOutlineHeader(Me)
			AddHandler QueryCellInfo, AddressOf SampleGrid_QueryCellInfo
		End Sub

		Private Sub SampleGrid_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
			Dim gb As GridBorder = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(158, 182, 206))
			If e.Style.CellType Is GridCellTypeName.Header Then
				If e.RowIndex = 0 Then
					e.Style.Interior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(249, 252, 253), Color.FromArgb(211, 220, 233))
				ElseIf e.ColIndex = 0 Then
					e.Style.BackColor = Color.FromArgb(228, 236, 247)
				End If
				e.Style.Borders.Right = gb
				e.Style.Borders.Bottom = e.Style.Borders.Right
			End If
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				excelLikeThickBorderSelection.Dispose()
				excelLikeOutlineHeader.Dispose()
			End If

			MyBase.Dispose(disposing)
		End Sub

		Public Overrides Sub Initialize()
			MyBase.Initialize()
			Me.TopRowIndex = InternalGetHeaderRows()+1
			Me.LeftColIndex = InternalGetHeaderCols()+1
			Me.AllowDrop = True
			Dim excelMarker As ExcelMarkerMouseController
			excelMarker = New ExcelMarkerMouseController(Me)
			Me.MouseControllerDispatcher.Add(excelMarker)

			Dim formulaController As FormulaRangeSelectionController = New FormulaRangeSelectionController(Me)
			Me.MouseControllerDispatcher.Add(formulaController)

			'Make sure there is a current cell
			Me.CurrentCell.Activate(1,1,GridSetCurrentCellOptions.ScrollInView)
		End Sub

		Public Shared Sub SetupGridModel(ByVal model As GridModel)
			GridFactoryProvider.Init(New GridCellModelFactory())
			model.BeginInit()

			'setting properties.
			GridFormulaCellRenderer.ForceEditWhenActivated = False
			model.RowCount = 100
			model.ColCount = 100
			model.Rows.DefaultSize = 19
			model.Cols.DefaultSize = 65
			model.RowHeights(0) = 21
			model.ColWidths(0) = 35
			model.Options.ControllerOptions = GridControllerOptions.All Or GridControllerOptions.ExcelLikeSelection

			model.TableStyle.CellType="FormulaCell"

			model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell
			model.CommandStack.Enabled=True
			model.CellModels.Add("LinkLabel", New LinkLabelCellModel(model))
			model.EndInit()

		End Sub

	End Class


	''' <summary>
	''' Implements an alternate approach for outlining cells with a thick border
	''' just like ExcelLikeSelectionFrame and ExcelLikeCurrentCell
	''' </summary>
	Public Class ExcelLikeThickBorderSelection
		Inherits Disposable
		Private m_grid As GridControlBase

		Public Sub New(ByVal grid As GridControlBase)
			m_grid = grid

			' disable old settings - we want to replace that behavior with custom code from this class.
			m_grid.Model.Options.ExcelLikeCurrentCell = False
			m_grid.Model.Options.ExcelLikeSelectionFrame = False


			' custom drawing of borders, need to invalidate cells when selection changes
			AddHandler m_grid.Model.SelectionChanged, AddressOf gridSelectionChanged
			AddHandler m_grid.CellDrawn, AddressOf gridCellDrawn

			''' Optionally Change colors for selected cells 

		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				RemoveHandler m_grid.Model.SelectionChanged, AddressOf gridSelectionChanged
				RemoveHandler m_grid.CellDrawn, AddressOf gridCellDrawn
				RemoveHandler m_grid.PrepareViewStyleInfo, AddressOf gridPrepareViewStyleInfo
			End If

			MyBase.Dispose(disposing)
		End Sub

		''' <summary>
		''' Draw thick borders for cells that are at edge of selection.
		''' </summary>
		Private Sub gridCellDrawn(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
			Dim grid As GridControlBase = CType(sender, GridControlBase)
			Dim rg As GridRangeInfo = grid.Selections.Ranges.ActiveRange

			If rg.Contains(GridRangeInfo.Cell(e.RowIndex, e.ColIndex)) Then
				Dim r As Rectangle = grid.RangeInfoToRectangle(GridRangeInfo.Cell(e.RowIndex, e.ColIndex))
				r.Height -= 1
				r.Width -= 1

				If rg.Left = e.ColIndex Then
					GridBorderPaint.DrawRectangle(e.Graphics, New GridBorder(GridBorderStyle.Solid, m_selectionBackColor, GridBorderWeight.ExtraExtraThick), r, Color.Beige, GridBorderSide.Left)
				End If

				If rg.Right = e.ColIndex Then
					GridBorderPaint.DrawRectangle(e.Graphics, New GridBorder(GridBorderStyle.Solid, m_selectionBackColor, GridBorderWeight.ExtraExtraThick), r, Color.Beige, GridBorderSide.Right)
				End If


				If rg.Top = e.RowIndex Then
					GridBorderPaint.DrawRectangle(e.Graphics, New GridBorder(GridBorderStyle.Solid, m_selectionBackColor, GridBorderWeight.ExtraExtraThick), r, Color.Beige, GridBorderSide.Top)
				End If

				If rg.Bottom = e.RowIndex Then
					GridBorderPaint.DrawRectangle(e.Graphics, New GridBorder(GridBorderStyle.Solid, m_selectionBackColor, GridBorderWeight.ExtraExtraThick), r, Color.Beige, GridBorderSide.Bottom)
				End If


				Dim rv As Rectangle = r
				Dim rh As Rectangle = r
				rh.Inflate(-2, 0)
				rv.Inflate(0, -2)

				If rg.Top = e.RowIndex Then
					rh.Y += 2
					rh.Height -= 2
				End If

				If rg.Bottom = e.RowIndex Then
					rh.Height -= 2
				End If


				If rg.Left = e.ColIndex Then
					rv.X += 2
					rv.Width -= 2
				End If

				If rg.Right = e.ColIndex Then
					rv.Width -= 2
				End If


				If rg.Left = e.ColIndex Then
					GridBorderPaint.DrawRectangle(e.Graphics, New GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Medium), rh, Color.Beige, GridBorderSide.Left)
				End If

				If rg.Right = e.ColIndex Then
					GridBorderPaint.DrawRectangle(e.Graphics, New GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Medium), rh, Color.Beige, GridBorderSide.Right)
				End If


				If rg.Top = e.RowIndex Then
					GridBorderPaint.DrawRectangle(e.Graphics, New GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Medium), rv, Color.Beige, GridBorderSide.Top)
				End If

				If rg.Bottom = e.RowIndex Then
					GridBorderPaint.DrawRectangle(e.Graphics, New GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Medium), rv, Color.Beige, GridBorderSide.Bottom)
				End If


				If rg.Right = e.ColIndex AndAlso rg.Bottom = e.RowIndex Then
					Dim rbr As Rectangle = r
					Dim d As Integer = 5
					rbr.X = rbr.Right - d
					rbr.Width = d
					rbr.Y = rbr.Bottom - d
					rbr.Height = d

					GridBorderPaint.DrawRectangle(e.Graphics, New GridBorder(GridBorderStyle.Solid, Color.White, GridBorderWeight.Thick), rbr, Color.Beige, GridBorderSide.Top Or GridBorderSide.Left)
				End If

			End If

		End Sub

		''' <summary>
		''' Repaint selected cells.
		''' </summary>
		Private Sub gridSelectionChanged(ByVal sender As Object, ByVal e As GridSelectionChangedEventArgs)
			Me.m_grid.UpdateWithDrawClippedGrid(m_grid.RangeInfoToRectangle(e.Range))
		End Sub

		Private m_selectionBackColor As Color = SystemColors.Highlight
		Private m_selectionTextColor As Color = SystemColors.HighlightText

		''' <summary>
		''' Optionally Change colors for selected cells 
		''' </summary>
		Private Sub gridPrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
			Dim grid As GridControlBase = CType(sender, GridControlBase)
			If grid.Selections.Ranges.AnyRangeContains(GridRangeInfo.Cell(e.RowIndex, e.ColIndex)) AndAlso (Not grid.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex)) Then
				e.Style.BackColor = m_selectionBackColor
				e.Style.TextColor = m_selectionTextColor
			End If
		End Sub
	End Class

	''' <summary>
	''' Highlight column and row headers for selected range
	''' </summary>
	Public Class ExcelLikeOutlineHeader
		Inherits Disposable
		Private m_grid As GridControlBase
		Private activeRange As GridRangeInfo

		Public Sub New(ByVal grid As GridControlBase)
			m_grid = grid

			AddHandler m_grid.Model.SelectionChanged, AddressOf gridSelectionChanged
			AddHandler m_grid.PrepareViewStyleInfo, AddressOf gridPrepareViewStyleInfo
		End Sub

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				RemoveHandler m_grid.Model.SelectionChanged, AddressOf gridSelectionChanged
				RemoveHandler m_grid.PrepareViewStyleInfo, AddressOf gridPrepareViewStyleInfo
			End If

			MyBase.Dispose(disposing)
		End Sub

		Private Function GetColHeaderRange(ByVal range As GridRangeInfo) As GridRangeInfo
			Return GridRangeInfo.Cells(0, range.Left, 0, range.Right)
		End Function

		Private Function GetRowHeaderRange(ByVal range As GridRangeInfo) As GridRangeInfo
			Return GridRangeInfo.Cells(range.Top, 0, range.Bottom, 0)
		End Function


		''' <summary>
		''' Repaint selected cells.
		''' </summary>
		Private Sub gridSelectionChanged(ByVal sender As Object, ByVal e As GridSelectionChangedEventArgs)
			Dim colRange As GridRangeInfo = GridRangeInfo.Empty
			Dim rowRange As GridRangeInfo = GridRangeInfo.Empty

			If Not activeRange Is Nothing AndAlso (Not activeRange.IsEmpty) Then
				colRange = GetColHeaderRange(activeRange)
				rowRange = GetRowHeaderRange(activeRange)
			End If

			activeRange = e.Range

			If Not activeRange Is Nothing AndAlso (Not activeRange.IsEmpty) Then
				colRange = GridRangeInfo.UnionRange(colRange, GetColHeaderRange(activeRange))
				rowRange = GridRangeInfo.UnionRange(rowRange, GetRowHeaderRange(activeRange))
			End If

			m_grid.UpdateWithDrawClippedGrid(m_grid.RangeInfoToRectangle(colRange))
			m_grid.UpdateWithDrawClippedGrid(m_grid.RangeInfoToRectangle(rowRange))
		End Sub

		Private Sub gridPrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
			Dim gb As GridBorder = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(242, 149, 54))
			If Not activeRange Is Nothing Then
				If ((e.RowIndex = 0 AndAlso (e.ColIndex >= activeRange.Left AndAlso e.ColIndex <= activeRange.Right)) OrElse (e.ColIndex = 0 AndAlso (e.RowIndex >= activeRange.Top AndAlso e.RowIndex <= activeRange.Bottom))) AndAlso Not(e.ColIndex = 0 AndAlso e.RowIndex = 0) Then
					e.Style.Borders.Right = gb
					e.Style.Borders.Bottom = e.Style.Borders.Right
					If e.RowIndex = 0 Then
						e.Style.Interior = New BrushInfo(GradientStyle.Vertical, Color.FromArgb(249, 217, 159), Color.FromArgb(242, 193, 96))
					ElseIf e.ColIndex = 0 Then
						e.Style.BackColor = Color.FromArgb(255, 213, 141)
					End If
					e.Cancel = True
				End If
			End If
		End Sub
	End Class
End Namespace