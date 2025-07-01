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
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Microsoft.Win32
Namespace SDIDemo
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
    Public Class Form1 : Inherits Office2007Form
#Region "Members declaration"
        Private WithEvents dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
        Private dockingClientPanel1 As Syncfusion.Windows.Forms.Tools.DockingClientPanel
        Private WithEvents listBox1 As System.Windows.Forms.ListBox
        Private textBox1 As System.Windows.Forms.TextBox
        Private WithEvents treeView1 As System.Windows.Forms.TreeView
        Private label1 As System.Windows.Forms.Label
        Private WithEvents cboDockLabel As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private label4 As System.Windows.Forms.Label
        Private WithEvents cboDrag As System.Windows.Forms.ComboBox
        Private label5 As System.Windows.Forms.Label
        Private WithEvents cboBrowsingKey As System.Windows.Forms.ComboBox
        Private checkedListBox1 As System.Windows.Forms.CheckedListBox
        Private checkedListBox2 As System.Windows.Forms.CheckedListBox
        Private components As System.ComponentModel.IContainer
        Private toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
        Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
        Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
        Private tabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
        Private tabPageAdv4 As Syncfusion.Windows.Forms.Tools.TabPageAdv
        Private textBox2 As System.Windows.Forms.TextBox
        Private WithEvents cbAutoHide As System.Windows.Forms.CheckBox
        Private radioButton1 As System.Windows.Forms.RadioButton
        Private rbLBMF As System.Windows.Forms.RadioButton
        Private rbTVTB As System.Windows.Forms.RadioButton
        Private rbLBTB As System.Windows.Forms.RadioButton
        Private rbLBTV As System.Windows.Forms.RadioButton
        Private WithEvents listBox2 As System.Windows.Forms.ListBox
        Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private panel1 As System.Windows.Forms.Panel
        Private label6 As System.Windows.Forms.Label
        Private panel2 As System.Windows.Forms.Panel
        Private label7 As System.Windows.Forms.Label
        Private panel3 As System.Windows.Forms.Panel
        Private label8 As System.Windows.Forms.Label
        Private panel4 As System.Windows.Forms.Panel
        Private label9 As System.Windows.Forms.Label
        Private label10 As System.Windows.Forms.Label
        Private WithEvents cboVisualStyle As System.Windows.Forms.ComboBox
        Private label11 As System.Windows.Forms.Label
        Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private WithEvents comboBoxBase1 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents checkedListBox3 As CheckedListBox
        Private selectedIndex As Integer = 0

#End Region
#Region "Initialization"
        Public Sub New()
            '
            ' Required for Windows Form Designer support.
            '


            InitializeComponent()

            InitEvents(Me.dockingManager1)
            Me.toolTip1.SetToolTip(Me.listBox2, "Press Ctrl+Delete to clear the event logs")
            Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            AddDockControlsToList()
            '
            ' TODO: Add any  constructor code after InitializeComponent call.
            '
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
        Friend WithEvents ilDocking As System.Windows.Forms.ImageList
        Friend WithEvents cbClose As System.Windows.Forms.CheckBox
        Friend WithEvents cbPaint As System.Windows.Forms.CheckBox
        Friend WithEvents cbContextMenu As System.Windows.Forms.CheckBox
        Friend WithEvents cbAuto As System.Windows.Forms.CheckBox
        Friend WithEvents cbTreeView As System.Windows.Forms.CheckBox
        Friend WithEvents cbTextBox As System.Windows.Forms.CheckBox
        Friend WithEvents cbListBox As System.Windows.Forms.CheckBox
        Friend WithEvents cbCheckedList As System.Windows.Forms.CheckBox
        Friend WithEvents cbfreezeresize As System.Windows.Forms.CheckBox
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim ccblistBox1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbtextBox1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbtreeView1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbcheckedListBox1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbcheckedListBox2 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Enable docking")
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Setting dock edge")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Making tabbed windows ")
            Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Setting as floaing")
            Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DesignTimeSupport", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4})
            Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DockAllow event")
            Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dragallow event")
            Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DockVisibilityChanging event")
            Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Events architecture", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
            Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DockToFill mode")
            Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Dissallow Floating")
            Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Docking diamond")
            Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DockTab settings")
            Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customization options", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13})
            Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Extensible ")
            Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DockingManager", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode9, TreeNode14, TreeNode15})
            Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.ilDocking = New System.Windows.Forms.ImageList(Me.components)
            Me.listBox1 = New System.Windows.Forms.ListBox
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.treeView1 = New System.Windows.Forms.TreeView
            Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox
            Me.checkedListBox2 = New System.Windows.Forms.CheckedListBox
            Me.dockingClientPanel1 = New Syncfusion.Windows.Forms.Tools.DockingClientPanel
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.panel2 = New System.Windows.Forms.Panel
            Me.cbfreezeresize = New System.Windows.Forms.CheckBox
            Me.cbClose = New System.Windows.Forms.CheckBox
            Me.cbPaint = New System.Windows.Forms.CheckBox
            Me.cbContextMenu = New System.Windows.Forms.CheckBox
            Me.cbAuto = New System.Windows.Forms.CheckBox
            Me.label7 = New System.Windows.Forms.Label
            Me.cbAutoHide = New System.Windows.Forms.CheckBox
            Me.panel1 = New System.Windows.Forms.Panel
            Me.label6 = New System.Windows.Forms.Label
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.rbLBMF = New System.Windows.Forms.RadioButton
            Me.rbTVTB = New System.Windows.Forms.RadioButton
            Me.rbLBTB = New System.Windows.Forms.RadioButton
            Me.rbLBTV = New System.Windows.Forms.RadioButton
            Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.panel4 = New System.Windows.Forms.Panel
            Me.cbCheckedList = New System.Windows.Forms.CheckBox
            Me.cbTreeView = New System.Windows.Forms.CheckBox
            Me.cbTextBox = New System.Windows.Forms.CheckBox
            Me.cbListBox = New System.Windows.Forms.CheckBox
            Me.label9 = New System.Windows.Forms.Label
            Me.panel3 = New System.Windows.Forms.Panel
            Me.comboBoxBase1 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase
            Me.checkedListBox3 = New System.Windows.Forms.CheckedListBox
            Me.label2 = New System.Windows.Forms.Label
            Me.cboVisualStyle = New System.Windows.Forms.ComboBox
            Me.label10 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.cboBrowsingKey = New System.Windows.Forms.ComboBox
            Me.label5 = New System.Windows.Forms.Label
            Me.cboDrag = New System.Windows.Forms.ComboBox
            Me.label4 = New System.Windows.Forms.Label
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.cboDockLabel = New System.Windows.Forms.ComboBox
            Me.label3 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.tabPageAdv4 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.listBox2 = New System.Windows.Forms.ListBox
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label11 = New System.Windows.Forms.Label
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockingClientPanel1.SuspendLayout()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            Me.tabPageAdv2.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.tabPageAdv3.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.panel3.SuspendLayout()
            CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageAdv4.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dockingManager1
            '
            Me.dockingManager1.DockLayoutStream = CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream)
            Me.dockingManager1.ForwardMenuShortcuts = False
            Me.dockingManager1.HostControl = Me
            Me.dockingManager1.ImageList = Me.ilDocking
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
            Me.dockingManager1.SetDockLabel(Me.listBox1, "Docking features")
            Me.dockingManager1.SetDockIcon(Me.listBox1, 1)
            ccblistBox1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.listBox1, ccblistBox1)
            Me.dockingManager1.SetDockLabel(Me.textBox1, "Description")
            Me.dockingManager1.SetDockIcon(Me.textBox1, 2)
            ccbtextBox1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.textBox1, ccbtextBox1)
            Me.dockingManager1.SetDockLabel(Me.treeView1, "DockingManager")
            Me.dockingManager1.SetDockIcon(Me.treeView1, 4)
            ccbtreeView1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.treeView1, ccbtreeView1)
            Me.dockingManager1.SetDockLabel(Me.checkedListBox1, "DockController classes")
            Me.dockingManager1.SetDockIcon(Me.checkedListBox1, 3)
            ccbcheckedListBox1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.checkedListBox1, ccbcheckedListBox1)
            Me.dockingManager1.SetDockLabel(Me.checkedListBox2, "Docking classes")
            Me.dockingManager1.SetDockIcon(Me.checkedListBox2, 5)
            ccbcheckedListBox2.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.checkedListBox2, ccbcheckedListBox2)
            '
            'ilDocking
            '
            Me.ilDocking.ImageStream = CType(resources.GetObject("ilDocking.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.ilDocking.TransparentColor = System.Drawing.Color.Transparent
            Me.ilDocking.Images.SetKeyName(0, "")
            Me.ilDocking.Images.SetKeyName(1, "")
            Me.ilDocking.Images.SetKeyName(2, "")
            Me.ilDocking.Images.SetKeyName(3, "")
            Me.ilDocking.Images.SetKeyName(4, "")
            Me.ilDocking.Images.SetKeyName(5, "")
            '
            'listBox1
            '
            Me.listBox1.BackColor = System.Drawing.Color.White
            Me.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dockingManager1.SetEnableDocking(Me.listBox1, True)
            Me.listBox1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.listBox1.IntegralHeight = False
            Me.listBox1.ItemHeight = 15
            Me.listBox1.Items.AddRange(New Object() {"VS.Net Type Docking windows", "Tabbed Docking", "Nested docking", "Floating windows", "Floating  with tabbed controls.", "Nested Docking in a Floating window.", "AutoHideMode", "Docking Diamonds", "State persistence", "Customization", "And much more..."})
            Me.listBox1.Location = New System.Drawing.Point(1, 19)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(110, 428)
            Me.listBox1.TabIndex = 5
            '
            'textBox1
            '
            Me.textBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dockingManager1.SetEnableDocking(Me.textBox1, True)
            Me.textBox1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.textBox1.ForeColor = System.Drawing.Color.Black
            Me.textBox1.Location = New System.Drawing.Point(1, 19)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.ReadOnly = True
            Me.textBox1.Size = New System.Drawing.Size(339, 87)
            Me.textBox1.TabIndex = 6
            Me.textBox1.Text = "Docking manager"
            '
            'treeView1
            '
            Me.treeView1.BackColor = System.Drawing.Color.Azure
            Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.dockingManager1.SetEnableDocking(Me.treeView1, True)
            Me.treeView1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.treeView1.Location = New System.Drawing.Point(1, 19)
            Me.treeView1.Name = "treeView1"
            TreeNode1.Name = ""
            TreeNode1.Text = "Enable docking"
            TreeNode2.Name = ""
            TreeNode2.Text = "Setting dock edge"
            TreeNode3.Name = ""
            TreeNode3.Text = "Making tabbed windows "
            TreeNode4.Name = ""
            TreeNode4.Text = "Setting as floaing"
            TreeNode5.Name = ""
            TreeNode5.Text = "DesignTimeSupport"
            TreeNode6.Name = ""
            TreeNode6.Text = "DockAllow event"
            TreeNode7.Name = ""
            TreeNode7.Text = "Dragallow event"
            TreeNode8.Name = ""
            TreeNode8.Text = "DockVisibilityChanging event"
            TreeNode9.Name = ""
            TreeNode9.Text = "Events architecture"
            TreeNode10.Name = ""
            TreeNode10.Text = "DockToFill mode"
            TreeNode11.Name = ""
            TreeNode11.Text = "Dissallow Floating"
            TreeNode12.Name = ""
            TreeNode12.Text = "Docking diamond"
            TreeNode13.Name = ""
            TreeNode13.Text = "DockTab settings"
            TreeNode14.Name = ""
            TreeNode14.Text = "Customization options"
            TreeNode15.Name = ""
            TreeNode15.Text = "Extensible "
            TreeNode16.Name = ""
            TreeNode16.Text = "DockingManager"
            Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode16})
            Me.treeView1.Scrollable = False
            Me.treeView1.Size = New System.Drawing.Size(100, 428)
            Me.treeView1.TabIndex = 11
            '
            'checkedListBox1
            '
            Me.checkedListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.dockingManager1.SetEnableDocking(Me.checkedListBox1, True)
            Me.checkedListBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkedListBox1.Items.AddRange(New Object() {"DockHostController", "DockTabController", "FloatingFormController", "MainFormController", "DockControllerBase"})
            Me.checkedListBox1.Location = New System.Drawing.Point(1, 19)
            Me.checkedListBox1.Name = "checkedListBox1"
            Me.checkedListBox1.Size = New System.Drawing.Size(356, 52)
            Me.checkedListBox1.TabIndex = 13
            '
            'checkedListBox2
            '
            Me.checkedListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(245, Byte), Integer))
            Me.dockingManager1.SetEnableDocking(Me.checkedListBox2, True)
            Me.checkedListBox2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.checkedListBox2.Items.AddRange(New Object() {"DockingManager", "DockHost", "DockTabControl", "DockTabPage", "FloatingForm", "AHTabControl", "AHTabPage", "FloatingForm", "DockingWrapperForm"})
            Me.checkedListBox2.Location = New System.Drawing.Point(1, 19)
            Me.checkedListBox2.Name = "checkedListBox2"
            Me.checkedListBox2.Size = New System.Drawing.Size(356, 52)
            Me.checkedListBox2.TabIndex = 15
            '
            'dockingClientPanel1
            '
            Me.dockingClientPanel1.Controls.Add(Me.tabControlAdv1)
            Me.dockingClientPanel1.Controls.Add(Me.gradientPanel2)
            Me.dockingClientPanel1.Location = New System.Drawing.Point(106, 0)
            Me.dockingClientPanel1.Name = "dockingClientPanel1"
            Me.dockingClientPanel1.Size = New System.Drawing.Size(481, 448)
            Me.dockingClientPanel1.SizeToFit = True
            Me.dockingClientPanel1.TabIndex = 4
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv3)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv4)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.tabControlAdv1.FocusOnTabClick = False
            Me.tabControlAdv1.InactiveTabColor = System.Drawing.Color.SeaShell
            Me.tabControlAdv1.ItemSize = New System.Drawing.Size(25, 22)
            Me.tabControlAdv1.Location = New System.Drawing.Point(0, 57)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Padding = New System.Drawing.Point(6, 1)
            Me.tabControlAdv1.Size = New System.Drawing.Size(481, 391)
            Me.tabControlAdv1.TabGap = 10
            Me.tabControlAdv1.TabIndex = 2
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(237, Byte), Integer))
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            '
            'tabPageAdv1
            '
            Me.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(177, Byte), Integer))
            Me.tabPageAdv1.Controls.Add(Me.textBox2)
            Me.tabPageAdv1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 29)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.Size = New System.Drawing.Size(478, 360)
            Me.tabPageAdv1.TabFont = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "Introduction"
            Me.tabPageAdv1.ThemesEnabled = False
            Me.toolTip1.SetToolTip(Me.tabPageAdv1, "Gives a brief introduction about the usage of DockingClientPanel")
            '
            'textBox2
            '
            Me.textBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.textBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer))
            Me.textBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(134, Byte), Integer))
            Me.textBox2.Location = New System.Drawing.Point(8, 8)
            Me.textBox2.Multiline = True
            Me.textBox2.Name = "textBox2"
            Me.textBox2.ReadOnly = True
            Me.textBox2.Size = New System.Drawing.Size(464, 342)
            Me.textBox2.TabIndex = 1
            Me.textBox2.Text = resources.GetString("textBox2.Text")
            '
            'tabPageAdv2
            '
            Me.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(177, Byte), Integer))
            Me.tabPageAdv2.Controls.Add(Me.gradientPanel1)
            Me.tabPageAdv2.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.tabPageAdv2.Location = New System.Drawing.Point(1, 29)
            Me.tabPageAdv2.Name = "tabPageAdv2"
            Me.tabPageAdv2.Size = New System.Drawing.Size(478, 348)
            Me.tabPageAdv2.TabIndex = 1
            Me.tabPageAdv2.Text = "Behavior"
            Me.tabPageAdv2.ThemesEnabled = False
            Me.toolTip1.SetToolTip(Me.tabPageAdv2, "Contain options to change the behaviour of docking")
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(177, Byte), Integer))
            Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel1.Controls.Add(Me.panel2)
            Me.gradientPanel1.Controls.Add(Me.panel1)
            Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel1.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(478, 348)
            Me.gradientPanel1.TabIndex = 4
            '
            'panel2
            '
            Me.panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer))
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.cbfreezeresize)
            Me.panel2.Controls.Add(Me.cbClose)
            Me.panel2.Controls.Add(Me.cbPaint)
            Me.panel2.Controls.Add(Me.cbContextMenu)
            Me.panel2.Controls.Add(Me.cbAuto)
            Me.panel2.Controls.Add(Me.label7)
            Me.panel2.Controls.Add(Me.cbAutoHide)
            Me.panel2.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.panel2.Location = New System.Drawing.Point(237, 27)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(224, 280)
            Me.panel2.TabIndex = 6
            '
            'cbfreezeresize
            '
            Me.cbfreezeresize.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbfreezeresize.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbfreezeresize.Location = New System.Drawing.Point(24, 236)
            Me.cbfreezeresize.Name = "cbfreezeresize"
            Me.cbfreezeresize.Size = New System.Drawing.Size(120, 24)
            Me.cbfreezeresize.TabIndex = 16
            Me.cbfreezeresize.Text = "Freeze resizing"
            '
            'cbClose
            '
            Me.cbClose.Checked = True
            Me.cbClose.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbClose.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbClose.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbClose.Location = New System.Drawing.Point(24, 160)
            Me.cbClose.Name = "cbClose"
            Me.cbClose.Size = New System.Drawing.Size(120, 24)
            Me.cbClose.TabIndex = 13
            Me.cbClose.Text = "Close Enabled"
            '
            'cbPaint
            '
            Me.cbPaint.Checked = True
            Me.cbPaint.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbPaint.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbPaint.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbPaint.Location = New System.Drawing.Point(24, 130)
            Me.cbPaint.Name = "cbPaint"
            Me.cbPaint.Size = New System.Drawing.Size(120, 24)
            Me.cbPaint.TabIndex = 12
            Me.cbPaint.Text = "Paint Border"
            '
            'cbContextMenu
            '
            Me.cbContextMenu.Checked = True
            Me.cbContextMenu.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbContextMenu.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbContextMenu.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbContextMenu.Location = New System.Drawing.Point(24, 200)
            Me.cbContextMenu.Name = "cbContextMenu"
            Me.cbContextMenu.Size = New System.Drawing.Size(120, 24)
            Me.cbContextMenu.TabIndex = 15
            Me.cbContextMenu.Text = "Context Menu"
            '
            'cbAuto
            '
            Me.cbAuto.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbAuto.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbAuto.Location = New System.Drawing.Point(24, 90)
            Me.cbAuto.Name = "cbAuto"
            Me.cbAuto.Size = New System.Drawing.Size(154, 24)
            Me.cbAuto.TabIndex = 14
            Me.cbAuto.Text = "Themes Enabled"
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label7.Location = New System.Drawing.Point(28, 16)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(112, 24)
            Me.label7.TabIndex = 4
            Me.label7.Text = "State Attributes"
            '
            'cbAutoHide
            '
            Me.cbAutoHide.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbAutoHide.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbAutoHide.Location = New System.Drawing.Point(24, 57)
            Me.cbAutoHide.Name = "cbAutoHide"
            Me.cbAutoHide.Size = New System.Drawing.Size(144, 24)
            Me.cbAutoHide.TabIndex = 3
            Me.cbAutoHide.Text = "Disable AutoHide"
            '
            'panel1
            '
            Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer))
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.label6)
            Me.panel1.Controls.Add(Me.radioButton1)
            Me.panel1.Controls.Add(Me.rbLBMF)
            Me.panel1.Controls.Add(Me.rbTVTB)
            Me.panel1.Controls.Add(Me.rbLBTB)
            Me.panel1.Controls.Add(Me.rbLBTV)
            Me.panel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.panel1.Location = New System.Drawing.Point(8, 27)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(223, 280)
            Me.panel1.TabIndex = 5
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer))
            Me.label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.Location = New System.Drawing.Point(0, 11)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(203, 29)
            Me.label6.TabIndex = 5
            Me.label6.Text = "Docking Customization"
            Me.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'radioButton1
            '
            Me.radioButton1.Checked = True
            Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.radioButton1.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.radioButton1.Location = New System.Drawing.Point(9, 250)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(168, 24)
            Me.radioButton1.TabIndex = 4
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Allow All"
            '
            'rbLBMF
            '
            Me.rbLBMF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.rbLBMF.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.rbLBMF.Location = New System.Drawing.Point(9, 200)
            Me.rbLBMF.Name = "rbLBMF"
            Me.rbLBMF.Size = New System.Drawing.Size(194, 44)
            Me.rbLBMF.TabIndex = 3
            Me.rbLBMF.Text = "Disallow ListBox-MainForm"
            '
            'rbTVTB
            '
            Me.rbTVTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.rbTVTB.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.rbTVTB.Location = New System.Drawing.Point(9, 149)
            Me.rbTVTB.Name = "rbTVTB"
            Me.rbTVTB.Size = New System.Drawing.Size(194, 45)
            Me.rbTVTB.TabIndex = 2
            Me.rbTVTB.Text = "Disallow TreeView-TextBox"
            '
            'rbLBTB
            '
            Me.rbLBTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.rbLBTB.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.rbLBTB.Location = New System.Drawing.Point(9, 90)
            Me.rbLBTB.Name = "rbLBTB"
            Me.rbLBTB.Size = New System.Drawing.Size(194, 53)
            Me.rbLBTB.TabIndex = 1
            Me.rbLBTB.Text = "Disallow ListBox-TextBox"
            '
            'rbLBTV
            '
            Me.rbLBTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.rbLBTV.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.rbLBTV.Location = New System.Drawing.Point(9, 43)
            Me.rbLBTV.Name = "rbLBTV"
            Me.rbLBTV.Size = New System.Drawing.Size(194, 53)
            Me.rbLBTV.TabIndex = 0
            Me.rbLBTV.Text = "Disallow ListBox-TreeView"
            '
            'tabPageAdv3
            '
            Me.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(177, Byte), Integer))
            Me.tabPageAdv3.Controls.Add(Me.panel4)
            Me.tabPageAdv3.Controls.Add(Me.panel3)
            Me.tabPageAdv3.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.tabPageAdv3.Location = New System.Drawing.Point(1, 29)
            Me.tabPageAdv3.Name = "tabPageAdv3"
            Me.tabPageAdv3.Size = New System.Drawing.Size(478, 348)
            Me.tabPageAdv3.TabIndex = 2
            Me.tabPageAdv3.Text = "Miscellaneous"
            Me.tabPageAdv3.ThemesEnabled = False
            Me.toolTip1.SetToolTip(Me.tabPageAdv3, "Contain customization options")
            '
            'panel4
            '
            Me.panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer))
            Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel4.Controls.Add(Me.cbCheckedList)
            Me.panel4.Controls.Add(Me.cbTreeView)
            Me.panel4.Controls.Add(Me.cbTextBox)
            Me.panel4.Controls.Add(Me.cbListBox)
            Me.panel4.Controls.Add(Me.label9)
            Me.panel4.Font = New System.Drawing.Font("Calibri", 12.0!)
            Me.panel4.Location = New System.Drawing.Point(8, 265)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(464, 70)
            Me.panel4.TabIndex = 17
            '
            'cbCheckedList
            '
            Me.cbCheckedList.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbCheckedList.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbCheckedList.Location = New System.Drawing.Point(47, 45)
            Me.cbCheckedList.Name = "cbCheckedList"
            Me.cbCheckedList.Size = New System.Drawing.Size(191, 24)
            Me.cbCheckedList.TabIndex = 13
            Me.cbCheckedList.Text = "Hide CheckedListBox"
            '
            'cbTreeView
            '
            Me.cbTreeView.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbTreeView.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbTreeView.Location = New System.Drawing.Point(264, 18)
            Me.cbTreeView.Name = "cbTreeView"
            Me.cbTreeView.Size = New System.Drawing.Size(144, 24)
            Me.cbTreeView.TabIndex = 11
            Me.cbTreeView.Text = "Hide TreeView"
            '
            'cbTextBox
            '
            Me.cbTextBox.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbTextBox.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbTextBox.Location = New System.Drawing.Point(264, 45)
            Me.cbTextBox.Name = "cbTextBox"
            Me.cbTextBox.Size = New System.Drawing.Size(144, 24)
            Me.cbTextBox.TabIndex = 12
            Me.cbTextBox.Text = "Hide TextBox"
            '
            'cbListBox
            '
            Me.cbListBox.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.cbListBox.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cbListBox.Location = New System.Drawing.Point(47, 18)
            Me.cbListBox.Name = "cbListBox"
            Me.cbListBox.Size = New System.Drawing.Size(144, 24)
            Me.cbListBox.TabIndex = 10
            Me.cbListBox.Text = "Hide ListBox"
            '
            'label9
            '
            Me.label9.Dock = System.Windows.Forms.DockStyle.Top
            Me.label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.Location = New System.Drawing.Point(0, 0)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(462, 15)
            Me.label9.TabIndex = 9
            Me.label9.Text = "Visibility"
            Me.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'panel3
            '
            Me.panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer))
            Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel3.Controls.Add(Me.comboBoxBase1)
            Me.panel3.Controls.Add(Me.label2)
            Me.panel3.Controls.Add(Me.cboVisualStyle)
            Me.panel3.Controls.Add(Me.label10)
            Me.panel3.Controls.Add(Me.label8)
            Me.panel3.Controls.Add(Me.cboBrowsingKey)
            Me.panel3.Controls.Add(Me.label5)
            Me.panel3.Controls.Add(Me.cboDrag)
            Me.panel3.Controls.Add(Me.label4)
            Me.panel3.Controls.Add(Me.comboBox1)
            Me.panel3.Controls.Add(Me.cboDockLabel)
            Me.panel3.Controls.Add(Me.label3)
            Me.panel3.Controls.Add(Me.label1)
            Me.panel3.Controls.Add(Me.checkedListBox3)
            Me.panel3.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.panel3.Location = New System.Drawing.Point(8, 8)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(464, 251)
            Me.panel3.TabIndex = 16
            '
            'comboBoxBase1
            '
            Me.comboBoxBase1.BackColor = System.Drawing.Color.White
            Me.comboBoxBase1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBoxBase1.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
            Me.comboBoxBase1.IgnoreThemeBackground = True
            Me.comboBoxBase1.ListControl = Me.checkedListBox3
            Me.comboBoxBase1.Location = New System.Drawing.Point(196, 204)
            Me.comboBoxBase1.Name = "comboBoxBase1"
            Me.comboBoxBase1.Size = New System.Drawing.Size(160, 21)
            Me.comboBoxBase1.SuppressDropDownEvent = False
            Me.comboBoxBase1.TabIndex = 15
            '
            'checkedListBox3
            '
            Me.checkedListBox3.BackColor = System.Drawing.Color.White
            Me.checkedListBox3.FormattingEnabled = True
            Me.checkedListBox3.Location = New System.Drawing.Point(277, -76)
            Me.checkedListBox3.Name = "checkedListBox3"
            Me.checkedListBox3.Size = New System.Drawing.Size(160, 89)
            Me.checkedListBox3.TabIndex = 12
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(44, 204)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(136, 32)
            Me.label2.TabIndex = 14
            Me.label2.Text = "Set Freeze/UnFreeze " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to DockedControls"
            '
            'cboVisualStyle
            '
            Me.cboVisualStyle.BackColor = System.Drawing.Color.White
            Me.cboVisualStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboVisualStyle.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cboVisualStyle.Items.AddRange(New Object() {"Default", "Office2003", "OfficeXP", "Office2007", "VS2005"})
            Me.cboVisualStyle.Location = New System.Drawing.Point(196, 167)
            Me.cboVisualStyle.Name = "cboVisualStyle"
            Me.cboVisualStyle.Size = New System.Drawing.Size(160, 24)
            Me.cboVisualStyle.TabIndex = 10
            '
            'label10
            '
            Me.label10.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.label10.Location = New System.Drawing.Point(44, 167)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(120, 24)
            Me.label10.TabIndex = 9
            Me.label10.Text = "Visual Style"
            '
            'label8
            '
            Me.label8.Dock = System.Windows.Forms.DockStyle.Top
            Me.label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.Location = New System.Drawing.Point(0, 0)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(462, 24)
            Me.label8.TabIndex = 8
            Me.label8.Text = "General Properties"
            Me.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'cboBrowsingKey
            '
            Me.cboBrowsingKey.BackColor = System.Drawing.Color.White
            Me.cboBrowsingKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboBrowsingKey.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cboBrowsingKey.Items.AddRange(New Object() {"Back", "Del", "End", "Enter", "F1", "F10", "F11", "F12", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "Home", "Insert", "PgDn", "PgUp"})
            Me.cboBrowsingKey.Location = New System.Drawing.Point(196, 134)
            Me.cboBrowsingKey.Name = "cboBrowsingKey"
            Me.cboBrowsingKey.Size = New System.Drawing.Size(160, 24)
            Me.cboBrowsingKey.TabIndex = 7
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.label5.Location = New System.Drawing.Point(44, 134)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(120, 24)
            Me.label5.TabIndex = 6
            Me.label5.Text = "BrowsingKey"
            '
            'cboDrag
            '
            Me.cboDrag.BackColor = System.Drawing.Color.White
            Me.cboDrag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDrag.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cboDrag.Items.AddRange(New Object() {"Standard", "VS2005", "Whidbey"})
            Me.cboDrag.Location = New System.Drawing.Point(196, 97)
            Me.cboDrag.Name = "cboDrag"
            Me.cboDrag.Size = New System.Drawing.Size(160, 24)
            Me.cboDrag.TabIndex = 5
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.label4.Location = New System.Drawing.Point(44, 100)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(120, 24)
            Me.label4.TabIndex = 4
            Me.label4.Text = "Drag Provider Style"
            '
            'comboBox1
            '
            Me.comboBox1.BackColor = System.Drawing.Color.White
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.comboBox1.Items.AddRange(New Object() {"Top", "Bottom", "Left", "Right"})
            Me.comboBox1.Location = New System.Drawing.Point(196, 67)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(160, 24)
            Me.comboBox1.TabIndex = 3
            '
            'cboDockLabel
            '
            Me.cboDockLabel.BackColor = System.Drawing.Color.White
            Me.cboDockLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboDockLabel.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.cboDockLabel.Items.AddRange(New Object() {"Center", "Default", "Left", "Right"})
            Me.cboDockLabel.Location = New System.Drawing.Point(196, 34)
            Me.cboDockLabel.Name = "cboDockLabel"
            Me.cboDockLabel.Size = New System.Drawing.Size(160, 24)
            Me.cboDockLabel.TabIndex = 1
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.label3.Location = New System.Drawing.Point(44, 67)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(120, 24)
            Me.label3.TabIndex = 2
            Me.label3.Text = "DockTab Alignment"
            '
            'label1
            '
            Me.label1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label1.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.label1.Location = New System.Drawing.Point(44, 34)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(138, 24)
            Me.label1.TabIndex = 0
            Me.label1.Text = "DockLabel Alignment"
            '
            'tabPageAdv4
            '
            Me.tabPageAdv4.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(177, Byte), Integer))
            Me.tabPageAdv4.Controls.Add(Me.listBox2)
            Me.tabPageAdv4.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.tabPageAdv4.Location = New System.Drawing.Point(1, 29)
            Me.tabPageAdv4.Name = "tabPageAdv4"
            Me.tabPageAdv4.Size = New System.Drawing.Size(478, 348)
            Me.tabPageAdv4.TabIndex = 3
            Me.tabPageAdv4.Text = "Events Log"
            Me.tabPageAdv4.ThemesEnabled = False
            Me.toolTip1.SetToolTip(Me.tabPageAdv4, "Displays the information about the events fired")
            '
            'listBox2
            '
            Me.listBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.listBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer))
            Me.listBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.listBox2.HorizontalScrollbar = True
            Me.listBox2.IntegralHeight = False
            Me.listBox2.ItemHeight = 16
            Me.listBox2.Location = New System.Drawing.Point(8, 8)
            Me.listBox2.Name = "listBox2"
            Me.listBox2.Size = New System.Drawing.Size(464, 330)
            Me.listBox2.TabIndex = 1
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(245, Byte), Integer)))
            Me.gradientPanel2.BorderColor = System.Drawing.Color.Black
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanel2.Controls.Add(Me.label11)
            Me.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gradientPanel2.Location = New System.Drawing.Point(0, 0)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(481, 448)
            Me.gradientPanel2.TabIndex = 3
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(244, Byte), Integer))
            Me.label11.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.label11.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label11.ForeColor = System.Drawing.Color.Black
            Me.label11.Location = New System.Drawing.Point(0, 0)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(481, 448)
            Me.label11.TabIndex = 2
            Me.label11.Text = "Syncfusion Docking Windows"
            Me.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'toolTip1
            '
            Me.toolTip1.AutomaticDelay = 0
            Me.toolTip1.ShowAlways = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(177, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(703, 559)
            Me.Controls.Add(Me.dockingClientPanel1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SDI Demo"
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockingClientPanel1.ResumeLayout(False)
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            Me.tabPageAdv1.PerformLayout()
            Me.tabPageAdv2.ResumeLayout(False)
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.tabPageAdv3.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageAdv4.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Public Shared Sub Main()
            Application.Run(New Form1())
        End Sub
#End Region
#Region "Event handlers-DockingManager"
        Private Sub dockingManager1_DockAllow(ByVal sender As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.DockAllowEventArgs) Handles dockingManager1.DockAllow
            If Me.rbLBTB.Checked = True Then
                ' Disallow docking the list box to the text box. 
                ' If the list box or the text box are either of the dock event's 
                ' DragControl or the TargetControl, then cancel the dock operation.
                If ((arg.DragControl Is Me.listBox1) OrElse (arg.TargetControl Is Me.listBox1)) AndAlso ((arg.DragControl Is Me.textBox1) OrElse (arg.TargetControl Is Me.textBox1)) Then
                    arg.Cancel = True
                End If

            End If

            If Me.rbLBTV.Checked = True Then
                If ((arg.DragControl Is Me.listBox1) OrElse (arg.TargetControl Is Me.listBox1)) AndAlso ((arg.DragControl Is Me.treeView1) OrElse (arg.TargetControl Is Me.treeView1)) Then
                    arg.Cancel = True
                End If
            End If

            If Me.rbTVTB.Checked = True Then
                If ((arg.DragControl Is Me.treeView1) OrElse (arg.TargetControl Is Me.treeView1)) AndAlso ((arg.DragControl Is Me.textBox1) OrElse (arg.TargetControl Is Me.textBox1)) Then
                    arg.Cancel = True
                End If
            End If

            If Me.rbLBMF.Checked = True Then
                ' Disallow docking the list box to the application's main form. 
                ' In this case, the list box will be the DragControl and the main form 
                ' will be TargetControl. If this is True, then cancel the operation.
                If (arg.DragControl Is Me.listBox1) AndAlso (arg.TargetControl Is Me) Then
                    arg.Cancel = True
                End If
            End If
        End Sub
        Private Sub dockingManager1_DockVisibilityChanged(ByVal sender As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.DockVisibilityChangedEventArgs) Handles dockingManager1.DockVisibilityChanged
            ' Based on the control dockvisibility state and sets the state for the check boxes.
            If arg.Control Is Me.listBox1 Then
                Me.cbListBox.Checked = Not Me.dockingManager1.GetDockVisibility(Me.listBox1)
            End If
            If arg.Control Is Me.treeView1 Then
                Me.cbTreeView.Checked = Not Me.dockingManager1.GetDockVisibility(Me.treeView1)
            End If
            If arg.Control Is Me.textBox1 Then
                Me.cbTextBox.Checked = Not Me.dockingManager1.GetDockVisibility(Me.textBox1)
            End If
        End Sub

#End Region

#Region "Setting Dock Label property"
        Private Sub cboDockLabel_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDockLabel.SelectedIndexChanged

            'Sets the DockLabelAlignment Property
            Select Case CStr(Me.cboDockLabel.SelectedItem)
                Case "Left"
                    Me.dockingManager1.DockLabelAlignment = Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Left
                Case "Right"
                    Me.dockingManager1.DockLabelAlignment = Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Right
                Case "Center"
                    Me.dockingManager1.DockLabelAlignment = Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Center
                Case "Default"
                    Me.dockingManager1.DockLabelAlignment = Syncfusion.Windows.Forms.Tools.DockLabelAlignmentStyle.Default
            End Select

        End Sub
#End Region

#Region "Setting Dock Tab Alignment property"

        Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
            'Sets Dock Tab Alignment Property
            Select Case CStr(Me.comboBox1.SelectedItem)

                Case "Left"
                    Me.dockingManager1.DockTabAlignment = Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Left
                Case "Right"
                    Me.dockingManager1.DockTabAlignment = Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Right
                Case "Top"
                    Me.dockingManager1.DockTabAlignment = Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Top
                Case "Bottom"
                    Me.dockingManager1.DockTabAlignment = Syncfusion.Windows.Forms.Tools.DockTabAlignmentStyle.Bottom
            End Select

        End Sub
#End Region

#Region "Setting DragProvider Style for Docking Manager"
        Private Sub cboDrag_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDrag.SelectedIndexChanged
            'Sets Dragprovider Style Property
            Select Case CStr(Me.cboDrag.SelectedItem)

                Case "Standard"
                    Me.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Standard
                Case "VS2005"
                    Me.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.VS2005
                Case "Whidbey"
                    Me.dockingManager1.DragProviderStyle = Syncfusion.Windows.Forms.Tools.DragProviderStyle.Whidbey

            End Select
        End Sub
#End Region

#Region "Setting Browsing key for Docking windows"
        Private Sub cboBrowsingKey_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboBrowsingKey.SelectedIndexChanged
            'Sets Docking windows Browsing Key property
            Select Case CStr(Me.cboBrowsingKey.SelectedItem)

                Case "PgDn"
                    Me.dockingManager1.BrowsingKey = (CType(System.Enum.Parse(GetType(Keys), "Next"), System.Windows.Forms.Keys))
                Case "PgUp"
                    Me.dockingManager1.BrowsingKey = (CType(System.Enum.Parse(GetType(Keys), "Prior"), System.Windows.Forms.Keys))
                Case "Del"
                    Me.dockingManager1.BrowsingKey = (CType(System.Enum.Parse(GetType(Keys), "Delete"), System.Windows.Forms.Keys))

                Case Else
                    Me.dockingManager1.BrowsingKey = (CType(System.Enum.Parse(GetType(Keys), CStr(Me.cboBrowsingKey.SelectedItem)), System.Windows.Forms.Keys))
            End Select



        End Sub
#End Region

#Region "State Attributes changed events"
        Private Sub cbPaint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbPaint.CheckedChanged
            ' Show/Hides the Border of the docking window
            Me.dockingManager1.PaintBorders = Me.cbPaint.Checked

        End Sub

        Private Sub cbClose_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbClose.CheckedChanged
            Me.dockingManager1.CloseEnabled = Me.cbClose.Checked

        End Sub

        Private Sub cbAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAuto.CheckedChanged
            Me.dockingManager1.ThemesEnabled = Me.cbAuto.Checked
        End Sub

        Private Sub cbContextMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbContextMenu.CheckedChanged
            Me.dockingManager1.EnableContextMenu = Me.cbContextMenu.Checked
        End Sub
#End Region

#Region "Initialize Docking Manager Events"
        Public Sub InitEvents(ByVal dm As DockingManager)
            AddHandler dm.AutoHideAnimationStart, AddressOf dm_AutoHideAnimationStart
            AddHandler dm.AutoHideAnimationStop, AddressOf dm_AutoHideAnimationStop
            AddHandler dm.DockAllow, AddressOf dm_DockAllow
            AddHandler dm.DockContextMenu, AddressOf dm_DockContextMenu
            AddHandler dm.DockControlActivated, AddressOf dm_DockControlActivated
            AddHandler dm.DockControlDeactivated, AddressOf dm_DockControlDeactivated
            AddHandler dm.DockMenuClick, AddressOf dm_DockMenuClick
            AddHandler dm.DockStateChanged, AddressOf dm_DockStateChanged
            AddHandler dm.DockStateChanging, AddressOf dm_DockStateChanging
            AddHandler dm.DockStateUnavailable, AddressOf dm_DockStateUnavailable
            AddHandler dm.DockVisibilityChanged, AddressOf dm_DockVisibilityChanged
            AddHandler dm.DockVisibilityChanging, AddressOf dm_DockVisibilityChanging
            AddHandler dm.DragAllow, AddressOf dm_DragAllow
            AddHandler dm.DragFeedbackStart, AddressOf dm_DragFeedbackStart
            AddHandler dm.DragFeedbackStop, AddressOf dm_DragFeedbackStop
            AddHandler dm.ImageListChanged, AddressOf dm_ImageListChanged
            AddHandler dm.InitializeControlOnLoad, AddressOf dm_InitializeControlOnLoad
            AddHandler dm.NewDockStateBeginLoad, AddressOf dm_NewDockStateBeginLoad
            AddHandler dm.NewDockStateEndLoad, AddressOf dm_NewDockStateEndLoad
            AddHandler dm.ProvideGraphicsItems, AddressOf dm_ProvideGraphicsItems
            AddHandler dm.ProvidePersistenceID, AddressOf dm_ProvidePersistenceID
            AddHandler dm.TransferredToManager, AddressOf dm_TransferredToManager
            AddHandler dm.TransferringFromManager, AddressOf dm_TransferringFromManager
        End Sub
#End Region   'Initialize Events

#Region "Standard Docking Manager Events"

        'The AutoHideAnimationStart event occurs just before the start of an autohide animation.
        Private Sub dm_AutoHideAnimationStart(ByVal sender As Object, ByVal arg As AutoHideAnimationEventArgs)
            selectedIndex = Me.listBox2.Items.Add("AutoHide Animation Start - " + arg.Control.Name)
            SetIndex(selectedIndex)

        End Sub

        'The AutoHideAnimationStop event occurs immediately after the end of an autohide animation.
        Private Sub dm_AutoHideAnimationStop(ByVal sender As Object, ByVal arg As AutoHideAnimationEventArgs)
            selectedIndex = listBox2.Items.Add("AutoHide Animation Stop - " + arg.Control.Name)
            SetIndex(selectedIndex)
        End Sub

        'The DockAllow event occurs when a docking window is dragged over a potential dock target.
        Private Sub dm_DockAllow(ByVal sender As Object, ByVal arg As DockAllowEventArgs)
            selectedIndex = listBox2.Items.Add("Dock Allow Event - " + "Drag Control - [" + arg.DragControl.Name + "], Target Control - [" + arg.TargetControl.Name + "], Docking Style  - [" + arg.DockStyle.ToString() + "]")
            SetIndex(selectedIndex)
        End Sub

        'The DockContextMenu event occurs when the right mouse button is clicked over a docking window's caption.
        Private Sub dm_DockContextMenu(ByVal sender As Object, ByVal arg As DockContextMenuEventArgs)
            selectedIndex = listBox2.Items.Add("Dock Context Menu - Owner control [" + arg.Owner.Name + "]")
            SetIndex(selectedIndex)
        End Sub

        'The DockControlActivated event occurs when a dockable control gets activated.
        Private Sub dm_DockControlActivated(ByVal sender As Object, ByVal arg As DockActivationChangedEventArgs)
            selectedIndex = listBox2.Items.Add("Dock Control Activated - [" + arg.Control.Name + "]")
            SetIndex(selectedIndex)

        End Sub

        'The DockControlDeactivated event occurs when a dockable control gets deactivated.
        Private Sub dm_DockControlDeactivated(ByVal sender As Object, ByVal arg As DockActivationChangedEventArgs)
            selectedIndex = listBox2.Items.Add("Dock Control Deactivated - [" + arg.Control.Name + "]")
            SetIndex(selectedIndex)
        End Sub

        '
        Private Sub dm_DockMenuClick(ByVal sender As Object, ByVal arg As DockMenuClickEventArgs)
            selectedIndex = listBox2.Items.Add("Dock Menu Click Event - [" + arg.Control.Name + "]" + " Docking Style [" + arg.DockingStyle.ToString() + "]")
            SetIndex(selectedIndex)
        End Sub

        'The DockStateChanged event occurs immediately after a dock operation.
        Private Sub dm_DockStateChanged(ByVal sender As Object, ByVal arg As DockStateChangeEventArgs)
            selectedIndex = listBox2.Items.Add("Dock State Changed - [" + arg.Controls(0).Name + "]")
            SetIndex(selectedIndex)
        End Sub

        'The DockStateChanging event occurs just before a dock operation takes place.
        Private Sub dm_DockStateChanging(ByVal sender As Object, ByVal arg As DockStateChangeEventArgs)
            selectedIndex = listBox2.Items.Add("Dock State Changing - [" + arg.Controls(0).Name + "]")
            SetIndex(selectedIndex)
        End Sub

        'The DockStateUnavailable event occurs if serialized information is not available for a dockable control when loading a persisted dock state.
        Private Sub dm_DockStateUnavailable(ByVal sender As Object, ByVal arg As DockStateUnavailableEventArgs)
            selectedIndex = listBox2.Items.Add("Dock State Unavailable - [" + arg.Control.Name + "]")
            SetIndex(selectedIndex)
        End Sub

        'The DockVisibilityChanged event occurs after a control's DockVisibility state has changed.
        Private Sub dm_DockVisibilityChanged(ByVal sender As Object, ByVal arg As DockVisibilityChangedEventArgs)
            selectedIndex = listBox2.Items.Add("Dock Visibility Changed - [" + arg.Control.Name + "]")
            SetIndex(selectedIndex)
        End Sub

        'The DockVisibilityChanging event occurs during a control's DockVisibility state is changing.
        Private Sub dm_DockVisibilityChanging(ByVal sender As Object, ByVal arg As DockVisibilityChangingEventArgs)
            selectedIndex = listBox2.Items.Add("Dock Visibility Changing - [" + arg.Control.Name + "]")
            SetIndex(selectedIndex)
        End Sub

        'The DragAllow event occurs when a docking window is about to be dragged.
        Private Sub dm_DragAllow(ByVal sender As Object, ByVal arg As DragAllowEventArgs)
            selectedIndex = listBox2.Items.Add("Drag Allow Event - [" + arg.Control.Name + "]")
            SetIndex(selectedIndex)
        End Sub

        'The DragFeedbackStart event occurs just before the start of feedback of a drag operation.
        Private Sub dm_DragFeedbackStart(ByVal sender As Object, ByVal e As EventArgs)
            selectedIndex = listBox2.Items.Add("Drag Feedback Start")
            SetIndex(selectedIndex)
        End Sub

        'The DragFeedbackStop event occurs immediately after the end of feedback of a drag operation.
        Private Sub dm_DragFeedbackStop(ByVal sender As Object, ByVal e As EventArgs)
            selectedIndex = listBox2.Items.Add("Drag Feedback Stop")
            SetIndex(selectedIndex)
        End Sub

        ' Occurs when the ImageList property changes.
        Private Sub dm_ImageListChanged(ByVal sender As Object, ByVal e As EventArgs)
            selectedIndex = listBox2.Items.Add("Image List Changed")
            SetIndex(selectedIndex)
        End Sub

        'The InitializeControlOnLoad event occurs when the DockingManager is not able to locate a control during a LoadDockState call.
        Private Sub dm_InitializeControlOnLoad(ByVal sender As Object, ByVal arg As InitializeControlOnLoadEventArgs)
            selectedIndex = listBox2.Items.Add("Initialize Control On Load - [" + arg.ControlName + "]")
            SetIndex(selectedIndex)
        End Sub

        'The NewDockStateBeginLoad event occurs just before a new dock state is loaded.
        Private Sub dm_NewDockStateBeginLoad(ByVal sender As Object, ByVal e As EventArgs)
            selectedIndex = listBox2.Items.Add("New Dock State Begin Load")
            SetIndex(selectedIndex)
        End Sub

        'The NewDockStateEndLoad event occurs immediately after a new dock state has been loaded.
        Private Sub dm_NewDockStateEndLoad(ByVal sender As Object, ByVal e As EventArgs)
            selectedIndex = listBox2.Items.Add("New Dock State End Load")
            SetIndex(selectedIndex)
        End Sub

        'The ProvideGraphicsItems event occurs whenever a dockable control's caption needs to be painted.
        Private Sub dm_ProvideGraphicsItems(ByVal sender As Object, ByVal arg As ProvideGraphicsItemsEventArgs)
            If (IsDBNull(arg.Control)) Then
                selectedIndex = listBox2.Items.Add("Provide Graphics Items - [" + arg.Control.Name + "]")
                SetIndex(selectedIndex)
            End If
        End Sub

        'Lets you specify a unique ID used to distinguish the persistence information of different instances of the Form type.
        Private Sub dm_ProvidePersistenceID(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.ProvidePersistenceIDEventArgs)
            selectedIndex = listBox2.Items.Add("Provide Persistence ID")
            SetIndex(selectedIndex)
        End Sub

        'The TransferredToManager event occurs after a dockable control that previously belonged to some other DockingManager has been transferred to the docking layout hosted by this DockingManager.
        Private Sub dm_TransferredToManager(ByVal sender As Object, ByVal arg As TransferManagerEventArgs)
            selectedIndex = listBox2.Items.Add("Transferred To Manager - [" + arg.Control.Name + "]")
            SetIndex(selectedIndex)
        End Sub

        'The TransferringFromManager event occurs when a dockable control hosted by this DockingManager is about to be transferred to the docking layout hosted by some other DockingManager.
        Private Sub dm_TransferringFromManager(ByVal sender As Object, ByVal arg As TransferManagerEventArgs)
            selectedIndex = listBox2.Items.Add("Transferring From Manager - [" + arg.Control.Name + "]")
            SetIndex(selectedIndex)
        End Sub
#End Region   'Standard Events

#Region "Selects the currently added item"
        Private Sub SetIndex(ByVal i As Integer)
            Me.listBox2.SelectedIndex = i
        End Sub
#End Region

#Region "Setting Tooltip and Delete all listbox item in KeyDown Event"
        Private Sub listBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.toolTip1.SetToolTip(Me.listBox2, "Press Ctrl+Delete to clear the event logs")
        End Sub

        Private Sub listBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles listBox2.KeyDown
            If e.KeyCode = System.Windows.Forms.Keys.Delete Or e.KeyCode = System.Windows.Forms.Keys.Control Then
                Me.listBox2.Items.Clear()
            End If
        End Sub
#End Region

#Region "Event Handlers"
        Private Sub cbListBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbListBox.CheckedChanged
            ' Shows / hides the list box.
            If Me.cbListBox.Checked = True Then
                Me.dockingManager1.SetDockVisibility(Me.listBox1, False)
            Else
                Me.dockingManager1.SetDockVisibility(Me.listBox1, True)
            End If
        End Sub

        Private Sub cbTreeView_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTreeView.CheckedChanged
            ' Shows / hides the treeview.
            If Me.cbTreeView.Checked = True Then
                Me.dockingManager1.SetDockVisibility(Me.treeView1, False)
            Else
                Me.dockingManager1.SetDockVisibility(Me.treeView1, True)
            End If
        End Sub
        Private Sub cbfreezeresize_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbfreezeresize.CheckedChanged
            Me.dockingManager1.FreezeResizing = cbfreezeresize.Checked
        End Sub
        Private Sub cbAutoHide_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbAutoHide.CheckedChanged
            ' Enables / disables the autohide mode for the DockingManager.
            If Me.cbAutoHide.Checked = True Then
                Me.dockingManager1.AutoHideEnabled = False
            Else
                Me.dockingManager1.AutoHideEnabled = True
            End If
        End Sub
        Private Sub cboVisualStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVisualStyle.SelectedIndexChanged

            'Sets Visual Style Property
            Select Case CStr(Me.cboVisualStyle.SelectedItem)

                Case "Default"
                    Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Default
                Case "Office2003"
                    Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2003
                Case "OfficeXP"
                    Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
                Case "VS2005"
                    Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.VS2005
                Case "Office2007"
                    Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007

            End Select


        End Sub



        Private Sub treeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterSelect
            Select Case e.Node.Text

                Case "DockingManager" : textBox1.Text = "At the most basic level a docking window may be defined as a control that attaches itself to a host form's border. Windows Forms provides basic support for docking capapbilities through the Dock property of the control class."
                Case "DesignTimeSupport" : textBox1.Text = "Docking architecture offers a true design time support"
                Case "Events architecture" : textBox1.Text = "Dockingmanager has numerous events which help to interact the docking operations"
                Case "Customization options" : textBox1.Text = "Docking manager has so much properties to make the docking customization"
                Case "Extensible " : textBox1.Text = "Docking architecture is extensible too by using inheritance.For example if you want to change the autohide tab font and color you can inherit the DockingManager class"
                Case "Enable docking" : textBox1.Text = "The docking for an control can be easily enabled by just setting a property 'EnableDocking On DockingManager'"
                Case "Setting dock edge" : textBox1.Text = "Drag a docked window to the edge of the form that will then stick to that edge"
                Case "Making tabbed windows " : textBox1.Text = "Drag a docked window to the title bar of another docked window, they will then became tabbed"
                Case "Setting as floaing" : textBox1.Text = "Just drag out the window ,it then will be free from form ie floating"
                Case "DockAllow event" : textBox1.Text = "A powerful event which will fire each time before a docking operation.It also allows to cancel the operation"
                Case "Dragallow event" : textBox1.Text = "The event which will fire before any drag opeation takes place"
                Case "DockVisibilityChanging event" : textBox1.Text = "Fires before we close any of the docked window.It offers the facility to cancel the closing."
                Case "DockToFill mode" : textBox1.Text = "Specifies whether the docked windows should resize to the empty space in the host form"
                Case "Dissallow Floating" : textBox1.Text = "If it is set to true,DockingManager wont allow any window to be floated"
                Case "Docking diamond" : textBox1.Text = "Allows to set the style of dock prediction bands"
                Case "DockTab settings" : textBox1.Text = "There are 3 properties DockTabAllignment,DockTabHeight,DockTabFont which help to customize the docktab"
            End Select



        End Sub

        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            cboDockLabel.SelectedIndex = 2
            comboBox1.SelectedIndex = 1
            cboDrag.SelectedIndex = 1
            cboBrowsingKey.SelectedIndex = 1
            cboVisualStyle.SelectedIndex = 3
            comboBoxBase1.Text = Me.dockingManager1.GetDockLabel(Me.treeView1)
            Me.dockingManager1.SetFreezeResize(Me.treeView1, True)
            Me.checkedListBox3.SetItemChecked(2, True)

        End Sub



        Private Sub cbCheckedList_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCheckedList.CheckedChanged
            dockingManager1.SetDockVisibility(checkedListBox1, Not cbCheckedList.Checked)
            dockingManager1.SetDockVisibility(checkedListBox2, Not cbCheckedList.Checked)
        End Sub

        Private Sub cbTextBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTextBox.CheckedChanged
            dockingManager1.SetDockVisibility(textBox1, Not cbTextBox.Checked)
        End Sub
#End Region

#Region "Freeze/Unfreeze"

        Private Sub AddDockControlsToList()
            Me.checkedListBox3.Items.Clear()
            For Each c As Control In Me.dockingManager1.ControlsArray
                Me.checkedListBox3.Items.Add(Me.dockingManager1.GetDockLabel(c).ToString(), Me.dockingManager1.GetFreezeResize(c))
            Next c
        End Sub

        Private Sub checkedListBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkedListBox3.SelectedIndexChanged
            Dim i As Integer = 0
            Dim ctrl As Control = GetDockedControl(Me.checkedListBox3.SelectedItem.ToString())
            If Not ctrl Is Nothing Then
                If Me.checkedListBox3.GetItemChecked(Me.checkedListBox3.SelectedIndex) Then
                    Me.dockingManager1.SetFreezeResize(ctrl, True)
                Else
                    Me.dockingManager1.SetFreezeResize(ctrl, False)
                End If

            End If
        End Sub

        Private Function GetDockedControl(ByVal name As String) As Control
            For Each c As Control In Me.dockingManager1.ControlsArray
                If Me.dockingManager1.GetDockLabel(c).ToString() = name Then
                    Return c
                End If
            Next c
            Return Nothing
        End Function

#End Region

    End Class
End Namespace
