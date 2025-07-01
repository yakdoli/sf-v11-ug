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


Namespace IndentationGuidelinesDemo
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
        Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
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

            Me.editControl1.ShowIndentationGuidelines = True
            Me.editControl1.IndentLineColor = Color.Khaki
            Me.editControl1.IndentBlockHighlightingColor = Color.IndianRed

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
        Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
            Me.mainMenu1 = New System.Windows.Forms.MainMenu()
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
            Me.MenuItem11 = New System.Windows.Forms.MenuItem()
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'editControl1
            '
            Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
            Me.editControl1.BackColor = System.Drawing.SystemColors.Window
            Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editControl1.Name = "editControl1"
            Me.editControl1.ShowHorizontalSplitters = False
            Me.editControl1.ShowSelectionMargin = False
            Me.editControl1.ShowVerticalSplitters = False
            Me.editControl1.Size = New System.Drawing.Size(544, 445)
            Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
            Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
            Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
            Me.editControl1.TabIndex = 0
            Me.editControl1.Text = "editControl1"
            Me.editControl1.TransferFocusOnTab = True
            Me.editControl1.WordWrap = True
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem9, Me.menuItem10})
            '
            'menuItem1
            '
            Me.menuItem1.Index = 0
            Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.MenuItem11, Me.menuItem8})
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
            'menuItem8
            '
            Me.menuItem8.Index = 7
            Me.menuItem8.Text = "E&xit"
            '
            'menuItem9
            '
            Me.menuItem9.Index = 1
            Me.menuItem9.Text = "JumpToStart"
            '
            'menuItem10
            '
            Me.menuItem10.Index = 2
            Me.menuItem10.Text = "JumpToEnd"
            '
            'MenuItem11
            '
            Me.MenuItem11.Index = 6
            Me.MenuItem11.Text = "Close"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(544, 445)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Menu = Me.mainMenu1
            Me.Name = "Form1"
            Me.Text = "Indentation Guidelines Demo"
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


        Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, MenuItem11.Click, menuItem8.Click

            Dim mi As MenuItem = sender

            Select Case mi.Text
                Case "&New"
                    Me.editControl1.NewFile()
                    Exit Sub
                Case "&Open"
                    Me.editControl1.LoadFile()
                    Exit Sub
                Case "&Save"
                    Me.editControl1.Save()
                    Exit Sub
                Case "Save&As"
                    Me.editControl1.SaveAs()
                    Exit Sub
                Case "Close"
                    Me.editControl1.Close()
                    Exit Sub
                Case "E&xit"
                    Me.Close()
                    Exit Sub
            End Select
        End Sub

        Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
            Me.editControl1.JumpToIndentBlockStart()
        End Sub 'menuItem9_Click

        Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
            Me.editControl1.JumpToIndentBlockEnd()
        End Sub 'menuItem10_Click

    End Class 'Form1
End Namespace 'editcontrol_basic