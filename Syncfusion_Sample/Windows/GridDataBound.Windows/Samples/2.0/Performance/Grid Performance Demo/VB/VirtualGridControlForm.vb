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
Imports System.Diagnostics
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms


Namespace VirtualGridControlPerf
    '/ <summary>
    '/ Summary description for VirtualGridControlForm.
    '/ </summary>
    
    Public Class VirtualGridControlForm
        Inherits System.Windows.Forms.Form
        '/ <summary>
        '/ Required designer variable.
        '/ </summary>
        Private components As System.ComponentModel.Container = Nothing
        Private gridPanel As System.Windows.Forms.Panel
        Private grid As GridControl
        Private WithEvents btnInitGrid As Syncfusion.Windows.Forms.ButtonAdv
        Private table As DataTable

        Private randomKey As Integer = 100
        Private zipCount As Integer = 100
        Private recordCount As Integer = 20000
        Private calculateMaxColumnWidth As Boolean = False
        Private useDataTableList As Boolean = False
        Private useOptimizedListChangedEvent As Boolean = True
        Private optimizeScrolling As Boolean = True
        Private batchSize As Integer = 50
        Private repeatCount As Integer = 300
        Private states() As String = {"North Carolina", "South Carolina", "Washington", "Nevada", "Ohio"}
        Private WithEvents btnResetGrid As Syncfusion.Windows.Forms.ButtonAdv
        Private textBox1 As System.Windows.Forms.TextBox
        Private labelRecordCount As System.Windows.Forms.Label
        Private labelZipCount As System.Windows.Forms.Label
        Private checkBoxCalculateMaximumWidth As System.Windows.Forms.CheckBox
        Private checkBoxUseDataViewSort As System.Windows.Forms.CheckBox
        Private textBoxRecordCount As System.Windows.Forms.TextBox
        Private textBoxZipCount As System.Windows.Forms.TextBox
        Private label1 As System.Windows.Forms.Label
        Private textBoxRepeatCount As System.Windows.Forms.TextBox
        Private WithEvents buttonInsertRecords As Syncfusion.Windows.Forms.ButtonAdv
        Private WithEvents buttonRemoveRecords As Syncfusion.Windows.Forms.ButtonAdv
        Private checkBoxUseOptimizedListChangedEvent As System.Windows.Forms.CheckBox
        Private checkBoxUseScrollWindow As System.Windows.Forms.CheckBox
        Private grpInitializeTable As System.Windows.Forms.GroupBox
        Private grpgroupBox1 As System.Windows.Forms.GroupBox
        Private lbllabel2 As System.Windows.Forms.Label
        Private txtBatchSize As System.Windows.Forms.TextBox
        Private WithEvents buttonChangeRecords As Syncfusion.Windows.Forms.ButtonAdv
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents btnChangeNames As Syncfusion.Windows.Forms.ButtonAdv
        Private hashTable As Hashtable

        
        Public Sub New()
            InitializeComponent()
            Try
                Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
                Me.Icon = ico
            Catch ex As Exception

            End Try
            
            Me.BackColor = Color.FromArgb(223, 227, 239)
            Me.StartPosition = FormStartPosition.CenterParent
            Me.textBoxRepeatCount.Text = repeatCount.ToString()
            Me.textBoxRecordCount.Text = recordCount.ToString()
            Me.textBoxZipCount.Text = zipCount.ToString()
            Me.checkBoxUseDataViewSort.Checked = Me.useDataTableList
            Me.checkBoxCalculateMaximumWidth.Checked = Me.calculateMaxColumnWidth
            checkBoxUseOptimizedListChangedEvent.Checked = Me.useOptimizedListChangedEvent
            Me.txtBatchSize.Text = Me.batchSize.ToString()
            checkBoxUseScrollWindow.Checked = optimizeScrolling
            Me.hashTable = New Hashtable()
            
            InitializeDataTable()
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

        
        
        Private Sub grid_QueryCellInfo(sender As Object, e As GridQueryCellInfoEventArgs)
            If e.ColIndex > 0 AndAlso e.RowIndex > 0 Then
                e.Style.CellValue = Me.table.Rows((e.RowIndex - 1))((e.ColIndex - 1))
                e.Handled = True
            End If
        End Sub 'grid_QueryCellInfo
        
        
        Private Sub grid_QueryColCount(sender As Object, e As GridRowColCountEventArgs)
            e.Count = Me.table.Columns.Count
            e.Handled = True
        End Sub 'grid_QueryColCount
        
        
        Private Sub grid_QueryRowCount(sender As Object, e As GridRowColCountEventArgs)
            e.Count = Me.table.Rows.Count
            e.Handled = True
        End Sub 'grid_QueryRowCount
        Private Sub grid_RowHeightsChanged(sender As Object, e As GridRowColSizeChangedEventArgs)
            grid.BeginUpdate()
            grid.UpdateStyles()
            grid.EndUpdate(True)
        End Sub
        
        
        Private Sub grid_SaveCellInfo(sender As Object, e As GridSaveCellInfoEventArgs)
            If e.ColIndex > 0 AndAlso e.RowIndex > 0 Then
                Me.table.Rows((e.RowIndex - 1))((e.ColIndex - 1)) = e.Style.CellValue
                e.Handled = True
            End If
        End Sub 'grid_SaveCellInfo

        Private Sub grid_QueryColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
            If e.Index > 0 Then
                e.Size = Integer.Parse(hashTable(e.Index).ToString())
                e.Handled = True
            End If
        End Sub 'grid_QueryColWidth

        Private Sub grid_SaveColWidth(ByVal sender As Object, ByVal e As GridRowColSizeEventArgs)
            If e.Index > 0 Then
                hashTable(e.Index) = e.Size
                e.Handled = True
            End If
            grid.Refresh()
        End Sub 'grid_QueryCellInfo
        
        
        Private Sub InitializeDataTable()
            Dim random As New Random(randomKey)
            randomKey += 1
            Dim numStates As Integer = states.GetLength(0)
            Dim nameFormat As String = "Name{0:00000}"

            Me.table = New DataTable("Test")

            Dim col As DataColumn = table.Columns.Add()
            col.DataType = GetType(String)
            col.ColumnName = "Name"

            col = table.Columns.Add()
            col.DataType = GetType(String)
            col.ColumnName = "State"

            col = table.Columns.Add()
            col.DataType = GetType(Integer)
            col.ColumnName = "Zip"

            Dim i As Integer
            For i = 0 To recordCount - 1
                Dim row As DataRow = Me.table.NewRow()
                row("Name") = String.Format(nameFormat, i)
                row("State") = states(random.Next(numStates - 1))
                row("Zip") = random.Next(zipCount)
                Me.table.Rows.Add(row)
            Next i

            Me.table.DefaultView.RowStateFilter = DataViewRowState.CurrentRows
        End Sub 'InitializeDataTable


        Sub ResetGrid()
            If Not (Me.grid Is Nothing) Then
                Me.gridPanel.Controls.Remove(Me.grid)
                AddHandler Me.table.Disposed, AddressOf table_Disposed
                AddHandler Me.table.DefaultView.Disposed, AddressOf table_Disposed
                Me.grid.Dispose()
                Me.grid = Nothing
                Me.LogMemoryUsage()
            End If
        End Sub 'ResetGrid


        Sub LogMemoryUsage()
            If Not (grid Is Nothing) Then
                Me.textBox1.Text += String.Format("Total Row Count {0}" + vbCr + vbLf, Me.table.Rows.Count)
            End If
            ' Force garbage collection and get used memory size
            GC.Collect()
            System.Threading.Thread.Sleep(randomKey)
            randomKey += 1
            Dim myProcess As Process = Process.GetCurrentProcess()
#If SyncfusionFramework2_0 Then
            Dim workingSetSizeinKiloBytes As Double = myProcess.WorkingSet64 / 1000
#Else
            Dim workingSetSizeinKiloBytes As Double = myProcess.WorkingSet / 1000
#End If
            Dim s As String = "Process's physical memory usage: " + workingSetSizeinKiloBytes.ToString() + " kb " + vbCr + vbLf
            Me.textBox1.Text += s
            ScrollTextBox()
        End Sub 'LogMemoryUsage


        Sub ScrollTextBox()
            Me.textBox1.SelectionStart = Me.textBox1.Text.Length
            Me.textBox1.ScrollBars = ScrollBars.Vertical
            Me.textBox1.ScrollToCaret()
            Me.textBox1.Focus()
        End Sub 'ScrollTextBox


        Private Sub InitializeGrid()
            If Not (Me.grid Is Nothing) Then
                RemoveHandler Me.grid.QueryCellInfo, AddressOf grid_QueryCellInfo
                RemoveHandler Me.grid.QueryColCount, AddressOf grid_QueryColCount
                RemoveHandler Me.grid.QueryRowCount, AddressOf grid_QueryRowCount
                RemoveHandler Me.grid.SaveCellInfo, AddressOf grid_SaveCellInfo
                RemoveHandler Me.grid.QueryColWidth, AddressOf grid_QueryColWidth
                RemoveHandler Me.grid.SaveColWidth, AddressOf grid_SaveColWidth
                RemoveHandler Me.grid.RowHeightsChanged, AddressOf grid_RowHeightsChanged
                Me.grid.Dispose()
            End If

            Dim dtStart As DateTime = DateTime.Now

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            ' Fill DataTable
            InitializeDataTable()

            Dim dtFill As DateTime = DateTime.Now

            ' Show an empty grid - triggers JIT compilation when run first time
            Me.grid = New GridControl()

            Me.grid.Dock = DockStyle.Fill
            Me.grid.VerticalThumbTrack = True
            Me.grid.ThemesEnabled = True
            Me.grid.GridVisualStyles = GridVisualStyles.Office2007Blue
            Me.grid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.grid.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
            Dim style As GridStyleInfo = grid.BaseStylesMap("Header").StyleInfo
            style.TextColor = Color.MidnightBlue
            style.Font.Facename = "Verdana"
            grid.Properties.BackgroundColor = SystemColors.Window

            Me.grid.DefaultColWidth = 70
            Me.grid.DefaultRowHeight = 18

			hashTable.Clear()
            For col As Integer = 0 To table.Columns.Count - 1
                hashTable.Add(col + 1, Me.grid.ColWidths(col))
            Next col
            ' DataView has performance issues when inserting new records into a large
            ' dataset. Instead of getting the DataTable.DefaultView, the engine
            ' can wrap the data table with a more efficient DataTableList class. 
            ' This allows instantenoues inserts for DataTable with > 100000 records.
            Dim dtCount As DateTime = DateTime.Now
            Me.grid.BeginUpdate()
            Me.gridPanel.Controls.Add(Me.grid)
            Me.grid.ResetVolatileData()
            Me.grid.Update()


            AddHandler Me.grid.QueryCellInfo, AddressOf grid_QueryCellInfo
            AddHandler Me.grid.QueryColCount, AddressOf grid_QueryColCount
            AddHandler Me.grid.QueryRowCount, AddressOf grid_QueryRowCount
            AddHandler Me.grid.SaveCellInfo, AddressOf grid_SaveCellInfo
            AddHandler Me.grid.QueryColWidth, AddressOf grid_QueryColWidth
            AddHandler Me.grid.SaveColWidth, AddressOf grid_SaveColWidth
            AddHandler Me.grid.RowHeightsChanged, AddressOf grid_RowHeightsChanged
            ' paint the grid.
            'this.gridPanel.Controls.Add(this.grid);
            'this.grid.Update();

            Me.grid.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.grid.Properties.GridLineColor = System.Drawing.Color.Silver

            Me.grid.Refresh()

            System.Windows.Forms.Cursor.Current = Cursors.Default

            Dim dtPaint As DateTime = DateTime.Now

            Dim settings As String = String.Format("DataTableList={0}", useDataTableList)
            Dim time1 As String = String.Format("Fill Datatable: {0}" + vbCr + vbLf, dtFill.Subtract(dtStart))
            Dim time3 As String = String.Format("Set data source and categorize: {0}" + vbCr + vbLf, dtCount.Subtract(dtFill))
            Dim time4 As String = String.Format("Repaint: {0}" + vbCr + vbLf, dtPaint.Subtract(dtCount))
            Dim time6 As String = String.Format("Total time: {0}" + vbCr + vbLf, dtPaint.Subtract(dtStart))

            Me.textBox1.Text += vbCr + vbLf + vbCr + vbLf + settings + time1 + time3 + time4 + time6
            Me.LogMemoryUsage()
        End Sub 'InitializeGrid


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
            Me.gridPanel = New System.Windows.Forms.Panel
            Me.btnInitGrid = New Syncfusion.Windows.Forms.ButtonAdv
            Me.btnResetGrid = New Syncfusion.Windows.Forms.ButtonAdv
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.labelRecordCount = New System.Windows.Forms.Label
            Me.labelZipCount = New System.Windows.Forms.Label
            Me.checkBoxCalculateMaximumWidth = New System.Windows.Forms.CheckBox
            Me.checkBoxUseDataViewSort = New System.Windows.Forms.CheckBox
            Me.textBoxRecordCount = New System.Windows.Forms.TextBox
            Me.textBoxZipCount = New System.Windows.Forms.TextBox
            Me.label1 = New System.Windows.Forms.Label
            Me.textBoxRepeatCount = New System.Windows.Forms.TextBox
            Me.buttonInsertRecords = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonRemoveRecords = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonChangeRecords = New Syncfusion.Windows.Forms.ButtonAdv
            Me.checkBoxUseOptimizedListChangedEvent = New System.Windows.Forms.CheckBox
            Me.checkBoxUseScrollWindow = New System.Windows.Forms.CheckBox
            Me.grpInitializeTable = New System.Windows.Forms.GroupBox
            Me.grpgroupBox1 = New System.Windows.Forms.GroupBox
            Me.btnChangeNames = New Syncfusion.Windows.Forms.ButtonAdv
            Me.txtBatchSize = New System.Windows.Forms.TextBox
            Me.lbllabel2 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.grpInitializeTable.SuspendLayout()
            Me.grpgroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridPanel
            '
            Me.gridPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridPanel.Location = New System.Drawing.Point(16, 16)
            Me.gridPanel.Name = "gridPanel"
            Me.gridPanel.Size = New System.Drawing.Size(544, 352)
            Me.gridPanel.TabIndex = 0
            '
            'btnInitGrid
            '
            Me.btnInitGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnInitGrid.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.btnInitGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnInitGrid.Location = New System.Drawing.Point(27, 214)
            Me.btnInitGrid.Name = "btnInitGrid"
            Me.btnInitGrid.Size = New System.Drawing.Size(72, 24)
            Me.btnInitGrid.TabIndex = 1
            Me.btnInitGrid.TabStop = False
            Me.btnInitGrid.Text = "Load Grid"
            Me.btnInitGrid.UseVisualStyle = True
            '
            'btnResetGrid
            '
            Me.btnResetGrid.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.btnResetGrid.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.btnResetGrid.Location = New System.Drawing.Point(680, 230)
            Me.btnResetGrid.Name = "btnResetGrid"
            Me.btnResetGrid.Size = New System.Drawing.Size(72, 24)
            Me.btnResetGrid.TabIndex = 1
            Me.btnResetGrid.TabStop = False
            Me.btnResetGrid.Text = "Reset Grid"
            Me.btnResetGrid.UseVisualStyle = True
            '
            'textBox1
            '
            Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBox1.Location = New System.Drawing.Point(16, 384)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(544, 160)
            Me.textBox1.TabIndex = 3
            Me.textBox1.TabStop = False
            '
            'labelRecordCount
            '
            Me.labelRecordCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.labelRecordCount.Location = New System.Drawing.Point(593, 54)
            Me.labelRecordCount.Name = "labelRecordCount"
            Me.labelRecordCount.Size = New System.Drawing.Size(72, 23)
            Me.labelRecordCount.TabIndex = 4
            Me.labelRecordCount.Text = "RecordCount"
            Me.labelRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'labelZipCount
            '
            Me.labelZipCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.labelZipCount.Location = New System.Drawing.Point(594, 78)
            Me.labelZipCount.Name = "labelZipCount"
            Me.labelZipCount.Size = New System.Drawing.Size(56, 23)
            Me.labelZipCount.TabIndex = 5
            Me.labelZipCount.Text = "Zip Count"
            Me.labelZipCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'checkBoxCalculateMaximumWidth
            '
            Me.checkBoxCalculateMaximumWidth.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.checkBoxCalculateMaximumWidth.Checked = True
            Me.checkBoxCalculateMaximumWidth.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxCalculateMaximumWidth.Enabled = False
            Me.checkBoxCalculateMaximumWidth.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxCalculateMaximumWidth.Location = New System.Drawing.Point(591, 152)
            Me.checkBoxCalculateMaximumWidth.Name = "checkBoxCalculateMaximumWidth"
            Me.checkBoxCalculateMaximumWidth.Size = New System.Drawing.Size(184, 24)
            Me.checkBoxCalculateMaximumWidth.TabIndex = 3
            Me.checkBoxCalculateMaximumWidth.Text = "Use ResizeToFit on ColWidths"
            '
            'checkBoxUseDataViewSort
            '
            Me.checkBoxUseDataViewSort.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.checkBoxUseDataViewSort.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxUseDataViewSort.Location = New System.Drawing.Point(591, 176)
            Me.checkBoxUseDataViewSort.Name = "checkBoxUseDataViewSort"
            Me.checkBoxUseDataViewSort.Size = New System.Drawing.Size(160, 24)
            Me.checkBoxUseDataViewSort.TabIndex = 4
            Me.checkBoxUseDataViewSort.Text = "Use DataTableList "
            '
            'textBoxRecordCount
            '
            Me.textBoxRecordCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.textBoxRecordCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBoxRecordCount.Location = New System.Drawing.Point(680, 55)
            Me.textBoxRecordCount.Name = "textBoxRecordCount"
            Me.textBoxRecordCount.Size = New System.Drawing.Size(64, 20)
            Me.textBoxRecordCount.TabIndex = 0
            Me.textBoxRecordCount.Text = "50000"
            '
            'textBoxZipCount
            '
            Me.textBoxZipCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.textBoxZipCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBoxZipCount.Location = New System.Drawing.Point(680, 80)
            Me.textBoxZipCount.Name = "textBoxZipCount"
            Me.textBoxZipCount.Size = New System.Drawing.Size(64, 20)
            Me.textBoxZipCount.TabIndex = 1
            Me.textBoxZipCount.Text = "1000"
            '
            'label1
            '
            Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.label1.Location = New System.Drawing.Point(591, 318)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(80, 20)
            Me.label1.TabIndex = 10
            Me.label1.Text = "Repeat Count"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'textBoxRepeatCount
            '
            Me.textBoxRepeatCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.textBoxRepeatCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBoxRepeatCount.Location = New System.Drawing.Point(680, 317)
            Me.textBoxRepeatCount.Name = "textBoxRepeatCount"
            Me.textBoxRepeatCount.Size = New System.Drawing.Size(64, 20)
            Me.textBoxRepeatCount.TabIndex = 6
            Me.textBoxRepeatCount.Text = "100"
            '
            'buttonInsertRecords
            '
            Me.buttonInsertRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonInsertRecords.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonInsertRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonInsertRecords.Location = New System.Drawing.Point(56, 168)
            Me.buttonInsertRecords.Name = "buttonInsertRecords"
            Me.buttonInsertRecords.Size = New System.Drawing.Size(104, 23)
            Me.buttonInsertRecords.TabIndex = 12
            Me.buttonInsertRecords.TabStop = False
            Me.buttonInsertRecords.Text = "Insert Records"
            Me.buttonInsertRecords.UseVisualStyle = True
            '
            'buttonRemoveRecords
            '
            Me.buttonRemoveRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonRemoveRecords.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonRemoveRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonRemoveRecords.Location = New System.Drawing.Point(56, 139)
            Me.buttonRemoveRecords.Name = "buttonRemoveRecords"
            Me.buttonRemoveRecords.Size = New System.Drawing.Size(104, 23)
            Me.buttonRemoveRecords.TabIndex = 12
            Me.buttonRemoveRecords.TabStop = False
            Me.buttonRemoveRecords.Text = "Remove Records"
            Me.buttonRemoveRecords.UseVisualStyle = True
            '
            'buttonChangeRecords
            '
            Me.buttonChangeRecords.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonChangeRecords.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonChangeRecords.Location = New System.Drawing.Point(56, 197)
            Me.buttonChangeRecords.Name = "buttonChangeRecords"
            Me.buttonChangeRecords.Size = New System.Drawing.Size(104, 23)
            Me.buttonChangeRecords.TabIndex = 16
            Me.buttonChangeRecords.TabStop = False
            Me.buttonChangeRecords.Text = "Change Records"
            Me.buttonChangeRecords.UseVisualStyle = True
            '
            'checkBoxUseOptimizedListChangedEvent
            '
            Me.checkBoxUseOptimizedListChangedEvent.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.checkBoxUseOptimizedListChangedEvent.Checked = True
            Me.checkBoxUseOptimizedListChangedEvent.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxUseOptimizedListChangedEvent.Enabled = False
            Me.checkBoxUseOptimizedListChangedEvent.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxUseOptimizedListChangedEvent.Location = New System.Drawing.Point(591, 128)
            Me.checkBoxUseOptimizedListChangedEvent.Name = "checkBoxUseOptimizedListChangedEvent"
            Me.checkBoxUseOptimizedListChangedEvent.Size = New System.Drawing.Size(184, 24)
            Me.checkBoxUseOptimizedListChangedEvent.TabIndex = 2
            Me.checkBoxUseOptimizedListChangedEvent.Text = "Use OptimzedListChangeEvent"
            '
            'checkBoxUseScrollWindow
            '
            Me.checkBoxUseScrollWindow.Enabled = False
            Me.checkBoxUseScrollWindow.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxUseScrollWindow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxUseScrollWindow.Location = New System.Drawing.Point(18, 104)
            Me.checkBoxUseScrollWindow.Name = "checkBoxUseScrollWindow"
            Me.checkBoxUseScrollWindow.Size = New System.Drawing.Size(152, 16)
            Me.checkBoxUseScrollWindow.TabIndex = 8
            Me.checkBoxUseScrollWindow.Text = "Use ScrollWindow"
            '
            'grpInitializeTable
            '
            Me.grpInitializeTable.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.grpInitializeTable.Controls.Add(Me.btnInitGrid)
            Me.grpInitializeTable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpInitializeTable.Location = New System.Drawing.Point(576, 16)
            Me.grpInitializeTable.Name = "grpInitializeTable"
            Me.grpInitializeTable.Size = New System.Drawing.Size(208, 256)
            Me.grpInitializeTable.TabIndex = 14
            Me.grpInitializeTable.TabStop = False
            Me.grpInitializeTable.Text = "Initialize Table"
            '
            'grpgroupBox1
            '
            Me.grpgroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.grpgroupBox1.Controls.Add(Me.btnChangeNames)
            Me.grpgroupBox1.Controls.Add(Me.txtBatchSize)
            Me.grpgroupBox1.Controls.Add(Me.lbllabel2)
            Me.grpgroupBox1.Controls.Add(Me.checkBoxUseScrollWindow)
            Me.grpgroupBox1.Controls.Add(Me.buttonRemoveRecords)
            Me.grpgroupBox1.Controls.Add(Me.buttonChangeRecords)
            Me.grpgroupBox1.Controls.Add(Me.buttonInsertRecords)
            Me.grpgroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpgroupBox1.Location = New System.Drawing.Point(576, 280)
            Me.grpgroupBox1.Name = "grpgroupBox1"
            Me.grpgroupBox1.Size = New System.Drawing.Size(208, 264)
            Me.grpgroupBox1.TabIndex = 15
            Me.grpgroupBox1.TabStop = False
            Me.grpgroupBox1.Text = "Manipulate Grid"
            '
            'btnChangeNames
            '
            Me.btnChangeNames.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.btnChangeNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnChangeNames.Location = New System.Drawing.Point(56, 226)
            Me.btnChangeNames.Name = "btnChangeNames"
            Me.btnChangeNames.Size = New System.Drawing.Size(104, 23)
            Me.btnChangeNames.TabIndex = 17
            Me.btnChangeNames.TabStop = False
            Me.btnChangeNames.Text = "Change Names"
            Me.btnChangeNames.UseVisualStyle = True
            '
            'txtBatchSize
            '
            Me.txtBatchSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtBatchSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBatchSize.Location = New System.Drawing.Point(104, 64)
            Me.txtBatchSize.Name = "txtBatchSize"
            Me.txtBatchSize.Size = New System.Drawing.Size(64, 20)
            Me.txtBatchSize.TabIndex = 7
            Me.txtBatchSize.Text = "1"
            '
            'lbllabel2
            '
            Me.lbllabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbllabel2.Location = New System.Drawing.Point(15, 64)
            Me.lbllabel2.Name = "lbllabel2"
            Me.lbllabel2.Size = New System.Drawing.Size(72, 16)
            Me.lbllabel2.TabIndex = 0
            Me.lbllabel2.Text = "Batch Size"
            Me.lbllabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'panel1
            '
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(792, 566)
            Me.panel1.TabIndex = 16
            '
            'VirtualGridControlForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(792, 566)
            Me.Controls.Add(Me.textBoxRepeatCount)
            Me.Controls.Add(Me.textBoxRecordCount)
            Me.Controls.Add(Me.checkBoxCalculateMaximumWidth)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.textBoxZipCount)
            Me.Controls.Add(Me.checkBoxUseOptimizedListChangedEvent)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.checkBoxUseDataViewSort)
            Me.Controls.Add(Me.labelZipCount)
            Me.Controls.Add(Me.labelRecordCount)
            Me.Controls.Add(Me.gridPanel)
            Me.Controls.Add(Me.btnResetGrid)
            Me.Controls.Add(Me.grpInitializeTable)
            Me.Controls.Add(Me.grpgroupBox1)
            Me.Controls.Add(Me.panel1)
            Me.MinimumSize = New System.Drawing.Size(400, 600)
            Me.Name = "VirtualGridControlForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Virtual Grid Control Performance Demo"
            Me.grpInitializeTable.ResumeLayout(False)
            Me.grpgroupBox1.ResumeLayout(False)
            Me.grpgroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub 'InitializeComponent 
#End Region




        Private Sub btnInitGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInitGrid.Click

            Me.useDataTableList = Me.checkBoxUseDataViewSort.Checked
            Me.calculateMaxColumnWidth = Me.checkBoxCalculateMaximumWidth.Checked
            Me.recordCount = Convert.ToInt32(Me.textBoxRecordCount.Text)
            Me.zipCount = Convert.ToInt32(Me.textBoxZipCount.Text)
            Me.useOptimizedListChangedEvent = checkBoxUseOptimizedListChangedEvent.Checked

            Me.InitializeGrid()
        End Sub 'btnInitGrid_Click


        Private Sub table_Disposed(ByVal sender As Object, ByVal e As EventArgs)
        End Sub 'table_Disposed


        Private Sub btnResetGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnResetGrid.Click
            Me.ResetGrid()
        End Sub 'btnResetGrid_Click


        Private Sub buttonInsertRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonInsertRecords.Click
            If grid Is Nothing Then
                Return
            End If
            repeatCount = Convert.ToInt32(Me.textBoxRepeatCount.Text)
            batchSize = Convert.ToInt32(Me.txtBatchSize.Text)
            optimizeScrolling = checkBoxUseScrollWindow.Checked

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dtStart As DateTime = DateTime.Now

            Dim random As New Random(randomKey)
            randomKey += 1
            Dim numStates As Integer = states.GetLength(0)
            Dim nameFormat As String = "Ins{0:00000}"


            Dim i As Integer
            For i = 0 To repeatCount - 1
                Dim row As DataRow = Me.table.NewRow()
                row("Name") = String.Format(nameFormat, Me.table.Rows.Count)
                row("State") = states(random.Next(numStates - 1))
                row("Zip") = random.Next(zipCount)
                Me.table.Rows.Add(row)

                ' Force immediate update of visible area and scrollbars after each operation
                ' when grouped, record will automatically be inserted in the correct group
                ' and sort order.
                If (i + 1) Mod batchSize = 0 Then
                    grid.Update()
                End If
            Next i 'this.grid.ResetVolatileData();
            'this.grid.Update();
            Me.grid.Refresh()


            Dim dtEnd As DateTime = DateTime.Now

            System.Windows.Forms.Cursor.Current = Cursors.Default

            Dim time1 As String = String.Format("Inserted {0} Records: {1}" + vbCr + vbLf, repeatCount, dtEnd.Subtract(dtStart))
            Me.textBox1.Text += vbCr + vbLf + vbCr + vbLf + time1.ToString
            Me.LogMemoryUsage()
        End Sub 'buttonInsertRecords_Click


        Private Sub buttonRemoveRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonRemoveRecords.Click
            If grid Is Nothing Then
                Return
            End If
            repeatCount = Convert.ToInt32(Me.textBoxRepeatCount.Text)
            batchSize = Convert.ToInt32(Me.txtBatchSize.Text)
            optimizeScrolling = checkBoxUseScrollWindow.Checked

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dtStart As DateTime = DateTime.Now

            Dim random As New Random(randomKey)
            randomKey += 1

            Try
                Dim i As Integer
                For i = 0 To repeatCount - 1
                    Dim record As Integer = random.Next(table.Rows.Count - 1)

                    Me.table.Rows.RemoveAt(record)

                    If (i + 1) Mod batchSize = 0 Then
                        grid.Update()
                    End If
                    If table.Rows.Count = 0 Then
                        Exit For
                    End If
                Next i
                Me.grid.Refresh()

                Dim dtEnd As DateTime = DateTime.Now

                System.Windows.Forms.Cursor.Current = Cursors.Default

                Dim time1 As String = String.Format("Removed {0} Records: {1}" + vbCr + vbLf, repeatCount, dtEnd.Subtract(dtStart))
                Me.textBox1.Text += vbCr + vbLf + vbCr + vbLf + time1.ToString
                Me.LogMemoryUsage()
            Catch ex As Exception
                MessageBox.Show("No Records in the Table")
            End Try
           
        End Sub 'buttonRemoveRecords_Click


        Private Sub btnChangeNames_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangeNames.Click
            If grid Is Nothing Then
                Return
            End If
            repeatCount = Convert.ToInt32(Me.textBoxRepeatCount.Text)
            batchSize = Convert.ToInt32(Me.txtBatchSize.Text)
            optimizeScrolling = checkBoxUseScrollWindow.Checked

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dtStart As DateTime = DateTime.Now

            Dim random As New Random(randomKey)
            randomKey += 1
            Dim nameFormat As String = "Chg{0:00000}"
            Dim numStates As Integer = states.GetLength(0)


            Dim i As Integer
            For i = 0 To repeatCount - 1
                Dim record As Integer = Fix(Math.Min(table.Rows.Count - 1, random.Next(table.Rows.Count)))
                If record >= 0 Then
                    Dim row As DataRow = Me.table.Rows(record)
                    row("Name") = String.Format(nameFormat, i)
                End If

                ' Force immediate update of visible area and scrollbars after each operation
                ' If grid is sorted by name, the record will be removed and reinserted at correct
                ' sort position.
                If (i + 1) Mod batchSize = 0 Then
                    grid.Update()
                End If
            Next i 'this.grid.ResetVolatileData();
            'this.grid.Update();
            Me.grid.Refresh()


            Dim dtEnd As DateTime = DateTime.Now

            System.Windows.Forms.Cursor.Current = Cursors.Default

            Dim time1 As String = String.Format("Changed {0} Records: {1}" + vbCr + vbLf, repeatCount, dtEnd.Subtract(dtStart))
            Me.textBox1.Text += vbCr + vbLf + vbCr + vbLf + time1.ToString
            Me.LogMemoryUsage()
        End Sub 'btnChangeNames_Click


        Private Sub buttonChangeRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonChangeRecords.Click
            If grid Is Nothing Then
                Return
            End If
            repeatCount = Convert.ToInt32(Me.textBoxRepeatCount.Text)
            batchSize = Convert.ToInt32(Me.txtBatchSize.Text)
            optimizeScrolling = checkBoxUseScrollWindow.Checked

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim dtStart As DateTime = DateTime.Now

            Dim random As New Random(randomKey)
            randomKey += 1
            Dim nameFormat As String = "Chg{0:00000}"
            Dim numStates As Integer = states.GetLength(0)


            Dim i As Integer
            For i = 0 To repeatCount - 1
                Dim record As Integer = Fix(Math.Min(table.Rows.Count - 1, random.Next(table.Rows.Count)))
                If record >= 0 Then
                    Dim row As DataRow = Me.table.Rows(record)
                    row.BeginEdit()
                    row("Name") = String.Format(nameFormat, i)
                    row("State") = states(random.Next(numStates - 1))
                    row("Zip") = random.Next(zipCount)
                    row.EndEdit()
                End If

                ' Force immediate update of visible area and scrollbars after each operation
                ' If grid is sorted by name, the record will be removed and reinserted at correct
                ' sort position.
                If (i + 1) Mod batchSize = 0 Then
                    grid.Update()
                End If
            Next i 'this.grid.ResetVolatileData();
            'this.grid.Update();
            Me.grid.Refresh()

            Dim dtEnd As DateTime = DateTime.Now

            System.Windows.Forms.Cursor.Current = Cursors.Default

            Dim time1 As String = String.Format("Changed {0} Records: {1}" + vbCr + vbLf, repeatCount, dtEnd.Subtract(dtStart))
            Me.textBox1.Text += vbCr + vbLf + vbCr + vbLf + time1
            Me.LogMemoryUsage()
        End Sub 'buttonChangeRecords_Click
    End Class 'VirtualGridControlForm 
End Namespace 'VirtualGridControlPerf 


