#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region


#Region "Directives"
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports System.Collections

#End Region

Namespace LinqGroupBy
    Friend Class CustomerOrdersDetails : Inherits SampleQuery

#Region "Variable Declaration"

        Private db As NorthwindwithImage

#End Region

#Region "Method"

#Region "Override Method"

        Public Overrides Sub InitializeGrid(ByVal grid As GridGroupingControl, ByVal db As NorthwindwithImage)
            Me.db = db

            Dim customerQuery = From customer In db.Customers Select customer

            Dim customerTotals = customerQuery.Count()

            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords

            ' Pass in a sample query for determing optimal column widths.
            ' Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
            Dim customerSamples As IEnumerable = customerQuery.Take(10)
            Dim ordersSamples As IEnumerable = (From p In db.Orders Select p).Take(10)
            Dim orderDetailSamples As IEnumerable = (From p In db.OrderDetails Select p).Take(10)

            Dim customerQueryResults As PassThroughGroupingResult = New PassThroughGroupingResult("Customer", customerQuery, GetType(Customers), customerTotals, customerSamples)

            Dim orderResults As PassThroughGroupingResult = New PassThroughGroupingResult("Orders", New NestedQueryResultsDelegate(AddressOf Me.GetOrdersForCustomer), GetType(Orders), ordersSamples)

            Dim orderDetailResults As PassThroughGroupingResult = New PassThroughGroupingResult("OrderDetails", New NestedQueryResultsDelegate(AddressOf Me.GetOrderDetailForOrder), GetType(OrderDetails), orderDetailSamples)

            grid.SourceListSet.Add("Customer", customerQueryResults)
            grid.SourceListSet.Add("Orders", orderResults)
            grid.SourceListSet.Add("OrderDetail", orderDetailResults)

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

            Dim orderDetail As GridRelationDescriptor = New GridRelationDescriptor("OrderDetail")
            orderDetail.RelationKeys.Add("OrderID", "OrderID")
            orderDetail.ChildTableName = "OrderDetail"
            orderDetail.RelationKind = RelationKind.RelatedMasterDetails
            orderDetail.ChildTableDescriptor.Relations.Clear()
            Dim prizeAvgSummary As GridSummaryColumnDescriptor = New GridSummaryColumnDescriptor("PrizeAvgSummary", SummaryType.Custom, "UnitPrice", "{PrizeAvg:#.##}")
            orderDetail.ChildTableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("Row 1", prizeAvgSummary))
            orderDetail.ChildTableDescriptor.TopLevelGroupOptions.CaptionText = "{TableName}: {RecordCount} Items, Average UnitPrice is {Row 1.PrizeAvgSummary}"
            orders.ChildTableDescriptor.Relations.Add(orderDetail)
        End Sub

#End Region

#Region "Public Method"

        Public Function GetOrdersForCustomer(ByVal keys As Object(), <System.Runtime.InteropServices.Out()> ByRef totals As Object) As IEnumerable
            Dim orderQuery = From p In db.Orders Where p.CustomerID.Equals(keys(0)) Select p

            totals = orderQuery.Count()

            Return orderQuery
        End Function

        Public Function GetOrderDetailForOrder(ByVal keys As Object(), <System.Runtime.InteropServices.Out()> ByRef totals As Object) As IEnumerable
            Dim orderDetailQuery = From p In db.OrderDetails Where p.OrderID.Equals(keys(0)) Select p

            Dim gVal As Integer = 0
            totals = (From p In db.OrderDetails _
                Where p.OrderID.Equals(keys(0)) _
                Group p By k = 0 Into g = Group _
                Select New With {Key .Count = g.Count(), .PrizeAvg = g.Average(Function(p As OrderDetails) p.UnitPrice), .Details = g}).Single()

            Return orderDetailQuery
        End Function
#End Region

#End Region
    End Class
End Namespace
