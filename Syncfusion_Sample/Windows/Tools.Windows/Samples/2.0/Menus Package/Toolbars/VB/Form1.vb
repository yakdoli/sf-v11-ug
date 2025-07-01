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
	Imports System.Collections
	Imports System.ComponentModel
	Imports System.Windows.Forms
	Imports System.Data
	Imports Syncfusion.Windows.Forms.Tools
	Imports Syncfusion.Windows.Forms.Tools.XPMenus
	Imports Syncfusion.Windows.Forms
Namespace XPToolbars_2005


	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Office2007Form
		#Region "Members"
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private xpToolBar1 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private imageList1 As System.Windows.Forms.ImageList
		Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private propertyGrid1 As System.Windows.Forms.PropertyGrid
		Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private copyItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private cutItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private pasteItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private undoItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private redoItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private fontColorItem As Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
		Private WithEvents aboutItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private xpToolBar2 As Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
		Private WithEvents barItem8 As BarItem

		Private panel1 As Panel
		Private dockingManager1 As DockingManager
		Private panel2 As Panel
		Private xpToolBar3 As XPToolBar
		Private barItem9 As BarItem
		Private comboBoxBarItem1 As ComboBoxBarItem
		Private WithEvents barItem10 As BarItem
		Private WithEvents barItem11 As BarItem
		Private WithEvents barItem12 As BarItem
		Private WithEvents barItem13 As BarItem
		Private WithEvents barItem14 As BarItem
		Private xpToolBar4 As XPToolBar
		Private WithEvents barItem15 As BarItem
		Private WithEvents barItem16 As BarItem
		Private WithEvents barItem17 As BarItem
		Private comboBoxBarItem2 As ComboBoxBarItem
		Private WithEvents barItem18 As BarItem
		Private parentBarItem3 As ParentBarItem
		Private dropDownBarItem1 As DropDownBarItem
		Private parentBarItem4 As ParentBarItem
		Private WithEvents barItem19 As BarItem
		Private parentBarItem5 As ParentBarItem
		Private WithEvents barItem20 As BarItem
		Private parentBarItem6 As ParentBarItem
		Private panel3 As Panel
		Private panel4 As Panel
		Private xpToolBar5 As XPToolBar
		Private groupBox1 As GroupBox
		Private gradientLabel4 As GradientLabel
		Private gradientLabel3 As GradientLabel
		Private WithEvents checkBoxAdv2 As CheckBoxAdv
		Private WithEvents comboBoxAdv2 As ComboBoxAdv
		Private WithEvents comboBoxAdv1 As ComboBoxAdv
		Private xpToolBar6 As XPToolBar
		Private WithEvents barItem21 As BarItem
		Private WithEvents barItem22 As BarItem
		Private WithEvents barItem23 As BarItem
		Private WithEvents barItem24 As BarItem
		Private WithEvents barItem25 As BarItem
		Private WithEvents barItem26 As BarItem
		Private WithEvents barItem27 As BarItem
		Private label13 As Label
		Private label26 As Label
		Private WithEvents barItem28 As BarItem
		Private WithEvents barItem29 As BarItem
		Private WithEvents barItem30 As BarItem
		Private WithEvents barItem31 As BarItem
		Private parentBarItem7 As ParentBarItem
		Private WithEvents barItem32 As BarItem
		Private dropDownBarItem2 As DropDownBarItem
		Private comboBoxBarItem3 As ComboBoxBarItem
		Private staticBarItem1 As StaticBarItem
		Private WithEvents barItem33 As BarItem
		Private WithEvents barItem34 As BarItem
		Private popupControlContainer2 As PopupControlContainer
		Private colorPickerUIAdv1 As ColorPickerUIAdv
		Private WithEvents barItem35 As BarItem
		Private WithEvents barItem36 As BarItem
		Private WithEvents barItem37 As BarItem
		Private components As System.ComponentModel.IContainer
		#End Region

		#Region "Form Load and Constructor"
		Public Sub New()
			InitializeComponent()
			Me.comboBoxAdv1.SelectedIndex = 3
			Me.comboBoxAdv2.SelectedIndex = 0
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.propertyGrid1.SelectedObject = Me.xpToolBar1
		End Sub
		#End Region

		#Region "Dispose"
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
		#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim ccbpanel1 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Dim ccbpanel2 As Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection = New Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection
            Me.dockingManager1 = New Syncfusion.Windows.Forms.Tools.DockingManager(Me.components)
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.panel1 = New System.Windows.Forms.Panel
            Me.xpToolBar4 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.barItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.panel2 = New System.Windows.Forms.Panel
            Me.xpToolBar3 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.comboBoxBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.copyItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.cutItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.pasteItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.undoItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.redoItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.fontColorItem = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.aboutItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.xpToolBar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.popupControlContainer2 = New Syncfusion.Windows.Forms.PopupControlContainer
            Me.colorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
            Me.xpToolBar2 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.comboBoxBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.barItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem33 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem34 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.dropDownBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem35 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem36 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem37 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.panel3 = New System.Windows.Forms.Panel
            Me.panel4 = New System.Windows.Forms.Panel
            Me.xpToolBar6 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.barItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem22 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem23 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem24 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem25 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem26 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem27 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.label13 = New System.Windows.Forms.Label
            Me.label26 = New System.Windows.Forms.Label
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv
            Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.gradientLabel4 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.gradientLabel3 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.xpToolBar5 = New Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar
            Me.barItem31 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem32 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.dropDownBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem
            Me.comboBoxBarItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.ComboBoxBarItem
            Me.staticBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.StaticBarItem
            Me.barItem28 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem29 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem30 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            Me.popupControlContainer2.SuspendLayout()
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel3.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxBarItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dockingManager1
            '
            Me.dockingManager1.DockLayoutStream = CType(resources.GetObject("dockingManager1.DockLayoutStream"), System.IO.MemoryStream)
            Me.dockingManager1.HostControl = Me
            Me.dockingManager1.ImageList = Me.imageList1
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Close, "CloseButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Pin, "PinButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Menu, "MenuButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Maximize, "MaximizeButton"))
            Me.dockingManager1.CaptionButtons.Add(New Syncfusion.Windows.Forms.Tools.CaptionButton(Syncfusion.Windows.Forms.Tools.CaptionButtonType.Restore, "RestoreButton"))
            Me.dockingManager1.SetDockLabel(Me.panel1, "Error List")
            ccbpanel1.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.panel1, ccbpanel1)
            Me.dockingManager1.SetDockLabel(Me.panel2, "Output (XPToolBar inside Dockable windows)")
            ccbpanel2.MergeWith(Me.dockingManager1.CaptionButtons, False)
            Me.dockingManager1.SetCustomCaptionButtons(Me.panel2, ccbpanel2)
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
            Me.imageList1.Images.SetKeyName(14, "document_out.png")
            Me.imageList1.Images.SetKeyName(15, "document_down.png")
            Me.imageList1.Images.SetKeyName(16, "document_up.png")
            Me.imageList1.Images.SetKeyName(17, "document_error.png")
            Me.imageList1.Images.SetKeyName(18, "window_preferences.png")
            Me.imageList1.Images.SetKeyName(19, "window.png")
            Me.imageList1.Images.SetKeyName(20, "window_delete.png")
            Me.imageList1.Images.SetKeyName(21, "delete.png")
            Me.imageList1.Images.SetKeyName(22, "warning.png")
            Me.imageList1.Images.SetKeyName(23, "about.png")
            Me.imageList1.Images.SetKeyName(24, "Office.ico")
            Me.imageList1.Images.SetKeyName(25, "book_red.png")
            Me.imageList1.Images.SetKeyName(26, "cubes.png")
            Me.imageList1.Images.SetKeyName(27, "star_blue.png")
            Me.imageList1.Images.SetKeyName(28, "document_stop.png")
            Me.imageList1.Images.SetKeyName(29, "checks.png")
            Me.imageList1.Images.SetKeyName(30, "document_edit.png")
            Me.imageList1.Images.SetKeyName(31, "document_into.png")
            Me.imageList1.Images.SetKeyName(32, "earth_find.png")
            Me.imageList1.Images.SetKeyName(33, "save_icon.png")
            Me.imageList1.Images.SetKeyName(34, "new_icon.png")
            Me.imageList1.Images.SetKeyName(35, "open_icon.png")
            Me.imageList1.Images.SetKeyName(36, "syncfusion.ico")
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.xpToolBar4)
            Me.dockingManager1.SetEnableDocking(Me.panel1, True)
            Me.panel1.Location = New System.Drawing.Point(1, 19)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(416, 52)
            Me.panel1.TabIndex = 5
            '
            'xpToolBar4
            '
            '
            '
            '
            Me.xpToolBar4.Bar.BarName = ""
            Me.xpToolBar4.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem15, Me.barItem16, Me.barItem17})
            Me.xpToolBar4.Bar.Manager = Nothing
            Me.xpToolBar4.Bar.SeparatorIndices.AddRange(New Integer() {1, 2})
            Me.xpToolBar4.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpToolBar4.Location = New System.Drawing.Point(0, 0)
            Me.xpToolBar4.Name = "xpToolBar4"
            Me.xpToolBar4.SeparatorIndices.AddRange(New Integer() {1, 2})
            Me.xpToolBar4.Size = New System.Drawing.Size(416, 25)
            Me.xpToolBar4.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
            Me.xpToolBar4.TabIndex = 0
            Me.xpToolBar4.Text = "xpToolBar4"
            '
            'barItem15
            '
            Me.barItem15.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem15.ID = "0 Errors"
            Me.barItem15.ImageIndex = 21
            Me.barItem15.ImageList = Me.imageList1
            Me.barItem15.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem15.Text = "0 Errors"
            '
            'barItem16
            '
            Me.barItem16.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem16.ID = "0 Warnings"
            Me.barItem16.ImageIndex = 22
            Me.barItem16.ImageList = Me.imageList1
            Me.barItem16.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem16.Text = "0 Warnings"
            '
            'barItem17
            '
            Me.barItem17.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem17.ID = "0 Messages"
            Me.barItem17.ImageIndex = 23
            Me.barItem17.ImageList = Me.imageList1
            Me.barItem17.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem17.Text = "0 Messages"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.xpToolBar3)
            Me.dockingManager1.SetEnableDocking(Me.panel2, True)
            Me.panel2.Location = New System.Drawing.Point(1, 19)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(416, 52)
            Me.panel2.TabIndex = 8
            '
            'xpToolBar3
            '
            '
            '
            '
            Me.xpToolBar3.Bar.BarName = ""
            Me.xpToolBar3.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem9, Me.comboBoxBarItem1, Me.barItem11, Me.barItem12, Me.barItem13, Me.barItem14})
            Me.xpToolBar3.Bar.Manager = Nothing
            Me.xpToolBar3.Bar.SeparatorIndices.AddRange(New Integer() {2, 3, 5})
            Me.xpToolBar3.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpToolBar3.Location = New System.Drawing.Point(0, 0)
            Me.xpToolBar3.Name = "xpToolBar3"
            Me.xpToolBar3.SeparatorIndices.AddRange(New Integer() {2, 3, 5})
            Me.xpToolBar3.Size = New System.Drawing.Size(416, 25)
            Me.xpToolBar3.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003
            Me.xpToolBar3.TabIndex = 0
            Me.xpToolBar3.Text = "xpToolBar3"
            '
            'barItem9
            '
            Me.barItem9.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem9.ID = "Show output from:"
            Me.barItem9.ImageList = Me.imageList1
            Me.barItem9.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem9.Text = "Show output from:"
            '
            'comboBoxBarItem1
            '
            Me.comboBoxBarItem1.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.comboBoxBarItem1.ID = "Debug"
            Me.comboBoxBarItem1.TextBoxValue = "Debug"
            '
            'barItem11
            '
            Me.barItem11.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem11.ImageIndex = 15
            Me.barItem11.ImageList = Me.imageList1
            '
            'barItem12
            '
            Me.barItem12.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem12.ImageIndex = 16
            Me.barItem12.ImageList = Me.imageList1
            '
            'barItem13
            '
            Me.barItem13.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem13.ImageIndex = 17
            Me.barItem13.ImageList = Me.imageList1
            '
            'barItem14
            '
            Me.barItem14.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem14.ImageIndex = 18
            Me.barItem14.ImageList = Me.imageList1
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.copyItem, Me.cutItem, Me.pasteItem, Me.undoItem, Me.redoItem, Me.fontColorItem, Me.aboutItem})
            Me.parentBarItem2.SeparatorIndices.AddRange(New Integer() {3, 5, 6})
            Me.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'copyItem
            '
            Me.copyItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.copyItem.ID = "&Copy"
            Me.copyItem.ImageIndex = 8
            Me.copyItem.ImageList = Me.imageList1
            Me.copyItem.Text = "&Copy"
            '
            'cutItem
            '
            Me.cutItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cutItem.ID = "Cu&t"
            Me.cutItem.ImageIndex = 9
            Me.cutItem.ImageList = Me.imageList1
            Me.cutItem.Text = "Cu&t"
            '
            'pasteItem
            '
            Me.pasteItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.pasteItem.ID = "&Paste"
            Me.pasteItem.ImageIndex = 8
            Me.pasteItem.ImageList = Me.imageList1
            Me.pasteItem.Text = "&Paste"
            '
            'undoItem
            '
            Me.undoItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.undoItem.ID = "&Undo"
            Me.undoItem.ImageIndex = 12
            Me.undoItem.ImageList = Me.imageList1
            Me.undoItem.Text = "&Undo"
            '
            'redoItem
            '
            Me.redoItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.redoItem.ID = "&Redo"
            Me.redoItem.ImageIndex = 13
            Me.redoItem.ImageList = Me.imageList1
            Me.redoItem.Text = "&Redo"
            '
            'fontColorItem
            '
            Me.fontColorItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.fontColorItem.ID = "Font Color"
            Me.fontColorItem.ImageIndex = 10
            Me.fontColorItem.ImageList = Me.imageList1
            Me.fontColorItem.Text = "Font Color"
            '
            'aboutItem
            '
            Me.aboutItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.aboutItem.ID = "&About Syncfusion"
            Me.aboutItem.ImageIndex = 14
            Me.aboutItem.ImageList = Me.imageList1
            Me.aboutItem.Text = "&About Syncfusion..."
            '
            'groupBox2
            '
            Me.groupBox2.BackColor = System.Drawing.Color.White
            Me.groupBox2.Controls.Add(Me.propertyGrid1)
            Me.groupBox2.Controls.Add(Me.xpToolBar1)
            Me.groupBox2.Controls.Add(Me.popupControlContainer2)
            Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Right
            Me.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.groupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.Location = New System.Drawing.Point(427, 25)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(233, 388)
            Me.groupBox2.TabIndex = 3
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "XPToolBar (Used outside the menus)"
            '
            'propertyGrid1
            '
            Me.propertyGrid1.CommandsBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.propertyGrid1.HelpVisible = False
            Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
            Me.propertyGrid1.Location = New System.Drawing.Point(3, 42)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(227, 343)
            Me.propertyGrid1.TabIndex = 1
            Me.propertyGrid1.ToolbarVisible = False
            '
            'xpToolBar1
            '
            Me.xpToolBar1.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.xpToolBar1.Bar.BarName = ""
            Me.xpToolBar1.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem2, Me.barItem1, Me.barItem3, Me.barItem5, Me.barItem4, Me.barItem6, Me.barItem7})
            Me.xpToolBar1.Bar.Manager = Nothing
            Me.xpToolBar1.Bar.SeparatorIndices.AddRange(New Integer() {2, 4, 5})
            Me.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpToolBar1.Font = New System.Drawing.Font("Calibri", 12.0!)
            Me.xpToolBar1.Location = New System.Drawing.Point(3, 17)
            Me.xpToolBar1.Name = "xpToolBar1"
            Me.xpToolBar1.SeparatorIndices.AddRange(New Integer() {2, 4, 5})
            Me.xpToolBar1.Size = New System.Drawing.Size(227, 25)
            Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.xpToolBar1.TabIndex = 0
            Me.xpToolBar1.Text = "xpToolBar1"
            '
            'barItem2
            '
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Calibri", 12.0!)
            Me.barItem2.ID = "Categorized"
            Me.barItem2.ImageIndex = 1
            Me.barItem2.ImageList = Me.imageList1
            Me.barItem2.Shortcut = System.Windows.Forms.Shortcut.Ctrl1
            Me.barItem2.Text = "Categorized"
            '
            'barItem1
            '
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Calibri", 12.0!)
            Me.barItem1.ID = "Alphabetic"
            Me.barItem1.ImageIndex = 0
            Me.barItem1.ImageList = Me.imageList1
            Me.barItem1.Shortcut = System.Windows.Forms.Shortcut.Ctrl2
            Me.barItem1.Text = "Alphabetic"
            '
            'barItem3
            '
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Calibri", 12.0!)
            Me.barItem3.ID = "Properties"
            Me.barItem3.ImageIndex = 2
            Me.barItem3.ImageList = Me.imageList1
            Me.barItem3.Shortcut = System.Windows.Forms.Shortcut.Ctrl3
            Me.barItem3.Text = "Properties"
            '
            'barItem5
            '
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Calibri", 12.0!)
            Me.barItem5.ID = "Events"
            Me.barItem5.ImageIndex = 4
            Me.barItem5.ImageList = Me.imageList1
            Me.barItem5.Shortcut = System.Windows.Forms.Shortcut.Ctrl4
            Me.barItem5.Text = "Events"
            '
            'barItem4
            '
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Calibri", 12.0!)
            Me.barItem4.ID = "Property Pages"
            Me.barItem4.ImageIndex = 3
            Me.barItem4.ImageList = Me.imageList1
            Me.barItem4.Shortcut = System.Windows.Forms.Shortcut.Ctrl5
            Me.barItem4.Text = "Show All"
            '
            'barItem6
            '
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Calibri", 12.0!)
            Me.barItem6.ID = "Run"
            Me.barItem6.ImageIndex = 5
            Me.barItem6.ImageList = Me.imageList1
            Me.barItem6.Shortcut = System.Windows.Forms.Shortcut.Ctrl6
            Me.barItem6.Text = "Run Button"
            '
            'barItem7
            '
            Me.barItem7.Checked = True
            Me.barItem7.CustomTextFont = New System.Drawing.Font("Calibri", 12.0!)
            Me.barItem7.ID = "Style"
            Me.barItem7.ImageIndex = 6
            Me.barItem7.ImageList = Me.imageList1
            Me.barItem7.Shortcut = System.Windows.Forms.Shortcut.Ctrl7
            Me.barItem7.Text = "Style Toggled"
            '
            'popupControlContainer2
            '
            Me.popupControlContainer2.Controls.Add(Me.colorPickerUIAdv1)
            Me.popupControlContainer2.Location = New System.Drawing.Point(6, 95)
            Me.popupControlContainer2.Name = "popupControlContainer2"
            Me.popupControlContainer2.Size = New System.Drawing.Size(144, 198)
            Me.popupControlContainer2.TabIndex = 3
            '
            'colorPickerUIAdv1.RecentGroup
            '
            Me.colorPickerUIAdv1.RecentGroup.Name = "RecentColors"
            Me.colorPickerUIAdv1.RecentGroup.Visible = False
            '
            'colorPickerUIAdv1.StandardGroup
            '
            Me.colorPickerUIAdv1.StandardGroup.Name = "StandardColors"
            '
            'colorPickerUIAdv1.ThemeGroup
            '
            Me.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
            Me.colorPickerUIAdv1.ThemeGroup.Name = "ThemeColors"
            '
            'colorPickerUIAdv1
            '
            Me.colorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(13, 13)
            Me.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.colorPickerUIAdv1.HorizontalItemsSpacing = 0
            Me.colorPickerUIAdv1.Location = New System.Drawing.Point(0, 0)
            Me.colorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 195)
            Me.colorPickerUIAdv1.Name = "colorPickerUIAdv1"
            Me.colorPickerUIAdv1.Size = New System.Drawing.Size(144, 198)
            Me.colorPickerUIAdv1.TabIndex = 0
            Me.colorPickerUIAdv1.Text = "colorPickerUIAdv1"
            '
            'xpToolBar2
            '
            '
            '
            '
            Me.xpToolBar2.Bar.BarName = ""
            Me.xpToolBar2.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem8, Me.comboBoxBarItem2, Me.barItem18, Me.parentBarItem3, Me.dropDownBarItem1, Me.parentBarItem4, Me.barItem19, Me.parentBarItem5, Me.barItem20, Me.parentBarItem6})
            Me.xpToolBar2.Bar.Manager = Nothing
            Me.xpToolBar2.Bar.SeparatorIndices.AddRange(New Integer() {3, 5, 7})
            Me.xpToolBar2.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpToolBar2.Location = New System.Drawing.Point(0, 0)
            Me.xpToolBar2.Name = "xpToolBar2"
            Me.xpToolBar2.SeparatorIndices.AddRange(New Integer() {3, 5, 7})
            Me.xpToolBar2.Size = New System.Drawing.Size(660, 25)
            Me.xpToolBar2.Style = Syncfusion.Windows.Forms.VisualStyle.[Default]
            Me.xpToolBar2.TabIndex = 4
            Me.xpToolBar2.Text = "xpToolBar2"
            '
            'barItem8
            '
            Me.barItem8.CustomActiveTextColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.barItem8.CustomNormalTextColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.barItem8.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem8.ID = "New"
            Me.barItem8.ImageIndex = 36
            Me.barItem8.ImageList = Me.imageList1
            Me.barItem8.ImageSize = New System.Drawing.Size(32, 32)
            Me.barItem8.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem8.Text = "Syncfusion "
            '
            'comboBoxBarItem2
            '
            Me.comboBoxBarItem2.ChoiceList.AddRange(New String() {"Http:", "www"})
            Me.comboBoxBarItem2.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.comboBoxBarItem2.ImageIndex = 24
            Me.comboBoxBarItem2.ImageList = Me.imageList1
            Me.comboBoxBarItem2.MinWidth = 60
            Me.comboBoxBarItem2.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            '
            'barItem18
            '
            Me.barItem18.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem18.ID = "Go"
            Me.barItem18.Text = "Go"
            '
            'parentBarItem3
            '
            Me.parentBarItem3.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.parentBarItem3.ImageIndex = 25
            Me.parentBarItem3.ImageList = Me.imageList1
            Me.parentBarItem3.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem33, Me.barItem34})
            Me.parentBarItem3.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            '
            'barItem33
            '
            Me.barItem33.ID = "Item1"
            Me.barItem33.Text = "Item1"
            '
            'barItem34
            '
            Me.barItem34.ID = "Item2"
            Me.barItem34.Text = "Item2"
            '
            'dropDownBarItem1
            '
            Me.dropDownBarItem1.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.dropDownBarItem1.ImageIndex = 26
            Me.dropDownBarItem1.ImageList = Me.imageList1
            Me.dropDownBarItem1.PopupControlContainer = Me.popupControlContainer2
            '
            'parentBarItem4
            '
            Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.parentBarItem4.ID = "BookMArks"
            Me.parentBarItem4.ImageIndex = 27
            Me.parentBarItem4.ImageList = Me.imageList1
            Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem35})
            Me.parentBarItem4.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.parentBarItem4.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem4.Text = "Bookmarks"
            '
            'barItem35
            '
            Me.barItem35.ID = "Item1"
            Me.barItem35.Text = "Item1"
            '
            'barItem19
            '
            Me.barItem19.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem19.ID = "12 Blocked"
            Me.barItem19.ImageIndex = 28
            Me.barItem19.ImageList = Me.imageList1
            Me.barItem19.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem19.Text = "14 Blocked"
            '
            'parentBarItem5
            '
            Me.parentBarItem5.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.parentBarItem5.ID = "Check"
            Me.parentBarItem5.ImageIndex = 29
            Me.parentBarItem5.ImageList = Me.imageList1
            Me.parentBarItem5.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem36})
            Me.parentBarItem5.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.parentBarItem5.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem5.Text = "Check"
            '
            'barItem36
            '
            Me.barItem36.ID = "Item1"
            Me.barItem36.Text = "Item"
            '
            'barItem20
            '
            Me.barItem20.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem20.ID = "Autofill"
            Me.barItem20.ImageIndex = 30
            Me.barItem20.ImageList = Me.imageList1
            Me.barItem20.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.barItem20.Text = "AutoFill"
            '
            'parentBarItem6
            '
            Me.parentBarItem6.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.parentBarItem6.ID = "SendTo"
            Me.parentBarItem6.ImageIndex = 31
            Me.parentBarItem6.ImageList = Me.imageList1
            Me.parentBarItem6.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem37})
            Me.parentBarItem6.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText
            Me.parentBarItem6.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem6.Text = "Send to"
            '
            'barItem37
            '
            Me.barItem37.ID = "Item"
            Me.barItem37.Text = "Item"
            '
            'barItem10
            '
            Me.barItem10.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.White
            Me.panel3.Controls.Add(Me.panel4)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel3.Location = New System.Drawing.Point(0, 25)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(427, 293)
            Me.panel3.TabIndex = 10
            '
            'panel4
            '
            Me.panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer))
            Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel4.Controls.Add(Me.xpToolBar6)
            Me.panel4.Controls.Add(Me.groupBox1)
            Me.panel4.Controls.Add(Me.xpToolBar5)
            Me.panel4.Location = New System.Drawing.Point(9, 8)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(410, 276)
            Me.panel4.TabIndex = 0
            '
            'xpToolBar6
            '
            Me.xpToolBar6.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.xpToolBar6.Bar.BarName = ""
            Me.xpToolBar6.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem21, Me.barItem22, Me.barItem23, Me.barItem24, Me.barItem25, Me.barItem26, Me.barItem27})
            Me.xpToolBar6.Bar.Manager = Nothing
            Me.xpToolBar6.Bar.SeparatorIndices.AddRange(New Integer() {3, 6})
            Me.xpToolBar6.Dock = System.Windows.Forms.DockStyle.Left
            Me.xpToolBar6.Location = New System.Drawing.Point(0, 25)
            Me.xpToolBar6.Name = "xpToolBar6"
            Me.xpToolBar6.SeparatorIndices.AddRange(New Integer() {3, 6})
            Me.xpToolBar6.ShowChevron = True
            Me.xpToolBar6.Size = New System.Drawing.Size(25, 249)
            Me.xpToolBar6.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.xpToolBar6.TabIndex = 2
            Me.xpToolBar6.Text = "xpToolBar6"
            '
            'barItem21
            '
            Me.barItem21.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem21.ImageIndex = 34
            Me.barItem21.ImageList = Me.imageList1
            '
            'barItem22
            '
            Me.barItem22.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem22.ImageIndex = 35
            Me.barItem22.ImageList = Me.imageList1
            '
            'barItem23
            '
            Me.barItem23.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem23.ImageIndex = 33
            Me.barItem23.ImageList = Me.imageList1
            '
            'barItem24
            '
            Me.barItem24.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem24.ImageIndex = 9
            Me.barItem24.ImageList = Me.imageList1
            '
            'barItem25
            '
            Me.barItem25.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem25.ImageIndex = 8
            Me.barItem25.ImageList = Me.imageList1
            '
            'barItem26
            '
            Me.barItem26.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem26.ImageIndex = 11
            Me.barItem26.ImageList = Me.imageList1
            '
            'barItem27
            '
            Me.barItem27.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem27.ImageIndex = 17
            Me.barItem27.ImageList = Me.imageList1
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label13)
            Me.groupBox1.Controls.Add(Me.label26)
            Me.groupBox1.Controls.Add(Me.comboBoxAdv2)
            Me.groupBox1.Controls.Add(Me.comboBoxAdv1)
            Me.groupBox1.Controls.Add(Me.checkBoxAdv2)
            Me.groupBox1.Controls.Add(Me.gradientLabel4)
            Me.groupBox1.Controls.Add(Me.gradientLabel3)
            Me.groupBox1.Location = New System.Drawing.Point(117, 60)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(202, 177)
            Me.groupBox1.TabIndex = 1
            Me.groupBox1.TabStop = False
            '
            'label13
            '
            Me.label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label13.Location = New System.Drawing.Point(13, 45)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(170, 1)
            Me.label13.TabIndex = 18
            '
            'label26
            '
            Me.label26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label26.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label26.Image = CType(resources.GetObject("label26.Image"), System.Drawing.Image)
            Me.label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label26.Location = New System.Drawing.Point(6, 17)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(154, 24)
            Me.label26.TabIndex = 17
            Me.label26.Text = "XPToolBar Appearance"
            Me.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'comboBoxAdv2
            '
            Me.comboBoxAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBoxAdv2.IgnoreThemeBackground = True
            Me.comboBoxAdv2.Items.AddRange(New Object() {"Blue", "Silver", "Black", "Managed"})
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Blue"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Silver"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Black"))
            Me.comboBoxAdv2.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv2, "Managed"))
            Me.comboBoxAdv2.Location = New System.Drawing.Point(100, 103)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(96, 23)
            Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv2.TabIndex = 15
            '
            'comboBoxAdv1
            '
            Me.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.comboBoxAdv1.IgnoreThemeBackground = True
            Me.comboBoxAdv1.Items.AddRange(New Object() {"Default", "Office2003", "VS2005", "Office2007"})
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Default"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Office2003"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "VS2005"))
            Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Office2007"))
            Me.comboBoxAdv1.Location = New System.Drawing.Point(100, 65)
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.Size = New System.Drawing.Size(96, 23)
            Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.comboBoxAdv1.TabIndex = 14
            '
            'checkBoxAdv2
            '
            Me.checkBoxAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv2.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv2.Location = New System.Drawing.Point(9, 140)
            Me.checkBoxAdv2.Name = "checkBoxAdv2"
            Me.checkBoxAdv2.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv2.Size = New System.Drawing.Size(151, 23)
            Me.checkBoxAdv2.TabIndex = 10
            Me.checkBoxAdv2.Text = "HighLightRectangle"
            Me.checkBoxAdv2.ThemesEnabled = False
            '
            'gradientLabel4
            '
            Me.gradientLabel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)))
            Me.gradientLabel4.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel4.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
            Me.gradientLabel4.Location = New System.Drawing.Point(9, 103)
            Me.gradientLabel4.Name = "gradientLabel4"
            Me.gradientLabel4.Size = New System.Drawing.Size(93, 19)
            Me.gradientLabel4.TabIndex = 3
            Me.gradientLabel4.Text = "ColorSchemes"
            Me.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'gradientLabel3
            '
            Me.gradientLabel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(253, Byte), Integer)))
            Me.gradientLabel3.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
            Me.gradientLabel3.Location = New System.Drawing.Point(9, 65)
            Me.gradientLabel3.Name = "gradientLabel3"
            Me.gradientLabel3.Size = New System.Drawing.Size(40, 19)
            Me.gradientLabel3.TabIndex = 2
            Me.gradientLabel3.Text = "Styles"
            Me.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'xpToolBar5
            '
            Me.xpToolBar5.BackColor = System.Drawing.Color.Transparent
            '
            '
            '
            Me.xpToolBar5.Bar.BarName = ""
            Me.xpToolBar5.Bar.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem31, Me.parentBarItem7, Me.dropDownBarItem2, Me.comboBoxBarItem3, Me.staticBarItem1})
            Me.xpToolBar5.Bar.Manager = Nothing
            Me.xpToolBar5.Dock = System.Windows.Forms.DockStyle.Top
            Me.xpToolBar5.Location = New System.Drawing.Point(0, 0)
            Me.xpToolBar5.Name = "xpToolBar5"
            Me.xpToolBar5.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.xpToolBar5.Size = New System.Drawing.Size(408, 25)
            Me.xpToolBar5.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            Me.xpToolBar5.TabIndex = 0
            Me.xpToolBar5.Text = "xpToolBar5"
            '
            'barItem31
            '
            Me.barItem31.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.barItem31.ID = "BarITem"
            Me.barItem31.Text = "BarItem"
            '
            'parentBarItem7
            '
            Me.parentBarItem7.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.parentBarItem7.ID = "ParentItem"
            Me.parentBarItem7.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem32})
            Me.parentBarItem7.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
            Me.parentBarItem7.Text = "ParentItem"
            '
            'barItem32
            '
            Me.barItem32.ID = "Item1"
            Me.barItem32.Text = "Item1"
            '
            'dropDownBarItem2
            '
            Me.dropDownBarItem2.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.dropDownBarItem2.ID = "DropDownItem"
            Me.dropDownBarItem2.PopupControlContainer = Me.popupControlContainer2
            Me.dropDownBarItem2.Text = "DropDownItem"
            '
            'comboBoxBarItem3
            '
            Me.comboBoxBarItem3.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.comboBoxBarItem3.ID = "ComboBox"
            Me.comboBoxBarItem3.Text = "ComboBox"
            '
            'staticBarItem1
            '
            Me.staticBarItem1.CustomTextFont = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
            Me.staticBarItem1.ID = "StaticItem"
            Me.staticBarItem1.Text = "StaticItem"
            '
            'barItem28
            '
            Me.barItem28.ID = "Item1"
            Me.barItem28.Text = "Item1"
            '
            'barItem29
            '
            Me.barItem29.ID = "Item2"
            Me.barItem29.Text = "Item2"
            '
            'barItem30
            '
            Me.barItem30.ID = "Item3"
            Me.barItem30.Text = "Item3"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(660, 413)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.xpToolBar2)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Toolbars "
            CType(Me.dockingManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            CType(Me.comboBoxBarItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            Me.popupControlContainer2.ResumeLayout(False)
            CType(Me.comboBoxBarItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel3.ResumeLayout(False)
            Me.panel4.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxBarItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		#Region "Main"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "Events"
		Private Sub barItem_Clicked(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem15.Click, barItem16.Click, barItem17.Click, barItem11.Click, barItem12.Click, barItem13.Click, barItem14.Click, barItem3.Click, barItem5.Click, barItem4.Click, barItem6.Click, barItem8.Click, barItem18.Click, barItem33.Click, barItem34.Click, barItem35.Click, barItem19.Click, barItem36.Click, barItem20.Click, barItem37.Click, barItem10.Click, barItem21.Click, barItem22.Click, barItem23.Click, barItem24.Click, barItem25.Click, barItem26.Click, barItem27.Click, barItem31.Click, barItem32.Click, barItem28.Click, barItem29.Click, barItem30.Click
			Dim item As BarItem = TryCast(sender, BarItem)
			MessageBox.Show(item.Text & " Clicked")
		End Sub


		Private Sub barItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem7.Click
			Me.barItem7.Checked = Not Me.barItem7.Checked
			If Me.barItem7.Checked Then
				Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Else
				Me.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Default
			End If
		End Sub
		Private Sub barItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem2.Click
			Me.propertyGrid1.PropertySort = PropertySort.Categorized
		End Sub

		Private Sub barItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles barItem1.Click
			Me.propertyGrid1.PropertySort = PropertySort.Alphabetical
		End Sub
		#End Region

		#Region "AboutForm_Logic"
		Private aboutForm As DemoCommon.AboutForm = Nothing
		Private Sub aboutItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles aboutItem.Click
			aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			aboutForm.ShowDialog()
		End Sub

		Private Sub AboutFormCloseBtnClicked(ByVal sender As Object, ByVal e As EventArgs)
			aboutForm.Close()
		End Sub
		#End Region

		#Region "Styles"
        Private Sub comboBoxAdv1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv1.SelectedIndexChanged
            Me.ColorScheme = Office2007Theme.Blue
            If Me.comboBoxAdv1.SelectedIndex = 0 Then
                Me.xpToolBar5.Style = VisualStyle.Default
                Me.xpToolBar6.Style = VisualStyle.Default
            End If
            If Me.comboBoxAdv1.SelectedIndex = 1 Then
                Me.xpToolBar5.Style = VisualStyle.Office2003
                Me.xpToolBar6.Style = VisualStyle.Office2003
            End If
            If Me.comboBoxAdv1.SelectedIndex = 2 Then
                Me.xpToolBar5.Style = VisualStyle.VS2005
                Me.xpToolBar6.Style = VisualStyle.VS2005
            End If
            If Me.comboBoxAdv1.SelectedIndex = 3 Then
                Me.xpToolBar5.Style = VisualStyle.Office2007
                Me.xpToolBar6.Style = VisualStyle.Office2007
                Me.ColorScheme = Me.xpToolBar5.Office2007Theme
            End If

        End Sub
		#End Region

		#Region "Office2007Theme"
		Private Sub comboBoxAdv2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxAdv2.SelectedIndexChanged
			Me.comboBoxAdv1.SelectedItem = "Office2007"
			Me.xpToolBar5.Style = VisualStyle.Office2007

			If Me.comboBoxAdv2.SelectedIndex = 0 Then
				Me.xpToolBar5.Office2007Theme = Office2007Theme.Blue
                Me.xpToolBar6.Office2007Theme = Office2007Theme.Blue
                Me.ColorScheme = Office2007Theme.Blue
			End If
			If Me.comboBoxAdv2.SelectedIndex = 1 Then
				Me.xpToolBar5.Office2007Theme = Office2007Theme.Silver
                Me.xpToolBar6.Office2007Theme = Office2007Theme.Silver
                Me.ColorScheme = Office2007Theme.Silver
			End If
			If Me.comboBoxAdv2.SelectedIndex = 2 Then
				Me.xpToolBar5.Office2007Theme = Office2007Theme.Black
                Me.xpToolBar6.Office2007Theme = Office2007Theme.Black
                Me.ColorScheme = Office2007Theme.Black
            End If
            If Me.comboBoxAdv2.SelectedIndex = 3 Then
                Me.xpToolBar5.Office2007Theme = Office2007Theme.Managed
                Me.xpToolBar6.Office2007Theme = Office2007Theme.Managed
                Me.ColorScheme = Office2007Theme.Managed
                Office2007Colors.ApplyManagedColors(Me, Color.Green)
            End If
		End Sub
		#End Region

		#Region "ShowHighLightRectangle"
		Private Sub checkBoxAdv2_CheckStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBoxAdv2.CheckStateChanged

			If Me.checkBoxAdv2.Checked Then
				Me.xpToolBar5.ShowHighlightRectangle = True
				Me.xpToolBar6.ShowHighlightRectangle = True
			Else
				Me.xpToolBar5.ShowHighlightRectangle = False
				Me.xpToolBar6.ShowHighlightRectangle = False
			End If
		End Sub
		#End Region

	End Class
End Namespace

