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
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private menuItem7 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
    Private WithEvents editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private menuItem9 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem16 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem17 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem18 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem19 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem20 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem21 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem22 As System.Windows.Forms.MenuItem
    Private currentCursor As Cursor = Cursors.Default
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Me.editControl1.LoadFile("..\\Form1.vb")
        Me.editControl1.Cursor = Me.currentCursor
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
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.menuItem10 = New System.Windows.Forms.MenuItem()
        Me.menuItem11 = New System.Windows.Forms.MenuItem()
        Me.menuItem12 = New System.Windows.Forms.MenuItem()
        Me.menuItem13 = New System.Windows.Forms.MenuItem()
        Me.menuItem14 = New System.Windows.Forms.MenuItem()
        Me.menuItem15 = New System.Windows.Forms.MenuItem()
        Me.menuItem16 = New System.Windows.Forms.MenuItem()
        Me.menuItem17 = New System.Windows.Forms.MenuItem()
        Me.menuItem18 = New System.Windows.Forms.MenuItem()
        Me.menuItem19 = New System.Windows.Forms.MenuItem()
        Me.menuItem20 = New System.Windows.Forms.MenuItem()
        Me.menuItem21 = New System.Windows.Forms.MenuItem()
        Me.menuItem22 = New System.Windows.Forms.MenuItem()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem9})
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
        ' editControl1
        ' 
        Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
        Me.editControl1.CurrentColumn = 1
        Me.editControl1.CurrentLine = 1
        Me.editControl1.CurrentPosition = New System.Drawing.Point(1, 1)
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.FileOpened = Nothing
        Me.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default
        Me.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default
        Me.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.editControl1.Name = "editControl1"
        Me.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty
        Me.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red
        Me.editControl1.ShowCollapse = True
        Me.editControl1.ShowHorizontalSplitters = True
        Me.editControl1.ShowLineNumbers = True
        Me.editControl1.ShowMarkers = True
        Me.editControl1.ShowSelectionMargin = True
        Me.editControl1.ShowVerticalSplitters = True
        Me.editControl1.ShowWhitespaces = False
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.TabIndex = 0
        Me.editControl1.TabSize = 2
        Me.editControl1.Text = "editControl1"
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.UserMarginWidth = 100
        ' 
        ' menuItem9
        ' 
        Me.menuItem9.Index = 1
        Me.menuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem10, Me.menuItem11, Me.menuItem12, Me.menuItem13, Me.menuItem14, Me.menuItem15, Me.menuItem16, Me.menuItem17, Me.menuItem18, Me.menuItem19, Me.menuItem20, Me.menuItem21, Me.menuItem22})
        Me.menuItem9.Text = "Cursors"
        ' 
        ' menuItem10
        ' 
        Me.menuItem10.Index = 0
        Me.menuItem10.Text = "AppStarting"
        ' 
        ' menuItem11
        ' 
        Me.menuItem11.Index = 1
        Me.menuItem11.Text = "Arrow"
        ' 
        ' menuItem12
        ' 
        Me.menuItem12.Index = 2
        Me.menuItem12.Text = "Cross"
        ' 
        ' menuItem13
        ' 
        Me.menuItem13.Index = 3
        Me.menuItem13.Text = "Default"
        ' 
        ' menuItem14
        ' 
        Me.menuItem14.Index = 4
        Me.menuItem14.Text = "Hand"
        ' 
        ' menuItem15
        ' 
        Me.menuItem15.Index = 5
        Me.menuItem15.Text = "Help"
        ' 
        ' menuItem16
        ' 
        Me.menuItem16.Index = 6
        Me.menuItem16.Text = "HSplit"
        ' 
        ' menuItem17
        ' 
        Me.menuItem17.Index = 7
        Me.menuItem17.Text = "IBeam"
        ' 
        ' menuItem18
        ' 
        Me.menuItem18.Index = 8
        Me.menuItem18.Text = "No"
        ' 
        ' menuItem19
        ' 
        Me.menuItem19.Index = 9
        Me.menuItem19.Text = "SizeAll"
        ' 
        ' menuItem20
        ' 
        Me.menuItem20.Index = 10
        Me.menuItem20.Text = "UpArrow"
        ' 
        ' menuItem21
        ' 
        Me.menuItem21.Index = 11
        Me.menuItem21.Text = "VSplit"
        ' 
        ' menuItem22
        ' 
        Me.menuItem22.Index = 12
        Me.menuItem22.Text = "WaitCursor"
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
        Me.Text = "Custom Cursor"
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


    Private Sub editControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles editControl1.MouseMove
        Me.editControl1.Cursor = Me.currentCursor
    End Sub 'editControl1_MouseMove


    Private Sub menuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click, menuItem11.Click, menuItem12.Click, menuItem13.Click, menuItem14.Click, menuItem15.Click, menuItem16.Click, menuItem17.Click, menuItem18.Click, menuItem19.Click, menuItem20.Click, menuItem21.Click, menuItem22.Click
        Dim mitem As MenuItem = sender

        If mitem.Text = "AppStarting" Then
            Me.currentCursor = Cursors.AppStarting
        End If
        If mitem.Text = "Arrow" Then
            Me.currentCursor = Cursors.Arrow
        End If
        If mitem.Text = "Cross" Then
            Me.currentCursor = Cursors.Cross
        End If
        If mitem.Text = "Default" Then
            Me.currentCursor = Cursors.Default
        End If
        If mitem.Text = "Hand" Then
            Me.currentCursor = Cursors.Hand
        End If
        If mitem.Text = "Help" Then
            Me.currentCursor = Cursors.Help
        End If
        If mitem.Text = "HSplit" Then
            Me.currentCursor = Cursors.HSplit
        End If
        If mitem.Text = "IBeam" Then
            Me.currentCursor = Cursors.IBeam
        End If
        If mitem.Text = "No" Then
            Me.currentCursor = Cursors.No
        End If
        If mitem.Text = "SizeAll" Then
            Me.currentCursor = Cursors.SizeAll
        End If
        If mitem.Text = "UpArrow" Then
            Me.currentCursor = Cursors.UpArrow
        End If
        If mitem.Text = "VSplit" Then
            Me.currentCursor = Cursors.VSplit
        End If
        If mitem.Text = "WaitCursor" Then
            Me.currentCursor = Cursors.WaitCursor
        End If
        Me.editControl1.Cursor = Me.currentCursor

    End Sub 'menuItem_Click
End Class 'Form1