Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.PivotAnalysis.Base
Imports Syncfusion.Windows.Forms

Namespace WindowsFormsApplication11
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()

            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch
            End Try

            Me.pivotGridControl1.ItemSource = ProductSales.GetSalesData()

            Me.pivotGridControl1.PivotRows.Add(New PivotItem With {.FieldMappingName = "Product", .TotalHeader = "Total"})

            Me.pivotGridControl1.PivotRows.Add(New PivotItem With {.FieldMappingName = "Year", .TotalHeader = "Total"})


            Me.pivotGridControl1.PivotColumns.Add(New PivotItem With {.FieldMappingName = "Country", .TotalHeader = "Total"})

            Me.pivotGridControl1.PivotColumns.Add(New PivotItem With {.FieldMappingName = "State", .TotalHeader = "Total"})

            Me.pivotGridControl1.PivotColumns.Add(New PivotItem With {.FieldMappingName = "Quantity", .TotalHeader = "Total"})

            Me.pivotGridControl1.PivotCalculations.Add(New PivotComputationInfo With {.FieldName = "Quantity", .Format = "#,##0"})
            Me.pivotGridControl1.PivotCalculations.Add(New PivotComputationInfo With {.FieldName = "Year", .Format = "#,##0"})
            Me.pivotGridControl1.ShowGroupBar = True
            Me.pivotGridControl1.AllowFiltering = True
            Me.pivotGridControl1.AllowSorting = True

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

#Region "DataSource"

#Region "product sales class"
        Public Class ProductSales

            Private privateProduct As String
            Public Property Product() As String
                Get
                    Return privateProduct
                End Get
                Set(ByVal value As String)
                    privateProduct = value
                End Set
            End Property



            Private privateYear As String
            Public Property Year() As String
                Get
                    Return privateYear
                End Get
                Set(ByVal value As String)
                    privateYear = value
                End Set
            End Property



            Private privateCountry As String
            Public Property Country() As String
                Get
                    Return privateCountry
                End Get
                Set(ByVal value As String)
                    privateCountry = value
                End Set
            End Property



            Private privateState As String
            Public Property State() As String
                Get
                    Return privateState
                End Get
                Set(ByVal value As String)
                    privateState = value
                End Set
            End Property



            Private privateQuantity As Integer
            Public Property Quantity() As Integer
                Get
                    Return privateQuantity
                End Get
                Set(ByVal value As Integer)
                    privateQuantity = value
                End Set
            End Property



            Private privateAmount As Double
            Public Property Amount() As Double
                Get
                    Return privateAmount
                End Get
                Set(ByVal value As Double)
                    privateAmount = value
                End Set
            End Property



            Public Shared Function GetSalesData() As ProductSalesCollection

                ''' Geography

                Dim countries() As String = {"Canada"}

                Dim canadaStates() As String = {"Alberta", "British Columbia", "Ontario"}



                ''' Time

                Dim dates() As String = {"FY 2005", "FY 2006", "FY 2007"}



                ''' Products

                Dim products() As String = {"Bike", "Car"}

                Dim r As New Random(123345345)



                Dim numberOfRecords As Integer = 2000

                Dim listOfProductSales As New ProductSalesCollection()

                For i As Integer = 0 To numberOfRecords - 1

                    Dim sales As New ProductSales()

                    sales.Country = countries(r.Next(0, countries.GetLength(0)))

                    sales.Quantity = r.Next(1, 12)

                    ''' 1 percent discount for 1 quantity

                    Dim discount As Double = (30000 * sales.Quantity) * (Double.Parse(sales.Quantity.ToString()) / 100)

                    sales.Amount = (30000 * sales.Quantity) - discount

                    sales.Year = dates(r.Next(r.Next(dates.GetLength(0) + 1)))

                    sales.Product = products(r.Next(r.Next(products.GetLength(0) + 1)))

                    sales.State = canadaStates(r.Next(canadaStates.GetLength(0)))

                    listOfProductSales.Add(sales)

                Next i



                Return listOfProductSales

            End Function



            Public Overrides Function ToString() As String

                Return String.Format("{0}-{1}-{2}", Me.Country, Me.State, Me.Product)

            End Function



            Public Class ProductSalesCollection
                Inherits List(Of ProductSales)

            End Class

        End Class
#End Region

#End Region

        Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckStateChanged
            Me.pivotGridControl1.AllowSorting = Not Me.pivotGridControl1.AllowSorting
            Me.pivotGridControl1.Refresh()
        End Sub

        Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv2.CheckStateChanged
            Me.pivotGridControl1.AllowFiltering = Not Me.pivotGridControl1.AllowFiltering
            Me.pivotGridControl1.Refresh()
        End Sub

        Private Sub checkBoxAdv3_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv3.CheckStateChanged
            Me.pivotGridControl1.ShowGroupBar = Not Me.pivotGridControl1.ShowGroupBar
        End Sub

    End Class
End Namespace
