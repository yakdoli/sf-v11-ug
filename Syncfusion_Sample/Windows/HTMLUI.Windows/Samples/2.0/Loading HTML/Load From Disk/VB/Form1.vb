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

Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports System.Diagnostics

Public Class Form1 : Inherits System.Windows.Forms.Form
    Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
    Private mainMenu1 As System.Windows.Forms.MainMenu
    Private menuItem1 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
    Private menuItem4 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private openDlg As System.Windows.Forms.OpenFileDialog
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private menuItem7 As System.Windows.Forms.MenuItem
    Private Shared filePath As String

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        Me.menuItem3 = New System.Windows.Forms.MenuItem()
        Me.menuItem4 = New System.Windows.Forms.MenuItem()
        Me.menuItem6 = New System.Windows.Forms.MenuItem()
        Me.menuItem5 = New System.Windows.Forms.MenuItem()
        Me.menuItem7 = New System.Windows.Forms.MenuItem()
        Me.openDlg = New System.Windows.Forms.OpenFileDialog()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.AllowDrop = True
        Me.htmluiControl1.AutoRunScripts = True
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(549, 386)
        Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.ShowTitle = False
        Me.htmluiControl1.Size = New System.Drawing.Size(576, 401)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 0
        Me.htmluiControl1.Text = "<html/>"
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem4, Me.menuItem7})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2, Me.menuItem3})
        Me.menuItem1.Text = "File"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "Open"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 1
        Me.menuItem3.Text = "Exit"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 1
        Me.menuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem6, Me.menuItem5})
        Me.menuItem4.Text = "Help"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 0
        Me.menuItem6.Text = "About the Applciation"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 1
        Me.menuItem5.Text = "About Syncfusion"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 2
        Me.menuItem7.Text = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 401)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.htmluiControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Load From Disk"
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Console.WriteLine("Form loaded")
        LoadFromFile("index.htm")
    End Sub

    Private Sub htmluiControl1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles htmluiControl1.DragDrop
        Dim files As String() = CType(e.Data.GetData("FileDrop", False), String())
        Dim fileName As String = ""
        For Each fileName In files
            LoadTheControl(fileName)
        Next fileName
    End Sub

    Private Sub htmluiControl1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles htmluiControl1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
        Application.Exit()
    End Sub

    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
        openDlg.InitialDirectory = GetFilesLocation()
        openDlg.Filter = "All files (*.*)|*.*"
        If DialogResult.OK = openDlg.ShowDialog() Then
            Dim filePath As String = openDlg.FileName
            LoadTheControl(filePath)
        End If
    End Sub

    Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
        Dim process As process = process.Start("http://www.syncfusion.com/")
    End Sub

    Private Sub menuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem6.Click
        HelpUser()
    End Sub

    Private Sub LoadTheControl(ByVal fileName As String)
        Dim extension As String = Path.GetExtension(fileName)
        If extension = ".htm" OrElse extension = ".html" OrElse extension = ".mhtml" OrElse extension = ".mht" Then
            Me.htmluiControl1.ShowTitle = True
            Me.htmluiControl1.LoadHTML(fileName)
        Else
            HelpUser()
        End If
    End Sub

    Private Sub LoadFromFile(ByVal fileName As String)
        Dim filePath As String = GetFilesLocation() & fileName
        Me.htmluiControl1.LoadHTML(filePath)
    End Sub

    Private Shared Function GetFilesLocation() As String
        If Not filePath Is Nothing Then
            Return filePath
        End If

        Dim path As String
        path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        Dim slashPos As Integer = path.LastIndexOf("\", path.Length)
        slashPos = path.LastIndexOf("\", slashPos - 1)
        slashPos = path.LastIndexOf("\", slashPos - 1)
        If slashPos > 0 Then
            path = path.Substring(0, slashPos)
        End If
        path = path.Replace("file:\", "")
        filePath = path & "\files\"
        Return filePath
    End Function

    Private Sub HelpUser()
        MessageBox.Show("This application features the ability of HTMLUI control to load the following documents from the user's drive." & Constants.vbLf + Constants.vbTab & " HTML documents" & Constants.vbLf + Constants.vbTab & " MHTML documents" & Constants.vbLf + Constants.vbTab & " Image files" & Constants.vbLf & "The user can also load the document by dragging and dropping the document on the form.")
    End Sub
End Class
