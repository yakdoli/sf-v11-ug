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
            Me.backStageButton6 = New Syncfusion.Windows.Forms.BackStageButton()
            Me.backStageTab1 = New Syncfusion.Windows.Forms.BackStageTab()
            Me.label2 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.backStageTab2 = New Syncfusion.Windows.Forms.BackStageTab()
            Me.label3 = New System.Windows.Forms.Label()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.backStageTab3 = New Syncfusion.Windows.Forms.BackStageTab()
            Me.label4 = New System.Windows.Forms.Label()
            Me.pictureBox3 = New System.Windows.Forms.PictureBox()
            Me.toolStripTabItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
            Me.toolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripPanelItem6 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton30 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton31 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton32 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripPanelItem5 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton27 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton28 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton29 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripPanelItem7 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton33 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton34 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton35 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripPanelItem1 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripPanelItem9 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton38 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton39 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton40 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripPanelItem8 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton36 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton37 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx9 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripPanelItem11 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton44 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton45 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton46 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripPanelItem10 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton41 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx10 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripPanelItem13 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton48 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton49 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripButton50 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripPanelItem12 = New Syncfusion.Windows.Forms.Tools.ToolStripPanelItem()
            Me.toolStripButton42 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripTabItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
            Me.toolStripEx4 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx8 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
            Me.toolStripEx11 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
            Me.toolStripTabItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
            Me.toolStripEx7 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
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
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backStageTab2.SuspendLayout()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backStageTab3.SuspendLayout()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.toolStripTabItem1.Panel.SuspendLayout()
            Me.toolStripEx1.SuspendLayout()
            Me.toolStripEx2.SuspendLayout()
            Me.toolStripEx9.SuspendLayout()
            Me.toolStripEx10.SuspendLayout()
            Me.toolStripTabItem2.Panel.SuspendLayout()
            Me.toolStripEx4.SuspendLayout()
            Me.toolStripEx8.SuspendLayout()
            Me.toolStripTabItem3.Panel.SuspendLayout()
            Me.toolStripEx5.SuspendLayout()
            Me.toolStripEx6.SuspendLayout()
            Me.SuspendLayout()
            '
            'ribbonControlAdv1
            '
            Me.ribbonControlAdv1.BackStageView = Me.backStageView1
            Me.ribbonControlAdv1.CanReduceCaptionLength = False
            Me.ribbonControlAdv1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
            Me.ribbonControlAdv1.SelectedTab = Me.toolStripTabItem2
            Me.ribbonControlAdv1.Size = New System.Drawing.Size(1158, 146)
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
            Me.backStage1.Controls.Add(Me.backStageButton6)
            Me.backStage1.Controls.Add(Me.backStageTab1)
            Me.backStage1.Controls.Add(Me.backStageTab2)
            Me.backStage1.Controls.Add(Me.backStageTab3)
            Me.backStage1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.backStage1.ItemSize = New System.Drawing.Size(130, 30)
            Me.backStage1.Location = New System.Drawing.Point(5, 55)
            Me.backStage1.Name = "backStage1"
            Me.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver
            Me.backStage1.Size = New System.Drawing.Size(1148, 568)
            Me.backStage1.TabIndex = 1
            Me.backStage1.Visible = False
            '
            'backStageButton6
            '
            Me.backStageButton6.BackColor = System.Drawing.Color.Transparent
            Me.backStageButton6.Location = New System.Drawing.Point(10, 10)
            Me.backStageButton6.Name = "backStageButton6"
            Me.backStageButton6.Size = New System.Drawing.Size(110, 25)
            Me.backStageButton6.TabIndex = 13
            Me.backStageButton6.Text = "Exit"
            '
            'backStageTab1
            '
            Me.backStageTab1.BackColor = System.Drawing.Color.White
            Me.backStageTab1.Controls.Add(Me.label2)
            Me.backStageTab1.Controls.Add(Me.pictureBox1)
            Me.backStageTab1.Controls.Add(Me.label1)
            Me.backStageTab1.Image = Nothing
            Me.backStageTab1.ImageSize = New System.Drawing.Size(16, 16)
            Me.backStageTab1.Location = New System.Drawing.Point(129, 0)
            Me.backStageTab1.Name = "backStageTab1"
            Me.backStageTab1.ShowCloseButton = True
            Me.backStageTab1.Size = New System.Drawing.Size(1019, 568)
            Me.backStageTab1.TabIndex = 6
            Me.backStageTab1.Text = "Feature 1"
            Me.backStageTab1.ThemesEnabled = False
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(31, 14)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(91, 17)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Clock Control"
            '
            'pictureBox1
            '
            Me.pictureBox1.Location = New System.Drawing.Point(11, 44)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(831, 530)
            Me.pictureBox1.TabIndex = 2
            Me.pictureBox1.TabStop = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(22, 19)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(0, 16)
            Me.label1.TabIndex = 1
            '
            'backStageTab2
            '
            Me.backStageTab2.BackColor = System.Drawing.Color.White
            Me.backStageTab2.Controls.Add(Me.label3)
            Me.backStageTab2.Controls.Add(Me.pictureBox2)
            Me.backStageTab2.Image = Nothing
            Me.backStageTab2.ImageSize = New System.Drawing.Size(16, 16)
            Me.backStageTab2.Location = New System.Drawing.Point(129, 0)
            Me.backStageTab2.Name = "backStageTab2"
            Me.backStageTab2.ShowCloseButton = True
            Me.backStageTab2.Size = New System.Drawing.Size(1019, 568)
            Me.backStageTab2.TabIndex = 7
            Me.backStageTab2.Text = "Feature 2"
            Me.backStageTab2.ThemesEnabled = False
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(23, 8)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(111, 17)
            Me.label3.TabIndex = 5
            Me.label3.Text = "BackStage Demo"
            '
            'pictureBox2
            '
            Me.pictureBox2.Location = New System.Drawing.Point(3, 38)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(831, 530)
            Me.pictureBox2.TabIndex = 4
            Me.pictureBox2.TabStop = False
            '
            'backStageTab3
            '
            Me.backStageTab3.BackColor = System.Drawing.Color.White
            Me.backStageTab3.Controls.Add(Me.label4)
            Me.backStageTab3.Controls.Add(Me.pictureBox3)
            Me.backStageTab3.Image = Nothing
            Me.backStageTab3.ImageSize = New System.Drawing.Size(16, 16)
            Me.backStageTab3.Location = New System.Drawing.Point(129, 0)
            Me.backStageTab3.Name = "backStageTab3"
            Me.backStageTab3.ShowCloseButton = True
            Me.backStageTab3.Size = New System.Drawing.Size(1019, 568)
            Me.backStageTab3.TabIndex = 8
            Me.backStageTab3.Text = "Feature 3"
            Me.backStageTab3.ThemesEnabled = False
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(23, 8)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(127, 17)
            Me.label4.TabIndex = 5
            Me.label4.Text = "Ribbon Style Demo"
            '
            'pictureBox3
            '
            Me.pictureBox3.Location = New System.Drawing.Point(3, 38)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(831, 530)
            Me.pictureBox3.TabIndex = 4
            Me.pictureBox3.TabStop = False
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
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx9)
            Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx10)
            Me.toolStripTabItem1.Panel.Name = "RibbonPanel1"
            Me.toolStripTabItem1.Panel.ScrollPosition = 0
            Me.toolStripTabItem1.Panel.TabIndex = 0
            Me.toolStripTabItem1.Panel.Text = "Controls"
            Me.toolStripTabItem1.Position = 0
            Me.toolStripTabItem1.Size = New System.Drawing.Size(65, 23)
            Me.toolStripTabItem1.Text = "Controls"
            '
            'toolStripEx1
            '
            Me.toolStripEx1.AutoSize = False
            Me.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx1.Image = Nothing
            Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem6, Me.toolStripPanelItem5, Me.toolStripPanelItem7, Me.toolStripPanelItem1})
            Me.toolStripEx1.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx1.Name = "toolStripEx1"
            Me.toolStripEx1.Office12Mode = False
            Me.toolStripEx1.Size = New System.Drawing.Size(528, 89)
            Me.toolStripEx1.TabIndex = 3
            Me.toolStripEx1.Text = "Editors"
            '
            'toolStripPanelItem6
            '
            Me.toolStripPanelItem6.CausesValidation = False
            Me.toolStripPanelItem6.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton30, Me.toolStripButton31, Me.toolStripButton32})
            Me.toolStripPanelItem6.Name = "toolStripPanelItem6"
            Me.toolStripPanelItem6.Size = New System.Drawing.Size(95, 75)
            Me.toolStripPanelItem6.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem6.Transparent = True
            '
            'toolStripButton30
            '
            Me.toolStripButton30.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton30.Name = "toolStripButton30"
            Me.toolStripButton30.Size = New System.Drawing.Size(68, 19)
            Me.toolStripButton30.Text = "ButtonAdv"
            '
            'toolStripButton31
            '
            Me.toolStripButton31.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton31.Name = "toolStripButton31"
            Me.toolStripButton31.Size = New System.Drawing.Size(67, 19)
            Me.toolStripButton31.Text = "ButtonEdit"
            '
            'toolStripButton32
            '
            Me.toolStripButton32.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton32.Name = "toolStripButton32"
            Me.toolStripButton32.Size = New System.Drawing.Size(91, 19)
            Me.toolStripButton32.Text = "ComboBoxAdv"
            '
            'toolStripPanelItem5
            '
            Me.toolStripPanelItem5.CausesValidation = False
            Me.toolStripPanelItem5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton27, Me.toolStripButton28, Me.toolStripButton29})
            Me.toolStripPanelItem5.Name = "toolStripPanelItem5"
            Me.toolStripPanelItem5.Size = New System.Drawing.Size(109, 75)
            Me.toolStripPanelItem5.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem5.Transparent = True
            '
            'toolStripButton27
            '
            Me.toolStripButton27.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton27.Name = "toolStripButton27"
            Me.toolStripButton27.Size = New System.Drawing.Size(105, 19)
            Me.toolStripButton27.Text = "CalculatorControl"
            '
            'toolStripButton28
            '
            Me.toolStripButton28.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton28.Name = "toolStripButton28"
            Me.toolStripButton28.Size = New System.Drawing.Size(104, 19)
            Me.toolStripButton28.Text = "ColorPickerUIAdv"
            '
            'toolStripButton29
            '
            Me.toolStripButton29.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton29.Name = "toolStripButton29"
            Me.toolStripButton29.Size = New System.Drawing.Size(98, 19)
            Me.toolStripButton29.Text = "RadioButtonAdv"
            '
            'toolStripPanelItem7
            '
            Me.toolStripPanelItem7.CausesValidation = False
            Me.toolStripPanelItem7.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton33, Me.toolStripButton34, Me.toolStripButton35})
            Me.toolStripPanelItem7.Name = "toolStripPanelItem7"
            Me.toolStripPanelItem7.Size = New System.Drawing.Size(113, 75)
            Me.toolStripPanelItem7.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem7.Transparent = True
            '
            'toolStripButton33
            '
            Me.toolStripButton33.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton33.Name = "toolStripButton33"
            Me.toolStripButton33.Size = New System.Drawing.Size(84, 19)
            Me.toolStripButton33.Text = "CheckBoxAdv"
            '
            'toolStripButton34
            '
            Me.toolStripButton34.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton34.Name = "toolStripButton34"
            Me.toolStripButton34.Size = New System.Drawing.Size(109, 19)
            Me.toolStripButton34.Text = "MonthCalendarExt"
            '
            'toolStripButton35
            '
            Me.toolStripButton35.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton35.Name = "toolStripButton35"
            Me.toolStripButton35.Size = New System.Drawing.Size(70, 19)
            Me.toolStripButton35.Text = "SplitButton"
            '
            'toolStripPanelItem1
            '
            Me.toolStripPanelItem1.CausesValidation = False
            Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton2, Me.toolStripButton3, Me.toolStripButton4})
            Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Size = New System.Drawing.Size(122, 75)
            Me.toolStripPanelItem1.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem1.Transparent = True
            '
            'toolStripButton2
            '
            Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton2.Name = "toolStripButton2"
            Me.toolStripButton2.Size = New System.Drawing.Size(67, 19)
            Me.toolStripButton2.Text = "TextBoxExt"
            '
            'toolStripButton3
            '
            Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton3.Name = "toolStripButton3"
            Me.toolStripButton3.Size = New System.Drawing.Size(118, 19)
            Me.toolStripButton3.Text = "NumericUpDownExt"
            '
            'toolStripButton4
            '
            Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton4.Name = "toolStripButton4"
            Me.toolStripButton4.Size = New System.Drawing.Size(89, 19)
            Me.toolStripButton4.Text = "IntegerTextBox"
            '
            'toolStripEx2
            '
            Me.toolStripEx2.AutoSize = False
            Me.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx2.Image = Nothing
            Me.toolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem9, Me.toolStripPanelItem8})
            Me.toolStripEx2.Location = New System.Drawing.Point(530, 1)
            Me.toolStripEx2.Name = "toolStripEx2"
            Me.toolStripEx2.Office12Mode = False
            Me.toolStripEx2.Size = New System.Drawing.Size(222, 89)
            Me.toolStripEx2.TabIndex = 2
            Me.toolStripEx2.Text = "Navigators"
            '
            'toolStripPanelItem9
            '
            Me.toolStripPanelItem9.CausesValidation = False
            Me.toolStripPanelItem9.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton38, Me.toolStripButton39, Me.toolStripButton40})
            Me.toolStripPanelItem9.Name = "toolStripPanelItem9"
            Me.toolStripPanelItem9.Size = New System.Drawing.Size(98, 75)
            Me.toolStripPanelItem9.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem9.Transparent = True
            '
            'toolStripButton38
            '
            Me.toolStripButton38.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton38.Name = "toolStripButton38"
            Me.toolStripButton38.Size = New System.Drawing.Size(61, 19)
            Me.toolStripButton38.Text = "GroupBar"
            '
            'toolStripButton39
            '
            Me.toolStripButton39.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton39.Name = "toolStripButton39"
            Me.toolStripButton39.Size = New System.Drawing.Size(94, 19)
            Me.toolStripButton39.Text = "NavigationView"
            '
            'toolStripButton40
            '
            Me.toolStripButton40.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton40.Name = "toolStripButton40"
            Me.toolStripButton40.Size = New System.Drawing.Size(66, 19)
            Me.toolStripButton40.Text = "XPTaskBar"
            '
            'toolStripPanelItem8
            '
            Me.toolStripPanelItem8.CausesValidation = False
            Me.toolStripPanelItem8.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton36, Me.toolStripButton37})
            Me.toolStripPanelItem8.Name = "toolStripPanelItem8"
            Me.toolStripPanelItem8.Size = New System.Drawing.Size(81, 75)
            Me.toolStripPanelItem8.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem8.Transparent = True
            '
            'toolStripButton36
            '
            Me.toolStripButton36.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton36.Name = "toolStripButton36"
            Me.toolStripButton36.Size = New System.Drawing.Size(77, 19)
            Me.toolStripButton36.Text = "RangerSlider"
            '
            'toolStripButton37
            '
            Me.toolStripButton37.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton37.Name = "toolStripButton37"
            Me.toolStripButton37.Size = New System.Drawing.Size(68, 19)
            Me.toolStripButton37.Text = "TrackBarEx"
            '
            'toolStripEx9
            '
            Me.toolStripEx9.AutoSize = False
            Me.toolStripEx9.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx9.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx9.Image = Nothing
            Me.toolStripEx9.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem11, Me.toolStripPanelItem10})
            Me.toolStripEx9.Location = New System.Drawing.Point(754, 1)
            Me.toolStripEx9.Name = "toolStripEx9"
            Me.toolStripEx9.Office12Mode = False
            Me.toolStripEx9.Size = New System.Drawing.Size(223, 89)
            Me.toolStripEx9.TabIndex = 4
            Me.toolStripEx9.Text = "Notificators"
            '
            'toolStripPanelItem11
            '
            Me.toolStripPanelItem11.CausesValidation = False
            Me.toolStripPanelItem11.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem11.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton44, Me.toolStripButton45, Me.toolStripButton46})
            Me.toolStripPanelItem11.Name = "toolStripPanelItem11"
            Me.toolStripPanelItem11.Size = New System.Drawing.Size(89, 75)
            Me.toolStripPanelItem11.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem11.Transparent = True
            '
            'toolStripButton44
            '
            Me.toolStripButton44.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton44.Name = "toolStripButton44"
            Me.toolStripButton44.Size = New System.Drawing.Size(41, 19)
            Me.toolStripButton44.Text = "Clock"
            '
            'toolStripButton45
            '
            Me.toolStripButton45.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton45.Name = "toolStripButton45"
            Me.toolStripButton45.Size = New System.Drawing.Size(85, 19)
            Me.toolStripButton45.Text = "SplashControl"
            '
            'toolStripButton46
            '
            Me.toolStripButton46.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton46.Name = "toolStripButton46"
            Me.toolStripButton46.Size = New System.Drawing.Size(73, 19)
            Me.toolStripButton46.Text = "ProgressBar"
            '
            'toolStripPanelItem10
            '
            Me.toolStripPanelItem10.CausesValidation = False
            Me.toolStripPanelItem10.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton41})
            Me.toolStripPanelItem10.Name = "toolStripPanelItem10"
            Me.toolStripPanelItem10.Size = New System.Drawing.Size(91, 75)
            Me.toolStripPanelItem10.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem10.Transparent = True
            '
            'toolStripButton41
            '
            Me.toolStripButton41.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton41.Name = "toolStripButton41"
            Me.toolStripButton41.Size = New System.Drawing.Size(87, 19)
            Me.toolStripButton41.Text = "WizardControl"
            '
            'toolStripEx10
            '
            Me.toolStripEx10.AutoSize = False
            Me.toolStripEx10.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx10.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx10.Image = Nothing
            Me.toolStripEx10.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripPanelItem13, Me.toolStripPanelItem12})
            Me.toolStripEx10.Location = New System.Drawing.Point(979, 1)
            Me.toolStripEx10.Name = "toolStripEx10"
            Me.toolStripEx10.Office12Mode = False
            Me.toolStripEx10.Size = New System.Drawing.Size(278, 89)
            Me.toolStripEx10.TabIndex = 5
            Me.toolStripEx10.Text = "Others"
            '
            'toolStripPanelItem13
            '
            Me.toolStripPanelItem13.CausesValidation = False
            Me.toolStripPanelItem13.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem13.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton48, Me.toolStripButton49, Me.toolStripButton50})
            Me.toolStripPanelItem13.Name = "toolStripPanelItem13"
            Me.toolStripPanelItem13.Size = New System.Drawing.Size(90, 75)
            Me.toolStripPanelItem13.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem13.Transparent = True
            '
            'toolStripButton48
            '
            Me.toolStripButton48.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton48.Name = "toolStripButton48"
            Me.toolStripButton48.Size = New System.Drawing.Size(80, 19)
            Me.toolStripButton48.Text = "TreeViewAdv"
            '
            'toolStripButton49
            '
            Me.toolStripButton49.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton49.Name = "toolStripButton49"
            Me.toolStripButton49.Size = New System.Drawing.Size(86, 19)
            Me.toolStripButton49.Text = "TabControlExt"
            '
            'toolStripButton50
            '
            Me.toolStripButton50.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton50.Name = "toolStripButton50"
            Me.toolStripButton50.Size = New System.Drawing.Size(83, 19)
            Me.toolStripButton50.Text = "ScrollerFrame"
            '
            'toolStripPanelItem12
            '
            Me.toolStripPanelItem12.CausesValidation = False
            Me.toolStripPanelItem12.ForeColor = System.Drawing.Color.MidnightBlue
            Me.toolStripPanelItem12.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton42})
            Me.toolStripPanelItem12.Name = "toolStripPanelItem12"
            Me.toolStripPanelItem12.Size = New System.Drawing.Size(122, 75)
            Me.toolStripPanelItem12.Text = "toolStripPanelItem1"
            Me.toolStripPanelItem12.Transparent = True
            '
            'toolStripButton42
            '
            Me.toolStripButton42.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton42.Name = "toolStripButton42"
            Me.toolStripButton42.Size = New System.Drawing.Size(118, 19)
            Me.toolStripButton42.Text = "ContextMenuStripEx"
            '
            'toolStripTabItem2
            '
            Me.toolStripTabItem2.Name = "toolStripTabItem2"
            '
            'ribbonControlAdv1.RibbonPanel2
            '
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx4)
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx8)
            Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx11)
            Me.toolStripTabItem2.Panel.Name = "RibbonPanel2"
            Me.toolStripTabItem2.Panel.ScrollPosition = 0
            Me.toolStripTabItem2.Panel.TabIndex = 1
            Me.toolStripTabItem2.Panel.Text = "Options"
            Me.toolStripTabItem2.Position = 1
            Me.toolStripTabItem2.Size = New System.Drawing.Size(63, 23)
            Me.toolStripTabItem2.Text = "Options"
            '
            'toolStripEx4
            '
            Me.toolStripEx4.AutoSize = False
            Me.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx4.Image = Nothing
            Me.toolStripEx4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1})
            Me.toolStripEx4.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx4.Name = "toolStripEx4"
            Me.toolStripEx4.Office12Mode = False
            Me.toolStripEx4.Size = New System.Drawing.Size(150, 89)
            Me.toolStripEx4.TabIndex = 1
            Me.toolStripEx4.Text = "OverView"
            '
            'toolStripButton1
            '
            Me.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton1.Name = "toolStripButton1"
            Me.toolStripButton1.Size = New System.Drawing.Size(93, 72)
            Me.toolStripButton1.Text = "Tools OverView"
            '
            'toolStripEx8
            '
            Me.toolStripEx8.AutoSize = False
            Me.toolStripEx8.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx8.Image = Nothing
            Me.toolStripEx8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton5})
            Me.toolStripEx8.Location = New System.Drawing.Point(152, 1)
            Me.toolStripEx8.Name = "toolStripEx8"
            Me.toolStripEx8.Office12Mode = False
            Me.toolStripEx8.Size = New System.Drawing.Size(133, 89)
            Me.toolStripEx8.TabIndex = 2
            Me.toolStripEx8.Text = "Clean"
            '
            'toolStripButton5
            '
            Me.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
            Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.toolStripButton5.Name = "toolStripButton5"
            Me.toolStripButton5.Size = New System.Drawing.Size(79, 72)
            Me.toolStripButton5.Text = "Clean Screen"
            '
            'toolStripEx11
            '
            Me.toolStripEx11.AutoSize = False
            Me.toolStripEx11.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx11.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx11.Image = Nothing
            Me.toolStripEx11.Location = New System.Drawing.Point(287, 1)
            Me.toolStripEx11.Name = "toolStripEx11"
            Me.toolStripEx11.Office12Mode = False
            Me.toolStripEx11.Size = New System.Drawing.Size(194, 89)
            Me.toolStripEx11.TabIndex = 5
            Me.toolStripEx11.Text = "Metro Colors"
            '
            'toolStripTabItem3
            '
            Me.toolStripTabItem3.Name = "toolStripTabItem3"
            '
            'ribbonControlAdv1.RibbonPanel3
            '
            Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx7)
            Me.toolStripTabItem3.Panel.Name = "RibbonPanel3"
            Me.toolStripTabItem3.Panel.ScrollPosition = 0
            Me.toolStripTabItem3.Panel.TabIndex = 2
            Me.toolStripTabItem3.Panel.Text = "Ribbon BackGround"
            Me.toolStripTabItem3.Position = 2
            Me.toolStripTabItem3.Size = New System.Drawing.Size(124, 23)
            Me.toolStripTabItem3.Text = "Ribbon BackGround"
            '
            'toolStripEx7
            '
            Me.toolStripEx7.AutoSize = False
            Me.toolStripEx7.Dock = System.Windows.Forms.DockStyle.None
            Me.toolStripEx7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
            Me.toolStripEx7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
            Me.toolStripEx7.Image = Nothing
            Me.toolStripEx7.Location = New System.Drawing.Point(0, 1)
            Me.toolStripEx7.Name = "toolStripEx7"
            Me.toolStripEx7.Office12Mode = False
            Me.toolStripEx7.Size = New System.Drawing.Size(949, 89)
            Me.toolStripEx7.TabIndex = 3
            Me.toolStripEx7.Text = "Header Images"
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
            Me.ClientSize = New System.Drawing.Size(1160, 721)
            Me.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Silver
            Me.Controls.Add(Me.backStage1)
            Me.Controls.Add(Me.ribbonControlAdv1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.HelpButtonImage = CType(resources.GetObject("$this.HelpButtonImage"), System.Drawing.Image)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "Form1"
            Me.Text = "Tools Windows Form [Controls simple overview]"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ribbonControlAdv1.ResumeLayout(False)
            Me.ribbonControlAdv1.PerformLayout()
            CType(Me.backStage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backStage1.ResumeLayout(False)
            Me.backStageTab1.ResumeLayout(False)
            Me.backStageTab1.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backStageTab2.ResumeLayout(False)
            Me.backStageTab2.PerformLayout()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.backStageTab3.ResumeLayout(False)
            Me.backStageTab3.PerformLayout()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.toolStripTabItem1.Panel.ResumeLayout(False)
            Me.toolStripEx1.ResumeLayout(False)
            Me.toolStripEx1.PerformLayout()
            Me.toolStripEx2.ResumeLayout(False)
            Me.toolStripEx2.PerformLayout()
            Me.toolStripEx9.ResumeLayout(False)
            Me.toolStripEx9.PerformLayout()
            Me.toolStripEx10.ResumeLayout(False)
            Me.toolStripEx10.PerformLayout()
            Me.toolStripTabItem2.Panel.ResumeLayout(False)
            Me.toolStripEx4.ResumeLayout(False)
            Me.toolStripEx4.PerformLayout()
            Me.toolStripEx8.ResumeLayout(False)
            Me.toolStripEx8.PerformLayout()
            Me.toolStripTabItem3.Panel.ResumeLayout(False)
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
		Private backStageTab1 As Syncfusion.Windows.Forms.BackStageTab
		Private backStageTab2 As Syncfusion.Windows.Forms.BackStageTab
		Private backStageTab3 As Syncfusion.Windows.Forms.BackStageTab
		Private WithEvents backStageButton6 As Syncfusion.Windows.Forms.BackStageButton
		Private toolStripTabItem2 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripTabItem1 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripEx2 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem1 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton2 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton3 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton4 As System.Windows.Forms.ToolStripButton
		Private label1 As System.Windows.Forms.Label
		Private toolStripTabItem3 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
		Private toolStripEx5 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton19 As System.Windows.Forms.ToolStripButton
		Private toolStripButton20 As System.Windows.Forms.ToolStripButton
		Private toolStripButton21 As System.Windows.Forms.ToolStripButton
		Private toolStripEx6 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton22 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem6 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton30 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton31 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton32 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem5 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton27 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton28 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton29 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem7 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton33 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton34 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton35 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem8 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton36 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton37 As System.Windows.Forms.ToolStripButton
		Private toolStripEx9 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem9 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton38 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton39 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton40 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem10 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton41 As System.Windows.Forms.ToolStripButton
		Private toolStripEx10 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripPanelItem11 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton44 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton45 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton46 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem13 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton48 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton49 As System.Windows.Forms.ToolStripButton
		Private WithEvents toolStripButton50 As System.Windows.Forms.ToolStripButton
		Private toolStripPanelItem12 As Syncfusion.Windows.Forms.Tools.ToolStripPanelItem
		Private WithEvents toolStripButton42 As System.Windows.Forms.ToolStripButton
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private label4 As System.Windows.Forms.Label
		Private pictureBox3 As System.Windows.Forms.PictureBox
		Private toolStripEx7 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripEx4 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private WithEvents toolStripButton1 As System.Windows.Forms.ToolStripButton
		Private toolStripEx8 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private WithEvents toolStripButton5 As System.Windows.Forms.ToolStripButton
		Private toolStripEx11 As Syncfusion.Windows.Forms.Tools.ToolStripEx
	End Class
End Namespace

