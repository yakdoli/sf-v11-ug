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
Imports Syncfusion.Windows.Forms.Edit.Enums


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private WithEvents menuItem1 As System.Windows.Forms.MenuItem
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    Private WithEvents editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
    Private menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
    Private menuItem8 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
    Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\CSharpSource.cs"
    
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.ShowLineNumbers = True
        Me.editControl1.ShowIndicatorMargin = True
        Me.editControl1.ShowOutliningCollapsers = True
        
        Me.editControl1.ApplyConfiguration(KnownLanguages.CSharp)
        Me.editControl1.LoadFile(filePath)
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
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.menuItem10 = New System.Windows.Forms.MenuItem()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem1})
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 1
        Me.menuItem1.Text = "&Launch KeyBindingDialog"
        ' 
        ' editControl1
        ' 
        Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
        Me.editControl1.BackColor = System.Drawing.SystemColors.Window
        Me.editControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
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
        Me.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.LightBlue
        Me.editControl1.IndentLineColor = System.Drawing.Color.Gray
        Me.editControl1.Name = "editControl1"
        Me.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty
        Me.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red
        Me.editControl1.ShowCollapse = False
        Me.editControl1.ShowHorizontalSplitters = True
        Me.editControl1.ShowIndentationGuidelines = True
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowLineNumbers = False
        Me.editControl1.ShowMarkers = False
        Me.editControl1.ShowOutliningCollapsers = False
        Me.editControl1.ShowVerticalSplitters = True
        Me.editControl1.ShowWhitespaces = False
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.TabIndex = 0
        Me.editControl1.TabSize = 2
        Me.editControl1.TabStopsArray = New Integer() {8, 16, 24, 32, 40}
        Me.editControl1.Text = ""
        Me.editControl1.TextAreaWidth = 600
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.UserMarginBackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood)
        Me.editControl1.UserMarginTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, System.Byte))
        Me.editControl1.UserMarginWidth = 100
        Me.editControl1.WordWrapMarginBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond)
        Me.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black
        Me.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        ' 
        ' menuItem2
        ' 
        Me.menuItem2.Index = 0
        Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem8, Me.menuItem9, Me.menuItem10})
        Me.menuItem2.Text = "File"
        ' 
        ' menuItem3
        ' 
        Me.menuItem3.Index = 0
        Me.menuItem3.Text = "New"
        ' 
        ' menuItem4
        ' 
        Me.menuItem4.Index = 1
        Me.menuItem4.Text = "Open"
        ' 
        ' menuItem5
        ' 
        Me.menuItem5.Index = 2
        Me.menuItem5.Text = "-"
        ' 
        ' menuItem6
        ' 
        Me.menuItem6.Index = 3
        Me.menuItem6.Text = "Save"
        ' 
        ' menuItem7
        ' 
        Me.menuItem7.Index = 4
        Me.menuItem7.Text = "SaveAs"
        ' 
        ' menuItem8
        ' 
        Me.menuItem8.Index = 5
        Me.menuItem8.Text = "-"
        ' 
        ' menuItem9
        ' 
        Me.menuItem9.Index = 6
        Me.menuItem9.Text = "Close"
        ' 
        ' menuItem10
        ' 
        Me.menuItem10.Index = 7
        Me.menuItem10.Text = "Exit"
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
        Me.Text = "Keys Binding"
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
    
    
    Private Sub menuItem1_Click(sender As Object, e As System.EventArgs) Handles menuItem1.Click
        Me.editControl1.ShowKeysBindingEditor()
    End Sub 'menuItem1_Click
    
    
    ' Bind the action name to the action using the RegisteringKeyCommands and ProcessCommandEventHandler events
    Private Sub editControl1_RegisteringKeyCommands(sender As Object, e As System.EventArgs) Handles editControl1.RegisteringKeyCommands
        AddHandler Me.editControl1.Commands.Add("File.SaveCommand").ProcessCommand, AddressOf Command_Save
        
        AddHandler Me.editControl1.Commands.Add("File.OpenCommand").ProcessCommand, AddressOf Command_Open
        
        AddHandler Me.editControl1.Commands.Add("File.SaveAsCommand").ProcessCommand, AddressOf Command_SaveAs
        
        AddHandler Me.editControl1.Commands.Add("File.NewCommand").ProcessCommand, AddressOf Command_New
    End Sub 'editControl1_RegisteringKeyCommands
    
    
    ' Bind key combinations to the action name using the RegisteringDefaultKeyBindings event
    Private Sub editControl1_RegisteringDefaultKeyBindings(sender As Object, e As System.EventArgs) Handles editControl1.RegisteringDefaultKeyBindings
        Me.editControl1.KeyBinder.BindToCommand(Keys.Control Or Keys.S, "File.SaveCommand")
        Me.editControl1.KeyBinder.BindToCommand(Keys.Control Or Keys.S Or Keys.Shift, "File.SaveAsCommand")
        Me.editControl1.KeyBinder.BindToCommand(Keys.Control Or Keys.N, "File.NewCommand")
        Me.editControl1.KeyBinder.BindToCommand(Keys.Control Or Keys.O, "File.OpenCommand")
    End Sub 'editControl1_RegisteringDefaultKeyBindings
    
    
    ' Define the action that needs to be performed
    Private Sub Command_New()
        Me.editControl1.[New]()
    End Sub 'Command_New
    
    
    Private Sub Command_SaveAs()
        Me.editControl1.SaveAs()
    End Sub 'Command_SaveAs
    
    
    Private Sub Command_Save()
        Me.editControl1.Save()
    End Sub 'Command_Save
    
    
    Private Sub Command_Open()
        Me.editControl1.LoadFile()
    End Sub 'Command_Open
    
    
    Private Sub MainMenuClick(sender As Object, e As System.EventArgs) Handles menuItem3.Click, menuItem4.Click, menuItem6.Click, menuItem7.Click, menuItem9.Click, menuItem10.Click
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
