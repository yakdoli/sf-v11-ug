Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Grouping
Imports System.Collections
Imports System.Collections.Specialized

Imports PivotGridLibrary.PivotGridControl
Imports Syncfusion.Styles

Namespace PivotGridLibrary
	Public Partial Class PivotGridControl
		Inherits UserControl
		Public Sub New()
			'turn off warning on Fields.Add behavior...
			FieldDescriptorCollection.AllowAddRangeChangedWarning = False

			InitializeComponent()

			collapsedNodes_Renamed = New Hashtable()
			appearance = New PivotAppearance()

			SubscribeToNonGridEvents()

			SizeGridsInLowerRight()

			SizePanelsOnLeftSide()

			SubscribeToGridEventsAndSetGridProperties()

		End Sub

		#Region "event subscription code"

		Private Sub SubscribeToGridEventsAndSetGridProperties()
			'used to handle dragging items from grid to grid and rearranging 
			AddHandler gridColumns.RowsMoving, AddressOf grid_RowsMoving
			AddHandler gridFields.RowsMoving, AddressOf grid_RowsMoving
			AddHandler gridFilter.RowsMoving, AddressOf grid_RowsMoving
			AddHandler gridRows.RowsMoving, AddressOf grid_RowsMoving
			AddHandler gridValues.RowsMoving, AddressOf grid_RowsMoving

			AddHandler gridValues.CellClick, AddressOf gridValues_CellClick

			AddHandler gridFields.CheckBoxClick, AddressOf gridFields_CheckBoxClick

			'set up virtual support of the display grid
			AddHandler gridMainDisplay.QueryCellInfo, AddressOf gridMainDisplay_QueryCellInfo

			'collapse cell support
			gridMainDisplay.CellModels.Add("PivotButtonCell", New PivotButtonCellModel(gridMainDisplay.Model))
			AddHandler gridMainDisplay.PushButtonClick, AddressOf gridMainDisplay_PushButtonClick

			'show initial panel through the grid drawing event the first time loaded...
			gridMainDisplay.Visible = True
			AddHandler gridMainDisplay.Paint, AddressOf gridMainDisplay_Paint

			'listen to events to draw icons
			AddHandler gridMainFilters.CellDrawn, AddressOf gridMainFilters_CellDrawn
			AddHandler gridMainRows.CellDrawn, AddressOf gridMainRows_CellDrawn
			AddHandler gridMainColumns.CellDrawn, AddressOf gridMainColumns_CellDrawn

			'handle the filtering on the filters grid
			AddHandler gridMainFilters.CurrentCellAcceptedChanges, AddressOf gridMainFilters_CurrentCellAcceptedChanges
			AddHandler gridMainFilters.CurrentCellCloseDropDown, AddressOf gridMainFilters_CurrentCellCloseDropDown

			gridMainDisplay.ResizeColsBehavior = GridResizeCellsBehavior.InsideGrid Or GridResizeCellsBehavior.IgnoreHeaders Or GridResizeCellsBehavior.ResizeSingle
            'AddHandler gridFilter.RowsRemoved, AddressOf gridFilter_RowsRemoved
            'AddHandler gridColumns.RowsRemoved, AddressOf gridColumns_RowsRemoved
            'AddHandler gridRows.RowsRemoved, AddressOf gridRows_RowsRemoved
            'AddHandler gridRows.RowsRemoving, AddressOf gridRows_RowsRemoving
            'AddHandler gridColumns.RowsRemoving, AddressOf gridColumns_RowsRemoving
            AddHandler gridFilter.RowsRemoving, AddressOf gridFilter_RowsRemoving
            AddHandler gridFilter.KeyDown, AddressOf grid_Delete
            AddHandler gridRows.KeyDown, AddressOf grid_Delete
            AddHandler gridValues.KeyDown, AddressOf grid_Delete
            AddHandler gridColumns.KeyDown, AddressOf grid_Delete
        End Sub
        Private Sub grid_Delete(ByVal sender As Object, ByVal e As KeyEventArgs)
            Dim grid As GridList = TryCast(sender, GridList)
            If e.KeyCode = Keys.Delete Then
                Dim fieldName As String = grid.CurrentCell.Renderer.ControlText
                Dim row As Integer = grid.CurrentCell.RowIndex
                grid.Rows.RemoveRange(row, row)
                SetCheck(fieldName, False)
                PerformLayout(grid, Nothing)
            End If
            e.Handled = True
        End Sub

        Private Sub gridFilter_RowsRemoving(ByVal sender As Object, ByVal e As GridRangeRemovingEventArgs)
            Dim s As String = gridFilter(e.From, 0).Text
            If EngineValues.TableDescriptor.RecordFilters.Contains(s) Then
                EngineValues.TableDescriptor.RecordFilters.Remove(s)
            End If
            If EngineColumns.TableDescriptor.RecordFilters.Contains(s) Then
                EngineColumns.TableDescriptor.RecordFilters.Remove(s)
            End If
            If EngineRows.TableDescriptor.RecordFilters.Contains(s) Then
                EngineRows.TableDescriptor.RecordFilters.Remove(s)
            End If

        End Sub
        Private Sub gridColumns_RowsRemoving(ByVal sender As Object, ByVal e As GridRangeRemovingEventArgs)
            SetCheck(gridColumns(e.From, 0).Text, False)
        End Sub
        Private Sub gridRows_RowsRemoving(ByVal sender As Object, ByVal e As GridRangeRemovingEventArgs)
            SetCheck(gridRows(e.From, 0).Text, False)
        End Sub
        Private Sub gridFilter_RowsRemoved(ByVal sender As Object, ByVal e As GridRangeRemovedEventArgs)
            SetUpMainFiltersGridAndApplyFilters()
        End Sub
        Private Sub gridColumns_RowsRemoved(ByVal sender As Object, ByVal e As GridRangeRemovedEventArgs)
            SetUpMainColumnsGridAndEngines()
            If gridRows.RowCount > 0 Then
                PerformLayout(gridFields, gridMainDisplay)
            End If
        End Sub
        Private Sub gridRows_RowsRemoved(ByVal sender As Object, ByVal e As GridRangeRemovedEventArgs)
            SetUpMainRowsGridAndEngines()
            If gridRows.RowCount > 0 Then
                PerformLayout(gridFields, gridMainDisplay)
            End If
        End Sub
		'used to handle layout of the various panels holding the various grids
		'used to catch click actions on various non-grid controls
		'used to set particular non-grid control properties
		Private Sub SubscribeToNonGridEvents()
		   AddHandler panelRB.SizeChanged, AddressOf panelRB_SizeChanged
			 AddHandler panelLeft.SizeChanged, AddressOf panelLeft_SizeChanged
			AddHandler checkBoxDeferLayout.CheckedChanged, AddressOf checkBoxDeferLayout_CheckedChanged
			AddHandler buttonUpdate.Click, AddressOf buttonUpdate_Click
			Me.splitter2.Enabled = False

			'handle the collapse and expand of the right panel
			AddHandler pictureBoxExpanded.Click, AddressOf pictureBoxCollapseExpand_Click
			AddHandler pictureBoxCollapsed.Click, AddressOf pictureBoxCollapseExpand_Click

		End Sub



		#End Region

		#Region "strings"

		Private allString_Renamed As String = "(all)"

		Public Property AllString() As String
			Get
				Return allString_Renamed
			End Get
			Set(ByVal value As String)
				allString_Renamed = value
			End Set
		End Property

		Private totalString_Renamed As String = "Total"

		Public Property TotalString() As String
			Get
				Return totalString_Renamed
			End Get
			Set(ByVal value As String)
				totalString_Renamed = value
			End Set
		End Property

		Private grandTotalString_Renamed As String = "Grand Total"

		Public Property GrandTotalString() As String
			Get
				Return grandTotalString_Renamed
			End Get
			Set(ByVal value As String)
				grandTotalString_Renamed = value
			End Set
		End Property

		#End Region

		#Region "filtering support"

		Private Sub gridMainFilters_CurrentCellCloseDropDown(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.PopupClosedEventArgs)
			gridMainFilters.CurrentCell.ConfirmChanges()

		End Sub


		Private Sub gridMainFilters_CurrentCellAcceptedChanges(ByVal sender As Object, ByVal e As CancelEventArgs)
			Me.Cursor = Cursors.WaitCursor

			Dim cc As GridCurrentCell = gridMainFilters.CurrentCell
			Dim value As String = cc.Renderer.ControlText
			'need to strip off the colon that was added to the cell value....
			Dim columnName As String = gridMainFilters(cc.RowIndex, cc.ColIndex - 1).Text.Substring(0, gridMainFilters(cc.RowIndex, cc.ColIndex - 1).Text.Length - 1)
			ApplyFilter(columnName, value)
			cc.EndEdit()
			Dim width As Integer = gridMainFilters.ColWidths(cc.ColIndex)
			gridMainFilters.ColWidths.ResizeToFit(cc.RangeInfo, GridResizeToFitOptions.NoShrinkSize)
			If width <> gridMainFilters.ColWidths(cc.ColIndex) Then
				LeftPanelWidth = gridMainFilters.ColWidths.GetTotal(0, gridMainFilters.ColCount) 'triggers a resize...
			End If
			Me.Cursor = Cursors.Default
		End Sub

		Private Sub ApplyFilter(ByVal columnName As String, ByVal value As String)

			'remove any existing filter
			If engineValues_Renamed.TableDescriptor.RecordFilters.IndexOf(columnName) > -1 Then
				engineValues_Renamed.TableDescriptor.RecordFilters.Remove(columnName)
			End If
			If engineColumns_Renamed.TableDescriptor.RecordFilters.IndexOf(columnName) > -1 Then
				engineColumns_Renamed.TableDescriptor.RecordFilters.Remove(columnName)
			End If
			If engineRows_Renamed.TableDescriptor.RecordFilters.IndexOf(columnName) > -1 Then
				engineRows_Renamed.TableDescriptor.RecordFilters.Remove(columnName)
			End If

			'aply a new filter...
			If value <> AllString Then
				Dim fc As FilterCondition = New FilterCondition(FilterCompareOperator.Equals, value)
				Dim rfd As RecordFilterDescriptor = New RecordFilterDescriptor(columnName, fc)
				engineValues_Renamed.TableDescriptor.RecordFilters.Add(TryCast(rfd.Clone(), RecordFilterDescriptor))
				engineColumns_Renamed.TableDescriptor.RecordFilters.Add(TryCast(rfd.Clone(), RecordFilterDescriptor))
				engineRows_Renamed.TableDescriptor.RecordFilters.Add(TryCast(rfd, RecordFilterDescriptor))

			End If
			UpdateValues()
		End Sub

		#End Region

		#Region "right panel show/hide"

		Private rightPaneCollapsed As Boolean = False
		Private Sub pictureBoxCollapseExpand_Click(ByVal sender As Object, ByVal e As EventArgs)
			'avoid panels reacting to size changes
			inSizeChanged = True
			'show/hide the right panel
			Me.panelRight.Visible = rightPaneCollapsed
			'show/hide the clickable glyph
			Me.pictureBoxCollapsed.Visible = Not rightPaneCollapsed
			'change the state variable
			rightPaneCollapsed = Not rightPaneCollapsed
			inSizeChanged = False
		End Sub
		#End Region

		#Region "bitmap drawing support"

		Private Sub gridMainColumns_CellDrawn(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
			If e.RowIndex = 0 AndAlso e.ColIndex > 0 Then
				DrawIcon(COLUMNHEADERBITMAP, e)
			End If
		End Sub

		Private Sub gridMainRows_CellDrawn(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
			If e.RowIndex > 0 AndAlso e.ColIndex = 0 Then
				DrawIcon(ROWHEADERBITMAP, e)
			End If
		End Sub

		Private Sub gridMainFilters_CellDrawn(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
			If e.RowIndex > 0 AndAlso e.ColIndex = 0 Then
				DrawIcon(FUNNELBITMAP, e)
			End If
		End Sub

		Private Const FUNNELBITMAP As String = "funnel.png"
		Private Const ROWHEADERBITMAP As String = "table_sql_row.png"
		Private Const COLUMNHEADERBITMAP As String = "table_sql.png"
		Private Sub DrawIcon(ByVal bitMapName As String, ByVal e As GridDrawCellEventArgs)
			Dim rect As Rectangle = e.Bounds
			rect.Width = 20 'bmp centered in this rectangle
			IconDrawingSupport.DrawImage(e.Graphics, bitMapName, rect, New Point(0, 0))
		End Sub

		#End Region

		#Region "handle responding to change in underlying data"

		Private isDirty As Boolean = False
		Private Sub engine_GroupSummaryInvalidated(ByVal sender As Object, ByVal e As GroupEventArgs)

			If (Not isDirty) Then
				isDirty = True
				BeginInvoke(New MethodInvoker(AddressOf DelayUpdateValues))
			End If
		End Sub

		Private Sub engine_GroupSummaryInvalidated1(ByVal sender As Object, ByVal e As GroupEventArgs)
			If (Not isDirty) Then
				isDirty = True
				BeginInvoke(New MethodInvoker(AddressOf DelayUpdateValues))
			End If
		End Sub

		Private Sub DelayUpdateValues()
			If isDirty Then
				UpdateValues()
			End If
			isDirty = False
		End Sub


		#End Region

		#Region "initialization code"

		Private Sub InitDisplay()
			Dim typedList As ITypedList = TryCast(list, ITypedList)
			If Not typedList Is Nothing Then
'				#Region "the Fields grid"
				Dim pdc As PropertyDescriptorCollection = typedList.GetItemProperties(Nothing)
				gridFields.RowCount = pdc.Count + 2
				gridFields.RowHeights(1) = 1 'need extra row at top tro allow dragging of headers to grids in the left panel
				gridFields.RowHeights(gridFields.RowCount) = 1 'need extra row at bottom to allow dragging of headers to grid beneath
				gridFields.ColCount = 0
				gridFields.ColWidths(0) = gridFields.ClientSize.Width
				Dim row As Integer = 2
				For Each pd As PropertyDescriptor In pdc
					gridFields(row, 0).Text = "0"
					gridFields(row, 0).Description = pd.Name
					row += 1
				Next pd

				gridFields.BaseStylesMap("Row Header").StyleInfo.CellAppearance = GridCellAppearance.Flat
				gridFields.BaseStylesMap("Row Header").StyleInfo.BackColor = gridFields.TableStyle.BackColor
				gridFields.BaseStylesMap("Row Header").StyleInfo.CellType = "CheckBox"
				gridFields.BaseStylesMap("Row Header").StyleInfo.CheckBoxOptions.CheckedValue = "1"
				gridFields.BaseStylesMap("Row Header").StyleInfo.CheckBoxOptions.UncheckedValue = "0"

				gridFields.BaseStylesMap("Row Header").StyleInfo.Font.Bold = False
				gridFields.HasCheckBox = True
				gridFields.HasPaddedRow = False
'				#End Region

'				#Region "the other grids"
				InitTargetGrid(gridRows)
				InitTargetGrid(gridFilter)
				InitTargetGrid(gridColumns)
				InitTargetGrid(gridValues)
'				#End Region

'				#Region "main display grid"
				gridMainDisplay.TableStyle.CellType = "Static"
				gridMainDisplay.TableStyle.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, Color.LightGray)
				gridMainDisplay.TableStyle.Borders.Right = New GridBorder(GridBorderStyle.Solid, Color.LightGray)
			   ' gridMainDisplay.DefaultGridBorderStyle = GridBorderStyle.Solid;
				gridMainDisplay.Model.Options.DisplayEmptyRows = True
				gridMainDisplay.Model.Options.DisplayEmptyColumns = True
				gridMainDisplay.ThemesEnabled = True
				gridMainDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
				gridMainDisplay.Office2007ScrollBars = True

				SetUpAMainGrid(gridMainColumns)

				SetUpAMainGrid(gridMainRows)

				SetUpAMainGrid(gridMainFilters)

'				#End Region

				SetLabelVisibility()
			End If
		End Sub

		Private Sub SetUpAMainGrid(ByVal grid As GridControl)
			grid.ThemesEnabled = True
			grid.HScrollBehavior = GridScrollbarMode.Disabled
			grid.HScroll = False
		   ' grid.ControllerOptions |= GridControllerOptions.DragColumnHeader;
			grid.AllowSelection = GridSelectionFlags.None
			grid.ColWidths(0) = panelRows.Width - 1

			grid.RowHeights(0) = panelColumns.Height - 1
			grid.BaseStylesMap("Row Header").StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center
			grid.BaseStylesMap("Column Header").StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center
			grid.BaseStylesMap("Row Header").StyleInfo.VerticalAlignment = GridVerticalAlignment.Middle
			grid.BaseStylesMap("Column Header").StyleInfo.VerticalAlignment = GridVerticalAlignment.Middle

			grid.BaseStylesMap("Column Header").StyleInfo.TextMargins = New GridMarginsInfo(16, 0, 0, 0) '20 is space for bmp on the left
			grid.BaseStylesMap("Row Header").StyleInfo.TextMargins = New GridMarginsInfo(16, 0, 0, 0) '20 is space for bmp on the left
			grid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			grid.Office2007ScrollBars = True
			grid.Properties.BackgroundColor = Color.FromArgb(227, 239, 255)
		End Sub

		Private Sub InitTargetGrid(ByVal grid As GridControl)
			grid.ColCount = 0
			grid.RowCount = 2
			grid.RowHeights(1) = 3 'hidden last row serves as a pad to allow D&D to work
			grid.RowHeights(2) = 3
			'grid[1, 0].BackColor = Color.Red; //so you can see them for debug purposes....
			'grid[2, 0].BackColor = Color.Blue;

			grid.ColWidths(0) = gridRows.ClientSize.Width
			grid.BaseStylesMap("Row Header").StyleInfo.CellAppearance = GridCellAppearance.Flat
			grid.BaseStylesMap("Row Header").StyleInfo.BackColor = gridFields.TableStyle.BackColor
			grid.BaseStylesMap("Row Header").StyleInfo.Font.Bold = False
			grid.BaseStylesMap("Row Header").StyleInfo.CellType = "Static"
		End Sub
		#End Region

		#Region "properties"

        '<NonSerialized> _
        Private appearance As PivotAppearance = Nothing

		Public Function GetAppearance() As PivotAppearance
			  If appearance Is Nothing Then
					appearance = New PivotAppearance()
			  End If
				Return appearance
		End Function
		Public Sub SetAppearance(ByVal appearance As PivotAppearance)
			Me.appearance = appearance
			Me.UpdateValues() 'forces the appearance to be applied
		End Sub


		#Region "count properties"
		Public ReadOnly Property Count() As Integer
			Get
				Return DataRowCount
			End Get
		End Property
		Public ReadOnly Property DataRowCount() As Integer
			Get
				Return list.Count
			End Get
		End Property

		Public ReadOnly Property FilterCount() As Integer
			Get
				Return gridFilter.RowCount - 2
			End Get
		End Property

		Public ReadOnly Property ValueCount() As Integer
			Get
				Return gridValues.RowCount - 2
			End Get
		End Property

		Public ReadOnly Property ColumnsCount() As Integer
			Get
				Return gridColumns.RowCount - 2
			End Get
		End Property

		Public ReadOnly Property RowsCount() As Integer
			Get
				Return gridRows.RowCount - 2
			End Get
		End Property

		#End Region

		#Region "DataSource"

		Private dataSource_Renamed As Object = Nothing
		Private list As IList = Nothing

		Public Property DataSource() As Object
			Get
				Return dataSource_Renamed
			End Get
			Set(ByVal value As Object)
				If dataSource_Renamed Is Nothing OrElse (Not dataSource_Renamed.Equals(value)) Then
					dataSource_Renamed = value
					Me.list = Nothing
					If TypeOf dataSource_Renamed Is IList Then
						Me.list = TryCast(dataSource_Renamed, IList)
					ElseIf TypeOf dataSource_Renamed Is DataTable Then
						Me.list = (CType(dataSource_Renamed, DataTable)).DefaultView
					End If
					EngineColumns.SetSourceList(Me.list)
					EngineRows.SetSourceList(Me.list)
					EngineValues.SetSourceList(Me.list)
					InitDisplay()
				End If
			End Set
		End Property


		#End Region

		#Region "grouping Engines"

		Private engineColumns_Renamed As Engine = Nothing
		Private engineRows_Renamed As Engine = Nothing
		Private engineValues_Renamed As Engine = Nothing

		Public ReadOnly Property EngineValues() As Engine
			Get
				If engineValues_Renamed Is Nothing Then
					engineValues_Renamed = CreateEngine(PivotContent.Values)
				End If
				Return engineValues_Renamed
			End Get
		End Property
		Public ReadOnly Property EngineRows() As Engine
			Get
				If engineRows_Renamed Is Nothing Then
					engineRows_Renamed = CreateEngine(PivotContent.Rows)
				End If
				Return engineRows_Renamed
			End Get
		End Property

		''' <summary>
		''' Gets the grouping Engine associated with COlumns.
		''' </summary>
		Public ReadOnly Property EngineColumns() As Engine
			Get
				If engineColumns_Renamed Is Nothing Then
					engineColumns_Renamed = CreateEngine(PivotContent.Columns)
				End If
				Return engineColumns_Renamed
			End Get
		End Property

		''' <summary>
		''' Override to use a derived engine.
		''' </summary>
		''' <param name="type">Indicates which engine is needed.</param>
		''' <returns>The Engine.</returns>
		Public Overridable Function CreateEngine(ByVal type As PivotContent) As Engine
			Dim engine As Engine = New Engine()
			Select Case type
				Case PivotContent.Columns
					AddHandler engine.GroupSummaryInvalidated, AddressOf engine_GroupSummaryInvalidated
				Case PivotContent.Fields, PivotContent.Filters, PivotContent.Rows
					AddHandler engine.GroupSummaryInvalidated, AddressOf engine_GroupSummaryInvalidated1
				Case PivotContent.Values
					AddHandler engine.GroupSummaryInvalidated, AddressOf engine_GroupSummaryInvalidated
				Case Else
			End Select

			Return engine

		End Function

		#End Region

		#Region "other properties"
		Private autoSizeColumns_Renamed As Boolean = True

		Public Property AutoSizeColumns() As Boolean
			Get
				Return autoSizeColumns_Renamed
			End Get
			Set(ByVal value As Boolean)
				autoSizeColumns_Renamed = value
			End Set
		End Property

		''' <summary>
		''' Gets the GridControl that holds the pivot table results.
		''' </summary>
		Public ReadOnly Property MainDisplayGrid() As GridControl
			Get
				Return gridMainDisplay
			End Get
		End Property
		#End Region

		#End Region

		#Region "event handlers"

		#Region "Paint"
		'used to show intially empty panel - used only once...
		Private Sub gridMainDisplay_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
			RemoveHandler gridMainDisplay.Paint, AddressOf gridMainDisplay_Paint
			SetLabelVisibility()
		End Sub
		#End Region

		#Region "QueryCellInfo"

		'celltip just for debug.... need to implement true celltip that displays something
		'cachedValuesForQueryCellInfo holds values of collapsed cells
		Private Sub gridMainDisplay_QueryCellInfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
			Dim pt As Point = GetCellHashKey(e.RowIndex, e.ColIndex)
			If cachedValuesForQueryCellInfo.ContainsKey(pt) Then
				e.Style.Text = GetCachedValue(pt)
			End If
			If e.ColIndex > -1 AndAlso e.ColIndex > numberRowFields AndAlso numberValueFields > 0 AndAlso e.ColIndex < pivotRightCol AndAlso IsSummaryRow(e.RowIndex) Then
				e.Style.ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override)
			End If
			'if(e.RowIndex > 0 && e.ColIndex > 0)
			' e.Style.CellTipText = string.Format("{0}", gridMainDisplay.CoveredRanges.FindRange(e.RowIndex, e.ColIndex));
		End Sub

		Private Function IsSummaryRow(ByVal rowIndex As Integer) As Boolean
			Dim b As Boolean = False
			Dim col As Integer = 1
			Do While (Not b) AndAlso col <= numberRowFields
				b = gridMainDisplay(rowIndex, col).Text.EndsWith(TotalString)
				col += 1
			Loop
			Return b
		End Function

		#End Region

		#Region "Schema support"

		Private Sub ResetEngine(ByVal engine As Engine)
			engine.TableDescriptor.Reset()
			engine.TableDescriptor.GroupedColumns.Clear()
			engine.TableDescriptor.Summaries.Clear()
			engine.TableDescriptor.RecordFilters.Clear()
		End Sub

		Public Sub ResetSchema()
			'reset the engines...
			ResetEngine(engineColumns_Renamed)
			ResetEngine(engineRows_Renamed)
			ResetEngine(engineValues_Renamed)


			'reset the grids...
			gridRows.RowCount = 0
			gridColumns.RowCount = 0
			gridFilter.RowCount = 0
			gridValues.RowCount = 0



			gridRows.RowCount = 2
			gridColumns.RowCount = 2
			gridFilter.RowCount = 2

			For i As Integer = 2 To gridFields.RowCount - 1
				SetCheck(gridFields(i, 0).Description, False)
			Next i

			ValuesComputationInfos.Clear()
			gridValues.RowCount = 2


			InitGridRowSizes(gridFields)
			InitGridRowSizes(gridRows)
			InitGridRowSizes(gridColumns)
			InitGridRowSizes(gridFilter)
			InitGridRowSizes(gridValues)

			LayoutAllGrids()
		End Sub

		Public Sub ApplySchema(ByVal schema As PivotSchema)
			'reset the engines...
			ResetEngine(engineColumns_Renamed)
			ResetEngine(engineRows_Renamed)
			ResetEngine(engineValues_Renamed)


			'reset the grids...
			gridFields.RowCount = 0
			gridRows.RowCount = 0
			gridColumns.RowCount = 0
			gridFilter.RowCount = 0
			gridValues.RowCount = 0

			'gridMainColumns.RowCount = 0;
			'gridMainDisplay.RowCount = 0;
			'gridMainFilters.RowCount = 0;
			'gridMainRows.RowCount = 0;


			gridFields.RowCount = schema.Fields.GetLength(0) + 2
			For i As Integer = 2 To gridFields.RowCount - 1
                gridFields(i, 0).Description = schema.Fields(i - 2)
				SetCheck(schema.Fields(i - 2), False)
			Next i

			gridRows.RowCount = schema.RowFields.GetLength(0) + 2
			For i As Integer = 2 To gridRows.RowCount - 1
				gridRows(i, 0).Text = schema.RowFields(i - 2)
				SetCheck(schema.RowFields(i - 2), True)
			Next i

			gridColumns.RowCount = schema.ColumnFields.GetLength(0) + 2
			For i As Integer = 2 To gridColumns.RowCount - 1
				gridColumns(i, 0).Text = schema.ColumnFields(i - 2)
				SetCheck(schema.ColumnFields(i - 2), True)
			Next i

			gridFilter.RowCount = schema.FilterFields.GetLength(0) + 2
			For i As Integer = 2 To gridFilter.RowCount - 1
				gridFilter(i, 0).Text = schema.FilterFields(i - 2)
				SetCheck(schema.FilterFields(i - 2), True)
			Next i

			gridFilter.RowCount = 0
			gridFilter.RowCount = schema.FilterValues.GetLength(0) + 2
			For i As Integer = 2 To gridFilter.RowCount - 1
				gridMainFilters(i - 1, 1).Text = schema.FilterValues(i - 2)
			Next i

			ValuesComputationInfos.Clear()
		   gridValues.RowCount = schema.ValueComputations.GetLength(0) + 2
			For i As Integer = 2 To gridValues.RowCount - 1
				 Dim fieldName As String = schema.ValueComputations(i - 2).FieldName
				 Dim computationName As String = schema.ValueComputations(i - 2).CalculationName
				 Dim fmt As String = schema.ValueComputations(i - 2).Format
				 SetCheck(fieldName, True)

				 Dim sum As SummaryBase = PivotComputationInfoList.CreateSummary(computationName) ' new DoubleAggregateSummary(0, double.MaxValue, double.MinValue, 0d);
				 Dim info As PivotComputationInfo = New PivotComputationInfo(sum, computationName, String.Format(DefaultDescriptionFormat, computationName, fieldName), fieldName)
				gridValues(i, 0).Text = fieldName
				ValuesComputationInfos.Add(info)
			Next i

			InitGridRowSizes(gridFields)
			InitGridRowSizes(gridRows)
			InitGridRowSizes(gridColumns)
			InitGridRowSizes(gridFilter)
			InitGridRowSizes(gridValues)

			LayoutAllGrids()
		End Sub

		Private Sub InitGridRowSizes(ByVal grid As GridControl)
			grid.RowHeights(1) = 1
			grid.RowHeights(grid.RowCount) = 1
		End Sub
		Private Sub LayoutAllGrids()
			gridMainColumns.BeginUpdate()
			gridMainDisplay.BeginUpdate()
			gridMainFilters.BeginUpdate()
			gridMainRows.BeginUpdate()

			PerformLayoutOnAllGrids()
			'PerformLayout(gridFields, gridColumns);
			'PerformLayout(gridFields, gridRows);
			'PerformLayout(gridFields, gridValues);
			'PerformLayout(gridFields, gridFilter);


			'PerformLayout(gridColumns, null);
			'PerformLayout(gridRows, null);
			'PerformLayout(gridFilter, null);
			'PerformLayout(gridValues, null);



			gridMainColumns.EndUpdate(True)
			gridMainDisplay.EndUpdate(True)
			gridMainFilters.EndUpdate(True)
			gridMainRows.EndUpdate(True)
		End Sub

		Private Sub PerformLayoutOnAllGrids()
		 '   DateTime start = DateTime.Now;

			  SetUpEngineFromPanelGrids(EngineColumns, gridColumns)
			  SetUpMainColumnsGridAndEngines()
			  ResizeColumnHeaders()

			  SetUpEngineFromPanelGrids(EngineRows, gridRows)
			  SetUpMainRowsGridAndEngines()

			  SetUpMainFiltersGridAndApplyFilters()


			engineValues_Renamed.TableDescriptor.GroupedColumns.Clear()
			engineValues_Renamed.TableDescriptor.Summaries.Clear()
			engineValues_Renamed.TableDescriptor.Fields.Clear() 'added

			Dim a As ArrayList = New ArrayList()
			For i As Integer = 2 To gridColumns.RowCount - 1
				a.Add(gridColumns(i, 0).Text)
			Next i
			For i As Integer = 2 To gridRows.RowCount - 1
				a.Add(gridRows(i, 0).Text)
			Next i
			For i As Integer = 2 To gridValues.RowCount - 1
				a.Add(gridValues(i, 0).Text)
			Next i

			'force the loading of the fields
			engineValues_Renamed.TableDescriptor.Fields.LoadDefault()
			'find the ones not being used....
			Dim d As ArrayList = New ArrayList()
			For Each fd As FieldDescriptor In engineValues_Renamed.TableDescriptor.Fields
				If a.IndexOf(fd.Name) = -1 Then
					d.Add(fd.Name)
				End If
			Next fd
			'and delete them.
			For Each s As String In d
				engineValues_Renamed.TableDescriptor.Fields.Remove(s)
			Next s

			'add the value summaries
			Dim name2 As String
			For i As Integer = 2 To gridValues.RowCount - 1
				name2 = gridValues(i, 0).Text
				AddSummaryToEngine(name2, EngineValues)
			Next i
			'now group the value engine - first the columns, then the rows...
			For i As Integer = 2 To gridColumns.RowCount - 1
				engineValues_Renamed.TableDescriptor.GroupedColumns.Add(gridColumns(i, 0).Text)
			Next i

			For i As Integer = 2 To gridRows.RowCount - 1
				engineValues_Renamed.TableDescriptor.GroupedColumns.Add(gridRows(i, 0).Text)
			Next i

			Dim name As String
			For i As Integer = 2 To gridValues.RowCount - 1
				name = gridValues(i, 0).Text
				AddSummaryToEngine(name, EngineColumns)
				AddSummaryToEngine(name, EngineRows)
			Next i


			For i As Integer = 2 To gridFilter.RowCount - 1
				If engineColumns_Renamed.TableDescriptor.Fields.IndexOf(gridFilter(i, 0).Text) = -1 Then
					engineColumns_Renamed.TableDescriptor.Fields.Add(gridFilter(i, 0).Text)
				End If
				If engineRows_Renamed.TableDescriptor.Fields.IndexOf(gridFilter(i, 0).Text) = -1 Then
					engineRows_Renamed.TableDescriptor.Fields.Add(gridFilter(i, 0).Text)
				End If
				If engineValues_Renamed.TableDescriptor.Fields.IndexOf(gridFilter(i, 0).Text) = -1 Then
					engineValues_Renamed.TableDescriptor.Fields.Add(gridFilter(i, 0).Text)
				End If

			Next i
			SetLabelVisibility()

			gridMainDisplay.BeginUpdate()
			gridMainDisplay.ColWidths.ResetRange(leftColBase, gridMainDisplay.ColCount)
			PopulateDisplayGrid()
			If AutoSizeColumns Then
				gridMainDisplay.ColWidths.ResizeToFit(GridRangeInfo.Cells(pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol))
			End If
			gridMainDisplay.EndUpdate()
			gridMainDisplay.Refresh()
			gridMainRows.Refresh()
			gridMainColumns.Refresh()

			Me.Cursor = Cursors.Default

			'if (this.ParentForm != null)
			'{
			'    this.ParentForm.Text = this.ParentForm.Text + " " + string.Format("Layout#{1} time: {0} secs", ((TimeSpan)(DateTime.Now - start)).TotalSeconds, aaaaa++);
			'}
		End Sub


		Public Function InitSchema() As PivotSchema
			Dim schema As PivotSchema = New PivotSchema()
			schema.Fields = New String(gridFields.RowCount - 2 - 1){}
			For i As Integer = 2 To gridFields.RowCount - 1
				   schema.Fields(i - 2) = gridFields(i, 0).Description
			Next i

			schema.RowFields = New String(gridRows.RowCount - 2 - 1){}
			For i As Integer = 2 To gridRows.RowCount - 1
				schema.RowFields(i - 2) = gridRows(i, 0).Text
			Next i

			schema.ColumnFields = New String(gridColumns.RowCount - 2 - 1){}
			For i As Integer = 2 To gridColumns.RowCount - 1
				schema.ColumnFields(i - 2) = gridColumns(i, 0).Text
			Next i

			schema.FilterFields = New String(gridFilter.RowCount - 2 - 1){}
			For i As Integer = 2 To gridFilter.RowCount - 1
				schema.FilterFields(i - 2) = gridFilter(i, 0).Text
			Next i

			schema.FilterValues = New String(gridFilter.RowCount - 2 - 1){}
			For i As Integer = 2 To gridFilter.RowCount - 1
				schema.FilterValues(i - 2) = gridMainFilters(i-1, 1).Text
			Next i

			schema.ValueComputations = TryCast(ValuesComputationInfos.ToArray(GetType(PivotComputationInfo)), PivotComputationInfo() )

			Return schema
		End Function


		#End Region
		#Region "node support for expand and collapse and cache data"

        '<NonSerialized> _
        Private collapsedNodes_Renamed As Hashtable = Nothing
		Private Function GetCellHashKey(ByVal rowIndex As Integer, ByVal colIndex As Integer) As Point
			Return New Point(colIndex, rowIndex)
		End Function

		Public Function CollapsedNodes() As Hashtable
			 If collapsedNodes_Renamed Is Nothing Then
					collapsedNodes_Renamed = New Hashtable()
			 End If
				Return collapsedNodes_Renamed
		End Function

		 Public ReadOnly Property ColumnCount() As Integer
			Get
				Return gridMainDisplay.ColCount
			End Get
		 End Property

		'expand collapse...

		Private Sub gridMainDisplay_PushButtonClick(ByVal sender As Object, ByVal e As GridCellPushButtonClickEventArgs)
			Me.gridMainDisplay.BeginUpdate()
			If e.ColIndex < leftColBase Then
				ClickRow(e.RowIndex, e.ColIndex)
			Else
				ClickCol(e.RowIndex, e.ColIndex)
			End If
			Me.gridMainDisplay.EndUpdate()
			gridMainDisplay.Refresh()
		End Sub

		Private Sub ClickRow(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			If rowIndex >= startGroupRows AndAlso rowIndex <= gridMainDisplay.RowCount Then
				Dim key As Object = GetCellHashKey(rowIndex, colIndex)
				If collapsedNodes_Renamed.ContainsKey(key) Then
					Dim saved As Object() = TryCast(collapsedNodes_Renamed(key), Object())
					Dim sizes As Integer() = TryCast(saved(0), Integer())
					Dim values As String() = TryCast(saved(2), String())
					Dim ranges As GridRangeInfoList = TryCast(saved(1), GridRangeInfoList)

					collapsedNodes_Renamed.Remove(key)
					gridMainDisplay(rowIndex, colIndex).Description = "-"
					Dim range As GridRangeInfo = Me.gridMainDisplay.CoveredRanges.FindRange(rowIndex, colIndex)
					gridMainDisplay.RowHeights.SetRange(rowIndex + 1, rowIndex + sizes.GetLength(0), sizes, True)

					Me.gridMainDisplay.CoveredRanges.Remove(range)
					For Each r As GridRangeInfo In ranges
						Me.gridMainDisplay.CoveredRanges.Add(r)
					Next r

					Dim count As Integer = pivotRightCol + 1
					For n As Integer = colIndex + 1 To count - 1
						RemoveCachedValue(rowIndex, n)
					Next n
				Else
					Dim save As Object() = New Object(2){}
					Dim range As GridRangeInfo = Me.gridMainDisplay.CoveredRanges.FindRange(rowIndex, colIndex)
					Dim newRange As GridRangeInfo = GridRangeInfo.Cells(rowIndex, colIndex, rowIndex + range.Height, rightCol)

					save(0) = gridMainDisplay.RowHeights.GetRange(rowIndex + 1, range.Bottom + Math.Max(summaryCount, 1))
					save(1) = Me.gridMainDisplay.CoveredRanges.Ranges.GetRangesIntersecting(newRange)
					save(2) = New String(summaryCount - 1){}

					'cache the summary values so they are available in QueryCellInfo for the collapsed node
					Dim count As Integer = pivotRightCol + 1

					For n As Integer = colIndex + 1 To count - 1
						CacheValue(rowIndex, n, Me.gridMainDisplay(rowIndex + range.Height, n).Text)
					Next n

					collapsedNodes_Renamed.Add(key, save)
					gridMainDisplay.RowHeights.SetRange(rowIndex + 1, range.Bottom + 1, 0)
					gridMainDisplay(rowIndex, colIndex).Description = "+"
					For Each r As GridRangeInfo In TryCast(save(1), GridRangeInfoList)
						Me.gridMainDisplay.CoveredRanges.Remove(r)
					Next r
					If Not(newRange.Width = 1 AndAlso newRange.Height = 1) Then
						Me.gridMainDisplay.CoveredRanges.Add(newRange)
					End If
				End If
			End If
		End Sub

		Public Sub CollapseAll()
			gridMainDisplay.BeginUpdate()
			'start at bottom and work up...
			For row As Integer = pivotBottomRow To pivotTopRow + numberColumnFields Step -1
				For col As Integer = pivotLeftCol + numberRowFields - 2 To pivotLeftCol Step -1
					Dim style As GridStyleInfo = gridMainDisplay(row, col)
					If style.CellType Is "PivotButtonCell" Then
						Dim key As Object = GetCellHashKey(row, col)
						If (Not collapsedNodes_Renamed.ContainsKey(key)) Then
							ClickRow(row, col)
						End If
					End If
				Next col
			Next row

			For row As Integer = pivotTopRow + numberColumnFields - 1 To pivotTopRow Step -1
				For col As Integer = pivotRightCol To pivotLeftCol + numberRowFields Step -1
					Dim style As GridStyleInfo = gridMainDisplay(row, col)
					If style.CellType Is "PivotButtonCell" Then
						Dim key As Object = GetCellHashKey(row, col)
						If (Not collapsedNodes_Renamed.ContainsKey(key)) Then
							ClickCol(row, col)
						End If
					End If
				Next col
			Next row
			gridMainDisplay.EndUpdate()
			gridMainDisplay.Refresh()
		End Sub

		Public Sub ExpandAll()
			gridMainDisplay.BeginUpdate()
			'start at left and work right...
			'for (int row = pivotTopRow + numberColumnFields; row <= pivotBottomRow; ++row)
			For row As Integer = pivotTopRow + numberColumnFields + 1 To pivotBottomRow - 2
				For col As Integer = pivotLeftCol To pivotLeftCol + numberRowFields - 2
					Dim key As Object = GetCellHashKey(row, col)
					If collapsedNodes_Renamed.ContainsKey(key) Then
						ClickRow(row, col)

					End If
				Next col
			Next row

			'start high and work lower
			For row As Integer = pivotTopRow + 1 To pivotTopRow + numberColumnFields - 1
				For col As Integer = pivotLeftCol + numberRowFields To pivotRightCol
					Dim key As Object = GetCellHashKey(row, col)
					If collapsedNodes_Renamed.ContainsKey(key) Then
						ClickCol(row, col)
					End If

				Next col
			Next row
			gridMainDisplay.EndUpdate()
			gridMainDisplay.Refresh()

			'gridMainDisplay.BeginUpdate();
			'//start at bottom and work up...
			'Point[] keys = new Point[CollapsedNodes.Count];
			'CollapsedNodes.Keys.CopyTo(keys, 0);

			'foreach (Point pt in keys)
			'{
			'    ClickCol(pt.Y, pt.X);
			'    ClickRow(pt.Y, pt.X);
			'}
			'gridMainDisplay.EndUpdate();
			'gridMainDisplay.Refresh();
		End Sub

		Private Sub ClickCol(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			If colIndex >= leftColBase AndAlso colIndex < ColumnCount Then
				Dim key As Object = GetCellHashKey(rowIndex, colIndex)
				If collapsedNodes_Renamed.ContainsKey(key) Then
					Dim saved As Object() = TryCast(collapsedNodes_Renamed(key), Object())
					Dim sizes As Integer() = TryCast(saved(0), Integer())
					Dim values As String() = TryCast(saved(2), String())
					Dim ranges As GridRangeInfoList = TryCast(saved(1), GridRangeInfoList)

					collapsedNodes_Renamed.Remove(key)
					gridMainDisplay(rowIndex, colIndex).Description = "-"
					Dim range As GridRangeInfo = Me.gridMainDisplay.CoveredRanges.FindRange(rowIndex, colIndex)
					gridMainDisplay.ColWidths.SetRange(colIndex + 1, colIndex + sizes.GetLength(0), sizes, True)

					Me.gridMainDisplay.CoveredRanges.Remove(range)
					For Each r As GridRangeInfo In ranges
						Me.gridMainDisplay.CoveredRanges.Add(r)
					Next r

					'remove the cached summary values used in QueryCellInfo
					Dim count As Integer = pivotBottomRow + 1
					For k As Integer = 0 To summaryCount - 1
						For n As Integer = bottomRow + 1 To count - 1
							RemoveCachedValue(n, colIndex + k)
						Next n
					Next k
				Else
					Dim save As Object() = New Object(2){}
					Dim range As GridRangeInfo = Me.gridMainDisplay.CoveredRanges.FindRange(rowIndex, colIndex)
					Dim newRange As GridRangeInfo = GridRangeInfo.Cells(rowIndex, colIndex, Me.bottomRow, colIndex + range.Width + Math.Max(summaryCount, 1) - 1)

					'GridRangeInfo newRange = GridRangeInfo.Cells(e.RowIndex, e.ColIndex, this.bottomRow, e.ColIndex + Math.Max(summaryCount, 1) - 1);

					save(0) = gridMainDisplay.ColWidths.GetRange(colIndex + 1, range.Right + Math.Max(summaryCount, 1))
					save(1) = Me.gridMainDisplay.CoveredRanges.Ranges.GetRangesIntersecting(newRange)
					save(2) = New String(summaryCount - 1){}

					'cache the summary values so they are available in QueryCellInfo for the collapsed node
					Dim count As Integer = pivotBottomRow + 1
					For k As Integer = 0 To summaryCount - 1
						For n As Integer = bottomRow + 1 To count - 1
							CacheValue(n, colIndex + k, Me.gridMainDisplay(n, colIndex + k + range.Width).Text)
						Next n
					Next k

					collapsedNodes_Renamed.Add(key, save)
					gridMainDisplay.ColWidths.SetRange(colIndex + 1, range.Right + 1, 0)
					gridMainDisplay(rowIndex, colIndex).Description = "+"
					For Each r As GridRangeInfo In TryCast(save(1), GridRangeInfoList)
						Me.gridMainDisplay.CoveredRanges.Remove(r)
					Next r
					If Not(newRange.Height = 1 AndAlso newRange.Width = 1) Then
						Me.gridMainDisplay.CoveredRanges.Add(newRange)
					End If
				End If
			End If
		End Sub

		Private cachedValuesForQueryCellInfo As Hashtable = New Hashtable()

		Private Function GetCachedValue(ByVal pt As Point) As String
			Dim a As Stack = TryCast(cachedValuesForQueryCellInfo(pt), Stack)
			Return a.Peek().ToString()
		End Function
		Private Sub RemoveCachedValue(ByVal rowIndex As Integer, ByVal colIndex As Integer)
			Dim pt As Point = GetCellHashKey(rowIndex, colIndex)
			Dim a As Stack = TryCast(cachedValuesForQueryCellInfo(pt), Stack)
			If Not a Is Nothing Then
				a.Pop()
				If a.Count = 0 Then
					cachedValuesForQueryCellInfo.Remove(pt)
				End If
			End If
		End Sub
		Private Sub CacheValue(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal value As String)
			Dim pt As Point = GetCellHashKey(rowIndex, colIndex)
			Dim a As Stack = TryCast(cachedValuesForQueryCellInfo(pt), Stack)
			If a Is Nothing Then
				 a = New Stack()
				cachedValuesForQueryCellInfo.Add(pt, a)
			End If
			a.Push(value)
		End Sub

		Private Function GetColGroup(ByVal rowIndex As Integer, ByVal colIndex As Integer) As Group
			Dim g As Group = engineColumns_Renamed.Table.TopLevelGroup

			For ii As Integer = pivotTopRow + 1 To rowIndex
				Dim range1 As GridRangeInfo = gridMainDisplay.CoveredRanges.FindRange(ii, colIndex)
				Dim iii As Integer
				If range1.IsEmpty Then
					iii = colIndex
				Else
					iii = range1.Left
				End If
				Console.WriteLine("[" & gridMainDisplay(ii, iii).Text & "]")
				g = g.Groups(gridMainDisplay(ii, iii).Text)
			Next ii
			Return g
		End Function


		#End Region

		#Region "update button and checkbox"
		Private Sub buttonUpdate_Click(ByVal sender As Object, ByVal e As EventArgs)
		  '//  DisplayGroupAndSubGroups(engineColumns.Table.TopLevelGroup as Group);
			checkBoxDeferLayout.Checked = False
			LayoutAllGrids()

		End Sub

		'//private int indent = -2;
		'//private void DisplayGroupAndSubGroups(Group g)
		'//{
		'//    indent += 4;
		'//    Console.WriteLine("{0}{1}", new string(' ', indent), (g.Category == null ? g.Name : g.Category.ToString()));

		'//    foreach (Group g1 in g.Groups)
		'//    {
		'//       if (g1.Groups != null)
		'//        {
		'//            DisplayGroupAndSubGroups(g1);
		'//        }
		'//    }
		'//    Console.WriteLine("{0}{1}", new string(' ', indent-2), g.GetSummary(0));
		'//    indent -= 4;
		'//}

		Private Sub checkBoxDeferLayout_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.buttonUpdate.Enabled = Me.checkBoxDeferLayout.Checked
		End Sub
		#End Region

		#Region "layout support"

		Private Const MINHEIGHT As Integer = 180
		Private inSizeChanged As Boolean = False
		Private Sub panelRB_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
			If panelRB.Height < MINHEIGHT Then
				panelRB.Height = MINHEIGHT
			ElseIf (Not inSizeChanged) Then
				inSizeChanged = True
				SizeGridsInLowerRight()
				inSizeChanged = False
			End If
		End Sub

		Public Sub SetLabelVisibility()
			Me.labelColumns.Visible = gridColumns.RowCount <= 2
			Me.labelFilter.Visible = gridFilter.RowCount <= 2
			Me.labelRows.Visible = gridRows.RowCount <= 2
			Me.labelGrid.Visible = gridValues.RowCount <= 2 AndAlso Me.labelRows.Visible AndAlso Me.labelColumns.Visible

		End Sub

		Private leftPanelWidth_Renamed As Integer = 90

		Public Property LeftPanelWidth() As Integer
			Get
				Return leftPanelWidth_Renamed
			End Get
			Set(ByVal value As Integer)
				If leftPanelWidth_Renamed <> value Then
					leftPanelWidth_Renamed = value
					SizePanelsOnLeftSide()
				End If
			End Set
		End Property
		Private leftPanelHeight_Renamed As Integer = 30

		Public Property LeftPanelHeight() As Integer
			Get
				Return leftPanelHeight_Renamed
			End Get
			Set(ByVal value As Integer)
				If leftPanelHeight_Renamed <> value Then
					leftPanelHeight_Renamed = value
					SizePanelsOnLeftSide()
				End If
			End Set
		End Property

		Private Sub SizePanelsOnLeftSide()
			Me.panelFilter.Size = New Size(LeftPanelWidth, LeftPanelHeight)
			Me.panelRows.Location = New Point(0, LeftPanelHeight + 1)
			Me.panelRows.Size = New Size(LeftPanelWidth, Me.panelLeft.Height - LeftPanelHeight - 1)
			Me.panelColumns.Location = New Point(LeftPanelWidth + 1, 0)
			Me.panelColumns.Size = New Size(Me.panelLeft.Width - LeftPanelWidth - 1, LeftPanelHeight)
			Me.panelGrid.Location = New Point(LeftPanelWidth + 1, LeftPanelHeight + 1)
			Me.panelGrid.Size = New Size(Me.panelLeft.Width - LeftPanelWidth - 1, Me.panelLeft.Height - LeftPanelHeight - 1)

			'this grid shares the width
			gridMainRows.ColWidths(0) = LeftPanelWidth
		End Sub

		Private Sub panelLeft_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
			SizePanelsOnLeftSide()
		End Sub

		Private Sub SizeGridsInLowerRight()
            Dim midHeight As Integer = Convert.ToInt32(Me.panelRB.Height / 2)
            Dim midWidth As Integer = Convert.ToInt32(Me.panelRB.Width / 2)
			Dim gridHeight As Integer = midHeight - Me.gridFilter.Top - 10
			Dim gridWidth As Integer = midWidth - Me.gridFilter.Left - 10
			Dim secondRowStart As Integer = midHeight
			Dim secondColStart As Integer = midWidth
			Dim y As Integer = secondRowStart + labelRowLabel.Height + 5
			Dim x As Integer = Me.gridFilter.Location.X ' labelRowLabel.Left;

			Me.gridFilter.Size = New Size(gridWidth, gridHeight)
			Dim offset As Integer = midHeight + Me.labelValues.Height + 5
			Me.gridRows.Size = New Size(gridWidth, gridHeight)
			Me.gridRows.Location = New Point(x, y)

			Me.gridColumns.Size = New Size(gridWidth, gridHeight)
			Me.gridColumns.Location = New Point(midWidth, Me.gridFilter.Top)

			Me.gridValues.Size = New Size(gridWidth, gridHeight)
			Me.gridValues.Location = New Point(midWidth, y)

			pictureBox1.Location = New Point(x, labelReportFilter.Location.Y)
			labelReportFilter.Location = New Point(Me.gridFilter.Location.X + pictureBox1.Width + 2, labelReportFilter.Location.Y)

			pictureBox2.Location = New Point(midWidth, labelColumnLabel.Location.Y)
			Me.labelColumnLabel.Location = New Point(midWidth + pictureBox2.Width + 2, labelColumnLabel.Location.Y)

			pictureBox3.Location = New Point(x, midHeight)
			Me.labelRowLabel.Location = New Point(x + pictureBox3.Width + 2, midHeight)

			pictureBox4.Location = New Point(midWidth, midHeight)
			Me.labelValues.Location = New Point(midWidth + pictureBox4.Width + 2, midHeight)

		  '  this.splitter2.SplitPosition = panelRight.Height / 2;

		End Sub


		#End Region

		#Region "handle click support in values grid to choose Summary"

		''' <summary>
		''' Override to use a derived PivotComputationInfoForm so that you can override the Choices property to provide custom choices.
		''' </summary>
		''' <returns>A CreatePivotComputationInfoForm object.</returns>
		Protected Overridable Function CreatePivotComputationInfoForm() As PivotComputationInfoForm
			Return New PivotComputationInfoForm()
		End Function
		Private Sub gridValues_CellClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			Dim f As PivotComputationInfoForm = CreatePivotComputationInfoForm()
			Dim name As String = gridValues(e.RowIndex, 0).Text


			Dim comp As PivotComputationInfo = ValuesComputationInfos.Find(name)
			Dim loc As Integer = -1
			If comp Is Nothing Then
				Dim info As PivotComputationInfo = f.Choices.Find(DefaultComputationName)
				If Not info Is Nothing Then
					comp = info
					comp.FieldName = name
					comp.Format = "#.##"
					comp.CalculationName = info.CalculationName
				Else
					Throw New ArgumentException("Invalid PivotGridCOntrol.DefaultComputationName")
				End If
			Else
				loc = ValuesComputationInfos.IndexOf(comp)
				ValuesComputationInfos.RemoveAt(loc)
			End If

			f.ComputationInfo = comp
			f.PivotGrid = Me
			f.StartPosition = FormStartPosition.Manual
			Dim pt As Point = Control.MousePosition
			f.Location = New Point(pt.X, pt.Y) 'puts up form with topleft at mouseclick
			'f.Location = new Point( pt.X - f.Width / 2, pt.Y - f.Height / 2); //puts up form centered at mouseclick

			 If f.ShowDialog() = DialogResult.OK Then
				If loc = -1 Then
					ValuesComputationInfos.Add(f.ComputationInfo)
				Else
					ValuesComputationInfos.Insert(loc, f.ComputationInfo)
				End If

				PerformLayout(gridValues, Nothing)

			 End If
		End Sub
		Private valuesComputationInfos_Renamed As PivotComputationInfoList

		Public ReadOnly Property ValuesComputationInfos() As PivotComputationInfoList
			Get
				If valuesComputationInfos_Renamed Is Nothing Then
					valuesComputationInfos_Renamed = New PivotComputationInfoList()
				End If
				Return valuesComputationInfos_Renamed
			End Get
		End Property

		#End Region

		#Region "drag drop support"

		Private ignoreRowMoving As Boolean = False
		Private Sub grid_RowsMoving(ByVal sender As Object, ByVal e As GridRangeMovingEventArgs)
			If ignoreRowMoving Then
				Return
			End If


			Dim sourceGrid As GridList = TryCast(sender, GridList)
			Dim pt As Point = sourceGrid.Parent.PointToClient(Control.MousePosition)
			Dim targetGrid As GridControl = Nothing
			e.Cancel = True
			Dim fieldName As String = ""
			If (Not sourceGrid.Bounds.Contains(pt)) Then
				targetGrid = LocateGrid(sourceGrid.Parent.PointToScreen(pt))
				If Not targetGrid Is Nothing Then
					If sourceGrid.Equals(gridFields) Then
						fieldName = sourceGrid(e.From, 0).Description
					Else
						fieldName = sourceGrid(e.From, 0).Text
					End If
					For i As Integer = 2 To targetGrid.RowCount + 1
						If fieldName = targetGrid(i, 0).Text Then
							Return ' already present
						End If
                    Next i

                    If Not sourceGrid Is gridFields Then
                        sourceGrid.Rows.RemoveRange(e.From, e.From)
                    End If

					If targetGrid Is gridFields Then
						SetCheck(fieldName, False)
					Else
						If sourceGrid Is gridFields AndAlso targetGrid Is gridFilter Then
							' clear the use case...
							Dim location As Integer
							Dim grid As GridList = TryCast(FindField(fieldName, location), GridList)
							If Not grid Is Nothing AndAlso location <> -1 Then
								grid.Rows.RemoveRange(location, location)
								PerformLayout(grid, Nothing)
							End If
                        End If
						targetGrid.Rows.InsertRange(targetGrid.RowCount, 1)
                        targetGrid(targetGrid.RowCount - 1, 0).Text = fieldName
                        SetCheck(fieldName, True)
						If targetGrid Is gridFilter Then
							SetUpMainFiltersGridAndApplyFilters()
						End If
                    End If
                End If
            ElseIf (Not sourceGrid.Equals(gridFields)) Then
                Dim row As Integer = e.Target
                If e.Target < 2 Then
                    row = 2
                ElseIf e.Target > sourceGrid.RowCount - 1 Then
                    row = sourceGrid.RowCount - 1
                End If
                ignoreRowMoving = True
				sourceGrid.Rows.MoveRange(e.From, row)
				ignoreRowMoving = False
			End If
			PerformLayout(sourceGrid, targetGrid)
		End Sub

		Private Sub SetUpEngineFromPanelGrids(ByVal engine As Engine, ByVal grid As GridControl)
			engine.Table.TableDirty = True
			engine.TableDescriptor.Fields.Clear()
			engine.TableDescriptor.GroupedColumns.Clear()
			engine.TableDescriptor.Summaries.Clear()
			For i As Integer = 2 To grid.RowCount - 1
			   ' engine.TableDescriptor.Fields.Add(grid[i, 0].Text);
				AddFieldToEngine(engine, grid(i, 0).Text)
			Next i
		End Sub

        Private Sub SetUpMainColumnsGridAndEngines()
            If gridColumns.RowCount > 0 Then
                gridMainColumns.ColCount = gridColumns.RowCount - 2
            End If

            gridMainColumns.Model.ColWidths(0) = 0
            gridMainColumns.RowCount = 0

            For i As Integer = 2 To gridColumns.RowCount - 1
                AddFieldToEngine(engineRows_Renamed, gridColumns(i, 0).Text)
                gridMainColumns(0, i - 1).Text = gridColumns(i, 0).Text
            Next i

            For i As Integer = 2 To gridValues.RowCount - 1
                AddSummaryToEngine(gridValues(i, 0).Text, EngineColumns)
            Next i

            gridMainColumns.ColWidths(0) = 0

            For i As Integer = 2 To gridColumns.RowCount - 1
                If Not engineColumns_Renamed.TableDescriptor.GroupedColumns.Contains(gridColumns(i, 0).Text) Then
                    engineColumns_Renamed.TableDescriptor.GroupedColumns.Add(gridColumns(i, 0).Text)
                End If
            Next i
            SetLabelVisibility()
        End Sub

		Private Function GetSummaryType(ByVal info As PivotComputationInfo) As SummaryType
			'assume DoubleAggregate
			Dim st As SummaryType = SummaryType.DoubleAggregate
			Select Case info.CalculationName
				Case "StdDev", "StdDevP", "Var", "VarP"
					st = SummaryType.Custom
				Case "Count"
					st = SummaryType.Count
				Case "Median", "Percentile25", "Percentile75"
					st = SummaryType.DoubleVector
				Case Else
			End Select

			Return st
		End Function

		Private defaultDescriptionFormat_Renamed As String = "{0} of {1}" '0=ComputationName and 1=FieldName

		Public Property DefaultDescriptionFormat() As String
			Get
				Return defaultDescriptionFormat_Renamed
			End Get
			Set(ByVal value As String)
				defaultDescriptionFormat_Renamed = value
			End Set
		End Property


		Private defaultComputationName_Renamed As String = "Sum"

		Public Property DefaultComputationName() As String
			Get
				Return defaultComputationName_Renamed
			End Get
			Set(ByVal value As String)
				defaultComputationName_Renamed = value
			End Set
		End Property
		Private Sub AddSummaryToEngine(ByVal fieldName As String, ByVal engine As Engine)
			Dim info As PivotComputationInfo = ValuesComputationInfos.Find(fieldName)
			If info Is Nothing Then
				Dim computationName As String = DefaultComputationName 'default computation
				Dim fd As FieldDescriptor = EngineValues.TableDescriptor.Fields(fieldName)
				If Not fd Is Nothing AndAlso fd.FieldPropertyType Is GetType(String) Then
					computationName = "Count"
				End If

				Dim sum As SummaryBase = PivotComputationInfoList.CreateSummary(computationName) ' new DoubleAggregateSummary(0, double.MaxValue, double.MinValue, 0d);
				info = New PivotComputationInfo(sum, computationName, String.Format(DefaultDescriptionFormat, computationName, fieldName), fieldName)
				ValuesComputationInfos.Add(info)
			End If

			If engine.TableDescriptor.Fields.IndexOf(fieldName) = -1 Then
			   ' engine.TableDescriptor.Fields.Add(fieldName);
				AddFieldToEngine(engine, fieldName)
			End If

			Dim st As SummaryType = GetSummaryType(info)
			Dim sd As SummaryDescriptor = New SummaryDescriptor(fieldName & " " & info.CalculationName, fieldName, st)
			If st = SummaryType.Custom Then
				sd.CreateSummaryMethod = New CreateSummaryDelegate(AddressOf DoubleStdDevSummary.CreateSummaryMethod)
			End If

			engine.TableDescriptor.Summaries.Add(sd)

		End Sub

		Private Const FILTERPAD As Integer = 4 'On the left side grids, the distance between bottom of filter grid and top of the row grid
        Private Sub SetUpMainFiltersGridAndApplyFilters()
            If gridFilter.RowCount > 0 Then
                gridMainFilters.RowCount = gridFilter.RowCount - 2
                gridMainFilters.Model.RowHeights(0) = 0
                gridMainFilters.ColCount = 1
                gridMainFilters.ColStyles(1).CellType = "ComboBox"
            End If
            'populate the dropdowns
            Dim name As String
            For i As Integer = 2 To gridFilter.RowCount - 1
                name = gridFilter(i, 0).Text
                gridMainFilters(i - 1, 1).DataSource = CreateUniqueEntries(name)
                If Not EngineValues.TableDescriptor.RecordFilters.Contains(name) Then
                    gridMainFilters(i - 1, 1).Text = ""
                End If
                gridMainFilters(i - 1, 0).Text = name & ":"
            Next i

            gridMainFilters.BaseStylesMap("Row Header").StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right
            gridMainFilters.HScrollBehavior = GridScrollbarMode.Disabled
            gridMainFilters.VScrollBehavior = GridScrollbarMode.Disabled
            gridMainFilters.HScroll = False
            gridMainFilters.VScroll = False
            If gridFilter.RowCount - 2 > 0 Then
                gridMainFilters.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 0, gridFilter.RowCount - 2, 0))
            End If
            gridMainFilters.ResetVolatileData()


            gridMainFilters.RowHeights(0) = 0

            'need to set height of gridMainFilter....
            If gridFilter.RowCount - 2 > 0 Then
                LeftPanelHeight = Math.Max(gridMainColumns.RowHeights(0), FILTERPAD + gridMainFilters.RowHeights.GetTotal(0, gridMainFilters.RowCount))
                LeftPanelWidth = gridMainFilters.ColWidths.GetTotal(0, gridMainFilters.ColCount)
            End If
            gridMainFilters.HScrollBehavior = GridScrollbarMode.Disabled
            gridMainFilters.HScroll = False
            SetLabelVisibility()
        End Sub

        Private Sub SetUpMainRowsGridAndEngines()
            If gridRows.RowCount > 0 Then
                gridMainRows.RowCount = gridRows.RowCount - 2
            End If
            ' gridMainRows.Model.RowHeights[0] = 0;
            gridMainRows.ColCount = 0
            gridMainRows.ColWidths(0) = LeftPanelWidth
            gridMainRows.ResetVolatileData()

            For i As Integer = 2 To gridColumns.RowCount - 1
                AddFieldToEngine(engineRows_Renamed, gridColumns(i, 0).Text)
            Next i
            For i As Integer = 2 To gridRows.RowCount - 1
                gridMainRows(i - 1, 0).Text = gridRows(i, 0).Text
            Next i

            gridMainRows.DefaultRowHeight = gridMainColumns.RowHeights(0)
            gridMainRows.RowHeights(0) = 0

            For i As Integer = 2 To gridValues.RowCount - 1
                AddSummaryToEngine(gridValues(i, 0).Text, EngineRows)
            Next i

            engineRows_Renamed.TableDescriptor.GroupedColumns.Clear()
            For i As Integer = 2 To gridRows.RowCount - 1
                If Not engineRows_Renamed.TableDescriptor.GroupedColumns.Contains(gridRows(i, 0).Text) Then
                    engineRows_Renamed.TableDescriptor.GroupedColumns.Add(gridRows(i, 0).Text)
                End If
            Next i
            SetLabelVisibility()
        End Sub

		Private Overloads Sub PerformLayout(ByVal sourceGrid As GridList, ByVal targetGrid As GridControl)
		  '  DateTime start = DateTime.Now;
			Me.Cursor = Cursors.WaitCursor

			'check if layout should be deferred..
			If checkBoxDeferLayout.Checked Then
				Dim name1 As String
				For i As Integer = 2 To gridValues.RowCount - 1
					name1 = gridValues(i, 0).Text
					AddSummaryToEngine(name1, EngineValues)
				Next i
				Return
			End If

			'first remove the field if the source != target and != gridFields
			  If sourceGrid.Equals(gridColumns) Then
					SetUpEngineFromPanelGrids(EngineColumns, gridColumns)
					SetUpMainColumnsGridAndEngines()
					ResizeColumnHeaders()
				ElseIf sourceGrid.Equals(gridRows) Then
					SetUpEngineFromPanelGrids(EngineRows, gridRows)
					SetUpMainRowsGridAndEngines()
				End If



			'first check to see if need to make a change because the columns (gridColumns) were modified
			If (Not sourceGrid.Equals(gridColumns)) AndAlso (Not targetGrid Is Nothing AndAlso targetGrid.Equals(gridColumns)) Then
				SetUpEngineFromPanelGrids(EngineColumns, gridColumns)
				SetUpMainColumnsGridAndEngines()
				ResizeColumnHeaders()
			'now check to see if need to make a change because the rows (gridRows) were modified
			ElseIf (Not sourceGrid.Equals(gridRows)) AndAlso (Not targetGrid Is Nothing AndAlso targetGrid.Equals(gridRows)) Then
				SetUpEngineFromPanelGrids(EngineRows, gridRows)
				SetUpMainRowsGridAndEngines()
			'now check to see if need to make a change because the filters (gridFilters) were modified
			ElseIf (Not sourceGrid.Equals(gridFilter)) AndAlso (Not targetGrid Is Nothing AndAlso targetGrid.Equals(gridFilter)) Then
				 SetUpMainFiltersGridAndApplyFilters()
			End If


			engineColumns_Renamed.TableDescriptor.Summaries.Clear()
			engineRows_Renamed.TableDescriptor.Summaries.Clear()
			engineValues_Renamed.TableDescriptor.GroupedColumns.Clear()
			engineValues_Renamed.TableDescriptor.Summaries.Clear()
            engineValues_Renamed.TableDescriptor.Fields.Clear() 'added          

            'setup value engine - add the columns fields first, then add the row fields
            'colect the fields that are used...
            Dim a As ArrayList = New ArrayList()
            For i As Integer = 2 To gridColumns.RowCount - 1
                a.Add(gridColumns(i, 0).Text)
            Next i
            For i As Integer = 2 To gridRows.RowCount - 1
                'engineValues.TableDescriptor.Fields.Add(gridRows[i, 0].Text);
                a.Add(gridRows(i, 0).Text)
            Next i
            For i As Integer = 2 To gridValues.RowCount - 1
                'engineValues.TableDescriptor.Fields.Add(gridValues[i, 0].Text);
                a.Add(gridValues(i, 0).Text)
            Next i

            'force the loading of the fields
            engineValues_Renamed.TableDescriptor.Fields.LoadDefault()
            'find the ones not being used....
            Dim d As ArrayList = New ArrayList()
            For Each fd As FieldDescriptor In engineValues_Renamed.TableDescriptor.Fields
                If a.IndexOf(fd.Name) = -1 Then
                    d.Add(fd.Name)
                End If
            Next fd
            'and delete them.
            For Each s As String In d
                engineValues_Renamed.TableDescriptor.Fields.Remove(s)
            Next s

            engineValues_Renamed.TableDescriptor.GroupedColumns.Clear()
            engineValues_Renamed.TableDescriptor.Summaries.Clear()

            'add the value summaries
            Dim name2 As String
            For i As Integer = 2 To gridValues.RowCount - 1
                name2 = gridValues(i, 0).Text
                AddSummaryToEngine(name2, EngineValues)
            Next i
            'now group the value engine - first the columns, then the rows...
            For i As Integer = 2 To gridColumns.RowCount - 1
                engineValues_Renamed.TableDescriptor.GroupedColumns.Add(gridColumns(i, 0).Text)
            Next i

            For i As Integer = 2 To gridRows.RowCount - 1
                engineValues_Renamed.TableDescriptor.GroupedColumns.Add(gridRows(i, 0).Text)
            Next i

            '			#End Region

            Dim name As String
            For i As Integer = 2 To gridValues.RowCount - 1
                name = gridValues(i, 0).Text
                AddSummaryToEngine(name, EngineColumns)
                AddSummaryToEngine(name, EngineRows)
            Next i


            For i As Integer = 2 To gridFilter.RowCount - 1
                If engineColumns_Renamed.TableDescriptor.Fields.IndexOf(gridFilter(i, 0).Text) = -1 Then
                    engineColumns_Renamed.TableDescriptor.Fields.Add(gridFilter(i, 0).Text)
                End If
                If engineRows_Renamed.TableDescriptor.Fields.IndexOf(gridFilter(i, 0).Text) = -1 Then
                    engineRows_Renamed.TableDescriptor.Fields.Add(gridFilter(i, 0).Text)
                End If
                If engineValues_Renamed.TableDescriptor.Fields.IndexOf(gridFilter(i, 0).Text) = -1 Then
                    engineValues_Renamed.TableDescriptor.Fields.Add(gridFilter(i, 0).Text)
                End If

            Next i

            If sourceGrid.Equals(gridValues) OrElse (targetGrid IsNot Nothing AndAlso targetGrid.Equals(gridValues)) Then
                For i As Integer = 2 To gridValues.RowCount - 1
                    Dim comp As PivotComputationInfo = ValuesComputationInfos.Find(gridValues(i, 0).Text)
                    Dim loc As Integer = ValuesComputationInfos.IndexOf(comp)
                    If loc <> -1 Then
                        If loc <> i - 2 Then
                            ValuesComputationInfos.RemoveAt(loc)
                            ValuesComputationInfos.Insert(i - 2, comp)
                        End If
                    End If
                Next i
            End If

            SetLabelVisibility()

            gridMainDisplay.BeginUpdate()

            'reset so no left over rows are seen...
            gridMainDisplay.RowCount = 2

            gridMainDisplay.ColWidths.ResetRange(leftColBase, gridMainDisplay.ColCount)
            PopulateDisplayGrid()
            If AutoSizeColumns Then
                gridMainDisplay.ColWidths.ResizeToFit(GridRangeInfo.Cells(pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol))
            End If
            gridMainDisplay.EndUpdate()
            gridMainDisplay.Refresh()
            gridMainRows.Refresh()
            gridMainColumns.Refresh()

            Me.Cursor = Cursors.Default

            'if (this.ParentForm != null)
            '{
            '    this.ParentForm.Text = this.ParentForm.Text + " " + string.Format("Layout#{1} time: {0} secs", ((TimeSpan)(DateTime.Now - start)).TotalSeconds, aaaaa++);
            '}
        End Sub
	  '  private int aaaaa = 0;

		Private Sub ResizeColumnHeaders()
			gridMainColumns.ColWidths.ResizeToFit(GridRangeInfo.Cells(0, 1, 0, gridMainColumns.ColCount), GridResizeToFitOptions.IncludeHeaders)
			For i As Integer = 1 To gridMainColumns.ColCount
				gridMainColumns.ColWidths(i) = gridMainColumns.ColWidths(i) + 24 'icon width
			Next i
		End Sub


		Private Sub AddFieldToEngine(ByVal engine As Engine, ByVal fieldName As String)
			If engine.TableDescriptor.Fields.IndexOf(fieldName) = -1 Then
				Dim typedList As ITypedList = TryCast(list, ITypedList)
				Dim pd As PropertyDescriptor = typedList.GetItemProperties(Nothing)(fieldName)
				If Not pd Is Nothing Then
					Dim fd As FieldDescriptor = New FieldDescriptor(fieldName, pd.PropertyType)
					engine.TableDescriptor.Fields.Add(fd)
				End If
			End If
		End Sub


		Private Function CreateUniqueEntries(ByVal fieldName As String) As IList
			Dim entries As ArrayList = New ArrayList()
			Dim typedList As ITypedList = TryCast(list, ITypedList)
			Dim pd As PropertyDescriptor = typedList.GetItemProperties(Nothing)(fieldName)
			If Not pd Is Nothing Then
				For Each o As Object In list
					Dim s As String = pd.GetValue(o).ToString()
					Dim i As Integer = entries.BinarySearch(s)
					If i < 0 Then
						entries.Insert(-i - 1, s)
					End If
				Next o
			End If
			entries.Insert(0, AllString)
			Return entries
		End Function

		Private startGroupColumns As Integer
		Public Sub UpdateValues()
			Dim keys As Point() = New Point(collapsedNodes_Renamed.Keys.Count - 1){}
			collapsedNodes_Renamed.Keys.CopyTo(keys, 0)

			gridMainDisplay.BeginUpdate()
			ExpandAll()
			PopulateDisplayGrid()

			For Each key As Point In keys
				If key.Y <= numberColumnFields Then
					ClickCol(key.Y, key.X)
				ElseIf key.X < numberRowFields Then
					ClickRow(key.Y, key.X)
				End If
			Next key
			gridMainDisplay.EndUpdate()

			gridMainDisplay.Refresh()

		End Sub


		Private recurLevel As Integer = 0
		Private bottomRow As Integer = 0
		Private rightCol As Integer = 0
        Private summaryCount As Integer = 0

        Private Function CheckFilter(ByVal group As Group) As Boolean
            For i As Integer = 2 To gridFilter.RowCount
                If gridFilter(i, 0).Text = group.Name Then
                    For k As Integer = 1 To gridMainFilters.RowCount
                        Dim Name As String = gridMainFilters(k, 0).Text.Substring(0, gridMainFilters(k, 0).Text.Length - 1)
                        If Name = group.Name Then
                            Dim filter As Boolean = True
                            If engineValues.TableDescriptor.RecordFilters.IndexOf(Name) = -1 AndAlso engineValues.TableDescriptor.RecordFilters.IndexOf(Name) = -1 AndAlso engineColumns.TableDescriptor.RecordFilters.IndexOf(Name) = -1 AndAlso engineRows.TableDescriptor.RecordFilters.IndexOf(Name) = -1 Then
                                filter = False
                            End If
                            Dim value As String = gridMainFilters(k, 1).Text
                            If filter AndAlso (Not value.Contains(group.Category.ToString())) Then
                                Return True
                            End If
                        End If
                    Next k
                End If
            Next i
            Return False
        End Function

		Private Function AddGroupRowsToGrid(ByVal rowIndex As Integer, ByVal parentGroup As Group, ByVal colIndex As Integer) As Integer
			If recurLevel = 0 Then
				rightCol = colIndex
			End If

			recurLevel += 1

			For Each g As Group In parentGroup.Groups
				If Not g.Groups Is Nothing AndAlso g.Groups.Count > 0 Then
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().RowExpandCell, StyleModifyType.Override)
					gridMainDisplay(rowIndex, colIndex).Text = g.Category.ToString()
					Dim top As Integer = rowIndex
					gridMainDisplay(rowIndex, colIndex).CellType = "PivotButtonCell"
					gridMainDisplay(rowIndex, colIndex).Description = "-"
					rowIndex = AddGroupRowsToGrid(rowIndex, g, colIndex + 1)

					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override)
					DisplayRowSummaryItems(rowIndex, colIndex, g, g.Category.ToString() & " Total")
					Dim w As Integer = Math.Max(summaryCount, 1) - 1
					If Not(top = rowIndex-1) Then
                        gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(top, colIndex, rowIndex - 1, colIndex))
                        If CheckFilter(g) Then
                            Me.gridMainDisplay.HideRows.SetRange(top, rowIndex - 1, True)
                        End If
                        Me.gridMainDisplay.HideRows(rowIndex) = CheckFilter(g)
					End If
					If Not(colIndex = rightCol) Then
								 gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, rightCol))
					End If
					rowIndex = rowIndex + 1
				Else
					rightCol = colIndex
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().RowCell, StyleModifyType.Override)
                    DisplayRowSummaryItems(rowIndex, colIndex, g, g.Category.ToString())
                    Me.gridMainDisplay.HideRows(rowIndex) = CheckFilter(g)
					rowIndex = rowIndex + 1
				End If

			Next g
			recurLevel -= 1
			If recurLevel = 0 Then
				EnsureRowCount(rowIndex)
				gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override)
				DisplayRowSummaryItems(rowIndex, colIndex, engineRows_Renamed.Table.TopLevelGroup, GrandTotalString)
				If Not(colIndex = rightCol) Then
						 gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, rightCol))
				End If
				If summaryCount > 1 Then
					Dim col As Integer = rightCol + 1
					Do While col + summaryCount - 1 <= pivotRightCol
						For k As Integer = 0 To summaryCount - 1
							gridMainDisplay(startGroupRows - 1, col).ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override)
							gridMainDisplay(startGroupRows - 1, col).Text = ValuesComputationInfos(k).Description
							col += 1
						Next k
					Loop
				ElseIf summaryCount = 1 Then
					If numberColumnFields = 0 Then
					  gridMainDisplay(startGroupRows - 2, pivotLeftCol).ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override)
					  gridMainDisplay(startGroupRows - 1, rightCol + 1).ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override)

						gridMainDisplay(startGroupRows - 2, pivotLeftCol).Text = ValuesComputationInfos(0).Description
						gridMainDisplay(startGroupRows - 1, rightCol + 1).Text = TotalString
					End If
					'else
					'{
					'    gridMainDisplay[startGroupRows - 1, rightCol + 1].ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override);
					'    gridMainDisplay[startGroupRows - 1, rightCol + 1].BackColor = Color.Yellow;
					'     gridMainDisplay[startGroupRows - 1, rightCol + 1].Text = TotalString;
					'}

				End If

			End If
			Return rowIndex


		End Function

		Private Sub EnsureRowCount(ByVal rowIndex As Integer)
			If rowIndex + summaryCount > gridMainDisplay.RowCount Then
				gridMainDisplay.RowCount = rowIndex + summaryCount
			End If
		End Sub

		Private Function AddGroupColumnsToGrid(ByVal rowIndex As Integer, ByVal parentGroup As Group, ByVal colIndex As Integer) As Integer
			Return AddGroupColumnsToGrid(rowIndex, parentGroup, colIndex, True)
		End Function

		Private Function AddGroupColumnsToGrid(ByVal rowIndex As Integer, ByVal parentGroup As Group, ByVal colIndex As Integer, ByVal setCovededCells As Boolean) As Integer
			If recurLevel = 0 Then

				colIndex = leftColBase
				bottomRow = rowIndex
			End If

			recurLevel += 1

			For Each g As Group In parentGroup.Groups

				If Not g.Groups Is Nothing AndAlso g.Groups.Count > 0 Then
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().ColumnExpandCell, StyleModifyType.Override)
					gridMainDisplay(rowIndex, colIndex).Text = g.Category.ToString()
					Dim left As Integer = colIndex
					gridMainDisplay(rowIndex, colIndex).CellType = "PivotButtonCell"
					gridMainDisplay(rowIndex, colIndex).Description = "-"
					colIndex = AddGroupColumnsToGrid(rowIndex + 1, g, colIndex)

					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().ColumnTotalCell, StyleModifyType.Override)
					DisplayColumnSummaryItems(rowIndex, colIndex, g, g.Category.ToString() & " " & TotalString)
					If setCovededCells Then
						Dim w As Integer = Math.Max(summaryCount, 1) - 1
						If Not(left = colIndex - 1) Then
                            gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, left, rowIndex, colIndex - 1))
                            If CheckFilter(g) Then
                                Me.gridMainDisplay.HideCols.SetRange(left, colIndex - 1, True)
                            End If
						End If
						If Not(rowIndex = bottomRow AndAlso w = 0) Then
							gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, bottomRow, colIndex + w))
						End If
                    End If
                    Me.gridMainDisplay.HideCols(colIndex) = CheckFilter(g)
					colIndex = colIndex + Math.Max(1, gridValues.RowCount - 2)
				Else
				  '  EnsureColumnCount(colIndex);
					bottomRow = rowIndex
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().ColumnCell, StyleModifyType.Override)

					DisplayColumnSummaryItems(rowIndex, colIndex, g, g.Category.ToString())
					If summaryCount > 1 Then
						If setCovededCells Then
							gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + summaryCount - 1))
						End If
                    End If
                    Me.gridMainDisplay.HideCols(colIndex) = CheckFilter(g)
					colIndex = colIndex + Math.Max(1, summaryCount)
				End If

			Next g
			recurLevel -= 1
			If recurLevel = 0 AndAlso setCovededCells Then
			   ' EnsureColumnCount(colIndex);

				If numberColumnFields > 0 Then
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().ColumnTotalCell, StyleModifyType.Override)

					DisplayColumnSummaryItems(rowIndex, colIndex, engineColumns_Renamed.Table.TopLevelGroup, GrandTotalString)
				End If
				If setCovededCells Then
					Dim w As Integer = Math.Max(summaryCount, 1) - 1
					If Not(rowIndex = bottomRow AndAlso w = 0) Then
						gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, bottomRow, colIndex + w))
					End If
				End If
				If summaryCount = 1 Then
					If numberRowFields > 1 Then
						gridMainDisplay(rowIndex - 1, leftColBase - 2).ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override)

						gridMainDisplay(rowIndex - 1, leftColBase - 2).Text = ValuesComputationInfos(0).Description

					Else

						gridMainDisplay(rowIndex - 1, leftColBase - 1).ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override)

						'if (numberRowFields == 0)
						'{
						'    gridMainDisplay[rowIndex - 1, leftColBase - 1].Text = ValuesComputationInfos[0].Description;
						'}
						'else
						'{
							gridMainDisplay(rowIndex - 1, leftColBase - 1).Text = ValuesComputationInfos(0).Description
						'}

					End If

				ElseIf summaryCount > 1 Then
					gridMainDisplay(rowIndex, leftColBase - 1).Text = ""

					If numberRowFields = 0 Then
						If setCovededCells Then
							If Not(rowIndex - 1 = pivotSummaryRowBase + 1 AndAlso pivotLeftCol <> leftColBase - 1) Then
								gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, pivotLeftCol, pivotSummaryRowBase + 1, leftColBase - 1))
							End If
						End If

						gridMainDisplay(pivotSummaryRowBase + 2, leftColBase - 1).ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override)
						gridMainDisplay(pivotSummaryRowBase + 2, leftColBase - 1).Text = TotalString


						Dim col As Integer = rightCol + 1
						Do While col + summaryCount - 1 <= pivotRightCol
							For k As Integer = 0 To summaryCount - 1
								gridMainDisplay(startGroupRows, col).ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override)
								gridMainDisplay(startGroupRows, col).Text = ValuesComputationInfos(k).Description
								col += 1
							Next k
						Loop
					Else
						If setCovededCells Then
							If Not(rowIndex - 1 = pivotSummaryRowBase + 1 AndAlso pivotLeftCol <> leftColBase - 1) Then
								gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, pivotLeftCol, rowIndex + numberColumnFields - 1, leftColBase - 1))
							End If
						End If

					End If

				End If

                If setCovededCells Then
                    Dim h As Integer
                    If (numberRowFields > 0) Then
                        If numberValueFields > 1 Then
                            h = Math.Max(0, numberColumnFields - 1) + (1) + (1)
                        Else
                            h = Math.Max(0, numberColumnFields - 1) + (1) + (0)
                        End If
                    Else
                        If numberValueFields > 1 Then
                            h = Math.Max(0, numberColumnFields - 1) + (0) + (1)
                        Else
                            h = Math.Max(0, numberColumnFields - 1) + (0) + (0)
                        End If
                    End If
                    Dim w As Integer = Math.Max(0, numberRowFields - 1)
                    If h > 0 OrElse w > 0 Then
                        Dim range As GridRangeInfo = gridMainDisplay.CoveredRanges.FindRange(pivotTopRow, pivotLeftCol)
                        If (Not range.IsEmpty) Then
                            gridMainDisplay.CoveredRanges.Remove(range)
                        End If
                        range = GridRangeInfo.Cells(pivotTopRow, pivotLeftCol, pivotTopRow + h, pivotLeftCol + w)
                        gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(pivotTopRow, pivotLeftCol, pivotTopRow + h, pivotLeftCol + w))
                        '      gridMainDisplay.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex - 1, leftColBase - 1, bottomRow, leftColBase - 1 + numberRowFields - 1));
                    End If
                end if

				gridMainDisplay(pivotTopRow, pivotLeftCol).ModifyStyle(GetAppearance().TopLeftCell, StyleModifyType.Override)
				gridMainDisplay.RowHeights(pivotTopRow) = 0
			End If
			Return colIndex

		End Function

		Private Sub EnsureColumnCount(ByVal colIndex As Integer)
			If colIndex + summaryCount > gridMainDisplay.ColCount Then
				gridMainDisplay.ColCount = colIndex + summaryCount
			End If
		End Sub

		Private Sub DisplayRowSummaryItems(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal g As Group, ByVal s As String)
			If summaryCount > 0 Then
				EnsureRowCount(rowIndex)

				If s.EndsWith(TotalString) Then
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override)
				Else
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().RowCell, StyleModifyType.Override)

				End If

				gridMainDisplay(rowIndex, colIndex).Text = s
				For k As Integer = 0 To summaryCount - 1
					Dim temp As String = gridValues(2 + k, 0).Text
					Dim summaries As Syncfusion.Collections.BinaryTree.ITreeTableSummary() = g.GetSummaries(engineColumns_Renamed.Table)
					Dim summary As Syncfusion.Collections.BinaryTree.ITreeTableSummary = summaries(k)
					Dim info As PivotComputationInfo = ValuesComputationInfos.Find(gridValues(2 + k, 0).Text)
					Dim fmt As String = "{0:" & info.Format & "}"
					If Not info Is Nothing Then
						If numberRowFields > 0 AndAlso numberColumnFields > 0 Then
							Dim o As Object =GetAppearance().ValueCell
							gridMainDisplay(rowIndex, pivotSummaryColBase + k).ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override)

							gridMainDisplay(rowIndex, pivotSummaryColBase + k).Text = String.Format(fmt, info.Pd.GetValue(summary)) 'info.Pd.GetValue(summary).ToString(info.Format); //** + 1
						Else
							gridMainDisplay(rowIndex, pivotSummaryColBase + k + 1).ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override)
							'  gridMainDisplay[rowIndex, pivotSummaryColBase + k + 1].Text = "h" + string.Format(fmt, info.Pd.GetValue(summary)); //info.Pd.GetValue(summary).ToString(info.Format); //** + 1
							gridMainDisplay(rowIndex, pivotSummaryColBase + k + 1).Text = String.Format(fmt, info.Pd.GetValue(summary)) 'info.Pd.GetValue(summary).ToString(info.Format); //** + 1
						End If
					End If
				Next k
			Else
				EnsureRowCount(rowIndex)
				If s.EndsWith(TotalString) Then
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().RowTotalCell, StyleModifyType.Override)
				Else
					'gridMainDisplay[rowIndex, colIndex].ModifyStyle(GetAppearance().CalculationNameCell, StyleModifyType.Override);
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().RowCell, StyleModifyType.Override)
				End If

				gridMainDisplay(rowIndex, colIndex).Text = s
			End If
		End Sub
		Private Sub DisplayColumnSummaryItems(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal g As Group, ByVal s As String)
			If summaryCount > 0 Then
				For k As Integer = 0 To summaryCount - 1
					If s.EndsWith(TotalString) Then
						gridMainDisplay(rowIndex, colIndex + k).ModifyStyle(GetAppearance().ColumnTotalCell, StyleModifyType.Override)
					Else
						gridMainDisplay(rowIndex, colIndex + k).ModifyStyle(GetAppearance().ColumnCell, StyleModifyType.Override)
					End If

					gridMainDisplay(rowIndex, colIndex + k).Text = s

					Dim summaries As Syncfusion.Collections.BinaryTree.ITreeTableSummary() = g.GetSummaries(engineColumns_Renamed.Table)
					Dim summary As Syncfusion.Collections.BinaryTree.ITreeTableSummary = summaries(k)
					Dim info As PivotComputationInfo = ValuesComputationInfos.Find(gridValues(2 + k, 0).Text)
					Dim fmt As String = "{0:" & info.Format & "}"
					If Not info Is Nothing Then
						If summaryCount > 1 Then
							If numberColumnFields > 0 AndAlso numberRowFields > 0 Then
								gridMainDisplay(pivotSummaryRowBase + 1, colIndex + k).ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override)
								gridMainDisplay(pivotSummaryRowBase + 1, colIndex + k).Text = String.Format(fmt, info.Pd.GetValue(summary))
							Else
								gridMainDisplay(pivotSummaryRowBase + 2, colIndex + k).ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override)
								gridMainDisplay(pivotSummaryRowBase + 2, colIndex + k).Text = String.Format(fmt, info.Pd.GetValue(summary))
							End If
							'if (summaryCount == 1)
							'{
							'    gridMainDisplay[pivotSummaryRowBase + 1, colIndex + k].ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override);
							'    gridMainDisplay[pivotSummaryRowBase + 1, colIndex + k].Text = info.Description;

							'}
						Else
							If numberValueFields = 0 OrElse numberRowFields = 0 Then '**
								gridMainDisplay(pivotSummaryRowBase + 1, colIndex + k).ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override)
								gridMainDisplay(pivotSummaryRowBase + 1, colIndex + k).Text = String.Format(fmt, info.Pd.GetValue(summary)) 'info.Pd.GetValue(summary).ToString(info.Format);
							Else
								gridMainDisplay(pivotSummaryRowBase, colIndex + k).ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override)
								gridMainDisplay(pivotSummaryRowBase, colIndex + k).Text = String.Format(fmt, info.Pd.GetValue(summary)) 'info.Pd.GetValue(summary).ToString(info.Format); ;
							End If
						End If
					End If
				Next k
			Else
				If s.EndsWith(TotalString) Then
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().ColumnTotalCell, StyleModifyType.Override)
				Else
					gridMainDisplay(rowIndex, colIndex).ModifyStyle(GetAppearance().ColumnCell, StyleModifyType.Override)
				End If
				gridMainDisplay(rowIndex, colIndex).Text = s
			End If
		End Sub


		Private Function GetCount(ByVal parentGroup As Group, ByVal count As Integer, ByVal isRow As Boolean) As Integer
			For Each g As Group In parentGroup.Groups
				If Not g.Groups Is Nothing AndAlso g.Groups.Count > 0 Then
					count = GetCount(g, count, isRow)
					If isRow Then
						count = count + (1)
					Else
						count = count + (Math.Max(1, gridValues.RowCount - 2))
					End If
				Else
					If isRow Then
						count = count + (1)
					Else
						count = count + (Math.Max(1, summaryCount))
					End If
				End If
			Next g
		   Return count
		End Function


		Private pivotTopRow As Integer = 1
		Private pivotLeftCol As Integer = 1
		Private pivotBottomRow As Integer = 1
		Private pivotRightCol As Integer = 1

		Private pivotSummaryRowBase As Integer = 1
		Private pivotSummaryColBase As Integer = 1

		Private numberColumnFields As Integer = 0
		Private numberRowFields As Integer = 0
		Private numberValueFields As Integer = 0
		Private numberFiltersFields As Integer = 0


		Private leftColBase As Integer = 2




		Private startGroupRows As Integer
   '     private int[] periods = null;
		Private numberRows As Integer


		Private Sub PopulateDisplayGrid()
			'Set up all the counts

			'number of items
			numberColumnFields = gridColumns.RowCount - 2
			numberRowFields = gridRows.RowCount - 2
			numberValueFields = gridValues.RowCount - 2
			numberFiltersFields = gridFilter.RowCount - 1

			Me.summaryCount = numberValueFields

			'gets the number of interior rows/cols
			Dim numberColumns As Integer = 0
			If numberRowFields = 0 Then
				numberColumns = (Math.Max(1, numberValueFields)) + GetCount(engineColumns_Renamed.Table.TopLevelGroup, numberColumns, False)
			Else
				numberColumns = (1) + GetCount(engineColumns_Renamed.Table.TopLevelGroup, numberColumns, False)
			End If
			Dim tempNumberRows As Integer = 0
			If numberColumnFields = 0 Then
				tempNumberRows = numberColumnFields + (1) + GetCount(engineRows_Renamed.Table.TopLevelGroup, tempNumberRows, True)
			Else
				If (numberValueFields <= 2) Then
					tempNumberRows = numberColumnFields + (0 + (numberValueFields)) + GetCount(engineRows_Renamed.Table.TopLevelGroup, tempNumberRows, True)
				Else
					tempNumberRows = numberColumnFields + (0 + (2)) + GetCount(engineRows_Renamed.Table.TopLevelGroup, tempNumberRows, True)
				End If
			End If

			numberRows = tempNumberRows
		 '   this.Parent.Text = string.Format("TL({0},{1})  BR({2},{3})   IN{4}", pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol, numberRows);

			'layout the grid real estate
			pivotTopRow = 1
			pivotLeftCol = 1
			If numberRowFields = 0 Then
				pivotRightCol = pivotLeftCol + (0) + numberColumns
			Else
				pivotRightCol = pivotLeftCol + (numberRowFields - 2 + numberValueFields) + numberColumns
			End If

		   pivotBottomRow = pivotTopRow + numberRows

		   If numberRowFields > 0 AndAlso numberColumnFields > 0 Then
			   pivotBottomRow += 1
			   pivotRightCol += 1
		   End If

		   pivotSummaryRowBase = pivotBottomRow - Math.Min(numberValueFields, 2)
		   pivotSummaryColBase = pivotRightCol - numberValueFields

		 '   this.Parent.Text = string.Format("RC({4},{5})    TL({0},{1})  BR({2},{3})", pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol, numberRows, numberColumns);

			If numberRowFields > 0 Then
				leftColBase = pivotLeftCol + (numberRowFields - 1)+ 1
			Else
				leftColBase = pivotLeftCol + (0)+ 1
			End If
			startGroupRows = numberColumnFields + 1 + 1

			If numberColumnFields = 0 OrElse (numberRowFields > 0 AndAlso numberValueFields > 1) Then
				startGroupRows += 1 '**
			End If

			collapsedNodes_Renamed.Clear()
			gridMainDisplay.CoveredRanges.Clear()
			gridMainDisplay.RowCount = 0 'clear the grid

			If (numberColumnFields > 0) Then
				startGroupColumns = 2
			Else
				startGroupColumns = 1
			End If

			gridMainDisplay.RowCount = pivotBottomRow
			gridMainDisplay.ColCount = pivotRightCol

			Dim colIndex As Integer = 0
			Dim rowIndex As Integer = 0

			'populate the rows
			If numberRowFields > 0 Then
				rowIndex = 2
				colIndex = 1
				rowIndex = AddGroupRowsToGrid(startGroupRows, engineRows_Renamed.Table.TopLevelGroup, colIndex)
			End If

			'populate the columns
			gridMainDisplay.RowCount += 1
			colIndex = leftColBase
			colIndex = AddGroupColumnsToGrid(startGroupColumns, engineColumns_Renamed.Table.TopLevelGroup, colIndex)


			'populate the values...
			SummaryCache.Clear()

			If numberColumnFields > 0 AndAlso numberRowFields > 0 AndAlso numberValueFields > 0 Then
			   colIndex = leftColBase
			   If numberValueFields > 1 Then
				   numberRows = pivotBottomRow - pivotTopRow - numberColumnFields - (3)
			   Else
				   numberRows = pivotBottomRow - pivotTopRow - numberColumnFields - (2)
			   End If
		 '      this.Parent.Text = string.Format("TL({0},{1})  BR({2},{3})   in{4}", pivotTopRow, pivotLeftCol, pivotBottomRow, pivotRightCol, numberRows);
			   DisplayMiddle(CType(engineValues_Renamed.Table.TopLevelGroup, Group), colIndex)
			End If
			gridMainDisplay.Refresh()

		End Sub

		#Region "Summary support"

		Private summaryCache_Renamed As Hashtable = Nothing

		Public ReadOnly Property SummaryCache() As Hashtable
			Get
				If summaryCache_Renamed Is Nothing Then
					summaryCache_Renamed = New Hashtable()
				End If
				Return summaryCache_Renamed
			End Get
			'set { summaryCache = value; }
		End Property

		#End Region

		'displays the values in the middle under the columnGroup at colIndex
		Private Function DisplayMiddle(ByVal columnGroup As Group, ByVal colIndex As Integer) As Integer
			Dim rowIndex As Integer = startGroupRows
			Dim rowGroup As Group = engineRows_Renamed.Table.TopLevelGroup

			Dim sums As SummaryPair(,) = New SummaryPair(numberRows - 1, summaryCount - 1){}
			For i As Integer = 0 To numberRows - 1
				For j As Integer = 0 To summaryCount - 1
					Dim info As PivotComputationInfo = ValuesComputationInfos.Find(gridValues(2 + j, 0).Text)
					sums(i, j) = New SummaryPair(PivotComputationInfoList.CreateSummary(info.CalculationName), info.Pd)
				Next j
			Next i
			SummaryCache.Add(columnGroup, sums)

			If Not columnGroup.Groups Is Nothing AndAlso columnGroup.Groups.Count > 0 Then
				For Each g As Group In columnGroup.Groups
					If g.GroupLevel < numberColumnFields Then
						colIndex = DisplayMiddle(g, colIndex)
					End If
				Next g
				DisplayMiddleDown(columnGroup, colIndex, CType(rowGroup, Group), rowIndex)

				If columnGroup.GroupLevel < numberColumnFields - 1 AndAlso columnGroup.GroupLevel > -1 AndAlso colIndex < gridMainDisplay.ColCount - 1 Then
					Dim sums1 As SummaryPair(,) = TryCast(SummaryCache(columnGroup.ParentGroup), SummaryPair(,))

					For i As Integer = 0 To numberRows - 1
						For j As Integer = 0 To summaryCount - 1
							Dim info As PivotComputationInfo = ValuesComputationInfos(j)
							Dim fmt As String = "{0:" & ValuesComputationInfos(j).Format & "}"
							Dim val As Object = sums(i, j).Pd.GetValue(sums(i, j).Summary)
							If Not val Is Nothing AndAlso (Not val.Equals(0)) Then
								'gridMainDisplay[startGroupRows + i, colIndex + j].Text = "g" + string.Format(fmt, val);
								gridMainDisplay(startGroupRows + i, colIndex + j).ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override)

								gridMainDisplay(startGroupRows + i, colIndex + j).Text = String.Format(fmt, val)
								sums1(i, j).Summary = sums1(i, j).Summary.Combine(sums(i, j).Summary)
							End If
						Next j
					Next i
				End If
			End If
			colIndex += summaryCount
			Return colIndex
		End Function


		'recursively display rows in column
		Private Function DisplayMiddleDown(ByVal columnGroup As Group, ByVal colIndex As Integer, ByVal rowGroup As Group, ByVal rowIndex As Integer) As Integer
			For Each g1 As Group In rowGroup.Groups
				rowIndex = DisplayMiddleDown(columnGroup, colIndex, g1, rowIndex)
			Next g1
			If Not rowGroup.Category Is Nothing Then
				Dim gr As Group = rowGroup
				Dim a As ArrayList = New ArrayList()
				Do While Not gr.Category Is Nothing
					a.Add(gr.Category)
					gr = gr.ParentGroup
				Loop

				'find the proper group in the Columns fields 
				'(need to walk back up the groups for the rows that were added to engineValues)
				Dim gc As Group = columnGroup

				Do While gc.GroupLevel > numberColumnFields AndAlso Not gc.ParentGroup Is Nothing
					gc = gc.ParentGroup
				Loop

				'now need to move down the groups to find the right calculation
				'it may not be here in which case the value is left empty.
				Dim found As Integer = -1
				For i As Integer = a.Count - 1 To 0 Step -1
					For Each g1 As Group In gc.Groups
						If g1.Category.Equals(a(i)) Then 'added changed
							gc = g1
							found = 0
							Exit For
						End If
					Next g1
						'//found = gc.Groups.FindGroup(a[i]);
						'//if (found > -1)
						'//    gc = gc.Groups[found];
						'//else
						'//    break;

				Next i
				'if we found it, then add the results to the accumulated results and display the values
				If found > -1 Then
					If colIndex + summaryCount <= gridMainDisplay.ColCount Then
						'accumulate the calculation in the ParentGroup and display the values in the grid
						Dim summaries As Syncfusion.Collections.BinaryTree.ITreeTableSummary() = gc.GetSummaries(engineValues_Renamed.Table)
						Dim sums1 As SummaryPair(,) = TryCast(SummaryCache(columnGroup.ParentGroup), SummaryPair(,))
						For k As Integer = 0 To summaryCount - 1
							Dim summary As Syncfusion.Collections.BinaryTree.ITreeTableSummary = summaries(k)
							Dim fmt As String = "{0:" & ValuesComputationInfos(k).Format & "}"
							Dim info As PivotComputationInfo = ValuesComputationInfos(k)
							sums1(rowIndex - startGroupRows, k).Summary = sums1(rowIndex - startGroupRows, k).Summary.Combine(summary)
							'gridMainDisplay[rowIndex, colIndex + k].Text = "c" + string.Format(fmt, sums1[rowIndex - startGroupRows, k].Pd.GetValue(summary)); 
							gridMainDisplay(rowIndex, colIndex + k).ModifyStyle(GetAppearance().ValueCell, StyleModifyType.Override)

							gridMainDisplay(rowIndex, colIndex + k).Text = String.Format(fmt, sums1(rowIndex - startGroupRows, k).Pd.GetValue(summary))
						Next k
					End If
				End If
			End If
			rowIndex += 1
			Return rowIndex
		End Function


		Private Sub SetCheck(ByVal rowIndex As Integer, ByVal value As Boolean)
			If rowIndex < 2 Then
				rowIndex = 2
			End If
			If value Then
				gridFields(rowIndex, 0).Text = "1"
			Else
				gridFields(rowIndex, 0).Text = "0"
			End If
		End Sub

        Private Sub SetCheck(ByVal fieldName As String, ByVal value As Boolean)
            Dim check As Integer = 0
            For i As Integer = 2 To gridFields.RowCount - 1
                If gridFields(i, 0).Description = fieldName Then
                    For row As Integer = 2 To gridRows.RowCount - 1
                        If gridRows(row, 0).Text.Equals(fieldName) Then
                            check = 1
                        End If
                    Next row
                    For row As Integer = 2 To gridColumns.RowCount - 1
                        If gridColumns(row, 0).Text.Equals(fieldName) Then
                            check = 1
                        End If
                    Next row
                    For row As Integer = 2 To gridValues.RowCount - 1
                        If gridValues(row, 0).Text.Equals(fieldName) Then
                            check = 1
                        End If
                    Next row
                    For row As Integer = 2 To gridFilter.RowCount - 1
                        If gridFilter(row, 0).Text.Equals(fieldName) Then
                            check = 1
                        End If
                    Next row
                    gridFields(i, 0).Text = check.ToString()
                    Exit For
                End If
            Next i

            'For i As Integer = 2 To gridFields.RowCount - 1
            '    If gridFields(i, 0).Description = fieldName Then
            '        If value Then
            '            gridFields(i, 0).Text = "1"
            '        Else
            '            gridFields(i, 0).Text = "0"
            '        End If

            '        Exit For
            '    End If
            'Next i
        End Sub

		Private Function LocateGrid(ByVal pt As Point) As GridList

			If Me.panelColumns.Bounds.Contains(Me.panelColumns.Parent.PointToClient(pt)) Then
				Return Me.gridColumns
			End If
			If Me.panelRows.Bounds.Contains(Me.panelRows.Parent.PointToClient(pt)) Then
				Return Me.gridRows
			End If
			If Me.panelGrid.Bounds.Contains(Me.panelGrid.Parent.PointToClient(pt)) Then
				Return Me.gridValues
			End If
			If Me.panelFilter.Bounds.Contains(Me.panelFilter.Parent.PointToClient(pt)) Then
				Return Me.gridFilter
			End If

			If Me.gridColumns.Bounds.Contains(gridColumns.Parent.PointToClient(pt)) Then
				Return Me.gridColumns
			End If
			If Me.gridFields.Bounds.Contains(gridFields.Parent.PointToClient(pt)) Then
				Return Me.gridFields
			End If
			If Me.gridFilter.Bounds.Contains(gridFilter.Parent.PointToClient(pt)) Then
				Return Me.gridFilter
			End If
			If Me.gridRows.Bounds.Contains(gridRows.Parent.PointToClient(pt)) Then
				Return Me.gridRows
			End If
			If Me.gridValues.Bounds.Contains(gridValues.Parent.PointToClient(pt)) Then
				Return Me.gridValues
			End If
			Return Nothing
		End Function



		#End Region
        
#Region "grid checkbox support"

        Private Sub gridFields_CheckBoxClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
            Dim rowIndex As Integer
            If e.RowIndex < 2 Then
                rowIndex = 2
            Else
                rowIndex = e.RowIndex
            End If
            If gridFields(rowIndex, 0).Text = "0" Then
                'this.gridRows.RowCount++;
                'this.gridRows[this.gridRows.RowCount, 0].Text = gridFields[e.RowIndex, 0].Description;
                Me.gridRows.Rows.InsertRange(Me.gridRows.RowCount, 1)
                Me.gridRows(Me.gridRows.RowCount - 1, 0).Text = gridFields(rowIndex, 0).Description
                Me.gridRows.Refresh()
                PerformLayout(gridRows, Nothing)
            Else
                Dim location As Integer
                For i As Integer = 0 To 3
                    Dim grid As GridList = TryCast(FindField(gridFields(rowIndex, 0).Description, location), GridList)
                    If Not grid Is Nothing AndAlso location <> -1 Then
                        grid.Rows.RemoveRange(location, location)
                        PerformLayout(grid, Nothing)
                    End If
                Next i
            End If
        End Sub

        Private Function FindField(ByVal fieldName As String, <System.Runtime.InteropServices.Out()> ByRef location As Integer) As GridControl
            location = -1
            Dim grid As GridControl = FindFieldInGrid(fieldName, location, gridFilter)
            If grid Is Nothing Then
                grid = FindFieldInGrid(fieldName, location, gridColumns)
            End If
            If grid Is Nothing Then
                grid = FindFieldInGrid(fieldName, location, gridValues)
            End If
            If grid Is Nothing Then
                grid = FindFieldInGrid(fieldName, location, gridRows)
            End If

            Return grid
        End Function

        Private Function FindFieldInGrid(ByVal fieldName As String, <System.Runtime.InteropServices.Out()> ByRef location As Integer, ByVal g As GridList) As GridControl
            Dim grid As GridList = Nothing
            location = -1
            For row As Integer = 1 + Integer.Parse((IIf(g.HasPaddedRow, 1, 0)).ToString()) To g.RowCount
                If g(row, 0).Text = fieldName Then
                    location = row
                    grid = g
                    Exit For
                End If
            Next row
            Return grid
        End Function
#End Region

#End Region
    End Class

	#Region "SummaryPair class"
	Public Class SummaryPair
		Public Sub New(ByVal summary As Syncfusion.Collections.BinaryTree.ITreeTableSummary, ByVal pd As PropertyDescriptor)
			Me.pd_Renamed = pd
			Me.summary_Renamed = summary
		End Sub


		Private summary_Renamed As Syncfusion.Collections.BinaryTree.ITreeTableSummary

		Public Property Summary() As Syncfusion.Collections.BinaryTree.ITreeTableSummary
			Get
				Return summary_Renamed
			End Get
            Set(ByVal value As Syncfusion.Collections.BinaryTree.ITreeTableSummary)
                summary_Renamed = value
            End Set
		End Property

		Private pd_Renamed As PropertyDescriptor

		Public Property Pd() As PropertyDescriptor
			Get
				Return pd_Renamed
			End Get
			Set(ByVal value As PropertyDescriptor)
				pd_Renamed = value
			End Set
		End Property
	End Class
	#End Region

	#Region "derived GridControl used in Pivot pane grids"
	Public Class GridList
		Inherits GridControl
		Public Sub New()
			MyBase.New()
			Me.RowCount = 1
			Me.ColCount = 1
			Me.RowHeights(0) = 0
			Me.ColWidths(0) = 0
			Me.DefaultGridBorderStyle = GridBorderStyle.None
			Me.Properties.BackgroundColor = Me.TableStyle.BackColor
			Me.AllowDragSelectedRows = True
			Me.ResizeRowsBehavior = GridResizeCellsBehavior.None
			Me.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.HideAlways
			Me.selectionColor_Renamed = Me.AlphaBlendSelectionColor
			Me.AlphaBlendSelectionColor = Color.FromArgb(0, 0, 0, 0)
			Me.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
			Me.Office2007ScrollBars = True
			Me.ThemesEnabled = True
			Me.TableStyle.Themed = True
		End Sub

		#Region "properties"

		Private selectionColor_Renamed As Color

		Public Property SelectionColor() As Color
			Get
				Return selectionColor_Renamed
			End Get
			Set(ByVal value As Color)
				selectionColor_Renamed = value
			End Set
		End Property

		Private hasCheckBox_Renamed As Boolean = False

		Public Property HasCheckBox() As Boolean
			Get
				Return hasCheckBox_Renamed
			End Get
			Set(ByVal value As Boolean)
				hasCheckBox_Renamed = value
			End Set
		End Property

		Private hasPaddedRow_Renamed As Boolean = True

		Public Property HasPaddedRow() As Boolean
			Get
				Return hasPaddedRow_Renamed
			End Get
			Set(ByVal value As Boolean)
				hasPaddedRow_Renamed = value
			End Set
		End Property

		#End Region

		#Region "overrides"

        'Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        '    If e.KeyCode = Keys.Delete Then
        '        Me.Rows.RemoveRange(Me.CurrentCell.RowIndex, Me.CurrentCell.RowIndex)
        '    End If
        '    MyBase.OnKeyDown(e)
        'End Sub
		Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
			Me.Selections.Clear()

			Dim row, col As Integer
			If (e.X > 20 OrElse (Not HasCheckBox)) AndAlso Me.PointToRowCol(New Point(e.X, e.Y), row, col) Then
				 Me.Selections.SelectRange(GridRangeInfo.Row(row), True)
				 Me.CurrentCell.MoveTo(row, col)
			End If
			MyBase.OnMouseDown(e)
		End Sub

		Protected Overrides Sub OnPrepareViewStyleInfo(ByVal e As GridPrepareViewStyleInfoEventArgs)
			MyBase.OnPrepareViewStyleInfo(e)
			If e.ColIndex = 0 AndAlso e.RowIndex > 0 AndAlso Not e.Style.CellValue Is Nothing AndAlso e.Style.CellType Is "CheckBox" AndAlso e.Style.Text = "1" Then
				e.Style.Font.Bold = True

			End If
			If Me.Focused AndAlso e.RowIndex = Me.CurrentCell.RowIndex Then
				e.Style.BackColor = Me.SelectionColor
			End If
			'//else
			'//    e.Style.BackColor = this.TableStyle.BackColor;
		End Sub

		Protected Overrides Sub OnSetCursor(ByRef m As Message)
			If Control.MouseButtons <> MouseButtons.Left Then
				Cursor.Current = Cursors.Default
			Else
				MyBase.OnSetCursor(m)
			End If
		End Sub

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			If Me.CurrentCell.HasCurrentCell Then
				Me.RefreshRange(GridRangeInfo.Row(Me.CurrentCell.RowIndex))
			End If
		End Sub

		#End Region


	End Class
	#End Region

	#Region "PivotContent enum"

	''' <summary>
	''' Used to identify the a portion of the Pivot Control Panel.
	''' </summary>
	Public Enum PivotContent
		Fields
		Filters
		Columns
		Rows
		Values
		ColumnsHeader
		SummaryRow
	End Enum
#End Region

End Namespace
