Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports VSDemo

Imports Syncfusion.Runtime.Serialization
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Microsoft.Win32
Namespace VSDemo
    ''' <summary>
    ''' Summary description for VSDemoMainForm.
    ''' </summary>
    Public Class VSDemoMainForm : Inherits Office2007Form


#Region "private members"

        Private tabbedMDIManager As TabbedMDIManager
        Private watchWindow As WatchWindowView


        Private WithEvents dockingManager1 As Syncfusion.Windows.Forms.Tools.DockingManager
        Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
        Private fileParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem17 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem18 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem27 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem28 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem29 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem30 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem31 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem32 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem33 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem34 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem35 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem36 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem37 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem38 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem39 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem40 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem41 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem42 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem43 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem44 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem45 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem46 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem47 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem48 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem49 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem50 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem51 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem52 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem53 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem54 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem55 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem56 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem57 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem58 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem59 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem60 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem61 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem62 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem63 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem64 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem65 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem66 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem67 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem68 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem69 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem70 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem71 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem72 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem73 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem74 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem75 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem76 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem77 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem78 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem79 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem80 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem81 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem82 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem83 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem84 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem85 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem86 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem88 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem89 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem90 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem91 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem92 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private mainMenuBar As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private mainToolBar As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private openFileBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents recentFileListBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
        Private errorlistView1 As VSDemo.ErrorlistView
        Private outputWindowView1 As VSDemo.OutputWindowView
        Private findResultsView1 As VSDemo.FindResultsView
        Private toolBoxView1 As VSDemo.ToolBoxView
        Private classView1 As VSDemo.ClassView
        Private solutionExplorerView1 As VSDemo.SolutionExplorerView
        Private propertiesView1 As VSDemo.PropertiesView
        Private dockingImageList As System.Windows.Forms.ImageList
        Friend imageList1 As System.Windows.Forms.ImageList
        Private windowParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem19 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private debugWindowsParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem20 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private imageList2 As System.Windows.Forms.ImageList
        Private objectBrowserView1 As VSDemo.ObjectBrowserView
        Private barItem21 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Private comboBoxBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
        Private bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private barItem22 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem23 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private barItem24 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private barItem25 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem26 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem87 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem93 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private Office2007ParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private VisualStylesParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private projectParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private debugParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Public codeEditorForm As CodeEditor = Nothing
        Private components As System.ComponentModel.IContainer
        Friend WithEvents SplashPanel1 As Syncfusion.Windows.Forms.Tools.SplashPanel
        Friend WithEvents SplashControl1 As Syncfusion.Windows.Forms.Tools.SplashControl
        Private ribbon As RibbonControlAdv

#End Region

#Region "Constructor"

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '


            InitializeComponent()
            Me.SplashControl1.ShowDialogSplash(Me)
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
            Me.tabbedMDIManager = New TabbedMDIManager()
            Me.tabbedMDIManager.AttachToMdiContainer(Me)
            Me.tabbedMDIManager.CloseOnMiddleButtonClick = True
            Me.tabbedMDIManager.TabStyle = GetType(TabRendererOffice2007)
            AddHandler tabbedMDIManager.TabControlAdded, AddressOf tabbedMDIManager_TabControlAdded
            Me.tabbedMDIManager.UseIconsInTabs = False
            AddHandler tabbedMDIManager.ContextMenuItem.BeforePopup, AddressOf ContextMenuItem_BeforePopup
            AddHandler tabbedMDIManager.BeforeDropDownPopup, AddressOf tabbedMDIManager_BeforeDropDownPopup
            Me.tabbedMDIManager.DropDownButtonVisible = True
            Me.tabbedMDIManager.CloseButtonVisible = True
        End Sub

#End Region

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VSDemoMainForm))
            Dim ccberrorlistView1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccboutputWindowView1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbfindResultsView1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbclassView1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbobjectBrowserView1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbsolutionExplorerView1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbpropertiesView1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.errorlistView1 = New VSDemo.ErrorlistView
            Me.outputWindowView1 = New VSDemo.OutputWindowView
            Me.findResultsView1 = New VSDemo.FindResultsView
            Me.objectBrowserView1 = New VSDemo.ObjectBrowserView
            Me.classView1 = New VSDemo.ClassView
            Me.solutionExplorerView1 = New VSDemo.SolutionExplorerView
            Me.propertiesView1 = New VSDemo.PropertiesView
            Me.toolBoxView1 = New VSDemo.ToolBoxView
            Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.mainMenuBar = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "MainMenu")
            Me.fileParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.dockingImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.openFileBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.recentFileListBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ListBarItem
            Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem43 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem44 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem45 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem46 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem47 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem48 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem49 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem50 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem51 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.barItem52 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem53 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem54 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem55 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.projectParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem56 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem57 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem58 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem59 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem60 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem61 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem62 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem63 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem64 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem65 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem66 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem67 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem68 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem69 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem70 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem71 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem72 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem73 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem74 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem75 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem76 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.debugParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.debugWindowsParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem83 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem84 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem85 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem77 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem78 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem79 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem80 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem81 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem82 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem22 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem23 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.windowParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem86 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem88 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem89 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem90 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem91 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem92 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.VisualStylesParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem24 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem25 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.Office2007ParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem26 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem87 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem93 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.mainToolBar = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "File")
            Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "Debug")
            Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.comboBoxBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.barItem27 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem28 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem29 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem30 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem31 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem32 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem33 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem34 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem35 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem36 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem37 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem38 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem39 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem40 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem41 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem42 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.SplashControl1 = New Syncfusion.Windows.Forms.Tools.SplashControl
            Me.SplashPanel1 = New Syncfusion.Windows.Forms.Tools.SplashPanel
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dockingManager1
            '
            Me.dockingManager1.AutoHideInterval = 350
            Me.dockingManager1.BorderColor = System.Drawing.Color.Transparent
            Me.dockingManager1.DockLayoutStream = CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream)
            Me.dockingManager1.HostControl = Me
            Me.dockingManager1.ImageList = Me.imageList1
            Me.dockingManager1.PersistState = True
            Me.dockingManager1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
            Me.dockingManager1.SetDockLabel(Me.errorlistView1, "Error List")
            Me.dockingManager1.SetDockIcon(Me.errorlistView1, 54)
            ccberrorlistView1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.errorlistView1, ccberrorlistView1)
            Me.dockingManager1.SetDockLabel(Me.outputWindowView1, "Output Window")
            Me.dockingManager1.SetDockIcon(Me.outputWindowView1, 55)
            ccboutputWindowView1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.outputWindowView1, ccboutputWindowView1)
            Me.dockingManager1.SetDockLabel(Me.findResultsView1, "Find Results")
            Me.dockingManager1.SetDockIcon(Me.findResultsView1, 17)
            ccbfindResultsView1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.findResultsView1, ccbfindResultsView1)
            Me.dockingManager1.SetDockLabel(Me.classView1, "Class View")
            Me.dockingManager1.SetDockIcon(Me.classView1, 23)
            ccbclassView1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.classView1, ccbclassView1)
            Me.dockingManager1.SetDockLabel(Me.objectBrowserView1, "Object Browser")
            ccbobjectBrowserView1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.objectBrowserView1, ccbobjectBrowserView1)
            Me.dockingManager1.SetDockLabel(Me.solutionExplorerView1, "Solution Explorer")
            Me.dockingManager1.SetDockIcon(Me.solutionExplorerView1, 31)
            ccbsolutionExplorerView1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.solutionExplorerView1, ccbsolutionExplorerView1)
            Me.dockingManager1.SetDockLabel(Me.propertiesView1, "PropertiesView")
            ccbpropertiesView1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.propertiesView1, ccbpropertiesView1)
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
            Me.imageList1.Images.SetKeyName(42, "")
            Me.imageList1.Images.SetKeyName(43, "")
            Me.imageList1.Images.SetKeyName(44, "")
            Me.imageList1.Images.SetKeyName(45, "")
            Me.imageList1.Images.SetKeyName(46, "")
            Me.imageList1.Images.SetKeyName(47, "")
            Me.imageList1.Images.SetKeyName(48, "")
            Me.imageList1.Images.SetKeyName(49, "")
            Me.imageList1.Images.SetKeyName(50, "")
            Me.imageList1.Images.SetKeyName(51, "")
            Me.imageList1.Images.SetKeyName(52, "")
            Me.imageList1.Images.SetKeyName(53, "")
            Me.imageList1.Images.SetKeyName(54, "")
            Me.imageList1.Images.SetKeyName(55, "")
            Me.imageList1.Images.SetKeyName(56, "")
            Me.imageList1.Images.SetKeyName(57, "")
            Me.imageList1.Images.SetKeyName(58, "")
            Me.imageList1.Images.SetKeyName(59, "")
            Me.imageList1.Images.SetKeyName(60, "")
            Me.imageList1.Images.SetKeyName(61, "")
            Me.imageList1.Images.SetKeyName(62, "")
            Me.imageList1.Images.SetKeyName(63, "")
            Me.imageList1.Images.SetKeyName(64, "")
            Me.imageList1.Images.SetKeyName(65, "")
            Me.imageList1.Images.SetKeyName(66, "")
            Me.imageList1.Images.SetKeyName(67, "")
            Me.imageList1.Images.SetKeyName(68, "")
            Me.imageList1.Images.SetKeyName(69, "")
            Me.imageList1.Images.SetKeyName(70, "")
            Me.imageList1.Images.SetKeyName(71, "")
            Me.imageList1.Images.SetKeyName(72, "")
            Me.imageList1.Images.SetKeyName(73, "")
            Me.imageList1.Images.SetKeyName(74, "")
            Me.imageList1.Images.SetKeyName(75, "")
            Me.imageList1.Images.SetKeyName(76, "")
            Me.imageList1.Images.SetKeyName(77, "")
            Me.imageList1.Images.SetKeyName(78, "")
            Me.imageList1.Images.SetKeyName(79, "")
            Me.imageList1.Images.SetKeyName(80, "")
            Me.imageList1.Images.SetKeyName(81, "")
            Me.imageList1.Images.SetKeyName(82, "")
            Me.imageList1.Images.SetKeyName(83, "")
            Me.imageList1.Images.SetKeyName(84, "")
            Me.imageList1.Images.SetKeyName(85, "")
            Me.imageList1.Images.SetKeyName(86, "")
            Me.imageList1.Images.SetKeyName(87, "")
            Me.imageList1.Images.SetKeyName(88, "")
            Me.imageList1.Images.SetKeyName(89, "")
            Me.imageList1.Images.SetKeyName(90, "")
            Me.imageList1.Images.SetKeyName(91, "")
            Me.imageList1.Images.SetKeyName(92, "panels_new3_close.ico")
            '
            'errorlistView1
            '
            Me.dockingManager1.SetEnableDocking(Me.errorlistView1, True)
            Me.errorlistView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.errorlistView1.Location = New System.Drawing.Point(3, 23)
            Me.errorlistView1.Name = "errorlistView1"
            Me.errorlistView1.Size = New System.Drawing.Size(998, 113)
            Me.errorlistView1.TabIndex = 5
            '
            'outputWindowView1
            '
            Me.dockingManager1.SetEnableDocking(Me.outputWindowView1, True)
            Me.outputWindowView1.Location = New System.Drawing.Point(3, 23)
            Me.outputWindowView1.Name = "outputWindowView1"
            Me.outputWindowView1.Size = New System.Drawing.Size(998, 113)
            Me.outputWindowView1.TabIndex = 7
            '
            'findResultsView1
            '
            Me.dockingManager1.SetEnableDocking(Me.findResultsView1, True)
            Me.findResultsView1.Location = New System.Drawing.Point(3, 23)
            Me.findResultsView1.Name = "findResultsView1"
            Me.findResultsView1.Size = New System.Drawing.Size(998, 113)
            Me.findResultsView1.TabIndex = 8
            '
            'objectBrowserView1
            '
            Me.dockingManager1.SetEnableDocking(Me.objectBrowserView1, True)
            Me.objectBrowserView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.objectBrowserView1.Location = New System.Drawing.Point(3, 23)
            Me.objectBrowserView1.Name = "objectBrowserView1"
            Me.objectBrowserView1.Size = New System.Drawing.Size(178, 202)
            Me.objectBrowserView1.TabIndex = 24
            '
            'classView1
            '
            Me.dockingManager1.SetEnableDocking(Me.classView1, True)
            Me.classView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.classView1.Location = New System.Drawing.Point(3, 23)
            Me.classView1.Name = "classView1"
            Me.classView1.Size = New System.Drawing.Size(178, 202)
            Me.classView1.TabIndex = 11
            '
            'solutionExplorerView1
            '
            Me.dockingManager1.SetEnableDocking(Me.solutionExplorerView1, True)
            Me.solutionExplorerView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.solutionExplorerView1.Location = New System.Drawing.Point(3, 23)
            Me.solutionExplorerView1.Name = "solutionExplorerView1"
            Me.solutionExplorerView1.Size = New System.Drawing.Size(178, 203)
            Me.solutionExplorerView1.TabIndex = 13
            '
            'propertiesView1
            '
            Me.dockingManager1.SetEnableDocking(Me.propertiesView1, True)
            Me.propertiesView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.propertiesView1.Location = New System.Drawing.Point(3, 23)
            Me.propertiesView1.Name = "propertiesView1"
            Me.propertiesView1.Size = New System.Drawing.Size(178, 708)
            Me.propertiesView1.TabIndex = 14
            '
            'toolBoxView1
            '
            Me.toolBoxView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.toolBoxView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolBoxView1.Location = New System.Drawing.Point(3, 23)
            Me.toolBoxView1.Name = "toolBoxView1"
            Me.toolBoxView1.Size = New System.Drawing.Size(365, 483)
            Me.toolBoxView1.TabIndex = 9
            '
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.mainMenuBar)
            Me.mainFrameBarManager1.Bars.Add(Me.mainToolBar)
            Me.mainFrameBarManager1.Bars.Add(Me.bar2)
            Me.mainFrameBarManager1.Categories.Add("File")
            Me.mainFrameBarManager1.Categories.Add("FileNew")
            Me.mainFrameBarManager1.Categories.Add("FileOpen")
            Me.mainFrameBarManager1.Categories.Add("FileAdd")
            Me.mainFrameBarManager1.Categories.Add("View")
            Me.mainFrameBarManager1.Categories.Add("Project")
            Me.mainFrameBarManager1.Categories.Add("Build")
            Me.mainFrameBarManager1.Categories.Add("Debug")
            Me.mainFrameBarManager1.Categories.Add("Debug Windows")
            Me.mainFrameBarManager1.Categories.Add("Window")
            Me.mainFrameBarManager1.Categories.Add("Help")
            Me.mainFrameBarManager1.Categories.Add("Data")
            Me.mainFrameBarManager1.Categories.Add("Styles")
            Me.mainFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form"
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem24, Me.barItem25, Me.VisualStylesParentBarItem, Me.Office2007ParentBarItem, Me.debugWindowsParentBarItem, Me.barItem26, Me.barItem87, Me.barItem93, Me.barItem43, Me.barItem78, Me.fileParentBarItem, Me.barItem77, Me.barItem44, Me.barItem79, Me.parentBarItem1, Me.barItem80, Me.barItem45, Me.barItem81, Me.parentBarItem2, Me.barItem82, Me.barItem46, Me.debugParentBarItem, Me.parentBarItem3, Me.comboBoxBarItem1, Me.barItem47, Me.barItem1, Me.barItem48, Me.barItem2, Me.barItem49, Me.barItem3, Me.barItem50, Me.barItem4, Me.barItem51, Me.barItem5, Me.barItem52, Me.barItem6, Me.barItem53, Me.barItem7, Me.barItem54, Me.barItem8, Me.barItem55, Me.barItem9, Me.parentBarItem4, Me.barItem10, Me.barItem19, Me.barItem11, Me.barItem20, Me.barItem12, Me.barItem21, Me.barItem13, Me.openFileBarItem, Me.barItem15, Me.barItem16, Me.barItem17, Me.barItem18, Me.barItem56, Me.barItem57, Me.barItem58, Me.barItem59, Me.barItem60, Me.barItem61, Me.barItem62, Me.barItem63, Me.barItem64, Me.barItem65, Me.barItem66, Me.barItem67, Me.barItem68, Me.projectParentBarItem, Me.barItem69, Me.barItem70, Me.barItem71, Me.barItem72, Me.barItem73, Me.barItem74, Me.barItem75, Me.barItem76, Me.parentBarItem6, Me.barItem83, Me.barItem84, Me.barItem85, Me.barItem86, Me.barItem88, Me.barItem89, Me.barItem90, Me.barItem91, Me.barItem92, Me.windowParentBarItem, Me.parentBarItem10, Me.recentFileListBarItem, Me.barItem14, Me.parentBarItem9, Me.comboBoxBarItem2, Me.barItem22, Me.barItem23, Me.parentBarItem7})
            Me.mainFrameBarManager1.ResetCustomization = False
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.mainFrameBarManager1.UpdateUIMFCStyle = True
            '
            'mainMenuBar
            '
            Me.mainMenuBar.BarName = "MainMenu"
            Me.mainMenuBar.BarStyle = CType(((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.UseWholeRow), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.mainMenuBar.Caption = "MainMenu"
            Me.mainMenuBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.fileParentBarItem, Me.parentBarItem4, Me.projectParentBarItem, Me.parentBarItem6, Me.debugParentBarItem, Me.parentBarItem7, Me.windowParentBarItem, Me.parentBarItem9, Me.VisualStylesParentBarItem})
            Me.mainMenuBar.Manager = Me.mainFrameBarManager1
            '
            'fileParentBarItem
            '
            Me.fileParentBarItem.CategoryIndex = 0
            Me.fileParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.fileParentBarItem.ID = "&File"
            Me.fileParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem2, Me.parentBarItem3, Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5, Me.barItem6, Me.barItem7, Me.parentBarItem10, Me.barItem8})
            Me.fileParentBarItem.SeparatorIndices.AddRange(New Integer() {3, 5, 7, 8, 10, 11})
            Me.fileParentBarItem.Text = "&File"
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 0
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "New"
            Me.parentBarItem1.ImageIndex = 63
            Me.parentBarItem1.ImageList = Me.imageList1
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem9, Me.barItem10, Me.barItem11})
            Me.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem1.Text = "&New"
            '
            'barItem9
            '
            Me.barItem9.CategoryIndex = 1
            Me.barItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem9.ID = "Project"
            Me.barItem9.ImageIndex = 61
            Me.barItem9.ImageList = Me.dockingImageList
            Me.barItem9.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftN
            Me.barItem9.Text = "Project"
            '
            'dockingImageList
            '
            Me.dockingImageList.ImageStream = CType(resources.GetObject("dockingImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.dockingImageList.TransparentColor = System.Drawing.Color.Transparent
            Me.dockingImageList.Images.SetKeyName(0, "")
            Me.dockingImageList.Images.SetKeyName(1, "")
            Me.dockingImageList.Images.SetKeyName(2, "")
            Me.dockingImageList.Images.SetKeyName(3, "")
            Me.dockingImageList.Images.SetKeyName(4, "")
            Me.dockingImageList.Images.SetKeyName(5, "")
            Me.dockingImageList.Images.SetKeyName(6, "")
            Me.dockingImageList.Images.SetKeyName(7, "")
            Me.dockingImageList.Images.SetKeyName(8, "")
            Me.dockingImageList.Images.SetKeyName(9, "")
            Me.dockingImageList.Images.SetKeyName(10, "")
            Me.dockingImageList.Images.SetKeyName(11, "")
            Me.dockingImageList.Images.SetKeyName(12, "")
            Me.dockingImageList.Images.SetKeyName(13, "")
            Me.dockingImageList.Images.SetKeyName(14, "")
            Me.dockingImageList.Images.SetKeyName(15, "")
            Me.dockingImageList.Images.SetKeyName(16, "")
            Me.dockingImageList.Images.SetKeyName(17, "")
            Me.dockingImageList.Images.SetKeyName(18, "")
            Me.dockingImageList.Images.SetKeyName(19, "")
            Me.dockingImageList.Images.SetKeyName(20, "")
            Me.dockingImageList.Images.SetKeyName(21, "")
            Me.dockingImageList.Images.SetKeyName(22, "")
            Me.dockingImageList.Images.SetKeyName(23, "")
            Me.dockingImageList.Images.SetKeyName(24, "")
            Me.dockingImageList.Images.SetKeyName(25, "")
            Me.dockingImageList.Images.SetKeyName(26, "")
            Me.dockingImageList.Images.SetKeyName(27, "")
            Me.dockingImageList.Images.SetKeyName(28, "")
            Me.dockingImageList.Images.SetKeyName(29, "")
            Me.dockingImageList.Images.SetKeyName(30, "")
            Me.dockingImageList.Images.SetKeyName(31, "")
            Me.dockingImageList.Images.SetKeyName(32, "")
            Me.dockingImageList.Images.SetKeyName(33, "")
            Me.dockingImageList.Images.SetKeyName(34, "")
            Me.dockingImageList.Images.SetKeyName(35, "")
            Me.dockingImageList.Images.SetKeyName(36, "")
            Me.dockingImageList.Images.SetKeyName(37, "")
            Me.dockingImageList.Images.SetKeyName(38, "")
            Me.dockingImageList.Images.SetKeyName(39, "")
            Me.dockingImageList.Images.SetKeyName(40, "")
            Me.dockingImageList.Images.SetKeyName(41, "")
            Me.dockingImageList.Images.SetKeyName(42, "")
            Me.dockingImageList.Images.SetKeyName(43, "")
            Me.dockingImageList.Images.SetKeyName(44, "")
            Me.dockingImageList.Images.SetKeyName(45, "")
            Me.dockingImageList.Images.SetKeyName(46, "")
            Me.dockingImageList.Images.SetKeyName(47, "")
            Me.dockingImageList.Images.SetKeyName(48, "")
            Me.dockingImageList.Images.SetKeyName(49, "")
            Me.dockingImageList.Images.SetKeyName(50, "")
            Me.dockingImageList.Images.SetKeyName(51, "")
            Me.dockingImageList.Images.SetKeyName(52, "")
            Me.dockingImageList.Images.SetKeyName(53, "")
            Me.dockingImageList.Images.SetKeyName(54, "")
            Me.dockingImageList.Images.SetKeyName(55, "")
            Me.dockingImageList.Images.SetKeyName(56, "")
            Me.dockingImageList.Images.SetKeyName(57, "")
            Me.dockingImageList.Images.SetKeyName(58, "")
            Me.dockingImageList.Images.SetKeyName(59, "")
            Me.dockingImageList.Images.SetKeyName(60, "")
            Me.dockingImageList.Images.SetKeyName(61, "")
            Me.dockingImageList.Images.SetKeyName(62, "")
            Me.dockingImageList.Images.SetKeyName(63, "")
            Me.dockingImageList.Images.SetKeyName(64, "")
            Me.dockingImageList.Images.SetKeyName(65, "")
            Me.dockingImageList.Images.SetKeyName(66, "")
            Me.dockingImageList.Images.SetKeyName(67, "")
            Me.dockingImageList.Images.SetKeyName(68, "")
            Me.dockingImageList.Images.SetKeyName(69, "")
            Me.dockingImageList.Images.SetKeyName(70, "")
            Me.dockingImageList.Images.SetKeyName(71, "")
            Me.dockingImageList.Images.SetKeyName(72, "")
            Me.dockingImageList.Images.SetKeyName(73, "")
            Me.dockingImageList.Images.SetKeyName(74, "")
            Me.dockingImageList.Images.SetKeyName(75, "")
            Me.dockingImageList.Images.SetKeyName(76, "")
            Me.dockingImageList.Images.SetKeyName(77, "")
            Me.dockingImageList.Images.SetKeyName(78, "")
            '
            'barItem10
            '
            Me.barItem10.CategoryIndex = 1
            Me.barItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem10.ID = "Website"
            Me.barItem10.Text = "Website"
            '
            'barItem11
            '
            Me.barItem11.CategoryIndex = 1
            Me.barItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem11.ID = "File_New"
            Me.barItem11.ImageIndex = 63
            Me.barItem11.ImageList = Me.dockingImageList
            Me.barItem11.Shortcut = System.Windows.Forms.Shortcut.CtrlN
            Me.barItem11.Text = "File"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 0
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "Open"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem12, Me.barItem13, Me.openFileBarItem})
            Me.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem2.Text = "&Open"
            '
            'barItem12
            '
            Me.barItem12.CategoryIndex = 2
            Me.barItem12.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem12.ID = "Project/Solution"
            Me.barItem12.ImageIndex = 61
            Me.barItem12.ImageList = Me.dockingImageList
            Me.barItem12.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftO
            Me.barItem12.Text = "Project/Solution"
            '
            'barItem13
            '
            Me.barItem13.CategoryIndex = 2
            Me.barItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem13.ID = "Website_1"
            Me.barItem13.Text = "Website"
            '
            'openFileBarItem
            '
            Me.openFileBarItem.CategoryIndex = 2
            Me.openFileBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.openFileBarItem.ID = "File_Open"
            Me.openFileBarItem.ImageIndex = 46
            Me.openFileBarItem.ImageList = Me.imageList1
            Me.openFileBarItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.openFileBarItem.Text = "File"
            '
            'parentBarItem3
            '
            Me.parentBarItem3.CategoryIndex = 0
            Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem3.ID = "Add"
            Me.parentBarItem3.ImageIndex = 56
            Me.parentBarItem3.ImageList = Me.imageList1
            Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem15, Me.barItem16, Me.barItem17, Me.barItem18})
            Me.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem3.Text = "&Add"
            '
            'barItem15
            '
            Me.barItem15.CategoryIndex = 3
            Me.barItem15.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem15.ID = "New Project"
            Me.barItem15.Text = "New Project"
            '
            'barItem16
            '
            Me.barItem16.CategoryIndex = 3
            Me.barItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem16.ID = "New Website"
            Me.barItem16.Text = "New Website"
            '
            'barItem17
            '
            Me.barItem17.CategoryIndex = 3
            Me.barItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem17.ID = "Existing Project"
            Me.barItem17.Text = "Existing Project"
            '
            'barItem18
            '
            Me.barItem18.CategoryIndex = 3
            Me.barItem18.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem18.ID = "Existing Website"
            Me.barItem18.Text = "Existing Website"
            '
            'barItem1
            '
            Me.barItem1.CategoryIndex = 0
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem1.ID = "Close"
            Me.barItem1.Text = "&Close"
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 0
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "Close Solution"
            Me.barItem2.Text = "C&lose Solution"
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 0
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "Save"
            Me.barItem3.ImageIndex = 30
            Me.barItem3.ImageList = Me.imageList1
            Me.barItem3.Text = "&Save"
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 0
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "Save All"
            Me.barItem4.ImageIndex = 29
            Me.barItem4.ImageList = Me.imageList1
            Me.barItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
            Me.barItem4.Text = "Save &All"
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 0
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "Export Template"
            Me.barItem5.Text = "&Export Template"
            '
            'barItem6
            '
            Me.barItem6.CategoryIndex = 0
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem6.ID = "Page Setup"
            Me.barItem6.ImageIndex = 38
            Me.barItem6.ImageList = Me.imageList1
            Me.barItem6.Text = "Page &Setup"
            '
            'barItem7
            '
            Me.barItem7.CategoryIndex = 0
            Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem7.ID = "Print"
            Me.barItem7.ImageIndex = 39
            Me.barItem7.ImageList = Me.imageList1
            Me.barItem7.Shortcut = System.Windows.Forms.Shortcut.CtrlP
            Me.barItem7.Text = "P&rint"
            '
            'parentBarItem10
            '
            Me.parentBarItem10.CategoryIndex = 0
            Me.parentBarItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem10.ID = "Recent Files"
            Me.parentBarItem10.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.recentFileListBarItem})
            Me.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItem10.Text = "Recent Files"
            '
            'recentFileListBarItem
            '
            Me.recentFileListBarItem.CategoryIndex = 0
            Me.recentFileListBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.recentFileListBarItem.ID = "RecentFileList"
            recentFileListBarItem.Text = "RecentFileList"
            '
            'barItem8
            '
            Me.barItem8.CategoryIndex = 0
            Me.barItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem8.ID = "Exit"
            Me.barItem8.Shortcut = System.Windows.Forms.Shortcut.CtrlX
            Me.barItem8.Text = "&Exit"
            '
            'parentBarItem4
            '
            Me.parentBarItem4.CategoryIndex = 4
            Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem4.ID = "View"
            Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem43, Me.barItem44, Me.barItem45, Me.barItem46, Me.barItem21, Me.barItem47, Me.barItem48, Me.barItem49, Me.barItem50, Me.barItem51, Me.barItem52, Me.barItem20, Me.barItem53, Me.barItem54, Me.barItem19, Me.barItem55})
            Me.parentBarItem4.MergeOrder = 2
            Me.parentBarItem4.SeparatorIndices.AddRange(New Integer() {4, 8, 15})
            Me.parentBarItem4.Text = "&View"
            '
            'barItem43
            '
            Me.barItem43.CategoryIndex = 4
            Me.barItem43.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem43.ID = "Code"
            Me.barItem43.Text = "Code"
            '
            'barItem44
            '
            Me.barItem44.CategoryIndex = 4
            Me.barItem44.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem44.ID = "Designer"
            Me.barItem44.Text = "Designer"
            '
            'barItem45
            '
            Me.barItem45.CategoryIndex = 4
            Me.barItem45.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem45.ID = "Open_1"
            Me.barItem45.Text = "Open"
            '
            'barItem46
            '
            Me.barItem46.CategoryIndex = 4
            Me.barItem46.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem46.ID = "Open With"
            Me.barItem46.Text = "Open With"
            '
            'barItem21
            '
            Me.barItem21.CategoryIndex = 4
            Me.barItem21.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem21.ID = "Bookmark Window"
            Me.barItem21.ImageIndex = 60
            Me.barItem21.ImageList = Me.imageList1
            Me.barItem21.Text = "Bookmark Window"
            '
            'barItem47
            '
            Me.barItem47.CategoryIndex = 4
            Me.barItem47.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem47.ID = "Server Explorer"
            Me.barItem47.ImageIndex = 58
            Me.barItem47.ImageList = Me.imageList1
            Me.barItem47.Text = "Server Explorer"
            '
            'barItem48
            '
            Me.barItem48.CategoryIndex = 4
            Me.barItem48.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem48.ID = "SolutionExplorer"
            Me.barItem48.ImageIndex = 31
            Me.barItem48.ImageList = Me.imageList1
            Me.barItem48.Text = "Solution Explorer"
            '
            'barItem49
            '
            Me.barItem49.CategoryIndex = 4
            Me.barItem49.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem49.ID = "ClassView"
            Me.barItem49.ImageIndex = 62
            Me.barItem49.ImageList = Me.imageList1
            Me.barItem49.Text = "Class View"
            '
            'barItem50
            '
            Me.barItem50.CategoryIndex = 4
            Me.barItem50.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem50.ID = "ObjectBrowser"
            Me.barItem50.ImageIndex = 61
            Me.barItem50.ImageList = Me.imageList1
            Me.barItem50.Text = "Object Browser"
            '
            'barItem51
            '
            Me.barItem51.CategoryIndex = 4
            Me.barItem51.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem51.ID = "ErrorList"
            Me.barItem51.ImageIndex = 0
            Me.barItem51.ImageList = Me.imageList2
            Me.barItem51.Text = "Error List"
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            '
            'barItem52
            '
            Me.barItem52.CategoryIndex = 4
            Me.barItem52.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem52.ID = "OutputWindow"
            Me.barItem52.ImageIndex = 33
            Me.barItem52.ImageList = Me.dockingImageList
            Me.barItem52.Text = "Output Window"
            '
            'barItem20
            '
            Me.barItem20.CategoryIndex = 4
            Me.barItem20.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem20.ID = "FindResults"
            Me.barItem20.ImageIndex = 17
            Me.barItem20.ImageList = Me.imageList1
            Me.barItem20.Text = "Find Results Window"
            '
            'barItem53
            '
            Me.barItem53.CategoryIndex = 4
            Me.barItem53.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem53.ID = "PropertiesWindow"
            Me.barItem53.ImageIndex = 27
            Me.barItem53.ImageList = Me.imageList1
            Me.barItem53.Text = "Properties Window"
            '
            'barItem54
            '
            Me.barItem54.CategoryIndex = 4
            Me.barItem54.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem54.ID = "ToolBox"
            Me.barItem54.ImageIndex = 33
            Me.barItem54.ImageList = Me.imageList1
            Me.barItem54.Text = "ToolBox"
            '
            'barItem19
            '
            Me.barItem19.CategoryIndex = 4
            Me.barItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem19.ID = "WatchList"
            Me.barItem19.ImageIndex = 47
            Me.barItem19.ImageList = Me.imageList1
            Me.barItem19.Text = "Add Watch List"
            '
            'barItem55
            '
            Me.barItem55.CategoryIndex = 4
            Me.barItem55.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem55.ID = "FullScreen"
            Me.barItem55.ImageIndex = 49
            Me.barItem55.ImageList = Me.imageList1
            Me.barItem55.Text = "FullScreen"
            '
            'projectParentBarItem
            '
            Me.projectParentBarItem.CategoryIndex = 5
            Me.projectParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.projectParentBarItem.ID = "Project_1"
            Me.projectParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem56, Me.barItem57, Me.barItem58, Me.barItem59, Me.barItem60, Me.barItem61, Me.barItem62, Me.barItem63, Me.barItem64, Me.barItem65, Me.barItem66, Me.barItem67, Me.barItem68})
            Me.projectParentBarItem.MergeOrder = 4
            Me.projectParentBarItem.SeparatorIndices.AddRange(New Integer() {5, 8, 11})
            Me.projectParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.projectParentBarItem.Text = "&Project"
            '
            'barItem56
            '
            Me.barItem56.CategoryIndex = 5
            Me.barItem56.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem56.ID = "Add Windows Form"
            Me.barItem56.ImageIndex = 69
            Me.barItem56.ImageList = Me.imageList1
            Me.barItem56.Text = "Add Windows Form"
            '
            'barItem57
            '
            Me.barItem57.CategoryIndex = 5
            Me.barItem57.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem57.ID = "Add UserControl"
            Me.barItem57.ImageIndex = 68
            Me.barItem57.ImageList = Me.imageList1
            Me.barItem57.Text = "Add UserControl"
            '
            'barItem58
            '
            Me.barItem58.CategoryIndex = 5
            Me.barItem58.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem58.ID = "Add Componenet"
            Me.barItem58.ImageIndex = 65
            Me.barItem58.ImageList = Me.imageList1
            Me.barItem58.Text = "Add Component"
            '
            'barItem59
            '
            Me.barItem59.CategoryIndex = 5
            Me.barItem59.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem59.ID = "Add Class"
            Me.barItem59.ImageIndex = 64
            Me.barItem59.ImageList = Me.imageList1
            Me.barItem59.Text = "Add Class"
            '
            'barItem60
            '
            Me.barItem60.CategoryIndex = 5
            Me.barItem60.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem60.ID = "Add New Item"
            Me.barItem60.ImageIndex = 67
            Me.barItem60.ImageList = Me.imageList1
            Me.barItem60.Text = "Add New Item"
            '
            'barItem61
            '
            Me.barItem61.CategoryIndex = 5
            Me.barItem61.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem61.ID = "Add Existing Item"
            Me.barItem61.ImageIndex = 66
            Me.barItem61.ImageList = Me.imageList1
            Me.barItem61.Text = "Add Existing Item"
            '
            'barItem62
            '
            Me.barItem62.CategoryIndex = 5
            Me.barItem62.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem62.ID = "Exclude from Project"
            Me.barItem62.Text = "Exclude from Project"
            '
            'barItem63
            '
            Me.barItem63.CategoryIndex = 5
            Me.barItem63.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem63.ID = "Show All Files"
            Me.barItem63.ImageIndex = 70
            Me.barItem63.ImageList = Me.imageList1
            Me.barItem63.Text = "Show All Files"
            '
            'barItem64
            '
            Me.barItem64.CategoryIndex = 5
            Me.barItem64.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem64.ID = "Add Reference"
            Me.barItem64.Text = "Add Reference"
            '
            'barItem65
            '
            Me.barItem65.CategoryIndex = 5
            Me.barItem65.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem65.ID = "Add WebReference"
            Me.barItem65.Text = "Add WebReference"
            '
            'barItem66
            '
            Me.barItem66.CategoryIndex = 5
            Me.barItem66.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem66.ID = "Set as Startup Project"
            Me.barItem66.Text = "Set as Startup Project"
            '
            'barItem67
            '
            Me.barItem67.CategoryIndex = 5
            Me.barItem67.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem67.ID = "Project Dependencies"
            Me.barItem67.Text = "Project Dependencies"
            '
            'barItem68
            '
            Me.barItem68.CategoryIndex = 5
            Me.barItem68.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem68.ID = "Project Build Order"
            Me.barItem68.Text = "Project Build Order"
            '
            'parentBarItem6
            '
            Me.parentBarItem6.CategoryIndex = 6
            Me.parentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem6.ID = "&Build"
            Me.parentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem69, Me.barItem70, Me.barItem71, Me.barItem72, Me.barItem73, Me.barItem74, Me.barItem75, Me.barItem76})
            Me.parentBarItem6.MergeOrder = 5
            Me.parentBarItem6.SeparatorIndices.AddRange(New Integer() {3, 6})
            Me.parentBarItem6.Text = "&Build"
            '
            'barItem69
            '
            Me.barItem69.CategoryIndex = 6
            Me.barItem69.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem69.ID = "Build Solution"
            Me.barItem69.ImageIndex = 72
            Me.barItem69.ImageList = Me.imageList1
            Me.barItem69.Text = "Build Solution"
            '
            'barItem70
            '
            Me.barItem70.CategoryIndex = 6
            Me.barItem70.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem70.ID = "Rebuild Solution"
            Me.barItem70.Text = "Rebuild Solution"
            '
            'barItem71
            '
            Me.barItem71.CategoryIndex = 6
            Me.barItem71.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem71.ID = "Clean Solution"
            Me.barItem71.Text = "Clean Solution"
            '
            'barItem72
            '
            Me.barItem72.CategoryIndex = 6
            Me.barItem72.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem72.ID = "Build Project"
            Me.barItem72.ImageIndex = 73
            Me.barItem72.ImageList = Me.imageList1
            Me.barItem72.Text = "Build Project"
            '
            'barItem73
            '
            Me.barItem73.CategoryIndex = 6
            Me.barItem73.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem73.ID = "Rebuild Project"
            Me.barItem73.Text = "Rebuild Project"
            '
            'barItem74
            '
            Me.barItem74.CategoryIndex = 6
            Me.barItem74.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem74.ID = "Clean Project"
            Me.barItem74.Text = "Clean Project"
            '
            'barItem75
            '
            Me.barItem75.CategoryIndex = 6
            Me.barItem75.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem75.ID = "Batch Build"
            Me.barItem75.Text = "Batch Build"
            '
            'barItem76
            '
            Me.barItem76.CategoryIndex = 6
            Me.barItem76.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem76.ID = "Configuration Manager"
            Me.barItem76.Text = "Configuration Manager"
            '
            'debugParentBarItem
            '
            Me.debugParentBarItem.CategoryIndex = 7
            Me.debugParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.debugParentBarItem.ID = "Debug"
            Me.debugParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.debugWindowsParentBarItem, Me.barItem77, Me.barItem78, Me.barItem79, Me.barItem80, Me.barItem81, Me.barItem82})
            Me.debugParentBarItem.MergeOrder = 6
            Me.debugParentBarItem.SeparatorIndices.AddRange(New Integer() {1, 5})
            Me.debugParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.debugParentBarItem.Text = "&Debug"
            '
            'debugWindowsParentBarItem
            '
            Me.debugWindowsParentBarItem.CategoryIndex = 7
            Me.debugWindowsParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.debugWindowsParentBarItem.ID = "Windows"
            Me.debugWindowsParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem83, Me.barItem84, Me.barItem85})
            Me.debugWindowsParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005
            Me.debugWindowsParentBarItem.Text = "Windows"
            '
            'barItem83
            '
            Me.barItem83.CategoryIndex = 8
            Me.barItem83.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem83.ID = "Break Points"
            Me.barItem83.ImageIndex = 75
            Me.barItem83.ImageList = Me.imageList1
            Me.barItem83.Text = "Break Points"
            '
            'barItem84
            '
            Me.barItem84.CategoryIndex = 8
            Me.barItem84.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem84.ID = "Output"
            Me.barItem84.ImageIndex = 79
            Me.barItem84.ImageList = Me.imageList1
            Me.barItem84.Text = "Output"
            '
            'barItem85
            '
            Me.barItem85.CategoryIndex = 8
            Me.barItem85.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem85.ID = "Immediate"
            Me.barItem85.ImageIndex = 78
            Me.barItem85.ImageList = Me.imageList1
            Me.barItem85.Text = "Immediate"
            '
            'barItem77
            '
            Me.barItem77.CategoryIndex = 7
            Me.barItem77.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem77.ID = "Start Debugging"
            Me.barItem77.ImageIndex = 80
            Me.barItem77.ImageList = Me.imageList1
            Me.barItem77.Text = "Start Debugging"
            '
            'barItem78
            '
            Me.barItem78.CategoryIndex = 7
            Me.barItem78.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem78.ID = "Start without Debugging"
            Me.barItem78.ImageIndex = 81
            Me.barItem78.ImageList = Me.imageList1
            Me.barItem78.Text = "Start without Debugging"
            '
            'barItem79
            '
            Me.barItem79.CategoryIndex = 7
            Me.barItem79.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem79.ID = "Attach to Process"
            Me.barItem79.ImageIndex = 74
            Me.barItem79.ImageList = Me.imageList1
            Me.barItem79.Text = "Attach to Process"
            '
            'barItem80
            '
            Me.barItem80.CategoryIndex = 7
            Me.barItem80.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem80.ID = "Exceptions"
            Me.barItem80.Text = "Exceptions"
            '
            'barItem81
            '
            Me.barItem81.CategoryIndex = 7
            Me.barItem81.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem81.ID = "Step Into"
            Me.barItem81.ImageIndex = 82
            Me.barItem81.ImageList = Me.imageList1
            Me.barItem81.Text = "Step Into"
            '
            'barItem82
            '
            Me.barItem82.CategoryIndex = 7
            Me.barItem82.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem82.ID = "Step Over"
            Me.barItem82.ImageIndex = 83
            Me.barItem82.ImageList = Me.imageList1
            Me.barItem82.Text = "Step Over"
            '
            'parentBarItem7
            '
            Me.parentBarItem7.CategoryIndex = 11
            Me.parentBarItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem7.ID = "Data"
            Me.parentBarItem7.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem22, Me.barItem23})
            Me.parentBarItem7.MergeOrder = 6
            Me.parentBarItem7.Text = "&Data"
            '
            'barItem22
            '
            Me.barItem22.CategoryIndex = 11
            Me.barItem22.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem22.ID = "Show Data Sources"
            Me.barItem22.ImageIndex = 91
            Me.barItem22.ImageList = Me.imageList1
            Me.barItem22.Text = "Show Data Sources"
            '
            'barItem23
            '
            Me.barItem23.CategoryIndex = 11
            Me.barItem23.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem23.ID = "Add New DataSource"
            Me.barItem23.ImageIndex = 89
            Me.barItem23.ImageList = Me.imageList1
            Me.barItem23.Text = "Add New DataSource"
            '
            'windowParentBarItem
            '
            Me.windowParentBarItem.CategoryIndex = 9
            Me.windowParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.windowParentBarItem.ID = "Windows_1"
            Me.windowParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem86, Me.barItem88, Me.barItem89, Me.barItem90, Me.barItem91, Me.barItem92})
            Me.windowParentBarItem.MergeOrder = 8
            Me.windowParentBarItem.SeparatorIndices.AddRange(New Integer() {1, 5})
            Me.windowParentBarItem.Text = "&Windows"
            '
            'barItem86
            '
            Me.barItem86.CategoryIndex = 9
            Me.barItem86.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem86.ID = "Cascade"
            Me.barItem86.ImageIndex = 50
            Me.barItem86.ImageList = Me.imageList1
            Me.barItem86.Text = "Cascade"
            '
            'barItem88
            '
            Me.barItem88.CategoryIndex = 9
            Me.barItem88.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem88.ID = "NewHorizontalTabGroup"
            Me.barItem88.Text = "New Horizontal TabGroup"
            '
            'barItem89
            '
            Me.barItem89.CategoryIndex = 9
            Me.barItem89.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem89.ID = "NewVerticalTabGroup"
            Me.barItem89.Text = "New Vertical TabGroup"
            '
            'barItem90
            '
            Me.barItem90.CategoryIndex = 9
            Me.barItem90.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem90.ID = "Tile Horizontal"
            Me.barItem90.ImageIndex = 53
            Me.barItem90.ImageList = Me.imageList1
            Me.barItem90.Text = "Tile Horizontal"
            '
            'barItem91
            '
            Me.barItem91.CategoryIndex = 9
            Me.barItem91.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem91.ID = "TileVertical"
            Me.barItem91.ImageIndex = 88
            Me.barItem91.ImageList = Me.imageList1
            Me.barItem91.Text = "Tile Vertical"
            '
            'barItem92
            '
            Me.barItem92.CategoryIndex = 9
            Me.barItem92.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem92.ID = "CloseAllWindows"
            Me.barItem92.ImageIndex = 84
            Me.barItem92.ImageList = Me.imageList1
            Me.barItem92.Text = "Close All Windows"
            '
            'parentBarItem9
            '
            Me.parentBarItem9.CategoryIndex = 10
            Me.parentBarItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem9.ID = "Help"
            Me.parentBarItem9.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem14})
            Me.parentBarItem9.MergeOrder = 9
            Me.parentBarItem9.Text = "&Help"
            '
            'barItem14
            '
            Me.barItem14.CategoryIndex = 10
            Me.barItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem14.ID = "About Syncfusion"
            Me.barItem14.ImageIndex = 45
            Me.barItem14.ImageList = Me.imageList1
            Me.barItem14.Text = "About Syncfusion"
            '
            'VisualStylesParentBarItem
            '
            Me.VisualStylesParentBarItem.CategoryIndex = 12
            Me.VisualStylesParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.VisualStylesParentBarItem.ID = "Styles"
            Me.VisualStylesParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem24, Me.barItem25, Me.Office2007ParentBarItem})
            Me.VisualStylesParentBarItem.MergeOrder = 10
            Me.VisualStylesParentBarItem.Text = "&Visual Styles"
            '
            'barItem24
            '
            Me.barItem24.CategoryIndex = 12
            Me.barItem24.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem24.ID = "Default"
            Me.barItem24.Text = "Default (VS 2005)"
            '
            'barItem25
            '
            Me.barItem25.CategoryIndex = 12
            Me.barItem25.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem25.ID = "Office2003"
            Me.barItem25.Text = "Office 2003"
            '
            'Office2007ParentBarItem
            '
            Me.Office2007ParentBarItem.CategoryIndex = 12
            Me.Office2007ParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Office2007ParentBarItem.ID = "Office2007Theme"
            Me.Office2007ParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem26, Me.barItem87, Me.barItem93})
            Me.Office2007ParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005
            Me.Office2007ParentBarItem.Text = "Office2007Theme"
            '
            'barItem26
            '
            Me.barItem26.CategoryIndex = 12
            Me.barItem26.Checked = True
            Me.barItem26.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem26.ID = "Blue"
            Me.barItem26.Text = "Blue"
            '
            'barItem87
            '
            Me.barItem87.CategoryIndex = 12
            Me.barItem87.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem87.ID = "Black"
            Me.barItem87.Text = "Black"
            '
            'barItem93
            '
            Me.barItem93.CategoryIndex = 12
            Me.barItem93.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem93.ID = "Silver"
            Me.barItem93.Text = "Silver"
            '
            'mainToolBar
            '
            Me.mainToolBar.BarName = "File"
            Me.mainToolBar.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.mainToolBar.Caption = "MainToolBar"
            Me.mainToolBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem3, Me.openFileBarItem, Me.barItem3, Me.barItem4})
            Me.mainToolBar.Manager = Me.mainFrameBarManager1
            '
            'bar2
            '
            Me.bar2.BarName = "Debug"
            Me.bar2.Caption = "debugToolBar"
            Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem48, Me.barItem49, Me.barItem53, Me.barItem54, Me.barItem19, Me.barItem51, Me.barItem52, Me.barItem20, Me.barItem77, Me.comboBoxBarItem1, Me.comboBoxBarItem2})
            Me.bar2.Manager = Me.mainFrameBarManager1
            Me.bar2.MenuItemMergeOrder = 5
            Me.bar2.SeparatorIndices.AddRange(New Integer() {8})
            '
            'comboBoxBarItem1
            '
            Me.comboBoxBarItem1.CategoryIndex = 7
            Me.comboBoxBarItem1.ChoiceList.AddRange(New String() {"Debug", "Release", "Configuration Manager.."})
            Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxBarItem1.ID = "debugCombo"
            Me.comboBoxBarItem1.ImageIndex = 18
            Me.comboBoxBarItem1.ImageList = Me.imageList1
            Me.comboBoxBarItem1.MinWidth = 70
            Me.comboBoxBarItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.comboBoxBarItem1.TextBoxValue = "Debug"
            '
            'comboBoxBarItem2
            '
            Me.comboBoxBarItem2.CategoryIndex = 7
            Me.comboBoxBarItem2.ChoiceList.AddRange(New String() {"AnyCPU", "Configuration Manager.."})
            Me.comboBoxBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxBarItem2.ID = "_1"
            Me.comboBoxBarItem2.MinWidth = 100
            Me.comboBoxBarItem2.TextBoxValue = "AnyCPU"
            '
            'barItem27
            '
            Me.barItem27.CategoryIndex = 4
            Me.barItem27.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem27.ID = "Quick Find"
            Me.barItem27.Shortcut = System.Windows.Forms.Shortcut.CtrlF
            Me.barItem27.Text = "Quick Find"
            '
            'barItem28
            '
            Me.barItem28.CategoryIndex = 4
            Me.barItem28.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem28.ID = "Quick Replace"
            Me.barItem28.Shortcut = System.Windows.Forms.Shortcut.CtrlH
            Me.barItem28.Text = "Quick Replace"
            '
            'barItem29
            '
            Me.barItem29.CategoryIndex = 4
            Me.barItem29.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem29.ID = "Find in Files"
            Me.barItem29.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftF
            Me.barItem29.Text = "Find in Files"
            '
            'barItem30
            '
            Me.barItem30.CategoryIndex = 4
            Me.barItem30.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem30.ID = "Replace in Files"
            Me.barItem30.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftH
            Me.barItem30.Text = "Replace in Files"
            '
            'barItem31
            '
            Me.barItem31.CategoryIndex = 4
            Me.barItem31.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem31.ID = "Find Symbol"
            Me.barItem31.Shortcut = System.Windows.Forms.Shortcut.AltF12
            Me.barItem31.Text = "Find Symbol"
            '
            'barItem32
            '
            Me.barItem32.CategoryIndex = 5
            Me.barItem32.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem32.ID = "Toggle Bookmark"
            Me.barItem32.Text = "Toggle Bookmark"
            '
            'barItem33
            '
            Me.barItem33.CategoryIndex = 5
            Me.barItem33.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem33.ID = "Enable Bookmark"
            Me.barItem33.Text = "Enable All Bookmarks"
            '
            'barItem34
            '
            Me.barItem34.CategoryIndex = 5
            Me.barItem34.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem34.ID = "Enable Bookmark_1"
            Me.barItem34.Text = "Enable Bookmark"
            '
            'barItem35
            '
            Me.barItem35.CategoryIndex = 5
            Me.barItem35.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem35.ID = "Previous Bookmark"
            Me.barItem35.Text = "Previous Bookmark"
            '
            'barItem36
            '
            Me.barItem36.CategoryIndex = 5
            Me.barItem36.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem36.ID = "Next Bookmark"
            Me.barItem36.Text = "Next Bookmark"
            '
            'barItem37
            '
            Me.barItem37.CategoryIndex = 5
            Me.barItem37.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem37.ID = "Clear Bookmarks"
            Me.barItem37.Text = "Clear Bookmarks"
            '
            'barItem38
            '
            Me.barItem38.CategoryIndex = 5
            Me.barItem38.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem38.ID = "Previous Bookmark in Folder"
            Me.barItem38.Text = "Previous Bookmark in Folder"
            '
            'barItem39
            '
            Me.barItem39.CategoryIndex = 5
            Me.barItem39.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem39.ID = "Next Bookmark in Folder"
            Me.barItem39.Text = "Next Bookmark in Folder"
            '
            'barItem40
            '
            Me.barItem40.CategoryIndex = 5
            Me.barItem40.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem40.ID = "Previous Bookmark in Document"
            Me.barItem40.Text = "Previous Bookmark in Document"
            '
            'barItem41
            '
            Me.barItem41.CategoryIndex = 5
            Me.barItem41.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem41.ID = "Next Bookmark in Document"
            Me.barItem41.Text = "Next Bookmark in Document"
            '
            'barItem42
            '
            Me.barItem42.CategoryIndex = 5
            Me.barItem42.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem42.ID = "Clear Bookmarks in Document"
            Me.barItem42.Text = "Clear Bookmarks in Document"
            '
            'SplashControl1
            '
            Me.SplashControl1.AutoMode = False
            Me.SplashControl1.CustomSplashPanel = Me.SplashPanel1
            Me.SplashControl1.HideHostForm = True
            Me.SplashControl1.HostForm = Me
            Me.SplashControl1.UseCustomSplashPanel = True
            '
            'SplashPanel1
            '
            Me.SplashPanel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Highlight, System.Drawing.SystemColors.HighlightText)
            Me.SplashPanel1.BackgroundImage = CType(resources.GetObject("SplashPanel1.BackgroundImage"), System.Drawing.Image)
            Me.SplashPanel1.BorderType = Syncfusion.Windows.Forms.Tools.SplashBorderType.None
            Me.SplashPanel1.DiscreetLocation = New System.Drawing.Point(0, 0)
            Me.SplashPanel1.Location = New System.Drawing.Point(264, 253)
            Me.SplashPanel1.Name = "SplashPanel1"
            Me.SplashPanel1.Size = New System.Drawing.Size(430, 230)
            Me.SplashPanel1.TabIndex = 5
            Me.SplashPanel1.Text = "SplashPanel1"
            '
            'VSDemoMainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(1016, 734)
            Me.Controls.Add(Me.SplashPanel1)
            Me.Controls.Add(Me.toolBoxView1)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "VSDemoMainForm"
            Me.Text = "Visual Studio Demo"
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New VSDemoMainForm())
        End Sub


#Region "BarItem Click Events"

        ''' <summary>
        ''' Bar Item click event functions
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub OnBarItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem1.Click, barItem8.Click, barItem11.Click, barItem19.Click, recentFileListBarItem.Click
            Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
            Select Case item.ID
                Case "File_New"
                    Dim oTemp As NewFileDialog = New NewFileDialog(Me)
                    oTemp.ShowDialog()
                Case "File_Open"
                    openFileDialog()
                Case "CloseAllWindows"
                    closeWindows()
                Case "Close"
                    If Not Me.ActiveMdiChild Is Nothing Then
                        Me.ActiveMdiChild.Close()
                    End If
                Case "NewHorizontalTabGroup"
                    If Me.tabbedMDIManager.CanCreateNewHorizontalGroup() Then
                        Me.tabbedMDIManager.CreateNewHorizontalGroup()
                    Else
                        MessageBox.Show("Reset window layout and then Click to create the Horizontal Group")
                    End If
                Case "NewVerticalTabGroup"
                    If Me.tabbedMDIManager.CanCreateNewVerticalGroup() Then
                        Me.tabbedMDIManager.CreateNewVerticalGroup()
                    Else
                        MessageBox.Show("Reset window layout and then Click to create the Vertical Group")
                    End If
                Case "TileVertical"
                    Me.LayoutMdi(MdiLayout.TileVertical)
                Case "TileHorizontal"
                    Me.LayoutMdi(MdiLayout.TileHorizontal)
                Case "Cascade"
                    Me.LayoutMdi(MdiLayout.Cascade)
                Case "RecentFileList"
                    Dim args As ListBarItemClickedEventArgs = CType(IIf(TypeOf e Is ListBarItemClickedEventArgs, e, Nothing), ListBarItemClickedEventArgs)
                    If recentFileListBarItem.ChildCaptions(args.IndexClicked) <> "" Then
                        openFileInCodeEditor(recentFileListBarItem.ChildCaptions(args.IndexClicked))
                    End If
                Case "Exit"
                    Me.Close()
                Case "WatchList"
                    createWatchWindow()
                Case "SolutionExplorer"
                    Me.dockingManager1.ActivateControl(Me.solutionExplorerView1)
                    If (Not Me.dockingManager1.GetDockVisibility(Me.solutionExplorerView1)) Then
                        Me.dockingManager1.SetDockVisibility(Me.solutionExplorerView1, True)
                    End If
                Case "PropertiesWindow"
                    Me.dockingManager1.ActivateControl(Me.propertiesView1)
                    If (Not Me.dockingManager1.GetDockVisibility(Me.propertiesView1)) Then
                        Me.dockingManager1.SetDockVisibility(Me.propertiesView1, True)
                    End If
                Case "ClassView"
                    Me.dockingManager1.ActivateControl(Me.classView1)
                    If (Not Me.dockingManager1.GetDockVisibility(Me.classView1)) Then
                        Me.dockingManager1.SetDockVisibility(Me.classView1, True)
                    End If
                Case "ErrorList"
                    Me.dockingManager1.ActivateControl(Me.errorlistView1)
                    If (Not Me.dockingManager1.GetDockVisibility(Me.errorlistView1)) Then
                        Me.dockingManager1.SetDockVisibility(Me.errorlistView1, True)
                    End If
                Case "OutputWindow"
                    Me.dockingManager1.ActivateControl(Me.outputWindowView1)
                    If (Not Me.dockingManager1.GetDockVisibility(Me.outputWindowView1)) Then
                        Me.dockingManager1.SetDockVisibility(Me.outputWindowView1, True)
                    End If
                Case "FindResults"
                    Me.dockingManager1.ActivateControl(Me.findResultsView1)
                    If (Not Me.dockingManager1.GetDockVisibility(Me.findResultsView1)) Then
                        Me.dockingManager1.SetDockVisibility(Me.findResultsView1, True)
                    End If
                Case "ToolBox"
                    Me.dockingManager1.ActivateControl(Me.toolBoxView1)
                    If (Not Me.dockingManager1.GetDockVisibility(Me.toolBoxView1)) Then
                        Me.dockingManager1.SetDockVisibility(Me.toolBoxView1, True)
                    End If
                Case "ObjectBrowser"
                    Me.dockingManager1.ActivateControl(Me.objectBrowserView1)
                    If (Not Me.dockingManager1.GetDockVisibility(Me.objectBrowserView1)) Then
                        Me.dockingManager1.SetDockVisibility(Me.objectBrowserView1, True)
                    End If
                Case "Default"
                    ChangeTheme(item, VisualStyle.Default)
                Case "Office2003"
                    ChangeTheme(item, VisualStyle.Office2003)
            End Select
        End Sub

        Private Sub closeWindows()
            Me.tabbedMDIManager.DetachFromMdiContainer(Me, True)
            For Each f As Form In Me.MdiChildren
                f.Close()
            Next f
            Me.tabbedMDIManager.AttachToMdiContainer(Me)
        End Sub

        Private listIndex As Integer = 1
        Private Sub createWatchWindow()
            Me.dockingManager1.LockDockPanelsUpdate()
            watchWindow = New WatchWindowView()
            'TODO: INSTANT VB TODO TASK: Assignments within expressions are not supported in VB.NET
            'ORIGINAL LINE: watchWindow.Name = String.Format("Watch List{0}", listIndex += 1);
            watchWindow.Name = String.Format("Watch List" + listIndex.ToString(), listIndex = listIndex + 1)
            Me.dockingManager1.DockControl(watchWindow, Me.errorlistView1, DockingStyle.Tabbed, watchWindow.Height)
            Me.dockingManager1.ActivateControl(watchWindow)
            Me.dockingManager1.UnlockDockPanelsUpdate()
            For Each i As BarItem In Me.debugWindowsParentBarItem.Items
                i.Checked = False
            Next i
            addToParentBarList(watchWindow.Name, Me.debugWindowsParentBarItem, New EventHandler(AddressOf OnDebugWindowClick))
        End Sub

        Private Sub OnDebugWindowClick(ByVal sender As Object, ByVal e As EventArgs)
            For Each i As BarItem In Me.debugWindowsParentBarItem.Items
                i.Checked = False
            Next i
            Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
            item.Checked = True
            Me.dockingManager1.ActivateControl(GetDockControl(item.Text))
        End Sub

        Private Function GetDockControl(ByVal name As String) As Control
            For Each c As Control In Me.dockingManager1.ControlsArray
                If c.Name = name Then
                    Return c
                End If
            Next c
            Return Nothing
        End Function

#End Region

#Region "Openfile functions"
        ''' <summary>
        ''' Opens a file dialog to show a list of files and then loads it in the CodeEditor
        ''' </summary>
        Private Sub openFileDialog()
            Dim ofd As OpenFileDialog = New OpenFileDialog()
            ofd.Filter = "C# Files (*.cs)|*.cs|VB Files (*.vb)|*.vb|All files|*"
            Dim dr As DialogResult = ofd.ShowDialog()
            If dr = Windows.Forms.DialogResult.OK Then
                Dim filepath As String = ofd.FileName
                openFileInCodeEditor(filepath)
            End If
        End Sub

        ''' <summary>
        ''' Helper function opens the file in CodeEditor form
        ''' </summary>
        ''' <param name="filepath"></param>
        Public Sub openFileInCodeEditor(ByVal filepath As String)
            Dim filename As String = Nothing
            If Not filepath Is Nothing Then
                filename = filepath.Substring(filepath.LastIndexOf("\") + 1)
            End If
            If (Not CheckFormPresentInChildWindow(filename)) Then
                ShowCodeEditor(filepath, filename)
                addToRecentList(filepath)
                addToParentBarList(filename, Me.windowParentBarItem, New EventHandler(AddressOf OnWindowBarItemClick))
            End If
        End Sub

        Private Sub addToParentBarList(ByVal barItemText As String, ByVal parentBarItem As ParentBarItem)
            For Each i As BarItem In Me.windowParentBarItem.Items
                i.Checked = False
            Next i
            Dim item As BarItem = New BarItem(barItemText)
            item.Checked = True
            item.ID = "myWindow" & barItemText
            item.MergeOrder = 0
            parentBarItem.Items.Add(item)
            Me.mainFrameBarManager1.Items.Add(item)
        End Sub

        Private Sub addToParentBarList(ByVal barItemText As String, ByVal parentBarItem As ParentBarItem, ByVal eventhandler As EventHandler)
            For Each i As BarItem In Me.windowParentBarItem.Items
                i.Checked = False
            Next i
            Dim item As BarItem = New BarItem(barItemText, eventhandler)
            item.Checked = True
            item.ID = "myWindow" & barItemText
            item.MergeOrder = 0
            parentBarItem.Items.Add(item)
            Me.mainFrameBarManager1.Items.Add(item)
        End Sub

        Public Function CheckFormPresentInChildWindow(ByVal filename As String) As Boolean
            Dim result As Boolean = False
            For Each f As Form In Me.MdiChildren
                If f.Text = filename Then
                    f.Activate()
                    result = True
                    Exit For
                End If
            Next f
            Return result
        End Function

        Private Sub ActivateChildForm(ByVal filename As String)
            For Each f As Form In Me.MdiChildren
                If f.Text = filename Then
                    f.Activate()
                    Exit For
                End If
            Next f
        End Sub

        Public Function CheckFormInChildWindow(ByVal filename As String) As Form
            Dim result As Form = Nothing
            For Each f As Form In Me.MdiChildren
                If f.Text = filename Then
                    f.Activate()
                    result = f
                    Exit For
                End If
            Next f
            Return result
        End Function

        Private Sub ShowCodeEditor(ByVal filepath As String, ByVal fileName As String)
            If fileName.EndsWith(".cs") Then
                codeEditorForm = New CodeEditor(VSDemo.CodeType.CS, filepath)
                codeEditorForm.MdiParent = Me
                codeEditorForm.Name = fileName
                codeEditorForm.Text = fileName
                codeEditorForm.Tag = CObj(filepath)
                codeEditorForm.Show()
            ElseIf fileName.EndsWith(".vb") Then
                codeEditorForm = New CodeEditor(VSDemo.CodeType.VB, filepath)
                codeEditorForm.MdiParent = Me
                codeEditorForm.Name = fileName
                codeEditorForm.Text = fileName
                codeEditorForm.Tag = CObj(filepath)
                codeEditorForm.Show()
            Else
                MessageBox.Show("Format not supported")
            End If
        End Sub

        Private Sub addToRecentList(ByVal filePath As String)
            If Me.recentFileListBarItem.ChildCaptions.IndexOf(filePath) = -1 Then
                If Me.recentFileListBarItem.ChildCaptions.Count <= 10 Then
                    Me.recentFileListBarItem.ChildCaptions.Add(filePath)
                Else
                    Me.recentFileListBarItem.ChildCaptions.RemoveAt(10)
                    Dim collection As StringCollection = Me.recentFileListBarItem.ChildCaptions
                    Me.recentFileListBarItem.ChildCaptions.Clear()
                    For Each s As String In collection
                        Me.recentFileListBarItem.ChildCaptions.Add(s)
                    Next s
                End If
            End If
        End Sub

        Private Sub OnWindowBarItemClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
            ActivateChildForm(item.Text)
            For Each i As BarItem In Me.windowParentBarItem.Items
                i.Checked = False
            Next i
            item.Checked = True
        End Sub


#End Region

#Region "Form Events"

        ''' <summary>
        ''' Occurs when the Form loads
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub VSDemoMainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.mainFrameBarManager1.LockHostedFormForMDIChanges = True
            Me.mainFrameBarManager1.RegisterMdiChildTypes(New Type() {GetType(CodeEditor)})
            loadFromSerializer()
            If System.IO.File.Exists(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "..\..\..\AssemblyInfo.vb") Then
                openFileInCodeEditor(System.IO.Path.GetDirectoryName(Application.ExecutablePath) & "..\..\..\AssemblyInfo.vb")
            End If
            Me.WindowState = FormWindowState.Maximized
            AddHandler MdiChildActivate, AddressOf OnMdiChildActivated
            'Me.mainFrameBarManager1.GetBarControl(Me.mainFrameBarManager1.GetMergedEquivalent(Me.mainToolBar, Me.mainToolBar)).RowIndex = 0
            'Me.mainFrameBarManager1.GetBarControl(Me.mainFrameBarManager1.GetMergedEquivalent(Me.bar2, Me.bar2)).RowIndex = 0

            'Me.mainFrameBarManager1.GetBarControl(Me.mainFrameBarManager1.GetMergedEquivalent(codeEditorForm.Bar2, codeEditorForm.Bar2)).RowIndex = 1
            'Me.mainFrameBarManager1.GetBarControl(Me.mainFrameBarManager1.GetMergedEquivalent(codeEditorForm.Bar3, codeEditorForm.Bar3)).RowIndex = 1

            Me.dockingManager1.CaptionButtons("CloseButton").ImageIndex = 92
            ApplyThemeToChildBarManager(VisualStyle.Office2007, Office2007Theme.Blue)
        End Sub

        ''' <summary>
        ''' Occurs when the MdiChild is activated
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub OnMdiChildActivated(ByVal sender As Object, ByVal e As EventArgs)
            If Not Me.ActiveMdiChild Is Nothing Then
                Me.ActiveMdiChild.Activate()
                For Each i As BarItem In Me.windowParentBarItem.Items
                    If i.Text = Me.ActiveMdiChild.Text Then
                        i.Checked = True
                    Else
                        i.Checked = False
                    End If
                Next i
            End If
        End Sub

        ''' <summary>
        ''' Occurs when the MainForm is closing
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub VSDemoMainForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
            RemoveHandler MdiChildActivate, AddressOf OnMdiChildActivated
            Me.tabbedMDIManager.DetachFromMdiContainer(Me, False)
            For Each f As Form In Me.MdiChildren
                f.Close()
            Next f
            serializeRecentlyViewedList()
            Me.dockingManager1.SaveDockState()
        End Sub

        Private Sub serializeRecentlyViewedList()
            Dim serializer As AppStateSerializer = AppStateSerializer.GetSingleton()
            serializer.SerializeObject("filelist", Me.recentFileListBarItem.ChildCaptions, True)
        End Sub
#End Region

#Region "TabbedMDI Events"
        ''' <summary>
        ''' Occurs when a new Form is added to the TabbedMDIManager instance
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="args"></param>
        Private tabControl As TabControlAdv
        Private Sub tabbedMDIManager_TabControlAdded(ByVal sender As Object, ByVal args As TabbedMDITabControlEventArgs)
            tabControl = args.TabControl
            tabControl.TabPrimitivesHost.Visible = True
            tabControl.TabGap = 7
        End Sub

        Private Sub tabbedMDIManager_BeforeDropDownPopup(ByVal sender As Object, ByVal e As DropDownPopupEventArgs)
            Select Case theme
                Case "VS2005"
                    e.ParentBarItem.Style = VisualStyle.VS2005
                Case "Office2003"
                    e.ParentBarItem.Style = VisualStyle.Office2003
                Case "Office2007"
                    e.ParentBarItem.Style = VisualStyle.Office2007
            End Select
        End Sub

        Private Sub ContextMenuItem_BeforePopup(ByVal sender As Object, ByVal e As CancelEventArgs)
            Select Case theme
                Case "VS2005"
                    Me.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.VS2005
                Case "Office2003"
                    Me.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
                Case "Office2007"
                    Me.tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            End Select
        End Sub
#End Region

#Region "Recently used files"

        ''' <summary>
        ''' Loads the save state of the recent file list from the serialized object
        ''' </summary>
        Private Sub loadFromSerializer()
            Dim serializer As AppStateSerializer = AppStateSerializer.GetSingleton()
            Dim fileList As Object = serializer.DeserializeObject("filelist")
            If Not fileList Is Nothing Then
                Dim collection As System.Collections.Specialized.StringCollection = CType(IIf(TypeOf fileList Is System.Collections.Specialized.StringCollection, fileList, Nothing), System.Collections.Specialized.StringCollection)
                Me.recentFileListBarItem.ChildCaptions.Clear()
                For Each s As String In collection
                    If System.IO.File.Exists(s) Then
                        Me.recentFileListBarItem.ChildCaptions.Add(s)
                    End If
                Next s
            End If
        End Sub

#End Region

#Region "About form"

        Private Sub barItem14_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem14.Click
            'Dim aboutForm As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
            '   aboutForm.ShowDialog()
        End Sub

#End Region

#Region "Docking Events"

        ''' <summary>
        ''' Occurs when the dock state of the control is changed
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="arg"></param>
        Private Sub dockingManager1_DockStateChanged(ByVal sender As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.DockStateChangeEventArgs) Handles dockingManager1.DockStateChanged
            SetHotTrackFalse()
        End Sub

        ''' <summary>
        ''' Occurs when the docked control is activated
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="arg"></param>
        Private Sub dockingManager1_DockControlActivated(ByVal sender As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.DockActivationChangedEventArgs) Handles dockingManager1.DockControlActivated
            If arg.Control.Name.StartsWith("Watch List") Then
                For Each i As BarItem In Me.debugWindowsParentBarItem.Items
                    If i.Text = arg.Control.Name Then
                        i.Checked = True
                    Else
                        i.Checked = False
                    End If
                Next i
            End If
        End Sub

        ''' <summary>
        ''' Occurs when the docking visibility is changed
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="arg"></param>
        Private Sub dockingManager1_DockVisibilityChanged(ByVal sender As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.DockVisibilityChangedEventArgs) Handles dockingManager1.DockVisibilityChanged
            If arg.Control.Name.StartsWith("Watch List") Then
                For Each i As BarItem In Me.debugWindowsParentBarItem.Items
                    If i.Text = arg.Control.Name Then
                        Me.debugWindowsParentBarItem.Items.Remove(i)
                        Exit For
                    Else
                        i.Checked = False
                    End If
                Next i
            End If
        End Sub

        ''' <summary>
        ''' Sets the HotTracking of docked windows to false
        ''' </summary>
        Private Sub SetHotTrackFalse()
            For Each ctrl As Control In Me.dockingManager1.ControlsArray
                Dim dhost As Syncfusion.Windows.Forms.Tools.DockHost = CType(IIf(TypeOf ctrl.Parent Is Syncfusion.Windows.Forms.Tools.DockHost, ctrl.Parent, Nothing), Syncfusion.Windows.Forms.Tools.DockHost)
                If Not dhost Is Nothing Then
                    Dim dhc As Syncfusion.Windows.Forms.Tools.DockHostController = CType(IIf(TypeOf dhost.InternalController Is Syncfusion.Windows.Forms.Tools.DockHostController, dhost.InternalController, Nothing), Syncfusion.Windows.Forms.Tools.DockHostController)

                    If TypeOf dhc.ParentController Is Syncfusion.Windows.Forms.Tools.DockTabController Then
                        Dim docktab As Syncfusion.Windows.Forms.Tools.DockTabControl = (CType(IIf(TypeOf dhc.ParentController Is Syncfusion.Windows.Forms.Tools.DockTabController, dhc.ParentController, Nothing), Syncfusion.Windows.Forms.Tools.DockTabController)).TabControl
                        docktab.HotTrack = False
                    End If
                End If
            Next ctrl
        End Sub

        ''' <summary>
        ''' Occurs when the DockState load is finished
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub dockingManager1_NewDockStateEndLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles dockingManager1.NewDockStateEndLoad
            Me.propertiesView1.Visible = True

            Me.dockingManager1.DockControl(Me.toolBoxView1, Me, DockingStyle.Left, 200)
            Me.dockingManager1.SetDockVisibility(Me.toolBoxView1, True)
            Me.dockingManager1.DockControl(Me.propertiesView1, Me, DockingStyle.Right, 200)
            Me.dockingManager1.SetDockVisibility(Me.propertiesView1, True)
            Me.dockingManager1.SetDockVisibility(Me.objectBrowserView1, True)
            Me.dockingManager1.DockControl(Me.objectBrowserView1, Me.propertiesView1, DockingStyle.Bottom, 200)
            Me.dockingManager1.SetDockVisibility(Me.errorlistView1, True)
            Me.dockingManager1.DockControl(Me.errorlistView1, Me, DockingStyle.Bottom, 150)

            SetHotTrackFalse()
        End Sub

#End Region

#Region "ThemeEffects"
        Private theme As String = "Office2007"
        Private Sub ChangeTheme(ByVal item As BarItem, ByVal type As VisualStyle)
            For Each i As BarItem In Me.VisualStylesParentBarItem.Items
                If i.ID = item.ID Then
                    i.Checked = True
                Else
                    i.Checked = False
                End If
            Next i
            For Each i As BarItem In Me.Office2007ParentBarItem.Items
                i.Checked = False
            Next i

            Select Case type
                Case VisualStyle.Default
                    Me.toolBoxView1.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.VS2005
                    Me.toolBoxView1.gvcSyncfusion.BackColor = Color.FromArgb(218, 216, 221)
                    Me.toolBoxView1.gvcComponents.BackColor = Color.FromArgb(218, 216, 221)
                    Me.toolBoxView1.gvcWindowsForms.BackColor = Color.FromArgb(218, 216, 221)
                    Me.toolBoxView1.gvcGeneral.BackColor = Color.FromArgb(218, 216, 221)

                    Me.dockingManager1.VisualStyle = VisualStyle.VS2005
                    Me.errorlistView1.errorlistToolBar.Style = VisualStyle.VS2005
                    Me.errorlistView1.errorlistToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.solutionExplorerView1.solutionExplorerToolBar.Style = VisualStyle.VS2005
                    Me.solutionExplorerView1.solutionExplorerToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.classView1.classViewToolBar.Style = VisualStyle.VS2005
                    Me.classView1.classViewToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.objectBrowserView1.objectBrowserToolBar.Style = VisualStyle.VS2005
                    Me.objectBrowserView1.objectBrowserToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.propertiesView1.propertiesToolBar.Style = VisualStyle.VS2005
                    Me.propertiesView1.propertiesToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.mainFrameBarManager1.Style = VisualStyle.VS2005
                    Me.projectParentBarItem.Style = VisualStyle.VS2005
                    Me.debugParentBarItem.Style = VisualStyle.VS2005
                    Me.tabbedMDIManager.TabStyle = GetType(TabRendererWhidbey)
                    Me.ColorScheme = Office2007Theme.Silver
                    ApplyThemeToChildBarManager(VisualStyle.VS2005)
                    SetColorToViewItems(SystemColors.Control, Color.Black)
                    theme = "VS2005"
                Case VisualStyle.Office2003
                    Me.toolBoxView1.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2003
                    Me.toolBoxView1.gvcSyncfusion.BackColor = Color.FromArgb(218, 216, 221)
                    Me.toolBoxView1.gvcComponents.BackColor = Color.FromArgb(218, 216, 221)
                    Me.toolBoxView1.gvcWindowsForms.BackColor = Color.FromArgb(218, 216, 221)
                    Me.toolBoxView1.gvcGeneral.BackColor = Color.FromArgb(218, 216, 221)

                    Me.dockingManager1.VisualStyle = type
                    Me.errorlistView1.errorlistToolBar.Style = type
                    Me.errorlistView1.errorlistToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.solutionExplorerView1.solutionExplorerToolBar.Style = type
                    Me.solutionExplorerView1.solutionExplorerToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.classView1.classViewToolBar.Style = type
                    Me.classView1.classViewToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.objectBrowserView1.objectBrowserToolBar.Style = type
                    Me.objectBrowserView1.objectBrowserToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.propertiesView1.propertiesToolBar.Style = type
                    Me.propertiesView1.propertiesToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

                    Me.mainFrameBarManager1.Style = type
                    Me.projectParentBarItem.Style = type
                    Me.debugParentBarItem.Style = type
                    Me.ColorScheme = Office2007Theme.Silver
                    Me.tabbedMDIManager.TabStyle = GetType(TabRendererWhidbey)
                    ApplyThemeToChildBarManager(VisualStyle.Office2003)
                    theme = "Office2003"
                    SetColorToViewItems(SystemColors.Control, Color.Black)
            End Select
        End Sub

        Private Sub OnOfficeThemeSelected(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem26.Click, barItem87.Click, barItem93.Click
            Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
            Me.Office2007ParentBarItem.Checked = True
            Me.toolBoxView1.gBToolBox.VisualStyle = VisualStyle.Office2007
            Me.dockingManager1.VisualStyle = VisualStyle.Office2007
            Me.errorlistView1.errorlistToolBar.Style = VisualStyle.Office2007
            Me.solutionExplorerView1.solutionExplorerToolBar.Style = VisualStyle.Office2007
            Me.classView1.classViewToolBar.Style = VisualStyle.Office2007
            Me.objectBrowserView1.objectBrowserToolBar.Style = VisualStyle.Office2007
            Me.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2007
            Me.mainFrameBarManager1.Style = VisualStyle.Office2007
            Me.projectParentBarItem.Style = VisualStyle.Office2007
            Me.debugParentBarItem.Style = VisualStyle.Office2007
            Me.tabbedMDIManager.TabStyle = GetType(TabRendererDockingWhidbey)
            Select Case item.ID
                Case "Blue"
                    ApplyOffice2007Theme(Syncfusion.Windows.Forms.Office2007Theme.Blue, 220, 235, 254, Color.MidnightBlue)
                    Me.ColorScheme = Office2007Theme.Blue
                    tabbedMDIManager.TabStyle = GetType(TabRendererOffice2007)
                    For Each tabhost As TabHost In tabbedMDIManager.TabGroupHosts
                        tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Blue
                    Next tabhost
                Case "Black"
                    ApplyOffice2007Theme(Syncfusion.Windows.Forms.Office2007Theme.Black, 166, 172, 181, Color.White)
                    Me.ColorScheme = Office2007Theme.Black
                    tabbedMDIManager.TabStyle = GetType(TabRendererOffice2007)
                    For Each tabhost As TabHost In tabbedMDIManager.TabGroupHosts
                        tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Black
                    Next tabhost
                Case "Silver"
                    ApplyOffice2007Theme(Syncfusion.Windows.Forms.Office2007Theme.Silver, 209, 211, 225, Color.Black)
                    Me.ColorScheme = Office2007Theme.Silver
                    tabbedMDIManager.TabStyle = GetType(TabRendererOffice2007)
                    For Each tabhost As TabHost In tabbedMDIManager.TabGroupHosts
                        tabhost.MDITabPanel.Office2007ColorScheme = Office2007Theme.Silver
                    Next tabhost
            End Select
            For Each i As BarItem In Me.Office2007ParentBarItem.Items
                If i.ID = item.ID Then
                    i.Checked = True
                Else
                    i.Checked = False
                End If
            Next i

            For Each i As BarItem In Me.VisualStylesParentBarItem.Items
                i.Checked = False
            Next i
            theme = "Office2007"
        End Sub

        Private Sub ApplyOffice2007Theme(ByVal theme As Syncfusion.Windows.Forms.Office2007Theme, ByVal r As Integer, ByVal g As Integer, ByVal b As Integer, ByVal forecolor As Color)
            Me.mainFrameBarManager1.Office2007Theme = theme
            Me.projectParentBarItem.Office2007Theme = theme
            Me.dockingManager1.Office2007Theme = theme
            Me.debugParentBarItem.Office2007Theme = theme
            Me.errorlistView1.errorlistToolBar.Style = VisualStyle.Office2007
            Me.errorlistView1.errorlistToolBar.Office2007Theme = theme
            Me.solutionExplorerView1.solutionExplorerToolBar.Office2007Theme = theme
            Me.classView1.classViewToolBar.Office2007Theme = theme
            Me.objectBrowserView1.objectBrowserToolBar.Office2007Theme = theme
            Me.propertiesView1.propertiesToolBar.Office2007Theme = theme
            Me.toolBoxView1.gBToolBox.Office2007Theme = theme
            SetColorToViewItems(Color.FromArgb(r, g, b), forecolor)
            ApplyThemeToChildBarManager(VisualStyle.Office2007, theme)
        End Sub
        Private tempForeColor As Color
        Private Sub SetColorToViewItems(ByVal backColor As Color, ByVal forecolor As Color)
            tempForeColor = forecolor
            Me.toolBoxView1.gvcSyncfusion.BackColor = backColor
            Me.toolBoxView1.gvcSyncfusion.ForeColor = forecolor
            Me.toolBoxView1.gvcComponents.BackColor = backColor
            Me.toolBoxView1.gvcComponents.ForeColor = forecolor
            Me.toolBoxView1.gvcWindowsForms.BackColor = backColor
            Me.toolBoxView1.gvcWindowsForms.ForeColor = forecolor
            Me.toolBoxView1.gvcGeneral.BackColor = backColor
            Me.toolBoxView1.gvcGeneral.ForeColor = forecolor
        End Sub


        Private Sub ApplyThemeToChildBarManager(ByVal style As VisualStyle)
            For Each f As Form In Me.MdiChildren
                If TypeOf f Is CodeEditor Then
                    Dim childCodeForm As CodeEditor = CType(f, CodeEditor)
                    childCodeForm.EditParentBarItem.Style = style
                    childCodeForm.FormatParentBarItem.Style = style
                    AddHandler childCodeForm.editControl1.MenuFill, AddressOf editControl_MenuFill
                End If
            Next f
        End Sub

        Private Sub ApplyThemeToChildBarManager(ByVal style As VisualStyle, ByVal theme As Syncfusion.Windows.Forms.Office2007Theme)
            For Each f As Form In Me.MdiChildren
                If TypeOf f Is CodeEditor Then
                    Dim childCodeForm As CodeEditor = CType(f, CodeEditor)
                    childCodeForm.EditParentBarItem.Style = style
                    childCodeForm.EditParentBarItem.Office2007Theme = theme
                    childCodeForm.FormatParentBarItem.Style = style
                    childCodeForm.FormatParentBarItem.Office2007Theme = theme

                    AddHandler childCodeForm.editControl1.MenuFill, AddressOf editControl_MenuFill
                End If
            Next f
        End Sub

        Private Sub editControl_MenuFill(ByVal sender As Object, ByVal e As EventArgs)
            Dim cm As Syncfusion.Windows.Forms.Edit.Implementation.ContextMenuManager = CType(sender, Syncfusion.Windows.Forms.Edit.Implementation.ContextMenuManager)
            Select Case theme
                Case "VS2005"
                    cm.ContextMenuProvider.SetVisualStyle(VisualStyle.VS2005)
                Case "Office2003"
                    cm.ContextMenuProvider.SetVisualStyle(VisualStyle.Office2003)
                Case "Office2007"
                    cm.ContextMenuProvider.SetVisualStyle(VisualStyle.Office2007)
            End Select
        End Sub
#End Region

      
        Private Sub SplashPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplashPanel1.Paint

        End Sub

     
      
        Private Sub barItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.toolBoxView1.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.VS2005
            Me.toolBoxView1.gvcSyncfusion.BackColor = Color.FromArgb(218, 216, 221)
            Me.toolBoxView1.gvcComponents.BackColor = Color.FromArgb(218, 216, 221)
            Me.toolBoxView1.gvcWindowsForms.BackColor = Color.FromArgb(218, 216, 221)
            Me.toolBoxView1.gvcGeneral.BackColor = Color.FromArgb(218, 216, 221)

            Me.dockingManager1.VisualStyle = VisualStyle.VS2005
            Me.errorlistView1.errorlistToolBar.Style = VisualStyle.VS2005
            Me.errorlistView1.errorlistToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.solutionExplorerView1.solutionExplorerToolBar.Style = VisualStyle.VS2005
            Me.solutionExplorerView1.solutionExplorerToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.classView1.classViewToolBar.Style = VisualStyle.VS2005
            Me.classView1.classViewToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.objectBrowserView1.objectBrowserToolBar.Style = VisualStyle.VS2005
            Me.objectBrowserView1.objectBrowserToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.propertiesView1.propertiesToolBar.Style = VisualStyle.VS2005
            Me.propertiesView1.propertiesToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.mainFrameBarManager1.Style = VisualStyle.VS2005
            Me.projectParentBarItem.Style = VisualStyle.VS2005
            Me.debugParentBarItem.Style = VisualStyle.VS2005
            Me.tabbedMDIManager.TabStyle = GetType(TabRendererWhidbey)
            Me.ColorScheme = Office2007Theme.Silver
            ApplyThemeToChildBarManager(VisualStyle.VS2005)
            SetColorToViewItems(SystemColors.Control, Color.Black)
            theme = "VS2005"
        End Sub

        Private Sub barItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            Me.toolBoxView1.gBToolBox.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2003
            Me.toolBoxView1.gvcSyncfusion.BackColor = Color.FromArgb(218, 216, 221)
            Me.toolBoxView1.gvcComponents.BackColor = Color.FromArgb(218, 216, 221)
            Me.toolBoxView1.gvcWindowsForms.BackColor = Color.FromArgb(218, 216, 221)
            Me.toolBoxView1.gvcGeneral.BackColor = Color.FromArgb(218, 216, 221)

            Me.dockingManager1.VisualStyle = VisualStyle.Office2003
            Me.errorlistView1.errorlistToolBar.Style = VisualStyle.Office2003
            Me.errorlistView1.errorlistToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.solutionExplorerView1.solutionExplorerToolBar.Style = VisualStyle.Office2003
            Me.solutionExplorerView1.solutionExplorerToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.classView1.classViewToolBar.Style = VisualStyle.Office2003
            Me.classView1.classViewToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.objectBrowserView1.objectBrowserToolBar.Style = VisualStyle.Office2003
            Me.objectBrowserView1.objectBrowserToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.propertiesView1.propertiesToolBar.Style = VisualStyle.Office2003
            Me.propertiesView1.propertiesToolBar.BackgroundColor = New Syncfusion.Drawing.BrushInfo()

            Me.mainFrameBarManager1.Style = VisualStyle.Office2003
            Me.projectParentBarItem.Style = VisualStyle.Office2003
            Me.debugParentBarItem.Style = VisualStyle.Office2003
            Me.ColorScheme = Office2007Theme.Silver
            Me.tabbedMDIManager.TabStyle = GetType(TabRendererWhidbey)
            ApplyThemeToChildBarManager(VisualStyle.Office2003)
            theme = "Office2003"
            SetColorToViewItems(SystemColors.Control, Color.Black)
        End Sub
    End Class

End Namespace

