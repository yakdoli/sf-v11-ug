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
Imports System.Drawing.Printing
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Text

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
    Private menuItem9 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem10 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem11 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem14 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem15 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem16 As System.Windows.Forms.MenuItem
    Private menuItem12 As System.Windows.Forms.MenuItem
    Private menuItem17 As System.Windows.Forms.MenuItem
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) + "\..\Test Files\Form1.cs"
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        
        Me.editControl1.LoadFile(BasePath)

        Me.editControl1.PageHeaderAndFooterVisible = True
        Me.editControl1.PrintDocumentName = True
        Me.editControl1.PrintPageNumber = True
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
        Me.menuItem13 = New System.Windows.Forms.MenuItem()
        Me.menuItem14 = New System.Windows.Forms.MenuItem()
        Me.menuItem15 = New System.Windows.Forms.MenuItem()
        Me.menuItem16 = New System.Windows.Forms.MenuItem()
        Me.menuItem12 = New System.Windows.Forms.MenuItem()
        Me.menuItem17 = New System.Windows.Forms.MenuItem()
        CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' editControl1
        ' 
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
        Me.editControl1.ScrollOffsetLeft = 14
        Me.editControl1.ScrollOffsetRight = 0
        Me.editControl1.ScrollOffsetTop = 0
        Me.editControl1.ShowCollapse = True
        Me.editControl1.ShowLineNumbers = False
        Me.editControl1.ShowMarkers = False
        Me.editControl1.ShowWhitespaces = False
        Me.editControl1.Size = New System.Drawing.Size(542, 445)
        Me.editControl1.TabIndex = 0
        Me.editControl1.TabSize = 2
        Me.editControl1.Text = ""
        Me.editControl1.VirtualSize = New System.Drawing.Size(101, 17)
        Me.editControl1.WordWrap = True
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
        ' menuItem9
        ' 
        Me.menuItem9.Index = 1
        Me.menuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem10, Me.menuItem14, Me.menuItem12, Me.menuItem11, Me.menuItem13, Me.menuItem15, Me.menuItem17, Me.menuItem16})
        Me.menuItem9.Text = "Print Menu"
        ' 
        ' menuItem10
        ' 
        Me.menuItem10.Index = 0
        Me.menuItem10.Text = "Show Print Dialog"
        ' 
        ' menuItem11
        ' 
        Me.menuItem11.Index = 3
        Me.menuItem11.Text = "Print Current Page"
        ' 
        ' menuItem13
        ' 
        Me.menuItem13.Index = 4
        Me.menuItem13.Text = "Print Directly"
        ' 
        ' menuItem14
        ' 
        Me.menuItem14.Index = 1
        Me.menuItem14.Text = "Print Preview"
        ' 
        ' menuItem15
        ' 
        Me.menuItem15.Index = 5
        Me.menuItem15.Text = "Print Selected Text"
        ' 
        ' menuItem16
        ' 
        Me.menuItem16.Index = 7
        Me.menuItem16.Text = "Print To Document"
        ' 
        ' menuItem12
        ' 
        Me.menuItem12.Index = 2
        Me.menuItem12.Text = "-"
        ' 
        ' menuItem17
        ' 
        Me.menuItem17.Index = 6
        Me.menuItem17.Text = "-"
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
        Me.Text = "Printing"
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


    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    End Sub 'Form1_Closing


    Private Sub menuItem10_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem10.Click
        Console.WriteLine("Display print dialog")
        Me.editControl1.Print()
    End Sub 'menuItem10_Click


    Private Sub menuItem11_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem11.Click
        Console.WriteLine("Printing the current page")
        Me.editControl1.PrintCurrentPage()
    End Sub 'menuItem11_Click


    Private Sub menuItem14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem14.Click
        Console.WriteLine("Display print preview")
        Me.editControl1.PrintPreview()
    End Sub 'menuItem14_Click


    Private Sub menuItem15_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem15.Click
        Console.WriteLine("Print selected text")
        Me.editControl1.PrintSelection()
    End Sub 'menuItem15_Click


    Private Sub menuItem16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem16.Click
        Console.WriteLine("Print to a printer file")
        Dim printdoc As PrintDocument = Me.editControl1.PrintDocument
        printdoc.Print()
    End Sub 'menuItem16_Click


    Private Sub menuItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem13.Click
        Console.WriteLine("Printing directly without the print dialog")
        Me.editControl1.PrintNoDialog()
    End Sub 'menuItem13_Click
End Class 'Form1