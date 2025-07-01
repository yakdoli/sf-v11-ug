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
Imports Syncfusion.Windows.Forms.HTMLUI

Namespace Syncfusion.Windows.Forms.HTMLUI.Samples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents treeView1 As System.Windows.Forms.TreeView
		Private label1 As System.Windows.Forms.Label
        ''' <summary>
        ''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing
        Private checkState As Boolean = False
        Private body As IHTMLElement() = Nothing

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
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents button1 As System.Windows.Forms.Button
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.label2 = New System.Windows.Forms.Label()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.treeView1 = New System.Windows.Forms.TreeView()
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.Panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'htmluiControl1
            '
            Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.htmluiControl1.AutoScroll = True
            Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(357, 359)
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Location = New System.Drawing.Point(168, 0)
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.ShowTitle = False
            Me.htmluiControl1.Size = New System.Drawing.Size(384, 374)
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
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel2, Me.label1, Me.treeView1})
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(160, 374)
            Me.panel1.TabIndex = 1
            '
            'Panel2
            '
            Me.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
            Me.Panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.Panel3})
            Me.Panel2.Location = New System.Drawing.Point(8, 216)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(144, 136)
            Me.Panel2.TabIndex = 2
            '
            'Label3
            '
            Me.Label3.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
            Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(252, Byte), CType(172, Byte), CType(85, Byte))
            Me.Label3.Location = New System.Drawing.Point(4, 4)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(136, 24)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "   Scroll Options"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel3
            '
            Me.Panel3.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
            Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
            Me.Panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2, Me.checkBox1, Me.button1})
            Me.Panel3.Location = New System.Drawing.Point(4, 28)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(136, 104)
            Me.Panel3.TabIndex = 4
            '
            'label2
            '
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(80, Byte), CType(0, Byte), CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(8, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(120, 16)
            Me.label2.TabIndex = 5
            Me.label2.Text = "  Scroll To Rectangle"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'checkBox1
            '
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.ForeColor = System.Drawing.Color.FromArgb(CType(80, Byte), CType(0, Byte), CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(8, 64)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(120, 32)
            Me.checkBox1.TabIndex = 4
            Me.checkBox1.Text = "Enable AutoScroll"
            '
            'button1
            '
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(79, Byte), CType(117, Byte), CType(153, Byte))
            Me.button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(8, 32)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(112, 24)
            Me.button1.TabIndex = 3
            Me.button1.Text = "Scroll To End"
            '
            'label1
            '
            Me.label1.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(252, Byte), CType(172, Byte), CType(85, Byte))
            Me.label1.Location = New System.Drawing.Point(8, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(144, 24)
            Me.label1.TabIndex = 1
            Me.label1.Text = "       Scroll To Element"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'treeView1
            '
            Me.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.treeView1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
            Me.treeView1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.treeView1.ImageIndex = -1
            Me.treeView1.Location = New System.Drawing.Point(8, 32)
            Me.treeView1.Name = "treeView1"
            Me.treeView1.SelectedImageIndex = -1
            Me.treeView1.Size = New System.Drawing.Size(144, 168)
            Me.treeView1.TabIndex = 0
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.htmluiControl1})
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Scroll bars"
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
            Me.Panel3.ResumeLayout(False)
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

		#Region "Class Events"
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			LoadHTMLFile("doc.htm")
			Me.checkState = Me.htmluiControl1.AutoScroll
			LoadTree(Me.htmluiControl1.Document)
		End Sub

		Private Sub treeView1_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterSelect
			If Me.checkState = False Then
				MessageBox.Show("AutoScroll looks disabled. Please enable it to use this functionality.")
				Return
			End If

			Dim elem As IHTMLElement = CType(IIf(TypeOf e.Node.Tag Is IHTMLElement, e.Node.Tag, Nothing), IHTMLElement)
			If elem Is Nothing Then
				Return
			End If
			Me.htmluiControl1.ScrollToElement(elem)
		End Sub

        Private Sub checkBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
            If Me.checkBox1.Checked = True Then
                Me.htmluiControl1.AutoScroll = True
                Me.checkState = True
            End If

            If Me.checkBox1.Checked = False Then
                Me.htmluiControl1.AutoScroll = False
                Me.checkState = False
            End If
        End Sub

        Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
            If Me.checkState = False Then
                MessageBox.Show("AutoScroll looks disabled. Please enable it to use this functionality.")
                Return
            End If

            ScrollToEnd()
        End Sub

#End Region

		#Region "Class Methods"
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

		Private Sub LoadTree(ByVal document As IInputHTML)
			Me.treeView1.Nodes.Clear()
			Me.body = document.GetElementsByName("body")
			Dim tnode As TreeNode = Nothing
			tnode = Me.treeView1.Nodes.Add(Me.body(0).Name)
			tnode.Tag = Me.body(0)
			AddElements(Me.body(0), tnode)
		End Sub

		Private Sub AddElements(ByVal element As IHTMLElement, ByVal parentNode As TreeNode)
            Dim coll As IHTMLElementsCollection = element.Children
            Dim elem As IHTMLElement
            For Each elem In coll
                Dim tnode As TreeNode = Nothing
                tnode = parentNode.Nodes.Add(elem.Name)
                tnode.Tag = elem
                AddElements(elem, tnode)
            Next elem
		End Sub

		Private Sub ScrollToEnd()
			Dim elem As IHTMLElement = Me.htmluiControl1.Document.RenderRoot
			Dim lastPoint As Point = new Point(0, (elem.Location.Y + elem.Size.Height))
			Dim rect As Rectangle = new Rectangle(new Point(10, lastPoint.Y-10), new Size(10,10))
			Me.htmluiControl1.ScrollToRectangle(rect, Me.htmluiControl1.Document)
		End Sub
		#End Region

	End Class
End Namespace
