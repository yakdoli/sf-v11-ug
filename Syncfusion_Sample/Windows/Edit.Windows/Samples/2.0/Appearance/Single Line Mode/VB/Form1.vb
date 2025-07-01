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


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
    Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
    Private menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Private menuItem9 As System.Windows.Forms.MenuItem
    Private components As System.ComponentModel.IContainer
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>

    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Me.editControl1.WordWrap = True
        Me.editControl1.ApplyConfiguration(Syncfusion.Windows.Forms.Edit.Enums.KnownLanguages.VBNET)
        Me.editControl1.Text = "Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)"

        Me.editControl1.SingleLineMode = True
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

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Config1 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem2 = New System.Windows.Forms.MenuItem
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.menuItem4 = New System.Windows.Forms.MenuItem
        Me.menuItem5 = New System.Windows.Forms.MenuItem
        Me.menuItem6 = New System.Windows.Forms.MenuItem
        Me.menuItem7 = New System.Windows.Forms.MenuItem
        Me.menuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.menuItem8 = New System.Windows.Forms.MenuItem
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem1})
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem9, Me.MenuItem10, Me.menuItem8})
        Me.menuItem2.Text = "File"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 0
        Me.menuItem3.Text = "New"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 1
        Me.menuItem4.Text = "Open"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 2
        Me.menuItem5.Text = "-"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 3
        Me.menuItem6.Text = "Save"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 4
        Me.menuItem7.Text = "SaveAs"
        '
        'menuItem9
        '
        Me.menuItem9.Index = 5
        Me.menuItem9.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 6
        Me.MenuItem10.Text = "Close"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 7
        Me.menuItem8.Text = "Exit"
        '
        'menuItem1
        '
        Me.menuItem1.Index = 1
        Me.menuItem1.Text = "Toggle SingleLineMode"
        '
        'editControl1
        '
        Me.editControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editControl1.BackColor = System.Drawing.Color.Beige
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.Configurator = Config1
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.editControl1.Location = New System.Drawing.Point(12, 12)
        Me.editControl1.Name = "editControl1"
        Me.editControl1.SaveOnClose = False
        Me.editControl1.SharedFileMode = True
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowLineNumbers = False
        Me.editControl1.ShowOutliningCollapsers = False
        Me.editControl1.ShowSelectionMargin = False
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.Size = New System.Drawing.Size(518, 214)
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.TabIndex = 5
        Me.editControl1.Text = "editControl1"
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.VisualColumn = 13
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(542, 238)
        Me.Controls.Add(Me.editControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Single Line Mode"
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click, menuItem3.Click, menuItem6.Click, menuItem7.Click, menuItem8.Click, MenuItem10.Click
        Dim mi As MenuItem = sender

        Select Case mi.Text
            Case "New"
                ' Create a new file
                Me.editControl1.NewFile()
            Case "Open"
                ' Open an existing file
                Me.editControl1.LoadFile()
            Case "Save"
                ' Save file
                Me.editControl1.Save()
            Case "SaveAs"
                ' Save as a different file
                Me.editControl1.SaveAs()
            Case "Close"
                ' Close the currently loaded file
                Me.editControl1.Close()
            Case "Exit"
                ' Close the host form
                Me.Close()
        End Select
    End Sub 'MainMenuClick

    Private Sub menuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem1.Click
        Me.editControl1.SingleLineMode = Not Me.editControl1.SingleLineMode
    End Sub
End Class 'Form1