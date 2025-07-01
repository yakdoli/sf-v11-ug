#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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
Imports System.Runtime.InteropServices '
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


Public Class Form1
    Inherits System.Windows.Forms.Form '

    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem4 As System.Windows.Forms.MenuItem

    Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "..\..\Test Files\Test.lsp"
    Private ConfigPath As String = Path.GetDirectoryName(Application.ExecutablePath) + "..\..\..\VB\config.xml"

    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing

    Private menuItem6 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
    Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem8 As System.Windows.Forms.MenuItem



    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Me.editControl1.CurrentColumn = 0
        Me.editControl1.CurrentLine = 0

        Me.editControl1.Configurator.Open(ConfigPath)
        Me.editControl1.ApplyConfiguration("LISP")
        Me.editControl1.LoadFile(BasePath)

        Me.editControl1.ShowOutliningCollapsers = True
        Me.editControl1.ShowLineNumbers = True
        Me.editControl1.ShowSelectionMargin = False
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
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem8, Me.menuItem9})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.MenuItem11, Me.menuItem5, Me.menuItem4, Me.menuItem6, Me.MenuItem10, Me.menuItem7})
        Me.menuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.menuItem1.Text = "&File"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.menuItem2.ShowShortcut = False
        Me.menuItem2.Text = "&New"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.menuItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.menuItem3.ShowShortcut = False
        Me.menuItem3.Text = "&Open"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 2
        Me.MenuItem11.Text = "-"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 3
        Me.menuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.menuItem5.ShowShortcut = False
        Me.menuItem5.Text = "&Save"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 4
        Me.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
        Me.menuItem4.ShowShortcut = False
        Me.menuItem4.Text = "Save&As"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 5
        Me.menuItem6.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 6
        Me.MenuItem10.Text = "Close"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 7
        Me.menuItem7.Text = "E&xit"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 1
        Me.menuItem8.Text = "Load TestFile"
        '
        'menuItem9
        '
        Me.menuItem9.Index = 2
        Me.menuItem9.Text = "Display ConfigFile"
        '
        'editControl1
        '
        Me.editControl1.BackColor = System.Drawing.SystemColors.Window
        Me.editControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo()
        Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.editControl1.ColumnGuideItems = New Syncfusion.Windows.Forms.Edit.Utils.ColumnGuideItem(-1) {}
        Me.editControl1.ColumnGuidesMeasuringFont = New System.Drawing.Font("Courier New", 10.0!)
        Me.editControl1.ContextChoiceSize = New System.Drawing.Size(176, 88)
        Me.editControl1.ContextPromptBackgroundBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.LemonChiffon)
        Me.editControl1.ContextPromptCustomSize = New System.Drawing.Size(400, 50)
        Me.editControl1.ContextTooltipBackgroundBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.LemonChiffon)
        Me.editControl1.CurrentColumn = 1
        Me.editControl1.CurrentLine = 1
        Me.editControl1.CurrentPosition = New System.Drawing.Point(1, 1)
        Me.editControl1.CustomLineWrappingMarkingImage = Nothing
        Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editControl1.FileOpened = Nothing
        Me.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default
        Me.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default
        Me.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.LightBlue
        Me.editControl1.IndentLineColor = System.Drawing.Color.Gray
        Me.editControl1.LineNumbersColor = System.Drawing.Color.DarkBlue
        Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.editControl1.Name = "editControl1"
        Me.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty
        Me.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red
        Me.editControl1.ShowCollapse = True
        Me.editControl1.ShowHorizontalSplitters = False
        Me.editControl1.ShowIndentationGuidelines = True
        Me.editControl1.ShowIndicatorMargin = False
        Me.editControl1.ShowLineNumbers = False
        Me.editControl1.ShowMarkers = False
        Me.editControl1.ShowOutliningCollapsers = True
        Me.editControl1.ShowVerticalSplitters = False
        Me.editControl1.ShowWhitespaces = False
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.StatusBarSettings.CoordsPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.editControl1.StatusBarSettings.CoordsPanel.MinWidth = 10
        Me.editControl1.StatusBarSettings.CoordsPanel.Visible = True
        Me.editControl1.StatusBarSettings.CoordsPanel.Width = 148
        Me.editControl1.StatusBarSettings.EncodingPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0
        Me.editControl1.StatusBarSettings.EncodingPanel.Visible = True
        Me.editControl1.StatusBarSettings.EncodingPanel.Width = 165
        Me.editControl1.StatusBarSettings.InsertPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.editControl1.StatusBarSettings.InsertPanel.MinWidth = 10
        Me.editControl1.StatusBarSettings.InsertPanel.Visible = True
        Me.editControl1.StatusBarSettings.InsertPanel.Width = 33
        Me.editControl1.StatusBarSettings.StatusPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
        Me.editControl1.StatusBarSettings.StatusPanel.Visible = True
        Me.editControl1.StatusBarSettings.StatusPanel.Width = 70
        Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.editControl1.StatusBarSettings.TextPanel.MinWidth = 10
        Me.editControl1.StatusBarSettings.TextPanel.Visible = True
        Me.editControl1.StatusBarSettings.TextPanel.Width = 96
        Me.editControl1.TabIndex = 0
        Me.editControl1.TabSize = 2
        Me.editControl1.TabStopsArray = New Integer() {8, 16, 24, 32, 40}
        Me.editControl1.Text = ""
        Me.editControl1.TextAreaWidth = 600
        Me.editControl1.UserMarginBackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood)
        Me.editControl1.UserMarginTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.editControl1.UserMarginWidth = 100
        Me.editControl1.WordWrapMarginBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond)
        Me.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black
        Me.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(542, 445)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Custom Config File"
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

    Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem4.Click, MenuItem10.Click, menuItem7.Click
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


    Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
        Me.editControl1.LoadFile(ConfigPath)
        Me.editControl1.ApplyConfiguration("XML")
    End Sub 'menuItem9_Click

    Private Sub menuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuItem8.Click
        Me.editControl1.LoadFile(BasePath)
        Me.editControl1.ApplyConfiguration("LISP")
    End Sub
End Class 'Form1 
