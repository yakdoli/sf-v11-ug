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
	Friend Class CustomerOrdersGroupedByShippers
		Inherits SampleQuery
		#Region "Variable Declaration"

		Private db As NorthwindwithImage

		#End Region

		#Region "Method"

		#Region "Override Method"

		Public Overrides Sub InitializeGrid(ByVal grid As GridGroupingControl, ByVal db As NorthwindwithImage)
            Me.db = db

            Dim customerQuery = From customer In db.Customers Group customer By key = customer.Country Into Group Select New With { _
                                        Key .Key = key, .Count = Group.Count(), .Details = Group}

            Dim customerTotals = customerQuery.Count()

            ' Pass in a sample query for determing optimal column widths.
            ' Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
            Dim customerSampleQuery = From c In db.Customers Select c

            Dim customerQueryResults As PassThroughGroupingResult = New PassThroughGroupingResult("Customer", customerQuery, GetType(Customers), customerTotals, customerSampleQuery.Take(10), "Country")

            Dim orderSampleQuery = From p In db.Orders Select p

            Dim orderResults As PassThroughGroupingResult = New PassThroughGroupingResult("Orders", New NestedQueryResultsDelegate(AddressOf Me.GetOrdersForCustomerGroupedByShippers), GetType(Orders), orderSampleQuery.Take(10), "Shipper_CompanyName")

            grid.SourceListSet.Add("Customer", customerQueryResults)
            grid.SourceListSet.Add("Orders", orderResults)
            'grid.SourceListSet.ClearAllWhenEngineSourceListChanged = false;
            grid.DataSource = customerQueryResults

            ' Clear out otherwise autopopulated UniformChildList relations
            ' for Orders and CustomerCustomerDemos.
            grid.TableDescriptor.Relations.Clear()

            Dim orders As GridRelationDescriptor = New GridRelationDescriptor("Orders")
            orders.RelationKeys.Add("CustomerID", "CustomerID")
            orders.ChildTableName = "Orders"
            orders.RelationKind = RelationKind.RelatedMasterDetails
            orders.ChildTableDescriptor.Relations.Clear()

            grid.TableDescriptor.Relations.Add(orders)

            ' Question: When consumer of customerQuery accesses nested lists such as Orders
            ' will Linq fire a separate select statement or will they already
            ' be in memory?

            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords

        End Sub


        Public Function GetOrdersForCustomerGroupedByShippers(ByVal keys As Object(), <System.Runtime.InteropServices.Out()> ByRef totals As Object) As IEnumerable
            Dim orderQuery = From p In db.Orders Where p.CustomerID.Equals(keys(0)) _
    Group p By key = p.ShipAddress Into Group Select New _
    With {.Count = Group.Count(), .Details = Group}

            totals = (From p In db.Orders Where p.CustomerID.Equals(keys(0)) Group p By k = 0 Into g = Group _
                      Select New With {Key .Count = g.Count()}).Single()

            Return orderQuery
        End Function

		#End Region

		#End Region

	End Class
End Namespace
