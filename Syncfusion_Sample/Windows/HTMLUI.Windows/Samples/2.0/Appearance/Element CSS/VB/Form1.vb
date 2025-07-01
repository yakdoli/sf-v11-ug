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

Namespace Syncfusion.Windows.Forms.HTMLUI.Samples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form

        Private Shared filePath As String = Nothing
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
        Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
        Friend WithEvents panel2 As System.Windows.Forms.Panel
        Friend WithEvents panel3 As System.Windows.Forms.Panel
        Friend WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
        Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.label1 = New System.Windows.Forms.Label()
            Me.radioButton2 = New System.Windows.Forms.RadioButton()
            Me.radioButton1 = New System.Windows.Forms.RadioButton()
            Me.panel1.SuspendLayout()
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel1
            '
            Me.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left)
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(200, Byte), CType(219, Byte))
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2})
            Me.panel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(128, 374)
            Me.panel1.TabIndex = 3
            '
            'htmluiControl1
            '
            Me.htmluiControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Location = New System.Drawing.Point(128, 0)
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.Size = New System.Drawing.Size(424, 374)
            Me.htmluiControl1.StartupDocument = ""
            Me.htmluiControl1.StartupFolder = ""
            Me.htmluiControl1.TabIndex = 2
            Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
            "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
            "=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=10,Y=20}"" /></html>"
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3})
            Me.panel2.Location = New System.Drawing.Point(4, 32)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(120, 136)
            Me.panel2.TabIndex = 1
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(193, Byte), CType(198, Byte), CType(220, Byte))
            Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.radioButton2, Me.radioButton1})
            Me.panel3.Location = New System.Drawing.Point(2, 2)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(116, 132)
            Me.panel3.TabIndex = 5
            '
            'label1
            '
            Me.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.WhiteSmoke
            Me.label1.Location = New System.Drawing.Point(-2, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(120, 24)
            Me.label1.TabIndex = 6
            Me.label1.Text = "Styles"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            Me.radioButton2.Text = "Style Black"
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
            Me.radioButton1.Text = "Style Red"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.htmluiControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Element CSS"
            Me.panel1.ResumeLayout(False)
            CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
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
			Me.LoadFromFile("index.htm")
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
			slashPos = path.LastIndexOf("\",slashPos-1)
			slashPos = path.LastIndexOf("\",slashPos-1)
			If slashPos > 0 Then
				path = path.Substring(0,slashPos)
			End If
			path = path.Replace("file:\", "")
			filePath = path & "\files\"
			Return filePath
		End Function

        Private Sub htmluiControl1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles htmluiControl1.MouseDown
            Dim elem As BaseElement = CType(IIf(TypeOf Me.htmluiControl1.GetElementAtClientPoint(e.X, e.Y) Is BaseElement, Me.htmluiControl1.GetElementAtClientPoint(e.X, e.Y), Nothing), BaseElement)
            If elem.Attributes.Contains("class") = False Then
                elem.Attributes.Add("class")
            End If
            If Not elem.Attributes("class") Is Nothing Then
                If radioButton1.Checked = True Then
                    elem.Attributes("class").Value = "tttRed"
                ElseIf radioButton2.Checked = True Then
                    elem.Attributes("class").Value = "tttBlack"
                Else
                    MessageBox.Show("Check a style for the elements display.")
                End If
            End If
        End Sub
    End Class
End Namespace
