Imports Microsoft.VisualBasic
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
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits MetroForm
#Region "Private Members"
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private propertyGrid1 As System.Windows.Forms.PropertyGrid
    Private WithEvents comboBoxBase1 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
    Private gridListControl1 As Syncfusion.Windows.Forms.Grid.GridListControl
    Private groupBox2 As System.Windows.Forms.GroupBox
    Private textLog As System.Windows.Forms.TextBox
    Friend Label1 As System.Windows.Forms.Label
    Private sqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Private sqlConnection1 As System.Data.SqlClient.SqlConnection
    Private sqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Private dataSet11 As DataSet1
    Private WithEvents comboDropDown1 As ComboBoxAdv
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing

#End Region

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("D:\icons\LOGO.ico"))
            Me.Icon = ico
        Catch
        End Try

        'we'll read the data from a local XML file
        'comment this line if you want to access your SQLserver
        'ReadXML(dataSet11, @"Common\Data\ComboBoxExtData.XML");
        ReadXML(dataSet11, "ComboBoxExtData.XML")

        'uncomment these DataAdapter1.Fill lines if you want to access your SQLserver
        'load the dataset with the tables we use
        'this.sqlDataAdapter1.Fill(this.dataSet11);
    End Sub

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboBoxBase1 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase()
        Me.gridListControl1 = New Syncfusion.Windows.Forms.Grid.GridListControl()
        Me.dataSet11 = New DataSet1()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.textLog = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.sqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.comboDropDown1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
        Me.groupBox1.SuspendLayout()
        CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.comboDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Controls.Add(Me.comboBoxBase1)
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.groupBox1.Location = New System.Drawing.Point(27, 69)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(192, 56)
        Me.groupBox1.TabIndex = 0
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "ComboBoxBase"
        ' 
        ' comboBoxBase1
        ' 
        Me.comboBoxBase1.BackColor = System.Drawing.Color.White
        Me.comboBoxBase1.DropDownWidth = 320
        Me.comboBoxBase1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.comboBoxBase1.ListControl = Me.gridListControl1
        Me.comboBoxBase1.Location = New System.Drawing.Point(16, 24)
        Me.comboBoxBase1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
        Me.comboBoxBase1.Name = "comboBoxBase1"
        Me.comboBoxBase1.Size = New System.Drawing.Size(160, 21)
        Me.comboBoxBase1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.comboBoxBase1.TabIndex = 0
        '			Me.comboBoxBase1.DropDownCloseOnClick += New Syncfusion.Windows.Forms.Tools.MouseClickCancelEventHandler(Me.comboBoxBase1_DropDownCloseOnClick)
        '			Me.comboBoxBase1.Validating += New System.ComponentModel.CancelEventHandler(Me.comboBoxBase1_Validating)
        '			Me.comboBoxBase1.Validated += New System.EventHandler(Me.comboBoxBase1_Validated)
        '			Me.comboBoxBase1.SelectionChangeCommitted += New System.EventHandler(Me.comboBoxBase1_SelectionChangeCommitted)
        '			Me.comboBoxBase1.DropDown += New System.EventHandler(Me.comboBoxBase1_DropDown)
        '			Me.comboBoxBase1.TextChanged += New System.EventHandler(Me.comboBoxBase1_TextChanged)
        ' 
        ' gridListControl1
        ' 
        Me.gridListControl1.BackColor = System.Drawing.Color.White
        Me.gridListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridListControl1.DataSource = Me.dataSet11.Products
        Me.gridListControl1.DisplayMember = "ProductName"
        Me.gridListControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridListControl1.ItemHeight = 18
        Me.gridListControl1.Location = New System.Drawing.Point(43, 131)
        Me.gridListControl1.MultiColumn = True
        Me.gridListControl1.Name = "gridListControl1"
        Me.gridListControl1.Properties.BackgroundColor = System.Drawing.SystemColors.Window
        Me.gridListControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(57))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(122))))))
        Me.gridListControl1.Properties.MarkColHeader = False
        Me.gridListControl1.Properties.MarkRowHeader = False
        Me.gridListControl1.SelectedIndex = -1
        Me.gridListControl1.Size = New System.Drawing.Size(216, 144)
        Me.gridListControl1.SupportsTransparentBackColor = True
        Me.gridListControl1.TabIndex = 3
        Me.gridListControl1.ThemesEnabled = True
        Me.gridListControl1.TopIndex = 0
        Me.gridListControl1.ValueMember = "ProductID"
        ' 
        ' dataSet11
        ' 
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        ' 
        ' propertyGrid1
        ' 
        Me.propertyGrid1.Location = New System.Drawing.Point(478, 50)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(200, 373)
        Me.propertyGrid1.TabIndex = 1
        ' 
        ' groupBox2
        ' 
        Me.groupBox2.Controls.Add(Me.textLog)
        Me.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.groupBox2.Location = New System.Drawing.Point(24, 281)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(448, 144)
        Me.groupBox2.TabIndex = 4
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Event Log:"
        ' 
        ' textLog
        ' 
        Me.textLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textLog.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.textLog.Location = New System.Drawing.Point(3, 18)
        Me.textLog.Multiline = True
        Me.textLog.Name = "textLog"
        Me.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textLog.Size = New System.Drawing.Size(442, 123)
        Me.textLog.TabIndex = 0
        ' 
        ' Label1
        ' 
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "The ComboBoxBase control shown below, is bound to a GridListControl which is bein" & "g used in the drop-down. Properties of both controls can be modified using the P" & "ropertyGrid to the right hand side."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        ' 
        ' sqlSelectCommand1
        ' 
        Me.sqlSelectCommand1.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice" & ", UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products"
        Me.sqlSelectCommand1.Connection = Me.sqlConnection1
        ' 
        ' sqlConnection1
        ' 
        Me.sqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_sampl" & "es;persist security info=True;user id=sa;packet size=4096;Pooling=true"
        Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
        ' 
        ' sqlInsertCommand1
        ' 
        Me.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText")
        Me.sqlInsertCommand1.Connection = Me.sqlConnection1
        Me.sqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued")})
        ' 
        ' sqlUpdateCommand1
        ' 
        Me.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText")
        Me.sqlUpdateCommand1.Connection = Me.sqlConnection1
        Me.sqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ProductName", System.Data.SqlDbType.NVarChar, 40, "ProductName"), New System.Data.SqlClient.SqlParameter("@SupplierID", System.Data.SqlDbType.Int, 4, "SupplierID"), New System.Data.SqlClient.SqlParameter("@CategoryID", System.Data.SqlDbType.Int, 4, "CategoryID"), New System.Data.SqlClient.SqlParameter("@QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, "QuantityPerUnit"), New System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Money, 8, "UnitPrice"), New System.Data.SqlClient.SqlParameter("@UnitsInStock", System.Data.SqlDbType.SmallInt, 2, "UnitsInStock"), New System.Data.SqlClient.SqlParameter("@UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, "UnitsOnOrder"), New System.Data.SqlClient.SqlParameter("@ReorderLevel", System.Data.SqlDbType.SmallInt, 2, "ReorderLevel"), New System.Data.SqlClient.SqlParameter("@Discontinued", System.Data.SqlDbType.Bit, 1, "Discontinued"), New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.Int, 4, "ProductID")})
        ' 
        ' sqlDeleteCommand1
        ' 
        Me.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText")
        Me.sqlDeleteCommand1.Connection = Me.sqlConnection1
        Me.sqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CategoryID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "CategoryID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Discontinued", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "Discontinued", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ProductName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ProductName", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_QuantityPerUnit", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "QuantityPerUnit", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ReorderLevel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "ReorderLevel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SupplierID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "SupplierID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitPrice", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsInStock", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsInStock", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_UnitsOnOrder", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, (CByte(0)), (CByte(0)), "UnitsOnOrder", System.Data.DataRowVersion.Original, Nothing)})
        ' 
        ' sqlDataAdapter1
        ' 
        Me.sqlDataAdapter1.DeleteCommand = Me.sqlDeleteCommand1
        Me.sqlDataAdapter1.InsertCommand = Me.sqlInsertCommand1
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})})
        Me.sqlDataAdapter1.UpdateCommand = Me.sqlUpdateCommand1
        ' 
        ' comboDropDown1
        ' 
        Me.comboDropDown1.BackColor = System.Drawing.Color.White
        Me.comboDropDown1.Location = New System.Drawing.Point(478, 16)
        Me.comboDropDown1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
        Me.comboDropDown1.Name = "comboDropDown1"
        Me.comboDropDown1.Size = New System.Drawing.Size(200, 21)
        Me.comboDropDown1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.comboDropDown1.TabIndex = 7
        '			Me.comboDropDown1.SelectedIndexChanging += New Syncfusion.Windows.Forms.Tools.SelectedIndexChangingHandler(Me.comboDropDown1_SelectedIndexChanging)
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.ClientSize = New System.Drawing.Size(688, 431)
        Me.Controls.Add(Me.comboDropDown1)
        Me.Controls.Add(Me.gridListControl1)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.groupBox2)
        Me.DropShadow = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
        Me.Text = "DropDown Grid Demo"
        '			Me.Load += New System.EventHandler(Me.Form1_Load)
        Me.groupBox1.ResumeLayout(False)
        CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.comboDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

#Region "Form Handlers"

    Private Sub ReadXML(ByVal dataSet11 As DataSet, ByVal xmlFileName As String)
        For n As Integer = 0 To 9
            If File.Exists(xmlFileName) Then
                Me.dataSet11.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" & xmlFileName
        Next n


    End Sub
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

#End Region

#Region "EventHandlers"
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.comboDropDown1.Items.Add(Me.comboBoxBase1)
        Me.comboDropDown1.Items.Add(Me.gridListControl1)
        Me.comboDropDown1.SelectedIndex = 0
        Me.gridListControl1.BackColor = System.Drawing.SystemColors.Window

        Me.Text = "DropDown Grid Demo"
#If SyncfusionFramework2_0 Then
        Me.Text = "DropDown Grid Demo."
#End If

        Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
        Me.Icon = ico
    End Sub

    Private Sub comboBoxBase1_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxBase1.DropDown
        Me.textLog.Text &= "Event: DropDown" & Constants.vbCrLf
        'this.comboBoxBase1.PopupContainer.Width = 400;
    End Sub

    Private Sub comboBoxBase1_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxBase1.SelectionChangeCommitted
        Me.textLog.Text &= "Event: SelectionChangeCommitted" & Constants.vbCrLf
    End Sub

    Private Sub comboBoxBase1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxBase1.Validated
        Me.textLog.Text &= "Event: Validated" & Constants.vbCrLf
    End Sub

    Private Sub comboBoxBase1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles comboBoxBase1.Validating
        Me.textLog.Text &= "Event: Validating" & Constants.vbCrLf
    End Sub

    Private Sub comboBoxBase1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxBase1.TextChanged
        Me.textLog.Text &= "Event: TextChanged" & Constants.vbCrLf
    End Sub

    Private Sub comboBoxBase1_DropDownCloseOnClick(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.MouseClickCancelEventArgs) Handles comboBoxBase1.DropDownCloseOnClick
        ' Optionally, you can prevent the dropdown from closing
        ' when there are no selected items in the list control.
        ' This might happen when you resized the column width via the header, for example.
        If Me.gridListControl1.SelectedIndex = -1 Then
            args.Cancel = True
        End If
    End Sub

    Private Sub comboDropDown1_SelectedIndexChanging(ByVal sender As Object, ByVal e As SelectedIndexChangingArgs) Handles comboDropDown1.SelectedIndexChanging
        Me.propertyGrid1.SelectedObject = Me.comboDropDown1.SelectedItem
    End Sub

#End Region

End Class
