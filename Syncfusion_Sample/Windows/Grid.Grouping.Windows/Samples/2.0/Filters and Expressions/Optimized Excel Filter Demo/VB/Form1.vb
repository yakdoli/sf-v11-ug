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
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid.Grouping

Namespace Optimized_Excel_Filter
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load_1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim count As Integer = 5000
			Dim childTable As DataTable
			Dim parentTable As DataTable = ProductSales.GetSalesData(count, childTable)
			Dim dset As New DataSet()
			dset.Tables.AddRange(New DataTable() { parentTable, childTable })
			dset.Relations.Add(New DataRelation("ParentToChild", parentTable.Columns("id"), childTable.Columns("parentID")))
			Me.gridGroupingControl1.DataSource = parentTable

			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Blue

			Me.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = True
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowFilterBar = True
			Me.gridGroupingControl1.ChildGroupOptions.ShowFilterBar = True

			Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.ChildGroupOptions.ShowCaption = False

			Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = False

			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
			For Each col As GridColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.Columns
				col.AllowFilter = True
			Next col

			Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor.Relations("ParentToChild").ChildTableDescriptor
			For Each col As GridColumnDescriptor In td.Columns
				col.AllowFilter = True
			Next col
			Me.gridGroupingControl1.TableDescriptor.Columns("ID").Width = 35
			Me.gridGroupingControl1.TableDescriptor.Columns("Quantity").Appearance.AnyRecordFieldCell.Format = "0.0"

			Me.gridGroupingControl1.OptimizeFilterPerformance = True
			Me.gridGroupingControl1.ShowNavigationBar = True

			filter.WireGrid(gridGroupingControl1)
			Me.DropShadow = True
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.propertyGrid1.BackColor = Color.White
			Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
			Me.gridGroupingControl1.AllowProportionalColumnSizing = True
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
		End Sub

		Private filter As New GridExcelFilter()
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			filter.ClearFilters(Me.gridGroupingControl1)
		End Sub


	End Class

	#Region "sample data"

	Public MustInherit Class ProductSales
		Public MustOverride Property Product() As String

		Public MustOverride Property [Date]() As String

		Public MustOverride Property Country() As String

		Public MustOverride Property State() As String

		Public MustOverride Property Quantity() As Integer

		Public MustOverride Property Amount() As Double

		Public MustOverride Property id() As Integer



		Public Shared Function GetSalesData(ByVal numberOfRecords As Integer, <System.Runtime.InteropServices.Out()> ByRef childTable As DataTable) As DataTable


'			#Region "implementation"

			''' Geography
			Dim countries() As String = { "Australia", "Canada", "France", "Germany", "United Kingdom", "United States" }
			Dim ausStates() As String = { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" }
			Dim canadaStates() As String = { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" }
			Dim franceStates() As String = { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers" }
			Dim germanyStates() As String = { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland" }
			Dim ukStates() As String = { "England" }
			Dim ussStates() As String = { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" }

			''' Time
			Dim dates() As String = { "FY 2005", "FY 2006", "FY 2007", "FY 2008", "FY 2009" }

			''' Products
			Dim products() As String = { "Bike", "Car" }

			childTable = New DataTable("Child")
			childTable.Columns.Add("ID")
			childTable.Columns.Add("Field2")
			childTable.Columns.Add("Field3")
			childTable.Columns.Add("parentID")

			Dim dt As New DataTable("Parent")
			dt.Columns.Add("ID")
			dt.Columns.Add("Date")
			dt.Columns.Add("Product")
			dt.Columns.Add("Country")
			dt.Columns.Add("State")
			dt.Columns.Add("Amount", GetType(Double))
			dt.Columns.Add("Quantity", GetType(Integer))

			Dim r As New Random(123345345)

			dt.BeginLoadData()

			For i As Integer = 0 To numberOfRecords - 1
				Dim dr As DataRow = dt.NewRow()
				dr("id") = i
				dr("Country") = countries(r.Next(1, countries.GetLength(0)))
				dr("Quantity") = r.Next(1, 12)

				dr("Amount") = (30000 * CInt(Fix(dr("Quantity"))))
				dr("Date") = dates(r.Next(r.Next(dates.GetLength(0) + 1)))
				dr("Product") = products(r.Next(r.Next(products.GetLength(0) + 1)))
				Select Case dr("Country").ToString()
					Case "Australia"
							dr("State") = ausStates(r.Next(ausStates.GetLength(0)))
							Exit Select
					Case "Canada"
							dr("State") = canadaStates(r.Next(canadaStates.GetLength(0)))
							Exit Select
					Case "France"
							dr("State") = franceStates(r.Next(franceStates.GetLength(0)))
							Exit Select
					Case "Germany"
							dr("State") = germanyStates(r.Next(germanyStates.GetLength(0)))
							Exit Select
					Case "United Kingdom"
							dr("State") = ukStates(r.Next(ukStates.GetLength(0)))
							Exit Select
					Case "United States"
							dr("State") = ussStates(r.Next(ussStates.GetLength(0)))
							Exit Select

				End Select

				dt.Rows.Add(dr)

				Dim rows As Integer = r.Next(10)

				For k As Integer = 0 To rows - 1
					Dim dr1 As DataRow = childTable.NewRow()
					dr1(0) = k
					dr1(1) = String.Format("F2_{0}", r.Next(3))
					dr1(2) = String.Format("F3_{0}", 100 + r.Next(3))
					dr1(3) = i
					childTable.Rows.Add(dr1)
				Next k

			Next i
			dt.EndLoadData()
'			#End Region

			Return dt
		End Function


		Public Overrides Function ToString() As String
			Return String.Format("{0}-{1}-{2}", Me.Country, Me.State, Me.Product)
		End Function

		Public Class ProductSalesCollection
			Inherits List(Of ProductSales)
		End Class
	End Class



	#End Region
End Namespace