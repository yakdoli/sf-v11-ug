Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Reflection
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms
Imports Microsoft.Win32

Namespace WindowFill
	''' <summary>
	''' Summary description for frmMain.
	''' </summary>
    Public Class frmMain : Inherits Office2007Form
#Region "Members declaration"
        Private ilCommon As System.Windows.Forms.ImageList
        Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
        Private dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
        Private components As System.ComponentModel.IContainer
        Private xPTtaskMenuBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
        Private taskMenuBox3 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
        Private panel1 As System.Windows.Forms.Panel
        Private button1 As System.Windows.Forms.Button
        Private comboBox1 As System.Windows.Forms.ComboBox
        Private label2 As System.Windows.Forms.Label
        Private textBox1 As System.Windows.Forms.TextBox
        Private label1 As System.Windows.Forms.Label
        Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private Tasks As Syncfusion.Windows.Forms.Tools.XPTaskBar
        Private Items As System.Windows.Forms.ListView
        Private Description As System.Windows.Forms.RichTextBox
        Private Category As System.Windows.Forms.TreeView
        Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private WithEvents comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Private lstlistBox1 As System.Windows.Forms.ListBox
        Private WithEvents barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private treeview1 As TreeView
        Private aboutForm As DemoCommon.AboutForm

#End Region
#Region "Initialisation"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '

            InitializeComponent()

            AddHandler comboBoxBarItem1.Click, AddressOf comboBoxBarItem1_Click
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub

        Private Sub comboBoxBarItem1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Select Case comboBoxBarItem1.TextBoxValue

                Case "Office2003"
                    dockingManager1.VisualStyle = VisualStyle.Office2003
                Case "WindowsXPThemes"
                    dockingManager1.VisualStyle = VisualStyle.Default
                    dockingManager1.ThemesEnabled = True
                Case "Office2007"
                    dockingManager1.VisualStyle = VisualStyle.Office2007
                Case "VS2005"
                    dockingManager1.VisualStyle = VisualStyle.VS2005

                Case "Default"
                    dockingManager1.VisualStyle = VisualStyle.Default

            End Select
        End Sub

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


#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DVD", 1, 1)
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CD/DVD Drives", New System.Windows.Forms.TreeNode() {TreeNode1})
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("80GB", 2, 2)
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hard disk", 3, 3, New System.Windows.Forms.TreeNode() {TreeNode3})
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Laser", 7, 7)
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Printers", 8, 8, New System.Windows.Forms.TreeNode() {TreeNode5})
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Webcam", 10, 10)
            Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Camera", 11, 11, New System.Windows.Forms.TreeNode() {TreeNode7})
            Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"CD Drive"}, 24, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(226, Byte), Integer)), New System.Drawing.Font("Microsoft Sans Serif", 9.75!))
            Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"HDD 80GB"}, 2, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(226, Byte), Integer)), New System.Drawing.Font("Microsoft Sans Serif", 9.75!))
            Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Camera"}, 9, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(226, Byte), Integer)), New System.Drawing.Font("Microsoft Sans Serif", 9.75!))
            Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Webcam"}, 10, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(226, Byte), Integer)), New System.Drawing.Font("Microsoft Sans Serif", 9.75!))
            Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"DVD Writer"}, 1, System.Drawing.SystemColors.WindowText, System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(226, Byte), Integer)), New System.Drawing.Font("Microsoft Sans Serif", 9.75!))
            Me.ilCommon = New System.Windows.Forms.ImageList(Me.components)
            Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Main")
            Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "VisualStyles")
            Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.lstlistBox1 = New System.Windows.Forms.ListBox
            Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.Category = New System.Windows.Forms.TreeView
            Me.Tasks = New Syncfusion.Windows.Forms.Tools.XPTaskBar
            Me.taskMenuBox3 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.button1 = New System.Windows.Forms.Button
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label2 = New System.Windows.Forms.Label
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.label1 = New System.Windows.Forms.Label
            Me.xPTtaskMenuBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox
            Me.Items = New System.Windows.Forms.ListView
            Me.Description = New System.Windows.Forms.RichTextBox
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Tasks, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Tasks.SuspendLayout()
            Me.taskMenuBox3.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'ilCommon
            '
            Me.ilCommon.ImageStream = CType(resources.GetObject("ilCommon.ImageStream"), System.Windows.Forms.ImageListStreamer)
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
            '
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.AutoLoadToolBarPositions = False
            Me.mainFrameBarManager1.AutoPersistCustomization = False
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.bar1)
            Me.mainFrameBarManager1.Bars.Add(Me.bar2)
            Me.mainFrameBarManager1.Categories.Add("File")
            Me.mainFrameBarManager1.Categories.Add("VisualStyle")
            Me.mainFrameBarManager1.Categories.Add("Format")
            Me.mainFrameBarManager1.Categories.Add("View")
            Me.mainFrameBarManager1.Categories.Add("Popups")
            Me.mainFrameBarManager1.Categories.Add("Help")
            Me.mainFrameBarManager1.Categories.Add("Misc")
            Me.mainFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
            Me.mainFrameBarManager1.EnableCustomizing = False
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.ImageList = Nothing
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.barItem1, Me.parentBarItem2, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5, Me.parentBarItem3, Me.comboBoxBarItem1, Me.barItem6, Me.barItem7})
            Me.mainFrameBarManager1.LargeImageList = Nothing
            Me.mainFrameBarManager1.ResetCustomization = False
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'bar1
            '
            Me.bar1.BarName = "Main"
            Me.bar1.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "Main"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem3, Me.parentBarItem2, Me.parentBarItem1})
            Me.bar1.Manager = Me.mainFrameBarManager1
            '
            'parentBarItem3
            '
            Me.parentBarItem3.CategoryIndex = 0
            Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem3.ID = "File"
            Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem5})
            Me.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem3.Text = "File"
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 0
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "Close"
            Me.barItem5.Text = "Close"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 1
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "VisualStyle"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem2, Me.barItem3, Me.barItem6, Me.barItem4, Me.barItem7})
            Me.parentBarItem2.Text = "VisualStyle"
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 1
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "Default"
            Me.barItem2.Text = "Default"
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 1
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "Office2003"
            Me.barItem3.Text = "Office2003"
            '
            'barItem6
            '
            Me.barItem6.CategoryIndex = 1
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem6.ID = "Office2007"
            Me.barItem6.Text = "Office2007"
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 1
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "Windows XP themes"
            Me.barItem4.Text = "Windows XP themes"
            '
            'barItem7
            '
            Me.barItem7.CategoryIndex = 1
            Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem7.ID = "VS2005"
            Me.barItem7.Text = "VS2005"
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 5
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "Help"
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1})
            Me.parentBarItem1.Text = "Help"
            '
            'barItem1
            '
            Me.barItem1.CategoryIndex = 5
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem1.ID = "About Syncfusion"
            Me.barItem1.Text = "About Syncfusion"
            '
            'bar2
            '
            Me.bar2.BarName = "VisualStyles"
            Me.bar2.BarStyle = Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible
            Me.bar2.Caption = "VisualStyles"
            Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.comboBoxBarItem1})
            Me.bar2.Manager = Me.mainFrameBarManager1
            '
            'comboBoxBarItem1
            '
            Me.comboBoxBarItem1.CategoryIndex = 1
            Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxBarItem1.Editable = False
            Me.comboBoxBarItem1.ID = "VisualStyle_1"
            Me.comboBoxBarItem1.ListBox = Me.lstlistBox1
            Me.comboBoxBarItem1.MinWidth = 150
            Me.comboBoxBarItem1.Text = "VisualStyle"
            Me.comboBoxBarItem1.TextBoxValue = "Office2007"
            '
            'lstlistBox1
            '
            Me.lstlistBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lstlistBox1.ItemHeight = 16
            Me.lstlistBox1.Items.AddRange(New Object() {"Default", "Office2003", "Office2007", "WindowsXPThemes", "VS2005"})
            Me.lstlistBox1.Location = New System.Drawing.Point(128, 192)
            Me.lstlistBox1.Name = "lstlistBox1"
            Me.lstlistBox1.Size = New System.Drawing.Size(144, 52)
            Me.lstlistBox1.TabIndex = 18
            '
            'dockingManager1
            '
            Me.dockingManager1.ActiveCaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
            Me.dockingManager1.DisallowFloating = True
            Me.dockingManager1.DockLayoutStream = CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream)
            Me.dockingManager1.DockToFill = True
            Me.dockingManager1.HostControl = Me
            Me.dockingManager1.ImageList = Me.ilCommon
            Me.dockingManager1.InActiveCaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
            Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.dockingManager1.SetDockLabel(Me.Description, "Description")
            Me.dockingManager1.SetDockIcon(Me.Description, 5)
            Me.dockingManager1.SetDockLabel(Me.Items, "Items")
            Me.dockingManager1.SetDockIcon(Me.Items, 23)
            Me.dockingManager1.SetDockLabel(Me.Tasks, "Tasks")
            Me.dockingManager1.SetDockLabel(Me.Category, "Category")
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
            '
            'Category
            '
            Me.Category.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dockingManager1.SetEnableDocking(Me.Category, True)
            Me.Category.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
            Me.Category.ImageIndex = 0
            Me.Category.ImageList = Me.ilCommon
            Me.Category.Location = New System.Drawing.Point(3, 23)
            Me.Category.Name = "Category"
            TreeNode1.ImageIndex = 1
            TreeNode1.Name = ""
            TreeNode1.SelectedImageIndex = 1
            TreeNode1.Text = "DVD"
            TreeNode2.Name = ""
            TreeNode2.Text = "CD/DVD Drives"
            TreeNode3.ImageIndex = 2
            TreeNode3.Name = ""
            TreeNode3.SelectedImageIndex = 2
            TreeNode3.Text = "80GB"
            TreeNode4.ImageIndex = 3
            TreeNode4.Name = ""
            TreeNode4.SelectedImageIndex = 3
            TreeNode4.Text = "Hard disk"
            TreeNode5.ImageIndex = 7
            TreeNode5.Name = ""
            TreeNode5.SelectedImageIndex = 7
            TreeNode5.Text = "Laser"
            TreeNode6.ImageIndex = 8
            TreeNode6.Name = ""
            TreeNode6.SelectedImageIndex = 8
            TreeNode6.Text = "Printers"
            TreeNode7.ImageIndex = 10
            TreeNode7.Name = ""
            TreeNode7.SelectedImageIndex = 10
            TreeNode7.Text = "Webcam"
            TreeNode8.ImageIndex = 11
            TreeNode8.Name = ""
            TreeNode8.SelectedImageIndex = 11
            TreeNode8.Text = "Camera"
            Me.Category.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode4, TreeNode6, TreeNode8})
            Me.Category.SelectedImageIndex = 0
            Me.Category.Size = New System.Drawing.Size(207, 356)
            Me.Category.TabIndex = 7
            '
            'Tasks
            '
            Me.Tasks.AutoPersistStates = True
            Me.Tasks.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(213, Byte), Integer))
            Me.Tasks.Controls.Add(Me.taskMenuBox3)
            Me.Tasks.Controls.Add(Me.xPTtaskMenuBox1)
            Me.dockingManager1.SetEnableDocking(Me.Tasks, True)
            Me.Tasks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
            Me.Tasks.Location = New System.Drawing.Point(3, 23)
            Me.Tasks.MinimumSize = New System.Drawing.Size(0, 0)
            Me.Tasks.Name = "Tasks"
            Me.Tasks.Padding = New System.Windows.Forms.Padding(10)
            Me.Tasks.Size = New System.Drawing.Size(207, 356)
            Me.Tasks.TabIndex = 9
            Me.Tasks.VerticalPadding = 20
            '
            'taskMenuBox3
            '
            Me.taskMenuBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.taskMenuBox3.Controls.Add(Me.panel1)
            Me.taskMenuBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.taskMenuBox3.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(158, Byte), Integer))
            Me.taskMenuBox3.HeaderForeColor = System.Drawing.Color.WhiteSmoke
            Me.taskMenuBox3.HeaderImageIndex = -1
            Me.taskMenuBox3.HitTaskBoxArea = False
            Me.taskMenuBox3.ItemBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.taskMenuBox3.Location = New System.Drawing.Point(10, 10)
            Me.taskMenuBox3.Name = "taskMenuBox3"
            Me.taskMenuBox3.PreferredChildPanelHeight = 120
            Me.taskMenuBox3.Size = New System.Drawing.Size(187, 151)
            Me.taskMenuBox3.TabIndex = 2
            Me.taskMenuBox3.Text = "Search"
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.textBox1)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
            Me.panel1.Location = New System.Drawing.Point(2, 29)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(183, 120)
            Me.panel1.TabIndex = 0
            '
            'button1
            '
            Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
            Me.button1.Location = New System.Drawing.Point(40, 80)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(88, 24)
            Me.button1.TabIndex = 4
            Me.button1.Text = "Search"
            '
            'comboBox1
            '
            Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
            Me.comboBox1.Items.AddRange(New Object() {"C#", "VB", "C++"})
            Me.comboBox1.Location = New System.Drawing.Point(78, 41)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(100, 24)
            Me.comboBox1.TabIndex = 3
            Me.comboBox1.Text = "comboBox1"
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
            Me.label2.Location = New System.Drawing.Point(0, 41)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(64, 16)
            Me.label2.TabIndex = 2
            Me.label2.Text = "Category:"
            '
            'textBox1
            '
            Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
            Me.textBox1.Location = New System.Drawing.Point(78, 8)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(100, 22)
            Me.textBox1.TabIndex = 1
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(0, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(75, 24)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Keywords:"
            '
            'xPTtaskMenuBox1
            '
            Me.xPTtaskMenuBox1.BackColor = System.Drawing.Color.White
            Me.xPTtaskMenuBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
            Me.xPTtaskMenuBox1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(158, Byte), Integer))
            Me.xPTtaskMenuBox1.HeaderForeColor = System.Drawing.Color.WhiteSmoke
            Me.xPTtaskMenuBox1.HeaderImageIndex = -1
            Me.xPTtaskMenuBox1.HitTaskBoxArea = False
            Me.xPTtaskMenuBox1.ItemBackColor = System.Drawing.Color.White
            Me.xPTtaskMenuBox1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() {New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results by Customer Name", System.Drawing.SystemColors.ActiveCaption, 22, Nothing, "about items", True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sort search results by Customer ID", System.Drawing.Color.Empty, 23, Nothing, "about drawing", True, True, "", New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), 0)})
            Me.xPTtaskMenuBox1.Location = New System.Drawing.Point(10, 181)
            Me.xPTtaskMenuBox1.Name = "xPTtaskMenuBox1"
            Me.xPTtaskMenuBox1.Size = New System.Drawing.Size(187, 133)
            Me.xPTtaskMenuBox1.TabIndex = 1
            Me.xPTtaskMenuBox1.Text = "Sort Categories"
            '
            'Items
            '
            Me.Items.AllowColumnReorder = True
            Me.Items.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.dockingManager1.SetEnableDocking(Me.Items, True)
            Me.Items.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
            ListViewItem3.UseItemStyleForSubItems = False
            Me.Items.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5})
            Me.Items.LargeImageList = Me.ilCommon
            Me.Items.Location = New System.Drawing.Point(3, 23)
            Me.Items.Name = "Items"
            Me.Items.Size = New System.Drawing.Size(397, 129)
            Me.Items.TabIndex = 5
            Me.Items.UseCompatibleStateImageBehavior = False
            '
            'Description
            '
            Me.Description.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(233, Byte), Integer))
            Me.dockingManager1.SetEnableDocking(Me.Description, True)
            Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Description.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
            Me.Description.Location = New System.Drawing.Point(3, 23)
            Me.Description.Name = "Description"
            Me.Description.Size = New System.Drawing.Size(397, 221)
            Me.Description.TabIndex = 4
            Me.Description.Text = "Use the DockingManager.DockToFill mode to create forms comprising entirely of doc" & _
                "kable windows. Controls can be made non-floatable by setting the DockingManager." & _
                "DisallowFloating property."
            '
            'frmMain
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(632, 462)
            Me.Controls.Add(Me.lstlistBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmMain"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Window Fill"
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Tasks, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Tasks.ResumeLayout(False)
            Me.taskMenuBox3.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New frmMain())
        End Sub
#End Region
#Region "Event handlers"
        Private Sub barItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem1.Click
            aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
            aboutForm.ShowDialog()
        End Sub

        Private Sub barItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem2.Click
            dockingManager1.ThemesEnabled = False
            dockingManager1.VisualStyle = VisualStyle.Default
            Me.comboBoxBarItem1.TextBoxValue = "Default"
        End Sub

        Private Sub barItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem3.Click
            dockingManager1.VisualStyle = VisualStyle.Office2003
            Me.comboBoxBarItem1.TextBoxValue = "Office2003"
        End Sub

        Private Sub barItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem4.Click
            dockingManager1.VisualStyle = VisualStyle.Default
            dockingManager1.ThemesEnabled = True
            Me.comboBoxBarItem1.TextBoxValue = "WindowsXPThemes"
        End Sub
        Private Sub barItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem6.Click
            dockingManager1.VisualStyle = VisualStyle.Office2007
            Me.comboBoxBarItem1.TextBoxValue = "Office2007"
        End Sub
        Private Sub barItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem7.Click
            dockingManager1.VisualStyle = VisualStyle.VS2005
            Me.comboBoxBarItem1.TextBoxValue = "VS2005"
        End Sub
        Private Sub comboBoxBarItem1_Selected(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBoxBarItem1.Selected

        End Sub
#End Region

        Private Sub barItem5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItem5.Click
            Application.Exit()
        End Sub
    End Class
End Namespace
