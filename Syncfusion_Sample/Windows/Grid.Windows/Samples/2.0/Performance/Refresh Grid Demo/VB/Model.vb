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


'/ <summary>
'/ Summary description for Model.
'/ </summary>

Public Class Model
    Private data(,) As Integer
    
    
    Public Sub New(rows As Integer, cols As Integer)
        Me.data = New Integer(rows, cols) {}
        Dim random As New Random(DateTime.Now.Millisecond)
        Dim i As Integer
        For i = 0 To rows - 1
            Dim j As Integer
            For j = 0 To cols - 1
                Me.data(i, j) = random.Next(1000)
            Next j
        Next i
    End Sub 'New 
    
    Default Public ReadOnly Property Item(row As Integer, col As Integer) As Integer
        Get
            Return Me.data(row, col)
        End Get
    End Property
    
    
    Public ReadOnly Property Rows() As Integer
        Get
            Return Me.data.GetLength(0) - 1
        End Get
    End Property
    
    
    Public ReadOnly Property Cols() As Integer
        Get
            Return Me.data.GetLength(1) - 1
        End Get
    End Property
End Class 'Model