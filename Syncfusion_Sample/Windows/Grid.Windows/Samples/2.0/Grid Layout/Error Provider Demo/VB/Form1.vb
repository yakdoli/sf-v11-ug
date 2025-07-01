Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace ErrorProvider
	Partial Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "EventHandlers"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.gridControl1.Model.PopulateValues(GridRangeInfo.Cells(1, 1, 5, 5), GetTable())
			Me.gridControl1.ColStyles(1).CellValueType = GetType(Int32)
			Me.gridControl1.ColStyles(2).CellValueType = GetType(DateTime)
			Me.gridControl1.ColCount = 3
			Me.gridControl1.RowCount = 6
			Me.gridControl1.ThemesEnabled = True
			'Error provider Properties
			Me.gridControl1.ShowRowHeaderErroricon = False
			Me.gridControl1.CurrentCell.ShowErrorIcon = False
			Me.gridControl1.CurrentCell.ShowErrorMessageBox = False
			Me.gridControl1.CurrentCell.ValidationErrorText = String.Empty
			textBox2.Enabled = False
			textBox1.Enabled = False
			AddHandler gridControl1.CurrentCellValidating, AddressOf gridControl1_CurrentCellValidating
			AddHandler gridControl1.CurrentCellErrorMessage, AddressOf gridControl1_CurrentCellErrorMessage
			Me.gridControl1.RefreshCurrentCellBehavior = GridRefreshCurrentCellBehavior.RefreshRow
			AddHandler gridControl1.KeyUp, AddressOf gridControl1_KeyUp
		End Sub

        Private Sub checkBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox1.CheckedChanged
            If checkBox1.Checked Then
                Me.gridControl1.ShowRowHeaderErroricon = True
            Else
                Me.gridControl1.ShowRowHeaderErroricon = False
            End If
        End Sub

        Private Sub chkValidate_CheckedChanged(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles chkValidate.CheckedChanged
            If chkValidate.Checked Then
                checkBox3.Checked = True
                textBox1.Enabled = True
            Else
                Me.gridControl1.CurrentCell.ValidationErrorText = String.Empty
                checkBox3.Checked = False
                textBox1.Enabled = False
                textBox1.Clear()
            End If
        End Sub

        Private Sub chkSetError_CheckedChanged(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles chkSetError.CheckedChanged
            If chkSetError.Checked Then
                checkBox3.Checked = True
                textBox2.Enabled = True
            Else
                checkBox3.Checked = False
                textBox2.Enabled = False
            End If
        End Sub

        Private Sub checkBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox2.CheckedChanged
            If checkBox2.Checked Then
                Me.gridControl1.CurrentCell.ShowErrorIcon = True
            Else
                Me.gridControl1.CurrentCell.ShowErrorIcon = False
            End If
        End Sub

		Private Sub gridControl1_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
			Me.gridControl1.RefreshRange(GridRangeInfo.Row(Me.gridControl1.CurrentCell.RowIndex))
		End Sub

		Private Sub gridControl1_CurrentCellErrorMessage(ByVal sender As Object, ByVal e As GridCurrentCellErrorMessageEventArgs)
			Me.gridControl1.RefreshRange(GridRangeInfo.Row(Me.gridControl1.CurrentCell.RowIndex))
		End Sub

		Private Sub gridControl1_CurrentCellValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
			Dim output As Long
			If chkSetError.Checked Then
				Long.TryParse(Me.gridControl1.CurrentCell.Renderer.ControlText, output)
				If Me.gridControl1.CurrentCell.ColIndex = 1 AndAlso output > 5 Then
					If String.IsNullOrEmpty(textBox2.Text) Then
						Me.gridControl1.CurrentCell.SetError("Please enter valid number")
					Else
						Me.gridControl1.CurrentCell.SetError(textBox2.Text)
					End If

				End If
			End If
        End Sub

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			If chkValidate.Checked Then
				Me.gridControl1.CurrentCell.ValidationErrorText = textBox1.Text
			Else
				Me.gridControl1.CurrentCell.ValidationErrorText = String.Empty
			End If
        End Sub

        Private Sub checkBox1_CheckedChanged_2(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox3.CheckedChanged
            If checkBox1.Checked Then
                Me.gridControl1.ShowRowHeaderErroricon = True
            Else
                Me.gridControl1.ShowRowHeaderErroricon = False
            End If
        End Sub

        Private Sub checkBox3_CheckedChanged_1(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles checkBox3.CheckedChanged
            If checkBox3.Checked Then
                Me.gridControl1.CurrentCell.ShowErrorMessageBox = True
            Else
                Me.gridControl1.CurrentCell.ShowErrorMessageBox = False
            End If
        End Sub

		Private Sub textBox1_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.TextChanged
			Me.gridControl1.CurrentCell.ValidationErrorText = textBox1.Text
		End Sub
		#End Region

		#Region "Method"
		Private Function GetTable() As DataTable
			Dim dt As New DataTable("MyTable")

			dt.Columns.Add(New DataColumn("S.NO"))
			dt.Columns.Add(New DataColumn("Date"))
			dt.Columns.Add(New DataColumn("History"))
			For i As Integer = 0 To 9
				dt.Rows.Add(New Object() { i, DateTime.Today, "Trader" })
			Next i

			Return dt
		End Function
#End Region
    End Class
End Namespace
