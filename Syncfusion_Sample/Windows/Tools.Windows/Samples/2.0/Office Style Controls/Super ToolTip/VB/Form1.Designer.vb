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
Namespace SuperToolTipDemo_2005
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
            Me.components = New System.ComponentModel.Container
            Dim ToolTipInfo7 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo8 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo9 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo10 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo11 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo12 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo13 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo14 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo15 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo4 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo5 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo6 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo3 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo16 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim ToolTipInfo2 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim ToolTipInfo1 As Syncfusion.Windows.Forms.Tools.ToolTipInfo = New Syncfusion.Windows.Forms.Tools.ToolTipInfo
            Me.superToolTip1 = New Syncfusion.Windows.Forms.Tools.SuperToolTip(Me)
            Me.newToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.openToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.saveToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.printToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.cutToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.copyToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.pasteToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.helpToolStripButton = New System.Windows.Forms.ToolStripButton
            Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.newToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.openToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.saveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
            Me.printToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.printPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
            Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.gradientLabel2 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.gradientLabel3 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.Label4 = New System.Windows.Forms.Label
            Me.helpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.contentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.indexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.searchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
            Me.aboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.CheckBox1 = New System.Windows.Forms.CheckBox
            Me.buttonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip
            Me.toolStrip1 = New System.Windows.Forms.ToolStrip
            Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.statusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx
            Me.StatusStripLabel1 = New Syncfusion.Windows.Forms.Tools.StatusStripLabel
            Me.gradientPanelExt1 = New Syncfusion.Windows.Forms.Tools.GradientPanelExt
            Me.gradientLabel6 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.label3 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.textBox2 = New System.Windows.Forms.TextBox
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.textBox3 = New System.Windows.Forms.TextBox
            Me.textPrimitive1 = New Syncfusion.Windows.Forms.Tools.TextPrimitive
            Me.popupControlContainer1 = New Syncfusion.Windows.Forms.PopupControlContainer(Me.components)
            Me.ColorPickerUIAdv2 = New Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.groupBox3 = New System.Windows.Forms.GroupBox
            Me.GroupBox4 = New System.Windows.Forms.GroupBox
            Me.Label5 = New System.Windows.Forms.Label
            Me.ComboBox1 = New System.Windows.Forms.ComboBox
            Me.GradientLabel4 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.menuStrip1.SuspendLayout()
            Me.toolStrip1.SuspendLayout()
            Me.statusStripEx1.SuspendLayout()
            CType(Me.gradientPanelExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanelExt1.SuspendLayout()
            Me.popupControlContainer1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.GroupBox4.SuspendLayout()
            Me.SuspendLayout()
            '
            'superToolTip1
            '
            Me.superToolTip1.InitialDelay = 1000
            Me.superToolTip1.ToolTipDuration = 5
            '
            'newToolStripButton
            '
            Me.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.newToolStripButton.Image = CType(resources.GetObject("newToolStripButton.Image"), System.Drawing.Image)
            Me.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.newToolStripButton.Name = "newToolStripButton"
            Me.newToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.newToolStripButton.Text = "&New"
            ToolTipInfo7.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(213, Byte), Integer))
            ToolTipInfo7.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo7.Body.Text = "Opens a new document"
            ToolTipInfo7.Body.TextMargin = New System.Windows.Forms.Padding(5)
            ToolTipInfo7.Footer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo7.Footer.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
            ToolTipInfo7.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo7.Footer.Text = "Press F1 for help"
            ToolTipInfo7.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo7.Header.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
            ToolTipInfo7.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo7.Header.Text = "New (Ctrl+N)"
            Me.superToolTip1.SetToolTip(Me.newToolStripButton, ToolTipInfo7)
            '
            'openToolStripButton
            '
            Me.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.openToolStripButton.Image = CType(resources.GetObject("openToolStripButton.Image"), System.Drawing.Image)
            Me.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.openToolStripButton.Name = "openToolStripButton"
            Me.openToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.openToolStripButton.Text = "&Open"
            ToolTipInfo8.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(71, Byte), Integer))
            ToolTipInfo8.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo8.Body.Text = "Opens an existing document"
            ToolTipInfo8.Body.TextMargin = New System.Windows.Forms.Padding(5)
            ToolTipInfo8.Footer.Hidden = True
            ToolTipInfo8.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo8.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo8.Header.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
            ToolTipInfo8.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo8.Header.Text = "Open (Ctrl+O)"
            ToolTipInfo8.Separator = False
            Me.superToolTip1.SetToolTip(Me.openToolStripButton, ToolTipInfo8)
            '
            'saveToolStripButton
            '
            Me.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.saveToolStripButton.Image = CType(resources.GetObject("saveToolStripButton.Image"), System.Drawing.Image)
            Me.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.saveToolStripButton.Name = "saveToolStripButton"
            Me.saveToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.saveToolStripButton.Text = "&Save"
            ToolTipInfo9.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(0, Byte), Integer))
            ToolTipInfo9.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo9.Body.Text = "Save the document"
            ToolTipInfo9.Body.TextMargin = New System.Windows.Forms.Padding(5)
            ToolTipInfo9.Footer.Hidden = True
            ToolTipInfo9.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo9.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo9.Header.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
            ToolTipInfo9.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo9.Header.Text = "Save (Ctrl+S)"
            ToolTipInfo9.Separator = False
            Me.superToolTip1.SetToolTip(Me.saveToolStripButton, ToolTipInfo9)
            '
            'printToolStripButton
            '
            Me.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.printToolStripButton.Image = CType(resources.GetObject("printToolStripButton.Image"), System.Drawing.Image)
            Me.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.printToolStripButton.Name = "printToolStripButton"
            Me.printToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.printToolStripButton.Text = "&Print"
            ToolTipInfo10.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(124, Byte), Integer))
            ToolTipInfo10.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo10.Body.Text = "Prints the document"
            ToolTipInfo10.Body.TextMargin = New System.Windows.Forms.Padding(5)
            ToolTipInfo10.Footer.Hidden = True
            ToolTipInfo10.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo10.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo10.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo10.Header.Text = "Print (Ctrl + P)"
            ToolTipInfo10.Separator = False
            Me.superToolTip1.SetToolTip(Me.printToolStripButton, ToolTipInfo10)
            '
            'cutToolStripButton
            '
            Me.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.cutToolStripButton.Image = CType(resources.GetObject("cutToolStripButton.Image"), System.Drawing.Image)
            Me.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.cutToolStripButton.Name = "cutToolStripButton"
            Me.cutToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.cutToolStripButton.Text = "C&ut"
            ToolTipInfo11.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(114, Byte), Integer))
            ToolTipInfo11.Body.Hidden = True
            ToolTipInfo11.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo11.Footer.Hidden = True
            ToolTipInfo11.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo11.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo11.Header.Image = CType(resources.GetObject("resource.Image7"), System.Drawing.Image)
            ToolTipInfo11.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo11.Header.Text = "Cut (Ctrl + X)"
            ToolTipInfo11.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo11.Separator = False
            Me.superToolTip1.SetToolTip(Me.cutToolStripButton, ToolTipInfo11)
            '
            'copyToolStripButton
            '
            Me.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.copyToolStripButton.Image = CType(resources.GetObject("copyToolStripButton.Image"), System.Drawing.Image)
            Me.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.copyToolStripButton.Name = "copyToolStripButton"
            Me.copyToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.copyToolStripButton.Text = "&Copy"
            ToolTipInfo12.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(223, Byte), Integer))
            ToolTipInfo12.Body.Hidden = True
            ToolTipInfo12.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo12.Footer.Hidden = True
            ToolTipInfo12.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo12.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo12.Header.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
            ToolTipInfo12.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo12.Header.Text = "Copy (Ctrl + C)"
            ToolTipInfo12.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo12.Separator = False
            Me.superToolTip1.SetToolTip(Me.copyToolStripButton, ToolTipInfo12)
            '
            'pasteToolStripButton
            '
            Me.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.pasteToolStripButton.Image = CType(resources.GetObject("pasteToolStripButton.Image"), System.Drawing.Image)
            Me.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.pasteToolStripButton.Name = "pasteToolStripButton"
            Me.pasteToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.pasteToolStripButton.Text = "&Paste"
            ToolTipInfo13.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(213, Byte), Integer))
            ToolTipInfo13.Body.Hidden = True
            ToolTipInfo13.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo13.Footer.Hidden = True
            ToolTipInfo13.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo13.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo13.Header.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
            ToolTipInfo13.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo13.Header.Text = "Paste (Ctrl + V)"
            ToolTipInfo13.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo13.Separator = False
            Me.superToolTip1.SetToolTip(Me.pasteToolStripButton, ToolTipInfo13)
            '
            'helpToolStripButton
            '
            Me.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.helpToolStripButton.Image = CType(resources.GetObject("helpToolStripButton.Image"), System.Drawing.Image)
            Me.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.helpToolStripButton.Name = "helpToolStripButton"
            Me.helpToolStripButton.Size = New System.Drawing.Size(23, 22)
            Me.helpToolStripButton.Text = "He&lp"
            ToolTipInfo14.Body.Hidden = True
            ToolTipInfo14.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo14.Footer.Hidden = True
            ToolTipInfo14.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo14.Header.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
            ToolTipInfo14.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo14.Header.Text = "Help (F1)"
            ToolTipInfo14.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo14.Separator = False
            Me.superToolTip1.SetToolTip(Me.helpToolStripButton, ToolTipInfo14)
            '
            'fileToolStripMenuItem
            '
            Me.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(219, Byte), Integer))
            Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripMenuItem, Me.openToolStripMenuItem, Me.toolStripSeparator2, Me.saveToolStripMenuItem, Me.saveAsToolStripMenuItem, Me.toolStripSeparator3, Me.printToolStripMenuItem, Me.printPreviewToolStripMenuItem, Me.toolStripSeparator4, Me.exitToolStripMenuItem})
            Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
            Me.fileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
            Me.fileToolStripMenuItem.Text = "&File"
            ToolTipInfo15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            ToolTipInfo15.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo15.Body.Text = "Contains standard menu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "items"
            ToolTipInfo15.Body.TextMargin = New System.Windows.Forms.Padding(5)
            ToolTipInfo15.Footer.Hidden = True
            ToolTipInfo15.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo15.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo15.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo15.Header.Text = "File "
            ToolTipInfo15.Separator = False
            Me.superToolTip1.SetToolTip(Me.fileToolStripMenuItem, ToolTipInfo15)
            '
            'newToolStripMenuItem
            '
            Me.newToolStripMenuItem.Image = CType(resources.GetObject("newToolStripMenuItem.Image"), System.Drawing.Image)
            Me.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.newToolStripMenuItem.Name = "newToolStripMenuItem"
            Me.newToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
            Me.newToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
            Me.newToolStripMenuItem.Text = "&New"
            '
            'openToolStripMenuItem
            '
            Me.openToolStripMenuItem.Image = CType(resources.GetObject("openToolStripMenuItem.Image"), System.Drawing.Image)
            Me.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.openToolStripMenuItem.Name = "openToolStripMenuItem"
            Me.openToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
            Me.openToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
            Me.openToolStripMenuItem.Text = "&Open"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(148, 6)
            '
            'saveToolStripMenuItem
            '
            Me.saveToolStripMenuItem.Image = CType(resources.GetObject("saveToolStripMenuItem.Image"), System.Drawing.Image)
            Me.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
            Me.saveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
            Me.saveToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
            Me.saveToolStripMenuItem.Text = "&Save"
            '
            'saveAsToolStripMenuItem
            '
            Me.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem"
            Me.saveAsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
            Me.saveAsToolStripMenuItem.Text = "Save &As"
            '
            'toolStripSeparator3
            '
            Me.toolStripSeparator3.Name = "toolStripSeparator3"
            Me.toolStripSeparator3.Size = New System.Drawing.Size(148, 6)
            '
            'printToolStripMenuItem
            '
            Me.printToolStripMenuItem.Image = CType(resources.GetObject("printToolStripMenuItem.Image"), System.Drawing.Image)
            Me.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.printToolStripMenuItem.Name = "printToolStripMenuItem"
            Me.printToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
            Me.printToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
            Me.printToolStripMenuItem.Text = "&Print"
            '
            'printPreviewToolStripMenuItem
            '
            Me.printPreviewToolStripMenuItem.Image = CType(resources.GetObject("printPreviewToolStripMenuItem.Image"), System.Drawing.Image)
            Me.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem"
            Me.printPreviewToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
            Me.printPreviewToolStripMenuItem.Text = "Print Pre&view"
            '
            'toolStripSeparator4
            '
            Me.toolStripSeparator4.Name = "toolStripSeparator4"
            Me.toolStripSeparator4.Size = New System.Drawing.Size(148, 6)
            '
            'exitToolStripMenuItem
            '
            Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
            Me.exitToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
            Me.exitToolStripMenuItem.Text = "E&xit"
            '
            'gradientLabel1
            '
            Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(246, Byte), Integer)))
            Me.gradientLabel1.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel1.Location = New System.Drawing.Point(6, 30)
            Me.gradientLabel1.Name = "gradientLabel1"
            Me.gradientLabel1.Size = New System.Drawing.Size(181, 27)
            Me.gradientLabel1.TabIndex = 30
            Me.gradientLabel1.Text = "SuperToolTip with Header Image"
            Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo4.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo4.Body.Text = "SuperTooltip allows image to be added to it. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "User can change the size of the im" & _
                "age using " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ImageScalingSize."
            ToolTipInfo4.Body.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo4.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo4.Footer.Text = "The ToolTip Text and Image can be aligned using " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TextAlign and ImageAlign proper" & _
                "ties."
            ToolTipInfo4.Footer.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo4.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo4.Header.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
            ToolTipInfo4.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo4.Header.Text = "SuperToolTip Header Image"
            ToolTipInfo4.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo4.Header.TextMargin = New System.Windows.Forms.Padding(3)
            Me.superToolTip1.SetToolTip(Me.gradientLabel1, ToolTipInfo4)
            '
            'gradientLabel2
            '
            Me.gradientLabel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(246, Byte), Integer)))
            Me.gradientLabel2.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel2.Location = New System.Drawing.Point(6, 78)
            Me.gradientLabel2.Name = "gradientLabel2"
            Me.gradientLabel2.Size = New System.Drawing.Size(181, 27)
            Me.gradientLabel2.TabIndex = 31
            Me.gradientLabel2.Text = "SuperToolTip with Image in Body"
            Me.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            ToolTipInfo5.Body.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
            ToolTipInfo5.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo5.Body.Text = "SuperTooltip can have Image and Text " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in body portion."
            ToolTipInfo5.Body.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo5.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo5.Footer.Text = "The margin of the ToolTip Text can be set using" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TextMargin."
            ToolTipInfo5.Footer.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo5.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo5.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo5.Header.Text = "SuperToolTip Image in Body"
            ToolTipInfo5.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo5.Header.TextMargin = New System.Windows.Forms.Padding(3)
            Me.superToolTip1.SetToolTip(Me.gradientLabel2, ToolTipInfo5)
            '
            'gradientLabel3
            '
            Me.gradientLabel3.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(246, Byte), Integer)))
            Me.gradientLabel3.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel3.Location = New System.Drawing.Point(6, 126)
            Me.gradientLabel3.Name = "gradientLabel3"
            Me.gradientLabel3.Size = New System.Drawing.Size(181, 27)
            Me.gradientLabel3.TabIndex = 32
            Me.gradientLabel3.Text = "SuperToolTip with Footer Image"
            Me.gradientLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo6.BackColor = System.Drawing.Color.FromArgb(CType(CType(123, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(124, Byte), Integer))
            ToolTipInfo6.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo6.Body.Text = "SuperTooltip can have Image and Text in Footer."
            ToolTipInfo6.Body.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo6.Footer.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
            ToolTipInfo6.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo6.Footer.Text = "The Image can be set before the Text " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or after the Text using TextImageRelation"
            ToolTipInfo6.Footer.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo6.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo6.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo6.Header.Text = "SuperToolTip Footer Image"
            ToolTipInfo6.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo6.Header.TextMargin = New System.Windows.Forms.Padding(3)
            Me.superToolTip1.SetToolTip(Me.gradientLabel3, ToolTipInfo6)
            '
            'Label4
            '
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Label4.Location = New System.Drawing.Point(7, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(182, 30)
            Me.Label4.TabIndex = 39
            Me.Label4.Text = "ToolTip will show above mouse pointer"
            ToolTipInfo3.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo3.Body.Text = "SuperToolTip can be added to any .NET control " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "such as" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " * MenuStrip" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " * ToolS" & _
                "trip" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " * ToolStripEx" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " * Grid" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " * Chart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " * And on any Syncfusion controls" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            ToolTipInfo3.Body.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo3.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo3.Footer.Text = "Show the SuperToolTip on any .NET control."
            ToolTipInfo3.Footer.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo3.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo3.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo3.Header.Text = "SuperToolTip On Any .NET control"
            ToolTipInfo3.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo3.Header.TextMargin = New System.Windows.Forms.Padding(3)
            Me.superToolTip1.SetToolTip(Me.Label4, ToolTipInfo3)
            '
            'helpToolStripMenuItem
            '
            Me.helpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contentsToolStripMenuItem, Me.indexToolStripMenuItem, Me.searchToolStripMenuItem, Me.toolStripSeparator7, Me.aboutToolStripMenuItem})
            Me.helpToolStripMenuItem.Name = "helpToolStripMenuItem"
            Me.helpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
            Me.helpToolStripMenuItem.Text = "&Help"
            ToolTipInfo16.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo16.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo16.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            ToolTipInfo16.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo16.Header.Text = "Help"
            Me.superToolTip1.SetToolTip(Me.helpToolStripMenuItem, ToolTipInfo16)
            '
            'contentsToolStripMenuItem
            '
            Me.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem"
            Me.contentsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
            Me.contentsToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
            Me.contentsToolStripMenuItem.Text = "&Contents"
            '
            'indexToolStripMenuItem
            '
            Me.indexToolStripMenuItem.Name = "indexToolStripMenuItem"
            Me.indexToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
            Me.indexToolStripMenuItem.Text = "&Index"
            '
            'searchToolStripMenuItem
            '
            Me.searchToolStripMenuItem.Name = "searchToolStripMenuItem"
            Me.searchToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
            Me.searchToolStripMenuItem.Text = "&Search"
            '
            'toolStripSeparator7
            '
            Me.toolStripSeparator7.Name = "toolStripSeparator7"
            Me.toolStripSeparator7.Size = New System.Drawing.Size(145, 6)
            '
            'aboutToolStripMenuItem
            '
            Me.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem"
            Me.aboutToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
            Me.aboutToolStripMenuItem.Text = "&About..."
            '
            'CheckBox1
            '
            Me.CheckBox1.Location = New System.Drawing.Point(10, 21)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(180, 30)
            Me.CheckBox1.TabIndex = 0
            Me.CheckBox1.Text = "SuperToolTip with RightToLeft support"
            ToolTipInfo2.Body.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo2.Body.Text = "SuperToolTip with RightToLeft support"
            ToolTipInfo2.Body.TextMargin = New System.Windows.Forms.Padding(3)
            ToolTipInfo2.Footer.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo2.Header.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            ToolTipInfo2.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo2.Header.Text = "RightToLeft"
            ToolTipInfo2.Header.TextMargin = New System.Windows.Forms.Padding(3)
            Me.superToolTip1.SetToolTip(Me.CheckBox1, ToolTipInfo2)
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'buttonAdv4
            '
            Me.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonAdv4.Image = CType(resources.GetObject("buttonAdv4.Image"), System.Drawing.Image)
            Me.buttonAdv4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.buttonAdv4.KeepFocusRectangle = False
            Me.buttonAdv4.Location = New System.Drawing.Point(10, 19)
            Me.buttonAdv4.Name = "buttonAdv4"
            Me.buttonAdv4.Size = New System.Drawing.Size(180, 27)
            Me.buttonAdv4.TabIndex = 26
            Me.buttonAdv4.Text = "Select a color and hover"
            Me.buttonAdv4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
            Me.buttonAdv4.UseVisualStyle = True
            '
            'menuStrip1
            '
            Me.menuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem, Me.helpToolStripMenuItem})
            Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
            Me.menuStrip1.Size = New System.Drawing.Size(669, 24)
            Me.menuStrip1.TabIndex = 0
            Me.menuStrip1.Text = "menuStrip1"
            '
            'toolStrip1
            '
            Me.toolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(246, Byte), Integer))
            Me.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newToolStripButton, Me.openToolStripButton, Me.saveToolStripButton, Me.printToolStripButton, Me.toolStripSeparator, Me.cutToolStripButton, Me.copyToolStripButton, Me.pasteToolStripButton, Me.toolStripSeparator1, Me.helpToolStripButton})
            Me.toolStrip1.Location = New System.Drawing.Point(0, 24)
            Me.toolStrip1.Name = "toolStrip1"
            Me.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
            Me.toolStrip1.ShowItemToolTips = False
            Me.toolStrip1.Size = New System.Drawing.Size(669, 25)
            Me.toolStrip1.TabIndex = 1
            Me.toolStrip1.Text = "toolStrip1"
            '
            'toolStripSeparator
            '
            Me.toolStripSeparator.Name = "toolStripSeparator"
            Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
            '
            'statusStripEx1
            '
            Me.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom
            Me.statusStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusStripLabel1})
            Me.statusStripEx1.Location = New System.Drawing.Point(0, 311)
            Me.statusStripEx1.Name = "statusStripEx1"
            Me.statusStripEx1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue
            Me.statusStripEx1.Size = New System.Drawing.Size(669, 22)
            Me.statusStripEx1.SizingGrip = False
            Me.statusStripEx1.TabIndex = 16
            Me.statusStripEx1.Text = "statusStripEx1"
            '
            'StatusStripLabel1
            '
            Me.StatusStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.StatusStripLabel1.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
            Me.StatusStripLabel1.Name = "StatusStripLabel1"
            Me.StatusStripLabel1.Size = New System.Drawing.Size(551, 13)
            Me.StatusStripLabel1.Text = "                    Place the mouse pointer over the Controls or ToolStripItems t" & _
                "o view the SuperToolTip"
            '
            'gradientPanelExt1
            '
            Me.gradientPanelExt1.BackColor = System.Drawing.Color.Transparent
            Me.gradientPanelExt1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.gradientPanelExt1.Controls.Add(Me.gradientLabel6)
            Me.gradientPanelExt1.Controls.Add(Me.label3)
            Me.gradientPanelExt1.Controls.Add(Me.label2)
            Me.gradientPanelExt1.Controls.Add(Me.label1)
            Me.gradientPanelExt1.Controls.Add(Me.textBox2)
            Me.gradientPanelExt1.Controls.Add(Me.textBox1)
            Me.gradientPanelExt1.Controls.Add(Me.textBox3)
            Me.gradientPanelExt1.CornerRadius = 5
            Me.gradientPanelExt1.Location = New System.Drawing.Point(435, 73)
            Me.gradientPanelExt1.Name = "gradientPanelExt1"
            Me.gradientPanelExt1.Primitives.AddRange(New Syncfusion.Windows.Forms.Tools.Primitive() {Me.textPrimitive1})
            Me.gradientPanelExt1.Size = New System.Drawing.Size(234, 198)
            Me.gradientPanelExt1.TabIndex = 25
            '
            'gradientLabel6
            '
            Me.gradientLabel6.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(254, Byte), Integer)))
            Me.gradientLabel6.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel6.Location = New System.Drawing.Point(83, 143)
            Me.gradientLabel6.Name = "gradientLabel6"
            Me.gradientLabel6.Size = New System.Drawing.Size(79, 23)
            Me.gradientLabel6.TabIndex = 36
            Me.gradientLabel6.Text = "Preview"
            Me.gradientLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(24, 115)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(61, 13)
            Me.label3.TabIndex = 34
            Me.label3.Text = "Footer Text"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(24, 80)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(55, 13)
            Me.label2.TabIndex = 34
            Me.label2.Text = "Body Text"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(24, 47)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(66, 13)
            Me.label1.TabIndex = 34
            Me.label1.Text = "Header Text"
            '
            'textBox2
            '
            Me.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBox2.Location = New System.Drawing.Point(104, 78)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(108, 20)
            Me.textBox2.TabIndex = 3
            '
            'textBox1
            '
            Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBox1.Location = New System.Drawing.Point(104, 45)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(108, 20)
            Me.textBox1.TabIndex = 1
            '
            'textBox3
            '
            Me.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.textBox3.Location = New System.Drawing.Point(104, 113)
            Me.textBox3.Name = "textBox3"
            Me.textBox3.Size = New System.Drawing.Size(108, 20)
            Me.textBox3.TabIndex = 33
            '
            'textPrimitive1
            '
            Me.textPrimitive1.PrimitiveBorderStyle = Syncfusion.Windows.Forms.Tools.PrimitiveBorderStyle.None
            Me.textPrimitive1.Size = New System.Drawing.Size(180, 20)
            Me.textPrimitive1.Text = "Enter text and hover preview button"
            Me.textPrimitive1.TextColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(234, Byte), Integer))
            Me.textPrimitive1.TextFont = New System.Drawing.Font("Arial", 8.0!)
            '
            'popupControlContainer1
            '
            Me.popupControlContainer1.Controls.Add(Me.ColorPickerUIAdv2)
            Me.popupControlContainer1.Location = New System.Drawing.Point(715, 70)
            Me.popupControlContainer1.Name = "popupControlContainer1"
            Me.popupControlContainer1.ParentControl = Me.buttonAdv4
            Me.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.popupControlContainer1.Size = New System.Drawing.Size(200, 201)
            Me.popupControlContainer1.TabIndex = 29
            '
            'ColorPickerUIAdv2.RecentGroup
            '
            Me.ColorPickerUIAdv2.RecentGroup.Name = "Recent Colors"
            Me.ColorPickerUIAdv2.RecentGroup.Visible = False
            '
            'ColorPickerUIAdv2.StandardGroup
            '
            Me.ColorPickerUIAdv2.StandardGroup.Name = "Standard Colors"
            '
            'ColorPickerUIAdv2.ThemeGroup
            '
            Me.ColorPickerUIAdv2.ThemeGroup.IsSubItemsVisible = True
            Me.ColorPickerUIAdv2.ThemeGroup.Name = "Theme Colors"
            '
            'ColorPickerUIAdv2
            '
            Me.ColorPickerUIAdv2.ColorItemSize = New System.Drawing.Size(13, 13)
            'Me.ColorPickerUIAdv2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ColorPickerUIAdv2.HorizontalItemsSpacing = 7
            Me.ColorPickerUIAdv2.Location = New System.Drawing.Point(0, 0)
            Me.ColorPickerUIAdv2.MinimumSize = New System.Drawing.Size(136, 149)
            Me.ColorPickerUIAdv2.Name = "ColorPickerUIAdv2"
            Me.ColorPickerUIAdv2.SelectedColor = System.Drawing.Color.Empty
            Me.ColorPickerUIAdv2.Size = New System.Drawing.Size(200, 201)
            Me.ColorPickerUIAdv2.TabIndex = 0
            Me.ColorPickerUIAdv2.Text = "ColorPickerUIAdv2"
            Me.ColorPickerUIAdv2.VerticalItemsSpacing = 1
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.gradientLabel1)
            Me.groupBox1.Controls.Add(Me.gradientLabel2)
            Me.groupBox1.Controls.Add(Me.gradientLabel3)
            Me.groupBox1.Location = New System.Drawing.Point(12, 80)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(199, 176)
            Me.groupBox1.TabIndex = 35
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Image support"
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.buttonAdv4)
            Me.groupBox2.Location = New System.Drawing.Point(232, 80)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(197, 56)
            Me.groupBox2.TabIndex = 36
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Change color"
            '
            'groupBox3
            '
            Me.groupBox3.Controls.Add(Me.Label4)
            Me.groupBox3.Location = New System.Drawing.Point(232, 200)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(195, 56)
            Me.groupBox3.TabIndex = 37
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Custom Location"
            '
            'GroupBox4
            '
            Me.GroupBox4.Controls.Add(Me.CheckBox1)
            Me.GroupBox4.Location = New System.Drawing.Point(232, 140)
            Me.GroupBox4.Name = "GroupBox4"
            Me.GroupBox4.Size = New System.Drawing.Size(195, 56)
            Me.GroupBox4.TabIndex = 38
            Me.GroupBox4.TabStop = False
            Me.GroupBox4.Text = "RightToLeft"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.Location = New System.Drawing.Point(39, 274)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(35, 13)
            Me.Label5.TabIndex = 39
            Me.Label5.Text = "Style"
            '
            'ComboBox1
            '
            Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Items.AddRange(New Object() {"Normal", "Balloon"})
            Me.ComboBox1.Location = New System.Drawing.Point(90, 271)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
            Me.ComboBox1.TabIndex = 40
            '
            'GradientLabel4
            '
            Me.GradientLabel4.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(246, Byte), Integer)))
            Me.GradientLabel4.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.GradientLabel4.Location = New System.Drawing.Point(235, 266)
            Me.GradientLabel4.Name = "GradientLabel4"
            Me.GradientLabel4.Size = New System.Drawing.Size(421, 25)
            Me.GradientLabel4.TabIndex = 41
            Me.GradientLabel4.Text = "Hover here Tool Tip will show HTML string"
            Me.GradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            ToolTipInfo1.Body.RenderHtml = True
            ToolTipInfo1.Body.Size = New System.Drawing.Size(200, 20)
            ToolTipInfo1.Body.Text = "<center><font face=""Century Gothic"" size=""10"" color=""#FF0000""><b>Body</b> in cent" & _
                "er alignment</font></center>"
            ToolTipInfo1.Footer.RenderHtml = True
            ToolTipInfo1.Footer.Size = New System.Drawing.Size(250, 20)
            ToolTipInfo1.Footer.Text = "<center><font face=""Courier New"" size=""11"" color=""#0000FF""><u>Footer</u> in Blue " & _
                "Underline</font></center>"
            ToolTipInfo1.Header.RenderHtml = True
            ToolTipInfo1.Header.Size = New System.Drawing.Size(20, 20)
            ToolTipInfo1.Header.Text = "<center><font style=""font-size:12px;"" face=""Verdana""  color=""#000000""><i>Header</" & _
                "i> In Italic</font></center>"
            Me.superToolTip1.SetToolTip(Me.GradientLabel4, ToolTipInfo1)
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(669, 333)
            Me.Controls.Add(Me.GradientLabel4)
            Me.Controls.Add(Me.ComboBox1)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.popupControlContainer1)
            Me.Controls.Add(Me.GroupBox4)
            Me.Controls.Add(Me.groupBox3)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.gradientPanelExt1)
            Me.Controls.Add(Me.statusStripEx1)
            Me.Controls.Add(Me.toolStrip1)
            Me.Controls.Add(Me.menuStrip1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MainMenuStrip = Me.menuStrip1
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SuperToolTip (Syncfusion Inc.)"
            Me.menuStrip1.ResumeLayout(False)
            Me.menuStrip1.PerformLayout()
            Me.toolStrip1.ResumeLayout(False)
            Me.toolStrip1.PerformLayout()
            Me.statusStripEx1.ResumeLayout(False)
            CType(Me.gradientPanelExt1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanelExt1.ResumeLayout(False)
            Me.gradientPanelExt1.PerformLayout()
            Me.popupControlContainer1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox3.ResumeLayout(False)
            Me.GroupBox4.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

        Private WithEvents superToolTip1 As Syncfusion.Windows.Forms.Tools.SuperToolTip
		Private menuStrip1 As System.Windows.Forms.MenuStrip
		Private fileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private newToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private openToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private saveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
		Private printToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private printPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
		Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private helpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private contentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private indexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private searchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents aboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStrip1 As System.Windows.Forms.ToolStrip
		Private newToolStripButton As System.Windows.Forms.ToolStripButton
		Private openToolStripButton As System.Windows.Forms.ToolStripButton
		Private saveToolStripButton As System.Windows.Forms.ToolStripButton
		Private printToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator As System.Windows.Forms.ToolStripSeparator
		Private cutToolStripButton As System.Windows.Forms.ToolStripButton
		Private copyToolStripButton As System.Windows.Forms.ToolStripButton
		Private pasteToolStripButton As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private helpToolStripButton As System.Windows.Forms.ToolStripButton
		Private statusStripEx1 As Syncfusion.Windows.Forms.Tools.StatusStripEx
        Private gradientPanelExt1 As Syncfusion.Windows.Forms.Tools.GradientPanelExt
        Private WithEvents textBox1 As System.Windows.Forms.TextBox
        Private WithEvents buttonAdv4 As Syncfusion.Windows.Forms.ButtonAdv
		Private popupControlContainer1 As Syncfusion.Windows.Forms.PopupControlContainer
		Private gradientLabel3 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel2 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private textPrimitive1 As Syncfusion.Windows.Forms.Tools.TextPrimitive
        Private WithEvents gradientLabel6 As Syncfusion.Windows.Forms.Tools.GradientLabel
        Private WithEvents textBox2 As System.Windows.Forms.TextBox
        Private WithEvents textBox3 As System.Windows.Forms.TextBox
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private groupBox2 As System.Windows.Forms.GroupBox
        Private groupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents StatusStripLabel1 As Syncfusion.Windows.Forms.Tools.StatusStripLabel
        Private WithEvents GroupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents ColorPickerUIAdv2 As Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents GradientLabel4 As Syncfusion.Windows.Forms.Tools.GradientLabel

       
    End Class
End Namespace

