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


 
Public Class DataGridWorkBookForm
   Inherits System.Windows.Forms.Form
   Private tabControl1 As System.Windows.Forms.TabControl
   Private tabPage1 As System.Windows.Forms.TabPage
   Private tabPage2 As System.Windows.Forms.TabPage
   Private tabPage3 As System.Windows.Forms.TabPage
   Private tabPage4 As System.Windows.Forms.TabPage
   Private tabPage5 As System.Windows.Forms.TabPage
    Private dataGrid1 As DataGrid
    Private dataGrid2 As DataGrid
    Private dataGrid3 As DataGrid
    Private dataGrid4 As DataGrid
    Private dataGrid5 As DataGrid
   Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
   Private label1 As System.Windows.Forms.Label
    
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support.
      '
        InitializeComponent()
        Try
            Dim ico As Icon = New Icon(StartUpForm.FindFile("Icon", "sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
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

    '/ <summary>
    '/ Required method for Designer support; do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.tabControl1 = New System.Windows.Forms.TabControl
        Me.tabPage1 = New System.Windows.Forms.TabPage
        Me.dataGrid1 = New DataGridCalculator.CalcDataGrid
        Me.tabPage2 = New System.Windows.Forms.TabPage
        Me.dataGrid2 = New DataGridCalculator.CalcDataGrid
        Me.tabPage3 = New System.Windows.Forms.TabPage
        Me.dataGrid3 = New DataGridCalculator.CalcDataGrid
        Me.tabPage4 = New System.Windows.Forms.TabPage
        Me.dataGrid4 = New DataGridCalculator.CalcDataGrid
        Me.tabPage5 = New System.Windows.Forms.TabPage
        Me.dataGrid5 = New DataGridCalculator.CalcDataGrid
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.label1 = New System.Windows.Forms.Label
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage2.SuspendLayout()
        CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage3.SuspendLayout()
        CType(Me.dataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage4.SuspendLayout()
        CType(Me.dataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPage5.SuspendLayout()
        CType(Me.dataGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Controls.Add(Me.tabPage3)
        Me.tabControl1.Controls.Add(Me.tabPage4)
        Me.tabControl1.Controls.Add(Me.tabPage5)
        Me.tabControl1.Location = New System.Drawing.Point(32, 64)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(656, 360)
        Me.tabControl1.TabIndex = 0
        '
        'tabPage1
        '
        Me.tabPage1.Controls.Add(Me.dataGrid1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(648, 334)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "DG1"
        '
        'dataGrid1
        '
        Me.dataGrid1.AllowSorting = False
        Me.dataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(648, 334)
        Me.dataGrid1.TabIndex = 0
        '
        'tabPage2
        '
        Me.tabPage2.Controls.Add(Me.dataGrid2)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Size = New System.Drawing.Size(648, 334)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "DG2"
        '
        'dataGrid2
        '
        Me.dataGrid2.AllowSorting = False
        Me.dataGrid2.DataMember = ""
        Me.dataGrid2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid2.Location = New System.Drawing.Point(0, 0)
        Me.dataGrid2.Name = "dataGrid2"
        Me.dataGrid2.Size = New System.Drawing.Size(648, 334)
        Me.dataGrid2.TabIndex = 0
        '
        'tabPage3
        '
        Me.tabPage3.Controls.Add(Me.dataGrid3)
        Me.tabPage3.Location = New System.Drawing.Point(4, 22)
        Me.tabPage3.Name = "tabPage3"
        Me.tabPage3.Size = New System.Drawing.Size(648, 334)
        Me.tabPage3.TabIndex = 2
        Me.tabPage3.Text = "DG3"
        '
        'dataGrid3
        '
        Me.dataGrid3.AllowSorting = False
        Me.dataGrid3.DataMember = ""
        Me.dataGrid3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid3.Location = New System.Drawing.Point(0, 0)
        Me.dataGrid3.Name = "dataGrid3"
        Me.dataGrid3.Size = New System.Drawing.Size(648, 334)
        Me.dataGrid3.TabIndex = 0
        '
        'tabPage4
        '
        Me.tabPage4.Controls.Add(Me.dataGrid4)
        Me.tabPage4.Location = New System.Drawing.Point(4, 22)
        Me.tabPage4.Name = "tabPage4"
        Me.tabPage4.Size = New System.Drawing.Size(648, 334)
        Me.tabPage4.TabIndex = 3
        Me.tabPage4.Text = "DG4"
        '
        'dataGrid4
        '
        Me.dataGrid4.AllowSorting = False
        Me.dataGrid4.DataMember = ""
        Me.dataGrid4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid4.Location = New System.Drawing.Point(0, 0)
        Me.dataGrid4.Name = "dataGrid4"
        Me.dataGrid4.Size = New System.Drawing.Size(648, 334)
        Me.dataGrid4.TabIndex = 0
        '
        'tabPage5
        '
        Me.tabPage5.Controls.Add(Me.dataGrid5)
        Me.tabPage5.Location = New System.Drawing.Point(4, 22)
        Me.tabPage5.Name = "tabPage5"
        Me.tabPage5.Size = New System.Drawing.Size(648, 334)
        Me.tabPage5.TabIndex = 4
        Me.tabPage5.Text = "DG5"
        '
        'dataGrid5
        '
        Me.dataGrid5.AllowSorting = False
        Me.dataGrid5.DataMember = ""
        Me.dataGrid5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid5.Location = New System.Drawing.Point(0, 0)
        Me.dataGrid5.Name = "dataGrid5"
        Me.dataGrid5.Size = New System.Drawing.Size(648, 334)
        Me.dataGrid5.TabIndex = 0
        '
        'checkBox1
        '
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox1.Location = New System.Drawing.Point(32, 24)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(224, 24)
        Me.checkBox1.TabIndex = 3
        Me.checkBox1.Text = "Show Formulas"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(272, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(304, 48)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Enter a formula like   = Sum(DG2!B2:DG2!B5)   into a cell."
        '
        'DataGridWorkBookForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(720, 454)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "DataGridWorkBookForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Grid Calculator Demo"
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage2.ResumeLayout(False)
        CType(Me.dataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage3.ResumeLayout(False)
        CType(Me.dataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage4.ResumeLayout(False)
        CType(Me.dataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPage5.ResumeLayout(False)
        CType(Me.dataGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private engine As Syncfusion.Calculate.CalcEngine


    Private Sub DataGridWorkBookForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dataGrid1.DataSource = GetARandomTable()
        Me.dataGrid2.DataSource = GetARandomTable()
        Me.dataGrid3.DataSource = GetARandomTable()
        Me.dataGrid4.DataSource = GetARandomTable()
        Me.dataGrid5.DataSource = GetARandomTable()

        If engine Is Nothing Then
            'Call this to reset static members in case other form is loaded first:
            Syncfusion.Calculate.CalcEngine.ResetSheetFamilyID()

            'Create the engine:
            engine = New Syncfusion.Calculate.CalcEngine(Me.dataGrid1)

            'Track dependencies required for auto calculations:
            engine.UseDependencies = True

            'Register multiple ICalcData objects for cross sheet references:
            Dim sheetfamilyID As Integer = Syncfusion.Calculate.CalcEngine.CreateSheetFamilyID()
            engine.RegisterGridAsSheet("DG1", Me.dataGrid1, sheetfamilyID)
            engine.RegisterGridAsSheet("DG2", Me.dataGrid2, sheetfamilyID)
            engine.RegisterGridAsSheet("DG3", Me.dataGrid3, sheetfamilyID)
            engine.RegisterGridAsSheet("DG4", Me.dataGrid4, sheetfamilyID)
            engine.RegisterGridAsSheet("DG5", Me.dataGrid5, sheetfamilyID)
        End If
    End Sub 'DataGridWorkBookForm_Load

#Region "Create DataTables"

    Private r As New Random()
    Private tableCount As Integer = 0

    Private Function GetARandomTable() As DataTable
        Dim dt As New DataTable(String.Format("Table{0}", tableCount))

        Dim nRows As Integer = r.Next(100) + 5
        Dim nCols As Integer = r.Next(20) + 5

        Dim i As Integer

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
        ShowFormulas(Me.checkBox1.Checked, Me.dataGrid1)
        ShowFormulas(Me.checkBox1.Checked, Me.dataGrid2)
        ShowFormulas(Me.checkBox1.Checked, Me.dataGrid3)
        ShowFormulas(Me.checkBox1.Checked, Me.dataGrid4)
        ShowFormulas(Me.checkBox1.Checked, Me.dataGrid5)
        Me.Cursor = Cursors.Default
    End Sub 'checkBox1_CheckedChanged


    Private Sub ShowFormulas(ByVal show As Boolean, ByVal grid As DataGrid)
        Dim dt As DataTable = grid.DataSource '
        

        If show Then
            engine.IgnoreValueChanged = True
            Dim row As Integer = 0

            While row < dt.Rows.Count
                Dim col As Integer = 0

                While col < dt.Columns.Count
                    Dim s As String = Me.engine.GetFormulaRowCol(CType(grid, ICalcData), row + 1, col + 1) 'one-based
                    If s.Length > 0 Then
                        grid(row, col) = s
                    End If
                    col += 1
                End While
                row += 1
            End While
            engine.IgnoreValueChanged = False
        Else
            Dim row As Integer = 0

            While row < dt.Rows.Count
                Dim col As Integer = 0

                While col < dt.Columns.Count
                    Dim s As String = Me.engine.GetFormulaRowCol(CType(grid, ICalcData), row + 1, col + 1) 'one-based
                    If s.Length > 0 Then
                        grid(row, col) = s
                    End If
                    col += 1
                End While
                row += 1
            End While
        End If
        grid.ReadOnly = show
        If show Then
            Me.checkBox1.Text = "Showing Formulas (Read-only DataGrid)"
        Else
            Me.checkBox1.Text = "Show Formulas"
        End If
    End Sub 'ShowFormulas 
#End Region
End Class 'DataGridWorkBookForm