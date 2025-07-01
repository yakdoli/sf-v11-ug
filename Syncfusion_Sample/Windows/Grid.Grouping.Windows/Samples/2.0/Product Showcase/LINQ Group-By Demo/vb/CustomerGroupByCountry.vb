#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
#Region "Directives"

Imports System.Collections
Imports System.Linq
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping

#End Region

Namespace LinqGroupBy
	Friend Class CustomerGroupByCountry
		Inherits SampleQuery
		#Region "Variable Declaration"

		Private db As NorthwindwithImage

		#End Region

		#Region "Method"

		#Region "Override Method"
		Public Overrides Sub InitializeGrid(ByVal grid As GridGroupingControl, ByVal db As NorthwindwithImage)
			Me.db = db
			Dim customerQuery = From customer In db.Customers _
			                    Group customer By customer.Country Into g = Group _
			                    Select New With {Key .Key = Country, Key .Count = g.Count()}

			Dim customerTotals = db.Customers.Count()

			grid.TableOptions.ColumnsMaxLengthStrategy = GridColumnsMaxLengthStrategy.FirstNRecords

			' Pass in a sample query for determing optimal column widths.
			' Use this together with GridColumnsMaxLengthStrategy.FirstNRecords
			Dim customerSamples As IEnumerable = ( _
			    From c In db.Customers _
			    Select c).Take(10)

			Dim customerQueryResults As New PassThroughGroupingResult("Customer", customerQuery, GetType(Customers), customerTotals, New QueryGroupsDetailsDelegate(AddressOf GetDetailsForCountry), customerSamples, "Country")

			grid.DataSource = customerQueryResults

			' Clear out otherwise autopopulated UniformChildList relations
			' for Orders and CustomerCustomerDemos.
			grid.TableDescriptor.Relations.Clear()
		End Sub

		#End Region

		#Region "Public Method"

		Public Function GetDetailsForCountry(ByVal group As Group) As IEnumerable
			' If group is nested, you also need to filter with CategoryKeys from g.ParentGroup!
			Dim country As String = CStr(PassThroughGroupingResult.GetValue(group.PassThroughItem, "Key"))

			' TODO: If country is null find a way to query for it more efficiently ...
			If country Is Nothing Then
				Return _
				    From p In db.Customers _
				    Where Not(p.Country IsNot Nothing) _
				    Select p
			End If

			Dim query = From p In db.Customers _
			            Where p.Country = country _
			            Select p

			Return query
		End Function

		#End Region

		#End Region
	End Class
End Namespace
