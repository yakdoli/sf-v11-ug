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


Namespace Syncfusion.Windows.Forms.HTMLUI.Samples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private _assembly As System.Reflection.Assembly
		Private _htmlStream As Stream

		Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl

		Private descriptions As IHTMLElement() = Nothing

        Private beginPoint As Point, endPoint As Point = Point.Empty
        Private description As Syncfusion.Windows.Forms.HTMLUI.IHTMLElement

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
        Friend WithEvents panel1 As System.Windows.Forms.Panel
        Friend WithEvents panel2 As System.Windows.Forms.Panel
        Friend WithEvents panel3 As System.Windows.Forms.Panel
        Friend WithEvents label3 As System.Windows.Forms.Label
        Friend WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents label1 As System.Windows.Forms.Label
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
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
            Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(357, 358)
            Me.htmluiControl1.BackColor = System.Drawing.Color.White
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.ShowTitle = False
            Me.htmluiControl1.Size = New System.Drawing.Size(384, 373)
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
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2})
            Me.panel1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
            Me.panel1.Location = New System.Drawing.Point(384, 1)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(168, 373)
            Me.panel1.TabIndex = 2
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3})
            Me.panel2.Location = New System.Drawing.Point(8, 16)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(152, 256)
            Me.panel2.TabIndex = 0
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
            Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.label3, Me.label2, Me.label1})
            Me.panel3.Location = New System.Drawing.Point(2, 2)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(148, 252)
            Me.panel3.TabIndex = 0
            '
            'label3
            '
            Me.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.Maroon
            Me.label3.Location = New System.Drawing.Point(2, 162)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(144, 88)
            Me.label3.TabIndex = 9
            '
            'label2
            '
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.Maroon
            Me.label2.Location = New System.Drawing.Point(2, 70)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(144, 84)
            Me.label2.TabIndex = 8
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(148, 56)
            Me.label1.TabIndex = 7
            Me.label1.Text = "Click on the product descriptions to get their coordinates"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.htmluiControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            'Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.Text = "Element Coordinates"
            'Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
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
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			LoadHTMLResource()
		End Sub

		Private Function LoadHTMLResource() As Boolean
			Dim success As Boolean = False

			Try
				_assembly = System.Reflection.Assembly.GetExecutingAssembly()
				_htmlStream = CType(_assembly.GetManifestResourceStream("products.htm"), Stream)
				If Not _htmlStream Is Nothing Then
					Me.htmluiControl1.LoadHTML(_htmlStream)
					success = True
				End If
			Catch ex As Exception
				MessageBox.Show(ex.ToString())
			End Try
			Return success
		End Function

		Private Sub description_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim element As BaseElement = CType(IIf(TypeOf sender Is BaseElement, sender, Nothing), BaseElement)
			beginPoint = element.Location
            If htmluiControl1.AutoScrollPosition.Y <> 0 Then
                beginPoint.Y += htmluiControl1.AutoScrollPosition.Y
            End If
            endPoint = New Point(beginPoint.X + element.Size.Width, beginPoint.Y + element.Size.Height)
            Me.label2.Text = "Element begins at " & beginPoint.ToString() & " and ends at " & endPoint.ToString()
            Me.label3.Text = "Element's Height" & Constants.vbLf + element.Height.ToString() + Constants.vbLf + Constants.vbLf & "Element's Width" & Constants.vbLf + element.Width.ToString()
            Me.htmluiControl1.Refresh()

		End Sub

		Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
			descriptions = Me.htmluiControl1.Document.GetElementsByName("description")
            If descriptions IsNot Nothing Then
                For Each description In descriptions
                    AddHandler description.Click, AddressOf description_Click
                Next description
            End If
        End Sub

		Private Sub htmluiControl1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles htmluiControl1.Paint
            If beginPoint.Equals(Point.Empty) = False AndAlso endPoint.Equals(Point.Empty) = False Then
                Dim sz As New Size(endPoint.X - beginPoint.X, endPoint.Y - beginPoint.Y)
                Dim rect As New Rectangle(beginPoint, sz)
                e.Graphics.DrawRectangle(New Pen(Color.Red), rect)
            End If
		End Sub
	End Class
End Namespace
