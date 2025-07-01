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
Imports Syncfusion.Windows.Forms.Grid

Namespace GridDataBoundGridCalculator

Public Class CalcGridDataBoundGrid
    Inherits GridDataBoundGrid
    Implements Syncfusion.Calculate.ICalcData

    Public Sub New()
        'Avoid the complexity of sorting:
        Me.SortBehavior = GridSortBehavior.None
        Me.AllowDragSelectedCols = False
        Me.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell

            'Set this to force the values to be saved when leaving cell
            'as opposed to being saved when leaving row.
            Me.Binder.DirectSaveCellInfo = True
		
             Me.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid   
        Me.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
        Me.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(227, Byte), CType(239, Byte), CType(255, Byte))
        Me.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(208, Byte), CType(215, Byte), CType(229, Byte))

        Me.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Font = New System.Drawing.Font("Verdana", 8.5F)
    End Sub 'New

        'Used to avoid focus problem on disabled grid:
        Private locked1 As Boolean = False

        Public Property Locked() As Boolean
            Get
                Return locked1
            End Get
            Set(ByVal Value As Boolean)
                locked1 = Value
            End Set
        End Property

        Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
            If Me.locked Then
                Return
            End If
            MyBase.OnMouseDown(e)
        End Sub 'OnMouseDown

#Region "ICalcData Members"


        Public Sub WireParentObject() Implements Syncfusion.Calculate.ICalcData.WireParentObject
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

                Dim val As String = Me(row + 1, col + 1).Text
                Dim e1 As New Syncfusion.Calculate.ValueChangedEventArgs(row + 1, col + 1, val)
                RaiseEvent ValueChanged(Me, e1)
            End If
        End Sub 'defaultView_ListChanged


        Private Sub dt_ColumnChanged(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
            Dim dt As DataTable = Me.DataSource '
            Me.changeCol = dt.Columns.IndexOf(e.Column)
        End Sub 'dt_ColumnChanged


        'One based:
        Public Function GetValueRowCol(ByVal row As Integer, ByVal col As Integer) As Object Implements Syncfusion.Calculate.ICalcData.GetValueRowCol
            Return Me(row, col).Text
        End Function 'GetValueRowCol


        'One based:
        Public Sub SetValueRowCol(ByVal value As Object, ByVal row As Integer, ByVal col As Integer) Implements Syncfusion.Calculate.ICalcData.SetValueRowCol
            Dim dt As DataTable = Me.DataSource '
            dt.Rows((row - 1))((col - 1)) = value
        End Sub 'SetValueRowCol

        Public Event ValueChanged As Syncfusion.Calculate.ValueChangedEventHandler Implements Syncfusion.Calculate.ICalcData.ValueChanged

#End Region
End Class 'CalcGridDataBoundGrid   
end Namespace 'GridDataBoundGridCalculator