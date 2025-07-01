Imports Microsoft.VisualBasic
Imports System.Drawing
Namespace BackStageDemo
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.ribbonControlAdv1 = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
            Me.backStageView1 = New Syncfusion.Windows.Forms.BackStageView(Me.components)
            Me.backStage1 = New Syncfusion.Windows.Forms.BackStage()
            Me.backStageButton1 = New Syncfusion.Windows.Forms.BackStageButton()
            Me.backStageButton2 = New Syncfusion.Windows.Forms.BackStageButton()
            Me.backStageButton3 = New Syncfusion.Windows.Forms.BackStageButton()
            Me.backStageButton4 = New Syncfusion.Windows.Forms.BackStageButton()
            Me.backStageTab1 = New Syncfusion.Windows.Forms.BackStageTab()
            Me.label1 = New System.Windows.Forms.Label()
            Me.backStageTab2 = New Syncfusion.Windows.Forms.BackStageTab()
            Me.backStageTab3 = New Syncfusion.Windows.Forms.BackStageTab()
            Me.backStageTab4 = New Syncfusion.Windows.Forms.BackStageTab()
            Me.backStageTab5 = New Syncfusion.Windows.Forms.BackStageTab()
            Me.backStageTab6 = New Syncfusion.Windows.Forms.BackStageTab()
            Me.backStageButton5 = New Syncfusion.Windows.Forms.BackStageButton()
            Me.backStageButton6 = New Syncfusion.Windows.Forms.BackStageButton()
            Me.toolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
            Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripPanelItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripPanelItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
            Me.toolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
            Me.toolStripButton11 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton16 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripPanelItem4 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton6 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton7 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton8 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton9 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton10 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.toolStripSplitButtonEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx()
            Me.toolStripSplitButtonEx3 = New Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx()
            Me.toolStripButton17 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton18 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripTabItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
            Me.toolStripEx3 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripButton12 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton13 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton14 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx4 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripButton15 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripTabItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
            Me.toolStripEx7 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripButton23 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton24 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton25 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx8 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripButton26 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx5 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripButton19 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton20 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton21 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx6 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripButton22 = New System.Windows.Forms.ToolStripButton()
            CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ribbonControlAdv1.SuspendLayout()
            CType(Me.backStage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backStage1.SuspendLayout()
            Me.backStageTab1.SuspendLayout()
            Me.toolStripTabItem1.Panel.SuspendLayout()
            Me.toolStripEx1.SuspendLayout()
            Me.toolStripEx2.SuspendLayout()
            Me.toolStripTabItem2.Panel.SuspendLayout()
            Me.toolStripEx3.SuspendLayout()
            Me.toolStripEx4.SuspendLayout()
            Me.toolStripTabItem3.Panel.SuspendLayout()
            Me.toolStripEx7.SuspendLayout()
            Me.toolStripEx8.SuspendLayout()
            Me.toolStripEx5.SuspendLayout()
            Me.toolStripEx6.SuspendLayout()
            Me.SuspendLayout()
            '
            'ribbonControlAdv1
            '
            Me.ribbonControlAdv1.BackStageView = Me.backStageView1
            Me.ribbonControlAdv1.CanReduceCaptionLength = False
            Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1)
            Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem2)
            Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem3)
            Me.ribbonControlAdv1.HideMenuButtonToolTip = False
            Me.ribbonControlAdv1.Location = New System.Drawing.Point(1, 0)
            Me.ribbonControlAdv1.MaximizeToolTip = "Maximize Ribbon"
            Me.ribbonControlAdv1.MenuButtonText = "File"
            Me.ribbonControlAdv1.MenuButtonWidth = 56
            Me.ribbonControlAdv1.MenuColor = System.Drawing.Color.Red
            Me.ribbonControlAdv1.MinimizeToolTip = "Minimize Ribbon"
            Me.ribbonControlAdv1.Name = "ribbonControlAdv1"
            Me.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver
            '
            'ribbonControlAdv1.OfficeMenu
            '
            Me.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
            Me.ribbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(12, 65)
            Me.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
            Me.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2010
            Me.ribbonControlAdv1.SelectedTab = Me.toolStripTabItem1
            Me.ribbonControlAdv1.Size = New System.Drawing.Size(805, 149)
            Me.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
            Me.ribbonControlAdv1.TabIndex = 0
            Me.ribbonControlAdv1.Text = "ribbonControlAdv1"
            Me.ribbonControlAdv1.TitleAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Center
            Me.ribbonControlAdv1.TitleColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            '
            'backStageView1
            '
            Me.backStageView1.BackStage = Me.backStage1
            Me.backStageView1.HostControl = Nothing
            Me.backStageView1.HostForm = Me
            '
            'backStage1
            '
            Me.backStage1.AllowDrop = True
            Me.backStage1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.backStage1.Controls.Add(Me.backStageButton1)
            Me.backStage1.Controls.Add(Me.backStageButton2)
            Me.backStage1.Controls.Add(Me.backStageButton3)
            Me.backStage1.Controls.Add(Me.backStageButton4)
            Me.backStage1.Controls.Add(Me.backStageTab1)
            Me.backStage1.Controls.Add(Me.backStageTab2)
            Me.backStage1.Controls.Add(Me.backStageTab3)
            Me.backStage1.Controls.Add(Me.backStageTab4)
            Me.backStage1.Controls.Add(Me.backStageTab5)
            Me.backStage1.Controls.Add(Me.backStageTab6)
            Me.backStage1.Controls.Add(Me.backStageButton5)
            Me.backStage1.Controls.Add(Me.backStageButton6)
            Me.backStage1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.backStage1.ItemSize = New System.Drawing.Size(130, 30)
            Me.backStage1.Location = New System.Drawing.Point(5, 55)
            Me.backStage1.Name = "backStage1"
            Me.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver
            Me.backStage1.Size = New System.Drawing.Size(795, 461)
            Me.backStage1.TabIndex = 1
            Me.backStage1.Visible = False
            '
            'backStageButton1
            '
            Me.backStageButton1.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton1.Location = New System.Drawing.Point(0, 0)
            Me.backStageButton1.Name = "backStageButton1"
            Me.backStageButton1.Size = New System.Drawing.Size(120, 23)
            Me.backStageButton1.TabIndex = 1
            '
            'backStageButton2
            '
            Me.backStageButton2.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton2.Location = New System.Drawing.Point(0, 0)
            Me.backStageButton2.Name = "backStageButton2"
            Me.backStageButton2.Size = New System.Drawing.Size(120, 23)
            Me.backStageButton2.TabIndex = 2
            '
            'backStageButton3
            '
            Me.backStageButton3.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton3.Location = New System.Drawing.Point(0, 0)
            Me.backStageButton3.Name = "backStageButton3"
            Me.backStageButton3.Size = New System.Drawing.Size(120, 23)
            Me.backStageButton3.TabIndex = 3
            '
            'backStageButton4
            '
            Me.backStageButton4.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton4.Location = New System.Drawing.Point(0, 0)
            Me.backStageButton4.Name = "backStageButton4"
            Me.backStageButton4.Size = New System.Drawing.Size(120, 23)
            Me.backStageButton4.TabIndex = 4
            '
            'backStageTab1
            '
            Me.backStageTab1.BackColor = System.Drawing.Color.White
            Me.backStageTab1.Controls.Add(Me.label1)
            Me.backStageTab1.Image = Nothing
            Me.backStageTab1.ImageSize = New System.Drawing.Size(16, 16)
            Me.backStageTab1.Location = New System.Drawing.Point(129, 0)
            Me.backStageTab1.Name = "backStageTab1"
            Me.backStageTab1.ShowCloseButton = True
            Me.backStageTab1.Size = New System.Drawing.Size(666, 461)
            Me.backStageTab1.TabIndex = 6
            Me.backStageTab1.Text = "Info"
            Me.backStageTab1.ThemesEnabled = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(22, 19)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(109, 16)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Select color here"
            '
            'backStageTab2
            '
            Me.backStageTab2.BackColor = System.Drawing.Color.White
            Me.backStageTab2.Image = Nothing
            Me.backStageTab2.ImageSize = New System.Drawing.Size(16, 16)
            Me.backStageTab2.Location = New System.Drawing.Point(129, 0)
            Me.backStageTab2.Name = "backStageTab2"
            Me.backStageTab2.ShowCloseButton = True
            Me.backStageTab2.Size = New System.Drawing.Size(666, 461)
            Me.backStageTab2.TabIndex = 7
            Me.backStageTab2.Text = "Recent"
            Me.backStageTab2.ThemesEnabled = False
            '
            'backStageTab3
            '
            Me.backStageTab3.BackColor = System.Drawing.Color.White
            Me.backStageTab3.Image = Nothing
            Me.backStageTab3.ImageSize = New System.Drawing.Size(16, 16)
            Me.backStageTab3.Location = New System.Drawing.Point(129, 0)
            Me.backStageTab3.Name = "backStageTab3"
            Me.backStageTab3.ShowCloseButton = True
            Me.backStageTab3.Size = New System.Drawing.Size(666, 461)
            Me.backStageTab3.TabIndex = 8
            Me.backStageTab3.Text = "New"
            Me.backStageTab3.ThemesEnabled = False
            '
            'backStageTab4
            '
            Me.backStageTab4.BackColor = System.Drawing.Color.White
            Me.backStageTab4.Image = Nothing
            Me.backStageTab4.ImageSize = New System.Drawing.Size(16, 16)
            Me.backStageTab4.Location = New System.Drawing.Point(129, 0)
            Me.backStageTab4.Name = "backStageTab4"
            Me.backStageTab4.ShowCloseButton = True
            Me.backStageTab4.Size = New System.Drawing.Size(666, 461)
            Me.backStageTab4.TabIndex = 9
            Me.backStageTab4.Text = "Print"
            Me.backStageTab4.ThemesEnabled = False
            '
            'backStageTab5
            '
            Me.backStageTab5.BackColor = System.Drawing.Color.White
            Me.backStageTab5.Image = Nothing
            Me.backStageTab5.ImageSize = New System.Drawing.Size(16, 16)
            Me.backStageTab5.Location = New System.Drawing.Point(129, 0)
            Me.backStageTab5.Name = "backStageTab5"
            Me.backStageTab5.ShowCloseButton = True
            Me.backStageTab5.Size = New System.Drawing.Size(666, 461)
            Me.backStageTab5.TabIndex = 10
            Me.backStageTab5.Text = "Save and Send"
            Me.backStageTab5.ThemesEnabled = False
            '
            'backStageTab6
            '
            Me.backStageTab6.BackColor = System.Drawing.Color.White
            Me.backStageTab6.Image = Nothing
            Me.backStageTab6.ImageSize = New System.Drawing.Size(16, 16)
            Me.backStageTab6.Location = New System.Drawing.Point(129, 0)
            Me.backStageTab6.Name = "backStageTab6"
            Me.backStageTab6.ShowCloseButton = True
            Me.backStageTab6.Size = New System.Drawing.Size(666, 461)
            Me.backStageTab6.TabIndex = 11
            Me.backStageTab6.Text = "Help"
            Me.backStageTab6.ThemesEnabled = False
            '
            'backStageButton5
            '
            Me.backStageButton5.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton5.Location = New System.Drawing.Point(10, 342)
            Me.backStageButton5.Name = "backStageButton5"
            Me.backStageButton5.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton5.TabIndex = 12
            Me.backStageButton5.Text = "Option"
            '
            'backStageButton6
            '
            Me.backStageButton6.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton6.Location = New System.Drawing.Point(10, 367)
            Me.backStageButton6.Name = "backStageButton6"
            Me.backStageButton6.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton6.TabIndex = 13
            Me.backStageButton6.Text = "Exit"
            '
            'toolStripTabItem1
            '
            Me.toolStripTabItem1.ForeColor = System.Drawing.Color.Red
            Me.toolStripTabItem1.Name = "toolStripTabItem1"
            '
            'ribbonControlAdv1.RibbonPanel1
            '
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx1)
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx2)
            Me.toolStripTabItem1.Panel.Name = "RibbonPanel1"
            Me.toolStripTabItem1.Panel.ScrollPosition = 0
            Me.toolStripTabItem1.Panel.TabIndex = 0
            Me.toolStripTabItem1.Panel.Text = "Home"
            Me.toolStripTabItem1.Position = 0
            Me.toolStripTabItem1.Size = New System.Drawing.Size(55, 23)
            Me.toolStripTabItem1.Text = "Home"
            '
            'toolStripEx1
            '
            Me.toolStripEx1.AutoSize = False
            Me.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx1.Image = Nothing
            Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.toolStripPanelItem1})
            Me.toolStripEx1.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx1.Name = "toolStripEx1"
            Me.toolStripEx1.Office12Mode = False
            Me.toolStripEx1.Size = New System.Drawing.Size(139, 92)
            Me.toolStripEx1.TabIndex = 3
            Me.toolStripEx1.Text = "Clipboard"
            '
            'toolStripButton1
            '
            Me.toolStripButton1.AutoSize = False
            Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
            Me.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton1.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
            Me.toolStripButton1.Name = "toolStripButton1"
            Me.toolStripButton1.Size = New System.Drawing.Size(39, 74)
            Me.toolStripButton1.Text = "Paste"
            Me.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripPanelItem1
            '
            Me.toolStripPanelItem1.CausesValidation = False
            Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton2, Me.toolStripButton3, Me.toolStripButton4})
            Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Size = New System.Drawing.Size(27, 78)
            Me.toolStripPanelItem1.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Transparent = True
            '
            'toolStripButton2
            '
            Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
            Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton2.Name = "toolStripButton2"
            Me.toolStripButton2.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton2.Text = "Cut"
            '
            'toolStripButton3
            '
            Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton3.Text = "Copy"
            '
            'toolStripButton4
            '
            Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
            Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton4.Name = "toolStripButton4"
            Me.toolStripButton4.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton4.Text = "Format"
            '
            'toolStripEx2
            '
            Me.toolStripEx2.AutoSize = False
            Me.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx2.Image = Nothing
            Me.toolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem2})
            Me.toolStripEx2.Location = New System.Drawing.Point(141, 1)
            Me.toolStripEx2.Name = "toolStripEx2"
            Me.toolStripEx2.Office12Mode = False
            Me.toolStripEx2.Size = New System.Drawing.Size(248, 92)
            Me.toolStripEx2.TabIndex = 2
            Me.toolStripEx2.Text = "Basic text"
            '
            'toolStripPanelItem2
            '
            Me.toolStripPanelItem2.AutoSize = False
            Me.toolStripPanelItem2.CausesValidation = False
            Me.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem3, Me.toolStripPanelItem4})
            Me.toolStripPanelItem2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
            Me.toolStripPanelItem2.Name = "toolStripPanelItem2"
            Me.toolStripPanelItem2.RowCount = 2
            Me.toolStripPanelItem2.Size = New System.Drawing.Size(220, 77)
            Me.toolStripPanelItem2.Text = "toolStripPanelItem2"
            Me.toolStripPanelItem2.Transparent = False
            '
            'toolStripPanelItem3
            '
            Me.toolStripPanelItem3.AutoSize = False
            Me.toolStripPanelItem3.CausesValidation = False
            Me.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripComboBox1, Me.toolStripComboBox2, Me.toolStripButton11, Me.toolStripButton16})
            Me.toolStripPanelItem3.Name = "toolStripPanelItem3"
            Me.toolStripPanelItem3.RowCount = 1
            Me.toolStripPanelItem3.Size = New System.Drawing.Size(260, 35)
            Me.toolStripPanelItem3.Transparent = True
            '
            'toolStripComboBox1
            '
            Me.toolStripComboBox1.Name = "toolStripComboBox1"
            Me.toolStripComboBox1.Size = New System.Drawing.Size(121, 23)
            Me.toolStripComboBox1.Text = "Caibri"
            '
            'toolStripComboBox2
            '
            Me.toolStripComboBox2.AutoSize = False
            Me.toolStripComboBox2.Name = "toolStripComboBox2"
            Me.toolStripComboBox2.Size = New System.Drawing.Size(35, 23)
            Me.toolStripComboBox2.Text = "20"
            '
            'toolStripButton11
            '
            Me.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton11.Name = "toolStripButton11"
            Me.toolStripButton11.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton11.Text = "toolStripButton11"
            '
            'toolStripButton16
            '
            Me.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton16.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton16.Name = "toolStripButton16"
            Me.toolStripButton16.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton16.Text = "toolStripButton16"
            '
            'toolStripPanelItem4
            '
            Me.toolStripPanelItem4.AutoSize = False
            Me.toolStripPanelItem4.CausesValidation = False
            Me.toolStripPanelItem4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton5, Me.toolStripButton6, Me.toolStripButton7, Me.toolStripButton8, Me.toolStripButton9, Me.toolStripButton10, Me.toolStripSeparator1, Me.toolStripSplitButtonEx1, Me.toolStripSplitButtonEx3, Me.toolStripButton17, Me.toolStripButton18})
            Me.toolStripPanelItem4.Name = "toolStripPanelItem4"
            Me.toolStripPanelItem4.RowCount = 1
            Me.toolStripPanelItem4.Size = New System.Drawing.Size(210, 30)
            Me.toolStripPanelItem4.Text = "toolStripPanelItem4"
            Me.toolStripPanelItem4.Transparent = True
            '
            'toolStripButton5
            '
            Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton5.Name = "toolStripButton5"
            Me.toolStripButton5.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton5.Text = "toolStripButton5"
            Me.ribbonControlAdv1.SetUseInQuickAccessMenu(Me.toolStripButton5, True)
            '
            'toolStripButton6
            '
            Me.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton6.Name = "toolStripButton6"
            Me.toolStripButton6.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton6.Text = "toolStripButton6"
            '
            'toolStripButton7
            '
            Me.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton7.Name = "toolStripButton7"
            Me.toolStripButton7.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton7.Text = "toolStripButton7"
            '
            'toolStripButton8
            '
            Me.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton8.Name = "toolStripButton8"
            Me.toolStripButton8.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton8.Text = "toolStripButton8"
            '
            'toolStripButton9
            '
            Me.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton9.Name = "toolStripButton9"
            Me.toolStripButton9.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton9.Text = "toolStripButton9"
            '
            'toolStripButton10
            '
            Me.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton10.Name = "toolStripButton10"
            Me.toolStripButton10.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton10.Text = "toolStripButton10"
            '
            'toolStripSeparator1
            '
            Me.toolStripSeparator1.Name = "toolStripSeparator1"
            Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 23)
            '
            'toolStripSplitButtonEx1
            '
            Me.toolStripSplitButtonEx1.Image = CType(resources.GetObject("toolStripSplitButtonEx1.Image"), System.Drawing.Image)
            Me.toolStripSplitButtonEx1.Name = "toolStripSplitButtonEx1"
            Me.toolStripSplitButtonEx1.Size = New System.Drawing.Size(33, 20)
            '
            'toolStripSplitButtonEx3
            '
            Me.toolStripSplitButtonEx3.Image = CType(resources.GetObject("toolStripSplitButtonEx3.Image"), System.Drawing.Image)
            Me.toolStripSplitButtonEx3.Name = "toolStripSplitButtonEx3"
            Me.toolStripSplitButtonEx3.Size = New System.Drawing.Size(33, 20)
            '
            'toolStripButton17
            '
            Me.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton17.Image = CType(resources.GetObject("toolStripButton17.Image"), System.Drawing.Image)
            Me.toolStripButton17.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton17.Name = "toolStripButton17"
            Me.toolStripButton17.Size = New System.Drawing.Size(23, 20)
            Me.toolStripButton17.Text = "toolStripButton17"
            '
            'toolStripButton18
            '
            Me.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            Me.toolStripButton18.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton18.Name = "toolStripButton18"
            Me.toolStripButton18.Size = New System.Drawing.Size(23, 4)
            Me.toolStripButton18.Text = "toolStripButton18"
            '
            'toolStripTabItem2
            '
            Me.toolStripTabItem2.Name = "toolStripTabItem2"
            '
            'ribbonControlAdv1.RibbonPanel2
            '
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx3)
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx4)
            Me.toolStripTabItem2.Panel.Name = "RibbonPanel2"
            Me.toolStripTabItem2.Panel.ScrollPosition = 0
            Me.toolStripTabItem2.Panel.TabIndex = 1
            Me.toolStripTabItem2.Panel.Text = "Insert"
            Me.toolStripTabItem2.Position = 1
            Me.toolStripTabItem2.Size = New System.Drawing.Size(53, 23)
            Me.toolStripTabItem2.Text = "Insert"
            '
            'toolStripEx3
            '
            Me.toolStripEx3.AutoSize = False
            Me.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx3.Image = Nothing
            Me.toolStripEx3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton12, Me.toolStripButton13, Me.toolStripButton14})
            Me.toolStripEx3.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx3.Name = "toolStripEx3"
            Me.toolStripEx3.Office12Mode = False
            Me.toolStripEx3.Size = New System.Drawing.Size(210, 0)
            Me.toolStripEx3.TabIndex = 0
            Me.toolStripEx3.Text = "Page"
            '
            'toolStripButton12
            '
            Me.toolStripButton12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton12.Name = "toolStripButton12"
            Me.toolStripButton12.Size = New System.Drawing.Size(68, 0)
            Me.toolStripButton12.Text = "CoverPage"
            Me.toolStripButton12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton13
            '
            Me.toolStripButton13.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton13.Name = "toolStripButton13"
            Me.toolStripButton13.Size = New System.Drawing.Size(66, 0)
            Me.toolStripButton13.Text = "Blankpage"
            Me.toolStripButton13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton14
            '
            Me.toolStripButton14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton14.Name = "toolStripButton14"
            Me.toolStripButton14.Size = New System.Drawing.Size(66, 0)
            Me.toolStripButton14.Text = "PageBreak"
            Me.toolStripButton14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx4
            '
            Me.toolStripEx4.AutoSize = False
            Me.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx4.Image = Nothing
            Me.toolStripEx4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton15})
            Me.toolStripEx4.Location = New System.Drawing.Point(212, 1)
            Me.toolStripEx4.Name = "toolStripEx4"
            Me.toolStripEx4.Office12Mode = False
            Me.toolStripEx4.Size = New System.Drawing.Size(71, 0)
            Me.toolStripEx4.TabIndex = 1
            Me.toolStripEx4.Text = "Illustrations"
            '
            'toolStripButton15
            '
            Me.toolStripButton15.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton15.Name = "toolStripButton15"
            Me.toolStripButton15.Size = New System.Drawing.Size(48, 0)
            Me.toolStripButton15.Text = "Picture"
            Me.toolStripButton15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripTabItem3
            '
            Me.toolStripTabItem3.Name = "toolStripTabItem3"
            '
            'ribbonControlAdv1.RibbonPanel3
            '
            Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx7)
            Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx8)
            Me.toolStripTabItem3.Panel.Name = "RibbonPanel3"
            Me.toolStripTabItem3.Panel.ScrollPosition = 0
            Me.toolStripTabItem3.Panel.TabIndex = 2
            Me.toolStripTabItem3.Panel.Text = "Property"
            Me.toolStripTabItem3.Position = 2
            Me.toolStripTabItem3.Size = New System.Drawing.Size(66, 23)
            Me.toolStripTabItem3.Text = "Property"
            '
            'toolStripEx7
            '
            Me.toolStripEx7.AutoSize = False
            Me.toolStripEx7.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx7.Image = Nothing
            Me.toolStripEx7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton23, Me.toolStripButton24, Me.toolStripButton25})
            Me.toolStripEx7.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx7.Name = "toolStripEx7"
            Me.toolStripEx7.Office12Mode = False
            Me.toolStripEx7.Size = New System.Drawing.Size(210, 0)
            Me.toolStripEx7.TabIndex = 2
            Me.toolStripEx7.Text = "Page"
            '
            'toolStripButton23
            '
            Me.toolStripButton23.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton23.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton23.Name = "toolStripButton23"
            Me.toolStripButton23.Size = New System.Drawing.Size(68, 0)
            Me.toolStripButton23.Text = "CoverPage"
            Me.toolStripButton23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton24
            '
            Me.toolStripButton24.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton24.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton24.Name = "toolStripButton24"
            Me.toolStripButton24.Size = New System.Drawing.Size(66, 0)
            Me.toolStripButton24.Text = "Blankpage"
            Me.toolStripButton24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton25
            '
            Me.toolStripButton25.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton25.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton25.Name = "toolStripButton25"
            Me.toolStripButton25.Size = New System.Drawing.Size(66, 0)
            Me.toolStripButton25.Text = "PageBreak"
            Me.toolStripButton25.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx8
            '
            Me.toolStripEx8.AutoSize = False
            Me.toolStripEx8.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx8.Image = Nothing
            Me.toolStripEx8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton26})
            Me.toolStripEx8.Location = New System.Drawing.Point(212, 1)
            Me.toolStripEx8.Name = "toolStripEx8"
            Me.toolStripEx8.Office12Mode = False
            Me.toolStripEx8.Size = New System.Drawing.Size(71, 0)
            Me.toolStripEx8.TabIndex = 3
            Me.toolStripEx8.Text = "Illustrations"
            '
            'toolStripButton26
            '
            Me.toolStripButton26.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton26.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton26.Name = "toolStripButton26"
            Me.toolStripButton26.Size = New System.Drawing.Size(48, 0)
            Me.toolStripButton26.Text = "Picture"
            Me.toolStripButton26.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx5
            '
            Me.toolStripEx5.AutoSize = False
            Me.toolStripEx5.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx5.Image = Nothing
            Me.toolStripEx5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton19, Me.toolStripButton20, Me.toolStripButton21})
            Me.toolStripEx5.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx5.Name = "toolStripEx5"
            Me.toolStripEx5.Office12Mode = False
            Me.toolStripEx5.Size = New System.Drawing.Size(210, 92)
            Me.toolStripEx5.TabIndex = 0
            Me.toolStripEx5.Text = "Page"
            '
            'toolStripButton19
            '
            Me.toolStripButton19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton19.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton19.Name = "toolStripButton19"
            Me.toolStripButton19.Size = New System.Drawing.Size(68, 89)
            Me.toolStripButton19.Text = "CoverPage"
            Me.toolStripButton19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton20
            '
            Me.toolStripButton20.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton20.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton20.Name = "toolStripButton20"
            Me.toolStripButton20.Size = New System.Drawing.Size(66, 89)
            Me.toolStripButton20.Text = "Blankpage"
            Me.toolStripButton20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripButton21
            '
            Me.toolStripButton21.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton21.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton21.Name = "toolStripButton21"
            Me.toolStripButton21.Size = New System.Drawing.Size(66, 89)
            Me.toolStripButton21.Text = "PageBreak"
            Me.toolStripButton21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'toolStripEx6
            '
            Me.toolStripEx6.AutoSize = False
            Me.toolStripEx6.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx6.Image = Nothing
            Me.toolStripEx6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton22})
            Me.toolStripEx6.Location = New System.Drawing.Point(212, 1)
            Me.toolStripEx6.Name = "toolStripEx6"
            Me.toolStripEx6.Office12Mode = False
            Me.toolStripEx6.Size = New System.Drawing.Size(71, 92)
            Me.toolStripEx6.TabIndex = 1
            Me.toolStripEx6.Text = "Illustrations"
            '
            'toolStripButton22
            '
            Me.toolStripButton22.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton22.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton22.Name = "toolStripButton22"
            Me.toolStripButton22.Size = New System.Drawing.Size(48, 89)
            Me.toolStripButton22.Text = "Picture"
            Me.toolStripButton22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(807, 617)
            Me.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Silver
            Me.Controls.Add(Me.backStage1)
            Me.Controls.Add(Me.ribbonControlAdv1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.HelpButtonImage = CType(resources.GetObject("$this.HelpButtonImage"), System.Drawing.Image)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Text = "BackStage Demo"
            CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ribbonControlAdv1.ResumeLayout(False)
            Me.ribbonControlAdv1.PerformLayout()
            CType(Me.backStage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backStage1.ResumeLayout(False)
            Me.backStageTab1.ResumeLayout(False)
            Me.backStageTab1.PerformLayout()
            Me.toolStripTabItem1.Panel.ResumeLayout(False)
            Me.toolStripEx1.ResumeLayout(False)
            Me.toolStripEx1.PerformLayout()
            Me.toolStripEx2.ResumeLayout(False)
            Me.toolStripEx2.PerformLayout()
            Me.toolStripTabItem2.Panel.ResumeLayout(False)
            Me.toolStripEx3.ResumeLayout(False)
            Me.toolStripEx3.PerformLayout()
            Me.toolStripEx4.ResumeLayout(False)
            Me.toolStripEx4.PerformLayout()
            Me.toolStripTabItem3.Panel.ResumeLayout(False)
            Me.toolStripEx7.ResumeLayout(False)
            Me.toolStripEx7.PerformLayout()
            Me.toolStripEx8.ResumeLayout(False)
            Me.toolStripEx8.PerformLayout()
            Me.toolStripEx5.ResumeLayout(False)
            Me.toolStripEx5.PerformLayout()
            Me.toolStripEx6.ResumeLayout(False)
            Me.toolStripEx6.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private ribbonControlAdv1 As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
		Private backStageView1 As Syncfusion.Windows.Forms.BackStageView
		Private backStage1 As Syncfusion.Windows.Forms.BackStage
		Private WithEvents backStageButton1 As Syncfusion.Windows.Forms.BackStageButton
		Private WithEvents backStageButton2 As Syncfusion.Windows.Forms.BackStageButton
		Private WithEvents backStageButton3 As Syncfusion.Windows.Forms.BackStageButton
		Private backStageButton4 As Syncfusion.Windows.Forms.BackStageButton
		Private backStageTab1 As Syncfusion.Windows.Forms.BackStageTab
		Private backStageTab2 As Syncfusion.Windows.Forms.BackStageTab
		Private backStageTab3 As Syncfusion.Windows.Forms.BackStageTab
		Private backStageTab4 As Syncfusion.Windows.Forms.BackStageTab
		Private backStageTab5 As Syncfusion.Windows.Forms.BackStageTab
		Private backStageTab6 As Syncfusion.Windows.Forms.BackStageTab
		Private backStageButton5 As Syncfusion.Windows.Forms.BackStageButton
		Private backStageButton6 As Syncfusion.Windows.Forms.BackStageButton
		Private toolStripTabItem2 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripEx2 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem2 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripPanelItem3 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
		Private toolStripComboBox2 As System.Windows.Forms.ToolStripComboBox
		Private toolStripPanelItem4 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton5 As System.Windows.Forms.ToolStripButton
		Private toolStripButton6 As System.Windows.Forms.ToolStripButton
		Private toolStripButton7 As System.Windows.Forms.ToolStripButton
		Private toolStripButton8 As System.Windows.Forms.ToolStripButton
		Private toolStripButton9 As System.Windows.Forms.ToolStripButton
		Private toolStripButton10 As System.Windows.Forms.ToolStripButton
		Private toolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem1 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private toolStripEx3 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton12 As System.Windows.Forms.ToolStripButton
		Private toolStripButton13 As System.Windows.Forms.ToolStripButton
		Private toolStripButton14 As System.Windows.Forms.ToolStripButton
		Private toolStripEx4 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton15 As System.Windows.Forms.ToolStripButton
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private toolStripSplitButtonEx1 As Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx
		Private toolStripSplitButtonEx3 As Syncfusion.Windows.Forms.Tools.ToolStripSplitButtonEx
		Private toolStripButton11 As System.Windows.Forms.ToolStripButton
		Private toolStripButton16 As System.Windows.Forms.ToolStripButton
		Private toolStripButton17 As System.Windows.Forms.ToolStripButton
		Private toolStripButton18 As System.Windows.Forms.ToolStripButton
		Private label1 As System.Windows.Forms.Label
		Private toolStripTabItem3 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripEx7 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton23 As System.Windows.Forms.ToolStripButton
		Private toolStripButton24 As System.Windows.Forms.ToolStripButton
		Private toolStripButton25 As System.Windows.Forms.ToolStripButton
		Private toolStripEx8 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton26 As System.Windows.Forms.ToolStripButton
		Private toolStripEx5 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton19 As System.Windows.Forms.ToolStripButton
		Private toolStripButton20 As System.Windows.Forms.ToolStripButton
		Private toolStripButton21 As System.Windows.Forms.ToolStripButton
		Private toolStripEx6 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton22 As System.Windows.Forms.ToolStripButton
	End Class
End Namespace

