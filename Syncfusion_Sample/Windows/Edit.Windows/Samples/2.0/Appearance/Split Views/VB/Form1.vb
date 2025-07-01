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
    Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
    Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
    Private WithEvents menuItem16 As System.Windows.Forms.MenuItem
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Form1.vb"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.ShowHorizontalSplitters = True
        Me.editControl1.ShowVerticalSplitters = True
        Me.editControl1.ShowIndicatorMargin = False
		Me.editControl1.SaveOnClose = False
        
        Me.editControl1.LoadFile(filePath)

        Me.editControl1.HorizontalSplitterPosition = 220
        Me.editControl1.TopVerticalSplitterPosition = 260
        Me.editControl1.BottomVerticalSplitterPosition = 260
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.menuItem16 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.menuItem10 = New System.Windows.Forms.MenuItem()
        Me.menuItem11 = New System.Windows.Forms.MenuItem()
        Me.menuItem12 = New System.Windows.Forms.MenuItem()
        Me.menuItem13 = New System.Windows.Forms.MenuItem()
        Me.menuItem14 = New System.Windows.Forms.MenuItem()
        Me.menuItem15 = New System.Windows.Forms.MenuItem()
        Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem9})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem16, Me.menuItem8})
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
        'menuItem16
        '
        Me.menuItem16.Index = 6
        Me.menuItem16.Text = "Close"
        '
        'menuItem8
        '
        Me.menuItem8.Index = 7
        Me.menuItem8.Text = "Exit"
        '
        'menuItem9
        '
        Me.menuItem9.Index = 1
        Me.menuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem10, Me.menuItem11, Me.menuItem12, Me.menuItem13, Me.menuItem14, Me.menuItem15})
        Me.menuItem9.Text = "SplittersMenu"
        '
        'menuItem10
        '
        Me.menuItem10.Checked = True
        Me.menuItem10.Index = 0
        Me.menuItem10.Text = "Show Vertical Splitters"
        '
        'menuItem11
        '
        Me.menuItem11.Checked = True
        Me.menuItem11.Index = 1
        Me.menuItem11.Text = "Show Horizontal Splitters"
        '
        'menuItem12
        '
        Me.menuItem12.Index = 2
        Me.menuItem12.Text = "-"
        '
        'menuItem13
        '
        Me.menuItem13.Index = 3
        Me.menuItem13.Text = "Split into Horizontal halves"
        '
        'menuItem14
        '
        Me.menuItem14.Index = 4
        Me.menuItem14.Text = "Split into Vertical halves"
        '
        'menuItem15
        '
        Me.menuItem15.Index = 5
        Me.menuItem15.Text = "Split into Quadrants"
        '
        'editControl1
        '
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
        Me.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        Me.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.LightBlue
        Me.editControl1.IndentLineColor = System.Drawing.Color.Gray
        Me.editControl1.LineNumbersColor = System.Drawing.Color.DarkBlue
        Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.editControl1.Name = "editControl1"
        Me.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty
        Me.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red
        Me.editControl1.ShowCollapse = True
        Me.editControl1.ShowHorizontalSplitters = True
        Me.editControl1.ShowIndentationGuidelines = True
        Me.editControl1.ShowIndicatorMargin = True
        Me.editControl1.ShowLineNumbers = True
        Me.editControl1.ShowMarkers = True
        Me.editControl1.ShowOutliningCollapsers = True
        Me.editControl1.ShowVerticalSplitters = True
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
        Me.editControl1.Text = "editControl1"
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
        Me.Text = "Split Views"
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
    
    
    Private Sub MainMenuClick(sender As Object, e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem16.Click, menuItem8.Click
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
    
    
    Private Sub SplittersMenuClick(sender As Object, e As System.EventArgs) Handles menuItem10.Click, menuItem11.Click, menuItem13.Click, menuItem14.Click, menuItem15.Click
        Dim mi As MenuItem = sender 
        
        Select Case mi.Text
            Case "Show Horizontal Splitters"
                Me.editControl1.ShowHorizontalSplitters = Not Me.editControl1.ShowHorizontalSplitters
                mi.Checked = Not mi.Checked
            Case "Show Vertical Splitters"
                Me.editControl1.ShowVerticalSplitters = Not Me.editControl1.ShowVerticalSplitters
                mi.Checked = Not mi.Checked
            Case "Split into Vertical halves"
                Me.editControl1.SplitVertically()
            Case "Split into Horizontal halves"
                Me.editControl1.SplitHorizontally()
            Case "Split into Quadrants"
                Me.editControl1.SplitFourQuadrants()
        End Select
    End Sub 'SplittersMenuClick
End Class 'Form1