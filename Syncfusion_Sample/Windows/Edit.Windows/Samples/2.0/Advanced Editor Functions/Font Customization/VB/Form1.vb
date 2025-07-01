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

Imports Syncfusion.Windows.Forms.Edit.Enums

'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents controlLanguageSelector1 As Syncfusion.Windows.Forms.Edit.Dialogs.ControlLanguageSelector
    Private label1 As System.Windows.Forms.Label
    Private controlFormatsList1 As Syncfusion.Windows.Forms.Edit.Dialogs.ControlFormatsList
    Private controlFormatsSettings1 As Syncfusion.Windows.Forms.Edit.Dialogs.ControlFormatsSettings
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private panel2 As System.Windows.Forms.Panel
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private menuItem7 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
		Me.editControl1.ApplyConfiguration(KnownLanguages.CSharp)
        editControl1.Text = "// Code used to customize the Formats :" + vbCr + vbLf + vbCr + vbLf + "#region Windows Form Designer generated code" + vbCr + vbLf + "/*...*/" + vbCr + vbLf + "this.controlLanguageSelector1.EditControl = this.editControl1;" + vbCr + vbLf + vbCr + vbLf + "this.controlFormatsList1.EditControl = this.editControl1;" + vbCr + vbLf + "this.controlFormatsList1.LanguageSelector = this.controlLanguageSelector1;" + vbCr + vbLf + vbCr + vbLf + "this.controlFormatsSettings1.FormatsSelector = this.controlFormatsList1;" + vbCr + vbLf + "/*...*/" + vbCr + vbLf + "#endregion" + vbCr + vbLf
  		editControl1.SaveOnClose = False
    End Sub 'New


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        Me.label1 = New System.Windows.Forms.Label()
        Me.controlLanguageSelector1 = New Syncfusion.Windows.Forms.Edit.Dialogs.ControlLanguageSelector()
        Me.button1 = New System.Windows.Forms.Button()
        Me.controlFormatsList1 = New Syncfusion.Windows.Forms.Edit.Dialogs.ControlFormatsList()
        Me.controlFormatsSettings1 = New Syncfusion.Windows.Forms.Edit.Dialogs.ControlFormatsSettings()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'editControl1
        '
        Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.Name = "editControl1"
        Me.editControl1.OnlyHighlightMatchingBraces = True
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowSelectionMargin = False
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.Size = New System.Drawing.Size(432, 445)
        Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.TabIndex = 0
        Me.editControl1.Text = "editControl1"
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.WordWrap = True
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(8, 272)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(192, 32)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Control used for selecting language:"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'controlLanguageSelector1
        '
        Me.controlLanguageSelector1.EditControl = Me.editControl1
        Me.controlLanguageSelector1.Location = New System.Drawing.Point(16, 304)
        Me.controlLanguageSelector1.Name = "controlLanguageSelector1"
        Me.controlLanguageSelector1.Size = New System.Drawing.Size(176, 20)
        Me.controlLanguageSelector1.TabIndex = 1
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(48, 344)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Show Dialog"
        '
        'controlFormatsList1
        '
        Me.controlFormatsList1.EditControl = Me.editControl1
        Me.controlFormatsList1.LanguageSelector = Me.controlLanguageSelector1
        Me.controlFormatsList1.Location = New System.Drawing.Point(8, 32)
        Me.controlFormatsList1.Name = "controlFormatsList1"
        Me.controlFormatsList1.SelectedFormats = Nothing
        Me.controlFormatsList1.Size = New System.Drawing.Size(200, 224)
        Me.controlFormatsList1.TabIndex = 3
        '
        'controlFormatsSettings1
        '
        Me.controlFormatsSettings1.Formats = Nothing
        Me.controlFormatsSettings1.FormatsSelector = Me.controlFormatsList1
        Me.controlFormatsSettings1.Location = New System.Drawing.Point(224, 40)
        Me.controlFormatsSettings1.Name = "controlFormatsSettings1"
        Me.controlFormatsSettings1.Size = New System.Drawing.Size(336, 376)
        Me.controlFormatsSettings1.TabIndex = 4
        '
        'label2
        '
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(216, 23)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Control for selecting language's format(s):"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(248, 8)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(208, 23)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Control for editing selected formats:"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel2
        '
        Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.controlFormatsSettings1, Me.label3, Me.label2, Me.controlFormatsList1, Me.label1, Me.controlLanguageSelector1, Me.button1})
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel2.Location = New System.Drawing.Point(432, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(568, 445)
        Me.panel2.TabIndex = 3
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.MenuItem9})
        Me.menuItem1.Text = "File"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "New"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "Open"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 2
        Me.menuItem4.Text = "-"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 3
        Me.menuItem5.Text = "Save"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 4
        Me.menuItem6.Text = "SaveAs"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 5
        Me.menuItem7.Text = "-"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 6
        Me.menuItem8.Text = "Close"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 7
        Me.MenuItem9.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1000, 445)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1, Me.panel2})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Name = "Form1"
        Me.Text = "Font Customization"
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
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


    Private Sub controlLanguageSelector1_SelectedLanguageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles controlLanguageSelector1.SelectedLanguageChanged
        ' Changes configuration language currently used control.
        editControl1.Language = controlLanguageSelector1.SelectedLanguage
    End Sub 'controlLanguageSelector1_SelectedLanguageChanged


    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        ' Shows the font customization dialog
        editControl1.ShowFormatsCustomizationDialog()
    End Sub 'button1_Click


    Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, MenuItem9.Click, menuItem8.Click
        Dim mi As MenuItem = sender

        Select Case mi.Text
            Case "New"
                Me.editControl1.NewFile()
            Case "Open"
                Me.editControl1.LoadFile()
            Case "Save"
                Me.editControl1.Save()
            Case "SaveAs"
                Me.editControl1.SaveAs()
            Case "Close"
                Me.editControl1.Close()
            Case "Exit"
                Me.Close()
        End Select
    End Sub 'MainMenuClick

End Class 'Form1