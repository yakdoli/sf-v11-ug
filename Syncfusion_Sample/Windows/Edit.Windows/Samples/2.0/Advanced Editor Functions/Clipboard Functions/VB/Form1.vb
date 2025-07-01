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
Imports System.Diagnostics
Imports System.Runtime.InteropServices

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.IO

Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization
Imports Syncfusion.Windows.Forms.Edit.Implementation


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
    Private menuItem8 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
    Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private menuItem11 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
    Private menuItem14 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem16 As System.Windows.Forms.MenuItem
    Private menuItem17 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem18 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem19 As System.Windows.Forms.MenuItem
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Test.cs"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.LoadFile(filePath)
        Me.editControl1.ShowOutliningCollapsers = True


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
        Dim resources As New System.Resources.ResourceManager(GetType(Form1))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem11 = New System.Windows.Forms.MenuItem()
        Me.menuItem12 = New System.Windows.Forms.MenuItem()
        Me.menuItem13 = New System.Windows.Forms.MenuItem()
        Me.menuItem14 = New System.Windows.Forms.MenuItem()
        Me.menuItem15 = New System.Windows.Forms.MenuItem()
        Me.menuItem16 = New System.Windows.Forms.MenuItem()
        Me.menuItem17 = New System.Windows.Forms.MenuItem()
        Me.menuItem18 = New System.Windows.Forms.MenuItem()
        Me.menuItem19 = New System.Windows.Forms.MenuItem()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.menuItem10 = New System.Windows.Forms.MenuItem()
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem11, Me.menuItem1})
        ' 
        ' menuItem11
        ' 
        Me.menuItem11.Index = 0
        Me.menuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem12, Me.menuItem13, Me.menuItem14, Me.menuItem15, Me.menuItem16, Me.menuItem17, Me.menuItem18, Me.menuItem19})
        Me.menuItem11.Text = "File"
        ' 
        ' menuItem12
        ' 
        Me.menuItem12.Index = 0
        Me.menuItem12.Text = "New"
        ' 
        ' menuItem13
        ' 
        Me.menuItem13.Index = 1
        Me.menuItem13.Text = "Open"
        ' 
        ' menuItem14
        ' 
        Me.menuItem14.Index = 2
        Me.menuItem14.Text = "-"
        ' 
        ' menuItem15
        ' 
        Me.menuItem15.Index = 3
        Me.menuItem15.Text = "Save"
        ' 
        ' menuItem16
        ' 
        Me.menuItem16.Index = 4
        Me.menuItem16.Text = "SaveAs..."
        ' 
        ' menuItem17
        ' 
        Me.menuItem17.Index = 5
        Me.menuItem17.Text = "-"
        ' 
        ' menuItem18
        ' 
        Me.menuItem18.Index = 6
        Me.menuItem18.Text = "Close"
        ' 
        ' menuItem19
        ' 
        Me.menuItem19.Index = 7
        Me.menuItem19.Text = "Exit"
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 1
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.menuItem9, Me.menuItem10})
        Me.menuItem1.Text = "&Edit"
        ' 
        ' menuItem2
        ' 
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "&Undo"
        ' 
        ' menuItem3
        ' 
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "&Redo"
        ' 
        ' menuItem4
        ' 
        Me.menuItem4.Index = 2
        Me.menuItem4.Text = "-"
        ' 
        ' menuItem5
        ' 
        Me.menuItem5.Index = 3
        Me.menuItem5.Text = "Cu&t"
        ' 
        ' menuItem6
        ' 
        Me.menuItem6.Index = 4
        Me.menuItem6.Text = "&Copy"
        ' 
        ' menuItem7
        ' 
        Me.menuItem7.Index = 5
        Me.menuItem7.Text = "&Paste"
        ' 
        ' menuItem8
        ' 
        Me.menuItem8.Index = 6
        Me.menuItem8.Text = "-"
        ' 
        ' menuItem9
        ' 
        Me.menuItem9.Index = 7
        Me.menuItem9.Text = "Select &All"
        ' 
        ' menuItem10
        ' 
        Me.menuItem10.Index = 8
        Me.menuItem10.Text = "Ca&ncel Selection"
        ' 
        ' editControl1
        ' 
        Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
        Me.editControl1.BackColor = System.Drawing.SystemColors.Window
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.editControl1.Name = "editControl1"
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowLineNumbers = False
        Me.editControl1.SaveOnClose = False
        Me.editControl1.ShowOutliningCollapsers = False
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.TabIndex = 0
        Me.editControl1.Text = ""
        Me.editControl1.TransferFocusOnTab = True
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 445)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Clipboard Functions"
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
    #End Region
    
    
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()>  _
    Shared Sub Main()
Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub 'Main
    
    
    Private Sub MainMenuClick(sender As Object, e As System.EventArgs) Handles menuItem12.Click, menuItem13.Click, menuItem15.Click, menuItem16.Click, menuItem18.Click, menuItem19.Click
        Dim mi As MenuItem = sender 
        
        Select Case mi.Text
            Case "New"
                Me.editControl1.NewFile()
            Case "Open"
                Me.editControl1.LoadFile()
            Case "Save"
                Me.editControl1.Save()
            Case "SaveAs..."
                Me.editControl1.SaveAs()
            Case "Close"
                Me.editControl1.Close()
            Case "Exit"
                Me.Close()
        End Select
    End Sub 'MainMenuClick
    
    
    Private Sub EditMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem7.Click, menuItem9.Click, menuItem10.Click
        Dim mi As MenuItem = sender

        Select Case mi.Text
            Case "&Undo"
                Me.editControl1.Undo()
            Case "&Redo"
                Me.editControl1.Redo()
            Case "Cu&t"
                Me.editControl1.Cut()
            Case "&Copy"
                Me.editControl1.Copy()
            Case "&Paste"
                Me.editControl1.Paste()
            Case "Select &All"
                Me.editControl1.SelectAll()
            Case "Ca&ncel Selection"
                Me.editControl1.SelectionCancel()
        End Select
    End Sub 'EditMenuClick


    Private Sub menuItem1_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem1.Popup
        Me.menuItem2.Enabled = Me.editControl1.CanUndo
        Me.menuItem3.Enabled = Me.editControl1.CanRedo
        If Not editControl1.Selection Is Nothing Then
            Me.menuItem6.Enabled = True
            Me.menuItem5.Enabled = True
        Else
            Me.menuItem6.Enabled = False
            Me.menuItem5.Enabled = False
        End If

        If Not editControl1.Selection Is Nothing Then
            menuItem10.Enabled = True
        Else
            menuItem10.Enabled = False
        End If
    End Sub
End Class 'Form1