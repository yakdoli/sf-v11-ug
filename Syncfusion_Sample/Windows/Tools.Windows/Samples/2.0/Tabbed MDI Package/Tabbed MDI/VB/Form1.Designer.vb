Imports Microsoft.VisualBasic
Imports System
Namespace TabbedMDI_2005
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
            Me.mainFrameBarManager1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(Me)
            Me.bar1 = New Syncfusion.Windows.Forms.Tools.XPMenus.Bar(Me.mainFrameBarManager1, "MainMenu")
            Me.parentBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem3 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem2 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem5 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem6 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem7 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.mdiListBarItem1 = New Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem
            Me.StylesList = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem8 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem9 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem10 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem11 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem12 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem13 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem14 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem15 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem16 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem17 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem18 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem19 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem20 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem22 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.barItem23 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.parentBarItem4 = New Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
            Me.barItem21 = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.closeAllBarItem = New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
            Me.statusBarAdv1 = New Syncfusion.Windows.Forms.Tools.StatusBarAdv
            Me.statusBarAdvPanel1 = New Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
            Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv
            Me.tabPageAdv1 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.checkBox6 = New System.Windows.Forms.CheckBox
            Me.checkBox5 = New System.Windows.Forms.CheckBox
            Me.checkBox4 = New System.Windows.Forms.CheckBox
            Me.checkBox3 = New System.Windows.Forms.CheckBox
            Me.checkBox2 = New System.Windows.Forms.CheckBox
            Me.checkBox1 = New System.Windows.Forms.CheckBox
            Me.comboBox1 = New System.Windows.Forms.ComboBox
            Me.label1 = New System.Windows.Forms.Label
            Me.tabPageAdv2 = New Syncfusion.Windows.Forms.Tools.TabPageAdv
            Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid
            Me.splitter1 = New System.Windows.Forms.Splitter
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.statusBarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.statusBarAdv1.SuspendLayout()
            CType(Me.statusBarAdvPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabControlAdv1.SuspendLayout()
            Me.tabPageAdv1.SuspendLayout()
            Me.tabPageAdv2.SuspendLayout()
            Me.SuspendLayout()
            '
            'mainFrameBarManager1
            '
            Me.mainFrameBarManager1.BarPositionInfo = CType(resources.GetObject("mainFrameBarManager1.BarPositionInfo"), System.IO.MemoryStream)
            Me.mainFrameBarManager1.Bars.Add(Me.bar1)
            Me.mainFrameBarManager1.Categories.Add("File")
            Me.mainFrameBarManager1.Categories.Add("MDI Tabs")
            Me.mainFrameBarManager1.Categories.Add("Visual Styles")
            Me.mainFrameBarManager1.Categories.Add("Help")
            Me.mainFrameBarManager1.Categories.Add("Popup")
            Me.mainFrameBarManager1.CurrentBaseFormType = ""
            Me.mainFrameBarManager1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mainFrameBarManager1.Form = Me
            Me.mainFrameBarManager1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.barItem1, Me.barItem2, Me.barItem3, Me.barItem4, Me.parentBarItem2, Me.barItem5, Me.barItem6, Me.mdiListBarItem1, Me.barItem7, Me.StylesList, Me.barItem8, Me.barItem9, Me.barItem10, Me.barItem11, Me.barItem12, Me.barItem13, Me.barItem14, Me.barItem15, Me.barItem16, Me.barItem17, Me.barItem18, Me.barItem19, Me.barItem20, Me.parentBarItem4, Me.barItem21, Me.closeAllBarItem, Me.barItem22, Me.barItem23})
            Me.mainFrameBarManager1.ResetCustomization = False
            Me.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
            '
            'bar1
            '
            Me.bar1.BarName = "MainMenu"
            Me.bar1.BarStyle = CType(((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu) _
                        Or Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible), Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)
            Me.bar1.Caption = "MainMenu"
            Me.bar1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.parentBarItem1, Me.parentBarItem2, Me.StylesList, Me.parentBarItem4})
            Me.bar1.Manager = Me.mainFrameBarManager1
            '
            'parentBarItem1
            '
            Me.parentBarItem1.CategoryIndex = 0
            Me.parentBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem1.ID = "&File"
            Me.parentBarItem1.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem1, Me.barItem3, Me.barItem4, Me.barItem2})
            Me.parentBarItem1.SeparatorIndices.AddRange(New Integer() {1, 3})
            Me.parentBarItem1.Text = "&File"
            '
            'barItem1
            '
            Me.barItem1.CategoryIndex = 0
            Me.barItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem1.ID = "New Document"
            Me.barItem1.Text = "New Document"
            '
            'barItem3
            '
            Me.barItem3.CategoryIndex = 0
            Me.barItem3.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem3.ID = "&Load TabGroupState"
            Me.barItem3.Text = "&Load TabGroupState"
            '
            'barItem4
            '
            Me.barItem4.CategoryIndex = 0
            Me.barItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem4.ID = "&Save TabGroupState"
            Me.barItem4.Text = "&Save TabGroupState"
            '
            'barItem2
            '
            Me.barItem2.CategoryIndex = 0
            Me.barItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem2.ID = "E&xit"
            Me.barItem2.Text = "E&xit"
            '
            'parentBarItem2
            '
            Me.parentBarItem2.CategoryIndex = 1
            Me.parentBarItem2.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem2.ID = "&MDI Tabs"
            Me.parentBarItem2.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem5, Me.barItem6, Me.barItem7, Me.mdiListBarItem1})
            Me.parentBarItem2.MergeOrder = 1
            Me.parentBarItem2.SeparatorIndices.AddRange(New Integer() {3})
            Me.parentBarItem2.Text = "&MDI Tabs"
            '
            'barItem5
            '
            Me.barItem5.CategoryIndex = 1
            Me.barItem5.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem5.ID = "Alignment Toggle"
            Me.barItem5.Text = "Alignment Toggle"
            '
            'barItem6
            '
            Me.barItem6.CategoryIndex = 1
            Me.barItem6.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem6.ID = "Parse Children"
            Me.barItem6.Text = "Parse Children"
            '
            'barItem7
            '
            Me.barItem7.CategoryIndex = 1
            Me.barItem7.Checked = True
            Me.barItem7.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem7.ID = "Show Properties"
            Me.barItem7.Text = "Show Properties"
            '
            'mdiListBarItem1
            '
            Me.mdiListBarItem1.CategoryIndex = 1
            Me.mdiListBarItem1.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.mdiListBarItem1.ID = "Window List"
            '
            'StylesList
            '
            Me.StylesList.CategoryIndex = 2
            Me.StylesList.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.StylesList.ID = "&Visual Styles"
            Me.StylesList.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem8, Me.barItem9, Me.barItem10, Me.barItem11, Me.barItem12, Me.barItem13, Me.barItem14, Me.barItem15, Me.barItem16, Me.barItem17, Me.barItem18, Me.barItem19, Me.barItem20, Me.barItem22, Me.barItem23})
            Me.StylesList.MergeOrder = 3
            Me.StylesList.Text = "&Visual Styles"
            '
            'barItem8
            '
            Me.barItem8.CategoryIndex = 2
            Me.barItem8.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem8.ID = "2D"
            Me.barItem8.Text = "2D"
            '
            'barItem9
            '
            Me.barItem9.CategoryIndex = 2
            Me.barItem9.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem9.ID = "3D"
            Me.barItem9.Text = "3D"
            '
            'barItem10
            '
            Me.barItem10.CategoryIndex = 2
            Me.barItem10.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem10.ID = "Workbook Mode"
            Me.barItem10.Text = "Workbook Mode"
            '
            'barItem11
            '
            Me.barItem11.CategoryIndex = 2
            Me.barItem11.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem11.ID = "OneNoteStyle"
            Me.barItem11.Text = "OneNote Style"
            '
            'barItem12
            '
            Me.barItem12.CategoryIndex = 2
            Me.barItem12.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem12.ID = "OneNoteStyleFlatTabs"
            Me.barItem12.Text = "OneNote Flat Tabs Style"
            '
            'barItem13
            '
            Me.barItem13.CategoryIndex = 2
            Me.barItem13.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem13.ID = "Office2003"
            Me.barItem13.Text = "Office 2003"
            '
            'barItem14
            '
            Me.barItem14.CategoryIndex = 2
            Me.barItem14.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem14.ID = "Whidbey"
            Me.barItem14.Text = "Whidbey"
            '
            'barItem15
            '
            Me.barItem15.CategoryIndex = 2
            Me.barItem15.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem15.ID = "DockingWhidbey"
            Me.barItem15.Text = "Docking Whidbey"
            '
            'barItem16
            '
            Me.barItem16.CategoryIndex = 2
            Me.barItem16.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem16.ID = "DockingWhidbeyBeta"
            Me.barItem16.Text = "Docking Whidbey Beta"
            '
            'barItem17
            '
            Me.barItem17.CategoryIndex = 2
            Me.barItem17.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem17.ID = "IE7"
            Me.barItem17.Text = "IE7"
            '
            'barItem18
            '
            Me.barItem18.CategoryIndex = 2
            Me.barItem18.Checked = True
            Me.barItem18.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem18.ID = "Office2007Blue"
            Me.barItem18.Text = "Office 2007 Blue"
            '
            'barItem19
            '
            Me.barItem19.CategoryIndex = 2
            Me.barItem19.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem19.ID = "Office2007Black"
            Me.barItem19.Text = "Office 2007 Black"
            '
            'barItem20
            '
            Me.barItem20.CategoryIndex = 2
            Me.barItem20.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem20.ID = "Office2007Silver"
            Me.barItem20.Text = "Office 2007 Silver"
            '
            'barItem22
            '
            Me.barItem22.CategoryIndex = 2
            Me.barItem22.ID = "Blend Light"
            Me.barItem22.Text = "Blend Light"
            '
            'barItem23
            '
            Me.barItem23.CategoryIndex = 2
            Me.barItem23.ID = "Blend Dark"
            Me.barItem23.Text = "Blend Dark"
            '
            'parentBarItem4
            '
            Me.parentBarItem4.CategoryIndex = 3
            Me.parentBarItem4.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.parentBarItem4.ID = "&Help"
            Me.parentBarItem4.Items.AddRange(New Syncfusion.Windows.Forms.Tools.XPMenus.BarItem() {Me.barItem21})
            Me.parentBarItem4.MergeOrder = 4
            Me.parentBarItem4.Text = "&Help"
            '
            'barItem21
            '
            Me.barItem21.CategoryIndex = 3
            Me.barItem21.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.barItem21.ID = "&About"
            Me.barItem21.Text = "&About"
            '
            'closeAllBarItem
            '
            Me.closeAllBarItem.CategoryIndex = 4
            Me.closeAllBarItem.CustomTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.closeAllBarItem.ID = "Close all but me"
            Me.closeAllBarItem.Text = "Close all but me"
            '
            'statusBarAdv1
            '
            Me.statusBarAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.statusBarAdv1.BorderColor = System.Drawing.Color.Black
            Me.statusBarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.statusBarAdv1.Controls.Add(Me.statusBarAdvPanel1)
            Me.statusBarAdv1.CustomLayoutBounds = New System.Drawing.Rectangle(0, 0, 0, 0)
            Me.statusBarAdv1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.statusBarAdv1.Location = New System.Drawing.Point(0, 408)
            Me.statusBarAdv1.Name = "statusBarAdv1"
            Me.statusBarAdv1.Padding = New System.Windows.Forms.Padding(3)
            Me.statusBarAdv1.Size = New System.Drawing.Size(671, 22)
            Me.statusBarAdv1.Spacing = New System.Drawing.Size(2, 2)
            Me.statusBarAdv1.TabIndex = 5
            '
            'statusBarAdvPanel1
            '
            Me.statusBarAdvPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Left
            Me.statusBarAdvPanel1.BorderColor = System.Drawing.Color.Black
            Me.statusBarAdvPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.statusBarAdvPanel1.Location = New System.Drawing.Point(0, 2)
            Me.statusBarAdvPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.statusBarAdvPanel1.Name = "statusBarAdvPanel1"
            Me.statusBarAdvPanel1.Size = New System.Drawing.Size(435, 18)
            Me.statusBarAdvPanel1.TabIndex = 1
            Me.statusBarAdvPanel1.Text = Nothing
            '
            'tabControlAdv1
            '
            Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv1)
            Me.tabControlAdv1.Controls.Add(Me.tabPageAdv2)
            Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Right
            Me.tabControlAdv1.FixedSingleBorderColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(227, Byte), Integer))
            Me.tabControlAdv1.Location = New System.Drawing.Point(456, 24)
            Me.tabControlAdv1.Name = "tabControlAdv1"
            Me.tabControlAdv1.Size = New System.Drawing.Size(215, 384)
            Me.tabControlAdv1.TabGap = 10
            Me.tabControlAdv1.TabIndex = 6
            Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
            '
            'tabPageAdv1
            '
            Me.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.tabPageAdv1.Controls.Add(Me.checkBox6)
            Me.tabPageAdv1.Controls.Add(Me.checkBox5)
            Me.tabPageAdv1.Controls.Add(Me.checkBox4)
            Me.tabPageAdv1.Controls.Add(Me.checkBox3)
            Me.tabPageAdv1.Controls.Add(Me.checkBox2)
            Me.tabPageAdv1.Controls.Add(Me.checkBox1)
            Me.tabPageAdv1.Controls.Add(Me.comboBox1)
            Me.tabPageAdv1.Controls.Add(Me.label1)
            Me.tabPageAdv1.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv1.Location = New System.Drawing.Point(1, 22)
            Me.tabPageAdv1.Name = "tabPageAdv1"
            Me.tabPageAdv1.ShowCloseButton = True
            Me.tabPageAdv1.Size = New System.Drawing.Size(213, 361)
            Me.tabPageAdv1.TabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
            Me.tabPageAdv1.TabIndex = 1
            Me.tabPageAdv1.Text = "Features"
            Me.tabPageAdv1.ThemesEnabled = False
            '
            'checkBox6
            '
            Me.checkBox6.AutoSize = True
            Me.checkBox6.Checked = True
            Me.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox6.Location = New System.Drawing.Point(8, 118)
            Me.checkBox6.Name = "checkBox6"
            Me.checkBox6.Size = New System.Drawing.Size(116, 17)
            Me.checkBox6.TabIndex = 3
            Me.checkBox6.Text = "Show Close Button"
            Me.checkBox6.UseVisualStyleBackColor = True
            '
            'checkBox5
            '
            Me.checkBox5.AutoSize = True
            Me.checkBox5.Location = New System.Drawing.Point(8, 150)
            Me.checkBox5.Name = "checkBox5"
            Me.checkBox5.Size = New System.Drawing.Size(181, 17)
            Me.checkBox5.TabIndex = 2
            Me.checkBox5.Text = "Close Tab on Middle button click"
            Me.checkBox5.UseVisualStyleBackColor = True
            '
            'checkBox4
            '
            Me.checkBox4.AutoSize = True
            Me.checkBox4.Location = New System.Drawing.Point(8, 216)
            Me.checkBox4.Name = "checkBox4"
            Me.checkBox4.Size = New System.Drawing.Size(100, 17)
            Me.checkBox4.TabIndex = 2
            Me.checkBox4.Text = "Hide Tab Panel"
            Me.checkBox4.UseVisualStyleBackColor = True
            '
            'checkBox3
            '
            Me.checkBox3.AutoSize = True
            Me.checkBox3.Checked = True
            Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox3.Location = New System.Drawing.Point(8, 184)
            Me.checkBox3.Name = "checkBox3"
            Me.checkBox3.Size = New System.Drawing.Size(107, 17)
            Me.checkBox3.TabIndex = 2
            Me.checkBox3.Text = "Use Icon in Tabs"
            Me.checkBox3.UseVisualStyleBackColor = True
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Location = New System.Drawing.Point(8, 249)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(197, 17)
            Me.checkBox2.TabIndex = 2
            Me.checkBox2.Text = "Show Individual Close Button for 2,4"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Location = New System.Drawing.Point(8, 86)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(138, 17)
            Me.checkBox1.TabIndex = 2
            Me.checkBox1.Text = "Show DropDownButton"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'comboBox1
            '
            Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"Default", "Office2003", "VS2005", "Office2007", "Office2007Outlook"})
            Me.comboBox1.Location = New System.Drawing.Point(8, 43)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(164, 21)
            Me.comboBox1.TabIndex = 1
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(5, 18)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(132, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "Context Menu Style"
            '
            'tabPageAdv2
            '
            Me.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(251, Byte), Integer))
            Me.tabPageAdv2.Controls.Add(Me.propertyGrid1)
            Me.tabPageAdv2.ImageSize = New System.Drawing.Size(16, 16)
            Me.tabPageAdv2.Location = New System.Drawing.Point(1, 22)
            Me.tabPageAdv2.Name = "tabPageAdv2"
            Me.tabPageAdv2.ShowCloseButton = True
            Me.tabPageAdv2.Size = New System.Drawing.Size(213, 361)
            Me.tabPageAdv2.TabIndex = 1
            Me.tabPageAdv2.Text = "Property Grid"
            Me.tabPageAdv2.ThemesEnabled = False
            '
            'propertyGrid1
            '
            Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.propertyGrid1.Location = New System.Drawing.Point(0, 0)
            Me.propertyGrid1.Name = "propertyGrid1"
            Me.propertyGrid1.Size = New System.Drawing.Size(213, 361)
            Me.propertyGrid1.TabIndex = 0
            '
            'splitter1
            '
            Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
            Me.splitter1.Location = New System.Drawing.Point(453, 24)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 384)
            Me.splitter1.TabIndex = 7
            Me.splitter1.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(671, 430)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.tabControlAdv1)
            Me.Controls.Add(Me.statusBarAdv1)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Tabbed MDI"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.mainFrameBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.statusBarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.statusBarAdv1.ResumeLayout(False)
            CType(Me.statusBarAdvPanel1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabControlAdv1.ResumeLayout(False)
            Me.tabPageAdv1.ResumeLayout(False)
            Me.tabPageAdv1.PerformLayout()
            Me.tabPageAdv2.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private mainFrameBarManager1 As Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager
        Private bar1 As Syncfusion.Windows.Forms.Tools.XPMenus.Bar
        Private parentBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem3 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem2 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem5 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem6 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private mdiListBarItem1 As Syncfusion.Windows.Forms.Tools.XPMenus.MdiListBarItem
        Private WithEvents barItem7 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private StylesList As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem8 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem9 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem10 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem11 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem12 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem13 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem14 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem15 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem16 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem17 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem18 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem19 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents barItem20 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private parentBarItem4 As Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem
        Private WithEvents barItem21 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Private WithEvents closeAllBarItem As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        'private Syncfusion.Windows.Forms.Tools.TabbedMDIManager tabbedMDIManager;
        Private statusBarAdv1 As Syncfusion.Windows.Forms.Tools.StatusBarAdv
        Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
        Private tabPageAdv1 As Syncfusion.Windows.Forms.Tools.TabPageAdv
        Private tabPageAdv2 As Syncfusion.Windows.Forms.Tools.TabPageAdv
        Private splitter1 As System.Windows.Forms.Splitter
        Private comboBox1 As System.Windows.Forms.ComboBox
        Private label1 As System.Windows.Forms.Label
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox5 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox4 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox6 As System.Windows.Forms.CheckBox
        Private propertyGrid1 As System.Windows.Forms.PropertyGrid
        Private statusBarAdvPanel1 As Syncfusion.Windows.Forms.Tools.StatusBarAdvPanel
        Friend WithEvents barItem22 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem
        Friend WithEvents barItem23 As Syncfusion.Windows.Forms.Tools.XPMenus.BarItem

	End Class
End Namespace

