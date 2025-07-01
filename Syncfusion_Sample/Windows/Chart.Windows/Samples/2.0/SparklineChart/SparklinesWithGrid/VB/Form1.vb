#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Syncfusion.Windows.Forms.Chart
Public Class Form1
    Private intArray(,) As Double
    Private sparkline(,) As Syncfusion.Windows.Forms.Chart.SparkLine = New Syncfusion.Windows.Forms.Chart.SparkLine(9, 2) {}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.gridControl1.Rows.DefaultSize = 35

        Me.gridControl1(0, 8).Text = "Line"
        Me.gridControl1(0, 9).Text = "Column"
        Me.gridControl1(0, 10).Text = "WinLoss"
        SparkLineSource()
    End Sub
   
    Private Sub SparkLineSource()
        Dim r As Random = New Random()

        Me.intArray = New Double(9, 6) {}

        For i As Integer = 0 To 9
            For j As Integer = 0 To 6
                Me.intArray(i, j) = r.Next(-50, 90)
            Next j
        Next i

        For i As Integer = 0 To 9
            For j As Integer = 0 To 6
                Me.gridControl1(i + 1, j + 1).CellValue = Me.intArray(i, j)
            Next j
        Next i

        For i As Integer = 0 To 9
            For j As Integer = 0 To 2
                sparkline(i, j) = New SparkLine()
            Next j
        Next i


        AddHandler gridControl1.PrepareViewStyleInfo, AddressOf gridControl1_PrepareViewStyleInfo
        Me.gridControl1.Refresh()
    End Sub
    Private Sub gridControl1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        Dim sourceItem() As Double = New Double(6) {}
        If e.ColIndex > 7 AndAlso e.RowIndex > 0 AndAlso e.RowIndex <= 10 Then
            For j As Integer = 0 To 6
                If Me.gridControl1(e.RowIndex, j + 1).CellValue.ToString() <> "" Then
                    sourceItem(j) = Convert.ToDouble(Me.gridControl1(e.RowIndex, j + 1).CellValue)
                End If
            Next j
            If e.ColIndex = 9 Then
                Me.sparkline(e.RowIndex - 1, e.ColIndex - 8).Type = SparkLineType.Column
            End If
            If e.ColIndex = 10 Then
                Me.sparkline(e.RowIndex - 1, e.ColIndex - 8).Type = SparkLineType.WinLoss
                Me.sparkline(e.RowIndex - 1, e.ColIndex - 8).Markers.ShowNegativePoint = True
            End If
            Me.sparkline(e.RowIndex - 1, e.ColIndex - 8).Source = sourceItem
            e.Style.CellType = "Control"
            e.Style.Control = Me.sparkline(e.RowIndex - 1, e.ColIndex - 8)
        End If
    End Sub

    Private Sub btnRandomData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandomData.Click
        SparkLineSource()
    End Sub
End Class
