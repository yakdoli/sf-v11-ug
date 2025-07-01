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
Imports System.Drawing.Text
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.Serialization

Imports Syncfusion.Diagnostics
Imports Syncfusion.Drawing
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace VirtualMergeCell
	''' <summary>
	''' Grid View 
	''' </summary>
	Public Class CustomGridControl
		Inherits GridControlBaseImp
		Public Sub New()
			MyBase.New(New CustomGridModel())
		End Sub

'INSTANT VB NOTE: The variable centerTextInVisibleCellPart was renamed since Visual Basic does not allow class members with the same name:
		Private centerTextInVisibleCellPart_Renamed As Boolean = False

		''' <summary>
		''' Set this true if you want the text in the merged cells of the first few
		''' columns to be centered in visible part of the cell and not scroll with
		''' the cell if the cell is only partially visible.
		''' </summary>
		Public Property CenterTextInVisibleCellPart() As Boolean
			Get
				Return Me.centerTextInVisibleCellPart_Renamed
			End Get
			Set(ByVal value As Boolean)
				Me.centerTextInVisibleCellPart_Renamed = value
				Refresh()
			End Set
		End Property




		'bool inTopRowChanging = false;
		Private savedTopRow As Integer = -1
		Private savedTopVisible As Boolean = False
		Private savedBottomRow As Integer = -1
		Private savedBottomVisible As Boolean = False


		''' <summary>
		''' Called before rows are scrolled.
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnTopRowChanging(ByVal e As GridRowColIndexChangingEventArgs)
			'inTopRowChanging = true;

			If centerTextInVisibleCellPart_Renamed Then
				savedTopRow = TopRowIndex
				savedTopVisible = ViewLayout.IsRowVisible(savedTopRow)
				savedBottomRow = ViewLayout.LastVisibleRow
				savedBottomVisible = Not ViewLayout.HasPartialVisibleRows
			End If

			MyBase.OnTopRowChanging (e)
		End Sub


		''' <summary>
		''' After rows were scrolled.
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnTopRowChanged(ByVal e As GridRowColIndexChangedEventArgs)
			MyBase.OnTopRowChanged (e)
			'inTopRowChanging = false;

			If centerTextInVisibleCellPart_Renamed AndAlso e.Success Then
				Dim rowIndex1 As Integer = TopRowIndex-1
				Dim visRow1 As Boolean = False 'ViewLayout.IsRowVisible(rowIndex1) && savedTopVisible;

				Dim rowIndex2 As Integer = savedBottomRow
				Dim visRow2 As Boolean = Not ViewLayout.HasPartialVisibleRows

				Dim clientCols As Integer = ViewLayout.VisibleCols

				If (Not visRow1) OrElse (Not visRow2) Then
					Dim ranges As New GridRangeInfoList()

					For n As Integer = 0 To clientCols - 1
						Dim colIndex As Integer = GetCol(n)
						Dim mergeRange As GridRangeInfo

						If Not visRow1 Then
							Dim r As Integer = Math.Max(rowIndex1, savedTopRow)
							If Model.MergeCells.Find(GridMergeCellDirection.RowsInColumn, r, colIndex, mergeRange) AndAlso (Not ranges.Contains(mergeRange)) Then
								If mergeRange.Bottom >= TopRowIndex Then
									' found a merged range that is only partially visible and this
									' needs to be fully repainted (since we do want to center text
									' within the visible boundaries of the cell only and not scroll
									' centered text out of view).
									Update()
									RefreshRange(mergeRange)
									ranges.Add(mergeRange)
								End If

							End If
						End If
						If Not visRow2 Then
							If Model.MergeCells.Find(GridMergeCellDirection.RowsInColumn, rowIndex2, colIndex, mergeRange) AndAlso (Not ranges.Contains(mergeRange)) Then
								If mergeRange.Top <= rowIndex2 Then
									' found a merged range that is only partially visible and this
									' needs to be fully repainted (since we do want to center text
									' within the visible boundaries of the cell only and not scroll
									' centered text out of view).
									Update()
									RefreshRange(mergeRange)
								End If

							End If
						End If
					Next n
				End If
			End If
		End Sub

	End Class

    <Serializable()> _
 Public Class CustomCellModel
        Inherits GridStaticCellModel
        Public Sub New(ByVal grid As GridModel)
            MyBase.New(grid)
            Me.AllowMerging = True
        End Sub

        Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
            MyBase.New(info, context)
        End Sub

        ''' <override/>
        Public Overrides Function CreateRenderer(ByVal grid As GridControlBase) As GridCellRendererBase
            Return New CustomCellRenderer(grid, Me)
        End Function
    End Class

	Public Class CustomCellRenderer
		Inherits GridStaticCellRenderer
		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
		End Sub

		''' <override/>
		Protected Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)

			If clientRectangle.IsEmpty Then
				Return
			End If

			Dim grid As CustomGridControl = TryCast(Me.Grid, CustomGridControl)
			If grid IsNot Nothing AndAlso grid.CenterTextInVisibleCellPart AndAlso colIndex < 3 AndAlso rowIndex > 0 Then
				Dim bounds As Rectangle = clientRectangle
				bounds.Intersect(grid.ViewLayout.RangeInfoToRectangle(GridRangeInfo.Cells(grid.TopRowIndex, 0, grid.ViewLayout.LastVisibleRow, grid.ViewLayout.LastVisibleCol), True, GridCellSizeKind.VisibleSize))
				bounds.Intersect(grid.ClientRectangle)

				Dim displayText As String = String.Empty

				Dim textRectangle As Rectangle = RemoveMargins(bounds, style)
				If textRectangle.IsEmpty Then
					Return
				End If

				displayText = style.Text

				If displayText.Length > 0 Then
					Dim font As Font = style.GdipFont
                    Dim textColor As Color = IIf(grid.PrintingMode AndAlso grid.Model.Properties.BlackWhite, Color.Black, style.TextColor) 'TODO: For performance reasons this should be changed to nested IF statements
					DrawText(g, displayText, font, textRectangle, style, textColor, False)
				End If
				Return
			End If
			MyBase.OnDraw (g, clientRectangle, rowIndex, colIndex, style)
		End Sub
	End Class

	''' <summary>
	''' Grid Model
	''' </summary>
	Public Class CustomGridModel
		Inherits GridModel
		Public Sub New()
			' Initial dimension
			RowCount = 1000
			ColCount = 8

			' initial row and column sizes
			Rows.DefaultSize = 18
			Cols.DefaultSize = 70

			Properties.GridLineColor = System.Drawing.Color.FromArgb(208, 215, 229)
			RowHeights(0) = 21
			ColWidths(0) = 35
			RowHeights.ResetModified()
			ColWidths.ResetModified()

			' fixed columns
			Cols.HeaderCount = 1
			Cols.FrozenCount = 2

			' standard base styles
			BaseStylesMap.RegisterStandardStyles()

			Dim standardStyle As GridStyleInfo = BaseStylesMap("Standard").StyleInfo
			standardStyle.MergeCell = GridMergeCellDirection.RowsInColumn

			Dim rowHeaderStyle As GridStyleInfo = BaseStylesMap("Row Header").StyleInfo
			'rowHeaderStyle.CellType = "Static";
			rowHeaderStyle.MergeCell = GridMergeCellDirection.RowsInColumn

			BaseStylesMap.Modified = False

			CellModels.Add("CustomCell", New CustomCellModel(Me))

			' Other options
			Options.MergeCellsMode = GridMergeCellsMode.OnDemandCalculation Or GridMergeCellsMode.MergeRowsInColumn
			Options.SmoothControlResize = False

			' At the momemnt the Excel-like selection feature is broken when using merge cells.
			Options.ExcelLikeCurrentCell = False
			Options.ExcelLikeSelectionFrame = False
			Options.GridVisualStyles = GridVisualStyles.Office2007Blue
			Options.DefaultGridBorderStyle = GridBorderStyle.Solid

		End Sub

		''' <summary>
		''' Provide cell types on demand
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnQueryCellModel(ByVal e As GridQueryCellModelEventArgs)
			MyBase.OnQueryCellModel (e)

			If e.CellModel Is Nothing Then
				Dim pGridCellObjectFactory As IGridCellModelFactory = GridFactoryProvider.CellModelFactory

				If pGridCellObjectFactory IsNot Nothing Then
					e.CellModel = pGridCellObjectFactory.CreateCellModel(e.CellType, Me)
				End If
			End If
		End Sub


		Public Function CanMergeCells(ByVal style1 As GridStyleInfo, ByVal style2 As GridStyleInfo) As Boolean
			Dim id1 As GridStyleInfoIdentity = style1.CellIdentity
			Dim id2 As GridStyleInfoIdentity = style2.CellIdentity

			If id1.RowIndex < 1 OrElse id2.RowIndex < 1 Then
				Return False
			End If

'			if (id1.ColIndex > 0 && id2.ColIndex > 0
'				&& !CanMergeCells(this[id1.RowIndex, id1.ColIndex-1], this[id2.RowIndex, id2.ColIndex-1]))
'				return false;

			Return style1.Text <> "" AndAlso style1.Text = style2.Text
		End Function

		''' <summary>
		''' Here you can can compare cells if they meet the criteria for 
		''' automatic merging. You could also consider neighbouring columns
		''' as part of the criteria if necessary.
		''' </summary>
		''' <param name="style1"></param>
		''' <param name="style2"></param>
		''' <returns></returns>
		Protected Overrides Sub OnQueryCanMergeCells(ByVal e As GridQueryCanMergeCellsEventArgs)
			MyBase.OnQueryCanMergeCells (e)

			If Not e.Handled Then
				Dim id1 As GridStyleInfoIdentity = e.Style1.CellIdentity
				Dim id2 As GridStyleInfoIdentity = e.Style2.CellIdentity

				If id1.ColIndex <= 3 Then
					e.Result = CanMergeCells(e.Style1, e.Style2)
					e.Handled = True
				End If
				' for other cells (Col 4 and higher) we just do default handling 
			End If
		End Sub

		''' <summary>
		''' First 3 columns are filled virtually - changes are ignored. The other columns
		''' are saved and loaded from GridData object.
		''' </summary>
		''' <param name="e"></param>
		Protected Overrides Sub OnQueryCellInfo(ByVal e As GridQueryCellInfoEventArgs)
			MyBase.OnQueryCellInfo (e)

			If Not e.Handled Then
				If e.ColIndex >= 0 AndAlso e.RowIndex > 0 Then
					If e.ColIndex < 3 Then
						Dim part As Integer = (4-e.ColIndex)*5 Xor 2
						Dim num As Integer = e.RowIndex \ part
						e.Style.CellValue = num
						e.Style.CellType = "CustomCell"
						e.Style.CellAppearance = GridCellAppearance.Raised
						e.Handled = True
					ElseIf e.ColIndex = 3 Then
						e.Style.CellValue = e.RowIndex\30
						e.Handled = True
					End If
				End If
			End If
		End Sub
	End Class
End Namespace
