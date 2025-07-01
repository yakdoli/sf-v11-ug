#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace MiniToolBarDemo_2005
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
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.miniToolBar1 = New Syncfusion.Windows.Forms.Tools.MiniToolBar
            Me.toolStripPanelItem5 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripPanelItem6 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton13 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton14 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton15 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem7 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton16 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton17 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton18 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripLabel1 = New System.Windows.Forms.ToolStripLabel
            Me.toolStripButton10 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton11 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton12 = New System.Windows.Forms.ToolStripButton
            Me.richTextBox1 = New System.Windows.Forms.RichTextBox
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripPanelItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
            Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.toolStripPanelItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton
            Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
            Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton8 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton9 = New System.Windows.Forms.ToolStripButton
            Me.miniToolBar2 = New Syncfusion.Windows.Forms.Tools.MiniToolBar
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label2 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label1 = New System.Windows.Forms.Label
            Me.panel1 = New System.Windows.Forms.Panel
            Me.textBox1 = New System.Windows.Forms.TextBox
            Me.tabPageAdv3 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.label3 = New System.Windows.Forms.Label
            Me.miniToolBar3 = New Syncfusion.Windows.Forms.Tools.MiniToolBar
            Me.statusBarAdv1 = New Syncfusion.Windows.Forms.Tools.StatusBarAdv
            Me.autoLabel1 = New Syncfusion.Windows.Forms.Tools.AutoLabel
            Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.miniToolBar1.SuspendLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.miniToolBar2.SuspendLayout()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.tabPageAdv2.SuspendLayout()
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel2.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.tabPageAdv3.SuspendLayout()
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.gradientPanel3.SuspendLayout()
            Me.miniToolBar3.SuspendLayout()
            CType(Me.statusBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.statusBarAdv1.SuspendLayout()
            Me.SuspendLayout()
            '
            'miniToolBar1
            '
            Me.miniToolBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.miniToolBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem5})
            Me.miniToolBar1.Name = "miniToolBar1"
            Me.miniToolBar1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
            Me.miniToolBar1.Size = New System.Drawing.Size(83, 62)
            '
            'toolStripPanelItem5
            '
            Me.toolStripPanelItem5.CausesValidation = False
            Me.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem6, Me.toolStripPanelItem7})
            Me.toolStripPanelItem5.Name = "toolStripPanelItem5"
            Me.toolStripPanelItem5.ShowItemToolTips = False
            Me.toolStripPanelItem5.Size = New System.Drawing.Size(79, 58)
            Me.toolStripPanelItem5.Text = "toolStripPanelItem5"
            Me.toolStripPanelItem5.Transparent = True
            '
            'toolStripPanelItem6
            '
            Me.toolStripPanelItem6.CausesValidation = False
            Me.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton13, Me.toolStripButton14, Me.toolStripButton15})
            Me.toolStripPanelItem6.Name = "toolStripPanelItem6"
            Me.toolStripPanelItem6.RowCount = 1
            Me.toolStripPanelItem6.ShowItemToolTips = False
            Me.toolStripPanelItem6.Size = New System.Drawing.Size(73, 27)
            Me.toolStripPanelItem6.Text = "toolStripPanelItem6"
            Me.toolStripPanelItem6.Transparent = True
            '
            'toolStripButton13
            '
            Me.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton13.Image = CType(resources.GetObject("toolStripButton13.Image"), System.Drawing.Image)
            Me.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton13.Name = "toolStripButton13"
            Me.toolStripButton13.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton13.Text = "Smile"
            '
            'toolStripButton14
            '
            Me.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton14.Image = CType(resources.GetObject("toolStripButton14.Image"), System.Drawing.Image)
            Me.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton14.Name = "toolStripButton14"
            Me.toolStripButton14.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton14.Text = "Laugh"
            '
            'toolStripButton15
            '
            Me.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton15.Image = CType(resources.GetObject("toolStripButton15.Image"), System.Drawing.Image)
            Me.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton15.Name = "toolStripButton15"
            Me.toolStripButton15.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton15.Text = "Sad"
            '
            'toolStripPanelItem7
            '
            Me.toolStripPanelItem7.CausesValidation = False
            Me.toolStripPanelItem7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton16, Me.toolStripButton17, Me.toolStripButton18})
            Me.toolStripPanelItem7.Name = "toolStripPanelItem7"
            Me.toolStripPanelItem7.RowCount = 1
            Me.toolStripPanelItem7.ShowItemToolTips = False
            Me.toolStripPanelItem7.Size = New System.Drawing.Size(73, 27)
            Me.toolStripPanelItem7.Text = "toolStripPanelItem7"
            Me.toolStripPanelItem7.Transparent = True
            '
            'toolStripButton16
            '
            Me.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton16.Image = CType(resources.GetObject("toolStripButton16.Image"), System.Drawing.Image)
            Me.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton16.Name = "toolStripButton16"
            Me.toolStripButton16.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton16.Text = "Surprised"
            '
            'toolStripButton17
            '
            Me.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton17.Image = CType(resources.GetObject("toolStripButton17.Image"), System.Drawing.Image)
            Me.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton17.Name = "toolStripButton17"
            Me.toolStripButton17.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton17.Text = "Sarcastic"
            '
            'toolStripButton18
            '
            Me.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton18.Image = CType(resources.GetObject("toolStripButton18.Image"), System.Drawing.Image)
            Me.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton18.Name = "toolStripButton18"
            Me.toolStripButton18.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton18.Text = "Hot"
            '
            'toolStripPanelItem4
            '
            Me.toolStripPanelItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.toolStripPanelItem4.CausesValidation = False
            Me.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel1, Me.toolStripButton10, Me.toolStripButton11, Me.toolStripButton12})
            Me.toolStripPanelItem4.Name = "toolStripPanelItem4"
            Me.toolStripPanelItem4.RowCount = 4
            Me.toolStripPanelItem4.ShowItemToolTips = False
            Me.toolStripPanelItem4.Size = New System.Drawing.Size(116, 108)
            Me.toolStripPanelItem4.Text = "toolStripPanelItem4"
            Me.toolStripPanelItem4.Transparent = True
            '
            'toolStripLabel1
            '
            Me.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.toolStripLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripLabel1.Name = "toolStripLabel1"
            Me.toolStripLabel1.Size = New System.Drawing.Size(100, 14)
            Me.toolStripLabel1.Text = "Office2007Colors"
            '
            'toolStripButton10
            '
            Me.toolStripButton10.Image = CType(resources.GetObject("toolStripButton10.Image"), System.Drawing.Image)
            Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton10.Name = "toolStripButton10"
            Me.toolStripButton10.Padding = New System.Windows.Forms.Padding(55, 3, 0, 3)
            Me.toolStripButton10.Size = New System.Drawing.Size(108, 26)
            Me.toolStripButton10.Text = "  Blue"
            '
            'toolStripButton11
            '
            Me.toolStripButton11.Image = CType(resources.GetObject("toolStripButton11.Image"), System.Drawing.Image)
            Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton11.Name = "toolStripButton11"
            Me.toolStripButton11.Padding = New System.Windows.Forms.Padding(47, 3, 5, 3)
            Me.toolStripButton11.Size = New System.Drawing.Size(111, 26)
            Me.toolStripButton11.Text = "  Silver"
            '
            'toolStripButton12
            '
            Me.toolStripButton12.Image = CType(resources.GetObject("toolStripButton12.Image"), System.Drawing.Image)
            Me.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton12.Name = "toolStripButton12"
            Me.toolStripButton12.Padding = New System.Windows.Forms.Padding(47, 3, 5, 3)
            Me.toolStripButton12.Size = New System.Drawing.Size(112, 26)
            Me.toolStripButton12.Text = "   Black"
            '
            'richTextBox1
            '
            Me.richTextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.richTextBox1.HideSelection = False
            Me.richTextBox1.Location = New System.Drawing.Point(16, 15)
            Me.richTextBox1.Name = "richTextBox1"
            Me.richTextBox1.Size = New System.Drawing.Size(462, 252)
            Me.richTextBox1.TabIndex = 3
            Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
            '
            'gridControl1
            '
            Me.gridControl1.ColCount = 7
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            Me.gridControl1.Location = New System.Drawing.Point(20, 139)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Office2007ScrollBars = True
            Me.gridControl1.RowCount = 13
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(490, 243)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 3
			Me.gridControl1.ThemesEnabled = True
            Me.gridControl1.UseRightToLeftCompatibleTextBox = True
            '
            'toolStripPanelItem1
            '
            Me.toolStripPanelItem1.CausesValidation = False
            Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem2, Me.toolStripPanelItem3})
            Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
            Me.toolStripPanelItem1.RowCount = 2
            Me.toolStripPanelItem1.ShowItemToolTips = False
            Me.toolStripPanelItem1.Size = New System.Drawing.Size(183, 58)
            Me.toolStripPanelItem1.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Transparent = True
            '
            'toolStripPanelItem2
            '
            Me.toolStripPanelItem2.CausesValidation = False
            Me.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripComboBox1, Me.toolStripButton1, Me.toolStripButton2})
            Me.toolStripPanelItem2.Name = "toolStripPanelItem2"
            Me.toolStripPanelItem2.RowCount = 1
            Me.toolStripPanelItem2.ShowItemToolTips = False
            Me.toolStripPanelItem2.Size = New System.Drawing.Size(173, 27)
            Me.toolStripPanelItem2.Text = "toolStripPanelItem2"
            Me.toolStripPanelItem2.Transparent = True
            '
            'toolStripComboBox1
            '
            Me.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.toolStripComboBox1.Items.AddRange(New Object() {"Body", "Heading 1", "Heading 2", "Heading 3", "Footer"})
            Me.toolStripComboBox1.Name = "toolStripComboBox1"
            Me.toolStripComboBox1.Size = New System.Drawing.Size(121, 21)
            '
            'toolStripButton1
            '
            Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
            Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton1.Name = "toolStripButton1"
            Me.toolStripButton1.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton1.Text = "Font Item"
            '
            'toolStripButton2
            '
            Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
            Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton2.Name = "toolStripButton2"
            Me.toolStripButton2.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton2.Text = "Paint Item"
            '
            'toolStripPanelItem3
            '
            Me.toolStripPanelItem3.CausesValidation = False
            Me.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton3, Me.toolStripButton4, Me.toolStripButton5, Me.toolStripSeparator1, Me.toolStripButton6, Me.toolStripSeparator2, Me.toolStripButton7, Me.toolStripButton8, Me.toolStripButton9})
            Me.toolStripPanelItem3.Name = "toolStripPanelItem3"
            Me.toolStripPanelItem3.RowCount = 1
            Me.toolStripPanelItem3.ShowItemToolTips = False
            Me.toolStripPanelItem3.Size = New System.Drawing.Size(177, 27)
            Me.toolStripPanelItem3.Text = "toolStripPanelItem3"
            Me.toolStripPanelItem3.Transparent = True
            '
            'toolStripButton3
            '
            Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton3.Text = "Bold Item"
            '
            'toolStripButton4
            '
            Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
            Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton4.Name = "toolStripButton4"
            Me.toolStripButton4.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton4.Text = "Italics Item"
            '
            'toolStripButton5
            '
            Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton5.Image = CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image)
            Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton5.Name = "toolStripButton5"
            Me.toolStripButton5.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton5.Text = "UnderLine Item"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 23)
            '
            'toolStripButton6
            '
            Me.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton6.Image = CType(resources.GetObject("toolStripButton6.Image"), System.Drawing.Image)
            Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton6.Name = "toolStripButton6"
            Me.toolStripButton6.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton6.Text = "Font Colot Item"
            '
            'toolStripSeparator2
            '
            Me.toolStripSeparator2.Name = "toolStripSeparator2"
            Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 23)
            '
            'toolStripButton7
            '
            Me.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton7.Image = CType(resources.GetObject("toolStripButton7.Image"), System.Drawing.Image)
            Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton7.Name = "toolStripButton7"
            Me.toolStripButton7.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton7.Text = "Left Justify"
            '
            'toolStripButton8
            '
            Me.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton8.Image = CType(resources.GetObject("toolStripButton8.Image"), System.Drawing.Image)
            Me.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton8.Name = "toolStripButton8"
            Me.toolStripButton8.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton8.Text = "Center Justify"
            '
            'toolStripButton9
            '
            Me.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton9.Image = CType(resources.GetObject("toolStripButton9.Image"), System.Drawing.Image)
            Me.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton9.Name = "toolStripButton9"
            Me.toolStripButton9.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton9.Text = "Right Justify"
            '
            'miniToolBar2
            '
            Me.miniToolBar2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem1})
            Me.miniToolBar2.Name = "miniToolBar1"
            Me.miniToolBar2.Size = New System.Drawing.Size(187, 62)
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv3)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControlAdv1.Location = New System.Drawing.Point(0, 0)
            Me.tabControlAdv1.MultilineText = True
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Padding = New System.Drawing.Point(9, 6)
            Me.tabControlAdv1.Size = New System.Drawing.Size(541, 434)
            Me.tabControlAdv1.TabGap = 10
            Me.tabControlAdv1.TabIndex = 5
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            Me.tabControlAdv1.VSLikeScrollButton = True
            '
            'tabPageAdv1
            '
            Me.tabPageAdv1.Controls.Add(Me.gradientPanel1)
            Me.tabPageAdv1.Controls.Add(Me.panel2)
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 35)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPageAdv1.Size = New System.Drawing.Size(539, 398)
            Me.tabPageAdv1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "TextRelated Controls"
            Me.tabPageAdv1.ThemesEnabled = False
            '
            'gradientPanel1
            '
            Me.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel1.Controls.Add(Me.label2)
            Me.gradientPanel1.Location = New System.Drawing.Point(25, 13)
            Me.gradientPanel1.Name = "gradientPanel1"
            Me.gradientPanel1.Size = New System.Drawing.Size(499, 70)
            Me.gradientPanel1.TabIndex = 8
            '
            'label2
            '
            Me.label2.BackColor = System.Drawing.Color.Transparent
            Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label2.Location = New System.Drawing.Point(0, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(497, 68)
            Me.label2.TabIndex = 5
            Me.label2.Text = "MiniToolBar in RichTextBox" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right click or select the text in the RichTextBox t" & _
                "o view the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "MiniToolBar"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(182, Byte), Integer))
            Me.panel2.Controls.Add(Me.richTextBox1)
            Me.panel2.Location = New System.Drawing.Point(25, 98)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(494, 284)
            Me.panel2.TabIndex = 4
            '
            'tabPageAdv2
            '
            Me.tabPageAdv2.Controls.Add(Me.gradientPanel2)
            Me.tabPageAdv2.Controls.Add(Me.panel1)
            Me.tabPageAdv2.Location = New System.Drawing.Point(1, 35)
            Me.tabPageAdv2.Name = "tabPageAdv2"
            Me.tabPageAdv2.Size = New System.Drawing.Size(539, 398)
            Me.tabPageAdv2.TabIndex = 1
            Me.tabPageAdv2.Text = "Container Controls"
            Me.tabPageAdv2.ThemesEnabled = False
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel2.Controls.Add(Me.label1)
            Me.gradientPanel2.Location = New System.Drawing.Point(18, 13)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(499, 60)
            Me.gradientPanel2.TabIndex = 7
            '
            'label1
            '
            Me.label1.BackColor = System.Drawing.Color.Transparent
            Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label1.Location = New System.Drawing.Point(0, 0)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(497, 58)
            Me.label1.TabIndex = 5
            Me.label1.Text = "MiniToolBar in controls inside container controls" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right click or select the te" & _
                "xt in the messenger TextBox to view the MiniToolBar"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'panel1
            '
            Me.panel1.BackgroundImage = CType(resources.GetObject("panel1.BackgroundImage"), System.Drawing.Image)
            Me.panel1.Controls.Add(Me.textBox1)
            Me.panel1.Location = New System.Drawing.Point(22, 79)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(495, 304)
            Me.panel1.TabIndex = 0
            '
            'textBox1
            '
            Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.textBox1.ContextMenuStrip = Me.ContextMenuStrip1
            Me.textBox1.Location = New System.Drawing.Point(11, 196)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(260, 61)
            Me.textBox1.TabIndex = 0
            Me.textBox1.Text = "Hi Simen,  Can you please mail me the details discussed in the meeting held on ye" & _
                "sterday :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'tabPageAdv3
            '
            Me.tabPageAdv3.Controls.Add(Me.gridControl1)
            Me.tabPageAdv3.Controls.Add(Me.gradientPanel3)
            Me.tabPageAdv3.Location = New System.Drawing.Point(1, 35)
            Me.tabPageAdv3.Name = "tabPageAdv3"
            Me.tabPageAdv3.Size = New System.Drawing.Size(539, 398)
            Me.tabPageAdv3.TabIndex = 2
            Me.tabPageAdv3.Text = "Other Controls"
            Me.tabPageAdv3.ThemesEnabled = False
            '
            'gradientPanel3
            '
            Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gradientPanel3.Controls.Add(Me.label3)
            Me.gradientPanel3.Location = New System.Drawing.Point(20, 23)
            Me.gradientPanel3.Name = "gradientPanel3"
            Me.gradientPanel3.Size = New System.Drawing.Size(499, 96)
            Me.gradientPanel3.TabIndex = 8
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.Transparent
            Me.label3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.label3.Location = New System.Drawing.Point(0, 0)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(497, 94)
            Me.label3.TabIndex = 5
            Me.label3.Text = "MiniToolBar in Grid controls" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right click on the GridControl to change the Colo" & _
                "r Schemes through" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the MiniToolBar."
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'miniToolBar3
            '
            Me.miniToolBar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.miniToolBar3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem4})
            Me.miniToolBar3.Name = "miniToolBar1"
            Me.miniToolBar3.Size = New System.Drawing.Size(120, 112)
            '
            'statusBarAdv1
            '
            Me.statusBarAdv1.BorderColor = System.Drawing.Color.Black
            Me.statusBarAdv1.Controls.Add(Me.autoLabel1)
            Me.statusBarAdv1.CustomLayoutBounds = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.statusBarAdv1.Location = New System.Drawing.Point(0, 434)
            Me.statusBarAdv1.Name = "statusBarAdv1"
            Me.statusBarAdv1.Padding = New System.Windows.Forms.Padding(3)
            Me.statusBarAdv1.Size = New System.Drawing.Size(541, 27)
            Me.statusBarAdv1.Spacing = New System.Drawing.Size(2, 2)
            Me.statusBarAdv1.TabIndex = 6
            '
            'autoLabel1
            '
            Me.autoLabel1.DX = 0
            Me.autoLabel1.DY = 0
            Me.autoLabel1.Location = New System.Drawing.Point(0, 2)
            Me.autoLabel1.Name = "autoLabel1"
            Me.autoLabel1.Size = New System.Drawing.Size(63, 13)
            Me.autoLabel1.TabIndex = 0
            Me.autoLabel1.Text = "MiniToolBar"
            Me.autoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ContextMenuStrip1
            '
            Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
            Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(250, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(541, 461)
            Me.Controls.Add(Me.tabControlAdv1)
            Me.Controls.Add(Me.statusBarAdv1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MiniToolBarDemo"
            Me.miniToolBar1.ResumeLayout(False)
            Me.miniToolBar1.PerformLayout()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.miniToolBar2.ResumeLayout(False)
            Me.miniToolBar2.PerformLayout()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.tabPageAdv2.ResumeLayout(False)
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel2.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.tabPageAdv3.ResumeLayout(False)
            CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.gradientPanel3.ResumeLayout(False)
            Me.miniToolBar3.ResumeLayout(False)
            Me.miniToolBar3.PerformLayout()
            CType(Me.statusBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.statusBarAdv1.ResumeLayout(False)
            Me.statusBarAdv1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private miniToolBar1 As Syncfusion.Windows.Forms.Tools.MiniToolBar
		Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private toolStripPanelItem1 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem2 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem3 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
		Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents toolStripButton6 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents toolStripButton7 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton8 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton9 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem4 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripLabel1 As System.Windows.Forms.ToolStripLabel
		Private miniToolBar2 As Syncfusion.Windows.Forms.Tools.MiniToolBar
		Private WithEvents toolStripButton10 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton11 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton12 As System.Windows.Forms.ToolStripButton
		Private WithEvents tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdv3 As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents textBox1 As System.Windows.Forms.TextBox
		Private miniToolBar3 As Syncfusion.Windows.Forms.Tools.MiniToolBar
		Private panel2 As System.Windows.Forms.Panel
		Private toolStripPanelItem5 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem6 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton13 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton14 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton15 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem7 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton16 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton17 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton18 As System.Windows.Forms.ToolStripButton
		Private statusBarAdv1 As Syncfusion.Windows.Forms.Tools.StatusBarAdv
		Private autoLabel1 As Syncfusion.Windows.Forms.Tools.AutoLabel
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label1 As System.Windows.Forms.Label
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label2 As System.Windows.Forms.Label
		Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
        Private label3 As System.Windows.Forms.Label
        Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
	End Class
End Namespace