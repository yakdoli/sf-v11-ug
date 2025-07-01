Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping

'INSTANT VB NOTE: VB does not allow aliasing interfaces:
'using ISummary = Syncfusion.Collections.BinaryTree.ITreeTableSummary
Imports Syncfusion.Windows.Forms


''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits MetroForm
    Private northwindDataSet1 As DataSet1
    Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapterOrders As System.Data.SqlClient.SqlDataAdapter
    Private sqlConnection2 As System.Data.SqlClient.SqlConnection
    Private panel1 As Panel
    Private gridGroupingControl1 As GridGroupingControl

    Private components As System.ComponentModel.Container = Nothing

    Public Sub New()
        ' GroupingEngineFactory provides a modified GridChildTable that adds an extra section
        GridEngineFactory.Factory = New GroupingEngineFactory()

        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '

        InitializeDataSet()
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

        Dim ordersDescriptor As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor


        ' You can define a summary row and mark it hidden.
        ' In that summary row you can add a column and set it's mapping name (and DisplayColumn) to be Freight

        Dim summaryColumn1 As New GridSummaryColumnDescriptor("FreightAverage", SummaryType.DoubleAggregate, "Freight", "{Average:###.00}")
        Dim summaryRow1 As New GridSummaryRowDescriptor()
        summaryRow1.Name = "SummaryRow 1"
        summaryRow1.Visible = False
        summaryRow1.SummaryColumns.Add(summaryColumn1)
        ordersDescriptor.SummaryRows.Add(summaryRow1)

        ' This is a second row, not marked hidden and therefore shown at the end of the group.
        Dim summaryColumn2 As New GridSummaryColumnDescriptor("FreightTotal", SummaryType.DoubleAggregate, "Freight", "{Sum:###.00}")
        Dim summaryRow2 As New GridSummaryRowDescriptor()
        summaryRow2.Name = "SummaryRow 2"
        summaryRow2.Title = "Total"
        summaryRow2.Visible = True
        summaryRow2.SummaryColumns.Add(summaryColumn2)
        ordersDescriptor.SummaryRows.Add(summaryRow2)

        ' Have Extra Section bar cover some cells.
        AddHandler gridGroupingControl1.TableModel.QueryCoveredRange, AddressOf TableModel_QueryCoveredRange

        ' Provide contents to be displayed in cell
        AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo
        AddHandler gridGroupingControl1.TableControlCellDrawn, AddressOf gridGroupingControl1_TableControlCellDrawn

        ' Move Freight column a bit to the left 
        Me.gridGroupingControl1.TableDescriptor.VisibleColumns.Move(Me.gridGroupingControl1.TableDescriptor.VisibleColumns.IndexOf("Freight"), 4)


        Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("EmployeeID")
        Me.gridGroupingControl1.TableDescriptor.GroupedColumns.Add("ShipCountry")
        Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
        Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
        Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
        Me.BackColor = Color.FromArgb(223, 227, 239)
        AddHandler gridGroupingControl1.TableControlCurrentCellActivated, AddressOf gridGroupingControl1_TableControlCurrentCellActivated
        Me.DropShadow = True
        Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
		Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
        Me.BackColor = Color.White
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

    Private xmlName As String = "Orders.xml"
    Private msdeAvailable As Boolean = False

    Private Sub InitializeDataSet()
        If msdeAvailable Then
            ' Initialize the data set

            Me.northwindDataSet1.BeginInit()

            ' Order is important here - first fill tables that are referenced with 
            ' foreign keys, then tables that have references to others.

            Me.sqlDataAdapterOrders.Fill(Me.northwindDataSet1)

            Me.northwindDataSet1.EndInit()

            Me.northwindDataSet1.WriteXml(xmlName)
        Else
            ' Read from a xml file instead. 
            If Not ReadXml(Me.northwindDataSet1, xmlName) Then
                ' If no xml found, try again with MSDE
                msdeAvailable = True
                InitializeDataSet()
            End If
        End If

    End Sub

    Private Function ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String) As Boolean
        ' Check both in parent folder and Parent\Data folders.
        Dim xmlDataFileName As String = "Common\Data\" & xmlFileName
        For n As Integer = 0 To 9
            If System.IO.File.Exists(xmlFileName) Then
                ds.ReadXml(xmlFileName)
                Return True
            End If
            If System.IO.File.Exists(xmlDataFileName) Then
                ds.ReadXml(xmlDataFileName)
                Return True
            End If
            xmlFileName = "..\" & xmlFileName
            xmlDataFileName = "..\" & xmlDataFileName
        Next n

        Return False
    End Function


    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.northwindDataSet1 = New DataSet1()
        Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.sqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterOrders = New System.Data.SqlClient.SqlDataAdapter()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' northwindDataSet1
        ' 
        Me.northwindDataSet1.DataSetName = "DataSet1"
        Me.northwindDataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        ' 
        ' sqlSelectCommand2
        ' 
        Me.sqlSelectCommand2.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" & "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" & "Country FROM Orders"
        Me.sqlSelectCommand2.Connection = Me.sqlConnection2
        ' 
        ' sqlConnection2
        ' 
        Me.sqlConnection2.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        Me.sqlConnection2.FireInfoMessageEventOnUserErrors = False
        ' 
        ' sqlInsertCommand2
        ' 
        Me.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText")
        Me.sqlInsertCommand2.Connection = Me.sqlConnection2
        Me.sqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry")})
        ' 
        ' sqlUpdateCommand2
        ' 
        Me.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText")
        Me.sqlUpdateCommand2.Connection = Me.sqlConnection2
        Me.sqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"), New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID")})
        ' 
        ' sqlDeleteCommand2
        ' 
        Me.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText")
        Me.sqlDeleteCommand2.Connection = Me.sqlConnection2
        Me.sqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapterOrders
        ' 
        Me.sqlDataAdapterOrders.DeleteCommand = Me.sqlDeleteCommand2
        Me.sqlDataAdapterOrders.InsertCommand = Me.sqlInsertCommand2
        Me.sqlDataAdapterOrders.SelectCommand = Me.sqlSelectCommand2
        Me.sqlDataAdapterOrders.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
        Me.sqlDataAdapterOrders.UpdateCommand = Me.sqlUpdateCommand2
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.gridGroupingControl1)
        Me.panel1.Location = New System.Drawing.Point(22, 23)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(666, 502)
        Me.panel1.TabIndex = 0
        ' 
        ' gridGroupingControl1
        ' 
        Me.gridGroupingControl1.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(231))))), (CInt(Fix((CByte(162)))))))
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.DataSource = Me.northwindDataSet1.Orders
        Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.ShowGroupDropArea = True
        Me.gridGroupingControl1.Size = New System.Drawing.Size(666, 502)
        Me.gridGroupingControl1.TabIndex = 1
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.ClientSize = New System.Drawing.Size(712, 550)
        Me.Controls.Add(Me.panel1)
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Customization Demo"
        CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region


    Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub

    Private extraSectionCoverCols As Integer = 3

    Private Sub TableModel_QueryCoveredRange(ByVal sender As Object, ByVal e As GridQueryCoveredRangeEventArgs)
        Dim thisTable As GridTable = Me.gridGroupingControl1.Table
        If e.RowIndex < thisTable.DisplayElements.Count Then
            Dim el As Element = thisTable.DisplayElements(e.RowIndex)

            If TypeOf el Is ExtraSection Then
                ' Cover some cells of the extra section (specified with extraSectionCoverCols)
                Dim startCol As Integer = el.GroupLevel + 1 ' Add +1 so we have place for column header
                If e.ColIndex >= startCol AndAlso e.ColIndex <= Me.extraSectionCoverCols + el.ParentTableDescriptor.GroupedColumns.Count Then
                    e.Range = GridRangeInfo.Cells(e.RowIndex, startCol, e.RowIndex, Me.extraSectionCoverCols + el.ParentTableDescriptor.GroupedColumns.Count)
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
        Dim el As Element = e.TableCellIdentity.DisplayElement

        If (el.ParentElement Is Nothing) Then
            e.Style.CellTipText = el.GetType().Name
        Else
            e.Style.CellTipText = el.GetType().Name + " (Parent: " + el.ParentElement.GetType().Name + ")"
        End If

        If TypeOf el Is ExtraSection Then
            If e.Style.TableCellIdentity.ColIndex = 0 Then
                ' Row Header
                e.Style.CellType = CType(el.ParentTableDescriptor, GridTableDescriptor).Appearance.RecordRowHeaderCell.CellType

                If Object.ReferenceEquals(el, el.ParentTable.CurrentElement) Then
                    e.Style.Text = "#"
                End If
            ElseIf e.Style.TableCellIdentity.ColIndex <= el.GroupLevel Then
                ' Group Indent 
                e.Style.BackColor = Color.FromArgb(218, 229, 245)
            ElseIf e.Style.TableCellIdentity.ColIndex <= extraSectionCoverCols + el.ParentTableDescriptor.GroupedColumns.Count Then
                ' Covered area (see TableModel_QueryCoveredRange above)
                e.Style.BackColor = Color.FromArgb(192, 201, 219)
                e.Style.CellValue = "ExtraSection (" + el.ParentGroup.Name + ")"
            ElseIf e.Style.TableCellIdentity.ColIndex > 3 Then
                e.Style.BackColor = Color.FromArgb(252, 172, 38)
                ' you can get the column as follows:

                Dim table As GridTable = CType(el.ParentTable, GridTable)
                Dim td As GridTableDescriptor = e.TableCellIdentity.Table.TableDescriptor
                Dim column As GridColumnDescriptor = td.RecordRowColumns(0, e.Style.TableCellIdentity.ColIndex - el.ParentTableDescriptor.GroupedColumns.Count - 1)
                e.Style.CellValue = column.Name

                ' Using that column you could try and identify the summary that should be displayed in this cell.
                If column.MappingName = "Freight" Then
                    ' Calling this method to demonstrate different alternatives to get to the summary text
                    e.Style.Text = GetSummaryText(el.ParentGroup, "SummaryRow 1", "FreightAverage")

                    ' Easier is to simple call built-in routine:
                    e.Style.Text = GridEngine.GetSummaryText(el.ParentGroup, "SummaryRow 1", "FreightAverage")
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Demonstrates different alternatives to get to the summary text (strong typed vs GridSummaryColumnDescriptor.Format)
    ''' </summary>
    Public Function GetSummaryText(ByVal group As Group, ByVal summaryRowName As String, ByVal summaryColumnName As String) As String
        Dim table As GridTable = CType(group.ParentTable, GridTable)
        Dim td As GridTableDescriptor = table.TableDescriptor
        Dim srd As GridSummaryRowDescriptor = td.SummaryRows(summaryRowName)
        Dim scd As GridSummaryColumnDescriptor = srd.SummaryColumns(summaryColumnName)

        Return GetSummaryText(group, scd)
    End Function

    ''' <summary>
    ''' Demonstrates different alternatives to get to the summary text (strong typed vs GridSummaryColumnDescriptor.Format)
    ''' </summary>
    Private Function GetSummaryText(ByVal group As Group, ByVal scd As GridSummaryColumnDescriptor) As String
        Dim table As GridTable = CType(group.ParentTable, GridTable)
        Dim td As GridTableDescriptor = table.TableDescriptor

        Dim summaryText As String = ""

        Dim use31Code As Boolean = True
        If use31Code Then
            If scd IsNot Nothing Then
                ' Option 1: GetDisplayText - this is actually the code used when you simply would call 
                ' e.Style.Text = ((GridTable) table).GetSummaryText(group, "SummaryRow 1", "FreightAverage");
                '
                ' Text is formatted as defined in GridSummaryColumnDescriptor.Format 
                summaryText = scd.GetDisplayText(group)

                ' or Option 2: Strong typed access to DoubleAggregateSummary.
                Dim summary1 As DoubleAggregateSummary = CType(group.GetSummary(scd.SummaryDescriptor), DoubleAggregateSummary)
                summaryText = String.Format("{0:c}", summary1.Average)

                ' or Option 3: Use reflection to get "Average" property of summary
                summaryText = String.Format("{0:c}", group.GetSummaryProperty(scd.SummaryDescriptor, "Average"))
            End If

        Else
            ' This is the code you had to use in version 3.0 and earlier (still working but bit more complicate)
            If scd IsNot Nothing Then
                Dim sd1 As SummaryDescriptor = scd.SummaryDescriptor
                If sd1 IsNot Nothing Then
                    Dim indexOfSd1 As Integer = table.TableDescriptor.Summaries.IndexOf(sd1)

                    Dim sum1 As Syncfusion.Collections.BinaryTree.ITreeTableSummary = group.GetSummaries(table)(indexOfSd1)
                    Dim text1 As String = scd.GetDisplayText(sum1)
                    summaryText = text1

                    ' - or - (access value directly)
                    ' strong typed - you have to cast to Int32AggregateSummary.

                    Dim summary1 As DoubleAggregateSummary = CType(group.GetSummaries(table)(indexOfSd1), DoubleAggregateSummary)
                    summaryText = String.Format("{0:c}", summary1.Average)
                End If
            End If
        End If

        Return summaryText
    End Function

    ''' <summary>
    ''' This code works with base engine, no dependency on GridEngine / GridSummaryColumnDescriptor etc.
    ''' </summary>
    Private Function GetAverageSummary(ByVal summaryDescriptor As SummaryDescriptor, ByVal group As Group) As String
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

        Else
            ' This is the code you had to use in version 3.0 and earlier (still working but bit more complicate)
            If summaryDescriptor IsNot Nothing Then
                Dim indexOfSd1 As Integer = table.TableDescriptor.Summaries.IndexOf(summaryDescriptor)

                ' strong typed - you have to cast to DoubleAggregateSummary.

                Dim summary1 As DoubleAggregateSummary = CType(group.GetSummaries(table)(indexOfSd1), DoubleAggregateSummary)
                summaryText = String.Format("{0:c}", summary1.Average)
            End If
        End If
        Return summaryText
    End Function

    Private Sub gridGroupingControl1_TableControlCurrentCellActivated(ByVal sender As Object, ByVal e As GridTableControlEventArgs)
        ' Navigate to ExtraSection when textbox inside ExtraSection has become CurrentCell.

        Dim gcc As GridCurrentCell = e.TableControl.CurrentCell
        Dim style As GridTableCellStyleInfo = e.TableControl.Model(gcc.RowIndex, gcc.ColIndex)
        Dim id As GridTableCellStyleInfoIdentity = style.TableCellIdentity

        If TypeOf id.DisplayElement Is ExtraSection Then
            id.Table.CurrentRecordManager.NavigateTo(id.DisplayElement)
        End If
    End Sub

    Private Sub gridGroupingControl1_TableControlCellDrawn(ByVal sender As Object, ByVal e As GridTableControlDrawCellEventArgs)
        Dim style As GridTableCellStyleInfo = e.TableControl.Model(e.Inner.RowIndex, e.Inner.ColIndex)
        Dim id As GridTableCellStyleInfoIdentity = style.TableCellIdentity

        Dim el As Element = id.DisplayElement

        If TypeOf el Is ExtraSection Then
            If id.ColIndex = 0 Then
                ' Row Header and ExtraSection is CurrentElement
                If el Is el.ParentTable.CurrentElement Then
                    ' Draw Record indicator 
                    Try
                        Dim iconBounds As Rectangle = Rectangle.FromLTRB(e.Inner.Bounds.Right - 15, e.Inner.Bounds.Top, e.Inner.Bounds.Right, e.Inner.Bounds.Bottom)
                        iconBounds.Offset(-2, 0)
                        IconPainter.PaintIcon(e.Inner.Graphics, iconBounds, Point.Empty, "SFARROW.BMP", style.TextColor)
                    Catch
                    End Try
                End If
            End If
        End If
    End Sub

    'INSTANT VB NOTE: The variable iconPainter was renamed since Visual Basic does not allow class members with the same name:

    Private Shared iconPainter_Renamed As IconPaint

    Friend Shared ReadOnly Property IconPainter() As IconPaint
        Get
            Dim ns As String = "CustomSectionInGroup" ' Must be same as your project settings Root Namespace
            If iconPainter_Renamed Is Nothing Then
                iconPainter_Renamed = New IconPaint(ns & ".", GetType(Form1).Assembly)
            End If
            Return iconPainter_Renamed
        End Get
    End Property

End Class



