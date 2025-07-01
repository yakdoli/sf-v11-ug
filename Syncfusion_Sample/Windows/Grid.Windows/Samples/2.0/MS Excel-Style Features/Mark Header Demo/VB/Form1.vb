Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports System.Collections
Imports System.Collections.Specialized
Imports System.IO
Imports System.Data.SqlServerCe
Imports System.Data.SqlClient
Imports Syncfusion.Windows.Forms.Grid

Namespace MarkHeaderDemo_2008
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()

			Dim r As New Random()
			InitializeComponent()

'			#Region "GridControl"
			Dim commandstring1 As String = "select * from Customers"
			Dim ds As New DataSet1()
			Me.gridControl1.ColCount = 10
			Dim da1 As New SqlCeDataAdapter(commandstring1, connString)
			Try
				da1.Fill(ds, "Customers")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try
			For i As Integer = 1 To Me.gridControl1.RowCount
				For j As Integer = 1 To Me.gridControl1.ColCount
					Me.gridControl1(i, j).CellValue = ds.Tables("Customers").Rows(i)(j-1).ToString()
				Next j
			Next i
			For j As Integer = 1 To Me.gridControl1.ColCount
				Me.gridControl1(0, j).Text = ds.Tables("Customers").Columns(j-1).ColumnName
			Next j
			Me.gridControl1.Model.ColWidths.ResizeToFitOptimized(GridRangeInfo.Table(), GridResizeToFitOptions.NoShrinkSize)
			Me.gridControl1.Refresh()

'			#End Region         

            Me.comboBox1.Text = "Both"
			Me.gridControl1.MarkColHeader = True
			Me.gridControl1.MarkRowHeader = True
			Me.comboBox2.Text = "Metro"
			Me.DropShadow = True
			Me.DropShadow = True
			AddHandler comboBox1.SelectedIndexChanged, AddressOf comboBox1_SelectedIndexChanged
			AddHandler comboBox1.SelectedIndexChanged, AddressOf comboBox1_SelectedIndexChanged
        End Sub
		Public ReadOnly Shared connString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

		Private Shared Function FindFile(ByVal fileName As String) As String
			' Check both in parent folder and Parent\Data folders.
			Dim dataFileName As String = "Common\Data\" & fileName
			For n As Integer = 0 To 11
				If System.IO.File.Exists(fileName) Then
					Return New FileInfo(fileName).FullName
				End If
				If System.IO.File.Exists(dataFileName) Then
					Return New FileInfo(dataFileName).FullName
				End If
				fileName = "..\" & fileName
				dataFileName = "..\" & dataFileName
			Next n

			Return fileName
		End Function

		Private Shared Sub ShowErrorMessage(ByVal ex As SqlException)
			If ex.Number = 11001 Then
				MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 208 Then
				MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 156 OrElse ex.Number = 102 Then
				MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If

		End Sub

		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
		   Select Case comboBox2.Text
			   Case "Metro"
				   Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
                Case "Office2010Blue"
                    Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Blue
                    Me.gridControl1.GridOfficeScrollBars = OfficeScrollBars.Office2010
                    Me.gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue
			   Case "Office2010Black"
				   Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Black
				   Me.gridControl1.GridOfficeScrollBars = OfficeScrollBars.Office2010
				   Me.gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black
			   Case "Office2010Silver"
				   Me.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Silver
				   Me.gridControl1.GridOfficeScrollBars = OfficeScrollBars.Office2010
				   Me.gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver
		   End Select
		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Select Case comboBox1.Text
				Case "Both"
					Me.gridControl1.MarkColHeader = True
					Me.gridControl1.MarkRowHeader = True
				Case "RowHeader"
					Me.gridControl1.MarkColHeader = False
					Me.gridControl1.MarkRowHeader = True
				Case "ColHeader"
					Me.gridControl1.MarkColHeader = True
					Me.gridControl1.MarkRowHeader = False
			End Select

		End Sub
	End Class
End Namespace
