Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2008"
'
'  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports System.Data.EntityClient
Imports System.IO
Imports System.Data.SqlClient
Imports System.Linq

Namespace Entity_FrameWork
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Partial Public Class Form1
		Inherits Office2007Form
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
				Me.Icon = ico
			Catch
			End Try
		End Sub

		''' <summary>
		''' Get the path of the icon file.
		''' </summary>
		''' <param name="bitmapName">IconFile name.</param>
		''' <returns>Icon file location.</returns>
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		''' <summary>
		''' Create a method for exit in file menuitem.
		''' </summary>
		Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles exitToolStripMenuItem.Click
			Application.Exit()
		End Sub

		''' <summary>
		''' Get the customer table from NorthWind database.
		''' </summary>
		''' <returns>Customers details.</returns>
		Private Function GetAllCustomers() As IQueryable(Of Customers)
			Dim customers = From c In db.Customers _
			                Select c
			Return customers
		End Function

		Private db As NorthwindGridEntities
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			'Get the path of the connecting databse.
            Dim conString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

			Try
				'Create a connection object for entity connection.
				Dim con As New EntityConnection("name=NorthwindGridEntities")
				con.StoreConnection.ConnectionString = conString
				db = New NorthwindGridEntities(con)
				Me.gridDataBoundGrid1.DataSource = db.Customers
				Me.gridDataBoundGrid1.Binder.EnableAddNew = False
			Catch e1 As SqlException
                Me.Close()
            Catch err As Exception
                MessageBox.Show("Error in Connection. " & err.Message)
                Application.Exit()
            End Try
            Dim colcount As Integer = Me.gridDataBoundGrid1.Model.ColCount
            Me.gridDataBoundGrid1.Model.HideCols(colcount - 1) = True
            Me.gridDataBoundGrid1.Model.HideCols(colcount) = True
			AddHandler gridDataBoundGrid1.PrepareViewStyleInfo, AddressOf gridDataBoundGrid1_PrepareViewStyleInfo
			Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.SingleClick
		End Sub

		''' <summary>
		''' To set the backcolor of the grid.
		''' </summary>
		Private Sub gridDataBoundGrid1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
			If e.RowIndex > 0 AndAlso e.RowIndex Mod 2 = 0 Then
				e.Style.BackColor = Color.PaleTurquoise
			End If
		End Sub

		''' <summary>
		''' Get the path of image file.
		''' </summary>
		''' <param name="bitmapName">ImageFile name.</param>
		''' <returns>ImageFile location.</returns>
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
	End Class
End Namespace