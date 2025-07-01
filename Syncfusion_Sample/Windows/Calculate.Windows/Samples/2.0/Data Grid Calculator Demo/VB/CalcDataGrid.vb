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
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Calculate

 
Public Class CalcDataGrid
   Inherits DataGrid
    Implements Syncfusion.Calculate.ICalcData
   
   Public Sub New()
      'Avoid the complexity of sorting:
      Me.AllowSorting = False
   End Sub 'New
   
    
   #Region "ICalcData Members"
   
   
   
    Public Sub WireParentObject() Implements ICalcData.WireParentObject
        'Use this event to get cell changes:
        Dim dt As DataTable = Me.DataSource '
        AddHandler dt.DefaultView.ListChanged, AddressOf defaultView_ListChanged
        AddHandler dt.ColumnChanged, AddressOf dt_ColumnChanged

        'Avoid the complexity of new row:
        dt.DefaultView.AllowNew = False
    End Sub 'WireParentObject

    Private changeCol As Integer = -1

    Private Sub defaultView_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
        If e.ListChangedType = ListChangedType.ItemChanged AndAlso changeCol > -1 Then
            Dim row As Integer = e.NewIndex
            Dim col As Integer = Me.changeCol

            Dim val As String = Me(row, col).ToString()
            Dim e1 As New Syncfusion.Calculate.ValueChangedEventArgs(row + 1, col + 1, val)
            RaiseEvent ValueChanged(Me, e1)
        End If
    End Sub 'defaultView_ListChanged


    Private Sub dt_ColumnChanged(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
        Dim dt As DataTable = Me.DataSource '

        Me.changeCol = dt.Columns.IndexOf(e.Column)
        Dim cm As CurrencyManager = Me.BindingContext(Me.DataSource, Me.DataMember)
        If Not (cm Is Nothing) Then
            cm.EndCurrentEdit()
        End If
    End Sub 'dt_ColumnChanged


    'One based:
    Public Function GetValueRowCol(ByVal row As Integer, ByVal col As Integer) As Object Implements ICalcData.GetValueRowCol
        Return Me(row - 1, col - 1)
    End Function 'GetValueRowCol


    'One based:
    Public Sub SetValueRowCol(ByVal value As Object, ByVal row As Integer, ByVal col As Integer) Implements ICalcData.SetValueRowCol
        Dim dt As DataTable = Me.DataSource
        dt.Rows((row - 1))((col - 1)) = value
    End Sub 'SetValueRowCol

    Public Event ValueChanged As Syncfusion.Calculate.ValueChangedEventHandler Implements ICalcData.ValueChanged
#End Region
End Class 'CalcDataGrid 