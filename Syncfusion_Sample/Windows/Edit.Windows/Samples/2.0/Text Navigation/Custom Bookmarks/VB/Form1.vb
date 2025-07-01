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
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Edit
Imports Syncfusion.Windows.Forms.Edit.Dialogs
Imports Syncfusion.Windows.Forms.Edit.Implementation.Config
Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Implementation.IO
Imports Syncfusion.Windows.Forms.Edit.Implementation.Formatting
Imports Syncfusion.Windows.Forms.Edit.Implementation.Parser
Imports Syncfusion.IO

Namespace _CustomBookmarksDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form

		Private image1, image2, image3, image4, selectedImage As Bitmap
		Private BasePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Test Files\Test.lsp"
		Private ConfigPath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\config.xml"
		Private imagePath As String = Path.GetDirectoryName(Application.ExecutablePath) & "\..\..\Images\"
		Private components As System.ComponentModel.IContainer
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
		Private WithEvents button3 As System.Windows.Forms.Button
		Private WithEvents button4 As System.Windows.Forms.Button
		Private WithEvents button5 As System.Windows.Forms.Button
		Private imageList1 As System.Windows.Forms.ImageList
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private pictureBox3 As System.Windows.Forms.PictureBox
		Private pictureBox4 As System.Windows.Forms.PictureBox
		Private WithEvents radioButton1 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton2 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton3 As System.Windows.Forms.RadioButton
		Private WithEvents radioButton4 As System.Windows.Forms.RadioButton
		Private WithEvents button6 As System.Windows.Forms.Button
		Private menuStrip1 As MenuStrip
		Private fileToolStripMenuItem As ToolStripMenuItem
		Private WithEvents newToolStripMenuItem As ToolStripMenuItem
		Private WithEvents openToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator1 As ToolStripSeparator
		Private WithEvents saveToolStripMenuItem As ToolStripMenuItem
		Private WithEvents saveAsToolStripMenuItem As ToolStripMenuItem
		Private toolStripSeparator2 As ToolStripSeparator
		Private WithEvents closeToolStripMenuItem As ToolStripMenuItem
		Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
		Private editControl1 As Syncfusion.Windows.Forms.Edit.EditControl


		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			Me.editControl1.Configurator.Open(ConfigPath)
			Me.editControl1.ApplyConfiguration("LISP")

			Me.editControl1.ShowOutliningCollapsers = True
			Me.editControl1.ShowLineNumbers = True
			Me.editControl1.ShowIndicatorMargin = True
			Me.editControl1.LoadFile(BasePath)

			image1 = New Bitmap(imagePath & "image1.gif")
			image2 = New Bitmap(imagePath & "image2.gif")
			image3 = New Bitmap(imagePath & "image3.gif")
			image4 = New Bitmap(imagePath & "image4.gif")
			pictureBox1.Image = image1
			pictureBox2.Image = image2
			pictureBox3.Image = image3
			pictureBox4.Image = image4

			selectedImage = image1
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
			Dim config5 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.button5 = New System.Windows.Forms.Button()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.button6 = New System.Windows.Forms.Button()
			Me.button4 = New System.Windows.Forms.Button()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.button3 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.button1 = New System.Windows.Forms.Button()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.radioButton4 = New System.Windows.Forms.RadioButton()
			Me.radioButton3 = New System.Windows.Forms.RadioButton()
			Me.radioButton2 = New System.Windows.Forms.RadioButton()
			Me.radioButton1 = New System.Windows.Forms.RadioButton()
			Me.pictureBox4 = New System.Windows.Forms.PictureBox()
			Me.pictureBox3 = New System.Windows.Forms.PictureBox()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
			Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.closeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.menuStrip1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' editControl1
			' 
			Me.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart
			Me.editControl1.BackColor = System.Drawing.SystemColors.Window
			Me.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.editControl1.Configurator = config5
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.LineNumbersFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.editControl1.Location = New System.Drawing.Point(0, 24)
			Me.editControl1.Name = "editControl1"
			Me.editControl1.ShowHorizontalSplitters = False
			Me.editControl1.ShowIndicatorMargin = False
			Me.editControl1.ShowLineNumbers = False
			Me.editControl1.ShowVerticalSplitters = False
			Me.editControl1.Size = New System.Drawing.Size(358, 415)
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = ""
			Me.editControl1.TransferFocusOnTab = True
			Me.editControl1.VirtualSpaceMode = True
			Me.editControl1.VisualColumn = 1
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.button5)
			Me.groupBox1.Controls.Add(Me.groupBox3)
			Me.groupBox1.Controls.Add(Me.groupBox2)
			Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Right
			Me.groupBox1.Location = New System.Drawing.Point(358, 24)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(184, 415)
			Me.groupBox1.TabIndex = 1
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "BookMarks"
			' 
			' button5
			' 
			Me.button5.Location = New System.Drawing.Point(27, 188)
			Me.button5.Name = "button5"
			Me.button5.Size = New System.Drawing.Size(137, 22)
			Me.button5.TabIndex = 2
			Me.button5.Text = "Set Custom Indicator"
'			Me.button5.Click += New System.EventHandler(Me.BookmarkOptionsButtons_Click);
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.button6)
			Me.groupBox3.Controls.Add(Me.button4)
			Me.groupBox3.Controls.Add(Me.button3)
			Me.groupBox3.Controls.Add(Me.button2)
			Me.groupBox3.Controls.Add(Me.button1)
			Me.groupBox3.Location = New System.Drawing.Point(15, 219)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(160, 184)
			Me.groupBox3.TabIndex = 1
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Bookmark Options"
			' 
			' button6
			' 
			Me.button6.Location = New System.Drawing.Point(8, 152)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(136, 24)
			Me.button6.TabIndex = 4
			Me.button6.Text = "Toggle Bookmark"
'			Me.button6.Click += New System.EventHandler(Me.BookmarkOptionsButtons_Click);
			' 
			' button4
			' 
			Me.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.button4.ImageIndex = 3
			Me.button4.ImageList = Me.imageList1
			Me.button4.Location = New System.Drawing.Point(8, 120)
			Me.button4.Name = "button4"
			Me.button4.Size = New System.Drawing.Size(137, 22)
			Me.button4.TabIndex = 3
			Me.button4.Text = "Clear Bookmarks"
'			Me.button4.Click += New System.EventHandler(Me.BookmarkOptionsButtons_Click);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			' 
			' button3
			' 
			Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.button3.ImageIndex = 2
			Me.button3.ImageList = Me.imageList1
			Me.button3.Location = New System.Drawing.Point(8, 88)
			Me.button3.Name = "button3"
			Me.button3.Size = New System.Drawing.Size(137, 22)
			Me.button3.TabIndex = 2
			Me.button3.Text = "Previous Bookmark"
'			Me.button3.Click += New System.EventHandler(Me.BookmarkOptionsButtons_Click);
			' 
			' button2
			' 
			Me.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.button2.ImageIndex = 1
			Me.button2.ImageList = Me.imageList1
			Me.button2.Location = New System.Drawing.Point(8, 56)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(137, 22)
			Me.button2.TabIndex = 1
			Me.button2.Text = "Next Bookmark"
'			Me.button2.Click += New System.EventHandler(Me.BookmarkOptionsButtons_Click);
			' 
			' button1
			' 
			Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.button1.ImageIndex = 0
			Me.button1.ImageList = Me.imageList1
			Me.button1.Location = New System.Drawing.Point(8, 24)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(137, 22)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Add Bookmark"
'			Me.button1.Click += New System.EventHandler(Me.BookmarkOptionsButtons_Click);
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.radioButton4)
			Me.groupBox2.Controls.Add(Me.radioButton3)
			Me.groupBox2.Controls.Add(Me.radioButton2)
			Me.groupBox2.Controls.Add(Me.radioButton1)
			Me.groupBox2.Controls.Add(Me.pictureBox4)
			Me.groupBox2.Controls.Add(Me.pictureBox3)
			Me.groupBox2.Controls.Add(Me.pictureBox2)
			Me.groupBox2.Controls.Add(Me.pictureBox1)
			Me.groupBox2.Location = New System.Drawing.Point(12, 26)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(163, 152)
			Me.groupBox2.TabIndex = 0
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Custom Indicators"
			' 
			' radioButton4
			' 
			Me.radioButton4.Location = New System.Drawing.Point(32, 115)
			Me.radioButton4.Name = "radioButton4"
			Me.radioButton4.Size = New System.Drawing.Size(120, 24)
			Me.radioButton4.TabIndex = 7
			Me.radioButton4.Text = "Custom Indicator4"
'			Me.radioButton4.CheckedChanged += New System.EventHandler(Me.RadioCustomIndicator_Changed);
			' 
			' radioButton3
			' 
			Me.radioButton3.Location = New System.Drawing.Point(32, 84)
			Me.radioButton3.Name = "radioButton3"
			Me.radioButton3.Size = New System.Drawing.Size(120, 24)
			Me.radioButton3.TabIndex = 6
			Me.radioButton3.Text = "Custom Indicator3"
'			Me.radioButton3.CheckedChanged += New System.EventHandler(Me.RadioCustomIndicator_Changed);
			' 
			' radioButton2
			' 
			Me.radioButton2.Location = New System.Drawing.Point(32, 51)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.Size = New System.Drawing.Size(120, 24)
			Me.radioButton2.TabIndex = 5
			Me.radioButton2.Text = "Custom Indicator2"
'			Me.radioButton2.CheckedChanged += New System.EventHandler(Me.RadioCustomIndicator_Changed);
			' 
			' radioButton1
			' 
			Me.radioButton1.Checked = True
			Me.radioButton1.Location = New System.Drawing.Point(32, 19)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.Size = New System.Drawing.Size(120, 24)
			Me.radioButton1.TabIndex = 4
			Me.radioButton1.TabStop = True
			Me.radioButton1.Text = "Custom Indicator1"
'			Me.radioButton1.CheckedChanged += New System.EventHandler(Me.RadioCustomIndicator_Changed);
			' 
			' pictureBox4
			' 
			Me.pictureBox4.Location = New System.Drawing.Point(8, 118)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New System.Drawing.Size(18, 18)
			Me.pictureBox4.TabIndex = 3
			Me.pictureBox4.TabStop = False
			' 
			' pictureBox3
			' 
			Me.pictureBox3.Location = New System.Drawing.Point(8, 86)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New System.Drawing.Size(18, 18)
			Me.pictureBox3.TabIndex = 2
			Me.pictureBox3.TabStop = False
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Location = New System.Drawing.Point(8, 54)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(18, 18)
			Me.pictureBox2.TabIndex = 1
			Me.pictureBox2.TabStop = False
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Location = New System.Drawing.Point(8, 22)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(18, 18)
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' menuStrip1
			' 
			Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.fileToolStripMenuItem})
			Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
			Me.menuStrip1.Name = "menuStrip1"
			Me.menuStrip1.Size = New System.Drawing.Size(542, 24)
			Me.menuStrip1.TabIndex = 2
			Me.menuStrip1.Text = "menuStrip1"
			' 
			' fileToolStripMenuItem
			' 
			Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator1, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator2, Me.closeToolStripMenuItem, Me.exitToolStripMenuItem})
			Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
			Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
			Me.fileToolStripMenuItem.Text = "&File"
			' 
			' newToolStripMenuItem
			' 
			Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
			Me.newToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.newToolStripMenuItem.Text = "&New"
'			Me.newToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' openToolStripMenuItem
			' 
			Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
			Me.openToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.openToolStripMenuItem.Text = "&Open..."
'			Me.openToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(149, 6)
			' 
			' saveToolStripMenuItem
			' 
			Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
			Me.saveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.saveToolStripMenuItem.Text = "&Save"
'			Me.saveToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' saveAsToolStripMenuItem
			' 
			Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
			Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.saveAsToolStripMenuItem.Text = "Save &As..."
'			Me.saveAsToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(149, 6)
			' 
			' closeToolStripMenuItem
			' 
			Me.closeToolStripMenuItem.Name = "closeToolStripMenuItem"
			Me.closeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.closeToolStripMenuItem.Text = "&Close"
'			Me.closeToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' exitToolStripMenuItem
			' 
			Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
			Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
			Me.exitToolStripMenuItem.Text = "E&xit"
'			Me.exitToolStripMenuItem.Click += New System.EventHandler(Me.MainMenuClick);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(542, 439)
			Me.Controls.Add(Me.editControl1)
			Me.Controls.Add(Me.groupBox1)
			Me.Controls.Add(Me.menuStrip1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
            Me.Text = "Custom Bookmarks"
            Me.StartPosition = FormStartPosition.CenterScreen
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.menuStrip1.ResumeLayout(False)
			Me.menuStrip1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
Application.EnableVisualStyles()
			Application.Run(New Form1())
		End Sub

		Private Sub MainMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles newToolStripMenuItem.Click, openToolStripMenuItem.Click, saveToolStripMenuItem.Click, saveAsToolStripMenuItem.Click, closeToolStripMenuItem.Click, exitToolStripMenuItem.Click
			Dim mi As ToolStripMenuItem = TryCast(sender, ToolStripMenuItem)

			Select Case mi.Text
				Case "&New" 
					Me.editControl1.NewFile()
				Case "&Open..." 
					Me.editControl1.LoadFile()
				Case "&Save" 
					Me.editControl1.Save()
				Case "Save &As..." 
					Me.editControl1.SaveAs()
				Case "&Close" 
					Me.editControl1.Close()
				Case "E&xit" 
					Me.Close()
			End Select
		End Sub

		Private Sub CustomBookmarkPainter1(ByVal sender As Object, ByVal args As BookmarkPaintEventArgs)
			args.Graphics.DrawImage(image1, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16)
		End Sub

		Private Sub CustomBookmarkPainter2(ByVal sender As Object, ByVal args As BookmarkPaintEventArgs)
			args.Graphics.DrawImage(image2, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16)
		End Sub

		Private Sub CustomBookmarkPainter3(ByVal sender As Object, ByVal args As BookmarkPaintEventArgs)
			args.Graphics.DrawImage(image3, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16)
		End Sub

		Private Sub CustomBookmarkPainter4(ByVal sender As Object, ByVal args As BookmarkPaintEventArgs)
			args.Graphics.DrawImage(image4, args.ClipRectangle.Left, args.ClipRectangle.Top, 16, 16)
		End Sub

		Private Sub RadioCustomIndicator_Changed(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioButton4.CheckedChanged, radioButton3.CheckedChanged, radioButton2.CheckedChanged, radioButton1.CheckedChanged
			Dim rb As RadioButton = TryCast(sender, RadioButton)

		   Select Case rb.Text
				Case "Custom Indicator1"
				   Me.selectedImage = image1
				Case "Custom Indicator2"
				   Me.selectedImage = image2
			   Case "Custom Indicator3"
				   Me.selectedImage = image3
			   Case "Custom Indicator4"
				   Me.selectedImage = image4
		   End Select
		End Sub

		Private Sub BookmarkOptionsButtons_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button5.Click, button6.Click, button4.Click, button3.Click, button2.Click, button1.Click
			Dim btn As Button = TryCast(sender, Button)

			Select Case btn.Text
				Case "Set Custom Indicator" 
					If Me.selectedImage Is image1 Then
						Dim bookmark1 As ICustomBookmark = Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, New BookmarkPaintEventHandler(AddressOf CustomBookmarkPainter1))
						bookmark1.UseInBookmarkSearch = True

					ElseIf Me.selectedImage Is image2 Then
						Dim bookmark2 As ICustomBookmark = Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, New BookmarkPaintEventHandler(AddressOf CustomBookmarkPainter2))
						bookmark2.UseInBookmarkSearch = True

					ElseIf Me.selectedImage Is image3 Then
						Dim bookmark3 As ICustomBookmark = Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, New BookmarkPaintEventHandler(AddressOf CustomBookmarkPainter3))
						bookmark3.UseInBookmarkSearch = True

					ElseIf Me.selectedImage Is image4 Then
						Dim bookmark4 As ICustomBookmark = Me.editControl1.SetCustomBookmark(Me.editControl1.CurrentLine, New BookmarkPaintEventHandler(AddressOf CustomBookmarkPainter4))
						bookmark4.UseInBookmarkSearch = True
					End If
					Me.editControl1.Refresh()

				Case "Add Bookmark" 
					Me.editControl1.BookmarkAdd(Me.editControl1.CurrentLine)

				Case "Toggle Bookmark" 
					Me.editControl1.BookmarkToggle()
					Me.editControl1.Refresh()

				Case "Clear Bookmarks" 
					Me.editControl1.BookmarkClear(True)
					Me.editControl1.Refresh()

				Case "Previous Bookmark" 
					Me.editControl1.BookmarkPrevious()

				Case "Next Bookmark" 
					Me.editControl1.BookmarkNext()
			End Select
			Me.editControl1.Focus()
		End Sub


	End Class
End Namespace
