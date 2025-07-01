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
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.IO


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private menuItem7 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Private WithEvents OpenGroupMenu As System.Windows.Forms.MenuItem
    Private WithEvents CloseGroupMenu As System.Windows.Forms.MenuItem
    Private menuItem12 As System.Windows.Forms.MenuItem
    Private WithEvents UndoMenu As System.Windows.Forms.MenuItem
    Private WithEvents RedoMenu As System.Windows.Forms.MenuItem
    Private menuItem15 As System.Windows.Forms.MenuItem
    Private WithEvents CancelGroupMenu As System.Windows.Forms.MenuItem
    Private WithEvents SavepointMenu As System.Windows.Forms.MenuItem
    Private WithEvents menuItem17 As System.Windows.Forms.MenuItem
    Private components As System.ComponentModel.IContainer
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>

    Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\CSharpSource.cs"



    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Me.editControl1.ShowOutliningCollapsers = True
        Me.editControl1.ShowIndicatorMargin = True

        Me.Size = New Size(550, 500)

        Me.editControl1.LoadFile(filePath)
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
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Config1 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem2 = New System.Windows.Forms.MenuItem
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.menuItem4 = New System.Windows.Forms.MenuItem
        Me.menuItem5 = New System.Windows.Forms.MenuItem
        Me.menuItem6 = New System.Windows.Forms.MenuItem
        Me.menuItem7 = New System.Windows.Forms.MenuItem
        Me.menuItem17 = New System.Windows.Forms.MenuItem
        Me.menuItem8 = New System.Windows.Forms.MenuItem
        Me.menuItem9 = New System.Windows.Forms.MenuItem
        Me.OpenGroupMenu = New System.Windows.Forms.MenuItem
        Me.CloseGroupMenu = New System.Windows.Forms.MenuItem
        Me.CancelGroupMenu = New System.Windows.Forms.MenuItem
        Me.menuItem12 = New System.Windows.Forms.MenuItem
        Me.UndoMenu = New System.Windows.Forms.MenuItem
        Me.RedoMenu = New System.Windows.Forms.MenuItem
        Me.menuItem15 = New System.Windows.Forms.MenuItem
        Me.SavepointMenu = New System.Windows.Forms.MenuItem
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'editControl1
        '
        Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
        Me.editControl1.BackColor = System.Drawing.SystemColors.Window
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.Configurator = Config1
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.DropAllFiles = False
        Me.editControl1.FileExtensions = New String() {".cs", ".htm", ".html", ".java", ".js", ".pas", ".sql", ".vb", ".vbs", ".xml"}
        Me.editControl1.Location = New System.Drawing.Point(0, 0)
        Me.editControl1.Name = "editControl1"
        Me.editControl1.PseudoFileName = ""
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowSelectionMargin = False
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.TabIndex = 0
        Me.editControl1.Text = ""
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.WordWrap = True
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem9})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem17, Me.menuItem8})
        Me.menuItem1.Text = "File"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "&New"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "&Open"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 2
        Me.menuItem4.Text = "-"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 3
        Me.menuItem5.Text = "&Save"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 4
        Me.menuItem6.Text = "Save&As"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 5
        Me.menuItem7.Text = "-"
        '
        'menuItem17
        '
        Me.menuItem17.Index = 6
        Me.menuItem17.Text = "Close"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 7
        Me.menuItem8.Text = "E&xit"
        '
        'menuItem9
        '
        Me.menuItem9.Index = 1
        Me.menuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenGroupMenu, Me.CloseGroupMenu, Me.CancelGroupMenu, Me.menuItem12, Me.UndoMenu, Me.RedoMenu, Me.menuItem15, Me.SavepointMenu})
        Me.menuItem9.Text = "ActionMenu"
        '
        'OpenGroupMenu
        '
        Me.OpenGroupMenu.Index = 0
        Me.OpenGroupMenu.Text = "Open Group"
        '
        'CloseGroupMenu
        '
        Me.CloseGroupMenu.Enabled = False
        Me.CloseGroupMenu.Index = 1
        Me.CloseGroupMenu.Text = "Close Group"
        '
        'CancelGroupMenu
        '
        Me.CancelGroupMenu.Enabled = False
        Me.CancelGroupMenu.Index = 2
        Me.CancelGroupMenu.Text = "Cancel Group"
        '
        'menuItem12
        '
        Me.menuItem12.Index = 3
        Me.menuItem12.Text = "-"
        '
        'UndoMenu
        '
        Me.UndoMenu.Index = 4
        Me.UndoMenu.Text = "Undo"
        '
        'RedoMenu
        '
        Me.RedoMenu.Index = 5
        Me.RedoMenu.Text = "Redo"
        '
        'menuItem15
        '
        Me.menuItem15.Index = 6
        Me.menuItem15.Text = "-"
        '
        'SavepointMenu
        '
        Me.SavepointMenu.Index = 7
        Me.SavepointMenu.Text = "Introduce Save Point"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 445)
        Me.Controls.Add(Me.editControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Action Grouping"
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


    Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem17.Click, menuItem8.Click
        Dim mi As MenuItem = sender

        Select Case mi.Text
            Case "&New"
                Me.editControl1.NewFile()
            Case "&Open"
                Me.editControl1.LoadFile()
            Case "&Save"
                Me.editControl1.Save()
            Case "Save&As"
                Me.editControl1.SaveAs()
            Case "Close"
                Me.editControl1.Close()
            Case "E&xit"
                Me.Close()
        End Select
    End Sub 'MainMenuClick


    Private Sub ActionMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenGroupMenu.Click, CloseGroupMenu.Click, CancelGroupMenu.Click, UndoMenu.Click, RedoMenu.Click, SavepointMenu.Click
        Dim mi As MenuItem = sender

        Select Case mi.Text
            Case "Open Group"

                Me.editControl1.UndoGroupOpen()
                Me.CloseGroupMenu.Enabled = True
                Me.CancelGroupMenu.Enabled = True
                Me.OpenGroupMenu.Enabled = False

            Case "Close Group"
                Try
                    Me.editControl1.UndoGroupClose()
                    Me.CloseGroupMenu.Enabled = False
                    Me.CancelGroupMenu.Enabled = False
                    Me.OpenGroupMenu.Enabled = True
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Alert")
                End Try

            Case "Cancel Group"
                Try
                    Me.editControl1.UndoGroupCancel()
                    Me.CloseGroupMenu.Enabled = False
                    Me.CancelGroupMenu.Enabled = False
                    Me.OpenGroupMenu.Enabled = True

                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Alert")
                End Try

            Case "Undo"
                Me.editControl1.Undo()

            Case "Redo"
                Me.editControl1.Redo()

            Case "Introduce Save Point"
                Me.editControl1.ResetUndoInfo()
        End Select
    End Sub 'ActionMenuClick

    Private Sub menuItem9_Select(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem9.Select
        Me.UndoMenu.Enabled = Me.editControl1.CanUndo
        Me.RedoMenu.Enabled = Me.editControl1.CanRedo
    End Sub
End Class 'Form1