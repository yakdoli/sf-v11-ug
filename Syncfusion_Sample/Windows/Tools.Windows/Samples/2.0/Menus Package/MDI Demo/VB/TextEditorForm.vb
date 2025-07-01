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
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Resources
Imports System.Windows.Forms

Namespace XPMenusMDI
    Public Class TextEditorForm
        Inherits Form
        Private baseImage As Image
        Private WithEvents barManager1 As ChildFrameBarManager
        Private WithEvents popupMenu1 As PopupMenu
        Private WithEvents barItem4 As BarItem
        Private WithEvents cutBarItem As BarItem
        Private WithEvents copyBarItem As BarItem
        Private WithEvents pasteBarItem As BarItem
        Private WithEvents fontColorBarItem As DropDownBarItem
        Private WithEvents editMenu As ParentBarItem
        Private WithEvents richTextBox1 As RichTextBox
        Private components As IContainer
        Private sourceFile As String
        Private WithEvents selAllBarItem As BarItem
        Private WithEvents popupControlContainer1 As PopupControlContainer
        Private WithEvents colorUIControl1 As ColorUIControl
        Private WithEvents largeImageList As ImageList
        Private WithEvents barItem2 As BarItem
        Private WithEvents findItem As ComboBoxBarItem
        Private WithEvents parentBarItem1 As ParentBarItem
        Private WithEvents barItem3 As BarItem
        Private WithEvents barItem5 As BarItem
        Private WithEvents parentBarItem2 As ParentBarItem
        Private WithEvents parentBarItem3 As ParentBarItem
        Private WithEvents popupMenusManager1 As PopupMenusManager
        Private WithEvents bar1 As Bar
        Private WithEvents bar2 As Bar
        Friend WithEvents SuperToolTip1 As Syncfusion.Windows.Forms.Tools.SuperToolTip
        Private Shared instanceCount As Integer
        'Fields
        'Constructors
        'Events
        'Methods
        Shared Sub New()
            'Warning: Implementation not found
        End Sub
        Public Sub New()
            MyBase.New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

        End Sub
        Public Sub New(ByVal sourceFile As String)
            MyBase.New()
            Me.sourceFile = sourceFile
            Me.InitializeComponent()
            instanceCount = (instanceCount + 1)

            Me.Text = ("Text Editor" + instanceCount.ToString)
            ' The SourceFile needs to be set before load gets called.
            Me.InitFromSourceFile()

        End Sub
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
        Friend WithEvents undoPopup As Syncfusion.Windows.Forms.PopupControlContainer
        Friend WithEvents undoLabel As System.Windows.Forms.Label
        Friend WithEvents DropDownBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
        Friend WithEvents Bar3 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Friend WithEvents SaveItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents ParentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents FontComboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Friend WithEvents FontListBox1 As Syncfusion.Windows.Forms.Tools.FontListBox
        Friend WithEvents undoList As Syncfusion.Windows.Forms.FocuslessListBox
        Private WithEvents imageList As System.Windows.Forms.ImageList
        Friend WithEvents imageList1 As System.Windows.Forms.ImageList
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditorForm))
            Me.imageList = New System.Windows.Forms.ImageList(Me.components)
            Me.barManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.barManager1, "MainMenu")
            Me.ParentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.SaveItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.editMenu = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.DropDownBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.undoPopup = New Syncfusion.Windows.Forms.PopupControlContainer
            Me.undoLabel = New System.Windows.Forms.Label
            Me.undoList = New Syncfusion.Windows.Forms.FocuslessListBox
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.cutBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.copyBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.pasteBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.findItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.fontColorBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer
            Me.colorUIControl1 = New Syncfusion.Windows.Forms.ColorUIControl
            Me.selAllBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.barManager1, "Text Edit")
            Me.FontComboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.FontListBox1 = New Syncfusion.Windows.Forms.Tools.FontListBox
            Me.Bar3 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.barManager1, "Standard")
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.largeImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.popupMenu1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.popupMenusManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(Me.components)
            Me.SuperToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.undoPopup.SuspendLayout()
            Me.popupControlContainer1.SuspendLayout()
            Me.SuspendLayout()
            '
            'imageList
            '
            Me.imageList.ImageStream = CType(resources.GetObject("imageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList.Images.SetKeyName(0, "")
            Me.imageList.Images.SetKeyName(1, "")
            Me.imageList.Images.SetKeyName(2, "")
            Me.imageList.Images.SetKeyName(3, "")
            Me.imageList.Images.SetKeyName(4, "")
            Me.imageList.Images.SetKeyName(5, "")
            Me.imageList.Images.SetKeyName(6, "")
            '
            'barManager1
            '
            Me.barManager1.BarPositionInfo = CType(resources.GetObject("barManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.barManager1.Bars.Add(Me.bar1)
            Me.barManager1.Bars.Add(Me.bar2)
            Me.barManager1.Bars.Add(Me.Bar3)
            Me.barManager1.Categories.Add("File")
            Me.barManager1.Categories.Add("Edit")
            Me.barManager1.Categories.Add("Standard")
            Me.barManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
            Me.barManager1.Form = Me
            Me.barManager1.FormName = "Text Editor"
            Me.barManager1.ImageList = Me.imageList1
            Me.barManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.editMenu, Me.ParentBarItem4, Me.DropDownBarItem1, Me.barItem2, Me.cutBarItem, Me.copyBarItem, Me.pasteBarItem, Me.fontColorBarItem, Me.selAllBarItem, Me.findItem, Me.FontComboBoxBarItem1, Me.barItem3, Me.barItem5, Me.parentBarItem2, Me.parentBarItem3, Me.SaveItem})
            Me.barManager1.LargeImageList = Me.largeImageList
            Me.barManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'bar1
            '
            Me.bar1.BarName = "MainMenu"
            Me.bar1.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "MainMenu"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.ParentBarItem4, Me.editMenu})
            Me.bar1.Manager = Me.barManager1
            '
            'ParentBarItem4
            '
            Me.ParentBarItem4.CategoryIndex = 0
            Me.ParentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem4.ID = "&File"
            Me.ParentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.SaveItem})
            Me.ParentBarItem4.MergeOrder = 1
            Me.ParentBarItem4.Text = "&File"
            '
            'SaveItem
            '
            Me.SaveItem.CategoryIndex = 2
            Me.SaveItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SaveItem.ID = "&Save"
            Me.SaveItem.ImageIndex = 6
            Me.SaveItem.MergeOrder = 2
            Me.SaveItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.SaveItem.Text = "&Save"
            Me.SaveItem.Tooltip = "Save Text (Ctrl + S)"
            '
            'editMenu
            '
            Me.editMenu.CategoryIndex = 1
            Me.editMenu.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.editMenu.ID = "&Edit"
            Me.editMenu.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.DropDownBarItem1, Me.barItem2, Me.cutBarItem, Me.copyBarItem, Me.pasteBarItem, Me.findItem, Me.fontColorBarItem, Me.selAllBarItem})
            Me.editMenu.MergeOrder = 2
            Me.editMenu.SeparatorIndices.AddRange(New Integer() {2, 5})
            Me.editMenu.Text = "&Edit"
            '
            'DropDownBarItem1
            '
            Me.DropDownBarItem1.CategoryIndex = 1
            Me.DropDownBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DropDownBarItem1.ID = "&Undo"
            Me.DropDownBarItem1.ImageIndex = 4
            Me.DropDownBarItem1.MergeType = System.Windows.Forms.MenuMerge.Replace
            Me.DropDownBarItem1.PopupControlContainer = Me.undoPopup
            Me.DropDownBarItem1.Text = "&Undo"
            '
            'undoPopup
            '
            Me.undoPopup.BackColor = System.Drawing.SystemColors.Window
            Me.undoPopup.Controls.Add(Me.undoLabel)
            Me.undoPopup.Controls.Add(Me.undoList)
            Me.undoPopup.Location = New System.Drawing.Point(9, 8)
            Me.undoPopup.Name = "undoPopup"
            Me.undoPopup.Padding = New System.Windows.Forms.Padding(1)
            Me.undoPopup.Size = New System.Drawing.Size(119, 123)
            Me.undoPopup.TabIndex = 7
            Me.undoPopup.Visible = False
            '
            'undoLabel
            '
            Me.undoLabel.BackColor = System.Drawing.Color.WhiteSmoke
            Me.undoLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.undoLabel.Location = New System.Drawing.Point(1, 61)
            Me.undoLabel.Name = "undoLabel"
            Me.undoLabel.Size = New System.Drawing.Size(117, 61)
            Me.undoLabel.TabIndex = 1
            Me.undoLabel.Text = "label1"
            Me.undoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'undoList
            '
            Me.undoList.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.undoList.CausesValidation = False
            Me.undoList.Dock = System.Windows.Forms.DockStyle.Top
            Me.undoList.ItemHeight = 20
            Me.undoList.Items.AddRange(New Object() {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen"})
            Me.undoList.Location = New System.Drawing.Point(1, 1)
            Me.undoList.Name = "undoList"
            Me.undoList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
            Me.undoList.Size = New System.Drawing.Size(117, 60)
            Me.undoList.TabIndex = 0
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 1
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "&Redo"
            Me.barItem2.ImageIndex = 5
            Me.barItem2.Text = "&Redo"
            '
            'cutBarItem
            '
            Me.cutBarItem.CategoryIndex = 1
            Me.cutBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cutBarItem.ID = "Cu&t"
            Me.cutBarItem.ImageIndex = 1
            Me.cutBarItem.Text = "Cu&t"
            '
            'copyBarItem
            '
            Me.copyBarItem.CategoryIndex = 1
            Me.copyBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.copyBarItem.ID = "&Copy"
            Me.copyBarItem.ImageIndex = 0
            Me.copyBarItem.Text = "&Copy"
            '
            'pasteBarItem
            '
            Me.pasteBarItem.CategoryIndex = 1
            Me.pasteBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pasteBarItem.ID = "&Paste"
            Me.pasteBarItem.ImageIndex = 2
            Me.pasteBarItem.Text = "&Paste"
            '
            'findItem
            '
            Me.findItem.AutoAppend = True
            Me.findItem.CategoryIndex = 1
            Me.findItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.findItem.ID = "Find"
            Me.findItem.MinWidth = 80
            Me.findItem.Text = "Find"
            '
            'fontColorBarItem
            '
            Me.fontColorBarItem.CategoryIndex = 1
            Me.fontColorBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fontColorBarItem.ID = "&Font Color"
            Me.fontColorBarItem.ImageIndex = 3
            Me.fontColorBarItem.PopupControlContainer = Me.popupControlContainer1
            Me.fontColorBarItem.Text = "&Font Color"
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BackColor = System.Drawing.SystemColors.ControlDark
            Me.popupControlContainer1.Controls.Add(Me.colorUIControl1)
            Me.popupControlContainer1.Location = New System.Drawing.Point(201, 30)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Padding = New System.Windows.Forms.Padding(1)
            Me.popupControlContainer1.Size = New System.Drawing.Size(238, 190)
            Me.popupControlContainer1.TabIndex = 5
            Me.popupControlContainer1.Visible = False
            '
            'colorUIControl1
            '
            Me.colorUIControl1.BackColor = System.Drawing.SystemColors.Control
            Me.colorUIControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.colorUIControl1.Location = New System.Drawing.Point(1, 1)
            Me.colorUIControl1.Name = "colorUIControl1"
            Me.colorUIControl1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.CustomColors
            Me.colorUIControl1.Size = New System.Drawing.Size(236, 188)
            Me.colorUIControl1.TabIndex = 0
            Me.colorUIControl1.Text = "colorUIControl1"
            Me.colorUIControl1.UserTabName = "User Colors"
            '
            'selAllBarItem
            '
            Me.selAllBarItem.CategoryIndex = 1
            Me.selAllBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.selAllBarItem.ID = "Select &All"
            Me.selAllBarItem.IsRecentlyUsedItem = False
            Me.selAllBarItem.Text = "Select &All"
            '
            'bar2
            '
            Me.bar2.BarName = "Text Edit"
            Me.bar2.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar2.Caption = "Text Edit"
            Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.cutBarItem, Me.copyBarItem, Me.pasteBarItem, Me.fontColorBarItem, Me.findItem, Me.DropDownBarItem1, Me.barItem2, Me.FontComboBoxBarItem1})
            Me.bar2.Manager = Me.barManager1
            '
            'FontComboBoxBarItem1
            '
            Me.FontComboBoxBarItem1.CategoryIndex = 1
            Me.FontComboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FontComboBoxBarItem1.Editable = False
            Me.FontComboBoxBarItem1.ID = "Font Selection"
            Me.FontComboBoxBarItem1.ListBox = Me.FontListBox1
            Me.FontComboBoxBarItem1.MinWidth = 100
            Me.FontComboBoxBarItem1.Text = "Font Combo"
            '
            'FontListBox1
            '
            Me.FontListBox1.ItemHeight = 15
            Me.FontListBox1.Location = New System.Drawing.Point(73, 114)
            Me.FontListBox1.Name = "FontListBox1"
            Me.FontListBox1.Size = New System.Drawing.Size(110, 79)
            Me.FontListBox1.TabIndex = 8
            '
            'Bar3
            '
            Me.Bar3.BarName = "Standard"
            Me.Bar3.Caption = "Standard"
            Me.Bar3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.SaveItem})
            Me.Bar3.Manager = Me.barManager1
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
            '
            'barItem3
            '
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "Item 1"
            Me.barItem3.Text = "Item 1"
            '
            'barItem5
            '
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "Item 2"
            Me.barItem5.Text = "Item 2"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "Parent Item 1"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem3})
            Me.parentBarItem2.Text = "Parent Item 1"
            '
            'parentBarItem3
            '
            Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem3.ID = "Parent 2"
            Me.parentBarItem3.Text = "Parent 2"
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
            'popupMenu1
            '
            Me.popupMenu1.ParentBarItem = Me.editMenu
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 0
            Me.barItem4.ID = "Test"
            Me.barItem4.Text = "Test"
            '
            'richTextBox1
            '
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.richTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.richTextBox1.HideSelection = False
            Me.richTextBox1.Location = New System.Drawing.Point(0, 0)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(400, 245)
            Me.richTextBox1.TabIndex = 4
            Me.richTextBox1.Text = ""
            Me.popupMenusManager1.SetXPContextMenu(Me.richTextBox1, Me.popupMenu1)
            '
            'parentBarItem1
            '
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem3, Me.barItem5, Me.parentBarItem2})
            Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() {1})
            '
            'TextEditorForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
            Me.ClientSize = New System.Drawing.Size(400, 245)
            Me.Controls.Add(Me.FontListBox1)
            Me.Controls.Add(Me.undoPopup)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.richTextBox1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "TextEditorForm"
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
            Me.Text = "Text Editor"
            CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.undoPopup.ResumeLayout(False)
            Me.popupControlContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private Sub ClientForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            ' Updated the enabled/disabled state of the menu items.
            Me.UpdateMenuItems()
            ' Update the Font Color BarItem image.
            Me.InitBaseImage()
            Me.colorUIControl1.SelectedColor = Color.Black

        End Sub
        Private Sub InitFromSourceFile()

            If (Me.sourceFile Is String.Empty) = False Then
                Dim file As FileInfo
                file = New FileInfo(Me.sourceFile)
                Dim r As StreamReader
                r = file.OpenText
                Me.richTextBox1.SelectedText = r.ReadToEnd
                r.Close()
            End If

        End Sub
        Private Sub cutBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cutBarItem.Click

            Me.richTextBox1.Cut()

        End Sub
        Private Sub richTextBox1_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles richTextBox1.SelectionChanged

            Me.UpdateMenuItems()

        End Sub
        Private Sub UpdateMenuItems()

            If (Me.richTextBox1.SelectedText.Length > 0) Then
                Me.copyBarItem.Enabled = True
                Me.cutBarItem.Enabled = True
            Else
                Me.copyBarItem.Enabled = False
                Me.cutBarItem.Enabled = False
            End If

        End Sub
        Private Sub copyBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles copyBarItem.Click

            Me.richTextBox1.Copy()

        End Sub
        Private Sub pasteBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pasteBarItem.Click

            Me.richTextBox1.Paste()

        End Sub
        Private Sub selAllBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selAllBarItem.Click

            Me.richTextBox1.SelectAll()

        End Sub

        Private Sub barItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem2.Click
            Me.richTextBox1.Redo()
        End Sub

        Private Sub fontColorBarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fontColorBarItem.Click

            ' Set the selection's color to be the ColorUI's Selected Color.
            Me.richTextBox1.SelectionColor = Me.colorUIControl1.SelectedColor

        End Sub
        Private Sub colorUIControl1_ColorSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorUIControl1.ColorSelected

            Me.fontColorBarItem_Click(sender, e)
            Me.UpdateDropdownImageColor(Me.colorUIControl1.SelectedColor)
            ' Close the popup, now that a Color was selected
            Me.popupControlContainer1.HidePopup(PopupCloseType.Done)

        End Sub
        Private Sub UpdateDropdownImageColor(ByVal newColor As Color)

            ' Create a new bitmap off the base image.
            Dim newImage As Image
            newImage = CType(Me.baseImage.Clone, Image)
            Dim newBitmap As System.Drawing.Bitmap
            newBitmap = New System.Drawing.Bitmap(newImage)
            ' Set the Color cue pixels to the appropriate color.
            Dim i As Integer
            i = 12

            Do While (i <= 14)
                Dim j As Integer
                j = 2

                Do While (j <= 14)
                    newBitmap.SetPixel(j, i, Me.colorUIControl1.SelectedColor)
                    j = (j + 1)

                Loop
                i = (i + 1)

            Loop
            ' Update the image stored in the imagelist to this new image.
            Me.imageList1.Images(Me.fontColorBarItem.ImageIndex) = newBitmap

        End Sub
        Private Sub InitBaseImage()

            ' Store this for use later when the selected color changes in ColorUI control.
            Me.baseImage = CType(Me.imageList1.Images(Me.fontColorBarItem.ImageIndex).Clone, Image)

        End Sub
        Private Sub findItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles findItem.Click

            If (Me.findItem.TextBoxValue Is String.Empty) = False Then
                ' Determine the starting location of the word.
                Dim searchString As String
                searchString = Me.findItem.TextBoxValue
                Dim searchBeginIndex As Integer
                searchBeginIndex = (Me.richTextBox1.SelectionStart + Me.richTextBox1.SelectionLength)
                Dim sourceString As String
                sourceString = Me.richTextBox1.Text.Substring(searchBeginIndex)
                Dim index As Integer
                index = sourceString.IndexOf(searchString)
                ' Determine if the word has been found and select it if it was.
                If (index = -(1)) Then
                    searchBeginIndex = 0
                    sourceString = Me.richTextBox1.Text.Substring(searchBeginIndex)
                    index = sourceString.IndexOf(searchString)
                End If
                If (index <> -(1)) Then
                    ' Select the string using the index and the length of the string.
                    Me.richTextBox1.Select((searchBeginIndex + index), Me.findItem.TextBoxValue.Length)
                End If
            End If

        End Sub
        Private Sub popupControlContainer1_Popup(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popupControlContainer1.Popup

            Me.colorUIControl1.Focus()

        End Sub


        Private Sub undoPopup_BeforePopup(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles undoPopup.BeforePopup
            Dim count As Integer = 0
            If Me.undoList.Items.Count > 15 Then
                count = 15
            Else
                count = Me.undoList.Items.Count()
            End If
            Me.undoList.Height = Me.undoList.ItemHeight * count
            Me.undoPopup.Height = Me.undoList.Height + 26
            Me.undoPopup.PopupHost.OverlapBorderColor = SystemColors.ControlDarkDark
        End Sub

        Private Sub undoPopup_CloseUp(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.PopupClosedEventArgs) Handles undoPopup.CloseUp
            If args.PopupCloseType = PopupCloseType.Done Then
                ' Undo Actions here based on selections in the listbox.
            End If
            Me.undoList.SelectedIndex = -1
        End Sub

        Private Sub undoLabel_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles undoLabel.MouseDown
            Me.undoPopup.HidePopup(PopupCloseType.Deactivated)
        End Sub

        Private Sub undoList_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles undoList.MouseDown
            Dim index As Integer = Me.undoList.IndexFromPoint(e.X, e.Y)
            If index <> -1 Then
                Me.undoList.SetSelected(index, True)
            End If
        End Sub

        Private Sub undoList_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles undoList.MouseMove
            Dim index As Integer = Me.undoList.IndexFromPoint(e.X, e.Y)
            If index <> -1 Then
                Dim selectedIndices As ListBox.SelectedIndexCollection = Me.undoList.SelectedIndices

                Dim i As Integer
                For i = index To 0 Step i - 1
                    If Not selectedIndices.Contains(i) Then
                        Me.undoList.SetSelected(i, True)
                    End If
                Next

                i = index + 1
                Do While (i < Me.undoList.Items.Count)
                    If selectedIndices.Contains(i) Then
                        Me.undoList.SetSelected(i, False)
                    End If
                    i = i + 1
                Loop
                index = index + 1

                Me.undoLabel.Text = "Undo " + index.ToString() + " Actions."
            End If
        End Sub

        Private Sub undoList_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles undoList.MouseUp
            Me.undoPopup.HidePopup(PopupCloseType.Done)
        End Sub

        Private Sub SaveItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveItem.Click
            Dim filename As String = ""
            Dim savefDlg As SaveFileDialog = New SaveFileDialog()
            savefDlg.Filter = "text files(*.txt)|*.txt"
            If (savefDlg.ShowDialog = Windows.Forms.DialogResult.OK) Then
                filename = savefDlg.FileName
                Dim wstr As StreamWriter = New StreamWriter(filename, False, System.Text.Encoding.Unicode)
                Dim line As String
                For Each line In richTextBox1.Lines
                    wstr.WriteLine(line)
                Next
                wstr.Close()
            End If
        End Sub

        Private Sub FontComboBoxBarItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FontComboBoxBarItem1.Click
            Me.richTextBox1.SelectionFont = New Font(Me.FontComboBoxBarItem1.TextBoxValue, 10)
        End Sub


    End Class
End Namespace
