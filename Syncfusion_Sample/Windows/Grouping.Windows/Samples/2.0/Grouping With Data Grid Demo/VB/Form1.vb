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

Imports Syncfusion.Grouping
Imports Syncfusion.Collections.BinaryTree


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private WithEvents dataGrid1 As System.Windows.Forms.DataGrid
    Private panel1 As System.Windows.Forms.Panel
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private label9 As System.Windows.Forms.Label
    Private MinB As System.Windows.Forms.Label
    Private MinA As System.Windows.Forms.Label
    Private MaxB As System.Windows.Forms.Label
    Private MaxA As System.Windows.Forms.Label
    Private TotalB As System.Windows.Forms.Label
    Private TotalA As System.Windows.Forms.Label
    Private label12 As System.Windows.Forms.Label
    Private CountB As System.Windows.Forms.Label
    Private CountA As System.Windows.Forms.Label
    Private label15 As System.Windows.Forms.Label
    Private label4 As System.Windows.Forms.Label
    Private numericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents NewData As System.Windows.Forms.Button
    Private panel2 As System.Windows.Forms.Panel
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Dim ico As System.Drawing.Icon = New System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"))
        Me.Icon = ico

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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.dataGrid1 = New System.Windows.Forms.DataGrid
        Me.panel1 = New System.Windows.Forms.Panel
        Me.CountB = New System.Windows.Forms.Label
        Me.CountA = New System.Windows.Forms.Label
        Me.label15 = New System.Windows.Forms.Label
        Me.TotalB = New System.Windows.Forms.Label
        Me.TotalA = New System.Windows.Forms.Label
        Me.label12 = New System.Windows.Forms.Label
        Me.MinB = New System.Windows.Forms.Label
        Me.MinA = New System.Windows.Forms.Label
        Me.label9 = New System.Windows.Forms.Label
        Me.MaxB = New System.Windows.Forms.Label
        Me.MaxA = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.label4 = New System.Windows.Forms.Label
        Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.NewData = New System.Windows.Forms.Button
        Me.panel2 = New System.Windows.Forms.Panel
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGrid1
        '
        Me.dataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGrid1.DataMember = ""
        Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataGrid1.Location = New System.Drawing.Point(8, 16)
        Me.dataGrid1.Name = "dataGrid1"
        Me.dataGrid1.Size = New System.Drawing.Size(208, 384)
        Me.dataGrid1.TabIndex = 0
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panel1.Controls.Add(Me.CountB)
        Me.panel1.Controls.Add(Me.CountA)
        Me.panel1.Controls.Add(Me.label15)
        Me.panel1.Controls.Add(Me.TotalB)
        Me.panel1.Controls.Add(Me.TotalA)
        Me.panel1.Controls.Add(Me.label12)
        Me.panel1.Controls.Add(Me.MinB)
        Me.panel1.Controls.Add(Me.MinA)
        Me.panel1.Controls.Add(Me.label9)
        Me.panel1.Controls.Add(Me.MaxB)
        Me.panel1.Controls.Add(Me.MaxA)
        Me.panel1.Controls.Add(Me.label6)
        Me.panel1.Controls.Add(Me.label3)
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Location = New System.Drawing.Point(224, 128)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(296, 80)
        Me.panel1.TabIndex = 1
        '
        'CountB
        '
        Me.CountB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CountB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountB.Location = New System.Drawing.Point(240, 56)
        Me.CountB.Name = "CountB"
        Me.CountB.Size = New System.Drawing.Size(56, 23)
        Me.CountB.TabIndex = 14
        Me.CountB.Text = "B"
        Me.CountB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountA
        '
        Me.CountA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CountA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountA.Location = New System.Drawing.Point(240, 32)
        Me.CountA.Name = "CountA"
        Me.CountA.Size = New System.Drawing.Size(56, 23)
        Me.CountA.TabIndex = 13
        Me.CountA.Text = "A"
        Me.CountA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label15
        '
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.Location = New System.Drawing.Point(248, 8)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(40, 23)
        Me.label15.TabIndex = 12
        Me.label15.Text = "Count"
        Me.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalB
        '
        Me.TotalB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotalB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalB.Location = New System.Drawing.Point(184, 56)
        Me.TotalB.Name = "TotalB"
        Me.TotalB.Size = New System.Drawing.Size(56, 23)
        Me.TotalB.TabIndex = 11
        Me.TotalB.Text = "B"
        Me.TotalB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TotalA
        '
        Me.TotalA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotalA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalA.Location = New System.Drawing.Point(184, 32)
        Me.TotalA.Name = "TotalA"
        Me.TotalA.Size = New System.Drawing.Size(56, 23)
        Me.TotalA.TabIndex = 10
        Me.TotalA.Text = "A"
        Me.TotalA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label12
        '
        Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label12.Location = New System.Drawing.Point(192, 8)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(48, 23)
        Me.label12.TabIndex = 9
        Me.label12.Text = "Total"
        Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinB
        '
        Me.MinB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MinB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinB.Location = New System.Drawing.Point(120, 56)
        Me.MinB.Name = "MinB"
        Me.MinB.Size = New System.Drawing.Size(64, 23)
        Me.MinB.TabIndex = 8
        Me.MinB.Text = "B"
        Me.MinB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MinA
        '
        Me.MinA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MinA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinA.Location = New System.Drawing.Point(120, 32)
        Me.MinA.Name = "MinA"
        Me.MinA.Size = New System.Drawing.Size(64, 23)
        Me.MinA.TabIndex = 7
        Me.MinA.Text = "A"
        Me.MinA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label9
        '
        Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.Location = New System.Drawing.Point(128, 8)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(56, 23)
        Me.label9.TabIndex = 6
        Me.label9.Text = "Minimum"
        Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaxB
        '
        Me.MaxB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaxB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxB.Location = New System.Drawing.Point(64, 56)
        Me.MaxB.Name = "MaxB"
        Me.MaxB.Size = New System.Drawing.Size(56, 23)
        Me.MaxB.TabIndex = 5
        Me.MaxB.Text = "B"
        Me.MaxB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaxA
        '
        Me.MaxA.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaxA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxA.Location = New System.Drawing.Point(64, 32)
        Me.MaxA.Name = "MaxA"
        Me.MaxA.Size = New System.Drawing.Size(56, 23)
        Me.MaxA.TabIndex = 4
        Me.MaxA.Text = "A"
        Me.MaxA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label6
        '
        Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(64, 8)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 23)
        Me.label6.TabIndex = 3
        Me.label6.Text = "Maximum"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(8, 56)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(48, 23)
        Me.label3.TabIndex = 2
        Me.label3.Text = "B"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(8, 32)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(48, 23)
        Me.label2.TabIndex = 1
        Me.label2.Text = "A"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(8, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Column"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label4
        '
        Me.label4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label4.Location = New System.Drawing.Point(32, 19)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(88, 16)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Number of rows"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'numericUpDown1
        '
        Me.numericUpDown1.Location = New System.Drawing.Point(128, 16)
        Me.numericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numericUpDown1.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numericUpDown1.Name = "numericUpDown1"
        Me.numericUpDown1.Size = New System.Drawing.Size(56, 20)
        Me.numericUpDown1.TabIndex = 3
        Me.numericUpDown1.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'NewData
        '
        Me.NewData.BackColor = System.Drawing.SystemColors.ControlLight
        Me.NewData.Location = New System.Drawing.Point(32, 48)
        Me.NewData.Name = "NewData"
        Me.NewData.Size = New System.Drawing.Size(152, 23)
        Me.NewData.TabIndex = 4
        Me.NewData.Text = "Generate New Data"
        Me.NewData.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel2.Controls.Add(Me.numericUpDown1)
        Me.panel2.Controls.Add(Me.NewData)
        Me.panel2.Controls.Add(Me.label4)
        Me.panel2.Location = New System.Drawing.Point(264, 16)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(216, 80)
        Me.panel2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 422)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.dataGrid1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grouping With Data Grid Demo"
        CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
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

    'our datasource
    Private myTable As DataTable

    'grouping support objects 
    Private theTable As Syncfusion.Grouping.Table
    Private engine As Syncfusion.Grouping.Engine


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'get a DataTable
        myTable = GetATable()

        'set it into the DataGrid
        Me.dataGrid1.DataSource = myTable

        'create a new grouping engine and assign it a IList datasource
        engine = New Engine()
        engine.SetSourceList(myTable.DefaultView)
        engine.RecordAsDisplayElements = True

        'enable the 2 summar
        'get a reference to the underlying grouping Table
        theTable = engine.Table

        'add the Summaries that we want
        engine.TableDescriptor.Summaries.Add("AStats", "A", SummaryType.Int32Aggregate)
        engine.TableDescriptor.Summaries.Add("BStats", "B", SummaryType.Int32Aggregate)

        RefreshStatsPanel()
    End Sub 'Form1_Load

    'turn off AddNew
    'dt.DefaultView.AllowNew = false;


    Private Function GetATable() As DataTable
        Dim dt As New DataTable("MyTable")
        dt.Columns.Add(New DataColumn("A", GetType(Integer)))
        dt.Columns.Add(New DataColumn("B", GetType(Integer)))

        PopulateDataTable(100, dt)

        Return dt
    End Function 'GetATable


    Private Sub PopulateDataTable(ByVal nRows As Integer, ByVal dt As DataTable)
        If Me.dataGrid1.CurrentRowIndex >= 0 Then
            Me.dataGrid1.CurrentRowIndex = 0
        End If
        dt.Clear()
        dt.Rows.Clear()

        Dim r As New Random()

        Dim i As Integer
        For i = 0 To nRows - 1
            Dim dr As DataRow = dt.NewRow()
            dr(0) = r.Next(1000)
            dr(1) = r.Next(1000)
            dt.Rows.Add(dr)
        Next i
    End Sub 'PopulateDataTable


    Private Sub NewData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewData.Click
        PopulateDataTable(Fix(Me.numericUpDown1.Value), Me.myTable)
        RefreshStatsPanel()
    End Sub 'NewData_Click


    Private Sub RefreshStatsPanel()
        Dim summaries As ITreeTableSummary() = Me.theTable.TopLevelGroup.GetSummaries(Me.theTable)
        Dim sdc As SummaryDescriptorCollection = Me.theTable.TableDescriptor.Summaries
        Dim index As Integer = sdc.IndexOf(sdc("AStats"))
        Dim summary As Int32AggregateSummary = summaries(index)

        MaxA.Text = summary.Maximum.ToString()
        MinA.Text = summary.Minimum.ToString()
        TotalA.Text = summary.Sum.ToString()
        CountA.Text = summary.Count.ToString()

        index = sdc.IndexOf(sdc("BStats"))
        summary = summaries(index)

        MaxB.Text = summary.Maximum.ToString()
        MinB.Text = summary.Minimum.ToString()
        TotalB.Text = summary.Sum.ToString()
        CountB.Text = summary.Count.ToString()
    End Sub 'RefreshStatsPanel



    Private Sub dataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dataGrid1.CurrentCellChanged
        RefreshStatsPanel()
    End Sub 'dataGrid1_CurrentCellChanged
End Class 'Form1