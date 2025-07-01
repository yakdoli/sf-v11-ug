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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
			Me.toolStripEx5 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton20 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton21 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton29 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx9 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton27 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton23 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton19 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx10 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton28 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton30 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripTabItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripEx3 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton12 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton13 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton14 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx4 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton15 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripTabItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
			Me.toolStripEx7 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton24 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripButton25 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx8 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton26 = New System.Windows.Forms.ToolStripButton()
			Me.toolStripEx6 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
			Me.toolStripButton22 = New System.Windows.Forms.ToolStripButton()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.panel4 = New BackStageDemo.PanelExt()
			Me.panel2 = New BackStageDemo.PanelExt()
			Me.label8 = New System.Windows.Forms.Label()
			Me.panel6 = New System.Windows.Forms.Panel()
			Me.transparentPanel16 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel15 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel12 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel14 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel13 = New BackStageDemo.TransparentPanel()
			Me.panel5 = New System.Windows.Forms.Panel()
			Me.transparentPanel7 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel8 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel9 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel10 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel11 = New BackStageDemo.TransparentPanel()
			Me.label5 = New System.Windows.Forms.Label()
			Me.transparentPanel4 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel5 = New BackStageDemo.TransparentPanel()
			Me.label6 = New System.Windows.Forms.Label()
			Me.transparentPanel6 = New BackStageDemo.TransparentPanel()
			Me.label7 = New System.Windows.Forms.Label()
			Me.panel3 = New BackStageDemo.PanelExt()
			Me.transparentPanel3 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel2 = New BackStageDemo.TransparentPanel()
			Me.transparentPanel1 = New BackStageDemo.TransparentPanel()
			Me.panel7 = New System.Windows.Forms.Panel()
			Me.flowLayout5 = New Syncfusion.Windows.Forms.Tools.FlowLayout(Me.components)
			CType(Me.ribbonControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.ribbonControlAdv1.SuspendLayout()
			CType(Me.backStage1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backStage1.SuspendLayout()
			Me.backStageTab1.SuspendLayout()
			Me.toolStripTabItem1.Panel.SuspendLayout()
			Me.toolStripEx1.SuspendLayout()
			Me.toolStripEx2.SuspendLayout()
			Me.toolStripEx5.SuspendLayout()
			Me.toolStripEx9.SuspendLayout()
			Me.toolStripEx10.SuspendLayout()
			Me.toolStripTabItem2.Panel.SuspendLayout()
			Me.toolStripEx3.SuspendLayout()
			Me.toolStripEx4.SuspendLayout()
			Me.toolStripTabItem3.Panel.SuspendLayout()
			Me.toolStripEx7.SuspendLayout()
			Me.toolStripEx8.SuspendLayout()
			Me.toolStripEx6.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.panel4.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.panel6.SuspendLayout()
			Me.panel5.SuspendLayout()
			Me.panel3.SuspendLayout()
			Me.panel7.SuspendLayout()
			CType(Me.flowLayout5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControlAdv1
			' 
			Me.ribbonControlAdv1.BackStageView = Me.backStageView1
			Me.ribbonControlAdv1.CanReduceCaptionLength = False
			Me.ribbonControlAdv1.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1)
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem2)
			Me.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem3)
			Me.ribbonControlAdv1.Location = New System.Drawing.Point(1, 0)
			Me.ribbonControlAdv1.MaximizeToolTip = "Maximize Ribbon"
			Me.ribbonControlAdv1.MenuButtonText = "File"
			Me.ribbonControlAdv1.MenuButtonWidth = 56
			Me.ribbonControlAdv1.MenuColor = System.Drawing.Color.Red
			Me.ribbonControlAdv1.MinimizeToolTip = "Minimize Ribbon"
			Me.ribbonControlAdv1.Name = "ribbonControlAdv1"
			Me.ribbonControlAdv1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver
			' 
			' ribbonControlAdv1.OfficeMenu
			' 
			Me.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu"
			Me.ribbonControlAdv1.OfficeMenu.Size = New System.Drawing.Size(12, 65)
			Me.ribbonControlAdv1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
			Me.ribbonControlAdv1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2013
			Me.ribbonControlAdv1.SelectedTab = Me.toolStripTabItem1
			Me.ribbonControlAdv1.Size = New System.Drawing.Size(805, 149)
			Me.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu"
			Me.ribbonControlAdv1.TabIndex = 0
			Me.ribbonControlAdv1.Text = "ribbonControlAdv1"
			Me.ribbonControlAdv1.TitleAlignment = Syncfusion.Windows.Forms.Tools.TextAlignment.Center
			Me.ribbonControlAdv1.TitleColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
			' 
			' backStageView1
			' 
			Me.backStageView1.BackStage = Me.backStage1
			Me.backStageView1.HostControl = Nothing
			Me.backStageView1.HostForm = Me
			' 
			' backStage1
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
			Me.backStage1.Location = New System.Drawing.Point(1, 31)
			Me.backStage1.Name = "backStage1"
			Me.backStage1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Silver
			Me.backStage1.Size = New System.Drawing.Size(14592, 65535)
			Me.backStage1.TabIndex = 1
			Me.backStage1.Visible = False
			' 
			' backStageButton1
			' 
			
			' 
			' backStageTab1
			' 
			Me.backStageTab1.BackColor = System.Drawing.Color.White
			Me.backStageTab1.Controls.Add(Me.label1)
			Me.backStageTab1.Image = Nothing
			Me.backStageTab1.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab1.Location = New System.Drawing.Point(129, 0)
			Me.backStageTab1.Name = "backStageTab1"
			Me.backStageTab1.ShowCloseButton = True
			Me.backStageTab1.Size = New System.Drawing.Size(14457, 65535)
			Me.backStageTab1.TabIndex = 6
			Me.backStageTab1.Text = "Info"
			Me.backStageTab1.ThemesEnabled = False
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(22, 19)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(0, 16)
			Me.label1.TabIndex = 1
			' 
			' backStageTab2
			' 
			Me.backStageTab2.BackColor = System.Drawing.Color.White
			Me.backStageTab2.Image = Nothing
			Me.backStageTab2.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab2.Location = New System.Drawing.Point(129, 0)
			Me.backStageTab2.Name = "backStageTab2"
			Me.backStageTab2.ShowCloseButton = True
			Me.backStageTab2.Size = New System.Drawing.Size(14433, 65535)
			Me.backStageTab2.TabIndex = 7
			Me.backStageTab2.Text = "Recent"
			Me.backStageTab2.ThemesEnabled = False
			' 
			' backStageTab3
			' 
			Me.backStageTab3.BackColor = System.Drawing.Color.White
			Me.backStageTab3.Image = Nothing
			Me.backStageTab3.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab3.Location = New System.Drawing.Point(129, 0)
			Me.backStageTab3.Name = "backStageTab3"
			Me.backStageTab3.ShowCloseButton = True
			Me.backStageTab3.Size = New System.Drawing.Size(14439, 65535)
			Me.backStageTab3.TabIndex = 8
			Me.backStageTab3.Text = "New"
			Me.backStageTab3.ThemesEnabled = False
			' 
			' backStageTab4
			' 
			Me.backStageTab4.BackColor = System.Drawing.Color.White
			Me.backStageTab4.Image = Nothing
			Me.backStageTab4.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab4.Location = New System.Drawing.Point(129, 0)
			Me.backStageTab4.Name = "backStageTab4"
			Me.backStageTab4.ShowCloseButton = True
			Me.backStageTab4.Size = New System.Drawing.Size(14445, 65535)
			Me.backStageTab4.TabIndex = 9
			Me.backStageTab4.Text = "Print"
			Me.backStageTab4.ThemesEnabled = False
			' 
			' backStageTab5
			' 
			Me.backStageTab5.BackColor = System.Drawing.Color.White
			Me.backStageTab5.Image = Nothing
			Me.backStageTab5.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab5.Location = New System.Drawing.Point(129, 0)
			Me.backStageTab5.Name = "backStageTab5"
			Me.backStageTab5.ShowCloseButton = True
			Me.backStageTab5.Size = New System.Drawing.Size(14451, 65535)
			Me.backStageTab5.TabIndex = 10
			Me.backStageTab5.Text = "Save and Send"
			Me.backStageTab5.ThemesEnabled = False
			' 
			' backStageTab6
			' 
			Me.backStageTab6.BackColor = System.Drawing.Color.White
			Me.backStageTab6.Image = Nothing
			Me.backStageTab6.ImageSize = New System.Drawing.Size(16, 16)
			Me.backStageTab6.Location = New System.Drawing.Point(129, 0)
			Me.backStageTab6.Name = "backStageTab6"
			Me.backStageTab6.ShowCloseButton = True
			Me.backStageTab6.Size = New System.Drawing.Size(14457, 65535)
			Me.backStageTab6.TabIndex = 11
			Me.backStageTab6.Text = "Help"
			Me.backStageTab6.ThemesEnabled = False
			' 
			' backStageButton5
			' 
			
			' 
			' toolStripTabItem1
			' 
			Me.toolStripTabItem1.ForeColor = System.Drawing.Color.Red
			Me.toolStripTabItem1.Name = "toolStripTabItem1"
			' 
			' ribbonControlAdv1.ribbonPanel1
			' 
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx1)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx2)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx5)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx9)
			Me.toolStripTabItem1.Panel.Controls.Add(Me.toolStripEx10)
			Me.toolStripTabItem1.Panel.Name = "ribbonPanel1"
			Me.toolStripTabItem1.Panel.ScrollPosition = 0
			Me.toolStripTabItem1.Panel.TabIndex = 0
			Me.toolStripTabItem1.Panel.Text = "Home"
			Me.toolStripTabItem1.Position = 0
			Me.toolStripTabItem1.Size = New System.Drawing.Size(55, 23)
			Me.toolStripTabItem1.Text = "Home"
			' 
			' toolStripEx1
			' 
			Me.toolStripEx1.AutoSize = False
			Me.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
			Me.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx1.Image = Nothing
			Me.toolStripEx1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton1, Me.toolStripPanelItem1})
			Me.toolStripEx1.Location = New System.Drawing.Point(0, 1)
			Me.toolStripEx1.Name = "toolStripEx1"
			Me.toolStripEx1.Office12Mode = False
			Me.toolStripEx1.Size = New System.Drawing.Size(89, 92)
			Me.toolStripEx1.TabIndex = 3
			Me.toolStripEx1.Text = "Clipboard"
			' 
			' toolStripButton1
			' 
			Me.toolStripButton1.AutoSize = False
			Me.toolStripButton1.Image = (CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image))
			Me.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
			Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton1.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
			Me.toolStripButton1.Name = "toolStripButton1"
			Me.toolStripButton1.Size = New System.Drawing.Size(39, 74)
			Me.toolStripButton1.Text = "Paste"
			Me.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			' 
			' toolStripPanelItem1
			' 
			Me.toolStripPanelItem1.CausesValidation = False
			Me.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton2, Me.toolStripButton3, Me.toolStripButton4})
			Me.toolStripPanelItem1.Name = "toolStripPanelItem1"
			Me.toolStripPanelItem1.Size = New System.Drawing.Size(27, 78)
			Me.toolStripPanelItem1.Text = "toolStripPanelItem1"
			Me.toolStripPanelItem1.Transparent = True
			' 
			' toolStripButton2
			' 
			Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton2.Image = (CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image))
			Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton2.Name = "toolStripButton2"
			Me.toolStripButton2.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton2.Text = "Cut"
			' 
			' toolStripButton3
			' 
			Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton3.Image = (CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image))
			Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton3.Name = "toolStripButton3"
			Me.toolStripButton3.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton3.Text = "Copy"
			' 
			' toolStripButton4
			' 
			Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
			Me.toolStripButton4.Image = (CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image))
			Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
			Me.toolStripButton4.Name = "toolStripButton4"
			Me.toolStripButton4.Size = New System.Drawing.Size(23, 20)
			Me.toolStripButton4.Text = "Format"
			' 
			' toolStripEx2
			' 
			Me.toolStripEx2.AutoSize = False
			Me.toolStripEx2.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
			Me.toolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx2.Image = Nothing
			Me.toolStripEx2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem2})
			Me.toolStripEx2.Location = New System.Drawing.Point(91, 1)
			Me.toolStripEx2.Name = "toolStripEx2"
			Me.toolStripEx2.Office12Mode = False
			Me.toolStripEx2.Size = New System.Drawing.Size(249, 92)
			Me.toolStripEx2.TabIndex = 2
			Me.toolStripEx2.Text = "Basic text"
			' 
			' toolStripPanelItem2
			' 
			Me.toolStripPanelItem2.AutoSize = False
			Me.toolStripPanelItem2.CausesValidation = False
			Me.toolStripPanelItem2.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem2.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripPanelItem3, Me.toolStripPanelItem4})
			Me.toolStripPanelItem2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
			Me.toolStripPanelItem2.Name = "toolStripPanelItem2"
			Me.toolStripPanelItem2.RowCount = 2
			Me.toolStripPanelItem2.Size = New System.Drawing.Size(220, 77)
			Me.toolStripPanelItem2.Text = "toolStripPanelItem2"
			Me.toolStripPanelItem2.Transparent = False
			' 
			' toolStripPanelItem3
			' 
			Me.toolStripPanelItem3.AutoSize = False
			Me.toolStripPanelItem3.CausesValidation = False
			Me.toolStripPanelItem3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.toolStripPanelItem3.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripComboBox1, Me.toolStripComboBox2, Me.toolStripButton11, Me.toolStripButton16})
			Me.toolStripPanelItem3.Name = "toolStripPanelItem3"
			Me.toolStripPanelItem3.RowCount = 1
			Me.toolStripPanelItem3.Size = New System.Drawing.Size(260, 35)
			Me.toolStripPanelItem3.Transparent = True
			' 
			' toolStripComboBox1
			' 
			Me.toolStripComboBox1.Name = "toolStripComboBox1"
			Me.toolStripComboBox1.Size = New System.Drawing.Size(121, 23)
			Me.toolStripComboBox1.Text = "Caibri"
			' 
			' toolStripComboBox2
			' 
			Me.toolStripComboBox2.AutoSize = False
			Me.toolStripComboBox2.Name = "toolStripComboBox2"
			Me.toolStripComboBox2.Size = New System.Drawing.Size(35, 23)
			Me.toolStripComboBox2.Text = "20"
			' 
			' toolStripButton11
			' 
			
			' 
			' toolStripTabItem2
			' 
			Me.toolStripTabItem2.Name = "toolStripTabItem2"
			' 
			' ribbonControlAdv1.ribbonPanel2
			' 
			Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx3)
			Me.toolStripTabItem2.Panel.Controls.Add(Me.toolStripEx4)
			Me.toolStripTabItem2.Panel.Name = "ribbonPanel2"
			Me.toolStripTabItem2.Panel.ScrollPosition = 0
			Me.toolStripTabItem2.Panel.TabIndex = 1
			Me.toolStripTabItem2.Panel.Text = "Insert"
			Me.toolStripTabItem2.Position = 1
			Me.toolStripTabItem2.Size = New System.Drawing.Size(53, 23)
			Me.toolStripTabItem2.Text = "Insert"
			' 
			' toolStripEx3
			' 
			Me.toolStripEx3.AutoSize = False
			Me.toolStripEx3.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
			Me.toolStripEx3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx3.Image = Nothing
			Me.toolStripEx3.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton12, Me.toolStripButton13, Me.toolStripButton14})
			Me.toolStripEx3.Location = New System.Drawing.Point(0, 1)
			Me.toolStripEx3.Name = "toolStripEx3"
			Me.toolStripEx3.Office12Mode = False
			Me.toolStripEx3.Size = New System.Drawing.Size(210, 0)
			Me.toolStripEx3.TabIndex = 0
			Me.toolStripEx3.Text = "Page"
			' 
			' toolStripButton12
			' 
			
			' 
			' toolStripEx4
			' 
			Me.toolStripEx4.AutoSize = False
			Me.toolStripEx4.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
			Me.toolStripEx4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx4.Image = Nothing
			Me.toolStripEx4.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton15})
			Me.toolStripEx4.Location = New System.Drawing.Point(212, 1)
			Me.toolStripEx4.Name = "toolStripEx4"
			Me.toolStripEx4.Office12Mode = False
			Me.toolStripEx4.Size = New System.Drawing.Size(71, 0)
			Me.toolStripEx4.TabIndex = 1
			Me.toolStripEx4.Text = "Illustrations"
			' 
			' toolStripButton15
			' 
			
			' 
			' toolStripTabItem3
			' 
			Me.toolStripTabItem3.Name = "toolStripTabItem3"
			' 
			' ribbonControlAdv1.ribbonPanel3
			' 
			Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx7)
			Me.toolStripTabItem3.Panel.Controls.Add(Me.toolStripEx8)
			Me.toolStripTabItem3.Panel.Name = "ribbonPanel3"
			Me.toolStripTabItem3.Panel.ScrollPosition = 0
			Me.toolStripTabItem3.Panel.TabIndex = 2
			Me.toolStripTabItem3.Panel.Text = "Property"
			Me.toolStripTabItem3.Position = 2
			Me.toolStripTabItem3.Size = New System.Drawing.Size(66, 23)
			Me.toolStripTabItem3.Text = "Property"
			' 
			' toolStripEx7
			' 
			Me.toolStripEx7.AutoSize = False
			Me.toolStripEx7.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx7.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
			Me.toolStripEx7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx7.Image = Nothing
			Me.toolStripEx7.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton24, Me.toolStripButton25})
			Me.toolStripEx7.Location = New System.Drawing.Point(0, 1)
			Me.toolStripEx7.Name = "toolStripEx7"
			Me.toolStripEx7.Office12Mode = False
			Me.toolStripEx7.Size = New System.Drawing.Size(140, 0)
			Me.toolStripEx7.TabIndex = 2
			Me.toolStripEx7.Text = "Data"
			' 
			' toolStripButton24
			' 
			
			' 
			' toolStripEx8
			' 
			Me.toolStripEx8.AutoSize = False
			Me.toolStripEx8.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx8.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
			Me.toolStripEx8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx8.Image = Nothing
			Me.toolStripEx8.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton26})
			Me.toolStripEx8.Location = New System.Drawing.Point(142, 1)
			Me.toolStripEx8.Name = "toolStripEx8"
			Me.toolStripEx8.Office12Mode = False
			Me.toolStripEx8.Size = New System.Drawing.Size(71, 0)
			Me.toolStripEx8.TabIndex = 3
			Me.toolStripEx8.Text = "Sheet"
			' 
			' toolStripButton26
			' 
			
			' 
			' toolStripEx6
			' 
			Me.toolStripEx6.AutoSize = False
			Me.toolStripEx6.Dock = System.Windows.Forms.DockStyle.None
			Me.toolStripEx6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))), (CInt(Fix((CByte(59))))))
			Me.toolStripEx6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
			Me.toolStripEx6.Image = Nothing
			Me.toolStripEx6.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.toolStripButton22})
			Me.toolStripEx6.Location = New System.Drawing.Point(212, 1)
			Me.toolStripEx6.Name = "toolStripEx6"
			Me.toolStripEx6.Office12Mode = False
			Me.toolStripEx6.Size = New System.Drawing.Size(71, 92)
			Me.toolStripEx6.TabIndex = 1
			Me.toolStripEx6.Text = "Illustrations"
			' 
			' toolStripButton22
			' 
		
			' 
			' panel1
			' 
			Me.panel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.panel1.BackColor = System.Drawing.Color.White
			Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel1.Controls.Add(Me.label4)
			Me.panel1.Controls.Add(Me.label3)
			Me.panel1.Controls.Add(Me.label2)
			Me.panel1.Controls.Add(Me.panel4)
			Me.panel1.Controls.Add(Me.panel3)
			Me.panel1.Location = New System.Drawing.Point(35, 50)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(724, 455)
			Me.panel1.TabIndex = 2
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label4.Location = New System.Drawing.Point(534, 11)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(74, 17)
			Me.label4.TabIndex = 11
			Me.label4.Text = "Office 2007"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label3.Location = New System.Drawing.Point(325, 11)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(74, 17)
			Me.label3.TabIndex = 10
			Me.label3.Text = "Office 2010"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(113, 11)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(74, 17)
			Me.label2.TabIndex = 9
			Me.label2.Text = "Office 2013"
			' 
			' panel4
			' 
			Me.panel4.Controls.Add(Me.panel2)
			Me.panel4.Controls.Add(Me.label5)
			Me.panel4.Controls.Add(Me.transparentPanel4)
			Me.panel4.Controls.Add(Me.transparentPanel5)
			Me.panel4.Controls.Add(Me.label6)
			Me.panel4.Controls.Add(Me.transparentPanel6)
			Me.panel4.Controls.Add(Me.label7)
			Me.panel4.Location = New System.Drawing.Point(25, 218)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(672, 211)
			Me.panel4.TabIndex = 8
			' 
			' panel2
			' 
			Me.panel2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.panel2.Controls.Add(Me.label8)
			Me.panel2.Controls.Add(Me.panel6)
			Me.panel2.Controls.Add(Me.panel5)
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(671, 211)
			Me.panel2.TabIndex = 6
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label8.Location = New System.Drawing.Point(289, 3)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(94, 17)
			Me.label8.TabIndex = 12
			Me.label8.Text = "Header Image"
			' 
			' panel6
			' 
			Me.panel6.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel6.Controls.Add(Me.transparentPanel16)
			Me.panel6.Controls.Add(Me.transparentPanel15)
			Me.panel6.Controls.Add(Me.transparentPanel12)
			Me.panel6.Controls.Add(Me.transparentPanel14)
			Me.panel6.Controls.Add(Me.transparentPanel13)
			Me.panel6.Location = New System.Drawing.Point(12, 107)
			Me.panel6.Name = "panel6"
			Me.panel6.Size = New System.Drawing.Size(642, 74)
			Me.panel6.TabIndex = 11
			' 
			' transparentPanel16
			' 
          
			' 
			' panel5
			' 
			Me.panel5.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.panel5.Controls.Add(Me.transparentPanel7)
			Me.panel5.Controls.Add(Me.transparentPanel8)
			Me.panel5.Controls.Add(Me.transparentPanel9)
			Me.panel5.Controls.Add(Me.transparentPanel10)
			Me.panel5.Controls.Add(Me.transparentPanel11)
			Me.panel5.Location = New System.Drawing.Point(12, 22)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New System.Drawing.Size(642, 81)
			Me.panel5.TabIndex = 10
			' 
			' transparentPanel7
			' 
         
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label5.Location = New System.Drawing.Point(100, 4)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(34, 17)
			Me.label5.TabIndex = 12
			Me.label5.Text = "Blue"
			' 
			' transparentPanel4
			' 
          
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label6.Location = New System.Drawing.Point(310, 4)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(40, 17)
			Me.label6.TabIndex = 13
			Me.label6.Text = "Silver"
			' 
			' transparentPanel6
			' 
           
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label7.Location = New System.Drawing.Point(526, 4)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(39, 17)
			Me.label7.TabIndex = 14
			Me.label7.Text = "Black"
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.transparentPanel3)
			Me.panel3.Controls.Add(Me.transparentPanel2)
			Me.panel3.Controls.Add(Me.transparentPanel1)
			Me.panel3.Location = New System.Drawing.Point(25, 27)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(672, 203)
			Me.panel3.TabIndex = 7
			' 
			' transparentPanel3
			' 
          
			' 
			' panel7
			' 
			Me.panel7.Controls.Add(Me.panel1)
			Me.panel7.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel7.Location = New System.Drawing.Point(6, 150)
			Me.panel7.Name = "panel7"
			Me.panel7.Size = New System.Drawing.Size(795, 549)
			Me.panel7.TabIndex = 3
			' 
			' flowLayout5
			' 
			Me.flowLayout5.ContainerControl = Me.panel7
			Me.flowLayout5.TopMargin = 50
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(807, 705)
			Me.ColorScheme = Syncfusion.Windows.Forms.Tools.RibbonForm.ColorSchemeType.Silver
			Me.Controls.Add(Me.panel7)
			Me.Controls.Add(Me.backStage1)
			Me.Controls.Add(Me.ribbonControlAdv1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.HelpButtonImage = (CType(resources.GetObject("$this.HelpButtonImage"), System.Drawing.Image))
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			Me.Text = "Ribbon Style Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
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
			Me.toolStripEx5.ResumeLayout(False)
			Me.toolStripEx5.PerformLayout()
			Me.toolStripEx9.ResumeLayout(False)
			Me.toolStripEx9.PerformLayout()
			Me.toolStripEx10.ResumeLayout(False)
			Me.toolStripEx10.PerformLayout()
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
			Me.toolStripEx6.ResumeLayout(False)
			Me.toolStripEx6.PerformLayout()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.panel4.ResumeLayout(False)
			Me.panel4.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.panel2.PerformLayout()
			Me.panel6.ResumeLayout(False)
			Me.panel5.ResumeLayout(False)
			Me.panel3.ResumeLayout(False)
			Me.panel7.ResumeLayout(False)
			CType(Me.flowLayout5, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private toolStripButton24 As System.Windows.Forms.ToolStripButton
		Private toolStripButton25 As System.Windows.Forms.ToolStripButton
		Private toolStripEx8 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton26 As System.Windows.Forms.ToolStripButton
		Private toolStripEx6 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton22 As System.Windows.Forms.ToolStripButton
		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents transparentPanel3 As TransparentPanel
		Private WithEvents transparentPanel2 As TransparentPanel
		Private WithEvents transparentPanel1 As TransparentPanel
		Private WithEvents transparentPanel6 As TransparentPanel
		Private WithEvents transparentPanel5 As TransparentPanel
		Private WithEvents transparentPanel4 As TransparentPanel
		Private panel2 As PanelExt
		Private WithEvents transparentPanel7 As TransparentPanel
		Private WithEvents transparentPanel11 As TransparentPanel
		Private WithEvents transparentPanel10 As TransparentPanel
		Private WithEvents transparentPanel9 As TransparentPanel
		Private WithEvents transparentPanel8 As TransparentPanel
		Private WithEvents transparentPanel12 As TransparentPanel
		Private WithEvents transparentPanel13 As TransparentPanel
		Private WithEvents transparentPanel14 As TransparentPanel
		Private WithEvents transparentPanel15 As TransparentPanel
		Private WithEvents transparentPanel16 As TransparentPanel
		Private panel3 As PanelExt
		Private panel5 As System.Windows.Forms.Panel
		Private panel4 As PanelExt
		Private panel6 As System.Windows.Forms.Panel
		Private panel7 As System.Windows.Forms.Panel
		Private flowLayout5 As Syncfusion.Windows.Forms.Tools.FlowLayout
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private toolStripEx5 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton20 As System.Windows.Forms.ToolStripButton
		Private toolStripButton21 As System.Windows.Forms.ToolStripButton
		Private toolStripButton29 As System.Windows.Forms.ToolStripButton
		Private toolStripEx9 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton27 As System.Windows.Forms.ToolStripButton
		Private toolStripButton23 As System.Windows.Forms.ToolStripButton
		Private toolStripButton19 As System.Windows.Forms.ToolStripButton
		Private toolStripEx10 As Syncfusion.Windows.Forms.Tools.ToolStripEx
		Private toolStripButton28 As System.Windows.Forms.ToolStripButton
		Private toolStripButton30 As System.Windows.Forms.ToolStripButton
	End Class
End Namespace

