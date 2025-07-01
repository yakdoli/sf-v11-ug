Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace CustomColors_2005
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim toolStripGalleryItem1 As New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem()
			Dim toolStripGalleryItem2 As New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem()
			Dim toolStripGalleryItem3 As New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem()
			Dim toolStripGalleryItem4 As New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem()
			Dim toolStripGalleryItem5 As New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem()
			Dim toolStripGalleryItem6 As New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem()
			Dim toolStripGalleryItem7 As New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem()
			Dim toolStripGalleryItem8 As New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem()
			Dim toolStripGalleryItem9 As New Syncfusion.Windows.Forms.Tools.ToolStripGalleryItem()
			Dim treeNode1 As New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
			Dim treeNode2 As New System.Windows.Forms.TreeNode("Junk Email", 0, 0)
			Dim treeNode3 As New System.Windows.Forms.TreeNode("Inbox", 2, 2)
			Dim treeNode4 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode5 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode6 As New System.Windows.Forms.TreeNode("Personal Folders", 7, 7, New System.Windows.Forms.TreeNode() { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5})
			Dim treeNode7 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode8 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode9 As New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
			Dim treeNode10 As New System.Windows.Forms.TreeNode("Archive Folders", 8, 8, New System.Windows.Forms.TreeNode() { treeNode7, treeNode8, treeNode9})
			Dim treeNode11 As New System.Windows.Forms.TreeNode("Drafts", 5, 5)
			Dim treeNode12 As New System.Windows.Forms.TreeNode("Inbox", 2, 2)
			Dim treeNode13 As New System.Windows.Forms.TreeNode("Outbox", 3, 3)
			Dim treeNode14 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode15 As New System.Windows.Forms.TreeNode("Public")
			Dim treeNode16 As New System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, New System.Windows.Forms.TreeNode() { treeNode11, treeNode12, treeNode13, treeNode14, treeNode15})
			Me.ribbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
			Me.toolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.clipboardToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem15 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripBtnPaste = New System.Windows.Forms.ToolStripButton()
			Me.toolStripDropDownBtnPaste = New System.Windows.Forms.ToolStripDropDownButton()
			Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.pasteSpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.pasteAsHyperlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripBtnCut = New System.Windows.Forms.ToolStripButton()
			Me.toolStripBtnCopy = New System.Windows.Forms.ToolStripButton()
			Me.toolStripBtnPaint = New System.Windows.Forms.ToolStripButton()
			Me.fontToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripPanelItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripPanelItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripFontfaceComboBox = New System.Windows.Forms.ToolStripComboBox()
			Me.toolStripFontSizeComboBox = New System.Windows.Forms.ToolStripComboBox()
			Me.toolStripPanelItem5 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.toolStripPanelItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.boldToolstripBtn = New System.Windows.Forms.ToolStripButton()
			Me.italicToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.underlineToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton()
			Me.strikethroToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.toolStripPanelItem6 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
			Me.txthighltToolStripsplitBtn = New System.Windows.Forms.ToolStripSplitButton()
			Me.fontcolorToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton()
			Me.paragraphToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.lAlignToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.centerToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.rAlignToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.justifyToolStripBtn = New System.Windows.Forms.ToolStripButton()
			Me.lspacingToolStripDropDwnBtn = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
			Me.moreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
			Me.addSpaceBeforeParagraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.removeSpaceAfterParagraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.shadingToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton()
			Me.noColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
			Me.moreShadingColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.btmborderToolStripSplitBtn = New System.Windows.Forms.ToolStripSplitButton()
			Me.bottomBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.topBoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.leftBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.rightBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.noBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.allBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.outsideBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.insideBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.insideHorizontalBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.insideVerticalBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.diagonalDownBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.diagonalUpBorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.horizontalLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
			Me.showGridlinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.bordersAndShadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.stylesToolStripExt = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripGallery1 = New Syncfusion.Windows.Forms.Tools.ToolStripGallery()
			Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
			Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
			Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
			Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton()
			Me.tabBarSplitterControl1 = New Syncfusion.Windows.Forms.TabBarSplitterControl()
			Me.tabBarPage1 = New Syncfusion.Windows.Forms.TabBarPage()
			Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
			Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.colorPickerUIAdv1 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv()
			Me.statusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx()
			Me.toolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
			Me.trackBarItem1 = New Syncfusion.Windows.Forms.Tools.TrackBarItem()
			Me.statusStripLabel1 = New Syncfusion.Windows.Forms.Tools.StatusStripLabel()
			Me.changeListLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.defineNewBulletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.changeListLevelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.defineNewNumberFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.setNumberingValueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.changeListLevelToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
			Me.defineNewMultilevelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.defineNewListStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.moreUnderlinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.underlineColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.automaticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.moreColorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.noColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
			Me.stopHighlightingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.automaticToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.themeColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.moreColorsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
			Me.groupBar1 = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.monthCalendarAdv1 = New Syncfusion.Windows.Forms.Tools.MonthCalendarAdv()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.radioButtonAdv1 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
			Me.radioButtonAdv2 = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.xpTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.treeView3 = New System.Windows.Forms.TreeView()
			Me.smallImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.groupBarItem1 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem2 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.dateTimePickerAdv1 = New Syncfusion.Windows.Forms.Tools.DateTimePickerAdv()
			Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.linkLabel13 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel14 = New System.Windows.Forms.LinkLabel()

			Me.wizardContainer1 = New Syncfusion.Windows.Forms.Tools.WizardContainer()
			Me.xpTaskPage1 = New Syncfusion.Windows.Forms.Tools.XPTaskPage()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.label3 = New System.Windows.Forms.Label()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.buttonEdit1 = New Syncfusion.Windows.Forms.Tools.ButtonEdit()
			Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.buttonEditChildButton2 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton()
			Me.multiColumnComboBox1 = New Syncfusion.Windows.Forms.Tools.MultiColumnComboBox()
			Me.textBoxExt2 = New Syncfusion.Windows.Forms.Tools.TextBoxExt()
			Me.comboBoxBase1 = New Syncfusion.Windows.Forms.Tools.ComboBoxBase()
			Me.buttonAdv6 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.label31 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.linkLabel15 = New System.Windows.Forms.LinkLabel()
			Me.linkLabel16 = New System.Windows.Forms.LinkLabel()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label10 = New System.Windows.Forms.Label()
			Me.xpTaskPage2 = New Syncfusion.Windows.Forms.Tools.XPTaskPage()
			Me.fontListBox1 = New Syncfusion.Windows.Forms.Tools.FontListBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.fontComboBox1 = New Syncfusion.Windows.Forms.Tools.FontComboBox()
			Me.label32 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.xpTaskPage3 = New Syncfusion.Windows.Forms.Tools.XPTaskPage()
			Me.calculatorControl1 = New Syncfusion.Windows.Forms.Tools.CalculatorControl()
			Me.scrollersFrame1 = New Syncfusion.Windows.Forms.ScrollersFrame(Me.components)
			CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ribbonControlAdv1.SuspendLayout()
			Me.toolStripTabItem1.Panel.SuspendLayout()
			Me.clipboardToolStripExt.SuspendLayout()
			Me.fontToolStripExt.SuspendLayout()
			Me.paragraphToolStripExt.SuspendLayout()
			Me.stylesToolStripExt.SuspendLayout()
			Me.toolStripEx1.SuspendLayout()
			Me.toolStripEx2.SuspendLayout()
			Me.tabBarSplitterControl1.SuspendLayout()
			Me.tabBarPage1.SuspendLayout()
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel3.SuspendLayout()
			Me.statusStripEx1.SuspendLayout()
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBar1.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.monthCalendarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel3.SuspendLayout()
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar1.SuspendLayout()
			Me.xpTaskBarBox2.SuspendLayout()
			Me.panel1.SuspendLayout()
			CType(Me.dateTimePickerAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dateTimePickerAdv1.Calendar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel2.SuspendLayout()
			Me.wizardContainer1.SuspendLayout()
			CType(Me.xpTaskPage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskPage1.SuspendLayout()
			Me.panel4.SuspendLayout()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.buttonEdit1.SuspendLayout()
			CType(Me.multiColumnComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpTaskPage2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskPage2.SuspendLayout()
			CType(Me.xpTaskPage3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskPage3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' ribbonControlAdv1
			' 
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1)
			Me.ribbonControlAdv1.Header.AddQuickItem(New Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton1))
			Me.ribbonControlAdv1.Location = New System.Drawing.Point(1, 0)
			Me.ribbonControlAdv1.MenuButtonImage = (CType(resources.GetObject("ribbonControlAdv1.MenuButtonImage"), System.Drawing.Image))
			Me.ribbonControlAdv1.Name = "ribbonControlAdv1"
			' 
			' ribbonControlAdv1.OfficeMenu
			' 
			Me.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLabel1, Me.toolStripSeparator5, Me.toolStripButton5})
			Me.ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton2, Me.toolStripButton3, Me.toolStripButton4})
			Me.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
			Me.ribbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(197, 166)
			Me.ribbonControlAdv1.OfficeMenu.SystemPanel.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton6})
			Me.ribbonControlAdv1.Size = New System.Drawing.Size(879, 156)
			Me.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
			Me.ribbonControlAdv1.TabIndex = 0
			Me.ribbonControlAdv1.Text = "ribbonControlAdv1"
'			Me.ribbonControlAdv1.Click += New System.EventHandler(Me.ribbonControlAdv1_Click)
			' 
			' toolStripTabItem1
			' 
			Me.toolStripTabItem1.Name = "toolStripTabItem1"
			Me.toolStripTabItem1.Padding = New System.Windows.Forms.Padding(15, 2, 3, 5)
			' 
			' ribbonControlAdv1.ribbonPanel1
			' 
			Me.toolStripTabItem1.Panel.Controls.Add(Me.clipboardToolStripExt)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.fontToolStripExt)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.paragraphToolStripExt)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.stylesToolStripExt)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx1)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx2)
			Me.toolStripTabItem1.Panel.Name = "ribbonPanel1"
			Me.toolStripTabItem1.Panel.ScrollPosition = 0
			Me.toolStripTabItem1.Panel.TabIndex = 2
			Me.toolStripTabItem1.Panel.Text = "Home"
			Me.toolStripTabItem1.Size = New System.Drawing.Size(57, 24)
			Me.toolStripTabItem1.Text = "Home"
			' 
			' clipboardToolStripExt
			' 
			Me.clipboardToolStripExt.CollapsedDropDownButtonText = "Clipboard"
			Me.clipboardToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.clipboardToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.clipboardToolStripExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.clipboardToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.clipboardToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.clipboardToolStripExt.Image = (CType(resources.GetObject("clipboardToolStripExt.Image"), System.Drawing.Image))
			Me.clipboardToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem15, Me.toolStripPanelItem1})
			Me.clipboardToolStripExt.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
			Me.clipboardToolStripExt.Location = New System.Drawing.Point(0, 1)
			Me.clipboardToolStripExt.Name = "clipboardToolStripExt"
			Me.clipboardToolStripExt.Size = New System.Drawing.Size(80, 91)
			Me.clipboardToolStripExt.TabIndex = 5
			Me.clipboardToolStripExt.Text = "Clipboard"
			' 
			' toolStripPanelItem15
			' 
			Me.toolStripPanelItem15.CausesValidation = False
			Me.toolStripPanelItem15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripPanelItem15.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem15.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripBtnPaste, Me.toolStripDropDownBtnPaste})
			Me.toolStripPanelItem15.Name = "toolStripPanelItem15"
			Me.toolStripPanelItem15.Size = New System.Drawing.Size(42, 73)
			Me.toolStripPanelItem15.Text = "toolStripPanelItem15"
			Me.toolStripPanelItem15.Transparent = True
			' 
			' toolStripBtnPaste
			' 
			Me.toolStripBtnPaste.AutoToolTip = False
			Me.toolStripBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripBtnPaste.Image = (CType(resources.GetObject("toolStripBtnPaste.Image"), System.Drawing.Image))
			Me.toolStripBtnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripBtnPaste.Name = "toolStripBtnPaste"
			Me.toolStripBtnPaste.Size = New System.Drawing.Size(36, 36)
			Me.toolStripBtnPaste.Text = "toolStripButton39"
			' 
			' toolStripDropDownBtnPaste
			' 
			Me.toolStripDropDownBtnPaste.AutoToolTip = False
			Me.toolStripDropDownBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripDropDownBtnPaste.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.pasteToolStripMenuItem, Me.pasteSpecialToolStripMenuItem, Me.pasteAsHyperlinkToolStripMenuItem})
			Me.toolStripDropDownBtnPaste.Image = (CType(resources.GetObject("toolStripDropDownBtnPaste.Image"), System.Drawing.Image))
			Me.toolStripDropDownBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownBtnPaste.Name = "toolStripDropDownBtnPaste"
			Me.SetShortcut(Me.toolStripDropDownBtnPaste, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)))
			Me.toolStripDropDownBtnPaste.ShowDropDownArrow = False
			Me.toolStripDropDownBtnPaste.Size = New System.Drawing.Size(38, 17)
			Me.toolStripDropDownBtnPaste.Text = "Paste"
			' 
			' pasteToolStripMenuItem
			' 
			Me.pasteToolStripMenuItem.Image = (CType(resources.GetObject("pasteToolStripMenuItem.Image"), System.Drawing.Image))
			Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
			Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
			Me.pasteToolStripMenuItem.Text = "&Paste"
			' 
			' pasteSpecialToolStripMenuItem
			' 
			Me.pasteSpecialToolStripMenuItem.Image = (CType(resources.GetObject("pasteSpecialToolStripMenuItem.Image"), System.Drawing.Image))
			Me.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem"
			Me.pasteSpecialToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
			Me.pasteSpecialToolStripMenuItem.Text = "Paste &Special..."
			' 
			' pasteAsHyperlinkToolStripMenuItem
			' 
			Me.pasteAsHyperlinkToolStripMenuItem.Enabled = False
			Me.pasteAsHyperlinkToolStripMenuItem.Image = (CType(resources.GetObject("pasteAsHyperlinkToolStripMenuItem.Image"), System.Drawing.Image))
			Me.pasteAsHyperlinkToolStripMenuItem.Name = "pasteAsHyperlinkToolStripMenuItem"
			Me.pasteAsHyperlinkToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
			Me.pasteAsHyperlinkToolStripMenuItem.Text = "Paste as &Hyperlink"
			' 
			' toolStripPanelItem1
			' 
			Me.toolStripPanelItem1.CausesValidation = False
			Me.toolStripPanelItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripBtnCut, Me.toolStripBtnCopy, Me.toolStripBtnPaint})
			Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
			Me.toolStripPanelItem1.Size = New System.Drawing.Size(27, 73)
			Me.toolStripPanelItem1.Text = "toolStripPanelItem1"
			Me.toolStripPanelItem1.Transparent = True
			' 
			' toolStripBtnCut
			' 
			Me.toolStripBtnCut.AutoToolTip = False
			Me.toolStripBtnCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripBtnCut.Image = (CType(resources.GetObject("toolStripBtnCut.Image"), System.Drawing.Image))
			Me.toolStripBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripBtnCut.Name = "toolStripBtnCut"
			Me.SetShortcut(Me.toolStripBtnCut, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)))
			Me.toolStripBtnCut.Size = New System.Drawing.Size(23, 20)
			Me.toolStripBtnCut.Text = "toolStripBtnCut"
			' 
			' toolStripBtnCopy
			' 
			Me.toolStripBtnCopy.AutoToolTip = False
			Me.toolStripBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripBtnCopy.Image = (CType(resources.GetObject("toolStripBtnCopy.Image"), System.Drawing.Image))
			Me.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripBtnCopy.Name = "toolStripBtnCopy"
			Me.SetShortcut(Me.toolStripBtnCopy, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)))
			Me.toolStripBtnCopy.Size = New System.Drawing.Size(23, 20)
			Me.toolStripBtnCopy.Text = "toolStripButton6"
			' 
			' toolStripBtnPaint
			' 
			Me.toolStripBtnPaint.AutoToolTip = False
			Me.toolStripBtnPaint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripBtnPaint.Image = (CType(resources.GetObject("toolStripBtnPaint.Image"), System.Drawing.Image))
			Me.toolStripBtnPaint.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripBtnPaint.Name = "toolStripBtnPaint"
			Me.SetShortcut(Me.toolStripBtnPaint, (CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)))
			Me.toolStripBtnPaint.Size = New System.Drawing.Size(23, 20)
			Me.toolStripBtnPaint.Text = "toolStripButton7"
			' 
			' fontToolStripExt
			' 
			Me.fontToolStripExt.CollapsedDropDownButtonText = "Font"
			Me.fontToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.fontToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.fontToolStripExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.fontToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.fontToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.fontToolStripExt.GroupedButtons = True
			Me.fontToolStripExt.Image = (CType(resources.GetObject("fontToolStripExt.Image"), System.Drawing.Image))
			Me.fontToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem3})
			Me.fontToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
			Me.fontToolStripExt.Location = New System.Drawing.Point(80, 1)
			Me.fontToolStripExt.Name = "fontToolStripExt"
			Me.fontToolStripExt.Size = New System.Drawing.Size(194, 91)
			Me.fontToolStripExt.TabIndex = 4
			Me.fontToolStripExt.Text = "Font"
			' 
			' toolStripPanelItem3
			' 
			Me.toolStripPanelItem3.CausesValidation = False
			Me.toolStripPanelItem3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem3.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem2, Me.toolStripPanelItem5})
			Me.toolStripPanelItem3.Name = "toolStripPanelItem3"
			Me.toolStripPanelItem3.Padding = New System.Windows.Forms.Padding(2, 10, 2, 2)
			Me.toolStripPanelItem3.RowCount = 2
			Me.toolStripPanelItem3.Size = New System.Drawing.Size(187, 68)
			Me.toolStripPanelItem3.Text = "toolStripPanelItem3"
			Me.toolStripPanelItem3.Transparent = True
			' 
			' toolStripPanelItem2
			' 
			Me.toolStripPanelItem2.CausesValidation = False
			Me.toolStripPanelItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem2.GroupedButtons = True
			Me.toolStripPanelItem2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripFontfaceComboBox, Me.toolStripFontSizeComboBox})
			Me.toolStripPanelItem2.Name = "toolStripPanelItem2"
			Me.toolStripPanelItem2.RowCount = 1
			Me.toolStripPanelItem2.Size = New System.Drawing.Size(170, 25)
			Me.toolStripPanelItem2.Text = "toolStripPanelItem2"
			Me.toolStripPanelItem2.Transparent = True
			' 
			' toolStripFontfaceComboBox
			' 
			Me.toolStripFontfaceComboBox.DropDownHeight = 120
			Me.toolStripFontfaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.toolStripFontfaceComboBox.IntegralHeight = False
			Me.toolStripFontfaceComboBox.Name = "toolStripFontfaceComboBox"
			Me.SetShortcut(Me.toolStripFontfaceComboBox, (CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)))
			Me.toolStripFontfaceComboBox.Size = New System.Drawing.Size(121, 21)
			' 
			' toolStripFontSizeComboBox
			' 
			Me.toolStripFontSizeComboBox.AutoSize = False
			Me.toolStripFontSizeComboBox.DropDownHeight = 120
			Me.toolStripFontSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.toolStripFontSizeComboBox.IntegralHeight = False
			Me.toolStripFontSizeComboBox.Items.AddRange(New Object() { "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
			Me.toolStripFontSizeComboBox.Name = "toolStripFontSizeComboBox"
			Me.SetShortcut(Me.toolStripFontSizeComboBox, (CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)))
			Me.toolStripFontSizeComboBox.Size = New System.Drawing.Size(41, 21)
			' 
			' toolStripPanelItem5
			' 
			Me.toolStripPanelItem5.CausesValidation = False
			Me.toolStripPanelItem5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem5.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem4, Me.toolStripPanelItem6})
			Me.toolStripPanelItem5.Name = "toolStripPanelItem5"
			Me.toolStripPanelItem5.RowCount = 1
			Me.toolStripPanelItem5.Size = New System.Drawing.Size(181, 31)
			Me.toolStripPanelItem5.Text = "toolStripPanelItem5"
			Me.toolStripPanelItem5.Transparent = True
			' 
			' toolStripPanelItem4
			' 
			Me.toolStripPanelItem4.CausesValidation = False
			Me.toolStripPanelItem4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem4.GroupedButtons = True
			Me.toolStripPanelItem4.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.boldToolstripBtn, Me.italicToolStripBtn, Me.underlineToolStripSplitBtn, Me.strikethroToolStripBtn})
			Me.toolStripPanelItem4.Name = "toolStripPanelItem4"
			Me.toolStripPanelItem4.RowCount = 1
			Me.toolStripPanelItem4.Size = New System.Drawing.Size(105, 27)
			Me.toolStripPanelItem4.Text = "toolStripPanelItem4"
			Me.toolStripPanelItem4.Transparent = True
			' 
			' boldToolstripBtn
			' 
			Me.boldToolstripBtn.AutoToolTip = False
			Me.boldToolstripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.boldToolstripBtn.Image = (CType(resources.GetObject("boldToolstripBtn.Image"), System.Drawing.Image))
			Me.boldToolstripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.boldToolstripBtn.Name = "boldToolstripBtn"
			Me.SetShortcut(Me.boldToolstripBtn, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)))
			Me.boldToolstripBtn.Size = New System.Drawing.Size(23, 20)
			Me.boldToolstripBtn.Text = "boldToolstripBtn"
			' 
			' italicToolStripBtn
			' 
			Me.italicToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.italicToolStripBtn.Image = (CType(resources.GetObject("italicToolStripBtn.Image"), System.Drawing.Image))
			Me.italicToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.italicToolStripBtn.Name = "italicToolStripBtn"
			Me.SetShortcut(Me.italicToolStripBtn, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)))
			Me.italicToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.italicToolStripBtn.Text = "italicToolStripBtn"
			' 
			' underlineToolStripSplitBtn
			' 
			Me.underlineToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.underlineToolStripSplitBtn.Image = (CType(resources.GetObject("underlineToolStripSplitBtn.Image"), System.Drawing.Image))
			Me.underlineToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.underlineToolStripSplitBtn.Name = "underlineToolStripSplitBtn"
			Me.SetShortcut(Me.underlineToolStripSplitBtn, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)))
			Me.underlineToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
			Me.underlineToolStripSplitBtn.Text = "underlineToolStripSplitBtn"
			' 
			' strikethroToolStripBtn
			' 
			Me.strikethroToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.strikethroToolStripBtn.Image = (CType(resources.GetObject("strikethroToolStripBtn.Image"), System.Drawing.Image))
			Me.strikethroToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.strikethroToolStripBtn.Name = "strikethroToolStripBtn"
			Me.strikethroToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.strikethroToolStripBtn.Text = "strikethroToolStripBtn"
			' 
			' toolStripPanelItem6
			' 
			Me.toolStripPanelItem6.CausesValidation = False
			Me.toolStripPanelItem6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem6.GroupedButtons = True
			Me.toolStripPanelItem6.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.txthighltToolStripsplitBtn, Me.fontcolorToolStripSplitBtn})
			Me.toolStripPanelItem6.Name = "toolStripPanelItem6"
			Me.toolStripPanelItem6.RowCount = 1
			Me.toolStripPanelItem6.Size = New System.Drawing.Size(68, 27)
			Me.toolStripPanelItem6.Text = "toolStripPanelItem6"
			Me.toolStripPanelItem6.Transparent = True
			' 
			' txthighltToolStripsplitBtn
			' 
			Me.txthighltToolStripsplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.txthighltToolStripsplitBtn.Image = (CType(resources.GetObject("txthighltToolStripsplitBtn.Image"), System.Drawing.Image))
			Me.txthighltToolStripsplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.txthighltToolStripsplitBtn.Name = "txthighltToolStripsplitBtn"
			Me.txthighltToolStripsplitBtn.Size = New System.Drawing.Size(32, 20)
			Me.txthighltToolStripsplitBtn.Text = "txthighltToolStripsplitBtn"
			' 
			' fontcolorToolStripSplitBtn
			' 
			Me.fontcolorToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.fontcolorToolStripSplitBtn.Image = (CType(resources.GetObject("fontcolorToolStripSplitBtn.Image"), System.Drawing.Image))
			Me.fontcolorToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.fontcolorToolStripSplitBtn.Name = "fontcolorToolStripSplitBtn"
			Me.fontcolorToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
			Me.fontcolorToolStripSplitBtn.Text = "fontcolorToolStripSplitBtn"
			' 
			' paragraphToolStripExt
			' 
			Me.paragraphToolStripExt.AutoSize = False
			Me.paragraphToolStripExt.CollapsedDropDownButtonText = "Paragraph"
			Me.paragraphToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.paragraphToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.paragraphToolStripExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.paragraphToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.paragraphToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.paragraphToolStripExt.GroupedButtons = True
			Me.paragraphToolStripExt.Image = (CType(resources.GetObject("paragraphToolStripExt.Image"), System.Drawing.Image))
			Me.paragraphToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.lAlignToolStripBtn, Me.centerToolStripBtn, Me.rAlignToolStripBtn, Me.justifyToolStripBtn, Me.lspacingToolStripDropDwnBtn, Me.shadingToolStripSplitBtn, Me.btmborderToolStripSplitBtn})
			Me.paragraphToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
			Me.paragraphToolStripExt.Location = New System.Drawing.Point(274, 1)
			Me.paragraphToolStripExt.Name = "paragraphToolStripExt"
			Me.paragraphToolStripExt.Padding = New System.Windows.Forms.Padding(0, 10, 1, 0)
			Me.paragraphToolStripExt.Size = New System.Drawing.Size(106, 91)
			Me.paragraphToolStripExt.TabIndex = 3
			Me.paragraphToolStripExt.Text = "Paragraph"
			' 
			' lAlignToolStripBtn
			' 
			Me.lAlignToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.lAlignToolStripBtn.Image = (CType(resources.GetObject("lAlignToolStripBtn.Image"), System.Drawing.Image))
			Me.lAlignToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.lAlignToolStripBtn.Name = "lAlignToolStripBtn"
			Me.SetShortcut(Me.lAlignToolStripBtn, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)))
			Me.lAlignToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.lAlignToolStripBtn.Text = "lAlignToolStripBtn"
			' 
			' centerToolStripBtn
			' 
			Me.centerToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.centerToolStripBtn.Image = (CType(resources.GetObject("centerToolStripBtn.Image"), System.Drawing.Image))
			Me.centerToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.centerToolStripBtn.Name = "centerToolStripBtn"
			Me.SetShortcut(Me.centerToolStripBtn, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)))
			Me.centerToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.centerToolStripBtn.Text = "centerToolStripBtn"
			' 
			' rAlignToolStripBtn
			' 
			Me.rAlignToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.rAlignToolStripBtn.Image = (CType(resources.GetObject("rAlignToolStripBtn.Image"), System.Drawing.Image))
			Me.rAlignToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.rAlignToolStripBtn.Name = "rAlignToolStripBtn"
			Me.SetShortcut(Me.rAlignToolStripBtn, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)))
			Me.rAlignToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.rAlignToolStripBtn.Text = "rAlignToolStripBtn"
			' 
			' justifyToolStripBtn
			' 
			Me.justifyToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.justifyToolStripBtn.Image = (CType(resources.GetObject("justifyToolStripBtn.Image"), System.Drawing.Image))
			Me.justifyToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.justifyToolStripBtn.Name = "justifyToolStripBtn"
			Me.SetShortcut(Me.justifyToolStripBtn, (CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)))
			Me.justifyToolStripBtn.Size = New System.Drawing.Size(23, 20)
			Me.justifyToolStripBtn.Text = "toolStripButton21"
			' 
			' lspacingToolStripDropDwnBtn
			' 
			Me.lspacingToolStripDropDwnBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.lspacingToolStripDropDwnBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripMenuItem2, Me.toolStripMenuItem3, Me.toolStripMenuItem4, Me.toolStripMenuItem5, Me.toolStripMenuItem6, Me.toolStripMenuItem7, Me.moreToolStripMenuItem, Me.toolStripSeparator9, Me.addSpaceBeforeParagraphToolStripMenuItem, Me.removeSpaceAfterParagraphToolStripMenuItem})
			Me.lspacingToolStripDropDwnBtn.Image = (CType(resources.GetObject("lspacingToolStripDropDwnBtn.Image"), System.Drawing.Image))
			Me.lspacingToolStripDropDwnBtn.ImageTransparentColor = System.Drawing.Color.White
			Me.lspacingToolStripDropDwnBtn.Name = "lspacingToolStripDropDwnBtn"
			Me.lspacingToolStripDropDwnBtn.Size = New System.Drawing.Size(29, 20)
			Me.lspacingToolStripDropDwnBtn.Text = "lspacingToolStripDropDwnBtn"
			' 
			' toolStripMenuItem2
			' 
			Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
			Me.toolStripMenuItem2.Size = New System.Drawing.Size(225, 22)
			Me.toolStripMenuItem2.Text = "1.0"
			' 
			' toolStripMenuItem3
			' 
			Me.toolStripMenuItem3.Checked = True
			Me.toolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Checked
			Me.toolStripMenuItem3.Name = "toolStripMenuItem3"
			Me.toolStripMenuItem3.Size = New System.Drawing.Size(225, 22)
			Me.toolStripMenuItem3.Text = "1.15"
			' 
			' toolStripMenuItem4
			' 
			Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
			Me.toolStripMenuItem4.Size = New System.Drawing.Size(225, 22)
			Me.toolStripMenuItem4.Text = "1.5"
			' 
			' toolStripMenuItem5
			' 
			Me.toolStripMenuItem5.Name = "toolStripMenuItem5"
			Me.toolStripMenuItem5.Size = New System.Drawing.Size(225, 22)
			Me.toolStripMenuItem5.Text = "2.0"
			' 
			' toolStripMenuItem6
			' 
			Me.toolStripMenuItem6.Name = "toolStripMenuItem6"
			Me.toolStripMenuItem6.Size = New System.Drawing.Size(225, 22)
			Me.toolStripMenuItem6.Text = "2.5"
			' 
			' toolStripMenuItem7
			' 
			Me.toolStripMenuItem7.Name = "toolStripMenuItem7"
			Me.toolStripMenuItem7.Size = New System.Drawing.Size(225, 22)
			Me.toolStripMenuItem7.Text = "3.0"
			' 
			' moreToolStripMenuItem
			' 
			Me.moreToolStripMenuItem.Name = "moreToolStripMenuItem"
			Me.moreToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
			Me.moreToolStripMenuItem.Text = "More..."
			' 
			' toolStripSeparator9
			' 
			Me.toolStripSeparator9.Name = "toolStripSeparator9"
			Me.toolStripSeparator9.Size = New System.Drawing.Size(222, 6)
			' 
			' addSpaceBeforeParagraphToolStripMenuItem
			' 
			Me.addSpaceBeforeParagraphToolStripMenuItem.Image = (CType(resources.GetObject("addSpaceBeforeParagraphToolStripMenuItem.Image"), System.Drawing.Image))
			Me.addSpaceBeforeParagraphToolStripMenuItem.Name = "addSpaceBeforeParagraphToolStripMenuItem"
			Me.addSpaceBeforeParagraphToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
			Me.addSpaceBeforeParagraphToolStripMenuItem.Text = "&Add Space Before Paragraph"
			' 
			' removeSpaceAfterParagraphToolStripMenuItem
			' 
			Me.removeSpaceAfterParagraphToolStripMenuItem.Image = (CType(resources.GetObject("removeSpaceAfterParagraphToolStripMenuItem.Image"), System.Drawing.Image))
			Me.removeSpaceAfterParagraphToolStripMenuItem.Name = "removeSpaceAfterParagraphToolStripMenuItem"
			Me.removeSpaceAfterParagraphToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
			Me.removeSpaceAfterParagraphToolStripMenuItem.Text = "&Remove Space After Paragraph"
			' 
			' shadingToolStripSplitBtn
			' 
			Me.shadingToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.shadingToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.noColorToolStripMenuItem1, Me.toolStripSeparator10, Me.moreShadingColorsToolStripMenuItem})
			Me.shadingToolStripSplitBtn.Image = (CType(resources.GetObject("shadingToolStripSplitBtn.Image"), System.Drawing.Image))
			Me.shadingToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.shadingToolStripSplitBtn.Name = "shadingToolStripSplitBtn"
			Me.shadingToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
			Me.shadingToolStripSplitBtn.Text = "shadingToolStripSplitBtn"
			' 
			' noColorToolStripMenuItem1
			' 
			Me.noColorToolStripMenuItem1.Image = (CType(resources.GetObject("noColorToolStripMenuItem1.Image"), System.Drawing.Image))
			Me.noColorToolStripMenuItem1.Name = "noColorToolStripMenuItem1"
			Me.noColorToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
			Me.noColorToolStripMenuItem1.Text = "&No Color"
			' 
			' toolStripSeparator10
			' 
			Me.toolStripSeparator10.Name = "toolStripSeparator10"
			Me.toolStripSeparator10.Size = New System.Drawing.Size(178, 6)
			' 
			' moreShadingColorsToolStripMenuItem
			' 
			Me.moreShadingColorsToolStripMenuItem.Image = (CType(resources.GetObject("moreShadingColorsToolStripMenuItem.Image"), System.Drawing.Image))
			Me.moreShadingColorsToolStripMenuItem.Name = "moreShadingColorsToolStripMenuItem"
			Me.moreShadingColorsToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.moreShadingColorsToolStripMenuItem.Text = "&More Shading Colors..."
			' 
			' btmborderToolStripSplitBtn
			' 
			Me.btmborderToolStripSplitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.btmborderToolStripSplitBtn.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() { Me.bottomBorderToolStripMenuItem, Me.topBoToolStripMenuItem, Me.leftBorderToolStripMenuItem, Me.rightBorderToolStripMenuItem, Me.toolStripSeparator1, Me.noBorderToolStripMenuItem, Me.allBordersToolStripMenuItem, Me.outsideBordersToolStripMenuItem, Me.insideBordersToolStripMenuItem, Me.toolStripSeparator2, Me.insideHorizontalBorderToolStripMenuItem, Me.insideVerticalBorderToolStripMenuItem, Me.diagonalDownBorderToolStripMenuItem, Me.diagonalUpBorderToolStripMenuItem, Me.toolStripSeparator3, Me.horizontalLineToolStripMenuItem, Me.toolStripSeparator4, Me.showGridlinesToolStripMenuItem, Me.bordersAndShadingToolStripMenuItem})
			Me.btmborderToolStripSplitBtn.Image = (CType(resources.GetObject("btmborderToolStripSplitBtn.Image"), System.Drawing.Image))
			Me.btmborderToolStripSplitBtn.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.btmborderToolStripSplitBtn.Name = "btmborderToolStripSplitBtn"
			Me.btmborderToolStripSplitBtn.Size = New System.Drawing.Size(32, 20)
			Me.btmborderToolStripSplitBtn.Text = "btmborderToolStripSplitBtn"
			' 
			' bottomBorderToolStripMenuItem
			' 
			Me.bottomBorderToolStripMenuItem.Image = (CType(resources.GetObject("bottomBorderToolStripMenuItem.Image"), System.Drawing.Image))
			Me.bottomBorderToolStripMenuItem.Name = "bottomBorderToolStripMenuItem"
			Me.bottomBorderToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.bottomBorderToolStripMenuItem.Text = "&Bottom Border"
			' 
			' topBoToolStripMenuItem
			' 
			Me.topBoToolStripMenuItem.Image = (CType(resources.GetObject("topBoToolStripMenuItem.Image"), System.Drawing.Image))
			Me.topBoToolStripMenuItem.Name = "topBoToolStripMenuItem"
			Me.topBoToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.topBoToolStripMenuItem.Text = "To&p Border"
			' 
			' leftBorderToolStripMenuItem
			' 
			Me.leftBorderToolStripMenuItem.Image = (CType(resources.GetObject("leftBorderToolStripMenuItem.Image"), System.Drawing.Image))
			Me.leftBorderToolStripMenuItem.Name = "leftBorderToolStripMenuItem"
			Me.leftBorderToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.leftBorderToolStripMenuItem.Text = "&Left Border"
			' 
			' rightBorderToolStripMenuItem
			' 
			Me.rightBorderToolStripMenuItem.Image = (CType(resources.GetObject("rightBorderToolStripMenuItem.Image"), System.Drawing.Image))
			Me.rightBorderToolStripMenuItem.Name = "rightBorderToolStripMenuItem"
			Me.rightBorderToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.rightBorderToolStripMenuItem.Text = "&Right Border"
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(183, 6)
			' 
			' noBorderToolStripMenuItem
			' 
			Me.noBorderToolStripMenuItem.Image = (CType(resources.GetObject("noBorderToolStripMenuItem.Image"), System.Drawing.Image))
			Me.noBorderToolStripMenuItem.Name = "noBorderToolStripMenuItem"
			Me.noBorderToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.noBorderToolStripMenuItem.Text = "&No Border"
			' 
			' allBordersToolStripMenuItem
			' 
			Me.allBordersToolStripMenuItem.Image = (CType(resources.GetObject("allBordersToolStripMenuItem.Image"), System.Drawing.Image))
			Me.allBordersToolStripMenuItem.Name = "allBordersToolStripMenuItem"
			Me.allBordersToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.allBordersToolStripMenuItem.Text = "&All Borders"
			' 
			' outsideBordersToolStripMenuItem
			' 
			Me.outsideBordersToolStripMenuItem.Image = (CType(resources.GetObject("outsideBordersToolStripMenuItem.Image"), System.Drawing.Image))
			Me.outsideBordersToolStripMenuItem.Name = "outsideBordersToolStripMenuItem"
			Me.outsideBordersToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.outsideBordersToolStripMenuItem.Text = "Out&side Borders"
			' 
			' insideBordersToolStripMenuItem
			' 
			Me.insideBordersToolStripMenuItem.Image = (CType(resources.GetObject("insideBordersToolStripMenuItem.Image"), System.Drawing.Image))
			Me.insideBordersToolStripMenuItem.Name = "insideBordersToolStripMenuItem"
			Me.insideBordersToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.insideBordersToolStripMenuItem.Text = "&Inside Borders"
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(183, 6)
			' 
			' insideHorizontalBorderToolStripMenuItem
			' 
			Me.insideHorizontalBorderToolStripMenuItem.Image = (CType(resources.GetObject("insideHorizontalBorderToolStripMenuItem.Image"), System.Drawing.Image))
			Me.insideHorizontalBorderToolStripMenuItem.Name = "insideHorizontalBorderToolStripMenuItem"
			Me.insideHorizontalBorderToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.insideHorizontalBorderToolStripMenuItem.Text = "Inside &Horizontal Border"
			' 
			' insideVerticalBorderToolStripMenuItem
			' 
			Me.insideVerticalBorderToolStripMenuItem.Image = (CType(resources.GetObject("insideVerticalBorderToolStripMenuItem.Image"), System.Drawing.Image))
			Me.insideVerticalBorderToolStripMenuItem.Name = "insideVerticalBorderToolStripMenuItem"
			Me.insideVerticalBorderToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.insideVerticalBorderToolStripMenuItem.Text = "Inside &Vertical Border"
			' 
			' diagonalDownBorderToolStripMenuItem
			' 
			Me.diagonalDownBorderToolStripMenuItem.Enabled = False
			Me.diagonalDownBorderToolStripMenuItem.Image = (CType(resources.GetObject("diagonalDownBorderToolStripMenuItem.Image"), System.Drawing.Image))
			Me.diagonalDownBorderToolStripMenuItem.Name = "diagonalDownBorderToolStripMenuItem"
			Me.diagonalDownBorderToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.diagonalDownBorderToolStripMenuItem.Text = "&Diagonal Down Border"
			' 
			' diagonalUpBorderToolStripMenuItem
			' 
			Me.diagonalUpBorderToolStripMenuItem.Enabled = False
			Me.diagonalUpBorderToolStripMenuItem.Image = (CType(resources.GetObject("diagonalUpBorderToolStripMenuItem.Image"), System.Drawing.Image))
			Me.diagonalUpBorderToolStripMenuItem.Name = "diagonalUpBorderToolStripMenuItem"
			Me.diagonalUpBorderToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.diagonalUpBorderToolStripMenuItem.Text = "Diagonal &Up Border"
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(183, 6)
			' 
			' horizontalLineToolStripMenuItem
			' 
			Me.horizontalLineToolStripMenuItem.Image = (CType(resources.GetObject("horizontalLineToolStripMenuItem.Image"), System.Drawing.Image))
			Me.horizontalLineToolStripMenuItem.Name = "horizontalLineToolStripMenuItem"
			Me.horizontalLineToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.horizontalLineToolStripMenuItem.Text = "Hori&zontal Line"
			' 
			' toolStripSeparator4
			' 
			Me.toolStripSeparator4.Name = "toolStripSeparator4"
			Me.toolStripSeparator4.Size = New System.Drawing.Size(183, 6)
			' 
			' showGridlinesToolStripMenuItem
			' 
			Me.showGridlinesToolStripMenuItem.Image = (CType(resources.GetObject("showGridlinesToolStripMenuItem.Image"), System.Drawing.Image))
			Me.showGridlinesToolStripMenuItem.Name = "showGridlinesToolStripMenuItem"
			Me.showGridlinesToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.showGridlinesToolStripMenuItem.Text = "Show &Gridlines"
			' 
			' bordersAndShadingToolStripMenuItem
			' 
			Me.bordersAndShadingToolStripMenuItem.Image = (CType(resources.GetObject("bordersAndShadingToolStripMenuItem.Image"), System.Drawing.Image))
			Me.bordersAndShadingToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.bordersAndShadingToolStripMenuItem.Name = "bordersAndShadingToolStripMenuItem"
			Me.bordersAndShadingToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
			Me.bordersAndShadingToolStripMenuItem.Text = "Border&s and Shading..."
			' 
			' stylesToolStripExt
			' 
			Me.stylesToolStripExt.CollapsedDropDownButtonText = "Styles"
			Me.stylesToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight
			Me.stylesToolStripExt.Dock = System.Windows.Forms.DockStyle.None
			Me.stylesToolStripExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.stylesToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue
			Me.stylesToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.stylesToolStripExt.Image = (CType(resources.GetObject("stylesToolStripExt.Image"), System.Drawing.Image))
			Me.stylesToolStripExt.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripLabel2, Me.toolStripGallery1})
			Me.stylesToolStripExt.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
			Me.stylesToolStripExt.Location = New System.Drawing.Point(380, 1)
			Me.stylesToolStripExt.Name = "stylesToolStripExt"
			Me.stylesToolStripExt.ShowCaption = False
			Me.stylesToolStripExt.Size = New System.Drawing.Size(288, 91)
			Me.stylesToolStripExt.TabIndex = 6
			Me.stylesToolStripExt.Text = "Styles"
			' 
			' toolStripLabel2
			' 
			Me.toolStripLabel2.Name = "toolStripLabel2"
			Me.toolStripLabel2.Size = New System.Drawing.Size(35, 84)
			Me.toolStripLabel2.Text = "Quick" & Constants.vbCrLf & "Styles"
			' 
			' toolStripGallery1
			' 
			Me.toolStripGallery1.CaptionText = ""
			Me.toolStripGallery1.CheckOnClick = True
			Me.toolStripGallery1.Dimensions = New System.Drawing.Size(0, 0)
			Me.toolStripGallery1.ItemBackColor = System.Drawing.Color.Empty
			Me.toolStripGallery1.ItemImageSize = New System.Drawing.Size(65, 48)
			toolStripGalleryItem1.Image = (CType(resources.GetObject("toolStripGalleryItem1.Image"), System.Drawing.Image))
			toolStripGalleryItem1.Tag = "H1"
			toolStripGalleryItem2.Image = (CType(resources.GetObject("toolStripGalleryItem2.Image"), System.Drawing.Image))
			toolStripGalleryItem2.Tag = "H2"
			toolStripGalleryItem3.Image = (CType(resources.GetObject("toolStripGalleryItem3.Image"), System.Drawing.Image))
			toolStripGalleryItem4.Image = (CType(resources.GetObject("toolStripGalleryItem4.Image"), System.Drawing.Image))
			toolStripGalleryItem5.Image = (CType(resources.GetObject("toolStripGalleryItem5.Image"), System.Drawing.Image))
			toolStripGalleryItem6.Image = (CType(resources.GetObject("toolStripGalleryItem6.Image"), System.Drawing.Image))
			toolStripGalleryItem7.Image = (CType(resources.GetObject("toolStripGalleryItem7.Image"), System.Drawing.Image))
			toolStripGalleryItem8.Image = (CType(resources.GetObject("toolStripGalleryItem8.Image"), System.Drawing.Image))
			toolStripGalleryItem9.Image = (CType(resources.GetObject("toolStripGalleryItem9.Image"), System.Drawing.Image))
			Me.toolStripGallery1.Items.Add(toolStripGalleryItem1)
			Me.toolStripGallery1.Items.Add(toolStripGalleryItem2)
			Me.toolStripGallery1.Items.Add(toolStripGalleryItem3)
			Me.toolStripGallery1.Items.Add(toolStripGalleryItem4)
			Me.toolStripGallery1.Items.Add(toolStripGalleryItem5)
			Me.toolStripGallery1.Items.Add(toolStripGalleryItem6)
			Me.toolStripGallery1.Items.Add(toolStripGalleryItem7)
			Me.toolStripGallery1.Items.Add(toolStripGalleryItem8)
			Me.toolStripGallery1.Items.Add(toolStripGalleryItem9)
			Me.toolStripGallery1.ItemSize = New System.Drawing.Size(75, 64)
			Me.toolStripGallery1.Name = "toolStripGallery1"
			Me.toolStripGallery1.ScrollerType = Syncfusion.Windows.Forms.Tools.ToolStripGalleryScrollerType.Compact
			Me.toolStripGallery1.Size = New System.Drawing.Size(246, 66)
			Me.toolStripGallery1.Text = "toolStripGallery1"
			Me.toolStripGallery1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripEx1
			' 
			Me.toolStripEx1.AutoSize = False
			Me.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx1.Image = Nothing
			Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1})
			Me.toolStripEx1.Location = New System.Drawing.Point(688, 1)
			Me.toolStripEx1.Name = "toolStripEx1"
			Me.toolStripEx1.ShowCaption = False
			Me.toolStripEx1.ShowLauncher = False
			Me.toolStripEx1.Size = New System.Drawing.Size(107, 93)
			Me.toolStripEx1.TabIndex = 7
			Me.toolStripEx1.Visible = False
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(23, 86)
			Me.toolStripButton1.Text = "toolStripButton1"
'			Me.toolStripButton1.Click += New System.EventHandler(Me.toolStripButton1_Click)
			' 
			' toolStripEx2
			' 
			Me.toolStripEx2.AutoSize = False
			Me.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.toolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx2.Image = Nothing
			Me.toolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripDropDownButton1})
			Me.toolStripEx2.Location = New System.Drawing.Point(668, 1)
			Me.toolStripEx2.Name = "toolStripEx2"
			Me.toolStripEx2.ShowCaption = False
			Me.toolStripEx2.ShowLauncher = False
			Me.toolStripEx2.Size = New System.Drawing.Size(99, 91)
			Me.toolStripEx2.TabIndex = 8
			' 
			' toolStripDropDownButton1
			' 
			Me.toolStripDropDownButton1.Image = (CType(resources.GetObject("toolStripDropDownButton1.Image"), System.Drawing.Image))
			Me.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripDropDownButton1.Name = "toolStripDropDownButton1"
			Me.toolStripDropDownButton1.Size = New System.Drawing.Size(58, 84)
			Me.toolStripDropDownButton1.Text = "Custom " & Constants.vbCrLf & "Colors"
			Me.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripLabel1
			' 
			Me.toolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.toolStripLabel1.Name = "toolStripLabel1"
			Me.toolStripLabel1.Size = New System.Drawing.Size(114, 13)
			Me.toolStripLabel1.Text = "Recent Documents"
			' 
			' toolStripSeparator5
			' 
			Me.toolStripSeparator5.Name = "toolStripSeparator5"
			Me.toolStripSeparator5.Size = New System.Drawing.Size(98, 2)
			' 
			' toolStripButton5
			' 
			Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
			Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton5.Name = "toolStripButton5"
			Me.toolStripButton5.Size = New System.Drawing.Size(114, 17)
			Me.toolStripButton5.Text = "Document1"
			Me.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.Image = (CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image))
			Me.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Size = New System.Drawing.Size(69, 36)
			Me.toolStripButton2.Text = "New"
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
			Me.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New System.Drawing.Size(69, 36)
			Me.toolStripButton3.Text = "Open"
			' 
			' toolStripButton4
			' 
			Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image))
			Me.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton4.Name = "toolStripButton4"
			Me.toolStripButton4.Size = New System.Drawing.Size(69, 36)
			Me.toolStripButton4.Text = "Save"
			' 
			' toolStripButton6
			' 
			Me.toolStripButton6.Image = (CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image))
			Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton6.Name = "toolStripButton6"
			Me.toolStripButton6.Size = New System.Drawing.Size(45, 20)
			Me.toolStripButton6.Text = "Exit"
			' 
			' tabBarSplitterControl1
			' 
			Me.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage1)
			Me.tabBarSplitterControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText
			Me.tabBarSplitterControl1.Location = New System.Drawing.Point(204, 157)
			Me.tabBarSplitterControl1.Name = "tabBarSplitterControl1"
			Me.tabBarSplitterControl1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.tabBarSplitterControl1.Office2007ScrollBars = True
			Me.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Managed
			Me.tabBarSplitterControl1.RelativeWidth = 66
			Me.tabBarSplitterControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.tabBarSplitterControl1.Size = New System.Drawing.Size(438, 395)
			Me.tabBarSplitterControl1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None
			Me.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Office2007
			Me.tabBarSplitterControl1.TabFolderDelta = 11
			Me.tabBarSplitterControl1.TabIndex = 2
			Me.tabBarSplitterControl1.Text = "tabBarSplitterControl1"
			Me.tabBarSplitterControl1.ThemesEnabled = False
			' 
			' tabBarPage1
			' 
			Me.tabBarPage1.Controls.Add(Me.gradientPanel3)
			Me.tabBarPage1.Location = New System.Drawing.Point(0, 0)
			Me.tabBarPage1.Name = "tabBarPage1"
			Me.tabBarPage1.SplitBars = Syncfusion.Windows.Forms.DynamicSplitBars.None
			Me.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control
			Me.tabBarPage1.Text = "Sheet1"
			Me.tabBarPage1.ThemesEnabled = False
			' 
			' gradientPanel3
			' 
			Me.gradientPanel3.BorderColor = System.Drawing.Color.Black
			Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel3.Controls.Add(Me.richTextBox1)
			Me.gradientPanel3.Controls.Add(Me.gradientLabel1)
			Me.gradientPanel3.Location = New System.Drawing.Point(0, 0)
			Me.gradientPanel3.Name = "gradientPanel3"
			Me.gradientPanel3.Size = New System.Drawing.Size(436, 376)
			Me.gradientPanel3.TabIndex = 9
			' 
			' richTextBox1
			' 
			Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBox1.Location = New System.Drawing.Point(0, 36)
			Me.richTextBox1.Name = "richTextBox1"
			Me.richTextBox1.ReadOnly = True
			Me.richTextBox1.Size = New System.Drawing.Size(434, 338)
			Me.richTextBox1.TabIndex = 1
			Me.richTextBox1.Text = ""
			' 
			' gradientLabel1
			' 
			Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			Me.gradientLabel1.BorderSides = (CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) Or System.Windows.Forms.Border3DSide.Right) Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide))
			Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
			Me.gradientLabel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gradientLabel1.Font = New System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel1.Location = New System.Drawing.Point(0, 0)
			Me.gradientLabel1.Name = "gradientLabel1"
			Me.gradientLabel1.Size = New System.Drawing.Size(434, 36)
			Me.gradientLabel1.TabIndex = 0
			Me.gradientLabel1.Text = "Custom Colors"
			Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' colorPickerUIAdv1.RecentGroup
			' 
			Me.colorPickerUIAdv1.RecentGroup.Name = "Recent Colors"
			Me.colorPickerUIAdv1.RecentGroup.Visible = False
			' 
			' colorPickerUIAdv1.StandardGroup
			' 
			Me.colorPickerUIAdv1.StandardGroup.Name = "Standard Colors"
			' 
			' colorPickerUIAdv1.ThemeGroup
			' 
			Me.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = True
			Me.colorPickerUIAdv1.ThemeGroup.Name = "Theme Colors"
			' 
			' colorPickerUIAdv1
			' 
			Me.colorPickerUIAdv1.ColorItemSize = New System.Drawing.Size(13, 13)
			Me.colorPickerUIAdv1.HorizontalItemsSpacing = 0
			Me.colorPickerUIAdv1.Location = New System.Drawing.Point(37, 107)
			Me.colorPickerUIAdv1.MinimumSize = New System.Drawing.Size(136, 195)
			Me.colorPickerUIAdv1.Name = "colorPickerUIAdv1"
			Me.colorPickerUIAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.colorPickerUIAdv1.SelectedColor = System.Drawing.Color.Empty
			Me.colorPickerUIAdv1.Size = New System.Drawing.Size(136, 210)
			Me.colorPickerUIAdv1.TabIndex = 7
			Me.colorPickerUIAdv1.Text = "colorPickerUIAdv1"
			Me.colorPickerUIAdv1.VerticalItemsSpacing = 3
'			Me.colorPickerUIAdv1.Picked += New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(Me.colorPickerUIAdv1_Picked)
			' 
			' statusStripEx1
			' 
			Me.statusStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripProgressBar1, Me.trackBarItem1, Me.statusStripLabel1})
			Me.statusStripEx1.Location = New System.Drawing.Point(6, 552)
			Me.statusStripEx1.Name = "statusStripEx1"
			Me.statusStripEx1.Size = New System.Drawing.Size(869, 22)
			Me.statusStripEx1.TabIndex = 3
			Me.statusStripEx1.Text = "statusStripEx1"
			' 
			' toolStripProgressBar1
			' 
			Me.toolStripProgressBar1.Name = "toolStripProgressBar1"
			Me.toolStripProgressBar1.Size = New System.Drawing.Size(100, 15)
			Me.toolStripProgressBar1.Value = 50
			' 
			' trackBarItem1
			' 
			Me.trackBarItem1.Maximum = 10
			Me.trackBarItem1.Name = "trackBarItem1"
			Me.trackBarItem1.Size = New System.Drawing.Size(250, 20)
			Me.trackBarItem1.Text = "trackBarItem1"
			Me.trackBarItem1.Value = 5
			' 
			' statusStripLabel1
			' 
			Me.statusStripLabel1.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
			Me.statusStripLabel1.Name = "statusStripLabel1"
			Me.statusStripLabel1.Size = New System.Drawing.Size(104, 13)
			Me.statusStripLabel1.Text = "Custom colors Demo"
			' 
			' changeListLevelToolStripMenuItem
			' 
			Me.changeListLevelToolStripMenuItem.Image = (CType(resources.GetObject("changeListLevelToolStripMenuItem.Image"), System.Drawing.Image))
			Me.changeListLevelToolStripMenuItem.Name = "changeListLevelToolStripMenuItem"
			Me.changeListLevelToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.changeListLevelToolStripMenuItem.Text = "&Change List Level"
			' 
			' defineNewBulletToolStripMenuItem
			' 
			Me.defineNewBulletToolStripMenuItem.Name = "defineNewBulletToolStripMenuItem"
			Me.defineNewBulletToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
			Me.defineNewBulletToolStripMenuItem.Text = "&Define New Bullet..."
			' 
			' changeListLevelToolStripMenuItem1
			' 
			Me.changeListLevelToolStripMenuItem1.Image = (CType(resources.GetObject("changeListLevelToolStripMenuItem1.Image"), System.Drawing.Image))
			Me.changeListLevelToolStripMenuItem1.Name = "changeListLevelToolStripMenuItem1"
			Me.changeListLevelToolStripMenuItem1.Size = New System.Drawing.Size(229, 22)
			Me.changeListLevelToolStripMenuItem1.Text = "&Change List Level"
			' 
			' defineNewNumberFormatToolStripMenuItem
			' 
			Me.defineNewNumberFormatToolStripMenuItem.Name = "defineNewNumberFormatToolStripMenuItem"
			Me.defineNewNumberFormatToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
			Me.defineNewNumberFormatToolStripMenuItem.Text = "&Define New Number Format..."
			' 
			' setNumberingValueToolStripMenuItem
			' 
			Me.setNumberingValueToolStripMenuItem.Image = (CType(resources.GetObject("setNumberingValueToolStripMenuItem.Image"), System.Drawing.Image))
			Me.setNumberingValueToolStripMenuItem.Name = "setNumberingValueToolStripMenuItem"
			Me.setNumberingValueToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
			Me.setNumberingValueToolStripMenuItem.Text = "Set Numbering &Value..."
			' 
			' changeListLevelToolStripMenuItem2
			' 
			Me.changeListLevelToolStripMenuItem2.Image = (CType(resources.GetObject("changeListLevelToolStripMenuItem2.Image"), System.Drawing.Image))
			Me.changeListLevelToolStripMenuItem2.Name = "changeListLevelToolStripMenuItem2"
			Me.changeListLevelToolStripMenuItem2.Size = New System.Drawing.Size(218, 22)
			Me.changeListLevelToolStripMenuItem2.Text = "&Change List Level"
			' 
			' defineNewMultilevelListToolStripMenuItem
			' 
			Me.defineNewMultilevelListToolStripMenuItem.Name = "defineNewMultilevelListToolStripMenuItem"
			Me.defineNewMultilevelListToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
			Me.defineNewMultilevelListToolStripMenuItem.Text = "&Define New Multilevel List..."
			' 
			' defineNewListStyleToolStripMenuItem
			' 
			Me.defineNewListStyleToolStripMenuItem.Name = "defineNewListStyleToolStripMenuItem"
			Me.defineNewListStyleToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
			Me.defineNewListStyleToolStripMenuItem.Text = "Define New &List Style..."
			' 
			' moreUnderlinesToolStripMenuItem
			' 
			Me.moreUnderlinesToolStripMenuItem.Name = "moreUnderlinesToolStripMenuItem"
			Me.moreUnderlinesToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
			Me.moreUnderlinesToolStripMenuItem.Text = "&More Underlines..."
			' 
			' underlineColorToolStripMenuItem
			' 
			Me.underlineColorToolStripMenuItem.Image = (CType(resources.GetObject("underlineColorToolStripMenuItem.Image"), System.Drawing.Image))
			Me.underlineColorToolStripMenuItem.Name = "underlineColorToolStripMenuItem"
			Me.underlineColorToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
			Me.underlineColorToolStripMenuItem.Text = "&Underline Color"
			' 
			' automaticToolStripMenuItem
			' 
			Me.automaticToolStripMenuItem.Name = "automaticToolStripMenuItem"
			Me.automaticToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.automaticToolStripMenuItem.Text = "&Automatic"
			' 
			' moreColorsToolStripMenuItem
			' 
			Me.moreColorsToolStripMenuItem.Name = "moreColorsToolStripMenuItem"
			Me.moreColorsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.moreColorsToolStripMenuItem.Text = "&More Colors..."
			' 
			' noColorToolStripMenuItem
			' 
			Me.noColorToolStripMenuItem.Image = (CType(resources.GetObject("noColorToolStripMenuItem.Image"), System.Drawing.Image))
			Me.noColorToolStripMenuItem.Name = "noColorToolStripMenuItem"
			Me.noColorToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
			Me.noColorToolStripMenuItem.Text = "&No Color"
			' 
			' toolStripSeparator8
			' 
			Me.toolStripSeparator8.Name = "toolStripSeparator8"
			Me.toolStripSeparator8.Size = New System.Drawing.Size(162, 6)
			' 
			' stopHighlightingToolStripMenuItem
			' 
			Me.stopHighlightingToolStripMenuItem.Enabled = False
			Me.stopHighlightingToolStripMenuItem.Name = "stopHighlightingToolStripMenuItem"
			Me.stopHighlightingToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
			Me.stopHighlightingToolStripMenuItem.Text = "&Stop Highlighting"
			' 
			' automaticToolStripMenuItem1
			' 
			Me.automaticToolStripMenuItem1.Name = "automaticToolStripMenuItem1"
			Me.automaticToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
			Me.automaticToolStripMenuItem1.Text = "&Automatic"
			' 
			' themeColorToolStripMenuItem
			' 
			Me.themeColorToolStripMenuItem.Name = "themeColorToolStripMenuItem"
			Me.themeColorToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
			Me.themeColorToolStripMenuItem.Text = "Theme Color"
			' 
			' moreColorsToolStripMenuItem1
			' 
			Me.moreColorsToolStripMenuItem1.Image = (CType(resources.GetObject("moreColorsToolStripMenuItem1.Image"), System.Drawing.Image))
			Me.moreColorsToolStripMenuItem1.Name = "moreColorsToolStripMenuItem1"
			Me.moreColorsToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
			Me.moreColorsToolStripMenuItem1.Text = "More Colors..."
			' 
			' groupBar1
			' 
			Me.groupBar1.AllowDrop = True
			Me.groupBar1.AnimatedSelection = False
			Me.groupBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.groupBar1.Controls.Add(Me.panel2)
			Me.groupBar1.Controls.Add(Me.panel3)
			Me.groupBar1.Dock = System.Windows.Forms.DockStyle.Left
			Me.groupBar1.Font = New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold)
			Me.groupBar1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.groupBar1.GroupBarItemHeight = 32
			Me.groupBar1.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.groupBarItem1, Me.groupBarItem2})
			Me.groupBar1.HeaderForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(65))))), (CInt(Fix((CByte(140))))))
			Me.groupBar1.Location = New System.Drawing.Point(6, 157)
			Me.groupBar1.Name = "groupBar1"
			Me.groupBar1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.groupBar1.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.groupBar1.SelectedItem = 0
			Me.groupBar1.Size = New System.Drawing.Size(198, 395)
			Me.groupBar1.StackedMode = True
			Me.groupBar1.TabIndex = 5
			Me.groupBar1.Text = "groupBar1"
			Me.groupBar1.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.groupBar1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.White
			Me.panel2.Controls.Add(Me.comboBoxAdv1)
			Me.panel2.Controls.Add(Me.monthCalendarAdv1)
			Me.panel2.Controls.Add(Me.buttonAdv2)
			Me.panel2.Controls.Add(Me.checkBoxAdv1)
			Me.panel2.Controls.Add(Me.radioButtonAdv1)
			Me.panel2.Controls.Add(Me.radioButtonAdv2)
			Me.panel2.Location = New System.Drawing.Point(1, 65)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(218, 234)
			Me.panel2.TabIndex = 1
			' 
			' comboBoxAdv1
			' 
			Me.comboBoxAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
			Me.comboBoxAdv1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.comboBoxAdv1.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxAdv1.IgnoreThemeBackground = True
			Me.comboBoxAdv1.Items.AddRange(New Object() { "MailBox", "Archive Folders"})
			Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "MailBox"))
			Me.comboBoxAdv1.ItemsImageIndexes.Add(New Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(Me.comboBoxAdv1, "Archive Folders"))
			Me.comboBoxAdv1.Location = New System.Drawing.Point(0, 127)
			Me.comboBoxAdv1.Name = "comboBoxAdv1"
			Me.comboBoxAdv1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.comboBoxAdv1.Size = New System.Drawing.Size(218, 19)
			Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.comboBoxAdv1.TabIndex = 4
			Me.comboBoxAdv1.Text = "Calendar Items"
			' 
			' monthCalendarAdv1
			' 
			Me.monthCalendarAdv1.Culture = New System.Globalization.CultureInfo("")
			Me.monthCalendarAdv1.DaysFont = New System.Drawing.Font("Verdana", 8F)
			Me.monthCalendarAdv1.DaysHeaderInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			Me.monthCalendarAdv1.Dock = System.Windows.Forms.DockStyle.Top
			Me.monthCalendarAdv1.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
			Me.monthCalendarAdv1.HeaderEndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(255))))))
			Me.monthCalendarAdv1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.monthCalendarAdv1.HeaderHeight = 20
			Me.monthCalendarAdv1.HeaderStartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(179))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(252))))))
			Me.monthCalendarAdv1.HeadForeColor = System.Drawing.SystemColors.ControlText
			Me.monthCalendarAdv1.HeadGradient = True
			Me.monthCalendarAdv1.Location = New System.Drawing.Point(0, 0)
			Me.monthCalendarAdv1.Name = "monthCalendarAdv1"
			Me.monthCalendarAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.monthCalendarAdv1.ScrollButtonSize = New System.Drawing.Size(24, 24)
			Me.monthCalendarAdv1.SelectedDates = New System.DateTime() { New System.DateTime(2009, 4, 14, 0, 0, 0, 0), New System.DateTime(2009, 4, 16, 0, 0, 0, 0)}
			Me.monthCalendarAdv1.Size = New System.Drawing.Size(218, 160)
			Me.monthCalendarAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.monthCalendarAdv1.TabIndex = 2
			Me.monthCalendarAdv1.WeekFont = New System.Drawing.Font("Verdana", 8F)
			Me.monthCalendarAdv1.WeekInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite)
			' 
			' 
			' 
			Me.monthCalendarAdv1.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.monthCalendarAdv1.NoneButton.Location = New System.Drawing.Point(146, 0)
			Me.monthCalendarAdv1.NoneButton.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.monthCalendarAdv1.NoneButton.Size = New System.Drawing.Size(72, 20)
			Me.monthCalendarAdv1.NoneButton.Text = "None"
			Me.monthCalendarAdv1.NoneButton.UseVisualStyle = True
			' 
			' 
			' 
			Me.monthCalendarAdv1.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.monthCalendarAdv1.TodayButton.Location = New System.Drawing.Point(0, 0)
			Me.monthCalendarAdv1.TodayButton.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.monthCalendarAdv1.TodayButton.Size = New System.Drawing.Size(146, 20)
			Me.monthCalendarAdv1.TodayButton.Text = "Today"
			Me.monthCalendarAdv1.TodayButton.UseVisualStyle = True
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.buttonAdv2.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.buttonAdv2.Location = New System.Drawing.Point(0, 146)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.buttonAdv2.Size = New System.Drawing.Size(218, 25)
			Me.buttonAdv2.TabIndex = 3
			Me.buttonAdv2.Text = "My Calendars"
			Me.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.buttonAdv2.UseVisualStyle = True
			' 
			' checkBoxAdv1
			' 
			Me.checkBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv1.Checked = True
			Me.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBoxAdv1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.checkBoxAdv1.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.checkBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.checkBoxAdv1.GradientStart = System.Drawing.SystemColors.Control
			Me.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.checkBoxAdv1.Location = New System.Drawing.Point(0, 171)
			Me.checkBoxAdv1.Name = "checkBoxAdv1"
			Me.checkBoxAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black
			Me.checkBoxAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.checkBoxAdv1.Size = New System.Drawing.Size(218, 21)
			Me.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
			Me.checkBoxAdv1.TabIndex = 5
			Me.checkBoxAdv1.Text = "Calendar"
			Me.checkBoxAdv1.ThemesEnabled = False
			' 
			' radioButtonAdv1
			' 
			Me.radioButtonAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.radioButtonAdv1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.radioButtonAdv1.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButtonAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.radioButtonAdv1.GradientStart = System.Drawing.SystemColors.Control
			Me.radioButtonAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.radioButtonAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.radioButtonAdv1.Location = New System.Drawing.Point(0, 192)
			Me.radioButtonAdv1.Name = "radioButtonAdv1"
			Me.radioButtonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.radioButtonAdv1.ShadowColor = System.Drawing.Color.Black
			Me.radioButtonAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.radioButtonAdv1.Size = New System.Drawing.Size(218, 21)
			Me.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2007
			Me.radioButtonAdv1.TabIndex = 6
			Me.radioButtonAdv1.Text = "All Calendar"
			Me.radioButtonAdv1.ThemesEnabled = False
			' 
			' radioButtonAdv2
			' 
			Me.radioButtonAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.radioButtonAdv2.Checked = True
			Me.radioButtonAdv2.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.radioButtonAdv2.Font = New System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButtonAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.radioButtonAdv2.GradientStart = System.Drawing.SystemColors.Control
			Me.radioButtonAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.radioButtonAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.radioButtonAdv2.Location = New System.Drawing.Point(0, 213)
			Me.radioButtonAdv2.Name = "radioButtonAdv2"
			Me.radioButtonAdv2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.radioButtonAdv2.ShadowColor = System.Drawing.Color.Black
			Me.radioButtonAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.radioButtonAdv2.Size = New System.Drawing.Size(218, 21)
			Me.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2007
			Me.radioButtonAdv2.TabIndex = 7
			Me.radioButtonAdv2.Text = "Calendar In Archive Folders"
			Me.radioButtonAdv2.ThemesEnabled = False
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.xpTaskBar1)
			Me.panel3.Location = New System.Drawing.Point(1, 27)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(196, 265)
			Me.panel3.TabIndex = 2
			' 
			' xpTaskBar1
			' 
			Me.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox1)
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox2)
			Me.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.xpTaskBar1.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar1.Name = "xpTaskBar1"
			Me.xpTaskBar1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.xpTaskBar1.Size = New System.Drawing.Size(196, 265)
			Me.xpTaskBar1.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
			Me.xpTaskBar1.TabIndex = 0
			Me.xpTaskBar1.VerticalPadding = 12
			' 
			' xpTaskBarBox1
			' 
			Me.xpTaskBarBox1.ForeColor = System.Drawing.Color.Black
			Me.xpTaskBarBox1.HeaderFont = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox1.HeaderImageIndex = -1
			Me.xpTaskBarBox1.HitTaskBoxArea = False
			Me.xpTaskBarBox1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPTaskBarItem() { New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Inbox", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem0", New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161))), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Unread Mail", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem1", New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(161))), 0), New Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Sent Items", System.Drawing.Color.Empty, -1, Nothing, "", True, True, "XPTaskBarItem2", New System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161))), 0)})
			Me.xpTaskBarBox1.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
			Me.xpTaskBarBox1.Size = New System.Drawing.Size(194, 79)
			Me.xpTaskBarBox1.TabIndex = 0
			Me.xpTaskBarBox1.Text = "Favourite Folder"
'			Me.xpTaskBarBox1.ItemClick += New Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickHandler(Me.xpTaskBarBox1_ItemClick)
			' 
			' xpTaskBarBox2
			' 
			Me.xpTaskBarBox2.Controls.Add(Me.panel1)
			Me.xpTaskBarBox2.HeaderFont = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox2.HeaderImageIndex = -1
			Me.xpTaskBarBox2.HitTaskBoxArea = False
			Me.xpTaskBarBox2.Location = New System.Drawing.Point(0, 91)
			Me.xpTaskBarBox2.Name = "xpTaskBarBox2"
			Me.xpTaskBarBox2.PreferredChildPanelHeight = 150
			Me.xpTaskBarBox2.Size = New System.Drawing.Size(194, 174)
			Me.xpTaskBarBox2.TabIndex = 1
			Me.xpTaskBarBox2.Text = "Mail Folders"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.treeView3)
			Me.panel1.Location = New System.Drawing.Point(2, 22)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(190, 150)
			Me.panel1.TabIndex = 0
			' 
			' treeView3
			' 
			Me.treeView3.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.treeView3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeView3.Font = New System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.treeView3.ImageIndex = 0
			Me.treeView3.ImageList = Me.smallImageList
			Me.treeView3.Indent = 25
			Me.treeView3.Location = New System.Drawing.Point(0, 0)
			Me.treeView3.Name = "treeView3"
			treeNode1.ImageIndex = 1
			treeNode1.Name = ""
			treeNode1.SelectedImageIndex = 1
			treeNode1.Text = "Deleted Items"
			treeNode2.ImageIndex = 0
			treeNode2.Name = ""
			treeNode2.SelectedImageIndex = 0
			treeNode2.Text = "Junk Email"
			treeNode3.ImageIndex = 2
			treeNode3.Name = ""
			treeNode3.SelectedImageIndex = 2
			treeNode3.Text = "Inbox"
			treeNode4.ImageIndex = 6
			treeNode4.Name = ""
			treeNode4.SelectedImageIndex = 6
			treeNode4.Text = "Sent Items"
			treeNode5.ImageIndex = 4
			treeNode5.Name = ""
			treeNode5.SelectedImageIndex = 4
			treeNode5.Text = "Search Folders"
			treeNode6.ImageIndex = 7
			treeNode6.Name = ""
			treeNode6.SelectedImageIndex = 7
			treeNode6.Text = "Personal Folders"
			treeNode7.ImageIndex = 4
			treeNode7.Name = ""
			treeNode7.SelectedImageIndex = 4
			treeNode7.Text = "Search Folders"
			treeNode8.ImageIndex = 6
			treeNode8.Name = ""
			treeNode8.SelectedImageIndex = 6
			treeNode8.Text = "Sent Items"
			treeNode9.ImageIndex = 1
			treeNode9.Name = ""
			treeNode9.SelectedImageIndex = 1
			treeNode9.Text = "Deleted Items"
			treeNode10.ImageIndex = 8
			treeNode10.Name = ""
			treeNode10.SelectedImageIndex = 8
			treeNode10.Text = "Archive Folders"
			treeNode11.ImageIndex = 5
			treeNode11.Name = ""
			treeNode11.SelectedImageIndex = 5
			treeNode11.Text = "Drafts"
			treeNode12.ImageIndex = 2
			treeNode12.Name = ""
			treeNode12.SelectedImageIndex = 2
			treeNode12.Text = "Inbox"
			treeNode13.ImageIndex = 3
			treeNode13.Name = ""
			treeNode13.SelectedImageIndex = 3
			treeNode13.Text = "Outbox"
			treeNode14.ImageIndex = 6
			treeNode14.Name = ""
			treeNode14.SelectedImageIndex = 6
			treeNode14.Text = "Sent Items"
			treeNode15.Name = ""
			treeNode15.Text = "Public"
			treeNode16.ImageIndex = 8
			treeNode16.Name = ""
			treeNode16.SelectedImageIndex = 8
			treeNode16.Text = "Syncfusion Email"
			Me.treeView3.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode6, treeNode10, treeNode16})
			Me.treeView3.SelectedImageIndex = 0
			Me.treeView3.ShowLines = False
			Me.treeView3.Size = New System.Drawing.Size(190, 150)
			Me.treeView3.TabIndex = 6
			' 
			' smallImageList
			' 
			Me.smallImageList.ImageStream = (CType(resources.GetObject("smallImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.smallImageList.TransparentColor = System.Drawing.Color.Transparent
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
			Me.smallImageList.Images.SetKeyName(34, "")
			Me.smallImageList.Images.SetKeyName(35, "")
			Me.smallImageList.Images.SetKeyName(36, "")
			Me.smallImageList.Images.SetKeyName(37, "")
			Me.smallImageList.Images.SetKeyName(38, "")
			Me.smallImageList.Images.SetKeyName(39, "")
			Me.smallImageList.Images.SetKeyName(40, "")
			Me.smallImageList.Images.SetKeyName(41, "")
			Me.smallImageList.Images.SetKeyName(42, "")
			Me.smallImageList.Images.SetKeyName(43, "")
			Me.smallImageList.Images.SetKeyName(44, "")
			Me.smallImageList.Images.SetKeyName(45, "")
			Me.smallImageList.Images.SetKeyName(46, "")
			Me.smallImageList.Images.SetKeyName(47, "today.png")
			' 
			' groupBarItem1
			' 
			Me.groupBarItem1.Client = Nothing
			Me.groupBarItem1.Icon = (CType(resources.GetObject("groupBarItem1.Icon"), System.Drawing.Icon))
			Me.groupBarItem1.Text = "Mail"
			' 
			' groupBarItem2
			' 
			Me.groupBarItem2.Client = Me.panel2
			Me.groupBarItem2.Icon = (CType(resources.GetObject("groupBarItem2.Icon"), System.Drawing.Icon))
			Me.groupBarItem2.Text = "Calendar"
			' 
			' dateTimePickerAdv1
			' 
			Me.dateTimePickerAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.dateTimePickerAdv1.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(171))))), (CInt(Fix((CByte(193))))), (CInt(Fix((CByte(222))))))
			Me.dateTimePickerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			' 
			' 
			' 
			Me.dateTimePickerAdv1.Calendar.AllowMultipleSelection = False
			Me.dateTimePickerAdv1.Calendar.Culture = New System.Globalization.CultureInfo("en-US")
			Me.dateTimePickerAdv1.Calendar.DaysFont = New System.Drawing.Font("Verdana", 8F)
			Me.dateTimePickerAdv1.Calendar.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dateTimePickerAdv1.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.dateTimePickerAdv1.Calendar.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.dateTimePickerAdv1.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None
			Me.dateTimePickerAdv1.Calendar.HeaderEndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(255))))))
			Me.dateTimePickerAdv1.Calendar.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.dateTimePickerAdv1.Calendar.HeaderHeight = 20
			Me.dateTimePickerAdv1.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(179))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(252))))))
			Me.dateTimePickerAdv1.Calendar.HeadForeColor = System.Drawing.SystemColors.ControlText
			Me.dateTimePickerAdv1.Calendar.HeadGradient = True
			Me.dateTimePickerAdv1.Calendar.Location = New System.Drawing.Point(0, 0)
			Me.dateTimePickerAdv1.Calendar.Name = "monthCalendar"
			Me.dateTimePickerAdv1.Calendar.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.dateTimePickerAdv1.Calendar.ScrollButtonSize = New System.Drawing.Size(24, 24)
			Me.dateTimePickerAdv1.Calendar.SelectedDates = New System.DateTime(){}
			Me.dateTimePickerAdv1.Calendar.Size = New System.Drawing.Size(206, 174)
			Me.dateTimePickerAdv1.Calendar.SizeToFit = True
			Me.dateTimePickerAdv1.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.dateTimePickerAdv1.Calendar.TabIndex = 0
			Me.dateTimePickerAdv1.Calendar.WeekFont = New System.Drawing.Font("Verdana", 8F)
			Me.dateTimePickerAdv1.Calendar.WeekInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite)
			' 
			' 
			' 
			Me.dateTimePickerAdv1.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.dateTimePickerAdv1.Calendar.NoneButton.Location = New System.Drawing.Point(134, 0)
			Me.dateTimePickerAdv1.Calendar.NoneButton.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.dateTimePickerAdv1.Calendar.NoneButton.Size = New System.Drawing.Size(72, 20)
			Me.dateTimePickerAdv1.Calendar.NoneButton.Text = "None"
			Me.dateTimePickerAdv1.Calendar.NoneButton.UseVisualStyle = True
			' 
			' 
			' 
			Me.dateTimePickerAdv1.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.dateTimePickerAdv1.Calendar.TodayButton.Location = New System.Drawing.Point(0, 0)
			Me.dateTimePickerAdv1.Calendar.TodayButton.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.dateTimePickerAdv1.Calendar.TodayButton.Size = New System.Drawing.Size(134, 20)
			Me.dateTimePickerAdv1.Calendar.TodayButton.Text = "Today"
			Me.dateTimePickerAdv1.Calendar.TodayButton.UseVisualStyle = True
			Me.dateTimePickerAdv1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.dateTimePickerAdv1.CalendarForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.dateTimePickerAdv1.CalendarTitleBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(179))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(252))))))
			Me.dateTimePickerAdv1.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText
			Me.dateTimePickerAdv1.Dock = System.Windows.Forms.DockStyle.Top
			Me.dateTimePickerAdv1.DropDownImage = Nothing
			Me.dateTimePickerAdv1.Location = New System.Drawing.Point(0, 0)
			Me.dateTimePickerAdv1.MinValue = New System.DateTime((CLng(Fix(0))))
			Me.dateTimePickerAdv1.Name = "dateTimePickerAdv1"
			Me.dateTimePickerAdv1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.dateTimePickerAdv1.ShowCheckBox = False
			Me.dateTimePickerAdv1.Size = New System.Drawing.Size(229, 20)
			Me.dateTimePickerAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.dateTimePickerAdv1.TabIndex = 1
			Me.dateTimePickerAdv1.Value = New System.DateTime(2008, 3, 20, 3, 6, 53, 612)
			' 
			' gradientPanel2
			' 
			Me.gradientPanel2.BorderColor = System.Drawing.Color.Black
			Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel2.Controls.Add(Me.checkBox1)
			Me.gradientPanel2.Controls.Add(Me.linkLabel13)
			Me.gradientPanel2.Controls.Add(Me.linkLabel14)
			Me.gradientPanel2.Location = New System.Drawing.Point(2, 27)
			Me.gradientPanel2.Name = "gradientPanel2"
			Me.gradientPanel2.Size = New System.Drawing.Size(220, 113)
			Me.gradientPanel2.TabIndex = 0
			' 
			' checkBox1
			' 
			Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.checkBox1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.checkBox1.Location = New System.Drawing.Point(24, 64)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(120, 16)
			Me.checkBox1.TabIndex = 20
			Me.checkBox1.Text = "Show at startup"
			' 
			' linkLabel13
			' 
			Me.linkLabel13.Image = (CType(resources.GetObject("linkLabel13.Image"), System.Drawing.Image))
			Me.linkLabel13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.linkLabel13.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.linkLabel13.Location = New System.Drawing.Point(16, 40)
			Me.linkLabel13.Name = "linkLabel13"
			Me.linkLabel13.Size = New System.Drawing.Size(128, 16)
			Me.linkLabel13.TabIndex = 18
			Me.linkLabel13.TabStop = True
			Me.linkLabel13.Text = "Microsoft Word Help"
			Me.linkLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' linkLabel14
			' 
			Me.linkLabel14.Image = (CType(resources.GetObject("linkLabel14.Image"), System.Drawing.Image))
			Me.linkLabel14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.linkLabel14.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.linkLabel14.Location = New System.Drawing.Point(16, 16)
			Me.linkLabel14.Name = "linkLabel14"
			Me.linkLabel14.Size = New System.Drawing.Size(128, 16)
			Me.linkLabel14.TabIndex = 19
			Me.linkLabel14.TabStop = True
			Me.linkLabel14.Text = "Add Network Place..."
			Me.linkLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleRight

			Me.wizardContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.wizardContainer1.Location = New System.Drawing.Point(0, 22)
			Me.wizardContainer1.Name = "wizardContainer1"
			Me.wizardContainer1.Size = New System.Drawing.Size(229, 369)
			Me.wizardContainer1.TabIndex = 6

			' 
			' panel4
			' 
			Me.panel4.BackColor = System.Drawing.Color.Transparent
			Me.panel4.Controls.Add(Me.label3)
			Me.panel4.Controls.Add(Me.gradientPanel1)
			Me.panel4.Location = New System.Drawing.Point(0, 0)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(229, 26)
			Me.panel4.TabIndex = 59
			' 
			' label3
			' 
			Me.label3.BackColor = System.Drawing.Color.Transparent
			Me.label3.Dock = System.Windows.Forms.DockStyle.Left
			Me.label3.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.label3.Location = New System.Drawing.Point(0, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(102, 26)
			Me.label3.TabIndex = 42
			Me.label3.Text = "Recent Search"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.BorderColor = System.Drawing.Color.Black
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel1.Controls.Add(Me.buttonEdit1)
			Me.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Right
			Me.gradientPanel1.Location = New System.Drawing.Point(111, 0)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(118, 26)
			Me.gradientPanel1.TabIndex = 57
			' 
			' buttonEdit1
			' 
			Me.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.buttonEdit1.Buttons.Add(Me.buttonEditChildButton1)
			Me.buttonEdit1.Buttons.Add(Me.buttonEditChildButton2)
			Me.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonEdit1.Controls.Add(Me.buttonEditChildButton2)
			Me.buttonEdit1.Controls.Add(Me.buttonEditChildButton1)
			Me.buttonEdit1.Location = New System.Drawing.Point(0, 0)
			Me.buttonEdit1.Name = "buttonEdit1"
			Me.buttonEdit1.ShowTextBox = False
			Me.buttonEdit1.Size = New System.Drawing.Size(116, 26)
			Me.buttonEdit1.TabIndex = 0
			Me.buttonEdit1.UseVisualStyle = True
			' 
			' buttonEditChildButton1
			' 
			Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton1.Image = (CType(resources.GetObject("buttonEditChildButton1.Image"), System.Drawing.Image))
			Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
			Me.buttonEditChildButton1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.buttonEditChildButton1.PreferredWidth = 18
			Me.buttonEditChildButton1.TabIndex = 1
			' 
			' buttonEditChildButton2
			' 
			Me.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight
			Me.buttonEditChildButton2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down
			Me.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window
			Me.buttonEditChildButton2.Image = (CType(resources.GetObject("buttonEditChildButton2.Image"), System.Drawing.Image))
			Me.buttonEditChildButton2.Name = "buttonEditChildButton2"
			Me.buttonEditChildButton2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.buttonEditChildButton2.PreferredWidth = 15
			Me.buttonEditChildButton2.TabIndex = 2
			' 
			' multiColumnComboBox1
			' 
			Me.multiColumnComboBox1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
			Me.multiColumnComboBox1.IgnoreThemeBackground = True
			Me.multiColumnComboBox1.Location = New System.Drawing.Point(33, 284)
			Me.multiColumnComboBox1.Name = "multiColumnComboBox1"
			Me.multiColumnComboBox1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.multiColumnComboBox1.Size = New System.Drawing.Size(156, 21)
			Me.multiColumnComboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.multiColumnComboBox1.TabIndex = 58
			Me.multiColumnComboBox1.Text = "Selected Locations"
			' 
			' textBoxExt2
			' 
			Me.textBoxExt2.Location = New System.Drawing.Point(27, 83)
			Me.textBoxExt2.Name = "textBoxExt2"
			Me.textBoxExt2.OverflowIndicatorToolTipText = Nothing
			Me.textBoxExt2.Size = New System.Drawing.Size(161, 20)
			Me.textBoxExt2.TabIndex = 41
			' 
			' comboBoxBase1
			' 
			Me.comboBoxBase1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(251))))))
			Me.comboBoxBase1.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.comboBoxBase1.IgnoreThemeBackground = True
			Me.comboBoxBase1.Location = New System.Drawing.Point(33, 236)
			Me.comboBoxBase1.Name = "comboBoxBase1"
			Me.comboBoxBase1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.comboBoxBase1.Size = New System.Drawing.Size(156, 22)
			Me.comboBoxBase1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.comboBoxBase1.TabIndex = 0
			Me.comboBoxBase1.Text = "Selected Locations"
			' 
			' buttonAdv6
			' 
			Me.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.buttonAdv6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.buttonAdv6.KeepFocusRectangle = False
			Me.buttonAdv6.Location = New System.Drawing.Point(116, 115)
			Me.buttonAdv6.Name = "buttonAdv6"
			Me.buttonAdv6.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.buttonAdv6.Size = New System.Drawing.Size(72, 23)
			Me.buttonAdv6.TabIndex = 55
			Me.buttonAdv6.Text = "Restore"
			Me.buttonAdv6.UseVisualStyle = True
			' 
			' buttonAdv5
			' 
			Me.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.buttonAdv5.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.buttonAdv5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.buttonAdv5.KeepFocusRectangle = False
			Me.buttonAdv5.Location = New System.Drawing.Point(27, 115)
			Me.buttonAdv5.Name = "buttonAdv5"
			Me.buttonAdv5.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.buttonAdv5.Size = New System.Drawing.Size(72, 23)
			Me.buttonAdv5.TabIndex = 54
			Me.buttonAdv5.Text = "Search"
			Me.buttonAdv5.UseVisualStyle = True
			' 
			' label31
			' 
			Me.label31.BackColor = System.Drawing.Color.MidnightBlue
			Me.label31.Location = New System.Drawing.Point(30, 195)
			Me.label31.Name = "label31"
			Me.label31.Size = New System.Drawing.Size(170, 1)
			Me.label31.TabIndex = 50
			' 
			' label11
			' 
			Me.label11.BackColor = System.Drawing.Color.Transparent
			Me.label11.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.label11.Location = New System.Drawing.Point(30, 265)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(100, 16)
			Me.label11.TabIndex = 46
			Me.label11.Text = "Results should be:"
			' 
			' linkLabel15
			' 
			Me.linkLabel15.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel15.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.linkLabel15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.linkLabel15.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.linkLabel15.Location = New System.Drawing.Point(27, 147)
			Me.linkLabel15.Name = "linkLabel15"
			Me.linkLabel15.Size = New System.Drawing.Size(96, 16)
			Me.linkLabel15.TabIndex = 56
			Me.linkLabel15.TabStop = True
			Me.linkLabel15.Text = "Search Tips..."
			Me.linkLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' linkLabel16
			' 
			Me.linkLabel16.BackColor = System.Drawing.Color.Transparent
			Me.linkLabel16.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.linkLabel16.LinkColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.linkLabel16.Location = New System.Drawing.Point(30, 345)
			Me.linkLabel16.Name = "linkLabel16"
			Me.linkLabel16.Size = New System.Drawing.Size(96, 16)
			Me.linkLabel16.TabIndex = 48
			Me.linkLabel16.TabStop = True
			Me.linkLabel16.Text = "Search options..."
			' 
			' label9
			' 
			Me.label9.BackColor = System.Drawing.Color.Transparent
			Me.label9.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label9.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.label9.Location = New System.Drawing.Point(30, 179)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(136, 16)
			Me.label9.TabIndex = 44
			Me.label9.Text = "Other Search Options:"
			' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.BackColor = System.Drawing.Color.Transparent
			Me.label12.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.label12.Location = New System.Drawing.Point(30, 321)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(171, 13)
			Me.label12.TabIndex = 47
			Me.label12.Text = "Fast searching is currently disabled"
			' 
			' label8
			' 
			Me.label8.BackColor = System.Drawing.Color.Transparent
			Me.label8.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.label8.Location = New System.Drawing.Point(27, 64)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(100, 16)
			Me.label8.TabIndex = 43
			Me.label8.Text = "Search text:"
			' 
			' label10
			' 
			Me.label10.BackColor = System.Drawing.Color.Transparent
			Me.label10.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(73))))), (CInt(Fix((CByte(148))))))
			Me.label10.Location = New System.Drawing.Point(30, 217)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(100, 16)
			Me.label10.TabIndex = 45
			Me.label10.Text = "Search in:"
			' 
			' xpTaskPage2
			' 
			Me.xpTaskPage2.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(99))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(206))))))
			Me.xpTaskPage2.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xpTaskPage2.Controls.Add(Me.fontListBox1)
			Me.xpTaskPage2.Controls.Add(Me.label5)
			Me.xpTaskPage2.Controls.Add(Me.label6)
			Me.xpTaskPage2.Controls.Add(Me.fontComboBox1)
			Me.xpTaskPage2.Controls.Add(Me.label32)
			Me.xpTaskPage2.Controls.Add(Me.label4)
			Me.xpTaskPage2.LayoutName = "Card2"
			Me.xpTaskPage2.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskPage2.Name = "xpTaskPage2"
			Me.xpTaskPage2.NextPage = Nothing
			Me.xpTaskPage2.PreviousPage = Nothing
			Me.xpTaskPage2.Size = New System.Drawing.Size(229, 369)
			Me.xpTaskPage2.TabIndex = 1
			Me.xpTaskPage2.Title = "Styles And Formatting"
			' 
			' fontListBox1
			' 
			Me.fontListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.fontListBox1.FormattingEnabled = True
			Me.fontListBox1.ItemHeight = 15
			Me.fontListBox1.Location = New System.Drawing.Point(19, 146)
			Me.fontListBox1.Name = "fontListBox1"
			Me.fontListBox1.Size = New System.Drawing.Size(182, 227)
			Me.fontListBox1.TabIndex = 33
			' 
			' label5
			' 
			Me.label5.BackColor = System.Drawing.Color.Black
			Me.label5.Location = New System.Drawing.Point(16, 120)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(185, 1)
			Me.label5.TabIndex = 32
			' 
			' label6
			' 
			Me.label6.BackColor = System.Drawing.Color.Transparent
			Me.label6.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.ForeColor = System.Drawing.Color.Black
			Me.label6.Location = New System.Drawing.Point(16, 104)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(160, 16)
			Me.label6.TabIndex = 31
			Me.label6.Text = "Font for Normal Text"
			' 
			' fontComboBox1
			' 
			Me.fontComboBox1.FormattingEnabled = True
			Me.fontComboBox1.Location = New System.Drawing.Point(19, 64)
			Me.fontComboBox1.Name = "fontComboBox1"
			Me.fontComboBox1.Office2007ColorTheme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.fontComboBox1.Size = New System.Drawing.Size(182, 21)
			Me.fontComboBox1.TabIndex = 30
			Me.fontComboBox1.VisualStyle = Syncfusion.Windows.Forms.Tools.ThemedComboBoxStyles.Office2007
			' 
			' label32
			' 
			Me.label32.BackColor = System.Drawing.Color.Black
			Me.label32.Location = New System.Drawing.Point(16, 45)
			Me.label32.Name = "label32"
			Me.label32.Size = New System.Drawing.Size(185, 1)
			Me.label32.TabIndex = 29
			' 
			' label4
			' 
			Me.label4.BackColor = System.Drawing.Color.Transparent
			Me.label4.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.ForeColor = System.Drawing.Color.Black
			Me.label4.Location = New System.Drawing.Point(16, 29)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(160, 16)
			Me.label4.TabIndex = 28
			Me.label4.Text = "Font for selected text"
			' 
			' xpTaskPage3
			' 
			Me.xpTaskPage3.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(99))))), (CInt(Fix((CByte(146))))), (CInt(Fix((CByte(206))))))
			Me.xpTaskPage3.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.xpTaskPage3.Controls.Add(Me.calculatorControl1)
			Me.xpTaskPage3.Controls.Add(Me.dateTimePickerAdv1)
			Me.xpTaskPage3.LayoutName = "Card3"
			Me.xpTaskPage3.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskPage3.Name = "xpTaskPage3"
			Me.xpTaskPage3.NextPage = Nothing
			Me.xpTaskPage3.PreviousPage = Nothing
			Me.xpTaskPage3.Size = New System.Drawing.Size(229, 369)
			Me.xpTaskPage3.TabIndex = 2
			Me.xpTaskPage3.Title = "Calculations"
			' 
			' calculatorControl1
			' 
			Me.calculatorControl1.AccessibleDescription = "Calculator control"
			Me.calculatorControl1.AccessibleName = "Calculator Control"
			Me.calculatorControl1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(179))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(252))))))
			Me.calculatorControl1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(179))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(252)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(255)))))))
			Me.calculatorControl1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust
			Me.calculatorControl1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.calculatorControl1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.calculatorControl1.DoubleValue = 0
			Me.calculatorControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.calculatorControl1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.calculatorControl1.HorizontalSpacing = 5
			Me.calculatorControl1.Location = New System.Drawing.Point(1, 99)
			Me.calculatorControl1.Name = "calculatorControl1"
			Me.calculatorControl1.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.calculatorControl1.RepeatAssignAction = True
			Me.calculatorControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.calculatorControl1.Size = New System.Drawing.Size(228, 210)
			Me.calculatorControl1.TabIndex = 4
			Me.calculatorControl1.Text = "calculatorControl1"
			Me.calculatorControl1.ThemesEnabled = True
			Me.calculatorControl1.UseUserOverride = True
			Me.calculatorControl1.UseVisualStyle = True
			Me.calculatorControl1.VerticalSpacing = 3
			' 
			' scrollersFrame1
			' 
			Me.scrollersFrame1.AttachedTo = Me.fontListBox1
			Me.scrollersFrame1.HorizontalSmallChange = 7
			Me.scrollersFrame1.OfficeColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Managed
			Me.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto
			Me.scrollersFrame1.VerticallSmallChange = 13
			Me.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(881, 580)
			Me.Controls.Add(Me.statusStripEx1)
			Me.Controls.Add(Me.tabBarSplitterControl1)

			Me.Controls.Add(Me.groupBar1)
			Me.Controls.Add(Me.ribbonControlAdv1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Office 2007 Custom Colors"
			CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ribbonControlAdv1.ResumeLayout(False)
			Me.ribbonControlAdv1.PerformLayout()
			Me.toolStripTabItem1.Panel.ResumeLayout(False)
			Me.toolStripTabItem1.Panel.PerformLayout()
			Me.clipboardToolStripExt.ResumeLayout(False)
			Me.clipboardToolStripExt.PerformLayout()
			Me.fontToolStripExt.ResumeLayout(False)
			Me.fontToolStripExt.PerformLayout()
			Me.paragraphToolStripExt.ResumeLayout(False)
			Me.paragraphToolStripExt.PerformLayout()
			Me.stylesToolStripExt.ResumeLayout(False)
			Me.stylesToolStripExt.PerformLayout()
			Me.toolStripEx1.ResumeLayout(False)
			Me.toolStripEx1.PerformLayout()
			Me.toolStripEx2.ResumeLayout(False)
			Me.toolStripEx2.PerformLayout()
			Me.tabBarSplitterControl1.ResumeLayout(False)
			Me.tabBarPage1.ResumeLayout(False)
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel3.ResumeLayout(False)
			Me.statusStripEx1.ResumeLayout(False)
			Me.statusStripEx1.PerformLayout()
			CType(Me.groupBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBar1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.monthCalendarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButtonAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioButtonAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel3.ResumeLayout(False)
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar1.ResumeLayout(False)
			Me.xpTaskBarBox2.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			CType(Me.dateTimePickerAdv1.Calendar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dateTimePickerAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel2.ResumeLayout(False)

			Me.wizardContainer1.ResumeLayout(False)
			CType(Me.xpTaskPage1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskPage1.ResumeLayout(False)
			Me.xpTaskPage1.PerformLayout()
			Me.panel4.ResumeLayout(False)
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.buttonEdit1.ResumeLayout(False)
			Me.buttonEdit1.PerformLayout()
			CType(Me.multiColumnComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.comboBoxBase1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpTaskPage2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskPage2.ResumeLayout(False)
			CType(Me.xpTaskPage3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskPage3.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents ribbonControlAdv1 As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
		Private tabBarSplitterControl1 As Syncfusion.Windows.Forms.TabBarSplitterControl
		Private tabBarPage1 As Syncfusion.Windows.Forms.TabBarPage
		Private statusStripEx1 As Syncfusion.Windows.Forms.Tools.StatusStripEx
		Private toolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private paragraphToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private lAlignToolStripBtn As System.Windows.Forms.ToolStripButton
		Private centerToolStripBtn As System.Windows.Forms.ToolStripButton
		Private rAlignToolStripBtn As System.Windows.Forms.ToolStripButton
		Private justifyToolStripBtn As System.Windows.Forms.ToolStripButton
		Private lspacingToolStripDropDwnBtn As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
		Private moreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
		Private addSpaceBeforeParagraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private removeSpaceAfterParagraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private shadingToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
		Private noColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
		Private moreShadingColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private btmborderToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
		Private bottomBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private topBoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private leftBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private rightBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private noBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private allBordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private outsideBordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private insideBordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private insideHorizontalBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private insideVerticalBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private diagonalDownBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private diagonalUpBorderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
		Private horizontalLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
		Private showGridlinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private bordersAndShadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private changeListLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private defineNewBulletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private changeListLevelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private defineNewNumberFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private setNumberingValueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private changeListLevelToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
		Private defineNewMultilevelListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private defineNewListStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private clipboardToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem15 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripBtnPaste As System.Windows.Forms.ToolStripButton
		Private toolStripDropDownBtnPaste As System.Windows.Forms.ToolStripDropDownButton
		Private pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private pasteSpecialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private pasteAsHyperlinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem1 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripBtnCut As System.Windows.Forms.ToolStripButton
		Private toolStripBtnCopy As System.Windows.Forms.ToolStripButton
		Private toolStripBtnPaint As System.Windows.Forms.ToolStripButton
		Private fontToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem2 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripFontfaceComboBox As System.Windows.Forms.ToolStripComboBox
		Private toolStripFontSizeComboBox As System.Windows.Forms.ToolStripComboBox
		Private toolStripPanelItem3 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem4 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private boldToolstripBtn As System.Windows.Forms.ToolStripButton
		Private italicToolStripBtn As System.Windows.Forms.ToolStripButton
		Private underlineToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
		Private strikethroToolStripBtn As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem6 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private txthighltToolStripsplitBtn As System.Windows.Forms.ToolStripSplitButton
		Private fontcolorToolStripSplitBtn As System.Windows.Forms.ToolStripSplitButton
		Private moreUnderlinesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private underlineColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private automaticToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private moreColorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private noColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
		Private stopHighlightingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private automaticToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private themeColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private moreColorsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
		Private toolStripPanelItem5 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private stylesToolStripExt As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripGallery1 As Syncfusion.Windows.Forms.Tools.ToolStripGallery
		Private groupBar1 As Syncfusion.Windows.Forms.Tools.GroupBar
		Private groupBarItem1 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem2 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private xpTaskBar1 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private WithEvents xpTaskBarBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private xpTaskBarBox2 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private treeView3 As System.Windows.Forms.TreeView
		Private smallImageList As System.Windows.Forms.ImageList
		Private panel1 As System.Windows.Forms.Panel
		Private panel2 As System.Windows.Forms.Panel
		Private monthCalendarAdv1 As Syncfusion.Windows.Forms.Tools.MonthCalendarAdv
		Private dateTimePickerAdv1 As Syncfusion.Windows.Forms.Tools.DateTimePickerAdv
		Private radioButtonAdv2 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private radioButtonAdv1 As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private panel3 As System.Windows.Forms.Panel
		Private WithEvents colorPickerUIAdv1 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private checkBox1 As System.Windows.Forms.CheckBox
		Private linkLabel13 As System.Windows.Forms.LinkLabel
		Private linkLabel14 As System.Windows.Forms.LinkLabel
		Private xpTaskPane1 As Syncfusion.Windows.Forms.Tools.XPTaskPane
		Private wizardContainer1 As Syncfusion.Windows.Forms.Tools.WizardContainer
		Private xpTaskPage1 As Syncfusion.Windows.Forms.Tools.XPTaskPage
		Private textBoxExt2 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private buttonAdv6 As Syncfusion.Windows.Forms.ButtonAdv
		Private buttonAdv5 As Syncfusion.Windows.Forms.ButtonAdv
		Private label31 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private linkLabel15 As System.Windows.Forms.LinkLabel
		Private linkLabel16 As System.Windows.Forms.LinkLabel
		Private label9 As System.Windows.Forms.Label
		Private label12 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private xpTaskPage2 As Syncfusion.Windows.Forms.Tools.XPTaskPage
		Private fontComboBox1 As Syncfusion.Windows.Forms.Tools.FontComboBox
		Private label32 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private fontListBox1 As Syncfusion.Windows.Forms.Tools.FontListBox
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private buttonEdit1 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton1 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private buttonEditChildButton2 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private comboBoxBase1 As Syncfusion.Windows.Forms.Tools.ComboBoxBase
		Private xpTaskPage3 As Syncfusion.Windows.Forms.Tools.XPTaskPage
		Private calculatorControl1 As Syncfusion.Windows.Forms.Tools.CalculatorControl
		Private multiColumnComboBox1 As Syncfusion.Windows.Forms.Tools.MultiColumnComboBox
		Private toolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
		Private trackBarItem1 As Syncfusion.Windows.Forms.Tools.TrackBarItem
		Private toolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private scrollersFrame1 As Syncfusion.Windows.Forms.ScrollersFrame
		Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private panel4 As System.Windows.Forms.Panel
		Private toolStripEx2 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
		Private toolStripLabel1 As System.Windows.Forms.ToolStripLabel
		Private toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
		Private toolStripButton5 As System.Windows.Forms.ToolStripButton
		Private toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private toolStripButton6 As System.Windows.Forms.ToolStripButton
		Private gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private richTextBox1 As System.Windows.Forms.RichTextBox
		Private statusStripLabel1 As Syncfusion.Windows.Forms.Tools.StatusStripLabel
		Private toolStripLabel2 As System.Windows.Forms.ToolStripLabel
	End Class
End Namespace

