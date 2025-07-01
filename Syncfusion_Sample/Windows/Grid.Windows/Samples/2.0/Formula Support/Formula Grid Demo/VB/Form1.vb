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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Globalization

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Styles
Imports System.IO


''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private contextMenu1 As System.Windows.Forms.ContextMenu
    Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Private domainUpDown1 As DomainUpDown
    Private WithEvents button3 As Syncfusion.Windows.Forms.ButtonAdv
    Private checkBox1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
    Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
    Private panel1 As Panel
    Private WithEvents comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Private gridAwareTextBox1 As GridAwareTextBox
    Private gridControl2 As GridControl
    Private panel2 As Panel
    Private textBox1 As GridAwareTextBox
    Private gridControl1 As GridControl
    Private components As System.ComponentModel.IContainer
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        Dim style As GridStyleInfo = Me.gridControl1.BaseStylesMap("Header").StyleInfo
        style.TextColor = System.Drawing.Color.MidnightBlue
        style.Font.Facename = "Verdana"
        style = Me.gridControl1.BaseStylesMap("Standard").StyleInfo
        style.TextColor = System.Drawing.Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.White
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        Try
            Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
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
        Me.components = New System.ComponentModel.Container
        Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
        Me.contextMenu1 = New System.Windows.Forms.ContextMenu
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem2 = New System.Windows.Forms.MenuItem
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.menuItem4 = New System.Windows.Forms.MenuItem
        Me.menuItem5 = New System.Windows.Forms.MenuItem
        Me.menuItem8 = New System.Windows.Forms.MenuItem
        Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.checkBox1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.panel1 = New System.Windows.Forms.Panel
        Me.gridAwareTextBox1 = New Syncfusion.Windows.Forms.Grid.GridAwareTextBox
        Me.gridControl2 = New Syncfusion.Windows.Forms.Grid.GridControl
        Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Me.panel2 = New System.Windows.Forms.Panel
        Me.textBox1 = New Syncfusion.Windows.Forms.Grid.GridAwareTextBox
        Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
        CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contextMenu1
        '
        Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem8})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.Text = "No Formatting"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 1
        Me.menuItem2.Text = "0 places"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 2
        Me.menuItem3.Text = "1 place"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 3
        Me.menuItem4.Text = "2 places"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 4
        Me.menuItem5.Text = "3 places"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 5
        Me.menuItem8.Text = "6 places"
        '
        'button3
        '
        Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.button3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.White
        Me.button3.Location = New System.Drawing.Point(531, 26)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(160, 23)
        Me.button3.TabIndex = 5
        Me.button3.Text = "Find Next Compare Failure"
        Me.button3.UseVisualStyle = True
        '
        'checkBox1
        '
        Me.checkBox1.DrawFocusRectangle = False
        Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox1.Location = New System.Drawing.Point(227, 22)
        Me.checkBox1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(166, 32)
        Me.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
        Me.checkBox1.TabIndex = 3
        Me.checkBox1.Text = "Raw Values in Column A"
        Me.checkBox1.ThemesEnabled = False
        '
        'button2
        '
        Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.button2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Location = New System.Drawing.Point(114, 26)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(97, 23)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Load Grid"
        Me.button2.UseVisualStyle = True
        '
        'button1
        '
        Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
        Me.button1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(12, 26)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 23)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Save Grid"
        Me.button1.UseVisualStyle = True
        '
        'panel1
        '
        Me.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.panel1.Controls.Add(Me.gridAwareTextBox1)
        Me.panel1.Controls.Add(Me.gridControl2)
        Me.panel1.Controls.Add(Me.comboBoxAdv1)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.checkBox1)
        Me.panel1.Controls.Add(Me.button3)
        Me.panel1.Location = New System.Drawing.Point(12, 329)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(745, 314)
        Me.panel1.TabIndex = 8
        '
        'gridAwareTextBox1
        '
        Me.gridAwareTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gridAwareTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window
        Me.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window
        Me.gridAwareTextBox1.Location = New System.Drawing.Point(12, 64)
        Me.gridAwareTextBox1.Name = "gridAwareTextBox1"
        Me.gridAwareTextBox1.Size = New System.Drawing.Size(724, 20)
        Me.gridAwareTextBox1.TabIndex = 9
        '
        'gridControl2
        '
        Me.gridControl2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gridControl2.BackColor = System.Drawing.Color.White
        Me.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridControl2.DefaultRowHeight = 20
        Me.gridControl2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        GridCellInfo1.Col = -1
        GridCellInfo1.Row = -1
        GridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
        GridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        GridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridControl2.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1})
        Me.gridControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl2.Location = New System.Drawing.Point(12, 96)
        Me.gridControl2.MetroScrollBars = True
        Me.gridControl2.Name = "gridControl2"
        Me.gridControl2.Size = New System.Drawing.Size(724, 195)
        Me.gridControl2.SmartSizeBox = False
        Me.gridControl2.TabIndex = 8
        Me.gridControl2.Text = "gridControl2"
        Me.gridControl2.ThemesEnabled = True
        '
        'comboBoxAdv1
        '
        Me.comboBoxAdv1.BackColor = System.Drawing.Color.White
        Me.comboBoxAdv1.Items.AddRange(New Object() {"0.001", "0.0001", "0.00001", "0.000001", "0.0000001", "0.00000001", "0.000000001", "0.0000000001", "0.00000000001"})
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "0.001"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "0.0001"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "0.00001"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "0.000001"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "0.0000001"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "0.00000001"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "0.000000001"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "0.0000000001"))
        Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "0.00000000001"))
        Me.comboBoxAdv1.Location = New System.Drawing.Point(399, 28)
        Me.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.comboBoxAdv1.Name = "comboBoxAdv1"
        Me.comboBoxAdv1.Size = New System.Drawing.Size(121, 21)
        Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
        Me.comboBoxAdv1.TabIndex = 6
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.textBox1)
        Me.panel2.Controls.Add(Me.gridControl1)
        Me.panel2.Location = New System.Drawing.Point(12, 12)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(745, 311)
        Me.panel2.TabIndex = 9
        '
        'textBox1
        '
        Me.textBox1.AcceptsReturn = True
        Me.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.textBox1.DisabledBackColor = System.Drawing.SystemColors.Window
        Me.textBox1.EnabledBackColor = System.Drawing.SystemColors.Window
        Me.textBox1.Location = New System.Drawing.Point(13, 10)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(724, 20)
        Me.textBox1.TabIndex = 6
        '
        'gridControl1
        '
        Me.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gridControl1.ColCount = 15
        Me.gridControl1.ContextMenu = Me.contextMenu1
        Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl1.HorizontalThumbTrack = True
        Me.gridControl1.Location = New System.Drawing.Point(13, 37)
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RowCount = 135
        Me.gridControl1.Size = New System.Drawing.Size(724, 262)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.TabIndex = 5
        Me.gridControl1.Text = "gridControl1"
        Me.gridControl1.ThemesEnabled = True
        Me.gridControl1.VerticalScrollTips = True
        Me.gridControl1.VerticalThumbTrack = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(769, 655)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.DropShadow = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formula Grid Demo"
        CType(Me.checkBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub

    Private formulas As Hashtable
    Private epsilon As Double = 0.00001
    Private format As String = "0.00000"
    Private badCompareColor As Color = Color.FromArgb(&H85, &HBF, &H75)
    Private foundColor As Color = Color.FromArgb(&HFF, &HBF, &H34)
    Private foundRow As Integer = -2
    Private messageBoxShown As Boolean = False
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.gridControl1.RowCount = 150

        '			#Region "Adding a formula to the formula library - step 2"
        'adding formula to the Formula Engine Library
        'step2: call the AddFunction member of the Engine
        Dim model As GridFormulaCellModel = TryCast(Me.gridControl1.CellModels("FormulaCell"), GridFormulaCellModel)

        'add formula name Min to the Library
        model.Engine.AddFunction("Min", New GridFormulaEngine.LibraryFunction(AddressOf ComputeMin))
        '			#End Region

        '			#Region "Initialize grid properties and set formulas & data"

        'set entire grid to allow formulas
        Me.gridControl1.BaseStylesMap("Standard").StyleInfo.CellType = "FormulaCell"
        Me.gridControl1.BaseStylesMap("Standard").StyleInfo.Format = "F2" 'two decimal places
        Me.gridControl1.BaseStylesMap("Standard").StyleInfo.BackColor = Color.FromArgb(&HDA, &HE5, &HF5) 'light blue background

        Me.gridControl1.ColWidths(0) = 30
        Me.gridControl1.ColWidths(1) = 180

        Me.gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation

        'dynamically create a basestyle for each formula title row
        Dim titleRowStyle As GridStyleInfo = Me.gridControl1.BaseStylesMap("TitleRow").StyleInfo
        titleRowStyle.Font.Bold = True
        titleRowStyle.Font.Size = 10
        titleRowStyle.Enabled = False
        titleRowStyle.BackColor = Color.FromArgb(&HFC, &HAC, &H26)
        Dim titleRowHeight As Integer = 20

        Dim introRowStyle As GridStyleInfo = Me.gridControl1.BaseStylesMap("IntroRow").StyleInfo
        introRowStyle.Font.Bold = True
        introRowStyle.Font.Size = 10
        introRowStyle.Font.Facename = "Verdana"
        introRowStyle.Enabled = False
        introRowStyle.BackColor = Color.FromArgb(&HC0, &HC9, &HDB)
        introRowStyle.TextColor = Color.FromArgb(&HDE, &H64, &H13)
        introRowStyle.Borders.Bottom = New GridBorder(GridBorderStyle.None)

        Dim introRowHeight As Integer = 22


        Dim row As Integer = 1
        Dim col As Integer = 1
        Dim blocksize As Integer = 4

        'enter the text for the intro
        Me.gridControl1(row, col).Text = "     Essential Grid has a formula cell type that allows a cell to host a formula. The included formula engine lets you add functions.You have the option of using a formula cell for the whole grid, or just for some grid cells, say a Sum row or Average column. Below are samples using library functions with random data. In the cells below, check things out by entering equals followed by an algebraic expression using +-/* and cell references. Some examples:"
        Me.gridControl1.RowStyles(row).BaseStyle = "IntroRow"
        Me.gridControl1.RowHeights(row) = 50
        Me.gridControl1(row, col).WrapText = True
        Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(row, 1, row, Me.gridControl1.ColCount))

        row += 1

        'enter the text for the intro
        Me.gridControl1(row, col).Text = "        =(E16+E17)/F16"
        Me.gridControl1.RowStyles(row).BaseStyle = "IntroRow"
        Me.gridControl1.RowHeights(row) = introRowHeight
        Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(row, 1, row, Me.gridControl1.ColCount))

        row += 1

        'enter the text for the intro
        Me.gridControl1(row, col).Text = "        =COS((E16+E17)/F16)"
        Me.gridControl1.RowStyles(row).BaseStyle = "IntroRow"
        Me.gridControl1.RowHeights(row) = introRowHeight
        Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(row, 1, row, Me.gridControl1.ColCount))

        Me.gridControl1(1, 0).Text = " "
        Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 0, row, 0))

        'this.gridControl1.Rows.FrozenCount = 8;

        Dim row0 As Integer = 5
        row = row0


        'loop through & get name of all library formulas...
        Dim al As New ArrayList()
        For Each o As Object In model.Engine.LibraryFunctions.Keys
            al.Add(o)
        Next o

        al.Sort()

        'set up a sam[ple block for each library formula
        Dim r As New Random()
        For Each o As Object In al
            Dim s As String = TryCast(o, String)
            If s IsNot Nothing Then
                Me.gridControl1.RowStyles(row).BaseStyle = "TitleRow"
                Me.gridControl1.RowHeights(row) = titleRowHeight
                Me.gridControl1(row, 0).Text = " "
                Me.gridControl1(row, 0).BackColor = Color.FromArgb(238, 122, 3)
                Me.gridControl1(row, 0).CellAppearance = GridCellAppearance.Flat
                Me.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(row, 1, row, Me.gridControl1.ColCount))

                'sample data
                For i As Integer = row + 1 To row + blocksize - 1
                    For j As Integer = col + 4 To col + 8 - 1
                        Me.gridControl1(i, j).CellValue = r.Next(10000)
                    Next j
                Next i

                If s = "AVERAGEA" OrElse s = "AVERAGE" OrElse s = "SUM" OrElse s = "AVG" OrElse s = "MAX" OrElse s = "MIN" OrElse s = "MAXA" OrElse s = "MINA" OrElse s = "AVEDEV" OrElse s = "HARMEAN" OrElse s = "GEOMEAN" OrElse s = "STDEV" OrElse s = "STDEVA" OrElse s = "STDEVP" OrElse s = "STDEVPA" Then 'functions need cell arguments only
                    Me.gridControl1(row, col).Text = s
                    'col 1 & col 2 of first row
                    Dim f As String = String.Format(s & "(E{0}:H{0})", row + 1)
                    Me.gridControl1(row + 1, col).Text = f
                    Me.gridControl1(row + 1, col + 1).Text = "="c & f

                    'col 1 & col 2 of second row
                    f = String.Format(s & "(E{0}:H{0}, E{1}, F{1}, G{1}, H{1})", row + 2, row + 3)
                    Me.gridControl1(row + 2, col).Text = f
                    Me.gridControl1(row + 2, col + 1).Text = "="c & f

                    'col 1 & col 2 of third row
                    f = String.Format(s & "(E{0}:H{0}, E{1}:H{1})", row + 2, row + 3)
                    Me.gridControl1(row + 3, col).Text = f
                    Me.gridControl1(row + 3, col + 1).Text = "="c & f
                ElseIf s = "IF" Then 'functions need three arguments only
                    Me.gridControl1(row, col).Text = s
                    'col 1 & col 2 of first row
                    Dim f As String = String.Format(s & "(E{0},1,0)", row + 1)
                    Me.gridControl1(row + 1, col).Text = f
                    Me.gridControl1(row + 1, col + 1).Text = "="c & f

                    'col 1 & col 2 of second row
                    f = String.Format(s & "(ABS(E{0}-H{0}),1,0)", row + 2)
                    Me.gridControl1(row + 2, col).Text = f
                    Me.gridControl1(row + 2, col + 1).Text = "="c & f

                    'col 1 & col 2 of third row
                    f = String.Format(s & "(SQRT(E{0}),1,0)", row + 3)
                    Me.gridControl1(row + 3, col).Text = f
                    Me.gridControl1(row + 3, col + 1).Text = "="c & f
                ElseIf s = "POW" Then 'functions need two arguments only
                    Me.gridControl1(row, col).Text = s

                    'col 1 & col 2 of first row
                    Dim f As String = String.Format(s & "(E{0},2)", row + 1)
                    Me.gridControl1(row + 1, col).Text = f
                    Me.gridControl1(row + 1, col + 1).Text = "="c & f

                    'col 1 & col 2 of second row
                    f = String.Format(s & "(ABS(E{0}-H{0}), 3)", row + 2)
                    Me.gridControl1(row + 2, col).Text = f
                    Me.gridControl1(row + 2, col + 1).Text = "="c & f

                    'col 1 & col 2 of third row
                    f = String.Format(s & "(SQRT(E{0}),2)", row + 3)
                    Me.gridControl1(row + 3, col).Text = f
                    Me.gridControl1(row + 3, col + 1).Text = "="c & f
                ElseIf s = "PI" Then 'functions need two arguments only
                    Me.gridControl1(row, col).Text = s

                    'col 1 & col 2 of first row
                    Dim f As String = String.Format(s & "()")
                    Me.gridControl1(row + 1, col).Text = f
                    Me.gridControl1(row + 1, col + 1).Text = "="c & f

                    'col 1 & col 2 of second row
                    f = String.Format(s & "()/2")
                    Me.gridControl1(row + 2, col).Text = f
                    Me.gridControl1(row + 2, col + 1).Text = "="c & f

                    'col 1 & col 2 of third row
                    f = String.Format("2 * " & s & "()")
                    Me.gridControl1(row + 3, col).Text = f
                    Me.gridControl1(row + 3, col + 1).Text = "="c & f

                ElseIf s = "ABS" OrElse s = "ACOS" OrElse s = "ACOSH" OrElse s = "ASIN" OrElse s = "ASINH" OrElse s = "ATAN" OrElse s = "ATANH" OrElse s = "COS" OrElse s = "EXP" OrElse s = "LN" OrElse s = "LOG10" OrElse s = "SIN" OrElse s = "SINH" OrElse s = "SQRT" Then
                    Me.gridControl1(row, col).Text = s

                    'sample data
                    For i As Integer = row + 1 To row + blocksize - 1
                        For j As Integer = col + 4 To col + 8 - 1
                            Me.gridControl1(i, j).CellValue = r.Next(10000)
                        Next j
                    Next i

                    'col 1 & col 2 of first row
                    Dim f As String = String.Format(s & "((E{0}-F{0}) / (G{0} + H{0}))", row + 1)
                    Me.gridControl1(row + 1, col).Text = f
                    Me.gridControl1(row + 1, col + 1).Text = "="c & f

                    'col 1 & col 2 of second row
                    f = String.Format(s & "(ABS(E{0}-F{0}))", row + 2)
                    Me.gridControl1(row + 2, col).Text = f
                    Me.gridControl1(row + 2, col + 1).Text = "="c & f

                    'col 1 & col 2 of third row
                    f = String.Format(s & "(E{0})", row + 3)
                    Me.gridControl1(row + 3, col).Text = f
                    Me.gridControl1(row + 3, col + 1).Text = "="c & f
                Else
                    row -= blocksize
                End If

            End If

            row += blocksize
        Next o

        'set up some summary items:
        Dim f1 As String = String.Format("=SUM(E{0}:E{1})", row0, row)
        Me.gridControl1(row + 1, col + 4).Text = f1
        Me.gridControl1(row + 1, col + 4).Borders.Top = New GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Medium)

        f1 = String.Format("=AVG(F{0}:F{1})", row0, row)
        Me.gridControl1(row + 1, col + 5).Text = f1
        Me.gridControl1(row + 1, col + 5).Borders.Top = New GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Medium)

        f1 = String.Format("=MAX(G{0}:G{1})", row0, row)
        Me.gridControl1(row + 1, col + 6).Text = f1
        Me.gridControl1(row + 1, col + 6).Borders.Top = New GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Medium)

        f1 = String.Format("=Min(H{0}:H{1})", row0, row)
        Me.gridControl1(row + 1, col + 7).Text = f1
        Me.gridControl1(row + 1, col + 7).Borders.Top = New GridBorder(GridBorderStyle.Solid, Color.Black, GridBorderWeight.Medium)
        '			#End Region

        'hook the GridAwareTextBox so the EditBar is available
        Me.textBox1.WireGrid(Me.gridControl1)

        Me.gridControl1.Focus()
        Me.gridControl1.CurrentCell.MoveTo(9, 1)
        Me.gridControl1.CommandStack.Enabled = True
        Me.gridControl1.Model.Options.SelectCellsMouseButtonsMask = MouseButtons.Left

        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.DefaultColWidth = 70
        Me.gridControl1.TopRowIndex = 15
        Me.gridControl1.ColStyles(1).Font.Bold = True
        'Gridcontrol2

        Me.gridAwareTextBox1.BackColor = Color.White
        Me.gridAwareTextBox1.WireGrid(Me.gridControl2)
        Me.gridControl2.TableStyle.CellType = "FormulaCell"
        Me.gridControl2.RowCount = 1100
        SetFormatFirstRow()

        Dim engine As GridFormulaEngine = (CType(Me.gridControl2.CellModels("FormulaCell"), GridFormulaCellModel)).Engine
        engine.FormulaCopyFlags = engine.FormulaCopyFlags Or GridFormulaCopyFlags.ClipBoardFormula 'copy formulas and not values
        Me.formulas = TryCast(engine.LibraryFunctions.Clone(), Hashtable)

        Me.formulas.Add("+ OPERATOR", "")
        Me.formulas.Add("- OPERATOR", "")
        Me.formulas.Add("* OPERATOR", "")
        Me.formulas.Add("/ OPERATOR", "")
        Me.formulas.Add("> OPERATOR", "")
        Me.formulas.Add("< OPERATOR", "")
        Me.formulas.Add(" = OPERATOR", "")
        Me.formulas.Add(">= OPERATOR", "")
        Me.formulas.Add("<= OPERATOR", "")
        Me.formulas.Add("<> OPERATOR", "")
        Me.formulas.Add("^ EXPONENT", "")
        Me.formulas.Add("- UNARY MINUS", "")

        AddHandler gridControl2.PrepareViewStyleInfo, AddressOf gridControl2_PrepareViewStyleInfo

        'this.domainUpDown1.SelectedIndex = 3;

        Me.gridControl2.Rows.FrozenCount = 1

        LoadTsvFile(FindFullPath("good.tsv"))

        If Environment.CommandLine.EndsWith("automatedtest") Then
            Dim t As New Timer()
            t.Interval = 100
            AddHandler t.Tick, AddressOf t_Tick
            t.Enabled = True
        End If
        Me.comboBoxAdv1.SelectedIndex = 2
        Me.gridControl2.DefaultRowHeight = 18
        Me.gridControl2.DefaultColWidth = 70
        Me.gridControl1.TopRowIndex = 16

    End Sub

    Private Sub gridControl2_PrepareViewStyleInfo(ByVal sender As Object, ByVal e As GridPrepareViewStyleInfoEventArgs)
        If e.RowIndex = 1 AndAlso e.ColIndex > 0 Then
            e.Style.TextColor = Color.White
        End If
        If e.RowIndex > 1 AndAlso e.ColIndex > 0 Then
            Dim s2 As String = Me.gridControl2(e.RowIndex, 2).Text.Trim()
            If Me.formulas.ContainsKey(s2.ToUpper()) Then
                e.Style.Font.Bold = True
                e.Style.BackColor = Color.FromArgb(&HC4, &HD6, &HE9)

            Else
                s2 = Me.gridControl2(e.RowIndex, 1).Text
                If s2.Length > 0 Then
                    e.Style.BackColor = Color.FromArgb(&HED, &HF0, &HF6)
                End If
            End If
        End If

        If Not Me.checkBox1.Checked Then
            If e.ColIndex = 1 AndAlso e.RowIndex > 1 AndAlso e.Style.Text.Length > 0 Then
                Dim d As Double
                If Double.TryParse(e.Style.FormattedText, NumberStyles.Any, Nothing, d) Then
                    e.Style.Format = Me.format
                    If Math.Abs(d) > Me.epsilon Then
                        e.Style.BackColor = badCompareColor


                    End If
                Else
                    e.Style.BackColor = Color.LightGoldenrodYellow
                End If
            End If
        End If

        If e.RowIndex = foundRow AndAlso e.ColIndex > 0 Then
            e.Style.BackColor = Me.foundColor
        End If
    End Sub

    Private Sub LoadGrdFile(ByVal s As String)
        Try
            Me.gridControl2.BeginUpdate()
            Me.gridControl2.Model = GridModel.LoadBinary(s)
            Me.gridControl2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            SetFormatFirstRow()
            Me.gridControl2.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, 100, 6))
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            Me.gridControl2.EndUpdate()
        End Try
    End Sub

    Private Sub LoadTsvFile(ByVal fileName As String)
        Dim save As String = Me.gridControl2.Model.TextDataExchange.ExportTabDelim
        Try
            Me.gridControl2.Model.TextDataExchange.ImportTabDelim = Constants.vbTab
            Dim reader As New StreamReader(fileName)
            Dim s As String = reader.ReadToEnd()
            reader.Close()
            Me.gridControl2.BeginUpdate()
            'reset grid
            Me.gridControl2.RowCount = 1
            Me.gridControl2.ColCount = 1
            Me.gridControl2.Model.TextDataExchange.PasteTextFromBuffer(s, GridRangeInfo.Cell(1, 1), 0)
            Me.gridControl2.EndUpdate()

            Me.gridControl2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            SetFormatFirstRow()
            Me.gridControl2.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, 100, 6))
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            Me.gridControl2.EndUpdate()
            Me.gridControl2.Model.TextDataExchange.ExportTabDelim = save
        End Try
    End Sub

    Private Sub WriteGrdFile(ByVal saveFile As String)
        Try
            Me.gridControl2.Model.SaveBinary(saveFile)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub WriteTsvFile(ByVal s As String)
        Me.Cursor = Cursors.WaitCursor
        Dim save As String = Me.gridControl2.Model.TextDataExchange.ExportTabDelim
        Me.gridControl2.Model.TextDataExchange.ExportTabDelim = Constants.vbTab
        Dim outPut As String = ""
        Dim rangeInfoList As New GridRangeInfoList()
        rangeInfoList.Add(GridRangeInfo.Cells(1, 1, Me.gridControl2.RowCount, Me.gridControl2.ColCount))
        For row As Integer = 1 To Me.gridControl1.RowCount
            For col As Integer = 1 To Me.gridControl2.ColCount
                Dim text As String = ""
                If Me.gridControl2.Data(row, col) IsNot Nothing Then
                    text = (New GridStyleInfo(Me.gridControl2.Data(row, col))).Text
                End If
                If col > 1 Then
                    outPut &= Me.gridControl2.Model.TextDataExchange.ExportTabDelim
                End If
                outPut &= text
            Next col
            outPut &= Environment.NewLine
        Next row
        Dim writer As New StreamWriter(s)
        writer.Write(outPut)
        writer.Close()
        Me.gridControl2.Model.TextDataExchange.ExportTabDelim = save
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub t_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim t As Timer = TryCast(sender, Timer)
        t.Enabled = False
        t.Dispose()
        Me.button3.PerformClick()
    End Sub

    Private Function FindFullPath(ByVal tsvFileName As String) As String
        ' Check both in parent folder and Parent\Data folders.
        Dim tsvDataFileName As String = "Data\" & tsvFileName
        For n As Integer = 0 To 9
            If System.IO.File.Exists(tsvFileName) Then
                Return Path.GetFullPath(tsvFileName)
            End If
            If System.IO.File.Exists(tsvDataFileName) Then
                Return Path.GetFullPath(tsvDataFileName)
            End If
            tsvFileName = "..\" & tsvFileName
            tsvDataFileName = "..\" & tsvDataFileName
        Next n

        Return ""
    End Function


    Private Sub SetFormatFirstRow()
        Dim style As GridStyleInfo = Me.gridControl2.RowStyles(1)
        style.Font.Size = 10.0F
        style.Font.Bold = True
        style.BackColor = Color.FromArgb(&HEE, &H7A, &H3)
        Me.gridControl2.RowHeights(1) = 30
        Me.gridControl2.HScrollPixel = True
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

#Region "Adding a formula to the formula library - step 1"

    'adding formula to the Formula Engine Library
    'step1: code it with this signature
    '			public string MyLibraryFormula(string args)
    '   return the computed value as a string...
    '   use the Engines public members as needed in your code.
    '   This sample computes the minimum of are arbitary range
    '     egs:		=Min(A1:C3)
    '				=min(a1,c2,a4,b2)
    Public Function ComputeMin(ByVal args As String) As String
        Dim model1 As GridFormulaCellModel = TryCast(Me.gridControl2.CellModels("FormulaCell"), GridFormulaCellModel)

        If model1 IsNot Nothing Then
            Dim engine As GridFormulaEngine = model1.Engine
            Dim min As Double = Double.MaxValue
            Dim d As Double
            Dim s1 As String

            For Each r As String In args.Split(New Char() {","c})
                If r.IndexOf(":"c) > -1 Then 'cell range
                    For Each s As String In engine.GetCellsFromArgs(r)
                        's is a cell line a21 or c3...
                        Try
                            s1 = engine.GetValueFromArg(s)
                        Catch ex As Exception
                            Return ex.Message
                        End Try
                        If s1 <> "" Then
                            If Double.TryParse(s1, NumberStyles.Number, Nothing, d) Then
                                min = Math.Min(min, d)
                            End If
                        End If
                    Next s
                Else
                    Try
                        s1 = engine.GetValueFromArg(r)
                    Catch ex As Exception
                        Return ex.Message
                    End Try
                    If s1 <> "" Then
                        If Double.TryParse(s1, NumberStyles.Number, Nothing, d) Then
                            min = Math.Min(min, d)
                        End If
                    End If

                End If
            Next r
            If min <> Double.MaxValue Then
                Return min.ToString()
            End If
        End If
        Return ""
    End Function


#End Region

#Region "handle format places context menu"

    Private Sub menuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem1.Click
        SetPlaces(-1)
    End Sub

    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
        SetPlaces(0)
    End Sub

    Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
        SetPlaces(1)
    End Sub

    Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click
        SetPlaces(2)
    End Sub

    Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
        SetPlaces(3)
    End Sub

    Private Sub menuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem8.Click
        SetPlaces(6)
    End Sub

    Private Sub SetPlaces(ByVal places As Integer)
        Dim rangeList As GridRangeInfoList
        If Me.gridControl1.Selections.GetSelectedRanges(rangeList, False) Then
            Dim style As New GridStyleInfo()
            If places = -1 Then
                style.Format = "g"
            Else
                style.Format = String.Format("F{0}", places)
            End If

            Dim range As GridRangeInfo = rangeList.ActiveRange.ExpandRange(1, 1, gridControl1.RowCount, gridControl1.ColCount)
            Me.gridControl1.ChangeCells(range, style, StyleModifyType.Override)

            Me.gridControl1.RefreshRange(range, GridRangeOptions.None)
        End If
    End Sub

#End Region

    Private Sub splitterControl1_PaneClosing(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs)
        If TypeOf e.Control Is GridControlBase Then
            Dim grid As GridControlBase = CType(e.Control, GridControlBase)
            Me.textBox1.UnwireGrid(grid)
        End If
    End Sub

    Private Sub splitterControl1_PaneCreated(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.SplitterPaneEventArgs)
        If TypeOf e.Control Is GridControlBase Then
            Dim grid As GridControlBase = CType(e.Control, GridControlBase)
            Me.textBox1.WireGrid(grid)
        End If
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        'save grid
        Dim saveFile As New SaveFileDialog()
        saveFile.DefaultExt = "*.tsv"
        saveFile.InitialDirectory = Application.ExecutablePath
        saveFile.Filter = "tsv Files|*.tsv|grd Files|*.grd"

        ' get a file name from the user
        If saveFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If saveFile.FileName.ToUpper().EndsWith(".GRD") Then
                WriteGrdFile(saveFile.FileName)
            ElseIf saveFile.FileName.ToUpper().EndsWith(".TSV") Then
                WriteTsvFile(saveFile.FileName)
            End If
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
        'load grid

        Dim dlgOpenFile As New OpenFileDialog()
        dlgOpenFile.Title = "Open grid file"
        dlgOpenFile.InitialDirectory = Application.ExecutablePath
        dlgOpenFile.Filter = "tsv Files|*.tsv|grd files (*.grd)|*.grd|All files (*.*)|*.*"

        If dlgOpenFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If dlgOpenFile.FileName.ToUpper().EndsWith(".GRD") Then
                LoadGrdFile(dlgOpenFile.FileName)
            ElseIf dlgOpenFile.FileName.ToUpper().EndsWith(".TSV") Then
                LoadTsvFile(dlgOpenFile.FileName)
            End If

        End If
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
        Me.Cursor = Cursors.WaitCursor
        Me.gridControl2.Focus()
        If (Not Me.gridControl2.CurrentCell.HasCurrentCell) OrElse messageBoxShown Then
            Me.gridControl2.CurrentCell.MoveTo(1, 0)
            messageBoxShown = False
        End If
        Dim found As Boolean = False
        Dim row As Integer = Me.gridControl2.CurrentCell.RowIndex
        Do While (Not found) AndAlso row < Me.gridControl2.RowCount
            row += 1
            Dim s As String = Me.gridControl2(row, 1).FormattedText
            If s.Length > 0 Then
                Dim d As Double
                If Double.TryParse(s, NumberStyles.Any, Nothing, d) Then
                    If Math.Abs(d) > Me.epsilon Then
                        found = True
                    End If
                End If
            End If
        Loop
        Me.Cursor = Cursors.Default
        If found Then
            If foundRow > 0 Then
                Dim i As Integer = foundRow
                foundRow = -2
                Me.gridControl2.RefreshRange(GridRangeInfo.Row(i))
            End If
            foundRow = row
            Me.gridControl2.CurrentCell.MoveTo(row, 0, GridSetCurrentCellOptions.ScrollInView)
            Me.gridControl2.RefreshRange(GridRangeInfo.Row(foundRow))
        Else
            If foundRow > 0 Then
                Dim i As Integer = foundRow
                foundRow = -2
                Me.gridControl2.RefreshRange(GridRangeInfo.Row(i))
            End If
            messageBoxShown = True
            MessageBox.Show("Search Completed")
        End If
    End Sub

    Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv1.SelectedIndexChanged
        Dim s As String = Me.comboBoxAdv1.Items(Me.comboBoxAdv1.SelectedIndex).ToString().Trim()
        If Double.TryParse(s, NumberStyles.Any, Nothing, epsilon) Then
            Try
                Me.format = epsilon.ToString("#.###############")
                Dim i As Integer = Me.format.IndexOf("1"c)
                If i > -1 Then
                    Me.format = Me.format.Substring(0, i + 1)
                End If
                Me.format = Me.format.Replace("1"c, "0"c)
                Me.gridControl1.Refresh()
            Catch
            End Try
        End If
    End Sub

End Class

