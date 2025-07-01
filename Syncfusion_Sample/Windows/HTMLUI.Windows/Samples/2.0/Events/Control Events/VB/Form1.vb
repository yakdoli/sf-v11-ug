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

Imports Microsoft.VisualBasic


Namespace HTMLUIControlEvents
    '/ <summary>
    '/ Summary description for Form1.
    '/ </summary>
    
    Public Class Form1
        Inherits System.Windows.Forms.Form
        Private _assembly As [Assembly]
        Private _htmlStream As Stream
        
        Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
        Private panel1 As System.Windows.Forms.Panel
        Private textBox1 As System.Windows.Forms.TextBox
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
        Friend WithEvents panel2 As System.Windows.Forms.Panel
        Friend WithEvents panel3 As System.Windows.Forms.Panel
        Friend WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents button2 As System.Windows.Forms.Button
        Friend WithEvents checkBoxShowTitleChanged As System.Windows.Forms.CheckBox
        Friend WithEvents checkBoxTitleChanged As System.Windows.Forms.CheckBox
        Friend WithEvents panel4 As System.Windows.Forms.Panel
        Friend WithEvents panel5 As System.Windows.Forms.Panel
        Friend WithEvents label3 As System.Windows.Forms.Label
        Friend WithEvents checkBoxPreRenderDocument As System.Windows.Forms.CheckBox
        Friend WithEvents checkBoxLoadError As System.Windows.Forms.CheckBox
        Friend WithEvents checkBoxLoadFinished As System.Windows.Forms.CheckBox
        Friend WithEvents checkBoxLoadStarted As System.Windows.Forms.CheckBox
        Friend WithEvents button1 As System.Windows.Forms.Button
        Friend WithEvents button3 As System.Windows.Forms.Button
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.label1 = New System.Windows.Forms.Label()
            Me.button2 = New System.Windows.Forms.Button()
            Me.checkBoxShowTitleChanged = New System.Windows.Forms.CheckBox()
            Me.checkBoxTitleChanged = New System.Windows.Forms.CheckBox()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.label3 = New System.Windows.Forms.Label()
            Me.checkBoxPreRenderDocument = New System.Windows.Forms.CheckBox()
            Me.checkBoxLoadError = New System.Windows.Forms.CheckBox()
            Me.checkBoxLoadFinished = New System.Windows.Forms.CheckBox()
            Me.checkBoxLoadStarted = New System.Windows.Forms.CheckBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button3 = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.panel5.SuspendLayout()
            Me.SuspendLayout()
            '
            'htmluiControl1
            '
            Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Location = New System.Drawing.Point(144, 0)
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.Size = New System.Drawing.Size(408, 280)
            Me.htmluiControl1.StartupDocument = ""
            Me.htmluiControl1.StartupFolder = ""
            Me.htmluiControl1.TabIndex = 0
            Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
            "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
            "=""True"" xsize=""{Width=71, Height=15}"" xlocation=""{X=10,Y=20}"">htmluiControl1</bo" & _
            "dy></html>"
            '
            'panel1
            '
            Me.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left)
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(200, Byte), CType(219, Byte))
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2, Me.panel4, Me.button3})
            Me.panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(144, 376)
            Me.panel1.TabIndex = 1
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3})
            Me.panel2.Location = New System.Drawing.Point(12, 209)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(120, 128)
            Me.panel2.TabIndex = 11
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.button2, Me.checkBoxShowTitleChanged, Me.checkBoxTitleChanged})
            Me.panel3.Location = New System.Drawing.Point(2, 2)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(116, 124)
            Me.panel3.TabIndex = 5
            '
            'label1
            '
            Me.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.WhiteSmoke
            Me.label1.Location = New System.Drawing.Point(-2, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(120, 24)
            Me.label1.TabIndex = 17
            Me.label1.Text = "Title events"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Font = New System.Drawing.Font("Arial", 8.25!)
            Me.button2.ForeColor = System.Drawing.Color.Maroon
            Me.button2.Location = New System.Drawing.Point(10, 92)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(98, 22)
            Me.button2.TabIndex = 16
            Me.button2.Text = "Change Title"
            '
            'checkBoxShowTitleChanged
            '
            Me.checkBoxShowTitleChanged.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.checkBoxShowTitleChanged.Checked = True
            Me.checkBoxShowTitleChanged.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxShowTitleChanged.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxShowTitleChanged.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxShowTitleChanged.ForeColor = System.Drawing.Color.Maroon
            Me.checkBoxShowTitleChanged.Location = New System.Drawing.Point(10, 54)
            Me.checkBoxShowTitleChanged.Name = "checkBoxShowTitleChanged"
            Me.checkBoxShowTitleChanged.Size = New System.Drawing.Size(98, 30)
            Me.checkBoxShowTitleChanged.TabIndex = 15
            Me.checkBoxShowTitleChanged.Text = "Show TitleChanged"
            '
            'checkBoxTitleChanged
            '
            Me.checkBoxTitleChanged.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.checkBoxTitleChanged.Checked = True
            Me.checkBoxTitleChanged.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxTitleChanged.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxTitleChanged.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxTitleChanged.ForeColor = System.Drawing.Color.Maroon
            Me.checkBoxTitleChanged.Location = New System.Drawing.Point(10, 28)
            Me.checkBoxTitleChanged.Name = "checkBoxTitleChanged"
            Me.checkBoxTitleChanged.Size = New System.Drawing.Size(96, 24)
            Me.checkBoxTitleChanged.TabIndex = 14
            Me.checkBoxTitleChanged.Text = "TitleChanged"
            '
            'panel4
            '
            Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.panel4.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel5})
            Me.panel4.Location = New System.Drawing.Point(12, 6)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(120, 200)
            Me.panel4.TabIndex = 10
            '
            'panel5
            '
            Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.panel5.Controls.AddRange(New System.Windows.Forms.Control() {Me.label3, Me.checkBoxPreRenderDocument, Me.checkBoxLoadError, Me.checkBoxLoadFinished, Me.checkBoxLoadStarted, Me.button1})
            Me.panel5.Location = New System.Drawing.Point(2, 2)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(116, 196)
            Me.panel5.TabIndex = 5
            '
            'label3
            '
            Me.label3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.WhiteSmoke
            Me.label3.Location = New System.Drawing.Point(-2, 0)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(120, 24)
            Me.label3.TabIndex = 15
            Me.label3.Text = "Load Events"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'checkBoxPreRenderDocument
            '
            Me.checkBoxPreRenderDocument.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.checkBoxPreRenderDocument.Checked = True
            Me.checkBoxPreRenderDocument.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxPreRenderDocument.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxPreRenderDocument.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxPreRenderDocument.ForeColor = System.Drawing.Color.Maroon
            Me.checkBoxPreRenderDocument.Location = New System.Drawing.Point(10, 128)
            Me.checkBoxPreRenderDocument.Name = "checkBoxPreRenderDocument"
            Me.checkBoxPreRenderDocument.Size = New System.Drawing.Size(96, 24)
            Me.checkBoxPreRenderDocument.TabIndex = 14
            Me.checkBoxPreRenderDocument.Text = "PreRenderDocument"
            '
            'checkBoxLoadError
            '
            Me.checkBoxLoadError.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.checkBoxLoadError.Checked = True
            Me.checkBoxLoadError.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxLoadError.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxLoadError.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxLoadError.ForeColor = System.Drawing.Color.Maroon
            Me.checkBoxLoadError.Location = New System.Drawing.Point(10, 96)
            Me.checkBoxLoadError.Name = "checkBoxLoadError"
            Me.checkBoxLoadError.Size = New System.Drawing.Size(96, 18)
            Me.checkBoxLoadError.TabIndex = 13
            Me.checkBoxLoadError.Text = "LoadError"
            '
            'checkBoxLoadFinished
            '
            Me.checkBoxLoadFinished.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.checkBoxLoadFinished.Checked = True
            Me.checkBoxLoadFinished.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxLoadFinished.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxLoadFinished.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxLoadFinished.ForeColor = System.Drawing.Color.Maroon
            Me.checkBoxLoadFinished.Location = New System.Drawing.Point(10, 64)
            Me.checkBoxLoadFinished.Name = "checkBoxLoadFinished"
            Me.checkBoxLoadFinished.Size = New System.Drawing.Size(96, 20)
            Me.checkBoxLoadFinished.TabIndex = 12
            Me.checkBoxLoadFinished.Text = "LoadFinished"
            '
            'checkBoxLoadStarted
            '
            Me.checkBoxLoadStarted.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.checkBoxLoadStarted.Checked = True
            Me.checkBoxLoadStarted.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxLoadStarted.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBoxLoadStarted.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxLoadStarted.ForeColor = System.Drawing.Color.Maroon
            Me.checkBoxLoadStarted.Location = New System.Drawing.Point(10, 32)
            Me.checkBoxLoadStarted.Name = "checkBoxLoadStarted"
            Me.checkBoxLoadStarted.Size = New System.Drawing.Size(96, 26)
            Me.checkBoxLoadStarted.TabIndex = 11
            Me.checkBoxLoadStarted.Text = "LoadStarted"
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.Maroon
            Me.button1.Location = New System.Drawing.Point(8, 160)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(98, 24)
            Me.button1.TabIndex = 11
            Me.button1.Text = "Load Document"
            '
            'button3
            '
            Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button3.ForeColor = System.Drawing.Color.Maroon
            Me.button3.Location = New System.Drawing.Point(16, 346)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(112, 24)
            Me.button3.TabIndex = 9
            Me.button3.Text = "Clear"
            '
            'textBox1
            '
            Me.textBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.textBox1.Location = New System.Drawing.Point(144, 280)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(408, 96)
            Me.textBox1.TabIndex = 2
            Me.textBox1.Text = ""
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.textBox1, Me.panel1, Me.htmluiControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Control Events"
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
            Me.panel5.ResumeLayout(False)
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
        
        
        Private Function LoadHTMLResource() As Boolean
            Dim success As Boolean = False
            
            Try
                _assembly = [Assembly].GetExecutingAssembly()
                _htmlStream = CType(_assembly.GetManifestResourceStream("Syncfusion.Windows.Forms.HTMLUI.Samples.display.htm"), Stream)
                If Not (_htmlStream Is Nothing) Then
                    Me.htmluiControl1.LoadHTML(_htmlStream)
                    success = True
                End If
            Catch ex As Exception
                OutputText(ex.ToString())
            End Try
            Return success
        End Function 'LoadHTMLResource
        
        
        Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
            LoadHTMLResource()
        End Sub 'Form1_Load       

        Private Sub OutputText(ByVal output As String)
            Me.textBox1.Text += output + vbCr + vbLf
            Me.textBox1.SelectionStart = Me.textBox1.Text.Length - 1
            Me.textBox1.SelectionLength = 0
            Me.textBox1.ScrollToCaret()
        End Sub 'OutputText


        Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
            If Me.checkBoxLoadFinished.Checked Then
                OutputText("LoadFinished event.")
            End If
        End Sub 'htmluiControl1_LoadFinished


        Private Sub htmluiControl1_LoadStarted(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadStarted
            If Me.checkBoxLoadStarted.Checked Then
                OutputText("LoadStarted event.")
            End If
        End Sub 'htmluiControl1_LoadStarted


        Private Sub htmluiControl1_LoadError(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventArgs) Handles htmluiControl1.LoadError
            If Me.checkBoxLoadError.Checked Then
                OutputText("LoadError event.")
            End If
        End Sub 'htmluiControl1_LoadError


        Private Sub htmluiControl1_PreRenderDocument(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.HTMLUI.PreRenderDocumentArgs) Handles htmluiControl1.PreRenderDocument
            If Me.checkBoxPreRenderDocument.Checked Then
                OutputText("LoadPrerenderDocument event.")
            End If
        End Sub 'htmluiControl1_PreRenderDocument


        Private Sub htmluiControl1_TitleChanged(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventArgs) Handles htmluiControl1.TitleChanged
            If Me.checkBoxTitleChanged.Checked Then
                OutputText("TitleChanged event.")
            End If
        End Sub 'htmluiControl1_TitleChanged


        Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
            LoadHTMLResource()
        End Sub 'button1_Click


        Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
            Me.textBox1.Clear()
        End Sub 'button3_Click


        Private Sub htmluiControl1_ShowTitleChanged(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.HTMLUI.ValueChangedEventArgs) Handles htmluiControl1.ShowTitleChanged
            If Me.checkBoxShowTitleChanged.Checked Then
                OutputText("ShowTitleChanged event.")
            End If
        End Sub 'htmluiControl1_ShowTitleChanged


        Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
            If Me.htmluiControl1.ShowTitle = True Then
                Me.htmluiControl1.Title = ""
                Me.htmluiControl1.ShowTitle = False
            Else
                Me.htmluiControl1.Title = "HTMLUIControl Title"
                Me.htmluiControl1.ShowTitle = True
            End If
        End Sub 'button2_Click
    End Class 'Form1 
End Namespace 'HTMLUIControlEvents