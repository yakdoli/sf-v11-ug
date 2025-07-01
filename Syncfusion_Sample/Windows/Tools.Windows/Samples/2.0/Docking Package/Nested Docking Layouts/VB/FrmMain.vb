Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools.XPMenus
Imports Microsoft.Win32
Namespace nesteddockinglayout
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
    Public Class Form1 : Inherits Office2007Form
#Region "Variable declaration"

        Private bNestedTab As Boolean
        Private userControl11 As nesteddockinglayout.UserControl1
        Private userControl12 As nesteddockinglayout.UserControl1
        Private WithEvents dm As DockingManager
        Private mfb As MainFrameBarManager
        Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private pbiFile As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents biExit As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private pbiVisualStyle As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private pbiVSOuterLayout As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents biVSILDefault As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biVSILWindowsXP As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biVSILOffice2003 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private pbiVSInnerLayout As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents biVSOLDefault As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biVSOLWindowsXP As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biVSOLOffice2003 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private pbiDragProviderStyle As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents biNestedTabOnOff As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private pbiDPSInnerLayout As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private pbiDPSOuterLayout As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents biDPSILStandard As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biDPSILVS2005 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biDPSILWhidbey As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biDPSOLStandard As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biDPSOLVS2005 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biDPSOLWhidbey As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biVSILVS2005 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biVSILOffice2007 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biVSOLVS2005 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents biVSOLOffice2007 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private components As System.ComponentModel.IContainer

#End Region

#Region "VS Form code ( Constructor , Initialization and Disposing )"

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '


            InitializeComponent()

          
            Me.mfb.Style = VisualStyle.Office2007
            Me.mfb.Font = New Font("Microsoft Sans Serif", 8.25F)

            '
            ' TODO: Add any constructor code after InitializeComponent call
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
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim ccbuserControl11 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbuserControl12 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Me.dm = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.userControl11 = New nesteddockinglayout.UserControl1
            Me.userControl12 = New nesteddockinglayout.UserControl1
            Me.mfb = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mfb, "Main")
            Me.pbiFile = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.biExit = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.pbiVisualStyle = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.pbiVSOuterLayout = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.biVSILDefault = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biVSILWindowsXP = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biVSILOffice2003 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biVSILOffice2007 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biVSILVS2005 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.pbiVSInnerLayout = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.biVSOLDefault = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biVSOLWindowsXP = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biVSOLOffice2003 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biVSOLOffice2007 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biVSOLVS2005 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.pbiDragProviderStyle = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.pbiDPSInnerLayout = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.biDPSILStandard = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biDPSILVS2005 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biDPSILWhidbey = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.pbiDPSOuterLayout = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.biDPSOLStandard = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biDPSOLVS2005 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biDPSOLWhidbey = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.biNestedTabOnOff = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            CType(Me.dm, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.mfb, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dm
            '
            Me.dm.AutoHideTabFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.dm.DockLayoutStream = CType(resources.GetObject("dm.DockLayoutStream"), System.IO.MemoryStream)
            Me.dm.DockTabFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.dm.HostControl = Me
            Me.dm.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.dm.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
            Me.dm.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
            Me.dm.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
            Me.dm.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
            Me.dm.SetDockLabel(Me.userControl11, "Color Panel1")
            ccbuserControl11.MergeWith(Me.dm.CaptionButtons, False)
            Me.dm.SetCustomCaptionButtons(Me.userControl11, ccbuserControl11)
            Me.dm.SetDockLabel(Me.userControl12, "ColorPanel2")
            ccbuserControl12.MergeWith(Me.dm.CaptionButtons, False)
            Me.dm.SetCustomCaptionButtons(Me.userControl12, ccbuserControl12)
            '
            'userControl11
            '
            Me.dm.SetEnableDocking(Me.userControl11, True)
            Me.userControl11.Location = New System.Drawing.Point(3, 23)
            Me.userControl11.Name = "userControl11"
            Me.userControl11.NestedTabbing = False
            Me.userControl11.Size = New System.Drawing.Size(354, 396)
            Me.userControl11.TabIndex = 0
            '
            'userControl12
            '
            Me.dm.SetEnableDocking(Me.userControl12, True)
            Me.userControl12.Location = New System.Drawing.Point(3, 23)
            Me.userControl12.Name = "userControl12"
            Me.userControl12.NestedTabbing = False
            Me.userControl12.Size = New System.Drawing.Size(241, 396)
            Me.userControl12.TabIndex = 1
            '
            'mfb
            '
            Me.mfb.BarPositionInfo = CType(resources.GetObject("mfb.BarPositionInfo"), System.IO.MemoryStream)
            Me.mfb.Bars.Add(Me.bar1)
            Me.mfb.Categories.Add("main")
            Me.mfb.Categories.Add("file")
            Me.mfb.Categories.Add("visualstyle")
            Me.mfb.Categories.Add("innerlayout")
            Me.mfb.Categories.Add("outerlayout")
            Me.mfb.Categories.Add("DragProviderstyle")
            Me.mfb.Categories.Add("DInner Layout")
            Me.mfb.Categories.Add("DOuter Layout")
            Me.mfb.CurrentBaseFormType = ""
            Me.mfb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mfb.Form = Me
            Me.mfb.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.pbiFile, Me.pbiVisualStyle, Me.pbiDragProviderStyle, Me.biExit, Me.pbiVSInnerLayout, Me.pbiVSOuterLayout, Me.biVSILDefault, Me.biVSILWindowsXP, Me.biVSILOffice2003, Me.biVSOLDefault, Me.biVSOLWindowsXP, Me.biVSOLOffice2003, Me.biNestedTabOnOff, Me.pbiDPSInnerLayout, Me.pbiDPSOuterLayout, Me.biDPSILStandard, Me.biDPSILVS2005, Me.biDPSILWhidbey, Me.biDPSOLStandard, Me.biDPSOLVS2005, Me.biDPSOLWhidbey, Me.biVSILVS2005, Me.biVSILOffice2007, Me.biVSOLVS2005, Me.biVSOLOffice2007})
            Me.mfb.ResetCustomization = False
            Me.mfb.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'bar1
            '
            Me.bar1.BarName = "Main"
            Me.bar1.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "Main"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.pbiFile, Me.pbiVisualStyle, Me.pbiDragProviderStyle, Me.biNestedTabOnOff})
            Me.bar1.Manager = Me.mfb
            '
            'pbiFile
            '
            Me.pbiFile.CategoryIndex = 0
            Me.pbiFile.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pbiFile.ID = "pbiFile"
            Me.pbiFile.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biExit})
            Me.pbiFile.Text = "File"
            '
            'biExit
            '
            Me.biExit.CategoryIndex = 1
            Me.biExit.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biExit.ID = "biExit"
            Me.biExit.Text = "Exit"
            '
            'pbiVisualStyle
            '
            Me.pbiVisualStyle.CategoryIndex = 0
            Me.pbiVisualStyle.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pbiVisualStyle.ID = "pbiVisualStyle"
            Me.pbiVisualStyle.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.pbiVSOuterLayout, Me.pbiVSInnerLayout})
            Me.pbiVisualStyle.Text = "Visual Style"
            '
            'pbiVSOuterLayout
            '
            Me.pbiVSOuterLayout.CategoryIndex = 2
            Me.pbiVSOuterLayout.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pbiVSOuterLayout.ID = "InnerLayout"
            Me.pbiVSOuterLayout.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biVSILDefault, Me.biVSILWindowsXP, Me.biVSILOffice2003, Me.biVSILOffice2007, Me.biVSILVS2005})
            Me.pbiVSOuterLayout.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.pbiVSOuterLayout.Text = "InnerLayout"
            '
            'biVSILDefault
            '
            Me.biVSILDefault.CategoryIndex = 3
            Me.biVSILDefault.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSILDefault.ID = "Default"
            Me.biVSILDefault.Text = "Default"
            '
            'biVSILWindowsXP
            '
            Me.biVSILWindowsXP.CategoryIndex = 3
            Me.biVSILWindowsXP.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSILWindowsXP.ID = "Windows XP themes"
            Me.biVSILWindowsXP.Text = "Windows XP themes"
            '
            'biVSILOffice2003
            '
            Me.biVSILOffice2003.CategoryIndex = 3
            Me.biVSILOffice2003.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSILOffice2003.ID = "Office 2003 Style"
            Me.biVSILOffice2003.Text = "Office 2003 Style"
            '
            'biVSILOffice2007
            '
            Me.biVSILOffice2007.CategoryIndex = 3
            Me.biVSILOffice2007.Checked = True
            Me.biVSILOffice2007.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSILOffice2007.ID = "Office2007"
            Me.biVSILOffice2007.Text = "Office 2007 Style"
            '
            'biVSILVS2005
            '
            Me.biVSILVS2005.CategoryIndex = 3
            Me.biVSILVS2005.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSILVS2005.ID = "VS2005_2"
            Me.biVSILVS2005.Text = "VS 2005"
            '
            'pbiVSInnerLayout
            '
            Me.pbiVSInnerLayout.CategoryIndex = 2
            Me.pbiVSInnerLayout.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pbiVSInnerLayout.ID = "Outer Layout"
            Me.pbiVSInnerLayout.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biVSOLDefault, Me.biVSOLWindowsXP, Me.biVSOLOffice2003, Me.biVSOLOffice2007, Me.biVSOLVS2005})
            Me.pbiVSInnerLayout.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.pbiVSInnerLayout.Text = "Outer Layout"
            '
            'biVSOLDefault
            '
            Me.biVSOLDefault.CategoryIndex = 4
            Me.biVSOLDefault.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSOLDefault.ID = "Default_1"
            Me.biVSOLDefault.Text = "Default"
            '
            'biVSOLWindowsXP
            '
            Me.biVSOLWindowsXP.CategoryIndex = 4
            Me.biVSOLWindowsXP.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSOLWindowsXP.ID = "Windows XP themes_1"
            Me.biVSOLWindowsXP.Text = "Windows XP Themes"
            '
            'biVSOLOffice2003
            '
            Me.biVSOLOffice2003.CategoryIndex = 4
            Me.biVSOLOffice2003.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSOLOffice2003.ID = "Office 2003 Style_1"
            Me.biVSOLOffice2003.Text = "Office 2003 Style"
            '
            'biVSOLOffice2007
            '
            Me.biVSOLOffice2007.CategoryIndex = 4
            Me.biVSOLOffice2007.Checked = True
            Me.biVSOLOffice2007.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSOLOffice2007.ID = "Office2007_1"
            Me.biVSOLOffice2007.Text = "Office 2007 Style"
            '
            'biVSOLVS2005
            '
            Me.biVSOLVS2005.CategoryIndex = 4
            Me.biVSOLVS2005.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biVSOLVS2005.ID = "VS2005_3"
            Me.biVSOLVS2005.Text = "VS 2005"
            '
            'pbiDragProviderStyle
            '
            Me.pbiDragProviderStyle.CategoryIndex = 0
            Me.pbiDragProviderStyle.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pbiDragProviderStyle.ID = "pbiDragProviderStyle"
            Me.pbiDragProviderStyle.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.pbiDPSInnerLayout, Me.pbiDPSOuterLayout})
            Me.pbiDragProviderStyle.Text = "Drag Provider Style"
            '
            'pbiDPSInnerLayout
            '
            Me.pbiDPSInnerLayout.CategoryIndex = 5
            Me.pbiDPSInnerLayout.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pbiDPSInnerLayout.ID = "Inner Layout"
            Me.pbiDPSInnerLayout.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biDPSILStandard, Me.biDPSILVS2005, Me.biDPSILWhidbey})
            Me.pbiDPSInnerLayout.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.pbiDPSInnerLayout.Text = "Inner Layout"
            '
            'biDPSILStandard
            '
            Me.biDPSILStandard.CategoryIndex = 6
            Me.biDPSILStandard.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biDPSILStandard.ID = "Standard"
            Me.biDPSILStandard.Text = "Standard"
            '
            'biDPSILVS2005
            '
            Me.biDPSILVS2005.CategoryIndex = 6
            Me.biDPSILVS2005.Checked = True
            Me.biDPSILVS2005.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biDPSILVS2005.ID = "VS2005"
            Me.biDPSILVS2005.Text = "VS2005"
            '
            'biDPSILWhidbey
            '
            Me.biDPSILWhidbey.CategoryIndex = 6
            Me.biDPSILWhidbey.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biDPSILWhidbey.ID = "Whidbey"
            Me.biDPSILWhidbey.Text = "Whidbey"
            '
            'pbiDPSOuterLayout
            '
            Me.pbiDPSOuterLayout.CategoryIndex = 5
            Me.pbiDPSOuterLayout.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.pbiDPSOuterLayout.ID = "Outer Layout_1"
            Me.pbiDPSOuterLayout.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biDPSOLStandard, Me.biDPSOLVS2005, Me.biDPSOLWhidbey})
            Me.pbiDPSOuterLayout.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.pbiDPSOuterLayout.Text = "Outer Layout"
            '
            'biDPSOLStandard
            '
            Me.biDPSOLStandard.CategoryIndex = 7
            Me.biDPSOLStandard.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biDPSOLStandard.ID = "Standard_1"
            Me.biDPSOLStandard.Text = "Standard"
            '
            'biDPSOLVS2005
            '
            Me.biDPSOLVS2005.CategoryIndex = 7
            Me.biDPSOLVS2005.Checked = True
            Me.biDPSOLVS2005.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biDPSOLVS2005.ID = "VS2005_1"
            Me.biDPSOLVS2005.Text = "VS2005"
            '
            'biDPSOLWhidbey
            '
            Me.biDPSOLWhidbey.CategoryIndex = 7
            Me.biDPSOLWhidbey.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biDPSOLWhidbey.ID = "Whidbey_1"
            Me.biDPSOLWhidbey.Text = "Whidbey"
            '
            'biNestedTabOnOff
            '
            Me.biNestedTabOnOff.CategoryIndex = 0
            Me.biNestedTabOnOff.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.biNestedTabOnOff.ID = "NestedTabbing"
            Me.biNestedTabOnOff.Text = "Nested Tabbing OFF"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(620, 446)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Nested Docking Layouts"
            CType(Me.dm, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.mfb, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub


#End Region

#Region "Properties"

        'To assign Nexted tabbing

        Public Property NestedTabbing() As Boolean
            Get
                Return bNestedTab
            End Get
            Set(ByVal value As Boolean)
                bNestedTab = value
                If bNestedTab Then
                    If dm.GetDockVisibility(Me.userControl11) And dm.GetDockVisibility(Me.userControl12) Then
                        dm.LockHostFormUpdate()
                        userControl11.NestedTabbing = True
                        userControl12.NestedTabbing = True
                        dm.DockTabAlignment = DockTabAlignmentStyle.Top
                        dm.DockControl(userControl12, Me, DockingStyle.Left, 650)
                        dm.DockControl(userControl11, userControl12, DockingStyle.Tabbed, 650, False)
                        dm.UnlockHostFormUpdate()
                    End If
                Else
                    userControl11.NestedTabbing = False
                    userControl12.NestedTabbing = False

                End If
            End Set
        End Property
#End Region

#Region "Event Handlers"

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        End Sub

        ' Assigning VisualStyle Default to Outer Layout.
        Private Sub VS_OL_DefaultMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSOLDefault.Click
            dm.VisualStyle = VisualStyle.Default
            dm.ThemesEnabled = False
            Me.biVSOLDefault.Checked = True
            Me.biVSOLOffice2003.Checked = False
            Me.biVSOLWindowsXP.Checked = False
            Me.biVSOLOffice2007.Checked = False
            Me.biVSOLVS2005.Checked = False
        End Sub

        ' Assigning VisualStyle OfficeXP to Outer Layout.
        Private Sub VS_OL_OfficeXPMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSOLWindowsXP.Click
            dm.VisualStyle = VisualStyle.Default
            dm.ThemesEnabled = True
            Me.biVSOLDefault.Checked = False
            Me.biVSOLOffice2003.Checked = False
            Me.biVSOLWindowsXP.Checked = True
            Me.biVSOLOffice2007.Checked = False
            Me.biVSOLVS2005.Checked = False
        End Sub

        ' Assigning VisualStyle Office2003 to Outer Layout.
        Private Sub VS_OL_Office2003Menu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSOLOffice2003.Click
            dm.VisualStyle = VisualStyle.Office2003
            Me.biVSOLDefault.Checked = False
            Me.biVSOLOffice2003.Checked = True
            Me.biVSOLWindowsXP.Checked = False
            Me.biVSOLOffice2007.Checked = False
            Me.biVSOLVS2005.Checked = False
        End Sub

        Private Sub VS_OL_VS2005Menu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSOLVS2005.Click
            dm.VisualStyle = VisualStyle.VS2005
            Me.biVSOLDefault.Checked = False
            Me.biVSOLOffice2003.Checked = False
            Me.biVSOLWindowsXP.Checked = False
            Me.biVSOLOffice2007.Checked = False
            Me.biVSOLVS2005.Checked = True
        End Sub

        Private Sub VS_OL_Office2007Menu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSOLOffice2007.Click
            dm.VisualStyle = VisualStyle.Office2007
            Me.biVSOLDefault.Checked = False
            Me.biVSOLOffice2003.Checked = False
            Me.biVSOLWindowsXP.Checked = False
            Me.biVSOLOffice2007.Checked = True
            Me.biVSOLVS2005.Checked = False
        End Sub

        ' Assigning VisualStyle Default to Inner Layout.
        Private Sub VS_IL_DefaultMenu_Clcik(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSILDefault.Click
            userControl11.VisualStyle = VisualStyle.Default
            userControl11.ThemesEnabled = False
            userControl12.VisualStyle = VisualStyle.Default
            userControl12.ThemesEnabled = False
            biVSILDefault.Checked = True
            biVSILOffice2003.Checked = False
            biVSILWindowsXP.Checked = False
	    biVSILOffice2007.Checked = False
        End Sub

        ' Assigning VisualStyle OfficeXP to Inner Layout.
        Private Sub VS_IL_OfficeXPMenu_Clcik(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSILWindowsXP.Click
            userControl11.VisualStyle = VisualStyle.Default
            userControl11.ThemesEnabled = True
            userControl12.VisualStyle = VisualStyle.Default
            userControl12.ThemesEnabled = True
            Me.biVSILDefault.Checked = False
            Me.biVSILOffice2003.Checked = False
            Me.biVSILWindowsXP.Checked = True
            Me.biVSILOffice2007.Checked = False
            Me.biVSILVS2005.Checked = False
        End Sub

        ' Assigning VisualStyle Office2003 to Inner Layout.
        Private Sub VS_IL_Office2003Menu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSILOffice2003.Click
            userControl11.VisualStyle = VisualStyle.Office2003
            userControl12.VisualStyle = VisualStyle.Office2003
            Me.biVSILDefault.Checked = False
            Me.biVSILOffice2003.Checked = True
            Me.biVSILWindowsXP.Checked = False
            Me.biVSILOffice2007.Checked = False
            Me.biVSILVS2005.Checked = False
        End Sub

        Private Sub VS_IL_VS2005Menu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSILVS2005.Click
            userControl11.VisualStyle = VisualStyle.VS2005
            userControl12.VisualStyle = VisualStyle.VS2005
            Me.biVSILDefault.Checked = False
            Me.biVSILOffice2003.Checked = False
            Me.biVSILWindowsXP.Checked = False
            Me.biVSILOffice2007.Checked = False
            Me.biVSILVS2005.Checked = True
        End Sub

        Private Sub VS_IL_Office2007Menu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biVSILOffice2007.Click
            userControl11.VisualStyle = VisualStyle.Office2007
            userControl12.VisualStyle = VisualStyle.Office2007
            Me.biVSILDefault.Checked = False
            Me.biVSILOffice2003.Checked = False
            Me.biVSILWindowsXP.Checked = False
            Me.biVSILOffice2007.Checked = True
            Me.biVSILVS2005.Checked = False
        End Sub

        ' Assigning NestedTabb On or Off.
        Private Sub NestedOnOffMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biNestedTabOnOff.Click
            If Me.biNestedTabOnOff.Text = "Nested Tabbing OFF" Then
                Me.biNestedTabOnOff.Text = "Nested Tabbing ON"
                NestedTabbing = True
            Else
                Me.biNestedTabOnOff.Text = "Nested Tabbing OFF"
                NestedTabbing = False
            End If
        End Sub

        ' Assigning DragProviderStyle Standard to Inner Layout.
        Private Sub DPS_IL_StandardMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biDPSILStandard.Click
            Me.userControl11.DragProviderStyle = DragProviderStyle.Standard
            Me.userControl12.DragProviderStyle = DragProviderStyle.Standard
            biDPSILStandard.Checked = True
            biDPSILVS2005.Checked = False
            biDPSILWhidbey.Checked = False
        End Sub

        ' Assigning DragProviderStyle VS2005 to Inner Layout.
        Private Sub DPS_IL_VS2005Menu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biDPSILVS2005.Click
            Me.userControl11.DragProviderStyle = DragProviderStyle.VS2005
            Me.userControl12.DragProviderStyle = DragProviderStyle.VS2005
            biDPSILStandard.Checked = False
            biDPSILVS2005.Checked = True
            biDPSILWhidbey.Checked = False
        End Sub

        ' Assigning DragProviderStyle Whidbey to Inner Layout.
        Private Sub DPS_IL_WhidbeyMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biDPSILWhidbey.Click
            Me.userControl11.DragProviderStyle = DragProviderStyle.Whidbey
            Me.userControl12.DragProviderStyle = DragProviderStyle.Whidbey
            biDPSILStandard.Checked = False
            biDPSILVS2005.Checked = False
            biDPSILWhidbey.Checked = True
        End Sub

        ' Assigning DragProviderStyle Standard to Outer Layout.
        Private Sub DPS_OL_StandardMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biDPSOLStandard.Click
            Me.dm.DragProviderStyle = DragProviderStyle.Standard
            Me.biDPSOLStandard.Checked = True
            Me.biDPSOLVS2005.Checked = False
            Me.biDPSOLWhidbey.Checked = False
        End Sub

        ' Assigning DragProviderStyle VS2005 to Outer Layout.
        Private Sub DPS_OL_VS2005Menu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biDPSOLVS2005.Click
            Me.dm.DragProviderStyle = DragProviderStyle.VS2005
            Me.biDPSOLStandard.Checked = False
            Me.biDPSOLVS2005.Checked = True
            Me.biDPSOLWhidbey.Checked = False
        End Sub

        ' Assigning DragProviderStyle Whidbey to Outer Layout.
        Private Sub DPS_OL_WhidbeyMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biDPSOLWhidbey.Click
            Me.dm.DragProviderStyle = DragProviderStyle.Whidbey
            Me.biDPSOLStandard.Checked = False
            Me.biDPSOLVS2005.Checked = False
            Me.biDPSOLWhidbey.Checked = True
        End Sub

        ' Closing the application.
        Private Sub ExitMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biExit.Click
            Me.Close()
        End Sub
        Private Sub dm_DockAllow(ByVal sender As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.DockAllowEventArgs) Handles dm.DockAllow
            If Me.NestedTabbing AndAlso arg.DockStyle <> DockingStyle.Tabbed Then
                arg.Cancel = True
            End If
        End Sub
#End Region

    End Class
End Namespace
