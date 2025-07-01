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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.Data.SqlServerCe

Imports Syncfusion.Windows.Forms.Tools


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private panel1 As System.Windows.Forms.Panel
    Private splitter1 As System.Windows.Forms.Splitter
    Private comboBox2 As System.Windows.Forms.ComboBox
    
    Private groupBox1 As System.Windows.Forms.GroupBox
    Private textLog As System.Windows.Forms.TextBox
    Private tabPage1 As System.Windows.Forms.TabPage
    Private comboBoxAdvSampleControl1 As ComboTest.MultiColumnComboBoxSampleControl
    Private tabControl1 As System.Windows.Forms.TabControl
    
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
        Me.comboBoxAdvSampleControl1.textLog = Me.textLog
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

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim connectionstring As String = "Data Source = ..\\..\\..\\..\\..\\..\\..\.\.\\..\\Common\\Data\\NorthwindIO.sdf"
        Dim table As New DataTable()
        Dim conn As New SqlCeConnection(connectionstring)
        conn.Open()
        Dim adapter As New SqlCeDataAdapter("SELECT CompanyName, ContactName, City, Country, CustomerID FROM Customers ORDER BY CompanyName ", conn)
        adapter.Fill(table)
        'Bind the Data Table with the MultiColumnBoundCombobox DataSource
        Me.comboBoxAdvSampleControl1.multiColumnBoundCombo.DataSource = table
        Me.comboBoxAdvSampleControl1.propertyGrid1.SelectedObject = Me.comboBoxAdvSampleControl1.multiColumnBoundCombo
        adapter.Dispose()
        conn.Close()
    End Sub

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.comboBox2 = New System.Windows.Forms.ComboBox()
        Me.splitter1 = New System.Windows.Forms.Splitter()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.textLog = New System.Windows.Forms.TextBox()
        Me.tabPage1 = New System.Windows.Forms.TabPage()
        Me.comboBoxAdvSampleControl1 = New ComboTest.MultiColumnComboBoxSampleControl()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.panel1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.comboBox2, Me.splitter1})
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel1.Location = New System.Drawing.Point(456, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(176, 517)
        Me.panel1.TabIndex = 6
        '
        'comboBox2
        '
        Me.comboBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.comboBox2.Location = New System.Drawing.Point(3, 0)
        Me.comboBox2.Name = "comboBox2"
        Me.comboBox2.Size = New System.Drawing.Size(173, 21)
        Me.comboBox2.TabIndex = 1
        '
        'splitter1
        '
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(3, 517)
        Me.splitter1.TabIndex = 0
        Me.splitter1.TabStop = False
        '
        'groupBox1
        '
        Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.textLog})
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupBox1.Location = New System.Drawing.Point(0, 262)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(512, 192)
        Me.groupBox1.TabIndex = 8
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Events:"
        '
        'textLog
        '
        Me.textLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textLog.Location = New System.Drawing.Point(3, 16)
        Me.textLog.Multiline = True
        Me.textLog.Name = "textLog"
        Me.textLog.Size = New System.Drawing.Size(506, 173)
        Me.textLog.TabIndex = 0
        Me.textLog.Text = ""
        '
        'tabPage1
        '
        Me.tabPage1.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(154, Byte))
        Me.tabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.comboBoxAdvSampleControl1})
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Size = New System.Drawing.Size(504, 236)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "ComboBoxAdv"
        '
        'comboBoxAdvSampleControl1
        '
        Me.comboBoxAdvSampleControl1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(200, Byte), CType(219, Byte))
        Me.comboBoxAdvSampleControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.comboBoxAdvSampleControl1.Name = "comboBoxAdvSampleControl1"
        Me.comboBoxAdvSampleControl1.Size = New System.Drawing.Size(504, 236)
        Me.comboBoxAdvSampleControl1.TabIndex = 0
        '
        'tabControl1
        '
        Me.tabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabPage1})
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.ItemSize = New System.Drawing.Size(82, 18)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(512, 262)
        Me.tabControl1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(200, Byte), CType(219, Byte))
        Me.ClientSize = New System.Drawing.Size(512, 454)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabControl1, Me.groupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multi Column ComboBox"
        AddHandler Load, AddressOf Form1_Load
        Me.panel1.ResumeLayout(False)
        Me.groupBox1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main
End Class 'Form1

Interface IChildSampleControls
    Function GetPrimaryItem() As Control
End Interface 'IChildSampleControls