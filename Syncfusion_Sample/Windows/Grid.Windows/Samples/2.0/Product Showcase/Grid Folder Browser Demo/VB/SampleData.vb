Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.IO


Namespace FolderBrowser
	Public Class TreeNodeState
		Shared Public Opened As Integer =0
		Shared Public Closed As Integer = 1
		Shared Public NoChildren As Integer = 2
	End Class

	<Serializable> _
	Public Class SampleData
		Private _count As Integer
		Private _indentLevel As Integer
		Private _items As String()
		Private _state As Integer

		Public Property Items() As String()
			Get
				If _items Is Nothing Then
					 _items = New String(_count - 1) {}
				End If
				Return _items
			End Get
			Set
				_items = Value
			End Set
		End Property


		Public Property IndentLevel() As Integer
			Get
				Return _indentLevel
			End Get
			Set
				_indentLevel = Value
			End Set
		End Property

		Public ReadOnly Property ItemCount() As Integer
			Get
				Return _count
			End Get
		End Property

		Public Property ExpandState() As Integer
			Get
				Return _state
			End Get
			Set
				_state = Value
			End Set
		End Property

		Public Sub New()
		End Sub

'INSTANT VB NOTE: The parameter indentLevel was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
'INSTANT VB NOTE: The parameter expandstate was renamed since Visual Basic will not uniquely identify class members when parameters have the same name:
		Public Sub New(ByVal indentLevel_Renamed As Integer, ByVal expandstate_Renamed As Integer, ByVal item1 As String, ByVal item2 As String, ByVal item3 As String, ByVal item4 As String, ByVal item5 As String)
			_count = 5
			_items = New String(_count - 1) {}
			_items(0) = item1
			_items(1) = item2
			_items(2) = item3
			_items(3) = item4
			_items(4) = item5
			_indentLevel = indentLevel_Renamed
			_state = expandstate_Renamed

		End Sub
	End Class

	<Serializable> _
	Public Class CollapsibleDataSource
		Private fc As FileData
		Private internalRowCount As Integer
		Private internalColCount As Integer
		Private drvName As String
		Private data As DataCollection
		Private isempty_Renamed As Boolean = False
		Private visibleRows As ArrayList

		Public Locked As Boolean

		Public Sub New(ByVal drive As String)
			internalColCount = 5

			Locked = False

			internalRowCount = 10
			drvName = drive

			visibleRows = New ArrayList()
			data = New DataCollection()
			fc = New FileData(Me.drvName)
			If fc.Count = 0 Then
				isempty_Renamed=True
			End If
		End Sub

		Public ReadOnly Property IsEmpty() As Boolean
			Get
				Return isempty_Renamed
			End Get
		End Property
		Public ReadOnly Property RowCount() As Integer
			Get
				Return visibleRows.Count
			End Get
		End Property

		Public ReadOnly Property ColCount() As Integer
			Get
				Return internalColCount
			End Get
		End Property

		Public Sub CollapseData(ByVal start As Integer)
			'decide which rows are visible and add then to visibleRows
			If start > 0 Then
				visibleRows.RemoveRange(start, visibleRows.Count - start)
			Else
				visibleRows = New ArrayList()
			End If

			Dim i As Integer = start
			Do While i < internalRowCount
				i = ProcessNode(i) ' will increment i at least once, maybe more
			Loop
		End Sub
		Public Sub CollapseData()
			'decide which rows are visible and add then to visibleRows
			visibleRows = New ArrayList()

			Dim i As Integer = 0
			Do While i < internalRowCount
				i = ProcessNode(i) ' will increment i at least once, maybe more
			Loop
		End Sub

		Public Sub InsertData(ByVal index As Integer, ByVal filePath As String, ByVal indent As Integer)
            Dim iOrginalIndex As Integer = Integer.Parse(visibleRows(index - 1).ToString()) + 1

            Me.fc = New FileData(filePath)

            For Each item As FileDataItem In Me.fc
                Dim state As Integer = 1
                If item.ItemType.ToString() = "File" Then
                    state = 2
                End If
                data.Insert(iOrginalIndex, New SampleData(indent + 1, state, item.Name, item.Size.ToString(), item.FullName, item.Modified.ToString(), item.ItemType.ToString()))
                internalRowCount += 1
                index += 1
            Next item
            CollapseData()

		End Sub

		Private Function ProcessNode(ByVal i As Integer) As Integer
			If i >= internalRowCount Then
				Return i
			End If

			Dim indent As Integer = data(i).IndentLevel
			Dim closed As Boolean = (data(i).ExpandState = TreeNodeState.Closed)
			visibleRows.Add(i)

			'make sure parent is not a nocheck
			Dim k As Integer
			If visibleRows.Count > 1 Then
				k = CInt(visibleRows(visibleRows.Count - 2))
				If data(k).ExpandState = TreeNodeState.NoChildren AndAlso indent > data(k).IndentLevel Then
					data(k).ExpandState = TreeNodeState.Opened
				End If
			End If

			i += 1
			If closed Then
				' since last node was not open, 
				' ignore all nodes indented further
				Do While i < internalRowCount AndAlso data(i).IndentLevel > indent
					i += 1
				Loop
				Return i ' return & process next node at same level
			End If

				' last node was open, so process all on same level
				Do While i < internalRowCount AndAlso data(i).IndentLevel = indent
					i = ProcessNode(i)
					Return i
				Loop

			Return i


		End Function
		Public ReadOnly Default Property Item(ByVal i As Integer) As SampleData
			Get
				Return data(CInt(visibleRows(i)))
			End Get
		End Property

		Public Sub InitData()
            Dim temp As ArrayList = GetFileListing(Me.drvName)

			internalRowCount = temp.Count

			Dim i As Integer = 0
'ORIGINAL LINE: for(int i = 0; i < internalRowCount; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < internalRowCount
				Dim d As SampleData = CType(temp(i), SampleData)

				If d.Items(3) = "Directory" Then
					Dim f As FileData = New FileData(System.IO.Directory.GetDirectoryRoot(d.Items(0)))
					d.IndentLevel = 1
					If f.Count > 0 Then
						d.ExpandState = TreeNodeState.Closed
					End If
				Else If d.Items(3) = "File" Then
					d.ExpandState = TreeNodeState.NoChildren
					d.IndentLevel = 1
				End If

				data.Add(d)
				i += 1
			Loop

		End Sub

		Public Sub ExpandAll()
			Dim i As Integer = 0
'ORIGINAL LINE: for(int i = 0; i < internalRowCount; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < internalRowCount
				If data(i).ExpandState = TreeNodeState.Closed Then
					data(i).ExpandState = TreeNodeState.Opened
				End If
				i += 1
			Loop
		End Sub

		Public Sub CloseAll()
			Dim i As Integer = 0
'ORIGINAL LINE: for(int i = 0; i < internalRowCount; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < internalRowCount
				If data(i).ExpandState = TreeNodeState.Opened Then
					data(i).ExpandState = TreeNodeState.Closed
				End If
				i += 1
			Loop

		End Sub

		Private Function GetFileListing(ByVal aStartingDir As String) As ArrayList
			Dim di As DirectoryInfo = New DirectoryInfo(aStartingDir)
            Dim List As ArrayList = New ArrayList()
			Me.fc = New FileData(aStartingDir)
            List.Add(New SampleData(0, TreeNodeState.Opened, drvName, aStartingDir.Length.ToString(), aStartingDir, di.LastWriteTime.ToString(), "Drive"))
            Dim item As FileDataItem
            For Each item In Me.fc
                List.Add(New SampleData(1, TreeNodeState.Closed, item.Name, item.Size.ToString(), item.FullName, item.Modified.ToString(), item.ItemType.ToString()))
            Next item
            Return List
		End Function
    End Class
End Namespace
