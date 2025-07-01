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
	Imports Syncfusion.Windows.Forms.Tools
Namespace SplashControlDemo

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class MainForm : Inherits System.Windows.Forms.Form
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private imageList1 As System.Windows.Forms.ImageList
		Private components As System.ComponentModel.IContainer
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private menuItem1 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem2 As System.Windows.Forms.MenuItem
		Private menuItem3 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Friend textBox5 As System.Windows.Forms.TextBox
		Private WithEvents button6 As System.Windows.Forms.Button
		Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private imageList2 As System.Windows.Forms.ImageList
		Public WithEvents splashControl1 As Syncfusion.Windows.Forms.Tools.SplashControl


		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		Private Sub SplashClosedHandler(ByVal sender As Object, ByVal e As EventArgs)

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
			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.splashControl1 = New Syncfusion.Windows.Forms.Tools.SplashControl()
			Me.mainMenu1 = New System.Windows.Forms.MainMenu()
			Me.menuItem1 = New System.Windows.Forms.MenuItem()
			Me.menuItem2 = New System.Windows.Forms.MenuItem()
			Me.menuItem3 = New System.Windows.Forms.MenuItem()
			Me.menuItem4 = New System.Windows.Forms.MenuItem()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.textBox5 = New System.Windows.Forms.TextBox()
			Me.button6 = New System.Windows.Forms.Button()
			Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControlAdv1.SuspendLayout()
			Me.tabPageAdv1.SuspendLayout()
			Me.tabPageAdv2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
			Me.imageList1.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			' 
			' splashControl1
			' 
			Me.splashControl1.CustomSplashPanel = Nothing
			Me.splashControl1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.RightBottom
			Me.splashControl1.HostForm = Me
			Me.splashControl1.HostFormWindowState = System.Windows.Forms.FormWindowState.Normal
			Me.splashControl1.SplashImage = (CType(resources.GetObject("splashControl1.SplashImage"), System.Drawing.Bitmap))
			Me.splashControl1.TimerInterval = 3000
			Me.splashControl1.UseCustomSplashPanel = True
'			Me.splashControl1.SplashDisplayed += New System.EventHandler(Me.splashControl1_SplashDisplayed);
'			Me.splashControl1.BeforeSplash += New System.ComponentModel.CancelEventHandler(Me.splashControl1_BeforeSplash);
'			Me.splashControl1.SplashClosed += New System.EventHandler(Me.splashControl1_SplashClosed);
			' 
			' mainMenu1
			' 
			Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem1, Me.menuItem3})
			' 
			' menuItem1
			' 
			Me.menuItem1.Index = 0
			Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem2})
			Me.menuItem1.Text = "File"
			' 
			' menuItem2
			' 
			Me.menuItem2.Index = 0
			Me.menuItem2.Text = "&Exit"
'			Me.menuItem2.Click += New System.EventHandler(Me.menuItem2_Click);
			' 
			' menuItem3
			' 
			Me.menuItem3.Index = 1
			Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() { Me.menuItem4})
			Me.menuItem3.Text = "Help"
			' 
			' menuItem4
			' 
			Me.menuItem4.Index = 0
			Me.menuItem4.Text = "About..."
'			Me.menuItem4.Click += New System.EventHandler(Me.menuItem4_Click);
			' 
			' pictureBox1
			' 
			Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Bitmap))
			Me.pictureBox1.Location = New System.Drawing.Point(56, 8)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(450, 250)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.pictureBox1.TabIndex = 5
			Me.pictureBox1.TabStop = False
			' 
			' textBox5
			' 
			Me.textBox5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.textBox5.ForeColor = System.Drawing.Color.FromArgb((CByte(103)), (CByte(110)), (CByte(154)))
			Me.textBox5.Multiline = True
			Me.textBox5.Name = "textBox5"
			Me.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
			Me.textBox5.Size = New System.Drawing.Size(549, 344)
			Me.textBox5.TabIndex = 4
			Me.textBox5.Text = ""
			' 
			' button6
			' 
			Me.button6.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
			Me.button6.ImageIndex = 2
			Me.button6.Location = New System.Drawing.Point(184, 264)
			Me.button6.Name = "button6"
			Me.button6.Size = New System.Drawing.Size(192, 40)
			Me.button6.TabIndex = 4
			Me.button6.Text = "Click to Show Splash Screen"
'			Me.button6.Click += New System.EventHandler(Me.button6_Click);
			' 
			' tabControlAdv1
			' 
			Me.tabControlAdv1.Controls.AddRange(New System.Windows.Forms.Control() { Me.tabPageAdv1, Me.tabPageAdv2})
			Me.tabControlAdv1.ImageList = Me.imageList2
			Me.tabControlAdv1.Location = New System.Drawing.Point(0, 8)
			Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Size = New System.Drawing.Size(552, 376)
            Me.tabControlAdv1.TabIndex = 6
			Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb((CByte(103)), (CByte(110)), (CByte(154)))
			Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererDockingWhidbey)
			' 
			' tabPageAdv1
			' 
			Me.tabPageAdv1.Controls.AddRange(New System.Windows.Forms.Control() { Me.pictureBox1, Me.button6})
			Me.tabPageAdv1.ImageIndex = 0
			Me.tabPageAdv1.Location = New System.Drawing.Point(1, 30)
			Me.tabPageAdv1.Name = "tabPageAdv1"
			Me.tabPageAdv1.Size = New System.Drawing.Size(549, 344)
			Me.tabPageAdv1.TabIndex = 0
			Me.tabPageAdv1.Text = "Show Splash"
			Me.tabPageAdv1.ThemesEnabled = False
			' 
			' tabPageAdv2
			' 
			Me.tabPageAdv2.Controls.AddRange(New System.Windows.Forms.Control() { Me.textBox5})
			Me.tabPageAdv2.ImageIndex = 1
			Me.tabPageAdv2.Location = New System.Drawing.Point(1, 30)
			Me.tabPageAdv2.Name = "tabPageAdv2"
			Me.tabPageAdv2.Size = New System.Drawing.Size(549, 344)
			Me.tabPageAdv2.TabIndex = 1
			Me.tabPageAdv2.Text = "EventLog"
			Me.tabPageAdv2.ThemesEnabled = False
			' 
			' imageList2
			' 
			Me.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
			Me.imageList2.ImageSize = New System.Drawing.Size(16, 16)
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
			' 
			' MainForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CByte(192)), (CByte(200)), (CByte(219)))
			Me.ClientSize = New System.Drawing.Size(552, 347)
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.tabControlAdv1})
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Menu = Me.mainMenu1
			Me.Name = "MainForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = " Splash Control"
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControlAdv1.ResumeLayout(False)
			Me.tabPageAdv1.ResumeLayout(False)
			Me.tabPageAdv2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Dim frmMain As MainForm = New MainForm()
			Application.Run(frmMain)
		End Sub
		#Region "ShowSplash"
		Private Sub button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button6.Click
			Me.splashControl1.ShowSplash(False)
		End Sub
		#End Region
		#Region "samplecodeblock"
		Protected Sub CodeGen_InitializeComponent()
			' <samplecodeblock name="SplashControl InitializeComponent">
			' InitializeComponent

			Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))

			' Create the splash control
			Me.splashControl1 = New SplashControl()

			' Setting AutoMode to true will automatically launch
			' splash screen - no additional code is required
			Me.splashControl1.AutoMode = True

			' The start position for the splash screen
			Me.splashControl1.DesktopAlignment = Syncfusion.Windows.Forms.Tools.SplashAlignment.Center

			' The host form for the splash control
			Me.splashControl1.HostForm = Me

			' Specifies if the splash screen should appear animated
			Me.splashControl1.ShowAnimation = False

			' The Splash image - specified through the designer
			Me.splashControl1.SplashImage = (CType(resources.GetObject("splashControl1.SplashImage"), System.Drawing.Bitmap))

			' The time period for which the splash should appear
			Me.splashControl1.TimerInterval = 3000
			'</samplecodeblock>
		End Sub

		#End Region
		#Region "Exit"
		Private Sub menuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem2.Click
			Application.Exit()
		End Sub
		#End Region
		#Region "SplashClosed"
		'<samplecodeblock name="SplashControl SplashClosed event.">
		Private Sub splashControl1_SplashClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles splashControl1.SplashClosed
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashClosed", sender.ToString())
			textBox5.Text = textBox5.Text & eventlogmessage

		End Sub
		#End Region
		'</samplecodeblock>
		#Region "SplashControlAboutForm"
		Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click
            Dim ab As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies)
            ab.ShowDialog()

		End Sub
		#End Region
		#Region "BeforeSplash"
		Private Sub splashControl1_BeforeSplash(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles splashControl1.BeforeSplash
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "BeforeSplash", sender.ToString())
			textBox5.Text = textBox5.Text & eventlogmessage

		End Sub
		#End Region
		#Region "SplashDisplayed"
		Private Sub splashControl1_SplashDisplayed(ByVal sender As Object, ByVal e As System.EventArgs) Handles splashControl1.SplashDisplayed
			Dim eventlogmessage As String = String.Format("Event: {0} Object: {1}" & Constants.vbCrLf, "SplashDisplayed", sender.ToString())
			textBox5.Text = textBox5.Text & eventlogmessage
		End Sub
		#End Region


	End Class
End Namespace
