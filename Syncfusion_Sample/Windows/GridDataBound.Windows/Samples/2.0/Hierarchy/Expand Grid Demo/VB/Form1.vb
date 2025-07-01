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
Imports System.Diagnostics
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Xml

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid


' TODO: SHould also handle double click on resize line (covered cells behavior)
' TODO: ScrollTipFeedback
'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
   Inherits System.Windows.Forms.Form
   Private WithEvents gridRecordNavigationControl1 As Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
   Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Private WithEvents expandAllbutton As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents collapseAllButton As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents okButton As Syncfusion.Windows.Forms.ButtonAdv
    Private panel1 As System.Windows.Forms.Panel
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
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
            Me.Icon = ico

        Catch ex As Exception

        End Try
      'Listen to the IBindingList.ListChanged events instead of the 
      'CurrencyManager events.
      Me.gridDataBoundGrid1.UseListChangedEvent = True
        Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.StartPosition = FormStartPosition.CenterScreen
   End Sub 'New
    
   '
   ' TODO: Add any constructor code after InitializeComponent call
   '
   
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


    '
    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.gridRecordNavigationControl1 = New Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
        Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.expandAllbutton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.collapseAllButton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.okButton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.panel1 = New System.Windows.Forms.Panel
        Me.gridRecordNavigationControl1.SuspendLayout()
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridRecordNavigationControl1
        '
        Me.gridRecordNavigationControl1.AllowAddNew = False
        Me.gridRecordNavigationControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridRecordNavigationControl1.Controls.Add(Me.gridDataBoundGrid1)
        Me.gridRecordNavigationControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gridRecordNavigationControl1.Location = New System.Drawing.Point(24, 24)
        Me.gridRecordNavigationControl1.MaxRecord = 0
        Me.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1"
        Me.gridRecordNavigationControl1.ShowToolTips = True
        Me.gridRecordNavigationControl1.Size = New System.Drawing.Size(624, 272)
        Me.gridRecordNavigationControl1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.gridRecordNavigationControl1.TabIndex = 0
        Me.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1"
        Me.gridRecordNavigationControl1.ThemesEnabled = True
        '
        'gridDataBoundGrid1
        '
        Me.gridDataBoundGrid1.AllowDragSelectedCols = True
        Me.gridDataBoundGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDataBoundGrid1.DefaultColWidth = 70
        Me.gridDataBoundGrid1.DefaultRowHeight = 18
        Me.gridDataBoundGrid1.FillSplitterPane = True
        Me.gridDataBoundGrid1.HorizontalThumbTrack = True
        Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
        Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.gridDataBoundGrid1.Size = New System.Drawing.Size(603, 251)
        Me.gridDataBoundGrid1.SmartSizeBox = False
        Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ThemesEnabled = True
        Me.gridDataBoundGrid1.VerticalThumbTrack = True
        '
        'expandAllbutton
        '
        Me.expandAllbutton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.expandAllbutton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.expandAllbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expandAllbutton.Location = New System.Drawing.Point(24, 306)
        Me.expandAllbutton.Name = "expandAllbutton"
        Me.expandAllbutton.Size = New System.Drawing.Size(104, 24)
        Me.expandAllbutton.TabIndex = 1
        Me.expandAllbutton.Text = "Expand All"
        Me.expandAllbutton.UseVisualStyle = True
        '
        'collapseAllButton
        '
        Me.collapseAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.collapseAllButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.collapseAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collapseAllButton.Location = New System.Drawing.Point(133, 306)
        Me.collapseAllButton.Name = "collapseAllButton"
        Me.collapseAllButton.Size = New System.Drawing.Size(96, 24)
        Me.collapseAllButton.TabIndex = 1
        Me.collapseAllButton.Text = "Collapse All"
        Me.collapseAllButton.UseVisualStyle = True
        '
        'okButton
        '
        Me.okButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton.Location = New System.Drawing.Point(562, 306)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(88, 24)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyle = True
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.okButton)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(672, 342)
        Me.panel1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(672, 342)
        Me.Controls.Add(Me.expandAllbutton)
        Me.Controls.Add(Me.gridRecordNavigationControl1)
        Me.Controls.Add(Me.collapseAllButton)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expand Grid Demo"
        Me.gridRecordNavigationControl1.ResumeLayout(False)
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    '
    Private checkBoxValues As New Hashtable()
    Private unboundValues As New Hashtable()
    Private gridModel As gridModel = Nothing
    Private gridBinder As GridModelDataBinder = Nothing


    Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
        Dim n As Integer
        For n = 0 To 10
            If File.Exists(xmlFileName) Then
                ds.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" & xmlFileName
        Next n '
    End Sub 'ReadXml


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' cache grid model and binder
        Me.gridModel = Me.gridDataBoundGrid1.Model
        Me.gridBinder = Me.gridDataBoundGrid1.Binder

        ' Reduce flicker
        Me.gridDataBoundGrid1.BeginUpdate()


        gridModel.Options.AllowSelection = GridSelectionFlags.AlphaBlend Or GridSelectionFlags.Row Or GridSelectionFlags.Column Or GridSelectionFlags.Keyboard Or GridSelectionFlags.Shift
        gridModel.Options.AllowDragSelectedCols = False
        AddHandler Me.gridDataBoundGrid1.PrepareViewStyleInfo, AddressOf gridDataBoundGrid1_PrepareViewStyleInfo
        Dim standard As GridStyleInfo = gridModel.BaseStylesMap("Standard").StyleInfo
        standard.ShowButtons = GridShowButtons.ShowCurrentRow

        Dim progressDialog As New DelayedStatusDialog(gridModel)
        gridModel.OperationFeedbackListener = progressDialog

        'Dim ds As New DataSet()

        '' we'll read the data from a local XML file
        '' set loadfromSqlServer if you want to access your SQLserver

        'Dim commandstring1 As String = "select * from Categories"
        'Dim commandstring2 As String = "select * from Products"
        'Dim commandstring3 As String = "select * from [Order Details]"
        'Dim commandstring4 As String = "select * from Suppliers"

        'Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(commandstring1, Syncfusion.SampleSQLDBSettings.SampleDatabases.NorthwindImage)
        'Dim da2 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(commandstring2, Syncfusion.SampleSQLDBSettings.SampleDatabases.NorthwindImage)
        'Dim da3 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(commandstring3, Syncfusion.SampleSQLDBSettings.SampleDatabases.NorthwindImage)
        'Dim da4 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(commandstring4, Syncfusion.SampleSQLDBSettings.SampleDatabases.NorthwindImage)
        'Try
        '    da1.Fill(ds, "Categories")
        '    da2.Fill(ds, "Products")
        '    da3.Fill(ds, "Order Details")
        '    da4.Fill(ds, "Suppliers")
        'Catch ex As SqlClient.SqlException
        '    ShowErrorMessage(ex)
        'End Try
        Dim ds As DataSet = New DataSet()

        ' we'll read the data from a local XML file
        ' set loadfromSqlServer if you want to access your SQLserver
        Dim loadfromSqlServer As Boolean = True
        If loadfromSqlServer Then
            Dim commandstring1 As String = "select * from Categories"
            Dim commandstring2 As String = "select * from Products"
            Dim commandstring3 As String = "select * from [Order Details]"
            Dim commandstring4 As String = "select * from Suppliers"
            Dim connectionstring As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
            Dim da1 As SqlServerCe.SqlCeDataAdapter = New SqlServerCe.SqlCeDataAdapter(commandstring1, connectionstring)
            Dim da2 As SqlServerCe.SqlCeDataAdapter = New SqlServerCe.SqlCeDataAdapter(commandstring2, connectionstring)
            Dim da3 As SqlServerCe.SqlCeDataAdapter = New SqlServerCe.SqlCeDataAdapter(commandstring3, connectionstring)
            Dim da4 As SqlServerCe.SqlCeDataAdapter = New SqlServerCe.SqlCeDataAdapter(commandstring4, connectionstring)

            Try
                da1.Fill(ds, "Categories")
                da2.Fill(ds, "Products")
                da3.Fill(ds, "Order Details")
                da4.Fill(ds, "Suppliers")
            Catch ex As SqlServerCe.SqlCeException
                MessageBox.Show(ex.Message)
            End Try

        Else
            ReadXml(ds, "Common\Data\Expand.xml")
        End If

        ds.Relations.Add(ds.Tables(0).Columns("CategoryID"), ds.Tables(1).Columns("CategoryID"))
        ds.Relations(0).RelationName = "Category_Products"

        ds.Relations.Add(ds.Tables(1).Columns("ProductID"), ds.Tables(2).Columns("ProductID"))
        ds.Relations(1).RelationName = "Products_OrderDetails"

        Me.gridDataBoundGrid1.DataMember = "Categories"
        Me.gridDataBoundGrid1.DataSource = ds

        Dim hlCategory_Products As GridHierarchyLevel = gridBinder.AddRelation("Category_Products")
        Dim hlProducts_OrderDetails As GridHierarchyLevel = gridBinder.AddRelation("Products_OrderDetails")
        ' "-" indicates a covered cell
        ' "." indicates a new row 
        Dim hlCategories As GridHierarchyLevel = gridBinder.RootHierarchyLevel
        hlCategories.LayoutColumns(New String() {"CategoryID", "CategoryName", "-", "Description", "-", "-", "-", "-"})
        hlCategory_Products.LayoutColumns(New String() {"", "ProductID", "ProductName", "-", "-", "SupplierID", "-", "-", ".", "", "QuantityPerUnit", "UnitPrice", "UnitsInStock", "UnitsOnOrder", "ReorderLevel", "Discontinued"})
        '"CategoryID", 
        ' show subsequent fields in a 2nd row  
        hlProducts_OrderDetails.LayoutColumns(New String() {"", "-", "OrderID", "UnitPrice", "Quantity", "Discount"})
        '"ProductID", 

        Dim supplierIDStyle As GridStyleInfo = hlCategory_Products.InternalColumns("SupplierID").StyleInfo
        supplierIDStyle.CellType = "GridListControl"
        supplierIDStyle.DataSource = ds.Tables("Suppliers")
        supplierIDStyle.DisplayMember = "CompanyName"
        supplierIDStyle.ValueMember = "SupplierID"
        supplierIDStyle.HorizontalAlignment = GridHorizontalAlignment.Left

        Dim discontinuedStyle As GridStyleInfo = hlCategory_Products.InternalColumns("Discontinued").StyleInfo
        discontinuedStyle.CellType = "CheckBox"
        discontinuedStyle.HorizontalAlignment = GridHorizontalAlignment.Center

        hlCategories.RowStyle.BackColor = Color.FromArgb(248, 251, 255)

        hlCategory_Products.RowStyle.BackColor = Color.FromArgb(250, 240, 230)

        hlProducts_OrderDetails.RowStyle.BackColor = Color.FromArgb(102, 110, 152)

        Me.gridDataBoundGrid1.HighlightCurrentColumnHeader = True

        ' Copy over bound columns and add one unbound extra column at the end
        Dim columns As GridBoundColumnsCollection = CType(Me.gridBinder.InternalColumns.Clone(), GridBoundColumnsCollection)
        Me.gridBinder.GridBoundColumns = columns

        ' Enable SelectAll mode for current cell (looks better)
        gridModel.Options.ShowCurrentCellBorderBehavior = GridShowCurrentCellBorder.WhenGridActive
        gridModel.Options.ActivateCurrentCellBehavior = GridCellActivateAction.SelectAll

        ' Move current cell to top-left corner.
        Me.gridDataBoundGrid1.CurrentCell.MoveTo(gridModel.Rows.HeaderCount + 1, gridModel.Cols.HeaderCount + 1)

        ' Increase with of navigation record so that " of ###" can be shown
        Me.gridRecordNavigationControl1.NavigationBarWidth += 20
        Me.gridRecordNavigationControl1.Font = Me.gridDataBoundGrid1.Font
        Me.gridRecordNavigationControl1.BackColor = Color.FromArgb(192, 201, 219)
        Me.gridRecordNavigationControl1.NavigationBarBackColor = Color.FromArgb(237, 240, 246)

        ' Resize rows option
        gridModel.Options.ResizeRowsBehavior = GridResizeCellsBehavior.ResizeSingle Or GridResizeCellsBehavior.OutlineBounds Or GridResizeCellsBehavior.OutlineHeaders
        gridModel.Options.ResizeColsBehavior = GridResizeCellsBehavior.ResizeSingle Or GridResizeCellsBehavior.AllowDragOutside Or GridResizeCellsBehavior.OutlineBounds Or GridResizeCellsBehavior.OutlineHeaders

        ' Set fond bold for standard column headers
        Dim gsiHeader As GridStyleInfo = gridModel.BaseStylesMap("Header").StyleInfo
        gsiHeader.Font.Bold = True
        gsiHeader.Enabled = True

        Me.gridDataBoundGrid1.VerticalThumbTrack = True

        Dim lastRow As Integer = Me.gridDataBoundGrid1.ViewLayout.LastVisibleRow

        'gridModel.ResetVolatileData();
        gridModel.ColWidths.ResizeToFit(GridRangeInfo.Cells(2, 0, gridModel.ColCount, lastRow), GridResizeToFitOptions.IncludeHeaders Or GridResizeToFitOptions.NoShrinkSize Or GridResizeToFitOptions.ResizeCoveredCells)
        Me.gridDataBoundGrid1.AllowResizeToFit = False
        Me.gridDataBoundGrid1.DefaultRowHeight = 18
        Me.gridDataBoundGrid1.DefaultColWidth = 70

        ' Grid will repaint ittself later.
        Me.gridDataBoundGrid1.EndUpdate()

        ' Wire events
        AddHandler Me.gridDataBoundGrid1.ScrollInfoChanged, AddressOf Me.gridDataBoundGrid1_ScrollInfoChanged
    End Sub 'Form1_Load
	
	Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

    Friend Shared Function FindFile(ByVal fileName As String) As String
        ' Check both in parent folder and Parent\Data folders.
        Dim dataFileName As String = "Common\Data\" & fileName
        For n As Integer = 0 To 11
            If System.IO.File.Exists(fileName) Then
                Return New FileInfo(fileName).FullName
            End If
            If System.IO.File.Exists(dataFileName) Then
                Return New FileInfo(dataFileName).FullName
            End If
            fileName = "..\" & fileName
            dataFileName = "..\" & dataFileName
        Next n

        Return fileName
    End Function
	
    Private Shared Sub ShowErrorMessage(ByVal ex As SqlException)
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

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    End Sub 'Form1_Closing

    ' You should call Update if you want changes made in the DataGrid be committed
    ' to the datasource. 
    ' Just uncomment the line below.
    ' this.sqlDataAdapter1.Update(this.dataSet11);

    Private Sub gridDataBoundGrid1_ScrollInfoChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim grid As GridDataBoundGrid = sender '
        Dim recordCount As Integer = grid.Binder.RecordCount
        If recordCount > 0 Then
            Me.gridRecordNavigationControl1.MaxLabel = " of " + Str$(recordCount)
        Else
            Me.gridRecordNavigationControl1.MaxLabel = ""
        End If
        Syncfusion.Diagnostics.TraceUtil.TraceCurrentMethodInfo(Me.gridRecordNavigationControl1.MaxLabel)
    End Sub 'gridDataBoundGrid1_ScrollInfoChanged


    Private Sub gridRecordNavigationControl1_PaneCreated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs) Handles gridRecordNavigationControl1.PaneCreated
        Dim grid As GridDataBoundGrid = e.Control '
        AddHandler grid.ScrollInfoChanged, AddressOf Me.gridDataBoundGrid1_ScrollInfoChanged
        AddHandler grid.PrepareViewStyleInfo, AddressOf gridDataBoundGrid1_PrepareViewStyleInfo
    End Sub 'gridRecordNavigationControl1_PaneCreated


    Private Sub gridRecordNavigationControl1_PaneClosing(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs) Handles gridRecordNavigationControl1.PaneClosing
        Dim grid As GridDataBoundGrid = e.Control '
        RemoveHandler grid.ScrollInfoChanged, AddressOf Me.gridDataBoundGrid1_ScrollInfoChanged
        RemoveHandler grid.PrepareViewStyleInfo, AddressOf gridDataBoundGrid1_PrepareViewStyleInfo
    End Sub 'gridRecordNavigationControl1_PaneClosing


    Private Sub gridDataBoundGrid1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        Dim grid As GridDataBoundGrid = sender '
        If Not (grid Is Nothing) AndAlso e.ColIndex > 0 Then
            If grid.IsShowCurrentRow(e.RowIndex) AndAlso Not grid.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex) Then
                e.Style.BackColor = SystemColors.Highlight
                e.Style.TextColor = SystemColors.HighlightText
            End If
        End If
    End Sub 'gridDataBoundGrid1_PrepareViewStyleInfo


    Private Sub expandAllbutton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles expandAllbutton.Click
        Me.gridDataBoundGrid1.ExpandAll()
    End Sub 'expandAllbutton_Click


    Private Sub collapseAllButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles collapseAllButton.Click
        Me.gridDataBoundGrid1.CollapseAll()
    End Sub 'collapseAllButton_Click


    Private Sub okButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles okButton.Click
        Close()
    End Sub 'okButton_Click
End Class 'Form1 
