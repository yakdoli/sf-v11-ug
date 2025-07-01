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

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
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
    Private startTimerButton As ButtonAdv
    Private gridGroupingControl1 As GridGroupingControl
    Private propertyGrid1 As PropertyGrid

    Private components As System.ComponentModel.Container = Nothing

    Private Sub OptimizeGridSettings(ByVal grid As GridGroupingControl)
        grid.CounterLogic = EngineCounters.YAmount
        grid.AllowedOptimizations = EngineOptimizations.DisableCounters Or EngineOptimizations.RecordsAsDisplayElements
        grid.UseDefaultsForFasterDrawing = True ' GDI interop drawing, FirstNRecords Summaries
        grid.InvalidateAllWhenListChanged = False ' only paint modified cells
        grid.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate
        grid.UpdateDisplayFrequency = 50 ' update every number of ms (speciy 0 if Update should occur manually, 1 if immediately)
        'grid.TableControl.EnableDoubleBufferSurface(); // reduce flickering
        grid.BlinkTime = 700

        ' Instruct grouping control not to access datasource through
        ' CurrencyManager API and instead access list diretly. When set to
        ' false you wil howver loose support for built-in CurrencyManager 
        ' synchronization.
        grid.BindToCurrencyManager = False

        If GetType(Object).AssemblyQualifiedName.IndexOf("Version=1") = -1 Then
            ' .NET 2.0 gets very slow when subscribing to ListChanged event on the 
            ' DataTable.DefaultView. The following setting allows the engine to wrap 
            ' datatable with a Syncfusion.Collections.DataTableList to work around 
            ' this bottleneck.
            '
            ' .NET 1.0 and 1.1 are just fine with using DataTable.DefaultView
            '
            grid.AllowSwapDataViewWithDataTableList = True
        End If
    End Sub

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Try
            Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

        InitializeDataSet()

        OptimizeGridSettings(Me.gridGroupingControl1)


        Dim ordersDescriptor As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor

        ' Add Unbound 
        ordersDescriptor.UnboundFields.Add("ShipVia_CompanyName")

        ' Callback for conversion
        AddHandler ordersDescriptor.QueryValue, AddressOf ordersDescriptor_QueryValue

        ' Hide it.
        ordersDescriptor.VisibleColumns.Remove("ShipVia_CompanyName")

        ' Use it for grouping.
        ordersDescriptor.GroupedColumns.Add("ShipVia_CompanyName")

        ordersDescriptor.TopLevelGroupOptions.ShowCaptionSummaryCells = False

        ' not neeeded.
        ordersDescriptor.PrimaryKeyColumns.Clear()


        ' You can define a summary row and mark it hidden.
        ' In that summary row you can add a column and set it's mapping name (and DisplayColumn) to be Freight
        Dim summaryColumn1 As New GridSummaryColumnDescriptor("FreightAverage", SummaryType.DoubleAggregate, "Freight", "{Average:###.00}")
        Dim summaryRow1 As New GridSummaryRowDescriptor()
        summaryRow1.Name = "Caption"
        summaryRow1.Visible = False
        summaryRow1.SummaryColumns.Add(summaryColumn1)
        ordersDescriptor.SummaryRows.Add(summaryRow1)

        ' This is a second row, not marked hidden and therefore shown at the end of the group.
        Dim summaryColumn2 As New GridSummaryColumnDescriptor("FreightTotal", SummaryType.DoubleAggregate, "Freight", "{Average:###.00}")
        Dim summaryRow2 As New GridSummaryRowDescriptor()
        summaryRow2.Name = "Bottom"
        summaryRow2.Visible = True
        summaryRow2.SummaryColumns.Add(summaryColumn2)
        ordersDescriptor.SummaryRows.Add(summaryRow2)

        ' Here you define the summary row that should be used for displaying summaries in caption bar.
        ordersDescriptor.ChildGroupOptions.ShowCaptionSummaryCells = True
        ordersDescriptor.ChildGroupOptions.ShowSummaries = True
        ordersDescriptor.ChildGroupOptions.CaptionSummaryRow = "Caption"

        ' Let's you hide/show the second row in child groups.
        ordersDescriptor.ChildGroupOptions.ShowSummaries = False

        ' Move Freight column ahead 
        ' ordersDescriptor.VisibleColumns.LoadDefault();
        Dim count As Integer = ordersDescriptor.VisibleColumns.Count ' force populating VisibleColumns
        ordersDescriptor.VisibleColumns.Remove("Freight")
        ordersDescriptor.VisibleColumns.Insert(3, New GridVisibleColumnDescriptor("Freight"))


        ' Minor customization: Have Caption bar cover some cells.
        AddHandler gridGroupingControl1.TableModel.QueryCoveredRange, AddressOf TableModel_QueryCoveredRange
        captionCoverCols = 2


        Me.gridGroupingControl1.Appearance.GroupCaptionCell.BackColor = Me.gridGroupingControl1.Appearance.RecordFieldCell.BackColor
        Me.gridGroupingControl1.Appearance.GroupCaptionCell.Borders.Top = New GridBorder(GridBorderStyle.Standard)
        Me.gridGroupingControl1.Appearance.GroupCaptionCell.CellType = "Static"

        Me.gridGroupingControl1.TableOptions.CaptionRowHeight = Me.gridGroupingControl1.TableOptions.RecordRowHeight

        Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False

        gridGroupingControl1.Table.CurrentRecord = gridGroupingControl1.Table.Records(0)
        Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
        Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
        gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.DropShadow = True
        Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
        Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
        Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
        Me.propertyGrid1.BackColor = Color.White
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


    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        startTimerButton.Text = "Start Timer"
        startTimerButton.Visible = True
        Me.Controls.Add(startTimerButton)
        AddHandler startTimerButton.Click, AddressOf startTimerButton_Click
        startTimerButton.BringToFront()
        Me.BackColor = Color.White
        Me.DropShadow = True
        Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
    End Sub

    Private Sub startTimerButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Start timer that updates datasource 
        Dim t As New Timer()
        t.Interval = 10
        AddHandler t.Tick, AddressOf t_Tick
        t.Start()
    End Sub

    Private rnd As New Random()

    Private Sub t_Tick(ByVal sender As Object, ByVal e As EventArgs)
        For n As Integer = 0 To 9
            Dim i As Integer = rnd.Next(Me.northwindDataSet1.Orders.Rows.Count)
            northwindDataSet1.Orders(i).Freight += 3 - Math.Round(CDec(rnd.NextDouble()) * 6)
        Next n
    End Sub

#Region "Initialize DataSet"

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

#End Region

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
        Me.northwindDataSet1 = New SummaryInCaption.DataSet1()
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.sqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterOrders = New System.Data.SqlClient.SqlDataAdapter()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.startTimerButton = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' northwindDataSet1
        ' 
        Me.northwindDataSet1.DataSetName = "DataSet1"
        Me.northwindDataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        ' 
        ' gridGroupingControl1
        ' 
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.DataSource = Me.northwindDataSet1.Orders
        Me.gridGroupingControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.ShowGroupDropArea = True
        Me.gridGroupingControl1.Size = New System.Drawing.Size(624, 361)
        Me.gridGroupingControl1.TabIndex = 0
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
        Me.sqlInsertCommand2.Connection = Me.sqlConnection2
        Me.sqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry")})
        ' 
        ' sqlUpdateCommand2
        ' 
        Me.sqlUpdateCommand2.Connection = Me.sqlConnection2
        Me.sqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"), New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID")})
        ' 
        ' sqlDeleteCommand2
        ' 
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
        Me.panel1.Location = New System.Drawing.Point(30, 24)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(624, 361)
        Me.panel1.TabIndex = 4
        ' 
        ' startTimerButton
        ' 
        Me.startTimerButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.startTimerButton.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(0))))))
        Me.startTimerButton.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.startTimerButton.ForeColor = System.Drawing.Color.White
        Me.startTimerButton.Location = New System.Drawing.Point(689, 24)
        Me.startTimerButton.Name = "startTimerButton"
        Me.startTimerButton.Size = New System.Drawing.Size(75, 23)
        Me.startTimerButton.TabIndex = 3
        Me.startTimerButton.Text = "Start Timer"
        Me.startTimerButton.UseVisualStyle = True
        Me.startTimerButton.UseVisualStyleBackColor = True
        ' 
        ' propertyGrid1
        ' 
        Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
        Me.propertyGrid1.CommandsForeColor = System.Drawing.SystemColors.ControlText
        Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
        Me.propertyGrid1.LineColor = System.Drawing.Color.White
        Me.propertyGrid1.Location = New System.Drawing.Point(689, 65)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(222, 320)
        Me.propertyGrid1.TabIndex = 5
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
        Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.ClientSize = New System.Drawing.Size(944, 420)
        Me.Controls.Add(Me.startTimerButton)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Real-Time Update Demo"
        CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub

#Region "Unbound Fields and Covered Ranges"

    Private Sub ordersDescriptor_QueryValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
        ' This methods maps from the underlying value to a related value

        Dim obj As Object = e.Record.GetValue("ShipVia")
        If obj IsNot Nothing AndAlso Not (TypeOf obj Is DBNull) Then
            Dim shipVia As Integer = CInt(Fix(obj))
            Select Case shipVia
                Case 0
                    e.Value = "null"
                Case 1
                    e.Value = "One"
                Case 2
                    e.Value = "Two"
                Case 3
                    e.Value = "Three"
            End Select
        End If
    End Sub

    Private captionCoverCols As Integer

    Private Sub TableModel_QueryCoveredRange(ByVal sender As Object, ByVal e As GridQueryCoveredRangeEventArgs)
        Dim thisTable As GridTable = Me.gridGroupingControl1.Table
        If e.RowIndex < thisTable.DisplayElements.Count Then
            Dim el As Element = thisTable.DisplayElements(e.RowIndex)

            Select Case el.Kind
                Case DisplayElementKind.Caption
                    ' Cover some cells of the caption bar (specified with captionCover)
                    Dim gs As IGridGroupOptionsSource = TryCast(el.ParentGroup, IGridGroupOptionsSource)
                    If gs IsNot Nothing AndAlso gs.GroupOptions.ShowCaptionSummaryCells Then
                        Dim startCol As Integer = el.GroupLevel + 1
                        If Not gs.GroupOptions.ShowCaptionPlusMinus Then
                            startCol -= 1
                        End If
                        If e.ColIndex >= startCol AndAlso e.ColIndex <= startCol + Me.captionCoverCols Then
                            e.Range = GridRangeInfo.Cells(e.RowIndex, startCol, e.RowIndex, startCol + Me.captionCoverCols)
                            e.Handled = True
                        End If
                    End If
                    Exit Select

            End Select
        End If

    End Sub

#End Region


End Class

