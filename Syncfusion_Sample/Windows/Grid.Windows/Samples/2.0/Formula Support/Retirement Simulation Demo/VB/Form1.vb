Imports Microsoft.VisualBasic
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
Imports System.Globalization
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid


''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private tabBarSplitterControl1 As Syncfusion.Windows.Forms.TabBarSplitterControl
    Private tabBarPage1 As Syncfusion.Windows.Forms.TabBarPage
    Private tabBarPage2 As Syncfusion.Windows.Forms.TabBarPage
    Private gridDisplay As Syncfusion.Windows.Forms.Grid.GridControl
    Private gridCalculations As Syncfusion.Windows.Forms.Grid.GridControl
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
    End Sub

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
        Me.tabBarSplitterControl1 = New Syncfusion.Windows.Forms.TabBarSplitterControl
        Me.tabBarPage1 = New Syncfusion.Windows.Forms.TabBarPage
        Me.gridDisplay = New Syncfusion.Windows.Forms.Grid.GridControl
        Me.tabBarPage2 = New Syncfusion.Windows.Forms.TabBarPage
        Me.gridCalculations = New Syncfusion.Windows.Forms.Grid.GridControl
        Me.tabBarSplitterControl1.SuspendLayout()
        Me.tabBarPage1.SuspendLayout()
        CType(Me.gridDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBarPage2.SuspendLayout()
        CType(Me.gridCalculations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabBarSplitterControl1
        '
        Me.tabBarSplitterControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage1)
        Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage2)
        Me.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText
        Me.tabBarSplitterControl1.Location = New System.Drawing.Point(12, 13)
        Me.tabBarSplitterControl1.Name = "tabBarSplitterControl1"
        Me.tabBarSplitterControl1.Size = New System.Drawing.Size(675, 391)
        Me.tabBarSplitterControl1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Metro
        Me.tabBarSplitterControl1.TabFolderDelta = 11
        Me.tabBarSplitterControl1.TabIndex = 0
        Me.tabBarSplitterControl1.Text = "tabBarSplitterControl1"
        Me.tabBarSplitterControl1.ThemesEnabled = True
        '
        'tabBarPage1
        '
        Me.tabBarPage1.Controls.Add(Me.gridDisplay)
        Me.tabBarPage1.Location = New System.Drawing.Point(0, 0)
        Me.tabBarPage1.Name = "tabBarPage1"
        Me.tabBarPage1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control
        Me.tabBarPage1.Text = "Display"
        Me.tabBarPage1.ThemesEnabled = True
        '
        'gridDisplay
        '
        Me.gridDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridDisplay.ColCount = 15
        Me.gridDisplay.DefaultRowHeight = 25
        Me.gridDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridDisplay.FillSplitterPane = True
        Me.gridDisplay.Location = New System.Drawing.Point(0, 0)
        Me.gridDisplay.Name = "gridDisplay"
        Me.gridDisplay.Properties.ColHeaders = False
        Me.gridDisplay.Properties.DisplayHorzLines = False
        Me.gridDisplay.Properties.DisplayVertLines = False
        Me.gridDisplay.Properties.MarkColHeader = False
        Me.gridDisplay.Properties.MarkRowHeader = False
        Me.gridDisplay.Properties.RowHeaders = False
        Me.gridDisplay.RowCount = 30
        Me.gridDisplay.Size = New System.Drawing.Size(658, 374)
        Me.gridDisplay.SmartSizeBox = False
        Me.gridDisplay.Text = "gridControl1"
        Me.gridDisplay.ThemesEnabled = True
        '
        'tabBarPage2
        '
        Me.tabBarPage2.Controls.Add(Me.gridCalculations)
        Me.tabBarPage2.Location = New System.Drawing.Point(0, 0)
        Me.tabBarPage2.Name = "tabBarPage2"
        Me.tabBarPage2.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control
        Me.tabBarPage2.Text = "Calculations"
        Me.tabBarPage2.ThemesEnabled = True
        '
        'gridCalculations
        '
        Me.gridCalculations.ColCount = 15
        Me.gridCalculations.FillSplitterPane = True
        Me.gridCalculations.Location = New System.Drawing.Point(0, 0)
        Me.gridCalculations.Name = "gridCalculations"
        Me.gridCalculations.RowCount = 50
        Me.gridCalculations.Size = New System.Drawing.Size(656, 372)
        Me.gridCalculations.SmartSizeBox = False
        Me.gridCalculations.Text = "gridControl2"
        Me.gridCalculations.ThemesEnabled = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(699, 416)
        Me.Controls.Add(Me.tabBarSplitterControl1)
        Me.DropShadow = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retirement Simulation Demo"
        Me.tabBarSplitterControl1.ResumeLayout(False)
        Me.tabBarPage1.ResumeLayout(False)
        CType(Me.gridDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBarPage2.ResumeLayout(False)
        CType(Me.gridCalculations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
Shared Sub Main()
        Application.Run(New Form1())
    End Sub


    Private helperList As Hashtable = Nothing
#Region "Event Handler"
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'helper class to mark headers/row on a the calculation sheet
        Dim helper As New GridMarkHeadersHelper(Me.gridCalculations)
        helper.RegisterGridForContextMenu(Me.gridDisplay)

        Me.helperList = New Hashtable()
        Me.helperList.Add(Me.gridCalculations, helper)

        'register grids for multisheeted use
        Dim sheetFamilyID As Integer = GridFormulaEngine.CreateSheetFamilyID()
        GridFormulaEngine.RegisterGridAsSheet("Display", Me.gridDisplay.Model, sheetFamilyID)
        GridFormulaEngine.RegisterGridAsSheet("Calc", Me.gridCalculations.Model, sheetFamilyID)

        SetUpDisplaySheet()

        SetUpCalcSheet()

        SetUpNamedRanges()

        'setup copying formulas
        Dim engine As GridFormulaEngine = (CType(Me.gridCalculations.CellModels("FormulaCell"), GridFormulaCellModel)).Engine
        engine.FormulaCopyFlags = engine.FormulaCopyFlags Or GridFormulaCopyFlags.ClipBoardFormula

        'make sure calc grid has current cell
        Me.tabBarPage2.ActiveControl = Me.gridCalculations
        Me.gridCalculations.CurrentCell.MoveTo(1, 1)

        'bring up form on grid in first tab
        Me.tabBarSplitterControl1.ActivePage = Me.tabBarPage1
        Me.tabBarPage1.ActiveControl = Me.gridDisplay
        Me.gridDisplay.CurrentCell.MoveTo(5, 5)
        Me.gridDisplay.Refresh()
        'subscribe to TabBar events to handle splitters generating new grids
        AddHandler tabBarSplitterControl1.PaneCreated, AddressOf tabBar_PaneCreated
        AddHandler tabBarSplitterControl1.PaneClosing, AddressOf tabBar_PaneClosing
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
        Me.gridDisplay.DefaultRowHeight = 25
        Me.gridCalculations.DefaultColWidth = 70
        Me.gridCalculations.Properties.GridLineColor = System.Drawing.Color.Silver
        Me.gridCalculations.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridCalculations.ThemesEnabled = False
        Me.Text = "Retirement Simulation Demo"
        Me.gridCalculations.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridCalculations.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridCalculations.ThemesEnabled = True
        Me.gridCalculations.MarkColHeader = True
        Me.gridCalculations.MarkRowHeader = True
        Me.gridCalculations.AlphaBlendSelectionColor = Color.Orange
        Me.gridCalculations.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Dim style As GridStyleInfo = gridCalculations.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridDisplay.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDisplay.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        AddHandler Me.gridDisplay.PrepareViewStyleInfo, AddressOf gridDisplay_PrepareViewStyleInfo
        style = gridDisplay.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.tabBarSplitterControl1.ThemesEnabled = True
    End Sub
    Private Sub tabBar_PaneCreated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs)
        Dim grid As GridControl = TryCast(e.Control, GridControl)
        Dim helper As New GridMarkHeadersHelper(grid)
        helperList.Add(grid, helper)
    End Sub
    Private Sub gridDisplay_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        e.Style.Borders.All = GridBorder.Empty
    End Sub

    Private Sub tabBar_PaneClosing(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs)
        Dim grid As GridControl = TryCast(e.Control, GridControl)
        Dim helper As GridMarkHeadersHelper = TryCast(Me.helperList(grid), GridMarkHeadersHelper)
        If helper IsNot Nothing Then
            Me.helperList.Remove(grid)
            helper.Dispose()
            helper = Nothing
        End If
    End Sub
#End Region
#Region "Method"
    Private Function GetIconFile(ByVal bitmapName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(bitmapName) Then
                Return bitmapName
            End If

            bitmapName = "..\" & bitmapName
        Next n

        Return bitmapName
    End Function
#End Region

#Region "DisplaySheet"

    Private Sub SetUpNamedRanges()
        'just so we can list the ranges (in order) at the end of the method
        Dim tempList As New ArrayList()

        Dim engine As GridFormulaEngine = (CType(Me.gridCalculations.CellModels("FormulaCell"), GridFormulaCellModel)).Engine
        Dim col As String = "Display!B"

        Dim row As Integer = 6
        engine.AddNamedRange("InitialYear", String.Format("{0}{1}", col, row))
        tempList.Add("InitialYear")
        row += 1
        engine.AddNamedRange("InitialAgeSpouse1", String.Format("{0}{1}", col, row))
        tempList.Add("InitialAgeSpouse1")
        row += 1
        engine.AddNamedRange("InitialAgeSpouse2", String.Format("{0}{1}", col, row))
        tempList.Add("InitialAgeSpouse2")
        row += 1
        engine.AddNamedRange("InitialSavingsBalance", String.Format("{0}{1}", col, row))
        tempList.Add("InitialSavingsBalance")
        row += 1
        engine.AddNamedRange("ReturnPercentage1", String.Format("{0}{1}", col, row))
        tempList.Add("ReturnPercentage1")
        row += 1
        engine.AddNamedRange("ReturnVolatility1", String.Format("{0}{1}", col, row))
        tempList.Add("ReturnVolatility1")
        row += 1
        engine.AddNamedRange("ReturnPercentage2", String.Format("{0}{1}", col, row))
        tempList.Add("ReturnPercentage2")
        row += 1
        engine.AddNamedRange("ReturnVolatility2", String.Format("{0}{1}", col, row))
        tempList.Add("ReturnVolatility2")
        row += 1
        engine.AddNamedRange("IncomeCOLA", String.Format("{0}{1}", col, row))
        tempList.Add("IncomeCOLA")
        row += 1
        engine.AddNamedRange("ExpenseCOLA", String.Format("{0}{1}", col, row))
        tempList.Add("ExpenseCOLA")
        row += 1
        engine.AddNamedRange("SSAgeSpouse1", String.Format("{0}{1}", col, row))
        tempList.Add("SSAgeSpouse1")
        row += 1
        engine.AddNamedRange("SSAgeSpouse2", String.Format("{0}{1}", col, row))
        tempList.Add("SSAgeSpouse2")
        row += 1
        engine.AddNamedRange("SSInitialAmountSpouse1", String.Format("{0}{1}", col, row))
        tempList.Add("SSInitialAmountSpouse1")
        row += 1
        engine.AddNamedRange("SSInitialPercentageSpouse2", String.Format("{0}{1}", col, row))
        tempList.Add("SSInitialPercentageSpouse2")
        row += 1
        engine.AddNamedRange("Spouse1Dies", String.Format("{0}{1}", col, row))
        tempList.Add("Spouse1Dies")
        row += 1
        engine.AddNamedRange("Spouse1Retires", String.Format("{0}{1}", col, row))
        tempList.Add("Spouse1Retires")
        row += 1
        engine.AddNamedRange("InitialAnnualDraw", String.Format("{0}{1}", col, row))
        tempList.Add("InitialAnnualDraw")
        row += 1
        engine.AddNamedRange("RandomBehavior", String.Format("{0}{1}", col, row))
        tempList.Add("RandomBehavior")

        'the trigger cell used in simulation run
        engine.AddNamedRange("TriggerCell", String.Format("Display!C11", col, row))


        'just display named values
        'row = 2;
        'foreach(string key in tempList)
        '{
        '    this.gridCalculations[row, 1].Text = key;
        '    this.gridCalculations[row, 2].Text = string.Format("= {0}", engine.NamedRanges[key.ToUpper()]);
        '    row++;
        '}


    End Sub

    Private Sub SetUpDisplaySheet()
        Dim row As Integer = 2
        Dim col As Integer = 1

        'some general settings
        Me.gridDisplay.ColWidths(col) = 220
        Me.gridDisplay.TableStyle.Enabled = False
        Me.gridDisplay.TableStyle.Font.Facename = "Arial"
        Me.gridDisplay.EnterKeyBehavior = GridDirectionType.Down

        '			#Region "inputs"
        'main title
        Me.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col, row, col + 4))
        Dim style As GridStyleInfo = Me.gridDisplay(row, col)
        style.Text = "Retirement Calculator"
        style.Font.Size = 14.0F
        style.Font.Bold = True
        style.HorizontalAlignment = GridHorizontalAlignment.Center
        Me.gridDisplay.RowHeights(row) = 25

        'inputs
        row += 1
        Me.gridDisplay.RowHeights(row) = 10
        row += 1
        'this.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col, row, col + 1));
        style = Me.gridDisplay(row, col)
        style.Text = "Inputs"
        style.Font.Size = 10.0F
        'style.Font.Bold = true;
        style.Font.Underline = True
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        'results
        'this.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col + 3, row, col + 4));
        style = Me.gridDisplay(row, col + 2)
        style.Text = "Results"
        style.Font.Size = 10.0F
        'style.Font.Bold = true;
        style.Font.Underline = True
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        'Initial Year
        row += 1
        Me.gridDisplay.RowHeights(row) = 5
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "Initial Year:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "2004"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'Initial Age spouse1
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "Initial Age spouse1:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "56"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'Initial Age spouse2
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "Initial Age spouse2:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "46"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'Initial savings balance
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "Initial savings balance:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "400000"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'return percentage1
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "return percentage1:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "8"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'return volatility1
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "return volatility1:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "10"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'return percentage2
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "return percentage2:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "4"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'return volatility2
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "return volatility2:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "3"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'income COLA
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "income COLA:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "3"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'expense COLA
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "expense COLA:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "3"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'SS age spouse1
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "SS age spouse1:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "63"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'SS age spouse2
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "SS age spouse2:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "63"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'SS initial amount (per month) spouse1
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "SS initial amount (per month) spouse1:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "1300"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'SS initial amount (% of spouse1) spouse2
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "SS initial amount (% of spouse1) spouse2:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "75"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'SS spouse1 dies
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "spouse1 dies:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "71"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'SS spouse1 retires
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "spouse1 retires:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "60"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'Initial Annual Draw
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "initial Annual Draw:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Double)
        style.Text = "50000"
        style.Format = "#,##0.00"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        'Random Behavior
        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "random behavior:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.CellValueType = GetType(Integer)
        style.CellValue = 1
        style.Format = "0"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        '			#End Region

        'set up results

        'Initial Year
        row = 6
        col = 3

        Me.gridDisplay.ColWidths(col) = 120
        style = Me.gridDisplay(row, col)
        style.Text = "Go Broke year:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "=Calc!A2"
        style.CellType = "FormulaCell"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "Spouse1 Age:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "=Calc!A3"
        style.CellType = "FormulaCell"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = "Spouse2 Age:"
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = "=Calc!A4"
        style.CellType = "FormulaCell"
        style.Font.Bold = True
        style.Enabled = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        row += 3
        Me.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col, row, col + 1))
        style = Me.gridDisplay(row, col)
        style.Enabled = True
        style.BorderMargins.Left = 30
        style.BorderMargins.Right = 20
        style.CellType = "PushButton"
        style.Description = "Probabilities"
        AddHandler gridDisplay.PushButtonClick, AddressOf gridDisplay_PushButtonClick

        row += 1
        row10 = row
        style = Me.gridDisplay(row, col)
        style.Text = ">= 10 years:"
        style.Enabled = False
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = ""
        style.Font.Bold = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = ">= 20 years:"
        style.Enabled = False
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = ""
        style.Font.Bold = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = ">= 30 years:"
        style.Enabled = False
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = ""
        style.Font.Bold = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        row += 1
        style = Me.gridDisplay(row, col)
        style.Text = ">= 40 years:"
        style.Enabled = False
        style.HorizontalAlignment = GridHorizontalAlignment.Right

        style = Me.gridDisplay(row, col + 1)
        style.Text = ""
        style.Font.Bold = True
        style.HorizontalAlignment = GridHorizontalAlignment.Left

        style = Me.gridDisplay(row, col + 1)
        style.Text = ""
        style.CellType = "FormulaCell"
        style.Font.Bold = True
        '	style.Enabled = true;
        style.HorizontalAlignment = GridHorizontalAlignment.Left

    End Sub

    Private row10 As Integer
    Private Sub gridDisplay_PushButtonClick(ByVal sender As Object, ByVal e As GridCellPushButtonClickEventArgs)
        Dim numTrials As Integer = 100

        Dim count10 As Integer = 0
        Dim count20 As Integer = 0
        Dim count30 As Integer = 0
        Dim count40 As Integer = 0

        Dim col As Integer = 4
        Dim currentAge As Integer = Integer.Parse(Me.gridDisplay(7, 2).Text)
        Dim retireAge As Integer = Integer.Parse(Me.gridDisplay(21, 2).Text)
        Dim row As Integer = 2 + retireAge - currentAge

        Dim d As Double
        Dim s As String

        Me.gridDisplay.ConfirmChanges()

        Dim progressBarEx1 As GridProgressBarInfo = SetProgressBar(row10 + 4, col - 1)

        Dim start As DateTime = DateTime.Now
        Me.Cursor = Cursors.WaitCursor
        For i As Integer = 0 To numTrials - 1
            Me.gridDisplay(e.RowIndex, e.ColIndex).CellValue = 0
            s = Me.gridCalculations(row + 10, col).FormattedText
            If Double.TryParse(s, NumberStyles.Any, Nothing, d) AndAlso d > 0 Then
                count10 += 1
            End If
            s = Me.gridCalculations(row + 20, col).FormattedText
            If Double.TryParse(s, NumberStyles.Any, Nothing, d) AndAlso d > 0 Then
                count20 += 1
            End If
            s = Me.gridCalculations(row + 30, col).FormattedText
            If Double.TryParse(s, NumberStyles.Any, Nothing, d) AndAlso d > 0 Then
                count30 += 1
            End If
            s = Me.gridCalculations(row + 40, col).FormattedText
            If Double.TryParse(s, NumberStyles.Any, Nothing, d) AndAlso d > 0 Then
                count40 += 1
            End If
            'System.Threading.Thread.Sleep(0);
            If i Mod 10 = 0 Then
                progressBarEx1.ProgressValue = i
            End If
            Application.DoEvents()
        Next i
        Me.Cursor = Cursors.Default


        Me.gridDisplay(row10, col).Text = String.Format("{0:P2}", (CSng(count10)) / numTrials)
        Me.gridDisplay(row10 + 1, col).Text = String.Format("{0:P2}", (CSng(count20)) / numTrials)
        Me.gridDisplay(row10 + 2, col).Text = String.Format("{0:P2}", (CSng(count30)) / numTrials)
        Me.gridDisplay(row10 + 3, col).Text = String.Format("{0:P2}", (CSng(count40)) / numTrials)

        Me.gridDisplay(row10 + 4, col - 1).CellType = "Static"
        Me.gridDisplay(row10 + 4, col - 1).Font.Bold = True

        Me.gridDisplay(row10 + 4, col - 1).Text = String.Format("{0} runs in {1}", numTrials, DateTime.Now.Subtract(start))
    End Sub


    Private Function SetProgressBar(ByVal row As Integer, ByVal col As Integer) As GridProgressBarInfo
        Dim style1 As GridStyleInfo = Me.gridDisplay(row, col)

        Me.gridDisplay.CoveredRanges.Add(GridRangeInfo.Cells(row, col, row, col + 1))
        style1.BorderMargins.Left = 30
        style1.BorderMargins.Right = 20

        Dim progressBarEx1 As GridProgressBarInfo = style1.ProgressBar
        progressBarEx1.BeginUpdate()
        progressBarEx1.ProgressValue = 0

        style1.CellType = "ProgressBar"
        style1.Themed = False
        'style1.CellAppearance = GridCellAppearance.Raised;

        progressBarEx1.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight
        progressBarEx1.BackGradientStartColor = System.Drawing.SystemColors.ControlDark
        progressBarEx1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
        progressBarEx1.BackMultipleColors = New System.Drawing.Color() {System.Drawing.SystemColors.ControlDark, System.Drawing.SystemColors.ControlLightLight, System.Drawing.SystemColors.Control}

        progressBarEx1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
        progressBarEx1.SegmentWidth = 10
        progressBarEx1.StretchImage = False
        progressBarEx1.StretchMultGrad = False
        progressBarEx1.TextShadow = False
        progressBarEx1.TubeEndColor = System.Drawing.SystemColors.Control
        progressBarEx1.TubeStartColor = Color.Blue 'System.Drawing.SystemColors.ControlDark;
        progressBarEx1.EndUpdate()
        Return progressBarEx1
    End Function

#End Region

#Region "CalculationSheet"

    Private Sub SetUpCalcSheet()
        '
        Dim row As Integer = 1
        Dim col As Integer = 3

        Dim colWithdrawal As String = GridRangeInfo.GetAlphaLabel(col)
        Dim colBalance As String = GridRangeInfo.GetAlphaLabel(col + 1)
        Dim colInvRate As String = GridRangeInfo.GetAlphaLabel(col + 2)
        Dim colYear As String = GridRangeInfo.GetAlphaLabel(col + 3)
        Dim colAge1 As String = GridRangeInfo.GetAlphaLabel(col + 4)
        Dim colAge2 As String = GridRangeInfo.GetAlphaLabel(col + 5)
        Dim colSS1 As String = GridRangeInfo.GetAlphaLabel(col + 6)
        Dim colSS2 As String = GridRangeInfo.GetAlphaLabel(col + 7)
        Dim colBroke As String = GridRangeInfo.GetAlphaLabel(col + 8)
        Dim colRand As String = GridRangeInfo.GetAlphaLabel(col + 9)



        'row 1
        Me.gridCalculations(row, col).Text = "Withdrawal Jan 1"
        Me.gridCalculations(row, col + 1).Text = "Balance Jan 2"
        Me.gridCalculations(row, col + 2).Text = "Inv Return Rate"
        Me.gridCalculations(row, col + 3).Text = "Year"
        Me.gridCalculations(row, col + 4).Text = "Age spouse 1"
        Me.gridCalculations(row, col + 5).Text = "Age spouse 2"
        Me.gridCalculations(row, col + 6).Text = "SS spouse 1"
        Me.gridCalculations(row, col + 7).Text = "SS spouse 2"
        Me.gridCalculations(row, col + 8).Text = "Broke Year"
        Me.gridCalculations(row, col + 9).Text = "Random #"


        'row 2
        row += 1
        Me.gridCalculations(row, col).Text = "0.00" 'assumes spouse1 is not retired at the start
        Me.gridCalculations(row, col + 1).Text = "= InitialSavingsBalance"
        Me.gridCalculations(row, col + 2).Text = String.Format("= (100+ReturnPercentage1+(1-2*{2}{1})*ReturnVolatility1)/100 * ({0}{1} < Spouse1Retires ) + (100+ReturnPercentage2+(1-2*{2}{1})*ReturnVolatility2)/100 * ({0}{1} >= Spouse1Retires ) ", colAge1, row, colRand)
        Me.gridCalculations(row, col + 3).Text = "= InitialYear"
        Me.gridCalculations(row, col + 4).Text = "= InitialAgeSpouse1"
        Me.gridCalculations(row, col + 5).Text = "= InitialAgeSpouse2"
        Me.gridCalculations(row, col + 6).Text = "0.00"
        Me.gridCalculations(row, col + 7).Text = "0.00"
        Me.gridCalculations(row, col + 8).Text = "0.00"
        Me.gridCalculations(row, col + 9).Text = "= TriggerCell + (1-RandomBehavior)/2" 'always zero but used to trigger new random run


        For i As Integer = row + 1 To Me.gridCalculations.RowCount - 1
            Me.gridCalculations(i, col).Text = String.Format("= (100+(1-2*{4}{1})+ExpenseCOLA)/100 * {0}{1} + ({2}{3}=Spouse1Retires) * InitialAnnualDraw", colWithdrawal, i - 1, colAge1, i, colRand)
            Me.gridCalculations(i, col + 1).Text = String.Format("=  {0}{1} * {2}{1}  - {3}{4} + ({5}{1} < Spouse1Dies) *  {6}{1} + {7}{1}", colBalance, i - 1, colInvRate, colWithdrawal, i, colAge1, colSS1, colSS2)


            Me.gridCalculations(i, col + 2).Text = String.Format("= (100+ReturnPercentage1+(1-2*{2}{1})*ReturnVolatility1)/100 * ({0}{1} < Spouse1Retires ) + (100+ReturnPercentage2+(1-2*{2}{1})*ReturnVolatility2)/100 * ({0}{1} >= Spouse1Retires ) ", colAge1, i, colRand)

            Me.gridCalculations(i, col + 3).Text = String.Format("= {0}{1} + 1", colYear, i - 1)
            Me.gridCalculations(i, col + 4).Text = String.Format("= {0}{1} + 1", colAge1, i - 1)
            Me.gridCalculations(i, col + 5).Text = String.Format("= {0}{1} + 1", colAge2, i - 1)
            Me.gridCalculations(i, col + 6).Text = String.Format("= (100+IncomeCOLA+(1-2*{3}{1}))/100 * {0}{1} + ({2}{1}=SSAgeSpouse1) * 12 * SSInitialAmountSpouse1", colSS1, i - 1, colAge1, colRand)
            Me.gridCalculations(i, col + 7).Text = String.Format("= (100+IncomeCOLA+(1-2*{5}{1}))/100 * {0}{4} + ({2}{1}=SSAgeSpouse2) * SSInitialPercentageSpouse2/100 * {3}{1}", colSS2, i, colAge2, colSS1, i - 1, colRand)
            Me.gridCalculations(i, col + 8).Text = String.Format("= ({0}{1}<0) * ({0}{2}>=0) * {3}{1}", colBalance, i, i - 1, colYear)
            Me.gridCalculations(i, col + 9).Text = String.Format("= RandomBehavior * Rand() + ${0}${1}", colRand, 2) 'make setting row 2 trigger new Rand's
            'this.gridCalculations[i, 1].Text = string.Format("= d{0}-d{1}", i, i-1); 
        Next i


        'make all cells potential formula cells
        Me.gridCalculations.TableStyle.CellType = "FormulaCell"
        Me.gridCalculations.TableStyle.Format = "#,##0.00"

        'years & age
        Me.gridCalculations.ColStyles(col + 3).Format = "F0"
        Me.gridCalculations.ColStyles(col + 4).Format = "F0"
        Me.gridCalculations.ColStyles(col + 5).Format = "F0"

        'some answers
        Me.gridCalculations(2, 1).Text = String.Format("= Max({0}2:{0}{1})", colBroke, Me.gridCalculations.RowCount - 1)
        Me.gridCalculations(3, 1).Text = String.Format("= SumIf({2}2:{2}{1}, "">0"", {0}2:{0}{1})", colAge1, Me.gridCalculations.RowCount - 1, colBroke)
        Me.gridCalculations(4, 1).Text = "= Max(0, A3 - InitialAgeSpouse1 + InitialAgeSpouse2)"

    End Sub


#End Region

End Class

