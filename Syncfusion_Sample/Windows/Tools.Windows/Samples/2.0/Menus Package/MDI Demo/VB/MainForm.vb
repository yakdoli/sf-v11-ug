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

Imports DemoCommon
Imports Microsoft.VisualBasic
Imports Syncfusion.Runtime.Serialization
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Resources
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace XPMenusMDI
    Public Class MainForm
        Inherits Office2007Form
        Private WithEvents popupMenu2 As PopupMenu
        Private WithEvents barManager1 As MainFrameBarManager
        Private WithEvents barItem8 As BarItem
        Private WithEvents barItem9 As BarItem
        Private WithEvents barItem10 As BarItem
        Private WithEvents dropDownBarItem1 As DropDownBarItem
        Private WithEvents barItem11 As BarItem
        Private WithEvents barItem12 As BarItem
        Private WithEvents mdiClient1 As MdiClient
        Private WithEvents popupControlContainer1 As PopupControlContainer
        Private WithEvents listBox1 As ListBox
        Private WithEvents parentBarItem1 As ParentBarItem
        Private WithEvents barItem13 As BarItem
        Private WithEvents barItem14 As BarItem
        Private WithEvents parentBarItem2 As ParentBarItem
        Private WithEvents openBarItem As BarItem
        Private WithEvents openFileDialog1 As OpenFileDialog
        Private WithEvents closeBarItem As BarItem
        Private WithEvents WindowsMenu As ParentBarItem
        Private WithEvents exitBarItem As BarItem
        Private WithEvents cascadeBarItem As BarItem
        Private WithEvents tileHBarItem As BarItem
        Private WithEvents tileVBarItem As BarItem
        Private WithEvents mruFilesListItem As ListBarItem
        Private WithEvents mdiListBarItem1 As MdiListBarItem
        Private WithEvents largeImageList As ImageList
        Private WithEvents bar1 As Bar
        Private WithEvents bar2 As Bar
        Private components As IContainer
        Private WithEvents aboutForm As AboutForm
        Friend WithEvents ThemesEnabledItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents Office2003Item As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents imageList1 As System.Windows.Forms.ImageList
        Friend WithEvents VS2005Item As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents Outlook2007Item As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents ParentBarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents BarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents DropDownBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
        Friend WithEvents PopupControlContainer2 As Syncfusion.Windows.Forms.PopupControlContainer
        Friend WithEvents ColorPickerUIAdv1 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
        Private Shared VersionTag As String

        Shared Sub New()
            VersionTag = "AppVersion"
        End Sub
        Public Sub New()
            MyBase.New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            ' Choosing to show a merged menu/toolbar structure, all the time.
            ' Hence registering the Child Form Types that will be instantiated during the course of
            ' the application.
            ' (You can choose not to invoke a merge explicitly, in which case, the framework
            ' will automatically merge the menus/toolbars from the child Forms when instances
            ' of those types get created).
            Me.StaticBarItem1.Text = "Ready"
            Me.DropDownBarItem2.UpdateUIOnAppIdle = True
            Me.barManager1.RegisterMdiChildTypes(New Type() {GetType(TextEditorForm), GetType(ImageEditorForm)})

        End Sub
        ' Mandatory requirement of the XP Menus framework: expose a BarManager property
        ' return the BarManager instance associated with your Form.
        Public ReadOnly Property BarManager() As BarManager
            Get

                Return Me.barManager1

            End Get
        End Property

        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)

            If disposing Then
                If (Not (components) Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)

        End Sub

        Private Sub ListItemClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mruFilesListItem.Click

            Dim args As ListBarItemClickedEventArgs
            args = CType(e, ListBarItemClickedEventArgs)
            Dim listItem As ListBarItem
            listItem = CType(sender, ListBarItem)
            listItem.CheckedIndices.Clear()
            listItem.CheckedIndices.Add(args.IndexClicked)
            ' Refresh, in case this item is put in a ParentBarItem with CloseOnClick = false
            listItem.UpdateCheckedStates()
            MessageBox.Show(("ListItem: " + listItem.ChildCaptions(args.IndexClicked)))

        End Sub

        Friend WithEvents ParentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents ToolbarListBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem
        Friend WithEvents CustomColorItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents Bar3 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Friend WithEvents StaticBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
        Friend WithEvents Bar4 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Friend WithEvents BarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents ParentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer()
            Me.listBox1 = New System.Windows.Forms.ListBox
            Me.barManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.barManager1, "MainMenu")
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.openBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.closeBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.mruFilesListItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
            Me.exitBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.ToolbarListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ToolbarListBarItem
            Me.WindowsMenu = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.cascadeBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.tileHBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.tileVBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.mdiListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.barManager1, "Standard")
            Me.Bar3 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.barManager1, "StatusBar")
            Me.StaticBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
            Me.Bar4 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.barManager1, "Colors")
            Me.Office2003Item = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.VS2005Item = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.Outlook2007Item = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.DropDownBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.PopupControlContainer2 = New Syncfusion.Windows.Forms.PopupControlContainer
            Me.ColorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
            Me.ThemesEnabledItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.CustomColorItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.largeImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.mdiClient1 = New System.Windows.Forms.MdiClient
            Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.dropDownBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.popupMenu2 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PopupControlContainer2.SuspendLayout()
            Me.SuspendLayout()
            '
            'barItem8
            '
            Me.barItem8.CategoryIndex = 0
            Me.barItem8.ID = "Test4"
            Me.barItem8.Text = "Test4"
            '
            'barItem9
            '
            Me.barItem9.CategoryIndex = 0
            Me.barItem9.ID = "Test5"
            Me.barItem9.Text = "Test5"
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.Location = New System.Drawing.Point(384, 80)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Size = New System.Drawing.Size(96, 96)
            Me.popupControlContainer1.TabIndex = 5
            Me.popupControlContainer1.Visible = False
            '
            'listBox1
            '
            Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.listBox1.Location = New System.Drawing.Point(0, 0)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(96, 95)
            Me.listBox1.TabIndex = 0
            '
            'barManager1
            '
            Me.barManager1.BarPositionInfo = CType(resources.GetObject("barManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.barManager1.Bars.Add(Me.bar1)
            Me.barManager1.Bars.Add(Me.bar2)
            Me.barManager1.Bars.Add(Me.Bar3)
            Me.barManager1.Bars.Add(Me.Bar4)
            Me.barManager1.Categories.Add("File")
            Me.barManager1.Categories.Add("View")
            Me.barManager1.Categories.Add("Window")
            Me.barManager1.Categories.Add("&Help")
            Me.barManager1.Categories.Add("StatusBar")
            Me.barManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
            Me.barManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.openBarItem, Me.ParentBarItem4, Me.WindowsMenu, Me.closeBarItem, Me.parentBarItem2, Me.mruFilesListItem, Me.exitBarItem, Me.cascadeBarItem, Me.tileHBarItem, Me.tileVBarItem, Me.barItem13, Me.barItem14, Me.mdiListBarItem1, Me.ToolbarListBarItem1, Me.CustomColorItem, Me.StaticBarItem1, Me.BarItem1, Me.ParentBarItem3, Me.ThemesEnabledItem, Me.Office2003Item, Me.VS2005Item, Me.Outlook2007Item, Me.ParentBarItem5, Me.BarItem2, Me.BarItem3, Me.BarItem4, Me.DropDownBarItem2})
            Me.barManager1.LargeImageList = Me.largeImageList
            Me.barManager1.ResetCustomization = False
            Me.barManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.barManager1.ThemesEnabled = True
            '
            'bar1
            '
            Me.bar1.BarName = "MainMenu"
            Me.bar1.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "MainMenu"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.ParentBarItem4, Me.WindowsMenu, Me.parentBarItem2})
            Me.bar1.Manager = Me.barManager1
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 0
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "&File"
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.openBarItem, Me.closeBarItem, Me.ParentBarItem3, Me.exitBarItem})
            Me.parentBarItem1.MergeOrder = 1
            Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() {2, 3})
            Me.parentBarItem1.Text = "&File"
            '
            'openBarItem
            '
            Me.openBarItem.CategoryIndex = 0
            Me.openBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.openBarItem.ID = "&Open"
            Me.openBarItem.ImageIndex = 0
            Me.openBarItem.ImageList = Me.imageList1
            Me.openBarItem.MergeOrder = 1
            Me.openBarItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.openBarItem.Text = "&Open"
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
            Me.imageList1.Images.SetKeyName(15, "architecture_info_16.png")
            Me.imageList1.Images.SetKeyName(16, "ballon_fav_16.png")
            Me.imageList1.Images.SetKeyName(17, "panels_new1_restore1.ico")
            Me.imageList1.Images.SetKeyName(18, "architecture_info_16.png")
            '
            'closeBarItem
            '
            Me.closeBarItem.CategoryIndex = 0
            Me.closeBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.closeBarItem.ID = "&Close"
            Me.closeBarItem.ImageIndex = 4
            Me.closeBarItem.ImageList = Me.imageList1
            Me.closeBarItem.MergeOrder = 3
            Me.closeBarItem.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftO
            Me.closeBarItem.Text = "&Close"
            '
            'ParentBarItem3
            '
            Me.ParentBarItem3.CategoryIndex = 0
            Me.ParentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem3.ID = "Most R&ecently Used Files"
            Me.ParentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.mruFilesListItem})
            Me.ParentBarItem3.MergeOrder = 10
            Me.ParentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem3.Text = "Most R&ecently Used Files"
            '
            'mruFilesListItem
            '
            Me.mruFilesListItem.CategoryIndex = 0
            Me.mruFilesListItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mruFilesListItem.ID = "Most Recently Used Files List"
            Me.mruFilesListItem.MergeOrder = 10
            Me.mruFilesListItem.Text = "Most Recently Used Files List"
            '
            'exitBarItem
            '
            Me.exitBarItem.CategoryIndex = 0
            Me.exitBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.exitBarItem.ID = "E&xit"
            Me.exitBarItem.ImageIndex = 8
            Me.exitBarItem.MergeOrder = 20
            Me.exitBarItem.Text = "E&xit"
            '
            'ParentBarItem4
            '
            Me.ParentBarItem4.CategoryIndex = 1
            Me.ParentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem4.ID = "&View"
            Me.ParentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.ToolbarListBarItem1})
            Me.ParentBarItem4.MergeOrder = 5
            Me.ParentBarItem4.Text = "&View"
            '
            'ToolbarListBarItem1
            '
            Me.ToolbarListBarItem1.CategoryIndex = 1
            Me.ToolbarListBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ToolbarListBarItem1.ID = "&Toolbars"
            Me.ToolbarListBarItem1.Text = "&Toolbars"
            '
            'WindowsMenu
            '
            Me.WindowsMenu.CategoryIndex = 2
            Me.WindowsMenu.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.WindowsMenu.ID = "&Window"
            Me.WindowsMenu.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.cascadeBarItem, Me.tileHBarItem, Me.tileVBarItem, Me.mdiListBarItem1})
            Me.WindowsMenu.MergeOrder = 19
            Me.WindowsMenu.SeparatorIndices.AddRange(New Integer() {3})
            Me.WindowsMenu.Text = "&Window"
            '
            'cascadeBarItem
            '
            Me.cascadeBarItem.CategoryIndex = 2
            Me.cascadeBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cascadeBarItem.ID = "&Cascade"
            Me.cascadeBarItem.ImageIndex = 1
            Me.cascadeBarItem.Text = "&Cascade"
            '
            'tileHBarItem
            '
            Me.tileHBarItem.CategoryIndex = 2
            Me.tileHBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tileHBarItem.ID = "Tile &Horizontal"
            Me.tileHBarItem.ImageIndex = 2
            Me.tileHBarItem.Text = "Tile &Horizontal"
            '
            'tileVBarItem
            '
            Me.tileVBarItem.CategoryIndex = 2
            Me.tileVBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tileVBarItem.ID = "Tile &Vertical"
            Me.tileVBarItem.ImageIndex = 3
            Me.tileVBarItem.Text = "Tile &Vertical"
            '
            'mdiListBarItem1
            '
            Me.mdiListBarItem1.CategoryIndex = 2
            Me.mdiListBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mdiListBarItem1.ID = "Window List"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 3
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "&Help"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem13})
            Me.parentBarItem2.MergeOrder = 20
            Me.parentBarItem2.Text = "&Help"
            '
            'barItem13
            '
            Me.barItem13.CategoryIndex = 3
            Me.barItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem13.ID = "Syncfusion on the Web"
            Me.barItem13.ImageIndex = 11
            Me.barItem13.Text = "Syncfusion on the Web"
            '
            'bar2
            '
            Me.bar2.BarName = "Standard"
            Me.bar2.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar2.Caption = "Standard"
            Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.openBarItem, Me.closeBarItem})
            Me.bar2.Manager = Me.barManager1
            '
            'Bar3
            '
            Me.Bar3.BarName = "StatusBar"
            Me.Bar3.BarStyle = CType(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsStatusBar), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.Bar3.Caption = "StatusBar"
            Me.Bar3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.StaticBarItem1})
            Me.Bar3.Manager = Me.barManager1
            '
            'StaticBarItem1
            '
            Me.StaticBarItem1.CategoryIndex = 4
            Me.StaticBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StaticBarItem1.FlatBorderColor = System.Drawing.SystemColors.GrayText
            Me.StaticBarItem1.ID = "Status1"
            Me.StaticBarItem1.Text = "Status1"
            '
            'Bar4
            '
            Me.Bar4.BarName = "Colors"
            Me.Bar4.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.Bar4.Caption = "Colors"
            Me.Bar4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.Office2003Item, Me.VS2005Item, Me.Outlook2007Item, Me.ParentBarItem5, Me.ThemesEnabledItem})
            Me.Bar4.Manager = Me.barManager1
            '
            'Office2003Item
            '
            Me.Office2003Item.CategoryIndex = 0
            Me.Office2003Item.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Office2003Item.ID = "Office 2003"
            Me.Office2003Item.ImageIndex = 6
            Me.Office2003Item.ImageList = Me.imageList1
            Me.Office2003Item.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.Office2003Item.Text = "Office 2003"
            '
            'VS2005Item
            '
            Me.VS2005Item.CategoryIndex = 0
            Me.VS2005Item.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.VS2005Item.ID = "VS 2005"
            Me.VS2005Item.ImageIndex = 15
            Me.VS2005Item.ImageList = Me.imageList1
            Me.VS2005Item.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.VS2005Item.Text = "VS 2005"
            '
            'Outlook2007Item
            '
            Me.Outlook2007Item.CategoryIndex = 0
            Me.Outlook2007Item.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Outlook2007Item.ID = "Outlook 2007"
            Me.Outlook2007Item.ImageIndex = 16
            Me.Outlook2007Item.ImageList = Me.imageList1
            Me.Outlook2007Item.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.Outlook2007Item.Text = "Outlook 2007"
            '
            'ParentBarItem5
            '
            Me.ParentBarItem5.CategoryIndex = 0
            Me.ParentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem5.ID = "Color Scheme"
            Me.ParentBarItem5.ImageIndex = 7
            Me.ParentBarItem5.ImageList = Me.imageList1
            Me.ParentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem3, Me.BarItem4, Me.BarItem2, Me.DropDownBarItem2})
            Me.ParentBarItem5.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.ParentBarItem5.Text = "Color Scheme"
            '
            'BarItem3
            '
            Me.BarItem3.CategoryIndex = 0
            Me.BarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem3.ID = "Blue"
            Me.BarItem3.Text = "Blue"
            '
            'BarItem4
            '
            Me.BarItem4.CategoryIndex = 0
            Me.BarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem4.ID = "Silver"
            Me.BarItem4.Text = "Silver"
            '
            'BarItem2
            '
            Me.BarItem2.CategoryIndex = 0
            Me.BarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem2.ID = "Black"
            Me.BarItem2.Text = "Black"
            '
            'DropDownBarItem2
            '
            Me.DropDownBarItem2.CategoryIndex = 0
            Me.DropDownBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DropDownBarItem2.ID = "Custom Colors"
            Me.DropDownBarItem2.PopupControlContainer = Me.PopupControlContainer2
            Me.DropDownBarItem2.Text = "Custom Colors"
            '
            'PopupControlContainer2
            '
            Me.PopupControlContainer2.Controls.Add(Me.ColorPickerUIAdv1)
            Me.PopupControlContainer2.Location = New System.Drawing.Point(155, 127)
            Me.PopupControlContainer2.Name = "PopupControlContainer2"
            Me.PopupControlContainer2.Size = New System.Drawing.Size(169, 201)
            Me.PopupControlContainer2.TabIndex = 10002
            Me.PopupControlContainer2.Visible = False
            '
            'ColorPickerUIAdv1.RecentGroup
            '
            Me.ColorPickerUIAdv1.RecentGroup.Name = "Recent Colors"
            Me.ColorPickerUIAdv1.RecentGroup.Visible = False
            '
            'ColorPickerUIAdv1.StandardGroup
            '
            Me.ColorPickerUIAdv1.StandardGroup.Name = "Standard Colors"
            '
            'ColorPickerUIAdv1.ThemeGroup
            '
            Me.ColorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
            Me.ColorPickerUIAdv1.ThemeGroup.Name = "Theme Colors"
            '
            'ColorPickerUIAdv1
            '
            Me.ColorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(13, 13)
            Me.ColorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ColorPickerUIAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ColorPickerUIAdv1.HorizontalItemsSpacing = 3
            Me.ColorPickerUIAdv1.Location = New System.Drawing.Point(0, 0)
            Me.ColorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 195)
            Me.ColorPickerUIAdv1.Name = "ColorPickerUIAdv1"
            Me.ColorPickerUIAdv1.Size = New System.Drawing.Size(169, 201)
            Me.ColorPickerUIAdv1.TabIndex = 0
            Me.ColorPickerUIAdv1.Text = "ColorPickerUIAdv1"
            Me.ColorPickerUIAdv1.VerticalItemsSpacing = 1
            '
            'ThemesEnabledItem
            '
            Me.ThemesEnabledItem.CategoryIndex = 0
            Me.ThemesEnabledItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ThemesEnabledItem.ID = "Themes Enabled"
            Me.ThemesEnabledItem.ImageIndex = 5
            Me.ThemesEnabledItem.ImageList = Me.imageList1
            Me.ThemesEnabledItem.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.ThemesEnabledItem.Text = "Themes Enabled"
            '
            'barItem14
            '
            Me.barItem14.CategoryIndex = 3
            Me.barItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem14.ID = "&About"
            Me.barItem14.ImageIndex = 11
            Me.barItem14.Text = "&About"
            Me.barItem14.Visible = False
            '
            'CustomColorItem
            '
            Me.CustomColorItem.CategoryIndex = 0
            Me.CustomColorItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CustomColorItem.ID = "Custom Color"
            Me.CustomColorItem.ImageIndex = 6
            Me.CustomColorItem.Text = "Custom Color"
            Me.CustomColorItem.Tooltip = "Disable Themes to enable custom colors"
            '
            'BarItem1
            '
            Me.BarItem1.CategoryIndex = 0
            Me.BarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem1.ID = "Office 2003 Style"
            Me.BarItem1.ImageIndex = 7
            Me.BarItem1.Text = "Office 2003 Style"
            Me.BarItem1.Tooltip = "Enable Office 2003 Style"
            '
            'largeImageList
            '
            Me.largeImageList.ImageStream = CType(resources.GetObject("largeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.largeImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.largeImageList.Images.SetKeyName(0, "")
            Me.largeImageList.Images.SetKeyName(1, "")
            Me.largeImageList.Images.SetKeyName(2, "")
            Me.largeImageList.Images.SetKeyName(3, "")
            Me.largeImageList.Images.SetKeyName(4, "")
            Me.largeImageList.Images.SetKeyName(5, "")
            Me.largeImageList.Images.SetKeyName(6, "")
            '
            'mdiClient1
            '
            Me.mdiClient1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mdiClient1.Location = New System.Drawing.Point(0, 50)
            Me.mdiClient1.Name = "mdiClient1"
            Me.mdiClient1.Size = New System.Drawing.Size(0, 0)
            Me.mdiClient1.TabIndex = 4
            '
            'barItem12
            '
            Me.barItem12.CategoryIndex = 0
            Me.barItem12.ID = "dummy"
            Me.barItem12.Text = "dummy"
            '
            'barItem11
            '
            Me.barItem11.CategoryIndex = 2
            Me.barItem11.ID = "Tseting"
            Me.barItem11.Text = "Tseting"
            '
            'barItem10
            '
            Me.barItem10.CategoryIndex = 0
            Me.barItem10.ID = "Test"
            Me.barItem10.Text = "Test"
            '
            'dropDownBarItem1
            '
            Me.dropDownBarItem1.CategoryIndex = 1
            Me.dropDownBarItem1.ID = "DropDown"
            Me.dropDownBarItem1.Text = "DropDown"
            '
            'popupMenu2
            '
            Me.popupMenu2.ParentBarItem = Me.parentBarItem1
            '
            'openFileDialog1
            '
            Me.openFileDialog1.Filter = "txt files (*.txt)|*.txt|Image Files (*.bmp; *.ico)|*.bmp;*.ico"
            Me.openFileDialog1.FilterIndex = 0
            Me.openFileDialog1.Title = "Text or Image File Selection Dialog"
            '
            'MainForm
            '
            Me.AccessibleName = ""
            Me.AutoScaleBaseSize = New System.Drawing.Size(7, 20)
            Me.ClientSize = New System.Drawing.Size(672, 438)
            Me.Controls.Add(Me.PopupControlContainer2)
            Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "MainForm"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "MDI Demo"
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PopupControlContainer2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=False, ExactSpelling:=False, PreserveSig:=False, CallingConvention:=CallingConvention.Winapi)> _
        Public Shared Function SetForegroundWindow(ByVal hwnd As System.IntPtr) As Boolean
        End Function

        <STAThread()> _
        Public Shared Sub Main()

            Dim mainForm As MainForm
            mainForm = New MainForm()
            Dim bRunning As Boolean
            bRunning = False
            Dim p As Process
            For Each p In Process.GetProcesses(System.Environment.MachineName)
                If IntPtr.op_Inequality(p.MainWindowHandle, IntPtr.Zero) Then
                    ' Process name gets truncated!
                    If (p.ProcessName Is "XPMenus") Then
                        bRunning = True
                        MessageBox.Show("Activating the already open instance of XPMenus.exe.")
                        SetForegroundWindow(p.MainWindowHandle)
                        Exit For
                    End If
                End If
            Next
            If Not (bRunning) Then
                ' Modify this version, whenever changes are made such that the persisted state cannot be loaded anymore.
                Dim curVersion As String
                curVersion = "1.0"
                ValidatePersistedStateVersion(curVersion)
                StoreVersionInfo(curVersion)
                Application.Run(mainForm)
            End If

        End Sub

        Private Shared Sub ValidatePersistedStateVersion(ByVal curVersion As String)

            ' Versioning
            Dim serializer As AppStateSerializer
            serializer = AppStateSerializer.GetSingleton
            Dim objectOut As Object
            objectOut = serializer.DeserializeObject(VersionTag)
            If (Not (objectOut) Is Nothing) Then
                Dim version As String
                version = CType(objectOut, String)
                version = version.ToLower
                curVersion = curVersion.ToLower
                ' Persisted info is not the current version, lets lose it.
                If (version Is curVersion) = False Then
                    serializer.FlushSerializer()
                End If
            End If

        End Sub

        Private Shared Sub StoreVersionInfo(ByVal curVersion As String)

            Dim serializer As AppStateSerializer
            serializer = AppStateSerializer.GetSingleton
            serializer.SerializeObject(VersionTag, curVersion, True)

        End Sub

        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Dim found As Boolean
            found = True
            Try
                Dim filename1 As String = "logo.jpg"
                Dim filename2 As String = "Description.txt"
                Me.AddDocument(New ImageEditorForm("..\logo.jpg"))
                Me.AddDocument(New TextEditorForm("..\Description.txt"))
                Me.mruFilesListItem.ChildCaptions.Add(filename1)
                Me.mruFilesListItem.ChildCaptions.Add(filename2)

            Catch ex As System.Exception
                found = False
            End Try
            ' Application specific initialization
            If Not (found) Then
                Try
                    Me.AddDocument(New TextEditorForm("Description.txt"))
                    Me.AddDocument(New ImageEditorForm("logo.jpg"))
                Catch ex As System.Exception
                End Try
            End If
            Me.UpdateMenuItems()

        End Sub

        Private Sub AddDocument(ByVal newForm As Form)

            newForm.MdiParent = Me
            newForm.Show()

        End Sub

        Private Sub openBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openBarItem.Click

            Dim dlg As DocumentTypeSelectionDialog
            dlg = New DocumentTypeSelectionDialog()
            If (dlg.ShowDialog <> Windows.Forms.DialogResult.OK) Then
                Return
            End If
            Dim docType As Integer
            docType = dlg.SelectedType
            Me.openFileDialog1.FileName = String.Empty
            If (docType = 0) Then
                Me.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*"
            Else
                If (docType = 1) Then
                    Me.openFileDialog1.Filter = "Image Files (*.bmp; *.ico; *.jpg)|*.bmp;*.ico;*.jpg|All Files (*.*)|*.*"
                End If
            End If
            If (Me.openFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK) Then
                Dim filename As String
                filename = Me.openFileDialog1.FileName
                filename = filename.ToLower
                Me.mruFilesListItem.ChildCaptions.Add(filename)
                If (docType = 0) Then
                    ' Text file opened
                    Dim childForm As TextEditorForm
                    childForm = New TextEditorForm(filename)
                    Me.AddDocument(childForm)
                Else
                    If (docType = 1) Then
                        Try
                            Dim imageEditor As ImageEditorForm
                            imageEditor = New ImageEditorForm(filename)
                            Me.AddDocument(imageEditor)
                        Catch ex As System.Exception
                        End Try
                    End If
                End If
            End If

        End Sub

        Private Sub closeBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBarItem.Click

            Dim activeChild As Form
            activeChild = Me.ActiveMdiChild
            If (Not (activeChild) Is Nothing) Then
                activeChild.Close()
            End If

        End Sub
        Private Sub MainForm_MdiChildActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate

            Me.UpdateMenuItems()

        End Sub

        Private Sub UpdateMenuItems()

            If (Not (Me.ActiveMdiChild) Is Nothing) Then
                Me.closeBarItem.Enabled = True
                Me.WindowsMenu.Enabled = True
            Else
                Me.closeBarItem.Enabled = False
                Me.WindowsMenu.Enabled = False
            End If

        End Sub

        Private Sub exitBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitBarItem.Click

            Me.Close()

        End Sub

        Private Sub cascadeBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cascadeBarItem.Click

            Me.LayoutMdi(MdiLayout.Cascade)

        End Sub

        Private Sub tileHBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tileHBarItem.Click

            Me.LayoutMdi(MdiLayout.TileHorizontal)

        End Sub

        Private Sub tileVBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tileVBarItem.Click

            Me.LayoutMdi(MdiLayout.TileVertical)

        End Sub

        Private Sub barItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barItem13.Click

            aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())

            aboutForm.ShowDialog()

        End Sub

        Private Sub AboutFormCloseBtnClicked(ByVal sender As Object, ByVal e As EventArgs)

            aboutForm.Close()

        End Sub



        Private Sub CustomColorItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomColorItem.Click
            Me.CustomColorItem.Checked = Not Me.CustomColorItem.Checked

            If Me.CustomColorItem.Checked Then

                MenuColors.MenuBGColor = Color.FromArgb(250, 250, 248)
                MenuColors.CheckedSelColor = Color.FromArgb(238, 238, 230)
                MenuColors.MenuLeftStripColor = Color.FromArgb(195, 195, 171)
                MenuColors.PressedSelColor = Color.FromArgb(195, 195, 171)
                MenuColors.SelBorderColor = Color.FromArgb(194, 163, 69)
                MenuColors.SelColor = Color.FromArgb(253, 252, 248)
                MenuColors.CommandBarBackColor = Color.FromArgb(227, 228, 214)
                Me.BackColor = Color.FromArgb(232, 232, 222)
                MenuColors.MainMenuBackColor = Me.BackColor
                MenuColors.StatusBarBackColor = Me.BackColor
                MenuColors.FloatingCommandBarCaptionColor = Color.FromArgb(227, 228, 214)
                MenuColors.ExpandedMenuStripBackColor = Color.FromArgb(229, 229, 217)
                ' Default is 175
                MenuColors.InactiveItemAlphaBlendFactor = 100
                MenuColors.MenuTextColor = Color.FromArgb(0, 1, 0)
                MenuColors.MenuActiveTextColor = Color.FromArgb(61, 65, 129)
                MenuColors.DisabledMenuTextColorBase = Color.FromArgb(227, 225, 214)
                MenuColors.DisabledToolbarItemTextColorBase = Color.FromArgb(227, 225, 214)


            Else
                ' Reset custom colors. The menus will then use system colors.
                MenuColors.MenuBGColor = Color.Empty
                MenuColors.DropDownBorderColor = Color.Empty
                MenuColors.CheckedSelColor = Color.Empty
                MenuColors.MenuLeftStripColor = Color.Empty
                MenuColors.PressedSelColor = Color.Empty
                MenuColors.SelBorderColor = Color.Empty
                MenuColors.SelColor = Color.Empty
                MenuColors.CommandBarBackColor = Color.Empty
                Me.ResetBackColor()
                MenuColors.MainMenuBackColor = Color.Empty
                MenuColors.StatusBarBackColor = Color.Empty
                MenuColors.FloatingCommandBarCaptionColor = Color.Empty
                MenuColors.ExpandedMenuStripBackColor = Color.Empty
                MenuColors.InactiveItemAlphaBlendFactor = -1
                MenuColors.MenuTextColor = Color.Empty
                MenuColors.MenuActiveTextColor = Color.Empty
                MenuColors.DisabledMenuTextColorBase = Color.Empty
                MenuColors.DisabledToolbarItemTextColorBase = Color.Empty
            End If

        End Sub

        Private Sub parentBarItem1_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles parentBarItem1.Selected, parentBarItem2.Selected, ParentBarItem4.Selected, BarItem1.Selected, barItem10.Selected, barItem11.Selected, barItem12.Selected, barItem13.Selected, barItem14.Selected, barItem8.Selected, barItem9.Selected, cascadeBarItem.Selected, closeBarItem.Selected, CustomColorItem.Selected, exitBarItem.Selected, parentBarItem1.Selected, parentBarItem2.Selected, ParentBarItem4.Selected, tileHBarItem.Selected, tileVBarItem.Selected, WindowsMenu.Selected
            Dim item As BarItem = CType(sender, BarItem)
            Me.StaticBarItem1.Text = item.Text
        End Sub

        Private Sub BarItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BarItem1.Click
            Me.BarItem1.Checked = Not Me.BarItem1.Checked
            If Me.BarItem1.Checked Then
                Me.barManager1.Style = VisualStyle.Office2003
            Else
                Me.barManager1.Style = VisualStyle.OfficeXP
            End If
        End Sub

        Private Sub Office2003Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Office2003Item.Click
            Me.ThemesEnabledItem.Checked = False
            Me.VS2005Item.Checked = False
            Me.Outlook2007Item.Checked = False
            Me.barManager1.ThemesEnabled = False
            Me.Office2003Item.Checked = Not Me.Office2003Item.Checked
            Me.barManager1.Style = VisualStyle.Default
            If Me.Office2003Item.Checked Then
                Me.barManager1.Style = VisualStyle.Office2003
            Else
                Me.barManager1.Style = VisualStyle.OfficeXP
            End If
        End Sub

        Private Sub VS2005Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VS2005Item.Click
            Me.Office2003Item.Checked = False
            Me.ThemesEnabledItem.Checked = False
            Me.barManager1.ThemesEnabled = False
            Me.Outlook2007Item.Checked = False
            Me.VS2005Item.Checked = Not Me.VS2005Item.Checked
            If Me.VS2005Item.Checked Then
                Me.barManager1.Style = VisualStyle.VS2005
            Else
                Me.barManager1.Style = VisualStyle.OfficeXP
            End If
        End Sub

        Private Sub Outlook2007Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Outlook2007Item.Click
            Me.Office2003Item.Checked = False
            Me.ThemesEnabledItem.Checked = False
            'this.barManager1.ThemesEnabled = false;
            Me.VS2005Item.Checked = False

            Me.Outlook2007Item.Checked = Not Me.Outlook2007Item.Checked
            If Me.Outlook2007Item.Checked Then
                Me.barManager1.Style = VisualStyle.Office2007Outlook
            Else
                Me.barManager1.Style = VisualStyle.OfficeXP
            End If
        End Sub

       

        Private Sub ThemesEnabledItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThemesEnabledItem.Click
            Me.Office2003Item.Checked = False
            Me.VS2005Item.Checked = False
            Me.Outlook2007Item.Checked = False
            Me.ThemesEnabledItem.Checked = Not Me.ThemesEnabledItem.Checked
            Me.barManager1.Style = VisualStyle.Default
            If Me.ThemesEnabledItem.Checked Then
                Me.barManager1.ThemesEnabled = True
            Else
                Me.barManager1.ThemesEnabled = False
            End If
        End Sub

        Private Sub BarItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarItem3.Click
            Me.Office2003Item.Checked = False
            Me.VS2005Item.Checked = False
            Me.Outlook2007Item.Checked = False
            Me.ThemesEnabledItem.Checked = False
            Me.barManager1.Style = VisualStyle.Office2007

            Me.barManager1.Office2007Theme = Office2007Theme.Blue
            Me.ColorScheme = Office2007Theme.Blue
        End Sub

        Private Sub BarItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarItem4.Click
            Me.Office2003Item.Checked = False
            Me.VS2005Item.Checked = False
            Me.Outlook2007Item.Checked = False
            Me.ThemesEnabledItem.Checked = False
            Me.barManager1.Style = VisualStyle.Office2007

            Me.barManager1.Office2007Theme = Office2007Theme.Silver
            Me.ColorScheme = Office2007Theme.Silver
        End Sub

        Private Sub BarItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarItem2.Click
            Me.Office2003Item.Checked = False
            Me.VS2005Item.Checked = False
            Me.Outlook2007Item.Checked = False
            Me.ThemesEnabledItem.Checked = False
            Me.barManager1.Style = VisualStyle.Office2007

            Me.barManager1.Office2007Theme = Office2007Theme.Black
            Me.ColorScheme = Office2007Theme.Black
        End Sub

        Private Sub ColorPickerUIAdv1_Picked(ByVal sender As System.Object, ByVal args As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs) Handles ColorPickerUIAdv1.Picked
            Me.Office2003Item.Checked = False
            Me.VS2005Item.Checked = False
            Me.Outlook2007Item.Checked = False
            Me.ThemesEnabledItem.Checked = False
            Me.barManager1.Style = VisualStyle.Office2007

            Me.barManager1.Office2007Theme = Office2007Theme.Managed
            Me.ColorScheme = Office2007Theme.Managed
            Office2007Colors.ApplyManagedColors(Me, args.Color)
            Me.DropDownBarItem2.PopupControlContainer.HidePopup(PopupCloseType.Done)
        End Sub

        Private Sub DropDownBarItem2_UpdateUI(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownBarItem2.UpdateUI
            Me.ColorPickerUIAdv1.RecentGroup.Visible = False
        End Sub
    End Class

End Namespace
