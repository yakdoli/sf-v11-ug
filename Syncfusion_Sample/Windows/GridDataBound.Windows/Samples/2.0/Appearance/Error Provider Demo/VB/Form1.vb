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
		Inherits Form
		Public Sub New()
			InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
                Me.Icon = ico
            Catch ex As Exception
            End Try
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.GridDataBoundGrid1.DataSource = GetTable()
			Me.GridDataBoundGrid1.ThemesEnabled = True
			'Error provider Properties
			Me.GridDataBoundGrid1.ShowRowHeaderErroricon = False
			Me.GridDataBoundGrid1.CurrentCell.ShowErrorIcon = False
			Me.GridDataBoundGrid1.CurrentCell.ShowErrorMessageBox = False
			Me.GridDataBoundGrid1.CurrentCell.ValidationErrorText = String.Empty
            Me.GridDataBoundGrid1.DefaultColWidth = 150
            Me.GridDataBoundGrid1.AllowResizeToFit = False
            textBox2.Enabled = False
            textBox1.Enabled = False
			AddHandler GridDataBoundGrid1.CurrentCellValidating, AddressOf GridDataBoundGrid1_CurrentCellValidating
			AddHandler GridDataBoundGrid1.CurrentCellErrorMessage, AddressOf GridDataBoundGrid1_CurrentCellErrorMessage
		End Sub


		Private Sub GridDataBoundGrid1_CurrentCellErrorMessage(ByVal sender As Object, ByVal e As GridCurrentCellErrorMessageEventArgs)
			'   e.Cancel=true;
		End Sub

		Private Sub GridDataBoundGrid1_CurrentCellValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
			Dim output As Long
            If chkSetError.Checked Then
                Long.TryParse(Me.GridDataBoundGrid1.CurrentCell.Renderer.ControlText, output)
                If Me.GridDataBoundGrid1.CurrentCell.ColIndex = 1 AndAlso output > 5 Then
                    If String.IsNullOrEmpty(textBox2.Text) Then
                        Me.GridDataBoundGrid1.CurrentCell.SetError("Please enter valid number")
                    Else
                        Me.GridDataBoundGrid1.CurrentCell.SetError(textBox2.Text)
                    End If

                End If
            End If
        End Sub

        Private Function GetTable() As DataTable
            Dim dt As New DataTable("MyTable")

            dt.Columns.Add(New DataColumn("S.NO", GetType(Integer)))
            dt.Columns.Add(New DataColumn("Date", GetType(DateTime)))
            dt.Columns.Add(New DataColumn("History", GetType(String)))
            For i As Integer = 0 To 4
                dt.Rows.Add(New Object() {i, DateTime.Today, "Trader"})
            Next i

            Return dt
        End Function

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBox1.Checked Then
                Me.GridDataBoundGrid1.ShowRowHeaderErroricon = True
            Else
                Me.GridDataBoundGrid1.ShowRowHeaderErroricon = False
            End If
        End Sub

        Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
            If checkBox4.Checked Then
                Me.GridDataBoundGrid1.CurrentCell.ValidationErrorText = textBox1.Text
            Else
                Me.GridDataBoundGrid1.CurrentCell.ValidationErrorText = String.Empty
            End If
        End Sub



        Private Sub checkBox5_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles chkSetError.CheckedChanged
            If chkSetError.Checked Then
                checkBox3.Checked = True
                textBox2.Enabled = True
            Else
                checkBox3.Checked = False
                textBox2.Enabled = False
            End If
        End Sub

		Private Sub checkBox4_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckedChanged
            If checkBox4.Checked Then
                checkBox3.Checked = True
                textBox1.Enabled = True
            Else
                Me.GridDataBoundGrid1.CurrentCell.ValidationErrorText = String.Empty
                textBox1.Clear()
                checkBox3.Checked = False
                textBox1.Enabled = False
            End If
		End Sub

		Private Sub checkBox1_CheckedChanged_2(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			If checkBox1.Checked Then
				Me.GridDataBoundGrid1.ShowRowHeaderErroricon = True
			Else
				Me.GridDataBoundGrid1.ShowRowHeaderErroricon = False
			End If
		End Sub

		Private Sub checkBox3_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckedChanged
			If checkBox3.Checked Then
				Me.GridDataBoundGrid1.CurrentCell.ShowErrorMessageBox = True
			Else
				Me.GridDataBoundGrid1.CurrentCell.ShowErrorMessageBox = False
			End If
		End Sub

		Private Sub checkBox2_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckedChanged
			If checkBox2.Checked Then
				Me.GridDataBoundGrid1.CurrentCell.ShowErrorIcon = True
			Else
				Me.GridDataBoundGrid1.CurrentCell.ShowErrorIcon = False
			End If
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

        Private Sub textBox1_TextChanged_1(sender As System.Object, e As System.EventArgs) Handles textBox1.TextChanged
            Me.GridDataBoundGrid1.CurrentCell.ValidationErrorText = textBox1.Text
        End Sub
    End Class
End Namespace
