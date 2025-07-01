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
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

Namespace CellSelectionDemo
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()
            Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch
            End Try

            ' Adding ItemSource to the Control
            Me.pivotGridControl1.ItemSource = ProductSales.GetSalesData()

            ' Adding PivotRows to the Control
            Me.pivotGridControl1.PivotRows.Add(New PivotItem With {.FieldMappingName = "Product", .TotalHeader = "Total"})

            Me.pivotGridControl1.PivotRows.Add(New PivotItem With {.FieldMappingName = "Date", .TotalHeader = "Total"})

            ' Adding PivotColumns to the Control
            Me.pivotGridControl1.PivotColumns.Add(New PivotItem With {.FieldMappingName = "Country", .TotalHeader = "Total"})

            Me.pivotGridControl1.PivotColumns.Add(New PivotItem With {.FieldMappingName = "State", .TotalHeader = "Total"})

            ' Adding PivotCalculations to the Control
            Me.pivotGridControl1.PivotCalculations.Add(New PivotComputationInfo With {.FieldName = "Amount", .Format = "#,##0", .SummaryType = SummaryType.DoubleTotalSum})

            Me.pivotGridControl1.PivotCalculations.Add(New PivotComputationInfo With {.FieldName = "Quantity", .Format = "#,##0"})

            checkBox2.Checked = True
            AddHandler pivotGridControl1.TableModel.SelectionChanged, AddressOf Model_SelectionChanged
        End Sub


        Private Sub Model_SelectionChanged(ByVal sender As Object, ByVal e As GridSelectionChangedEventArgs)
            'PivotCellInfo cellinfo;

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

            Private privateDate As String
            Public Property [Date]() As String
                Get
                    Return privateDate
                End Get
                Set(ByVal value As String)
                    privateDate = value
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

            Private privateUnitPrice As Double
            Public Property UnitPrice() As Double
                Get
                    Return privateUnitPrice
                End Get
                Set(ByVal value As Double)
                    privateUnitPrice = value
                End Set
            End Property

            Private privateTotalPrice As Double
            Public Property TotalPrice() As Double
                Get
                    Return privateTotalPrice
                End Get
                Set(ByVal value As Double)
                    privateTotalPrice = value
                End Set
            End Property

            Public Shared Function GetSalesData() As ProductSalesCollection
                ''' Geography
                Dim countries() As String = {"Australia", "Canada", "France", "Germany", "United Kingdom", "United States"}
                Dim ausStates() As String = {"New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria"}
                Dim canadaStates() As String = {"Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec"}
                Dim franceStates() As String = {"Charente Maritime", "Essonne", "Garonne (Haute)", "Gers"}
                Dim germanyStates() As String = {"Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland"}
                Dim ukStates() As String = {"England"}
                Dim ussStates() As String = {"New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina"}

                ''' Time
                Dim dates() As String = {"FY 2005", "FY 2006", "FY 2007", "FY 2008", "FY 2009"}

                ''' Products
                Dim products() As String = {"Bike", "Car"}
                Dim r As New Random(123345345)

                Dim numberOfRecords As Integer = 2000
                Dim listOfProductSales As New ProductSalesCollection()
                For i As Integer = 0 To numberOfRecords - 1
                    Dim sales As New ProductSales()
                    sales.Country = countries(r.Next(1, countries.GetLength(0)))
                    sales.Quantity = r.Next(1, 12)
                    ''' 1 percent discount for 1 quantity
                    Dim discount As Double = (30000 * sales.Quantity) * (Double.Parse(sales.Quantity.ToString()) / 100)
                    sales.Amount = (30000 * sales.Quantity) - discount
                    sales.TotalPrice = sales.Amount * sales.Quantity
                    sales.UnitPrice = sales.Amount / sales.Quantity
                    sales.Date = dates(r.Next(r.Next(dates.GetLength(0) + 1)))
                    sales.Product = products(r.Next(r.Next(products.GetLength(0) + 1)))
                    Select Case sales.Country
                        Case "Australia"
                            sales.State = ausStates(r.Next(ausStates.GetLength(0)))
                            Exit Select
                        Case "Canada"
                            sales.State = canadaStates(r.Next(canadaStates.GetLength(0)))
                            Exit Select
                        Case "France"
                            sales.State = franceStates(r.Next(franceStates.GetLength(0)))
                            Exit Select
                        Case "Germany"
                            sales.State = germanyStates(r.Next(germanyStates.GetLength(0)))
                            Exit Select
                        Case "United Kingdom"
                            sales.State = ukStates(r.Next(ukStates.GetLength(0)))
                            Exit Select
                        Case "United States"
                            sales.State = ussStates(r.Next(ussStates.GetLength(0)))
                            Exit Select
                    End Select
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

        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.pivotGridControl1.ShowGroupBar = Not Me.pivotGridControl1.ShowGroupBar
        End Sub



#End Region


        Private Sub checkBox2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox2.CheckStateChanged
            If checkBox2.Checked Then
                Me.pivotGridControl1.TableModel.Options.ExcelLikeSelectionFrame = True
                Me.pivotGridControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Any
                checkBox1.Checked = True
            Else
                Me.pivotGridControl1.TableModel.Options.ExcelLikeSelectionFrame = False
                If Not checkBox1.Checked Then
                    Me.pivotGridControl1.TableModel.Selections.Clear()
                End If
            End If
        End Sub

        Private Sub checkBox1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckStateChanged
            If checkBox1.Checked Then
                Me.pivotGridControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Any
            Else
                Me.pivotGridControl1.TableModel.Options.AllowSelection = GridSelectionFlags.None
                Me.pivotGridControl1.TableModel.Selections.Clear()
                checkBox2.Checked = False
            End If
        End Sub

    End Class
End Namespace
