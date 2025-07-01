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
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace TaskBar
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		#Region "Private Members"
		Private xpTaskBar1 As TaskBar.GradientTaskBar
		Private WithEvents xpTaskBarBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private xpTaskBarBox2 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private label1 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private tabControlAdv1 As TabControlAdv
		Private tabPageAdv1 As TabPageAdv
		Private tabPageAdv2 As TabPageAdv
		Private xpTaskBarStyles As XPTaskBar
		Private WithEvents xpTaskBarBox3 As StyleTaskBox
		Private WithEvents xpTaskBarBox4 As StyleTaskBox
		Private WithEvents xpTaskBarBox5 As StyleTaskBox
		Private label2 As Label
		Private components As System.ComponentModel.IContainer
#End Region

		#Region "Form's constructor, Main and Dispose"
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
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
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
		#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.xpTaskBar1 = New TaskBar.GradientTaskBar(Me.components)
			Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.xpTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.label2 = New System.Windows.Forms.Label()
			Me.xpTaskBarStyles = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox3 = New TaskBar.StyleTaskBox()
			Me.xpTaskBarBox4 = New TaskBar.StyleTaskBox()
			Me.xpTaskBarBox5 = New TaskBar.StyleTaskBox()
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar1.SuspendLayout()
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControlAdv1.SuspendLayout()
			Me.tabPageAdv1.SuspendLayout()
			Me.tabPageAdv2.SuspendLayout()
			CType(Me.xpTaskBarStyles, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBarStyles.SuspendLayout()
			Me.SuspendLayout()
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList2.Images.SetKeyName(0, "")
			Me.imageList2.Images.SetKeyName(1, "")
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			' 
			' xpTaskBar1
			' 
			Me.xpTaskBar1.AutoScroll = True
			Me.xpTaskBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(42))))), (CInt(Fix((CByte(78))))), (CInt(Fix((CByte(129))))))
			Me.xpTaskBar1.BlendImage = (CType(resources.GetObject("xpTaskBar1.BlendImage"), System.Drawing.Image))
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox1)
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox2)
			Me.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Right
			Me.xpTaskBar1.GradientEndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(42))))), (CInt(Fix((CByte(78))))), (CInt(Fix((CByte(129))))))
			Me.xpTaskBar1.GradientStartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(237))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(242))))))
			Me.xpTaskBar1.HeaderImageList = Me.imageList2
			Me.xpTaskBar1.Location = New System.Drawing.Point(269, 0)
			Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar1.Name = "xpTaskBar1"
			Me.xpTaskBar1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 0)
			Me.xpTaskBar1.Size = New System.Drawing.Size(181, 413)
			Me.xpTaskBar1.TabIndex = 0
			' 
			' xpTaskBarBox1
			' 
			Me.xpTaskBarBox1.BackColor = System.Drawing.Color.Transparent
			Me.xpTaskBarBox1.DrawFocusRect = False
			Me.xpTaskBarBox1.FocusOnClick = False
			Me.xpTaskBarBox1.ForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.Transparent
			Me.xpTaskBarBox1.HeaderForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox1.HeaderImageIndex = 0
			Me.xpTaskBarBox1.HeaderImageList = Me.imageList2
			Me.xpTaskBarBox1.HitTaskBoxArea = False
			Me.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(241))))))
			Me.xpTaskBarBox1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 1", System.Drawing.Color.Black, -1, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item2", System.Drawing.Color.Black, -1, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 3", System.Drawing.Color.Black, -1, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 4", System.Drawing.Color.Black, -1, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 5", System.Drawing.Color.Black, -1, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Item 6", System.Drawing.Color.Black, -1, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)})
			Me.xpTaskBarBox1.Location = New System.Drawing.Point(10, 5)
			Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
			Me.xpTaskBarBox1.Size = New System.Drawing.Size(161, 167)
			Me.xpTaskBarBox1.TabIndex = 0
			Me.xpTaskBarBox1.Text = "Tasks"
'			Me.xpTaskBarBox1.ProvideHeaderBackgroundBrush += New Syncfusion.Windows.Forms.Tools.ProvideBrushEventHandler(Me.xpTaskBarBox1_ProvideHeaderBackgroundBrush);
			' 
			' xpTaskBarBox2
			' 
			Me.xpTaskBarBox2.BackColor = System.Drawing.Color.Transparent
			Me.xpTaskBarBox2.ForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.Transparent
			Me.xpTaskBarBox2.HeaderForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox2.HeaderImageIndex = 1
			Me.xpTaskBarBox2.HitTaskBoxArea = False
			Me.xpTaskBarBox2.ImageList = Me.imageList1
			Me.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.Transparent
			Me.xpTaskBarBox2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Canada", System.Drawing.Color.Empty, 0, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("France", System.Drawing.Color.Empty, 1, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Germany", System.Drawing.Color.Empty, 2, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("UK", System.Drawing.Color.Empty, 3, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("USA", System.Drawing.Color.Empty, 4, Nothing, Nothing, True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)})
			Me.xpTaskBarBox2.Location = New System.Drawing.Point(10, 172)
			Me.xpTaskBarBox2.Name = "xpTaskBarBox2"
			Me.xpTaskBarBox2.Size = New System.Drawing.Size(161, 152)
			Me.xpTaskBarBox2.TabIndex = 1
			Me.xpTaskBarBox2.Text = "Countries..."
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label1.Font = New System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(196))))), (CInt(Fix((CByte(250))))))
			Me.label1.Location = New System.Drawing.Point(0, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(269, 413)
			Me.label1.TabIndex = 1
			Me.label1.Text = "MSN like TaskBar"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' tabControlAdv1
			' 
			Me.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
			Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
			Me.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
			Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(141))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(227))))))
			Me.tabControlAdv1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.tabControlAdv1.Location = New System.Drawing.Point(0, 0)
			Me.tabControlAdv1.Name = "tabControlAdv1"
			Me.tabControlAdv1.Size = New System.Drawing.Size(456, 447)
			Me.tabControlAdv1.TabGap = 10
			Me.tabControlAdv1.TabIndex = 2
			Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(182))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(246))))))
			Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
			Me.tabControlAdv1.ThemesEnabled = True
			' 
			' tabPageAdv1
			' 
			Me.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
			Me.tabPageAdv1.Controls.Add(Me.label1)
			Me.tabPageAdv1.Controls.Add(Me.xpTaskBar1)
			Me.tabPageAdv1.Location = New System.Drawing.Point(3, 31)
			Me.tabPageAdv1.Name = "tabPageAdv1"
			Me.tabPageAdv1.Size = New System.Drawing.Size(450, 413)
			Me.tabPageAdv1.TabIndex = 1
			Me.tabPageAdv1.Text = "MSN TaskBar"
			Me.tabPageAdv1.ThemesEnabled = False
			' 
			' tabPageAdv2
			' 
			Me.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(248))))))
			Me.tabPageAdv2.Controls.Add(Me.label2)
			Me.tabPageAdv2.Controls.Add(Me.xpTaskBarStyles)
			Me.tabPageAdv2.Location = New System.Drawing.Point(3, 31)
			Me.tabPageAdv2.Name = "tabPageAdv2"
			Me.tabPageAdv2.Size = New System.Drawing.Size(450, 413)
			Me.tabPageAdv2.TabIndex = 2
			Me.tabPageAdv2.Text = "Custom TaskBar"
			Me.tabPageAdv2.ThemesEnabled = False
			' 
			' label2
			' 
			Me.label2.BackColor = System.Drawing.Color.Transparent
			Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label2.Font = New System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(196))))), (CInt(Fix((CByte(250))))))
			Me.label2.Location = New System.Drawing.Point(184, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(266, 413)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Custom TaskBar "
			Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' xpTaskBarStyles
			' 
			Me.xpTaskBarStyles.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(125))))), (CInt(Fix((CByte(153))))), (CInt(Fix((CByte(218))))))
			Me.xpTaskBarStyles.Controls.Add(Me.xpTaskBarBox3)
			Me.xpTaskBarStyles.Controls.Add(Me.xpTaskBarBox4)
			Me.xpTaskBarStyles.Controls.Add(Me.xpTaskBarBox5)
			Me.xpTaskBarStyles.Dock = System.Windows.Forms.DockStyle.Left
			Me.xpTaskBarStyles.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarStyles.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBarStyles.Name = "xpTaskBarStyles"
			Me.xpTaskBarStyles.Padding = New System.Windows.Forms.Padding(10, 15, 10, 0)
			Me.xpTaskBarStyles.Size = New System.Drawing.Size(184, 413)
			Me.xpTaskBarStyles.TabIndex = 3
			Me.xpTaskBarStyles.VerticalPadding = 15
			' 
			' xpTaskBarBox3
			' 
			Me.xpTaskBarBox3.DrawFocusRect = False
			Me.xpTaskBarBox3.FocusOnClick = False
			Me.xpTaskBarBox3.HeaderBackColor = System.Drawing.SystemColors.Control
			Me.xpTaskBarBox3.HeaderImageIndex = -1
			Me.xpTaskBarBox3.HitTaskBoxArea = False
			Me.xpTaskBarBox3.ItemBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(215))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(242))))))
			Me.xpTaskBarBox3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Make a New Folder", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem0", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Publish this Folder to the web", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem1", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Copy", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem6", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Paste", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem7", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)})
			Me.xpTaskBarBox3.Location = New System.Drawing.Point(10, 15)
			Me.xpTaskBarBox3.Name = "xpTaskBarBox3"
			Me.xpTaskBarBox3.Size = New System.Drawing.Size(164, 111)
			Me.xpTaskBarBox3.TabIndex = 0
			Me.xpTaskBarBox3.Text = "Files And Folder Task"
'			Me.xpTaskBarBox3.Paint += New System.Windows.Forms.PaintEventHandler(Me.xpTaskBarBox_Paint);
			' 
			' xpTaskBarBox4
			' 
			Me.xpTaskBarBox4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(215))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(242))))))
			Me.xpTaskBarBox4.DrawFocusRect = False
			Me.xpTaskBarBox4.FocusOnClick = False
			Me.xpTaskBarBox4.HeaderBackColor = System.Drawing.SystemColors.Control
			Me.xpTaskBarBox4.HeaderImageIndex = -1
			Me.xpTaskBarBox4.HitTaskBoxArea = False
			Me.xpTaskBarBox4.ItemBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(215))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(242))))))
			Me.xpTaskBarBox4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("My Documents", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem2", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Desktop", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem5", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("My Computer", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem8", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("My Network Places", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem9", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("My Music", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem10", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)})
			Me.xpTaskBarBox4.Location = New System.Drawing.Point(10, 141)
			Me.xpTaskBarBox4.Name = "xpTaskBarBox4"
			Me.xpTaskBarBox4.Size = New System.Drawing.Size(164, 131)
			Me.xpTaskBarBox4.TabIndex = 1
			Me.xpTaskBarBox4.Text = "Other Places"
'			Me.xpTaskBarBox4.Paint += New System.Windows.Forms.PaintEventHandler(Me.xpTaskBarBox_Paint);
			' 
			' xpTaskBarBox5
			' 
			Me.xpTaskBarBox5.DrawFocusRect = False
			Me.xpTaskBarBox5.FocusOnClick = False
			Me.xpTaskBarBox5.HeaderBackColor = System.Drawing.SystemColors.Control
			Me.xpTaskBarBox5.HeaderImageIndex = -1
			Me.xpTaskBarBox5.HitTaskBoxArea = False
			Me.xpTaskBarBox5.ItemBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(215))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(242))))))
			Me.xpTaskBarBox5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Cut", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem3", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Copy", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem4", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Paste", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem11", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Delete", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem12", New System.Drawing.Font("Microsoft Sans Serif", 8.25F), 0)})
			Me.xpTaskBarBox5.Location = New System.Drawing.Point(10, 287)
			Me.xpTaskBarBox5.Name = "xpTaskBarBox5"
			Me.xpTaskBarBox5.Size = New System.Drawing.Size(164, 111)
			Me.xpTaskBarBox5.TabIndex = 2
			Me.xpTaskBarBox5.Text = "ClipBoard"
'			Me.xpTaskBarBox5.Paint += New System.Windows.Forms.PaintEventHandler(Me.xpTaskBarBox_Paint);
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(182))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(246))))))
			Me.ClientSize = New System.Drawing.Size(456, 447)
			Me.Controls.Add(Me.tabControlAdv1)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Custom TaskBar"
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar1.ResumeLayout(False)
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControlAdv1.ResumeLayout(False)
			Me.tabPageAdv1.ResumeLayout(False)
			Me.tabPageAdv2.ResumeLayout(False)
			CType(Me.xpTaskBarStyles, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBarStyles.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "Events"
		Private Sub xpTaskBarBox1_ProvideHeaderBackgroundBrush(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.ProvideBrushEventArgs) Handles xpTaskBarBox1.ProvideHeaderBackgroundBrush
			' Custom draw the background only when XP Themes is not available.
			If (Not XPThemes.IsThemedOS) OrElse (Not XPThemes.IsThemeActive) OrElse (Not Me.xpTaskBar1.ThemesEnabled) Then
				' Blend settings
				Dim relativeIntensities As Single() = { 0.0f, 0.0f, 1.0f }
				Dim relativePositions As Single() = { 0.0F, 0.5f, 1.0F }
				Dim blend As Blend = New Blend()
				blend.Factors = relativeIntensities
				blend.Positions = relativePositions

				Dim box As XPTaskBarBox = TryCast(sender, XPTaskBarBox)

				' Header back brush
				Dim lgBrush As LinearGradientBrush = New LinearGradientBrush(args.Bounds, Color.FromArgb(132, 164, 193), Color.FromArgb(46, 116, 163), 0, True)
				lgBrush.Blend = blend
				args.Brush = lgBrush
			End If
		End Sub


		Private Sub xpTaskBarBox_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles xpTaskBarBox3.Paint, xpTaskBarBox4.Paint, xpTaskBarBox5.Paint
			Dim xptBox As XPTaskBarBox = TryCast(sender, XPTaskBarBox)
			Dim itemsRect As Rectangle = xptBox.GetItemsRect()
			itemsRect.Width -= 1
			itemsRect.Height -= 1
			e.Graphics.DrawRectangle(New Pen(Color.FromArgb(113, 137, 183), 3), itemsRect)

		End Sub
		#End Region

	End Class
End Namespace
