#Region "Copyright Syncfusion Inc. 2001 - 2009"
'
'  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
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
Imports System.Resources
Imports System.Windows.Forms
Imports System.IO

Namespace RecordNavDataBoundGrid

    '<summary>
    'Summary description for Form1.
    '</summary>
    Public Class Form1
        Inherits Form
        Private WithEvents gridRecordNavigationControl1 As GridRecordNavigationControl

        '<summary>
        'Required designer variable.
        '</summary>
        Private components As Container
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
            Me.GridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
            Me.GridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Dim style As GridStyleInfo = GridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"
            Me.BackColor = Color.FromArgb(223, 227, 239)
            Me.StartPosition = FormStartPosition.CenterScreen
            'Listen to the IBindingList.ListChanged events instead of the 
	    'CurrencyManager events.
            Me.GridDataBoundGrid1.UseListChangedEvent = True
        

        End Sub

        '<summary>
        'Clean up any resources being used.
        '</summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub

        '<summary>
        'Required method for Designer support - do not modify
        'the contents of this method with the code editor.
        '</summary>
        Friend WithEvents GridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
        Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
        Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
        Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
        Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
        Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
        Friend WithEvents DataSet11 As DataSet1
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Private Sub InitializeComponent()
            Me.gridRecordNavigationControl1 = New Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl()
            Me.GridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid()
            Me.DataSet11 = New DataSet1()
            Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
            Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
            Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
            Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
            Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
            Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.gridRecordNavigationControl1.SuspendLayout()
            CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridRecordNavigationControl1
            '
            Me.gridRecordNavigationControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.gridRecordNavigationControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridRecordNavigationControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.GridDataBoundGrid1})
            Me.gridRecordNavigationControl1.EnabledArrowColor = System.Drawing.Color.FromArgb(CType(222, Byte), CType(100, Byte), CType(19, Byte))
            Me.gridRecordNavigationControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
            Me.gridRecordNavigationControl1.ForeColor = System.Drawing.Color.Black
            Me.gridRecordNavigationControl1.Location = New System.Drawing.Point(48, 32)
            Me.gridRecordNavigationControl1.MaxRecord = 0
            Me.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1"
            Me.gridRecordNavigationControl1.NavigationBarBackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(191, Byte), CType(52, Byte))
            Me.gridRecordNavigationControl1.ShowToolTips = True
            Me.gridRecordNavigationControl1.Size = New System.Drawing.Size(712, 305)
            Me.gridRecordNavigationControl1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.Both
            Me.gridRecordNavigationControl1.TabIndex = 0
            Me.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1"
            Me.gridRecordNavigationControl1.ThemesEnabled = True
            '
            'GridDataBoundGrid1
            '
            Me.GridDataBoundGrid1.AllowDragSelectedCols = True
            Me.GridDataBoundGrid1.DataSource = Me.DataSet11.Customers
            Me.GridDataBoundGrid1.FillSplitterPane = True
            Me.GridDataBoundGrid1.HorizontalThumbTrack = True
            Me.GridDataBoundGrid1.Name = "GridDataBoundGrid1"
            Me.GridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.GridDataBoundGrid1.SmartSizeBox = False
            Me.GridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
            Me.GridDataBoundGrid1.Text = "GridDataBoundGrid1"
            Me.GridDataBoundGrid1.ThemesEnabled = True
            Me.GridDataBoundGrid1.VerticalThumbTrack = True
            '
            'DataSet11
            '
            Me.DataSet11.DataSetName = "DataSet1"
            Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
            '
            'SqlSelectCommand1
            '
            Me.SqlSelectCommand1.CommandText = "SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region," & _
            " PostalCode, Country, Phone, Fax FROM Customers"
            Me.SqlSelectCommand1.Connection = Me.SqlConnection1
            '
            'SqlConnection1
            '
            Me.SqlConnection1.ConnectionString = "Network Address=66.135.59.108,49489;initial catalog=NORTHWIND;password=Sync_samples;persist security info=True;user id=sa;packet size=4096;Pooling=true"
            '
            'SqlInsertCommand1
            '
            Me.SqlInsertCommand1.CommandText = "INSERT INTO Customers(CustomerID, CompanyName, ContactName, ContactTitle, Address" & _
            ", City, Region, PostalCode, Country, Phone, Fax) VALUES (@CustomerID, @CompanyNa" & _
            "me, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country" & _
            ", @Phone, @Fax); SELECT CustomerID, CompanyName, ContactName, ContactTitle, Addr" & _
            "ess, City, Region, PostalCode, Country, Phone, Fax FROM Customers WHERE (Custome" & _
            "rID = @CustomerID)"
            Me.SqlInsertCommand1.Connection = Me.SqlConnection1
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"))
            Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"))
            '
            'SqlUpdateCommand1
            '
            Me.SqlUpdateCommand1.CommandText = "UPDATE Customers SET CustomerID = @CustomerID, CompanyName = @CompanyName, Contac" & _
            "tName = @ContactName, ContactTitle = @ContactTitle, Address = @Address, City = @" & _
            "City, Region = @Region, PostalCode = @PostalCode, Country = @Country, Phone = @P" & _
            "hone, Fax = @Fax WHERE (CustomerID = @Original_CustomerID) AND (Address = @Origi" & _
            "nal_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @Origi" & _
            "nal_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Origina" & _
            "l_CompanyName) AND (ContactName = @Original_ContactName OR @Original_ContactName" & _
            " IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle OR " & _
            "@Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Origina" & _
            "l_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Original" & _
            "_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone OR @" & _
            "Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_PostalCode" & _
            " OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Original" & _
            "_Region OR @Original_Region IS NULL AND Region IS NULL); SELECT CustomerID, Comp" & _
            "anyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, " & _
            "Phone, Fax FROM Customers WHERE (CustomerID = @CustomerID)"
            Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.NVarChar, 5, "CustomerID"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CompanyName", System.Data.SqlDbType.NVarChar, 40, "CompanyName"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactName", System.Data.SqlDbType.NVarChar, 30, "ContactName"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ContactTitle", System.Data.SqlDbType.NVarChar, 30, "ContactTitle"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Address", System.Data.SqlDbType.NVarChar, 60, "Address"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@City", System.Data.SqlDbType.NVarChar, 15, "City"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Region", System.Data.SqlDbType.NVarChar, 15, "Region"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PostalCode", System.Data.SqlDbType.NVarChar, 10, "PostalCode"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Country", System.Data.SqlDbType.NVarChar, 15, "Country"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Phone", System.Data.SqlDbType.NVarChar, 24, "Phone"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fax", System.Data.SqlDbType.NVarChar, 24, "Fax"))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing))
            '
            'SqlDeleteCommand1
            '
            Me.SqlDeleteCommand1.CommandText = "DELETE FROM Customers WHERE (CustomerID = @Original_CustomerID) AND (Address = @O" & _
            "riginal_Address OR @Original_Address IS NULL AND Address IS NULL) AND (City = @O" & _
            "riginal_City OR @Original_City IS NULL AND City IS NULL) AND (CompanyName = @Ori" & _
            "ginal_CompanyName) AND (ContactName = @Original_ContactName OR @Original_Contact" & _
            "Name IS NULL AND ContactName IS NULL) AND (ContactTitle = @Original_ContactTitle" & _
            " OR @Original_ContactTitle IS NULL AND ContactTitle IS NULL) AND (Country = @Ori" & _
            "ginal_Country OR @Original_Country IS NULL AND Country IS NULL) AND (Fax = @Orig" & _
            "inal_Fax OR @Original_Fax IS NULL AND Fax IS NULL) AND (Phone = @Original_Phone " & _
            "OR @Original_Phone IS NULL AND Phone IS NULL) AND (PostalCode = @Original_Postal" & _
            "Code OR @Original_PostalCode IS NULL AND PostalCode IS NULL) AND (Region = @Orig" & _
            "inal_Region OR @Original_Region IS NULL AND Region IS NULL)"
            Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CustomerID", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Address", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Address", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_City", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "City", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CompanyName", System.Data.SqlDbType.NVarChar, 40, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CompanyName", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactName", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactName", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ContactTitle", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ContactTitle", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Country", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Country", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fax", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fax", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Phone", System.Data.SqlDbType.NVarChar, 24, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Phone", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PostalCode", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PostalCode", System.Data.DataRowVersion.Original, Nothing))
            Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Region", System.Data.SqlDbType.NVarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Region", System.Data.DataRowVersion.Original, Nothing))
            '
            'SqlDataAdapter1
            '
            Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
            Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
            Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
            Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax")})})
            Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
            '
            'Panel1
            '
            Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(808, 374)
            Me.Panel1.TabIndex = 1
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(808, 374)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.gridRecordNavigationControl1, Me.Panel1})
            Me.Name = "Form1"
            Me.Text = "Record Nav Data Bound Grid Demo"
            Me.gridRecordNavigationControl1.ResumeLayout(False)
            CType(Me.GridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

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
                Me.GridDataBoundGrid1.BeginUpdate()

                'we'll read the data from a local XML file
                'comment this line if you want to access your SQLserver
                ReadXml("Common\Data\GDBDdata.XML")
                'uncomment this Fill line if you want to access your SQLserver
                ' Me.SqlDataAdapter1.Fill(Me.DataSet11)

                Me.GridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0))
                Me.GridDataBoundGrid1.CurrentCell.MoveTo(1, 1)
                Me.GridDataBoundGrid1.EndUpdate()
                'Me.gridDataBoundGrid1.DefaultRowHeight = 18
                'Me.gridDataBoundGrid1.DefaultColWidth = 70
                Me.GridDataBoundGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver
                Me.GridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
                GridDataBoundGrid1.BackColor = Color.FromArgb(196, 214, 233)

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


        Private Sub Form1_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

            ' You should call Update if you want changes made in the DataGrid be committed
            ' to the datasource. 
            ' Just uncomment the line below.
            ' this.sqlDataAdapter1.Update(this.dataSet11);

        End Sub
    End Class
End Namespace
