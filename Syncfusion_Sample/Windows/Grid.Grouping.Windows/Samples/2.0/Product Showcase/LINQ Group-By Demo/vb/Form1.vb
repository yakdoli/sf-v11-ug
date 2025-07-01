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
Imports System.Linq
Imports System.Windows.Forms

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports System.Data.SqlClient
Imports System.IO
Imports Syncfusion.Windows.Forms
Imports System.Data
Imports System.Drawing
Imports Syncfusion.Windows.Forms.Grid
#End Region

Namespace LinqGroupBy
	Partial Public Class Form1
		Inherits MetroForm
		#Region "Variable declaration"

		Private db As NorthwindwithImage
		Public ReadOnly Shared conString As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")

		#End Region

		#Region "Event handler"

		Public Sub New()

			InitializeComponent()

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
            End Try
			
			AddHandler comboBoxAdv1.SelectedIndexChanged, AddressOf comboBoxAdv1_SelectedIndexChanged
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
		End Sub

		Private Sub aboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim abtform As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			abtform.ShowDialog()
		End Sub

		Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Me.Close()
		End Sub

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)


			Try
				db = New NorthwindwithImage(conString)

				Dim sq As SampleQuery = New LinqGroupBy.CustomerQuery()
				sq.InitializeGrid(gridGroupingControl1, db)

				MyBase.OnLoad(e)
			Catch ex As SqlException
				ShowErrorMessage(ex)
				Me.Close()
			End Try

		End Sub

		Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Select Case Me.comboBoxAdv1.SelectedIndex
				Case 0
					ResetGrid(New CustomerQuery())
				Case 1
					ResetGrid(New CustomerOrders())
				Case 2
					ResetGrid(New CustomerOrdersDetails())
				Case 3
					ResetGrid(New CustomerOrdersGroupedByShippers())
				Case 4
					ResetGrid(New ProductsGroupedBySupplier())
				Case 5
					ResetGrid(New ProductsGroupedBySupplierAndCategory())
			End Select
		End Sub

		#End Region       

		#Region "Method"

		Private Sub GridIntializationSettings()
			Me.gridGroupingControl1.BeginUpdate()
			Me.gridGroupingControl1.TableModel.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
			Me.gridGroupingControl1.Table.TableOptions.RecordRowHeight = 22
			Me.gridGroupingControl1.Table.TableOptions.ColumnHeaderRowHeight = 22
			Me.gridGroupingControl1.Table.TableOptions.CaptionRowHeight = 22
			Me.gridGroupingControl1.EndUpdate(True)
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

		Private Sub ResetGrid(ByVal sq As SampleQuery)
			 gridGroupingControl1.DataSource = Nothing
			 sq.InitializeGrid(gridGroupingControl1, db)
		End Sub

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

		#End Region

	End Class

End Namespace
