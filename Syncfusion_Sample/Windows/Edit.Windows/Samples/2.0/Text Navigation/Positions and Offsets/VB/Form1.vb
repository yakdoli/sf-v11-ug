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
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private menuItem7 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Private menuItem9 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
    Private menuItem12 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
    Private menuItem15 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem16 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
    Private statusBar1 As System.Windows.Forms.StatusBar
    Private statusBarPanel1 As System.Windows.Forms.StatusBarPanel
    
    Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\CSharpSource.cs"
    
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.LoadFile(BasePath)
        Me.editControl1.ShowOutliningCollapsers = True
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.ShowHorizontalSplitters = False
		Me.editControl1.BringToFront()

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
    Friend WithEvents EditControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
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
        Me.menuItem11 = New System.Windows.Forms.MenuItem()
        Me.menuItem12 = New System.Windows.Forms.MenuItem()
        Me.menuItem13 = New System.Windows.Forms.MenuItem()
        Me.menuItem15 = New System.Windows.Forms.MenuItem()
        Me.menuItem16 = New System.Windows.Forms.MenuItem()
        Me.menuItem14 = New System.Windows.Forms.MenuItem()
        Me.statusBar1 = New System.Windows.Forms.StatusBar()
        Me.statusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.EditControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem9})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.MenuItem17, Me.menuItem8})
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
        Me.menuItem8.Index = 7
        Me.menuItem8.Text = "Exit"
        '
        'menuItem9
        '
        Me.menuItem9.Index = 1
        Me.menuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem10, Me.menuItem11, Me.menuItem12, Me.menuItem13, Me.menuItem15, Me.menuItem16, Me.menuItem14})
        Me.menuItem9.Text = "PositionMenu"
        '
        'menuItem10
        '
        Me.menuItem10.Index = 0
        Me.menuItem10.Text = "MousePosition To VirtualPosition"
        '
        'menuItem11
        '
        Me.menuItem11.Index = 1
        Me.menuItem11.Text = "MousePosition To PhysicalPosition"
        '
        'menuItem12
        '
        Me.menuItem12.Index = 2
        Me.menuItem12.Text = "-"
        '
        'menuItem13
        '
        Me.menuItem13.Index = 3
        Me.menuItem13.Text = "CursorPosition To PhysicalPosition"
        '
        'menuItem15
        '
        Me.menuItem15.Index = 4
        Me.menuItem15.Text = "-"
        '
        'menuItem16
        '
        Me.menuItem16.Index = 5
        Me.menuItem16.Text = "VirtualPosition To Offset"
        '
        'menuItem14
        '
        Me.menuItem14.Index = 6
        Me.menuItem14.Text = "Offset to VirtualPosition"
        '
        'statusBar1
        '
        Me.statusBar1.Location = New System.Drawing.Point(0, 423)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.statusBarPanel1})
        Me.statusBar1.ShowPanels = True
        Me.statusBar1.Size = New System.Drawing.Size(542, 22)
        Me.statusBar1.SizingGrip = False
        Me.statusBar1.TabIndex = 1
        Me.statusBar1.Text = "statusBar1"
        '
        'statusBarPanel1
        '
        Me.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.statusBarPanel1.Width = 542
        '
        'EditControl1
        '
        Me.EditControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EditControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditControl1.Name = "EditControl1"
        Me.EditControl1.ShowHorizontalSplitters = False
        Me.EditControl1.ShowVerticalSplitters = False
        Me.EditControl1.Size = New System.Drawing.Size(542, 423)
        Me.EditControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
        Me.EditControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.EditControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.EditControl1.TabIndex = 2
        Me.EditControl1.Text = "EditControl1"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 6
        Me.MenuItem17.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 445)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.EditControl1, Me.statusBar1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Positions and Offsets"
        CType(Me.statusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditControl1, System.ComponentModel.ISupportInitialize).EndInit()
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


    Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, MenuItem17.Click, menuItem8.Click
        Dim mi As MenuItem = sender

        Select Case mi.Text
            Case "New"
                Me.EditControl1.NewFile()
            Case "Open"
                Me.EditControl1.LoadFile()
            Case "Save"
                Me.EditControl1.Save()
            Case "SaveAs"
                Me.EditControl1.SaveAs()
            Case "Close"
                Me.EditControl1.Close()
            Case "Exit"
                Me.Close()
        End Select
    End Sub 'MainMenuClick


    Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
        Dim p1, p2 As Point

        p1 = Me.EditControl1.PointToClient(Control.MousePosition)
        p2 = Me.EditControl1.PointToVirtualPosition(p1)

        Me.statusBarPanel1.Text = "MousePosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          "
        Me.statusBarPanel1.Text += "VirtualPosition : (" + p2.X.ToString() + "," + p2.Y.ToString() + ")"
    End Sub 'menuItem10_Click


    Private Sub menuItem11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem11.Click
        Dim p1, p2 As Point

        p1 = Me.EditControl1.PointToClient(Control.MousePosition)
        p2 = Me.EditControl1.PointToPhysicalPosition(p1)

        Me.statusBarPanel1.Text = "MousePosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          "
        Me.statusBarPanel1.Text += "PhysicalPosition : (" + p2.X.ToString() + "," + p2.Y.ToString() + ")"
    End Sub 'menuItem11_Click


    Private Sub menuItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem13.Click
        Dim p1, p2 As Point

        p1 = Me.EditControl1.CurrentPosition
        p2 = Me.EditControl1.ConvertVirtualPositionToPhysical(p1)

        Me.statusBarPanel1.Text = "CursorPosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          "
        Me.statusBarPanel1.Text += "PhysicalPosition : (" + p2.X.ToString() + "," + p2.Y.ToString() + ")"
    End Sub 'menuItem13_Click


    Private Sub menuItem16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem16.Click
        Dim p1 As Point
        Dim offset As Long

        p1 = Me.EditControl1.CurrentPosition
        offset = Me.EditControl1.ConvertVirtualPositionToOffset(p1)

        Me.statusBarPanel1.Text = "CursorPosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          "
        Me.statusBarPanel1.Text += "Offset : " + offset.ToString()
    End Sub 'menuItem16_Click


    Private Sub menuItem14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem14.Click
        Dim p1 As Point
        Dim offset As Long = 60

        p1 = Me.EditControl1.ConvertOffsetToVirtualPosition(offset)
        Me.EditControl1.CurrentPosition = p1

        Me.statusBarPanel1.Text = "CursorPosition : (" + p1.X.ToString() + "," + p1.Y.ToString() + ")          "
        Me.statusBarPanel1.Text += "Offset : " + offset.ToString()
    End Sub 'menuItem14_Click
End Class 'Form1