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
Imports Syncfusion.Calculate
Imports Syncfusion.Windows.Forms.Grid


Namespace GridDataBoundGridCalculator

Public Class GridDataBoundGridWorkBookForm
    Inherits System.Windows.Forms.Form
    Private gridDataBoundGrid1 As GridDataBoundGridCalculator.CalcGridDataBoundGrid
    Private gridDataBoundGrid2 As GridDataBoundGridCalculator.CalcGridDataBoundGrid
    Private gridDataBoundGrid3 As GridDataBoundGridCalculator.CalcGridDataBoundGrid
    Private gridDataBoundGrid4 As GridDataBoundGridCalculator.CalcGridDataBoundGrid
    Private gridDataBoundGrid5 As GridDataBoundGridCalculator.CalcGridDataBoundGrid
    Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private label1 As System.Windows.Forms.Label
    Private tabBarSplitterControl1 As Syncfusion.Windows.Forms.TabBarSplitterControl
    Private tabBarPage1 As Syncfusion.Windows.Forms.TabBarPage
    Private tabBarPage2 As Syncfusion.Windows.Forms.TabBarPage
    Private tabBarPage3 As Syncfusion.Windows.Forms.TabBarPage
    Private tabBarPage4 As Syncfusion.Windows.Forms.TabBarPage
    Private tabBarPage5 As Syncfusion.Windows.Forms.TabBarPage

    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support.
        '
            InitializeComponent()
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"))
            Me.Icon = ico

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
        ''' <summary>
        ''' Required method for Designer support; do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim GridStyleInfo6 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
            Dim GridStyleInfo7 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
            Dim GridStyleInfo8 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
            Dim GridStyleInfo9 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
            Dim GridStyleInfo10 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
            Me.gridDataBoundGrid1 = New GridDataBoundGridCalculator.CalcGridDataBoundGrid
            Me.gridDataBoundGrid2 = New GridDataBoundGridCalculator.CalcGridDataBoundGrid
            Me.gridDataBoundGrid3 = New GridDataBoundGridCalculator.CalcGridDataBoundGrid
            Me.gridDataBoundGrid4 = New GridDataBoundGridCalculator.CalcGridDataBoundGrid
            Me.gridDataBoundGrid5 = New GridDataBoundGridCalculator.CalcGridDataBoundGrid
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.label1 = New System.Windows.Forms.Label
            Me.tabBarSplitterControl1 = New Syncfusion.Windows.Forms.TabBarSplitterControl
            Me.tabBarPage1 = New Syncfusion.Windows.Forms.TabBarPage
            Me.tabBarPage2 = New Syncfusion.Windows.Forms.TabBarPage
            Me.tabBarPage3 = New Syncfusion.Windows.Forms.TabBarPage
            Me.tabBarPage4 = New Syncfusion.Windows.Forms.TabBarPage
            Me.tabBarPage5 = New Syncfusion.Windows.Forms.TabBarPage
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDataBoundGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDataBoundGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDataBoundGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridDataBoundGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabBarSplitterControl1.SuspendLayout()
            Me.tabBarPage1.SuspendLayout()
            Me.tabBarPage2.SuspendLayout()
            Me.tabBarPage3.SuspendLayout()
            Me.tabBarPage4.SuspendLayout()
            Me.tabBarPage5.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridDataBoundGrid1
            '
            Me.gridDataBoundGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell
            Me.gridDataBoundGrid1.AllowDragSelectedCols = True
            Me.gridDataBoundGrid1.DataMember = ""
            Me.gridDataBoundGrid1.FillSplitterPane = True
            Me.gridDataBoundGrid1.Font = New System.Drawing.Font("Verdana", 8.5!)
            Me.gridDataBoundGrid1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid1.Location = New System.Drawing.Point(0, 0)
            Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
            Me.gridDataBoundGrid1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid1.Size = New System.Drawing.Size(573, 341)
            Me.gridDataBoundGrid1.SmartSizeBox = False
            Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None
            GridStyleInfo6.Font.Bold = False
            GridStyleInfo6.Font.Facename = "Verdana"
            GridStyleInfo6.Font.Italic = False
            GridStyleInfo6.Font.Size = 8.5!
            GridStyleInfo6.Font.Strikeout = False
            GridStyleInfo6.Font.Underline = False
            Me.gridDataBoundGrid1.TableStyle = GridStyleInfo6
            '
            'gridDataBoundGrid2
            '
            Me.gridDataBoundGrid2.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell
            Me.gridDataBoundGrid2.AllowDragSelectedCols = True
            Me.gridDataBoundGrid2.DataMember = ""
            Me.gridDataBoundGrid2.FillSplitterPane = True
            Me.gridDataBoundGrid2.Font = New System.Drawing.Font("Verdana", 8.5!)
            Me.gridDataBoundGrid2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridDataBoundGrid2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid2.Location = New System.Drawing.Point(136, 112)
            Me.gridDataBoundGrid2.Name = "gridDataBoundGrid2"
            Me.gridDataBoundGrid2.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDataBoundGrid2.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridDataBoundGrid2.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid2.Size = New System.Drawing.Size(130, 80)
            Me.gridDataBoundGrid2.SmartSizeBox = False
            Me.gridDataBoundGrid2.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None
            GridStyleInfo7.Font.Bold = False
            GridStyleInfo7.Font.Facename = "Verdana"
            GridStyleInfo7.Font.Italic = False
            GridStyleInfo7.Font.Size = 8.5!
            GridStyleInfo7.Font.Strikeout = False
            GridStyleInfo7.Font.Underline = False
            Me.gridDataBoundGrid2.TableStyle = GridStyleInfo7
            '
            'gridDataBoundGrid3
            '
            Me.gridDataBoundGrid3.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell
            Me.gridDataBoundGrid3.AllowDragSelectedCols = True
            Me.gridDataBoundGrid3.DataMember = ""
            Me.gridDataBoundGrid3.FillSplitterPane = True
            Me.gridDataBoundGrid3.Font = New System.Drawing.Font("Verdana", 8.5!)
            Me.gridDataBoundGrid3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridDataBoundGrid3.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid3.Location = New System.Drawing.Point(136, 136)
            Me.gridDataBoundGrid3.Name = "gridDataBoundGrid3"
            Me.gridDataBoundGrid3.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDataBoundGrid3.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridDataBoundGrid3.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid3.Size = New System.Drawing.Size(130, 80)
            Me.gridDataBoundGrid3.SmartSizeBox = False
            Me.gridDataBoundGrid3.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None
            GridStyleInfo8.Font.Bold = False
            GridStyleInfo8.Font.Facename = "Verdana"
            GridStyleInfo8.Font.Italic = False
            GridStyleInfo8.Font.Size = 8.5!
            GridStyleInfo8.Font.Strikeout = False
            GridStyleInfo8.Font.Underline = False
            Me.gridDataBoundGrid3.TableStyle = GridStyleInfo8
            '
            'gridDataBoundGrid4
            '
            Me.gridDataBoundGrid4.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell
            Me.gridDataBoundGrid4.AllowDragSelectedCols = True
            Me.gridDataBoundGrid4.DataMember = ""
            Me.gridDataBoundGrid4.FillSplitterPane = True
            Me.gridDataBoundGrid4.Font = New System.Drawing.Font("Verdana", 8.5!)
            Me.gridDataBoundGrid4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridDataBoundGrid4.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid4.Location = New System.Drawing.Point(112, 112)
            Me.gridDataBoundGrid4.Name = "gridDataBoundGrid4"
            Me.gridDataBoundGrid4.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDataBoundGrid4.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridDataBoundGrid4.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid4.Size = New System.Drawing.Size(130, 80)
            Me.gridDataBoundGrid4.SmartSizeBox = False
            Me.gridDataBoundGrid4.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None
            GridStyleInfo9.Font.Bold = False
            GridStyleInfo9.Font.Facename = "Verdana"
            GridStyleInfo9.Font.Italic = False
            GridStyleInfo9.Font.Size = 8.5!
            GridStyleInfo9.Font.Strikeout = False
            GridStyleInfo9.Font.Underline = False
            Me.gridDataBoundGrid4.TableStyle = GridStyleInfo9
            '
            'gridDataBoundGrid5
            '
            Me.gridDataBoundGrid5.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell
            Me.gridDataBoundGrid5.AllowDragSelectedCols = True
            Me.gridDataBoundGrid5.DataMember = ""
            Me.gridDataBoundGrid5.FillSplitterPane = True
            Me.gridDataBoundGrid5.Font = New System.Drawing.Font("Verdana", 8.5!)
            Me.gridDataBoundGrid5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.gridDataBoundGrid5.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridDataBoundGrid5.Location = New System.Drawing.Point(144, 96)
            Me.gridDataBoundGrid5.Name = "gridDataBoundGrid5"
            Me.gridDataBoundGrid5.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridDataBoundGrid5.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridDataBoundGrid5.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
            Me.gridDataBoundGrid5.Size = New System.Drawing.Size(130, 80)
            Me.gridDataBoundGrid5.SmartSizeBox = False
            Me.gridDataBoundGrid5.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None
            GridStyleInfo10.Font.Bold = False
            GridStyleInfo10.Font.Facename = "Verdana"
            GridStyleInfo10.Font.Italic = False
            GridStyleInfo10.Font.Size = 8.5!
            GridStyleInfo10.Font.Strikeout = False
            GridStyleInfo10.Font.Underline = False
            Me.gridDataBoundGrid5.TableStyle = GridStyleInfo10
            '
            'checkBox1
            '
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Location = New System.Drawing.Point(34, 32)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(128, 16)
            Me.checkBox1.TabIndex = 3
            Me.checkBox1.Text = "Show Formulas"
            '
            'label1
            '
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Location = New System.Drawing.Point(320, 34)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(312, 16)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Enter a formula like   = Sum(GDBG2!B2:GDBG2!B5)   into a cell."
            '
            'tabBarSplitterControl1
            '
            Me.tabBarSplitterControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage1)
            Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage2)
            Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage3)
            Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage4)
            Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage5)
            Me.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText
            Me.tabBarSplitterControl1.Location = New System.Drawing.Point(32, 64)
            Me.tabBarSplitterControl1.Name = "tabBarSplitterControl1"
            Me.tabBarSplitterControl1.Office2007ScrollBars = True
            Me.tabBarSplitterControl1.Size = New System.Drawing.Size(592, 360)
            Me.tabBarSplitterControl1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None
            Me.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007
            Me.tabBarSplitterControl1.TabFolderDelta = 11
            Me.tabBarSplitterControl1.TabIndex = 5
            Me.tabBarSplitterControl1.Text = "tabBarSplitterControl1"
            Me.tabBarSplitterControl1.ThemesEnabled = False
            '
            'tabBarPage1
            '
            Me.tabBarPage1.Controls.Add(Me.gridDataBoundGrid1)
            Me.tabBarPage1.Location = New System.Drawing.Point(0, 0)
            Me.tabBarPage1.Name = "tabBarPage1"
            Me.tabBarPage1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None
            Me.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control
            Me.tabBarPage1.Text = "GDBG1"
            Me.tabBarPage1.ThemesEnabled = False
            '
            'tabBarPage2
            '
            Me.tabBarPage2.Controls.Add(Me.gridDataBoundGrid2)
            Me.tabBarPage2.Location = New System.Drawing.Point(0, 0)
            Me.tabBarPage2.Name = "tabBarPage2"
            Me.tabBarPage2.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
            Me.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control
            Me.tabBarPage2.Text = "GDBG2"
            Me.tabBarPage2.ThemesEnabled = False
            '
            'tabBarPage3
            '
            Me.tabBarPage3.Controls.Add(Me.gridDataBoundGrid3)
            Me.tabBarPage3.Location = New System.Drawing.Point(0, 0)
            Me.tabBarPage3.Name = "tabBarPage3"
            Me.tabBarPage3.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
            Me.tabBarPage3.TabBackColor = System.Drawing.SystemColors.Control
            Me.tabBarPage3.Text = "GDBG3"
            Me.tabBarPage3.ThemesEnabled = False
            '
            'tabBarPage4
            '
            Me.tabBarPage4.Controls.Add(Me.gridDataBoundGrid4)
            Me.tabBarPage4.Location = New System.Drawing.Point(0, 0)
            Me.tabBarPage4.Name = "tabBarPage4"
            Me.tabBarPage4.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
            Me.tabBarPage4.TabBackColor = System.Drawing.SystemColors.Control
            Me.tabBarPage4.Text = "GDBG4"
            Me.tabBarPage4.ThemesEnabled = False
            '
            'tabBarPage5
            '
            Me.tabBarPage5.Controls.Add(Me.gridDataBoundGrid5)
            Me.tabBarPage5.Location = New System.Drawing.Point(0, 0)
            Me.tabBarPage5.Name = "tabBarPage5"
            Me.tabBarPage5.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
            Me.tabBarPage5.TabBackColor = System.Drawing.SystemColors.Control
            Me.tabBarPage5.Text = "GDBG5"
            Me.tabBarPage5.ThemesEnabled = False
            '
            'GridDataBoundGridWorkBookForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(656, 454)
            Me.Controls.Add(Me.tabBarSplitterControl1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.checkBox1)
            Me.Name = "GridDataBoundGridWorkBookForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Grid-Data-Bound-Grid Calculator Demo"
            CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDataBoundGrid2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDataBoundGrid3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDataBoundGrid4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridDataBoundGrid5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabBarSplitterControl1.ResumeLayout(False)
            Me.tabBarPage1.ResumeLayout(False)
            Me.tabBarPage2.ResumeLayout(False)
            Me.tabBarPage3.ResumeLayout(False)
            Me.tabBarPage4.ResumeLayout(False)
            Me.tabBarPage5.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region


        Private engine As Syncfusion.Calculate.CalcEngine


        Private Sub gridDataBoundGridWorkBookForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.gridDataBoundGrid1.DataSource = GetARandomTable()
            Me.gridDataBoundGrid2.DataSource = GetARandomTable()
            Me.gridDataBoundGrid3.DataSource = GetARandomTable()
            Me.gridDataBoundGrid4.DataSource = GetARandomTable()
            Me.gridDataBoundGrid5.DataSource = GetARandomTable()

            If engine Is Nothing Then
                'Create the engine:
                engine = New Syncfusion.Calculate.CalcEngine(Me.gridDataBoundGrid1)
                'Track dependencies required for auto calculations:
                engine.UseDependencies = True

                'Register multiple ICalcData objects for cross sheet references:
                Dim sheetfamilyID As Integer = Syncfusion.Calculate.CalcEngine.CreateSheetFamilyID()
                engine.RegisterGridAsSheet("GDBG1", Me.gridDataBoundGrid1, sheetfamilyID)
                engine.RegisterGridAsSheet("GDBG2", Me.gridDataBoundGrid2, sheetfamilyID)
                engine.RegisterGridAsSheet("GDBG3", Me.gridDataBoundGrid3, sheetfamilyID)
                engine.RegisterGridAsSheet("GDBG4", Me.gridDataBoundGrid4, sheetfamilyID)
                engine.RegisterGridAsSheet("GDBG5", Me.gridDataBoundGrid5, sheetfamilyID)
            End If
        End Sub 'gridDataBoundGridWorkBookForm_Load

#Region "Create DataTables"

        Private r As New Random()
        Private tableCount As Integer = 0

        Private Function GetARandomTable() As DataTable
            Dim dt As New DataTable(String.Format("Table{0}", tableCount))

            Dim nRows As Integer = r.Next(100) + 5
            Dim nCols As Integer = r.Next(20) + 5

            Dim i As Integer = 0

            While i < nCols
                dt.Columns.Add(New DataColumn(RangeInfo.GetAlphaLabel((i + 1))))
                i += 1
            End While

            tableCount += 1

            i = 0

            While i < nRows
                Dim dr As DataRow = dt.NewRow()
                Dim j As Integer = 0

                While j < nCols
                    If j = 0 Then
                        dr(j) = i + 1
                    Else
                        dr(j) = r.Next(1000)
                    End If
                    j += 1
                End While
                dt.Rows.Add(dr)
                i += 1
            End While
            dt.DefaultView.AllowNew = False
            Return dt
        End Function 'GetARandomTable

#End Region



#Region " CheckBox handler code"


        Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            Me.Cursor = Cursors.WaitCursor
            ShowFormulas(Me.checkBox1.Checked, Me.gridDataBoundGrid1)
            ShowFormulas(Me.checkBox1.Checked, Me.gridDataBoundGrid2)
            ShowFormulas(Me.checkBox1.Checked, Me.gridDataBoundGrid3)
            ShowFormulas(Me.checkBox1.Checked, Me.gridDataBoundGrid4)
            ShowFormulas(Me.checkBox1.Checked, Me.gridDataBoundGrid5)
            Me.Cursor = Cursors.Default
        End Sub 'checkBox1_CheckedChanged


        Private Sub ShowFormulas(ByVal show As Boolean, ByVal grid As CalcGridDataBoundGrid)
            Dim dt As DataTable = grid.DataSource '
            engine.IgnoreValueChanged = True

            If show Then
                Dim row As Integer

                While row < dt.Rows.Count
                    Dim col As Integer = 0

                    While col < dt.Columns.Count
                        'All calls into CalcEngine are one-based:
                        Dim s As String = Me.engine.GetFormulaRowCol(grid, row + 1, col + 1)
                        If s.Length > 0 Then
                            'No calculation as ValueChanged is not raised:
                            grid(row + 1, col + 1).Text = s
                        End If
                        col += 1
                    End While
                    row += 1
                End While
            Else
                Dim row As Integer

                While row < dt.Rows.Count
                    Dim col As Integer = 0

                    While col < dt.Columns.Count
                        'All calls into CalcEngine are one-based:
                        Dim s As String = Me.engine.GetFormulaRowCol(grid, row + 1, col + 1)
                        If s.Length > 0 Then
                            'Get the value:
                            Dim family As Syncfusion.Calculate.GridSheetFamilyItem = Syncfusion.Calculate.CalcEngine.GetSheetFamilyItem(grid)
                            Dim cell As String = IIf(family.ParentObjectToToken Is Nothing, "", family.ParentObjectToToken(grid).ToString())

                            cell += RangeInfo.GetAlphaLabel((col + 1)) + (row + 1).ToString()
                            s = Me.engine.GetValueFromParentObject(cell)
                            grid(row + 1, col + 1).Text = s
                        End If
                        col += 1
                    End While

                    Me.gridDataBoundGrid1.Binder.EndEdit()
                    row += 1
                End While
            End If
            engine.IgnoreValueChanged = False
        End Sub 'ShowFormulas 
#End Region
End Class 'GridDataBoundGridWorkBookForm
End Namespace 'GridDataBoundGridCalculator