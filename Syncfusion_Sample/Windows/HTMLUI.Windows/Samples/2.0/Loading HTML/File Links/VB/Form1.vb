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
      Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
      Private Shared filePath As String = Nothing
      Private statusBar1 As System.Windows.Forms.StatusBar
      
      '/ <summary>
      '/ Required designer variable.
      '/ </summary>
      Private components As System.ComponentModel.Container = Nothing
      
      
      Public Sub New()
         '
         ' Required for Windows Form Designer support
         '
         InitializeComponent()
      End Sub 'New
       
      '
      ' TODO: Add any constructor code after InitializeComponent call
      '
      
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
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(525, 359)
        Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.ShowTitle = False
        Me.htmluiControl1.Size = New System.Drawing.Size(552, 374)
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
        Me.statusBar1.Location = New System.Drawing.Point(0, 352)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Size = New System.Drawing.Size(552, 22)
        Me.statusBar1.TabIndex = 1
        Me.statusBar1.Text = "statusBar1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.statusBar1, Me.htmluiControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Links"
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
      
      
      Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        LoadFromFile("model.htm")
      End Sub 'Form1_Load
      
      
      Private Sub LoadFromFile(fileName As String)
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
      
      
      Private Sub htmluiControl1_LoadError(sender As Object, e As Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventArgs) Handles htmluiControl1.LoadError
         Me.statusBar1.Text = "Load failed " + e.Document.FileName + " " + e.Document.RenderException.Message
      End Sub 'htmluiControl1_LoadError
      
      
      Private Sub htmluiControl1_LoadFinished(sender As Object, e As System.EventArgs) Handles htmluiControl1.LoadFinished
         Me.statusBar1.Text = "Load succeeded."
      End Sub 'htmluiControl1_LoadFinished
   End Class 'Form1
