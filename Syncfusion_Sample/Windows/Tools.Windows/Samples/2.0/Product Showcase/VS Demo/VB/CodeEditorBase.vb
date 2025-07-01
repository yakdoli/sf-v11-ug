Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Tools.XPMenus

Namespace VSDemo
	Public Enum CodeType
		CS
		VB
	End Enum




	''' <summary>
	''' Summary description for CodeEditorBase.
	''' </summary>
	Public Class CodeEditorBase : Inherits System.Windows.Forms.Form
		Friend editControl1 As Syncfusion.Windows.Forms.Edit.EditControl
		Friend childMenuBar As Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager
		Private largeImageList As System.Windows.Forms.ImageList
		Private imageList1 As System.Windows.Forms.ImageList
		Private childToolBar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Friend bar2 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private WithEvents barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private parentBarItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private barItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem17 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem18 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem19 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem20 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem21 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem22 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem23 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem24 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem25 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem26 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem27 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem28 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem29 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem30 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem31 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem32 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem33 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem34 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem35 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem36 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem37 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private imageList2 As System.Windows.Forms.ImageList
		Private panel1 As System.Windows.Forms.Panel
		Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private splitter1 As System.Windows.Forms.Splitter
		Private comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private comboBoxBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
		Friend bar4 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
		Private parentBarItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private parentBarItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
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
		Private barItem56 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem57 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem58 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private barItem59 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Friend EditParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Friend FormatParentBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private components As System.ComponentModel.IContainer


		Public Sub New()
			InitializeComponent()
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
			For Each i As BarItem In Me.childMenuBar.Items
				i.CustomTextFont = New Font("Microsoft Sans Serif", 8.25f)
			Next i
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
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
			Me.components = New System.ComponentModel.Container()
			Dim config1 As Syncfusion.Windows.Forms.Edit.Implementation.Config.Config = New Syncfusion.Windows.Forms.Edit.Implementation.Config.Config()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CodeEditorBase))
			Me.editControl1 = New Syncfusion.Windows.Forms.Edit.EditControl()
			Me.childMenuBar = New Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(Me)
			Me.childToolBar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childMenuBar, "childMenu")
			Me.EditParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
			Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem30 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem31 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem32 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem33 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem34 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem35 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem36 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem37 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem22 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem23 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem24 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem25 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem26 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem27 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem28 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem29 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.FormatParentBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.parentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem54 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.barItem55 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem56 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem57 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem59 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem58 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem50 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem51 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem52 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem53 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem46 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem47 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem48 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem49 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem42 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem43 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem44 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem45 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem40 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem41 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.parentBarItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem38 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem39 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.bar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childMenuBar, "Edit")
			Me.bar4 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.childMenuBar, "Format")
			Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem()
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.largeImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.splitter1 = New System.Windows.Forms.Splitter()
			Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.childMenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' editControl1
			' 
			Me.editControl1.Configurator = config1
			Me.editControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.editControl1.DropAllFiles = False
			Me.editControl1.FileExtensions = New String() { ".cs", ".htm", ".html", ".java", ".js", ".pas", ".sql", ".vb", ".vbs", ".xml"}
			Me.editControl1.Location = New System.Drawing.Point(0, 24)
			Me.editControl1.Name = "editControl1"
			Me.editControl1.PseudoFileName = ""
			Me.editControl1.SaveOnClose = False
			Me.editControl1.ShowHorizontalSplitters = False
			Me.editControl1.ShowVerticalSplitters = False
			Me.editControl1.Size = New System.Drawing.Size(776, 694)
			Me.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70
			Me.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
			Me.editControl1.TabIndex = 0
			Me.editControl1.Text = "editControl1"
			' 
			' childMenuBar
			' 
			Me.childMenuBar.BarPositionInfo = (CType(resources.GetObject("childMenuBar.BarPositionInfo"), System.IO.MemoryStream))
			Me.childMenuBar.Bars.Add(Me.childToolBar1)
			Me.childMenuBar.Bars.Add(Me.bar2)
			Me.childMenuBar.Bars.Add(Me.bar4)
			Me.childMenuBar.Categories.Add("Edit")
			Me.childMenuBar.Categories.Add("EditFind")
			Me.childMenuBar.Categories.Add("Edit Bookmark")
			Me.childMenuBar.Categories.Add("EditAdvanced")
			Me.childMenuBar.Categories.Add("Format")
			Me.childMenuBar.Categories.Add("FormatAlign")
			Me.childMenuBar.Categories.Add("FormatMakeSameSize")
			Me.childMenuBar.Categories.Add("FormatHorzSpacing")
			Me.childMenuBar.Categories.Add("FormatVertSpacing")
			Me.childMenuBar.Categories.Add("FormatCenterInForm")
			Me.childMenuBar.Categories.Add("FormatOrder")
			Me.childMenuBar.CurrentBaseFormType = ""
			Me.childMenuBar.Form = Me
			Me.childMenuBar.ImageList = Nothing
			Me.childMenuBar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem46, Me.barItem54, Me.barItem47, Me.barItem8, Me.barItem48, Me.barItem55, Me.barItem49, Me.barItem9, Me.barItem56, Me.barItem10, Me.barItem57, Me.barItem11, Me.barItem59, Me.barItem12, Me.barItem58, Me.barItem13, Me.barItem14, Me.parentBarItem2, Me.barItem15, Me.parentBarItem3, Me.parentBarItem4, Me.EditParentBarItem, Me.barItem16, Me.barItem17, Me.barItem18, Me.barItem19, Me.barItem20, Me.barItem21, Me.barItem22, Me.barItem23, Me.barItem24, Me.barItem25, Me.barItem26, Me.barItem27, Me.barItem28, Me.barItem29, Me.barItem30, Me.barItem31, Me.barItem32, Me.barItem33, Me.barItem34, Me.barItem35, Me.barItem36, Me.barItem37, Me.comboBoxBarItem1, Me.parentBarItem6, Me.parentBarItem7, Me.parentBarItem8, Me.parentBarItem9, Me.parentBarItem10, Me.parentBarItem11, Me.FormatParentBarItem, Me.barItem38, Me.barItem39, Me.barItem40, Me.barItem41, Me.barItem42, Me.barItem43, Me.barItem44, Me.barItem45, Me.barItem50, Me.barItem51, Me.barItem52, Me.barItem53})
			Me.childMenuBar.LargeImageList = Nothing
			Me.childMenuBar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' childToolBar1
			' 
			Me.childToolBar1.BarName = "childMenu"
			Me.childToolBar1.BarStyle = (CType((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible) Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle))
			Me.childToolBar1.Caption = "childMenu"
			Me.childToolBar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.EditParentBarItem, Me.FormatParentBarItem})
			Me.childToolBar1.Manager = Me.childMenuBar
			' 
			' EditParentBarItem
			' 
			Me.EditParentBarItem.CategoryIndex = 0
			Me.EditParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.EditParentBarItem.ID = "Edit"
			Me.EditParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem8, Me.barItem9, Me.barItem10, Me.barItem11, Me.barItem12, Me.barItem13, Me.barItem14, Me.parentBarItem2, Me.barItem15, Me.parentBarItem4, Me.parentBarItem3})
			Me.EditParentBarItem.MergeOrder = 1
			Me.EditParentBarItem.SeparatorIndices.AddRange(New Integer() { 2, 7, 9, 10})
			Me.EditParentBarItem.Text = "&Edit"
			' 
			' barItem8
			' 
			Me.barItem8.CategoryIndex = 0
			Me.barItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem8.ID = "Undo"
			Me.barItem8.ImageIndex = 34
			Me.barItem8.ImageList = Me.imageList2
			Me.barItem8.Text = "Undo"
'			Me.barItem8.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' imageList2
			' 
			Me.imageList2.ImageStream = (CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer))
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
			' barItem9
			' 
			Me.barItem9.CategoryIndex = 0
			Me.barItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem9.ID = "Redo"
			Me.barItem9.ImageIndex = 27
			Me.barItem9.ImageList = Me.imageList2
			Me.barItem9.Text = "Redo"
'			Me.barItem9.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem10
			' 
			Me.barItem10.CategoryIndex = 0
			Me.barItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem10.ID = "Cut"
			Me.barItem10.ImageIndex = 39
			Me.barItem10.ImageList = Me.imageList2
			Me.barItem10.Text = "Cut"
'			Me.barItem10.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem11
			' 
			Me.barItem11.CategoryIndex = 0
			Me.barItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem11.ID = "Copy"
			Me.barItem11.ImageIndex = 35
			Me.barItem11.ImageList = Me.imageList2
			Me.barItem11.Text = "Copy"
'			Me.barItem11.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem12
			' 
			Me.barItem12.CategoryIndex = 0
			Me.barItem12.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem12.ID = "Paste"
			Me.barItem12.ImageIndex = 25
			Me.barItem12.ImageList = Me.imageList2
			Me.barItem12.Text = "Paste"
'			Me.barItem12.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem13
			' 
			Me.barItem13.CategoryIndex = 0
			Me.barItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem13.ID = "Delete"
			Me.barItem13.Text = "Delete"
			' 
			' barItem14
			' 
			Me.barItem14.CategoryIndex = 0
			Me.barItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem14.ID = "Select All"
			Me.barItem14.Text = "Select All"
'			Me.barItem14.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' parentBarItem2
			' 
			Me.parentBarItem2.CategoryIndex = 0
			Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem2.ID = "Find and Replace"
			Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem16, Me.barItem17, Me.barItem18, Me.barItem19})
			Me.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
			Me.parentBarItem2.Text = "Find and Replace"
			' 
			' barItem16
			' 
			Me.barItem16.CategoryIndex = 1
			Me.barItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem16.ID = "Quick Find"
			Me.barItem16.ImageIndex = 16
			Me.barItem16.ImageList = Me.imageList2
			Me.barItem16.Shortcut = System.Windows.Forms.Shortcut.CtrlF
			Me.barItem16.Text = "Quick Find"
			' 
			' barItem17
			' 
			Me.barItem17.CategoryIndex = 1
			Me.barItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem17.ID = "Quick Replace"
			Me.barItem17.Shortcut = System.Windows.Forms.Shortcut.CtrlH
			Me.barItem17.Text = "Quick Replace"
			' 
			' barItem18
			' 
			Me.barItem18.CategoryIndex = 1
			Me.barItem18.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem18.ID = "Find"
			Me.barItem18.ImageIndex = 40
			Me.barItem18.ImageList = Me.imageList2
			Me.barItem18.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftF
			Me.barItem18.Text = "Find in Files"
'			Me.barItem18.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem19
			' 
			Me.barItem19.CategoryIndex = 1
			Me.barItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem19.ID = "Replace"
			Me.barItem19.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftH
			Me.barItem19.Text = "Replace in Files"
'			Me.barItem19.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem15
			' 
			Me.barItem15.CategoryIndex = 0
			Me.barItem15.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem15.ID = "Goto"
			Me.barItem15.Text = "Goto"
			' 
			' parentBarItem4
			' 
			Me.parentBarItem4.CategoryIndex = 0
			Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem4.ID = "Advanced"
			Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem30, Me.barItem31, Me.barItem32, Me.barItem33, Me.barItem34, Me.barItem35, Me.barItem36, Me.barItem37})
			Me.parentBarItem4.SeparatorIndices.AddRange(New Integer() { 2, 4})
			Me.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
			Me.parentBarItem4.Text = "Advanced"
			' 
			' barItem30
			' 
			Me.barItem30.CategoryIndex = 3
			Me.barItem30.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem30.ID = "Format Document"
			Me.barItem30.Text = "Format Document"
			' 
			' barItem31
			' 
			Me.barItem31.CategoryIndex = 3
			Me.barItem31.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem31.ID = "Format Selection"
			Me.barItem31.Text = "Format Selection"
			' 
			' barItem32
			' 
			Me.barItem32.CategoryIndex = 3
			Me.barItem32.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem32.ID = "Make Uppercase"
			Me.barItem32.Text = "Make Uppercase"
			' 
			' barItem33
			' 
			Me.barItem33.CategoryIndex = 3
			Me.barItem33.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem33.ID = "Make Lowercase"
			Me.barItem33.Text = "Make Lowercase"
			' 
			' barItem34
			' 
			Me.barItem34.CategoryIndex = 3
			Me.barItem34.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem34.ID = "Comment"
			Me.barItem34.ImageIndex = 10
			Me.barItem34.ImageList = Me.imageList2
			Me.barItem34.Text = "Comment Selection"
'			Me.barItem34.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem35
			' 
			Me.barItem35.CategoryIndex = 3
			Me.barItem35.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem35.ID = "Uncomment"
			Me.barItem35.ImageIndex = 33
			Me.barItem35.ImageList = Me.imageList2
			Me.barItem35.Text = "Uncomment Selection"
'			Me.barItem35.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem36
			' 
			Me.barItem36.CategoryIndex = 3
			Me.barItem36.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem36.ID = "Indent"
			Me.barItem36.ImageIndex = 37
			Me.barItem36.ImageList = Me.imageList2
			Me.barItem36.Text = "Increase Line Indent"
'			Me.barItem36.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem37
			' 
			Me.barItem37.CategoryIndex = 3
			Me.barItem37.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem37.ID = "Outdent"
			Me.barItem37.ImageIndex = 38
			Me.barItem37.ImageList = Me.imageList2
			Me.barItem37.Text = "Decrease Line Indent"
'			Me.barItem37.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' parentBarItem3
			' 
			Me.parentBarItem3.CategoryIndex = 0
			Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem3.ID = "Bookmarks"
			Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem20, Me.barItem21, Me.barItem22, Me.barItem23, Me.barItem24, Me.barItem25, Me.barItem26, Me.barItem27, Me.barItem28, Me.barItem29})
			Me.parentBarItem3.SeparatorIndices.AddRange(New Integer() { 2, 5, 7, 9})
			Me.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
			Me.parentBarItem3.Text = "Bookmarks"
			' 
			' barItem20
			' 
			Me.barItem20.CategoryIndex = 2
			Me.barItem20.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem20.ID = "ToggleBookmark"
			Me.barItem20.Text = "Toggle Bookmark"
'			Me.barItem20.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem21
			' 
			Me.barItem21.CategoryIndex = 2
			Me.barItem21.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem21.ID = "AddBookmark"
			Me.barItem21.ImageIndex = 1
			Me.barItem21.ImageList = Me.imageList2
			Me.barItem21.Text = "Enable Bookmark"
'			Me.barItem21.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem22
			' 
			Me.barItem22.CategoryIndex = 2
			Me.barItem22.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem22.ID = "PrevBookmarks"
			Me.barItem22.ImageIndex = 5
			Me.barItem22.ImageList = Me.imageList2
			Me.barItem22.Text = "Previous Bookmarks"
'			Me.barItem22.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem23
			' 
			Me.barItem23.CategoryIndex = 2
			Me.barItem23.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem23.ID = "NextBookmark"
			Me.barItem23.ImageIndex = 2
			Me.barItem23.ImageList = Me.imageList2
			Me.barItem23.Text = "Next Bookmark"
'			Me.barItem23.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem24
			' 
			Me.barItem24.CategoryIndex = 2
			Me.barItem24.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem24.ID = "ClearBookmark"
			Me.barItem24.ImageIndex = 8
			Me.barItem24.ImageList = Me.imageList2
			Me.barItem24.Text = "Clear Bookmarks"
'			Me.barItem24.Click += New System.EventHandler(Me.OnBarItemClick);
			' 
			' barItem25
			' 
			Me.barItem25.CategoryIndex = 2
			Me.barItem25.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem25.ID = "Previous Bookmark in Folder"
			Me.barItem25.ImageIndex = 7
			Me.barItem25.ImageList = Me.imageList2
			Me.barItem25.Text = "Previous Bookmark in Folder"
			' 
			' barItem26
			' 
			Me.barItem26.CategoryIndex = 2
			Me.barItem26.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem26.ID = "Next Bookmark in Folder"
			Me.barItem26.ImageIndex = 4
			Me.barItem26.ImageList = Me.imageList2
			Me.barItem26.Text = "Next Bookmark in Folder"
			' 
			' barItem27
			' 
			Me.barItem27.CategoryIndex = 2
			Me.barItem27.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem27.ID = "Previous Bookmark in Document"
			Me.barItem27.ImageIndex = 19
			Me.barItem27.ImageList = Me.imageList2
			Me.barItem27.Text = "Previous Bookmark in Document"
			' 
			' barItem28
			' 
			Me.barItem28.CategoryIndex = 2
			Me.barItem28.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem28.ID = "Next Bookmark in Document"
			Me.barItem28.ImageIndex = 20
			Me.barItem28.ImageList = Me.imageList2
			Me.barItem28.Text = "Next Bookmark in Document"
			' 
			' barItem29
			' 
			Me.barItem29.CategoryIndex = 2
			Me.barItem29.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem29.ID = "ClearAllBookmarks"
			Me.barItem29.Text = "Clear All Bookmarks"
			' 
			' FormatParentBarItem
			' 
			Me.FormatParentBarItem.CategoryIndex = 4
			Me.FormatParentBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormatParentBarItem.ID = "Format"
			Me.FormatParentBarItem.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.parentBarItem6, Me.parentBarItem7, Me.parentBarItem8, Me.parentBarItem9, Me.parentBarItem10, Me.parentBarItem11})
			Me.FormatParentBarItem.MergeOrder = 7
			Me.FormatParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Me.FormatParentBarItem.Text = "F&ormat"
			' 
			' parentBarItem6
			' 
			Me.parentBarItem6.CategoryIndex = 4
			Me.parentBarItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem6.ID = "Align"
			Me.parentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem54, Me.barItem55, Me.barItem56, Me.barItem57, Me.barItem59, Me.barItem58})
			Me.parentBarItem6.SeparatorIndices.AddRange(New Integer() { 3})
			Me.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Me.parentBarItem6.Text = "Align"
			' 
			' barItem54
			' 
			Me.barItem54.CategoryIndex = 5
			Me.barItem54.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem54.ID = "Left"
			Me.barItem54.ImageIndex = 15
			Me.barItem54.ImageList = Me.imageList1
			Me.barItem54.Text = "Left"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
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
			' barItem55
			' 
			Me.barItem55.CategoryIndex = 5
			Me.barItem55.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem55.ID = "Center"
			Me.barItem55.ImageIndex = 14
			Me.barItem55.ImageList = Me.imageList1
			Me.barItem55.Text = "Center"
			' 
			' barItem56
			' 
			Me.barItem56.CategoryIndex = 5
			Me.barItem56.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem56.ID = "Right"
			Me.barItem56.ImageIndex = 17
			Me.barItem56.ImageList = Me.imageList1
			Me.barItem56.Text = "Right"
			' 
			' barItem57
			' 
			Me.barItem57.CategoryIndex = 5
			Me.barItem57.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem57.ID = "Top"
			Me.barItem57.ImageIndex = 18
			Me.barItem57.ImageList = Me.imageList1
			Me.barItem57.Text = "Top"
			' 
			' barItem59
			' 
			Me.barItem59.CategoryIndex = 5
			Me.barItem59.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem59.ID = "Middle"
			Me.barItem59.ImageIndex = 16
			Me.barItem59.ImageList = Me.imageList1
			Me.barItem59.Text = "Middle"
			' 
			' barItem58
			' 
			Me.barItem58.CategoryIndex = 5
			Me.barItem58.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem58.ID = "Bottom"
			Me.barItem58.ImageIndex = 13
			Me.barItem58.ImageList = Me.imageList1
			Me.barItem58.Text = "Bottom"
			' 
			' parentBarItem7
			' 
			Me.parentBarItem7.CategoryIndex = 4
			Me.parentBarItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem7.ID = "Make Same Size"
			Me.parentBarItem7.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem50, Me.barItem51, Me.barItem52, Me.barItem53})
			Me.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Me.parentBarItem7.Text = "Make Same Size"
			' 
			' barItem50
			' 
			Me.barItem50.CategoryIndex = 6
			Me.barItem50.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem50.ID = "Width"
			Me.barItem50.ImageIndex = 36
			Me.barItem50.ImageList = Me.imageList1
			Me.barItem50.Text = "Width"
			' 
			' barItem51
			' 
			Me.barItem51.CategoryIndex = 6
			Me.barItem51.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem51.ID = "Height"
			Me.barItem51.ImageIndex = 25
			Me.barItem51.ImageList = Me.imageList1
			Me.barItem51.Text = "Height"
			' 
			' barItem52
			' 
			Me.barItem52.CategoryIndex = 6
			Me.barItem52.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem52.ID = "Both"
			Me.barItem52.ImageIndex = 20
			Me.barItem52.ImageList = Me.imageList1
			Me.barItem52.Text = "Both"
			' 
			' barItem53
			' 
			Me.barItem53.CategoryIndex = 6
			Me.barItem53.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem53.ID = "SizeToGrid"
			Me.barItem53.ImageIndex = 29
			Me.barItem53.ImageList = Me.imageList1
			Me.barItem53.Text = "SizeToGrid"
			' 
			' parentBarItem8
			' 
			Me.parentBarItem8.CategoryIndex = 4
			Me.parentBarItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem8.ID = "Horizontal Spacing"
			Me.parentBarItem8.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem46, Me.barItem47, Me.barItem48, Me.barItem49})
			Me.parentBarItem8.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Me.parentBarItem8.Text = "Horizontal Spacing"
			' 
			' barItem46
			' 
			Me.barItem46.CategoryIndex = 7
			Me.barItem46.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem46.ID = "Make Equal_1"
			Me.barItem46.ImageIndex = 16
			Me.barItem46.ImageList = Me.imageList1
			Me.barItem46.Text = "Make Equal"
			' 
			' barItem47
			' 
			Me.barItem47.CategoryIndex = 7
			Me.barItem47.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem47.ID = "Increase_1"
			Me.barItem47.ImageIndex = 23
			Me.barItem47.ImageList = Me.imageList1
			Me.barItem47.Text = "Increase"
			' 
			' barItem48
			' 
			Me.barItem48.CategoryIndex = 7
			Me.barItem48.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem48.ID = "Decrease_1"
			Me.barItem48.ImageIndex = 22
			Me.barItem48.ImageList = Me.imageList1
			Me.barItem48.Text = "Decrease"
			' 
			' barItem49
			' 
			Me.barItem49.CategoryIndex = 7
			Me.barItem49.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem49.ID = "Remove_1"
			Me.barItem49.ImageIndex = 24
			Me.barItem49.ImageList = Me.imageList1
			Me.barItem49.Text = "Remove"
			' 
			' parentBarItem9
			' 
			Me.parentBarItem9.CategoryIndex = 4
			Me.parentBarItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem9.ID = "Vertical Spacing"
			Me.parentBarItem9.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem42, Me.barItem43, Me.barItem44, Me.barItem45})
			Me.parentBarItem9.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Me.parentBarItem9.Text = "Vertical Spacing"
			' 
			' barItem42
			' 
			Me.barItem42.CategoryIndex = 8
			Me.barItem42.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem42.ID = "Make Equal"
			Me.barItem42.ImageIndex = 32
			Me.barItem42.ImageList = Me.imageList1
			Me.barItem42.Text = "Make Equal"
			' 
			' barItem43
			' 
			Me.barItem43.CategoryIndex = 8
			Me.barItem43.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem43.ID = "Increase"
			Me.barItem43.ImageIndex = 37
			Me.barItem43.ImageList = Me.imageList1
			Me.barItem43.Text = "Increase"
			' 
			' barItem44
			' 
			Me.barItem44.CategoryIndex = 8
			Me.barItem44.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem44.ID = "Decrease"
			Me.barItem44.ImageIndex = 31
			Me.barItem44.ImageList = Me.imageList1
			Me.barItem44.Text = "Decrease"
			' 
			' barItem45
			' 
			Me.barItem45.CategoryIndex = 8
			Me.barItem45.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem45.ID = "Remove"
			Me.barItem45.ImageIndex = 34
			Me.barItem45.ImageList = Me.imageList1
			Me.barItem45.Text = "Remove"
			' 
			' parentBarItem10
			' 
			Me.parentBarItem10.CategoryIndex = 4
			Me.parentBarItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem10.ID = "Center In Form"
			Me.parentBarItem10.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem40, Me.barItem41})
			Me.parentBarItem10.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Me.parentBarItem10.Text = "Center In Form"
			' 
			' barItem40
			' 
			Me.barItem40.CategoryIndex = 9
			Me.barItem40.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem40.ID = "Horizontally"
			Me.barItem40.ImageIndex = 26
			Me.barItem40.ImageList = Me.imageList1
			Me.barItem40.Text = "Horizontally"
			' 
			' barItem41
			' 
			Me.barItem41.CategoryIndex = 9
			Me.barItem41.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem41.ID = "Vertically"
			Me.barItem41.ImageIndex = 35
			Me.barItem41.ImageList = Me.imageList1
			Me.barItem41.Text = "Vertically"
			' 
			' parentBarItem11
			' 
			Me.parentBarItem11.CategoryIndex = 4
			Me.parentBarItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem11.ID = "Order"
			Me.parentBarItem11.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem38, Me.barItem39})
			Me.parentBarItem11.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Me.parentBarItem11.Text = "Order"
			' 
			' barItem38
			' 
			Me.barItem38.CategoryIndex = 10
			Me.barItem38.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem38.ID = "BringToFront"
			Me.barItem38.ImageIndex = 21
			Me.barItem38.ImageList = Me.imageList1
			Me.barItem38.Text = "BringToFront"
			' 
			' barItem39
			' 
			Me.barItem39.CategoryIndex = 10
			Me.barItem39.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem39.ID = "SendToBack"
			Me.barItem39.ImageIndex = 28
			Me.barItem39.ImageList = Me.imageList1
			Me.barItem39.Text = "SendToBack"
			' 
			' bar2
			' 
			Me.bar2.BarName = "Edit"
			Me.bar2.Caption = "childToolBar1"
			Me.bar2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem8, Me.barItem9, Me.barItem10, Me.barItem11, Me.barItem12, Me.barItem34, Me.barItem35, Me.barItem36, Me.barItem37, Me.barItem21, Me.barItem22, Me.barItem23, Me.barItem24, Me.barItem25, Me.barItem26, Me.barItem27, Me.barItem28})
			Me.bar2.Manager = Me.childMenuBar
			Me.bar2.MenuItemMergeOrder = 1
			Me.bar2.SeparatorIndices.AddRange(New Integer() { 5, 9})
			' 
			' bar4
			' 
			Me.bar4.BarName = "Format"
			Me.bar4.Caption = "childFormatBar"
			Me.bar4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem54, Me.barItem55, Me.barItem56, Me.barItem57, Me.barItem59, Me.barItem58, Me.barItem50, Me.barItem51, Me.barItem52, Me.barItem53, Me.barItem47, Me.barItem48, Me.barItem49, Me.barItem43, Me.barItem44, Me.barItem45, Me.barItem40, Me.barItem41, Me.barItem38, Me.barItem39})
			Me.bar4.Manager = Me.childMenuBar
			Me.bar4.MenuItemMergeOrder = 3
			Me.bar4.SeparatorIndices.AddRange(New Integer() { 6, 10, 13, 16, 18})
			' 
			' comboBoxBarItem1
			' 
			Me.comboBoxBarItem1.CategoryIndex = 1
			Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxBarItem1.ID = "_1"
			' 
			' parentBarItem1
			' 
			Me.parentBarItem1.CategoryIndex = 0
			Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.parentBarItem1.ID = "&Refactor"
			Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() { Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.barItem5, Me.barItem6, Me.barItem7})
			Me.parentBarItem1.MergeOrder = 3
			Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() { 1, 4})
			Me.parentBarItem1.Text = "&Refactor"
			' 
			' barItem1
			' 
			Me.barItem1.CategoryIndex = 0
			Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem1.ID = "Rename"
			Me.barItem1.Text = "Rename"
			' 
			' barItem2
			' 
			Me.barItem2.CategoryIndex = 0
			Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem2.ID = "Extract Method"
			Me.barItem2.Text = "Extract Method"
			' 
			' barItem3
			' 
			Me.barItem3.CategoryIndex = 0
			Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem3.ID = "Encapsulate Field"
			Me.barItem3.Text = "Encapsulate Field"
			' 
			' barItem4
			' 
			Me.barItem4.CategoryIndex = 0
			Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem4.ID = "Extract Interface"
			Me.barItem4.Text = "Extract Interface"
			' 
			' barItem5
			' 
			Me.barItem5.CategoryIndex = 0
			Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem5.ID = "Promote Local Variable to Parameter"
			Me.barItem5.Text = "Promote Local Variable to Parameter"
			' 
			' barItem6
			' 
			Me.barItem6.CategoryIndex = 0
			Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem6.ID = "Remove Parameters"
			Me.barItem6.Text = "Remove Parameters"
			' 
			' barItem7
			' 
			Me.barItem7.CategoryIndex = 0
			Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.barItem7.ID = "Reorder Parameters"
			Me.barItem7.Text = "Reorder Parameters"
			' 
			' largeImageList
			' 
			Me.largeImageList.ImageStream = (CType(resources.GetObject("largeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.largeImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.largeImageList.Images.SetKeyName(0, "")
			Me.largeImageList.Images.SetKeyName(1, "")
			Me.largeImageList.Images.SetKeyName(2, "")
			Me.largeImageList.Images.SetKeyName(3, "")
			Me.largeImageList.Images.SetKeyName(4, "")
			Me.largeImageList.Images.SetKeyName(5, "")
			Me.largeImageList.Images.SetKeyName(6, "")
			Me.largeImageList.Images.SetKeyName(7, "")
			Me.largeImageList.Images.SetKeyName(8, "")
			Me.largeImageList.Images.SetKeyName(9, "")
			Me.largeImageList.Images.SetKeyName(10, "")
			Me.largeImageList.Images.SetKeyName(11, "")
			Me.largeImageList.Images.SetKeyName(12, "")
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.comboBoxAdv2)
			Me.panel1.Controls.Add(Me.splitter1)
			Me.panel1.Controls.Add(Me.comboBoxAdv1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(776, 24)
			Me.panel1.TabIndex = 4
			' 
			' comboBoxAdv2
			' 
			Me.comboBoxAdv2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.comboBoxAdv2.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
			Me.comboBoxAdv2.IgnoreThemeBackground = True
			Me.comboBoxAdv2.ImageList = Me.imageList2
			Me.comboBoxAdv2.Location = New System.Drawing.Point(395, 0)
			Me.comboBoxAdv2.Name = "comboBoxAdv2"
			Me.comboBoxAdv2.ShowImageInTextBox = True
			Me.comboBoxAdv2.Size = New System.Drawing.Size(381, 24)
			Me.comboBoxAdv2.SuppressDropDownEvent = False
			Me.comboBoxAdv2.TabIndex = 2
			Me.comboBoxAdv2.Text = "Main(String[] args)"
			' 
			' splitter1
			' 
			Me.splitter1.Location = New System.Drawing.Point(392, 0)
			Me.splitter1.Name = "splitter1"
			Me.splitter1.Size = New System.Drawing.Size(3, 24)
			Me.splitter1.TabIndex = 1
			Me.splitter1.TabStop = False
			' 
			' comboBoxAdv1
			' 
			Me.comboBoxAdv1.Dock = System.Windows.Forms.DockStyle.Left
			Me.comboBoxAdv1.FlatStyle = Syncfusion.Windows.Forms.Tools.ComboFlatStyle.System
			Me.comboBoxAdv1.IgnoreThemeBackground = True
			Me.comboBoxAdv1.ImageList = Me.imageList2
			Me.comboBoxAdv1.Location = New System.Drawing.Point(0, 0)
			Me.comboBoxAdv1.Name = "comboBoxAdv1"
			Me.comboBoxAdv1.ShowImageInTextBox = True
			Me.comboBoxAdv1.Size = New System.Drawing.Size(392, 24)
			Me.comboBoxAdv1.SuppressDropDownEvent = False
			Me.comboBoxAdv1.TabIndex = 0
			Me.comboBoxAdv1.Text = "ConsoleApplication1.Program()"
			' 
			' CodeEditorBase
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.ClientSize = New System.Drawing.Size(776, 718)
			Me.Controls.Add(Me.editControl1)
			Me.Controls.Add(Me.panel1)
			Me.Font = New System.Drawing.Font("Calibri", 9.75F)
			Me.Name = "CodeEditorBase"
			Me.Text = "CodeEditorBase"
			CType(Me.editControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.childMenuBar, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "BarItem Click Event"
		Private Sub OnBarItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles barItem8.Click, barItem9.Click, barItem10.Click, barItem11.Click, barItem12.Click, barItem14.Click, barItem18.Click, barItem19.Click, barItem34.Click, barItem35.Click, barItem36.Click, barItem37.Click, barItem20.Click, barItem21.Click, barItem22.Click, barItem23.Click, barItem24.Click
			Dim item As BarItem = CType(IIf(TypeOf sender Is BarItem, sender, Nothing), BarItem)
			Try
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
			Catch e1 As Exception
				MessageBox.Show(e1.Message)
			End Try
		End Sub
		#End Region



	End Class
End Namespace
