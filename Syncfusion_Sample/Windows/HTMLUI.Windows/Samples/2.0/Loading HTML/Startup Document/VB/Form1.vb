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
      Private htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
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
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.Size = New System.Drawing.Size(552, 374)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 0
        Me.htmluiControl1.Text = "<title></title><html/>"
        Me.htmluiControl1.Title = ""
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.htmluiControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Startup Document"
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
         Dim path As String
         path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
         Dim slashPos As Integer = path.LastIndexOf("\", path.Length)
        slashPos = path.LastIndexOf("\", slashPos - 1)
        slashPos = path.LastIndexOf("\", slashPos - 1)
         If slashPos > 0 Then
            path = path.Substring(0, slashPos)
         End If
         path = path.Replace("file:\", "")
        Me.htmluiControl1.StartupDocument = path + "\\files\\startup_page.htm"
    End Sub 'Form1_Load

    Private Sub htmluiControl1_LinkClicked(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.HTMLUI.LinkForwardEventArgs)
        If e.Path = "" Then
            System.Console.WriteLine("The specified path not exists.")
        End If
    End Sub

End Class 'Form1


