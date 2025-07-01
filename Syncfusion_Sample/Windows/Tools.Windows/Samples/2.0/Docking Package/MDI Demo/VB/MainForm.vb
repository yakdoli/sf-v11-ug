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
	Imports System.ComponentModel
	Imports System.Drawing
	Imports System.Windows.Forms
	Imports System.Reflection
	Imports System.Diagnostics
	Imports System.Runtime.InteropServices
	Imports Microsoft.Win32
	Imports Syncfusion.Runtime.Serialization
	Imports Syncfusion.Windows.Forms.Tools.XPMenus
	Imports Syncfusion.Windows.Forms.Tools
	Imports Syncfusion.Windows.Forms
Namespace MDIDemo


	Public Class MainForm : Inherits Office2007Form
		#Region "Members declaration"

		Private dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
		Private components As System.ComponentModel.IContainer

		Private windowCount As Integer = 0
		Private toolBarButton1 As System.Windows.Forms.ToolBarButton
		Private toolBarButton2 As System.Windows.Forms.ToolBarButton
		Private toolBarButton3 As System.Windows.Forms.ToolBarButton
		Private toolBarButton4 As System.Windows.Forms.ToolBarButton
		Private toolBarButton5 As System.Windows.Forms.ToolBarButton
		Private toolBarButton6 As System.Windows.Forms.ToolBarButton
		Private toolBarButton7 As System.Windows.Forms.ToolBarButton
		Private ilCommon As System.Windows.Forms.ImageList
		Private pnlSlnToolBar As System.Windows.Forms.Panel
		Private tbSlnPanel As System.Windows.Forms.ToolBar
		Private tvNetwork As System.Windows.Forms.TreeView
		Private dwCurrent As System.Windows.Forms.ListBox
		Private dwDocumentBrowser As System.Windows.Forms.TreeView
		Private dwNotes2 As System.Windows.Forms.TextBox
		Private dwNotes1 As System.Windows.Forms.TextBox
		Private dwNetwork As System.Windows.Forms.Panel

		' Used during CommandBar dockstate changes.
		Private szToolBarPanel As Size
		Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private cbToolBar As CommandBar
		Private barItem20 As BarItem
		Private bar4 As Bar
		Private toolStripEx1 As ToolStripEx
		Private WithEvents chkOffice2007Mdi As ToolStripCheckBox
		Private toolStripSeparator1 As ToolStripSeparator
		Private clrSchemeDD As ToolStripDropDownButton
		Private WithEvents blueClrScheme As ToolStripMenuItem
		Private WithEvents silverClrScheme As ToolStripMenuItem
		Private WithEvents blackClrScheme As ToolStripMenuItem
		Private CustomColorScheme As ToolStripMenuItem
		Private WithEvents tsbNew As ToolStripButton
		Private WithEvents tsbOpen As ToolStripButton
		Private WithEvents tsbSave As ToolStripButton
		Private WithEvents cmbFontFace As ToolStripComboBox
		Private WithEvents cmbFontSize As ToolStripComboBox
		Private toolStripSeparator2 As ToolStripSeparator
		Private toolStripSeparator3 As ToolStripSeparator
		Private szToolBarCommandBarPanel As Size
#End Region

		#Region "Initialization"
		Public Sub New()
			'
			' Required for Windows Form Designer support.
			'

			InitializeComponent()

			CustomColorsDropDownImpl()
			'Set up MDI stuff.
			Me.IsMdiContainer = True
			AddHandler MdiChildActivate, AddressOf MDIChildActivated
			' Get the toolbar and CommandBar panel sizes.
			Me.szToolBarPanel = New Size(80,24)
			Me.szToolBarCommandBarPanel = New Size(273,24)

            Me.cmbFontFace.SelectedIndex = 0
			Me.cmbFontSize.SelectedIndex = 1

			'Status Bar
			Me.bar4 = New Bar()
			Me.mainFrameBarManager1.Bars.Add(bar4)
			Me.bar4.BarName = "Status Bar"
			Me.bar4.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsStatusBar), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar4.Caption = "Status Bar"
			Me.bar4.Items.Add(barItem20)
			Me.bar4.Manager = Me.mainFrameBarManager1
			AddHandler Load, AddressOf MainForm_Load
            AddHandler Me.dockingManager1.NewDockStateEndLoad, AddressOf dockingManager1_NewDockStateEndLoad
            
        End Sub

        Private Sub dockingManager1_NewDockStateEndLoad(ByVal sender As Object, ByVal e As EventArgs)

            CreateNewDocument()


        End Sub


		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
            Me.dockingManager1.SetAsMDIChild(Me.dwDocumentBrowser, True)
		End Sub

		''' <summary>
		'''    Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub



		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main(ByVal args As String())
			' Modify this version, whenever changes are made such that the persisted state cannot be loaded anymore.
			Dim curVersion As String = "1.0"
			ValidatePersistedStateVersion(curVersion)
			StoreVersionInfo(curVersion)
'INSTANT VB NOTE: The local variable mainForm was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
			Dim mainForm_Renamed As MainForm = New MainForm()
			Application.Run(mainForm_Renamed)
		End Sub

		''' <summary>
		'''    Required method for Designer support - do not modify
		'''    the contents of this method with the code editor.
		''' </summary>
		Protected Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
			Dim ccbdwCurrent As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Dim ccbdwDocumentBrowser As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Dim ccbdwNotes2 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Dim ccbdwNetwork As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Dim ccbdwNotes1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection()
			Dim treeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Amber", 35, 35)
			Dim treeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Services", 30, 30, New System.Windows.Forms.TreeNode() { treeNode1})
			Dim treeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("John", 31, 31)
			Dim treeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Smith", 32, 32)
			Dim treeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Field Units", 30, 30, New System.Windows.Forms.TreeNode() { treeNode2, treeNode3, treeNode4})
			Dim treeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Steve 1", 36, 36)
			Dim treeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Steve 2", 34, 34)
			Dim treeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Caldito", 33, 33)
			Dim treeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Luxor", 32, 32)
			Dim treeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Marketing/Sales", 30, 30, New System.Windows.Forms.TreeNode() { treeNode6, treeNode7, treeNode8, treeNode9})
			Dim treeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salem", 31, 31)
			Dim treeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Amityville", 31, 31)
			Dim treeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deployment Servers", 37, 37, New System.Windows.Forms.TreeNode() { treeNode11, treeNode12})
			Dim treeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(" Brad", 31, 31)
			Dim treeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Anton", 37, 37, New System.Windows.Forms.TreeNode() { treeNode14})
			Dim treeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Technical Support", 30, 30, New System.Windows.Forms.TreeNode() { treeNode15})
			Dim treeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bill", 32, 32)
			Dim treeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mark", 32, 32)
			Dim treeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Steve", 31, 31)
			Dim treeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MaryAnn", 31, 31)
			Dim treeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LP1", 36, 36)
			Dim treeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LP2", 36, 36)
			Dim treeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Print Server", 30, 30, New System.Windows.Forms.TreeNode() { treeNode21, treeNode22})
			Dim treeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Development", 37, 37, New System.Windows.Forms.TreeNode() { treeNode17, treeNode18, treeNode19, treeNode20, treeNode23})
			Dim treeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solution 1", 22, 22)
			Dim treeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solution 2", 22, 22)
			Dim treeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trial", 22, 22)
			Dim treeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clerks", 24, 24)
			Dim treeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("WorkIssue", 24, 24)
			Dim treeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("QuickSolutions", 25, 25, New System.Windows.Forms.TreeNode() { treeNode25, treeNode26, treeNode27, treeNode28, treeNode29})
			Dim treeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clients")
			Dim treeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Office1", 22, 22, New System.Windows.Forms.TreeNode() { treeNode31})
			Dim treeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BG Group", 25, 25, New System.Windows.Forms.TreeNode() { treeNode32})
			Dim treeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contacts", 8, 8)
			Dim treeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Referrals")
			Dim treeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("QuickSoft Solutions", 26, 26, New System.Windows.Forms.TreeNode() { treeNode34, treeNode35})
			Dim treeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ABCL Sales", 22, 22)
			Dim treeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("BetaSoft", 24, 24)
			Dim treeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NC", 8, 8)
			Dim treeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SC", 9, 9)
			Dim treeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GA")
			Dim treeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ZincLite Inc", 27, 27, New System.Windows.Forms.TreeNode() { treeNode39, treeNode40, treeNode41})
			Dim treeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales 1", 22, 22)
			Dim treeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Sales 2", 22, 22)
			Dim treeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Complaints", 10, 10)
			Dim treeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("MicroCorp", 23, 23, New System.Windows.Forms.TreeNode() { treeNode43, treeNode44, treeNode45})
			Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
			Me.ilCommon = New System.Windows.Forms.ImageList(Me.components)
			Me.dwNotes2 = New System.Windows.Forms.TextBox()
			Me.dwNotes1 = New System.Windows.Forms.TextBox()
			Me.dwNetwork = New System.Windows.Forms.Panel()
			Me.tvNetwork = New System.Windows.Forms.TreeView()
			Me.pnlSlnToolBar = New System.Windows.Forms.Panel()
			Me.tbSlnPanel = New System.Windows.Forms.ToolBar()
			Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton4 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton5 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton6 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton7 = New System.Windows.Forms.ToolBarButton()
			Me.dwCurrent = New System.Windows.Forms.ListBox()
			Me.dwDocumentBrowser = New System.Windows.Forms.TreeView()
			Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
			Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "MainMenu")
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.cbToolBar = New Syncfusion.Windows.Forms.Tools.CommandBar()
			Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.tsbNew = New System.Windows.Forms.ToolStripButton()
			Me.tsbOpen = New System.Windows.Forms.ToolStripButton()
			Me.tsbSave = New System.Windows.Forms.ToolStripButton()
			Me.cmbFontFace = New System.Windows.Forms.ToolStripComboBox()
			Me.cmbFontSize = New System.Windows.Forms.ToolStripComboBox()
			Me.chkOffice2007Mdi = New Syncfusion.Windows.Forms.Tools.ToolStripCheckBox()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.clrSchemeDD = New System.Windows.Forms.ToolStripDropDownButton()
			Me.blueClrScheme = New System.Windows.Forms.ToolStripMenuItem()
			Me.silverClrScheme = New System.Windows.Forms.ToolStripMenuItem()
			Me.blackClrScheme = New System.Windows.Forms.ToolStripMenuItem()
			Me.CustomColorScheme = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dwNetwork.SuspendLayout()
			Me.pnlSlnToolBar.SuspendLayout()
			CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolStripEx1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' dockingManager1
			' 
			Me.dockingManager1.ActiveCaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.dockingManager1.DockLayoutStream = (CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream))
			Me.dockingManager1.ForwardMenuShortcuts = False
			Me.dockingManager1.HostControl = Me
			Me.dockingManager1.ImageList = Me.ilCommon
			Me.dockingManager1.Office2007MdiChildForm = True
			Me.dockingManager1.Office2007MdiColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue
			Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
			Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
			Me.dockingManager1.SetDockLabel(Me.dwCurrent, "Current")
			Me.dockingManager1.SetDockIcon(Me.dwCurrent, 45)
			ccbdwCurrent.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.dwCurrent, ccbdwCurrent)
			Me.dockingManager1.SetDockLabel(Me.dwDocumentBrowser, "Document Browser")
			Me.dockingManager1.SetDockIcon(Me.dwDocumentBrowser, 47)
			ccbdwDocumentBrowser.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.dwDocumentBrowser, ccbdwDocumentBrowser)
			Me.dockingManager1.SetDockLabel(Me.dwNotes2, "Notes 2")
			Me.dockingManager1.SetDockIcon(Me.dwNotes2, 9)
			ccbdwNotes2.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.dwNotes2, ccbdwNotes2)
			Me.dockingManager1.SetDockLabel(Me.dwNetwork, "Network")
			Me.dockingManager1.SetDockIcon(Me.dwNetwork, 46)
			ccbdwNetwork.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.dwNetwork, ccbdwNetwork)
			Me.dockingManager1.SetDockLabel(Me.dwNotes1, "Notes 1")
			Me.dockingManager1.SetDockIcon(Me.dwNotes1, 9)
			ccbdwNotes1.MergeWith(Me.dockingManager1.CaptionButtons, False)
			Me.dockingManager1.SetCustomCaptionButtons(Me.dwNotes1, ccbdwNotes1)
			' 
			' ilCommon
			' 
			Me.ilCommon.ImageStream = (CType(resources.GetObject("ilCommon.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ilCommon.TransparentColor = System.Drawing.Color.Transparent
			Me.ilCommon.Images.SetKeyName(0, "")
			Me.ilCommon.Images.SetKeyName(1, "")
			Me.ilCommon.Images.SetKeyName(2, "")
			Me.ilCommon.Images.SetKeyName(3, "")
			Me.ilCommon.Images.SetKeyName(4, "")
			Me.ilCommon.Images.SetKeyName(5, "")
			Me.ilCommon.Images.SetKeyName(6, "")
			Me.ilCommon.Images.SetKeyName(7, "")
			Me.ilCommon.Images.SetKeyName(8, "")
			Me.ilCommon.Images.SetKeyName(9, "")
			Me.ilCommon.Images.SetKeyName(10, "")
			Me.ilCommon.Images.SetKeyName(11, "")
			Me.ilCommon.Images.SetKeyName(12, "")
			Me.ilCommon.Images.SetKeyName(13, "")
			Me.ilCommon.Images.SetKeyName(14, "")
			Me.ilCommon.Images.SetKeyName(15, "")
			Me.ilCommon.Images.SetKeyName(16, "")
			Me.ilCommon.Images.SetKeyName(17, "")
			Me.ilCommon.Images.SetKeyName(18, "")
			Me.ilCommon.Images.SetKeyName(19, "")
			Me.ilCommon.Images.SetKeyName(20, "")
			Me.ilCommon.Images.SetKeyName(21, "")
			Me.ilCommon.Images.SetKeyName(22, "")
			Me.ilCommon.Images.SetKeyName(23, "")
			Me.ilCommon.Images.SetKeyName(24, "")
			Me.ilCommon.Images.SetKeyName(25, "")
			Me.ilCommon.Images.SetKeyName(26, "")
			Me.ilCommon.Images.SetKeyName(27, "")
			Me.ilCommon.Images.SetKeyName(28, "")
			Me.ilCommon.Images.SetKeyName(29, "")
			Me.ilCommon.Images.SetKeyName(30, "")
			Me.ilCommon.Images.SetKeyName(31, "")
			Me.ilCommon.Images.SetKeyName(32, "")
			Me.ilCommon.Images.SetKeyName(33, "")
			Me.ilCommon.Images.SetKeyName(34, "")
			Me.ilCommon.Images.SetKeyName(35, "")
			Me.ilCommon.Images.SetKeyName(36, "")
			Me.ilCommon.Images.SetKeyName(37, "")
			Me.ilCommon.Images.SetKeyName(38, "")
			Me.ilCommon.Images.SetKeyName(39, "")
			Me.ilCommon.Images.SetKeyName(40, "")
			Me.ilCommon.Images.SetKeyName(41, "")
			Me.ilCommon.Images.SetKeyName(42, "")
			Me.ilCommon.Images.SetKeyName(43, "")
			Me.ilCommon.Images.SetKeyName(44, "")
			Me.ilCommon.Images.SetKeyName(45, "")
			Me.ilCommon.Images.SetKeyName(46, "")
			Me.ilCommon.Images.SetKeyName(47, "")
			Me.ilCommon.Images.SetKeyName(48, "colors.png")
			' 
			' dwNotes2
			' 
			Me.dwNotes2.BackColor = System.Drawing.Color.White
			Me.dwNotes2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.dockingManager1.SetEnableDocking(Me.dwNotes2, True)
			Me.dwNotes2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.dwNotes2.Location = New System.Drawing.Point(3, 23)
			Me.dwNotes2.Multiline = True
			Me.dwNotes2.Name = "dwNotes2"
			Me.dwNotes2.Size = New System.Drawing.Size(737, 82)
			Me.dwNotes2.TabIndex = 13
			Me.dwNotes2.Text = "NOTE - Replace disks for all project files."
			' 
			' dwNotes1
			' 
			Me.dwNotes1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.dockingManager1.SetEnableDocking(Me.dwNotes1, True)
			Me.dwNotes1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.dwNotes1.Location = New System.Drawing.Point(3, 23)
			Me.dwNotes1.Multiline = True
			Me.dwNotes1.Name = "dwNotes1"
			Me.dwNotes1.Size = New System.Drawing.Size(737, 82)
			Me.dwNotes1.TabIndex = 17
			Me.dwNotes1.Text = "Send profiles to Suzanne."
			' 
			' dwNetwork
			' 
			Me.dwNetwork.Controls.Add(Me.tvNetwork)
			Me.dwNetwork.Controls.Add(Me.pnlSlnToolBar)
			Me.dockingManager1.SetEnableDocking(Me.dwNetwork, True)
			Me.dwNetwork.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F)
			Me.dwNetwork.Location = New System.Drawing.Point(3, 23)
			Me.dwNetwork.Name = "dwNetwork"
			Me.dwNetwork.Size = New System.Drawing.Size(155, 410)
			Me.dwNetwork.TabIndex = 16
			' 
			' tvNetwork
			' 
			Me.tvNetwork.BackColor = System.Drawing.Color.White
			Me.tvNetwork.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tvNetwork.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.tvNetwork.ImageIndex = 0
			Me.tvNetwork.ImageList = Me.ilCommon
			Me.tvNetwork.Location = New System.Drawing.Point(0, 23)
			Me.tvNetwork.Name = "tvNetwork"
			treeNode1.ImageIndex = 35
			treeNode1.Name = ""
			treeNode1.SelectedImageIndex = 35
			treeNode1.Text = "Amber"
			treeNode2.ImageIndex = 30
			treeNode2.Name = ""
			treeNode2.SelectedImageIndex = 30
			treeNode2.Text = "Services"
			treeNode3.ImageIndex = 31
			treeNode3.Name = ""
			treeNode3.SelectedImageIndex = 31
			treeNode3.Text = "John"
			treeNode4.ImageIndex = 32
			treeNode4.Name = ""
			treeNode4.SelectedImageIndex = 32
			treeNode4.Text = "Smith"
			treeNode5.ImageIndex = 30
			treeNode5.Name = ""
			treeNode5.SelectedImageIndex = 30
			treeNode5.Text = "Field Units"
			treeNode6.ImageIndex = 36
			treeNode6.Name = ""
			treeNode6.SelectedImageIndex = 36
			treeNode6.Text = "Steve 1"
			treeNode7.ImageIndex = 34
			treeNode7.Name = ""
			treeNode7.SelectedImageIndex = 34
			treeNode7.Text = "Steve 2"
			treeNode8.ImageIndex = 33
			treeNode8.Name = ""
			treeNode8.SelectedImageIndex = 33
			treeNode8.Text = "Caldito"
			treeNode9.ImageIndex = 32
			treeNode9.Name = ""
			treeNode9.SelectedImageIndex = 32
			treeNode9.Text = "Luxor"
			treeNode10.ImageIndex = 30
			treeNode10.Name = ""
			treeNode10.SelectedImageIndex = 30
			treeNode10.Text = "Marketing/Sales"
			treeNode11.ImageIndex = 31
			treeNode11.Name = ""
			treeNode11.SelectedImageIndex = 31
			treeNode11.Text = "Salem"
			treeNode12.ImageIndex = 31
			treeNode12.Name = ""
			treeNode12.SelectedImageIndex = 31
			treeNode12.Text = "Amityville"
			treeNode13.ImageIndex = 37
			treeNode13.Name = ""
			treeNode13.SelectedImageIndex = 37
			treeNode13.Text = "Deployment Servers"
			treeNode14.ImageIndex = 31
			treeNode14.Name = ""
			treeNode14.SelectedImageIndex = 31
			treeNode14.Text = " Brad"
			treeNode15.ImageIndex = 37
			treeNode15.Name = ""
			treeNode15.SelectedImageIndex = 37
			treeNode15.Text = "Anton"
			treeNode16.ImageIndex = 30
			treeNode16.Name = ""
			treeNode16.SelectedImageIndex = 30
			treeNode16.Text = "Technical Support"
			treeNode17.ImageIndex = 32
			treeNode17.Name = ""
			treeNode17.SelectedImageIndex = 32
			treeNode17.Text = "Bill"
			treeNode18.ImageIndex = 32
			treeNode18.Name = ""
			treeNode18.SelectedImageIndex = 32
			treeNode18.Text = "Mark"
			treeNode19.ImageIndex = 31
			treeNode19.Name = ""
			treeNode19.SelectedImageIndex = 31
			treeNode19.Text = "Steve"
			treeNode20.ImageIndex = 31
			treeNode20.Name = ""
			treeNode20.SelectedImageIndex = 31
			treeNode20.Text = "MaryAnn"
			treeNode21.ImageIndex = 36
			treeNode21.Name = ""
			treeNode21.SelectedImageIndex = 36
			treeNode21.Text = "LP1"
			treeNode22.ImageIndex = 36
			treeNode22.Name = ""
			treeNode22.SelectedImageIndex = 36
			treeNode22.Text = "LP2"
			treeNode23.ImageIndex = 30
			treeNode23.Name = ""
			treeNode23.SelectedImageIndex = 30
			treeNode23.Text = "Print Server"
			treeNode24.ImageIndex = 37
			treeNode24.Name = ""
			treeNode24.SelectedImageIndex = 37
			treeNode24.Text = "Development"
			Me.tvNetwork.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode5, treeNode10, treeNode13, treeNode16, treeNode24})
			Me.tvNetwork.SelectedImageIndex = 0
			Me.tvNetwork.Size = New System.Drawing.Size(155, 387)
			Me.tvNetwork.TabIndex = 1
			' 
			' pnlSlnToolBar
			' 
			Me.pnlSlnToolBar.Controls.Add(Me.tbSlnPanel)
			Me.pnlSlnToolBar.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnlSlnToolBar.Location = New System.Drawing.Point(0, 0)
			Me.pnlSlnToolBar.Name = "pnlSlnToolBar"
			Me.pnlSlnToolBar.Size = New System.Drawing.Size(155, 23)
			Me.pnlSlnToolBar.TabIndex = 23
			' 
			' tbSlnPanel
			' 
			Me.tbSlnPanel.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
			Me.tbSlnPanel.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() { Me.toolBarButton1, Me.toolBarButton2, Me.toolBarButton3, Me.toolBarButton4, Me.toolBarButton5, Me.toolBarButton6, Me.toolBarButton7})
			Me.tbSlnPanel.ButtonSize = New System.Drawing.Size(23, 20)
			Me.tbSlnPanel.Divider = False
			Me.tbSlnPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tbSlnPanel.DropDownArrows = True
			Me.tbSlnPanel.ImageList = Me.ilCommon
			Me.tbSlnPanel.Location = New System.Drawing.Point(0, 0)
			Me.tbSlnPanel.Name = "tbSlnPanel"
			Me.tbSlnPanel.ShowToolTips = True
			Me.tbSlnPanel.Size = New System.Drawing.Size(155, 26)
			Me.tbSlnPanel.TabIndex = 0
			' 
			' toolBarButton1
			' 
			Me.toolBarButton1.ImageIndex = 41
			Me.toolBarButton1.Name = "toolBarButton1"
			Me.toolBarButton1.ToolTipText = "View Code"
			' 
			' toolBarButton2
			' 
			Me.toolBarButton2.ImageIndex = 5
			Me.toolBarButton2.Name = "toolBarButton2"
			Me.toolBarButton2.ToolTipText = "View Designer"
			' 
			' toolBarButton3
			' 
			Me.toolBarButton3.Name = "toolBarButton3"
			Me.toolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
			' 
			' toolBarButton4
			' 
			Me.toolBarButton4.ImageIndex = 44
			Me.toolBarButton4.Name = "toolBarButton4"
			Me.toolBarButton4.ToolTipText = "Refresh"
			' 
			' toolBarButton5
			' 
			Me.toolBarButton5.ImageIndex = 43
			Me.toolBarButton5.Name = "toolBarButton5"
			Me.toolBarButton5.ToolTipText = "Show All Files"
			' 
			' toolBarButton6
			' 
			Me.toolBarButton6.Name = "toolBarButton6"
			Me.toolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
			' 
			' toolBarButton7
			' 
			Me.toolBarButton7.ImageIndex = 42
			Me.toolBarButton7.Name = "toolBarButton7"
			Me.toolBarButton7.ToolTipText = "Properties"
			' 
			' dwCurrent
			' 
			Me.dwCurrent.BackColor = System.Drawing.Color.White
			Me.dwCurrent.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.dockingManager1.SetEnableDocking(Me.dwCurrent, True)
			Me.dwCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.dwCurrent.IntegralHeight = False
			Me.dwCurrent.Items.AddRange(New Object() { "Projects1.doc", "Features.doc", "Client Issues1.doc", "Client Issues2.doc", "Clients.xls", "Presentation.ppt", "Slides.ppt", "Updates.doc", "Personal.doc", "Mail.doc"})
			Me.dwCurrent.Location = New System.Drawing.Point(3, 23)
			Me.dwCurrent.Name = "dwCurrent"
			Me.dwCurrent.Size = New System.Drawing.Size(131, 410)
			Me.dwCurrent.TabIndex = 9
			' 
			' dwDocumentBrowser
			' 
			Me.dwDocumentBrowser.BackColor = System.Drawing.Color.White
			Me.dwDocumentBrowser.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.dockingManager1.SetEnableDocking(Me.dwDocumentBrowser, True)
			Me.dwDocumentBrowser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.dwDocumentBrowser.ImageIndex = 0
			Me.dwDocumentBrowser.ImageList = Me.ilCommon
			Me.dwDocumentBrowser.Location = New System.Drawing.Point(3, 23)
			Me.dwDocumentBrowser.Name = "dwDocumentBrowser"
			treeNode25.ImageIndex = 22
			treeNode25.Name = ""
			treeNode25.SelectedImageIndex = 22
			treeNode25.Text = "Solution 1"
			treeNode26.ImageIndex = 22
			treeNode26.Name = ""
			treeNode26.SelectedImageIndex = 22
			treeNode26.Text = "Solution 2"
			treeNode27.ImageIndex = 22
			treeNode27.Name = ""
			treeNode27.SelectedImageIndex = 22
			treeNode27.Text = "Trial"
			treeNode28.ImageIndex = 24
			treeNode28.Name = ""
			treeNode28.SelectedImageIndex = 24
			treeNode28.Text = "Clerks"
			treeNode29.ImageIndex = 24
			treeNode29.Name = ""
			treeNode29.SelectedImageIndex = 24
			treeNode29.Text = "WorkIssue"
			treeNode30.ImageIndex = 25
			treeNode30.Name = ""
			treeNode30.SelectedImageIndex = 25
			treeNode30.Text = "QuickSolutions"
			treeNode31.Name = ""
			treeNode31.Text = "Clients"
			treeNode32.ImageIndex = 22
			treeNode32.Name = ""
			treeNode32.SelectedImageIndex = 22
			treeNode32.Text = "Office1"
			treeNode33.ImageIndex = 25
			treeNode33.Name = ""
			treeNode33.SelectedImageIndex = 25
			treeNode33.Text = "BG Group"
			treeNode34.ImageIndex = 8
			treeNode34.Name = ""
			treeNode34.SelectedImageIndex = 8
			treeNode34.Text = "Contacts"
			treeNode35.Name = ""
			treeNode35.Text = "Referrals"
			treeNode36.ImageIndex = 26
			treeNode36.Name = ""
			treeNode36.SelectedImageIndex = 26
			treeNode36.Text = "QuickSoft Solutions"
			treeNode37.ImageIndex = 22
			treeNode37.Name = ""
			treeNode37.SelectedImageIndex = 22
			treeNode37.Text = "ABCL Sales"
			treeNode38.ImageIndex = 24
			treeNode38.Name = ""
			treeNode38.SelectedImageIndex = 24
			treeNode38.Text = "BetaSoft"
			treeNode39.ImageIndex = 8
			treeNode39.Name = ""
			treeNode39.SelectedImageIndex = 8
			treeNode39.Text = "NC"
			treeNode40.ImageIndex = 9
			treeNode40.Name = ""
			treeNode40.SelectedImageIndex = 9
			treeNode40.Text = "SC"
			treeNode41.Name = ""
			treeNode41.Text = "GA"
			treeNode42.ImageIndex = 27
			treeNode42.Name = ""
			treeNode42.SelectedImageIndex = 27
			treeNode42.Text = "ZincLite Inc"
			treeNode43.ImageIndex = 22
			treeNode43.Name = ""
			treeNode43.SelectedImageIndex = 22
			treeNode43.Text = "Sales 1"
			treeNode44.ImageIndex = 22
			treeNode44.Name = ""
			treeNode44.SelectedImageIndex = 22
			treeNode44.Text = "Sales 2"
			treeNode45.ImageIndex = 10
			treeNode45.Name = ""
			treeNode45.SelectedImageIndex = 10
			treeNode45.Text = "Complaints"
			treeNode46.ImageIndex = 23
			treeNode46.Name = ""
			treeNode46.SelectedImageIndex = 23
			treeNode46.Text = "MicroCorp"
			Me.dwDocumentBrowser.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode30, treeNode33, treeNode36, treeNode37, treeNode38, treeNode42, treeNode46})
			Me.dwDocumentBrowser.SelectedImageIndex = 0
			Me.dwDocumentBrowser.Size = New System.Drawing.Size(183, 410)
			Me.dwDocumentBrowser.TabIndex = 11
			' 
			' mainFrameBarManager1
			' 
			Me.mainFrameBarManager1.BarPositionInfo = (CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream))
			Me.mainFrameBarManager1.Bars.Add(Me.bar1)
			Me.mainFrameBarManager1.Categories.Add("File")
			Me.mainFrameBarManager1.Categories.Add("Window")
			Me.mainFrameBarManager1.Categories.Add("Help")
			Me.mainFrameBarManager1.Categories.Add("Status Bar")
			Me.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form"
			Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.mainFrameBarManager1.Form = Me
			Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem1, Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.parentBarItem5, Me.barItem12, Me.barItem13, Me.barItem14, Me.parentBarItem2, Me.barItem15, Me.barItem20})
			Me.mainFrameBarManager1.ResetCustomization = False
			Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' bar1
			' 
			Me.bar1.BarName = "MainMenu"
			Me.bar1.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar1.Caption = "MainMenu"
			Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem1, Me.parentBarItem5, Me.parentBarItem2})
			Me.bar1.Manager = Me.mainFrameBarManager1
			' 
			' parentBarItem1
			' 
			Me.parentBarItem1.CategoryIndex = 0
			Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem1.ID = "&File"
			Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4})
			Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() { 3})
			Me.parentBarItem1.Text = "&File"
			' 
			' barItem1
			' 
			Me.barItem1.CategoryIndex = 0
			Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem1.ID = "New"
			Me.barItem1.ImageIndex = 40
			Me.barItem1.ImageList = Me.ilCommon
			Me.barItem1.Text = "New"
'			Me.barItem1.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem2
			' 
			Me.barItem2.CategoryIndex = 0
			Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem2.ID = "Open"
			Me.barItem2.ImageIndex = 38
			Me.barItem2.ImageList = Me.ilCommon
			Me.barItem2.Text = "Open"
'			Me.barItem2.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem3
			' 
			Me.barItem3.CategoryIndex = 0
			Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem3.ID = "Save"
			Me.barItem3.ImageIndex = 39
			Me.barItem3.ImageList = Me.ilCommon
			Me.barItem3.Text = "Save"
'			Me.barItem3.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem4
			' 
			Me.barItem4.CategoryIndex = 0
			Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem4.ID = "Exit"
			Me.barItem4.Text = "Exit"
'			Me.barItem4.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' parentBarItem5
			' 
			Me.parentBarItem5.CategoryIndex = 1
			Me.parentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem5.ID = "Window"
			Me.parentBarItem5.ImageIndex = 38
			Me.parentBarItem5.ImageList = Me.ilCommon
			Me.parentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem12, Me.barItem13, Me.barItem14})
			Me.parentBarItem5.MergeOrder = 2
			Me.parentBarItem5.Text = "Window"
			' 
			' barItem12
			' 
			Me.barItem12.CategoryIndex = 1
			Me.barItem12.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem12.ID = "Cascade"
			Me.barItem12.Text = "Cascade"
'			Me.barItem12.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem13
			' 
			Me.barItem13.CategoryIndex = 1
			Me.barItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem13.ID = "Tile Horizontally"
			Me.barItem13.Text = "Tile Horizontally"
'			Me.barItem13.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem14
			' 
			Me.barItem14.CategoryIndex = 1
			Me.barItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem14.ID = "Tile Vertically"
			Me.barItem14.Text = "Tile Vertically"
'			Me.barItem14.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' parentBarItem2
			' 
			Me.parentBarItem2.CategoryIndex = 2
			Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem2.ID = "Help"
			Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem15})
			Me.parentBarItem2.MergeOrder = 3
			Me.parentBarItem2.Text = "Help"
			' 
			' barItem15
			' 
			Me.barItem15.CategoryIndex = 2
			Me.barItem15.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem15.ID = "About Syncfusion"
			Me.barItem15.Text = "About Syncfusion"
			' 
			' barItem20
			' 
			Me.barItem20.CategoryIndex = 3
			Me.barItem20.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem20.ID = "Status1"
			Me.barItem20.Text = "Status1"
			' 
			' parentBarItem3
			' 
			Me.parentBarItem3.CategoryIndex = 1
			Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem3.ID = "FontFace"
			Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem5, Me.barItem6, Me.barItem7, Me.barItem8})
			Me.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.parentBarItem3.Text = "FontFace"
			' 
			' barItem5
			' 
			Me.barItem5.CategoryIndex = 1
			Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem5.ID = "1.Microsoft Sans Seriff"
			Me.barItem5.Text = "1. Microsoft Sans Seriff"
			' 
			' barItem6
			' 
			Me.barItem6.CategoryIndex = 1
			Me.barItem6.Checked = True
			Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem6.ID = "2. Calibri"
			Me.barItem6.Text = "2. Calibri"
			' 
			' barItem7
			' 
			Me.barItem7.CategoryIndex = 1
			Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem7.ID = "3. Courier New"
			Me.barItem7.Text = "3. Courier New"
			' 
			' barItem8
			' 
			Me.barItem8.CategoryIndex = 1
			Me.barItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem8.ID = "4. Times New Roman"
			Me.barItem8.Text = "4. Times New Roman"
			' 
			' parentBarItem4
			' 
			Me.parentBarItem4.CategoryIndex = 1
			Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem4.ID = "FontSize"
			Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem9})
			Me.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.parentBarItem4.Text = "FontSize"
			' 
			' barItem9
			' 
			Me.barItem9.CategoryIndex = 1
			Me.barItem9.Checked = True
			Me.barItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem9.ID = "Small"
			Me.barItem9.Text = "Small"
			' 
			' barItem10
			' 
			Me.barItem10.CategoryIndex = 1
			Me.barItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem10.ID = "Medium"
			Me.barItem10.Text = "Medium"
			' 
			' barItem11
			' 
			Me.barItem11.CategoryIndex = 1
			Me.barItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem11.ID = "Large"
			Me.barItem11.Text = "Large"
			' 
			' cbToolBar
			' 
			Me.cbToolBar.ChevronColor = System.Drawing.SystemColors.ControlText
			Me.cbToolBar.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top
			Me.cbToolBar.Font = New System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.cbToolBar.MaxLength = 200
			Me.cbToolBar.MinHeight = 26
			Me.cbToolBar.MinLength = 50
			Me.cbToolBar.Name = "cbToolBar"
			Me.cbToolBar.RowIndex = -1
			Me.cbToolBar.RowOffset = -1
			Me.cbToolBar.TabIndex = 0
			Me.cbToolBar.TabStop = False
			' 
			' toolStripEx1
			' 
			Me.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx1.Image = Nothing
			Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.tsbNew, Me.tsbOpen, Me.tsbSave, Me.toolStripSeparator2, Me.cmbFontFace, Me.cmbFontSize, Me.toolStripSeparator3, Me.chkOffice2007Mdi, Me.toolStripSeparator1, Me.clrSchemeDD})
			Me.toolStripEx1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
			Me.toolStripEx1.Location = New System.Drawing.Point(0, 25)
			Me.toolStripEx1.Name = "toolStripEx1"
			Me.toolStripEx1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue
			Me.toolStripEx1.ShowCaption = False
			Me.toolStripEx1.Size = New System.Drawing.Size(743, 25)
			Me.toolStripEx1.TabIndex = 10015
			' 
			' tsbNew
			' 
			Me.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tsbNew.Image = (CType(resources.GetObject("tsbNew.Image"), System.Drawing.Image))
			Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.tsbNew.Name = "tsbNew"
			Me.tsbNew.Size = New System.Drawing.Size(23, 22)
			Me.tsbNew.Text = "New"
'			Me.tsbNew.Click += New System.EventHandler(Me.tsbNew_Click);
			' 
			' tsbOpen
			' 
			Me.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tsbOpen.Image = (CType(resources.GetObject("tsbOpen.Image"), System.Drawing.Image))
			Me.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.tsbOpen.Name = "tsbOpen"
			Me.tsbOpen.Size = New System.Drawing.Size(23, 22)
			Me.tsbOpen.Text = "Open"
'			Me.tsbOpen.Click += New System.EventHandler(Me.tsbOpen_Click);
			' 
			' tsbSave
			' 
			Me.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.tsbSave.Image = (CType(resources.GetObject("tsbSave.Image"), System.Drawing.Image))
			Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.tsbSave.Name = "tsbSave"
			Me.tsbSave.Size = New System.Drawing.Size(23, 22)
			Me.tsbSave.Text = "Save"
'			Me.tsbSave.Click += New System.EventHandler(Me.tsbSave_Click);
			' 
			' cmbFontFace
			' 
			Me.cmbFontFace.Items.AddRange(New Object() { "Arial", "Times New Roman", "Courier New", "MS Sans Serif"})
			Me.cmbFontFace.Name = "cmbFontFace"
			Me.cmbFontFace.Size = New System.Drawing.Size(121, 25)
			Me.cmbFontFace.Text = "Font Family"
'			Me.cmbFontFace.SelectedIndexChanged += New System.EventHandler(Me.cmbFontFace_SelectedIndexChanged);
			' 
			' cmbFontSize
			' 
			Me.cmbFontSize.Items.AddRange(New Object() { "Small", "Medium", "Large"})
			Me.cmbFontSize.Name = "cmbFontSize"
			Me.cmbFontSize.Size = New System.Drawing.Size(121, 25)
			Me.cmbFontSize.Text = "Size"
'			Me.cmbFontSize.SelectedIndexChanged += New System.EventHandler(Me.cmbFontSize_SelectedIndexChanged);
			' 
			' chkOffice2007Mdi
			' 
			Me.chkOffice2007Mdi.Checked = True
			Me.chkOffice2007Mdi.CheckState = System.Windows.Forms.CheckState.Checked
			Me.chkOffice2007Mdi.Name = "chkOffice2007Mdi"
			Me.chkOffice2007Mdi.Size = New System.Drawing.Size(121, 22)
			Me.chkOffice2007Mdi.Text = "Office2007 MDI Child"
'			Me.chkOffice2007Mdi.CheckedChanged += New System.EventHandler(Me.chkOffice2007Mdi_CheckedChanged);
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
			' 
			' clrSchemeDD
			' 
			Me.clrSchemeDD.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.blueClrScheme, Me.silverClrScheme, Me.blackClrScheme, Me.CustomColorScheme})
			Me.clrSchemeDD.Image = (CType(resources.GetObject("clrSchemeDD.Image"), System.Drawing.Image))
			Me.clrSchemeDD.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.clrSchemeDD.Name = "clrSchemeDD"
			Me.clrSchemeDD.Size = New System.Drawing.Size(101, 22)
			Me.clrSchemeDD.Text = "Color Scheme"
			' 
			' blueClrScheme
			' 
			Me.blueClrScheme.Checked = True
			Me.blueClrScheme.CheckState = System.Windows.Forms.CheckState.Checked
			Me.blueClrScheme.Name = "blueClrScheme"
			Me.blueClrScheme.Size = New System.Drawing.Size(149, 22)
			Me.blueClrScheme.Tag = "Blue"
			Me.blueClrScheme.Text = "Blue"
'			Me.blueClrScheme.Click += New System.EventHandler(Me.clrSchemeDD_Click);
			' 
			' silverClrScheme
			' 
			Me.silverClrScheme.Name = "silverClrScheme"
			Me.silverClrScheme.Size = New System.Drawing.Size(149, 22)
			Me.silverClrScheme.Tag = "Silver"
			Me.silverClrScheme.Text = "Silver"
'			Me.silverClrScheme.Click += New System.EventHandler(Me.clrSchemeDD_Click);
			' 
			' blackClrScheme
			' 
			Me.blackClrScheme.Name = "blackClrScheme"
			Me.blackClrScheme.Size = New System.Drawing.Size(149, 22)
			Me.blackClrScheme.Tag = "Black"
			Me.blackClrScheme.Text = "Black"
'			Me.blackClrScheme.Click += New System.EventHandler(Me.clrSchemeDD_Click);
			' 
			' CustomColorScheme
			' 
			Me.CustomColorScheme.Name = "CustomColorScheme"
			Me.CustomColorScheme.Size = New System.Drawing.Size(149, 22)
			Me.CustomColorScheme.Tag = "Custom"
			Me.CustomColorScheme.Text = "Custom Color"
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
			' 
			' MainForm
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(743, 621)
			Me.Controls.Add(Me.toolStripEx1)
			Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.IsMdiContainer = True
			Me.MaximizeBox = False
			Me.Name = "MainForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "MDI Demo"
			CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dwNetwork.ResumeLayout(False)
			Me.pnlSlnToolBar.ResumeLayout(False)
			Me.pnlSlnToolBar.PerformLayout()
			CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolStripEx1.ResumeLayout(False)
			Me.toolStripEx1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

#End Region

		#Region "Helper methods"
		Private Sub CreateNewDocument()
			windowCount += 1
            Dim doc As Document = New Document("Document " & windowCount.ToString())
            doc.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.dockingManager1.LockDockPanelsUpdate()
            Me.dockingManager1.SetEnableDocking(doc, True)
            Me.dockingManager1.SetDockLabel(doc, "Document" & windowCount)
			Me.dockingManager1.SetAsMDIChild(doc, True)
            Me.dockingManager1.UnlockDockPanelsUpdate()

			If Me.cmbFontFace.Enabled = False Then
				Me.cmbFontFace.Enabled = True
			End If
			If Me.cmbFontSize.Enabled = False Then
				Me.cmbFontSize.Enabled = True
			End If
			If Me.barItem3.Enabled = False Then
				Me.barItem3.Enabled = True
			End If
		End Sub

		Private Sub OpenDocument()
			' Create an OpenFileDialog to request a file to open.
			Dim openFile1 As OpenFileDialog = New OpenFileDialog()

			' Initialize the OpenFileDialog to look for RTF files.
			openFile1.DefaultExt = "*.rtf"
			openFile1.Filter = "RTF Files|*.rtf"

			' Determine whether the user selected a file from the OpenFileDialog.
			If openFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso openFile1.FileName.Length > 0 Then
				' Create a new document and initialize it with the contents of the file.
				Me.CreateNewDocument()
				Dim activedoc As Document = TryCast(Me.ActiveMdiChild, Document)
				activedoc.DoLoadDocument(openFile1.FileName)
			End If
		End Sub

		Private Sub SaveDocument()
			Dim mdichild As Form = Me.ActiveMdiChild
			If (Not mdichild Is Nothing) AndAlso (TypeOf mdichild Is Document) Then
				' Create a SaveFileDialog to request a path and file name to save to.
				Dim saveFile1 As SaveFileDialog = New SaveFileDialog()

				' Initialize the SaveFileDialog to specify the RTF extension for the file.
				saveFile1.DefaultExt = "*.rtf"
				saveFile1.Filter = "RTF Files|*.rtf"

				' Determine if the user selected a file name from the saveFileDialog.
				If saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso saveFile1.FileName.Length > 0 Then
					' Save the contents of the RichTextBox into the file.
					Dim activedoc As Document = TryCast(mdichild, Document)
					activedoc.DoSaveDocument(saveFile1.FileName)
				End If
			End If
		End Sub

		#End Region

		#Region "BarItem Click Events"

		Private Sub OnBarItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem1.Click, barItem2.Click, barItem3.Click, barItem4.Click, barItem12.Click, barItem13.Click, barItem14.Click
			Dim item As BarItem = TryCast(sender, BarItem)
			Select Case item.ID
				Case "New"
					CreateNewDocument()
				Case "Open"
					OpenDocument()
				Case "Save"
					SaveDocument()
				Case "Exit"
					Application.Exit()
				Case "Cascade"
					Me.LayoutMdi(MdiLayout.Cascade)
				Case "Tile Horizontally"
					Me.LayoutMdi(MdiLayout.TileHorizontal)
				Case "Tile Vertically"
					Me.LayoutMdi(MdiLayout.TileVertical)
				Case "About Syncfusion"
                    Dim oTemp As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
                    oTemp.ShowDialog()

			End Select

		End Sub

		#End Region

		#Region "CommandBarEvents & Form Events"

		'One of the MDIChild windows has been activated.
		Protected Sub MDIChildActivated(ByVal sender As Object, ByVal e As System.EventArgs)

			If Me.ActiveMdiChild Is Nothing Then
				barItem20.Text = String.Empty
			Else
				barItem20.Text = Me.ActiveMdiChild.Text
			End If
		End Sub

		Public Sub MDIClient_ControlRemoved(ByVal sender As Object, ByVal e As ControlEventArgs)
			If Me.MdiChildren.Length = 0 Then
				Me.cmbFontFace.Text = "Font Family"
				Me.cmbFontSize.Text = "Size"
				Me.cmbFontFace.Enabled = False
				Me.cmbFontSize.Enabled = False
				Me.barItem3.Enabled = False
			End If
		End Sub

		Protected Overrides Sub OnMdiChildActivate(ByVal e As EventArgs)
			MyBase.OnMdiChildActivate(e)

			Dim mdichild As Form = Me.ActiveMdiChild
			If (Not mdichild Is Nothing) AndAlso (TypeOf mdichild Is Document) Then
				Dim doc As Document = TryCast(mdichild, Document)
				Me.cmbFontFace.Text = doc.CurrentFontFamily
				Me.cmbFontSize.Text = doc.CurrentFontSize
			End If
		End Sub

#End Region

		#Region "VERSIONING"
		Private Shared VersionTag As String = "AppVersion"
		Private Shared Sub ValidatePersistedStateVersion(ByVal curVersion As String)
			' Versioning
			Dim serializer As AppStateSerializer = AppStateSerializer.GetSingleton()
			Dim objectOut As Object = serializer.DeserializeObject(VersionTag)
			If Not objectOut Is Nothing Then
				Dim version As String = CStr(objectOut)
				version = version.ToLower()

				curVersion = curVersion.ToLower()

				' Persisted info is not the current version, let's lose it.
				If version <> curVersion Then
					serializer.FlushSerializer()
				End If
			End If
		End Sub
		' Store the current version, so that we can validate it the next time.
		Private Shared Sub StoreVersionInfo(ByVal curVersion As String)
			Dim serializer As AppStateSerializer = AppStateSerializer.GetSingleton()
			serializer.SerializeObject(VersionTag, curVersion, True)
		End Sub
		#End Region ' VERSIONING

		#Region "ToolStripMenuEvents"
		Private Sub CustomColorsDropDownImpl()
			Dim colorPicker As ColorPickerUIAdv = New ColorPickerUIAdv()
			AddHandler colorPicker.Picked, AddressOf colorPicker_Picked
			colorPicker.MoreColorsButton.Visible = False
			colorPicker.StateButton.Visible = False

			Dim host As ToolStripControlHost = New ToolStripControlHost(colorPicker)
			host.Size = New Size(150, 100)
			colorPicker.Dock = DockStyle.Fill
			Dim dd As ToolStripDropDown = New ToolStripDropDown()
			dd.Items.Add(host)
			'dd.Renderer = new BorderlessRenderer();
			CustomColorScheme.DropDown = dd
		End Sub

		' Applying Custom color 
		Private Sub colorPicker_Picked(ByVal sender As Object, ByVal args As ColorPickerUIAdv.ColorPickedEventArgs)
			dockingManager1.Office2007MdiColorScheme = Office2007Theme.Managed
            dockingManager1.Office2007Theme = Office2007Theme.Managed
            mainFrameBarManager1.Office2007Theme = Office2007Theme.Managed
            toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Managed
			For Each f As Form In Me.MdiChildren
				If Not f Is Nothing AndAlso TypeOf f Is Document Then
					Dim docForm As Document = TryCast(f, Document)
					docForm.ColorScheme = Office2007Theme.Managed
				End If

			Next f

			Office2007Colors.ApplyManagedColors(Me, args.Color)
			clrSchemeDD.DropDown.Close()
			ColorSchemeMenuCheck()
			CustomColorScheme.Checked = True
		End Sub

		Private Sub chkOffice2007Mdi_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkOffice2007Mdi.CheckedChanged
			Me.dockingManager1.Office2007MdiChildForm = Me.chkOffice2007Mdi.Checked
		End Sub

		Private Sub cmbFontFace_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbFontFace.SelectedIndexChanged
			Me.cmbFontFace.Text = Me.cmbFontFace.SelectedItem.ToString()
			Dim mdichild As Form = Me.ActiveMdiChild
			If (Not mdichild Is Nothing) AndAlso (TypeOf mdichild Is Document) Then
				Dim doc As Document = TryCast(mdichild, Document)
				doc.CurrentFontFamily = Me.cmbFontFace.Text
			End If
		End Sub

		Private Sub cmbFontSize_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbFontSize.SelectedIndexChanged
			Me.cmbFontSize.Text = Me.cmbFontSize.SelectedItem.ToString()
			Dim mdichild As Form = Me.ActiveMdiChild
			If (Not mdichild Is Nothing) AndAlso (TypeOf mdichild Is Document) Then
				Dim doc As Document = TryCast(mdichild, Document)
				doc.CurrentFontSize = Me.cmbFontSize.Text
			End If
		End Sub

		Private Sub tsbNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbNew.Click
			CreateNewDocument()
		End Sub

		Private Sub tsbOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbOpen.Click
			OpenDocument()
		End Sub

		Private Sub tsbSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tsbSave.Click
			SaveDocument()
		End Sub

		Private Sub clrSchemeDD_Click(ByVal sender As Object, ByVal e As EventArgs) Handles blueClrScheme.Click, silverClrScheme.Click, blackClrScheme.Click
			Dim menuItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

			Select Case TryCast(menuItem.Tag, String)
				Case "Blue"
					ColorSchemeMenuCheck()
					blueClrScheme.Checked = True
					' Change the MDI Child form colorscheme here.
                    Me.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Blue
                    dockingManager1.Office2007Theme = Office2007Theme.Blue
                    mainFrameBarManager1.Office2007Theme = Office2007Theme.Blue
                    toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue
					' Change parent form color scheme here.
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Blue)
				Case "Silver"
					ColorSchemeMenuCheck()
					silverClrScheme.Checked = True
                    Me.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Silver
                    dockingManager1.Office2007Theme = Office2007Theme.Silver
                    mainFrameBarManager1.Office2007Theme = Office2007Theme.Silver
                    toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Silver)
				Case "Black"
					ColorSchemeMenuCheck()
					blackClrScheme.Checked = True
                    Me.dockingManager1.Office2007MdiColorScheme = Office2007Theme.Black
                    dockingManager1.Office2007Theme = Office2007Theme.Black
                    mainFrameBarManager1.Office2007Theme = Office2007Theme.Black
                    toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black
					Office2007Colors.ApplyManagedScheme(Me, Office2007Theme.Black)
			End Select

			For Each f As Form In Me.MdiChildren
				If Not f Is Nothing AndAlso TypeOf f Is Document Then
					Dim docForm As Document = TryCast(f, Document)
					docForm.ColorScheme = CType(System.Enum.Parse(GetType(Office2007Theme), menuItem.Tag.ToString()), Office2007Theme)
				End If

			Next f
		End Sub

		Private Sub ColorSchemeMenuCheck()
			blueClrScheme.Checked = False
			silverClrScheme.Checked = False
			blackClrScheme.Checked = False
			CustomColorScheme.Checked = False
		End Sub
#End Region

        Private Sub MainForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            Me.dockingManager1.UnlockDockPanelsUpdate()
        End Sub

        Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            Me.dockingManager1.LockDockPanelsUpdate()
        End Sub
    End Class
End Namespace
