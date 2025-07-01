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
Imports System.Reflection

Imports Syncfusion.Windows.Forms.HTMLUI


'/ <summary>
'/ Summary description for Form1.
   '/ </summary>
   
   Public Class Form1
      Inherits System.Windows.Forms.Form
      Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
      Private statusBar1 As System.Windows.Forms.StatusBar
      
      Private Shared filePath As String = Nothing
      
      Private htmlelements As New Hashtable()
      Private listUsers As New ArrayList()
      
      Private txtFname As INPUTElementImpl
      Private txtLname As INPUTElementImpl
      Private txtUname As INPUTElementImpl
      Private txtPass As INPUTElementImpl
      Private mainMenu1 As System.Windows.Forms.MainMenu
      Private menuItem1 As System.Windows.Forms.MenuItem
      Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
      
      
      '/ <summary>
      '/ Required designer variable.
      '/ </summary>
      Private components As System.ComponentModel.Container = Nothing
      
      
      Public Sub New()
         '
         ' Required for Windows Form Designer support
         '
         InitializeComponent()
         
         '
         ' TODO: Add any constructor code after InitializeComponent call
         '
         Dim oneUser As New UserClass("John", "Doe", "johndoe", "")
         Me.listUsers.Add(oneUser)
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
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.statusBar1 = New System.Windows.Forms.StatusBar()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu()
        Me.menuItem1 = New System.Windows.Forms.MenuItem()
        Me.menuItem2 = New System.Windows.Forms.MenuItem()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(525, 338)
        Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.ShowTitle = False
        Me.htmluiControl1.Size = New System.Drawing.Size(552, 353)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 0
        Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
        "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
        "=""True"" xsize=""{Width=77, Height=14}"" xlocation=""{X=10,Y=0}"">htmluiControl1</bod" & _
        "y></html>"
        '
        'statusBar1
        '
        Me.statusBar1.Location = New System.Drawing.Point(0, 331)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Size = New System.Drawing.Size(552, 22)
        Me.statusBar1.TabIndex = 1
        Me.statusBar1.Text = "statusBar1"
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2})
        Me.menuItem1.Text = "File"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.Text = "View Source"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 353)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.statusBar1, Me.htmluiControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTMLUI Dialog"
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
      #End Region
      
      
      '/ <summary>
      '/ The main entry point for the application.
      '/ </summary>
      <STAThread()>  _
      Shared Sub Main()
         Application.Run(New Form1())
      End Sub 'Main
      
      
      Private Sub htmluiControl1_LoadError(sender As Object, e As Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventArgs) Handles htmluiControl1.LoadError
         Me.statusBar1.Text = "Load failed " + e.Document.FileName + " " + e.Document.RenderException.Message
      End Sub 'htmluiControl1_LoadError
      
      
      Private Sub htmluiControl1_LoadFinished(sender As Object, e As System.EventArgs) Handles htmluiControl1.LoadFinished
        Me.statusBar1.Text = "Load succeeded."

        Dim path As String
        If Me.htmluiControl1.Document.Uri Is Nothing Then
            path = Me.htmluiControl1.Document.FileName
        Else
            path = Me.htmluiControl1.Document.Uri.LocalPath
        End If

        If path = GetFilesLocation() + "viewusers.htm" Then
            htmlelements = Me.htmluiControl1.Document.GetElementsByUserIdHash()
            Dim list As BaseElement = htmlelements("allusersList") '
            Dim listString As String = String.Empty
            Dim c As UserClass
            For Each c In Me.listUsers
                listString += c.userName + "(" + c.fName + " " + c.lName + ")<p/>"
            Next c
            list.InnerHTML = listString
        ElseIf path = GetFilesLocation() + "createuser.htm" Then
            htmlelements = Me.htmluiControl1.Document.GetElementsByUserIdHash()

            Dim cuBtn As BaseElement = htmlelements("createUserBtn") '
            Dim caBtn As BaseElement = htmlelements("cancelUserBtn") '

            txtFname = htmlelements("FirstName") '
            txtLname = htmlelements("LastName") '
            txtUname = htmlelements("username") '
            txtPass = htmlelements("password") '

            AddHandler cuBtn.Click, AddressOf cuBtn_Click
            AddHandler caBtn.Click, AddressOf caBtn_Click
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadFromFile("main.htm")
    End Sub 'Form1_Load

    Private Sub caBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
        LoadFromFile("main.htm")
    End Sub

    Private Sub cuBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
        htmlelements = Me.htmluiControl1.Document.GetElementsByUserIdHash()

        Dim errorElem As BaseElement = htmlelements("errormsg") '

        Dim errorMsg As String = ""
        Dim fname As String = txtFname.UserControl.CustomControl.Text.Trim()
        Dim lname As String = txtLname.UserControl.CustomControl.Text.Trim()
        Dim uname As String = txtUname.UserControl.CustomControl.Text.Trim()
        Dim pass As String = txtPass.UserControl.CustomControl.Text.Trim()

        Dim proceed As Boolean = True

        If fname = String.Empty Then
            errorMsg += "First Name is required<br>"
            proceed = False
        End If

        If lname = String.Empty Then
            errorMsg += "Last Name is required<br>"
            proceed = False
        End If

        If uname = String.Empty Then
            errorMsg += "User Name is required<br>"
            proceed = False
        End If

        If pass = String.Empty Then
            errorMsg += "Password is required<br>"
            proceed = False
        End If

        If proceed Then
            Dim newUser As New UserClass(fname, lname, uname, pass)
            Me.listUsers.Add(newUser)
            LoadFromFile("viewusers.htm")
        Else
            errorElem.InnerHTML = errorMsg
        End If
    End Sub 'cuBtn_Click


    Private Sub LoadFromFile(ByVal fileName As String)
        Dim filePath As String = GetFilesLocation() + fileName
        Me.htmluiControl1.LoadHTML(filePath)
    End Sub 'LoadFromFile


    Shared Function GetFilesLocation() As String
        If Not (filePath Is Nothing) Then
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
        filePath = path + "\files\"
        Return filePath
    End Function 'GetFilesLocation


    Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
        MessageBox.Show(Me.htmluiControl1.Text)
    End Sub 'menuItem2_Click


    Private Class UserClass
        Public fName As String
        Public lName As String
        Public userName As String
        Public password As String


        Public Sub New(ByVal fName As String, ByVal lName As String, ByVal userName As String, ByVal password As String)
            Me.fName = fName
            Me.lName = lName
            Me.userName = userName
            Me.password = password
        End Sub 'New
    End Class 'UserClass
End Class 'Form1
