Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms

Namespace HideRowCols
    Partial Public Class Form1 : Inherits MetroForm
        Private visibleColCount, visibleRowCount As Integer

        Public Sub New()
            InitializeComponent()

            Me.gridControl1.BeginUpdate()

            ' 2500 x 2500 grid
            Me.gridControl1.ColCount = 2500
            visibleColCount = Me.gridControl1.ColCount

            Me.gridControl1.RowCount = 2500
            visibleRowCount = Me.gridControl1.RowCount

            ' Fill the grid
            Dim n As Integer = 0

            Do While n < gridControl1.ColCount
                Dim style As GridStyleInfo = New GridStyleInfo()
                style.CellValue = n + 1
                Dim i As Integer = 0

                Do While i < gridControl1.RowCount
                    Me.gridControl1.SetCellInfo(i + 1, n + 1, style, StyleModifyType.Copy, True, True)
                    i += 1
                Loop
                n += 1
            Loop

            Me.gridControl1.ListBoxSelectionMode = SelectionMode.One
            gridControl1.CurrentCell.MoveTo(1, 1)
            Me.gridControl1.EndUpdate()

            Me.label1.Text = "    Row Count: " & (Me.gridControl1.RowCount) & ";       Col Count: " & (Me.gridControl1.ColCount)
           
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
        End Sub

        Private Function GetIconFile(ByVal bitmapName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(bitmapName) Then
                    Return bitmapName
                End If

                bitmapName = "..\" & bitmapName
            Next n

            Return bitmapName
        End Function


#Region "Event Handlers"

        Private flag As Boolean = True
        Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
            If flag Then
                Me.gridControl1.HideCols.SetRange(1, CInt(upDownCol.Value), True)
                Me.gridControl1.HideRows.SetRange(1, CInt(upDownRow.Value), True)
                Me.gridControl1.CurrentCell.MoveTo(CInt(upDownRow.Value) + 1, CInt(upDownCol.Value) + 1)
                flag = False
                Me.upDownRow.Enabled = False
                Me.upDownCol.Enabled = False

                btnHide.Text = "Show Hidden Rows and Columns"
                Me.label1.Text = "    Row Count: " & (gridControl1.RowCount - upDownRow.Value) & ";  " + vbCr + vbLf + vbCr + vbLf + " Col Count: " & (gridControl1.ColCount - upDownCol.Value)
            Else
                Me.gridControl1.HideCols.SetRange(1, CInt(upDownCol.Value), False)
                Me.gridControl1.HideRows.SetRange(1, CInt(upDownRow.Value), False)
                Me.gridControl1.CurrentCell.MoveTo(1, 1)
                Me.gridControl1.ScrollCellInView(1, 1, GridScrollCurrentCellReason.MoveTo)
                Me.upDownCol.Value = 0
                Me.upDownRow.Value = 0
                flag = True
                Me.upDownRow.Enabled = True
                Me.upDownCol.Enabled = True
                btnHide.Text = "Hide Rows and Columns"
                Me.label1.Text = "    Row Count: " & (gridControl1.RowCount - upDownRow.Value) & ";    Col Count: " & (gridControl1.ColCount - upDownCol.Value)
            End If
            Me.gridControl1.Refresh()
        End Sub
#End Region
    End Class
End Namespace