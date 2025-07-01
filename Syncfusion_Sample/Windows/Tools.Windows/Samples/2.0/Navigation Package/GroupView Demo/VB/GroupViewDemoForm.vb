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
	Imports System.Diagnostics
	Imports Syncfusion.Windows.Forms.Tools
	Imports Syncfusion.Windows.Forms.Tools.XPMenus
	Imports Syncfusion.Windows.Forms
	Imports System.IO
Namespace GroupViewDemo

	Public Class GroupViewDemoForm : Inherits Office2007Form
		#Region "Private Members"
		Private ilGroupBarSmall As System.Windows.Forms.ImageList
		Private ilGroupBarLarge As System.Windows.Forms.ImageList
		Private gvModes As Syncfusion.Windows.Forms.Tools.GroupView
		Public WithEvents rbLargeIcons As System.Windows.Forms.RadioButton
		Public WithEvents rbSmallIcons As System.Windows.Forms.RadioButton
		Public WithEvents rbVSNETList As System.Windows.Forms.RadioButton
		Public WithEvents rbVSNETFlow As System.Windows.Forms.RadioButton
		Public WithEvents rbOXPFolderBrowser As System.Windows.Forms.RadioButton
		Public WithEvents rbO2KFolderBrowser As System.Windows.Forms.RadioButton
		Public WithEvents rbMessengerList As System.Windows.Forms.RadioButton
		Public WithEvents rbXPTaskBar As System.Windows.Forms.RadioButton
		Private listView1 As System.Windows.Forms.ListView
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private imageList As System.Windows.Forms.ImageList
		Private tabControlAdv1 As TabControlAdv
		Private tabPageAdv1 As TabPageAdv
		Private tabPageAdv2 As TabPageAdv
		Private WithEvents gvMain As GroupView
		Private gpVSBehavior As GradientPanel
		Private label5 As Label
		Private WithEvents cpBackColor As ColorPickerButton
		Private panel15 As Panel
		Private label35 As Label
		Private WithEvents cbButtonView As CheckBox
		Private label2 As Label
		Private WithEvents cmbGVBorder As ComboBox
		Private WithEvents cbHighightText As CheckBox
		Private gradientPanel3 As GradientPanel
		Private panel2 As Panel
		Private label6 As Label
		Private WithEvents nUDHighlightOffset As NumericUpDownExt
		Private label11 As Label
		Private label10 As Label
		Private label9 As Label
		Private WithEvents nUDSelectedOffset As NumericUpDownExt
		Private WithEvents nUDSelectingOffset As NumericUpDownExt
		Private WithEvents nUDSelectedHighlightOffset As NumericUpDownExt
		Private label3 As Label
		Private WithEvents cbFlowView As CheckBox
		Private WithEvents nUDTextSpacing As NumericUpDownExt
		Private label12 As Label
		Private WithEvents cbTextUnderline As CheckBox
		Private WithEvents cbTextWrap As CheckBox
		Private label13 As Label
		Private label14 As Label
		Private label15 As Label
		Private label16 As Label
		Private WithEvents cpHighlightItem As ColorPickerButton
		Private WithEvents cpHighlightText As ColorPickerButton
		Private splitter1 As Splitter
		Private WithEvents cpselectedHlItem As ColorPickerButton
		Private WithEvents cpSelectedTextColor As ColorPickerButton
		Private WithEvents cpSelectedItemColor As ColorPickerButton
		Private label17 As Label
		Private label18 As Label
		Private WithEvents cbToolTips As CheckBox
		Private WithEvents cbFlowViewItemText As CheckBox
		Private WithEvents numericUpDownExt1 As NumericUpDownExt
		Private label19 As Label
		Private WithEvents cbIntegratedScrolling As CheckBox
		Private label20 As Label
		Private WithEvents cmbOrientation As ComboBox
		Private WithEvents cbThemesEnabled As CheckBox
		Private tabPageAdv3 As TabPageAdv
		Private WithEvents gvFeatures As CustomGroupView
		Private label1 As Label
		Private gradientPanel5 As GradientPanel
		Private panel3 As Panel
		Private label22 As Label
		Private WithEvents cbHighlightImage As CheckBox
		Private gradientPanel6 As GradientPanel
		Private WithEvents button1 As Button
		Private gradientPanel2 As GradientPanel
		Private gradientPanelExt1 As GradientPanelExt
		Private WithEvents timer1 As Timer
		Private richTextBox1 As RichTextBox
		Private panel1 As Panel
		Private WithEvents cpSelectedHlText As ColorPickerButton
		Private gradientPanel1 As GradientPanel
		Private label40 As Label
		Private label7 As Label
		Private scrollersFrame1 As ScrollersFrame
		Private panel4 As Panel
		Private panel6 As Panel
		Private panel5 As Panel
		Private panel7 As Panel
		Private panel8 As Panel
		Private gradientPanel4 As GradientPanel
		Private components As System.ComponentModel.IContainer = Nothing
		#End Region

		#Region "Form's Constructor, Main And Dispose"
		Public Sub New()
			' This call is required by the Windows Form Designer.
			InitializeComponent()
			Me.cmbOrientation.SelectedIndex = 1
			Me.cmbGVBorder.SelectedIndex = 2
			Me.rbO2KFolderBrowser.Checked = True
			Me.gradientPanelExt1.Size = New Size(172, 505)
			Me.cbHighightText.Checked = True
			Me.cbHighlightImage.Checked = True
			Me.cbButtonView.Checked = True
			Me.cbIntegratedScrolling.Checked = True

			Me.richTextBox1.Text = ""
			Dim path As String = Application.StartupPath.ToString() & "..\..\..\GroupView_Features.rtf"
			If File.Exists(path) Then
				Me.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText)
			End If

		End Sub
		Public ReadOnly Property GroupView() As GroupView
			Get
				Return Me.gvModes
			End Get
		End Property
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New GroupViewDemoForm())
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

		#Region "Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GroupViewDemoForm))
			Me.ilGroupBarLarge = New System.Windows.Forms.ImageList(Me.components)
			Me.ilGroupBarSmall = New System.Windows.Forms.ImageList(Me.components)
			Me.gvModes = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.rbXPTaskBar = New System.Windows.Forms.RadioButton()
			Me.rbMessengerList = New System.Windows.Forms.RadioButton()
			Me.rbOXPFolderBrowser = New System.Windows.Forms.RadioButton()
			Me.rbO2KFolderBrowser = New System.Windows.Forms.RadioButton()
			Me.rbVSNETFlow = New System.Windows.Forms.RadioButton()
			Me.rbVSNETList = New System.Windows.Forms.RadioButton()
			Me.rbSmallIcons = New System.Windows.Forms.RadioButton()
			Me.rbLargeIcons = New System.Windows.Forms.RadioButton()
			Me.listView1 = New System.Windows.Forms.ListView()
			Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
			Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
			Me.imageList = New System.Windows.Forms.ImageList(Me.components)
			Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.splitter1 = New System.Windows.Forms.Splitter()
			Me.gvMain = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.panel6 = New System.Windows.Forms.Panel()
			Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.label6 = New System.Windows.Forms.Label()
			Me.panel5 = New System.Windows.Forms.Panel()
			Me.gpVSBehavior = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.label1 = New System.Windows.Forms.Label()
			Me.cbIntegratedScrolling = New System.Windows.Forms.CheckBox()
			Me.cbFlowViewItemText = New System.Windows.Forms.CheckBox()
			Me.cbToolTips = New System.Windows.Forms.CheckBox()
			Me.cbFlowView = New System.Windows.Forms.CheckBox()
			Me.panel15 = New System.Windows.Forms.Panel()
			Me.label35 = New System.Windows.Forms.Label()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.gradientPanel5 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.cpSelectedHlText = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.cbHighlightImage = New System.Windows.Forms.CheckBox()
			Me.cpSelectedTextColor = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label20 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.cpBackColor = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.cbTextUnderline = New System.Windows.Forms.CheckBox()
			Me.cmbOrientation = New System.Windows.Forms.ComboBox()
			Me.label14 = New System.Windows.Forms.Label()
			Me.cbTextWrap = New System.Windows.Forms.CheckBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.cbThemesEnabled = New System.Windows.Forms.CheckBox()
			Me.nUDTextSpacing = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
			Me.cbButtonView = New System.Windows.Forms.CheckBox()
			Me.nUDSelectedHighlightOffset = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
			Me.cbHighightText = New System.Windows.Forms.CheckBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.cmbGVBorder = New System.Windows.Forms.ComboBox()
			Me.nUDSelectedOffset = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
			Me.numericUpDownExt1 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
			Me.nUDSelectingOffset = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label16 = New System.Windows.Forms.Label()
			Me.label19 = New System.Windows.Forms.Label()
			Me.nUDHighlightOffset = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt()
			Me.cpHighlightText = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label11 = New System.Windows.Forms.Label()
			Me.cpselectedHlItem = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label18 = New System.Windows.Forms.Label()
			Me.cpSelectedItemColor = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label17 = New System.Windows.Forms.Label()
			Me.cpHighlightItem = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label13 = New System.Windows.Forms.Label()
			Me.label15 = New System.Windows.Forms.Label()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.label22 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.panel7 = New System.Windows.Forms.Panel()
			Me.panel8 = New System.Windows.Forms.Panel()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label40 = New System.Windows.Forms.Label()
			Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.gradientPanelExt1 = New Syncfusion.Windows.Forms.Tools.GradientPanelExt()
			Me.gvFeatures = New GroupViewDemo.CustomGroupView()
			Me.gradientPanel6 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.scrollersFrame1 = New Syncfusion.Windows.Forms.ScrollersFrame(Me.components)
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControlAdv1.SuspendLayout()
			Me.tabPageAdv1.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.panel6.SuspendLayout()
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel3.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.panel5.SuspendLayout()
			CType(Me.gpVSBehavior, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gpVSBehavior.SuspendLayout()
			Me.panel15.SuspendLayout()
			Me.panel4.SuspendLayout()
			CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel5.SuspendLayout()
			CType(Me.nUDTextSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nUDSelectedHighlightOffset, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nUDSelectedOffset, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nUDSelectingOffset, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nUDHighlightOffset, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			Me.tabPageAdv2.SuspendLayout()
			Me.panel7.SuspendLayout()
			Me.panel8.SuspendLayout()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel2.SuspendLayout()
			Me.tabPageAdv3.SuspendLayout()
			CType(Me.gradientPanelExt1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanelExt1.SuspendLayout()
			CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel6.SuspendLayout()
			CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel4.SuspendLayout()
			Me.SuspendLayout()
			' 
			' ilGroupBarLarge
			' 
			Me.ilGroupBarLarge.ImageStream = (CType(resources.GetObject("ilGroupBarLarge.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ilGroupBarLarge.TransparentColor = System.Drawing.Color.Transparent
			Me.ilGroupBarLarge.Images.SetKeyName(0, "")
			Me.ilGroupBarLarge.Images.SetKeyName(1, "")
			Me.ilGroupBarLarge.Images.SetKeyName(2, "")
			Me.ilGroupBarLarge.Images.SetKeyName(3, "")
			Me.ilGroupBarLarge.Images.SetKeyName(4, "")
			Me.ilGroupBarLarge.Images.SetKeyName(5, "")
			Me.ilGroupBarLarge.Images.SetKeyName(6, "")
			Me.ilGroupBarLarge.Images.SetKeyName(7, "")
			Me.ilGroupBarLarge.Images.SetKeyName(8, "")
			Me.ilGroupBarLarge.Images.SetKeyName(9, "")
			Me.ilGroupBarLarge.Images.SetKeyName(10, "")
			Me.ilGroupBarLarge.Images.SetKeyName(11, "")
			Me.ilGroupBarLarge.Images.SetKeyName(12, "")
			Me.ilGroupBarLarge.Images.SetKeyName(13, "")
			Me.ilGroupBarLarge.Images.SetKeyName(14, "")
			Me.ilGroupBarLarge.Images.SetKeyName(15, "")
			Me.ilGroupBarLarge.Images.SetKeyName(16, "")
			Me.ilGroupBarLarge.Images.SetKeyName(17, "")
			Me.ilGroupBarLarge.Images.SetKeyName(18, "")
			' 
			' ilGroupBarSmall
			' 
			Me.ilGroupBarSmall.ImageStream = (CType(resources.GetObject("ilGroupBarSmall.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ilGroupBarSmall.TransparentColor = System.Drawing.Color.Transparent
			Me.ilGroupBarSmall.Images.SetKeyName(0, "")
			Me.ilGroupBarSmall.Images.SetKeyName(1, "")
			Me.ilGroupBarSmall.Images.SetKeyName(2, "")
			Me.ilGroupBarSmall.Images.SetKeyName(3, "")
			Me.ilGroupBarSmall.Images.SetKeyName(4, "")
			Me.ilGroupBarSmall.Images.SetKeyName(5, "")
			Me.ilGroupBarSmall.Images.SetKeyName(6, "")
			Me.ilGroupBarSmall.Images.SetKeyName(7, "")
			Me.ilGroupBarSmall.Images.SetKeyName(8, "")
			Me.ilGroupBarSmall.Images.SetKeyName(9, "")
			Me.ilGroupBarSmall.Images.SetKeyName(10, "")
			Me.ilGroupBarSmall.Images.SetKeyName(11, "")
			Me.ilGroupBarSmall.Images.SetKeyName(12, "")
			Me.ilGroupBarSmall.Images.SetKeyName(13, "")
			Me.ilGroupBarSmall.Images.SetKeyName(14, "")
			Me.ilGroupBarSmall.Images.SetKeyName(15, "")
			Me.ilGroupBarSmall.Images.SetKeyName(16, "")
			Me.ilGroupBarSmall.Images.SetKeyName(17, "")
			Me.ilGroupBarSmall.Images.SetKeyName(18, "")
			Me.ilGroupBarSmall.Images.SetKeyName(19, "")
			Me.ilGroupBarSmall.Images.SetKeyName(20, "")
			' 
			' gvModes
			' 
			Me.gvModes.AllowDragDrop = True
			Me.gvModes.BackColor = System.Drawing.SystemColors.ControlLight
			Me.gvModes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gvModes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
			Me.gvModes.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("3½ Floppy Drive", 0, True, Nothing, "3½ Floppy Drive"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("5¼ Floppy Drive", 1, True, Nothing, "5¼ Floppy Drive"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Audio Disc", 2, True, Nothing, "Audio Disc"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CD Drive", 3, True, Nothing, "CD Drive"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Closed Folders", 4, True, Nothing, "Closed Folders"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Control Panel", 5, True, Nothing, "Control Panel"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Desktop", 6, True, Nothing, "Desktop"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Disconnected Drives", 7, True, Nothing, "Disconnected Drives"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Network Drives", 8, True, Nothing, "Network Drives"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Entire Network", 9, True, Nothing, "Entire Network"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Explorer", 10, True, Nothing, "Explorer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("My Computer", 11, True, Nothing, "My Computer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Net Hood", 12, True, Nothing, "Net Hood"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Open Folders", 13, True, Nothing, "Open Folders"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Shared Folders", 14, True, Nothing, "Shared Folders"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Full", 15, True, Nothing, "Recycle Full"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Bin", 16, True, Nothing, "Recycle Bin")})
			Me.gvModes.HighlightImage = False
			Me.gvModes.HighlightImageOffset = New System.Drawing.Point(-2, -2)
			Me.gvModes.HighlightText = False
			Me.gvModes.LargeImageList = Me.ilGroupBarLarge
			Me.gvModes.Location = New System.Drawing.Point(9, 10)
			Me.gvModes.Name = "gvModes"
			Me.gvModes.Size = New System.Drawing.Size(168, 517)
			Me.gvModes.SmallImageList = Me.ilGroupBarSmall
			Me.gvModes.SmallImageView = True
			Me.gvModes.TabIndex = 4
			' 
			' rbXPTaskBar
			' 
			Me.rbXPTaskBar.AutoSize = True
			Me.rbXPTaskBar.BackColor = System.Drawing.Color.Transparent
			Me.rbXPTaskBar.ForeColor = System.Drawing.Color.Black
			Me.rbXPTaskBar.Location = New System.Drawing.Point(19, 279)
			Me.rbXPTaskBar.Name = "rbXPTaskBar"
			Me.rbXPTaskBar.Size = New System.Drawing.Size(101, 17)
			Me.rbXPTaskBar.TabIndex = 8
			Me.rbXPTaskBar.Text = "XP TaskBar List"
			Me.rbXPTaskBar.UseVisualStyleBackColor = False
'			Me.rbXPTaskBar.CheckedChanged += New System.EventHandler(Me.rbXPTaskBar_CheckedChanged);
			' 
			' rbMessengerList
			' 
			Me.rbMessengerList.AutoSize = True
			Me.rbMessengerList.BackColor = System.Drawing.Color.Transparent
			Me.rbMessengerList.ForeColor = System.Drawing.Color.MidnightBlue
			Me.rbMessengerList.Location = New System.Drawing.Point(19, 240)
			Me.rbMessengerList.Name = "rbMessengerList"
			Me.rbMessengerList.Size = New System.Drawing.Size(163, 17)
			Me.rbMessengerList.TabIndex = 7
			Me.rbMessengerList.Text = "MSN Messenger SideBar List"
			Me.rbMessengerList.UseVisualStyleBackColor = False
'			Me.rbMessengerList.CheckedChanged += New System.EventHandler(Me.rbMessengerList_CheckedChanged);
			' 
			' rbOXPFolderBrowser
			' 
			Me.rbOXPFolderBrowser.AutoSize = True
			Me.rbOXPFolderBrowser.BackColor = System.Drawing.Color.Transparent
			Me.rbOXPFolderBrowser.ForeColor = System.Drawing.Color.Black
			Me.rbOXPFolderBrowser.Location = New System.Drawing.Point(19, 201)
			Me.rbOXPFolderBrowser.Name = "rbOXPFolderBrowser"
			Me.rbOXPFolderBrowser.Size = New System.Drawing.Size(143, 17)
			Me.rbOXPFolderBrowser.TabIndex = 6
			Me.rbOXPFolderBrowser.Text = "Office XP Folder Browser"
			Me.rbOXPFolderBrowser.UseVisualStyleBackColor = False
'			Me.rbOXPFolderBrowser.CheckedChanged += New System.EventHandler(Me.rbOXPFolderBrowser_CheckedChanged);
			' 
			' rbO2KFolderBrowser
			' 
			Me.rbO2KFolderBrowser.AutoSize = True
			Me.rbO2KFolderBrowser.BackColor = System.Drawing.Color.Transparent
			Me.rbO2KFolderBrowser.ForeColor = System.Drawing.Color.MidnightBlue
			Me.rbO2KFolderBrowser.Location = New System.Drawing.Point(19, 162)
			Me.rbO2KFolderBrowser.Name = "rbO2KFolderBrowser"
			Me.rbO2KFolderBrowser.Size = New System.Drawing.Size(153, 17)
			Me.rbO2KFolderBrowser.TabIndex = 5
			Me.rbO2KFolderBrowser.Text = "Office 2000 Folder Browser"
			Me.rbO2KFolderBrowser.UseVisualStyleBackColor = False
'			Me.rbO2KFolderBrowser.CheckedChanged += New System.EventHandler(Me.rbO2KFolderBrowser_CheckedChanged);
			' 
			' rbVSNETFlow
			' 
			Me.rbVSNETFlow.AutoSize = True
			Me.rbVSNETFlow.BackColor = System.Drawing.Color.Transparent
			Me.rbVSNETFlow.ForeColor = System.Drawing.Color.Black
			Me.rbVSNETFlow.Location = New System.Drawing.Point(19, 123)
			Me.rbVSNETFlow.Name = "rbVSNETFlow"
			Me.rbVSNETFlow.Size = New System.Drawing.Size(156, 17)
			Me.rbVSNETFlow.TabIndex = 3
			Me.rbVSNETFlow.Text = "VS.NET Toolbox Flow View"
			Me.rbVSNETFlow.UseVisualStyleBackColor = False
'			Me.rbVSNETFlow.CheckedChanged += New System.EventHandler(Me.rbVSNETFlow_CheckedChanged);
			' 
			' rbVSNETList
			' 
			Me.rbVSNETList.AutoSize = True
			Me.rbVSNETList.BackColor = System.Drawing.Color.Transparent
			Me.rbVSNETList.ForeColor = System.Drawing.Color.MidnightBlue
			Me.rbVSNETList.Location = New System.Drawing.Point(19, 84)
			Me.rbVSNETList.Name = "rbVSNETList"
			Me.rbVSNETList.Size = New System.Drawing.Size(150, 17)
			Me.rbVSNETList.TabIndex = 2
			Me.rbVSNETList.Text = "VS.NET Toolbox List View"
			Me.rbVSNETList.UseVisualStyleBackColor = False
'			Me.rbVSNETList.CheckedChanged += New System.EventHandler(Me.rbVSNETList_CheckedChanged);
			' 
			' rbSmallIcons
			' 
			Me.rbSmallIcons.AutoSize = True
			Me.rbSmallIcons.BackColor = System.Drawing.Color.Transparent
			Me.rbSmallIcons.ForeColor = System.Drawing.Color.Black
			Me.rbSmallIcons.Location = New System.Drawing.Point(19, 45)
			Me.rbSmallIcons.Name = "rbSmallIcons"
			Me.rbSmallIcons.Size = New System.Drawing.Size(156, 17)
			Me.rbSmallIcons.TabIndex = 1
			Me.rbSmallIcons.Text = "OutlookBar Small Icon View"
			Me.rbSmallIcons.UseVisualStyleBackColor = False
'			Me.rbSmallIcons.CheckedChanged += New System.EventHandler(Me.rbSmallIcons_CheckedChanged);
			' 
			' rbLargeIcons
			' 
			Me.rbLargeIcons.AutoSize = True
			Me.rbLargeIcons.BackColor = System.Drawing.Color.Transparent
			Me.rbLargeIcons.ForeColor = System.Drawing.Color.MidnightBlue
			Me.rbLargeIcons.Location = New System.Drawing.Point(19, 6)
			Me.rbLargeIcons.Name = "rbLargeIcons"
			Me.rbLargeIcons.Size = New System.Drawing.Size(158, 17)
			Me.rbLargeIcons.TabIndex = 0
			Me.rbLargeIcons.Text = "OutlookBar Large Icon View"
			Me.rbLargeIcons.UseVisualStyleBackColor = False
'			Me.rbLargeIcons.CheckedChanged += New System.EventHandler(Me.rbLargeIcons_CheckedChanged);
			' 
			' listView1
			' 
			Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.columnHeader1, Me.columnHeader2})
			Me.listView1.GridLines = True
			Me.listView1.Location = New System.Drawing.Point(4, 1)
			Me.listView1.Name = "listView1"
			Me.listView1.Size = New System.Drawing.Size(274, 173)
			Me.listView1.TabIndex = 7
			Me.listView1.UseCompatibleStateImageBehavior = False
			Me.listView1.View = System.Windows.Forms.View.Details
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Text = "Events"
			Me.columnHeader1.Width = 121
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Text = "Object"
			Me.columnHeader2.Width = 145
			' 
			' imageList
			' 
			Me.imageList.ImageStream = (CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList.Images.SetKeyName(0, "palette.png")
			Me.imageList.Images.SetKeyName(1, "font.png")
			Me.imageList.Images.SetKeyName(2, "photo_scenery.png")
			Me.imageList.Images.SetKeyName(3, "windows.png")
			Me.imageList.Images.SetKeyName(4, "note_pinned.png")
			Me.imageList.Images.SetKeyName(5, "about.png")
			Me.imageList.Images.SetKeyName(6, "element_into_input.png")
			Me.imageList.Images.SetKeyName(7, "window_sidebar.png")
			Me.imageList.Images.SetKeyName(8, "transform2.png")
			Me.imageList.Images.SetKeyName(9, "modem_earth.png")
			' 
			' tabControlAdv1
			' 
			Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdv3)
			Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabControlAdv1.Location = New System.Drawing.Point(0, 0)
			Me.tabControlAdv1.Name = "tabControlAdv1"
			Me.tabControlAdv1.Padding = New System.Drawing.Point(15, 5)
			Me.tabControlAdv1.Size = New System.Drawing.Size(790, 571)
			Me.tabControlAdv1.TabGap = 10
			Me.tabControlAdv1.TabIndex = 11
			Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb((CInt((CByte(182)))), (CInt((CByte(214)))), (CInt((CByte(246)))))
			Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
			Me.tabControlAdv1.ThemesEnabled = True
			' 
			' tabPageAdv1
			' 
			Me.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(237)))), (CInt((CByte(248)))))
			Me.tabPageAdv1.Controls.Add(Me.panel1)
			Me.tabPageAdv1.Location = New System.Drawing.Point(2, 34)
			Me.tabPageAdv1.Name = "tabPageAdv1"
			Me.tabPageAdv1.Size = New System.Drawing.Size(786, 535)
			Me.tabPageAdv1.TabIndex = 1
			Me.tabPageAdv1.Text = "GroupView Properties"
			Me.tabPageAdv1.ThemesEnabled = False
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(237)))), (CInt((CByte(248)))))
			Me.panel1.Controls.Add(Me.splitter1)
			Me.panel1.Controls.Add(Me.gvMain)
			Me.panel1.Controls.Add(Me.panel6)
			Me.panel1.Controls.Add(Me.panel5)
			Me.panel1.Controls.Add(Me.panel4)
			Me.panel1.Controls.Add(Me.button1)
			Me.panel1.Location = New System.Drawing.Point(7, 6)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(772, 521)
			Me.panel1.TabIndex = 203
			' 
			' splitter1
			' 
			Me.splitter1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(199)))), (CInt((CByte(216)))), (CInt((CByte(237)))))
			Me.splitter1.Location = New System.Drawing.Point(168, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(2, 521)
			Me.splitter1.TabIndex = 200
			Me.splitter1.TabStop = False
			' 
			' gvMain
			' 
			Me.gvMain.AllowDragDrop = True
			Me.gvMain.BackColor = System.Drawing.SystemColors.ControlLight
			Me.gvMain.Dock = System.Windows.Forms.DockStyle.Left
			Me.gvMain.ForeColor = System.Drawing.Color.Black
			Me.gvMain.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("3½ Floppy Drive", 0, True, Nothing, "3½ Floppy Drive"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("5¼ Floppy Drive", 1, True, Nothing, "5¼ Floppy Drive"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Audio Disc", 2, True, Nothing, "Audio Disc"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CD Drive", 3, True, Nothing, "CD Drive"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Closed Folders", 4, True, Nothing, "Closed Folders"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Control Panel", 5, True, Nothing, "Control Panel"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Desktop", 6, True, Nothing, "Desktop"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Disconnected Drives", 7, True, Nothing, "Disconnected Drives"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Network Drives", 8, True, Nothing, "Network Drives"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Entire Network", 9, True, Nothing, "Entire Network"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Explorer", 10, True, Nothing, "Explorer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("My Computer", 11, True, Nothing, "My Computer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Net Hood", 12, True, Nothing, "Net Hood"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Open Folders", 13, True, Nothing, "Open Folders"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Shared Folders", 14, True, Nothing, "Shared Folders"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Full", 15, True, Nothing, "Recycle Full"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Recycle Bin", 16, True, Nothing, "Recycle Bin")})
			Me.gvMain.HighlightImageOffset = New System.Drawing.Point(-2, -2)
			Me.gvMain.HighlightText = False
			Me.gvMain.HighlightTextColor = System.Drawing.Color.Brown
			Me.gvMain.ImageSpacing = 6
			Me.gvMain.IntegratedScrolling = True
			Me.gvMain.LargeImageList = Me.ilGroupBarLarge
			Me.gvMain.Location = New System.Drawing.Point(0, 0)
			Me.gvMain.Name = "gvMain"
			Me.gvMain.SelectedTextColor = System.Drawing.Color.SaddleBrown
			Me.gvMain.Size = New System.Drawing.Size(168, 521)
			Me.gvMain.SmallImageList = Me.ilGroupBarSmall
			Me.gvMain.SmallImageView = True
			Me.gvMain.TabIndex = 8
'			Me.gvMain.ShowContextMenu += New System.EventHandler(Me.gvc_ShowContextMenu);
'			Me.gvMain.GroupViewItemsReordered += New System.EventHandler(Me.gvcWinForms_GroupViewItemsReordered);
'			Me.gvMain.GroupViewItemRenamed += New Syncfusion.Windows.Forms.Tools.GroupItemRenamedEventHandler(Me.gvcWinForms_GroupViewItemRenamed);
'			Me.gvMain.GroupViewItemSelected += New System.EventHandler(Me.gvcWinForms_GroupViewItemSelected);
			' 
			' panel6
			' 
			Me.panel6.BackColor = System.Drawing.Color.Transparent
			Me.panel6.Controls.Add(Me.gradientPanel3)
			Me.panel6.Controls.Add(Me.panel2)
			Me.panel6.Location = New System.Drawing.Point(483, 275)
			Me.panel6.Name = "panel6"
			Me.panel6.Size = New System.Drawing.Size(285, 210)
			Me.panel6.TabIndex = 205
			' 
			' gradientPanel3
			' 
			Me.gradientPanel3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(165)))), (CInt((CByte(205)))), (CInt((CByte(246)))))
			Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(227)))), (CInt((CByte(246)))))
			Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel3.Controls.Add(Me.listView1)
			Me.gradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gradientPanel3.Location = New System.Drawing.Point(0, 30)
			Me.gradientPanel3.Name = "gradientPanel3"
			Me.gradientPanel3.Size = New System.Drawing.Size(285, 180)
			Me.gradientPanel3.TabIndex = 199
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(223)))), (CInt((CByte(236)))), (CInt((CByte(254)))))
			Me.panel2.BackgroundImage = (CType(resources.GetObject("panel2.BackgroundImage"), System.Drawing.Image))
			Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.panel2.Controls.Add(Me.label6)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(285, 30)
			Me.panel2.TabIndex = 157
			' 
			' label6
			' 
			Me.label6.BackColor = System.Drawing.Color.Transparent
			Me.label6.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label6.Image = (CType(resources.GetObject("label6.Image"), System.Drawing.Image))
			Me.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label6.Location = New System.Drawing.Point(10, 2)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(83, 19)
			Me.label6.TabIndex = 170
			Me.label6.Text = "Event Log"
			Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' panel5
			' 
			Me.panel5.Controls.Add(Me.gpVSBehavior)
			Me.panel5.Controls.Add(Me.panel15)
			Me.panel5.Location = New System.Drawing.Point(184, 277)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New System.Drawing.Size(285, 210)
			Me.panel5.TabIndex = 204
			' 
			' gpVSBehavior
			' 
			Me.gpVSBehavior.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(209)))), (CInt((CByte(227)))), (CInt((CByte(248)))))
			Me.gpVSBehavior.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(227)))), (CInt((CByte(246)))))
			Me.gpVSBehavior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gpVSBehavior.Controls.Add(Me.label1)
			Me.gpVSBehavior.Controls.Add(Me.cbIntegratedScrolling)
			Me.gpVSBehavior.Controls.Add(Me.cbFlowViewItemText)
			Me.gpVSBehavior.Controls.Add(Me.cbToolTips)
			Me.gpVSBehavior.Controls.Add(Me.cbFlowView)
			Me.gpVSBehavior.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gpVSBehavior.Location = New System.Drawing.Point(0, 30)
			Me.gpVSBehavior.Name = "gpVSBehavior"
			Me.gpVSBehavior.Size = New System.Drawing.Size(285, 180)
			Me.gpVSBehavior.TabIndex = 196
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.ForeColor = System.Drawing.Color.Black
			Me.label1.Location = New System.Drawing.Point(2, 140)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(281, 38)
			Me.label1.TabIndex = 172
			Me.label1.Text = "Use the GroupView's context menu for more options..."
			' 
			' cbIntegratedScrolling
			' 
			Me.cbIntegratedScrolling.AutoSize = True
			Me.cbIntegratedScrolling.BackColor = System.Drawing.Color.Transparent
			Me.cbIntegratedScrolling.Location = New System.Drawing.Point(13, 95)
			Me.cbIntegratedScrolling.Name = "cbIntegratedScrolling"
			Me.cbIntegratedScrolling.Size = New System.Drawing.Size(117, 17)
			Me.cbIntegratedScrolling.TabIndex = 165
			Me.cbIntegratedScrolling.Text = "Integrated Scrolling"
			Me.cbIntegratedScrolling.UseVisualStyleBackColor = False
'			Me.cbIntegratedScrolling.CheckedChanged += New System.EventHandler(Me.cbIntegratedScrolling_CheckedChanged);
			' 
			' cbFlowViewItemText
			' 
			Me.cbFlowViewItemText.AutoSize = True
			Me.cbFlowViewItemText.BackColor = System.Drawing.Color.Transparent
			Me.cbFlowViewItemText.Location = New System.Drawing.Point(13, 39)
			Me.cbFlowViewItemText.Name = "cbFlowViewItemText"
			Me.cbFlowViewItemText.Size = New System.Drawing.Size(118, 17)
			Me.cbFlowViewItemText.TabIndex = 164
			Me.cbFlowViewItemText.Text = "FlowView Item Text"
			Me.cbFlowViewItemText.UseVisualStyleBackColor = False
'			Me.cbFlowViewItemText.CheckedChanged += New System.EventHandler(Me.cbFlowViewItemText_CheckedChanged);
			' 
			' cbToolTips
			' 
			Me.cbToolTips.AutoSize = True
			Me.cbToolTips.BackColor = System.Drawing.Color.Transparent
			Me.cbToolTips.Location = New System.Drawing.Point(13, 67)
			Me.cbToolTips.Name = "cbToolTips"
			Me.cbToolTips.Size = New System.Drawing.Size(94, 17)
			Me.cbToolTips.TabIndex = 163
			Me.cbToolTips.Text = "ShowToolTips"
			Me.cbToolTips.UseVisualStyleBackColor = False
'			Me.cbToolTips.CheckedChanged += New System.EventHandler(Me.cbToolTips_CheckedChanged);
			' 
			' cbFlowView
			' 
			Me.cbFlowView.AutoSize = True
			Me.cbFlowView.BackColor = System.Drawing.Color.Transparent
			Me.cbFlowView.Location = New System.Drawing.Point(13, 11)
			Me.cbFlowView.Name = "cbFlowView"
			Me.cbFlowView.Size = New System.Drawing.Size(71, 17)
			Me.cbFlowView.TabIndex = 162
			Me.cbFlowView.Text = "FlowView"
			Me.cbFlowView.UseVisualStyleBackColor = False
'			Me.cbFlowView.CheckedChanged += New System.EventHandler(Me.cbFlowView_CheckedChanged);
			' 
			' panel15
			' 
			Me.panel15.BackColor = System.Drawing.Color.Transparent
			Me.panel15.BackgroundImage = (CType(resources.GetObject("panel15.BackgroundImage"), System.Drawing.Image))
			Me.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.panel15.Controls.Add(Me.label35)
			Me.panel15.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel15.Location = New System.Drawing.Point(0, 0)
			Me.panel15.Name = "panel15"
			Me.panel15.Size = New System.Drawing.Size(285, 30)
			Me.panel15.TabIndex = 157
			' 
			' label35
			' 
			Me.label35.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label35.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label35.Image = (CType(resources.GetObject("label35.Image"), System.Drawing.Image))
			Me.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label35.Location = New System.Drawing.Point(10, 6)
			Me.label35.Name = "label35"
			Me.label35.Size = New System.Drawing.Size(77, 19)
			Me.label35.TabIndex = 170
			Me.label35.Text = "Behavior"
			Me.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' panel4
			' 
			Me.panel4.BackColor = System.Drawing.Color.Transparent
			Me.panel4.Controls.Add(Me.gradientPanel5)
			Me.panel4.Controls.Add(Me.panel3)
			Me.panel4.Location = New System.Drawing.Point(182, 9)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(586, 254)
			Me.panel4.TabIndex = 203
			' 
			' gradientPanel5
			' 
			Me.gradientPanel5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(209)))), (CInt((CByte(227)))), (CInt((CByte(248)))))
			Me.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(227)))), (CInt((CByte(246)))))
			Me.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel5.Controls.Add(Me.cpSelectedHlText)
			Me.gradientPanel5.Controls.Add(Me.cbHighlightImage)
			Me.gradientPanel5.Controls.Add(Me.cpSelectedTextColor)
			Me.gradientPanel5.Controls.Add(Me.label20)
			Me.gradientPanel5.Controls.Add(Me.label5)
			Me.gradientPanel5.Controls.Add(Me.cpBackColor)
			Me.gradientPanel5.Controls.Add(Me.cbTextUnderline)
			Me.gradientPanel5.Controls.Add(Me.cmbOrientation)
			Me.gradientPanel5.Controls.Add(Me.label14)
			Me.gradientPanel5.Controls.Add(Me.cbTextWrap)
			Me.gradientPanel5.Controls.Add(Me.label12)
			Me.gradientPanel5.Controls.Add(Me.cbThemesEnabled)
			Me.gradientPanel5.Controls.Add(Me.nUDTextSpacing)
			Me.gradientPanel5.Controls.Add(Me.cbButtonView)
			Me.gradientPanel5.Controls.Add(Me.nUDSelectedHighlightOffset)
			Me.gradientPanel5.Controls.Add(Me.cbHighightText)
			Me.gradientPanel5.Controls.Add(Me.label3)
			Me.gradientPanel5.Controls.Add(Me.cmbGVBorder)
			Me.gradientPanel5.Controls.Add(Me.nUDSelectedOffset)
			Me.gradientPanel5.Controls.Add(Me.numericUpDownExt1)
			Me.gradientPanel5.Controls.Add(Me.nUDSelectingOffset)
			Me.gradientPanel5.Controls.Add(Me.label2)
			Me.gradientPanel5.Controls.Add(Me.label16)
			Me.gradientPanel5.Controls.Add(Me.label19)
			Me.gradientPanel5.Controls.Add(Me.nUDHighlightOffset)
			Me.gradientPanel5.Controls.Add(Me.cpHighlightText)
			Me.gradientPanel5.Controls.Add(Me.label11)
			Me.gradientPanel5.Controls.Add(Me.cpselectedHlItem)
			Me.gradientPanel5.Controls.Add(Me.label10)
			Me.gradientPanel5.Controls.Add(Me.label9)
			Me.gradientPanel5.Controls.Add(Me.label18)
			Me.gradientPanel5.Controls.Add(Me.cpSelectedItemColor)
			Me.gradientPanel5.Controls.Add(Me.label17)
			Me.gradientPanel5.Controls.Add(Me.cpHighlightItem)
			Me.gradientPanel5.Controls.Add(Me.label13)
			Me.gradientPanel5.Controls.Add(Me.label15)
			Me.gradientPanel5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gradientPanel5.Location = New System.Drawing.Point(0, 30)
			Me.gradientPanel5.Name = "gradientPanel5"
			Me.gradientPanel5.Size = New System.Drawing.Size(586, 224)
			Me.gradientPanel5.TabIndex = 201
			' 
			' cpSelectedHlText
			' 
			Me.cpSelectedHlText.BackColor = System.Drawing.Color.Black
			Me.cpSelectedHlText.ColorUISize = New System.Drawing.Size(208, 230)
			Me.cpSelectedHlText.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cpSelectedHlText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cpSelectedHlText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cpSelectedHlText.ForeColor = System.Drawing.Color.Black
			Me.cpSelectedHlText.Location = New System.Drawing.Point(302, 137)
			Me.cpSelectedHlText.Name = "cpSelectedHlText"
			Me.cpSelectedHlText.SelectedAsBackcolor = True
			Me.cpSelectedHlText.SelectedColor = System.Drawing.Color.Black
			Me.cpSelectedHlText.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.cpSelectedHlText.Size = New System.Drawing.Size(20, 20)
			Me.cpSelectedHlText.TabIndex = 189
			Me.cpSelectedHlText.UseVisualStyleBackColor = False
'			Me.cpSelectedHlText.ColorSelected += New System.EventHandler(Me.cpSelectedHlText_ColorSelected_1);
			' 
			' cbHighlightImage
			' 
			Me.cbHighlightImage.AutoSize = True
			Me.cbHighlightImage.BackColor = System.Drawing.Color.Transparent
			Me.cbHighlightImage.Location = New System.Drawing.Point(3, 12)
			Me.cbHighlightImage.Name = "cbHighlightImage"
			Me.cbHighlightImage.Size = New System.Drawing.Size(99, 17)
			Me.cbHighlightImage.TabIndex = 188
			Me.cbHighlightImage.Text = "Highlight Image"
			Me.cbHighlightImage.UseVisualStyleBackColor = False
'			Me.cbHighlightImage.CheckedChanged += New System.EventHandler(Me.cbHighlightImage_CheckedChanged);
			' 
			' cpSelectedTextColor
			' 
			Me.cpSelectedTextColor.BackColor = System.Drawing.Color.SaddleBrown
			Me.cpSelectedTextColor.ColorUISize = New System.Drawing.Size(208, 230)
			Me.cpSelectedTextColor.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cpSelectedTextColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cpSelectedTextColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cpSelectedTextColor.ForeColor = System.Drawing.Color.Black
			Me.cpSelectedTextColor.Location = New System.Drawing.Point(302, 87)
			Me.cpSelectedTextColor.Name = "cpSelectedTextColor"
			Me.cpSelectedTextColor.SelectedAsBackcolor = True
			Me.cpSelectedTextColor.SelectedColor = System.Drawing.Color.SaddleBrown
			Me.cpSelectedTextColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.cpSelectedTextColor.Size = New System.Drawing.Size(20, 20)
			Me.cpSelectedTextColor.TabIndex = 187
			Me.cpSelectedTextColor.UseVisualStyleBackColor = False
'			Me.cpSelectedTextColor.ColorSelected += New System.EventHandler(Me.cpSelectedTextColor_ColorSelected);
			' 
			' label20
			' 
			Me.label20.AutoSize = True
			Me.label20.BackColor = System.Drawing.Color.Transparent
			Me.label20.ForeColor = System.Drawing.Color.Black
			Me.label20.Location = New System.Drawing.Point(356, 187)
			Me.label20.Name = "label20"
			Me.label20.Size = New System.Drawing.Size(58, 13)
			Me.label20.TabIndex = 169
			Me.label20.Text = "Orientation"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.BackColor = System.Drawing.Color.Transparent
			Me.label5.ForeColor = System.Drawing.Color.Black
			Me.label5.Location = New System.Drawing.Point(158, 12)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(56, 13)
			Me.label5.TabIndex = 159
			Me.label5.Text = "BackColor"
			' 
			' cpBackColor
			' 
			Me.cpBackColor.BackColor = System.Drawing.SystemColors.ControlLight
			Me.cpBackColor.ColorUISize = New System.Drawing.Size(208, 230)
			Me.cpBackColor.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cpBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cpBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cpBackColor.ForeColor = System.Drawing.Color.Black
			Me.cpBackColor.Location = New System.Drawing.Point(302, 12)
			Me.cpBackColor.Name = "cpBackColor"
			Me.cpBackColor.SelectedAsBackcolor = True
			Me.cpBackColor.SelectedColor = System.Drawing.SystemColors.ControlLight
			Me.cpBackColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.cpBackColor.Size = New System.Drawing.Size(20, 20)
			Me.cpBackColor.TabIndex = 158
			Me.cpBackColor.UseVisualStyleBackColor = True
'			Me.cpBackColor.ColorSelected += New System.EventHandler(Me.cpBackColor_ColorSelected);
			' 
			' cbTextUnderline
			' 
			Me.cbTextUnderline.AutoSize = True
			Me.cbTextUnderline.BackColor = System.Drawing.Color.Transparent
			Me.cbTextUnderline.Location = New System.Drawing.Point(3, 137)
			Me.cbTextUnderline.Name = "cbTextUnderline"
			Me.cbTextUnderline.Size = New System.Drawing.Size(95, 17)
			Me.cbTextUnderline.TabIndex = 173
			Me.cbTextUnderline.Text = "Text Underline"
			Me.cbTextUnderline.UseVisualStyleBackColor = False
'			Me.cbTextUnderline.CheckedChanged += New System.EventHandler(Me.cbTextUnderline_CheckedChanged);
			' 
			' cmbOrientation
			' 
			Me.cmbOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbOrientation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.cmbOrientation.FormattingEnabled = True
			Me.cmbOrientation.Items.AddRange(New Object() { "Horizontal", "Vertical"})
			Me.cmbOrientation.Location = New System.Drawing.Point(499, 187)
			Me.cmbOrientation.Name = "cmbOrientation"
			Me.cmbOrientation.Size = New System.Drawing.Size(82, 21)
			Me.cmbOrientation.TabIndex = 170
'			Me.cmbOrientation.SelectedIndexChanged += New System.EventHandler(Me.cmbOrientation_SelectedIndexChanged);
			' 
			' label14
			' 
			Me.label14.AutoSize = True
			Me.label14.BackColor = System.Drawing.Color.Transparent
			Me.label14.ForeColor = System.Drawing.Color.Black
			Me.label14.Location = New System.Drawing.Point(158, 137)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(141, 13)
			Me.label14.TabIndex = 177
			Me.label14.Text = "SelectedHighlight Text Color"
			' 
			' cbTextWrap
			' 
			Me.cbTextWrap.AutoSize = True
			Me.cbTextWrap.BackColor = System.Drawing.Color.Transparent
			Me.cbTextWrap.Location = New System.Drawing.Point(3, 112)
			Me.cbTextWrap.Name = "cbTextWrap"
			Me.cbTextWrap.Size = New System.Drawing.Size(76, 17)
			Me.cbTextWrap.TabIndex = 174
			Me.cbTextWrap.Text = "Text Wrap"
			Me.cbTextWrap.UseVisualStyleBackColor = False
'			Me.cbTextWrap.CheckedChanged += New System.EventHandler(Me.cbTextWrap_CheckedChanged);
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.BackColor = System.Drawing.Color.Transparent
			Me.label12.ForeColor = System.Drawing.Color.Black
			Me.label12.Location = New System.Drawing.Point(356, 112)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(70, 13)
			Me.label12.TabIndex = 171
			Me.label12.Text = "Text Spacing"
			' 
			' cbThemesEnabled
			' 
			Me.cbThemesEnabled.AutoSize = True
			Me.cbThemesEnabled.BackColor = System.Drawing.Color.Transparent
			Me.cbThemesEnabled.Location = New System.Drawing.Point(3, 87)
			Me.cbThemesEnabled.Name = "cbThemesEnabled"
			Me.cbThemesEnabled.Size = New System.Drawing.Size(105, 17)
			Me.cbThemesEnabled.TabIndex = 171
			Me.cbThemesEnabled.Text = "Themes enabled"
			Me.cbThemesEnabled.UseVisualStyleBackColor = False
'			Me.cbThemesEnabled.CheckedChanged += New System.EventHandler(Me.cbThemesEnabled_CheckedChanged);
			' 
			' nUDTextSpacing
			' 
			Me.nUDTextSpacing.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(234)))), (CInt((CByte(242)))), (CInt((CByte(251)))))
			Me.nUDTextSpacing.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(177)))), (CInt((CByte(197)))), (CInt((CByte(218)))))
			Me.nUDTextSpacing.Location = New System.Drawing.Point(499, 112)
			Me.nUDTextSpacing.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.nUDTextSpacing.Name = "nUDTextSpacing"
			Me.nUDTextSpacing.Size = New System.Drawing.Size(52, 20)
			Me.nUDTextSpacing.TabIndex = 172
			Me.nUDTextSpacing.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
'			Me.nUDTextSpacing.ValueChanged += New System.EventHandler(Me.nUDTextSpacing_ValueChanged);
			' 
			' cbButtonView
			' 
			Me.cbButtonView.AutoSize = True
			Me.cbButtonView.BackColor = System.Drawing.Color.Transparent
			Me.cbButtonView.Location = New System.Drawing.Point(3, 62)
			Me.cbButtonView.Name = "cbButtonView"
			Me.cbButtonView.Size = New System.Drawing.Size(80, 17)
			Me.cbButtonView.TabIndex = 143
			Me.cbButtonView.Text = "ButtonView"
			Me.cbButtonView.UseVisualStyleBackColor = False
'			Me.cbButtonView.CheckedChanged += New System.EventHandler(Me.cbButtonView_CheckedChanged);
			' 
			' nUDSelectedHighlightOffset
			' 
			Me.nUDSelectedHighlightOffset.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(234)))), (CInt((CByte(242)))), (CInt((CByte(251)))))
			Me.nUDSelectedHighlightOffset.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(177)))), (CInt((CByte(197)))), (CInt((CByte(218)))))
			Me.nUDSelectedHighlightOffset.Location = New System.Drawing.Point(499, 87)
			Me.nUDSelectedHighlightOffset.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.nUDSelectedHighlightOffset.Name = "nUDSelectedHighlightOffset"
			Me.nUDSelectedHighlightOffset.Size = New System.Drawing.Size(52, 20)
			Me.nUDSelectedHighlightOffset.TabIndex = 170
			Me.nUDSelectedHighlightOffset.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
'			Me.nUDSelectedHighlightOffset.ValueChanged += New System.EventHandler(Me.nUDSelectedHighlightOffset_ValueChanged);
			' 
			' cbHighightText
			' 
			Me.cbHighightText.AutoSize = True
			Me.cbHighightText.BackColor = System.Drawing.Color.Transparent
			Me.cbHighightText.Location = New System.Drawing.Point(3, 37)
			Me.cbHighightText.Name = "cbHighightText"
			Me.cbHighightText.Size = New System.Drawing.Size(89, 17)
			Me.cbHighightText.TabIndex = 162
			Me.cbHighightText.Text = "Highight Text"
			Me.cbHighightText.UseVisualStyleBackColor = False
'			Me.cbHighightText.CheckedChanged += New System.EventHandler(Me.cbHighightText_CheckedChanged);
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.BackColor = System.Drawing.Color.Transparent
			Me.label3.ForeColor = System.Drawing.Color.Black
			Me.label3.Location = New System.Drawing.Point(356, 87)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(142, 13)
			Me.label3.TabIndex = 169
			Me.label3.Text = "SelectedHighlightText Offset"
			' 
			' cmbGVBorder
			' 
			Me.cmbGVBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbGVBorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.cmbGVBorder.FormattingEnabled = True
			Me.cmbGVBorder.Items.AddRange(New Object() { "None", "FixedSingle", "Fixed3D"})
			Me.cmbGVBorder.Location = New System.Drawing.Point(499, 162)
			Me.cmbGVBorder.Name = "cmbGVBorder"
			Me.cmbGVBorder.Size = New System.Drawing.Size(82, 21)
			Me.cmbGVBorder.TabIndex = 161
'			Me.cmbGVBorder.SelectedIndexChanged += New System.EventHandler(Me.cmbGVBorder_SelectedIndexChanged);
			' 
			' nUDSelectedOffset
			' 
			Me.nUDSelectedOffset.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(234)))), (CInt((CByte(242)))), (CInt((CByte(251)))))
			Me.nUDSelectedOffset.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(177)))), (CInt((CByte(197)))), (CInt((CByte(218)))))
			Me.nUDSelectedOffset.Location = New System.Drawing.Point(499, 62)
			Me.nUDSelectedOffset.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.nUDSelectedOffset.Name = "nUDSelectedOffset"
			Me.nUDSelectedOffset.Size = New System.Drawing.Size(52, 20)
			Me.nUDSelectedOffset.TabIndex = 168
			Me.nUDSelectedOffset.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
'			Me.nUDSelectedOffset.ValueChanged += New System.EventHandler(Me.nUDSelectedOffset_ValueChanged);
			' 
			' numericUpDownExt1
			' 
			Me.numericUpDownExt1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(234)))), (CInt((CByte(242)))), (CInt((CByte(251)))))
			Me.numericUpDownExt1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(177)))), (CInt((CByte(197)))), (CInt((CByte(218)))))
			Me.numericUpDownExt1.Location = New System.Drawing.Point(499, 137)
			Me.numericUpDownExt1.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.numericUpDownExt1.Name = "numericUpDownExt1"
			Me.numericUpDownExt1.Size = New System.Drawing.Size(52, 20)
			Me.numericUpDownExt1.TabIndex = 168
			Me.numericUpDownExt1.Value = New Decimal(New Integer() { 6, 0, 0, 0})
			Me.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
'			Me.numericUpDownExt1.ValueChanged += New System.EventHandler(Me.numericUpDownExt1_ValueChanged);
			' 
			' nUDSelectingOffset
			' 
			Me.nUDSelectingOffset.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(234)))), (CInt((CByte(242)))), (CInt((CByte(251)))))
			Me.nUDSelectingOffset.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(177)))), (CInt((CByte(197)))), (CInt((CByte(218)))))
			Me.nUDSelectingOffset.Location = New System.Drawing.Point(499, 37)
			Me.nUDSelectingOffset.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.nUDSelectingOffset.Name = "nUDSelectingOffset"
			Me.nUDSelectingOffset.Size = New System.Drawing.Size(52, 20)
			Me.nUDSelectingOffset.TabIndex = 167
			Me.nUDSelectingOffset.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
'			Me.nUDSelectingOffset.ValueChanged += New System.EventHandler(Me.nUDSelectingOffset_ValueChanged);
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.BackColor = System.Drawing.Color.Transparent
			Me.label2.ForeColor = System.Drawing.Color.Black
			Me.label2.Location = New System.Drawing.Point(356, 162)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(61, 13)
			Me.label2.TabIndex = 160
			Me.label2.Text = "BorderStyle"
			' 
			' label16
			' 
			Me.label16.AutoSize = True
			Me.label16.BackColor = System.Drawing.Color.Transparent
			Me.label16.ForeColor = System.Drawing.Color.Black
			Me.label16.Location = New System.Drawing.Point(158, 37)
			Me.label16.Name = "label16"
			Me.label16.Size = New System.Drawing.Size(96, 13)
			Me.label16.TabIndex = 175
			Me.label16.Text = "HighlightText Color"
			' 
			' label19
			' 
			Me.label19.AutoSize = True
			Me.label19.BackColor = System.Drawing.Color.Transparent
			Me.label19.ForeColor = System.Drawing.Color.Black
			Me.label19.Location = New System.Drawing.Point(356, 137)
			Me.label19.Name = "label19"
			Me.label19.Size = New System.Drawing.Size(75, 13)
			Me.label19.TabIndex = 167
			Me.label19.Text = "ImageSpacing"
			' 
			' nUDHighlightOffset
			' 
			Me.nUDHighlightOffset.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(234)))), (CInt((CByte(242)))), (CInt((CByte(251)))))
			Me.nUDHighlightOffset.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(177)))), (CInt((CByte(197)))), (CInt((CByte(218)))))
			Me.nUDHighlightOffset.Location = New System.Drawing.Point(499, 12)
			Me.nUDHighlightOffset.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.nUDHighlightOffset.Name = "nUDHighlightOffset"
			Me.nUDHighlightOffset.Size = New System.Drawing.Size(52, 20)
			Me.nUDHighlightOffset.TabIndex = 166
			Me.nUDHighlightOffset.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
'			Me.nUDHighlightOffset.ValueChanged += New System.EventHandler(Me.nUDHighlightOffset_ValueChanged);
			' 
			' cpHighlightText
			' 
			Me.cpHighlightText.BackColor = System.Drawing.Color.Brown
			Me.cpHighlightText.ColorUISize = New System.Drawing.Size(208, 230)
			Me.cpHighlightText.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cpHighlightText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cpHighlightText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cpHighlightText.ForeColor = System.Drawing.Color.Black
			Me.cpHighlightText.Location = New System.Drawing.Point(302, 37)
			Me.cpHighlightText.Name = "cpHighlightText"
			Me.cpHighlightText.SelectedAsBackcolor = True
			Me.cpHighlightText.SelectedColor = System.Drawing.Color.Brown
			Me.cpHighlightText.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.cpHighlightText.Size = New System.Drawing.Size(20, 20)
			Me.cpHighlightText.TabIndex = 181
			Me.cpHighlightText.UseVisualStyleBackColor = False
'			Me.cpHighlightText.ColorSelected += New System.EventHandler(Me.cpHighlightText_ColorSelected);
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.BackColor = System.Drawing.Color.Transparent
			Me.label11.ForeColor = System.Drawing.Color.Black
			Me.label11.Location = New System.Drawing.Point(356, 62)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(101, 13)
			Me.label11.TabIndex = 165
			Me.label11.Text = "SelectedText Offset"
			' 
			' cpselectedHlItem
			' 
			Me.cpselectedHlItem.BackColor = System.Drawing.SystemColors.ControlLight
			Me.cpselectedHlItem.ColorUISize = New System.Drawing.Size(208, 230)
			Me.cpselectedHlItem.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cpselectedHlItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cpselectedHlItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cpselectedHlItem.ForeColor = System.Drawing.Color.Black
			Me.cpselectedHlItem.Location = New System.Drawing.Point(302, 162)
			Me.cpselectedHlItem.Name = "cpselectedHlItem"
			Me.cpselectedHlItem.SelectedAsBackcolor = True
			Me.cpselectedHlItem.SelectedColor = System.Drawing.SystemColors.ControlLight
			Me.cpselectedHlItem.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.cpselectedHlItem.Size = New System.Drawing.Size(20, 20)
			Me.cpselectedHlItem.TabIndex = 182
			Me.cpselectedHlItem.UseVisualStyleBackColor = False
'			Me.cpselectedHlItem.ColorSelected += New System.EventHandler(Me.cpselectedHlItem_ColorSelected);
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.BackColor = System.Drawing.Color.Transparent
			Me.label10.ForeColor = System.Drawing.Color.Black
			Me.label10.Location = New System.Drawing.Point(356, 37)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(103, 13)
			Me.label10.TabIndex = 164
			Me.label10.Text = "SelectingText Offset"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.BackColor = System.Drawing.Color.Transparent
			Me.label9.ForeColor = System.Drawing.Color.Black
			Me.label9.Location = New System.Drawing.Point(356, 12)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(100, 13)
			Me.label9.TabIndex = 163
			Me.label9.Text = "HighlightText Offset"
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.BackColor = System.Drawing.Color.Transparent
			Me.label18.ForeColor = System.Drawing.Color.Black
			Me.label18.Location = New System.Drawing.Point(158, 87)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(100, 13)
			Me.label18.TabIndex = 184
			Me.label18.Text = "Selected Text Color"
			' 
			' cpSelectedItemColor
			' 
			Me.cpSelectedItemColor.BackColor = System.Drawing.SystemColors.ControlLight
			Me.cpSelectedItemColor.ColorUISize = New System.Drawing.Size(208, 230)
			Me.cpSelectedItemColor.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cpSelectedItemColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cpSelectedItemColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cpSelectedItemColor.ForeColor = System.Drawing.Color.Black
			Me.cpSelectedItemColor.Location = New System.Drawing.Point(302, 112)
			Me.cpSelectedItemColor.Name = "cpSelectedItemColor"
			Me.cpSelectedItemColor.SelectedAsBackcolor = True
			Me.cpSelectedItemColor.SelectedColor = System.Drawing.SystemColors.ControlLight
			Me.cpSelectedItemColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.cpSelectedItemColor.Size = New System.Drawing.Size(20, 20)
			Me.cpSelectedItemColor.TabIndex = 186
			Me.cpSelectedItemColor.UseVisualStyleBackColor = False
'			Me.cpSelectedItemColor.ColorSelected += New System.EventHandler(Me.cpSelectedItemColor_ColorSelected);
			' 
			' label17
			' 
			Me.label17.AutoSize = True
			Me.label17.BackColor = System.Drawing.Color.Transparent
			Me.label17.ForeColor = System.Drawing.Color.Black
			Me.label17.Location = New System.Drawing.Point(158, 112)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(99, 13)
			Me.label17.TabIndex = 185
			Me.label17.Text = "Selected Item Color"
			' 
			' cpHighlightItem
			' 
			Me.cpHighlightItem.BackColor = System.Drawing.SystemColors.ControlLight
			Me.cpHighlightItem.ColorUISize = New System.Drawing.Size(208, 230)
			Me.cpHighlightItem.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cpHighlightItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cpHighlightItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cpHighlightItem.ForeColor = System.Drawing.Color.Black
			Me.cpHighlightItem.Location = New System.Drawing.Point(302, 62)
			Me.cpHighlightItem.Name = "cpHighlightItem"
			Me.cpHighlightItem.SelectedAsBackcolor = True
			Me.cpHighlightItem.SelectedColor = System.Drawing.SystemColors.ControlLight
			Me.cpHighlightItem.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.cpHighlightItem.Size = New System.Drawing.Size(20, 20)
			Me.cpHighlightItem.TabIndex = 180
			Me.cpHighlightItem.UseVisualStyleBackColor = False
'			Me.cpHighlightItem.ColorSelected += New System.EventHandler(Me.cpHighlightItem_ColorSelected);
			' 
			' label13
			' 
			Me.label13.AutoSize = True
			Me.label13.BackColor = System.Drawing.Color.Transparent
			Me.label13.ForeColor = System.Drawing.Color.Black
			Me.label13.Location = New System.Drawing.Point(158, 162)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(137, 13)
			Me.label13.TabIndex = 178
			Me.label13.Text = "SelectedHighlightItem Color"
			' 
			' label15
			' 
			Me.label15.AutoSize = True
			Me.label15.BackColor = System.Drawing.Color.Transparent
			Me.label15.ForeColor = System.Drawing.Color.Black
			Me.label15.Location = New System.Drawing.Point(158, 62)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(95, 13)
			Me.label15.TabIndex = 176
			Me.label15.Text = "HighlightItem Color"
			' 
			' panel3
			' 
			Me.panel3.BackColor = System.Drawing.Color.Transparent
			Me.panel3.BackgroundImage = (CType(resources.GetObject("panel3.BackgroundImage"), System.Drawing.Image))
			Me.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.panel3.Controls.Add(Me.label22)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel3.Location = New System.Drawing.Point(0, 0)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(586, 30)
			Me.panel3.TabIndex = 157
			' 
			' label22
			' 
			Me.label22.BackColor = System.Drawing.Color.Transparent
			Me.label22.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.label22.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label22.Image = (CType(resources.GetObject("label22.Image"), System.Drawing.Image))
			Me.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label22.Location = New System.Drawing.Point(11, 4)
			Me.label22.Name = "label22"
			Me.label22.Size = New System.Drawing.Size(97, 19)
			Me.label22.TabIndex = 170
			Me.label22.Text = "Appearance"
			Me.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' button1
			' 
			Me.button1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.button1.Location = New System.Drawing.Point(684, 491)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(74, 24)
			Me.button1.TabIndex = 202
			Me.button1.Text = "Clear log"
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' tabPageAdv2
			' 
			Me.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(237)))), (CInt((CByte(248)))))
			Me.tabPageAdv2.Controls.Add(Me.panel7)
			Me.tabPageAdv2.Controls.Add(Me.gvModes)
			Me.tabPageAdv2.Location = New System.Drawing.Point(2, 34)
			Me.tabPageAdv2.Name = "tabPageAdv2"
			Me.tabPageAdv2.Size = New System.Drawing.Size(786, 535)
			Me.tabPageAdv2.TabIndex = 2
			Me.tabPageAdv2.Text = "GroupView Modes"
			Me.tabPageAdv2.ThemesEnabled = False
			' 
			' panel7
			' 
			Me.panel7.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(209)))), (CInt((CByte(227)))), (CInt((CByte(248)))))
			Me.panel7.Controls.Add(Me.panel8)
			Me.panel7.Controls.Add(Me.gradientPanel2)
			Me.panel7.Location = New System.Drawing.Point(186, 12)
			Me.panel7.Name = "panel7"
			Me.panel7.Size = New System.Drawing.Size(591, 514)
			Me.panel7.TabIndex = 206
			' 
			' panel8
			' 
			Me.panel8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(182)))), (CInt((CByte(214)))), (CInt((CByte(246)))))
			Me.panel8.Controls.Add(Me.gradientPanel1)
			Me.panel8.Location = New System.Drawing.Point(8, 9)
			Me.panel8.Name = "panel8"
			Me.panel8.Size = New System.Drawing.Size(574, 121)
			Me.panel8.TabIndex = 206
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.BackColor = System.Drawing.Color.White
			Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(79)))), (CInt((CByte(129)))), (CInt((CByte(189)))))
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel1.Controls.Add(Me.label7)
			Me.gradientPanel1.Controls.Add(Me.label40)
			Me.gradientPanel1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientPanel1.Location = New System.Drawing.Point(6, 6)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(561, 109)
			Me.gradientPanel1.TabIndex = 205
			' 
			' label7
			' 
			Me.label7.BackColor = System.Drawing.Color.Transparent
			Me.label7.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label7.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label7.Location = New System.Drawing.Point(0, 0)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(507, 107)
			Me.label7.TabIndex = 2
			Me.label7.Text = resources.GetString("label7.Text")
			' 
			' label40
			' 
			Me.label40.BackColor = System.Drawing.Color.Transparent
			Me.label40.Dock = System.Windows.Forms.DockStyle.Right
			Me.label40.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label40.Image = (CType(resources.GetObject("label40.Image"), System.Drawing.Image))
			Me.label40.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label40.Location = New System.Drawing.Point(507, 0)
			Me.label40.Name = "label40"
			Me.label40.Size = New System.Drawing.Size(52, 107)
			Me.label40.TabIndex = 1
			' 
			' gradientPanel2
			' 
			Me.gradientPanel2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(241)))), (CInt((CByte(253)))))
			Me.gradientPanel2.BackgroundImage = (CType(resources.GetObject("gradientPanel2.BackgroundImage"), System.Drawing.Image))
			Me.gradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(79)))), (CInt((CByte(129)))), (CInt((CByte(189)))))
			Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel2.Controls.Add(Me.rbOXPFolderBrowser)
			Me.gradientPanel2.Controls.Add(Me.rbXPTaskBar)
			Me.gradientPanel2.Controls.Add(Me.rbLargeIcons)
			Me.gradientPanel2.Controls.Add(Me.rbO2KFolderBrowser)
			Me.gradientPanel2.Controls.Add(Me.rbMessengerList)
			Me.gradientPanel2.Controls.Add(Me.rbVSNETFlow)
			Me.gradientPanel2.Controls.Add(Me.rbVSNETList)
			Me.gradientPanel2.Controls.Add(Me.rbSmallIcons)
			Me.gradientPanel2.Location = New System.Drawing.Point(131, 170)
			Me.gradientPanel2.Name = "gradientPanel2"
			Me.gradientPanel2.Size = New System.Drawing.Size(364, 306)
			Me.gradientPanel2.TabIndex = 204
			' 
			' tabPageAdv3
			' 
			Me.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(227)))), (CInt((CByte(237)))), (CInt((CByte(248)))))
			Me.tabPageAdv3.Controls.Add(Me.gradientPanelExt1)
			Me.tabPageAdv3.Controls.Add(Me.gradientPanel6)
			Me.tabPageAdv3.Location = New System.Drawing.Point(2, 34)
			Me.tabPageAdv3.Name = "tabPageAdv3"
			Me.tabPageAdv3.Size = New System.Drawing.Size(786, 535)
			Me.tabPageAdv3.TabIndex = 3
			Me.tabPageAdv3.Text = "Custom GroupView"
			Me.tabPageAdv3.ThemesEnabled = False
			' 
			' gradientPanelExt1
			' 
			Me.gradientPanelExt1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(235)))), (CInt((CByte(254)))))
			Me.gradientPanelExt1.BorderColor = System.Drawing.Color.Black
			Me.gradientPanelExt1.BorderGap = 2
			Me.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanelExt1.Controls.Add(Me.gvFeatures)
			Me.gradientPanelExt1.ExpandLocation = New System.Drawing.Point(0, 0)
			Me.gradientPanelExt1.ExpandSize = New System.Drawing.Size(0, 0)
			Me.gradientPanelExt1.Location = New System.Drawing.Point(9, 12)
			Me.gradientPanelExt1.Name = "gradientPanelExt1"
			Me.gradientPanelExt1.Size = New System.Drawing.Size(192, 506)
			Me.gradientPanelExt1.TabIndex = 159
			' 
			' gvFeatures
			' 
			Me.gvFeatures.BackColor = System.Drawing.Color.White
			Me.gvFeatures.BackgroundImage = (CType(resources.GetObject("gvFeatures.BackgroundImage"), System.Drawing.Image))
			Me.gvFeatures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.gvFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gvFeatures.FlatLook = True
			Me.gvFeatures.ForeColor = System.Drawing.Color.MidnightBlue
			Me.gvFeatures.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Custom Colors", 0, True, Nothing, "Custom Colors"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Text Customization", 1, True, Nothing, "Text Customization"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Image Settings", 2, True, Nothing, "Image Settings"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Orientation", 3, True, Nothing, "Orientation"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("ContextMenu", 4, True, Nothing, "ContextMenu"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("ToolTip Support", 5, True, Nothing, "ToolTip Support"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("InPlace Rename", 6, True, Nothing, "InPlace Rename"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Various Modes", 7, True, Nothing, "Various Modes"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Events Support", 8, True, Nothing, "Events Support"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Localization", 9, True, Nothing, "Localization")})
			Me.gvFeatures.HighlightImageOffset = New System.Drawing.Point(1, 1)
			Me.gvFeatures.HighlightItemColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(224)))), (CInt((CByte(192)))))
			Me.gvFeatures.HighlightTextColor = System.Drawing.Color.Black
			Me.gvFeatures.IntegratedScrolling = True
			Me.gvFeatures.ItemXSpacing = 30
			Me.gvFeatures.ItemYSpacing = 10
			Me.gvFeatures.LargeImageList = Me.imageList
			Me.gvFeatures.Location = New System.Drawing.Point(10, 8)
			Me.gvFeatures.Name = "gvFeatures"
			Me.gvFeatures.SelectedHighlightTextColor = System.Drawing.Color.Black
			Me.gvFeatures.SelectedTextColor = System.Drawing.Color.White
			Me.gvFeatures.SelectingTextColor = System.Drawing.Color.White
			Me.gvFeatures.Size = New System.Drawing.Size(169, 489)
			Me.gvFeatures.SmallImageList = Nothing
			Me.gvFeatures.TabIndex = 174
			Me.gvFeatures.Text = "groupView1"
			Me.gvFeatures.TextSpacing = 22
			Me.gvFeatures.TextWrap = True
'			Me.gvFeatures.MouseLeave += New System.EventHandler(Me.groupView1_MouseLeave);
'			Me.gvFeatures.GroupViewItemHighlighted += New System.EventHandler(Me.groupView1_GroupViewItemHighlighted);
			' 
			' gradientPanel6
			' 
			Me.gradientPanel6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(235)))), (CInt((CByte(253)))))
			Me.gradientPanel6.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(73)))), (CInt((CByte(137)))), (CInt((CByte(243)))))
			Me.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel6.Controls.Add(Me.gradientPanel4)
			Me.gradientPanel6.Location = New System.Drawing.Point(210, 19)
			Me.gradientPanel6.Name = "gradientPanel6"
			Me.gradientPanel6.Size = New System.Drawing.Size(563, 497)
			Me.gradientPanel6.TabIndex = 203
			' 
			' gradientPanel4
			' 
			Me.gradientPanel4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(224)))), (CInt((CByte(235)))), (CInt((CByte(253)))))
			Me.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(73)))), (CInt((CByte(137)))), (CInt((CByte(243)))))
			Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel4.Controls.Add(Me.richTextBox1)
			Me.gradientPanel4.Location = New System.Drawing.Point(10, 12)
			Me.gradientPanel4.Name = "gradientPanel4"
			Me.gradientPanel4.Size = New System.Drawing.Size(539, 472)
			Me.gradientPanel4.TabIndex = 204
			' 
			' richTextBox1
			' 
			Me.richTextBox1.BackColor = System.Drawing.Color.White
			Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.richTextBox1.Location = New System.Drawing.Point(2, 2)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.ReadOnly = True
			Me.richTextBox1.Size = New System.Drawing.Size(533, 467)
			Me.richTextBox1.TabIndex = 0
			Me.richTextBox1.Text = ""
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 400
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' scrollersFrame1
			' 
			Me.scrollersFrame1.AttachedTo = Me.richTextBox1
			Me.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto
			Me.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007
			' 
			' GroupViewDemoForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.BackColor = System.Drawing.Color.White
			Me.ClientSize = New System.Drawing.Size(790, 571)
			Me.Controls.Add(Me.tabControlAdv1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "GroupViewDemoForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "GroupView Demo "
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControlAdv1.ResumeLayout(False)
			Me.tabPageAdv1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.panel6.ResumeLayout(False)
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel3.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			Me.panel5.ResumeLayout(False)
			CType(Me.gpVSBehavior, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gpVSBehavior.ResumeLayout(False)
			Me.gpVSBehavior.PerformLayout()
			Me.panel15.ResumeLayout(False)
			Me.panel4.ResumeLayout(False)
			CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel5.ResumeLayout(False)
			Me.gradientPanel5.PerformLayout()
			CType(Me.nUDTextSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nUDSelectedHighlightOffset, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nUDSelectedOffset, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nUDSelectingOffset, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nUDHighlightOffset, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel3.ResumeLayout(False)
			Me.tabPageAdv2.ResumeLayout(False)
			Me.panel7.ResumeLayout(False)
			Me.panel8.ResumeLayout(False)
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel2.ResumeLayout(False)
			Me.gradientPanel2.PerformLayout()
			Me.tabPageAdv3.ResumeLayout(False)
			CType(Me.gradientPanelExt1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanelExt1.ResumeLayout(False)
			CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel6.ResumeLayout(False)
			CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel4.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "GroupView"

		#Region "Various modes of groupView"


		Private Sub rbLargeIcons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbLargeIcons.CheckedChanged
			' Set the GroupView attributes for the OutlookBar type interface with large icons
			If Me.rbLargeIcons.Checked = True Then
				Me.gvModes.SmallImageView = False
				Me.gvModes.ButtonView = False
				Me.gvModes.FlowView = False
				Me.gvModes.FlatLook = False

				Me.gvModes.BackColor = SystemColors.ControlDark
				Me.gvModes.ForeColor = SystemColors.HighlightText
				Me.gvModes.HighlightItemColor = SystemColors.ControlDark
				Me.gvModes.HighlightTextColor = SystemColors.HighlightText
				Me.gvModes.SelectingItemColor = SystemColors.ControlDark
				Me.gvModes.SelectingTextColor = SystemColors.HighlightText
				Me.gvModes.SelectedItemColor = SystemColors.ControlDark
				Me.gvModes.SelectedTextColor = SystemColors.HighlightText
				Me.gvModes.SelectedHighlightItemColor = SystemColors.ControlDark
				Me.gvModes.SelectedHighlightTextColor = SystemColors.HighlightText

				Me.gvModes.ImageSpacing = 8
				Me.gvModes.ItemXSpacing = 8
				Me.gvModes.ItemYSpacing = 8

				Me.gvModes.ClipSelectionBounds = True
				Me.gvModes.HighlightImage = True
				Me.gvModes.HighlightText = False
				Me.gvModes.TextUnderline = False
				Me.gvModes.TextWrap = False

				Me.gvModes.HighlightImageOffset = Point.Empty
				Me.gvModes.SelectingImageOffset = Point.Empty
				Me.gvModes.SelectingTextOffset = Point.Empty
			End If
		End Sub

		Private Sub rbSmallIcons_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSmallIcons.CheckedChanged
			' Set the GroupView attributes for the OutlookBar type interface with small icons
			If Me.rbSmallIcons.Checked = True Then
				Me.gvModes.SmallImageView = True
				Me.gvModes.ButtonView = False
				Me.gvModes.FlowView = False
				Me.gvModes.FlatLook = False

				Me.gvModes.BackColor = SystemColors.ControlDark
				Me.gvModes.ForeColor = SystemColors.HighlightText
				Me.gvModes.HighlightItemColor = SystemColors.ControlDark
				Me.gvModes.HighlightTextColor = SystemColors.HighlightText
				Me.gvModes.SelectingItemColor = SystemColors.ControlDark
				Me.gvModes.SelectingTextColor = SystemColors.HighlightText
				Me.gvModes.SelectedItemColor = SystemColors.ControlDark
				Me.gvModes.SelectedTextColor = SystemColors.HighlightText
				Me.gvModes.SelectedHighlightItemColor = SystemColors.ControlDark
				Me.gvModes.SelectedHighlightTextColor = SystemColors.HighlightText

				Me.gvModes.ImageSpacing = 3
				Me.gvModes.ItemXSpacing = 8
				Me.gvModes.ItemYSpacing = 8

				Me.gvModes.ClipSelectionBounds = True
				Me.gvModes.HighlightImage = True
				Me.gvModes.HighlightText = False
				Me.gvModes.TextUnderline = False
				Me.gvModes.TextWrap = False

				Me.gvModes.HighlightImageOffset = Point.Empty
				Me.gvModes.SelectingImageOffset = Point.Empty
				Me.gvModes.SelectingTextOffset = Point.Empty
			End If
		End Sub

		Private Sub rbVSNETList_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbVSNETList.CheckedChanged
			' Set the GroupView attributes for the VS.NET Toolbox type interface with ListView (non-flow) mode
			If Me.rbVSNETList.Checked = True Then

				Me.gvModes.SmallImageView = True
				Me.gvModes.ButtonView = True
				Me.gvModes.FlowView = False
				Me.gvModes.FlatLook = False

				Me.gvModes.BackColor = SystemColors.Control
				Me.gvModes.ForeColor = SystemColors.ControlText
				Me.gvModes.HighlightItemColor = SystemColors.Control
				Me.gvModes.HighlightTextColor = SystemColors.ControlText
				Me.gvModes.SelectingItemColor = ControlPaint.Light(SystemColors.ControlLight)
				Me.gvModes.SelectingTextColor = SystemColors.ControlText
				Me.gvModes.SelectedHighlightItemColor = SystemColors.Control
				Me.gvModes.SelectedHighlightTextColor = SystemColors.ControlText
				Me.gvModes.SelectedItemColor = ControlPaint.Light(SystemColors.ControlLight)
				Me.gvModes.SelectedTextColor = SystemColors.ControlText



				Me.gvModes.ImageSpacing = 2
				Me.gvModes.ItemXSpacing = 8
				Me.gvModes.ItemYSpacing = 1

				Me.gvModes.ClipSelectionBounds = False
				Me.gvModes.HighlightImage = True
				Me.gvModes.HighlightText = True
				Me.gvModes.TextUnderline = False
				Me.gvModes.TextWrap = False

				Me.gvModes.HighlightImageOffset = Point.Empty
				Me.gvModes.SelectingImageOffset = Point.Empty
				Me.gvModes.SelectingTextOffset = Point.Empty
			End If
		End Sub

		Private Sub rbVSNETFlow_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbVSNETFlow.CheckedChanged
			' Set the GroupView attributes for the VS.NET Toolbox type interface with non-listview (flow) mode
			If Me.rbVSNETFlow.Checked = True Then
				Me.gvModes.SmallImageView = True
				Me.gvModes.ButtonView = True
				Me.gvModes.FlowView = True
				Me.gvModes.FlatLook = False

				Me.gvModes.BackColor = SystemColors.Control
				Me.gvModes.ForeColor = SystemColors.ControlText
				Me.gvModes.HighlightItemColor = SystemColors.Control
				Me.gvModes.HighlightTextColor = SystemColors.ControlText
				Me.gvModes.SelectingItemColor = ControlPaint.Light(SystemColors.ControlLight)
				Me.gvModes.SelectingTextColor = SystemColors.ControlText
				Me.gvModes.SelectedItemColor = ControlPaint.Light(SystemColors.ControlLight)
				Me.gvModes.SelectedTextColor = SystemColors.ControlText
				Me.gvModes.SelectedHighlightItemColor = SystemColors.Control
				Me.gvModes.SelectedHighlightTextColor = SystemColors.ControlText

				Me.gvModes.ImageSpacing = 5
				Me.gvModes.ItemXSpacing = 0
				Me.gvModes.ItemYSpacing = 0

				Me.gvModes.ClipSelectionBounds = False
				Me.gvModes.HighlightImage = True
				Me.gvModes.HighlightText = True
				Me.gvModes.TextUnderline = False
				Me.gvModes.TextWrap = False

				Me.gvModes.HighlightImageOffset = Point.Empty
				Me.gvModes.SelectingImageOffset = Point.Empty
				Me.gvModes.SelectingTextOffset = Point.Empty
			End If
		End Sub

		Private Sub rbOXPFolderBrowser_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOXPFolderBrowser.CheckedChanged
			' Set the GroupView attributes for the Office XP folder browser type interface.
			If Me.rbOXPFolderBrowser.Checked = True Then
				Me.gvModes.SmallImageView = False
				Me.gvModes.ButtonView = True
				Me.gvModes.FlowView = False
				Me.gvModes.FlatLook = True

				Me.gvModes.BackColor = ControlPaint.Light(SystemColors.Control, 0.25f)
				Me.gvModes.ForeColor = SystemColors.ControlText
				Me.gvModes.HighlightItemColor = Color.FromArgb(236, 235, 240)
				Me.gvModes.HighlightTextColor = SystemColors.ControlText
				Me.gvModes.SelectingItemColor = Color.FromArgb(133, 146, 181)
				Me.gvModes.SelectedItemColor = Color.FromArgb(212, 213, 216)
				Me.gvModes.SelectedTextColor = SystemColors.ControlText
				Me.gvModes.SelectedHighlightItemColor = Color.FromArgb(133, 146, 181)
				If Me.gvModes.ThemesEnabled = False Then
					Me.gvModes.SelectingTextColor = SystemColors.HighlightText
					Me.gvModes.SelectedHighlightTextColor = SystemColors.HighlightText
				Else
					Me.gvModes.SelectingTextColor = SystemColors.ControlText
					Me.gvModes.SelectedHighlightTextColor = SystemColors.ControlText
				End If

				Me.gvModes.ImageSpacing = 5
				Me.gvModes.ItemXSpacing = 8
				Me.gvModes.ItemYSpacing = 1

				Me.gvModes.ClipSelectionBounds = False
				Me.gvModes.HighlightImage = True
				Me.gvModes.HighlightText = True
				Me.gvModes.TextUnderline = False
				Me.gvModes.TextWrap = True

				Me.gvModes.HighlightImageOffset = New Point(-2, -2)
				Me.gvModes.SelectingImageOffset = Point.Empty
				Me.gvModes.SelectingTextOffset = Point.Empty
			End If
		End Sub

		Private Sub rbO2KFolderBrowser_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbO2KFolderBrowser.CheckedChanged
			' Set the GroupView attributes for the Office 2000 folder browser type interface.
			If Me.rbO2KFolderBrowser.Checked = True Then
				Me.gvModes.SmallImageView = False
				Me.gvModes.ButtonView = True
				Me.gvModes.FlowView = False
				Me.gvModes.FlatLook = False

				Me.gvModes.BackColor = SystemColors.ControlDark
				If Me.gvModes.ThemesEnabled = False Then
					Me.gvModes.ForeColor = SystemColors.HighlightText
					Me.gvModes.HighlightTextColor = SystemColors.HighlightText
					Me.gvModes.SelectingTextColor = SystemColors.HighlightText
					Me.gvModes.SelectedTextColor = SystemColors.HighlightText
					Me.gvModes.SelectedHighlightTextColor = SystemColors.HighlightText
				Else
					Me.gvModes.ForeColor = SystemColors.ControlText
					Me.gvModes.HighlightTextColor = SystemColors.ControlText
					Me.gvModes.SelectingTextColor = SystemColors.ControlText
					Me.gvModes.SelectedTextColor = SystemColors.ControlText
					Me.gvModes.SelectedHighlightTextColor = SystemColors.ControlText
				End If
				Me.gvModes.HighlightItemColor = SystemColors.ControlDark
				Me.gvModes.SelectingItemColor = SystemColors.ControlDark
				Me.gvModes.SelectedItemColor = SystemColors.ControlDark
				Me.gvModes.SelectedHighlightItemColor = SystemColors.ControlDark

				Me.gvModes.ImageSpacing = 5
				Me.gvModes.ItemXSpacing = 8
				Me.gvModes.ItemYSpacing = 1

				Me.gvModes.ClipSelectionBounds = False
				Me.gvModes.HighlightText = True
				Me.gvModes.HighlightImage = True
				Me.gvModes.TextUnderline = False
				Me.gvModes.TextWrap = True

				Me.gvModes.HighlightImageOffset = Point.Empty
				Me.gvModes.SelectingImageOffset = Point.Empty
				Me.gvModes.SelectingTextOffset = Point.Empty
			End If
		End Sub

		Private Sub rbMessengerList_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbMessengerList.CheckedChanged
			' Set the GroupView attributes for the MSN Messenger list type interface.
			If Me.rbMessengerList.Checked = True Then
				Me.gvModes.SmallImageView = True
				Me.gvModes.ButtonView = True
				Me.gvModes.FlowView = False
				Me.gvModes.FlatLook = False

				Me.gvModes.BackColor = System.Drawing.Color.Beige
				Me.gvModes.ForeColor = SystemColors.ControlText
				Me.gvModes.HighlightItemColor = System.Drawing.Color.Beige
				Me.gvModes.HighlightTextColor = System.Drawing.Color.Coral
				Me.gvModes.SelectingItemColor = System.Drawing.Color.Beige
				Me.gvModes.SelectingTextColor = System.Drawing.Color.Coral
				Me.gvModes.SelectedItemColor = System.Drawing.Color.Beige
				Me.gvModes.SelectedTextColor = System.Drawing.Color.Coral
				Me.gvModes.SelectedHighlightItemColor = System.Drawing.Color.Beige
				Me.gvModes.SelectedHighlightTextColor = System.Drawing.Color.Coral

				Me.gvModes.ImageSpacing = 2
				Me.gvModes.ItemXSpacing = 8
				Me.gvModes.ItemYSpacing = 5

				Me.gvModes.ClipSelectionBounds = False
				Me.gvModes.HighlightImage = False
				Me.gvModes.HighlightText = False
				Me.gvModes.TextUnderline = False
				Me.gvModes.TextWrap = True

				Me.gvModes.HighlightImageOffset = Point.Empty
				Me.gvModes.SelectingImageOffset = New System.Drawing.Point(1, 1)
				Me.gvModes.SelectingTextOffset = New System.Drawing.Point(1, 1)
			End If
		End Sub

		Private Sub rbXPTaskBar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbXPTaskBar.CheckedChanged
			' Set the GroupView attributes for the XP TaskBar list type interface.
			If Me.rbXPTaskBar.Checked = True Then
				Me.gvModes.SmallImageView = True
				Me.gvModes.ButtonView = False
				Me.gvModes.FlowView = False
				Me.gvModes.FlatLook = False

				Me.gvModes.BackColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue)
				Me.gvModes.ForeColor = System.Drawing.Color.RoyalBlue
				Me.gvModes.HighlightItemColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue)
				Me.gvModes.HighlightTextColor = System.Drawing.Color.DeepSkyBlue
				Me.gvModes.SelectingItemColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue)
				Me.gvModes.SelectingTextColor = System.Drawing.Color.DeepSkyBlue
				Me.gvModes.SelectedItemColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue)
				Me.gvModes.SelectedTextColor = System.Drawing.Color.DeepSkyBlue
				Me.gvModes.SelectedHighlightItemColor = ControlPaint.LightLight(System.Drawing.Color.LightSteelBlue)
				Me.gvModes.SelectedHighlightTextColor = System.Drawing.Color.DeepSkyBlue

				Me.gvModes.ImageSpacing = 2
				Me.gvModes.ItemXSpacing = 8
				Me.gvModes.ItemYSpacing = 5

				Me.gvModes.ClipSelectionBounds = False
				Me.gvModes.HighlightImage = False
				Me.gvModes.HighlightText = False
				Me.gvModes.TextUnderline = True
				Me.gvModes.TextWrap = True

				Me.gvModes.HighlightImageOffset = Point.Empty
				Me.gvModes.SelectingImageOffset = Point.Empty
				Me.gvModes.SelectingTextOffset = Point.Empty
			End If
		End Sub

		#End Region

		#Region "sample code block"
		'
		'// This method is not used anywhere and is provided only to show how to
		'// programmatically create and initialize a GroupView control
		'// <samplecodeblock name="GroupView">
'private void InitializeGroupView()
'{
			'// Create the GroupView control
'this.gvcWinForms = new Syncfusion.Windows.Forms.Tools.GroupView();

			'// Set the large and small ImageLists
'this.gvcWinForms.LargeImageList = this.ilGroupBarLarge;
'this.gvcWinForms.SmallImageList = this.ilGroupBarSmall;
	
			'// Set the GroupView properties to display as a VS.NET Toolbox type window
'this.gvcWinForms.SmallImageView = true;
'this.gvcWinForms.ButtonView = true;
'this.gvcWinForms.FlowView = false;
'this.gvcWinForms.FlatLook = false;

'this.gvcWinForms.BackColor = SystemColors.Control;
'this.gvcWinForms.ForeColor = SystemColors.ControlText;
'this.gvcWinForms.HighlightItemColor = SystemColors.Control;
'this.gvcWinForms.HighlightTextColor = SystemColors.ControlText;
'this.gvcWinForms.SelectingItemColor = ControlPaint.Light(SystemColors.ControlLight);
'this.gvcWinForms.SelectingTextColor = SystemColors.ControlText;
'this.gvcWinForms.SelectedItemColor = ControlPaint.Light(SystemColors.ControlLight);
'this.gvcWinForms.SelectedTextColor = SystemColors.ControlText;
'this.gvcWinForms.SelectedHighlightItemColor = SystemColors.Control;
'this.gvcWinForms.SelectedHighlightTextColor = SystemColors.ControlText;

'this.gvcWinForms.ImageSpacing = 2;
'this.gvcWinForms.ItemXSpacing = 8;
'this.gvcWinForms.ItemYSpacing = 1;

'this.gvcWinForms.ClipSelectionBounds = false;
'this.gvcWinForms.HighlightImage = true;
'this.gvcWinForms.HighlightText = true;
'this.gvcWinForms.TextUnderline = false;
'this.gvcWinForms.TextWrap = false;
		
			'// Create and add the GroupViewItem objects
'this.gvcWinForms.GroupViewItems.AddRange(
'new Syncfusion.Windows.Forms.Tools.GroupViewItem[] {
'new Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11),
'new Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12),
'new Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13)});
																	   
			'// Provide a handler for the GroupView.GroupViewItemSelected event.
'this.gvcWinForms.GroupViewItemSelected += new System.EventHandler(this.gvcWinForms_GroupViewItemSelected);
'}
		
		'// GroupView.GroupViewItemSelected event handler.
'private void gvcWinForms_GroupViewItemSelected(object sender, System.EventArgs e)
'{
'MessageBox.Show(String.Concat("Selected Item Index = ", this.gvcWinForms.SelectedItem.ToString()));
'}
		'// </samplecodeblock>
'
		#End Region

		#Region "GroupView Events "
		' GroupView.GroupViewItemSelected event handler.
		Private Sub gvcWinForms_GroupViewItemSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvMain.GroupViewItemSelected
			Dim gview As GroupView = TryCast(sender, GroupView)
			Dim listViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "GroupViewItemSelected", "Selected Item : " & gview.GroupViewItems(gview.SelectedItem).Text })
			Me.listView1.Items.Add(listViewItem1)
		End Sub


		Private Sub gvcWinForms_GroupViewItemsReordered(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvMain.GroupViewItemsReordered
			Dim listViewItem1 As ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "GroupViewItemsReordered" })
			Me.listView1.Items.Add(listViewItem1)
		End Sub

		Private Sub gvcWinForms_GroupViewItemRenamed(ByVal obj As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.GroupItemRenamedEventArgs) Handles gvMain.GroupViewItemRenamed
			Dim listViewItem1 As ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "GroupViewItemRenamed", "Old Label: " & arg.OldLabel & " New Label: " & arg.NewLabel })
			Me.listView1.Items.Add(listViewItem1)
		End Sub

		#Region "ContextMenu"
		' Handler for the GroupView.ShowContextMenu event.
		Private Sub gvc_ShowContextMenu(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvMain.ShowContextMenu
			Dim listViewItem1 As ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "ContextMenu Shown" })
			Me.listView1.Items.Add(listViewItem1)

			Dim menu As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu()

			menu.ParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			menu.ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003

			Dim additem As BarItem = New BarItem("Add New Item", New EventHandler(AddressOf Me.gvc_MenuAddNewItem))
			additem.ImageList = Me.ilGroupBarSmall
			additem.ImageIndex = 17
			menu.ParentBarItem.Items.Add(additem)

			Dim removeitem As BarItem = New BarItem("Remove Item", New EventHandler(AddressOf Me.gvc_MenuRemoveItem))
			removeitem.ImageList = Me.ilGroupBarSmall
			removeitem.ImageIndex = 18
			menu.ParentBarItem.Items.Add(removeitem)

			Dim renameitem As BarItem = New BarItem("Rename Item", New EventHandler(AddressOf Me.gvc_MenuRenameItem))
			menu.ParentBarItem.Items.Add(renameitem)

			If Me.gvMain.ButtonView = True Then
				Dim listviewitem As BarItem = Nothing
				listviewitem = New BarItem("List View", New EventHandler(AddressOf Me.gvc_MenuListView))
				If Me.gvMain.FlowView = False Then
					listviewitem.Checked = True
				Else
					listviewitem.Checked = False
				End If
				menu.ParentBarItem.Items.Add(listviewitem)

				Dim moveupitem As BarItem = New BarItem("Move &Up", New EventHandler(AddressOf Me.gvc_MenuMoveUpDown))
				moveupitem.ImageList = Me.ilGroupBarSmall
				moveupitem.ImageIndex = 19
				menu.ParentBarItem.Items.Add(moveupitem)
				If Me.gvMain.SelectedItem <= 0 Then
					moveupitem.Enabled = False
				End If

				Dim movedownitem As BarItem = New BarItem("Move &Down", New EventHandler(AddressOf Me.gvc_MenuMoveUpDown))
				movedownitem.ImageList = Me.ilGroupBarSmall
				movedownitem.ImageIndex = 20
				menu.ParentBarItem.Items.Add(movedownitem)
				If Me.gvMain.SelectedItem >= Me.gvMain.GroupViewItems.Count - 1 Then
					movedownitem.Enabled = False
				End If

				If Not listviewitem Is Nothing Then
					menu.ParentBarItem.BeginGroupAt(listviewitem)
				End If
				menu.ParentBarItem.BeginGroupAt(moveupitem)
			End If

			If Me.gvMain.HighlightedItem = -1 Then
				removeitem.Enabled = False
				renameitem.Enabled = False
			End If

			If Syncfusion.Windows.Forms.XPThemes.IsThemedOS AndAlso Syncfusion.Windows.Forms.XPThemes.IsThemeActive Then
				Dim themedrawingitem As BarItem = New BarItem("Theme &Drawing", New EventHandler(AddressOf Me.gvc_ThemeDrawing))
				If Me.gvMain.ThemesEnabled = True Then
					themedrawingitem.Checked = True
				Else
					themedrawingitem.Checked = False
				End If
				menu.ParentBarItem.Items.Add(themedrawingitem)
				menu.ParentBarItem.BeginGroupAt(themedrawingitem)
			End If

			menu.Show(Me.gvMain, Me.gvMain.PointToClient(Cursor.Position))
		End Sub

		Public Sub gvc_MenuAddNewItem(ByVal sender As Object, ByVal e As EventArgs)

			Dim grpvwitem As Syncfusion.Windows.Forms.Tools.GroupViewItem = New Syncfusion.Windows.Forms.Tools.GroupViewItem()
			grpvwitem.Text = "New Item"
			grpvwitem.ImageIndex = 0
			Me.gvMain.GroupViewItems.Add(grpvwitem)

			Dim listViewItem1 As ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "GroupViewItemAdded", "Newly Added Item :" & Me.gvModes.GroupViewItems(Me.gvModes.GroupViewItems.Count - 1).Text })
			Me.listView1.Items.Add(listViewItem1)
		End Sub

		Private Sub gvc_MenuRemoveItem(ByVal sender As Object, ByVal e As EventArgs)
			Dim nitem As Integer = Me.gvMain.ContextMenuItem
			If (nitem >= 0) AndAlso (nitem < Me.gvMain.GroupViewItems.Count) Then
				Dim grpvwitem As Syncfusion.Windows.Forms.Tools.GroupViewItem = Me.gvMain.GroupViewItems(nitem)
				Me.gvMain.GroupViewItems.Remove(grpvwitem)
				Dim listViewItem1 As ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "GroupViewItemRemoved", "Deleted Item :" & grpvwitem.Text })
				Me.listView1.Items.Add(listViewItem1)
			End If
		End Sub

		Private Sub gvc_MenuRenameItem(ByVal sender As Object, ByVal e As EventArgs)
			Dim nitem As Integer = Me.gvMain.ContextMenuItem
			If (nitem >= 0) AndAlso (nitem < Me.gvMain.GroupViewItems.Count) Then
				Me.gvMain.InplaceRenameItem(nitem)
			End If
			Dim listViewItem1 As ListViewItem = New System.Windows.Forms.ListViewItem(New String() { "GroupViewItemRenaming" })
			Me.listView1.Items.Add(listViewItem1)
		End Sub
		Private Sub gvc_MenuListView(ByVal sender As Object, ByVal e As EventArgs)
			Me.cbFlowView.Checked = Not Me.cbFlowView.Checked
		End Sub

		Private Sub gvc_MenuMoveUpDown(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As BarItem = TryCast(sender, BarItem)
			If item.Text = "Move &Up" Then
				Me.gvMain.SelectedItem = Me.gvMain.SelectedItem - 1
			Else
				Me.gvMain.SelectedItem = Me.gvMain.SelectedItem + 1
			End If
		End Sub

		Private Sub gvc_ThemeDrawing(ByVal sender As Object, ByVal e As EventArgs)
			Dim item As BarItem = TryCast(sender, BarItem)
			If item.Checked = False Then
				Me.gvMain.ThemesEnabled = True
				Me.cbThemesEnabled.Checked = True
			Else
				Me.gvMain.ThemesEnabled = False
				Me.cbThemesEnabled.Checked = False
			End If
		End Sub
		#End Region
#End Region

		#Region "Groupview properties"






		Private Sub cpBackColor_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpBackColor.ColorSelected
			Me.gvMain.BackColor = cpBackColor.SelectedColor
		End Sub



		Private Sub cmbGVBorder_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbGVBorder.SelectedIndexChanged
			Me.gvMain.BorderStyle = CType(System.Enum.Parse(GetType(BorderStyle), Me.cmbGVBorder.SelectedItem.ToString(), True), BorderStyle)
		End Sub

		Private Sub cbButtonView_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbButtonView.CheckedChanged
			Me.gvMain.ButtonView = cbButtonView.Checked
		End Sub

		Private Sub cbHighightText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbHighightText.CheckedChanged
			Me.gvMain.HighlightText = cbHighightText.Checked
			Me.cbButtonView.Enabled = cbHighightText.Checked
		End Sub

		Private Sub nUDHighlightOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDHighlightOffset.ValueChanged
			Me.gvMain.HighlightTextOffset = New Point(CInt(Me.nUDHighlightOffset.Value))
		End Sub

		Private Sub nUDSelectingOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDSelectingOffset.ValueChanged
			Me.gvMain.SelectingTextOffset = New Point(CInt(Me.nUDSelectingOffset.Value))
		End Sub

		Private Sub nUDSelectedOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDSelectedOffset.ValueChanged
			Me.gvMain.SelectedTextOffset = New Point(CInt(Me.nUDSelectedOffset.Value))
		End Sub

		Private Sub nUDSelectedHighlightOffset_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDSelectedHighlightOffset.ValueChanged
			Me.gvMain.SelectedHighlightTextOffset = New Point(CInt(Me.nUDSelectedHighlightOffset.Value))
		End Sub

		Private Sub cbFlowView_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFlowView.CheckedChanged
			Me.gvMain.FlowView = Me.cbFlowView.Checked
		End Sub

		Private Sub nUDTextSpacing_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUDTextSpacing.ValueChanged
			Me.gvMain.TextSpacing = CInt(Me.nUDTextSpacing.Value)
		End Sub

		Private Sub cbTextUnderline_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTextUnderline.CheckedChanged
			Me.gvMain.TextUnderline = cbTextUnderline.Checked
		End Sub

		Private Sub cbTextWrap_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbTextWrap.CheckedChanged
			If cbTextWrap.Checked Then
				Me.gvMain.TextWrap = True
				Me.gvMain.Width = 125
			Else
				Me.gvMain.TextWrap = False
				Me.gvMain.Width = 168
			End If
		End Sub
		Private Sub cpHighlightText_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpHighlightText.ColorSelected
			Me.gvMain.HighlightTextColor = cpHighlightText.SelectedColor
		End Sub

		Private Sub cpHighlightItem_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpHighlightItem.ColorSelected
			Me.gvMain.HighlightItemColor = cpHighlightItem.SelectedColor
		End Sub

		Private Sub cpSelectedHlText_ColorSelected_1(ByVal sender As Object, ByVal e As EventArgs) Handles cpSelectedHlText.ColorSelected
			Me.gvMain.SelectedHighlightTextColor = cpSelectedHlText.SelectedColor
		End Sub

		Private Sub cpselectedHlItem_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpselectedHlItem.ColorSelected
			Me.gvMain.SelectedHighlightItemColor = cpselectedHlItem.SelectedColor
		End Sub
		Private Sub cpSelectedTextColor_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpSelectedTextColor.ColorSelected
			Me.gvMain.SelectedTextColor = cpSelectedTextColor.SelectedColor
		End Sub
		Private Sub cpSelectedItemColor_ColorSelected(ByVal sender As Object, ByVal e As EventArgs) Handles cpSelectedItemColor.ColorSelected
			Me.gvMain.SelectedItemColor = Me.cpSelectedItemColor.SelectedColor
		End Sub
		Private Sub cbToolTips_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbToolTips.CheckedChanged
			Me.gvMain.ShowToolTips = cbToolTips.Checked
		End Sub
		Private Sub cbFlowViewItemText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbFlowViewItemText.CheckedChanged
			Me.gvMain.ShowFlowViewItemText = cbFlowViewItemText.Checked
		End Sub

		Private Sub numericUpDownExt1_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles numericUpDownExt1.ValueChanged
			Me.gvMain.ImageSpacing = CInt(Me.numericUpDownExt1.Value)
		End Sub

		Private Sub cbIntegratedScrolling_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbIntegratedScrolling.CheckedChanged
			Me.gvMain.IntegratedScrolling = Not Me.cbIntegratedScrolling.Checked
		End Sub

		Private Sub cmbOrientation_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbOrientation.SelectedIndexChanged
			If Me.cmbOrientation.SelectedIndex = 0 Then
				Me.gvMain.Orientation = GroupViewOrientation.Horizontal
			Else
				Me.gvMain.Orientation = GroupViewOrientation.Vertical
			End If
		End Sub

		Private Sub cbThemesEnabled_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbThemesEnabled.CheckedChanged
			Me.gvMain.ThemesEnabled = cbThemesEnabled.Checked
		End Sub


		'Code to make the Custom GroupView scroll up and down.
		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			If timer1.Interval >= 100 AndAlso timer1.Interval <= 1100 Then
				Me.timer1.Interval = timer1.Interval + 50
			End If
			If timer1.Interval >= 100 AndAlso timer1.Interval < 600 Then
				Me.gvFeatures.ScrollGroupView(True)

			End If
			If timer1.Interval > 600 AndAlso timer1.Interval < 1200 Then
				Me.gvFeatures.ScrollGroupView(False)

			End If
			If timer1.Interval >= 1100 Then
				Me.timer1.Interval = 100
			End If

		End Sub

		Private Sub cbHighlightImage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbHighlightImage.CheckedChanged
			Me.gvMain.HighlightImage = cbHighlightImage.Checked
		End Sub

		Private Sub groupView1_GroupViewItemHighlighted(ByVal sender As Object, ByVal e As EventArgs) Handles gvFeatures.GroupViewItemHighlighted
			   Me.timer1.Enabled = False
		End Sub

		Private Sub groupView1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles gvFeatures.MouseLeave
			Me.timer1.Enabled = True
		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			Me.listView1.Items.Clear()
		End Sub

		  #End Region

		#End Region
	End Class

	#Region "CustomGroupView"
	Public Class CustomGroupView : Inherits GroupView

		Public Sub ScrollGroupView(ByVal x As Boolean)
		   Me.DoScroll(x, False)

		End Sub
	End Class
	#End Region
End Namespace
