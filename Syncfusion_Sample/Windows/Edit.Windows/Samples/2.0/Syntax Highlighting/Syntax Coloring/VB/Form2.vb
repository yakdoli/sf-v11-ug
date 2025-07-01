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
Imports System.IO


'/ <summary>
'/ Summary description for Form2.
'/ </summary>

Public Class Form2
    Inherits System.Windows.Forms.Form
    Private WithEvents treeView1 As System.Windows.Forms.TreeView
    Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Config.xml"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.treeView1.ExpandAll()
        
        Me.editControl1.LoadFile(BasePath)
    End Sub 'New
    
    
    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
        Me.treeView1 = New System.Windows.Forms.TreeView()
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'treeView1
        '
        Me.treeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.treeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeView1.ImageIndex = -1
        Me.treeView1.ItemHeight = 20
        Me.treeView1.Name = "treeView1"
        Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("Prebuilt Configurations", New System.Windows.Forms.TreeNode() {New System.Windows.Forms.TreeNode("CSharp"), New System.Windows.Forms.TreeNode("VB.NET"), New System.Windows.Forms.TreeNode("HTML"), New System.Windows.Forms.TreeNode("XML"), New System.Windows.Forms.TreeNode("Pascal"), New System.Windows.Forms.TreeNode("SQL"), New System.Windows.Forms.TreeNode("Java"), New System.Windows.Forms.TreeNode("VBScript"), New System.Windows.Forms.TreeNode("JScript"), New System.Windows.Forms.TreeNode("Default")})})
        Me.treeView1.SelectedImageIndex = -1
        Me.treeView1.Size = New System.Drawing.Size(176, 430)
        Me.treeView1.TabIndex = 0
        '
        'editControl1
        '
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.ChangedLinesMarkingLineColor = System.Drawing.Color.Yellow
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.editControl1.Location = New System.Drawing.Point(176, 0)
        Me.editControl1.Name = "editControl1"
        Me.editControl1.SharedFileMode = True
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowSelectionMargin = False
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.Size = New System.Drawing.Size(528, 430)
        Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.TabIndex = 1
        Me.editControl1.Text = ""
        Me.editControl1.TransferFocusOnTab = True
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 430)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1, Me.treeView1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Configuration Settings Display"
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
    #End Region
    
    
    Private Sub treeView1_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterSelect
        Select Case Me.treeView1.SelectedNode.Text

            Case "CSharp"
                Me.editControl1.GoTo(168, 3)

            Case "HTML"
                Me.editControl1.GoTo(834, 3)

            Case "XML"
                Me.editControl1.GoTo(734, 3)

            Case "Pascal"
                Me.editControl1.GoTo(589, 3)

            Case "VB.NET"
                Me.editControl1.GoTo(1697, 3)

            Case "SQL"
                Me.editControl1.GoTo(1945, 3)

            Case "Java"
                Me.editControl1.GoTo(3209, 3)

            Case "Default"
                Me.editControl1.GoTo(3, 2)

            Case "VBScript"
                Me.editControl1.GoTo(3346, 3)

            Case "JScript"
                Me.editControl1.GoTo(3772, 3)
        End Select
    End Sub 'treeView1_AfterSelect
End Class 'Form2