#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.GridGroupingControl1.DataSource = GetTable()
			Me.GridGroupingControl1.ThemesEnabled = True
			'Error provider Properties
			Me.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = False
			Me.GridGroupingControl1.TableControl.CurrentCell.ShowErrorIcon = False
			Me.GridGroupingControl1.TableControl.CurrentCell.ShowErrorMessageBox = False
			Me.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = String.Empty
			Me.GridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.GridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			Me.textBox1.Enabled = False
			Me.textBox2.Enabled = False
			AddHandler GridGroupingControl1.TableControl.CurrentCellValidating, AddressOf GridGroupingControl1_CurrentCellValidating
			AddHandler GridGroupingControl1.TableControl.CurrentCellErrorMessage, AddressOf GridGroupingControl1_CurrentCellErrorMessage
		End Sub


		Private Sub GridGroupingControl1_CurrentCellErrorMessage(ByVal sender As Object, ByVal e As GridCurrentCellErrorMessageEventArgs)
			'   e.Cancel=true;
		End Sub

		Private Sub GridGroupingControl1_CurrentCellValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
			Dim output As Long
			If chkSetError.Checked Then
				Long.TryParse(Me.GridGroupingControl1.TableControl.CurrentCell.Renderer.ControlText, output)
				If Me.GridGroupingControl1.TableControl.CurrentCell.ColIndex = 1 AndAlso output > 5 Then
					If String.IsNullOrEmpty(textBox2.Text) Then
						Me.GridGroupingControl1.TableControl.CurrentCell.SetError("Please enter valid number")
					Else
						Me.GridGroupingControl1.TableControl.CurrentCell.SetError(textBox2.Text)
					End If

				End If
			End If
		End Sub

		Private Function GetTable() As DataTable
			Dim dt As New DataTable("MyTable")

			dt.Columns.Add(New DataColumn("S.NO", GetType(Integer)))
			dt.Columns.Add(New DataColumn("Date", GetType(DateTime)))
			dt.Columns.Add(New DataColumn("History", GetType(String)))
			For i As Integer = 1 To 14
				dt.Rows.Add(New Object() { i, DateTime.Today.AddDays(i), "Trader " & i })
			Next i

			Return dt
		End Function

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			If checkBox1.Checked Then
				Me.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = True
			Else
				Me.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = False
			End If
		End Sub

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
			If checkBox4.Checked Then
				Me.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = textBox1.Text
			Else
				Me.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = String.Empty
			End If
		End Sub



		Private Sub checkBox5_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles chkSetError.CheckStateChanged
			If chkSetError.Checked Then
				checkBox3.Checked = True
				textBox2.Enabled = True
			Else
				checkBox3.Checked = False
				textBox2.Enabled = False
			End If
		End Sub

		Private Sub checkBox4_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox4.CheckStateChanged
			If checkBox4.Checked Then
				checkBox3.Checked = True
				Me.textBox1.Enabled = True
			Else
				Me.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = String.Empty
				Me.textBox1.Clear()
				checkBox3.Checked = False
				Me.textBox1.Enabled = False
			End If
		End Sub

		Private Sub checkBox1_CheckedChanged_2(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckStateChanged
			If checkBox1.Checked Then
				Me.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = True
			Else
				Me.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = False
			End If
		End Sub

		Private Sub checkBox3_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox3.CheckStateChanged
			If checkBox3.Checked Then
				Me.GridGroupingControl1.TableControl.CurrentCell.ShowErrorMessageBox = True
			Else
				Me.GridGroupingControl1.TableControl.CurrentCell.ShowErrorMessageBox = False
			End If
		End Sub

		Private Sub checkBox2_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckStateChanged
			If checkBox2.Checked Then
				Me.GridGroupingControl1.TableControl.CurrentCell.ShowErrorIcon = True
			Else
				Me.GridGroupingControl1.TableControl.CurrentCell.ShowErrorIcon = False
			End If
		End Sub

		Private Sub textBox1_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.TextChanged
			Me.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = textBox1.Text
		End Sub
	End Class
End Namespace
