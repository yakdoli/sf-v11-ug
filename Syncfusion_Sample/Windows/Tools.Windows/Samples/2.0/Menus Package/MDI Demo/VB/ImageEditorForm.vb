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
Imports System.Drawing
Imports System.Resources
Imports System.Windows.Forms

Namespace XPMenusMDI
    Public Class ImageEditorForm
        Inherits Form
        Private WithEvents pictureBox1 As PictureBox
        Private WithEvents childFrameBarManager1 As ChildFrameBarManager
        Private WithEvents horzFilpItem As BarItem
        Private WithEvents vertFlipItem As BarItem
        Private WithEvents rotate90Item As BarItem
        Private WithEvents parentBarItem1 As ParentBarItem
        Private sourceFile As String
        Private sourceImage As Image
        Private WithEvents popupControlContainer1 As PopupControlContainer
        Private WithEvents button1 As Button
        Private WithEvents button2 As Button
        Private WithEvents button3 As Button
        Private WithEvents button4 As Button
        Private WithEvents button5 As Button
        Private WithEvents button6 As Button
        Private WithEvents button7 As Button
        Private WithEvents button8 As Button
        Private WithEvents button9 As Button
        Private WithEvents dropDownBarItem1 As DropDownBarItem
        Private WithEvents parentBarItem2 As ParentBarItem
        Private WithEvents parentBarItem3 As ParentBarItem
        Private WithEvents autoSizeItem As BarItem
        Private WithEvents centerImageItem As BarItem
        Private WithEvents normalItem As BarItem
        Private WithEvents stretchItem As BarItem
        Private WithEvents dummyLabel As Label
        Private WithEvents imageList1 As ImageList
        Private WithEvents largeImageList As ImageList
        Private WithEvents popupMenu1 As PopupMenu
        Private WithEvents contextMenuItem As ParentBarItem
        Private WithEvents bar1 As Bar
        Private WithEvents bar2 As Bar
        Private components As IContainer
        Private WithEvents lsmItem As BarItem
        Private WithEvents curSelection As Button
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
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '

        End Sub
        Public Sub New(ByVal sourceFile As String)
            MyBase.New()
            Me.sourceFile = sourceFile
            Me.InitializeComponent()
            instanceCount = (instanceCount + 1)

            Me.Text = ("Image Editor" + instanceCount.ToString)
            ' The SourceFile needs to be set before load gets called.
            Me.InitFromSourceFile()

        End Sub
        Public ReadOnly Property BarManager() As BarManager
            Get

                Return Me.childFrameBarManager1

            End Get
        End Property
        Property LatestSizeModeItem() As BarItem
            Get

                Return Me.lsmItem

            End Get
            Set(ByVal Value As BarItem)

                If (Me.lsmItem Is Value) = False Then
                    If (Not (Me.lsmItem) Is Nothing) Then
                        Me.lsmItem.Checked = False
                    End If
                    Me.lsmItem = Value
                    If (Not (Me.lsmItem) Is Nothing) Then
                        Me.lsmItem.Checked = True
                        Me.StaticBarItem1.Text = "Image Status: " + Me.lsmItem.Text
                    End If
                End If

            End Set
        End Property
        Property CurrentSelection() As Button
            Get

                Return Me.curSelection

            End Get
            Set(ByVal Value As Button)

                If (Me.curSelection Is Value) = False Then
                    If (Not (Me.curSelection) Is Nothing) Then
                        Me.curSelection.BringToFront()
                    End If
                    Me.curSelection = Value
                    If (Not (Me.curSelection) Is Nothing) Then
                        Me.dummyLabel.Location = Me.curSelection.Location
                        Me.dummyLabel.BringToFront()
                    End If
                    Me.UpdatePictureBoxProps()
                End If

            End Set
        End Property
        ReadOnly Property CurAlign() As Integer
            Get

                Return CType(Me.curSelection.Tag, Integer)

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
        Friend WithEvents PopupMenusManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager
        Friend WithEvents Bar3 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Friend WithEvents SaveItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents ParentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents Bar4 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Friend WithEvents StaticBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImageEditorForm))
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.childFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "MainMenu")
            Me.ParentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.SaveItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.horzFilpItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.vertFlipItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.rotate90Item = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.dropDownBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer
            Me.button9 = New System.Windows.Forms.Button
            Me.button8 = New System.Windows.Forms.Button
            Me.button7 = New System.Windows.Forms.Button
            Me.button6 = New System.Windows.Forms.Button
            Me.button5 = New System.Windows.Forms.Button
            Me.button4 = New System.Windows.Forms.Button
            Me.button3 = New System.Windows.Forms.Button
            Me.button2 = New System.Windows.Forms.Button
            Me.button1 = New System.Windows.Forms.Button
            Me.dummyLabel = New System.Windows.Forms.Label
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.autoSizeItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.centerImageItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.normalItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.stretchItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "ImageEditor")
            Me.Bar3 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "Standard")
            Me.Bar4 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childFrameBarManager1, "StatusBar")
            Me.StaticBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.contextMenuItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.largeImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.popupMenu1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
            Me.PopupMenusManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(Me.components)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupControlContainer1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.BackColor = System.Drawing.Color.White
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(408, 218)
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            Me.PopupMenusManager1.SetXPContextMenu(Me.pictureBox1, Me.popupMenu1)
            '
            'childFrameBarManager1
            '
            Me.childFrameBarManager1.BarPositionInfo = CType(resources.GetObject("childFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.childFrameBarManager1.Bars.Add(Me.bar1)
            Me.childFrameBarManager1.Bars.Add(Me.bar2)
            Me.childFrameBarManager1.Bars.Add(Me.Bar3)
            Me.childFrameBarManager1.Bars.Add(Me.Bar4)
            Me.childFrameBarManager1.Categories.Add("File")
            Me.childFrameBarManager1.Categories.Add("Standard")
            Me.childFrameBarManager1.Categories.Add("Edit")
            Me.childFrameBarManager1.Categories.Add("Format")
            Me.childFrameBarManager1.Categories.Add("StatusBar")
            Me.childFrameBarManager1.Categories.Add("ContextMenu")
            Me.childFrameBarManager1.CategoriesToIgnoreInCustDialog.AddRange(New Integer() {6})
            Me.childFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
            Me.childFrameBarManager1.Form = Me
            Me.childFrameBarManager1.FormName = "Image Editor"
            Me.childFrameBarManager1.ImageList = Me.imageList1
            Me.childFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.ParentBarItem4, Me.horzFilpItem, Me.vertFlipItem, Me.rotate90Item, Me.dropDownBarItem1, Me.parentBarItem3, Me.parentBarItem2, Me.contextMenuItem, Me.autoSizeItem, Me.centerImageItem, Me.normalItem, Me.stretchItem, Me.SaveItem, Me.StaticBarItem1})
            Me.childFrameBarManager1.LargeImageList = Me.largeImageList
            Me.childFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'bar1
            '
            Me.bar1.BarName = "MainMenu"
            Me.bar1.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "MainMenu"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.ParentBarItem4, Me.parentBarItem1, Me.parentBarItem3})
            Me.bar1.Manager = Me.childFrameBarManager1
            '
            'ParentBarItem4
            '
            Me.ParentBarItem4.CategoryIndex = 0
            'Me.ParentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.ParentBarItem4.ID = "&File"
            Me.ParentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.SaveItem})
            Me.ParentBarItem4.MergeOrder = 1
            Me.ParentBarItem4.Text = "&File"
            '
            'SaveItem
            '
            Me.SaveItem.CategoryIndex = 1
            'Me.SaveItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.SaveItem.ID = "&Save"
            Me.SaveItem.ImageIndex = 5
            Me.SaveItem.MergeOrder = 2
            Me.SaveItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.SaveItem.Text = "&Save"
            Me.SaveItem.Tooltip = "Save Image (Ctrl + S)"
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 2
            'Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.parentBarItem1.ID = "&Edit"
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.horzFilpItem, Me.vertFlipItem, Me.rotate90Item})
            Me.parentBarItem1.MergeOrder = 2
            Me.parentBarItem1.Text = "&Edit"
            '
            'horzFilpItem
            '
            Me.horzFilpItem.CategoryIndex = 2
            'Me.horzFilpItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.horzFilpItem.ID = "&Horizontal Flip"
            Me.horzFilpItem.ImageIndex = 0
            Me.horzFilpItem.Text = "&Horizontal Flip"
            '
            'vertFlipItem
            '
            Me.vertFlipItem.CategoryIndex = 2
            'Me.vertFlipItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.vertFlipItem.ID = "&Vertical Flip"
            Me.vertFlipItem.ImageIndex = 1
            Me.vertFlipItem.Text = "&Vertical Flip"
            '
            'rotate90Item
            '
            Me.rotate90Item.CategoryIndex = 2
            'Me.rotate90Item.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.rotate90Item.ID = "&Rotate by 90"
            Me.rotate90Item.ImageIndex = 2
            Me.rotate90Item.Text = "&Rotate by 90"
            '
            'parentBarItem3
            '
            Me.parentBarItem3.CategoryIndex = 3
            'Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.parentBarItem3.ID = "Forma&t"
            Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.dropDownBarItem1, Me.parentBarItem2})
            Me.parentBarItem3.MergeOrder = 3
            Me.parentBarItem3.Text = "Forma&t"
            '
            'dropDownBarItem1
            '
            Me.dropDownBarItem1.CategoryIndex = 2
            'Me.dropDownBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.dropDownBarItem1.ID = "Alignment"
            Me.dropDownBarItem1.ImageIndex = 3
            Me.dropDownBarItem1.PopupControlContainer = Me.popupControlContainer1
            Me.dropDownBarItem1.Text = "Alignment"
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.popupControlContainer1.Controls.Add(Me.button9)
            Me.popupControlContainer1.Controls.Add(Me.button8)
            Me.popupControlContainer1.Controls.Add(Me.button7)
            Me.popupControlContainer1.Controls.Add(Me.button6)
            Me.popupControlContainer1.Controls.Add(Me.button5)
            Me.popupControlContainer1.Controls.Add(Me.button4)
            Me.popupControlContainer1.Controls.Add(Me.button3)
            Me.popupControlContainer1.Controls.Add(Me.button2)
            Me.popupControlContainer1.Controls.Add(Me.button1)
            Me.popupControlContainer1.Controls.Add(Me.dummyLabel)
            Me.popupControlContainer1.Location = New System.Drawing.Point(264, 72)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.Size = New System.Drawing.Size(128, 128)
            Me.popupControlContainer1.TabIndex = 4
            Me.popupControlContainer1.Visible = False
            '
            'button9
            '
            Me.button9.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button9.Location = New System.Drawing.Point(88, 88)
            Me.button9.Name = "button9"
            Me.button9.Size = New System.Drawing.Size(32, 32)
            Me.button9.TabIndex = 8
            '
            'button8
            '
            Me.button8.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button8.Location = New System.Drawing.Point(48, 88)
            Me.button8.Name = "button8"
            Me.button8.Size = New System.Drawing.Size(32, 32)
            Me.button8.TabIndex = 7
            '
            'button7
            '
            Me.button7.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button7.Location = New System.Drawing.Point(8, 88)
            Me.button7.Name = "button7"
            Me.button7.Size = New System.Drawing.Size(32, 32)
            Me.button7.TabIndex = 6
            '
            'button6
            '
            Me.button6.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button6.Location = New System.Drawing.Point(88, 48)
            Me.button6.Name = "button6"
            Me.button6.Size = New System.Drawing.Size(32, 32)
            Me.button6.TabIndex = 5
            '
            'button5
            '
            Me.button5.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button5.Location = New System.Drawing.Point(48, 48)
            Me.button5.Name = "button5"
            Me.button5.Size = New System.Drawing.Size(32, 32)
            Me.button5.TabIndex = 4
            '
            'button4
            '
            Me.button4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button4.Location = New System.Drawing.Point(8, 48)
            Me.button4.Name = "button4"
            Me.button4.Size = New System.Drawing.Size(32, 32)
            Me.button4.TabIndex = 3
            '
            'button3
            '
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button3.Location = New System.Drawing.Point(88, 8)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(32, 32)
            Me.button3.TabIndex = 2
            '
            'button2
            '
            Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button2.Location = New System.Drawing.Point(48, 8)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(32, 32)
            Me.button2.TabIndex = 1
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button1.Location = New System.Drawing.Point(8, 8)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(32, 32)
            Me.button1.TabIndex = 0
            '
            'dummyLabel
            '
            Me.dummyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.dummyLabel.Location = New System.Drawing.Point(8, 8)
            Me.dummyLabel.Name = "dummyLabel"
            Me.dummyLabel.Size = New System.Drawing.Size(32, 32)
            Me.dummyLabel.TabIndex = 9
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 2
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.parentBarItem2.ID = "SizeMode"
            Me.parentBarItem2.ImageIndex = 4
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.autoSizeItem, Me.centerImageItem, Me.normalItem, Me.stretchItem})
            Me.parentBarItem2.ParentStyle = Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItemStyle.DropDown
            Me.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem2.Text = "SizeMode"
            '
            'autoSizeItem
            '
            Me.autoSizeItem.CategoryIndex = 3
            Me.autoSizeItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.autoSizeItem.ID = "Auto Size"
            Me.autoSizeItem.Text = "Auto Size"
            '
            'centerImageItem
            '
            Me.centerImageItem.CategoryIndex = 3
            Me.centerImageItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.centerImageItem.ID = "Center Image"
            Me.centerImageItem.Text = "Center Image"
            '
            'normalItem
            '
            Me.normalItem.CategoryIndex = 3
            Me.normalItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.normalItem.ID = "Normal"
            Me.normalItem.Text = "Normal"
            '
            'stretchItem
            '
            Me.stretchItem.CategoryIndex = 3
            Me.stretchItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.stretchItem.ID = "Stretch Image"
            Me.stretchItem.Text = "Stretch Image"
            '
            'bar2
            '
            Me.bar2.BarName = "ImageEditor"
            Me.bar2.Caption = "ImageEditor"
            Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.horzFilpItem, Me.vertFlipItem, Me.rotate90Item, Me.dropDownBarItem1, Me.parentBarItem2})
            Me.bar2.Manager = Me.childFrameBarManager1
            Me.bar2.SeparatorIndices.AddRange(New Integer() {3})
            '
            'Bar3
            '
            Me.Bar3.BarName = "Standard"
            Me.Bar3.BarStyle = CType((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.Bar3.Caption = "Standard"
            Me.Bar3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.SaveItem})
            Me.Bar3.Manager = Me.childFrameBarManager1
            '
            'Bar4
            '
            Me.Bar4.BarName = "StatusBar"
            Me.Bar4.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsStatusBar), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.Bar4.Caption = "StatusBar"
            Me.Bar4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.StaticBarItem1})
            Me.Bar4.Manager = Me.childFrameBarManager1
            '
            'StaticBarItem1
            '
            Me.StaticBarItem1.CategoryIndex = 4
            Me.StaticBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.StaticBarItem1.FlatBorderColor = System.Drawing.SystemColors.GrayText
            Me.StaticBarItem1.ID = "Image Status:"
            Me.StaticBarItem1.Text = "Image Status:"
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
            '
            'contextMenuItem
            '
            Me.contextMenuItem.CategoryIndex = 5
            Me.contextMenuItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.contextMenuItem.ID = "ContextMenu"
            Me.contextMenuItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem3})
            Me.contextMenuItem.Text = "ContextMenu"
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
            '
            'popupMenu1
            '
            Me.popupMenu1.ParentBarItem = Me.contextMenuItem
            '
            'ImageEditorForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.ClientSize = New System.Drawing.Size(408, 218)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "ImageEditorForm"
            Me.Text = "Image Editor"
            Me.PopupMenusManager1.SetXPContextMenu(Me, Me.popupMenu1)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.childFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupControlContainer1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private Sub ImageEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            Me.button1.Tag = 1
            Me.button2.Tag = 2
            Me.button3.Tag = 3
            Me.button4.Tag = 4
            Me.button5.Tag = 5
            Me.button6.Tag = 6
            Me.button7.Tag = 7
            Me.button8.Tag = 8
            Me.button9.Tag = 9
            Me.normalItem.Tag = System.Enum.GetName(GetType(PictureBoxSizeMode), PictureBoxSizeMode.Normal)
            Me.centerImageItem.Tag = System.Enum.GetName(GetType(PictureBoxSizeMode), PictureBoxSizeMode.CenterImage)
            Me.stretchItem.Tag = System.Enum.GetName(GetType(PictureBoxSizeMode), PictureBoxSizeMode.StretchImage)
            Me.autoSizeItem.Tag = System.Enum.GetName(GetType(PictureBoxSizeMode), PictureBoxSizeMode.AutoSize)
            Me.curSelection = Me.button1
            Me.SizeModeChanged(Me.autoSizeItem, EventArgs.Empty)
            Me.CurrentSelection = Me.button5

        End Sub
        Private Sub InitFromSourceFile()

            If (Me.sourceFile Is String.Empty) = False Then
                Try
                    Me.sourceImage = Image.FromFile(Me.sourceFile, True)
                    Me.pictureBox1.Image = Me.sourceImage
                Catch e As Exception
                    Throw e
                End Try
            End If

        End Sub
        Private Sub horzFilpItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles horzFilpItem.Click

            Me.sourceImage.RotateFlip(RotateFlipType.RotateNoneFlipX)
            Me.pictureBox1.Invalidate()
            Me.UpdatePictureBoxProps()

        End Sub
        Private Sub vertFlipItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vertFlipItem.Click

            Me.sourceImage.RotateFlip(RotateFlipType.RotateNoneFlipY)
            Me.pictureBox1.Invalidate()
            Me.UpdatePictureBoxProps()

        End Sub
        Private Sub rotate90Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rotate90Item.Click

            Me.sourceImage.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Me.pictureBox1.Size = Me.sourceImage.Size
            Me.pictureBox1.Invalidate()
            Me.UpdatePictureBoxProps()

        End Sub
        Private Sub AlignSelected(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button9.Click, button8.Click, button7.Click, button6.Click, button5.Click, button4.Click, button3.Click, button2.Click, button1.Click

            Me.popupControlContainer1.HidePopup(PopupCloseType.Done)
            Me.autoSizeItem.PerformClick()
            Me.CurrentSelection = CType(sender, Button)

        End Sub
        Private Sub SizeModeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autoSizeItem.Click, centerImageItem.Click, normalItem.Click, stretchItem.Click

            Try
                Dim barItem As BarItem
                barItem = CType(sender, BarItem)
                Me.pictureBox1.SizeMode = CType(System.Enum.Parse(GetType(PictureBoxSizeMode), CType(barItem.Tag, String)), PictureBoxSizeMode)
                Me.LatestSizeModeItem = CType(sender, BarItem)
            Catch ex As System.Exception
            End Try
            UpdatePictureBoxProps()

        End Sub
        Private Sub UpdatePictureBoxProps()

            If (Me.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize) Then
                Select Case Me.CurAlign
                    Case 1
                        Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
                        Me.pictureBox1.Anchor = AnchorStyles.None
                        'End Section
                    Case 2
                        Me.pictureBox1.Location = New System.Drawing.Point(((Me.ClientRectangle.Width / 2) _
                                        - (Me.pictureBox1.Width / 2)), 0)
                        Me.pictureBox1.Anchor = AnchorStyles.Right
                        'End Section
                    Case 3
                        Me.pictureBox1.Location = New System.Drawing.Point((Me.ClientRectangle.Width - Me.pictureBox1.Width), 0)
                        Me.pictureBox1.Anchor = AnchorStyles.Right
                        'End Section
                    Case 4
                        Me.pictureBox1.Location = New System.Drawing.Point(0, ((Me.ClientRectangle.Height / 2) _
                                        - (Me.pictureBox1.Height / 2)))
                        Me.pictureBox1.Anchor = AnchorStyles.Bottom
                        'End Section
                    Case 5
                        Me.pictureBox1.Location = New System.Drawing.Point(((Me.ClientRectangle.Width / 2) _
                                        - (Me.pictureBox1.Width / 2)), ((Me.ClientRectangle.Height / 2) _
                                        - (Me.pictureBox1.Height / 2)))
                        Me.pictureBox1.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
                        'End Section
                    Case 6
                        Me.pictureBox1.Location = New System.Drawing.Point((Me.ClientRectangle.Width - Me.pictureBox1.Width), ((Me.ClientRectangle.Height / 2) _
                                        - (Me.pictureBox1.Height / 2)))
                        Me.pictureBox1.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
                        'End Section
                    Case 7
                        Me.pictureBox1.Location = New System.Drawing.Point(0, (Me.ClientRectangle.Height - Me.pictureBox1.Height))
                        Me.pictureBox1.Anchor = AnchorStyles.Bottom
                        'End Section
                    Case 8
                        Me.pictureBox1.Location = New System.Drawing.Point(((Me.ClientRectangle.Width / 2) _
                                        - (Me.pictureBox1.Width / 2)), (Me.ClientRectangle.Height - Me.pictureBox1.Height))
                        Me.pictureBox1.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
                        'End Section
                    Case 9
                        Me.pictureBox1.Location = New System.Drawing.Point((Me.ClientRectangle.Width - Me.pictureBox1.Width), (Me.ClientRectangle.Height - Me.pictureBox1.Height))
                        Me.pictureBox1.Anchor = (AnchorStyles.Right Or AnchorStyles.Bottom)
                        'End Section
                End Select
            Else
                Me.pictureBox1.Anchor = AnchorStyles.None
                Me.pictureBox1.Dock = DockStyle.Fill
            End If

        End Sub
        Private Sub ImageEditorForm_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

            Me.UpdatePictureBoxProps()

        End Sub

        Private Sub SaveItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveItem.Click
            Dim filename As String = ""
            Dim savefDlg As SaveFileDialog = New SaveFileDialog()
            savefDlg.Filter = "Image Files (*.bmp; *.gif; *.jpg)|*.bmp;*.gif;*.jpg|All Files (*.*)|*.*"
            If (savefDlg.ShowDialog = Windows.Forms.DialogResult.OK) Then
                filename = savefDlg.FileName
                Me.pictureBox1.Image.Save(filename)
            End If
        End Sub
    End Class
End Namespace
