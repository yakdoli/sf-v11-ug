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
Imports System.Data.SqlServerCe

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports System.IO
Imports Syncfusion.Windows.Forms



''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits MetroForm

    Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private productRatingsDataSet2 As ProductRatingsDataSet
    Private groupBox1 As GroupBox
    Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Private propertyGrid1 As PropertyGrid
    Private components As IContainer

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Me.gridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
        Me.gridGroupingControl1.TableOptions.GridLineBorder = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
        Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue
        Me.comboBoxAdv1.SelectedIndex = 0
        AddHandler comboBoxAdv1.SelectedIndexChanged, AddressOf comboBoxAdv1_SelectedIndexChanged

        Try
            Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try

        Me.gridGroupingControl1.TableOptions.AllowDropDownCell = False
        Me.DropShadow = True
        Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
		Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro
        Me.propertyGrid1.SelectedObject = Me.gridGroupingControl1
        ' NOTE: If you open ProductRatingsDataSet.xsd and right click on the 
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

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '

        Dim commandstring1 As String = "select * from Products"
        Dim commandstring2 As String = "select * from Ratings"
        Dim commandstring3 As String = "select * from RatingDescription"
        Dim commandstring4 As String = "select * from Customers"
        Dim commandstring5 As String = "select * from Suppliers"

        Dim connection As String = "Data Source=" & FindFile("NorthwindIO.sdf")

        Dim da1 As New SqlCeDataAdapter(commandstring1, connection)
        Dim da2 As New SqlCeDataAdapter(commandstring2, connection)
        Dim da3 As New SqlCeDataAdapter(commandstring3, connection)
        Dim da4 As New SqlCeDataAdapter(commandstring4, connection)
        Dim da5 As New SqlCeDataAdapter(commandstring5, connection)

        da5.Fill(productRatingsDataSet2, "Suppliers")
        da1.Fill(productRatingsDataSet2, "Products")
        da3.Fill(productRatingsDataSet2, "RatingDescription")
        da4.Fill(productRatingsDataSet2, "Customers")
        da2.Fill(productRatingsDataSet2, "Ratings")

        Dim shouldGenerateRandomRatings As Boolean = False

        If shouldGenerateRandomRatings Then
            Dim rnd As New Random()
            For n As Integer = 0 To 99
                Dim custIndex As Integer = CInt(Fix(Math.Round(rnd.NextDouble() * (Me.productRatingsDataSet2.Customers.Count - 1), 0)))
                Dim prodIndex As Integer = CInt(Fix(Math.Round(rnd.NextDouble() * (Me.productRatingsDataSet2.Products.Count - 1), 0)))
                Dim rating As Integer = CInt(Fix(Math.Round(rnd.NextDouble() * (Me.productRatingsDataSet2.RatingDescription.Count - 1), 0)))
                Dim row As ProductRatingsDataSet.RatingsRow = Me.productRatingsDataSet2.Ratings.NewRatingsRow()
                row.CustomerID = Me.productRatingsDataSet2.Customers(custIndex).CustomerID
                row.ProductID = Me.productRatingsDataSet2.Products(prodIndex).ProductID
                row.RatingID = rating
                Try
                    Me.productRatingsDataSet2.Ratings.AddRatingsRow(row)
                Catch
                End Try
            Next n


        End If


    End Sub

    Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Select Case comboBoxAdv1.SelectedIndex
            Case 0
                IsGroupedByRatings = False
                Dim mainTd As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
                mainTd.GroupedColumns.Clear()
                mainTd.VisibleColumns.Reset()
            Case 1
                IsGroupedByRatings = False

                Dim mainTd1 As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
                mainTd1.GroupedColumns.Clear()
                mainTd1.GroupedColumns.Add(mainTd1.Columns("Discontinued").MappingName)
                mainTd1.VisibleColumns.Reset()
                mainTd1.VisibleColumns.Remove("Discontinued")
            Case 2
                IsGroupedByRatings = False

                Dim mainTd2 As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
                mainTd2.GroupedColumns.Clear()
                mainTd2.GroupedColumns.Add(mainTd2.Columns("Suppliers_CompanyName").MappingName)
                mainTd2.VisibleColumns.Reset()
                mainTd2.VisibleColumns.Remove("Suppliers_CompanyName")
            Case 3
                IsGroupedByRatings = True

                Dim mainTd3 As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
                mainTd3.GroupedColumns.Clear()
                mainTd3.GroupedColumns.Add(mainTd3.Columns("Ratings").MappingName)
                mainTd3.VisibleColumns.Reset()
                mainTd3.VisibleColumns.Remove("Ratings")
                Me.gridGroupingControl1.Table.ExpandAllGroups()

        End Select
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
        Dim GridColumnDescriptor1 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor2 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor3 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridRelationDescriptor1 As Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor
        Dim GridColumnDescriptor4 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridColumnDescriptor5 As Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor
        Dim GridRelationDescriptor2 As Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor
        Dim GridRelationDescriptor3 As Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor
        Dim GridRelationDescriptor4 As Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor = New Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        Me.productRatingsDataSet2 = New ProductRatings.ProductRatingsDataSet
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productRatingsDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridGroupingControl1
        '
        Me.gridGroupingControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.DataSource = Me.productRatingsDataSet2.Products
        Me.gridGroupingControl1.Location = New System.Drawing.Point(16, 16)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.Size = New System.Drawing.Size(547, 298)
        Me.gridGroupingControl1.TabIndex = 0
        GridColumnDescriptor1.Appearance.AnyRecordFieldCell.CellType = "TextBox"
        GridColumnDescriptor1.Appearance.AnyRecordFieldCell.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
        GridColumnDescriptor1.MappingName = "Discontinued"
        GridColumnDescriptor2.AllowDropDownCell = True
        GridColumnDescriptor2.MappingName = "Ratings_RatingDescription_Description"
        GridColumnDescriptor2.Name = "Ratings"
        GridColumnDescriptor2.Width = 176
        GridColumnDescriptor3.HeaderText = "Supplier"
        GridColumnDescriptor3.MappingName = "Suppliers_CompanyName"
        Me.gridGroupingControl1.TableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("CategoryID"), GridColumnDescriptor1, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ProductName"), GridColumnDescriptor2, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("ReorderLevel"), GridColumnDescriptor3, New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("UnitPrice"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("UnitsInStock"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("UnitsOnOrder")})
        GridColumnDescriptor4.HeaderText = "Customer"
        GridColumnDescriptor4.MappingName = "Customers_CompanyName"
        GridColumnDescriptor5.HeaderText = "Rating"
        GridColumnDescriptor5.MappingName = "RatingDescription_Description"
        GridRelationDescriptor1.ChildTableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {GridColumnDescriptor4, GridColumnDescriptor5})
        GridRelationDescriptor2.MappingName = "RatingDescriptionRatings"
        GridRelationDescriptor3.ChildTableDescriptor.Columns.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor() {New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("CustomerID"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("City"), New Syncfusion.Windows.Forms.Grid.Grouping.GridColumnDescriptor("CompanyName")})
        GridRelationDescriptor3.MappingName = "CustomersRatings"
        GridRelationDescriptor1.ChildTableDescriptor.Relations.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor() {GridRelationDescriptor2, GridRelationDescriptor3})
        GridRelationDescriptor1.MappingName = "ProductsRatings"
        GridRelationDescriptor1.RelationKind = Syncfusion.Grouping.RelationKind.ForeignKeyKeyWords
        GridRelationDescriptor4.MappingName = "SuppliersProducts"
        Me.gridGroupingControl1.TableDescriptor.Relations.AddRange(New Syncfusion.Windows.Forms.Grid.Grouping.GridRelationDescriptor() {GridRelationDescriptor1, GridRelationDescriptor4})
        Me.gridGroupingControl1.TableDescriptor.SortedColumns.AddRange(New Syncfusion.Grouping.SortColumnDescriptor() {New Syncfusion.Grouping.SortColumnDescriptor("Ratings", System.ComponentModel.ListSortDirection.Ascending)})
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        '
        'productRatingsDataSet2
        '
        Me.productRatingsDataSet2.DataSetName = "ProductRatingsDataSet"
        Me.productRatingsDataSet2.Locale = New System.Globalization.CultureInfo("en-US")
        Me.productRatingsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.comboBoxAdv1)
        Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.Location = New System.Drawing.Point(585, 16)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(188, 68)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Group By"
        '
        'comboBoxAdv1
        '
        Me.comboBoxAdv1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxAdv1.BackColor = System.Drawing.Color.White
        Me.comboBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxAdv1.Items.AddRange(New Object() {"None", "Discontinued", "Supplier", "Ratings"})
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "None"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Discontinued"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Supplier"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Ratings"))
        Me.comboBoxAdv1.Location = New System.Drawing.Point(9, 32)
        Me.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.comboBoxAdv1.Name = "comboBoxAdv1"
        Me.comboBoxAdv1.Size = New System.Drawing.Size(166, 21)
        Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.comboBoxAdv1.TabIndex = 3
        '
        'propertyGrid1
        '
        Me.propertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyGrid1.BackColor = System.Drawing.Color.White
        Me.propertyGrid1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.propertyGrid1.HelpBackColor = System.Drawing.Color.White
        Me.propertyGrid1.Location = New System.Drawing.Point(585, 99)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(188, 215)
        Me.propertyGrid1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(787, 336)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Ratings Demo"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productRatingsDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region


    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub

    'INSTANT VB NOTE: The variable isGroupedByRatings was renamed since Visual Basic does not allow class members with the same name:
    Private isGroupedByRatings_Renamed As Boolean
    Private copyOfProducsRatings As GridRelationDescriptor

    Public Property IsGroupedByRatings() As Boolean
        Get
            Return isGroupedByRatings_Renamed
        End Get
        Set(ByVal value As Boolean)
            If isGroupedByRatings_Renamed <> value Then
                isGroupedByRatings_Renamed = value
                If Not isGroupedByRatings_Renamed Then
                    ' Apply original schema
                    SetupProducts()
                Else
                    SetupGroupByRatings()
                End If
            End If
        End Set
    End Property

    Private Sub SetupProducts()
        ' 
        ' In this method we swap the Products and Ratings table. We reverse
        ' the changes made by SetupGroupByRatings.
        '
        Me.gridGroupingControl1.Table.CurrentElement = Nothing

        Dim mainTd As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
        mainTd.GroupedColumns.Clear()

        ' Was never switched before to Ratings - return.
        If Me.copyOfProducsRatings Is Nothing Then
            Return
        End If

        ' Save Suppliers and RatingDescription so that they can be reapplied.
        Dim suppliersRd As New GridRelationDescriptor()
        suppliersRd.InitializeFrom(mainTd.Relations("Products").ChildTableDescriptor.Relations("Suppliers"))

        '
        ' Change MappingNames for Columns. The name of the column stays the same.
        '
        For Each cd As GridColumnDescriptor In mainTd.Columns
            If cd.MappingName.StartsWith("Products_") Then
                cd.MappingName = cd.MappingName.Substring("Products_".Length)
            Else
                cd.MappingName = "Ratings_" & cd.MappingName
            End If
        Next cd

        mainTd.Relations.Clear()
        mainTd.Relations.Add(copyOfProducsRatings)
        mainTd.Relations.Add(suppliersRd)

        Me.gridGroupingControl1.DataSource = Me.productRatingsDataSet2.Ratings

        mainTd.Name = "Products View"

        ' Change the main table.
        Me.gridGroupingControl1.DataSource = Me.productRatingsDataSet2.Products
    End Sub

    Private Sub SetupGroupByRatings()
        ' 
        ' In this method we swap the Products and Ratings table. At startup the
        ' DataSource is set to the Products table which has a parent child relation 
        ' with Ratings.
        '
        ' In this method we assign the Ratings table as main DataSource and add
        ' a ForeignKey relation to the products table. This allows products that
        ' have multiple ratings to appear more than once.
        '
        ' The foreign key relation from Products to Suppliers will be saved
        ' and reapplied in this method.
        '

        Dim mainTd As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor

        Me.gridGroupingControl1.Table.CurrentElement = Nothing

        ' Reset all Grouping
        mainTd.GroupedColumns.Clear()
        mainTd.VisibleColumns.Reset()

        ' Save the relations we previously defined for Ratings
        copyOfProducsRatings = New GridRelationDescriptor()
        copyOfProducsRatings.InitializeFrom(mainTd.Relations("Ratings"))

        ' Save also Suppliers and RatingDescription so that they can be reapplied.
        Dim suppliersRd As New GridRelationDescriptor()
        suppliersRd.InitializeFrom(mainTd.Relations("Suppliers"))

        Dim ratingsDescriptionRd As New GridRelationDescriptor()
        ratingsDescriptionRd.InitializeFrom(copyOfProducsRatings.ChildTableDescriptor.Relations("RatingDescription"))

        '
        ' Change MappingNames for Columns. The name of the column stays the same.
        '
        For Each cd As GridColumnDescriptor In mainTd.Columns
            If cd.MappingName.StartsWith("Ratings_") Then
                cd.MappingName = cd.MappingName.Substring("Ratings_".Length)
            Else
                cd.MappingName = "Products_" & cd.MappingName
            End If
        Next cd

        '
        ' Set up foreign key relation from Ratings to Products
        ' so that each Product can now appear multiple times, once for each Rating it has.
        '
        Dim productsRd As New GridRelationDescriptor()
        productsRd.RelationKind = RelationKind.ForeignKeyReference
        productsRd.ChildTableName = "Products"
        productsRd.RelationKeys.Add("ProductID", "ProductID")
        productsRd.ChildTableDescriptor.Relations.Clear()

        '
        ' Main DataSource is now "Ratings" table. Add foreign key relations to products and 
        ' restore the Suppliers and RatingDescription relation.
        '
        mainTd.Relations.Clear()
        mainTd.Relations.Add(productsRd)
        mainTd.Relations.Add(ratingsDescriptionRd)
        productsRd.ChildTableDescriptor.Relations.Add(suppliersRd)

        mainTd.Name = "Group by Ratings"

        Me.gridGroupingControl1.DataSource = Me.productRatingsDataSet2.Ratings
    End Sub

    Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim abtForm As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
        abtForm.ShowDialog()
    End Sub

End Class

