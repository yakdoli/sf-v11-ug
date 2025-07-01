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
Imports System.Reflection
Imports System.IO
Imports Syncfusion.Windows.Forms.HTMLUI

Namespace Syncfusion.Windows.Forms.HTMLUI.Samples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private _assembly As System.Reflection.Assembly
		Private _htmlStream As Stream
		Private htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
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
        Friend WithEvents button1 As System.Windows.Forms.Button
        Friend WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents panel2 As System.Windows.Forms.Panel
        Friend WithEvents label3 As System.Windows.Forms.Label
        Friend WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents button2 As System.Windows.Forms.Button
        Friend WithEvents listView1 As System.Windows.Forms.ListView
        Friend WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.button1 = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.button2 = New System.Windows.Forms.Button()
            Me.listView1 = New System.Windows.Forms.ListView()
            Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
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
            Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(365, 359)
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Location = New System.Drawing.Point(192, 0)
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.Size = New System.Drawing.Size(392, 374)
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
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me.label1, Me.panel2, Me.listView1})
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(184, 374)
            Me.panel1.TabIndex = 1
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.Maroon
            Me.button1.Location = New System.Drawing.Point(16, 320)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(152, 24)
            Me.button1.TabIndex = 16
            Me.button1.Text = "Refresh"
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.WhiteSmoke
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label1.Location = New System.Drawing.Point(16, 144)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(152, 24)
            Me.label1.TabIndex = 15
            Me.label1.Text = "Selected Elements"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
            Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.label3, Me.label2, Me.button2})
            Me.panel2.Location = New System.Drawing.Point(16, 16)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(152, 96)
            Me.panel2.TabIndex = 13
            '
            'label3
            '
            Me.label3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.WhiteSmoke
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(152, 24)
            Me.label3.TabIndex = 6
            Me.label3.Text = "Text Options"
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label2
            '
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(80, Byte), CType(0, Byte), CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(32, 72)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(88, 16)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Copy Text (Ctrl+C)"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'button2
            '
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.Maroon
            Me.button2.Location = New System.Drawing.Point(8, 40)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(136, 24)
            Me.button2.TabIndex = 2
            Me.button2.Text = "Search Text (Ctrl+F)"
            '
            'listView1
            '
            Me.listView1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
            Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1})
            Me.listView1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.listView1.Location = New System.Drawing.Point(16, 168)
            Me.listView1.Name = "listView1"
            Me.listView1.Size = New System.Drawing.Size(152, 152)
            Me.listView1.TabIndex = 14
            Me.listView1.View = System.Windows.Forms.View.List
            '
            'columnHeader1
            '
            Me.columnHeader1.Width = 100
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.htmluiControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Text Selection"
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
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

		Private Function LoadHTMLResource() As Boolean
			Dim success As Boolean = False

			Try
				_assembly = System.Reflection.Assembly.GetExecutingAssembly()
				_htmlStream = CType(_assembly.GetManifestResourceStream("display.htm"), Stream)
				If Not _htmlStream Is Nothing Then
					Me.htmluiControl1.LoadHTML(_htmlStream)
					success = True
				End If
			Catch ex As Exception
				MessageBox.Show(ex.ToString())
			End Try
			Return success
		End Function

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			LoadHTMLResource()
		End Sub

        Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
            Me.listView1.Items.Clear()
            Dim elem As IHTMLElement
            For Each elem In Me.htmluiControl1.SelectedElements
                Me.listView1.Items.Add(elem.Name & " " & elem.ID)
            Next elem
        End Sub

        Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
            Me.htmluiControl1.DisplayFindForm()
        End Sub

    End Class
End Namespace
