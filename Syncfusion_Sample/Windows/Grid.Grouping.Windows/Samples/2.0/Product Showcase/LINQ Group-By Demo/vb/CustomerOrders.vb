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
Imports System.Collections

#End Region

Namespace LinqGroupBy
	Friend Class CustomerOrders
		Inherits SampleQuery
		#Region "Variable Declaration"

		Private db As NorthwindwithImage

		#End Region

		#Region "Method"

		#Region "Override Method"

		Public Overrides Sub InitializeGrid(ByVal grid As GridGroupingControl, ByVal db As NorthwindwithImage)
			Me.db = db

			Dim customerQuery = From customer In db.Customers _
			                    Select customer

			Dim customerTotals = customerQuery.Count()

			grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords

			' Pass in a sample query for determing optimal column widths.
			' Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
			Dim customerSamples As IEnumerable = customerQuery.Take(10)
			Dim ordersSamples As IEnumerable = ( _
			    From p In db.Orders _
			    Select p).Take(10)

			Dim customerQueryResults As New PassThroughGroupingResult("Customer", customerQuery, GetType(Customers), customerTotals, customerSamples, New UpdateHelper())

			Dim orderResults As New PassThroughGroupingResult("Orders", New NestedQueryResultsDelegate(AddressOf Me.GetOrdersForCustomer), GetType(Orders), ordersSamples)

			grid.SourceListSet.Add("Customer", customerQueryResults)
			grid.SourceListSet.Add("Orders", orderResults)

			grid.DataSource = customerQueryResults

			' Clear out otherwise autopopulated UniformChildList relations
			' for Orders and CustomerCustomerDemos.
			grid.TableDescriptor.Relations.Clear()

			Dim orders As New GridRelationDescriptor("Orders")
			orders.RelationKeys.Add("CustomerID", "CustomerID")
			orders.ChildTableName = "Orders"
			orders.RelationKind = RelationKind.RelatedMasterDetails
			orders.ChildTableDescriptor.Relations.Clear()

			grid.TableDescriptor.Relations.Add(orders)

			' Question: When consumer of customerQuery accesses nested lists such as Orders
			' will Linq fire a separate select statement or will they already
			' be in memory?
		End Sub

		#End Region

		#Region "Public Method"
		Public Function GetOrdersForCustomer(ByVal keys() As Object, <System.Runtime.InteropServices.Out()> ByRef totals As Object) As IEnumerable
			Dim orderQuery = From p In db.Orders _
			                 Where p.CustomerID.Equals(keys(0)) _
			                 Select p

			totals = orderQuery.Count()

			Return orderQuery
		End Function

		#End Region
		#End Region

		Public Class UpdateHelper
			Implements IRecordUpdateHelper
			#Region "IRecordUpdateHelper Members"

			Public Function CanSaveRecord(ByVal item As Object) As Boolean Implements IRecordUpdateHelper.CanSaveRecord
				Return True
			End Function

			Public Sub SaveRecord(ByVal item As Object, ByVal table As Table) Implements IRecordUpdateHelper.SaveRecord

			End Sub

			Public Sub AddRecord(ByVal item As Object, ByVal table As Table) Implements IRecordUpdateHelper.AddRecord
				Console.WriteLine(table.CurrentRecord)
			End Sub

			Public Function DeleteRecord(ByVal item As Object, ByVal table As Table) As Boolean Implements IRecordUpdateHelper.DeleteRecord
				Return False
			End Function

			#End Region
		End Class

	End Class
End Namespace
