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
Imports Syncfusion.Windows.Forms.Grid


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private WithEvents gridRecordNavigationControl1 As Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
    Private WithEvents gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
    Private WithEvents okButton As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents toggleMultiRowCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents outlineHeaderCheckBox As System.Windows.Forms.CheckBox
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
        
    End Sub 'New

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
        Me.gridRecordNavigationControl1 = New Syncfusion.Windows.Forms.Grid.GridRecordNavigationControl
        Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.okButton = New Syncfusion.Windows.Forms.ButtonAdv
        Me.toggleMultiRowCheckBox = New System.Windows.Forms.CheckBox
        Me.outlineHeaderCheckBox = New System.Windows.Forms.CheckBox
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
        Me.gridRecordNavigationControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridRecordNavigationControl1.Controls.Add(Me.gridDataBoundGrid1)
        Me.gridRecordNavigationControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.gridRecordNavigationControl1.Location = New System.Drawing.Point(48, 39)
        Me.gridRecordNavigationControl1.MaxRecord = 0
        Me.gridRecordNavigationControl1.Name = "gridRecordNavigationControl1"
        Me.gridRecordNavigationControl1.ShowToolTips = True
        Me.gridRecordNavigationControl1.Size = New System.Drawing.Size(712, 312)
        Me.gridRecordNavigationControl1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.gridRecordNavigationControl1.TabIndex = 0
        Me.gridRecordNavigationControl1.Text = "gridRecordNavigationControl1"
        Me.gridRecordNavigationControl1.ThemesEnabled = True
        '
        'gridDataBoundGrid1
        '
        Me.gridDataBoundGrid1.AllowDragSelectedCols = True
        Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDataBoundGrid1.DefaultColWidth = 70
        Me.gridDataBoundGrid1.DefaultRowHeight = 18
        Me.gridDataBoundGrid1.FillSplitterPane = True
        Me.gridDataBoundGrid1.HorizontalThumbTrack = True
        Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
        Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.gridDataBoundGrid1.Size = New System.Drawing.Size(693, 293)
        Me.gridDataBoundGrid1.SmartSizeBox = False
        Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ThemesEnabled = True
        Me.gridDataBoundGrid1.VerticalThumbTrack = True
        '
        'okButton
        '
        Me.okButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.okButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.okButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton.Location = New System.Drawing.Point(665, 368)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(96, 24)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "Reset Binding"
        Me.okButton.UseVisualStyle = True
        '
        'toggleMultiRowCheckBox
        '
        Me.toggleMultiRowCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.toggleMultiRowCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.toggleMultiRowCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toggleMultiRowCheckBox.Location = New System.Drawing.Point(297, 367)
        Me.toggleMultiRowCheckBox.Name = "toggleMultiRowCheckBox"
        Me.toggleMultiRowCheckBox.Size = New System.Drawing.Size(160, 24)
        Me.toggleMultiRowCheckBox.TabIndex = 2
        Me.toggleMultiRowCheckBox.Text = "Multiple rows per record"
        '
        'outlineHeaderCheckBox
        '
        Me.outlineHeaderCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.outlineHeaderCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.outlineHeaderCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outlineHeaderCheckBox.Location = New System.Drawing.Point(481, 367)
        Me.outlineHeaderCheckBox.Name = "outlineHeaderCheckBox"
        Me.outlineHeaderCheckBox.Size = New System.Drawing.Size(152, 24)
        Me.outlineHeaderCheckBox.TabIndex = 2
        Me.outlineHeaderCheckBox.Text = "Outline column header"
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.toggleMultiRowCheckBox)
        Me.panel1.Controls.Add(Me.outlineHeaderCheckBox)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(784, 406)
        Me.panel1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 406)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.gridRecordNavigationControl1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Row Record Demo"
        Me.gridRecordNavigationControl1.ResumeLayout(False)
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Main

    Private dataSet11 As New DataSet("Test")


    Private Sub okButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles okButton.Click
        'Dim testing As Boolean = False
        'If testing Then
            Me.gridDataBoundGrid1.Binder.SuspendBinding()
            Me.dataSet11.Clear()
            ReadXml("Common\Data\GDBDdata.XML")
            Me.gridDataBoundGrid1.Binder.ResumeBinding()
        'End If
    End Sub 'okButton_Click


    Sub ReadXml(ByVal xmlFileName As String)
        Dim n As Integer
        For n = 0 To 10
            If File.Exists(xmlFileName) Then
                Me.dataSet11.ReadXmlSchema(xmlFileName)
                Me.dataSet11.ReadXml(xmlFileName)
                Exit For
            End If
            xmlFileName = "..\" + xmlFileName
        Next n
    End Sub 'ReadXml


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'we'll read the data from a local XML file
        'comment this line if you want to access your SQLserver
        Me.gridDataBoundGrid1.Binder.SuspendBinding()
        ReadXml("Common\Data\GDBDdata.XML")

        Me.gridDataBoundGrid1.DataMember = "Customers"
        Me.gridDataBoundGrid1.DataSource = dataSet11
        Me.gridDataBoundGrid1.Binder.ResumeBinding()
        Me.gridDataBoundGrid1.DefaultRowHeight = 18
        Me.gridDataBoundGrid1.DefaultColWidth = 70
        Me.gridDataBoundGrid1.ResizeColsBehavior = GridResizeCellsBehavior.ResizeAll
        Dim gb As GridBoundColumn
        For Each gb In Me.gridDataBoundGrid1.Binder.InternalColumns
            System.Diagnostics.Trace.WriteLine("""" + gb.MappingName + """")
        Next gb
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


    Private Sub outlineHeaderCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles outlineHeaderCheckBox.CheckedChanged
        Me.gridDataBoundGrid1.HighlightCurrentColumnHeader = Me.outlineHeaderCheckBox.Checked
        Me.gridDataBoundGrid1.Refresh()
    End Sub 'outlineHeaderCheckBox_CheckedChanged


    Private Sub toggleMultiRowCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles toggleMultiRowCheckBox.CheckedChanged
        Me.gridRecordNavigationControl1.HSplitPos = 100
        Me.gridRecordNavigationControl1.VSplitPos = 100

        gridDataBoundGrid1 = Me.gridRecordNavigationControl1.ActivePane
        Dim gridModel As GridModel = gridDataBoundGrid1.Model
        Dim binder As GridModelDataBinder = gridDataBoundGrid1.Binder

        gridModel.BeginUpdate()
        If Not Me.toggleMultiRowCheckBox.Checked Then
            binder.LayoutColumns(New String() {"CustomerID", "CompanyName", "ContactName", "ContactTitle", "Address", "City", "PostalCode", "Country", "Phone", "Fax", "Region"})
            Me.gridDataBoundGrid1.HighlightCurrentColumnHeader = False
            Me.outlineHeaderCheckBox.Checked = False
            Me.gridDataBoundGrid1.AllowSelection = GridSelectionFlags.Any
            Me.gridDataBoundGrid1.SortBehavior = GridSortBehavior.DoubleClick
        Else
            ' "-" indicates a covered cell
            ' "." indicates a new row 
            binder.LayoutColumns(New String() {"CustomerID", "CompanyName", "-", "ContactTitle", "ContactName", "-", ".", "Address", "-", "-", "City", "-", "-", ".", "PostalCode", "Country", "-", "Phone", "Fax", "Region"})
            Me.gridDataBoundGrid1.HighlightCurrentColumnHeader = True
            Me.outlineHeaderCheckBox.Checked = True
            Me.gridDataBoundGrid1.AllowSelection = GridSelectionFlags.None
            Me.gridDataBoundGrid1.SortBehavior = GridSortBehavior.SingleClick
        End If
        gridModel.ColWidths.ResetRange(1, gridModel.ColCount)
        gridModel.ColWidths.ResizeToFit(GridRangeInfo.Rows(0, Me.gridDataBoundGrid1.ViewLayout.LastVisibleRow), GridResizeToFitOptions.IncludeHeaders Or GridResizeToFitOptions.ResizeCoveredCells Or GridResizeToFitOptions.NoShrinkSize)
        gridModel.EndUpdate(False)
        gridModel.Refresh()
        Me.gridDataBoundGrid1.VerticalThumbTrack = True
    End Sub 'toggleMultiRowCheckBox_CheckedChanged


    Private Sub gridDataBoundGrid1_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs) Handles gridDataBoundGrid1.PrepareViewStyleInfo
        Dim grid As GridDataBoundGrid = sender
        If Not (grid Is Nothing) AndAlso e.RowIndex > grid.Model.Rows.HeaderCount AndAlso e.ColIndex > grid.Model.Cols.HeaderCount Then
            If grid.IsShowCurrentRow(e.RowIndex) AndAlso Not grid.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex) Then
                e.Style.BackColor = SystemColors.Highlight
                e.Style.TextColor = SystemColors.HighlightText
            Else
                Dim rs As GridBoundRecordState = grid.Binder.GetRecordStateAtRowIndex(e.RowIndex)
                If rs.Position Mod 2 <> 0 Then
                    e.Style.BackColor = Color.FromArgb(219, 226, 242)
                End If
            End If
        End If
    End Sub 'gridDataBoundGrid1_PrepareViewStyleInfo

    Private Sub gridRecordNavigationControl1_PaneCreated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs) Handles gridRecordNavigationControl1.PaneCreated
        Dim grid As GridDataBoundGrid = e.Control
        AddHandler grid.PrepareViewStyleInfo, AddressOf Me.gridDataBoundGrid1_PrepareViewStyleInfo
    End Sub 'gridRecordNavigationControl1_PaneCreated


    Private Sub gridRecordNavigationControl1_PaneClosing(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs) Handles gridRecordNavigationControl1.PaneClosing
        Dim grid As GridDataBoundGrid = e.Control
        RemoveHandler grid.PrepareViewStyleInfo, AddressOf Me.gridDataBoundGrid1_PrepareViewStyleInfo
    End Sub 'gridRecordNavigationControl1_PaneClosing
End Class 'Form1 
