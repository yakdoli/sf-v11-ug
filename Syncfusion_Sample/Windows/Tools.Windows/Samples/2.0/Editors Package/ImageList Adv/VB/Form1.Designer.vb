Imports Microsoft.VisualBasic
Imports System
Namespace ImageListAdv_Demo
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
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
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim treeNodeAdvStyleInfo1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
			Dim treeNodeAdv1 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv2 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv3 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv4 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdvStyleInfo2 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
			Dim treeNodeAdv5 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv6 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv7 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv8 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdvStyleInfo3 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
			Dim treeNodeAdvStyleInfo4 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
			Dim treeNodeAdvStyleInfo5 As Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo = New Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo()
			Dim treeNodeAdv9 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv10 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv11 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv12 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv13 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv14 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Dim treeNodeAdv15 As Syncfusion.Windows.Forms.Tools.TreeNodeAdv = New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.xpToolBar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.xpToolBar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv5 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabControlAdv2 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv4 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabPageAdv6 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.tabControlAdv3 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageAdv12 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.gradientLabel8 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel7 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.label13 = New System.Windows.Forms.Label()
			Me.label14 = New System.Windows.Forms.Label()
			Me.label15 = New System.Windows.Forms.Label()
			Me.tabPageAdv9 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label16 = New System.Windows.Forms.Label()
			Me.label17 = New System.Windows.Forms.Label()
			Me.groupBar2 = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.groupBarItem5 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem6 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.groupBarItem1 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.gradientLabel10 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel9 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.tabPageAdv10 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.gradientLabel6 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.label12 = New System.Windows.Forms.Label()
			Me.gradientLabel3 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.tabPageAdv8 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.treeViewAdv2 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
			Me.gradientLabel13 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.treeViewAdv3 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
			Me.tabPageAdv11 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.gradientLabel5 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel4 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.tabPageAdv13 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.trackBarEx1 = New Syncfusion.Windows.Forms.Tools.TrackBarEx()
			Me.gradientLabel19 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.gradientLabel12 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label18 = New System.Windows.Forms.Label()
			Me.label19 = New System.Windows.Forms.Label()
			Me.trackBarEx2 = New Syncfusion.Windows.Forms.Tools.TrackBarEx()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.gradientLabel2 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.label46 = New System.Windows.Forms.Label()
			Me.label58 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
			Me.dockingUserControl1 = New ImageListAdv_Demo.Docking1()
			Me.dockingUserControl2 = New ImageListAdv_Demo.Docking2()
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControlAdv1.SuspendLayout()
			CType(Me.tabControlAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControlAdv2.SuspendLayout()
			CType(Me.tabControlAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControlAdv3.SuspendLayout()
			Me.tabPageAdv12.SuspendLayout()
			Me.tabPageAdv9.SuspendLayout()
			CType(Me.groupBar2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabPageAdv10.SuspendLayout()
			Me.tabPageAdv8.SuspendLayout()
			CType(Me.treeViewAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeViewAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabPageAdv11.SuspendLayout()
			Me.tabPageAdv13.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "cut.png")
			Me.imageList1.Images.SetKeyName(1, "copy.png")
			Me.imageList1.Images.SetKeyName(2, "paste.png")
			Me.imageList1.Images.SetKeyName(3, "photo_scenery.png")
			Me.imageList1.Images.SetKeyName(4, "desktop.png")
			Me.imageList1.Images.SetKeyName(5, "data_certificate.png")
			Me.imageList1.Images.SetKeyName(6, "panels_new3_autohide1.png")
			Me.imageList1.Images.SetKeyName(7, "Gif.gif")
			Me.imageList1.Images.SetKeyName(8, "png.png")
			Me.imageList1.Images.SetKeyName(9, "bmp.bmp")
			Me.imageList1.Images.SetKeyName(10, "ico.ICO")
			Me.imageList1.Images.SetKeyName(11, "pin_green(1).jpg")
			Me.imageList1.Images.SetKeyName(12, "pin_red.png")
			Me.imageList1.Images.SetKeyName(13, "pin_yellow.png")
			Me.imageList1.Images.SetKeyName(14, "pin_blue.png")
			Me.imageList1.Images.SetKeyName(15, "msn.png")
			Me.imageList1.Images.SetKeyName(16, "ie.ico")
			Me.imageList1.Images.SetKeyName(17, "undo.png")
			Me.imageList1.Images.SetKeyName(18, "redo.png")
			Me.imageList1.Images.SetKeyName(19, "help2.png")
			Me.imageList1.Images.SetKeyName(20, "view.png")
			Me.imageList1.Images.SetKeyName(21, "colors.png")
			Me.imageList1.Images.SetKeyName(22, "form_red.png")
			Me.imageList1.Images.SetKeyName(23, "clipboard.png")
			Me.imageList1.Images.SetKeyName(24, "folder.png")
			Me.imageList1.Images.SetKeyName(25, "navigate_right2.png")
			Me.imageList1.Images.SetKeyName(26, "navigate_down2.png")
			Me.imageList1.Images.SetKeyName(27, "star_red.png")
			Me.imageList1.Images.SetKeyName(28, "star_green.png")
			Me.imageList1.Images.SetKeyName(29, "star_blue.png")
			Me.imageList1.Images.SetKeyName(30, "contract.png")
			Me.imageList1.Images.SetKeyName(31, "file_bmp.jpg")
			Me.imageList1.Images.SetKeyName(32, "file_gif.jpg")
			Me.imageList1.Images.SetKeyName(33, "file_jpg.jpg")
			Me.imageList1.Images.SetKeyName(34, "file_png.jpg")
			' 
			' imageListAdv1
			' 
			Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() { (CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images2"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images3"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images4"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images5"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images6"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images7"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images8"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images9"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images10"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images11"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images12"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images13"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images14"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images15"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images16"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images17"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images18"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images19"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images20"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images21"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images22"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images23"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images24"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images25"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images26"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images27"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images28"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images29"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images30"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images31"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images32"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images33"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images34"), System.Drawing.Image))})
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP
			Me.buttonAdv2.Location = New System.Drawing.Point(67, 51)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Size = New System.Drawing.Size(83, 43)
			Me.buttonAdv2.TabIndex = 6
			Me.buttonAdv2.Text = "ButtonAdv"
			Me.buttonAdv2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.buttonAdv2.UseVisualStyle = True
			' 
			' xpToolBar1
			' 
			' 
			' 
			' 
			Me.xpToolBar1.Bar.BarName = ""
			Me.xpToolBar1.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5, Me.barItem6})
			Me.xpToolBar1.Bar.Manager = Nothing
			Me.xpToolBar1.Bar.SeparatorIndices.AddRange(New Integer() { 3, 5})
			Me.xpToolBar1.Location = New System.Drawing.Point(35, 44)
			Me.xpToolBar1.Name = "xpToolBar1"
			Me.xpToolBar1.SeparatorIndices.AddRange(New Integer() { 3, 5})
			Me.xpToolBar1.Size = New System.Drawing.Size(176, 25)
			Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Me.xpToolBar1.TabIndex = 17
			Me.xpToolBar1.Text = "xpToolBar1"
			' 
			' barItem1
			' 
			Me.barItem1.ID = "One"
			Me.barItem1.Text = "Cu."
			Me.barItem1.Tooltip = "Cut"
			' 
			' barItem2
			' 
			Me.barItem2.ID = "Copy"
			Me.barItem2.Text = "Co."
			Me.barItem2.Tooltip = "Copy"
			' 
			' barItem3
			' 
			Me.barItem3.ID = "Paste"
			Me.barItem3.Text = "Pa."
			Me.barItem3.Tooltip = "Paste"
			' 
			' barItem4
			' 
			Me.barItem4.ID = "Undo"
			Me.barItem4.Text = "Un."
			Me.barItem4.Tooltip = "Undo"
			' 
			' barItem5
			' 
			Me.barItem5.ID = "Redo"
			Me.barItem5.Text = "Re."
			Me.barItem5.Tooltip = "Redo"
			' 
			' barItem6
			' 
			Me.barItem6.ID = "Help"
			Me.barItem6.Text = "He."
			Me.barItem6.Tooltip = "Help"
			' 
			' xpToolBar2
			' 
			' 
			' 
			' 
			Me.xpToolBar2.Bar.BarName = ""
			Me.xpToolBar2.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem7, Me.barItem8, Me.barItem9, Me.barItem10, Me.barItem11, Me.barItem12})
			Me.xpToolBar2.Bar.Manager = Nothing
			Me.xpToolBar2.Bar.SeparatorIndices.AddRange(New Integer() { 3, 5})
			Me.xpToolBar2.Location = New System.Drawing.Point(255, 44)
			Me.xpToolBar2.Name = "xpToolBar2"
			Me.xpToolBar2.SeparatorIndices.AddRange(New Integer() { 3, 5})
			Me.xpToolBar2.Size = New System.Drawing.Size(176, 25)
			Me.xpToolBar2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Me.xpToolBar2.TabIndex = 18
			Me.xpToolBar2.Text = "xpToolBar2"
			' 
			' barItem7
			' 
			Me.barItem7.ID = "Cut"
			Me.barItem7.Text = "Cu."
			Me.barItem7.Tooltip = "Cut"
			' 
			' barItem8
			' 
			Me.barItem8.ID = "Copy"
			Me.barItem8.Text = "Co."
			Me.barItem8.Tooltip = "Copy"
			' 
			' barItem9
			' 
			Me.barItem9.ID = "Paste"
			Me.barItem9.Text = "Pa."
			Me.barItem9.Tooltip = "Paste"
			' 
			' barItem10
			' 
			Me.barItem10.ID = "Undo"
			Me.barItem10.Text = "Un."
			Me.barItem10.Tooltip = "Undo"
			' 
			' barItem11
			' 
			Me.barItem11.ID = "Redo"
			Me.barItem11.Text = "Re."
			Me.barItem11.Tooltip = "Redo"
			' 
			' barItem12
			' 
			Me.barItem12.ID = "Help"
			Me.barItem12.Text = "He."
			Me.barItem12.Tooltip = "Help"
			' 
			' tabControlAdv1
			' 
			Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.tabControlAdv1.BackColor = System.Drawing.SystemColors.Control
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv5)
			Me.tabControlAdv1.FocusOnTabClick = False
			Me.tabControlAdv1.Location = New System.Drawing.Point(9, 15)
			Me.tabControlAdv1.Name = "tabControlAdv1"
			Me.tabControlAdv1.Padding = New System.Drawing.Point(1, 1)
			Me.tabControlAdv1.ShowScroll = False
			Me.tabControlAdv1.Size = New System.Drawing.Size(196, 115)
			Me.tabControlAdv1.TabIndex = 20
			Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.OneNoteStyleRenderer)
			' 
			' tabPageAdv1
			' 
			Me.tabPageAdv1.Location = New System.Drawing.Point(1, 0)
			Me.tabPageAdv1.Name = "tabPageAdv1"
			Me.tabPageAdv1.Size = New System.Drawing.Size(193, 113)
			Me.tabPageAdv1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.tabPageAdv1.TabIndex = 1
			Me.tabPageAdv1.Text = "Page1"
			Me.tabPageAdv1.ThemesEnabled = False
			' 
			' tabPageAdv2
			' 
			Me.tabPageAdv2.Location = New System.Drawing.Point(1, 0)
			Me.tabPageAdv2.Name = "tabPageAdv2"
			Me.tabPageAdv2.Size = New System.Drawing.Size(193, 113)
			Me.tabPageAdv2.TabIndex = 1
			Me.tabPageAdv2.Text = "Page2"
			Me.tabPageAdv2.ThemesEnabled = False
			' 
			' tabPageAdv5
			' 
			Me.tabPageAdv5.Location = New System.Drawing.Point(1, 0)
			Me.tabPageAdv5.Name = "tabPageAdv5"
			Me.tabPageAdv5.Size = New System.Drawing.Size(193, 113)
			Me.tabPageAdv5.TabIndex = 2
			Me.tabPageAdv5.Text = "Page3"
			Me.tabPageAdv5.ThemesEnabled = False
			' 
			' tabControlAdv2
			' 
			Me.tabControlAdv2.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.tabControlAdv2.BackColor = System.Drawing.SystemColors.Control
			Me.tabControlAdv2.Controls.Add(Me.tabPageAdv3)
			Me.tabControlAdv2.Controls.Add(Me.tabPageAdv4)
			Me.tabControlAdv2.Controls.Add(Me.tabPageAdv6)
			Me.tabControlAdv2.Location = New System.Drawing.Point(238, 15)
			Me.tabControlAdv2.Name = "tabControlAdv2"
			Me.tabControlAdv2.Padding = New System.Drawing.Point(1, 1)
			Me.tabControlAdv2.ShowScroll = False
			Me.tabControlAdv2.Size = New System.Drawing.Size(196, 113)
			Me.tabControlAdv2.TabIndex = 22
			Me.tabControlAdv2.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.OneNoteStyleRenderer)
			' 
			' tabPageAdv3
			' 
			Me.tabPageAdv3.Location = New System.Drawing.Point(1, 0)
			Me.tabPageAdv3.Name = "tabPageAdv3"
			Me.tabPageAdv3.Size = New System.Drawing.Size(193, 111)
			Me.tabPageAdv3.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.tabPageAdv3.TabIndex = 1
			Me.tabPageAdv3.Text = "Page1"
			Me.tabPageAdv3.ThemesEnabled = False
			' 
			' tabPageAdv4
			' 
			Me.tabPageAdv4.Location = New System.Drawing.Point(1, 0)
			Me.tabPageAdv4.Name = "tabPageAdv4"
			Me.tabPageAdv4.Size = New System.Drawing.Size(193, 111)
			Me.tabPageAdv4.TabIndex = 1
			Me.tabPageAdv4.Text = "Page2"
			Me.tabPageAdv4.ThemesEnabled = False
			' 
			' tabPageAdv6
			' 
			Me.tabPageAdv6.Location = New System.Drawing.Point(1, 0)
			Me.tabPageAdv6.Name = "tabPageAdv6"
			Me.tabPageAdv6.Size = New System.Drawing.Size(193, 111)
			Me.tabPageAdv6.TabIndex = 2
			Me.tabPageAdv6.Text = "Page3"
			Me.tabPageAdv6.ThemesEnabled = False
			' 
			' tabControlAdv3
			' 
			Me.tabControlAdv3.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.tabControlAdv3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabControlAdv3.Controls.Add(Me.tabPageAdv12)
			Me.tabControlAdv3.Controls.Add(Me.tabPageAdv9)
			Me.tabControlAdv3.Controls.Add(Me.tabPageAdv10)
			Me.tabControlAdv3.Controls.Add(Me.tabPageAdv8)
			Me.tabControlAdv3.Controls.Add(Me.tabPageAdv11)
			Me.tabControlAdv3.Controls.Add(Me.tabPageAdv13)
			Me.tabControlAdv3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabControlAdv3.Location = New System.Drawing.Point(127, 0)
			Me.tabControlAdv3.Name = "tabControlAdv3"
			Me.tabControlAdv3.Size = New System.Drawing.Size(453, 241)
			Me.tabControlAdv3.TabGap = 10
			Me.tabControlAdv3.TabIndex = 43
			Me.tabControlAdv3.TabPanelBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.tabControlAdv3.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
			' 
			' tabPageAdv12
			' 
			Me.tabPageAdv12.Controls.Add(Me.gradientLabel8)
			Me.tabPageAdv12.Controls.Add(Me.gradientLabel7)
			Me.tabPageAdv12.Controls.Add(Me.label13)
			Me.tabPageAdv12.Controls.Add(Me.label14)
			Me.tabPageAdv12.Controls.Add(Me.label15)
			Me.tabPageAdv12.Controls.Add(Me.dockingUserControl1)
			Me.tabPageAdv12.Controls.Add(Me.dockingUserControl2)
			Me.tabPageAdv12.Location = New System.Drawing.Point(1, 29)
			Me.tabPageAdv12.Name = "tabPageAdv12"
			Me.tabPageAdv12.Size = New System.Drawing.Size(450, 210)
			Me.tabPageAdv12.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.tabPageAdv12.TabIndex = 5
			Me.tabPageAdv12.Text = "Docking"
			Me.tabPageAdv12.ThemesEnabled = False
			' 
			' gradientLabel8
			' 
			Me.gradientLabel8.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel8.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel8.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel8.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.gradientLabel8.Location = New System.Drawing.Point(298, 158)
			Me.gradientLabel8.Name = "gradientLabel8"
			Me.gradientLabel8.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel8.TabIndex = 116
			Me.gradientLabel8.Text = "ImageList"
			Me.gradientLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' gradientLabel7
			' 
			Me.gradientLabel7.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel7.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel7.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel7.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.gradientLabel7.Location = New System.Drawing.Point(73, 158)
			Me.gradientLabel7.Name = "gradientLabel7"
			Me.gradientLabel7.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel7.TabIndex = 115
			Me.gradientLabel7.Text = "ImageListAdv"
			Me.gradientLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' label13
			' 
			Me.label13.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label13.Location = New System.Drawing.Point(220, 169)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(10, 1)
			Me.label13.TabIndex = 123
			' 
			' label14
			' 
			Me.label14.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label14.Location = New System.Drawing.Point(221, 20)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(10, 1)
			Me.label14.TabIndex = 122
			' 
			' label15
			' 
			Me.label15.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label15.Location = New System.Drawing.Point(225, 21)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(1, 148)
			Me.label15.TabIndex = 121
			' 
			' tabPageAdv9
			' 
			Me.tabPageAdv9.Controls.Add(Me.label4)
			Me.tabPageAdv9.Controls.Add(Me.label16)
			Me.tabPageAdv9.Controls.Add(Me.label17)
			Me.tabPageAdv9.Controls.Add(Me.groupBar2)
			Me.tabPageAdv9.Controls.Add(Me.groupBar1)
			Me.tabPageAdv9.Controls.Add(Me.gradientLabel10)
			Me.tabPageAdv9.Controls.Add(Me.gradientLabel9)
			Me.tabPageAdv9.Location = New System.Drawing.Point(1, 29)
			Me.tabPageAdv9.Name = "tabPageAdv9"
			Me.tabPageAdv9.Size = New System.Drawing.Size(450, 210)
			Me.tabPageAdv9.TabIndex = 2
			Me.tabPageAdv9.Text = "GroupBar"
			Me.tabPageAdv9.ThemesEnabled = False
			' 
			' label4
			' 
			Me.label4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label4.Location = New System.Drawing.Point(214, 170)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(10, 1)
			Me.label4.TabIndex = 130
			' 
			' label16
			' 
			Me.label16.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label16.Location = New System.Drawing.Point(214, 12)
			Me.label16.Name = "label16"
			Me.label16.Size = New System.Drawing.Size(10, 1)
			Me.label16.TabIndex = 129
			' 
			' label17
			' 
			Me.label17.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label17.Location = New System.Drawing.Point(219, 13)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(1, 157)
			Me.label17.TabIndex = 128
			' 
			' groupBar2
			' 
			Me.groupBar2.AllowDrop = True
			Me.groupBar2.AnimatedSelection = False
			Me.groupBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.groupBar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.groupBar2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.groupBar2.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.groupBarItem5, Me.groupBarItem6})
			Me.groupBar2.HeaderForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(65))))), (CInt(Fix((CByte(140))))))
			Me.groupBar2.Location = New System.Drawing.Point(270, 8)
			Me.groupBar2.Name = "groupBar2"
			Me.groupBar2.SelectedItem = 1
			Me.groupBar2.ShowItemImageInHeader = True
			Me.groupBar2.Size = New System.Drawing.Size(145, 148)
			Me.groupBar2.StackedMode = True
			Me.groupBar2.TabIndex = 127
			Me.groupBar2.Text = "groupBar2"
			Me.groupBar2.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.groupBar2.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' groupBarItem5
			' 
			Me.groupBarItem5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.groupBarItem5.Client = Nothing
			Me.groupBarItem5.LargeImageMode = True
			Me.groupBarItem5.Text = "Notes"
			' 
			' groupBarItem6
			' 
			Me.groupBarItem6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.groupBarItem6.Client = Nothing
			Me.groupBarItem6.LargeImageMode = True
			Me.groupBarItem6.Text = "Folder List"
			' 
			' groupBar1
			' 
			Me.groupBar1.AllowDrop = True
			Me.groupBar1.AnimatedSelection = False
			Me.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.groupBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold)
			Me.groupBar1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.groupBarItem1, Me.groupBarItem3})
			Me.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(65))))), (CInt(Fix((CByte(140))))))
			Me.groupBar1.Location = New System.Drawing.Point(35, 8)
			Me.groupBar1.Name = "groupBar1"
			Me.groupBar1.SelectedItem = 1
			Me.groupBar1.ShowItemImageInHeader = True
			Me.groupBar1.Size = New System.Drawing.Size(145, 148)
			Me.groupBar1.StackedMode = True
			Me.groupBar1.TabIndex = 126
			Me.groupBar1.Text = "groupBar1"
			Me.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' groupBarItem1
			' 
			Me.groupBarItem1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.groupBarItem1.Client = Nothing
			Me.groupBarItem1.LargeImageMode = True
			Me.groupBarItem1.Text = "Notes"
			' 
			' groupBarItem3
			' 
			Me.groupBarItem3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253))))))
			Me.groupBarItem3.Client = Nothing
			Me.groupBarItem3.LargeImageMode = True
			Me.groupBarItem3.Text = "Folder List"
			' 
			' gradientLabel10
			' 
			Me.gradientLabel10.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel10.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel10.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel10.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel10.Location = New System.Drawing.Point(308, 170)
			Me.gradientLabel10.Name = "gradientLabel10"
			Me.gradientLabel10.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel10.TabIndex = 125
			Me.gradientLabel10.Text = "ImageList"
			Me.gradientLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' gradientLabel9
			' 
			Me.gradientLabel9.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel9.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel9.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel9.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel9.Location = New System.Drawing.Point(64, 170)
			Me.gradientLabel9.Name = "gradientLabel9"
			Me.gradientLabel9.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel9.TabIndex = 124
			Me.gradientLabel9.Text = "ImageListAdv"
			Me.gradientLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' tabPageAdv10
			' 
			Me.tabPageAdv10.Controls.Add(Me.gradientLabel6)
			Me.tabPageAdv10.Controls.Add(Me.tabControlAdv2)
			Me.tabPageAdv10.Controls.Add(Me.label10)
			Me.tabPageAdv10.Controls.Add(Me.label11)
			Me.tabPageAdv10.Controls.Add(Me.label12)
			Me.tabPageAdv10.Controls.Add(Me.tabControlAdv1)
			Me.tabPageAdv10.Controls.Add(Me.gradientLabel3)
			Me.tabPageAdv10.Location = New System.Drawing.Point(1, 29)
			Me.tabPageAdv10.Name = "tabPageAdv10"
			Me.tabPageAdv10.Size = New System.Drawing.Size(450, 210)
			Me.tabPageAdv10.TabIndex = 3
			Me.tabPageAdv10.Text = "TabControlAdv"
			Me.tabPageAdv10.ThemesEnabled = False
			' 
			' gradientLabel6
			' 
			Me.gradientLabel6.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel6.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel6.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel6.Location = New System.Drawing.Point(300, 140)
			Me.gradientLabel6.Name = "gradientLabel6"
			Me.gradientLabel6.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel6.TabIndex = 115
			Me.gradientLabel6.Text = "ImageList"
			Me.gradientLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' label10
			' 
			Me.label10.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label10.Location = New System.Drawing.Point(217, 158)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(10, 1)
			Me.label10.TabIndex = 117
			' 
			' label11
			' 
			Me.label11.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label11.Location = New System.Drawing.Point(217, 10)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(10, 1)
			Me.label11.TabIndex = 116
			' 
			' label12
			' 
			Me.label12.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label12.Location = New System.Drawing.Point(221, 10)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(1, 148)
			Me.label12.TabIndex = 115
			' 
			' gradientLabel3
			' 
			Me.gradientLabel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel3.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel3.Location = New System.Drawing.Point(63, 140)
			Me.gradientLabel3.Name = "gradientLabel3"
			Me.gradientLabel3.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel3.TabIndex = 114
			Me.gradientLabel3.Text = "ImageListAdv"
			Me.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' tabPageAdv8
			' 
			Me.tabPageAdv8.Controls.Add(Me.label1)
			Me.tabPageAdv8.Controls.Add(Me.label2)
			Me.tabPageAdv8.Controls.Add(Me.label5)
			Me.tabPageAdv8.Controls.Add(Me.gradientLabel1)
			Me.tabPageAdv8.Controls.Add(Me.treeViewAdv2)
			Me.tabPageAdv8.Controls.Add(Me.gradientLabel13)
			Me.tabPageAdv8.Controls.Add(Me.treeViewAdv3)
			Me.tabPageAdv8.Location = New System.Drawing.Point(1, 29)
			Me.tabPageAdv8.Name = "tabPageAdv8"
			Me.tabPageAdv8.Size = New System.Drawing.Size(450, 210)
			Me.tabPageAdv8.TabIndex = 1
			Me.tabPageAdv8.Text = "TreeViewAdv"
			Me.tabPageAdv8.ThemesEnabled = False
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label1.Location = New System.Drawing.Point(215, 170)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(10, 1)
			Me.label1.TabIndex = 126
			' 
			' label2
			' 
			Me.label2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label2.Location = New System.Drawing.Point(215, 12)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(10, 1)
			Me.label2.TabIndex = 125
			' 
			' label5
			' 
			Me.label5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label5.Location = New System.Drawing.Point(220, 13)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(1, 157)
			Me.label5.TabIndex = 124
			' 
			' gradientLabel1
			' 
			Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel1.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel1.Location = New System.Drawing.Point(286, 146)
			Me.gradientLabel1.Name = "gradientLabel1"
			Me.gradientLabel1.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel1.TabIndex = 123
			Me.gradientLabel1.Text = "ImageList"
			Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' treeViewAdv2
			' 
			Me.treeViewAdv2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(249)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(249)))))), System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(249)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(249))))))})
			treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = True
			treeNodeAdvStyleInfo1.ShowPlusMinus = False
			treeNodeAdvStyleInfo1.ThemesEnabled = False
			Me.treeViewAdv2.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() { New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)})
			' 
			' 
			' 
			Me.treeViewAdv2.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv2.HelpTextControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv2.HelpTextControl.Name = "helpText"
			Me.treeViewAdv2.HelpTextControl.Size = New System.Drawing.Size(49, 15)
			Me.treeViewAdv2.HelpTextControl.TabIndex = 0
			Me.treeViewAdv2.HelpTextControl.Text = "help text"
			Me.treeViewAdv2.ItemHeight = 25
			Me.treeViewAdv2.Location = New System.Drawing.Point(48, 17)
			Me.treeViewAdv2.Name = "treeViewAdv2"
			treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv1.EnsureDefaultOptionedChild = True
			treeNodeAdv1.Expanded = True
			treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv2.EnsureDefaultOptionedChild = True
			treeNodeAdv2.Optioned = True
			treeNodeAdv2.Text = "Outstanding"
			treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv3.EnsureDefaultOptionedChild = True
			treeNodeAdv3.Text = "Excellent"
			treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv4.EnsureDefaultOptionedChild = True
			treeNodeAdv4.Text = "Good"
			treeNodeAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv2, treeNodeAdv3, treeNodeAdv4})
			treeNodeAdv1.Text = "Remarks"
			Me.treeViewAdv2.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv1})
			Me.treeViewAdv2.ShowLines = False
			Me.treeViewAdv2.ShowPlusMinus = False
			Me.treeViewAdv2.ShowRootLines = False
			Me.treeViewAdv2.Size = New System.Drawing.Size(128, 114)
			Me.treeViewAdv2.TabIndex = 118
			Me.treeViewAdv2.Text = "treeViewAdv2"
			Me.treeViewAdv2.ThemesEnabled = False
			' 
			' 
			' 
			Me.treeViewAdv2.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
			Me.treeViewAdv2.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv2.ToolTipControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv2.ToolTipControl.Name = "toolTip"
			Me.treeViewAdv2.ToolTipControl.Size = New System.Drawing.Size(41, 15)
			Me.treeViewAdv2.ToolTipControl.TabIndex = 1
			Me.treeViewAdv2.ToolTipControl.Text = "toolTip"
			' 
			' gradientLabel13
			' 
			Me.gradientLabel13.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel13.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel13.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel13.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel13.Location = New System.Drawing.Point(69, 146)
			Me.gradientLabel13.Name = "gradientLabel13"
			Me.gradientLabel13.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel13.TabIndex = 115
			Me.gradientLabel13.Text = "ImageListAdv"
			Me.gradientLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' treeViewAdv3
			' 
			Me.treeViewAdv3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(249)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(249)))))), System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(249)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(243))))), (CInt(Fix((CByte(245))))), (CInt(Fix((CByte(249))))))})
			treeNodeAdvStyleInfo2.EnsureDefaultOptionedChild = True
			treeNodeAdvStyleInfo2.ShowPlusMinus = False
			treeNodeAdvStyleInfo2.ThemesEnabled = False
			Me.treeViewAdv3.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() { New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo2)})
			' 
			' 
			' 
			Me.treeViewAdv3.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv3.HelpTextControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv3.HelpTextControl.Name = "helpText"
			Me.treeViewAdv3.HelpTextControl.Size = New System.Drawing.Size(49, 15)
			Me.treeViewAdv3.HelpTextControl.TabIndex = 0
			Me.treeViewAdv3.HelpTextControl.Text = "help text"
			Me.treeViewAdv3.ItemHeight = 25
			Me.treeViewAdv3.Location = New System.Drawing.Point(266, 17)
			Me.treeViewAdv3.Name = "treeViewAdv3"
			treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv5.EnsureDefaultOptionedChild = True
			treeNodeAdv5.Expanded = True
			treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv6.EnsureDefaultOptionedChild = True
			treeNodeAdv6.Optioned = True
			treeNodeAdv6.Text = "Oustanding"
			treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv7.EnsureDefaultOptionedChild = True
			treeNodeAdv7.Text = "Excellent"
			treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv8.EnsureDefaultOptionedChild = True
			treeNodeAdv8.Text = "Good"
			treeNodeAdv5.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv6, treeNodeAdv7, treeNodeAdv8})
			treeNodeAdv5.Text = "Remarks"
			Me.treeViewAdv3.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv5})
			Me.treeViewAdv3.ShowLines = False
			Me.treeViewAdv3.ShowPlusMinus = False
			Me.treeViewAdv3.Size = New System.Drawing.Size(128, 114)
			Me.treeViewAdv3.TabIndex = 117
			Me.treeViewAdv3.Text = "treeViewAdv3"
			Me.treeViewAdv3.ThemesEnabled = False
			' 
			' 
			' 
			Me.treeViewAdv3.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
			Me.treeViewAdv3.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv3.ToolTipControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv3.ToolTipControl.Name = "toolTip"
			Me.treeViewAdv3.ToolTipControl.Size = New System.Drawing.Size(41, 15)
			Me.treeViewAdv3.ToolTipControl.TabIndex = 1
			Me.treeViewAdv3.ToolTipControl.Text = "toolTip"
			' 
			' tabPageAdv11
			' 
			Me.tabPageAdv11.Controls.Add(Me.gradientLabel5)
			Me.tabPageAdv11.Controls.Add(Me.gradientLabel4)
			Me.tabPageAdv11.Controls.Add(Me.xpToolBar2)
			Me.tabPageAdv11.Controls.Add(Me.label7)
			Me.tabPageAdv11.Controls.Add(Me.label8)
			Me.tabPageAdv11.Controls.Add(Me.label9)
			Me.tabPageAdv11.Controls.Add(Me.xpToolBar1)
			Me.tabPageAdv11.Location = New System.Drawing.Point(1, 29)
			Me.tabPageAdv11.Name = "tabPageAdv11"
			Me.tabPageAdv11.Size = New System.Drawing.Size(450, 210)
			Me.tabPageAdv11.TabIndex = 4
			Me.tabPageAdv11.Text = "XPMenus"
			Me.tabPageAdv11.ThemesEnabled = False
			' 
			' gradientLabel5
			' 
			Me.gradientLabel5.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel5.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel5.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel5.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel5.Location = New System.Drawing.Point(297, 131)
			Me.gradientLabel5.Name = "gradientLabel5"
			Me.gradientLabel5.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel5.TabIndex = 122
			Me.gradientLabel5.Text = "ImageList"
			Me.gradientLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' gradientLabel4
			' 
			Me.gradientLabel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel4.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel4.Location = New System.Drawing.Point(69, 131)
			Me.gradientLabel4.Name = "gradientLabel4"
			Me.gradientLabel4.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel4.TabIndex = 121
			Me.gradientLabel4.Text = "ImageListAdv"
			Me.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' label7
			' 
			Me.label7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label7.Location = New System.Drawing.Point(216, 155)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(10, 1)
			Me.label7.TabIndex = 120
			' 
			' label8
			' 
			Me.label8.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label8.Location = New System.Drawing.Point(216, 25)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(10, 1)
			Me.label8.TabIndex = 119
			' 
			' label9
			' 
			Me.label9.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label9.Location = New System.Drawing.Point(221, 26)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(1, 129)
			Me.label9.TabIndex = 118
			' 
			' tabPageAdv13
			' 
			Me.tabPageAdv13.Controls.Add(Me.pictureBox1)
			Me.tabPageAdv13.Controls.Add(Me.trackBarEx1)
			Me.tabPageAdv13.Controls.Add(Me.gradientLabel19)
			Me.tabPageAdv13.Controls.Add(Me.gradientLabel12)
			Me.tabPageAdv13.Controls.Add(Me.label6)
			Me.tabPageAdv13.Controls.Add(Me.label18)
			Me.tabPageAdv13.Controls.Add(Me.label19)
			Me.tabPageAdv13.Controls.Add(Me.trackBarEx2)
			Me.tabPageAdv13.Controls.Add(Me.pictureBox2)
			Me.tabPageAdv13.Location = New System.Drawing.Point(1, 29)
			Me.tabPageAdv13.Name = "tabPageAdv13"
			Me.tabPageAdv13.Size = New System.Drawing.Size(450, 210)
			Me.tabPageAdv13.TabIndex = 7
			Me.tabPageAdv13.Text = "Image Size"
			Me.tabPageAdv13.ThemesEnabled = False
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Location = New System.Drawing.Point(94, 32)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox1.TabIndex = 133
			Me.pictureBox1.TabStop = False
			' 
			' trackBarEx1
			' 
			Me.trackBarEx1.DecreaseButtonSize = New System.Drawing.Size(14, 14)
			Me.trackBarEx1.IncreaseButtonSize = New System.Drawing.Size(14, 14)
			Me.trackBarEx1.Location = New System.Drawing.Point(35, 105)
            Me.trackBarEx1.Name = "trackBarEx1"
			Me.trackBarEx1.Size = New System.Drawing.Size(148, 20)
			Me.trackBarEx1.TabIndex = 132
			Me.trackBarEx1.Text = "trackBarEx1"
			Me.trackBarEx1.TimerInterval = 100
			Me.trackBarEx1.TrackBarGradientEnd = System.Drawing.Color.FromArgb((CInt(Fix((CByte(198))))), (CInt(Fix((CByte(222))))), (CInt(Fix((CByte(254))))))
			Me.trackBarEx1.TrackBarGradientStart = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))

			' 
			' gradientLabel19
			' 
			Me.gradientLabel19.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel19.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel19.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel19.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel19.Location = New System.Drawing.Point(309, 144)
			Me.gradientLabel19.Name = "gradientLabel19"
			Me.gradientLabel19.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel19.TabIndex = 131
			Me.gradientLabel19.Text = "ImageList"
			Me.gradientLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' gradientLabel12
			' 
			Me.gradientLabel12.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, New System.Drawing.Color() { System.Drawing.Color.FromArgb((CInt(Fix((CByte(228))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(204))))), (CInt(Fix((CByte(235))))), (CInt(Fix((CByte(255)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(174))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(212)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(170))))), (CInt(Fix((CByte(181))))), (CInt(Fix((CByte(196)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(168))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(179)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(188))))), (CInt(Fix((CByte(200))))), (CInt(Fix((CByte(214)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(207))))), (CInt(Fix((CByte(214))))), (CInt(Fix((CByte(226)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(237))))), (CInt(Fix((CByte(242)))))), System.Drawing.Color.White})
			Me.gradientLabel12.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel12.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
			Me.gradientLabel12.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel12.Location = New System.Drawing.Point(61, 144)
			Me.gradientLabel12.Name = "gradientLabel12"
			Me.gradientLabel12.Size = New System.Drawing.Size(90, 25)
			Me.gradientLabel12.TabIndex = 130
			Me.gradientLabel12.Text = "ImageListAdv"
			Me.gradientLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' label6
			' 
			Me.label6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label6.Location = New System.Drawing.Point(217, 169)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(10, 1)
			Me.label6.TabIndex = 129
			' 
			' label18
			' 
			Me.label18.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label18.Location = New System.Drawing.Point(217, 11)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(10, 1)
			Me.label18.TabIndex = 128
			' 
			' label19
			' 
			Me.label19.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label19.Location = New System.Drawing.Point(222, 12)
			Me.label19.Name = "label19"
			Me.label19.Size = New System.Drawing.Size(1, 157)
			Me.label19.TabIndex = 127
			' 
			' trackBarEx2
			' 
			Me.trackBarEx2.DecreaseButtonSize = New System.Drawing.Size(14, 14)
			Me.trackBarEx2.IncreaseButtonSize = New System.Drawing.Size(14, 14)
			Me.trackBarEx2.Location = New System.Drawing.Point(273, 105)
			
			Me.trackBarEx2.Name = "trackBarEx2"
			Me.trackBarEx2.Size = New System.Drawing.Size(148, 20)
			Me.trackBarEx2.TabIndex = 3
			Me.trackBarEx2.Text = "trackBarEx2"
			Me.trackBarEx2.TimerInterval = 100
			Me.trackBarEx2.TrackBarGradientEnd = System.Drawing.Color.FromArgb((CInt(Fix((CByte(198))))), (CInt(Fix((CByte(222))))), (CInt(Fix((CByte(254))))))
			Me.trackBarEx2.TrackBarGradientStart = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
          

			' 
			' pictureBox2
			' 
			Me.pictureBox2.Location = New System.Drawing.Point(324, 32)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox2.TabIndex = 1
			Me.pictureBox2.TabStop = False
			' 
			' gradientLabel2
			' 
			Me.gradientLabel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control)
			Me.gradientLabel2.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.gradientLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.gradientLabel2.Location = New System.Drawing.Point(65, 137)
			Me.gradientLabel2.Name = "gradientLabel2"
			Me.gradientLabel2.Size = New System.Drawing.Size(88, 35)
			Me.gradientLabel2.TabIndex = 103
			Me.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' label46
			' 
			Me.label46.BackColor = System.Drawing.Color.Transparent
			Me.label46.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label46.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label46.Image = (CType(resources.GetObject("label46.Image"), System.Drawing.Image))
			Me.label46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label46.Location = New System.Drawing.Point(3, 12)
			Me.label46.Name = "label46"
			Me.label46.Size = New System.Drawing.Size(86, 24)
			Me.label46.TabIndex = 105
			Me.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label58
			' 
			Me.label58.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label58.Location = New System.Drawing.Point(3, 36)
			Me.label58.Name = "label58"
			Me.label58.Size = New System.Drawing.Size(150, 1)
			Me.label58.TabIndex = 104
			' 
			' label3
			' 
			Me.label3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(143))))), (CInt(Fix((CByte(164))))), (CInt(Fix((CByte(190))))))
			Me.label3.Location = New System.Drawing.Point(2, 68)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(90, 122)
			Me.label3.TabIndex = 123
			' 
			' treeViewAdv1
			' 
			treeNodeAdvStyleInfo3.Background = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(207))))), (CInt(Fix((CByte(132)))))), System.Drawing.Color.White)
			treeNodeAdvStyleInfo3.EnsureDefaultOptionedChild = True
			treeNodeAdvStyleInfo3.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(74))))), (CInt(Fix((CByte(92))))), (CInt(Fix((CByte(140))))))
			treeNodeAdvStyleInfo4.Background = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(253)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(206))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(245)))))))
			treeNodeAdvStyleInfo4.EnsureDefaultOptionedChild = True
			treeNodeAdvStyleInfo5.BaseStyle = "Style1"
			treeNodeAdvStyleInfo5.EnsureDefaultOptionedChild = True
			treeNodeAdvStyleInfo5.ShowPlusMinus = False
			treeNodeAdvStyleInfo5.ThemesEnabled = True
			Me.treeViewAdv1.BaseStylePairs.AddRange(New Syncfusion.Windows.Forms.Tools.StyleNamePair() { New Syncfusion.Windows.Forms.Tools.StyleNamePair("Style1", treeNodeAdvStyleInfo3), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Style2", treeNodeAdvStyleInfo4), New Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo5)})
			Me.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Left
			Me.treeViewAdv1.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.treeViewAdv1.ForeColor = System.Drawing.Color.White
			Me.treeViewAdv1.FullRowSelect = True
			' 
			' 
			' 
			Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv1.HelpTextControl.Name = "helpText"
			Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(49, 15)
			Me.treeViewAdv1.HelpTextControl.TabIndex = 0
			Me.treeViewAdv1.HelpTextControl.Text = "help text"
			Me.treeViewAdv1.HotTracking = True
			Me.treeViewAdv1.ItemHeight = 34
			Me.treeViewAdv1.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv1.Name = "treeViewAdv1"
			treeNodeAdv9.BaseStyle = "Style2"
			treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv9.EnsureDefaultOptionedChild = True
			treeNodeAdv9.Expanded = True
			treeNodeAdv10.BaseStyle = "Style2"
			treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv10.EnsureDefaultOptionedChild = True
			treeNodeAdv10.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			treeNodeAdv10.Optioned = True
			treeNodeAdv10.Text = "DockingManager"
			treeNodeAdv11.BaseStyle = "Style2"
			treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv11.EnsureDefaultOptionedChild = True
			treeNodeAdv11.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			treeNodeAdv11.Text = "GroupBar"
			treeNodeAdv12.BaseStyle = "Style2"
			treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv12.EnsureDefaultOptionedChild = True
			treeNodeAdv12.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			treeNodeAdv12.Text = "TabControlAdv"
			treeNodeAdv13.BaseStyle = "Style2"
			treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv13.EnsureDefaultOptionedChild = True
			treeNodeAdv13.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			treeNodeAdv13.Text = "TreeViewAdv"
			treeNodeAdv14.BaseStyle = "Style2"
			treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv14.EnsureDefaultOptionedChild = True
			treeNodeAdv14.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			treeNodeAdv14.Text = "XPMenus"
			treeNodeAdv9.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv10, treeNodeAdv11, treeNodeAdv12, treeNodeAdv13, treeNodeAdv14})
			treeNodeAdv9.Text = "Controls"
			treeNodeAdv15.BaseStyle = "Style2"
			treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = True
			treeNodeAdv15.EnsureDefaultOptionedChild = True
			treeNodeAdv15.Expanded = True
			treeNodeAdv15.Text = "Image Size"
			Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() { treeNodeAdv9, treeNodeAdv15})
			Me.treeViewAdv1.SelectedNodeBackground = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(207))))), (CInt(Fix((CByte(132)))))), System.Drawing.Color.White)
			Me.treeViewAdv1.ShowLines = False
			Me.treeViewAdv1.ShowPlusMinus = False
			Me.treeViewAdv1.Size = New System.Drawing.Size(127, 241)
			Me.treeViewAdv1.TabIndex = 44
			Me.treeViewAdv1.Text = "treeViewAdv1"
			Me.treeViewAdv1.ThemesEnabled = True
			' 
			' 
			' 
			Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
			Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
			Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 15)
			Me.treeViewAdv1.ToolTipControl.TabIndex = 1
			Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
'			Me.treeViewAdv1.Click += New System.EventHandler(Me.treeViewAdv1_Click);
			' 
			' dockingUserControl1
			' 
			Me.dockingUserControl1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.dockingUserControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.dockingUserControl1.Location = New System.Drawing.Point(45, 21)
			Me.dockingUserControl1.Name = "dockingUserControl1"
			Me.dockingUserControl1.Size = New System.Drawing.Size(150, 119)
			Me.dockingUserControl1.TabIndex = 0
			' 
			' dockingUserControl2
			' 
			Me.dockingUserControl2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.dockingUserControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.dockingUserControl2.Location = New System.Drawing.Point(255, 21)
			Me.dockingUserControl2.Name = "dockingUserControl2"
			Me.dockingUserControl2.Size = New System.Drawing.Size(150, 119)
			Me.dockingUserControl2.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(580, 241)
			Me.Controls.Add(Me.tabControlAdv3)
			Me.Controls.Add(Me.treeViewAdv1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ImageListAdv"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControlAdv1.ResumeLayout(False)
			CType(Me.tabControlAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControlAdv2.ResumeLayout(False)
			CType(Me.tabControlAdv3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControlAdv3.ResumeLayout(False)
			Me.tabPageAdv12.ResumeLayout(False)
			Me.tabPageAdv9.ResumeLayout(False)
			CType(Me.groupBar2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabPageAdv10.ResumeLayout(False)
			Me.tabPageAdv8.ResumeLayout(False)
			CType(Me.treeViewAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeViewAdv3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabPageAdv11.ResumeLayout(False)
			Me.tabPageAdv13.ResumeLayout(False)
			Me.tabPageAdv13.PerformLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
		Private imageList1 As System.Windows.Forms.ImageList
		Private buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private xpToolBar1 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private xpToolBar2 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabControlAdv2 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private tabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv4 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv6 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv5 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabControlAdv3 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private tabPageAdv8 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv9 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private gradientLabel2 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private label46 As System.Windows.Forms.Label
		Private label58 As System.Windows.Forms.Label
		Private tabPageAdv10 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv11 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv12 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private WithEvents treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
		Private barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private gradientLabel6 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel3 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private gradientLabel5 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel4 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private dockingUserControl1 As Docking1
		Private dockingUserControl2 As Docking2
		Private gradientLabel8 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel7 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel10 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel9 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private label3 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private label14 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private gradientLabel13 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private groupBar2 As Syncfusion.Windows.Forms.Tools.GroupBar
		Private groupBarItem5 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem6 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
		Private groupBarItem3 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private label4 As System.Windows.Forms.Label
		Private label16 As System.Windows.Forms.Label
		Private label17 As System.Windows.Forms.Label
		Private treeViewAdv3 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
		Private treeViewAdv2 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private tabPageAdv13 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents trackBarEx2 As Syncfusion.Windows.Forms.Tools.TrackBarEx
		Private label6 As System.Windows.Forms.Label
		Private label18 As System.Windows.Forms.Label
		Private label19 As System.Windows.Forms.Label
		Private gradientLabel19 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel12 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private WithEvents trackBarEx1 As Syncfusion.Windows.Forms.Tools.TrackBarEx
		Private groupBarItem1 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private pictureBox1 As System.Windows.Forms.PictureBox

       
        
    End Class
End Namespace

