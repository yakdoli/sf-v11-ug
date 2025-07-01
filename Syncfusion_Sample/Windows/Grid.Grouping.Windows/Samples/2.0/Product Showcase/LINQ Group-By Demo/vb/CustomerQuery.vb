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
Imports System.Text
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping

#End Region

Namespace LinqGroupBy
	Friend Class CustomerQuery
		Inherits SampleQuery
		#Region "Method"

		#Region "Override Method"

		Public Overrides Sub InitializeGrid(ByVal grid As GridGroupingControl, ByVal db As NorthwindwithImage)
			Dim customerQuery = From customer In db.Customers _
			                    Select customer

			Dim customerTotals = customerQuery.Count()

			Dim customerQueryResults As New PassThroughGroupingResult("Customer", customerQuery, GetType(Customers), customerTotals)

			grid.UseLazyUniformChildListRelation = True
			grid.DataSource = customerQueryResults

			' Clear out otherwise autopopulated UniformChildList relations
			' for Orders and CustomerCustomerDemos.
			'grid.TableDescriptor.Relations[1].ChildTableDescriptor.GroupedColumns.Add("Shipper_CompanyName");
			'grid.TableDescriptor.Relations[1].ChildTableDescriptor.GroupedColumns.Add("Employee_LastName");

			' Question: When consumer of customerQuery accesses nested lists such as Orders
			' will Linq fire a separate select statement or will they already
			' be in memory?

			grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords

		End Sub

		#End Region

		#End Region
	End Class
End Namespace
