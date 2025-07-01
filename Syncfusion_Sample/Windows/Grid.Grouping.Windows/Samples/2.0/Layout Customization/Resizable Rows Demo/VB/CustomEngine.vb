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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports System.Diagnostics

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping


'/ <summary>
'/ GroupingEngineFactory provides GroupingRecordRow elements that
'/ support saving row heights.
'/ </summary>

Public Class GroupingEngineFactory
    Inherits GridEngineFactoryBase

    ' Add this line in your forms ctor:
    ' GroupingEngineFactory provides a modified GridChildTable that adds an extra section
    ' GridEngineFactory.Factory = new GroupingEngineFactory();
    Public Overrides Function CreateEngine() As GridEngine
        Return New GroupingEngine()
    End Function 'CreateEngine
End Class 'GroupingEngineFactory


Public Class GroupingEngine
    Inherits GridEngine

    Public Overrides Function CreateRecordRow(ByVal parent As RecordRowsPart) As RecordRow
        Return New GroupingRecordRow(parent)
    End Function 'CreateRecordRow


    Public Overrides Function CreateCaptionRow(ByVal parent As CaptionSection) As CaptionRow
        Return New GroupingCaptionRow(parent)
    End Function 'CreateCaptionRow


    Public Overrides Function CreateColumnHeaderRow(ByVal parent As ColumnHeaderSection) As ColumnHeaderRow
        Return New GroupingColumnHeaderRow(parent)
    End Function 'CreateColumnHeaderRow
End Class 'GroupingEngine 
' same pattern can be used for:
' FilterBarRow CreateFilterBarRow(FilterBarSection parent)
' GroupFooterSection CreateGroupFooterSection(Group parent)
' GroupHeaderSection CreateGroupHeaderSection(Group parent)
' RecordPreviewRow CreateRecordPreviewRow(RecordPreviewRowsPart parent)


Public Class GroupingRecordRow
    Inherits GridRecordRow
    Implements IGridRowHeight 'ToDo: Add Implements Clauses for implementation methods of these interface(s)
    Private _rowHeight As Integer = -1


    '/ <summary>
    '/ Initializes a new object in the specifed record part.
    '/ </summary>
    '/ <param name="parent">The parent element.</param>
    Public Sub New(ByVal parent As RecordRowsPart)
        MyBase.New(parent)
    End Sub 'New

#Region "IGridRowHeight Members"


    '/ <summary>
    '/ Determines if elements supports storing row heights 
    '/ </summary>
    '/ <returns></returns>
    Public Function SupportsRowHeight() As Boolean Implements IGridRowHeight.SupportsRowHeight
        Return True
    End Function 'SupportsRowHeight

    '/ <summary>
    '/ The row height 
    '/ </summary>
    Public Property RowHeight() As Integer Implements IGridRowHeight.RowHeight
        Get
            Return _rowHeight
        End Get
        Set(ByVal Value As Integer)
            If _rowHeight <> Value Then
                _rowHeight = Value
                Me.InvalidateCounterBottomUp()
            End If
        End Set
    End Property

    '/ <summary>
    '/ Checks if row height was modified or if default setting should be used.
    '/ </summary>
    Public ReadOnly Property HasRowHeight() As Boolean Implements IGridRowHeight.HasRowHeight
        Get
            Return _rowHeight <> -1
        End Get
    End Property

#End Region


    '/ <summary>
    '/ This is where the row height then gets integrated with the engine
    '/ YAmount Counter logic.
    '/ </summary>
    '/ <returns></returns>
    Public Overrides Function GetYAmountCount() As Double
        ' Note: whenever the value that is returned by GetYAmountCount changes
        ' make sure you call InvalidateCounterBottomUp so that the engine
        ' is aware of the change and counters are recalculated. See
        ' the RowHeight setter. 
        If _rowHeight <> -1 Then
            Return _rowHeight
        Else
            Return MyBase.GetYAmountCount()
        End If
    End Function 'GetYAmountCount
End Class 'GroupingRecordRow 



Public Class GroupingCaptionRow
    Inherits GridCaptionRow
    Implements IGridRowHeight 'ToDo: Add Implements Clauses for implementation methods of these interface(s)
    Private _rowHeight As Integer = -1


    '/ <summary>
    '/ Initializes a new object in the specifed record part.
    '/ </summary>
    '/ <param name="parent">The parent element.</param>
    Public Sub New(ByVal parent As CaptionSection)
        MyBase.New(parent)
    End Sub 'New

#Region "IGridRowHeight Members"


    '/ <summary>
    '/ Determines if elements supports storing row heights 
    '/ </summary>
    '/ <returns></returns>
    Public Function SupportsRowHeight() As Boolean Implements IGridRowHeight.SupportsRowHeight
        Return True
    End Function 'SupportsRowHeight

    '/ <summary>
    '/ The row height 
    '/ </summary>
    Public Property RowHeight() As Integer Implements IGridRowHeight.RowHeight
        Get
            Return _rowHeight
        End Get
        Set(ByVal Value As Integer)
            If _rowHeight <> Value Then
                _rowHeight = Value
                Me.InvalidateCounterBottomUp()
            End If
        End Set
    End Property

    '/ <summary>
    '/ Checks if row height was modified or if default setting should be used.
    '/ </summary>
    Public ReadOnly Property HasRowHeight() As Boolean Implements IGridRowHeight.HasRowHeight
        Get
            Return _rowHeight <> -1
        End Get
    End Property

#End Region



    '/ <summary>
    '/ This is where the row height then gets integrated with the engine
    '/ YAmount Counter logic.
    '/ </summary>
    '/ <returns></returns>
    Public Overrides Function GetYAmountCount() As Double
        ' Note: whenever the value that is returned by GetYAmountCount changes
        ' make sure you call InvalidateCounterBottomUp so that the engine
        ' is aware of the change and counters are recalculated. See
        ' the RowHeight setter. 
        If _rowHeight <> -1 Then
            Return _rowHeight
        Else
            Return MyBase.GetYAmountCount()
        End If
    End Function 'GetYAmountCount
End Class 'GroupingCaptionRow 



Public Class GroupingColumnHeaderRow
    Inherits GridColumnHeaderRow
    Implements IGridRowHeight 'ToDo: Add Implements Clauses for implementation methods of these interface(s)
    Private _rowHeight As Integer = -1


    '/ <summary>
    '/ Initializes a new object in the specifed record part.
    '/ </summary>
    '/ <param name="parent">The parent element.</param>
    Public Sub New(ByVal parent As ColumnHeaderSection)
        MyBase.New(parent)
    End Sub 'New

#Region "IGridRowHeight Members"


    '/ <summary>
    '/ Determines if elements supports storing row heights 
    '/ </summary>
    '/ <returns></returns>
    Public Function SupportsRowHeight() As Boolean Implements IGridRowHeight.SupportsRowHeight
        Return True
    End Function 'SupportsRowHeight

    '/ <summary>
    '/ The row height 
    '/ </summary>
    Public Property RowHeight() As Integer Implements IGridRowHeight.RowHeight
        Get
            Return _rowHeight
        End Get
        Set(ByVal Value As Integer)
            If _rowHeight <> Value Then
                _rowHeight = Value
                Me.InvalidateCounterBottomUp()
            End If
        End Set
    End Property

    '/ <summary>
    '/ Checks if row height was modified or if default setting should be used.
    '/ </summary>
    Public ReadOnly Property HasRowHeight() As Boolean Implements IGridRowHeight.HasRowHeight
        Get
            Return _rowHeight <> -1
        End Get
    End Property

#End Region



    '/ <summary>
    '/ This is where the row height then gets integrated with the engine
    '/ YAmount Counter logic.
    '/ </summary>
    '/ <returns></returns>
    Public Overrides Function GetYAmountCount() As Double
        ' Note: whenever the value that is returned by GetYAmountCount changes
        ' make sure you call InvalidateCounterBottomUp so that the engine
        ' is aware of the change and counters are recalculated. See
        ' the RowHeight setter. 
        If _rowHeight <> -1 Then
            Return _rowHeight
        Else
            Return MyBase.GetYAmountCount()
        End If
    End Function 'GetYAmountCount
End Class 'GroupingColumnHeaderRow 

