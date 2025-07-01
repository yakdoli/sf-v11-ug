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

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections

Namespace CustomGridCell
    <Serializable()> _
    Public Class CollapsibleDataSource
        Private internalRowCount As Integer
        Private internalColCount As Integer
        Private data() As SampleData
        Private visibleRows As ArrayList
        Public Locked As Boolean
        'Fields
        'Constructors
        'Methods
        Public Sub New(ByVal rawRowCount As Integer)
            MyBase.New()
            internalColCount = 4
            Locked = False
            internalRowCount = rawRowCount
            visibleRows = New ArrayList()

        End Sub
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
        Default Public ReadOnly Property Item(ByVal i As Integer) As SampleData
            Get

                Return data(CType(visibleRows(i), Integer))

            End Get
        End Property
        Public Overloads Sub CollapseData(ByVal start As Integer)

            'decide which rows are visible and add then to visibleRows
            If (start > 0) Then
                visibleRows.RemoveRange(start, (visibleRows.Count - start))
            Else
                visibleRows = New ArrayList()
            End If
            Dim i As Integer
            i = start

            Do While (i < internalRowCount)
                i = ProcessNode(i)
                ' will increment i at least once, maybe more

            Loop


        End Sub
        Public Overloads Sub CollapseData()

            'decide which rows are visible and add then to visibleRows
            visibleRows = New ArrayList()
            Dim i As Integer
            i = 0

            Do While (i < internalRowCount)
                i = ProcessNode(i)
                ' will increment i at least once, maybe more

            Loop


        End Sub
        Private Function ProcessNode(ByVal i As Integer) As Integer

            If (i >= internalRowCount) Then
                Return i
            End If
            Dim indent As Integer
            indent = data(i).IndentLevel
            Dim closed As Boolean
            closed = (data(i).ExpandState = TreeNodeState.Closed)
            visibleRows.Add(i)
            'make sure parent is not a nocheck
            Dim k As Integer
            If (visibleRows.Count > 1) Then
                k = CType(visibleRows((visibleRows.Count - 2)), Integer)
                If ((data(k).ExpandState = TreeNodeState.NoChildren) _
                            AndAlso (indent > data(k).IndentLevel)) Then
                    data(k).ExpandState = TreeNodeState.Opened
                End If
            End If
            i = (i + 1)

            ' last node was open, so process all on same level
            If closed Then
                ' since last node was not open, 
                ' ignore all nodes indented further

                Do While ((i < internalRowCount) _
                            AndAlso (data(i).IndentLevel > indent))
                    i = (i + 1)


                Loop

                Return i
                ' return & process next node at same level
            End If

            Do While ((i < internalRowCount) _
                        AndAlso (data(i).IndentLevel = indent))
                i = ProcessNode(i)
                Return i

            Loop

            Return i

        End Function
        Public Sub InitData()

            Me.data = New SampleData(internalRowCount - 1) {}
            Dim i As Integer
            i = 0

            Do While (i < internalRowCount)
                Dim ii As Integer
                ii = (i + 1)
                data(i) = New SampleData(0, TreeNodeState.NoChildren, (("row " + ii.ToString) _
                                + ", col 1"), (("row " + ii.ToString) _
                                + ", col 2"), (("row " + ii.ToString) _
                                + ", col 3"), (("row " + ii.ToString) _
                                + ", col 4"))
                i = (i + 1)

            Loop

        End Sub
        Public Sub ExpandAll()

            Dim i As Integer
            i = 0

            Do While (i < internalRowCount)
                If data(i).ExpandState = TreeNodeState.Closed Then
                    data(i).ExpandState = TreeNodeState.Opened
                End If
                i = (i + 1)

            Loop

        End Sub
        Public Sub CloseAll()

            Dim i As Integer
            i = 0

            Do While (i < internalRowCount)
                If data(i).ExpandState = TreeNodeState.Opened Then
                    data(i).ExpandState = TreeNodeState.Closed
                End If
                i = (i + 1)

            Loop

        End Sub
    End Class
End Namespace
