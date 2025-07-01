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
Imports System.Reflection

Imports Syncfusion.Windows.Forms.HTMLUI


''' <summary>
''' Summary description for Form1.
''' </summary>
Public Class Form1 : Inherits System.Windows.Forms.Form
    Private _assembly As System.Reflection.Assembly
    Private _htmlStream As Stream

    Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl

    Private panel1 As System.Windows.Forms.Panel

    Private endPoint As Point = Point.Empty

    Private pd As HTMLUIPrintDocument

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        '
        ' TODO: Add any constructor code after InitializeComponent call
        '
    End Sub


#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents panel3 As System.Windows.Forms.Panel
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(389, 337)
        Me.htmluiControl1.BackColor = System.Drawing.Color.White
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Location = New System.Drawing.Point(136, 0)
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.ShowTitle = False
        Me.htmluiControl1.Size = New System.Drawing.Size(416, 352)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 0
        Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
        "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
        "=""True"" xsize=""{Width=71, Height=15}"" xlocation=""{X=10,Y=0}"">htmluiControl1</bod" & _
        "y></html>"
        '
        'panel1
        '
        Me.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left)
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(200, Byte), CType(219, Byte))
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2, Me.checkBox1})
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(136, 352)
        Me.panel1.TabIndex = 1
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
        Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3})
        Me.panel2.Location = New System.Drawing.Point(8, 16)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(120, 120)
        Me.panel2.TabIndex = 7
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
        Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2, Me.button1, Me.button2})
        Me.panel3.Location = New System.Drawing.Point(2, 2)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(116, 116)
        Me.panel3.TabIndex = 5
        '
        'label2
        '
        Me.label2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
        Me.label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label2.Location = New System.Drawing.Point(-2, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(120, 24)
        Me.label2.TabIndex = 6
        Me.label2.Text = "Print Document"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Maroon
        Me.button1.Location = New System.Drawing.Point(6, 38)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(104, 28)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Print"
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Maroon
        Me.button2.Location = New System.Drawing.Point(6, 72)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(104, 32)
        Me.button2.TabIndex = 5
        Me.button2.Text = "Print Preview"
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox1.ForeColor = System.Drawing.Color.Maroon
        Me.checkBox1.Location = New System.Drawing.Point(16, 168)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(112, 64)
        Me.checkBox1.TabIndex = 8
        Me.checkBox1.Text = "Enable 'Ctrl+P' shortcut for printing"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 353)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.htmluiControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Printing"
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
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
        LoadHTMLResource()
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.printDocument()
        Me.htmluiControl1.Focus()
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.printPreview()
        Me.htmluiControl1.Focus()
    End Sub

    Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
        pd = New HTMLUIPrintDocument(Me.htmluiControl1.Document)
    End Sub

    Private Sub htmluiControl1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles htmluiControl1.KeyDown
        If (Me.checkBox1.Checked = True) Then
            'Ctrl+P shortcut for printing document.
            If (e.Control = True AndAlso e.KeyCode = Keys.P) Then
                Me.printDocument()

            Else
                Console.WriteLine("'Ctrl + P' is the key board shortcut to print a document in the HTMLUI control.")
            End If
        End If
    End Sub

    Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        Me.htmluiControl1.Focus()
    End Sub


#Region "ClassHelperMethods"
    ''' <summary>
    ''' Loads the HTML file from the embedded resource.
    ''' </summary>
    ''' <returns></returns>
    Private Function LoadHTMLResource() As Boolean
        Dim success As Boolean = False

        Try
            _assembly = System.Reflection.Assembly.GetExecutingAssembly()
            _htmlStream = CType(_assembly.GetManifestResourceStream("print.htm"), Stream)
            If Not _htmlStream Is Nothing Then
                Me.htmluiControl1.LoadHTML(_htmlStream)
                success = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
        Return success
    End Function

    ''' <summary>
    ''' prints the document in the HTMLUI control.
    ''' </summary>
    Private Sub printDocument()
        Dim dg As PrintDialog = New PrintDialog()
        dg.AllowSomePages = True
        dg.Document = pd
        If dg.ShowDialog() = DialogResult.OK Then
            pd.Print()
        End If
    End Sub

    ''' <summary>
    ''' preview the document before print.
    ''' </summary>
    Private Sub printPreview()
        Dim dlg As PrintPreviewDialog = New PrintPreviewDialog()
        dlg.Document = pd
        dlg.ShowDialog()
    End Sub
#End Region




End Class
