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

Imports Syncfusion.Calculate


Public Class ArrayCalcData
    Implements ICalcData

    '/ <summary>
    '/ original double array
    '/ </summary>
    Private dValues(,) As Double

    '/ <summary>
    '/ vector holding the sum of the rows.
    '/ </summary>
    '/ <remarks>
    '/ Serves as the last column.
    '/ </remarks>
    Private rowSums() As Object

    '/ <summary>
    '/ Vector holding the sum of the columns.
    '/ </summary>
    '/ <remarks>
    '/ Serves as the last row.
    '/ </remarks>
    Private colSums() As Object

    Dim rowCount As Integer
    Dim colCount As Integer

    '/ <summary>
    '/ Gets or sets the value of this ArrayCalcData object.
    '/ </summary>
    '/ <remarks>
    '/ Since this class wraps a double array, the indexing is zero-based. But 
    '/ the ICalcData methods require one-based indexing by convention. So, 
    '/ one is added to the indexes when the ICalcData methods are called.
    '/ </remarks>
    Default Public Property Item(ByVal row As Integer, ByVal col As Integer) As Object
        Get
            Return GetValueRowCol(row + 1, col + 1)
        End Get
        Set(ByVal Value As Object)
            SetValueRowCol(Value, row + 1, col + 1)
        End Set
    End Property
    '/ <summary>
    '/ Wraps the double array with an extra row and column that holds calculated sums.
    '/ </summary>
    '/ <param name="dValues"></param>
    Public Sub New(ByVal dValues(,) As Double)
        Me.dValues = dValues
        rowCount = dValues.GetLength(0)
        colCount = dValues.GetLength(1)
        rowSums = New Object(rowCount + 1) {}
        colSums = New Object(colCount + 1) {}

        'initialize the formulas for the row sums
        ' eg. "=Sum(A5:D5)"  to sum row 5
        Dim row As Integer
        For row = 0 To rowCount - 1
            rowSums(row) = String.Format("=Sum(A{1}:{0}{1})", RangeInfo.GetAlphaLabel(colCount - 1), row + 1)
        Next

        'initialize the formulas for the columns sums
        ' eg. "=Sum(B1:B5)"  to sum column 2
        Dim col As Integer
        For col = 0 To colCount - 1
            colSums(col) = String.Format("=Sum({0}1:{0}{1})", RangeInfo.GetAlphaLabel((col + 1)), rowCount - 1)
        Next
    End Sub 'New

    '/ <summary>
    '/ Gets the value into either the double array or column vector 
    '/ or row vector.
    '/ </summary>
    '/ <param name="row">one-based row index.</param>
    '/ <param name="col">one-based column index.</param>
    '/ <returns>The value.</returns>
    '/ <remarks> By convention, ICalcData uses one-based indexes.</remarks>
    Public Function GetValueRowCol(ByVal row As Integer, ByVal col As Integer) As Object Implements Syncfusion.Calculate.ICalcData.GetValueRowCol
        If row = rowCount Then
            Return colSums((col - 1))
        Else
            If col = colCount Then
                Return rowSums((row - 1))

            Else
                Return Me.dValues(row - 1, col - 1)
            End If
        End If
    End Function 'GetValueRowCol

    '/ <summary>
    '/ Sets the value into either the double array or column vector 
    '/ or row vector.
    '/ </summary>
    '/ <param name="row">one-based row index.</param>
    '/ <param name="col">one-based column index.</param>
    '/ <param name="value">The value to be set.</param>
    '/ <remarks> This setter raises the ICalcData.ValueChanged event which 
    '/ is listened to by the CalcEngine to manage the calculations.
    '/ 
    '/ By convention, ICalcData uses one-based indexes.
    '/ </remarks>
    Public Sub SetValueRowCol(ByVal value As Object, ByVal row As Integer, ByVal col As Integer) Implements Syncfusion.Calculate.ICalcData.SetValueRowCol

        If row = rowCount Then
            colSums(col - 1) = value
        Else
            If col = colCount Then
                rowSums(row - 1) = value
            Else
                Me.dValues(row - 1, col - 1) = Double.Parse(value.ToString())
            End If
        End If
        Dim e1 As New ValueChangedEventArgs(row, col, value.ToString())
        RaiseEvent ValueChanged(Me, e1)
    End Sub 'SetValueRowCol


    Public Sub WireParentObject() Implements Syncfusion.Calculate.ICalcData.WireParentObject

    End Sub

    Public Event ValueChanged(ByVal sender As Object, ByVal e As Syncfusion.Calculate.ValueChangedEventArgs) Implements Syncfusion.Calculate.ICalcData.ValueChanged
End Class
