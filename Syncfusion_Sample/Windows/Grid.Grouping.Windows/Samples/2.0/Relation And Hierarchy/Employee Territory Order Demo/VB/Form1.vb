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

Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Grouping


''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits MetroForm
    Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Private sqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    Private sqlDataAdapterTerritories As System.Data.SqlClient.SqlDataAdapter
    Private sqlDataAdapterRegion As System.Data.SqlClient.SqlDataAdapter
    Private sqlDataAdapterEmployeeTerritories As System.Data.SqlClient.SqlDataAdapter
    Private sqlDataAdapterEmployees As System.Data.SqlClient.SqlDataAdapter
    Private sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Private northwindDataSet1 As NorthwindDataSet
    Private sqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapterOrders As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapterOrderDetails As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapterProducts As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapterShippers As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapterSuppliers As System.Data.SqlClient.SqlDataAdapter
    Private sqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Private sqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapterCategories As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand10 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand10 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapterCustomers As System.Data.SqlClient.SqlDataAdapter
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing

    Private msdeAvailable As Boolean = False
    Private WithEvents comboBoxEmployeeTerritoriesRelationKind As System.Windows.Forms.ComboBox
    Private label1 As System.Windows.Forms.Label
    Private xmlName As String = "EmployeeTerritoryOrder.xml"
    Private panel1 As Panel
    Private Sub InitializeDataSet()
        If msdeAvailable Then
            ' Initialize the data set

            Me.northwindDataSet1.BeginInit()

            ' Order is important here - first fill tables that are referenced with
            ' foreign keys, then tables that have references to others.

            Me.sqlDataAdapterCategories.Fill(Me.northwindDataSet1)
            Me.sqlDataAdapterShippers.Fill(Me.northwindDataSet1)
            Me.sqlDataAdapterSuppliers.Fill(Me.northwindDataSet1)
            Me.sqlDataAdapterProducts.Fill(Me.northwindDataSet1)

            Me.sqlDataAdapterCustomers.Fill(Me.northwindDataSet1)

            Me.sqlDataAdapterEmployees.Fill(Me.northwindDataSet1)
            Me.sqlDataAdapterRegion.Fill(Me.northwindDataSet1)
            Me.sqlDataAdapterTerritories.Fill(Me.northwindDataSet1)
            Me.sqlDataAdapterEmployeeTerritories.Fill(Me.northwindDataSet1)

            Me.sqlDataAdapterOrders.Fill(Me.northwindDataSet1)
            Me.sqlDataAdapterOrderDetails.Fill(Me.northwindDataSet1)

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


    Public Sub New()
        '
        Engine.VerboseEnsureObjectLifeTime = True

        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Me.northwindDataSet1 = New NorthwindDataSet()
        Me.northwindDataSet1.DataSetName = "NorthwindDataSet"
        Me.northwindDataSet1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        Try
            Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

        ' Initialize the data set
        InitializeDataSet()
        Me.gridGroupingControl1.DataSource = Me.northwindDataSet1.Employees
        Me.gridGroupingControl1.TableOptions.GridVisualStyles = GridVisualStyles.Metro
        Me.gridGroupingControl1.TableOptions.GridLineBorder = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False

        'this.gridGroupingControl1.TableDescriptor.Relations.LoadDefault();
        'return;
        ' above call if commented out would autopopulate relations and extract
        ' information for RegionTerritories, TerritoriesEmployeeTerritories
        ' and EmployeesEmployeeTerritories from the DataSet.


        ' NOTE: If you open NorthwindDataSet.xsd and right click on the
        ' relation between Products and Suppliers and select "Edit Relation"
        ' you will notice in the dialog that is shown that the
        ' DataSet property "Create foreign key constraint Only" has been checked.
        ' This setting allows the grouping engine to differentiate between
        ' foreign key relations and master details relations when autopopulating
        ' relations.
        '
        ' Check out also the "PrintGroupingGrid" sample code. In its form constructor
        ' it shows how to avoid columns being automatically added to the parent table for each
        ' column in the foreign table. It does instead manually add those columns
        ' from the referenced table by setting ShowRelationFields = ShowRelationFields.Hide
        ' and calling Columns.Add("ForeignTable.ColumnName")


        ' manually setting up relations
        Me.gridGroupingControl1.TableDescriptor.Relations.Clear()


        '
        ' The dataset has ForeignKeyConstraints defined for RegionTerritories, TerritoriesEmployeeTerritories
        ' and EmployeesEmployeeTerritories relations. GridRelationDescriptor can extract information from dataset
        ' when you specify GridRelationDescriptor.MappingName.
        '
        ' The dataset does not contain information about the ReportsTo, USStates and Countries relation.
        '
        ' For ReportsTo we specify the ChildTableName and RelationKeys. We also hook an event for
        ' displaying an unbound field in the foreign table.
        '
        ' For Countries and USStates we again specify the ChildTableName and RelationKeys.
        ' Countries is a strong-typed ArrayList (Indexer is strong typed).
        ' USStates is a ArrayList with ITypedList implementation that returns a custom property descriptor.
        '

        '
        ' Register all collections to be used
        '

        Me.gridGroupingControl1.Engine.SourceListSet.InitializeFromDataSet(Me.northwindDataSet1)
        ' above call is actually not necessary - when you set groupingControl.DataSource = northwindDataSet1.Employees;
        ' it will automatically call SourceListSet.InitializeFromDataSet

        ' The Countries and USStates on the other side must be registered with the Engine.SourceListSet.
        ' Registration with Engine.SourceListSet is necessary for all collections that do not belong to the dataset
        ' assigned to groupingControl.DataSource

        Me.gridGroupingControl1.Engine.SourceListSet.Add("Countries", CountriesCollection.CreateDefaultCollection())
        Me.gridGroupingControl1.Engine.SourceListSet.Add("USStates", USStatesCollection.CreateDefaultCollection())

        '
        ' General Settings
        '

        Dim mainTd As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor

        ' No captions and force all records in Employees table to be expanded so that nested Table captions are visible
        Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
        mainTd.TableOptions.ShowRecordPlusMinus = False

        '
        ' EmployeeTerritories
        '

        ' Setting up Master-Details Relation betwen Employess and Territories
        Dim gridRelationDescriptor1 As New GridRelationDescriptor()
        gridRelationDescriptor1.MappingName = "EmployeesEmployeeTerritories"
        Me.gridGroupingControl1.TableDescriptor.Relations.Add(gridRelationDescriptor1)

        ' Territories has nested foreign key relation with Territory table
        Dim gridRelationDescriptor2 As New GridRelationDescriptor()
        gridRelationDescriptor2.MappingName = "TerritoriesEmployeeTerritories"
        gridRelationDescriptor1.ChildTableDescriptor.Relations.Add(gridRelationDescriptor2)

        ' Territory has nested foreign key relation with Region
        Dim gridRelationDescriptor3 As New GridRelationDescriptor()
        gridRelationDescriptor3.MappingName = "RegionTerritories"
        gridRelationDescriptor2.ChildTableDescriptor.Relations.Add(gridRelationDescriptor3)

        ' setup columns and various other options for each of the relations.

        ' MasterDetails: EmployeesEmployeeTerritories
        gridRelationDescriptor1.ChildTableDescriptor.TopLevelGroupOptions.ShowCaption = True
        gridRelationDescriptor1.ChildTableDescriptor.InheritAppearanceFomParent = False
        gridRelationDescriptor1.ChildTableDescriptor.Columns.Clear()
        gridRelationDescriptor1.ChildTableDescriptor.Columns.AddRange(New GridColumnDescriptor() {New GridColumnDescriptor("EmployeeID"), New GridColumnDescriptor("Territory", "Territories_TerritoryDescription"), New GridColumnDescriptor("Region", "Territories_Region_RegionDescription")})

        ' Foreign Key: TerritoriesEmployeeTerritories
        gridRelationDescriptor2.ChildTableDescriptor.InheritAppearanceFomParent = False
        gridRelationDescriptor2.ChildTableDescriptor.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        gridRelationDescriptor2.ChildTableDescriptor.Columns.Clear()
        gridRelationDescriptor2.ChildTableDescriptor.Columns.AddRange(New GridColumnDescriptor() {New GridColumnDescriptor("TerritoryID"), New GridColumnDescriptor("TerritoryDescription"), New GridColumnDescriptor("Region", "Region_RegionDescription")})

        ' Foreign Key: RegionTerritories
        gridRelationDescriptor3.ChildTableDescriptor.InheritAppearanceFomParent = False




        '
        ' ReportsTo
        '

        ' Add an additional foreign key relation for ReportsTo
        Dim reportsToRd As New GridRelationDescriptor()
        reportsToRd.RelationKind = RelationKind.ForeignKeyReference

        reportsToRd.Name = "ReportsTo" ' Prefix for fields that get added to main table (e.g. ReportsTo_Title)
        reportsToRd.ChildTableName = "Employees" ' Name to look up related table in Engine.SourceListSet
        reportsToRd.RelationKeys.Add("ReportsTo", "EmployeeID") ' Foreign key and primary in related table.

        reportsToRd.ChildTableDescriptor.Relations.Clear() ' don't autopopulate further nested relations - avoid recursion


        ' Unbound field: Event to fill ReportsTo_LastNameAndTitle with formatted text.
        reportsToRd.ChildTableDescriptor.UnboundFields.Add("LastNameAndTitle") ' "[LastName] + '(' + [Title] + ')'"));
        AddHandler gridGroupingControl1.QueryValue, AddressOf gridGroupingControl1_QueryValue

        reportsToRd.ChildTableDescriptor.Fields.Clear() ' don't autopopulate - specify fields that get pulled in from main table.
        reportsToRd.ChildTableDescriptor.Fields.Add("EmployeeID") ' primary key - must be available as field
        reportsToRd.ChildTableDescriptor.Fields.Add("LastName") ' will be shown as ReportsTo_LastName in main table.
        reportsToRd.ChildTableDescriptor.Fields.Add("Title") ' will be shown as ReportsTo_Title in main table.
        reportsToRd.ChildTableDescriptor.Fields.Add("LastNameAndTitle") ' will be shown as ReportsTo_LastNameAndTitle in main table.

        ' Just FYI: reportsToRd has not been added to Relations yet - so if we would not have manually added
        ' fields above the LoadDefault() call would not find any columns. But we added fields so its not an issue
        Dim start As DateTime = DateTime.Now
        If DateTime.Now.Subtract(start).TotalSeconds > 5 Then 'added
            Application.DoEvents()
            start = DateTime.Now
            reportsToRd.ChildTableDescriptor.VisibleColumns.LoadDefault()
            reportsToRd.ChildTableDescriptor.VisibleColumns.Remove("EmployeeID") ' hide EmployeeID column in dropdown, other columns are autopopulated.
            reportsToRd.ChildTableDescriptor.VisibleColumns.Remove("LastNameAndTitle")

            reportsToRd.ChildTableDescriptor.AllowEdit = False ' don't allow edit dropdown and
            reportsToRd.ChildTableDescriptor.AllowNew = False ' hide pencil button

            mainTd.Relations.Add(reportsToRd) ' At this time the relation descriptor is attached to the engine.

            mainTd.InheritAppearanceFomParent = False

            ' mainTd is already connected to the engine and the engine has a valid datasource. Therefore
            ' LoadDefault will be able to populate all columns from the table.
            mainTd.VisibleColumns.LoadDefault()
            mainTd.VisibleColumns.Remove("ReportsTo_Title") ' will be shown as ReportsTo_Title in main table.
            mainTd.VisibleColumns.Remove("ReportsTo_LastName") ' will be shown as ReportsTo_LastName in main table.
            ' one field that remains is: "ReportsTo_LastNameAndTitle"

            ' You can create relations to collections that do not belong to the Dataset. You can create relationships between any IList derived collections.

            ' The Countries and USStates on the other side must be registered with the Engine.SourceListSet.
            ' see code earlier: this.gridGroupingControl1.Engine.SourceListSet.Add("Countries", CountriesCollection.CreateDefaultCollection());
            ' see code earlier: this.gridGroupingControl1.Engine.SourceListSet.Add("USStates", USStatesCollection.CreateDefaultCollection());

            '
            ' USStates
            '

            Dim usStatesRd As New GridRelationDescriptor()
            usStatesRd.Name = "State"
            usStatesRd.RelationKind = RelationKind.ForeignKeyReference
            usStatesRd.ChildTableName = "USStates" ' SourceListSet name for lookup
            usStatesRd.RelationKeys.Add("Region", "Key")

            ' Let's also customize the appearance of the dropdown table here:
            usStatesRd.ChildTableDescriptor.Columns.Add(New GridColumnDescriptor("State", "Description")) ' Description is a a custom property descriptor in USStatesCollection
            usStatesRd.ChildTableDescriptor.SortedColumns.Add("State")
            usStatesRd.ChildTableDescriptor.AllowEdit = False
            usStatesRd.ChildTableDescriptor.AllowNew = False ' Make pencil icon disappear, users can't modify states.
            mainTd.Relations.Add(usStatesRd)

            '
            ' Countries
            '

            Dim countriesRd As New GridRelationDescriptor()
            countriesRd.Name = "Country" ' default will be ChildTableName = "Countries"
            countriesRd.RelationKind = RelationKind.ForeignKeyReference
            countriesRd.ChildTableName = "Countries" ' SourceListSet name for lookup
            countriesRd.RelationKeys.Add("Country", "CountryCode")
            countriesRd.ChildTableDescriptor.AllowEdit = True
            countriesRd.ChildTableDescriptor.AllowNew = True ' Make pencil icon appear, allow user to add countries (these setting will be overriden by CountriesCollection.IsReadOnly / CountriesCollection.IsFixedSize properties if they are true).
            mainTd.Relations.Add(countriesRd)



            ' Replace the columns with foreign key descriptions. The ColumnSets and VisibleColumns
            ' collection will be able to pick up the columns since the
            ' name of the columns stays the same.
            mainTd.Columns("ReportsTo").MappingName = "ReportsTo_LastNameAndTitle"
            mainTd.Columns("Country").MappingName = "Country_Name"
            mainTd.Columns("Region").MappingName = "State_Name"


            '
            ' Orders
            '

            ' Setting up Master-Details Relation betwen Employess and Orders

            ' let's just autopopulate ChildTableDescriptor and nested relations for EmployeesOrders.
            Dim gridRelationDescriptor4 As New GridRelationDescriptor()
            gridRelationDescriptor4.MappingName = "EmployeesOrders"

            gridRelationDescriptor4.ChildTableDescriptor.TopLevelGroupOptions.ShowCaption = True
            mainTd.Relations.Add(gridRelationDescriptor4)

            '
            ' comboBoxEmployeeTerritoriesRelationKind Combobox
            '

            comboBoxEmployeeTerritoriesRelationKind.Text = Me.EmployeeTerritoriesRelationKind.ToString()

            Me.gridGroupingControl1.Table.CollapseAllRecords()

            Me.gridGroupingControl1.Table.Records(0).NestedTables("EmployeeTerritories").IsExpanded = True

            Me.gridGroupingControl1.Table.Records(0).NestedTables("Orders").Records(0).NestedTables("Order Details").Records(0).SetCurrent("Products_ProductName")


            Dim testReadWriteXmlSchema As Boolean = False
            If testReadWriteXmlSchema Then
                Dim fileName As String = "EmployeeTerritoryOrderEngineSchema.xml"
                Dim fullPath As String = System.IO.Path.GetFullPath(fileName)

                Console.WriteLine("Writing " & fullPath)

                Dim xw As New System.Xml.XmlTextWriter(fileName, System.Text.Encoding.UTF8)
                Me.gridGroupingControl1.WriteXmlSchema(xw)
                xw.Close()

                Console.WriteLine("Reading " & fullPath)

                Dim xr As System.Xml.XmlReader = New System.Xml.XmlTextReader(fileName)
                Me.gridGroupingControl1.Engine = GridEngine.CreateFromXml(xr)
                xr.Close()

                ' A nice exercise:
                ' You can load the xml we created here into the designer when you click on the "Choose Xml Schema ..." verb.
                ' If you then save the change (click View Code) the schema is then serialized back as
                ' code statement into the InitializeComponent code of this form.
            End If
        End If
        AddHandler gridGroupingControl1.TableControlCurrentCellShowingDropDown, AddressOf gridGroupingControl1_TableControlCurrentCellShowingDropDown
    End Sub

    Private Sub gridGroupingControl1_TableControlCurrentCellShowingDropDown(ByVal sender As Object, ByVal e As GridTableControlCurrentCellShowingDropDownEventArgs)
        Dim rend As GridTableDropDownListCellRenderer = TryCast(e.TableControl.CurrentCell.Renderer, GridTableDropDownListCellRenderer)
        If rend IsNot Nothing Then
            rend.TextBox.DeselectAll()
        End If
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
        Dim gridColumnDescriptor1 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim gridColumnDescriptor2 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim gridColumnDescriptor3 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim gridColumnDescriptor4 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim gridColumnDescriptor5 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim gridColumnDescriptor6 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim gridColumnDescriptor7 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim gridColumnDescriptor8 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor()
        Dim gridColumnSetDescriptor1 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor()
        Dim gridColumnSetDescriptor2 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor()
        Dim gridColumnSetDescriptor3 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor()
        Dim gridColumnSetDescriptor4 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor()
        Dim gridColumnSetDescriptor5 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor()
        Dim gridColumnSetDescriptor6 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor()
        Dim gridColumnSetDescriptor7 As New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor()
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.sqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterTerritories = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterRegion = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlDataAdapterEmployeeTerritories = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlDataAdapterEmployees = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterOrders = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterOrderDetails = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterProducts = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlSelectCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterShippers = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlSelectCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterSuppliers = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand8 = New System.Data.SqlClient.SqlCommand()
        Me.sqlSelectCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterCategories = New System.Data.SqlClient.SqlDataAdapter()
        Me.sqlSelectCommand11 = New System.Data.SqlClient.SqlCommand()
        Me.sqlInsertCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapterCustomers = New System.Data.SqlClient.SqlDataAdapter()
        Me.comboBoxEmployeeTerritoriesRelationKind = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.panel1 = New System.Windows.Forms.Panel()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' gridGroupingControl1
        ' 
        Me.gridGroupingControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.gridGroupingControl1.Appearance.AlternateRecordFieldCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.RecordPreviewCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.CellType = "Static"
        Me.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.Enabled = False
        Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = True
        Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.gridGroupingControl1.Appearance.AnyCell.Font.Size = 8.25F
        Me.gridGroupingControl1.Appearance.RecordPreviewCell.TextColor = Color.DimGray
        Me.gridGroupingControl1.Appearance.RecordPreviewRowHeaderCell.TextColor = Color.DimGray
        Me.gridGroupingControl1.Appearance.AnyGroupCell.TextColor = Color.DimGray
        Me.gridGroupingControl1.Appearance.AnyRecordFieldCell.TextColor = Color.DimGray
        Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro

        Me.gridGroupingControl1.Location = New System.Drawing.Point(24, 12)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.Size = New System.Drawing.Size(728, 392)
        Me.gridGroupingControl1.TabIndex = 0
        gridColumnDescriptor1.HeaderText = "ID"
        gridColumnDescriptor1.MappingName = "EmployeeID"
        gridColumnDescriptor1.Width = 60
        gridColumnDescriptor2.MappingName = "FirstName"
        gridColumnDescriptor2.Width = 115
        gridColumnDescriptor3.MappingName = "Address"
        gridColumnDescriptor3.Width = 118
        gridColumnDescriptor4.MappingName = "City"
        gridColumnDescriptor4.Width = 83
        gridColumnDescriptor5.MappingName = "Region"
        gridColumnDescriptor5.Width = 100
        gridColumnDescriptor6.MappingName = "Country"
        gridColumnDescriptor6.Width = 80
        gridColumnDescriptor7.MappingName = "Title"
        gridColumnDescriptor7.Width = 144
        gridColumnDescriptor8.MappingName = "TitleOfCourtesy"
        gridColumnDescriptor8.Width = 133
        Me.gridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {gridColumnDescriptor1, gridColumnDescriptor2, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("LastName"), gridColumnDescriptor3, gridColumnDescriptor4, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("PostalCode"), gridColumnDescriptor5, gridColumnDescriptor6, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("BirthDate"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("Photo"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ReportsTo"), gridColumnDescriptor7, gridColumnDescriptor8})
        gridColumnSetDescriptor1.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("EmployeeID", "R0C0:R1C0")})
        gridColumnSetDescriptor1.Name = "ColumnSetId"
        gridColumnSetDescriptor2.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Photo", "R0C0:R1C0")})
        gridColumnSetDescriptor2.Name = "ColumnSetPhoto"
        gridColumnSetDescriptor3.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("FirstName", "R0C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("LastName", "R1C0")})
        gridColumnSetDescriptor3.Name = "ColumnSetName"
        gridColumnSetDescriptor4.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Address", "R0C0:R0C1"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("City", "R1C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("PostalCode", "R1C1")})
        gridColumnSetDescriptor4.Name = "ColumnSetAddress"
        gridColumnSetDescriptor5.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Region", "R0C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Country", "R1C0")})
        gridColumnSetDescriptor5.Name = "ColumnSetRegionCountry"
        gridColumnSetDescriptor6.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("Title", "R0C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("ReportsTo", "R1C0")})
        gridColumnSetDescriptor6.Name = "ColumnSetTitle"
        gridColumnSetDescriptor7.ColumnSpans.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("BirthDate", "R0C0"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSpanDescriptor("TitleOfCourtesy", "R1C0")})
        gridColumnSetDescriptor7.Name = "ColumnSetBirth"
        Me.gridGroupingControl1.TableDescriptor.ColumnSets.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnSetDescriptor() {gridColumnSetDescriptor1, gridColumnSetDescriptor2, gridColumnSetDescriptor3, gridColumnSetDescriptor4, gridColumnSetDescriptor5, gridColumnSetDescriptor6, gridColumnSetDescriptor7})
        Me.gridGroupingControl1.TableDescriptor.Name = "Employees"
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = True
        ' 
        ' northwindDataSet1
        ' 
       
        ' 
        ' sqlSelectCommand1
        ' 
        Me.sqlSelectCommand1.CommandText = "SELECT TerritoryID, TerritoryDescription, RegionID FROM Territories"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        ' 
        ' sqlConnection1
        ' 
        Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        ' 
        ' sqlInsertCommand1
        ' 
        Me.sqlInsertCommand1.Connection = Me.sqlConnection1
        Me.sqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TerritoryID", System.Data.SqlDbType.NVarChar, 20, "TerritoryID"), New System.Data.SqlClient.SqlParameter("@TerritoryDescription", System.Data.SqlDbType.NVarChar, 50, "TerritoryDescription"), New System.Data.SqlClient.SqlParameter("@RegionID", System.Data.SqlDbType.Int, 4, "RegionID")})
        ' 
        ' sqlUpdateCommand1
        ' 
        Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TerritoryID", System.Data.SqlDbType.NVarChar, 20, "TerritoryID"), New System.Data.SqlClient.SqlParameter("@TerritoryDescription", System.Data.SqlDbType.NVarChar, 50, "TerritoryDescription"), New System.Data.SqlClient.SqlParameter("@RegionID", System.Data.SqlDbType.Int, 4, "RegionID"), New System.Data.SqlClient.SqlParameter("@Original_TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TerritoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RegionID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RegionID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TerritoryDescription", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TerritoryDescription", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlSelectCommand2
        ' 
        Me.sqlSelectCommand2.CommandText = "SELECT RegionID, RegionDescription FROM Region"
        Me.sqlSelectCommand2.Connection = Me.sqlConnection1
        ' 
        ' sqlSelectCommand3
        ' 
        Me.sqlSelectCommand3.CommandText = "SELECT EmployeeID, TerritoryID FROM EmployeeTerritories"
        Me.sqlSelectCommand3.Connection = Me.sqlConnection1
        ' 
        ' sqlInsertCommand3
        ' 
        Me.sqlInsertCommand3.Connection = Me.sqlConnection1
        Me.sqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@TerritoryID", System.Data.SqlDbType.NVarChar, 20, "TerritoryID")})
        ' 
        ' sqlUpdateCommand3
        ' 
        Me.sqlUpdateCommand3.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@TerritoryID", System.Data.SqlDbType.NVarChar, 20, "TerritoryID"), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TerritoryID", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDeleteCommand3
        ' 
        Me.sqlDeleteCommand3.CommandText = "DELETE FROM EmployeeTerritories WHERE (EmployeeID = @Original_EmployeeID) AND (Te" & "rritoryID = @Original_TerritoryID)"
        Me.sqlDeleteCommand3.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TerritoryID", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlSelectCommand4
        ' 
        Me.sqlSelectCommand4.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDa" & "te, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Not" & "es, ReportsTo, PhotoPath FROM Employees"
        Me.sqlSelectCommand4.Connection = Me.sqlConnection1
        ' 
        ' sqlInsertCommand4
        ' 
        Me.sqlInsertCommand4.Connection = Me.sqlConnection1
        Me.sqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"), New System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"), New System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 30, "Title"), New System.Data.SqlClient.SqlParameter("@TitleOfCourtesy", System.Data.SqlDbType.NVarChar, 25, "TitleOfCourtesy"), New System.Data.SqlClient.SqlParameter("@BirthDate", System.Data.SqlDbType.DateTime, 8, "BirthDate"), New System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.DateTime, 8, "HireDate"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@HomePhone", System.Data.SqlDbType.NVarChar, 24, "HomePhone"), New System.Data.SqlClient.SqlParameter("@Extension", System.Data.SqlDbType.NVarChar, 4, "Extension"), New System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.VarBinary, 2147483647, "Photo"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 1073741823, "Notes"), New System.Data.SqlClient.SqlParameter("@ReportsTo", System.Data.SqlDbType.Int, 4, "ReportsTo"), New System.Data.SqlClient.SqlParameter("@PhotoPath", System.Data.SqlDbType.NVarChar, 255, "PhotoPath")})
        ' 
        ' sqlUpdateCommand4
        ' 
        Me.sqlUpdateCommand4.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 20, "LastName"), New System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 10, "FirstName"), New System.Data.SqlClient.SqlParameter("@Title", System.Data.SqlDbType.NVarChar, 30, "Title"), New System.Data.SqlClient.SqlParameter("@TitleOfCourtesy", System.Data.SqlDbType.NVarChar, 25, "TitleOfCourtesy"), New System.Data.SqlClient.SqlParameter("@BirthDate", System.Data.SqlDbType.DateTime, 8, "BirthDate"), New System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.DateTime, 8, "HireDate"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@HomePhone", System.Data.SqlDbType.NVarChar, 24, "HomePhone"), New System.Data.SqlClient.SqlParameter("@Extension", System.Data.SqlDbType.NVarChar, 4, "Extension"), New System.Data.SqlClient.SqlParameter("@Photo", System.Data.SqlDbType.VarBinary, 2147483647, "Photo"), New System.Data.SqlClient.SqlParameter("@Notes", System.Data.SqlDbType.NVarChar, 1073741823, "Notes"), New System.Data.SqlClient.SqlParameter("@ReportsTo", System.Data.SqlDbType.Int, 4, "ReportsTo"), New System.Data.SqlClient.SqlParameter("@PhotoPath", System.Data.SqlDbType.NVarChar, 255, "PhotoPath"), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_BirthDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "BirthDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Extension", System.Data.SqlDbType.NVarChar, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Extension", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HireDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HomePhone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HomePhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PhotoPath", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PhotoPath", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReportsTo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReportsTo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TitleOfCourtesy", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID")})
        ' 
        ' sqlDeleteCommand4
        ' 
        Me.sqlDeleteCommand4.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_BirthDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "BirthDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Extension", System.Data.SqlDbType.NVarChar, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Extension", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "FirstName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HireDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_HomePhone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "HomePhone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "LastName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PhotoPath", System.Data.SqlDbType.NVarChar, 255, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PhotoPath", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReportsTo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReportsTo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Title", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Title", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TitleOfCourtesy", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TitleOfCourtesy", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapterTerritories
        ' 
        Me.sqlDataAdapterTerritories.DeleteCommand = Me.sqlDeleteCommand1
        Me.sqlDataAdapterTerritories.InsertCommand = Me.sqlInsertCommand1
        Me.sqlDataAdapterTerritories.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapterTerritories.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Territories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TerritoryID", "TerritoryID"), New System.Data.Common.DataColumnMapping("TerritoryDescription", "TerritoryDescription"), New System.Data.Common.DataColumnMapping("RegionID", "RegionID")})})
        Me.sqlDataAdapterTerritories.UpdateCommand = Me.sqlUpdateCommand1
        ' 
        ' sqlDeleteCommand1
        ' 
        Me.sqlDeleteCommand1.CommandText = "DELETE FROM Territories WHERE (TerritoryID = @Original_TerritoryID) AND (RegionID" & " = @Original_RegionID) AND (TerritoryDescription = @Original_TerritoryDescriptio" & "n)"
        Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TerritoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RegionID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RegionID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TerritoryDescription", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "TerritoryDescription", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapterRegion
        ' 
        Me.sqlDataAdapterRegion.SelectCommand = Me.sqlSelectCommand2
        Me.sqlDataAdapterRegion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Region", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("RegionID", "RegionID"), New System.Data.Common.DataColumnMapping("RegionDescription", "RegionDescription")})})
        ' 
        ' sqlDataAdapterEmployeeTerritories
        ' 
        Me.sqlDataAdapterEmployeeTerritories.DeleteCommand = Me.sqlDeleteCommand3
        Me.sqlDataAdapterEmployeeTerritories.InsertCommand = Me.sqlInsertCommand3
        Me.sqlDataAdapterEmployeeTerritories.SelectCommand = Me.sqlSelectCommand3
        Me.sqlDataAdapterEmployeeTerritories.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "EmployeeTerritories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("TerritoryID", "TerritoryID")})})
        Me.sqlDataAdapterEmployeeTerritories.UpdateCommand = Me.sqlUpdateCommand3
        ' 
        ' sqlDataAdapterEmployees
        ' 
        Me.sqlDataAdapterEmployees.DeleteCommand = Me.sqlDeleteCommand4
        Me.sqlDataAdapterEmployees.InsertCommand = Me.sqlInsertCommand4
        Me.sqlDataAdapterEmployees.SelectCommand = Me.sqlSelectCommand4
        Me.sqlDataAdapterEmployees.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCourtesy"), New System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"), New System.Data.Common.DataColumnMapping("HireDate", "HireDate"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"), New System.Data.Common.DataColumnMapping("Extension", "Extension"), New System.Data.Common.DataColumnMapping("Photo", "Photo"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo"), New System.Data.Common.DataColumnMapping("PhotoPath", "PhotoPath")})})
        Me.sqlDataAdapterEmployees.UpdateCommand = Me.sqlUpdateCommand4
        ' 
        ' sqlSelectCommand5
        ' 
        Me.sqlSelectCommand5.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" & "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" & "Country FROM Orders"
        Me.sqlSelectCommand5.Connection = Me.sqlConnection1
        ' 
        ' sqlInsertCommand2
        ' 
        Me.sqlInsertCommand2.Connection = Me.sqlConnection1
        Me.sqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry")})
        ' 
        ' sqlUpdateCommand2
        ' 
        Me.sqlUpdateCommand2.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"), New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID")})
        ' 
        ' sqlDeleteCommand2
        ' 
        Me.sqlDeleteCommand2.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShippedDate", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapterOrders
        ' 
        Me.sqlDataAdapterOrders.DeleteCommand = Me.sqlDeleteCommand2
        Me.sqlDataAdapterOrders.InsertCommand = Me.sqlInsertCommand2
        Me.sqlDataAdapterOrders.SelectCommand = Me.sqlSelectCommand5
        Me.sqlDataAdapterOrders.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
        Me.sqlDataAdapterOrders.UpdateCommand = Me.sqlUpdateCommand2
        ' 
        ' sqlSelectCommand6
        ' 
        Me.sqlSelectCommand6.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]"
        Me.sqlSelectCommand6.Connection = Me.sqlConnection1
        ' 
        ' sqlInsertCommand5
        ' 
        Me.sqlInsertCommand5.Connection = Me.sqlConnection1
        Me.sqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"), New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"), New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount")})
        ' 
        ' sqlUpdateCommand5
        ' 
        Me.sqlUpdateCommand5.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID"), New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.SmallInt, 2, "Quantity"), New System.Data.SqlClient.SqlParameter("@Discount", System.Data.SqlDbType.Real, 4, "Discount"), New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDeleteCommand5
        ' 
        Me.sqlDeleteCommand5.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discount", System.Data.SqlDbType.Real, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discount", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Quantity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapterOrderDetails
        ' 
        Me.sqlDataAdapterOrderDetails.DeleteCommand = Me.sqlDeleteCommand5
        Me.sqlDataAdapterOrderDetails.InsertCommand = Me.sqlInsertCommand5
        Me.sqlDataAdapterOrderDetails.SelectCommand = Me.sqlSelectCommand6
        Me.sqlDataAdapterOrderDetails.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Order Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Discount", "Discount")})})
        Me.sqlDataAdapterOrderDetails.UpdateCommand = Me.sqlUpdateCommand5
        ' 
        ' sqlSelectCommand7
        ' 
        Me.sqlSelectCommand7.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" & ", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products"
        Me.sqlSelectCommand7.Connection = Me.sqlConnection1
        ' 
        ' sqlInsertCommand6
        ' 
        Me.sqlInsertCommand6.Connection = Me.sqlConnection1
        Me.sqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued")})
        ' 
        ' sqlUpdateCommand6
        ' 
        Me.sqlUpdateCommand6.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"), New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID")})
        ' 
        ' sqlDeleteCommand6
        ' 
        Me.sqlDeleteCommand6.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapterProducts
        ' 
        Me.sqlDataAdapterProducts.DeleteCommand = Me.sqlDeleteCommand6
        Me.sqlDataAdapterProducts.InsertCommand = Me.sqlInsertCommand6
        Me.sqlDataAdapterProducts.SelectCommand = Me.sqlSelectCommand7
        Me.sqlDataAdapterProducts.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})})
        Me.sqlDataAdapterProducts.UpdateCommand = Me.sqlUpdateCommand6
        ' 
        ' sqlSelectCommand8
        ' 
        Me.sqlSelectCommand8.CommandText = "SELECT ShipperID, CompanyName, Phone FROM Shippers"
        Me.sqlSelectCommand8.Connection = Me.sqlConnection1
        ' 
        ' sqlInsertCommand7
        ' 
        Me.sqlInsertCommand7.CommandText = "INSERT INTO Shippers(CompanyName, Phone) VALUES (@CompanyName, @Phone); SELECT Sh" & "ipperID, CompanyName, Phone FROM Shippers WHERE (ShipperID = @@IDENTITY)"
        Me.sqlInsertCommand7.Connection = Me.sqlConnection1
        Me.sqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone")})
        ' 
        ' sqlUpdateCommand7
        ' 
        Me.sqlUpdateCommand7.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Original_ShipperID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipperID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ShipperID", System.Data.SqlDbType.Int, 4, "ShipperID")})
        ' 
        ' sqlDeleteCommand7
        ' 
        Me.sqlDeleteCommand7.CommandText = "DELETE FROM Shippers WHERE (ShipperID = @Original_ShipperID) AND (CompanyName = @" & "Original_CompanyName) AND (Phone = @Original_Phone OR @Original_Phone IS NULL AN" & "D Phone IS NULL)"
        Me.sqlDeleteCommand7.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ShipperID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ShipperID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapterShippers
        ' 
        Me.sqlDataAdapterShippers.DeleteCommand = Me.sqlDeleteCommand7
        Me.sqlDataAdapterShippers.InsertCommand = Me.sqlInsertCommand7
        Me.sqlDataAdapterShippers.SelectCommand = Me.sqlSelectCommand8
        Me.sqlDataAdapterShippers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Shippers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ShipperID", "ShipperID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("Phone", "Phone")})})
        Me.sqlDataAdapterShippers.UpdateCommand = Me.sqlUpdateCommand7
        ' 
        ' sqlSelectCommand9
        ' 
        Me.sqlSelectCommand9.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region," & " PostalCode, Country, Phone, Fax, HomePage FROM Suppliers"
        Me.sqlSelectCommand9.Connection = Me.sqlConnection1
        ' 
        ' sqlUpdateCommand8
        ' 
        Me.sqlUpdateCommand8.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"), New System.Data.SqlClient.SqlParameter("@HomePage", System.Data.SqlDbType.NVarChar, 1073741823, "HomePage"), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID")})
        ' 
        ' sqlDataAdapterSuppliers
        ' 
        Me.sqlDataAdapterSuppliers.DeleteCommand = Me.sqlDeleteCommand8
        Me.sqlDataAdapterSuppliers.InsertCommand = Me.sqlInsertCommand8
        Me.sqlDataAdapterSuppliers.SelectCommand = Me.sqlSelectCommand9
        Me.sqlDataAdapterSuppliers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Suppliers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax"), New System.Data.Common.DataColumnMapping("HomePage", "HomePage")})})
        Me.sqlDataAdapterSuppliers.UpdateCommand = Me.sqlUpdateCommand8
        ' 
        ' sqlDeleteCommand8
        ' 
        Me.sqlDeleteCommand8.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlInsertCommand8
        ' 
        Me.sqlInsertCommand8.Connection = Me.sqlConnection1
        Me.sqlInsertCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"), New System.Data.SqlClient.SqlParameter("@HomePage", System.Data.SqlDbType.NVarChar, 1073741823, "HomePage")})
        ' 
        ' sqlSelectCommand10
        ' 
        Me.sqlSelectCommand10.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
        Me.sqlSelectCommand10.Connection = Me.sqlConnection1
        ' 
        ' sqlInsertCommand9
        ' 
        Me.sqlInsertCommand9.Connection = Me.sqlConnection1
        Me.sqlInsertCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"), New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture")})
        ' 
        ' sqlUpdateCommand9
        ' 
        Me.sqlUpdateCommand9.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"), New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture"), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID")})
        ' 
        ' sqlDeleteCommand9
        ' 
        Me.sqlDeleteCommand9.CommandText = "DELETE FROM Categories WHERE (CategoryID = @Original_CategoryID) AND (CategoryNam" & "e = @Original_CategoryName)"
        Me.sqlDeleteCommand9.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryName", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapterCategories
        ' 
        Me.sqlDataAdapterCategories.DeleteCommand = Me.sqlDeleteCommand9
        Me.sqlDataAdapterCategories.InsertCommand = Me.sqlInsertCommand9
        Me.sqlDataAdapterCategories.SelectCommand = Me.sqlSelectCommand10
        Me.sqlDataAdapterCategories.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
        Me.sqlDataAdapterCategories.UpdateCommand = Me.sqlUpdateCommand9
        ' 
        ' sqlSelectCommand11
        ' 
        Me.sqlSelectCommand11.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," & " PostalCode, Country, Phone, Fax FROM Customers"
        Me.sqlSelectCommand11.Connection = Me.sqlConnection1
        ' 
        ' sqlInsertCommand10
        ' 
        Me.sqlInsertCommand10.Connection = Me.sqlConnection1
        Me.sqlInsertCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax")})
        ' 
        ' sqlUpdateCommand10
        ' 
        Me.sqlUpdateCommand10.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDeleteCommand10
        ' 
        Me.sqlDeleteCommand10.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Region", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapterCustomers
        ' 
        Me.sqlDataAdapterCustomers.DeleteCommand = Me.sqlDeleteCommand10
        Me.sqlDataAdapterCustomers.InsertCommand = Me.sqlInsertCommand10
        Me.sqlDataAdapterCustomers.SelectCommand = Me.sqlSelectCommand11
        Me.sqlDataAdapterCustomers.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax")})})
        Me.sqlDataAdapterCustomers.UpdateCommand = Me.sqlUpdateCommand10
        ' 
        ' comboBoxEmployeeTerritoriesRelationKind
        ' 
        Me.comboBoxEmployeeTerritoriesRelationKind.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
        Me.comboBoxEmployeeTerritoriesRelationKind.Items.AddRange(New Object() {"RelatedMasterDetails", "ForeignKeyKeyWords"})
        Me.comboBoxEmployeeTerritoriesRelationKind.Location = New System.Drawing.Point(559, 22)
        Me.comboBoxEmployeeTerritoriesRelationKind.Name = "comboBoxEmployeeTerritoriesRelationKind"
        Me.comboBoxEmployeeTerritoriesRelationKind.Size = New System.Drawing.Size(152, 21)
        Me.comboBoxEmployeeTerritoriesRelationKind.TabIndex = 1
        Me.comboBoxEmployeeTerritoriesRelationKind.Text = "comboBox1"
        Me.comboBoxEmployeeTerritoriesRelationKind.ForeColor = Color.DimGray
        Me.comboBoxEmployeeTerritoriesRelationKind.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        '			Me.comboBoxEmployeeTerritoriesRelationKind.SelectedIndexChanged += New System.EventHandler(Me.comboBoxEmployeeTerritoriesRelationKind_SelectedIndexChanged)
        ' 
        ' label1
        ' 
        Me.label1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label1.Location = New System.Drawing.Point(13, 22)
        Me.label1.Name = "label1"
        Me.label1.ForeColor = Color.DimGray
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0F)
        Me.label1.Size = New System.Drawing.Size(528, 50)
        Me.label1.TabIndex = 2
        Me.label1.Text = "EmployeeTerritoriesRelation.RelationKind:  Switch to ForeignKeyKeywords view for " & "the EmployeeTerritories child table. In ForeignKeyKeyWordsMode you can then drop" & "down the EmployeeTerritories column."
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        ' 
        ' panel1
        ' 
        Me.panel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBoxEmployeeTerritoriesRelationKind)
        Me.panel1.Location = New System.Drawing.Point(24, 410)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(726, 72)
        Me.panel1.TabIndex = 5
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.ClientSize = New System.Drawing.Size(776, 483)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.DropShadow = True
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Territory Order Demo"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.northwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub

    Private Sub gridGroupingControl1_QueryValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
        If e.TableDescriptor.Name = "ReportsTo" AndAlso e.Field.Name = "LastNameAndTitle" Then
            ' "[LastName] + '(' + [Title] + ')'"));
            e.Value = String.Format("{0} ({1})", e.Record.GetValue("LastName"), e.Record.GetValue("Title"))
        End If
    End Sub

    Private Sub comboBoxEmployeeTerritoriesRelationKind_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxEmployeeTerritoriesRelationKind.SelectedIndexChanged
        Dim cb As ComboBox = CType(sender, ComboBox)

        If cb.Text = "RelatedMasterDetails" Then
            EmployeeTerritoriesRelationKind = RelationKind.RelatedMasterDetails
        Else
            EmployeeTerritoriesRelationKind = RelationKind.ForeignKeyKeyWords
        End If

    End Sub

    Private columnSetTerritory As GridColumnSetDescriptor
    Private columnTerritory As GridColumnDescriptor

    Private Property EmployeeTerritoriesRelationKind() As RelationKind
        Get
            Return Me.gridGroupingControl1.TableDescriptor.Relations("EmployeeTerritories").RelationKind
        End Get
        Set(ByVal value As RelationKind)
            If EmployeeTerritoriesRelationKind <> value Then
                Cursor.Current = Cursors.WaitCursor
                Dim mainTd As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
                Me.gridGroupingControl1.TableControl.HScrollBar.Value = Me.gridGroupingControl1.TableControl.HScrollBar.Minimum
                Me.gridGroupingControl1.Table.CurrentRecordManager.CurrentField = Me.gridGroupingControl1.TableDescriptor.Columns(0).FieldDescriptor

                If columnSetTerritory Is Nothing Then
                    ' Create column set for territory that spans 2 rows.
                    columnSetTerritory = New GridColumnSetDescriptor()
                    columnSetTerritory.Name = "ColumnSetTerritory"
                    columnSetTerritory.ColumnSpans.AddRange(New GridColumnSpanDescriptor() {New GridColumnSpanDescriptor("Territories", "R0C0:R1C0")})


                    columnTerritory = New GridColumnDescriptor()
                    columnTerritory.Name = "Territories"
                    columnTerritory.MappingName = "EmployeeTerritories_Territories_TerritoryDescription"
                    columnTerritory.Width = 150

                    mainTd.Columns.Add(columnTerritory)
                    ' If the following warning is displayed in Console output:
                    ' "Could not find Field with name EmployeeTerritories_Territories_TerritoryDescription in Employees"
                    ' This is because the relation is added afterwards below. It is ok to ignore the warning.

                    mainTd.ColumnSets.Add(columnSetTerritory)
                End If

                Select Case value
                    Case RelationKind.ForeignKeyKeyWords
                        ' Change Relation Kind
                        mainTd.Relations("EmployeeTerritories").RelationKind = value

                        ' Show Territory column with sumary of territories.
                        mainTd.VisibleColumns.Insert(3, "ColumnSetTerritory")
                        Exit Select

                    Case RelationKind.RelatedMasterDetails
                        ' Hide Territory column
                        mainTd.VisibleColumns.Remove("ColumnSetTerritory")

                        ' Change RelationKind
                        Me.gridGroupingControl1.TableDescriptor.Relations("EmployeeTerritories").RelationKind = value
                        Exit Select

                End Select

                Me.gridGroupingControl1.Refresh()

                Cursor.Current = Cursors.Arrow
            End If
        End Set
    End Property

End Class
