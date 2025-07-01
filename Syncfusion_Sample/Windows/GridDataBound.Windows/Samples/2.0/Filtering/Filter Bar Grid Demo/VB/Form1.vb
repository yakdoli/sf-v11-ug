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

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms


Public Class Form1
   Inherits System.Windows.Forms.Form
   Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
   
   Private theFilterBar As GridFilterBar
   Private ds As DataSet
   Private currentTableName As String
    Private WithEvents button3 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents enableDialogButton As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents NoneCustomButton As Syncfusion.Windows.Forms.ButtonAdv
    Private panel1 As System.Windows.Forms.Panel

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
        Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.StartPosition = FormStartPosition.CenterScreen
      'Listen to the IBindingList.ListChanged events instead of the 
      'CurrencyManager events.
        Me.gridDataBoundGrid1.UseListChangedEvent = True
        Me.gridDataBoundGrid1.ResizeColsBehavior = GridResizeCellsBehavior.None
        Me.gridDataBoundGrid1.ResizeRowsBehavior = GridResizeCellsBehavior.None
        Me.gridDataBoundGrid1.AllowSelection = GridSelectionFlags.Cell
   End Sub 'New
    
   
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose


#Region "Windows Form Designer generated code"


    Private Sub InitializeComponent()
        Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.label1 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.enableDialogButton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.NoneCustomButton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.panel1 = New System.Windows.Forms.Panel
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridDataBoundGrid1
        '
        Me.gridDataBoundGrid1.AllowDragSelectedCols = True
        Me.gridDataBoundGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDataBoundGrid1.HorizontalThumbTrack = True
        Me.gridDataBoundGrid1.Location = New System.Drawing.Point(45, 54)
        Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.gridDataBoundGrid1.Size = New System.Drawing.Size(555, 313)
        Me.gridDataBoundGrid1.SmartSizeBox = False
        Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid1.TabIndex = 0
        Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ThemesEnabled = True
        Me.gridDataBoundGrid1.VerticalThumbTrack = True
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(624, 53)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(112, 27)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Add Filter Bar"
        Me.button1.UseVisualStyle = True
        Me.button1.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(623, 85)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(112, 27)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Remove Filter Bar"
        Me.button2.UseVisualStyle = True
        Me.button2.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(45, 381)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(128, 15)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Current Row Filter:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label2
        '
        Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.label2.Location = New System.Drawing.Point(190, 380)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(408, 16)
        Me.label2.TabIndex = 4
        Me.label2.Text = "(none)"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'comboBox1
        '
        Me.comboBox1.Items.AddRange(New Object() {"Customers", "Employees", "Orders", "Products"})
        Me.comboBox1.Location = New System.Drawing.Point(46, 19)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(232, 21)
        Me.comboBox1.TabIndex = 5
        Me.comboBox1.Text = "Customers"
        '
        'button3
        '
        Me.button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(624, 343)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(112, 24)
        Me.button3.TabIndex = 6
        Me.button3.Text = "Reset Grid"
        Me.button3.UseVisualStyle = True
        Me.button3.UseVisualStyleBackColor = True
        '
        'enableDialogButton
        '
        Me.enableDialogButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.enableDialogButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.enableDialogButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.enableDialogButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enableDialogButton.Location = New System.Drawing.Point(624, 172)
        Me.enableDialogButton.Name = "enableDialogButton"
        Me.enableDialogButton.Size = New System.Drawing.Size(112, 36)
        Me.enableDialogButton.TabIndex = 7
        Me.enableDialogButton.Text = "     Enable        Custom Dialog"
        Me.enableDialogButton.UseVisualStyle = True
        Me.enableDialogButton.UseVisualStyleBackColor = True
        '
        'NoneCustomButton
        '
        Me.NoneCustomButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoneCustomButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.NoneCustomButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.NoneCustomButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoneCustomButton.Location = New System.Drawing.Point(623, 213)
        Me.NoneCustomButton.Name = "NoneCustomButton"
        Me.NoneCustomButton.Size = New System.Drawing.Size(112, 37)
        Me.NoneCustomButton.TabIndex = 8
        Me.NoneCustomButton.Text = "      German         [none]  [custom]"
        Me.NoneCustomButton.UseVisualStyle = True
        Me.NoneCustomButton.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.NoneCustomButton)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(752, 414)
        Me.panel1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(752, 414)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.gridDataBoundGrid1)
        Me.Controls.Add(Me.enableDialogButton)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filter Bar Grid Demo"
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region
#Region "Initial Setup"


    Sub ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String)
        Dim n As Integer
        For n = 0 To 10
            If System.IO.File.Exists(xmlFileName) Then
                ds.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" + xmlFileName
        Next n
    End Sub 'ReadXml


    <STAThread()> _
Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Ma


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds = New DataSet()
        ReadXml(ds, "Common\Data\GDBDdata.XML")
        Me.gridDataBoundGrid1.DefaultRowHeight = 18
        Me.gridDataBoundGrid1.DefaultColWidth = 70
        AddHandler gridDataBoundGrid1.PrepareViewStyleInfo, AddressOf Me.gridDataBoundGrid1_PrepareViewStyleInfo
        AddHandler gridDataBoundGrid1.CellDoubleClick, AddressOf gridDataBoundGrid1_CellDoubleClick

        SetTableIntoGridAndWireFilterBar("customers")
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


    Private Sub SetTableIntoGridAndWireFilterBar(ByVal tableName As String)
        Me.Cursor = Cursors.WaitCursor

        Me.gridDataBoundGrid1.GridBoundColumns.Clear()
        Me.gridDataBoundGrid1.Selections.Clear()

        Me.gridDataBoundGrid1.BeginUpdate()

        If Not (Me.theFilterBar Is Nothing) AndAlso theFilterBar.Wired Then
            'reset the old table
            theFilterBar.RowFilter = ""

            theFilterBar.UnwireGrid()
        End If

        currentTableName = tableName

        Me.gridDataBoundGrid1.DataSource = ds.Tables(tableName)

        Me.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Row(0), GridResizeToFitOptions.NoShrinkSize)

        'create the filter bar and display it
        theFilterBar = New GridFilterBar()

        'catch the creating column header event so we can turn off unwanted filter headers
        'needs to be hooked before WireGrid call to catch things...
        AddHandler theFilterBar.CreatingColumnHeader, AddressOf GridFilterBarCreatingColumnHeader

        theFilterBar.WireGrid(Me.gridDataBoundGrid1)

        'catch the rowfilter changed event so we can display the filter text
        AddHandler theFilterBar.FilterBarTextChanged, AddressOf GridFilterBarTextChanged

        'apply any special formatting...
        FormatGridForTable(tableName)


        Me.gridDataBoundGrid1.EndUpdate()

        Me.Cursor = Cursors.Arrow
        AddHandler gridDataBoundGrid1.CurrentCellShowingDropDown, AddressOf gridDataBoundGrid1_CurrentCellShowingDropDown
    End Sub 'SetTableIntoGridAndWireFilterBar
    Private Sub gridDataBoundGrid1_CurrentCellShowingDropDown(ByVal sender As Object, ByVal e As GridCurrentCellShowingDropDownEventArgs)
        If Me.gridDataBoundGrid1.CurrentCell.ColIndex = 1 AndAlso Me.comboBox1.Text = "Employees" Then
            e.Cancel = True
        End If
        If (Me.gridDataBoundGrid1.CurrentCell.ColIndex = 1 OrElse Me.gridDataBoundGrid1.CurrentCell.ColIndex = 2 OrElse Me.gridDataBoundGrid1.CurrentCell.ColIndex = 3) AndAlso Me.comboBox1.Text = "Products" Then
            e.Cancel = True
        End If
    End Sub


    Private Sub FormatGridForTable(ByVal tableName As String)
        Dim gbcc As GridBoundColumnsCollection = Me.gridDataBoundGrid1.Binder.InternalColumns

        If tableName = "Customers" Then
            'none
        ElseIf tableName = "Employees" Then
            gbcc("BirthDate").StyleInfo.Format = "d"
            gbcc("BirthDate").StyleInfo.CellValueType = GetType(DateTime)
            gbcc("HireDate").StyleInfo.Format = "d"
            gbcc("HireDate").StyleInfo.CellValueType = GetType(DateTime)


            'get rid of photo column
            gbcc("Photo").Hidden = True
            gbcc("PhotoPath").Hidden = True
        ElseIf tableName = "Orders" Then
            gbcc("OrderDate").StyleInfo.Format = "d"
            gbcc("OrderDate").StyleInfo.CellValueType = GetType(DateTime)
            gbcc("RequiredDate").StyleInfo.Format = "d"
            gbcc("RequiredDate").StyleInfo.CellValueType = GetType(DateTime)
            gbcc("ShippedDate").StyleInfo.Format = "d"
            gbcc("ShippedDate").StyleInfo.CellValueType = GetType(DateTime)

            gbcc("Freight").StyleInfo.Format = "f2"
            gbcc("Freight").StyleInfo.CellValueType = GetType(Double)
            gbcc("Freight").StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right

            'make EmployeeID display LastName using a hidden foreign key combobox
            Dim dt As DataTable = ds.Tables("Employees")
            gbcc("EmployeeID").StyleInfo.CellType = "ComboBox"
            gbcc("EmployeeID").StyleInfo.DataSource = dt
            gbcc("EmployeeID").StyleInfo.DisplayMember = "LastName"
            gbcc("EmployeeID").StyleInfo.ValueMember = "EmployeeID"
            gbcc("EmployeeID").StyleInfo.ShowButtons = GridShowButtons.Hide

        ElseIf tableName = "Products" Then
            gbcc("UnitPrice").StyleInfo.Format = "f2"
            gbcc("UnitPrice").StyleInfo.CellValueType = GetType(Double)
            gbcc("UnitPrice").StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Right
            gbcc("UnitsInStock").StyleInfo.Format = "f0"
            gbcc("UnitsInStock").StyleInfo.CellValueType = GetType(Double)
            gbcc("UnitsInStock").StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center
            gbcc("UnitsOnOrder").StyleInfo.Format = "f0"
            gbcc("UnitsOnOrder").StyleInfo.CellValueType = GetType(Double)
            gbcc("UnitsOnOrder").StyleInfo.HorizontalAlignment = GridHorizontalAlignment.Center
        End If
    End Sub 'FormatGridForTable


#End Region

#Region "Form Event Handlers"

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        'add filter bar
        If Not (theFilterBar Is Nothing) AndAlso Not theFilterBar.Wired Then
            theFilterBar.WireGrid(Me.gridDataBoundGrid1)
            Me.label2.Text = ""
        End If
        Me.gridDataBoundGrid1.RefreshRange(GridRangeInfo.Row(1))
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        'remove filter bar
        theFilterBar.UnwireGrid()
        Me.gridDataBoundGrid1.RefreshRange(GridRangeInfo.Row(1))
    End Sub 'button2_Click


    Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
        'load a different table...
        If Not (Me.ds Is Nothing) AndAlso Me.comboBox1.Text <> currentTableName Then
            SetTableIntoGridAndWireFilterBar(Me.comboBox1.Text)
        End If
    End Sub 'comboBox1_SelectedIndexChanged


    Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
        'reset the datagrid
        If Not (theFilterBar Is Nothing) Then
            theFilterBar.RowFilter = ""
            Me.label2.Text = ""
        End If
    End Sub 'button3_Click

#End Region

#Region "FilterBar Event Handlers"


    'use this event to control whether or a column has a filter cell at the top
    Private Sub GridFilterBarCreatingColumnHeader(ByVal sender As Object, ByVal e As GridFilterBarCreatingColumnHeaderEventArgs)
        If currentTableName = "Customers" Then
            'just show all columns for this table though not really useful
        ElseIf currentTableName = "Employees" Then
            'don't try filter the primary key colum
            If e.ColName = "EmployeeID" Then
                e.Cancel = True
            End If
        ElseIf currentTableName = "Products" Then
            'don't try filter these columns
            If e.ColName = "ProductID" OrElse e.ColName = "ProductName" OrElse e.ColName = "QuantityPerUnit" Then
                e.Cancel = True
            End If
        ElseIf currentTableName = "Orders" Then
        End If
    End Sub 'GridFilterBarCreatingColumnHeader
    'show all columns

    'this event is fired when the row filter is changed
    Private Sub GridFilterBarTextChanged(ByVal sender As Object, ByVal e As GridFilterBarTextChangedEventArgs)
        Me.label2.Text = theFilterBar.RowFilter
    End Sub 'GridFilterBarTextChanged


    'show my own custom filter dialog
    Private Sub GridFilterBarShowDialogEventHandler(ByVal send As Object, ByVal e As GridFilterBarShowDialogEventArgs)
        Dim dlg As New MyFilterDialog()

        dlg.grid = Me.gridDataBoundGrid1
        dlg.table = Me.ds.Tables(currentTableName)
        Dim result As DialogResult = dlg.ShowDialog()

        If result = Windows.Forms.DialogResult.Ignore Then
            'show the default dialog
            e.Handled = False
        Else
            'otherwise don't show default and set the result
            e.Handled = True
            e.Result = result 'cancel or OK-filter the grid with e.FilterCriteria
            e.FilterCriteria = dlg.textBox1.Text ' the filter string
        End If
    End Sub 'GridFilterBarShowDialogEventHandler
#End Region

    Private useCustomDialog As Boolean = False

    Private Sub enableDialogButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles enableDialogButton.Click
        useCustomDialog = Not useCustomDialog
        If useCustomDialog Then
            'catch the ShowDialog event to display my own custom filter dialog
            AddHandler theFilterBar.FilterBarShowDialog, AddressOf GridFilterBarShowDialogEventHandler
            Me.enableDialogButton.Text = "      Disable        Custom Dialog"
        Else
            RemoveHandler theFilterBar.FilterBarShowDialog, AddressOf GridFilterBarShowDialogEventHandler
            Me.enableDialogButton.Text = "      Enable        Custom Dialog"
        End If
    End Sub 'enableDialogButton_Click


    Private Sub NoneCustomButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NoneCustomButton.Click
        Me.gridDataBoundGrid1.BeginUpdate()
        Me.theFilterBar.UnwireGrid()

        If Me.NoneCustomButton.Text.IndexOf("German") > -1 Then
            theFilterBar.GridFilterBarStrings(0) = "(Keine Auswahl)"
            theFilterBar.GridFilterBarStrings(1) = "(Dialogauswahl)"
            theFilterBar.GridFilterBarStrings(2) = "gleich"
            theFilterBar.GridFilterBarStrings(3) = "nicht gleich"
            theFilterBar.GridFilterBarStrings(4) = "groesser"
            theFilterBar.GridFilterBarStrings(5) = "groesser oder gleich"
            theFilterBar.GridFilterBarStrings(6) = "kleiner"
            theFilterBar.GridFilterBarStrings(7) = "kleiner oder gleich"
            theFilterBar.GridFilterBarStrings(8) = "Textanfang gleich"
            theFilterBar.GridFilterBarStrings(9) = "Textanfang nicht gleich"
            theFilterBar.GridFilterBarStrings(10) = "Textende gleich"
            theFilterBar.GridFilterBarStrings(11) = "Textende nicht gleich"
            theFilterBar.GridFilterBarStrings(12) = "Enthaelt"
            theFilterBar.GridFilterBarStrings(13) = "Enthaelt nicht"
            theFilterBar.GridFilterBarStrings(14) = "Verwende * fuer beliebige Zeichenfolge"
            theFilterBar.GridFilterBarStrings(15) = "Zeige Reihen mit:"
            Me.NoneCustomButton.Text = "   Do not show       [none]  [custom]"
        ElseIf Me.NoneCustomButton.Text.IndexOf("Do not") > -1 Then
            theFilterBar.GridFilterBarStrings(0) = ""
            theFilterBar.GridFilterBarStrings(1) = ""
            theFilterBar.GridFilterBarStrings(2) = "equal"
            theFilterBar.GridFilterBarStrings(3) = "not equal"
            theFilterBar.GridFilterBarStrings(4) = "greater than"
            theFilterBar.GridFilterBarStrings(5) = "greater than or equal"
            theFilterBar.GridFilterBarStrings(6) = "less than"
            theFilterBar.GridFilterBarStrings(7) = "less than or equal"
            theFilterBar.GridFilterBarStrings(8) = "begins with"
            theFilterBar.GridFilterBarStrings(9) = "does not begin with"
            theFilterBar.GridFilterBarStrings(10) = "ends with"
            theFilterBar.GridFilterBarStrings(11) = "does not end with"
            theFilterBar.GridFilterBarStrings(12) = "contains"
            theFilterBar.GridFilterBarStrings(13) = "does not contain"
            theFilterBar.GridFilterBarStrings(14) = "Use * to represent any series of characters"
            theFilterBar.GridFilterBarStrings(15) = "Show rows where:"
            Me.NoneCustomButton.Text = "      Default         [none]  [custom]"
        ElseIf Me.NoneCustomButton.Text.IndexOf("Default") > -1 Then
            theFilterBar.GridFilterBarStrings(0) = "(none)"
            theFilterBar.GridFilterBarStrings(1) = "(custom)"
            Me.NoneCustomButton.Text = "     German     [none]  [custom]"
        End If
        Me.theFilterBar.WireGrid(Me.gridDataBoundGrid1)
        Me.gridDataBoundGrid1.EndUpdate()
    End Sub 'NoneCustomButton_Click

    Private Sub gridDataBoundGrid1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        If e.RowIndex > 0 AndAlso e.ColIndex > 0 Then
            If e.RowIndex = 1 AndAlso Not (Me.theFilterBar Is Nothing) AndAlso theFilterBar.Wired Then
                e.Style.BackColor = Color.White ' Color.FromArgb(218, 229, 245);                                
                e.Style.TextColor = Color.MidnightBlue
            Else
                e.Style.BackColor = Color.FromArgb(242, 248, 255)
            End If
        End If
    End Sub 'gridDataBoundGrid1_PrepareViewStyleInfo
    Private Sub gridDataBoundGrid1_CellDoubleClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
        If Me.comboBox1.SelectedIndex = 1 Then
            If e.RowIndex = 1 AndAlso e.ColIndex = 1 Then
                e.Cancel = True
            End If
        ElseIf Me.comboBox1.SelectedIndex = 3 Then
            If e.RowIndex = 1 AndAlso (e.ColIndex >= 1 AndAlso e.ColIndex <= 3) Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class 'Form1 '