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
Imports System.Text


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits System.Windows.Forms.Form
    Private statusBar1 As System.Windows.Forms.StatusBar
  Private Shared filePath As String
    Private panel1 As System.Windows.Forms.Panel
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
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
  Friend WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
  Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.statusBar1 = New System.Windows.Forms.StatusBar()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.checkBox4 = New System.Windows.Forms.CheckBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.panel1.SuspendLayout()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusBar1
        '
        Me.statusBar1.Location = New System.Drawing.Point(0, 350)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Size = New System.Drawing.Size(552, 24)
        Me.statusBar1.TabIndex = 0
        Me.statusBar1.Text = "Ready"
        '
        'panel1
        '
        Me.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left)
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.checkBox4, Me.checkBox3, Me.checkBox2, Me.checkBox1})
        Me.panel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(160, 349)
        Me.panel1.TabIndex = 4
        '
        'checkBox4
        '
        Me.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox4.ForeColor = System.Drawing.Color.FromArgb(CType(51, Byte), CType(51, Byte), CType(103, Byte))
        Me.checkBox4.Location = New System.Drawing.Point(16, 136)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(136, 48)
        Me.checkBox4.TabIndex = 3
        Me.checkBox4.Text = "Document with no bgColor"
        '
        'checkBox3
        '
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox3.ForeColor = System.Drawing.Color.FromArgb(CType(51, Byte), CType(51, Byte), CType(103, Byte))
        Me.checkBox3.Location = New System.Drawing.Point(16, 272)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(136, 56)
        Me.checkBox3.TabIndex = 2
        Me.checkBox3.Text = "Back Color based on styles"
        '
        'checkBox2
        '
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox2.ForeColor = System.Drawing.Color.FromArgb(CType(51, Byte), CType(51, Byte), CType(103, Byte))
        Me.checkBox2.Location = New System.Drawing.Point(16, 200)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(136, 56)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "Document bgColor Attribute of Body tag"
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Enabled = False
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox1.ForeColor = System.Drawing.Color.FromArgb(CType(51, Byte), CType(51, Byte), CType(103, Byte))
        Me.checkBox1.Location = New System.Drawing.Point(16, 16)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(136, 104)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "HTMLUIControl.BackColor (when no document is loaded or document doesn't specify c" & _
        "olor)"
        '
        'htmluiControl1
        '
        Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.htmluiControl1.AutoRunScripts = True
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(365, 334)
        Me.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(200, Byte), CType(219, Byte))
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Location = New System.Drawing.Point(160, 0)
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.ShowTitle = False
        Me.htmluiControl1.Size = New System.Drawing.Size(392, 349)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 5
        Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
        "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
        "=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=10,Y=0}"" /></html>"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.htmluiControl1, Me.panel1, Me.statusBar1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Background"
        Me.panel1.ResumeLayout(False)
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main


  Private Sub htmluiControl1_LoadError(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventArgs)
    Me.statusBar1.Text = "Load failed " + e.Document.FileName + " " + e.Document.RenderException.Message
  End Sub 'htmluiControl1_LoadError


  Private Sub htmluiControl1_LoadFinished(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.statusBar1.Text = "Load succeeded."
  End Sub 'htmluiControl1_LoadFinished


  Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    Application.Exit()
  End Sub 'menuItem3_Click


  Private Sub htmluiControl1_LoadStarted(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Me.statusBar1.Text = "Starting to load..."
  End Sub 'htmluiControl1_LoadStarted


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


  Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
  End Sub 'Form1_Load


  Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
    SetBackColor()
  End Sub 'checkBox2_CheckedChanged


  Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
    SetBackColor()
  End Sub 'checkBox3_CheckedChanged


  Private Sub SetBackColor()
    If Me.checkBox2.Checked Then
      If Me.checkBox3.Checked = False Then
        LoadFromFile("demo.htm")
      End If
    End If
    If Me.checkBox3.Checked Then
      LoadFromFile("demostyle.htm")
    End If
    If Me.checkBox4.Checked Then
      If Me.checkBox3.Checked = False AndAlso Me.checkBox2.Checked = False Then
        LoadFromFile("democolorless.htm")
      End If
    End If
    If Me.checkBox3.Checked = False AndAlso Me.checkBox2.Checked = False AndAlso Me.checkBox4.Checked = False Then
      Me.htmluiControl1.ResetText()
    End If
  End Sub 'SetBackColor


  Private Sub checkBox4_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox4.CheckedChanged
    SetBackColor()
  End Sub 'checkBox4_CheckedChanged
End Class 'Form1 
