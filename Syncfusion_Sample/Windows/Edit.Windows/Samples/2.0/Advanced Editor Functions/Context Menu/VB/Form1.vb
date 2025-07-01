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

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Implementation



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
    Private components As System.ComponentModel.IContainer
    
    Private basePath As String = "..\Test Files\PascalSource.pas"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Me.editControl1.ShowIndicatorMargin = True
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowVerticalSplitters = False

        Me.editControl1.LoadFile(basePath)
        
        ' Enable or disable context menu
        ' this.editControl1.ContextMenuManager.Enabled = false;

        ' Switch to XPMenus PopupMenu
        ' If the Syncfusion.Tools.Windows assembly was loaded before context menu is instantiated for the first time,
        ' then a XPMenus PopupMenu is shown. Otherwise, a standard .NET context menu is shown.

        ' Instantiating a type from SSyncfusion.Tools.Windows assembly loads the assembly 
        ' (you also need to have reference to the Syncfusion.Tools.Windows assembly in your project references)
        ' new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();

        ' You can also explicitly set the look and feel of context menu 
        ' Show Office2003 style context menu
        ' this.editControl1.ContextMenuManager.ContextMenuProvider = new Syncfusion.Windows.Forms.Tools.XPMenus.XPMenusProvider();

        ' Show standard style context menu
        ' this.editControl1.ContextMenuManager.ContextMenuProvider = new Syncfusion.Windows.Forms.StandardMenusProvider();

        ' Add a event handler that is called each time the menu is dropped down where you can add custom menu items.
        AddHandler Me.editControl1.MenuFill, AddressOf cm_FillMenu
    End Sub 'New
    
    
    
    Private Sub cm_FillMenu(sender As Object, e As EventArgs)
        Dim cm As ContextMenuManager = CType(sender, ContextMenuManager)
        
        ' To clear default context menu items 
        ' cm.ClearMenu();
        ' Add a separator
        cm.AddSeparator()
        
        ' Add custom custom context menu items and their Click eventhandlers
        cm.AddMenuItem("&Find", New EventHandler(AddressOf ShowFindDialog))
        cm.AddMenuItem("&Replace", New EventHandler(AddressOf ShowReplaceDialog))
        cm.AddMenuItem("&Goto", New EventHandler(AddressOf ShowGoToDialog))
        
        
        ' If you need to get access to the underlying menu provider you can access it via:
        Dim contextMenuProvider As Syncfusion.Windows.Forms.IContextMenuProvider = Me.editControl1.ContextMenuManager.ContextMenuProvider
    End Sub 'cm_FillMenu
     '	contextMenuProvider.SetContextMenuItemChecked(...);
    '	contextMenuProvider.SetContextMenuItemEnabled(...);
    '	contextMenuProvider.SetContextMenuItemImage(...);
    '	contextMenuProvider.SetContextMenuItemShortcut(...);
    
    
    Sub ShowFindDialog(sender As Object, e As EventArgs)
        Me.editControl1.ShowFindDialog()
    End Sub 'ShowFindDialog
    
    
    Sub ShowReplaceDialog(sender As Object, e As EventArgs)
        Me.editControl1.ShowReplaceDialog()
    End Sub 'ShowReplaceDialog
    
    
    Sub ShowGoToDialog(sender As Object, e As EventArgs)
        Me.editControl1.ShowGoToDialog()
    End Sub 'ShowGoToDialog
    
    
    
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
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' editControl1
        ' 
        Me.editControl1.AutoIndentMode = Enums.AutoIndentMode.Smart
        Me.editControl1.AutoScrollPosition = New System.Drawing.Point(0, 0)
        Me.editControl1.BackColor = System.Drawing.SystemColors.Window
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.CurrentColumn = 1
        Me.editControl1.CurrentLine = 1
        Me.editControl1.CurrentPosition = New System.Drawing.Point(1, 1)
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.FileOpened = Nothing
        Me.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default
        Me.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default
        Me.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.editControl1.Name = "editControl1"
        Me.editControl1.ScrollOffsetBottom = 0
        Me.editControl1.ScrollOffsetLeft = 24
        Me.editControl1.ScrollOffsetRight = 0
        Me.editControl1.ScrollOffsetTop = 0
        Me.editControl1.ShowCollapse = True
        Me.editControl1.ShowLineNumbers = True
        Me.editControl1.ShowMarkers = False
        Me.editControl1.ShowWhitespaces = False
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.TabIndex = 0
        Me.editControl1.TabSize = 2
        Me.editControl1.Text = ""
        Me.editControl1.VirtualSize = New System.Drawing.Size(0, 17)
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8})
        Me.menuItem1.Text = "File"
        ' 
        ' menuItem2
        ' 
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "New"
        ' 
        ' menuItem3
        ' 
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "Open"
        ' 
        ' menuItem4
        ' 
        Me.menuItem4.Index = 2
        Me.menuItem4.Text = "-"
        ' 
        ' menuItem5
        ' 
        Me.menuItem5.Index = 3
        Me.menuItem5.Text = "Save"
        ' 
        ' menuItem6
        ' 
        Me.menuItem6.Index = 4
        Me.menuItem6.Text = "SaveAs"
        ' 
        ' menuItem7
        ' 
        Me.menuItem7.Index = 5
        Me.menuItem7.Text = "-"
        ' 
        ' menuItem8
        ' 
        Me.menuItem8.Index = 6
        Me.menuItem8.Text = "Exit"
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
        Me.Text = "Context Menu"
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
    
    
    Private Sub menuItem2_Click(sender As Object, e As System.EventArgs) Handles menuItem2.Click
        Me.editControl1.NewFile()
    End Sub 'menuItem2_Click
    
    
    Private Sub menuItem3_Click(sender As Object, e As System.EventArgs) Handles menuItem3.Click
        Me.editControl1.LoadFile()
    End Sub 'menuItem3_Click
    
    
    Private Sub menuItem5_Click(sender As Object, e As System.EventArgs) Handles menuItem5.Click
        Me.editControl1.Save()
    End Sub 'menuItem5_Click
    
    
    Private Sub menuItem6_Click(sender As Object, e As System.EventArgs) Handles menuItem6.Click
        Me.editControl1.SaveAs()
    End Sub 'menuItem6_Click
    
    
    Private Sub menuItem8_Click(sender As Object, e As System.EventArgs) Handles menuItem8.Click
        Me.Close()
    End Sub 'menuItem8_Click
    
    
    Private Sub Form1_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    End Sub 'Form1_Closing
End Class 'Form1