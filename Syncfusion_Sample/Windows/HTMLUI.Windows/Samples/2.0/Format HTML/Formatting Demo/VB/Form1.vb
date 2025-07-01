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
		Private panel1 As System.Windows.Forms.Panel
        Private label1 As System.Windows.Forms.Label
        Private formatOrange As HTMLFormat = Nothing
		Private formatGreen As HTMLFormat = Nothing

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
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents panel3 As System.Windows.Forms.Panel
        Friend WithEvents panel4 As System.Windows.Forms.Panel
        Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
        Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
        Friend WithEvents label3 As System.Windows.Forms.Label
        Friend WithEvents label4 As System.Windows.Forms.Label
        Friend WithEvents label2 As System.Windows.Forms.Label
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.radioButton2 = New System.Windows.Forms.RadioButton()
            Me.radioButton1 = New System.Windows.Forms.RadioButton()
            Me.label1 = New System.Windows.Forms.Label()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.Panel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'htmluiControl1
            '
            Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.htmluiControl1.AutoScroll = True
            Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(389, 241)
            Me.htmluiControl1.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Location = New System.Drawing.Point(136, 120)
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.ShowTitle = False
            Me.htmluiControl1.Size = New System.Drawing.Size(416, 256)
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
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3})
            Me.panel1.Location = New System.Drawing.Point(0, -8)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(136, 384)
            Me.panel1.TabIndex = 1
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel4})
            Me.panel3.Location = New System.Drawing.Point(8, 32)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(120, 136)
            Me.panel3.TabIndex = 3
            '
            'panel4
            '
            Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.panel4.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2, Me.radioButton2, Me.radioButton1})
            Me.panel4.Location = New System.Drawing.Point(2, 2)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(116, 132)
            Me.panel4.TabIndex = 5
            '
            'radioButton2
            '
            Me.radioButton2.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
            Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton2.ForeColor = System.Drawing.Color.Maroon
            Me.radioButton2.Location = New System.Drawing.Point(4, 76)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(108, 40)
            Me.radioButton2.TabIndex = 5
            Me.radioButton2.Text = "Format green"
            '
            'radioButton1
            '
            Me.radioButton1.Anchor = (System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right)
            Me.radioButton1.Checked = True
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.radioButton1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.radioButton1.ForeColor = System.Drawing.Color.Maroon
            Me.radioButton1.Location = New System.Drawing.Point(4, 36)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(108, 32)
            Me.radioButton1.TabIndex = 4
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Format orange"
            '
            'label1
            '
            Me.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.label1.BackColor = System.Drawing.Color.White
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.Maroon
            Me.label1.Location = New System.Drawing.Point(16, 32)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(384, 56)
            Me.label1.TabIndex = 2
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel2
            '
            Me.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(223, Byte), CType(228, Byte), CType(240, Byte))
            Me.Panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.label4, Me.label3, Me.label1})
            Me.Panel2.Location = New System.Drawing.Point(136, 0)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(416, 120)
            Me.Panel2.TabIndex = 2
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.Maroon
            Me.label4.Location = New System.Drawing.Point(16, 96)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(94, 14)
            Me.label4.TabIndex = 6
            Me.label4.Text = "HTMLUI Output"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.Maroon
            Me.label3.Location = New System.Drawing.Point(16, 8)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(65, 14)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Style code"
            '
            'label2
            '
            Me.label2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.WhiteSmoke
            Me.label2.Location = New System.Drawing.Point(-2, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(120, 24)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Format style"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Panel2, Me.panel1, Me.htmluiControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Formatting Demo"
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
            Me.Panel2.ResumeLayout(False)
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
			CreateHTMLFormat()
			LoadHTMLResource()
		End Sub

		Private Sub CreateHTMLFormat()
			formatOrange = New HTMLFormat("FormatOrange")
			formatOrange.Font = New Font("Comic Sans MS",11,System.Drawing.FontStyle.Bold)
			formatOrange.ForeColor = Color.Blue
			formatOrange.BackgroundColor = Color.Orange
			formatOrange.Cursor = Cursors.Hand

			formatGreen = New HTMLFormat("FormatGreen")
			formatGreen.Font = New Font("Arial",10)
			formatGreen.ForeColor = Color.White
			formatGreen.BackgroundColor = Color.Green
			formatGreen.Cursor = Cursors.Cross
		End Sub

		Private Function LoadHTMLResource() As Boolean
			Dim success As Boolean = False

			Try
				_assembly = System.Reflection.Assembly.GetExecutingAssembly()
				_htmlStream = CType(_assembly.GetManifestResourceStream("format.htm"), Stream)
				If Not _htmlStream Is Nothing Then
					Me.htmluiControl1.LoadHTML(_htmlStream)
					success = True
				End If
			Catch ex As Exception
				MessageBox.Show(ex.ToString())
			End Try
			Return success
		End Function

		Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
			Dim elem As IHTMLElement() = Me.htmluiControl1.Document.GetElementsByName("body")
			AddHandler elem(0).Click, AddressOf ElementClick
		End Sub

		Private Sub ElementClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim barg As BubblingEventArgs = HTMLUIControl.GetBublingEventArgs(e)
			Dim elem As BaseElement = CType(IIf(TypeOf barg.RootSender Is BaseElement, barg.RootSender, Nothing), BaseElement)
			If elem.Name = "p" AndAlso Not formatOrange Is Nothing Then
				If radioButton1.Checked = True Then
					elem.Format = formatOrange
				End If
				If radioButton2.Checked = True Then
					elem.Format = formatGreen
				Else If radioButton1.Checked = False AndAlso radioButton2.Checked = False Then
					MessageBox.Show("Check any of the test Boxes to show the Format")
				End If
                Me.label1.Text = elem.Format.Name.ToString() + Constants.vbLf + elem.Format.Font.ToString() + elem.Format.BackgroundColor.ToString()
			End If

		End Sub

       
    End Class
End Namespace
