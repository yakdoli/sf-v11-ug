Imports Microsoft.VisualBasic
Imports System
Namespace CustomCaption
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
			Dim captionButton1 As New Syncfusion.Windows.Forms.Tools.CaptionButton()
			Dim toolTipInfo1 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = (CType(New Syncfusion.Windows.Forms.Tools.ToolTipInfo(), Syncfusion.Windows.Forms.Tools.ToolTipInfo))
			Dim captionButton2 As New Syncfusion.Windows.Forms.Tools.CaptionButton()
			Dim toolTipInfo2 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = (CType(New Syncfusion.Windows.Forms.Tools.ToolTipInfo(), Syncfusion.Windows.Forms.Tools.ToolTipInfo))
			Dim captionButton3 As New Syncfusion.Windows.Forms.Tools.CaptionButton()
			Dim toolTipInfo3 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = (CType(New Syncfusion.Windows.Forms.Tools.ToolTipInfo(), Syncfusion.Windows.Forms.Tools.ToolTipInfo))
			Dim captionButton4 As New Syncfusion.Windows.Forms.Tools.CaptionButton()
			Dim toolTipInfo4 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = (CType(New Syncfusion.Windows.Forms.Tools.ToolTipInfo(), Syncfusion.Windows.Forms.Tools.ToolTipInfo))
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim ccblabel1 As New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Dim ccbtreeViewAdv1 As New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Dim ccbGroupBar1 As New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Dim ccbpropertyGrid1 As New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.superToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
			Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
			Me.GroupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.groupView1 = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.groupView2 = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.groupView3 = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.gvcGeneral = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.gvcComponents = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem4 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem5 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
			Me.label1 = New System.Windows.Forms.Label()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.colorDialog1 = New System.Windows.Forms.ColorDialog()
			Me.xpToolBar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.staticBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem()
			Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.inactiveCaptionBack = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.activeCaptionBack = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.inactiveCaptionFore = New System.Windows.Forms.ToolStripButton()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.activeCaptionFore = New System.Windows.Forms.ToolStripButton()
			Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.GroupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.GroupBar1.SuspendLayout()
			CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolStripEx1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dockingManager1
			' 
			Me.dockingManager1.ActiveCaptionFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			captionButton1.ImageIndex = 0
			captionButton1.Name = "CloseButton"
			toolTipInfo1.Body.Hidden = True
			toolTipInfo1.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo1.Footer.Hidden = True
			toolTipInfo1.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo1.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo1.Header.Text = "Close"
			toolTipInfo1.Separator = False
			captionButton1.SuperToolTipInfo = toolTipInfo1
			captionButton1.ToolTip = "Close"
			captionButton1.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close
			captionButton2.ImageIndex = 15
			captionButton2.Name = "PinButton"
			toolTipInfo2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))))
			toolTipInfo2.Body.Hidden = True
			toolTipInfo2.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo2.Footer.Hidden = True
			toolTipInfo2.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo2.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo2.Header.Text = "Auto Hide"
			toolTipInfo2.Separator = False
			captionButton2.SuperToolTipInfo = toolTipInfo2
			captionButton2.ToolTip = "Auto Hide"
			captionButton2.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin
			captionButton3.ImageIndex = 2
			captionButton3.Name = "MenuButton"
			toolTipInfo3.BackColor = System.Drawing.Color.Teal
			toolTipInfo3.Body.Hidden = True
			toolTipInfo3.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo3.Footer.Hidden = True
			toolTipInfo3.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo3.Header.Size = New System.Drawing.Size(20, 20)
			toolTipInfo3.Header.Text = "Context" & Constants.vbCrLf & "Menu"
			toolTipInfo3.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			toolTipInfo3.Separator = False
			captionButton3.SuperToolTipInfo = toolTipInfo3
			captionButton3.ToolTip = "Window Position"
			captionButton3.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu
			captionButton4.ImageIndex = 3
			captionButton4.Name = "MaximizeButton"
			toolTipInfo4.Body.Size = New System.Drawing.Size(20, 20)
			toolTipInfo4.Footer.Size = New System.Drawing.Size(20, 20)
			toolTipInfo4.Header.Size = New System.Drawing.Size(20, 20)
			captionButton4.SuperToolTipInfo = toolTipInfo4
			captionButton4.ToolTip = "Maximize"
			captionButton4.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize
			Me.dockingManager1.CaptionButtons.Add(captionButton1)
			Me.dockingManager1.CaptionButtons.Add(captionButton2)
			Me.dockingManager1.CaptionButtons.Add(captionButton3)
			Me.dockingManager1.CaptionButtons.Add(captionButton4)
			Me.dockingManager1.ShowCustomButtonsInFloating = True
			Me.dockingManager1.DockLayoutStream = (CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream))
			Me.dockingManager1.EnableSuperToolTip = True
			Me.dockingManager1.HostControl = Me
			Me.dockingManager1.ImageList = Me.imageList1
			Me.dockingManager1.InActiveCaptionFont = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.dockingManager1.ReduceFlickeringInRtl = False
			Me.dockingManager1.SuperToolTip = Me.superToolTip1
			Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.dockingManager1.SetDockLabel(Me.label1, "Find Results")
			Me.dockingManager1.SetDockIcon(Me.label1, 3)
			Me.dockingManager1.SetEnableDocking(Me.label1, True)
			ccblabel1.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.label1, ccblabel1)
			Me.dockingManager1.SetDockLabel(Me.treeViewAdv1, "Solution Explorer")
			Me.dockingManager1.SetDockIcon(Me.treeViewAdv1, 10)
			Me.dockingManager1.SetEnableDocking(Me.treeViewAdv1, True)
			ccbtreeViewAdv1.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.treeViewAdv1, ccbtreeViewAdv1)
			Me.dockingManager1.SetDockLabel(Me.GroupBar1, "ToolBox")
			Me.dockingManager1.SetDockIcon(Me.GroupBar1, 11)
			Me.dockingManager1.SetEnableDocking(Me.GroupBar1, True)
			ccbGroupBar1.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.GroupBar1, ccbGroupBar1)
			Me.dockingManager1.SetDockLabel(Me.propertyGrid1, "Properties")
			Me.dockingManager1.SetDockIcon(Me.propertyGrid1, 14)
			Me.dockingManager1.SetEnableDocking(Me.propertyGrid1, True)
			ccbpropertyGrid1.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.propertyGrid1, ccbpropertyGrid1)
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "panels_new3_close.ico")
			Me.imageList1.Images.SetKeyName(1, "panels_new3_autohide1.ico")
			Me.imageList1.Images.SetKeyName(2, "panels_new3_menu.ico")
			Me.imageList1.Images.SetKeyName(3, "panels_new1_restore2.ico")
			Me.imageList1.Images.SetKeyName(4, "previous_icon_16.png")
			Me.imageList1.Images.SetKeyName(5, "next_icon_16.png")
			Me.imageList1.Images.SetKeyName(6, "minus.png")
			Me.imageList1.Images.SetKeyName(7, "plus.png")
			Me.imageList1.Images.SetKeyName(8, "information.png")
			Me.imageList1.Images.SetKeyName(9, "about.png")
			Me.imageList1.Images.SetKeyName(10, "window.png")
			Me.imageList1.Images.SetKeyName(11, "signpost.png")
			Me.imageList1.Images.SetKeyName(12, "unknown.png")
			Me.imageList1.Images.SetKeyName(13, "panels_new3_autohide2.png")
			Me.imageList1.Images.SetKeyName(14, "PropertiesHS.png")
			Me.imageList1.Images.SetKeyName(15, "PushpinHS.png")
			' 
			' superToolTip1
			' 
			Me.superToolTip1.InitialDelay = 100
			Me.superToolTip1.MaxWidth = 300
			Me.superToolTip1.ToolTipDuration = 32
			' 
			' treeViewAdv1
			' 
			' 
			' 
			' 
			Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(0, 0)
			Me.treeViewAdv1.HelpTextControl.Name = "helpText"
			Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(49, 15)
			Me.treeViewAdv1.HelpTextControl.TabIndex = 0
			Me.treeViewAdv1.HelpTextControl.Text = "help text"
			Me.treeViewAdv1.Location = New System.Drawing.Point(3, 23)
			Me.treeViewAdv1.Margin = New System.Windows.Forms.Padding(2)
			Me.treeViewAdv1.Name = "treeViewAdv1"
			Me.treeViewAdv1.Size = New System.Drawing.Size(188, 94)
			Me.treeViewAdv1.TabIndex = 44
			Me.treeViewAdv1.Text = "Solution Explorer"
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
			' 
			' GroupBar1
			' 
			Me.GroupBar1.AllowDrop = True
			Me.GroupBar1.AnimatedSelection = False
			Me.GroupBar1.BackColor = System.Drawing.SystemColors.Control
			Me.GroupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.GroupBar1.Controls.Add(Me.groupView1)
			Me.GroupBar1.Controls.Add(Me.groupView2)
			Me.GroupBar1.Controls.Add(Me.groupView3)
			Me.GroupBar1.Controls.Add(Me.gvcGeneral)
			Me.GroupBar1.Controls.Add(Me.gvcComponents)
			Me.GroupBar1.FlatLook = True
			Me.GroupBar1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.GroupBar1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.GroupBar1.GroupBarItemHeight = 18
			Me.GroupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.groupBarItem3, Me.groupBarItem4, Me.groupBarItem5})
			Me.GroupBar1.IndexOnVisibleItems = True
			Me.GroupBar1.Location = New System.Drawing.Point(3, 23)
			Me.GroupBar1.Name = "GroupBar1"
			Me.GroupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.GroupBar1.SelectedItem = 1
			Me.GroupBar1.Size = New System.Drawing.Size(191, 128)
			Me.GroupBar1.TabIndex = 60
			Me.GroupBar1.Text = "groupBar2"
			Me.GroupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.GroupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' groupView1
			' 
			Me.groupView1.AllowDragDrop = True
			Me.groupView1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.groupView1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.groupView1.ButtonView = True
			Me.groupView1.FlatLook = True
			Me.groupView1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupView1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.groupView1.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("FileSystemWatcher", 22, True, Nothing, "FileSystemWatcher"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("EventLog", 23, True, Nothing, "EventLog"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectoryEntry", 24, True, Nothing, "DirectoryEntry"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectorySearcher", 25, True, Nothing, "DirectorySearcher"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 26, True, Nothing, "MessageQueue")})
			Me.groupView1.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(194))))))
			Me.groupView1.IntegratedScrolling = True
			Me.groupView1.ItemYSpacing = 1
			Me.groupView1.Location = New System.Drawing.Point(1, 37)
			Me.groupView1.Name = "groupView1"
			Me.groupView1.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(62))))))
			Me.groupView1.SelectedItem = 0
			Me.groupView1.SelectedItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.groupView1.SelectingItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.groupView1.Size = New System.Drawing.Size(189, 72)
			Me.groupView1.SmallImageView = True
			Me.groupView1.TabIndex = 6
			Me.groupView1.Text = "groupViewControl4"
			' 
			' groupView2
			' 
			Me.groupView2.AllowDragDrop = True
			Me.groupView2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.groupView2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.groupView2.ButtonView = True
			Me.groupView2.FlatLook = True
			Me.groupView2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupView2.ForeColor = System.Drawing.SystemColors.ControlText
			Me.groupView2.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12, True, Nothing, "Label"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13, True, Nothing, "LinkLabel"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 14, True, Nothing, "Button"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 15, True, Nothing, "TextBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 16, True, Nothing, "MainMenu"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 17, True, Nothing, "CheckBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 18, True, Nothing, "RadioButton")})
			Me.groupView2.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(194))))))
			Me.groupView2.ImageSpacing = 5
			Me.groupView2.IntegratedScrolling = True
			Me.groupView2.ItemXSpacing = 0
			Me.groupView2.ItemYSpacing = 0
			Me.groupView2.Location = New System.Drawing.Point(1, 55)
			Me.groupView2.Name = "groupView2"
			Me.groupView2.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(62))))))
			Me.groupView2.SelectedItem = 0
			Me.groupView2.SelectedItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.groupView2.SelectingItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.groupView2.Size = New System.Drawing.Size(218, 244)
			Me.groupView2.SmallImageView = True
			Me.groupView2.TabIndex = 7
			Me.groupView2.Text = "groupViewControl5"
			' 
			' groupView3
			' 
			Me.groupView3.AllowDragAnyObject = True
			Me.groupView3.AllowDragDrop = True
			Me.groupView3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.groupView3.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.groupView3.ButtonView = True
			Me.groupView3.FlatLook = True
			Me.groupView3.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupView3.ForeColor = System.Drawing.SystemColors.ControlText
			Me.groupView3.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12, True, Nothing, "Label"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13, True, Nothing, "LinkLabel"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 14, True, Nothing, "Button"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 15, True, Nothing, "TextBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 16, True, Nothing, "MainMenu"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 17, True, Nothing, "CheckBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 18, True, Nothing, "RadioButton"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("GroupBox", 19, True, Nothing, "GroupBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("PictureBox", 20, True, Nothing, "PictureBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DataGrid", 21, True, Nothing, "DataGrid")})
			Me.groupView3.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(194))))))
			Me.groupView3.IntegratedScrolling = True
			Me.groupView3.ItemYSpacing = 1
			Me.groupView3.Location = New System.Drawing.Point(1, 19)
			Me.groupView3.Name = "groupView3"
			Me.groupView3.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(62))))))
			Me.groupView3.SelectedItem = 0
			Me.groupView3.SelectedItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.groupView3.SelectingItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.groupView3.Size = New System.Drawing.Size(177, 146)
			Me.groupView3.SmallImageView = True
			Me.groupView3.TabIndex = 5
			Me.groupView3.Text = "groupViewControl3"
			' 
			' gvcGeneral
			' 
			Me.gvcGeneral.AllowDragDrop = True
			Me.gvcGeneral.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(227))))))
			Me.gvcGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gvcGeneral.ButtonView = True
			Me.gvcGeneral.FlatLook = True
			Me.gvcGeneral.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gvcGeneral.ForeColor = System.Drawing.SystemColors.ControlText
			Me.gvcGeneral.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12, True, Nothing, "Label"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13, True, Nothing, "LinkLabel"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 14, True, Nothing, "Button"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 15, True, Nothing, "TextBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 16, True, Nothing, "MainMenu"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 17, True, Nothing, "CheckBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 18, True, Nothing, "RadioButton")})
			Me.gvcGeneral.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(194))))))
			Me.gvcGeneral.HighlightText = False
			Me.gvcGeneral.ImageSpacing = 5
			Me.gvcGeneral.IntegratedScrolling = True
			Me.gvcGeneral.ItemXSpacing = 0
			Me.gvcGeneral.ItemYSpacing = 0
			Me.gvcGeneral.Location = New System.Drawing.Point(1, 55)
			Me.gvcGeneral.Name = "gvcGeneral"
			Me.gvcGeneral.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(62))))))
			Me.gvcGeneral.SelectedItem = 0
			Me.gvcGeneral.SelectedItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.gvcGeneral.SelectingItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.gvcGeneral.Size = New System.Drawing.Size(0, 0)
			Me.gvcGeneral.SmallImageView = True
			Me.gvcGeneral.TabIndex = 4
			Me.gvcGeneral.Text = "groupViewControl5"
			' 
			' gvcComponents
			' 
			Me.gvcComponents.AllowDragDrop = True
			Me.gvcComponents.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(227))))))
			Me.gvcComponents.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gvcComponents.ButtonView = True
			Me.gvcComponents.FlatLook = True
			Me.gvcComponents.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gvcComponents.ForeColor = System.Drawing.SystemColors.ControlText
			Me.gvcComponents.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("FileSystemWatcher", 22, True, Nothing, "FileSystemWatcher"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("EventLog", 23, True, Nothing, "EventLog"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectoryEntry", 24, True, Nothing, "DirectoryEntry"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectorySearcher", 25, True, Nothing, "DirectorySearcher"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 26, True, Nothing, "MessageQueue")})
			Me.gvcComponents.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(194))))))
			Me.gvcComponents.IntegratedScrolling = True
			Me.gvcComponents.ItemYSpacing = 1
			Me.gvcComponents.Location = New System.Drawing.Point(1, 37)
			Me.gvcComponents.Name = "gvcComponents"
			Me.gvcComponents.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(62))))))
			Me.gvcComponents.SelectedItem = 0
			Me.gvcComponents.SelectedItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.gvcComponents.SelectingItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.gvcComponents.Size = New System.Drawing.Size(245, 0)
			Me.gvcComponents.SmallImageView = True
			Me.gvcComponents.TabIndex = 4
			Me.gvcComponents.Text = "groupViewControl4"
			' 
			' groupBarItem3
			' 
			Me.groupBarItem3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(219))))), (CInt(Fix((CByte(230))))), (CInt(Fix((CByte(244))))))
			Me.groupBarItem3.Client = Me.groupView3
			Me.groupBarItem3.Text = "Windows Forms"
			' 
			' groupBarItem4
			' 
			Me.groupBarItem4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(219))))), (CInt(Fix((CByte(230))))), (CInt(Fix((CByte(244))))))
			Me.groupBarItem4.Client = Me.groupView1
			Me.groupBarItem4.Text = "Components"
			' 
			' groupBarItem5
			' 
			Me.groupBarItem5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(219))))), (CInt(Fix((CByte(230))))), (CInt(Fix((CByte(244))))))
			Me.groupBarItem5.Client = Me.groupView2
			Me.groupBarItem5.Text = "General"
			' 
			' propertyGrid1
			' 
			Me.propertyGrid1.HelpBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.propertyGrid1.HelpVisible = False
			Me.propertyGrid1.Location = New System.Drawing.Point(3, 23)
			Me.propertyGrid1.Name = "propertyGrid1"
			Me.propertyGrid1.Size = New System.Drawing.Size(188, 169)
			Me.propertyGrid1.TabIndex = 146
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.label1.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
			Me.label1.ImageList = Me.imageList2
			Me.label1.Location = New System.Drawing.Point(3, 23)
			Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(461, 135)
			Me.label1.TabIndex = 21
			Me.label1.Text = resources.GetString("label1.Text")
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList2.Images.SetKeyName(0, "window.png")
			Me.imageList2.Images.SetKeyName(1, "signpost.png")
			Me.imageList2.Images.SetKeyName(2, "unknown.png")
			' 
			' xpToolBar1
			' 
			Me.xpToolBar1.BackColor = System.Drawing.Color.Transparent
			' 
			' 
			' 
			Me.xpToolBar1.Bar.BarName = ""
			Me.xpToolBar1.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem2, Me.barItem3, Me.staticBarItem1, Me.comboBoxBarItem1, Me.barItem4})
			Me.xpToolBar1.Bar.Manager = Nothing
			Me.xpToolBar1.Bar.SeparatorIndices.AddRange(New Integer() { 1, 2, 3})
			Me.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpToolBar1.Location = New System.Drawing.Point(0, 0)
			Me.xpToolBar1.Name = "xpToolBar1"
			Me.xpToolBar1.SeparatorIndices.AddRange(New Integer() { 1, 2, 3})
			Me.xpToolBar1.Size = New System.Drawing.Size(665, 53)
			Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
			Me.xpToolBar1.TabIndex = 146
			Me.xpToolBar1.Text = "xpToolBar1"
			' 
			' barItem1
			' 
			Me.barItem1.Checked = True
			Me.barItem1.ID = "Show &Caption"
			Me.barItem1.Text = "Show &Caption"
'			Me.barItem1.Click += New System.EventHandler(Me.ShowCaptionClick)
			' 
			' barItem2
			' 
			Me.barItem2.Checked = True
			Me.barItem2.ID = "Show Caption &Images"
			Me.barItem2.Text = "Show Caption &Images"
'			Me.barItem2.Click += New System.EventHandler(Me.ShowCaptionImageClick)
			' 
			' barItem3
			' 
			Me.barItem3.Checked = True
			Me.barItem3.ID = "Show &Caption"
			Me.barItem3.Text = "Enable Super&ToolTip"
'			Me.barItem3.Click += New System.EventHandler(Me.EnableSuperToolTipClick)
			' 
			' staticBarItem1
			' 
			Me.staticBarItem1.ID = "VisualStyles"
			Me.staticBarItem1.Text = "Visual Styles"
			' 
			' comboBoxBarItem1
			' 
			Me.comboBoxBarItem1.Editable = False
			Me.comboBoxBarItem1.ID = "Styles"
			Me.comboBoxBarItem1.ListBox = Me.listBox1
			Me.comboBoxBarItem1.MinWidth = 100
			Me.comboBoxBarItem1.Text = "Styles"
			' 
			' listBox1
			' 
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.Items.AddRange(New Object() { "Default", "Office2003", "VS2005", "Office2007", "Office2007Outlook"})
			Me.listBox1.Location = New System.Drawing.Point(533, 109)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(100, 69)
			Me.listBox1.TabIndex = 148
			' 
			' toolStripEx1
			' 
			Me.toolStripEx1.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.Etched
			Me.toolStripEx1.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Bottom
			Me.toolStripEx1.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Etched
			Me.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx1.Image = Nothing
			Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.inactiveCaptionBack, Me.toolStripSeparator1, Me.activeCaptionBack, Me.toolStripSeparator2, Me.inactiveCaptionFore, Me.toolStripSeparator3, Me.activeCaptionFore})
			Me.toolStripEx1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
			Me.toolStripEx1.Location = New System.Drawing.Point(0, 53)
			Me.toolStripEx1.Name = "toolStripEx1"
			Me.toolStripEx1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue
			Me.toolStripEx1.ShowCaption = True
			Me.toolStripEx1.ShowLauncher = False
			Me.toolStripEx1.Size = New System.Drawing.Size(665, 44)
			Me.toolStripEx1.TabIndex = 147
			Me.toolStripEx1.Text = "--Applicable if VisualStyle is default--"
			' 
			' inactiveCaptionBack
			' 
			Me.inactiveCaptionBack.Image = (CType(resources.GetObject("inactiveCaptionBack.Image"), System.Drawing.Image))
			Me.inactiveCaptionBack.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.inactiveCaptionBack.Name = "inactiveCaptionBack"
			Me.inactiveCaptionBack.Size = New System.Drawing.Size(180, 22)
			Me.inactiveCaptionBack.Text = "Inactive Caption Background"
'			Me.inactiveCaptionBack.Click += New System.EventHandler(Me.InActiveCaptionBackGround_ButtonClicked)
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
			' 
			' activeCaptionBack
			' 
			Me.activeCaptionBack.Image = (CType(resources.GetObject("activeCaptionBack.Image"), System.Drawing.Image))
			Me.activeCaptionBack.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.activeCaptionBack.Name = "activeCaptionBack"
			Me.activeCaptionBack.Size = New System.Drawing.Size(172, 22)
			Me.activeCaptionBack.Text = "Active Caption Background"
'			Me.activeCaptionBack.Click += New System.EventHandler(Me.activeCaptionBack_Click)
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
			' 
			' inactiveCaptionFore
			' 
			Me.inactiveCaptionFore.Image = (CType(resources.GetObject("inactiveCaptionFore.Image"), System.Drawing.Image))
			Me.inactiveCaptionFore.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.inactiveCaptionFore.Name = "inactiveCaptionFore"
			Me.inactiveCaptionFore.Size = New System.Drawing.Size(178, 22)
			Me.inactiveCaptionFore.Text = "Inactive Caption Foreground"
'			Me.inactiveCaptionFore.Click += New System.EventHandler(Me.inactiveCaptionFore_Click)
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
			' 
			' activeCaptionFore
			' 
			Me.activeCaptionFore.Image = (CType(resources.GetObject("activeCaptionFore.Image"), System.Drawing.Image))
			Me.activeCaptionFore.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.activeCaptionFore.Name = "activeCaptionFore"
			Me.activeCaptionFore.Size = New System.Drawing.Size(170, 20)
			Me.activeCaptionFore.Text = "Active Caption Foreground"
'			Me.activeCaptionFore.Click += New System.EventHandler(Me.activeCaptionFore_Click)
			' 
			' barItem4
			' 
			Me.barItem4.ID = "Show CustomButton In Floating"
			Me.barItem4.Text = "Show Caption in Floating"
'			Me.barItem4.Click += New System.EventHandler(ShowCaptionInFloating_Click)
			Me.barItem4.Checked = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(241))))), (CInt(Fix((CByte(244))))), (CInt(Fix((CByte(254))))))
			Me.ClientSize = New System.Drawing.Size(665, 416)
			Me.Controls.Add(Me.toolStripEx1)
			Me.Controls.Add(Me.xpToolBar1)
			Me.Controls.Add(Me.listBox1)
			Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Custom Caption"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.GroupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.GroupBar1.ResumeLayout(False)
			CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolStripEx1.ResumeLayout(False)
			Me.toolStripEx1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Public dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
		Private superToolTip1 As Syncfusion.Windows.Forms.Tools.SuperToolTip
		Private label1 As System.Windows.Forms.Label
		Private imageList1 As System.Windows.Forms.ImageList
		Private imageList2 As System.Windows.Forms.ImageList
		Private treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv

		Private GroupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
		Private gvcGeneral As Syncfusion.Windows.Forms.Tools.GroupView
		Private gvcComponents As Syncfusion.Windows.Forms.Tools.GroupView
		Private groupBarItem3 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem4 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem5 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupView3 As Syncfusion.Windows.Forms.Tools.GroupView
		Private groupView2 As Syncfusion.Windows.Forms.Tools.GroupView
		Private groupView1 As Syncfusion.Windows.Forms.Tools.GroupView
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private xpToolBar1 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private toolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private WithEvents inactiveCaptionBack As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents activeCaptionBack As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents activeCaptionFore As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents inactiveCaptionFore As System.Windows.Forms.ToolStripButton
		Private staticBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
		Private comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private listBox1 As System.Windows.Forms.ListBox
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
	End Class
End Namespace

