Imports Microsoft.VisualBasic
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

Imports Syncfusion.Windows.Forms.Tools

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms

Namespace CommandBars

	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class DockedBarsForm
		Inherits System.Windows.Forms.Form
		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Public commandBarController1 As Syncfusion.Windows.Forms.Tools.CommandBarController
		Private mainMenu1 As System.Windows.Forms.MainMenu
		Private WithEvents fontComboBox As System.Windows.Forms.ComboBox
		Private WithEvents fontSizeComboBox As System.Windows.Forms.ComboBox
		Private boldButton As System.Windows.Forms.ToolBarButton
		Private italicButton As System.Windows.Forms.ToolBarButton
		Private underLineButton As System.Windows.Forms.ToolBarButton
		Private laButton As System.Windows.Forms.ToolBarButton
		Private centerButton As System.Windows.Forms.ToolBarButton
		Private raButton As System.Windows.Forms.ToolBarButton
		Private imageList1 As System.Windows.Forms.ImageList
		Private separator As System.Windows.Forms.ToolBarButton
		Private components As System.ComponentModel.IContainer
		Private menuItem8 As System.Windows.Forms.MenuItem
		Private WithEvents menuItem13 As System.Windows.Forms.MenuItem
		Private panel2 As System.Windows.Forms.Panel
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private toolBarButton1 As System.Windows.Forms.ToolBarButton
		Private toolBarButton2 As System.Windows.Forms.ToolBarButton
		Private toolBarButton3 As System.Windows.Forms.ToolBarButton
		Private toolBarButton5 As System.Windows.Forms.ToolBarButton
		Private toolBarButton6 As System.Windows.Forms.ToolBarButton
		Private toolBarButton7 As System.Windows.Forms.ToolBarButton
		Private panel3 As System.Windows.Forms.Panel
		Public WithEvents commandBarFonts As Syncfusion.Windows.Forms.Tools.CommandBar
		Private WithEvents tbFont As System.Windows.Forms.ToolBar
		Public WithEvents commandBarAlign As Syncfusion.Windows.Forms.Tools.CommandBar
		Private WithEvents tbAlign As System.Windows.Forms.ToolBar
		Public WithEvents commandBarStandard As Syncfusion.Windows.Forms.Tools.CommandBar
		Public commandBarAddress As Syncfusion.Windows.Forms.Tools.CommandBar
		Private WithEvents tbStandard As System.Windows.Forms.ToolBar
		Private toolBarButton8 As System.Windows.Forms.ToolBarButton
		Private pnlFonts As System.Windows.Forms.Panel
		Private pnlFontsTB As System.Windows.Forms.Panel
		Private initDone As Boolean = False

		Private WithEvents menuItemNew As System.Windows.Forms.MenuItem
		Private WithEvents menuItemOpen As System.Windows.Forms.MenuItem
		Private WithEvents menuItemCopy As System.Windows.Forms.MenuItem
		Private WithEvents menuItemCut As System.Windows.Forms.MenuItem
		Private WithEvents menuItemPaste As System.Windows.Forms.MenuItem
		Private WithEvents menuItemSave As System.Windows.Forms.MenuItem
		Private WithEvents menuItemExit As System.Windows.Forms.MenuItem
		Private WithEvents menuItemStandard As System.Windows.Forms.MenuItem
		Private WithEvents menuItemFonts As System.Windows.Forms.MenuItem
		Private WithEvents menuItemAlign As System.Windows.Forms.MenuItem
		Private WithEvents menuItemAddress As System.Windows.Forms.MenuItem
		Private WithEvents menuItemView As System.Windows.Forms.MenuItem
		Private menuItemFile As System.Windows.Forms.MenuItem
		Private menuItemEdit As System.Windows.Forms.MenuItem
		Private WithEvents menuItemHelp As System.Windows.Forms.MenuItem
		Private popupMenuAddress As Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu
		Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
		Private WithEvents biAddressHome As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents biAddressFAQ As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents biAddressSales As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
		Private WithEvents biAddressProducts As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem

		Private szFontToolBarPanel As Size
		Private statusBar1 As System.Windows.Forms.StatusBar
		Private xpTaskPane1 As Syncfusion.Windows.Forms.Tools.XPTaskPane
		Private wizardContainer1 As Syncfusion.Windows.Forms.Tools.WizardContainer
		Private xpTaskPage1 As Syncfusion.Windows.Forms.Tools.XPTaskPage
		Private label1 As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private label2 As System.Windows.Forms.Label
		Private xpTaskPage2 As Syncfusion.Windows.Forms.Tools.XPTaskPage
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents styleComboBox As System.Windows.Forms.ComboBox
		Private label3 As System.Windows.Forms.Label
		Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents AllowFloating As RadioButton
		Private WithEvents AllowDocking As RadioButton
		Private szFontCommandBarPanelSize As Size


		Public Sub New()
			' Cache the fully extended sizes of the toolbar and panel controls in the fonts CommandBar.
			' These sizes are used for calculating the toolbar dimensions in the CommandBar.CommandBarStateChanging 
			' and CommandBar.CommandBarStateChanged event handlers
			Me.szFontToolBarPanel = New Size(72, 23)
			Me.szFontCommandBarPanelSize = New Size(288, 24)

			'
			' Required for Windows Form Designer support.
			'
			InitializeComponent()
			Me.commandBarAddress.AllowedDockBorders = Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Top Or Syncfusion.Windows.Forms.Tools.CommandBarDockBorder.Bottom

'			#Region "Office2003Colors"
			Office2003Colors.UpdateMenuColors()
'		   #End Region
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DockedBarsForm))
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.commandBarController1 = New Syncfusion.Windows.Forms.Tools.CommandBarController(Me.components)
			Me.commandBarFonts = New Syncfusion.Windows.Forms.Tools.CommandBar()
			Me.pnlFonts = New System.Windows.Forms.Panel()
			Me.fontComboBox = New System.Windows.Forms.ComboBox()
			Me.fontSizeComboBox = New System.Windows.Forms.ComboBox()
			Me.pnlFontsTB = New System.Windows.Forms.Panel()
			Me.tbFont = New System.Windows.Forms.ToolBar()
			Me.boldButton = New System.Windows.Forms.ToolBarButton()
			Me.italicButton = New System.Windows.Forms.ToolBarButton()
			Me.underLineButton = New System.Windows.Forms.ToolBarButton()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.commandBarAlign = New Syncfusion.Windows.Forms.Tools.CommandBar()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.tbAlign = New System.Windows.Forms.ToolBar()
			Me.laButton = New System.Windows.Forms.ToolBarButton()
			Me.centerButton = New System.Windows.Forms.ToolBarButton()
			Me.raButton = New System.Windows.Forms.ToolBarButton()
			Me.commandBarStandard = New Syncfusion.Windows.Forms.Tools.CommandBar()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.tbStandard = New System.Windows.Forms.ToolBar()
			Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton2 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton3 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton5 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton6 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton7 = New System.Windows.Forms.ToolBarButton()
			Me.toolBarButton8 = New System.Windows.Forms.ToolBarButton()
			Me.commandBarAddress = New Syncfusion.Windows.Forms.Tools.CommandBar()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.popupMenuAddress = New Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(Me.components)
			Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem()
			Me.biAddressHome = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.biAddressFAQ = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.biAddressSales = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.biAddressProducts = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem()
			Me.separator = New System.Windows.Forms.ToolBarButton()
			Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
			Me.menuItemFile = New System.Windows.Forms.MenuItem()
			Me.menuItemNew = New System.Windows.Forms.MenuItem()
			Me.menuItemOpen = New System.Windows.Forms.MenuItem()
			Me.menuItemSave = New System.Windows.Forms.MenuItem()
			Me.menuItem8 = New System.Windows.Forms.MenuItem()
			Me.menuItemExit = New System.Windows.Forms.MenuItem()
			Me.menuItemEdit = New System.Windows.Forms.MenuItem()
			Me.menuItemCut = New System.Windows.Forms.MenuItem()
			Me.menuItemCopy = New System.Windows.Forms.MenuItem()
			Me.menuItemPaste = New System.Windows.Forms.MenuItem()
			Me.menuItemView = New System.Windows.Forms.MenuItem()
			Me.menuItemStandard = New System.Windows.Forms.MenuItem()
			Me.menuItemFonts = New System.Windows.Forms.MenuItem()
			Me.menuItemAlign = New System.Windows.Forms.MenuItem()
			Me.menuItemAddress = New System.Windows.Forms.MenuItem()
			Me.menuItemHelp = New System.Windows.Forms.MenuItem()
			Me.menuItem13 = New System.Windows.Forms.MenuItem()
			Me.statusBar1 = New System.Windows.Forms.StatusBar()
			Me.wizardContainer1 = New Syncfusion.Windows.Forms.Tools.WizardContainer()
			Me.AllowFloating = New System.Windows.Forms.RadioButton()
			Me.AllowDocking = New System.Windows.Forms.RadioButton()
			Me.checkBox2 = New System.Windows.Forms.CheckBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.styleComboBox = New System.Windows.Forms.ComboBox()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.commandBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.commandBarFonts.SuspendLayout()
			Me.pnlFonts.SuspendLayout()
			Me.pnlFontsTB.SuspendLayout()
			Me.commandBarAlign.SuspendLayout()
			Me.panel3.SuspendLayout()
			Me.commandBarStandard.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.commandBarAddress.SuspendLayout()
			Me.panel1.SuspendLayout()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richTextBox1
			' 
            Me.richTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.richTextBox1.BackColor = System.Drawing.SystemColors.Window
            Me.richTextBox1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.richTextBox1.ForeColor = System.Drawing.Color.SandyBrown
            Me.richTextBox1.HideSelection = False
            Me.richTextBox1.Location = New System.Drawing.Point(0, 54)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(352, 282)
            Me.richTextBox1.TabIndex = 0
            Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
            Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            '
            'commandBarController1
            '
            Me.commandBarController1.CommandBars.Add(Me.commandBarFonts)
            Me.commandBarController1.CommandBars.Add(Me.commandBarAlign)
            Me.commandBarController1.CommandBars.Add(Me.commandBarStandard)
            Me.commandBarController1.CommandBars.Add(Me.commandBarAddress)
            Me.commandBarController1.HostForm = Me
            Me.commandBarController1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'commandBarFonts
            '
            Me.commandBarFonts.ChevronColor = System.Drawing.SystemColors.ControlText
            Me.commandBarFonts.Controls.Add(Me.pnlFonts)
            Me.commandBarFonts.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top
            Me.commandBarFonts.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
            Me.commandBarFonts.HideDropDownButton = True
            Me.commandBarFonts.MaxLength = 300
            Me.commandBarFonts.MinHeight = 26
            Me.commandBarFonts.MinLength = 50
            Me.commandBarFonts.Name = "commandBarFonts"
            Me.commandBarFonts.RowIndex = 0
            Me.commandBarFonts.RowOffset = 169
            Me.commandBarFonts.ShowDockModeText = False
            Me.commandBarFonts.TabIndex = 0
            Me.commandBarFonts.TabStop = False
            Me.commandBarFonts.Text = "Fonts"
            '
            'pnlFonts
            '
            Me.pnlFonts.Controls.Add(Me.fontComboBox)
            Me.pnlFonts.Controls.Add(Me.fontSizeComboBox)
            Me.pnlFonts.Controls.Add(Me.pnlFontsTB)
            Me.pnlFonts.Location = New System.Drawing.Point(10, 1)
            Me.pnlFonts.Name = "pnlFonts"
            Me.pnlFonts.Size = New System.Drawing.Size(288, 24)
            Me.pnlFonts.TabIndex = 6
            '
            'fontComboBox
            '
            Me.fontComboBox.DisplayMember = "Name"
            Me.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.fontComboBox.Location = New System.Drawing.Point(0, 1)
            Me.fontComboBox.Name = "fontComboBox"
            Me.fontComboBox.Size = New System.Drawing.Size(144, 21)
            Me.fontComboBox.TabIndex = 5
            Me.fontComboBox.ValueMember = "Name"
            '
            'fontSizeComboBox
            '
            Me.fontSizeComboBox.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "15"})
            Me.fontSizeComboBox.Location = New System.Drawing.Point(148, 1)
            Me.fontSizeComboBox.Name = "fontSizeComboBox"
            Me.fontSizeComboBox.Size = New System.Drawing.Size(56, 21)
            Me.fontSizeComboBox.TabIndex = 4
            '
            'pnlFontsTB
            '
            Me.pnlFontsTB.Controls.Add(Me.tbFont)
            Me.pnlFontsTB.Location = New System.Drawing.Point(210, 0)
            Me.pnlFontsTB.Name = "pnlFontsTB"
            Me.pnlFontsTB.Size = New System.Drawing.Size(72, 23)
            Me.pnlFontsTB.TabIndex = 5
            '
            'tbFont
            '
            Me.tbFont.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
            Me.tbFont.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.boldButton, Me.italicButton, Me.underLineButton})
            Me.tbFont.Divider = False
            Me.tbFont.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbFont.DropDownArrows = True
            Me.tbFont.ImageList = Me.imageList1
            Me.tbFont.Location = New System.Drawing.Point(0, 0)
            Me.tbFont.Name = "tbFont"
            Me.tbFont.ShowToolTips = True
            Me.tbFont.Size = New System.Drawing.Size(72, 26)
            Me.tbFont.TabIndex = 4
            '
            'boldButton
            '
            Me.boldButton.ImageIndex = 3
            Me.boldButton.Name = "boldButton"
            Me.boldButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.boldButton.ToolTipText = "Bold"
            '
            'italicButton
            '
            Me.italicButton.ImageIndex = 4
            Me.italicButton.Name = "italicButton"
            Me.italicButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.italicButton.ToolTipText = "Italic"
            '
            'underLineButton
            '
            Me.underLineButton.ImageIndex = 5
            Me.underLineButton.Name = "underLineButton"
            Me.underLineButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.underLineButton.ToolTipText = "Underline"
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
            Me.imageList1.Images.SetKeyName(0, "")
            Me.imageList1.Images.SetKeyName(1, "")
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
            '
            'commandBarAlign
            '
            Me.commandBarAlign.ChevronColor = System.Drawing.SystemColors.ControlText
            Me.commandBarAlign.Controls.Add(Me.panel3)
            Me.commandBarAlign.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top
            Me.commandBarAlign.FloatModeWrapping = True
            Me.commandBarAlign.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
            Me.commandBarAlign.HideDropDownButton = True
            Me.commandBarAlign.MaxLength = 84
            Me.commandBarAlign.MinHeight = 26
            Me.commandBarAlign.MinLength = 50
            Me.commandBarAlign.Name = "commandBarAlign"
            Me.commandBarAlign.RowIndex = 1
            Me.commandBarAlign.RowOffset = 402
            Me.commandBarAlign.ShowDockModeText = False
            Me.commandBarAlign.TabIndex = 2
            Me.commandBarAlign.TabStop = False
            Me.commandBarAlign.Text = "Align"
            '
            'panel3
            '
            Me.panel3.Controls.Add(Me.tbAlign)
            Me.panel3.Location = New System.Drawing.Point(10, 1)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(72, 24)
            Me.panel3.TabIndex = 5
            '
            'tbAlign
            '
            Me.tbAlign.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
            Me.tbAlign.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.laButton, Me.centerButton, Me.raButton})
            Me.tbAlign.ButtonSize = New System.Drawing.Size(23, 22)
            Me.tbAlign.Divider = False
            Me.tbAlign.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbAlign.DropDownArrows = True
            Me.tbAlign.ImageList = Me.imageList1
            Me.tbAlign.Location = New System.Drawing.Point(0, 0)
            Me.tbAlign.Name = "tbAlign"
            Me.tbAlign.ShowToolTips = True
            Me.tbAlign.Size = New System.Drawing.Size(72, 26)
            Me.tbAlign.TabIndex = 4
            '
            'laButton
            '
            Me.laButton.ImageIndex = 1
            Me.laButton.Name = "laButton"
            Me.laButton.Pushed = True
            Me.laButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.laButton.ToolTipText = "Left Aligned"
            '
            'centerButton
            '
            Me.centerButton.ImageIndex = 0
            Me.centerButton.Name = "centerButton"
            Me.centerButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.centerButton.ToolTipText = "Center Aligned"
            '
            'raButton
            '
            Me.raButton.ImageIndex = 2
            Me.raButton.Name = "raButton"
            Me.raButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
            Me.raButton.ToolTipText = "Right Aligned"
            '
            'commandBarStandard
            '
            Me.commandBarStandard.ChevronColor = System.Drawing.SystemColors.ControlText
            Me.commandBarStandard.Controls.Add(Me.panel2)
            Me.commandBarStandard.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top
            Me.commandBarStandard.FloatModeWrapping = True
            Me.commandBarStandard.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
            Me.commandBarStandard.HideDropDownButton = True
            Me.commandBarStandard.MaxLength = 167
            Me.commandBarStandard.MinHeight = 26
            Me.commandBarStandard.MinLength = 50
            Me.commandBarStandard.Name = "commandBarStandard"
            Me.commandBarStandard.RowIndex = 0
            Me.commandBarStandard.RowOffset = 0
            Me.commandBarStandard.ShowDockModeText = False
            Me.commandBarStandard.TabIndex = 1
            Me.commandBarStandard.TabStop = False
            Me.commandBarStandard.Text = "Standard"
            '
            'panel2
            '
            Me.panel2.Controls.Add(Me.tbStandard)
            Me.panel2.Location = New System.Drawing.Point(10, 1)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(155, 24)
            Me.panel2.TabIndex = 5
            '
            'tbStandard
            '
            Me.tbStandard.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
            Me.tbStandard.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.toolBarButton1, Me.toolBarButton2, Me.toolBarButton3, Me.toolBarButton5, Me.toolBarButton6, Me.toolBarButton7, Me.toolBarButton8})
            Me.tbStandard.Divider = False
            Me.tbStandard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tbStandard.DropDownArrows = True
            Me.tbStandard.ImageList = Me.imageList1
            Me.tbStandard.Location = New System.Drawing.Point(0, 0)
            Me.tbStandard.Name = "tbStandard"
            Me.tbStandard.ShowToolTips = True
            Me.tbStandard.Size = New System.Drawing.Size(155, 26)
            Me.tbStandard.TabIndex = 4
            '
            'toolBarButton1
            '
            Me.toolBarButton1.ImageIndex = 6
            Me.toolBarButton1.Name = "toolBarButton1"
            Me.toolBarButton1.ToolTipText = "New"
            '
            'toolBarButton2
            '
            Me.toolBarButton2.ImageIndex = 7
            Me.toolBarButton2.Name = "toolBarButton2"
            Me.toolBarButton2.ToolTipText = "Open"
            '
            'toolBarButton3
            '
            Me.toolBarButton3.ImageIndex = 8
            Me.toolBarButton3.Name = "toolBarButton3"
            Me.toolBarButton3.ToolTipText = "Save"
            '
            'toolBarButton5
            '
            Me.toolBarButton5.Name = "toolBarButton5"
            Me.toolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            '
            'toolBarButton6
            '
            Me.toolBarButton6.ImageIndex = 10
            Me.toolBarButton6.Name = "toolBarButton6"
            Me.toolBarButton6.ToolTipText = "Cut"
            '
            'toolBarButton7
            '
            Me.toolBarButton7.ImageIndex = 11
            Me.toolBarButton7.Name = "toolBarButton7"
            Me.toolBarButton7.ToolTipText = "Copy"
            '
            'toolBarButton8
            '
            Me.toolBarButton8.ImageIndex = 12
            Me.toolBarButton8.Name = "toolBarButton8"
            Me.toolBarButton8.ToolTipText = "Paste"
            '
            'commandBarAddress
            '
            Me.commandBarAddress.ChevronColor = System.Drawing.SystemColors.ControlText
            Me.commandBarAddress.Controls.Add(Me.panel1)
            Me.commandBarAddress.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top
            Me.commandBarAddress.FloatModeWrapping = True
            Me.commandBarAddress.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, CType(0, Byte))
            Me.commandBarAddress.HideDropDownButton = True
            Me.commandBarAddress.MaxLength = 400
            Me.commandBarAddress.MinHeight = 26
            Me.commandBarAddress.MinLength = 50
            Me.commandBarAddress.Name = "commandBarAddress"
            Me.commandBarAddress.PopupMenu = Me.popupMenuAddress
            Me.commandBarAddress.RowIndex = 1
            Me.commandBarAddress.RowOffset = 0
            Me.commandBarAddress.TabIndex = 3
            Me.commandBarAddress.TabStop = False
            Me.commandBarAddress.Text = "Address"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Location = New System.Drawing.Point(55, 1)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(343, 24)
            Me.panel1.TabIndex = 0
            '
            'comboBox1
            '
            Me.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.comboBox1.Items.AddRange(New Object() {"www.syncfusion.com", "www.syncfusion.com/faq/winforms", "msdn.microsoft.com"})
            Me.comboBox1.Location = New System.Drawing.Point(0, 0)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(343, 21)
            Me.comboBox1.TabIndex = 4
            Me.comboBox1.Text = "www.syncfusion.com"
            '
            'popupMenuAddress
            '
            Me.popupMenuAddress.ParentBarItem = Me.parentBarItem1
            '
            'parentBarItem1
            '
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.biAddressHome, Me.biAddressFAQ, Me.biAddressSales, Me.biAddressProducts})
            Me.parentBarItem1.MetroColor = System.Drawing.Color.LightSkyBlue
            Me.parentBarItem1.ShowToolTipInPopUp = False
            Me.parentBarItem1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'biAddressHome
            '
            Me.biAddressHome.ID = "Syncfusion Home"
            Me.biAddressHome.ImageIndex = 13
            Me.biAddressHome.ImageList = Me.imageList1
            Me.biAddressHome.ShowToolTipInPopUp = False
            Me.biAddressHome.Text = "Syncfusion Home"
            '
            'biAddressFAQ
            '
            Me.biAddressFAQ.ID = "Windows Forms FAQ"
            Me.biAddressFAQ.ImageIndex = 13
            Me.biAddressFAQ.ImageList = Me.imageList1
            Me.biAddressFAQ.ShowToolTipInPopUp = False
            Me.biAddressFAQ.Text = "Windows Forms FAQ"
            '
            'biAddressSales
            '
            Me.biAddressSales.ID = "Syncfusion Sales"
            Me.biAddressSales.ImageIndex = 13
            Me.biAddressSales.ImageList = Me.imageList1
            Me.biAddressSales.ShowToolTipInPopUp = False
            Me.biAddressSales.Text = "Syncfusion Sales"
            '
            'biAddressProducts
            '
            Me.biAddressProducts.ID = "Syncfusion Products Page"
            Me.biAddressProducts.ImageIndex = 13
            Me.biAddressProducts.ImageList = Me.imageList1
            Me.biAddressProducts.ShowToolTipInPopUp = False
            Me.biAddressProducts.Text = "Syncfusion Products Page"
            '
            'separator
            '
            Me.separator.Name = "separator"
            Me.separator.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
            '
            'mainMenu1
            '
            Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemFile, Me.menuItemEdit, Me.menuItemView, Me.menuItemHelp})
            '
            'menuItemFile
            '
            Me.menuItemFile.Index = 0
            Me.menuItemFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemNew, Me.menuItemOpen, Me.menuItemSave, Me.menuItem8, Me.menuItemExit})
            Me.menuItemFile.Text = "&File"
            '
            'menuItemNew
            '
            Me.menuItemNew.Index = 0
            Me.menuItemNew.Text = "&New"
            '
            'menuItemOpen
            '
            Me.menuItemOpen.Index = 1
            Me.menuItemOpen.Text = "&Open"
            '
            'menuItemSave
            '
            Me.menuItemSave.Index = 2
            Me.menuItemSave.Text = "Save"
            '
            'menuItem8
            '
            Me.menuItem8.Index = 3
            Me.menuItem8.Text = "-"
            '
            'menuItemExit
            '
            Me.menuItemExit.Index = 4
            Me.menuItemExit.Text = "&Exit"
            '
            'menuItemEdit
            '
            Me.menuItemEdit.Index = 1
            Me.menuItemEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemCut, Me.menuItemCopy, Me.menuItemPaste})
            Me.menuItemEdit.Text = "&Edit"
            '
            'menuItemCut
            '
            Me.menuItemCut.Index = 0
            Me.menuItemCut.Text = "Cu&t"
            '
            'menuItemCopy
            '
            Me.menuItemCopy.Index = 1
            Me.menuItemCopy.Text = "&Copy"
            '
            'menuItemPaste
            '
            Me.menuItemPaste.Index = 2
            Me.menuItemPaste.Text = "&Paste"
            '
            'menuItemView
            '
            Me.menuItemView.Index = 2
            Me.menuItemView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemStandard, Me.menuItemFonts, Me.menuItemAlign, Me.menuItemAddress})
            Me.menuItemView.Text = "&View"
            '
            'menuItemStandard
            '
            Me.menuItemStandard.Index = 0
            Me.menuItemStandard.Text = "Standard"
            '
            'menuItemFonts
            '
            Me.menuItemFonts.Index = 1
            Me.menuItemFonts.Text = "Fonts"
            '
            'menuItemAlign
            '
            Me.menuItemAlign.Index = 2
            Me.menuItemAlign.Text = "Align"
            '
            'menuItemAddress
            '
            Me.menuItemAddress.Index = 3
            Me.menuItemAddress.Text = "Address"
            '
            'menuItemHelp
            '
            Me.menuItemHelp.Index = 3
            Me.menuItemHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem13})
            Me.menuItemHelp.Text = "&Help"
            '
            'menuItem13
            '
            Me.menuItem13.Index = 0
            Me.menuItem13.Text = "About &Syncfusion"
            '
            'statusBar1
            '
            Me.statusBar1.Location = New System.Drawing.Point(0, 337)
            Me.statusBar1.Name = "statusBar1"
            Me.statusBar1.Size = New System.Drawing.Size(544, 24)
            Me.statusBar1.TabIndex = 4
            Me.statusBar1.Text = "Ready"
            '
            'wizardContainer1
            '
            Me.wizardContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.wizardContainer1.Location = New System.Drawing.Point(0, 22)
            Me.wizardContainer1.Name = "wizardContainer1"
            Me.wizardContainer1.Size = New System.Drawing.Size(192, 263)
            Me.wizardContainer1.TabIndex = 3
            '
            'AllowFloating
            '
            Me.AllowFloating.AutoSize = True
            Me.AllowFloating.BackColor = System.Drawing.Color.Transparent
            Me.AllowFloating.Location = New System.Drawing.Point(16, 183)
            Me.AllowFloating.Name = "AllowFloating"
            Me.AllowFloating.Size = New System.Drawing.Size(90, 17)
            Me.AllowFloating.TabIndex = 13
            Me.AllowFloating.Text = "Allow Floating"
            Me.AllowFloating.UseVisualStyleBackColor = False
            '
            'AllowDocking
            '
            Me.AllowDocking.AutoSize = True
            Me.AllowDocking.BackColor = System.Drawing.Color.Transparent
            Me.AllowDocking.Checked = True
            Me.AllowDocking.Location = New System.Drawing.Point(16, 160)
            Me.AllowDocking.Name = "AllowDocking"
            Me.AllowDocking.Size = New System.Drawing.Size(93, 17)
            Me.AllowDocking.TabIndex = 12
            Me.AllowDocking.TabStop = True
            Me.AllowDocking.Text = "Allow Docking"
            Me.AllowDocking.UseVisualStyleBackColor = False
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.BackColor = System.Drawing.Color.Transparent
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.Location = New System.Drawing.Point(16, 137)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(144, 17)
            Me.checkBox2.TabIndex = 9
            Me.checkBox2.Text = "Show Drop Down Button"
            Me.checkBox2.UseVisualStyleBackColor = False
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.Location = New System.Drawing.Point(16, 62)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(30, 13)
            Me.label3.TabIndex = 8
            Me.label3.Text = "Style"
            '
            'styleComboBox
            '
            Me.styleComboBox.DisplayMember = "Name"
            Me.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.styleComboBox.Items.AddRange(New Object() {"Default", "OfficeXP", "Office2003"})
            Me.styleComboBox.Location = New System.Drawing.Point(16, 86)
            Me.styleComboBox.Name = "styleComboBox"
            Me.styleComboBox.Size = New System.Drawing.Size(160, 21)
            Me.styleComboBox.TabIndex = 7
            Me.styleComboBox.ValueMember = "Name"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.BackColor = System.Drawing.Color.Transparent
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Location = New System.Drawing.Point(16, 115)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(96, 17)
            Me.checkBox1.TabIndex = 0
            Me.checkBox1.Text = "Show Chevron"
            Me.checkBox1.UseVisualStyleBackColor = False
            '
            'pictureBox2
            '
            Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
            Me.pictureBox2.Location = New System.Drawing.Point(8, 160)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(16, 16)
            Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox2.TabIndex = 3
            Me.pictureBox2.TabStop = False
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Location = New System.Drawing.Point(32, 136)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(120, 96)
            Me.label2.TabIndex = 2
            Me.label2.Text = "The Essential Tools Menus Package uses the CommandBars framework for creating the" & _
                " XP menus and toolbars. "
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(8, 48)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(16, 16)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 1
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Location = New System.Drawing.Point(32, 24)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(120, 96)
            Me.label1.TabIndex = 0
            Me.label1.Text = "CommandBars implement the framework support that is required for creating Visual " & _
                "Studio.NET type dockable/floatable menus and toolbars."
            '
            'DockedBarsForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(544, 361)
            Me.Controls.Add(Me.richTextBox1)
            Me.Controls.Add(Me.statusBar1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Menu = Me.mainMenu1
            Me.Name = "DockedBarsForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Command Bars "
            CType(Me.commandBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.commandBarFonts.ResumeLayout(False)
            Me.pnlFonts.ResumeLayout(False)
            Me.pnlFontsTB.ResumeLayout(False)
            Me.pnlFontsTB.PerformLayout()
            Me.commandBarAlign.ResumeLayout(False)
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            Me.commandBarStandard.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.commandBarAddress.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			Application.Run(New DockedBarsForm())
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Me.fontComboBox.DisplayMember = "Name"
			Me.fontComboBox.ValueMember = "Name"
			Me.fontComboBox.Items.AddRange(FontFamily.Families)
			Me.fontComboBox.SelectedIndex = 2

			Me.fontSizeComboBox.SelectedIndex = 2
			Me.styleComboBox.Items.Clear()
			Me.styleComboBox.DataSource = System.Enum.GetNames(GetType(VisualStyle))
			'this.styleComboBox.SelectedIndex = 2;

			Me.initDone = True
			Me.UpdateFont()

			Me.xpTaskPane1 = New Syncfusion.Windows.Forms.Tools.XPTaskPane()
			Me.xpTaskPage2 = New Syncfusion.Windows.Forms.Tools.XPTaskPage()
			Me.xpTaskPage1 = New Syncfusion.Windows.Forms.Tools.XPTaskPage()
			' 
			' xpTaskPane1
			' 
			Me.xpTaskPane1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(243))))), (CInt(Fix((CByte(255))))))
			Me.xpTaskPane1.Controls.Add(Me.wizardContainer1)
			Me.xpTaskPane1.Dock = System.Windows.Forms.DockStyle.Right
			' 
			' xpTaskPage2
			' 
			Me.xpTaskPage2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(243))))), (CInt(Fix((CByte(255))))))
			Me.xpTaskPage2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(230)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(186))))), (CInt(Fix((CByte(186))))), (CInt(Fix((CByte(206)))))))
			Me.xpTaskPage2.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(99))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(206))))))
			Me.xpTaskPage2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xpTaskPage2.Controls.Add(Me.AllowFloating)
			Me.xpTaskPage2.Controls.Add(Me.AllowDocking)
			Me.xpTaskPage2.Controls.Add(Me.checkBox2)
			Me.xpTaskPage2.Controls.Add(Me.label3)
			Me.xpTaskPage2.Controls.Add(Me.styleComboBox)
			Me.xpTaskPage2.Controls.Add(Me.checkBox1)
			Me.xpTaskPage2.LayoutName = "Card1"
			Me.xpTaskPage2.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskPage2.Name = "xpTaskPage2"
			Me.xpTaskPage2.NextPage = Nothing
			Me.xpTaskPage2.PreviousPage = Nothing
			Me.xpTaskPage2.Size = New System.Drawing.Size(192, 263)
			Me.xpTaskPage2.TabIndex = 1
			Me.xpTaskPage2.Title = "Properties"

			' 
			' xpTaskPage1
			' 
			Me.xpTaskPage1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(243))))), (CInt(Fix((CByte(255))))))
			Me.xpTaskPage1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(218))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(236)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(186))))), (CInt(Fix((CByte(186))))), (CInt(Fix((CByte(206)))))))
			Me.xpTaskPage1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(99))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(206))))))
			Me.xpTaskPage1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xpTaskPage1.Controls.Add(Me.pictureBox2)
			Me.xpTaskPage1.Controls.Add(Me.label2)
			Me.xpTaskPage1.Controls.Add(Me.pictureBox1)
			Me.xpTaskPage1.Controls.Add(Me.label1)
			Me.xpTaskPage1.LayoutName = "Card2"
			Me.xpTaskPage1.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskPage1.Name = "xpTaskPage1"
			Me.xpTaskPage1.NextPage = Nothing
			Me.xpTaskPage1.PreviousPage = Nothing
			Me.xpTaskPage1.Size = New System.Drawing.Size(192, 263)
			Me.xpTaskPage1.TabIndex = 0
			Me.xpTaskPage1.Title = "Info"

			Me.xpTaskPane1.HeaderMenuItem.ImageIndex = 2
			Me.xpTaskPane1.HeaderMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.OfficeXP
			Me.xpTaskPane1.Location = New System.Drawing.Point(352, 52)
			Me.xpTaskPane1.Name = "xpTaskPane1"
			Me.xpTaskPane1.SelectedPage = Me.xpTaskPage2
			Me.xpTaskPane1.Size = New System.Drawing.Size(192, 285)
			Me.xpTaskPane1.TabIndex = 5
			Me.xpTaskPane1.TaskPages = New Syncfusion.Windows.Forms.Tools.XPTaskPage() { Me.xpTaskPage2, Me.xpTaskPage1}
			Me.xpTaskPane1.TaskPanePageContainer = Me.wizardContainer1
			Me.wizardContainer1.Controls.Add(Me.xpTaskPage2)
			Me.wizardContainer1.Controls.Add(Me.xpTaskPage1)
			Me.Controls.Add(Me.xpTaskPane1)

			Me.xpTaskPane1.Header.BackColor = Office2003Colors.MenuMarginColorDark
			Me.xpTaskPage1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.MenuMarginColorLight, Office2003Colors.MenuMarginColorDark)
			Me.xpTaskPage2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, Office2003Colors.MenuMarginColorLight, Office2003Colors.MenuMarginColorDark)

		End Sub

		Private curStyle As FontStyle = FontStyle.Regular
		Private curAlignment As HorizontalAlignment = HorizontalAlignment.Left
		Private Sub fontComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fontComboBox.SelectedIndexChanged, fontSizeComboBox.SelectedIndexChanged
			If Not Me.initDone Then
				Return
			End If

			Me.richTextBox1.Focus()
			Me.UpdateFont()
		End Sub

		Private Sub toolBar1_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbFont.ButtonClick, tbAlign.ButtonClick
			If Not Me.initDone Then
				Return
			End If

			'this.curStyle = FontStyle.Regular;
			If e.Button Is Me.boldButton Then
				If Me.boldButton.Pushed Then
					Me.curStyle = Me.curStyle Or FontStyle.Bold
				Else
					Me.curStyle -= FontStyle.Bold
				End If
			ElseIf e.Button Is Me.italicButton Then
				If Me.italicButton.Pushed Then
					Me.curStyle = Me.curStyle Or FontStyle.Italic
				Else
					Me.curStyle -= FontStyle.Italic
				End If
			ElseIf e.Button Is Me.underLineButton Then
				If Me.underLineButton.Pushed Then
					Me.curStyle = Me.curStyle Or FontStyle.Underline
				Else
					Me.curStyle -= FontStyle.Underline
				End If
			ElseIf e.Button Is Me.laButton Then
				If Me.laButton.Pushed Then
					Me.curAlignment = HorizontalAlignment.Left
					Me.centerButton.Pushed = False
					Me.raButton.Pushed = False
				End If
			ElseIf e.Button Is Me.centerButton Then
				If Me.centerButton.Pushed Then
					Me.curAlignment = HorizontalAlignment.Center
					Me.laButton.Pushed = False
					Me.raButton.Pushed = False
				End If
			ElseIf e.Button Is Me.raButton Then
				If Me.raButton.Pushed Then
					Me.curAlignment = HorizontalAlignment.Right
					Me.laButton.Pushed = False
					Me.centerButton.Pushed = False
				End If
			End If
			Me.richTextBox1.Focus()
			Me.UpdateFont()
		End Sub

		Private Sub UpdateFont()
			Try
				Dim family As String = Me.fontComboBox.SelectedItem.ToString()
				family = family.Substring(family.IndexOf("=") + 1, family.IndexOf("]") - family.IndexOf("=") - 1)
				Me.richTextBox1.SelectionFont = New Font(family, Int32.Parse(Me.fontSizeComboBox.Text), Me.curStyle)
				Me.richTextBox1.SelectionAlignment = Me.curAlignment
			Catch
			End Try
		End Sub

		Private Sub menuItemEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemCut.Click, menuItemCopy.Click, menuItemPaste.Click, menuItemHelp.Click
			Dim mnuitem As MenuItem = TryCast(sender, MenuItem)
			If mnuitem IsNot Nothing Then
				Me.HandleStandardCommands(mnuitem.Text)
			End If
		End Sub

		Private Sub menuItemFile_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemNew.Click, menuItemOpen.Click, menuItemSave.Click, menuItemExit.Click
			Dim mnuitem As MenuItem = TryCast(sender, MenuItem)
			If mnuitem IsNot Nothing Then
				Me.HandleStandardCommands(mnuitem.Text)
			End If
		End Sub

		Private Sub tbStandard_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles tbStandard.ButtonClick
			Me.HandleStandardCommands(e.Button.ToolTipText)
		End Sub

		Private Sub menuItemView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemStandard.Click, menuItemFonts.Click, menuItemAlign.Click, menuItemAddress.Click
			Dim mnuitem As MenuItem = TryCast(sender, MenuItem)
			Select Case mnuitem.Text
				Case "Address"
					Me.commandBarAddress.Visible = Not Me.menuItemAddress.Checked
				Case "Align"
					Me.commandBarAlign.Visible = Not Me.menuItemAlign.Checked
				Case "Fonts"
					Me.commandBarFonts.Visible = Not Me.menuItemFonts.Checked
				Case "Standard"
					Me.commandBarStandard.Visible = Not Me.menuItemStandard.Checked
			End Select
		End Sub

		Private Sub HandleStandardCommands(ByVal command As String)
			Dim nindex As Integer = command.IndexOf("&"c)
			If nindex >= 0 Then
				command = command.Remove(nindex, 1)
			End If
			Select Case command
				Case "New"
					Me.richTextBox1.Clear()
				Case "Open"
					Me.OpenDocument()
				Case "Save"
					Me.SaveDocument()
				Case "Exit"
					Me.Close()
				Case "Cut"
					Me.richTextBox1.Cut()
				Case "Copy"
					Me.richTextBox1.Copy()
				Case "Paste"
					Me.richTextBox1.Paste()
			End Select
		End Sub

		Private Sub OpenDocument()
			' Create an OpenFileDialog to request a file to open.
			Dim openFile1 As New OpenFileDialog()

			' Initialize the OpenFileDialog to look for RTF files.
			openFile1.DefaultExt = "*.rtf"
			openFile1.Filter = "RTF Files|*.rtf"

			' Determine whether the user selected a file from the OpenFileDialog.
			If openFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso openFile1.FileName.Length > 0 Then
				Me.richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText)
			End If
		End Sub

		Private Sub SaveDocument()
			' Create a SaveFileDialog to request a path and file name to save to.
			Dim saveFile1 As New SaveFileDialog()

			' Initialize the SaveFileDialog to specify the RTF extension for the file.
			saveFile1.DefaultExt = "*.rtf"
			saveFile1.Filter = "RTF Files|*.rtf"

			' Determine if the user selected a file name from the saveFileDialog.
			If saveFile1.ShowDialog() = System.Windows.Forms.DialogResult.OK AndAlso saveFile1.FileName.Length > 0 Then
				' Save the contents of the RichTextBox into the file.
				Me.richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText)
			End If
		End Sub

		Private Sub menuItemView_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemView.Popup
			Me.menuItemAddress.Checked = Me.commandBarAddress.Visible
			Me.menuItemAlign.Checked = Me.commandBarAlign.Visible
			Me.menuItemFonts.Checked = Me.commandBarFonts.Visible
			Me.menuItemStandard.Checked = Me.commandBarStandard.Visible
		End Sub

		' Handler for the CommandBar.CommandBarStateChanging event.
		Private Sub cbFonts_CommandBarStateChanging(ByVal obj As System.Object, ByVal arg As Syncfusion.Windows.Forms.Tools.CommandBarStateChangingEventArgs) Handles commandBarFonts.CommandBarStateChanging
			' If the fonts CommandBar is being docked to a vertical dock position, ie., left or right, 
			' then hide the two combo boxes and set the commandbar maxlength to be equal to 
			' the length of the fonts toolbar.
			' NOTE - The CommandBar's dockstate will be set to CommandBarDockState.None when the CommandBar 
			' is in an indeterminate state. This happens only during loading and deserialization.
			Dim currentborder As Syncfusion.Windows.Forms.Tools.CommandBarDockState = Me.commandBarFonts.DockState
			Dim newborder As Syncfusion.Windows.Forms.Tools.CommandBarDockState = arg.NewDockState
			If ((currentborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top) OrElse (currentborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Bottom) OrElse (currentborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float) OrElse (currentborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.None)) AndAlso ((newborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) OrElse (newborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right)) Then
				Me.fontComboBox.Visible = False
				Me.fontSizeComboBox.Visible = False
				Me.commandBarFonts.MaxLength = Me.commandBarFonts.CalcCommandBarMaxLength(Me.szFontToolBarPanel.Width)
				' Move the panel containing the fonts toolbar to the (0,0) position of the commandbar panel.
				Me.pnlFontsTB.Location = New Point(0, 0)
			End If
			' If the Fonts CommandBar is being redocked / floated from the left or right borders, then 
			' increase the max length and restore combo box visibility.
			If ((currentborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) OrElse (currentborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right)) AndAlso ((newborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top) OrElse (newborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Bottom) OrElse (newborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float) OrElse (newborder = Syncfusion.Windows.Forms.Tools.CommandBarDockState.None)) Then
				Me.commandBarFonts.MaxLength = Me.commandBarFonts.CalcCommandBarMaxLength(Me.szFontCommandBarPanelSize.Width)
				' Move the fonts toolbar panel to its original position ie., after the two combo boxes.
				Me.pnlFontsTB.Location = New Point(Me.fontSizeComboBox.Right + 6, 0)
				Me.fontComboBox.Visible = True
				Me.fontSizeComboBox.Visible = True
			End If
		End Sub

		' Handler for the CommandBar.CommandBarStateChanged event.
		Private Sub cbFonts_CommandBarStateChanging(ByVal sender As Object, ByVal e As System.EventArgs)
			' The Fonts CommandBar client dimensions may have been changed by the redocking. 
			' Size the panel containing the Fonts toolbar to fit the new CommandBar panel dimensions.
			If ((Me.commandBarFonts.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) OrElse (Me.commandBarFonts.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right)) AndAlso (Me.pnlFontsTB.Width > Me.commandBarFonts.Width) Then
				Me.pnlFontsTB.Size = Me.pnlFonts.Size
			Else
				' The CommandBar has been moved out of a left / right dock position.
				If Me.pnlFontsTB.Height > Me.commandBarFonts.Height Then
					Me.pnlFontsTB.Size = Me.szFontToolBarPanel
				End If
			End If
		End Sub

		Private Sub biAddress_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles biAddressHome.Click, biAddressFAQ.Click, biAddressSales.Click, biAddressProducts.Click
			Dim item As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem = TryCast(sender, Syncfusion.Windows.Forms.Tools.XPMenus.BarItem)
			Me.comboBox1.Text = TryCast(item.Tag, String)
		End Sub

		Private Sub commandBarStandard_Wrapping(ByVal obj As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventArgs) Handles commandBarStandard.CommandBarWrapping
			' Apply the wrapping algorithm only when the CommandBar is floating.
			If Me.commandBarStandard.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float Then
				' szmaxwrap represents the tbStandard toolbar's dimensions in the maximum wrapped state. 
				' szwinwrap represents the tbStandard toolbar's dimensions in the minimum wrapped state.
				' These dimensions are determined at design time.
				Dim szmaxwrap As New Size(40, 155)
				Dim szminwrap As New Size(150, 23)
				Me.DoToolBarWrapping(Me.tbStandard, szmaxwrap, szminwrap, arg)
			ElseIf (Me.commandBarStandard.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) OrElse (Me.commandBarStandard.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right) Then
				Dim szmaxwrap As New Size(24, 155)
				arg.ClientSize = szmaxwrap
			End If
		End Sub

		Private Sub commandBarAlign_CommandBarWrapping(ByVal obj As Object, ByVal arg As Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventArgs) Handles commandBarAlign.CommandBarWrapping
			' Apply the wrapping algorithm only when the CommandBar is floating.
			If Me.commandBarAlign.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Float Then
				Dim szmaxwrap As New Size(40, 67)
				Dim szminwrap As New Size(72, 23)
				Me.DoToolBarWrapping(Me.tbAlign, szmaxwrap, szminwrap, arg)
			ElseIf (Me.commandBarAlign.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Left) OrElse (Me.commandBarAlign.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Right) Then
				Dim szmaxwrap As New Size(24, 67)
				arg.ClientSize = szmaxwrap
			End If
		End Sub

		Private Sub DoToolBarWrapping(ByVal toolbar As ToolBar, ByVal szmaxwrap As Size, ByVal szminwrap As Size, ByVal arg As Syncfusion.Windows.Forms.Tools.CommandBarWrappingEventArgs)
			Dim szcurrent As Size = arg.ClientSize
			Dim sztemp As Size = toolbar.Size

			Dim nbtncount As Integer = toolbar.Buttons.Count
			Dim szbtn As Size = toolbar.ButtonSize

			If (arg.CommandBarResizeType = Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Right) OrElse (arg.CommandBarResizeType = Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Left) Then
				Dim nfactor As Integer = CInt(Fix(Math.Ceiling(CSng(szminwrap.Width) / CSng(szcurrent.Width))))
				Dim ffactor As Single = CSng(szminwrap.Width) / CSng(szcurrent.Width)

				If szcurrent.Width < szmaxwrap.Width Then
					arg.ClientSize = szmaxwrap
				ElseIf (nfactor > 1) AndAlso (nfactor = ffactor) Then
					Dim nnewwidth As Integer = CInt(Fix(Math.Ceiling(CSng(nbtncount) / CSng(nfactor)))) * szbtn.Width

					Dim sznew As Size = Size.Empty
					If nnewwidth > szmaxwrap.Width Then
						' Set this width to be the toolbar's parent panel width and allow the toolbar to 
						' layout itself for this width. We then get the toolbar's height and assign this as 
						' the CommandBar client size.
						sznew.Width = nnewwidth
						toolbar.Parent.Width = sznew.Width
						sznew.Height = toolbar.Height
						toolbar.Parent.Width = sztemp.Width
					Else
						sznew = szmaxwrap
					End If

					' Set the CommandBar's client size to be equal to this new size.
					arg.ClientSize = sznew
				ElseIf ffactor <= 1 Then
					' The CommandBar is extended to the maximum width.
					arg.ClientSize = szminwrap
				Else
					arg.ClientSize = toolbar.Size
				End If
			ElseIf (arg.CommandBarResizeType = Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Bottom) OrElse (arg.CommandBarResizeType = Syncfusion.Windows.Forms.Tools.CommandBarResizeType.Top) Then
				Dim nfactor As Integer = CInt(Fix(Math.Floor(CSng(szcurrent.Height) / CSng(szbtn.Height))))
				Dim ffactor As Single = CSng(szcurrent.Height) / CSng(szbtn.Height)

				If szcurrent.Height > szmaxwrap.Height Then
					arg.ClientSize = szmaxwrap
				ElseIf (nfactor > 1) AndAlso (nfactor = ffactor) Then
					' The toolbar width is estimated to be equal to the buttonwidth + the number of button columns reqd.
					Dim nnewwidth As Integer = CInt(Fix(Math.Ceiling(CSng(nbtncount) / CSng(nfactor)))) * szbtn.Width

					Dim sznew As Size = Size.Empty
					If nnewwidth > szmaxwrap.Width Then
						' Assign the new width to the toolbar parent panel and get the corresponding 
						' toolbar height.
						sznew.Width = nnewwidth
						toolbar.Parent.Width = sznew.Width
						sznew.Height = toolbar.Height
						toolbar.Parent.Width = sztemp.Width
					Else
						sznew = szmaxwrap
					End If

					' Set the CommandBar's client size to be equal to this new size.
					arg.ClientSize = sznew
				ElseIf ffactor <= 1 Then
					arg.ClientSize = szminwrap
				Else
					arg.ClientSize = toolbar.Size
				End If
			End If
		End Sub

		#Region "AboutForm_Logic"

		Private aboutForm As DemoCommon.AboutForm = Nothing
		Private Sub menuItem13_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem13.Click
			aboutForm = New DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies())
			aboutForm.ShowDialog()
		End Sub

		#End Region ' AboutForm_Logic

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
			For Each bar As CommandBar In Me.commandBarController1.CommandBars
				bar.HideChevron = Not Me.checkBox1.Checked
			Next bar
		End Sub

		Private Sub styleComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles styleComboBox.SelectedIndexChanged
			Dim vstyle As Syncfusion.Windows.Forms.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2003
			Try
				vstyle = CType(System.Enum.Parse(GetType(Syncfusion.Windows.Forms.VisualStyle), Me.styleComboBox.Text), Syncfusion.Windows.Forms.VisualStyle)
			Catch

			End Try
			Me.commandBarController1.Style = vstyle
			For Each bar As CommandBar In Me.commandBarController1.CommandBars
				bar.Refresh()
			Next bar

		End Sub

		Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
			For Each bar As CommandBar In Me.commandBarController1.CommandBars
				If bar.Name <> "commandBarStandard" Then
					bar.HideDropDownButton = Not Me.checkBox2.Checked
					Me.commandBarController1.RecalcLayout(bar)
				End If
			Next bar

		End Sub

		Private Sub AllowFloating_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles AllowFloating.CheckedChanged
            For Each bar As CommandBar In Me.commandBarController1.CommandBars
                If bar.Visible Then
                    bar.DisableDocking = Not Me.AllowDocking.Checked
                End If
            Next bar
		End Sub

		Private Sub AllowDocking_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles AllowDocking.CheckedChanged
			For Each bar As CommandBar In Me.commandBarController1.CommandBars
				bar.DisableFloating = Not Me.AllowFloating.Checked
			Next bar

		End Sub

'        
'        // This method is not used anywhere and is provided only to show how to 
'        // programmatically initialize the CommandBars.
'        // <samplecodeblock name="CommandBars">
'        private void InitializeCommandBars()
'        {	
'            // Create the CommandBarController.
'            this.commandBarController1 = new Syncfusion.Windows.Forms.Tools.CommandBarController();
'            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).BeginInit();
'
'            // Set the CommandBarController's host form.
'            this.commandBarController1.HostForm = this;
'            this.commandBarController1.PersistState = true;
'
'            // Create the CommandBar control.
'            this.commandBarAddress = new Syncfusion.Windows.Forms.Tools.CommandBar();
'
'            // Set the CommandBar Layout/Behavior/Appearance attributes.
'            this.commandBarAddress.DockBorder = Syncfusion.Windows.Forms.Tools.DockBorder.Top;
'            this.commandBarAddress.HideDropDownButton = true;
'            this.commandBarAddress.MaxLength = 400;
'            this.commandBarAddress.MinHeight = 26;
'            this.commandBarAddress.MinLength = 50;
'            this.commandBarAddress.Name = "commandBarAddress";
'            this.commandBarAddress.RowIndex = 1;
'            this.commandBarAddress.RowOffset = 1;
'            this.commandBarAddress.Text = "Address";
'
'            // Create the Combo Box control and add it to the CommandBar's Controls collection.
'            this.comboBox1 = new System.Windows.Forms.ComboBox();
'            this.commandBarAddress.Controls.AddRange(new System.Windows.Forms.Control[] {this.comboBox1});
'
'            // Add the CommandBar to the CommandBarController.CommandBars collection.
'            this.commandBarController1.CommandBars.Add(this.commandBarAddress);
'
'            ((System.ComponentModel.ISupportInitialize)(this.commandBarController1)).EndInit();
'        }
'        //</samplecodeblock>
'        

	End Class
End Namespace
