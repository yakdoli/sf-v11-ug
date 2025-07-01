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
Imports Syncfusion.Windows.Forms.MetroForm


'/ <summary>
'/ This sample shows how to customize the current cell arrow up/down behavior
    '/ and highlight the current record.
    '/ </summary>

    Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
        Private WithEvents gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Private sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
        Private sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
        Private sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
        Private sqlConnection1 As System.Data.SqlClient.SqlConnection
        Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Private dataSet11 As DataSet1
        Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
        Private sqlInsertCommand2 As System.Data.SqlClient.SqlCommand
        Private sqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
        Private sqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
        Private sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
        Private sqlConnection2 As System.Data.SqlClient.SqlConnection
    Private sqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents CheckBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents buttonAdv3 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents buttonAdv5 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents buttonAdv8 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents buttonAdv6 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents buttonAdv7 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents buttonAdv4 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents buttonAdv9 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
    Private components As System.ComponentModel.IContainer
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Try
            Dim ico As Icon = New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro


        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        Dim msdeAvailable As Boolean = False
        If msdeAvailable Then
            Me.sqlDataAdapter1.Fill(Me.dataSet11)
            Me.sqlDataAdapter2.Fill(Me.dataSet11)
        Else
            ' Read from a xml file instead.
            ReadXml(Me.dataSet11, "Common\Data\HVData.xml")
        End If

        Me.gridGroupingControl1.AddGroupDropArea("Orders")

        Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = False
        Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.ChildGroupOptions.ShowCaptionPlusMinus = False

        If Me.gridGroupingControl1.Table.Records.Count > 12 AndAlso Me.gridGroupingControl1.Table.Records(10).NestedTables.Count > 0 Then
            Me.gridGroupingControl1.Table.Records(10).IsExpanded = True
            Me.gridGroupingControl1.Table.Records(10).NestedTables(0).IsExpanded = True
            Me.gridGroupingControl1.Table.Records(12).IsExpanded = True
            Me.gridGroupingControl1.Table.Records(12).NestedTables(0).IsExpanded = True
        End If


        Me.gridGroupingControl1.Appearance.GroupCaptionCell.Enabled = True

        Me.gridGroupingControl1.IntelliMousePanning = True

        Me.ContextMenuStrip1.Items.Add("Select All")
        Me.ContextMenuStrip1.Items.Add("Delete Selected")
        Me.gridGroupingControl1.ContextMenuStrip = Me.ContextMenuStrip1

        Me.gridGroupingControl1.TableModel.Options.SelectCellsMouseButtonsMask = Windows.Forms.MouseButtons.Left
        Me.gridGroupingControl1.TableOptions.ListBoxSelectionMode = SelectionMode.MultiExtended
        Me.gridGroupingControl1.TableOptions.AllowSelection = GridSelectionFlags.None
        Me.gridGroupingControl1.TableOptions.ListBoxSelectionColorOptions = GridListBoxSelectionColorOptions.ApplySelectionColor
        Me.gridGroupingControl1.TableOptions.ListBoxSelectionCurrentCellOptions = GridListBoxSelectionCurrentCellOptions.WhiteCurrentCell Or GridListBoxSelectionCurrentCellOptions.MoveCurrentCellWithMouse
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


    Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
        Dim n As Integer
        For n = 0 To 11
            If System.IO.File.Exists(xmlFileName) Then
                ds.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" + xmlFileName
        Next n
    End Sub 'ReadXml


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
        Me.components = New System.ComponentModel.Container
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Me.dataSet11 = New MultipleRecordSelection.DataSet1
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.sqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.buttonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.buttonAdv8 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.buttonAdv6 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.buttonAdv7 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.buttonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.buttonAdv9 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridGroupingControl1
        '
        Me.gridGroupingControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gridGroupingControl1.Appearance.AlternateRecordFieldCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.AnyCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.gridGroupingControl1.Appearance.AnyIndentCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.NestedTableRowHeaderCell.BaseStyle = ""
        Me.gridGroupingControl1.Appearance.NestedTableRowHeaderCell.CellType = "RowHeaderCell"
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.DataSource = Me.dataSet11.Customers
        Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.Location = New System.Drawing.Point(0, 0)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = True
        Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = True
        Me.gridGroupingControl1.NestedTableGroupOptions.ShowGroupPreview = True
        Me.gridGroupingControl1.ShowGroupDropArea = True
        Me.gridGroupingControl1.ShowNavigationBar = True
        Me.gridGroupingControl1.Size = New System.Drawing.Size(592, 596)
        Me.gridGroupingControl1.TabIndex = 0
        Me.gridGroupingControl1.TableDescriptor.AllowNew = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
        Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
        Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
        Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
        Me.gridGroupingControl1.TableOptions.ShowTableIndentAsCoveredRange = True
        Me.gridGroupingControl1.TableOptions.ShowTableRowHeaderAsCoveredRange = True
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," & _
            " PostalCode, Country, Phone, Fax FROM Customers"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        '
        'sqlConnection1
        '
        Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & _
            "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'sqlInsertCommand1
        '
        Me.sqlInsertCommand1.Connection = Me.sqlConnection1
        Me.sqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax")})
        '
        'sqlUpdateCommand1
        '
        Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlDeleteCommand1
        '
        Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.DeleteCommand = Me.sqlDeleteCommand1
        Me.sqlDataAdapter1.InsertCommand = Me.sqlInsertCommand1
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax")})})
        Me.sqlDataAdapter1.UpdateCommand = Me.sqlUpdateCommand1
        '
        'sqlSelectCommand2
        '
        Me.sqlSelectCommand2.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" & _
            "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" & _
            "Country FROM Orders"
        Me.sqlSelectCommand2.Connection = Me.sqlConnection1
        '
        'sqlInsertCommand2
        '
        Me.sqlInsertCommand2.Connection = Me.sqlConnection1
        Me.sqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry")})
        '
        'sqlUpdateCommand2
        '
        Me.sqlUpdateCommand2.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"), New System.Data.SqlClient.SqlParameter("@EmployeeID", System.Data.SqlDbType.Int, 4, "EmployeeID"), New System.Data.SqlClient.SqlParameter("@OrderDate", System.Data.SqlDbType.DateTime, 8, "OrderDate"), New System.Data.SqlClient.SqlParameter("@RequiredDate", System.Data.SqlDbType.DateTime, 8, "RequiredDate"), New System.Data.SqlClient.SqlParameter("@ShippedDate", System.Data.SqlDbType.DateTime, 8, "ShippedDate"), New System.Data.SqlClient.SqlParameter("@ShipVia", System.Data.SqlDbType.Int, 4, "ShipVia"), New System.Data.SqlClient.SqlParameter("@Freight", System.Data.SqlDbType.Money, 8, "Freight"), New System.Data.SqlClient.SqlParameter("@ShipName", System.Data.SqlDbType.NVarChar, 40, "ShipName"), New System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 60, "ShipAddress"), New System.Data.SqlClient.SqlParameter("@ShipCity", System.Data.SqlDbType.NVarChar, 15, "ShipCity"), New System.Data.SqlClient.SqlParameter("@ShipRegion", System.Data.SqlDbType.NVarChar, 15, "ShipRegion"), New System.Data.SqlClient.SqlParameter("@ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, "ShipPostalCode"), New System.Data.SqlClient.SqlParameter("@ShipCountry", System.Data.SqlDbType.NVarChar, 15, "ShipCountry"), New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShippedDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@OrderID", System.Data.SqlDbType.Int, 4, "OrderID")})
        '
        'sqlDeleteCommand2
        '
        Me.sqlDeleteCommand2.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_OrderID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EmployeeID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Freight", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Freight", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OrderDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_RequiredDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "RequiredDate", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipAddress", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCity", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCity", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipCountry", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipCountry", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipPostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipPostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipRegion", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipRegion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShipVia", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShipVia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ShippedDate", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ShippedDate", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlDataAdapter2
        '
        Me.sqlDataAdapter2.DeleteCommand = Me.sqlDeleteCommand2
        Me.sqlDataAdapter2.InsertCommand = Me.sqlInsertCommand2
        Me.sqlDataAdapter2.SelectCommand = Me.sqlSelectCommand2
        Me.sqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
        Me.sqlDataAdapter2.UpdateCommand = Me.sqlUpdateCommand2
        '
        'sqlConnection2
        '
        Me.sqlConnection2.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & _
            "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        Me.sqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'sqlSelectCommand3
        '
        Me.sqlSelectCommand3.CommandText = "SELECT ShipperID, CompanyName, Phone FROM Shippers"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.buttonAdv1)
        Me.GroupBox1.Controls.Add(Me.buttonAdv3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Location = New System.Drawing.Point(4, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 154)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Table Level"
        '
        'CheckBox1
        '
        Me.CheckBox1.DrawFocusRectangle = False
        Me.CheckBox1.ForeColor = System.Drawing.Color.DimGray
        Me.CheckBox1.Location = New System.Drawing.Point(7, 23)
        Me.CheckBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(142, 19)
        Me.CheckBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Include Nested Tables"
        Me.CheckBox1.ThemesEnabled = False
        '
        'buttonAdv1
        '
        Me.buttonAdv1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdv1.ForeColor = System.Drawing.Color.White
        Me.buttonAdv1.Location = New System.Drawing.Point(24, 57)
        Me.buttonAdv1.Name = "buttonAdv1"
        Me.buttonAdv1.Size = New System.Drawing.Size(114, 27)
        Me.buttonAdv1.TabIndex = 17
        Me.buttonAdv1.Text = "SelectAll"
        Me.buttonAdv1.UseVisualStyle = True
        Me.buttonAdv1.UseVisualStyleBackColor = True
        '
        'buttonAdv3
        '
        Me.buttonAdv3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.buttonAdv3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdv3.ForeColor = System.Drawing.Color.White
        Me.buttonAdv3.Location = New System.Drawing.Point(24, 100)
        Me.buttonAdv3.Name = "buttonAdv3"
        Me.buttonAdv3.Size = New System.Drawing.Size(114, 27)
        Me.buttonAdv3.TabIndex = 19
        Me.buttonAdv3.Text = "Delete Selected"
        Me.buttonAdv3.UseVisualStyle = True
        Me.buttonAdv3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.buttonAdv2)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.buttonAdv5)
        Me.GroupBox2.Controls.Add(Me.buttonAdv8)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox2.Location = New System.Drawing.Point(5, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 184)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Range Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Range to select"
        '
        'buttonAdv2
        '
        Me.buttonAdv2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.buttonAdv2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdv2.ForeColor = System.Drawing.Color.White
        Me.buttonAdv2.Location = New System.Drawing.Point(23, 60)
        Me.buttonAdv2.Name = "buttonAdv2"
        Me.buttonAdv2.Size = New System.Drawing.Size(114, 27)
        Me.buttonAdv2.TabIndex = 18
        Me.buttonAdv2.Text = "Select Range"
        Me.buttonAdv2.UseVisualStyle = True
        Me.buttonAdv2.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.DimGray
        Me.NumericUpDown1.Location = New System.Drawing.Point(103, 22)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(34, 23)
        Me.NumericUpDown1.TabIndex = 3
        '
        'buttonAdv5
        '
        Me.buttonAdv5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.buttonAdv5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.buttonAdv5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdv5.ForeColor = System.Drawing.Color.White
        Me.buttonAdv5.Location = New System.Drawing.Point(23, 102)
        Me.buttonAdv5.Name = "buttonAdv5"
        Me.buttonAdv5.Size = New System.Drawing.Size(114, 27)
        Me.buttonAdv5.TabIndex = 21
        Me.buttonAdv5.Text = "Clear Range"
        Me.buttonAdv5.UseVisualStyle = True
        Me.buttonAdv5.UseVisualStyleBackColor = True
        '
        'buttonAdv8
        '
        Me.buttonAdv8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAdv8.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.buttonAdv8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonAdv8.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.buttonAdv8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdv8.ForeColor = System.Drawing.Color.White
        Me.buttonAdv8.Location = New System.Drawing.Point(23, 142)
        Me.buttonAdv8.Name = "buttonAdv8"
        Me.buttonAdv8.Size = New System.Drawing.Size(114, 27)
        Me.buttonAdv8.TabIndex = 24
        Me.buttonAdv8.Text = "Delete Range"
        Me.buttonAdv8.UseVisualStyle = True
        Me.buttonAdv8.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.button2)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(593, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 596)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.buttonAdv6)
        Me.GroupBox3.Controls.Add(Me.buttonAdv7)
        Me.GroupBox3.Controls.Add(Me.buttonAdv4)
        Me.GroupBox3.Controls.Add(Me.buttonAdv9)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DimGray
        Me.GroupBox3.Location = New System.Drawing.Point(5, 417)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 167)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Navigation Bar Settings"
        '
        'buttonAdv6
        '
        Me.buttonAdv6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.buttonAdv6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonAdv6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.buttonAdv6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdv6.ForeColor = System.Drawing.Color.White
        Me.buttonAdv6.Location = New System.Drawing.Point(23, 20)
        Me.buttonAdv6.Name = "buttonAdv6"
        Me.buttonAdv6.Size = New System.Drawing.Size(114, 27)
        Me.buttonAdv6.TabIndex = 22
        Me.buttonAdv6.Text = "MoveFirst"
        Me.buttonAdv6.UseVisualStyle = True
        Me.buttonAdv6.UseVisualStyleBackColor = True
        '
        'buttonAdv7
        '
        Me.buttonAdv7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAdv7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.buttonAdv7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonAdv7.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.buttonAdv7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdv7.ForeColor = System.Drawing.Color.White
        Me.buttonAdv7.Location = New System.Drawing.Point(23, 129)
        Me.buttonAdv7.Name = "buttonAdv7"
        Me.buttonAdv7.Size = New System.Drawing.Size(114, 27)
        Me.buttonAdv7.TabIndex = 23
        Me.buttonAdv7.Text = "MovePrevious"
        Me.buttonAdv7.UseVisualStyle = True
        Me.buttonAdv7.UseVisualStyleBackColor = True
        '
        'buttonAdv4
        '
        Me.buttonAdv4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.buttonAdv4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdv4.ForeColor = System.Drawing.Color.White
        Me.buttonAdv4.Location = New System.Drawing.Point(23, 94)
        Me.buttonAdv4.Name = "buttonAdv4"
        Me.buttonAdv4.Size = New System.Drawing.Size(114, 27)
        Me.buttonAdv4.TabIndex = 20
        Me.buttonAdv4.Text = "MoveNext"
        Me.buttonAdv4.UseVisualStyle = True
        Me.buttonAdv4.UseVisualStyleBackColor = True
        '
        'buttonAdv9
        '
        Me.buttonAdv9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAdv9.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.buttonAdv9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buttonAdv9.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.buttonAdv9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAdv9.ForeColor = System.Drawing.Color.White
        Me.buttonAdv9.Location = New System.Drawing.Point(23, 57)
        Me.buttonAdv9.Name = "buttonAdv9"
        Me.buttonAdv9.Size = New System.Drawing.Size(114, 27)
        Me.buttonAdv9.TabIndex = 25
        Me.buttonAdv9.Text = "MoveLast"
        Me.buttonAdv9.UseVisualStyle = True
        Me.buttonAdv9.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Location = New System.Drawing.Point(28, 12)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(114, 27)
        Me.button2.TabIndex = 16
        Me.button2.Text = "DeleteAll"
        Me.button2.UseVisualStyle = True
        Me.button2.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(754, 596)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Range Selection Demo"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()

#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub 'Form1_Load


    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv1.Click
        Me.gridGroupingControl1.Table.Records.SelectAll()
        If Me.CheckBox1.Checked Then
            For Each tbl As Table In Me.gridGroupingControl1.Table.RelatedTables
                tbl.Records.SelectAll()
            Next tbl
        End If
    End Sub

    Private Sub btnClearSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv3.Click
        Me.gridGroupingControl1.Table.SelectedRecords.DeleteAll()
        If Me.CheckBox1.Checked Then
            For Each tbl As Table In Me.gridGroupingControl1.Table.RelatedTables
                tbl.SelectedRecords.DeleteAll()
            Next tbl
        End If
    End Sub

    Private Sub btnDeleteAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.gridGroupingControl1.Table.Records.DeleteAll()
    End Sub

    Private Sub btnSelectRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv2.Click
        If Me.NumericUpDown1.Value <> 0 Then
            Dim rec(CInt(Fix(Me.NumericUpDown1.Value)) - 1) As Record
            For counter As Integer = 0 To CInt(Fix(Me.NumericUpDown1.Value)) - 1
                rec(counter) = Me.gridGroupingControl1.Table.Records(counter)
            Next counter
            Me.gridGroupingControl1.Table.SelectedRecords.AddRange(rec)
        Else
            MessageBox.Show("Please Enter Valid Range!")
        End If
    End Sub

    Private Sub btnClearRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv5.Click
        If Me.NumericUpDown1.Value <> 0 AndAlso Me.NumericUpDown1.Value <= Me.gridGroupingControl1.Table.SelectedRecords.Count Then
            Dim rec(CInt(Fix(Me.NumericUpDown1.Value)) - 1) As SelectedRecord
            For counter As Integer = 0 To CInt(Fix(Me.NumericUpDown1.Value)) - 1
                rec(counter) = Me.gridGroupingControl1.Table.SelectedRecords(counter)
            Next counter
            Me.gridGroupingControl1.Table.SelectedRecords.RemoveRange(rec)
        Else
            MessageBox.Show("Please Enter Valid Selected Range!")
        End If
    End Sub

    Private Sub btnDeleteRange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv8.Click
        If Me.NumericUpDown1.Value <= Me.gridGroupingControl1.Table.Records.Count Then
            Dim rec(CInt(Fix(Me.NumericUpDown1.Value)) - 1) As Record
            For counter As Integer = 0 To CInt(Fix(Me.NumericUpDown1.Value)) - 1
                rec(counter) = Me.gridGroupingControl1.Table.Records(counter)
            Next counter
            Me.gridGroupingControl1.Table.Records.DeleteRecords(rec)
        Else
            MessageBox.Show("Please Enter Valid Range to delete!")
        End If
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        If e.ClickedItem.Text = "Select All" Then
            Me.gridGroupingControl1.Table.Records.SelectAll()
            If Me.CheckBox1.Checked Then
                For Each tbl As Table In Me.gridGroupingControl1.Table.RelatedTables
                    tbl.Records.SelectAll()
                Next tbl
            End If
        ElseIf e.ClickedItem.Text = "Delete Selected" Then
            Me.gridGroupingControl1.Table.SelectedRecords.DeleteAll()
            If Me.CheckBox1.Checked Then
                For Each tbl As Table In Me.gridGroupingControl1.Table.RelatedTables
                    tbl.SelectedRecords.DeleteAll()
                Next tbl
            End If
        End If
    End Sub

    Private Sub moveFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv6.Click
        Me.gridGroupingControl1.RecordNavigationBar.MoveFirst()
    End Sub

    Private Sub moveLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv9.Click
        Me.gridGroupingControl1.RecordNavigationBar.MoveLast()
    End Sub

    Private Sub moveNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv4.Click
        Me.gridGroupingControl1.RecordNavigationBar.MoveNext()
    End Sub

    Private Sub movePrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonAdv7.Click
        Me.gridGroupingControl1.RecordNavigationBar.MovePrevious()
    End Sub
End Class 'Form1
