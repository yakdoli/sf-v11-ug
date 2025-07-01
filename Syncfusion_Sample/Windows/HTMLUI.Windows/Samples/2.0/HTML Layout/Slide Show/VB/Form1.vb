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

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
    Private htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
		Private panel1 As System.Windows.Forms.Panel
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing
    Private timer As System.Windows.Forms.Timer = New System.Windows.Forms.Timer()
    Private count As Integer = 0
    Private timeDelay As Integer = 0
    Private Shared filePath As String = Nothing

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
    Friend WithEvents panel3 As System.Windows.Forms.Panel
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents button2 As System.Windows.Forms.Button
    Friend WithEvents button3 As System.Windows.Forms.Button
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'htmluiControl1
        '
        Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.htmluiControl1.AutoRunScripts = True
        Me.htmluiControl1.AutoScroll = True
        Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(373, 362)
        Me.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(CType(237, Byte), CType(240, Byte), CType(246, Byte))
        Me.htmluiControl1.EnableMultithreading = False
        Me.htmluiControl1.IsOriginalTextCached = True
        Me.htmluiControl1.Location = New System.Drawing.Point(150, 0)
        Me.htmluiControl1.Name = "htmluiControl1"
        Me.htmluiControl1.Size = New System.Drawing.Size(400, 377)
        Me.htmluiControl1.StartupDocument = ""
        Me.htmluiControl1.StartupFolder = ""
        Me.htmluiControl1.TabIndex = 0
        Me.htmluiControl1.Text = "htmluiControl1"
        '
        'panel1
        '
        Me.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left)
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(200, Byte), CType(219, Byte))
        Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3, Me.panel2})
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(152, 374)
        Me.panel1.TabIndex = 1
        '
        'panel3
        '
        Me.panel3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
        Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me.button2, Me.button3})
        Me.panel3.Location = New System.Drawing.Point(12, 136)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(128, 144)
        Me.panel3.TabIndex = 8
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Maroon
        Me.button1.Location = New System.Drawing.Point(8, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(112, 28)
        Me.button1.TabIndex = 4
        Me.button1.Text = "Start"
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Maroon
        Me.button2.Location = New System.Drawing.Point(8, 56)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(113, 29)
        Me.button2.TabIndex = 5
        Me.button2.Text = "Stop"
        '
        'button3
        '
        Me.button3.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.Maroon
        Me.button3.Location = New System.Drawing.Point(8, 104)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(113, 28)
        Me.button3.TabIndex = 6
        Me.button3.Text = "Reset"
        '
        'panel2
        '
        Me.panel2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
        Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.textBox1, Me.label2, Me.label1})
        Me.panel2.Location = New System.Drawing.Point(12, 16)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(128, 88)
        Me.panel2.TabIndex = 7
        '
        'textBox1
        '
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBox1.ForeColor = System.Drawing.Color.Maroon
        Me.textBox1.Location = New System.Drawing.Point(8, 61)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(48, 20)
        Me.textBox1.TabIndex = 10
        Me.textBox1.Text = "1"
        Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label2
        '
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.Maroon
        Me.label2.Location = New System.Drawing.Point(64, 61)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 16)
        Me.label2.TabIndex = 9
        Me.label2.Text = "second(s)"
        '
        'label1
        '
        Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Maroon
        Me.label1.Location = New System.Drawing.Point(8, 13)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(112, 32)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Set the time delay for the slide show"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 374)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.htmluiControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slide Show"
        'Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
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
        Console.WriteLine("Form Loaded")
        LoadHTMLFiles()
        Me.textBox1.Focus()
    End Sub

#Region "UIEvents"

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        TimerStart()
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        TimerStop()
    End Sub

    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Console.WriteLine(count.ToString())
        If count >= 6 Then
            ResetTimer()
        Else
            count += 1
        End If
        LoadHTMLFiles()
    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        ResetTimer()
    End Sub

    Private Sub textBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TimerStart()
        End If
        Console.WriteLine("Enter key down on textbox")
    End Sub
#End Region

		#Region "HelperMethods"
		Private Sub TimerStart()
			timeDelay = 1000
			If Me.textBox1.Text<>"" Then
				timeDelay = (Convert.ToInt32(Me.textBox1.Text)*1000)
			End If
        Dim secTimeDelay As Integer
        secTimeDelay = (timeDelay / 1000)
			Me.textBox1.Text = secTimeDelay.ToString()
			Console.WriteLine("Timer Started. Time delay is " & secTimeDelay.ToString())
			timer.Interval = timeDelay
			timer.Start()
			AddHandler timer.Tick, AddressOf timer_Tick
		End Sub

		Private Sub TimerStop()
			Console.WriteLine("Timer Stopped.")
			timer.Stop()
			RemoveHandler timer.Tick, AddressOf timer_Tick
		End Sub

		Private Sub ResetTimer()
			Console.WriteLine("Timer Reset")
			Me.count = 0
			LoadHTMLFiles()
		End Sub

		Private Sub LoadHTMLFiles()
			Console.WriteLine("Loading the HTML file.")
			If count = 0 Then
				LoadFromFile("main.htm")
			End If
			If count = 1 Then
				LoadFromFile("tools.htm")
			End If
			If count = 2 Then
				LoadFromFile("grid.htm")
			End If
			If count = 3 Then
				LoadFromFile("chart.htm")
			End If
			If count = 4 Then
				LoadFromFile("diagram.htm")
			End If
			If count = 5 Then
				LoadFromFile("pdf.htm")
			End If
			If count = 6 Then
				LoadFromFile("HTMLUI.htm")
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
			Dim slashPos As Integer = path.LastIndexOf("\",path.Length)
        slashPos = path.LastIndexOf("\", slashPos - 1)
        slashPos = path.LastIndexOf("\", slashPos - 1)
			If slashPos > 0 Then
				path = path.Substring(0,slashPos)
			End If
        path = path.Replace("file:\", "")
			filePath = path & "\files\"
			Return filePath
		End Function
		#End Region
	End Class
