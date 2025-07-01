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
Imports Syncfusion.Windows.Forms
Imports System.Data.SqlServerCe
Imports System.Data.SqlClient
Imports System.IO
Imports System.Collections
Imports Syncfusion.Grouping

Namespace ExcelToolTip
	Partial Public Class Form1
		Inherits MetroForm
		Private commentMouseController As CommentMouseController
		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim ds As New DataSet()
			Dim commandstring As String = "select * from Customers"
			Dim connection As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
			Dim da As New SqlCeDataAdapter(commandstring, connection)
			Try
				da.Fill(ds, "Customers")
			Catch ex As SqlException
				MessageBox.Show(ex.ToString())
			End Try
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.gridGroupingControl1.DataSource = ds.Tables("Customers")

			' Commants insert based on RecordID and Column Name, Because Sorting and Grouping is supported in GridGroupingControl            
			Dim comments As New Hashtable()
			For Each rec As Record In Me.gridGroupingControl1.Table.Records
				Dim key As String = rec.Id & "CustomerID"
				comments.Add(key, rec.GetValue("ContactName"))
			Next rec

			'create the Comment mousecontroller.
			'commentMouseController = new CommentMouseController(gridGroupingControl1.TableControl);
			commentMouseController = New CommentMouseController(gridGroupingControl1.TableControl, comments)

			'allow context menu to edit/add comments
			commentMouseController.ContextMenuEnabled = True
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			'register the controller
			gridGroupingControl1.TableControl.MouseControllerDispatcher.Add(commentMouseController)
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
		Private Shared Function FindFile(ByVal fileName As String) As String
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
	End Class
End Namespace