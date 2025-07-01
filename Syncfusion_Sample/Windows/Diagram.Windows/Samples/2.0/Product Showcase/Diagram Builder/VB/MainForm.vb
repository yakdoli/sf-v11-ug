#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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
Imports System.Drawing.Design
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.ComponentModel
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms
Imports System.Resources
Imports System.Drawing.Printing
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap
Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Scripting
Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Runtime.Serialization
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace Syncfusion.Windows.Forms.Diagram.Samples.DiagramTool
    ''' <summary>
    ''' MainForm for the Essential Diagram Builder.
    ''' </summary>
    Public Class MainForm : Inherits Office2007Form
#Region "Fields"
        Dim docForm As DiagramForm
        Private dockingManager As Tools.DockingManager
        Private tabbedMDIManager As Tools.TabbedMDIManager
        Private openPaletteDialog As OpenFileDialog
        Private openDiagramDialog As OpenFileDialog
        Private saveDiagramDialog As SaveFileDialog
        Private savePaletteDialog As SaveFileDialog
        Private openImageDialog As OpenFileDialog
        Private symbolPaletteGroupBar As PaletteGroupBar
        Private mainFrameBarManager As Tools.XPMenus.MainFrameBarManager
        Private mainMenuBar As Tools.XPMenus.Bar
        Private WithEvents biFileNew As Tools.XPMenus.BarItem
        Private WithEvents biFileOpen As Tools.XPMenus.BarItem
        Private WithEvents biFileSave As Tools.XPMenus.BarItem
        Private WithEvents biFileSaveAs As Tools.XPMenus.BarItem
        Private WithEvents biAddPalette As Tools.XPMenus.BarItem
        Private WithEvents biSavePalette As Tools.XPMenus.BarItem
        Private WithEvents biFileExit As Tools.XPMenus.BarItem
        Private WithEvents barShowRulers As Tools.XPMenus.BarItem
        Private WithEvents biTabbedMDI As Tools.XPMenus.BarItem
        Private WithEvents barItemEditCut As Tools.XPMenus.BarItem
        Private WithEvents barItemEditCopy As Tools.XPMenus.BarItem
        Private WithEvents barItemEditPaste As Tools.XPMenus.BarItem
        Private WithEvents barItemEditUndo As Tools.XPMenus.BarItem
        Private WithEvents barItemEditRedo As Tools.XPMenus.BarItem
        Private WithEvents barItemEditDelete As Tools.XPMenus.BarItem
        Private WithEvents barItemAbout As Tools.XPMenus.BarItem
        Private propertyEditor_Renamed As PropertyEditor
        Private standardToolbar As Tools.XPMenus.Bar
        Private WithEvents biFilePrint As Tools.XPMenus.BarItem
        Private WithEvents biPageSetup As Tools.XPMenus.BarItem
        Private WithEvents barItemViewSymbolPalette As Tools.XPMenus.BarItem
        Private WithEvents barItemViewProperties As Tools.XPMenus.BarItem
        Private WithEvents barItemEditSelectAll As Tools.XPMenus.BarItem
        Private parentBarItemEdit As Tools.XPMenus.ParentBarItem
        Private parentBarItemFile As Tools.XPMenus.ParentBarItem
        Private parentBarItemView As Tools.XPMenus.ParentBarItem
        Private parentBarItemWindow As Tools.XPMenus.ParentBarItem
        Private parentBarItemHelp As Tools.XPMenus.ParentBarItem
        Private smallImageList As ImageList
        Private m_documentExplorer As DocumentExplorer
        Private WithEvents barItemDocumentExplorer As Tools.XPMenus.BarItem
        Private resStringMgr As ResourceManager
        Private WithEvents biPrintPreview As Tools.XPMenus.BarItem
        Private WithEvents barItemPanZoom As Tools.XPMenus.BarItem
        Private overviewControl1 As OverviewControl
        Private WithEvents barItemHeaderFooter As Tools.XPMenus.BarItem
        Private WithEvents barItemPageBorders As Tools.XPMenus.BarItem
        Private parentBarItemToolsGrouping As Tools.XPMenus.ParentBarItem
        Private parentBarItemToolsOrder As Tools.XPMenus.ParentBarItem
        Private WithEvents barItemAlignLeft As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemAlignCenter As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemAlignRight As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemAlignTop As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemAlignMiddle As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemAlignBottom As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemFlipHorizontally As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemFlipVertically As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemFlipBoth As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemGroupingGroup As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemGroupingUnGroup As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemOrderFront As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemOrderForward As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemOrderBackward As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemOrderBack As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemRotateClock As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemRotateConter As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemResizeWidth As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemResizeHeight As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemResizeSize As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemResizeAcross As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemResizeDown As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItemActions As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItemAlign As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItemFlip As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItemRotate As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItemResize As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItemNode As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private parentBarItemPopUp As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItemLayout As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItemFormat As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItemFillStyle As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItemShadowStyle As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private components As IContainer
#End Region

#Region "Constructors"

        Dim _initialFileLoc As String = ""
        Public Sub New(ByVal fileLocation As String)
            Me.New()
            _initialFileLoc = fileLocation
        End Sub


        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' Initialize tabbed MDI manager
            '
            tabbedMDIManager = New Tools.TabbedMDIManager()
            tabbedMDIManager.AttachToMdiContainer(Me)

            AddHandler tabbedMDIManager.TabControlAdded, AddressOf tabbedMDIManager_TabControlAdded

            ' Create resource manager for strings
            Me.resStringMgr = New ResourceManager("Strings", GetType(MainForm).Assembly)

            AddHandler Closing, AddressOf MainForm_Closing

            ' Wire up OnIdle processing
            AddHandler Application.Idle, AddressOf OnIdle
            Me.propertyEditor_Renamed.PropertyGrid.BackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
            Me.propertyEditor_Renamed.PropertyGrid.CommandsBackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
            Me.propertyEditor_Renamed.PropertyGrid.CommandsForeColor = System.Drawing.Color.MidnightBlue
            Me.propertyEditor_Renamed.PropertyGrid.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.propertyEditor_Renamed.PropertyGrid.HelpBackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
            Me.propertyEditor_Renamed.PropertyGrid.HelpForeColor = System.Drawing.Color.MidnightBlue
            Me.propertyEditor_Renamed.PropertyGrid.LineColor = System.Drawing.Color.FromArgb((CByte(185)), (CByte(216)), (CByte(255)))
            Me.propertyEditor_Renamed.PropertyGrid.ViewBackColor = System.Drawing.Color.FromArgb((CByte(227)), (CByte(239)), (CByte(255)))
            Me.propertyEditor_Renamed.PropertyGrid.ViewForeColor = System.Drawing.Color.MidnightBlue
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

#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim captionButton1 As Syncfusion.Windows.Forms.Tools.CaptionButton = New Syncfusion.Windows.Forms.Tools.CaptionButton()
            Dim toolTipInfo1 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
            Dim captionButton2 As Syncfusion.Windows.Forms.Tools.CaptionButton = New Syncfusion.Windows.Forms.Tools.CaptionButton()
            Dim toolTipInfo2 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
            Dim captionButton3 As Syncfusion.Windows.Forms.Tools.CaptionButton = New Syncfusion.Windows.Forms.Tools.CaptionButton()
            Dim toolTipInfo3 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
            Dim captionButton4 As Syncfusion.Windows.Forms.Tools.CaptionButton = New Syncfusion.Windows.Forms.Tools.CaptionButton()
            Dim toolTipInfo4 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.dockingManager = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.propertyEditor_Renamed = New Syncfusion.Windows.Forms.Diagram.Controls.PropertyEditor()
            Me.symbolPaletteGroupBar = New Syncfusion.Windows.Forms.Diagram.Controls.PaletteGroupBar()
            Me.overviewControl1 = New Syncfusion.Windows.Forms.Diagram.Controls.OverviewControl()
            Me.m_documentExplorer = New Syncfusion.Windows.Forms.Diagram.Controls.DocumentExplorer()
            Me.openPaletteDialog = New System.Windows.Forms.OpenFileDialog()
            Me.savePaletteDialog = New System.Windows.Forms.SaveFileDialog()
            Me.openDiagramDialog = New System.Windows.Forms.OpenFileDialog()
            Me.saveDiagramDialog = New System.Windows.Forms.SaveFileDialog()
            Me.smallImageList = New System.Windows.Forms.ImageList(Me.components)
            Me.openImageDialog = New System.Windows.Forms.OpenFileDialog()
            Me.mainFrameBarManager = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.mainMenuBar = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager, "MainMenu")
            Me.parentBarItemFile = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.biFileNew = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.biFileOpen = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.biFileSave = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.biFileSaveAs = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.biAddPalette = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.biSavePalette = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.biPageSetup = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.biPrintPreview = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.biFilePrint = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.biFileExit = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemEdit = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barItemEditUndo = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemEditRedo = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemEditSelectAll = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemEditDelete = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemEditCut = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemEditCopy = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemEditPaste = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemFormat = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barItemFillStyle = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemShadowStyle = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemView = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barShowRulers = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemViewSymbolPalette = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemViewProperties = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemPanZoom = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemDocumentExplorer = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemHeaderFooter = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemPageBorders = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemActions = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.parentBarItemAlign = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barItemAlignLeft = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemAlignCenter = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemAlignRight = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemAlignTop = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemAlignMiddle = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemAlignBottom = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemFlip = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barItemFlipHorizontally = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemFlipVertically = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemFlipBoth = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemToolsGrouping = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barItemGroupingGroup = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemGroupingUnGroup = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemToolsOrder = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barItemOrderFront = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemOrderForward = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemOrderBackward = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemOrderBack = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemRotate = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barItemRotateClock = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemRotateConter = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemResize = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barItemResizeWidth = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemResizeHeight = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemResizeSize = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemResizeAcross = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemResizeDown = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.barItemLayout = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemWindow = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.biTabbedMDI = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.parentBarItemHelp = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.barItemAbout = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
            Me.standardToolbar = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager, "Standard")
            Me.parentBarItemPopUp = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            Me.parentBarItemNode = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
            CType(Me.dockingManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.symbolPaletteGroupBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mainFrameBarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dockingManager
            ' 
            Me.dockingManager.ActiveCaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            captionButton1.ImageIndex = -1
            captionButton1.Name = "CloseButton"
            captionButton1.SuperToolTipInfo = toolTipInfo1
            captionButton1.TransparentImageColor = System.Drawing.Color.Transparent
            captionButton1.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close
            captionButton2.ImageIndex = -1
            captionButton2.Name = "PinButton"
            captionButton2.SuperToolTipInfo = toolTipInfo2
            captionButton2.TransparentImageColor = System.Drawing.Color.Transparent
            captionButton2.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin
            captionButton3.ImageIndex = -1
            captionButton3.Name = "MenuButton"
            captionButton3.SuperToolTipInfo = toolTipInfo3
            captionButton3.TransparentImageColor = System.Drawing.Color.Transparent
            captionButton3.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu
            captionButton4.ImageIndex = -1
            captionButton4.Name = "MaximizeButton"
            captionButton4.SuperToolTipInfo = toolTipInfo4
            captionButton4.TransparentImageColor = System.Drawing.Color.Transparent
            captionButton4.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize
            Me.dockingManager.CaptionButtons.Add(captionButton1)
            Me.dockingManager.CaptionButtons.Add(captionButton2)
            Me.dockingManager.CaptionButtons.Add(captionButton3)
            Me.dockingManager.CaptionButtons.Add(captionButton4)
            Me.dockingManager.DockLayoutStream = (CType(resources.GetObject("dockingManager.DockLayoutStream"), System.IO.MemoryStream))
            Me.dockingManager.HostControl = Me
            Me.dockingManager.InActiveCaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.dockingManager.MaximizeButtonEnabled = True
            Me.dockingManager.MenuButtonEnabled = False
            Me.dockingManager.PersistState = True
            Me.dockingManager.ThemesEnabled = True
            Me.dockingManager.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            AddHandler Me.dockingManager.DockVisibilityChanged, AddressOf Me.dockingManager_DockVisibilityChanged
            Me.dockingManager.SetDockLabel(Me.propertyEditor_Renamed, "Properties")
            Me.dockingManager.SetDockLabel(Me.symbolPaletteGroupBar, "Symbol Palettes")
            Me.dockingManager.SetDockLabel(Me.overviewControl1, "Pan & Zoom")
            Me.dockingManager.SetDockLabel(Me.m_documentExplorer, "Document Explorer")
            Me.dockingManager.SetHiddenOnLoad(Me.m_documentExplorer, True)
            ' 
            ' propertyEditor
            ' 
            Me.propertyEditor_Renamed.Diagram = Nothing
            Me.dockingManager.SetEnableDocking(Me.propertyEditor_Renamed, True)
            Me.propertyEditor_Renamed.Location = New System.Drawing.Point(3, 22)
            Me.propertyEditor_Renamed.Name = "propertyEditor"
            Me.propertyEditor_Renamed.Size = New System.Drawing.Size(197, 320)
            Me.propertyEditor_Renamed.TabIndex = 11
            Me.propertyEditor_Renamed.ShowCombo = True
            ' 
            ' symbolPaletteGroupBar
            ' 
            Me.symbolPaletteGroupBar.AllowDrop = True
            Me.symbolPaletteGroupBar.EditMode = False
            Me.dockingManager.SetEnableDocking(Me.symbolPaletteGroupBar, True)
            Me.symbolPaletteGroupBar.Font = New System.Drawing.Font("Corbel", 9.0F, System.Drawing.FontStyle.Bold)
            Me.symbolPaletteGroupBar.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(33)))), (CInt((CByte(77)))), (CInt((CByte(140)))))
            Me.symbolPaletteGroupBar.Location = New System.Drawing.Point(3, 22)
            Me.symbolPaletteGroupBar.Name = "symbolPaletteGroupBar"
            Me.symbolPaletteGroupBar.Size = New System.Drawing.Size(250, 229)
            Me.symbolPaletteGroupBar.TabIndex = 9
            Me.symbolPaletteGroupBar.Text = "paletteGroupBar1"
            Me.symbolPaletteGroupBar.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
            Me.symbolPaletteGroupBar.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            ' 
            ' overviewControl1
            ' 
            Me.overviewControl1.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.overviewControl1.Diagram = Nothing
            Me.dockingManager.SetEnableDocking(Me.overviewControl1, True)
            Me.overviewControl1.ForeColor = System.Drawing.Color.Red
            Me.overviewControl1.Location = New System.Drawing.Point(3, 22)
            Me.overviewControl1.Name = "overviewControl1"
            Me.overviewControl1.Size = New System.Drawing.Size(197, 141)
            Me.overviewControl1.TabIndex = 11
            ' 
            ' m_documentExplorer
            ' 
            Me.dockingManager.SetEnableDocking(Me.m_documentExplorer, True)
            Me.m_documentExplorer.ImageIndex = 0
            Me.m_documentExplorer.Location = New System.Drawing.Point(3, 22)
            Me.m_documentExplorer.Name = "m_documentExplorer"
            Me.m_documentExplorer.SelectedImageIndex = 0
            Me.m_documentExplorer.Size = New System.Drawing.Size(250, 232)
            Me.m_documentExplorer.TabIndex = 0
            ' 
            ' openPaletteDialog
            ' 
            Me.openPaletteDialog.DefaultExt = "edp"
            Me.openPaletteDialog.Filter = "Essential Diagram Palettes|*.edp|Visio Stencils|*.vss; *.vsx|Visio Drawings(Shape" & "s only)|*.vsd; *.vdx|All files|*.*"
            Me.openPaletteDialog.Title = "Add SymbolPalette"
            ' 
            ' savePaletteDialog
            ' 
            Me.savePaletteDialog.DefaultExt = "edp"
            Me.savePaletteDialog.Filter = "Essential Diagram Palettes|*.edp|All files|*.*"
            Me.savePaletteDialog.Title = "Save SymbolPalette"
            ' 
            ' openDiagramDialog
            ' 
            Me.openDiagramDialog.Filter = "Diagram Files|*.edd|All files|*.*"
            Me.openDiagramDialog.Title = "Open Diagram"
            ' 
            ' saveDiagramDialog
            ' 
            Me.saveDiagramDialog.FileName = "doc1"
            Me.saveDiagramDialog.Filter = "Diagram files|*.edd|EMF file|*.emf|GIF file|*.gif|PNG file|*.png|BMP file|*.bmp|J" & "PEG file|*.jpeg,*.jpg|TIFF file|*.tiff|SVG file|*.svg|All files|*.*"
            ' 
            ' smallImageList
            ' 
            Me.smallImageList.ImageStream = (CType(resources.GetObject("smallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
            Me.smallImageList.TransparentColor = System.Drawing.Color.Fuchsia
            Me.smallImageList.Images.SetKeyName(0, "")
            Me.smallImageList.Images.SetKeyName(1, "")
            Me.smallImageList.Images.SetKeyName(2, "")
            Me.smallImageList.Images.SetKeyName(3, "")
            Me.smallImageList.Images.SetKeyName(4, "")
            Me.smallImageList.Images.SetKeyName(5, "")
            Me.smallImageList.Images.SetKeyName(6, "")
            Me.smallImageList.Images.SetKeyName(7, "")
            Me.smallImageList.Images.SetKeyName(8, "")
            Me.smallImageList.Images.SetKeyName(9, "")
            Me.smallImageList.Images.SetKeyName(10, "")
            Me.smallImageList.Images.SetKeyName(11, "")
            Me.smallImageList.Images.SetKeyName(12, "")
            Me.smallImageList.Images.SetKeyName(13, "")
            Me.smallImageList.Images.SetKeyName(14, "")
            Me.smallImageList.Images.SetKeyName(15, "")
            Me.smallImageList.Images.SetKeyName(16, "")
            Me.smallImageList.Images.SetKeyName(17, "")
            Me.smallImageList.Images.SetKeyName(18, "")
            Me.smallImageList.Images.SetKeyName(19, "")
            Me.smallImageList.Images.SetKeyName(20, "")
            Me.smallImageList.Images.SetKeyName(21, "")
            Me.smallImageList.Images.SetKeyName(22, "")
            Me.smallImageList.Images.SetKeyName(23, "")
            Me.smallImageList.Images.SetKeyName(24, "")
            Me.smallImageList.Images.SetKeyName(25, "")
            Me.smallImageList.Images.SetKeyName(26, "")
            Me.smallImageList.Images.SetKeyName(27, "")
            Me.smallImageList.Images.SetKeyName(28, "")
            Me.smallImageList.Images.SetKeyName(29, "")
            Me.smallImageList.Images.SetKeyName(30, "")
            Me.smallImageList.Images.SetKeyName(31, "")
            Me.smallImageList.Images.SetKeyName(32, "")
            Me.smallImageList.Images.SetKeyName(33, "")
            ' 
            ' openImageDialog
            ' 
            Me.openImageDialog.Filter = "Windows Bitmaps|*.bmp|Enhanced Metafiles|*.emf|All files|*.*"
            Me.openImageDialog.Title = "Insert Image"
            ' 
            ' mainFrameBarManager
            ' 
            Me.mainFrameBarManager.BarPositionInfo = (CType(resources.GetObject("mainFrameBarManager.BarPositionInfo"), System.IO.MemoryStream))
            Me.mainFrameBarManager.Bars.Add(Me.mainMenuBar)
            Me.mainFrameBarManager.Bars.Add(Me.standardToolbar)
            Me.mainFrameBarManager.Categories.Add("Popups")
            Me.mainFrameBarManager.Categories.Add("File")
            Me.mainFrameBarManager.Categories.Add("Window")
            Me.mainFrameBarManager.Categories.Add("Edit")
            Me.mainFrameBarManager.Categories.Add("Help")
            Me.mainFrameBarManager.Categories.Add("View")
            Me.mainFrameBarManager.Categories.Add("Dialogs")
            Me.mainFrameBarManager.Categories.Add("Actions")
            Me.mainFrameBarManager.Categories.Add("Align")
            Me.mainFrameBarManager.Categories.Add("Flip")
            Me.mainFrameBarManager.Categories.Add("Grouping")
            Me.mainFrameBarManager.Categories.Add("Order")
            Me.mainFrameBarManager.Categories.Add("Rotate")
            Me.mainFrameBarManager.Categories.Add("Resize")
            Me.mainFrameBarManager.Categories.Add("Format")
            Me.mainFrameBarManager.CurrentBaseFormType = "System.Windows.Forms.Form"
            Me.mainFrameBarManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.mainFrameBarManager.Form = Me
            Me.mainFrameBarManager.ImageList = Nothing
            Me.mainFrameBarManager.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItemFile, Me.parentBarItemAlign, Me.parentBarItemRotate, Me.parentBarItemFlip, Me.parentBarItemResize, Me.biFileNew, Me.parentBarItemEdit, Me.parentBarItemPopUp, Me.parentBarItemView, Me.parentBarItemWindow, Me.parentBarItemHelp, Me.parentBarItemActions, Me.biFileOpen, Me.parentBarItemToolsGrouping, Me.parentBarItemToolsOrder, Me.biFileSave, Me.biFileSaveAs, Me.biPageSetup, Me.biPrintPreview, Me.biFilePrint, Me.biAddPalette, Me.biSavePalette, Me.biFileExit, Me.biTabbedMDI, Me.barItemEditCut, Me.barItemEditCopy, Me.barItemEditPaste, Me.barItemEditUndo, Me.barItemEditRedo, Me.barItemAbout, Me.barItemViewSymbolPalette, Me.barItemViewProperties, Me.barItemEditSelectAll, Me.barItemPanZoom, Me.barItemDocumentExplorer, Me.barShowRulers, Me.barItemHeaderFooter, Me.barItemPageBorders, Me.barItemAlignBottom, Me.barItemAlignCenter, Me.barItemAlignLeft, Me.barItemAlignMiddle, Me.barItemAlignRight, Me.barItemAlignTop, Me.barItemEditDelete, Me.barItemFlipBoth, Me.barItemFlipHorizontally, Me.barItemFlipVertically, Me.barItemGroupingGroup, Me.barItemGroupingUnGroup, Me.barItemOrderBack, Me.barItemOrderBackward, Me.barItemOrderForward, Me.barItemOrderFront, Me.barItemResizeAcross, Me.barItemResizeDown, Me.barItemResizeHeight, Me.barItemResizeSize, Me.barItemResizeWidth, Me.barItemRotateClock, Me.barItemRotateConter, Me.barItemLayout, Me.parentBarItemFormat, Me.barItemFillStyle, Me.barItemShadowStyle})
            Me.mainFrameBarManager.LargeImageList = Nothing
            Me.mainFrameBarManager.ResetCustomization = False
            Me.mainFrameBarManager.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            ' 
            ' mainMenuBar
            ' 
            Me.mainMenuBar.BarName = "MainMenu"
            Me.mainMenuBar.BarStyle = (CType(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
            Me.mainMenuBar.Caption = "MainMenu"
            Me.mainMenuBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItemFile, Me.parentBarItemEdit, Me.parentBarItemView, Me.parentBarItemActions, Me.parentBarItemWindow, Me.parentBarItemHelp})
            Me.mainMenuBar.Manager = Me.mainFrameBarManager
            ' 
            ' parentBarItemFile
            ' 
            Me.parentBarItemFile.CategoryIndex = 0
            Me.parentBarItemFile.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemFile.ID = "File"
            Me.parentBarItemFile.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biFileNew, Me.biFileOpen, Me.biFileSave, Me.biFileSaveAs, Me.biAddPalette, Me.biSavePalette, Me.biPageSetup, Me.biPrintPreview, Me.biFilePrint, Me.biFileExit})
            Me.parentBarItemFile.SeparatorIndices.AddRange(New Integer() {4, 6, 9})
            Me.parentBarItemFile.Text = "&File"
            ' 
            ' biFileNew
            ' 
            Me.biFileNew.CategoryIndex = 1
            Me.biFileNew.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biFileNew.ID = "New"
            Me.biFileNew.ImageIndex = 0
            Me.biFileNew.ImageList = Me.smallImageList
            Me.biFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
            Me.biFileNew.Text = "&New"
            '			Me.biFileNew.Click += New System.EventHandler(Me.biFileNew_Click);
            ' 
            ' biFileOpen
            ' 
            Me.biFileOpen.CategoryIndex = 1
            Me.biFileOpen.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biFileOpen.ID = "Open"
            Me.biFileOpen.ImageIndex = 1
            Me.biFileOpen.ImageList = Me.smallImageList
            Me.biFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
            Me.biFileOpen.Text = "&Open"
            '			Me.biFileOpen.Click += New System.EventHandler(Me.biFileOpen_Click);
            ' 
            ' biFileSave
            ' 
            Me.biFileSave.CategoryIndex = 1
            Me.biFileSave.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biFileSave.ID = "Save"
            Me.biFileSave.ImageIndex = 2
            Me.biFileSave.ImageList = Me.smallImageList
            Me.biFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
            Me.biFileSave.Text = "&Save"
            '			Me.biFileSave.Click += New System.EventHandler(Me.biFileSave_Click);
            ' 
            ' biFileSaveAs
            ' 
            Me.biFileSaveAs.CategoryIndex = 1
            Me.biFileSaveAs.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biFileSaveAs.ID = "Save As..."
            Me.biFileSaveAs.Text = "Save As..."
            '			Me.biFileSaveAs.Click += New System.EventHandler(Me.biFileSaveAs_Click);
            ' 
            ' biAddPalette
            ' 
            Me.biAddPalette.CategoryIndex = 1
            Me.biAddPalette.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biAddPalette.ID = "Add SymbolPalette"
            Me.biAddPalette.Text = "Add SymbolPalette..."
            '			Me.biAddPalette.Click += New System.EventHandler(Me.biFileAddPalette_Click);
            ' 
            ' biSavePalette
            ' 
            Me.biSavePalette.CategoryIndex = 1
            Me.biSavePalette.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biSavePalette.ID = "Save SymbolPalette"
            Me.biSavePalette.Text = "Save Active SymbolPalette"
            '			Me.biSavePalette.Click += New System.EventHandler(Me.biSavePalette_Click);
            ' 
            ' biPageSetup
            ' 
            Me.biPageSetup.CategoryIndex = 1
            Me.biPageSetup.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biPageSetup.ID = "Page Setup"
            Me.biPageSetup.ImageIndex = 5
            Me.biPageSetup.ImageList = Me.smallImageList
            Me.biPageSetup.Text = "Page Setup"
            '			Me.biPageSetup.Click += New System.EventHandler(Me.biPageSetup_Click);
            ' 
            ' biPrintPreview
            ' 
            Me.biPrintPreview.CategoryIndex = 1
            Me.biPrintPreview.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biPrintPreview.ID = "Print Preview"
            Me.biPrintPreview.ImageIndex = 3
            Me.biPrintPreview.ImageList = Me.smallImageList
            Me.biPrintPreview.Text = "Print Preview"
            Me.biPrintPreview.Tooltip = "Print Preview"
            '			Me.biPrintPreview.Click += New System.EventHandler(Me.biPrintPreview_Click);
            ' 
            ' biFilePrint
            ' 
            Me.biFilePrint.CategoryIndex = 1
            Me.biFilePrint.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biFilePrint.ID = "Print"
            Me.biFilePrint.ImageIndex = 6
            Me.biFilePrint.ImageList = Me.smallImageList
            Me.biFilePrint.Text = "Print"
            '			Me.biFilePrint.Click += New System.EventHandler(Me.biFilePrint_Click);
            ' 
            ' biFileExit
            ' 
            Me.biFileExit.CategoryIndex = 1
            Me.biFileExit.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biFileExit.ID = "Exit"
            Me.biFileExit.Text = "Exit"
            '			Me.biFileExit.Click += New System.EventHandler(Me.biFileExit_Click);
            ' 
            ' parentBarItemEdit
            ' 
            Me.parentBarItemEdit.CategoryIndex = 0
            Me.parentBarItemEdit.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemEdit.ID = "Edit"
            Me.parentBarItemEdit.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemEditUndo, Me.barItemEditRedo, Me.barItemEditSelectAll, Me.barItemEditDelete, Me.barItemEditCut, Me.barItemEditCopy, Me.barItemEditPaste, Me.parentBarItemFormat})
            Me.parentBarItemEdit.SeparatorIndices.AddRange(New Integer() {2, 4})
            Me.parentBarItemEdit.Text = "&Edit"
            ' 
            ' barItemEditUndo
            ' 
            Me.barItemEditUndo.CategoryIndex = 3
            Me.barItemEditUndo.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemEditUndo.ID = "Undo"
            Me.barItemEditUndo.ImageIndex = 10
            Me.barItemEditUndo.ImageList = Me.smallImageList
            Me.barItemEditUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
            Me.barItemEditUndo.Text = "&Undo"
            '			Me.barItemEditUndo.Click += New System.EventHandler(Me.barItemEditUndo_Click);
            ' 
            ' barItemEditRedo
            ' 
            Me.barItemEditRedo.CategoryIndex = 3
            Me.barItemEditRedo.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemEditRedo.ID = "EditRedo"
            Me.barItemEditRedo.ImageIndex = 11
            Me.barItemEditRedo.ImageList = Me.smallImageList
            Me.barItemEditRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY
            Me.barItemEditRedo.Text = "&Redo"
            '			Me.barItemEditRedo.Click += New System.EventHandler(Me.barItemEditRedo_Click);
            ' 
            ' barItemEditSelectAll
            ' 
            Me.barItemEditSelectAll.CategoryIndex = 3
            Me.barItemEditSelectAll.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemEditSelectAll.ID = "&Select All"
            Me.barItemEditSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA
            Me.barItemEditSelectAll.Text = "Select &All"
            '			Me.barItemEditSelectAll.Click += New System.EventHandler(Me.barItemEditSelectAll_Click);
            ' 
            ' barItemEditDelete
            ' 
            Me.barItemEditDelete.CategoryIndex = 3
            Me.barItemEditDelete.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemEditDelete.ID = "Delete"
            Me.barItemEditDelete.ImageIndex = 12
            Me.barItemEditDelete.ImageList = Me.smallImageList
            Me.barItemEditDelete.Text = "&Delete"
            '			Me.barItemEditDelete.Click += New System.EventHandler(Me.barItemEditDelete_Click);
            ' 
            ' barItemEditCut
            ' 
            Me.barItemEditCut.CategoryIndex = 3
            Me.barItemEditCut.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemEditCut.ID = "Cut"
            Me.barItemEditCut.ImageIndex = 8
            Me.barItemEditCut.ImageList = Me.smallImageList
            Me.barItemEditCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX
            Me.barItemEditCut.Text = "C&ut"
            '			Me.barItemEditCut.Click += New System.EventHandler(Me.barItemEditCut_Click);
            ' 
            ' barItemEditCopy
            ' 
            Me.barItemEditCopy.CategoryIndex = 3
            Me.barItemEditCopy.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemEditCopy.ID = "Copy"
            Me.barItemEditCopy.ImageIndex = 7
            Me.barItemEditCopy.ImageList = Me.smallImageList
            Me.barItemEditCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC
            Me.barItemEditCopy.Text = "&Copy"
            '			Me.barItemEditCopy.Click += New System.EventHandler(Me.barItemEditCopy_Click);
            ' 
            ' barItemEditPaste
            ' 
            Me.barItemEditPaste.CategoryIndex = 3
            Me.barItemEditPaste.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemEditPaste.ID = "Paste"
            Me.barItemEditPaste.ImageIndex = 9
            Me.barItemEditPaste.ImageList = Me.smallImageList
            Me.barItemEditPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV
            Me.barItemEditPaste.Text = "&Paste"
            '			Me.barItemEditPaste.Click += New System.EventHandler(Me.barItemEditPaste_Click);
            ' 
            ' parentBarItemFormat
            ' 
            Me.parentBarItemFormat.CategoryIndex = 0
            Me.parentBarItemFormat.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemFormat.ID = "Format"
            Me.parentBarItemFormat.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemFillStyle, Me.barItemShadowStyle})
            Me.parentBarItemFormat.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItemFormat.Text = "&Format"
            ' 
            ' barItemFillStyle
            ' 
            Me.barItemFillStyle.CategoryIndex = 14
            Me.barItemFillStyle.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemFillStyle.ID = "Fill"
            Me.barItemFillStyle.Text = "&Fill..."
            '			Me.barItemFillStyle.Click += New System.EventHandler(Me.fillBarItem_Click);
            ' 
            ' barItemShadowStyle
            ' 
            Me.barItemShadowStyle.CategoryIndex = 14
            Me.barItemShadowStyle.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemShadowStyle.ID = "Shadow"
            Me.barItemShadowStyle.Text = "&Shadow..."
            '			Me.barItemShadowStyle.Click += New System.EventHandler(Me.shadowBarItem_Click);
            ' 
            ' parentBarItemView
            ' 
            Me.parentBarItemView.CategoryIndex = 0
            Me.parentBarItemView.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemView.ID = "View"
            Me.parentBarItemView.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barShowRulers, Me.barItemViewSymbolPalette, Me.barItemViewProperties, Me.barItemPanZoom, Me.barItemDocumentExplorer, Me.barItemHeaderFooter, Me.barItemPageBorders})
            Me.parentBarItemView.SeparatorIndices.AddRange(New Integer() {3})
            Me.parentBarItemView.Text = "&View"
            ' 
            ' barShowRulers
            ' 
            Me.barShowRulers.CategoryIndex = 5
            Me.barShowRulers.Checked = False
            Me.barShowRulers.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barShowRulers.ID = "Rulers"
            Me.barShowRulers.Text = "Rulers"
            '			Me.barShowRulers.Click += New System.EventHandler(Me.barShowRulers_Click);
            ' 
            ' barItemViewSymbolPalette
            ' 
            Me.barItemViewSymbolPalette.CategoryIndex = 5
            Me.barItemViewSymbolPalette.Checked = True
            Me.barItemViewSymbolPalette.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemViewSymbolPalette.ID = "Symbol SymbolPalette"
            Me.barItemViewSymbolPalette.Text = "Symbol Palette..."
            '			Me.barItemViewSymbolPalette.Click += New System.EventHandler(Me.barItemViewSymbolPalette_Click);
            ' 
            ' barItemViewProperties
            ' 
            Me.barItemViewProperties.CategoryIndex = 5
            Me.barItemViewProperties.Checked = True
            Me.barItemViewProperties.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemViewProperties.ID = "Properties"
            Me.barItemViewProperties.Text = "Properties"
            '			Me.barItemViewProperties.Click += New System.EventHandler(Me.barItemViewProperties_Click);
            ' 
            ' barItemPanZoom
            ' 
            Me.barItemPanZoom.CategoryIndex = 5
            Me.barItemPanZoom.Checked = True
            Me.barItemPanZoom.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemPanZoom.ID = "panZoomWindow"
            Me.barItemPanZoom.Text = "Pan & Zoom Window"
            Me.barItemPanZoom.Tooltip = "Pan & Zoom Window"
            '			Me.barItemPanZoom.Click += New System.EventHandler(Me.barItemPanZoom_Click);
            ' 
            ' barItemDocumentExplorer
            ' 
            Me.barItemDocumentExplorer.CategoryIndex = 5
            Me.barItemDocumentExplorer.Checked = True
            Me.barItemDocumentExplorer.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemDocumentExplorer.ID = "DocumentExplorer"
            Me.barItemDocumentExplorer.Text = "Document Explorer"
            Me.barItemDocumentExplorer.Tooltip = "Document Explorer"
            '			Me.barItemDocumentExplorer.Click += New System.EventHandler(Me.barItemDocumentExplorer_Click);
            ' 
            ' barItemHeaderFooter
            ' 
            Me.barItemHeaderFooter.CategoryIndex = 5
            Me.barItemHeaderFooter.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemHeaderFooter.ID = "Header Footer"
            Me.barItemHeaderFooter.Text = "Header Footer..."
            '			Me.barItemHeaderFooter.Click += New System.EventHandler(Me.barItemHeaderFooter_Click);
            ' 
            ' barItemPageBorders
            ' 
            Me.barItemPageBorders.CategoryIndex = 5
            Me.barItemPageBorders.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemPageBorders.ID = "Page Borders"
            Me.barItemPageBorders.Text = "Page Borders..."
            '			Me.barItemPageBorders.Click += New System.EventHandler(Me.barItemPageBorders_Click);
            ' 
            ' parentBarItemActions
            ' 
            Me.parentBarItemActions.CategoryIndex = 0
            Me.parentBarItemActions.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemActions.ID = "Actions"
            Me.parentBarItemActions.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItemAlign, Me.parentBarItemFlip, Me.parentBarItemToolsGrouping, Me.parentBarItemToolsOrder, Me.parentBarItemRotate, Me.parentBarItemResize, Me.barItemLayout})
            Me.parentBarItemActions.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItemActions.Text = "&Actions"
            ' 
            ' parentBarItemAlign
            ' 
            Me.parentBarItemAlign.CategoryIndex = 0
            Me.parentBarItemAlign.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemAlign.ID = "Align"
            Me.parentBarItemAlign.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemAlignLeft, Me.barItemAlignCenter, Me.barItemAlignRight, Me.barItemAlignTop, Me.barItemAlignMiddle, Me.barItemAlignBottom})
            Me.parentBarItemAlign.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItemAlign.Text = "&Align"
            ' 
            ' barItemAlignLeft
            ' 
            Me.barItemAlignLeft.CategoryIndex = 8
            Me.barItemAlignLeft.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemAlignLeft.ID = "AlignLeft"
            Me.barItemAlignLeft.ImageIndex = 15
            Me.barItemAlignLeft.ImageList = Me.smallImageList
            Me.barItemAlignLeft.Text = "Align Left"
            '			Me.barItemAlignLeft.Click += New System.EventHandler(Me.barItemAlign_Click);
            ' 
            ' barItemAlignCenter
            ' 
            Me.barItemAlignCenter.CategoryIndex = 8
            Me.barItemAlignCenter.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemAlignCenter.ID = "AlignCenter"
            Me.barItemAlignCenter.ImageIndex = 14
            Me.barItemAlignCenter.ImageList = Me.smallImageList
            Me.barItemAlignCenter.Text = "Align Center"
            '			Me.barItemAlignCenter.Click += New System.EventHandler(Me.barItemAlign_Click);
            ' 
            ' barItemAlignRight
            ' 
            Me.barItemAlignRight.CategoryIndex = 8
            Me.barItemAlignRight.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemAlignRight.ID = "AlignRight"
            Me.barItemAlignRight.ImageIndex = 17
            Me.barItemAlignRight.ImageList = Me.smallImageList
            Me.barItemAlignRight.Text = "Align Right"
            '			Me.barItemAlignRight.Click += New System.EventHandler(Me.barItemAlign_Click);
            ' 
            ' barItemAlignTop
            ' 
            Me.barItemAlignTop.CategoryIndex = 8
            Me.barItemAlignTop.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemAlignTop.ID = "AlignTop"
            Me.barItemAlignTop.ImageIndex = 18
            Me.barItemAlignTop.ImageList = Me.smallImageList
            Me.barItemAlignTop.Text = "Align Top"
            '			Me.barItemAlignTop.Click += New System.EventHandler(Me.barItemAlign_Click);
            ' 
            ' barItemAlignMiddle
            ' 
            Me.barItemAlignMiddle.CategoryIndex = 8
            Me.barItemAlignMiddle.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemAlignMiddle.ID = "AlignMiddle"
            Me.barItemAlignMiddle.ImageIndex = 16
            Me.barItemAlignMiddle.ImageList = Me.smallImageList
            Me.barItemAlignMiddle.Text = "Align Middle"
            '			Me.barItemAlignMiddle.Click += New System.EventHandler(Me.barItemAlign_Click);
            ' 
            ' barItemAlignBottom
            ' 
            Me.barItemAlignBottom.CategoryIndex = 8
            Me.barItemAlignBottom.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemAlignBottom.ID = "AlignBottom"
            Me.barItemAlignBottom.ImageIndex = 13
            Me.barItemAlignBottom.ImageList = Me.smallImageList
            Me.barItemAlignBottom.Text = "Align Bottom"
            '			Me.barItemAlignBottom.Click += New System.EventHandler(Me.barItemAlign_Click);
            ' 
            ' parentBarItemFlip
            ' 
            Me.parentBarItemFlip.CategoryIndex = 0
            Me.parentBarItemFlip.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemFlip.ID = "Flip"
            Me.parentBarItemFlip.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemFlipHorizontally, Me.barItemFlipVertically, Me.barItemFlipBoth})
            Me.parentBarItemFlip.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItemFlip.Text = "&Flip"
            ' 
            ' barItemFlipHorizontally
            ' 
            Me.barItemFlipHorizontally.CategoryIndex = 9
            Me.barItemFlipHorizontally.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemFlipHorizontally.ID = "FlipHorizontally"
            Me.barItemFlipHorizontally.ImageIndex = 20
            Me.barItemFlipHorizontally.ImageList = Me.smallImageList
            Me.barItemFlipHorizontally.Text = "Flip Horizontally"
            '			Me.barItemFlipHorizontally.Click += New System.EventHandler(Me.barItemFlip_Click);
            ' 
            ' barItemFlipVertically
            ' 
            Me.barItemFlipVertically.CategoryIndex = 9
            Me.barItemFlipVertically.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemFlipVertically.ID = "FlipVertically"
            Me.barItemFlipVertically.ImageIndex = 19
            Me.barItemFlipVertically.ImageList = Me.smallImageList
            Me.barItemFlipVertically.Text = "Flip Vertically"
            '			Me.barItemFlipVertically.Click += New System.EventHandler(Me.barItemFlip_Click);
            ' 
            ' barItemFlipBoth
            ' 
            Me.barItemFlipBoth.CategoryIndex = 9
            Me.barItemFlipBoth.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemFlipBoth.ID = "FlipBoth"
            Me.barItemFlipBoth.Text = "Flip Both"
            '			Me.barItemFlipBoth.Click += New System.EventHandler(Me.barItemFlip_Click);
            ' 
            ' parentBarItemToolsGrouping
            ' 
            Me.parentBarItemToolsGrouping.CategoryIndex = 0
            Me.parentBarItemToolsGrouping.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemToolsGrouping.ID = "Grouping"
            Me.parentBarItemToolsGrouping.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemGroupingGroup, Me.barItemGroupingUnGroup})
            Me.parentBarItemToolsGrouping.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItemToolsGrouping.Text = "&Grouping"
            ' 
            ' barItemGroupingGroup
            ' 
            Me.barItemGroupingGroup.CategoryIndex = 10
            Me.barItemGroupingGroup.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemGroupingGroup.ID = "Group"
            Me.barItemGroupingGroup.ImageIndex = 21
            Me.barItemGroupingGroup.ImageList = Me.smallImageList
            Me.barItemGroupingGroup.Text = "Group"
            '			Me.barItemGroupingGroup.Click += New System.EventHandler(Me.barItemGroupingGroup_Click);
            ' 
            ' barItemGroupingUnGroup
            ' 
            Me.barItemGroupingUnGroup.CategoryIndex = 10
            Me.barItemGroupingUnGroup.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemGroupingUnGroup.ID = "UnGroup"
            Me.barItemGroupingUnGroup.ImageIndex = 22
            Me.barItemGroupingUnGroup.ImageList = Me.smallImageList
            Me.barItemGroupingUnGroup.Text = "UnGroup"
            '			Me.barItemGroupingUnGroup.Click += New System.EventHandler(Me.barItemGroupingGroup_Click);
            ' 
            ' parentBarItemToolsOrder
            ' 
            Me.parentBarItemToolsOrder.CategoryIndex = 0
            Me.parentBarItemToolsOrder.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemToolsOrder.ID = "Order"
            Me.parentBarItemToolsOrder.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemOrderFront, Me.barItemOrderForward, Me.barItemOrderBackward, Me.barItemOrderBack})
            Me.parentBarItemToolsOrder.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItemToolsOrder.Text = "&Order"
            ' 
            ' barItemOrderFront
            ' 
            Me.barItemOrderFront.CategoryIndex = 11
            Me.barItemOrderFront.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemOrderFront.ID = "Bring to Front"
            Me.barItemOrderFront.ImageIndex = 26
            Me.barItemOrderFront.ImageList = Me.smallImageList
            Me.barItemOrderFront.Text = "Bring to Front"
            '			Me.barItemOrderFront.Click += New System.EventHandler(Me.barItemOrder_Click);
            ' 
            ' barItemOrderForward
            ' 
            Me.barItemOrderForward.CategoryIndex = 11
            Me.barItemOrderForward.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemOrderForward.ID = "Bring Forward"
            Me.barItemOrderForward.ImageIndex = 25
            Me.barItemOrderForward.ImageList = Me.smallImageList
            Me.barItemOrderForward.Text = "Bring Forward"
            '			Me.barItemOrderForward.Click += New System.EventHandler(Me.barItemOrder_Click);
            ' 
            ' barItemOrderBackward
            ' 
            Me.barItemOrderBackward.CategoryIndex = 11
            Me.barItemOrderBackward.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemOrderBackward.ID = "Send Backward"
            Me.barItemOrderBackward.ImageIndex = 27
            Me.barItemOrderBackward.ImageList = Me.smallImageList
            Me.barItemOrderBackward.Text = "Send Backward"
            '			Me.barItemOrderBackward.Click += New System.EventHandler(Me.barItemOrder_Click);
            ' 
            ' barItemOrderBack
            ' 
            Me.barItemOrderBack.CategoryIndex = 11
            Me.barItemOrderBack.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemOrderBack.ID = "Send to Back"
            Me.barItemOrderBack.ImageIndex = 28
            Me.barItemOrderBack.ImageList = Me.smallImageList
            Me.barItemOrderBack.Text = "Send to Back"
            '			Me.barItemOrderBack.Click += New System.EventHandler(Me.barItemOrder_Click);
            ' 
            ' parentBarItemRotate
            ' 
            Me.parentBarItemRotate.CategoryIndex = 0
            Me.parentBarItemRotate.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemRotate.ID = "Rotate"
            Me.parentBarItemRotate.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemRotateClock, Me.barItemRotateConter})
            Me.parentBarItemRotate.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItemRotate.Text = "&Rotate"
            ' 
            ' barItemRotateClock
            ' 
            Me.barItemRotateClock.CategoryIndex = 12
            Me.barItemRotateClock.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemRotateClock.ID = "RotateClock"
            Me.barItemRotateClock.ImageIndex = 24
            Me.barItemRotateClock.ImageList = Me.smallImageList
            Me.barItemRotateClock.Text = "Rotate 90 clockwise"
            '			Me.barItemRotateClock.Click += New System.EventHandler(Me.barItemRotate_Click);
            ' 
            ' barItemRotateConter
            ' 
            Me.barItemRotateConter.CategoryIndex = 12
            Me.barItemRotateConter.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemRotateConter.ID = "RotateConter"
            Me.barItemRotateConter.ImageIndex = 23
            Me.barItemRotateConter.ImageList = Me.smallImageList
            Me.barItemRotateConter.Text = "Rotate 90 conter-clockwise"
            '			Me.barItemRotateConter.Click += New System.EventHandler(Me.barItemRotate_Click);
            ' 
            ' parentBarItemResize
            ' 
            Me.parentBarItemResize.CategoryIndex = 0
            Me.parentBarItemResize.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemResize.ID = "Resize"
            Me.parentBarItemResize.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemResizeWidth, Me.barItemResizeHeight, Me.barItemResizeSize, Me.barItemResizeAcross, Me.barItemResizeDown})
            Me.parentBarItemResize.SeparatorIndices.AddRange(New Integer() {3})
            Me.parentBarItemResize.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.parentBarItemResize.Text = "R&esize"
            ' 
            ' barItemResizeWidth
            ' 
            Me.barItemResizeWidth.CategoryIndex = 13
            Me.barItemResizeWidth.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemResizeWidth.ID = "SameWidth"
            Me.barItemResizeWidth.ImageIndex = 31
            Me.barItemResizeWidth.ImageList = Me.smallImageList
            Me.barItemResizeWidth.Text = "Same Width"
            '			Me.barItemResizeWidth.Click += New System.EventHandler(Me.barItemResize_Click);
            ' 
            ' barItemResizeHeight
            ' 
            Me.barItemResizeHeight.CategoryIndex = 13
            Me.barItemResizeHeight.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemResizeHeight.ID = "SameHeight"
            Me.barItemResizeHeight.ImageIndex = 29
            Me.barItemResizeHeight.ImageList = Me.smallImageList
            Me.barItemResizeHeight.Text = "Same Height"
            '			Me.barItemResizeHeight.Click += New System.EventHandler(Me.barItemResize_Click);
            ' 
            ' barItemResizeSize
            ' 
            Me.barItemResizeSize.CategoryIndex = 13
            Me.barItemResizeSize.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemResizeSize.ID = "SameSize"
            Me.barItemResizeSize.ImageIndex = 30
            Me.barItemResizeSize.ImageList = Me.smallImageList
            Me.barItemResizeSize.Text = "Same Size"
            '			Me.barItemResizeSize.Click += New System.EventHandler(Me.barItemResize_Click);
            ' 
            ' barItemResizeAcross
            ' 
            Me.barItemResizeAcross.CategoryIndex = 13
            Me.barItemResizeAcross.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemResizeAcross.ID = "SpaceAcross"
            Me.barItemResizeAcross.ImageIndex = 32
            Me.barItemResizeAcross.ImageList = Me.smallImageList
            Me.barItemResizeAcross.Text = "Space Across"
            '			Me.barItemResizeAcross.Click += New System.EventHandler(Me.barItemResize_Click);
            ' 
            ' barItemResizeDown
            ' 
            Me.barItemResizeDown.CategoryIndex = 13
            Me.barItemResizeDown.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemResizeDown.ID = "SpaceDown"
            Me.barItemResizeDown.ImageIndex = 33
            Me.barItemResizeDown.ImageList = Me.smallImageList
            Me.barItemResizeDown.Text = "Space Down"
            '			Me.barItemResizeDown.Click += New System.EventHandler(Me.barItemResize_Click);
            ' 
            ' barItemLayout
            ' 
            Me.barItemLayout.CategoryIndex = 0
            Me.barItemLayout.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemLayout.ID = "Layout nodes"
            Me.barItemLayout.Text = "Layout nodes..."
            '			Me.barItemLayout.Click += New System.EventHandler(Me.barItemLayout_Click);
            ' 
            ' parentBarItemWindow
            ' 
            Me.parentBarItemWindow.CategoryIndex = 0
            Me.parentBarItemWindow.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemWindow.ID = "Window"
            Me.parentBarItemWindow.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biTabbedMDI})
            Me.parentBarItemWindow.Text = "&Window"
            ' 
            ' biTabbedMDI
            ' 
            Me.biTabbedMDI.CategoryIndex = 2
            Me.biTabbedMDI.Checked = True
            Me.biTabbedMDI.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.biTabbedMDI.ID = "Tabbed MDI"
            Me.biTabbedMDI.Text = "Tabbed MDI"
            '			Me.biTabbedMDI.Click += New System.EventHandler(Me.biTabbedMDI_Click);
            ' 
            ' parentBarItemHelp
            ' 
            Me.parentBarItemHelp.CategoryIndex = 0
            Me.parentBarItemHelp.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemHelp.ID = "Help"
            Me.parentBarItemHelp.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemAbout})
            Me.parentBarItemHelp.Text = "&Help"
            ' 
            ' barItemAbout
            ' 
            Me.barItemAbout.CategoryIndex = 4
            Me.barItemAbout.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.barItemAbout.ID = "About"
            Me.barItemAbout.Text = "About..."
            '			Me.barItemAbout.Click += New System.EventHandler(Me.barItemAbout_Click);
            ' 
            ' standardToolbar
            ' 
            Me.standardToolbar.BarName = "Standard"
            Me.standardToolbar.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.RotateWhenVertical) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
            Me.standardToolbar.Caption = "Standard"
            Me.standardToolbar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biFileNew, Me.biFileOpen, Me.biFileSave, Me.biPrintPreview, Me.biFilePrint})
            Me.standardToolbar.Manager = Me.mainFrameBarManager
            ' 
            ' parentBarItemPopUp
            ' 
            Me.parentBarItemPopUp.CategoryIndex = 0
            Me.parentBarItemPopUp.Customizable = False
            Me.parentBarItemPopUp.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemPopUp.ID = "PopUpMenu"
            Me.parentBarItemPopUp.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemEditCut, Me.barItemEditCopy, Me.barItemEditPaste, Me.barItemEditDelete, Me.parentBarItemActions, Me.parentBarItemFormat})
            Me.parentBarItemPopUp.SeparatorIndices.AddRange(New Integer() {3, 4})
            Me.parentBarItemPopUp.ShowTooltip = False
            Me.parentBarItemPopUp.Text = "PopUpMenu"
            Me.parentBarItemPopUp.UsePartialMenus = False
            Me.parentBarItemPopUp.Visible = False
            ' 
            ' parentBarItemNode
            ' 
            Me.parentBarItemNode.CategoryIndex = 0
            Me.parentBarItemNode.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
            Me.parentBarItemNode.ID = "NodeMenu"
            Me.parentBarItemNode.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItemEditCut, Me.barItemEditCopy, Me.barItemEditPaste, Me.parentBarItemActions})
            Me.parentBarItemNode.SeparatorIndices.AddRange(New Integer() {3})
            Me.parentBarItemNode.Text = "NodeMenu"
            Me.parentBarItemNode.Visible = False
            ' 
            ' MainForm
            ' 
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(792, 566)
            Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
            Me.IsMdiContainer = True
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Diagram Builder"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            '			Me.MdiChildActivate += New System.EventHandler(Me.MainForm_MdiChildActivate);
            '			Me.Load += New System.EventHandler(Me.MainForm_Load);
            CType(Me.dockingManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.symbolPaletteGroupBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mainFrameBarManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "MainForm Event Handlers"

        Friend Function FindFile(ByVal fileName As String) As String
            ' Check both in parent folder and Parent\Data folders.
            Dim dataFileName As String = "Data\" & fileName
            For n As Integer = 0 To 11
                If System.IO.File.Exists(fileName) Then
                    Return fileName
                End If
                If System.IO.File.Exists(dataFileName) Then
                    Return dataFileName
                End If
                fileName = "..\" & fileName
                dataFileName = "..\" & dataFileName
            Next n

            Return fileName
        End Function

        Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.barItemViewProperties.Checked = True
            Me.barItemViewSymbolPalette.Checked = True


            'Load Palettes
            Dim symbolPalettes As String() = New String() {"..\..\..\..\..\..\..\..\..\Common\Data\Diagram\FloorPlan Shapes.edp", "..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Basic Shapes.edp", "..\..\..\..\..\..\..\..\..\Common\Data\Diagram\ElectricalSymbols.edp", "..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp", "..\..\..\..\..\..\..\..\..\Common\Data\Diagram\NetworkSymbols.edp"}
            For Each symbolpalette As String In symbolPalettes
                Dim filepath As String = FindFile(symbolpalette)
                If File.Exists(filepath) Then
                    Me.symbolPaletteGroupBar.LoadPalette(filepath)
                End If
            Next symbolpalette

            ' New diagram
            docForm = New DiagramForm(Me)
            AddHandler docForm.Closing, AddressOf DiagramForm_Closing

            ' Subscribe for DocumentExplorer selection change
            AddHandler m_documentExplorer.AfterSelect, AddressOf m_documentExplorer_AfterSelect

            ' Load Diagram file.
            If _initialFileLoc = "" Then
                docForm.Diagram.LoadBinary(FindFile("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\FloorPlan.edd"))
                docForm.FileName = " Floor Plan "
            Else
                docForm.Diagram.LoadBinary(_initialFileLoc)
                docForm.FileName = _initialFileLoc.Substring(0, _initialFileLoc.IndexOf("."))
            End If

            ' Attach created diagram to DocumentExplorer
            If Not docForm.Diagram.Model Is Nothing Then
                m_documentExplorer.AttachModel(docForm.Diagram.Model)
            End If

            docForm.Show()

            'Me.ActiveDiagram.ShowRulers = True
            For Each item As GroupBarItem In symbolPaletteGroupBar.GroupBarItems
                If TypeOf item.Client Is PaletteGroupView Then
                    Dim view As PaletteGroupView = CType(IIf(TypeOf item.Client Is PaletteGroupView, item.Client, Nothing), PaletteGroupView)
                    view.FlowView = True
                    view.ShowFlowViewItemText = True
                    view.ShowToolTips = True
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118)
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149)
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184)
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115)
                    view.FlowViewItemTextLength = 60
                    view.BackgroundImage = Image.FromFile("..\..\..\..\..\..\..\..\..\Common\images\Diagram\background_2.jpg")
                    view.FlatLook = True
                End If
            Next item

            ' Load the save bar state
            If File.Exists("..\..\persist.xml") Then
                Dim serializer As AppStateSerializer = New AppStateSerializer(SerializeMode.XMLFile, "..\..\persist")
                Me.mainFrameBarManager.LoadBarState(serializer)
            End If
        End Sub
        Private Sub MainForm_MdiChildActivate(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MdiChildActivate
            Dim diagramForm As DiagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
            If Not diagramForm Is Nothing Then
                If Me.dockingManager.GetDockVisibility(propertyEditor_Renamed) Then
                    Me.propertyEditor_Renamed.Diagram = diagramForm.Diagram
                End If

                ' Subscribe for DocumentSink events
                If Not diagramForm.Diagram.Model Is Nothing Then
                    Dim document As Model = diagramForm.Diagram.Model
                End If

                ' If the OverviewControl is visible then change the OverviewControl.Model and OverviewControl.View 
                ' properties to reference the new diagram's Model and View
                If Me.dockingManager.GetDockVisibility(overviewControl1) Then
                    Me.overviewControl1.Diagram = diagramForm.Diagram
                End If
                'attach active diagram to palette groupbar
                Me.symbolPaletteGroupBar.Diagram = diagramForm.Diagram
            End If
        End Sub
#End Region

#Region "Properties"

        Private ReadOnly Property ActiveDiagram() As Controls.Diagram
            Get
                Dim diagram As Controls.Diagram = Nothing

                If Not Me.ActiveMdiChild Is Nothing Then
                    Dim diagramForm As DiagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
                    If Not diagramForm Is Nothing Then
                        diagram = diagramForm.Diagram
                    End If
                End If

                Return diagram
            End Get
        End Property

        Private ReadOnly Property ActiveDiagramForm() As DiagramForm
            Get
                Dim diagramForm As DiagramForm = Nothing

                If Not Me.ActiveMdiChild Is Nothing Then
                    diagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
                End If

                Return diagramForm
            End Get
        End Property

        Public ReadOnly Property PropertyEditor() As PropertyEditor
            Get
                Return Me.propertyEditor_Renamed
            End Get
        End Property

#End Region

#Region "File Menu Event Handlers"
        Private Sub biSavePalette_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biSavePalette.Click
            ' Open symbol palette and add it to the symbol palette group bar
            If savePaletteDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim symbolPalette As SymbolPalette = symbolPaletteGroupBar.CurrentSymbolPalette
                Dim strSavePath As String = savePaletteDialog.FileName

                If Not symbolPalette Is Nothing Then
                    Dim fStream As FileStream = New FileStream(strSavePath, FileMode.OpenOrCreate, FileAccess.Write)
                    Dim formatter As BinaryFormatter = New BinaryFormatter()

                    formatter.Serialize(fStream, symbolPalette)
                    fStream.Close()
                End If
            End If
        End Sub
        Private Sub biFileAddPalette_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biAddPalette.Click
            ' Open symbol palette and add it to the symbol palette group bar
            If openPaletteDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim curSymbolPalette As SymbolPalette = New SymbolPalette()

                Dim strFileName As String = openPaletteDialog.FileName

                Dim options As RegexOptions = RegexOptions.IgnoreCase Or RegexOptions.RightToLeft
                Dim match As Match = Regex.Match(strFileName, ".vss|.vsx|.vsd|.vdx", options)

                If match.Success Then
                    Dim converter As VisioStencilConverter = New VisioStencilConverter(strFileName, Me)
                    converter.ShowProgressDialog = True
                    curSymbolPalette = converter.Convert()
                    If Not curSymbolPalette Is Nothing Then
                        symbolPaletteGroupBar.AddPalette(curSymbolPalette)
                    End If
                Else                   
                    Try
                        curSymbolPalette = curSymbolPalette.FromFile(strFileName)
                        symbolPaletteGroupBar.AddPalette(curSymbolPalette)
                    Catch se As Exception
                        MessageBox.Show(Me, se.Message)
                    End Try
                End If
            End If
        End Sub

        Private Sub biFileNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biFileNew.Click
            ' New diagram
            docForm = New DiagramForm(Me)
            docForm.Diagram.View.Grid.GridStyle = GridStyle.Line
            docForm.Diagram.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            docForm.Diagram.View.Grid.Color = Color.LightGray
            docForm.Diagram.View.Grid.VerticalSpacing = 15
            docForm.Diagram.View.Grid.HorizontalSpacing = 15
            docForm.Diagram.Model.BackgroundStyle.GradientCenter = 0.5F
            docForm.Diagram.View.HandleColor = Color.AliceBlue
            docForm.Diagram.View.HandleOutlineColor = Color.SkyBlue
            docForm.Diagram.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
            docForm.Diagram.View.SelectionList.Clear()
            AddHandler docForm.Closing, AddressOf DiagramForm_Closing
            ' Attach just created diagram
            m_documentExplorer.AttachModel(docForm.Diagram.Model)
            docForm.Show()
        End Sub

        Private Sub biFileOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biFileOpen.Click
            ' Open diagram
            If Me.openDiagramDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                docForm = New DiagramForm(Me)
                docForm.OpenFile(Me.openDiagramDialog.FileName)

                If Not docForm.Diagram.Model Is Nothing Then
                    m_documentExplorer.AttachModel(docForm.Diagram.Model)
                End If

                AddHandler docForm.Closing, AddressOf DiagramForm_Closing
                docForm.Show()
            End If
        End Sub

        Private Sub biFileSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biFileSave.Click
            ' Save diagram
            Dim docForm As DiagramForm = Me.ActiveDiagramForm
            If Not docForm Is Nothing Then
                If (Not docForm.HasFileName) Then
                    If Me.saveDiagramDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                        docForm.SaveAsFile(Me.saveDiagramDialog.FileName)
                    End If
                Else
                    docForm.SaveFile()
                End If
            End If
        End Sub

        Private Sub biFileSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biFileSaveAs.Click
            ' Save diagram
            Dim docForm As DiagramForm = Me.ActiveDiagramForm
            If Not docForm Is Nothing Then
                If docForm.HasFileName Then
                    Me.saveDiagramDialog.FileName = docForm.FileName
                End If
                If Me.saveDiagramDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    Dim strFileName As String = Me.saveDiagramDialog.FileName
                    ' search for file extension
                    Dim options As RegexOptions = RegexOptions.IgnoreCase
                    Dim match As Match = Regex.Match(strFileName, "([^.]*)$", options)
                    If match.Success Then
                        Dim imgDiagram As Image

                        Select Case match.Value
                            Case "svg"
                                Dim tosvg As ToSvg = New ToSvg()
                                ' Get Diagram Nodes Bounding Rectangle.
                                Dim rectBounding As RectangleF = Me.ActiveDiagramForm.Diagram.Model.GetBoundingRect()
                                Dim gfx As Graphics = tosvg.GetRealGraphics(New Size(CInt(rectBounding.Width), CInt(rectBounding.Height)))
                                Me.ActiveDiagram.ExportDiagramToGraphics(gfx)
                                tosvg.Save(strFileName)

                            Case "emf"
                                'Save Diagram to created image.
                                imgDiagram = Me.ActiveDiagram.ExportDiagramAsImage(False)

                                ' Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Emf)
                            Case "png"
                                'Save Diagram to created image.
                                imgDiagram = Me.ActiveDiagram.ExportDiagramAsImage(False)

                                ' Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Png)
                            Case "jpg", "jpeg"
                                'Save Diagram to created image.
                                imgDiagram = Me.ActiveDiagram.ExportDiagramAsImage(False)

                                ' Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Jpeg)
                            Case "tiff"
                                'Save Diagram to created image.
                                imgDiagram = Me.ActiveDiagram.ExportDiagramAsImage(False)

                                ' Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Tiff)
                            Case "gif"
                                'Save Diagram to created image.
                                imgDiagram = Me.ActiveDiagram.ExportDiagramAsImage(False)

                                ' Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Gif)
                            Case "bmp"
                                'Save Diagram to created image.
                                imgDiagram = Me.ActiveDiagram.ExportDiagramAsImage(False)

                                ' Save image as metafile.
                                imgDiagram.Save(strFileName, ImageFormat.Bmp)

                            Case Else
                                docForm.SaveAsFile(Me.saveDiagramDialog.FileName)
                        End Select
                    End If
                End If
            End If
        End Sub

        Private Sub biPrintPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biPrintPreview.Click
            Me.PrintPreview()
        End Sub

        Private Sub biFilePrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biFilePrint.Click
            Me.Print()
        End Sub
        Private Sub biPageSetup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biPageSetup.Click
            Me.PageSetup()
        End Sub
        Private Sub biFileExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biFileExit.Click
            Application.Exit()
        End Sub
        Private Sub barItemHeaderFooter_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemHeaderFooter.Click
            HeaderFooterSetup()
        End Sub
        Private Sub barItemPageBorders_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemPageBorders.Click
            PageBordersSetup()
        End Sub
#End Region

#Region "Edit Menu Event Handlers"

        Private Sub barItemEditCut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemEditCut.Click
            If Not Me.ActiveMdiChild Is Nothing Then
                Dim diagramForm As DiagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
                If Not diagramForm Is Nothing Then
                    diagramForm.Diagram.Controller.Cut()
                End If
            End If
        End Sub
        Private Sub barItemEditCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemEditCopy.Click
            If Not Me.ActiveMdiChild Is Nothing Then
                Dim diagramForm As DiagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
                If Not diagramForm Is Nothing Then
                    diagramForm.Diagram.Controller.Copy()
                End If
            End If
        End Sub
        Private Sub barItemEditPaste_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemEditPaste.Click
            If Not Me.ActiveMdiChild Is Nothing Then
                Dim diagramForm As DiagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
                If Not diagramForm Is Nothing Then
                    diagramForm.Diagram.Controller.Paste()
                End If
            End If
        End Sub
        Private Sub barItemEditUndo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemEditUndo.Click
            If Not Me.ActiveMdiChild Is Nothing Then
                Dim diagramForm As DiagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
                If Not diagramForm Is Nothing Then
                    diagramForm.Diagram.Model.HistoryManager.Undo()
                    propertyEditor_Renamed.PropertyGrid.Refresh()
                End If
            End If
        End Sub
        Private Sub barItemEditRedo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemEditRedo.Click
            If Not Me.ActiveMdiChild Is Nothing Then
                Dim diagramForm As DiagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
                If Not diagramForm Is Nothing Then
                    diagramForm.Diagram.Model.HistoryManager.Redo()
                    propertyEditor_Renamed.PropertyGrid.Refresh()
                End If
            End If
        End Sub
        Private Sub barItemEditSelectAll_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemEditSelectAll.Click
            If Not Me.ActiveMdiChild Is Nothing Then
                Dim diagramForm As DiagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
                If Not diagramForm Is Nothing Then
                    diagramForm.Diagram.Controller.SelectAll()
                End If
            End If
        End Sub
#End Region

#Region "View Menu Event Handlers"
        Public Sub barShowRulers_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barShowRulers.Click
            If Not ActiveDiagram Is Nothing Then
                barShowRulers.Checked = Not barShowRulers.Checked
                Me.ActiveDiagram.ShowRulers = barShowRulers.Checked
            End If
        End Sub
        Private Sub barItemViewSymbolPalette_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemViewSymbolPalette.Click
            If Me.barItemViewSymbolPalette.Checked Then
                Me.dockingManager.SetDockVisibility(Me.symbolPaletteGroupBar, False)
                Me.barItemViewSymbolPalette.Checked = False
            Else
                Me.dockingManager.SetDockVisibility(Me.symbolPaletteGroupBar, True)
                Me.barItemViewSymbolPalette.Checked = True
            End If
        End Sub

        Private Sub barItemViewProperties_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemViewProperties.Click
            If Me.barItemViewProperties.Checked Then
                Me.dockingManager.SetDockVisibility(Me.propertyEditor_Renamed, False)
            Else
                Me.dockingManager.SetDockVisibility(Me.propertyEditor_Renamed, True)
            End If
        End Sub

        Private Sub barItemPanZoom_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemPanZoom.Click
            If barItemPanZoom.Checked Then
                dockingManager.SetDockVisibility(overviewControl1, False)
            Else
                If Not Me.ActiveDiagram Is Nothing Then
                    dockingManager.SetDockVisibility(overviewControl1, True)
                End If
            End If
        End Sub
        Private Sub barItemDocumentExplorer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemDocumentExplorer.Click
            If barItemDocumentExplorer.Checked Then
                ' Hide the document explorer control
                dockingManager.SetDockVisibility(m_documentExplorer, False)
                barItemDocumentExplorer.Checked = False
            Else
                ' Initialize the OverviewControl with the active diagram's Model & View and display the control
                If (Not Me.ActiveDiagram Is Nothing) AndAlso ((Not Me.dockingManager.GetDockVisibility(m_documentExplorer))) Then
                    dockingManager.SetDockVisibility(m_documentExplorer, True)
                    dockingManager.SetControlSize(m_documentExplorer, New Size(201, 492))
                End If

                barItemDocumentExplorer.Checked = True
            End If
        End Sub
        Private Sub HeaderFooterSetup()
            'INSTANT VB NOTE: The local variable activeDiagram was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            Dim activeDiagram_Renamed As Controls.Diagram = Me.ActiveDiagram
            If Not activeDiagram_Renamed Is Nothing AndAlso Not activeDiagram_Renamed.Model Is Nothing Then
                Dim dlgHF As HeaderFooterDialog = New HeaderFooterDialog()
                dlgHF.Header = activeDiagram_Renamed.Model.HeaderFooterData.Header
                dlgHF.Footer = activeDiagram_Renamed.Model.HeaderFooterData.Footer
                dlgHF.MeasurementUnits = activeDiagram_Renamed.Model.MeasurementUnits
                If dlgHF.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    activeDiagram_Renamed.Model.HeaderFooterData.Header = dlgHF.Header
                    activeDiagram_Renamed.Model.HeaderFooterData.Footer = dlgHF.Footer
                End If
            End If
        End Sub

        Private Sub PageBordersSetup()
            'INSTANT VB NOTE: The local variable activeDiagram was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            Dim activeDiagram_Renamed As Controls.Diagram = Me.ActiveDiagram
            If Not activeDiagram_Renamed Is Nothing AndAlso Not activeDiagram_Renamed.Model Is Nothing Then
                Dim borderDialog As PageBorderDialog = New PageBorderDialog()
                borderDialog.PageBorderStyle = activeDiagram_Renamed.View.PageBorderStyle
                If borderDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    activeDiagram_Renamed.View.PageBorderStyle = borderDialog.PageBorderStyle
                    activeDiagram_Renamed.View.RefreshPageSettings()
                    activeDiagram_Renamed.UpdateView()
                End If
            End If
        End Sub


#End Region

#Region "Window Menu Event Handlers"

        Private Sub biTabbedMDI_Click(ByVal sender As Object, ByVal e As EventArgs) Handles biTabbedMDI.Click
            ' Toggle tabbed MDI mode
            Dim barItem As Tools.XPMenus.BarItem = CType(IIf(TypeOf sender Is Tools.XPMenus.BarItem, sender, Nothing), Tools.XPMenus.BarItem)
            If Not barItem Is Nothing Then
                If barItem.Checked Then
                    tabbedMDIManager.DetachFromMdiContainer(Me, True)
                    barItem.Checked = False
                Else
                    tabbedMDIManager.AttachToMdiContainer(Me)
                    barItem.Checked = True
                End If
            End If
        End Sub

#End Region

#Region "Help Menu Event Handlers"

        Private Sub barItemAbout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemAbout.Click
            Dim aboutDlg As DemoCommon.AboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
            aboutDlg.ShowDialog(Me)
        End Sub

#End Region

#Region "Docking"

        Private Sub dockingManager_DockVisibilityChanged(ByVal sender As Object, ByVal e As Tools.DockVisibilityChangedEventArgs)
            If e.Control Is Me.propertyEditor_Renamed Then
                Dim check As Boolean = Me.dockingManager.GetDockVisibility(propertyEditor_Renamed)
                If check Then
                    propertyEditor_Renamed.Diagram = Me.ActiveDiagram
                    Me.barItemViewProperties.Checked = True
                Else
                    propertyEditor_Renamed.Diagram = Nothing
                    Me.barItemViewProperties.Checked = False
                End If
            ElseIf e.Control Is Me.symbolPaletteGroupBar Then
                Me.barItemViewSymbolPalette.Checked = Me.dockingManager.GetDockVisibility(symbolPaletteGroupBar)
            ElseIf e.Control Is Me.overviewControl1 Then
                Dim check As Boolean = Me.dockingManager.GetDockVisibility(overviewControl1)
                If check Then
                    overviewControl1.Diagram = Me.ActiveDiagram
                    Me.barItemViewProperties.Checked = True
                Else
                    overviewControl1.DetachDiagram()
                    Me.barItemPanZoom.Checked = False
                End If
            ElseIf e.Control Is m_documentExplorer Then
                barItemDocumentExplorer.Checked = Me.dockingManager.GetDockVisibility(m_documentExplorer)
            End If
        End Sub

#End Region

#Region "UI Updating"

        Private Sub OnIdle(ByVal sender As Object, ByVal evtArgs As EventArgs)
            'INSTANT VB NOTE: The local variable activeDiagram was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            Dim activeDiagram_Renamed As Controls.Diagram = Me.ActiveDiagram

            Dim editUndoText As String = Me.resStringMgr.GetString("EditUndoText")
            Dim editRedoText As String = Me.resStringMgr.GetString("EditRedoText")
            Me.barItemPanZoom.Checked = dockingManager.GetDockVisibility(overviewControl1)
            Me.barItemDocumentExplorer.Checked = dockingManager.GetDockVisibility(m_documentExplorer)
            Me.barItemViewProperties.Checked = dockingManager.GetDockVisibility(propertyEditor_Renamed)
            Me.barItemViewSymbolPalette.Checked = dockingManager.GetDockVisibility(symbolPaletteGroupBar)

            If Not activeDiagram_Renamed Is Nothing AndAlso Not activeDiagram_Renamed.Model Is Nothing Then
                Me.biFileSave.Enabled = True
                Me.biFileSaveAs.Enabled = True
                Me.barItemEditCopy.Enabled = activeDiagram_Renamed.CanCopy
                Me.barItemEditCut.Enabled = activeDiagram_Renamed.CanCut
                If Me.WindowState <> FormWindowState.Minimized Then
                    Me.barItemEditPaste.Enabled = ActiveDiagram.CanPaste
                End If
                Me.barItemEditUndo.Enabled = activeDiagram_Renamed.Model.HistoryManager.CanUndo
                Me.barItemEditRedo.Enabled = activeDiagram_Renamed.Model.HistoryManager.CanRedo
                Me.barItemEditDelete.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                Me.barShowRulers.Enabled = True
                'this.barShowRulers.Checked = this.ActiveDiagram.ShowRulers;
                Me.barItemEditSelectAll.Enabled = True
                Me.biFilePrint.Enabled = True
                Me.biPageSetup.Enabled = True
                barItemAlignLeft.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count >= 2)
                barItemAlignCenter.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count >= 2)
                barItemAlignRight.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count >= 2)
                barItemAlignTop.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count >= 2)
                barItemAlignMiddle.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count >= 2)
                barItemAlignBottom.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count >= 2)
                barItemFlipHorizontally.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                barItemFlipVertically.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                barItemFlipBoth.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                barItemGroupingGroup.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 1)
                barItemGroupingUnGroup.Enabled = True
                barItemOrderFront.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                barItemOrderForward.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                barItemOrderBackward.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                barItemOrderBack.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                barItemRotateClock.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                barItemRotateConter.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 0)
                barItemResizeWidth.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 1)
                barItemResizeHeight.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 1)
                barItemResizeSize.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 1)
                barItemResizeAcross.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 1)
                barItemResizeDown.Enabled = (Me.ActiveDiagram.Controller.SelectionList.Count > 1)
                If Me.ActiveDiagram.Controller.SelectionList.Count > 0 Then
                    Dim node As Node = Me.ActiveDiagram.Controller.SelectionList(0)
                    barItemFillStyle.Enabled = (Not TypeDescriptor.GetProperties(node, False)("FillStyle") Is Nothing)
                    barItemShadowStyle.Enabled = (Not TypeDescriptor.GetProperties(node, False)("ShadowStyle") Is Nothing)
                End If

                Dim strDescriptions As String() = {""}
                Dim nDescWanted As Integer = 1
                Dim nDescReturned As Integer = activeDiagram_Renamed.Model.HistoryManager.GetUndoDescriptions(nDescWanted, strDescriptions)

                If nDescReturned = nDescWanted Then
                    editUndoText = editUndoText & " " & strDescriptions(0)
                End If

                ' clear strDecsriptions.
                nDescReturned = activeDiagram_Renamed.Model.HistoryManager.GetRedoDescriptions(nDescWanted, strDescriptions)
                If nDescReturned = nDescWanted Then
                    editRedoText = editRedoText & " " & strDescriptions(0)
                End If
            Else
                Me.biFileSave.Enabled = False
                Me.biFileSaveAs.Enabled = False
                Me.barItemEditCopy.Enabled = False
                Me.barItemEditCut.Enabled = False
                Me.barItemEditPaste.Enabled = False
                Me.barItemEditUndo.Enabled = False
                Me.barItemEditRedo.Enabled = False
                Me.barItemEditSelectAll.Enabled = False
                Me.biFilePrint.Enabled = False
                Me.biPageSetup.Enabled = False
                Me.barItemEditDelete.Enabled = False
                Me.barShowRulers.Enabled = False

                barItemAlignLeft.Enabled = False
                barItemAlignCenter.Enabled = False
                barItemAlignRight.Enabled = False
                barItemAlignTop.Enabled = False
                barItemAlignMiddle.Enabled = False
                barItemAlignBottom.Enabled = False
                barItemFlipHorizontally.Enabled = False
                barItemFlipVertically.Enabled = False
                barItemFlipBoth.Enabled = False
                barItemGroupingGroup.Enabled = False
                barItemGroupingUnGroup.Enabled = False
                barItemOrderFront.Enabled = False
                barItemOrderForward.Enabled = False
                barItemOrderBackward.Enabled = False
                barItemOrderBack.Enabled = False
                barItemRotateClock.Enabled = False
                barItemRotateConter.Enabled = False
                barItemResizeWidth.Enabled = False
                barItemResizeHeight.Enabled = False
                barItemResizeSize.Enabled = False
                barItemResizeAcross.Enabled = False
                barItemResizeDown.Enabled = False
                barItemFillStyle.Enabled = False
                barItemShadowStyle.Enabled = False
            End If

            Me.barItemEditUndo.Text = editUndoText
            Me.barItemEditRedo.Text = editRedoText
        End Sub

#End Region

#Region "Printing"

        Private Sub PageSetup()
            

            Dim activeDiagram As Controls.Diagram = Me.ActiveDiagram

            If activeDiagram Is Nothing OrElse activeDiagram.Model Is Nothing Then
                Return
            End If

            Using dlgPageSetup As PageSetupDialog = New PageSetupDialog(activeDiagram.View)
                If dlgPageSetup.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    activeDiagram.UpdateView()
                End If
            End Using
        End Sub

        Private Sub Print()
            '			TextNode txtnode = new TextNode( "Hello World" );
            '			txtnode.SizeToText( new SizeF( 500,50 ) );

            '			InsertNodesCmd inscmd = new InsertNodesCmd();
            '			inscmd.Location = new PointF( 50,50 );
            '			inscmd.Nodes.Add( txtnode );
            '			this.ActiveDiagram.Controller.ExecuteCommand( inscmd );

            '			GroupCmd grpcmd = new GroupCmd();
            '			grpcmd.Nodes.Add( txtnode );
            '			this.ActiveDiagram.Controller.ExecuteCommand( grpcmd );

            'INSTANT VB NOTE: The local variable activeDiagram was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            Dim activeDiagram_Renamed As Controls.Diagram = Me.ActiveDiagram
            If Not activeDiagram_Renamed Is Nothing Then
                Dim printDoc As PrintDocument = activeDiagram_Renamed.CreatePrintDocument()
                Dim printDlg As PrintDialog = New PrintDialog()
                printDlg.Document = printDoc

                printDlg.AllowSomePages = True

                If printDlg.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    printDoc.PrinterSettings = printDlg.PrinterSettings
                    printDoc.Print()
                End If
            End If
        End Sub

        Private Sub PrintPreview()
            'INSTANT VB NOTE: The local variable activeDiagram was renamed since Visual Basic will not uniquely identify class members when local variables have the same name:
            Dim activeDiagram_Renamed As Controls.Diagram = Me.ActiveDiagram

            If Not activeDiagram_Renamed Is Nothing Then
                Dim printDoc As PrintDocument = activeDiagram_Renamed.CreatePrintDocument()
                Dim printPreviewDlg As PrintPreviewDialog = New PrintPreviewDialog()
                printPreviewDlg.StartPosition = FormStartPosition.CenterScreen

                printDoc.PrinterSettings.FromPage = 0
                printDoc.PrinterSettings.ToPage = 0
                printDoc.PrinterSettings.PrintRange = PrintRange.AllPages

                printPreviewDlg.Document = printDoc
                printPreviewDlg.ShowDialog(Me)
            End If
        End Sub

#End Region

#Region "MDI Window Management"

        Private Sub DiagramForm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim docForm As DiagramForm = CType(IIf(TypeOf sender Is DiagramForm, sender, Nothing), DiagramForm)
            If Not docForm Is Nothing AndAlso Not docForm.Diagram.Model Is Nothing Then
                If docForm.Diagram.Model.Modified Then
                    Dim res As DialogResult = MessageBox.Show(Me, "The diagram has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel)
                    If res = System.Windows.Forms.DialogResult.Yes Then
                        If docForm.HasFileName Then
                            Me.saveDiagramDialog.FileName = docForm.FileName
                        End If
                        If Me.saveDiagramDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                            docForm.SaveAsFile(Me.saveDiagramDialog.FileName)
                        Else
                            e.Cancel = True
                        End If
                    ElseIf res = System.Windows.Forms.DialogResult.Cancel Then
                        e.Cancel = True
                    End If
                End If

                If (Not e.Cancel) Then
                    Me.overviewControl1.DetachDiagram()
                    m_documentExplorer.DetachModel(docForm.Diagram.Model)
                End If
            End If
        End Sub

#End Region

#Region "Actions"
        Private Sub m_documentExplorer_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs)
            ' Update diagram's selection list depending on TreeNode Tag
            If TypeOf e.Node.Tag Is Model Then

            ElseIf TypeOf e.Node.Tag Is Node Then
                Dim nodeTemp As Node = CType(IIf(TypeOf e.Node.Tag Is Node, e.Node.Tag, Nothing), Node)

                If Not nodeTemp Is Nothing Then
                    If nodeTemp.Visible AndAlso nodeTemp.Root.Equals(Me.ActiveDiagram.Model) Then
                        ActiveDiagram.View.SelectionList.Clear()
                        ActiveDiagram.View.SelectionList.Add(CType(IIf(TypeOf e.Node.Tag Is Node, e.Node.Tag, Nothing), Node))
                    Else
                        propertyEditor_Renamed.PropertyGrid.SelectedObject = nodeTemp
                    End If
                End If
            End If
        End Sub

        Private Sub barItemEditDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemEditDelete.Click
            If Not Me.ActiveMdiChild Is Nothing Then
                Dim diagramForm As DiagramForm = CType(IIf(TypeOf Me.ActiveMdiChild Is DiagramForm, Me.ActiveMdiChild, Nothing), DiagramForm)
                If Not diagramForm Is Nothing Then
                    diagramForm.Diagram.Controller.Delete()
                End If
            End If
        End Sub

        Private Sub barItemAlign_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemAlignLeft.Click, barItemAlignCenter.Click, barItemAlignRight.Click, barItemAlignTop.Click, barItemAlignMiddle.Click, barItemAlignBottom.Click
            Select Case (CType(sender, Tools.XPMenus.BarItem)).ID
                Case "AlignLeft"
                    Me.ActiveDiagram.AlignLeft()
                Case "AlignCenter"
                    Me.ActiveDiagram.AlignCenter()
                Case "AlignBottom"
                    Me.ActiveDiagram.AlignBottom()
                Case "AlignMiddle"
                    Me.ActiveDiagram.AlignMiddle()
                Case "AlignTop"
                    Me.ActiveDiagram.AlignTop()
                Case "AlignRight"
                    Me.ActiveDiagram.AlignRight()
                Case Else
            End Select

        End Sub

        Private Sub barItemFlip_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemFlipHorizontally.Click, barItemFlipVertically.Click, barItemFlipBoth.Click
            Select Case (CType(sender, Tools.XPMenus.BarItem)).ID.ToLower()
                Case "fliphorizontally"
                    Me.ActiveDiagram.FlipHorizontal()
                Case "flipvertically"
                    Me.ActiveDiagram.FlipVertical()
                Case "flipboth"
                    Me.ActiveDiagram.FlipHorizontal()
                    Me.ActiveDiagram.FlipVertical()
                Case Else
            End Select

        End Sub

        Private Sub barItemGroupingGroup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemGroupingGroup.Click, barItemGroupingUnGroup.Click
            Select Case (CType(sender, Tools.XPMenus.BarItem)).ID.ToLower()
                Case "group"
                    Me.ActiveDiagram.Controller.Group()
                Case "ungroup"
                    Me.ActiveDiagram.Controller.UnGroup()
                Case Else
            End Select
        End Sub

        Private Sub barItemOrder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemOrderFront.Click, barItemOrderForward.Click, barItemOrderBackward.Click, barItemOrderBack.Click
            Select Case (CType(sender, Tools.XPMenus.BarItem)).ID.ToLower()
                Case "bring to front"
                    Me.ActiveDiagram.Controller.BringToFront()
                Case "bring forward"
                    Me.ActiveDiagram.Controller.BringForward()
                Case "send backward"
                    Me.ActiveDiagram.Controller.SendBackward()
                Case "send to back"
                    Me.ActiveDiagram.Controller.SendToBack()
                Case Else
            End Select

        End Sub

        Private Sub barItemRotate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemRotateClock.Click, barItemRotateConter.Click
            Select Case (CType(sender, Tools.XPMenus.BarItem)).ID.ToLower()
                Case "rotateclock"
                    Me.ActiveDiagram.Rotate(90)
                Case "rotateconter"
                    Me.ActiveDiagram.Rotate(-90)
                Case Else
            End Select

        End Sub

        Private Sub barItemResize_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemResizeWidth.Click, barItemResizeHeight.Click, barItemResizeSize.Click, barItemResizeAcross.Click, barItemResizeDown.Click
            Select Case (CType(sender, Tools.XPMenus.BarItem)).ID.ToLower()
                Case "spaceacross"
                    Me.ActiveDiagram.SpaceAcross()
                Case "spacedown"
                    Me.ActiveDiagram.SpaceDown()
                Case "samesize"
                    Me.ActiveDiagram.SameSize()
                Case "sameheight"
                    Me.ActiveDiagram.SameHeight()
                Case "samewidth"
                    Me.ActiveDiagram.SameWidth()
                Case Else
            End Select
        End Sub

        Private Sub barItemLayout_Click(ByVal sender As Object, ByVal e As EventArgs) Handles barItemLayout.Click
            Dim dialog As LayoutDialog = New LayoutDialog(Me.ActiveDiagram)
            dialog.Show()
        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main(ByVal args As String())
            ' Register scripting engines
            ScriptEngineFactory.RegisterScriptEngine(ScriptLanguages.VisualBasic, GetType(Microsoft.VisualBasic.Vsa.VsaEngine))
            ScriptEngineFactory.RegisterScriptEngine(ScriptLanguages.JScript, GetType(Microsoft.JScript.Vsa.VsaEngine))

            AddHandler Application.ThreadException, AddressOf DefaultExceptionHandler.Singleton.OnThreadException
            If args.Length > 0 Then
                If File.Exists(args(0)) Then
                    Application.Run(New MainForm(args(0)))
                Else
                    Console.WriteLine("File not found")
                    Console.WriteLine("----------------")
                    Console.WriteLine("Running in default mode")
                    Application.Run(New MainForm())
                End If
            Else
                Application.Run(New MainForm())
            End If

            RemoveHandler Application.ThreadException, AddressOf DefaultExceptionHandler.Singleton.OnThreadException
        End Sub


        Friend Function GetPopupParentBar() As Tools.XPMenus.ParentBarItem
            Return Me.parentBarItemPopUp
        End Function

        Private Sub shadowBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItemShadowStyle.Click
            Dim ssd As ShadowStyleDialog = New ShadowStyleDialog()
            Dim fs As ShadowStyle = Nothing
            For Each n As Node In Me.ActiveDiagram.Controller.SelectionList
                fs = CType(TypeDescriptor.GetProperties(n, False)("ShadowStyle").GetValue(n), ShadowStyle)
                If Not fs Is Nothing Then
                    Exit For
                End If
            Next n
            If Not fs Is Nothing Then
                ssd.ShadowStyle.Color = fs.Color
                ssd.ShadowStyle.ForeColor = fs.ForeColor
                ssd.ShadowStyle.ColorAlphaFactor = fs.ColorAlphaFactor
                ssd.ShadowStyle.ForeColorAlphaFactor = fs.ForeColorAlphaFactor
                ssd.ShadowStyle.PathBrushStyle = fs.PathBrushStyle
                ssd.ShadowStyle.OffsetX = fs.OffsetX
                ssd.ShadowStyle.OffsetY = fs.OffsetY
                ssd.ShadowStyle.Visible = fs.Visible
                If System.Windows.Forms.DialogResult.OK = ssd.ShowDialog() Then
                    For Each n As Node In Me.ActiveDiagram.Controller.SelectionList
                        fs = CType(TypeDescriptor.GetProperties(n, False)("ShadowStyle").GetValue(n), ShadowStyle)
                        If Not fs Is Nothing Then
                            fs.Color = ssd.ShadowStyle.Color
                            fs.ForeColor = ssd.ShadowStyle.ForeColor
                            fs.ColorAlphaFactor = ssd.ShadowStyle.ColorAlphaFactor
                            fs.ForeColorAlphaFactor = ssd.ShadowStyle.ForeColorAlphaFactor
                            fs.PathBrushStyle = ssd.ShadowStyle.PathBrushStyle
                            fs.OffsetX = ssd.ShadowStyle.OffsetX
                            fs.OffsetY = ssd.ShadowStyle.OffsetY
                            fs.Visible = ssd.ShadowStyle.Visible
                        End If
                    Next n
                End If
            End If
        End Sub

        Private Sub fillBarItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItemFillStyle.Click
            Dim fsd As FillStyleDialog = New FillStyleDialog()
            Dim node As Node
            Dim fs As FillStyle = Nothing
            For Each n As Node In Me.ActiveDiagram.Controller.SelectionList
                fs = CType(TypeDescriptor.GetProperties(n, False)("FillStyle").GetValue(n), FillStyle)
                If Not fs Is Nothing Then
                    node = n
                    Exit For
                End If
            Next n

            If Not fs Is Nothing Then
                fsd.FillStyle.Color = fs.Color
                fsd.FillStyle.ForeColor = fs.ForeColor
                fsd.FillStyle.ColorAlphaFactor = fs.ColorAlphaFactor
                fsd.FillStyle.ForeColorAlphaFactor = fs.ForeColorAlphaFactor
                fsd.FillStyle.Type = fs.Type
                fsd.FillStyle.GradientAngle = fs.GradientAngle
                fsd.FillStyle.GradientCenter = fs.GradientCenter
                fsd.FillStyle.PathBrushStyle = fs.PathBrushStyle
                fsd.FillStyle.HatchBrushStyle = fs.HatchBrushStyle
                fsd.FillStyle.Texture = fs.Texture
                fsd.FillStyle.TextureWrapMode = fs.TextureWrapMode
                If System.Windows.Forms.DialogResult.OK = fsd.ShowDialog() Then
                    For Each n As Node In Me.ActiveDiagram.Controller.SelectionList
                        fs = CType(TypeDescriptor.GetProperties(n, False)("FillStyle").GetValue(n), FillStyle)
                        If Not fs Is Nothing Then
                            fs.Color = fsd.FillStyle.Color
                            fs.ForeColor = fsd.FillStyle.ForeColor
                            fs.ColorAlphaFactor = fsd.FillStyle.ColorAlphaFactor
                            fs.ForeColorAlphaFactor = fsd.FillStyle.ForeColorAlphaFactor
                            fs.Type = fsd.FillStyle.Type
                            fs.GradientAngle = fsd.FillStyle.GradientAngle
                            fs.GradientCenter = fsd.FillStyle.GradientCenter
                            fs.PathBrushStyle = fsd.FillStyle.PathBrushStyle
                            fs.HatchBrushStyle = fsd.FillStyle.HatchBrushStyle
                            fs.Texture = fsd.FillStyle.Texture
                            fs.TextureWrapMode = fsd.FillStyle.TextureWrapMode
                        End If
                    Next n
                End If
            End If
        End Sub

        Private Sub tabbedMDIManager_TabControlAdded(ByVal sender As Object, ByVal args As Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs)
            args.TabControl.TabStyle = GetType(TabRendererOffice2007)
            tabbedMDIManager.ContextMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
        End Sub

        Private Sub MainForm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
            ' Save Menu Bars State
            Dim serializer As AppStateSerializer = New AppStateSerializer(SerializeMode.XMLFile, "..\..\persist")
            Me.mainFrameBarManager.SaveBarState(serializer)
            serializer.PersistNow()
        End Sub
    End Class
End Namespace
