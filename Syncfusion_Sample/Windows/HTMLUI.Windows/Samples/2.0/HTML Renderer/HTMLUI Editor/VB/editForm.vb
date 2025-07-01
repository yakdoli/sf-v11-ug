#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Text
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace Syncfusion.Windows.Forms.HTMLUI.Samples
	''' <summary>
	''' Summary description for Form2.
	''' </summary>
	Public Class editForm : Inherits System.Windows.Forms.Form
		Private richTextBox1 As System.Windows.Forms.RichTextBox
        Private txt As String = ""
		Private newMenu As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private menuItem4 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
		Private panel1 As System.Windows.Forms.Panel
        Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
        Private opnFileDlg As System.Windows.Forms.OpenFileDialog

#Region "Properties"
        Public ReadOnly Property newHtml() As String
            Get
                Return richTextBox1.Text
            End Get
        End Property
#End Region

        Public Sub New(ByVal text As String)
            '
            ' Required for Windows Form Designer support
            '
            Me.txt = text
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
        Friend WithEvents button1 As System.Windows.Forms.Button
        Friend WithEvents button2 As System.Windows.Forms.Button
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(editForm))
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.newMenu = New System.Windows.Forms.MainMenu()
            Me.menuItem1 = New System.Windows.Forms.MenuItem()
            Me.menuItem2 = New System.Windows.Forms.MenuItem()
            Me.menuItem3 = New System.Windows.Forms.MenuItem()
            Me.menuItem4 = New System.Windows.Forms.MenuItem()
            Me.menuItem6 = New System.Windows.Forms.MenuItem()
            Me.menuItem5 = New System.Windows.Forms.MenuItem()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.button1 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.opnFileDlg = New System.Windows.Forms.OpenFileDialog()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'richTextBox1
            '
            Me.richTextBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.richTextBox1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(400, 288)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.Text = ""
            '
            'newMenu
            '
            Me.newMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem4})
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
            Me.menuItem2.Text = "Open New File"
            '
            'menuItem3
            '
            Me.menuItem3.Index = 1
            Me.menuItem3.Text = "Exit Edit Form"
            '
            'menuItem4
            '
            Me.menuItem4.Index = 1
            Me.menuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem6, Me.menuItem5})
            Me.menuItem4.Text = "Edit"
            '
            'menuItem6
            '
            Me.menuItem6.Index = 0
            Me.menuItem6.Text = "Clear All"
            '
            'menuItem5
            '
            Me.menuItem5.Index = 1
            Me.menuItem5.Text = "SelectAll"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(218, Byte), CType(229, Byte), CType(245, Byte))
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.button1, Me.button2})
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.panel1.Location = New System.Drawing.Point(0, 289)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(400, 48)
            Me.panel1.TabIndex = 1
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
            Me.button1.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.Maroon
            Me.button1.Location = New System.Drawing.Point(76, 12)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(64, 24)
            Me.button1.TabIndex = 2
            Me.button1.Text = "OK"
            '
            'button2
            '
            Me.button2.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
            Me.button2.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
            Me.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.Color.Maroon
            Me.button2.Location = New System.Drawing.Point(260, 12)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(64, 24)
            Me.button2.TabIndex = 3
            Me.button2.Text = "Cancel"
            '
            'editForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(400, 337)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.richTextBox1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Menu = Me.newMenu
            Me.Name = "editForm"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Editor"
            Me.panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "ClassEvents"
        Private Sub Form2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.AddTextToTxtBox(txt)
        End Sub

        Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
            Me.Close()
        End Sub

        Private Sub menuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem6.Click
            ClearText()
        End Sub

        Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
            SelectAllText()
        End Sub

        Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
            Me.opnFileDlg.InitialDirectory = "C:\"
            Me.opnFileDlg.Filter = "htm files|*.htm|html files|*.html|Text files|*.txt"
            If Me.opnFileDlg.ShowDialog() = DialogResult.OK Then
                Dim text As String = ReadFile(Me.opnFileDlg.FileName)
                Me.richTextBox1.Text = text
            End If
        End Sub
#End Region

#Region "ClassMethods"
        Private Sub ClearText()
            Me.richTextBox1.Text = ""
            Me.richTextBox1.Text.Trim()
        End Sub

        Private Sub SelectAllText()
            Me.richTextBox1.SelectAll()
        End Sub

        Private Sub AddTextToTxtBox(ByVal str As String)
            Me.richTextBox1.Text = str
        End Sub

        Private Function ReadFile(ByVal fileName As String) As String
            Dim textReader As TextReader = New StreamReader(Me.opnFileDlg.FileName)
            Dim stb As StringBuilder = New StringBuilder()
            Dim str As String = textReader.ReadLine()
            Do While Not str Is Nothing
                Console.WriteLine(str)
                stb.Append(str & Constants.vbLf)
                str = textReader.ReadLine()
            Loop
            Dim textInFile As String = stb.ToString()
            textReader.Close()
            Return textInFile
        End Function
#End Region

    End Class
End Namespace
