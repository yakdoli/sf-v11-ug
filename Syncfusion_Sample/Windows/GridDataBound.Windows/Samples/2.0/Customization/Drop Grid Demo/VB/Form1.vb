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

Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms
Imports System.IO

Public Class Form1
    Inherits Form
    Private WithEvents sqlDataAdapter1 As SqlDataAdapter
    Private WithEvents sqlSelectCommand1 As SqlCommand
    Private WithEvents sqlConnection1 As SqlConnection

    Private WithEvents sqlDataAdapter2 As SqlDataAdapter
    Private WithEvents sqlSelectCommand2 As SqlCommand
    Private WithEvents customerGrid1 As GridHierDataBoundGrid
    Private WithEvents orderGrid2 As GridHierDataBoundGrid
    Private WithEvents order_DetailsGrid3 As GridDataBoundGrid
    Private WithEvents sqlDataAdapter3 As SqlDataAdapter
    Private WithEvents sqlSelectCommand3 As SqlCommand
    Private WithEvents sqlDataAdapter4 As SqlDataAdapter
    Private WithEvents sqlSelectCommand4 As SqlCommand
    Private WithEvents sqlDataAdapter5 As SqlDataAdapter
    Private WithEvents sqlSelectCommand5 As SqlCommand
    Private components As Container
    'Fields
    'Constructors
    'Events
    'Methods
    Public Sub New()
        MyBase.New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
            Me.Icon = ico
        Catch ex As Exception
        End Try

    End Sub
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)

    End Sub
    Friend WithEvents DataSet11 As GDBGwithDropGrids.DataSet1

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.sqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DataSet11 = New GDBGwithDropGrids.DataSet1
        Me.sqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter3 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter4 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.sqlDataAdapter5 = New System.Data.SqlClient.SqlDataAdapter
        Me.sqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sqlDataAdapter1
        '
        Me.sqlDataAdapter1.SelectCommand = Me.sqlSelectCommand1
        Me.sqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax")})})
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
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sqlDataAdapter2
        '
        Me.sqlDataAdapter2.SelectCommand = Me.sqlSelectCommand2
        Me.sqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
        '
        'sqlSelectCommand2
        '
        Me.sqlSelectCommand2.CommandText = "SELECT OrderID, CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, Shi" & _
            "pVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, Ship" & _
            "Country FROM Orders"
        Me.sqlSelectCommand2.Connection = Me.sqlConnection1
        '
        'sqlDataAdapter3
        '
        Me.sqlDataAdapter3.SelectCommand = Me.sqlSelectCommand3
        Me.sqlDataAdapter3.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Employees", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("LastName", "LastName"), New System.Data.Common.DataColumnMapping("FirstName", "FirstName"), New System.Data.Common.DataColumnMapping("Title", "Title"), New System.Data.Common.DataColumnMapping("TitleOfCourtesy", "TitleOfCourtesy"), New System.Data.Common.DataColumnMapping("BirthDate", "BirthDate"), New System.Data.Common.DataColumnMapping("HireDate", "HireDate"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("HomePhone", "HomePhone"), New System.Data.Common.DataColumnMapping("Extension", "Extension"), New System.Data.Common.DataColumnMapping("Photo", "Photo"), New System.Data.Common.DataColumnMapping("Notes", "Notes"), New System.Data.Common.DataColumnMapping("ReportsTo", "ReportsTo"), New System.Data.Common.DataColumnMapping("PhotoPath", "PhotoPath")})})
        '
        'sqlSelectCommand3
        '
        Me.sqlSelectCommand3.CommandText = "SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDa" & _
            "te, Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Not" & _
            "es, ReportsTo, PhotoPath FROM Employees"
        Me.sqlSelectCommand3.Connection = Me.sqlConnection1
        '
        'sqlDataAdapter4
        '
        Me.sqlDataAdapter4.SelectCommand = Me.sqlSelectCommand4
        Me.sqlDataAdapter4.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Order Details", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Discount", "Discount")})})
        '
        'sqlSelectCommand4
        '
        Me.sqlSelectCommand4.CommandText = "SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]"
        Me.sqlSelectCommand4.Connection = Me.sqlConnection1
        '
        'sqlDataAdapter5
        '
        Me.sqlDataAdapter5.SelectCommand = Me.sqlSelectCommand5
        Me.sqlDataAdapter5.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder")})})
        '
        'sqlSelectCommand5
        '
        Me.sqlSelectCommand5.CommandText = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnO" & _
            "rder FROM Products"
        Me.sqlSelectCommand5.Connection = Me.sqlConnection1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(592, 310)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDBG Drop Grid Demo"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    <STAThread()> _
    Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())

    End Sub

    Sub ReadXml(ByVal xmlFileName As String)
        Dim n As Integer
        For n = 0 To 10
            If (File.Exists(xmlFileName)) Then
                Me.DataSet11.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" & xmlFileName
        Next n '
    End Sub 'ReadXml


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'we'll read the data from a local XML file
            'comment this line if you want to access your SQLserver
            ReadXml("Common\Data\GDBDdata.XML")

            'uncomment these DataAdapter1.Fill lines if you want to access your SQLserver
            'load the dataset with the tables we use
            'Me.sqlDataAdapter1.Fill(Me.DataSet11)
            ' customers table - used for the main grid
            'Me.sqlDataAdapter2.Fill(Me.DataSet11)
            ' order's table - used for first dropdown grid
            'Me.sqlDataAdapter3.Fill(Me.DataSet11)
            ' employee's table - used for foreign key combo
            'Me.sqlDataAdapter4.Fill(Me.DataSet11)
            ' order details - used for the second dropdown grid
            'Me.sqlDataAdapter5.Fill(Me.DataSet11)



            ' products - used for foreign key griddropdownlist
            'inner most grid ... does not contain dropdowns - so it is a GridDataBoundGrid
            ' will be shown in dropdown
            Me.order_DetailsGrid3 = New GridHierDataBoundGrid(Me, Me.DataSet11.Order_Details, Nothing, Nothing, Nothing, Nothing, False)
            'setorder_DetailsGridLooks(this, EventArgs.Empty); //force the first setting...
            'this.order_DetailsGrid3.Model.DataProviderChanged += new EventHandler(setorder_DetailsGridLooks);
            'this.order_DetailsGrid3.Model.DataProviderChanged += new EventHandler(setorder_DetailsGridLooks);
            'in code, create a grid for the orders table - uses GridHierDataBoundGrid class
            ' - will be shown in dropdown
            Me.orderGrid2 = New GridHierDataBoundGrid(Me, Me.DataSet11.Orders, Me.DataSet11.Order_Details, Me.order_DetailsGrid3, New QueryFilterStringEventHandler(AddressOf ProvideOrder_DetailsFilterStrings), New QueryFormatGridEventHandler(AddressOf ProvideOrder_DetailsFormat), True)
            'setOrderGridLooks(this, EventArgs.Empty);//force the first setting...
            'this.orderGrid2.Model.DataProviderChanged += new EventHandler(setOrderGridLooks);
            'create the outer most grid for the customers table - uses GridHierDataBoundGrid class
            Me.customerGrid1 = New GridHierDataBoundGrid(Me, Me.DataSet11.Customers, Me.DataSet11.Orders, Me.orderGrid2, New QueryFilterStringEventHandler(AddressOf ProvideOrdersFilterStrings), New QueryFormatGridEventHandler(AddressOf ProvideOrderFormat), True)
            'set its properties....
            Me.customerGrid1.ThemesEnabled = True
            Me.customerGrid1.Location = New Point(20, 20)
            Me.customerGrid1.Size = New Size((Me.ClientSize.Width - 40), (Me.ClientSize.Height - 40))
            Me.customerGrid1.Anchor = (((AnchorStyles.Bottom Or AnchorStyles.Left) _
                        Or AnchorStyles.Right) _
                        Or AnchorStyles.Top)
            Me.customerGrid1.BorderStyle = BorderStyle.FixedSingle
            Me.Controls.Add(Me.customerGrid1)
            'this.customerGrid1.Model.HideCols[0] = true;
            Me.customerGrid1.CurrentCell.Deactivate(True)
            'this.customerGrid1.Model.Options.ActivateCurrentCellBehavior = GridCellActivateAction.SetCurrent;
            Me.customerGrid1.CurrentCell.Activate(1, 2, GridSetCurrentCellOptions.SetFocus)

            'Listen to the IBindingList.ListChanged events instead of the 
            'CurrencyManager events.
            Me.customerGrid1.UseListChangedEvent = True

            'Listen to the IBindingList.ListChanged events instead of the 
            'CurrencyManager events.
            Me.order_DetailsGrid3.UseListChangedEvent = True

            'Listen to the IBindingList.ListChanged events instead of the 
            'CurrencyManager events.
            Me.orderGrid2.UseListChangedEvent = True
            AddHandler Me.customerGrid1.PrepareViewStyleInfo, AddressOf customerGrid1_PrepareViewStyleInfo
            Me.customerGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.customerGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver
            Me.customerGrid1.DefaultColWidth = 70
            Me.customerGrid1.DefaultRowHeight = 18
            Me.customerGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
            Me.customerGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.customerGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            Dim style As GridStyleInfo = customerGrid1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"

            Me.orderGrid2.GridVisualStyles = GridVisualStyles.Office2007Blue
            Me.orderGrid2.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.orderGrid2.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            style = orderGrid2.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"
            Me.BackColor = Color.FromArgb(223, 227, 239)
            Me.StartPosition = FormStartPosition.CenterScreen
        Catch ex As Exception
            MessageBox.Show("This sample needs to access SQL server. Please recheck the connection string.")
            MessageBox.Show(ex.ToString())
        End Try
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

	
    Private Sub ProvideOrderFormat(ByVal sender As Object, ByVal e As QueryFormatGridEventArgs)
        e.Grid.Model.BaseStylesMap("Header").StyleInfo.BackColor = Color.FromArgb(100, 100, 255)
        e.Grid.Model.BaseStylesMap("Header").StyleInfo.TextColor = Color.FromArgb(&HFF, &HBF, &H34)
        e.Grid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        e.Grid.Model.Properties.GridLineColor = System.Drawing.Color.Silver
        AddHandler e.Grid.PrepareViewStyleInfo, AddressOf OrderFormat_PrepareViewStyleInfo

        'set up the EmployeeID column as a foreign key combo column
        Dim style As GridStyleInfo = CType(e.Grid, GridDataBoundGrid).GridBoundColumns("EmployeeID").StyleInfo
        style.CellType = "ComboBox"
        style.DataSource = Me.DataSet11.Employees
        style.ValueMember = "EmployeeID"
        style.DisplayMember = "LastName"
        style.ExclusiveChoiceList = True
    End Sub

    Private Sub ProvideOrder_DetailsFormat(ByVal sender As Object, ByVal e As QueryFormatGridEventArgs)
        e.Grid.Model.BaseStylesMap("Header").StyleInfo.BackColor = Color.FromArgb(100, 255, 100)
        e.Grid.Model.BaseStylesMap("Header").StyleInfo.TextColor = Color.FromArgb(&H85, &HBF, &H75)
        e.Grid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        e.Grid.Model.Properties.GridLineColor = System.Drawing.Color.Silver
        AddHandler e.Grid.PrepareViewStyleInfo, AddressOf DetailsFormat_PrepareViewStyleInfo

        'set up the ProductID columns as a foreign key griddroplist column
        Dim style As GridStyleInfo = CType(e.Grid, GridDataBoundGrid).GridBoundColumns("ProductID").StyleInfo
        style.CellType = "GridListControl"
        style.DataSource = Me.DataSet11.Products
        style.ValueMember = "ProductID"
        style.DisplayMember = "ProductName"
        style.ExclusiveChoiceList = True
    End Sub

    Private Sub ProvideOrdersFilterStrings(ByVal sender As Object, ByVal e As QueryFilterStringEventArgs)
        'add 1 to get to customerID
        If Me.customerGrid1.Model(e.Row, e.Column + 1).Text <> "" Then
            e.FilterString = String.Format("CustomerID = '{0}'", Me.customerGrid1.Model(e.Row, e.Column + 1).Text) 'add 1 to get to customerID
        End If

    End Sub
    Private Sub ProvideOrder_DetailsFilterStrings(ByVal sender As Object, ByVal e As QueryFilterStringEventArgs)
        If Me.orderGrid2.Model(e.Row, e.Column + 1).Text <> "" Then
            e.FilterString = String.Format("OrderID = '{0}'", Me.orderGrid2.Model(e.Row, e.Column + 1).Text)
        End If
    End Sub

    Private Sub customerGrid1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        If e.RowIndex Mod 2 = 0 AndAlso e.ColIndex > 0 Then
            e.Style.BackColor = Color.FromArgb(218, 229, 245) 'Color.FromArgb( 237, 240, 246 );			
        End If
    End Sub 'customerGrid1_PrepareViewStyleInfo

    Private Sub OrderFormat_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        If e.RowIndex > 0 AndAlso e.RowIndex Mod 2 = 0 AndAlso e.ColIndex > 0 Then
            e.Style.BackColor = Color.FromArgb(&HFF, &HBF, &H34)
        End If
    End Sub 'OrderFormat_PrepareViewStyleInfo

    Private Sub DetailsFormat_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        If e.RowIndex Mod 2 = 0 AndAlso e.ColIndex > 0 Then
            e.Style.BackColor = Color.FromArgb(&H85, &HBF, &H75)
        End If
    End Sub 'DetailsFormat_PrepareViewStyleInfo 
End Class

