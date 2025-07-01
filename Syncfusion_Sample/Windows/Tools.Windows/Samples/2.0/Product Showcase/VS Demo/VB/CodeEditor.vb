Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace VSDemo
    'Public Enum CodeType
    '    CS
    '    VB
    'End Enum


    Public Class CodeEditor
        Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            'Add any initialization after the InitializeComponent() call
            For Each item As BarItem In Me.ChildFrameBarManager1.Items
                item.CustomTextFont = New Font("Microsoft Sans Serif", 8.0F)
            Next

        End Sub

        Public Sub New(ByVal type As CodeType, ByVal fileName As String)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Select Case type
                Case CodeType.CS
                    Me.editControl1.ApplyConfiguration(Syncfusion.Windows.Forms.Edit.Enums.KnownLanguages.CSharp)
                Case CodeType.VB
                    Me.editControl1.ApplyConfiguration(Syncfusion.Windows.Forms.Edit.Enums.KnownLanguages.VBNET)
            End Select
            Me.editControl1.LoadFile(fileName)
            Me.editControl1.ParsingMode = Syncfusion.Windows.Forms.Edit.Enums.TextParsingMode.PartialParsingNoFallback
        End Sub
        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents ChildFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager
        Friend WithEvents panel1 As System.Windows.Forms.Panel
        Friend WithEvents comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Friend WithEvents splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Friend WithEvents editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
        Friend WithEvents Bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Friend WithEvents EditParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents BarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents ParentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents ParentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents ParentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents BarItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem17 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem18 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem19 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem20 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem21 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem22 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem23 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem24 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem25 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem26 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem27 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem28 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem29 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem30 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem31 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents ParentBarItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents ParentBarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents ParentBarItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents ParentBarItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents ParentBarItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents ParentBarItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents BarItem32 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem33 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem34 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem35 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem36 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem37 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem38 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem39 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem40 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem41 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem42 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem43 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem44 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem45 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem46 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem47 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem48 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem49 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem50 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem51 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem52 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents BarItem53 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents FormatParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Friend WithEvents imageList2 As System.Windows.Forms.ImageList
        Friend WithEvents imageList1 As System.Windows.Forms.ImageList
        Friend WithEvents Bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Friend WithEvents Bar3 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeEditor))
            Dim Config1 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config
            Me.ChildFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(Me)
            Me.Bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.ChildFrameBarManager1, "EditMenu")
            Me.EditParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
            Me.BarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.BarItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem22 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem23 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem24 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem25 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem26 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem27 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem28 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem29 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem30 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.FormatParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.ParentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem32 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem33 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem34 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem35 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem36 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem37 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem38 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem39 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem40 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem41 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem42 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem43 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem44 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem45 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem46 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem47 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem48 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem49 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem50 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem51 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.ParentBarItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.BarItem52 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.BarItem53 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.Bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.ChildFrameBarManager1, "EditToolBar")
            Me.Bar3 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.ChildFrameBarManager1, "FormatToolBar")
            Me.panel1 = New System.Windows.Forms.Panel
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.splitter1 = New System.Windows.Forms.Splitter
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl
            Me.BarItem31 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            CType(Me.ChildFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ChildFrameBarManager1
            '
            Me.ChildFrameBarManager1.BarPositionInfo = CType(resources.GetObject("ChildFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.ChildFrameBarManager1.Bars.Add(Me.Bar1)
            Me.ChildFrameBarManager1.Bars.Add(Me.Bar2)
            Me.ChildFrameBarManager1.Bars.Add(Me.Bar3)
            Me.ChildFrameBarManager1.Categories.Add("Edit")
            Me.ChildFrameBarManager1.Categories.Add("Format")
            Me.ChildFrameBarManager1.CurrentBaseFormType = ""
            Me.ChildFrameBarManager1.Form = Me
            Me.ChildFrameBarManager1.ImageList = Nothing
            Me.ChildFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.ParentBarItem5, Me.EditParentBarItem, Me.ParentBarItem6, Me.BarItem1, Me.ParentBarItem7, Me.BarItem2, Me.ParentBarItem8, Me.BarItem3, Me.ParentBarItem9, Me.BarItem4, Me.ParentBarItem10, Me.BarItem5, Me.BarItem32, Me.BarItem7, Me.BarItem33, Me.BarItem6, Me.BarItem34, Me.ParentBarItem3, Me.BarItem35, Me.BarItem9, Me.BarItem36, Me.ParentBarItem2, Me.BarItem37, Me.ParentBarItem4, Me.BarItem38, Me.BarItem8, Me.BarItem39, Me.BarItem10, Me.BarItem40, Me.BarItem11, Me.BarItem41, Me.BarItem12, Me.BarItem42, Me.BarItem13, Me.BarItem43, Me.BarItem14, Me.BarItem44, Me.BarItem15, Me.BarItem45, Me.BarItem16, Me.BarItem46, Me.BarItem17, Me.BarItem47, Me.BarItem18, Me.BarItem48, Me.BarItem19, Me.BarItem49, Me.BarItem20, Me.BarItem50, Me.BarItem21, Me.BarItem51, Me.BarItem22, Me.BarItem52, Me.BarItem23, Me.BarItem53, Me.BarItem24, Me.FormatParentBarItem, Me.BarItem25, Me.BarItem26, Me.BarItem27, Me.BarItem28, Me.BarItem29, Me.BarItem30})
            Me.ChildFrameBarManager1.LargeImageList = Nothing
            Me.ChildFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'Bar1
            '
            Me.Bar1.BarName = "EditMenu"
            Me.Bar1.BarStyle = CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.Bar1.Caption = "EditMenu"
            Me.Bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.EditParentBarItem, Me.FormatParentBarItem})
            Me.Bar1.Manager = Me.ChildFrameBarManager1
            '
            'EditParentBarItem
            '
            Me.EditParentBarItem.CategoryIndex = 0
            Me.EditParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.EditParentBarItem.ID = "Edit"
            Me.EditParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem1, Me.BarItem2, Me.BarItem3, Me.BarItem4, Me.BarItem5, Me.BarItem7, Me.BarItem6, Me.ParentBarItem3, Me.BarItem9, Me.ParentBarItem2, Me.ParentBarItem4})
            Me.EditParentBarItem.MergeOrder = 1
            Me.EditParentBarItem.SeparatorIndices.AddRange(New Integer() {2, 7, 9, 10})
            Me.EditParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
            Me.EditParentBarItem.Text = "&Edit"
            '
            'BarItem1
            '
            Me.BarItem1.CategoryIndex = 0
            Me.BarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem1.ID = "Undo"
            Me.BarItem1.ImageIndex = 34
            Me.BarItem1.ImageList = Me.imageList2
            Me.BarItem1.Text = "Undo"
            '
            'imageList2
            '
            Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList2.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList2.Images.SetKeyName(0, "")
            Me.imageList2.Images.SetKeyName(1, "")
            Me.imageList2.Images.SetKeyName(2, "")
            Me.imageList2.Images.SetKeyName(3, "")
            Me.imageList2.Images.SetKeyName(4, "")
            Me.imageList2.Images.SetKeyName(5, "")
            Me.imageList2.Images.SetKeyName(6, "")
            Me.imageList2.Images.SetKeyName(7, "")
            Me.imageList2.Images.SetKeyName(8, "")
            Me.imageList2.Images.SetKeyName(9, "")
            Me.imageList2.Images.SetKeyName(10, "")
            Me.imageList2.Images.SetKeyName(11, "")
            Me.imageList2.Images.SetKeyName(12, "")
            Me.imageList2.Images.SetKeyName(13, "")
            Me.imageList2.Images.SetKeyName(14, "")
            Me.imageList2.Images.SetKeyName(15, "")
            Me.imageList2.Images.SetKeyName(16, "")
            Me.imageList2.Images.SetKeyName(17, "")
            Me.imageList2.Images.SetKeyName(18, "")
            Me.imageList2.Images.SetKeyName(19, "")
            Me.imageList2.Images.SetKeyName(20, "")
            Me.imageList2.Images.SetKeyName(21, "")
            Me.imageList2.Images.SetKeyName(22, "")
            Me.imageList2.Images.SetKeyName(23, "")
            Me.imageList2.Images.SetKeyName(24, "")
            Me.imageList2.Images.SetKeyName(25, "")
            Me.imageList2.Images.SetKeyName(26, "")
            Me.imageList2.Images.SetKeyName(27, "")
            Me.imageList2.Images.SetKeyName(28, "")
            Me.imageList2.Images.SetKeyName(29, "")
            Me.imageList2.Images.SetKeyName(30, "")
            Me.imageList2.Images.SetKeyName(31, "")
            Me.imageList2.Images.SetKeyName(32, "")
            Me.imageList2.Images.SetKeyName(33, "")
            Me.imageList2.Images.SetKeyName(34, "")
            Me.imageList2.Images.SetKeyName(35, "")
            Me.imageList2.Images.SetKeyName(36, "")
            Me.imageList2.Images.SetKeyName(37, "")
            Me.imageList2.Images.SetKeyName(38, "")
            Me.imageList2.Images.SetKeyName(39, "")
            '
            'BarItem2
            '
            Me.BarItem2.CategoryIndex = 0
            Me.BarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem2.ID = "Redo"
            Me.BarItem2.ImageIndex = 27
            Me.BarItem2.ImageList = Me.imageList2
            Me.BarItem2.Text = "Redo"
            '
            'BarItem3
            '
            Me.BarItem3.CategoryIndex = 0
            Me.BarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem3.ID = "Cut"
            Me.BarItem3.ImageIndex = 39
            Me.BarItem3.ImageList = Me.imageList2
            Me.BarItem3.Text = "Cut"
            '
            'BarItem4
            '
            Me.BarItem4.CategoryIndex = 0
            Me.BarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem4.ID = "Copy"
            Me.BarItem4.ImageIndex = 35
            Me.BarItem4.ImageList = Me.imageList2
            Me.BarItem4.Text = "Copy"
            '
            'BarItem5
            '
            Me.BarItem5.CategoryIndex = 0
            Me.BarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem5.ID = "Paste"
            Me.BarItem5.ImageIndex = 25
            Me.BarItem5.ImageList = Me.imageList2
            Me.BarItem5.Text = "Paste"
            '
            'BarItem7
            '
            Me.BarItem7.CategoryIndex = 0
            Me.BarItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem7.ID = "Delete"
            Me.BarItem7.Text = "Delete"
            '
            'BarItem6
            '
            Me.BarItem6.CategoryIndex = 0
            Me.BarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem6.ID = "Select All"
            Me.BarItem6.Text = "Select All"
            '
            'ParentBarItem3
            '
            Me.ParentBarItem3.CategoryIndex = 0
            Me.ParentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem3.ID = "Find and Replace"
            Me.ParentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem8, Me.BarItem10, Me.BarItem11, Me.BarItem12})
            Me.ParentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem3.Text = "Find and Replace"
            '
            'BarItem8
            '
            Me.BarItem8.CategoryIndex = 0
            Me.BarItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem8.ID = "Quick Find"
            Me.BarItem8.ImageIndex = 16
            Me.BarItem8.ImageList = Me.imageList2
            Me.BarItem8.Text = "Quick Find"
            '
            'BarItem10
            '
            Me.BarItem10.CategoryIndex = 0
            Me.BarItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem10.ID = "Quick Replace"
            Me.BarItem10.Text = "Quick Replace"
            '
            'BarItem11
            '
            Me.BarItem11.CategoryIndex = 0
            Me.BarItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem11.ID = "Find in Files"
            Me.BarItem11.Text = "Find in Files"
            '
            'BarItem12
            '
            Me.BarItem12.CategoryIndex = 0
            Me.BarItem12.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem12.ID = "Replace in Files"
            Me.BarItem12.Text = "Replace in Files"
            '
            'BarItem9
            '
            Me.BarItem9.CategoryIndex = 0
            Me.BarItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem9.ID = "Goto"
            Me.BarItem9.Text = "Goto"
            '
            'ParentBarItem2
            '
            Me.ParentBarItem2.CategoryIndex = 0
            Me.ParentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem2.ID = "Advanced"
            Me.ParentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem13, Me.BarItem14, Me.BarItem15, Me.BarItem16, Me.BarItem17, Me.BarItem18, Me.BarItem19, Me.BarItem20})
            Me.ParentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem2.Text = "Advanced"
            '
            'BarItem13
            '
            Me.BarItem13.CategoryIndex = 0
            Me.BarItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem13.ID = "Format Document"
            Me.BarItem13.Text = "Format Document"
            '
            'BarItem14
            '
            Me.BarItem14.CategoryIndex = 0
            Me.BarItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem14.ID = "Format Selection"
            Me.BarItem14.Text = "Format Selection"
            '
            'BarItem15
            '
            Me.BarItem15.CategoryIndex = 0
            Me.BarItem15.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem15.ID = "Make Uppercase"
            Me.BarItem15.Text = "Make Uppercase"
            '
            'BarItem16
            '
            Me.BarItem16.CategoryIndex = 0
            Me.BarItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem16.ID = "Make Lowercase"
            Me.BarItem16.Text = "Make Lowercase"
            '
            'BarItem17
            '
            Me.BarItem17.CategoryIndex = 0
            Me.BarItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem17.ID = "Comment Selection"
            Me.BarItem17.ImageIndex = 10
            Me.BarItem17.ImageList = Me.imageList2
            Me.BarItem17.Text = "Comment Selection"
            '
            'BarItem18
            '
            Me.BarItem18.CategoryIndex = 0
            Me.BarItem18.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem18.ID = "Uncomment Selection"
            Me.BarItem18.ImageIndex = 33
            Me.BarItem18.ImageList = Me.imageList2
            Me.BarItem18.Text = "Uncomment Selection"
            '
            'BarItem19
            '
            Me.BarItem19.CategoryIndex = 0
            Me.BarItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem19.ID = "Increase Line Indent"
            Me.BarItem19.ImageIndex = 12
            Me.BarItem19.ImageList = Me.imageList1
            Me.BarItem19.Text = "Increase Line Indent"
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
            '
            'BarItem20
            '
            Me.BarItem20.CategoryIndex = 0
            Me.BarItem20.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem20.ID = "Decrease Line Indent"
            Me.BarItem20.ImageIndex = 11
            Me.BarItem20.ImageList = Me.imageList1
            Me.BarItem20.Text = "Decrease Line Indent"
            '
            'ParentBarItem4
            '
            Me.ParentBarItem4.CategoryIndex = 0
            Me.ParentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem4.ID = "Bookmarks"
            Me.ParentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem21, Me.BarItem22, Me.BarItem23, Me.BarItem24, Me.BarItem25, Me.BarItem26, Me.BarItem27, Me.BarItem28, Me.BarItem29, Me.BarItem30})
            Me.ParentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem4.Text = "Bookmarks"
            '
            'BarItem21
            '
            Me.BarItem21.CategoryIndex = 0
            Me.BarItem21.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem21.ID = "Toggle Bookmark"
            Me.BarItem21.Text = "Toggle Bookmark"
            '
            'BarItem22
            '
            Me.BarItem22.CategoryIndex = 0
            Me.BarItem22.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem22.ID = "Enable Bookmark"
            Me.BarItem22.ImageIndex = 1
            Me.BarItem22.ImageList = Me.imageList2
            Me.BarItem22.Text = "Enable Bookmark"
            '
            'BarItem23
            '
            Me.BarItem23.CategoryIndex = 0
            Me.BarItem23.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem23.ID = "Previous Bookmark"
            Me.BarItem23.ImageIndex = 5
            Me.BarItem23.ImageList = Me.imageList2
            Me.BarItem23.Text = "Previous Bookmark"
            '
            'BarItem24
            '
            Me.BarItem24.CategoryIndex = 0
            Me.BarItem24.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem24.ID = "Next Bookmark"
            Me.BarItem24.ImageIndex = 2
            Me.BarItem24.ImageList = Me.imageList2
            Me.BarItem24.Text = "Next Bookmark"
            '
            'BarItem25
            '
            Me.BarItem25.CategoryIndex = 0
            Me.BarItem25.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem25.ID = "Clear Bookmark"
            Me.BarItem25.ImageIndex = 8
            Me.BarItem25.ImageList = Me.imageList2
            Me.BarItem25.Text = "Clear Bookmark"
            '
            'BarItem26
            '
            Me.BarItem26.CategoryIndex = 0
            Me.BarItem26.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem26.ID = "Previous Bookmark in Folder"
            Me.BarItem26.ImageIndex = 7
            Me.BarItem26.ImageList = Me.imageList2
            Me.BarItem26.Text = "Previous Bookmark in Folder"
            '
            'BarItem27
            '
            Me.BarItem27.CategoryIndex = 0
            Me.BarItem27.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem27.ID = "Next Bookmark in Folder"
            Me.BarItem27.ImageIndex = 4
            Me.BarItem27.ImageList = Me.imageList2
            Me.BarItem27.Text = "Next Bookmark in Folder"
            '
            'BarItem28
            '
            Me.BarItem28.CategoryIndex = 0
            Me.BarItem28.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem28.ID = "Previous Bookmark in Document"
            Me.BarItem28.ImageIndex = 6
            Me.BarItem28.ImageList = Me.imageList2
            Me.BarItem28.Text = "Previous Bookmark in Document"
            '
            'BarItem29
            '
            Me.BarItem29.CategoryIndex = 0
            Me.BarItem29.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem29.ID = "Next Bookmark in Document"
            Me.BarItem29.ImageIndex = 3
            Me.BarItem29.ImageList = Me.imageList2
            Me.BarItem29.Text = "Next Bookmark in Document"
            '
            'BarItem30
            '
            Me.BarItem30.CategoryIndex = 0
            Me.BarItem30.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem30.ID = "Clear All Bookmarks"
            Me.BarItem30.Text = "Clear All Bookmarks"
            '
            'FormatParentBarItem
            '
            Me.FormatParentBarItem.CategoryIndex = 1
            Me.FormatParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormatParentBarItem.ID = "F&ormat"
            Me.FormatParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.ParentBarItem5, Me.ParentBarItem6, Me.ParentBarItem7, Me.ParentBarItem8, Me.ParentBarItem9, Me.ParentBarItem10})
            Me.FormatParentBarItem.MergeOrder = 7
            Me.FormatParentBarItem.Text = "F&ormat"
            '
            'ParentBarItem5
            '
            Me.ParentBarItem5.CategoryIndex = 1
            Me.ParentBarItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem5.ID = "Align"
            Me.ParentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem32, Me.BarItem33, Me.BarItem34, Me.BarItem35, Me.BarItem36, Me.BarItem37})
            Me.ParentBarItem5.SeparatorIndices.AddRange(New Integer() {3})
            Me.ParentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem5.Text = "Align"
            '
            'BarItem32
            '
            Me.BarItem32.CategoryIndex = 1
            Me.BarItem32.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem32.ID = "Left"
            Me.BarItem32.ImageIndex = 15
            Me.BarItem32.ImageList = Me.imageList1
            Me.BarItem32.Text = "Left"
            '
            'BarItem33
            '
            Me.BarItem33.CategoryIndex = 1
            Me.BarItem33.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem33.ID = "Center"
            Me.BarItem33.ImageIndex = 14
            Me.BarItem33.ImageList = Me.imageList1
            Me.BarItem33.Text = "Center"
            '
            'BarItem34
            '
            Me.BarItem34.CategoryIndex = 1
            Me.BarItem34.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem34.ID = "Right"
            Me.BarItem34.ImageIndex = 17
            Me.BarItem34.ImageList = Me.imageList1
            Me.BarItem34.Text = "Right"
            '
            'BarItem35
            '
            Me.BarItem35.CategoryIndex = 1
            Me.BarItem35.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem35.ID = "Top"
            Me.BarItem35.ImageIndex = 18
            Me.BarItem35.ImageList = Me.imageList1
            Me.BarItem35.Text = "Top"
            '
            'BarItem36
            '
            Me.BarItem36.CategoryIndex = 1
            Me.BarItem36.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem36.ID = "Middle"
            Me.BarItem36.ImageIndex = 16
            Me.BarItem36.ImageList = Me.imageList1
            Me.BarItem36.Text = "Middle"
            '
            'BarItem37
            '
            Me.BarItem37.CategoryIndex = 1
            Me.BarItem37.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem37.ID = "Bottom"
            Me.BarItem37.ImageIndex = 13
            Me.BarItem37.ImageList = Me.imageList1
            Me.BarItem37.Text = "Bottom"
            '
            'ParentBarItem6
            '
            Me.ParentBarItem6.CategoryIndex = 1
            Me.ParentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem6.ID = "Make Same Size"
            Me.ParentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem38, Me.BarItem39, Me.BarItem40, Me.BarItem41})
            Me.ParentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem6.Text = "Make Same Size"
            '
            'BarItem38
            '
            Me.BarItem38.CategoryIndex = 1
            Me.BarItem38.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem38.ID = "Width"
            Me.BarItem38.ImageIndex = 36
            Me.BarItem38.ImageList = Me.imageList1
            Me.BarItem38.Text = "Width"
            '
            'BarItem39
            '
            Me.BarItem39.CategoryIndex = 1
            Me.BarItem39.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem39.ID = "Height"
            Me.BarItem39.ImageIndex = 25
            Me.BarItem39.ImageList = Me.imageList1
            Me.BarItem39.Text = "Height"
            '
            'BarItem40
            '
            Me.BarItem40.CategoryIndex = 1
            Me.BarItem40.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem40.ID = "Both"
            Me.BarItem40.ImageIndex = 19
            Me.BarItem40.ImageList = Me.imageList1
            Me.BarItem40.Text = "Both"
            '
            'BarItem41
            '
            Me.BarItem41.CategoryIndex = 1
            Me.BarItem41.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem41.ID = "SizeToGrid"
            Me.BarItem41.ImageIndex = 29
            Me.BarItem41.ImageList = Me.imageList1
            Me.BarItem41.Text = "SizeToGrid"
            '
            'ParentBarItem7
            '
            Me.ParentBarItem7.CategoryIndex = 1
            Me.ParentBarItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem7.ID = "Horizontal Spacing"
            Me.ParentBarItem7.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem42, Me.BarItem43, Me.BarItem44, Me.BarItem45})
            Me.ParentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem7.Text = "Horizontal Spacing"
            '
            'BarItem42
            '
            Me.BarItem42.CategoryIndex = 1
            Me.BarItem42.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem42.ID = "Make Equal"
            Me.BarItem42.ImageIndex = 16
            Me.BarItem42.ImageList = Me.imageList1
            Me.BarItem42.Text = "Make Equal"
            '
            'BarItem43
            '
            Me.BarItem43.CategoryIndex = 1
            Me.BarItem43.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem43.ID = "Increase"
            Me.BarItem43.ImageIndex = 23
            Me.BarItem43.ImageList = Me.imageList1
            Me.BarItem43.Text = "Increase"
            '
            'BarItem44
            '
            Me.BarItem44.CategoryIndex = 1
            Me.BarItem44.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem44.ID = "Decrease"
            Me.BarItem44.ImageIndex = 22
            Me.BarItem44.ImageList = Me.imageList1
            Me.BarItem44.Text = "Decrease"
            '
            'BarItem45
            '
            Me.BarItem45.CategoryIndex = 1
            Me.BarItem45.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem45.ID = "Remove"
            Me.BarItem45.ImageIndex = 24
            Me.BarItem45.ImageList = Me.imageList1
            Me.BarItem45.Text = "Remove"
            '
            'ParentBarItem8
            '
            Me.ParentBarItem8.CategoryIndex = 1
            Me.ParentBarItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem8.ID = "Vertical Spacing"
            Me.ParentBarItem8.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem46, Me.BarItem47, Me.BarItem48, Me.BarItem49})
            Me.ParentBarItem8.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem8.Text = "Vertical Spacing"
            '
            'BarItem46
            '
            Me.BarItem46.CategoryIndex = 1
            Me.BarItem46.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem46.ID = "Make Equal_1"
            Me.BarItem46.ImageIndex = 32
            Me.BarItem46.ImageList = Me.imageList1
            Me.BarItem46.Text = "Make Equal"
            '
            'BarItem47
            '
            Me.BarItem47.CategoryIndex = 1
            Me.BarItem47.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem47.ID = "Increase_1"
            Me.BarItem47.ImageIndex = 37
            Me.BarItem47.ImageList = Me.imageList1
            Me.BarItem47.Text = "Increase"
            '
            'BarItem48
            '
            Me.BarItem48.CategoryIndex = 1
            Me.BarItem48.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem48.ID = "Decrease_1"
            Me.BarItem48.ImageIndex = 33
            Me.BarItem48.ImageList = Me.imageList1
            Me.BarItem48.Text = "Decrease"
            '
            'BarItem49
            '
            Me.BarItem49.CategoryIndex = 1
            Me.BarItem49.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem49.ID = "Remove_1"
            Me.BarItem49.ImageIndex = 34
            Me.BarItem49.ImageList = Me.imageList1
            Me.BarItem49.Text = "Remove"
            '
            'ParentBarItem9
            '
            Me.ParentBarItem9.CategoryIndex = 1
            Me.ParentBarItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem9.ID = "Center In Form"
            Me.ParentBarItem9.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem50, Me.BarItem51})
            Me.ParentBarItem9.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem9.Text = "Center In Form"
            '
            'BarItem50
            '
            Me.BarItem50.CategoryIndex = 1
            Me.BarItem50.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem50.ID = "Horizontally"
            Me.BarItem50.ImageIndex = 35
            Me.BarItem50.ImageList = Me.imageList1
            Me.BarItem50.Text = "Horizontally"
            '
            'BarItem51
            '
            Me.BarItem51.CategoryIndex = 1
            Me.BarItem51.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem51.ID = "Vertically"
            Me.BarItem51.ImageIndex = 26
            Me.BarItem51.ImageList = Me.imageList1
            Me.BarItem51.Text = "Vertically"
            '
            'ParentBarItem10
            '
            Me.ParentBarItem10.CategoryIndex = 1
            Me.ParentBarItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ParentBarItem10.ID = "Order"
            Me.ParentBarItem10.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem52, Me.BarItem53})
            Me.ParentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.ParentBarItem10.Text = "Order"
            '
            'BarItem52
            '
            Me.BarItem52.CategoryIndex = 1
            Me.BarItem52.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem52.ID = "BringToFront"
            Me.BarItem52.ImageIndex = 21
            Me.BarItem52.ImageList = Me.imageList1
            Me.BarItem52.Text = "BringToFront"
            '
            'BarItem53
            '
            Me.BarItem53.CategoryIndex = 1
            Me.BarItem53.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem53.ID = "SendToBack"
            Me.BarItem53.ImageIndex = 28
            Me.BarItem53.ImageList = Me.imageList1
            Me.BarItem53.Text = "SendToBack"
            '
            'Bar2
            '
            Me.Bar2.BarName = "EditToolBar"
            Me.Bar2.Caption = "EditToolBar"
            Me.Bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem1, Me.BarItem2, Me.BarItem3, Me.BarItem4, Me.BarItem5, Me.BarItem17, Me.BarItem18, Me.BarItem19, Me.BarItem20, Me.BarItem22, Me.BarItem23, Me.BarItem24, Me.BarItem25, Me.BarItem26, Me.BarItem27, Me.BarItem28, Me.BarItem29})
            Me.Bar2.Manager = Me.ChildFrameBarManager1
            Me.Bar2.MenuItemMergeOrder = 1
            Me.Bar2.SeparatorIndices.AddRange(New Integer() {5, 9})
            '
            'Bar3
            '
            Me.Bar3.BarName = "FormatToolBar"
            Me.Bar3.Caption = "FormatToolBar"
            Me.Bar3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.BarItem32, Me.BarItem33, Me.BarItem34, Me.BarItem35, Me.BarItem36, Me.BarItem37, Me.BarItem38, Me.BarItem39, Me.BarItem40, Me.BarItem41, Me.BarItem42, Me.BarItem43, Me.BarItem44, Me.BarItem45, Me.BarItem46, Me.BarItem47, Me.BarItem48, Me.BarItem49, Me.BarItem50, Me.BarItem51, Me.BarItem52, Me.BarItem53})
            Me.Bar3.Manager = Me.ChildFrameBarManager1
            Me.Bar3.MenuItemMergeOrder = 2
            Me.Bar3.SeparatorIndices.AddRange(New Integer() {6, 10, 14, 18, 20})
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.comboBoxAdv2)
            Me.panel1.Controls.Add(Me.splitter1)
            Me.panel1.Controls.Add(Me.comboBoxAdv1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(800, 24)
            Me.panel1.TabIndex = 5
            '
            'comboBoxAdv2
            '
            Me.comboBoxAdv2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.comboBoxAdv2.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
            Me.comboBoxAdv2.IgnoreThemeBackground = True
            Me.comboBoxAdv2.Location = New System.Drawing.Point(395, 0)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.ShowImageInTextBox = True
            Me.comboBoxAdv2.Size = New System.Drawing.Size(405, 24)
            Me.comboBoxAdv2.SuppressDropDownEvent = False
            Me.comboBoxAdv2.TabIndex = 2
            Me.comboBoxAdv2.Text = "Main(String[] args)"
            '
            'splitter1
            '
            Me.splitter1.Location = New System.Drawing.Point(392, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 24)
            Me.splitter1.TabIndex = 1
            Me.splitter1.TabStop = False
            '
            'comboBoxAdv1
            '
            Me.comboBoxAdv1.Dock = System.Windows.Forms.DockStyle.Left
            Me.comboBoxAdv1.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
            Me.comboBoxAdv1.IgnoreThemeBackground = True
            Me.comboBoxAdv1.Location = New System.Drawing.Point(0, 0)
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.ShowImageInTextBox = True
            Me.comboBoxAdv1.Size = New System.Drawing.Size(392, 24)
            Me.comboBoxAdv1.SuppressDropDownEvent = False
            Me.comboBoxAdv1.TabIndex = 0
            Me.comboBoxAdv1.Text = "ConsoleApplication1.Program()"
            '
            'editControl1
            '
            Me.editControl1.Configurator = Config1
            Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.editControl1.DropAllFiles = False
            Me.editControl1.FileExtensions = New String() {".cs", ".htm", ".html", ".java", ".js", ".pas", ".sql", ".vb", ".vbs", ".xml"}
            Me.editControl1.Location = New System.Drawing.Point(0, 24)
            Me.editControl1.Name = "editControl1"
            Me.editControl1.PseudoFileName = ""
            Me.editControl1.SaveOnClose = False
            Me.editControl1.ShowHorizontalSplitters = False
            Me.editControl1.ShowVerticalSplitters = False
            Me.editControl1.Size = New System.Drawing.Size(800, 702)
            Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
            Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
            Me.editControl1.TabIndex = 3
            Me.editControl1.Text = "editControl1"
            '
            'BarItem31
            '
            Me.BarItem31.CategoryIndex = 1
            Me.BarItem31.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BarItem31.ID = "Align"
            Me.BarItem31.Text = "Align"
            '
            'CodeEditor
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
            Me.ClientSize = New System.Drawing.Size(800, 726)
            Me.Controls.Add(Me.editControl1)
            Me.Controls.Add(Me.panel1)
            Me.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.Name = "CodeEditor"
            Me.Text = "CodeEditor"
            CType(Me.ChildFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

#Region "BarItem Click Event"

        Private Sub OnBarItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarItem1.Click, BarItem2.Click, BarItem3.Click, BarItem4.Click, BarItem5.Click, BarItem6.Click, BarItem11.Click, BarItem12.Click, BarItem17.Click, BarItem18.Click, BarItem19.Click, BarItem20.Click, BarItem21.Click, BarItem22.Click, BarItem23.Click, BarItem26.Click, BarItem27.Click, BarItem28.Click, BarItem29.Click, BarItem30.Click
            Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
            Select Case item.ID
                Case "Undo"
                    Me.editControl1.Undo()
                Case "Redo"
                    Me.editControl1.Redo()
                Case "Cut"
                    Me.editControl1.Cut()
                Case "Copy"
                    Me.editControl1.Copy()
                Case "Paste"
                    Me.editControl1.Paste()
                Case "SelectAll"
                    Me.editControl1.SelectAll()
                Case "Find"
                    Me.editControl1.ShowFindDialog()
                Case "Replace"
                    Me.editControl1.ShowReplaceDialog()
                Case "Comment"
                    Me.editControl1.CommentSelection()
                Case "Uncomment"
                    Me.editControl1.UncommentSelection()
                Case "Indent"
                    Me.editControl1.IndentSelection()
                Case "Outdent"
                    Me.editControl1.OutdentSelection()
                Case "AddBookmark"
                    Me.editControl1.BookmarkAdd(Me.editControl1.CurrentLine)
                Case "PrevBookmark"
                    Me.editControl1.BookmarkPrevious()
                Case "NextBookmark"
                    Me.editControl1.BookmarkNext()
                Case "RemoveBookmark"
                    Me.editControl1.BookmarkRemove(Me.editControl1.CurrentLine)
                Case "ClearBookmark"
                    Me.editControl1.BookmarkClear()
                Case "ToggleBookmark"
                    Me.editControl1.BookmarkToggle()
            End Select

        End Sub
#End Region

    End Class

End Namespace
