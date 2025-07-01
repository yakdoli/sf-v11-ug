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

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Diagnostics
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms

Namespace GroupingPerf
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits MetroForm
        Private components As System.ComponentModel.IContainer
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private gridPanel As System.Windows.Forms.Panel
		Private grid As GridGroupingControl
		Private WithEvents btnInitGrid As Syncfusion.Windows.Forms.ButtonAdv
		Private table As DataTable

		Private randomKey As Integer = 100
		Private zipCount As Integer = 100
		Private recordCount As Integer = 20000
		Private calculateMaxColumnWidth As Boolean = True
		Private useGroupingSortList As Boolean = False
		Private sortandCategorize As Boolean = True
		Private optimizeScrolling As Boolean = True
		Private batchSize As Integer = 50
		Private repeatCount As Integer = 300
		Private states() As String = {"North Carolina", "South Carolina", "Washington", "Nevada", "Ohio"}
		Private WithEvents btnResetGrid As Syncfusion.Windows.Forms.ButtonAdv
		Private textBox1 As System.Windows.Forms.TextBox
		Private labelRecordCount As System.Windows.Forms.Label
		Private labelZipCount As System.Windows.Forms.Label
        Private checkBoxCalculateMaximumWidth As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private checkBoxUseDataViewSort As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private checkBoxMultiThreading As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private textBoxRecordCount As Syncfusion.Windows.Forms.Tools.TextBoxExt
        Private textBoxZipCount As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private label1 As System.Windows.Forms.Label
        Private textBoxRepeatCount As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private WithEvents buttonInsertRecords As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonRemoveRecords As Syncfusion.Windows.Forms.ButtonAdv
        Private checkBoxSortandCategorize As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private checkBoxUseScrollWindow As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private grpInitializeTable As System.Windows.Forms.GroupBox
		Private grpgroupBox1 As System.Windows.Forms.GroupBox
		Private lbllabel2 As System.Windows.Forms.Label
        Private txtBatchSize As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private WithEvents buttonChangeRecords As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents btnCollapseAll As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents btnExpandAll As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents btnChangeNames As Syncfusion.Windows.Forms.ButtonAdv
		Private allowMultiThreading As Boolean = False

		Public Sub New()
			' GroupingEngineFactory provides a trimmed down GridGroup
			' which eliminates overhead of not needed preview rows, header and footer cells.
			GridEngineFactory.Factory = New GroupingEngineFactory()

			InitializeComponent()

			Try
				Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			Me.textBoxRepeatCount.Text = repeatCount.ToString()
			Me.textBoxRecordCount.Text = recordCount.ToString()
			Me.textBoxZipCount.Text = zipCount.ToString()
			Me.checkBoxMultiThreading.Checked =Me.allowMultiThreading
			Me.checkBoxUseDataViewSort.Checked = Me.useGroupingSortList
			Me.checkBoxCalculateMaximumWidth.Checked = Me.calculateMaxColumnWidth
			checkBoxSortandCategorize.Checked = Me.sortandCategorize
			Me.txtBatchSize.Text = Me.batchSize.ToString()
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			checkBoxUseScrollWindow.Checked = optimizeScrolling

			InitializeDataTable()



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


        Private Sub InitializeDataTable()
            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
            'ORIGINAL LINE: Random random = New Random(randomKey += 1);
            randomKey += 1
            Dim random As Random = New Random(randomKey)
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

            Dim i As Integer = 0
            'ORIGINAL LINE: for(int i = 0; i < recordCount; i += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While i < recordCount
                Dim row As DataRow = Me.table.NewRow()
                row("Name") = String.Format(nameFormat, i)
                row("State") = states(random.Next(numStates - 1))
                row("Zip") = random.Next(zipCount)
                Me.table.Rows.Add(row)
                i += 1
            Loop

            Me.table.DefaultView.RowStateFilter = DataViewRowState.CurrentRows
        End Sub

        Private Sub ResetGroupingGrid()
            If Not Me.grid Is Nothing Then
                Me.gridPanel.Controls.Remove(Me.grid)
                Me.grid.Dispose()
                Me.grid = Nothing
                Me.table.Dispose()
                Me.table = Nothing
                Me.LogMemoryUsage()
            End If
        End Sub

        Private Sub LogMemoryUsage()
            If Not grid Is Nothing Then
                Me.textBox1.Text += String.Format("Table Record Count {0}, Grid Record Count {1}/{3}, Display Element Count {2}, Element Count{4}" & Constants.vbCrLf, table.Rows.Count, grid.Table.Records.Count, grid.Table.DisplayElements.Count, grid.Table.UnsortedRecords.Count, grid.Table.Elements.Count)
            End If
            ' Force garbage collection and get used memory size
            GC.Collect()
            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
            'ORIGINAL LINE: System.Threading.Thread.Sleep(randomKey += 1);
            randomKey += 1
            System.Threading.Thread.Sleep(randomKey)
            Dim myProcess As Process = Process.GetCurrentProcess()
            Dim workingSetSizeinKiloBytes As Double = myProcess.WorkingSet64 / 1000
            Dim s As String = "Process's physical memory usage: " & workingSetSizeinKiloBytes.ToString() & " kb " & Constants.vbCrLf
            Me.textBox1.Text += s
            ScrollTextBox()
        End Sub

        Private Sub ScrollTextBox()
            Me.textBox1.SelectionStart = Me.textBox1.Text.Length
            Me.textBox1.ScrollBars = ScrollBars.Vertical
            Me.textBox1.ScrollToCaret()
            Me.textBox1.Focus()
        End Sub

        Private Sub OptimizeGridSettings(ByVal grid As GridGroupingControl)
            grid.CounterLogic = EngineCounters.YAmount
            grid.AllowedOptimizations = EngineOptimizations.DisableCounters Or EngineOptimizations.RecordsAsDisplayElements
            grid.UseDefaultsForFasterDrawing = True ' GDI interop drawing, FirstNRecords Summaries
            grid.InvalidateAllWhenListChanged = False ' only paint modified cells
            grid.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.InvalidateAll
            grid.UpdateDisplayFrequency = 100 ' update every number of ms (speciy 0 if Update should be called manually)




            ' Instruct grouping control not to access datasource through
            ' CurrencyManager API and instead access list diretly. When set to
            ' false you wil howver loose support for built-in CurrencyManager 
            ' synchronization.
            grid.BindToCurrencyManager = False

            If GetType(Object).AssemblyQualifiedName.IndexOf("Version=1") = -1 Then
                ' .NET 2.0 gets very slow when subscribing to ListChanged event on the 
                ' DataTable.DefaultView. The following setting allows the engine to wrap 
                ' datatable with a Syncfusion.Collections.DataTableList to work around 
                ' this bottleneck.
                '
                ' .NET 1.0 and 1.1 are just fine with using DataTable.DefaultView
                '
                grid.AllowSwapDataViewWithDataTableList = True
            End If
        End Sub

        Private Sub InitializeGroupingGrid()
            If Not Me.grid Is Nothing Then
                Me.grid.Dispose()
            End If

            Dim dtStart As DateTime = DateTime.Now

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

            ' Fill DataTable
            InitializeDataTable()

            Dim dtFill As DateTime = DateTime.Now

            ' Show an empty grid - triggers JIT compilation when run first time
            Me.grid = New GridGroupingControl()
            Me.grid.TableDescriptor.AllowCalculateMaxColumnWidth = calculateMaxColumnWidth
            Me.grid.Dock = DockStyle.Fill
            Me.grid.GridVisualStyles = GridVisualStyles.Metro
            Me.grid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            Me.grid.TopLevelGroupOptions.ShowCaption = False
            Me.grid.Appearance.AnyCell.Font.Facename = "Verdana"
            ' only set this on true multiprocessor machines - otherwise it slows down a bit
            ' because of synchronization overhead.
            Me.grid.Table.AllowThreading = Me.allowMultiThreading

            OptimizeGridSettings(grid)

            ' Assign data source
            If useGroupingSortList Then
                Dim gs As GroupingSortList = New GroupingSortList(Me.table)
                Me.grid.DataSource = gs
            Else
                Me.grid.DataSource = Me.table
            End If

            ' Assign grouping and sort order
            If Me.sortandCategorize Then
                Me.grid.TableDescriptor.GroupedColumns.Add("State")
                Me.grid.TableDescriptor.GroupedColumns.Add("Zip")
            End If

            ' Force filling and intialization of engine and drawing of grid.
            Dim count As Integer = Me.grid.Table.DisplayElements.Count

            Dim dtCount As DateTime = DateTime.Now

            ' paint the grid.
            Me.gridPanel.Controls.Add(CType(Me.grid, Control))



            Me.grid.Update()

            Windows.Forms.Cursor.Current = Cursors.Default

            Dim dtPaint As DateTime = DateTime.Now

            Dim time1 As String = String.Format("Fill Datatable: {0}" & Constants.vbCrLf, dtFill.Subtract(dtStart))
            Dim time3 As String = String.Format("Set data source and categorize: {0}" & Constants.vbCrLf, dtCount.Subtract(dtFill))
            Dim time4 As String = String.Format("Repaint: {0}" & Constants.vbCrLf, dtPaint.Subtract(dtCount))
            Dim time6 As String = String.Format("Total time: {0}" & Constants.vbCrLf, dtPaint.Subtract(dtStart))

            Me.textBox1.Text += Constants.vbCrLf & Constants.vbCrLf & time1 & time3 & time4 & time6
            Me.LogMemoryUsage()
			Me.DropShadow = True
            Me.grid.GridVisualStyles = GridVisualStyles.Metro
            Me.grid.GridOfficeScrollBars = OfficeScrollBars.Metro
			Me.BackColor = Color.White
            grid.Table.ExpandAllRecords()
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
            Me.components = New System.ComponentModel.Container
            Me.gridPanel = New System.Windows.Forms.Panel
            Me.btnInitGrid = New Syncfusion.Windows.Forms.ButtonAdv
            Me.btnResetGrid = New Syncfusion.Windows.Forms.ButtonAdv
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.labelRecordCount = New System.Windows.Forms.Label
            Me.labelZipCount = New System.Windows.Forms.Label
            Me.checkBoxCalculateMaximumWidth = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxUseDataViewSort = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxMultiThreading = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.textBoxRecordCount = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.textBoxZipCount = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.label1 = New System.Windows.Forms.Label
            Me.textBoxRepeatCount = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.buttonInsertRecords = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonRemoveRecords = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonChangeRecords = New Syncfusion.Windows.Forms.ButtonAdv
            Me.checkBoxSortandCategorize = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxUseScrollWindow = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.grpInitializeTable = New System.Windows.Forms.GroupBox
            Me.grpgroupBox1 = New System.Windows.Forms.GroupBox
            Me.btnChangeNames = New Syncfusion.Windows.Forms.ButtonAdv
            Me.btnExpandAll = New Syncfusion.Windows.Forms.ButtonAdv
            Me.btnCollapseAll = New Syncfusion.Windows.Forms.ButtonAdv
            Me.txtBatchSize = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.lbllabel2 = New System.Windows.Forms.Label
            CType(Me.checkBoxCalculateMaximumWidth, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxUseDataViewSort, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxMultiThreading, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textBoxRecordCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textBoxZipCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textBoxRepeatCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxSortandCategorize, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxUseScrollWindow, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.grpInitializeTable.SuspendLayout()
            Me.grpgroupBox1.SuspendLayout()
            CType(Me.txtBatchSize, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridPanel
            '
            Me.gridPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridPanel.Location = New System.Drawing.Point(28, 26)
            Me.gridPanel.Name = "gridPanel"
            Me.gridPanel.Size = New System.Drawing.Size(553, 344)
            Me.gridPanel.TabIndex = 0
            '
            'btnInitGrid
            '
            Me.btnInitGrid.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.btnInitGrid.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.btnInitGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnInitGrid.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.btnInitGrid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnInitGrid.ForeColor = System.Drawing.Color.White
            Me.btnInitGrid.Location = New System.Drawing.Point(30, 232)
            Me.btnInitGrid.Name = "btnInitGrid"
            Me.btnInitGrid.Size = New System.Drawing.Size(78, 24)
            Me.btnInitGrid.TabIndex = 1
            Me.btnInitGrid.TabStop = False
            Me.btnInitGrid.Text = "Load Grid"
            Me.btnInitGrid.UseVisualStyle = True
            Me.btnInitGrid.UseVisualStyleBackColor = False
            '
            'btnResetGrid
            '
            Me.btnResetGrid.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.btnResetGrid.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.btnResetGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnResetGrid.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.btnResetGrid.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnResetGrid.ForeColor = System.Drawing.Color.White
            Me.btnResetGrid.Location = New System.Drawing.Point(118, 232)
            Me.btnResetGrid.Name = "btnResetGrid"
            Me.btnResetGrid.Size = New System.Drawing.Size(90, 24)
            Me.btnResetGrid.TabIndex = 1
            Me.btnResetGrid.TabStop = False
            Me.btnResetGrid.Text = "Reset Grid"
            Me.btnResetGrid.UseVisualStyle = True
            Me.btnResetGrid.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox1.ForeColor = System.Drawing.Color.DimGray
            Me.textBox1.Location = New System.Drawing.Point(28, 400)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(553, 160)
            Me.textBox1.TabIndex = 3
            Me.textBox1.TabStop = False
            Me.textBox1.Text = "Results:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "-----------"
            '
            'labelRecordCount
            '
            Me.labelRecordCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.labelRecordCount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelRecordCount.ForeColor = System.Drawing.Color.DimGray
            Me.labelRecordCount.Location = New System.Drawing.Point(633, 54)
            Me.labelRecordCount.Name = "labelRecordCount"
            Me.labelRecordCount.Size = New System.Drawing.Size(82, 23)
            Me.labelRecordCount.TabIndex = 4
            Me.labelRecordCount.Text = "RecordCount"
            '
            'labelZipCount
            '
            Me.labelZipCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.labelZipCount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelZipCount.ForeColor = System.Drawing.Color.DimGray
            Me.labelZipCount.Location = New System.Drawing.Point(633, 94)
            Me.labelZipCount.Name = "labelZipCount"
            Me.labelZipCount.Size = New System.Drawing.Size(82, 23)
            Me.labelZipCount.TabIndex = 5
            Me.labelZipCount.Text = "Zip Count"
            '
            'checkBoxCalculateMaximumWidth
            '
            Me.checkBoxCalculateMaximumWidth.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.checkBoxCalculateMaximumWidth.Checked = True
            Me.checkBoxCalculateMaximumWidth.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxCalculateMaximumWidth.DrawFocusRectangle = False
            Me.checkBoxCalculateMaximumWidth.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxCalculateMaximumWidth.ForeColor = System.Drawing.Color.DimGray
            Me.checkBoxCalculateMaximumWidth.Location = New System.Drawing.Point(633, 158)
            Me.checkBoxCalculateMaximumWidth.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxCalculateMaximumWidth.Name = "checkBoxCalculateMaximumWidth"
            Me.checkBoxCalculateMaximumWidth.Size = New System.Drawing.Size(156, 24)
            Me.checkBoxCalculateMaximumWidth.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxCalculateMaximumWidth.TabIndex = 3
            Me.checkBoxCalculateMaximumWidth.Text = "Calculate Column Width"
            Me.checkBoxCalculateMaximumWidth.ThemesEnabled = False
            '
            'checkBoxUseDataViewSort
            '
            Me.checkBoxUseDataViewSort.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.checkBoxUseDataViewSort.DrawFocusRectangle = False
            Me.checkBoxUseDataViewSort.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxUseDataViewSort.ForeColor = System.Drawing.Color.DimGray
            Me.checkBoxUseDataViewSort.Location = New System.Drawing.Point(633, 182)
            Me.checkBoxUseDataViewSort.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxUseDataViewSort.Name = "checkBoxUseDataViewSort"
            Me.checkBoxUseDataViewSort.Size = New System.Drawing.Size(156, 24)
            Me.checkBoxUseDataViewSort.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxUseDataViewSort.TabIndex = 4
            Me.checkBoxUseDataViewSort.Text = "Use DataView Sort "
            Me.checkBoxUseDataViewSort.ThemesEnabled = False
            '
            'checkBoxMultiThreading
            '
            Me.checkBoxMultiThreading.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.checkBoxMultiThreading.DrawFocusRectangle = False
            Me.checkBoxMultiThreading.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxMultiThreading.ForeColor = System.Drawing.Color.DimGray
            Me.checkBoxMultiThreading.Location = New System.Drawing.Point(633, 206)
            Me.checkBoxMultiThreading.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxMultiThreading.Name = "checkBoxMultiThreading"
            Me.checkBoxMultiThreading.Size = New System.Drawing.Size(124, 24)
            Me.checkBoxMultiThreading.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxMultiThreading.TabIndex = 5
            Me.checkBoxMultiThreading.Text = "MultiThreading"
            Me.checkBoxMultiThreading.ThemesEnabled = False
            '
            'textBoxRecordCount
            '
            Me.textBoxRecordCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.textBoxRecordCount.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.textBoxRecordCount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxRecordCount.ForeColor = System.Drawing.Color.DimGray
            Me.textBoxRecordCount.Location = New System.Drawing.Point(737, 54)
            Me.textBoxRecordCount.Name = "textBoxRecordCount"
            Me.textBoxRecordCount.Size = New System.Drawing.Size(64, 22)
            Me.textBoxRecordCount.TabIndex = 0
            Me.textBoxRecordCount.Text = "50000"
            '
            'textBoxZipCount
            '
            Me.textBoxZipCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.textBoxZipCount.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.textBoxZipCount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxZipCount.ForeColor = System.Drawing.Color.DimGray
            Me.textBoxZipCount.Location = New System.Drawing.Point(737, 94)
            Me.textBoxZipCount.Name = "textBoxZipCount"
            Me.textBoxZipCount.Size = New System.Drawing.Size(64, 22)
            Me.textBoxZipCount.TabIndex = 1
            Me.textBoxZipCount.Text = "1000"
            '
            'label1
            '
            Me.label1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.DimGray
            Me.label1.Location = New System.Drawing.Point(633, 350)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(76, 20)
            Me.label1.TabIndex = 10
            Me.label1.Text = "Repeat Count"
            '
            'textBoxRepeatCount
            '
            Me.textBoxRepeatCount.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.textBoxRepeatCount.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.textBoxRepeatCount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxRepeatCount.ForeColor = System.Drawing.Color.DimGray
            Me.textBoxRepeatCount.Location = New System.Drawing.Point(737, 350)
            Me.textBoxRepeatCount.Name = "textBoxRepeatCount"
            Me.textBoxRepeatCount.Size = New System.Drawing.Size(64, 22)
            Me.textBoxRepeatCount.TabIndex = 6
            Me.textBoxRepeatCount.Text = "100"
            '
            'buttonInsertRecords
            '
            Me.buttonInsertRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonInsertRecords.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonInsertRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonInsertRecords.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonInsertRecords.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonInsertRecords.ForeColor = System.Drawing.Color.White
            Me.buttonInsertRecords.Location = New System.Drawing.Point(119, 123)
            Me.buttonInsertRecords.Name = "buttonInsertRecords"
            Me.buttonInsertRecords.Size = New System.Drawing.Size(89, 23)
            Me.buttonInsertRecords.TabIndex = 12
            Me.buttonInsertRecords.TabStop = False
            Me.buttonInsertRecords.Text = "Insert Records"
            Me.buttonInsertRecords.UseVisualStyle = True
            Me.buttonInsertRecords.UseVisualStyleBackColor = True
            '
            'buttonRemoveRecords
            '
            Me.buttonRemoveRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonRemoveRecords.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonRemoveRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonRemoveRecords.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonRemoveRecords.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonRemoveRecords.ForeColor = System.Drawing.Color.White
            Me.buttonRemoveRecords.Location = New System.Drawing.Point(24, 123)
            Me.buttonRemoveRecords.Name = "buttonRemoveRecords"
            Me.buttonRemoveRecords.Size = New System.Drawing.Size(84, 23)
            Me.buttonRemoveRecords.TabIndex = 12
            Me.buttonRemoveRecords.TabStop = False
            Me.buttonRemoveRecords.Text = "Remove Records"
            Me.buttonRemoveRecords.UseVisualStyle = True
            Me.buttonRemoveRecords.UseVisualStyleBackColor = True
            '
            'buttonChangeRecords
            '
            Me.buttonChangeRecords.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonChangeRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonChangeRecords.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonChangeRecords.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonChangeRecords.ForeColor = System.Drawing.Color.White
            Me.buttonChangeRecords.Location = New System.Drawing.Point(24, 152)
            Me.buttonChangeRecords.Name = "buttonChangeRecords"
            Me.buttonChangeRecords.Size = New System.Drawing.Size(84, 23)
            Me.buttonChangeRecords.TabIndex = 16
            Me.buttonChangeRecords.TabStop = False
            Me.buttonChangeRecords.Text = "Change Records"
            Me.buttonChangeRecords.UseVisualStyle = True
            Me.buttonChangeRecords.UseVisualStyleBackColor = True
            '
            'checkBoxSortandCategorize
            '
            Me.checkBoxSortandCategorize.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.checkBoxSortandCategorize.Checked = True
            Me.checkBoxSortandCategorize.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxSortandCategorize.DrawFocusRectangle = False
            Me.checkBoxSortandCategorize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxSortandCategorize.ForeColor = System.Drawing.Color.DimGray
            Me.checkBoxSortandCategorize.Location = New System.Drawing.Point(633, 134)
            Me.checkBoxSortandCategorize.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxSortandCategorize.Name = "checkBoxSortandCategorize"
            Me.checkBoxSortandCategorize.Size = New System.Drawing.Size(156, 24)
            Me.checkBoxSortandCategorize.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxSortandCategorize.TabIndex = 2
            Me.checkBoxSortandCategorize.Text = "Sort and Categorize"
            Me.checkBoxSortandCategorize.ThemesEnabled = False
            '
            'checkBoxUseScrollWindow
            '
            Me.checkBoxUseScrollWindow.DrawFocusRectangle = False
            Me.checkBoxUseScrollWindow.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxUseScrollWindow.ForeColor = System.Drawing.Color.DimGray
            Me.checkBoxUseScrollWindow.Location = New System.Drawing.Point(24, 88)
            Me.checkBoxUseScrollWindow.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.checkBoxUseScrollWindow.Name = "checkBoxUseScrollWindow"
            Me.checkBoxUseScrollWindow.Size = New System.Drawing.Size(152, 16)
            Me.checkBoxUseScrollWindow.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.checkBoxUseScrollWindow.TabIndex = 8
            Me.checkBoxUseScrollWindow.Text = "Use ScrollWindow"
            Me.checkBoxUseScrollWindow.ThemesEnabled = False
            '
            'grpInitializeTable
            '
            Me.grpInitializeTable.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.grpInitializeTable.Controls.Add(Me.btnResetGrid)
            Me.grpInitializeTable.Controls.Add(Me.btnInitGrid)
            Me.grpInitializeTable.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpInitializeTable.Location = New System.Drawing.Point(607, 26)
            Me.grpInitializeTable.Name = "grpInitializeTable"
            Me.grpInitializeTable.Size = New System.Drawing.Size(214, 272)
            Me.grpInitializeTable.TabIndex = 14
            Me.grpInitializeTable.TabStop = False
            Me.grpInitializeTable.Text = "Initialize Table"
            '
            'grpgroupBox1
            '
            Me.grpgroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.grpgroupBox1.Controls.Add(Me.btnChangeNames)
            Me.grpgroupBox1.Controls.Add(Me.btnExpandAll)
            Me.grpgroupBox1.Controls.Add(Me.btnCollapseAll)
            Me.grpgroupBox1.Controls.Add(Me.txtBatchSize)
            Me.grpgroupBox1.Controls.Add(Me.lbllabel2)
            Me.grpgroupBox1.Controls.Add(Me.checkBoxUseScrollWindow)
            Me.grpgroupBox1.Controls.Add(Me.buttonRemoveRecords)
            Me.grpgroupBox1.Controls.Add(Me.buttonChangeRecords)
            Me.grpgroupBox1.Controls.Add(Me.buttonInsertRecords)
            Me.grpgroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.grpgroupBox1.ForeColor = System.Drawing.Color.DimGray
            Me.grpgroupBox1.Location = New System.Drawing.Point(607, 320)
            Me.grpgroupBox1.Name = "grpgroupBox1"
            Me.grpgroupBox1.Size = New System.Drawing.Size(214, 240)
            Me.grpgroupBox1.TabIndex = 15
            Me.grpgroupBox1.TabStop = False
            Me.grpgroupBox1.Text = "Manipulate Grid"
            '
            'btnChangeNames
            '
            Me.btnChangeNames.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.btnChangeNames.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnChangeNames.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.btnChangeNames.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnChangeNames.ForeColor = System.Drawing.Color.White
            Me.btnChangeNames.Location = New System.Drawing.Point(118, 152)
            Me.btnChangeNames.Name = "btnChangeNames"
            Me.btnChangeNames.Size = New System.Drawing.Size(90, 23)
            Me.btnChangeNames.TabIndex = 17
            Me.btnChangeNames.TabStop = False
            Me.btnChangeNames.Text = "Change Names"
            Me.btnChangeNames.UseVisualStyle = True
            Me.btnChangeNames.UseVisualStyleBackColor = True
            '
            'btnExpandAll
            '
            Me.btnExpandAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.btnExpandAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnExpandAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.btnExpandAll.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnExpandAll.ForeColor = System.Drawing.Color.White
            Me.btnExpandAll.Location = New System.Drawing.Point(119, 181)
            Me.btnExpandAll.Name = "btnExpandAll"
            Me.btnExpandAll.Size = New System.Drawing.Size(89, 23)
            Me.btnExpandAll.TabIndex = 15
            Me.btnExpandAll.TabStop = False
            Me.btnExpandAll.Text = "Expand All"
            Me.btnExpandAll.UseVisualStyle = True
            Me.btnExpandAll.UseVisualStyleBackColor = True
            '
            'btnCollapseAll
            '
            Me.btnCollapseAll.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.btnCollapseAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.btnCollapseAll.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.btnCollapseAll.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnCollapseAll.ForeColor = System.Drawing.Color.White
            Me.btnCollapseAll.Location = New System.Drawing.Point(24, 181)
            Me.btnCollapseAll.Name = "btnCollapseAll"
            Me.btnCollapseAll.Size = New System.Drawing.Size(84, 23)
            Me.btnCollapseAll.TabIndex = 14
            Me.btnCollapseAll.TabStop = False
            Me.btnCollapseAll.Text = "Collapse All"
            Me.btnCollapseAll.UseVisualStyle = True
            Me.btnCollapseAll.UseVisualStyleBackColor = True
            '
            'txtBatchSize
            '
            Me.txtBatchSize.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.txtBatchSize.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtBatchSize.ForeColor = System.Drawing.Color.DimGray
            Me.txtBatchSize.Location = New System.Drawing.Point(130, 53)
            Me.txtBatchSize.Name = "txtBatchSize"
            Me.txtBatchSize.Size = New System.Drawing.Size(64, 22)
            Me.txtBatchSize.TabIndex = 7
            Me.txtBatchSize.Text = "1"
            '
            'lbllabel2
            '
            Me.lbllabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbllabel2.ForeColor = System.Drawing.Color.DimGray
            Me.lbllabel2.Location = New System.Drawing.Point(26, 59)
            Me.lbllabel2.Name = "lbllabel2"
            Me.lbllabel2.Size = New System.Drawing.Size(72, 16)
            Me.lbllabel2.TabIndex = 0
            Me.lbllabel2.Text = "Batch Size"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(849, 595)
            Me.Controls.Add(Me.textBoxRepeatCount)
            Me.Controls.Add(Me.textBoxRecordCount)
            Me.Controls.Add(Me.checkBoxCalculateMaximumWidth)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.textBoxZipCount)
            Me.Controls.Add(Me.checkBoxSortandCategorize)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.checkBoxMultiThreading)
            Me.Controls.Add(Me.checkBoxUseDataViewSort)
            Me.Controls.Add(Me.labelZipCount)
            Me.Controls.Add(Me.labelRecordCount)
            Me.Controls.Add(Me.gridPanel)
            Me.Controls.Add(Me.grpInitializeTable)
            Me.Controls.Add(Me.grpgroupBox1)
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(400, 600)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Grouping Performance Demo"
            CType(Me.checkBoxCalculateMaximumWidth, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxUseDataViewSort, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxMultiThreading, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBoxRecordCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBoxZipCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBoxRepeatCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxSortandCategorize, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxUseScrollWindow, System.ComponentModel.ISupportInitialize).EndInit()
            Me.grpInitializeTable.ResumeLayout(False)
            Me.grpgroupBox1.ResumeLayout(False)
            Me.grpgroupBox1.PerformLayout()
            CType(Me.txtBatchSize, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
				Application.EnableVisualStyles()
			#End If

			Application.Run(New Form1())
		End Sub

		Private Sub btnInitGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInitGrid.Click

			Me.allowMultiThreading = Me.checkBoxMultiThreading.Checked
			Me.useGroupingSortList = Me.checkBoxUseDataViewSort.Checked
			Me.calculateMaxColumnWidth = Me.checkBoxCalculateMaximumWidth.Checked
			Me.recordCount = Convert.ToInt32(Me.textBoxRecordCount.Text)
			Me.zipCount = Convert.ToInt32(Me.textBoxZipCount.Text)
			Me.sortandCategorize = checkBoxSortandCategorize.Checked

			Me.InitializeGroupingGrid()
		End Sub

		Private Sub btnResetGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnResetGrid.Click
			Me.ResetGroupingGrid()
		End Sub

		Private Sub buttonInsertRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonInsertRecords.Click
			If grid Is Nothing Then
				Return
			End If

			repeatCount = Convert.ToInt32(Me.textBoxRepeatCount.Text)
			batchSize = Convert.ToInt32(Me.txtBatchSize.Text)
			optimizeScrolling = checkBoxUseScrollWindow.Checked

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

			Dim dtStart As DateTime = DateTime.Now

'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
            'ORIGINAL LINE: Random random = New Random(randomKey += 1);
            randomKey += 1
            Dim random As Random = New Random(randomKey)
			Dim numStates As Integer = states.GetLength(0)
			Dim nameFormat As String = "Ins{0:00000}"

			' Use ScrollWindow operations instead of invalidating whole grid when
			' inserting or removing records.
			Me.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling

			Dim i As Integer = 0
'ORIGINAL LINE: for(int i = 0; i < repeatCount; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < repeatCount
				Dim row As DataRow = Me.table.NewRow()
				row("Name") = String.Format(nameFormat, Me.table.Rows.Count)
				row("State") = states(random.Next(numStates-1))
				row("Zip") = random.Next(zipCount)
				Me.table.Rows.Add(row)

				' Force immediate update of visible area and scrollbars after each operation
				' when grouped, record will automatically be inserted in the correct group
				' and sort order.
				If (i+1) Mod batchSize = 0 Then
					grid.Update()
				End If
				i += 1
			Loop
			Me.grid.Update()

			Dim dtEnd As DateTime = DateTime.Now

            Windows.Forms.Cursor.Current = Cursors.Default

			Dim time1 As String = String.Format("Inserted {0} Records: {1}" & Constants.vbCrLf, repeatCount, dtEnd.Subtract(dtStart))
			Me.textBox1.Text += Constants.vbCrLf & Constants.vbCrLf & time1
			Me.LogMemoryUsage()
		End Sub

		Private Sub buttonRemoveRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonRemoveRecords.Click
			If grid Is Nothing Then
				Return
			End If

			repeatCount = Convert.ToInt32(Me.textBoxRepeatCount.Text)
			batchSize = Convert.ToInt32(Me.txtBatchSize.Text)
			optimizeScrolling = checkBoxUseScrollWindow.Checked

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

			Dim dtStart As DateTime = DateTime.Now

'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
            'ORIGINAL LINE: Random random = New Random(randomKey += 1);
            randomKey += 1
            Dim random As Random = New Random(randomKey)

			' Use ScrollWindow operations instead of invalidating whole grid when
			' inserting or removing records.
			Me.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling

			Dim i As Integer = 0
'ORIGINAL LINE: for(int i = 0; i < repeatCount; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < repeatCount
				Dim record As Integer = CInt(Math.Min(table.Rows.Count-1, random.Next(0, table.Rows.Count)))
				If record < 0 Then
					Exit Do
				End If

					Me.table.Rows.RemoveAt(record)

				' Force immediate update of visible area and scrollbars after each operation
				'Trace.WriteLine(String.Format("Table Record Count {0}, Grid Record Count {1}/{3}, Display Element Count {2}\r\n", table.Rows.Count, grid.Table.Records.Count, grid.Table.DisplayElements.Count, grid.Table.UnsortedRecords.Count));
				If (i+1) Mod batchSize = 0 Then
					grid.Update()
				End If
				i += 1
			Loop
			Me.grid.Update()

			Dim dtEnd As DateTime = DateTime.Now

            Windows.Forms.Cursor.Current = Cursors.Default

			Dim time1 As String = String.Format("Removed {0} Records: {1}" & Constants.vbCrLf, repeatCount, dtEnd.Subtract(dtStart))
			Me.textBox1.Text += Constants.vbCrLf & Constants.vbCrLf & time1
			Me.LogMemoryUsage()
		End Sub

		Private Sub btnChangeNames_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnChangeNames.Click
			If grid Is Nothing Then
				Return
			End If

			repeatCount = Convert.ToInt32(Me.textBoxRepeatCount.Text)
			batchSize = Convert.ToInt32(Me.txtBatchSize.Text)
			optimizeScrolling = checkBoxUseScrollWindow.Checked

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

			Dim dtStart As DateTime = DateTime.Now

'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
            'ORIGINAL LINE: Random random = New Random(randomKey += 1);
            randomKey += 1
            Dim random As Random = New Random(randomKey)
			Dim nameFormat As String = "Chg{0:00000}"
			Dim numStates As Integer = states.GetLength(0)


			' Use ScrollWindow operations instead of invalidating whole grid when
			' inserting or removing records.
			Me.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling

			Dim i As Integer = 0
'ORIGINAL LINE: for(int i = 0; i < repeatCount; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < repeatCount
				Dim record As Integer = CInt(Math.Min(table.Rows.Count-1, random.Next(table.Rows.Count)))
				If record >= 0 Then
					Dim row As DataRow = Me.table.Rows(record)
					row("Name") = String.Format(nameFormat, i)
				End If

				' Force immediate update of visible area and scrollbars after each operation
				' If grid is sorted by name, the record will be removed and reinserted at correct
				' sort position.
				If (i+1) Mod batchSize = 0 Then
					grid.Update()
				End If
				i += 1
			Loop
			Me.grid.Update()

			Dim dtEnd As DateTime = DateTime.Now

            Windows.Forms.Cursor.Current = Cursors.Default

			Dim time1 As String = String.Format("Changed {0} Records: {1}" & Constants.vbCrLf, repeatCount, dtEnd.Subtract(dtStart))
			Me.textBox1.Text += Constants.vbCrLf & Constants.vbCrLf & time1
			Me.LogMemoryUsage()
		End Sub

		Private Sub btnCollapseAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCollapseAll.Click
			If grid Is Nothing Then
				Return
			End If

			Dim dtStart As DateTime = DateTime.Now

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

			Me.grid.Table.CollapseAllGroups()

			Dim dtEnd As DateTime = DateTime.Now

            Windows.Forms.Cursor.Current = Cursors.Default

			Dim time1 As String = String.Format("Expanded all groups: {0}" & Constants.vbCrLf, dtEnd.Subtract(dtStart))
			Me.textBox1.Text += Constants.vbCrLf & Constants.vbCrLf & time1
			Me.LogMemoryUsage()
		End Sub

		Private Sub btnExpandAll_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExpandAll.Click
			If grid Is Nothing Then
				Return
			End If

			Dim dtStart As DateTime = DateTime.Now

			Cursor.Current = Cursors.WaitCursor

			Me.grid.Table.ExpandAllGroups()

			Dim dtEnd As DateTime = DateTime.Now

			Cursor.Current = Cursors.Default

			Dim time1 As String = String.Format("Expanded all groups: {0}" & Constants.vbCrLf, dtEnd.Subtract(dtStart))
			Me.textBox1.Text += Constants.vbCrLf & Constants.vbCrLf & time1
			Me.LogMemoryUsage()
		End Sub

		Private Sub buttonChangeRecords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonChangeRecords.Click
			If grid Is Nothing Then
				Return
			End If

			repeatCount = Convert.ToInt32(Me.textBoxRepeatCount.Text)
			batchSize = Convert.ToInt32(Me.txtBatchSize.Text)
			optimizeScrolling = checkBoxUseScrollWindow.Checked

            Windows.Forms.Cursor.Current = Cursors.WaitCursor

			Dim dtStart As DateTime = DateTime.Now

'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
            'ORIGINAL LINE: Random random = New Random(randomKey += 1);
            randomKey += 1
            Dim random As Random = New Random(randomKey)
			Dim nameFormat As String = "Chg{0:00000}"
			Dim numStates As Integer = states.GetLength(0)


			' Use ScrollWindow operations instead of invalidating whole grid when
			' inserting or removing records.
			Me.grid.TableControl.OptimizeInsertRemoveCells = optimizeScrolling

			Dim i As Integer = 0
'ORIGINAL LINE: for(int i = 0; i < repeatCount; i += 1)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
			Do While i < repeatCount
				Dim record As Integer = CInt(Math.Min(table.Rows.Count-1, random.Next(table.Rows.Count)))
				If record >= 0 Then
					Dim row As DataRow = Me.table.Rows(record)
					row.BeginEdit()
					row("Name") = String.Format(nameFormat, i)
					row("State") = states(random.Next(numStates-1))
					row("Zip") = random.Next(zipCount)
					row.EndEdit()
				End If

				' Force immediate update of visible area and scrollbars after each operation
				' If grid is sorted by name, the record will be removed and reinserted at correct
				' sort position.
				If (i+1) Mod batchSize = 0 Then
					grid.Update()
				End If
				i += 1
			Loop
			Me.grid.Update()

			Dim dtEnd As DateTime = DateTime.Now

            Windows.Forms.Cursor.Current = Cursors.Default

			Dim time1 As String = String.Format("Changed {0} Records: {1}" & Constants.vbCrLf, repeatCount, dtEnd.Subtract(dtStart))
			Me.textBox1.Text += Constants.vbCrLf & Constants.vbCrLf & time1
			Me.LogMemoryUsage()
		End Sub
	End Class



	''' <summary>
	''' GroupingSortList wraps a DataView with a IBindingList and implements the IGroupingList
	''' interface and its Sort method. This allows performing the sort on the dataview directly
	''' instead of letting the grouping engine perform the sorting.
	''' </summary>
	Public Class GroupingSortList : Implements IGroupingList, IBindingList
		Private dt As DataTable
		Private dv As DataView
		Private bindingList As IBindingList

		Public Sub New(ByVal dt As DataTable)
			Me.dt = dt
			Me.dv = dt.DefaultView
			bindingList = CType(dv, IBindingList)
			AddHandler bindingList.ListChanged, AddressOf bindingList_ListChanged
		End Sub

		#Region "IGroupingList Members"

        Public Sub ApplySort(ByVal relationChildColumns As RelationChildColumnDescriptorCollection, ByVal groupColumns As SortColumnDescriptorCollection, ByVal sortColumns As SortColumnDescriptorCollection) Implements IGroupingList.ApplySort
            Dim first As Boolean = True
            Dim sb As StringBuilder = New StringBuilder()
            For Each sd As SortColumnDescriptor In relationChildColumns
                If first Then
                    first = False
                Else
                    sb.Append(", ")
                End If

                sb.Append(sd.FieldDescriptor.MappingName)
                If sd.SortDirection = ListSortDirection.Descending Then
                    sb.Append(" DESC")
                End If
            Next sd
            Dim sort As String = sb.ToString()
            If sort <> dv.Sort Then
                dv.Sort = sort
            End If
        End Sub

		Public ReadOnly Property AllowItemReference() As Boolean Implements IGroupingList.AllowItemReference
			Get
				Return False
			End Get
		End Property

		Public ReadOnly Property SupportsGroupSorting() As Boolean Implements IGroupingList.SupportsGroupSorting
			Get
				Return True
			End Get
		End Property

		Public ReadOnly Property GroupingSortBehavior() As Syncfusion.Grouping.GroupingSortBehavior Implements IGroupingList.GroupingSortBehavior
			Get
				Return Syncfusion.Grouping.GroupingSortBehavior.GroupByGroup
			End Get
		End Property

		#End Region

		#Region "IBindingList Members"

'TODO: INSTANT VB TODO TASK: property is a keyword in VB.NET. Change the name or use square brackets to override it:
'INSTANT VB NOTE: The parameter property was renamed since it is a keyword in VB:
		Public Sub AddIndex(ByVal property_Renamed As PropertyDescriptor) Implements IBindingList.AddIndex
			bindingList.AddIndex(property_Renamed)
		End Sub

		Public ReadOnly Property AllowNew() As Boolean Implements IBindingList.AllowNew
			Get
				Return bindingList.AllowNew
			End Get
		End Property

'TODO: INSTANT VB TODO TASK: property is a keyword in VB.NET. Change the name or use square brackets to override it:
'INSTANT VB NOTE: The parameter property was renamed since it is a keyword in VB:
		Private Sub ApplySort(ByVal property_Renamed As PropertyDescriptor, ByVal direction As System.ComponentModel.ListSortDirection) Implements System.ComponentModel.IBindingList.ApplySort
			bindingList.ApplySort(property_Renamed, direction)
		End Sub

		Public ReadOnly Property SortProperty() As PropertyDescriptor Implements IBindingList.SortProperty
			Get
				Return bindingList.SortProperty
			End Get
		End Property

'TODO: INSTANT VB TODO TASK: property is a keyword in VB.NET. Change the name or use square brackets to override it:
'INSTANT VB NOTE: The parameter property was renamed since it is a keyword in VB:
		Public Function Find(ByVal property_Renamed As PropertyDescriptor, ByVal key As Object) As Integer Implements IBindingList.Find
			Return bindingList.Find(property_Renamed, key)
		End Function

		Public ReadOnly Property SupportsSorting() As Boolean Implements IBindingList.SupportsSorting
			Get
				Return bindingList.SupportsSorting
			End Get
		End Property

		Public ReadOnly Property IsSorted() As Boolean Implements IBindingList.IsSorted
			Get
				Return bindingList.IsSorted
			End Get
		End Property

		Public ReadOnly Property AllowRemove() As Boolean Implements IBindingList.AllowRemove
			Get
				Return bindingList.AllowRemove
			End Get
		End Property

		Public ReadOnly Property SupportsSearching() As Boolean Implements IBindingList.SupportsSearching
			Get
				Return bindingList.SupportsSearching
			End Get
		End Property

		Public ReadOnly Property SortDirection() As System.ComponentModel.ListSortDirection Implements IBindingList.SortDirection
			Get
				Return bindingList.SortDirection
			End Get
		End Property

		Public Event ListChanged As System.ComponentModel.ListChangedEventHandler Implements IBindingList.ListChanged

		Public ReadOnly Property SupportsChangeNotification() As Boolean Implements IBindingList.SupportsChangeNotification
			Get
				Return bindingList.SupportsChangeNotification
			End Get
		End Property

		Public Sub RemoveSort() Implements IBindingList.RemoveSort
			bindingList.RemoveSort()
		End Sub

		Public Function AddNew() As Object Implements IBindingList.AddNew
			Return bindingList.AddNew()
		End Function

		Public ReadOnly Property AllowEdit() As Boolean Implements IBindingList.AllowEdit
			Get
				Return bindingList.AllowEdit
			End Get
		End Property

'TODO: INSTANT VB TODO TASK: property is a keyword in VB.NET. Change the name or use square brackets to override it:
'INSTANT VB NOTE: The parameter property was renamed since it is a keyword in VB:
		Public Sub RemoveIndex(ByVal property_Renamed As PropertyDescriptor) Implements IBindingList.RemoveIndex
			bindingList.RemoveIndex(property_Renamed)
		End Sub

		#End Region

		#Region "IList Members"

        Public ReadOnly Property IsReadOnly() As Boolean Implements IBindingList.IsReadOnly
            Get
                Return bindingList.IsReadOnly
            End Get
        End Property

        Default Public Property Item(ByVal index As Integer) As Object Implements IBindingList.Item
            Get
                Return bindingList(index)
            End Get
            Set(ByVal value As Object)
                bindingList(index) = Value
            End Set
        End Property

        Public Sub RemoveAt(ByVal index As Integer) Implements IBindingList.RemoveAt
            bindingList.RemoveAt(index)
        End Sub

        Public Sub Insert(ByVal index As Integer, ByVal value As Object) Implements IBindingList.Insert
            bindingList.Insert(index, value)
        End Sub

        Public Sub Remove(ByVal value As Object) Implements IBindingList.Remove
            bindingList.Remove(value)
        End Sub

        Public Function Contains(ByVal value As Object) As Boolean Implements IBindingList.Contains

            Return bindingList.Contains(value)
        End Function

        Public Sub Clear() Implements IBindingList.Clear
            bindingList.Clear()
        End Sub

        Public Function IndexOf(ByVal value As Object) As Integer Implements IBindingList.IndexOf
            Return bindingList.IndexOf(value)
        End Function

        Public Function Add(ByVal value As Object) As Integer Implements IBindingList.Add
            Return bindingList.Add(value)
        End Function

        Public ReadOnly Property IsFixedSize() As Boolean Implements IBindingList.IsFixedSize
            Get
                Return bindingList.IsFixedSize
            End Get
        End Property

		#End Region

		#Region "ICollection Members"

        Public ReadOnly Property IsSynchronized() As Boolean Implements IBindingList.IsSynchronized
            Get
                Return bindingList.IsSynchronized
            End Get
        End Property

        Public ReadOnly Property Count() As Integer Implements IBindingList.Count
            Get
                Return bindingList.Count
            End Get
        End Property

        Public Sub CopyTo(ByVal array As Array, ByVal index As Integer) Implements IBindingList.CopyTo
            bindingList.CopyTo(array, index)
        End Sub

        Public ReadOnly Property SyncRoot() As Object Implements IBindingList.SyncRoot
            Get
                Return bindingList.SyncRoot
            End Get
        End Property

		#End Region

		#Region "IEnumerable Members"

        Public Function GetEnumerator() As IEnumerator Implements IBindingList.GetEnumerator
            Return bindingList.GetEnumerator()
        End Function

		#End Region

		Private Sub bindingList_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
			If Not ListChangedEvent Is Nothing Then
				RaiseEvent ListChanged(Me, e)
			End If
		End Sub
	End Class

	''' <summary>
	''' GroupingEngineFactory provides a trimmed down GridGroup
	''' which eliminates overhead of not needed preview rows, header and footer cells.
	''' </summary>
	Public Class GroupingEngineFactory : Inherits GridEngineFactoryBase
		Public Overrides Function CreateEngine() As GridEngine
			Return New GroupingEngine()
		End Function
	End Class

	Public Class GroupingEngine : Inherits GridEngine
		Public Overrides Function CreateGroup(ByVal parent As Section) As Group
			Return New GroupingGroup(parent)
		End Function

	End Class

	Public Class GroupingGroup : Inherits Group
		Public Sub New(ByVal parent As Section)
			MyBase.New(parent)
		End Sub

		Protected Overrides Sub OnInitializeSections(ByVal hasRecords As Boolean, ByVal fields As SortColumnDescriptorCollection)
			Me.Sections.Add(Me.ParentTableDescriptor.CreateCaptionSection(Me))
			If hasRecords Then
				Me.Sections.Add(Me.ParentTableDescriptor.CreateRecordsDetails(Me, fields))
			Else
				Me.Sections.Add(Me.ParentTableDescriptor.CreateGroupsDetails(Me, fields))
			End If
			Me.Sections.Add(Me.ParentTableDescriptor.CreateSummarySection(Me))
		End Sub

		Public Overrides Function IsChildVisible(ByVal el As Element) As Boolean
			If TypeOf el Is CaptionSection Then
				Return True
			Else If TypeOf el Is DetailsSection Then
				Return Me.IsExpanded
			Else If TypeOf el Is GridSummarySection Then
				Return Me.IsExpanded
			End If
			Return True
		End Function
	End Class

End Namespace
