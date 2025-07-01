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
Imports DemoCommon


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
   Inherits System.Windows.Forms.Form
   Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
   Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
   Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
   Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
   Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
   Private barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
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
   Private statusBar1 As System.Windows.Forms.StatusBar
   Private controlBar1 As Syncfusion.Windows.Forms.Tools.ControlBar
   Private taskPanel As System.Windows.Forms.Panel
   Private controlBar2 As Syncfusion.Windows.Forms.Tools.ControlBar
   Private xpTaskPaneToolbar As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
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
    Private comboBoxAdv4 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Private linkLabel15 As System.Windows.Forms.LinkLabel
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
    Private linkLabel17 As System.Windows.Forms.LinkLabel
    Private linkLabel18 As System.Windows.Forms.LinkLabel
    Private linkLabel19 As System.Windows.Forms.LinkLabel
    Private label33 As System.Windows.Forms.Label
    Private label34 As System.Windows.Forms.Label
    Private textBox4 As System.Windows.Forms.TextBox
    Private label35 As System.Windows.Forms.Label
    Private label36 As System.Windows.Forms.Label
    Private label37 As System.Windows.Forms.Label
    Private linkLabel20 As System.Windows.Forms.LinkLabel
    Private components As System.ComponentModel.IContainer
    Private WithEvents aboutForm As AboutForm
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
    Friend WithEvents ButtonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents ComboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
    Friend WithEvents ButtonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
    Friend WithEvents biTaskPrevious As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Friend WithEvents biTaskNext As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Friend WithEvents biTaskHome As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private nInvoiceCount As Integer = 0


    Public Sub New()
        InitializeComponent()

        Dim txtform As New TextForm()
        txtform.TopLevel = False
        txtform.MdiParent = Me
        nReportCount += 1
        txtform.Show()
        txtform.Text = String.Concat("Report ", nReportCount.ToString())
        Me.cardLayout1.First()
        'ToDo: Unsupported operator
        'ToDo: ++ operator not supported within expressions
    End Sub 'New


    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose


    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Friend WithEvents GradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
    Friend WithEvents LargeimageList As System.Windows.Forms.ImageList
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Private WithEvents label25 As System.Windows.Forms.Label
    Private WithEvents label24 As System.Windows.Forms.Label
    Private WithEvents label32 As System.Windows.Forms.Label
    Private WithEvents label31 As System.Windows.Forms.Label
    Private WithEvents label30 As System.Windows.Forms.Label
    Friend WithEvents label38 As System.Windows.Forms.Label
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Project Management"}, 13, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75!))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Sections"}, 18, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75!))
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Introduction"}, 14, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75!))
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Planning"}, 15, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75!))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Departments"}, 22, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75!))
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Review 1"}, 13, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75!))
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Review 2"}, 13, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75!))
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Records"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75!))
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Inventory"}, 16, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Calibri", 9.75!))
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
        Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "MainMenu")
        Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.parentBarItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.parentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.listBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
        Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.parentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.toolbarListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem
        Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.parentBarItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.barItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "File")
        Me.controlBar1 = New Syncfusion.Windows.Forms.Tools.ControlBar
        Me.xpTaskPaneToolbar = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
        Me.taskPanel = New System.Windows.Forms.Panel
        Me.pnlGettingStarted = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.label24 = New System.Windows.Forms.Label
        Me.label25 = New System.Windows.Forms.Label
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.linkLabel15 = New System.Windows.Forms.LinkLabel
        Me.linkLabel16 = New System.Windows.Forms.LinkLabel
        Me.comboBoxAdv4 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Me.label20 = New System.Windows.Forms.Label
        Me.linkLabel11 = New System.Windows.Forms.LinkLabel
        Me.label21 = New System.Windows.Forms.Label
        Me.label22 = New System.Windows.Forms.Label
        Me.label23 = New System.Windows.Forms.Label
        Me.linkLabel12 = New System.Windows.Forms.LinkLabel
        Me.linkLabel13 = New System.Windows.Forms.LinkLabel
        Me.linkLabel14 = New System.Windows.Forms.LinkLabel
        Me.xpToolBar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
        Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.parentBarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.pnlNewDocument = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.ButtonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.label38 = New System.Windows.Forms.Label
        Me.label30 = New System.Windows.Forms.Label
        Me.label31 = New System.Windows.Forms.Label
        Me.label32 = New System.Windows.Forms.Label
        Me.label36 = New System.Windows.Forms.Label
        Me.label37 = New System.Windows.Forms.Label
        Me.linkLabel20 = New System.Windows.Forms.LinkLabel
        Me.label33 = New System.Windows.Forms.Label
        Me.label34 = New System.Windows.Forms.Label
        Me.textBox4 = New System.Windows.Forms.TextBox
        Me.label35 = New System.Windows.Forms.Label
        Me.label28 = New System.Windows.Forms.Label
        Me.label29 = New System.Windows.Forms.Label
        Me.linkLabel17 = New System.Windows.Forms.LinkLabel
        Me.linkLabel18 = New System.Windows.Forms.LinkLabel
        Me.linkLabel19 = New System.Windows.Forms.LinkLabel
        Me.pnlSearchOptions = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar
        Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
        Me.xpTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
        Me.GradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
        Me.ComboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Me.label26 = New System.Windows.Forms.Label
        Me.ButtonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.textBox2 = New System.Windows.Forms.TextBox
        Me.label27 = New System.Windows.Forms.Label
        Me.LargeimageList = New System.Windows.Forms.ImageList(Me.components)
        Me.popupMenu1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
        Me.parentBarItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.biGettingStarted = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.biNewDocument = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.biSearchOptions = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.controlBar2 = New Syncfusion.Windows.Forms.Tools.ControlBar
        Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Me.listView1 = New System.Windows.Forms.ListView
        Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Me.comboBoxBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Me.fontColorBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
        Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.dropDownBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
        Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.parentBarItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.parentBarItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.barItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.comboBoxBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.statusBar1 = New System.Windows.Forms.StatusBar
        Me.cardLayout1 = New Syncfusion.Windows.Forms.Tools.CardLayout(Me.components)
        Me.biTaskPrevious = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.biTaskNext = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.biTaskHome = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.controlBar1.SuspendLayout()
        Me.taskPanel.SuspendLayout()
        CType(Me.pnlGettingStarted, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGettingStarted.SuspendLayout()
        CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gradientPanel2.SuspendLayout()
        CType(Me.comboBoxAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlNewDocument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNewDocument.SuspendLayout()
        CType(Me.pnlSearchOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearchOptions.SuspendLayout()
        CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xpTaskBar1.SuspendLayout()
        Me.xpTaskBarBox2.SuspendLayout()
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GradientPanel1.SuspendLayout()
        CType(Me.ComboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.controlBar2.SuspendLayout()
        CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cardLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainFrameBarManager1
        '
        Me.mainFrameBarManager1.AutoLoadToolBarPositions = False
        Me.mainFrameBarManager1.AutoPersistCustomization = False
        Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
        Me.mainFrameBarManager1.Bars.Add(Me.bar1)
        Me.mainFrameBarManager1.Bars.Add(Me.bar2)
        Me.mainFrameBarManager1.Categories.Add("File")
        Me.mainFrameBarManager1.Categories.Add("Format")
        Me.mainFrameBarManager1.Categories.Add("View")
        Me.mainFrameBarManager1.Categories.Add("Popups")
        Me.mainFrameBarManager1.Categories.Add("Help")
        Me.mainFrameBarManager1.Categories.Add("Misc")
        Me.mainFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
        Me.mainFrameBarManager1.DetachedCommandBars.Add(Me.controlBar1)
        Me.mainFrameBarManager1.DetachedCommandBars.Add(Me.controlBar2)
        Me.mainFrameBarManager1.EnableCustomizing = False
        Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainFrameBarManager1.Form = Me
        Me.mainFrameBarManager1.ImageList = Me.imageList1
        Me.mainFrameBarManager1.InternalDocking = False
        Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem10, Me.parentBarItem1, Me.barItem2, Me.barItem3, Me.parentBarItem6, Me.listBarItem1, Me.barItem7, Me.parentBarItem3, Me.comboBoxBarItem1, Me.comboBoxBarItem2, Me.fontColorBarItem, Me.parentBarItem5, Me.toolbarListBarItem1, Me.barItem1, Me.barItem16, Me.barItem17, Me.parentBarItem11, Me.barItem19, Me.barItem4, Me.barItem5})
        Me.mainFrameBarManager1.LargeImageList = Nothing
        Me.mainFrameBarManager1.ResetCustomization = False
        Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        '
        'bar1
        '
        Me.bar1.BarName = "MainMenu"
        Me.bar1.BarStyle = CType(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                    Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                    Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                    Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
        Me.bar1.Caption = "MainMenu"
        Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem5, Me.parentBarItem11})
        Me.bar1.Manager = Me.mainFrameBarManager1
        '
        'parentBarItem1
        '
        Me.parentBarItem1.CategoryIndex = 3
        Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem1.ID = "&File"
        Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem10, Me.barItem2, Me.barItem3, Me.parentBarItem6, Me.barItem7})
        Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() {3, 4})
        Me.parentBarItem1.Text = "&File"
        '
        'parentBarItem10
        '
        Me.parentBarItem10.CategoryIndex = 0
        Me.parentBarItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem10.ID = "&New"
        Me.parentBarItem10.ImageIndex = 0
        Me.parentBarItem10.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem16, Me.barItem17})
        Me.parentBarItem10.ParentStyle = Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItemStyle.DropDown
        Me.parentBarItem10.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.parentBarItem10.Text = "&New"
        '
        'barItem1
        '
        Me.barItem1.CategoryIndex = 0
        Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem1.ID = "New1"
        Me.barItem1.ImageIndex = 14
        Me.barItem1.Text = "Letter"
        '
        'barItem16
        '
        Me.barItem16.CategoryIndex = 0
        Me.barItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem16.ID = "New2"
        Me.barItem16.ImageIndex = 15
        Me.barItem16.Text = "Report"
        '
        'barItem17
        '
        Me.barItem17.CategoryIndex = 0
        Me.barItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem17.ID = "New3"
        Me.barItem17.ImageIndex = 13
        Me.barItem17.Text = "Invoice"
        '
        'barItem2
        '
        Me.barItem2.CategoryIndex = 0
        Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem2.ID = "&Open"
        Me.barItem2.ImageIndex = 1
        Me.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.barItem2.Text = "&Open"
        '
        'barItem3
        '
        Me.barItem3.CategoryIndex = 0
        Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem3.ID = "&Save"
        Me.barItem3.ImageIndex = 2
        Me.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.barItem3.Text = "&Save"
        '
        'parentBarItem6
        '
        Me.parentBarItem6.CategoryIndex = 0
        Me.parentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem6.ID = "Recent Views (Expanding List)"
        Me.parentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.listBarItem1})
        Me.parentBarItem6.Text = "Recent Views (Expanding List)"
        '
        'listBarItem1
        '
        Me.listBarItem1.CategoryIndex = 0
        Me.listBarItem1.ChildCaptions.AddRange(New String() {"View 1", "View 2", "View 3"})
        Me.listBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBarItem1.ID = "MRU List"
        Me.listBarItem1.Text = "MRU List"
        '
        'barItem7
        '
        Me.barItem7.CategoryIndex = 0
        Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem7.ID = "&Exit"
        Me.barItem7.Text = "&Exit"
        '
        'parentBarItem5
        '
        Me.parentBarItem5.CategoryIndex = 3
        Me.parentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem5.ID = "&View"
        Me.parentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.toolbarListBarItem1, Me.barItem4, Me.barItem5})
        Me.parentBarItem5.MergeOrder = 2
        Me.parentBarItem5.Text = "&View"
        '
        'toolbarListBarItem1
        '
        Me.toolbarListBarItem1.CategoryIndex = 2
        Me.toolbarListBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolbarListBarItem1.ID = "Toolbar List"
        Me.toolbarListBarItem1.Text = "Toolbar List"
        '
        'barItem4
        '
        Me.barItem4.CategoryIndex = 2
        Me.barItem4.Checked = True
        Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem4.ID = "Task Pane"
        Me.barItem4.Text = "&Task Pane"
        '
        'barItem5
        '
        Me.barItem5.CategoryIndex = 2
        Me.barItem5.Checked = True
        Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem5.ID = "Properties Pane"
        Me.barItem5.Text = "&Properties Pane"
        '
        'parentBarItem11
        '
        Me.parentBarItem11.CategoryIndex = 3
        Me.parentBarItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem11.ID = "&Help"
        Me.parentBarItem11.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem19})
        Me.parentBarItem11.MergeOrder = 5
        Me.parentBarItem11.Text = "&Help"
        '
        'barItem19
        '
        Me.barItem19.CategoryIndex = 4
        Me.barItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem19.ID = "About Syncfusion"
        Me.barItem19.ImageIndex = 41
        Me.barItem19.Text = "About Syncfusion"
        '
        'bar2
        '
        Me.bar2.BarName = "File"
        Me.bar2.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                    Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                    Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
        Me.bar2.Caption = "File"
        Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem10, Me.barItem2, Me.barItem3})
        Me.bar2.Manager = Me.mainFrameBarManager1
        '
        'controlBar1
        '
        Me.controlBar1.CaptionControl = Me.xpTaskPaneToolbar
        Me.controlBar1.ChevronColor = System.Drawing.SystemColors.ControlText
        Me.controlBar1.ControlBarCaptionHeight = 31
        Me.controlBar1.Controls.Add(Me.taskPanel)
        Me.controlBar1.Controls.Add(Me.xpTaskPaneToolbar)
        Me.controlBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left
        Me.controlBar1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controlBar1.MaxLength = 200
        Me.controlBar1.MinHeight = 224
        Me.controlBar1.MinLength = 50
        Me.controlBar1.Name = "controlBar1"
        Me.controlBar1.PopupMenu = Me.popupMenu1
        Me.controlBar1.RowIndex = 0
        Me.controlBar1.TabIndex = 0
        Me.controlBar1.TabStop = False
        Me.controlBar1.Text = "Getting Started"
        '
        'xpTaskPaneToolbar
        '
        Me.xpTaskPaneToolbar.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.xpTaskPaneToolbar.Bar.BarName = ""
        Me.xpTaskPaneToolbar.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biTaskPrevious, Me.biTaskNext, Me.biTaskHome})
        Me.xpTaskPaneToolbar.Bar.Manager = Nothing
        Me.xpTaskPaneToolbar.Location = New System.Drawing.Point(2, 33)
        Me.xpTaskPaneToolbar.Name = "xpTaskPaneToolbar"
        Me.xpTaskPaneToolbar.Size = New System.Drawing.Size(219, 25)
        Me.xpTaskPaneToolbar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.xpTaskPaneToolbar.TabIndex = 29
        Me.xpTaskPaneToolbar.Text = "xpToolBar2"
        '
        'taskPanel
        '
        Me.taskPanel.Controls.Add(Me.pnlGettingStarted)
        Me.taskPanel.Controls.Add(Me.pnlNewDocument)
        Me.taskPanel.Controls.Add(Me.pnlSearchOptions)
        Me.taskPanel.Location = New System.Drawing.Point(2, 56)
        Me.taskPanel.Name = "taskPanel"
        Me.taskPanel.Size = New System.Drawing.Size(220, 507)
        Me.taskPanel.TabIndex = 29
        '
        'pnlGettingStarted
        '
        Me.pnlGettingStarted.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.pnlGettingStarted.BorderColor = System.Drawing.Color.Black
        Me.cardLayout1.SetCardName(Me.pnlGettingStarted, "GettingStarted")
        Me.pnlGettingStarted.Controls.Add(Me.gradientPanel2)
        Me.pnlGettingStarted.Controls.Add(Me.comboBoxAdv4)
        Me.pnlGettingStarted.Controls.Add(Me.label20)
        Me.pnlGettingStarted.Controls.Add(Me.linkLabel11)
        Me.pnlGettingStarted.Controls.Add(Me.label21)
        Me.pnlGettingStarted.Controls.Add(Me.label22)
        Me.pnlGettingStarted.Controls.Add(Me.label23)
        Me.pnlGettingStarted.Controls.Add(Me.linkLabel12)
        Me.pnlGettingStarted.Controls.Add(Me.linkLabel13)
        Me.pnlGettingStarted.Controls.Add(Me.linkLabel14)
        Me.pnlGettingStarted.Controls.Add(Me.xpToolBar2)
        Me.pnlGettingStarted.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.pnlGettingStarted.Location = New System.Drawing.Point(0, 0)
        Me.cardLayout1.SetMinimumSize(Me.pnlGettingStarted, New System.Drawing.Size(176, 232))
        Me.pnlGettingStarted.Name = "pnlGettingStarted"
        Me.cardLayout1.SetPreferredSize(Me.pnlGettingStarted, New System.Drawing.Size(176, 232))
        Me.pnlGettingStarted.Size = New System.Drawing.Size(220, 507)
        Me.pnlGettingStarted.TabIndex = 29
        Me.pnlGettingStarted.Tag = "Getting Started"
        '
        'gradientPanel2
        '
        Me.gradientPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gradientPanel2.Controls.Add(Me.label24)
        Me.gradientPanel2.Controls.Add(Me.label25)
        Me.gradientPanel2.Controls.Add(Me.linkLabel15)
        Me.gradientPanel2.Controls.Add(Me.linkLabel16)
        Me.gradientPanel2.Location = New System.Drawing.Point(11, 272)
        Me.gradientPanel2.Name = "gradientPanel2"
        Me.gradientPanel2.Size = New System.Drawing.Size(195, 70)
        Me.gradientPanel2.TabIndex = 49
        '
        'label24
        '
        Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
        Me.label24.Location = New System.Drawing.Point(8, 42)
        Me.label24.Name = "label24"
        Me.label24.Size = New System.Drawing.Size(16, 16)
        Me.label24.TabIndex = 42
        '
        'label25
        '
        Me.label25.ImageIndex = 1
        Me.label25.ImageList = Me.imageList1
        Me.label25.Location = New System.Drawing.Point(8, 16)
        Me.label25.Name = "label25"
        Me.label25.Size = New System.Drawing.Size(16, 16)
        Me.label25.TabIndex = 41
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
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
        'linkLabel15
        '
        Me.linkLabel15.AutoSize = True
        Me.linkLabel15.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel15.Location = New System.Drawing.Point(42, 42)
        Me.linkLabel15.Name = "linkLabel15"
        Me.linkLabel15.Size = New System.Drawing.Size(145, 15)
        Me.linkLabel15.TabIndex = 39
        Me.linkLabel15.TabStop = True
        Me.linkLabel15.Text = "Create a New Document..."
        '
        'linkLabel16
        '
        Me.linkLabel16.AutoSize = True
        Me.linkLabel16.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel16.Location = New System.Drawing.Point(42, 16)
        Me.linkLabel16.Name = "linkLabel16"
        Me.linkLabel16.Size = New System.Drawing.Size(45, 15)
        Me.linkLabel16.TabIndex = 37
        Me.linkLabel16.TabStop = True
        Me.linkLabel16.Text = "Open..."
        '
        'comboBoxAdv4
        '
        Me.comboBoxAdv4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxAdv4.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.comboBoxAdv4.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.comboBoxAdv4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxAdv4.IgnoreThemeBackground = True
        Me.comboBoxAdv4.Items.AddRange(New Object() {"Custom Document Format 1", "Custom Document Format 2", "Letter Format", "Record Format", "Editorial Format", "Application Format"})
        Me.comboBoxAdv4.Location = New System.Drawing.Point(10, 208)
        Me.comboBoxAdv4.Name = "comboBoxAdv4"
        Me.comboBoxAdv4.Size = New System.Drawing.Size(193, 21)
        Me.comboBoxAdv4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.comboBoxAdv4.SuppressDropDownEvent = False
        Me.comboBoxAdv4.TabIndex = 48
        Me.comboBoxAdv4.Text = "Select Format..."
        '
        'label20
        '
        Me.label20.ImageIndex = 40
        Me.label20.ImageList = Me.imageList1
        Me.label20.Location = New System.Drawing.Point(8, 128)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(16, 8)
        Me.label20.TabIndex = 47
        '
        'linkLabel11
        '
        Me.linkLabel11.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel11.Location = New System.Drawing.Point(32, 128)
        Me.linkLabel11.Name = "linkLabel11"
        Me.linkLabel11.Size = New System.Drawing.Size(40, 16)
        Me.linkLabel11.TabIndex = 46
        Me.linkLabel11.TabStop = True
        Me.linkLabel11.Text = "More..."
        '
        'label21
        '
        Me.label21.ImageIndex = 40
        Me.label21.ImageList = Me.imageList1
        Me.label21.Location = New System.Drawing.Point(8, 96)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(16, 8)
        Me.label21.TabIndex = 45
        '
        'label22
        '
        Me.label22.ImageIndex = 40
        Me.label22.ImageList = Me.imageList1
        Me.label22.Location = New System.Drawing.Point(8, 72)
        Me.label22.Name = "label22"
        Me.label22.Size = New System.Drawing.Size(16, 8)
        Me.label22.TabIndex = 44
        '
        'label23
        '
        Me.label23.ImageIndex = 40
        Me.label23.ImageList = Me.imageList1
        Me.label23.Location = New System.Drawing.Point(8, 48)
        Me.label23.Name = "label23"
        Me.label23.Size = New System.Drawing.Size(16, 16)
        Me.label23.TabIndex = 43
        '
        'linkLabel12
        '
        Me.linkLabel12.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel12.Location = New System.Drawing.Point(32, 96)
        Me.linkLabel12.Name = "linkLabel12"
        Me.linkLabel12.Size = New System.Drawing.Size(168, 16)
        Me.linkLabel12.TabIndex = 42
        Me.linkLabel12.TabStop = True
        Me.linkLabel12.Text = "Save Current Document Format"
        '
        'linkLabel13
        '
        Me.linkLabel13.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel13.Location = New System.Drawing.Point(32, 72)
        Me.linkLabel13.Name = "linkLabel13"
        Me.linkLabel13.Size = New System.Drawing.Size(120, 16)
        Me.linkLabel13.TabIndex = 41
        Me.linkLabel13.TabStop = True
        Me.linkLabel13.Text = "Modify Current Format"
        '
        'linkLabel14
        '
        Me.linkLabel14.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel14.Location = New System.Drawing.Point(32, 48)
        Me.linkLabel14.Name = "linkLabel14"
        Me.linkLabel14.Size = New System.Drawing.Size(176, 16)
        Me.linkLabel14.TabIndex = 40
        Me.linkLabel14.TabStop = True
        Me.linkLabel14.Text = "Create Custom Document Format"
        '
        'xpToolBar2
        '
        Me.xpToolBar2.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.xpToolBar2.Bar.BarName = ""
        Me.xpToolBar2.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem11, Me.parentBarItem7, Me.barItem12, Me.barItem13, Me.barItem11, Me.parentBarItem7, Me.barItem12, Me.barItem13})
        Me.xpToolBar2.Bar.Manager = Nothing
        Me.xpToolBar2.Bar.SeparatorIndices.AddRange(New Integer() {2, 6})
        Me.xpToolBar2.Dock = System.Windows.Forms.DockStyle.Top
        Me.xpToolBar2.Location = New System.Drawing.Point(0, 0)
        Me.xpToolBar2.Name = "xpToolBar2"
        Me.xpToolBar2.SeparatorIndices.AddRange(New Integer() {2})
        Me.xpToolBar2.Size = New System.Drawing.Size(217, 25)
        Me.xpToolBar2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.xpToolBar2.TabIndex = 2
        Me.xpToolBar2.Text = "xpToolBar2"
        '
        'barItem11
        '
        Me.barItem11.ID = "Item1"
        Me.barItem11.ImageIndex = 16
        Me.barItem11.ImageList = Me.imageList1
        Me.barItem11.Text = "Item1"
        '
        'parentBarItem7
        '
        Me.parentBarItem7.ID = "DropDown1"
        Me.parentBarItem7.ImageIndex = 14
        Me.parentBarItem7.ImageList = Me.imageList1
        Me.parentBarItem7.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem10})
        Me.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
        Me.parentBarItem7.Text = "DropDown1"
        '
        'barItem10
        '
        Me.barItem10.ID = "Button Item1"
        Me.barItem10.Text = "Button Item1"
        '
        'barItem12
        '
        Me.barItem12.ID = "Item2"
        Me.barItem12.ImageIndex = 17
        Me.barItem12.ImageList = Me.imageList1
        Me.barItem12.Text = "Item2"
        '
        'barItem13
        '
        Me.barItem13.ID = "Item3"
        Me.barItem13.ImageIndex = 18
        Me.barItem13.ImageList = Me.imageList1
        Me.barItem13.Text = "Item3"
        '
        'pnlNewDocument
        '
        Me.pnlNewDocument.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.pnlNewDocument.BorderColor = System.Drawing.Color.Black
        Me.cardLayout1.SetCardName(Me.pnlNewDocument, "NewDocument")
        Me.pnlNewDocument.Controls.Add(Me.ButtonAdv1)
        Me.pnlNewDocument.Controls.Add(Me.label38)
        Me.pnlNewDocument.Controls.Add(Me.label30)
        Me.pnlNewDocument.Controls.Add(Me.label31)
        Me.pnlNewDocument.Controls.Add(Me.label32)
        Me.pnlNewDocument.Controls.Add(Me.label36)
        Me.pnlNewDocument.Controls.Add(Me.label37)
        Me.pnlNewDocument.Controls.Add(Me.linkLabel20)
        Me.pnlNewDocument.Controls.Add(Me.label33)
        Me.pnlNewDocument.Controls.Add(Me.label34)
        Me.pnlNewDocument.Controls.Add(Me.textBox4)
        Me.pnlNewDocument.Controls.Add(Me.label35)
        Me.pnlNewDocument.Controls.Add(Me.label28)
        Me.pnlNewDocument.Controls.Add(Me.label29)
        Me.pnlNewDocument.Controls.Add(Me.linkLabel17)
        Me.pnlNewDocument.Controls.Add(Me.linkLabel18)
        Me.pnlNewDocument.Controls.Add(Me.linkLabel19)
        Me.pnlNewDocument.Location = New System.Drawing.Point(0, 0)
        Me.cardLayout1.SetMinimumSize(Me.pnlNewDocument, New System.Drawing.Size(200, 272))
        Me.pnlNewDocument.Name = "pnlNewDocument"
        Me.cardLayout1.SetPreferredSize(Me.pnlNewDocument, New System.Drawing.Size(200, 272))
        Me.pnlNewDocument.Size = New System.Drawing.Size(220, 507)
        Me.pnlNewDocument.TabIndex = 32
        Me.pnlNewDocument.Tag = "New Document"
        '
        'ButtonAdv1
        '
        Me.ButtonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.ButtonAdv1.Location = New System.Drawing.Point(170, 208)
        Me.ButtonAdv1.Name = "ButtonAdv1"
        Me.ButtonAdv1.Size = New System.Drawing.Size(34, 23)
        Me.ButtonAdv1.TabIndex = 21
        Me.ButtonAdv1.Text = "Go"
        Me.ButtonAdv1.UseVisualStyle = True
        '
        'label38
        '
        Me.label38.ImageIndex = 22
        Me.label38.ImageList = Me.imageList1
        Me.label38.Location = New System.Drawing.Point(8, 304)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(20, 24)
        Me.label38.TabIndex = 79
        '
        'label30
        '
        Me.label30.Image = CType(resources.GetObject("label30.Image"), System.Drawing.Image)
        Me.label30.Location = New System.Drawing.Point(8, 96)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(20, 16)
        Me.label30.TabIndex = 78
        '
        'label31
        '
        Me.label31.Image = CType(resources.GetObject("label31.Image"), System.Drawing.Image)
        Me.label31.Location = New System.Drawing.Point(8, 72)
        Me.label31.Name = "label31"
        Me.label31.Size = New System.Drawing.Size(20, 16)
        Me.label31.TabIndex = 77
        '
        'label32
        '
        Me.label32.Image = CType(resources.GetObject("label32.Image"), System.Drawing.Image)
        Me.label32.Location = New System.Drawing.Point(8, 48)
        Me.label32.Name = "label32"
        Me.label32.Size = New System.Drawing.Size(20, 16)
        Me.label32.TabIndex = 76
        '
        'label36
        '
        Me.label36.BackColor = System.Drawing.Color.Transparent
        Me.label36.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label36.Location = New System.Drawing.Point(8, 272)
        Me.label36.Name = "label36"
        Me.label36.Size = New System.Drawing.Size(144, 16)
        Me.label36.TabIndex = 75
        Me.label36.Text = "Recently used templates"
        '
        'label37
        '
        Me.label37.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label37.ForeColor = System.Drawing.Color.Transparent
        Me.label37.Location = New System.Drawing.Point(8, 288)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(235, 2)
        Me.label37.TabIndex = 74
        '
        'linkLabel20
        '
        Me.linkLabel20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel20.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel20.Location = New System.Drawing.Point(32, 312)
        Me.linkLabel20.Name = "linkLabel20"
        Me.linkLabel20.Size = New System.Drawing.Size(72, 16)
        Me.linkLabel20.TabIndex = 72
        Me.linkLabel20.TabStop = True
        Me.linkLabel20.Text = "Letter format"
        '
        'label33
        '
        Me.label33.BackColor = System.Drawing.Color.Transparent
        Me.label33.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label33.Location = New System.Drawing.Point(8, 160)
        Me.label33.Name = "label33"
        Me.label33.Size = New System.Drawing.Size(64, 16)
        Me.label33.TabIndex = 71
        Me.label33.Text = "Templates"
        '
        'label34
        '
        Me.label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label34.Location = New System.Drawing.Point(8, 184)
        Me.label34.Name = "label34"
        Me.label34.Size = New System.Drawing.Size(96, 16)
        Me.label34.TabIndex = 70
        Me.label34.Text = "Search online for:"
        '
        'textBox4
        '
        Me.textBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBox4.Location = New System.Drawing.Point(8, 208)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(155, 21)
        Me.textBox4.TabIndex = 68
        '
        'label35
        '
        Me.label35.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label35.ForeColor = System.Drawing.Color.Transparent
        Me.label35.Location = New System.Drawing.Point(8, 176)
        Me.label35.Name = "label35"
        Me.label35.Size = New System.Drawing.Size(235, 2)
        Me.label35.TabIndex = 67
        '
        'label28
        '
        Me.label28.BackColor = System.Drawing.Color.Transparent
        Me.label28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.label28.Location = New System.Drawing.Point(8, 16)
        Me.label28.Name = "label28"
        Me.label28.Size = New System.Drawing.Size(136, 16)
        Me.label28.TabIndex = 66
        Me.label28.Text = "New"
        '
        'label29
        '
        Me.label29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label29.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.label29.ForeColor = System.Drawing.Color.Transparent
        Me.label29.Location = New System.Drawing.Point(8, 32)
        Me.label29.Name = "label29"
        Me.label29.Size = New System.Drawing.Size(235, 2)
        Me.label29.TabIndex = 65
        '
        'linkLabel17
        '
        Me.linkLabel17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel17.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel17.Location = New System.Drawing.Point(32, 96)
        Me.linkLabel17.Name = "linkLabel17"
        Me.linkLabel17.Size = New System.Drawing.Size(128, 16)
        Me.linkLabel17.TabIndex = 61
        Me.linkLabel17.TabStop = True
        Me.linkLabel17.Text = "From existing document"
        Me.linkLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linkLabel18
        '
        Me.linkLabel18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel18.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel18.Location = New System.Drawing.Point(32, 72)
        Me.linkLabel18.Name = "linkLabel18"
        Me.linkLabel18.Size = New System.Drawing.Size(120, 16)
        Me.linkLabel18.TabIndex = 60
        Me.linkLabel18.TabStop = True
        Me.linkLabel18.Text = "Choose document type"
        Me.linkLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'linkLabel19
        '
        Me.linkLabel19.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLabel19.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.linkLabel19.Location = New System.Drawing.Point(32, 48)
        Me.linkLabel19.Name = "linkLabel19"
        Me.linkLabel19.Size = New System.Drawing.Size(96, 16)
        Me.linkLabel19.TabIndex = 59
        Me.linkLabel19.TabStop = True
        Me.linkLabel19.Text = "Empty document"
        '
        'pnlSearchOptions
        '
        Me.pnlSearchOptions.BorderColor = System.Drawing.Color.Black
        Me.pnlSearchOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cardLayout1.SetCardName(Me.pnlSearchOptions, "SearchOptions")
        Me.pnlSearchOptions.Controls.Add(Me.xpTaskBar1)
        Me.pnlSearchOptions.Location = New System.Drawing.Point(0, 0)
        Me.cardLayout1.SetMinimumSize(Me.pnlSearchOptions, New System.Drawing.Size(192, 232))
        Me.pnlSearchOptions.Name = "pnlSearchOptions"
        Me.cardLayout1.SetPreferredSize(Me.pnlSearchOptions, New System.Drawing.Size(192, 232))
        Me.pnlSearchOptions.Size = New System.Drawing.Size(220, 507)
        Me.pnlSearchOptions.TabIndex = 31
        Me.pnlSearchOptions.Tag = "Search Options"
        '
        'xpTaskBar1
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
        Me.xpTaskBar1.Padding = New System.Windows.Forms.Padding(10, 10, 10, 0)
        Me.xpTaskBar1.Size = New System.Drawing.Size(218, 505)
        Me.xpTaskBar1.TabIndex = 10
        '
        'xpTaskBarBox1
        '
        Me.xpTaskBarBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.LightSteelBlue
        Me.xpTaskBarBox1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.xpTaskBarBox1.HeaderImageIndex = 0
        Me.xpTaskBarBox1.HitTaskBoxArea = False
        Me.xpTaskBarBox1.ImageList = Me.imageList1
        Me.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.AliceBlue
        Me.xpTaskBarBox1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results based on order", System.Drawing.SystemColors.ActiveCaption, 22, 0, "about items", True, True, "", New System.Drawing.Font("Tahoma", 8.25!), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results based on date", System.Drawing.Color.Empty, 23, 0, "about drawing", True, True, "", New System.Drawing.Font("Tahoma", 8.25!), 0)})
        Me.xpTaskBarBox1.Location = New System.Drawing.Point(10, 10)
        Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
        Me.xpTaskBarBox1.Size = New System.Drawing.Size(198, 101)
        Me.xpTaskBarBox1.TabIndex = 0
        Me.xpTaskBarBox1.Text = "Search Options"
        '
        'xpTaskBarBox2
        '
        Me.xpTaskBarBox2.Controls.Add(Me.GradientPanel1)
        Me.xpTaskBarBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.SlateGray
        Me.xpTaskBarBox2.HeaderForeColor = System.Drawing.Color.White
        Me.xpTaskBarBox2.HeaderImageIndex = 1
        Me.xpTaskBarBox2.HitTaskBoxArea = False
        Me.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.AliceBlue
        Me.xpTaskBarBox2.Location = New System.Drawing.Point(10, 111)
        Me.xpTaskBarBox2.Name = "xpTaskBarBox2"
        Me.xpTaskBarBox2.PreferredChildPanelHeight = 110
        Me.xpTaskBarBox2.Size = New System.Drawing.Size(198, 156)
        Me.xpTaskBarBox2.TabIndex = 1
        Me.xpTaskBarBox2.Text = "Search"
        '
        'GradientPanel1
        '
        Me.GradientPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(252, Byte), Integer)), System.Drawing.Color.AliceBlue)
        Me.GradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.GradientPanel1.BorderColor = System.Drawing.Color.Black
        Me.GradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
        Me.GradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GradientPanel1.Controls.Add(Me.ComboBoxAdv2)
        Me.GradientPanel1.Controls.Add(Me.label26)
        Me.GradientPanel1.Controls.Add(Me.ButtonAdv2)
        Me.GradientPanel1.Controls.Add(Me.textBox2)
        Me.GradientPanel1.Controls.Add(Me.label27)
        Me.GradientPanel1.Location = New System.Drawing.Point(2, 44)
        Me.GradientPanel1.Name = "GradientPanel1"
        Me.GradientPanel1.Size = New System.Drawing.Size(194, 110)
        Me.GradientPanel1.TabIndex = 0
        '
        'ComboBoxAdv2
        '
        Me.ComboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ComboBoxAdv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxAdv2.IgnoreThemeBackground = True
        Me.ComboBoxAdv2.Location = New System.Drawing.Point(63, 40)
        Me.ComboBoxAdv2.Name = "ComboBoxAdv2"
        Me.ComboBoxAdv2.Size = New System.Drawing.Size(121, 22)
        Me.ComboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.ComboBoxAdv2.SuppressDropDownEvent = False
        Me.ComboBoxAdv2.TabIndex = 22
        '
        'label26
        '
        Me.label26.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label26.Location = New System.Drawing.Point(0, 40)
        Me.label26.Name = "label26"
        Me.label26.Size = New System.Drawing.Size(64, 16)
        Me.label26.TabIndex = 2
        Me.label26.Text = "Category:"
        '
        'ButtonAdv2
        '
        Me.ButtonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.ButtonAdv2.Location = New System.Drawing.Point(64, 77)
        Me.ButtonAdv2.Name = "ButtonAdv2"
        Me.ButtonAdv2.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdv2.TabIndex = 21
        Me.ButtonAdv2.Text = "Search"
        Me.ButtonAdv2.UseVisualStyle = True
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(64, 8)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(120, 21)
        Me.textBox2.TabIndex = 1
        '
        'label27
        '
        Me.label27.ForeColor = System.Drawing.Color.MidnightBlue
        Me.label27.Location = New System.Drawing.Point(0, 8)
        Me.label27.Name = "label27"
        Me.label27.Size = New System.Drawing.Size(64, 16)
        Me.label27.TabIndex = 0
        Me.label27.Text = "Keywords:"
        '
        'LargeimageList
        '
        Me.LargeimageList.ImageStream = CType(resources.GetObject("LargeimageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.LargeimageList.TransparentColor = System.Drawing.Color.Transparent
        Me.LargeimageList.Images.SetKeyName(0, "")
        Me.LargeimageList.Images.SetKeyName(1, "")
        '
        'popupMenu1
        '
        Me.popupMenu1.ParentBarItem = Me.parentBarItem12
        '
        'parentBarItem12
        '
        Me.parentBarItem12.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biGettingStarted, Me.biNewDocument, Me.biSearchOptions, Me.barItem6, Me.barItem18, Me.barItem21})
        Me.parentBarItem12.SeparatorIndices.AddRange(New Integer() {3})
        Me.parentBarItem12.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        '
        'biGettingStarted
        '
        Me.biGettingStarted.ID = "GettingStarted"
        Me.biGettingStarted.ImageIndex = 25
        Me.biGettingStarted.ImageList = Me.imageList1
        Me.biGettingStarted.Text = "Getting Started"
        '
        'biNewDocument
        '
        Me.biNewDocument.ID = "New Document"
        Me.biNewDocument.ImageIndex = 22
        Me.biNewDocument.ImageList = Me.imageList1
        Me.biNewDocument.Text = "New Document"
        '
        'biSearchOptions
        '
        Me.biSearchOptions.ID = "Search Options"
        Me.biSearchOptions.ImageIndex = 26
        Me.biSearchOptions.ImageList = Me.imageList1
        Me.biSearchOptions.Text = "Search Options"
        '
        'barItem6
        '
        Me.barItem6.ID = "New Document"
        Me.barItem6.ImageIndex = 2
        Me.barItem6.ImageList = Me.imageList1
        Me.barItem6.Text = "Save Document"
        '
        'barItem18
        '
        Me.barItem18.ID = "Review"
        Me.barItem18.ImageList = Me.imageList1
        Me.barItem18.Text = "Review"
        '
        'barItem21
        '
        Me.barItem21.ID = "Updates"
        Me.barItem21.ImageList = Me.imageList1
        Me.barItem21.Text = "Updates"
        '
        'controlBar2
        '
        Me.controlBar2.CaptionControl = Me.comboBoxAdv1
        Me.controlBar2.ChevronColor = System.Drawing.SystemColors.ControlText
        Me.controlBar2.ControlBarCaptionHeight = 25
        Me.controlBar2.Controls.Add(Me.listView1)
        Me.controlBar2.Controls.Add(Me.comboBoxAdv1)
        Me.controlBar2.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.controlBar2.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right
        Me.controlBar2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.controlBar2.HideDropDownButton = True
        Me.controlBar2.MaxLength = 200
        Me.controlBar2.MinHeight = 197
        Me.controlBar2.MinLength = 50
        Me.controlBar2.Name = "controlBar2"
        Me.controlBar2.RowIndex = 0
        Me.controlBar2.TabIndex = 1
        Me.controlBar2.TabStop = False
        Me.controlBar2.Text = "Document Properties"
        '
        'comboBoxAdv1
        '
        Me.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.comboBoxAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
        Me.comboBoxAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxAdv1.IgnoreThemeBackground = True
        Me.comboBoxAdv1.Items.AddRange(New Object() {"Node Types", "Top-level Caption Nodes", "Sub Caption Nodes", "Selected Nodes", "Underlined Nodes", "Highlighted Nodes", "Italicized Nodes", ""})
        Me.comboBoxAdv1.Location = New System.Drawing.Point(2, 27)
        Me.comboBoxAdv1.Name = "comboBoxAdv1"
        Me.comboBoxAdv1.Size = New System.Drawing.Size(192, 21)
        Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        Me.comboBoxAdv1.SuppressDropDownEvent = False
        Me.comboBoxAdv1.TabIndex = 29
        Me.comboBoxAdv1.Text = "Overview"
        '
        'listView1
        '
        Me.listView1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.listView1.Location = New System.Drawing.Point(2, 46)
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(193, 517)
        Me.listView1.SmallImageList = Me.imageList1
        Me.listView1.TabIndex = 10
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.List
        '
        'parentBarItem3
        '
        Me.parentBarItem3.CategoryIndex = 3
        Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem3.ID = "Submenu"
        Me.parentBarItem3.Text = "Submenu"
        '
        'comboBoxBarItem1
        '
        Me.comboBoxBarItem1.AutoAppend = True
        Me.comboBoxBarItem1.CategoryIndex = 1
        Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxBarItem1.ID = "Editable"
        Me.comboBoxBarItem1.MinWidth = 100
        Me.comboBoxBarItem1.Text = "Editable"
        Me.comboBoxBarItem1.Tooltip = "Provides Editable and AutoAppend functionality for Find features."
        '
        'comboBoxBarItem2
        '
        Me.comboBoxBarItem2.CategoryIndex = 1
        Me.comboBoxBarItem2.ChoiceList.AddRange(New String() {"Release", "Debug"})
        Me.comboBoxBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxBarItem2.Editable = False
        Me.comboBoxBarItem2.ID = "ChoiceList"
        Me.comboBoxBarItem2.MinWidth = 70
        Me.comboBoxBarItem2.Text = "ChoiceList"
        '
        'fontColorBarItem
        '
        Me.fontColorBarItem.CategoryIndex = 1
        Me.fontColorBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontColorBarItem.ID = "Font DropDown"
        Me.fontColorBarItem.ImageIndex = 8
        Me.fontColorBarItem.Text = "Font DropDown"
        '
        'barItem8
        '
        Me.barItem8.ID = "Item1"
        Me.barItem8.ImageIndex = 12
        Me.barItem8.Text = "Item1"
        '
        'dropDownBarItem3
        '
        Me.dropDownBarItem3.ImageIndex = 15
        '
        'barItem9
        '
        Me.barItem9.ID = "Item2"
        Me.barItem9.ImageIndex = 13
        Me.barItem9.Text = "Item2"
        '
        'parentBarItem8
        '
        Me.parentBarItem8.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem11, Me.barItem12, Me.barItem13, Me.parentBarItem9, Me.comboBoxBarItem3})
        Me.parentBarItem8.SeparatorIndices.AddRange(New Integer() {3})
        '
        'parentBarItem9
        '
        Me.parentBarItem9.ID = "SubMenu"
        Me.parentBarItem9.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem14, Me.barItem15})
        Me.parentBarItem9.Text = "SubMenu"
        '
        'barItem14
        '
        Me.barItem14.ID = "SubItem1"
        Me.barItem14.Text = "SubItem1"
        '
        'barItem15
        '
        Me.barItem15.ID = "SubItem2"
        Me.barItem15.Text = "SubItem2"
        '
        'comboBoxBarItem3
        '
        Me.comboBoxBarItem3.AutoAppend = True
        Me.comboBoxBarItem3.ID = "Combo:"
        Me.comboBoxBarItem3.MinWidth = 70
        Me.comboBoxBarItem3.Text = "Combo:"
        '
        'statusBar1
        '
        Me.statusBar1.Location = New System.Drawing.Point(0, 616)
        Me.statusBar1.Name = "statusBar1"
        Me.statusBar1.Size = New System.Drawing.Size(888, 22)
        Me.statusBar1.TabIndex = 19
        Me.statusBar1.Text = "statusBar1"
        '
        'cardLayout1
        '
        Me.cardLayout1.ContainerControl = Me.taskPanel
        Me.cardLayout1.LayoutMode = Syncfusion.Windows.Forms.Tools.CardLayoutMode.Fill
        Me.cardLayout1.SelectedCard = "SearchOptions"
        '
        'biTaskPrevious
        '
        Me.biTaskPrevious.ImageIndex = 37
        Me.biTaskPrevious.ImageList = Me.imageList1
        '
        'biTaskNext
        '
        Me.biTaskNext.ImageIndex = 38
        Me.biTaskNext.ImageList = Me.imageList1
        '
        'biTaskHome
        '
        Me.biTaskHome.ImageIndex = 39
        Me.biTaskHome.ImageList = Me.imageList1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(888, 638)
        Me.Controls.Add(Me.statusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Control Bars"
        CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.controlBar1.ResumeLayout(False)
        Me.taskPanel.ResumeLayout(False)
        CType(Me.pnlGettingStarted, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGettingStarted.ResumeLayout(False)
        CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gradientPanel2.ResumeLayout(False)
        Me.gradientPanel2.PerformLayout()
        CType(Me.comboBoxAdv4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlNewDocument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNewDocument.ResumeLayout(False)
        Me.pnlNewDocument.PerformLayout()
        CType(Me.pnlSearchOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearchOptions.ResumeLayout(False)
        CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xpTaskBar1.ResumeLayout(False)
        Me.xpTaskBarBox2.ResumeLayout(False)
        CType(Me.GradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GradientPanel1.ResumeLayout(False)
        Me.GradientPanel1.PerformLayout()
        CType(Me.ComboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.controlBar2.ResumeLayout(False)
        CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cardLayout1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main


    Protected Overrides Sub OnSystemColorsChanged(ByVal e As EventArgs)
        MyBase.OnSystemColorsChanged(e)
    End Sub 'OnSystemColorsChanged


    ' Display the About dialog
    Private Sub barItem19_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem19.Click
        Dim aboutForm1 As New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
        aboutForm1.ShowDialog()
    End Sub 'barItem19_Click


    ' Create a new MDI child form
    Private Sub barItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem1.Click
        Dim txtform As New TextForm()
        txtform.TopLevel = False
        txtform.MdiParent = Me
        nLetterCount += 1
        txtform.Show()
        txtform.Text = String.Concat("Letter ", nLetterCount.ToString())
        'ToDo: Unsupported operator
        'ToDo: ++ operator not supported within expressions
    End Sub 'barItem1_Click


    ' Create a new MDI child form
    Private Sub barItem16_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem16.Click
        Dim txtform As New TextForm()
        txtform.TopLevel = False
        txtform.MdiParent = Me
        nReportCount += 1
        txtform.Show()
        txtform.Text = String.Concat("Report ", (Me.nReportCount).ToString())
        'ToDo: Unsupported operator
        'ToDo: ++ operator not supported within expressions
    End Sub 'barItem16_Click


    ' Create a new MDI child form
    Private Sub barItem17_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem17.Click
        Dim txtform As New TextForm()
        txtform.TopLevel = False
        txtform.MdiParent = Me
        nInvoiceCount += 1
        txtform.Show()
        txtform.Text = String.Concat("Invoice ", (Me.nInvoiceCount).ToString())
        'ToDo: Unsupported operator
        'ToDo: ++ operator not supported within expressions
    End Sub 'barItem17_Click



    ' Update the 'View' PopupMenu UI state
    Private Sub parentBarItem5_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles parentBarItem5.Popup
        Me.barItem4.Checked = Me.controlBar1.Visible
        Me.barItem5.Checked = Me.controlBar2.Visible
    End Sub 'parentBarItem5_Popup


    ' Show/hide the TaskPane ControlBar
    Private Sub barItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem4.Click
        Me.controlBar1.Visible = Not Me.controlBar1.Visible
    End Sub 'barItem4_Click


    ' Show/hide the DocumentProperties ControlBar
    Private Sub barItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem5.Click
        Me.controlBar2.Visible = Not Me.controlBar2.Visible
    End Sub 'barItem5_Click


    ' ControlBar1 - TaskPane - switching logic implemented using the Card LayoutManager
    Private Sub biTaskNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biTaskNext.Click
        Me.cardLayout1.Next()
        Me.controlBar1.Text = Me.cardLayout1.GetComponentFromName(Me.cardLayout1.SelectedCard).Tag '
    End Sub 'biTaskNext_Click
    'if(this.cardLayout1.NextCardIndex)

    Private Sub biTaskPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biTaskPrevious.Click
        Me.cardLayout1.Previous()
        Me.controlBar1.Text = Me.cardLayout1.GetComponentFromName(Me.cardLayout1.SelectedCard).Tag '
    End Sub 'biTaskPrevious_Click
    'if(this.cardLayout1.PreviousCardIndex)

    Private Sub biTaskHome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biTaskHome.Click
        Me.cardLayout1.First()
        Me.controlBar1.Text = Me.cardLayout1.GetComponentFromName(Me.cardLayout1.SelectedCard).Tag '
    End Sub 'biTaskHome_Click


    ' The ControlBar1 PopupMenu - Update the taskpane visibility state
    Private Sub parentBarItem12_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles parentBarItem12.Popup
        Dim selectedcard As String = Me.cardLayout1.GetComponentFromName(Me.cardLayout1.SelectedCard).Tag '
        Me.biGettingStarted.Checked = selectedcard = Me.pnlGettingStarted.Tag '
        Me.biNewDocument.Checked = selectedcard = Me.pnlNewDocument.Tag '
        Me.biSearchOptions.Checked = selectedcard = Me.pnlSearchOptions.Tag '
    End Sub 'parentBarItem12_Popup


    ' Set the Tasks ControlBar's selected card depending on the ControlBar PopupMenu item selection
    Private Sub biGettingStarted_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biGettingStarted.Click
        Me.cardLayout1.Show("GettingStarted")
        Me.controlBar1.Text = "Getting Started"
    End Sub 'biGettingStarted_Click


    Private Sub biNewDocument_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biNewDocument.Click
        Me.cardLayout1.Show("NewDocument")
        Me.controlBar1.Text = "New Document"
    End Sub 'biNewDocument_Click


    Private Sub biSearchOptions_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biSearchOptions.Click
        Me.cardLayout1.Show("SearchOptions")
        Me.controlBar1.Text = "Search Options"
    End Sub 'biSearchOptions_Click


    Private Sub barItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barItem7.Click
        Application.Exit()
    End Sub
End Class 'Form1 


