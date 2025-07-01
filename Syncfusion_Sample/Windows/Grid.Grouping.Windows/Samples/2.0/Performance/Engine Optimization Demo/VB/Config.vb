Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region



Imports System
Imports System.Data
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid

Namespace TestEngineOptimizations
	Public Enum DataSourceType
		None
		FlatVirtualList
		FlatDataView
		
'		FlatDataTableWrapperList,
'		HierachicalDataView,
'		FlatVirtualListWithForeinKeys,
'		FlatDataViewWithForeinKeys,
	End Enum

	<TypeConverter(GetType(ExpandableObjectConverter))> _
	Public Class Config
		Private name_Renamed As String
		Private dataSourceType_Renamed As DataSourceType
		Private recordCount_Renamed As Integer
		Private comment_Renamed As String
		Private schema_Renamed As GridEngine = New GridEngine()
		Private useCustomEngine_Renamed As Boolean
		Private allowGrouping_Renamed As Boolean
		Private allowThumbtracking_Renamed As Boolean = True



'INSTANT VB NOTE: The parameter name was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal name_Renamed As String)
			Me.name_Renamed = name_Renamed

			Select Case name_Renamed
				Case "Flat Virtual List, 30 million records, Virtual Mode"
					dataSourceType_Renamed = DataSourceType.FlatVirtualList
					recordCount_Renamed = 30000000 ' 30 million
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.All
					schema_Renamed.CounterLogic = EngineCounters.YAmount '.FilteredRecords;
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = False
					schema_Renamed.TableDescriptor.AllowEdit = False
					comment_Renamed = "Large Virtual List with 30,000,000 records. Sorting and Grouping disabled. ReadOnly. Pixelscroll."
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					allowGrouping_Renamed = False
					useCustomEngine_Renamed = False
					allowThumbtracking_Renamed = False
					Me.OnDataSourceTypeChange()
					schema_Renamed.TableDescriptor.Columns("Index").MaxLength = 10

				Case "Flat Virtual List, VirtualMode"
					dataSourceType_Renamed = DataSourceType.FlatVirtualList
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.All
					schema_Renamed.CounterLogic = EngineCounters.FilteredRecords
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = False
					allowGrouping_Renamed = True
					comment_Renamed = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly"
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = False
					Me.OnDataSourceTypeChange()
					schema_Renamed.TableDescriptor.Columns("Index").MaxLength = 10

				Case "Flat DataView, VirtualMode, Pass-Through sorting enabled."
					dataSourceType_Renamed = DataSourceType.FlatDataView
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.All
					schema_Renamed.CounterLogic = EngineCounters.FilteredRecords
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = True
					allowGrouping_Renamed = True
					comment_Renamed = "FlatDataView with 100,000 records. Sorting and Grouping enabled. Pass-through sort enabled."
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = False
					Me.OnDataSourceTypeChange()

				Case "Flat DataView, VirtualMode, Pass-Through sorting disabled."
					dataSourceType_Renamed = DataSourceType.FlatDataView
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.DisableCounters Or EngineOptimizations.VirtualMode Or EngineOptimizations.RecordsAsDisplayElements
					schema_Renamed.CounterLogic = EngineCounters.FilteredRecords
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = True
					allowGrouping_Renamed = True
					comment_Renamed = "FlatDataView with 100,000 records. Sorting and Grouping enabled. No pass-through sort."
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = False
					Me.OnDataSourceTypeChange()

				Case "Flat DataView, Summaries."
					dataSourceType_Renamed = DataSourceType.FlatDataView
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.DisableCounters Or EngineOptimizations.VirtualMode Or EngineOptimizations.RecordsAsDisplayElements
					schema_Renamed.CounterLogic = EngineCounters.FilteredRecords
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = True
					schema_Renamed.TableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("Average", New GridSummaryColumnDescriptor("Zip", SummaryType.Int32Aggregate, "Zip", "{Average:###}")))
					allowGrouping_Renamed = True
					comment_Renamed = "FlatDataView with 100,000 records. Summaries. Sorting and Grouping enabled. No pass-through sort."
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = False
					Me.OnDataSourceTypeChange()

				Case "Flat DataView, Grouped."
					dataSourceType_Renamed = DataSourceType.FlatDataView
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.DisableCounters Or EngineOptimizations.VirtualMode Or EngineOptimizations.RecordsAsDisplayElements
					schema_Renamed.CounterLogic = EngineCounters.FilteredRecords
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = True
					schema_Renamed.TableDescriptor.GroupedColumns.Add("Zip")
					allowGrouping_Renamed = True
					comment_Renamed = "FlatDataView with 100,000 records. Grouped. Sorting enabled. No pass-through sort."
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = False
					Me.OnDataSourceTypeChange()

				Case "Flat Virtual List, No Optimizations"
					dataSourceType_Renamed = DataSourceType.FlatVirtualList
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.None
					schema_Renamed.CounterLogic = EngineCounters.All
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = False
					allowGrouping_Renamed = True
					comment_Renamed = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly"
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = False
					Me.OnDataSourceTypeChange()
					schema_Renamed.TableDescriptor.Columns("Index").MaxLength = 10

				Case "Flat Virtual List, Using Custom Engine"
					dataSourceType_Renamed = DataSourceType.FlatVirtualList
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.All
					schema_Renamed.CounterLogic = EngineCounters.FilteredRecords
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = False
					allowGrouping_Renamed = True
					comment_Renamed = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly. Using Custom Engine."
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = True
					Me.OnDataSourceTypeChange()
					schema_Renamed.TableDescriptor.Columns("Index").MaxLength = 10

				Case "Flat Virtual List, Sorted"
					dataSourceType_Renamed = DataSourceType.FlatVirtualList
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.All
					schema_Renamed.CounterLogic = EngineCounters.FilteredRecords
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = False
					schema_Renamed.TableDescriptor.SortedColumns.Add("SomeValue")
					allowGrouping_Renamed = True
					comment_Renamed = "Sorted Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly"
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = False
					Me.OnDataSourceTypeChange()
					schema_Renamed.TableDescriptor.Columns("Index").MaxLength = 10

				Case "Flat Virtual List, Grouped"
					dataSourceType_Renamed = DataSourceType.FlatVirtualList
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.All
					schema_Renamed.CounterLogic = EngineCounters.FilteredRecords
					schema_Renamed.TableOptions.VerticalPixelScroll = False ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = True
					schema_Renamed.TableDescriptor.GroupedColumns.Add("OtherValue")
					allowGrouping_Renamed = True
					comment_Renamed = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly"
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = False
					Me.OnDataSourceTypeChange()
					schema_Renamed.TableDescriptor.Columns("Index").MaxLength = 10

				Case "Flat Virtual List, Grouped, VerticalPixelScroll"
					dataSourceType_Renamed = DataSourceType.FlatVirtualList
					recordCount_Renamed = 100000 ' 100k
					schema_Renamed.InvalidateAllWhenListChanged = False
					schema_Renamed.AllowedOptimizations = EngineOptimizations.All
					schema_Renamed.CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.VerticalPixelScroll = True ' also dependant on CounterLogic = EngineCounters.YAmount
					schema_Renamed.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords
					schema_Renamed.TableOptions.ColumnsMaxLengthFirstNRecords = 100
					schema_Renamed.TableOptions.AllowSortColumns = True
					schema_Renamed.TableDescriptor.AllowEdit = True
					schema_Renamed.TableDescriptor.GroupedColumns.Add("OtherValue")
					allowGrouping_Renamed = True
					comment_Renamed = "Virtual List With 100,000 records. Sorting and Grouping enabled. No pass-through sort. ReadOnly"
					schema_Renamed.Appearance.AlternateRecordFieldCell.BackColor = Color.Beige
					useCustomEngine_Renamed = False
					Me.OnDataSourceTypeChange()
					schema_Renamed.TableDescriptor.Columns("Index").MaxLength = 10

				Case "Reset Datasource"
					dataSourceType_Renamed = DataSourceType.None
					recordCount_Renamed = 0 ' 100k
					comment_Renamed = "Empty Datasource (null)"
					Me.OnDataSourceTypeChange()


			End Select
		End Sub

		Public Sub New()
		End Sub

		<Category("Info"), RefreshProperties(RefreshProperties.All)> _
		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set
				name_Renamed = Value
			End Set
		End Property

		<Category("Info"), RefreshProperties(RefreshProperties.All)> _
		Public Property Comment() As String
			Get
				Return comment_Renamed
			End Get
			Set
				comment_Renamed = Value
			End Set
		End Property

		<Category("Data"), RefreshProperties(RefreshProperties.All)> _
		Public Property DataSourceType() As DataSourceType
			Get
				Return dataSourceType_Renamed
			End Get
			Set
				dataSourceType_Renamed = Value
			End Set
		End Property

		<Category("Data"), RefreshProperties(RefreshProperties.All)> _
		Public Property RecordCount() As Integer
			Get
				Return recordCount_Renamed
			End Get
			Set
				recordCount_Renamed = Value
			End Set
		End Property

		<Category("Data"), RefreshProperties(RefreshProperties.All)> _
		Public Property Schema() As GridEngine
			Get
				Return schema_Renamed
			End Get
			Set
				schema_Renamed.InitializeFrom(Value)
			End Set
		End Property

		<Category("Data"), RefreshProperties(RefreshProperties.All)> _
		Public Property AllowThumbtracking() As Boolean
			Get
				Return allowThumbtracking_Renamed
			End Get
			Set
				allowThumbtracking_Renamed = Value
			End Set
		End Property

		<Category("Data"), RefreshProperties(RefreshProperties.All)> _
		Public Property AllowGrouping() As Boolean
			Get
				Return allowGrouping_Renamed
			End Get
			Set
				allowGrouping_Renamed = Value
			End Set
		End Property

		<Category("Data"), RefreshProperties(RefreshProperties.All)> _
		Public Property UseCustomEngine() As Boolean
			Get
				Return useCustomEngine_Renamed
			End Get
			Set
				useCustomEngine_Renamed = Value
			End Set
		End Property

		Private Sub OnDataSourceTypeChange()
			Select Case Me.dataSourceType_Renamed
				Case DataSourceType.FlatVirtualList
					Me.schema_Renamed.DataSource = New TestEngineOptimizations.VirtualList(Me.recordCount_Renamed)
					Me.schema_Renamed.Reset()

				Case DataSourceType.None
					Me.schema_Renamed.DataSource = Nothing
					Me.schema_Renamed.Reset()

				Case DataSourceType.FlatDataView
					Me.schema_Renamed.DataSource = GetDataTable(100, Me.recordCount_Renamed)
					Me.schema_Renamed.Reset()
					Exit Select
			End Select
		End Sub

'INSTANT VB NOTE: The parameter recordCount was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Private Function GetDataTable(ByVal zipCount As Integer, ByVal recordCount_Renamed As Integer) As DataTable
			Dim states As String() = New String(){"North Carolina", "South Carolina", "Washington", "Nevada", "Ohio"}

			Dim random As Random = New Random()
			Dim numStates As Integer = states.GetLength(0)
			Dim nameFormat As String = "Name{0:00000}"

			Dim table As DataTable = New DataTable("Test")

			Dim col As DataColumn = table.Columns.Add()
			col.DataType = GetType(String)
			col.ColumnName = "Name"

			col = table.Columns.Add()
			col.DataType = GetType(String)
			col.ColumnName = "State"

			col = table.Columns.Add()
			col.DataType = GetType(Integer)
			col.ColumnName = "Zip"

			Dim i As Integer = 0
'ORIGINAL LINE: for(int i = 0; i < recordCount; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < recordCount_Renamed
				Dim row As DataRow = table.NewRow()
				row("Name") = String.Format(nameFormat, i)
				row("State") = states(random.Next(numStates-1))
				row("Zip") = random.Next(zipCount)
				table.Rows.Add(row)
				i += 1
			Loop

			Return table
		End Function

		Public Sub ApplyTo(ByVal form As Form1)
			Dim currentCustomEngine As Boolean = TypeOf form.gridGroupingControl1.Engine Is GroupingEngine


				' Create a new GridGroupingControl with new engine
				form.Controls.Remove(form.gridGroupingControl1)
				If Me.useCustomEngine_Renamed Then
					form.gridGroupingControl1 = New GridGroupingControl(New GroupingEngine())
				Else
					form.gridGroupingControl1 = New GridGroupingControl()
				End If
				form.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
				form.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.None
            form.gridGroupingControl1.ClientSize = New Size(380, 300)
            form.gridGroupingControl1.Location = New Point(20, 18)
				form.gridGroupingControl1.Name = "gridGroupingControl1"
				form.gridGroupingControl1.TabIndex = 0
				form.gridGroupingControl1.VersionInfo = "3.2.0.0"
            form.gridGroupingControl1.IntelliMousePanning = True
            form.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            form.Controls.Add(form.gridGroupingControl1)

			Dim grid As GridGroupingControl = form.gridGroupingControl1
			grid.DataSource = Nothing
			grid.Engine = schema_Renamed ' will call Engine.InitializeFrom in setter.

			Select Case Me.dataSourceType_Renamed
				Case DataSourceType.None
					grid.DataSource = Nothing

				Case DataSourceType.FlatVirtualList
					grid.DataSource = New TestEngineOptimizations.VirtualList(Me.recordCount_Renamed)
				Case DataSourceType.FlatDataView
					grid.DataSource = GetDataTable(100, Me.recordCount_Renamed)
					Exit Select
			End Select

			grid.ShowGroupDropArea = Me.allowGrouping_Renamed
			grid.VerticalThumbTrack = Me.AllowThumbtracking

		End Sub
	End Class


	#region "'ConfigCollection' strongly typed collection class"

	<EditorAttribute(GetType(System.ComponentModel.Design.CollectionEditor), GetType(System.Drawing.Design.UITypeEditor))> _
	Public Class ConfigCollection : Inherits System.Collections.CollectionBase
		Public Sub New()
		End Sub

		Public Sub New(ByVal fieValue As ConfigCollection)
			Me.AddRange(fieValue)
		End Sub

		Public Sub New(ByVal fieValue As Config())
			Me.AddRange(fieValue)
		End Sub

		Public Default Property Item(ByVal intIndex As Integer) As Config
			Get
				Return (CType(List(intIndex), Config))
			End Get
			Set
				List(intIndex) = Value
			End Set
		End Property

		Public Function Find(ByVal name As String) As Config
			For n As Integer = 0 To Count - 1
				If Me(n).Name = name Then
					Return Me(n)
				End If
			Next n

			Return Nothing
		End Function

		Public Function GetConfig(ByVal name As String) As Config
			Dim value As Config = Find(name)
			If value Is Nothing Then
				Dim obj As Config = New Config()
				obj.Name = name
				Add(obj)
			End If

			Return value
		End Function

		Public Function Add(ByVal fieValue As Config) As Integer
			Return List.Add(fieValue)
		End Function

		Public Sub AddRange(ByVal fieValue As Config())
			Dim intCounter As Integer = 0
'ORIGINAL LINE: for (int intCounter = 0; (intCounter < fieValue.Length); intCounter = (intCounter + 1))
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While (intCounter < fieValue.Length)
				Me.Add(fieValue(intCounter))
				intCounter = (intCounter + 1)
			Loop
		End Sub

		Public Sub AddRange(ByVal fieValue As ConfigCollection)
			Dim intCounter As Integer = 0
'ORIGINAL LINE: for (int intCounter = 0; (intCounter < fieValue.Count); intCounter = (intCounter + 1))
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While (intCounter < fieValue.Count)
				Me.Add(fieValue(intCounter))
				intCounter = (intCounter + 1)
			Loop
		End Sub

		Public Function Contains(ByVal fieValue As Config) As Boolean
			Return List.Contains(fieValue)
		End Function

		Public Sub CopyTo(ByVal fieArray As Config(), ByVal intIndex As Integer)
			List.CopyTo(fieArray, intIndex)
		End Sub

		Public Function IndexOf(ByVal fieValue As Config) As Integer
			Return List.IndexOf(fieValue)
		End Function

		Public Sub Insert(ByVal intIndex As Integer, ByVal fieValue As Config)
			List.Insert(intIndex, fieValue)
		End Sub

		Public Shadows Function GetEnumerator() As ConfigEnumerator
			Return New ConfigEnumerator(Me)
		End Function

		Public Sub Remove(ByVal fieValue As Config)
			List.Remove(fieValue)
		End Sub

		Public Class ConfigEnumerator : Inherits Object : Implements System.Collections.IEnumerator

			Private iEnBase As System.Collections.IEnumerator

			Private iEnLocal As System.Collections.IEnumerable

			Public Sub New(ByVal fieMappings As ConfigCollection)
				Me.iEnLocal = (CType(fieMappings, System.Collections.IEnumerable))
				Me.iEnBase = iEnLocal.GetEnumerator()
			End Sub


			Private ReadOnly Property Current() As Object Implements System.Collections.IEnumerator.Current
				Get
					Return iEnBase.Current
				End Get
			End Property


			Private Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
				Return iEnBase.MoveNext()
			End Function


			Private Sub Reset() Implements System.Collections.IEnumerator.Reset
				iEnBase.Reset()
			End Sub
		End Class
	End Class

	#End Region '('ConfigCollection' strongly typed collection class)
End Namespace
