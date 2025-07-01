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
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Syncfusion.Windows.Forms
Namespace XPMenusSDI
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		#Region "Members"
		Private baseImage As Image
		Private WithEvents mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
		Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private bar3 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private WithEvents parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private largeImageList1 As System.Windows.Forms.ImageList
		Private WithEvents comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private WithEvents comboBoxBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private WithEvents parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents parentBarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents toolbarListBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem
		Private WithEvents parentBarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents listBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
		Private WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private bar4 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private splitter1 As System.Windows.Forms.Splitter
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private xpToolBar1 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private WithEvents barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents parentBarItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents dropDownBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
		Private WithEvents barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label1 As GradientLabel
		Private popupMenu1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private popupMenu2 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private WithEvents parentBarItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents parentBarItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents comboBoxBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Private popupMenusManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager
		Private WithEvents parentBarItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem17 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem18 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
		Private WithEvents colorUIControl1 As Syncfusion.Windows.Forms.ColorUIControl
		Private WithEvents fontColorBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
		Private WithEvents parentBarItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem19 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private panel3 As System.Windows.Forms.Panel
		Private splitter2 As System.Windows.Forms.Splitter
		Private barItem20 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private bar5 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private WithEvents staticBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
        Private superToolTip1 As SuperToolTip
        Friend WithEvents CheckBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private components As System.ComponentModel.IContainer
#End Region

#Region "Form Constructor"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            ' It's recommended that you keep the PopupControlContainer unparented by
            ' any Control on the Form (which will be the default case as set up during design-time).
            ' Otherwise, the Form wouldn't close sometimes, after dropping down this popup!
            Me.popupControlContainer1.Parent.Controls.Remove(Me.popupControlContainer1)
            Me.richTextBox1.Text = "Right-Click here to bring up context menu." & Constants.vbCrLf
            Me.staticBarItem1.Text = "Ready"
        End Sub
#End Region

#Region "Dispose"
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.components = New System.ComponentModel.Container
            Dim ToolTipInfo8 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo5 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo6 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo7 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo4 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo1 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo2 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo3 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo9 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo13 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo10 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo11 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo12 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo14 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
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
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.toolbarListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem
            Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.comboBoxBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.fontColorBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer
            Me.colorUIControl1 = New Syncfusion.Windows.Forms.ColorUIControl
            Me.parentBarItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "File")
            Me.bar3 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Format")
            Me.bar4 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Edit")
            Me.bar5 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "StatusBar")
            Me.staticBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.largeImageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.splitter2 = New System.Windows.Forms.Splitter
            Me.panel3 = New System.Windows.Forms.Panel
            Me.label1 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.splitter1 = New System.Windows.Forms.Splitter
            Me.panel2 = New System.Windows.Forms.Panel
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.xpToolBar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.dropDownBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.popupMenu1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
            Me.popupMenu2 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
            Me.parentBarItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.comboBoxBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.popupMenusManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(Me.components)
            Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.superToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
            Me.CheckBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.comboBoxBarItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.bar1)
            Me.mainFrameBarManager1.Bars.Add(Me.bar2)
            Me.mainFrameBarManager1.Bars.Add(Me.bar3)
            Me.mainFrameBarManager1.Bars.Add(Me.bar4)
            Me.mainFrameBarManager1.Bars.Add(Me.bar5)
            Me.mainFrameBarManager1.Categories.Add("File")
            Me.mainFrameBarManager1.Categories.Add("Edit")
            Me.mainFrameBarManager1.Categories.Add("Format")
            Me.mainFrameBarManager1.Categories.Add("View")
            Me.mainFrameBarManager1.Categories.Add("Help")
            Me.mainFrameBarManager1.Categories.Add("StatusBar")
            Me.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form"
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.ImageList = Me.imageList1
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem4, Me.parentBarItem10, Me.barItem2, Me.comboBoxBarItem1, Me.barItem3, Me.parentBarItem6, Me.comboBoxBarItem2, Me.listBarItem1, Me.barItem7, Me.fontColorBarItem, Me.barItem1, Me.parentBarItem2, Me.barItem16, Me.barItem17, Me.barItem4, Me.barItem5, Me.barItem6, Me.parentBarItem5, Me.toolbarListBarItem1, Me.barItem18, Me.parentBarItem11, Me.barItem19, Me.staticBarItem1})
            Me.mainFrameBarManager1.LargeImageList = Me.largeImageList1
            Me.mainFrameBarManager1.ResetCustomization = False
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.mainFrameBarManager1.ThemesEnabled = True
            '
            'bar1
            '
            Me.bar1.BarName = "MainMenu"
            Me.bar1.BarStyle = CType(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "MainMenu"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem2, Me.parentBarItem5, Me.parentBarItem4, Me.parentBarItem11})
            Me.bar1.Manager = Me.mainFrameBarManager1
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 0
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "&File"
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem10, Me.barItem2, Me.barItem3, Me.parentBarItem6, Me.barItem7})
            Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() {3, 4})
            Me.parentBarItem1.ShowTooltip = False
            Me.parentBarItem1.Text = "&File"
            ToolTipInfo8.Body.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
            ToolTipInfo8.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo8.Body.Text = "Click here to open, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "save, view recent " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "files and close."
            ToolTipInfo8.Body.TextMargin = New System.Windows.Forms.Padding(6)
            ToolTipInfo8.Footer.Hidden = True
            ToolTipInfo8.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo8.Header.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo8.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo8.Header.Text = "File Item"
            ToolTipInfo8.Header.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo8.Separator = False
            Me.superToolTip1.SetToolTip(Me.parentBarItem1, ToolTipInfo8)
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
            Me.parentBarItem10.ShowTooltip = False
            Me.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem10.Text = "&New"
            ToolTipInfo5.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(223, Byte), Integer))
            ToolTipInfo5.Body.Hidden = True
            ToolTipInfo5.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo5.Footer.Hidden = True
            ToolTipInfo5.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo5.Header.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            ToolTipInfo5.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo5.Header.Text = "New"
            ToolTipInfo5.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo5.Separator = False
            Me.superToolTip1.SetToolTip(Me.parentBarItem10, ToolTipInfo5)
            '
            'barItem1
            '
            Me.barItem1.CategoryIndex = 0
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem1.ID = "New1"
            Me.barItem1.Text = "New1"
            '
            'barItem16
            '
            Me.barItem16.CategoryIndex = 0
            Me.barItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem16.ID = "New2"
            Me.barItem16.Text = "New2"
            '
            'barItem17
            '
            Me.barItem17.CategoryIndex = 0
            Me.barItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem17.ID = "New3"
            Me.barItem17.Text = "New3"
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 0
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "&Open"
            Me.barItem2.ImageIndex = 1
            Me.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.barItem2.ShowTooltip = False
            Me.barItem2.Text = "&Open"
            ToolTipInfo6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(114, Byte), Integer))
            ToolTipInfo6.Body.Hidden = True
            ToolTipInfo6.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo6.Footer.Hidden = True
            ToolTipInfo6.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo6.Header.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
            ToolTipInfo6.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo6.Header.Text = "Open"
            ToolTipInfo6.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo6.Separator = False
            Me.superToolTip1.SetToolTip(Me.barItem2, ToolTipInfo6)
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 0
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "&Save"
            Me.barItem3.ImageIndex = 2
            Me.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.barItem3.ShowTooltip = False
            Me.barItem3.Text = "&Save"
            ToolTipInfo7.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(124, Byte), Integer))
            ToolTipInfo7.Body.Hidden = True
            ToolTipInfo7.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo7.Footer.Hidden = True
            ToolTipInfo7.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo7.Header.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
            ToolTipInfo7.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo7.Header.Text = "Save"
            ToolTipInfo7.Separator = False
            Me.superToolTip1.SetToolTip(Me.barItem3, ToolTipInfo7)
            '
            'parentBarItem6
            '
            Me.parentBarItem6.CategoryIndex = 0
            Me.parentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem6.ID = "Recent Views (Expanding List)"
            Me.parentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.listBarItem1})
            Me.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
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
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 1
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "&Edit"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem4, Me.barItem5, Me.barItem6, Me.barItem18})
            Me.parentBarItem2.SeparatorIndices.AddRange(New Integer() {3})
            Me.parentBarItem2.ShowTooltip = False
            Me.parentBarItem2.Text = "&Edit"
            ToolTipInfo4.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(213, Byte), Integer))
            ToolTipInfo4.Body.Hidden = True
            ToolTipInfo4.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo4.Footer.Hidden = True
            ToolTipInfo4.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo4.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo4.Header.Text = "Edit"
            ToolTipInfo4.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo4.Separator = False
            Me.superToolTip1.SetToolTip(Me.parentBarItem2, ToolTipInfo4)
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 1
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "Cu&t"
            Me.barItem4.ImageIndex = 3
            Me.barItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlX
            Me.barItem4.ShowTooltip = False
            Me.barItem4.Text = "Cu&t"
            ToolTipInfo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
            ToolTipInfo1.Body.Hidden = True
            ToolTipInfo1.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo1.Footer.Hidden = True
            ToolTipInfo1.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo1.Header.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            ToolTipInfo1.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo1.Header.Text = "Cut"
            ToolTipInfo1.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo1.Separator = False
            Me.superToolTip1.SetToolTip(Me.barItem4, ToolTipInfo1)
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 1
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "&Copy"
            Me.barItem5.ImageIndex = 4
            Me.barItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlC
            Me.barItem5.ShowTooltip = False
            Me.barItem5.Text = "&Copy"
            ToolTipInfo2.BackColor = System.Drawing.Color.LightCoral
            ToolTipInfo2.Body.Hidden = True
            ToolTipInfo2.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo2.Footer.Hidden = True
            ToolTipInfo2.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo2.Header.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            ToolTipInfo2.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo2.Header.Text = "Copy"
            ToolTipInfo2.Separator = False
            Me.superToolTip1.SetToolTip(Me.barItem5, ToolTipInfo2)
            '
            'barItem6
            '
            Me.barItem6.CategoryIndex = 1
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem6.ID = "&Paste"
            Me.barItem6.ImageIndex = 5
            Me.barItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlV
            Me.barItem6.ShowTooltip = False
            Me.barItem6.Text = "&Paste"
            ToolTipInfo3.BackColor = System.Drawing.Color.PaleTurquoise
            ToolTipInfo3.Body.Hidden = True
            ToolTipInfo3.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo3.Footer.Hidden = True
            ToolTipInfo3.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo3.Header.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            ToolTipInfo3.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo3.Header.Text = "Paste"
            ToolTipInfo3.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo3.Separator = False
            Me.superToolTip1.SetToolTip(Me.barItem6, ToolTipInfo3)
            '
            'barItem18
            '
            Me.barItem18.CategoryIndex = 1
            Me.barItem18.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem18.ID = "Clear Events"
            Me.barItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlL
            Me.barItem18.Text = "Clear Events"
            '
            'parentBarItem5
            '
            Me.parentBarItem5.CategoryIndex = 3
            Me.parentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem5.ID = "&View"
            Me.parentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.toolbarListBarItem1})
            Me.parentBarItem5.ShowTooltip = False
            Me.parentBarItem5.Text = "&View"
            ToolTipInfo9.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(71, Byte), Integer))
            ToolTipInfo9.Body.Hidden = True
            ToolTipInfo9.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo9.Footer.Hidden = True
            ToolTipInfo9.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo9.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo9.Header.Text = "View"
            ToolTipInfo9.Separator = False
            Me.superToolTip1.SetToolTip(Me.parentBarItem5, ToolTipInfo9)
            '
            'toolbarListBarItem1
            '
            Me.toolbarListBarItem1.CategoryIndex = 3
            Me.toolbarListBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolbarListBarItem1.ID = "Toolbar List"
            Me.toolbarListBarItem1.Text = "Toolbar List"
            '
            'parentBarItem4
            '
            Me.parentBarItem4.CategoryIndex = 2
            Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem4.ID = "Forma&t"
            Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.comboBoxBarItem1, Me.comboBoxBarItem2, Me.fontColorBarItem})
            Me.parentBarItem4.ShowTooltip = False
            Me.parentBarItem4.Text = "Forma&t"
            ToolTipInfo13.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(0, Byte), Integer))
            ToolTipInfo13.Body.Hidden = True
            ToolTipInfo13.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo13.Footer.Hidden = True
            ToolTipInfo13.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo13.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo13.Header.Text = "Format"
            ToolTipInfo13.Separator = False
            Me.superToolTip1.SetToolTip(Me.parentBarItem4, ToolTipInfo13)
            '
            'comboBoxBarItem1
            '
            Me.comboBoxBarItem1.AutoAppend = True
            Me.comboBoxBarItem1.CategoryIndex = 2
            Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxBarItem1.ID = "Editable"
            Me.comboBoxBarItem1.MinWidth = 100
            Me.comboBoxBarItem1.ShowTooltip = False
            Me.comboBoxBarItem1.Text = "Editable"
            Me.comboBoxBarItem1.Tooltip = "Provides Editable and AutoAppend functionality for Find features."
            ToolTipInfo10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            ToolTipInfo10.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo10.Body.Text = "Provides Editable and AutoAppend " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "functionality for Find features."
            ToolTipInfo10.Body.TextMargin = New System.Windows.Forms.Padding(5)
            ToolTipInfo10.Footer.Hidden = True
            ToolTipInfo10.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo10.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo10.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo10.Header.Text = "Editable"
            ToolTipInfo10.Header.TextMargin = New System.Windows.Forms.Padding(5)
            ToolTipInfo10.Separator = False
            Me.superToolTip1.SetToolTip(Me.comboBoxBarItem1, ToolTipInfo10)
            '
            'comboBoxBarItem2
            '
            Me.comboBoxBarItem2.CategoryIndex = 2
            Me.comboBoxBarItem2.ChoiceList.AddRange(New String() {"Release", "Debug"})
            Me.comboBoxBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxBarItem2.Editable = False
            Me.comboBoxBarItem2.ID = "ChoiceList"
            Me.comboBoxBarItem2.MinWidth = 70
            Me.comboBoxBarItem2.ShowTooltip = False
            Me.comboBoxBarItem2.Text = "ChoiceList"
            ToolTipInfo11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
            ToolTipInfo11.Body.Hidden = True
            ToolTipInfo11.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo11.Footer.Hidden = True
            ToolTipInfo11.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo11.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo11.Header.Text = "ChoiceList"
            ToolTipInfo11.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo11.Separator = False
            Me.superToolTip1.SetToolTip(Me.comboBoxBarItem2, ToolTipInfo11)
            '
            'fontColorBarItem
            '
            Me.fontColorBarItem.CategoryIndex = 2
            Me.fontColorBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fontColorBarItem.ID = "Font DropDown"
            Me.fontColorBarItem.ImageIndex = 8
            Me.fontColorBarItem.PopupControlContainer = Me.popupControlContainer1
            Me.fontColorBarItem.ShowTooltip = False
            Me.fontColorBarItem.Text = "Font DropDown"
            ToolTipInfo12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            ToolTipInfo12.Body.Hidden = True
            ToolTipInfo12.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo12.Footer.Hidden = True
            ToolTipInfo12.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo12.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo12.Header.Text = "Font DropDown"
            ToolTipInfo12.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo12.Separator = False
            Me.superToolTip1.SetToolTip(Me.fontColorBarItem, ToolTipInfo12)
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.popupControlContainer1.Controls.Add(Me.colorUIControl1)
            Me.popupControlContainer1.Location = New System.Drawing.Point(464, 48)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Padding = New System.Windows.Forms.Padding(1)
            Me.popupControlContainer1.Size = New System.Drawing.Size(208, 200)
            Me.popupControlContainer1.TabIndex = 6
            Me.popupControlContainer1.Visible = False
            '
            'colorUIControl1
            '
            Me.colorUIControl1.BackColor = System.Drawing.SystemColors.Control
            Me.colorUIControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.colorUIControl1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.colorUIControl1.Location = New System.Drawing.Point(1, 1)
            Me.colorUIControl1.Name = "colorUIControl1"
            Me.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
            Me.colorUIControl1.Size = New System.Drawing.Size(206, 198)
            Me.colorUIControl1.TabIndex = 0
            Me.colorUIControl1.Text = "colorUIControl1"
            '
            'parentBarItem11
            '
            Me.parentBarItem11.CategoryIndex = 4
            Me.parentBarItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem11.ID = "&Help"
            Me.parentBarItem11.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem19})
            Me.parentBarItem11.ShowTooltip = False
            Me.parentBarItem11.Text = "&Help"
            ToolTipInfo14.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(213, Byte), Integer))
            ToolTipInfo14.Body.Hidden = True
            ToolTipInfo14.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo14.Footer.Hidden = True
            ToolTipInfo14.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo14.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo14.Header.Text = "Help"
            ToolTipInfo14.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo14.Separator = False
            Me.superToolTip1.SetToolTip(Me.parentBarItem11, ToolTipInfo14)
            '
            'barItem19
            '
            Me.barItem19.CategoryIndex = 4
            Me.barItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem19.ID = "About Syncfusion"
            Me.barItem19.ImageIndex = 22
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
            'bar3
            '
            Me.bar3.BarName = "Format"
            Me.bar3.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar3.Caption = "Format"
            Me.bar3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.comboBoxBarItem1, Me.fontColorBarItem, Me.comboBoxBarItem2})
            Me.bar3.Manager = Me.mainFrameBarManager1
            Me.bar3.SeparatorIndices.AddRange(New Integer() {1})
            '
            'bar4
            '
            Me.bar4.BarName = "Edit"
            Me.bar4.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar4.Caption = "Edit"
            Me.bar4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem4, Me.barItem5, Me.barItem6})
            Me.bar4.Manager = Me.mainFrameBarManager1
            '
            'bar5
            '
            Me.bar5.BarName = "StatusBar"
            Me.bar5.BarStyle = CType(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsStatusBar), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar5.Caption = "StatusBar"
            Me.bar5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.staticBarItem1})
            Me.bar5.Manager = Me.mainFrameBarManager1
            '
            'staticBarItem1
            '
            Me.staticBarItem1.CategoryIndex = 5
            Me.staticBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.staticBarItem1.FlatBorderColor = System.Drawing.SystemColors.GrayText
            Me.staticBarItem1.ID = "Status1"
            Me.staticBarItem1.Text = "Status1"
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
            '
            'largeImageList1
            '
            Me.largeImageList1.ImageStream = CType(resources.GetObject("largeImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.largeImageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.largeImageList1.Images.SetKeyName(0, "")
            Me.largeImageList1.Images.SetKeyName(1, "")
            Me.largeImageList1.Images.SetKeyName(2, "")
            Me.largeImageList1.Images.SetKeyName(3, "")
            Me.largeImageList1.Images.SetKeyName(4, "")
            Me.largeImageList1.Images.SetKeyName(5, "")
            Me.largeImageList1.Images.SetKeyName(6, "")
            Me.largeImageList1.Images.SetKeyName(7, "")
            Me.largeImageList1.Images.SetKeyName(8, "")
            Me.largeImageList1.Images.SetKeyName(9, "")
            Me.largeImageList1.Images.SetKeyName(10, "")
            Me.largeImageList1.Images.SetKeyName(11, "")
            Me.largeImageList1.Images.SetKeyName(12, "")
            Me.largeImageList1.Images.SetKeyName(13, "")
            Me.largeImageList1.Images.SetKeyName(14, "")
            Me.largeImageList1.Images.SetKeyName(15, "")
            Me.largeImageList1.Images.SetKeyName(16, "")
            Me.largeImageList1.Images.SetKeyName(17, "")
            Me.largeImageList1.Images.SetKeyName(18, "")
            Me.largeImageList1.Images.SetKeyName(19, "")
            Me.largeImageList1.Images.SetKeyName(20, "")
            Me.largeImageList1.Images.SetKeyName(21, "")
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.White
            Me.panel1.Controls.Add(Me.groupBox1)
            Me.panel1.Controls.Add(Me.splitter2)
            Me.panel1.Controls.Add(Me.panel3)
            Me.panel1.Controls.Add(Me.popupControlContainer1)
            Me.panel1.Controls.Add(Me.splitter1)
            Me.panel1.Controls.Add(Me.panel2)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(0, 50)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(664, 347)
            Me.panel1.TabIndex = 4
            '
            'groupBox1
            '
            Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.groupBox1.Controls.Add(Me.richTextBox1)
            Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.groupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(8, 170)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(456, 173)
            Me.groupBox1.TabIndex = 3
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Events"
            '
            'richTextBox1
            '
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.richTextBox1.Location = New System.Drawing.Point(3, 17)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(450, 153)
            Me.richTextBox1.TabIndex = 2
            Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
            Me.popupMenusManager1.SetXPContextMenu(Me.richTextBox1, Me.popupMenu1)
            '
            'splitter2
            '
            Me.splitter2.Dock = System.Windows.Forms.DockStyle.Top
            Me.splitter2.Location = New System.Drawing.Point(0, 134)
            Me.splitter2.Name = "splitter2"
            Me.splitter2.Size = New System.Drawing.Size(469, 3)
            Me.splitter2.TabIndex = 8
            Me.splitter2.TabStop = False
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.label1)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel3.Location = New System.Drawing.Point(0, 0)
            Me.panel3.Name = "panel3"
            Me.panel3.Padding = New System.Windows.Forms.Padding(5)
            Me.panel3.Size = New System.Drawing.Size(469, 134)
            Me.panel3.TabIndex = 7
            '
            'label1
            '
            Me.label1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(241, Byte), Integer)))
            Me.label1.BorderSides = CType(((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom) _
                        Or System.Windows.Forms.Border3DSide.Middle), System.Windows.Forms.Border3DSide)
            Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(5, 5)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(459, 124)
            Me.label1.TabIndex = 4
            Me.label1.Text = resources.GetString("label1.Text")
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.popupMenusManager1.SetXPContextMenu(Me.label1, Me.popupMenu2)
            '
            'splitter1
            '
            Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitter1.Location = New System.Drawing.Point(469, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 347)
            Me.splitter1.TabIndex = 1
            Me.splitter1.TabStop = False
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.propertyGrid1)
            Me.panel2.Controls.Add(Me.xpToolBar1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(472, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
            Me.panel2.Size = New System.Drawing.Size(192, 347)
            Me.panel2.TabIndex = 0
            '
            'propertyGrid1
            '
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.WhiteSmoke
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid1.Location = New System.Drawing.Point(0, 30)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(190, 315)
            Me.propertyGrid1.TabIndex = 0
            Me.propertyGrid1.ToolbarVisible = False
            '
            'xpToolBar1
            '
            Me.xpToolBar1.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.xpToolBar1.Bar.BarName = ""
            Me.xpToolBar1.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem11, Me.parentBarItem7, Me.barItem12, Me.barItem13})
            Me.xpToolBar1.Bar.Manager = Nothing
            Me.xpToolBar1.Bar.SeparatorIndices.AddRange(New Integer() {2})
            Me.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpToolBar1.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.xpToolBar1.Location = New System.Drawing.Point(0, 5)
            Me.xpToolBar1.Name = "xpToolBar1"
            Me.xpToolBar1.SeparatorIndices.AddRange(New Integer() {2, 2, 2, 2, 2})
            Me.xpToolBar1.Size = New System.Drawing.Size(190, 25)
            Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.xpToolBar1.TabIndex = 1
            Me.xpToolBar1.Text = "xpToolBar1"
            Me.xpToolBar1.ThemesEnabled = True
            '
            'barItem11
            '
            Me.barItem11.CustomTextFont = New System.Drawing.Font("Calibri", 9.75!)
            Me.barItem11.ID = "Item1"
            Me.barItem11.ImageIndex = 16
            Me.barItem11.ImageList = Me.imageList1
            Me.barItem11.LargeImageList = Me.largeImageList1
            Me.barItem11.Text = "Item1"
            '
            'parentBarItem7
            '
            Me.parentBarItem7.CustomTextFont = New System.Drawing.Font("Calibri", 9.75!)
            Me.parentBarItem7.ID = "DropDown1"
            Me.parentBarItem7.ImageIndex = 14
            Me.parentBarItem7.ImageList = Me.imageList1
            Me.parentBarItem7.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem10})
            Me.parentBarItem7.LargeImageList = Me.largeImageList1
            Me.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem7.Text = "DropDown1"
            '
            'barItem10
            '
            Me.barItem10.ID = "Button Item1"
            Me.barItem10.Text = "Button Item1"
            '
            'barItem12
            '
            Me.barItem12.CustomTextFont = New System.Drawing.Font("Calibri", 9.75!)
            Me.barItem12.ID = "Item2"
            Me.barItem12.ImageIndex = 17
            Me.barItem12.ImageList = Me.imageList1
            Me.barItem12.LargeImageList = Me.largeImageList1
            Me.barItem12.Text = "Item2"
            '
            'barItem13
            '
            Me.barItem13.CustomTextFont = New System.Drawing.Font("Calibri", 9.75!)
            Me.barItem13.ID = "Item3"
            Me.barItem13.ImageIndex = 18
            Me.barItem13.ImageList = Me.imageList1
            Me.barItem13.LargeImageList = Me.largeImageList1
            Me.barItem13.Text = "Item3"
            '
            'barItem8
            '
            Me.barItem8.ID = "Item1"
            Me.barItem8.ImageIndex = 12
            Me.barItem8.ImageList = Me.imageList1
            Me.barItem8.Text = "Item1"
            '
            'dropDownBarItem3
            '
            Me.dropDownBarItem3.ImageIndex = 15
            Me.dropDownBarItem3.ImageList = Me.imageList1
            Me.dropDownBarItem3.PopupControlContainer = Me.popupControlContainer1
            '
            'barItem9
            '
            Me.barItem9.ID = "Item2"
            Me.barItem9.ImageIndex = 13
            Me.barItem9.ImageList = Me.imageList1
            Me.barItem9.Text = "Item2"
            '
            'popupMenu1
            '
            Me.popupMenu1.ParentBarItem = Me.parentBarItem2
            '
            'popupMenu2
            '
            Me.popupMenu2.ParentBarItem = Me.parentBarItem8
            '
            'parentBarItem8
            '
            Me.parentBarItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem8.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem11, Me.barItem12, Me.barItem13, Me.parentBarItem9, Me.comboBoxBarItem3})
            Me.parentBarItem8.SeparatorIndices.AddRange(New Integer() {3})
            Me.parentBarItem8.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'parentBarItem9
            '
            Me.parentBarItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
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
            Me.comboBoxBarItem3.ChoiceList.AddRange(New String() {"Item 1", "Item 2", "Item 3"})
            Me.comboBoxBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.comboBoxBarItem3.ID = "Combo:"
            Me.comboBoxBarItem3.MinWidth = 70
            Me.comboBoxBarItem3.Text = "Combo:"
            '
            'CheckBoxAdv1
            '
            Me.CheckBoxAdv1.Checked = True
            Me.CheckBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.CheckBoxAdv1.Location = New System.Drawing.Point(487, 23)
            Me.CheckBoxAdv1.Name = "CheckBoxAdv1"
            Me.CheckBoxAdv1.Size = New System.Drawing.Size(150, 21)
            Me.CheckBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
            Me.CheckBoxAdv1.TabIndex = 5
            Me.CheckBoxAdv1.Text = "PersistAutoAppendList"
            Me.CheckBoxAdv1.ThemesEnabled = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.WhiteSmoke
            Me.ClientSize = New System.Drawing.Size(664, 423)
            Me.Controls.Add(Me.CheckBoxAdv1)
            Me.Controls.Add(Me.panel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SDI Demo"
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            CType(Me.comboBoxBarItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Main"
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub
#End Region

#Region "Event Handlers for Tracing"
        Private Sub BarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles parentBarItem10.Click, barItem1.Click, barItem16.Click, barItem17.Click, barItem2.Click, barItem3.Click, barItem4.Click, barItem5.Click, barItem6.Click, comboBoxBarItem1.Click, comboBoxBarItem2.Click, staticBarItem1.Click, barItem11.Click, barItem10.Click, barItem12.Click, barItem13.Click, barItem8.Click, dropDownBarItem3.Click, barItem9.Click, barItem14.Click, barItem15.Click, comboBoxBarItem3.Click
            If TypeOf sender Is BarItem Then
                Dim barItem As BarItem = TryCast(sender, BarItem)
                Me.MyTraceLine(barItem.Text & " Clicked.")
            Else
                Me.MyTraceLine("Unknown Item Clicked.")
            End If
        End Sub

        Private Sub BarItem_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles parentBarItem1.Selected, parentBarItem10.Selected, barItem1.Selected, barItem16.Selected, barItem17.Selected, barItem2.Selected, barItem3.Selected, parentBarItem6.Selected, listBarItem1.Selected, barItem7.Selected, parentBarItem2.Selected, barItem4.Selected, barItem5.Selected, barItem6.Selected, barItem18.Selected, parentBarItem5.Selected, toolbarListBarItem1.Selected, parentBarItem4.Selected, comboBoxBarItem1.Selected, comboBoxBarItem2.Selected, fontColorBarItem.Selected, barItem11.Selected, parentBarItem7.Selected, barItem12.Selected, barItem13.Selected, dropDownBarItem3.Selected, parentBarItem8.Selected, parentBarItem9.Selected, barItem14.Selected, barItem15.Selected, comboBoxBarItem3.Selected, parentBarItem11.Selected
            If TypeOf sender Is BarItem Then
                Dim barItem As BarItem = TryCast(sender, BarItem)
                Me.staticBarItem1.Text = barItem.Text
                Me.MyTraceLine(barItem.Text & " Selected.")
            Else
                Me.MyTraceLine("Unknown Item Selected.")
            End If
        End Sub

        Private Sub Submenu_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles parentBarItem1.Popup, parentBarItem10.Popup, parentBarItem6.Popup, parentBarItem2.Popup, parentBarItem5.Popup, toolbarListBarItem1.Popup, parentBarItem4.Popup, parentBarItem7.Popup, parentBarItem8.Popup, parentBarItem9.Popup, parentBarItem11.Popup
            If TypeOf sender Is ParentBarItem Then
                Dim barItem As ParentBarItem = TryCast(sender, ParentBarItem)
                Me.MyTraceLine(barItem.Text & " Popup.")
            Else
                Me.MyTraceLine("Unknown Item Popup.")
            End If
        End Sub

        Private Sub Sumenu_PopupClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles parentBarItem1.PopupClosed, parentBarItem10.PopupClosed, parentBarItem6.PopupClosed, parentBarItem2.PopupClosed, parentBarItem5.PopupClosed, toolbarListBarItem1.PopupClosed, parentBarItem4.PopupClosed, parentBarItem7.PopupClosed, parentBarItem8.PopupClosed, parentBarItem9.PopupClosed, parentBarItem11.PopupClosed
            If TypeOf sender Is ParentBarItem Then
                Dim barItem As ParentBarItem = TryCast(sender, ParentBarItem)
                Me.MyTraceLine(barItem.Text & " PopupClosed.")
            Else
                Me.MyTraceLine("Unknown Item PopupClosed.")
            End If
        End Sub

        Private Sub Customization_Begin(ByVal sender As Object, ByVal e As System.EventArgs) Handles mainFrameBarManager1.CustomizationBegin
            Me.MyTraceLine("CustomizationBegin occured.")
        End Sub

        Private Sub Customization_Done(ByVal sender As Object, ByVal e As System.EventArgs) Handles mainFrameBarManager1.CustomizationDone
            Me.MyTraceLine("CustomizationDone occured.")
        End Sub
        Private Sub MyTraceLine(ByVal text As String)
            Me.richTextBox1.Text += text & Constants.vbCrLf
            Me.richTextBox1.SelectionStart = 10000
        End Sub
        Private Sub Clear_Events(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem18.Click
            ' Forwarding for tracing
            Me.BarItem_Click(sender, e)

            Me.richTextBox1.Text = String.Empty
        End Sub
#End Region

#Region "ColorUI DropDown"
        Private Sub fontColorBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontColorBarItem.Click
            ' Forward for tracing.
            Me.BarItem_Click(sender, e)

            Me.UpdateRichTextColor()
        End Sub
        Private Sub UpdateRichTextColor()
            ' Set the selection's color to be the ColorUI's Selected Color.
            Me.richTextBox1.SelectAll()
            Me.richTextBox1.SelectionColor = Me.colorUIControl1.SelectedColor
            Me.richTextBox1.SelectionStart = Me.richTextBox1.SelectionLength
        End Sub


        Private Sub colorUIControl1_ColorSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorUIControl1.ColorSelected
            Me.UpdateDropdownImageColor(Me.colorUIControl1.SelectedColor)
            ' Close the popup, now that a Color was selected
            Me.popupControlContainer1.HidePopup(PopupCloseType.Done)

            Me.UpdateRichTextColor()
        End Sub

        Private Sub UpdateDropdownImageColor(ByVal newColor As Color)
            ' Create a new bitmap off the base image.
            Dim newImage As Image = TryCast(Me.baseImage.Clone(), Image)
            Dim newBitmap As Bitmap = New Bitmap(newImage)

            ' Set the Color cue pixels to the appropriate color.
            For i As Integer = 13 To 15
                For j As Integer = 1 To 13
                    newBitmap.SetPixel(j, i, Me.colorUIControl1.SelectedColor)
                Next j
            Next i

            ' Update the image stored in the imagelist to this new image.
            Me.imageList1.Images(Me.fontColorBarItem.ImageIndex) = newBitmap
        End Sub
        Private Sub InitBaseImage()
            ' Store this for use later when the selected color changes in ColorUI control.
            Me.baseImage = TryCast(Me.imageList1.Images(Me.fontColorBarItem.ImageIndex).Clone(), Image)
        End Sub
#End Region

#Region "Sample App Logic"
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' Update the Font Color BarItem image.
            Me.InitBaseImage()
            Me.colorUIControl1.SelectedColor = Color.Black
        End Sub
        Private Sub richTextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richTextBox1.TextChanged
            If Me.richTextBox1.Text.Length > 0 Then
                Me.richTextBox1.SelectionStart = Me.richTextBox1.Text.Length - 1
                Me.richTextBox1.ScrollToCaret()
            End If
        End Sub

        Private Sub barItem7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem7.Click
            Application.Exit()
        End Sub
#End Region


        Private Sub barItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barItem19.Click
            Dim frm As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
            frm.ShowDialog()
        End Sub

        Private Sub CheckBoxAdv1_CheckedChanged(ByVal sender As System.Object, ByVal e As Syncfusion.Windows.Forms.Tools.CheckedChangedEventArgs) Handles CheckBoxAdv1.CheckedChanged
            Me.comboBoxBarItem1.Checked = Me.CheckBoxAdv1.Checked

        End Sub
    End Class
End Namespace
