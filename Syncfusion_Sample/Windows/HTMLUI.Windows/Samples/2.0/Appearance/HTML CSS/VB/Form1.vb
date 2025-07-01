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

''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
  Private panel1 As System.Windows.Forms.Panel
    ''' <summary>
    ''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

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
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
  Friend WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
    Friend WithEvents panel4 As System.Windows.Forms.Panel
    Friend WithEvents panel5 As System.Windows.Forms.Panel
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents button1 As System.Windows.Forms.Button
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.panel5 = New System.Windows.Forms.Panel()
        Me.label3 = New System.Windows.Forms.Label()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.button1 = New System.Windows.Forms.Button()
        Me.panel1.SuspendLayout()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel4.SuspendLayout()
        Me.panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left)
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(200, Byte), CType(219, Byte))
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel4})
        Me.panel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(136, 374)
        Me.panel1.TabIndex = 1
        '
        'htmluiControl1
        '
        Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.htmluiControl1.AutoRunScripts = True
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(389, 359)
        Me.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Location = New System.Drawing.Point(136, 0)
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.Size = New System.Drawing.Size(416, 374)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 2
        Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
        "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
        "=""True"" xsize=""{Width=77, Height=14}"" xlocation=""{X=10,Y=20}"">htmluiControl1</bo" & _
        "dy></html>"
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
        Me.panel4.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel5})
        Me.panel4.Location = New System.Drawing.Point(8, 24)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(120, 168)
        Me.panel4.TabIndex = 6
        '
        'panel5
        '
        Me.panel5.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
        Me.panel5.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me.label3, Me.radioButton2, Me.radioButton1})
        Me.panel5.Location = New System.Drawing.Point(2, 2)
        Me.panel5.Name = "panel5"
        Me.panel5.Size = New System.Drawing.Size(116, 164)
        Me.panel5.TabIndex = 5
        '
        'label3
        '
        Me.label3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
        Me.label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.label3.Location = New System.Drawing.Point(-2, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(120, 24)
        Me.label3.TabIndex = 6
        Me.label3.Text = "Style Sheets"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radioButton2
        '
        Me.radioButton2.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
        Me.radioButton2.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
        Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radioButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton2.ForeColor = System.Drawing.Color.Maroon
        Me.radioButton2.Location = New System.Drawing.Point(4, 78)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(108, 40)
        Me.radioButton2.TabIndex = 5
        Me.radioButton2.Text = "Style sheet2"
        '
        'radioButton1
        '
        Me.radioButton1.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
        Me.radioButton1.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
        Me.radioButton1.Checked = True
        Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radioButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioButton1.ForeColor = System.Drawing.Color.Maroon
        Me.radioButton1.Location = New System.Drawing.Point(4, 38)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(108, 32)
        Me.radioButton1.TabIndex = 4
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Style sheet1"
        '
        'button1
        '
        Me.button1.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Maroon
        Me.button1.Location = New System.Drawing.Point(14, 126)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(96, 28)
        Me.button1.TabIndex = 7
        Me.button1.Text = "Apply Style"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.htmluiControl1, Me.panel1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HTML CSS"
        Me.panel1.ResumeLayout(False)
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel4.ResumeLayout(False)
        Me.panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub LoadHTMLFile(ByVal fileName As String)

			Dim path As String
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
			Dim slashPos As Integer = path.LastIndexOf("\",path.Length)
			slashPos = path.LastIndexOf("\",slashPos-1)
			If slashPos > 0 Then
				path = path.Substring(0,slashPos)
			End If
			path = path.Replace("file:\", "")
			Me.htmluiControl1.StartupDocument = System.IO.Path.Combine(path, fileName)

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			LoadHTMLFile("styles.htm")
		End Sub
		Private Sub LoadCSSFromFile(ByVal fileName As String)
			Dim remString As String = "\bin\debug"
			Dim path As String = Application.StartupPath.Remove(Application.StartupPath.Length - remString.Length, remString.Length)+ "\" & fileName
			Me.htmluiControl1.LoadCSS(path)
		End Sub

  Private Sub htmluiControl1_LoadFinished(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Console.WriteLine("Load Finished")
  End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        If Me.radioButton1.Checked = True Then
            LoadCSSFromFile("style.css")
        ElseIf Me.radioButton2.Checked = True Then
            LoadCSSFromFile("style2.css")
        End If
    End Sub
End Class
