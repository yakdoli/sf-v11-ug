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
Imports System.Diagnostics

Imports Syncfusion.Runtime.Serialization
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms

'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Office2007Form
#Region "Members declaration"
    Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
    Private imageList1 As System.Windows.Forms.ImageList
    Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
    Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
    Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private components As System.ComponentModel.IContainer
    Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
    Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Private parentBarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Private parentBarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
    Private WithEvents biSuiteLogo As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private WithEvents biSuiteInfo As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private WithEvents biToolsLogo As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private WithEvents biToolsInfo As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private WithEvents biGridLogo As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private WithEvents biGridInfo As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
    Private ucSuitePage As LinkedManagers.TabPageClientControl
    Private ucToolsPage As LinkedManagers.TabPageClientControl
    Private tabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
    Private ucGridPage As LinkedManagers.TabPageClientControl
    Private aboutForm As DemoCommon.AboutForm

    Private htCreatedControls As New Hashtable()
    Private bDisposeControlsOnClose As Boolean = False
    ' Set to TRUE to dispose dockable controls upon closing
#End Region
#Region "Initialization"
    ' DockableClientsInitialization
    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                ' Array of the DockingManagers present in the different tabpage client controls
                Dim dockingmgrs() As DockingManager = {Me.ucSuitePage.DockingManager, Me.ucToolsPage.DockingManager, Me.ucGridPage.DockingManager}

                Dim manager As DockingManager
                For Each manager In dockingmgrs
                    RemoveHandler manager.DockVisibilityChanged, AddressOf Me.DockingManager_DockVisibilityChanged
                    RemoveHandler manager.TransferredToManager, AddressOf Me.DockingManager_TransferredToManager
                    RemoveHandler manager.InitializeControlOnLoad, AddressOf Me.DockingManager_InitializeControlOnLoad
                Next manager

                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
    End Sub 'New

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
        Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "MainMenuToolBar")
        Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.biSuiteLogo = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.biSuiteInfo = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.parentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.biToolsLogo = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.biToolsInfo = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.parentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.biGridLogo = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.biGridInfo = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "ShortcutToolBar")
        Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
        Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
        Me.ucSuitePage = New LinkedManagers.TabPageClientControl
        Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
        Me.ucToolsPage = New LinkedManagers.TabPageClientControl
        Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
        Me.ucGridPage = New LinkedManagers.TabPageClientControl
        CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabControlAdv1.SuspendLayout()
        Me.tabPageAdv1.SuspendLayout()
        Me.tabPageAdv2.SuspendLayout()
        Me.tabPageAdv3.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainFrameBarManager1
        '
        Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
        Me.mainFrameBarManager1.Bars.Add(Me.bar1)
        Me.mainFrameBarManager1.Bars.Add(Me.bar2)
        Me.mainFrameBarManager1.Categories.Add("MainMenu")
        Me.mainFrameBarManager1.Categories.Add("FileMenu")
        Me.mainFrameBarManager1.Categories.Add("ViewMenu")
        Me.mainFrameBarManager1.Categories.Add("HelpMenu")
        Me.mainFrameBarManager1.Categories.Add("OpenShortcut")
        Me.mainFrameBarManager1.Categories.Add("SaveShortcut")
        Me.mainFrameBarManager1.Categories.Add("ExitShortcut")
        Me.mainFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form"
        Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainFrameBarManager1.Form = Me
        Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem2, Me.parentBarItem3, Me.barItem5, Me.barItem1, Me.barItem2, Me.biSuiteLogo, Me.biSuiteInfo, Me.biToolsLogo, Me.biToolsInfo, Me.biGridLogo, Me.biGridInfo, Me.parentBarItem4, Me.parentBarItem5, Me.parentBarItem6})
        Me.mainFrameBarManager1.ResetCustomization = False
        Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
        '
        'bar1
        '
        Me.bar1.BarName = "MainMenuToolBar"
        Me.bar1.BarStyle = CType(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                    Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
        Me.bar1.Caption = "MainMenuToolBar"
        Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem2, Me.parentBarItem3})
        Me.bar1.Manager = Me.mainFrameBarManager1
        '
        'parentBarItem1
        '
        Me.parentBarItem1.CategoryIndex = 0
        Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem1.ID = "File"
        Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem2})
        Me.parentBarItem1.Text = "&File"
        '
        'barItem1
        '
        Me.barItem1.CategoryIndex = 1
        Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem1.ID = "Load Dock State"
        Me.barItem1.ImageIndex = 0
        Me.barItem1.ImageList = Me.imageList1
        Me.barItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
        Me.barItem1.Text = "Load Dock State"
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.imageList1.Images.SetKeyName(0, "openfolderHS.png")
        Me.imageList1.Images.SetKeyName(1, "saveHS.png")
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
        '
        'barItem2
        '
        Me.barItem2.CategoryIndex = 1
        Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem2.ID = "Save Dock State"
        Me.barItem2.ImageIndex = 1
        Me.barItem2.ImageList = Me.imageList1
        Me.barItem2.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
        Me.barItem2.Text = "Save Dock State"
        '
        'parentBarItem2
        '
        Me.parentBarItem2.CategoryIndex = 0
        Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem2.ID = "View"
        Me.parentBarItem2.ImageList = Me.imageList1
        Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem4, Me.parentBarItem5, Me.parentBarItem6})
        Me.parentBarItem2.Text = "&View"
        '
        'parentBarItem4
        '
        Me.parentBarItem4.CategoryIndex = 2
        Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem4.ID = "Essential Suite_1"
        Me.parentBarItem4.ImageIndex = 10
        Me.parentBarItem4.ImageList = Me.imageList1
        Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biSuiteLogo, Me.biSuiteInfo})
        Me.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007Outlook
        Me.parentBarItem4.Text = "Essential Suite"
        '
        'biSuiteLogo
        '
        Me.biSuiteLogo.CategoryIndex = 2
        Me.biSuiteLogo.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biSuiteLogo.ID = "suiteLogo"
        Me.biSuiteLogo.ImageIndex = 6
        Me.biSuiteLogo.ImageList = Me.imageList1
        Me.biSuiteLogo.Text = "Suite Logo"
        '
        'biSuiteInfo
        '
        Me.biSuiteInfo.CategoryIndex = 2
        Me.biSuiteInfo.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biSuiteInfo.ID = "suiteInformation"
        Me.biSuiteInfo.ImageIndex = 7
        Me.biSuiteInfo.ImageList = Me.imageList1
        Me.biSuiteInfo.Text = "Suite Information"
        '
        'parentBarItem5
        '
        Me.parentBarItem5.CategoryIndex = 2
        Me.parentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem5.ID = "Essential Tools_1"
        Me.parentBarItem5.ImageIndex = 9
        Me.parentBarItem5.ImageList = Me.imageList1
        Me.parentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biToolsLogo, Me.biToolsInfo})
        Me.parentBarItem5.Text = "Essential Tools"
        '
        'biToolsLogo
        '
        Me.biToolsLogo.CategoryIndex = 2
        Me.biToolsLogo.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biToolsLogo.ID = "toolsLogo"
        Me.biToolsLogo.ImageIndex = 6
        Me.biToolsLogo.ImageList = Me.imageList1
        Me.biToolsLogo.Text = "Tools Logo"
        '
        'biToolsInfo
        '
        Me.biToolsInfo.CategoryIndex = 2
        Me.biToolsInfo.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biToolsInfo.ID = "toolsInformation"
        Me.biToolsInfo.ImageIndex = 7
        Me.biToolsInfo.ImageList = Me.imageList1
        Me.biToolsInfo.Text = "Tools Information"
        '
        'parentBarItem6
        '
        Me.parentBarItem6.CategoryIndex = 2
        Me.parentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem6.ID = "Essential Grid_1"
        Me.parentBarItem6.ImageIndex = 8
        Me.parentBarItem6.ImageList = Me.imageList1
        Me.parentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biGridLogo, Me.biGridInfo})
        Me.parentBarItem6.Text = "Essential Grid"
        '
        'biGridLogo
        '
        Me.biGridLogo.CategoryIndex = 2
        Me.biGridLogo.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biGridLogo.ID = "gridLogo"
        Me.biGridLogo.ImageIndex = 6
        Me.biGridLogo.ImageList = Me.imageList1
        Me.biGridLogo.Text = "Grid Logo"
        '
        'biGridInfo
        '
        Me.biGridInfo.CategoryIndex = 2
        Me.biGridInfo.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.biGridInfo.ID = "gridInformation"
        Me.biGridInfo.ImageIndex = 7
        Me.biGridInfo.ImageList = Me.imageList1
        Me.biGridInfo.Text = "Grid Information"
        '
        'parentBarItem3
        '
        Me.parentBarItem3.CategoryIndex = 0
        Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parentBarItem3.ID = "Help"
        Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem5})
        Me.parentBarItem3.Text = "&Help"
        '
        'barItem5
        '
        Me.barItem5.CategoryIndex = 3
        Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.barItem5.ID = "About Syncfusion"
        Me.barItem5.ImageIndex = 11
        Me.barItem5.ImageList = Me.imageList1
        Me.barItem5.Text = "About Syncfusion"
        '
        'bar2
        '
        Me.bar2.BarName = "ShortcutToolBar"
        Me.bar2.BarStyle = CType(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                    Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
        Me.bar2.Caption = "ShortcutToolBar"
        Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem2})
        Me.bar2.Manager = Me.mainFrameBarManager1
        Me.bar2.SeparatorIndices.AddRange(New Integer() {1})
        '
        'tabControlAdv1
        '
        Me.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tabControlAdv1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
        Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
        Me.tabControlAdv1.Controls.Add(Me.tabPageAdv3)
        Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.tabControlAdv1.Location = New System.Drawing.Point(0, 51)
        Me.tabControlAdv1.Name = "tabControlAdv1"
        Me.tabControlAdv1.Padding = New System.Drawing.Point(6, 1)
        Me.tabControlAdv1.Size = New System.Drawing.Size(576, 395)
        Me.tabControlAdv1.TabGap = 10
        Me.tabControlAdv1.TabIndex = 4
        Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
        '
        'tabPageAdv1
        '
        Me.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tabPageAdv1.Controls.Add(Me.ucSuitePage)
        Me.tabPageAdv1.Location = New System.Drawing.Point(1, 25)
        Me.tabPageAdv1.Name = "tabPageAdv1"
        Me.tabPageAdv1.Size = New System.Drawing.Size(574, 369)
        Me.tabPageAdv1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.tabPageAdv1.TabIndex = 3
        Me.tabPageAdv1.Text = "Essential Suite"
        Me.tabPageAdv1.ThemesEnabled = False
        '
        'ucSuitePage
        '
        Me.ucSuitePage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucSuitePage.Location = New System.Drawing.Point(0, 0)
        Me.ucSuitePage.Name = "ucSuitePage"
        Me.ucSuitePage.Size = New System.Drawing.Size(574, 369)
        Me.ucSuitePage.TabIndex = 0
        '
        'tabPageAdv2
        '
        Me.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tabPageAdv2.Controls.Add(Me.ucToolsPage)
        Me.tabPageAdv2.Location = New System.Drawing.Point(1, 25)
        Me.tabPageAdv2.Name = "tabPageAdv2"
        Me.tabPageAdv2.Size = New System.Drawing.Size(573, 368)
        Me.tabPageAdv2.TabIndex = 4
        Me.tabPageAdv2.Text = "Essential Tools"
        Me.tabPageAdv2.ThemesEnabled = False
        '
        'ucToolsPage
        '
        Me.ucToolsPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucToolsPage.Location = New System.Drawing.Point(0, 0)
        Me.ucToolsPage.Name = "ucToolsPage"
        Me.ucToolsPage.Size = New System.Drawing.Size(573, 368)
        Me.ucToolsPage.TabIndex = 0
        '
        'tabPageAdv3
        '
        Me.tabPageAdv3.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.tabPageAdv3.Controls.Add(Me.ucGridPage)
        Me.tabPageAdv3.Location = New System.Drawing.Point(1, 25)
        Me.tabPageAdv3.Name = "tabPageAdv3"
        Me.tabPageAdv3.Size = New System.Drawing.Size(573, 368)
        Me.tabPageAdv3.TabIndex = 5
        Me.tabPageAdv3.Text = "Essential Grid"
        Me.tabPageAdv3.ThemesEnabled = False
        '
        'ucGridPage
        '
        Me.ucGridPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucGridPage.Location = New System.Drawing.Point(0, 0)
        Me.ucGridPage.Name = "ucGridPage"
        Me.ucGridPage.Size = New System.Drawing.Size(573, 368)
        Me.ucGridPage.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(576, 446)
        Me.Controls.Add(Me.tabControlAdv1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Linked Managers"
        CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabControlAdv1.ResumeLayout(False)
        Me.tabPageAdv1.ResumeLayout(False)
        Me.tabPageAdv2.ResumeLayout(False)
        Me.tabPageAdv3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Syncfusion.Runtime.Serialization.AppStateSerializer.InitializeSingleton(SerializeMode.XMLFile, String.Concat(Environment.CurrentDirectory, "DockState"))
        Application.Run(New Form1())
    End Sub 'Main

#End Region
#Region "Event handlers"
    Private Sub barItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem5.Click
        aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
        aboutForm.ShowDialog()
    End Sub 'barItem5_Click

    Private Sub barItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
        Me.Dispose()
    End Sub 'barItem3_Click
    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        ' Save the persisted dock state information for the different DockingManagers
        Me.ucSuitePage.DockingManager.SaveDockState()
        Me.ucToolsPage.DockingManager.SaveDockState()
        Me.ucGridPage.DockingManager.SaveDockState()
    End Sub 'Form1_Closing
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dockingmgrs() As DockingManager = {Me.ucSuitePage.DockingManager, Me.ucToolsPage.DockingManager, Me.ucGridPage.DockingManager}

        ' Specify the DockingManagers in the array to be used as target providers by all DockingManagers
        Dim manager As DockingManager
        For Each manager In dockingmgrs
            ' Invoking the DockingManager.AddToTargetManagersList method on a docking manager will add the 
            ' specified DockingManager argument instance to the invoking method's target managers list. 
            ' Doing so allows dockable controls from the host docking manager to be docked onto the docking layout 
            ' implemented by the target docking manager.
            If manager Is Me.ucSuitePage.DockingManager Then
                '
            Else
                Me.ucSuitePage.DockingManager.AddToTargetManagersList(manager)
            End If
            If manager Is Me.ucToolsPage.DockingManager Then
                '
            Else
                Me.ucToolsPage.DockingManager.AddToTargetManagersList(manager)
            End If
            If manager Is Me.ucGridPage.DockingManager Then
                '
            Else
                Me.ucGridPage.DockingManager.AddToTargetManagersList(manager)
            End If
            ' Subscribe to the DockingManager.DockVisiblityChanged event.
            AddHandler manager.DockVisibilityChanged, AddressOf Me.DockingManager_DockVisibilityChanged
            ' Subscribe to the DockingManager.ManagerTransferred event.
            AddHandler manager.TransferredToManager, AddressOf Me.DockingManager_TransferredToManager
            ' Subscribe to the DockingManager.InitializeControlOnLoad event.
            AddHandler manager.InitializeControlOnLoad, AddressOf Me.DockingManager_InitializeControlOnLoad

            'Enabling XPTheme 
            manager.ThemesEnabled = True
        Next manager

        ' Load the persisted dock state information for the different DockingManagers
        Me.ucSuitePage.DockingManager.LoadDockState()
        Me.ucToolsPage.DockingManager.LoadDockState()
        Me.ucGridPage.DockingManager.LoadDockState()
    End Sub 'Form1_Load
    Private Sub biSuiteLogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biSuiteLogo.Click
        Me.ActivateSuiteLogoControl(Me.ucSuitePage.DockingManager, True)
    End Sub 'biSuiteLogo_Click
    Private Sub biSuiteInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biSuiteInfo.Click
        Me.ActivateSuiteInfoControl(Me.ucSuitePage.DockingManager, True)
    End Sub 'biSuiteInfo_Click
    Private Sub biToolsLogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biToolsLogo.Click
        Me.ActivateToolsLogoControl(Me.ucToolsPage.DockingManager, True)
    End Sub 'biToolsLogo_Click
    Private Sub biToolsInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biToolsInfo.Click
        Me.ActivateToolsInfoControl(Me.ucToolsPage.DockingManager, True)
    End Sub 'biToolsInfo_Click
    Private Sub biGridLogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biGridLogo.Click
        Me.ActivateGridLogoControl(Me.ucGridPage.DockingManager, True)
    End Sub 'biGridLogo_Click
    Private Sub biGridInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biGridInfo.Click
        Me.ActivateGridInfoControl(Me.ucGridPage.DockingManager, True)
    End Sub 'biGridInfo_Click
    Private Sub barItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem1.Click
        Me.ucSuitePage.DockingManager.LoadDockState()
        Me.ucToolsPage.DockingManager.LoadDockState()
        Me.ucGridPage.DockingManager.LoadDockState()
    End Sub
    Private Sub barItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem2.Click
        Me.ucSuitePage.DockingManager.SaveDockState()
        Me.ucToolsPage.DockingManager.SaveDockState()
        Me.ucGridPage.DockingManager.SaveDockState()
    End Sub
#End Region
#Region "Event handlers-DockingMaanger"
    ' A docking window is being closed. Remove it from the docking layout and dispose the control.

    Protected Sub DockingManager_DockVisibilityChanged(ByVal sender As Object, ByVal args As DockVisibilityChangedEventArgs)
        ' When the bDisposeControlsOnClose flag is set, clicking the 'X' close button will remove the 
        ' control from it's docking layout and dispose it.
        If Me.bDisposeControlsOnClose = True Then
            Dim dockingmgr As DockingManager = sender '
            'ToDo: Error processing original source shown below
            '   {
            '    DockingManager dockingmgr = sender as DockingManager;
            '----------------------------------------^--- Syntax error: ';' expected
            Dim dockablecontrol As DockableControlBase = args.Control '
            'ToDo: Error processing original source shown below
            '    DockingManager dockingmgr = sender as DockingManager;
            '    DockableControlBase dockablecontrol = args.Control as DockableControlBase;
            '--------------------------------------------------------^--- Syntax error: ';' expected
            If dockingmgr.GetDockVisibility(dockablecontrol) = False Then
                Dim serializer As Syncfusion.Runtime.Serialization.AppStateSerializer = Syncfusion.Runtime.Serialization.AppStateSerializer.GetSingleton()
                dockingmgr.SaveDockState(serializer, dockablecontrol)

                dockingmgr.SetEnableDocking(dockablecontrol, False)
                Me.htCreatedControls.Remove(dockablecontrol.Name)
                dockablecontrol.Dispose()
            End If
        End If
    End Sub 'DockingManager_DockVisibilityChanged


    ' A docking window is being transferred from one docking layout to another. 
    ' Update the control's DockingManager reference.
    Protected Sub DockingManager_TransferredToManager(ByVal sender As Object, ByVal args As TransferManagerEventArgs)
        Dim dockablecontrol As DockableControlBase = args.Control '
        'ToDo: Error processing original source shown below
        '  {
        '   DockableControlBase dockablecontrol = args.Control as DockableControlBase;
        '-------------------------------------------------------^--- Syntax error: ';' expected
        dockablecontrol.CurrentDockingManager = sender '
        'ToDo: Error processing original source shown below
        '   DockableControlBase dockablecontrol = args.Control as DockableControlBase;
        '   dockablecontrol.CurrentDockingManager = sender as DockingManager;
        '---------------------------------------------------^--- Syntax error: ';' expected
    End Sub 'DockingManager_TransferredToManager


    ' The DockingManager.InitializeControlOnLoad event is fired when the DockingManager attempts to load a persisted 
    ' dock state and is not able to locate the control for the persisted information. The event is used here as a 
    ' place holder for creating the docking window.
    Protected Sub DockingManager_InitializeControlOnLoad(ByVal sender As Object, ByVal args As InitializeControlOnLoadEventArgs)
        Dim dockingmgr As DockingManager = sender '
        'ToDo: Error processing original source shown below
        '  {
        '   DockingManager dockingmgr = sender as DockingManager;
        '---------------------------------------^--- Syntax error: ';' expected
        Select Case args.ControlName
            Case "Suite Logo"
                Me.ActivateSuiteLogoControl(dockingmgr, False)
            Case "Suite Info"
                Me.ActivateSuiteInfoControl(dockingmgr, False)
            Case "Tools Info"
                Me.ActivateToolsInfoControl(dockingmgr, False)
            Case "Tools Logo"
                Me.ActivateToolsLogoControl(dockingmgr, False)
            Case "Grid Logo"
                Me.ActivateGridLogoControl(dockingmgr, False)
            Case "Grid Info"
                Me.ActivateGridInfoControl(dockingmgr, False)
        End Select
    End Sub 'DockingManager_InitializeControlOnLoad
#End Region
#Region "DockableClientsInitialization"


    Protected Sub ActivateSuiteLogoControl(ByVal dockingmgr As DockingManager, ByVal setdockposition As Boolean)
        If Me.htCreatedControls.ContainsKey("Suite Logo") = True Then
            Dim dockablecontrol As DockableControlBase = Me.htCreatedControls("Suite Logo") '

            Dim hosttabpage As TabPageAdv = dockablecontrol.CurrentDockingManager.HostControl.Parent '

            If Me.tabControlAdv1.SelectedTab Is hosttabpage Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = hosttabpage
            End If
            If dockingmgr.GetDockVisibility(dockablecontrol) = False Then
                dockingmgr.SetDockVisibility(dockablecontrol, True)
            End If
        Else
            ' Set the Suite TabPage as the selected tab
            If Me.tabControlAdv1.SelectedTab Is Me.tabPageAdv1 Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = Me.tabPageAdv1
            End If
            ' Create an instance of the SuiteLogoControl and dock it to the left border of the ucSuitePage
            ' UserControl that is embedded within the Suite TabPage
            Dim suitelogo As New SuiteLogoControl("Suite Logo")
            suitelogo.CurrentDockingManager = dockingmgr
            If setdockposition = True Then
                dockingmgr.DockControl(suitelogo, dockingmgr.HostControl, DockingStyle.Left, 150)
                'dockingmgr.DockControlInAutoHideMode(suitelogo, DockingStyle.Left, 250);
            Else
                dockingmgr.SetEnableDocking(suitelogo, True)
            End If
            dockingmgr.SetDockLabel(suitelogo, suitelogo.DockLabel)
            dockingmgr.SetDockIcon(suitelogo, suitelogo.DockIcon)

            Me.htCreatedControls.Add("Suite Logo", suitelogo)
        End If
    End Sub 'ActivateSuiteLogoControl


    Protected Sub ActivateSuiteInfoControl(ByVal dockingmgr As DockingManager, ByVal setdockposition As Boolean)
        If Me.htCreatedControls.ContainsKey("Suite Info") = True Then
            Dim dockablecontrol As DockableControlBase = Me.htCreatedControls("Suite Info") '
            'ToDo: Error processing original source shown below
            '   {
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Suite Info"] as DockableControlBase;
            '--------------------------------------------------------------------------------^--- Syntax error: ';' expected
            Dim hosttabpage As TabPageAdv = dockablecontrol.CurrentDockingManager.HostControl.Parent '
            'ToDo: Error processing original source shown below
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Suite Info"] as DockableControlBase;
            '    TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
            '---------------------------------------------------------------------------------------^--- Syntax error: ';' expected
            If Me.tabControlAdv1.SelectedTab Is hosttabpage Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = hosttabpage
            End If
            If dockingmgr.GetDockVisibility(dockablecontrol) = False Then
                dockingmgr.SetDockVisibility(dockablecontrol, True)
            End If
        Else
            ' Set the Suite TabPage as the selected tab
            If Me.tabControlAdv1.SelectedTab Is Me.tabPageAdv1 Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = Me.tabPageAdv1
            End If
            ' Create an instance of the SuiteInfoControl and dock it to the bottom border of the ucSuitePage
            ' UserControl that is embedded within the Suite TabPage
            Dim dockablecontrol As DockableControlBase = New SuiteInfoControl("Suite Info")

            dockablecontrol.CurrentDockingManager = dockingmgr
            If setdockposition = True Then
                dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Bottom, 150)
            Else
                dockingmgr.SetEnableDocking(dockablecontrol, True)
            End If
            dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel)
            dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon)

            Me.htCreatedControls.Add("Suite Info", dockablecontrol)
        End If
    End Sub 'ActivateSuiteInfoControl


    Protected Sub ActivateToolsLogoControl(ByVal dockingmgr As DockingManager, ByVal setdockposition As Boolean)
        If Me.htCreatedControls.ContainsKey("Tools Logo") = True Then
            Dim dockablecontrol As DockableControlBase = Me.htCreatedControls("Tools Logo") '
            'ToDo: Error processing original source shown below
            '   {
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Tools Logo"] as DockableControlBase;
            '--------------------------------------------------------------------------------^--- Syntax error: ';' expected
            Dim hosttabpage As TabPageAdv = dockablecontrol.CurrentDockingManager.HostControl.Parent '
            'ToDo: Error processing original source shown below
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Tools Logo"] as DockableControlBase;
            '    TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
            '---------------------------------------------------------------------------------------^--- Syntax error: ';' expected
            If Me.tabControlAdv1.SelectedTab Is hosttabpage Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = hosttabpage
            End If
            If dockablecontrol.CurrentDockingManager.GetDockVisibility(dockablecontrol) = False Then
                dockablecontrol.CurrentDockingManager.SetDockVisibility(dockablecontrol, True)
            End If
        Else
            ' Set the Tools TabPage as the selected tab
            If Me.tabControlAdv1.SelectedTab Is Me.tabPageAdv2 Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = Me.tabPageAdv2
            End If
            ' Create an instance of the ToolsLogoControl and dock it to the left border of the ucToolsPage
            ' UserControl that is embedded inside the Tools TabPage
            Dim dockablecontrol As DockableControlBase = New ToolsLogoControl("Tools Logo")
            dockablecontrol.CurrentDockingManager = dockingmgr
            If setdockposition = True Then
                dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Left, 150)
            Else
                dockingmgr.SetEnableDocking(dockablecontrol, True)
            End If
            dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel)
            dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon)

            Me.htCreatedControls.Add("Tools Logo", dockablecontrol)
        End If
    End Sub 'ActivateToolsLogoControl


    Protected Sub ActivateToolsInfoControl(ByVal dockingmgr As DockingManager, ByVal setdockposition As Boolean)
        If Me.htCreatedControls.ContainsKey("Tools Info") = True Then
            Dim dockablecontrol As DockableControlBase = Me.htCreatedControls("Tools Info") '
            'ToDo: Error processing original source shown below
            '   {
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Tools Info"] as DockableControlBase;
            '--------------------------------------------------------------------------------^--- Syntax error: ';' expected
            Dim hosttabpage As TabPageAdv = dockablecontrol.CurrentDockingManager.HostControl.Parent '
            'ToDo: Error processing original source shown below
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Tools Info"] as DockableControlBase;
            '    TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
            '---------------------------------------------------------------------------------------^--- Syntax error: ';' expected
            If Me.tabControlAdv1.SelectedTab Is hosttabpage Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = hosttabpage
            End If
            If dockablecontrol.CurrentDockingManager.GetDockVisibility(dockablecontrol) = False Then
                dockablecontrol.CurrentDockingManager.SetDockVisibility(dockablecontrol, True)
            End If
        Else
            ' Set the Tools TabPage as the selected tab
            If Me.tabControlAdv1.SelectedTab Is Me.tabPageAdv2 Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = Me.tabPageAdv2
            End If
            ' Create an instance of the ToolsInfoControl and dock it to the bottom border of the ucToolsPage
            ' UserControl that is embedded inside the Tools TabPage
            Dim dockablecontrol As DockableControlBase = New ToolsInfoControl("Tools Info")
            dockablecontrol.CurrentDockingManager = dockingmgr
            If setdockposition = True Then
                dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Bottom, 150)
            Else
                dockingmgr.SetEnableDocking(dockablecontrol, True)
            End If
            dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel)
            dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon)

            Me.htCreatedControls.Add("Tools Info", dockablecontrol)
        End If
    End Sub 'ActivateToolsInfoControl


    Protected Sub ActivateGridLogoControl(ByVal dockingmgr As DockingManager, ByVal setdockposition As Boolean)
        If Me.htCreatedControls.ContainsKey("Grid Logo") = True Then
            Dim dockablecontrol As DockableControlBase = Me.htCreatedControls("Grid Logo") '
            'ToDo: Error processing original source shown below
            '   {
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Grid Logo"] as DockableControlBase;
            '-------------------------------------------------------------------------------^--- Syntax error: ';' expected
            Dim hosttabpage As TabPageAdv = dockablecontrol.CurrentDockingManager.HostControl.Parent '
            'ToDo: Error processing original source shown below
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Grid Logo"] as DockableControlBase;
            '    TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
            '---------------------------------------------------------------------------------------^--- Syntax error: ';' expected
            If Me.tabControlAdv1.SelectedTab Is hosttabpage Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = hosttabpage
            End If
            If dockablecontrol.CurrentDockingManager.GetDockVisibility(dockablecontrol) = False Then
                dockablecontrol.CurrentDockingManager.SetDockVisibility(dockablecontrol, True)
            End If
        Else
            ' Set the Grid TabPage as the selected tab
            If Me.tabControlAdv1.SelectedTab Is Me.tabPageAdv3 Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = Me.tabPageAdv3
            End If
            ' Create an instance of the GridLogoControl and dock it to the left border of the ucGridPage
            ' UserControl that is embedded inside the Grid TabPage
            Dim dockablecontrol As DockableControlBase = New GridLogoControl("Grid Logo")
            dockablecontrol.CurrentDockingManager = dockingmgr
            If setdockposition = True Then
                dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Left, 150)
            Else
                dockingmgr.SetEnableDocking(dockablecontrol, True)
            End If
            dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel)
            dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon)

            Me.htCreatedControls.Add("Grid Logo", dockablecontrol)
        End If
    End Sub 'ActivateGridLogoControl


    Protected Sub ActivateGridInfoControl(ByVal dockingmgr As DockingManager, ByVal setdockposition As Boolean)
        If Me.htCreatedControls.ContainsKey("Grid Info") = True Then
            Dim dockablecontrol As DockableControlBase = Me.htCreatedControls("Grid Info") '
            'ToDo: Error processing original source shown below
            '   {
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Grid Info"] as DockableControlBase;
            '-------------------------------------------------------------------------------^--- Syntax error: ';' expected
            Dim hosttabpage As TabPageAdv = dockablecontrol.CurrentDockingManager.HostControl.Parent '
            'ToDo: Error processing original source shown below
            '    DockableControlBase dockablecontrol = this.htCreatedControls["Grid Info"] as DockableControlBase;
            '    TabPageAdv hosttabpage = dockablecontrol.CurrentDockingManager.HostControl.Parent as TabPageAdv;
            '---------------------------------------------------------------------------------------^--- Syntax error: ';' expected
            If Me.tabControlAdv1.SelectedTab Is hosttabpage Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = hosttabpage
            End If
            If dockablecontrol.CurrentDockingManager.GetDockVisibility(dockablecontrol) = False Then
                dockablecontrol.CurrentDockingManager.SetDockVisibility(dockablecontrol, True)
            End If
        Else
            ' Set the Grid TabPage as the selected tab
            If Me.tabControlAdv1.SelectedTab Is Me.tabPageAdv3 Then
                '
            Else
                Me.tabControlAdv1.SelectedTab = Me.tabPageAdv3
            End If
            ' Create an instance of the GridInfoControl and dock it to the left border of the ucGridPage
            ' UserControl that is embedded inside the Grid TabPage
            Dim dockablecontrol As DockableControlBase = New GridInfoControl("Grid Info")
            dockablecontrol.CurrentDockingManager = dockingmgr
            If setdockposition = True Then
                dockingmgr.DockControl(dockablecontrol, dockingmgr.HostControl, DockingStyle.Bottom, 150)
            Else
                dockingmgr.SetEnableDocking(dockablecontrol, True)
            End If
            dockingmgr.SetDockLabel(dockablecontrol, dockablecontrol.DockLabel)
            dockingmgr.SetDockIcon(dockablecontrol, dockablecontrol.DockIcon)

            Me.htCreatedControls.Add("Grid Info", dockablecontrol)
        End If
    End Sub 'ActivateGridInfoControl

#End Region
   
End Class 'Form1 