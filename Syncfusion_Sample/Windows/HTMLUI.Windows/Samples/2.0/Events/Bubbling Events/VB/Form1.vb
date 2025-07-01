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
		Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl
		Private statusBar1 As System.Windows.Forms.StatusBar

		Private Shared filePath As String = Nothing

		Private htmlelements As Hashtable = New Hashtable()
		Private panel1 As System.Windows.Forms.Panel
        Private htmlelement As IHTMLElement()


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
        Friend WithEvents panel2 As System.Windows.Forms.Panel
        Friend WithEvents panel3 As System.Windows.Forms.Panel
        Friend WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents label1 As System.Windows.Forms.Label
        Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
            Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
            Me.statusBar1 = New System.Windows.Forms.StatusBar()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
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
            Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(341, 337)
            Me.htmluiControl1.EnableMultithreading = False
            Me.htmluiControl1.IsOriginalTextCached = True
            Me.htmluiControl1.Location = New System.Drawing.Point(176, 0)
            Me.htmluiControl1.Name = "htmluiControl1"
            Me.htmluiControl1.ShowTitle = False
            Me.htmluiControl1.Size = New System.Drawing.Size(368, 352)
            Me.htmluiControl1.StartupDocument = ""
            Me.htmluiControl1.StartupFolder = ""
            Me.htmluiControl1.TabIndex = 0
            Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & _
            "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & _
            "=""True"" xsize=""{Width=71, Height=15}"" xlocation=""{X=10,Y=0}"">htmluiControl1</bod" & _
            "y></html>"
            '
            'statusBar1
            '
            Me.statusBar1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right)
            Me.statusBar1.Dock = System.Windows.Forms.DockStyle.None
            Me.statusBar1.Location = New System.Drawing.Point(0, 352)
            Me.statusBar1.Name = "statusBar1"
            Me.statusBar1.Size = New System.Drawing.Size(552, 22)
            Me.statusBar1.TabIndex = 1
            Me.statusBar1.Text = "statusBar1"
            '
            'panel1
            '
            Me.panel1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left)
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
            Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2, Me.checkBox1})
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(176, 352)
            Me.panel1.TabIndex = 2
            '
            'panel2
            '
            Me.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(215, Byte), CType(221, Byte), CType(237, Byte))
            Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel3})
            Me.panel2.Location = New System.Drawing.Point(8, 120)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(160, 88)
            Me.panel2.TabIndex = 5
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(198, Byte), CType(220, Byte))
            Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2, Me.label1})
            Me.panel3.Location = New System.Drawing.Point(2, 2)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(156, 84)
            Me.panel3.TabIndex = 0
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.FromArgb(CType(103, Byte), CType(110, Byte), CType(152, Byte))
            Me.label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.WhiteSmoke
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(160, 24)
            Me.label2.TabIndex = 4
            Me.label2.Text = "Action"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label1
            '
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(46, Byte), CType(28, Byte))
            Me.label1.Location = New System.Drawing.Point(2, 28)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(150, 54)
            Me.label1.TabIndex = 2
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'checkBox1
            '
            Me.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.ForeColor = System.Drawing.Color.FromArgb(CType(51, Byte), CType(51, Byte), CType(103, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(8, 32)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(160, 72)
            Me.checkBox1.TabIndex = 4
            Me.checkBox1.Text = "Check To Include Mouse Leave Event"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(552, 374)
            Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.statusBar1, Me.htmluiControl1})
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Bubbling Events"
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

		Private Sub htmluiControl1_LoadError(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.HTMLUI.LoadErrorEventArgs) Handles htmluiControl1.LoadError
			Me.statusBar1.Text = "Load failed " & e.Document.FileName & " " +e.Document.RenderException.Message
		End Sub

		Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
			Try

				Me.statusBar1.Text = "Load succeeded."

				Dim path As String = String.Empty

				If Not Me.htmluiControl1.Document.Uri Is Nothing Then
					path = Me.htmluiControl1.Document.Uri.LocalPath
				Else
					path = Me.htmluiControl1.Document.FileName
				End If

				If path = GetFilesLocation() & "main.htm" Then
					htmlelement = Me.htmluiControl1.Document.GetElementsByName("body")
				End If
				AddHandler htmlelement(0).Click, AddressOf body_OnClick
				AddHandler htmlelement(0).MouseLeave, AddressOf body_MouseLeave
			Catch ex As Exception
                Console.WriteLine("Error:" & ex.ToString())
			End Try
		End Sub

		Private Sub body_OnClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim bargs As BubblingEventArgs = HTMLUIControl.GetBublingEventArgs(e)
			Dim elem As BaseElement = CType(IIf(TypeOf bargs.RootSender Is BaseElement, bargs.RootSender, Nothing), BaseElement)

			If Not elem Is Nothing AndAlso TypeOf elem Is INPUTElementImpl Then
				If elem.ID = "Button1" Then
					Me.label1.Text = "Button 1 clicked"
				Else If elem.ID = "Button2" Then
					Me.label1.Text = "Button 2 clicked"
				Else If elem.ID = "Button3" Then
					Me.label1.Text = "Button 3 clicked"
				Else If elem.ID = "Button4" Then
					Me.label1.Text = "Button 4 clicked"
				End If
			End If
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			LoadFromFile("main.htm")
		End Sub

        Private Sub caBtn_Click(ByVal sender As Object, ByVal e As EventArgs)
            LoadFromFile("main.htm")
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
            Dim slashPos As Integer = path.LastIndexOf("\", path.Length)
            slashPos = path.LastIndexOf("\", slashPos - 1)
            slashPos = path.LastIndexOf("\", slashPos - 1)
            If slashPos > 0 Then
                path = path.Substring(0, slashPos)
            End If
            path = path.Replace("file:\", "")
            filePath = path & "\files\"
            Return filePath
        End Function

        Private Sub body_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
            Dim bargs As BubblingEventArgs = HTMLUIControl.GetBublingEventArgs(e)
            Dim elem As BaseElement = CType(IIf(TypeOf bargs.RootSender Is BaseElement, bargs.RootSender, Nothing), BaseElement)

            If Not elem Is Nothing AndAlso TypeOf elem Is INPUTElementImpl AndAlso checkBox1.Checked = True Then
                If elem.ID = "Button1" Then
                    Me.label1.Text = "Mouse just left Button 1"
                ElseIf elem.ID = "Button2" Then
                    Me.label1.Text = "Mouse just left Button 2"
                ElseIf elem.ID = "Button3" Then
                    Me.label1.Text = "Mouse just left Button 3"
                ElseIf elem.ID = "Button4" Then
                    Me.label1.Text = "Mouse just left Button 4"
                End If
            End If
        End Sub
    End Class
End Namespace
