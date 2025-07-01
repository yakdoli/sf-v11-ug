#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
#Region "Directives"

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms

#End Region

Namespace FindReplace
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()

'			#Region "Icon Settings"
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

'			#End Region

'			#Region "General"
			Me.gridGroupingControl1.DataSource = GetADataTable()
			Me.SetStyle(ControlStyles.UserPaint, True)
'			#End Region
		End Sub



		#Region "HelperClass [Icon]"

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function




		#End Region

		#Region "Find and Replace"

		#Region "EventHandlers"

		Private Sub gridGroupingControl1_TableControlCurrentCellKeyDown(ByVal sender As Object, ByVal e As GridTableControlKeyEventArgs) Handles gridGroupingControl1.TableControlCurrentCellKeyDown

			If e.Inner.Control Then
				If e.Inner.KeyCode = Keys.F OrElse e.Inner.KeyCode = Keys.H Then
					Dim f As New GridFindReplaceDialog(Me.gridGroupingControl1, "Metro")
					f.ShowDialog()
				End If
			End If
		End Sub
		#End Region

		#Region "DataTable"
		Private Function GetADataTable() As DataTable

			Dim dt As New DataTable("MyTable")

			Dim nCols As Integer = 20
			Dim nRows As Integer = 25

			For i As Integer = 0 To nCols - 1
				dt.Columns.Add(New DataColumn(String.Format("Col{0}", i)))
			Next i

			Dim rand As New Random()

			For i As Integer = 0 To nRows - 1
				Dim dr As DataRow = dt.NewRow()
				For j As Integer = 0 To nCols - 1
					dr(j) = rand.Next(100)
				Next j
				dt.Rows.Add(dr)
			Next i
			Return dt

		End Function
		#End Region

		#End Region

	End Class
End Namespace