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
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports System.Diagnostics

Imports Syncfusion.Collections.BinaryTree

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits MetroForm
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
    Private menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem50 As System.Windows.Forms.MenuItem
    Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Private dataSet11 As CustomViews.DataSet1
    Private groupingGrid1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private groupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
    Private Columns As Syncfusion.Windows.Forms.Tools.GroupBarItem
    Private groupBarItem2 As Syncfusion.Windows.Forms.Tools.GroupBarItem
    Private WithEvents groupView1 As Syncfusion.Windows.Forms.Tools.GroupView
    Private groupBarItem3 As Syncfusion.Windows.Forms.Tools.GroupBarItem
    Private groupView2 As GroupView
    Private WithEvents groupView3 As GroupView
    Private WithEvents groupView4 As GroupView
    Private WithEvents checkBoxAdv1 As CheckBoxAdv
    Private components As IContainer

    Private Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
        For n As Integer = 0 To 9
            If File.Exists(xmlFileName) Then
                ds.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" & xmlFileName
        Next n
    End Sub


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        Me.groupingGrid1.DataMember = ""
        Me.groupingGrid1.DataSource = Me.dataSet11.Customers
        Me.groupingGrid1.ShowGroupDropArea = True
        Me.groupingGrid1.FilterRuntimeProperties = True ' don't show all properties in PropertyGrid

        AddHandler groupingGrid1.QueryCellStyleInfo, AddressOf groupingGrid1_QueryCellStyleInfo
        ReadXml(Me.dataSet11, "Common\Data\GDBDdata.XML")

        Me.groupingGrid1.TableDescriptor.Columns("City").AllowFilter = True
        Me.groupingGrid1.TableDescriptor.Columns("Country").AllowFilter = True
        Me.groupingGrid1.TableDescriptor.Columns("Region").AllowFilter = True
        Me.groupingGrid1.TableDescriptor.Columns("ContactTitle").AllowFilter = True
        Me.groupingGrid1.TableDescriptor.Columns("CompanyName").AllowFilter = True
        Me.groupingGrid1.TopLevelGroupOptions.ShowFilterBar = True

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = Color.White
        Me.groupingGrid1.TableOptions.GridLineBorder = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
        Me.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.groupingGrid1.TopLevelGroupOptions.ShowCaption = False
        Me.groupingGrid1.Appearance.AnyCell.Font.Facename = "Verdana"
        Me.groupingGrid1.Appearance.AnyCell.TextColor = Color.MidnightBlue
        Me.DropShadow = True
        Me.groupingGrid1.GridVisualStyles = GridVisualStyles.Metro

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
        Me.dataSet11 = New CustomViews.DataSet1
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.menuItem50 = New System.Windows.Forms.MenuItem
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.groupingGrid1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Me.groupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar
        Me.groupView4 = New Syncfusion.Windows.Forms.Tools.GroupView
        Me.groupView3 = New Syncfusion.Windows.Forms.Tools.GroupView
        Me.groupView1 = New Syncfusion.Windows.Forms.Tools.GroupView
        Me.Columns = New Syncfusion.Windows.Forms.Tools.GroupBarItem
        Me.groupBarItem2 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
        Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem
        Me.groupView2 = New Syncfusion.Windows.Forms.Tools.GroupView
        Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupingGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBar1.SuspendLayout()
        CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'menuItem3
        '
        Me.menuItem3.Index = -1
        Me.menuItem3.Text = ""
        '
        'menuItem50
        '
        Me.menuItem50.Index = -1
        Me.menuItem50.Text = ""
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
        'groupingGrid1
        '
        Me.groupingGrid1.BackColor = System.Drawing.SystemColors.Window
        Me.groupingGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.groupingGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.groupingGrid1.Location = New System.Drawing.Point(12, 12)
        Me.groupingGrid1.Name = "groupingGrid1"
        Me.groupingGrid1.ShowNavigationBar = True
        Me.groupingGrid1.Size = New System.Drawing.Size(552, 516)
        Me.groupingGrid1.TabIndex = 1
        Me.groupingGrid1.TableDescriptor.AllowNew = False
        Me.groupingGrid1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.groupingGrid1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
        Me.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.groupingGrid1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
        Me.groupingGrid1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
        Me.groupingGrid1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
        Me.groupingGrid1.TableDescriptor.TableOptions.RecordRowHeight = 20
        Me.groupingGrid1.Text = "groupingGrid1"
        '
        'groupBar1
        '
        Me.groupBar1.AllowDrop = True
        Me.groupBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.groupBar1.BorderColor = System.Drawing.Color.White
        Me.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.groupBar1.Controls.Add(Me.groupView1)
        Me.groupBar1.Controls.Add(Me.groupView4)
        Me.groupBar1.Controls.Add(Me.groupView3)
        Me.groupBar1.ExpandButtonToolTip = Nothing
        Me.groupBar1.FlatLook = True
        Me.groupBar1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBar1.ForeColor = System.Drawing.Color.White
        Me.groupBar1.GroupBarDropDownToolTip = Nothing
        Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() {Me.Columns, Me.groupBarItem2, Me.groupBarItem3})
        Me.groupBar1.IndexOnVisibleItems = True
        Me.groupBar1.Location = New System.Drawing.Point(588, 12)
        Me.groupBar1.MinimizeButtonToolTip = Nothing
        Me.groupBar1.Name = "groupBar1"
        Me.groupBar1.NavigationPaneTooltip = Nothing
        Me.groupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
        Me.groupBar1.SelectedItem = 0
        Me.groupBar1.Size = New System.Drawing.Size(176, 302)
        Me.groupBar1.TabIndex = 20
        Me.groupBar1.Text = "groupBar1"
        Me.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
        '
        'groupView4
        '
        Me.groupView4.BackColor = System.Drawing.Color.White
        Me.groupView4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.groupView4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupView4.ForeColor = System.Drawing.Color.DimGray
        Me.groupView4.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() {New Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Filters ..", -1, True, Nothing, "Choose Filters .."), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Clear Filters", -1, True, Nothing, "Clear Filters"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Grouping ..", -1, True, Nothing, "Choose Grouping .."), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Clear Grouping", -1, True, Nothing, "Clear Grouping"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Sorting..", -1, True, Nothing, "Choose Sorting.."), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Clear Sorting", -1, True, Nothing, "Clear Sorting"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Summaries..", -1, True, Nothing, "Choose Summaries.."), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Clear Summaries", -1, True, Nothing, "Clear Summaries")})
        Me.groupView4.HighlightItemColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.groupView4.Location = New System.Drawing.Point(0, 302)
        Me.groupView4.Name = "groupView4"
        Me.groupView4.Size = New System.Drawing.Size(176, 0)
        Me.groupView4.TabIndex = 29
        Me.groupView4.Text = "groupView4"
        Me.groupView4.TextWrap = True
        '
        'groupView3
        '
        Me.groupView3.BackColor = System.Drawing.Color.White
        Me.groupView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.groupView3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupView3.ForeColor = System.Drawing.Color.DimGray
        Me.groupView3.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() {New Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Columns ..", -1, True, Nothing, "Choose Columns .."), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Reset Columns", -1, True, Nothing, "Reset Columns"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Column Sets..", -1, True, Nothing, "Choose Column Sets.."), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Reset ColumnSets", -1, True, Nothing, "Reset ColumnSets"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose Column Order ..", -1, True, Nothing, "Choose Column Order .."), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Reset Columns Order", -1, True, Nothing, "Reset Columns Order"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Choose ExpressionFields", -1, True, Nothing, "Choose ExpressionFields")})
        Me.groupView3.HighlightItemColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.groupView3.Location = New System.Drawing.Point(0, 44)
        Me.groupView3.Name = "groupView3"
        Me.groupView3.SelectedHighlightItemColor = System.Drawing.SystemColors.Highlight
        Me.groupView3.SelectedItemColor = System.Drawing.SystemColors.Highlight
        Me.groupView3.Size = New System.Drawing.Size(176, 0)
        Me.groupView3.TabIndex = 28
        Me.groupView3.Text = "groupView3"
        Me.groupView3.TextWrap = True
        '
        'groupView1
        '
        Me.groupView1.BackColor = System.Drawing.Color.White
        Me.groupView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.groupView1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupView1.ForeColor = System.Drawing.Color.DimGray
        Me.groupView1.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() {New Syncfusion.Windows.Forms.Tools.GroupViewItem("CustomersDataTable (from Xml)", -1, True, Nothing, "CustomersDataTable (from Xml)"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Browse Table", -1, True, Nothing, "Browse Table"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Reset Filters, Summaries and Grouping", -1, True, Nothing, "Reset Filters, Summaries and Grouping")})
        Me.groupView1.HighlightItemColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.groupView1.Location = New System.Drawing.Point(0, 22)
        Me.groupView1.Name = "groupView1"
        Me.groupView1.Size = New System.Drawing.Size(176, 236)
        Me.groupView1.TabIndex = 27
        Me.groupView1.Text = "groupView1"
        Me.groupView1.TextWrap = True
        '
        'Columns
        '
        Me.Columns.BackColor = System.Drawing.Color.White
        Me.Columns.Client = Me.groupView1
        Me.Columns.Text = "Table Option"
        '
        'groupBarItem2
        '
        Me.groupBarItem2.BackColor = System.Drawing.Color.White
        Me.groupBarItem2.Client = Me.groupView3
        Me.groupBarItem2.Text = "Column"
        '
        'groupBarItem3
        '
        Me.groupBarItem3.BackColor = System.Drawing.Color.White
        Me.groupBarItem3.Client = Me.groupView4
        Me.groupBarItem3.Text = "Option"
        '
        'groupView2
        '
        Me.groupView2.Location = New System.Drawing.Point(0, 44)
        Me.groupView2.Name = "groupView2"
        Me.groupView2.Size = New System.Drawing.Size(176, 104)
        Me.groupView2.TabIndex = 28
        Me.groupView2.Text = "groupView2"
        '
        'checkBoxAdv1
        '
        Me.checkBoxAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkBoxAdv1.DrawFocusRectangle = False
        Me.checkBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBoxAdv1.Location = New System.Drawing.Point(588, 323)
        Me.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.checkBoxAdv1.Name = "checkBoxAdv1"
        Me.checkBoxAdv1.Size = New System.Drawing.Size(176, 21)
        Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBoxAdv1.TabIndex = 30
        Me.checkBoxAdv1.Text = "Enable\Disable XP Themes"
        Me.checkBoxAdv1.ThemesEnabled = False
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(776, 541)
        Me.Controls.Add(Me.checkBoxAdv1)
        Me.Controls.Add(Me.groupBar1)
        Me.Controls.Add(Me.groupingGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Views Demo"
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupingGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBar1.ResumeLayout(False)
        CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


#End Region


    Friend Function _ShowGridBaseStylesDialog(ByVal instance As Object, ByVal propertyName As String, ByVal provider As IServiceProvider, ByVal type As Type) As DialogResult
        Dim ce As New System.ComponentModel.Design.CollectionEditor(type)
        Dim esc As New Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(provider)
        Dim pd As PropertyDescriptor = TypeDescriptor.GetProperties(instance)(propertyName)
        Dim tdc As New Syncfusion.ComponentModel.TypeDescriptorContext(instance, pd)
        tdc.ServiceProvider = esc

        ce.EditValue(tdc, esc, pd.GetValue(instance))

        Return esc.DialogResult
    End Function
    Private Sub groupingGrid1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
        e.Style.CellTipText = e.TableCellIdentity.Info
    End Sub

    Friend Function _ShowGridColumnsDialog(ByVal instance As Object, ByVal propertyName As String, ByVal provider As IServiceProvider, ByVal type As Type) As DialogResult
        Dim ce As New GroupingCollectionEditor(type)
        Dim esc As New Syncfusion.ComponentModel.WindowsFormsEditorServiceContainer(provider)
        Dim pd As PropertyDescriptor = TypeDescriptor.GetProperties(instance)(propertyName)
        Dim tdc As New Syncfusion.ComponentModel.TypeDescriptorContext(instance, pd)
        tdc.ServiceProvider = esc

        ce.EditValue(tdc, esc, pd.GetValue(instance))

        Return esc.DialogResult
    End Function

    Private Sub ReadXml(ByVal xmlFileName As String)
        Dim fileName As String = xmlFileName
        For n As Integer = 0 To 9
            If File.Exists(xmlFileName) Then
                Me.dataSet11.ReadXml(xmlFileName)
                Return
            End If
            xmlFileName = ".\" & xmlFileName
        Next n
        MessageBox.Show(fileName & " not found. " & Constants.vbLf + Constants.vbLf & "Please make sure the Grid\Samples\Data folder can be found in a parent directory!", "GroupingPreview - Data folder not found")
        Close()
    End Sub


    Private Function IsCustomersTableShown() As Boolean
        Return Me.groupingGrid1.Engine.DataMember = "Customers" OrElse Me.groupingGrid1.Engine.DataMember = ""
    End Function

    Private Function IsCustomersTableShown(ByVal showMessage As Boolean) As Boolean
        Dim b As Boolean = IsCustomersTableShown()
        If (Not b) AndAlso showMessage Then
            MessageBox.Show("This menu entry only works with the Customers table. " & Constants.vbLf & "Use the 'Choose ..' entry below instead.")
        End If
        Return b
    End Function

    Private connection As OleDbConnection
    Private fileName As String = ""

    Private Sub groupView1_GroupViewItemSelected(ByVal sender As Object, ByVal e As EventArgs) Handles groupView1.GroupViewItemSelected
        Select Case Me.groupView1.GroupViewItems((TryCast(sender, GroupView)).SelectedItem).Text
            Case "CustomersDataTable (from Xml)"
                Me.groupingGrid1.ResetTableDescriptor()
                Me.groupingGrid1.DataSource = Me.dataSet11.Customers
                Me.groupingGrid1.DataMember = ""
            Case "Browse Table"
                Dim f As New SelectTableForm()
                f.Table = Me.groupingGrid1.Engine.DataMember
                If fileName <> "" Then
                    f.FileName = fileName
                    f.Table = Me.groupingGrid1.Engine.DataMember
                End If
                If f.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso f.Table IsNot "" Then
                    fileName = f.FileName
                    Dim dataAdapter As OleDbDataAdapter = Nothing
                    Dim _dataSet As DataSet = Nothing
                    Dim tableName As String = f.Table

                    Try
                        ' Connection object
                        If connection Is Nothing Then
                            connection = New OleDbConnection(f.ConnectionString)
                        End If

                        ' Create data adapter object
                        dataAdapter = New OleDbDataAdapter("SELECT * FROM [" & tableName & "]", connection)

                        ' Create a dataset object and fill with data using data adapter's Fill method
                        _dataSet = New DataSet()
                        dataAdapter.Fill(_dataSet, tableName)
                        connection.Close()

                        Me.groupingGrid1.CancelEdit()
                        If f.ResetColumnChecked OrElse f.Table IsNot Me.groupingGrid1.Engine.DataMember Then
                            Me.groupingGrid1.ResetTableDescriptor()
                        End If

                        Me.groupingGrid1.Engine.DataMember = ""
                        Me.groupingGrid1.Engine.DataSource = _dataSet.Tables(tableName)

                        Me.Text = tableName
                    Catch ex As Exception
                        MessageBox.Show("Problem with DB access-" & Constants.vbLf + Constants.vbLf & "   connection: " & f.ConnectionString & Constants.vbLf + Constants.vbLf + ex.ToString())
                        Return
                    End Try
                End If
            Case "Reset Filters, Summaries and Grouping"
                Me.groupingGrid1.ResetTableDescriptor()
        End Select
    End Sub

    Private Sub groupView3_GroupViewItemSelected(ByVal sender As Object, ByVal e As EventArgs) Handles groupView3.GroupViewItemSelected
        Select Case Me.groupView3.GroupViewItems((TryCast(sender, GroupView)).SelectedItem).Text
            Case "Choose Columns .."
                _ShowGridColumnsDialog(Me.groupingGrid1.Engine.TableDescriptor, "Columns", Nothing, GetType(GridColumnDescriptorCollection))
            Case "Reset Columns"
                Me.groupingGrid1.Engine.TableDescriptor.ResetColumns()
            Case "Choose ColumnSets .."
                _ShowGridColumnsDialog(Me.groupingGrid1.Engine.TableDescriptor, "ColumnSets", Nothing, GetType(GridColumnSetDescriptorCollection))
            Case "Reset ColumnSets"
                Me.groupingGrid1.Engine.TableDescriptor.ResetColumnSets()
            Case "Choose Column Order .."
                _ShowGridColumnsDialog(Me.groupingGrid1.Engine.TableDescriptor, "VisibleColumns", Nothing, GetType(GridVisibleColumnDescriptorCollection))
            Case "Reset Columns Order"
                Me.groupingGrid1.Engine.TableDescriptor.VisibleColumns.Reset()
            Case "Choose ExpressionFields"
                _ShowGridColumnsDialog(Me.groupingGrid1.Engine.TableDescriptor, "ExpressionFields", Nothing, GetType(ExpressionFieldDescriptorCollection))
        End Select

    End Sub

    Private Sub groupView4_GroupViewItemSelected(ByVal sender As Object, ByVal e As EventArgs) Handles groupView4.GroupViewItemSelected
        Select Case Me.groupView4.GroupViewItems((TryCast(sender, GroupView)).SelectedItem).Text
            Case "Choose Filters .."
                _ShowGridColumnsDialog(Me.groupingGrid1.Engine.TableDescriptor, "RecordFilters", Nothing, GetType(RecordFilterDescriptorCollection))
            Case "Clear Filters"
                Me.groupingGrid1.Engine.TableDescriptor.ResetRecordFilters()
            Case "Choose Grouping .."
                _ShowGridColumnsDialog(Me.groupingGrid1.Engine.TableDescriptor, "GroupedColumns", Nothing, GetType(SortColumnDescriptorCollection))
            Case "Clear Grouping"
                Me.groupingGrid1.Engine.TableDescriptor.ResetGroupedColumns()
            Case "Choose Summaries.."
                _ShowGridColumnsDialog(Me.groupingGrid1.Engine.TableDescriptor, "SummaryRows", Nothing, GetType(GridSummaryRowDescriptorCollection))
            Case "Clear Summaries"
                Me.groupingGrid1.Engine.TableDescriptor.ResetSummaryRows()
            Case "Choose Sorting.."
                _ShowGridColumnsDialog(Me.groupingGrid1.Engine.TableDescriptor, "SortedColumns", Nothing, GetType(SortColumnDescriptorCollection))
            Case "Clear Sorting"
                Me.groupingGrid1.Engine.TableDescriptor.ResetSortedColumns()
        End Select
    End Sub

    Private Sub checkBoxAdv1_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv1.CheckStateChanged
        Dim standard As GridStyleInfo = Me.groupingGrid1.Engine.Appearance.AnyCell
        standard.Themed = Not standard.Themed
        Me.groupingGrid1.ThemesEnabled = standard.Themed
        Me.groupingGrid1.Office2007ScrollBars = True
        If standard.Themed Then
            Me.DropShadow = True
            Me.groupingGrid1.GridVisualStyles = GridVisualStyles.Metro
        Else
            Me.groupingGrid1.TableOptions.GridVisualStyles = GridVisualStyles.SystemTheme
        End If
        Me.groupingGrid1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue
    End Sub
End Class
