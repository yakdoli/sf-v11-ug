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

Public Class ExternalData
    Private _rowCount As Integer
    Private _colCount As Integer
    Private _data(,) As Int32
    'Fields
    'Constructors
    'Methods
    Public Sub New(ByVal rows As Integer, ByVal cols As Integer)
        MyBase.New()
        _rowCount = rows
        _colCount = cols
        _data = New Integer(_rowCount - 1, _colCount - 1) {}
        Dim i As Integer
        i = 0

        Do While (i < RowCount)
            Dim j As Integer
            j = 0

            Do While (j < ColCount)
                _data(i, j) = ((100 * i) _
                            + j)
                j = (j + 1)

            Loop
            i = (i + 1)

        Loop

    End Sub

    Public Overridable ReadOnly Property RowCount() As Integer
        Get
            Return _rowCount
        End Get
    End Property

    Public Overridable ReadOnly Property ColCount() As Integer
        Get
            Return _colCount
        End Get
    End Property

    Default Public Overridable Property Item(ByVal row As Integer, ByVal col As Integer) As Integer
        Get
            Return _data(row, col)
        End Get
        Set(ByVal Value As Integer)
            _data(row, col) = Value
        End Set
    End Property

End Class
