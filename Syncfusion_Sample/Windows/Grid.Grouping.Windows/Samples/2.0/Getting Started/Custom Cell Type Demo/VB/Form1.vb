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
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Private sqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Private sqlDataAdapter3 As System.Data.SqlClient.SqlDataAdapter
    Private dataSet11 As CustomCellTypes.DataSet1
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico

        Catch ex As Exception

        End Try

       
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        Me.InitializeDataSet()
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        
        Me.gridGroupingControl1.TableOptions.AllowDropDownCell = False
        
        Me.gridGroupingControl1.AddGroupDropArea("Products")
        
       
        ' You can replace any of this cell types by registering a different cell type. If you do
        ' want for example replace the "PlusMinus" buttons used for expanding and collapsing records
        ' you can create a custom cell type.
        ' 
        ' Example:
        ' groupingGrid.Appearance.GroupCaptionPlusMinusCell.CellType = "MyPlusMinusButton";
        ' 
        ' this.groupingGrid1.TableModel.CellModels["MyPlusMinusButton"] = = new MyPlusMinusButtonModel(this.groupingGrid1.TableModel);
        ' 
        ' MyPlusMinusButtonModel and MyPlusMinusButtonRenderer could be derived from PushButtonCellModel and PushButtonCellRenderer and override the various virtual Draw methods.
        ' 
        ' See also the following MyHeaderCellModel example where we place an extra button inside
        ' column headers.
        Dim header As New MyHeaderCellModel(Me.gridGroupingControl1.TableModel)
        Me.gridGroupingControl1.TableModel.CellModels("My Column Header") = header
        Me.gridGroupingControl1.Appearance.ColumnHeaderCell.CellType = "My Column Header"

        Me.gridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = False
        
        ' The following event shows how you get information about the cell that is being clicked
        ' especially how to get access to the TableCellIdentity with information about column,
        ' display element etc.
        AddHandler Me.gridGroupingControl1.TableControlCellClick, AddressOf gridGroupingControl1_TableControlCellClick
        AddHandler Me.gridGroupingControl1.TableControlCellHitTest, AddressOf gridGroupingControl1_TableControlCellHitTest
        AddHandler Me.gridGroupingControl1.TableControlCellButtonClicked, AddressOf gridGroupingControl1_TableControlCellButtonClicked
        
        AddHandler Me.gridGroupingControl1.TableControlCellMouseHover, AddressOf gridGroupingControl1_TableControlCellMouseHover
          
        ' NOTE: If you open DataSet1.xsd and right click on the 
        ' relation between Products and Suppliers and select "Edit Relation" 
        ' you will notice in the dialog that is shown that the 
        ' DataSet property "Create foreign key constraint only" has been checked.
        ' This setting allows the grouping engine to differentiate between
        ' foreign key relations and master details relations when autopopulating
        ' relations.
		'
		' Check out also the "PrintGroupingGrid" sample code. In its form constructor
		' it shows how to avoid columns being automatically added to the parent table for each
		' column in the foreign table. It does instead manually add those columns
		' from the referenced table by setting ShowRelationFields = ShowRelationFields.Hide
		' and calling Columns.Add("ForeignTable.ColumnName")

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
    
    Private xmlName As String = "CatgeoryProductsShippers.xml"
    Private msdeAvailable As Boolean = False
    
    
    Sub InitializeDataSet()
        If msdeAvailable Then
            ' Initialize the data set
            Me.dataSet11.BeginInit()
            
            ' Order is important here - first fill tables that are referenced with 
            ' foreign keys, then tables that have references to others.
            Me.sqlDataAdapter1.Fill(Me.dataSet11)
            Me.sqlDataAdapter3.Fill(Me.dataSet11)
            Me.sqlDataAdapter2.Fill(Me.dataSet11)
            
            Me.dataSet11.EndInit()
            
            Me.dataSet11.WriteXml(xmlName)
        Else
            ' Read from a xml file instead. 
            If Not ReadXml(Me.dataSet11, xmlName) Then
                ' If no xml found, try again with MSDE
                msdeAvailable = True
                InitializeDataSet()
            End If
        End If
    End Sub 'InitializeDataSet
     
    
    Function ReadXml(ds As DataSet, xmlFileName As String) As Boolean
        ' Check both in parent folder and Parent\Data folders.
        Dim xmlDataFileName As String = "Common\Data\" + xmlFileName
        Dim n As Integer
        For n = 0 To 11
            If System.IO.File.Exists(xmlFileName) Then
                ds.ReadXml(xmlFileName)
                Return True
            End If
            If System.IO.File.Exists(xmlDataFileName) Then
                ds.ReadXml(xmlDataFileName)
                Return True
            End If
            xmlFileName = "..\" + xmlFileName
            xmlDataFileName = "..\" + xmlDataFileName
        Next n
        
        Return False
    End Function 'ReadXml
    
    
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
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Me.dataSet11 = New CustomCellTypes.DataSet1
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
        Me.sqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.sqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.sqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.sqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridGroupingControl1
        '
        Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.DataSource = Me.dataSet11.Categories
        Me.gridGroupingControl1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.Location = New System.Drawing.Point(16, 24)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.ShowGroupDropArea = True
        Me.gridGroupingControl1.Size = New System.Drawing.Size(672, 360)
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
        Me.gridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer)))
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sqlSelectCommand1
        '
        Me.sqlSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
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
        Me.sqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"), New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture")})
        '
        'sqlUpdateCommand1
        '
        Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CategoryName", System.Data.SqlDbType.NVarChar, 15, "CategoryName"), New System.Data.SqlClient.SqlParameter("@Description", System.Data.SqlDbType.NVarChar, 1073741823, "Description"), New System.Data.SqlClient.SqlParameter("@Picture", System.Data.SqlDbType.VarBinary, 2147483647, "Picture"), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID")})
        '
        'sqlDeleteCommand1
        '
        Me.sqlDeleteCommand1.CommandText = "DELETE FROM Categories WHERE (CategoryID = @Original_CategoryID) AND (CategoryNam" & _
            "e = @Original_CategoryName)"
        Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryName", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryName", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.DeleteCommand = Me.sqlDeleteCommand1
        Me.sqlDataAdapter1.InsertCommand = Me.sqlInsertCommand1
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
        Me.sqlDataAdapter1.UpdateCommand = Me.sqlUpdateCommand1
        '
        'sqlSelectCommand2
        '
        Me.sqlSelectCommand2.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" & _
            ", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products"
        Me.sqlSelectCommand2.Connection = Me.sqlConnection1
        '
        'sqlInsertCommand2
        '
        Me.sqlInsertCommand2.Connection = Me.sqlConnection1
        Me.sqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued")})
        '
        'sqlUpdateCommand2
        '
        Me.sqlUpdateCommand2.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"), New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID")})
        '
        'sqlDeleteCommand2
        '
        Me.sqlDeleteCommand2.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlDataAdapter2
        '
        Me.sqlDataAdapter2.DeleteCommand = Me.sqlDeleteCommand2
        Me.sqlDataAdapter2.InsertCommand = Me.sqlInsertCommand2
        Me.sqlDataAdapter2.SelectCommand = Me.sqlSelectCommand2
        Me.sqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})})
        Me.sqlDataAdapter2.UpdateCommand = Me.sqlUpdateCommand2
        '
        'sqlSelectCommand3
        '
        Me.sqlSelectCommand3.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region," & _
            " PostalCode, Country, Phone, Fax, HomePage FROM Suppliers"
        Me.sqlSelectCommand3.Connection = Me.sqlConnection1
        '
        'sqlInsertCommand3
        '
        Me.sqlInsertCommand3.Connection = Me.sqlConnection1
        Me.sqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"), New System.Data.SqlClient.SqlParameter("@HomePage", System.Data.SqlDbType.NVarChar, 1073741823, "HomePage")})
        '
        'sqlUpdateCommand3
        '
        Me.sqlUpdateCommand3.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"), New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"), New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"), New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"), New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"), New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"), New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"), New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"), New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"), New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"), New System.Data.SqlClient.SqlParameter("@HomePage", System.Data.SqlDbType.NVarChar, 1073741823, "HomePage"), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID")})
        '
        'sqlDeleteCommand3
        '
        Me.sqlDeleteCommand3.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing)})
        '
        'sqlDataAdapter3
        '
        Me.sqlDataAdapter3.DeleteCommand = Me.sqlDeleteCommand3
        Me.sqlDataAdapter3.InsertCommand = Me.sqlInsertCommand3
        Me.sqlDataAdapter3.SelectCommand = Me.sqlSelectCommand3
        Me.sqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Suppliers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax"), New System.Data.Common.DataColumnMapping("HomePage", "HomePage")})})
        Me.sqlDataAdapter3.UpdateCommand = Me.sqlUpdateCommand3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(720, 430)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.DropShadow = True
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Custom Cell Type Demo"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub 'Main


    ' In case you want to handle other Mouse events like Mouse Move and Mouse Hover
    ' you sometimes need to handle groupingGrid1_TableControlCellHitTest
    Private Sub gridGroupingControl1_TableControlCellHitTest(ByVal sender As Object, ByVal e As GridTableControlCellHitTestEventArgs)
        Dim style As GridTableCellStyleInfo = CType(e.TableControl.Model(e.Inner.RowIndex, e.Inner.ColIndex), GridTableCellStyleInfo)
        If style.TableCellIdentity.TableCellType = GridTableCellType.ColumnHeaderCell Then
            ' Uncommenting this will make gridGroupingControl1_TableControlCellClick not being hit
            ' for ColumnHeaderCell
            '				e.Inner.Cancel = true
            '				e.Inner.Result = 0
        End If
    End Sub 'gridGroupingControl1_TableControlCellHitTest


    Private Sub gridGroupingControl1_TableControlCellClick(ByVal sender As Object, ByVal e As GridTableControlCellClickEventArgs)
        Dim style As GridTableCellStyleInfo = CType(e.TableControl.Model(e.Inner.RowIndex, e.Inner.ColIndex), GridTableCellStyleInfo)
        Dim id As GridTableCellStyleInfoIdentity = style.TableCellIdentity

        If id.TableCellType = GridTableCellType.ColumnHeaderCell Then
            ' Workaround - gridGroupingControl1_TableControlCellButtonClicked does not get hit so
            ' we'll check for the area where the button is and set e.Inner.Cancel = true
            Dim r As GridCellRendererBase = e.TableControl.CellRenderers(style.CellType)
            r.PerformLayout(e.Inner.RowIndex, e.Inner.ColIndex, style, e.TableControl.RangeInfoToRectangle(GridRangeInfo.Cell(e.Inner.RowIndex, e.Inner.ColIndex)))
            If r.RaiseHitTest(e.Inner.RowIndex, e.Inner.ColIndex, e.Inner.MouseEventArgs, Nothing) = GridHitTestContext.CellButtonElement Then
                Dim column As String = ""
                If Not (id.Column Is Nothing) Then column = id.Column.ToString()
                Dim s As String = "Clicked on " + id.TableCellType.ToString() + "(" + column + ", " + id.DisplayElement.GetType().Name + ")"

                MessageBox.Show(s)
                e.Inner.Cancel = True
            End If
        End If
    End Sub 'gridGroupingControl1_TableControlCellClick


    Private Sub gridGroupingControl1_TableControlCellMouseHover(ByVal sender As Object, ByVal e As GridTableControlCellMouseEventArgs)
        Dim style As GridTableCellStyleInfo = CType(e.TableControl.Model(e.Inner.RowIndex, e.Inner.ColIndex), GridTableCellStyleInfo)
        Dim id As GridTableCellStyleInfoIdentity = style.TableCellIdentity

        '
        ' Note the check for not being a GridTableCellType.NestedTableCell below. If the mouse hovers
        ' over an area of a nested table, this event will get hit twice: First for the outer
        ' TableControl (which routes the event to the inner TableControl) and then afterward
        ' for the inner TableControl. For the outer TableControl the TableCellType 
        ' is GridTableCellType.NestedTableCell
        '
        If id.TableCellType <> GridTableCellType.NestedTableCell Then
            Dim column As String = ""
            If Not (id.Column Is Nothing) Then column = id.Column.ToString()
            Console.WriteLine("MouseHover over " + id.TableCellType.ToString() + "(" + column + ", " + id.DisplayElement.GetType().Name + ")")
        End If
    End Sub 'gridGroupingControl1_TableControlCellMouseHover


    Private Sub gridGroupingControl1_TableControlCellButtonClicked(ByVal sender As Object, ByVal e As GridTableControlCellButtonClickedEventArgs)
        Dim style As GridTableCellStyleInfo = CType(e.TableControl.Model(e.Inner.RowIndex, e.Inner.ColIndex), GridTableCellStyleInfo)
        Dim id As GridTableCellStyleInfoIdentity = style.TableCellIdentity

        If id.TableCellType <> GridTableCellType.NestedTableCell Then
            Dim column As String = ""
            If Not (id.Column Is Nothing) Then column = id.Column.ToString()
            Dim s As String = "TableControlCellButtonClicked on " + id.TableCellType.ToString() + "(" + column + ", " + id.DisplayElement.GetType().Name + ")"

            Console.WriteLine(s)
            e.Inner.Cancel = True
        End If


        If id.TableCellType = GridTableCellType.RecordPlusMinusCell Then
            ' Expand record without moving current record to that record (change default behavior
            ' of grid).
            Dim r As Record = id.DisplayElement.ParentRecord
            r.isExpanded = Not r.isExpanded
            e.Inner.Cancel = True ' don't let grid handle CellButtonClicked - otherwise it would reverse the IsExpanded call.
        End If


        If id.TableCellType = GridTableCellType.GroupCaptionPlusMinusCell Then
            ' Expand record without moving current record to that record (change default behavior
            ' of grid).
            Dim g As Group = id.DisplayElement.ParentGroup
            g.isExpanded = Not g.isExpanded
            e.Inner.Cancel = True ' don't let grid handle CellButtonClicked - otherwise it would reverse the IsExpanded call.
        End If
    End Sub 'gridGroupingControl1_TableControlCellButtonClicked 

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class 'Form1 