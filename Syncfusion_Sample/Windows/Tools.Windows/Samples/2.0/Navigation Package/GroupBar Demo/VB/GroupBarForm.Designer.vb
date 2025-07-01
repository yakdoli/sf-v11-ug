Imports Microsoft.VisualBasic
Imports System
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Namespace GroupBarDemo_2005
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
			Dim listViewItem7 As New System.Windows.Forms.ListViewItem(New String() { "Inbox"}, 2, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem8 As New System.Windows.Forms.ListViewItem(New String() { "Sent Items"}, 6, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem9 As New System.Windows.Forms.ListViewItem(New String() { "Junk Email"}, 0, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem10 As New System.Windows.Forms.ListViewItem(New String() { "Deleted Items"}, 1, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem11 As New System.Windows.Forms.ListViewItem(New String() { "Drafts"}, 5, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim listViewItem12 As New System.Windows.Forms.ListViewItem(New String() { "Outbox"}, 3, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0))))
			Dim treeNode41 As New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
			Dim treeNode42 As New System.Windows.Forms.TreeNode("Junk Email", 0, 0)
			Dim treeNode43 As New System.Windows.Forms.TreeNode("InBox", 2, 2)
			Dim treeNode44 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode45 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode46 As New System.Windows.Forms.TreeNode("Personal Folders", 7, 7, New System.Windows.Forms.TreeNode() { treeNode41, treeNode42, treeNode43, treeNode44, treeNode45})
			Dim treeNode47 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode48 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode49 As New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
			Dim treeNode50 As New System.Windows.Forms.TreeNode("Archive Folders", 8, 8, New System.Windows.Forms.TreeNode() { treeNode47, treeNode48, treeNode49})
			Dim treeNode51 As New System.Windows.Forms.TreeNode("Drafts", 5, 5)
			Dim treeNode52 As New System.Windows.Forms.TreeNode("InBox", 2, 2)
			Dim treeNode53 As New System.Windows.Forms.TreeNode("OutBox", 3, 3)
			Dim treeNode54 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode55 As New System.Windows.Forms.TreeNode("Public")
			Dim treeNode56 As New System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, New System.Windows.Forms.TreeNode() { treeNode51, treeNode52, treeNode53, treeNode54, treeNode55})
			Dim treeNode1 As New System.Windows.Forms.TreeNode("Junk Mail", 3, 3)
			Dim treeNode2 As New System.Windows.Forms.TreeNode("Deleted Items", 1, 1, New System.Windows.Forms.TreeNode() { treeNode1})
			Dim treeNode3 As New System.Windows.Forms.TreeNode("Junk Email", 0, 0)
			Dim treeNode4 As New System.Windows.Forms.TreeNode("InBox", 2, 2)
			Dim treeNode5 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode6 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode7 As New System.Windows.Forms.TreeNode("Calendar")
			Dim treeNode8 As New System.Windows.Forms.TreeNode("Contacts", 9, 9)
			Dim treeNode9 As New System.Windows.Forms.TreeNode("Drafts", 5, 5)
			Dim treeNode10 As New System.Windows.Forms.TreeNode("Journal", 13, 13)
			Dim treeNode11 As New System.Windows.Forms.TreeNode("Personal Folders", 7, 7, New System.Windows.Forms.TreeNode() { treeNode2, treeNode3, treeNode4, treeNode5, treeNode6, treeNode7, treeNode8, treeNode9, treeNode10})
			Dim treeNode12 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4)
			Dim treeNode13 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode14 As New System.Windows.Forms.TreeNode("Deleted Items", 1, 1)
			Dim treeNode15 As New System.Windows.Forms.TreeNode("Archive Folders", 8, 8, New System.Windows.Forms.TreeNode() { treeNode12, treeNode13, treeNode14})
			Dim treeNode16 As New System.Windows.Forms.TreeNode("Drafts", 5, 5)
			Dim treeNode57 As New System.Windows.Forms.TreeNode("InBox", 2, 2)
			Dim treeNode58 As New System.Windows.Forms.TreeNode("OutBox", 3, 3)
			Dim treeNode59 As New System.Windows.Forms.TreeNode("Sent Items", 6, 6)
			Dim treeNode60 As New System.Windows.Forms.TreeNode("Public")
			Dim treeNode61 As New System.Windows.Forms.TreeNode("Syncfusion Email", 8, 8, New System.Windows.Forms.TreeNode() { treeNode16, treeNode57, treeNode58, treeNode59, treeNode60})
			Dim treeNode62 As New System.Windows.Forms.TreeNode("For Follow Up", 4, 4)
			Dim treeNode63 As New System.Windows.Forms.TreeNode("Large Mail", 4, 4)
			Dim treeNode64 As New System.Windows.Forms.TreeNode("Search Folders", 4, 4, New System.Windows.Forms.TreeNode() { treeNode62, treeNode63})
			Me.tabControlAdv1 = New Syncfusion.Windows.Forms.Tools.TabControlAdv()
			Me.tabPageVS = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.gpVSAppearance = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.panel16 = New System.Windows.Forms.Panel()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label17 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.cbflatLook = New System.Windows.Forms.CheckBox()
			Me.cpBack = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.label1 = New System.Windows.Forms.Label()
			Me.cmbGBBorder = New System.Windows.Forms.ComboBox()
			Me.cbDrawClientBorder = New System.Windows.Forms.CheckBox()
			Me.cmbGBVisualStyle = New System.Windows.Forms.ComboBox()
			Me.gpVSBehavior = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.panel15 = New System.Windows.Forms.Panel()
			Me.label34 = New System.Windows.Forms.Label()
			Me.label35 = New System.Windows.Forms.Label()
			Me.cbAnimatedSelection = New System.Windows.Forms.CheckBox()
			Me.cbIntegratedScrolling = New System.Windows.Forms.CheckBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.cmbTextAlignment = New System.Windows.Forms.ComboBox()
			Me.gbVisualStudio = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.WinFormsGroupView = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.ilGroupBarLarge = New System.Windows.Forms.ImageList(Me.components)
			Me.ilGroupBarSmall = New System.Windows.Forms.ImageList(Me.components)
			Me.GeneralGroupView = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.ComponentsGroupView = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.WinFormsGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.ComponentsGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.GeneralGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.tabPageOutlook = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.panel23 = New System.Windows.Forms.Panel()
			Me.label20 = New System.Windows.Forms.Label()
			Me.cbCollapse = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.label15 = New System.Windows.Forms.Label()
			Me.cbAutoClose = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.cbShowGripper = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.numericCollapsedWidth = New System.Windows.Forms.NumericUpDown()
			Me.label18 = New System.Windows.Forms.Label()
			Me.cmbPopupResize = New System.Windows.Forms.ComboBox()
			Me.panel18 = New System.Windows.Forms.Panel()
			Me.label28 = New System.Windows.Forms.Label()
			Me.label29 = New System.Windows.Forms.Label()
			Me.cbAllowCollapse = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.panel25 = New System.Windows.Forms.Panel()
			Me.cbChevron = New System.Windows.Forms.CheckBox()
			Me.cbImageInHeader = New System.Windows.Forms.CheckBox()
			Me.panel17 = New System.Windows.Forms.Panel()
			Me.label23 = New System.Windows.Forms.Label()
			Me.label27 = New System.Windows.Forms.Label()
			Me.cbStackedMode = New System.Windows.Forms.CheckBox()
			Me.label25 = New System.Windows.Forms.Label()
			Me.cmbOutLookGBStyle = New System.Windows.Forms.ComboBox()
			Me.label26 = New System.Windows.Forms.Label()
			Me.cmbOutLookGBColorScheme = New System.Windows.Forms.ComboBox()
			Me.gbOutlook = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.listView3 = New System.Windows.Forms.ListView()
			Me.columnHeader3 = New System.Windows.Forms.ColumnHeader()
			Me.smallImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.xpTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.treeView3 = New System.Windows.Forms.TreeView()
			Me.xpTaskBar6 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox10 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel8 = New System.Windows.Forms.Panel()
			Me.label16 = New System.Windows.Forms.Label()
			Me.xpTaskBarBox11 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel11 = New System.Windows.Forms.Panel()
			Me.panel14 = New System.Windows.Forms.Panel()
			Me.radioButton23 = New System.Windows.Forms.RadioButton()
			Me.radioButton24 = New System.Windows.Forms.RadioButton()
			Me.radioButton25 = New System.Windows.Forms.RadioButton()
			Me.radioButton26 = New System.Windows.Forms.RadioButton()
			Me.radioButton27 = New System.Windows.Forms.RadioButton()
			Me.xpTaskBar4 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox7 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel6 = New System.Windows.Forms.Panel()
			Me.label14 = New System.Windows.Forms.Label()
			Me.xpTaskBarBox8 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel9 = New System.Windows.Forms.Panel()
			Me.radioButton18 = New System.Windows.Forms.RadioButton()
			Me.radioButton19 = New System.Windows.Forms.RadioButton()
			Me.radioButton20 = New System.Windows.Forms.RadioButton()
			Me.radioButton21 = New System.Windows.Forms.RadioButton()
			Me.radioButton22 = New System.Windows.Forms.RadioButton()
			Me.xpTaskBar2 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox3 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel4 = New System.Windows.Forms.Panel()
			Me.label9 = New System.Windows.Forms.Label()
			Me.xpTaskBarBox4 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel7 = New System.Windows.Forms.Panel()
			Me.radioButton12 = New System.Windows.Forms.RadioButton()
			Me.radioButton11 = New System.Windows.Forms.RadioButton()
			Me.radioButton6 = New System.Windows.Forms.RadioButton()
			Me.radioButton7 = New System.Windows.Forms.RadioButton()
			Me.radioButton8 = New System.Windows.Forms.RadioButton()
			Me.radioButton9 = New System.Windows.Forms.RadioButton()
			Me.radioButton10 = New System.Windows.Forms.RadioButton()
			Me.xpTaskBar3 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox5 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel5 = New System.Windows.Forms.Panel()
			Me.label8 = New System.Windows.Forms.Label()
			Me.xpTaskBarBox6 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.radioButton5 = New System.Windows.Forms.RadioButton()
			Me.radioButton4 = New System.Windows.Forms.RadioButton()
			Me.radioButton3 = New System.Windows.Forms.RadioButton()
			Me.radioButton2 = New System.Windows.Forms.RadioButton()
			Me.radioButton1 = New System.Windows.Forms.RadioButton()
			Me.calendarPanel = New System.Windows.Forms.Panel()
			Me.monthCalendarAdv2 = New Syncfusion.Windows.Forms.Tools.MonthCalendarAdv()
			Me.gradientLabel10 = New Syncfusion.Windows.Forms.Tools.GradientLabel()
			Me.panel13 = New System.Windows.Forms.Panel()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.panel12 = New System.Windows.Forms.Panel()
			Me.linkLabel10 = New System.Windows.Forms.LinkLabel()
			Me.xpTaskBar5 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox9 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.panel10 = New System.Windows.Forms.Panel()
			Me.treeView1 = New System.Windows.Forms.TreeView()
			Me.MailGgroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.ContactsGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.TasksGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.NotesgroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.FolderListGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.CalendarGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.JournalGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.tabPageAdvanced = New Syncfusion.Windows.Forms.Tools.TabPageAdv()
			Me.gradientPanel7 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.listView1 = New System.Windows.Forms.ListView()
			Me.columnHeader1 = New System.Windows.Forms.ColumnHeader()
			Me.columnHeader2 = New System.Windows.Forms.ColumnHeader()
			Me.panel21 = New System.Windows.Forms.Panel()
			Me.label36 = New System.Windows.Forms.Label()
			Me.label37 = New System.Windows.Forms.Label()
			Me.gradientPanel6 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.label24 = New System.Windows.Forms.Label()
			Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.label38 = New System.Windows.Forms.Label()
			Me.label19 = New System.Windows.Forms.Label()
			Me.label22 = New System.Windows.Forms.Label()
			Me.label21 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.cpCustomColor = New Syncfusion.Windows.Forms.ColorPickerButton()
			Me.panel19 = New System.Windows.Forms.Panel()
			Me.label30 = New System.Windows.Forms.Label()
			Me.label31 = New System.Windows.Forms.Label()
			Me.gbAdvanced = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.NestedGroupBar = New Syncfusion.Windows.Forms.Tools.GroupBar()
			Me.gvOffice = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.PersonalGroupView = New Syncfusion.Windows.Forms.Tools.GroupView()
			Me.PersonalGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.OfficeGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.panel24 = New System.Windows.Forms.Panel()
			Me.label4 = New System.Windows.Forms.Label()
			Me.CustomControlsPanel = New System.Windows.Forms.Panel()
			Me.checkBoxAdv2 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.checkBoxAdv1 = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv()
			Me.monthCalendarAdv1 = New Syncfusion.Windows.Forms.Tools.MonthCalendarAdv()
			Me.panel20 = New System.Windows.Forms.Panel()
			Me.label32 = New System.Windows.Forms.Label()
			Me.panel22 = New System.Windows.Forms.Panel()
			Me.label33 = New System.Windows.Forms.Label()
			Me.CustomControlsGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.NestedGroupBarItem = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem2 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem1 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.groupBarItem3 = New Syncfusion.Windows.Forms.Tools.GroupBarItem()
			Me.label12 = New System.Windows.Forms.Label()
			Me.label13 = New System.Windows.Forms.Label()
			Me.radioButton13 = New System.Windows.Forms.RadioButton()
			Me.radioButton14 = New System.Windows.Forms.RadioButton()
			Me.radioButton15 = New System.Windows.Forms.RadioButton()
			Me.radioButton16 = New System.Windows.Forms.RadioButton()
			Me.radioButton17 = New System.Windows.Forms.RadioButton()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.imageListAdv1 = New Syncfusion.Windows.Forms.Tools.ImageListAdv(Me.components)
			Me.scrollersFrame1 = New Syncfusion.Windows.Forms.ScrollersFrame(Me.components)
			Me.scrollersFrame2 = New Syncfusion.Windows.Forms.ScrollersFrame(Me.components)
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControlAdv1.SuspendLayout()
			Me.tabPageVS.SuspendLayout()
			CType(Me.gpVSAppearance, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gpVSAppearance.SuspendLayout()
			Me.panel16.SuspendLayout()
			CType(Me.gpVSBehavior, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gpVSBehavior.SuspendLayout()
			Me.panel15.SuspendLayout()
			CType(Me.gbVisualStudio, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gbVisualStudio.SuspendLayout()
			Me.tabPageOutlook.SuspendLayout()
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel3.SuspendLayout()
			Me.panel23.SuspendLayout()
			CType(Me.cbCollapse, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbAutoClose, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cbShowGripper, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.numericCollapsedWidth, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel18.SuspendLayout()
			CType(Me.cbAllowCollapse, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel2.SuspendLayout()
			Me.panel25.SuspendLayout()
			Me.panel17.SuspendLayout()
			CType(Me.gbOutlook, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gbOutlook.SuspendLayout()
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar1.SuspendLayout()
			Me.xpTaskBarBox1.SuspendLayout()
			Me.panel1.SuspendLayout()
			Me.xpTaskBarBox2.SuspendLayout()
			Me.panel2.SuspendLayout()
			CType(Me.xpTaskBar6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar6.SuspendLayout()
			Me.xpTaskBarBox10.SuspendLayout()
			Me.panel8.SuspendLayout()
			Me.xpTaskBarBox11.SuspendLayout()
			Me.panel11.SuspendLayout()
			Me.panel14.SuspendLayout()
			CType(Me.xpTaskBar4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar4.SuspendLayout()
			Me.xpTaskBarBox7.SuspendLayout()
			Me.panel6.SuspendLayout()
			Me.xpTaskBarBox8.SuspendLayout()
			Me.panel9.SuspendLayout()
			CType(Me.xpTaskBar2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar2.SuspendLayout()
			Me.xpTaskBarBox3.SuspendLayout()
			Me.panel4.SuspendLayout()
			Me.xpTaskBarBox4.SuspendLayout()
			Me.panel7.SuspendLayout()
			CType(Me.xpTaskBar3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar3.SuspendLayout()
			Me.xpTaskBarBox5.SuspendLayout()
			Me.panel5.SuspendLayout()
			Me.xpTaskBarBox6.SuspendLayout()
			Me.panel3.SuspendLayout()
			Me.calendarPanel.SuspendLayout()
			CType(Me.monthCalendarAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel13.SuspendLayout()
			Me.panel12.SuspendLayout()
			CType(Me.xpTaskBar5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar5.SuspendLayout()
			Me.xpTaskBarBox9.SuspendLayout()
			Me.panel10.SuspendLayout()
			Me.tabPageAdvanced.SuspendLayout()
			CType(Me.gradientPanel7, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel7.SuspendLayout()
			Me.panel21.SuspendLayout()
			CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel6.SuspendLayout()
			CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel4.SuspendLayout()
			Me.panel19.SuspendLayout()
			CType(Me.gbAdvanced, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gbAdvanced.SuspendLayout()
			CType(Me.NestedGroupBar, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.NestedGroupBar.SuspendLayout()
			Me.panel24.SuspendLayout()
			Me.CustomControlsPanel.SuspendLayout()
			CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.monthCalendarAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel20.SuspendLayout()
			Me.panel22.SuspendLayout()
			Me.SuspendLayout()
			' 
			' tabControlAdv1
			' 
			Me.tabControlAdv1.ActiveTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.tabControlAdv1.Controls.Add(Me.tabPageVS)
			Me.tabControlAdv1.Controls.Add(Me.tabPageOutlook)
			Me.tabControlAdv1.Controls.Add(Me.tabPageAdvanced)
			Me.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabControlAdv1.Location = New System.Drawing.Point(0, 0)
			Me.tabControlAdv1.Name = "tabControlAdv1"
			Me.tabControlAdv1.Size = New System.Drawing.Size(557, 513)
			Me.tabControlAdv1.TabGap = 10
			Me.tabControlAdv1.TabIndex = 1
			Me.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(199))))), (CInt(Fix((CByte(216))))), (CInt(Fix((CByte(237))))))
			Me.tabControlAdv1.TabStyle = GetType(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007)
			Me.tabControlAdv1.ThemesEnabled = True
			' 
			' tabPageVS
			' 
			Me.tabPageVS.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(247))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(255))))))
			Me.tabPageVS.Controls.Add(Me.gpVSAppearance)
			Me.tabPageVS.Controls.Add(Me.gpVSBehavior)
			Me.tabPageVS.Controls.Add(Me.gbVisualStudio)
			Me.tabPageVS.Location = New System.Drawing.Point(3, 31)
			Me.tabPageVS.Name = "tabPageVS"
			Me.tabPageVS.Size = New System.Drawing.Size(550, 478)
			Me.tabPageVS.TabIndex = 1
			Me.tabPageVS.Text = "VS Like GroupBar"
			Me.tabPageVS.ThemesEnabled = False
			' 
			' gpVSAppearance
			' 
			Me.gpVSAppearance.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))))
			Me.gpVSAppearance.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(213))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(246))))))
			Me.gpVSAppearance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gpVSAppearance.Controls.Add(Me.panel16)
			Me.gpVSAppearance.Controls.Add(Me.label2)
			Me.gpVSAppearance.Controls.Add(Me.label5)
			Me.gpVSAppearance.Controls.Add(Me.cbflatLook)
			Me.gpVSAppearance.Controls.Add(Me.cpBack)
			Me.gpVSAppearance.Controls.Add(Me.label1)
			Me.gpVSAppearance.Controls.Add(Me.cmbGBBorder)
			Me.gpVSAppearance.Controls.Add(Me.cbDrawClientBorder)
			Me.gpVSAppearance.Controls.Add(Me.cmbGBVisualStyle)
			Me.gpVSAppearance.Location = New System.Drawing.Point(302, 242)
			Me.gpVSAppearance.Name = "gpVSAppearance"
			Me.gpVSAppearance.Size = New System.Drawing.Size(220, 180)
			Me.gpVSAppearance.TabIndex = 196
			' 
			' panel16
			' 
			Me.panel16.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(254))))))
			Me.panel16.Controls.Add(Me.label6)
			Me.panel16.Controls.Add(Me.label17)
			Me.panel16.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel16.Location = New System.Drawing.Point(0, 0)
			Me.panel16.Name = "panel16"
			Me.panel16.Size = New System.Drawing.Size(218, 27)
			Me.panel16.TabIndex = 157
			' 
			' label6
			' 
			Me.label6.BackColor = System.Drawing.Color.White
			Me.label6.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.label6.Location = New System.Drawing.Point(0, 25)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(218, 2)
			Me.label6.TabIndex = 139
			' 
			' label17
			' 
			Me.label17.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label17.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label17.Image = (CType(resources.GetObject("label17.Image"), System.Drawing.Image))
			Me.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label17.Location = New System.Drawing.Point(10, 5)
			Me.label17.Name = "label17"
			Me.label17.Size = New System.Drawing.Size(97, 17)
			Me.label17.TabIndex = 170
			Me.label17.Text = "Appearance"
			Me.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.BackColor = System.Drawing.Color.Transparent
			Me.label2.ForeColor = System.Drawing.Color.Black
			Me.label2.Location = New System.Drawing.Point(13, 149)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(66, 13)
			Me.label2.TabIndex = 139
			Me.label2.Text = "Visual Styles"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.BackColor = System.Drawing.Color.Transparent
			Me.label5.ForeColor = System.Drawing.Color.Black
			Me.label5.Location = New System.Drawing.Point(13, 37)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(56, 13)
			Me.label5.TabIndex = 149
			Me.label5.Text = "BackColor"
			' 
			' cbflatLook
			' 
			Me.cbflatLook.AutoSize = True
			Me.cbflatLook.BackColor = System.Drawing.Color.Transparent
			Me.cbflatLook.Location = New System.Drawing.Point(13, 63)
			Me.cbflatLook.Name = "cbflatLook"
			Me.cbflatLook.Size = New System.Drawing.Size(70, 17)
			Me.cbflatLook.TabIndex = 133
			Me.cbflatLook.Text = "Flat Look"
			Me.cbflatLook.UseVisualStyleBackColor = False
'			Me.cbflatLook.CheckedChanged += New System.EventHandler(Me.flatLookCheckBox_CheckedChanged)
			' 
			' cpBack
			' 
			Me.cpBack.BackColor = System.Drawing.SystemColors.Control
			Me.cpBack.ColorUISize = New System.Drawing.Size(208, 230)
			Me.cpBack.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cpBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cpBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cpBack.ForeColor = System.Drawing.Color.MidnightBlue
			Me.cpBack.Location = New System.Drawing.Point(84, 37)
			Me.cpBack.Name = "cpBack"
			Me.cpBack.SelectedAsBackcolor = True
			Me.cpBack.SelectedColor = System.Drawing.SystemColors.Control
			Me.cpBack.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.cpBack.Size = New System.Drawing.Size(20, 20)
			Me.cpBack.TabIndex = 148
			Me.cpBack.UseVisualStyleBackColor = False
'			Me.cpBack.ColorSelected += New System.EventHandler(Me.GBBackColorPickerButton_ColorSelected)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.BackColor = System.Drawing.Color.Transparent
			Me.label1.ForeColor = System.Drawing.Color.Black
			Me.label1.Location = New System.Drawing.Point(13, 123)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(109, 13)
			Me.label1.TabIndex = 136
			Me.label1.Text = "GroupBar BorderStyle"
			' 
			' cmbGBBorder
			' 
			Me.cmbGBBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbGBBorder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.cmbGBBorder.FormattingEnabled = True
			Me.cmbGBBorder.Items.AddRange(New Object() { "None", "FixedSingle", "Fixed3D"})
			Me.cmbGBBorder.Location = New System.Drawing.Point(125, 123)
			Me.cmbGBBorder.Name = "cmbGBBorder"
			Me.cmbGBBorder.Size = New System.Drawing.Size(82, 21)
			Me.cmbGBBorder.TabIndex = 137
'			Me.cmbGBBorder.SelectedIndexChanged += New System.EventHandler(Me.GBBorderComboBox_SelectedIndexChanged)
			' 
			' cbDrawClientBorder
			' 
			Me.cbDrawClientBorder.AutoSize = True
			Me.cbDrawClientBorder.BackColor = System.Drawing.Color.Transparent
			Me.cbDrawClientBorder.Location = New System.Drawing.Point(13, 93)
			Me.cbDrawClientBorder.Name = "cbDrawClientBorder"
			Me.cbDrawClientBorder.Size = New System.Drawing.Size(108, 17)
			Me.cbDrawClientBorder.TabIndex = 138
			Me.cbDrawClientBorder.Text = "DrawClientBorder"
			Me.cbDrawClientBorder.UseVisualStyleBackColor = False
'			Me.cbDrawClientBorder.CheckedChanged += New System.EventHandler(Me.ClientBorderCheckBox_CheckedChanged)
			' 
			' cmbGBVisualStyle
			' 
			Me.cmbGBVisualStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbGBVisualStyle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.cmbGBVisualStyle.FormattingEnabled = True
			Me.cmbGBVisualStyle.Items.AddRange(New Object() { "Default", "Office2003", "Office2007"})
			Me.cmbGBVisualStyle.Location = New System.Drawing.Point(125, 149)
			Me.cmbGBVisualStyle.Name = "cmbGBVisualStyle"
			Me.cmbGBVisualStyle.Size = New System.Drawing.Size(82, 21)
			Me.cmbGBVisualStyle.TabIndex = 140
'			Me.cmbGBVisualStyle.SelectedIndexChanged += New System.EventHandler(Me.GBVisualStyleComboBox_SelectedIndexChanged)
			' 
			' gpVSBehavior
			' 
			Me.gpVSBehavior.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))))
			Me.gpVSBehavior.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(213))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(246))))))
			Me.gpVSBehavior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gpVSBehavior.Controls.Add(Me.panel15)
			Me.gpVSBehavior.Controls.Add(Me.cbAnimatedSelection)
			Me.gpVSBehavior.Controls.Add(Me.cbIntegratedScrolling)
			Me.gpVSBehavior.Controls.Add(Me.label3)
			Me.gpVSBehavior.Controls.Add(Me.cmbTextAlignment)
			Me.gpVSBehavior.Location = New System.Drawing.Point(302, 19)
			Me.gpVSBehavior.Name = "gpVSBehavior"
			Me.gpVSBehavior.Size = New System.Drawing.Size(220, 180)
			Me.gpVSBehavior.TabIndex = 195
			' 
			' panel15
			' 
			Me.panel15.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(254))))))
			Me.panel15.Controls.Add(Me.label34)
			Me.panel15.Controls.Add(Me.label35)
			Me.panel15.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel15.Location = New System.Drawing.Point(0, 0)
			Me.panel15.Name = "panel15"
			Me.panel15.Size = New System.Drawing.Size(218, 27)
			Me.panel15.TabIndex = 157
			' 
			' label34
			' 
			Me.label34.BackColor = System.Drawing.Color.White
			Me.label34.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.label34.Location = New System.Drawing.Point(0, 25)
			Me.label34.Name = "label34"
			Me.label34.Size = New System.Drawing.Size(218, 2)
			Me.label34.TabIndex = 139
			' 
			' label35
			' 
			Me.label35.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label35.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label35.Image = (CType(resources.GetObject("label35.Image"), System.Drawing.Image))
			Me.label35.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label35.Location = New System.Drawing.Point(10, 2)
			Me.label35.Name = "label35"
			Me.label35.Size = New System.Drawing.Size(77, 19)
			Me.label35.TabIndex = 170
			Me.label35.Text = "Behavior"
			Me.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' cbAnimatedSelection
			' 
			Me.cbAnimatedSelection.AutoSize = True
			Me.cbAnimatedSelection.BackColor = System.Drawing.Color.Transparent
			Me.cbAnimatedSelection.Checked = True
			Me.cbAnimatedSelection.CheckState = System.Windows.Forms.CheckState.Checked
			Me.cbAnimatedSelection.Location = New System.Drawing.Point(13, 48)
			Me.cbAnimatedSelection.Name = "cbAnimatedSelection"
			Me.cbAnimatedSelection.Size = New System.Drawing.Size(117, 17)
			Me.cbAnimatedSelection.TabIndex = 132
			Me.cbAnimatedSelection.Text = "Animated Selection"
			Me.cbAnimatedSelection.UseVisualStyleBackColor = False
'			Me.cbAnimatedSelection.CheckedChanged += New System.EventHandler(Me.animatedSelectionCheckBox_CheckedChanged)
			' 
			' cbIntegratedScrolling
			' 
			Me.cbIntegratedScrolling.AutoSize = True
			Me.cbIntegratedScrolling.BackColor = System.Drawing.Color.Transparent
			Me.cbIntegratedScrolling.Location = New System.Drawing.Point(13, 84)
			Me.cbIntegratedScrolling.Name = "cbIntegratedScrolling"
			Me.cbIntegratedScrolling.Size = New System.Drawing.Size(114, 17)
			Me.cbIntegratedScrolling.TabIndex = 143
			Me.cbIntegratedScrolling.Text = "IntegratedScrolling"
			Me.cbIntegratedScrolling.UseVisualStyleBackColor = False
'			Me.cbIntegratedScrolling.CheckedChanged += New System.EventHandler(Me.IntegratedScrollingCheckBox_CheckedChanged)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.BackColor = System.Drawing.Color.Transparent
			Me.label3.ForeColor = System.Drawing.Color.Black
			Me.label3.Location = New System.Drawing.Point(13, 122)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(77, 13)
			Me.label3.TabIndex = 141
			Me.label3.Text = "Text Alignment"
			' 
			' cmbTextAlignment
			' 
			Me.cmbTextAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbTextAlignment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.cmbTextAlignment.FormattingEnabled = True
			Me.cmbTextAlignment.Items.AddRange(New Object() { "Left", "Center", "Right"})
			Me.cmbTextAlignment.Location = New System.Drawing.Point(107, 122)
			Me.cmbTextAlignment.Name = "cmbTextAlignment"
			Me.cmbTextAlignment.Size = New System.Drawing.Size(80, 21)
			Me.cmbTextAlignment.TabIndex = 142
'			Me.cmbTextAlignment.SelectedIndexChanged += New System.EventHandler(Me.GBTextAlignmentComboBox_SelectedIndexChanged)
			' 
			' gbVisualStudio
			' 
			Me.gbVisualStudio.AllowDrop = True
			Me.gbVisualStudio.BackColor = System.Drawing.SystemColors.Control
			Me.gbVisualStudio.Controls.Add(Me.WinFormsGroupView)
			Me.gbVisualStudio.Controls.Add(Me.GeneralGroupView)
			Me.gbVisualStudio.Controls.Add(Me.ComponentsGroupView)
			Me.gbVisualStudio.Font = New System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.gbVisualStudio.ForeColor = System.Drawing.Color.Black
			Me.gbVisualStudio.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.WinFormsGroupBarItem, Me.ComponentsGroupBarItem, Me.GeneralGroupBarItem})
			Me.gbVisualStudio.Location = New System.Drawing.Point(28, 45)
			Me.gbVisualStudio.Name = "gbVisualStudio"
			Me.gbVisualStudio.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.gbVisualStudio.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.gbVisualStudio.SelectedItem = 0
			Me.gbVisualStudio.Size = New System.Drawing.Size(230, 324)
			Me.gbVisualStudio.TabIndex = 135
			Me.gbVisualStudio.Text = "groupBar4"
			Me.gbVisualStudio.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			' 
			' WinFormsGroupView
			' 
			Me.WinFormsGroupView.AllowDragAnyObject = True
			Me.WinFormsGroupView.AllowDragDrop = True
			Me.WinFormsGroupView.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(227))))))
			Me.WinFormsGroupView.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.WinFormsGroupView.ButtonView = True
			Me.WinFormsGroupView.FlatLook = True
			Me.WinFormsGroupView.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.WinFormsGroupView.ForeColor = System.Drawing.SystemColors.ControlText
			Me.WinFormsGroupView.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12, True, Nothing, "Label"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13, True, Nothing, "LinkLabel"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 14, True, Nothing, "Button"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 15, True, Nothing, "TextBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 16, True, Nothing, "MainMenu"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 17, True, Nothing, "CheckBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 18, True, Nothing, "RadioButton"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("GroupBox", 19, True, Nothing, "GroupBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("PictureBox", 20, True, Nothing, "PictureBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DataGrid", 21, True, Nothing, "DataGrid"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Chart", 9, True, Nothing, "Chart"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Color Picker", 10, True, Nothing, "Color Picker"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 26, True, Nothing, "MessageQueue")})
			Me.WinFormsGroupView.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(194))))))
			Me.WinFormsGroupView.IntegratedScrolling = True
			Me.WinFormsGroupView.ItemYSpacing = 1
			Me.WinFormsGroupView.LargeImageList = Me.ilGroupBarLarge
			Me.WinFormsGroupView.Location = New System.Drawing.Point(2, 24)
			Me.WinFormsGroupView.Name = "WinFormsGroupView"
			Me.WinFormsGroupView.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(62))))))
			Me.WinFormsGroupView.SelectedItem = 0
			Me.WinFormsGroupView.SelectedItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.WinFormsGroupView.SelectingItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.WinFormsGroupView.Size = New System.Drawing.Size(226, 254)
			Me.WinFormsGroupView.SmallImageList = Me.ilGroupBarSmall
			Me.WinFormsGroupView.SmallImageView = True
			Me.WinFormsGroupView.TabIndex = 4
			Me.WinFormsGroupView.Text = "groupViewControl3"
			' 
			' ilGroupBarLarge
			' 
			Me.ilGroupBarLarge.ImageStream = (CType(resources.GetObject("ilGroupBarLarge.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ilGroupBarLarge.TransparentColor = System.Drawing.Color.Transparent
			Me.ilGroupBarLarge.Images.SetKeyName(0, "")
			Me.ilGroupBarLarge.Images.SetKeyName(1, "")
			Me.ilGroupBarLarge.Images.SetKeyName(2, "")
			Me.ilGroupBarLarge.Images.SetKeyName(3, "")
			Me.ilGroupBarLarge.Images.SetKeyName(4, "")
			Me.ilGroupBarLarge.Images.SetKeyName(5, "")
			Me.ilGroupBarLarge.Images.SetKeyName(6, "")
			Me.ilGroupBarLarge.Images.SetKeyName(7, "")
			Me.ilGroupBarLarge.Images.SetKeyName(8, "")
			Me.ilGroupBarLarge.Images.SetKeyName(9, "")
			Me.ilGroupBarLarge.Images.SetKeyName(10, "")
			Me.ilGroupBarLarge.Images.SetKeyName(11, "")
			Me.ilGroupBarLarge.Images.SetKeyName(12, "")
			Me.ilGroupBarLarge.Images.SetKeyName(13, "")
			Me.ilGroupBarLarge.Images.SetKeyName(14, "")
			Me.ilGroupBarLarge.Images.SetKeyName(15, "")
			Me.ilGroupBarLarge.Images.SetKeyName(16, "")
			Me.ilGroupBarLarge.Images.SetKeyName(17, "")
			Me.ilGroupBarLarge.Images.SetKeyName(18, "")
			Me.ilGroupBarLarge.Images.SetKeyName(19, "")
			Me.ilGroupBarLarge.Images.SetKeyName(20, "")
			Me.ilGroupBarLarge.Images.SetKeyName(21, "")
			Me.ilGroupBarLarge.Images.SetKeyName(22, "")
			Me.ilGroupBarLarge.Images.SetKeyName(23, "")
			Me.ilGroupBarLarge.Images.SetKeyName(24, "")
			Me.ilGroupBarLarge.Images.SetKeyName(25, "")
			Me.ilGroupBarLarge.Images.SetKeyName(26, "")
			Me.ilGroupBarLarge.Images.SetKeyName(27, "")
			' 
			' ilGroupBarSmall
			' 
			Me.ilGroupBarSmall.ImageStream = (CType(resources.GetObject("ilGroupBarSmall.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ilGroupBarSmall.TransparentColor = System.Drawing.Color.Transparent
			Me.ilGroupBarSmall.Images.SetKeyName(0, "")
			Me.ilGroupBarSmall.Images.SetKeyName(1, "")
			Me.ilGroupBarSmall.Images.SetKeyName(2, "")
			Me.ilGroupBarSmall.Images.SetKeyName(3, "")
			Me.ilGroupBarSmall.Images.SetKeyName(4, "")
			Me.ilGroupBarSmall.Images.SetKeyName(5, "")
			Me.ilGroupBarSmall.Images.SetKeyName(6, "")
			Me.ilGroupBarSmall.Images.SetKeyName(7, "")
			Me.ilGroupBarSmall.Images.SetKeyName(8, "")
			Me.ilGroupBarSmall.Images.SetKeyName(9, "")
			Me.ilGroupBarSmall.Images.SetKeyName(10, "")
			Me.ilGroupBarSmall.Images.SetKeyName(11, "")
			Me.ilGroupBarSmall.Images.SetKeyName(12, "")
			Me.ilGroupBarSmall.Images.SetKeyName(13, "")
			Me.ilGroupBarSmall.Images.SetKeyName(14, "")
			Me.ilGroupBarSmall.Images.SetKeyName(15, "")
			Me.ilGroupBarSmall.Images.SetKeyName(16, "")
			Me.ilGroupBarSmall.Images.SetKeyName(17, "")
			Me.ilGroupBarSmall.Images.SetKeyName(18, "")
			Me.ilGroupBarSmall.Images.SetKeyName(19, "")
			Me.ilGroupBarSmall.Images.SetKeyName(20, "")
			Me.ilGroupBarSmall.Images.SetKeyName(21, "")
			Me.ilGroupBarSmall.Images.SetKeyName(22, "")
			Me.ilGroupBarSmall.Images.SetKeyName(23, "")
			Me.ilGroupBarSmall.Images.SetKeyName(24, "")
			Me.ilGroupBarSmall.Images.SetKeyName(25, "")
			Me.ilGroupBarSmall.Images.SetKeyName(26, "")
			Me.ilGroupBarSmall.Images.SetKeyName(27, "")
			Me.ilGroupBarSmall.Images.SetKeyName(28, "")
			Me.ilGroupBarSmall.Images.SetKeyName(29, "")
			Me.ilGroupBarSmall.Images.SetKeyName(30, "")
			Me.ilGroupBarSmall.Images.SetKeyName(31, "")
			' 
			' GeneralGroupView
			' 
			Me.GeneralGroupView.AllowDragDrop = True
			Me.GeneralGroupView.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(227))))))
			Me.GeneralGroupView.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.GeneralGroupView.ButtonView = True
			Me.GeneralGroupView.FlatLook = True
			Me.GeneralGroupView.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.GeneralGroupView.ForeColor = System.Drawing.SystemColors.ControlText
			Me.GeneralGroupView.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Label", 12, True, Nothing, "Label"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("LinkLabel", 13, True, Nothing, "LinkLabel"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Button", 14, True, Nothing, "Button"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("TextBox", 15, True, Nothing, "TextBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MainMenu", 16, True, Nothing, "MainMenu"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("CheckBox", 17, True, Nothing, "CheckBox"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("RadioButton", 18, True, Nothing, "RadioButton")})
			Me.GeneralGroupView.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(194))))))
			Me.GeneralGroupView.HighlightText = False
			Me.GeneralGroupView.ImageSpacing = 5
			Me.GeneralGroupView.IntegratedScrolling = True
			Me.GeneralGroupView.ItemXSpacing = 0
			Me.GeneralGroupView.ItemYSpacing = 0
			Me.GeneralGroupView.LargeImageList = Me.ilGroupBarLarge
			Me.GeneralGroupView.Location = New System.Drawing.Point(2, 68)
			Me.GeneralGroupView.Name = "GeneralGroupView"
			Me.GeneralGroupView.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(62))))))
			Me.GeneralGroupView.SelectedItem = 0
			Me.GeneralGroupView.SelectedItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.GeneralGroupView.SelectingItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.GeneralGroupView.Size = New System.Drawing.Size(0, 0)
			Me.GeneralGroupView.SmallImageList = Me.ilGroupBarSmall
			Me.GeneralGroupView.SmallImageView = True
			Me.GeneralGroupView.TabIndex = 6
			Me.GeneralGroupView.Text = "groupViewControl5"
			' 
			' ComponentsGroupView
			' 
			Me.ComponentsGroupView.AllowDragDrop = True
			Me.ComponentsGroupView.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(223))))), (CInt(Fix((CByte(227))))))
			Me.ComponentsGroupView.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.ComponentsGroupView.ButtonView = True
			Me.ComponentsGroupView.FlatLook = True
			Me.ComponentsGroupView.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ComponentsGroupView.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ComponentsGroupView.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Pointer", 11, True, Nothing, "Pointer"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("FileSystemWatcher", 22, True, Nothing, "FileSystemWatcher"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("EventLog", 23, True, Nothing, "EventLog"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectoryEntry", 24, True, Nothing, "DirectoryEntry"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("DirectorySearcher", 25, True, Nothing, "DirectorySearcher"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("MessageQueue", 26, True, Nothing, "MessageQueue")})
			Me.ComponentsGroupView.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(238))))), (CInt(Fix((CByte(194))))))
			Me.ComponentsGroupView.IntegratedScrolling = True
			Me.ComponentsGroupView.ItemYSpacing = 1
			Me.ComponentsGroupView.LargeImageList = Me.ilGroupBarLarge
			Me.ComponentsGroupView.Location = New System.Drawing.Point(1, 45)
			Me.ComponentsGroupView.Name = "ComponentsGroupView"
			Me.ComponentsGroupView.SelectedHighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(254))))), (CInt(Fix((CByte(128))))), (CInt(Fix((CByte(62))))))
			Me.ComponentsGroupView.SelectedItem = 0
			Me.ComponentsGroupView.SelectedItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.ComponentsGroupView.SelectingItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(111))))))
			Me.ComponentsGroupView.Size = New System.Drawing.Size(228, 0)
			Me.ComponentsGroupView.SmallImageList = Me.ilGroupBarSmall
			Me.ComponentsGroupView.SmallImageView = True
			Me.ComponentsGroupView.TabIndex = 4
			Me.ComponentsGroupView.Text = "groupViewControl4"
			' 
			' WinFormsGroupBarItem
			' 
			Me.WinFormsGroupBarItem.Client = Me.WinFormsGroupView
			Me.WinFormsGroupBarItem.Text = "Windows Forms"
			' 
			' ComponentsGroupBarItem
			' 
			Me.ComponentsGroupBarItem.Client = Me.ComponentsGroupView
			Me.ComponentsGroupBarItem.Text = "Components"
			' 
			' GeneralGroupBarItem
			' 
			Me.GeneralGroupBarItem.Client = Me.GeneralGroupView
			Me.GeneralGroupBarItem.Text = "General"
			' 
			' tabPageOutlook
			' 
			Me.tabPageOutlook.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(247))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(255))))))
			Me.tabPageOutlook.Controls.Add(Me.gradientPanel3)
			Me.tabPageOutlook.Controls.Add(Me.gradientPanel2)
			Me.tabPageOutlook.Controls.Add(Me.gbOutlook)
			Me.tabPageOutlook.Location = New System.Drawing.Point(3, 31)
			Me.tabPageOutlook.Name = "tabPageOutlook"
			Me.tabPageOutlook.Size = New System.Drawing.Size(550, 478)
			Me.tabPageOutlook.TabIndex = 3
			Me.tabPageOutlook.Text = "Outlook GroupBar"
			Me.tabPageOutlook.ThemesEnabled = False
			' 
			' gradientPanel3
			' 
			Me.gradientPanel3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))))
			Me.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(213))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(246))))))
			Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel3.Controls.Add(Me.panel23)
			Me.gradientPanel3.Controls.Add(Me.panel18)
			Me.gradientPanel3.Controls.Add(Me.cbAllowCollapse)
			Me.gradientPanel3.Location = New System.Drawing.Point(319, 251)
			Me.gradientPanel3.Name = "gradientPanel3"
			Me.gradientPanel3.Size = New System.Drawing.Size(220, 210)
			Me.gradientPanel3.TabIndex = 198
			' 
			' panel23
			' 
			Me.panel23.BackColor = System.Drawing.Color.Transparent
			Me.panel23.Controls.Add(Me.label20)
			Me.panel23.Controls.Add(Me.cbCollapse)
			Me.panel23.Controls.Add(Me.label15)
			Me.panel23.Controls.Add(Me.cbAutoClose)
			Me.panel23.Controls.Add(Me.cbShowGripper)
			Me.panel23.Controls.Add(Me.numericCollapsedWidth)
			Me.panel23.Controls.Add(Me.label18)
			Me.panel23.Controls.Add(Me.cmbPopupResize)
			Me.panel23.Location = New System.Drawing.Point(6, 59)
			Me.panel23.Name = "panel23"
			Me.panel23.Size = New System.Drawing.Size(203, 147)
			Me.panel23.TabIndex = 201
			' 
			' label20
			' 
			Me.label20.BackColor = System.Drawing.Color.Transparent
			Me.label20.Image = (CType(resources.GetObject("label20.Image"), System.Drawing.Image))
			Me.label20.Location = New System.Drawing.Point(123, 64)
			Me.label20.Name = "label20"
			Me.label20.Size = New System.Drawing.Size(20, 20)
			Me.label20.TabIndex = 201
			Me.toolTip1.SetToolTip(Me.label20, "Closes the popup automatically when another groupbar item is selected")
			' 
			' cbCollapse
			' 
			Me.cbCollapse.AutoHeight = True
			Me.cbCollapse.BackColor = System.Drawing.Color.Transparent
			Me.cbCollapse.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.cbCollapse.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.cbCollapse.GradientStart = System.Drawing.SystemColors.Control
			Me.cbCollapse.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.cbCollapse.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.cbCollapse.Location = New System.Drawing.Point(3, 4)
			Me.cbCollapse.Name = "cbCollapse"
			Me.cbCollapse.ShadowColor = System.Drawing.Color.Black
			Me.cbCollapse.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.cbCollapse.Size = New System.Drawing.Size(68, 17)
			Me.cbCollapse.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
			Me.cbCollapse.TabIndex = 0
			Me.cbCollapse.Text = "Collapse"
			Me.cbCollapse.ThemesEnabled = False
'			Me.cbCollapse.CheckedChanged += New Syncfusion.Windows.Forms.Tools.CheckedChangedEventHandler(Me.CollapseCheckBoxAdv_CheckedChanged)
			' 
			' label15
			' 
			Me.label15.AutoSize = True
			Me.label15.BackColor = System.Drawing.Color.Transparent
			Me.label15.Location = New System.Drawing.Point(3, 120)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(103, 13)
			Me.label15.TabIndex = 5
			Me.label15.Text = "Popup Resize Mode"
			' 
			' cbAutoClose
			' 
			Me.cbAutoClose.AutoHeight = True
			Me.cbAutoClose.BackColor = System.Drawing.Color.Transparent
			Me.cbAutoClose.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.cbAutoClose.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.cbAutoClose.GradientStart = System.Drawing.SystemColors.Control
			Me.cbAutoClose.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.cbAutoClose.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.cbAutoClose.Location = New System.Drawing.Point(3, 64)
			Me.cbAutoClose.Name = "cbAutoClose"
			Me.cbAutoClose.ShadowColor = System.Drawing.Color.Black
			Me.cbAutoClose.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.cbAutoClose.Size = New System.Drawing.Size(114, 17)
			Me.cbAutoClose.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
			Me.cbAutoClose.TabIndex = 11
			Me.cbAutoClose.Text = "Popup Auto Close"
			Me.cbAutoClose.ThemesEnabled = False
'			Me.cbAutoClose.CheckedChanged += New Syncfusion.Windows.Forms.Tools.CheckedChangedEventHandler(Me.checkBoxAdvAutoClose_CheckedChanged)
			' 
			' cbShowGripper
			' 
			Me.cbShowGripper.AutoHeight = True
			Me.cbShowGripper.BackColor = System.Drawing.Color.Transparent
			Me.cbShowGripper.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.cbShowGripper.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.cbShowGripper.GradientStart = System.Drawing.SystemColors.Control
			Me.cbShowGripper.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.cbShowGripper.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.cbShowGripper.Location = New System.Drawing.Point(3, 34)
			Me.cbShowGripper.Name = "cbShowGripper"
			Me.cbShowGripper.ShadowColor = System.Drawing.Color.Black
			Me.cbShowGripper.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.cbShowGripper.Size = New System.Drawing.Size(111, 17)
			Me.cbShowGripper.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
			Me.cbShowGripper.TabIndex = 1
			Me.cbShowGripper.Text = "Show Popup Gripper"
			Me.cbShowGripper.ThemesEnabled = False
'			Me.cbShowGripper.CheckedChanged += New Syncfusion.Windows.Forms.Tools.CheckedChangedEventHandler(Me.checkBoxAdvGripper_CheckedChanged)
			' 
			' numericCollapsedWidth
			' 
			Me.numericCollapsedWidth.Increment = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.numericCollapsedWidth.Location = New System.Drawing.Point(112, 94)
			Me.numericCollapsedWidth.Maximum = New Decimal(New Integer() { 80, 0, 0, 0})
			Me.numericCollapsedWidth.Minimum = New Decimal(New Integer() { 32, 0, 0, 0})
			Me.numericCollapsedWidth.Name = "numericCollapsedWidth"
			Me.numericCollapsedWidth.Size = New System.Drawing.Size(82, 20)
			Me.numericCollapsedWidth.TabIndex = 8
			Me.numericCollapsedWidth.Value = New Decimal(New Integer() { 32, 0, 0, 0})
'			Me.numericCollapsedWidth.ValueChanged += New System.EventHandler(Me.CollapsedWidthNumericUpDown_ValueChanged)
			' 
			' label18
			' 
			Me.label18.AutoSize = True
			Me.label18.BackColor = System.Drawing.Color.Transparent
			Me.label18.Location = New System.Drawing.Point(3, 94)
			Me.label18.Name = "label18"
			Me.label18.Size = New System.Drawing.Size(84, 13)
			Me.label18.TabIndex = 7
			Me.label18.Text = "Collapsed Width"
			' 
			' cmbPopupResize
			' 
			Me.cmbPopupResize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbPopupResize.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.cmbPopupResize.FormattingEnabled = True
			Me.cmbPopupResize.Items.AddRange(New Object() { "Both", "Horizontal", "None", "Vertical"})
			Me.cmbPopupResize.Location = New System.Drawing.Point(112, 120)
			Me.cmbPopupResize.Name = "cmbPopupResize"
			Me.cmbPopupResize.Size = New System.Drawing.Size(82, 21)
			Me.cmbPopupResize.TabIndex = 16
'			Me.cmbPopupResize.SelectedIndexChanged += New System.EventHandler(Me.PopupResizeComboBox_SelectedIndexChanged)
			' 
			' panel18
			' 
			Me.panel18.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(254))))))
			Me.panel18.Controls.Add(Me.label28)
			Me.panel18.Controls.Add(Me.label29)
			Me.panel18.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel18.Location = New System.Drawing.Point(0, 0)
			Me.panel18.Name = "panel18"
			Me.panel18.Size = New System.Drawing.Size(218, 27)
			Me.panel18.TabIndex = 157
			' 
			' label28
			' 
			Me.label28.BackColor = System.Drawing.Color.White
			Me.label28.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.label28.Location = New System.Drawing.Point(0, 25)
			Me.label28.Name = "label28"
			Me.label28.Size = New System.Drawing.Size(218, 2)
			Me.label28.TabIndex = 139
			' 
			' label29
			' 
			Me.label29.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label29.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label29.Image = (CType(resources.GetObject("label29.Image"), System.Drawing.Image))
			Me.label29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label29.Location = New System.Drawing.Point(4, 4)
			Me.label29.Name = "label29"
			Me.label29.Size = New System.Drawing.Size(175, 18)
			Me.label29.TabIndex = 170
			Me.label29.Text = "Collapse Mode Properties"
			Me.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' cbAllowCollapse
			' 
			Me.cbAllowCollapse.AutoHeight = True
			Me.cbAllowCollapse.BackColor = System.Drawing.Color.Transparent
			Me.cbAllowCollapse.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.cbAllowCollapse.Checked = True
			Me.cbAllowCollapse.CheckState = System.Windows.Forms.CheckState.Checked
			Me.cbAllowCollapse.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.cbAllowCollapse.GradientStart = System.Drawing.SystemColors.Control
			Me.cbAllowCollapse.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.cbAllowCollapse.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.cbAllowCollapse.Location = New System.Drawing.Point(10, 35)
			Me.cbAllowCollapse.Name = "cbAllowCollapse"
			Me.cbAllowCollapse.ShadowColor = System.Drawing.Color.Black
			Me.cbAllowCollapse.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.cbAllowCollapse.Size = New System.Drawing.Size(95, 17)
			Me.cbAllowCollapse.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007
			Me.cbAllowCollapse.TabIndex = 22
			Me.cbAllowCollapse.Text = "AllowCollapse"
			Me.cbAllowCollapse.ThemesEnabled = False
'			Me.cbAllowCollapse.CheckedChanged += New Syncfusion.Windows.Forms.Tools.CheckedChangedEventHandler(Me.AllowCollapseCheckBoxAdv_CheckedChanged)
			' 
			' gradientPanel2
			' 
			Me.gradientPanel2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))))
			Me.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(213))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(246))))))
			Me.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel2.Controls.Add(Me.panel25)
			Me.gradientPanel2.Controls.Add(Me.panel17)
			Me.gradientPanel2.Controls.Add(Me.cbStackedMode)
			Me.gradientPanel2.Controls.Add(Me.label25)
			Me.gradientPanel2.Controls.Add(Me.cmbOutLookGBStyle)
			Me.gradientPanel2.Controls.Add(Me.label26)
			Me.gradientPanel2.Controls.Add(Me.cmbOutLookGBColorScheme)
			Me.gradientPanel2.Location = New System.Drawing.Point(320, 27)
			Me.gradientPanel2.Name = "gradientPanel2"
			Me.gradientPanel2.Size = New System.Drawing.Size(220, 210)
			Me.gradientPanel2.TabIndex = 197
			' 
			' panel25
			' 
			Me.panel25.BackColor = System.Drawing.Color.Transparent
			Me.panel25.Controls.Add(Me.cbChevron)
			Me.panel25.Controls.Add(Me.cbImageInHeader)
			Me.panel25.Location = New System.Drawing.Point(1, 63)
			Me.panel25.Name = "panel25"
			Me.panel25.Size = New System.Drawing.Size(186, 60)
			Me.panel25.TabIndex = 201
			' 
			' cbChevron
			' 
			Me.cbChevron.AutoSize = True
			Me.cbChevron.BackColor = System.Drawing.Color.Transparent
			Me.cbChevron.Checked = True
			Me.cbChevron.CheckState = System.Windows.Forms.CheckState.Checked
			Me.cbChevron.Location = New System.Drawing.Point(10, 6)
			Me.cbChevron.Name = "cbChevron"
			Me.cbChevron.Size = New System.Drawing.Size(96, 17)
			Me.cbChevron.TabIndex = 134
			Me.cbChevron.Text = "Show Chevron"
			Me.cbChevron.UseVisualStyleBackColor = False
'			Me.cbChevron.CheckedChanged += New System.EventHandler(Me.ChevronCheckBox_CheckedChanged)
			' 
			' cbImageInHeader
			' 
			Me.cbImageInHeader.AutoSize = True
			Me.cbImageInHeader.BackColor = System.Drawing.Color.Transparent
			Me.cbImageInHeader.Location = New System.Drawing.Point(10, 36)
			Me.cbImageInHeader.Name = "cbImageInHeader"
			Me.cbImageInHeader.Size = New System.Drawing.Size(157, 17)
			Me.cbImageInHeader.TabIndex = 136
			Me.cbImageInHeader.Text = "Show Item Image in Header"
			Me.cbImageInHeader.UseVisualStyleBackColor = False
'			Me.cbImageInHeader.CheckedChanged += New System.EventHandler(Me.ImageInHeaderCheckBox_CheckedChanged)
			' 
			' panel17
			' 
			Me.panel17.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(254))))))
			Me.panel17.Controls.Add(Me.label23)
			Me.panel17.Controls.Add(Me.label27)
			Me.panel17.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel17.Location = New System.Drawing.Point(0, 0)
			Me.panel17.Name = "panel17"
			Me.panel17.Size = New System.Drawing.Size(218, 27)
			Me.panel17.TabIndex = 157
			' 
			' label23
			' 
			Me.label23.BackColor = System.Drawing.Color.White
			Me.label23.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.label23.Location = New System.Drawing.Point(0, 25)
			Me.label23.Name = "label23"
			Me.label23.Size = New System.Drawing.Size(218, 2)
			Me.label23.TabIndex = 139
			' 
			' label27
			' 
			Me.label27.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label27.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label27.Image = (CType(resources.GetObject("label27.Image"), System.Drawing.Image))
			Me.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label27.Location = New System.Drawing.Point(10, 1)
			Me.label27.Name = "label27"
			Me.label27.Size = New System.Drawing.Size(144, 21)
			Me.label27.TabIndex = 170
			Me.label27.Text = "GroupBar Properties"
			Me.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' cbStackedMode
			' 
			Me.cbStackedMode.AutoSize = True
			Me.cbStackedMode.BackColor = System.Drawing.Color.Transparent
			Me.cbStackedMode.Checked = True
			Me.cbStackedMode.CheckState = System.Windows.Forms.CheckState.Checked
			Me.cbStackedMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbStackedMode.Location = New System.Drawing.Point(10, 39)
			Me.cbStackedMode.Name = "cbStackedMode"
			Me.cbStackedMode.Size = New System.Drawing.Size(132, 17)
			Me.cbStackedMode.TabIndex = 137
			Me.cbStackedMode.Text = "Enable Stacked Mode"
			Me.cbStackedMode.UseVisualStyleBackColor = False
'			Me.cbStackedMode.CheckedChanged += New System.EventHandler(Me.StackedModeCheckBox_CheckedChanged)
			' 
			' label25
			' 
			Me.label25.AutoSize = True
			Me.label25.BackColor = System.Drawing.Color.Transparent
			Me.label25.ForeColor = System.Drawing.Color.Black
			Me.label25.Location = New System.Drawing.Point(10, 129)
			Me.label25.Name = "label25"
			Me.label25.Size = New System.Drawing.Size(66, 13)
			Me.label25.TabIndex = 141
			Me.label25.Text = "Visual Styles"
			' 
			' cmbOutLookGBStyle
			' 
			Me.cmbOutLookGBStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbOutLookGBStyle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.cmbOutLookGBStyle.FormattingEnabled = True
			Me.cmbOutLookGBStyle.Items.AddRange(New Object() { "Default", "Office2003", "Office2007"})
			Me.cmbOutLookGBStyle.Location = New System.Drawing.Point(106, 129)
			Me.cmbOutLookGBStyle.Name = "cmbOutLookGBStyle"
			Me.cmbOutLookGBStyle.Size = New System.Drawing.Size(82, 21)
			Me.cmbOutLookGBStyle.TabIndex = 142
'			Me.cmbOutLookGBStyle.SelectedIndexChanged += New System.EventHandler(Me.OutLookGBStyleComboBox_SelectedIndexChanged)
			' 
			' label26
			' 
			Me.label26.AutoSize = True
			Me.label26.BackColor = System.Drawing.Color.Transparent
			Me.label26.ForeColor = System.Drawing.Color.Black
			Me.label26.Location = New System.Drawing.Point(10, 159)
			Me.label26.Name = "label26"
			Me.label26.Size = New System.Drawing.Size(75, 13)
			Me.label26.TabIndex = 143
			Me.label26.Text = "ColorSchemes"
			' 
			' cmbOutLookGBColorScheme
			' 
			Me.cmbOutLookGBColorScheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.cmbOutLookGBColorScheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup
			Me.cmbOutLookGBColorScheme.FormattingEnabled = True
			Me.cmbOutLookGBColorScheme.Items.AddRange(New Object() { "Blue", "Silver", "Black"})
			Me.cmbOutLookGBColorScheme.Location = New System.Drawing.Point(106, 159)
			Me.cmbOutLookGBColorScheme.Name = "cmbOutLookGBColorScheme"
			Me.cmbOutLookGBColorScheme.Size = New System.Drawing.Size(82, 21)
			Me.cmbOutLookGBColorScheme.TabIndex = 144
'			Me.cmbOutLookGBColorScheme.SelectedIndexChanged += New System.EventHandler(Me.OutLookGBColorSchemeComboBox_SelectedIndexChanged)
			' 
			' gbOutlook
			' 
			Me.gbOutlook.AllowCollapse = True
			Me.gbOutlook.AllowDrop = True
			Me.gbOutlook.AnimatedSelection = False
			Me.gbOutlook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gbOutlook.Controls.Add(Me.xpTaskBar1)
			Me.gbOutlook.Controls.Add(Me.xpTaskBar6)
			Me.gbOutlook.Controls.Add(Me.xpTaskBar4)
			Me.gbOutlook.Controls.Add(Me.xpTaskBar2)
			Me.gbOutlook.Controls.Add(Me.xpTaskBar3)
			Me.gbOutlook.Controls.Add(Me.calendarPanel)
			Me.gbOutlook.Controls.Add(Me.xpTaskBar5)
			Me.gbOutlook.Dock = System.Windows.Forms.DockStyle.Left
			Me.gbOutlook.Font = New System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold)
			Me.gbOutlook.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.gbOutlook.GroupBarItemHeight = 34
			Me.gbOutlook.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.MailGgroupBarItem, Me.ContactsGroupBarItem, Me.TasksGroupBarItem, Me.NotesgroupBarItem, Me.FolderListGroupBarItem, Me.CalendarGroupBarItem, Me.JournalGroupBarItem})
			Me.gbOutlook.HeaderBackColor = System.Drawing.SystemColors.Control
			Me.gbOutlook.HeaderForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(16))))), (CInt(Fix((CByte(65))))), (CInt(Fix((CByte(140))))))
			Me.gbOutlook.Location = New System.Drawing.Point(0, 0)
			Me.gbOutlook.Name = "gbOutlook"
			Me.gbOutlook.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.gbOutlook.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.gbOutlook.SelectedItem = 0
			Me.gbOutlook.Size = New System.Drawing.Size(245, 478)
			Me.gbOutlook.StackedMode = True
			Me.gbOutlook.TabIndex = 0
			Me.gbOutlook.Text = "groupBar1"
			Me.gbOutlook.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.gbOutlook.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
'			Me.gbOutlook.StateChanged += New System.EventHandler(Me.gbOutlook_StateChanged)
			' 
			' xpTaskBar1
			' 
			Me.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox1)
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox2)
			Me.xpTaskBar1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.xpTaskBar1.ForeColor = System.Drawing.Color.Black
			Me.xpTaskBar1.Location = New System.Drawing.Point(1, 27)
			Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar1.Name = "xpTaskBar1"
			Me.xpTaskBar1.Size = New System.Drawing.Size(243, 276)
			Me.xpTaskBar1.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
			Me.xpTaskBar1.TabIndex = 0
			Me.xpTaskBar1.VerticalPadding = 1
			' 
			' xpTaskBarBox1
			' 
			Me.xpTaskBarBox1.Controls.Add(Me.panel1)
			Me.xpTaskBarBox1.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox1.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.xpTaskBarBox1.HeaderImageIndex = -1
			Me.xpTaskBarBox1.HitTaskBoxArea = False
			Me.xpTaskBarBox1.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
			Me.xpTaskBarBox1.PreferredChildPanelHeight = 100
			Me.xpTaskBarBox1.Size = New System.Drawing.Size(241, 124)
			Me.xpTaskBarBox1.TabIndex = 0
			Me.xpTaskBarBox1.Text = "Favorite Folders"
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.listView3)
			Me.panel1.Location = New System.Drawing.Point(2, 22)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(237, 100)
			Me.panel1.TabIndex = 0
			' 
			' listView3
			' 
			Me.listView3.Alignment = System.Windows.Forms.ListViewAlignment.Left
			Me.listView3.AutoArrange = False
			Me.listView3.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.listView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.columnHeader3})
			Me.listView3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listView3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.listView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
			Me.listView3.HideSelection = False
			Me.listView3.Items.AddRange(New System.Windows.Forms.ListViewItem() { listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12})
			Me.listView3.LargeImageList = Me.smallImageList
			Me.listView3.Location = New System.Drawing.Point(0, 0)
			Me.listView3.MultiSelect = False
			Me.listView3.Name = "listView3"
			Me.listView3.Size = New System.Drawing.Size(237, 100)
			Me.listView3.SmallImageList = Me.smallImageList
			Me.listView3.TabIndex = 21
			Me.listView3.UseCompatibleStateImageBehavior = False
			Me.listView3.View = System.Windows.Forms.View.Details
			' 
			' columnHeader3
			' 
			Me.columnHeader3.Width = 150
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
			' 
			' xpTaskBarBox2
			' 
			Me.xpTaskBarBox2.Controls.Add(Me.panel2)
			Me.xpTaskBarBox2.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.xpTaskBarBox2.HeaderImageIndex = -1
			Me.xpTaskBarBox2.HitTaskBoxArea = False
			Me.xpTaskBarBox2.Location = New System.Drawing.Point(0, 125)
			Me.xpTaskBarBox2.Name = "xpTaskBarBox2"
			Me.xpTaskBarBox2.PreferredChildPanelHeight = 125
			Me.xpTaskBarBox2.Size = New System.Drawing.Size(241, 149)
			Me.xpTaskBarBox2.TabIndex = 1
			Me.xpTaskBarBox2.Text = "Mail Folders"
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.treeView3)
			Me.panel2.Location = New System.Drawing.Point(2, 22)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(237, 125)
			Me.panel2.TabIndex = 0
			' 
			' treeView3
			' 
			Me.treeView3.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.treeView3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeView3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.treeView3.ImageIndex = 0
			Me.treeView3.ImageList = Me.smallImageList
			Me.treeView3.Indent = 25
			Me.treeView3.Location = New System.Drawing.Point(0, 0)
			Me.treeView3.Name = "treeView3"
			treeNode41.ImageIndex = 1
			treeNode41.Name = ""
			treeNode41.SelectedImageIndex = 1
			treeNode41.Text = "Deleted Items"
			treeNode42.ImageIndex = 0
			treeNode42.Name = ""
			treeNode42.SelectedImageIndex = 0
			treeNode42.Text = "Junk Email"
			treeNode43.ImageIndex = 2
			treeNode43.Name = ""
			treeNode43.SelectedImageIndex = 2
			treeNode43.Text = "InBox"
			treeNode44.ImageIndex = 6
			treeNode44.Name = ""
			treeNode44.SelectedImageIndex = 6
			treeNode44.Text = "Sent Items"
			treeNode45.ImageIndex = 4
			treeNode45.Name = ""
			treeNode45.SelectedImageIndex = 4
			treeNode45.Text = "Search Folders"
			treeNode46.ImageIndex = 7
			treeNode46.Name = ""
			treeNode46.SelectedImageIndex = 7
			treeNode46.Text = "Personal Folders"
			treeNode47.ImageIndex = 4
			treeNode47.Name = ""
			treeNode47.SelectedImageIndex = 4
			treeNode47.Text = "Search Folders"
			treeNode48.ImageIndex = 6
			treeNode48.Name = ""
			treeNode48.SelectedImageIndex = 6
			treeNode48.Text = "Sent Items"
			treeNode49.ImageIndex = 1
			treeNode49.Name = ""
			treeNode49.SelectedImageIndex = 1
			treeNode49.Text = "Deleted Items"
			treeNode50.ImageIndex = 8
			treeNode50.Name = ""
			treeNode50.SelectedImageIndex = 8
			treeNode50.Text = "Archive Folders"
			treeNode51.ImageIndex = 5
			treeNode51.Name = ""
			treeNode51.SelectedImageIndex = 5
			treeNode51.Text = "Drafts"
			treeNode52.ImageIndex = 2
			treeNode52.Name = ""
			treeNode52.SelectedImageIndex = 2
			treeNode52.Text = "InBox"
			treeNode53.ImageIndex = 3
			treeNode53.Name = ""
			treeNode53.SelectedImageIndex = 3
			treeNode53.Text = "OutBox"
			treeNode54.ImageIndex = 6
			treeNode54.Name = ""
			treeNode54.SelectedImageIndex = 6
			treeNode54.Text = "Sent Items"
			treeNode55.Name = ""
			treeNode55.Text = "Public"
			treeNode56.ImageIndex = 8
			treeNode56.Name = ""
			treeNode56.SelectedImageIndex = 8
			treeNode56.Text = "Syncfusion Email"
			Me.treeView3.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode46, treeNode50, treeNode56})
			Me.treeView3.SelectedImageIndex = 0
			Me.treeView3.ShowLines = False
			Me.treeView3.Size = New System.Drawing.Size(237, 125)
			Me.treeView3.TabIndex = 4
			' 
			' xpTaskBar6
			' 
			Me.xpTaskBar6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.xpTaskBar6.Controls.Add(Me.xpTaskBarBox10)
			Me.xpTaskBar6.Controls.Add(Me.xpTaskBarBox11)
			Me.xpTaskBar6.Location = New System.Drawing.Point(1, 239)
			Me.xpTaskBar6.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar6.Name = "xpTaskBar6"
			Me.xpTaskBar6.Size = New System.Drawing.Size(0, 0)
			Me.xpTaskBar6.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
			Me.xpTaskBar6.TabIndex = 8
			Me.xpTaskBar6.VerticalPadding = 1
			' 
			' xpTaskBarBox10
			' 
			Me.xpTaskBarBox10.Controls.Add(Me.panel8)
			Me.xpTaskBarBox10.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox10.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.xpTaskBarBox10.HeaderForeColor = System.Drawing.Color.Black
			Me.xpTaskBarBox10.HeaderImageIndex = -1
			Me.xpTaskBarBox10.HitTaskBoxArea = False
			Me.xpTaskBarBox10.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox10.Name = "xpTaskBarBox10"
			Me.xpTaskBarBox10.Size = New System.Drawing.Size(0, 54)
			Me.xpTaskBarBox10.TabIndex = 0
			Me.xpTaskBarBox10.Text = "My Journal"
			' 
			' panel8
			' 
			Me.panel8.Controls.Add(Me.label16)
			Me.panel8.Location = New System.Drawing.Point(2, 22)
			Me.panel8.Name = "panel8"
			Me.panel8.Size = New System.Drawing.Size(0, 30)
			Me.panel8.TabIndex = 0
			' 
			' label16
			' 
			Me.label16.Dock = System.Windows.Forms.DockStyle.Left
			Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label16.ImageIndex = 13
			Me.label16.ImageList = Me.smallImageList
			Me.label16.Location = New System.Drawing.Point(0, 0)
			Me.label16.Name = "label16"
			Me.label16.Size = New System.Drawing.Size(89, 30)
			Me.label16.TabIndex = 5
			Me.label16.Text = "Journal"
			Me.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' xpTaskBarBox11
			' 
			Me.xpTaskBarBox11.Controls.Add(Me.panel11)
			Me.xpTaskBarBox11.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox11.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.xpTaskBarBox11.HeaderImageIndex = -1
			Me.xpTaskBarBox11.HitTaskBoxArea = False
			Me.xpTaskBarBox11.Location = New System.Drawing.Point(0, 55)
			Me.xpTaskBarBox11.Name = "xpTaskBarBox11"
			Me.xpTaskBarBox11.PreferredChildPanelHeight = 130
			Me.xpTaskBarBox11.Size = New System.Drawing.Size(0, 154)
			Me.xpTaskBarBox11.TabIndex = 1
			Me.xpTaskBarBox11.Text = "Current View"
			' 
			' panel11
			' 
			Me.panel11.Controls.Add(Me.panel14)
			Me.panel11.Location = New System.Drawing.Point(2, 22)
			Me.panel11.Name = "panel11"
			Me.panel11.Size = New System.Drawing.Size(0, 130)
			Me.panel11.TabIndex = 0
			' 
			' panel14
			' 
			Me.panel14.BackColor = System.Drawing.Color.White
			Me.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel14.Controls.Add(Me.radioButton23)
			Me.panel14.Controls.Add(Me.radioButton24)
			Me.panel14.Controls.Add(Me.radioButton25)
			Me.panel14.Controls.Add(Me.radioButton26)
			Me.panel14.Controls.Add(Me.radioButton27)
			Me.panel14.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel14.Location = New System.Drawing.Point(0, 0)
			Me.panel14.Name = "panel14"
			Me.panel14.Size = New System.Drawing.Size(0, 130)
			Me.panel14.TabIndex = 7
			' 
			' radioButton23
			' 
			Me.radioButton23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton23.Location = New System.Drawing.Point(16, 104)
			Me.radioButton23.Name = "radioButton23"
			Me.radioButton23.Size = New System.Drawing.Size(176, 24)
			Me.radioButton23.TabIndex = 4
			Me.radioButton23.Text = "Phone Calls"
			' 
			' radioButton24
			' 
			Me.radioButton24.BackColor = System.Drawing.SystemColors.Window
			Me.radioButton24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton24.Location = New System.Drawing.Point(16, 80)
			Me.radioButton24.Name = "radioButton24"
			Me.radioButton24.Size = New System.Drawing.Size(176, 24)
			Me.radioButton24.TabIndex = 3
			Me.radioButton24.Text = "Entry List"
			Me.radioButton24.UseVisualStyleBackColor = False
			' 
			' radioButton25
			' 
			Me.radioButton25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton25.Location = New System.Drawing.Point(16, 56)
			Me.radioButton25.Name = "radioButton25"
			Me.radioButton25.Size = New System.Drawing.Size(176, 24)
			Me.radioButton25.TabIndex = 2
			Me.radioButton25.Text = "By Category"
			' 
			' radioButton26
			' 
			Me.radioButton26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton26.Location = New System.Drawing.Point(16, 32)
			Me.radioButton26.Name = "radioButton26"
			Me.radioButton26.Size = New System.Drawing.Size(176, 24)
			Me.radioButton26.TabIndex = 1
			Me.radioButton26.Text = "By Contact"
			' 
			' radioButton27
			' 
			Me.radioButton27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton27.Location = New System.Drawing.Point(16, 8)
			Me.radioButton27.Name = "radioButton27"
			Me.radioButton27.Size = New System.Drawing.Size(176, 24)
			Me.radioButton27.TabIndex = 0
			Me.radioButton27.Text = "By Type"
			' 
			' xpTaskBar4
			' 
			Me.xpTaskBar4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.xpTaskBar4.Controls.Add(Me.xpTaskBarBox7)
			Me.xpTaskBar4.Controls.Add(Me.xpTaskBarBox8)
			Me.xpTaskBar4.Location = New System.Drawing.Point(1, 27)
			Me.xpTaskBar4.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar4.Name = "xpTaskBar4"
			Me.xpTaskBar4.Size = New System.Drawing.Size(243, 280)
			Me.xpTaskBar4.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
			Me.xpTaskBar4.TabIndex = 6
			Me.xpTaskBar4.VerticalPadding = 1
			' 
			' xpTaskBarBox7
			' 
			Me.xpTaskBarBox7.Controls.Add(Me.panel6)
			Me.xpTaskBarBox7.Font = New System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.xpTaskBarBox7.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox7.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox7.HeaderImageIndex = -1
			Me.xpTaskBarBox7.HitTaskBoxArea = False
			Me.xpTaskBarBox7.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox7.Name = "xpTaskBarBox7"
			Me.xpTaskBarBox7.Size = New System.Drawing.Size(241, 54)
			Me.xpTaskBarBox7.TabIndex = 0
			Me.xpTaskBarBox7.Text = "My Notes"
			' 
			' panel6
			' 
			Me.panel6.Controls.Add(Me.label14)
			Me.panel6.Location = New System.Drawing.Point(2, 22)
			Me.panel6.Name = "panel6"
			Me.panel6.Size = New System.Drawing.Size(237, 30)
			Me.panel6.TabIndex = 0
			' 
			' label14
			' 
			Me.label14.Dock = System.Windows.Forms.DockStyle.Left
			Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label14.ImageIndex = 11
			Me.label14.ImageList = Me.smallImageList
			Me.label14.Location = New System.Drawing.Point(0, 0)
			Me.label14.Name = "label14"
			Me.label14.Size = New System.Drawing.Size(83, 30)
			Me.label14.TabIndex = 5
			Me.label14.Text = "Notes"
			Me.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' xpTaskBarBox8
			' 
			Me.xpTaskBarBox8.Controls.Add(Me.panel9)
			Me.xpTaskBarBox8.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox8.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox8.HeaderImageIndex = -1
			Me.xpTaskBarBox8.HitTaskBoxArea = False
			Me.xpTaskBarBox8.Location = New System.Drawing.Point(0, 55)
			Me.xpTaskBarBox8.Name = "xpTaskBarBox8"
			Me.xpTaskBarBox8.PreferredChildPanelHeight = 125
			Me.xpTaskBarBox8.Size = New System.Drawing.Size(241, 149)
			Me.xpTaskBarBox8.TabIndex = 1
			Me.xpTaskBarBox8.Text = "Current View"
			' 
			' panel9
			' 
			Me.panel9.BackColor = System.Drawing.Color.White
			Me.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel9.Controls.Add(Me.radioButton18)
			Me.panel9.Controls.Add(Me.radioButton19)
			Me.panel9.Controls.Add(Me.radioButton20)
			Me.panel9.Controls.Add(Me.radioButton21)
			Me.panel9.Controls.Add(Me.radioButton22)
			Me.panel9.Location = New System.Drawing.Point(2, 22)
			Me.panel9.Name = "panel9"
			Me.panel9.Size = New System.Drawing.Size(237, 125)
			Me.panel9.TabIndex = 21
			' 
			' radioButton18
			' 
			Me.radioButton18.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton18.Location = New System.Drawing.Point(16, 104)
			Me.radioButton18.Name = "radioButton18"
			Me.radioButton18.Size = New System.Drawing.Size(176, 24)
			Me.radioButton18.TabIndex = 4
			Me.radioButton18.Text = "By Color"
			' 
			' radioButton19
			' 
			Me.radioButton19.BackColor = System.Drawing.SystemColors.Window
			Me.radioButton19.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton19.Location = New System.Drawing.Point(16, 80)
			Me.radioButton19.Name = "radioButton19"
			Me.radioButton19.Size = New System.Drawing.Size(176, 24)
			Me.radioButton19.TabIndex = 3
			Me.radioButton19.Text = "By Category"
			Me.radioButton19.UseVisualStyleBackColor = False
			' 
			' radioButton20
			' 
			Me.radioButton20.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton20.Location = New System.Drawing.Point(16, 56)
			Me.radioButton20.Name = "radioButton20"
			Me.radioButton20.Size = New System.Drawing.Size(176, 24)
			Me.radioButton20.TabIndex = 2
			Me.radioButton20.Text = "Last Seven Days"
			' 
			' radioButton21
			' 
			Me.radioButton21.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton21.Location = New System.Drawing.Point(16, 32)
			Me.radioButton21.Name = "radioButton21"
			Me.radioButton21.Size = New System.Drawing.Size(176, 24)
			Me.radioButton21.TabIndex = 1
			Me.radioButton21.Text = "Notes List"
			' 
			' radioButton22
			' 
			Me.radioButton22.Checked = True
			Me.radioButton22.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton22.Location = New System.Drawing.Point(16, 8)
			Me.radioButton22.Name = "radioButton22"
			Me.radioButton22.Size = New System.Drawing.Size(176, 24)
			Me.radioButton22.TabIndex = 0
			Me.radioButton22.TabStop = True
			Me.radioButton22.Text = "Icons"
			' 
			' xpTaskBar2
			' 
			Me.xpTaskBar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.xpTaskBar2.Controls.Add(Me.xpTaskBarBox3)
			Me.xpTaskBar2.Controls.Add(Me.xpTaskBarBox4)
			Me.xpTaskBar2.Location = New System.Drawing.Point(1, 27)
			Me.xpTaskBar2.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar2.Name = "xpTaskBar2"
			Me.xpTaskBar2.Size = New System.Drawing.Size(243, 280)
			Me.xpTaskBar2.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
			Me.xpTaskBar2.TabIndex = 4
			Me.xpTaskBar2.VerticalPadding = 1
			' 
			' xpTaskBarBox3
			' 
			Me.xpTaskBarBox3.Controls.Add(Me.panel4)
			Me.xpTaskBarBox3.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox3.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.xpTaskBarBox3.HeaderImageIndex = -1
			Me.xpTaskBarBox3.HitTaskBoxArea = False
			Me.xpTaskBarBox3.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox3.Name = "xpTaskBarBox3"
			Me.xpTaskBarBox3.Size = New System.Drawing.Size(241, 54)
			Me.xpTaskBarBox3.TabIndex = 0
			Me.xpTaskBarBox3.Text = "My Tasks"
			' 
			' panel4
			' 
			Me.panel4.Controls.Add(Me.label9)
			Me.panel4.Location = New System.Drawing.Point(2, 22)
			Me.panel4.Name = "panel4"
			Me.panel4.Size = New System.Drawing.Size(237, 30)
			Me.panel4.TabIndex = 0
			' 
			' label9
			' 
			Me.label9.Dock = System.Windows.Forms.DockStyle.Left
			Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.label9.ForeColor = System.Drawing.Color.Black
			Me.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label9.ImageIndex = 10
			Me.label9.ImageList = Me.smallImageList
			Me.label9.Location = New System.Drawing.Point(0, 0)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(80, 30)
			Me.label9.TabIndex = 5
			Me.label9.Text = "Tasks"
			Me.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' xpTaskBarBox4
			' 
			Me.xpTaskBarBox4.Controls.Add(Me.panel7)
			Me.xpTaskBarBox4.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox4.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.xpTaskBarBox4.HeaderImageIndex = -1
			Me.xpTaskBarBox4.HitTaskBoxArea = False
			Me.xpTaskBarBox4.Location = New System.Drawing.Point(0, 55)
			Me.xpTaskBarBox4.Name = "xpTaskBarBox4"
			Me.xpTaskBarBox4.PreferredChildPanelHeight = 125
			Me.xpTaskBarBox4.Size = New System.Drawing.Size(241, 149)
			Me.xpTaskBarBox4.TabIndex = 1
			Me.xpTaskBarBox4.Text = "CurrentView"
			' 
			' panel7
			' 
			Me.panel7.BackColor = System.Drawing.Color.White
			Me.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel7.Controls.Add(Me.radioButton12)
			Me.panel7.Controls.Add(Me.radioButton11)
			Me.panel7.Controls.Add(Me.radioButton6)
			Me.panel7.Controls.Add(Me.radioButton7)
			Me.panel7.Controls.Add(Me.radioButton8)
			Me.panel7.Controls.Add(Me.radioButton9)
			Me.panel7.Controls.Add(Me.radioButton10)
			Me.panel7.Location = New System.Drawing.Point(2, 22)
			Me.panel7.Name = "panel7"
			Me.panel7.Size = New System.Drawing.Size(237, 125)
			Me.panel7.TabIndex = 7
			' 
			' radioButton12
			' 
			Me.radioButton12.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton12.Location = New System.Drawing.Point(16, 152)
			Me.radioButton12.Name = "radioButton12"
			Me.radioButton12.Size = New System.Drawing.Size(176, 24)
			Me.radioButton12.TabIndex = 6
			Me.radioButton12.Text = "Assignment"
			' 
			' radioButton11
			' 
			Me.radioButton11.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton11.Location = New System.Drawing.Point(16, 128)
			Me.radioButton11.Name = "radioButton11"
			Me.radioButton11.Size = New System.Drawing.Size(176, 24)
			Me.radioButton11.TabIndex = 5
			Me.radioButton11.Text = "By Category"
			' 
			' radioButton6
			' 
			Me.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton6.Location = New System.Drawing.Point(16, 104)
			Me.radioButton6.Name = "radioButton6"
			Me.radioButton6.Size = New System.Drawing.Size(176, 24)
			Me.radioButton6.TabIndex = 4
			Me.radioButton6.Text = "Overdue Tasks"
			' 
			' radioButton7
			' 
			Me.radioButton7.BackColor = System.Drawing.SystemColors.Window
			Me.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton7.Location = New System.Drawing.Point(16, 80)
			Me.radioButton7.Name = "radioButton7"
			Me.radioButton7.Size = New System.Drawing.Size(176, 24)
			Me.radioButton7.TabIndex = 3
			Me.radioButton7.Text = "Next Seven Days"
			Me.radioButton7.UseVisualStyleBackColor = False
			' 
			' radioButton8
			' 
			Me.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton8.Location = New System.Drawing.Point(16, 56)
			Me.radioButton8.Name = "radioButton8"
			Me.radioButton8.Size = New System.Drawing.Size(176, 24)
			Me.radioButton8.TabIndex = 2
			Me.radioButton8.Text = "Active Tasks"
			' 
			' radioButton9
			' 
			Me.radioButton9.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton9.Location = New System.Drawing.Point(16, 32)
			Me.radioButton9.Name = "radioButton9"
			Me.radioButton9.Size = New System.Drawing.Size(176, 24)
			Me.radioButton9.TabIndex = 1
			Me.radioButton9.Text = "Detailed List"
			' 
			' radioButton10
			' 
			Me.radioButton10.Checked = True
			Me.radioButton10.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton10.Location = New System.Drawing.Point(16, 8)
			Me.radioButton10.Name = "radioButton10"
			Me.radioButton10.Size = New System.Drawing.Size(176, 24)
			Me.radioButton10.TabIndex = 0
			Me.radioButton10.TabStop = True
			Me.radioButton10.Text = "Simple List"
			' 
			' xpTaskBar3
			' 
			Me.xpTaskBar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.xpTaskBar3.Controls.Add(Me.xpTaskBarBox5)
			Me.xpTaskBar3.Controls.Add(Me.xpTaskBarBox6)
			Me.xpTaskBar3.Location = New System.Drawing.Point(1, 27)
			Me.xpTaskBar3.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar3.Name = "xpTaskBar3"
			Me.xpTaskBar3.Size = New System.Drawing.Size(243, 280)
			Me.xpTaskBar3.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
			Me.xpTaskBar3.TabIndex = 5
			Me.xpTaskBar3.VerticalPadding = 1
			' 
			' xpTaskBarBox5
			' 
			Me.xpTaskBarBox5.Controls.Add(Me.panel5)
			Me.xpTaskBarBox5.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox5.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox5.HeaderImageIndex = -1
			Me.xpTaskBarBox5.HitTaskBoxArea = False
			Me.xpTaskBarBox5.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox5.Name = "xpTaskBarBox5"
			Me.xpTaskBarBox5.Size = New System.Drawing.Size(241, 54)
			Me.xpTaskBarBox5.TabIndex = 0
			Me.xpTaskBarBox5.Text = "My Contacts"
			' 
			' panel5
			' 
			Me.panel5.Controls.Add(Me.label8)
			Me.panel5.Location = New System.Drawing.Point(2, 22)
			Me.panel5.Name = "panel5"
			Me.panel5.Size = New System.Drawing.Size(237, 30)
			Me.panel5.TabIndex = 0
			' 
			' label8
			' 
			Me.label8.Dock = System.Windows.Forms.DockStyle.Left
			Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.label8.ForeColor = System.Drawing.Color.Black
			Me.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label8.ImageIndex = 9
			Me.label8.ImageList = Me.smallImageList
			Me.label8.Location = New System.Drawing.Point(0, 0)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(96, 30)
			Me.label8.TabIndex = 5
			Me.label8.Text = "Contacts"
			Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' xpTaskBarBox6
			' 
			Me.xpTaskBarBox6.Controls.Add(Me.panel3)
			Me.xpTaskBarBox6.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox6.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox6.HeaderImageIndex = -1
			Me.xpTaskBarBox6.HitTaskBoxArea = False
			Me.xpTaskBarBox6.Location = New System.Drawing.Point(0, 55)
			Me.xpTaskBarBox6.Name = "xpTaskBarBox6"
			Me.xpTaskBarBox6.PreferredChildPanelHeight = 125
			Me.xpTaskBarBox6.Size = New System.Drawing.Size(241, 149)
			Me.xpTaskBarBox6.TabIndex = 1
			Me.xpTaskBarBox6.Text = "Current View"
			' 
			' panel3
			' 
			Me.panel3.BackColor = System.Drawing.Color.White
			Me.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel3.Controls.Add(Me.radioButton5)
			Me.panel3.Controls.Add(Me.radioButton4)
			Me.panel3.Controls.Add(Me.radioButton3)
			Me.panel3.Controls.Add(Me.radioButton2)
			Me.panel3.Controls.Add(Me.radioButton1)
			Me.panel3.Location = New System.Drawing.Point(2, 22)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(237, 125)
			Me.panel3.TabIndex = 3
			' 
			' radioButton5
			' 
			Me.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton5.Location = New System.Drawing.Point(12, 103)
			Me.radioButton5.Name = "radioButton5"
			Me.radioButton5.Size = New System.Drawing.Size(176, 24)
			Me.radioButton5.TabIndex = 4
			Me.radioButton5.Text = "By Company"
			' 
			' radioButton4
			' 
			Me.radioButton4.BackColor = System.Drawing.SystemColors.Window
			Me.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton4.Location = New System.Drawing.Point(12, 79)
			Me.radioButton4.Name = "radioButton4"
			Me.radioButton4.Size = New System.Drawing.Size(176, 24)
			Me.radioButton4.TabIndex = 3
			Me.radioButton4.Text = "By Category"
			Me.radioButton4.UseVisualStyleBackColor = False
			' 
			' radioButton3
			' 
			Me.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton3.Location = New System.Drawing.Point(12, 55)
			Me.radioButton3.Name = "radioButton3"
			Me.radioButton3.Size = New System.Drawing.Size(176, 24)
			Me.radioButton3.TabIndex = 2
			Me.radioButton3.Text = "Phone List"
			' 
			' radioButton2
			' 
			Me.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton2.Location = New System.Drawing.Point(12, 31)
			Me.radioButton2.Name = "radioButton2"
			Me.radioButton2.Size = New System.Drawing.Size(176, 24)
			Me.radioButton2.TabIndex = 1
			Me.radioButton2.Text = "Detailed Address Cards"
			' 
			' radioButton1
			' 
			Me.radioButton1.Checked = True
			Me.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton1.Location = New System.Drawing.Point(12, 7)
			Me.radioButton1.Name = "radioButton1"
			Me.radioButton1.Size = New System.Drawing.Size(176, 24)
			Me.radioButton1.TabIndex = 0
			Me.radioButton1.TabStop = True
			Me.radioButton1.Text = "Address Cards"
			' 
			' calendarPanel
			' 
			Me.calendarPanel.BackColor = System.Drawing.Color.White
			Me.calendarPanel.Controls.Add(Me.monthCalendarAdv2)
			Me.calendarPanel.Controls.Add(Me.gradientLabel10)
			Me.calendarPanel.Controls.Add(Me.panel13)
			Me.calendarPanel.Controls.Add(Me.panel12)
			Me.calendarPanel.Location = New System.Drawing.Point(1, 27)
			Me.calendarPanel.Name = "calendarPanel"
			Me.calendarPanel.Size = New System.Drawing.Size(243, 314)
			Me.calendarPanel.TabIndex = 12
			' 
			' monthCalendarAdv2
			' 
			Me.monthCalendarAdv2.Culture = New System.Globalization.CultureInfo("")
			Me.monthCalendarAdv2.DaysFont = New System.Drawing.Font("Verdana", 8F)
			Me.monthCalendarAdv2.DaysHeaderInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			'this.monthCalendarAdv2.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
			Me.monthCalendarAdv2.HeaderEndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(255))))))
			Me.monthCalendarAdv2.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.monthCalendarAdv2.HeaderHeight = 20
			Me.monthCalendarAdv2.HeaderStartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(179))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(252))))))
			Me.monthCalendarAdv2.HeadForeColor = System.Drawing.SystemColors.ControlText
			Me.monthCalendarAdv2.HeadGradient = True
			Me.monthCalendarAdv2.Location = New System.Drawing.Point(20, 9)
			Me.monthCalendarAdv2.Name = "monthCalendarAdv2"
			Me.monthCalendarAdv2.ScrollButtonSize = New System.Drawing.Size(24, 24)
			Me.monthCalendarAdv2.SelectedDates = New System.DateTime() { New System.DateTime(2008, 7, 25, 5, 30, 21, 187)}
			Me.monthCalendarAdv2.Size = New System.Drawing.Size(190, 157)
			Me.monthCalendarAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.monthCalendarAdv2.TabIndex = 21
			Me.monthCalendarAdv2.WeekFont = New System.Drawing.Font("Verdana", 8F)
			Me.monthCalendarAdv2.WeekInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite)
			' 
			' 
			' 
			Me.monthCalendarAdv2.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.monthCalendarAdv2.NoneButton.Location = New System.Drawing.Point(118, 0)
			Me.monthCalendarAdv2.NoneButton.Size = New System.Drawing.Size(72, 20)
			Me.monthCalendarAdv2.NoneButton.Text = "None"
			Me.monthCalendarAdv2.NoneButton.UseVisualStyle = True
			Me.monthCalendarAdv2.NoneButton.Visible = False
			' 
			' 
			' 
			Me.monthCalendarAdv2.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.monthCalendarAdv2.TodayButton.Location = New System.Drawing.Point(0, 0)
			Me.monthCalendarAdv2.TodayButton.Size = New System.Drawing.Size(190, 20)
			Me.monthCalendarAdv2.TodayButton.Text = "Today"
			Me.monthCalendarAdv2.TodayButton.UseVisualStyle = True
			Me.monthCalendarAdv2.TodayButton.Visible = False
			' 
			' gradientLabel10
			' 
			Me.gradientLabel10.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(221))))), (CInt(Fix((CByte(246)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(141))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(230)))))))
			Me.gradientLabel10.BorderSides = System.Windows.Forms.Border3DSide.Top
			Me.gradientLabel10.BorderStyle = System.Windows.Forms.Border3DStyle.Flat
			Me.gradientLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientLabel10.Location = New System.Drawing.Point(0, 360)
			Me.gradientLabel10.Name = "gradientLabel10"
			Me.gradientLabel10.Size = New System.Drawing.Size(318, 20)
			Me.gradientLabel10.TabIndex = 4
			Me.gradientLabel10.Text = "My Calendars"
			Me.gradientLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' panel13
			' 
			Me.panel13.BackColor = System.Drawing.SystemColors.Window
			Me.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel13.Controls.Add(Me.label10)
			Me.panel13.Controls.Add(Me.label11)
			Me.panel13.Location = New System.Drawing.Point(0, 380)
			Me.panel13.Name = "panel13"
			Me.panel13.Size = New System.Drawing.Size(318, 32)
			Me.panel13.TabIndex = 4
			' 
			' label10
			' 
			Me.label10.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label10.Location = New System.Drawing.Point(40, 0)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(254, 30)
			Me.label10.TabIndex = 4
			Me.label10.Text = "Calendar"
			Me.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' label11
			' 
			Me.label11.Dock = System.Windows.Forms.DockStyle.Left
			Me.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label11.ImageIndex = 12
			Me.label11.ImageList = Me.smallImageList
			Me.label11.Location = New System.Drawing.Point(0, 0)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(40, 30)
			Me.label11.TabIndex = 4
			Me.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' panel12
			' 
			Me.panel12.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel12.Controls.Add(Me.linkLabel10)
			Me.panel12.Location = New System.Drawing.Point(0, 408)
			Me.panel12.Name = "panel12"
			Me.panel12.Size = New System.Drawing.Size(318, 142)
			Me.panel12.TabIndex = 4
			' 
			' linkLabel10
			' 
			Me.linkLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.linkLabel10.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
			Me.linkLabel10.Location = New System.Drawing.Point(16, 8)
			Me.linkLabel10.Name = "linkLabel10"
			Me.linkLabel10.Size = New System.Drawing.Size(176, 16)
			Me.linkLabel10.TabIndex = 0
			Me.linkLabel10.TabStop = True
			Me.linkLabel10.Text = "Open a Shared Calendar..."
			' 
			' xpTaskBar5
			' 
			Me.xpTaskBar5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.xpTaskBar5.Controls.Add(Me.xpTaskBarBox9)
			Me.xpTaskBar5.Location = New System.Drawing.Point(1, 27)
			Me.xpTaskBar5.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar5.Name = "xpTaskBar5"
			Me.xpTaskBar5.Size = New System.Drawing.Size(243, 348)
			Me.xpTaskBar5.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007
			Me.xpTaskBar5.TabIndex = 7
			Me.xpTaskBar5.VerticalPadding = 1
			' 
			' xpTaskBarBox9
			' 
			Me.xpTaskBarBox9.Controls.Add(Me.panel10)
			Me.xpTaskBarBox9.ForeColor = System.Drawing.Color.MidnightBlue
			Me.xpTaskBarBox9.HeaderFont = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.xpTaskBarBox9.HeaderImageIndex = -1
			Me.xpTaskBarBox9.HitTaskBoxArea = False
			Me.xpTaskBarBox9.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox9.Name = "xpTaskBarBox9"
			Me.xpTaskBarBox9.PreferredChildPanelHeight = 160
			Me.xpTaskBarBox9.Size = New System.Drawing.Size(241, 184)
			Me.xpTaskBarBox9.TabIndex = 0
			Me.xpTaskBarBox9.Text = "My Folder List"
			' 
			' panel10
			' 
			Me.panel10.Controls.Add(Me.treeView1)
			Me.panel10.Location = New System.Drawing.Point(2, 22)
			Me.panel10.Name = "panel10"
			Me.panel10.Size = New System.Drawing.Size(237, 160)
			Me.panel10.TabIndex = 0
			' 
			' treeView1
			' 
			Me.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.treeView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.treeView1.ImageIndex = 0
			Me.treeView1.ImageList = Me.smallImageList
			Me.treeView1.Indent = 25
			Me.treeView1.Location = New System.Drawing.Point(0, 0)
			Me.treeView1.Name = "treeView1"
			treeNode1.ImageIndex = 3
			treeNode1.Name = ""
			treeNode1.SelectedImageIndex = 3
			treeNode1.Text = "Junk Mail"
			treeNode2.ImageIndex = 1
			treeNode2.Name = ""
			treeNode2.SelectedImageIndex = 1
			treeNode2.Text = "Deleted Items"
			treeNode3.ImageIndex = 0
			treeNode3.Name = ""
			treeNode3.SelectedImageIndex = 0
			treeNode3.Text = "Junk Email"
			treeNode4.ImageIndex = 2
			treeNode4.Name = ""
			treeNode4.SelectedImageIndex = 2
			treeNode4.Text = "InBox"
			treeNode5.ImageIndex = 6
			treeNode5.Name = ""
			treeNode5.SelectedImageIndex = 6
			treeNode5.Text = "Sent Items"
			treeNode6.ImageIndex = 4
			treeNode6.Name = ""
			treeNode6.SelectedImageIndex = 4
			treeNode6.Text = "Search Folders"
			treeNode7.Name = ""
			treeNode7.Text = "Calendar"
			treeNode8.ImageIndex = 9
			treeNode8.Name = ""
			treeNode8.SelectedImageIndex = 9
			treeNode8.Text = "Contacts"
			treeNode9.ImageIndex = 5
			treeNode9.Name = ""
			treeNode9.SelectedImageIndex = 5
			treeNode9.Text = "Drafts"
			treeNode10.ImageIndex = 13
			treeNode10.Name = ""
			treeNode10.SelectedImageIndex = 13
			treeNode10.Text = "Journal"
			treeNode11.ImageIndex = 7
			treeNode11.Name = ""
			treeNode11.SelectedImageIndex = 7
			treeNode11.Text = "Personal Folders"
			treeNode12.ImageIndex = 4
			treeNode12.Name = ""
			treeNode12.SelectedImageIndex = 4
			treeNode12.Text = "Search Folders"
			treeNode13.ImageIndex = 6
			treeNode13.Name = ""
			treeNode13.SelectedImageIndex = 6
			treeNode13.Text = "Sent Items"
			treeNode14.ImageIndex = 1
			treeNode14.Name = ""
			treeNode14.SelectedImageIndex = 1
			treeNode14.Text = "Deleted Items"
			treeNode15.ImageIndex = 8
			treeNode15.Name = ""
			treeNode15.SelectedImageIndex = 8
			treeNode15.Text = "Archive Folders"
			treeNode16.ImageIndex = 5
			treeNode16.Name = ""
			treeNode16.SelectedImageIndex = 5
			treeNode16.Text = "Drafts"
			treeNode57.ImageIndex = 2
			treeNode57.Name = ""
			treeNode57.SelectedImageIndex = 2
			treeNode57.Text = "InBox"
			treeNode58.ImageIndex = 3
			treeNode58.Name = ""
			treeNode58.SelectedImageIndex = 3
			treeNode58.Text = "OutBox"
			treeNode59.ImageIndex = 6
			treeNode59.Name = ""
			treeNode59.SelectedImageIndex = 6
			treeNode59.Text = "Sent Items"
			treeNode60.Name = ""
			treeNode60.Text = "Public"
			treeNode61.ImageIndex = 8
			treeNode61.Name = ""
			treeNode61.SelectedImageIndex = 8
			treeNode61.Text = "Syncfusion Email"
			treeNode62.ImageIndex = 4
			treeNode62.Name = ""
			treeNode62.SelectedImageIndex = 4
			treeNode62.Text = "For Follow Up"
			treeNode63.ImageIndex = 4
			treeNode63.Name = ""
			treeNode63.SelectedImageIndex = 4
			treeNode63.Text = "Large Mail"
			treeNode64.ImageIndex = 4
			treeNode64.Name = ""
			treeNode64.SelectedImageIndex = 4
			treeNode64.Text = "Search Folders"
			Me.treeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() { treeNode11, treeNode15, treeNode61, treeNode64})
			Me.treeView1.SelectedImageIndex = 0
			Me.treeView1.ShowLines = False
			Me.treeView1.Size = New System.Drawing.Size(237, 160)
			Me.treeView1.TabIndex = 21
			' 
			' MailGgroupBarItem
			' 
			Me.MailGgroupBarItem.Client = Me.xpTaskBar1
			Me.MailGgroupBarItem.LargeImageMode = True
			Me.MailGgroupBarItem.Text = "Mail"
			' 
			' ContactsGroupBarItem
			' 
			Me.ContactsGroupBarItem.Client = Me.xpTaskBar3
			Me.ContactsGroupBarItem.LargeImageMode = True
			Me.ContactsGroupBarItem.Text = "Contacts"
			' 
			' TasksGroupBarItem
			' 
			Me.TasksGroupBarItem.Client = Me.xpTaskBar2
			Me.TasksGroupBarItem.LargeImageMode = True
			Me.TasksGroupBarItem.Text = "Tasks"
			' 
			' NotesgroupBarItem
			' 
			Me.NotesgroupBarItem.Client = Me.xpTaskBar4
			Me.NotesgroupBarItem.LargeImageMode = True
			Me.NotesgroupBarItem.Text = "Notes"
			' 
			' FolderListGroupBarItem
			' 
			Me.FolderListGroupBarItem.Client = Me.xpTaskBar5
			Me.FolderListGroupBarItem.InNavigationPane = True
			Me.FolderListGroupBarItem.LargeImageMode = True
			Me.FolderListGroupBarItem.Text = "Folder List"
			' 
			' CalendarGroupBarItem
			' 
			Me.CalendarGroupBarItem.Client = Me.calendarPanel
			Me.CalendarGroupBarItem.InNavigationPane = True
			Me.CalendarGroupBarItem.LargeImageMode = True
			Me.CalendarGroupBarItem.Text = "Calendar"
			' 
			' JournalGroupBarItem
			' 
			Me.JournalGroupBarItem.Client = Me.xpTaskBar6
			Me.JournalGroupBarItem.InNavigationPane = True
			Me.JournalGroupBarItem.LargeImageMode = True
			Me.JournalGroupBarItem.Text = "Journal"
			' 
			' tabPageAdvanced
			' 
			Me.tabPageAdvanced.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(247))))), (CInt(Fix((CByte(249))))), (CInt(Fix((CByte(255))))))
			Me.tabPageAdvanced.Controls.Add(Me.gradientPanel7)
			Me.tabPageAdvanced.Controls.Add(Me.gradientPanel6)
			Me.tabPageAdvanced.Controls.Add(Me.gradientPanel4)
			Me.tabPageAdvanced.Controls.Add(Me.gbAdvanced)
			Me.tabPageAdvanced.Location = New System.Drawing.Point(3, 31)
			Me.tabPageAdvanced.Name = "tabPageAdvanced"
			Me.tabPageAdvanced.Size = New System.Drawing.Size(550, 478)
			Me.tabPageAdvanced.TabIndex = 2
			Me.tabPageAdvanced.Text = "Advanced Settings"
			Me.tabPageAdvanced.ThemesEnabled = False
			' 
			' gradientPanel7
			' 
			Me.gradientPanel7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))))
			Me.gradientPanel7.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(213))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(246))))))
			Me.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel7.Controls.Add(Me.listView1)
			Me.gradientPanel7.Controls.Add(Me.panel21)
			Me.gradientPanel7.Location = New System.Drawing.Point(313, 279)
			Me.gradientPanel7.Name = "gradientPanel7"
			Me.gradientPanel7.Size = New System.Drawing.Size(220, 185)
			Me.gradientPanel7.TabIndex = 201
			' 
			' listView1
			' 
			Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() { Me.columnHeader1, Me.columnHeader2})
			Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listView1.FullRowSelect = True
			Me.listView1.GridLines = True
			Me.listView1.Location = New System.Drawing.Point(0, 27)
			Me.listView1.MultiSelect = False
			Me.listView1.Name = "listView1"
			Me.listView1.Size = New System.Drawing.Size(218, 156)
			Me.listView1.TabIndex = 158
			Me.listView1.UseCompatibleStateImageBehavior = False
			Me.listView1.View = System.Windows.Forms.View.Details
			' 
			' columnHeader1
			' 
			Me.columnHeader1.Text = "Events"
			Me.columnHeader1.Width = 127
			' 
			' columnHeader2
			' 
			Me.columnHeader2.Text = "Arguments"
			Me.columnHeader2.Width = 91
			' 
			' panel21
			' 
			Me.panel21.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(254))))))
			Me.panel21.Controls.Add(Me.label36)
			Me.panel21.Controls.Add(Me.label37)
			Me.panel21.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel21.Location = New System.Drawing.Point(0, 0)
			Me.panel21.Name = "panel21"
			Me.panel21.Size = New System.Drawing.Size(218, 27)
			Me.panel21.TabIndex = 157
			' 
			' label36
			' 
			Me.label36.BackColor = System.Drawing.Color.White
			Me.label36.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.label36.Location = New System.Drawing.Point(0, 25)
			Me.label36.Name = "label36"
			Me.label36.Size = New System.Drawing.Size(218, 2)
			Me.label36.TabIndex = 139
			' 
			' label37
			' 
			Me.label37.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label37.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label37.Image = (CType(resources.GetObject("label37.Image"), System.Drawing.Image))
			Me.label37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label37.Location = New System.Drawing.Point(10, 3)
			Me.label37.Name = "label37"
			Me.label37.Size = New System.Drawing.Size(81, 18)
			Me.label37.TabIndex = 170
			Me.label37.Text = "Event Log"
			Me.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' gradientPanel6
			' 
			Me.gradientPanel6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(233))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(250))))))
			Me.gradientPanel6.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(141))))), (CInt(Fix((CByte(178))))), (CInt(Fix((CByte(227))))))
			Me.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel6.Controls.Add(Me.label24)
			Me.gradientPanel6.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.gradientPanel6.Location = New System.Drawing.Point(13, 12)
			Me.gradientPanel6.Name = "gradientPanel6"
			Me.gradientPanel6.Size = New System.Drawing.Size(524, 65)
			Me.gradientPanel6.TabIndex = 200
			' 
			' label24
			' 
			Me.label24.BackColor = System.Drawing.Color.Transparent
			Me.label24.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label24.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label24.Image = (CType(resources.GetObject("label24.Image"), System.Drawing.Image))
			Me.label24.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label24.Location = New System.Drawing.Point(0, 0)
			Me.label24.Name = "label24"
			Me.label24.Size = New System.Drawing.Size(522, 63)
			Me.label24.TabIndex = 1
			Me.label24.Text = resources.GetString("label24.Text")
			' 
			' gradientPanel4
			' 
			Me.gradientPanel4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(235))))), (CInt(Fix((CByte(241))))), (CInt(Fix((CByte(253))))))
			Me.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(213))))), (CInt(Fix((CByte(227))))), (CInt(Fix((CByte(246))))))
			Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel4.Controls.Add(Me.label38)
			Me.gradientPanel4.Controls.Add(Me.label19)
			Me.gradientPanel4.Controls.Add(Me.label22)
			Me.gradientPanel4.Controls.Add(Me.label21)
			Me.gradientPanel4.Controls.Add(Me.label7)
			Me.gradientPanel4.Controls.Add(Me.cpCustomColor)
			Me.gradientPanel4.Controls.Add(Me.panel19)
			Me.gradientPanel4.Location = New System.Drawing.Point(314, 87)
			Me.gradientPanel4.Name = "gradientPanel4"
			Me.gradientPanel4.Size = New System.Drawing.Size(220, 186)
			Me.gradientPanel4.TabIndex = 199

			' 
			' label38
			' 
			Me.label38.BackColor = System.Drawing.Color.Transparent
			Me.label38.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label38.ForeColor = System.Drawing.Color.Black
			Me.label38.Location = New System.Drawing.Point(17, 138)
			Me.label38.Name = "label38"
			Me.label38.Size = New System.Drawing.Size(189, 31)
			Me.label38.TabIndex = 208
			Me.label38.Text = "Right Click on the GroupBarItems to view the ContextMenu." & Constants.vbCrLf & Constants.vbCrLf
			' 
			' label19
			' 
			Me.label19.AutoSize = True
			Me.label19.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label19.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label19.Location = New System.Drawing.Point(3, 116)
			Me.label19.Name = "label19"
			Me.label19.Size = New System.Drawing.Size(89, 13)
			Me.label19.TabIndex = 207
			Me.label19.Text = "ContextMenus"
			Me.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label22
			' 
			Me.label22.BackColor = System.Drawing.Color.Transparent
			Me.label22.Image = (CType(resources.GetObject("label22.Image"), System.Drawing.Image))
			Me.label22.Location = New System.Drawing.Point(130, 69)
			Me.label22.Name = "label22"
			Me.label22.Size = New System.Drawing.Size(20, 20)
			Me.label22.TabIndex = 206
			Me.toolTip1.SetToolTip(Me.label22, "Color of ParentGroupBar with Office2007 style is " & Constants.vbCrLf & "set with Office2007Colors clas" & "s." & Constants.vbCrLf & Constants.vbCrLf & "Color of the Nested GroupBar with OfficeXP style is " & Constants.vbCrLf & "set using the Provid" & "eGroupBarItemBrush event.")
			' 
			' label21
			' 
			Me.label21.AutoSize = True
			Me.label21.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label21.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label21.Location = New System.Drawing.Point(3, 40)
			Me.label21.Name = "label21"
			Me.label21.Size = New System.Drawing.Size(88, 13)
			Me.label21.TabIndex = 205
			Me.label21.Text = "Custom Colors"
			Me.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.BackColor = System.Drawing.Color.Transparent
			Me.label7.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label7.ForeColor = System.Drawing.Color.Black
			Me.label7.Location = New System.Drawing.Point(17, 69)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(65, 14)
			Me.label7.TabIndex = 203
			Me.label7.Text = "Select Color"
			' 
			' cpCustomColor
			' 
			Me.cpCustomColor.BackColor = System.Drawing.SystemColors.HotTrack
			Me.cpCustomColor.ColorUISize = New System.Drawing.Size(208, 230)
			Me.cpCustomColor.Cursor = System.Windows.Forms.Cursors.Hand
			Me.cpCustomColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
			Me.cpCustomColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cpCustomColor.ForeColor = System.Drawing.Color.MidnightBlue
			Me.cpCustomColor.Location = New System.Drawing.Point(104, 69)
			Me.cpCustomColor.Name = "cpCustomColor"
			Me.cpCustomColor.SelectedAsBackcolor = True
			Me.cpCustomColor.SelectedColor = System.Drawing.SystemColors.HotTrack
			Me.cpCustomColor.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None
			Me.cpCustomColor.Size = New System.Drawing.Size(20, 20)
			Me.cpCustomColor.TabIndex = 202
			Me.cpCustomColor.UseVisualStyleBackColor = False
'			Me.cpCustomColor.ColorSelected += New System.EventHandler(Me.cpCustomColor_ColorSelected)
			' 
			' panel19
			' 
			Me.panel19.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(223))))), (CInt(Fix((CByte(236))))), (CInt(Fix((CByte(254))))))
			Me.panel19.Controls.Add(Me.label30)
			Me.panel19.Controls.Add(Me.label31)
			Me.panel19.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel19.Location = New System.Drawing.Point(0, 0)
			Me.panel19.Name = "panel19"
			Me.panel19.Size = New System.Drawing.Size(218, 27)
			Me.panel19.TabIndex = 157
			' 
			' label30
			' 
			Me.label30.BackColor = System.Drawing.Color.White
			Me.label30.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.label30.Location = New System.Drawing.Point(0, 25)
			Me.label30.Name = "label30"
			Me.label30.Size = New System.Drawing.Size(218, 2)
			Me.label30.TabIndex = 139
			' 
			' label31
			' 
			Me.label31.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label31.ForeColor = System.Drawing.Color.MidnightBlue
			Me.label31.Image = (CType(resources.GetObject("label31.Image"), System.Drawing.Image))
			Me.label31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
			Me.label31.Location = New System.Drawing.Point(8, 4)
			Me.label31.Name = "label31"
			Me.label31.Size = New System.Drawing.Size(137, 18)
			Me.label31.TabIndex = 170
			Me.label31.Text = "Advanced Features"
			Me.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' gbAdvanced
			' 
			Me.gbAdvanced.AllowDrop = True
			Me.gbAdvanced.BackColor = System.Drawing.Color.White
			Me.gbAdvanced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gbAdvanced.Controls.Add(Me.NestedGroupBar)
			Me.gbAdvanced.Controls.Add(Me.panel24)
			Me.gbAdvanced.Controls.Add(Me.CustomControlsPanel)
			Me.gbAdvanced.Controls.Add(Me.panel20)
			Me.gbAdvanced.Controls.Add(Me.panel22)
			Me.gbAdvanced.DrawClientBorder = True
			Me.gbAdvanced.Font = New System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold)
			Me.gbAdvanced.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(33))))), (CInt(Fix((CByte(77))))), (CInt(Fix((CByte(140))))))
			Me.gbAdvanced.GroupBarItemHeight = 27
			Me.gbAdvanced.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.CustomControlsGroupBarItem, Me.NestedGroupBarItem, Me.groupBarItem2, Me.groupBarItem1, Me.groupBarItem3})
			Me.gbAdvanced.Location = New System.Drawing.Point(17, 92)
			Me.gbAdvanced.Name = "gbAdvanced"
			Me.gbAdvanced.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed
			Me.gbAdvanced.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.gbAdvanced.SelectedItem = 1
			Me.gbAdvanced.Size = New System.Drawing.Size(230, 371)
			Me.gbAdvanced.TabIndex = 136
			Me.gbAdvanced.Text = "groupBar2"
			Me.gbAdvanced.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
			Me.gbAdvanced.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007
'			Me.gbAdvanced.GroupBarItemSelected += New System.EventHandler(Me.gbAdvanced_GroupBarItemSelected)
'			Me.gbAdvanced.GroupBarItemRenamed += New Syncfusion.Windows.Forms.Tools.GroupItemRenamedEventHandler(Me.gbAdvanced_GroupBarItemRenamed)
'			Me.gbAdvanced.ShowContextMenu += New System.EventHandler(Me.gbAdvanced_ShowContextMenu)
'			Me.gbAdvanced.GroupBarItemSelectionChanging += New Syncfusion.Windows.Forms.Tools.GroupBarItemSelectionChangingEventHandler(Me.gbAdvanced_GroupBarItemSelectionChanging)
			' 
			' NestedGroupBar
			' 
			Me.NestedGroupBar.AllowDrop = True
			Me.NestedGroupBar.BackColor = System.Drawing.Color.White
			Me.NestedGroupBar.Controls.Add(Me.gvOffice)
			Me.NestedGroupBar.Controls.Add(Me.PersonalGroupView)
			Me.NestedGroupBar.DrawClientBorder = True
			Me.NestedGroupBar.ForeColor = System.Drawing.Color.Black
			Me.NestedGroupBar.GroupBarItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupBarItem() { Me.PersonalGroupBarItem, Me.OfficeGroupBarItem})
			Me.NestedGroupBar.Location = New System.Drawing.Point(2, 56)
			Me.NestedGroupBar.Name = "NestedGroupBar"
			Me.NestedGroupBar.PopupClientSize = New System.Drawing.Size(0, 0)
			Me.NestedGroupBar.SelectedItem = 1
			Me.NestedGroupBar.Size = New System.Drawing.Size(226, 232)
			Me.NestedGroupBar.TabIndex = 134
			Me.NestedGroupBar.Text = "groupBar1"
			Me.NestedGroupBar.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Left
'			Me.NestedGroupBar.ProvideGroupBarItemBrush += New Syncfusion.Windows.Forms.Tools.ProvideGroupBarItemBrushEventHandler(Me.NestedGroupBar_ProvideGroupBarItemBrush)
			' 
			' gvOffice
			' 
			Me.gvOffice.BackColor = System.Drawing.Color.White
			Me.gvOffice.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gvOffice.FlatLook = True
			Me.gvOffice.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Activities", 0, True, Nothing, "Activities"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Appointments", 1, True, Nothing, "Appointments"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Contacts", 2, True, Nothing, "Contacts"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Reminder", 3, True, Nothing, "Reminder")})
			Me.gvOffice.HighlightImageOffset = New System.Drawing.Point(1, 1)
			Me.gvOffice.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			Me.gvOffice.HighlightTextColor = System.Drawing.Color.White
			Me.gvOffice.IntegratedScrolling = True
			Me.gvOffice.ItemXSpacing = 30
			Me.gvOffice.ItemYSpacing = 10
			Me.gvOffice.LargeImageList = Me.ilGroupBarLarge
			Me.gvOffice.Location = New System.Drawing.Point(3, 47)
			Me.gvOffice.Name = "gvOffice"
			Me.gvOffice.SelectedTextColor = System.Drawing.Color.White
			Me.gvOffice.SelectingTextColor = System.Drawing.Color.White
			Me.gvOffice.Size = New System.Drawing.Size(220, 182)
			Me.gvOffice.SmallImageList = Nothing
			Me.gvOffice.TabIndex = 11
			Me.gvOffice.Text = "groupView5"
			Me.gvOffice.TextSpacing = 22
			Me.gvOffice.TextWrap = True
			' 
			' PersonalGroupView
			' 
			Me.PersonalGroupView.BackColor = System.Drawing.Color.White
			Me.PersonalGroupView.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.PersonalGroupView.FlatLook = True
			Me.PersonalGroupView.GroupViewItems.AddRange(New Syncfusion.Windows.Forms.Tools.GroupViewItem() { New Syncfusion.Windows.Forms.Tools.GroupViewItem("Activities", 0, True, Nothing, "Activities"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Appointments", 1, True, Nothing, "Appointments"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Contacts", 2, True, Nothing, "Contacts"), New Syncfusion.Windows.Forms.Tools.GroupViewItem("Reminder", 3, True, Nothing, "Reminder")})
			Me.PersonalGroupView.HighlightImageOffset = New System.Drawing.Point(1, 1)
			Me.PersonalGroupView.HighlightItemColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))), (CInt(Fix((CByte(224))))))
			Me.PersonalGroupView.HighlightTextColor = System.Drawing.Color.White
			Me.PersonalGroupView.IntegratedScrolling = True
			Me.PersonalGroupView.ItemXSpacing = 30
			Me.PersonalGroupView.ItemYSpacing = 10
			Me.PersonalGroupView.LargeImageList = Me.ilGroupBarLarge
			Me.PersonalGroupView.Location = New System.Drawing.Point(3, 24)
			Me.PersonalGroupView.Name = "PersonalGroupView"
			Me.PersonalGroupView.SelectedTextColor = System.Drawing.Color.White
			Me.PersonalGroupView.SelectingTextColor = System.Drawing.Color.White
			Me.PersonalGroupView.Size = New System.Drawing.Size(220, 1)
			Me.PersonalGroupView.SmallImageList = Nothing
			Me.PersonalGroupView.TabIndex = 10
			Me.PersonalGroupView.Text = "groupView5"
			Me.PersonalGroupView.TextSpacing = 22
			Me.PersonalGroupView.TextWrap = True
			' 
			' PersonalGroupBarItem
			' 
			Me.PersonalGroupBarItem.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(185))))), (CInt(Fix((CByte(225))))))
			Me.PersonalGroupBarItem.Client = Me.PersonalGroupView
			Me.PersonalGroupBarItem.Text = "Personal"
			' 
			' OfficeGroupBarItem
			' 
			Me.OfficeGroupBarItem.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(154))))), (CInt(Fix((CByte(185))))), (CInt(Fix((CByte(225))))))
			Me.OfficeGroupBarItem.Client = Me.gvOffice
			Me.OfficeGroupBarItem.Text = "Office"
			' 
			' panel24
			' 
			Me.panel24.Controls.Add(Me.label4)
			Me.panel24.Location = New System.Drawing.Point(2, 137)
			Me.panel24.Name = "panel24"
			Me.panel24.Size = New System.Drawing.Size(0, 0)
			Me.panel24.TabIndex = 137
			' 
			' label4
			' 
			Me.label4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label4.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.label4.ForeColor = System.Drawing.Color.Black
			Me.label4.Location = New System.Drawing.Point(0, 0)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(0, 0)
			Me.label4.TabIndex = 0
			Me.label4.Text = resources.GetString("label4.Text")
			' 
			' CustomControlsPanel
			' 
			Me.CustomControlsPanel.BackColor = System.Drawing.Color.White
			Me.CustomControlsPanel.Controls.Add(Me.checkBoxAdv2)
			Me.CustomControlsPanel.Controls.Add(Me.checkBoxAdv1)
			Me.CustomControlsPanel.Controls.Add(Me.monthCalendarAdv1)
			Me.CustomControlsPanel.Location = New System.Drawing.Point(2, 28)
			Me.CustomControlsPanel.Name = "CustomControlsPanel"
			Me.CustomControlsPanel.Size = New System.Drawing.Size(226, 1)
			Me.CustomControlsPanel.TabIndex = 133
			' 
			' checkBoxAdv2
			' 
			Me.checkBoxAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv2.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.checkBoxAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.checkBoxAdv2.GradientStart = System.Drawing.SystemColors.Control
			Me.checkBoxAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv2.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.checkBoxAdv2.Location = New System.Drawing.Point(36, 214)
			Me.checkBoxAdv2.Name = "checkBoxAdv2"
			Me.checkBoxAdv2.ShadowColor = System.Drawing.Color.Black
			Me.checkBoxAdv2.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.checkBoxAdv2.Size = New System.Drawing.Size(125, 21)
			Me.checkBoxAdv2.TabIndex = 2
			Me.checkBoxAdv2.Text = "Project Delivered"
			Me.checkBoxAdv2.ThemesEnabled = True
			' 
			' checkBoxAdv1
			' 
			Me.checkBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(161)))
			Me.checkBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark
			Me.checkBoxAdv1.GradientStart = System.Drawing.SystemColors.Control
			Me.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame
			Me.checkBoxAdv1.ImageCheckBoxSize = New System.Drawing.Size(13, 13)
			Me.checkBoxAdv1.Location = New System.Drawing.Point(36, 196)
			Me.checkBoxAdv1.Name = "checkBoxAdv1"
			Me.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black
			Me.checkBoxAdv1.ShadowOffset = New System.Drawing.Point(2, 2)
			Me.checkBoxAdv1.Size = New System.Drawing.Size(125, 21)
			Me.checkBoxAdv1.TabIndex = 1
			Me.checkBoxAdv1.Text = "Task Completed"
			Me.checkBoxAdv1.ThemesEnabled = True
			' 
			' monthCalendarAdv1
			' 
			Me.monthCalendarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump
			Me.monthCalendarAdv1.Culture = New System.Globalization.CultureInfo("")
			Me.monthCalendarAdv1.DaysFont = New System.Drawing.Font("Verdana", 8F)
			Me.monthCalendarAdv1.DaysHeaderInterior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			'this.monthCalendarAdv1.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
			Me.monthCalendarAdv1.HeaderEndColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(231))))), (CInt(Fix((CByte(242))))), (CInt(Fix((CByte(255))))))
			Me.monthCalendarAdv1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.monthCalendarAdv1.HeaderHeight = 20
			Me.monthCalendarAdv1.HeaderStartColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(179))))), (CInt(Fix((CByte(209))))), (CInt(Fix((CByte(252))))))
			Me.monthCalendarAdv1.HeadForeColor = System.Drawing.SystemColors.ControlText
			Me.monthCalendarAdv1.HeadGradient = True
			Me.monthCalendarAdv1.Location = New System.Drawing.Point(13, 17)
			Me.monthCalendarAdv1.Name = "monthCalendarAdv1"
			Me.monthCalendarAdv1.ScrollButtonSize = New System.Drawing.Size(24, 24)
			Me.monthCalendarAdv1.SelectedDates = New System.DateTime() { New System.DateTime(2008, 7, 25, 5, 30, 23, 359)}
			Me.monthCalendarAdv1.Size = New System.Drawing.Size(184, 168)
			Me.monthCalendarAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007
			Me.monthCalendarAdv1.TabIndex = 0
			Me.monthCalendarAdv1.WeekFont = New System.Drawing.Font("Verdana", 8F)
			Me.monthCalendarAdv1.WeekInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite)
			' 
			' 
			' 
			Me.monthCalendarAdv1.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.monthCalendarAdv1.NoneButton.Location = New System.Drawing.Point(112, 0)
			Me.monthCalendarAdv1.NoneButton.Size = New System.Drawing.Size(72, 20)
			Me.monthCalendarAdv1.NoneButton.Text = "None"
			Me.monthCalendarAdv1.NoneButton.UseVisualStyle = True
			' 
			' 
			' 
			Me.monthCalendarAdv1.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
			Me.monthCalendarAdv1.TodayButton.Location = New System.Drawing.Point(0, 0)
			Me.monthCalendarAdv1.TodayButton.Size = New System.Drawing.Size(112, 20)
			Me.monthCalendarAdv1.TodayButton.Text = "Today"
			Me.monthCalendarAdv1.TodayButton.UseVisualStyle = True
			' 
			' panel20
			' 
			Me.panel20.Controls.Add(Me.label32)
			Me.panel20.Location = New System.Drawing.Point(2, 314)
			Me.panel20.Name = "panel20"
			Me.panel20.Size = New System.Drawing.Size(226, 1)
			Me.panel20.TabIndex = 135
			' 
			' label32
			' 
			Me.label32.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label32.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label32.ForeColor = System.Drawing.Color.Black
			Me.label32.Location = New System.Drawing.Point(0, 0)
			Me.label32.Name = "label32"
			Me.label32.Size = New System.Drawing.Size(226, 1)
			Me.label32.TabIndex = 0
			Me.label32.Text = "Color of ParentGroupBar with Office2007 style is set with Office2007Colors class." & Constants.vbCrLf & Constants.vbCrLf & "Color of the Nested GroupBar with OfficeXP style is set using the ProvideGro" & "upBarItemBrush event."
			' 
			' panel22
			' 
			Me.panel22.Controls.Add(Me.label33)
			Me.panel22.Location = New System.Drawing.Point(2, 341)
			Me.panel22.Name = "panel22"
			Me.panel22.Size = New System.Drawing.Size(226, 1)
			Me.panel22.TabIndex = 136
			' 
			' label33
			' 
			Me.label33.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label33.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label33.ForeColor = System.Drawing.Color.Black
			Me.label33.Location = New System.Drawing.Point(0, 0)
			Me.label33.Name = "label33"
			Me.label33.Size = New System.Drawing.Size(226, 1)
			Me.label33.TabIndex = 0
			Me.label33.Text = resources.GetString("label33.Text")
			' 
			' CustomControlsGroupBarItem
			' 
			Me.CustomControlsGroupBarItem.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(65))))), (CInt(Fix((CByte(131))))), (CInt(Fix((CByte(183))))))
			Me.CustomControlsGroupBarItem.Client = Me.CustomControlsPanel
			Me.CustomControlsGroupBarItem.Text = "Custom Controls"
			' 
			' NestedGroupBarItem
			' 
			Me.NestedGroupBarItem.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(65))))), (CInt(Fix((CByte(131))))), (CInt(Fix((CByte(183))))))
			Me.NestedGroupBarItem.Client = Me.NestedGroupBar
			Me.NestedGroupBarItem.Text = "Nested GroupBar"
			' 
			' groupBarItem2
			' 
			Me.groupBarItem2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(65))))), (CInt(Fix((CByte(131))))), (CInt(Fix((CByte(183))))))
			Me.groupBarItem2.Client = Me.panel20
			Me.groupBarItem2.Text = "Appearance Customization"
			' 
			' groupBarItem1
			' 
			Me.groupBarItem1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(65))))), (CInt(Fix((CByte(131))))), (CInt(Fix((CByte(183))))))
			Me.groupBarItem1.Client = Me.panel22
			Me.groupBarItem1.Text = "Events supported"
			' 
			' groupBarItem3
			' 
			Me.groupBarItem3.BackColor = System.Drawing.Color.White
			Me.groupBarItem3.Client = Me.panel24
			Me.groupBarItem3.Text = "ContextMenu"
			' 
			' label12
			' 
			Me.label12.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.label12.AutoSize = True
			Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label12.Location = New System.Drawing.Point(50, 8)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(36, 13)
			Me.label12.TabIndex = 4
			Me.label12.Text = "Tasks"
			Me.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' label13
			' 
			Me.label13.Dock = System.Windows.Forms.DockStyle.Left
			Me.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
			Me.label13.ImageIndex = 10
			Me.label13.Location = New System.Drawing.Point(0, 0)
			Me.label13.Name = "label13"
			Me.label13.Size = New System.Drawing.Size(40, 30)
			Me.label13.TabIndex = 4
			Me.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' radioButton13
			' 
			Me.radioButton13.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton13.Location = New System.Drawing.Point(16, 104)
			Me.radioButton13.Name = "radioButton13"
			Me.radioButton13.Size = New System.Drawing.Size(176, 24)
			Me.radioButton13.TabIndex = 4
			Me.radioButton13.Text = "By Color"
			' 
			' radioButton14
			' 
			Me.radioButton14.BackColor = System.Drawing.SystemColors.Window
			Me.radioButton14.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton14.Location = New System.Drawing.Point(16, 80)
			Me.radioButton14.Name = "radioButton14"
			Me.radioButton14.Size = New System.Drawing.Size(176, 24)
			Me.radioButton14.TabIndex = 3
			Me.radioButton14.Text = "By Category"
			Me.radioButton14.UseVisualStyleBackColor = False
			' 
			' radioButton15
			' 
			Me.radioButton15.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton15.Location = New System.Drawing.Point(16, 56)
			Me.radioButton15.Name = "radioButton15"
			Me.radioButton15.Size = New System.Drawing.Size(176, 24)
			Me.radioButton15.TabIndex = 2
			Me.radioButton15.Text = "Last Seven Days"
			' 
			' radioButton16
			' 
			Me.radioButton16.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton16.Location = New System.Drawing.Point(16, 32)
			Me.radioButton16.Name = "radioButton16"
			Me.radioButton16.Size = New System.Drawing.Size(176, 24)
			Me.radioButton16.TabIndex = 1
			Me.radioButton16.Text = "Notes List"
			' 
			' radioButton17
			' 
			Me.radioButton17.Checked = True
			Me.radioButton17.FlatStyle = System.Windows.Forms.FlatStyle.System
			Me.radioButton17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radioButton17.Location = New System.Drawing.Point(16, 8)
			Me.radioButton17.Name = "radioButton17"
			Me.radioButton17.Size = New System.Drawing.Size(176, 24)
			Me.radioButton17.TabIndex = 0
			Me.radioButton17.TabStop = True
			Me.radioButton17.Text = "Icons"
			' 
			' imageListAdv1
			' 
			Me.imageListAdv1.Images.AddRange(New System.Drawing.Image() { (CType(resources.GetObject("imageListAdv1.Images"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images1"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images2"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images3"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images4"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images5"), System.Drawing.Image)), (CType(resources.GetObject("imageListAdv1.Images6"), System.Drawing.Image))})
			Me.imageListAdv1.ImageSize = New System.Drawing.Size(32, 32)
			' 
			' scrollersFrame1
			' 
			Me.scrollersFrame1.AttachedTo = Me.listView3
			Me.scrollersFrame1.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto
			Me.scrollersFrame1.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007Generic
			' 
			' scrollersFrame2
			' 
			Me.scrollersFrame2.AttachedTo = Me.treeView3
			Me.scrollersFrame2.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto
			Me.scrollersFrame2.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007Generic
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(557, 513)
			Me.Controls.Add(Me.tabControlAdv1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.MaximizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "GroupBar Demo"
			CType(Me.tabControlAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControlAdv1.ResumeLayout(False)
			Me.tabPageVS.ResumeLayout(False)
			CType(Me.gpVSAppearance, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gpVSAppearance.ResumeLayout(False)
			Me.gpVSAppearance.PerformLayout()
			Me.panel16.ResumeLayout(False)
			CType(Me.gpVSBehavior, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gpVSBehavior.ResumeLayout(False)
			Me.gpVSBehavior.PerformLayout()
			Me.panel15.ResumeLayout(False)
			CType(Me.gbVisualStudio, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gbVisualStudio.ResumeLayout(False)
			Me.tabPageOutlook.ResumeLayout(False)
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel3.ResumeLayout(False)
			Me.panel23.ResumeLayout(False)
			Me.panel23.PerformLayout()
			CType(Me.cbCollapse, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbAutoClose, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cbShowGripper, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.numericCollapsedWidth, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel18.ResumeLayout(False)
			CType(Me.cbAllowCollapse, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel2.ResumeLayout(False)
			Me.gradientPanel2.PerformLayout()
			Me.panel25.ResumeLayout(False)
			Me.panel25.PerformLayout()
			Me.panel17.ResumeLayout(False)
			CType(Me.gbOutlook, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gbOutlook.ResumeLayout(False)
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar1.ResumeLayout(False)
			Me.xpTaskBarBox1.ResumeLayout(False)
			Me.panel1.ResumeLayout(False)
			Me.xpTaskBarBox2.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			CType(Me.xpTaskBar6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar6.ResumeLayout(False)
			Me.xpTaskBarBox10.ResumeLayout(False)
			Me.panel8.ResumeLayout(False)
			Me.xpTaskBarBox11.ResumeLayout(False)
			Me.panel11.ResumeLayout(False)
			Me.panel14.ResumeLayout(False)
			CType(Me.xpTaskBar4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar4.ResumeLayout(False)
			Me.xpTaskBarBox7.ResumeLayout(False)
			Me.panel6.ResumeLayout(False)
			Me.xpTaskBarBox8.ResumeLayout(False)
			Me.panel9.ResumeLayout(False)
			CType(Me.xpTaskBar2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar2.ResumeLayout(False)
			Me.xpTaskBarBox3.ResumeLayout(False)
			Me.panel4.ResumeLayout(False)
			Me.xpTaskBarBox4.ResumeLayout(False)
			Me.panel7.ResumeLayout(False)
			CType(Me.xpTaskBar3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar3.ResumeLayout(False)
			Me.xpTaskBarBox5.ResumeLayout(False)
			Me.panel5.ResumeLayout(False)
			Me.xpTaskBarBox6.ResumeLayout(False)
			Me.panel3.ResumeLayout(False)
			Me.calendarPanel.ResumeLayout(False)
			CType(Me.monthCalendarAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel13.ResumeLayout(False)
			Me.panel12.ResumeLayout(False)
			CType(Me.xpTaskBar5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar5.ResumeLayout(False)
			Me.xpTaskBarBox9.ResumeLayout(False)
			Me.panel10.ResumeLayout(False)
			Me.tabPageAdvanced.ResumeLayout(False)
			CType(Me.gradientPanel7, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel7.ResumeLayout(False)
			Me.panel21.ResumeLayout(False)
			CType(Me.gradientPanel6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel6.ResumeLayout(False)
			CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel4.ResumeLayout(False)
			Me.gradientPanel4.PerformLayout()
			Me.panel19.ResumeLayout(False)
			CType(Me.gbAdvanced, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gbAdvanced.ResumeLayout(False)
			CType(Me.NestedGroupBar, System.ComponentModel.ISupportInitialize).EndInit()
			Me.NestedGroupBar.ResumeLayout(False)
			Me.panel24.ResumeLayout(False)
			Me.CustomControlsPanel.ResumeLayout(False)
			CType(Me.checkBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.monthCalendarAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel20.ResumeLayout(False)
			Me.panel22.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tabControlAdv1 As Syncfusion.Windows.Forms.Tools.TabControlAdv
		Private tabPageVS As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private tabPageAdvanced As Syncfusion.Windows.Forms.Tools.TabPageAdv
		Private GeneralGroupView As Syncfusion.Windows.Forms.Tools.GroupView
		Private ilGroupBarLarge As System.Windows.Forms.ImageList
		Private ilGroupBarSmall As System.Windows.Forms.ImageList


		Private WithEvents cbAnimatedSelection As System.Windows.Forms.CheckBox
		Private CustomControlsPanel As System.Windows.Forms.Panel
		Private monthCalendarAdv1 As Syncfusion.Windows.Forms.Tools.MonthCalendarAdv
		Private checkBoxAdv2 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private checkBoxAdv1 As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents cbflatLook As System.Windows.Forms.CheckBox
		Private PersonalGroupView As Syncfusion.Windows.Forms.Tools.GroupView
		Private WithEvents NestedGroupBar As Syncfusion.Windows.Forms.Tools.GroupBar


		Private WinFormsGroupView As Syncfusion.Windows.Forms.Tools.GroupView
		Private ComponentsGroupView As Syncfusion.Windows.Forms.Tools.GroupView
		Private gbVisualStudio As Syncfusion.Windows.Forms.Tools.GroupBar
		Private WinFormsGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private ComponentsGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private GeneralGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private WithEvents gbAdvanced As Syncfusion.Windows.Forms.Tools.GroupBar
		Private PersonalGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private OfficeGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private CustomControlsGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private NestedGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private label1 As System.Windows.Forms.Label
		Private WithEvents cmbGBBorder As System.Windows.Forms.ComboBox
		Private WithEvents cbDrawClientBorder As System.Windows.Forms.CheckBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents cmbGBVisualStyle As System.Windows.Forms.ComboBox
		Private WithEvents cmbTextAlignment As System.Windows.Forms.ComboBox
		Private label3 As System.Windows.Forms.Label
		Private WithEvents cbIntegratedScrolling As System.Windows.Forms.CheckBox
		Private label5 As System.Windows.Forms.Label
		Private WithEvents cpBack As Syncfusion.Windows.Forms.ColorPickerButton
		Private tabPageOutlook As Syncfusion.Windows.Forms.Tools.TabPageAdv


		Private label12 As System.Windows.Forms.Label
		Private label13 As System.Windows.Forms.Label
		Private WithEvents gbOutlook As Syncfusion.Windows.Forms.Tools.GroupBar
		Private MailGgroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private ContactsGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private TasksGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private NotesgroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private FolderListGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private CalendarGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private JournalGroupBarItem As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private WithEvents cbAllowCollapse As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents cmbPopupResize As System.Windows.Forms.ComboBox
		Private WithEvents numericCollapsedWidth As System.Windows.Forms.NumericUpDown
		Private label18 As System.Windows.Forms.Label
		Private WithEvents cbAutoClose As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private label15 As System.Windows.Forms.Label
		Private WithEvents cbShowGripper As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents cbCollapse As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private xpTaskBar1 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private xpTaskBarBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private panel1 As System.Windows.Forms.Panel
		Private listView3 As System.Windows.Forms.ListView
		Private columnHeader3 As System.Windows.Forms.ColumnHeader
		Private xpTaskBarBox2 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private smallImageList As System.Windows.Forms.ImageList
		Private panel2 As System.Windows.Forms.Panel
		Private treeView3 As System.Windows.Forms.TreeView
		Private panel3 As System.Windows.Forms.Panel
		Private radioButton5 As System.Windows.Forms.RadioButton
		Private radioButton4 As System.Windows.Forms.RadioButton
		Private radioButton3 As System.Windows.Forms.RadioButton
		Private radioButton2 As System.Windows.Forms.RadioButton
		Private radioButton1 As System.Windows.Forms.RadioButton
		Private panel7 As System.Windows.Forms.Panel
		Private radioButton12 As System.Windows.Forms.RadioButton
		Private radioButton11 As System.Windows.Forms.RadioButton
		Private radioButton6 As System.Windows.Forms.RadioButton
		Private radioButton7 As System.Windows.Forms.RadioButton
		Private radioButton8 As System.Windows.Forms.RadioButton
		Private radioButton9 As System.Windows.Forms.RadioButton
		Private radioButton10 As System.Windows.Forms.RadioButton
		Private xpTaskBar2 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private xpTaskBarBox3 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private panel4 As System.Windows.Forms.Panel
		Private xpTaskBarBox4 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private label9 As System.Windows.Forms.Label
		Private xpTaskBar3 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private xpTaskBarBox5 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private panel5 As System.Windows.Forms.Panel
		Private label8 As System.Windows.Forms.Label
		Private xpTaskBarBox6 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private xpTaskBar5 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private xpTaskBarBox9 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private xpTaskBar4 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private xpTaskBarBox7 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private panel6 As System.Windows.Forms.Panel
		Private label14 As System.Windows.Forms.Label
		Private xpTaskBarBox8 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private panel9 As System.Windows.Forms.Panel
		Private radioButton18 As System.Windows.Forms.RadioButton
		Private radioButton19 As System.Windows.Forms.RadioButton
		Private radioButton20 As System.Windows.Forms.RadioButton
		Private radioButton21 As System.Windows.Forms.RadioButton
		Private radioButton22 As System.Windows.Forms.RadioButton
		Private xpTaskBar6 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private xpTaskBarBox10 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private panel8 As System.Windows.Forms.Panel
		Private xpTaskBarBox11 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private calendarPanel As System.Windows.Forms.Panel
		Private gradientLabel10 As Syncfusion.Windows.Forms.Tools.GradientLabel
		Private panel13 As System.Windows.Forms.Panel
		Private label10 As System.Windows.Forms.Label
		Private label11 As System.Windows.Forms.Label
		Private panel12 As System.Windows.Forms.Panel
		Private linkLabel10 As System.Windows.Forms.LinkLabel
		Private radioButton13 As System.Windows.Forms.RadioButton
		Private radioButton14 As System.Windows.Forms.RadioButton
		Private radioButton15 As System.Windows.Forms.RadioButton
		Private radioButton16 As System.Windows.Forms.RadioButton
		Private radioButton17 As System.Windows.Forms.RadioButton
		Private panel10 As System.Windows.Forms.Panel
		Private treeView1 As System.Windows.Forms.TreeView
		Private label16 As System.Windows.Forms.Label
		Private monthCalendarAdv2 As Syncfusion.Windows.Forms.Tools.MonthCalendarAdv
		Private panel11 As System.Windows.Forms.Panel
		Private panel14 As System.Windows.Forms.Panel
		Private radioButton23 As System.Windows.Forms.RadioButton
		Private radioButton24 As System.Windows.Forms.RadioButton
		Private radioButton25 As System.Windows.Forms.RadioButton
		Private radioButton26 As System.Windows.Forms.RadioButton
		Private radioButton27 As System.Windows.Forms.RadioButton
		Private WithEvents cbChevron As System.Windows.Forms.CheckBox
		Private WithEvents cbImageInHeader As System.Windows.Forms.CheckBox
		Private WithEvents cbStackedMode As System.Windows.Forms.CheckBox
		Private WithEvents cmbOutLookGBStyle As System.Windows.Forms.ComboBox
		Private label25 As System.Windows.Forms.Label
		Private WithEvents cmbOutLookGBColorScheme As System.Windows.Forms.ComboBox
		Private label26 As System.Windows.Forms.Label
		Private gpVSAppearance As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private panel16 As System.Windows.Forms.Panel
		Private label6 As System.Windows.Forms.Label
		Private label17 As System.Windows.Forms.Label
		Private gpVSBehavior As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private panel15 As System.Windows.Forms.Panel
		Private label34 As System.Windows.Forms.Label
		Private label35 As System.Windows.Forms.Label
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private panel17 As System.Windows.Forms.Panel
		Private label23 As System.Windows.Forms.Label
		Private label27 As System.Windows.Forms.Label
		Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private panel18 As System.Windows.Forms.Panel
		Private label28 As System.Windows.Forms.Label
		Private label29 As System.Windows.Forms.Label
		Private gradientPanel4 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private panel19 As System.Windows.Forms.Panel
		Private label30 As System.Windows.Forms.Label
		Private label31 As System.Windows.Forms.Label
		Private label20 As System.Windows.Forms.Label
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private gradientPanel6 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private label24 As System.Windows.Forms.Label
		Private gradientPanel7 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private panel21 As System.Windows.Forms.Panel
		Private label36 As System.Windows.Forms.Label
		Private label37 As System.Windows.Forms.Label
		Private panel23 As System.Windows.Forms.Panel
		Private panel25 As System.Windows.Forms.Panel
		Private WithEvents cpCustomColor As Syncfusion.Windows.Forms.ColorPickerButton
		Private gvOffice As Syncfusion.Windows.Forms.Tools.GroupView
		Private label7 As System.Windows.Forms.Label
		Private label22 As System.Windows.Forms.Label
		Private label21 As System.Windows.Forms.Label
		Private groupBarItem1 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private groupBarItem2 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private panel22 As System.Windows.Forms.Panel
		Private label33 As System.Windows.Forms.Label
		Private panel20 As System.Windows.Forms.Panel
		Private label32 As System.Windows.Forms.Label
		Private listView1 As System.Windows.Forms.ListView
		Private columnHeader1 As System.Windows.Forms.ColumnHeader
		Private columnHeader2 As System.Windows.Forms.ColumnHeader
		Private imageListAdv1 As Syncfusion.Windows.Forms.Tools.ImageListAdv
		Private scrollersFrame1 As Syncfusion.Windows.Forms.ScrollersFrame
		Private groupBarItem3 As Syncfusion.Windows.Forms.Tools.GroupBarItem
		Private label19 As System.Windows.Forms.Label
		Private panel24 As System.Windows.Forms.Panel
		Private label4 As System.Windows.Forms.Label
		Private label38 As System.Windows.Forms.Label
		Private scrollersFrame2 As Syncfusion.Windows.Forms.ScrollersFrame



	End Class
End Namespace

