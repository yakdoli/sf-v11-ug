Imports Microsoft.VisualBasic
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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Drawing

Namespace LocalizationDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private comboBoxBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private WithEvents parentBarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private toolbarListBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem
		Private parentBarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private listBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
		Private WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private dropDownBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
		Private barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private comboBoxBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private parentBarItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem17 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private fontColorBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
		Private parentBarItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem19 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem20 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private listView1 As System.Windows.Forms.ListView
		Private WithEvents controlBar1 As Syncfusion.Windows.Forms.Tools.ControlBar
		Private taskPanel As System.Windows.Forms.Panel
		Private controlBar2 As Syncfusion.Windows.Forms.Tools.ControlBar
		Private xpTaskPaneToolbar As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private WithEvents biTaskPrevious As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents biTaskNext As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents biTaskHome As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private cardLayout1 As Syncfusion.Windows.Forms.Tools.CardLayout
		Private popupMenu1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private WithEvents parentBarItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private pnlGettingStarted As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private xpToolBar2 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private label20 As System.Windows.Forms.Label
		Private linkLabel11 As System.Windows.Forms.LinkLabel
		Private label21 As System.Windows.Forms.Label
		Private label22 As System.Windows.Forms.Label
		Private label23 As System.Windows.Forms.Label
		Private linkLabel12 As System.Windows.Forms.LinkLabel
		Private linkLabel13 As System.Windows.Forms.LinkLabel
		Private linkLabel14 As System.Windows.Forms.LinkLabel
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label24 As System.Windows.Forms.Label
		Private linkLabel15 As System.Windows.Forms.LinkLabel
		Private label25 As System.Windows.Forms.Label
		Private linkLabel16 As System.Windows.Forms.LinkLabel
		Private pnlSearchOptions As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private xpTaskBar1 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private xpTaskBarBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private xpTaskBarBox2 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private label26 As System.Windows.Forms.Label
		Private textBox2 As System.Windows.Forms.TextBox
		Private label27 As System.Windows.Forms.Label
		Private pnlNewDocument As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label28 As System.Windows.Forms.Label
		Private label29 As System.Windows.Forms.Label
		Private label30 As System.Windows.Forms.Label
		Private label31 As System.Windows.Forms.Label
		Private label32 As System.Windows.Forms.Label
		Private linkLabel17 As System.Windows.Forms.LinkLabel
		Private linkLabel18 As System.Windows.Forms.LinkLabel
		Private linkLabel19 As System.Windows.Forms.LinkLabel
		Private label33 As System.Windows.Forms.Label
		Private label34 As System.Windows.Forms.Label
		Private textBox4 As System.Windows.Forms.TextBox
		Private label35 As System.Windows.Forms.Label
		Private label36 As System.Windows.Forms.Label
		Private label37 As System.Windows.Forms.Label
		Private label38 As System.Windows.Forms.Label
		Private linkLabel20 As System.Windows.Forms.LinkLabel
		Private components As System.ComponentModel.IContainer

		Private nReportCount As Integer = 0
		Private nLetterCount As Integer = 0
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents biGettingStarted As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents biNewDocument As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents biSearchOptions As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem18 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem21 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private LargeimageList As System.Windows.Forms.ImageList
		Private comboBoxAdv3 As ComboBoxAdv
		Private WithEvents buttonAdv1 As ButtonAdv
		Private comboBoxAdv2 As ComboBoxAdv
		Private buttonAdv2 As ButtonAdv
		Private label1 As Label
		Private nInvoiceCount As Integer = 0

		Public Sub New()
			LocalizationProvider.Provider = New Localizer()


			InitializeComponent()


			Dim txtform As LocalizationDemo.TextForm = New TextForm()
			txtform.TopLevel = False
			txtform.MdiParent = Me
			txtform.Show()
			nReportCount += 1
			txtform.Text = String.Concat("Bericht ", (nReportCount).ToString())
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim listViewItem1 As New System.Windows.Forms.ListViewItem(New String() { "Project Management"}, 13, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F))
			Dim listViewItem2 As New System.Windows.Forms.ListViewItem(New String() { "Sections"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F))
			Dim listViewItem3 As New System.Windows.Forms.ListViewItem(New String() { "Introduction"}, 14, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F))
			Dim listViewItem4 As New System.Windows.Forms.ListViewItem(New String() { "Planning"}, 15, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F))
			Dim listViewItem5 As New System.Windows.Forms.ListViewItem(New String() { "Departments"}, 18, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F))
			Dim listViewItem6 As New System.Windows.Forms.ListViewItem(New String() { "Review 1"}, 13, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F))
			Dim listViewItem7 As New System.Windows.Forms.ListViewItem(New String() { "Review 2"}, 13, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F))
			Dim listViewItem8 As New System.Windows.Forms.ListViewItem(New String() { "Records"}, 2, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F))
			Dim listViewItem9 As New System.Windows.Forms.ListViewItem(New String() { "Inventory"}, 22, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75F))
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
			Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "MainMenu")
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.parentBarItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.listBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem()
			Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.toolbarListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem()
			Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "File")
			Me.controlBar1 = New Syncfusion.Windows.Forms.Tools.ControlBar()
			Me.xpTaskPaneToolbar = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.biTaskPrevious = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.biTaskNext = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.biTaskHome = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.taskPanel = New System.Windows.Forms.Panel()
			Me.pnlGettingStarted = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.label24 = New System.Windows.Forms.Label()
			Me.linkLabel15 = New System.Windows.Forms.LinkLabel()
			Me.label25 = New System.Windows.Forms.Label()
			Me.linkLabel16 = New System.Windows.Forms.LinkLabel()
			Me.label20 = New System.Windows.Forms.Label()
			Me.linkLabel11 = New System.Windows.Forms.LinkLabel()
			Me.label21 = New System.Windows.Forms.Label()
			Me.comboBoxAdv3 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.label22 = New System.Windows.Forms.Label()
			Me.label23 = New System.Windows.Forms.Label()
			Me.linkLabel12 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel13 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel14 = New System.Windows.Forms.LinkLabel()
			Me.xpToolBar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar()
			Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.pnlNewDocument = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label36 = New System.Windows.Forms.Label()
			Me.label37 = New System.Windows.Forms.Label()
			Me.label38 = New System.Windows.Forms.Label()
			Me.linkLabel20 = New System.Windows.Forms.LinkLabel()
			Me.label33 = New System.Windows.Forms.Label()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.label34 = New System.Windows.Forms.Label()
			Me.textBox4 = New System.Windows.Forms.TextBox()
			Me.label35 = New System.Windows.Forms.Label()
			Me.label28 = New System.Windows.Forms.Label()
			Me.label29 = New System.Windows.Forms.Label()
			Me.label30 = New System.Windows.Forms.Label()
			Me.label31 = New System.Windows.Forms.Label()
			Me.label32 = New System.Windows.Forms.Label()
			Me.linkLabel17 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel18 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel19 = New System.Windows.Forms.LinkLabel()
			Me.pnlSearchOptions = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.xpTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.label26 = New System.Windows.Forms.Label()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.label27 = New System.Windows.Forms.Label()
			Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.LargeimageList = New System.Windows.Forms.ImageList(Me.components)
			Me.popupMenu1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.parentBarItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.biGettingStarted = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.biNewDocument = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.biSearchOptions = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.controlBar2 = New Syncfusion.Windows.Forms.Tools.ControlBar()
			Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.listView1 = New System.Windows.Forms.ListView()
			Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.comboBoxBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.fontColorBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem()
			Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.dropDownBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem()
			Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.parentBarItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.comboBoxBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.cardLayout1 = New Syncfusion.Windows.Forms.Tools.CardLayout(Me.components)
			CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.controlBar1.SuspendLayout()
			Me.taskPanel.SuspendLayout()
			CType(Me.pnlGettingStarted, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlGettingStarted.SuspendLayout()
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel2.SuspendLayout()
			CType(Me.comboBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pnlNewDocument, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlNewDocument.SuspendLayout()
			CType(Me.pnlSearchOptions, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pnlSearchOptions.SuspendLayout()
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar1.SuspendLayout()
			Me.xpTaskBarBox2.SuspendLayout()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.controlBar2.SuspendLayout()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxBarItem3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' mainFrameBarManager1
			' 
			Me.mainFrameBarManager1.AutoLoadToolBarPositions = False
			Me.mainFrameBarManager1.AutoPersistCustomization = False
			Me.mainFrameBarManager1.BarPositionInfo = (CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream))
			Me.mainFrameBarManager1.Bars.Add(Me.bar1)
			Me.mainFrameBarManager1.Bars.Add(Me.bar2)
			Me.mainFrameBarManager1.Categories.Add("Datei")
			Me.mainFrameBarManager1.Categories.Add("Format")
			Me.mainFrameBarManager1.Categories.Add("Anzeigen")
			Me.mainFrameBarManager1.Categories.Add("Popups")
			Me.mainFrameBarManager1.Categories.Add("Hilfe")
			Me.mainFrameBarManager1.Categories.Add("Misc")
			Me.mainFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
			Me.mainFrameBarManager1.DetachedCommandBars.Add(Me.controlBar1)
			Me.mainFrameBarManager1.DetachedCommandBars.Add(Me.controlBar2)
			Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.mainFrameBarManager1.Form = Me
			Me.mainFrameBarManager1.ImageList = Me.imageList1
			Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem10, Me.parentBarItem1, Me.barItem2, Me.barItem3, Me.parentBarItem6, Me.listBarItem1, Me.barItem7, Me.parentBarItem3, Me.comboBoxBarItem1, Me.comboBoxBarItem2, Me.fontColorBarItem, Me.parentBarItem5, Me.toolbarListBarItem1, Me.barItem1, Me.barItem16, Me.barItem17, Me.parentBarItem11, Me.barItem19, Me.barItem4, Me.barItem5})
			Me.mainFrameBarManager1.ResetCustomization = False
			Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' bar1
			' 
			Me.bar1.BarName = "MainMenu"
			Me.bar1.BarStyle = (CType(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar1.Caption = "MainMenu"
			Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem1, Me.parentBarItem5, Me.parentBarItem11})
			Me.bar1.Manager = Me.mainFrameBarManager1
			' 
			' parentBarItem1
			' 
			Me.parentBarItem1.CategoryIndex = 3
			Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem1.ID = "&File"
			Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem10, Me.barItem2, Me.barItem3, Me.parentBarItem6, Me.barItem7})
			Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() { 3, 4})
			Me.parentBarItem1.Text = "&Datei"
			' 
			' parentBarItem10
			' 
			Me.parentBarItem10.CategoryIndex = 0
			Me.parentBarItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem10.ID = "&New"
			Me.parentBarItem10.ImageIndex = 0
			Me.parentBarItem10.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem16, Me.barItem17})
			Me.parentBarItem10.ParentStyle = Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItemStyle.DropDown
			Me.parentBarItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlN
			Me.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.parentBarItem10.Text = "&Neue"
			' 
			' barItem1
			' 
			Me.barItem1.CategoryIndex = 0
			Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem1.ID = "New1"
			Me.barItem1.ImageIndex = 14
			Me.barItem1.Text = "Schreiben"
			' 
			' barItem16
			' 
			Me.barItem16.CategoryIndex = 0
			Me.barItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem16.ID = "New2"
			Me.barItem16.ImageIndex = 15
			Me.barItem16.Text = "Bericht"
			' 
			' barItem17
			' 
			Me.barItem17.CategoryIndex = 0
			Me.barItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem17.ID = "New3"
			Me.barItem17.ImageIndex = 13
			Me.barItem17.Text = "Rechnung"
			' 
			' barItem2
			' 
			Me.barItem2.CategoryIndex = 0
			Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem2.ID = "&Open"
			Me.barItem2.ImageIndex = 1
			Me.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO
			Me.barItem2.Text = "&Open"
			' 
			' barItem3
			' 
			Me.barItem3.CategoryIndex = 0
			Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem3.ID = "&Save"
			Me.barItem3.ImageIndex = 2
			Me.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS
			Me.barItem3.Text = "&Speichern"
			' 
			' parentBarItem6
			' 
			Me.parentBarItem6.CategoryIndex = 0
			Me.parentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem6.ID = "Recent Views (Expanding List)"
			Me.parentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.listBarItem1})
			Me.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.parentBarItem6.Text = "Aktuelle Hits (erweiterte Liste)"
			' 
			' listBarItem1
			' 
			Me.listBarItem1.CategoryIndex = 0
			Me.listBarItem1.ChildCaptions.AddRange(New String() { "View 1", "View 2", "View 3"})
			Me.listBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listBarItem1.ID = "MRU List"
			Me.listBarItem1.Text = "MRU-Liste"
			' 
			' barItem7
			' 
			Me.barItem7.CategoryIndex = 0
			Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem7.ID = "&Exit"
			Me.barItem7.Text = "&Exit"
			' 
			' parentBarItem5
			' 
			Me.parentBarItem5.CategoryIndex = 3
			Me.parentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem5.ID = "&View"
			Me.parentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.toolbarListBarItem1, Me.barItem4, Me.barItem5})
			Me.parentBarItem5.MergeOrder = 2
			Me.parentBarItem5.Text = "&Anzeigen"
			' 
			' toolbarListBarItem1
			' 
			Me.toolbarListBarItem1.CategoryIndex = 2
			Me.toolbarListBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolbarListBarItem1.ID = "Toolbar List"
			Me.toolbarListBarItem1.Text = "Toolbar Liste"
			' 
			' barItem4
			' 
			Me.barItem4.CategoryIndex = 2
			Me.barItem4.Checked = True
			Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem4.ID = "Task Pane"
			Me.barItem4.Text = "&Aufgabenbereich"
			' 
			' barItem5
			' 
			Me.barItem5.CategoryIndex = 2
			Me.barItem5.Checked = True
			Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem5.ID = "Properties Pane"
			Me.barItem5.Text = "&Eigenschaftsleiste"
			' 
			' parentBarItem11
			' 
			Me.parentBarItem11.CategoryIndex = 3
			Me.parentBarItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem11.ID = "&Help"
			Me.parentBarItem11.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem19})
			Me.parentBarItem11.MergeOrder = 5
			Me.parentBarItem11.Text = "&Hilfe"
			' 
			' barItem19
			' 
			Me.barItem19.CategoryIndex = 4
			Me.barItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem19.ID = "About Syncfusion"
			Me.barItem19.ImageIndex = 41
			Me.barItem19.Text = "Über Syncfusion"
			' 
			' bar2
			' 
			Me.bar2.BarName = "File"
			Me.bar2.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.bar2.Caption = "Datei"
			Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem10, Me.barItem2, Me.barItem3})
			Me.bar2.Manager = Me.mainFrameBarManager1
			' 
			' controlBar1
			' 
			Me.controlBar1.AllowedDockBorders = (CType((Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Left Or Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Right), Syncfusion.Windows.Forms.Tools.CommandBarDockBorder))
			Me.controlBar1.CaptionControl = Me.xpTaskPaneToolbar
			Me.controlBar1.ChevronColor = System.Drawing.SystemColors.ControlText
			Me.controlBar1.ControlBarCaptionHeight = 31
			Me.controlBar1.Controls.Add(Me.taskPanel)
			Me.controlBar1.Controls.Add(Me.xpTaskPaneToolbar)
			Me.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left
			Me.controlBar1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.controlBar1.MaxLength = 200
			Me.controlBar1.MinHeight = 224
			Me.controlBar1.MinLength = 50
			Me.controlBar1.Name = "controlBar1"
			Me.controlBar1.PopupMenu = Me.popupMenu1
			Me.controlBar1.RowIndex = 0
			Me.controlBar1.TabIndex = 0
			Me.controlBar1.TabStop = False
			Me.controlBar1.Text = "Erste Schritte"
			' 
			' xpTaskPaneToolbar
			' 
			Me.xpTaskPaneToolbar.BackColor = System.Drawing.Color.Transparent
			' 
			' 
			' 
			Me.xpTaskPaneToolbar.Bar.BarName = ""
			Me.xpTaskPaneToolbar.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.biTaskPrevious, Me.biTaskNext, Me.biTaskHome})
			Me.xpTaskPaneToolbar.Bar.Manager = Nothing
			Me.xpTaskPaneToolbar.Location = New System.Drawing.Point(2, 33)
			Me.xpTaskPaneToolbar.Name = "xpTaskPaneToolbar"
			Me.xpTaskPaneToolbar.Size = New System.Drawing.Size(218, 25)
			Me.xpTaskPaneToolbar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.xpTaskPaneToolbar.TabIndex = 29
			Me.xpTaskPaneToolbar.Text = "xpToolBar2"
			' 
			' biTaskPrevious
			' 
			Me.biTaskPrevious.CustomTextFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.biTaskPrevious.ImageIndex = 37
			Me.biTaskPrevious.ImageList = Me.imageList1
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
			Me.imageList1.Images.SetKeyName(5, "")
			Me.imageList1.Images.SetKeyName(6, "")
			Me.imageList1.Images.SetKeyName(7, "")
			Me.imageList1.Images.SetKeyName(8, "")
			Me.imageList1.Images.SetKeyName(9, "")
			Me.imageList1.Images.SetKeyName(10, "")
			Me.imageList1.Images.SetKeyName(11, "")
			Me.imageList1.Images.SetKeyName(12, "")
			Me.imageList1.Images.SetKeyName(13, "")
			Me.imageList1.Images.SetKeyName(14, "")
			Me.imageList1.Images.SetKeyName(15, "")
			Me.imageList1.Images.SetKeyName(16, "")
			Me.imageList1.Images.SetKeyName(17, "")
			Me.imageList1.Images.SetKeyName(18, "")
			Me.imageList1.Images.SetKeyName(19, "")
			Me.imageList1.Images.SetKeyName(20, "")
			Me.imageList1.Images.SetKeyName(21, "")
			Me.imageList1.Images.SetKeyName(22, "")
			Me.imageList1.Images.SetKeyName(23, "")
			Me.imageList1.Images.SetKeyName(24, "")
			Me.imageList1.Images.SetKeyName(25, "")
			Me.imageList1.Images.SetKeyName(26, "")
			Me.imageList1.Images.SetKeyName(27, "")
			Me.imageList1.Images.SetKeyName(28, "")
			Me.imageList1.Images.SetKeyName(29, "")
			Me.imageList1.Images.SetKeyName(30, "")
			Me.imageList1.Images.SetKeyName(31, "")
			Me.imageList1.Images.SetKeyName(32, "")
			Me.imageList1.Images.SetKeyName(33, "")
			Me.imageList1.Images.SetKeyName(34, "")
			Me.imageList1.Images.SetKeyName(35, "")
			Me.imageList1.Images.SetKeyName(36, "")
			Me.imageList1.Images.SetKeyName(37, "")
			Me.imageList1.Images.SetKeyName(38, "")
			Me.imageList1.Images.SetKeyName(39, "")
			Me.imageList1.Images.SetKeyName(40, "")
			Me.imageList1.Images.SetKeyName(41, "")
			' 
			' biTaskNext
			' 
			Me.biTaskNext.CustomTextFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.biTaskNext.ImageIndex = 38
			Me.biTaskNext.ImageList = Me.imageList1
			' 
			' biTaskHome
			' 
			Me.biTaskHome.CustomTextFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.biTaskHome.ImageIndex = 39
			Me.biTaskHome.ImageList = Me.imageList1
			' 
			' taskPanel
			' 
			Me.taskPanel.Controls.Add(Me.pnlGettingStarted)
			Me.taskPanel.Controls.Add(Me.pnlNewDocument)
			Me.taskPanel.Controls.Add(Me.pnlSearchOptions)
			Me.taskPanel.Location = New System.Drawing.Point(2, 58)
			Me.taskPanel.Name = "taskPanel"
			Me.taskPanel.Size = New System.Drawing.Size(220, 528)
			Me.taskPanel.TabIndex = 29
			' 
			' pnlGettingStarted
			' 
			Me.pnlGettingStarted.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.cardLayout1.SetCardName(Me.pnlGettingStarted, "GettingStarted")
			Me.pnlGettingStarted.Controls.Add(Me.gradientPanel2)
			Me.pnlGettingStarted.Controls.Add(Me.label20)
			Me.pnlGettingStarted.Controls.Add(Me.linkLabel11)
			Me.pnlGettingStarted.Controls.Add(Me.label21)
			Me.pnlGettingStarted.Controls.Add(Me.comboBoxAdv3)
			Me.pnlGettingStarted.Controls.Add(Me.label22)
			Me.pnlGettingStarted.Controls.Add(Me.label23)
			Me.pnlGettingStarted.Controls.Add(Me.linkLabel12)
			Me.pnlGettingStarted.Controls.Add(Me.linkLabel13)
			Me.pnlGettingStarted.Controls.Add(Me.linkLabel14)
			Me.pnlGettingStarted.Controls.Add(Me.xpToolBar2)
			Me.pnlGettingStarted.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.pnlGettingStarted.Location = New System.Drawing.Point(0, 0)
			Me.cardLayout1.SetMinimumSize(Me.pnlGettingStarted, New System.Drawing.Size(176, 232))
			Me.pnlGettingStarted.Name = "pnlGettingStarted"
			Me.cardLayout1.SetPreferredSize(Me.pnlGettingStarted, New System.Drawing.Size(176, 232))
			Me.pnlGettingStarted.Size = New System.Drawing.Size(220, 528)
			Me.pnlGettingStarted.TabIndex = 29
			Me.pnlGettingStarted.Tag = "Erste Schritte"
			' 
			' gradientPanel2
			' 
			Me.gradientPanel2.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gradientPanel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(215))))), (CInt(Fix((CByte(221))))), (CInt(Fix((CByte(237))))))
			Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(158))))), (CInt(Fix((CByte(171))))), (CInt(Fix((CByte(206))))))
			Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel2.Controls.Add(Me.label24)
			Me.gradientPanel2.Controls.Add(Me.linkLabel15)
			Me.gradientPanel2.Controls.Add(Me.label25)
			Me.gradientPanel2.Controls.Add(Me.linkLabel16)
			Me.gradientPanel2.Location = New System.Drawing.Point(11, 287)
			Me.gradientPanel2.Name = "gradientPanel2"
			Me.gradientPanel2.Size = New System.Drawing.Size(195, 73)
			Me.gradientPanel2.TabIndex = 49
			' 
			' label24
			' 
			Me.label24.Image = (CType(resources.GetObject("label24.Image"), System.Drawing.Image))
			Me.label24.Location = New System.Drawing.Point(6, 47)
			Me.label24.Name = "label24"
			Me.label24.Size = New System.Drawing.Size(16, 16)
			Me.label24.TabIndex = 40
			' 
			' linkLabel15
			' 
			Me.linkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel15.Location = New System.Drawing.Point(40, 47)
			Me.linkLabel15.Name = "linkLabel15"
			Me.linkLabel15.Size = New System.Drawing.Size(168, 24)
			Me.linkLabel15.TabIndex = 39
			Me.linkLabel15.TabStop = True
			Me.linkLabel15.Text = "Erstellen eines neuen Dokuments..."
			' 
			' label25
			' 
			Me.label25.ImageIndex = 1
			Me.label25.ImageList = Me.imageList1
			Me.label25.Location = New System.Drawing.Point(6, 7)
			Me.label25.Name = "label25"
			Me.label25.Size = New System.Drawing.Size(16, 16)
			Me.label25.TabIndex = 38
			' 
			' linkLabel16
			' 
			Me.linkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel16.Location = New System.Drawing.Point(40, 7)
			Me.linkLabel16.Name = "linkLabel16"
			Me.linkLabel16.Size = New System.Drawing.Size(168, 24)
			Me.linkLabel16.TabIndex = 37
			Me.linkLabel16.TabStop = True
			Me.linkLabel16.Text = "Open..."
			' 
			' label20
			' 
			Me.label20.ImageIndex = 40
			Me.label20.ImageList = Me.imageList1
			Me.label20.Location = New System.Drawing.Point(8, 119)
			Me.label20.Name = "label20"
			Me.label20.Size = New System.Drawing.Size(16, 8)
			Me.label20.TabIndex = 47
			' 
			' linkLabel11
			' 
			Me.linkLabel11.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel11.Location = New System.Drawing.Point(32, 115)
			Me.linkLabel11.Name = "linkLabel11"
			Me.linkLabel11.Size = New System.Drawing.Size(40, 16)
			Me.linkLabel11.TabIndex = 46
			Me.linkLabel11.TabStop = True
			Me.linkLabel11.Text = "Mehr..."
			' 
			' label21
			' 
			Me.label21.ImageIndex = 40
			Me.label21.ImageList = Me.imageList1
			Me.label21.Location = New System.Drawing.Point(8, 96)
			Me.label21.Name = "label21"
			Me.label21.Size = New System.Drawing.Size(16, 8)
			Me.label21.TabIndex = 45
			' 
			' comboBoxAdv3
			' 
			Me.comboBoxAdv3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
			Me.comboBoxAdv3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBoxAdv3.Items.AddRange(New Object() { "Benutzerdefinierte Dokument Format 1", "Benutzerdefinierte Dokument Format 2", "Letter Format", "Record Format", "Editorial Format", "Application Format"})
			Me.comboBoxAdv3.Location = New System.Drawing.Point(8, 225)
			Me.comboBoxAdv3.Name = "comboBoxAdv3"
			Me.comboBoxAdv3.Size = New System.Drawing.Size(198, 21)
			Me.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.comboBoxAdv3.TabIndex = 24
			Me.comboBoxAdv3.Text = "Benutzerdefinierte Dokument Format 1"
			' 
			' label22
			' 
			Me.label22.ImageIndex = 40
			Me.label22.ImageList = Me.imageList1
			Me.label22.Location = New System.Drawing.Point(8, 72)
			Me.label22.Name = "label22"
			Me.label22.Size = New System.Drawing.Size(16, 8)
			Me.label22.TabIndex = 44
			' 
			' label23
			' 
			Me.label23.ImageIndex = 40
			Me.label23.ImageList = Me.imageList1
			Me.label23.Location = New System.Drawing.Point(8, 48)
			Me.label23.Name = "label23"
			Me.label23.Size = New System.Drawing.Size(16, 16)
			Me.label23.TabIndex = 43
			' 
			' linkLabel12
			' 
			Me.linkLabel12.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel12.Location = New System.Drawing.Point(32, 94)
			Me.linkLabel12.Name = "linkLabel12"
			Me.linkLabel12.Size = New System.Drawing.Size(192, 16)
			Me.linkLabel12.TabIndex = 42
			Me.linkLabel12.TabStop = True
			Me.linkLabel12.Text = "Sparen Sie aktuelle Dokument Format"
			' 
			' linkLabel13
			' 
			Me.linkLabel13.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel13.Location = New System.Drawing.Point(32, 72)
			Me.linkLabel13.Name = "linkLabel13"
			Me.linkLabel13.Size = New System.Drawing.Size(192, 16)
			Me.linkLabel13.TabIndex = 41
			Me.linkLabel13.TabStop = True
			Me.linkLabel13.Text = "Ändern Sie aktuelle Format"
			' 
			' linkLabel14
			' 
			Me.linkLabel14.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel14.Location = New System.Drawing.Point(32, 48)
			Me.linkLabel14.Name = "linkLabel14"
			Me.linkLabel14.Size = New System.Drawing.Size(192, 16)
			Me.linkLabel14.TabIndex = 40
			Me.linkLabel14.TabStop = True
			Me.linkLabel14.Text = "Erstellen von benutzerdefinierten Dokument-Format"
			' 
			' xpToolBar2
			' 
			Me.xpToolBar2.BackColor = System.Drawing.Color.Transparent
			' 
			' 
			' 
			Me.xpToolBar2.Bar.BarName = ""
			Me.xpToolBar2.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem11, Me.parentBarItem7, Me.barItem12, Me.barItem13})
			Me.xpToolBar2.Bar.Manager = Nothing
			Me.xpToolBar2.Bar.SeparatorIndices.AddRange(New Integer() { 2})
			Me.xpToolBar2.Dock = System.Windows.Forms.DockStyle.Top
			Me.xpToolBar2.Location = New System.Drawing.Point(0, 0)
			Me.xpToolBar2.Name = "xpToolBar2"
			Me.xpToolBar2.SeparatorIndices.AddRange(New Integer() { 2})
			Me.xpToolBar2.Size = New System.Drawing.Size(216, 25)
			Me.xpToolBar2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.xpToolBar2.TabIndex = 2
			Me.xpToolBar2.Text = "xpToolBar2"
			' 
			' barItem11
			' 
			Me.barItem11.CustomTextFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.barItem11.ID = "Item1"
			Me.barItem11.ImageIndex = 16
			Me.barItem11.ImageList = Me.imageList1
			Me.barItem11.Text = "Item1"
			' 
			' parentBarItem7
			' 
			Me.parentBarItem7.CustomTextFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.parentBarItem7.ID = "DropDown1"
			Me.parentBarItem7.ImageIndex = 14
			Me.parentBarItem7.ImageList = Me.imageList1
			Me.parentBarItem7.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem10})
			Me.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.parentBarItem7.Text = "DropDown1"
			' 
			' barItem10
			' 
			Me.barItem10.ID = "Button Item1"
			Me.barItem10.Text = "Button Item1"
			' 
			' barItem12
			' 
			Me.barItem12.CustomTextFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.barItem12.ID = "Item2"
			Me.barItem12.ImageIndex = 17
			Me.barItem12.ImageList = Me.imageList1
			Me.barItem12.Text = "Item2"
			' 
			' barItem13
			' 
			Me.barItem13.CustomTextFont = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
			Me.barItem13.ID = "Item3"
			Me.barItem13.ImageIndex = 18
			Me.barItem13.ImageList = Me.imageList1
			Me.barItem13.Text = "Item3"
			' 
			' pnlNewDocument
			' 
			Me.pnlNewDocument.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.cardLayout1.SetCardName(Me.pnlNewDocument, "Neues Dokument")
			Me.pnlNewDocument.Controls.Add(Me.label1)
			Me.pnlNewDocument.Controls.Add(Me.label36)
			Me.pnlNewDocument.Controls.Add(Me.label37)
			Me.pnlNewDocument.Controls.Add(Me.label38)
			Me.pnlNewDocument.Controls.Add(Me.linkLabel20)
			Me.pnlNewDocument.Controls.Add(Me.label33)
			Me.pnlNewDocument.Controls.Add(Me.buttonAdv1)
			Me.pnlNewDocument.Controls.Add(Me.label34)
			Me.pnlNewDocument.Controls.Add(Me.textBox4)
			Me.pnlNewDocument.Controls.Add(Me.label35)
			Me.pnlNewDocument.Controls.Add(Me.label28)
			Me.pnlNewDocument.Controls.Add(Me.label29)
			Me.pnlNewDocument.Controls.Add(Me.label30)
			Me.pnlNewDocument.Controls.Add(Me.label31)
			Me.pnlNewDocument.Controls.Add(Me.label32)
			Me.pnlNewDocument.Controls.Add(Me.linkLabel17)
			Me.pnlNewDocument.Controls.Add(Me.linkLabel18)
			Me.pnlNewDocument.Controls.Add(Me.linkLabel19)
			Me.pnlNewDocument.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.pnlNewDocument.Location = New System.Drawing.Point(0, 0)
			Me.cardLayout1.SetMinimumSize(Me.pnlNewDocument, New System.Drawing.Size(200, 272))
			Me.pnlNewDocument.Name = "pnlNewDocument"
			Me.cardLayout1.SetPreferredSize(Me.pnlNewDocument, New System.Drawing.Size(200, 272))
			Me.pnlNewDocument.Size = New System.Drawing.Size(220, 528)
			Me.pnlNewDocument.TabIndex = 32
			Me.pnlNewDocument.Tag = "Neues Dokument"
			' 
			' label1
			' 
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.label1.Location = New System.Drawing.Point(8, 234)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(168, 38)
			Me.label1.TabIndex = 76
			Me.label1.Text = "Klicken Sie auf 'Go' Taste für lokalisierte MessageBoxAdv"
			' 
			' label36
			' 
			Me.label36.BackColor = System.Drawing.Color.Transparent
			Me.label36.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label36.ForeColor = System.Drawing.SystemColors.ControlText
			Me.label36.Location = New System.Drawing.Point(8, 272)
			Me.label36.Name = "label36"
			Me.label36.Size = New System.Drawing.Size(144, 16)
			Me.label36.TabIndex = 75
			Me.label36.Text = "Zuletzt verwendete Vorlagen"
			' 
			' label37
			' 
			Me.label37.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.label37.ForeColor = System.Drawing.Color.Transparent
			Me.label37.Location = New System.Drawing.Point(8, 288)
			Me.label37.Name = "label37"
			Me.label37.Size = New System.Drawing.Size(235, 2)
			Me.label37.TabIndex = 74
			' 
			' label38
			' 
			Me.label38.ImageIndex = 22
			Me.label38.ImageList = Me.imageList1
			Me.label38.Location = New System.Drawing.Point(8, 304)
			Me.label38.Name = "label38"
			Me.label38.Size = New System.Drawing.Size(20, 24)
			Me.label38.TabIndex = 73
			' 
			' linkLabel20
			' 
			Me.linkLabel20.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel20.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.linkLabel20.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel20.Location = New System.Drawing.Point(32, 312)
			Me.linkLabel20.Name = "linkLabel20"
			Me.linkLabel20.Size = New System.Drawing.Size(112, 16)
			Me.linkLabel20.TabIndex = 72
			Me.linkLabel20.TabStop = True
			Me.linkLabel20.Text = "Letter-Format"
			' 
			' label33
			' 
			Me.label33.BackColor = System.Drawing.Color.Transparent
			Me.label33.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label33.ForeColor = System.Drawing.SystemColors.ControlText
			Me.label33.Location = New System.Drawing.Point(8, 160)
			Me.label33.Name = "label33"
			Me.label33.Size = New System.Drawing.Size(64, 16)
			Me.label33.TabIndex = 71
			Me.label33.Text = "Vorlagen"
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv1.Location = New System.Drawing.Point(175, 208)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(31, 23)
			Me.buttonAdv1.TabIndex = 21
			Me.buttonAdv1.Text = "Go"
			Me.buttonAdv1.UseVisualStyle = True
			' 
			' label34
			' 
			Me.label34.BackColor = System.Drawing.Color.Transparent
			Me.label34.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.label34.Location = New System.Drawing.Point(8, 184)
			Me.label34.Name = "label34"
			Me.label34.Size = New System.Drawing.Size(96, 16)
			Me.label34.TabIndex = 70
			Me.label34.Text = "Suchen Sie online nach:"
			' 
			' textBox4
			' 
			Me.textBox4.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.textBox4.Location = New System.Drawing.Point(8, 208)
			Me.textBox4.Name = "textBox4"
			Me.textBox4.Size = New System.Drawing.Size(155, 23)
			Me.textBox4.TabIndex = 68
			' 
			' label35
			' 
			Me.label35.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.label35.ForeColor = System.Drawing.Color.Transparent
			Me.label35.Location = New System.Drawing.Point(8, 176)
			Me.label35.Name = "label35"
			Me.label35.Size = New System.Drawing.Size(235, 2)
			Me.label35.TabIndex = 67
			' 
			' label28
			' 
			Me.label28.BackColor = System.Drawing.Color.Transparent
			Me.label28.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label28.ForeColor = System.Drawing.SystemColors.ControlText
			Me.label28.Location = New System.Drawing.Point(8, 16)
			Me.label28.Name = "label28"
			Me.label28.Size = New System.Drawing.Size(136, 16)
			Me.label28.TabIndex = 66
			Me.label28.Text = "Neue"
			' 
			' label29
			' 
			Me.label29.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
			Me.label29.ForeColor = System.Drawing.Color.Transparent
			Me.label29.Location = New System.Drawing.Point(8, 32)
			Me.label29.Name = "label29"
			Me.label29.Size = New System.Drawing.Size(235, 2)
			Me.label29.TabIndex = 65
			' 
			' label30
			' 
			Me.label30.Image = (CType(resources.GetObject("label30.Image"), System.Drawing.Image))
			Me.label30.Location = New System.Drawing.Point(8, 96)
			Me.label30.Name = "label30"
			Me.label30.Size = New System.Drawing.Size(20, 16)
			Me.label30.TabIndex = 64
			' 
			' label31
			' 
			Me.label31.Image = (CType(resources.GetObject("label31.Image"), System.Drawing.Image))
			Me.label31.Location = New System.Drawing.Point(8, 72)
			Me.label31.Name = "label31"
			Me.label31.Size = New System.Drawing.Size(20, 16)
			Me.label31.TabIndex = 63
			' 
			' label32
			' 
			Me.label32.Image = (CType(resources.GetObject("label32.Image"), System.Drawing.Image))
			Me.label32.Location = New System.Drawing.Point(8, 48)
			Me.label32.Name = "label32"
			Me.label32.Size = New System.Drawing.Size(20, 16)
			Me.label32.TabIndex = 62
			' 
			' linkLabel17
			' 
			Me.linkLabel17.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel17.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.linkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel17.Location = New System.Drawing.Point(32, 96)
			Me.linkLabel17.Name = "linkLabel17"
			Me.linkLabel17.Size = New System.Drawing.Size(192, 16)
			Me.linkLabel17.TabIndex = 61
			Me.linkLabel17.TabStop = True
			Me.linkLabel17.Text = "Mit vorhandenem Dokument"
			Me.linkLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' linkLabel18
			' 
			Me.linkLabel18.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel18.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.linkLabel18.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel18.Location = New System.Drawing.Point(32, 72)
			Me.linkLabel18.Name = "linkLabel18"
			Me.linkLabel18.Size = New System.Drawing.Size(192, 16)
			Me.linkLabel18.TabIndex = 60
			Me.linkLabel18.TabStop = True
			Me.linkLabel18.Text = "Wählen Sie Dokument-Typ"
			Me.linkLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' linkLabel19
			' 
			Me.linkLabel19.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel19.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel19.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel19.Location = New System.Drawing.Point(32, 48)
			Me.linkLabel19.Name = "linkLabel19"
			Me.linkLabel19.Size = New System.Drawing.Size(192, 16)
			Me.linkLabel19.TabIndex = 59
			Me.linkLabel19.TabStop = True
			Me.linkLabel19.Text = "Leeres Dokument"
			' 
			' pnlSearchOptions
			' 
			Me.pnlSearchOptions.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.cardLayout1.SetCardName(Me.pnlSearchOptions, "SearchOptions")
			Me.pnlSearchOptions.Controls.Add(Me.xpTaskBar1)
			Me.pnlSearchOptions.Location = New System.Drawing.Point(0, 0)
			Me.cardLayout1.SetMinimumSize(Me.pnlSearchOptions, New System.Drawing.Size(192, 232))
			Me.pnlSearchOptions.Name = "pnlSearchOptions"
			Me.cardLayout1.SetPreferredSize(Me.pnlSearchOptions, New System.Drawing.Size(192, 232))
			Me.pnlSearchOptions.Size = New System.Drawing.Size(220, 528)
			Me.pnlSearchOptions.TabIndex = 31
			Me.pnlSearchOptions.Tag = "Suchoptionen"
			' 
			' xpTaskBar1
			' 
			Me.xpTaskBar1.AutoPersistStates = False
			Me.xpTaskBar1.AutoScroll = True
			Me.xpTaskBar1.BackColor = System.Drawing.Color.Transparent
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox1)
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox2)
			Me.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xpTaskBar1.HeaderImageList = Me.LargeimageList
			Me.xpTaskBar1.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar1.Name = "xpTaskBar1"
			Me.xpTaskBar1.Padding = New System.Windows.Forms.Padding(10)
			Me.xpTaskBar1.Size = New System.Drawing.Size(216, 524)
			Me.xpTaskBar1.TabIndex = 10
			' 
			' xpTaskBarBox1
			' 
			Me.xpTaskBarBox1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.LightSteelBlue
			Me.xpTaskBarBox1.HeaderImageIndex = 0
			Me.xpTaskBarBox1.HitTaskBoxArea = False
			Me.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty
			Me.xpTaskBarBox1.ImageList = Me.imageList1
			Me.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.AliceBlue
			Me.xpTaskBarBox1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results based on order", System.Drawing.SystemColors.ActiveCaption, 22, Nothing, "about items", True, True, "", New System.Drawing.Font("Tahoma", 8.25F), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results based on date", System.Drawing.Color.Empty, 23, Nothing, "about drawing", True, True, "", New System.Drawing.Font("Tahoma", 8.25F), 0)})
			Me.xpTaskBarBox1.Location = New System.Drawing.Point(10, 10)
			Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
			Me.xpTaskBarBox1.Size = New System.Drawing.Size(196, 113)
			Me.xpTaskBarBox1.TabIndex = 0
			Me.xpTaskBarBox1.Text = "Suchoptionen"
			' 
			' xpTaskBarBox2
			' 
			Me.xpTaskBarBox2.Controls.Add(Me.gradientPanel1)
			Me.xpTaskBarBox2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.SlateGray
			Me.xpTaskBarBox2.HeaderForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox2.HeaderImageIndex = 1
			Me.xpTaskBarBox2.HitTaskBoxArea = False
			Me.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty
			Me.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.AliceBlue
			Me.xpTaskBarBox2.Location = New System.Drawing.Point(10, 123)
			Me.xpTaskBarBox2.Name = "xpTaskBarBox2"
			Me.xpTaskBarBox2.PreferredChildPanelHeight = 120
			Me.xpTaskBarBox2.Size = New System.Drawing.Size(196, 166)
			Me.xpTaskBarBox2.TabIndex = 1
			Me.xpTaskBarBox2.Text = "Suche"
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(246))))), (CInt(Fix((CByte(246))))), (CInt(Fix((CByte(252)))))), System.Drawing.Color.AliceBlue)
			Me.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel1.Controls.Add(Me.label26)
			Me.gradientPanel1.Controls.Add(Me.textBox2)
			Me.gradientPanel1.Controls.Add(Me.label27)
			Me.gradientPanel1.Controls.Add(Me.comboBoxAdv2)
			Me.gradientPanel1.Controls.Add(Me.buttonAdv2)
			Me.gradientPanel1.Location = New System.Drawing.Point(2, 44)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(192, 120)
			Me.gradientPanel1.TabIndex = 0
			' 
			' label26
			' 
			Me.label26.AutoSize = True
			Me.label26.Location = New System.Drawing.Point(5, 40)
			Me.label26.Name = "label26"
			Me.label26.Size = New System.Drawing.Size(57, 13)
			Me.label26.TabIndex = 2
			Me.label26.Text = "Kategorie:"
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(64, 8)
			Me.textBox2.Multiline = True
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(120, 21)
			Me.textBox2.TabIndex = 1
			' 
			' label27
			' 
			Me.label27.Location = New System.Drawing.Point(6, 8)
			Me.label27.Name = "label27"
			Me.label27.Size = New System.Drawing.Size(64, 16)
			Me.label27.TabIndex = 0
			Me.label27.Text = "Stichwort:"
			' 
			' comboBoxAdv2
			' 
			Me.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
			Me.comboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBoxAdv2.Location = New System.Drawing.Point(63, 35)
			Me.comboBoxAdv2.Name = "comboBoxAdv2"
			Me.comboBoxAdv2.Size = New System.Drawing.Size(121, 21)
			Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.comboBoxAdv2.TabIndex = 23
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv2.Location = New System.Drawing.Point(64, 77)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Size = New System.Drawing.Size(75, 23)
			Me.buttonAdv2.TabIndex = 22
			Me.buttonAdv2.Text = "Suche"
			Me.buttonAdv2.UseVisualStyle = True
			' 
			' LargeimageList
			' 
			Me.LargeimageList.ImageStream = (CType(resources.GetObject("LargeimageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.LargeimageList.TransparentColor = System.Drawing.Color.Transparent
			Me.LargeimageList.Images.SetKeyName(0, "")
			Me.LargeimageList.Images.SetKeyName(1, "")
			' 
			' popupMenu1
			' 
			Me.popupMenu1.ParentBarItem = Me.parentBarItem12
			' 
			' parentBarItem12
			' 
			Me.parentBarItem12.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.biGettingStarted, Me.biNewDocument, Me.biSearchOptions, Me.barItem6, Me.barItem18, Me.barItem21})
			Me.parentBarItem12.SeparatorIndices.AddRange(New Integer() { 3})
			Me.parentBarItem12.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' biGettingStarted
			' 
			Me.biGettingStarted.ID = "GettingStarted"
			Me.biGettingStarted.ImageIndex = 25
			Me.biGettingStarted.ImageList = Me.imageList1
			Me.biGettingStarted.Text = "Getting Started"
			' 
			' biNewDocument
			' 
			Me.biNewDocument.ID = "New Document"
			Me.biNewDocument.ImageIndex = 22
			Me.biNewDocument.ImageList = Me.imageList1
			Me.biNewDocument.Text = "Neues Dokument"
			' 
			' biSearchOptions
			' 
			Me.biSearchOptions.ID = "Search Options"
			Me.biSearchOptions.ImageIndex = 26
			Me.biSearchOptions.ImageList = Me.imageList1
			Me.biSearchOptions.Text = "Suchoptionen"
			' 
			' barItem6
			' 
			Me.barItem6.ID = "New Document"
			Me.barItem6.ImageIndex = 2
			Me.barItem6.ImageList = Me.imageList1
			Me.barItem6.Text = "Dokument speichern"
			' 
			' barItem18
			' 
			Me.barItem18.ID = "Review"
			Me.barItem18.Text = "Review"
			' 
			' barItem21
			' 
			Me.barItem21.ID = "Updates"
			Me.barItem21.Text = "Updates"
			' 
			' controlBar2
			' 
			Me.controlBar2.CaptionControl = Me.comboBoxAdv1
			Me.controlBar2.ChevronColor = System.Drawing.SystemColors.ControlText
			Me.controlBar2.ControlBarCaptionHeight = 25
			Me.controlBar2.Controls.Add(Me.listView1)
			Me.controlBar2.Controls.Add(Me.comboBoxAdv1)
			Me.controlBar2.Cursor = System.Windows.Forms.Cursors.SizeWE
			Me.controlBar2.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right
			Me.controlBar2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.controlBar2.HideDropDownButton = True
			Me.controlBar2.MaxLength = 200
			Me.controlBar2.MinHeight = 186
			Me.controlBar2.MinLength = 50
			Me.controlBar2.Name = "controlBar2"
			Me.controlBar2.RowIndex = 0
			Me.controlBar2.TabIndex = 1
			Me.controlBar2.TabStop = False
			Me.controlBar2.Text = "Dokumenteigenschaften"
			' 
			' comboBoxAdv1
			' 
			Me.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
			Me.comboBoxAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.comboBoxAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxAdv1.Items.AddRange(New Object() { "Node Types", "Top-level Caption Nodes", "Sub Caption Nodes", "Selected Nodes", "Underlined Nodes", "Highlighted Nodes", "Italicized Nodes", ""})
			Me.comboBoxAdv1.Location = New System.Drawing.Point(2, 27)
			Me.comboBoxAdv1.Name = "comboBoxAdv1"
			Me.comboBoxAdv1.Size = New System.Drawing.Size(181, 19)
			Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.comboBoxAdv1.TabIndex = 29
			Me.comboBoxAdv1.Text = "Übersicht"
			' 
			' listView1
			' 
			Me.listView1.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9})
			Me.listView1.Location = New System.Drawing.Point(2, 46)
			Me.listView1.Name = "listView1"
			Me.listView1.Size = New System.Drawing.Size(182, 540)
			Me.listView1.SmallImageList = Me.imageList1
			Me.listView1.TabIndex = 10
			Me.listView1.UseCompatibleStateImageBehavior = False
			Me.listView1.View = System.Windows.Forms.View.List
			' 
			' parentBarItem3
			' 
			Me.parentBarItem3.CategoryIndex = 3
			Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem3.ID = "Submenu"
			Me.parentBarItem3.Text = "Untermenü"
			' 
			' comboBoxBarItem1
			' 
			Me.comboBoxBarItem1.AutoAppend = True
			Me.comboBoxBarItem1.CategoryIndex = 1
			Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxBarItem1.ID = "Editable"
			Me.comboBoxBarItem1.MinWidth = 100
			Me.comboBoxBarItem1.Text = "Editable"
			Me.comboBoxBarItem1.Tooltip = "Stellt Editierbare und AutoAppend Funktionalität für Suchen Features."
			' 
			' comboBoxBarItem2
			' 
			Me.comboBoxBarItem2.CategoryIndex = 1
			Me.comboBoxBarItem2.ChoiceList.AddRange(New String() { "Release", "Debug"})
			Me.comboBoxBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxBarItem2.Editable = False
			Me.comboBoxBarItem2.ID = "ChoiceList"
			Me.comboBoxBarItem2.MinWidth = 70
			Me.comboBoxBarItem2.Text = "Auswahlliste"
			' 
			' fontColorBarItem
			' 
			Me.fontColorBarItem.CategoryIndex = 1
			Me.fontColorBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.fontColorBarItem.ID = "Font DropDown"
			Me.fontColorBarItem.ImageIndex = 8
			Me.fontColorBarItem.Text = "Font DropDown"
			' 
			' barItem8
			' 
			Me.barItem8.ID = "Item1"
			Me.barItem8.ImageIndex = 12
			Me.barItem8.ImageList = Me.imageList1
			Me.barItem8.Text = "Item1"
			' 
			' dropDownBarItem3
			' 
			Me.dropDownBarItem3.ImageIndex = 15
			Me.dropDownBarItem3.ImageList = Me.imageList1
			' 
			' barItem9
			' 
			Me.barItem9.ID = "Item2"
			Me.barItem9.ImageIndex = 13
			Me.barItem9.ImageList = Me.imageList1
			Me.barItem9.Text = "Item2"
			' 
			' parentBarItem8
			' 
			Me.parentBarItem8.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem11, Me.barItem12, Me.barItem13, Me.parentBarItem9, Me.comboBoxBarItem3})
			Me.parentBarItem8.SeparatorIndices.AddRange(New Integer() { 3})
			' 
			' parentBarItem9
			' 
			Me.parentBarItem9.ID = "SubMenu"
			Me.parentBarItem9.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem14, Me.barItem15})
			Me.parentBarItem9.Text = "Untermenü"
			' 
			' barItem14
			' 
			Me.barItem14.ID = "SubItem1"
			Me.barItem14.Text = "SubItem1"
			' 
			' barItem15
			' 
			Me.barItem15.ID = "SubItem2"
			Me.barItem15.Text = "SubItem2"
			' 
			' comboBoxBarItem3
			' 
			Me.comboBoxBarItem3.AutoAppend = True
			Me.comboBoxBarItem3.ID = "Combo:"
			Me.comboBoxBarItem3.MinWidth = 70
			Me.comboBoxBarItem3.Text = "Combo:"
			' 
			' cardLayout1
			' 
			Me.cardLayout1.ContainerControl = Me.taskPanel
			Me.cardLayout1.LayoutMode = Syncfusion.Windows.Forms.Tools.CardLayoutMode.Fill
			Me.cardLayout1.SelectedCard = "GettingStarted"
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(864, 638)
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.IsMdiContainer = True
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "New Localization Procedure"
			CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.controlBar1.ResumeLayout(False)
			Me.taskPanel.ResumeLayout(False)
			CType(Me.pnlGettingStarted, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlGettingStarted.ResumeLayout(False)
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel2.ResumeLayout(False)
			CType(Me.comboBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pnlNewDocument, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlNewDocument.ResumeLayout(False)
			Me.pnlNewDocument.PerformLayout()
			CType(Me.pnlSearchOptions, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pnlSearchOptions.ResumeLayout(False)
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar1.ResumeLayout(False)
			Me.xpTaskBarBox2.ResumeLayout(False)
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			Me.gradientPanel1.PerformLayout()
			CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.controlBar2.ResumeLayout(False)
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxBarItem3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardLayout1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Protected Overrides Sub OnSystemColorsChanged(ByVal e As EventArgs)
			MyBase.OnSystemColorsChanged(e)
		End Sub


		' Display the About dialog
		Private aboutForm As DemoCommon.AboutForm = Nothing
		Private Sub barItem19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem19.Click
			aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			aboutForm.ShowDialog()
		End Sub

		' Create a new MDI child form
		Private Sub barItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem1.Click
			Dim txtform As LocalizationDemo.TextForm = New TextForm()
			txtform.TopLevel = False
			txtform.MdiParent = Me
			txtform.Show()
			nLetterCount += 1
			txtform.Text = String.Concat("Letter ", (nLetterCount).ToString())
		End Sub

		' Create a new MDI child form
		Private Sub barItem16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem16.Click
			Dim txtform As LocalizationDemo.TextForm = New TextForm()
			txtform.TopLevel = False
			txtform.MdiParent = Me
			txtform.Show()
			Me.nReportCount += 1
			txtform.Text = String.Concat("Report ", (Me.nReportCount).ToString())
		End Sub

		' Create a new MDI child form
		Private Sub barItem17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem17.Click
			Dim txtform As LocalizationDemo.TextForm = New TextForm()
			txtform.TopLevel = False
			txtform.MdiParent = Me
			txtform.Show()
			Me.nInvoiceCount += 1
			txtform.Text = String.Concat("Invoice ", (Me.nInvoiceCount).ToString())
		End Sub


		' Update the 'View' PopupMenu UI state
		Private Sub parentBarItem5_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles parentBarItem5.Popup
			Me.barItem4.Checked = Me.controlBar1.Visible
			Me.barItem5.Checked = Me.controlBar2.Visible
		End Sub

		' Show/hide the TaskPane ControlBar
		Private Sub barItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem4.Click
			Me.controlBar1.Visible = Not Me.controlBar1.Visible
		End Sub

		' Show/hide the DocumentProperties ControlBar
		Private Sub barItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem5.Click
			Me.controlBar2.Visible = Not Me.controlBar2.Visible
		End Sub

		' ControlBar1 - TaskPane - switching logic implemented using the Card LayoutManager
		Private Sub biTaskNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biTaskNext.Click
			Me.cardLayout1.Next()
			Me.controlBar1.Text = TryCast(Me.cardLayout1.GetComponentFromName(Me.cardLayout1.SelectedCard).Tag, String)
			'if(this.cardLayout1.NextCardIndex)
		End Sub

		Private Sub biTaskPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biTaskPrevious.Click
			Me.cardLayout1.Previous()
			Me.controlBar1.Text = TryCast(Me.cardLayout1.GetComponentFromName(Me.cardLayout1.SelectedCard).Tag, String)
			'if(this.cardLayout1.PreviousCardIndex)
		End Sub

		Private Sub biTaskHome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biTaskHome.Click
			Me.cardLayout1.First()
			Me.controlBar1.Text = TryCast(Me.cardLayout1.GetComponentFromName(Me.cardLayout1.SelectedCard).Tag, String)
		End Sub

		' The ControlBar1 PopupMenu - Update the taskpane visibility state
		Private Sub parentBarItem12_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles parentBarItem12.Popup
			Dim selectedcard As String = TryCast(Me.cardLayout1.GetComponentFromName(Me.cardLayout1.SelectedCard).Tag, String)
			Me.biGettingStarted.Checked = (selectedcard = (TryCast(Me.pnlGettingStarted.Tag, String)))
			Me.biNewDocument.Checked = (selectedcard = (TryCast(Me.pnlNewDocument.Tag, String)))
			Me.biSearchOptions.Checked = (selectedcard = (TryCast(Me.pnlSearchOptions.Tag, String)))
		End Sub

		' Set the Tasks ControlBar's selected card depending on the ControlBar PopupMenu item selection
		Private Sub biGettingStarted_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biGettingStarted.Click
			Me.cardLayout1.Show("GettingStarted")
			Me.controlBar1.Text = "Getting Started"
		End Sub

		Private Sub biNewDocument_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biNewDocument.Click
			Me.cardLayout1.Show("Neues Dokument")
			Me.controlBar1.Text = "Neues Dokument"
		End Sub

		Private Sub biSearchOptions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biSearchOptions.Click
			Me.cardLayout1.Show("SearchOptions")
			Me.controlBar1.Text = "Search Options"
		End Sub

		' Optionally, switch the XPTaskBar layout between the horizontal and vertical modes when the 
		' ControlBar orientation changes
		Private Sub controlBar1_CommandBarStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles controlBar1.CommandBarStateChanged
			If Me.controlBar1.Floating Then
				' If floating:
				Me.xpTaskBar1.VerticalLayout = True
			Else
				' If Docked:
				If Me.controlBar1.DockState = CommandBarDockState.Top OrElse Me.controlBar1.DockState = CommandBarDockState.Bottom Then
					' to top or bottom
					Me.xpTaskBar1.VerticalLayout = False
				Else
					' to left or right
					Me.xpTaskBar1.VerticalLayout = True
				End If
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.cardLayout1.Show("Neues Dokument")
		End Sub

		Private Sub barItem7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem7.Click
			Application.Exit()
		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			MessageBoxAdv.Show(Me, "Fehler nicht mit dem Internet verbunden!", "Warnung", MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning)
		End Sub
	End Class
End Namespace
