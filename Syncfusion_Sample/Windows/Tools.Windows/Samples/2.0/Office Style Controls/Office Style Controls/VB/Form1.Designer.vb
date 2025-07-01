#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Namespace Office2007Controls
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.statusStripEx1 = New Syncfusion.Windows.Forms.Tools.StatusStripEx
            Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
            Me.toolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
            Me.toolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
            Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton
            Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton
            Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel
            Me.trackBarItem1 = New Syncfusion.Windows.Forms.Tools.TrackBarItem
            Me.StatusStripLabel1 = New Syncfusion.Windows.Forms.Tools.StatusStripLabel
            Me.StatusStripLabel2 = New Syncfusion.Windows.Forms.Tools.StatusStripLabel
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label6 = New System.Windows.Forms.Label
            Me.trackBarEx1 = New Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 100)
            Me.label7 = New System.Windows.Forms.Label
            Me.label8 = New System.Windows.Forms.Label
            Me.label9 = New System.Windows.Forms.Label
            Me.numericUpDownExt1 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.label10 = New System.Windows.Forms.Label
            Me.numericUpDownExt2 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.colorDialog1 = New System.Windows.Forms.ColorDialog
            Me.buttonEdit2 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton1 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.contextMenuStripEx1 = New Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
            Me.cutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.pasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.fontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.bulletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.buToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.tWOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.thToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.etToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.hyperlinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.gradientLabel1 = New Syncfusion.Windows.Forms.Tools.GradientLabel
            Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.comboBox4 = New System.Windows.Forms.ComboBox
            Me.label12 = New System.Windows.Forms.Label
            Me.label11 = New System.Windows.Forms.Label
            Me.textBoxExt1 = New Syncfusion.Windows.Forms.Tools.TextBoxExt
            Me.label13 = New System.Windows.Forms.Label
            Me.checkBoxAdv5 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.panel1 = New System.Windows.Forms.Panel
            Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.checkBoxAdv3 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label14 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.panel2 = New System.Windows.Forms.Panel
            Me.TextBox1 = New System.Windows.Forms.TextBox
            Me.panel4 = New System.Windows.Forms.Panel
            Me.checkBoxAdv4 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.label5 = New System.Windows.Forms.Label
            Me.buttonEdit3 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton3 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.buttonEdit1 = New Syncfusion.Windows.Forms.Tools.ButtonEdit
            Me.buttonEditChildButton2 = New Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
            Me.panel3 = New System.Windows.Forms.Panel
            Me.checkBoxAdv6 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            Me.statusStripEx1.SuspendLayout()
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownExt2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit2.SuspendLayout()
            Me.contextMenuStripEx1.SuspendLayout()
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textBoxExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.panel4.SuspendLayout()
            CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit3.SuspendLayout()
            CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.buttonEdit1.SuspendLayout()
            Me.panel3.SuspendLayout()
            CType(Me.checkBoxAdv6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'statusStripEx1
            '
            Me.statusStripEx1.AllowItemReorder = True
            Me.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom
            Me.statusStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1, Me.toolStripProgressBar1, Me.toolStripStatusLabel2, Me.toolStripPanelItem1, Me.statusLabel, Me.trackBarItem1, Me.StatusStripLabel1, Me.StatusStripLabel2})
            Me.statusStripEx1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
            Me.statusStripEx1.Location = New System.Drawing.Point(0, 320)
            Me.statusStripEx1.Name = "statusStripEx1"
            Me.statusStripEx1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue
            Me.statusStripEx1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.statusStripEx1.ShowItemToolTips = True
            Me.statusStripEx1.Size = New System.Drawing.Size(690, 27)
            Me.statusStripEx1.TabIndex = 13
            Me.statusStripEx1.Text = "statusStripEx4"
            '
            'toolStripStatusLabel1
            '
            Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
            Me.toolStripStatusLabel1.Size = New System.Drawing.Size(39, 13)
            Me.toolStripStatusLabel1.Text = "Saving"
            '
            'toolStripProgressBar1
            '
            Me.toolStripProgressBar1.Name = "toolStripProgressBar1"
            Me.toolStripProgressBar1.Size = New System.Drawing.Size(100, 15)
            Me.toolStripProgressBar1.Value = 50
            '
            'toolStripStatusLabel2
            '
            Me.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
            Me.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripStatusLabel2.Image = CType(resources.GetObject("toolStripStatusLabel2.Image"), System.Drawing.Image)
            Me.toolStripStatusLabel2.Name = "toolStripStatusLabel2"
            Me.toolStripStatusLabel2.Size = New System.Drawing.Size(20, 20)
            Me.toolStripStatusLabel2.Text = "Status"
            '
            'toolStripPanelItem1
            '
            Me.toolStripPanelItem1.AutoSize = False
            Me.toolStripPanelItem1.CausesValidation = False
            Me.toolStripPanelItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton3, Me.toolStripButton4})
            Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
            Me.toolStripPanelItem1.RowCount = 1
            Me.toolStripPanelItem1.Size = New System.Drawing.Size(50, 27)
            Me.toolStripPanelItem1.Text = "PanelItem"
            Me.toolStripPanelItem1.Transparent = True
            '
            'toolStripButton3
            '
            Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton3.Text = "toolStripButton3"
            '
            'toolStripButton4
            '
            Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
            Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton4.Name = "toolStripButton4"
            Me.toolStripButton4.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton4.Text = "toolStripButton4"
            '
            'statusLabel
            '
            Me.statusLabel.Name = "statusLabel"
            Me.statusLabel.Size = New System.Drawing.Size(30, 13)
            Me.statusLabel.Text = "50%"
            '
            'trackBarItem1
            '
            Me.trackBarItem1.Maximum = 10
            Me.trackBarItem1.Name = "trackBarItem1"
            Me.trackBarItem1.Size = New System.Drawing.Size(150, 20)
            Me.trackBarItem1.Text = "TrackBar"
            Me.trackBarItem1.Value = 5
            '
            'StatusStripLabel1
            '
            Me.StatusStripLabel1.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
            Me.StatusStripLabel1.Name = "StatusStripLabel1"
            Me.StatusStripLabel1.Size = New System.Drawing.Size(35, 13)
            Me.StatusStripLabel1.StatusString = "1 of 1"
            Me.StatusStripLabel1.Text = "Page:"
            '
            'StatusStripLabel2
            '
            Me.StatusStripLabel2.Margin = New System.Windows.Forms.Padding(0, 4, 0, 2)
            Me.StatusStripLabel2.Name = "StatusStripLabel2"
            Me.StatusStripLabel2.Size = New System.Drawing.Size(42, 13)
            Me.StatusStripLabel2.StatusString = "1"
            Me.StatusStripLabel2.Text = "Words: 1"
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label2.Location = New System.Drawing.Point(3, 8)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(88, 24)
            Me.label2.TabIndex = 28
            Me.label2.Text = "TrackBarEx"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label3.Location = New System.Drawing.Point(3, 8)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(173, 24)
            Me.label3.TabIndex = 29
            Me.label3.Text = "ContextMenuStripEx "
            Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label6.Location = New System.Drawing.Point(7, 14)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(55, 28)
            Me.label6.TabIndex = 48
            Me.label6.Text = "Gradient" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "StartColor"
            '
            'trackBarEx1
            '
            Me.trackBarEx1.Location = New System.Drawing.Point(14, 46)
            Me.trackBarEx1.Name = "trackBarEx1"
            Me.trackBarEx1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.trackBarEx1.Size = New System.Drawing.Size(168, 20)
            Me.trackBarEx1.TabIndex = 49
            Me.trackBarEx1.Text = "trackBarEx1"
            Me.trackBarEx1.TimerInterval = 100
            Me.trackBarEx1.Value = 0
            '
            'label7
            '
            Me.label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label7.Location = New System.Drawing.Point(90, 20)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(130, 1)
            Me.label7.TabIndex = 50
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label8.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label8.Location = New System.Drawing.Point(9, 90)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(63, 14)
            Me.label8.TabIndex = 52
            Me.label8.Text = "ButtonColor"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label9.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label9.Location = New System.Drawing.Point(9, 150)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(62, 28)
            Me.label9.TabIndex = 55
            Me.label9.Text = "Increase " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Button Size"
            '
            'numericUpDownExt1
            '
            Me.numericUpDownExt1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.numericUpDownExt1.Location = New System.Drawing.Point(76, 123)
            Me.numericUpDownExt1.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
            Me.numericUpDownExt1.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDownExt1.Name = "numericUpDownExt1"
            Me.numericUpDownExt1.Size = New System.Drawing.Size(129, 20)
            Me.numericUpDownExt1.TabIndex = 56
            Me.numericUpDownExt1.Value = New Decimal(New Integer() {20, 0, 0, 0})
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label10.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label10.Location = New System.Drawing.Point(7, 115)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(62, 28)
            Me.label10.TabIndex = 57
            Me.label10.Text = "Decrease " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Button Size"
            '
            'numericUpDownExt2
            '
            Me.numericUpDownExt2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.numericUpDownExt2.Location = New System.Drawing.Point(76, 150)
            Me.numericUpDownExt2.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
            Me.numericUpDownExt2.Minimum = New Decimal(New Integer() {20, 0, 0, 0})
            Me.numericUpDownExt2.Name = "numericUpDownExt2"
            Me.numericUpDownExt2.Size = New System.Drawing.Size(129, 20)
            Me.numericUpDownExt2.TabIndex = 58
            Me.numericUpDownExt2.Value = New Decimal(New Integer() {20, 0, 0, 0})
            '
            'buttonEdit2
            '
            Me.buttonEdit2.BackColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(239, Byte), Integer))
            Me.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit2.Buttons.Add(Me.buttonEditChildButton1)
            Me.buttonEdit2.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonEdit2.Controls.Add(Me.buttonEditChildButton1)
            Me.buttonEdit2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEdit2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEdit2.Location = New System.Drawing.Point(76, 82)
            Me.buttonEdit2.Name = "buttonEdit2"
            Me.buttonEdit2.Size = New System.Drawing.Size(129, 26)
            Me.buttonEdit2.TabIndex = 62
            '
            'buttonEditChildButton1
            '
            Me.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton1.Image = Nothing
            Me.buttonEditChildButton1.Name = "buttonEditChildButton1"
            Me.buttonEditChildButton1.PreferredWidth = 20
            Me.buttonEditChildButton1.TabIndex = 1
            Me.buttonEditChildButton1.Text = "..."
            Me.buttonEditChildButton1.UseVisualStyleBackColor = True
            '
            'contextMenuStripEx1
            '
            Me.contextMenuStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cutToolStripMenuItem, Me.copyToolStripMenuItem, Me.pasteToolStripMenuItem, Me.fontToolStripMenuItem, Me.bulletToolStripMenuItem, Me.hyperlinkToolStripMenuItem})
            Me.contextMenuStripEx1.Name = "contextMenuStripEx1"
            Me.contextMenuStripEx1.Size = New System.Drawing.Size(130, 161)
            Me.contextMenuStripEx1.Text = "Header"
            '
            'cutToolStripMenuItem
            '
            Me.cutToolStripMenuItem.Image = CType(resources.GetObject("cutToolStripMenuItem.Image"), System.Drawing.Image)
            Me.cutToolStripMenuItem.Name = "cutToolStripMenuItem"
            Me.cutToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
            Me.cutToolStripMenuItem.Text = "Cut"
            '
            'copyToolStripMenuItem
            '
            Me.copyToolStripMenuItem.Image = CType(resources.GetObject("copyToolStripMenuItem.Image"), System.Drawing.Image)
            Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
            Me.copyToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
            Me.copyToolStripMenuItem.Text = "Copy"
            '
            'pasteToolStripMenuItem
            '
            Me.pasteToolStripMenuItem.Image = CType(resources.GetObject("pasteToolStripMenuItem.Image"), System.Drawing.Image)
            Me.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem"
            Me.pasteToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
            Me.pasteToolStripMenuItem.Text = "Paste"
            '
            'fontToolStripMenuItem
            '
            Me.fontToolStripMenuItem.Image = CType(resources.GetObject("fontToolStripMenuItem.Image"), System.Drawing.Image)
            Me.fontToolStripMenuItem.Name = "fontToolStripMenuItem"
            Me.fontToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
            Me.fontToolStripMenuItem.Text = "Font"
            '
            'bulletToolStripMenuItem
            '
            Me.bulletToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buToolStripMenuItem, Me.tWOToolStripMenuItem, Me.thToolStripMenuItem, Me.etToolStripMenuItem})
            Me.bulletToolStripMenuItem.Image = CType(resources.GetObject("bulletToolStripMenuItem.Image"), System.Drawing.Image)
            Me.bulletToolStripMenuItem.Name = "bulletToolStripMenuItem"
            Me.bulletToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
            Me.bulletToolStripMenuItem.Text = "Bullet"
            '
            'buToolStripMenuItem
            '
            Me.buToolStripMenuItem.Image = CType(resources.GetObject("buToolStripMenuItem.Image"), System.Drawing.Image)
            Me.buToolStripMenuItem.Name = "buToolStripMenuItem"
            Me.buToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
            Me.buToolStripMenuItem.Text = "Bu"
            '
            'tWOToolStripMenuItem
            '
            Me.tWOToolStripMenuItem.Image = CType(resources.GetObject("tWOToolStripMenuItem.Image"), System.Drawing.Image)
            Me.tWOToolStripMenuItem.Name = "tWOToolStripMenuItem"
            Me.tWOToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
            Me.tWOToolStripMenuItem.Text = "TWO"
            '
            'thToolStripMenuItem
            '
            Me.thToolStripMenuItem.Image = CType(resources.GetObject("thToolStripMenuItem.Image"), System.Drawing.Image)
            Me.thToolStripMenuItem.Name = "thToolStripMenuItem"
            Me.thToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
            Me.thToolStripMenuItem.Text = "th"
            '
            'etToolStripMenuItem
            '
            Me.etToolStripMenuItem.Image = CType(resources.GetObject("etToolStripMenuItem.Image"), System.Drawing.Image)
            Me.etToolStripMenuItem.Name = "etToolStripMenuItem"
            Me.etToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
            Me.etToolStripMenuItem.Text = "et"
            '
            'hyperlinkToolStripMenuItem
            '
            Me.hyperlinkToolStripMenuItem.Image = CType(resources.GetObject("hyperlinkToolStripMenuItem.Image"), System.Drawing.Image)
            Me.hyperlinkToolStripMenuItem.Name = "hyperlinkToolStripMenuItem"
            Me.hyperlinkToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
            Me.hyperlinkToolStripMenuItem.Text = "Hyperlink"
            '
            'gradientLabel1
            '
            Me.gradientLabel1.BackgroundColor = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            Me.gradientLabel1.BorderSides = CType((((System.Windows.Forms.Border3DSide.Left Or System.Windows.Forms.Border3DSide.Top) _
                        Or System.Windows.Forms.Border3DSide.Right) _
                        Or System.Windows.Forms.Border3DSide.Bottom), System.Windows.Forms.Border3DSide)
            Me.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.gradientLabel1.ContextMenuStrip = Me.contextMenuStripEx1
            Me.gradientLabel1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.gradientLabel1.Location = New System.Drawing.Point(53, 62)
            Me.gradientLabel1.Name = "gradientLabel1"
            Me.gradientLabel1.Size = New System.Drawing.Size(135, 36)
            Me.gradientLabel1.TabIndex = 64
            Me.gradientLabel1.Text = "Right click to view " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the ContextMenuStripEx"
            Me.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'checkBoxAdv1
            '
            Me.checkBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv1.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv1.Location = New System.Drawing.Point(5, 173)
            Me.checkBoxAdv1.Name = "checkBoxAdv1"
            Me.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv1.Size = New System.Drawing.Size(168, 17)
            Me.checkBoxAdv1.TabIndex = 65
            Me.checkBoxAdv1.Text = "Right To Left"
            Me.checkBoxAdv1.ThemesEnabled = True
            '
            'comboBox4
            '
            Me.comboBox4.DropDownHeight = 185
            Me.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBox4.FormattingEnabled = True
            Me.comboBox4.IntegralHeight = False
            Me.comboBox4.ItemHeight = 14
            Me.comboBox4.Items.AddRange(New Object() {"Blue", "Black", "Silver"})
            Me.comboBox4.Location = New System.Drawing.Point(96, 140)
            Me.comboBox4.Name = "comboBox4"
            Me.comboBox4.Size = New System.Drawing.Size(115, 22)
            Me.comboBox4.TabIndex = 69
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label12.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label12.Location = New System.Drawing.Point(3, 143)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(86, 14)
            Me.label12.TabIndex = 68
            Me.label12.Text = "Office Style Color"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label11.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label11.Location = New System.Drawing.Point(6, 112)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(65, 14)
            Me.label11.TabIndex = 70
            Me.label11.Text = "Add Header"
            '
            'textBoxExt1
            '
            Me.textBoxExt1.Location = New System.Drawing.Point(96, 111)
            Me.textBoxExt1.Name = "textBoxExt1"
            Me.textBoxExt1.OverflowIndicatorToolTipText = Nothing
            Me.textBoxExt1.Size = New System.Drawing.Size(115, 20)
            Me.textBoxExt1.TabIndex = 71
            '
            'label13
            '
            Me.label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label13.Location = New System.Drawing.Point(150, 20)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(75, 1)
            Me.label13.TabIndex = 72
            '
            'checkBoxAdv5
            '
            Me.checkBoxAdv5.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv5.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv5.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv5.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv5.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv5.Location = New System.Drawing.Point(10, 181)
            Me.checkBoxAdv5.Name = "checkBoxAdv5"
            Me.checkBoxAdv5.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv5.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv5.Size = New System.Drawing.Size(126, 27)
            Me.checkBoxAdv5.TabIndex = 73
            Me.checkBoxAdv5.Text = "Right To Left"
            Me.checkBoxAdv5.ThemesEnabled = True
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.panel1.Controls.Add(Me.checkBoxAdv2)
            Me.panel1.Controls.Add(Me.checkBoxAdv3)
            Me.panel1.Controls.Add(Me.comboBox1)
            Me.panel1.Controls.Add(Me.label14)
            Me.panel1.Controls.Add(Me.label4)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(218, 320)
            Me.panel1.TabIndex = 75
            '
            'checkBoxAdv2
            '
            Me.checkBoxAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv2.Checked = True
            Me.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv2.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv2.Location = New System.Drawing.Point(8, 95)
            Me.checkBoxAdv2.Name = "checkBoxAdv2"
            Me.checkBoxAdv2.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv2.Size = New System.Drawing.Size(136, 24)
            Me.checkBoxAdv2.TabIndex = 54
            Me.checkBoxAdv2.Text = "Sizing Grip"
            Me.checkBoxAdv2.ThemesEnabled = True
            '
            'checkBoxAdv3
            '
            Me.checkBoxAdv3.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBoxAdv3.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv3.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv3.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv3.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv3.Location = New System.Drawing.Point(8, 133)
            Me.checkBoxAdv3.Name = "checkBoxAdv3"
            Me.checkBoxAdv3.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv3.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv3.Size = New System.Drawing.Size(168, 17)
            Me.checkBoxAdv3.TabIndex = 53
            Me.checkBoxAdv3.Text = "Right To Left"
            Me.checkBoxAdv3.ThemesEnabled = True
            '
            'comboBox1
            '
            Me.comboBox1.DropDownHeight = 185
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.comboBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.IntegralHeight = False
            Me.comboBox1.ItemHeight = 14
            Me.comboBox1.Items.AddRange(New Object() {"Blue", "Silver", "Black"})
            Me.comboBox1.Location = New System.Drawing.Point(95, 60)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(109, 22)
            Me.comboBox1.TabIndex = 49
            '
            'label14
            '
            Me.label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label14.Location = New System.Drawing.Point(110, 22)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(100, 1)
            Me.label14.TabIndex = 48
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label4.Location = New System.Drawing.Point(3, 62)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(86, 14)
            Me.label4.TabIndex = 47
            Me.label4.Text = "Office Style Color"
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label1.Location = New System.Drawing.Point(3, 8)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(128, 24)
            Me.label1.TabIndex = 46
            Me.label1.Text = "StatusStripEx"
            Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'panel2
            '
            Me.panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.panel2.Controls.Add(Me.label7)
            Me.panel2.Controls.Add(Me.TextBox1)
            Me.panel2.Controls.Add(Me.panel4)
            Me.panel2.Controls.Add(Me.label2)
            Me.panel2.Controls.Add(Me.trackBarEx1)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel2.Location = New System.Drawing.Point(460, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(230, 320)
            Me.panel2.TabIndex = 76
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(186, 46)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ReadOnly = True
            Me.TextBox1.Size = New System.Drawing.Size(24, 20)
            Me.TextBox1.TabIndex = 76
            Me.TextBox1.Text = "0"
            '
            'panel4
            '
            Me.panel4.Controls.Add(Me.label6)
            Me.panel4.Controls.Add(Me.checkBoxAdv4)
            Me.panel4.Controls.Add(Me.label8)
            Me.panel4.Controls.Add(Me.label5)
            Me.panel4.Controls.Add(Me.label10)
            Me.panel4.Controls.Add(Me.buttonEdit3)
            Me.panel4.Controls.Add(Me.buttonEdit2)
            Me.panel4.Controls.Add(Me.buttonEdit1)
            Me.panel4.Controls.Add(Me.numericUpDownExt2)
            Me.panel4.Controls.Add(Me.numericUpDownExt1)
            Me.panel4.Controls.Add(Me.label9)
            Me.panel4.Controls.Add(Me.checkBoxAdv5)
            Me.panel4.Location = New System.Drawing.Point(6, 72)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(214, 237)
            Me.panel4.TabIndex = 80
            '
            'checkBoxAdv4
            '
            Me.checkBoxAdv4.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv4.Checked = True
            Me.checkBoxAdv4.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv4.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv4.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv4.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv4.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv4.Location = New System.Drawing.Point(10, 214)
            Me.checkBoxAdv4.Name = "checkBoxAdv4"
            Me.checkBoxAdv4.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv4.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv4.Size = New System.Drawing.Size(113, 17)
            Me.checkBoxAdv4.TabIndex = 79
            Me.checkBoxAdv4.Text = "Show Buttons"
            Me.checkBoxAdv4.ThemesEnabled = True
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label5.Location = New System.Drawing.Point(9, 49)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(50, 28)
            Me.label5.TabIndex = 78
            Me.label5.Text = "Gradient" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EndColor"
            '
            'buttonEdit3
            '
            Me.buttonEdit3.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit3.Buttons.Add(Me.buttonEditChildButton3)
            Me.buttonEdit3.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonEdit3.Controls.Add(Me.buttonEditChildButton3)
            Me.buttonEdit3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEdit3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEdit3.Location = New System.Drawing.Point(76, 46)
            Me.buttonEdit3.Name = "buttonEdit3"
            Me.buttonEdit3.Size = New System.Drawing.Size(129, 26)
            Me.buttonEdit3.TabIndex = 77
            '
            'buttonEditChildButton3
            '
            Me.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton3.Image = Nothing
            Me.buttonEditChildButton3.Name = "buttonEditChildButton3"
            Me.buttonEditChildButton3.PreferredWidth = 20
            Me.buttonEditChildButton3.TabIndex = 1
            Me.buttonEditChildButton3.Text = "..."
            Me.buttonEditChildButton3.UseVisualStyleBackColor = True
            '
            'buttonEdit1
            '
            Me.buttonEdit1.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(198, Byte), Integer))
            Me.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.buttonEdit1.Buttons.Add(Me.buttonEditChildButton2)
            Me.buttonEdit1.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonEdit1.Controls.Add(Me.buttonEditChildButton2)
            Me.buttonEdit1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEdit1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEdit1.Location = New System.Drawing.Point(76, 10)
            Me.buttonEdit1.Name = "buttonEdit1"
            Me.buttonEdit1.Size = New System.Drawing.Size(129, 26)
            Me.buttonEdit1.TabIndex = 76
            '
            'buttonEditChildButton2
            '
            Me.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight
            Me.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window
            Me.buttonEditChildButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.buttonEditChildButton2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonEditChildButton2.Image = Nothing
            Me.buttonEditChildButton2.Name = "buttonEditChildButton2"
            Me.buttonEditChildButton2.PreferredWidth = 20
            Me.buttonEditChildButton2.TabIndex = 1
            Me.buttonEditChildButton2.Text = "..."
            Me.buttonEditChildButton2.UseVisualStyleBackColor = True
            '
            'panel3
            '
            Me.panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.panel3.Controls.Add(Me.label13)
            Me.panel3.Controls.Add(Me.checkBoxAdv6)
            Me.panel3.Controls.Add(Me.label3)
            Me.panel3.Controls.Add(Me.checkBoxAdv1)
            Me.panel3.Controls.Add(Me.gradientLabel1)
            Me.panel3.Controls.Add(Me.label11)
            Me.panel3.Controls.Add(Me.textBoxExt1)
            Me.panel3.Controls.Add(Me.label12)
            Me.panel3.Controls.Add(Me.comboBox4)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(218, 0)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(242, 320)
            Me.panel3.TabIndex = 77
            '
            'checkBoxAdv6
            '
            Me.checkBoxAdv6.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv6.Checked = True
            Me.checkBoxAdv6.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxAdv6.GradientEnd = System.Drawing.SystemColors.ControlDark
            Me.checkBoxAdv6.GradientStart = System.Drawing.SystemColors.Control
            Me.checkBoxAdv6.HotBorderColor = System.Drawing.SystemColors.WindowFrame
            Me.checkBoxAdv6.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
            Me.checkBoxAdv6.Location = New System.Drawing.Point(3, 208)
            Me.checkBoxAdv6.Name = "checkBoxAdv6"
            Me.checkBoxAdv6.ShadowColor = System.Drawing.Color.Black
            Me.checkBoxAdv6.ShadowOffset = New System.Drawing.Point(2, 2)
            Me.checkBoxAdv6.Size = New System.Drawing.Size(141, 20)
            Me.checkBoxAdv6.TabIndex = 75
            Me.checkBoxAdv6.Text = "DropDown Shadow"
            Me.checkBoxAdv6.ThemesEnabled = True
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(254, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(690, 347)
            Me.Controls.Add(Me.panel3)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.statusStripEx1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Office Style Controls"
            Me.statusStripEx1.ResumeLayout(False)
            Me.statusStripEx1.PerformLayout()
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownExt2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit2.ResumeLayout(False)
            Me.buttonEdit2.PerformLayout()
            Me.contextMenuStripEx1.ResumeLayout(False)
            CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textBoxExt1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.checkBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            CType(Me.checkBoxAdv4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.buttonEdit3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit3.ResumeLayout(False)
            Me.buttonEdit3.PerformLayout()
            CType(Me.buttonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.buttonEdit1.ResumeLayout(False)
            Me.buttonEdit1.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.panel3.PerformLayout()
            CType(Me.checkBoxAdv6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private statusStripEx1 As Syncfusion.Windows.Forms.Tools.StatusStripEx
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
        Private toolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
        Private toolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
        Private toolStripPanelItem1 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
        Private toolStripButton3 As System.Windows.Forms.ToolStripButton
        Private toolStripButton4 As System.Windows.Forms.ToolStripButton
        Private statusLabel As System.Windows.Forms.ToolStripStatusLabel
		Private trackBarItem1 As Syncfusion.Windows.Forms.Tools.TrackBarItem
        Private label6 As System.Windows.Forms.Label
        Private WithEvents trackBarEx1 As Syncfusion.Windows.Forms.Tools.TrackBarEx
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private WithEvents numericUpDownExt1 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private label10 As System.Windows.Forms.Label
		Private WithEvents numericUpDownExt2 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private colorDialog1 As System.Windows.Forms.ColorDialog
		Private WithEvents buttonEdit2 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton1 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private contextMenuStripEx1 As Syncfusion.Windows.Forms.Tools.ContextMenuStripEx
		Private cutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private pasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private fontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private bulletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private buToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private tWOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private thToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private etToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private hyperlinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private gradientLabel1 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private WithEvents checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents comboBox4 As System.Windows.Forms.ComboBox
		Private label12 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private WithEvents textBoxExt1 As Syncfusion.Windows.Forms.Tools.TextBoxExt
		Private label13 As System.Windows.Forms.Label
		Private WithEvents checkBoxAdv5 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents checkBoxAdv3 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private label14 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private panel2 As System.Windows.Forms.Panel
		Private panel3 As System.Windows.Forms.Panel
		Private WithEvents buttonEdit1 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton2 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private WithEvents buttonEdit3 As Syncfusion.Windows.Forms.Tools.ButtonEdit
		Private buttonEditChildButton3 As Syncfusion.Windows.Forms.Tools.ButtonEditChildButton
		Private label5 As System.Windows.Forms.Label
		Private WithEvents checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv4 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents checkBoxAdv6 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
        Private panel4 As System.Windows.Forms.Panel
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents StatusStripLabel1 As Syncfusion.Windows.Forms.Tools.StatusStripLabel
        Friend WithEvents StatusStripLabel2 As Syncfusion.Windows.Forms.Tools.StatusStripLabel

	End Class
End Namespace

