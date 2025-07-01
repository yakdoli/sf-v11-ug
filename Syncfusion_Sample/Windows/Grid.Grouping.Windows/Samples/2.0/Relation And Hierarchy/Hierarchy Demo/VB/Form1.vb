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
Imports System.Data.OleDb
Imports System.IO

Imports Syncfusion.Grouping

Imports Syncfusion.Collections
Imports Syncfusion.Drawing
Imports Syncfusion.ComponentModel
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.MetroForm



'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
    Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub 'Main

    Private groupingGrid1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Private dataSet21 As HierarchySample.DataSet1
    Private WithEvents expandAllButton As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents CollapseAllbutton As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents propertyGrid1 As System.Windows.Forms.PropertyGrid
    Private components As System.ComponentModel.IContainer
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>


    Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
        Dim n As Integer
        For n = 0 To 11
            If File.Exists(xmlFileName) Then
                ds.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" + xmlFileName
        Next n
    End Sub 'ReadXml


    Sub CheckVisibleCount(ByVal tb As Table)
        Dim v As Integer = tb.GetVisibleCount()

        tb.InvalidateCounterTopDown(True)
        If v <> tb.GetVisibleCount() Then
            Console.WriteLine("{0} <> {1}", v, tb.GetVisibleCount())
        End If
    End Sub 'CheckVisibleCount


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()


        Me.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.groupingGrid1.TopLevelGroupOptions.ShowCaption = False
        Me.groupingGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.groupingGrid1.GridOfficeScrollBars = OfficeScrollBars.Metro

        Try
            Dim ico As Icon = New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

        Me.groupingGrid1.ShowNavigationBar = True
        Me.groupingGrid1.TableControl.HorizontalScrollTips = False
        Me.groupingGrid1.BorderStyle = BorderStyle.FixedSingle
        Me.groupingGrid1.FilterRuntimeProperties = True
        Me.propertyGrid1.SelectedObject = Me.groupingGrid1


        Dim ds As New DataSet()
        ReadXml(ds, "Common\Data\Expand.xml")

        ds.Tables(1).TableName = "Products"
        ds.Tables(2).TableName = "OrderDetails"
        ds.Tables(3).TableName = "Suppliers"

        ds.Relations.Add(ds.Tables(0).Columns("CategoryID"), ds.Tables(1).Columns("CategoryID"))
        ds.Relations(0).RelationName = "Category_Products"

        ds.Relations.Add(ds.Tables(1).Columns("ProductID"), ds.Tables(2).Columns("ProductID"))
        ds.Relations(1).RelationName = "Products_OrderDetails"

        Me.groupingGrid1.DataSource = ds.Tables(0)

        Dim engine As GridEngine = Me.groupingGrid1.Engine

        engine.TopLevelGroupOptions.ShowCaption = True

        ' Record summary for Categories Tables

        Dim categoriesTableDescriptor As GridTableDescriptor = CType(engine.TableDescriptor, GridTableDescriptor)

        categoriesTableDescriptor.Columns.Clear()
        categoriesTableDescriptor.Columns.Add("CategoryID")
        categoriesTableDescriptor.Columns.Add("CategoryName")
        categoriesTableDescriptor.Columns.Add("Description")

        categoriesTableDescriptor.Columns("CategoryName").Width = 200

        Dim countCat As New GridSummaryColumnDescriptor("RecordCount")
        countCat.SummaryType = SummaryType.Count
        countCat.Style = GridSummaryStyle.FillRow
        countCat.DataMember = "CategoryID"
        countCat.Format = "      {Count} Records."

        Dim categoriesSummaryRow As New GridSummaryRowDescriptor("RecordCountRow")
        categoriesSummaryRow.SummaryColumns.Add(countCat)
        categoriesTableDescriptor.SummaryRows.Add(categoriesSummaryRow)

        ' Group Products table by "SupplierID"
        Dim productsRelationDescriptor As RelationDescriptor = categoriesTableDescriptor.Relations("Products")
        Dim productsTableDescriptor As GridTableDescriptor = CType(productsRelationDescriptor.ChildTableDescriptor, GridTableDescriptor)
        productsTableDescriptor.GroupedColumns.Add("SupplierID")

        ' Group OrderDetails table by "Discount"
        ' Add Total = "[UnitPrice]*[Quantity]" expression field
        ' Add Summaries for Total and Average for UnitPrice.
        Dim orderDetailsRelationDescriptor As RelationDescriptor = productsTableDescriptor.Relations("OrderDetails")
        Dim orderDetailsTableDescriptor As GridTableDescriptor = CType(orderDetailsRelationDescriptor.ChildTableDescriptor, GridTableDescriptor)

        Dim ed As New ExpressionFieldDescriptor("Total", "[UnitPrice]*[Quantity]")
        ed.DefaultValue = ""
        orderDetailsTableDescriptor.ExpressionFields.Add(ed)
        orderDetailsTableDescriptor.GroupedColumns.Add("Discount")

        Dim orderDetailsSummaryRow As New GridSummaryRowDescriptor("Total")
        orderDetailsTableDescriptor.SummaryRows.Add(orderDetailsSummaryRow)

        Dim totalSum As New GridSummaryColumnDescriptor("Total")
        totalSum.SummaryType = SummaryType.DoubleAggregate
        totalSum.Style = GridSummaryStyle.Column
        totalSum.DataMember = "Total"
        totalSum.DisplayColumn = "Total"
        totalSum.Format = "Sum={Sum}"
        orderDetailsSummaryRow.SummaryColumns.Add(totalSum)


        orderDetailsTableDescriptor.Columns("Total").Width = 70


        Dim avgUnitPrice As New GridSummaryColumnDescriptor("AvgUnitPrice")
        avgUnitPrice.SummaryType = SummaryType.DoubleAggregate
        avgUnitPrice.Style = GridSummaryStyle.Column
        avgUnitPrice.DataMember = "UnitPrice"
        avgUnitPrice.DisplayColumn = "UnitPrice"
        avgUnitPrice.Format = "Avg={Average:#.0}"
        orderDetailsSummaryRow.SummaryColumns.Add(avgUnitPrice)

        ' expand a specific record, search for groups etc.
        Dim categoriesTable As Table = engine.Table '.RelatedTables["Categories"];
        Console.WriteLine(categoriesTable.ToString())

        Dim productsTable As Table = categoriesTable.RelatedTables("Products")
        Console.WriteLine(productsTable.ToString())

        ' Get the child table in the products table that is assocuated with category "1"
        Dim product1 As ChildTable = CType(productsTable.TopLevelGroup.Groups("1"), ChildTable)
        Console.WriteLine(product1.ToString())
        Console.WriteLine(product1.Groups(0).ToString())

        ' Get the child table in the products table that is assocuated with category "1"
        Dim product21 As ChildTable = CType(productsTable.TopLevelGroup.Groups("8"), ChildTable)
        Console.WriteLine(product21.ToString())
        Console.WriteLine(product21.Groups(0).Records(0).ToString())

        ' Show me the associated "NestedTable" element of the categories table (the NestedTable 
        ' element established the link between parent table and a nested child table)
        Console.WriteLine(product21.Groups(0).Records(0).ParentChildTable.ParentNestedTable)

        ' Expand the product for category 8
        product21.IsExpanded = True
        product21.ParentNestedTable.IsExpanded = True
        product21.ParentNestedTable.ParentRecord.IsExpanded = True

        ' When you assign a "DataSet" as a datasource, the DataSet is a list with one record (not allowing AddNew) with nested tables.
        ' Expand the first record so that tables are shown.
        engine.Table.TopLevelGroup.Records(0).IsExpanded = True

        ' Sort  product table by ProductName 
        product21.ParentTable.TableDescriptor.SortedColumns.Add("ProductName")

        ' Find group for supplier id 21
        Dim supplier21Group As Group = product21.Groups("21")

        ' Find productname Spegesild in that group
        Dim index As Integer = supplier21Group.Records.FindRecord("Spegesild")

        ' Print out the row index and record index
        Dim r As Record = supplier21Group.Records(index)
        Console.WriteLine("Found: " + r.ToString())
        Console.WriteLine("RowIndex " + engine.Table.NestedDisplayElements.IndexOf(r).ToString())
        Console.WriteLine("Record Index " + engine.Table.Records.IndexOf(r).ToString())

        ' Dump out nested display elements to console


        Me.groupingGrid1.Table.Records(0).IsExpanded = True
        Me.groupingGrid1.Table.TopLevelGroup.IsExpanded = True

        engine.ChildGroupOptions.ShowCaption = True
        engine.NestedTableGroupOptions.ShowCaption = True

        ' Adding GroupDropAreas for nested tables.
        groupingGrid1.AddGroupDropArea(CType(productsTable, GridTable))
        groupingGrid1.AddGroupDropArea(CType(productsTable.RelatedTables(0), GridTable))
        groupingGrid1.ShowGroupDropArea = True

        ' Make Spegesild current record
        If Not (r Is Nothing) Then
            r.SetCurrent()

            ' Expand record and nested tables
            r.IsExpanded = True
            r.NestedTables(0).IsExpanded = True

            Dim orderDetailsRecords As Record = r.NestedTables(0).ChildTable.GetFirstRecord()
            ' Expand Group record belongs to
            orderDetailsRecords.ParentGroup.IsExpanded = True

            ' Scroll this record in view.
            groupingGrid1.TableControl.ScrollInView(orderDetailsRecords)
            groupingGrid1.TableControl.LeftColIndex = 1
        End If
    End Sub 'New

    Private Function GetIconFile(ByVal bitmapName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(bitmapName) Then
                Return bitmapName
            End If

            bitmapName = "..\" & bitmapName
        Next n

        Return bitmapName
    End Function


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.groupingGrid1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.expandAllButton = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.CollapseAllbutton = New Syncfusion.Windows.Forms.ButtonAdv()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        CType(Me.groupingGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupingGrid1
        '
        Me.groupingGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupingGrid1.BackColor = System.Drawing.SystemColors.Window
        Me.groupingGrid1.Location = New System.Drawing.Point(0, 0)
        Me.groupingGrid1.Name = "groupingGrid1"
        Me.groupingGrid1.Size = New System.Drawing.Size(431, 347)
        Me.groupingGrid1.TabIndex = 1
        Me.groupingGrid1.Text = "groupingGrid1"
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" & _
            ", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & _
            "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})})
        '
        'expandAllButton
        '
        Me.expandAllButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.expandAllButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.expandAllButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandAllButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.expandAllButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expandAllButton.ForeColor = System.Drawing.Color.White
        Me.expandAllButton.Location = New System.Drawing.Point(392, 367)
        Me.expandAllButton.Name = "expandAllButton"
        Me.expandAllButton.Size = New System.Drawing.Size(128, 24)
        Me.expandAllButton.TabIndex = 2
        Me.expandAllButton.Text = "Expand All"
        Me.expandAllButton.UseVisualStyle = True
        '
        'CollapseAllbutton
        '
        Me.CollapseAllbutton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CollapseAllbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.CollapseAllbutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CollapseAllbutton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.CollapseAllbutton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollapseAllbutton.ForeColor = System.Drawing.Color.White
        Me.CollapseAllbutton.Location = New System.Drawing.Point(552, 367)
        Me.CollapseAllbutton.Name = "CollapseAllbutton"
        Me.CollapseAllbutton.Size = New System.Drawing.Size(128, 24)
        Me.CollapseAllbutton.TabIndex = 2
        Me.CollapseAllbutton.Text = "Collapse All"
        Me.CollapseAllbutton.UseVisualStyle = True
        '
        'propertyGrid1
        '
        Me.propertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid1.BackColor = System.Drawing.Color.White
        Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.White
        Me.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White
        Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
        Me.propertyGrid1.LineColor = System.Drawing.Color.White
        Me.propertyGrid1.Location = New System.Drawing.Point(456, 0)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(255, 347)
        Me.propertyGrid1.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(714, 403)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.expandAllButton)
        Me.Controls.Add(Me.groupingGrid1)
        Me.Controls.Add(Me.CollapseAllbutton)
        Me.DropShadow = True
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Hierarchy Demo"
        CType(Me.groupingGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region



    Private Sub menuItemExitApp_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub 'menuItemExitApp_Click


    Private Sub menuItemDsChoose_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        _ShowGridColumnsDialog(Me.groupingGrid1.Engine.TableDescriptor, "Columns", Nothing, GetType(GridColumnDescriptorCollection))
    End Sub 'menuItemDsChoose_Click

    Friend Function _ShowGridColumnsDialog(ByVal instance As Object, ByVal propertyName As String, ByVal provider As IServiceProvider, ByVal type As Type) As DialogResult
        Dim ce As New GroupingCollectionEditor(type)
        Dim esc As New Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(provider)
        Dim pd As PropertyDescriptor = TypeDescriptor.GetProperties(instance)(propertyName)
        Dim tdc As New Syncfusion.ComponentModel.TypeDescriptorContext(instance, pd)
        tdc.ServiceProvider = esc

        ce.EditValue(tdc, esc, pd.GetValue(instance))

        Dim control As Control = instance '
        If Not (control Is Nothing) Then
            control.Invalidate()
        End If
        Me.groupingGrid1.Refresh()

        Return esc.DialogResult
    End Function '_ShowGridColumnsDialog



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub 'Form1_Load



    Private Sub menuItemXPThemes_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim standard As GridStyleInfo = Me.groupingGrid1.Engine.Appearance.AnyCell
        standard.Themed = Not standard.Themed
        Me.groupingGrid1.ThemesEnabled = standard.Themed
        Me.groupingGrid1.Refresh()
    End Sub 'menuItemXPThemes_Click


    Private Sub expandAllButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles expandAllButton.Click
        ' Set focus back to grid
        Me.ActiveControl = groupingGrid1

        ' Scroll to top
        groupingGrid1.TableControl.VScrollBar.Value = groupingGrid1.TableControl.VScrollBar.Minimum

        ' Determine current element. If it is a nested table, get the current element of the child table.
        Dim el As Element = Me.groupingGrid1.Table.CurrentElement
        While TypeOf el Is NestedTable
            el = CType(el, NestedTable).ChildTable.ParentTable.CurrentElement
        End While
        ' Expand all records
        Me.groupingGrid1.Table.ExpandAllRecords()

        ' Scroll current record into view.
        If Not (el Is Nothing) Then
            ' Restore Current Field 
            el.ParentTable.CurrentRecordManager.NavigateTo(el)

            ' Scroll element into view
            groupingGrid1.TableControl.ScrollInView(el)
        End If

        ' Synchronize grid display with engine changes.
        Me.groupingGrid1.Update()

        Console.WriteLine(Me.groupingGrid1.Table.GetCounter())
    End Sub 'expandAllButton_Click


    Private Sub CollapseAllbutton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CollapseAllbutton.Click
        ' Set focus back to grid
        Me.ActiveControl = groupingGrid1

        ' Scroll to top
        groupingGrid1.TableControl.VScrollBar.Value = groupingGrid1.TableControl.VScrollBar.Minimum

        ' Determine current element. If it is a nested table, get the parent record.
        Dim el As Element = Me.groupingGrid1.Table.CurrentElement
        While TypeOf el Is NestedTable
            el = el.ParentRecord
        End While
        ' Collapse all records.
        Me.groupingGrid1.Table.CollapseAllRecords()
        Me.groupingGrid1.Table.CollapseAllGroups()

        ' Scroll current record into view.
        If Not (el Is Nothing) Then
            ' Restore Current Field 
            el.ParentTable.CurrentRecordManager.NavigateTo(el)

            ' Scroll element into view
            groupingGrid1.TableControl.ScrollInView(el)
        End If

        ' Synchronize grid display with engine changes.
        Me.groupingGrid1.Update()
    End Sub 'CollapseAllbutton_Click

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim abtForm As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
        abtForm.ShowDialog()
    End Sub
End Class 'Form1
