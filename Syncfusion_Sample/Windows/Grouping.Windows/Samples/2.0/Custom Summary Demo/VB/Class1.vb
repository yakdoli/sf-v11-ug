#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.IO

Imports Syncfusion.Grouping
Imports Syncfusion.Collections.BinaryTree



Public Class Class1
    
    
    Public Shared Sub Main()
        Dim c As New Class1()
        c.Run()
        Console.WriteLine("Please press <Enter> to continue.")
        Console.ReadLine()
    End Sub 'Main
    
    Private engine1 As Syncfusion.Grouping.Engine
    Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Private dataSet11 As CustomSummary.DataSet1
    Private sd0 As SummaryDescriptor
    Private sd1 As SummaryDescriptor
    Private sd2 As SummaryDescriptor
    Private sd3 As SummaryDescriptor
    
    
    
    Sub ReadXml(ds As DataSet, xmlFileName As String)
        Dim n As Integer
        For n = 0 To 11
            If File.Exists(xmlFileName) Then
                ds.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" + xmlFileName
        Next n
    End Sub 'ReadXml
    
    
    Public Sub Run()
        Dim el As Element
        For Each el In  engine1.Table.DisplayElements
            Console.WriteLine(el.ToString())
            If TypeOf el Is Syncfusion.Grouping.SummarySection Then
                ' Cast summary to correct type before accessing idividual summary properties
                Console.WriteLine("Summaries:")
                Dim summaries As ITreeTableSummary() = el.ParentGroup.GetSummaries(el.ParentTable)
                
                Dim d0 As DoubleAggregateSummary = CType(summaries(el.ParentTableDescriptor.Summaries.IndexOf(sd0)), DoubleAggregateSummary)
                Console.WriteLine("QuantityAverage = {0}", d0.Average)
                
                Dim d1 As TotalSummary = CType(summaries(el.ParentTableDescriptor.Summaries.IndexOf(sd1)), TotalSummary)
                Console.WriteLine("QuantityDistinctCount = {0}", d1.Total)
                
                Dim d2 As DistinctInt32CountSummary = CType(summaries(el.ParentTableDescriptor.Summaries.IndexOf(sd2)), DistinctInt32CountSummary)
                Console.WriteLine("QuantityTotal = {0}", d2.Count)
                
                Dim d3 As StatisticsSummary = CType(summaries(el.ParentTableDescriptor.Summaries.IndexOf(sd3)), StatisticsSummary)
                Console.WriteLine("QuantityMedian = {0}", d3.Median)

                Console.WriteLine("QuantityAverage = {0}", GetAverageSummary(sd0, el.ParentGroup))

            End If
        Next el
    End Sub 'Run
    
    
    Function GetAverageSummary(ByVal summaryDescriptor As SummaryDescriptor, ByVal group As Group) As String
        Dim table As Table = group.ParentTable
        Dim td As TableDescriptor = table.TableDescriptor
        Dim summaryText As String = ""

        Dim use31Code As Boolean = True
        If use31Code Then
            ' Option 1: Strong typed access to DoubleAggregateSummary.
            Dim summary1 As DoubleAggregateSummary = CType(group.GetSummary(summaryDescriptor), DoubleAggregateSummary)
            summaryText = String.Format("{0:c}", summary1.Average)

            ' or Option 2: Use reflection to get "Average" property of summary
            summaryText = String.Format("{0:c}", group.GetSummaryProperty(summaryDescriptor, "Average"))

            ' or Option 3: Use reflection to get "Average" property of summary and format it
            summaryText = group.GetFormattedSummaryProperty(summaryDescriptor, "Average", "{0:c}")

        Else
            ' This is the code you had to use in version 3.0 and earlier (still working but bit more complicate)
            If Not (summaryDescriptor Is Nothing) Then
                Dim indexOfSd1 As Integer = table.TableDescriptor.Summaries.IndexOf(summaryDescriptor)

                ' strong typed - you have to cast to DoubleAggregateSummary.
                Dim summary1 As DoubleAggregateSummary = CType(group.GetSummaries(table)(indexOfSd1), DoubleAggregateSummary)
                summaryText = String.Format("{0:c}", summary1.Average)
            End If
        End If
        Return summaryText
    End Function 'GetSummary

    Public Sub New()
        InitializeComponent()
        
        Dim msdeAvailable As Boolean = False
        If msdeAvailable Then
            Me.sqlDataAdapter1.Fill(Me.dataSet11)

        Else
            ' Read from a xml file instead. 
            ReadXml(Me.dataSet11, "Common\Data\CustOrders.xml")
        End If
        
        Me.engine1 = New Engine()
        
        ' Setup a integrated summary
        sd0 = New SummaryDescriptor()

        sd0.MappingName = "Quantity"
        sd0.SummaryType = SummaryType.DoubleAggregate
        Me.engine1.TableDescriptor.Summaries.Add(sd0)
        
        ' Setup custom summaries
        sd1 = New SummaryDescriptor()
        sd1.Name = "QuantityTotal"
        sd1.MappingName = "Quantity"
        sd1.SummaryType = SummaryType.Custom
        sd1.CreateSummaryMethod = New CreateSummaryDelegate(AddressOf TotalSummary.CreateSummaryMethod)
        Me.engine1.TableDescriptor.Summaries.Add(sd1)
        
        sd2 = New SummaryDescriptor()
        sd2.Name = "QuantityDistinctCount"
        sd2.MappingName = "Quantity"
        sd2.SummaryType = SummaryType.Custom
        sd2.CreateSummaryMethod = New CreateSummaryDelegate(AddressOf DistinctInt32CountSummary.CreateSummaryMethod)
        Me.engine1.TableDescriptor.Summaries.Add(sd2)
        
        sd3 = New SummaryDescriptor()
        sd3.Name = "QuantityMedian"
        sd3.MappingName = "Quantity"
        sd3.SummaryType = SummaryType.Custom
        sd3.CreateSummaryMethod = New CreateSummaryDelegate(AddressOf StatisticsSummary.CreateSummaryMethod)
        Me.engine1.TableDescriptor.Summaries.Add(sd3)
        
        
        ' Setup running totals by displaying the value of a custom counter in an unbound field
        Dim unboundField As New FieldDescriptor("QuantityCount", "", False, "")
        unboundField.ReadOnly = False
        Me.engine1.TableDescriptor.UnboundFields.Add(unboundField)
        
        AddHandler Me.engine1.TableDescriptor.QueryValue, AddressOf unboundField_QueryValue ' Routine that queries for the value
        AddHandler Me.engine1.TableDescriptor.SaveValue, AddressOf unboundField_SaveValue
        
        Dim unboundField2 As New FieldDescriptor("QuantityCount2", "", False, "")
        Me.engine1.TableDescriptor.UnboundFields.Add(unboundField2)
        
        ' Setup custom counter
        AddHandler Me.engine1.Table.QueryCustomCount, AddressOf Table_QueryCustomCount
        AddHandler Me.engine1.CurrentRecordContextChange, AddressOf engine1_CurrentRecordContextChange
        AddHandler Me.engine1.Table.QueryVisibleCustomCount, AddressOf Table_QueryVisibleCustomCount
        
        ' Assign data source
        Me.engine1.SetSourceList(Me.dataSet11.Order_Details.DefaultView)
        
        quantityFieldDescriptor = Me.engine1.TableDescriptor.Fields("Quantity")
        
        ' Add a filter so that we can check out difference between VisibleCustomCount (only records that meet criteria are counted) 
        ' and CustomCount (all records are counted)
        Me.engine1.TableDescriptor.RecordFilters.Add("[UnitPrice] > 20")
    End Sub 'New
    
    Private quantityFieldDescriptor As FieldDescriptor
    
    
    
    '/ <summary>
    '/ Query value for unbound field
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub unboundField_QueryValue(sender As Object, e As FieldValueEventArgs)
        If TypeOf e.Record Is AddNewRecord Then
            Return
        End If 
        If e.Field.Name = "QuantityCount" Then
            e.Value = e.Record.GetCustomPosition()
        Else
            e.Value = e.Record.GetVisibleCustomPosition()
        End If
    End Sub 'unboundField_QueryValue
     
    '/ <summary>
    '/ Could write back value here if needed when unbound field is changed by user.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub unboundField_SaveValue(sender As Object, e As FieldValueEventArgs)
        Console.WriteLine(e.Value)
    End Sub 'unboundField_SaveValue
    
    
    '/ <summary>
    '/ Fill in custom counter. This event is called for every record in the table. The CustomCounter
    '/ will increase no matter if a record meet filter criteria or not.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub Table_QueryCustomCount(ByVal sender As Object, ByVal e As CustomCountEventArgs)
        If TypeOf e.Record Is AddNewRecord Then
            Return
        End If
        Dim obj As Object = e.Record.GetValue(quantityFieldDescriptor)
        Dim quantity As Double = Convert.ToDouble(obj)
        e.CustomCount = quantity
    End Sub 'Table_QueryCustomCount


    '/ <summary>
    '/ Fill in visible custom counter. This event is called for every visible record in the table. The CustomCounter
    '/ will increase only for records that meet filter criteria.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub Table_QueryVisibleCustomCount(ByVal sender As Object, ByVal e As CustomCountEventArgs)
        If TypeOf e.Record Is AddNewRecord Then
            Return
        End If
        Dim obj As Object = e.Record.GetValue(quantityFieldDescriptor)
        Dim quantity As Double = Convert.ToDouble(obj)
        e.CustomCount = quantity
    End Sub 'Table_QueryVisibleCustomCount


    '/ <summary>
    '/ We need to make counters dirty when the record has changed since the custom counters need
    '/ to be recalculated for subsequent records. Also, the grid needs to be redrawn.
    '/ </summary>
    '/ <param name="sender"></param>
    '/ <param name="e"></param>
    Private Sub engine1_CurrentRecordContextChange(ByVal sender As Object, ByVal e As CurrentRecordContextChangeEventArgs)
        If e.Action = CurrentRecordAction.EndEditComplete Then
            e.Record.InvalidateCounterBottomUp()
        End If 'this.engine1.Refresh();
    End Sub 'engine1_CurrentRecordContextChange


    Private Sub InitializeComponent()
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.dataSet11 = New CustomSummary.DataSet1()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        ' 
        ' sqlSelectCommand1
        ' 
        Me.sqlSelectCommand1.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        ' 
        ' sqlInsertCommand1
        ' 
        Me.sqlInsertCommand1.CommandText = "INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount) VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount); SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details] WHERE (OrderID = @OrderID) AND (ProductID = @ProductID)"
        Me.sqlInsertCommand1.Connection = Me.sqlConnection1
        Me.sqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"))
        Me.sqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"))
        Me.sqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"))
        Me.sqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"))
        Me.sqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"))
        ' 
        ' sqlUpdateCommand1
        ' 
        Me.sqlUpdateCommand1.CommandText = "UPDATE [Order Details] SET OrderID = @OrderID, ProductID = @ProductID, UnitPrice = @UnitPrice, Quantity = @Quantity, Discount = @Discount WHERE (OrderID = @Original_OrderID) AND (ProductID = @Original_ProductID) AND (Discount = @Original_Discount) AND (Quantity = @Original_Quantity) AND (UnitPrice = @Original_UnitPrice); SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details] WHERE (OrderID = @OrderID) AND (ProductID = @ProductID)"
        Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"))
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"))
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"))
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"))
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"))
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "Discount", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
        ' 
        ' sqlDeleteCommand1
        ' 
        Me.sqlDeleteCommand1.CommandText = "DELETE FROM [Order Details] WHERE (OrderID = @Original_OrderID) AND (ProductID = " + "@Original_ProductID) AND (Discount = @Original_Discount) AND (Quantity = @Origin" + "al_Quantity) AND (UnitPrice = @Original_UnitPrice)"
        Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "Discount", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "Quantity", System.Data.DataRowVersion.Original, Nothing))
        Me.sqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, System.Byte), CType(0, System.Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing))
        ' 
        ' sqlConnection1
        ' 
        Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_samples;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        ' 
        ' sqlDataAdapter1
        ' 
        Me.sqlDataAdapter1.DeleteCommand = Me.sqlDeleteCommand1
        Me.sqlDataAdapter1.InsertCommand = Me.sqlInsertCommand1
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Order Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Discount", "Discount")})})
        Me.sqlDataAdapter1.UpdateCommand = Me.sqlUpdateCommand1
        ' 
        ' dataSet11
        ' 
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub 'InitializeComponent
End Class 'Class1 