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
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
Imports Syncfusion.Windows.Forms.Edit.Utils
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Enums


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
    Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.LoadFile("..\Form1.vb")
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
        Me.menuItem9 = New System.Windows.Forms.MenuItem()
        Me.menuItem10 = New System.Windows.Forms.MenuItem()
        Me.menuItem11 = New System.Windows.Forms.MenuItem()
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
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.TabIndex = 0
        Me.editControl1.TabSize = 2
        Me.editControl1.Text = "editControl1"
        Me.editControl1.TransferFocusOnTab = True
        Me.editControl1.UserMarginWidth = 100
        Me.editControl1.WordWrap = True
        ' 
        ' mainMenu1
        ' 
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem9, Me.menuItem10, Me.menuItem11})
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
        Me.menuItem3.Text = "Open..."
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
        Me.menuItem6.Text = "Save As.."
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
        ' menuItem9
        ' 
        Me.menuItem9.Index = 1
        Me.menuItem9.Text = "StrikeLine"
        ' 
        ' menuItem10
        ' 
        Me.menuItem10.Index = 2
        Me.menuItem10.Text = "StrikeSelection"
        ' 
        ' menuItem11
        ' 
        Me.menuItem11.Index = 3
        Me.menuItem11.Text = "StrikeTextRange"
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
        Me.Text = "Strike Through"
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


    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
        Me.editControl1.NewFile()
    End Sub 'menuItem2_Click


    Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
        Me.editControl1.LoadFile()
    End Sub 'menuItem3_Click


    Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
        Me.editControl1.Save()
    End Sub 'menuItem5_Click


    Private Sub menuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem6.Click
        Me.editControl1.SaveAs()
    End Sub 'menuItem6_Click


    Private Sub menuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem8.Click
        Me.Close()
    End Sub 'menuItem8_Click


    Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
        ' Strike out the current line
        Me.editControl1.StrikeThrough(Me.editControl1.CurrentLine, Color.IndianRed)
    End Sub 'menuItem9_Click


    Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
        ' Strike out the selected text
        If Not Me.editControl1.Selection Is Nothing Then
            Me.editControl1.StrikeThrough(Me.editControl1.Selection.Top, Me.editControl1.Selection.Bottom, Color.Navy)
        Else
            MessageBox.Show("Please select some text to see the action")
        End If
    End Sub 'menuItem10_Click


    Private Sub menuItem11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem11.Click
        Dim startLineNumber As Integer = 12
        Dim endLineNumber As Integer = 17

        ' Creating the associated CoordinatePoints that indicate the text range
        Dim startCoordinatePoint As CoordinatePoint = Me.editControl1.Parser.GetCoordinatePoint(12, 1)
        Dim endCoordinatePoint As CoordinatePoint = Me.editControl1.Parser.GetCoordinatePoint(17, Me.editControl1.GetLine(17).LineLength)

        ' Strike out the text in the specified text range
        Me.editControl1.StrikeThrough(startCoordinatePoint, endCoordinatePoint, Color.Red)
    End Sub 'menuItem11_Click
End Class 'Form1