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
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms
Imports System.Data.Linq
Imports System.Data.SqlClient
Imports LINQToSQLCE
Imports Syncfusion.Windows.Forms.Grid

#End Region

Namespace LINQToSQL
	Partial Public Class Form1
		Inherits MetroForm
		#Region "Event Handler"

		Public Sub New()
			InitializeComponent()
			Me.gridGroupingControl1.DataSource = bindingSource1
			Me.comboBoxAdv1.DataSource = CreateTable()
			Me.comboBoxAdv1.DisplayMember = "BindingType"
			Me.comboBoxAdv1.ValueMember = "Id"
			Me.comboBoxAdv1.SelectedIndex = 0
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
			Me.SetStyle(ControlStyles.UserPaint, True)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			GridIntializationSettings()
		End Sub

		Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv1.SelectedIndexChanged
			Select Case Me.comboBoxAdv1.SelectedIndex
				Case 0
					'ListItemReference
					SetDataSource("ListItemReference")
				Case 1
					'MasterDetail/UniformChildList
					'MasterDetail_CustomerOrders
					SetDataSource("MasterDetail_CustomerOrders")
				Case 2
					'ManyToMany
					SetDataSource("ManyToMany")
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
		Private Function CreateTable() As DataTable
			Dim dt As New DataTable()
			dt.Columns.Add("BindingType")
			dt.Columns.Add("Id")
			dt.Rows.Add("ListItemReference", 0)
			dt.Rows.Add("MasterDetail/UniformChildList (CustomerOrders)", 1)
			dt.Rows.Add("ManyToMany (EmployeeDetails)", 2)
			Return dt
		End Function

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		Private Sub SetDataSource(ByVal queryType As String)
			Dim query As IQueryable

			Try

				query = SetDataSource(queryType, New LINQToSQLCE.NorthwindGrid("Data Source=" & FindFile("NorthwindGrid.sdf")))

				Me.gridGroupingControl1.UseLazyUniformChildListRelation = True
				Cursor.Current = Cursors.WaitCursor
				Me.gridGroupingControl1.SuspendLayout()
				Me.gridGroupingControl1.ResetTableDescriptor()
				Me.gridGroupingControl1.TableDescriptor.ResetRelations()
				gridGroupingControl1.BeginUpdate()
				bindingSource1.DataSource = query
				Me.gridGroupingControl1.TableDescriptor.EnableOneTimePopulate()
				gridGroupingControl1.EndUpdate(True)
				Me.gridGroupingControl1.ResumeLayout(True)
				Cursor.Current = Cursors.Default
			Catch ex As SqlException
				ShowErrorMessage(ex)
				Me.Close()
			End Try

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

		'If SQL Express Server not installed then go for Compact SQL Server file.
		Private Function SetDataSource(ByVal queryType As String, ByVal db As LINQToSQLCE.NorthwindGrid) As IQueryable
			' db.Connection.ConnectionString = "Data Source=" + FindFile("NorthwindGrid.sdf");

			Dim query As IQueryable
			Select Case queryType
				Case "ListItemReference"
					query = From p In db.Products _
					        Order By p.ProductName Ascending _
					        Select p

				Case "MasterDetail_CustomerOrders"
					query = From cust In db.Customers _
					        Order By cust.CompanyName _
					        Select cust
				Case "ManyToMany"
					query = From emp In db.Employees _
					        Select New EmployeeInfo With {.ID = emp.EmployeeID, .Name = emp.FirstName & " " & emp.LastName, .Title = emp.Title, .Address = emp.Address, .TerritoryRegion = ( _
					                From terri In db.Territories _
					                Join empterri In db.EmployeeTerritories On terri.TerritoryID Equals empterri.TerritoryID _
					                Where empterri.EmployeeID.Equals(emp.EmployeeID) _
					                Select New TerritoryRegion With {.TerritoryID = terri.TerritoryID, .TerritoryDescription = terri.TerritoryDescription, .RegionID = terri.Region.RegionID, .RegionDescription = terri.Region.RegionDescription}).ToList()}

				Case Else
					'Using Extension Methods and Lambda Expression.
					query = db.Customers.OrderBy(Function(cust) cust.CustomerID)
			End Select

			Return query
		End Function

		#End Region

	End Class
End Namespace
