Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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
Imports System.Data.EntityClient
Imports System.Data.Common
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports System.Linq
Imports System.IO
Imports System.Data.SqlClient
Imports Syncfusion.Windows.Forms.MetroForm
Imports Syncfusion.Grouping

Namespace Entity_Framework
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Partial Public Class Form1
        Inherits Syncfusion.Windows.Forms.MetroForm
        Private db As NorthwindGridEntities
        Private Shared ReadOnly str As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
        Public Shared ReadOnly conString As String = str
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("..\..\Icon\sfgrid1.ico"))
				Me.Icon = ico
			Catch
            End Try
            Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1

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

		''' <summary>
		''' Get the customer table from NorthWind database.
		''' </summary>
		''' <returns>Customers details.</returns>
		Private Function GetAllOrders() As IQueryable(Of Customers)
			Dim order = From o In db.Customers _
			            Order By o.CustomerID Ascending _
			            Select o
			Return order
		End Function

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


		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Try
				'Create a connection object for entity connection.
				Dim con As New EntityConnection("name=NorthwindGridEntities")
				con.StoreConnection.ConnectionString = conString
				db = New NorthwindGridEntities(con)
                Me.gridGroupingControl1.DataSource = db.Customers
				Me.gridGroupingControl1.TableDescriptor.Relations.Clear()
                Me.gridGroupingControl1.Engine.SourceListSet.Add(New SourceListSetEntry("Customers", GetAllCustomers().ToList().Cast(Of Customers)))
                Dim relation As New GridRelationDescriptor()
				relation.Name = "Customer"
				relation.ChildTableName = "Customers" ' SourceListSet name for lookup
				relation.RelationKind = RelationKind.RelatedMasterDetails
				relation.RelationKeys.Add("CustomerID", "CustomerID")
				'Add relation to parent table.
				Me.gridGroupingControl1.TableDescriptor.Relations.Add(relation)
			Catch e1 As SqlException
                Me.Close()
            Catch err As Exception
                MessageBox.Show("Error in Connection. " & err.Message)
                Application.Exit()
            End Try
		End Sub

		''' <summary>
		''' Create a method for exit in file menuitem.
		''' </summary>
        Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Application.Exit()
        End Sub
	End Class

End Namespace