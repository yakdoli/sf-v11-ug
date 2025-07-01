Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Styles
Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms
Imports System.Data.SqlServerCe
Namespace GridBoundColumnSerialization
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits System.Windows.Forms.Form
        Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Private WithEvents dataset11 As Dataset1
        Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
        Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
        Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
        Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
        Private oleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
        Private oleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents button2 As System.Windows.Forms.Button
        Private components As System.ComponentModel.Container = Nothing
        Private Const connection As String = "Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Registry Path=;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Database Password=;Data Source=""{0}"";Jet OLEDB:Engine Type=5;Jet OLEDB:Global Bulk Transactions=1;Provider=""Microsoft.Jet.OLEDB.4.0"";Jet OLEDB:System database=;Jet OLEDB:SFP=False;Extended Properties=;Mode=Share Deny None;Jet OLEDB:New Database Password=;Jet OLEDB:Create System Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;User ID=Admin;Jet OLEDB:Encrypt Database=False"

        Public Sub New()
            InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
                Me.Icon = ico
            Catch ex As Exception

            End Try
            Dim commandstring As String = "select * from Customers"
            Dim connection As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
            Dim da As SqlCeDataAdapter = New SqlCeDataAdapter(commandstring, connection)
            Try
                da.Fill(dataset11, "Customers")
            Catch ex As SqlClient.SqlException
                ShowErrorMessage(ex)
            End Try

            'Format GridBoundColumns
            Me.gridDataBoundGrid1.Binder.InternalColumns(0).StyleInfo.BackColor = Color.FromArgb(255, 229, 201)
            Me.gridDataBoundGrid1.Binder.InternalColumns(1).StyleInfo.TextColor = Color.FromArgb(41, 65, 125)
            Me.gridDataBoundGrid1.Binder.InternalColumns(1).StyleInfo.Font.Bold = True
            Me.gridDataBoundGrid1.Binder.InternalColumns(2).StyleInfo.BackColor = Color.FromArgb(246, 246, 222)
            Me.gridDataBoundGrid1.Binder.InternalColumns(3).StyleInfo.Font.Bold = True
            Me.gridDataBoundGrid1.Binder.InternalColumns(4).StyleInfo.BackColor = Color.FromArgb(223, 247, 252)
            Me.gridDataBoundGrid1.Binder.InternalColumns(7).StyleInfo.BackColor = Color.FromArgb(205, 211, 227)
            Me.gridDataBoundGrid1.ThemesEnabled = True
            Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"
            Me.BackColor = Color.FromArgb(223, 227, 239)
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.gridDataBoundGrid1.AllowResizeToFit = False
            Me.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Table(), GridResizeToFitOptions.IncludeHeaders)
        End Sub
        Private Function FindFile(ByVal connstring As String) As String
            connstring = "common\data\" & connstring
            For n As Integer = 0 To 9
                If System.IO.File.Exists(connstring) Then
                    Return New FileInfo(connstring).FullName
                End If
                connstring = "..\" & connstring
            Next n
            Return connstring
        End Function
		
			Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		
        Private Shared Sub ShowErrorMessage(ByVal ex As SqlClient.SqlException)
            If ex.Number = 11001 Then
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If ex.Number = 208 Then
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If ex.Number = 156 OrElse ex.Number = 102 Then
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Sub
        Private Function FindDatabase(ByVal mdbFileName As String) As String
            For n As Integer = 0 To 9
                If System.IO.File.Exists(mdbFileName) Then
                    Return mdbFileName
                End If
                mdbFileName = "..\" & mdbFileName
            Next n
            Return ""
        End Function

        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        Friend WithEvents Panel1 As System.Windows.Forms.Panel

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
            Me.dataset11 = New Dataset1
            Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
            Me.oleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
            Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
            Me.oleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand
            Me.button1 = New System.Windows.Forms.Button
            Me.button2 = New System.Windows.Forms.Button
            Me.Panel1 = New System.Windows.Forms.Panel
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataset11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridDataBoundGrid1
            '
            Me.gridDataBoundGrid1.AllowDragSelectedCols = True
            Me.gridDataBoundGrid1.DataMember = ""
            Me.gridDataBoundGrid1.DataSource = Me.dataset11.Customers
            Me.gridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
            Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
            Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid1.Size = New System.Drawing.Size(568, 224)
            Me.gridDataBoundGrid1.SmartSizeBox = False
            Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
            Me.gridDataBoundGrid1.TabIndex = 0
            Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.UseListChangedEvent = True
            '
            'dataset11
            '
            Me.dataset11.DataSetName = "Dataset1"
            Me.dataset11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataset11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'oleDbDataAdapter1
            '
            Me.oleDbDataAdapter1.DeleteCommand = Me.oleDbDeleteCommand1
            Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
            Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
            Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("Fax", "Fax"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Region", "Region")})})
            Me.oleDbDataAdapter1.UpdateCommand = Me.oleDbUpdateCommand1
            '
            'oleDbDeleteCommand1
            '
            Me.oleDbDeleteCommand1.CommandText = resources.GetString("oleDbDeleteCommand1.CommandText")
            Me.oleDbDeleteCommand1.Connection = Me.oleDbConnection1
            Me.oleDbDeleteCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing)})
            '
            'oleDbConnection1
            '
            Me.oleDbConnection1.ConnectionString = resources.GetString("oleDbConnection1.ConnectionString")
            '
            'oleDbInsertCommand1
            '
            Me.oleDbInsertCommand1.CommandText = "INSERT INTO Customers(Address, City, CompanyName, ContactName, ContactTitle, Coun" & _
                "try, CustomerID, Fax, Phone, PostalCode, Region) VALUES (?, ?, ?, ?, ?, ?, ?, ?," & _
                " ?, ?, ?)"
            Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
            Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"), New System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"), New System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"), New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"), New System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"), New System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region")})
            '
            'oleDbSelectCommand1
            '
            Me.oleDbSelectCommand1.CommandText = "SELECT Address, City, CompanyName, ContactName, ContactTitle, Country, CustomerID" & _
                ", Fax, Phone, PostalCode, Region FROM Customers"
            Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
            '
            'oleDbUpdateCommand1
            '
            Me.oleDbUpdateCommand1.CommandText = resources.GetString("oleDbUpdateCommand1.CommandText")
            Me.oleDbUpdateCommand1.Connection = Me.oleDbConnection1
            Me.oleDbUpdateCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("Address", System.Data.OleDb.OleDbType.VarWChar, 60, "Address"), New System.Data.OleDb.OleDbParameter("City", System.Data.OleDb.OleDbType.VarWChar, 15, "City"), New System.Data.OleDb.OleDbParameter("CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, "CompanyName"), New System.Data.OleDb.OleDbParameter("ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactName"), New System.Data.OleDb.OleDbParameter("ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, "ContactTitle"), New System.Data.OleDb.OleDbParameter("Country", System.Data.OleDb.OleDbType.VarWChar, 15, "Country"), New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("Fax", System.Data.OleDb.OleDbType.VarWChar, 24, "Fax"), New System.Data.OleDb.OleDbParameter("Phone", System.Data.OleDb.OleDbType.VarWChar, 24, "Phone"), New System.Data.OleDb.OleDbParameter("PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "PostalCode"), New System.Data.OleDb.OleDbParameter("Region", System.Data.OleDb.OleDbType.VarWChar, 15, "Region"), New System.Data.OleDb.OleDbParameter("Original_CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Address1", System.Data.OleDb.OleDbType.VarWChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_City1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_CompanyName", System.Data.OleDb.OleDbType.VarWChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactName", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactName1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactTitle", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_ContactTitle1", System.Data.OleDb.OleDbType.VarWChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Country1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fax", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Fax1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Phone1", System.Data.OleDb.OleDbType.VarWChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_PostalCode1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing), New System.Data.OleDb.OleDbParameter("Original_Region1", System.Data.OleDb.OleDbType.VarWChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing)})
            '
            'button1
            '
            Me.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(180, 232)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(112, 23)
            Me.button1.TabIndex = 1
            Me.button1.Text = "BinarySerialize"
            '
            'button2
            '
            Me.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(221, Byte), Integer))
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.Location = New System.Drawing.Point(292, 232)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(112, 23)
            Me.button2.TabIndex = 2
            Me.button2.Text = "BinaryDeserialize"
            Me.button2.UseVisualStyleBackColor = False
            '
            'Panel1
            '
            Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Panel1.Controls.Add(Me.gridDataBoundGrid1)
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(568, 224)
            Me.Panel1.TabIndex = 4
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(231, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(568, 266)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.button2)
            Me.Controls.Add(Me.button1)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Serialize Data Bound Grid Demo"
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataset11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Dim dlg As FileDialog = New SaveFileDialog()
            dlg.Filter = "Binary files (*.egt)|*.egt|All files (*.*)|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    'serialize out the row heights & columnwidths
                    Dim formatter As IFormatter = New BinaryFormatter()
                    Dim stream As Stream = New FileStream(dlg.FileName, FileMode.Create, FileAccess.Write, FileShare.None)

                    'handle the mappingnames
                    Dim col As GridBoundColumnsCollection = CType(Me.gridDataBoundGrid1.GridBoundColumns, GridBoundColumnsCollection)
                    If col.Count = 0 Then
                        col = Me.gridDataBoundGrid1.Binder.InternalColumns
                    End If

                    Dim nCols As Integer = col.Count
                    Dim a As String() = New String(nCols - 1) {}
                    Dim i As Integer = 0
                    Dim c As GridBoundColumn
                    For Each c In col
                        'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
                        'ORIGINAL LINE: a[i += 1] = c.MappingName;
                        a(i = i + 1) = c.MappingName
                    Next c

                    formatter.Serialize(stream, a)
                    formatter.Serialize(stream, Me.gridDataBoundGrid1.Model.ColWidths.Dictionary)
                    formatter.Serialize(stream, Me.gridDataBoundGrid1.Model.RowHeights.Dictionary)
                    formatter.Serialize(stream, Me.gridDataBoundGrid1.Model.ColStyles(1).BackColor)
                    stream.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click

            Dim dlg As FileDialog = New OpenFileDialog()
            dlg.Filter = "Binary files (*.egt)|*.egt|All files (*.*)|*.*"
            If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    Dim formatter As IFormatter = New BinaryFormatter()
                    Dim stream As Stream = New FileStream(dlg.FileName, FileMode.Open, FileAccess.Read, FileShare.None)
                    Try
                        Me.gridDataBoundGrid1.BeginUpdate()

                        'handle the mappingnames
                        Dim col As GridBoundColumnsCollection = CType(Me.gridDataBoundGrid1.GridBoundColumns.Clone(), GridBoundColumnsCollection)
                        If col.Count = 0 Then
                            col = Me.gridDataBoundGrid1.Binder.InternalColumns
                        End If
                        'Deserialize GridBoundColumns
                        Dim a As String() = CType(formatter.Deserialize(stream), String())
                        Me.gridDataBoundGrid1.GridBoundColumns.Clear()
                        Dim s As String
                        For Each s In a
                            If s IsNot Nothing Then
                                Dim c As GridBoundColumn = col(s)
                                Me.gridDataBoundGrid1.GridBoundColumns.Add(c)
                            End If
                        Next s

                        Me.gridDataBoundGrid1.Model.ColWidths.Dictionary = CType(formatter.Deserialize(stream), Syncfusion.Windows.Forms.Grid.GridRowColSizeDictionary)
                        Me.gridDataBoundGrid1.Model.RowHeights.Dictionary = CType(formatter.Deserialize(stream), Syncfusion.Windows.Forms.Grid.GridRowColSizeDictionary)
                        Me.gridDataBoundGrid1.Model.ColStyles(1).BackColor = CType(formatter.Deserialize(stream), Color)
                    Finally
                        Me.gridDataBoundGrid1.EndUpdate()
                        Me.gridDataBoundGrid1.Refresh()
                        stream.Close()
                    End Try
                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            End If
        End Sub
    End Class
End Namespace
