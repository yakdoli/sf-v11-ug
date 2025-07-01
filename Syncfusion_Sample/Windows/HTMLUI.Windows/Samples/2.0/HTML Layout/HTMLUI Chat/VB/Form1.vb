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
Imports System.Xml
Imports System.Reflection

Imports Syncfusion.Windows.Forms.HTMLUI

Namespace Syncfusion.Windows.Forms.HTMLUI.Samples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		#Region "ClassSummaryDescription"
		Private WithEvents htmluiControl1 As Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl

		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents textBox1 As System.Windows.Forms.TextBox
		Private WithEvents button1 As System.Windows.Forms.Button

		Private table1 As BaseElement = Nothing

		Private Const DEF_IMG_SMILE As String = "<img id='smile' src='..\..\smile.gif'>"
		Private Const DEF_IMG_SAD As String = "<img id='sad' src='..\..\sad.gif'>"
		Private Const DEF_IMG_LAUGH As String = "<img id='laugh' src='..\..\laugh.gif'>"
		Private Const DEF_IMG_WAVE As String = "<img id='wave' src='..\..\wave.gif'>"
		Private Const DEF_SMILE As String = ":-)"
		Private Const DEF_SAD As String = ":-("
		Private Const DEF_LAUGH As String = ":))"
		Private Const DEF_WAVE As String = ":-h"

		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button5 As System.Windows.Forms.Button
		Private panel2 As System.Windows.Forms.Panel
		Private panel3 As System.Windows.Forms.Panel
		Private panel4 As System.Windows.Forms.Panel
		Private panel5 As System.Windows.Forms.Panel
		Private panel6 As System.Windows.Forms.Panel
		Private WithEvents button7 As System.Windows.Forms.Button
		Private panel7 As System.Windows.Forms.Panel
		Private imageList1 As System.Windows.Forms.ImageList
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private contextMenu1 As System.Windows.Forms.ContextMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
		Private menuItem6 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem7 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem9 As System.Windows.Forms.MenuItem
		Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
		Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private panel8 As System.Windows.Forms.Panel
		Private WithEvents button6 As System.Windows.Forms.Button
		Private WithEvents menuItem8 As System.Windows.Forms.MenuItem
		Private components As System.ComponentModel.IContainer
		#End Region

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
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
			Me.htmluiControl1 = New Syncfusion.Windows.Forms.HTMLUI.HTMLUIControl()
			Me.contextMenu1 = New System.Windows.Forms.ContextMenu()
			Me.menuItem9 = New System.Windows.Forms.MenuItem()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel8 = New System.Windows.Forms.Panel()
			Me.button6 = New System.Windows.Forms.Button()
			Me.button1 = New System.Windows.Forms.Button()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.button5 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.button3 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.panel6 = New System.Windows.Forms.Panel()
			Me.button7 = New System.Windows.Forms.Button()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.panel7 = New System.Windows.Forms.Panel()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.panel5 = New System.Windows.Forms.Panel()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.mainMenu1 = New System.Windows.Forms.MainMenu()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.menuItem2 = New System.Windows.Forms.MenuItem()
			Me.menuItem3 = New System.Windows.Forms.MenuItem()
			Me.menuItem4 = New System.Windows.Forms.MenuItem()
			Me.menuItem5 = New System.Windows.Forms.MenuItem()
			Me.menuItem6 = New System.Windows.Forms.MenuItem()
			Me.menuItem7 = New System.Windows.Forms.MenuItem()
			Me.menuItem8 = New System.Windows.Forms.MenuItem()
			Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
			Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
			CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.panel8.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.panel6.SuspendLayout()
			Me.panel7.SuspendLayout()
			Me.panel4.SuspendLayout()
			Me.panel5.SuspendLayout()
			Me.panel3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' htmluiControl1
			' 
			Me.htmluiControl1.AutoScroll = True
			Me.htmluiControl1.AutoScrollMinSize = New System.Drawing.Size(309, 297)
			Me.htmluiControl1.ContextMenu = Me.contextMenu1
			Me.htmluiControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.htmluiControl1.EnableMultithreading = False
			Me.htmluiControl1.IsOriginalTextCached = True
			Me.htmluiControl1.Location = New System.Drawing.Point(0, 0)
			Me.htmluiControl1.Name = "htmluiControl1"
			Me.htmluiControl1.ShowTitle = False
			Me.htmluiControl1.Size = New System.Drawing.Size(336, 312)
			Me.htmluiControl1.StartupDocument = ""
			Me.htmluiControl1.StartupFolder = ""
			Me.htmluiControl1.TabIndex = 0
			Me.htmluiControl1.Text = "<html xvisible=""True"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}""><head xvi" & "sible=""False"" xsize=""{Width=0, Height=0}"" xlocation=""{X=0,Y=0}"" /><body xvisible" & "=""True"" xsize=""{Width=66, Height=15}"" xlocation=""{X=10,Y=15}"">htmluiControl1</bo" & "dy></html>"
			Me.toolTip1.SetToolTip(Me.htmluiControl1, "HTMLUI Control")
'			Me.htmluiControl1.LoadFinished += New System.EventHandler(Me.htmluiControl1_LoadFinished);
			' 
			' contextMenu1
			' 
			Me.contextMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem9})
			' 
			' menuItem9
			' 
			Me.menuItem9.Index = 0
			Me.menuItem9.Text = "Copy"
'			Me.menuItem9.Click += New System.EventHandler(Me.menuItem9_Click);
			' 
			' panel1
			' 
			Me.panel1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CByte(229)), (CByte(255)), (CByte(255)))
			Me.panel1.Controls.Add(Me.panel8)
			Me.panel1.Controls.Add(Me.button5)
			Me.panel1.Controls.Add(Me.button4)
			Me.panel1.Controls.Add(Me.button3)
			Me.panel1.Controls.Add(Me.button2)
			Me.panel1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.panel1.Location = New System.Drawing.Point(0, 312)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(336, 136)
			Me.panel1.TabIndex = 1
			' 
			' panel8
			' 
			Me.panel8.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel8.BackColor = System.Drawing.Color.White
			Me.panel8.Controls.Add(Me.button6)
			Me.panel8.Controls.Add(Me.button1)
			Me.panel8.Controls.Add(Me.textBox1)
			Me.panel8.Location = New System.Drawing.Point(8, 40)
			Me.panel8.Name = "panel8"
			Me.panel8.Size = New System.Drawing.Size(312, 88)
			Me.panel8.TabIndex = 6
			' 
			' button6
			' 
			Me.button6.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button6.BackColor = System.Drawing.Color.LightCyan
			Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button6.ForeColor = System.Drawing.SystemColors.ControlText
			Me.button6.Image = (CType(resources.GetObject("button6.Image"), System.Drawing.Image))
			Me.button6.Location = New System.Drawing.Point(256, 56)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(48, 17)
			Me.button6.TabIndex = 2
			Me.button6.Text = "Search"
			Me.toolTip1.SetToolTip(Me.button6, "Search for text")
'			Me.button6.Click += New System.EventHandler(Me.button6_Click);
			' 
			' button1
			' 
			Me.button1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.BackColor = System.Drawing.Color.LightCyan
			Me.button1.Enabled = False
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.button1.Image = (CType(resources.GetObject("button1.Image"), System.Drawing.Image))
			Me.button1.Location = New System.Drawing.Point(256, 8)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(48, 48)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Send"
			Me.toolTip1.SetToolTip(Me.button1, "Send Message")
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' textBox1
			' 
			Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.textBox1.Dock = System.Windows.Forms.DockStyle.Left
			Me.textBox1.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(177)))
			Me.textBox1.Location = New System.Drawing.Point(0, 0)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(256, 88)
			Me.textBox1.TabIndex = 0
			Me.textBox1.Text = ""
'			Me.textBox1.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.textBox1_KeyDown);
'			Me.textBox1.TextChanged += New System.EventHandler(Me.textBox1_TextChanged);
			' 
			' button5
			' 
			Me.button5.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.button5.BackColor = System.Drawing.Color.LightCyan
			Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.button5.Image = (CType(resources.GetObject("button5.Image"), System.Drawing.Image))
			Me.button5.Location = New System.Drawing.Point(152, 8)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(32, 24)
			Me.button5.TabIndex = 5
			Me.toolTip1.SetToolTip(Me.button5, "Cry")
'			Me.button5.Click += New System.EventHandler(Me.button5_Click);
			' 
			' button4
			' 
			Me.button4.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.button4.BackColor = System.Drawing.Color.LightCyan
			Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.button4.Image = (CType(resources.GetObject("button4.Image"), System.Drawing.Image))
			Me.button4.Location = New System.Drawing.Point(104, 8)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(32, 24)
			Me.button4.TabIndex = 4
			Me.toolTip1.SetToolTip(Me.button4, "bye")
'			Me.button4.Click += New System.EventHandler(Me.button4_Click);
			' 
			' button3
			' 
			Me.button3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.button3.BackColor = System.Drawing.Color.LightCyan
			Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.button3.Image = (CType(resources.GetObject("button3.Image"), System.Drawing.Image))
			Me.button3.Location = New System.Drawing.Point(56, 8)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(32, 24)
			Me.button3.TabIndex = 3
			Me.toolTip1.SetToolTip(Me.button3, "broad smile")
'			Me.button3.Click += New System.EventHandler(Me.button3_Click);
			' 
			' button2
			' 
			Me.button2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.button2.BackColor = System.Drawing.Color.LightCyan
			Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.button2.Image = (CType(resources.GetObject("button2.Image"), System.Drawing.Image))
			Me.button2.Location = New System.Drawing.Point(8, 8)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(32, 24)
			Me.button2.TabIndex = 2
			Me.toolTip1.SetToolTip(Me.button2, "smile")
'			Me.button2.Click += New System.EventHandler(Me.button2_Click);
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.FromArgb((CByte(218)), (CByte(229)), (CByte(245)))
			Me.panel2.BackgroundImage = (CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image))
			Me.panel2.Controls.Add(Me.panel6)
			Me.panel2.Controls.Add(Me.panel4)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel2.ImeMode = System.Windows.Forms.ImeMode.Off
			Me.panel2.Location = New System.Drawing.Point(336, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(128, 446)
			Me.panel2.TabIndex = 2
			' 
			' panel6
			' 
			Me.panel6.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel6.BackColor = System.Drawing.Color.AliceBlue
			Me.panel6.Controls.Add(Me.button7)
			Me.panel6.Controls.Add(Me.panel7)
			Me.panel6.Location = New System.Drawing.Point(8, 312)
			Me.panel6.Name = "panel6"
			Me.panel6.Size = New System.Drawing.Size(112, 120)
			Me.panel6.TabIndex = 1
			' 
			' button7
			' 
			Me.button7.BackColor = System.Drawing.Color.AliceBlue
			Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.button7.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button7.ForeColor = System.Drawing.Color.AliceBlue
			Me.button7.ImageIndex = 5
			Me.button7.ImageList = Me.imageList1
			Me.button7.Location = New System.Drawing.Point(72, 104)
			Me.button7.Name = "button7"
			Me.button7.Size = New System.Drawing.Size(32, 15)
			Me.button7.TabIndex = 1
			Me.button7.Text = "..."
			Me.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
			Me.toolTip1.SetToolTip(Me.button7, "Change the display picture")
'			Me.button7.Click += New System.EventHandler(Me.button7_Click);
			' 
			' imageList1
			' 
			Me.imageList1.ImageSize = New System.Drawing.Size(15, 15)
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			' 
			' panel7
			' 
			Me.panel7.BackColor = System.Drawing.Color.White
			Me.panel7.Controls.Add(Me.pictureBox2)
			Me.panel7.ForeColor = System.Drawing.Color.Honeydew
			Me.panel7.Location = New System.Drawing.Point(8, 8)
			Me.panel7.Name = "panel7"
			Me.panel7.Size = New System.Drawing.Size(96, 96)
			Me.panel7.TabIndex = 0
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(96, 96)
			Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox2.TabIndex = 0
			Me.pictureBox2.TabStop = False
			' 
			' panel4
			' 
			Me.panel4.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel4.BackColor = System.Drawing.Color.AliceBlue
			Me.panel4.Controls.Add(Me.panel5)
			Me.panel4.Location = New System.Drawing.Point(8, 16)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(112, 120)
			Me.panel4.TabIndex = 0
			' 
			' panel5
			' 
			Me.panel5.BackColor = System.Drawing.Color.White
			Me.panel5.Controls.Add(Me.pictureBox1)
			Me.panel5.ForeColor = System.Drawing.Color.Honeydew
			Me.panel5.Location = New System.Drawing.Point(8, 8)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New System.Drawing.Size(96, 96)
			Me.panel5.TabIndex = 0
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(96, 96)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' panel3
			' 
			Me.panel3.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel3.Controls.Add(Me.htmluiControl1)
			Me.panel3.Location = New System.Drawing.Point(0, 0)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(336, 312)
			Me.panel3.TabIndex = 3
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1, Me.menuItem6})
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 0
			Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem2, Me.menuItem3, Me.menuItem4, Me.menuItem5})
			Me.menuItem1.Text = "File"
			' 
			' menuItem2
			' 
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "New Chat Window"
'			Me.menuItem2.Click += New System.EventHandler(Me.menuItem2_Click);
			' 
			' menuItem3
			' 
			Me.menuItem3.Index = 1
			Me.menuItem3.Text = "Save this conversation"
'			Me.menuItem3.Click += New System.EventHandler(Me.menuItem3_Click);
			' 
			' menuItem4
			' 
			Me.menuItem4.Index = 2
			Me.menuItem4.Text = "Open old conversation"
'			Me.menuItem4.Click += New System.EventHandler(Me.menuItem4_Click);
			' 
			' menuItem5
			' 
			Me.menuItem5.Index = 3
			Me.menuItem5.Text = "Exit"
'			Me.menuItem5.Click += New System.EventHandler(Me.menuItem5_Click);
			' 
			' menuItem6
			' 
			Me.menuItem6.Index = 1
			Me.menuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem7, Me.menuItem8})
			Me.menuItem6.Text = "Options"
			' 
			' menuItem7
			' 
			Me.menuItem7.Index = 0
			Me.menuItem7.Text = "Change display picture"
'			Me.menuItem7.Click += New System.EventHandler(Me.menuItem7_Click);
			' 
			' menuItem8
			' 
			Me.menuItem8.Index = 1
			Me.menuItem8.Text = "ChangeBackGround"
'			Me.menuItem8.Click += New System.EventHandler(Me.menuItem8_Click);
			' 
			' saveFileDialog1
			' 
			Me.saveFileDialog1.FileName = "Conversation1"
			Me.saveFileDialog1.Title = "Save the conversation"
			' 
			' openFileDialog1
			' 
			Me.openFileDialog1.CheckFileExists = False
			Me.openFileDialog1.CheckPathExists = False
			Me.openFileDialog1.RestoreDirectory = True
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(464, 446)
			Me.Controls.Add(Me.panel3)
			Me.Controls.Add(Me.panel2)
			Me.Controls.Add(Me.panel1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Menu = Me.mainMenu1
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "HTMLUI Chat"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.htmluiControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel8.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.panel6.ResumeLayout(False)
			Me.panel7.ResumeLayout(False)
			Me.panel4.ResumeLayout(False)
			Me.panel5.ResumeLayout(False)
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

		#Region "ApplicationEvents"
		Private Sub htmluiControl1_LoadFinished(ByVal sender As Object, ByVal e As System.EventArgs) Handles htmluiControl1.LoadFinished
			WireElements()
		End Sub


		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.htmluiControl1.LoadFromString("")
			LoadHTMLFile("chat.htm")
            Me.pictureBox1.Image = Image.FromFile(GetLocation() & "\clouds.jpg")
            Me.pictureBox2.Image = Image.FromFile(GetLocation() & "\clouds.jpg")
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			SendContents()
		End Sub

		Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles textBox1.TextChanged
			If Me.textBox1.Text <> String.Empty Then
				Me.button1.Enabled = True
			End If
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
			Me.textBox1.Text &= ":-)"
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
			Me.textBox1.Text &= ":))"
		End Sub

		Private Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
			Me.textBox1.Text &= ":-h"
		End Sub

		Private Sub button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button5.Click
			Me.textBox1.Text &= ":-("
		End Sub

		Private Sub textBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textBox1.KeyDown
			If e.KeyCode = Keys.Enter Then
				SendContents()
			End If
		End Sub

		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
			Dim form As Form = New Form1()
			form.Show()
		End Sub

		Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
			Me.Close()
		End Sub

		Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
			Me.saveFileDialog1.Filter = "xml files|*.xml"
			Me.openFileDialog1.InitialDirectory = Directory.CreateDirectory("..\..\").FullName.ToString()
			If saveFileDialog1.ShowDialog() = DialogResult.OK Then
				Me.htmluiControl1.Document.Document.Save(saveFileDialog1.FileName)
			End If
			Console.WriteLine("Conversation saved.")
		End Sub

		Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click
			Me.openFileDialog1.Filter = "xml files|*.xml"
			Me.openFileDialog1.InitialDirectory = Directory.CreateDirectory("..\..\").FullName.ToString()
			If Me.openFileDialog1.ShowDialog() = DialogResult.OK Then
				Dim document As XmlDocument = New XmlDocument()
				document.Load(openFileDialog1.FileName)
				Dim outerXML As String = document.FirstChild.OuterXml.ToString()
				Me.htmluiControl1.LoadFromString(ReplaceImage(outerXML))
			End If
			Console.WriteLine("Conversation opened.")
		End Sub

		Private Sub menuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem7.Click
			Me.ChangeDisplayPicture()
		End Sub

		Private Sub button7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button7.Click
			Me.ChangeDisplayPicture()
		End Sub

		Private Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button6.Click
			Me.htmluiControl1.DisplayFindForm()
		End Sub

		Private Sub menuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem8.Click
			ChangeBackGroundPicture()
		End Sub

		Private Sub menuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem9.Click
			Dim str As String = Me.htmluiControl1.SelectedText.ToString()
			If str <> "" Then
				Clipboard.SetDataObject(str, True)
			End If
		End Sub
		#End Region

		#Region "ClassHelperMethods"
		Private Sub ChangeDisplayPicture()
			Me.openFileDialog1.Filter = "Bmp files|*.bmp|Jpg files|*.jpg|Gif files|*.gif"
			Me.openFileDialog1.InitialDirectory = Directory.CreateDirectory("..\..\").FullName.ToString()
			If Me.openFileDialog1.ShowDialog() = DialogResult.OK Then
				Me.pictureBox2.Image = Image.FromFile(Me.openFileDialog1.FileName.ToString())
			End If
		End Sub

		Private Function ReplaceImage(ByVal OuterXML As String) As String
			Me.htmluiControl1.LoadFromString(OuterXML)
			Dim element As IHTMLElement() = Me.htmluiControl1.Document.GetElementsByName("body")
			Dim collection As IHTMLElementsCollection = element(0).Children

			Dim elem As IHTMLElement
			For Each elem In collection
				WriteElement(elem)
			Next elem
			Return Me.htmluiControl1.Document.Document.OuterXml
		End Function

		Private Sub WriteElement(ByVal elem As IHTMLElement)
			If elem.ID = "smile" Then
				Console.WriteLine(elem.Attributes("src").Value.ToString())
				elem.Attributes("src").Value = GetLocation() & "\smile.gif"

			Else If elem.ID = "sad" Then
				elem.Attributes("src").Value = GetLocation() & "\sad.gif"

			Else If elem.ID = "laugh" Then
				elem.Attributes("src").Value = GetLocation() & "\laugh.gif"

			Else If elem.ID = "wave" Then
				elem.Attributes("src").Value = GetLocation() & "\wave.gif"
			End If

			If elem.Children.Count <> 0 Then
				Dim newParent As IHTMLElementsCollection = elem.Children
				Dim smallChild As IHTMLElement
				For Each smallChild In newParent
					WriteElement(smallChild)
				Next smallChild
			End If
		End Sub

		Private Function GetLocation() As String
			Dim path As String
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
			Dim slashPos As Integer = path.LastIndexOf("\",path.Length)
			slashPos = path.LastIndexOf("\",slashPos-1)
			slashPos = path.LastIndexOf("\",slashPos-1)
			If slashPos > 0 Then
				path = path.Substring(0,slashPos)
			End If
			path = path.Replace("file:\", "")
			path = path & "\files"
			Return path
		End Function

		Private Sub WireElements()
			Dim htmlelements As Hashtable = Me.htmluiControl1.Document.GetElementsByUserIdHash()
			Me.table1 = CType(IIf(TypeOf htmlelements("Table1") Is BaseElement, htmlelements("Table1"), Nothing), BaseElement)
		End Sub

		Private Sub LoadHTMLFile(ByVal fileName As String)
			Dim path As String
			path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
			Dim slashPos As Integer = path.LastIndexOf("\",path.Length)
			slashPos = path.LastIndexOf("\",slashPos-1)
			slashPos = path.LastIndexOf("\",slashPos-1)
			If slashPos > 0 Then
				path = path.Substring(0,slashPos)
			End If
			path = path.Replace("file:\", "")
			Me.htmluiControl1.StartupDocument = System.IO.Path.Combine(path & "//files", fileName)
		End Sub

		Private Sub SendContents()
			If Me.textBox1.Text <> String.Empty Then
				AddToDisplay(Me.textBox1.Text)
				Me.textBox1.Clear()
				Me.button1.Enabled = False
			End If
		End Sub

		Private Sub AddToDisplay(ByVal newText As String)
			'Replace the text with the smileys
			newText = newText.Replace(DEF_SMILE, DEF_IMG_SMILE)
			newText = newText.Replace(DEF_LAUGH, DEF_IMG_LAUGH)
			newText = newText.Replace(DEF_WAVE, DEF_IMG_WAVE)
			newText = newText.Replace(DEF_SAD, DEF_IMG_SAD)

			newText = newText.Replace(Constants.vbCrLf, "<br \>")

			' Create a new row and insert the text
			Me.table1.InnerHTML &= "<tr><td class=""date"">" & DateTime.Now.ToString() & "</td></tr><tr><td class=""message"">" & newText & "<p/></td></tr>"
			ScrollToEnd()
		End Sub

		Private Sub ChangeBackGroundPicture()
			Me.openFileDialog1.Filter = "Bmp files|*.bmp|Jpg files|*.jpg|Gif files|*.gif"
			Me.openFileDialog1.InitialDirectory = Directory.CreateDirectory("..\..\").FullName.ToString()
			If Me.openFileDialog1.ShowDialog() = DialogResult.OK Then
				Me.panel1.BackgroundImage = Image.FromFile(Me.openFileDialog1.FileName.ToString())
				Me.panel2.BackgroundImage = Image.FromFile(Me.openFileDialog1.FileName.ToString())
			End If
		End Sub

		Private Sub ScrollToEnd()
			Dim lastPoint As Point = New Point(Me.table1.Location.X + Me.table1.Size.Width, Me.table1.Location.Y + Me.table1.Size.Height)
			Dim rect As Rectangle = New Rectangle(New Point(lastPoint.X-10, lastPoint.Y-10), New Size(10,10))
			Me.htmluiControl1.ScrollToRectangle(rect, Me.htmluiControl1.Document)
		End Sub
		#End Region
	End Class
End Namespace
