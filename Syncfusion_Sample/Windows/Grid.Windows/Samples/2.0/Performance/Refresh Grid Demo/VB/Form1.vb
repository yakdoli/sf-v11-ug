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
Imports System.Threading

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Styles
Imports Syncfusion.Drawing
Imports Syncfusion.ComponentModel
Imports Syncfusion.Windows.Forms


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits MetroForm
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private grid As PerformanceGrid
    Private model As Model
    Private timer As System.Windows.Forms.Timer
    Private transpose As Boolean = False

    Private useGDI As Boolean
    Private usePrepareViewStyleInfo As Boolean
    Private showHeaders As Boolean
    Private drawBorder As Boolean
    Private iterationsPerUpdate As Integer
    Private timerInterval As Integer
    Private sleep As Integer
    Private useDoubleBuffer As Boolean
    Private statusBar1 As System.Windows.Forms.StatusBar
    Private refreshCountPanel As System.Windows.Forms.StatusBarPanel
    Private tickCountPanel As System.Windows.Forms.StatusBarPanel
    Private averageTicksPanel As System.Windows.Forms.StatusBarPanel
    Private optimizeDrawBackground As Boolean
    Private insertRemoveInterval As Integer
	private Dim clientHeight As Integer

    Public Sub New()
        ' adjust behavior of performance sanoke with the following properties
        useGDI = True
        usePrepareViewStyleInfo = False
        showHeaders = True
        drawBorder = True
        useDoubleBuffer = False
        optimizeDrawBackground = True
        iterationsPerUpdate = 3
        insertRemoveInterval = 1
        timerInterval = 20
        sleep = 0

        useDoubleBuffer = useDoubleBuffer Or Not useGDI


        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Me.grid = New PerformanceGrid()
        Me.grid.Model.UseGridNonVirtualDataCache = True
        Me.grid.UseGDI = useGDI
        Me.grid.UseDoubleBuffer = useDoubleBuffer
        Me.grid.OptimizeDrawBackground = optimizeDrawBackground
        Me.grid.OptimizeInsertRemoveCells = True
        GridStyleInfo.Default.Trimming = StringTrimming.None ' Default is StringTrimming.Char which forces
        ' GridGDIPaint.DrawText to use NativeMethods.DrawText instead of NativeMethods.ExtTextOut

        Me.grid.Model(0, 0).Text = " "

        ' PrepareViewStyleInfo lets you modify a temporary copy of style objects, and change
        ' appearance without saving changes to volatile data cache. However, this is a bit
        ' slower than modifying contents directly.
        Me.grid.SupportsPrepareViewStyleInfo = usePrepareViewStyleInfo
        If usePrepareViewStyleInfo Then
            AddHandler grid.PrepareViewStyleInfo, AddressOf grid_PrepareViewStyleInfo
        End If
        If drawBorder Then
            ' Use solid line - faster than dotted line
            grid.Model.TableStyle.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, SystemColors.Control, GridBorderWeight.Thin)
            grid.Model.TableStyle.Borders.Right = New GridBorder(GridBorderStyle.Solid, SystemColors.Control, GridBorderWeight.Thin)
            ' No border at all is of course faster.
        Else
            grid.Model.TableStyle.Borders.All = GridBorder.Empty 'new GridBorder(GridBorderStyle.Dotted, SystemColors.ControlLight, GridBorderWeight.Thin);//GridBorder.Empty;
        End If
        If Not showHeaders Then
            grid.Model.HideRows(0) = True
            grid.Model.HideCols(0) = True
        End If

        highlightColumn = -3
        Me.grid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Dim clientSize As Size = Me.ClientSize
        clientSize.Height -= statusBar1.Height
        Me.grid.Location = New Point(Me.Location.X + 10, Me.Location.Y + 10)
		clientHeight = 14 * Me.grid.DefaultRowHeight
		Me.grid.Size = New Size(Me.Size.Width - 30, clientHeight)
		Me.Size = New Size(Me.Size.Width, Me.grid.Size.Height + Me.statusBar1.Height + 75)
        Me.grid.HScrollPixel = True
        Me.grid.VScrollPixel = True
        Me.grid.HorizontalThumbTrack = True
        Me.grid.VerticalThumbTrack = True
        Me.grid.TableStyle.Enabled = False
        grid.Model.Options.NumberedRowHeaders = False
        grid.Model.Options.NumberedColHeaders = False
        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch ex As Exception

        End Try
       
        Dim style As GridStyleInfo = grid.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        style.Borders.All = New GridBorder(GridBorderStyle.Solid, Color.LightGray, GridBorderWeight.Thin)
        Me.grid.ThemesEnabled = True
        Me.grid.GridVisualStyles = GridVisualStyles.Metro
        Me.grid.DefaultRowHeight = 18
        Me.grid.DefaultColWidth = 70
        Me.grid.Properties.GridLineColor = System.Drawing.Color.Silver
        Me.grid.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.Controls.Add(Me.grid)
        Me.model = New Model(10, 10)
        SynchronizeModel()

        Me.timer = New System.Windows.Forms.Timer()
        Me.timer.Interval = timerInterval
        AddHandler Me.timer.Tick, AddressOf Me.OnUpdate
        Me.timer.Start()

        grid.Refresh()
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


    Private total As Integer = 0
    Private count As Integer = 0
    Private valueCounter As Integer = 0
    Private highlightColumn As Integer = 0
    Private countInBatch As Integer = 0


    Sub SynchronizeModel()
        grid.Model.RowCount = Me.model.Rows
        grid.Model.ColCount = Me.model.Cols
        Dim col As Integer
        For col = 0 To model.Cols - 1
            Dim backColor As Color = SystemColors.Window
            If Math.Abs(col - Me.highlightColumn) < 2 Then
                backColor = Color.Red
            End If
            Dim interior As New BrushInfo(backColor)

            Dim row As Integer
            For row = 0 To model.Rows - 1
                If Me.transpose Then
                    grid.Model(row + 1, col + 1).CellValue = valueCounter + model(row, col)
                Else
                    grid.Model(row + 1, col + 1).CellValue = valueCounter + model(col, row)
                End If
                grid.Model(row + 1, col + 1).Interior = interior
            Next row
        Next col
        valueCounter = valueCounter + 1
        If valueCounter > 10000 Then
            Application.Exit()
        End If
    End Sub 'SynchronizeModel
    Private updateCount As Integer = 0


    Private Sub OnUpdate(ByVal sender As Object, ByVal args As EventArgs)
        Dim allocateIro As Boolean = True
        updateCount += 1
        Dim t As Integer = Environment.TickCount
        Dim n As Integer

        ' Changing cells
        For n = 0 To iterationsPerUpdate - 1
            highlightColumn = (highlightColumn + 1) Mod (grid.Model.ColCount + 1)
            Me.transpose = Not Me.transpose
            SynchronizeModel()
            Me.grid.InvalidateRange(grid.ViewLayout.VisibleCellsRange)
            Me.grid.Update()
            count += 1
            countInBatch += 1
            If sleep > 0 Then
                Thread.Sleep(sleep)
            End If
        Next n
        If insertRemoveInterval > 0 AndAlso updateCount Mod insertRemoveInterval = 0 Then
            Dim rows As Integer = grid.Model.RowCount / 3

            ' Inserting a row
            For n = 0 To rows - 1
                If allocateIro Then
                    Dim iro As New GridModelInsertRangeOptions()
                    iro.Data = New GridStyleInfoStoreTable(1, grid.Model.ColCount + 1)
                    iro.RowColSizes = New Integer() {grid.Model.Rows.DefaultSize}
                    iro.RowColHide = New Boolean() {False}
                    Dim c As Integer
                    For c = 1 To grid.Model.ColCount
                        iro.Data(0, c) = New GridStyleInfoStore()
                        iro.Data(0, c).SetValue(GridStyleInfoStore.CellValueProperty, n + 1)
                    Next c
                    grid.Model.Rows.InsertRange(1, 1, iro)
                Else
                    ' Not much performance diff between GridModelInsertRangeOptions and modifying values directly,
                    grid.BeginUpdate(Syncfusion.Windows.Forms.BeginUpdateOptions.InvalidateAndScroll)
                    grid.Model.Rows.InsertRange(1, 1)
                    Dim c As Integer
                    For c = 1 To grid.Model.ColCount
                        grid.Model(1, c).CellValue = n + 1
                    Next c
                    grid.EndUpdate(True)
                End If
                count += 1
                countInBatch += 1
                Me.grid.Update()
                If sleep > 0 Then
                    Thread.Sleep(sleep)
                End If
            Next n
            Dim cols As Integer = grid.Model.ColCount / 3

            ' Inserting columns
            For n = 0 To cols - 1
                If allocateIro Then
                    Dim iro As New GridModelInsertRangeOptions()
                    iro.Data = New GridStyleInfoStoreTable(grid.Model.RowCount + 1, 1)
                    iro.RowColSizes = New Integer() {grid.Model.Cols.DefaultSize}
                    iro.RowColHide = New Boolean() {False}
                    Dim r As Integer
                    For r = 1 To grid.Model.RowCount
                        iro.Data(r, 0) = New GridStyleInfoStore()
                        iro.Data(r, 0).SetValue(GridStyleInfoStore.CellValueProperty, n + 1)
                    Next r
                    grid.Model.Cols.InsertRange(1, 1, iro)
                Else
                    ' Not much performance diff between GridModelInsertRangeOptions and modifying values directly,
                    grid.BeginUpdate(Syncfusion.Windows.Forms.BeginUpdateOptions.InvalidateAndScroll)
                    grid.Model.Cols.InsertRange(1, 1)
                    Dim r As Integer
                    For r = 1 To grid.Model.RowCount
                        grid.Model(r, 1).CellValue = n + 1
                    Next r
                    grid.EndUpdate(True)
                End If
                Me.grid.Update()
                If sleep > 0 Then
                    Thread.Sleep(sleep)
                End If
                count += 1
                countInBatch += 1
            Next n

            ' Removing columns
            For n = 0 To cols - 1
                grid.Model.Cols.RemoveRange(1, 1)
                Me.grid.Update()
                If sleep > 0 Then
                    Thread.Sleep(sleep)
                End If
                count += 1
                countInBatch += 1
            Next n


            ' Removing a row
            For n = 0 To rows - 1
                grid.Model.Rows.RemoveRange(1, 1)
                Me.grid.Update()
                If sleep > 0 Then
                    Thread.Sleep(sleep)
                End If
                count += 1
                countInBatch += 1
            Next n
        End If



        Dim ticks As Integer = Environment.TickCount - t
        total += ticks

        If updateCount Mod 5 = 0 Then
            Dim avg As Single = total * 1.0F / countInBatch - sleep
            Me.refreshCountPanel.Text = "Refresh Count = " + count.ToString()
            Me.averageTicksPanel.Text = "Average Ticks = " + avg.ToString()


            If Math.Abs(Fix(avg) + 10 - Me.timer.Interval) > 25 Then
                Me.timer.Interval = Math.Max(Fix(avg) + 10, Me.timerInterval)
            End If
            total = 0
            countInBatch = 0
        End If
    End Sub 'OnUpdate


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.statusBar1 = New System.Windows.Forms.StatusBar
        Me.refreshCountPanel = New System.Windows.Forms.StatusBarPanel
        Me.tickCountPanel = New System.Windows.Forms.StatusBarPanel
        Me.averageTicksPanel = New System.Windows.Forms.StatusBarPanel
        CType(Me.refreshCountPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tickCountPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.averageTicksPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusBar1
        '
        Me.statusBar1.Location = New System.Drawing.Point(0, 544)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.refreshCountPanel, Me.tickCountPanel, Me.averageTicksPanel})
        Me.statusBar1.ShowPanels = True
        Me.statusBar1.Size = New System.Drawing.Size(792, 22)
        Me.statusBar1.TabIndex = 0
        '
        'refreshCountPanel
        '
        Me.refreshCountPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.refreshCountPanel.Name = "refreshCountPanel"
        Me.refreshCountPanel.Width = 258
        '
        'tickCountPanel
        '
        Me.tickCountPanel.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.tickCountPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.tickCountPanel.Name = "tickCountPanel"
        Me.tickCountPanel.Width = 258
        '
        'averageTicksPanel
        '
        Me.averageTicksPanel.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.averageTicksPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.averageTicksPanel.Name = "averageTicksPanel"
        Me.averageTicksPanel.Text = "statusBarPanel1"
        Me.averageTicksPanel.Width = 258
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 15)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.statusBar1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refresh Grid Demo"
        CType(Me.refreshCountPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tickCountPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.averageTicksPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub 'Form1_Load


    Private Sub grid_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridPrepareViewStyleInfoEventArgs)
        ' Highlight columns
        If Math.Abs(e.ColIndex - Me.highlightColumn) < 2 AndAlso e.ColIndex <> e.RowIndex Then
            e.Style.BackColor = Color.Red
        End If
    End Sub 'grid_PrepareViewStyleInfo
End Class 'Form1
