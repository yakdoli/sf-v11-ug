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
Imports System.Drawing.Drawing2D

Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Enums
Imports Syncfusion.Windows.Forms.Edit.Implementation
Imports Syncfusion.Drawing


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
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private menuItem10 As System.Windows.Forms.MenuItem
    Private menuItem11 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem12 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
    Private menuItem16 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem17 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem18 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem19 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem20 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem21 As System.Windows.Forms.MenuItem
    Private menuItem22 As System.Windows.Forms.MenuItem
    Private menuItem23 As System.Windows.Forms.MenuItem
    Private menuItem24 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem25 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem26 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem27 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem28 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem29 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem30 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem31 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem32 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem33 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem34 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem35 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem36 As System.Windows.Forms.MenuItem
    Private menuItem37 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem38 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem39 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem40 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem41 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem42 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem43 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem44 As System.Windows.Forms.MenuItem
    
    Private filePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\VBSource.vb"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.LoadFile(filePath)
        
        Me.editControl1.WordWrap = True
        Me.editControl1.WordWrapMode = WordWrapMode.WordWrapMargin
        Me.editControl1.WordWrapType = WordWrapType.WrapByChar
        Me.editControl1.TextAreaWidth = 350
        Me.editControl1.WordWrapMarginLineStyle = DashStyle.Dash
        Me.editControl1.WordWrapMarginLineColor = Color.Green
        Me.editControl1.WordWrapMarginBrush = New BrushInfo(gradientStyle, m_foreColor, m_backColor)
        Me.editControl1.WordWrapMarginVisible = True
        
        Me.Size = New Size(568, 408)
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
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.menuItem8 = New System.Windows.Forms.MenuItem()
        Me.menuItem10 = New System.Windows.Forms.MenuItem()
        Me.menuItem12 = New System.Windows.Forms.MenuItem()
        Me.menuItem13 = New System.Windows.Forms.MenuItem()
        Me.menuItem11 = New System.Windows.Forms.MenuItem()
        Me.menuItem14 = New System.Windows.Forms.MenuItem()
        Me.menuItem15 = New System.Windows.Forms.MenuItem()
        Me.menuItem16 = New System.Windows.Forms.MenuItem()
        Me.menuItem17 = New System.Windows.Forms.MenuItem()
        Me.menuItem18 = New System.Windows.Forms.MenuItem()
        Me.menuItem19 = New System.Windows.Forms.MenuItem()
        Me.menuItem20 = New System.Windows.Forms.MenuItem()
        Me.menuItem21 = New System.Windows.Forms.MenuItem()
        Me.menuItem22 = New System.Windows.Forms.MenuItem()
        Me.menuItem25 = New System.Windows.Forms.MenuItem()
        Me.menuItem26 = New System.Windows.Forms.MenuItem()
        Me.menuItem27 = New System.Windows.Forms.MenuItem()
        Me.menuItem28 = New System.Windows.Forms.MenuItem()
        Me.menuItem23 = New System.Windows.Forms.MenuItem()
        Me.menuItem29 = New System.Windows.Forms.MenuItem()
        Me.menuItem30 = New System.Windows.Forms.MenuItem()
        Me.menuItem31 = New System.Windows.Forms.MenuItem()
        Me.menuItem32 = New System.Windows.Forms.MenuItem()
        Me.menuItem24 = New System.Windows.Forms.MenuItem()
        Me.menuItem33 = New System.Windows.Forms.MenuItem()
        Me.menuItem34 = New System.Windows.Forms.MenuItem()
        Me.menuItem35 = New System.Windows.Forms.MenuItem()
        Me.menuItem36 = New System.Windows.Forms.MenuItem()
        Me.menuItem37 = New System.Windows.Forms.MenuItem()
        Me.menuItem38 = New System.Windows.Forms.MenuItem()
        Me.menuItem39 = New System.Windows.Forms.MenuItem()
        Me.menuItem40 = New System.Windows.Forms.MenuItem()
        Me.menuItem41 = New System.Windows.Forms.MenuItem()
        Me.menuItem42 = New System.Windows.Forms.MenuItem()
        Me.menuItem43 = New System.Windows.Forms.MenuItem()
        Me.menuItem44 = New System.Windows.Forms.MenuItem()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' editControl1
        ' 
        Me.editControl1.AutoIndentMode = AutoIndentMode.Smart
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
        Me.editControl1.ShowCollapse = True
        Me.editControl1.ShowHorizontalSplitters = True
        Me.editControl1.ShowIndentationGuidelines = True
        Me.editControl1.ShowLineNumbers = True
        Me.editControl1.ShowMarkers = False
        Me.editControl1.ShowSelectionMargin = False
        Me.editControl1.ShowVerticalSplitters = True
        Me.editControl1.ShowWhitespaces = False
        Me.editControl1.Size = New System.Drawing.Size(512, 445)
        Me.editControl1.TabIndex = 0
        Me.editControl1.TabSize = 2
        Me.editControl1.Text = ""
        Me.editControl1.TextAreaWidth = 600
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.UserMarginBackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood)
        Me.editControl1.UserMarginWidth = 100
        Me.editControl1.UserMarginTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, System.Byte))
        Me.editControl1.WordWrap = True
        Me.editControl1.WordWrapMarginBrush = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond)
        Me.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black
        Me.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem10, Me.menuItem11, Me.menuItem16, Me.menuItem22, Me.menuItem23, Me.menuItem24, Me.menuItem37})
        ' 
        ' menuItem1
        ' 
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6, Me.menuItem7, Me.menuItem9, Me.menuItem8})
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
        ' menuItem9
        ' 
        Me.menuItem9.Index = 6
        Me.menuItem9.Text = "Close"
        ' 
        ' menuItem8
        ' 
        Me.menuItem8.Index = 7
        Me.menuItem8.Text = "Exit"
        ' 
        ' menuItem10
        ' 
        Me.menuItem10.Index = 1
        Me.menuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem12, Me.menuItem13})
        Me.menuItem10.Text = "WrapMode"
        ' 
        ' menuItem12
        ' 
        Me.menuItem12.Index = 0
        Me.menuItem12.Text = "Control"
        ' 
        ' menuItem13
        ' 
        Me.menuItem13.Index = 1
        Me.menuItem13.Text = "TextArea"
        ' 
        ' menuItem11
        ' 
        Me.menuItem11.Index = 2
        Me.menuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem14, Me.menuItem15})
        Me.menuItem11.Text = " WrapType"
        ' 
        ' menuItem14
        ' 
        Me.menuItem14.Index = 0
        Me.menuItem14.Text = "Character"
        ' 
        ' menuItem15
        ' 
        Me.menuItem15.Index = 1
        Me.menuItem15.Text = "Word"
        ' 
        ' menuItem16
        ' 
        Me.menuItem16.Index = 3
        Me.menuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem17, Me.menuItem18, Me.menuItem19, Me.menuItem20, Me.menuItem21})
        Me.menuItem16.Text = "LineStyle"
        ' 
        ' menuItem17
        ' 
        Me.menuItem17.Index = 0
        Me.menuItem17.Text = "Dash"
        ' 
        ' menuItem18
        ' 
        Me.menuItem18.Index = 1
        Me.menuItem18.Text = "DashDot"
        ' 
        ' menuItem19
        ' 
        Me.menuItem19.Index = 2
        Me.menuItem19.Text = "DashDotDot"
        ' 
        ' menuItem20
        ' 
        Me.menuItem20.Index = 3
        Me.menuItem20.Text = "Dot"
        ' 
        ' menuItem21
        ' 
        Me.menuItem21.Index = 4
        Me.menuItem21.Text = "Solid"
        ' 
        ' menuItem22
        ' 
        Me.menuItem22.Index = 4
        Me.menuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem25, Me.menuItem26, Me.menuItem27, Me.menuItem28})
        Me.menuItem22.Text = "LineColor"
        ' 
        ' menuItem25
        ' 
        Me.menuItem25.Index = 0
        Me.menuItem25.Text = "Green"
        ' 
        ' menuItem26
        ' 
        Me.menuItem26.Index = 1
        Me.menuItem26.Text = "Navy"
        ' 
        ' menuItem27
        ' 
        Me.menuItem27.Index = 2
        Me.menuItem27.Text = "IndianRed"
        ' 
        ' menuItem28
        ' 
        Me.menuItem28.Index = 3
        Me.menuItem28.Text = "Aqua"
        ' 
        ' menuItem23
        ' 
        Me.menuItem23.Index = 5
        Me.menuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem29, Me.menuItem30, Me.menuItem31, Me.menuItem32})
        Me.menuItem23.Text = "ForeColor"
        ' 
        ' menuItem29
        ' 
        Me.menuItem29.Index = 0
        Me.menuItem29.Text = "Salmon"
        ' 
        ' menuItem30
        ' 
        Me.menuItem30.Index = 1
        Me.menuItem30.Text = "Orange"
        ' 
        ' menuItem31
        ' 
        Me.menuItem31.Index = 2
        Me.menuItem31.Text = "Blue"
        ' 
        ' menuItem32
        ' 
        Me.menuItem32.Index = 3
        Me.menuItem32.Text = "Pink"
        ' 
        ' menuItem24
        ' 
        Me.menuItem24.Index = 6
        Me.menuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem33, Me.menuItem34, Me.menuItem35, Me.menuItem36})
        Me.menuItem24.Text = "BackColor"
        ' 
        ' menuItem33
        ' 
        Me.menuItem33.Index = 0
        Me.menuItem33.Text = "Beige"
        ' 
        ' menuItem34
        ' 
        Me.menuItem34.Index = 1
        Me.menuItem34.Text = "LightYellow"
        ' 
        ' menuItem35
        ' 
        Me.menuItem35.Index = 2
        Me.menuItem35.Text = "LightSalmon"
        ' 
        ' menuItem36
        ' 
        Me.menuItem36.Index = 3
        Me.menuItem36.Text = "Silver"
        ' 
        ' menuItem37
        ' 
        Me.menuItem37.Index = 7
        Me.menuItem37.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem38, Me.menuItem39, Me.menuItem40, Me.menuItem41, Me.menuItem42, Me.menuItem43, Me.menuItem44})
        Me.menuItem37.Text = "GradientStyle"
        ' 
        ' menuItem38
        ' 
        Me.menuItem38.Index = 0
        Me.menuItem38.Text = "BackwardDiagonal"
        ' 
        ' menuItem39
        ' 
        Me.menuItem39.Index = 1
        Me.menuItem39.Text = "ForwardDiagonal"
        ' 
        ' menuItem40
        ' 
        Me.menuItem40.Index = 2
        Me.menuItem40.Text = "Horizontal"
        ' 
        ' menuItem41
        ' 
        Me.menuItem41.Index = 3
        Me.menuItem41.Text = "None"
        ' 
        ' menuItem42
        ' 
        Me.menuItem42.Index = 4
        Me.menuItem42.Text = "PathEllipse"
        ' 
        ' menuItem43
        ' 
        Me.menuItem43.Index = 5
        Me.menuItem43.Text = "PathRectangle"
        ' 
        ' menuItem44
        ' 
        Me.menuItem44.Index = 6
        Me.menuItem44.Text = "Vertical"
        ' 
        ' Form1
        ' 
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(512, 445)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.editControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Word Wrap"
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

    
    Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click, menuItem3.Click, menuItem5.Click, menuItem6.Click, menuItem9.Click, menuItem8.Click
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
                Me.editControl1.NewFile()
            Case "Exit"
                Me.Close()
        End Select
    End Sub 'MainMenuClick


    Private Sub WrapModeClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem12.Click, menuItem13.Click
        Dim mi As MenuItem = sender
        Select Case mi.Text
            Case "Control"
                Me.editControl1.WordWrapMode = WordWrapMode.Control
            Case "TextArea"
                Me.editControl1.WordWrapMode = WordWrapMode.WordWrapMargin
        End Select
    End Sub 'WrapModeClick


    Private Sub WrapTypeClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem14.Click, menuItem15.Click
        Dim mi As MenuItem = sender '
        'ToDo: Error processing original source shown below
        '  {
        '   MenuItem mi = sender as MenuItem;
        '-------------------------^--- Syntax error: ';' expected
        Select Case mi.Text
            Case "Character"
                Me.editControl1.WordWrapType = WordWrapType.WrapByChar
            Case "Word"
                Me.editControl1.WordWrapType = WordWrapType.WrapByWord
        End Select
    End Sub 'WrapTypeClick


    Private Sub LineStyleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem17.Click, menuItem18.Click, menuItem19.Click, menuItem20.Click, menuItem21.Click
        Dim mi As MenuItem = sender
        Select Case mi.Text
            Case "Dash"
                Me.editControl1.WordWrapMarginLineStyle = DashStyle.Dash
            Case "DashDot"
                Me.editControl1.WordWrapMarginLineStyle = DashStyle.DashDot
            Case "DashDotDot"
                Me.editControl1.WordWrapMarginLineStyle = DashStyle.DashDotDot
            Case "Dot"
                Me.editControl1.WordWrapMarginLineStyle = DashStyle.Dot
            Case "Solid"
                Me.editControl1.WordWrapMarginLineStyle = DashStyle.Solid
        End Select
    End Sub 'LineStyleClick


    Private Sub LineColorClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem25.Click, menuItem26.Click, menuItem27.Click, menuItem28.Click
        Dim mi As MenuItem = sender
        Select Case mi.Text
            Case "Green"
                Me.editControl1.WordWrapMarginLineColor = Color.Green
            Case "Navy"
                Me.editControl1.WordWrapMarginLineColor = Color.Navy
            Case "IndianRed"
                Me.editControl1.WordWrapMarginLineColor = Color.IndianRed
            Case "Aqua"
                Me.editControl1.WordWrapMarginLineColor = Color.Aqua
        End Select
    End Sub 'LineColorClick

    Private m_foreColor As Color = Color.White

    Private Sub ForeColorClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem29.Click, menuItem30.Click, menuItem31.Click, menuItem32.Click
        Dim mi As MenuItem = sender
        Select Case mi.Text
            Case "Salmon"
                m_foreColor = Color.Salmon
            Case "Orange"
                m_foreColor = Color.Orange
            Case "Blue"
                m_foreColor = Color.Blue
            Case "Pink"
                m_foreColor = Color.Pink
        End Select
        Me.editControl1.WordWrapMarginBrush = New BrushInfo(gradientStyle, m_foreColor, m_backColor)
    End Sub 'ForeColorClick

    Private m_backColor As Color = Color.LightSalmon

    Private Sub BackColorClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem33.Click, menuItem34.Click, menuItem35.Click, menuItem36.Click
        Dim mi As MenuItem = sender
        Select Case mi.Text
            Case "Beige"
                m_backColor = Color.Beige
            Case "LightYellow"
                m_backColor = Color.LightYellow
            Case "LightSalmon"
                m_backColor = Color.LightSalmon
            Case "Silver"
                m_backColor = Color.Silver
        End Select
        
        Me.editControl1.WordWrapMarginBrush = New BrushInfo(gradientStyle, m_foreColor, m_backColor)
    End Sub 'BackColorClick
    
    Private gradientStyle As GradientStyle = GradientStyle.Horizontal

    Private Sub GradientStyleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem38.Click, menuItem39.Click, menuItem40.Click, menuItem41.Click, menuItem42.Click, menuItem43.Click, menuItem44.Click
        Dim mi As MenuItem = sender
        Select Case mi.Text
            Case "BackwardDiagonal"
                gradientStyle = GradientStyle.BackwardDiagonal
            Case "ForwardDiagonal"
                gradientStyle = GradientStyle.ForwardDiagonal
            Case "Horizontal"
                gradientStyle = GradientStyle.Horizontal
            Case "None"
                gradientStyle = GradientStyle.None
            Case "PathEllipse"
                gradientStyle = GradientStyle.PathEllipse
            Case "PathRectangle"
                gradientStyle = GradientStyle.PathRectangle
            Case "Vertical"
                gradientStyle = GradientStyle.Vertical
        End Select

        Me.editControl1.WordWrapMarginBrush = New BrushInfo(gradientStyle, m_foreColor, m_backColor)
    End Sub 'GradientStyleClick
End Class 'Form1
