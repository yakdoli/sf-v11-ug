#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
#Region "Directives"

Imports System.Linq
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports System.Collections

#End Region

Namespace LinqGroupBy
    Friend Class ProductsGroupedBySupplier : Inherits SampleQuery		

		#Region "Method"

		#Region "Override Method"

	 Public Overrides Sub InitializeGrid(ByVal grid As GridGroupingControl, ByVal db As NorthwindwithImage)
            Dim productQuery = From p In db.Products Group p By key = p.SupplierID Into Group _
                                      Select New With {Key .Key = key.Value, .Count = Group.Count(), .PrizeAvg = Group.Average(Function(p As Products) p.UnitPrice), .Details = Group}

            ' How to calculate aggregates for the whole query with C#?
            ' (see also ms-help://MS.VSCC.v90/MS.MSDNQTR.v90.en/dv_linq/html/36d97c83-5de5-457d-971d-10a69365e7c4.htm)
            ' It just says "not applicable" ?.? 
            ' So as a workaround, group by a constant and this will return one single group.
            Dim productTotalsQuery = From p In db.Products Group p By k = 0 Into g = Group _
                                            Select New With {Key .Count = g.Count(), .PrizeAvg = g.Average(Function(p As Products) p.UnitPrice)}
            Dim productTotals As Object = productTotalsQuery.Single()

            ' Pass in a sample query for determing optimal column widths.
            ' Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
            Dim productSampleQuery = From p In db.Products Select p

            grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords


            Dim productQueryResults As PassThroughGroupingResult = New PassThroughGroupingResult("Product", productQuery, GetType(Products), productTotals, productSampleQuery.Take(10), "Supplier")

            ' Summary that is retrieved from query
            Dim prizeAvgSummary As GridSummaryColumnDescriptor = New GridSummaryColumnDescriptor("PrizeAvgSummary", SummaryType.Custom, "UnitPrice", "{PrizeAvg:#.##}")

            ' Summary that is calculated by grid engine internal from populated records (but this one
            ' has limitation ... see comments below)
            Dim unitsInStockSummary As GridSummaryColumnDescriptor = New GridSummaryColumnDescriptor("UnitsSummary", SummaryType.Int32Aggregate, "UnitsInStock", "{Sum}")


            ' Note: UnitsSummary will only work for the group with the records. The parent groups
            ' or TopLevelGroup that has no populated records will not be able to calculate the UnitsSummary since
            ' no records are populated at the time the "Supplier" group is expanded.

            grid.TableDescriptor.SummaryRows.Add(New GridSummaryRowDescriptor("Row 1", New GridSummaryColumnDescriptor() {prizeAvgSummary, unitsInStockSummary}))

            grid.TableDescriptor.TopLevelGroupOptions.CaptionText = "{TableName}: {RecordCount} Items, Average UnitPrice is {Row 1.PrizeAvgSummary}"


            grid.DataSource = productQueryResults

            ' Clear out otherwise autopopulated UniformChildList relations
            grid.TableDescriptor.Relations.Clear()
        End Sub

		#End Region

		#End Region
	End Class

End Namespace
